Public Class frm_ConsultaClientes

    Private Sub frm_ConsultaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Cliente")
        lsv_Catalogo.Columns.Add("Direccion")
        lsv_Catalogo.Columns.Add("Colonia")
        lsv_Catalogo.Columns.Add("Ciudad, Estado")
        lsv_Catalogo.Columns.Add("Giro Comercial")
        lsv_Catalogo.Columns.Add("Categoria")
        lsv_Catalogo.Columns.Add("Clave Radio")
        lsv_Catalogo.Columns.Add("Fecha Registro")
        lsv_Catalogo.Columns.Add("Local Foraneo")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Catalogo.Columns.Add("TipoCliente")
        lsv_Catalogo.Columns(11).Width = 120
        lsv_Catalogo.Columns.Add("Latitud")
        lsv_Catalogo.Columns(12).Width = 0
        lsv_Catalogo.Columns.Add("Longitud")
        lsv_Catalogo.Columns(13).Width = 0

        cmb_Status.AgregarItem("A", "ACTIVO")
        cmb_Status.AgregarItem("B", "BAJA")
        cmb_Status.AgregarItem("P", "PROSPECTO")

        cmb_TipoCliente.AgregarItem("1", "TRASLADO")
        cmb_TipoCliente.AgregarItem("2", "SEG. PATRIMONIAL")
        cmb_TipoCliente.AgregarItem("3", "TRASLADO Y SEG.")
        cmb_TipoCliente.AgregarItem("4", "CAJA BANCARIA")
        cmb_TipoCliente.AgregarItem("5", "OTRO")
        cmb_Cliente.Actualizar()
    End Sub

    Sub Botones()
        btn_Mapa.Enabled = lsv_Catalogo.Items.Count > 0
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        btn_ExportarContactos.Enabled = lsv_Catalogo.Items.Count > 0
        btn_Adjunto.Enabled = False
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            btn_Adjunto.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(10).Text = "BAJA"
        End If
    End Sub

    Sub Buscar()
        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub cmbs_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged, cmb_Status.SelectedValueChanged, cmb_TipoCliente.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Resgistros: 0"
        Call Botones()
    End Sub

    Private Sub cmb_Cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            ElseIf cmb_TipoCliente.Enabled Then
                cmb_TipoCliente.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
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
        lbl_Registros.Text = "Registros: 0"
        cmb_Cliente.SelectedValue = 0
        tbx_Cliente.Enabled = Not chk_Todos.Checked
        cmb_Cliente.Enabled = Not chk_Todos.Checked
        btn_BuscarCliente.Enabled = Not chk_Todos.Checked
        Call Botones()
    End Sub

    Private Sub cmb_Status_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Status.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_TipoCliente.Enabled Then
                cmb_TipoCliente.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        cmb_Status.SelectedValue = "0"
        cmb_Status.Enabled = Not chk_Status.Checked
        Call Botones()
    End Sub

    Private Sub chk_Tipo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_TipoCliente.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        cmb_TipoCliente.SelectedValue = "0"
        cmb_TipoCliente.Enabled = Not chk_TipoCliente.Checked
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If Not chk_Todos.Checked And cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione el Cliente Padre o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
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

        If Not Cn_Clientes.fn_Clientes_Consulta(lsv_Catalogo, cmb_Cliente.SelectedValue, Status, cmb_TipoCliente.SelectedValue) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Botones()
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Buscar()
            btn_Buscar.Focus()
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Call Buscar()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

    Private Sub btn_Mapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mapa.Click
        SegundosDesconexion = 0

        Dim Latitud As New List(Of Decimal)
        Dim Longitud As New List(Of Decimal)
        Dim Nombre As New List(Of String)
        Dim Descripcion As New List(Of String)
        Dim Contador As Integer = 0

        For Each item As ListViewItem In lsv_Catalogo.Items
            If item.SubItems(12).Text <> "0" And item.SubItems(13).Text <> "0" Then
                Contador += 1
                Latitud.Add(item.SubItems(12).Text)
                Longitud.Add(item.SubItems(13).Text)
                Nombre.Add(item.Text & "  " & item.SubItems(1).Text)
                Descripcion.Add(item.SubItems(2).Text & ", " & item.SubItems(3).Text & ", " & item.SubItems(4).Text)
            End If
        Next

        If Contador = 0 Then
            MsgBox("No existen Clientes con Latitud y Longitud capturada.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        Dim frm As New frm_Mapas
        frm.LatitudPin = Latitud.ToArray
        frm.LongitudPin = Longitud.ToArray
        frm.NombrePin = Nombre.ToArray
        frm.DescripcionPin = Descripcion.ToArray

        frm.ShowDialog()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, "Consulta de Clientes", 0, 2, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_ExportarContactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarContactos.Click
        SegundosDesconexion = 0

        Dim Status As Char
        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        Dim lsv As New cp_Listview
        Cn_Clientes.fn_Clientes_ConsultaContactos(cmb_Cliente.SelectedValue, Status, cmb_TipoCliente.SelectedValue, lsv)

        FuncionesGlobales.fn_Exportar_Excel(lsv, 2, "Consulta de Clientes con Contactos", 0, 2, frm_MENU.prg_Barra)
        lsv.Dispose()
    End Sub

    Private Sub btn_Adjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Adjunto.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 AndAlso lsv_Catalogo.SelectedItems(0).SubItems(10).Text = "BAJA" Then
            Dim frm As New frm_CargarArchivos
            frm.Filtro = "Documento de Word 97-2003 (*.doc)|*.doc|Documento de Word (*.docx)|*.xdoc|Archivo PDF(*.pdf)|*.pdf"
            frm.MaxArchivos = 1
            frm.Id_Tabla = lsv_Catalogo.SelectedItems(0).Tag
            frm.Tipo = frm_CargarArchivos.Query.ClientesBajas
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class