Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ConsultaClientesListaNegra

    Private Sub frm_ConsultaClientesListaNegra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Catalogo.Columns.Add("Cliente")
        lsv_Catalogo.Columns.Add("Observaciones")
        lsv_Catalogo.Columns.Add("FechaBaja")

        dtp_Desde.Value = Today.Date
        dtp_Hasta.Value = Today.Date
        cmb_Cliente.Actualizar()
    End Sub

    Sub Botones()
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
    End Sub


    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0

            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0

            If cmb_Cliente.Enabled Then
                cmb_Cliente.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged, dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Resgistros: 0"
        Call Botones()
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Resgistros: 0"
        Call Botones()
    End Sub

    Private Sub chk_Cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cliente.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_Cliente.SelectedValue = 0
        cmb_Cliente.Enabled = Not chk_Cliente.Checked
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha Inicial no puede ser mayor que la Fecha Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If Not chk_Cliente.Checked And cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione el Cliente o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        lsv_Catalogo.Items.Clear()
        If Not fn_ClientesListaNegra_LlenarLista(cmb_Cliente.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, lsv_Catalogo) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Botones()
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class