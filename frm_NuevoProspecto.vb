Imports System.Data.SqlClient
Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_NuevoProspecto

    Public MensajeAlerta As String = ""

    Private Sub Frm_ClienteNuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'toolTip
        Dim toolTip As New ToolTip()

        toolTip.ShowAlways = True
        toolTip.SetToolTip(lbl_ComprobanteUUID, "Se genera cada mes en la primera factura.")
        toolTip.SetToolTip(lbl_UsarUUID, "1,2 y 9")
        toolTip.SetToolTip(lbl_CategoriaUUID, "Ejemplo: 'Oxxo poniente'")

        cmb_SeleccioneCP.Actualizar()

        cmb_Categoria.Actualizar()
        cmb_CFDI.Actualizar()

        cmb_Giro.Actualizar()

        cmb_ZonaF.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ZonaF.Actualizar()

        cmb_ColoniaF.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ColoniaF.Actualizar()
        cmb_ColoniaC.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ColoniaC.Actualizar()

        cmb_ZonaC.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ZonaC.Actualizar()

        cmb_CiudadF.AgregaParametro("@Id_Estado", -1, 1)
        cmb_CiudadF.Actualizar()

        cmb_CiudadC.AgregaParametro("@Id_Estado", -1, 1)
        cmb_CiudadC.Actualizar()

        cmb_EstadoF.AgregaParametro("@Id_Pais", -1, 1)
        cmb_EstadoF.Actualizar()

        cmb_EstadoC.AgregaParametro("@Id_Pais", -1, 1)
        cmb_EstadoC.Actualizar()

        cmb_PaisF.Actualizar()
        cmb_PaisC.Actualizar()

        dtp_InicioOp.Value = Today.Date

    End Sub

    Private Sub cmb_PaisF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PaisF.SelectedValueChanged
        If cmb_PaisF.Items.Count = 0 Then Exit Sub
        cmb_EstadoF.ActualizaValorParametro("@Id_Pais", cmb_PaisF.SelectedValue)
        cmb_EstadoF.Actualizar()
        cmb_EstadoF.Enabled = True
        cmb_CiudadF.Enabled = True
        tbx_CPF.Enabled = True
    End Sub

    Private Sub cmb_PaisC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PaisC.SelectedValueChanged
        If cmb_PaisC.Items.Count = 0 Then Exit Sub
        cmb_EstadoC.ActualizaValorParametro("@Id_Pais", cmb_PaisC.SelectedValue)
        cmb_EstadoC.Actualizar()
        cmb_EstadoC.Enabled = True
        cmb_CiudadC.Enabled = True
        tbx_CPC.Enabled = True
    End Sub

    Private Sub cmb_EstadoF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_EstadoF.SelectedValueChanged
        If cmb_EstadoF.Items.Count = 0 Then Exit Sub
        cmb_CiudadF.ActualizaValorParametro("@Id_Estado", cmb_EstadoF.SelectedValue)
        cmb_CiudadF.Actualizar()
    End Sub

    Private Sub cmb_EstadoC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_EstadoC.SelectedValueChanged
        If cmb_EstadoC.Items.Count = 0 Then Exit Sub
        cmb_CiudadC.ActualizaValorParametro("@Id_Estado", cmb_EstadoC.SelectedValue)
        cmb_CiudadC.Actualizar()
    End Sub

    Private Sub cmb_CiudadF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CiudadF.SelectedValueChanged
        If cmb_CiudadF.Items.Count = 0 Then Exit Sub
        cmb_ZonaF.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadF.SelectedValue)
        cmb_ZonaF.Actualizar()
        cmb_ColoniaF.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadF.SelectedValue)
        cmb_ColoniaF.Actualizar()
    End Sub

    Private Sub cmb_CiudadC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CiudadC.SelectedValueChanged
        If cmb_CiudadC.Items.Count = 0 Then Exit Sub
        cmb_ZonaC.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadC.SelectedValue)
        cmb_ZonaC.Actualizar()
        cmb_ColoniaC.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadC.SelectedValue)
        cmb_ColoniaC.Actualizar()
    End Sub

    Private Sub Btn_Cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Foraneo As Char = "L"
        Dim RequiereMaterial As String = ""
        Dim UtilizaCaset As String
        Dim UtilizaCatalogoDigital As String
        Dim Tipo As String = ""
        Dim EsCasetDelCliente As String
        Dim Envia_Correo As String = ""

        If cmb_ColoniaF.Text = "Seleccione..." Or cmb_ColoniaF.Text = "" Then
            MsgBox("Favor de seleccionar una colonia fiscal", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_ColoniaC.Text = "Seleccione..." Or cmb_ColoniaC.Text = "" Then
            MsgBox("Favor de seleccionar una colonia comercial", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_KM_CFDI.Text.Trim() = "" Then
            MsgBox("Favor de ingresar el KM CDFI.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_UsarUUID.Text.Trim() = "" Then
            MsgBox("Favor de ingresar el Usa UUID.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If ValidarCodigoPostalesGuardar() Then
            MsgBox("Alugunos de los Codigos Postales estan erroneos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_ZonaF.Text = "Seleccione..." Or cmb_ZonaC.Text = "Seleccione..." Then
            MsgBox("Favor de seleccionar una Zona.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_NumeroF.Text = "" Then tbx_NumeroF.Text = "0"
        If tbx_NumeroC.Text = "" Then tbx_NumeroC.Text = "0"
        If tbx_NumeroF.Text.Trim.Contains("-") Then
            MsgBox("El número exterior parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NumeroF.Focus()
            Exit Sub
        End If
        If tbx_NumeroC.Text.Trim.Contains("-") Then
            MsgBox("El número exterior parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NumeroC.Focus()
            Exit Sub
        End If

        If rdb_EnviarCorreoSI.Checked And tbx_Correo.Text.Trim = "" Then
            MsgBox("Favor de introducir el Correo para enviar facturas", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Correo.Focus()
            Exit Sub
        End If

        If tbx_Latitud.Text = "" Then tbx_Latitud.Text = 0
        If tbx_Longitud.Text = "" Then tbx_Longitud.Text = 0
        ' If tbx_KM_CFDI.Text = "" Then tbx_KM_CFDI.Text = 0
        If tbx_ComprobanteUUID.Text = "" Then tbx_ComprobanteUUID.Text = ""
        If tbx_UsarUUID.Text = "" Then tbx_UsarUUID.Text = 0
        If tbx_Correo.Text = "" Then tbx_Correo.Text = ""

        If tbx_Categoria.Text = "" Then tbx_Categoria.Text = ""

        If DatosGenerales_Validar() Then
            If rdb_ForaneoS.Checked Then Foraneo = "F"
            If rbn_MaterialSi.Checked Then RequiereMaterial = "S" Else RequiereMaterial = "N"
            If rbn_UtilizaCasetSI.Checked Then UtilizaCaset = "S" Else UtilizaCaset = "N"
            If rbn_UtilizaCatalogoDigitalSI.Checked Then UtilizaCatalogoDigital = "S" Else UtilizaCatalogoDigital = "N"
            If rdb_CasetPropioSI.Checked Then EsCasetDelCliente = "S" Else EsCasetDelCliente = "N"

            If rdb_EnviarCorreoSI.Checked Then Envia_Correo = "S" Else Envia_Correo = "N"


            If rdb_Traslado.Checked Then
                Tipo = "1"
            ElseIf Rdb_SeguridadP.Checked Then
                Tipo = "2"
            ElseIf Rdb_Ambos.Checked Then
                Tipo = "3"
            ElseIf Rdb_CajaBancaria.Checked Then
                Tipo = "4"
            ElseIf Rdb_Otro.Checked Then
                Tipo = "5"
            ElseIf rdb_CajerosAut.Checked Then
                Tipo = "6"
            End If
            Dim Prospecto As Integer = fn_Clientes_Crear(tbx_NombreF.Text,
                                                         tbx_CalleF.Text,
                                                         tbx_NumeroF.Text,
                                                         tbx_IntF.Text,
                                                         cmb_ColoniaF.Text, 'tbx_ColoniaF.Text,
                                                         tbx_CPF.Text,
                                                         cmb_ZonaF.SelectedValue,
                                                         tbx_RFC.Text,
                                                         tbx_NombreC.Text,
                                                         tbx_CalleC.Text,
                                                         tbx_NumeroC.Text,
                                                         tbx_IntC.Text,
                                                         cmb_ZonaC.SelectedValue,
                                                         cmb_ColoniaC.Text, 'tbx_ColoniaC.Text,
                                                         tbx_CPC.Text,
                                                         cmb_Giro.SelectedValue,
                                                         cmb_Categoria.SelectedValue,
                                                         tbx_ClaveRadio.Text,
                                                         Foraneo,
                                                         cmb_SeleccioneCP.SelectedValue,
                                                         tbx_Latitud.Text,
                                                         tbx_Longitud.Text,
                                                         RequiereMaterial,
                                                         MensajeAlerta,
                                                         Tipo,
                                                         dtp_InicioOp.Value.Date,
                                                         tbx_EntreF1.Text,
                                                         tbx_EntreF2.Text,
                                                         tbx_EntreC1.Text,
                                                         tbx_EntreC2.Text,
                                                         tbx_NombreCorto.Text,
                                                         cbx_ClienteP.Checked,
                                                         UtilizaCaset,
                                                         UtilizaCatalogoDigital,
                                                         cmb_CFDI.SelectedValue,
                                                         tbx_KM_CFDI.Text,
                                                         tbx_ComprobanteUUID.Text,
                                                         tbx_UsarUUID.Text,
                                                         tbx_Categoria.Text,
                                                         EsCasetDelCliente,
                                                         Envia_Correo,
                                                         tbx_Correo.Text)
            If Not Prospecto = 0 Then
                MsgBox("Se acaba de crear un Prospecto con la Clave: " & Prospecto, MsgBoxStyle.Information, frm_MENU.Text)
                cbx_ClienteP.Checked = False
                cmb_SeleccioneCP.SelectedValue = 0
            Else
                MsgBox("Ha ocurrido un error al intentar crear el nuevo Prospecto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
        End If
    End Sub

    Protected Sub LimpiarCasillas()
        SegundosDesconexion = 0

        tbx_NombreF.Clear()                                       'Nombre_Fiscal, 
        tbx_CalleF.Clear()                                        'Direccion_Fiscal, 
        tbx_NumeroF.Clear()
        tbx_IntF.Clear()
        tbx_ColoniaF.Clear()
        tbx_CPF.Clear()
        tbx_EntreF1.Clear()
        tbx_EntreF2.Clear()
        cmb_PaisF.SelectedValue = "0"                               'Id_Pais
        cmb_EstadoF.SelectedValue = "0"                             'Id_Estado
        cmb_CiudadF.SelectedValue = "0"                             'Id_Ciudad
        cmb_ColoniaF.SelectedValue = "0"
        cmb_ZonaF.SelectedValue = "0"                               'Id_Zona
        tbx_RFC.Clear()                                           'RFC,
        tbx_NombreC.Clear()                                       'Nombre_Comercial, 
        tbx_CalleC.Clear()                                        'Direccion_Comercial, 
        tbx_NumeroC.Clear()
        tbx_IntC.Clear()
        tbx_ColoniaC.Clear()
        tbx_CPC.Clear()
        tbx_EntreC1.Clear()
        tbx_EntreC2.Clear()
        cmb_PaisC.SelectedValue = "0"                               'Id_Pais
        cmb_EstadoC.SelectedValue = "0"                             'Id_Estado
        cmb_CiudadC.SelectedValue = "0"                             'Id_Ciudad
        cmb_ZonaC.SelectedValue = "0"                               'Id_Zona
        cmb_PaisC.SelectedValue = "0"                               'Id_Pais
        cmb_EstadoC.SelectedValue = "0"                             'Id_Estado
        cmb_CiudadC.SelectedValue = "0"                             'Id_Ciudad
        cmb_ColoniaC.SelectedValue = "0"
        cmb_ZonaC.SelectedValue = "0"                               'Zona_Fiscal, 
        cmb_Giro.SelectedValue = "0"                                'Id_Giro, 

        cmb_Categoria.SelectedValue = "0"                           'Id_Categoria,  
        cmb_CFDI.SelectedValue = "0"

        tbx_ClaveRadio.Clear()                                    'Clave_Radio,  

        tbx_Latitud.Clear()
        tbx_Longitud.Clear()

        tbx_KM_CFDI.Clear()
        tbx_ComprobanteUUID.Clear()
        tbx_UsarUUID.Clear()
        tbx_Categoria.Clear()

        rdb_ForaneoS.Checked = False
        rdb_ForaneoN.Checked = False
        rbn_MaterialSi.Checked = False
        rbn_MaterialNo.Checked = False
        rtb_MensajeAlerta.Clear()
        rdb_Traslado.Checked = False
        Rdb_SeguridadP.Checked = False
        Rdb_Ambos.Checked = False
        Rdb_CajaBancaria.Checked = False
        Rdb_Otro.Checked = False
        rdb_CajerosAut.Checked = False
        tbx_NombreCorto.Clear()
        MensajeAlerta = ""
    End Sub

    Private Function DatosGenerales_Validar() As Boolean

        If cmb_SeleccioneCP.SelectedIndex = 0 AndAlso Not cbx_ClienteP.Checked Then
            MsgBox("Debe seleccionar si será un Cliente Padre, sino el que sería Padre del Prospecto a agregar" & Chr(13) &
                   "o en su defecto, seleccionar ambas opciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Not rdb_Traslado.Checked And Not Rdb_SeguridadP.Checked And Not Rdb_Ambos.Checked And Not Rdb_CajaBancaria.Checked And Not Rdb_Otro.Checked And Not rdb_CajerosAut.Checked Then
            MsgBox("Debe Indicar el Tipo de Cliente (Traslado, Seg. Patrimonial, etc.).", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If tbx_NombreC.Text = "" Then
            MsgBox("Debe Indicar el Tipo de Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreC.Focus()
            Return False
        End If

        If cmb_ZonaC.SelectedValue = "0" Then
            MsgBox("Debe Indicar la Zona para la Dirección Comercial.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ZonaC.Focus()
            Return False
        End If

        If cmb_Giro.SelectedValue = "0" Then
            MsgBox("Debe Indicar el Giro Comercial.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Giro.Focus()
            Return False
        End If
        If cmb_Categoria.SelectedValue = "0" Then
            MsgBox("Debe Indicar la Categoría del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Categoria.Focus()
            Return False
        End If

        If cmb_CFDI.SelectedValue = "0" Then
            MsgBox("Indicar si es ESTATAL o FEDERAL del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CFDI.Focus()
            Return False
        End If

        If rbn_MaterialSi.Checked = False And rbn_MaterialNo.Checked = False Then
            MsgBox("Debe Indicar si el Cliente requiere Material Operativo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If rbn_UtilizaCasetSI.Checked = False And rbn_UtilizaCasetNO.Checked = False Then
            MsgBox("Debe Indicar si el Cliente Utiliza Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If rbn_UtilizaCatalogoDigitalSI.Checked = False And rbn_UtilizaCatalogoDigitalNO.Checked = False Then
            MsgBox("Debe Indicar si el Cliente utiliza Catalogo Digital.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If dtp_InicioOp.Value < Today.Date Then
            MsgBox("La Fecha de Inicio de Operaciones debe ser mayor a la Fecha Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_InicioOp.Focus()
            Return False
        End If

        If tbx_CPF.Text = "" Then
            MsgBox("Debe Indicar el Codigo Postal Fiscal.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CPF.Focus()
            Return False
        End If

        If tbx_CPC.Text = "" Then
            MsgBox("Debe Indicar el Codigo Postal Comercial.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CPC.Focus()
            Return False
        End If

        If cmb_ColoniaF.Text = "" Then
            MsgBox("Debe de indicar la Colonia Fiscal del cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ColoniaF.Focus()
            Return False
        End If

        If cmb_ColoniaC.Text = "" Then
            MsgBox("Debe de indicar la Colonia Comecial del cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ColoniaC.Focus()
            Return False
        End If

        If tbx_CalleF.Text = "" Then
            MsgBox("Debe de ingresar la Calle Fiscal del cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CalleF.Focus()
            Return False
        End If

        If tbx_CalleC.Text = "" Then
            MsgBox("Debe de ingresar la Calle Comercial del cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CalleC.Focus()
            Return False
        End If

        If tbx_RFC.Text = "" Then
            MsgBox("Debe Indicar el RFC del cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_RFC.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Cliente = True

        frm.ShowDialog()

        tbx_SeleccioneCP.Text = frm.Clave
    End Sub

    Private Sub gbx_DatosF_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReasignarCPF.MouseHover, gbx_DatosC.MouseHover, Gbx_Botones.MouseHover, gbx_ClientePadre.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_MensajeAlerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MensajeAlerta.Click
        SegundosDesconexion = 0

        Dim frm As New frm_MensajeAlerta
        frm.MensajeFinal = MensajeAlerta
        frm.ShowDialog()
        If frm.DialogResult <> Windows.Forms.DialogResult.Cancel Then
            MensajeAlerta = frm.MensajeFinal
            rtb_MensajeAlerta.Text = frm.MensajeTexto
        End If

    End Sub

    Private Sub dtp_InicioOp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_InicioOp.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then btn_Guardar.Focus()
    End Sub

    Private Sub cmb_SeleccioneCP_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_SeleccioneCP.SelectedValueChanged
        SegundosDesconexion = 0

        ''---prueba de clave padre he hijo
        'If cmb_SeleccioneCP.SelectedValue > 0 AndAlso tbx_SeleccioneCP.Text <> "" Then
        '    tbx_claveProspectoNew.Text = tbx_SeleccioneCP.Text & "-"
        'Else
        '    tbx_claveProspectoNew.Text = ""
        'End If
        'tbx_claveProspectoNew.Enabled = cmb_SeleccioneCP.SelectedValue > 0
        ''-------------

        If cmb_SeleccioneCP.Items.Count = 0 OrElse cmb_SeleccioneCP.SelectedValue = 0 Then
            Call LimpiarCasillas()
            Exit Sub
        End If

        Dim lc_dr As DataRow = fn_Clientes_Generales(cmb_SeleccioneCP.SelectedValue)

        If lc_dr IsNot Nothing Then
            tbx_NombreF.Text = lc_dr("Nombre_Fiscal")
            tbx_CalleF.Text = lc_dr("Calle_Fiscal")
            tbx_NumeroF.Text = lc_dr("Numero_Fiscal")
            tbx_IntF.Text = lc_dr("NumeroInt_Fiscal")
            tbx_ColoniaF.Text = lc_dr("Colonia_Fiscal")
            tbx_CPF.Text = lc_dr("CP_Fiscal")

            Dim Dr_Lugar As DataRow
            If lc_dr("Zona_Fiscal") > 0 Then
                Dr_Lugar = fn_Clientes_Lugar(lc_dr("Zona_Fiscal"))
                If Dr_Lugar IsNot Nothing Then
                    cmb_PaisF.SelectedValue = Dr_Lugar("Id_Pais")
                    cmb_EstadoF.SelectedValue = Dr_Lugar("Id_Estado")
                    cmb_CiudadF.SelectedValue = Dr_Lugar("Id_Ciudad")
                    cmb_ZonaF.SelectedValue = Dr_Lugar("Id_Zona")
                End If
            End If
            tbx_RFC.Text = lc_dr("RFC")

            If lc_dr("Zona_Fiscal") = lc_dr("Zona_Comercial") Then
                cmb_PaisC.SelectedValue = cmb_PaisF.SelectedValue
                cmb_EstadoC.SelectedValue = cmb_EstadoF.SelectedValue
                cmb_CiudadC.SelectedValue = cmb_CiudadF.SelectedValue
                cmb_ZonaC.SelectedValue = cmb_ZonaF.SelectedValue
            ElseIf lc_dr("Zona_Comercial") > 0 Then
                Dr_Lugar = fn_Clientes_Lugar(lc_dr("Zona_Comercial"))
                If Dr_Lugar IsNot Nothing Then
                    cmb_PaisC.SelectedValue = Dr_Lugar("Id_Pais")
                    cmb_EstadoC.SelectedValue = Dr_Lugar("Id_Estado")
                    cmb_CiudadC.SelectedValue = Dr_Lugar("Id_Ciudad")
                    cmb_ZonaC.SelectedValue = Dr_Lugar("Id_Zona")
                End If
            End If
            cmb_Giro.SelectedValue = lc_dr("Id_Giro")

            cmb_Categoria.SelectedValue = lc_dr("Id_Categoria")
            cmb_CFDI.SelectedValue = lc_dr("Id_CFDI")

            If lc_dr("Local_Foraneo") = "F" Then rdb_ForaneoS.Checked = True Else rdb_ForaneoN.Checked = True

            cmb_ColoniaF.Text = lc_dr("Colonia_Fiscal")

            'If lc_dr("Caset_Propio") = "SI" Then rdb_CasetPropioSI.Checked = True Else rdb_CasetPropioNO.Checked = True

            cmb_EstadoF.Enabled = True
            cmb_CiudadF.Enabled = True
            cmb_EstadoC.Enabled = True
            cmb_CiudadC.Enabled = True

            ValidarCodigoPostalesMostrar()
        End If
    End Sub

    'Private Sub tbx_claveProspectoNew_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_claveProspectoNew.KeyPress
    '    '3 es fijo porke hijo solo tiene 3 digitos

    '    If (CInt(tbx_claveProspectoNew.Text.Length) - (CInt(tbx_SeleccioneCP.Text.Length) + 1)) >= 3 Then
    '        If Asc(e.KeyChar) = 8 Then
    '            'borrar-retroceso = 8
    '            e.Handled = False ' avanza
    '        Else
    '            e.Handled = True ' no avanza
    '        End If
    '        Exit Sub
    '    End If

    '    If cmb_SeleccioneCP.SelectedValue > 0 AndAlso tbx_claveProspectoNew.Text.Length = CInt(tbx_SeleccioneCP.Text.Length) + 1 Then
    '        If Asc(e.KeyChar) = 8 Then
    '            'borrar-retroceso = 8
    '            e.Handled = True 'no avanza
    '        Else
    '            e.Handled = False
    '        End If
    '    Else
    '        e.Handled = False 'avanza
    '    End If
    'End Sub

    'Private Sub tbx_SeleccioneCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_SeleccioneCP.TextChanged
    '    ''---prueba de clave padre he hijo
    '    If cmb_SeleccioneCP.SelectedValue > 0 AndAlso tbx_SeleccioneCP.Text <> "" Then
    '        tbx_claveProspectoNew.Text = tbx_SeleccioneCP.Text & "-"
    '    Else
    '        tbx_claveProspectoNew.Text = ""
    '    End If
    '    tbx_claveProspectoNew.Enabled = cmb_SeleccioneCP.SelectedValue > 0

    'End Sub

    Private Sub cbx_ClienteP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ClienteP.CheckedChanged
        If cbx_ClienteP.Checked Then
            tbx_SeleccioneCP.Enabled = False
            cmb_SeleccioneCP.Enabled = False
            btn_Buscar.Enabled = False
        Else
            tbx_SeleccioneCP.Enabled = True
            cmb_SeleccioneCP.Enabled = True
            btn_Buscar.Enabled = True
        End If
    End Sub

    Private Sub lbl_KM_CFDI_Click(sender As Object, e As EventArgs) Handles lbl_KM_CFDI.Click

    End Sub

    Private Sub buscarLugarF(sender As Object, e As KeyPressEventArgs) Handles tbx_CPF.KeyPress

        If tbx_CPF.TextLength > 0 AndAlso Asc(e.KeyChar) = Keys.Enter Then


            Dim Dr_Lugar As DataTable = fn_BuscarLugar(tbx_CPF.Text)

            If Dr_Lugar IsNot Nothing Then

                'cmb_PaisF.SelectedValue = Dr_Lugar.Rows(0)("id_Pais").ToString()
                'cmb_EstadoF.SelectedValue = Dr_Lugar.Rows(0)("id_Estado").ToString()
                'cmb_CiudadF.SelectedValue = Dr_Lugar.Rows(0)("id_Ciudad").ToString()

                'cmb_ZonaF.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadF.SelectedValue)
                'cmb_ZonaF.Actualizar()
                'cmb_ColoniaF.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadF.SelectedValue)
                'cmb_ColoniaF.Actualizar()

                cmb_PaisF.SelectedValue = Dr_Lugar.Rows(0)("id_Pais").ToString()
                cmb_EstadoF.SelectedValue = Dr_Lugar.Rows(0)("id_Estado").ToString()
                cmb_CiudadF.SelectedValue = Dr_Lugar.Rows(0)("id_Ciudad").ToString()
                cmb_ColoniaF.DataSource = Dr_Lugar
                cmb_ColoniaF.DisplayMember = "nombre"
                cmb_ColoniaF.ValueMember = "Id_Colonia"

                cmb_EstadoF.Enabled = False
                cmb_CiudadF.Enabled = False

            Else
                MsgBox("El Codigo Postal es erroneo.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub buscarLugarC(sender As Object, e As KeyPressEventArgs) Handles tbx_CPC.KeyPress

        If tbx_CPC.TextLength > 0 AndAlso Asc(e.KeyChar) = Keys.Enter Then

            Dim Dr_Lugar As DataTable = fn_BuscarLugar(tbx_CPC.Text)

            If Dr_Lugar IsNot Nothing Then

                'cmb_PaisC.SelectedValue = Dr_Lugar.Rows(0)("id_Pais").ToString()
                'cmb_EstadoC.SelectedValue = Dr_Lugar.Rows(0)("id_Estado").ToString()
                'cmb_CiudadC.SelectedValue = Dr_Lugar.Rows(0)("id_Ciudad").ToString()

                'cmb_ZonaC.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadC.SelectedValue)
                'cmb_ZonaC.Actualizar()
                'cmb_ColoniaC.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadC.SelectedValue)
                'cmb_ColoniaC.Actualizar()

                cmb_PaisC.SelectedValue = Dr_Lugar.Rows(0)("id_Pais").ToString()
                cmb_EstadoC.SelectedValue = Dr_Lugar.Rows(0)("id_Estado").ToString()
                cmb_CiudadC.SelectedValue = Dr_Lugar.Rows(0)("id_Ciudad").ToString()
                cmb_ColoniaC.DataSource = Dr_Lugar
                cmb_ColoniaC.DisplayMember = "nombre"
                cmb_ColoniaC.ValueMember = "Id_Colonia"

                cmb_EstadoC.Enabled = False
                cmb_CiudadC.Enabled = False

            Else
                MsgBox("El Codigo Postal es erroneo.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub gbx_DatosC_Enter(sender As Object, e As EventArgs) Handles gbx_DatosC.Enter

    End Sub

    Private Sub cmb_ColoniaC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ColoniaC.SelectedIndexChanged

    End Sub

    Private Sub cmb_ColoniaC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_ColoniaC.SelectedValueChanged
        tbx_ColoniaC.Text = cmb_ColoniaC.Text
    End Sub

    Private Sub tbx_CPC_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_CPC.KeyDown

        If e.KeyData = Keys.Back And tbx_CPC.Text = "" Then
            cmb_EstadoC.Enabled = True
            cmb_CiudadC.Enabled = True
        End If

    End Sub

    Private Sub tbx_CPF_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_CPF.KeyDown
        If e.KeyData = Keys.Back And tbx_CPF.Text = "" Then
            cmb_EstadoF.Enabled = True
            cmb_CiudadF.Enabled = True
        End If
    End Sub

    Private Sub cmb_ColoniaF_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_ColoniaF.SelectedValueChanged
        tbx_ColoniaF.Text = cmb_ColoniaF.Text
    End Sub

    ''' <summary>
    ''' Este metodo sirve para validar si el codigo postal existe o no existe. En caso de que no exista se pintara de rojo.
    ''' </summary>
    Private Sub ValidarCodigoPostalesMostrar()

        tbx_CPF.ForeColor = Color.Black
        tbx_CPC.ForeColor = Color.Black

        Dim validarCodigoPostalF As DataTable = fn_BuscarLugar(tbx_CPF.Text)
        Dim validarCodigoPostalC As DataTable = fn_BuscarLugar(tbx_CPC.Text)

        If validarCodigoPostalF Is Nothing Then
            tbx_CPF.ForeColor = Color.Red
        End If

        If validarCodigoPostalC Is Nothing Then
            tbx_CPC.ForeColor = Color.Red
        End If

    End Sub

    ''' <summary>
    ''' Este metodo nos sirve para asegurara que no se guarden los datos del cliente si algun codigo postal es incorrectos
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidarCodigoPostalesGuardar() As Boolean

        Dim validarCodigoPostalF As DataTable = fn_BuscarLugar(tbx_CPF.Text)
        Dim validarCodigoPostalC As DataTable = fn_BuscarLugar(tbx_CPC.Text)

        If validarCodigoPostalF Is Nothing Then
            Return True
        ElseIf validarCodigoPostalC Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmb_ColoniaF_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_ColoniaF.SelectionChangeCommitted
        Dim colonias As DataTable
        colonias = cmb_ColoniaF.DataSource
        tbx_CPF.Text = ""

        Try
            If colonias IsNot Nothing Then
                For i As Integer = 0 To colonias.Rows.Count - 1
                    If cmb_ColoniaF.Text = colonias.Rows(i)("nombre").ToString() Then
                        tbx_CPF.Text = colonias.Rows(i)("c_CodigoPostal").ToString()
                        tbx_CPF.Enabled = False
                        cmb_CiudadF.Enabled = False
                        cmb_EstadoF.Enabled = False
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Lo sentimos algo salio mal, favor de repotar al departamento de Tecnologia.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_PaisF_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_PaisF.SelectionChangeCommitted
        tbx_CPF.Text = ""
    End Sub

    Private Sub cmb_ColoniaC_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_ColoniaC.SelectionChangeCommitted
        Dim colonias As DataTable
        colonias = cmb_ColoniaC.DataSource
        tbx_CPC.Text = ""
        Try
            If colonias IsNot Nothing Then
                For i As Integer = 0 To colonias.Rows.Count - 1
                    If cmb_ColoniaC.Text = colonias.Rows(i)("nombre").ToString() Then
                        tbx_CPC.Text = colonias.Rows(i)("c_CodigoPostal").ToString()
                        tbx_CPC.Enabled = False
                        cmb_CiudadC.Enabled = False
                        cmb_EstadoC.Enabled = False
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Lo sentimos algo salio mal, favor de repotar al departamento de Tecnologia.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try

    End Sub

    Private Sub cmb_PaisC_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_PaisC.SelectionChangeCommitted
        tbx_CPC.Text = ""
    End Sub

    Private Sub rdb_EnviarCorreoSI_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_EnviarCorreoSI.CheckedChanged
        tbx_Correo.Enabled = rdb_EnviarCorreoSI.Checked
    End Sub

    Private Sub rdb_EnviarCorreoNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_EnviarCorreoNo.CheckedChanged
        tbx_Correo.Enabled = Not rdb_EnviarCorreoNo.Checked
        tbx_Correo.Text = ""
    End Sub

    Private Sub Btn_AgregarColoniaComercial_Click(sender As Object, e As EventArgs) Handles Btn_AgregarColoniaComercial.Click
        If tbx_CPC.Text.Trim() <> "" Then
            frm_AgregarColonia.tbx_CodigoPostal.Text = tbx_CPC.Text.Trim()
            frm_AgregarColonia.ShowDialog()
        Else
            MsgBox("Favor de introducir el codigo postal", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CPC.Focus()
        End If
    End Sub

    Private Sub Btn_AgregarColoniaFiscal_Click(sender As Object, e As EventArgs) Handles Btn_AgregarColoniaFiscal.Click
        If tbx_CPF.Text.Trim() <> "" Then
            frm_AgregarColonia.tbx_CodigoPostal.Text = tbx_CPF.Text.Trim()
            frm_AgregarColonia.ShowDialog()
        Else
            MsgBox("Favor de introducir el codigo postal", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CPF.Focus()
        End If
    End Sub

    Private Sub btnReasignarCPF_Click(sender As Object, e As EventArgs) Handles btnReasignarCPF.Click
        If tbx_CPF.Text.Trim() <> "" Then
            frm_ReasignarCodigoPostal.tbx_CodigoPostal.Text = tbx_CPF.Text.Trim()
            frm_ReasignarCodigoPostal.ShowDialog()
        Else
            MsgBox("Favor de introducir el codigo postal", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CPF.Focus()
        End If
    End Sub

    Private Sub btnReasignarCPC_Click(sender As Object, e As EventArgs) Handles btnReasignarCPC.Click
        If tbx_CPC.Text.Trim() <> "" Then
            frm_ReasignarCodigoPostal.tbx_CodigoPostal.Text = tbx_CPC.Text.Trim()
            frm_ReasignarCodigoPostal.ShowDialog()
        Else
            MsgBox("Favor de introducir el codigo postal", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CPC.Focus()
        End If
    End Sub
End Class