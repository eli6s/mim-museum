''' <summary>
''' donations form. supports both standard donations and event-tied donations.
''' donor_id is nullable — null means anonymous donor.
''' </summary>
Public Class donations
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_id As Integer = 0

    'lookup maps for donors (guests) and events
    Private guest_map As New Dictionary(Of String, Integer)
    Private event_map As New Dictionary(Of String, Integer)

    'special placeholder for the anonymous donor option in the combo
    Private Const ANONYMOUS_LABEL As String = "— Anonymous —"

    Private Const select_sql As String =
        "SELECT
             d.donation_id,
             d.donor_id,
             ISNULL(g.first_name + ' ' + g.last_name, 'Anonymous') AS donor_name,
             d.amount,
             d.donation_type,
             d.donation_date,
             d.note,
             d.event_id,
             ev.event_name
         FROM donations d
         LEFT JOIN guests g ON d.donor_id = g.guest_id
         LEFT JOIN events ev ON d.event_id = ev.event_id
        "


    Private Sub donations_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_lookups()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        donations_grid.AutoGenerateColumns = False
        donations_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"donation_id", {"ID", 70}},
            {"donor_name", {"Donor", 200}},
            {"amount", {"Amount", 120}},
            {"donation_type", {"Type", 100}},
            {"donation_date", {"Date", 130}},
            {"event_name", {"Event", 180}},
            {"note", {"Note", 220}}
        }

        For Each col In cols
            add_column(donations_grid, col.Key, col.Value(0), col.Value(1))
        Next

        'donor_id and event_id stay in the data source for editing but aren't shown
        add_column(donations_grid, "donor_id", "donor_id", 0, False)
        add_column(donations_grid, "event_id", "event_id", 0, False)

        donations_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub load_lookups()
        'donors are guests — we add an "Anonymous" option at the top
        guest_map.Clear()
        donor_input.Items = New String() {}
        donor_input.AddItem(ANONYMOUS_LABEL)

        For Each row In db_obj.fetch("SELECT guest_id, first_name + ' ' + last_name AS full_name FROM guests ORDER BY full_name")
            Dim full_name = row("full_name").ToString()
            Dim id_val = Convert.ToInt32(row("guest_id"))
            guest_map(full_name) = id_val
            donor_input.AddItem(full_name)
        Next
        donor_input.SelectedIndex = -1

        'events list — only used when type = event
        load_combo(
            event_input,
            event_map,
            "SELECT event_id, event_name FROM events ORDER BY event_name",
            "event_id",
            "event_name"
        )

        'donation type combo (strip the leading underscore from _Event)
        type_input.Items = New String() {}
        For Each enum_name In [Enum].GetNames(GetType(DonationType))
            type_input.AddItem(enum_name.TrimStart("_"c).ToLower())
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

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY d.donation_date DESC"
        Else
            sql = select_sql &
                "
                WHERE
                    ISNULL(g.first_name + ' ' + g.last_name, 'Anonymous') LIKE @term OR
                    d.donation_type LIKE @term OR
                    ISNULL(d.note, '') LIKE @term OR
                    ISNULL(ev.event_name, '') LIKE @term OR
                    CAST(d.donation_id AS NVARCHAR(20)) LIKE @term OR
                    CAST(d.amount AS NVARCHAR(30)) LIKE @term OR
                    FORMAT(d.donation_date, 'MMM d, yyyy') LIKE @term
                ORDER BY d.donation_date DESC
                "
            params("term") = "%" & term & "%"
        End If

        Try
            donations_grid.DataSource = db_obj.fetch_datatable(sql, params)
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Search error: {ex.Message}")
        End Try
    End Sub


    'when type changes, enable/disable the event combo accordingly.
    'standard donations don't have an event, event donations require one.
    Private Sub type_input_selected_index_changed(sender As Object, e As EventArgs) Handles type_input.SelectedIndexChanged
        If type_input.SelectedItem Is Nothing Then Return
        Dim t = type_input.SelectedItem.ToString()

        If t = "event" Then
            event_input.Enabled = True
        Else
            event_input.Enabled = False
            event_input.SelectedIndex = -1
        End If
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
                INSERT INTO donations (donor_id, amount, donation_type, donation_date, note, event_id)
                VALUES (@donor_id, @amount, @donation_type, @donation_date, @note, @event_id)
                ", build_params())

            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess("Donation recorded.")
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
            p("donation_id") = editing_id

            db_obj.execute(
                "
                UPDATE donations
                SET donor_id      = @donor_id,
                    amount        = @amount,
                    donation_type = @donation_type,
                    donation_date = @donation_date,
                    note          = @note,
                    event_id      = @event_id
                WHERE donation_id = @donation_id
                ", p)

            Dim updated_id = editing_id
            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated donation #{updated_id}.")
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


    Private Sub donations_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles donations_grid.DataBindingComplete
        populate_row_numbers(donations_grid)
    End Sub


    Private Sub donations_grid_sorted(sender As Object, e As EventArgs) Handles donations_grid.Sorted
        populate_row_numbers(donations_grid)
    End Sub


    Private Async Sub donations_grid_key_down(sender As Object, e As KeyEventArgs) Handles donations_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If donations_grid.SelectedRows.Count = 0 Then Return

        Dim selected_id = CInt(donations_grid.SelectedRows(0).Cells("donation_id").Value)

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete donation #{selected_id}? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "DELETE FROM donations WHERE donation_id = @donation_id",
                New Dictionary(Of String, Object) From {{"donation_id", selected_id}})
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted donation #{selected_id}.")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub donations_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles donations_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = donations_grid.Rows(e.RowIndex)
        editing_id = CInt(row.Cells("donation_id").Value)

        go_to_manage()

        amount_input.Text = row.Cells("amount").Value?.ToString()
        date_input.Content = Convert.ToDateTime(row.Cells("donation_date").Value)

        Dim note_val = row.Cells("note").Value
        note_input.Text = If(IsDBNull(note_val), "", note_val?.ToString())

        select_combo(type_input, row.Cells("donation_type").Value?.ToString())

        'donor — could be anonymous (donor_id null) or a guest
        Dim donor_id_val = row.Cells("donor_id").Value
        If IsDBNull(donor_id_val) OrElse donor_id_val Is Nothing Then
            select_combo(donor_input, ANONYMOUS_LABEL)
        Else
            Dim donor_name = row.Cells("donor_name").Value?.ToString()
            select_combo(donor_input, donor_name)
        End If

        'event — only relevant if type = event
        Dim event_name_val = row.Cells("event_name").Value
        If Not IsDBNull(event_name_val) AndAlso event_name_val IsNot Nothing Then
            select_combo(event_input, event_name_val.ToString())
        End If

        set_mode(FormMode.Edit)
    End Sub


    Private Sub donations_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles donations_grid.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim col = donations_grid.Columns(e.ColumnIndex).Name

        If col = "donation_date" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
            e.Value = CDate(e.Value).ToString("MMM d, yyyy")
            e.FormattingApplied = True
        End If

        If col = "amount" AndAlso e.Value IsNot Nothing Then
            e.Value = CDec(e.Value).ToString("C2")
            e.FormattingApplied = True
        End If

        'show "—" for empty event names rather than blank cells
        If col = "event_name" Then
            If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
                e.Value = "—"
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
        'donor_id is null when "Anonymous" is selected
        Dim donor_label = If(donor_input.SelectedItem Is Nothing, "", donor_input.SelectedItem.ToString())
        Dim donor_id_val As Object
        If donor_label = ANONYMOUS_LABEL OrElse String.IsNullOrEmpty(donor_label) Then
            donor_id_val = DBNull.Value
        Else
            donor_id_val = guest_map(donor_label)
        End If

        'event_id is null unless type = event
        Dim type_str = If(type_input.SelectedItem Is Nothing, "", type_input.SelectedItem.ToString())
        Dim event_id_val As Object
        If type_str = "event" Then
            event_id_val = get_combo_id(event_input, event_map)
            If CInt(event_id_val) = 0 Then event_id_val = DBNull.Value
        Else
            event_id_val = DBNull.Value
        End If

        'note is optional
        Dim note_val As Object = If(String.IsNullOrWhiteSpace(note_input.Text), CObj(DBNull.Value), CObj(note_input.Text.Trim()))

        Return New Dictionary(Of String, Object) From {
            {"donor_id", donor_id_val},
            {"amount", CDec(amount_input.Text.Trim())},
            {"donation_type", type_str},
            {"donation_date", date_input.Content.Date},
            {"note", note_val},
            {"event_id", event_id_val}
        }
    End Function


    Private Sub clear_inputs()
        amount_input.Text = ""
        note_input.Text = ""
        date_input.Content = DateTime.Today
        donor_input.SelectedIndex = -1
        event_input.SelectedIndex = -1
        type_input.SelectedIndex = -1
        event_input.Enabled = False
        editing_id = 0
    End Sub


    Private Function validate_inputs() As String
        Dim amount As Decimal
        If Not Decimal.TryParse(amount_input.Text.Trim(), amount) OrElse amount <= 0 Then Return "Amount must be a positive number."
        If date_input.Content.Date > DateTime.Today Then Return "Donation date cannot be in the future."
        If type_input.SelectedIndex = -1 Then Return "Select a donation type."

        Dim t = type_input.SelectedItem.ToString()
        If t = "event" AndAlso get_combo_id(event_input, event_map) = 0 Then
            Return "Event donations must reference an event."
        End If
        Return Nothing
    End Function

End Class