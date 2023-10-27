Public Class frm_ModificarOrigenDestino

    Private Sub frm_ValidaHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False
        cmb_Servicios.AgregaParametro("@Id_Cliente", "-1", 1)
        cmb_ClientesHorarios.AgregaParametro("Id_Cliente", "-1", 1)
        cmb_ClientesHorarios.AgregaParametro("Tipo", "O", 0)
        cmb_Clientes.Actualizar()
        cmb_Servicios.Actualizar()
        cmb_ClientesHorarios.Actualizar()
        cmb_H_Cliente.Actualizar()
        BanderA = True

        Lsv_Horarios.Columns.Add("Cliente")
        Lsv_Horarios.Columns.Add("Frecuencia")
        Lsv_Horarios.Columns.Add("ClienteOrigen")
        Lsv_Horarios.Columns.Add("Recolección")
        Lsv_Horarios.Columns.Add("ClienteDestino")
        Lsv_Horarios.Columns.Add("Entrega")
        Lsv_Horarios.Columns.Add("Ruta")
     
    End Sub

    Private Sub cmb_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0
        Lsv_Horarios.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        If cmb_Clientes.SelectedValue = 0 Then Exit Sub
        cmb_Servicios.ActualizaValorParametro("@Id_Cliente", cmb_Clientes.SelectedValue)
        cmb_Servicios.Actualizar()
        cmb_ClientesHorarios.ActualizaValorParametro("Id_Cliente", "-1")
        cmb_ClientesHorarios.ActualizaValorParametro("Tipo", "O")
        cmb_ClientesHorarios.Actualizar()

    End Sub


    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub chk_CLiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmb_Clientes_SelectedIndexChanged(cmb_Clientes, e)
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
            For Each Item As ListViewItem In Lsv_Horarios.Items
                Item.Checked = False
            Next
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        Dim Tipo As Char = "O"
        Lsv_Horarios.Items.Clear()

        If cmb_Clientes.SelectedValue = 0 Then
            MsgBox("Selecciones el Cliente a Mostrar.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If

        If cmb_Servicios.SelectedValue = 0 Then
            MsgBox("Selecciones el Servicio a Mostrar.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Servicios.Focus()
            Exit Sub
        End If
        If cmb_ClientesHorarios.SelectedValue = 0 Then
            MsgBox("Selecciones el Cliente a Mostrar.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ClientesHorarios.Focus()
            Exit Sub
        End If

        If rdb_Destino.Checked = True Then Tipo = "D"
        If Not Cn_Clientes.fn_ModificarOrigenDestino_LlenarLista(Lsv_Horarios, cmb_Clientes.SelectedValue, cmb_ClientesHorarios.SelectedValue, cmb_Servicios.SelectedValue, Tipo) Then
            MsgBox("Ocurrio un error al cargar los datos de los horarios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_Registros.Text = "Registros: " & Lsv_Horarios.Items.Count
        chk_Todos.Checked = True

    End Sub

    Private Sub rdb_Origen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Origen.CheckedChanged

        Call Carga_Radios()

        lbl_H_Cliente.Text = "Este Cliente sera el Nuevo Origen"
    End Sub

    Private Sub rdb_Destino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Destino.CheckedChanged
        Call Carga_Radios()
        lbl_H_Cliente.Text = "Este Cliente sera el Nuevo Destino"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        SegundosDesconexion = 0
        Dim Tipo As Char = "O"

        If Lsv_Horarios.CheckedItems.Count = 0 Then
            MsgBox("Marque la casilla de los Horarios a Modificar", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If rdb_Origen.Checked Then
            If MsgBox("Los clientes seleccionados cambiaran su Cliente Origen: " & cmb_ClientesHorarios.Text & " ,por " & cmb_H_Cliente.Text & Chr(13) & "Seguro que desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            If MsgBox("Los clientes seleccionados cambiaran su Cliente Destino: " & cmb_ClientesHorarios.Text & " ,por " & cmb_H_Cliente.Text & Chr(13) & "Seguro que desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        If rdb_Destino.Checked = True Then Tipo = "D"
        If Not Cn_Clientes.fn_ModificarOrigenDestino_Update(Lsv_Horarios, cmb_H_Cliente.SelectedValue, Tipo) Then
            MsgBox("Ocurrio un error al Modificar los Horarios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call btn_Mostrar_Click(Nothing, Nothing)
        cmb_H_Cliente.SelectedValue = 0
        Call Desmarcar_Radios()
    End Sub

    Private Sub cmb_ClientesHorarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClientesHorarios.SelectedIndexChanged
        Lsv_Horarios.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub cmb_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Servicios.SelectedIndexChanged
        Lsv_Horarios.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        cmb_ClientesHorarios.ActualizaValorParametro("Id_Cliente", "-1")
        cmb_ClientesHorarios.ActualizaValorParametro("Tipo", "O")
        cmb_ClientesHorarios.Actualizar()
        Call Desmarcar_Radios()

    End Sub

    Private Sub Lsv_Horarios_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Horarios.ItemChecked
        lbl_Registros.Text = "Resgistros marcados: " & Lsv_Horarios.CheckedItems.Count
        If Lsv_Horarios.CheckedItems.Count = 0 Then lbl_Registros.Text = "Registros: " & Lsv_Horarios.Items.Count
    End Sub

    Sub Desmarcar_Radios()
        If rdb_Destino.Checked = True Then rdb_Destino.Checked = False
        If rdb_Origen.Checked = True Then rdb_Origen.Checked = False
    End Sub
    Sub Carga_Radios()
        Lsv_Horarios.Items.Clear()
        If cmb_Clientes.SelectedValue = 0 OrElse cmb_Servicios.SelectedValue = 0 Then Exit Sub

        cmb_ClientesHorarios.ActualizaValorParametro("Id_Cliente", cmb_Clientes.SelectedValue)
        If rdb_Origen.Checked = True Then
            cmb_ClientesHorarios.ActualizaValorParametro("Tipo", "O")
            cmb_ClientesHorarios.Actualizar()
        Else
            cmb_ClientesHorarios.ActualizaValorParametro("Tipo", "D")
            cmb_ClientesHorarios.Actualizar()
        End If
    End Sub
  
    

End Class