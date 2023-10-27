Imports System.Windows.Forms
Imports System.Threading
Imports System.Globalization
Imports Modulo_Ventas.FuncionesGlobales
Imports System.Deployment
Imports System.Deployment.Application

Public Class frm_MENU

    Private Segundos As Integer = 0

    Private Sub frm_MENU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If LoginId > 0 Then
            Cn_Login.Login_CerrarSesion()
            'Insertar en Usr_Log
            If TipoBloqueo <> 0 Then
                Cn_Login.fn_Log_Create("CIERRE DE SESION(DESPUES DE BLOQUEO)")
            Else
                Cn_Login.fn_Log_Create("CIERRE DE SESION")
            End If
        End If
    End Sub

    Private Sub frm_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Call Deshabilitar_Todo()

        Meses(1) = "Ene"
        Meses(2) = "Feb"
        Meses(3) = "Mar"
        Meses(4) = "Abr"
        Meses(5) = "May"
        Meses(6) = "Jun"
        Meses(7) = "Jul"
        Meses(8) = "Ago"
        Meses(9) = "Sep"
        Meses(10) = "Oct"
        Meses(11) = "Nov"
        Meses(12) = "Dic"

        MesesLargo(1) = "Enero"
        MesesLargo(2) = "Febrero"
        MesesLargo(3) = "Marzo"
        MesesLargo(4) = "Abril"
        MesesLargo(5) = "Mayo"
        MesesLargo(6) = "Junio"
        MesesLargo(7) = "Julio"
        MesesLargo(8) = "Agosto"
        MesesLargo(9) = "Septiembre"
        MesesLargo(10) = "Octubre"
        MesesLargo(11) = "Noviembre"
        MesesLargo(12) = "Diciembre"

        'Cambiar la configuración regional
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES", False)

        ' Obtengo la informacion de formato numerico
        Dim nfi As Globalization.NumberFormatInfo = Thread.CurrentThread.CurrentCulture.NumberFormat
        ' Obtengo la informacion de formato fecha
        Dim Dfi As Globalization.DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        If nfi.NumberDecimalSeparator <> "." Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.NumberGroupSeparator <> "," Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.CurrencySymbol <> "$" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortDatePattern <> "dd/MM/yyyy" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortTimePattern <> "HH:mm:ss" And Dfi.ShortTimePattern <> "hh:mm tt" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If

        tmr_Inicio.Enabled = True
    End Sub

    Private Sub tmr_Inicio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Inicio.Tick
        TipoBloqueo = 0
        SegundosDesconexion = 0
        tmr_Inicio.Enabled = False
        Dim frmSet As New frm_Settings
        'verificar Si hay tipoesquema y DAtos de conexion
        If My.Settings.TipoEsquema = "0" Then
            frmSet.ShowDialog()
            If My.Settings.TipoEsquema = "0" Then
                MsgBox("No se ha especificado el tipo de esquema a utilizar.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If

        If Cn_Clientes.fn_CuentaSettings() = 10 Then
            frmSet.ShowDialog()
            If Cn_Clientes.fn_CuentaSettings() = 10 Then
                MsgBox("No se han capturado el nombre del Servidor y la Base de Datos.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If
        '---------------
        frm_Login.ShowDialog()
        If SucursalId = 0 Then
            Me.Close()
            Exit Sub
        End If

        Me.Text = "SIAC. Módulo Ventas v" & ModuloVersion & "  ** Conectado A: " & SucursalDatos

        cn_Mensajes.ActualizarMensajes()
        tmr_Hora.Enabled = True

    End Sub

    Private Sub tmr_Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Hora.Tick
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString

        Segundos += 1
        SegundosDesconexion += 1
        If SegundosDesconexion >= (MinutosDesconexion * 60) Then
            SegundosDesconexion = 0
            tmr_Hora.Enabled = False
            'Insertar en Usr_Log
            Cn_Login.fn_Log_Create("BLOQUEO POR INACTIVIDAD")
            TipoBloqueo = 2
            Call CerrarModales()
            Me.Hide()
            frm_Login.ShowDialog()
            tmr_Hora.Enabled = True
        End If
        If Segundos = 300 Then
            cn_Mensajes.ActualizarMensajes()
            Segundos = 0
        End If
    End Sub

    Sub CerrarModales()
        Dim Contador As Integer = Application.OpenForms.Count
        Try
            For ILocal As Integer = 0 To Contador - 1
                If Application.OpenForms(ILocal).Modal Then
                    Application.OpenForms(ILocal).Dispose()
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub tsb_Bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Bloquear.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BLOQUEAR SISTEMA")
        TipoBloqueo = 1

        tmr_Hora.Enabled = False
        Me.Hide()
        frm_Login.ShowDialog()
        tmr_Hora.Enabled = True
    End Sub

    Sub Deshabilitar_Todo()
        Dim SubSub As Integer = 0
        For Each element As ToolStripItem In MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                SubSub = 0
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            SubSub = SubSub + 1
                            If TypeOf (SubChild) Is ToolStripMenuItem And SubChild.Tag <> "" Then
                                SubChild.Enabled = False
                            End If

                        Next
                        If SubSub = 0 And Child.Tag <> "" Then
                            Child.Enabled = False
                        End If

                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                If element.Tag <> "" Then
                    element.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CLIENTES")

        'Dim frm As New frm_Clientes
        'FuncionesGlobales.MostrarVentana(frm)
        FuncionesGlobales.MostrarVentana(frm_Clientes)
    End Sub

    Private Sub CatalogoDeClientesPorcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeClientesPorcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CLIENTES CON SERVICIO DE PROCESO")

        Dim frm As New frm_ClientesProceso
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CatalogoDeCajasBancariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeCajasBancariasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAJAS BANCARIAS")

        Dim frm As New frm_CajasBancarias
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub BajaDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDeClientesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BAJA DE CLIENTES")

        Dim frm As New frm_ClientesBaja
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub GruposDeFacturaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposDeFacturaciónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GRUPOS DE FACTURACION DE PROCESO")

        Dim frm As New frm_GruposFacturacion
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub GenerarCartaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCartaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GENERAR CARTA DE AUMENTO DE PRECIO")

        Dim frm As New frm_GenerarCarta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ValidarCartasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarCartasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR CARTAS DE AUMENTO DE PRECIO")

        Dim frm As New frm_ValidarCartas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDePuntosAtendidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDePuntosAtendidosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE PUNTOS ATENDIDOS")

        Dim frm As New frm_ConsultaPuntos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REGISTRO DE PROSPECTOS")

        Dim frm As New frm_NuevoProspecto
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CatalogoDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeCuentasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CUETNAS BANCARIAS")

        Dim frm As New frm_CatalogoCuentas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ValidaProspectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidaProspectoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR PROSPECTOS")

        Dim frm As New frm_ValidaProspectos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CatalogoDeDocumentosRequeridosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeDocumentosRequeridosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE DOCUMENTOS REQUERIDOS")

        Dim frm As New frm_DoctosRequeridos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeContactosEnWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeContactosEnWebToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE MENSAJES WEB SISSA")

        Dim frm As New frm_ConsultaWeb
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ValidarHorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarHorariosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR HORARIOS")

        Dim frm As New frm_ValidaHorarios
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_LeerMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_LeerMensajes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        Dim frm As New frm_VerMensajes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_NuevoMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_NuevoMensaje.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        Dim frm As New frm_EnviarMensajes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Salir.Click
        Me.Close()
    End Sub

    Private Sub tsb_DocumentosRequeridos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DocumentosRequeridos.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE DOCUMENTOS REQUERIDOS")

        Dim frm As New frm_DoctosRequeridos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_CajasBancarias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_CajasBancarias.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAJAS BANCARIAS")

        Dim frm As New frm_CajasBancarias
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_ClientesProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ClientesProceso.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CLIENTES CON SERVICIO DE PROCESO")

        Dim frm As New frm_ClientesProceso
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_Cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Cuentas.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CUENTAS BANCARIAS")

        Dim frm As New frm_CatalogoCuentas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_NuevoProspecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_NuevoProspecto.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REGISTRO DE PROSOPECTO")

        Dim frm As New frm_NuevoProspecto
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_ValidarProspecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ValidarProspecto.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR PROSPECTOS")

        Dim frm As New frm_ValidaProspectos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Clientes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CLIENTES")

        'Dim frm As New frm_Clientes
        'FuncionesGlobales.MostrarVentana(frm)
        FuncionesGlobales.MostrarVentana(frm_Clientes)
    End Sub

    Private Sub tsb_ValidarHorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ValidarHorarios.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR HORARIOS")

        Dim frm As New frm_ValidaHorarios
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub GruposDeFacturaciónABancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposDeFacturaciónABancosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONCEPTOS DE FACTUARCION DE PROCESO")

        Dim frm As New frm_ConceptosFproceso
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AtenciónDeLlamadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtenciónDeLlamadasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REGISTRO DE LLAMADAS")

        Dim frm As New frm_AtencionLlamadas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: AGENDA")

        Dim frm As New frm_Agenda
        FuncionesGlobales.MostrarVentana(frm, True)
        'FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE LLAMADAS")

        Dim frm As New frm_ConsultaLlamadas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ReportarFallaDeEquipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaDeEquipoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN EQUIPO")

        Dim frm As New frm_ReporteFallas
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: COTIZACIONES")

        Dim frm As New frm_Cotizaciones
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        Dim frm As New frm_EnviarMensajes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub VerMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        Dim frm As New frm_VerMensajes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ActualizacionesInstaladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizacionesInstaladasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ACTUALIZACIONES")

        Dim frm As New frm_ActualizacionesConsultar
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeClientesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE CLIENTES")

        Dim frm As New frm_ConsultaClientes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub LeerContactosDeOutlookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerContactosDeOutlookToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER CONTACTOS DE OUTLOOK")

        Dim frm As New frm_Outlook
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACERCA DE")

        Dim frm As New frm_About
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ReportarFallaEnSistemaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportarFallaEnSistemaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN SISTEMA")

        Dim frm As New frm_ReporteFallasS
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub SeguimientoAFallasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoAFallasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SEGUIMIENTO A FALLAS")

        Dim frm As New frm_ReporteFallasConsultar
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub TiposDeCajasFuertesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeCajasFuertesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: TIPOS DE CAJAS FUERTES")

        Dim frm As New frm_CajasFuertesT
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub InventarioDeCajasFuertesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioDeCajasFuertesToolStripMenuItem1.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: INVENTARIO DE CAJAS FUERTES")

        Dim frm As New frm_CajasFuertes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeCajasFuertesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCajasFuertesToolStripMenuItem1.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS DE CAJAS FUERTES")

        Dim frm As New frm_ConsultaCajasFuertes
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub MovimientosDeCajasFuertesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeCajasFuertesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS DE MOVIMIENTOS DE CAJAS FUERTES")

        Dim frm As New frm_ConsultaCajasFuertesM
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub OrdenDeInpecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeInpecciónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ORDEN DE INSPECCION PARA INSTALACION DE CAJA FUERTE")

        Dim frm As New frm_ActaInspeccion
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaOrdenesDeInspecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaOrdenesDeInspecciónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA ORDENES DE INSPECCION")

        Dim frm As New frm_ActaInspeccionConsulta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ValidarOrdenesDeInspecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarOrdenesDeInspecciónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR ORDENES DE INSPECCION")

        Dim frm As New frm_ActaInspeccionValidar
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ValidarMovimientoDeCajaFuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarMovimientoDeCajaFuerteToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR MOVIMIENTO DE CAJA FUERTE")

        Dim frm As New frm_CajasFuertesMovValidar
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeCajasFuertesPorEdadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCajasFuertesPorEdadToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS DE CAJAS FUERTES POR EDAD")

        Dim frm As New frm_ConsultaCajasFuertes
        frm.ConsultaPorEdad = True
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeClientesEnListaNegraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeClientesEnListaNegraToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS DE CLIENTES EN LISTA NEGRA")

        Dim frm As New frm_ConsultaClientesListaNegra
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeBajaDeClientseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeBajaDeClientseToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS DE BAJA DE CLIENTES")

        Dim frm As New frm_ConsultaClientesBaja
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub BuscarActualizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarActualizaciónToolStripMenuItem.Click
        Call InstallUpdateSyncWithInfo()
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing
        Me.Cursor = Cursors.WaitCursor
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                Me.Cursor = Cursors.Default
                MsgBox("La actualización no se puede descargar en este momento. " + Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            Catch ioe As InvalidOperationException
                Me.Cursor = Cursors.Default
                MsgBox("Esta no es una Aplicacion ClickOnce. No se puede actualizar. Error: " & ioe.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Me.Cursor = Cursors.Default
                    Dim dr As DialogResult = MsgBox("Está disponible la nueva versión " & info.AvailableVersion.ToString & ". Desea Instalarla Ahora?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MsgBox("El Sistema ha detectado una actualización marcada como obligatoria. La versión mínima requerida es " & _
                        info.MinimumRequiredVersion.ToString() & _
                        ". Se instalará la Actualización y se reiniciará el Sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Text)
                End If
                Me.Cursor = Cursors.WaitCursor
                If (doUpdate) Then
                    Try
                        AD.Update()
                        Me.Cursor = Cursors.Default
                        MsgBox("La Actualización se instaló correctamente, El Sistema se reiniciará.", MsgBoxStyle.Exclamation, Me.Text)
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        Me.Cursor = Cursors.Default
                        MsgBox("No se pudo instalar la Actualziación. " & Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.Text)
                        Return
                    End Try
                End If
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No se encontraron Actualizaciones Disponibles.", MsgBoxStyle.Information, Me.Text)
            End If
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Esta no es una aplicación ClickOnce Válida.", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

    Private Sub SolicitudDeEquipoServicioYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeEquipoServicioYOtrosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SOLICITUD DE EQUIPO, SERVICIOS Y OTROS")

        Dim frm As New frm_ReporteFallasI
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeAlertasRecibidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAlertasRecibidasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS DE ALERTAS RECIBIDAS")

        Dim frm As New frm_AlertasConsultas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CambioDeRazonSocialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeRazonSocialToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIO DE RAZON SOCIAL")

        Dim frm As New frm_ClientesActualizar
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub DescargarManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargarManualDeUsuarioToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESCARGAR MANUAL DE USUARIO")

        Dim frm As New frm_DescargarArchivo
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub ModificarOrigenODestinoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarOrigenODestinoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: MODIFICAR ORIGEN DESTINO")

        Dim frm As New frm_ModificarOrigenDestino
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub BuscarClientesEnMapaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarClientesEnMapaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: MAPA CLIENTES")

        Dim frm As New frm_MapaClientes
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub MapaClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapaClientesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BUSCAR CLIENTE EN MAPA")

        Dim frm As New frm_MapaClientesBuscar
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ComoLlegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComoLlegarToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: COMO LLEGAR")

        Dim frm As New frm_MapaRutas
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ReporteGeneralDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteGeneralDeClientesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE GENERAL DE CLIENTES")

        Dim frm As New frm_ReporteGeneralClientes
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub InstanciasDeEvaluaciónYEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstanciasDeEvaluaciónYEmpleadosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: INSTANCIAS DE EVALUACION y EMPLEADOS")

        Dim frm As New frm_Instancias
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub ConsultaGeneralDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeneralDeCuentasToolStripMenuItem.Click
        SegundosDesconexion = 0

        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA GENERAL DE CUENTAS POR CLIENTE")

        Dim frm As New frm_CuentasBCliente
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CatalogoDeContratosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeContratosToolStripMenuItem.Click
        SegundosDesconexion = 0

        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: GENERAR CONTRATOS")

        Dim frm As New frm_Contratos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CatalgoDeClausulasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalgoDeClausulasToolStripMenuItem.Click

        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CLAUSULAS")

        Dim frm As New frm_Clausulas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ClonarServiciosYHorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClonarServiciosYHorariosToolStripMenuItem.Click
        SegundosDesconexion = 0

        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CLONAR SERVICIOS Y HORARIOS")

        Dim frm As New frm_ClonarServiciosHorarios
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ReporteGeneralDeHorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteGeneralDeHorariosToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE GENERAL DE HORARIOS")

        Dim frm As New frm_ReporteGeneralHorarios
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub GruposDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposDeClientesToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GRUPOS DE CLIENTES")

        Dim frm As New frm_ClientesGrupos
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConfiguracionDeAlertasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionDeAlertasToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONFIGURACION DE ALERTAS")

        Dim frm As New frm_ClientesAlertas
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub AdministracionDeCasetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministracionDeCasetToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ADMINISTRACION DE CASET")

        Dim frm As New frm_Kardex
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub AsignarCasetClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarCasetClienteToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ADMINISTRACION DE CASET")

        Dim frm As New frm_CasetAsignaCliente
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub
End Class
