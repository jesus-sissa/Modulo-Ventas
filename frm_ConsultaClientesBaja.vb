Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ConsultaClientesBaja

    Private Sub frm_ConsultaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Catalogo.Columns.Add("FechaBaja")
        lsv_Catalogo.Columns.Add("UsuarioBaja")
        lsv_Catalogo.Columns.Add("ClaveCliente")
        lsv_Catalogo.Columns.Add("NombreComercial")
        lsv_Catalogo.Columns.Add("MotivoBaja")
        lsv_Catalogo.Columns.Add("PersonaSolicita")
        lsv_Catalogo.Columns.Add("Observaciones")
        lsv_Catalogo.Columns.Add("TipoCliente")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Catalogo.Columns.Add("BajaPermanente")
        dtp_Desde.Value = Today.Date
        dtp_Hasta.Value = Today.Date

        cmb_UsuarioBaja.Actualizar()
        ' cmb_MotivoBaja.AgregaParametro("@Tipo", 1, 1)
        cmb_MotivoBaja.Actualizar()
        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("V", "VALIDADO")
    End Sub

#Region "SUB's"

    Sub Botones()
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        btn_Adjunto.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Sub Buscar()
        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Sub Limpiar()
        lsv_Catalogo.Items.Clear()
        lbl_TotalLsv.Text = "0 Registros"
    End Sub

#End Region

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_UsuarioBaja.Enabled Then
                cmb_UsuarioBaja.Focus()
            ElseIf cmb_MotivoBaja.Enabled Then
                cmb_MotivoBaja.Focus()
            ElseIf cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged, dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call Botones()
    End Sub

    Private Sub cmbs_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_UsuarioBaja.SelectedValueChanged, cmb_MotivoBaja.SelectedValueChanged, cmb_Status.SelectedValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call Botones()
    End Sub

    Private Sub cmb_UsuarioBaja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_UsuarioBaja.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_MotivoBaja.Enabled Then
                cmb_MotivoBaja.Focus()
            ElseIf cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_MotivoBaja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_MotivoBaja.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_UsuarioBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_UsuarioBaja.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        cmb_UsuarioBaja.SelectedValue = 0
        cmb_UsuarioBaja.Enabled = Not chk_UsuarioBaja.Checked
        tbx_UsuarioBaja.Enabled = Not chk_UsuarioBaja.Checked
        Call Botones()
    End Sub

    Private Sub chk_MotivoBaja_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_MotivoBaja.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        cmb_MotivoBaja.SelectedValue = 0
        cmb_MotivoBaja.Enabled = Not chk_MotivoBaja.Checked
        tbx_MotivoBaja.Enabled = Not chk_MotivoBaja.Checked
        Call Botones()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        cmb_Status.SelectedValue = "0"
        cmb_Status.Enabled = Not chk_Status.Checked
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha Inicial no puede ser mayor que la Final", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If Not chk_UsuarioBaja.Checked And cmb_UsuarioBaja.SelectedValue = 0 Then
            MsgBox("Seleccione el Usuario de Baja o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_UsuarioBaja.Focus()
            Exit Sub
        End If

        If Not chk_MotivoBaja.Checked And cmb_MotivoBaja.SelectedValue = 0 Then
            MsgBox("Seleccione el Motivo de Baja o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If Not chk_Status.Checked And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione el Status o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        Dim Status As Char
        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        If Not fn_ClientesBaja_Consulta(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_UsuarioBaja.SelectedValue, cmb_MotivoBaja.SelectedValue, Status, lsv_Catalogo) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lbl_TotalLsv.Text = lsv_Catalogo.Items.Count.ToString & " Registros"
        Call Botones()
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0
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

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 1, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Adjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Adjunto.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Dim frm As New frm_CargarArchivos
            frm.Filtro = "Documento de Word 97-2003 (*.doc)|*.doc|Documento de Word (*.docx)|*.xdoc|Archivo PDF(*.pdf)|*.pdf"
            frm.MaxArchivos = 1
            frm.Id_Tabla = lsv_Catalogo.SelectedItems(0).SubItems(10).Text
            frm.Tipo = frm_CargarArchivos.Query.ClientesBajas
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class