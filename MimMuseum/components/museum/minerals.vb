Public Class minerals
    Private ReadOnly db_obj As New db_controller()
    Private current_mode As FormMode = FormMode.Add
    Private editing_tag As String = ""

    ' note: cuiComboBox occasionally renders blank after an item is deleted upstream.
    ' worked around by reloading lookups every time the manage tab is selected.
    ' lookup maps: display text → id
    Private class_map As New Dictionary(Of String, Integer)
    Private country_map As New Dictionary(Of String, Integer)
    Private section_map As New Dictionary(Of String, Integer)

    Private Const select_sql As String =
        "SELECT
             m.mineral_tag,
             m.mineral_name,
             m.chem_formula,
             c.class_name,
             cn.country_name,
             s.section_name,
             m.dimensions,
             m.hardness_lvl,
             m.is_fluorescent,
             m.is_radioactive,
             m.mineral_desc,
             m.date_added
        FROM minerals m
        INNER JOIN classifications c ON m.class_id  = c.class_id
        INNER JOIN countries cn ON m.country_id = cn.country_id
        INNER JOIN sections s  ON m.section_id = s.section_id
        "


    Private Sub minerals_load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_tabs(tbc)
        setup_grid()
        load_lookups()
        set_mode(FormMode.Add)
        run_search()
    End Sub


    Private Sub setup_grid()
        minerals_grid.AutoGenerateColumns = False
        minerals_grid.Columns.Clear()

        Dim cols As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 40}},
            {"mineral_tag", {"Tag", 90}},
            {"mineral_name", {"Name", 180}},
            {"chem_formula", {"Formula", 130}},
            {"class_name", {"Class", 150}},
            {"country_name", {"Country", 150}},
            {"section_name", {"Section", 180}},
            {"dimensions", {"Dimensions", 130}},
            {"date_added", {"Date Added", 130}},
            {"hardness_lvl", {"Hardness", 80}},
            {"is_fluorescent", {"Fluorescent", 100}},
            {"is_radioactive", {"Radioactive", 100}},
            {"mineral_desc", {"Description", 260}}
        }

        For Each col In cols
            add_column(minerals_grid, col.Key, col.Value(0), col.Value(1))
        Next

        minerals_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub load_lookups()
        load_combo(
            class_input,
            class_map,
            "SELECT class_id, class_name FROM classifications ORDER BY class_name",
            "class_id",
            "class_name"
            )

        load_combo(
            country_input,
            country_map,
            "SELECT country_id, country_name FROM countries ORDER BY country_name",
            "country_id",
            "country_name"
            )

        load_combo(
            section_input,
            section_map,
            "SELECT section_id, section_name FROM sections ORDER BY section_name",
            "section_id",
            "section_name"
            )
    End Sub


    Private Sub set_mode(new_mode As FormMode)
        current_mode = new_mode

        Select Case current_mode
            Case FormMode.Add
                confirm_btn.Text = "Add"
                tag_input.Enabled = True
                mode_lbl.Content = "Mode: ADD"
                mode_lbl.ForeColor = Color.FromArgb(98, 252, 170)

            Case FormMode.Edit
                confirm_btn.Text = "Update"
                tag_input.Enabled = False
                mode_lbl.Content = "Mode: EDIT"
                mode_lbl.ForeColor = Color.FromArgb(255, 170, 0)
        End Select
    End Sub


    Private Sub run_search()
        Dim term = search_input.Text.Trim()

        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If String.IsNullOrEmpty(term) Then
            sql = select_sql & " ORDER BY m.mineral_name"
        Else
            sql = select_sql &
                "
                WHERE
                    m.mineral_tag LIKE @term OR
                    m.mineral_name LIKE @term OR
                    m.chem_formula LIKE @term OR
                    m.dimensions LIKE @term OR
                    m.mineral_desc LIKE @term OR
                    c.class_name LIKE @term OR
                    cn.country_name LIKE @term OR
                    s.section_name LIKE @term OR
                    CAST(m.hardness_lvl AS NVARCHAR(10)) LIKE @term OR
                    CAST(m.date_added AS NVARCHAR(30)) LIKE @term OR
                    FORMAT(m.date_added, 'MMM d, yyyy') LIKE @term
                ORDER BY m.mineral_name
                "
            params("term") = "%" & term & "%"
        End If

        Try
            minerals_grid.DataSource = db_obj.fetch_datatable(sql, params)
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
                INSERT INTO minerals (
                    mineral_tag, mineral_name, chem_formula, class_id, country_id,
                    section_id, dimensions, hardness_lvl, mineral_desc,
                    is_fluorescent, is_radioactive, date_added
                    )
                 VALUES (
                    @mineral_tag, @mineral_name, @chem_formula, @class_id, @country_id,
                    @section_id, @dimensions, @hardness_lvl, @mineral_desc,
                    @is_fluorescent, @is_radioactive, @date_added
                    )
                ", build_input_params())

            Dim inserted_tag = tag_input.Text.Trim()

            clear_inputs()
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Added the mineral {inserted_tag}")

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
            Dim p = build_input_params()
            p("editing_tag") = editing_tag

            db_obj.execute(
                "
                UPDATE minerals 
                SET
                    mineral_name   = @mineral_name,
                    chem_formula   = @chem_formula,
                    class_id       = @class_id,
                    country_id     = @country_id,
                    section_id     = @section_id,
                    dimensions     = @dimensions,
                    hardness_lvl   = @hardness_lvl,
                    mineral_desc   = @mineral_desc,
                    is_fluorescent = @is_fluorescent,
                    is_radioactive = @is_radioactive,
                    date_added     = @date_added
                WHERE mineral_tag  = @editing_tag
                ", p)

            Dim updated_tag = editing_tag
            clear_inputs()
            set_mode(FormMode.Add)
            go_to_browse()
            run_search()
            Vip.Notification.Alert.ShowSucess($"Updated the mineral {updated_tag}")

        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Update error: {ex.Message}")
        End Try
    End Sub


    Private Sub search_input_content_changed(sender As Object, e As EventArgs) Handles search_input.ContentChanged
        run_search()
    End Sub


    'reset to add mode if user manually clicks the "browse" header while in edit mode
    Private Sub tab_control_selected_index_changed(sender As Object, e As EventArgs) Handles tbc.SelectedIndexChanged
        'switching back to browse while in edit mode? reset to add
        If tbc.SelectedIndex = 0 AndAlso current_mode = FormMode.Edit Then
            clear_inputs()
            set_mode(FormMode.Add)
        End If

        'entering manage tab? reload lookups but DON'T clear (double-click needs them intact)
        If tbc.SelectedIndex = 1 Then
            load_lookups()
        End If
    End Sub


    'DataBindingComplete ensures row numbers are assigned after the grid finishes binding,
    'since DataSource assignment is asynchronous and rows aren't available immediately.
    Private Sub minerals_grid_data_binding_complete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles minerals_grid.DataBindingComplete
        populate_row_numbers(minerals_grid)
    End Sub


    Private Sub minerals_grid_sorted(sender As Object, e As EventArgs) Handles minerals_grid.Sorted
        populate_row_numbers(minerals_grid)
    End Sub


    Private Async Sub minerals_grid_key_down(sender As Object, e As KeyEventArgs) Handles minerals_grid.KeyDown
        If e.KeyCode <> Keys.Delete Then Return
        If minerals_grid.SelectedRows.Count = 0 Then Return

        Dim selected_tag = minerals_grid.SelectedRows(0).Cells("mineral_tag").Value?.ToString()
        If String.IsNullOrEmpty(selected_tag) Then Return

        Dim confirm = Await delete_confirmation.ShowDialog(
                                main,
                                $"Delete the mineral '{selected_tag}'? This cannot be undone.",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo
                                )

        If confirm <> DialogResult.Yes Then Return

        Try
            db_obj.execute(
                "
                DELETE FROM minerals
                WHERE mineral_tag = @mineral_tag
                ",
                New Dictionary(Of String, Object) From {{"mineral_tag", selected_tag}}
            )
            run_search()
            Vip.Notification.Alert.ShowSucess($"Deleted the mineral {selected_tag}")
        Catch ex As Exception
            Vip.Notification.Alert.ShowError($"Delete error: {ex.Message}")
        End Try
    End Sub


    Private Sub minerals_grid_cell_double_click(sender As Object, e As DataGridViewCellEventArgs) Handles minerals_grid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = minerals_grid.Rows(e.RowIndex)

        go_to_manage()
        editing_tag = row.Cells("mineral_tag").Value?.ToString()

        tag_input.Text = editing_tag
        name_input.Text = row.Cells("mineral_name").Value?.ToString()
        formula_input.Text = row.Cells("chem_formula").Value?.ToString()
        dimensions_input.Text = row.Cells("dimensions").Value?.ToString()
        desc_input.Text = row.Cells("mineral_desc").Value?.ToString()
        hardness_input.ValueNumber = Convert.ToDecimal(row.Cells("hardness_lvl").Value)
        fluorescent_input.Checked = Convert.ToBoolean(row.Cells("is_fluorescent").Value)
        radioactive_input.Checked = Convert.ToBoolean(row.Cells("is_radioactive").Value)
        date_added_input.Content = Convert.ToDateTime(row.Cells("date_added").Value)

        select_combo(class_input, row.Cells("class_name").Value?.ToString())
        select_combo(country_input, row.Cells("country_name").Value?.ToString())
        select_combo(section_input, row.Cells("section_name").Value?.ToString())

        set_mode(FormMode.Edit)
    End Sub


    Private Sub minerals_grid_cell_formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles minerals_grid.CellFormatting
        Dim col_name = minerals_grid.Columns(e.ColumnIndex).Name

        If (col_name = "is_fluorescent" OrElse col_name = "is_radioactive") AndAlso e.RowIndex >= 0 Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is Boolean Then
                Dim bool_val = CBool(e.Value)
                e.Value = If(bool_val, "Yes", "No")
                If bool_val Then e.CellStyle.ForeColor = Color.FromArgb(104, 252, 143)
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                e.FormattingApplied = True
            End If
        End If

        If col_name = "date_added" AndAlso e.RowIndex >= 0 Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is DateTime Then
                e.Value = CDate(e.Value).ToString("MMM d, yyyy")
                e.FormattingApplied = True
            End If
        End If
    End Sub


    'pressing "esc" while on the "manage" tab is the same as "cancel"
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


    Private Function build_input_params() As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From {
            {"mineral_tag", tag_input.Text.Trim()},
            {"mineral_name", name_input.Text.Trim()},
            {"chem_formula", formula_input.Text.Trim()},
            {"class_id", get_combo_id(class_input, class_map)},
            {"country_id", get_combo_id(country_input, country_map)},
            {"section_id", get_combo_id(section_input, section_map)},
            {"dimensions", dimensions_input.Text.Trim()},
            {"hardness_lvl", CInt(hardness_input.ValueNumber)},
            {"mineral_desc", desc_input.Text.Trim()},
            {"is_fluorescent", fluorescent_input.Checked},
            {"is_radioactive", radioactive_input.Checked},
            {"date_added", date_added_input.Content.Date}
        }
    End Function


    Private Sub clear_inputs()
        tag_input.Text = ""
        name_input.Text = ""
        formula_input.Text = ""
        dimensions_input.Text = ""
        desc_input.Text = ""
        hardness_input.ValueNumber = 1
        fluorescent_input.Checked = False
        radioactive_input.Checked = False
        date_added_input.Content = DateTime.Today
        class_input.SelectedIndex = -1
        country_input.SelectedIndex = -1
        section_input.SelectedIndex = -1
        editing_tag = ""
    End Sub


    Private Function validate_inputs() As String
        If String.IsNullOrWhiteSpace(tag_input.Text) Then Return "Mineral tag is required."
        If String.IsNullOrWhiteSpace(name_input.Text) Then Return "Mineral name is required."
        If String.IsNullOrWhiteSpace(formula_input.Text) Then Return "Chemical formula is required."
        If get_combo_id(class_input, class_map) = 0 Then Return "Please select a classification."
        If get_combo_id(country_input, country_map) = 0 Then Return "Please select a country."
        If get_combo_id(section_input, section_map) = 0 Then Return "Please select a section."
        If String.IsNullOrWhiteSpace(dimensions_input.Text) Then Return "Dimensions are required."
        If date_added_input.Content.Date > DateTime.Today Then Return "Date added cannot be in the future."
        If Not valid_dimensions(dimensions_input.Text) Then Return "Dimensions must be in the format: N x N x N cm"
        If hardness_input.ValueNumber < 1 OrElse hardness_input.ValueNumber > 10 Then Return "Hardness must be between 1 and 10."
        If String.IsNullOrWhiteSpace(desc_input.Text) Then Return "Description is required."
        Return Nothing
    End Function

End Class