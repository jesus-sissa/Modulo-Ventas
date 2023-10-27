Imports Modulo_Ventas.Cn_Clientes

Public Class frm_InstanciasEmpleados

    'Private Id_Instancia As Integer = 0
    Dim EmpleadoBaja As String
    Dim InstanciaBaja As String

    Private Sub frm_InstanciasEmpleados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Empleados.Actualizar()
        cmb_Instancia.Actualizar()
        lsv_Catalogo.Columns.Add("Instancia")
        lsv_Catalogo.Columns.Add("Empleado")
        Call LlenarLista()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
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
        For I As Integer = 0 To lsv_Catalogo.Items.Count - 1
            If lsv_Catalogo.Items(I).SubItems(2).Text = cmb_Instancia.SelectedValue And _
               lsv_Catalogo.Items(I).SubItems(3).Text = cmb_Empleados.SelectedValue Then
                MsgBox("El Empleado seleccionado ya existe en la Instancia.", MsgBoxStyle.Critical, frm_MENU.Text)
                lsv_Catalogo.Items(I).Selected = True
                Exit Sub
            End If
        Next

        If Not fn_InstanciasEmpleados_Create(cmb_Instancia.SelectedValue, cmb_Empleados.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar crear el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            Call LlenarLista()
        End If

        cmb_Empleados.SelectedValue = 0

    End Sub

    Public Sub LlenarLista()
        SegundosDesconexion = 0

        If Not fn_InstanciasEmpleados_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click

        EmpleadoBaja = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        InstanciaBaja = lsv_Catalogo.SelectedItems(0).SubItems(0).Text

        If Not fn_InstanciasEmpleados_Baja(lsv_Catalogo.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar dar de Baja el Empleado de la Instancia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'INSERTAR EN EL LOG
        Cn_Login.fn_Log_Create("EMPLEADO POR INSTANCIA: SE ELIMINO EL EMPLEADO " & EmpleadoBaja & " DE LA INSTANCIA " & InstanciaBaja)

        Btn_Baja.Enabled = False
        Call LlenarLista()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 0, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial) Then
            MsgBox("Las Palabras: '" & tbx_Buscar.Text & "' no se han encontrado en la lista", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub cmb_Instancia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Instancia.SelectedIndexChanged
        If cmb_Instancia.SelectedValue > 0 And cmb_Empleados.SelectedValue > 0 Then
            btn_Guardar.Enabled = True
        Else
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub cmb_Empleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleados.SelectedIndexChanged
        If cmb_Instancia.SelectedValue > 0 And cmb_Empleados.SelectedValue > 0 Then
            btn_Guardar.Enabled = True
        Else
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

End Class