﻿

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeloF1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim SuperTabColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabColorTable = New DevComponents.DotNetBar.Rendering.SuperTabColorTable()
        Dim SuperTabLinearGradientColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable = New DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable()
        Me.SuperTabPrincipal = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanelRegistro = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.GroupPanelBuscador = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGrM_Buscador = New Janus.Windows.GridEX.GridEX()
        Me.MPanelSup = New System.Windows.Forms.Panel()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PanelInferior = New DevComponents.DotNetBar.PanelEx()
        Me.MPanelUserAct = New System.Windows.Forms.Panel()
        Me.BubbleBarUsuario = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTabUsuario = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BubbleButton1 = New DevComponents.DotNetBar.BubbleButton()
        Me.TxtNombreUsu = New System.Windows.Forms.TextBox()
        Me.PanelNavegacion = New System.Windows.Forms.Panel()
        Me.LblPaginacion = New System.Windows.Forms.Label()
        Me.btnUltimo = New DevComponents.DotNetBar.ButtonX()
        Me.btnSiguiente = New DevComponents.DotNetBar.ButtonX()
        Me.btnAnterior = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrimero = New DevComponents.DotNetBar.ButtonX()
        Me.PanelSuperior = New DevComponents.DotNetBar.PanelEx()
        Me.MRlAccion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelToolBar2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.PanelToolBar1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.btnGrabar = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.SupTabItemRegistro = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanelBuscador = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SupTabItemBusqueda = New DevComponents.DotNetBar.SuperTabItem()
        Me.MEP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MHighlighterFocus = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.MFlyoutUsuario = New DevComponents.DotNetBar.Controls.Flyout(Me.components)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.GroupPanelBuscador.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPanelSup.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavegacion.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Controls.Add(Me.SuperTabControlPanelRegistro)
        Me.SuperTabPrincipal.Controls.Add(Me.SuperTabControlPanelBuscador)
        Me.SuperTabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabPrincipal.HorizontalText = False
        Me.SuperTabPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabPrincipal.Name = "SuperTabPrincipal"
        Me.SuperTabPrincipal.ReorderTabsEnabled = True
        Me.SuperTabPrincipal.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabPrincipal.SelectedTabIndex = 0
        Me.SuperTabPrincipal.Size = New System.Drawing.Size(1137, 624)
        Me.SuperTabPrincipal.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
        Me.SuperTabPrincipal.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabPrincipal.TabIndex = 0
        Me.SuperTabPrincipal.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SupTabItemRegistro, Me.SupTabItemBusqueda})
        SuperTabLinearGradientColorTable1.Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))}
        SuperTabColorTable1.Background = SuperTabLinearGradientColorTable1
        Me.SuperTabPrincipal.TabStripColor = SuperTabColorTable1
        Me.SuperTabPrincipal.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OfficeMobile2014
        Me.SuperTabPrincipal.Text = "SuperTabControl1"
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Controls.Add(Me.PanelPrincipal)
        Me.SuperTabControlPanelRegistro.Controls.Add(Me.PanelInferior)
        Me.SuperTabControlPanelRegistro.Controls.Add(Me.PanelSuperior)
        Me.SuperTabControlPanelRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanelRegistro.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanelRegistro.Name = "SuperTabControlPanelRegistro"
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(1102, 624)
        Me.SuperTabControlPanelRegistro.TabIndex = 1
        Me.SuperTabControlPanelRegistro.TabItem = Me.SupTabItemRegistro
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.PanelPrincipal.Controls.Add(Me.GroupPanelBuscador)
        Me.PanelPrincipal.Controls.Add(Me.MPanelSup)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 89)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1102, 491)
        Me.PanelPrincipal.TabIndex = 0
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelBuscador.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelBuscador.Controls.Add(Me.JGrM_Buscador)
        Me.GroupPanelBuscador.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelBuscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Location = New System.Drawing.Point(0, 226)
        Me.GroupPanelBuscador.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanelBuscador.Name = "GroupPanelBuscador"
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(1102, 265)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelBuscador.TabIndex = 1
        Me.GroupPanelBuscador.Text = "B U S C A D O R"
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JGrM_Buscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGrM_Buscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGrM_Buscador.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGrM_Buscador.Location = New System.Drawing.Point(0, 0)
        Me.JGrM_Buscador.Margin = New System.Windows.Forms.Padding(4)
        Me.JGrM_Buscador.Name = "JGrM_Buscador"
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(1096, 238)
        Me.JGrM_Buscador.TabIndex = 0
        '
        'MPanelSup
        '
        Me.MPanelSup.BackColor = System.Drawing.Color.White
        Me.MPanelSup.Controls.Add(Me.PanelUsuario)
        Me.MPanelSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.MPanelSup.Location = New System.Drawing.Point(0, 0)
        Me.MPanelSup.Margin = New System.Windows.Forms.Padding(4)
        Me.MPanelSup.Name = "MPanelSup"
        Me.MPanelSup.Size = New System.Drawing.Size(1102, 226)
        Me.MPanelSup.TabIndex = 0
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.lbHora)
        Me.PanelUsuario.Controls.Add(Me.lbFecha)
        Me.PanelUsuario.Controls.Add(Me.lbUsuario)
        Me.PanelUsuario.Controls.Add(Me.lblHora)
        Me.PanelUsuario.Controls.Add(Me.lblFecha)
        Me.PanelUsuario.Controls.Add(Me.lblUsuario)
        Me.PanelUsuario.Location = New System.Drawing.Point(869, 36)
        Me.PanelUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(293, 123)
        Me.PanelUsuario.TabIndex = 19
        Me.PanelUsuario.TabStop = True
        Me.PanelUsuario.Visible = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(153, 80)
        Me.lbHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(98, 24)
        Me.lbHora.TabIndex = 6
        Me.lbHora.Text = "USUARIO:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(153, 52)
        Me.lbFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(98, 24)
        Me.lbFecha.TabIndex = 5
        Me.lbFecha.Text = "USUARIO:"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(153, 23)
        Me.lbUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(98, 24)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.Text = "USUARIO:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(41, 80)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(75, 24)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "HORA:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(41, 53)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(86, 24)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "FECHA:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(41, 23)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(106, 24)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "USUARIO:"
        '
        'PanelInferior
        '
        Me.PanelInferior.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelInferior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelInferior.Controls.Add(Me.MPanelUserAct)
        Me.PanelInferior.Controls.Add(Me.PanelNavegacion)
        Me.PanelInferior.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 580)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(1102, 44)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        Me.PanelInferior.TabIndex = 4
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Controls.Add(Me.BubbleBarUsuario)
        Me.MPanelUserAct.Controls.Add(Me.TxtNombreUsu)
        Me.MPanelUserAct.Dock = System.Windows.Forms.DockStyle.Right
        Me.MPanelUserAct.Location = New System.Drawing.Point(835, 0)
        Me.MPanelUserAct.Margin = New System.Windows.Forms.Padding(4)
        Me.MPanelUserAct.Name = "MPanelUserAct"
        Me.MPanelUserAct.Size = New System.Drawing.Size(267, 44)
        Me.MPanelUserAct.TabIndex = 21
        '
        'BubbleBarUsuario
        '
        Me.BubbleBarUsuario.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBarUsuario.AntiAlias = True
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BubbleBarUsuario.ImageSizeLarge = New System.Drawing.Size(50, 50)
        Me.BubbleBarUsuario.ImageSizeNormal = New System.Drawing.Size(32, 28)
        Me.BubbleBarUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BubbleBarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.Name = "BubbleBarUsuario"
        Me.BubbleBarUsuario.SelectedTab = Me.BubbleBarTabUsuario
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBarUsuario.Size = New System.Drawing.Size(267, 44)
        Me.BubbleBarUsuario.TabIndex = 13
        Me.BubbleBarUsuario.Tabs.Add(Me.BubbleBarTabUsuario)
        Me.BubbleBarUsuario.TabsVisible = False
        Me.BubbleBarUsuario.Text = "BubbleBar5"
        '
        'BubbleBarTabUsuario
        '
        Me.BubbleBarTabUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTabUsuario.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTabUsuario.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.BubbleButton1})
        Me.BubbleBarTabUsuario.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTabUsuario.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTabUsuario.Name = "BubbleBarTabUsuario"
        Me.BubbleBarTabUsuario.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTabUsuario.Text = "BubbleBarTab3"
        Me.BubbleBarTabUsuario.TextColor = System.Drawing.Color.Black
        '
        'BubbleButton1
        '
        Me.BubbleButton1.Image = Global.Modelo.My.Resources.Resources.man_18
        Me.BubbleButton1.ImageLarge = Global.Modelo.My.Resources.Resources.man_18
        Me.BubbleButton1.Name = "BubbleButton1"
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.BackColor = System.Drawing.Color.Gold
        Me.TxtNombreUsu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNombreUsu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsu.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtNombreUsu.Location = New System.Drawing.Point(0, 0)
        Me.TxtNombreUsu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombreUsu.Multiline = True
        Me.TxtNombreUsu.Name = "TxtNombreUsu"
        Me.TxtNombreUsu.Size = New System.Drawing.Size(267, 44)
        Me.TxtNombreUsu.TabIndex = 14
        Me.TxtNombreUsu.Text = "MARCO"
        Me.TxtNombreUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNombreUsu.Visible = False
        '
        'PanelNavegacion
        '
        Me.PanelNavegacion.Controls.Add(Me.LblPaginacion)
        Me.PanelNavegacion.Controls.Add(Me.btnUltimo)
        Me.PanelNavegacion.Controls.Add(Me.btnSiguiente)
        Me.PanelNavegacion.Controls.Add(Me.btnAnterior)
        Me.PanelNavegacion.Controls.Add(Me.btnPrimero)
        Me.PanelNavegacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNavegacion.Location = New System.Drawing.Point(0, 0)
        Me.PanelNavegacion.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelNavegacion.Name = "PanelNavegacion"
        Me.PanelNavegacion.Size = New System.Drawing.Size(384, 44)
        Me.PanelNavegacion.TabIndex = 20
        '
        'LblPaginacion
        '
        Me.LblPaginacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaginacion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaginacion.ForeColor = System.Drawing.Color.White
        Me.LblPaginacion.Location = New System.Drawing.Point(228, 0)
        Me.LblPaginacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPaginacion.Name = "LblPaginacion"
        Me.LblPaginacion.Size = New System.Drawing.Size(156, 44)
        Me.LblPaginacion.TabIndex = 22
        Me.LblPaginacion.Text = "0/0"
        Me.LblPaginacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUltimo
        '
        Me.btnUltimo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUltimo.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnUltimo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Image = Global.Modelo.My.Resources.Resources.next2
        Me.btnUltimo.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnUltimo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnUltimo.Location = New System.Drawing.Point(171, 0)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(57, 44)
        Me.btnUltimo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUltimo.TabIndex = 14
        '
        'btnSiguiente
        '
        Me.btnSiguiente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSiguiente.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Image = Global.Modelo.My.Resources.Resources.next1
        Me.btnSiguiente.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnSiguiente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSiguiente.Location = New System.Drawing.Point(114, 0)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(57, 44)
        Me.btnSiguiente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSiguiente.TabIndex = 13
        '
        'btnAnterior
        '
        Me.btnAnterior.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnterior.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Image = Global.Modelo.My.Resources.Resources.at1
        Me.btnAnterior.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAnterior.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAnterior.Location = New System.Drawing.Point(57, 0)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(57, 44)
        Me.btnAnterior.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAnterior.TabIndex = 12
        '
        'btnPrimero
        '
        Me.btnPrimero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrimero.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnPrimero.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Image = Global.Modelo.My.Resources.Resources.at2
        Me.btnPrimero.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnPrimero.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPrimero.Location = New System.Drawing.Point(0, 0)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(57, 44)
        Me.btnPrimero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrimero.TabIndex = 11
        '
        'PanelSuperior
        '
        Me.PanelSuperior.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelSuperior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.PanelSuperior.Controls.Add(Me.MRlAccion)
        Me.PanelSuperior.Controls.Add(Me.PanelToolBar2)
        Me.PanelSuperior.Controls.Add(Me.PanelToolBar1)
        Me.PanelSuperior.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1102, 89)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.TabIndex = 0
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MRlAccion.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRlAccion.ForeColor = System.Drawing.Color.White
        Me.MRlAccion.Location = New System.Drawing.Point(584, 0)
        Me.MRlAccion.Margin = New System.Windows.Forms.Padding(4)
        Me.MRlAccion.Name = "MRlAccion"
        Me.MRlAccion.Size = New System.Drawing.Size(261, 89)
        Me.MRlAccion.TabIndex = 7
        Me.MRlAccion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.BackgroundImage = Global.Modelo.My.Resources.Resources.fondoPanel
        Me.PanelToolBar2.Controls.Add(Me.btnImprimir)
        Me.PanelToolBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelToolBar2.Location = New System.Drawing.Point(995, 0)
        Me.PanelToolBar2.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelToolBar2.Name = "PanelToolBar2"
        Me.PanelToolBar2.Size = New System.Drawing.Size(107, 89)
        Me.PanelToolBar2.TabIndex = 6
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.Modelo.My.Resources.Resources.printee
        Me.btnImprimir.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(107, 89)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.TextColor = System.Drawing.Color.White
        '
        'PanelToolBar1
        '
        Me.PanelToolBar1.Controls.Add(Me.btnSalir)
        Me.PanelToolBar1.Controls.Add(Me.btnGrabar)
        Me.PanelToolBar1.Controls.Add(Me.btnEliminar)
        Me.PanelToolBar1.Controls.Add(Me.btnModificar)
        Me.PanelToolBar1.Controls.Add(Me.btnNuevo)
        Me.PanelToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.PanelToolBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelToolBar1.Name = "PanelToolBar1"
        Me.PanelToolBar1.Size = New System.Drawing.Size(501, 89)
        Me.PanelToolBar1.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Modelo.My.Resources.Resources.atras
        Me.btnSalir.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Location = New System.Drawing.Point(384, 0)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(117, 89)
        Me.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextColor = System.Drawing.Color.White
        '
        'btnGrabar
        '
        Me.btnGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnGrabar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = Global.Modelo.My.Resources.Resources.save
        Me.btnGrabar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnGrabar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnGrabar.Location = New System.Drawing.Point(288, 0)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(96, 89)
        Me.btnGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGrabar.TabIndex = 9
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.TextColor = System.Drawing.Color.White
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Modelo.My.Resources.Resources.trash
        Me.btnEliminar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEliminar.Location = New System.Drawing.Point(192, 0)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 89)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Modelo.My.Resources.Resources.edit
        Me.btnModificar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnModificar.Location = New System.Drawing.Point(96, 0)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 89)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Modelo.My.Resources.Resources.add
        Me.btnNuevo.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 89)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextColor = System.Drawing.Color.White
        '
        'SupTabItemRegistro
        '
        Me.SupTabItemRegistro.AttachedControl = Me.SuperTabControlPanelRegistro
        Me.SupTabItemRegistro.GlobalItem = False
        Me.SupTabItemRegistro.Name = "SupTabItemRegistro"
        Me.SupTabItemRegistro.Text = "REGISTRO"
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanelBuscador.Location = New System.Drawing.Point(0, 41)
        Me.SuperTabControlPanelBuscador.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanelBuscador.Name = "SuperTabControlPanelBuscador"
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(1089, 583)
        Me.SuperTabControlPanelBuscador.TabIndex = 0
        Me.SuperTabControlPanelBuscador.TabItem = Me.SupTabItemBusqueda
        '
        'SupTabItemBusqueda
        '
        Me.SupTabItemBusqueda.AttachedControl = Me.SuperTabControlPanelBuscador
        Me.SupTabItemBusqueda.GlobalItem = False
        Me.SupTabItemBusqueda.Name = "SupTabItemBusqueda"
        Me.SupTabItemBusqueda.Text = "BUSQUEDA"
        '
        'MEP
        '
        Me.MEP.ContainerControl = Me
        '
        'MHighlighterFocus
        '
        Me.MHighlighterFocus.ContainerControl = Me
        '
        'MFlyoutUsuario
        '
        Me.MFlyoutUsuario.DropShadow = False
        Me.MFlyoutUsuario.Parent = Me
        Me.MFlyoutUsuario.TargetControl = Me.BubbleBarUsuario
        '
        'ModeloF1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 624)
        Me.Controls.Add(Me.SuperTabPrincipal)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModeloF1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "{...TITULO...}"
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.GroupPanelBuscador.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPanelSup.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents SuperTabPrincipal As DevComponents.DotNetBar.SuperTabControl
    Protected WithEvents SuperTabControlPanelBuscador As DevComponents.DotNetBar.SuperTabControlPanel
    Protected WithEvents SupTabItemBusqueda As DevComponents.DotNetBar.SuperTabItem
    Protected WithEvents SuperTabControlPanelRegistro As DevComponents.DotNetBar.SuperTabControlPanel
    Protected WithEvents SupTabItemRegistro As DevComponents.DotNetBar.SuperTabItem
    Protected WithEvents PanelSuperior As DevComponents.DotNetBar.PanelEx
    Protected WithEvents PanelInferior As DevComponents.DotNetBar.PanelEx
    Protected WithEvents BubbleBarUsuario As DevComponents.DotNetBar.BubbleBar
    Protected WithEvents BubbleBarTabUsuario As DevComponents.DotNetBar.BubbleBarTab
    Protected WithEvents TxtNombreUsu As System.Windows.Forms.TextBox
    Protected WithEvents PanelToolBar1 As System.Windows.Forms.Panel
    Protected WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnGrabar As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Protected WithEvents PanelToolBar2 As System.Windows.Forms.Panel
    Protected WithEvents MPanelSup As System.Windows.Forms.Panel
    Protected WithEvents PanelPrincipal As System.Windows.Forms.Panel
    Protected WithEvents GroupPanelBuscador As DevComponents.DotNetBar.Controls.GroupPanel
    Protected WithEvents JGrM_Buscador As Janus.Windows.GridEX.GridEX
    Protected WithEvents PanelUsuario As System.Windows.Forms.Panel
    Protected WithEvents lbHora As System.Windows.Forms.Label
    Protected WithEvents lbFecha As System.Windows.Forms.Label
    Protected WithEvents lbUsuario As System.Windows.Forms.Label
    Protected WithEvents lblHora As System.Windows.Forms.Label
    Protected WithEvents lblFecha As System.Windows.Forms.Label
    Protected WithEvents lblUsuario As System.Windows.Forms.Label
    Protected WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Protected WithEvents PanelNavegacion As System.Windows.Forms.Panel
    Protected WithEvents btnUltimo As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnSiguiente As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnAnterior As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnPrimero As DevComponents.DotNetBar.ButtonX
    Protected WithEvents MPanelUserAct As System.Windows.Forms.Panel
    Protected WithEvents LblPaginacion As System.Windows.Forms.Label
    Protected WithEvents MEP As System.Windows.Forms.ErrorProvider
    Protected WithEvents MHighlighterFocus As DevComponents.DotNetBar.Validator.Highlighter
    Protected WithEvents MFlyoutUsuario As DevComponents.DotNetBar.Controls.Flyout
    Friend WithEvents MRlAccion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BubbleButton1 As DevComponents.DotNetBar.BubbleButton
End Class
