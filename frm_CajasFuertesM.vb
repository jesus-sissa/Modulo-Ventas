Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_CajasFuertesM
    Dim List_export As New cp_Listview
    Dim CombinacionArr() As String
    Dim Status As String = "T"
    Dim TipoCaja As Integer = 0
    Dim hoy As Date = Date.Now
    Dim dia30 As Date = hoy.AddDays(-30)
    Dim dia40 As Date = hoy.AddDays(-40)


    Private Sub frm_CajasFuertes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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

        cmb_General.AgregarItem("2", "Por Día")
        cmb_General.AgregarItem("3", "Por Semana")
        cmb_General.SelectedIndex = 0

        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()

    End Sub

#Region "Sub"
    Sub Buscar()
        SegundosDesconexion = 0
        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
        'Call Botones()
    End Sub

    Sub Mostrar()

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Dim base = hoy.AddDays(-30).ToString("yyyy-MM-dd")
        Dim fechaFin = dtpFin.Value.AddDays(-30).ToString("yyyy-MM-dd")
        Dim fechaInicio = dtpInicio.Value.AddDays(-30).ToString("yyyy-MM-dd")

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

        'If cmb_General.SelectedIndex = 0 Then
        '    MsgBox("Seleccione un tipo de Reporte", MsgBoxStyle.Critical, frm_MENU.Text)
        '    cmb_General.Focus()
        '    Exit Sub
        'End If

        If cmb_General.SelectedIndex = 2 Or cmb_General.SelectedIndex = 3 Then
            If fechaInicio < base Then
                MsgBox("La fecha " & cmb_General.Text & " no puede ser menor que la fecha Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtpInicio.Focus()
                Exit Sub
            End If

            Dim f As Date = fechaInicio
            Dim dia07 As Date = f.AddDays(+7).ToString("yyyy-MM-dd")
            If fechaFin > dia07 Then
                MsgBox("El rengo de Fechas solo llega hasta una semana.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If cmb_General.SelectedIndex = 3 Then
                If fechaInicio > fechaFin Then
                    MsgBox("Las fechas seleccionadas parecen ser incorrectas.", MsgBoxStyle.Critical, frm_MENU.Text)
                    dtpInicio.Focus()
                    Exit Sub
                End If

            End If

        End If

        FuncionesGlobales.fn_Menu_Progreso(30)
        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        'Aqui se Actualiza el listview

        Select Case cmb_General.SelectedIndex
            Case 0
                Reporte_General()
            Case 1
                ReportePorDia(fechaInicio)
            Case 2
                ReportePorSemana(fechaInicio, fechaFin)
            Case Else

        End Select
        FuncionesGlobales.fn_Menu_Progreso(60)
        lsv_Catalogo.Columns(10).Width = 200

        FuncionesGlobales.fn_Menu_Progreso(100)
        'Call Botones()
        FuncionesGlobales.fn_Menu_Progreso(0)
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count

    End Sub
    Dim tbl As DataTable
    Sub Reporte_General(Optional Busqueda As String = "N")
        If (Busqueda.Equals("N")) Then
            tbl = Cn_Clientes.fn_CajasFuertes_LlenarListaSemaforo(Status, cmb_Cliente.SelectedValue)
        End If

        lsv_Catalogo.Actualizar(tbl, "Id_CajaFuerte")
        FuncionesGlobales.fn_Menu_Progreso(60)

        For Each Itms As ListViewItem In lsv_Catalogo.Items
            'si la fehca es igual 
            Dim fechaBase As Date = IIf(Itms.SubItems(5).Text = "", dia40, Itms.SubItems(5).Text)

            If fechaBase.ToShortDateString > dia30 Then
                Itms.ForeColor = System.Drawing.Color.Green
                Itms.SubItems(6).Text = fechaBase.AddDays(30).ToShortDateString()
                Itms.SubItems(11).Text = "VERDE"
            Else

                If fechaBase.ToShortDateString > dia40 Then
                    Itms.ForeColor = System.Drawing.Color.Orange
                    Itms.SubItems(6).Text = fechaBase.AddDays(30).ToShortDateString()
                    Itms.SubItems(11).Text = "AMARILLO"
                Else
                    Itms.ForeColor = System.Drawing.Color.PaleVioletRed
                    Itms.SubItems(6).Text = fechaBase.AddDays(30).ToShortDateString()
                    Itms.SubItems(11).Text = "ROJO"
                End If
            End If
            If (Busqueda <> "N" AndAlso Itms.SubItems(11).Text <> Busqueda) Then
                Itms.Remove()
            End If
                FuncionesGlobales.fn_Menu_Progreso(90)
        Next
        lsv_Catalogo.Columns(10).Width = 200
        lsv_Catalogo.Columns(11).Width = 0
        Lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Sub ReportePorDia(ByVal fechaInicio)
        'Dim fechaInicio = DateTimePicker1.Value.AddDays(-30).ToString("yyyy-MM-dd")
        FuncionesGlobales.fn_Menu_Progreso(60)
        Cn_Clientes.fn_CajasFuertes_PorDia(lsv_Catalogo, Status, cmb_Cliente.SelectedValue, fechaInicio)
        For Each Itms As ListViewItem In lsv_Catalogo.Items
            Itms.SubItems(6).Text = dtpInicio.Value.ToShortDateString()
        Next
        FuncionesGlobales.fn_Menu_Progreso(90)

    End Sub

    Sub ReportePorSemana(ByVal fechaInicio, ByVal fechaFin)
        'Dim fechaInicio = DateTimePicker1.Value.AddDays(-30).ToString("yyyy-MM-dd")
        'Dim fechaFin = DateTimePicker2.Value.AddDays(-30).ToString("yyyy-MM-dd")
        FuncionesGlobales.fn_Menu_Progreso(60)
        Cn_Clientes.fn_CajasFuertes_PorDia_Semana(lsv_Catalogo, Status, cmb_Cliente.SelectedValue, fechaInicio, fechaFin)
        For Each Itms As ListViewItem In lsv_Catalogo.Items
            Dim sum As Date = Itms.SubItems(5).Text
            Itms.SubItems(6).Text = sum.AddDays(+30)
        Next
        FuncionesGlobales.fn_Menu_Progreso(90)
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
        'Call Botones()
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
        'Call Botones()
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
        'Call Botones()
    End Sub

    Private Sub cmb_Status_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        'Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        Call Mostrar()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        FuncionesGlobales.fn_Menu_Progreso(30)
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, "REPORTE " & cmb_General.SelectedValue & " CLAVES DE CAJEROS", 0, 0, frm_MENU.prg_Barra)

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_BuscarProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        Dim frm As New Frm_BuscarCliente
        Frm_BuscarCliente.Consulta = Frm_BuscarCliente.Query.Proveedores
        'tbx_Proveedor.Text = frm.Clave
        Frm_BuscarCliente.ShowDialog()
    End Sub


#End Region

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_BuscarClienteDia_Click(sender As Object, e As EventArgs)
        SegundosDesconexion = 0

        Frm_BuscarCliente.Consulta = Frm_BuscarCliente.Query.Clientes
        Frm_BuscarCliente.ShowDialog()

    End Sub



    Private Sub cmb_General_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_General.SelectedIndexChanged
        Select Case cmb_General.SelectedIndex
            Case 0

                dtpInicio.Enabled = False
                dtpFin.Enabled = False
                lsv_Catalogo.Items.Clear()
                Lbl_Registros.Text = "Registros: 0"

            Case 1
                dtpInicio.Enabled = True
                lsv_Catalogo.Items.Clear()
                Lbl_Registros.Text = "Registros: 0"
            Case 2
                dtpInicio.Enabled = True
                dtpFin.Enabled = True
                lsv_Catalogo.Items.Clear()
                Lbl_Registros.Text = "Registros: 0"
            Case Else

        End Select
    End Sub

    Private Sub MENORESQUE30ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENORESQUE30ToolStripMenuItem.Click
        If lsv_Catalogo.Items.Count = 0 Or cmb_General.SelectedIndex <> 0 Then Exit Sub
        Reporte_General("VERDE")
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub

    Private Sub MAYORESQUE30YMENORESQUE40ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAYORESQUE30YMENORESQUE40ToolStripMenuItem.Click

        If lsv_Catalogo.Items.Count = 0 Or cmb_General.SelectedIndex <> 0 Then Exit Sub
        Reporte_General("AMARILLO")
        FuncionesGlobales.fn_Menu_Progreso(0)

    End Sub

    Private Sub MAYORESDE40ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAYORESDE40ToolStripMenuItem.Click
        If lsv_Catalogo.Items.Count = 0 Or cmb_General.SelectedIndex <> 0 Then Exit Sub
        Reporte_General("ROJO")
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub
End Class