Imports Modulo_Ventas.Cn_Clientes

Public Class frm_CapturarDestino
    Public Id_Cliente As Integer

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_CapturarDestino_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Zona.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_Zona.Actualizar()
        cmb_Ciudad.AgregaParametro("@Id_Pais", fn_CapturarDestino_ObtenPais(), 1)
        cmb_Ciudad.Actualizar()
    End Sub

    Private Sub cmb_Ciudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ciudad.SelectedIndexChanged
        SegundosDesconexion = 0

        If cmb_Ciudad.Items.Count = 0 Then Exit Sub
        cmb_Zona.ActualizaValorParametro("@Id_Ciudad", cmb_Ciudad.SelectedValue)
        cmb_Zona.Actualizar()
    End Sub

    Private Function Validar() As Boolean
        If tbx_Nombre.Text = "" Then
            MsgBox("Indique el Nombre Comercial del Cliente.", 16 + 0, frm_MENU.Text)
            tbx_Nombre.Focus()
            Return False
        End If
        If tbx_Calle.Text = "" Then
            MsgBox("Indique una Calle", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            tbx_Calle.Focus()
            Return False
        End If
        If tbx_Numero.Text = "" Then
            MsgBox("Indique un Número", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            tbx_Numero.Focus()
            Return False
        End If
        If tbx_Colonia.Text = "" Then
            MsgBox("Indique una Colonia", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            tbx_Colonia.Focus()
            Return False
        End If
        If cmb_Zona.Text = "" Then
            MsgBox("Seleccione una Zona.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Zona.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Validar() Then
            Dim Id As Integer = fn_CapturarDestino_Guardar(tbx_Nombre.Text, tbx_Calle.Text, tbx_Numero.Text, tbx_NumeroInt.Text, tbx_Colonia.Text, cmb_Zona.SelectedValue)
            If Id = 0 Then
                MsgBox("Ha ocurrido un error al intentar guardar el destino", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                Id_Cliente = Id
                Me.Close()
            End If
        End If

    End Sub

    Private Sub gbx_DatosComerciales_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_DatosComerciales.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class