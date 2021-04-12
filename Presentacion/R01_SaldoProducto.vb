﻿Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports UTILITIES

Public Class R01_SaldoProducto
    Dim _inter As Integer = 0
#Region "Variables Globales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Eventos"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
        _prCargarComboLibreriaDeposito(cbAlmacen)
    End Sub

    Private Sub _prCargarComboLibreriaDeposito(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMovimientoListarSucursales()
        dt.Rows.Add(-1, "Todos")
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 500
            .DropDownList.Columns("aabdes").Caption = "SUCURSAL"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With

        mCombo.Value = -1
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
        _modulo.Select()
        '_tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion dsds
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "S A L D O   D E   P R O D U C T O".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub

    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        Dim saldoMayorCero As Boolean = chkSaldoMayorCero.Checked
        Dim condicionMayorCero As String = IIf(chkSaldoMayorCero.Checked, " AND iacant > 0 ", "")
        If swTipo.Value Then
            Dim objrep As New R_StockActual()
            If (cbAlmacen.Value >= 0) Then
                _dt = L_VistaStockActual("cenum=0 and iaalm=" + Str(cbAlmacen.Value) + " " + condicionMayorCero)
                objrep.SetDataSource(_dt)
                MCrReporte.ReportSource = objrep
            Else
                _dt = L_VistaStockActual("cenum=0" + " " + condicionMayorCero)
                objrep.SetDataSource(_dt)
                MCrReporte.ReportSource = objrep
            End If


        Else
            Dim objrep As New R_StockActualSinAgrupacion()

            If (cbAlmacen.Value >= 0) Then
                _dt = L_VistaStockActual("cenum=0 and iaalm=" + Str(cbAlmacen.Value) + " " + condicionMayorCero)
                objrep.SetDataSource(_dt)
                MCrReporte.ReportSource = objrep
            Else
                _dt = L_VistaStockActual("cenum=0" + " " + condicionMayorCero)
                objrep.SetDataSource(_dt)
                MCrReporte.ReportSource = objrep
            End If

        End If

    End Sub

#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _inter = _inter + 1
        If _inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub
End Class