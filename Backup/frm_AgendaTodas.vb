Imports System.Windows.Forms
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_AgendaTodas

    Public Año As Integer
    Public Mes As Byte
    Public Id_Empleado As Integer

    Private Sub frm_AgendaTodas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Tareas.Columns.Add("Fecha")
        lsv_Tareas.Columns.Add("Inicio")
        lsv_Tareas.Columns.Add("Fin")
        lsv_Tareas.Columns.Add("Asunto")
        lsv_Tareas.Columns.Add("Descripcion")
        lsv_Tareas.Columns.Add("Status")

        Me.Text = "Tareas de: " & UsuarioN & " Mes: " & MesesLargo(Mes) & " de " & Año.ToString
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        rtb_Descripcion.Clear()
        btn_Detalle.Enabled = False
        If Not fn_Agenda_MesGet(lsv_Tareas, Año, Mes, Id_Empleado) Then
            MsgBox("Ocurrió un Error al intentar mostrar las Tareas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        For Each Elemento As ListViewItem In lsv_Tareas.Items
            If Elemento.SubItems(5).Text = "PENDIENTE" Then
                Elemento.ForeColor = Color.Green
            ElseIf Elemento.SubItems(5).Text = "CANCELADA" Then
                Elemento.ForeColor = Color.Red
            ElseIf Elemento.SubItems(5).Text = "FINALIZADA" Then
                Elemento.ForeColor = Color.Gray
            ElseIf Elemento.SubItems(5).Text = "POSPUESTA" Then
                Elemento.ForeColor = Color.Goldenrod
            End If
        Next
    End Sub

    Private Sub lsv_Tareas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Tareas.SelectedIndexChanged
        SegundosDesconexion = 0
        rtb_Descripcion.Clear()
        btn_Detalle.Enabled = False
        If lsv_Tareas.SelectedItems.Count > 0 Then
            rtb_Descripcion.Text = lsv_Tareas.SelectedItems(0).SubItems(4).Text
            btn_Detalle.Enabled = True
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Detalle.Click, lsv_Tareas.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frm_AgendaCita
        frm.IdAgenda = lsv_Tareas.SelectedItems(0).Tag
        frm.ShowDialog()
        Me.Cursor = Cursors.Default
        Call LlenarLista()
    End Sub
End Class