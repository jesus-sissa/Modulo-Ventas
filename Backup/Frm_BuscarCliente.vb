Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class Frm_BuscarCliente

    Public Cliente As Boolean = True
    Public Llamadas As Boolean = False
    Public Id_Sucursal As Integer = SucursalId
    Public Empresa As String
    Public Clave As String
    Public Consulta As Query = Query.Clientes
    Public Id As Integer = 0

    <Flags()> _
    Enum Query As Byte
        Clientes
        Empleados
        CajaBancaria
        Llamadas
        CajasFuertes
        Proveedores
        Prospectos
        Contactos
        ClientesPadre
        ClientesCajasFuerte
    End Enum

    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Llenar_Lista()
    End Sub

    Sub Llenar_Lista()
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        Select Case Consulta
            Case Query.Clientes
                Me.Size = New Size(654, 449)
                lsv_Clientes.Row1 = 37
                lsv_Clientes.Row2 = 10
                lsv_Clientes.Row3 = 37
                lsv_Clientes.Row4 = 10
                Dim SoloActivos As Boolean = chk_SoloActivos.Checked = True
                If Not fn_BuscarClientes_LlenarLista(lsv_Clientes, SoloActivos, Id_Sucursal, Cliente) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                For Each Elemento As ListViewItem In lsv_Clientes.Items
                    If Elemento.SubItems(3).Text <> "ACTIVO" Then
                        Elemento.ForeColor = Color.Red
                    End If
                Next
                Text = "Buscar Clientes"

            Case Query.Empleados
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaEmpleados(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Empleados"

            Case Query.CajaBancaria
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaCajasBancarias(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las Cajas Bancarias.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Cajas Bancarias"

            Case Query.Llamadas
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 65
                If Not fn_Seguimiento_BuscarLlamadas(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las Llamadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Llamadas"
                chk_SoloActivos.Visible = False

            Case Query.CajasFuertes
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 13
                lsv_Clientes.Row3 = 13
                lsv_Clientes.Row4 = 20
                lsv_Clientes.Row5 = 12
                lsv_Clientes.Row6 = 12
                lsv_Clientes.Row7 = 18
                lsv_Clientes.Row8 = 19
                lsv_Clientes.Row9 = 13
                Dim Status As String = "V"
                If Not chk_SoloActivos.Checked Then Status = "T"
                If Not fn_BuscarClientes_LlenarListaCajasFuertes(Id, Status, lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las Cajas Fuertes.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Detalle de Servicios de Cajas Fuertes"
                chk_SoloActivos.Text = "Solo Validados"
                lbl_DobleClick.Text = "Doble Click para Mostrar el Detalle de la Caja Fuerte."

            Case Query.Proveedores
                lsv_Clientes.Row1 = 10
                lsv_Clientes.Row2 = 70
                lsv_Clientes.Row3 = 15
                Dim SoloActivos As Boolean = chk_SoloActivos.Checked = True
                If Not fn_BuscarClientes_LlenarListaProveedores(lsv_Clientes, SoloActivos) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Proveedores.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Proveedores"
                chk_SoloActivos.Text = "Mostrar solo Proveedores Activos"

            Case Query.Prospectos
                Me.Size = New Size(654, 449)
                chk_SoloActivos.Visible = False
                lsv_Clientes.Row1 = 35
                lsv_Clientes.Row2 = 10
                lsv_Clientes.Row3 = 35
                lsv_Clientes.Row4 = 15
                Dim SoloActivos As Boolean = chk_SoloActivos.Checked = True
                If Not fn_BuscarProspectos_LlenarLista(lsv_Clientes, SoloActivos) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Prospectos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Prospectos"

            Case Query.Contactos
                lsv_Clientes.Row1 = 14
                lsv_Clientes.Row2 = 14
                lsv_Clientes.Row3 = 14
                lsv_Clientes.Row4 = 14
                lsv_Clientes.Row5 = 30
                lsv_Clientes.Row6 = 0
                lsv_Clientes.Row7 = 0
                lsv_Clientes.Row8 = 0
                lsv_Clientes.Row9 = 0
                lsv_Clientes.Row10 = 0
                chk_SoloActivos.Visible = False
                If Not fn_Clientes_ContactosBuscar(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Contactos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If

            Case Query.ClientesPadre
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 60
                lsv_Clientes.Row3 = 20
                Dim SoloActivos As Boolean = chk_SoloActivos.Checked = True
                If Not fn_BuscarClientes_Padres(SoloActivos, lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Clientes Padres.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Clientes Padres"

            Case Query.ClientesCajasFuerte
                chk_SoloActivos.Visible = False
                lsv_Clientes.Row1 = 10
                lsv_Clientes.Row2 = 35
                lsv_Clientes.Row3 = 18
                lsv_Clientes.Row4 = 15
                lsv_Clientes.Row5 = 18
                'La Variable Clave se usará para traer todos los Id's de los Clientes que se enlistaran
                If Not fn_BuscarClientes_ConCajaFuerte(Clave, lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Clientes con Cajas Fuertes Rentadas o en Proceso de Renta.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Clientes con Cajas Fuertes"

        End Select
        Lbl_Registros.Text = "Registros: " & lsv_Clientes.Items.Count
        tbx_Buscar.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        SegundosDesconexion = 0

        Select Case Consulta
            Case Query.Clientes
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Empleados
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.CajaBancaria
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Llamadas
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Empresa = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Proveedores
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Prospectos
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Contactos
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.CajasFuertes
                Dim frm As New frm_CajasFuertesD
                frm.Id_CajaFuerte = lsv_Clientes.SelectedItems(0).Tag
                frm.ShowDialog()
                Exit Sub
            Case Query.ClientesPadre
                Id = lsv_Clientes.SelectedItems(0).Tag
                Clave = lsv_Clientes.SelectedItems(0).Text
        End Select

        Me.Close()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0

        Select Case Consulta
            Case Query.Clientes
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Empleados
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.CajaBancaria
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Llamadas
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Proveedores
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Prospectos
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Contactos
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.ClientesPadre
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Id = lsv_Clientes.SelectedItems(0).Tag
                    Clave = lsv_Clientes.SelectedItems(0).Text
                End If

        End Select
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = 13 And lsv_Clientes.SelectedItems.Count > 0 Then Me.Close()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        SegundosDesconexion = 0

        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, 0)
    End Sub

    Private Sub chk_SoloActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SoloActivos.CheckedChanged
        SegundosDesconexion = 0

        Call Llenar_Lista()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Clientes.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

End Class