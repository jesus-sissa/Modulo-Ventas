Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes
Public Class frm_ConsultaCajasFuertesM

    Private Sub frm_ConsultaCajasFuertesM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_TipoMov.AgregarItem(1, "VENTA")
        cmb_TipoMov.AgregarItem(2, "RENTA")
        cmb_TipoMov.AgregarItem(3, "FIN DE RENTA")
        cmb_TipoMov.AgregarItem(4, "CAMBIO DE COMBINACION")
        cmb_TipoMov.AgregarItem(5, "MANTENIMIENTO O REPARACION")
        cmb_TipoMov.AgregarItem(6, "REUBICACION")
        cmb_TipoMov.AgregarItem(7, "CAMBIO DE MANEJO DE COMBINACION")
        cmb_TipoMov.AgregarItem(9, "MANTENIMIENTO INTERNO")

        lsv_Catalogo.Columns.Add("FechaMovimiento")
        lsv_Catalogo.Columns.Add("FechaRegistro")
        lsv_Catalogo.Columns.Add("ClaveCaja")
        lsv_Catalogo.Columns.Add("Empleado")
        lsv_Catalogo.Columns.Add("Movimiento")
        lsv_Catalogo.Columns.Add("Cliente")
        lsv_Catalogo.Columns.Add("CombinacionCliente")
        lsv_Catalogo.Columns.Add("Observaciones")
        lsv_Catalogo.Columns.Add("Status")

        cmb_CajaFuerte.Actualizar()
        cmb_Cliente.Actualizar()

        dtp_desde.Value = Date.Now
        dtp_Hasta.Value = Date.Now
    End Sub

    Sub LlenarLista()
        lsv_Catalogo.Items.Clear()
        If Not fn_ConsultaCajasFuertesM_LlenarLista(lsv_Catalogo, cmb_CajaFuerte.SelectedValue, cmb_Cliente.SelectedValue, dtp_desde.Value.Date, dtp_Hasta.Value.Date, cmb_TipoMov.SelectedValue) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Sub Botones()
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        BTN_Modificar.Enabled = False
        Btn_CancerlarMov.Enabled = False
        btn_Recibo.Enabled = False
        btn_Importar.Enabled = False
        btn_CombinacionCliente.Enabled = False
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Btn_CancerlarMov.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(10).Text = "ACTIVO"
            'Un movimiento validado tambien se puede modificar ya que los precios cambian al pasar el tiempo
            BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(10).Text <> "CANCELADO" 'AndAlso lsv_Catalogo.SelectedItems(0).SubItems(10).Text <> "VALIDADO"
            btn_Recibo.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(10).Text <> "CANCELADO"
            btn_CombinacionCliente.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(10).Text <> "CANCELADO"
            btn_Importar.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(10).Text = "VALIDADO"
        End If
    End Sub

#Region "Botones"

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.ClickButton
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1

        fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If Not chk_CajaFuerte.Checked AndAlso cmb_CajaFuerte.SelectedValue = 0 Then
            MsgBox("Seleccione un Tipo de Caja Fuerte o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaFuerte.Focus()
            Exit Sub
        End If

        If Not chk_Cliente.Checked AndAlso cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        If dtp_desde.Value > dtp_Hasta.Value Then
            MsgBox("Fecha Inicial debe ser menor que la Fecha Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_desde.Focus()
            Exit Sub
        End If

        If Not chk_TipoMov.Checked AndAlso cmb_TipoMov.SelectedValue = 0 Then
            MsgBox("Seleccione un Tipo de Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoMov.Focus()
            Exit Sub
        End If

        Call LlenarLista()
    End Sub

    Private Sub Btn_CancerlarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CancerlarMov.Click
        SegundosDesconexion = 0

        If Not fn_CajasFuertesMov_Baja(lsv_Catalogo.SelectedItems(0).Tag, lsv_Catalogo.SelectedItems(0).SubItems(6).Text, lsv_Catalogo.SelectedItems(0).SubItems(11).Text) Then
            MsgBox("Ocurrió un error al tatar dar de Baja el Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Volver a llenar la lista
        Call LlenarLista()
        Call Botones()
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        Dim frm As New frm_CajasFuertesMov
        Dim dr As DataRow = fn_CajasFuertes_Read(lsv_Catalogo.SelectedItems(0).SubItems(11).Text)
        frm.Id_CajaFuerteMov = lsv_Catalogo.SelectedItems(0).Tag
        frm.Id_CajaFuerte = lsv_Catalogo.SelectedItems(0).SubItems(11).Text
        frm.CombinacionActual = Split(dr("Combinacion"), " ")
        'Para el nombre
        frm.CajaClave = dr("Clave_CajaFuerte")
        frm.CajaMarca = dr("Marca")
        frm.CajaSerie = dr("Serie")
        Select Case lsv_Catalogo.SelectedItems(0).SubItems(10).Text
            Case "ACTIVO"
                Cn_Login.fn_Log_Create("MODIFICAR INFORMACIÓN EN LOS MOVIMIENTOS DE CAJAS FUERTES")
                If lsv_Catalogo.SelectedItems(0).SubItems(6).Text = "MANTENIMIENTO INTERNO" Then
                    frm.StatusMov = "M"
                End If
            Case "VALIDADO"
                frm.btn_Guardar.Enabled = True
            Case Else
                frm.btn_Guardar.Enabled = False
                frm.btn_GuardarImprimir.Enabled = False
        End Select
        frm.ShowDialog()
        'Actualizar la lista.
        Call LlenarLista()
        Call Botones()
    End Sub

    Private Sub btn_Importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importar.Click
        SegundosDesconexion = 0

        Dim frm_CA As New frm_CargarArchivos
        frm_CA.Filtro = "Imagenes (*.jpg)|*.jpg"
        frm_CA.MaxArchivos = 5
        frm_CA.Id_Tabla = lsv_Catalogo.SelectedItems(0).Tag
        frm_CA.Tipo = frm_CargarArchivos.Query.CajasFuertesValidar
        frm_CA.ShowDialog()
    End Sub

    Private Sub btn_Recibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibo.Click
        SegundosDesconexion = 0

        Dim TipoMov As String = lsv_Catalogo.SelectedItems(0).SubItems(6).Text

        Dim frm As New frm_Reporte
        Dim rpt
        If TipoMov = "RENTA" Then

            rpt = New rpt_ReciboMovCaja2
        Else
            rpt = New rpt_ReciboMovCaja3
        End If

        Dim Ds As New ds_Reporte

        frm.crv.ReportSource = rpt

        If Not fn_Imprimir_LlenarReciboMovimiento(Ds.Tbl_CajasFuertesMov, lsv_Catalogo.SelectedItems(0).Tag) Then
            MsgBox("Error al intentar generar el Recibo del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not fn_Reportes_Encabezado(Ds.Tbl_DatosEmpresa) Then
            MsgBox("Error al intentar generar el Recibo del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
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

            Dim Top_Obj As Integer = 0
            Dim Left_Obj As Integer = 0 '+- 342default
            Dim Width_Obj As Integer = 0 '1440Default
            Dim nuevoAncho As Integer = 0
            Dim NuevoAlto As Integer = 0
            '----subreporte1
            With rpt.SubReports(0).ReportDefinition.Sections("Section1").ReportObjects("Logo")

                Top_Obj = .Top
                Left_Obj = .Left '+- 342default
                Width_Obj = .Width '1440Default

                If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                nuevoAncho = Ancho * valordiv
                NuevoAlto = Alto * valordiv

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

            '-----para el subreporte 2----------

            With rpt.SubReports(1).ReportDefinition.Sections("Section1").ReportObjects("Logo")
                If Ancho > Alto Then .Top = Top_Obj Else .Left = Left_Obj
                .Width = nuevoAncho
                .Height = NuevoAlto
            End With

            '---para el tercer subreporte ----

            If TipoMov <> "RENTA" Then
                With rpt.SubReports(2).ReportDefinition.Sections("Section1").ReportObjects("Logo")
                    If Ancho > Alto Then .Top = Top_Obj Else .Left = Left_Obj
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With
            End If
            '-------liberar objetos
            ms_ByteToImagen.Dispose()
            imagenNueva.Dispose()
        End If
        '--------------}
        'se maneja media items subreportes
        rpt.Subreports.Item(0).SetDataSource(Ds)
        rpt.Subreports.Item(1).SetDataSource(Ds)
        If TipoMov <> "RENTA" Then rpt.Subreports.Item(2).SetDataSource(Ds)

        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()
    End Sub

    Private Sub btn_CombinacionCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CombinacionCliente.Click
        SegundosDesconexion = 0

        Dim TipoMov As String = lsv_Catalogo.SelectedItems(0).SubItems(6).Text
        Dim CombinacionCliente As String = lsv_Catalogo.SelectedItems(0).SubItems(8).Text

        If CombinacionCliente = "SI" And (TipoMov = "VENTA" Or TipoMov = "CAMBIO DE COMBINACION" Or TipoMov = "RENTA" Or TipoMov = "CAMBIO DE MANEJO DE COMBINACION") Then
            'Carta Combinación
            Dim dr_CajaFuerte As DataRow = fn_CajasFuertes_Read(lsv_Catalogo.SelectedItems(0).SubItems(11).Text)
            Dim frm As New frm_Reporte
            Dim rpt As New rpt_ReciboCombinacion
            Dim Ds As New ds_Reporte

            frm.crv.ReportSource = rpt
            If Not fn_Imprimir_LlenarCartaCombinacion(Ds.Tbl_ReciboCombinacion, lsv_Catalogo.SelectedItems(0).Tag) Then
                MsgBox("Error al intentar generar la Carta de la Combinación.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If Not fn_Reportes_Encabezado(Ds.Tbl_DatosEmpresa) Then
                MsgBox("Error al intentar generar la Carta de la Combinación.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim txt_Combinacion1 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section3.ReportObjects("txt_Combinacion1")
            Dim txt_Combinacion2 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section3.ReportObjects("txt_Combinacion2")
            Dim txt_Combinacion3 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section3.ReportObjects("txt_Combinacion3")

            Try
                Dim CombinacionArr() As String
                CombinacionArr = Split(dr_CajaFuerte("Combinacion"), " ")

                txt_Combinacion1.Text = CombinacionArr(0)
                txt_Combinacion2.Text = CombinacionArr(1)
                txt_Combinacion3.Text = CombinacionArr(2)

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
                frm.ShowDialog()
            Catch
            End Try
        Else
            MsgBox("No se puede generar la Carta de la Combinación a este Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 2, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

#End Region

#Region "ComboBox, CheckBox y DateTimePicker"

    Private Sub cmb_CajaFuerte_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaFuerte.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub cmb_CajaFuerte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_CajaFuerte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Cliente.Enabled Then
                cmb_Cliente.Focus()
            Else
                dtp_desde.Focus()
            End If
        End If
    End Sub

    Private Sub chk_CajaFuerte_CheckedChanged(ByVal sender As CheckBox, ByVal e As System.EventArgs) Handles chk_CajaFuerte.CheckedChanged
        SegundosDesconexion = 0

        cmb_CajaFuerte.SelectedValue = 0
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        lbl_CajaFuerte.Enabled = Not chk_CajaFuerte.Checked
        tbx_CajaFuerte.Enabled = Not chk_CajaFuerte.Checked
        cmb_CajaFuerte.Enabled = Not chk_CajaFuerte.Checked
        Call Botones()
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub cmb_Cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_desde.Focus()
        End If
    End Sub

    Private Sub chk_Cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cliente.CheckedChanged
        SegundosDesconexion = 0

        cmb_Cliente.SelectedValue = 0
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        lbl_Cliente.Enabled = Not chk_Cliente.Checked
        tbx_Cliente.Enabled = Not chk_Cliente.Checked
        cmb_Cliente.Enabled = Not chk_Cliente.Checked
        Call Botones()
    End Sub

    Private Sub dtp_desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_TipoMov.Enabled Then
                cmb_TipoMov.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_TipoMov_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoMov.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub cmb_TipoMov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_TipoMov.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Mostrar.Focus()
        End If
    End Sub

    Private Sub chk_TipoMov_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TipoMov.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        cmb_TipoMov.SelectedValue = 0
        cmb_TipoMov.Enabled = chk_TipoMov.Checked = False
        lbl_TipoMov.Enabled = chk_TipoMov.Checked = False
        Call Botones()
    End Sub

#End Region

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

End Class