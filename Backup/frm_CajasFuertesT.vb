Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_CajasFuertesT

    Dim Status As String = "A"

    Private Sub frm_CajasFuertesT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0

        cmb_Tipo.LimpiarItems()
        cmb_Tipo.AgregarItem(1, "PROPIA")
        cmb_Tipo.AgregarItem(2, "NO PROPIA")

        'Aqui se llena la lista
        fn_CajasFuertesT_LlenarLista(lsv_Catalogo, Status)
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        Call Botones()
    End Sub

#Region "Sub"
    Sub Botones()
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Sub Clear()
        cmb_Tipo.Enabled = True
        cmb_Tipo.SelectedValue = "0"
        tbx_Clave.Clear()
        tbx_StockMinimo.Clear()
        tbx_Peso.Clear()
        tbx_Existencia.Text = 0
        tbx_AltoE.Clear()
        tbx_AnchoE.Clear()
        tbx_FondoE.Clear()
        tbx_AltoI.Clear()
        tbx_AnchoI.Clear()
        tbx_FondoI.Clear()
        tbx_Modelo.Clear()
    End Sub

    Private Function Validar() As Boolean
        If cmb_Tipo.SelectedValue = "0" Then
            MsgBox("Seleccione un tipo de Caja Fuerte.", MsgBoxStyle.Critical, Me.Text)
            cmb_Tipo.Focus()
            Return True
        End If

        If cmb_Tipo.SelectedValue = 1 Then
            'Validar ingreso de datos
            If tbx_Clave.Text = Nothing Then
                MsgBox("Ingrese una Clave válida.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Clave.Focus()
                Return True
            End If
            If tbx_StockMinimo.Text = Nothing Then
                MsgBox("Ingrese el Stock Mínimo.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_StockMinimo.Focus()
                Return True
            End If
            If tbx_Peso.Text = Nothing Then tbx_Peso.Text = 0
            If CDec(tbx_Peso.Text) = 0 Then
                MsgBox("Ingrese el Peso(kg).", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Peso.Focus()
                Return True
            End If
            If tbx_Modelo.Text = "" Then
                MsgBox("Debe indicar el Modelo.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Modelo.Focus()
                Return True
            End If

            'Valores Exteriores
            If tbx_AltoE.Text = Nothing Then
                MsgBox("Ingrese el Alto Exterior.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_AltoE.Focus()
                Return True
            End If
            If tbx_AnchoE.Text = Nothing Then
                MsgBox("Ingrese el Ancho Exterior.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_AnchoE.Focus()
                Return True
            End If
            If tbx_FondoE.Text = Nothing Then
                MsgBox("Ingrese el Fondo Exterior.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_FondoE.Focus()
                Return True
            End If

            'Valores Interiores
            If tbx_AltoI.Text = Nothing Then
                MsgBox("Ingrese el Alto Interior.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_AltoI.Focus()
                Return True
            End If
            If tbx_AnchoI.Text = Nothing Then
                MsgBox("Ingrese el Ancho Interior.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_AnchoI.Focus()
                Return True
            End If
            If tbx_FondoI.Text = Nothing Then
                MsgBox("Ingrese el Fondo Interior.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_FondoI.Focus()
                Return True
            End If

            'Validar que los valores sean mayores a cero.
            If CInt(tbx_AnchoE.Text) <= 0 Or CInt(tbx_AltoE.Text) <= 0 Or CInt(tbx_FondoE.Text) <= 0 _
                Or CInt(tbx_AnchoI.Text) <= 0 Or CInt(tbx_AltoI.Text) <= 0 Or CInt(tbx_FondoI.Text) <= 0 Then
                MsgBox("Todas las medidas deben ser Mayores que Cero.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return True
            End If

            'Validar que los valores exteriores sean mayores a las interiores.
            If (CInt(tbx_AnchoI.Text) >= CInt(tbx_AnchoE.Text)) Or (CInt(tbx_AltoI.Text) >= CInt(tbx_AltoE.Text)) Or (CInt(tbx_FondoI.Text) >= CInt(tbx_FondoE.Text)) Then
                MsgBox("Los valores de las dimensiones exteriores deben de ser mayor que las interiores.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return True
            End If
        ElseIf cmb_Tipo.SelectedValue = 2 Then
            If tbx_Clave.Text.Trim = "" Then
                MsgBox("Ingrese una Clave válida.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Clave.Focus()
                Return True
            End If

            If tbx_StockMinimo.Text.Trim = "" Then tbx_StockMinimo.Text = 0
            If tbx_Peso.Text.Trim = "" Then tbx_Peso.Text = 0
            If tbx_AltoI.Text.Trim = "" Then tbx_AltoI.Text = 0
            If tbx_AltoE.Text.Trim = "" Then tbx_AltoE.Text = 0
            If tbx_AnchoI.Text.Trim = "" Then tbx_AnchoI.Text = 0
            If tbx_AnchoE.Text.Trim = "" Then tbx_AnchoE.Text = 0
            If tbx_FondoI.Text.Trim = "" Then tbx_FondoI.Text = 0
            If tbx_FondoE.Text.Trim = "" Then tbx_FondoE.Text = 0
            If tbx_Modelo.Text.Trim = "" Then
                MsgBox("Ocurrió un error con el modelo de la Caja Fuerte.", MsgBoxStyle.Critical, Me.Text)
                Return True
            End If
        End If

        Return False

    End Function

#End Region

#Region "Botones"

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)

        Call Botones()
    End Sub

    Private Sub cbx_Activos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Activos.CheckedChanged
        If cbx_Activos.Checked Then
            Status = "A"
        Else
            Status = "T"
        End If
        fn_CajasFuertesT_LlenarLista(lsv_Catalogo, Status)
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        Call Botones()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        'Aqui se cierra la ventana
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Call Clear()
        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0

        Dim dr As DataRow = fn_CajasFuertesT_Read(lsv_Catalogo.SelectedItems(0).Tag)
        'Aqui se filtra cuando el objeto esta activo o inactivo
        If dr("Existencia") = 0 And dr("Status") = "A" Then
            fn_CajasFuertesT_Baja(dr("Id_CajaFuerteT"), "B")
        ElseIf dr("Status") = "B" Then
            fn_CajasFuertesT_Reingreso(dr("Id_CajaFuerteT"), "A")
        ElseIf dr("Existencia") > 0 And dr("Status") = "A" Then
            MsgBox("No se puede dar de Baja por que tiene Cajas Fuertes en Existencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        'Aqui se actualiza la lista
        lsv_Catalogo.Items.Clear()
        fn_CajasFuertesT_LlenarLista(lsv_Catalogo, Status)
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        Call Botones()
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems(0).SubItems(11).Text = "BAJA" Then
            MsgBox("No se puede modificar un registro con status en BAJA.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim dr As DataRow = fn_CajasFuertesT_Read(lsv_Catalogo.SelectedItems(0).Tag)

        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se establece el texto del objeto seleccionado
        tbx_Clave.Text = dr("Clave_CajaFuerteT")
        tbx_StockMinimo.Text = dr("Stock_Minimo")
        tbx_Peso.Text = dr("Peso")
        tbx_Existencia.Text = dr("Existencia")
        tbx_AltoE.Text = dr("AltoE")
        tbx_AnchoE.Text = dr("AnchoE")
        tbx_FondoE.Text = dr("FondoE")
        tbx_AltoI.Text = dr("AltoI")
        tbx_AnchoI.Text = dr("AnchoI")
        tbx_FondoI.Text = dr("FondoI")
        cmb_Tipo.SelectedValue = dr("Tipo")
        cmb_Tipo.Enabled = False
        tbx_Modelo.Text = dr("Modelo")
        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        'Validadcion
        If Validar() = True Then Exit Sub

        'En caso de que todo sea valido
        If Tab_Nuevo.Text = "Nuevo" Then
            'Validar que la clave no este repetida
            Dim DT As DataTable = fn_CajasFuertesT_Read()
            If DT IsNot Nothing Then
                For Each dr As DataRow In DT.Rows
                    If dr("Clave_CajaFuerteT") = tbx_Clave.Text Then
                        MsgBox("La Clave: " & tbx_Clave.Text & " ya existe, por favor ingrese otra clave.", MsgBoxStyle.Critical, frm_MENU.Text)
                        tbx_Clave.Focus()
                        Exit Sub
                    End If
                Next
            End If


            'Si se esta Insertando
            If fn_CajasFuertesT_Nuevo(tbx_Clave.Text, CInt(tbx_AltoE.Text), CInt(tbx_AnchoE.Text), CInt(tbx_FondoE.Text), _
                                      CInt(tbx_AltoI.Text), CInt(tbx_AnchoI.Text), CInt(tbx_FondoI.Text), _
                                      CInt(tbx_StockMinimo.Text), CDec(tbx_Peso.Text), tbx_Modelo.Text.Trim, cmb_Tipo.SelectedValue) Then

                'En caso de que se haya hecho la transaccion
                FuncionesGlobales.fn_Menu_Progreso(30)
                Call Clear()
                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"
                FuncionesGlobales.fn_Menu_Progreso(40)
                cmb_Tipo.Focus()
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            'Si se esta actualizando
            If fn_CajasFuertesT_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Clave.Text, CInt(tbx_AltoE.Text), CInt(tbx_AnchoE.Text), CInt(tbx_FondoE.Text), CInt(tbx_AltoI.Text), _
                                           CInt(tbx_AnchoI.Text), CInt(tbx_FondoI.Text), CInt(tbx_StockMinimo.Text), CInt(tbx_Existencia.Text), CDec(tbx_Peso.Text), tbx_Modelo.Text.Trim) Then
                'En caso de que se haya hecho la transaccion
                FuncionesGlobales.fn_Menu_Progreso(30)
                Call Clear()
                Tab_Nuevo.Text = "Nuevo"
                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado
                FuncionesGlobales.fn_Menu_Progreso(40)

            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        End If

        'Aqui se limpia el listview
        lsv_Catalogo.Items.Clear()
        FuncionesGlobales.fn_Menu_Progreso(50)
        'Aqui se Actualiza el listview
        fn_CajasFuertesT_LlenarLista(lsv_Catalogo, Status)
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
        FuncionesGlobales.fn_Menu_Progreso(100)
        'Aqui se limpia el contador de progreso
        FuncionesGlobales.fn_Menu_Progreso(0)

        Call Botones()
    End Sub

#End Region

#Region "ListView"
    Private Sub lsv_Catalogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.Click
        Call Botones()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        Call Botones()
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub
#End Region

    Private Sub cmb_Tipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Tipo.SelectedValue = 2 Then
            If Tab_Nuevo.Text.ToUpper = "NUEVO" Then
                Dim Cantidad As Integer = fn_CajasFuertesT_CuentaxTipo(2, "T")
                If Cantidad < 0 Then
                    MsgBox("Ocurrió un error al contabilizar las cajas fuertes no propias.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                Else
                    tbx_Modelo.Text = "NO PROPIA " & (Cantidad + 1)
                End If
            End If
            tbx_Modelo.ReadOnly = True
        Else
            tbx_Modelo.Text = ""
            tbx_Modelo.ReadOnly = False
        End If
    End Sub
End Class