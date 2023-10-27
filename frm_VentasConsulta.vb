Imports Modulo_Ventas.Cn_Clientes

Public Class frm_VentasConsulta

    Private Sub frm_ConsultaDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        cmb_Status.AgregarItem("SO", "SOLICITADA")
        cmb_Status.AgregarItem("CA", "CANCELADA")
        cmb_Status.AgregarItem("VA", "VALIDADA")
        cmb_Status.AgregarItem("EB", "ENVIADO A BOVEDA")
        cmb_Status.AgregarItem("RB", "RECIBIDO EN BOVEDA")
        cmb_Status.AgregarItem("DB", "DEVUELTO POR BOVEDA")
        cmb_Status.AgregarItem("AM", "ASIGNADO A DOTADOR")
        cmb_Status.AgregarItem("VM", "ACEPTADO POR DOTADOR")
        cmb_Status.AgregarItem("EM", "ENTREGADO POR MENSAJERO")
        cmb_Status.AgregarItem("ER", "ENTREGADO POR RUTA")
        cmb_Status.AgregarItem("EN", "ENTREGADO")
        cmb_Status.AgregarItem("RU", "EN RUTA")

        lsv_Datos.Columns.Clear()
        lsv_Datos.Columns.Add("Remision")
        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Cliente")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Envases")
        lsv_Datos.Columns.Add("Envases SN")
        lsv_Datos.Columns.Add("Status")
        lsv_Datos.Columns.Add("ModoCaptura")
        lsv_Datos.Columns.Add("Usuario Captura")
        lsv_Datos.Columns.Add("Observaciones")

        lsv_Detalle.Columns.Clear()
        lsv_Detalle.Columns.Add("Clave")
        lsv_Detalle.Columns.Add("Descripcion")
        lsv_Detalle.Columns.Add("Cantidad")

        lsv_Folios.Columns.Add("Material")
        lsv_Folios.Columns.Add("Inicial")
        lsv_Folios.Columns.Add("Final")
        lsv_Folios.Columns.Add("Cantidad")
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Function Validar() As Boolean
        If cmb_Status.SelectedValue = "0" And Not cbx_Status.Checked Then
            MsgBox("Debe seleccionar un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Return False
        End If

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas es incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        lsv_Detalle.Items.Clear()
        lsv_Folios.Items.Clear()

        lbl_Total.Text = "Total Ventas: 0"
        btn_Exportar.Enabled = False

        If Validar() Then
            If Not fn_ConsultaVentas(lsv_Datos, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Status.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar Consultar las Ventas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            lbl_Total.Text = "Total Ventas: " & lsv_Datos.Items.Count.ToString
            btn_Exportar.Enabled = lsv_Datos.Items.Count > 0

            'Colorear las canceladas
            For Each Elemento As ListViewItem In lsv_Datos.Items
                If Elemento.SubItems(6).Text = "CANCELADA" Then Elemento.ForeColor = Color.Red
            Next
        End If
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = 13 Then dtp_Hasta.Focus()
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

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        dtp_Hasta.MinDate = dtp_Desde.Value

        lbl_Total.Text = "Total Ventas: 0"
        lsv_Datos.Items.Clear()
        lsv_Detalle.Items.Clear()
        lsv_Folios.Items.Clear()
    End Sub

    Private Sub cbx_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Status.CheckedChanged
        cmb_Status.Enabled = Not cbx_Status.Checked
        If cbx_Status.Checked Then
            cmb_Status.SelectedValue = "0"
        End If

        lbl_Total.Text = "Total Ventas: 0"
        lsv_Datos.Items.Clear()
        lsv_Detalle.Items.Clear()
        lsv_Folios.Items.Clear()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Datos.SelectedItems.Count > 0 Then
            If Not fn_ConsultaVentas_Detalle(lsv_Detalle, lsv_Datos.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar el Detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            'Mostrar los Folios de Remisiones vendidos
            If Not fn_ConsultaVentas_DetalleF(lsv_Folios, lsv_Datos.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Folios de Remisiones vendidas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            lsv_Detalle.Items.Clear()
            lsv_Folios.Items.Clear()
        End If
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        SegundosDesconexion = 0

        lbl_Total.Text = "Total Ventas: 0"
        lsv_Datos.Items.Clear()
        lsv_Detalle.Items.Clear()
        lsv_Folios.Items.Clear()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        lbl_Total.Text = "Total Ventas: 0"
        lsv_Datos.Items.Clear()
        lsv_Detalle.Items.Clear()
        lsv_Folios.Items.Clear()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If lsv_Datos.Items.Count > 0 Then
            FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, "CONSULTA DE VENTA DE MATERIAL", 0, 0, frm_MENU.prg_Barra)
            Cn_Login.fn_Log_Create("EXPORTAR REPORTE CONSULTA DE VENTAS DE MATERIAL.  FECHAS: " & dtp_Desde.Value.ToShortDateString & " - " & dtp_Hasta.Value.ToShortDateString & " / STATUS: " & cmb_Status.Text)
        End If
    End Sub

    Private Sub btn_ExportarFormato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'FuncionesGlobales.fn_Exportar_Excel(dtp_Desde.Value, dtp_Hasta.Value, cmb_Status.SelectedValue, 4)




    End Sub

    Private Sub btn_ExportarFormato2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'FuncionesGlobales.fn_ConsultaVentas_Excel2(dtp_Desde.Value, dtp_Hasta.Value, cmb_Status.SelectedValue, 4)
    End Sub


End Class