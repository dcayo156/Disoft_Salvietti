﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F01_Proveedor
    Inherits Modelo.ModeloF01_ca

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
        Me.TableLayoutPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.Gp3Proveedores = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj1Busqueda = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.tbNcuenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btBuscarCuenta = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.tbCuentaProv = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TbNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TbRazonSocial = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TbEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TbNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SbEstado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.TbTelefono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControlPrincipal.SuspendLayout()
        Me.MSuperTabControlPanelRegistro.SuspendLayout()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarNavegacion.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        Me.MPanelToolBarImprimir.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelPrincipal.SuspendLayout()
        Me.Gp3Proveedores.SuspendLayout()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelDatosGenerales.SuspendLayout()
        Me.PanelExDatosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSuperTabControlPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControlPrincipal.ControlBox.MenuBox, Me.MSuperTabControlPrincipal.ControlBox.CloseBox})
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.TableLayoutPanelPrincipal)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.TableLayoutPanelPrincipal, 0)
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        '
        'MPnInferior
        '
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(179, 38)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtUltimo
        '
        '
        'MBtSiguiente
        '
        '
        'MBtAnterior
        '
        '
        'MBtPrimero
        '
        '
        'MBtSalir
        '
        '
        'MBtGrabar
        '
        '
        'MBtEliminar
        '
        '
        'MBtModificar
        '
        '
        'MBtNuevo
        '
        '
        'MBubbleBarUsuario
        '
        '
        '
        '
        Me.MBubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.MBubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.MBubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'MLbPaginacion
        '
        '
        '
        '
        Me.MLbPaginacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'TableLayoutPanelPrincipal
        '
        Me.TableLayoutPanelPrincipal.ColumnCount = 1
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.Gp3Proveedores, 0, 1)
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.GroupPanelDatosGenerales, 0, 0)
        Me.TableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal"
        Me.TableLayoutPanelPrincipal.RowCount = 2
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.Size = New System.Drawing.Size(1270, 560)
        Me.TableLayoutPanelPrincipal.TabIndex = 29
        '
        'Gp3Proveedores
        '
        Me.Gp3Proveedores.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp3Proveedores.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp3Proveedores.Controls.Add(Me.Dgj1Busqueda)
        Me.Gp3Proveedores.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp3Proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp3Proveedores.Location = New System.Drawing.Point(4, 250)
        Me.Gp3Proveedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Gp3Proveedores.Name = "Gp3Proveedores"
        Me.Gp3Proveedores.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Gp3Proveedores.Size = New System.Drawing.Size(1262, 306)
        '
        '
        '
        Me.Gp3Proveedores.Style.BackColor = System.Drawing.SystemColors.Control
        Me.Gp3Proveedores.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.Gp3Proveedores.Style.BackColorGradientAngle = 90
        Me.Gp3Proveedores.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderBottomWidth = 1
        Me.Gp3Proveedores.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp3Proveedores.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderLeftWidth = 1
        Me.Gp3Proveedores.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderRightWidth = 1
        Me.Gp3Proveedores.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderTopWidth = 1
        Me.Gp3Proveedores.Style.CornerDiameter = 4
        Me.Gp3Proveedores.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp3Proveedores.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp3Proveedores.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp3Proveedores.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp3Proveedores.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp3Proveedores.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp3Proveedores.TabIndex = 4
        Me.Gp3Proveedores.Text = "BUSQUEDA GENERAL"
        '
        'Dgj1Busqueda
        '
        Me.Dgj1Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Busqueda.Location = New System.Drawing.Point(7, 6)
        Me.Dgj1Busqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgj1Busqueda.Name = "Dgj1Busqueda"
        Me.Dgj1Busqueda.Size = New System.Drawing.Size(1242, 271)
        Me.Dgj1Busqueda.TabIndex = 0
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.PanelExDatosGenerales)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanelDatosGenerales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(1262, 238)
        '
        '
        '
        Me.GroupPanelDatosGenerales.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.Style.BackColorGradientAngle = 90
        Me.GroupPanelDatosGenerales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderBottomWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelDatosGenerales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderLeftWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderRightWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderTopWidth = 1
        Me.GroupPanelDatosGenerales.Style.CornerDiameter = 4
        Me.GroupPanelDatosGenerales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelDatosGenerales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelDatosGenerales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelDatosGenerales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelDatosGenerales.TabIndex = 3
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'PanelExDatosGenerales
        '
        Me.PanelExDatosGenerales.AutoScroll = True
        Me.PanelExDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExDatosGenerales.Controls.Add(Me.tbNcuenta)
        Me.PanelExDatosGenerales.Controls.Add(Me.btBuscarCuenta)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX9)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbCuentaProv)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX1)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbNit)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX2)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX8)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX3)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbRazonSocial)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX4)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX7)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX5)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbEmail)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbCodigo)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX6)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbNombre)
        Me.PanelExDatosGenerales.Controls.Add(Me.SbEstado)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbTelefono)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbObs)
        Me.PanelExDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PanelExDatosGenerales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelExDatosGenerales.Name = "PanelExDatosGenerales"
        Me.PanelExDatosGenerales.Size = New System.Drawing.Size(1256, 215)
        Me.PanelExDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExDatosGenerales.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExDatosGenerales.Style.GradientAngle = 90
        Me.PanelExDatosGenerales.TabIndex = 16
        '
        'tbNcuenta
        '
        '
        '
        '
        Me.tbNcuenta.Border.Class = "TextBoxBorder"
        Me.tbNcuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNcuenta.Location = New System.Drawing.Point(1068, 42)
        Me.tbNcuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNcuenta.MaxLength = 50
        Me.tbNcuenta.Name = "tbNcuenta"
        Me.tbNcuenta.PreventEnterBeep = True
        Me.tbNcuenta.Size = New System.Drawing.Size(43, 26)
        Me.tbNcuenta.TabIndex = 118
        Me.tbNcuenta.Visible = False
        '
        'btBuscarCuenta
        '
        Me.btBuscarCuenta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarCuenta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscarCuenta.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btBuscarCuenta.ImageFixedSize = New System.Drawing.Size(23, 23)
        Me.btBuscarCuenta.Location = New System.Drawing.Point(1007, 41)
        Me.btBuscarCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBuscarCuenta.Name = "btBuscarCuenta"
        Me.btBuscarCuenta.Size = New System.Drawing.Size(53, 30)
        Me.btBuscarCuenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarCuenta.TabIndex = 117
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(631, 42)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(125, 28)
        Me.LabelX9.TabIndex = 17
        Me.LabelX9.Text = "*Núm. Cuenta:"
        '
        'tbCuentaProv
        '
        '
        '
        '
        Me.tbCuentaProv.Border.Class = "TextBoxBorder"
        Me.tbCuentaProv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCuentaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCuentaProv.Location = New System.Drawing.Point(764, 42)
        Me.tbCuentaProv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCuentaProv.MaxLength = 50
        Me.tbCuentaProv.Name = "tbCuentaProv"
        Me.tbCuentaProv.PreventEnterBeep = True
        Me.tbCuentaProv.Size = New System.Drawing.Size(244, 26)
        Me.tbCuentaProv.TabIndex = 16
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(125, 28)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        '
        'TbNit
        '
        '
        '
        '
        Me.TbNit.Border.Class = "TextBoxBorder"
        Me.TbNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNit.Location = New System.Drawing.Point(137, 182)
        Me.TbNit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNit.MaxLength = 20
        Me.TbNit.Name = "TbNit"
        Me.TbNit.PreventEnterBeep = True
        Me.TbNit.Size = New System.Drawing.Size(200, 26)
        Me.TbNit.TabIndex = 5
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(4, 39)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(125, 28)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "*Nombre:"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(4, 146)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(125, 28)
        Me.LabelX8.TabIndex = 15
        Me.LabelX8.Text = "Razon Social:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(631, 4)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(125, 28)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Estado:"
        '
        'TbRazonSocial
        '
        '
        '
        '
        Me.TbRazonSocial.Border.Class = "TextBoxBorder"
        Me.TbRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbRazonSocial.Location = New System.Drawing.Point(137, 146)
        Me.TbRazonSocial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbRazonSocial.MaxLength = 50
        Me.TbRazonSocial.Name = "TbRazonSocial"
        Me.TbRazonSocial.PreventEnterBeep = True
        Me.TbRazonSocial.Size = New System.Drawing.Size(467, 26)
        Me.TbRazonSocial.TabIndex = 4
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(4, 75)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(125, 28)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Teléfono:"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(4, 182)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(125, 28)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Nit Proveedor:"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(631, 100)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(125, 28)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Observación:"
        '
        'TbEmail
        '
        '
        '
        '
        Me.TbEmail.Border.Class = "TextBoxBorder"
        Me.TbEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEmail.Location = New System.Drawing.Point(137, 111)
        Me.TbEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbEmail.MaxLength = 50
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.PreventEnterBeep = True
        Me.TbEmail.Size = New System.Drawing.Size(467, 26)
        Me.TbEmail.TabIndex = 3
        '
        'TbCodigo
        '
        '
        '
        '
        Me.TbCodigo.Border.Class = "TextBoxBorder"
        Me.TbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCodigo.Location = New System.Drawing.Point(137, 4)
        Me.TbCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.PreventEnterBeep = True
        Me.TbCodigo.Size = New System.Drawing.Size(107, 26)
        Me.TbCodigo.TabIndex = 0
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(4, 111)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(125, 28)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "E-mail:"
        '
        'TbNombre
        '
        '
        '
        '
        Me.TbNombre.Border.Class = "TextBoxBorder"
        Me.TbNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombre.Location = New System.Drawing.Point(137, 39)
        Me.TbNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNombre.MaxLength = 50
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.PreventEnterBeep = True
        Me.TbNombre.Size = New System.Drawing.Size(467, 26)
        Me.TbNombre.TabIndex = 1
        '
        'SbEstado
        '
        '
        '
        '
        Me.SbEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbEstado.Location = New System.Drawing.Point(764, 5)
        Me.SbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbEstado.Name = "SbEstado"
        Me.SbEstado.OffBackColor = System.Drawing.Color.Firebrick
        Me.SbEstado.OffText = "Inactivo"
        Me.SbEstado.OnBackColor = System.Drawing.Color.Green
        Me.SbEstado.OnText = "Activo"
        Me.SbEstado.Size = New System.Drawing.Size(133, 27)
        Me.SbEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbEstado.TabIndex = 6
        '
        'TbTelefono
        '
        '
        '
        '
        Me.TbTelefono.Border.Class = "TextBoxBorder"
        Me.TbTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTelefono.Location = New System.Drawing.Point(137, 75)
        Me.TbTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbTelefono.MaxLength = 20
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.PreventEnterBeep = True
        Me.TbTelefono.Size = New System.Drawing.Size(200, 26)
        Me.TbTelefono.TabIndex = 2
        '
        'TbObs
        '
        '
        '
        '
        Me.TbObs.Border.Class = "TextBoxBorder"
        Me.TbObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbObs.Location = New System.Drawing.Point(764, 101)
        Me.TbObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbObs.MaxLength = 200
        Me.TbObs.Multiline = True
        Me.TbObs.Name = "TbObs"
        Me.TbObs.PreventEnterBeep = True
        Me.TbObs.Size = New System.Drawing.Size(267, 74)
        Me.TbObs.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'F01_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 690)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "F01_Proveedor"
        Me.Opacity = 0.05R
        Me.Text = "F01_Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Controls.SetChildIndex(Me.MPnSuperior, 0)
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MSuperTabControlPrincipal, 0)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControlPrincipal.ResumeLayout(False)
        Me.MSuperTabControlPanelRegistro.ResumeLayout(False)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarNavegacion.ResumeLayout(False)
        Me.MPanelToolBarAccion.ResumeLayout(False)
        Me.MPanelToolBarImprimir.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelPrincipal.ResumeLayout(False)
        Me.Gp3Proveedores.ResumeLayout(False)
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TbNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbRazonSocial As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SbEstado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents TbObs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbTelefono As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Gp3Proveedores As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dgj1Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents PanelExDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCuentaProv As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btBuscarCuenta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbNcuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Timer1 As Timer
End Class
