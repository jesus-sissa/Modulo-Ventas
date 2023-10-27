Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ProspectoaClientes
    Public Cliente As Boolean = True
    Public Clave As String

    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fn_BuscarClientes_LlenarLista(lsv_Clientes, Cliente, SucursalId)
        tbx_Buscar.Focus()
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        SegundosDesconexion = 0

        Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
        Me.Close()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        If lsv_Clientes.SelectedItems.Count > 0 Then Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 And lsv_Clientes.SelectedItems.Count > 0 Then Me.Close()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Clientes.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub lsv_Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.MouseHover
        SegundosDesconexion = 0
    End Sub

End Class