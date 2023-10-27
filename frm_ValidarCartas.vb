Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_ValidarCartas

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Cartas.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Cartas.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Cartas, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub ValidarCartas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fn_ValidarCartas_LlenarCartas(lsv_Cartas)
        fn_ValidarCartas_LlenarDetalle(lsv_Detalle, -1)
        lbl_Registros.Text = "Registros: " & lsv_Cartas.Items.Count
        Lbl_Registros2.Text = "Registros: " & lsv_Detalle.Items.Count
        btn_Reimprimir.Enabled = lsv_Cartas.Items.Count > 0
    End Sub

    Private Sub lsv_Cartas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Cartas.SelectedIndexChanged
        If lsv_Cartas.SelectedItems.Count > 0 Then
            Select Case lsv_Cartas.SelectedItems(0).SubItems(2).Text
                Case "ACTIVA"
                    btn_Validar.Enabled = True
                    btn_Cancelar.Enabled = True
                Case "VALIDADA"
                    btn_Validar.Enabled = False
                    btn_Cancelar.Enabled = True
                Case "CANCELDADA"
                    btn_Validar.Enabled = False
                    btn_Cancelar.Enabled = False
                Case "APLICADA"
                    btn_Validar.Enabled = False
                    btn_Cancelar.Enabled = False
            End Select

            fn_ValidarCartas_LlenarDetalle(lsv_Detalle, lsv_Cartas.SelectedItems(0).Tag)
        Else
            btn_Validar.Enabled = False
            btn_Cancelar.Enabled = False
            lsv_Detalle.Items.Clear()
        End If
        Lbl_Registros2.Text = "Registros: " & lsv_Detalle.Items.Count
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()
        If frm.Firma Then
            If lsv_Cartas.SelectedItems.Count > 0 Then
                Dim Id(lsv_Cartas.SelectedItems.Count - 1) As Integer
                For I As Integer = 0 To lsv_Cartas.SelectedItems.Count - 1
                    Id(I) = lsv_Cartas.SelectedItems(I).Tag
                Next

                If fn_ValidarCartas_ValidarCartas(Id) Then
                    fn_ValidarCartas_LlenarCartas(lsv_Cartas)
                Else
                    MsgBox("Ha ocurrido un error al intentar Validar los registros.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()
        If frm.Firma Then
            If lsv_Cartas.SelectedItems.Count > 0 Then
                Dim Id(lsv_Cartas.SelectedItems.Count - 1) As Integer
                For I As Integer = 0 To lsv_Cartas.SelectedItems.Count - 1
                    Id(I) = lsv_Cartas.SelectedItems(I).Tag
                Next

                If fn_ValidarCartas_CancelarCartas(Id) Then
                    fn_ValidarCartas_LlenarCartas(lsv_Cartas)
                Else
                    MsgBox("Ha ocurrido un error al intentar Cancelar los registros.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                End If
            End If
        End If
        lbl_Registros.Text = "Registros: " & lsv_Cartas.Items.Count
    End Sub

    Private Sub btn_Reimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reimprimir.Click
        SegundosDesconexion = 0

        If lsv_Cartas.SelectedItems.Count > 0 Then
            Dim Ds As New ds_Reporte
            fn_ValidarCartas_ImprimirDetalle(Ds.tbl_CartaAumentoD, lsv_Cartas.SelectedItems(0).Tag)
            Dim frm As New frm_Reporte
            Dim Rpt As New rpt_CartaAumento

            '--------------pruebas de imagen en reportes {
            If Not IsDBNull(Ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = Ds.Tbl_DatosEmpresa.Rows(0)("logo")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                Dim Ancho As Integer = imagenNueva.Width
                Dim Alto As Integer = imagenNueva.Height
                Dim valordiv As Decimal = 0.0

                With Rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                    Dim Top_Obj As Integer = .Top
                    Dim Left_Obj As Integer = .Left '+- 342default
                    Dim Width_Obj As Integer = .Width '1440Default

                    If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                    Dim nuevoAncho As Integer = Ancho * valordiv
                    Dim NuevoAlto As Integer = Alto * valordiv

                    If Ancho > Alto Then
                        'horizontal
                        Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                        .Top = Top_Obj
                    Else
                        'vertical,cuadrado
                        Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                        .Left = Left_Obj
                    End If
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With

                '-------liberar objetos
                ms_ByteToImagen.Dispose()
                imagenNueva.Dispose()
            End If
            '--------------}
            Rpt.SetDataSource(Ds)

            Dim Array As Array = fn_ValidarCartas_Imprimir(lsv_Cartas.SelectedItems(0).Tag)
            Rpt.SetParameterValue("Cliente", Array(1))
            Rpt.SetParameterValue("Direccion del Cliente", Array(2) & Chr(13) & Array(3))
            Rpt.SetParameterValue("Fecha Actual", CDate(Array(4)).ToLongDateString)
            Rpt.SetParameterValue("Contacto", Array(8))
            Rpt.SetParameterValue("Empresa", Array(5))
            Rpt.SetParameterValue("Ejecutivo", Array(6))
            Rpt.SetParameterValue("Correo Ejecutivo", Array(7))

            frm.crv.ReportSource = Rpt

            FuncionesGlobales.MostrarVentana(frm)
        End If
    End Sub

    Private Sub lsv_Cartas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cartas.MouseHover, lsv_Detalle.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

End Class