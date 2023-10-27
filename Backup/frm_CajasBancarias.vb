Imports System.Data.SqlClient
Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes
Imports Microsoft.VisualBasic

Public Class frm_CajasBancarias

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        'Aqui se cierra la ventana
        Me.Close()
    End Sub

    Private Sub frm_CajasBancarias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Aqui se llena la lista
        cmb_Cliente.Actualizar()
        cmb_Banco.Actualizar()

        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        Dim Status As String
        SegundosDesconexion = 0

        Call Limpiar()
        fn_Menu_Progreso(50)
        If cbx_Activas.Checked Then Status = "A" Else Status = "T"
        Cn_Clientes.fn_CajasBancarias_LlenarLista(lsv_Catalogo, Status)
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        fn_Menu_Progreso(100)
        Call Botones()
        fn_Menu_Progreso(0)
    End Sub

    Private Sub Limpiar()
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"

        Call Botones()
    End Sub

    Sub Botones()
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        cmb_Banco.SelectedValue = "0"
        tbx_Cliente.Text = ""
        cmb_Cliente.Enabled = True
        tbx_Cliente.Enabled = True
        btn_BuscarCliente.Enabled = True

        Tab_Catalogo.SelectedTab = tab_Listado
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If cmb_Cliente.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Banco.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        If fn_CajasBancarias_BuscarExiste(cmb_Cliente.SelectedValue, cmb_Banco.SelectedValue) Then
            MsgBox("La Caja Bancaria ya Existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Tab_Nuevo.Text = "Nuevo" Then
            If fn_CajasBancarias_Crear(cmb_Cliente.SelectedValue, cmb_Banco.SelectedValue) Then
                fn_Menu_Progreso(30)

                cmb_Banco.SelectedValue = "0"
                tbx_Cliente.Text = ""
                cmb_Cliente.Enabled = True
                tbx_Cliente.Enabled = True
                btn_BuscarCliente.Enabled = True

                Tab_Nuevo.Text = "Nuevo"
                fn_Menu_Progreso(100)
            Else
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                fn_Menu_Progreso(0)
            End If
        Else
            If fn_CajasBancarias_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, cmb_Banco.SelectedValue) Then
                fn_Menu_Progreso(30)

                cmb_Banco.SelectedValue = "0"
                tbx_Cliente.Text = ""
                cmb_Cliente.Enabled = True
                tbx_Cliente.Enabled = True
                btn_BuscarCliente.Enabled = True
                Tab_Nuevo.Text = "Nuevo"

                Tab_Catalogo.SelectedTab = tab_Listado
                fn_Menu_Progreso(40)
                Call LlenarLista()
                fn_Menu_Progreso(100)
            Else
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                fn_Menu_Progreso(0)
            End If
        End If
        fn_Menu_Progreso(0)
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        Call Botones()
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim dt As DataTable = fn_CajasBancarias_Leer2(lsv_Catalogo.SelectedItems(0).Tag)
        If dt Is Nothing Then
            MsgBox("Ocurrió un error al intentar leer los datos de la Caja Bancaria.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        If dt.Rows.Count = 0 Then
            MsgBox("No se encontró la información de la Caja Bancaria.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        cmb_Cliente.SelectedValue = dt.Rows(0)("Id_Cliente")
        cmb_Banco.SelectedValue = dt.Rows(0)("Id_Banco")
        cmb_Cliente.Enabled = False
        tbx_Cliente.Enabled = False
        btn_BuscarCliente.Enabled = False
        Tab_Nuevo.Text = "Modificar"
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems(0).SubItems(2).Text = "ACTIVO" Then
            If Not fn_CajasBancarias_ValidarDependencias(lsv_Catalogo.SelectedItems(0).Tag) Then
                fn_CajasBancarias_Status(lsv_Catalogo.SelectedItems(0).Tag, "B")
            Else
                MsgBox("No se puede dar de baja la Caja Bancaria porque tiene dependencias registradas.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Exit Sub
            End If
        Else
            fn_CajasBancarias_Status(lsv_Catalogo.SelectedItems(0).Tag, "A")
        End If

        Call LlenarLista()
    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Frm_BuscarCliente.ShowDialog()
        tbx_Cliente.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 1, frm_MENU.prg_Barra)
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        If Tab_Nuevo.Text = "Nuevo" Then
            cmb_Banco.SelectedValue = 0
            cmb_Cliente.SelectedValue = 0
        End If

    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub cbx_Activas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Activas.CheckedChanged
        Call LlenarLista()
    End Sub
End Class