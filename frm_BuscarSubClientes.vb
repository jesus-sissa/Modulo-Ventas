Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_BuscarSubClientes

    Public Id_Padre As Integer = 0
    Public Id_PrecioDescripcion As Integer = 0
    Public Id_CS As Integer
    Public ClavePrecio As String
    Public Clave_Padre As String
    Public Consulta As Query = Query.InfoGnral
    Public FiltroStatus As String = "T"

    <Flags()> _
    Enum Query As Byte
        InfoGnral
        InfoFiscal
        ClientesServicios
        ClientesBaja
        ClientesProceso
        ModHorariosTemp
        ModHorariosReal
    End Enum

    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chk_Todos.BringToFront()
        If Consulta = Query.ClientesServicios OrElse Consulta = Query.ModHorariosTemp OrElse Consulta = Query.ModHorariosReal Then
            lbl_StatusSubCli.Visible = False
            cmb_StatusSubCli.Visible = False
        End If

        cmb_StatusSubCli.AgregarItem("A", "ACTIVOS")
        cmb_StatusSubCli.AgregarItem("B", "BAJAS")
        cmb_StatusSubCli.AgregarItem("T", "TODOS")
        cmb_StatusSubCli.SelectedValue = FiltroStatus

        Call Llenar_Lista()
    End Sub

    Sub Llenar_Lista()
        lsv_Clientes.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Dim SinError As Boolean = True

        Select Case Consulta
            Case Query.InfoGnral
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 30
                lsv_Clientes.Row3 = 30
                lsv_Clientes.Row4 = 20
                If Id_Padre <> 0 AndAlso cmb_StatusSubCli.SelectedValue <> "0" Then
                    SinError = fn_SubCliente_LlenarLista(1, Id_Padre, cmb_StatusSubCli.SelectedValue, False, lsv_Clientes)
                End If

            Case Query.InfoFiscal
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 25
                lsv_Clientes.Row3 = 20
                lsv_Clientes.Row4 = 45
                lsv_Clientes.Row5 = 15
                If Id_Padre <> 0 AndAlso cmb_StatusSubCli.SelectedValue <> "0" Then
                    SinError = fn_SubCliente_LlenarLista(2, Id_Padre, cmb_StatusSubCli.SelectedValue, False, lsv_Clientes)
                End If

            Case Query.ClientesServicios
                lsv_Clientes.Row1 = 10
                lsv_Clientes.Row2 = 25
                lsv_Clientes.Row3 = 15
                lsv_Clientes.Row4 = 10
                lsv_Clientes.Row5 = 25
                lsv_Clientes.Row6 = 10
                SinError = fn_SubClienteServicios_LlenarLista(Id_Padre, Id_PrecioDescripcion, ClavePrecio, "N", lsv_Clientes)

            Case Query.ClientesBaja
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 30
                lsv_Clientes.Row3 = 30
                lsv_Clientes.Row4 = 20
                If Id_Padre <> 0 AndAlso cmb_StatusSubCli.SelectedValue <> "0" Then
                    SinError = fn_SubCliente_LlenarLista(1, Id_Padre, cmb_StatusSubCli.SelectedValue, True, lsv_Clientes)
                End If

            Case Query.ClientesProceso
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 30
                lsv_Clientes.Row3 = 30
                lsv_Clientes.Row4 = 20
                If Id_Padre <> 0 AndAlso cmb_StatusSubCli.SelectedValue <> "0" Then
                    SinError = fn_SubCliente_LlenarLista(1, Id_Padre, cmb_StatusSubCli.SelectedValue, True, lsv_Clientes)
                End If

                ''Pendiente porque se iba a usar para mostrar horarios y poderlos modificar pero se dejo que en excel se hiciera
                'Case Query.ModHorariosTemp, Query.ModHorariosReal
                ''Las columnas se acomodan dentro de la función
                '    If Consulta = Query.ModHorariosTemp Then
                '        SinError = fn_Clientes_LlenarLista_HorariosTemporales(Id_Padre, Clave_Padre, Id_CS, lsv_Clientes)
                '    Else
                '        SinError = fn_Clientes_LlenarLista_HorariosReales(Id_Padre, Clave_Padre, Id_CS, lsv_Clientes)
                '    End If

        End Select
        Lbl_Registros.Text = "Registros: " & lsv_Clientes.Items.Count
        If Not SinError Then MsgBox("Ocurrio un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, 0)
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim Fila_Inicial As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Clientes.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        For Each Elemento As ListViewItem In lsv_Clientes.Items
            Elemento.Checked = chk_Todos.Checked
        Next
    End Sub

    Private Sub cmb_StatusSubCli_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_StatusSubCli.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_StatusSubCli.Visible Then Call Llenar_Lista()
    End Sub

    Private Sub lsv_Clientes_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Clientes.ItemChecked
        btn_Agregar.Enabled = lsv_Clientes.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_AgregarCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click, btn_Cerrar.Click
        Me.Close()
    End Sub

End Class