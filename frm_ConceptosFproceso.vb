Imports System.Data.SqlClient

Public Class frm_ConceptosFproceso

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        'Aqui se cierra la ventana
        Me.Close()

    End Sub

    Private Sub frm_ConceptosFproceso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'Aqui se llena la lista
        Cn_Clientes.fn_ConceptosFproceso_LlenarLista(lsv_Catalogo)

        If lsv_Catalogo.Items.Count = 0 Then
            BTN_Exportar.Enabled = False
        Else
            BTN_Exportar.Enabled = True
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Private Sub TBX_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Aqui se pasa al siguiente control con enter
            tbx_Formula.Focus()
        Else
            'Aqui se convierte el caracter en mayusculas
            e.KeyChar = UCase(e.KeyChar)
        End If
    End Sub

    Private Sub tbx_Clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Formula.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Aqui se pasa al siguiente control con enter
            btn_Guardar.Focus()
        Else
            'Aqui se convierte el caracter en mayusculas
            e.KeyChar = UCase(e.KeyChar)
        End If
    End Sub

    Private Sub tbx_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Nombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Aqui se pasa al siguiente control con enter
            tbx_Formula.Focus()
        Else
            'Aqui se convierte el caracter en mayusculas
            e.KeyChar = UCase(e.KeyChar)
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        'Aqui se limpian los textbox
        tbx_Formula.Clear()
        tbx_Nombre.Clear()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Not FuncionesGlobales.fn_Valida_Cadena(tbx_Formula.Text.Trim, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            'En caso de que la clave no sea valida
            MsgBox("'" & tbx_Formula.Text.Trim & "', No es una nombre de formula valida.", MsgBoxStyle.Critical, frm_MENU.Text)
        ElseIf Not FuncionesGlobales.fn_Valida_Cadena(tbx_Nombre.Text, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            'En caso de que el nombre no sea valido
            MsgBox("'" & tbx_Nombre.Text.Trim & "', No es un nombre válido.", MsgBoxStyle.Critical, frm_MENU.Text)
        ElseIf tbx_Formula.Text = "" Or tbx_Nombre.Text = "" Then
            'En caso de que haya campos en blanco
            MsgBox("No se puede dejar ningún campo vacío.", MsgBoxStyle.Critical, frm_MENU.Text)
        ElseIf Cn_Clientes.fn_ConceptosFproceso_ValidarFormula(tbx_Formula.Text) Then
            'En caso de que la clave ya exista en la base de datos
            MsgBox("La formula no existe.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            'En caso de que todo sea valido
            If Tab_Nuevo.Text = "Nuevo" Then
                'Si se esta Insertando
                If Cn_Clientes.fn_ConceptosFproceso_Nuevo(tbx_Nombre.Text.Trim, tbx_Formula.Text.Trim) Then
                    'En caso de que se haya hecho la transaccion
                    FuncionesGlobales.fn_Menu_Progreso(30)
                    'Aqui se limpian los textbox
                    tbx_Formula.Clear()
                    tbx_Nombre.Clear()
                    'Aqui se Ajusta el titulo de la pestaña
                    Tab_Nuevo.Text = "Nuevo"
                    FuncionesGlobales.fn_Menu_Progreso(40)
                    tbx_Nombre.Focus()
                Else
                    'En caso de que no se haya hecho la transaccion
                    MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    FuncionesGlobales.fn_Menu_Progreso(0)
                End If
            Else
                'Si se esta actualizando
                If Cn_Clientes.fn_ConceptosFproceso_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Nombre.Text.Trim, tbx_Formula.Text.Trim) Then
                    'En caso de que se haya hecho la transaccion
                    FuncionesGlobales.fn_Menu_Progreso(30)
                    'Aqui se limpian los textbox
                    tbx_Formula.Clear()
                    tbx_Nombre.Clear()
                    Tab_Nuevo.Text = "Nuevo"
                    'Aqui se cambia la pestaña seleccionada
                    Tab_Catalogo.SelectedTab = tab_Listado
                    FuncionesGlobales.fn_Menu_Progreso(40)
                Else
                    'En caso de que no se haya hecho la transaccion
                    MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    FuncionesGlobales.fn_Menu_Progreso(0)
                End If
            End If
            'Aqui se limpia el listview
            lsv_Catalogo.Items.Clear()
            Lbl_Registros.Text = "Registros: 0"
            FuncionesGlobales.fn_Menu_Progreso(50)
            'Aqui se Actualiza el listview
            Cn_Clientes.fn_ConceptosFproceso_LlenarLista(lsv_Catalogo)
            Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
            'Aqui se ocultan y se muestran los botones de reporte
            If lsv_Catalogo.Items.Count = 0 Then
                BTN_Exportar.Enabled = False
            Else
                BTN_Exportar.Enabled = True
            End If
            FuncionesGlobales.fn_Menu_Progreso(100)
            'Aqui se ocultan los botones
            Btn_Baja.Enabled = False
            BTN_Modificar.Enabled = False
            'Aqui se limpia el contador de progreso
            FuncionesGlobales.fn_Menu_Progreso(0)
        End If
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
        'Aqui se ocultan los botones
        Btn_Baja.Enabled = True
        BTN_Modificar.Enabled = True
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        'Aqui se establece el texto del objeto seleccionado
        tbx_Formula.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        tbx_Nombre.Text = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"
        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0

        'Aqui se filtra cuando el objeto esta activo o inactivo
        If lsv_Catalogo.SelectedItems(0).SubItems(2).Text = "ACTIVO" Then
            If Cn_Clientes.fn_ConceptosFproceso_ValidarDependencias(lsv_Catalogo.SelectedItems(0).Tag) Then
                Cn_Clientes.fn_ConceptosFproceso_Baja(lsv_Catalogo.SelectedItems(0).Tag)
            Else
                MsgBox("No se puede desactivar el elemento porque tiene dependencias registradas.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            Cn_Clientes.fn_ConceptosFproceso_Alta(lsv_Catalogo.SelectedItems(0).Tag)
        End If
        'Aqui se actualiza la lista
        lsv_Catalogo.Items.Clear()
        Cn_Clientes.fn_ConceptosFproceso_LlenarLista(lsv_Catalogo)
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
        'Aqui se ocultan y se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            BTN_Exportar.Enabled = False
        Else
            BTN_Exportar.Enabled = True
        End If
        'Aqui se ocultan los botones
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

End Class