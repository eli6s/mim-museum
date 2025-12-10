Imports CuoreUI.Controls

Public Class side_nav
    Private Sub museum_header_Click(sender As Object, e As EventArgs) Handles museum_btn.Click
        Dim museum_dashboard_ctrl = add_ctrl(Of museum_dashboard)(main, "admin-active-ctrl", DockStyle.Fill)

        If museum_submenu.Visible = False Then
            museum_submenu.Visible = True
        Else
            museum_submenu.Visible = False
        End If
    End Sub

    Private Sub boutique_header_Click(sender As Object, e As EventArgs) Handles boutique_btn.Click
        If boutique_submenu.Visible = False Then
            boutique_submenu.Visible = True
        Else
            boutique_submenu.Visible = False
        End If
    End Sub

    Private Sub minerals_btn_Click(sender As Object, e As EventArgs) Handles minerals_btn.Click
        add_ctrl(Of minerals)(main, "admin-active-ctrl", DockStyle.Fill)

        Dim test = get_ctrl(main, "header")
        MsgBox(test.Bounds.ToString())

    End Sub

    Private Sub classes_btn_Click(sender As Object, e As EventArgs) Handles classes_btn.Click
        add_ctrl(Of classifications)(main, "admin-active-ctrl", DockStyle.Fill)
    End Sub

    Private Sub countries_btn_Click(sender As Object, e As EventArgs) Handles countries_btn.Click
        add_ctrl(Of countries)(main, "admin-active-ctrl", DockStyle.Fill)
    End Sub

    Private Sub pos_btn_Click(sender As Object, e As EventArgs) Handles pos_btn.Click
        add_ctrl(Of pos)(main, "admin-active-ctrl", DockStyle.Fill)
    End Sub

    Private Sub museum_dashboard_btn_Click(sender As Object, e As EventArgs) Handles museum_dashboard_btn.Click
        'change_path()
    End Sub

    Private Sub register_click_handler(parent As Control)
        For Each ctrl As Control In parent.Controls
            'And TypeOf ctrl.Parent Is cuiPanel 
            If TypeOf ctrl Is cuiButton Then
                AddHandler ctrl.Click, AddressOf nav_btn_click
            End If

            ' Recursively register for nested containers (Panels, etc)
            If ctrl.HasChildren Then
                register_click_handler(ctrl)
            End If
        Next
    End Sub


    Private Sub nav_btn_click(sender As Object, e As EventArgs)
        'Dim btn As cuiButton = DirectCast(sender, cuiButton)

        ''todo
        'Dim idk As List(Of String) = (Me.museum_submenu.Name, Me.boutique_submenu.Name)

        '' Find parent submenu (the panel that has the root Tag)
        'Dim submenu As Control = btn.Parent
        'MsgBox(submenu.Name)

        'If TypeOf submenu Is  Then
        '    Dim root As String = submenu.Tag.ToString()

        '    Dim child As String = btn.Text

        '    Dim full_path As String = $"{root} | {child}"

        '    ' Update global path + header
        '    set_active_path(main, "header", full_path)
        'End If
    End Sub


    Private Sub side_nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        register_click_handler(main)

        'could call the mouseclick or some other event here 
    End Sub

End Class
