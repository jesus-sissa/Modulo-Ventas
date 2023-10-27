Imports System.Data.SqlClient
Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_NuevoProspecto

    Public MensajeAlerta As String = ""

    Private Sub Frm_ClienteNuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_SeleccioneCP.Actualizar()
        cmb_Categoria.Actualizar()
        cmb_Giro.Actualizar()

        cmb_ZonaF.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ZonaF.Actualizar()

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
    End Sub

    Private Sub cmb_PaisC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PaisC.SelectedValueChanged
        If cmb_PaisC.Items.Count = 0 Then Exit Sub
        cmb_EstadoC.ActualizaValorParametro("@Id_Pais", cmb_PaisC.SelectedValue)
        cmb_EstadoC.Actualizar()
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
    End Sub

    Private Sub cmb_CiudadC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CiudadC.SelectedValueChanged
        If cmb_CiudadC.Items.Count = 0 Then Exit Sub
        cmb_ZonaC.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadC.SelectedValue)
        cmb_ZonaC.Actualizar()
    End Sub

    Private Sub Btn_Cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Foraneo As Char = "L"
        Dim RequiereMaterial As String
        Dim Tipo As String = ""

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

        If tbx_Latitud.Text = "" Then tbx_Latitud.Text = 0
        If tbx_Longitud.Text = "" Then tbx_Longitud.Text = 0

        If DatosGenerales_Validar() Then
            If rdb_ForaneoS.Checked Then Foraneo = "F"
            If rbn_MaterialSi.Checked Then RequiereMaterial = "S" Else RequiereMaterial = "N"
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
            End If
            Dim Prospecto As Integer = fn_Clientes_Crear(tbx_NombreF.Text, tbx_CalleF.Text, tbx_NumeroF.Text, tbx_IntF.Text, tbx_ColoniaF.Text, tbx_CPF.Text, _
                                                                     cmb_ZonaF.SelectedValue, tbx_RFC.Text, tbx_NombreC.Text, tbx_CalleC.Text, tbx_NumeroC.Text, tbx_IntC.Text, _
                                                                     cmb_ZonaC.SelectedValue, tbx_ColoniaC.Text, tbx_CPC.Text, cmb_Giro.SelectedValue, cmb_Categoria.SelectedValue, _
                                                                     tbx_ClaveRadio.Text, Foraneo, cmb_SeleccioneCP.SelectedValue, tbx_Latitud.Text, tbx_Longitud.Text, RequiereMaterial, MensajeAlerta, _
                                                                     Tipo, dtp_InicioOp.Value.Date, tbx_EntreF1.Text, tbx_EntreF2.Text, tbx_EntreC1.Text, tbx_EntreC2.Text, tbx_NombreCorto.Text, cbx_ClienteP.Checked)
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
        cmb_ZonaC.SelectedValue = "0"                               'Zona_Fiscal, 
        cmb_Giro.SelectedValue = "0"                                'Id_Giro, 
        cmb_Categoria.SelectedValue = "0"                           'Id_Categoria,  
        tbx_ClaveRadio.Clear()                                    'Clave_Radio,  
        tbx_Latitud.Clear()
        tbx_Longitud.Clear()
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
        tbx_NombreCorto.Clear()
        MensajeAlerta = ""
    End Sub

    Private Function DatosGenerales_Validar() As Boolean
        If cmb_SeleccioneCP.SelectedIndex = 0 AndAlso Not cbx_ClienteP.Checked Then
            MsgBox("Debe seleccionar si será un Cliente Padre, sino el que sería Padre del Prospecto a agregar" & Chr(13) & _
                   "o en su defecto, seleccionar ambas opciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Not rdb_Traslado.Checked And Not Rdb_SeguridadP.Checked And Not Rdb_Ambos.Checked And Not Rdb_CajaBancaria.Checked And Not Rdb_Otro.Checked Then
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

        If rbn_MaterialSi.Checked = False And rbn_MaterialNo.Checked = False Then
            MsgBox("Debe Indicar si el Cliente requiere Material Operativo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If dtp_InicioOp.Value < Today.Date Then
            MsgBox("La Fecha de Inicio de Operaciones debe ser mayor a la Fecha Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_InicioOp.Focus()
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

    Private Sub gbx_DatosF_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_DatosF.MouseHover, gbx_DatosC.MouseHover, Gbx_Botones.MouseHover, gbx_ClientePadre.MouseHover
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
            If lc_dr("Local_Foraneo") = "F" Then rdb_ForaneoS.Checked = True Else rdb_ForaneoN.Checked = True
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
End Class