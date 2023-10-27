Public Class frm_ConsultaWeb

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_ConsultaWeb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call llenarLista()
        lbl_Registros.Text = "Resgistros: " & lsv_Datos.Items.Count
        BTN_Exportar.Enabled = lsv_Datos.Items.Count > 0
    End Sub

    Sub LlenarLista()
        If Not Cn_Clientes.fn_Contact_LlenarLista(lsv_Datos, 1) Then
            MsgBox("Hubo un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        If lsv_Datos.SelectedItems.Count > 0 Then
            tbx_Fecha.Text = lsv_Datos.SelectedItems(0).Text
            tbx_Nombre.Text = lsv_Datos.SelectedItems(0).SubItems(1).Text
            tbx_Apellido.Text = lsv_Datos.SelectedItems(0).SubItems(2).Text
            tbx_Mail.Text = lsv_Datos.SelectedItems(0).SubItems(3).Text
            tbx_Telefono.Text = lsv_Datos.SelectedItems(0).SubItems(4).Text
            tbx_Empresa.Text = lsv_Datos.SelectedItems(0).SubItems(5).Text
            tbx_Mensaje.Text = lsv_Datos.SelectedItems(0).SubItems(6).Text
            tbx_Mensaje.Text.ToUpper()
        Else
            Call LimpiarControles()
        End If
    End Sub

    Sub LimpiarControles()
        tbx_Fecha.Clear()
        tbx_Nombre.Clear()
        tbx_Apellido.Clear()
        tbx_Mail.Clear()
        tbx_Empresa.Clear()
        tbx_Telefono.Clear()
        tbx_Mensaje.Clear()
    End Sub

    Private Sub btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualizar.Click
        SegundosDesconexion = 0

        Call LlenarLista()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        If Not FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, Me.Text, 0, 0, frm_MENU.prg_Barra) Then
            MsgBox("Se presentó un error al intentar Exportar a Excel.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover
        SegundosDesconexion = 0
    End Sub

End Class