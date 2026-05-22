''' <summary>
''' shared maintenance form. set building_filter before load.
''' "museum" or "boutique" — passed by the host user control.
''' also handles the equipment_maintenance join table so the user can
''' associate a list of equipment items + their cost with the service.
''' </summary>
Public Class museum_maintenance
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    Public Property building_filter As String = "museum"

    'lookup map for the internal-employee combobox
    Private employee_map As New Dictionary(Of String, Integer)

    'lookup map for the equipment items used in the equipment_maintenance subform
    Private equipment_map As New Dictionary(Of String, Integer)

    Private ReadOnly Property select_sql As String
        Get
            Return "SELECT
                     m.service_id,
                     m.service_type,
                     m.servicer,
                     m.employee_id,
                     ISNULL(e.first_name + ' ' + e.last_name, '') AS employee_name,
                     m.building,
                     m.notes,
                     m.start_date,
                     m.end_date
                 FROM maintenance m
                 LEFT JOIN employees e ON m.employee_id = e.employee_id
                 WHERE m.building = @building
                "
        End Get
    End Property


    Private Sub maintenance_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_lookups()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        maintenance_grid.AutoGenerateColumns = False
        maintenance_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"service_id", {"ID", 70}},
            {"service_type", {"Type", 100}},
            {"servicer", {"Servicer", 160}},
            {"employee_name", {"Employee", 180}},
            {"start_date", {"Start", 110}},
            {"end_date", {"End", 110}},
            {"notes", {"Notes", 280}}
        }

        For Each col In cols
            add_column(maintenance_grid, col.Key, col.Value(0), col.Value(1))
        Next

        'employee_id stays in the data set but isn't displayed
        add_column(maintenance_grid, "employee_id", "employee_id", 0, False)
        maintenance_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub load_lookups()
        'employees combo — only active employees
        load_combo(
            employee_input,
            employee_map,
            "
            SELECT employee_id, first_name + ' ' + last_name AS full_name
            FROM employees
            WHERE is_active = 1
            ORDER BY full_name",
            "employee_id",
            "full_name"
        )

        'equipment combo for the equipment_maintenance subform — same building only
        load_combo(
            equipment_input,
            equipment_map,
            "SELECT item_id, item_name FROM equipment WHERE building = '" & building_filter & "' ORDER BY item_name",
            "item_id",
            "item_name"
        )

        'service type combo
        type_input.Items = New String() {}
        For Each enum_name In [Enum].GetNames(GetType(ServiceType))
            type_input.AddItem(enum_name.ToLower())
        Next

        type_input.SelectedIndex = -1
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
            sql = select_sql & " ORDER BY m.start_date DESC"
        Else
            sql = select_sql &
                "
                AND (
                    m.service_type LIKE @term OR
                    ISNULL(m.servicer, '') LIKE @term OR
                    ISNULL(e.first_name + ' ' + e.last_name, '') LIKE @term OR
                    m.notes LIKE @term OR
                    CAST(m.service_id AS NVARCHAR(20)) LIKE @term OR
                    FORMAT(m.start_date, 'MMM d, yyyy') LIKE @term OR
                    FORMAT(m.end_date, 'MMM d, yyyy') LIKE @term
                )
                ORDER BY m.start_date DESC
                "
            params("term") = "%" & term & "%"
        End If

        Try
            maintenance_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    'show/hide the right inputs depending on whether it's internal or external
    'internal needs an employee_id, external needs a servicer name
    Private Sub type_input_selected_index_changed(sender As Object, e As EventArgs) Handles type_input.SelectedIndexChanged
        If type_input.SelectedItem Is Nothing Then Return
        Dim t = type_input.SelectedItem.ToString()

        If t = "internal" Then
            employee_input.Enabled = True
            servicer_input.Enabled = False
            servicer_input.Text = ""
        Else
            employee_input.Enabled = False
            employee_input.SelectedIndex = -1
            servicer_input.Enabled = True
        End If
    End Sub


    'add the currently-selected equipment + cost to the local list
    Private Sub add_equipment_btn_click(sender As Object, e As EventArgs) Handles add_equipment_btn.Click
        If equipment_input.SelectedItem Is Nothing Then
            Vip.Notification.Alert.ShowWarning("Select an equipment item first.")
            Return
        End If

        Dim cost As Decimal
        If Not Decimal.TryParse(equipment_cost_input.Text.Trim(), cost) OrElse cost <= 0 Then
            Vip.Notification.Alert.ShowWarning("Enter a positive cost.")
            Return
        End If

        Dim item_name = equipment_input.SelectedItem.ToString()
        Dim item_id = equipment_map(item_name)

        'avoid duplicates — schema enforces it via PK anyway
        For Each lvi As ListViewItem In equipment_list.Items
            If CInt(lvi.Tag) = item_id Then
                Vip.Notification.Alert.ShowWarning("That item is already in the list.")
                Return
            End If
        Next

        Dim row As New ListViewItem(item_name)
        row.SubItems.Add(cost.ToString("C2"))
        row.Tag = item_id
        equipment_list.Items.Add(row)

        equipment_input.SelectedIndex = -1
        equipment_cost_input.Text = ""
    End Sub


    'remove the currently-selected listview row
    Private Sub remove_equipment_btn_click(sender As Object, e As EventArgs) Handles remove_equipment_btn.Click
        If equipment_list.SelectedItems.Count = 0 Then Return
        equipment_list.Items.Remove(equipment_list.SelectedItems(0))
    End Sub


    'pre-fill the equipment list when editing a service
    Private Sub load_existing_equipment(service_id As Integer)
        equipment_list.Items.Clear()

        Dim rows = db_obj.fetch(
            "SELECT em.item_id, eq.item_name, em.cost
             FROM equipment_maintenance em
             INNER JOIN equipment eq ON em.item_id = eq.item_id
             WHERE em.service_id = @service_id",
            New Dictionary(Of String, Object) From {{"service_id", service_id}}
        )

        For Each row In rows
            Dim lvi As New ListViewItem(row("item_name").ToString())
            lvi.SubItems.Add(CDec(row("cost")).ToString("C2"))
            lvi.Tag = Convert.ToInt32(row("item_id"))
            equipment_list.Items.Add(lvi)
        Next
    End Sub


    'wipe and re-insert the join rows
    ' TODO: make sense of this
    Private Sub save_equipment_links(service_id As Integer)
        db_obj.execute("DELETE FROM equipment_maintenance WHERE service_id = @service_id",
                       New Dictionary(Of String, Object) From {{"service_id", service_id}})

        For Each lvi As ListViewItem In equipment_list.Items
            Dim item_id = CInt(lvi.Tag)
            'parse the cost back from the formatted display
            Dim cost_str = lvi.SubItems(1).Text.Replace("$", "").Replace(",", "")
            Dim cost As Decimal
            Decimal.TryParse(cost_str, cost)

            db_obj.execute(
                "INSERT INTO equipment_maintenance (service_id, item_id, cost) VALUES (@service_id, @item_id, @cost)",
                New Dictionary(Of String, Object) From {
                    {"service_id", service_id},
                    {"item_id", item_id},
                    {"cost", cost}
                }
            )
        Next
    End Sub


    Private Sub do_insert()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            Vip.Notification.Alert.ShowWarning(err)
            Return
        End If

        Try
            'insert maintenance row, then grab the new id and save the equipment links
            db_obj.execute(
                "
                INSERT INTO maintenance
                    (service_type, servicer, employee_id, building, notes, start_date, end_date)
                VALUES
                    (@service_type, @servicer, @employee_id, @building, @notes, @start_date, @end_date)
                ", build_params())

            ' TODO: make sense of this
            Dim new_id = CInt(db_obj.fetch_val("SELECT IDENT_CURRENT('maintenance')"))
            save_equipment_links(new_id)

            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess("Maintenance service recorded.")
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
            p("service_id") = editing_id

            db_obj.execute(
                "
                UPDATE maintenance
                SET service_type = @service_type,
                    servicer     = @servicer,
                    employee_id  = @employee_id,
                    notes        = @notes,
                    start_date   = @start_date,
                    end_date     = @end_date
                WHERE service_id = @service_id
                ", p)

            save_equipment_links(editing_id)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated service #{updated_id}.")
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


    Private Sub maintenance_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles maintenance_grid.DataBindingComplete
        populate_row_numbers(maintenance_grid)
    End Sub


    Private Sub maintenance_grid_sorted(sender As Object, e As EventArgs) Handles maintenance_grid.Sorted
        populate_row_numbers(maintenance_grid)
    End Sub


    Private Async Sub maintenance_grid_key_down(sender As Object, e As KeyEventArgs) Handles maintenance_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If maintenance_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(maintenance_grid.SelectedRows(0).Cells("service_id").Value)

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete service #{selected_id}? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM maintenance WHERE service_id = @service_id",
                New Dictionary(Of String, Object) From {{"service_id", selected_id}})
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted service #{selected_id}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub maintenance_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles maintenance_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = maintenance_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("service_id").Value)

        go_to_manage()
        load_lookups()

        select_combo(type_input, row.Cells("service_type").Value?.ToString())

        Dim servicer_val = row.Cells("servicer").Value
        servicer_input.Text = If(IsDBNull(servicer_val), "", servicer_val?.ToString())

        Dim emp_id_val = row.Cells("employee_id").Value
        If Not IsDBNull(emp_id_val) AndAlso emp_id_val IsNot Nothing Then
            select_combo(employee_input, row.Cells("employee_name").Value?.ToString())
        End If

        notes_input.Text = row.Cells("notes").Value?.ToString()
        start_date_input.Content = Convert.ToDateTime(row.Cells("start_date").Value)
        end_date_input.Content = Convert.ToDateTime(row.Cells("end_date").Value)

        load_existing_equipment(editing_id)
        set_mode(FormMode.Edit)
    End Sub


    Private Sub maintenance_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles maintenance_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = maintenance_grid.Columns(e.ColumnIndex).Name

        If (col = "start_date" OrElse col = "end_date") AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
            e.Value = CDate(e.Value).ToString("MMM d, yyyy")
            e.FormattingApplied = True
        End If

        If col = "servicer" AndAlso (e.Value Is Nothing OrElse IsDBNull(e.Value) OrElse String.IsNullOrEmpty(e.Value.ToString())) Then
            e.Value = "—"
            e.FormattingApplied = True
        End If

        If col = "employee_name" AndAlso (e.Value Is Nothing OrElse IsDBNull(e.Value) OrElse String.IsNullOrEmpty(e.Value.ToString())) Then
            e.Value = "—"
            e.FormattingApplied = True
        End If
    End Sub


    ' if you press `Esc` while on the `manage` tab, it's as if you clicked the cancel button
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, key_data As Keys) As Boolean
        If key_data = Keys.Escape AndAlso tbc.SelectedIndex = 1 Then
            cancel_btn_click(Nothing, EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, key_data)
    End Function


    Private Sub confirm_btn_click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        Select Case current_mode
            Case FormMode.Add
                do_insert()
            Case FormMode.Edit
                do_update()
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
        Dim type_str = If(type_input.SelectedItem Is Nothing, "", type_input.SelectedItem.ToString())

        'internal → employee_id set, servicer null
        'external → servicer set, employee_id null
        Dim emp_id_val As Object = DBNull.Value
        Dim servicer_val As Object = DBNull.Value

        If type_str = "internal" Then
            emp_id_val = get_combo_id(employee_input, employee_map)
        Else
            servicer_val = servicer_input.Text.Trim()
        End If

        Return New Dictionary(Of String, Object) From {
            {"service_type", type_str},
            {"servicer", servicer_val},
            {"employee_id", emp_id_val},
            {"building", building_filter},
            {"notes", notes_input.Text.Trim()},
            {"start_date", start_date_input.Content.Date},
            {"end_date", end_date_input.Content.Date}
        }
    End Function


    Private Sub clear_inputs()
        servicer_input.Text = ""
        notes_input.Text = ""
        equipment_cost_input.Text = ""

        ' TODO: make sense of these
        start_date_input.Content = DateTime.Today
        end_date_input.Content = DateTime.Today.AddDays(1)

        type_input.SelectedIndex = -1
        employee_input.SelectedIndex = -1
        equipment_input.SelectedIndex = -1
        equipment_list.Items.Clear()
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If type_input.SelectedIndex = -1 Then Return "Select a service type."

        Dim t = type_input.SelectedItem.ToString()
        If t = "internal" AndAlso get_combo_id(employee_input, employee_map) = 0 Then
            Return "Internal services require an employee."
        End If
        If t = "external" AndAlso String.IsNullOrWhiteSpace(servicer_input.Text) Then
            Return "External services require a servicer name."
        End If

        If String.IsNullOrWhiteSpace(notes_input.Text) Then Return "Notes are required."
        If end_date_input.Content.Date <= start_date_input.Content.Date Then
            Return "End date must be after start date."
        End If

        Return Nothing
    End Function

End Class