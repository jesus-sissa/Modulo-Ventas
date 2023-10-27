Imports Modulo_Ventas.Cn_Clientes

Public Class frm_Instancias
    Private Id_Instancia As Integer = 0
    Dim EmpleadoBaja As String
    Dim InstanciaBaja As String
    Private Id_EI As Integer = 0

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_Clave.Text.Trim = "" Then
            MsgBox("Indique una Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If
        If tbx_Descripcion.Text.Trim = "" Then
            MsgBox("Indique una Descripcion.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If
        If cmb_Tipo.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo de Evaluación.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If
        '-----------------
        '-----------------
        If btn_Modificar.Tag = "N" Then

            For I As Integer = 0 To lsv_Catalogo.Items.Count - 1
                If lsv_Catalogo.Items(I).Text = tbx_Clave.Text.Trim OrElse _
                   lsv_Catalogo.Items(I).SubItems(1).Text = tbx_Descripcion.Text.Trim Then
                    MsgBox("La Clave o la descripción ya se encuentran capturadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                    lsv_Catalogo.Items(I).Selected = True
                    Exit Sub
                End If
            Next

            If Not fn_Instancias_Create(tbx_Clave.Text.Trim, tbx_Descripcion.Text.Trim, cmb_Tipo.SelectedValue, "A") Then
                MsgBox("Ha ocurrido un error al intentar crear el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                Call LlenarLista()
                cmb_Tipo.SelectedValue = 0
            End If

        Else
            If tbx_Descripcion.Tag <> tbx_Descripcion.Text.Trim Then
                For I As Integer = 0 To lsv_Catalogo.Items.Count - 1
                    If lsv_Catalogo.Items(I).SubItems(1).Text = tbx_Descripcion.Text.Trim Then
                        MsgBox("La Descripción ya se encuentra registrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                        lsv_Catalogo.Items(I).Selected = True
                        Exit Sub
                    End If
                Next
            End If

            If Not fn_Instancias_Update(Id_Instancia, tbx_Descripcion.Text.Trim, cmb_Tipo.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar actualizar el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                Call LlenarLista()
                tbx_Clave.Enabled = True
                cmb_Tipo.SelectedValue = 0
                'Tab_Catalogo.SelectedTab = tab_Listado
            End If

        End If
    End Sub

    Public Sub Limpiar()
        tbx_Clave.Clear()
        tbx_Descripcion.Clear()
        tbx_Buscar.Clear()
        lsv_Catalogo.SelectedItems.Clear()
        btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Public Sub LlenarLista()
        SegundosDesconexion = 0

        If Not fn_Instancias_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        'recarga el combo instancias
        cmb_Instancia.Actualizar()

        Call Limpiar()

        'Tab_Nuevo.Text = "Nuevo"
        btn_Modificar.Tag = "N"
        'Tab_Catalogo.SelectedTab = tab_Listado
        Id_Instancia = 0
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Private Sub frm_Instancias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'D=Datos; S=Servicios; T=Todo o Ambos
        If cmb_Tipo.Items.Count > 0 Then cmb_Tipo.LimpiarItems()
        cmb_Tipo.AgregarItem("D", "DATOS")
        cmb_Tipo.AgregarItem("S", "SERVICIOS")
        cmb_Tipo.AgregarItem("T", "TODO")

        Call LlenarLista()

        '-----instancia x empleado
        cmb_Empleados.Actualizar()
        cmb_Instancia.Actualizar()
        lsv_empleadosxInstancia.Columns.Add("Instancia")
        lsv_empleadosxInstancia.Columns.Add("Empleado")
        Call LlenarListaEI()
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            If lsv_Catalogo.SelectedItems(0).SubItems(3).Text = "ACTIVO" Then
                fn_Instancias_Baja(lsv_Catalogo.SelectedItems(0).Tag, "B")
            Else
                fn_Instancias_Baja(lsv_Catalogo.SelectedItems(0).Tag, "A")
            End If

            If Not fn_Instancias_LlenarLista(lsv_Catalogo) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 0, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Id_Instancia = lsv_Catalogo.SelectedItems(0).Tag
            Dim row As DataRow = fn_Instancias_Read(Id_Instancia)

            If row Is Nothing Then
                MsgBox("Ha ocurrido un error al intentar leer los datos del registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            tbx_Clave.Text = row("Clave_Instancia")
            tbx_Descripcion.Text = row("Descripcion")
            tbx_Descripcion.Tag = row("Descripcion") '--
            cmb_Tipo.SelectedValue = row("Tipo_Evaluacion")

            btn_Modificar.Tag = "M"
            'Tab_Nuevo.Text = "Modificar"
            'Tab_Nuevo.Tag = "M"
            'Tab_Catalogo.SelectedTab = Tab_Nuevo
            tbx_Clave.Enabled = False
            tbx_Descripcion.SelectAll()
            tbx_Descripcion.Focus()
        Else
            MsgBox("Debe seleccionar un registro para modificar.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial) Then
            MsgBox("Las Palabras: '" & tbx_Buscar.Text & "' no se han encontrado en la lista.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_buscarEI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarEI.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_empleadosxInstancia.SelectedItems.Count > 0 Then Fila_Inicial = lsv_empleadosxInstancia.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_empleadosxInstancia, tbx_buscarEI.Text, 0, Fila_Inicial) Then
            MsgBox("Las Palabras: '" & tbx_buscarEI.Text & "' no se han encontrado en la lista", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub cmb_Empleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleados.SelectedIndexChanged
        If cmb_Instancia.SelectedValue > 0 And cmb_Empleados.SelectedValue > 0 Then
            btn_AgregarEI.Enabled = True
        Else
            btn_AgregarEI.Enabled = False
        End If
    End Sub

    Private Sub btn_AgregarEI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarEI.Click
        SegundosDesconexion = 0

        If cmb_Instancia.SelectedIndex = 0 Then
            MsgBox("Seleccione una Instancia.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Instancia.Focus()
            Exit Sub
        End If
        If cmb_Empleados.SelectedIndex = 0 Then
            MsgBox("Seleccione un Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleados.Focus()
            Exit Sub
        End If

        'Buscar para ver si el Empleado seleccionado ya existe en la instancia
        For I As Integer = 0 To lsv_empleadosxInstancia.Items.Count - 1
            If lsv_empleadosxInstancia.Items(I).SubItems(2).Text = cmb_Instancia.SelectedValue And _
               lsv_empleadosxInstancia.Items(I).SubItems(3).Text = cmb_Empleados.SelectedValue Then
                MsgBox("El Empleado seleccionado ya existe en la Instancia.", MsgBoxStyle.Critical, frm_MENU.Text)
                lsv_empleadosxInstancia.Items(I).Selected = True
                Exit Sub
            End If
        Next

        If Not fn_InstanciasEmpleados_Create(cmb_Instancia.SelectedValue, cmb_Empleados.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar crear el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            Call LlenarListaEI()
        End If

        cmb_Empleados.SelectedValue = 0

    End Sub

    Private Sub btn_BorrarEI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrarEI.Click
        EmpleadoBaja = lsv_empleadosxInstancia.SelectedItems(0).SubItems(1).Text
        InstanciaBaja = lsv_empleadosxInstancia.SelectedItems(0).SubItems(0).Text

        If Not fn_InstanciasEmpleados_Baja(lsv_empleadosxInstancia.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar dar de Baja el Empleado de la Instancia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'INSERTAR EN EL LOG
        Cn_Login.fn_Log_Create("EMPLEADO POR INSTANCIA: SE ELIMINO EL EMPLEADO " & EmpleadoBaja & " DE LA INSTANCIA " & InstanciaBaja)

        btn_Baja.Enabled = False
        Call LlenarListaEI()
    End Sub

    Private Sub btn_ExportarEI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarEI.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_empleadosxInstancia, 0, Me.Text, 0, 0, frm_MENU.prg_Barra)

    End Sub

    Public Sub LlenarListaEI()
        SegundosDesconexion = 0

        If Not fn_InstanciasEmpleados_LlenarLista(lsv_empleadosxInstancia) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lbl_registrosEI.Text = "Registros:" & lsv_empleadosxInstancia.Items.Count
    End Sub

    Private Sub lsv_empleadosxInstancia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_empleadosxInstancia.SelectedIndexChanged
        btn_BorrarEI.Enabled = lsv_empleadosxInstancia.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Call LlenarLista()
        cmb_Tipo.SelectedValue = 0
        tbx_Clave.Enabled = True
    End Sub
End Class