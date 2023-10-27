
Public Class frm_AtencionLlamadas

    Dim DiasLetras As String = ""
    Dim DiasNumeros As String = ""
    Dim Bandera As Boolean = False

    Private Sub frm_AtencionLlamadas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            SegundosDesconexion = 0

            Me.Close()
        End If
    End Sub

    Private Sub frm_AtencionLlamadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Normal

        Dim Pais As Integer = 1

        lsv_ServiciosCotizar.Columns.Add("Fecha Desde")
        lsv_ServiciosCotizar.Columns.Add("Linea")
        lsv_ServiciosCotizar.Columns.Add("Cantidad")

        lsv_ServiciosCotizar.Columns.Add("Tipo")
        lsv_ServiciosCotizar.Columns.Add("Monto")
        lsv_ServiciosCotizar.Columns.Add("Proceso")
        lsv_ServiciosCotizar.Columns.Add("Morralla")
        lsv_ServiciosCotizar.Columns.Add("Acred. Mismo Dia")
        lsv_ServiciosCotizar.Columns.Add("Dias")

        lsv_ServiciosCotizar.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_ServiciosCotizar.Columns(4).TextAlign = HorizontalAlignment.Right

        cmb_Empresa.AgregaParametro("@Status", "A", 0)
        cmb_Empresa.Actualizar()
        cmb_Ciudad.AgregaParametro("@Id_Pais", Pais, 1)
        cmb_Ciudad.Actualizar()
        cmb_LineaServicio.Actualizar()

        cmb_Tipo.AgregarItem("1", "UNICA VEZ")
        cmb_Tipo.AgregarItem("2", "TEMPORADA")
        cmb_Tipo.AgregarItem("3", "INDEFINIDO")

        cmb_Banco.Actualizar()
        cmb_CiaActual.Actualizar()
        Bandera = True
    End Sub

    Private Sub rdb_nuevo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Nuevo.CheckedChanged
        Call LimpiarDatos()
        If rdb_Cliente.Checked Or rdb_Prospecto.Checked Then
            tbx_Clave.Visible = True
            cmb_Empresa.Visible = True
            tbx_Empresa.Visible = False
            btn_Buscar.Visible = True
            btn_Buscar.Enabled = True
        Else
            tbx_Clave.Visible = False
            cmb_Empresa.Visible = False
            tbx_Empresa.Visible = True
            btn_Buscar.Visible = False
            btn_Buscar.Enabled = False
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Agenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agenda.Click
        SegundosDesconexion = 0

        Dim frm_a As New frm_Agenda
        frm_a.ShowDialog()
        frm_a.Dispose()
    End Sub

    Private Sub cbx_Ninguna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Ninguna.CheckedChanged
        If cbx_Ninguna.Checked Then
            cmb_CiaActual.Enabled = False
            tbx_PrecioActual.Enabled = False
            tbx_CuotaActual.Enabled = False
            tbx_MotivoCambio.Enabled = False
            cmb_CiaActual.SelectedIndex = 0
            tbx_PrecioActual.Clear()
            tbx_CuotaActual.Clear()
            tbx_MotivoCambio.Clear()
        Else
            cmb_CiaActual.Enabled = True
            tbx_PrecioActual.Enabled = True
            tbx_CuotaActual.Enabled = True
            tbx_MotivoCambio.Enabled = True
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        Dim Proceso As Char
        Dim Morralla As Char
        Dim MismoDia As Char
        Dim IdBanco As Integer = 0
        Dim NombreBanco As String = ""

        If cmb_LineaServicio.SelectedValue = 0 Then
            MsgBox("Seleccione la Linea de Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_LineaServicio.Focus()
            Exit Sub
        End If
        If cmb_Tipo.SelectedValue = 0 Then
            MsgBox("", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If
        If tbx_Cantidad.Text = "" Then tbx_Cantidad.Text = 0

        If cbx_Proceso.Checked Then
            Proceso = "S"
        Else
            Proceso = "N"
        End If
        If cbx_Morralla.Checked Then
            Morralla = "S"
        Else
            Morralla = "N"
        End If
        If cbx_AcreditarMismoDia.Checked Then
            MismoDia = "S"
        Else
            MismoDia = "N"
        End If

        If cmb_Tipo.SelectedValue <> 2 Then
            dtp_FechaHasta.Value = dtp_FechaDesde.Value
        End If

        DiasLetras = ""
        DiasNumeros = ""

        Call ConcatenaDias()

        If tbx_Monto.Text = "" Then tbx_Monto.Text = 0

        If cmb_Banco.SelectedValue = 0 Then
            If tbx_Banco.Text <> "" Then
                IdBanco = 0
                NombreBanco = tbx_Banco.Text
            End If
        Else
            IdBanco = cmb_Banco.SelectedValue
            NombreBanco = cmb_Banco.Text
        End If

        If tbx_PrecioActual.Text = "" Then tbx_PrecioActual.Text = 0
        If tbx_CuotaActual.Text = "" Then tbx_CuotaActual.Text = 0

        'Agregar datos al Listview
        lsv_ServiciosCotizar.Items.Add(Format(dtp_FechaDesde.Value, "dd/MM/yyyy"))
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_ClaveLineaServicio.Text)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(Format(CDec(tbx_Cantidad.Text), "###,##0.00"))
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_Tipo.Text)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(Format(CDec(tbx_Monto.Text), "###,##0.00"))
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(Proceso)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(Morralla)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(MismoDia)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(DiasLetras)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_LineaServicio.SelectedValue)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(Format(dtp_FechaHasta.Value, "dd/MM/yyyy"))
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(DiasNumeros)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(IdBanco)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(NombreBanco)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_CiaActual.SelectedValue)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_PrecioActual.Text)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_CuotaActual.Text)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_MotivoCambio.Text)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(tbx_ObservacionesEsp.Text)
        lsv_ServiciosCotizar.Items(lsv_ServiciosCotizar.Items.Count - 1).SubItems.Add(cmb_Tipo.SelectedValue)

        Call LimpiarDatosServicios()
        lbl_Registros.Text = "Registros: " & lsv_ServiciosCotizar.Items.Count
    End Sub

    Private Sub cmb_Tipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedValueChanged
        If cmb_Tipo.SelectedValue <> "2" Then
            dtp_FechaHasta.Enabled = False
        Else
            dtp_FechaHasta.Enabled = True
        End If
    End Sub

    Private Sub ConcatenaDias()
        SegundosDesconexion = 0

        Dim ant As Boolean = False

        If cbx_Dom.Checked Then
            DiasLetras = DiasLetras + "Do"
            DiasNumeros = DiasNumeros + "1" + tbx_HorarioDom.Text
            ant = True
        End If

        If cbx_Lun.Checked Then
            If ant Then
                DiasLetras = DiasLetras + "," + "Lu"
                DiasNumeros = DiasNumeros + "," + "2" + tbx_HorarioLun.Text
            Else
                DiasLetras = DiasLetras + "Lu"
                DiasNumeros = DiasNumeros + "2" + tbx_HorarioLun.Text
            End If
            ant = True
        End If

        If cbx_Mar.Checked Then
            If ant Then
                DiasLetras = DiasLetras + "," + "Ma"
                DiasNumeros = DiasNumeros + "," + "3" + tbx_HorarioMar.Text
            Else
                DiasLetras = DiasLetras + "Ma"
                DiasNumeros = DiasNumeros + "3" + tbx_HorarioMar.Text
            End If
            ant = True
        End If

        If cbx_Mie.Checked Then
            If ant Then
                DiasLetras = DiasLetras + "," + "Mi"
                DiasNumeros = DiasNumeros + "," + "4" + tbx_HorarioMie.Text
            Else
                DiasLetras = DiasLetras + "Mi"
                DiasNumeros = DiasNumeros + "4" + tbx_HorarioMie.Text
            End If
            ant = True
        End If

        If cbx_Jue.Checked Then
            If ant Then
                DiasLetras = DiasLetras + "," + "Ju"
                DiasNumeros = DiasNumeros + "," + "5" + tbx_HorarioJue.Text
            Else
                DiasLetras = DiasLetras + "Ju"
                DiasNumeros = DiasNumeros + "5" + tbx_HorarioJue.Text
            End If
            ant = True
        End If

        If cbx_Vie.Checked Then
            If ant Then
                DiasLetras = DiasLetras + "," + "Vi"
                DiasNumeros = DiasNumeros + "," + "6" + tbx_HorarioVie.Text
            Else
                DiasLetras = DiasLetras + "Vi"
                DiasNumeros = DiasNumeros + "6" + tbx_HorarioVie.Text
            End If
        End If

        If cbx_Sab.Checked Then
            If ant Then
                DiasLetras = DiasLetras + "," + "Sa"
                DiasNumeros = DiasNumeros + "," + "7" + tbx_HorarioSab.Text
            Else
                DiasLetras = DiasLetras + "Sa"
                DiasNumeros = DiasNumeros + "7" + tbx_HorarioSab.Text
            End If
        End If

    End Sub

    Private Sub LimpiarDatosServicios()
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
        cmb_CiaActual.SelectedValue = 0
        tbx_PrecioActual.Text = ""
        tbx_CuotaActual.Text = ""
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

    Private Sub LimpiarDatosContacto()
        rdb_Entrante.Checked = True
        rdb_Cliente.Checked = True

        tbx_Nombre.Clear()
        tbx_Empresa.Clear()
        tbx_Clave.Clear()
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

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim TipoLlamada As Char
        Dim ContactoId As Integer
        Dim NombreEmpresa As String

        If tbx_Nombre.Text = "" Then
            MsgBox("Capture el Nombre del Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombre.Focus()
            Exit Sub
        End If

        If rdb_Nuevo.Checked Then
            If tbx_Empresa.Text = "" Then
                MsgBox("Capture el Nombre de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Empresa.Focus()
                Exit Sub
            End If
            ContactoId = 0
            NombreEmpresa = tbx_Empresa.Text
        Else
            If cmb_Empresa.SelectedValue = 0 Then
                MsgBox("Seleccione la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Empresa.Focus()
                Exit Sub
            End If
            ContactoId = cmb_Empresa.SelectedValue
            NombreEmpresa = cmb_Empresa.Text
        End If

        If rdb_Entrante.Checked Then
            TipoLlamada = "E"
        Else
            TipoLlamada = "S"
        End If

        If Cn_Clientes.fn_SolicitudServicio_Nuevo(TipoLlamada, ContactoId, tbx_Nombre.Text, NombreEmpresa, tbx_Direccion.Text, tbx_Colonia.Text, cmb_Ciudad.SelectedValue, tbx_Telefono.Text, tbx_Fax.Text, tbx_Correo.Text, tbx_ComoSeEntero.Text, tbx_Observaciones.Text, lsv_ServiciosCotizar.Items) Then
            MsgBox("Los datos han sido guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LimpiarDatosContacto()
        Call LimpiarDatosServicios()
        lsv_ServiciosCotizar.Items.Clear()
    End Sub

    Private Sub cbx_Dom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Dom.CheckedChanged
        If cbx_Dom.Checked Then
            tbx_HorarioDom.Enabled = True
            tbx_HorarioDom.Focus()
        Else
            tbx_HorarioDom.Enabled = False
        End If
    End Sub

    Private Sub cbx_Lun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Lun.CheckedChanged
        If cbx_Lun.Checked Then
            tbx_HorarioLun.Enabled = True
            tbx_HorarioLun.Focus()
        Else
            tbx_HorarioLun.Enabled = False
        End If
    End Sub

    Private Sub cbx_Mar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_Mar.CheckedChanged
        If cbx_Mar.Checked Then
            tbx_HorarioMar.Enabled = True
            tbx_HorarioMar.Focus()
        Else
            tbx_HorarioMar.Enabled = False
        End If
    End Sub

    Private Sub cbx_Mie_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_Mie.CheckedChanged
        If cbx_Mie.Checked Then
            tbx_HorarioMie.Enabled = True
            tbx_HorarioMie.Focus()
        Else
            tbx_HorarioMie.Enabled = False
        End If
    End Sub

    Private Sub cbx_Jue_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_Jue.CheckedChanged
        If cbx_Jue.Checked Then
            tbx_HorarioJue.Enabled = True
            tbx_HorarioJue.Focus()
        Else
            tbx_HorarioJue.Enabled = False
        End If
    End Sub

    Private Sub cbx_Vie_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_Vie.CheckStateChanged
        If cbx_Vie.Checked Then
            tbx_HorarioVie.Enabled = True
            tbx_HorarioVie.Focus()
        Else
            tbx_HorarioVie.Enabled = False
        End If
    End Sub

    Private Sub cbx_Sab_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_Sab.CheckedChanged
        If cbx_Sab.Checked Then
            tbx_HorarioSab.Enabled = True
            tbx_HorarioSab.Focus()
        Else
            tbx_HorarioSab.Enabled = False
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        If rdb_Cliente.Checked = True Then
            Frm_BuscarCliente.Cliente = True
            Frm_BuscarCliente.Consulta = Frm_BuscarCliente.Query.Clientes
        Else
            Frm_BuscarCliente.Cliente = False
            Frm_BuscarCliente.Consulta = Frm_BuscarCliente.Query.Prospectos
        End If

        Frm_BuscarCliente.ShowDialog()

        tbx_Clave.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub cbx_Proceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Proceso.CheckedChanged
        SegundosDesconexion = 0

        If cbx_Proceso.Checked Then
            cbx_AcreditarMismoDia.Enabled = True
        Else
            cbx_AcreditarMismoDia.Enabled = False
        End If
    End Sub

    Sub LimpiarDatos()
        SegundosDesconexion = 0

        tbx_Direccion.Text = ""
        tbx_Colonia.Text = ""
        cmb_Ciudad.SelectedValue = ""
        cmb_Ciudad.SelectedValue = 0
        tbx_Correo.Text = ""
        tbx_Telefono.Text = ""
        tbx_Fax.Text = ""
    End Sub

    Private Sub cmb_Empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empresa.SelectedIndexChanged

        Call LimpiarDatos()
        Dim dr_DatosCliente As DataRow = Cn_Clientes.fn_AtencionLlamadas_ObtenValores(cmb_Empresa.SelectedValue)
        If Not dr_DatosCliente Is Nothing Then
            tbx_Direccion.Text = dr_DatosCliente("Direccion")
            tbx_Colonia.Text = dr_DatosCliente("Colonia")
            cmb_Ciudad.SelectedValue = dr_DatosCliente("Id_Ciudad")
        End If
    End Sub

    Private Sub gbx_DatosContacto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_DatosContacto.MouseHover, gbx_AtendiendoA.MouseHover, gbx_Botones.MouseHover, gbx_DatosAdicionales.MouseHover, gbx_Servicios.MouseHover, gbx_ServiciosACotizar.MouseHover, gbx_TipoLllamada.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub RadioButons() Handles rdb_Prospecto.CheckedChanged, rdb_Cliente.CheckedChanged
        Call LimpiarDatos()
        If Bandera Then
            If rdb_Prospecto.Checked Then
                cmb_Empresa.ActualizaValorParametro("@Status", "P")
                cmb_Empresa.Actualizar()
            ElseIf rdb_Cliente.Checked Then
                cmb_Empresa.ActualizaValorParametro("@Status", "A")
                cmb_Empresa.Actualizar()
            End If
        End If
    End Sub
End Class