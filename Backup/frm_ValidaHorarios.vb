Public Class frm_ValidaHorarios

    Private Sub frm_ValidaHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False
        cmb_Clientes.AgregaParametro("@Status", "A", 0)
        cmb_Clientes.Actualizar()
        BanderA = True

        Cn_Clientes.fn_ValidaHorario_LlenarLista(Lsv_Horarios, -1, False)
        lbl_Registros.Text = "Registros: " & Lsv_Horarios.Items.Count
    End Sub

    Private Sub cmb_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0

        Dim Hijos As Boolean
        If cmb_Clientes.Items.Count > 0 Then
            If chk_CLiente.Checked = True Then
                Hijos = True
            Else
                Hijos = False
            End If
            Call llenaLista(Hijos)
        End If
    End Sub

    Private Sub Btn_Valida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Valida.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()

        If frm.Firma = True Then
            If Cn_Clientes.fn_ValidaHorario_UsuarioValida(frm.Empleado) = True Then
                If Cn_Clientes.fn_ValidaHorario_Valida(Lsv_Horarios) = True Then
                    MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
                    cmb_Clientes.SelectedValue = 0
                    Lsv_Horarios.Items.Clear()
                    tbx_Comentario.Clear()
                End If
            Else
                MsgBox("Empleado no autorizado para evaluar horarios", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        frm.Dispose()
        Btn_Valida.Enabled = False
        btn_Eliminar.Enabled = False
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Lsv_Horarios_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Horarios.ItemChecked
        Btn_Valida.Enabled = Lsv_Horarios.CheckedItems.Count > 0
        btn_Eliminar.Enabled = Lsv_Horarios.CheckedItems.Count > 0
    End Sub

    Private Sub chk_CLiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CLiente.CheckedChanged
        cmb_Clientes_SelectedIndexChanged(cmb_Clientes, e)
    End Sub

    Private Sub llenaLista(ByVal Hijos As Boolean)
        SegundosDesconexion = 0

        If BanderA = True Then
            If cmb_Clientes.SelectedValue <> 0 Then
                Cn_Clientes.fn_ValidaHorario_LlenarLista(Lsv_Horarios, cmb_Clientes.SelectedValue, Hijos)
            Else
                Lsv_Horarios.Items.Clear()
            End If
        End If
        lbl_Registros.Text = "Registros: " & Lsv_Horarios.Items.Count
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()

        If frm.Firma = True Then
            If Cn_Clientes.fn_ValidaHorario_UsuarioValida(frm.Empleado) = True Then
                If Cn_Clientes.fn_ValidaHorario_Eliminar(Lsv_Horarios) = True Then
                    MsgBox("Registros Eliminados.", MsgBoxStyle.Information, frm_MENU.Text)
                    Lsv_Horarios.Items.Clear()
                    tbx_Comentario.Clear()
                    btn_Eliminar.Enabled = False
                    Btn_Valida.Enabled = False
                    Call llenaLista(chk_CLiente.Checked)
                    chk_Todos.Checked = False
                End If
            Else
                MsgBox("Empleado no autorizado para evaluar horarios", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        frm.Dispose()
    End Sub

    Private Sub Lsv_Horarios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Horarios.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        If chk_Todos.Checked = True Then
            For Each Item As ListViewItem In Lsv_Horarios.Items
                Item.Checked = True
            Next
        Else
            For Each Item As ListViewItem In Lsv_Horarios.CheckedItems
                Item.Checked = False
            Next
        End If
    End Sub
End Class