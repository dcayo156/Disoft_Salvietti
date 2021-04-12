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
Imports System.Math
Public Class F0_PagosCreditoCompraUlt
    Dim _Inter As Integer = 0
#Region "Variables Globales"
    Dim precio As DataTable
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim Bin As New MemoryStream
    Private boShow As Boolean = False
    Private boAdd As Boolean = False
    Private boModif As Boolean = False
    Private boDel As Boolean = False
    Dim dtTO00111 As DataTable
    Dim Asiento As Integer = 0

    Dim dtTC009 As DataTable = New DataTable

    Dim Lavadero As Integer = 42
    Dim Remolque As Integer = 55
    Dim Administracion As Integer = 56
    Dim Escuela As Integer = 1
    Dim Certificacion As Integer = 43
    Dim Hotel As Integer = 44
    Dim Linea As Integer = 0
#End Region
#Region "METODOS PRIVADOS"

    Private Sub _IniciarTodo()
        MSuperTabControl.SelectedTabIndex = 0
        'Dim img As New Bitmap(My.Resources.delete, 28, 28)
        'img.Save(Bin, Imaging.ImageFormat.Png)

        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        _prCargarComboLibreria(cbbanco, 6, 1)

        'Me.WindowState = FormWindowState.Maximized
        _prAsignarPermisos()
        ' P_prAsignarPermisos()
        Me.Text = "PAGO DE COMPRAS A CREDITOS"
        Dim blah As New Bitmap(New Bitmap(My.Resources.cobro), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
        _prCargarCobranza()
        _prInhabiliitar()
        'Ocultar el botón Modificar
        btnModificar.Visible = False
    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_prListarBanco(cod1, cod2)
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

        ''''''''''
        btnModificar.Enabled = True
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnEliminar.Enabled = True

        PanelNavegacion.Enabled = True
        'grdetalle.RootTable.Columns("img").Visible = False
        If (GpanelDeudas.Visible = True) Then
            _DesHabilitarProductos()
        End If
        'If (Not IsDBNull(grfactura)) Then
        '    grfactura.RootTable.Columns("img").Visible = False
        'End If

        grcobranza.Enabled = True
    End Sub
    Private Sub _prhabilitar()
        grcobranza.Enabled = False
        tbnrodoc.ReadOnly = False
        tbfecha.IsInputReadOnly = False
        tbObservacion.ReadOnly = False


        ''  tbCliente.ReadOnly = False  por que solo podra seleccionar Cliente
        ''  tbVendedor.ReadOnly = False
        grfactura.RootTable.Columns("img").Visible = True
        btnGrabar.Enabled = True
    End Sub
    Public Sub _prCargarCobranza()
        Dim dt As DataTable = L_fnCobranzasGeneralCompra()
        grcobranza.DataSource = dt
        grcobranza.RetrieveStructure()
        grcobranza.AlternatingColors = True
        '      a.tenumi ,a.tefdoc ,a.tety4vend,vendedor .yddesc as vendedor,
        'a.teobs ,a.tefact ,a.tehact ,a.teuact  ,Sum(detalle .tdmonto) as total 
        With grcobranza.RootTable.Columns("tenumi")
            .Width = 120
            .Visible = True
            .Caption = "Cod Cobranza"
        End With
        With grcobranza.RootTable.Columns("asiento")
            .Width = 120
            .Visible = False
        End With
        With grcobranza.RootTable.Columns("tdnrodoc")
            .Width = 120
            .Visible = True
            .Caption = "Nro. Compra"
            .FormatString = "dd/MM/yyyy"
        End With
        With grcobranza.RootTable.Columns("tefdoc")
            .Width = 120
            .Visible = True
            .Caption = "Fecha"
            .FormatString = "dd/MM/yyyy"
        End With
        With grcobranza.RootTable.Columns("tety4vend")

            .Width = 90
            .Visible = False
        End With
        With grcobranza.RootTable.Columns("vendedor")
            .Caption = "Cobrador"
            .Width = 300
            .Visible = False
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
            .FormatString = "0.00"
            .Visible = True
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
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
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
            LblPaginacion.Text = "0/0"
        End If
    End Sub

    Private Sub _Limpiar()
        tbnrodoc.Clear()
        tbfecha.Value = Now.Date
        tbObservacion.Clear()
        _prDetalleCobranzas(-1)
        _prAddDetalle()
        tbObservacion.Focus()

    End Sub
    Sub _prAddDetalle()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        '       numidetalle,proveedor.yddesc as proveedor, NroDoc,  numiCredito, numiCobranza
        ',a.tctc1numi ,a.tcty4prov  ,detalle.tdfechaPago, pendiente,PagoAc,NumeroRecibo, DescBanco, banco, detalle.tdnrocheque, img , estado 
        cbbanco.SelectedIndex = 0
        CType(grfactura.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, "", 0, 0, 0, 0, 0, Now.Date, 0,
                                                      0, "", cbbanco.Text, 0, "", Bin.ToArray, 0)
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
        dt = L_fnCobranzasDetalleCompras(_numi)
        _prCargarIconDelete(dt)
        grfactura.DataSource = dt
        grfactura.RetrieveStructure()
        grfactura.AlternatingColors = True
        '       numidetalle,proveedor.yddesc as proveedor, NroDoc,  numiCredito, numiCobranza
        ',a.tctc1numi ,a.tcty4prov  ,detalle.tdfechaPago, pendiente,PagoAc,NumeroRecibo, DescBanco, banco, detalle.tdnrocheque, img , estado 
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
        With grfactura.RootTable.Columns("tctc1numi")
            .Width = 100
            .Visible = False
        End With
        With grfactura.RootTable.Columns("tcty4prov")
            .Width = 100
            .Visible = False
        End With
        '       numidetalle,proveedor.yddesc as proveedor, NroDoc,  numiCredito, numiCobranza
        ',a.tctc1numi ,a.tcty4prov  ,detalle.tdfechaPago, pendiente,PagoAc,NumeroRecibo, DescBanco, banco, detalle.tdnrocheque, img , estado 
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
            .Caption = "Nro Compra"
            .TextAlignment = TextAlignment.Far
        End With

        With grfactura.RootTable.Columns("proveedor")
            .Caption = "Proveedor"
            .Width = 350
            .Visible = True
        End With
        With grfactura.RootTable.Columns("PagoAc")
            .Caption = "Total Pagado"
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
                .Caption = "Eliminar"
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
        '      a.tenumi ,a.tefdoc ,a.tety4vend,vendedor .yddesc as vendedor,
        'a.teobs ,a.tefact ,a.tehact ,a.teuact  ,Sum(detalle .tdmonto) as total 

        With grcobranza
            tbnrodoc.Text = .GetValue("tenumi")
            tbfecha.Value = .GetValue("tefdoc")
            tbObservacion.Text = .GetValue("teobs")
            lbFecha.Text = CType(.GetValue("tefact"), Date).ToString("dd/MM/yyyy")
            lbHora.Text = .GetValue("tehact").ToString
            lbUsuario.Text = .GetValue("teuact").ToString
            Asiento = .GetValue("asiento")
        End With

        _prDetalleCobranzas(tbnrodoc.Text)

        LblPaginacion.Text = Str(grcobranza.Row + 1) + "/" + grcobranza.RowCount.ToString

    End Sub
    Private Sub _prAsignarPermisos()

        'Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        'Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        'Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        'Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        'Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        'If add = False Then
        '    btnNuevo.Visible = False
        'End If
        'If modif = False Then
        '    btnModificar.Visible = False
        'End If
        'If del = False Then
        '    btnEliminar.Visible = False
        'End If

        Dim dtRolUsu() As DataRow = L_prRolDetalleGeneral(gi_userRol).Select("yaprog='" + _nameButton + "'")

        If (dtRolUsu.Count = 1) Then
            boShow = dtRolUsu(0).Item("ycshow")
            boAdd = dtRolUsu(0).Item("ycadd")
            boModif = dtRolUsu(0).Item("ycmod")
            boDel = dtRolUsu(0).Item("ycdel")
        End If

        If boAdd = False Then
            btnNuevo.Visible = False
        End If
        If boModif = False Then
            btnModificar.Visible = False
        End If
        If boDel = False Then
            btnEliminar.Visible = False
        End If

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
        '       A.tcnumi, sucursal, NroDoc
        ',a.tctc1numi ,a.tcty4prov  ,proveedor,a.tcfdoc , totalfactura,pendiente,PagoAc,NumeroRecibo
        Dim dt As New DataTable
        dt = L_fnCobranzasObtenerLasVentasACreditoCompras()
        _prEliminarExistente(dt)

        grPendiente.DataSource = dt
        grPendiente.RetrieveStructure()
        grPendiente.AlternatingColors = True
        With grPendiente.RootTable.Columns("tcnumi")
            .Width = 100
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("tctc1numi")
            .Width = 100
            .Visible = False
        End With
        With grPendiente.RootTable.Columns("tcty4prov")
            .Width = 100
            .Visible = False
        End With

        '       A.tcnumi, sucursal, NroDoc
        ',a.tctc1numi ,a.tcty4prov  ,proveedor,a.tcfdoc , totalfactura,pendiente,PagoAc,NumeroRecibo

        With grPendiente.RootTable.Columns("NroDoc")
            .Caption = "Nro Compra"
            .Width = 90
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With

        With grPendiente.RootTable.Columns("proveedor")
            .Caption = "Proveedor"
            .Width = 350
            .Visible = True
        End With


        With grPendiente.RootTable.Columns("tcfdoc")
            .Caption = "Fecha"
            .Width = 110
            .FormatString = "dd/MM/yyyy"
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("totalfactura")
            .Caption = "Total"
            .Width = 120
            .MaxLength = 100
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("pendiente")
            .Caption = "Pendiente Pago"
            .Width = 140
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
            .MaxLength = 10
            .Visible = True
        End With
        With grPendiente.RootTable.Columns("PagoAc")
            .Caption = "Pago A/C"
            .Width = 120
            .FormatString = "0.00"
            .MaxLength = 10
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
        dt = L_fnListarPagosCompras(_numi)
        '_prCargarIconDelete(dt)
        grpagos.DataSource = dt
        grpagos.RetrieveStructure()
        grpagos.AlternatingColors = True
        '       A.tdnumi, A.tdtc12numi, A.tdnrodoc, A.tdfechaPago, A.tdmonto, A.tdnrorecibo, A.tdfact, A.tdhact
        ',a.tduact,Cast('' as image)as img 
        With grpagos.RootTable.Columns("tdnumi")
            .Width = 100
            .Visible = False
        End With
        With grpagos.RootTable.Columns("tdtc12numi")
            .Width = 100
            .Visible = False
        End With
        With grpagos.RootTable.Columns("tdnrodoc")
            .Caption = "Nro Compra"
            .TextAlignment = TextAlignment.Far
            .Width = 90
            .Visible = True
        End With
        With grpagos.RootTable.Columns("tdfechaPago")
            .Caption = "Fecha Pago"
            .Width = 120
            .Visible = True
        End With
        With grpagos.RootTable.Columns("tdmonto")
            .Caption = "Pagos"
            .Width = 180
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
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
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(grfactura.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(grfactura.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer

        Next
        grfactura.RootTable.Columns("img").Visible = True
    End Sub
    Function _fnAccesible() As Boolean

        Return tbObservacion.ReadOnly = False
    End Function

    Private Sub _HabilitarProductos()
        GpanelDeudas.Visible = True
        PanelInferior.Visible = False
        _prCargarTablaCreditos() ''''Aqui poner el Primer Precio de Costo
        grPendiente.Focus()
        grPendiente.MoveTo(grPendiente.FilterRow)
        grPendiente.Col = 2
    End Sub
    Private Sub _DesHabilitarProductos()
        GpanelDeudas.Visible = False
        PanelInferior.Visible = True
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
    Private Sub _prGuardarModificado()

        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagosCompra(-1)
        _prInterpretarDatosCobranza(dtCobro)
        Dim res As Boolean = L_fnModificarCobranzaCompras(tbnrodoc.Text, tbfecha.Value.ToString("yyyy/MM/dd"), 0, tbObservacion.Text, dtCobro)
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
        dt = L_prListarBanco(6, 1)
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
        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagosCompra(-1)
        _prInterpretarDatosCobranza(dtCobro)
        Dim res As Boolean = L_fnGrabarCobranzaCompras(numi, tbfecha.Value.ToString("yyyy/MM/dd"), 0, tbObservacion.Text, dtCobro)


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
        If (grfactura.RowCount > 0) Then
            grfactura.Row = grfactura.RowCount - 1
            If (grfactura.GetValue("tcty4prov") = 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione  un detalle de Pagos".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                Return False
            End If

        End If

        Return True
    End Function
    Public Sub _PrimerRegistro()
        Dim _MPos As Integer
        If grcobranza.RowCount > 0 Then
            _MPos = 0
            ''   _prMostrarRegistro(_MPos)
            grcobranza.Row = _MPos
        End If
    End Sub
    Private Sub _prSalir()
        If btnGrabar.Enabled = True Then
            _prInhabiliitar()
            If grcobranza.RowCount > 0 Then

                _prMostrarRegistro(0)

            End If
        Else
            '_tab.Close()
            _modulo.Select()
            Close()
        End If
    End Sub
    Private Sub P_GenerarReporte()
        Dim dt As DataTable = L_fnCobranzasReporteCompras(tbnrodoc.Text)
        Dim total As Double = dt.Compute("SUM(importe)", "")
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If
        Dim ParteEntera As Long
        Dim ParteDecimal As Double
        ParteEntera = Int(total)
        ParteDecimal = total - ParteEntera
        Dim li As String = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(ParteEntera)) + " con " +
        IIf(ParteDecimal.ToString.Equals("0"), "00", ParteDecimal.ToString) + "/100 Bolivianos"

        P_Global.Visualizador = New Visualizador

        Dim objrep As New R_ReportePagosCobranzas
        '' GenerarNro(_dt)
        ''objrep.SetDataSource(Dt1Kardex)
        objrep.SetDataSource(dt)
        objrep.SetParameterValue("total", li)
        objrep.SetParameterValue("usuario", gs_user)
        P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
        P_Global.Visualizador.Show() 'Comentar
        P_Global.Visualizador.BringToFront() 'Comentar


    End Sub
#End Region
#Region "EVENTOS FORMULARIO"


    Private Sub F0_PagosCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub
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

    Private Sub grpagos_MouseClick(sender As Object, e As MouseEventArgs) Handles grpagos.MouseClick
        'If (grpagos.CurrentColumn.Index = grpagos.RootTable.Columns("img").Index) Then
        '    _prELiminarFila()
        'End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _Limpiar()
        _prhabilitar()

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True
        PanelNavegacion.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (grcobranza.RowCount > 0) Then
            _prhabilitar()
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True

            PanelNavegacion.Enabled = False
            _prCargarIconELiminar()
        End If
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Boolean = L_fnVerificarSiSeContabilizoPagoCompra(tbnrodoc.Text)
        If result Then
            Dim img As Bitmap = New Bitmap(My.Resources.WARNING, 50, 50)
            ToastNotification.Show(Me, "El Pago de la Compra ya fue contabilizada, si usted la elimina deberá hacer el ajuste del asiento contable manualmente".ToUpper, img, 5000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarCobranzaCompras(tbnrodoc.Text, mensajeError)
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

    Private Sub grfactura_Enter(sender As Object, e As EventArgs) Handles grfactura.Enter
        If (_fnAccesible()) Then

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
           grfactura.Col = grfactura.RootTable.Columns("proveedor").Index) Then
            Dim indexfil As Integer = grfactura.Row
            Dim indexcol As Integer = grfactura.Col
            _HabilitarProductos()

        End If
        If (e.KeyData = Keys.Escape And grfactura.Row >= 0) Then

            _prELiminarFila()


        End If

    End Sub

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
                    If (grfactura.GetValue("tcty4prov") > 0) Then
                        _prAddDetalle()
                        grfactura.Row = grfactura.RowCount - 1
                        _fnObtenerFilaDetalle(pos, grfactura.GetValue("numidetalle"))
                    End If
                    'detalle .tdnumi as numidetalle,cliente.yddesc as cliente,NroDoc, factura,a.tcnumi as numiCredito,cobranza .tenumi as numiCobranza
                    '	,a.tctv1numi ,a.tcty4clie ,detalle.tdfechaPago,detalle .tdmonto  as PagoAc,detalle .tdnrorecibo  as NumeroRecibo,
                    '' DescBanco,detalle .tdty3banco as banco, detalle.tdnrocheque,Cast('' as image)as img ,1 as estado ,Cast(0 as decimal(18,2)) as pendiente

                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("proveedor") = grPendiente.GetValue("proveedor")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("NroDoc") = grPendiente.GetValue("NroDoc")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("numiCredito") = grPendiente.GetValue("tcnumi")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("tctc1numi") = grPendiente.GetValue("tctc1numi")
                    CType(grfactura.DataSource, DataTable).Rows(pos).Item("tcty4prov") = grPendiente.GetValue("tcty4prov")
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
                        ToastNotification.Show(Me, "El PAGO DE ESTE COBRANZA ya existe en el detalle".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                    End If
                End If
            End If
        End If
        If e.KeyData = Keys.Escape Then
            _DesHabilitarProductos()
        End If
    End Sub



    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
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


    Private Sub grcobranza_SelectionChanged(sender As Object, e As EventArgs) Handles grcobranza.SelectionChanged
        If (grcobranza.RowCount >= 0 And grcobranza.Row >= 0) Then

            _prMostrarRegistro(grcobranza.Row)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim _pos As Integer = grcobranza.Row
        If grcobranza.RowCount > 0 Then
            _pos = grcobranza.RowCount - 1
            ''  _prMostrarRegistro(_pos)
            grcobranza.Row = _pos
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim _pos As Integer = grcobranza.Row
        If _pos < grcobranza.RowCount - 1 Then
            _pos = grcobranza.Row + 1
            '' _prMostrarRegistro(_pos)
            grcobranza.Row = _pos
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim _MPos As Integer = grcobranza.Row
        If _MPos > 0 And grcobranza.RowCount > 0 Then
            _MPos = _MPos - 1
            ''  _prMostrarRegistro(_MPos)
            grcobranza.Row = _MPos
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        _PrimerRegistro()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _prSalir()
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
            MSuperTabControl.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub grcobranza_DoubleClick(sender As Object, e As EventArgs) Handles grcobranza.DoubleClick

        MSuperTabControl.SelectedTabIndex = 0

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'If (Not _fnAccesible()) Then
        '    P_GenerarReporte()

        'End If
    End Sub


    Private Sub tbObservacion_Leave(sender As Object, e As EventArgs) Handles tbObservacion.Leave
        grfactura.Select()
    End Sub

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click

        If (Asiento > 0) Then
            ToastNotification.Show(Me, "El pago de esta compra ya ha sido Contabilizada".ToUpper,
                                           My.Resources.WARNING, 2000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)

            Return

        End If
        dtTO00111 = L_prComprobanteDetalleDetalleGeneral(-1)
        GenerarComprobante()

    End Sub

    Public Function ObtenerNumiProveedor() As Integer
        Dim dt As DataTable = CType(grfactura.DataSource, DataTable)
        If (dt.Rows.Count > 0) Then

            Return dt.Rows(0).Item("tcty4prov")

        End If
        Return -1
    End Function
    Private Function to3Decimales(num As Double) As Double
        Dim res As Double = 0
        Dim numeroString As String = num.ToString()
        Dim posicionPuntoDecimal As Integer = numeroString.IndexOf(".")

        If posicionPuntoDecimal > 0 Then
            Dim cantidadDecimales As Integer = numeroString.Substring(posicionPuntoDecimal).Count - 1
            If cantidadDecimales >= 3 Then
                numeroString = numeroString.Substring(0, posicionPuntoDecimal + 4)
                res = Convert.ToDouble(numeroString)
            Else
                res = num
            End If

        Else
            res = num
        End If
        Return res
    End Function

    Public Function _fnBuscarIDTC009(ci As String, _dt As DataTable) As Integer
        For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
            If (ci.Equals(_dt.Rows(i).Item("cjci"))) Then
                Return _dt.Rows(i).Item("cjnumi")
            End If

        Next
        Return 0

    End Function
    Public Sub GenerarComprobante()
        Dim numiCuenta As Integer
        Dim dt As New DataTable
        dt = L_prServicioListarCuentasCreditocompras(1003, ObtenerNumiProveedor())  ''Ok
        Dim tabla As DataTable = dt.Copy
        tabla.Rows.Clear()
        Dim BanderaCuentaPorCobrar As Boolean = False
        Dim dtPagos As DataTable

        For i As Integer = 0 To dt.Rows.Count - 1
            dtPagos = New DataTable

            Dim dtDetalle As DataTable = L_prObtenerDetallePlantilla(dt.Rows(i).Item("canumi"), 1003)

            Dim tipo As Integer
            If (dtDetalle.Rows.Count <= 0) Then
                tipo = -1
            Else
                tipo = dtDetalle.Rows(0).Item("tipo")
            End If


            If (tipo = -1) Then ''''Venta Contado
                dtPagos = L_prObtenerPagosTotalesCuentaPorCobrar(tbnrodoc.Text)
                dtTC009 = L_prListarProveedorCreditoParaTC009Pagos(tbnrodoc.Text)

            Else
                If (tipo = -2) Then

                    dtPagos = L_prObtenerPagosTotalesCuentaPorCobrarCAJA(tbnrodoc.Text)

                Else
                    Dim dtCuentasBancos = L_prServicioListarCuentasBAncos(1003, tbnrodoc.Text)  ''Ok

                    Dim numiPadre As Integer = 0

                    For p As Integer = 0 To dtCuentasBancos.Rows.Count - 1 Step 1

                        numiCuenta = dtCuentasBancos.Rows(p).Item("canumi")
                        Dim dtObtenerCuenta As DataTable = L_prCuentaDiferencia(numiCuenta)
                        If (dtObtenerCuenta.Rows(0).Item("canumi") <> numiPadre) Then
                            numiPadre = dtObtenerCuenta.Rows(0).Item("canumi")
                            tabla.Rows.Add(dtObtenerCuenta.Rows(0).Item("canumi"), dtObtenerCuenta.Rows(0).Item("cacta"), dtObtenerCuenta.Rows(0).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, Escuela, 0) '''' Aqui agrego al padre
                        End If

                        tabla.ImportRow(dtCuentasBancos.Rows(p))



                        dtPagos = L_prObtenerPagosTotalesCuentaPorCobrarByBanco(tbnrodoc.Text, dtCuentasBancos.Rows(p).Item("canumi"))


                        numiCuenta = dtCuentasBancos.Rows(p).Item("canumi")


                        If (dtPagos.Rows.Count > 0) Then

                            For k As Integer = 0 To dtPagos.Rows.Count - 1 Step 1
                                Dim Glosa As String = dt.Rows(i).Item("cadesc")

                                Dim conversion As Double = dtPagos.Rows(k).Item("tdmonto")
                                conversion = to3Decimales(conversion)
                                Dim totales As Double = Round(conversion, 2)
                                Dim TotalSus As Double = Round(to3Decimales(totales / (6.96)), 2)
                                Linea = Linea + 1
                                Dim fact As String = " con Factura Nro #" + Str(dtPagos.Rows(k).Item("nroDocumento"))

                                If (dt.Rows(i).Item("chdebe") > 0) Then
                                    tabla.Rows.Add(numiCuenta, DBNull.Value, dtPagos.Rows(k).Item("proveedor") + fact, DBNull.Value, DBNull.Value, DBNull.Value, 6.96, totales, DBNull.Value, TotalSus, DBNull.Value, Escuela, Linea)
                                Else
                                    tabla.Rows.Add(numiCuenta, DBNull.Value, dtPagos.Rows(k).Item("proveedor") + fact, DBNull.Value, DBNull.Value, DBNull.Value, 6.96, DBNull.Value, totales, DBNull.Value, TotalSus, Escuela, Linea)
                                End If
                            Next



                        End If


                    Next
                    dtPagos = New DataTable


                End If

            End If

            ''canumi , nro,cadesc ,chporcen,chdebe ,chhaber 
            Dim porcentaje As Double = dt.Rows(i).Item("chporcen")



            numiCuenta = dt.Rows(i).Item("canumi")

            Dim numicuentaatc As Integer = 21 'ATC

            If (dtPagos.Rows.Count > 0) Then
                numiCuenta = dt.Rows(i).Item("canumi")
                Dim dtObtenerCuenta As DataTable = L_prCuentaDiferencia(numiCuenta)
                tabla.Rows.Add(dtObtenerCuenta.Rows(0).Item("canumi"), dtObtenerCuenta.Rows(0).Item("cacta"), dtObtenerCuenta.Rows(0).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, Escuela, 0) '''' Aqui agrego al padre
                tabla.ImportRow(dt.Rows(i))  '''Aqui agrego al hijo

                Dim _dtTC009Inserted As DataTable
                If (tipo = -1) Then ''''Venta Contado
                    '''''''Relleno el numi de la cuenta en la TC009
                    For p As Integer = 0 To dtTC009.Rows.Count - 1 Step 1
                        dtTC009.Rows(p).Item("cjnumiTc001") = numiCuenta
                    Next
                    '''''''''''Insertamos a la TC009'''''''''''''''
                    _dtTC009Inserted = L_prInsertarTC009(dtTC009)

                    '''''''''''''''''''''''''''''''''''''''''''''''
                End If




                For k As Integer = 0 To dtPagos.Rows.Count - 1 Step 1
                    Dim Glosa As String = dt.Rows(i).Item("cadesc")

                    Dim conversion As Double = dtPagos.Rows(k).Item("tdmonto")
                    conversion = to3Decimales(conversion)
                    Dim totales As Double = Round(conversion, 2)
                    Dim TotalSus As Double = Round(to3Decimales(totales / (6.96)), 2)
                    Linea = Linea + 1
                    If (tipo = -1) Then

                        ''''''''''''''''''
                        Dim IdTC009 As Integer = _fnBuscarIDTC009(dtPagos.Rows(k).Item("ydnumi"), _dtTC009Inserted)
                        dtTO00111.Rows.Add(0, Linea, IdTC009, 1)
                        '''''''''''''''''''''''''
                    End If


                    If (dt.Rows(i).Item("chdebe") > 0) Then
                        tabla.Rows.Add(numiCuenta, DBNull.Value, dtPagos.Rows(k).Item("proveedor") + " con Factura Nro #" + dtPagos.Rows(k).Item("nroDocumento"), DBNull.Value, DBNull.Value, DBNull.Value, 6.96, totales, DBNull.Value, TotalSus, DBNull.Value, Escuela, Linea)
                    Else
                        tabla.Rows.Add(numiCuenta, DBNull.Value, dtPagos.Rows(k).Item("proveedor") + " con Factura Nro #" + dtPagos.Rows(k).Item("nroDocumento"), DBNull.Value, DBNull.Value, DBNull.Value, 6.96, DBNull.Value, totales, DBNull.Value, TotalSus, Escuela, Linea)
                    End If
                Next



            End If





        Next

        _prArmarCuadre(tabla)

        For Each fila As DataRow In tabla.Rows
            If IsDBNull(fila.Item("debe")) = True Then
                fila.Item("debe") = 0
            End If
            If IsDBNull(fila.Item("haber")) = True Then
                fila.Item("haber") = 0
            End If
            If IsDBNull(fila.Item("debesus")) = True Then
                fila.Item("debesus") = 0
            End If
            If IsDBNull(fila.Item("habersus")) = True Then
                fila.Item("habersus") = 0
            End If
        Next
        Dim dt2 As DataTable

        dt2 = L_prObtenerPlantila(1003)

        Dim tipo02 As Integer

        tipo02 = dt2.Rows(0).Item("Tipo")
        Dim factura As Integer = dt2.Rows(0).Item("Factura")
        Dim TipoTransacion As Integer = 2
        Dim numiComprobante As String = ""
        Dim res As Boolean = L_prComprobanteGrabarIntegracion(numiComprobante, "", 1, Now.Date.Year.ToString, Now.Date.Month.ToString, "", Now.Date.ToString("yyyy/MM/dd"), 6.96, "", "", 1, tabla, "", 0, 6.96, Now.Date.ToString("yyyy/MM/dd"), Now.Date.ToString("yyyy/MM/dd"), 1, 1,
                                                             tipo02, factura, Now.Date.ToString("yyyy/MM/dd"), Now.Date.ToString("yyyy/MM/dd"), TipoTransacion, tbnrodoc.Text, dtTO00111)
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "El Asiento Contable fue generado Exitosamente".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )


        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Los codigos no pudieron ser modificados".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If


    End Sub

    Public Sub _prArmarCuadre(ByRef dt As DataTable)
        Try
            Dim totaldebe As Double = dt.Compute("Sum(debe)", "")
            Dim totalhaber As Double = dt.Compute("Sum(haber)", "")
            Dim totaldebesus As Double = dt.Compute("Sum(debesus)", "")
            Dim totalhabersus As Double = dt.Compute("Sum(habersus)", "")
            Dim restantedebe As Double = 0
            Dim restanteHaber As Double = 0
            Dim RestanteDebeSus As Double = 0
            Dim RestanteHaberSus As Double = 0
            If (totaldebe > totalhaber) Then
                restanteHaber = totaldebe - totalhaber
            Else
                restantedebe = totalhaber - totaldebe
            End If
            If (totaldebesus > totalhabersus) Then
                RestanteHaberSus = totaldebesus - totalhabersus
            Else
                RestanteDebeSus = totalhabersus - totaldebesus
            End If
            If (restantedebe > 0 Or restanteHaber > 0 Or RestanteDebeSus > 0 Or RestanteHaberSus > 0) Then
                Dim dtObtenerCuenta As DataTable = L_prCuentaDiferencia(652)  '''3=Lavadero
                dt.Rows.Add(dtObtenerCuenta.Rows(0).Item("canumi"), dtObtenerCuenta.Rows(0).Item("cacta"), dtObtenerCuenta.Rows(0).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, Administracion, 0)
                dt.Rows.Add(dtObtenerCuenta.Rows(1).Item("canumi"), dtObtenerCuenta.Rows(1).Item("cacta"), dtObtenerCuenta.Rows(1).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, Administracion, 0)
                Linea = Linea + 1
                dt.Rows.Add(dtObtenerCuenta.Rows(1).Item("canumi"), DBNull.Value, "Ajuste de Cambio", DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, IIf(restantedebe = 0, DBNull.Value, restantedebe), IIf(restanteHaber = 0, DBNull.Value, restanteHaber), IIf(RestanteDebeSus = 0, DBNull.Value, RestanteDebeSus), IIf(RestanteHaberSus = 0, DBNull.Value, RestanteHaberSus), Administracion, Linea)


            Else


            End If
        Catch ex As Exception

        End Try



    End Sub
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