Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_CajasFuertesMovValidar

    Dim CombinacionActual() As String

    Private Sub frm_CajasFuertesMovValidar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        Call OcultarCombinaciones()
        rtb_ObservacionesValidar.Clear()
        dtp_FechaReal.Value = Today.Date
        dtp_HoraReal.Value = Now.ToLongDateString
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Validar.Enabled = False
        If Not fn_CajasFuertesValidar_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Sub OcultarCombinaciones()
        CombinacionActual = Nothing

        lbl_CombActual.Visible = False
        tbx_CombActual0.Clear()
        tbx_CombActual1.Clear()
        tbx_CombActual2.Clear()
        tbx_CombActual0.Visible = False
        tbx_CombActual1.Visible = False
        tbx_CombActual2.Visible = False

        lbl_CombNueva.Visible = False
        tbx_CombNueva0.Clear()
        tbx_CombNueva1.Clear()
        tbx_CombNueva2.Clear()
        tbx_CombNueva0.Visible = False
        tbx_CombNueva1.Visible = False
        tbx_CombNueva2.Visible = False
        lbl_ACombinacion.Visible = False
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Validar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        'Cuando sea un Movimiento de Cambio de Combinación o Cambio de Manejo de Combinación
        Call OcultarCombinaciones()

        If lsv_Catalogo.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        Dim TipoMov As String = lsv_Catalogo.SelectedItems(0).SubItems(2).Text
        Dim Resultado As Boolean = (TipoMov = "CAMBIO DE COMBINACION" OrElse TipoMov = "CAMBIO DE MANEJO DE COMBINACION")

        If Resultado Then
            CombinacionActual = Split(lsv_Catalogo.SelectedItems(0).SubItems(12).Text, " ")
            tbx_CombActual0.Text = CombinacionActual(0)
            tbx_CombActual1.Text = CombinacionActual(1)
            tbx_CombActual2.Text = CombinacionActual(2)
        Else
            CombinacionActual = Nothing
        End If

        lbl_CombActual.Visible = Resultado
        tbx_CombActual0.Visible = Resultado
        tbx_CombActual1.Visible = Resultado
        tbx_CombActual2.Visible = Resultado

        lbl_CombNueva.Visible = Resultado
        tbx_CombNueva0.Visible = Resultado
        tbx_CombNueva1.Visible = Resultado
        tbx_CombNueva2.Visible = Resultado
        lbl_ACombinacion.Visible = Resultado

        btn_Validar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub rtb_ObservacionesValidar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_ObservacionesValidar.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0
        'validar si es de Rentado a Venta
        Dim TipoMov As String = lsv_Catalogo.SelectedItems(0).SubItems(2).Text
        Dim Resultado As Boolean = (TipoMov = "CAMBIO DE COMBINACION" OrElse TipoMov = "CAMBIO DE MANEJO DE COMBINACION")

        If Resultado AndAlso (tbx_CombNueva0.Text = Nothing And tbx_CombNueva1.Text = Nothing And tbx_CombNueva2.Text = Nothing) Then
            MsgBox("Agregue la Nueva Combinación.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CombNueva0.Focus()
            Exit Sub
        End If
        Dim CombinacionNueva As String = tbx_CombNueva0.Text & " " & tbx_CombNueva1.Text & " " & tbx_CombNueva2.Text

        Dim FRM As New frm_FirmaElectronica
        FRM.Bloquear = True
        FRM.PedirObservaciones = False
        FRM.ShowDialog()
        If FRM.Firma = True Then
            If MsgBox("Desea Agregar Archivos al Movimiento que se esta Validando?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                Dim frm_CA As New frm_CargarArchivos
                frm_CA.Filtro = "Imagenes (*.jpg)|*.jpg"
                frm_CA.MaxArchivos = 5
                frm_CA.Id_Tabla = lsv_Catalogo.SelectedItems(0).Tag
                frm_CA.Tipo = frm_CargarArchivos.Query.CajasFuertesValidar
                frm_CA.ShowDialog()
            End If

            If Not fn_CajasFuertesValidar_Status(lsv_Catalogo.SelectedItems(0).Tag, rtb_ObservacionesValidar.Text, CombinacionNueva, dtp_FechaReal.Value.Date, dtp_HoraReal.Value.TimeOfDay.ToString) Then
                MsgBox("No se pudo realizar la Validación.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            MsgBox("Se Valido el Movimiento de forma correcta.", MsgBoxStyle.Information, frm_MENU.Text)

            If TipoMov = "VENTA" OrElse TipoMov = "RENTA" OrElse TipoMov = "CAMBIO DE COMBINACION" OrElse TipoMov = "CAMBIO DE MANEJO DE COMBINACION" Then
                Dim frm_R As New frm_Reporte
                Dim rpt As New rpt_ReciboCombinacion
                Dim Ds As New ds_Reporte

                If lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "SI" Then
                    'Solo se debe imprimir la carta de Combinacion cuando el cliente maneja la combinacion
                    frm_R.crv.ReportSource = rpt
                    If Not fn_Imprimir_LlenarCartaCombinacion(Ds.Tbl_ReciboCombinacion, lsv_Catalogo.SelectedItems(0).Tag) Then
                        MsgBox("Error al intentar generar el Recibo del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    Dim txt_Combinacion1 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section3.ReportObjects("txt_Combinacion1")
                    Dim txt_Combinacion2 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section3.ReportObjects("txt_Combinacion2")
                    Dim txt_Combinacion3 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section3.ReportObjects("txt_Combinacion3")

                    Try
                        txt_Combinacion1.Text = tbx_CombNueva0.Text
                        txt_Combinacion2.Text = tbx_CombNueva1.Text
                        txt_Combinacion3.Text = tbx_CombNueva2.Text

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
                        frm_R.WindowState = FormWindowState.Maximized
                        frm_R.ShowDialog()
                    Catch
                    End Try
                End If
            End If
            Call LlenarLista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub dtp_FechaReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaReal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_HoraReal.Focus()
    End Sub

    Private Sub dtp_HoraReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_HoraReal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If tbx_CombNueva0.Visible Then
                tbx_CombNueva0.Focus()
            Else
                btn_Validar.Focus()
            End If
        End If
    End Sub

End Class