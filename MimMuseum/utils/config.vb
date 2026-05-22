Imports OxyPlot

Module config
    Public ReadOnly btn_active_color As Color = Color.FromArgb(97, 189, 250)
    Public ReadOnly btn_inactive_color As Color = Color.FromArgb(0, 0, 0, 0)

    Public ReadOnly piechart_colours() As OxyColor = {
            OxyColor.FromRgb(252, 144, 193),    ' pink
            OxyColor.FromRgb(199, 132, 250),    ' lavender
            OxyColor.FromRgb(172, 130, 255),    ' magneta
            OxyColor.FromRgb(125, 255, 255),    ' cyan
            OxyColor.FromRgb(125, 188, 255),    ' sky blue
            OxyColor.FromRgb(89, 139, 255),     ' blurple
            OxyColor.FromRgb(98, 252, 170),     ' green
            OxyColor.FromRgb(255, 150, 150)
        }

    Public Const MANAGER_SALARY As Decimal = 2500.0
    Public Const ASSISTANT_SALARY As Decimal = 1500.0
    Public Const CASHIER_SALARY As Decimal = 1200.0

    Structure ctrl_names
        Const login = "login"
        Const header = "header"
        Const side_nav = "side-nav"
        Const admin_active = "admin-active"
        Const reset_pass = "reset-pass"
        Const new_pass = "new-pass"
    End Structure

End Module
