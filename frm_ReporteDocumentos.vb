Public Class frm_ReporteDocumentos

    Private Sub frm_ReporteDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("ACTA CONSTITUTIVA")
        lsv_Catalogo.Columns.Add("CEDULA FISCAL")
        lsv_Catalogo.Columns.Add("PODER LEGAL")
        lsv_Catalogo.Columns.Add("IFE REPRESENTANTE LEGAL")
        lsv_Catalogo.Columns.Add("COMPROBANTE DE DOMICILIO ACTUALIZADO")
        lsv_Catalogo.Columns.Add("CURP REPRESENTANTE LEGAL")
        lsv_Catalogo.Columns.Add("SOLICITUD DE SERVICIO CORRECTAMENTE LLENADA")

        If Not Cn_Clientes.fn_Clientes_ReporteDocumentos(lsv_Catalogo) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    
    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        Cursor = Cursors.WaitCursor
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, "Reporte Documentos", 0, 0, frm_MENU.prg_Barra)
        Cursor = Cursors.Default
    End Sub
End Class