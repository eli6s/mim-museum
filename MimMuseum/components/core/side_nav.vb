Imports System.IO
Imports CuoreUI.Controls

Public Class side_nav
    Private submenus As List(Of cuiPanel)
    Private sidenav_panels As List(Of Control)
    Private active_btn As cuiButton = Nothing

    ' map a sidenav button's content text to the user control that should be loaded.
    ' each route adds the control with ctrl_names.admin_active so the previous view is replaced, not stacked.
    Private view_routes As New Dictionary(Of String, Action)(StringComparer.OrdinalIgnoreCase) From {
        {"minerals", Sub() add_ctrl(Of minerals)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"classifications", Sub() add_ctrl(Of classifications)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"sections", Sub() add_ctrl(Of sections)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"countries", Sub() add_ctrl(Of countries)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"guests", Sub() add_ctrl(Of guests)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"donations", Sub() add_ctrl(Of donations)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"events", Sub() add_ctrl(Of events)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"pos", Sub() add_ctrl(Of pos)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"customers", Sub() add_ctrl(Of customers)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"inventory", Sub() add_ctrl(Of inventory)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"transactions", Sub() add_ctrl(Of transactions)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"settings", Sub() add_ctrl(Of settings)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"categories", Sub() add_ctrl(Of categories)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"positions", Sub() add_ctrl(Of positions)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"users", Sub() add_ctrl(Of users)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"reports", Sub() add_ctrl(Of reports)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)},
        {"dashboard", Sub() load_dashboard()}
    }


    Private Sub side_nav_load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' cashiers land on the boutique dashboard, everyone else on the museum dashboard.
        ' we also hide the museum submenu for cashiers since they can't access any of it.
        If session_manager.position = UserPosition.Cashier Then
            show_submenu(boutique_submenu)
            set_active_btn(active_btn, btn_boutique_dashboard)
            update_breadcrumb(main.header_pnl, btn_boutique_dashboard)
        Else
            show_submenu(museum_submenu)
            set_active_btn(active_btn, btn_museum_dashboard)
            update_breadcrumb(main.header_pnl, btn_museum_dashboard)
        End If

        ' register one global click handler for every button in the sidenav
        register_click_handlers(main, AddressOf global_btn_click)
    End Sub


    ' global click handler for all sidenav buttons.
    ' routes the click and updates the active button & breadcrumb at the same time.
    Private Sub global_btn_click(sender As Object, e As EventArgs)
        Dim btn As cuiButton = DirectCast(sender, cuiButton)
        Dim btn_to_activate As cuiButton = btn
        Dim panel As Control = btn.Parent

        ' logout has its own handler, therefore we don't treat it like a nav button
        If btn Is btn_logout Then Return

        ' ignore clicks from buttons that aren't part of the sidenav itself
        If Not sidenav_panels.Contains(panel) Then Return

        ' if the section header buttons (museum / boutique) are clicked,
        ' jump to the respective dashboard and expand their submenu
        If btn Is btn_museum Then
            btn_to_activate = btn_museum_dashboard
            show_submenu(museum_submenu)
        ElseIf btn Is btn_boutique Then
            btn_to_activate = btn_boutique_dashboard
            show_submenu(boutique_submenu)
        End If

        set_active_btn(active_btn, btn_to_activate)
        route_to_view(btn)
        update_breadcrumb(main.header_pnl, btn_to_activate)
    End Sub


    ' highlight the clicked button & un-highlight the previously active one
    Public Sub set_active_btn(ByRef active_btn As cuiButton, clicked_btn As cuiButton)
        If active_btn IsNot Nothing Then
            active_btn.BackColor = btn_inactive_color
            active_btn.Checked = False
        End If

        active_btn = clicked_btn
        active_btn.BackColor = btn_active_color
        active_btn.Checked = True
    End Sub


    ' update the navigation path label in the header
    Public Sub update_breadcrumb(parent As Control, btn As cuiButton)
        Dim header_ctrl As header = get_ctrl(parent, ctrl_names.header)
        If header_ctrl Is Nothing Then Return

        Dim parent_panel As Control = btn.Parent
        Dim full_path As String

        ' submenu buttons get a "Section | Page" path; root buttons just get the page name
        If TypeOf parent_panel Is cuiPanel AndAlso parent_panel.Tag IsNot Nothing Then
            full_path = $"{parent_panel.Tag} | {btn.Content.Trim()}"
        Else
            full_path = btn.Content.Trim()
        End If

        header_ctrl.breadcrumb_btn.Content = full_path
        header_ctrl.breadcrumb_btn.Image = btn.Image
    End Sub


    ' route to the right user control based on the clicked button.
    ' museum/boutique header buttons go to their dashboards.
    ' equipment, employees, and maintenance route differently depending on which submenu the button lives in (museum vs boutique).
    Private Sub route_to_view(btn As cuiButton)
        If btn Is btn_museum Then
            add_ctrl(Of museum_dashboard)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        ElseIf btn Is btn_boutique Then
            add_ctrl(Of boutique_dashboard)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        End If

        ' equipment, employees, and maintenance are duplicated buttons.
        ' pick the right one by looking at which submenu panel the button lives in
        If btn Is btn_museum_equipment Then
            add_ctrl(Of museum_equipment)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        ElseIf btn Is btn_boutique_equipment Then
            add_ctrl(Of boutique_equipment)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        ElseIf btn Is btn_museum_employees Then
            ' host the shared museum_employees control directly with its default museum filter
            add_ctrl(Of museum_employees)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        ElseIf btn Is btn_boutique_employees Then
            add_ctrl(Of boutique_employees)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        ElseIf btn Is btn_museum_maintenance Then
            add_ctrl(Of museum_maintenance)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        ElseIf btn Is btn_boutique_maintenance Then
            add_ctrl(Of maintenance)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
            Return
        End If

        ' all other buttons: look up the route by their displayed text
        Dim button_text As String = btn.Content.ToLower()
        If view_routes.ContainsKey(button_text) Then
            view_routes(button_text).Invoke()
        End If
    End Sub


    ' pick the right dashboard depending on which submenu is currently visible
    ' this works because only one submenu can be visible at a time
    Private Sub load_dashboard()
        If museum_submenu.Visible Then
            add_ctrl(Of museum_dashboard)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
        ElseIf boutique_submenu.Visible Then
            add_ctrl(Of boutique_dashboard)(main.main_pnl, ctrl_names.admin_active, DockStyle.Fill)
        End If
    End Sub


    ' show one submenu, hide the others
    Private Sub show_submenu(panel_to_show As cuiPanel)
        For Each panel In submenus
            panel.Visible = False
        Next
        panel_to_show.Visible = True
    End Sub


    ' walk every button in the sidenav and toggle visibility based on the current user's accessible modules
    ' this is how RBAC (role-based access control) is performed
    Private Sub apply_permissions()
        Dim accessible_modules As List(Of SystemModule) = session_manager.get_my_modules()

        apply_to_buttons(core_panel, accessible_modules)

        ' show/hide the section headers depending on whether the user has any access to that side at all
        btn_museum.Visible = has_any_museum_access(accessible_modules)
        btn_boutique.Visible = has_any_boutique_access(accessible_modules)

        museum_submenu.Visible = btn_museum.Visible
        boutique_submenu.Visible = btn_boutique.Visible
    End Sub


    Private Sub apply_to_buttons(parent As Control, accessible_modules As List(Of SystemModule))
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is cuiButton Then
                Dim btn As cuiButton = DirectCast(ctrl, cuiButton)

                ' always show logout. section headers are toggled separately.
                If btn Is btn_logout Or btn Is btn_museum Or btn Is btn_boutique Then
                    Continue For
                End If

                ' turn the button name (e.g. "btn_museum_equipment") into the matching
                ' enum name ("MuseumEquipment") and check membership
                Dim module_name As String = to_pascal_case(btn.Name.Replace("btn_", ""))
                Dim _module As SystemModule

                If [Enum].TryParse(module_name, True, _module) Then
                    btn.Tag = $"SystemModule.{_module}"
                    btn.Visible = accessible_modules.Contains(_module)
                End If
            Else
                ' recurse so we cover buttons nested inside panels
                apply_to_buttons(ctrl, accessible_modules)
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


    Private Async Sub logout_btn_click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim answer = Await logout_confirmation.ShowDialog(
                                main,
                                "Are you sure you want to logout?",
                                "Logout",
                                MessageBoxButtons.YesNo)

        If answer = DialogResult.No Then Return

        remove_ctrl(main.header_pnl, ctrl_names.header)
        remove_ctrl(main.side_nav_pnl, ctrl_names.side_nav)

        Dim assets_dir = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "assets")
        Dim pics_dir = Path.Combine(assets_dir, "pics")
        Dim bg_path = Path.Combine(pics_dir, "bg.jpg")

        main.BackgroundImage = Image.FromFile(bg_path)
        main.header_pnl.Visible = False
        main.side_nav_pnl.Visible = False
        main.main_pnl.Visible = False

        session_manager.logout()
        add_ctrl(Of login)(main, ctrl_names.login)
    End Sub
End Class