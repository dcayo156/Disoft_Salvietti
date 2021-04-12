﻿Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid

Public Class F01_ReporteCompras
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Private Sub P_prInicio()
        'Abrir conexion dsds
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.WindowState = FormWindowState.Maximized
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        P_prArmarCombos()
        P_prArmarComboProducto()
    End Sub
    Private Sub P_prArmarComboProducto()
        Dim DtP As DataTable
        DtP = L_fnObtenerProductos()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProducto, DtP, 60, 200, "COD", "PRODUCTOS")
        cbProducto.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub P_prArmarCombos()
        P_prArmarComboProveedor()
        P_prArmarComboCategoria()
        P_prCargarComboLibreria(cbMarca, 102)
        P_prCargarComboLibreria(cbAtributo, 103)
        P_prArmarComboDescripcion(cbDescripcion)


    End Sub
    Private Sub P_prArmarComboProveedor()
        Dim DtP As DataTable
        DtP = L_fnObtenerProveedor()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProveedor, DtP, 60, 200, "COD", "PROVEEDOR")
        cbProveedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub P_prArmarComboCategoria()
        Dim Dt As DataTable
        Dt = L_fnObtenerCategoria()
        Dt.Rows.Add(0, "TODOS")
        g_prArmarCombo(cbCategoria, Dt, 60, 200, "Código", "Categoría")
        cbCategoria.SelectedIndex = Convert.ToInt32(Dt.Rows.Count - 1)

    End Sub

    Private Sub P_prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaProductoGeneral(cod1)
        dt.Rows.Add(0, "TODOS")
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cenum").Width = 70
            .DropDownList.Columns("cenum").Caption = "COD"
            .DropDownList.Columns.Add("cedesc").Width = 200
            .DropDownList.Columns("cedesc").Caption = "DESCRIPCION"
            .ValueMember = "cenum"
            .DisplayMember = "cedesc"
            .DataSource = dt
            .Refresh()
        End With
        mCombo.SelectedIndex = Convert.ToInt32(dt.Rows.Count - 1)
    End Sub
    Private Sub P_prArmarComboDescripcion(cbDescripcion As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim Dt As DataTable
        Dt = L_fnObtenerDescripcion()
        Dt.Rows.Add("TODOS")
        With cbDescripcion
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cadesc2").Width = 200
            .DropDownList.Columns("cadesc2").Caption = "DESCRIPCION"
            .ValueMember = "cadesc2"
            .DisplayMember = "cadesc2"
            .DataSource = Dt
            .Refresh()
        End With
        cbDescripcion.SelectedIndex = Convert.ToInt32(Dt.Rows.Count - 1)
    End Sub

    Private Sub F01_ReporteVentaFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte de Compras"
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        P_prInicio()

    End Sub
    Public Sub Filtrar(ByRef _dt As DataTable)
        Dim table As DataTable = _dt.Copy


        If (cbProducto.Value <> 0) Then
            table = _dt.Copy
            table.Rows.Clear()
            For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
                If (_dt.Rows(i).Item("Codigo") = cbProducto.Value) Then
                    table.ImportRow(_dt.Rows(i))

                End If

            Next
            _dt = table.Copy
        End If
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim dt As DataTable = L_fnReporteComprasFacturadas(cbProveedor.Value, cbCategoria.Value, cbMarca.Value, cbAtributo.Value, cbDescripcion.Value, tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        Filtrar(dt)
        If (dt.Rows.Count > 0) Then


            grDatos.DataSource = dt
            grDatos.RetrieveStructure()
            grDatos.AlternatingColors = True

            'Mes Fecha	Proveedor	Documento	Detalle	Codigo	Producto	Marca	Atributo	Familia	Descripcion	Cantidad	Precio	Importe	PrecioCosto	Valorado	Usuario
            With grDatos.RootTable.Columns("Atributo")
                .Caption = "Atributo"
                .FormatString = ""
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Descripcion")
                .Caption = "Descripcion"
                .FormatString = ""
                .Visible = True
            End With
            With grDatos.RootTable.Columns("detalle")
                .Caption = "Detalle"
                .FormatString = ""

                .Visible = False
            End With

            'Mes Fecha	Documento		Producto	Marca		Familia		Cantidad	Precio	Importe	PrecioCosto	Valorado	Usuario
            With grDatos.RootTable.Columns("Codigo")
                .Caption = "Codigo"
                .FormatString = ""
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Proveedor")
                .Caption = "Proveedor"
                .FormatString = ""
                .Visible = True
            End With
            'Mes Fecha	Documento		Producto		Cantidad	Precio	Importe	PrecioCosto	Valorado	Usuario


            With grDatos.RootTable.Columns("Marca")
                .Caption = "Marca"
                .FormatString = ""
                .Visible = True
            End With


            With grDatos.RootTable.Columns("Familia")
                .Caption = "Familia"
                .FormatString = ""
                .Visible = True
            End With



            With grDatos.RootTable.Columns("Mes")
                .Caption = "Mes"
                .FormatString = ""
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Fecha")
                .Caption = "Fecha"
                .FormatString = "dd/MM/yyyy"
                .Visible = True
            End With
            With grDatos.RootTable.Columns("Documento")
                .Caption = "Documento"
                .FormatString = ""
                .Visible = True
            End With
            '	Cantidad	Precio	Importe	PrecioCosto	Valorado	Usuario



            With grDatos.RootTable.Columns("Producto")
                .Width = 250
                .Caption = "Producto"
                .Visible = True
            End With




            With grDatos.RootTable.Columns("Cantidad")
                .Width = 100
                .FormatString = "0.00"
                .Visible = True

            End With
            With grDatos.RootTable.Columns("Precio")
                .Width = 100
                .FormatString = "0.00"
                .Visible = True

            End With
            With grDatos.RootTable.Columns("Importe")
                .Width = 100
                .FormatString = "0.00"
                .Visible = True

            End With
            With grDatos.RootTable.Columns("PrecioCosto")
                .Width = 100
                .FormatString = "0.00"
                .Visible = True

            End With
            With grDatos.RootTable.Columns("Valorado")
                .Width = 100
                .FormatString = "0.00"
                .Visible = True

            End With

            With grDatos.RootTable.Columns("Usuario")
                .Width = 100
                .FormatString = ""
                .Visible = True

            End With




            With grDatos
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .GroupByBoxVisible = False
                'diseño de la grilla
                .VisualStyle = VisualStyle.Office2007
            End With
        Else
            If (Not IsNothing(grDatos) And Not IsNothing(grDatos.DataSource)) Then

                CType(grDatos.DataSource, DataTable).Rows.Clear()

            End If

            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                    My.Resources.INFORMATION, 2000,
                                    eToastGlowColor.Blue,
                                    eToastPosition.TopCenter)
        End If

    End Sub
    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte Productos\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")

                End If
            End If
        End If
    End Sub
    Private Sub btExcel_Click(sender As Object, e As EventArgs) Handles btExcel.Click
        If (Not IsNothing(grDatos) And Not IsNothing(grDatos.DataSource)) Then

            _prCrearCarpetaReportes()
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            If (P_ExportarExcel(RutaGlobal + "\Reporte\Reporte Productos")) Then
                ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE COMPRAS EXITOSA..!!!",
                                           img, 2000,
                                           eToastGlowColor.Green,
                                           eToastPosition.BottomCenter)
            Else
                ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE COMPRAS..!!!",
                                           My.Resources.WARNING, 2000,
                                           eToastGlowColor.Red,
                                           eToastPosition.BottomLeft)
            End If
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA EXPORTAR..!!!",
                                   My.Resources.INFORMATION, 2000,
                                   eToastGlowColor.Blue,
                                   eToastPosition.TopCenter)

        End If
    End Sub
    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = grDatos.GetRows.Length
                Dim _columna As Integer = grDatos.RootTable.Columns.Count
                Dim _archivo As String = _ubicacion & "\ListaDeCompras_" & Now.Date.Day &
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In grDatos.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In grDatos.GetRows
                    For Each _col As GridEXColumn In grDatos.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function

End Class