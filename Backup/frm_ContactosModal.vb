Public Class frm_ContactosModal
    Public Id_Cliente As Integer
    Public Aceptar As Boolean = False

    Private Sub frm_RutasModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Ejecutivo.AgregaParametro("@Id_Cliente", Id_Cliente, 1)
        cmb_Ejecutivo.Actualizar()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Aceptar = False
        Me.Close()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        SegundosDesconexion = 0

        If cmb_Ejecutivo.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Ejecutivo.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        Else
            Aceptar = True
            Me.Close()
        End If
    End Sub
End Class