Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ConsultaCajasFuertes

    Public ConsultaPorEdad As Boolean = False

    Private Sub frm_ConsultaCajasFuertes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LimpiarLista()
        Call LoadSegunConsulta()
        lsv_ConsultaEdad.Height = 291
        dtp_Desde.Value = Today.Date
        dtp_Hasta.Value = Today.Date
        cmb_Status.AgregarItem("A", "DISPONIBLE")
        cmb_Status.AgregarItem("B", "BAJA")
        cmb_Status.AgregarItem("R", "RENTADA")
        cmb_Status.AgregarItem("V", "VENDIDA")
        cmb_Status.AgregarItem("PR", "EN PROCESO DE RENTA")
        cmb_Status.AgregarItem("PV", "EN PROCESO DE VENTA")
        cmb_Status.AgregarItem("RR", "EN PROCESO DE RETIRO")
        cmb_Status.AgregarItem("M", "MANTENIMIENTO INTERNO")
        cmb_Proveedor.Actualizar()
    End Sub

#Region "SUB's"

    Sub LoadSegunConsulta()
        If Not ConsultaPorEdad Then
            lsv_ConsultaNormal.Columns.Add("Clave")
            lsv_ConsultaNormal.Columns.Add("Marca")
            lsv_ConsultaNormal.Columns.Add("Modelo")
            lsv_ConsultaNormal.Columns.Add("Serie")
            lsv_ConsultaNormal.Columns.Add("Peso(kg)")
            lsv_ConsultaNormal.Columns.Add("Proveedor")
            lsv_ConsultaNormal.Columns.Add("FechaCompra")
            lsv_ConsultaNormal.Columns.Add("FechaFabricacion")
            lsv_ConsultaNormal.Columns.Add("Combinacion")
            lsv_ConsultaNormal.Columns.Add("Observaciones")
            lsv_ConsultaNormal.Columns.Add("Status").Width = 150
            lsv_ConsultaNormal.Columns.Add("Nueva").Width = 60
        Else
            Me.Text = "Consulta de Cajas Fuertes por Edad"
            chk_Fechas.Visible = True
            lsv_ConsultaEdad.Visible = True
            lsv_ConsultaNormal.Visible = False
            lsv_ConsultaEdad.Columns.Add("Serie")
            lsv_ConsultaEdad.Columns.Add("FechaCompra")
            lsv_ConsultaEdad.Columns.Add("Años")
            lsv_ConsultaEdad.Columns.Add("Meses")
            lsv_ConsultaEdad.Columns.Add("Peso(kg)")
            lsv_ConsultaEdad.Columns.Add("Exterior")
            lsv_ConsultaEdad.Columns.Add("Interior")
            lsv_ConsultaEdad.Columns.Add("Marca")
            lsv_ConsultaEdad.Columns.Add("Proveedor")
            lsv_ConsultaEdad.Columns.Add("Modelo")
            lsv_ConsultaEdad.Columns.Add("Status").Width = 150
            lsv_ConsultaEdad.Columns.Add("Nueva").Width = 60
            lsv_ConsultaEdad.Columns.Add("Cliente").Width = 200
        End If
    End Sub

    Sub LimpiarLista()
        SegundosDesconexion = 0
        lsv_ConsultaNormal.Items.Clear()
        lsv_ConsultaEdad.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        btn_Exportar.Enabled = False
    End Sub

    Sub Buscar()
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If Not ConsultaPorEdad Then
            If lsv_ConsultaNormal.SelectedItems.Count > 0 Then Fila_Inicial = lsv_ConsultaNormal.SelectedItems(0).Index + 1
            fn_Buscar_enListView(lsv_ConsultaNormal, tbx_Buscar.Text, 0, Fila_Inicial)
        Else
            If lsv_ConsultaEdad.SelectedItems.Count > 0 Then Fila_Inicial = lsv_ConsultaEdad.SelectedItems(0).Index + 1
            fn_Buscar_enListView(lsv_ConsultaEdad, tbx_Buscar.Text, 0, Fila_Inicial)
        End If
    End Sub

#End Region

#Region "Acciones de Botones"

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then Call Buscar()
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.ClickButton
        Call Buscar()
    End Sub

    Private Sub btn_BuscarProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarProveedores.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Proveedores
        frm.ShowDialog()
        tbx_Proveedor.Text = frm.Clave
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        Dim Status As String

        'If cmb_Proveedor.SelectedValue Is Nothing Then Exit Sub

        If Not chk_Proveedor.Checked AndAlso cmb_Proveedor.SelectedValue = 0 Then
            MsgBox("Seleccione un Proveedor o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedor.Focus()
            Exit Sub
        End If

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("Fecha Inicial debe ser menor que la Fecha Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If Not chk_Status.Checked AndAlso cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Status o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        If Not ConsultaPorEdad Then
            If Not fn_ConsultaCajasFuertes_LlenarLista(lsv_ConsultaNormal, cmb_Proveedor.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status) Then
                MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            lbl_Registros.Text = "Registros: " & lsv_ConsultaNormal.Items.Count
            btn_Exportar.Enabled = lsv_ConsultaNormal.Items.Count > 0
            lsv_ConsultaNormal.Columns.RemoveAt(8)
        Else
            If Not fn_ConsultaCajasFuertesEdad_LlenarLista(lsv_ConsultaEdad, cmb_Proveedor.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, chk_Fechas.Checked, Status) Then
                MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            lbl_Registros.Text = "Registros: " & lsv_ConsultaEdad.Items.Count
            btn_Exportar.Enabled = lsv_ConsultaEdad.Items.Count > 0
            lsv_ConsultaEdad.Columns.RemoveAt(8)
        End If
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        If Not ConsultaPorEdad Then
            fn_Exportar_Excel(lsv_ConsultaNormal, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Else
            fn_Exportar_Excel(lsv_ConsultaEdad, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

#End Region

#Region "ComboBox, CheckBox y DateTimePicker"

    Private Sub cmb_Proveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Proveedor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If dtp_Desde.Enabled Then
                dtp_Desde.Focus()
            ElseIf cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Proveedor_CheckedChanged(ByVal sender As CheckBox, ByVal e As System.EventArgs) Handles chk_Proveedor.CheckedChanged
        Call LimpiarLista()
        cmb_Proveedor.SelectedValue = 0
        tbx_Proveedor.Enabled = Not chk_Proveedor.Checked
        cmb_Proveedor.Enabled = Not chk_Proveedor.Checked
        btn_BuscarProveedores.Enabled = Not chk_Proveedor.Checked
    End Sub

    Private Sub cmb_Proveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Proveedor.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub chk_Fechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Fechas.CheckedChanged
        Call LimpiarLista()
        dtp_Desde.Value = Today.Date
        dtp_Desde.Enabled = Not chk_Fechas.Checked
        dtp_Hasta.Value = Today.Date
        dtp_Hasta.Enabled = Not chk_Fechas.Checked
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        Call LimpiarLista()
        cmb_Status.SelectedValue = "0"
        cmb_Status.Enabled = Not chk_Status.Checked
    End Sub

    Private Sub cmb_Status_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

#End Region

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ConsultaNormal.DoubleClick, lsv_ConsultaEdad.DoubleClick
        SegundosDesconexion = 0

        If lsv_ConsultaNormal.SelectedItems.Count > 0 OrElse lsv_ConsultaEdad.SelectedItems.Count > 0 Then
            Dim frm As New frm_CajasFuertesD
            If Not ConsultaPorEdad Then
                frm.Id_CajaFuerte = lsv_ConsultaNormal.SelectedItems(0).Tag
            Else
                frm.Id_CajaFuerte = lsv_ConsultaEdad.SelectedItems(0).Tag
            End If
            Cn_Login.fn_Log_Create("ABRIR VENTANA: DETALLE DE CAJA FUERTE")
            frm.ShowDialog()
        End If
    End Sub

End Class