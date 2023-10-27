Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class frm_ClientesActualizar

    Dim Dt_Subclientes As New DataTable

    Private Sub frm_Clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()

        cmb_ZonaF.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ZonaF.Actualizar()
        cmb_CiudadF.AgregaParametro("@Id_Estado", -1, 1)
        cmb_CiudadF.Actualizar()
        cmb_EstadoF.AgregaParametro("@Id_Pais", -1, 1)
        cmb_EstadoF.Actualizar()
        cmb_PaisF.Actualizar()
        dtp_Inicio.Value = Today.Date

        Dt_Subclientes.Columns.Add("Id_Subcliente", GetType(Integer))
    End Sub

    Sub Limpiar()
        'Datos Generales
        tbx_NombreF.Clear()
        tbx_RFC.Clear()
        tbx_CalleF.Clear()
        tbx_EntreF1.Clear()
        tbx_EntreF2.Clear()
        tbx_ColoniaF.Clear()
        tbx_NumeroF.Clear()
        tbx_IntF.Clear()
        tbx_CPF.Clear()
        tbx_ClvFactAnt.Clear()
        tbx_ClvFactN.Clear()
        dtp_Inicio.Value = Today.Date
        rtb_Observaciones.Clear()
        cmb_PaisF.SelectedValue = "0"
        cmb_EstadoF.SelectedValue = "0"
        cmb_CiudadF.SelectedValue = "0"
        cmb_ZonaF.SelectedValue = "0"
        chk_Fiscales.Checked = False
    End Sub

    Sub DatosFiscales_Llenar()
        chk_Fiscales.Checked = False
        chk_Fiscales.Enabled = False
        btn_Guardar.Enabled = False
        If cmb_Cliente.SelectedValue = 0 Then Exit Sub
        Dim Dr_DatosGenerales As DataRow = fn_Clientes_Generales(cmb_Cliente.SelectedValue)

        tbx_ClvFactAnt.Text = Dr_DatosGenerales("Clave_Facturacion")
        tbx_NombreF.Text = Dr_DatosGenerales("Nombre_Fiscal")
        tbx_RFC.Text = Dr_DatosGenerales("RFC")
        tbx_CalleF.Text = Dr_DatosGenerales("Calle_Fiscal")
        tbx_NumeroF.Text = Dr_DatosGenerales("Numero_Fiscal")
        tbx_IntF.Text = Dr_DatosGenerales("NumeroInt_Fiscal")
        tbx_ColoniaF.Text = Dr_DatosGenerales("Colonia_Fiscal")
        tbx_CPF.Text = Dr_DatosGenerales("CP_Fiscal")
        tbx_EntreF1.Text = Dr_DatosGenerales("EntreCalle_Fiscal1")
        tbx_EntreF2.Text = Dr_DatosGenerales("EntreCalle_Fiscal2")

        'Se obtiene los datos del país, estado, ciudad y zona para fiscal
        If Dr_DatosGenerales("Zona_Fiscal") > 0 Then
            Dim Dr_Lugar As DataRow = fn_Clientes_Lugar(Dr_DatosGenerales("Zona_Fiscal"))
            If Dr_Lugar IsNot Nothing Then
                cmb_PaisF.SelectedValue = Dr_Lugar("Id_Pais")
                cmb_EstadoF.SelectedValue = Dr_Lugar("Id_Estado")
                cmb_CiudadF.SelectedValue = Dr_Lugar("Id_Ciudad")
                cmb_ZonaF.SelectedValue = Dr_Lugar("Id_Zona")
            End If
        End If
        btn_Guardar.Enabled = True
        chk_Fiscales.Enabled = True
    End Sub

    Private Sub cmb_Padre_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        Call Limpiar()
        Call DatosFiscales_Llenar()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Cliente = True
        frm.Consulta = Frm_BuscarCliente.Query.Clientes
        frm.ShowDialog()

        tbx_Cliente.Text = frm.Clave
    End Sub

    Private Sub cmb_PaisF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PaisF.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_PaisF.Items.Count = 0 Then Exit Sub
        cmb_EstadoF.ActualizaValorParametro("@Id_Pais", cmb_PaisF.SelectedValue)
        cmb_EstadoF.Actualizar()
    End Sub

    Private Sub cmb_EstadoF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_EstadoF.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_EstadoF.Items.Count = 0 Then Exit Sub
        cmb_CiudadF.ActualizaValorParametro("@Id_Estado", cmb_EstadoF.SelectedValue)
        cmb_CiudadF.Actualizar()
    End Sub

    Private Sub cmb_CiudadF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CiudadF.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_CiudadF.Items.Count = 0 Then Exit Sub
        cmb_ZonaF.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadF.SelectedValue)
        cmb_ZonaF.Actualizar()
    End Sub

    Private Sub dtp_Inicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Inicio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then rtb_Observaciones.Focus()
    End Sub

    Private Sub chk_Fiscales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Fiscales.CheckedChanged
        SegundosDesconexion = 0

        If chk_Fiscales.Checked Then
            Dim frm As New frm_BuscarSubClientes
            frm.Id_Padre = cmb_Cliente.SelectedValue
            frm.Consulta = frm_BuscarSubClientes.Query.InfoFiscal
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                'Al palomear subclientes en la ventana modal se pasa esa información a un dt para gestionar los valores
                For Each ModalSubClientes As ListViewItem In frm.lsv_Clientes.CheckedItems
                    Dt_Subclientes.Rows.Add(ModalSubClientes.Tag)
                Next
            Else
                'Si se dio cancelar se despalomea el checkbox para no generar confusión.
                chk_Fiscales.Checked = False
                Dt_Subclientes.Rows.Clear()
            End If
        Else
            Dt_Subclientes.Rows.Clear()
        End If
    End Sub

    Private Sub chk_Fiscales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Fiscales.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then btn_Guardar.Focus()
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_NombreF.Text.Trim = "" Then
            MsgBox("Debe de agregar el Nombre Fiscal del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreF.Focus()
            Exit Sub
        End If
        If tbx_RFC.Text.Trim = "" Then
            MsgBox("Debe de agregar el RFC del Cliente", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_RFC.Focus()
            Exit Sub
        End If
        If tbx_CalleF.Text.Trim = "" Then
            MsgBox("Debe de agregar la Calle Fiscal del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CalleF.Focus()
            Exit Sub
        End If
        If cmb_PaisF.SelectedValue = "0" Then
            MsgBox("Debe de seleccionar el País donde se ubica el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PaisF.Focus()
            Exit Sub
        End If
        If cmb_EstadoF.SelectedValue = "0" Then
            MsgBox("Debe de seleccionar el Estado donde se ubica el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_EstadoF.Focus()
            Exit Sub
        End If
        If cmb_CiudadF.SelectedValue = "0" Then
            MsgBox("Debe de seleccionar la Ciudad donde se ubica el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CiudadF.Focus()
            Exit Sub
        End If
        If cmb_ZonaF.SelectedValue = "0" Then
            MsgBox("Debe de seleccionar la Zona donde se ubica el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ZonaF.Focus()
            Exit Sub
        End If
        'Datos para el Historial de los cambios realizados
        If rtb_Observaciones.Text.Trim.Length < 10 Then
            MsgBox("Debe de indicar Observaciones más descriptivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Observaciones.Focus()
            Exit Sub
        End If

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()

        If Not frm.Firma Then
            btn_Guardar.Focus()
            Exit Sub
        End If

        If tbx_NumeroF.Text.Trim = "" Then tbx_NumeroF.Text = "0"
        If tbx_CPF.Text.Trim = "" Then tbx_CPF.Text = "0"

        If fn_Clientes_GuardarRS(cmb_Cliente.SelectedValue, tbx_NombreF.Text.Trim, tbx_CalleF.Text.Trim, CInt(tbx_NumeroF.Text.Trim), tbx_EntreF1.Text.Trim, _
                                 tbx_EntreF2.Text.Trim, tbx_IntF.Text.Trim, tbx_ColoniaF.Text.Trim, CInt(tbx_CPF.Text.Trim), cmb_ZonaF.SelectedValue, tbx_RFC.Text.Trim, _
                                 tbx_ClvFactAnt.Text.Trim, tbx_ClvFactN.Text.Trim, rtb_Observaciones.Text.Trim, dtp_Inicio.Value.Date, Dt_Subclientes) Then

            MsgBox("Se han actualizado correctamente los datos.", MsgBoxStyle.Information, frm_MENU.Text)
            cmb_Cliente.SelectedValue = 0
        Else
            MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class

