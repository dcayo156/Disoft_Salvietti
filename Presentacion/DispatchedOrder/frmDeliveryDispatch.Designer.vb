﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeliveryDispatch
    Inherits System.Windows.Forms.Form

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
        Dim cbChoferes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeliveryDispatch))
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelPedido = New System.Windows.Forms.Panel()
        Me.dgjPedido = New Janus.Windows.GridEX.GridEX()
        Me.PanelProducto = New System.Windows.Forms.Panel()
        Me.dgjProducto = New Janus.Windows.GridEX.GridEX()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btReporteDespachoCliente = New DevComponents.DotNetBar.ButtonX()
        Me.btReporteDespachoLinea = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbChoferes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBase.SuspendLayout()
        Me.PanelPedido.SuspendLayout()
        CType(Me.dgjPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProducto.SuspendLayout()
        CType(Me.dgjProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBase
        '
        Me.PanelBase.Controls.Add(Me.PanelPedido)
        Me.PanelBase.Controls.Add(Me.PanelProducto)
        Me.PanelBase.Controls.Add(Me.PanelSuperior)
        Me.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBase.Location = New System.Drawing.Point(0, 0)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New System.Drawing.Size(1186, 450)
        Me.PanelBase.TabIndex = 0
        '
        'PanelPedido
        '
        Me.PanelPedido.Controls.Add(Me.dgjPedido)
        Me.PanelPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPedido.Location = New System.Drawing.Point(0, 60)
        Me.PanelPedido.Name = "PanelPedido"
        Me.PanelPedido.Size = New System.Drawing.Size(1186, 275)
        Me.PanelPedido.TabIndex = 1
        '
        'dgjPedido
        '
        Me.dgjPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjPedido.Location = New System.Drawing.Point(0, 0)
        Me.dgjPedido.Name = "dgjPedido"
        Me.dgjPedido.Size = New System.Drawing.Size(1186, 275)
        Me.dgjPedido.TabIndex = 2
        '
        'PanelProducto
        '
        Me.PanelProducto.Controls.Add(Me.dgjProducto)
        Me.PanelProducto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProducto.Location = New System.Drawing.Point(0, 335)
        Me.PanelProducto.Name = "PanelProducto"
        Me.PanelProducto.Size = New System.Drawing.Size(1186, 115)
        Me.PanelProducto.TabIndex = 1
        '
        'dgjProducto
        '
        Me.dgjProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgjProducto.Name = "dgjProducto"
        Me.dgjProducto.Size = New System.Drawing.Size(1186, 115)
        Me.dgjProducto.TabIndex = 3
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.LabelX1)
        Me.PanelSuperior.Controls.Add(Me.Tb_Fecha)
        Me.PanelSuperior.Controls.Add(Me.btReporteDespachoCliente)
        Me.PanelSuperior.Controls.Add(Me.btReporteDespachoLinea)
        Me.PanelSuperior.Controls.Add(Me.LabelX2)
        Me.PanelSuperior.Controls.Add(Me.cbChoferes)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1186, 60)
        Me.PanelSuperior.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(290, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(55, 23)
        Me.LabelX1.TabIndex = 233
        Me.LabelX1.Text = "Fecha:"
        '
        'Tb_Fecha
        '
        '
        '
        '
        Me.Tb_Fecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_Fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Tb_Fecha.ButtonDropDown.Visible = True
        Me.Tb_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Fecha.IsPopupCalendarOpen = False
        Me.Tb_Fecha.Location = New System.Drawing.Point(351, 12)
        '
        '
        '
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Tb_Fecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.Tb_Fecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.TodayButtonVisible = True
        Me.Tb_Fecha.Name = "Tb_Fecha"
        Me.Tb_Fecha.Size = New System.Drawing.Size(120, 22)
        Me.Tb_Fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Tb_Fecha.TabIndex = 232
        '
        'btReporteDespachoCliente
        '
        Me.btReporteDespachoCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReporteDespachoCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReporteDespachoCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.btReporteDespachoCliente.Image = Global.Presentacion.My.Resources.Resources.PEDI_ULTIMOS_PEDIDOS
        Me.btReporteDespachoCliente.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btReporteDespachoCliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btReporteDespachoCliente.Location = New System.Drawing.Point(1036, 0)
        Me.btReporteDespachoCliente.Name = "btReporteDespachoCliente"
        Me.btReporteDespachoCliente.Size = New System.Drawing.Size(75, 60)
        Me.btReporteDespachoCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReporteDespachoCliente.TabIndex = 6
        Me.btReporteDespachoCliente.Text = "Despacho por cliente"
        '
        'btReporteDespachoLinea
        '
        Me.btReporteDespachoLinea.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReporteDespachoLinea.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReporteDespachoLinea.Dock = System.Windows.Forms.DockStyle.Right
        Me.btReporteDespachoLinea.Image = Global.Presentacion.My.Resources.Resources.PEDI_ENTRAGA_PEDIDOS
        Me.btReporteDespachoLinea.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btReporteDespachoLinea.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btReporteDespachoLinea.Location = New System.Drawing.Point(1111, 0)
        Me.btReporteDespachoLinea.Name = "btReporteDespachoLinea"
        Me.btReporteDespachoLinea.Size = New System.Drawing.Size(75, 60)
        Me.btReporteDespachoLinea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReporteDespachoLinea.TabIndex = 5
        Me.btReporteDespachoLinea.Text = "Despacho por producto"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(55, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Choferes:"
        '
        'cbChoferes
        '
        cbChoferes_DesignTimeLayout.LayoutString = resources.GetString("cbChoferes_DesignTimeLayout.LayoutString")
        Me.cbChoferes.DesignTimeLayout = cbChoferes_DesignTimeLayout
        Me.cbChoferes.Location = New System.Drawing.Point(73, 14)
        Me.cbChoferes.Name = "cbChoferes"
        Me.cbChoferes.SelectedIndex = -1
        Me.cbChoferes.SelectedItem = Nothing
        Me.cbChoferes.Size = New System.Drawing.Size(200, 20)
        Me.cbChoferes.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmDeliveryDispatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 450)
        Me.Controls.Add(Me.PanelBase)
        Me.Name = "frmDeliveryDispatch"
        Me.Opacity = 0.05R
        Me.Text = "frmDeliveryDispatch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PanelBase.ResumeLayout(False)
        Me.PanelPedido.ResumeLayout(False)
        CType(Me.dgjPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProducto.ResumeLayout(False)
        CType(Me.dgjProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelPedido As Panel
    Friend WithEvents PanelProducto As Panel
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbChoferes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents btReporteDespachoLinea As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgjPedido As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgjProducto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btReporteDespachoCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Timer1 As Timer
End Class
