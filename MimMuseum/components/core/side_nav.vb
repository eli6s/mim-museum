Imports CuoreUI.Controls

Public Class side_nav
    Private submenus As List(Of cuiPanel)
    Private sidenav_panels As List(Of Control)
    Private active_btn As cuiButton = Nothing

    ' key value pairs consiting of a button's name & a function to add the appropriate user control
    Private view_routes As New Dictionary(Of String, Action)(StringComparer.OrdinalIgnoreCase) From {
        {"minerals", Sub()
                         add_ctrl(Of minerals)(
                            main.main_pnl,
                            ctrl_names.admin_active,
                            DockStyle.Fill
                            )
                     End Sub},
        {"classifications", Sub()
                                add_ctrl(Of classifications)(
                                    main.main_pnl,
                                    ctrl_names.admin_active,
                                    DockStyle.Fill
                                    )
                            End Sub},
        {"countries", Sub()
                          add_ctrl(Of countries)(
                            main.main_pnl,
                            ctrl_names.admin_active,
                            DockStyle.Fill
                            )
                      End Sub},
        {"pos", Sub()
                    add_ctrl(Of pos)(
                        main.main_pnl,
                        ctrl_names.admin_active,
                        DockStyle.Fill
                        )
                End Sub},
        {"settings", Sub()
                         add_ctrl(Of settings)(
                            main.main_pnl,
                            ctrl_names.admin_active,
                            DockStyle.Fill
                            )
                     End Sub},
        {"positions", Sub()
                          add_ctrl(Of positions)(
                            main.main_pnl,
                            ctrl_names.admin_active,
                            DockStyle.Fill
                            )
                      End Sub},
        {"dashboard", Sub()
                          load_dashboard()
                      End Sub}
    }


    Private Sub side_nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submenus = New List(Of cuiPanel) From {
            museum_submenu,
            boutique_submenu
        }

        sidenav_panels = New List(Of Control) From {
            core_panel,
            museum_submenu,
            boutique_submenu,
            actions_panel
        }

        apply_permissions()
        ' show the museum submenu by default and hide all others
        ' set the default active button and update the breadcrumb (path)

        'TODO: small issue with the dashboard routing when the user logged in is a cashier
        If session_manager.position = UserPosition.Cashier Then
            show_submenu(boutique_submenu)
            set_active_btn(active_btn, btn_boutique_dashboard)
            update_breadcrumb(main.header_pnl, btn_boutique_dashboard)
        Else
            show_submenu(museum_submenu)
            set_active_btn(active_btn, btn_museum_dashboard)
            update_breadcrumb(main.header_pnl, btn_museum_dashboard)
        End If

        ' register click handlers for all buttons
        register_click_handlers(main, AddressOf global_btn_click)
    End Sub


    ' global click handler for all navigation buttons
    Private Sub global_btn_click(sender As Object, e As EventArgs)
        'determine which button should be highlighted
        Dim btn As cuiButton = DirectCast(sender, cuiButton)
        Dim btn_to_activate As cuiButton = btn
        Dim panel As Control = btn.Parent

        'since actions are only being performed on navigation buttons for now,
        'all non-navigation buttons & the logout button must be filtered,
        'as we don't want to highlight them, display their breadcrumb, or route to their view
        '

        If btn Is btn_logout Then
            Return
        End If

        If Not sidenav_panels.Contains(panel) Then
            Return
        End If

        ' Handle header button clicks
        If btn Is btn_museum Then
            btn_to_activate = btn_museum_dashboard
            show_submenu(museum_submenu)

        ElseIf btn Is btn_boutique Then
            btn_to_activate = btn_boutique_dashboard
            show_submenu(boutique_submenu)
        End If

        set_active_btn(active_btn, btn_to_activate)
        route_to_view(btn)

        ' update the navigation path/breadcrumb using the highlighted button
        update_breadcrumb(main.header_pnl, btn_to_activate)
    End Sub


    'set the active button in the admin panel navigation menu
    Public Sub set_active_btn(ByRef active_btn As cuiButton, clicked_btn As cuiButton)
        If active_btn IsNot Nothing Then
            active_btn.BackColor = btn_inactive_color
            active_btn.Checked = False
        End If

        active_btn = clicked_btn
        active_btn.BackColor = btn_active_color
        active_btn.Checked = True
    End Sub


    'update the navigation breadcrumb path
    Public Sub update_breadcrumb(parent As Control, btn As cuiButton)
        Dim header_ctrl As header = get_ctrl(parent, ctrl_names.header)
        If header_ctrl Is Nothing Then Return

        Dim parent_panel As Control = btn.Parent
        Dim full_path As String

        'check if the button is inside a tagged submenu panel
        If TypeOf parent_panel Is cuiPanel AndAlso parent_panel.Tag IsNot Nothing Then
            full_path = $"{parent_panel.Tag} | {btn.Content.Trim()}"
        Else
            'it's a root/header button (example: "Museum")
            full_path = btn.Content.Trim()
        End If

        header_ctrl.breadcrumb_btn.Content = full_path
        header_ctrl.breadcrumb_btn.Image = btn.Image
    End Sub


    ' route to the appropriate view based on the button
    Private Sub route_to_view(btn As cuiButton)
        ' if the button is the museum or boutique headers, route to their corresponding dashboards
        If btn Is btn_museum Then
            add_ctrl(Of museum_dashboard)(
                main.main_pnl,
                ctrl_names.admin_active,
                DockStyle.Fill
                )
            Return

        ElseIf btn Is btn_boutique Then
            add_ctrl(Of boutique_dashboard)(
                main.main_pnl,
                ctrl_names.admin_active,
                DockStyle.Fill
                )
            Return
        End If

        Dim button_text As String = btn.Content.ToLower()

        ' if the key exists, route to the corresponding user control
        If view_routes.ContainsKey(button_text) Then
            view_routes(button_text).Invoke()
        End If
    End Sub


    ' load the appropriate dashboard based on the active section
    Private Sub load_dashboard()
        If museum_submenu.Visible Then
            add_ctrl(Of museum_dashboard)(
                main.main_pnl,
                ctrl_names.admin_active,
                DockStyle.Fill
                )
        ElseIf boutique_submenu.Visible Then
            add_ctrl(Of boutique_dashboard)(
                main.main_pnl,
                ctrl_names.admin_active,
                DockStyle.Fill
                )
        End If
    End Sub


    ' show a specific submenu and hide all others
    Private Sub show_submenu(panel_to_show As cuiPanel)
        For Each panel In submenus
            panel.Visible = False
        Next
        panel_to_show.Visible = True
    End Sub


    Private Sub apply_permissions()
        Dim accessible_modules As List(Of SystemModule) = session_manager.get_my_modules()

        'process all buttons recursively
        apply_to_buttons(core_panel, accessible_modules)

        'show/hide section headers
        btn_museum.Visible = has_any_museum_access(accessible_modules)
        btn_boutique.Visible = has_any_boutique_access(accessible_modules)
        museum_submenu.Visible = btn_museum.Visible
        boutique_submenu.Visible = btn_boutique.Visible
    End Sub


    Private Sub apply_to_buttons(parent As Control, accessible_modules As List(Of SystemModule))
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is cuiButton Then
                Dim btn As cuiButton = DirectCast(ctrl, cuiButton)

                'logout always visible, headers handled separately
                If btn Is btn_logout Or btn Is btn_museum Or btn Is btn_boutique Then
                    Continue For
                End If

                'match button name to module
                Dim module_name As String = to_pascal_case(btn.Name.Replace("btn_", ""))
                Dim _module As SystemModule

                If [Enum].TryParse(module_name, True, _module) Then
                    btn.Tag = $"SystemModule.{_module}"
                    btn.Visible = accessible_modules.Contains(_module)
                End If
            Else
                apply_to_buttons(ctrl, accessible_modules)  'recurse into panels
            End If
        Next
    End Sub


    Private Function has_any_museum_access(modules As List(Of SystemModule)) As Boolean
        Return modules.Any(
            Function(m) m >= SystemModule.MuseumDashboard And m <= SystemModule.Guests
            )
    End Function


    Private Function has_any_boutique_access(modules As List(Of SystemModule)) As Boolean
        Return modules.Any(
            Function(m) m >= SystemModule.BoutiqueDashboard And m <= SystemModule.BoutiqueMaintenance
            )
    End Function


    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        msg_dialog.YesText = "Yes"
        msg_dialog.NoText = "No"
        msg_dialog.CancelText = Nothing

        Dim answer = msg_dialog.ShowDialog(main, "Are you sure you want to logout?", "Logout")

        'If yes Then
        '    remove_ctrl(main.header_pnl, "header")
        '    remove_ctrl(main.side_nav_pnl, "side-nav")

        '    'main.BackgroundImage =
        '    main.header_pnl.Visible = False
        '    main.side_nav_pnl.Visible = False
        '    main.main_pnl.Visible = False

        '    add_ctrl(Of login)(Me, "login")
        'End If
    End Sub
End Class