Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_CajasFuertes
    Dim List_export As New cp_Listview
    Dim CombinacionArr() As String
    Dim Status As String = "T"
    Dim TipoCaja As Integer = 0
    'Dim Acceso As Boolean = False

    Private Sub frm_CajasFuertes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' MessageBox.Show(UsuarioTipo.ToString())

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Marca")
        lsv_Catalogo.Columns.Add("Modelo")
        lsv_Catalogo.Columns.Add("Serie")
        lsv_Catalogo.Columns.Add("Peso(Kg)")
        lsv_Catalogo.Columns.Add("Exterior")
        lsv_Catalogo.Columns.Add("Interior")
        lsv_Catalogo.Columns.Add("FechaCompra")
        lsv_Catalogo.Columns.Add("FechaFabricacion")
        lsv_Catalogo.Columns.Add("Combinacion")
        lsv_Catalogo.Columns.Add("Observaciones", 160, HorizontalAlignment.Left)
        lsv_Catalogo.Columns.Add("Status", 200, HorizontalAlignment.Left)
        lsv_Catalogo.Columns.Add("Nueva", 60, HorizontalAlignment.Left)
        lsv_Catalogo.Columns.Add("CombinacionCliente", 120, HorizontalAlignment.Left)
        lsv_Catalogo.Columns.Add("ClaveCliente", 80, HorizontalAlignment.Right)
        lsv_Catalogo.Columns.Add("Cliente", 250, HorizontalAlignment.Left)
        lsv_Catalogo.Columns.Add("Direccion", 300, HorizontalAlignment.Left)

        cmb_Status.AgregarItem("A", "DISPONIBLE")
        cmb_Status.AgregarItem("V", "VENDIDA")
        cmb_Status.AgregarItem("R", "RENTADA")
        cmb_Status.AgregarItem("B", "BAJA")
        cmb_Status.AgregarItem("PV", "EN PROCESO DE VENTA")
        cmb_Status.AgregarItem("PR", "EN PROCESO DE RENTA")
        cmb_Status.AgregarItem("RR", "EN PROCESO DE RETIRO")
        cmb_Status.AgregarItem("M", "MANTENIMIENTO INTERNO")
        cmb_Status.AgregarItem("P", "PROPIEDAD DEL CLIENTE")
        cmb_Status.AgregarItem("VF", "VENDIDA FIN SERVICIO")

        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()

        cmb_CajaFuerteT.AgregaParametro("@Status", "A", 0)
        cmb_CajaFuerteT.Actualizar()

        cmb_TipoReceptor.AgregaParametro("@Status", "A", 0)
        cmb_TipoReceptor.Actualizar()

        cmb_TipoDial.AgregaParametro("@Status", "A", 0)
        cmb_TipoDial.Actualizar()

        cmb_TipoChapa.AgregaParametro("@Status", "A", 0)
        cmb_TipoChapa.Actualizar()

        cmb_Proveedor.Actualizar()
        cmb_Nueva.AgregarItem("S", "Sí")
        cmb_Nueva.AgregarItem("N", "No")
        dtp_Fabricacion.Value = Today.Date
        dtp_Compra.Value = Today.Date
        dtp_FechaRetiro.Value = Today.Date

        cmb_ClienteAsignado.AgregaParametro("@Status", "A", 0)
        cmb_ClienteAsignado.Actualizar()
        Call ProveedorACliente(False)
        Call Botones()
        Call UltimaClave()
    End Sub

#Region "Sub"
    Sub Buscar()
        SegundosDesconexion = 0
        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
        Call Botones()
    End Sub

    Sub Botones()
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        'Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        'BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Btn_Baja.Enabled = (lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "DISPONIBLE" OrElse lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "PROPIEDAD DEL CLIENTE")
            BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(11).Text <> "BAJA"
            btn_Gestion.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(11).Text <> "BAJA"
            btn_ReciboBaja.Visible = lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "BAJA" AndAlso lsv_Catalogo.SelectedItems(0).SubItems(19).Text = "1"
        Else
            Btn_Baja.Enabled = False
            btn_Gestion.Enabled = False
            btn_ReciboBaja.Visible = False
            BTN_Modificar.Enabled = False
        End If
    End Sub

    Sub Limpiar()
        'Aqui se limpian los textbox
        cmb_CajaFuerteT.SelectedValue = 0
        cmb_TipoReceptor.SelectedValue = 0
        cmb_TipoDial.SelectedValue = 0
        cmb_TipoChapa.SelectedValue = 0
        tbx_ClaveCajaFuerte.Tag = Nothing
        tbx_ClaveCajaFuerte.Clear()
        tbx_Marca.Clear()
        tbx_Modelo.Clear()
        tbx_Serie.Clear()
        tbx_Combinacion0.Clear()
        tbx_Combinacion1.Clear()
        tbx_Combinacion2.Clear()
        tbx_CombinacionCliente.Text = "NO"
        dtp_Fabricacion.Value = Today.Date
        dtp_FechaRetiro.Value = Today.Date
        dtp_Compra.Value = Today.Date
        cmb_Nueva.SelectedValue = 0
        cmb_Proveedor.SelectedValue = 0
        tbx_Proveedor.Clear()
        rtb_Observaciones.Clear()
        lbl_FechaRetiro.Enabled = False
        dtp_FechaRetiro.Enabled = False
        lbl_FechaRetiroA.Visible = False
        Call ProveedorACliente(False)
    End Sub

    Sub Mostrar()
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        FuncionesGlobales.fn_Menu_Progreso(0)
        If cmb_Cliente.Enabled And cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If
        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Estatus o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        FuncionesGlobales.fn_Menu_Progreso(30)
        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If
        FuncionesGlobales.fn_Menu_Progreso(60)
        'Aqui se Actualiza el listview
        Cn_Clientes.fn_CajasFuertes_LlenarLista(lsv_Catalogo, Status, cmb_Cliente.SelectedValue)
        'Nuevo list pero sin la columna combinacion
        Cn_Clientes.fn_CajasFuertes_LlenarListaSincombinaciones(List_export, Status, cmb_Cliente.SelectedValue)


        FuncionesGlobales.fn_Menu_Progreso(90)
        'Se Ponen de color verde los que esten disponibles
        For Each Itms As ListViewItem In lsv_Catalogo.Items
            If Itms.SubItems(11).Text = "DISPONIBLE" Then
                Itms.ForeColor = System.Drawing.Color.Green
            End If
            If Itms.SubItems(11).Text = "VENDIDA FIN SERVICIO" Then
                Itms.ForeColor = System.Drawing.Color.Red
            End If
        Next
        FuncionesGlobales.fn_Menu_Progreso(100)
        Call Botones()
        FuncionesGlobales.fn_Menu_Progreso(0)
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        If Not Acceso Then
            If lsv_Catalogo.Items.Count >= 0 Then
                lsv_Catalogo.Columns.RemoveAt(9)
            End If
        End If
    End Sub

    Sub UltimaClave()
        Dim dr As DataRow = fn_CajasFuertes_UltimaClave()
        If dr Is Nothing Then
            tbx_ClaveCajaFuerte.Text = "0001"
        Else
            tbx_ClaveCajaFuerte.Text = dr("Clave_CajaFuerte") + 1
        End If
    End Sub

    Private Function Validar() As Boolean

        'Validar ingreso de datos
        If cmb_CajaFuerteT.SelectedValue = 0 Then
            MsgBox("Seleccione un Tipo de Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaFuerteT.Focus()
            Return True
        End If

        If cmb_TipoReceptor.SelectedValue = 0 Then
            MsgBox("Seleccione un Tipo de Receptor.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaFuerteT.Focus()
            Return True
        End If

        If TipoCaja = 1 Then

            If tbx_ClaveCajaFuerte.Text = Nothing Then
                MsgBox("Capture la Clave de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_ClaveCajaFuerte.Focus()
                Return True
            End If

            If tbx_Marca.Text = Nothing Then
                MsgBox("Capture la Marca.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Marca.Focus()
                Return True
            End If

            If tbx_Modelo.Text = Nothing Then
                MsgBox("Capture el Modelo.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Modelo.Focus()
                Return True
            End If

            If tbx_Serie.Text = Nothing Then
                MsgBox("Capture la Serie.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Serie.Focus()
                Return True
            End If

            If tbx_Combinacion0.Text = Nothing Or tbx_Combinacion1.Text = Nothing Or tbx_Combinacion2.Text = Nothing Then
                MsgBox("Capture la Combinación.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Combinacion0.Focus()
                Return True
            End If

            If dtp_Fabricacion.Value.Date > Now.Date Then
                MsgBox("La Fecha de Fabricación no puede ser mayor al del día de hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_Fabricacion.Focus()
                Return True
            End If

            If cmb_Nueva.SelectedValue.ToString = "0" Then
                MsgBox("Seleccione si es Nueva o no la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Nueva.Focus()
                Return True
            End If

            If dtp_FechaRetiro.Enabled And dtp_FechaRetiro.Value.Date <= Now.Date Then
                MsgBox("La Fecha de Retiro no puede ser menor o igual a la Fecha Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_FechaRetiro.Focus()
                Return True
            End If

            If cmb_Proveedor.SelectedValue = 0 Then
                MsgBox("Seleccione un Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Proveedor.Focus()
                Return True
            End If

            If dtp_Compra.Value.Date > Now.Date Then
                MsgBox("La Fecha de Compra no puede ser mayor al del día de hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_Compra.Focus()
                Return True
            End If
        ElseIf TipoCaja = 2 Then

            If tbx_Combinacion0.Text = Nothing Or tbx_Combinacion1.Text = Nothing Or tbx_Combinacion2.Text = Nothing Then
                MsgBox("Capture la Combinación.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Combinacion0.Focus()
                Return True
            End If

            If tbx_Marca.Text.Trim = "" Then tbx_Marca.Text = ""
            If tbx_Serie.Text.Trim = "" Then tbx_Serie.Text = ""

            If cmb_ClienteAsignado.SelectedValue = 0 Then
                MsgBox("Seleccione el Cliente propietario de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_ClienteAsignado.Focus()
                Return True
            End If

            If dtp_Fabricacion.Value.Date > Now.Date Then
                MsgBox("La Fecha de Fabricación no puede ser mayor al del día de hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_Fabricacion.Focus()
                Return True
            End If

            If dtp_FechaRetiro.Enabled And dtp_FechaRetiro.Value.Date <= Now.Date Then
                MsgBox("La Fecha de Retiro no puede ser menor o igual a la Fecha Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_FechaRetiro.Focus()
                Return True
            End If

            If dtp_Compra.Value.Date > Now.Date Then
                MsgBox("La Fecha de Compra no puede ser mayor al del día de hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_Compra.Focus()
                Return True
            End If

        End If
        Return False
    End Function

#End Region

#Region "Enter"

    Private Sub dtp_Fabricacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fabricacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cmb_Nueva.Focus()
        End If
    End Sub

    Private Sub dtp_Compra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Compra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            rtb_Observaciones.Focus()
        End If
    End Sub

    Private Sub dtp_FechaRetiro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaRetiro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Proveedor.Focus()
        End If
    End Sub
#End Region

#Region "Botones y ComboBox"

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Buscar()
        End If
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        Call Buscar()
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Clientes.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        cmb_Cliente.SelectedValue = 0
        cmb_Cliente.Enabled = chk_Clientes.Checked = False
        tbx_Cliente.Enabled = chk_Clientes.Checked = False
        lbl_Cliente.Enabled = chk_Clientes.Checked = False
        btn_BuscarCliente.Enabled = chk_Clientes.Checked = False
        Call Botones()
    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Frm_BuscarCliente.Consulta = Frm_BuscarCliente.Query.Clientes
        Frm_BuscarCliente.ShowDialog()
        tbx_Cliente.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0
        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = chk_Status.Checked = False
        lbl_Status.Enabled = chk_Status.Checked = False
        Call Botones()
    End Sub

    Private Sub cmb_Status_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        Call Mostrar()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        If Acceso Then
            FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        Else
            FuncionesGlobales.fn_Exportar_Excel(List_export, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        End If
    End Sub
    Sub Permiso(ByVal acceso As Boolean)
        If acceso Then
            grp_DimensionE.Enabled = False
            grp_DimensionI.Enabled = False
            Pnl_infocompra.Enabled = False
            pnl_des.Enabled = False
            pnl_des2.Enabled = False
        Else
            '
            tbx_Combinacion0.Enabled = False
            tbx_Combinacion1.Enabled = False
            tbx_Combinacion2.Enabled = False
            tbx_Combinacion0.UseSystemPasswordChar = True
            tbx_Combinacion1.UseSystemPasswordChar = True
            tbx_Combinacion2.UseSystemPasswordChar = True
            'lbl_Observaciones.Visible = False
            'rtb_Observaciones.Visible = False
            grp_detallescomb.Visible = False
            '  rtb_Observaciones.Text = "******"
            'rtb_Observaciones.UseSystemPasswordChar = True
        End If
    End Sub
    'Llena el listbox de combinaciones 
    Sub Llena_ListCombinaciones()
        Dim datos() As String
        ltb_LogCombinacion.Items.Clear()
        Dim dr As DataRow = fn_CajasFuertes_LogCombinaciones_Get(tbx_ClaveCajaFuerte.Tag)
        If Not dr.IsNull(0) Then
            datos = Split(dr("Log_Combinacion"), "*")
            ltb_LogCombinacion.Items.Add("Usuario realizó : " + datos(0).ToString)
            ltb_LogCombinacion.Items.Add("")
            ltb_LogCombinacion.Items.Add("Fecha de cambio   : " + datos(2).ToString)
            ltb_LogCombinacion.Items.Add("")
            ltb_LogCombinacion.Items.Add("Combinación anterior : " + datos(1).ToString)
        End If
    End Sub
    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        If lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "BAJA" Then
            Exit Sub
        End If
        Dim dr As DataRow = fn_CajasFuertes_Read(lsv_Catalogo.SelectedItems(0).Tag)

        'Aqui se establece el texto del objeto seleccionado
        tbx_ClaveCajaFuerte.Tag = lsv_Catalogo.SelectedItems(0).Tag
        tbx_ClaveCajaFuerte.Text = dr("Clave_CajaFuerte")
        cmb_CajaFuerteT.SelectedValue = dr("Id_CajaFuerteT")
        tbx_Marca.Text = dr("Marca")
        tbx_Modelo.Text = dr("Modelo")
        tbx_Serie.Text = dr("Serie")
        cmb_Proveedor.SelectedValue = dr("Id_Proveedor")
        dtp_Compra.Value = dr("Fecha_Compra")
        dtp_Fabricacion.Value = dr("Fecha_Fabricacion")
        CombinacionArr = Split(dr("Combinacion"), " ")
        tbx_CombinacionCliente.Text = dr("CombinacionCliente")
        rtb_Observaciones.Text = dr("Observaciones")
        'cmb_TipoReceptor.SelectedValue = dr("Id_Receptor")
        cmb_TipoReceptor.SelectedValue = IIf(Convert.ToString(dr("Id_Receptor")) = "", 0, dr("Id_Receptor"))
        'cmb_TipoDial.SelectedValue = dr("Id_Dial")
        cmb_TipoDial.SelectedValue = IIf(Convert.ToString(dr("Id_Dial")) = "", 0, dr("Id_Dial"))
        'cmb_TipoChapa.SelectedValue = dr("Id_Chapa")
        cmb_TipoChapa.SelectedValue = IIf(Convert.ToString(dr("Id_Chapa")) = "", 0, dr("Id_Chapa"))
        cmb_ClienteAsignado.SelectedValue = lsv_Catalogo.SelectedItems(0).SubItems(18).Text
        If dr("Utiliza_Combinacion") = "SI" Then rdb_CombinacionSI.Checked = True Else rdb_CombinacionNO.Checked = True

        If dr("Nueva") <> Nothing Then
            cmb_Nueva.SelectedValue = dr("Nueva")
        Else
            cmb_Nueva.SelectedValue = 0
        End If

        chk_Retiro.Checked = False
        If lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "RENTADA" OrElse lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "PENDIENTE EN RENTA" Then
            chk_Retiro.Enabled = True
            lbl_FechaRetiro.Enabled = True
            If dr("Fin_Renta") <> Nothing Then
                dtp_FechaRetiro.Value = dr("Fin_Renta")
                dtp_FechaRetiro.Enabled = True
                lbl_FechaRetiroA.Visible = True
            Else
                chk_Retiro.Checked = True
                dtp_FechaRetiro.Enabled = False
                lbl_FechaRetiroA.Visible = False
                dtp_FechaRetiro.Value = Today.Date
            End If
        Else
            chk_Retiro.Enabled = False
            lbl_FechaRetiro.Enabled = False
            dtp_FechaRetiro.Enabled = False
            lbl_FechaRetiroA.Visible = False
            cmb_TipoReceptor.Visible = True
            cmb_TipoReceptor.Enabled = True
        End If
        'Carga el LogCombinaciones
        Llena_ListCombinaciones()
        '
        Try
            tbx_Combinacion0.Text = CombinacionArr(0)
            tbx_Combinacion1.Text = CombinacionArr(1)
            tbx_Combinacion2.Text = CombinacionArr(2)
        Catch
        End Try
        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"
        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo
        Permiso(Acceso)
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0
        'Revisa si la caja fuerte esta de baja
        If lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "DISPONIBLE" Then
            Dim Imprimir As Boolean = lsv_Catalogo.SelectedItems(0).SubItems(19).Text = "1"
            Dim frm As New frm_BajaCajaFuerte
            frm.Id_CajaFuerte = lsv_Catalogo.SelectedItems(0).Tag
            frm.Id_CajaFuerteT = lsv_Catalogo.SelectedItems(0).SubItems(17).Text
            frm.Imprimir = Imprimir
            Cn_Login.fn_Log_Create("ABRIR VENTANA: BAJA DE CAJAS FUERTES")
            frm.ShowDialog()

            Call Mostrar()
        Else
            MsgBox("La Caja Fuerte no puede darse de Baja, porque no se encuentra Disponible.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub btn_Gestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Gestion.Click
        SegundosDesconexion = 0
        ' If Acceso Then Exit Sub
        If lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "BAJA" Then
            MsgBox("La Caja Fuerte que seleccionó esta dada de Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim frm As New frm_CajasFuertesMov

        frm.Id_CajaFuerte = lsv_Catalogo.SelectedItems(0).Tag
        frm.Id_CajaFuerteT = lsv_Catalogo.SelectedItems(0).SubItems(17).Text
        frm.CombinacionActual = Split(lsv_Catalogo.SelectedItems(0).SubItems(9).Text, " ")

        frm.Id_Cliente = lsv_Catalogo.SelectedItems(0).SubItems(18).Text
        If lsv_Catalogo.SelectedItems(0).SubItems(13).Text = "SI" Then
            frm.ManejoCombinacion = "S"
        ElseIf lsv_Catalogo.SelectedItems(0).SubItems(13).Text = "NO" Then
            frm.ManejoCombinacion = "N"
        Else
            frm.ManejoCombinacion = ""
        End If

        Select Case lsv_Catalogo.SelectedItems(0).SubItems(11).Text
            Case "PROCESO EN VENTA", "PROCESO EN RENTA", "PROCESO EN RETIRO"
                frm.StatusMov = "PROCESO"
            Case "VENDIDA"
                frm.StatusMov = "V"
            Case "DISPONIBLE"
                frm.StatusMov = "A"
            Case "MANTENIMIENTO INTERNO"
                frm.StatusMov = "M"
            Case "RENTADA"
                frm.StatusMov = "R"
        End Select

        'Para el nombre
        frm.CajaClave = lsv_Catalogo.SelectedItems(0).Text
        frm.CajaMarca = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        frm.CajaSerie = lsv_Catalogo.SelectedItems(0).SubItems(3).Text
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GESTIÓN DE CAJAS FUERTES")
        frm.ShowDialog()
        Call Mostrar()
    End Sub

    Private Sub btn_ReciboBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReciboBaja.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems(0).SubItems(19).Text = "2" Then
            MsgBox("La Caja es del tipo NO PROPIA, por lo que no se imprime recibo de baja.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim dr_CajaFuerteB As DataRow = fn_CajasFuertesBaja_ReadUltimo(lsv_Catalogo.SelectedItems(0).Tag)

        If dr_CajaFuerteB("Id_CajaFuerteB") <> Nothing Then
            Dim frm As New frm_Reporte
            Dim rpt As New rpt_ActaBajaCajaFuerte
            Dim Ds As New ds_Reporte

            'Reporte de Baja de Cajas Fuertes
            frm.crv.ReportSource = rpt
            If Not fn_Imprimir_LlenarReciboBajaCajaFuerte(Ds.Tbl_CajasFuertesBajas, dr_CajaFuerteB("Id_CajaFuerteB")) Then
                MsgBox("Error al intentar generar el Recibo de Baja de Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If Not fn_Reportes_Encabezado(Ds.Tbl_DatosEmpresa) Then
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
        Else
            MsgBox("Error al intentar generar el Recibo de Baja de Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Botones()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub
    Private Sub cmb_CajaFuerteT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaFuerteT.SelectedIndexChanged
        'Segun el valor del tipo de Caja Fuerte se llenan los textbox
        If cmb_CajaFuerteT.SelectedValue = 0 Then
            tbx_Marca.Clear()
            tbx_Modelo.Clear()
            tbx_Peso.Text = 0.0
            tbx_AltoE.Text = 0
            tbx_AnchoE.Text = 0
            tbx_FondoE.Text = 0
            tbx_AltoI.Text = 0
            tbx_AnchoI.Text = 0
            tbx_FondoI.Text = 0
            TipoCaja = 0
            Call ProveedorACliente(False)
        Else
            Dim dr As DataRow = Cn_Clientes.fn_CajasFuertesT_Read(cmb_CajaFuerteT.SelectedValue)
            If dr IsNot Nothing Then
                tbx_Peso.Text = dr("Peso")
                tbx_Modelo.Text = dr("Modelo")
                tbx_AnchoE.Text = dr("AnchoE")
                tbx_AltoE.Text = dr("AltoE")
                tbx_FondoE.Text = dr("FondoE")
                tbx_AnchoI.Text = dr("AnchoI")
                tbx_AltoI.Text = dr("AltoI")
                tbx_FondoI.Text = dr("FondoI")
                TipoCaja = dr("Tipo").ToString
                dr = Nothing
                Select Case Microsoft.VisualBasic.Left(cmb_CajaFuerteT.Text, 2)
                    Case "CA"
                        tbx_Marca.Text = "CASPER"

                    Case "SE"
                        tbx_Marca.Text = "ARMSTRONG"

                End Select
                If TipoCaja = 1 Then
                    Call ProveedorACliente(False)
                ElseIf TipoCaja = 2 Then
                    Call ProveedorACliente(True)
                End If
            Else
                tbx_Marca.Clear()
                tbx_Modelo.Clear()
                tbx_Peso.Text = 0.0
                tbx_AltoE.Text = 0
                tbx_AnchoE.Text = 0
                tbx_FondoE.Text = 0
                tbx_AltoI.Text = 0
                tbx_AnchoI.Text = 0
                tbx_FondoI.Text = 0
                TipoCaja = 0
                Call ProveedorACliente(False)
            End If
        End If
    End Sub

    Sub ProveedorACliente(ByVal Cambiar As Boolean)
        cmb_Proveedor.Visible = Not Cambiar
        btn_BuscarProveedores.Visible = Not Cambiar
        lbl_FechaCompra.Visible = Not Cambiar
        dtp_Compra.Visible = Not Cambiar
        lbl_Observaciones.Visible = Not Cambiar
        rtb_Observaciones.Visible = Not Cambiar
        dtp_CompraA.Visible = Not Cambiar

        cmb_ClienteAsignado.Visible = Cambiar
        If Cambiar Then
            grp_InfoCompra.Text = "Propietario de la Caja Fuerte"
            lbl_Proveedor.Text = "Cliente"
            cmb_ClienteAsignado.Filtro = tbx_Proveedor
            cmb_Proveedor.Filtro = Nothing
        Else
            grp_InfoCompra.Text = "Información de Compra"
            lbl_Proveedor.Text = "Proveedor"
            cmb_ClienteAsignado.Filtro = Nothing
            cmb_Proveedor.Filtro = tbx_Proveedor
        End If
    End Sub

    Private Sub btn_BuscarProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarProveedores.Click
        SegundosDesconexion = 0
        Dim frm As New Frm_BuscarCliente
        Frm_BuscarCliente.Consulta = Frm_BuscarCliente.Query.Proveedores
        tbx_Proveedor.Text = frm.Clave
        Frm_BuscarCliente.ShowDialog()
    End Sub
    'Insertar LogCombinacion
    Sub LogCombinacion()
        Dim CombinacionAnterior As String = CombinacionArr(0) + CombinacionArr(1) + CombinacionArr(2)
        If CombinacionAnterior <> (tbx_Combinacion0.Text.Trim + tbx_Combinacion1.Text.Trim + tbx_Combinacion2.Text.Trim) Then
            Cn_Clientes.fn_CajasFuertes_LogCombinaciones(tbx_ClaveCajaFuerte.Tag, (Convert.ToString(UsuarioId) + "*" + CombinacionAnterior))
        End If
    End Sub
    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        'Validar ingreso de datos
        If Validar() Then Exit Sub
        Dim Combinacion As String
        Dim UtilizaCombinacion As String

        If rdb_CombinacionSI.Checked Then UtilizaCombinacion = "S" Else UtilizaCombinacion = "N"

        Combinacion = tbx_Combinacion0.Text.Trim & " " & tbx_Combinacion1.Text.Trim & " " & tbx_Combinacion2.Text.Trim

        'En caso de que todo sea valido
        If Tab_Nuevo.Text = "Nuevo" Then
            'Validar que la clave no este repetida
            Dim DT As DataTable = Cn_Clientes.fn_CajasFuertes_Read()
            If DT IsNot Nothing Then
                For Each dr As DataRow In DT.Rows
                    If dr("Clave_CajaFuerte") = tbx_ClaveCajaFuerte.Text Then
                        DT.Dispose()
                        MsgBox("La Clave: " & tbx_ClaveCajaFuerte.Text & " ya existe, se guardará con la siguiente Clave.", MsgBoxStyle.Information, frm_MENU.Text)
                    End If
                Next
            End If

            Dim Status As String = "A"
            If TipoCaja = 2 Then Status = "P"

            'Si se esta Insertando
            If Cn_Clientes.fn_CajasFuertes_Nuevo(cmb_CajaFuerteT.SelectedValue, tbx_Marca.Text, tbx_Serie.Text, cmb_Proveedor.SelectedValue, dtp_Compra.Value.Date,
                                                 dtp_Fabricacion.Value.Date, Combinacion, rtb_Observaciones.Text, IIf(cmb_Nueva.SelectedValue = "0", "", cmb_Nueva.SelectedValue),
                                                 TipoCaja, Status, cmb_ClienteAsignado.SelectedValue, cmb_TipoReceptor.SelectedValue, cmb_TipoDial.SelectedValue, cmb_TipoChapa.SelectedValue, UtilizaCombinacion) Then
                'En caso de que se haya hecho la transaccion
                Call Limpiar()
                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"
                FuncionesGlobales.fn_Menu_Progreso(40)
                cmb_CajaFuerteT.Focus()
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se pudo agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
                Exit Sub
            End If
        Else
            'Si se esta actualizando
            Dim CombinacionCliente As String

            If cmb_TipoReceptor.SelectedIndex = 0 Then ' Then
                MsgBox("Seleccione un tipo de Receptor.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If cmb_TipoDial.SelectedIndex = 0 Then
                MsgBox("Seleccione un tipo de Dial.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If cmb_TipoChapa.SelectedIndex = 0 Then
                MsgBox("Seleccione un tipo de Chapa.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If tbx_CombinacionCliente.Text = "SI" Then CombinacionCliente = "S" Else CombinacionCliente = "N"


            If Cn_Clientes.fn_CajasFuertes_Actualizar(tbx_ClaveCajaFuerte.Tag, cmb_CajaFuerteT.SelectedValue, tbx_Marca.Text, tbx_Serie.Text,
                                                      cmb_Proveedor.SelectedValue, dtp_Compra.Value.Date, dtp_Fabricacion.Value.Date, Combinacion,
                                                      rtb_Observaciones.Text, IIf(cmb_Nueva.SelectedValue = "0", "", cmb_Nueva.SelectedValue), CombinacionCliente, dtp_FechaRetiro.Value.Date,
                                                      dtp_FechaRetiro.Enabled, cmb_ClienteAsignado.SelectedValue, cmb_TipoReceptor.SelectedValue, cmb_TipoDial.SelectedValue, cmb_TipoChapa.SelectedValue, UtilizaCombinacion) Then
                'Llamada ala funcion de combinacionlog 08/11/2019
                LogCombinacion()
                'En caso de que se haya hecho la transaccion
                FuncionesGlobales.fn_Menu_Progreso(30)
                Call Limpiar()
                Tab_Nuevo.Text = "Nuevo"
                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado
                FuncionesGlobales.fn_Menu_Progreso(40)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se pudo editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
                Exit Sub
            End If
        End If

        If (cmb_Cliente.SelectedValue > 0 OrElse chk_Clientes.Checked) AndAlso (cmb_Status.SelectedValue > "0" OrElse chk_Status.Checked) Then
            Call Mostrar()
        End If
        Call UltimaClave()
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Call Limpiar()
        Call UltimaClave()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"
    End Sub

#End Region

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

    Private Sub chk_Retiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Retiro.CheckedChanged
        SegundosDesconexion = 0

        dtp_FechaRetiro.Enabled = Not chk_Retiro.Checked
        lbl_FechaRetiroA.Visible = Not chk_Retiro.Checked
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        If Tab_Catalogo.SelectedTab.Text = "Nuevo" Then
            If Not Acceso Then
                tbx_Combinacion0.Enabled = True
                tbx_Combinacion1.Enabled = True
                tbx_Combinacion2.Enabled = True
                'cmb_TipoReceptor.Visible = True
                'lbl_Observaciones.Enabled = True
                'rtb_Observaciones.Enabled = True
            Else
                Tab_Catalogo.SelectedIndex = 0

            End If
        End If
        ''If Tab_Catalogo.SelectedTab = tab_Listado Then

    End Sub

    'Private Sub cmb_TipoReceptor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TipoReceptor.SelectedIndexChanged
    '    cmb_TipoReceptor.ActualizaValorParametro("@Id_Tipo", cmb_TipoReceptor.SelectedValue)
    '    'cmb_TipoReceptor.Actualizar()
    'End Sub

    'Private Sub cmb_TipoDial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TipoDial.SelectedIndexChanged
    '    cmb_TipoDial.ActualizaValorParametro("@Id_Tipo", cmb_TipoDial.SelectedValue)
    '    'cmb_TipoDial.Actualizar()
    'End Sub

    'Private Sub cmb_TipoChapa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TipoChapa.SelectedIndexChanged
    '    cmb_TipoChapa.ActualizaValorParametro("@Id_Tipo", cmb_TipoChapa.SelectedValue)
    '    'cmb_TipoChapa.Actualizar()
    'End Sub

    Private Sub cmb_TipoReceptor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_TipoReceptor.SelectedValueChanged
        cmb_TipoReceptor.ActualizaValorParametro("@Id_Tipo", cmb_TipoReceptor.SelectedValue)
        'cmb_TipoReceptor.Actualizar()
    End Sub

    Private Sub cmb_TipoDial_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_TipoDial.SelectedValueChanged
        cmb_TipoDial.ActualizaValorParametro("@Id_Tipo", cmb_TipoDial.SelectedValue)
        'cmb_TipoDial.Actualizar()
    End Sub

    Private Sub cmb_TipoChapa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_TipoChapa.SelectedValueChanged
        cmb_TipoChapa.ActualizaValorParametro("@Id_Tipo", cmb_TipoChapa.SelectedValue)
        'cmb_TipoChapa.Actualizar()
    End Sub
End Class