﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F02_PedidoNuevo
    Inherits Modelo.ModeloF02_cd

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim cbPreVendedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbDistribuidor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CbCategoria_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F02_PedidoNuevo))
        Me.TableLayoutPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrPan_PeriodoPedido = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PaFrecEnDias = New System.Windows.Forms.Panel()
        Me.GrB_FrecEnDias = New System.Windows.Forms.GroupBox()
        Me.Tb_FrecEnDias = New DevComponents.Editors.IntegerInput()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Check2 = New DevComponents.DotNetBar.ButtonX()
        Me.PaFrecMensual = New System.Windows.Forms.Panel()
        Me.GrB_FrecMensual = New System.Windows.Forms.GroupBox()
        Me.Tb_FrecMensual = New DevComponents.Editors.IntegerInput()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Check3 = New DevComponents.DotNetBar.ButtonX()
        Me.PaFrecSem = New System.Windows.Forms.Panel()
        Me.GrB_FrecSemanal = New System.Windows.Forms.GroupBox()
        Me.CheckBoxX7 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX6 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX5 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX4 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Btn_Check1 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_DetallePedido = New Janus.Windows.GridEX.GridEX()
        Me.cmQuitarDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.tbCodCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_CliEstado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tb_CliCod = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tb_CliTelef = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_CliNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tb_CliDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.dtpFechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.lbFVenc = New DevComponents.DotNetBar.LabelX()
        Me.btAplicarDesc = New DevComponents.DotNetBar.ButtonX()
        Me.tbMontoCredito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swTipoVenta = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cbPreVendedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbDistribuidor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Btn_GenerarPedidos = New DevComponents.DotNetBar.ButtonX()
        Me.Tb_Estado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Lb_Estado = New DevComponents.DotNetBar.LabelX()
        Me.Tb_CliCateg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tb_CliCodZona = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Observaciones = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tb_Zona = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Hora = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Tb_CantProd2 = New DevComponents.Editors.DoubleInput()
        Me.QrFactura = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.Tb_CantProd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Btn_AddProd = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_TerminarAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.JGr_Productos = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.JGr_TipoProd = New Janus.Windows.GridEX.GridEX()
        Me.SuperTabItemCliente = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel10 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_Reclamos = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel8 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_Clientes = New Janus.Windows.GridEX.GridEX()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel12 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Tb_DireccionDetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel11 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Tb_Obs2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tb_Obs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel9 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.JGr_UltimosPedidos = New Janus.Windows.GridEX.GridEX()
        Me.Tb_TotalPedidos3Meses = New System.Windows.Forms.TextBox()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_PromCosumo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_Buscador = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx9 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.btBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaAl = New System.Windows.Forms.DateTimePicker()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaDel = New System.Windows.Forms.DateTimePicker()
        Me.ConMenu_Clientes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ACTUALIZARCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERCLIENTESACTIVOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMenu_Buscador = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VERHISTORIALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMenu_Opciones1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERHISTORIALToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGERARPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANULARPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btnVentaDirecta = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CbCategoria = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbCategoria = New DevComponents.DotNetBar.LabelX()
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControlPrincipal.SuspendLayout()
        Me.MSuperTabControlPanelBusqueda.SuspendLayout()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GrPan_PeriodoPedido.SuspendLayout()
        Me.PaFrecEnDias.SuspendLayout()
        Me.GrB_FrecEnDias.SuspendLayout()
        CType(Me.Tb_FrecEnDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaFrecMensual.SuspendLayout()
        Me.GrB_FrecMensual.SuspendLayout()
        CType(Me.Tb_FrecMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaFrecSem.SuspendLayout()
        Me.GrB_FrecSemanal.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.JGr_DetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmQuitarDetalle.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.cbPreVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDistribuidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.Tb_CantProd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGr_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.JGr_TipoProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupPanel10.SuspendLayout()
        CType(Me.JGr_Reclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel8.SuspendLayout()
        CType(Me.JGr_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupPanel12.SuspendLayout()
        Me.GroupPanel11.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        Me.GroupPanel9.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        CType(Me.JGr_UltimosPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        CType(Me.JGr_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel6.SuspendLayout()
        Me.PanelEx9.SuspendLayout()
        Me.ConMenu_Clientes.SuspendLayout()
        Me.ConMenu_Buscador.SuspendLayout()
        Me.ConMenu_Opciones1.SuspendLayout()
        CType(Me.CbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MSuperTabControlPrincipal.Controls.Add(Me.SuperTabControlPanel1)
        Me.MSuperTabControlPrincipal.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MSuperTabControlPrincipal.SelectedTabIndex = 2
        Me.MSuperTabControlPrincipal.Size = New System.Drawing.Size(1799, 692)
        Me.MSuperTabControlPrincipal.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItemCliente})
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelBusqueda, 0)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        '
        'MSuperTabControlPanelBusqueda
        '
        Me.MSuperTabControlPanelBusqueda.Controls.Add(Me.TableLayoutPanel3)
        Me.MSuperTabControlPanelBusqueda.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MSuperTabControlPanelBusqueda.Size = New System.Drawing.Size(1743, 692)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.TableLayoutPanelPrincipal)
        Me.MSuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MSuperTabControlPanelRegistro.Size = New System.Drawing.Size(1757, 692)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.TableLayoutPanelPrincipal, 0)
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Controls.Add(Me.btnVentaDirecta)
        Me.MPnSuperior.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MPnSuperior.Size = New System.Drawing.Size(1799, 86)
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        Me.MPnSuperior.Controls.SetChildIndex(Me.MPanelToolBarAccion, 0)
        Me.MPnSuperior.Controls.SetChildIndex(Me.MPanelToolBarImprimir, 0)
        Me.MPnSuperior.Controls.SetChildIndex(Me.MRlAccion, 0)
        Me.MPnSuperior.Controls.SetChildIndex(Me.btnVentaDirecta, 0)
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(0, 778)
        Me.MPnInferior.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MPnInferior.Size = New System.Drawing.Size(1799, 36)
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MPanelToolBarUsuario
        '
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(1532, 0)
        Me.MPanelToolBarUsuario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MPanelToolBarUsuario.Size = New System.Drawing.Size(267, 36)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(179, 38)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MPanelToolBarNavegacion
        '
        Me.MPanelToolBarNavegacion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MPanelToolBarNavegacion.Padding = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.MPanelToolBarNavegacion.Size = New System.Drawing.Size(427, 36)
        '
        'MBtUltimo
        '
        Me.MBtUltimo.Location = New System.Drawing.Point(180, 0)
        Me.MBtUltimo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MBtUltimo.Size = New System.Drawing.Size(57, 36)
        '
        'MBtSiguiente
        '
        Me.MBtSiguiente.Location = New System.Drawing.Point(123, 0)
        Me.MBtSiguiente.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MBtSiguiente.Size = New System.Drawing.Size(57, 36)
        '
        'MBtAnterior
        '
        Me.MBtAnterior.Location = New System.Drawing.Point(66, 0)
        Me.MBtAnterior.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MBtAnterior.Size = New System.Drawing.Size(57, 36)
        '
        'MBtPrimero
        '
        Me.MBtPrimero.Location = New System.Drawing.Point(9, 0)
        Me.MBtPrimero.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MBtPrimero.Size = New System.Drawing.Size(57, 36)
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
        'MPanelToolBarImprimir
        '
        Me.MPanelToolBarImprimir.Controls.Add(Me.btActualizar)
        Me.MPanelToolBarImprimir.Location = New System.Drawing.Point(1586, 0)
        Me.MPanelToolBarImprimir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MPanelToolBarImprimir.Size = New System.Drawing.Size(213, 86)
        Me.MPanelToolBarImprimir.Controls.SetChildIndex(Me.MBtImprimir, 0)
        Me.MPanelToolBarImprimir.Controls.SetChildIndex(Me.btActualizar, 0)
        '
        'MBtImprimir
        '
        Me.MBtImprimir.Location = New System.Drawing.Point(117, 0)
        Me.MBtImprimir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MBtImprimir.Visible = False
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
        Me.MBubbleBarUsuario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MBubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.MBubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.MBubbleBarUsuario.Size = New System.Drawing.Size(67, 36)
        '
        'MLbPaginacion
        '
        '
        '
        '
        Me.MLbPaginacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MLbPaginacion.Location = New System.Drawing.Point(237, 0)
        Me.MLbPaginacion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MLbPaginacion.Size = New System.Drawing.Size(181, 36)
        '
        'MFlyoutUsuario
        '
        '
        'MBtUsuario
        '
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
        Me.TableLayoutPanelPrincipal.ColumnCount = 2
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal"
        Me.TableLayoutPanelPrincipal.RowCount = 1
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.Size = New System.Drawing.Size(1757, 692)
        Me.TableLayoutPanelPrincipal.TabIndex = 29
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrPan_PeriodoPedido, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1221, 684)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GrPan_PeriodoPedido
        '
        Me.GrPan_PeriodoPedido.CanvasColor = System.Drawing.SystemColors.Control
        Me.GrPan_PeriodoPedido.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GrPan_PeriodoPedido.Controls.Add(Me.PaFrecEnDias)
        Me.GrPan_PeriodoPedido.Controls.Add(Me.PaFrecMensual)
        Me.GrPan_PeriodoPedido.Controls.Add(Me.PaFrecSem)
        Me.GrPan_PeriodoPedido.DisabledBackColor = System.Drawing.Color.Empty
        Me.GrPan_PeriodoPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrPan_PeriodoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrPan_PeriodoPedido.Location = New System.Drawing.Point(4, 595)
        Me.GrPan_PeriodoPedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrPan_PeriodoPedido.Name = "GrPan_PeriodoPedido"
        Me.GrPan_PeriodoPedido.Size = New System.Drawing.Size(1213, 85)
        '
        '
        '
        Me.GrPan_PeriodoPedido.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GrPan_PeriodoPedido.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GrPan_PeriodoPedido.Style.BackColorGradientAngle = 90
        Me.GrPan_PeriodoPedido.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrPan_PeriodoPedido.Style.BorderBottomWidth = 1
        Me.GrPan_PeriodoPedido.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GrPan_PeriodoPedido.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrPan_PeriodoPedido.Style.BorderLeftWidth = 1
        Me.GrPan_PeriodoPedido.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrPan_PeriodoPedido.Style.BorderRightWidth = 1
        Me.GrPan_PeriodoPedido.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrPan_PeriodoPedido.Style.BorderTopWidth = 1
        Me.GrPan_PeriodoPedido.Style.CornerDiameter = 4
        Me.GrPan_PeriodoPedido.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GrPan_PeriodoPedido.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GrPan_PeriodoPedido.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GrPan_PeriodoPedido.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GrPan_PeriodoPedido.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GrPan_PeriodoPedido.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GrPan_PeriodoPedido.TabIndex = 12
        Me.GrPan_PeriodoPedido.Text = "F R E C U E N C I A      D E L      P E D I D O "
        '
        'PaFrecEnDias
        '
        Me.PaFrecEnDias.BackColor = System.Drawing.Color.Transparent
        Me.PaFrecEnDias.Controls.Add(Me.GrB_FrecEnDias)
        Me.PaFrecEnDias.Controls.Add(Me.Btn_Check2)
        Me.PaFrecEnDias.Dock = System.Windows.Forms.DockStyle.Left
        Me.PaFrecEnDias.Location = New System.Drawing.Point(760, 0)
        Me.PaFrecEnDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaFrecEnDias.Name = "PaFrecEnDias"
        Me.PaFrecEnDias.Size = New System.Drawing.Size(293, 58)
        Me.PaFrecEnDias.TabIndex = 9
        '
        'GrB_FrecEnDias
        '
        Me.GrB_FrecEnDias.BackColor = System.Drawing.Color.Transparent
        Me.GrB_FrecEnDias.Controls.Add(Me.Tb_FrecEnDias)
        Me.GrB_FrecEnDias.Controls.Add(Me.LabelX20)
        Me.GrB_FrecEnDias.Controls.Add(Me.LabelX19)
        Me.GrB_FrecEnDias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrB_FrecEnDias.Location = New System.Drawing.Point(39, 0)
        Me.GrB_FrecEnDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrB_FrecEnDias.Name = "GrB_FrecEnDias"
        Me.GrB_FrecEnDias.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrB_FrecEnDias.Size = New System.Drawing.Size(254, 58)
        Me.GrB_FrecEnDias.TabIndex = 2
        Me.GrB_FrecEnDias.TabStop = False
        Me.GrB_FrecEnDias.Text = "Frecuencia En Dias"
        '
        'Tb_FrecEnDias
        '
        '
        '
        '
        Me.Tb_FrecEnDias.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_FrecEnDias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_FrecEnDias.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Tb_FrecEnDias.Location = New System.Drawing.Point(81, 18)
        Me.Tb_FrecEnDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_FrecEnDias.MaxValue = 31
        Me.Tb_FrecEnDias.MinValue = 1
        Me.Tb_FrecEnDias.Name = "Tb_FrecEnDias"
        Me.Tb_FrecEnDias.ShowUpDown = True
        Me.Tb_FrecEnDias.Size = New System.Drawing.Size(60, 26)
        Me.Tb_FrecEnDias.TabIndex = 27
        Me.Tb_FrecEnDias.Value = 1
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelX20.Location = New System.Drawing.Point(149, 18)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(47, 28)
        Me.LabelX20.TabIndex = 26
        Me.LabelX20.Text = "DIAS"
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelX19.Location = New System.Drawing.Point(15, 18)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(59, 28)
        Me.LabelX19.TabIndex = 25
        Me.LabelX19.Text = "CADA:"
        '
        'Btn_Check2
        '
        Me.Btn_Check2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Check2.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Check2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_Check2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Check2.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.Btn_Check2.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Check2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Check2.Name = "Btn_Check2"
        Me.Btn_Check2.Size = New System.Drawing.Size(39, 58)
        Me.Btn_Check2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Check2.TabIndex = 5
        '
        'PaFrecMensual
        '
        Me.PaFrecMensual.BackColor = System.Drawing.Color.Transparent
        Me.PaFrecMensual.Controls.Add(Me.GrB_FrecMensual)
        Me.PaFrecMensual.Controls.Add(Me.Btn_Check3)
        Me.PaFrecMensual.Dock = System.Windows.Forms.DockStyle.Left
        Me.PaFrecMensual.Location = New System.Drawing.Point(467, 0)
        Me.PaFrecMensual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaFrecMensual.Name = "PaFrecMensual"
        Me.PaFrecMensual.Size = New System.Drawing.Size(293, 58)
        Me.PaFrecMensual.TabIndex = 10
        '
        'GrB_FrecMensual
        '
        Me.GrB_FrecMensual.BackColor = System.Drawing.Color.Transparent
        Me.GrB_FrecMensual.Controls.Add(Me.Tb_FrecMensual)
        Me.GrB_FrecMensual.Controls.Add(Me.LabelX22)
        Me.GrB_FrecMensual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrB_FrecMensual.Location = New System.Drawing.Point(39, 0)
        Me.GrB_FrecMensual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrB_FrecMensual.Name = "GrB_FrecMensual"
        Me.GrB_FrecMensual.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrB_FrecMensual.Size = New System.Drawing.Size(254, 58)
        Me.GrB_FrecMensual.TabIndex = 6
        Me.GrB_FrecMensual.TabStop = False
        Me.GrB_FrecMensual.Text = "Frecuencia Mensual"
        '
        'Tb_FrecMensual
        '
        '
        '
        '
        Me.Tb_FrecMensual.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_FrecMensual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_FrecMensual.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Tb_FrecMensual.Location = New System.Drawing.Point(113, 18)
        Me.Tb_FrecMensual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_FrecMensual.MaxValue = 31
        Me.Tb_FrecMensual.MinValue = 1
        Me.Tb_FrecMensual.Name = "Tb_FrecMensual"
        Me.Tb_FrecMensual.ShowUpDown = True
        Me.Tb_FrecMensual.Size = New System.Drawing.Size(60, 26)
        Me.Tb_FrecMensual.TabIndex = 8
        Me.Tb_FrecMensual.Value = 1
        '
        'LabelX22
        '
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelX22.Location = New System.Drawing.Point(15, 18)
        Me.LabelX22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(91, 28)
        Me.LabelX22.TabIndex = 25
        Me.LabelX22.Text = "EN EL DIA:"
        '
        'Btn_Check3
        '
        Me.Btn_Check3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Check3.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Check3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_Check3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Check3.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.Btn_Check3.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Check3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Check3.Name = "Btn_Check3"
        Me.Btn_Check3.Size = New System.Drawing.Size(39, 58)
        Me.Btn_Check3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Check3.TabIndex = 7
        '
        'PaFrecSem
        '
        Me.PaFrecSem.BackColor = System.Drawing.Color.Transparent
        Me.PaFrecSem.Controls.Add(Me.GrB_FrecSemanal)
        Me.PaFrecSem.Controls.Add(Me.Btn_Check1)
        Me.PaFrecSem.Dock = System.Windows.Forms.DockStyle.Left
        Me.PaFrecSem.Location = New System.Drawing.Point(0, 0)
        Me.PaFrecSem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaFrecSem.Name = "PaFrecSem"
        Me.PaFrecSem.Size = New System.Drawing.Size(467, 58)
        Me.PaFrecSem.TabIndex = 8
        '
        'GrB_FrecSemanal
        '
        Me.GrB_FrecSemanal.BackColor = System.Drawing.Color.Transparent
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX7)
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX6)
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX5)
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX4)
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX3)
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX2)
        Me.GrB_FrecSemanal.Controls.Add(Me.CheckBoxX1)
        Me.GrB_FrecSemanal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrB_FrecSemanal.Location = New System.Drawing.Point(39, 0)
        Me.GrB_FrecSemanal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrB_FrecSemanal.Name = "GrB_FrecSemanal"
        Me.GrB_FrecSemanal.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrB_FrecSemanal.Size = New System.Drawing.Size(428, 58)
        Me.GrB_FrecSemanal.TabIndex = 1
        Me.GrB_FrecSemanal.TabStop = False
        Me.GrB_FrecSemanal.Text = "Frecuencia Semanal"
        '
        'CheckBoxX7
        '
        '
        '
        '
        Me.CheckBoxX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX7.Location = New System.Drawing.Point(336, 15)
        Me.CheckBoxX7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX7.Name = "CheckBoxX7"
        Me.CheckBoxX7.Size = New System.Drawing.Size(48, 28)
        Me.CheckBoxX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX7.TabIndex = 6
        Me.CheckBoxX7.Text = "Do"
        '
        'CheckBoxX6
        '
        '
        '
        '
        Me.CheckBoxX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX6.Location = New System.Drawing.Point(280, 15)
        Me.CheckBoxX6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX6.Name = "CheckBoxX6"
        Me.CheckBoxX6.Size = New System.Drawing.Size(48, 28)
        Me.CheckBoxX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX6.TabIndex = 5
        Me.CheckBoxX6.Text = "Sa"
        '
        'CheckBoxX5
        '
        '
        '
        '
        Me.CheckBoxX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX5.Location = New System.Drawing.Point(229, 15)
        Me.CheckBoxX5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX5.Name = "CheckBoxX5"
        Me.CheckBoxX5.Size = New System.Drawing.Size(48, 28)
        Me.CheckBoxX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX5.TabIndex = 4
        Me.CheckBoxX5.Text = "Vi"
        '
        'CheckBoxX4
        '
        '
        '
        '
        Me.CheckBoxX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX4.Location = New System.Drawing.Point(173, 15)
        Me.CheckBoxX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX4.Name = "CheckBoxX4"
        Me.CheckBoxX4.Size = New System.Drawing.Size(48, 28)
        Me.CheckBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX4.TabIndex = 3
        Me.CheckBoxX4.Text = "Ju"
        '
        'CheckBoxX3
        '
        '
        '
        '
        Me.CheckBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX3.Location = New System.Drawing.Point(120, 15)
        Me.CheckBoxX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(45, 28)
        Me.CheckBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX3.TabIndex = 2
        Me.CheckBoxX3.Text = "Mi"
        '
        'CheckBoxX2
        '
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX2.Location = New System.Drawing.Point(64, 15)
        Me.CheckBoxX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(61, 28)
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX2.TabIndex = 1
        Me.CheckBoxX2.Text = "Ma"
        '
        'CheckBoxX1
        '
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.Location = New System.Drawing.Point(9, 15)
        Me.CheckBoxX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(47, 28)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX1.TabIndex = 0
        Me.CheckBoxX1.Text = "Lu"
        '
        'Btn_Check1
        '
        Me.Btn_Check1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Check1.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Check1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_Check1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Check1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.Btn_Check1.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Check1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Check1.Name = "Btn_Check1"
        Me.Btn_Check1.Size = New System.Drawing.Size(39, 58)
        Me.Btn_Check1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Check1.TabIndex = 4
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.JGr_DetallePedido)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel5.Location = New System.Drawing.Point(4, 329)
        Me.GroupPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(1213, 258)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 11
        Me.GroupPanel5.Text = "DETALLE DE PEDIDO"
        '
        'JGr_DetallePedido
        '
        Me.JGr_DetallePedido.ContextMenuStrip = Me.cmQuitarDetalle
        Me.JGr_DetallePedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_DetallePedido.Location = New System.Drawing.Point(0, 0)
        Me.JGr_DetallePedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_DetallePedido.Name = "JGr_DetallePedido"
        Me.JGr_DetallePedido.Size = New System.Drawing.Size(1207, 231)
        Me.JGr_DetallePedido.TabIndex = 100
        '
        'cmQuitarDetalle
        '
        Me.cmQuitarDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmQuitarDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarItemToolStripMenuItem})
        Me.cmQuitarDetalle.Name = "ConMenu_Clientes"
        Me.cmQuitarDetalle.Size = New System.Drawing.Size(167, 40)
        '
        'QuitarItemToolStripMenuItem
        '
        Me.QuitarItemToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.elim_fila2
        Me.QuitarItemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitarItemToolStripMenuItem.Name = "QuitarItemToolStripMenuItem"
        Me.QuitarItemToolStripMenuItem.Size = New System.Drawing.Size(166, 36)
        Me.QuitarItemToolStripMenuItem.Text = "Quitar Item"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.PanelEx1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(1213, 140)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 9
        Me.GroupPanel3.Text = "DATOS CLIENTE"
        '
        'PanelEx1
        '
        Me.PanelEx1.AutoScroll = True
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.CbCategoria)
        Me.PanelEx1.Controls.Add(Me.lbCategoria)
        Me.PanelEx1.Controls.Add(Me.tbCodCliente)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.Tb_CliEstado)
        Me.PanelEx1.Controls.Add(Me.Tb_CliCod)
        Me.PanelEx1.Controls.Add(Me.Tb_CliTelef)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX8)
        Me.PanelEx1.Controls.Add(Me.Tb_CliNombre)
        Me.PanelEx1.Controls.Add(Me.Tb_CliDireccion)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.LabelX10)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1207, 113)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'tbCodCliente
        '
        Me.tbCodCliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbCodCliente.Border.Class = "TextBoxBorder"
        Me.tbCodCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodCliente.DisabledBackColor = System.Drawing.Color.White
        Me.tbCodCliente.ForeColor = System.Drawing.Color.Black
        Me.tbCodCliente.Location = New System.Drawing.Point(4, 75)
        Me.tbCodCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCodCliente.Name = "tbCodCliente"
        Me.tbCodCliente.PreventEnterBeep = True
        Me.tbCodCliente.Size = New System.Drawing.Size(133, 26)
        Me.tbCodCliente.TabIndex = 20
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(4, -5)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(133, 28)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "COD CLIENTE:"
        '
        'Tb_CliEstado
        '
        Me.Tb_CliEstado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliEstado.Border.Class = "TextBoxBorder"
        Me.Tb_CliEstado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliEstado.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliEstado.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliEstado.Location = New System.Drawing.Point(1063, 23)
        Me.Tb_CliEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliEstado.Name = "Tb_CliEstado"
        Me.Tb_CliEstado.PreventEnterBeep = True
        Me.Tb_CliEstado.Size = New System.Drawing.Size(200, 26)
        Me.Tb_CliEstado.TabIndex = 18
        Me.Tb_CliEstado.Visible = False
        '
        'Tb_CliCod
        '
        Me.Tb_CliCod.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliCod.Border.Class = "TextBoxBorder"
        Me.Tb_CliCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliCod.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliCod.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliCod.Location = New System.Drawing.Point(4, 23)
        Me.Tb_CliCod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliCod.Name = "Tb_CliCod"
        Me.Tb_CliCod.PreventEnterBeep = True
        Me.Tb_CliCod.Size = New System.Drawing.Size(133, 26)
        Me.Tb_CliCod.TabIndex = 11
        '
        'Tb_CliTelef
        '
        Me.Tb_CliTelef.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliTelef.Border.Class = "TextBoxBorder"
        Me.Tb_CliTelef.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliTelef.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliTelef.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliTelef.Location = New System.Drawing.Point(855, 23)
        Me.Tb_CliTelef.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliTelef.Name = "Tb_CliTelef"
        Me.Tb_CliTelef.PreventEnterBeep = True
        Me.Tb_CliTelef.Size = New System.Drawing.Size(200, 26)
        Me.Tb_CliTelef.TabIndex = 17
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(145, -5)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(152, 28)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "NOMBRE:"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(855, -5)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(129, 28)
        Me.LabelX8.TabIndex = 16
        Me.LabelX8.Text = "TELEFONO:"
        '
        'Tb_CliNombre
        '
        Me.Tb_CliNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliNombre.Border.Class = "TextBoxBorder"
        Me.Tb_CliNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliNombre.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliNombre.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliNombre.Location = New System.Drawing.Point(145, 23)
        Me.Tb_CliNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliNombre.Multiline = True
        Me.Tb_CliNombre.Name = "Tb_CliNombre"
        Me.Tb_CliNombre.PreventEnterBeep = True
        Me.Tb_CliNombre.Size = New System.Drawing.Size(287, 80)
        Me.Tb_CliNombre.TabIndex = 13
        '
        'Tb_CliDireccion
        '
        Me.Tb_CliDireccion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliDireccion.Border.Class = "TextBoxBorder"
        Me.Tb_CliDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliDireccion.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliDireccion.Location = New System.Drawing.Point(440, 23)
        Me.Tb_CliDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliDireccion.Multiline = True
        Me.Tb_CliDireccion.Name = "Tb_CliDireccion"
        Me.Tb_CliDireccion.PreventEnterBeep = True
        Me.Tb_CliDireccion.Size = New System.Drawing.Size(388, 80)
        Me.Tb_CliDireccion.TabIndex = 15
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(440, -5)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(180, 28)
        Me.LabelX7.TabIndex = 14
        Me.LabelX7.Text = "DIRECCION:"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(4, 47)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(131, 28)
        Me.LabelX10.TabIndex = 19
        Me.LabelX10.Text = "COD CLIENTE:"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.PanelEx2)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(4, 152)
        Me.GroupPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1213, 169)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 10
        Me.GroupPanel4.Text = "DATOS PEDIDO"
        '
        'PanelEx2
        '
        Me.PanelEx2.AutoScroll = True
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dtpFechaVenc)
        Me.PanelEx2.Controls.Add(Me.lbFVenc)
        Me.PanelEx2.Controls.Add(Me.btAplicarDesc)
        Me.PanelEx2.Controls.Add(Me.tbMontoCredito)
        Me.PanelEx2.Controls.Add(Me.swTipoVenta)
        Me.PanelEx2.Controls.Add(Me.LabelX12)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Controls.Add(Me.cbPreVendedor)
        Me.PanelEx2.Controls.Add(Me.cbDistribuidor)
        Me.PanelEx2.Controls.Add(Me.Btn_GenerarPedidos)
        Me.PanelEx2.Controls.Add(Me.Tb_Estado)
        Me.PanelEx2.Controls.Add(Me.Lb_Estado)
        Me.PanelEx2.Controls.Add(Me.Tb_CliCateg)
        Me.PanelEx2.Controls.Add(Me.Tb_CliCodZona)
        Me.PanelEx2.Controls.Add(Me.LabelX9)
        Me.PanelEx2.Controls.Add(Me.Tb_Observaciones)
        Me.PanelEx2.Controls.Add(Me.Tb_Zona)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.Tb_Hora)
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.Tb_Fecha)
        Me.PanelEx2.Controls.Add(Me.LabelX11)
        Me.PanelEx2.Controls.Add(Me.LabelX14)
        Me.PanelEx2.Controls.Add(Me.Tb_Id)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1207, 142)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 8
        '
        'dtpFechaVenc
        '
        Me.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenc.Location = New System.Drawing.Point(997, 97)
        Me.dtpFechaVenc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaVenc.Name = "dtpFechaVenc"
        Me.dtpFechaVenc.Size = New System.Drawing.Size(159, 26)
        Me.dtpFechaVenc.TabIndex = 46
        '
        'lbFVenc
        '
        '
        '
        '
        Me.lbFVenc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFVenc.Location = New System.Drawing.Point(997, 69)
        Me.lbFVenc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbFVenc.Name = "lbFVenc"
        Me.lbFVenc.Size = New System.Drawing.Size(125, 28)
        Me.lbFVenc.TabIndex = 47
        Me.lbFVenc.Text = "FECHA VENC.:"
        '
        'btAplicarDesc
        '
        Me.btAplicarDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAplicarDesc.BackColor = System.Drawing.Color.Transparent
        Me.btAplicarDesc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAplicarDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAplicarDesc.Image = Global.Presentacion.My.Resources.Resources.descuentos
        Me.btAplicarDesc.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btAplicarDesc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btAplicarDesc.Location = New System.Drawing.Point(873, 69)
        Me.btAplicarDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btAplicarDesc.Name = "btAplicarDesc"
        Me.btAplicarDesc.Size = New System.Drawing.Size(116, 64)
        Me.btAplicarDesc.TabIndex = 44
        Me.btAplicarDesc.Text = "APLICAR DESCUENTOS"
        Me.btAplicarDesc.TextColor = System.Drawing.Color.Navy
        '
        'tbMontoCredito
        '
        '
        '
        '
        Me.tbMontoCredito.Border.Class = "TextBoxBorder"
        Me.tbMontoCredito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoCredito.Location = New System.Drawing.Point(1024, 32)
        Me.tbMontoCredito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMontoCredito.Name = "tbMontoCredito"
        Me.tbMontoCredito.PreventEnterBeep = True
        Me.tbMontoCredito.Size = New System.Drawing.Size(133, 26)
        Me.tbMontoCredito.TabIndex = 43
        '
        'swTipoVenta
        '
        '
        '
        '
        Me.swTipoVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swTipoVenta.Location = New System.Drawing.Point(873, 32)
        Me.swTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.swTipoVenta.Name = "swTipoVenta"
        Me.swTipoVenta.OffBackColor = System.Drawing.Color.Cyan
        Me.swTipoVenta.OffText = "CREDITO"
        Me.swTipoVenta.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swTipoVenta.OnText = "CONTADO"
        Me.swTipoVenta.Size = New System.Drawing.Size(145, 27)
        Me.swTipoVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swTipoVenta.TabIndex = 45
        Me.swTipoVenta.Value = True
        Me.swTipoVenta.ValueObject = "Y"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(327, 0)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(149, 28)
        Me.LabelX12.TabIndex = 39
        Me.LabelX12.Text = "PRE-VENDEDOR:"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(741, 0)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(133, 28)
        Me.LabelX1.TabIndex = 38
        Me.LabelX1.Text = "DISTRIBUIDOR:"
        Me.LabelX1.Visible = False
        '
        'cbPreVendedor
        '
        cbPreVendedor_DesignTimeLayout.LayoutString = resources.GetString("cbPreVendedor_DesignTimeLayout.LayoutString")
        Me.cbPreVendedor.DesignTimeLayout = cbPreVendedor_DesignTimeLayout
        Me.cbPreVendedor.Location = New System.Drawing.Point(477, 0)
        Me.cbPreVendedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPreVendedor.Name = "cbPreVendedor"
        Me.cbPreVendedor.SelectedIndex = -1
        Me.cbPreVendedor.SelectedItem = Nothing
        Me.cbPreVendedor.Size = New System.Drawing.Size(240, 26)
        Me.cbPreVendedor.TabIndex = 37
        '
        'cbDistribuidor
        '
        cbDistribuidor_DesignTimeLayout.LayoutString = resources.GetString("cbDistribuidor_DesignTimeLayout.LayoutString")
        Me.cbDistribuidor.DesignTimeLayout = cbDistribuidor_DesignTimeLayout
        Me.cbDistribuidor.Location = New System.Drawing.Point(883, 0)
        Me.cbDistribuidor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDistribuidor.Name = "cbDistribuidor"
        Me.cbDistribuidor.SelectedIndex = -1
        Me.cbDistribuidor.SelectedItem = Nothing
        Me.cbDistribuidor.Size = New System.Drawing.Size(240, 26)
        Me.cbDistribuidor.TabIndex = 36
        Me.cbDistribuidor.Visible = False
        '
        'Btn_GenerarPedidos
        '
        Me.Btn_GenerarPedidos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_GenerarPedidos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_GenerarPedidos.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_GenerarPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GenerarPedidos.Image = Global.Presentacion.My.Resources.Resources.GEN_PEDIDOS_AUTOMATICAMENTE_ORI
        Me.Btn_GenerarPedidos.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.Btn_GenerarPedidos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_GenerarPedidos.Location = New System.Drawing.Point(1065, 97)
        Me.Btn_GenerarPedidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_GenerarPedidos.Name = "Btn_GenerarPedidos"
        Me.Btn_GenerarPedidos.Size = New System.Drawing.Size(97, 63)
        Me.Btn_GenerarPedidos.TabIndex = 35
        Me.Btn_GenerarPedidos.Text = "GENERAR PEDIDOS"
        Me.Btn_GenerarPedidos.TextColor = System.Drawing.Color.Navy
        '
        'Tb_Estado
        '
        '
        '
        '
        Me.Tb_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Estado.Location = New System.Drawing.Point(264, 137)
        Me.Tb_Estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Estado.Name = "Tb_Estado"
        Me.Tb_Estado.OffText = "INACTIVO"
        Me.Tb_Estado.OnText = "ACTIVO"
        Me.Tb_Estado.Size = New System.Drawing.Size(117, 27)
        Me.Tb_Estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Tb_Estado.TabIndex = 34
        '
        'Lb_Estado
        '
        '
        '
        '
        Me.Lb_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lb_Estado.Location = New System.Drawing.Point(171, 135)
        Me.Lb_Estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Lb_Estado.Name = "Lb_Estado"
        Me.Lb_Estado.Size = New System.Drawing.Size(85, 28)
        Me.Lb_Estado.TabIndex = 33
        Me.Lb_Estado.Text = "ESTADO:"
        '
        'Tb_CliCateg
        '
        Me.Tb_CliCateg.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliCateg.Border.Class = "TextBoxBorder"
        Me.Tb_CliCateg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliCateg.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliCateg.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliCateg.Location = New System.Drawing.Point(4, 97)
        Me.Tb_CliCateg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliCateg.Name = "Tb_CliCateg"
        Me.Tb_CliCateg.PreventEnterBeep = True
        Me.Tb_CliCateg.Size = New System.Drawing.Size(107, 26)
        Me.Tb_CliCateg.TabIndex = 30
        Me.Tb_CliCateg.Visible = False
        '
        'Tb_CliCodZona
        '
        Me.Tb_CliCodZona.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_CliCodZona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CliCodZona.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_CliCodZona.ForeColor = System.Drawing.Color.Black
        Me.Tb_CliCodZona.Location = New System.Drawing.Point(389, 137)
        Me.Tb_CliCodZona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CliCodZona.Multiline = True
        Me.Tb_CliCodZona.Name = "Tb_CliCodZona"
        Me.Tb_CliCodZona.PreventEnterBeep = True
        Me.Tb_CliCodZona.Size = New System.Drawing.Size(107, 25)
        Me.Tb_CliCodZona.TabIndex = 29
        Me.Tb_CliCodZona.Visible = False
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(1, 62)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(163, 28)
        Me.LabelX9.TabIndex = 32
        Me.LabelX9.Text = "OBSERVACIONES:"
        '
        'Tb_Observaciones
        '
        Me.Tb_Observaciones.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_Observaciones.Border.Class = "TextBoxBorder"
        Me.Tb_Observaciones.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Observaciones.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_Observaciones.ForeColor = System.Drawing.Color.Black
        Me.Tb_Observaciones.Location = New System.Drawing.Point(171, 65)
        Me.Tb_Observaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Observaciones.MaxLength = 100
        Me.Tb_Observaciones.Multiline = True
        Me.Tb_Observaciones.Name = "Tb_Observaciones"
        Me.Tb_Observaciones.PreventEnterBeep = True
        Me.Tb_Observaciones.Size = New System.Drawing.Size(695, 68)
        Me.Tb_Observaciones.TabIndex = 22
        '
        'Tb_Zona
        '
        Me.Tb_Zona.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_Zona.Border.Class = "TextBoxBorder"
        Me.Tb_Zona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Zona.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_Zona.ForeColor = System.Drawing.Color.Black
        Me.Tb_Zona.Location = New System.Drawing.Point(612, 33)
        Me.Tb_Zona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Zona.Name = "Tb_Zona"
        Me.Tb_Zona.PreventEnterBeep = True
        Me.Tb_Zona.Size = New System.Drawing.Size(253, 26)
        Me.Tb_Zona.TabIndex = 27
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(540, 32)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(60, 28)
        Me.LabelX4.TabIndex = 31
        Me.LabelX4.Text = "ZONA:"
        '
        'Tb_Hora
        '
        Me.Tb_Hora.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_Hora.Border.Class = "TextBoxBorder"
        Me.Tb_Hora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Hora.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_Hora.ForeColor = System.Drawing.Color.Black
        Me.Tb_Hora.Location = New System.Drawing.Point(405, 32)
        Me.Tb_Hora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Hora.Name = "Tb_Hora"
        Me.Tb_Hora.PreventEnterBeep = True
        Me.Tb_Hora.Size = New System.Drawing.Size(117, 26)
        Me.Tb_Hora.TabIndex = 26
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(332, 32)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(65, 28)
        Me.LabelX3.TabIndex = 28
        Me.LabelX3.Text = "HORA:"
        '
        'Tb_Fecha
        '
        Me.Tb_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Tb_Fecha.Location = New System.Drawing.Point(136, 33)
        Me.Tb_Fecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Fecha.Name = "Tb_Fecha"
        Me.Tb_Fecha.Size = New System.Drawing.Size(181, 26)
        Me.Tb_Fecha.TabIndex = 21
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(4, 32)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(91, 28)
        Me.LabelX11.TabIndex = 24
        Me.LabelX11.Text = "FECHA:"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(4, -1)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(123, 28)
        Me.LabelX14.TabIndex = 23
        Me.LabelX14.Text = "COD. PEDIDO:"
        '
        'Tb_Id
        '
        Me.Tb_Id.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tb_Id.Border.Class = "TextBoxBorder"
        Me.Tb_Id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Id.DisabledBackColor = System.Drawing.Color.White
        Me.Tb_Id.ForeColor = System.Drawing.Color.Black
        Me.Tb_Id.Location = New System.Drawing.Point(137, 0)
        Me.Tb_Id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Id.Name = "Tb_Id"
        Me.Tb_Id.PreventEnterBeep = True
        Me.Tb_Id.Size = New System.Drawing.Size(183, 26)
        Me.Tb_Id.TabIndex = 25
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupPanel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupPanel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1233, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.09991009!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.90009!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(520, 684)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx4)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(512, 676)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 3
        Me.GroupPanel1.Text = "SELECCIONAR PRODUCTO"
        '
        'PanelEx4
        '
        Me.PanelEx4.AutoScroll = True
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Tb_CantProd2)
        Me.PanelEx4.Controls.Add(Me.QrFactura)
        Me.PanelEx4.Controls.Add(Me.Tb_CantProd)
        Me.PanelEx4.Controls.Add(Me.Btn_AddProd)
        Me.PanelEx4.Controls.Add(Me.Btn_TerminarAdd)
        Me.PanelEx4.Controls.Add(Me.LabelX2)
        Me.PanelEx4.Controls.Add(Me.JGr_Productos)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(506, 649)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 25
        '
        'Tb_CantProd2
        '
        Me.Tb_CantProd2.AutoOverwrite = True
        '
        '
        '
        Me.Tb_CantProd2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_CantProd2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CantProd2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Tb_CantProd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_CantProd2.ForeColor = System.Drawing.Color.Black
        Me.Tb_CantProd2.Increment = 1.0R
        Me.Tb_CantProd2.Location = New System.Drawing.Point(96, 545)
        Me.Tb_CantProd2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CantProd2.MinValue = 0R
        Me.Tb_CantProd2.Name = "Tb_CantProd2"
        Me.Tb_CantProd2.Size = New System.Drawing.Size(133, 30)
        Me.Tb_CantProd2.TabIndex = 29
        Me.Tb_CantProd2.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'QrFactura
        '
        Me.QrFactura.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrFactura.Image = CType(resources.GetObject("QrFactura.Image"), System.Drawing.Image)
        Me.QrFactura.Location = New System.Drawing.Point(20, 587)
        Me.QrFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QrFactura.Name = "QrFactura"
        Me.QrFactura.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrFactura.Size = New System.Drawing.Size(59, 47)
        Me.QrFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrFactura.TabIndex = 28
        Me.QrFactura.TabStop = False
        Me.QrFactura.Text = "QrCodeImgControl1"
        Me.QrFactura.Visible = False
        '
        'Tb_CantProd
        '
        '
        '
        '
        Me.Tb_CantProd.Border.Class = "TextBoxBorder"
        Me.Tb_CantProd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_CantProd.Location = New System.Drawing.Point(96, 606)
        Me.Tb_CantProd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_CantProd.Name = "Tb_CantProd"
        Me.Tb_CantProd.PreventEnterBeep = True
        Me.Tb_CantProd.Size = New System.Drawing.Size(133, 26)
        Me.Tb_CantProd.TabIndex = 27
        Me.Tb_CantProd.Visible = False
        '
        'Btn_AddProd
        '
        Me.Btn_AddProd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_AddProd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_AddProd.Image = Global.Presentacion.My.Resources.Resources.add21
        Me.Btn_AddProd.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_AddProd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_AddProd.Location = New System.Drawing.Point(345, 538)
        Me.Btn_AddProd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_AddProd.Name = "Btn_AddProd"
        Me.Btn_AddProd.Size = New System.Drawing.Size(100, 71)
        Me.Btn_AddProd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_AddProd.TabIndex = 5
        Me.Btn_AddProd.Text = "Adicionar"
        Me.Btn_AddProd.Visible = False
        '
        'Btn_TerminarAdd
        '
        Me.Btn_TerminarAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_TerminarAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_TerminarAdd.Image = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.Btn_TerminarAdd.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_TerminarAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_TerminarAdd.Location = New System.Drawing.Point(237, 538)
        Me.Btn_TerminarAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_TerminarAdd.Name = "Btn_TerminarAdd"
        Me.Btn_TerminarAdd.Size = New System.Drawing.Size(100, 71)
        Me.Btn_TerminarAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_TerminarAdd.TabIndex = 6
        Me.Btn_TerminarAdd.Text = "Terminar"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(5, 545)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 28)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Cantidad:"
        '
        'JGr_Productos
        '
        Me.JGr_Productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.JGr_Productos.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_Productos.Name = "JGr_Productos"
        Me.JGr_Productos.Size = New System.Drawing.Size(506, 530)
        Me.JGr_Productos.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.PanelEx3)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(512, 1)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "SELECCIONAR CATEGORIA"
        Me.GroupPanel2.Visible = False
        '
        'PanelEx3
        '
        Me.PanelEx3.AutoScroll = True
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.JGr_TipoProd)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(506, 8)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 18
        '
        'JGr_TipoProd
        '
        Me.JGr_TipoProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_TipoProd.Location = New System.Drawing.Point(0, 0)
        Me.JGr_TipoProd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_TipoProd.Name = "JGr_TipoProd"
        Me.JGr_TipoProd.Size = New System.Drawing.Size(506, 8)
        Me.JGr_TipoProd.TabIndex = 0
        '
        'SuperTabItemCliente
        '
        Me.SuperTabItemCliente.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItemCliente.GlobalItem = False
        Me.SuperTabItemCliente.Name = "SuperTabItemCliente"
        Me.SuperTabItemCliente.Text = "CLIENTE"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.TableLayoutPanel4)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1743, 692)
        Me.SuperTabControlPanel1.TabIndex = 0
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItemCliente
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1743, 692)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GroupPanel10, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupPanel8, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1212, 684)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'GroupPanel10
        '
        Me.GroupPanel10.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel10.Controls.Add(Me.JGr_Reclamos)
        Me.GroupPanel10.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel10.Location = New System.Drawing.Point(4, 517)
        Me.GroupPanel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel10.Name = "GroupPanel10"
        Me.GroupPanel10.Size = New System.Drawing.Size(1204, 163)
        '
        '
        '
        Me.GroupPanel10.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel10.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel10.Style.BackColorGradientAngle = 90
        Me.GroupPanel10.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderBottomWidth = 1
        Me.GroupPanel10.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel10.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderLeftWidth = 1
        Me.GroupPanel10.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderRightWidth = 1
        Me.GroupPanel10.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderTopWidth = 1
        Me.GroupPanel10.Style.CornerDiameter = 4
        Me.GroupPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel10.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel10.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel10.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel10.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel10.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel10.TabIndex = 12
        Me.GroupPanel10.Text = "R E C L A M O S      G R A B A D O S"
        '
        'JGr_Reclamos
        '
        Me.JGr_Reclamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Reclamos.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Reclamos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_Reclamos.Name = "JGr_Reclamos"
        Me.JGr_Reclamos.Size = New System.Drawing.Size(1198, 136)
        Me.JGr_Reclamos.TabIndex = 1
        '
        'GroupPanel8
        '
        Me.GroupPanel8.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel8.Controls.Add(Me.JGr_Clientes)
        Me.GroupPanel8.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel8.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel8.Name = "GroupPanel8"
        Me.GroupPanel8.Size = New System.Drawing.Size(1204, 505)
        '
        '
        '
        Me.GroupPanel8.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel8.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel8.Style.BackColorGradientAngle = 90
        Me.GroupPanel8.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderBottomWidth = 1
        Me.GroupPanel8.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel8.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderLeftWidth = 1
        Me.GroupPanel8.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderRightWidth = 1
        Me.GroupPanel8.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderTopWidth = 1
        Me.GroupPanel8.Style.CornerDiameter = 4
        Me.GroupPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel8.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel8.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel8.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel8.TabIndex = 0
        Me.GroupPanel8.Text = "BUSQUEDA CLIENTES"
        '
        'JGr_Clientes
        '
        Me.JGr_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Clientes.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_Clientes.Name = "JGr_Clientes"
        Me.JGr_Clientes.Size = New System.Drawing.Size(1198, 478)
        Me.JGr_Clientes.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupPanel12, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupPanel11, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupPanel9, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(1224, 4)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(515, 684)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'GroupPanel12
        '
        Me.GroupPanel12.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel12.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel12.Controls.Add(Me.Tb_DireccionDetalle)
        Me.GroupPanel12.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel12.Location = New System.Drawing.Point(4, 551)
        Me.GroupPanel12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel12.Name = "GroupPanel12"
        Me.GroupPanel12.Size = New System.Drawing.Size(507, 129)
        '
        '
        '
        Me.GroupPanel12.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel12.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel12.Style.BackColorGradientAngle = 90
        Me.GroupPanel12.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderBottomWidth = 1
        Me.GroupPanel12.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel12.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderLeftWidth = 1
        Me.GroupPanel12.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderRightWidth = 1
        Me.GroupPanel12.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel12.Style.BorderTopWidth = 1
        Me.GroupPanel12.Style.CornerDiameter = 4
        Me.GroupPanel12.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel12.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel12.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel12.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel12.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel12.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel12.TabIndex = 3
        Me.GroupPanel12.Text = "DIRECCION DEL CLIENTE"
        '
        'Tb_DireccionDetalle
        '
        '
        '
        '
        Me.Tb_DireccionDetalle.Border.Class = "TextBoxBorder"
        Me.Tb_DireccionDetalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_DireccionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_DireccionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_DireccionDetalle.Location = New System.Drawing.Point(0, 0)
        Me.Tb_DireccionDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_DireccionDetalle.Multiline = True
        Me.Tb_DireccionDetalle.Name = "Tb_DireccionDetalle"
        Me.Tb_DireccionDetalle.PreventEnterBeep = True
        Me.Tb_DireccionDetalle.ReadOnly = True
        Me.Tb_DireccionDetalle.Size = New System.Drawing.Size(501, 102)
        Me.Tb_DireccionDetalle.TabIndex = 0
        '
        'GroupPanel11
        '
        Me.GroupPanel11.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel11.Controls.Add(Me.PanelEx6)
        Me.GroupPanel11.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel11.Location = New System.Drawing.Point(4, 346)
        Me.GroupPanel11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel11.Name = "GroupPanel11"
        Me.GroupPanel11.Size = New System.Drawing.Size(507, 197)
        '
        '
        '
        Me.GroupPanel11.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel11.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel11.Style.BackColorGradientAngle = 90
        Me.GroupPanel11.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderBottomWidth = 1
        Me.GroupPanel11.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel11.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderLeftWidth = 1
        Me.GroupPanel11.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderRightWidth = 1
        Me.GroupPanel11.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel11.Style.BorderTopWidth = 1
        Me.GroupPanel11.Style.CornerDiameter = 4
        Me.GroupPanel11.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel11.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel11.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel11.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel11.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel11.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel11.TabIndex = 2
        Me.GroupPanel11.Text = "OBSERVACIONES"
        '
        'PanelEx6
        '
        Me.PanelEx6.AutoScroll = True
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.Tb_Obs2)
        Me.PanelEx6.Controls.Add(Me.Tb_Obs)
        Me.PanelEx6.Controls.Add(Me.LabelX21)
        Me.PanelEx6.Controls.Add(Me.LabelX23)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(501, 170)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx6.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 4
        '
        'Tb_Obs2
        '
        '
        '
        '
        Me.Tb_Obs2.Border.Class = "TextBoxBorder"
        Me.Tb_Obs2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Obs2.Location = New System.Drawing.Point(5, 98)
        Me.Tb_Obs2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Obs2.Multiline = True
        Me.Tb_Obs2.Name = "Tb_Obs2"
        Me.Tb_Obs2.PreventEnterBeep = True
        Me.Tb_Obs2.Size = New System.Drawing.Size(427, 49)
        Me.Tb_Obs2.TabIndex = 3
        Me.Tb_Obs2.Visible = False
        '
        'Tb_Obs
        '
        '
        '
        '
        Me.Tb_Obs.Border.Class = "TextBoxBorder"
        Me.Tb_Obs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Obs.Location = New System.Drawing.Point(5, 28)
        Me.Tb_Obs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Obs.Multiline = True
        Me.Tb_Obs.Name = "Tb_Obs"
        Me.Tb_Obs.PreventEnterBeep = True
        Me.Tb_Obs.Size = New System.Drawing.Size(427, 49)
        Me.Tb_Obs.TabIndex = 0
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(5, 74)
        Me.LabelX21.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(152, 28)
        Me.LabelX21.TabIndex = 2
        Me.LabelX21.Text = "OBS. ADICIONAL:"
        Me.LabelX21.Visible = False
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Location = New System.Drawing.Point(5, 4)
        Me.LabelX23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(139, 28)
        Me.LabelX23.TabIndex = 1
        Me.LabelX23.Text = "OBSERVACION:"
        '
        'GroupPanel9
        '
        Me.GroupPanel9.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel9.Controls.Add(Me.PanelEx5)
        Me.GroupPanel9.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel9.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel9.Name = "GroupPanel9"
        Me.GroupPanel9.Size = New System.Drawing.Size(507, 334)
        '
        '
        '
        Me.GroupPanel9.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel9.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel9.Style.BackColorGradientAngle = 90
        Me.GroupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderBottomWidth = 1
        Me.GroupPanel9.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderLeftWidth = 1
        Me.GroupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderRightWidth = 1
        Me.GroupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderTopWidth = 1
        Me.GroupPanel9.Style.CornerDiameter = 4
        Me.GroupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel9.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel9.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel9.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel9.TabIndex = 1
        Me.GroupPanel9.Text = "ULTIMOS PEDIDOS"
        '
        'PanelEx5
        '
        Me.PanelEx5.AutoScroll = True
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.JGr_UltimosPedidos)
        Me.PanelEx5.Controls.Add(Me.Tb_TotalPedidos3Meses)
        Me.PanelEx5.Controls.Add(Me.LabelX18)
        Me.PanelEx5.Controls.Add(Me.LabelX16)
        Me.PanelEx5.Controls.Add(Me.Tb_PromCosumo)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(501, 307)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 14
        '
        'JGr_UltimosPedidos
        '
        Me.JGr_UltimosPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.JGr_UltimosPedidos.Location = New System.Drawing.Point(0, 0)
        Me.JGr_UltimosPedidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_UltimosPedidos.Name = "JGr_UltimosPedidos"
        Me.JGr_UltimosPedidos.Size = New System.Drawing.Size(501, 209)
        Me.JGr_UltimosPedidos.TabIndex = 0
        '
        'Tb_TotalPedidos3Meses
        '
        Me.Tb_TotalPedidos3Meses.Location = New System.Drawing.Point(321, 217)
        Me.Tb_TotalPedidos3Meses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_TotalPedidos3Meses.Name = "Tb_TotalPedidos3Meses"
        Me.Tb_TotalPedidos3Meses.Size = New System.Drawing.Size(91, 26)
        Me.Tb_TotalPedidos3Meses.TabIndex = 13
        Me.Tb_TotalPedidos3Meses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Location = New System.Drawing.Point(0, 252)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(319, 28)
        Me.LabelX18.TabIndex = 9
        Me.LabelX18.Text = "PROMEDIO CONSUMO EN DIAS.......:"
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(0, 217)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(319, 28)
        Me.LabelX16.TabIndex = 12
        Me.LabelX16.Text = "TOTAL PEDIDOS ULTIMOS 3 MESES:"
        '
        'Tb_PromCosumo
        '
        Me.Tb_PromCosumo.Location = New System.Drawing.Point(321, 252)
        Me.Tb_PromCosumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_PromCosumo.Name = "Tb_PromCosumo"
        Me.Tb_PromCosumo.Size = New System.Drawing.Size(91, 26)
        Me.Tb_PromCosumo.TabIndex = 11
        Me.Tb_PromCosumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupPanel7, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupPanel6, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1743, 692)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.JGr_Buscador)
        Me.GroupPanel7.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel7.Location = New System.Drawing.Point(4, 115)
        Me.GroupPanel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(1735, 573)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel7.TabIndex = 1
        Me.GroupPanel7.Text = "BUSQUEDA GENERAL"
        '
        'JGr_Buscador
        '
        Me.JGr_Buscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Buscador.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGr_Buscador.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Buscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JGr_Buscador.Name = "JGr_Buscador"
        Me.JGr_Buscador.Size = New System.Drawing.Size(1729, 546)
        Me.JGr_Buscador.TabIndex = 1
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.PanelEx9)
        Me.GroupPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel6.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(1735, 103)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 0
        Me.GroupPanel6.Text = "FILTRO GENERAL"
        '
        'PanelEx9
        '
        Me.PanelEx9.AutoScroll = True
        Me.PanelEx9.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx9.Controls.Add(Me.ButtonX3)
        Me.PanelEx9.Controls.Add(Me.btBuscar)
        Me.PanelEx9.Controls.Add(Me.LabelX17)
        Me.PanelEx9.Controls.Add(Me.tbFechaAl)
        Me.PanelEx9.Controls.Add(Me.LabelX15)
        Me.PanelEx9.Controls.Add(Me.tbFechaDel)
        Me.PanelEx9.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx9.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx9.Name = "PanelEx9"
        Me.PanelEx9.Size = New System.Drawing.Size(1729, 76)
        Me.PanelEx9.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx9.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx9.Style.GradientAngle = 90
        Me.PanelEx9.TabIndex = 5
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonX3.Location = New System.Drawing.Point(816, 10)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(284, 60)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 5
        Me.ButtonX3.Text = "MOSTRAR ULTIMOS 100 PEDIDOS"
        Me.ButtonX3.Visible = False
        '
        'btBuscar
        '
        Me.btBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btBuscar.Location = New System.Drawing.Point(616, 10)
        Me.btBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(192, 60)
        Me.btBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscar.TabIndex = 4
        Me.btBuscar.Text = "BUSCAR POR FECHA"
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(312, 20)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(71, 28)
        Me.LabelX17.TabIndex = 3
        Me.LabelX17.Text = "AL:"
        '
        'tbFechaAl
        '
        Me.tbFechaAl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaAl.Location = New System.Drawing.Point(391, 20)
        Me.tbFechaAl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFechaAl.Name = "tbFechaAl"
        Me.tbFechaAl.Size = New System.Drawing.Size(164, 26)
        Me.tbFechaAl.TabIndex = 2
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(16, 20)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(71, 28)
        Me.LabelX15.TabIndex = 1
        Me.LabelX15.Text = "DEL:"
        '
        'tbFechaDel
        '
        Me.tbFechaDel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaDel.Location = New System.Drawing.Point(95, 20)
        Me.tbFechaDel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFechaDel.Name = "tbFechaDel"
        Me.tbFechaDel.Size = New System.Drawing.Size(164, 26)
        Me.tbFechaDel.TabIndex = 0
        '
        'ConMenu_Clientes
        '
        Me.ConMenu_Clientes.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Clientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACTUALIZARCLIENTESToolStripMenuItem, Me.VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem, Me.VERCLIENTESACTIVOSToolStripMenuItem})
        Me.ConMenu_Clientes.Name = "ConMenu_Clientes"
        Me.ConMenu_Clientes.Size = New System.Drawing.Size(308, 76)
        '
        'ACTUALIZARCLIENTESToolStripMenuItem
        '
        Me.ACTUALIZARCLIENTESToolStripMenuItem.Name = "ACTUALIZARCLIENTESToolStripMenuItem"
        Me.ACTUALIZARCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(307, 24)
        Me.ACTUALIZARCLIENTESToolStripMenuItem.Text = "ACTUALIZAR CLIENTES"
        '
        'VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem
        '
        Me.VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem.Name = "VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem"
        Me.VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem.Size = New System.Drawing.Size(307, 24)
        Me.VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem.Text = "VER CLIENTES PASIVOS Y ACTIVOS"
        '
        'VERCLIENTESACTIVOSToolStripMenuItem
        '
        Me.VERCLIENTESACTIVOSToolStripMenuItem.Name = "VERCLIENTESACTIVOSToolStripMenuItem"
        Me.VERCLIENTESACTIVOSToolStripMenuItem.Size = New System.Drawing.Size(307, 24)
        Me.VERCLIENTESACTIVOSToolStripMenuItem.Text = "VER CLIENTES ACTIVOS"
        '
        'ConMenu_Buscador
        '
        Me.ConMenu_Buscador.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Buscador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VERHISTORIALToolStripMenuItem})
        Me.ConMenu_Buscador.Name = "ConMenu_Buscador"
        Me.ConMenu_Buscador.Size = New System.Drawing.Size(172, 28)
        '
        'VERHISTORIALToolStripMenuItem
        '
        Me.VERHISTORIALToolStripMenuItem.Name = "VERHISTORIALToolStripMenuItem"
        Me.VERHISTORIALToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.VERHISTORIALToolStripMenuItem.Text = "VER ESTADOS"
        '
        'ConMenu_Opciones1
        '
        Me.ConMenu_Opciones1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Opciones1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.GRABARRECLAMOREPARTIDORToolStripMenuItem, Me.VERHISTORIALToolStripMenuItem1, Me.REGERARPEDIDOToolStripMenuItem, Me.ANULARPEDIDOToolStripMenuItem})
        Me.ConMenu_Opciones1.Name = "ConMenu_Opciones"
        Me.ConMenu_Opciones1.Size = New System.Drawing.Size(296, 124)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(295, 24)
        Me.ToolStripMenuItem1.Text = "GRABAR RECLAMO CLIENTE"
        '
        'GRABARRECLAMOREPARTIDORToolStripMenuItem
        '
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Name = "GRABARRECLAMOREPARTIDORToolStripMenuItem"
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Size = New System.Drawing.Size(295, 24)
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Text = "GRABAR RECLAMO REPARTIDOR"
        '
        'VERHISTORIALToolStripMenuItem1
        '
        Me.VERHISTORIALToolStripMenuItem1.Name = "VERHISTORIALToolStripMenuItem1"
        Me.VERHISTORIALToolStripMenuItem1.Size = New System.Drawing.Size(295, 24)
        Me.VERHISTORIALToolStripMenuItem1.Text = "VER ESTADOS"
        '
        'REGERARPEDIDOToolStripMenuItem
        '
        Me.REGERARPEDIDOToolStripMenuItem.Name = "REGERARPEDIDOToolStripMenuItem"
        Me.REGERARPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(295, 24)
        Me.REGERARPEDIDOToolStripMenuItem.Text = "REGENERAR PEDIDO"
        '
        'ANULARPEDIDOToolStripMenuItem
        '
        Me.ANULARPEDIDOToolStripMenuItem.Name = "ANULARPEDIDOToolStripMenuItem"
        Me.ANULARPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(295, 24)
        Me.ANULARPEDIDOToolStripMenuItem.Text = "ANULAR PEDIDO"
        '
        'btActualizar
        '
        Me.btActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btActualizar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.Image = Global.Presentacion.My.Resources.Resources.BT_ACTUALIZAR
        Me.btActualizar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btActualizar.Location = New System.Drawing.Point(0, 0)
        Me.btActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(107, 86)
        Me.btActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizar.TabIndex = 12
        Me.btActualizar.Text = "ACTUALIZAR"
        Me.btActualizar.TextColor = System.Drawing.Color.Black
        '
        'btnVentaDirecta
        '
        Me.btnVentaDirecta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVentaDirecta.BackColor = System.Drawing.Color.Transparent
        Me.btnVentaDirecta.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnVentaDirecta.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentaDirecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentaDirecta.Image = Global.Presentacion.My.Resources.Resources.BONOS_DESC
        Me.btnVentaDirecta.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnVentaDirecta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnVentaDirecta.Location = New System.Drawing.Point(1410, 0)
        Me.btnVentaDirecta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVentaDirecta.Name = "btnVentaDirecta"
        Me.btnVentaDirecta.Size = New System.Drawing.Size(176, 86)
        Me.btnVentaDirecta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVentaDirecta.TabIndex = 14
        Me.btnVentaDirecta.Text = "VENTA DIRECTA"
        Me.btnVentaDirecta.TextColor = System.Drawing.Color.Black
        Me.btnVentaDirecta.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CbCategoria
        '
        Me.CbCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption
        CbCategoria_DesignTimeLayout.LayoutString = resources.GetString("CbCategoria_DesignTimeLayout.LayoutString")
        Me.CbCategoria.DesignTimeLayout = CbCategoria_DesignTimeLayout
        Me.CbCategoria.DisabledBackColor = System.Drawing.SystemColors.ButtonFace
        Me.CbCategoria.Location = New System.Drawing.Point(855, 72)
        Me.CbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCategoria.Name = "CbCategoria"
        Me.CbCategoria.SelectedIndex = -1
        Me.CbCategoria.SelectedItem = Nothing
        Me.CbCategoria.Size = New System.Drawing.Size(301, 26)
        Me.CbCategoria.TabIndex = 21
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        '
        '
        '
        Me.lbCategoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoria.Location = New System.Drawing.Point(855, 49)
        Me.lbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(81, 19)
        Me.lbCategoria.TabIndex = 22
        Me.lbCategoria.Text = "Cat. Precio."
        '
        'F02_PedidoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1799, 814)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "F02_PedidoNuevo"
        Me.Text = "F02_Pedido"
        Me.Controls.SetChildIndex(Me.MPnSuperior, 0)
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MSuperTabControlPrincipal, 0)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControlPrincipal.ResumeLayout(False)
        Me.MSuperTabControlPanelBusqueda.ResumeLayout(False)
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GrPan_PeriodoPedido.ResumeLayout(False)
        Me.PaFrecEnDias.ResumeLayout(False)
        Me.GrB_FrecEnDias.ResumeLayout(False)
        CType(Me.Tb_FrecEnDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaFrecMensual.ResumeLayout(False)
        Me.GrB_FrecMensual.ResumeLayout(False)
        CType(Me.Tb_FrecMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaFrecSem.ResumeLayout(False)
        Me.GrB_FrecSemanal.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        CType(Me.JGr_DetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmQuitarDetalle.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.cbPreVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDistribuidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.Tb_CantProd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGr_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.JGr_TipoProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupPanel10.ResumeLayout(False)
        CType(Me.JGr_Reclamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel8.ResumeLayout(False)
        CType(Me.JGr_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.GroupPanel12.ResumeLayout(False)
        Me.GroupPanel11.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        Me.GroupPanel9.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        CType(Me.JGr_UltimosPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupPanel7.ResumeLayout(False)
        CType(Me.JGr_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel6.ResumeLayout(False)
        Me.PanelEx9.ResumeLayout(False)
        Me.ConMenu_Clientes.ResumeLayout(False)
        Me.ConMenu_Buscador.ResumeLayout(False)
        Me.ConMenu_Opciones1.ResumeLayout(False)
        CType(Me.CbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGr_Productos As Janus.Windows.GridEX.GridEX
    Friend WithEvents JGr_TipoProd As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb_CliEstado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Tb_CliTelef As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_CliDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_CliNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_CliCod As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Tb_Estado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Lb_Estado As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_CliCateg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Tb_CliCodZona As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Observaciones As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Tb_Zona As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Hora As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents JGr_DetallePedido As Janus.Windows.GridEX.GridEX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_AddProd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_TerminarAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItemCliente As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents GrPan_PeriodoPedido As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PaFrecEnDias As System.Windows.Forms.Panel
    Friend WithEvents GrB_FrecEnDias As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_FrecEnDias As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_Check2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PaFrecMensual As System.Windows.Forms.Panel
    Friend WithEvents GrB_FrecMensual As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_FrecMensual As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_Check3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PaFrecSem As System.Windows.Forms.Panel
    Friend WithEvents GrB_FrecSemanal As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxX7 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX6 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX5 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX4 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Btn_Check1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx9 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaAl As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaDel As System.Windows.Forms.DateTimePicker
    Friend WithEvents JGr_Buscador As Janus.Windows.GridEX.GridEX
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupPanel8 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents JGr_Clientes As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel9 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb_TotalPedidos3Meses As System.Windows.Forms.TextBox
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_PromCosumo As System.Windows.Forms.TextBox
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents JGr_UltimosPedidos As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel10 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGr_Reclamos As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel11 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb_Obs2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Obs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel12 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb_DireccionDetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ConMenu_Clientes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ACTUALIZARCLIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERCLIENTESPASIVOSYACTIVOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERCLIENTESACTIVOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMenu_Buscador As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VERHISTORIALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMenu_Opciones1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRABARRECLAMOREPARTIDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERHISTORIALToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGERARPEDIDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANULARPEDIDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_GenerarPedidos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCodCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Tb_CantProd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbPreVendedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbDistribuidor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmQuitarDetalle As ContextMenuStrip
    Friend WithEvents QuitarItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbMontoCredito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents swTipoVenta As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents btnVentaDirecta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAplicarDesc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents QrFactura As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents dtpFechaVenc As DateTimePicker
    Friend WithEvents lbFVenc As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_CantProd2 As DevComponents.Editors.DoubleInput
    Friend WithEvents CbCategoria As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbCategoria As DevComponents.DotNetBar.LabelX
End Class
