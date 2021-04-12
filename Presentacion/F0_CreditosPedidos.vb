﻿Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports System.Threading
Imports System.Drawing.Text
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports System.Reflection
Imports System.Runtime.InteropServices
Public Class F0_CreditosPedidos
    Dim _Inter As Integer = 0
#Region "Variables Globales"
    Dim precio As DataTable
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim Bin As New MemoryStream
#End Region
#Region "METODOS PRIVADOS"

    Private Sub _IniciarTodo()

        'Dim img As New Bitmap(My.Resources.delete, 28, 28)
        'img.Save(Bin, Imaging.ImageFormat.Png)

        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        _prCargarComboLibreria(cbbanco, 6, 1)

        'Me.WindowState = FormWindowState.Maximized
        _prAsignarPermisos()
        Me.Text = "NOTAS DE COBRANZAS"
        'Dim blah As New Bitmap(New Bitmap(My.Resources.cobro), 20, 20)
        'Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        'Me.Icon = ico


        _prInhabiliitar()
        _prCargarCobranza()

    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneral()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 70
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 200
            .DropDownList.Columns("ycdes3").Caption = "DESCRIPCION"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Function _fnBytesArchivo(img As Bitmap, ancho As Integer, alto As Integer) As Object
        Bin = New MemoryStream()
        Dim img2 As New Bitmap(img, ancho, alto)
        img2.Save(Bin, System.Drawing.Imaging.ImageFormat.Png)
        Return Bin.ToArray()
    End Function
    Private Sub _prInhabiliitar()
        tbnrodoc.ReadOnly = True
        tbfecha.IsInputReadOnly = True
        tbObservacion.ReadOnly = True
        tbcobrador.ReadOnly = True
        ''''''''''
        MBtModificar.Enabled = True
        MBtGrabar.Enabled = False

        MBtNuevo.Enabled = True
        MBtEliminar.Enabled = True

        MPanelToolBarNavegacion.Enabled = True
        'grdetalle.RootTable.Columns("img").Visible = False
        If (GpanelDeudas.Visible = True) Then
            _DesHabilitarProductos()
        End If
        'grfactura.RootTable.Columns("img").Visible = False
        grcobranza.Enabled = True
    End Sub
    Private Sub _prhabilitar()
        grcobranza.Enabled = False
        tbnrodoc.ReadOnly = False
        tbfecha.IsInputReadOnly = False
        tbObservacion.ReadOnly = False
        tbcobrador.ReadOnly = False

        ''  tbCliente.ReadOnly = False  por que solo podra seleccionar Cliente
        ''  tbVendedor.ReadOnly = False
        grfactura.RootTable.Columns("img").Visible = True
        MBtGrabar.Enabled = True
    End Sub
    Public Sub _prCargarCobranza()
        Dim dt As DataTable = L_fnCobranzasGeneral()
        grcobranza.DataSource = dt
        grcobranza.RetrieveStructure()
        grcobranza.AlternatingColors = True
        '     a.tenumi ,a.tefdoc ,a.tety4vend,vendedor .yddesc as vendedor,
        'a.teobs ,a.tefact ,a.tehact ,a.teuact  ,Sum(detalle .tdmonto) as total 
        With grcobranza.RootTable.Columns("tenumi")
            .Width = 120
            .Visible = True
            .TextAlignment = TextAlignment.Far
            .Caption = "Cod Cobranzas"
        End With
        With grcobranza.RootTable.Columns("tefdoc")
            .Width = 120
            .Visible = True
            .Caption = "FECHA"
            .FormatString = "dd/MM/yyyy"
        End With
        With grcobranza.RootTable.Columns("tety4vend")

            .Width = 90
            .Visible = False
        End With
        With grcobranza.RootTable.Columns("vendedor")
            .Caption = "Cobrador"
            .Width = 300
            .Visible = True
        End With
        With grcobranza.RootTable.Columns("teobs")
            .Caption = "Observacion"
            .Width = 250
            .Visible = True
        End With
        With grcobranza.RootTable.Columns("total")
            .Caption = "Total"
            .Width = 100
            .TextAlignment = TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
        End With
        With grcobranza.RootTable.Columns("tefact")
            .Width = 100
            .Visible = False
        End With
        With grcobranza.RootTable.Columns("tehact")
            .Width = 100
            .Visible = False
        End With
        With grcobranza.RootTable.Columns("teuact")
            .Width = 100
            .Visible = False
        End With


        With grcobranza
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007

        End With
    End Sub

    Public Sub _prFiltrar()
        'cargo el buscador
        Dim _Mpos As Integer
        _prCargarCobranza()
        If grcobranza.RowCount > 0 Then
            _Mpos = 0
            grcobranza.Row = _Mpos
        Else
            _Limpiar()
            MLbPaginacion.Text = "0/0"
        End If
    End Sub

    Private Sub _Limpiar()
        tbnrodoc.Clear()
        tbfecha.Value = Now.Date
        tbObservacion.Clear()
        tbcodVendedor.Clear()
        tbcobrador.Clear()

        _prDetalleCobranzas(-1)
        _prAddDetalle()
        tbcobrador.Focus()

    End Sub
    Sub _prAddDetalle()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        '       numidetalle, NroDoc, factura, numiCredito, numiCobranza, A.tctv1numi
        ',a.tcty4clie ,cliente,detalle.tdfechaPago, PagoAc, NumeroRecibo, DescBanco, banco, detalle.tdnrocheque 
        cbbanco.SelectedIndex = 0
        CType(grfactura.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, "", "", 0, 0, 0, 0, 0,
                                                     Now.Date, 0, 0, "", cbbanco.Text, 0, "", Bin.ToArray, 0)
    End Sub
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(grfactura.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("numidetalle=MAX(numidetalle)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("numidetalle")
        End If
        Return 1
    End Function
    Private Sub _prDetalleCobranzas(_numi As Integer)

        Dim dt As New DataTable
        dt = L_fnCobranzasDetalle(_numi)
        _prCargarIconDelete(dt)
        grfactura.DataSource = dt
        grfactura.RetrieveStructure()
        grfactura.AlternatingColors = True
        '       numidetalle, NroDoc, factura, numiCredito, numiCobranza, A.tctv1numi
        ',a.tcty4clie ,cliente,detalle.tdfechaPago, PagoAc, NumeroRecibo, DescBanco, banco, detalle.tdnrocheque,
        'img,estado,pendiente
        With grfactura.RootTable.Columns("numidetalle")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("tdfechaPago")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("numiCredito")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("numiCobranza")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("tctv1numi")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("tcty4clie")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("pendiente")
            .Width = 100
            .FormatString = "0.00"
            .Visible = True
            .TextAlignment = TextAlignment.Far
            .Caption = "Pendiente"
        End With

        With grfactura.RootTable.Columns("NroDoc")
            .Width = 90
            .Visible = True
            .Caption = "Nro Doc"
            .TextAlignment = TextAlignment.Far
        End With
        With grfactura.RootTable.Columns("factura")
            .Caption = "Factura"
            .Width = 100
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grfactura.RootTable.Columns("cliente")
            .Caption = "Cliente"
            .Width = 350
            .Visible = True
        End With
        With grfactura.RootTable.Columns("PagoAc")
            .Caption = "Total Cobrado"
            .Width = 180
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With grfactura.RootTable.Columns("NumeroRecibo")
            .Caption = "Nro Recibo"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grfactura.RootTable.Columns("DescBanco")
            .Caption = "Banco"
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbbanco.DropDownList
            .Width = 160
            .Visible = True
        End With
        With grfactura.RootTable.Columns("banco")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("estado")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("tdnrocheque")
            .Caption = "Nro Cheque"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        If (_fnAccesible()) Then
            With grfactura.RootTable.Columns("img")
                .Width = 80
                .Caption = "Eliminar"
                .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
                .Visible = True
            End With
        Else
            With grfactura.RootTable.Columns("img")
                .Width = 80
                .Caption = "ELiminar"
                .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
                .Visible = False
            End With
        End If


        With grfactura
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .AlternatingColors = True

            .RowHeaders = InheritableBoolean.True
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With


    End Sub

    Public Sub _prMostrarRegistro(_N As Integer)
        '' grVentas.Row = _N
        '     a.tenumi ,a.tefdoc ,a.tety4vend,vendedor .yddesc as vendedor,
        'a.teobs ,a.tefact ,a.tehact ,a.teuact  ,Sum(detalle .tdmonto) as total 

        With grcobranza
            tbnrodoc.Text = .GetValue("tenumi")
            tbfecha.Value = .GetValue("tefdoc")
            tbObservacion.Text = .GetValue("teobs")
            tbcobrador.Text = .GetValue("vendedor")
            tbcodVendedor.Text = .GetValue("tety4vend")
            MLbFecha.Text = CType(.GetValue("tefact"), Date).ToString("dd/MM/yyyy")
            MLbHora.Text = .GetValue("tehact").ToString
            MLbUsuario.Text = .GetValue("teuact").ToString

        End With

        _prDetalleCobranzas(tbnrodoc.Text)

        MLbPaginacion.Text = Str(grcobranza.Row + 1) + "/" + grcobranza.RowCount.ToString

    End Sub
    Private Sub _prAsignarPermisos()

        'Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        'Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        'Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        'Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        'Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        'If add = False Then
        '    MBtNuevo.Visible = False
        'End If
        'If modif = False Then
        '    MBtModificar.Visible = False
        'End If
        'If del = False Then
        '    MBtEliminar.Visible = False
        'End If
    End Sub

    Public Sub _prEliminarExistente(ByRef dt As DataTable)
        Dim aux As DataTable = dt.Copy
        aux.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim numi As Integer = dt.Rows(i).Item("tcnumi")
            If (Not _fnExistePago(numi)) Then
                aux.ImportRow(dt.Rows(i))

            End If
        Next
        dt = aux
    End Sub
    Private Sub _prCargarTablaCreditos()
        'a.tcnumi,sucursal,NroDoc,as factura,a.tctv1numi ,a.tcty4clie ,cliente,a.tcty4vend,vendedor,a.tcfdoc ,totalfactura, pendiente, PagoAc, NumeroRecibo
        Dim dt As New DataTable
        dt = L_fnCobranzasObtenerLasVentasACredito()
        _prEliminarExistente(dt)

        grPendiente.DataSource = dt
        grPendiente.RetrieveStructure()
        grPendiente.AlternatingColors = True
        With grPendiente.RootTable.Columns("tcnumi")
            .Width = 100
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("sucursal")
            .Width = 100
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("tctv1numi")
            .Width = 100
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("tcty4clie")
            .Width = 100
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("tcty4vend")
            .Width = 100
            .Visible = False
        End With


        With grPendiente.RootTable.Columns("NroDoc")
            .Caption = "Nro Doc"
            .Width = 90
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("factura")
            .Caption = "Nro Factura"
            .Width = 95
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("cliente")
            .Caption = "Cliente"
            .Width = 350
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("vendedor")
            .Caption = "Vendedor"
            .Width = 230
            .Visible = True
        End With

        With grPendiente.RootTable.Columns("tcfdoc")
            .Caption = "Fecha"
            .Width = 110
            .FormatString = "dd/MM/yyyy"
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("totalfactura")
            .Caption = "Total Factura"
            .Width = 120
            .MaxLength = 100
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("pendiente")
            .Caption = "Pendiente Cobro"
            .Width = 140
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .MaxLength = 10
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("PagoAc")
            .Caption = "Total Cobrado"
            .Width = 120
            .FormatString = "0.00"
            .MaxLength = 10
            .TextAlignment = TextAlignment.Far
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("NumeroRecibo")
            .Caption = "Nro Recibo"
            .Width = 150
            .MaxLength = 20
            .Visible = False
        End With
        With grPendiente
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges

        End With


    End Sub


    Private Sub _prCargarTablaPagos(_numi As Integer)

        Dim dt As New DataTable
        dt = L_fnObtenerLosPagos(_numi)
        '_prCargarIconDelete(dt)
        grpagos.DataSource = dt
        grpagos.RetrieveStructure()
        grpagos.AlternatingColors = True
        'A.tdnumi, A.tdtv12numi, A.tdnrodoc, A.tdfechaPago, A.tdmonto, A.tdnrorecibo, A.tdfact, A.tdhact, A.tduact

        '       detalle.tdnumi as numidetalle, cliente.ccdesc  As cliente, Concat(Month(a.oafdoc),'-',Year(a.oafdoc )) NroDoc,'0' as factura,
        '   a.oanumi  As numiCredito, cobranza.tenumi as numiCobranza
        ',a.oanumi as tctv1numi ,a.oaccli  as tcty4clie ,detalle.tdfechaPago,
        '(credito.ogcred  -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.oanumi  ))
        ' as pendiente,detalle .tdmonto  as PagoAc,detalle .tdnrorecibo  as NumeroRecibo,
        '   banco.cedesc  as DescBanco, detalle.tdty3banco As banco, detalle.tdnrocheque, Cast('' as image)as img ,1 as estado 
        With grpagos.RootTable.Columns("tdnumi")
            .Width = 100
            .Visible = False
        End With
        With grpagos.RootTable.Columns("tdtv12numi")
            .Width = 100
            .Visible = False
        End With
        With grpagos.RootTable.Columns("tdnrodoc")
            .Caption = "Nro Doc"
            .Width = 90
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grpagos.RootTable.Columns("tdfechaPago")
            .Caption = "Fecha Pago"
            .Width = 120
            .Visible = True
        End With
        With grpagos.RootTable.Columns("tdmonto")
            .Caption = "Cobros"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With grpagos.RootTable.Columns("tdnrorecibo")
            .Caption = "Nro Recibo"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grpagos.RootTable.Columns("tdfact")
            .Width = 100
            .Visible = False
        End With
        With grpagos.RootTable.Columns("tdhact")
            .Width = 100
            .Visible = False
        End With
        With grpagos.RootTable.Columns("tduact")
            .Width = 100
            .Visible = False
        End With


        With grpagos
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007


            .VisualStyle = VisualStyle.Office2007


            .RowHeaders = InheritableBoolean.True
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With


    End Sub
    Public Sub _prCargarIconDelete(ByRef dt As DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            dt.Rows(i).Item("img") = _fnBytesArchivo(My.Resources.delete, 28, 28)
        Next
    End Sub
#End Region




    Private Sub grfactura_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grfactura.EditingCell

        'Habilitar solo las columnas de Precio, %, Monto y ObservaciónDescBanco()tdnrocheque
        If (Not _fnAccesible()) Then
            e.Cancel = True
            Return
        End If
        If (e.Column.Index = grfactura.RootTable.Columns("PagoAc").Index Or e.Column.Index = grfactura.RootTable.Columns("NumeroRecibo").Index Or e.Column.Index = grfactura.RootTable.Columns("DescBanco").Index Or e.Column.Index = grfactura.RootTable.Columns("tdnrocheque").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub grfactura_SelectionChanged(sender As Object, e As EventArgs) Handles grfactura.SelectionChanged
        'a.tcnumi,sucursal,NroDoc,as factura,a.tctv1numi ,a.tcty4clie ,cliente,a.tcty4vend,vendedor,a.tcfdoc ,totalfactura, pendiente, PagoAc, NumeroRecibo
        If (grfactura.Row >= 0) Then
            'tbnrodoc.Text = grfactura.GetValue("NroDoc")
            'tbfecha.Value = grfactura.GetValue("tcfdoc")
            'tbcobrador.Text = grfactura.GetValue("cliente")

            _prCargarTablaPagos(grfactura.GetValue("numiCredito"))
        End If
    End Sub

    Private Sub grfactura_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grfactura.CellValueChanged
        If (e.Column.Index = grfactura.RootTable.Columns("PagoAc").Index) Then
            If (Not IsNumeric(grfactura.GetValue("PagoAc")) Or grfactura.GetValue("PagoAc").ToString = String.Empty) Then
                'grfactura.SetValue("PagoAc", 0)
                'grdetalle.SetValue("tbptot", grdetalle.GetValue("cbpcost"))
            Else
                If (grfactura.GetValue("PagoAc") > 0) Then
                    Dim deuda As Double = grfactura.GetValue("pendiente")
                    If (grfactura.GetValue("PagoAc") > deuda) Then
                        grfactura.SetValue("PagoAc", deuda)
                    End If
                Else
                    grfactura.SetValue("PagoAc", 0)

                End If
            End If
        End If



    End Sub

    Private Sub grfactura_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grfactura.CellEdited
        If (e.Column.Index = grfactura.RootTable.Columns("PagoAc").Index) Then
            If (Not IsNumeric(grfactura.GetValue("PagoAc")) Or grfactura.GetValue("PagoAc").ToString = String.Empty) Then
                grfactura.SetValue("PagoAc", 0)
                'grdetalle.SetValue("tbptot", grdetalle.GetValue("cbpcost"))
            End If

        End If
        Dim pos As Integer = -1
        _fnObtenerFilaDetalle(pos, grfactura.GetValue("numidetalle"))
        If (pos >= 0) Then
            Dim estado = CType(grfactura.DataSource, DataTable).Rows(pos).Item("estado")
            If (estado = 1) Then
                CType(grfactura.DataSource, DataTable).Rows(pos).Item("estado") = 2
            End If

        End If


    End Sub
    Sub _prInterpretarDatos(ByRef dt As DataTable)
        '        A.tdnumi, A.tdtv12numi, A.tdnrodoc, A.tdfechaPago, A.tdmonto
        ',a.tdnrorecibo ,a.tdfact ,a.tdhact ,a.tduact 

        'a.tcnumi,sucursal,NroDoc,as factura,a.tctv1numi ,a.tcty4clie ,cliente,a.tcty4vend,vendedor,a.tcfdoc ,totalfactura, pendiente, PagoAc, NumeroRecibo
        Dim dtcobro As DataTable = CType(grfactura.DataSource, DataTable)
        For i As Integer = 0 To dtcobro.Rows.Count - 1 Step 1
            Dim pago As Double = dtcobro.Rows(i).Item("PagoAc")
            If (pago > 0) Then
                dt.Rows.Add(0, dtcobro.Rows(i).Item("tcnumi"), dtcobro.Rows(i).Item("NroDoc"),
                            dtcobro.Rows(i).Item("tcfdoc"), pago, dtcobro.Rows(i).Item("NumeroRecibo"))
            End If
        Next
    End Sub
    Sub _prGrabarCobro()
        Dim dtCobro As DataTable = L_fnObtenerLosPagos(-1)
        _prInterpretarDatos(dtCobro)
        If (dtCobro.Rows.Count > 0) Then

            Dim res As Boolean = L_fnGrabarPagos("", dtCobro)


            If res Then

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "EL PAGO HA SIDO GRABADO CON EXITO".ToUpper,
                                          img, 3500,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
                Dim pos As Integer = grfactura.Row
                If (pos <= grfactura.RowCount - 1) Then
                    grfactura.Row = pos
                End If
                _prCargarTablaCreditos()



                grfactura.Focus()


            Else
                Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                ToastNotification.Show(Me, "EL COBRO NO PUDO GRABARSE CON EXITO".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If


        Else
            Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
            ''''''NO EXISTE DATOS PARA INSERTAR EN LOS COBROS 
            ToastNotification.Show(Me, "NO EXISTE NINGUN PAGO INSERTADO PARA PODER GRABAR !!             ", img, 4000, eToastGlowColor.Orange, eToastPosition.TopCenter)

        End If
    End Sub
    Private Sub BtAdicionar_Click(sender As Object, e As EventArgs)
        _prGrabarCobro()
    End Sub

    Private Sub grpagos_MouseClick(sender As Object, e As MouseEventArgs) Handles grpagos.MouseClick
        'If (grpagos.CurrentColumn.Index = grpagos.RootTable.Columns("img").Index) Then
        '    _prELiminarFila()
        'End If
    End Sub
    Sub _prELiminarFila()
        If (grfactura.Row >= 0) Then
            If (grfactura.RowCount >= 2) Then
                Dim estado As Integer = grfactura.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = grfactura.GetValue("numidetalle")
                _fnObtenerFilaDetalle(pos, lin)
                If (estado = 0) Then
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("estado") = -2

                End If
                If (estado = 1) Then
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                grfactura.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(grfactura.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

                grfactura.Select()
                grfactura.Col = 1
                grfactura.Row = grfactura.RowCount - 1
            End If
        End If

    End Sub

    Private Sub MBtNuevo_Click(sender As Object, e As EventArgs) Handles MBtNuevo.Click
        _Limpiar()
        _prhabilitar()

        MBtNuevo.Enabled = False
        MBtModificar.Enabled = False
        MBtEliminar.Enabled = False
        MBtGrabar.Enabled = True
        MPanelToolBarNavegacion.Enabled = False
    End Sub

    Private Sub MBtModificar_Click(sender As Object, e As EventArgs) Handles MBtModificar.Click
        If (grcobranza.RowCount > 0) Then
            _prhabilitar()
            MBtNuevo.Enabled = False
            MBtModificar.Enabled = False
            MBtEliminar.Enabled = False
            MBtGrabar.Enabled = True

            MPanelToolBarNavegacion.Enabled = False
            _prCargarIconELiminar()
        End If
    End Sub
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(grfactura.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(grfactura.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer

        Next
        grfactura.RootTable.Columns("img").Visible = True
    End Sub

    Private Sub MBtEliminar_Click(sender As Object, e As EventArgs) Handles MBtEliminar.Click
        Dim ef = New Efecto


        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarCobranza(tbnrodoc.Text, mensajeError)
            If res Then


                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de COBRANZA ".ToUpper + tbnrodoc.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                _prFiltrar()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If
        End If
    End Sub
    Function _fnAccesible() As Boolean

        Return tbObservacion.ReadOnly = False
    End Function
    Private Sub tbcobrador_KeyDown(sender As Object, e As KeyEventArgs) Handles tbcobrador.KeyDown
        If (_fnAccesible()) Then
            If e.KeyData = Keys.Control + Keys.Enter Then

                Dim dt As DataTable

                dt = L_fnListarEmpleado()
                'a.cbnumi  , a.cbdesc, a.cbci, a.cbfnac 

                Dim listEstCeldas As New List(Of Modelo.MCelda)
                listEstCeldas.Add(New Modelo.MCelda("cbnumi", True, "Codigo", 120))
                listEstCeldas.Add(New Modelo.MCelda("cbdesc", True, "Nombre", 200))
                listEstCeldas.Add(New Modelo.MCelda("cbci", True, "CI", 90))
                listEstCeldas.Add(New Modelo.MCelda("cbfnac", True, "Fecha", 100, "yyyy/MM/dd"))


                Dim ef = New Efecto
                ef.tipo = 3
                ef.dt = dt
                ef.SeleclCol = 2
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 350
                ef.Context = "Seleccione Conciliacion".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then

                    'a.ibid ,a.ibfdoc ,a.ibconcep ,a.ibconcep ,c.cbdesc as chofer
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row


                    tbcodVendedor.Text = Row.Cells("cbnumi").Value
                    tbcobrador.Text = Row.Cells("cbdesc").Value
                    tbObservacion.Focus()
                End If





            End If

        End If
    End Sub

    Private Sub grfactura_Enter(sender As Object, e As EventArgs) Handles grfactura.Enter
        If (_fnAccesible()) Then
            If (tbcodVendedor.Text.Length <= 0) Then
                ToastNotification.Show(Me, "           Antes de Continuar Por favor Seleccione un COBRADOR!!             ".ToUpper, My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
                tbcobrador.Focus()
                Return
            End If
            grfactura.Select()
            grfactura.Col = 1
            grfactura.Row = 0
        End If
    End Sub

    Private Sub tbObservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles tbObservacion.KeyDown
        If e.KeyData = Keys.Enter Then
            'grfactura.Focus()

        End If
    End Sub

    Private Sub grfactura_KeyDown(sender As Object, e As KeyEventArgs) Handles grfactura.KeyDown
        If (Not _fnAccesible()) Then
            Return
        End If
        If (e.KeyData = Keys.Control + Keys.Enter And grfactura.Row >= 0 And
           grfactura.Col = grfactura.RootTable.Columns("cliente").Index) Then
            Dim indexfil As Integer = grfactura.Row
            Dim indexcol As Integer = grfactura.Col
            _HabilitarProductos()

        End If
        If (e.KeyData = Keys.Escape And grfactura.Row >= 0) Then

            _prELiminarFila()


        End If

    End Sub
    Private Sub _HabilitarProductos()
        GpanelDeudas.Visible = True
        MPnInferior.Visible = False
        _prCargarTablaCreditos()
        grPendiente.Focus()
        grPendiente.MoveTo(grPendiente.FilterRow)
        grPendiente.Col = 2
    End Sub
    Private Sub _DesHabilitarProductos()
        GpanelDeudas.Visible = False
        MPnInferior.Visible = True
        grfactura.Select()
        grfactura.Col = 1
        grfactura.Row = grfactura.RowCount - 1

    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(grfactura.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(grfactura.DataSource, DataTable).Rows(i).Item("numidetalle")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub
    Public Function _fnExistePago(idprod As Integer) As Boolean
        For i As Integer = 0 To CType(grfactura.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _idprod As Integer = CType(grfactura.DataSource, DataTable).Rows(i).Item("numiCredito")
            Dim estado As Integer = CType(grfactura.DataSource, DataTable).Rows(i).Item("estado")
            If (_idprod = idprod And estado >= 0) Then

                Return True
            End If
        Next
        Return False
    End Function
    Private Sub grPendiente_KeyDown(sender As Object, e As KeyEventArgs) Handles grPendiente.KeyDown
        If (Not _fnAccesible()) Then
            Return
        End If


        If (e.KeyData = Keys.Enter) Then
            Dim f, c As Integer
            c = grPendiente.Col
            f = grPendiente.Row
            If (f >= 0) Then
                Dim pos As Integer = -1
                grfactura.Row = grfactura.RowCount - 1
                _fnObtenerFilaDetalle(pos, grfactura.GetValue("numidetalle"))
                Dim existe As Boolean = _fnExistePago(grPendiente.GetValue("tcnumi"))
                If ((pos >= 0) And (Not existe)) Then
                    If (grfactura.GetValue("tcty4clie") > 0) Then
                        _prAddDetalle()
                        grfactura.Row = grfactura.RowCount - 1
                        _fnObtenerFilaDetalle(pos, grfactura.GetValue("numidetalle"))
                    End If
                    'detalle .tdnumi as numidetalle,cliente.yddesc as cliente,NroDoc, factura,a.tcnumi as numiCredito,cobranza .tenumi as numiCobranza
                    '	,a.tctv1numi ,a.tcty4clie ,detalle.tdfechaPago,detalle .tdmonto  as PagoAc,detalle .tdnrorecibo  as NumeroRecibo,
                    '' DescBanco,detalle .tdty3banco as banco, detalle.tdnrocheque,Cast('' as image)as img ,1 as estado ,Cast(0 as decimal(18,2)) as pendiente

                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("cliente") = grPendiente.GetValue("cliente")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("NroDoc") = grPendiente.GetValue("NroDoc")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("factura") = grPendiente.GetValue("factura")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("numiCredito") = grPendiente.GetValue("tcnumi")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("tctv1numi") = grPendiente.GetValue("tctv1numi")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("tcty4clie") = grPendiente.GetValue("tcty4clie")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("pendiente") = grPendiente.GetValue("pendiente")

                    _prCargarTablaCreditos()
                    grPendiente.RemoveFilters()
                    grPendiente.Focus()
                    grPendiente.MoveTo(grPendiente.FilterRow)
                    grPendiente.Col = 3
                    '_DesHabilitarProductos()
                Else
                    If (existe) Then
                        Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                        ToastNotification.Show(Me, "El PAGO DE ESTE VENTA ya existe en el detalle".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                    End If
                End If
            End If
        End If
        If e.KeyData = Keys.Escape Then
            _DesHabilitarProductos()
        End If
    End Sub


    Private Sub _prGuardarModificado()

        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagos(-1)
        _prInterpretarDatosCobranza(dtCobro)
        Dim res As Boolean = L_fnModificarCobranza(tbnrodoc.Text, tbfecha.Value.ToString("yyyy/MM/dd"), tbcodVendedor.Text, tbObservacion.Text, dtCobro)
        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de cobranza ".ToUpper + tbnrodoc.Text + " Modificado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prCargarCobranza()

            _prSalir()


        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser Modificada".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
    End Sub
    Private Sub MBtGrabar_Click(sender As Object, e As EventArgs) Handles MBtGrabar.Click
        If _ValidarCampos() = False Then
            Exit Sub
        End If

        If (tbnrodoc.Text = String.Empty) Then
            _GuardarNuevo()
        Else
            If (tbnrodoc.Text <> String.Empty) Then
                _prGuardarModificado()
                ''    _prInhabiliitar()

            End If
        End If
    End Sub
    Sub _prInterpretarDatosCobranza(ByRef dt As DataTable)


        '       numidetalle, NroDoc, factura, numiCredito, numiCobranza, A.tctv1numi
        ',a.tcty4clie ,cliente,detalle.tdfechaPago, PagoAc, NumeroRecibo, DescBanco, banco, detalle.tdnrocheque,
        'img,estado,pendiente
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        Dim dtcobro As DataTable = CType(grfactura.DataSource, DataTable)
        For i As Integer = 0 To dtcobro.Rows.Count - 1 Step 1
            Dim pago As Double = dtcobro.Rows(i).Item("PagoAc")
            Dim estado As Double = dtcobro.Rows(i).Item("estado")
            If (estado = 0) Then
                '             td.tdtv12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
                'td.tdnrocheque, @newFecha  ,@newHora  ,@teuact

                '     td.tdtv12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
                'td.tdnrocheque, @newFecha  ,@newHora  ,@teuact
                If (pago > 0) Then
                    dt.Rows.Add(0, dtcobro.Rows(i).Item("numiCredito"), 0, dtcobro.Rows(i).Item("NroDoc"),
                                            Now.Date, pago, dtcobro.Rows(i).Item("NumeroRecibo"), _fnObtenerNumiBancoLibreria(
                                                dtcobro.Rows(i).Item("DescBanco")), dtcobro.Rows(i).Item("tdnrocheque"), Now.Date,
                                            "", "", Bin.ToArray, 0)
                End If

            End If
            If (estado = 2) Then
                'tdtv12numi, tdtv13numi, tdnrodoc, tdfechaPago, tdmonto, tdnrorecibo, tdty3banco,
                ' tdnrocheque, tdfact, tdhact, tduact
                dt.Rows.Add(dtcobro.Rows(i).Item("numidetalle"), dtcobro.Rows(i).Item("numiCredito"), 0, dtcobro.Rows(i).Item("NroDoc"),
                                         Now.Date, pago, dtcobro.Rows(i).Item("NumeroRecibo"), _fnObtenerNumiBancoLibreria(
                                             dtcobro.Rows(i).Item("DescBanco")), dtcobro.Rows(i).Item("tdnrocheque"), Now.Date,
                                         "", "", Bin.ToArray, 2)
            End If
            If (estado = -1) Then
                'tdtv12numi, tdtv13numi, tdnrodoc, tdfechaPago, tdmonto, tdnrorecibo, tdty3banco,
                ' tdnrocheque, tdfact, tdhact, tduact
                dt.Rows.Add(dtcobro.Rows(i).Item("numidetalle"), dtcobro.Rows(i).Item("numiCredito"), 0, dtcobro.Rows(i).Item("NroDoc"),
                                         Now.Date, pago, dtcobro.Rows(i).Item("NumeroRecibo"), _fnObtenerNumiBancoLibreria(
                                             dtcobro.Rows(i).Item("DescBanco")), dtcobro.Rows(i).Item("tdnrocheque"), Now.Date,
                                         "", "", Bin.ToArray, -1)
            End If
        Next
    End Sub

    Public Function _fnObtenerNumiBancoLibreria(name As String) As Integer
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneral()
        '.DropDownList.Columns("yccod3").Caption = "COD"
        '.DropDownList.Columns.Add("ycdes3").Width = 200
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim data As String = dt.Rows(i).Item("ycdes3")
            If (data.Equals(name)) Then
                Return dt.Rows(i).Item("yccod3")
            End If
        Next
        Return -1
    End Function
    Public Sub _GuardarNuevo()

        '_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable
        Dim numi As String = ""
        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagos(-1)
        _prInterpretarDatosCobranza(dtCobro)
        Dim res As Boolean = L_fnGrabarCobranza(numi, tbfecha.Value.ToString("yyyy/MM/dd"), tbcodVendedor.Text, tbObservacion.Text, dtCobro)


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Compra ".ToUpper + tbnrodoc.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )

            _prCargarCobranza()
            _Limpiar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If

    End Sub
    Public Function _ValidarCampos() As Boolean
        If (tbcodVendedor.Text.Length <= 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
            ToastNotification.Show(Me, "Por Favor Seleccione un Cobrador con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            tbcobrador.Focus()
            Return False

        End If

        If (grfactura.RowCount > 0) Then
            grfactura.Row = grfactura.RowCount - 1
            If (grfactura.GetValue("tcty4clie") = 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione  un detalle de Pagos".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                Return False
            End If

        End If

        Return True
    End Function

    Private Sub grcobranza_SelectionChanged(sender As Object, e As EventArgs) Handles grcobranza.SelectionChanged
        If (grcobranza.RowCount >= 0 And grcobranza.Row >= 0) Then

            _prMostrarRegistro(grcobranza.Row)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles MBtUltimo.Click
        Dim _pos As Integer = grcobranza.Row
        If grcobranza.RowCount > 0 Then
            _pos = grcobranza.RowCount - 1
            ''  _prMostrarRegistro(_pos)
            grcobranza.Row = _pos
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles MBtSiguiente.Click
        Dim _pos As Integer = grcobranza.Row
        If _pos < grcobranza.RowCount - 1 Then
            _pos = grcobranza.Row + 1
            '' _prMostrarRegistro(_pos)
            grcobranza.Row = _pos
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles MBtAnterior.Click
        Dim _MPos As Integer = grcobranza.Row
        If _MPos > 0 And grcobranza.RowCount > 0 Then
            _MPos = _MPos - 1
            ''  _prMostrarRegistro(_MPos)
            grcobranza.Row = _MPos
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles MBtPrimero.Click
        _PrimerRegistro()
    End Sub
    Public Sub _PrimerRegistro()
        Dim _MPos As Integer
        If grcobranza.RowCount > 0 Then
            _MPos = 0
            ''   _prMostrarRegistro(_MPos)
            grcobranza.Row = _MPos
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        _prSalir()
    End Sub
    Private Sub _prSalir()
        If MBtGrabar.Enabled = True Then
            _prInhabiliitar()
            If grcobranza.RowCount > 0 Then

                _prMostrarRegistro(0)

            End If
        Else

            _modulo.Select()
            '_tab.Close()
            Close()

        End If
    End Sub

    Private Sub grfactura_MouseClick(sender As Object, e As MouseEventArgs) Handles grfactura.MouseClick
        If (Not _fnAccesible()) Then
            Return
        End If
        If (grfactura.RowCount >= 2) Then
            If (grfactura.CurrentColumn.Index = grfactura.RootTable.Columns("img").Index) Then
                _prELiminarFila()
            End If
        End If
    End Sub

    Private Sub grcobranza_KeyDown(sender As Object, e As KeyEventArgs) Handles grcobranza.KeyDown
        If (e.KeyData = Keys.Enter) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
        End If
    End Sub



    'Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
    '    If (Not _fnAccesible()) Then
    '        P_GenerarReporte()

    '    End If
    'End Sub
    'Private Sub P_GenerarReporte()
    '    Dim dt As DataTable = L_fnCobranzasReporte(tbnrodoc.Text)
    '    Dim total As Double = dt.Compute("SUM(importe)", "")
    '    If Not IsNothing(P_Global.Visualizador) Then
    '        P_Global.Visualizador.Close()
    '    End If
    '    Dim ParteEntera As Long
    '    Dim ParteDecimal As Double
    '    ParteEntera = Int(total)
    '    ParteDecimal = total - ParteEntera
    '    Dim li As String = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(ParteEntera)) + " con " +
    '    IIf(ParteDecimal.ToString.Equals("0"), "00", ParteDecimal.ToString) + "/100 Bolivianos"

    '    P_Global.Visualizador = New Visualizador

    '    Dim objrep As New R_ReporteCobranzas
    '    '' GenerarNro(_dt)
    '    ''objrep.SetDataSource(Dt1Kardex)
    '    objrep.SetDataSource(dt)
    '    objrep.SetParameterValue("total", li)
    '    objrep.SetParameterValue("usuario", gs_user)
    '    P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
    '    P_Global.Visualizador.Show() 'Comentar
    '    P_Global.Visualizador.BringToFront() 'Comentar


    'End Sub

    Private Sub tbObservacion_Leave(sender As Object, e As EventArgs) Handles tbObservacion.Leave
        grfactura.Select()
    End Sub

    Private Sub F0_CreditosPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub

    Private Sub grcobranza_DoubleClick(sender As Object, e As EventArgs) Handles grcobranza.DoubleClick
        MSuperTabControlPrincipal.SelectedTabIndex = 0
    End Sub
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