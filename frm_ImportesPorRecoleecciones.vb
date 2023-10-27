Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales
Public Class frm_ImportesPorRecoleecciones

    Private Sub BTN_Exportar_Click(sender As Object, e As EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        fn_Exportar_Excel(lsv_Catalogo, 0, frm_MENU.Text, 0, 0, frm_MENU.prg_Barra)

        Cn_Login.fn_Log_Create("EXPORTAR REPORTE DE IMPORTES POR RECOLECCION. CLIENTE: --" + " / FECHAS: " & dtp_desde.Value.ToShortDateString & " - " & dtp_Hasta.Value.ToShortDateString)
    End Sub

    Private Sub btn_Consultar_Click_1(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        fn_ImportesporRecolecciones_llenarlista(lsv_Catalogo, dtp_desde.Value, dtp_Hasta.Value)
        FuncionesGlobales.fn_NumRegistros(lbl_Registros, lsv_Catalogo.Items.Count)
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
    End Sub
End Class