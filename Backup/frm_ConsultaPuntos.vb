Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ConsultaPuntos

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.ClickButton
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1

        fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub cbx_Todos_CheckedChanged(ByVal sender As CheckBox, ByVal e As System.EventArgs) Handles cbx_Todos.CheckedChanged
        If sender.Checked Then cmb_Cliente.SelectedValue = 0
        tbx_Cliente.Enabled = Not sender.Checked
        cmb_Cliente.Enabled = Not sender.Checked
        btn_BuscarCliente.Enabled = Not sender.Checked
        cbx_Hijos.Enabled = Not sender.Checked
        cbx_Hijos.Checked = False
    End Sub

    Private Sub frm_ConsultaPuntos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_desde.Value = Date.Now
        dtp_Hasta.Value = Date.Now
        lsv_Catalogo.Columns.Add("Ruta")
        lsv_Catalogo.Columns.Add("Fecha")
        lsv_Catalogo.Columns.Add("Cliente Origen")
        lsv_Catalogo.Columns.Add("Cliente Destino")
        lsv_Catalogo.Columns.Add("Recoleccion")
        lsv_Catalogo.Columns.Add("Real")
        lsv_Catalogo.Columns.Add("Entrega")
        lsv_Catalogo.Columns.Add("Real1")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Catalogo.Columns.Add("Fuera de Servicio")
        cmb_Cliente.Actualizar()
    End Sub

    Private Sub dtp_desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_desde.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            rbn_Origen.Focus()
        End If
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.TextChanged, rbn_Ambos.CheckedChanged, rbn_Destino.CheckedChanged, rbn_Origen.CheckedChanged, cbx_Hijos.CheckedChanged, dtp_desde.ValueChanged, dtp_Hasta.ValueChanged
        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        BTN_Exportar.Enabled = False
    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Frm_BuscarCliente.ShowDialog()
        tbx_Cliente.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        Call fn_Exportar_Excel(lsv_Catalogo, 0, frm_MENU.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub rbn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbn_Origen.KeyPress, rbn_Destino.KeyPress, rbn_Ambos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbx_Hijos.Focus()
        End If
    End Sub

    Private Sub cbx_Hijos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_Hijos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbx_Todos.Focus()
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        Dim Tipo As Integer
        If rbn_Origen.Checked Then Tipo = 1
        If rbn_Destino.Checked Then Tipo = 2
        If rbn_Ambos.Checked Then Tipo = 3
        If cmb_Cliente.SelectedValue Is Nothing Then Exit Sub
        fn_ConsultaPuntos_llenarlista(lsv_Catalogo, cmb_Cliente.SelectedValue, Tipo, cbx_Hijos.Checked, dtp_desde.Value, dtp_Hasta.Value)

        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        lbl_Registros.Text = "Registros: 0"
    End Sub
End Class