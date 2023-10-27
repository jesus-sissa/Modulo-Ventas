Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ActaInspeccionValidar

    Private Sub frm_ActaInspeccionValidar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        btn_Validar.Enabled = False
        Lbl_Registros.Text = "Registros: 0"
        If Not fn_ActasInspeccion_Pendientes(lsv_ActasInspeccionP) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_ActasInspeccionP.Items.Count
    End Sub

    Private Sub lsv_ActasInspeccionP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ActasInspeccionP.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Validar.Enabled = lsv_ActasInspeccionP.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click, lsv_ActasInspeccionP.DoubleClick
        SegundosDesconexion = 0

        Dim frm As New frm_ActaInspeccionDetalle
        frm.Id_Inspeccion = lsv_ActasInspeccionP.SelectedItems(0).Tag

        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR ACTA DE INSPECCION DE CAJA FUERTE")
        frm.ShowDialog()
        Call LlenarLista()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class