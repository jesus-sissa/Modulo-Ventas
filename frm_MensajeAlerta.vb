Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_MensajeAlerta

    Public MensajeFinal As String = ""
    Public MensajeTexto As String = ""

    Private Sub frm_MensajeAlerta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Material.AgregaParametro("@Status", "A", 0)
        cmb_Material.Actualizar()
        lsv_Material.Columns.Add("Cantidad")
        lsv_Material.Columns(0).Width = 100
        lsv_Material.Columns.Add("Materiales")
        lsv_Material.Columns(1).Width = 500

        'If Cliente > 0 AndAlso MensajeFinal = "" Then
        '    Dim Dr_Cliente As DataRow = fn_Clientes_Generales(Cliente)
        '    If Dr_Cliente IsNot Nothing Then
        '        Dim PrimerArr() As String
        '        Dim SegundoArr() As String
        '        Dim TercerArr() As String
        '        PrimerArr = Split(Dr_Cliente("MensajeAlerta"), ";")
        '        For JLocal As Integer = 0 To (PrimerArr.Length - 2)
        '            SegundoArr = Split(PrimerArr(JLocal), ",")
        '            lsv_Material.Items.Add(SegundoArr(0)).SubItems.Add(SegundoArr(1))
        '        Next
        '        lsv_Material.Columns(0).Width = 100
        '        lsv_Material.Columns(1).Width = 500
        '        TercerArr = Split(Dr_Cliente("MensajeAlerta"), "/")
        '        If TercerArr.Length > 1 Then
        '            rtb_MensajeAlerta.Text = TercerArr(1)
        '        End If
        '    End If
        'Else
        If MensajeFinal <> "" Then
            Dim PrimerArr() As String
            Dim SegundoArr() As String
            Dim TercerArr() As String
            PrimerArr = Split(MensajeFinal, ";")
            For JLocal As Integer = 0 To (PrimerArr.Length - 2)
                SegundoArr = Split(PrimerArr(JLocal), ",")
                lsv_Material.Items.Add(SegundoArr(0)).SubItems.Add(SegundoArr(1))
            Next
            lsv_Material.Columns(0).Width = 100
            lsv_Material.Columns(1).Width = 500
            TercerArr = Split(MensajeFinal, "/")
            If TercerArr.Length > 1 Then
                rtb_MensajeAlerta.Text = TercerArr(1)
            End If
        End If
        'End If
    End Sub

    Private Sub rtb_MensajeAlerta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_MensajeAlerta.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        SegundosDesconexion = 0

        MensajeFinal = ""
        MensajeTexto = ""

        For Each Elemento As ListViewItem In lsv_Material.Items
            MensajeFinal = Elemento.Text & "," & Elemento.SubItems(1).Text & ";" & MensajeFinal
            MensajeTexto = Elemento.Text & ", " & Elemento.SubItems(1).Text & "; " & MensajeTexto
        Next
        If MensajeFinal = "" And rtb_MensajeAlerta.TextLength > 0 Then
            MensajeFinal = "/" & rtb_MensajeAlerta.Text
        ElseIf MensajeFinal <> "" Then
            MensajeFinal = MensajeFinal & "/" & rtb_MensajeAlerta.Text
        End If
        If MensajeTexto = "" Then
            MensajeTexto = rtb_MensajeAlerta.Text
        ElseIf rtb_MensajeAlerta.TextLength > 0 Then
            MensajeTexto = MensajeTexto & " " & rtb_MensajeAlerta.Text
        End If

        'If Cliente > 0 Then
        '    frm_Clientes.MensajeAlerta = MensajeFinal
        '    frm_Clientes.rtb_MensajeAlerta.Text = MensajeTexto
        'Else
        '    frm_NuevoProspecto.MensajeAlerta = MensajeFinal
        '    frm_NuevoProspecto.rtb_MensajeAlerta.Text = MensajeTexto
        'End If
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        If cmb_Material.SelectedValue = 0 Or tbx_Cantidad.TextLength = 0 Then
            MsgBox("Ingrese los valores correspondientes para poder agregar un registro", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            lsv_Material.Items.Add(tbx_Cantidad.Text).SubItems.Add(cmb_Material.Text)
            tbx_Cantidad.Focus()
        End If
    End Sub

    Private Sub lsv_Material_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Material.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Limpiar.Enabled = lsv_Material.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        SegundosDesconexion = 0

        lsv_Material.SelectedItems(0).Remove()
    End Sub

End Class