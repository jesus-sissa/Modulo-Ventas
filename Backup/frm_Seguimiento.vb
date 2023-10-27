
Imports VB = Microsoft.VisualBasic
Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes


Public Class frm_ConsultaLlamadas

    Private Sub frm_Seguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Pais As Integer = 1

        dtp_desde.Value = Date.Now
        dtp_Hasta.Value = Date.Now

        cmb_Empresa.Actualizar()
        cmb_Ciudad.AgregaParametro("@Id_Pais", Pais, 1)
        cmb_Ciudad.Actualizar()
        cmb_LineaServicio.Actualizar()

        cmb_Tipo.AgregarItem("1", "UNICA VEZ")
        cmb_Tipo.AgregarItem("2", "TEMPORADA")
        cmb_Tipo.AgregarItem("3", "INDEFINIDO")

        cmb_Banco.Actualizar()
        cmb_CiaActual.Actualizar()

        lsv_Listado.Columns.Add("No. Llamada")
        lsv_Listado.Columns.Add("Fecha")
        lsv_Listado.Columns.Add("Hora")
        lsv_Listado.Columns.Add("Empresa")
        lsv_Listado.Columns.Add("Contacto")

        lsv_ServiciosCotizar.Columns.Add("Linea")
        lsv_ServiciosCotizar.Columns.Add("Proceso")
        lsv_ServiciosCotizar.Columns.Add("AcredMismoDia")
        lsv_ServiciosCotizar.Columns.Add("CambioMorralla")
        lsv_ServiciosCotizar.Columns.Add("CajaBancaria")
        lsv_ServiciosCotizar.Columns.Add("CiaActual")
        lsv_ServiciosCotizar.Columns.Add("TipoServicio")
    End Sub

    Private Sub dtp_desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_desde.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Buscar.Focus()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        If dtp_desde.Value > dtp_Hasta.Value Then
            MsgBox("La Fecha Desde debe ser menor a Fecha Hasta.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_desde.Focus()
            Exit Sub
        End If

        fn_ConsultaLlamadas_LlenarLista(dtp_desde.Value, dtp_Hasta.Value, lsv_Listado)
        lbl_Registros.Text = "Registros: " & lsv_Listado.Items.Count
        btn_Exportar.Enabled = lsv_Listado.Items.Count > 0

    End Sub

    Private Sub lsv_Listado_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Listado.MouseDoubleClick
        SegundosDesconexion = 0

        LimpiarDatosContacto()
        LimpiarDatosServicios()
        lsv_ServiciosCotizar.Items.Clear()

        Dim dr_Llamadas As DataRow = fn_ConsultaLlamadas_MuestraDetalles(lsv_Listado.SelectedItems(0).Tag)
        If Not dr_Llamadas Is Nothing Then

            tab_Seguimiento.SelectedTab = tab_Detalle
            rdb_Entrante.Checked = dr_Llamadas("Tipo_Llamada") = "E"
            rdb_Saliente.Checked = dr_Llamadas("Tipo_Llamada") = "S"

            Select Case dr_Llamadas("Status")

                Case "A", "B"
                    rdb_Cliente.Checked = True

                Case "P", "PV"
                    rdb_Prospecto.Checked = True
                Case ""
                    rdb_Nuevo.Checked = True
            End Select

            tbx_Nombre.Text = dr_Llamadas("Nombre_Contacto")

            If dr_Llamadas("Id_Cliente") <> 0 Then
                cmb_Empresa.SelectedValue = dr_Llamadas("Id_Cliente")
            Else
                tbx_Clave.Visible = False
                cmb_Empresa.Visible = False
                tbx_Empresa.Visible = True
                tbx_Empresa.Text = dr_Llamadas("Empresa")
            End If

            tbx_Direccion.Text = dr_Llamadas("Direccion")
            tbx_Colonia.Text = dr_Llamadas("Colonia")
            cmb_Ciudad.SelectedValue = dr_Llamadas("Id_Ciudad")
            tbx_Correo.Text = dr_Llamadas("Mail")
            tbx_Telefono.Text = dr_Llamadas("Telefono")
            tbx_Fax.Text = dr_Llamadas("Fax")
            tbx_ComoSeEntero.Text = dr_Llamadas("Medio_Contacto")
            tbx_Observaciones.Text = dr_Llamadas("Observaciones")
        End If
        fn_Consulta_Llamadas_DetallesServicios(lsv_Listado.SelectedItems(0).Tag, lsv_ServiciosCotizar)
        lsv_ServiciosCotizar.Columns(8).Width = 0
        lsv_ServiciosCotizar.Columns(9).Width = 0
        lsv_ServiciosCotizar.Columns(10).Width = 0
        lsv_ServiciosCotizar.Columns(11).Width = 0
        lsv_ServiciosCotizar.Columns(12).Width = 0
        lsv_ServiciosCotizar.Columns(13).Width = 0
        lsv_ServiciosCotizar.Columns(14).Width = 0
        lsv_ServiciosCotizar.Columns(15).Width = 0
        lsv_ServiciosCotizar.Columns(16).Width = 0
        lsv_ServiciosCotizar.Columns(17).Width = 0
        lsv_ServiciosCotizar.Columns(18).Width = 0
        lsv_ServiciosCotizar.Columns(19).Width = 0
        lsv_ServiciosCotizar.Columns(20).Width = 0
        lsv_ServiciosCotizar.Columns(21).Width = 0
        lsv_ServiciosCotizar.Columns(22).Width = 0

    End Sub

    Private Sub btn_CerrarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerrarDetalle.Click
        SegundosDesconexion = 0

        LimpiarDatosContacto()
        LimpiarDatosServicios()
        lsv_ServiciosCotizar.Items.Clear()
        tab_Seguimiento.SelectedTab = tab_Listado
    End Sub


    Private Sub LimpiarDatosContacto()
        SegundosDesconexion = 0

        rdb_Entrante.Checked = True
        rdb_Cliente.Checked = True

        tbx_Nombre.Clear()
        tbx_Empresa.Visible = False
        tbx_Empresa.Clear()
        tbx_Clave.Visible = True
        tbx_Clave.Clear()
        cmb_Empresa.Visible = True
        cmb_Empresa.SelectedValue = 0
        tbx_Direccion.Clear()
        tbx_Colonia.Clear()
        cmb_Ciudad.SelectedValue = 0
        tbx_Correo.Clear()
        tbx_Telefono.Clear()
        tbx_Fax.Clear()
        tbx_ComoSeEntero.Clear()
        tbx_Observaciones.Clear()

    End Sub

    Private Sub LimpiarDatosServicios()
        SegundosDesconexion = 0

        cmb_LineaServicio.SelectedValue = 0
        cmb_Tipo.SelectedValue = 0
        tbx_Cantidad.Text = ""
        cbx_Proceso.Checked = False
        cbx_Morralla.Checked = False
        cbx_AcreditarMismoDia.Checked = False
        dtp_FechaDesde.Value = Today
        dtp_FechaHasta.Value = Today
        cbx_Dom.Checked = False
        cbx_Lun.Checked = False
        cbx_Mar.Checked = False
        cbx_Mie.Checked = False
        cbx_Jue.Checked = False
        cbx_Vie.Checked = False
        cbx_Sab.Checked = False
        tbx_Monto.Text = ""
        cmb_Banco.SelectedValue = 0
        tbx_Banco.Text = ""
        cbx_Ninguna.Checked = False
        cmb_CiaActual.Enabled = True
        cmb_CiaActual.SelectedValue = 0
        tbx_PrecioActual.Enabled = True
        tbx_PrecioActual.Text = ""
        tbx_CuotaActual.Enabled = True
        tbx_CuotaActual.Text = ""
        tbx_MotivoCambio.Enabled = True
        tbx_MotivoCambio.Text = ""
        tbx_ObservacionesEsp.Text = ""

        tbx_HorarioDom.Clear()
        tbx_HorarioLun.Clear()
        tbx_HorarioMar.Clear()
        tbx_HorarioMie.Clear()
        tbx_HorarioJue.Clear()
        tbx_HorarioVie.Clear()
        tbx_HorarioSab.Clear()

    End Sub

    Private Sub lsv_ServiciosCotizar_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_ServiciosCotizar.MouseDoubleClick

        Dim dia As Char = ""

        Call LimpiarDatosServicios()

        cmb_LineaServicio.SelectedValue = lsv_ServiciosCotizar.SelectedItems(0).SubItems(19).Text
        cmb_Tipo.SelectedValue = lsv_ServiciosCotizar.SelectedItems(0).SubItems(20).Text
        tbx_Cantidad.Text = lsv_ServiciosCotizar.SelectedItems(0).SubItems(7).Text
        cbx_Proceso.Checked = lsv_ServiciosCotizar.SelectedItems(0).SubItems(1).Text = "SI"
        cbx_Morralla.Checked = lsv_ServiciosCotizar.SelectedItems(0).SubItems(2).Text = "SI"
        cbx_AcreditarMismoDia.Checked = lsv_ServiciosCotizar.SelectedItems(0).SubItems(3).Text = "SI"
        dtp_FechaDesde.Value = lsv_ServiciosCotizar.SelectedItems(0).SubItems(9).Text
        dtp_FechaHasta.Value = lsv_ServiciosCotizar.SelectedItems(0).SubItems(10).Text

        For Each s As String In Split(lsv_ServiciosCotizar.SelectedItems(0).SubItems(8).Text, ",")
            If VB.Left(s, 1) = "1" Then
                cbx_Dom.Checked = True
                tbx_HorarioDom.Text = VB.Right(s, (Len(s) - 1))
            End If
            If VB.Left(s, 1) = "2" Then
                cbx_Lun.Checked = True
                tbx_HorarioLun.Text = VB.Right(s, (Len(s) - 1))
            End If
            If VB.Left(s, 1) = "3" Then
                cbx_Mar.Checked = True
                tbx_HorarioMar.Text = VB.Right(s, (Len(s) - 1))
            End If
            If VB.Left(s, 1) = "4" Then
                cbx_Mie.Checked = True
                tbx_HorarioMie.Text = VB.Right(s, (Len(s) - 1))
            End If
            If VB.Left(s, 1) = "5" Then
                cbx_Jue.Checked = True
                tbx_HorarioJue.Text = VB.Right(s, (Len(s) - 1))
            End If
            If VB.Left(s, 1) = "6" Then
                cbx_Vie.Checked = True
                tbx_HorarioVie.Text = VB.Right(s, (Len(s) - 1))
            End If
            If VB.Left(s, 1) = "7" Then
                cbx_Sab.Checked = True
                tbx_HorarioSab.Text = VB.Right(s, (Len(s) - 1))
            End If
        Next
        tbx_Monto.Text = Format(CDec(lsv_ServiciosCotizar.SelectedItems(0).SubItems(11).Text), "###,##0.00")
        cmb_Banco.SelectedValue = lsv_ServiciosCotizar.SelectedItems(0).SubItems(21).Text
        tbx_Banco.Text = lsv_ServiciosCotizar.SelectedItems(0).SubItems(4).Text
        If lsv_ServiciosCotizar.SelectedItems(0).SubItems(22).Text = 0 Then
            cbx_Ninguna.Checked = True
            cmb_CiaActual.Enabled = False
            tbx_PrecioActual.Enabled = False
            tbx_CuotaActual.Enabled = False
            tbx_MotivoCambio.Enabled = False
        Else
            cbx_Ninguna.Checked = False
            cmb_CiaActual.Enabled = True
            tbx_PrecioActual.Enabled = True
            tbx_CuotaActual.Enabled = True
            tbx_MotivoCambio.Enabled = True
            cmb_CiaActual.SelectedValue = lsv_ServiciosCotizar.SelectedItems(0).SubItems(22).Text
        End If

        tbx_PrecioActual.Text = Format(lsv_ServiciosCotizar.SelectedItems(0).SubItems(14).Text, "###,##0.00")
        tbx_CuotaActual.Text = Format(lsv_ServiciosCotizar.SelectedItems(0).SubItems(15).Text, "###,##0.00")
        tbx_MotivoCambio.Text = lsv_ServiciosCotizar.SelectedItems(0).SubItems(16).Text
        tbx_ObservacionesEsp.Text = lsv_ServiciosCotizar.SelectedItems(0).SubItems(18).Text

    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Listado, 2, "Registro de Llamadas", 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Listado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Listado.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub gbx_Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Servicios.MouseHover, gbx_DatosContacto.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class