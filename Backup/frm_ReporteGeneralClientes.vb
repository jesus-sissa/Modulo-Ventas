Public Class frm_ReporteGeneralClientes

    Private Sub frm_ReporteGeneralClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Catalogo.Columns.Add("Grupo")
        lsv_Catalogo.Columns.Add("Clave Cliente")
        lsv_Catalogo.Columns.Add("Nombre Fiscal")
        lsv_Catalogo.Columns.Add("Direccion Fiscal")
        lsv_Catalogo.Columns.Add("Colonia Fiscal")
        lsv_Catalogo.Columns.Add("CP Fiscal")
        lsv_Catalogo.Columns.Add("Direccion Comercial")
        lsv_Catalogo.Columns.Add("Giro Comercial")
        lsv_Catalogo.Columns.Add("Ciudad, Estado")
        lsv_Catalogo.Columns.Add("Categoria")
        lsv_Catalogo.Columns.Add("Clave Radio")
        lsv_Catalogo.Columns.Add("Fecha Registro")
        lsv_Catalogo.Columns.Add("Local Foraneo")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Catalogo.Columns.Add("TipoCliente")
        lsv_Catalogo.Columns.Add("Latitud")
        lsv_Catalogo.Columns.Add("Longitud")

        cmb_Status.AgregarItem("A", "ACTIVO")
        cmb_Status.AgregarItem("B", "BAJA")
        cmb_Status.AgregarItem("P", "PROSPECTO")

        cmb_TipoCliente.AgregarItem("1", "TRASLADO")
        cmb_TipoCliente.AgregarItem("2", "SEG. PATRIMONIAL")
        cmb_TipoCliente.AgregarItem("3", "TRASLADO Y SEG.")
        cmb_TipoCliente.AgregarItem("4", "CAJA BANCARIA")
        cmb_TipoCliente.AgregarItem("5", "OTRO")
        cmb_Cliente.Actualizar()


        Cmb_Grupo.Actualizar()

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If Not chk_Todos.Checked And cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione el Cliente Padre o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        If Not Chk_Grupo.Checked And Cmb_Grupo.SelectedValue = "0" Then
            MsgBox("Seleccione un Grupo o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Grupo.Focus()
            Exit Sub
        End If

        If Not chk_Status.Checked And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione el Status o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If Not chk_TipoCliente.Checked And cmb_TipoCliente.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        Dim Status As Char
        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        If Not Cn_Clientes.fn_Clientes_ReporteGeneral(lsv_Catalogo, cmb_Cliente.SelectedValue, Cmb_Grupo.SelectedValue, Status, cmb_TipoCliente.SelectedValue) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        Cursor = Cursors.WaitCursor
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, "Reporte General de Clientes", 0, 0, frm_MENU.prg_Barra)
        Cursor = Cursors.Default
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.ClientesPadre
        frm.ShowDialog()
        tbx_Cliente.Text = frm.Clave
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_Cliente.SelectedValue = 0
        tbx_Cliente.Enabled = Not chk_Todos.Checked
        cmb_Cliente.Enabled = Not chk_Todos.Checked
        btn_BuscarCliente.Enabled = Not chk_Todos.Checked
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_Status.SelectedValue = "0"
        cmb_Status.Enabled = Not chk_Status.Checked
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub chk_TipoCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TipoCliente.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_TipoCliente.SelectedValue = "0"
        cmb_TipoCliente.Enabled = Not chk_TipoCliente.Checked
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub
  
    Private Sub Chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Grupo.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Cmb_Grupo.SelectedValue = "0"
        Cmb_Grupo.Enabled = Not Chk_Grupo.Checked
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Sub LimpiarLista()
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub Cmb_Grupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_Grupo.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_Status_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_TipoCliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoCliente.SelectedValueChanged
        Call LimpiarLista()
    End Sub
End Class