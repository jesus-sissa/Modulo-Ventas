
Public Class frm_Cotizaciones

    Dim Total As Decimal

    Private Sub frm_Cotizaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_Cotizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Precio.AgregaParametro("@Id_Linea", 0, 1)
        cmb_Precio.AgregaParametro("@Status", "A", 0)
        cmb_Precio.Actualizar()

        cmb_PrecioDescripcion.AgregaParametro("@Id_Linea", 0, 1)
        cmb_PrecioDescripcion.AgregaParametro("@Status", "A", 0)
        cmb_PrecioDescripcion.Actualizar()

        cmb_LineaServicio.Actualizar()
        cmb_CuotaRiesgo.Actualizar()
        cmb_Kilometraje.Actualizar()


        lsv_ServiciosSolicitados.Columns.Add("Linea")
        lsv_ServiciosSolicitados.Columns.Add("Descripcion")
        lsv_ServiciosSolicitados.Columns.Add("Cantidad")
        lsv_ServiciosSolicitados.Columns.Add("MontoAprox")
        lsv_ServiciosSolicitados.Columns.Add("Proceso")
        lsv_ServiciosSolicitados.Columns.Add("Morralla")
        lsv_ServiciosSolicitados.Columns.Add("MismoDia")
        lsv_ServiciosSolicitados.Columns.Add("FechaInicio")

        lsv_ServiciosSolicitados.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_ServiciosSolicitados.Columns(3).TextAlign = HorizontalAlignment.Right

        lsv_ServiciosCotizar.Columns.Add("Clave")
        lsv_ServiciosCotizar.Columns.Add("Descripcion")
        lsv_ServiciosCotizar.Columns.Add("Observaciones")
        lsv_ServiciosCotizar.Columns.Add("Cantidad")
        lsv_ServiciosCotizar.Columns.Add("Precio")
        lsv_ServiciosCotizar.Columns.Add("Subtotal")

        lsv_ServiciosCotizar.Columns(3).TextAlign = HorizontalAlignment.Right
        lsv_ServiciosCotizar.Columns(4).TextAlign = HorizontalAlignment.Right
        lsv_ServiciosCotizar.Columns(5).TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        'SegundosDesconexion = 0

        ''Validar los datos capturados
        'If cmb_LineaServicio.SelectedValue = 0 Then
        '    MsgBox("Seleccione la Línea de Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    cmb_LineaServicio.Focus()
        '    Exit Sub
        'End If

        'If cmb_Precio.SelectedValue = 0 Then
        '    MsgBox("Seleccione el Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    cmb_PrecioDescripcion.Focus()
        '    Exit Sub
        'End If

        ''Agregar datos al Listview
        'Dim arr As Array = Split(cmb_PrecioDescripcion.Text, "     ")
        'Dim s As String = arr(1)

        'lsv_ServiciosCotizar.Items.Add(tbx_CvePrecio.Text)
        'lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(arr(1))
        'lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_DescripcionPrecio.Text)
        'lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_CantidadPrecio.Text)
        'lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_Precio.Text)
        'lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(FormatNumber((tbx_CantidadPrecio.Text) * CDec(cmb_Precio.Text), 2))
        'lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(dtp_FechaInicio.Value)
        'Total = Total + (CDec(tbx_CantidadPrecio.Text) * CDec(cmb_Precio.Text))
        'lbl_CantidadTotal.Text = FormatCurrency(Total, 2)

        'If cmb_PreciosCuotaRiesgo.SelectedValue > 0 Then
        '    arr = Split(cmb_CuotaRiesgo.Text, "     ")
        '    lsv_ServiciosCotizar.Items.Add(tbx_CveCuotaRiesgo.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(arr(1))
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_DescripcionCR.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_CantidadCuotaRiesgo.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_PreciosCuotaRiesgo.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(FormatNumber(CDec(tbx_CantidadCuotaRiesgo.Text) * CDec(cmb_PreciosCuotaRiesgo.Text), 2))
        '    Total = Total + (CDec(tbx_CantidadCuotaRiesgo.Text) * CDec(cmb_PreciosCuotaRiesgo.Text))
        '    lbl_CantidadTotal.Text = FormatCurrency(Total, 2)
        'End If
        'If cmb_PreciosEnvases.SelectedValue > 0 Then
        '    arr = Split(cmb_EnvasesExceso.Text, "     ")
        '    lsv_ServiciosCotizar.Items.Add(tbx_CveEnvases.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(arr(1))
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_DescripcionEE.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_CantidadEnvases.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_PreciosEnvases.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(FormatNumber(CDec(tbx_CantidadEnvases.Text) * CDec(cmb_PreciosEnvases.Text), 2))
        '    Total = Total + (CDec(tbx_CantidadEnvases.Text) * CDec(cmb_PreciosEnvases.Text))
        '    lbl_CantidadTotal.Text = FormatCurrency(Total, 2)
        'End If
        'If cmb_PreciosKilometraje.SelectedValue > 0 Then
        '    arr = Split(cmb_Kilometraje.Text, "     ")
        '    lsv_ServiciosCotizar.Items.Add(tbx_CveKilometraje.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(arr(1))
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_DescripcionKM.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_CantidadKilometraje.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_PreciosKilometraje.Text)
        '    lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(FormatNumber(CDec(tbx_CantidadKilometraje.Text) * CDec(cmb_PreciosKilometraje.Text), 2))
        '    Total = Total + (CDec(tbx_CantidadKilometraje.Text) * CDec(cmb_PreciosKilometraje.Text))
        '    lbl_CantidadTotal.Text = FormatCurrency(Total, 2)
        'End If

        ''Limpiar datos capturados
        ''LimpiarServicios()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Reporte

        'Validar que se hayan agregado servicios en el Listview

        If lsv_ServiciosCotizar.Items.Count > 0 Then
            'Guardar en la tabla de Cotizaciones
        Else
            MsgBox("No se han agregado elementos.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaInicio.Focus()
        End If

        'Se muestra la Cotizacion para imprimirla

        'frm.crv.ReportSource = Cn_Reclutamiento.fn_Cotizaciones_GeneraReporte("Id de la Empresa")
        'frm.ShowDialog()

        Call LimpiarDatosGenerales()
        lsv_ServiciosCotizar.Items.Clear()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Public Sub LimpiarDatosGenerales()
        tbx_NumLlamada.Clear()
        tbx_NombreEmpresa.Clear()
    End Sub

    Public Sub LimpiarServicios()
        SegundosDesconexion = 0

        tbx_CveLinea.Clear()
        cmb_LineaServicio.SelectedValue = 0
        'tbx_CvePrecio.Clear()
        cmb_PrecioDescripcion.SelectedValue = 0
        cmb_Precio.SelectedValue = 0
        tbx_CveCuotaRiesgo.Clear()
        cmb_CuotaRiesgo.SelectedValue = 0
        'tbx_CveEnvases.Clear()
        tbx_CveKilometraje.Clear()
        cmb_Kilometraje.SelectedValue = 0
        'cmb_ServicioPredeterminado.SelectedValue = 0
        'cmb_EntregaDotaciones.SelectedValue = 0
        'cmb_CobroUnico.SelectedValue = 0
        'cmb_Recoleccion.SelectedValue = 0
        tbx_DescripcionPrecio.Clear()
        tbx_DescripcionCR.Clear()
        tbx_DescripcionKM.Clear()

        tbx_CantidadPrecio.Clear()
        tbx_CantidadCuotaRiesgo.Clear()
        tbx_CantidadKilometraje.Clear()
    End Sub

    Public Shared Function fn_Cotizaciones_GeneraReporte()
        Try

        Catch ex As Exception

        End Try
    End Function

    Private Sub cmb_LineaServicio_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_LineaServicio.SelectedValueChanged
        If cmb_LineaServicio.Items.Count = 0 Then Exit Sub
        cmb_Precio.ActualizaValorParametro("@Id_Linea", cmb_LineaServicio.SelectedValue)
        cmb_Precio.Actualizar()

        cmb_PrecioDescripcion.ActualizaValorParametro("@Id_Linea", cmb_LineaServicio.SelectedValue)
        cmb_PrecioDescripcion.Actualizar()

        'Revisar si la linea seleccionada es Traslado para activar o bloquear los textboxes
        Dim dt As DataTable = cmb_LineaServicio.DataSource
        If dt.Rows(cmb_LineaServicio.SelectedIndex)("Traslado") = "SI" Then
            tbx_CveCuotaRiesgo.Enabled = True
            tbx_CveKilometraje.Enabled = True
            cmb_Kilometraje.Enabled = True
            cmb_CuotaRiesgo.Enabled = True

            tbx_CantidadCuotaRiesgo.Enabled = True
            tbx_CantidadKilometraje.Enabled = True
            tbx_DescripcionCR.Enabled = True
            tbx_DescripcionKM.Enabled = True

        Else
            cmb_CuotaRiesgo.SelectedValue = 0
            cmb_Kilometraje.SelectedValue = 0
            tbx_CveCuotaRiesgo.Enabled = False
            tbx_CveKilometraje.Enabled = False
            cmb_Kilometraje.Enabled = False
            cmb_CuotaRiesgo.Enabled = False

            tbx_CantidadCuotaRiesgo.Enabled = False
            tbx_CantidadKilometraje.Enabled = False
            tbx_DescripcionCR.Enabled = False
            tbx_DescripcionKM.Enabled = False


        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = 3
        frm.ShowDialog()

        tbx_NumLlamada.Text = frm.Clave
        tbx_NombreEmpresa.Text = frm.Empresa
    End Sub

    Private Sub tbx_NumLlamada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_NumLlamada.TextChanged
        tbx_NombreEmpresa.Clear()
        lsv_ServiciosSolicitados.Items.Clear()
        Call LimpiarServicios()

        If tbx_NumLlamada.Text.Length = 0 Then Exit Sub

        If Not Cn_Clientes.fn_Seguimiento_LlenarLista(Val(tbx_NumLlamada.Text), lsv_ServiciosSolicitados) Then
            MsgBox("Ha ocurrido un error al intentar cargar las Llamadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            If lsv_ServiciosSolicitados.Items.Count > 0 Then tbx_NombreEmpresa.Text = lsv_ServiciosSolicitados.Items(0).SubItems(9).Text

        End If
        lbl_Registros.Text = "Registros: " & lsv_ServiciosCotizar.Items.Count
        Lbl_Registros2.Text = "Registros: " & lsv_ServiciosCotizar.Items.Count
        'Actualizar()
    End Sub

    Private Sub lsv_ServiciosSolicitados_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_ServiciosSolicitados.MouseClick
        Call LimpiarServicios()

        tbx_CantidadPrecio.Text = lsv_ServiciosSolicitados.SelectedItems(0).SubItems(2).Text
        tbx_CantidadCuotaRiesgo.Text = FormatNumber(lsv_ServiciosSolicitados.SelectedItems(0).SubItems(8).Text, 2)
        tbx_CveLinea.Text = lsv_ServiciosSolicitados.SelectedItems(0).SubItems(0).Text
        dtp_FechaInicio.Value = lsv_ServiciosSolicitados.SelectedItems(0).SubItems(7).Text
        tbx_MontoAprox.Text = lsv_ServiciosSolicitados.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub lsv_ServiciosSolicitados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_ServiciosSolicitados.SelectedIndexChanged
        'tbx_CantidadPrecio.Text = lsv_ServiciosSolicitados.SelectedItems(0).SubItems(2).Text
        'tbx_CantidadCuotaRiesgo.Text = FormatNumber(lsv_ServiciosSolicitados.SelectedItems(0).SubItems(8).Text, 2)
    End Sub

    Private Sub lsv_ServiciosSolicitados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ServiciosSolicitados.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_ServiciosCotizar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ServiciosCotizar.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class