<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Mim_museum_dataset = New MimMuseum.mim_museum_dataset()
        Me.delete_confirmation = New CuoreUI.Components.cuiMessageDialog()
        Me.CuiLabel10 = New CuoreUI.Controls.cuiLabel()
        Me.date_added_input = New CuoreUI.Controls.cuiCalendarDatePicker()
        Me.cancel_btn = New CuoreUI.Controls.cuiButton()
        Me.confirm_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel5 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel12 = New CuoreUI.Controls.cuiLabel()
        Me.price_input = New CuoreUI.Controls.cuiTextBox()
        Me.mode_lbl = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel15 = New CuoreUI.Controls.cuiLabel()
        Me.pg_browse = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.search_input = New CuoreUI.Controls.cuiTextBox()
        Me.inventory_grid = New MetroFramework.Controls.MetroGrid()
        Me.pg_manage = New System.Windows.Forms.TabPage()
        Me.remove_image_btn = New CuoreUI.Controls.cuiButton()
        Me.upload_image_btn = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel9 = New CuoreUI.Controls.cuiLabel()
        Me.quantity_input = New CuoreUI.Controls.cuiTextBox()
        Me.preview_picture = New System.Windows.Forms.PictureBox()
        Me.item_name_input = New CuoreUI.Controls.cuiTextBox()
        Me.active_toggle = New CuoreUI.Controls.cuiSwitch()
        Me.mineral_input = New CuoreUI.Controls.cuiComboBox()
        Me.CuiLabel8 = New CuoreUI.Controls.cuiLabel()
        Me.CuiLabel1 = New CuoreUI.Controls.cuiLabel()
        Me.tbc = New System.Windows.Forms.TabControl()
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_browse.SuspendLayout()
        CType(Me.inventory_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_manage.SuspendLayout()
        CType(Me.preview_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mim_museum_dataset
        '
        Me.Mim_museum_dataset.DataSetName = "mim_museum_dataset"
        Me.Mim_museum_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'delete_confirmation
        '
        Me.delete_confirmation.BackColor = System.Drawing.Color.White
        Me.delete_confirmation.ButtonSize = New System.Drawing.Size(80, 32)
        Me.delete_confirmation.CancelText = ""
        Me.delete_confirmation.DialogPadding = New System.Windows.Forms.Padding(30)
        Me.delete_confirmation.DialogSize = New System.Drawing.Size(430, 300)
        Me.delete_confirmation.DimColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.delete_confirmation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.delete_confirmation.NoText = "No"
        Me.delete_confirmation.OKText = ""
        Me.delete_confirmation.Rounding = 12
        Me.delete_confirmation.YesText = "Yes"
        '
        'CuiLabel10
        '
        Me.CuiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel10.Content = "Date\ Added"
        Me.CuiLabel10.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel10.Location = New System.Drawing.Point(979, 477)
        Me.CuiLabel10.Name = "CuiLabel10"
        Me.CuiLabel10.Size = New System.Drawing.Size(169, 23)
        Me.CuiLabel10.TabIndex = 129
        Me.CuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'date_added_input
        '
        Me.date_added_input.Content = New Date(2026, 3, 8, 0, 0, 0, 0)
        Me.date_added_input.EnableThemeChangeButton = True
        Me.date_added_input.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_added_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.date_added_input.HoverOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.Icon = CType(resources.GetObject("date_added_input.Icon"), System.Drawing.Image)
        Me.date_added_input.IconTint = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.Location = New System.Drawing.Point(979, 509)
        Me.date_added_input.Margin = New System.Windows.Forms.Padding(6)
        Me.date_added_input.Name = "date_added_input"
        Me.date_added_input.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.date_added_input.NormalOutline = System.Drawing.Color.Transparent
        Me.date_added_input.OutlineThickness = 1.5!
        Me.date_added_input.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom
        Me.date_added_input.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.date_added_input.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.date_added_input.Rounding = 12
        Me.date_added_input.ShowIcon = True
        Me.date_added_input.Size = New System.Drawing.Size(390, 49)
        Me.date_added_input.TabIndex = 128
        Me.date_added_input.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light
        '
        'cancel_btn
        '
        Me.cancel_btn.CheckButton = False
        Me.cancel_btn.Checked = False
        Me.cancel_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancel_btn.CheckedForeColor = System.Drawing.Color.White
        Me.cancel_btn.CheckedImageTint = System.Drawing.Color.White
        Me.cancel_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancel_btn.Content = "Cancel"
        Me.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cancel_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.cancel_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cancel_btn.HoverImageTint = System.Drawing.Color.White
        Me.cancel_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.cancel_btn.Image = Nothing
        Me.cancel_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.cancel_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.cancel_btn.Location = New System.Drawing.Point(1147, 922)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.cancel_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel_btn.NormalImageTint = System.Drawing.Color.White
        Me.cancel_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel_btn.OutlineThickness = 3.0!
        Me.cancel_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.cancel_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cancel_btn.PressedForeColor = System.Drawing.Color.White
        Me.cancel_btn.PressedImageTint = System.Drawing.Color.White
        Me.cancel_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cancel_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.cancel_btn.Size = New System.Drawing.Size(126, 49)
        Me.cancel_btn.TabIndex = 108
        Me.cancel_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.cancel_btn.TextPadding = 12
        Me.cancel_btn.TextSpacing = 2
        '
        'confirm_btn
        '
        Me.confirm_btn.CheckButton = False
        Me.confirm_btn.Checked = False
        Me.confirm_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confirm_btn.CheckedForeColor = System.Drawing.Color.White
        Me.confirm_btn.CheckedImageTint = System.Drawing.Color.White
        Me.confirm_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confirm_btn.Content = "Confirm"
        Me.confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirm_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.confirm_btn.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.confirm_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.confirm_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.confirm_btn.HoverImageTint = System.Drawing.Color.White
        Me.confirm_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.confirm_btn.Image = Nothing
        Me.confirm_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.confirm_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.confirm_btn.Location = New System.Drawing.Point(970, 922)
        Me.confirm_btn.Name = "confirm_btn"
        Me.confirm_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.confirm_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.confirm_btn.NormalImageTint = System.Drawing.Color.White
        Me.confirm_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.confirm_btn.OutlineThickness = 1.0!
        Me.confirm_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.confirm_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.confirm_btn.PressedForeColor = System.Drawing.Color.White
        Me.confirm_btn.PressedImageTint = System.Drawing.Color.White
        Me.confirm_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.confirm_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.confirm_btn.Size = New System.Drawing.Size(156, 49)
        Me.confirm_btn.TabIndex = 10
        Me.confirm_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.confirm_btn.TextPadding = 12
        Me.confirm_btn.TextSpacing = 2
        '
        'CuiLabel5
        '
        Me.CuiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel5.Content = "Manage\ Inventory"
        Me.CuiLabel5.Font = New System.Drawing.Font("Helvetica", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel5.Location = New System.Drawing.Point(958, 46)
        Me.CuiLabel5.Name = "CuiLabel5"
        Me.CuiLabel5.Size = New System.Drawing.Size(303, 65)
        Me.CuiLabel5.TabIndex = 85
        Me.CuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel12
        '
        Me.CuiLabel12.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel12.Content = "Price"
        Me.CuiLabel12.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel12.Location = New System.Drawing.Point(964, 359)
        Me.CuiLabel12.Name = "CuiLabel12"
        Me.CuiLabel12.Size = New System.Drawing.Size(99, 32)
        Me.CuiLabel12.TabIndex = 126
        Me.CuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'price_input
        '
        Me.price_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.price_input.Content = ""
        Me.price_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.price_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.price_input.FocusImageTint = System.Drawing.Color.White
        Me.price_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.price_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.price_input.Image = Nothing
        Me.price_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.price_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.price_input.Location = New System.Drawing.Point(979, 398)
        Me.price_input.Margin = New System.Windows.Forms.Padding(4)
        Me.price_input.Multiline = False
        Me.price_input.Name = "price_input"
        Me.price_input.NormalImageTint = System.Drawing.Color.Silver
        Me.price_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.price_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.price_input.PasswordChar = False
        Me.price_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.price_input.PlaceholderText = "Price"
        Me.price_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.price_input.Size = New System.Drawing.Size(179, 49)
        Me.price_input.TabIndex = 125
        Me.price_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.price_input.UnderlinedStyle = True
        '
        'mode_lbl
        '
        Me.mode_lbl.BackColor = System.Drawing.Color.Transparent
        Me.mode_lbl.Content = "Mode:\ ADD"
        Me.mode_lbl.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.mode_lbl.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.mode_lbl.Location = New System.Drawing.Point(998, 130)
        Me.mode_lbl.Name = "mode_lbl"
        Me.mode_lbl.Size = New System.Drawing.Size(227, 44)
        Me.mode_lbl.TabIndex = 124
        Me.mode_lbl.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel15
        '
        Me.CuiLabel15.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel15.Content = "Item\ Name"
        Me.CuiLabel15.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel15.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel15.Location = New System.Drawing.Point(970, 255)
        Me.CuiLabel15.Name = "CuiLabel15"
        Me.CuiLabel15.Size = New System.Drawing.Size(128, 30)
        Me.CuiLabel15.TabIndex = 87
        Me.CuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'pg_browse
        '
        Me.pg_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_browse.Controls.Add(Me.MaterialDivider1)
        Me.pg_browse.Controls.Add(Me.search_input)
        Me.pg_browse.Controls.Add(Me.inventory_grid)
        Me.pg_browse.Location = New System.Drawing.Point(4, 26)
        Me.pg_browse.Name = "pg_browse"
        Me.pg_browse.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_browse.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_browse.TabIndex = 0
        Me.pg_browse.Text = "Browse"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(6, 144)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(2314, 1)
        Me.MaterialDivider1.TabIndex = 123
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'search_input
        '
        Me.search_input.BackColor = System.Drawing.Color.Transparent
        Me.search_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.search_input.Content = ""
        Me.search_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_input.FocusImageTint = System.Drawing.Color.White
        Me.search_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Image = Nothing
        Me.search_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.search_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.search_input.Location = New System.Drawing.Point(503, 45)
        Me.search_input.Margin = New System.Windows.Forms.Padding(4)
        Me.search_input.Multiline = False
        Me.search_input.Name = "search_input"
        Me.search_input.NormalImageTint = System.Drawing.Color.Silver
        Me.search_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.Padding = New System.Windows.Forms.Padding(23, 19, 23, 0)
        Me.search_input.PasswordChar = False
        Me.search_input.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.search_input.PlaceholderText = "Search"
        Me.search_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.search_input.Size = New System.Drawing.Size(1304, 61)
        Me.search_input.TabIndex = 122
        Me.search_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.search_input.UnderlinedStyle = True
        '
        'inventory_grid
        '
        Me.inventory_grid.AllowUserToAddRows = False
        Me.inventory_grid.AllowUserToDeleteRows = False
        Me.inventory_grid.AllowUserToResizeColumns = False
        Me.inventory_grid.AllowUserToResizeRows = False
        Me.inventory_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.inventory_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.inventory_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.inventory_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inventory_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.inventory_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventory_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.inventory_grid.ColumnHeadersHeight = 70
        Me.inventory_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.inventory_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.inventory_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.inventory_grid.EnableHeadersVisualStyles = False
        Me.inventory_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.inventory_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inventory_grid.Location = New System.Drawing.Point(88, 185)
        Me.inventory_grid.Name = "inventory_grid"
        Me.inventory_grid.ReadOnly = True
        Me.inventory_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventory_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.inventory_grid.RowHeadersVisible = False
        Me.inventory_grid.RowHeadersWidth = 50
        Me.inventory_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 20)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.inventory_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.inventory_grid.RowTemplate.Height = 42
        Me.inventory_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventory_grid.Size = New System.Drawing.Size(2147, 970)
        Me.inventory_grid.TabIndex = 9
        '
        'pg_manage
        '
        Me.pg_manage.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pg_manage.Controls.Add(Me.remove_image_btn)
        Me.pg_manage.Controls.Add(Me.upload_image_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel9)
        Me.pg_manage.Controls.Add(Me.quantity_input)
        Me.pg_manage.Controls.Add(Me.preview_picture)
        Me.pg_manage.Controls.Add(Me.CuiLabel10)
        Me.pg_manage.Controls.Add(Me.date_added_input)
        Me.pg_manage.Controls.Add(Me.cancel_btn)
        Me.pg_manage.Controls.Add(Me.confirm_btn)
        Me.pg_manage.Controls.Add(Me.CuiLabel5)
        Me.pg_manage.Controls.Add(Me.CuiLabel12)
        Me.pg_manage.Controls.Add(Me.price_input)
        Me.pg_manage.Controls.Add(Me.mode_lbl)
        Me.pg_manage.Controls.Add(Me.CuiLabel15)
        Me.pg_manage.Controls.Add(Me.item_name_input)
        Me.pg_manage.Controls.Add(Me.active_toggle)
        Me.pg_manage.Controls.Add(Me.mineral_input)
        Me.pg_manage.Controls.Add(Me.CuiLabel8)
        Me.pg_manage.Controls.Add(Me.CuiLabel1)
        Me.pg_manage.Location = New System.Drawing.Point(4, 26)
        Me.pg_manage.Name = "pg_manage"
        Me.pg_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_manage.Size = New System.Drawing.Size(2329, 1268)
        Me.pg_manage.TabIndex = 1
        Me.pg_manage.Text = "Manage"
        '
        'remove_image_btn
        '
        Me.remove_image_btn.CheckButton = False
        Me.remove_image_btn.Checked = False
        Me.remove_image_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.remove_image_btn.CheckedForeColor = System.Drawing.Color.White
        Me.remove_image_btn.CheckedImageTint = System.Drawing.Color.White
        Me.remove_image_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.remove_image_btn.Content = "Remove Image"
        Me.remove_image_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remove_image_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.remove_image_btn.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remove_image_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.remove_image_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.remove_image_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.remove_image_btn.HoverImageTint = System.Drawing.Color.White
        Me.remove_image_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.remove_image_btn.Image = Nothing
        Me.remove_image_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.remove_image_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.remove_image_btn.Location = New System.Drawing.Point(753, 554)
        Me.remove_image_btn.Name = "remove_image_btn"
        Me.remove_image_btn.NormalBackground = System.Drawing.Color.Transparent
        Me.remove_image_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.remove_image_btn.NormalImageTint = System.Drawing.Color.White
        Me.remove_image_btn.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.remove_image_btn.OutlineThickness = 3.0!
        Me.remove_image_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.remove_image_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.remove_image_btn.PressedForeColor = System.Drawing.Color.White
        Me.remove_image_btn.PressedImageTint = System.Drawing.Color.White
        Me.remove_image_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.remove_image_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.remove_image_btn.Size = New System.Drawing.Size(120, 33)
        Me.remove_image_btn.TabIndex = 134
        Me.remove_image_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.remove_image_btn.TextPadding = 12
        Me.remove_image_btn.TextSpacing = 2
        '
        'upload_image_btn
        '
        Me.upload_image_btn.CheckButton = False
        Me.upload_image_btn.Checked = False
        Me.upload_image_btn.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.upload_image_btn.CheckedForeColor = System.Drawing.Color.White
        Me.upload_image_btn.CheckedImageTint = System.Drawing.Color.White
        Me.upload_image_btn.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.upload_image_btn.Content = "Choose Image"
        Me.upload_image_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upload_image_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.upload_image_btn.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upload_image_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.upload_image_btn.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.upload_image_btn.HoverForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.upload_image_btn.HoverImageTint = System.Drawing.Color.White
        Me.upload_image_btn.HoverOutline = System.Drawing.Color.Transparent
        Me.upload_image_btn.Image = Nothing
        Me.upload_image_btn.ImageExpand = New System.Drawing.Point(3, 3)
        Me.upload_image_btn.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.upload_image_btn.Location = New System.Drawing.Point(616, 554)
        Me.upload_image_btn.Name = "upload_image_btn"
        Me.upload_image_btn.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.upload_image_btn.NormalForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.upload_image_btn.NormalImageTint = System.Drawing.Color.White
        Me.upload_image_btn.NormalOutline = System.Drawing.Color.Transparent
        Me.upload_image_btn.OutlineThickness = 1.0!
        Me.upload_image_btn.Padding = New System.Windows.Forms.Padding(12)
        Me.upload_image_btn.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.upload_image_btn.PressedForeColor = System.Drawing.Color.White
        Me.upload_image_btn.PressedImageTint = System.Drawing.Color.White
        Me.upload_image_btn.PressedOutline = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.upload_image_btn.Rounding = New System.Windows.Forms.Padding(12)
        Me.upload_image_btn.Size = New System.Drawing.Size(120, 33)
        Me.upload_image_btn.TabIndex = 133
        Me.upload_image_btn.TextAlignment = System.Drawing.StringAlignment.Center
        Me.upload_image_btn.TextPadding = 12
        Me.upload_image_btn.TextSpacing = 2
        '
        'CuiLabel9
        '
        Me.CuiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel9.Content = "Quantity"
        Me.CuiLabel9.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel9.Location = New System.Drawing.Point(1198, 359)
        Me.CuiLabel9.Name = "CuiLabel9"
        Me.CuiLabel9.Size = New System.Drawing.Size(99, 32)
        Me.CuiLabel9.TabIndex = 132
        Me.CuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'quantity_input
        '
        Me.quantity_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.quantity_input.Content = ""
        Me.quantity_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantity_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.quantity_input.FocusImageTint = System.Drawing.Color.White
        Me.quantity_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.quantity_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.quantity_input.Image = Nothing
        Me.quantity_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.quantity_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.quantity_input.Location = New System.Drawing.Point(1198, 398)
        Me.quantity_input.Margin = New System.Windows.Forms.Padding(4)
        Me.quantity_input.Multiline = False
        Me.quantity_input.Name = "quantity_input"
        Me.quantity_input.NormalImageTint = System.Drawing.Color.Silver
        Me.quantity_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.quantity_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.quantity_input.PasswordChar = False
        Me.quantity_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.quantity_input.PlaceholderText = "Quantity"
        Me.quantity_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.quantity_input.Size = New System.Drawing.Size(171, 49)
        Me.quantity_input.TabIndex = 131
        Me.quantity_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.quantity_input.UnderlinedStyle = True
        '
        'preview_picture
        '
        Me.preview_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.preview_picture.Location = New System.Drawing.Point(616, 284)
        Me.preview_picture.Name = "preview_picture"
        Me.preview_picture.Size = New System.Drawing.Size(257, 235)
        Me.preview_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.preview_picture.TabIndex = 130
        Me.preview_picture.TabStop = False
        '
        'item_name_input
        '
        Me.item_name_input.BackColor = System.Drawing.Color.Transparent
        Me.item_name_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.item_name_input.Content = ""
        Me.item_name_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.item_name_input.FocusBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.item_name_input.FocusImageTint = System.Drawing.Color.White
        Me.item_name_input.FocusOutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.item_name_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_name_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.item_name_input.Image = Nothing
        Me.item_name_input.ImageExpand = New System.Drawing.Point(0, 0)
        Me.item_name_input.ImageOffset = New System.Drawing.Point(0, 0)
        Me.item_name_input.Location = New System.Drawing.Point(979, 285)
        Me.item_name_input.Margin = New System.Windows.Forms.Padding(4)
        Me.item_name_input.Multiline = False
        Me.item_name_input.Name = "item_name_input"
        Me.item_name_input.NormalImageTint = System.Drawing.Color.Silver
        Me.item_name_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.item_name_input.Padding = New System.Windows.Forms.Padding(23, 13, 23, 0)
        Me.item_name_input.PasswordChar = False
        Me.item_name_input.PlaceholderColor = System.Drawing.Color.DimGray
        Me.item_name_input.PlaceholderText = "Item Name"
        Me.item_name_input.Rounding = New System.Windows.Forms.Padding(12)
        Me.item_name_input.Size = New System.Drawing.Size(390, 49)
        Me.item_name_input.TabIndex = 83
        Me.item_name_input.TextOffset = New System.Drawing.Size(0, 0)
        Me.item_name_input.UnderlinedStyle = True
        '
        'active_toggle
        '
        Me.active_toggle.Checked = False
        Me.active_toggle.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.active_toggle.CheckedForeground = System.Drawing.Color.White
        Me.active_toggle.CheckedOutlineColor = System.Drawing.Color.Empty
        Me.active_toggle.CheckedSymbolColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.active_toggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.active_toggle.Location = New System.Drawing.Point(1000, 726)
        Me.active_toggle.MinimumSize = New System.Drawing.Size(12, 8)
        Me.active_toggle.Name = "active_toggle"
        Me.active_toggle.OutlineThickness = 1.0!
        Me.active_toggle.ShowSymbols = False
        Me.active_toggle.Size = New System.Drawing.Size(48, 26)
        Me.active_toggle.TabIndex = 111
        Me.active_toggle.ThumbSizeModifier = New System.Drawing.Size(0, 0)
        Me.active_toggle.UncheckedBackground = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.active_toggle.UncheckedForeground = System.Drawing.Color.White
        Me.active_toggle.UncheckedOutlineColor = System.Drawing.Color.Empty
        Me.active_toggle.UncheckedSymbolColor = System.Drawing.Color.Gray
        '
        'mineral_input
        '
        Me.mineral_input.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.mineral_input.DropDownBackgroundColor = System.Drawing.Color.White
        Me.mineral_input.DropDownForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.mineral_input.ExpandArrowColor = System.Drawing.Color.Gray
        Me.mineral_input.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mineral_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mineral_input.Items = New String(-1) {}
        Me.mineral_input.Location = New System.Drawing.Point(983, 608)
        Me.mineral_input.Margin = New System.Windows.Forms.Padding(6)
        Me.mineral_input.MaxDropDownHeight = 240
        Me.mineral_input.Name = "mineral_input"
        Me.mineral_input.NoSelectionText = "Select"
        Me.mineral_input.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mineral_input.OutlineThickness = 1.0!
        Me.mineral_input.Rounding = 12
        Me.mineral_input.SelectedIndex = -1
        Me.mineral_input.SelectedItem = ""
        Me.mineral_input.Size = New System.Drawing.Size(386, 49)
        Me.mineral_input.SortAlphabetically = True
        Me.mineral_input.TabIndex = 120
        '
        'CuiLabel8
        '
        Me.CuiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel8.Content = "Mineral"
        Me.CuiLabel8.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel8.Location = New System.Drawing.Point(942, 578)
        Me.CuiLabel8.Name = "CuiLabel8"
        Me.CuiLabel8.Size = New System.Drawing.Size(166, 30)
        Me.CuiLabel8.TabIndex = 119
        Me.CuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'CuiLabel1
        '
        Me.CuiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CuiLabel1.Content = "Active"
        Me.CuiLabel1.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center
        Me.CuiLabel1.Location = New System.Drawing.Point(942, 681)
        Me.CuiLabel1.Name = "CuiLabel1"
        Me.CuiLabel1.Size = New System.Drawing.Size(166, 24)
        Me.CuiLabel1.TabIndex = 104
        Me.CuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.pg_browse)
        Me.tbc.Controls.Add(Me.pg_manage)
        Me.tbc.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc.Location = New System.Drawing.Point(-9, -4)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(2337, 1298)
        Me.tbc.TabIndex = 1
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.tbc)
        Me.Name = "inventory"
        Me.Size = New System.Drawing.Size(2318, 1291)
        CType(Me.Mim_museum_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_browse.ResumeLayout(False)
        CType(Me.inventory_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_manage.ResumeLayout(False)
        CType(Me.preview_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mim_museum_dataset As mim_museum_dataset
    Friend WithEvents delete_confirmation As CuoreUI.Components.cuiMessageDialog
    Friend WithEvents CuiLabel10 As CuoreUI.Controls.cuiLabel
    Friend WithEvents date_added_input As CuoreUI.Controls.cuiCalendarDatePicker
    Friend WithEvents cancel_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents confirm_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel5 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel12 As CuoreUI.Controls.cuiLabel
    Friend WithEvents price_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents mode_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel15 As CuoreUI.Controls.cuiLabel
    Friend WithEvents pg_browse As TabPage
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents search_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents inventory_grid As MetroFramework.Controls.MetroGrid
    Friend WithEvents pg_manage As TabPage
    Friend WithEvents item_name_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents active_toggle As CuoreUI.Controls.cuiSwitch
    Friend WithEvents mineral_input As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiLabel8 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiLabel1 As CuoreUI.Controls.cuiLabel
    Friend WithEvents tbc As TabControl
    Friend WithEvents preview_picture As PictureBox
    Friend WithEvents CuiLabel9 As CuoreUI.Controls.cuiLabel
    Friend WithEvents quantity_input As CuoreUI.Controls.cuiTextBox
    Friend WithEvents remove_image_btn As CuoreUI.Controls.cuiButton
    Friend WithEvents upload_image_btn As CuoreUI.Controls.cuiButton
End Class
