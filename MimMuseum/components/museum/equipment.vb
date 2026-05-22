''' <summary>
''' Shared equipment form. Set building_filter before load.
''' "museum" or "boutique" — passed by the host UserControl.
''' </summary>
''' 
Public Class museum_equipment
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    Public Property building_filter As String = "museum"

    Private category_map As New Dictionary(Of String, Integer)

    Private ReadOnly Property select_sql As String
        Get
            Return "SELECT
                     eq.item_id,
                     eq.item_name,
                     ic.category_name,
                     eq.supplier,
                     eq.cost,
                     eq.item_status,
                     eq.building,
                     eq.item_desc,
                     eq.purchase_date
                 FROM equipment eq
                 INNER JOIN items_categories ic ON eq.category_id = ic.category_id
                 WHERE eq.building = @building
                "
        End Get
    End Property


    Private Sub equipment_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_lookups()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        equipment_grid.AutoGenerateColumns = False
        equipment_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"item_id", {"ID", 70}},
            {"item_name", {"Name", 180}},
            {"category_name", {"Category", 140}},
            {"supplier", {"Supplier", 150}},
            {"cost", {"Cost", 90}},
            {"item_status", {"Status", 100}},
            {"purchase_date", {"Purchase Date", 130}},
            {"item_desc", {"Description", 240}}
        }

        For Each col In cols
            add_column(equipment_grid, col.Key, col.Value(0), col.Value(1))
        Next

        equipment_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub load_lookups()
        load_combo(
            category_input,
            category_map,
            "SELECT category_id, category_name FROM items_categories ORDER BY category_name",
            "category_id",
            "category_name"
        )

        'item status combo (convert PascalCase to snake_case for InRepair)
        status_input.Items = New String() {}
        For Each enum_name In [Enum].GetNames(GetType(ItemStatus))
            Dim db_value = If(enum_name = "InRepair", "in_repair", enum_name.ToLower())
            status_input.AddItem(db_value)
        Next
        status_input.SelectedIndex = -1
    End Sub


    Private Sub set_mode(new_mode As FormMode)
        current_mode = new_mode

        Select Case current_mode
            Case FormMode.Add
                confirm_btn.Text = "Add"
                mode_lbl.Content = "Mode: ADD"
                mode_lbl.ForeColor = Color.FromArgb(98, 252, 170)
            Case FormMode.Edit
                confirm_btn.Text = "Update"
                mode_lbl.Content = "Mode: EDIT"
                mode_lbl.ForeColor = Color.FromArgb(255, 170, 0)
        End Select
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()
        Dim sql As String
        Dim params As New Dictionary(Of String, Object)
        params("building") = building_filter

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY eq.item_name"
        Else
            sql = select_sql &
                "
                AND (
                    eq.item_name      LIKE @term OR
                    ic.category_name  LIKE @term OR
                    eq.supplier       LIKE @term OR
                    eq.item_status    LIKE @term OR
                    eq.item_desc      LIKE @term OR
                    CAST(eq.item_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(eq.cost AS NVARCHAR(30)) LIKE @term OR
                    FORMAT(eq.purchase_date, 'MMM d, yyyy') LIKE @term
                )
                ORDER BY eq.item_name
                "
            params("term") = "%" & term & "%"
        End If

        Try
            equipment_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    Private Sub do_insert()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            Vip.Notification.Alert.ShowWarning(err)
            Return
        End If

        Try
            db_obj.execute(
                "
                INSERT INTO equipment
                    (item_name, category_id, supplier, cost, item_status, building, item_desc, purchase_date)
                VALUES
                    (@item_name, @category_id, @supplier, @cost, @item_status, @building, @item_desc, @purchase_date)
                ", build_params())

            Dim name = name_input.Text.Trim()
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Added equipment '{name}'.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Insert error: {ex.Message}")
        End Try
    End Sub


    Private Sub do_update()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            Vip.Notification.Alert.ShowWarning(err)
            Return
        End If

        Try
            Dim p = build_params()
            p("item_id") = editing_id

            db_obj.execute(
                "
                UPDATE equipment
                SET item_name     = @item_name,
                    category_id   = @category_id,
                    supplier      = @supplier,
                    cost          = @cost,
                    item_status   = @item_status,
                    item_desc     = @item_desc,
                    purchase_date = @purchase_date
                WHERE item_id     = @item_id
                ", p)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated equipment #{updated_id}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Update error: {ex.Message}")
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    Private Sub tab_control_selected_index_changed(sender As Object, e As EventArgs) Handles tbc.SelectedIndexChanged
        If tbc.SelectedIndex = 0 AndAlso current_mode = FormMode.Edit Then
            clear_inputs()
            set_mode(FormMode.Add)
        End If

        If tbc.SelectedIndex = 1 Then
            load_lookups()
        End If
    End Sub


    Private Sub equipment_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles equipment_grid.DataBindingComplete
        populate_row_numbers(equipment_grid)
    End Sub


    Private Sub equipment_grid_sorted(sender As Object, e As EventArgs) Handles equipment_grid.Sorted
        populate_row_numbers(equipment_grid)
    End Sub


    Private Async Sub equipment_grid_key_down(sender As Object, e As KeyEventArgs) Handles equipment_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If equipment_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(equipment_grid.SelectedRows(0).Cells("item_id").Value)
        Dim name = equipment_grid.SelectedRows(0).Cells("item_name").Value?.ToString()

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete equipment '{name}'? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM equipment WHERE item_id = @item_id",
                New Dictionary(Of String, Object) From {{"item_id", selected_id}})
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted equipment '{name}'.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub equipment_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles equipment_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = equipment_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("item_id").Value)

        go_to_manage()

        name_input.Text = row.Cells("item_name").Value?.ToString()
        supplier_input.Text = row.Cells("supplier").Value?.ToString()
        cost_input.Text = row.Cells("cost").Value?.ToString()
        desc_input.Text = row.Cells("item_desc").Value?.ToString()
        date_input.Content = Convert.ToDateTime(row.Cells("purchase_date").Value)

        select_combo(category_input, row.Cells("category_name").Value?.ToString())
        select_combo(status_input, row.Cells("item_status").Value?.ToString())

        set_mode(FormMode.Edit)
    End Sub


    Private Sub equipment_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles equipment_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = equipment_grid.Columns(e.ColumnIndex).Name

        If col = "purchase_date" Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
                e.Value = CDate(e.Value).ToString("MMM d, yyyy")
                e.FormattingApplied = True
            End If
        End If

        If col = "cost" Then
            If e.Value IsNot Nothing Then
                e.Value = CDec(e.Value).ToString("C2")
                e.FormattingApplied = True
            End If
        End If

        If col = "item_status" Then
            If e.Value IsNot Nothing Then
                Dim status = e.Value.ToString()
                'e.CellStyle.ForeColor = Select Case status
                '    Case "active" : Color.FromArgb(104, 252, 143)
                'Case "in_repair" : Color.FromArgb(255, 200, 0)
                'Case Else : Color.FromArgb(255, 128, 128)
                'End Select
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                e.FormattingApplied = True
            End If
        End If
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, key_data As Keys) As Boolean
        If key_data = Keys.Escape AndAlso tbc.SelectedIndex = 1 Then
            cancel_btn_click(Nothing, EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, key_data)
    End Function


    Private Sub confirm_btn_click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        Select Case current_mode
            Case FormMode.Add : do_insert()
            Case FormMode.Edit : do_update()
        End Select
    End Sub


    Private Sub cancel_btn_click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        clear_inputs()
        set_mode(FormMode.Add)
        go_to_browse()
    End Sub


    Private Sub go_to_browse()
        tbc.SelectedIndex = 0
    End Sub


    Private Sub go_to_manage()
        tbc.SelectedIndex = 1
    End Sub


    Private Function build_params() As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From {
            {"item_name", name_input.Text.Trim()},
            {"category_id", get_combo_id(category_input, category_map)},
            {"supplier", supplier_input.Text.Trim()},
            {"cost", CDec(cost_input.Text.Trim())},
            {"item_status", status_input.SelectedItem.ToString()},
            {"building", building_filter},
            {"item_desc", desc_input.Text.Trim()},
            {"purchase_date", date_input.Content.Date}
        }
    End Function


    Private Sub clear_inputs()
        name_input.Text = ""
        supplier_input.Text = ""
        cost_input.Text = ""
        desc_input.Text = ""
        date_input.Content = DateTime.Today
        category_input.SelectedIndex = -1
        status_input.SelectedIndex = -1
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(name_input.Text) Then Return "Item name required."
        If get_combo_id(category_input, category_map) = 0 Then Return "Select a category."
        If String.IsNullOrWhiteSpace(supplier_input.Text) Then Return "Supplier required."
        Dim cost_val As Decimal
        If Not Decimal.TryParse(cost_input.Text.Trim(), cost_val) OrElse cost_val <= 0 Then Return "Cost must be a positive number."
        If status_input.SelectedIndex = -1 Then Return "Select a status."
        If String.IsNullOrWhiteSpace(desc_input.Text) Then Return "Description required."
        If date_input.Content.Date > DateTime.Today Then Return "Purchase date cannot be in the future."
        Return Nothing
    End Function

End Class