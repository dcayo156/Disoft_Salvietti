﻿Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls
Imports System.Math


Public Class F02_Compra

#Region "Atributos generales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public Linea As Integer = 0
    Private boShow As Boolean = False
    Private boAdd As Boolean = False
    Private boModif As Boolean = False
    Private boDel As Boolean = False
    Dim dtTO00111 As DataTable
    Private Asiento As Integer = 0
    Public _detalleCompras As DataTable 'Almacena el detalle para insertar a la tabla TPA001 del BDDiconCF
    Dim dtTC009 As DataTable = New DataTable
    Public conv As String

#End Region

#Region "Propiedades generales"

#End Region

#Region "Variables globales locales"
    Dim FtTitulo As Font = New Font("Arial", gi_fuenteTamano + 1)
    Dim FtNormal As Font = New Font("Arial", gi_fuenteTamano)

    Dim DtBusqueda As DataTable
    Dim DtDetalle As DataTable
    Dim StRutaDocumentos = gs_CarpetaRaiz + "\Documentos\Compra\"
    Dim InDuracion As Byte = 5

    Dim BoNuevo As Boolean = False
    Dim BoModificar As Boolean = False
    Dim BoEliminar As Boolean = False
    Dim BoNavegar As Boolean = False

#End Region
    Dim _inter As Integer = 0
#Region "Eventos generales"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub MBtNuevo_Click(sender As Object, e As EventArgs) Handles MBtNuevo.Click
        P_prNuevoRegistro()
    End Sub

    Private Sub MBtModificar_Click(sender As Object, e As EventArgs) Handles MBtModificar.Click
        P_prModificarRegistro()
    End Sub

    Private Sub MBtEliminar_Click(sender As Object, e As EventArgs) Handles MBtEliminar.Click
        P_prEliminarRegistro()
    End Sub

    Private Sub MBtGrabar_Click(sender As Object, e As EventArgs) Handles MBtGrabar.Click
        P_prGrabarRegistro()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        P_prCancelarRegistro()
    End Sub

    Private Sub MBtPrimero_Click(sender As Object, e As EventArgs) Handles MBtPrimero.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MoveFirst()
        End If
    End Sub

    Private Sub MBtAnterior_Click(sender As Object, e As EventArgs) Handles MBtAnterior.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MovePrevious()
        End If
    End Sub

    Private Sub MBtSiguiente_Click(sender As Object, e As EventArgs) Handles MBtSiguiente.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MoveNext()
        End If
    End Sub

    Private Sub MBtUltimo_Click(sender As Object, e As EventArgs) Handles MBtUltimo.Click
        If (dgjBusqueda.RowCount > 0) Then
            dgjBusqueda.MoveLast()
        End If
    End Sub

    Private Sub DgjBusqueda_SelectionChanged(sender As Object, e As EventArgs) Handles dgjBusqueda.SelectionChanged
        If (dgjBusqueda.Row > -1 And (Not BoNuevo And Not BoModificar)) Then
            P_prLlenarDatos(dgjBusqueda.Row)
        End If
    End Sub

    Private Sub dgjBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgjBusqueda.DoubleClick
        If (dgjBusqueda.Row > -1) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub dgjBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgjBusqueda.KeyDown
        If (e.KeyData = Keys.Enter) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles tbProveedor.KeyDown
        If (BoNuevo Or BoModificar) Then
            If (e.KeyData = Keys.Control + Keys.Enter) Then
                P_prArmarAyudaProveedor()
            End If
        End If
    End Sub

    Private Sub btBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btBuscarProveedor.Click
        P_prArmarAyudaProveedor()
    End Sub

    Private Sub tbNroFactura_KeyPress(sender As Object, e As KeyPressEventArgs)
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub tbObs_Leave(sender As Object, e As EventArgs) Handles tbObs.Leave
        If (BoNuevo Or BoModificar) Then
            dgjDetalle.Select()
        End If
    End Sub

    Private Sub dgjDetalle_Enter(sender As Object, e As EventArgs) Handles dgjDetalle.Enter

        If (tbCodProveedor.Text = String.Empty) Then
            ToastNotification.Show(Me, "           Antes de Continuar Por favor Seleccione un Proveedor!!             ", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            tbProveedor.Focus()
            Return
        End If
        dgjDetalle.Row = 0
        dgjDetalle.Col = dgjDetalle.RootTable.Columns("cabtc1numi").Index

    End Sub

    Private Sub dgjDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles dgjDetalle.KeyDown

        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prArmarAyudaProducto()
        ElseIf (e.KeyData = Keys.Enter) Then
            Dim f, c As Integer
            c = dgjDetalle.Col
            f = dgjDetalle.Row

            'Pasar el foco a peso
            If (c = dgjDetalle.RootTable.Columns("cabtc1numi").Index) Then
                dgjDetalle.Row = f
                dgjDetalle.Col = c + 2
            End If
            If (c = dgjDetalle.RootTable.Columns("ntc1numi").Index) Then
                dgjDetalle.Row = f
                dgjDetalle.Col = c + 1
            End If
            If (c = dgjDetalle.RootTable.Columns("cabcantcj").Index) Then
                dgjDetalle.Row = f
                dgjDetalle.Col = c + 1
            End If
            If (c = dgjDetalle.RootTable.Columns("cabcantun").Index) Then
                dgjDetalle.Row = f
                dgjDetalle.Col = c + 1
            End If
            If (c = dgjDetalle.RootTable.Columns("cabsubtot").Index) Then
                dgjDetalle.Row = f
                dgjDetalle.Col = c + 5
            End If
            If (c = dgjDetalle.RootTable.Columns("cabdesccj").Index) Then
                If (dgjDetalle.Row = dgjDetalle.RowCount - 1) Then
                    P_prAddFilaDetalle()
                End If
                dgjDetalle.Row = f + 1
                dgjDetalle.Col = dgjDetalle.RootTable.Columns("ntc1numi").Index
                P_prArmarAyudaProducto()
            End If
        End If
    End Sub
    Public Sub _prCalcularPrecioTotal()
        ''Agregado para que Muestre el Subtotal de la compra
        'tbSubtotalC.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabtot"), AggregateFunction.Sum)
        tbSubtotalC.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabsubtot"), AggregateFunction.Sum)

        'Dim montodesc As Double = tbMdesc.Value
        Dim montodesc As Double = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabdesccj"), AggregateFunction.Sum)

        tbMdesc.Value = montodesc

        ' tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabtot"), AggregateFunction.Sum) - montodesc
        tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabsubtot"), AggregateFunction.Sum) - (montodesc + tbDescuentoPro1.Value + tvDescuento02.Value)

    End Sub
    Private Sub dgjDetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjDetalle.EditingCell
        If (BoNuevo Or BoModificar) Then
            If (e.Column.Key.Equals("cabcantcj") Or e.Column.Key.Equals("cabcantun") Or e.Column.Key.Equals("cabsubtot") Or e.Column.Key.Equals("cabdesccj")) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgjDetalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles dgjDetalle.CellEdited
        If (BoModificar Or BoNuevo) Then
            If (e.Column.Key.Equals("cabcantcj") Or e.Column.Key.Equals("cabcantun") Or e.Column.Key.Equals("cabsubtot") Or e.Column.Key.Equals("cabdesccj")) Then

                'If (e.Column.Key.Equals("cabcant")) Then
                '    'dgjDetalle.SetValue("total", dgjDetalle.GetValue("cabcant") * dgjDetalle.GetValue("cabpcom"))
                '    dgjDetalle.SetValue("cabsubtot", dgjDetalle.GetValue("cabcant") * dgjDetalle.GetValue("cabpcom"))
                'End If

                'If (e.Column.Key.Equals("cabpcom")) Then
                '    'dgjDetalle.SetValue("total", dgjDetalle.GetValue("cabcant") * dgjDetalle.GetValue("cabpcom"))
                '    dgjDetalle.SetValue("cabsubtot", dgjDetalle.GetValue("cabcant") * dgjDetalle.GetValue("cabpcom"))
                'End If

                If (dgjDetalle.GetValue("cabtca1numi") <> 0) Then
                    dgjDetalle.SetValue("estado", 2)
                End If
            End If
        End If
    End Sub

    Private Sub tsmiEliminarFilaDetalle_Click(sender As Object, e As EventArgs) Handles tsmiEliminarFilaDetalle.Click
        Try
            dgjDetalle.CurrentRow.EndEdit()
            dgjDetalle.CurrentRow.Delete()
            dgjDetalle.Refetch()
            dgjDetalle.Refresh()
            _prCalcularPrecioTotal()
        Catch ex As Exception
            'sms
            'MsgBox(ex)
        End Try
    End Sub

#End Region

#Region "Metodos y funciones indispensables"

    Private Sub P_prInicio()
        _leerParametros()
        'Abrir conexión
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        'Validar requisitos del programa
        If (Not P_fnValidarRequisitos() = String.Empty) Then
            Return
        End If

        'Inicializar componentes
        P_prInicializarComponentes()

        'Habilitar/Deshabilitar compotentes del formulario
        P_prHDComponentes(False)

        'Armar todo los combobox 
        P_prArmarCombos()

        'Armar todo las grillas
        BoNavegar = False
        P_prArmarGrillas()
        P_prEliminarArchivosSinReferencia(DtBusqueda, "nimg", StRutaDocumentos)
        BoNavegar = True

        P_prActualizarPaginacion(0)
        P_prLlenarDatos(0)
    End Sub
    Private Sub _leerParametros()
        LabelX5.Visible = gs_Parametros(0).Item("sycompracred")
        swTipoVenta.Visible = gs_Parametros(0).Item("sycompracred")
        lbCredito.Visible = gs_Parametros(0).Item("sycompracred")
        tbFechaVenc.Visible = gs_Parametros(0).Item("sycompracred")
        LabelX16.Visible = gs_Parametros(0).Item("sycomprafact")
        swEmision.Visible = gs_Parametros(0).Item("sycomprafact")
        GroupPanelFactura2.Visible = gs_Parametros(0).Item("sycomprafact")
        LabelX13.Visible = gs_Parametros(0).Item("sycomprareten")
        swRetencion.Visible = gs_Parametros(0).Item("sycomprareten")
        LabelX12.Visible = gs_Parametros(0).Item("sycompraconsig")
        swConsigna.Visible = gs_Parametros(0).Item("sycompraconsig")
        LabelX2.Visible = gs_Parametros(0).Item("sycompraasiento")
        swAsiento.Visible = gs_Parametros(0).Item("sycompraasiento")
        LabelX14.Visible = gs_Parametros(0).Item("sycompradescpr1")
        tbDescuentoPro1.Visible = gs_Parametros(0).Item("sycompradescpr1")
        LabelX15.Visible = gs_Parametros(0).Item("sycompradescpr2")
        tvDescuento02.Visible = gs_Parametros(0).Item("sycompradescpr2")
    End Sub
    Private Function P_fnValidarRequisitos() As String
        Dim sms As String = ""

        'Crea la carpeta de imagenes si es que no estuviera creada.
        P_prValidarCarpetaImagenes()

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   "".ToUpper,
                                   My.Resources.WARNING,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return sms
    End Function

    Private Sub P_prInicializarComponentes()
        'Form
        Me.Text = "C O M P R A"
        ' Me.WindowState = FormWindowState.Maximized

        'Tab
        MSuperTabControlPrincipal.SelectedTabIndex = 0

        'Visible
        'MBtImprimir.Visible = False
        tsmiEliminarFilaDetalle.Visible = False
        tbCodProveedor.Visible = False

        'Enabled
        MBtGrabar.Enabled = False

        'ReadOnly
        tbCodigo.ReadOnly = True
        tbProveedor.ReadOnly = True

        'Grid Busqueda
        dgjBusqueda.AllowEdit = Janus.Data.InheritableBoolean.False

        'Botones

        'Funciones
        P_prCambiarFuenteComponentes()
        P_prAsignarPermisos()

        'Usuario del sistema
        MTbUsuario.Text = gs_user
    End Sub

    Private Sub P_prCambiarFuenteComponentes()
        Dim xCtrl As Control
        For Each xCtrl In TableLayoutPanelPrincipal.Controls
            Try
                xCtrl.Font = FtNormal
            Catch ex As Exception
            End Try
        Next
        'For Each xCtrl In TableLayoutPanelPrincipal.Controls
        '    Try
        '        xCtrl.Font = FtNormal
        '    Catch ex As Exception
        '    End Try
        'Next
    End Sub

    Private Sub P_prAsignarPermisos()

        Dim dtRolUsu() As DataRow = L_prRolDetalleGeneral(gi_userRol).Select("yaprog='" + _nameButton + "'")

        If (dtRolUsu.Count = 1) Then
            boShow = dtRolUsu(0).Item("ycshow")
            boAdd = dtRolUsu(0).Item("ycadd")
            boModif = dtRolUsu(0).Item("ycmod")
            boDel = dtRolUsu(0).Item("ycdel")
        End If

        If boAdd = False Then
            MBtNuevo.Visible = False
        End If
        If boModif = False Then
            MBtModificar.Visible = False
        End If
        If boDel = False Then
            MBtEliminar.Visible = False
        End If

    End Sub

    Private Sub P_prHDComponentes(ByVal flat As Boolean)
        'TextBox
        'tbProveedor.ReadOnly = Not flat


        tbNroFactura.ReadOnly = Not flat
        tbObs.ReadOnly = Not flat
        tbNitProv.ReadOnly = Not flat
        tbNAutorizacion.ReadOnly = Not flat
        tbCodControl.ReadOnly = Not flat
        tbNDui.ReadOnly = Not flat
        tbSACF.ReadOnly = Not flat

        tbMdesc.IsInputReadOnly = Not flat

        If MBtNuevo.Enabled = True Then
            tbSubtotalC.IsInputReadOnly = Not flat
            tbtotal.IsInputReadOnly = Not flat
            tbMdesc.IsInputReadOnly = Not flat
        Else
            tbSubtotalC.IsInputReadOnly = flat
            tbtotal.IsInputReadOnly = flat
            tbMdesc.IsInputReadOnly = flat
            tbNitProv.ReadOnly = flat
        End If

        'ComboBox

        'DateTimer
        dtiFechaCompra.IsInputReadOnly = Not flat
        dtiFechaCompra.ButtonDropDown.Enabled = flat

        dtiFfactura.IsInputReadOnly = Not flat

        'Button
        btBuscarProveedor.Enabled = flat

        'Switch Button
        swTipoVenta.IsReadOnly = flat
        swEmision.IsReadOnly = Not flat
        swConsigna.IsReadOnly = Not flat
        swRetencion.IsReadOnly = Not flat
        'Radio Button

        'Grillas
        dgjDetalle.AllowEdit = IIf(flat, 1, 2)
    End Sub

    Private Sub P_prLimpiar()
        'TextBox
        tbCodigo.Clear()
        tbCodProveedor.Clear()
        tbProveedor.Clear()
        tbNroFactura.Text = "0"
        tbObs.Clear()
        tbNitProv.Clear()
        swEmision.Value = True
        swConsigna.Value = False
        swRetencion.Value = False
        swTipoVenta.Value = False
        tbFechaVenc.Value = Now.Date
        'tbNroFactura.Clear()
        'tbNAutorizacion.Clear()
        'tbCodControl.Clear()
        'tbNDui.Clear()
        tbNroFactura.Text = "0"
        tbNAutorizacion.Text = "0"
        tbCodControl.Text = "0"
        tbNDui.Text = "0"
        tbSACF.Clear()

        tbSubtotalC.Value = 0
        tbMdesc.Value = 0
        tbDescuentoPro1.Value = 0
        tvDescuento02.Value = 0
        tbtotal.Value = 0


        'ComboBox

        'DateTimer
        dtiFechaCompra.Value = Now.Date
        dtiFfactura.Value = Now.Date

        'Switch Button

        'Radio Button

        'Grillas
        P_prArmarGrillaDetalle("-1")

        MBtGrabar.Tooltip = "GRABAR"
    End Sub

    Private Sub P_prArmarCombos()

    End Sub

    Private Sub P_prArmarGrillas()
        P_prArmarGrillaBusqueda()
        P_prArmarGrillaDetalle("-1")
    End Sub

    Private Sub P_prActualizarPaginacion(ByVal index As Integer)
        MLbPaginacion.Text = "Reg. " & index + 1 & " de " & dgjBusqueda.GetRows.Count

    End Sub

    Private Sub P_prMoverIndexActual()
        Dim index As Integer = CInt(MLbPaginacion.Text.Trim.Split(" ")(1).Trim)
        If (index < 0) Then
            index = 0
        End If
        If (index > dgjBusqueda.RowCount) Then
            index = dgjBusqueda.RowCount
        End If
        If index > 0 Then
            dgjBusqueda.MoveTo(index - 1)
            P_prLlenarDatos(dgjBusqueda.Row)
        Else
            dgjBusqueda.MoveTo(index)
            P_prLlenarDatos(index)
            P_prActualizarPaginacion(index)
            P_prLimpiar()
        End If

    End Sub

    Private Sub P_prLlenarDatos(ByVal index As Integer)
        If (index <= dgjBusqueda.GetRows.Count - 1 And index >= 0) Then
            If (BoNavegar) Then
                With dgjBusqueda
                    Me.tbCodigo.Text = .GetValue("caanumi").ToString
                    Me.dtiFechaCompra.Value = .GetValue("caafdoc")
                    Me.tbCodProveedor.Text = .GetValue("caaprov").ToString
                    Me.tbProveedor.Text = .GetValue("nprov").ToString
                    Me.tbNroFactura.Text = .GetValue("caanfac").ToString
                    Me.tbObs.Text = .GetValue("caaobs").ToString
                    Me.tbNitProv.Text = .GetValue("cmnit").ToString
                    Me.swTipoVenta.Value = .GetValue("caatven")
                    Me.tbFechaVenc.Value = .GetValue("caafvcred").ToString
                    Me.swEmision.Value = .GetValue("caaemision")
                    Me.swConsigna.Value = .GetValue("caaconsigna")
                    Me.dtiFfactura.Value = .GetValue("caaffactura")
                    Me.tbDescuentoPro1.Value = .GetValue("caadescpro1")
                    Me.tvDescuento02.Value = .GetValue("caadescpro2")


                    'If (IsDBNull(.GetValue("asiento"))) Then
                    '    Asiento = ""
                    'Else
                    '    Asiento = .GetValue("asiento")
                    'End If


                    'Aqui se coloca los datos de la grilla de los Equipos
                    P_prArmarGrillaDetalle(tbCodigo.Text)

                    MLbFecha.Text = CType(.GetValue("caafact").ToString, Date).ToString("dd/MM/yyyy")
                    MLbHora.Text = .GetValue("caahact").ToString
                    MLbUsuario.Text = .GetValue("caauact").ToString
                End With

                tbMdesc.Value = dgjBusqueda.GetValue("caadesc")
                _prCalcularPrecioTotal()
                If swEmision.Value = True Then
                    _prCargarFacturacion(tbCodigo.Text)
                End If

                P_prActualizarPaginacion(dgjBusqueda.Row)

                If (Not boModif And boAdd) Then
                    If (Now.Date = Me.dtiFechaCompra.Value) Then
                        MBtModificar.Visible = True
                    Else
                        MBtModificar.Visible = False
                    End If
                End If
            End If
        Else
            If (dgjBusqueda.GetRows.Count > 0) Then
                P_prMoverIndexActual()
            End If
        End If
    End Sub
    Private Sub _prCargarFacturacion(_numi As String)
        Dim dtC As New DataTable
        dtC = L_prCompraComprobanteGeneralPorNumi(_numi)

        If dtC.Rows.Count = 0 Then
            tbNAutorizacion.Text = ""
            tbCodControl.Text = ""
            tbNDui.Text = ""
            tbSACF.Text = ""
        Else
            tbNAutorizacion.Text = dtC.Rows(0).Item("fcaautoriz")
            tbCodControl.Text = dtC.Rows(0).Item("fcaccont")
            tbNDui.Text = dtC.Rows(0).Item("fcandui")
            tbSACF.Text = tbtotal.Text - dtC.Rows(0).Item("fcanscf")
        End If

    End Sub

    Private Sub P_prNuevoRegistro()
        P_prLimpiar()
        P_prEstadoNueModEli(1)
        P_prHDComponentes(BoNuevo)
        P_prAddFilaDetalle()
        dtiFechaCompra.Select()
    End Sub

    Private Sub P_prModificarRegistro()
        'Verifica si ya se contabilizó la compra
        Dim contabilizo As Boolean = L_fnVerificarSiSeContabilizo(tbCodigo.Text)
        If contabilizo Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra ya fue contabilizada, si usted la modifica deberá hacer el ajuste del asiento contable manualmente".ToUpper, img, 5100, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

        P_prEstadoNueModEli(2)
        P_prHDComponentes(BoModificar)
        P_prAddFilaDetalle()
        dtiFechaCompra.Select()
    End Sub

    Private Sub P_prEliminarRegistro()
        'Verifica Pagos de la compra
        If (swTipoVenta.Value = False) Then
            Dim res1 As Boolean = L_fnVerificarPagosCompras(tbCodigo.Text)
            If res1 Then
                Dim img As Bitmap = New Bitmap(My.Resources.WARNING, 50, 50)
                ToastNotification.Show(Me, "No se puede eliminar la Compra con código ".ToUpper + tbCodigo.Text + ", porque tiene pagos realizados, por favor primero elimine los pagos correspondientes a esta compra".ToUpper,
                                          img, 5000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                Exit Sub
            End If
        End If

        'Verifica si ya se contabilizó la compra
        Dim contabilizo As Boolean = L_fnVerificarSiSeContabilizo(tbCodigo.Text)
        If contabilizo Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Esta Compra ya fue contabilizada, si usted la elimina deberá hacer el ajuste del asiento contable manualmente".ToUpper, img, 5000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If


        Dim numi As String = tbCodigo.Text 'Valor del código único
        Dim info As New TaskDialogInfo("¿esta seguro de eliminar el registro?".ToUpper,
                                       eTaskDialogIcon.Delete, "advertencia".ToUpper,
                                       "Esta a punto de eliminar la compra con".ToUpper _
                                       + vbCrLf + "código -> ".ToUpper _
                                       + numi + " " + vbCrLf + "Desea continuar?".ToUpper,
                                       eTaskDialogButton.Yes Or eTaskDialogButton.Cancel,
                                       eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim resEliminar As Boolean = L_fnbValidarEliminacion(numi, "TCA001", "caanumi", mensajeError)
            If (resEliminar) Then
                Dim res As Boolean = L_fnCompraEliminar(numi) 'Medoto de lógica para eliminar
                If (res) Then
                    ToastNotification.Show(Me, "Codigo de compra: ".ToUpper + numi + " eliminado con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA, InDuracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                    BoNavegar = False
                    P_prArmarGrillaBusqueda()
                    BoNavegar = True
                    P_prMoverIndexActual()
                Else
                    ToastNotification.Show(Me, "No se pudo eliminar la compra con código: ".ToUpper + numi + ", intente nuevamente.".ToUpper,
                                           My.Resources.WARNING, InDuracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
                End If
            Else
                ToastNotification.Show(Me, mensajeError.ToUpper,
                                           My.Resources.I64x64_error, InDuracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub P_prGrabarRegistro()
        Dim numi As String
        Dim fdoc As String
        Dim prov As String
        Dim nfac As String
        Dim obs As String
        Dim tven As String
        Dim fvcred As String
        Dim mon As String
        Dim desc As Double
        Dim descpro1 As Double
        Dim descpro2 As Double
        Dim desctot As Double
        Dim total As Double
        Dim emision As String
        Dim consigna As String
        Dim retencion As String
        Dim asiento As String
        Dim ffactura As String


        If (BoNuevo) Then
            If (P_fnValidarGrabacion()) Then

                numi = tbCodigo.Text.Trim
                fdoc = dtiFechaCompra.Value.ToString("yyyy/MM/dd")
                prov = tbCodProveedor.Text.Trim
                nfac = IIf(tbNroFactura.Text.Trim = String.Empty, "0", tbNroFactura.Text.Trim)
                obs = tbObs.Text.Trim
                tven = IIf(swTipoVenta.Value = True, 1, 0)
                fvcred = IIf(swTipoVenta.Value = True, Now.Date.ToString("yyyy/MM/dd"), tbFechaVenc.Value.ToString("yyyy/MM/dd"))
                mon = 1
                desc = tbMdesc.Value
                descpro1 = tbDescuentoPro1.Value
                descpro2 = tvDescuento02.Value
                desctot = desc + descpro1 + descpro2
                total = tbtotal.Value
                emision = IIf(swEmision.Value = True, 1, 0)
                consigna = IIf(swConsigna.Value = True, 1, 0)
                retencion = IIf(swRetencion.Value = True, 1, 0)
                asiento = IIf(swAsiento.Value = True, 1, 0)
                ffactura = dtiFfactura.Value.ToString("yyyy/MM/dd")

                dtiFechaCompra.Select()

                Dim dt As DataTable = CType(dgjDetalle.DataSource, DataTable).DefaultView.ToTable(False, "cabnumi", "cabtc1numi", "cabcantcj", "cabcantun", "cabsubtot", "cabpcomcj", "cabpcomun", "cabporc", "cabdesccj", "cabdescun", "cabdescpro1cj", "cabdescpro1un", "cabdescpro2cj", "cabdescpro2un", "cabtot", "cabpcostocj", "cabpcostoun", "cabputi", "cabpven", "cabnfr", "cabstocka", "cabstockf", "cabtca1numi", "estado")

                RecuperarDatosTFC001()  'Recupera datos para grabar en la BDDiconCF en la Tabla TFC001
                If ValidarDescuentos() = False Then
                    Exit Sub
                End If
                'Grabar
                Dim res As Boolean = L_fnCompraGrabar(numi, fdoc, prov, nfac, obs, dt, tven, fvcred, mon, desc, descpro1, descpro2, desctot, total, emision, consigna, retencion, asiento, ffactura, _detalleCompras)


                If (res) Then
                    '_prCargarTablaComprobantes()
                    P_prLimpiar()
                    BoNavegar = False
                    P_prArmarGrillaBusqueda()
                    BoNavegar = True

                    dtiFechaCompra.Select()
                    ToastNotification.Show(Me, "Codigo de compra ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       InDuracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                Else
                    ToastNotification.Show(Me, "No se pudo grabar el codigo de compra ".ToUpper + tbCodigo.Text + ", intente nuevamente.".ToUpper,
                                       My.Resources.WARNING,
                                       InDuracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
                End If
            End If
        ElseIf (BoModificar) Then
            If (P_fnValidarGrabacion()) Then
                numi = tbCodigo.Text.Trim
                fdoc = dtiFechaCompra.Value.ToString("yyyy/MM/dd")
                prov = tbCodProveedor.Text.Trim
                nfac = IIf(tbNroFactura.Text.Trim = String.Empty, "0", tbNroFactura.Text.Trim)
                obs = tbObs.Text.Trim
                tven = IIf(swTipoVenta.Value = True, 1, 0)
                fvcred = IIf(swTipoVenta.Value = True, Now.Date.ToString("yyyy/MM/dd"), tbFechaVenc.Value.ToString("yyyy/MM/dd"))
                mon = 1
                desc = tbMdesc.Value
                descpro1 = tbDescuentoPro1.Value
                descpro2 = tvDescuento02.Value
                desctot = desc + descpro1 + descpro2
                total = tbtotal.Value
                emision = IIf(swEmision.Value = True, 1, 0)
                consigna = IIf(swConsigna.Value = True, 1, 0)
                retencion = IIf(swRetencion.Value = True, 1, 0)
                asiento = IIf(swAsiento.Value = True, 1, 0)
                ffactura = dtiFfactura.Value.ToString("yyyy/MM/dd")

                dtiFechaCompra.Select()

                'Dim dt As DataTable = CType(dgjDetalle.DataSource, DataTable).DefaultView.ToTable(False, "cabnumi", "cabtc1numi", "cabcant", "cabpcom", "cabputi", "cabpven", "cabnfr", "cabstocka", "cabstockf", "cabtca1numi", "estado")
                Dim dt As DataTable = CType(dgjDetalle.DataSource, DataTable).DefaultView.ToTable(False, "cabnumi", "cabtc1numi", "cabcantcj", "cabcantun", "cabsubtot", "cabpcomcj", "cabpcomun", "cabporc", "cabdesccj", "cabdescun", "cabdescpro1cj", "cabdescpro1un", "cabdescpro2cj", "cabdescpro2un", "cabtot", "cabpcostocj", "cabpcostoun", "cabputi", "cabpven", "cabnfr", "cabstocka", "cabstockf", "cabtca1numi", "estado")

                RecuperarDatosTFC001()  'Recupera datos para grabar en la BDDiconCF en la Tabla TFC001
                'Grabar
                Dim res As Boolean = L_fnCompraModificar(numi, fdoc, prov, nfac, obs, dt, tven, fvcred, mon, desc, descpro1, descpro2, desctot, total, emision, consigna, retencion, asiento, ffactura, _detalleCompras)

                If (res) Then

                    BoNavegar = False
                    P_prArmarGrillaBusqueda()
                    BoNavegar = True

                    P_prMoverIndexActual()

                    dtiFechaCompra.Select()
                    MBtSalir.PerformClick()

                    ToastNotification.Show(Me, "Codigo de compra ".ToUpper + tbCodigo.Text + " Modificado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       InDuracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                Else
                    ToastNotification.Show(Me, "No se pudo modificar el codigo de compra ".ToUpper + tbCodigo.Text + ", intente nuevamente.".ToUpper,
                                       My.Resources.WARNING,
                                       InDuracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
                End If
            End If
        End If
    End Sub

    Public Sub RecuperarDatosTFC001()
        _detalleCompras = L_prCompraComprobanteGeneralPorNumi(-1)
        '_ValidarDatosFacturacion()
        Dim ffec As String
        Dim fnit As String
        Dim frsocial As String
        Dim fnro As String
        Dim fndui As String
        Dim fautoriz As String
        Dim fmonto As String
        Dim fccont As String
        Dim sujetoCreditoFiscal As String
        Dim nosujetoCreditoFiscal As String
        Dim subTotal As String
        Dim fdesc As String
        Dim importeBaseCreditoFiscal As String
        Dim creditoFiscal As String

        If swEmision.Value = True Then
            ffec = dtiFechaCompra.Value.ToString("yyyy/MM/dd")
            fnit = tbNitProv.Text
            frsocial = tbProveedor.Text
            fnro = tbNroFactura.Text
            If tbNDui.Text = String.Empty Then
                tbNDui.Text = 0
            End If
            fndui = tbNDui.Text

            fautoriz = tbNAutorizacion.Text
            fmonto = tbtotal.Value.ToString + tbMdesc.Value + tbDescuentoPro1.Value + tvDescuento02.Value
            sujetoCreditoFiscal = tbSACF.Text
            nosujetoCreditoFiscal = tbtotal.Value.ToString - sujetoCreditoFiscal
            subTotal = fmonto - nosujetoCreditoFiscal
            fdesc = tbMdesc.Value + tbDescuentoPro1.Value + tvDescuento02.Value
            'tbImporteBaseCreditoFiscal.Value = TbSubTotal.Value - TbdDescuento.Value
            importeBaseCreditoFiscal = fmonto - fdesc
            creditoFiscal = importeBaseCreditoFiscal * 0.13
            fccont = tbCodControl.Text
            Dim numi As String = ""

            _detalleCompras.Rows.Add(1, ffec, fnit, frsocial, fnro, fndui, fautoriz, fmonto, nosujetoCreditoFiscal, subTotal, fdesc, importeBaseCreditoFiscal, creditoFiscal, fccont, 1, 0, 0)

        Else
            ffec = dtiFechaCompra.Value.ToString("yyyy/MM/dd")
            fnit = tbNitProv.Text
            frsocial = tbProveedor.Text
            fnro = tbNroFactura.Text
            fndui = 0
            fautoriz = 0
            fmonto = tbtotal.Value.ToString
            sujetoCreditoFiscal = tbSACF.Text
            nosujetoCreditoFiscal = 0
            subTotal = fmonto
            fdesc = tbMdesc.Value.ToString
            importeBaseCreditoFiscal = fmonto - fdesc
            creditoFiscal = 0
            fccont = 0
            Dim numi As String = ""

            _detalleCompras.Rows.Add(1, ffec, fnit, frsocial, fnro, fndui, fautoriz, fmonto, nosujetoCreditoFiscal, subTotal, fdesc, importeBaseCreditoFiscal, creditoFiscal, fccont, 1, 0, 0)

        End If

    End Sub
    Private Sub P_prCancelarRegistro()
        If (Not MBtGrabar.Enabled) Then
            Me.Close()
            If (gb_ConexionAbierta) Then
                _modulo.Select()
                '_tab.Close()
            End If
        Else
            P_prLimpiar()
            P_prHDComponentes(False)
            P_prLlenarDatos(dgjBusqueda.Row)
        End If
        P_prEstadoNueModEli(4)
    End Sub

    Private Sub P_prEstadoNueModEli(value As Integer)
        BoNuevo = (value = 1)
        BoModificar = (value = 2)
        BoEliminar = (value = 3)

        MBtNuevo.Enabled = (value = 4)
        MBtModificar.Enabled = (value = 4)
        MBtEliminar.Enabled = (value = 4)
        MBtGrabar.Enabled = Not (value = 4)

        If (value = 4) Then
            MBtSalir.Tooltip = "SALIR"
            MBtSalir.Text = "SALIR"
        Else
            MBtSalir.Tooltip = "CANCELAR"
            MBtSalir.Text = "CANCELAR"
        End If

        MBtPrimero.Enabled = (value = 4)
        MBtAnterior.Enabled = (value = 4)
        MBtSiguiente.Enabled = (value = 4)
        MBtUltimo.Enabled = (value = 4)
        MSuperTabItemBusqueda.Visible = (value = 4)

        tsmiEliminarFilaDetalle.Visible = Not (value = 4)

        MBtGrabar.Tooltip = IIf(value = 1, "GRABAR NUEVO REGISTRO", IIf(value = 2, "GRABAR MODIFICACIÓN DE REGISTRO", "GRABAR"))
        MRlAccion.Text = IIf(value = 1, "NUEVO", IIf(value = 2, "MODIFICAR", ""))

        'Compentes

        If (MSuperTabControlPrincipal.SelectedTabIndex = 1) Then
            MSuperTabControlPrincipal.SelectedTabIndex = 0
        End If

    End Sub

    Private Sub P_prCargarImagen(pbimg As PictureBox)
        'OfdProducto.InitialDirectory = "C:\Users\" + Environment.UserName + "\Pictures"
        'OfdProducto.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.bmp"
        'OfdProducto.FilterIndex = 1
        'If (OfdProducto.ShowDialog() = DialogResult.OK) Then
        '    vlImagen = New CImagen(OfdProducto.SafeFileName, OfdProducto.FileName, 0)
        '    pbimg.SizeMode = PictureBoxSizeMode.StretchImage
        '    pbimg.Load(vlImagen.getImagen())
        'End If
    End Sub

    Private Function P_fnObtenerID() As String
        Dim res As String = ""
        res = res + Now.Hour.ToString("00") + Now.Minute.ToString("00") + Now.Second.ToString("00") + "_" _
            + Now.Day.ToString("00") + Now.Month.ToString("00") + Now.Year.ToString("0000")
        Return res
    End Function

    Private Sub P_prEliminarArchivosSinReferencia(dt As DataTable, col As String, ruta As String)
        'Try
        '    For Each foundFile As String In My.Computer.FileSystem.GetFiles(ruta)
        '        Dim split As String() = foundFile.Split("\")
        '        Dim nomImg As String = split(split.Length - 1)
        '        Dim array As DataRow() = dt.Select(col + "='" + nomImg + "'")
        '        If (array.Length = 0) Then
        '            My.Computer.FileSystem.DeleteFile(ruta + "\" + nomImg, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        '        End If
        '    Next
        'Catch ex As Exception

        'End Try
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
#Region "Metodos y funciones generales"

    Private Sub P_prValidarCarpetaImagenes()
        Dim rutaDestino As String = StRutaDocumentos
        If (System.IO.Directory.Exists(rutaDestino) = False) Then
            System.IO.Directory.CreateDirectory(rutaDestino)
        End If
    End Sub

    Private Sub P_prArmarGrillaBusqueda()
        DtBusqueda = New DataTable
        DtBusqueda = L_fnCompraGeneral()

        dgjBusqueda.BoundMode = Janus.Data.BoundMode.Bound
        dgjBusqueda.DataSource = DtBusqueda
        dgjBusqueda.RetrieveStructure()

        'dar formato a las columnas
        With dgjBusqueda.RootTable.Columns("caanumi")
            .Caption = "Código"
            .Width = 80
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("caafdoc")
            .Caption = "Fecha"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("caaprov")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("asiento")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("nprov")
            .Caption = "Proveedor"
            .Width = 200
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns("cmnit")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caanfac")
            .Caption = "Nro Factura"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("caaobs")
            .Caption = "Observación"
            .Width = 300
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns("caafact")
            .Visible = False
        End With

        With dgjBusqueda.RootTable.Columns("caahact")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caauact")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caatven")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caafvcred")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caamon")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caaest")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caadesc")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caadescpro1")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caadescpro2")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caadesctot")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caatotal")
            .Caption = "Total"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
        End With
        With dgjBusqueda.RootTable.Columns("caaemision")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caaconsigna")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("caaasientoi")
            .Visible = False
        End With
        With dgjBusqueda.RootTable.Columns("asiento")
            .Caption = "Id Asiento"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With dgjBusqueda.RootTable.Columns("caaffactura")
            .Visible = False
        End With
        'Habilitar Filtradores
        With dgjBusqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
            .RecordNavigator = True
        End With
    End Sub

    Private Sub P_prArmarGrillaDetalle(numi As String)
        DtDetalle = New DataTable
        DtDetalle = L_fnCompraDetalle(numi)

        dgjDetalle.BoundMode = Janus.Data.BoundMode.Bound
        dgjDetalle.DataSource = DtDetalle
        dgjDetalle.RetrieveStructure()

        'dar formato a las columnas
        With dgjDetalle.RootTable.Columns("cabnumi")
            .Visible = False
        End With

        With dgjDetalle.RootTable.Columns("cabtc1numi")
            .Caption = "Cod. Producto"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjDetalle.RootTable.Columns("cacod")
            .Caption = "Codigo Flex"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjDetalle.RootTable.Columns("ntc1numi")
            .Caption = "Descripción Producto"
            .Width = 350
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjDetalle.RootTable.Columns("cabcantcj")
            .Caption = "Cant. Cj."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .CellStyle.BackColor = Color.SteelBlue
            .FormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabcantun")
            .Caption = "Cant. Un."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .CellStyle.BackColor = Color.SteelBlue
            .FormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabsubtot")
            .Caption = "Importe Bruto"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .CellStyle.BackColor = Color.SteelBlue
            .FormatString = "0.00"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabpcomcj")
            .Caption = "Precio Cj."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabpcomun")
            .Caption = "Precio Un."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabporc")
            .Caption = "Desc. (%)"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabdescun")
            .Caption = "Desc. Un."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabdesccj")
            .Caption = "Desc. Cj."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .CellStyle.BackColor = Color.SteelBlue
            .FormatString = "0.00"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabdescpro1cj")
            .Caption = "Desc. Pro1"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = gs_Parametros(0).Item("sycompradescpr1")
            .CellStyle.BackColor = Color.Turquoise
            .FormatString = "0.0000"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabdescpro1un")
            .Caption = "Desc. Pro1 Un."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = gs_Parametros(0).Item("sycompradescpr1")
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.0000"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabdescpro2cj")
            .Caption = "Desc. Pro2"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = gs_Parametros(0).Item("sycompradescpr2")
            .CellStyle.BackColor = Color.Turquoise
            .FormatString = "0.0000"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabdescpro2un")
            .Caption = "Desc. Pro2 Un."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = gs_Parametros(0).Item("sycompradescpr2")
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.0000"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabtot")
            .Caption = "Importe"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabpcostocj")
            .Caption = "P. Costo Cj."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.0000"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabpcostoun")
            .Caption = "P. Costo Un."
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtTitulo
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.0000"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.0000"
        End With
        With dgjDetalle.RootTable.Columns("cabputi")
            .Caption = "% Utilidad"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabpven")
            .Caption = "Precio Venta"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjDetalle.RootTable.Columns("cabnfr")
            .Caption = "Nro. Factura/Recibo"
            .Width = 120
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0"
        End With

        With dgjDetalle.RootTable.Columns("cabstocka")
            .Caption = "Stock Actual"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjDetalle.RootTable.Columns("cabstockf")
            .Caption = "Stock Final"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("cabtca1numi")
            .Visible = False
        End With
        With dgjDetalle.RootTable.Columns("total")
            .Caption = "Total"
            .Width = 100
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
            .AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
            .TotalFormatString = "0.00"
        End With
        With dgjDetalle.RootTable.Columns("estado")
            .Visible = False
        End With

        'Habilitar Filtradores
        With dgjDetalle
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
            .RecordNavigator = True
            .TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
            .TotalRowPosition = TotalRowPosition.BottomFixed
            .TotalRowFormatStyle.BackColor = Color.Yellow

        End With
    End Sub

    Private Function P_fnValidarGrabacion() As Boolean
        Dim sms As String = ""

        If (Not IsDate(dtiFechaCompra.Value)) Then
            sms = "elija una fecha de compra valida."
        End If

        If (tbProveedor.Text.Trim = String.Empty) Then
            If (sms = String.Empty) Then
                sms = "el proveedor no puede quedar vacio."
            Else
                sms = sms + vbCrLf + "el proveedor no puede quedar vacio."
            End If
        End If
        If swEmision.Value = True Then
            If (tbNroFactura.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "Debe llenar el número de factura."
                Else
                    sms = sms + vbCrLf + "Debe llenar el número de factura."
                End If
                tbNroFactura.Focus()
            End If
            If (tbNAutorizacion.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "Debe llenar el número de autorización."
                Else
                    sms = sms + vbCrLf + "Debe llenar el número de autorización."
                End If
                tbNAutorizacion.Focus()
            End If
            If (tbCodControl.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "Debe llenar el código de control."
                Else
                    sms = sms + vbCrLf + "Debe llenar el código de control."
                End If
                tbCodControl.Focus()
            End If
        Else
            If (tbNroFactura.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "Debe llenar el número de recibo."
                Else
                    sms = sms + vbCrLf + "Debe llenar el número de recibo."
                End If
                tbNroFactura.Focus()
            End If
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   sms.ToUpper,
                                   My.Resources.INFORMATION,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If


        Return (sms = String.Empty)
    End Function

    Private Sub P_prArmarAyudaProveedor()
        Dim frmAyuda As Modelo.ModeloAyuda
        Dim dt As DataTable = L_fnObtenerTabla("cmnumi, cmdesc, cmnit", "TC010", "cmest=1")
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("cmnumi", True, "Código", 70))
        listEstCeldas.Add(New Modelo.MCelda("cmdesc", True, "Proveedor", 280))
        listEstCeldas.Add(New Modelo.MCelda("cmnit", False, "Proveedor", 100))

        frmAyuda = New Modelo.ModeloAyuda(300, 360, dt, "Seleccionar proveedor".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("cmnumi").Value
            Dim desc As String = frmAyuda.filaSelect.Cells("cmdesc").Value
            Dim nit As String = frmAyuda.filaSelect.Cells("cmnit").Value
            tbCodProveedor.Text = id
            tbProveedor.Text = desc
            tbNitProv.Text = nit
        End If
    End Sub

    Private Sub P_prArmarAyudaProducto()
        Dim frmAyuda As Modelo.ModeloAyuda

        'Dim dt As DataTable = L_ProductosGeneral(1, "caest=1 and caserie=0").Tables(0)
        Dim dt As DataTable = L_ProductosGeneral(1, "caest=1 and caserie=0 and cagr1= " + tbCodProveedor.Text + " ").Tables(0)

        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("canumi", True, "Código", 80))
        listEstCeldas.Add(New Modelo.MCelda("cacod", True, "Cod Flex", 100))
        listEstCeldas.Add(New Modelo.MCelda("cadesc", True, "Producto", 300))
        listEstCeldas.Add(New Modelo.MCelda("cadesc2", True, "Desc", 150))
        listEstCeldas.Add(New Modelo.MCelda("caconv", True, "Conversion", 150))

        frmAyuda = New Modelo.ModeloAyuda(600, 540, dt, "Seleccione Producto".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("canumi").Value
            Dim cod As String = frmAyuda.filaSelect.Cells("cacod").Value
            Dim desc As String = frmAyuda.filaSelect.Cells("cadesc").Value
            conv = frmAyuda.filaSelect.Cells("caconv").Value


            dgjDetalle.Col = dgjDetalle.RootTable.Columns("cabcantcj").Index
            dgjDetalle.SetValue(1, id)
            dgjDetalle.SetValue(2, cod)
            dgjDetalle.SetValue(3, desc)
            '_prCalcularPrecioTotal()
        End If
    End Sub

    Private Sub P_prAddFilaDetalle()
        Dim f As DataRow
        f = DtDetalle.NewRow

        f.Item("cabnumi") = DtDetalle.Rows.Count + 1
        f.Item("cabtc1numi") = 0
        f.Item("ntc1numi") = ""
        f.Item("cabcantcj") = 0
        f.Item("cabcantun") = 0
        f.Item("cabsubtot") = 0
        f.Item("cabpcomcj") = 0
        f.Item("cabpcomun") = 0
        f.Item("cabporc") = 0
        f.Item("cabdesccj") = 0
        f.Item("cabdescun") = 0
        f.Item("cabdescpro1cj") = 0
        f.Item("cabdescpro1un") = 0
        f.Item("cabdescpro2cj") = 0
        f.Item("cabdescpro2un") = 0
        f.Item("cabtot") = 0
        f.Item("cabpcostocj") = 0
        f.Item("cabpcostoun") = 0
        f.Item("cabputi") = 0
        f.Item("cabpven") = 0
        f.Item("cabnfr") = "0"
        f.Item("cabstocka") = 0
        f.Item("cabstockf") = 0
        f.Item("cabtca1numi") = 0
        f.Item("total") = 0
        f.Item("estado") = 0

        DtDetalle.Rows.Add(f)
    End Sub

    Private Sub tbNroFactura_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles tbNroFactura.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub tbNAutorizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNAutorizacion.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub tbNDui_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNDui.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub tbSACF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSACF.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub swEmision_ValueChanged(sender As Object, e As EventArgs) Handles swEmision.ValueChanged
        If swEmision.Visible = False Then
            Exit Sub
        End If
        If swEmision.Value = False Then
            lbNFactura.Text = "Nro. Recibo:"
            GroupPanelFactura2.Text = "DATOS RECIBO"
            lbNAutoriz.Visible = False
            tbNAutorizacion.Visible = False
            lbCodCtrl.Visible = False
            tbCodControl.Visible = False
            lbNDui.Visible = False
            tbNDui.Visible = False
            lbSACF.Visible = False
            tbSACF.Visible = False
        Else
            lbNFactura.Text = "Nro. Factura:"
            GroupPanelFactura2.Text = "DATOS FACTURACIÓN"
            lbNAutoriz.Visible = True
            tbNAutorizacion.Visible = True
            lbCodCtrl.Visible = True
            tbCodControl.Visible = True
            lbNDui.Visible = True
            tbNDui.Visible = True
            lbSACF.Visible = True
            tbSACF.Visible = True

        End If
    End Sub


    Private Sub swTipoVenta_ValueChanged(sender As Object, e As EventArgs) Handles swTipoVenta.ValueChanged
        If swTipoVenta.Visible = False Then
            Exit Sub
        End If

        If (swTipoVenta.Value = False) Then
            lbCredito.Visible = True
            tbFechaVenc.Visible = True
            tbFechaVenc.Value = Now.Date
        Else
            lbCredito.Visible = False
            tbFechaVenc.Visible = False
        End If
    End Sub

    Private Sub tbtotal_ValueChanged(sender As Object, e As EventArgs) Handles tbtotal.ValueChanged
        tbSACF.Text = tbtotal.Text
    End Sub

    Private Sub dgjDetalle_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles dgjDetalle.CellValueChanged
        Dim codprod As Integer
        If (BoModificar Or BoNuevo) Then
            If ((e.Column.Key.Equals("cabcantcj")) Or (e.Column.Key.Equals("cabcantun")) Or (e.Column.Key.Equals("cabsubtot"))) Then
                Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, lin)

                'Obtener la conversion del producto
                codprod = dgjDetalle.GetValue("cabtc1numi")
                Dim dtconv As New DataTable
                dtconv = L_fnConversionProd(codprod)
                conv = dtconv.Rows(0).Item("caconv")

                If (Not IsNumeric(dgjDetalle.GetValue("cabcantcj")) Or dgjDetalle.GetValue("cabcantcj").ToString = String.Empty) Then
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabcantcj") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabcantcj")
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot")

                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro1cj") = 0
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro1un") = 0
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro2cj") = 0
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro2un") = 0

                Else
                    If (e.Column.Key.Equals("cabcantcj")) Then
                        dgjDetalle.SetValue("cabcantun", dgjDetalle.GetValue("cabcantcj") * conv)
                        dgjDetalle.SetValue("cabpcomcj", dgjDetalle.GetValue("cabsubtot") / dgjDetalle.GetValue("cabcantcj"))
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabcantcj") = dgjDetalle.GetValue("cabcantcj")
                        Dim descuento As Double = tbDescuentoPro1.Value
                        Dim TotalBruto As Double = tbSubtotalC.Value
                        CalcularDescuento01(TotalBruto, descuento)
                        CalcularDescuento02(TotalBruto, tvDescuento02.Value)
                    End If
                End If
                If (Not IsNumeric(dgjDetalle.GetValue("cabcantun")) Or dgjDetalle.GetValue("cabcantun").ToString = String.Empty) Then
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabcantun") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabcantun")
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot")
                Else
                    If (e.Column.Key.Equals("cabcantun")) Then
                        dgjDetalle.SetValue("cabcantcj", dgjDetalle.GetValue("cabcantun") / conv)
                        dgjDetalle.SetValue("cabpcomcj", dgjDetalle.GetValue("cabsubtot") / dgjDetalle.GetValue("cabcantcj"))
                    End If
                End If

                If (e.Column.Key.Equals("cabsubtot")) Then
                    If (Not IsNumeric(dgjDetalle.GetValue("cabsubtot")) Or dgjDetalle.GetValue("cabsubtot").ToString = String.Empty) Then
                        'Dim cantidad As Double = dgjDetalle.GetValue("cabcantcj")
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcomcj") = 0 ' CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcomcj")
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcomun") = 0
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = 0

                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro1cj") = 0
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro1un") = 0
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro2cj") = 0
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescpro2un") = 0
                    Else
                        dgjDetalle.SetValue("cabpcomcj", dgjDetalle.GetValue("cabsubtot") / dgjDetalle.GetValue("cabcantcj"))

                        Dim unid As Double = (dgjDetalle.GetValue("cabcantun") / dgjDetalle.GetValue("cabcantcj"))
                        dgjDetalle.SetValue("cabpcomun", dgjDetalle.GetValue("cabpcomcj") / unid)

                        'Dim porcdesc As Double = dgjDetalle.GetValue("cabporc")
                        'Dim montodesc As Double = ((dgjDetalle.GetValue("cabpcom") * dgjDetalle.GetValue("cabcant")) * (porcdesc / 100))
                        Dim montodesc As Double = dgjDetalle.GetValue("cabdesccj")


                        Dim totalF As Double = dgjDetalle.GetValue("cabsubtot") - montodesc
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = totalF
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = dgjDetalle.GetValue("cabsubtot")
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdesccj") = montodesc

                        'CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcostocj") = (CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") * 0.87) / dgjDetalle.GetValue("cabcantcj")
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcostocj") = (CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot")) / dgjDetalle.GetValue("cabcantcj")

                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcostoun") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcostocj") / conv

                        _prCalcularPrecioTotal()

                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = dgjDetalle.GetValue("cabsubtot")
                        Dim descuento As Double = tbDescuentoPro1.Value
                        Dim TotalBruto As Double = tbSubtotalC.Value
                        CalcularDescuento01(TotalBruto, descuento)
                        CalcularDescuento02(TotalBruto, tvDescuento02.Value)
                    End If

                    If (dgjDetalle.GetValue("cabtca1numi") <> 0) Then
                        dgjDetalle.SetValue("estado", 2)
                    End If
                End If
            End If


            ''''''''''''''''''''''PORCENTAJE DE DESCUENTO '''''''''''''''''''''
            'If (e.Column.Index = dgjDetalle.RootTable.Columns("cabporc").Index) Then
            '    If (Not IsNumeric(dgjDetalle.GetValue("cabporc")) Or dgjDetalle.GetValue("cabporc").ToString = String.Empty) Then
            '        Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
            '        Dim pos As Integer = -1
            '        _fnObtenerFilaDetalle(pos, lin)
            '        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabporc") = 0
            '        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdesccj") = 0
            '        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
            '    Else
            '        If (dgjDetalle.GetValue("cabporc") > 0 And dgjDetalle.GetValue("cabporc") <= 100) Then

            '            Dim porcdesc As Double = dgjDetalle.GetValue("cabporc")
            '            Dim montodesc As Double = (dgjDetalle.GetValue("cabsubtot") * (porcdesc / 100))
            '            Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
            '            Dim pos As Integer = -1
            '            _fnObtenerFilaDetalle(pos, lin)
            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdesc") = montodesc


            '            Dim totalF As Double = dgjDetalle.GetValue("cabsubtot") - montodesc

            '            dgjDetalle.SetValue("cabdesc", montodesc)
            '            dgjDetalle.SetValue("cabtot", totalF)
            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = totalF
            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = dgjDetalle.GetValue("cabsubtot")

            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabpcosto") = (CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") * 0.87) / dgjDetalle.GetValue("cabcant")

            '            'Dim total As Double = dgjDetalle.GetValue("total")
            '            'Dim total As Double = dgjDetalle.GetValue("cabtot")
            '            _prCalcularPrecioTotal()
            '            'tbSubtotalC.Text = tbSubtotalC.Value + total
            '            'tbtotal.Text = tbSubtotalC.Text
            '        Else
            '            Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
            '            Dim pos As Integer = -1
            '            _fnObtenerFilaDetalle(pos, lin)
            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabporc") = 0
            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdesc") = 0
            '            CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
            '            dgjDetalle.SetValue("cabporc", 0)
            '            dgjDetalle.SetValue("cabdesc", 0)
            '            dgjDetalle.SetValue("cabtot", dgjDetalle.GetValue("cabsubtot"))
            '            _prCalcularPrecioTotal()
            '        End If
            '    End If
            'End If

            '''''''''''''''''''''MONTO DE DESCUENTO '''''''''''''''''''''

            If (e.Column.Index = dgjDetalle.RootTable.Columns("cabdesccj").Index) Then
                If (Not IsNumeric(dgjDetalle.GetValue("cabdesccj")) Or dgjDetalle.GetValue("cabdesccj").ToString = String.Empty) Then
                    Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabporc") = 0
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescun") = 0
                    CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
                Else
                    If (dgjDetalle.GetValue("cabdesccj") >= 0) Then 'And dgjDetalle.GetValue("cabdesc") <= dgjDetalle.GetValue("cabsubtot")

                        Dim montodesc As Double = dgjDetalle.GetValue("cabdesccj")
                        Dim pordesc As Double = ((montodesc * 100) / dgjDetalle.GetValue("cabsubtot"))
                        Dim montodescun As Double = montodesc / dgjDetalle.GetValue("cabcantcj")


                        Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdesccj") = montodesc
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabporc") = pordesc
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdescun") = montodescun

                        dgjDetalle.SetValue("cabporc", pordesc)

                        Dim totalF As Double = dgjDetalle.GetValue("cabsubtot") - montodesc

                        dgjDetalle.SetValue("cabtot", totalF)
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = totalF
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot") = dgjDetalle.GetValue("cabsubtot")


                        _prCalcularPrecioTotal()



                        Dim descuento As Double = tbDescuentoPro1.Value
                        Dim TotalBruto As Double = tbSubtotalC.Value
                        CalcularDescuento01(TotalBruto, descuento)
                        CalcularDescuento02(TotalBruto, tvDescuento02.Value)

                    Else
                        Dim lin As Integer = dgjDetalle.GetValue("cabnumi")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabporc") = 0
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabdesccj") = 0
                        CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabtot") = CType(dgjDetalle.DataSource, DataTable).Rows(pos).Item("cabsubtot")
                        dgjDetalle.SetValue("cabporc", 0)
                        dgjDetalle.SetValue("cabdesccj", 0)
                        dgjDetalle.SetValue("cabtot", dgjDetalle.GetValue("cabsubtot"))
                        _prCalcularPrecioTotal()

                    End If
                End If
            End If

        End If
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(dgjDetalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabnumi")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Private Sub tbMdesc_ValueChanged(sender As Object, e As EventArgs) Handles tbMdesc.ValueChanged
        If (tbMdesc.Focused) Then

            Dim total As Double = tbtotal.Value
            If (Not tbMdesc.Text = String.Empty) Then
                If (tbMdesc.Value = 0 Or tbMdesc.Value > total) Then
                    tbMdesc.Value = 0
                    _prCalcularPrecioTotal()
                Else
                    Dim montodesc As Double = tbMdesc.Value
                    'tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabtot"), AggregateFunction.Sum) - montodesc
                    tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabsubtot"), AggregateFunction.Sum) - montodesc
                End If

            End If

            If (tbMdesc.Text = String.Empty) Then
                tbMdesc.Value = 0
            End If
        End If

    End Sub


#End Region

#Region "Asiento Contable"
    Private Sub _prCargarTablaComprobantes()

        Dim tipo As Integer
        Dim k As Integer
        Dim dt As New DataTable
        If (swEmision.Value = True) Then
            dt = L_prServicioListarCuentas(1, tbCodProveedor.Text)  ''Es Factura
        Else
            dt = L_prServicioListarCuentas(2, tbCodProveedor.Text)  ''esRecibo
        End If

        Dim tabla As DataTable = dt.Copy
        tabla.Rows.Clear()
        Dim BanderaCuentaPorCobrar As Boolean = False
        Dim TotalTransaccion As Double
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim dtDetalle As DataTable
            If (swEmision.Value = True) Then
                dtDetalle = L_prObtenerDetallePlantilla(dt.Rows(i).Item("canumi"), 1)
            Else
                dtDetalle = L_prObtenerDetallePlantilla(dt.Rows(i).Item("canumi"), 2)
            End If
            If (dtDetalle.Rows.Count = 0) Then

                tipo = 0
            Else

                tipo = dtDetalle.Rows(0).Item("tipo")
            End If


            TotalTransaccion = tbtotal.Value

            ''canumi , nro,cadesc ,chporcen,chdebe ,chhaber 
            Dim porcentaje As Double = dt.Rows(i).Item("chporcen")

            Dim numiCuenta As Integer = dt.Rows(i).Item("canumi")

            Dim numicuentaatc As Integer = 21 'ATC

            Dim total As Double = TotalTransaccion
            If (total > 0) Then
                Dim dtObtenerCuenta As DataTable = L_prCuentaDiferencia(numiCuenta)
                tabla.Rows.Add(dtObtenerCuenta.Rows(0).Item("canumi"), dtObtenerCuenta.Rows(0).Item("cacta"), dtObtenerCuenta.Rows(0).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, 1, 0) '''' Aqui agrego al padre
                tabla.ImportRow(dt.Rows(i))  '''Aqui agrego al hijo
                If (tipo = 0) Then

                    Dim Glosa As String = dt.Rows(i).Item("cadesc")
                    Dim conversion As Double = tbtotal.Value
                    conversion = to3Decimales(conversion)
                    Dim totales As Double = Round(conversion, 2)
                    Dim TotalSus As Double = Round(to3Decimales(totales / (6.96)), 2)
                    Linea = Linea + 1

                    If (dt.Rows(i).Item("chdebe") > 0) Then
                        tabla.Rows.Add(numiCuenta, DBNull.Value, tbProveedor.Text + " con Factura Nro #" + tbNroFactura.Text, DBNull.Value, DBNull.Value, DBNull.Value, 6.96, totales, DBNull.Value, TotalSus, DBNull.Value, 1, Linea)
                    Else
                        tabla.Rows.Add(numiCuenta, DBNull.Value, tbProveedor.Text + " con Factura Nro #" + tbNroFactura.Text, DBNull.Value, DBNull.Value, DBNull.Value, 6.96, DBNull.Value, totales, DBNull.Value, TotalSus, 1, Linea)
                    End If

                    dtTC009 = L_prListarProveedorCreditoParaTC009(tbCodigo.Text)
                    '''''''Relleno el numi de la cuenta en la TC009
                    For p As Integer = 0 To dtTC009.Rows.Count - 1 Step 1
                        dtTC009.Rows(p).Item("cjnumiTc001") = numiCuenta
                    Next
                    '''''''''''Insertamos a la TC009'''''''''''''''
                    Dim _dtTC009Inserted = L_prInsertarTC009(dtTC009)

                    ''''''''''''''''''
                    Dim IdTC009 As Integer = _fnBuscarIDTC009(tbCodProveedor.Text, _dtTC009Inserted)
                    dtTO00111.Rows.Add(0, Linea, IdTC009, 1)
                    '''''''''''''''''''''''''



                Else
                    Dim Glosa As String = dt.Rows(i).Item("cadesc")
                    Dim conversion As Double = (total * (porcentaje / 100))
                    conversion = to3Decimales(conversion)
                    Dim totales As Double = Round(conversion, 2)
                    Dim TotalSus As Double = Round(to3Decimales(totales / (6.96)), 2)
                    Linea = Linea + 1

                    If (dt.Rows(i).Item("chdebe") > 0) Then
                        tabla.Rows.Add(numiCuenta, DBNull.Value, Glosa + " DEL " + Now.Date.ToString("dd/MM/yyyy") + " AL " + Now.Date.ToString("dd/MM/yyyy"), DBNull.Value, DBNull.Value, DBNull.Value, 6.96, totales, DBNull.Value, TotalSus, DBNull.Value, 1, Linea)
                    Else
                        tabla.Rows.Add(numiCuenta, DBNull.Value, Glosa + " DEL " + Now.Date.ToString("dd/MM/yyyy") + " AL " + Now.Date.ToString("dd/MM/yyyy"), DBNull.Value, DBNull.Value, DBNull.Value, 6.96, DBNull.Value, totales, DBNull.Value, TotalSus, 1, Linea)
                    End If
                End If



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
        If (swEmision.Value = True) Then
            dt2 = L_prObtenerPlantila(1)

        Else

            dt2 = L_prObtenerPlantila(1)
        End If

        tipo = dt2.Rows(0).Item("Tipo")
        Dim factura As Integer = dt2.Rows(0).Item("Factura")
        Dim TipoTransacion As Integer = 3
        Dim numiComprobante As String = ""
        Dim res As Boolean = L_prComprobanteGrabarIntegracion(numiComprobante, "", 1, Now.Date.Year.ToString, Now.Date.Month.ToString, "", Now.Date.ToString("yyyy/MM/dd"), 6.96, "", "", 1, tabla, "", 0, 6.96, Now.Date.ToString("yyyy/MM/dd"), Now.Date.ToString("yyyy/MM/dd"), 1, 1,
                                                             tipo, factura, Now.Date.ToString("yyyy/MM/dd"), Now.Date.ToString("yyyy/MM/dd"), TipoTransacion, tbCodigo.Text, dtTO00111)
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

    Public Function _fnBuscarIDTC009(ci As String, _dt As DataTable) As Integer
        For i As Integer = 0 To _dt.Rows.Count - 1 Step 1
            If (ci.Equals(_dt.Rows(i).Item("cjci"))) Then
                Return _dt.Rows(i).Item("cjnumi")
            End If

        Next
        Return 0

    End Function

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
                dt.Rows.Add(dtObtenerCuenta.Rows(0).Item("canumi"), dtObtenerCuenta.Rows(0).Item("cacta"), dtObtenerCuenta.Rows(0).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, 56, 0)
                dt.Rows.Add(dtObtenerCuenta.Rows(1).Item("canumi"), dtObtenerCuenta.Rows(1).Item("cacta"), dtObtenerCuenta.Rows(1).Item("cadesc"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, 56, 0)
                Linea = Linea + 1
                dt.Rows.Add(dtObtenerCuenta.Rows(1).Item("canumi"), DBNull.Value, "Ajuste de Cambio", DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, IIf(restantedebe = 0, DBNull.Value, restantedebe), IIf(restanteHaber = 0, DBNull.Value, restanteHaber), IIf(RestanteDebeSus = 0, DBNull.Value, RestanteDebeSus), IIf(RestanteHaberSus = 0, DBNull.Value, RestanteHaberSus), 56, Linea)

            Else


            End If
        Catch ex As Exception

        End Try



    End Sub

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

    Private Sub tbMdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMdesc.KeyDown
        If (e.KeyData = Keys.Enter) Then
            If ValidarDescuentos() = False Then
                Exit Sub
            End If


            'Dim descpar As Double = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabdesc"), AggregateFunction.Sum)
            'Dim montodesc As Double = tbMdesc.Value

            'If montodesc < descpar Then
            '    ToastNotification.Show(Me, "El monto no puede ser menor a: ".ToUpper + descpar.ToString + ", intente nuevamente.".ToUpper,
            '                                   My.Resources.WARNING, InDuracion * 1000,
            '                                   eToastGlowColor.Red,
            '                                   eToastPosition.TopCenter)
            '    tbMdesc.Value = descpar
            'Else
            '    tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabsubtot"), AggregateFunction.Sum) - montodesc
            'End If
        End If

    End Sub

    'Public Sub ValidarDescuentos()
    '    Dim descpar As Double = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabdesc"), AggregateFunction.Sum)
    '    Dim montodesc As Double = tbMdesc.Value

    '    If montodesc < descpar Then
    '        ToastNotification.Show(Me, "El monto no puede ser menor a: ".ToUpper + descpar.ToString + ", intente nuevamente.".ToUpper,
    '                                           My.Resources.WARNING, InDuracion * 1000,
    '                                           eToastGlowColor.Red,
    '                                           eToastPosition.TopCenter)
    '        tbMdesc.Value = descpar
    '    Else
    '        tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabsubtot"), AggregateFunction.Sum) - montodesc
    '    End If

    'End Sub

    Public Function ValidarDescuentos() As Boolean
        Dim descpar As Double = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabdesc"), AggregateFunction.Sum)
        Dim montodesc As Double = tbMdesc.Value

        If montodesc < descpar Then
            ToastNotification.Show(Me, "El monto de descuento no puede ser menor a: ".ToUpper + descpar.ToString + ", intente nuevamente.".ToUpper,
                                               My.Resources.WARNING, InDuracion * 1000,
                                               eToastGlowColor.Red,
                                               eToastPosition.TopCenter)
            'tbMdesc.Value = descpar
            Return False
        Else
            tbtotal.Value = dgjDetalle.GetTotal(dgjDetalle.RootTable.Columns("cabsubtot"), AggregateFunction.Sum) - montodesc
            Return True
        End If

        Return True
    End Function

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click
        'If (Asiento > 0) Then
        '    ToastNotification.Show(Me, "Esta Compra ya ha sido Contabilizado".ToUpper,
        '                                   My.Resources.WARNING, InDuracion * 1000,
        '                                   eToastGlowColor.Red,
        '                                   eToastPosition.TopCenter)

        '    Return

        'End If

        'Verifica si ya se contabilizó la compra
        Dim contabilizo As Boolean = L_fnVerificarSiSeContabilizo(tbCodigo.Text)
        If contabilizo Then
            ToastNotification.Show(Me, "Esta Compra ya ha sido Contabilizada".ToUpper,
                                           My.Resources.WARNING, InDuracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)

            Return
        End If

        If (swEmision.IsReadOnly = True And tbCodigo.Text.Length > 0) Then
            dtTO00111 = L_prComprobanteDetalleDetalleGeneral(-1)
            _prCargarTablaComprobantes()

        Else
            ToastNotification.Show(Me, "No se puede Contabilizar En modo Edicion".ToUpper,
                                            My.Resources.WARNING, InDuracion * 1000,
                                            eToastGlowColor.Red,
                                            eToastPosition.TopCenter)
        End If

    End Sub

    Private Sub MBtImprimir_Click(sender As Object, e As EventArgs) Handles MBtImprimir.Click
        P_GenerarReporte()
    End Sub
    Private Sub P_GenerarReporte()
        Dim dt As DataTable = L_fnNotaCompras(tbCodigo.Text)
        Dim dt2 = L_DatosEmpresa("1")
        Dim _TotalLi As Decimal
        Dim _Literal, _TotalDecimal, _TotalDecimal2 As String

        'Literal 
        _TotalLi = dt.Rows(0).Item("caatotal")
        _TotalDecimal = _TotalLi - Math.Truncate(_TotalLi)
        _TotalDecimal2 = CDbl(_TotalDecimal) * 100

        _Literal = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_TotalLi) - CDbl(_TotalDecimal)) + "  " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"


        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        P_Global.Visualizador = New Visualizador

        Dim objrep As New R_NotaCompra
        objrep.SetDataSource(dt)
        objrep.SetParameterValue("Empresa", dt2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Direccion", dt2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Telefono", dt2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Nit", dt2.Tables(0).Rows(0).Item("scnit").ToString)
        objrep.SetParameterValue("Literal", _Literal)

        P_Global.Visualizador.CRV1.ReportSource = objrep
        P_Global.Visualizador.Show()
        P_Global.Visualizador.BringToFront()
    End Sub

    Public Sub CalcularDescuento01(TotalBruto As Double, descuento As Double)

        Dim dt As DataTable = CType(dgjDetalle.DataSource, DataTable)
        Dim DescuentoUnitario As Double
        Dim CantidadCaja As Double
        Dim Descuento01 As Double
        Dim ImporteBruto As Double
        Dim CostoTotal As Double
        Dim PrecioCostoCaja As Double
        Dim CantidadUnitaria As Double
        If (dt.Rows.Count > 0 And tbObs.ReadOnly = False) Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                CantidadCaja = dt.Rows(i).Item("cabcantcj")
                ImporteBruto = dt.Rows(i).Item("cabsubtot")
                If (ImporteBruto > 0 And CantidadCaja > 0 And TotalBruto > 0) Then
                    Descuento01 = ((ImporteBruto * descuento) / TotalBruto)
                    CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabdescpro1cj") = Descuento01
                    DescuentoUnitario = Descuento01 / CantidadCaja
                    CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabdescpro1un") = DescuentoUnitario

                    '''''''Aqui Calculo el descuento
                    CostoTotal = (dt.Rows(i).Item("cabsubtot") - (dt.Rows(i).Item("cabdesccj") + dt.Rows(i).Item("cabdescpro1cj") + dt.Rows(i).Item("cabdescpro2cj")))
                    'PrecioCostoCaja = (dt.Rows(i).Item("cabsubtot") - (dt.Rows(i).Item("cabdesccj") + dt.Rows(i).Item("cabdescpro1cj") + dt.Rows(i).Item("cabdescpro2cj"))) * 0.87
                    PrecioCostoCaja = (dt.Rows(i).Item("cabsubtot") - (dt.Rows(i).Item("cabdesccj") + dt.Rows(i).Item("cabdescpro1cj") + dt.Rows(i).Item("cabdescpro2cj")))
                    PrecioCostoCaja = PrecioCostoCaja / dt.Rows(i).Item("cabcantcj")
                    CantidadUnitaria = dt.Rows(i).Item("cabcantun") / dt.Rows(i).Item("cabcantcj")
                    If (PrecioCostoCaja > 0 And CantidadUnitaria > 0) Then
                        CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabtot") = CostoTotal
                        CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabpcostocj") = PrecioCostoCaja
                        CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabpcostoun") = PrecioCostoCaja / CantidadUnitaria
                    End If
                    '''''''''
                End If
            Next

            tbtotal.Value = (tbSubtotalC.Value - (tbMdesc.Value + tbDescuentoPro1.Value + tvDescuento02.Value))
        End If
    End Sub

    Public Sub CalcularDescuento02(TotalBruto As Double, descuento As Double)

        Dim dt As DataTable = CType(dgjDetalle.DataSource, DataTable)
        Dim DescuentoUnitario As Double
        Dim CantidadCaja As Double
        Dim Descuento01 As Double
        Dim ImporteBruto As Double
        Dim CostoTotal As Double
        Dim PrecioCostoCaja As Double
        Dim CantidadUnitaria As Double
        If (dt.Rows.Count > 0 And tbObs.ReadOnly = False) Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                CantidadCaja = dt.Rows(i).Item("cabcantcj")
                ImporteBruto = dt.Rows(i).Item("cabsubtot")
                If (ImporteBruto > 0 And CantidadCaja > 0 And TotalBruto > 0) Then
                    Descuento01 = ((ImporteBruto * descuento) / TotalBruto)
                    CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabdescpro2cj") = Descuento01
                    DescuentoUnitario = Descuento01 / CantidadCaja
                    CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabdescpro2un") = DescuentoUnitario
                    '''''''Aqui Calculo el descuento
                    CostoTotal = (dt.Rows(i).Item("cabsubtot") - (dt.Rows(i).Item("cabdesccj") + dt.Rows(i).Item("cabdescpro1cj") + dt.Rows(i).Item("cabdescpro2cj")))
                    'PrecioCostoCaja = (dt.Rows(i).Item("cabsubtot") - (dt.Rows(i).Item("cabdesccj") + dt.Rows(i).Item("cabdescpro1cj") + dt.Rows(i).Item("cabdescpro2cj"))) * 0.87
                    PrecioCostoCaja = (dt.Rows(i).Item("cabsubtot") - (dt.Rows(i).Item("cabdesccj") + dt.Rows(i).Item("cabdescpro1cj") + dt.Rows(i).Item("cabdescpro2cj")))

                    PrecioCostoCaja = PrecioCostoCaja / dt.Rows(i).Item("cabcantcj")
                    CantidadUnitaria = dt.Rows(i).Item("cabcantun") / dt.Rows(i).Item("cabcantcj")
                    If (PrecioCostoCaja > 0 And CantidadUnitaria > 0) Then
                        CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabtot") = CostoTotal
                        CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabpcostocj") = PrecioCostoCaja
                        CType(dgjDetalle.DataSource, DataTable).Rows(i).Item("cabpcostoun") = PrecioCostoCaja / CantidadUnitaria
                    End If
                    '''''''''
                End If

            Next
            tbtotal.Value = (tbSubtotalC.Value - (tbMdesc.Value + tbDescuentoPro1.Value + tvDescuento02.Value))
        End If
    End Sub

    Private Sub DoubleInput1_ValueChanged(sender As Object, e As EventArgs) Handles tbDescuentoPro1.ValueChanged
        Dim descuento As Double = tbDescuentoPro1.Value
        Dim TotalBruto As Double = tbSubtotalC.Value
        If (descuento >= 0) Then
            CalcularDescuento01(TotalBruto, descuento)
        End If

    End Sub

    Private Sub tbSubtotalC_ValueChanged(sender As Object, e As EventArgs) Handles tbSubtotalC.ValueChanged
        Dim descuento As Double = tbDescuentoPro1.Value
        Dim TotalBruto As Double = tbSubtotalC.Value
        If (descuento > 0) Then
            CalcularDescuento01(TotalBruto, descuento)
        End If
        Dim descuento02 As Double = tvDescuento02.Value
        If (descuento02 > 0) Then
            CalcularDescuento02(TotalBruto, descuento02)
        End If
    End Sub

    Private Sub tvDescuento02_ValueChanged(sender As Object, e As EventArgs) Handles tvDescuento02.ValueChanged
        Dim descuento02 As Double = tvDescuento02.Value
        Dim TotalBruto As Double = tbSubtotalC.Value
        If (descuento02 >= 0) Then
            CalcularDescuento02(TotalBruto, descuento02)
        End If
    End Sub

    Private Sub tbProveedor_TextChanged(sender As Object, e As EventArgs) Handles tbProveedor.TextChanged

    End Sub
#End Region
End Class