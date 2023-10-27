Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_BajaCajaFuerte
    Public Id_CajaFuerte As Integer = 0
    Public Id_CajaFuerteT As Integer = 0
    Dim Id_CajaFuerteB As Integer = 0
    Public Imprimir As Boolean = True

    Private Sub frm_BajaCajaFuerte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Baja.AgregaParametro("@Tipo", "6", 1)
        cmb_Baja.Actualizar()
        dtp_Baja.Value = Now.Date
    End Sub

#Region "Botones"

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If cmb_Baja.SelectedValue = 0 Then
            MsgBox("Seleccione el Motivo de la Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Baja.Focus()
            Exit Sub
        End If

        If dtp_Baja.Value.Date > Now.Date Then
            MsgBox("La Fecha no puede ser mayor a la actual.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Baja.Focus()
            Exit Sub
        End If

        If rtb_Observaciones.TextLength < 10 Then
            MsgBox("Indique Observaciones mas detalladas.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Observaciones.Focus()
            Exit Sub
        End If

        'Si se esta Insertando
        If Cn_Clientes.fn_CajasFuertesBaja_Baja(Id_CajaFuerte, cmb_Baja.SelectedValue, dtp_Baja.Value, rtb_Observaciones.Text, Id_CajaFuerteT, Id_CajaFuerteB) Then
            cmb_Baja.SelectedValue = 0
            dtp_Baja.Value = Today.Date
            rtb_Observaciones.Clear()

            If Imprimir Then
                Dim frm As New frm_Reporte
                Dim rpt As New rpt_ActaBajaCajaFuerte
                Dim Ds As New ds_Reporte

                'Reporte de Baja de Cajas Fuertes
                frm.crv.ReportSource = rpt
                If Not fn_Imprimir_LlenarReciboBajaCajaFuerte(Ds.Tbl_CajasFuertesBajas, Id_CajaFuerteB) Then
                    MsgBox("Error al intentar generar el Recibo de Baja de Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                '--------------pruebas de imagen en reportes {
                If Not IsDBNull(Ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

                    Dim imagenNueva As Image = Nothing
                    Dim imagenBytes As Byte() = Ds.Tbl_DatosEmpresa.Rows(0)("logo")
                    Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                    imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                    Dim Ancho As Integer = imagenNueva.Width
                    Dim Alto As Integer = imagenNueva.Height
                    Dim valordiv As Decimal = 0.0

                    With rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

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
                rpt.SetDataSource(Ds)

                frm.WindowState = FormWindowState.Maximized
                FuncionesGlobales.MostrarVentana(frm, False)
            End If

            Me.Close()

        Else
            'En caso de que no se haya hecho la transaccion
            MsgBox("No se pudo realizar la Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        cmb_Baja.SelectedValue = 0
        dtp_Baja.Value = Now.Date
        rtb_Observaciones.Clear()
        Me.Close()
    End Sub

#End Region

    Private Sub gbx_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Datos.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub dtp_Baja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Baja.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            rtb_Observaciones.Focus()
        End If
    End Sub
End Class
