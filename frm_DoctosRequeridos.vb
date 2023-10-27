Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_DoctosRequeridos

    Private Sub frm_DoctosRequeridos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        Call LlenarLista()
        Call Botones()
    End Sub

#Region "SUB's"

    Sub Botones()
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            btn_Modificar.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(1).Text = "ACTIVO"
        End If
    End Sub

    Sub LlenarLista()
        lsv_Catalogo.Items.Clear()
        If Not fn_DocumentosRequerido_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Sub Buscar()
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio)
    End Sub

    Sub Limpiar()
        tbx_Descripcion.Clear()
        tbx_Status.Clear()
        Tab_Nuevo.Text = "Nuevo"
    End Sub

#End Region

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0

            Call Buscar()
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Call Buscar()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        'Aqui se filtra cuando el Documento Requerido esta Activo o Baja
        If lsv_Catalogo.SelectedItems(0).SubItems(1).Text = "ACTIVO" Then
            fn_DocumentosRequeridos_Modificar(lsv_Catalogo.SelectedItems(0).Tag, lsv_Catalogo.SelectedItems(0).Text, "B")
        Else
            fn_DocumentosRequeridos_Modificar(lsv_Catalogo.SelectedItems(0).Tag, lsv_Catalogo.SelectedItems(0).Text, "A")
        End If
        Call LlenarLista()
        Call Botones()
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        'Aqui se establece el texto del objeto seleccionado
        tbx_Descripcion.Text = lsv_Catalogo.SelectedItems(0).Text
        tbx_Status.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text

        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo
        Call Botones()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_Descripcion.Text.Trim = "" Then
            MsgBox("Capture la Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        'En caso de que todo sea valido y sea un registro nuevo
        If Tab_Nuevo.Text = "Nuevo" Then
            If Not fn_DocumentosRequerido_Existe(tbx_Descripcion.Text.Trim) Then
                'En caso de que el Documento Requerido ya exista en la base de datos
                MsgBox("Documento ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Descripcion.Text = ""
                tbx_Status.Text = ""
                tbx_Descripcion.Focus()
                Exit Sub
            End If

            If Not fn_DocumentosRequeridos_Nuevo(tbx_Descripcion.Text.Trim) Then
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se pudo guardar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                fn_Menu_Progreso(0)
            End If
        Else
            'Si se esta actualizando
            If Not fn_DocumentosRequeridos_Modificar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Descripcion.Text.Trim, "A") Then
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se pudo editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                fn_Menu_Progreso(0)
            Else
                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        End If
        'En caso de que se haya hecho la transaccion
        fn_Menu_Progreso(30)

        'Aqui se limpian los textbox
        MsgBox("Los datos se han guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Call Limpiar()
        fn_Menu_Progreso(40)

        Call LlenarLista()
        fn_Menu_Progreso(50)
        Call Botones()
        fn_Menu_Progreso(100)
        'Aqui se limpia el contador de progreso
        fn_Menu_Progreso(0)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Call Limpiar()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Sub frm_DoctosRequeridos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            SegundosDesconexion = 0

            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class