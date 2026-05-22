''' <summary>
''' boutique inventory form. supports image upload for each item,
''' optional mineral reference, soft delete via is_active toggle.
''' low-stock items (≤5 units) highlighted in red.
''' </summary>
Public Class inventory
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    'optional mineral reference — items can reference a mineral or be standalone
    Private mineral_map As New Dictionary(Of String, String)

    'tracks the source file path when user uploads a new image (Nothing if no new upload)
    Private pending_image_path As String = Nothing

    'existing filename when editing (so we know what to delete if replaced)
    Private existing_image_filename As String = Nothing

    Private Const select_sql As String =
        "SELECT
             b.item_id,
             b.item_name,
             b.unit_price,
             b.quantity,
             b.date_added,
             b.image_filename,
             b.is_active,
             b.ref_mineral,
             m.mineral_name
         FROM boutique_items b
         LEFT JOIN minerals m ON b.ref_mineral = m.mineral_tag
         WHERE b.is_active = 1
        "


    Private Sub inventory_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_lookups()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        inventory_grid.AutoGenerateColumns = False
        inventory_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"item_id", {"ID", 70}},
            {"item_name", {"Item Name", 200}},
            {"unit_price", {"Price", 100}},
            {"quantity", {"Stock", 80}},
            {"mineral_name", {"Ref Mineral", 180}},
            {"date_added", {"Added", 120}}
        }

        For Each col In cols
            add_column(inventory_grid, col.Key, col.Value(0), col.Value(1))
        Next

        add_column(inventory_grid, "ref_mineral", "ref_mineral", 0, False)
        add_column(inventory_grid, "is_active", "is_active", 0, False)
        add_column(inventory_grid, "image_filename", "image_filename", 0, False)

        inventory_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub load_lookups()
        mineral_map.Clear()
        mineral_input.Items = New String() {}

        mineral_input.AddItem("— None —")

        For Each row In db_obj.fetch("SELECT mineral_tag, mineral_name FROM minerals ORDER BY mineral_name")
            Dim name = row("mineral_name").ToString()
            Dim tag = row("mineral_tag").ToString()
            mineral_map(name) = tag
            mineral_input.AddItem(name)
        Next

        mineral_input.SelectedIndex = -1
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

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY b.item_name"
        Else
            sql = select_sql &
                "
                AND (
                    b.item_name LIKE @term OR
                    ISNULL(m.mineral_name, '') LIKE @term OR
                    CAST(b.item_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(b.unit_price AS NVARCHAR(20)) LIKE @term OR
                    CAST(b.quantity AS NVARCHAR(20)) LIKE @term OR
                    FORMAT(b.date_added, 'MMM d, yyyy') LIKE @term
                )
                ORDER BY b.item_name
                "
            params("term") = "%" & term & "%"
        End If

        Try
            inventory_grid.DataSource = db_obj.fetch_datatable(sql, params)
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
                INSERT INTO boutique_items (item_name, unit_price, quantity, date_added, ref_mineral, image_filename, is_active)
                VALUES (@item_name, @unit_price, @quantity, @date_added, @ref_mineral, @image_filename, 1)
                ", build_params())

            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess("Item added to inventory.")
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
                UPDATE boutique_items
                SET item_name      = @item_name,
                    unit_price     = @unit_price,
                    quantity       = @quantity,
                    date_added     = @date_added,
                    ref_mineral    = @ref_mineral,
                    image_filename = @image_filename,
                    is_active      = @is_active
                WHERE item_id      = @item_id
                ", p)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated item #{updated_id}.")
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


    Private Sub inventory_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles inventory_grid.DataBindingComplete
        populate_row_numbers(inventory_grid)
    End Sub


    Private Sub inventory_grid_sorted(sender As Object, e As EventArgs) Handles inventory_grid.Sorted
        populate_row_numbers(inventory_grid)
    End Sub


    Private Async Sub inventory_grid_key_down(sender As Object, e As KeyEventArgs) Handles inventory_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If inventory_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(inventory_grid.SelectedRows(0).Cells("item_id").Value)
        Dim item_name = inventory_grid.SelectedRows(0).Cells("item_name").Value?.ToString()

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Archive item '{item_name}'? It will be hidden from POS.",
                                "Confirm Archive",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            'soft delete — set is_active = 0
            db_obj.execute(
                "UPDATE boutique_items SET is_active = 0 WHERE item_id = @item_id",
                New Dictionary(Of String, Object) From {{"item_id", selected_id}})
            run_search()
            Vip.Notification.Alert.ShowSucess($"Archived item '{item_name}'.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Archive error: {ex.Message}")
        End Try
    End Sub


    Private Sub inventory_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles inventory_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = inventory_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("item_id").Value)

        go_to_manage()

        item_name_input.Text = row.Cells("item_name").Value?.ToString()
        price_input.Text = row.Cells("unit_price").Value?.ToString()
        quantity_input.Text = row.Cells("quantity").Value?.ToString()
        date_added_input.Content = Convert.ToDateTime(row.Cells("date_added").Value)

        Dim mineral_name_val = row.Cells("mineral_name").Value
        If IsDBNull(mineral_name_val) OrElse mineral_name_val Is Nothing Then
            select_combo(mineral_input, "— None —")
        Else
            select_combo(mineral_input, mineral_name_val.ToString())
        End If

        'load existing image via image_helpers
        pending_image_path = Nothing
        Dim image_filename_val = row.Cells("image_filename").Value
        If Not IsDBNull(image_filename_val) AndAlso image_filename_val IsNot Nothing AndAlso Not String.IsNullOrEmpty(image_filename_val.ToString()) Then
            existing_image_filename = image_filename_val.ToString()
            Dim img_path = get_item_image_path(existing_image_filename)
            If img_path IsNot Nothing Then
                'load via FileStream so the file doesn't stay locked
                Using fs As New IO.FileStream(img_path, IO.FileMode.Open, IO.FileAccess.Read)
                    preview_picture.Image = Image.FromStream(fs)
                End Using
            Else
                preview_picture.Image = get_placeholder_image()
            End If
        Else
            existing_image_filename = Nothing
            preview_picture.Image = Nothing
        End If

        set_mode(FormMode.Edit)
    End Sub


    'highlight low-stock items (≤5) in red
    Private Sub inventory_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles inventory_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = inventory_grid.Columns(e.ColumnIndex).Name

        If col = "date_added" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
            e.Value = CDate(e.Value).ToString("MMM d, yyyy")
            e.FormattingApplied = True
        End If

        If col = "unit_price" AndAlso e.Value IsNot Nothing Then
            e.Value = CDec(e.Value).ToString("C2")
            e.FormattingApplied = True
        End If

        If col = "mineral_name" Then
            If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
                e.Value = "—"
                e.FormattingApplied = True
            End If
        End If

        Dim qty = CInt(inventory_grid.Rows(e.RowIndex).Cells("quantity").Value)
        If qty <= 5 Then
            e.CellStyle.BackColor = Color.FromArgb(255, 105, 94)
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


    Private Sub upload_image_btn_click(sender As Object, e As EventArgs) Handles upload_image_btn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.webp"
            ofd.Title = "Select Item Image"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    'load via FileStream so the source file doesn't stay locked
                    Using fs As New IO.FileStream(ofd.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                        preview_picture.Image = Image.FromStream(fs)
                    End Using
                    pending_image_path = ofd.FileName
                Catch ex As Exception
                    Vip.Notification.Alert.ShowError($"Image load error: {ex.Message}")
                End Try
            End If
        End Using
    End Sub


    Private Sub remove_image_btn_click(sender As Object, e As EventArgs) Handles remove_image_btn.Click
        preview_picture.Image = Nothing
        pending_image_path = Nothing
    End Sub


    Private Sub go_to_browse()
        tbc.SelectedIndex = 0
    End Sub


    Private Sub go_to_manage()
        tbc.SelectedIndex = 1
    End Sub


    Private Function build_params() As Dictionary(Of String, Object)
        Dim mineral_label = If(mineral_input.SelectedItem Is Nothing, "", mineral_input.SelectedItem.ToString())
        Dim ref_mineral_val As Object
        If mineral_label = "— None —" OrElse String.IsNullOrEmpty(mineral_label) Then
            ref_mineral_val = DBNull.Value
        Else
            ref_mineral_val = mineral_map(mineral_label)
        End If

        'image handling — three cases:
        '  1. user uploaded a new image → save it, delete old one if editing
        '  2. user kept existing image → reuse the existing filename
        '  3. user removed the image → null + delete old file if editing
        Dim image_filename_val As Object = DBNull.Value

        If pending_image_path IsNot Nothing Then
            'case 1: new upload — save it via image_helpers
            Try
                Dim new_filename = save_item_image(pending_image_path)
                image_filename_val = new_filename
                'delete the old one if we were editing
                If Not String.IsNullOrEmpty(existing_image_filename) Then
                    Try
                        delete_item_image(existing_image_filename)
                    Catch ex As Exception
                        'silently ignore — old file cleanup isn't critical
                    End Try
                End If
            Catch ex As Exception
                Vip.Notification.Alert.ShowWarning($"Could not save new image: {ex.Message}")
                image_filename_val = If(existing_image_filename, CObj(DBNull.Value), CObj(DBNull.Value))
            End Try
        ElseIf preview_picture.Image IsNot Nothing AndAlso Not String.IsNullOrEmpty(existing_image_filename) Then
            'case 2: kept existing
            image_filename_val = existing_image_filename
        Else
            'case 3: removed — delete old file if any
            If Not String.IsNullOrEmpty(existing_image_filename) Then
                Try
                    delete_item_image(existing_image_filename)
                Catch ex As Exception
                    'silently ignore
                End Try
            End If
        End If

        Return New Dictionary(Of String, Object) From {
            {"item_name", item_name_input.Text.Trim()},
            {"unit_price", CDec(price_input.Text.Trim())},
            {"quantity", CInt(quantity_input.Text.Trim())},
            {"date_added", date_added_input.Content.Date},
            {"ref_mineral", ref_mineral_val},
            {"image_filename", image_filename_val},
            {"is_active", 1}
        }
    End Function


    Private Sub clear_inputs()
        item_name_input.Text = ""
        price_input.Text = ""
        quantity_input.Text = ""
        date_added_input.Content = DateTime.Today
        mineral_input.SelectedIndex = -1
        preview_picture.Image = Nothing
        pending_image_path = Nothing
        existing_image_filename = Nothing
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(item_name_input.Text) Then Return "Item name required."

        Dim price As Decimal
        If Not Decimal.TryParse(price_input.Text.Trim(), price) OrElse price <= 0 Then
            Return "Price must be a positive number."
        End If

        Dim qty As Integer
        If Not Integer.TryParse(quantity_input.Text.Trim(), qty) OrElse qty < 0 Then
            Return "Quantity must be a non-negative integer."
        End If

        If date_added_input.Content.Date > DateTime.Today Then
            Return "Date added cannot be in the future."
        End If

        Return Nothing
    End Function

End Class