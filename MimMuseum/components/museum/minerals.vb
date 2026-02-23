Public Class minerals
    Private ReadOnly db_obj As New db_controller()
    'user control: 2318, 1177
    'search: 2314, 186
    'grid: 2147, 873

    Private Sub minerals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        minerals_grid.AutoGenerateColumns = False
        minerals_grid.Columns.Clear()

        Dim column_headers As New Dictionary(Of String, Object()) From {
            {"row_number", {"#", 30}},
            {"mineral_tag", {"Tag", 80}},
            {"mineral_name", {"Name", 180}},
            {"chem_formula", {"Formula", 120}},
            {"class_name", {"Class", 150}},
            {"country_name", {"Country", 150}},
            {"section_name", {"Section", 200}},
            {"dimensions", {"Dimensions", 120}},
            {"hardness_lvl", {"Hardness", 80}},
            {"is_fluorescent", {"Fluorescent", 100}},
            {"is_radioactive", {"Radioactive", 100}},
            {"mineral_desc", {"Description", 250}}
        }

        For Each col_header In column_headers
            Dim name As String = col_header.Key
            Dim header As String = col_header.Value(0)
            Dim width As Integer = col_header.Value(1)

            add_column(minerals_grid, name, header, width)
        Next

        minerals_grid.DataSource = db_obj.fetch_datatable(
            "
            SELECT
                m.*,
                c.class_name,
                s.section_name,
                cn.country_name
            FROM minerals m
            INNER JOIN classifications c ON m.class_id = c.class_id
            INNER JOIN sections s ON m.section_id = s.section_id
            INNER JOIN countries cn ON m.country_id = cn.country_id
            ")
        minerals_grid.Columns("row_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        populate_row_numbers(minerals_grid)
        'minerals_grid.Columns("row_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub


    Private Sub minerals_grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles minerals_grid.CellFormatting
        ' handle boolean columns with styling
        If (minerals_grid.Columns(e.ColumnIndex).Name = "is_fluorescent" OrElse
        minerals_grid.Columns(e.ColumnIndex).Name = "is_radioactive") AndAlso
        e.RowIndex >= 0 Then

            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is Boolean Then
                Dim boolValue = CBool(e.Value)
                e.Value = If(boolValue, "Yes", "No")

                If boolValue Then
                    e.CellStyle.ForeColor = Color.FromArgb(104, 252, 143)
                End If

                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                e.FormattingApplied = True
            End If
        End If

        ' BADGE GENERATION: https://claude.ai/chat/68036132-e5fe-4fd2-938d-40e60d0ab200
        ' example: column index 3 holds event status as a string
        'If e.ColumnIndex = 3 Then

        '    e.CellStyle.BackColor = Color.FromArgb(220, 252, 231) ' light green
        '            e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)

        'End If

    End Sub


    Private Sub minerals_grid_Sorted(sender As Object, e As EventArgs) Handles minerals_grid.Sorted
        populate_row_numbers(minerals_grid)
    End Sub


    Private Sub minerals_grid_MouseClick(sender As Object, e As MouseEventArgs) Handles minerals_grid.MouseClick
        If e.Button = MouseButtons.Right Then
            'context menu for actions here
            HopeContextMenuStrip1.Show(minerals_grid, e.Location)
        End If
    End Sub


    'Try
    'Dim row As DataGridViewRow = MetroGrid1.Rows(e.RowIndex)

    '        Dim mineral_tag As String = Convert.ToInt32(row.Cells(0).Value)
    '        Dim mineral_name As String = row.Cells(1).Value.ToString()
    '        Dim chem_formula As String = row.Cells(2).Value.ToString()

    '        Dim class_id As Integer = row.Cells(3).Value.ToString()
    '        Dim country_id As Integer = row.Cells(4).Value.ToString()
    '        Dim section_id As Integer = row.Cells(5).Value.ToString()

    '        Dim dimensions As String = row.Cells(6).Value.ToString()
    '        Dim hardness_lvl As Integer = row.Cells(7).Value.ToString()
    '        Dim mineral_desc As String = row.Cells(8).Value.ToString()
    '        Dim is_fluorescent As Boolean = row.Cells(9).Value.ToString()
    '        Dim is_radioactive As Boolean = row.Cells(10).Value.ToString()

    '        db_obj.execute(
    '        "
    '        UPDATE minerals 
    '        SET 
    '            mineral_name = @mineral_name,
    '            chem_formula = @chem_formula,
    '            class_id = @class_id,
    '            country_id = @country_id,
    '            section_id = @section_id,
    '            dimensions = @dimensions,
    '            hardness_lvl = @hardness_lvl,
    '            mineral_desc = @mineral_desc,
    '            is_fluorescent = @is_fluorescent,
    '            is_radioactive = @is_radioactive
    '        WHERE mineral_tag = @mineral_tag
    '        ",
    '        New Dictionary(Of String, Object) From {
    '            {"mineral_tag", mineral_tag},
    '            {"mineral_name", mineral_name},
    '            {"chem_formula", chem_formula},
    '            {"class_id", class_id},
    '            {"country_id", country_id},
    '            {"section_id", section_id},
    '            {"dimensions", dimensions},
    '            {"hardness_lvl", hardness_lvl},
    '            {"mineral_desc", mineral_desc},
    '            {"is_fluorescent", is_fluorescent},
    '            {"is_radioactive", is_radioactive}
    '        }
    '    )
    '        'could display the msg here

    '    Catch ex As Exception
    '        MessageBox.Show("error updating database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '    Dim result As DialogResult = MessageBox.Show(
    '    "Are you sure you want to delete this class?",
    '    "Delete",
    '    MessageBoxButtons.YesNo,
    '    MessageBoxIcon.Question
    ')

    'If result = DialogResult.Yes Then
    '    Try
    '        If e.Row.Cells(0).Value IsNot Nothing Then
    '            Dim mineral_tag As String = Convert.ToInt32(e.Row.Cells(0).Value)

    '            db_obj.execute(
    '            "
    '            DELETE FROM minerals
    '            WHERE mineral_tag = @mineral_tag
    '            ",
    '            New Dictionary(Of String, Object) From {
    '                {"mineral_tag", mineral_tag}
    '            }
    '        )
    '            e.Cancel = False
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("error deleting from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        e.Cancel = True
    '    End Try

End Class
