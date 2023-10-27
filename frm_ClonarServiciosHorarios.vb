Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ClonarServiciosHorarios
    Dim dt_Clientes As DataTable = Nothing
    Dim DesmarcarCheckBox As Boolean = False

    Private Sub frm_ClonarServiciosHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_ClientePadre.Actualizar()
        dt_Clientes = cmb_ClientePadre.DataSource

        tab_ClonarServiciosHorarios.TabPages.Remove(tab_ServiciosOtros)
        tab_ClonarServiciosHorarios.TabPages.Remove(tab_ServiciosHorarios)

        cmb_TipoServicio.AgregarItem("1", "SERVICIOS OTROS")
        cmb_TipoServicio.AgregarItem("2", "SERVICIOS TV")

        lsv_ServiciosOtros.Columns.Add("FechaInicio")
        lsv_ServiciosOtros.Columns.Add("ClaveLinea")
        lsv_ServiciosOtros.Columns.Add("ClavePrecio")
        lsv_ServiciosOtros.Columns.Add("Precio")
        lsv_ServiciosOtros.Columns.Add("Descripcion")

        lsv_ServiciosTV.Columns.Add("FechaInicio")
        lsv_ServiciosTV.Columns.Add("ClaveLinea")
        lsv_ServiciosTV.Columns.Add("ClavePrecio")
        lsv_ServiciosTV.Columns.Add("Precio")
        lsv_ServiciosTV.Columns.Add("Descripcion")
        lsv_ServiciosTV.Columns.Add("ClaveCR")
        lsv_ServiciosTV.Columns.Add("PrecioCR")
        lsv_ServiciosTV.Columns.Add("ClaveKM")
        lsv_ServiciosTV.Columns.Add("PrecioKM")
        lsv_ServiciosTV.Columns.Add("CantidadKM")

        lsv_HorariosActivos.Columns.Add("Finicio")
        lsv_HorariosActivos.Columns.Add("TipoFrecuencia")
        lsv_HorariosActivos.Columns.Add("Dia")
        lsv_HorariosActivos.Columns.Add("Origen")
        lsv_HorariosActivos.Columns.Add("Recoleccion")
        lsv_HorariosActivos.Columns.Add("Destino")
        lsv_HorariosActivos.Columns.Add("Entrega")
        lsv_HorariosActivos.Columns.Add("RutaRecolecta")
        lsv_HorariosActivos.Columns.Add("Status")

        lsv_Subclientes.Columns.Add("Clave")
        lsv_Subclientes.Columns.Add("NombreComercial")

    End Sub

    Private Sub ServiciosOtros_Llenar(ByVal Id_Cliente As Integer)
        lsv_ServiciosOtros.Items.Clear()
        lbl_ServiciosOtros.Text = "Registros: 0"

        If Not fn_Clientes_Servicios_LlenarLista(Id_Cliente, lsv_ServiciosOtros, "A", "N") Then
            MsgBox("Ocurrio un error al tratar cargar la lista de Servicios Otros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_ServiciosOtros.Text = "Registros: " & lsv_ServiciosOtros.Items.Count
    End Sub

    Private Sub ServiciosTV_Llenar(ByVal Id_Cliente As Integer)
        lsv_ServiciosTV.Items.Clear()
        lbl_ServiciosTV.Text = "Registros: 0"

        If Not fn_Clientes_Servicios_LlenarLista(Id_Cliente, lsv_ServiciosTV, "A", "S") Then
            MsgBox("Ocurrio un error al tratar cargar la lista de Servicios TV.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_ServiciosTV.Text = "Registros: " & lsv_ServiciosTV.Items.Count
    End Sub

    Private Sub LimpiarControles()
        lsv_ServiciosOtros.Items.Clear()
        lbl_ServiciosOtros.Text = "Registros: 0"
        lsv_ServiciosTV.Items.Clear()
        lbl_ServiciosTV.Text = "Registros: 0"
        lsv_HorariosActivos.Items.Clear()
        lbl_Horarios.Text = "Registros: 0"
        lsv_Subclientes.Items.Clear()
        lbl_Subclientes.Text = "Registros: 0"

        chk_ServiciosOtros.Checked = False
        chk_HorariosServicios.Checked = False
        chk_Subclientes.Checked = False
    End Sub

    Private Sub cmb_ClientePadre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClientePadre.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
        'tree.Nodes.Clear()
        If cmb_ClientePadre Is Nothing Then Exit Sub
        If cmb_ClientePadre.SelectedValue > 0 Then

            Call ServiciosOtros_Llenar(cmb_ClientePadre.SelectedValue)
            Call ServiciosTV_Llenar(cmb_ClientePadre.SelectedValue)

            Dim Id_padre As Integer = dt_Clientes.Rows(cmb_ClientePadre.SelectedIndex)("IDP")
            If Id_padre = 0 Then Id_padre = cmb_ClientePadre.SelectedValue

            ' muestra los subclientes del padre, aunque selecciones un hijo
            Call fn_Clientes_LlenarListaHijos(lsv_Subclientes, Id_padre)
            lbl_Subclientes.Text = "Registros: " & lsv_Subclientes.Items.Count

        End If
    End Sub

    Private Sub chk_ServiciosOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ServiciosOtros.CheckedChanged
        SegundosDesconexion = 0
        If DesmarcarCheckBox = True Then
            DesmarcarCheckBox = False
            Exit Sub
        End If
        If chk_ServiciosOtros.Checked Then
            For Each elemento As ListViewItem In lsv_ServiciosOtros.Items
                elemento.Checked = True
            Next
        Else
            For Each elemento As ListViewItem In lsv_ServiciosOtros.CheckedItems
                elemento.Checked = False
            Next
        End If

    End Sub

    Private Sub chk_HorariosServicios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_HorariosServicios.CheckedChanged
        SegundosDesconexion = 0

        If DesmarcarCheckBox = True Then
            DesmarcarCheckBox = False
            Exit Sub
        End If

        If chk_HorariosServicios.Checked Then
            For Each elemento As ListViewItem In lsv_HorariosActivos.Items
                elemento.Checked = True
            Next
        Else
            For Each elemento As ListViewItem In lsv_HorariosActivos.CheckedItems
                elemento.Checked = False
            Next
        End If
    End Sub

    Private Sub lsv_ServiciosTV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ServiciosTV.SelectedIndexChanged
        lsv_HorariosActivos.Items.Clear()
        lbl_Horarios.Text = "Registros: 0"

        If lsv_ServiciosTV.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarListaClonar(lsv_ServiciosTV.SelectedItems(0).Tag, lsv_HorariosActivos)
            lbl_Horarios.Text = "Registros: " & lsv_HorariosActivos.Items.Count
        End If
    End Sub

    Private Sub btn_ClonarServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClonarServicios.Click
        SegundosDesconexion = 0
        If Clonar_ServiciosOtros() Then cmb_ClientePadre.SelectedValue = 0
    End Sub

    Private Function ValidarControles() As Boolean
        If cmb_ClientePadre.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente de la lista desplegable.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        If cmb_TipoServicio.SelectedValue = "1" Then
            If lsv_ServiciosOtros.Items.Count = 0 Then
                MsgBox("No existen Servicios agregados al Cliente seleccionado.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                tab_ClonarServiciosHorarios.SelectedTab = tab_ServiciosOtros
                Exit Function
            End If

            If lsv_ServiciosOtros.CheckedItems.Count = 0 Then
                MsgBox("Marque uno o varios Servicios que desea Clonar.", MsgBoxStyle.Critical, frm_MENU.Text)
                tab_ClonarServiciosHorarios.SelectedTab = tab_ServiciosOtros
                Exit Function
            End If

        ElseIf cmb_TipoServicio.SelectedValue = "2" Then
            If lsv_ServiciosTV.Items.Count = 0 Then
                MsgBox("No existen Servicios agregados al Cliente seleccionado.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                tab_ClonarServiciosHorarios.SelectedTab = tab_ServiciosHorarios
                Exit Function
            End If

            If lsv_ServiciosTV.SelectedItems.Count = 0 Then
                MsgBox("Seleccione un Servicio de TV para ver los Horarios agregados.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                tab_ClonarServiciosHorarios.SelectedTab = tab_ServiciosHorarios
                Exit Function
            End If

            If lsv_HorariosActivos.Items.Count = 0 Then
                MsgBox("No existen Horarios activos a Clonar.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                tab_ClonarServiciosHorarios.SelectedTab = tab_ServiciosHorarios
                Exit Function
            End If

            If lsv_HorariosActivos.CheckedItems.Count = 0 Then
                MsgBox("Seleccione uno o varios Horarios a Clonar.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                tab_ClonarServiciosHorarios.SelectedTab = tab_ServiciosHorarios
                Exit Function
            End If
        End If

        If dtp_FechaInicioServicio.Value.Date < Now.Date Then
            MsgBox("La fecha debe ser mayor o igual al dia de hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_ClonarServiciosHorarios.SelectedTab = tab_Subclientes
            dtp_FechaInicioServicio.Focus()
            Exit Function
        End If

        If lsv_Subclientes.Items.Count = 0 Then
            MsgBox("No existen Subclientes en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_ClonarServiciosHorarios.SelectedTab = tab_Subclientes
            Exit Function
        End If

        If lsv_Subclientes.CheckedItems.Count = 0 Then
            MsgBox("Marque uno o varios Subclientes de la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_ClonarServiciosHorarios.SelectedTab = tab_Subclientes
            Exit Function
        End If

        Return True
    End Function

    Private Function Clonar_ServiciosOtros() As Boolean
        If Not ValidarControles() Then Exit Function

        For Each subcliente As ListViewItem In lsv_Subclientes.CheckedItems
            'Si algún Cliente ya tiene Servicios advertir si desea continuar.

            Dim lsv_ServiciosTemp As New cp_Listview
            If Not fn_Clientes_Servicios_LlenarLista(subcliente.Tag, lsv_ServiciosTemp, "A", "N") Then
                MsgBox("Ocurrió un error al tratar de cargar la lista de Servicios Otros.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Function
            End If
            'si por lomenos 1 cliente ya tiene servicios y si desea continuar salirse..
            If lsv_ServiciosTemp.Items.Count > 0 Then
                If MsgBox("Algunos clientes ya tienen Servicios, si continúa se duplicarán los Servicios, ¿Desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Exit Function
                Else
                    'si dio clic Aceptar entonces
                    Dim frm As New frm_FirmaElectronica
                    frm.Bloquear = True
                    frm.PedirObservaciones = False
                    frm.ShowDialog()

                    If frm.Firma = True Then
                        GoTo SalirForSubCliente
                    Else
                        Exit Function
                    End If
                    '-----------------
                End If
            End If
        Next

SalirForSubCliente:

        If Not fn_Servicios_Clonar(dtp_FechaInicioServicio.Value.Date, lsv_Subclientes, lsv_ServiciosOtros) Then
            MsgBox("No se pudieron Clonar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        Else
            MsgBox("Se Clonaron " & lsv_ServiciosOtros.CheckedItems.Count & " Servicios correctamente." & " a " & lsv_Subclientes.CheckedItems.Count & " Clientes", MsgBoxStyle.Information, frm_MENU.Text)
        End If
        Return True

    End Function

    Private Function Clonar_ServicioHorarios() As Boolean
        If Not ValidarControles() Then Exit Function

        Dim lsv_ServiciosTVTemp As New cp_Listview
        Dim lsv_HorariosTemp As New cp_Listview

        'For que verifica si ya tiene Horarios algun Cliente
        For Each subcliente As ListViewItem In lsv_Subclientes.CheckedItems

            'Traemos todos los servicios del 1er cliente
            If Not fn_Clientes_Servicios_LlenarLista(subcliente.Tag, lsv_ServiciosTVTemp, "A", "S") Then
                MsgBox("Ocurrió un error al tratar de cargar la lista de Servicios TV.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Function
            End If
            For Each servicioTV As ListViewItem In lsv_ServiciosTVTemp.Items
                'Traemos Horarios Activos por cada ID_CS del Cliente
                Call fn_Horarios_LlenarListaClonar(servicioTV.Tag, lsv_HorariosTemp)
                If lsv_HorariosTemp.Items.Count > 0 Then
                    If MsgBox("Algunos clientes ya tienen Horarios activos, si continúa se duplicará el Servicio y sus Horarios, ¿Desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                        Exit Function
                    Else
                        'si dio clic Aceptar entonces
                        Dim frm As New frm_FirmaElectronica
                        frm.Bloquear = True
                        frm.PedirObservaciones = False
                        frm.ShowDialog()

                        If frm.Firma = True Then
                            GoTo SalirForSubCliente
                        Else
                            Exit Function
                        End If
                        '-----------------
                    End If
                End If
            Next
        Next subcliente

SalirForSubCliente:

        If Not fn_Horarios_Clonar(dtp_FechaInicioServicio.Value.Date, lsv_ServiciosTV, lsv_Subclientes, lsv_HorariosActivos) Then
            MsgBox("Ocurrió un error al Clonar el Servicio y sus Horarios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        Else
            MsgBox("Se Clonaron " & lsv_HorariosActivos.CheckedItems.Count & " Horarios correctamente." & " a " & lsv_Subclientes.CheckedItems.Count & " Clientes", MsgBoxStyle.Information, frm_MENU.Text)
        End If
        Return True
    End Function

    Private Sub btn_ClonarServiciosHorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClonarServiciosHorarios.Click
        SegundosDesconexion = 0
        If Clonar_ServicioHorarios() Then lsv_ServiciosTV.SelectedItems.Clear()
    End Sub

    Private Sub chk_Subclientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Subclientes.CheckedChanged
        SegundosDesconexion = 0
        If DesmarcarCheckBox = True Then
            DesmarcarCheckBox = False
            Exit Sub
        End If

        If chk_Subclientes.Checked Then
            For Each elemento As ListViewItem In lsv_Subclientes.Items
                If tbx_SeleccioneCP.Text.Trim = elemento.Text Then
                    elemento.Checked = False
                Else
                    elemento.Checked = True
                End If
            Next
        Else
            For Each elemento As ListViewItem In lsv_Subclientes.CheckedItems
                elemento.Checked = False
            Next
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub cmb_TipoServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoServicio.SelectedIndexChanged
        SegundosDesconexion = 0
        tab_ClonarServiciosHorarios.TabPages.Remove(tab_ServiciosOtros)
        tab_ClonarServiciosHorarios.TabPages.Remove(tab_ServiciosHorarios)
        btn_ClonarServicios.Enabled = False
        btn_ClonarServiciosHorarios.Enabled = False

        Select Case cmb_TipoServicio.SelectedValue
            Case 1
                tab_ClonarServiciosHorarios.TabPages.Insert(0, tab_ServiciosOtros)
                btn_ClonarServicios.Enabled = True
                tab_ClonarServiciosHorarios.SelectedIndex = 0
            Case 2
                tab_ClonarServiciosHorarios.TabPages.Insert(0, tab_ServiciosHorarios)
                btn_ClonarServiciosHorarios.Enabled = True
                tab_ClonarServiciosHorarios.SelectedIndex = 0
        End Select
    End Sub

    Private Sub lsv_Subclientes_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Subclientes.ItemChecked
        If tbx_SeleccioneCP.Text.Trim = e.Item.Text Then
            e.Item.Checked = False
        End If

        If e.Item.Checked = False Then
            DesmarcarCheckBox = True
            chk_Subclientes.Checked = False
            DesmarcarCheckBox = False
        End If
    End Sub

    Private Sub lsv_ServiciosOtros_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_ServiciosOtros.ItemChecked
        If e.Item.Checked = False Then
            DesmarcarCheckBox = True
            chk_ServiciosOtros.Checked = False
            DesmarcarCheckBox = False
        End If
    End Sub

    Private Sub lsv_HorariosActivos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_HorariosActivos.ItemChecked
        If e.Item.Checked = False Then
            DesmarcarCheckBox = True
            chk_HorariosServicios.Checked = False
            DesmarcarCheckBox = False
        End If
    End Sub
End Class