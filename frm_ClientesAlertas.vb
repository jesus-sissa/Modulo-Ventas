Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ClientesAlertas
    Dim Id_Cliente As Integer = 0
    Dim Id_Padre As Integer = 0
    Dim Cancelar As Boolean = False

    Private Sub frm_ClientesAlertas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        SegundosDesconexion = 0

        cmb_ClienteP.AgregaParametro("@Status", "A", 0)
        cmb_ClienteP.AgregaParametro("@Padres", "S", 0)
        cmb_ClienteP.Actualizar()

        Cmb_AlertasTipo.LimpiarItems()
        Cmb_AlertasTipo.AgregarItem("46", "NOTIFICACION DE ATENCION TRASLADO DE VALORES")

        cmb_AlertaContacto.AgregaParametro("@Id_Cliente", -1, 1)
        cmb_AlertaContacto.AgregaParametro("@Tipo_Contacto", 0, 1)
        cmb_AlertaContacto.Actualizar()

        lsv_Alertas.Clear()
        lsv_Alertas.Columns.Add("Alerta")
        lsv_Alertas.Columns.Add("Contacto")
        lsv_Alertas.Columns.Add("Correo")
        lsv_Alertas.Columns.Add("Recoleccion")
        lsv_Alertas.Columns.Add("Entrega")
        lsv_Alertas.Columns.Add("Origen")
        lsv_Alertas.Columns.Add("Destino")
        lsv_Alertas.Columns.Add("Status")
        lsv_Alertas.Columns.Add("IdC")
        lsv_Alertas.Columns.Add("CA")
        lsv_Alertas.Columns.Add("TC", 0)

        lsv_Clientes.Clear()
        lsv_Clientes.Columns.Add("Clave")
        lsv_Clientes.Columns.Add("Cliente")
        lsv_Clientes.Columns.Add("Status")
        lsv_Clientes.Columns.Add("IdP")

        tp_Alertas.Parent = Nothing
    End Sub

    Sub ListaClientes()
        SegundosDesconexion = 0

        If cmb_ClienteP.SelectedValue = "0" AndAlso Chk_TodosClientes.Checked = False Then
            lsv_Clientes.Items.Clear()
            lbl_RegistrosClientes.Text = "Registros: 0"
        Else
            If Not fn_ClientesAlertas_ListaClientes(lsv_Clientes, cmb_ClienteP.SelectedValue, "A") Then
                MsgBox("Ocurrió un error al intentar mostrar los Clientes.", MsgBoxStyle.Critical, Me.Text)
            End If
            lbl_RegistrosClientes.Text = "Registros: " & lsv_Clientes.Items.Count
        End If
    End Sub


    Private Sub rbn_AlertaEsteCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_AlertaEsteCliente.CheckedChanged, MyBase.Load
        SegundosDesconexion = 0

        If rbn_AlertaEsteCliente.Checked Then
            cmb_AlertaContacto.ActualizaValorParametro("@Id_Cliente", Id_Cliente)
            cmb_AlertaContacto.Actualizar()
        End If
    End Sub

    Private Sub rbn_AlertaClientePadre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_AlertaClientePadre.CheckedChanged
        SegundosDesconexion = 0

        If rbn_AlertaClientePadre.Checked Then
            cmb_AlertaContacto.ActualizaValorParametro("@Id_Cliente", Id_Padre)
            cmb_AlertaContacto.Actualizar()
        End If
    End Sub

    Private Sub btn_AlertaGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AlertaGuardar.Click
        SegundosDesconexion = 0

        If Cmb_AlertasTipo.SelectedValue = "0" Then
            MsgBox("Seleccione un Tipo de Alerta.", MsgBoxStyle.Critical, Me.Text)
            Cmb_AlertasTipo.Focus()
            Exit Sub
        End If

        If Chk_AlertaRecoleccion.Checked = False AndAlso Chk_AlertaEntrega.Checked = False Then
            MsgBox("Seleccione un Evento para la alerta.", MsgBoxStyle.Critical, Me.Text)
            Chk_AlertaRecoleccion.Focus()
            Exit Sub
        End If

        If Chk_AlertaOrigen.Checked = False AndAlso Chk_AlertaDestino.Checked = False Then
            MsgBox("Seleccione cuando se enviará la alerta.", MsgBoxStyle.Critical, Me.Text)
            Chk_AlertaOrigen.Focus()
            Exit Sub
        End If

        If rbn_AlertaEsteCliente.Checked = False AndAlso rbn_AlertaClientePadre.Checked = False Then
            MsgBox("Seleccione el origen de los Contactos.", MsgBoxStyle.Critical, Me.Text)
            'rbn_AlertaEsteCliente.Focus()
            Exit Sub
        End If

        If cmb_AlertaContacto.SelectedValue = "0" Then
            MsgBox("Seleccione el Contacto de la alerta.", MsgBoxStyle.Critical, Me.Text)
            cmb_AlertaContacto.Focus()
            Exit Sub
        End If

        Dim Dt_Contactos As DataTable = cmb_AlertaContacto.DataSource
        If Dt_Contactos(cmb_AlertaContacto.SelectedIndex)("Mail") = "" Then
            MsgBox("El Contacto seleccionado no cuenta con un correo registrado.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        For Each ItemContacto As ListViewItem In lsv_Alertas.Items
            If ItemContacto.SubItems(9).Text.Trim = Cmb_AlertasTipo.SelectedValue AndAlso _
            ItemContacto.SubItems(8).Text.Trim = cmb_AlertaContacto.SelectedValue Then
                MsgBox("La alerta con ese Contacto ya se encuentra en la lista.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If
        Next

        Dim Alerta_Recoleccion As String = IIf(Chk_AlertaRecoleccion.Checked, "S", "N")
        Dim Alerta_Entrega As String = IIf(Chk_AlertaEntrega.Checked, "S", "N")
        Dim Modo_Alerta As Integer = 0
        If Chk_AlertaOrigen.Checked And Chk_AlertaDestino.Checked Then
            Modo_Alerta = 3
        ElseIf Chk_AlertaOrigen.Checked Then
            Modo_Alerta = 1
        ElseIf Chk_AlertaDestino.Checked Then
            Modo_Alerta = 2
        End If

        Dim Tipo_Cliente As Integer = IIf(rbn_AlertaEsteCliente.Checked, 1, 2)

        If Not fn_ClientesAlertas_Guardar(Cmb_AlertasTipo.SelectedValue, Id_Cliente, Alerta_Recoleccion, Alerta_Entrega, Tipo_Cliente, Modo_Alerta, cmb_AlertaContacto.SelectedValue) Then
            MsgBox("Ocurrió un error al intentar guardar el Contacto.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        Else
            LimpiarDatos()
        End If

        Call Alertas_Lista()

    End Sub

    Sub Alertas_Lista()
        SegundosDesconexion = 0

        If Not fn_ClientesAlertas_Lista(lsv_Alertas, Id_Cliente, "A") Then
            MsgBox("Ocurrió un error al listar las Alertas.", MsgBoxStyle.Critical, Me.Text)
        End If

        If lsv_Alertas.Columns.Count > 0 Then
            lsv_Alertas.Columns(10).Width = 0
        End If

        lbl_RegistrosAlertas.Text = "Registros: " & lsv_Alertas.Items.Count
    End Sub

    Private Sub cmb_ClienteP_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ClienteP.SelectedValueChanged
        Call ListaClientes()
    End Sub

    Private Sub Chk_TodosClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_TodosClientes.CheckedChanged
        cmb_ClienteP.SelectedValue = "0"
        cmb_ClienteP.Enabled = Not Chk_TodosClientes.Checked
        Call ListaClientes()
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        Call Editar()
    End Sub

    Sub Editar()
        SegundosDesconexion = 0

        If lsv_Clientes.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Cliente de la lista.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Id_Cliente = lsv_Clientes.SelectedItems(0).Tag
        Id_Padre = lsv_Clientes.SelectedItems(0).SubItems(3).Text

        Cancelar = False
        tp_Alertas.Parent = Tab_ClientesAlertas
        Tab_ClientesAlertas.SelectedTab = tp_Alertas

        Call Alertas_Lista()
    End Sub

    Sub LimpiarAlerta()
        tp_Alertas.Parent = Nothing
        Id_Cliente = 0
        Id_Padre = 0
        Cancelar = False
    End Sub

    Sub LimpiarDatos()
        Chk_AlertaRecoleccion.Checked = False
        Chk_AlertaEntrega.Checked = False
        Chk_AlertaOrigen.Checked = False
        Chk_AlertaDestino.Checked = False
        rbn_AlertaEsteCliente.Checked = False
        rbn_AlertaClientePadre.Checked = False
        cmb_AlertaContacto.ActualizaValorParametro("@Id_Cliente", -1)
        cmb_AlertaContacto.Actualizar()
        Cmb_AlertasTipo.Focus()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Cancelar = True
        Tab_ClientesAlertas.SelectedTab = tp_Clientes
    End Sub

    Private Sub Tab_ClientesAlertas_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles Tab_ClientesAlertas.Selecting
        If Tab_ClientesAlertas.SelectedTab Is tp_Clientes Then
            If Not Cancelar Then
                If Not MsgBox("Si cambia de pestaña los cambios no guardados se perderán." & vbNewLine & _
                       "¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        Call Editar()
    End Sub

    Private Sub Tab_ClientesAlertas_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles Tab_ClientesAlertas.Selected
        If Tab_ClientesAlertas.SelectedTab Is tp_Clientes Then
            Call LimpiarAlerta()
        End If
    End Sub

    Private Sub btn_AlertaBajaReingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AlertaBajaReingreso.Click
        SegundosDesconexion = 0

        If lsv_Alertas.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Contacto de la lista.", MsgBoxStyle.Critical, Me.Text)
            lsv_Alertas.Focus()
            Exit Sub
        End If

        If Not fn_ClientesAlertas_EliminarContacto(lsv_Alertas.SelectedItems(0).Tag) Then
            MsgBox("Ocurrió un error al intentar eliminar el Contacto.", MsgBoxStyle.Critical, Me.Text)
        End If

        Call Alertas_Lista()

    End Sub

End Class