﻿Imports Logica.AccesoLogica
Imports Modelo.MGlobal
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.ComponentModel
Imports UTILITIES

Public Class P_Principal
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

#Region "Atributos"

#End Region

#Region "Metodos Privados"

    Public Sub New()
        _prCambiarStyle()
        ' This call is required by the designer.
        InitializeComponent()
        FP_Configuracion.Select()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub _prIniciarTodo()
        'Estatico
        FP_RecursosHumanos.Visible = False
        FP_Compras.Visible = False


        'Leer Archivo de Configuración

        If IO.File.Exists(Application.StartupPath + "\CONFIGSERVER.TXT") Then
            Dim frm As New Form2
            'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
            'frm._nameButton = Form2.Name
            'frm._tab = tab3
            'frm._modulo = FP_Venta
            frm.ShowDialog()
            '_prLeerArchivoConfig2()
        Else
            _prLeerArchivoConfig(1)
        End If

        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        EmpresaSeleccion()
        'inicio la empresa

        'btConfCliente.Visible = True
        'btConfPrecio.Visible = True
        'btConfProducto.Visible = True
        'btConfRol.Visible = True
        'btConfUsuario.Visible = True
        'btConfPersonal.Visible = True
        'btConfLibreria.Visible = True
        'btConfEquipo.Visible = True
        'btDescuentos.Visible = True

    End Sub
    Private Sub EmpresaSeleccion()
        Dim frmEmpresa As New P_LoginEmpresa
        frmEmpresa.ShowDialog()
        If frmEmpresa.ok = False Then
            Me.Close()
            Exit Sub
        End If
        _prLeerArchivoConfig(2)
        gb_ConexionAbierta = True
        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.WindowState = FormWindowState.Maximized
        gs_Parametros = L_Parametros()
        'iniciar login de usuario

        _prLogin()
        l_habilitar_prog()
    End Sub
    Private Sub l_habilitar_prog()
        btInveMPCompraProducto.Visible = gs_Parametros(0).Item("sycompra")
        btConfEquipo.Visible = gs_Parametros(0).Item("syclienteequipo")
        ItemContainerInveEquipos.Visible = gs_Parametros(0).Item("syclienteequipo")
        btMovPack.Visible = gs_Parametros(0).Item("syproductopack")
        btLogiRepVisitasDiarias.Visible = False
        tLogiRepProductosMesa.Visible = False
        btPediControlReclamos.Visible = False
        btVentVenta.Visible = False
        btVentPago.Visible = False
        btVentIntegradorFletel.Visible = False
        btVentRepEquipoPrestadoVsUltimaVenta.Visible = False
        btVentRepPrestamoVsVentas.Visible = False
        btNotaVenta.Visible = False
        'btnPedidoProCobrar.Visible = False
        btVentRepCuentaPorCobrar.Visible = False
        btVentRepSaldoCreditoCliente.Visible = False
        ItemContainerConfTransacciones.Refresh()
        If gs_puerto <> "0" Then
            btConfFormulario.Visible = True
        End If
        gs_CantPersonal = gs_Parametros(0).Item("sycantpersonal")
    End Sub

    Private Sub _prCambiarStyle()
        'tratar de cambiar estilo
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass)
        'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eStyle.VisualStudio2012Dark)
        'RibbonPredefinedColorSchemes.ChangeStyle(eStyle.VisualStudio2012Dark)

        'cambio de otros colores
        Dim table As Office2007ColorTable = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable
        Dim ct As SideNavColorTable = table.SideNav
        ''  ct.TitleBackColor = Color.FromArgb(49, 59, 66)
        'ct.SideNavItem.MouseOver.BackColors = New Color() {Color.Red, Color.Yellow}
        ct.SideNavItem.MouseOver.BorderColors = New Color() {Color.FromArgb(49, 59, 66)} ' No border
        ct.SideNavItem.Selected.BackColors = New Color() {Color.Yellow}
        ''     ct.BorderColors = New Color() {Color.FromArgb(49, 59, 66)} ' Control border color

        ''  ct.PanelBackColor = Color.FromArgb(49, 59, 66)
    End Sub

    Private Sub _prLeerArchivoConfig(tipoInicio As Integer)
        Dim NombreBaseDatos As String = "BDDistBHF"
        Dim empresa = gs_empresaDesc
        Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIG.TXT")
        gs_Ip = Archivo(0).Split("=")(1).Trim
        gs_UsuarioSql = Archivo(1).Split("=")(1).Trim
        gs_ClaveSql = Archivo(2).Split("=")(1).Trim
        gs_NombreBD = Archivo(3).Split("=")(1).Trim
        gs_CarpetaRaiz = Archivo(4).Split("=")(1).Trim
        gs_NombreBD2 = Archivo(5).Split("=")(1).Trim
        gs_NombreBD3 = Archivo(6).Split("=")(1).Trim

        If tipoInicio = 1 Then
            NombreBaseDatos = gs_NombreBD
        ElseIf tipoInicio = 2 Then

            If gs_NombreBD2 = empresa Then
                gs_NombreBD = gs_NombreBD2
            End If
            If gs_NombreBD3 = empresa Then
                gs_NombreBD = gs_NombreBD3
            End If

        End If

        'gs_ftpIp = Archivo(5).Split("=")(1).Trim
        'gs_ftpUsuario = "1" 'Archivo(6).Split("=")(1).Trim
        'gs_ftpPass = "1" 'Archivo(7).Split("=")(1).Trim

        ConnectionString.SetParameters(gs_Ip, "1433", gs_NombreBD, gs_UsuarioSql, gs_ClaveSql)
    End Sub
    Private Sub _prLeerArchivoConfig2()
        Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIGSERVER.TXT")
        gs_Ip = Archivo(gs_Ser).Split("=")(1).Trim
        gs_UsuarioSql = Archivo(gs_Ser).Split("=")(2).Trim
        gs_ClaveSql = Archivo(gs_Ser).Split("=")(3).Trim
        gs_NombreBD = Archivo(gs_Ser).Split("=")(4).Trim
        gs_CarpetaRaiz = Archivo(gs_Ser).Split("=")(5).Trim
        gs_puerto = Archivo(gs_Ser).Split("=")(6).Trim
        'gs_ftpIp = Archivo(5).Split("=")(1).Trim
        'gs_ftpUsuario = "1" 'Archivo(6).Split("=")(1).Trim
        'gs_ftpPass = "1" 'Archivo(7).Split("=")(1).Trim
    End Sub

    Private Sub _prLogin()
        Dim ef = New Efecto
        ef.tipo = 4
        ef.ShowDialog()

        L_Usuario = gs_user
        Modelo.MGlobal.gs_user = gs_user

        lbUsuario.Text = gs_user
        lbUsuario.Font = New Font("Tahoma", 12, FontStyle.Bold)

        If gs_user = "DEFAULT" Then
            SideNav1.Enabled = False
        Else
            _PCargarPrivilegios()
            _prCargarConfiguracionSistema()
            SideNav1.Enabled = True
        End If
    End Sub
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Private Sub _prCargarConfiguracionSistema()
        Try
            'mostrar o no mapas
            Dim dtConfSistema As DataTable = L_ConfSistemaGeneral()
            If dtConfSistema.Rows(0).Item("cccmapa") = 0 Then
                gb_mostrarMapa = False
            Else
                gb_mostrarMapa = True
            End If

            'Cargar configuración de empresa-parametros
            gi_mapa = dtConfSistema.Rows(0).Item("cccmapa")
            gi_notiPed = dtConfSistema.Rows(0).Item("cccnotiped")
            gi_vcre = dtConfSistema.Rows(0).Item("cccvcre")
            gi_vdes = dtConfSistema.Rows(0).Item("cccvdes")
            gi_vccli = dtConfSistema.Rows(0).Item("cccvccli")
            gi_vacu = dtConfSistema.Rows(0).Item("cccvacu")
            gi_ftp = dtConfSistema.Rows(0).Item("cccftp")
            gi_vcre2 = dtConfSistema.Rows(0).Item("cccvcre2")
            gi_mprec = IIf(IsDBNull(dtConfSistema.Rows(0).Item("cccmprec")) = True, 0, dtConfSistema.Rows(0).Item("cccmprec"))
            gi_adev = IIf(IsDBNull(dtConfSistema.Rows(0).Item("cccadev")), 0, dtConfSistema.Rows(0).Item("cccadev"))
            gb_despacho = IIf(IsDBNull(dtConfSistema.Rows(0).Item("cccdespacho")), False, dtConfSistema.Rows(0).Item("cccdespacho"))
            gb_ubilogo = IIf(IsDBNull(dtConfSistema.Rows(0).Item("cccubilogo")), "", dtConfSistema.Rows(0).Item("cccubilogo"))
            gi_frecvisita = dtConfSistema.Rows(0).Item("cccfrecvisita")
            gi_CRM = dtConfSistema.Rows(0).Item("cccCRM")
            If gi_CRM = 1 Then
                FP_CRM.Visible = True
            Else
                FP_CRM.Visible = False
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try

    End Sub

    Private Sub _PCargarPrivilegios()
        Dim listaTabs As New List(Of DevComponents.DotNetBar.Metro.MetroTilePanel)
        listaTabs.Add(MetroTilePanelConf)
        listaTabs.Add(MetroTilePanelLogistica)
        listaTabs.Add(MetroTilePanelPedido)
        listaTabs.Add(MetroTilePanelVenta)
        listaTabs.Add(MetroTilePanelInventario)
        listaTabs.Add(MetroTilePanelCRM)
        listaTabs.Add(MetroTilePanelRRHH)
        listaTabs.Add(MetroTilePanelCompra)


        Dim idRolUsu As String = gi_userRol


        Dim dtModulos As DataTable '= L_prLibreriaDetalleGeneral(gi_LibSistema, gi_LibSISModulo)
        dtModulos = L_LibreriaGeneral(gi_LibSistema).Tables(0)
        Dim listFormsModulo As New List(Of String)

        For i = 0 To dtModulos.Rows.Count - 1
            Dim dtDetRol As DataTable = L_RolDetalle_General(-1, idRolUsu, dtModulos.Rows(i).Item("cenum"))
            listFormsModulo = New List(Of String)

            If dtDetRol.Rows.Count > 0 Then
                'cargo los nombres de los programas(botones) del modulo
                For Each fila As DataRow In dtDetRol.Rows
                    listFormsModulo.Add(fila.Item("yaprog").ToString.ToUpper)
                Next
                'recorro el modulo(tab) que corresponde
                For Each _item As DevComponents.DotNetBar.BaseItem In listaTabs.Item(i).Items
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        If listFormsModulo.Contains(btn.Name.ToUpper) Then 'si el nombre del boton pertenece a la lista de formularios del modulo
                            Dim Texto As String = btn.Text
                            Dim TTexto As String = btn.TitleText
                            Dim f As Integer = listFormsModulo.IndexOf(btn.Name.ToUpper)
                            If Texto = "" Then 'esta usando el Title Text
                                btn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            Else 'esta usando el Text
                                btn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            End If

                            If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                btn.Visible = True
                            Else
                                btn.Visible = False
                            End If
                        Else 'si no pertenece lo oculto
                            btn.Visible = False
                        End If
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                If listFormsModulo.Contains(_subBtn.Name.ToUpper) Then
                                    Dim Texto As String = _subBtn.Text
                                    Dim TTexto As String = _subBtn.TitleText
                                    Dim f As Integer = listFormsModulo.IndexOf(_subBtn.Name.ToUpper)
                                    If Texto = "" Then 'esta usando el Title Text
                                        _subBtn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    Else 'esta usando el Text
                                        _subBtn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    End If

                                    If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                        _subBtn.Visible = True
                                    Else
                                        _subBtn.Visible = False
                                    End If
                                Else
                                    _subBtn.Visible = False
                                End If
                            Next
                        End If

                    End If
                Next
            Else ' no exiten formulario registrados en el modulo pero igual hay que ocultar los botones y los subbotones que tenga
                For Each _item As DevComponents.DotNetBar.BaseItem In listaTabs.Item(i).Items
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        btn.Visible = False
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                _subBtn.Visible = False
                            Next
                        End If

                    End If
                Next

            End If

        Next

        'refrescar el formulario
        Me.Refresh()
    End Sub
#End Region

    Private Sub P_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub P_Principal_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        _prLogin()
    End Sub

    Private Sub P_Principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        _prLogin()
    End Sub

    Private Sub Ventana_Click(sender As Object, e As EventArgs) Handles FP_Ventana.Click
        SideNav1.IsMenuExpanded = False
    End Sub

    Private Sub SideNav1_IsMenuExpandedChanged(sender As Object, e As EventArgs) Handles SideNav1.IsMenuExpandedChanged
        If (SideNav1.IsMenuExpanded = True) Then
            FP_Configuracion.Select()
        End If
    End Sub

    Private Sub rmSesion_ItemClick(sender As Object, e As EventArgs) Handles rmSesion.ItemClick
        Dim item As RadialMenuItem = TryCast(sender, RadialMenuItem)
        If item IsNot Nothing AndAlso (Not String.IsNullOrEmpty(item.Text)) Then
            Select Case item.Name
                Case "btCerrarSesion"
                    _prLogin()
                Case "btSalir"
                    Me.Close()
                Case "btAbout"
                    'Dim frm As New P_Acerca
                    'frm.ShowDialog()
                Case "tbEmpresa"
                    EmpresaSeleccion()
            End Select
        End If
    End Sub

    Private Sub FP_CerrarSesion_Click(sender As Object, e As EventArgs) Handles FP_CerrarSesion.Click
        rmSesion.IsOpen = True
        rmSesion.MenuLocation = New Point(Me.Width / 2, Me.Height / 3)
        SideNavPaenlConf.Select()
    End Sub

    Private Sub rmSesion_MenuClosed(sender As Object, e As EventArgs) Handles rmSesion.MenuClosed
        FP_Configuracion.Select()
    End Sub

    Private Sub superTabControl3_TabItemClose(sender As Object, e As SuperTabStripTabItemCloseEventArgs)
        Dim cantidad As Integer = superTabControlVentana.Tabs.Count
        'If cantidad = 1 Then
        '    FP_Configuracion.Select()
        'End If
    End Sub


#Region "Cofiguracion"

    Private Sub btConfCliente_Click(sender As Object, e As EventArgs) Handles btConfCliente.Click
        'SideNav1.IsMenuExpanded = False


        'FP_Ventana.Select()
        F02_Cliente.AllowTransparency = True
        Dim frm As New F02_Cliente
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfCliente.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion

        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    'Private Async Sub btConfProducto_Click(sender As Object, e As EventArgs) Handles btConfProducto.Click
    Private Sub btConfProducto_Click(sender As Object, e As EventArgs) Handles btConfProducto.Click
        'SideNav1.IsMenuExpanded = False
        F01_Producto.AllowTransparency = True
        'FP_Ventana.Select()
        Dim frm As New F01_Producto
        frm._nameButton = btConfCliente.Name
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        frm.TipoForm = 1
        frm.Titulo = "P R O D U C T O"

        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        'FP_Ventana.Select()
        'frm.AllowTransparency = True
        'frm.Visible = False
        'FP_Configuracion.Select()


        'Await Task.Delay(2000)
        frm.Show()
        'frm.Inicio()
        'Sleep(2000)
        'frm.WindowState = FormWindowState.Maximized
        'Sleep(8000)
        'frm.Opacity = 100
        'FP_Ventana.Select()
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1


        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfEquipo_Click(sender As Object, e As EventArgs) Handles btConfEquipo.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        'F01_Producto.AllowTransparency = True
        Dim frm As New F01_Producto
        'Dim frm As New Form1
        frm.TipoForm = 2
        frm._modulo = FP_Configuracion
        frm.Titulo = "E Q U I P O"
        frm.Show()


        'frm._nameButton = btConfCliente.Name
        ''Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        ''frm._tab = tab3



        ''Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        ''superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        ''tab3.AttachedControl.Controls.Add(panel)

        ''tab3.Text = frm.Text
        ''tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfPrecio_Click(sender As Object, e As EventArgs) Handles btConfPrecio.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Precio.AllowTransparency = True
        Dim frm As New F0_PreciosAlterno
        frm._nameButton = btConfPrecio.Name
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfFormulario_Click(sender As Object, e As EventArgs) Handles btConfFormulario.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        'Dim frm As New P_Formularios
        'frm._nameButton = btConfFormulario.Name
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._tab = tab3
        'frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        'frm.Show()
        'tab3.Text = frm.Text
        ''tab3.Icon = frm.Icon

        Dim frm As New Parametros
        frm.Show()

    End Sub

    Private Sub btConfRol_Click(sender As Object, e As EventArgs) Handles btConfRol.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        'Dim frm As New P_Roles
        F01_Rol.AllowTransparency = True
        Dim frm As New F01_Rol
        frm._nameButton = btConfRol.Name
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfUsuario_Click(sender As Object, e As EventArgs) Handles btConfUsuario.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        P_Usuarios.AllowTransparency = True
        Dim frm As New P_Usuarios
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfUsuario.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfLibreria_Click(sender As Object, e As EventArgs) Handles btConfLibreria.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Libreria.AllowTransparency = True
        Dim frm As New F02_Libreria
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfLibreria.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfPersonal_Click(sender As Object, e As EventArgs) Handles btConfPersonal.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_Personal.AllowTransparency = True
        Dim frm As New F01_Personal
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfPersonal.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btDescuentos_Click(sender As Object, e As EventArgs) Handles btDescuentos.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Descuento.AllowTransparency = True
        Dim frm As New F02_Descuento
        frm._nameButton = btConfPrecio.Name
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub


#End Region

#Region "Logistica"

    Private Sub btLogiZona_Click(sender As Object, e As EventArgs) Handles btLogiZona.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Zona.AllowTransparency = True
        Dim frm As New F02_Zona
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btLogiZona.Name
        'frm._tab = tab3
        frm._modulo = FP_Logistica
        frm.Titulo = "Z O N A"
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btLogiMovChoferSalida_Click(sender As Object, e As EventArgs) Handles btLogiMovChoferSalida.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        'F0G_MovimientoChoferSalida.AllowTransparency = True
        Dim frm As New F0G_MovimientoChoferSalida
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btLogiMovChoferSalida.Name
        'frm._tab = tab3
        frm._modulo = FP_Logistica
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub


    Private Sub btLogiMovChoferConciliacion_Click(sender As Object, e As EventArgs) Handles btLogiMovChoferConciliacion.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0G_MovimientoChoferEntrada.AllowTransparency = True
        Dim frm As New F0G_MovimientoChoferEntrada
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btLogiMovChoferConciliacion.Name
        'frm._tab = tab3
        frm._modulo = FP_Logistica
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btLogiRepVisitasDiarias_Click(sender As Object, e As EventArgs) Handles btLogiRepVisitasDiarias.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_VisitasDiarias.AllowTransparency = True
        Dim frm As New R01_VisitasDiarias
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btLogiRepVisitasDiarias.Name
        'frm._tab = tab3
        frm._modulo = FP_Logistica
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub
    Private Sub btVisitaClientes_Click(sender As Object, e As EventArgs) Handles btVisitaClientes.Click
        R01_VisitasDiarias.AllowTransparency = True
        Dim frm As New R01_VisitasClientes
        frm._nameButton = btVisitaClientes.Name
        frm._modulo = FP_Logistica
        frm.Show()
    End Sub
#End Region

#Region "Pedido"

    Private Sub btPediPedido_Click(sender As Object, e As EventArgs) Handles btPediPedido.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Pedido.AllowTransparency = True
        Dim frm As New F02_Pedido
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediPedido.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btPediPedidoControl_Click(sender As Object, e As EventArgs) Handles btPediPedidoControl.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PedidosAsignacion.AllowTransparency = True
        Dim frm As New F0_PedidosAsignacion
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btLogiZona.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btPediControlReclamos_Click(sender As Object, e As EventArgs) Handles btPediControlReclamos.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_ControlReclamos.AllowTransparency = True
        Dim frm As New F01_ControlReclamos
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediControlReclamos.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediMonitoreoPedido_Click(sender As Object, e As EventArgs) Handles btPediMonitoreoPedido.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_MonitoreoPedido.AllowTransparency = True
        Dim frm As New F01_MonitoreoPedido
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediMonitoreoPedido.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediUbicacionCliente_Click(sender As Object, e As EventArgs) Handles btPediUbicacionCliente.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F1_MapaCLientes.AllowTransparency = True
        Dim frm As New F1_MapaCLientes
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediUbicacionCliente.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediDistribicion_Click(sender As Object, e As EventArgs) Handles btPediDistribicion.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        frmDispatch.AllowTransparency = True
        Dim frm As New frmDispatch
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediDistribicion.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediFacturacionDespacho_Click(sender As Object, e As EventArgs) Handles btPediFacturacionDespacho.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        frmBillingDispatch.AllowTransparency = True
        Dim frm As New frmBillingDispatch
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediFacturacionDespacho.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediDespachoEntregado_Click(sender As Object, e As EventArgs) Handles btPediDespachoEntregado.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        frmBillingDispatch.AllowTransparency = True
        Dim frm As New frmDeliveryDispatch
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediFacturacionDespacho.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub
#End Region

#Region "Venta"

    Private Sub btVentVenta_Click(sender As Object, e As EventArgs) Handles btVentVenta.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0G_VentaChoferConciliacion.AllowTransparency = True
        Dim frm As New F0G_VentaChoferConciliacion
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentVenta.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentPago_Click(sender As Object, e As EventArgs) Handles btVentPago.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_Pagos.AllowTransparency = True
        Dim frm As New F01_Pagos
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentPago.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub
    Private Sub btVentas_Click(sender As Object, e As EventArgs) Handles btVentas.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_Ventas.AllowTransparency = True
        Dim frm As New F0_Ventas
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentas.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

#Region "Reportes Ventas"

    Private Sub btVentRepEquipoPrestadoVsUltimaVenta_Click(sender As Object, e As EventArgs) Handles btVentRepEquipoPrestadoVsUltimaVenta.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_EquipoPrestadoVsUltimaVenta.AllowTransparency = True
        Dim frm As New R01_EquipoPrestadoVsUltimaVenta
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepEquipoPrestadoVsUltimaVenta.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentRepUltimaVenta_Click(sender As Object, e As EventArgs) Handles btVentRepUltimaVenta.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_UltimaVentaCliente.AllowTransparency = True
        Dim frm As New R01_UltimaVentaCliente
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepUltimaVenta.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentRepSaldoCreditoCliente_Click(sender As Object, e As EventArgs) Handles btVentRepSaldoCreditoCliente.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_saldoCreditoCliente.AllowTransparency = True
        Dim frm As New R01_saldoCreditoCliente
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepSaldoCreditoCliente.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub
    Private Sub btVentRepVentaCajaGeneral_Click(sender As Object, e As EventArgs) Handles btVentRepVentaCajaGeneral.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        frmCajaGeneral.AllowTransparency = True
        Dim frm As New frmCajaGeneral
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentaCajaGeneral.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

#End Region

#End Region

#Region "Inventario"

#Region "Inventario equipo"

    Private Sub btInveMEMovEquipo_Click(sender As Object, e As EventArgs) Handles btInveMEMovEquipo.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Movimiento.AllowTransparency = True
        Dim frm As New F02_Movimiento
        frm.titulo = "M O V I M I E N T O   D E   E Q U I P O"
        frm.tipo = 1
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMEMovEquipo.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btInveMESaldoEquipo_Click(sender As Object, e As EventArgs) Handles btInveMESaldoEquipo.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_SaldoEquipo.AllowTransparency = True
        Dim frm As New R01_SaldoEquipo
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMESaldoEquipo.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btInveMEKardexEquipo_Click(sender As Object, e As EventArgs) Handles btInveMEKardexEquipo.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_KardexInventarioEquiProd.AllowTransparency = True
        Dim frm As New F01_KardexInventarioEquiProd
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMEKardexEquipo.Name
        frm.Titulo = "K A R D E X   D E   E Q U I P O"
        frm.Tipo = 1
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btInveMEKardexPrestamoAgrupado_Click(sender As Object, e As EventArgs) Handles btInveMEKardexPrestamoAgrupado.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_PrestamoEquiposAgrupado.AllowTransparency = True
        Dim frm As New R01_PrestamoEquiposAgrupado
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMEKardexPrestamoAgrupado.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

#End Region

#Region "Inventario producto"

    Private Sub btInveMPMovProducto_Click(sender As Object, e As EventArgs) Handles btInveMPMovProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Movimiento.AllowTransparency = True
        Dim frm As New F02_Movimiento
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm.titulo = "M O V I M I E N T O   D E   P R O D U C T O"
        frm.tipo = 2
        frm._nameButton = btInveMPMovProducto.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btInveMPSaldoProducto_Click(sender As Object, e As EventArgs) Handles btInveMPSaldoProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_SaldoProducto.AllowTransparency = True
        Dim frm As New R01_SaldoProducto
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMPSaldoProducto.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btInveMPKardexProducto_Click(sender As Object, e As EventArgs) Handles btInveMPKardexProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_KardexInventarioEquiProd.AllowTransparency = True
        Dim frm As New F01_KardexInventarioEquiProd
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMEKardexEquipo.Name
        frm.Titulo = "K A R D E X   D E   P R O D U C T O"
        frm.Tipo = 2
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btInveMPProveedor_Click(sender As Object, e As EventArgs) Handles btInveMPProveedor.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F01_Proveedor.AllowTransparency = True
        Dim frm As New F01_Proveedor
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMPProveedor.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub



    Private Sub btVentCaja_Click(sender As Object, e As EventArgs) Handles btVentCaja.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_MCaja.AllowTransparency = True
        Dim frm As New F0_MCaja
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentCaja.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btConfcategoria_Click(sender As Object, e As EventArgs) Handles btConfcategoria.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_Categoria.AllowTransparency = True
        Dim frm As New F0_Categoria
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfcategoria.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentRepVentasG_Click(sender As Object, e As EventArgs) Handles btVentRepVentasG.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_VentasAtendidas.AllowTransparency = True
        Dim frm As New R01_VentasAtendidas
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentasG.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentRepProducto_Click(sender As Object, e As EventArgs) Handles btVentRepProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_VentasProductos.AllowTransparency = True
        Dim frm As New R01_VentasProductos
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepProducto.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentRepVentasConcepto_Click(sender As Object, e As EventArgs) Handles btVentRepVentasConcepto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_Concepto_Ventas_Meses.AllowTransparency = True
        Dim frm As New R01_Concepto_Ventas_Meses
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentasConcepto.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btVentRepVentasGrafica_Click(sender As Object, e As EventArgs) Handles btVentRepVentasGrafica.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        Pr_ReporteVentasGrafico.AllowTransparency = True
        Dim frm As New Pr_ReporteVentasGrafico

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentasGrafica.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btVentIntegradorFletel_Click(sender As Object, e As EventArgs) Handles btVentIntegradorFletel.Click
        SideNav1.IsMenuExpanded = False
        FP_Ventana.Select()
        Dim frm As New P_IntegradorFlextel

        Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentasGrafica.Name
        frm._tab = tab3
        frm._modulo = FP_Venta
        Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        tab3.Text = frm.Text
    End Sub

    Private Sub btVentRepEstaClient_Click(sender As Object, e As EventArgs) Handles btVentRepEstaClient.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_EstadoCuentasCliente.AllowTransparency = True
        Dim frm As New R01_EstadoCuentasCliente
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentasG.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentRepCuentaPorCobrar_Click(sender As Object, e As EventArgs) Handles btVentRepCuentaPorCobrar.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_EstadoCuentasPorCobrar.AllowTransparency = True
        Dim frm As New R01_EstadoCuentasPorCobrar
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btVentRepVentasG.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btVentCredito_Click(sender As Object, e As EventArgs) Handles btVentCredito.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_CreditosPedidos.AllowTransparency = True
        Dim frm As New F0_CreditosPedidos

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = F0_CreditosPedidos.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btnPedidoProCobrar_Click(sender As Object, e As EventArgs) Handles btnPedidoProCobrar.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R0_Credito.AllowTransparency = True
        Dim frm As New R0_Credito

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = F0_CreditosPedidos.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btVentRepPrestamoVsVentas_Click(sender As Object, e As EventArgs) Handles btVentRepPrestamoVsVentas.Click
        SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_EquipoPrestadoVsVenta.AllowTransparency = True
        Dim frm As New R01_EquipoPrestadoVsVenta

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = F0_CreditosPedidos.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btVentRepVentaClientePorMes_Click(sender As Object, e As EventArgs) Handles btVentRepVentaClientePorMes.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R02_VentaClientePorMes.AllowTransparency = True
        Dim frm As New R02_VentaClientePorMes

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = F0_CreditosPedidos.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btConfMesas_Click(sender As Object, e As EventArgs) Handles btConfMesas.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        P_Mesas.AllowTransparency = True
        Dim frm As New P_Mesas
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfMesas.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub tLogiRepProductosMesa_Click(sender As Object, e As EventArgs) Handles tLogiRepProductosMesa.Click
        SideNav1.IsMenuExpanded = False
        FP_Ventana.Select()
        Dim frm As New R01_ProductosMesa
        Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btLogiRepVisitasDiarias.Name
        frm._tab = tab3
        frm._modulo = FP_Logistica
        Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        tab3.Text = frm.Text

    End Sub

    Private Sub btNotaVenta_Click(sender As Object, e As EventArgs) Handles btNotaVenta.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_NotaVenta.AllowTransparency = True
        Dim frm As New R01_NotaVenta
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = R01_NotaVenta.Name
        'frm._tab = tab3
        frm._modulo = FP_Venta
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btStockDisponible_Click(sender As Object, e As EventArgs) Handles btStockDisponible.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_StockDisponible.AllowTransparency = True
        Dim frm As New R01_StockDisponible
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btStockDisponible.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub MetroTileItem9_Click(sender As Object, e As EventArgs) Handles MetroTileItem9.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02ZonaAsignacion.AllowTransparency = True
        Dim frm As New F0_AsignacionZonaAlternativo
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = F02_Zona.Name
        'frm._tab = tab3
        frm._modulo = FP_Logistica

        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediReporteUtilidades_Click(sender As Object, e As EventArgs) Handles btPediReporteUtilidades.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R0_ReportePedidosCosto.AllowTransparency = True
        Dim frm As New R0_ReportePedidosCosto
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediReporteUtilidades.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btPediReporteUtilidadesPorProducto_Click(sender As Object, e As EventArgs) Handles btPediReporteUtilidadesPorProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R0_UTilidadPorProducto.AllowTransparency = True
        Dim frm As New R0_UTilidadPorProducto
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPediReporteUtilidades.Name
        'frm._tab = tab3
        frm._modulo = FP_Pedido
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btConfDosificacion_Click(sender As Object, e As EventArgs) Handles btConfDosificacion.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F1_Dosificacion.AllowTransparency = True
        Dim frm As New F1_Dosificacion
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btConfDosificacion.Name
        'frm._tab = tab3
        frm._modulo = FP_Configuracion
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
    End Sub

    Private Sub btMovPack_Click(sender As Object, e As EventArgs) Handles btMovPack.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_MovimientoPack.AllowTransparency = True
        Dim frm As New F02_MovimientoPack
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm.titulo = "M O V I M I E N T O   D E   P A C K"
        frm.tipo = 2
        frm._nameButton = btMovPack.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btSaldoFisicoValorado_Click(sender As Object, e As EventArgs) Handles btSaldoFisicoValorado.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        R01_SaldoFisicoValorado.AllowTransparency = True
        Dim frm As New R01_SaldoFisicoValorado
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btSaldoFisicoValorado.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub





#End Region

#End Region

#Region "RRHH"



#End Region

#Region "Compra"
    Private Sub btInveMPCompraProducto_Click(sender As Object, e As EventArgs) Handles btInveMPCompraProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F02_Compra.AllowTransparency = True
        Dim frm As New F02_Compra
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btInveMPCompraProducto.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btPagosCompras_Click(sender As Object, e As EventArgs) Handles btPagosCompras.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New F0_PagosCreditoCompraUlt
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPagosCompras.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub P_Principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            Dim frm As New Parametros
            frm.Show()
        End If
    End Sub

    Private Sub SideNav1_Click(sender As Object, e As EventArgs) Handles SideNav1.Click

    End Sub

    Private Sub SideNav1_KeyDown(sender As Object, e As KeyEventArgs) Handles SideNav1.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            Dim frm As New Parametros
            frm.Show()
        End If
    End Sub

    Private Sub btVendedorZonas_Click(sender As Object, e As EventArgs) Handles btVendedorZonas.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New F01_RepZonaVendedores
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btPagosCompras.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnEstadoCuentasProveedor_Click(sender As Object, e As EventArgs) Handles btnEstadoCuentasProveedor.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New R01_EstadoCuentasCompra
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btnEstadoCuentasProveedor.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnReporteMovimiento_Click(sender As Object, e As EventArgs) Handles btnReporteMovimiento.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New R01_ReporteMovimientos
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btnEstadoCuentasProveedor.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnReporteCompras_Click(sender As Object, e As EventArgs) Handles btnReporteCompras.Click
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New F01_ReporteCompras
        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._nameButton = btnEstadoCuentasProveedor.Name
        ''frm._tab = tab3
        'frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnExistenciaProducto_Click(sender As Object, e As EventArgs) Handles btnExistenciaProducto.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New R02_ExistenciaProductos

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btnEstadoCuentasProveedor.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnReporteComercial_Click(sender As Object, e As EventArgs) Handles btnReporteComercial.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New R01_VentasProductosRanking

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        frm._nameButton = btnEstadoCuentasProveedor.Name
        'frm._tab = tab3
        frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnVentaFacturada_Click(sender As Object, e As EventArgs) Handles btnVentaFacturada.Click
        'SideNav1.IsMenuExpanded = False
        'FP_Ventana.Select()
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New F01_ReporteVentaFact

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._nameButton = btnEstadoCuentasProveedor.Name
        ''frm._tab = tab3
        'frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
        'tab3.Text = frm.Text
        'tab3.Icon = frm.Icon
    End Sub

    Private Sub btnVentaAdministrativa_Click(sender As Object, e As EventArgs) Handles btnVentaAdministrativa.Click
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New F01_ReporteVentaAdmin
        frm.Show()
    End Sub

    Private Sub btPediPedidoNuevo_Click(sender As Object, e As EventArgs) Handles btPediPedidoNuevo.Click

        F02_PedidoNuevo.AllowTransparency = True
        Dim frm As New F02_PedidoNuevo

        frm._nameButton = btPediPedidoNuevo.Name
        frm._modulo = FP_Pedido
        frm.Show()
    End Sub

    Private Sub btnVentaFacturacion_Click(sender As Object, e As EventArgs) Handles btnVentaFacturacion.Click
        F0_PagosCreditoCompraUlt.AllowTransparency = True
        Dim frm As New F01_ReporteFactura02

        'Dim tab3 As SuperTabItem = superTabControlVentana.CreateTab(frm.Text)
        'frm._nameButton = btnEstadoCuentasProveedor.Name
        ''frm._tab = tab3
        'frm._modulo = FP_Inventario
        'Dim panel As Panel = P_Global._fnCrearPanelVentanas(frm)
        'superTabControlVentana.SelectedTabIndex = superTabControlVentana.Tabs.Count - 1
        'tab3.AttachedControl.Controls.Add(panel)
        frm.Show()
    End Sub

    Private Sub btConfEmpresa_Click(sender As Object, e As EventArgs) Handles btConfEmpresa.Click

        F1_Empresas.AllowTransparency = True
        Dim frm As New F1_Empresas

        frm._nameButton = btConfEmpresa.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub btComisiones_Click(sender As Object, e As EventArgs) Handles btComisiones.Click
        F02_Comisiones.AllowTransparency = True
        Dim frm As New F02_Comisiones
        frm._nameButton = btComisiones.Name
        frm._modulo = FP_CRM
        frm.Show()
    End Sub

    Private Sub btVentaComision_Click(sender As Object, e As EventArgs) Handles btVentaComision.Click
        R01_VentasComision.AllowTransparency = True
        Dim frm As New R01_VentasComision
        frm._nameButton = btVentaComision.Name
        frm._modulo = FP_CRM
        frm.Show()
    End Sub

    Private Sub btVentasVendedor_Click(sender As Object, e As EventArgs) Handles btVentasVendedor.Click
        R01_VentasVendedor.AllowTransparency = True
        Dim frm As New R01_VentasVendedor
        frm._nameButton = btVentasVendedor.Name
        frm._modulo = FP_CRM
        frm.Show()
    End Sub

    Private Sub btEstadoCuentaCliente_Click(sender As Object, e As EventArgs) Handles btEstadoCuentaCliente.Click
        R01_EstadoCuentasClientes.AllowTransparency = True
        Dim frm As New R01_EstadoCuentasClientes
        frm._nameButton = btEstadoCuentaCliente.Name
        frm._modulo = FP_Venta
        frm.Show()
    End Sub

    Private Sub btEstadoCuentasClientesTodos_Click(sender As Object, e As EventArgs) Handles btEstadoCuentasClientesTodos.Click
        R01_EstadoCuentasClientesTodos.AllowTransparency = True
        Dim frm As New R01_EstadoCuentasClientesTodos
        frm._nameButton = btEstadoCuentasClientesTodos.Name
        frm._modulo = FP_Venta
        frm.Show()
    End Sub

    Private Sub btBancos_Click(sender As Object, e As EventArgs) Handles btBancos.Click
        F1_Bancos.AllowTransparency = True
        Dim frm As New F1_Bancos
        frm._nameButton = btBancos.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub



#End Region

End Class