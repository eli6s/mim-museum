''' <summary>
''' events form. manages events with staff assignment (employees) and
''' attendee registration (guests) via CheckedListBox controls for the
''' many-to-many relationships.
''' </summary>
Public Class events
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    'parallel id lists for the checklists since CheckedListBox items can't carry tags
    Private employee_ids As New List(Of Integer)
    Private attendee_ids As New List(Of Integer)


    Private Const select_sql As String =
        "SELECT
             event_id,
             event_name,
             total_guests,
             event_status,
             event_date,
             start_time,
             end_time
         FROM events
        "

    Private Sub events_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_status_combo()
        load_employees_checklist()
        load_attendees_checklist()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        events_grid.AutoGenerateColumns = False
        events_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"event_id", {"ID", 70}},
            {"event_name", {"Event Name", 220}},
            {"total_guests", {"Capacity", 100}},
            {"event_status", {"Status", 110}},
            {"event_date", {"Date", 130}},
            {"start_time", {"Start Time", 110}},
            {"end_time", {"End Time", 110}}
        }

        For Each col In cols
            add_column(events_grid, col.Key, col.Value(0), col.Value(1))
        Next

        events_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub load_status_combo()
        status_input.Items = New String() {}
        For Each enum_name In [Enum].GetNames(GetType(EventStatus))
            status_input.AddItem(enum_name.ToLower())
        Next
        status_input.SelectedIndex = -1
    End Sub


    Private Sub load_employees_checklist()
        employees_checklist.Items.Clear()
        employee_ids.Clear()

        'only active museum employees (manager + assistant)
        Dim sql = "
            SELECT e.employee_id, e.first_name + ' ' + e.last_name AS full_name
            FROM employees e
            INNER JOIN positions p ON e.position_id = p.position_id
            WHERE e.is_active = 1 AND p.position_title IN ('manager', 'assistant')
            ORDER BY full_name
        "

        For Each row In db_obj.fetch(sql)
            Dim full_name = row("full_name").ToString()
            Dim emp_id = Convert.ToInt32(row("employee_id"))
            employees_checklist.Items.Add(full_name, False)
            employee_ids.Add(emp_id)
        Next
    End Sub


    Private Sub load_attendees_checklist()
        attendees_checklist.Items.Clear()
        attendee_ids.Clear()

        For Each row In db_obj.fetch("SELECT guest_id, first_name + ' ' + last_name AS full_name FROM guests ORDER BY full_name")
            Dim full_name = row("full_name").ToString()
            Dim guest_id = Convert.ToInt32(row("guest_id"))
            attendees_checklist.Items.Add(full_name, False)
            attendee_ids.Add(guest_id)
        Next
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
            sql = select_sql & " ORDER BY event_date DESC"
        Else
            sql = select_sql &
                "
                WHERE
                    event_name LIKE @term OR
                    event_status LIKE @term OR
                    CAST(event_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(total_guests AS NVARCHAR(20)) LIKE @term OR
                    FORMAT(event_date, 'MMM d, yyyy') LIKE @term OR
                    FORMAT(start_time, 'hh:mm tt') LIKE @term OR
                    FORMAT(end_time, 'hh:mm tt') LIKE @term
                ORDER BY event_date DESC
                "
            params("term") = "%" & term & "%"
        End If

        Try
            events_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            MessageBox.Show($"Search error: {ex.Message}")
        End Try
    End Sub


    'pre-check employees who are assigned to this event
    Private Sub load_event_employees(event_id As Integer)
        Dim assigned = db_obj.fetch(
            "SELECT employee_id FROM events_employees WHERE event_id = @event_id",
            New Dictionary(Of String, Object) From {{"event_id", event_id}}
        )

        Dim assigned_ids = assigned.Select(Function(r) CInt(r("employee_id"))).ToList()

        For i = 0 To employees_checklist.Items.Count - 1
            employees_checklist.SetItemChecked(i, assigned_ids.Contains(employee_ids(i)))
        Next
    End Sub


    'pre-check guests who are registered for this event
    Private Sub load_event_attendees(event_id As Integer)
        Dim registered = db_obj.fetch(
            "SELECT guest_id FROM events_attendees WHERE event_id = @event_id",
            New Dictionary(Of String, Object) From {{"event_id", event_id}}
        )

        Dim registered_ids = registered.Select(Function(r) CInt(r("guest_id"))).ToList()

        For i = 0 To attendees_checklist.Items.Count - 1
            attendees_checklist.SetItemChecked(i, registered_ids.Contains(attendee_ids(i)))
        Next
    End Sub


    'wipe and re-insert the events_employees join rows
    Private Sub save_event_employees(event_id As Integer)
        db_obj.execute(
            "DELETE FROM events_employees WHERE event_id = @event_id",
            New Dictionary(Of String, Object) From {{"event_id", event_id}}
        )

        For i = 0 To employees_checklist.Items.Count - 1
            If employees_checklist.GetItemChecked(i) Then
                db_obj.execute(
                    "INSERT INTO events_employees (event_id, employee_id) VALUES (@event_id, @employee_id)",
                    New Dictionary(Of String, Object) From {
                        {"event_id", event_id},
                        {"employee_id", employee_ids(i)}
                    }
                )
            End If
        Next
    End Sub


    'wipe and re-insert the events_attendees join rows
    Private Sub save_event_attendees(event_id As Integer)
        db_obj.execute(
            "DELETE FROM events_attendees WHERE event_id = @event_id",
            New Dictionary(Of String, Object) From {{"event_id", event_id}}
        )

        For i = 0 To attendees_checklist.Items.Count - 1
            If attendees_checklist.GetItemChecked(i) Then
                db_obj.execute(
                    "INSERT INTO events_attendees (event_id, guest_id) VALUES (@event_id, @guest_id)",
                    New Dictionary(Of String, Object) From {
                        {"event_id", event_id},
                        {"guest_id", attendee_ids(i)}
                    }
                )
            End If
        Next
    End Sub


    Private Sub do_insert()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            MessageBox.Show(err)
            Return
        End If

        Try
            db_obj.execute(
                "
                INSERT INTO events (event_name, total_guests, event_status, event_date, start_time, end_time)
                VALUES (@event_name, @total_guests, @event_status, @event_date, @start_time, @end_time)
                ", build_params())

            Dim new_id = CInt(db_obj.fetch_val("SELECT IDENT_CURRENT('events')"))

            save_event_employees(new_id)
            save_event_attendees(new_id)

            clear_inputs()
            go_to_browse()
            run_search()
            MessageBox.Show("Event created.")
        Catch ex As Exception
            MessageBox.Show($"Insert error: {ex.Message}")
        End Try
    End Sub


    Private Sub do_update()
        Dim err = validate_inputs()
        If err IsNot Nothing Then
            MessageBox.Show(err)
            Return
        End If

        Try
            Dim p = build_params()
            p("event_id") = editing_id

            db_obj.execute(
                "
                UPDATE events
                SET event_name   = @event_name,
                    total_guests = @total_guests,
                    event_status = @event_status,
                    event_date   = @event_date,
                    start_time   = @start_time,
                    end_time     = @end_time
                WHERE event_id   = @event_id
                ", p)

            save_event_employees(editing_id)
            save_event_attendees(editing_id)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            MessageBox.Show($"Updated event #{updated_id}.")
        Catch ex As Exception
            MessageBox.Show($"Update error: {ex.Message}")
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
            load_status_combo()
            load_employees_checklist()
            load_attendees_checklist()
        End If
    End Sub


    Private Sub events_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles events_grid.DataBindingComplete
        populate_row_numbers(events_grid)
    End Sub


    Private Sub events_grid_sorted(sender As Object, e As EventArgs) Handles events_grid.Sorted
        populate_row_numbers(events_grid)
    End Sub


    Private Sub events_grid_key_down(sender As Object, e As KeyEventArgs) Handles events_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If events_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(events_grid.SelectedRows(0).Cells("event_id").Value)
        Dim event_name = events_grid.SelectedRows(0).Cells("event_name").Value?.ToString()

        Dim confirm = MessageBox.Show(
            $"Delete event '{event_name}'? This cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM events WHERE event_id = @event_id",
                New Dictionary(Of String, Object) From {{"event_id", selected_id}})
            run_search()
            MessageBox.Show($"Deleted event '{event_name}'.")
        Catch ex As Exception
            MessageBox.Show($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub events_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles events_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = events_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("event_id").Value)

        go_to_manage()

        event_name_input.Text = row.Cells("event_name").Value?.ToString()
        capacity_input.Text = row.Cells("total_guests").Value?.ToString()
        event_date_input.Content = Convert.ToDateTime(row.Cells("event_date").Value)

        Dim start_time_val = TimeSpan.Parse(row.Cells("start_time").Value.ToString())
        start_time_input.Value = DateTime.Today.Add(start_time_val)

        Dim end_time_val = TimeSpan.Parse(row.Cells("end_time").Value.ToString())
        end_time_input.Value = DateTime.Today.Add(end_time_val)

        select_combo(status_input, row.Cells("event_status").Value?.ToString())

        load_event_employees(editing_id)
        load_event_attendees(editing_id)

        set_mode(FormMode.Edit)
    End Sub


    Private Sub events_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles events_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = events_grid.Columns(e.ColumnIndex).Name

        If col = "event_date" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
            e.Value = CDate(e.Value).ToString("MMM d, yyyy")
            e.FormattingApplied = True
        End If

        If (col = "start_time" OrElse col = "end_time") AndAlso e.Value IsNot Nothing Then
            Dim time_val = TimeSpan.Parse(e.Value.ToString())
            e.Value = DateTime.Today.Add(time_val).ToString("hh:mm tt")
            e.FormattingApplied = True
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
            {"event_name", event_name_input.Text.Trim()},
            {"total_guests", CInt(capacity_input.Text.Trim())},
            {"event_status", If(status_input.SelectedItem Is Nothing, "", status_input.SelectedItem.ToString())},
            {"event_date", event_date_input.Content.Date},
            {"start_time", start_time_input.Value.TimeOfDay},
            {"end_time", end_time_input.Value.TimeOfDay}
        }
    End Function


    Private Sub clear_inputs()
        event_name_input.Text = ""
        capacity_input.Text = ""
        event_date_input.Content = DateTime.Today.AddDays(7)
        start_time_input.Value = DateTime.Today.AddHours(10)
        end_time_input.Value = DateTime.Today.AddHours(14)
        status_input.SelectedIndex = -1

        'uncheck all employees and attendees
        For i = 0 To employees_checklist.Items.Count - 1
            employees_checklist.SetItemChecked(i, False)
        Next
        For i = 0 To attendees_checklist.Items.Count - 1
            attendees_checklist.SetItemChecked(i, False)
        Next

        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(event_name_input.Text) Then Return "Event name required."

        Dim capacity As Integer
        If Not Integer.TryParse(capacity_input.Text.Trim(), capacity) OrElse capacity <= 0 Then
            Return "Capacity must be a positive integer."
        End If

        If status_input.SelectedIndex = -1 Then Return "Select an event status."
        If event_date_input.Content.Date < DateTime.Today Then Return "Event date cannot be in the past."

        'time validation: start must be between 08:00 and 23:00, end must be after start
        Dim start_ts = start_time_input.Value.TimeOfDay
        Dim end_ts = end_time_input.Value.TimeOfDay

        If start_ts < TimeSpan.FromHours(8) OrElse start_ts > TimeSpan.FromHours(23) Then
            Return "Start time must be between 08:00 and 23:00."
        End If
        If end_ts <= start_ts Then
            Return "End time must be after start time."
        End If

        'capacity check: registered attendees can't exceed capacity
        Dim registered_count = attendees_checklist.CheckedItems.Count
        If registered_count > capacity Then
            Return $"Registered attendees ({registered_count}) exceed capacity ({capacity})."
        End If

        Return Nothing
    End Function

End Class