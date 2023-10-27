Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_GenerarCarta

    Private Sub frm_GenerarCarta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_Contacto.AgregaParametro("@Id_Cliente", -1, 1)
        cmb_Contacto.Actualizar()
        cmb_Cliente.Actualizar()
        fn_GeneraCarta_LlenarDs(Ds_Clientes.Tbl_CartaAumentoD, cmb_Cliente.SelectedValue)

        cmb_TipoPrecio.AgregarItem("P", "Porcentaje")
        cmb_TipoPrecio.AgregarItem("I", "Importe")

        cmb_TipoCR.AgregarItem("P", "Porcentaje")
        cmb_TipoCR.AgregarItem("I", "Importe")

        cmb_TipoEE.AgregarItem("P", "Porcentaje")
        cmb_TipoEE.AgregarItem("I", "Importe")

        cmb_TipoKM.AgregarItem("P", "Porcentaje")
        cmb_TipoKM.AgregarItem("I", "Importe")

        cmb_Ejecutivo.Actualizar()

    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Frm_BuscarCliente.ShowDialog()
        tbx_Cliente.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        cmb_Cliente.SelectedValue = "0"
    End Sub

    Private Sub Btn_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Generar.Click, Me.F2
        SegundosDesconexion = 0

        'If cmb_Ejecutivo.SelectedValue = "0" Or cmb_Firma.SelectedValue = "0" Then
        '    MsgBox("Debe Seleccionar un Ejecutivo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        'Else
        '    Dim Id_Carta As Integer = fn_GenerarCarta_Guardar(Ds_Clientes.Tbl_CartaAumentoD, cmb_Cliente.SelectedValue, dtp_Fecha.Value, cmb_Ejecutivo.SelectedValue, cmb_Firma.SelectedValue)
        '    If Id_Carta > 0 Then
        '        Dim Ds As New ds_Reporte
        '        fn_ValidarCartas_ImprimirDetalle(Ds.tbl_CartaAumentoD, Id_Carta)
        '        Dim frm As New frm_Reporte
        '        Dim Rpt As New rpt_CartaAumento
        '        Rpt.SetDataSource(Ds)

        '        Dim Array As Array = fn_ValidarCartas_Imprimir(Id_Carta)
        '        Rpt.SetParameterValue("Cliente", Array(1))
        '        Rpt.SetParameterValue("Direccion del Cliente", Array(2) & Chr(13) & Array(3))
        '        Rpt.SetParameterValue("Fecha Actual", CDate(Array(4)).ToLongDateString)
        '        Rpt.SetParameterValue("Contacto", Array(8))
        '        Rpt.SetParameterValue("Empresa", Array(5))
        '        Rpt.SetParameterValue("Ejecutivo", Array(6))
        '        Rpt.SetParameterValue("Correo Ejecutivo", Array(7))

        '        frm.crv.ReportSource = Rpt

        '        FuncionesGlobales.MostrarVentana(frm)
        '    Else
        '        MsgBox("Ha ocurrido un error al generar la carta", MsgBoxStyle.Critical, frm_MENU.Text)
        '    End If
        'End If
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        If cmb_Cliente.Items.Count = 0 Then Exit Sub
        fn_GeneraCarta_LlenarDs(Ds_Clientes.Tbl_CartaAumentoD, cmb_Cliente.SelectedValue)

        cmb_Contacto.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        cmb_Contacto.Actualizar()
    End Sub

    Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_TipoPrecio.LostFocus, cmb_TipoCR.LostFocus, cmb_TipoEE.LostFocus, cmb_TipoKM.LostFocus
        TblCartaAumentoDBindingSource.EndEdit()
    End Sub

    Private Sub combo_SelectedValueChanged(ByVal sender As cp_cmb_Manual, ByVal e As System.EventArgs) Handles cmb_TipoPrecio.SelectedValueChanged, cmb_TipoCR.SelectedValueChanged, cmb_TipoEE.SelectedValueChanged, cmb_TipoKM.SelectedValueChanged
        If sender.Focused Then
            If tbx_CantPrecio.Text = "" Then tbx_CantPrecio.Text = 0
            If tbx_CantCR.Text = "" Then tbx_CantCR.Text = 0
            If tbx_CantEE.Text = "" Then tbx_CantEE.Text = 0
            If tbx_CantKM.Text = "" Then tbx_CantKM.Text = 0

            If sender Is cmb_TipoPrecio Then
                Select Case sender.SelectedValue
                    Case "0"
                        tbx_CantPrecio.Enabled = False
                    Case "P"
                        tbx_CantPrecio.Enabled = True
                        tbx_CantPrecio.TipoDatos = FuncionesGlobales.Validar_Cadena.Porcentaje
                        lbl_PrecioNvo.Text = CDec(lbl_PrecioAct.Text) + (CDec(lbl_PrecioAct.Text) * (CDec(tbx_CantPrecio.Text) / 100))
                    Case "I"
                        tbx_CantPrecio.Enabled = True
                        tbx_CantPrecio.TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Decimales
                        lbl_PrecioNvo.Text = CDec(lbl_PrecioAct.Text) + (CDec(tbx_CantPrecio.Text))
                End Select
            ElseIf sender Is cmb_TipoCR Then
                Select Case sender.SelectedValue
                    Case "0"
                        tbx_CantCR.Enabled = False
                    Case "P"
                        tbx_CantCR.Enabled = True
                        tbx_CantCR.TipoDatos = FuncionesGlobales.Validar_Cadena.Porcentaje
                        lbl_CRNvo.Text = CDec(lbl_CRAct.Text) + (CDec(lbl_CRAct.Text) * (CDec(Val(tbx_CantCR.Text)) / 100))
                    Case "I"
                        tbx_CantCR.Enabled = True
                        tbx_CantCR.TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Decimales
                        lbl_CRNvo.Text = CDec(lbl_CRAct.Text) + (CDec(tbx_CantCR.Text))
                End Select
            ElseIf sender Is cmb_TipoEE Then
                Select Case sender.SelectedValue
                    Case "0"
                        tbx_CantEE.Enabled = False
                    Case "P"
                        tbx_CantEE.Enabled = True
                        tbx_CantEE.TipoDatos = FuncionesGlobales.Validar_Cadena.Porcentaje
                        lbl_EENvo.Text = CDec(lbl_EEAct.Text) + (CDec(lbl_EEAct.Text) * (CDec(Val(tbx_CantEE.Text)) / 100))
                    Case "I"
                        tbx_CantEE.Enabled = True
                        tbx_CantEE.TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Decimales
                        lbl_EENvo.Text = CDec(lbl_EEAct.Text) + (CDec(tbx_CantEE.Text))
                End Select
            Else
                Select Case sender.SelectedValue
                    Case "0"
                        tbx_CantKM.Enabled = False
                    Case "P"
                        tbx_CantKM.Enabled = True
                        tbx_CantKM.TipoDatos = FuncionesGlobales.Validar_Cadena.Porcentaje
                        lbl_KMNvo.Text = CDec(lbl_KMAct.Text) + (CDec(lbl_KMAct.Text) * (CDec(Val(tbx_CantKM.Text)) / 100))
                    Case "I"
                        tbx_CantKM.Enabled = True
                        tbx_CantKM.TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Decimales
                        lbl_KMNvo.Text = CDec(lbl_KMAct.Text) + (CDec(tbx_CantKM.Text))
                End Select
            End If
        End If
    End Sub

    Private Sub Textbox_LostFocus(ByVal sender As cp_Textbox, ByVal e As System.EventArgs) Handles tbx_CantPrecio.LostFocus, tbx_CantCR.LostFocus, tbx_CantEE.LostFocus, tbx_CantKM.LostFocus
        If sender.Text = "" Then sender.Text = 0
        If sender Is tbx_CantPrecio Then
            Select Case cmb_TipoPrecio.SelectedValue
                Case "P"
                    lbl_PrecioNvo.Text = CDec(lbl_PrecioAct.Text) + (CDec(lbl_PrecioAct.Text) * (CDec(tbx_CantPrecio.Text) / 100))
                Case "I"
                    lbl_PrecioNvo.Text = CDec(lbl_PrecioAct.Text) + (CDec(tbx_CantPrecio.Text))
            End Select
        ElseIf sender Is tbx_CantCR Then
            Select Case cmb_TipoCR.SelectedValue
                Case "P"
                    lbl_CRNvo.Text = CDec(lbl_CRAct.Text) + (CDec(lbl_CRAct.Text) * (CDec(tbx_CantCR.Text) / 100))
                Case "I"
                    lbl_CRNvo.Text = CDec(lbl_CRAct.Text) + (CDec(tbx_CantCR.Text))
            End Select
        ElseIf sender Is tbx_CantEE Then
            Select Case cmb_TipoEE.SelectedValue
                Case "P"
                    lbl_EENvo.Text = CDec(lbl_EEAct.Text) + (CDec(lbl_EEAct.Text) * (CDec(tbx_CantEE.Text) / 100))
                Case "I"
                    lbl_EENvo.Text = CDec(lbl_EEAct.Text) + (CDec(tbx_CantEE.Text))
            End Select
        Else
            Select Case cmb_TipoKM.SelectedValue
                Case "P"
                    lbl_KMNvo.Text = CDec(lbl_KMAct.Text) + (CDec(lbl_KMAct.Text) * (CDec(tbx_CantKM.Text) / 100))
                Case "I"
                    lbl_KMNvo.Text = CDec(lbl_KMAct.Text) + (CDec(tbx_CantKM.Text))
            End Select
        End If
        TblCartaAumentoDBindingSource.EndEdit()
    End Sub

    Private Sub dgv_Servicios_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Servicios.SelectionChanged
        If dgv_Servicios.ColumnCount > 0 Then
            'PrecioDataGridViewTextBoxColumn'este estaba como columna 14/05/2014
            cmb_TipoPrecio.Enabled = dgv_Servicios.SelectedRows.Count > 0 AndAlso dgv_Servicios.SelectedRows(0).Cells("PrecioAnteriorDataGridViewTextBoxColumn").Value IsNot Nothing
            cmb_TipoCR.Enabled = dgv_Servicios.SelectedRows.Count > 0 AndAlso dgv_Servicios.SelectedRows(0).Cells("PrecioAnteriorCRDataGridViewTextBoxColumn").Value IsNot Nothing
            cmb_TipoEE.Enabled = dgv_Servicios.SelectedRows.Count > 0 AndAlso dgv_Servicios.SelectedRows(0).Cells("PrecioAnteriorEEDataGridViewTextBoxColumn").Value IsNot Nothing
            cmb_TipoKM.Enabled = dgv_Servicios.SelectedRows.Count > 0 AndAlso dgv_Servicios.SelectedRows(0).Cells("PrecioAnteriorKMDataGridViewTextBoxColumn").Value IsNot Nothing
        End If
    End Sub

    Private Sub dgv_Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_Servicios.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub gbx_Cliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Cliente.MouseHover, Gbx_Controles.MouseHover, gbx_Precios.MouseHover, gbx_Servicios.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

End Class