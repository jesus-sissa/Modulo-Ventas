Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ContratosClausulas
    Public Dt_Clausulas As DataTable = Nothing
    Public Dt_Agregado As DataTable = Nothing

    Private Sub frm_ContratosModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        Me.Show()

        'Llena lista de Clausulas Activos
        If Dt_Clausulas IsNot Nothing Then
            dgv_Clausulas.DataSource = Dt_Clausulas
            dgv_Clausulas.Columns("Numero_Clausula").Visible = False
            dgv_Clausulas.Columns("Numero_Ordinario").Visible = False
        End If
        btn_Agregar.Enabled = dgv_Clausulas.RowCount > 0

        If dgv_Clausulas.RowCount = 0 Then
            MsgBox("No existen Cláusulas agregadas al Catálogo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Llena Clausulas Agregados
        If Dt_Agregado IsNot Nothing Then
            dgv_Agregados.DataSource = Dt_Agregado
            dgv_Agregados.Columns("Id_ClausulaD").Visible = False
        End If
        btn_Quitar.Enabled = dgv_Agregados.RowCount > 0
        If dgv_Agregados.RowCount = 0 Then
            btn_Bajar.Enabled = False
            btn_Subir.Enabled = False
        End If
        For Each claus As DataGridViewRow In dgv_Clausulas.Rows
            For Each clausADD As DataGridViewRow In dgv_Agregados.Rows
                If clausADD.Cells("Id_ClausulaD").Value = claus.Cells("Id_Clausula").Value Then
                    claus.Cells("Marcar").Value = True
                    claus.Cells("Marcar").ReadOnly = True
                    claus.DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        Next
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0
        If dgv_Clausulas.RowCount = 0 Then
            MsgBox("No existen Cláusulas a agregar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        J = 0
        Dt_Agregado = Dt_Clausulas.Clone
        For Each DgvR_Clausula As DataGridViewRow In dgv_Clausulas.Rows
            Dim DgvChk As DataGridViewCheckBoxCell = DgvR_Clausula.Cells("Marcar")
            If DgvChk.Value = True Then
                J += 1
                Dt_Agregado.ImportRow(Dt_Clausulas.Rows(DgvR_Clausula.Index))
                Dt_Agregado.Rows(J - 1).Item("Numero_Clausula") = J
                Dt_Agregado.Rows(J - 1).Item("Numero_Ordinario") = NumeroOrdinal(J)
                DgvR_Clausula.Cells("Marcar").ReadOnly = True
                DgvR_Clausula.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
        If J = 0 Then
            MsgBox("Debe Marcar una o varias Cláusulas de la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        dgv_Agregados.DataSource = Dt_Agregado
        dgv_Agregados.Sort(dgv_Agregados.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
        dgv_Agregados.Columns("Status").Visible = False
        btn_Quitar.Enabled = True

    End Sub

    Private Sub btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Quitar.Click
        SegundosDesconexion = 0
        Dim Fila As Integer = 0
        Dim BorrarCla As Boolean = False
        For Index As Integer = 0 To dgv_Agregados.Rows.Count - 1
            Dim Chk As DataGridViewCheckBoxCell = dgv_Agregados.Rows(Fila).Cells("MarcarA")
            If Chk.Value = True Then
                For Each DgvR_Clausula As DataGridViewRow In dgv_Clausulas.Rows
                    If DgvR_Clausula.Cells("Id_Clausula").Value = dgv_Agregados.Rows(Fila).Cells("Id_ClausulaD").Value Then
                        DgvR_Clausula.Cells("Marcar").Value = False
                        DgvR_Clausula.DefaultCellStyle.BackColor = Color.White
                        DgvR_Clausula.Cells("Marcar").ReadOnly = False
                        Exit For
                    End If
                Next
                dgv_Agregados.Rows.Remove(dgv_Agregados.Rows(Fila))
                BorrarCla = True
            Else
                Fila += 1
            End If
        Next
        Dt_Agregado.AcceptChanges() 'refresca el Dt Sourceado
        If BorrarCla = False Then
            MsgBox("Debe marcar una o varias Cláusulas a remover", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        J = 1
        For Each DgvR_Agregados As DataGridViewRow In dgv_Agregados.Rows
            DgvR_Agregados.Cells("Numero_Clausula").Value = J
            DgvR_Agregados.Cells("Numero_Ordinario").Value = NumeroOrdinal(J)
            J += 1
        Next

        btn_Quitar.Enabled = dgv_Agregados.RowCount > 0
        If dgv_Agregados.RowCount = 0 Then
            btn_Bajar.Enabled = False
            btn_Subir.Enabled = False
        Else
            dgv_Agregados.Rows(0).Selected = True
            Call BotonesBajarSubir(0)
        End If
    End Sub

    Private Sub btn_Subir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Subir.Click
        SegundosDesconexion = 0
        Dim filasel As Integer = dgv_Agregados.SelectedCells(0).RowIndex

        If dgv_Agregados.SelectedCells(0).RowIndex = 0 Then Exit Sub
        dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex - 1).Cells("Numero_Clausula").Value = dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex - 1).Cells("Numero_Clausula").Value + 1
        dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex).Cells("Numero_Clausula").Value = dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex).Cells("Numero_Clausula").Value - 1
        J = 0
        For Each DgvR_Agregados As DataGridViewRow In dgv_Agregados.Rows
            DgvR_Agregados.Cells("Numero_Ordinario").Value = NumeroOrdinal(DgvR_Agregados.Cells("Numero_Clausula").Value)
            J += 1
        Next
        dgv_Agregados.Sort(dgv_Agregados.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        Call BotonesBajarSubir(filasel - 1)
        If dgv_Agregados.Rows(filasel - 1).Selected = False Then
            dgv_Agregados.Rows(filasel - 1).Selected = True
        End If
    End Sub

    Private Sub btn_Bajar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bajar.Click
        SegundosDesconexion = 0

        Dim filasel As Integer = dgv_Agregados.SelectedCells(0).RowIndex

        If dgv_Agregados.SelectedCells(0).RowIndex = dgv_Agregados.Rows.Count - 1 Then Exit Sub
        dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex + 1).Cells("Numero_Clausula").Value = dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex + 1).Cells("Numero_Clausula").Value - 1
        dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex).Cells("Numero_Clausula").Value = dgv_Agregados.Rows(dgv_Agregados.SelectedCells(0).RowIndex).Cells("Numero_Clausula").Value + 1
        J = 0
        For Each DgvR_Agregados As DataGridViewRow In dgv_Agregados.Rows
            DgvR_Agregados.Cells("Numero_Ordinario").Value = NumeroOrdinal(DgvR_Agregados.Cells("Numero_Clausula").Value)
            J += 1
        Next
        dgv_Agregados.Sort(dgv_Agregados.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        Call BotonesBajarSubir(filasel + 1)
        If dgv_Agregados.Rows(filasel + 1).Selected = False Then
            dgv_Agregados.Rows(filasel + 1).Selected = True
        End If
    End Sub

    Private Sub BotonesBajarSubir(ByVal fila As Integer)
        btn_Subir.Enabled = True
        btn_Bajar.Enabled = True
        If fila = 0 Then btn_Subir.Enabled = False
        If fila = dgv_Agregados.RowCount - 1 Then btn_Bajar.Enabled = False
    End Sub

    Private Sub dgv_Agregados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Agregados.CellClick
        SegundosDesconexion = 0
        Call BotonesBajarSubir(e.RowIndex)
    End Sub

    Private Function NumeroOrdinal(ByVal Numero As Integer) As String
        Dim Ordinal As String = ""

        Dim Largo = Numero.ToString.Length
        For A As Integer = 0 To Largo - 1
            If (Largo - A) = 3 Then
                Select Case Numero.ToString.Substring(A, 1)
                    Case Is = "1"
                        Ordinal = "CENTESIMA "
                End Select
            ElseIf (Largo - A) = 2 Then
                Select Case Numero.ToString.Substring(A, 1)
                    Case Is = "1"
                        Ordinal = Ordinal & "DECIMA "
                    Case Is = "2"
                        Ordinal = Ordinal & "VIGESIMA "
                    Case Is = "3"
                        Ordinal = Ordinal & "TRIGESIMA "
                    Case Is = "4"
                        Ordinal = Ordinal & "CUADRAGESIMA "
                    Case Is = "5"
                        Ordinal = Ordinal & "QUINCUAGESIMA "
                    Case Is = "6"
                        Ordinal = Ordinal & "SEXAGESIMA "
                    Case Is = "7"
                        Ordinal = Ordinal & "SEPTUAGESIMA "
                    Case Is = "8"
                        Ordinal = Ordinal & "OCTAGESIMA "
                    Case Is = "9"
                        Ordinal = Ordinal & "NONAGESIMA "
                End Select
            ElseIf (Largo - A) = 1 Then
                Select Case Numero.ToString.Substring(A, 1)
                    Case Is = "1"
                        Ordinal = Ordinal & "PRIMERA"
                    Case Is = "2"
                        Ordinal = Ordinal & "SEGUNDA"
                    Case Is = "3"
                        Ordinal = Ordinal & "TERCERA"
                    Case Is = "4"
                        Ordinal = Ordinal & "CUARTA"
                    Case Is = "5"
                        Ordinal = Ordinal & "QUINTA"
                    Case Is = "6"
                        Ordinal = Ordinal & "SEXTA"
                    Case Is = "7"
                        Ordinal = Ordinal & "SEPTIMA"
                    Case Is = "8"
                        Ordinal = Ordinal & "OCATAVA"
                    Case Is = "9"
                        Ordinal = Ordinal & "NOVENA"
                End Select
            End If
        Next
        Return Ordinal.Trim
    End Function

    Private Sub btn_Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Regresar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_ContratosModal_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            dgv_Clausulas.Columns("Marcar").Width = dgv_Clausulas.Width * 0.03
            dgv_Clausulas.Columns("Descripcion").Width = dgv_Clausulas.Width * 0.42
            dgv_Clausulas.Columns("Comentarios").Width = dgv_Clausulas.Width * 0.42
            dgv_Clausulas.Columns("Status").Width = dgv_Clausulas.Width * 0.1

            dgv_Agregados.Columns("MarcarA").Width = dgv_Agregados.Width * 0.03
            dgv_Agregados.Columns("DescripcionA").Width = dgv_Agregados.Width * 0.42
            dgv_Agregados.Columns("ComentariosA").Width = dgv_Agregados.Width * 0.42
            dgv_Agregados.Columns("Numero_Clausula").Width = dgv_Agregados.Width * 0.1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgv_Agregados_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Agregados.DataError
        MsgBox("Dato No válido, Capture un  número.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

 
End Class