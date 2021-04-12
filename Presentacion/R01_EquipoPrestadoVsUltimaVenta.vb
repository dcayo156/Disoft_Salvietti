﻿Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_EquipoPrestadoVsUltimaVenta
    Dim _Inter As Integer = 0
#Region "Atributos generales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Variables Globales"

    Dim InDuracion As Byte = 5

#End Region

#Region "Eventos"

    Private Sub PR_KardexPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub


    Private Sub TbCodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TbCodigo.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prCargarAyudaCliente()
        End If
    End Sub

    Private Sub BtBuscarCliente_Click_1(sender As Object, e As EventArgs) Handles BtBuscarCliente.Click
        P_prCargarAyudaCliente()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
        Me._modulo.Select()
        ' Me._tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "C L I E N T E   C O N   E Q U I P O   V S   U L T I M A   V E N T A".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        TbCodigo.ReadOnly = True
        TbDescripcion.ReadOnly = True

        DtiDesde.Value = Now.Date
    End Sub

    Private Sub P_prCargarReporte()
        If (P_fnValidar()) Then
            Dim dt As New DataTable

            dt = L_VistaSaldoPrestamoEquiposUV(DtiDesde.Value.ToString("yyyy/MM/dd"), TbCodigo.Text)

            If (dt.Rows.Count > 0) Then
                Dim objrep As New R_SaldoPrestamoEquiposUV

                objrep.SetDataSource(dt)

                objrep.SetParameterValue("Fecha", DtiDesde.Value.ToString("dd/MM/yyyy"))
                objrep.SetParameterValue("Zona", TbDescripcion.Text)

                MCrReporte.ReportSource = objrep
                MCrReporte.Show()
                MCrReporte.BringToFront()
            Else
                ToastNotification.Show(Me, "no hay datos para los parametros seleccionados.".ToUpper,
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
                MCrReporte.ReportSource = Nothing
            End If
        End If
    End Sub

    Private Sub P_prCargarAyudaCliente()
        Dim frmAyuda As Modelo.ModeloAyuda
        Dim dt As DataTable = L_GetZonasCPZ().Tables(0)
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("lanumi", True, "Codigo", 80))
        listEstCeldas.Add(New Modelo.MCelda("city", True, "Dpto", 150))
        listEstCeldas.Add(New Modelo.MCelda("prov", True, "Provincia", 150))
        listEstCeldas.Add(New Modelo.MCelda("zona", True, "Zona", 200))

        frmAyuda = New Modelo.ModeloAyuda(750, 400, dt, "Seleccione una zona".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            TbCodigo.Text = frmAyuda.filaSelect.Cells("lanumi").Value
            TbDescripcion.Text = "dpto: ".ToUpper + frmAyuda.filaSelect.Cells("city").Value.ToString + vbCrLf _
                                  + "provincia: ".ToUpper + frmAyuda.filaSelect.Cells("prov").Value.ToString + vbCrLf _
                                  + "zona: ".ToUpper + frmAyuda.filaSelect.Cells("zona").Value.ToString
        End If
    End Sub

    Private Function P_fnValidar() As Boolean
        Dim sms As String = ""

        If (TbCodigo.Text.Trim = String.Empty) Then
            sms = "Para generar el reporte debe elegir una zona.".ToUpper
        End If

        If (DtiDesde.Value > Now.Date) Then
            If (sms = String.Empty) Then
                sms = "La fecha tiene que ser menor o igual a la fecha actual.".ToUpper
            Else
                sms = sms + vbCrLf + "La fecha tiene que ser menor o igual a la fecha actual.".ToUpper
            End If
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   sms.ToUpper,
                                   My.Resources.WARNING,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return (sms = String.Empty)
    End Function

#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub
End Class