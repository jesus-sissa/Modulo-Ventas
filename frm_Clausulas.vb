Imports Modulo_Ventas.Cn_Clientes

Public Class frm_Clausulas

    Private Sub frm_Clausulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        tab_ClausulaNueva.Tag = 1
        tab_SubClausulaNueva.Tag = 1

        Me.tab_SubClausulaNueva.Parent = Nothing
        Call LlenarListaC()
    End Sub

    Private Sub btn_GuardarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarC.Click

        SegundosDesconexion = 0
        If rtb_DescripcionC.Text.Trim = "" Then
            MsgBox("Capture una Descripción para la nueva Cláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_DescripcionC.Focus()
            Exit Sub
        End If
        Select Case tab_ClausulaNueva.Tag
            Case 1 'Nuevo
                If fn_Clausulas_Guardar(rtb_DescripcionC.Text.Trim, tbx_ComentariosC.Text.Trim) = False Then
                    MsgBox("Ocurrió un error al guardar la Cláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                Else
                    rtb_DescripcionC.Clear()
                    tbx_ComentariosC.Clear()
                    Call LlenarListaC()
                End If
            Case 2 'Modificar
                If fn_Clausulas_Modificar(rtb_DescripcionC.Tag, rtb_DescripcionC.Text, tbx_ComentariosC.Text) = False Then
                    MsgBox("Ocurrió un error al modificar la Claúsula", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                Else
                    rtb_DescripcionC.Clear()
                    tbx_ComentariosC.Clear()
                    Call LlenarListaC()
                    tab_Clausulas.SelectedTab = tab_Listado
                End If
        End Select
    End Sub

    Private Sub chk_Clausula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Clausula.CheckedChanged
        SegundosDesconexion = 0
        Call LlenarListaC()
    End Sub

    Private Sub btn_StatusC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatusC.Click
        SegundosDesconexion = 0
        If dgv_Clausula.RowCount = 0 Then Exit Sub

        Dim Cla_Agregadas As Boolean = False
        J = 0
        For Each dr_Clausula As DataGridViewRow In dgv_Clausula.Rows
            Dim DgvChk As DataGridViewCheckBoxCell = dr_Clausula.Cells("Marcar")
            If DgvChk.Value = True Then
                J += 1
                If fn_Contratos_ClausulaEnContrato(dr_Clausula.Cells("Id_Clausula").Value) = False Then
                    DgvChk.Value = False 'si se encuentra se Desmarca
                    Cla_Agregadas = True
                    J -= 1
                End If
            End If
        Next

        If Cla_Agregadas Then
            MsgBox("Algunas Cláusulas se desmarcaron porque ya se encuentran agregadas a algún Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            If J = 0 Then Exit Sub
        End If

        If J = 0 And Cla_Agregadas = False Then
            MsgBox("Debe marcar una o varias filas para afectar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Frm As New frm_FirmaElectronica
        Frm.PedirObservaciones = True
        Frm.Bloquear = True
        Frm.ShowDialog()
        If Frm.Firma = False Then Exit Sub

        If fn_Clausulas_Status(dgv_Clausula, Frm.Observaciones) = False Then
            MsgBox("Error al modificar Baja/Reingreso de la(s) Cláusula(s).", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call LlenarListaC()
    End Sub

    Private Sub btn_ModificarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ModificarC.Click
        'en el tag=1(Nuevo) 2(Modificar)
        SegundosDesconexion = 0
        If dgv_Clausula.RowCount = 0 Then Exit Sub

        Dim filaSelec As Integer = dgv_Clausula.SelectedCells(0).RowIndex
        If fn_Contratos_ClausulaEnContrato(dgv_Clausula.Rows(filaSelec).Cells("Id_Clausula").Value) = False Then
            MsgBox("No se puede afectar una Cláusula agregada a un Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        rtb_DescripcionC.Text = dgv_Clausula.Rows(filaSelec).Cells("Descripcion").Value
        rtb_DescripcionC.Tag = dgv_Clausula.Rows(filaSelec).Cells("Id_Clausula").Value
        tbx_ComentariosC.Text = dgv_Clausula.Rows(filaSelec).Cells("Comentarios").Value

        tab_ClausulaNueva.Text = "Modificar_C"
        tab_ClausulaNueva.Tag = 2 'Modificar
        tab_Clausulas.SelectedTab = tab_ClausulaNueva
    End Sub

    Private Sub btn_ModificarSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ModificarSC.Click
        SegundosDesconexion = 0
        'en el tag=1(Nuevo), 2(Modificar)
        If dgv_Detalle.RowCount = 0 Then Exit Sub

        Dim filaSelec As Integer = dgv_Detalle.SelectedCells(0).RowIndex
        rtb_DescripcionD.Text = dgv_Detalle.Rows(filaSelec).Cells("DescripcionD").Value
        rtb_DescripcionD.Tag = dgv_Detalle.Rows(filaSelec).Cells("Id_ClausulaD").Value
        tbx_ComentariosD.Text = dgv_Detalle.Rows(filaSelec).Cells("ComentariosD").Value

        tab_SubClausulaNueva.Text = "Modificar_SC"
        tab_SubClausulaNueva.Tag = 2 'Modificar
        Me.tab_SubClausulaNueva.Parent = tab_Clausulas
        tab_Clausulas.SelectedTab = tab_SubClausulaNueva

    End Sub

    Private Sub btn_CancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarC.Click
        SegundosDesconexion = 0
        rtb_DescripcionC.Clear()
        tbx_ComentariosC.Clear()
        tab_Clausulas.SelectedTab = tab_Listado
    End Sub

    Private Sub btn_CancelarD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarD.Click
        SegundosDesconexion = 0
        rtb_DescripcionD.Clear()
        tbx_ComentariosD.Clear()
        tab_Clausulas.SelectedTab = tab_Listado
        Me.tab_SubClausulaNueva.Parent = Nothing
    End Sub

    Private Sub tab_Clausulas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Clausulas.SelectedIndexChanged
        SegundosDesconexion = 0
        If tab_Clausulas.SelectedIndex = 0 Then
            rtb_DescripcionD.Clear()
            rtb_DescripcionC.Clear()
            tbx_ComentariosC.Clear()
            tbx_ComentariosD.Clear()
            Me.tab_SubClausulaNueva.Parent = Nothing
            tab_SubClausulaNueva.Text = "NuevaSubClausula"
            tab_ClausulaNueva.Text = "NuevaClausula"
            tab_SubClausulaNueva.Tag = 1 'nuevo
            tab_ClausulaNueva.Tag = 1 'nuevo
        ElseIf tab_Clausulas.SelectedIndex = 2 Then
            Dim dt_Detalle As DataTable
            dt_Detalle = fn_Clausulas_LlenarDetalle(rtb_DescripcionD.Tag, IIf(chk_Clausula.Checked, "A", "T"))
            If dt_Detalle Is Nothing Then
                MsgBox("Ocurrió un error al cargar el detalle de las Cláusulas", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            dgv_DetalleC.DataSource = dt_Detalle
        End If
    End Sub

    Private Sub btn_StatusSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatusSC.Click
        SegundosDesconexion = 0
        J = 0
        For Each dr_Detalle As DataGridViewRow In dgv_Detalle.Rows
            Dim DgvChk As DataGridViewCheckBoxCell = dr_Detalle.Cells("MarcarD")
            If DgvChk.Value = True Then
                J += 1
            End If
        Next

        If J = 0 Then
            MsgBox("Debe marcar una Fila para afectar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()
        If Frm.Firma = False Then Exit Sub

        If fn_Clausulas_StatusD(dgv_Detalle, Frm.Observaciones) = False Then
            MsgBox("Error al cambiar el status del detalle de la Cláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim status As String = "T"
        If chk_Clausula.Checked Then status = "A"
        Dim dt_Detalle As DataTable = fn_Clausulas_LlenarDetalle(dgv_Clausula.Rows(dgv_Clausula.SelectedCells(0).RowIndex).Cells("Id_Clausula").Value, status)
        dgv_Detalle.DataSource = dt_Detalle
    End Sub

    Private Sub btn_GuardarSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarSC.Click
        SegundosDesconexion = 0
        If rtb_DescripcionD.Text.Trim = "" Then
            MsgBox("Capture una Descripción para la nueva Subcláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_DescripcionC.Focus()
            Exit Sub
        End If

        Select Case tab_SubClausulaNueva.Tag
            Case 1 'Nuevo
                If fn_Clausulas_GuardarD(rtb_DescripcionD.Tag, rtb_DescripcionD.Text, tbx_ComentariosD.Text) = False Then
                    MsgBox("Ocurrió un error al guardar la Subcláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                Else
                    rtb_DescripcionD.Clear()
                    tbx_ComentariosD.Clear()
                    dgv_DetalleC.DataSource = fn_Clausulas_LlenarDetalle(rtb_DescripcionD.Tag, IIf(chk_Detalle.Checked, "A", "T"))
                End If

            Case 2 'Modific
                Dim Frm As New frm_FirmaElectronica
                Frm.Bloquear = True
                Frm.PedirObservaciones = False
                Frm.ShowDialog()
                If Frm.Firma = False Then Exit Sub

                If fn_Clasulas_ModificarD(rtb_DescripcionD.Tag, rtb_DescripcionD.Text, tbx_ComentariosD.Text) = False Then
                    MsgBox("Ocurrió un error al modificar la Subcláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                Else
                    rtb_DescripcionD.Clear()
                    tbx_ComentariosD.Clear()
                    Dim status As String = "T"
                    If chk_Clausula.Checked Then status = "A"
                    Dim dt_Detalle As DataTable = fn_Clausulas_LlenarDetalle(dgv_Clausula.Rows(dgv_Clausula.SelectedCells(0).RowIndex).Cells("Id_Clausula").Value, status)
                    dgv_Detalle.DataSource = dt_Detalle

                    tab_Clausulas.SelectedTab = tab_Listado
                End If
        End Select
    End Sub

    Private Sub btn_DetalleC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DetalleC.Click
        SegundosDesconexion = 0

        If dgv_Clausula.RowCount = 0 Then Exit Sub
        Dim filaSelec As Integer = dgv_Clausula.SelectedCells(0).RowIndex
        If fn_Contratos_ClausulaEnContrato(dgv_Clausula.Rows(filaSelec).Cells("Id_Clausula").Value) = False Then
            MsgBox("No se puede afectar una Cláusula agregada a un Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        rtb_DescripcionD.Tag = dgv_Clausula.Rows(filaSelec).Cells("Id_Clausula").Value

        tab_SubClausulaNueva.Text = "NuevaSubClausula"
        Me.tab_SubClausulaNueva.Parent = tab_Clausulas
        tab_Clausulas.SelectedTab = tab_SubClausulaNueva

    End Sub

    Private Sub LlenarListaC()
        Dim dt_Clausulas As DataTable
        dt_Clausulas = fn_Clausulas_LlenarLista(IIf(chk_Clausula.Checked, "A", "T"))

        If dt_Clausulas Is Nothing Then
            MsgBox("ocurrió un error al cargar la información de las Cláusulas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        dgv_Clausula.DataSource = dt_Clausulas
    End Sub

    Private Sub chk_DetalleC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DetalleC.CheckedChanged
        If dgv_DetalleC.DataSource Is Nothing Then Exit Sub

        Dim status As String = "T"
        If chk_DetalleC.Checked Then status = "A"
        Dim dt_Detalle As DataTable = fn_Clausulas_LlenarDetalle(dgv_Clausula.Rows(dgv_Clausula.SelectedCells(0).RowIndex).Cells("Id_Clausula").Value, status)
        dgv_DetalleC.DataSource = dt_Detalle
    End Sub

    Private Sub chk_Detalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Detalle.CheckedChanged
        If dgv_Detalle.DataSource Is Nothing Then Exit Sub
        Dim status As String = "T"
        If chk_Detalle.Checked Then status = "A"
        Dim dt_Detalle As DataTable = fn_Clausulas_LlenarDetalle(dgv_Clausula.Rows(dgv_Clausula.SelectedCells(0).RowIndex).Cells("Id_Clausula").Value, status)
        dgv_Detalle.DataSource = dt_Detalle
    End Sub

    Private Sub dgv_Clausula_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Clausula.CellClick
        SegundosDesconexion = 0
        If dgv_Clausula.DataSource Is Nothing Then Exit Sub

        Dim status As String = "T"
        If chk_Clausula.Checked Then status = "A"
        Dim dt_Detalle As DataTable = fn_Clausulas_LlenarDetalle(dgv_Clausula.Rows(e.RowIndex).Cells("Id_Clausula").Value, status)

        If dt_Detalle Is Nothing Then
            MsgBox("Ocurrió un error al cargar el detalle de la Cláusula.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        dgv_Detalle.DataSource = dt_Detalle
        btn_StatusSC.Enabled = dt_Detalle.Rows.Count > 0
        btn_ModificarSC.Enabled = dt_Detalle.Rows.Count > 0
    End Sub

    Private Sub tbx_ComentariosC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_ComentariosC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_GuardarC.Focus()
        End If
    End Sub

    Private Sub frm_Clausulas_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If dgv_Clausula.Columns.Count > 0 Then
            dgv_Clausula.Columns("Marcar").Width = 50
            dgv_Clausula.Columns("Descripcion").Width = (dgv_Clausula.Width - 250) / 2
            dgv_Clausula.Columns("Comentarios").Width = (dgv_Clausula.Width - 250) / 2
            dgv_Clausula.Columns("Status").Width = 150
        End If

        If dgv_Detalle.Columns.Count > 0 Then
            dgv_Detalle.Columns("MarcarD").Width = 50
            dgv_Detalle.Columns("DescripcionD").Width = (dgv_Detalle.Width - 250) / 2
            dgv_Detalle.Columns("ComentariosD").Width = (dgv_Detalle.Width - 250) / 2
            dgv_Detalle.Columns("StatusD").Width = 150
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub rtb_DescripcionC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_DescripcionC.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rtb_DescripcionD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_DescripcionD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class