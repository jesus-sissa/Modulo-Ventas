Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_CatalogoCuentas

    Dim Pais As Integer
    Dim Estado As Integer
    Dim Ciudad As Integer

    Private Tbl_Referencias As DataTable

    ''' <summary>
    ''' Aqui se crea la tabla de referencias
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreaTbl_Referencias() As DataTable
        Dim Tbl As New DataTable
        Tbl.Columns.Add(New DataColumn("Id_Referencia"))
        Tbl.Columns.Add(New DataColumn("Id_Cuenta"))
        Tbl.Columns.Add(New DataColumn("Referencia"))
        Tbl.Columns.Add(New DataColumn("Status"))
        Tbl.Columns.Add(New DataColumn("Modificado"))

        lsv_2_Referencia.Columns.Add("Referencia")
        lsv_2_Referencia.Columns.Add("Status")

        cmb_Status.AgregarItem("B", "INACTIVO")
        cmb_Status.AgregarItem("A", "ACTIVO")
        cmb_Status.AgregarItem("T", "TODOS")


        Return Tbl
    End Function

    Private Sub frm_CatalogoCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Referenciada.AgregarItem("S", "Sí")
        cmb_Referenciada.AgregarItem("N", "No")
        cmb_ReferenciaFija.AgregarItem("S", "Sí")
        cmb_ReferenciaFija.AgregarItem("N", "No")

        cmb_Moneda.Actualizar()
        cmb_Ciudad.AgregaParametro("@Id_Estado", -1, 1)
        cmb_Ciudad.Actualizar()
        cmb_Estado.AgregaParametro("@Id_Pais", -1, 1)
        cmb_Estado.Actualizar()
        cmb_Pais.Actualizar()

        cmb_Banco.Actualizar()
        cmb_Banco2.Actualizar()

        Tbl_Referencias = CreaTbl_Referencias()

        'Sacar el Pais, Estado y Ciudad de la Sucursal para ponerlos como sugerencia
        'cmb_2_Moneda.SelectedValue = MonedaId
        Dim dt As DataTable = fn_Sucursales_Read(SucursalId)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                'cmb_2_Pais.SelectedValue = dt.Rows(0)("Id_Pais")
                'cmb_2_Estado.SelectedValue = dt.Rows(0)("Id_Estado")
                'cmb_2_Ciudad.SelectedValue = dt.Rows(0)("Id_Ciudad")
                Pais = dt.Rows(0)("Id_Pais")
                Estado = dt.Rows(0)("Id_Estado")
                Ciudad = dt.Rows(0)("Id_Ciudad")
            End If
        End If

        cmb_Moneda.SelectedValue = MonedaId
        cmb_Pais.SelectedValue = Pais
        cmb_Estado.SelectedValue = Estado
        cmb_Ciudad.SelectedValue = Ciudad
    End Sub

    Private Sub cmb_2_Pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pais.SelectedIndexChanged
        If cmb_Pais.Items.Count = 0 Then Exit Sub
        cmb_Estado.ActualizaValorParametro("@Id_Pais", cmb_Pais.SelectedValue)
        cmb_Estado.Actualizar()
    End Sub

    Private Sub cmb_2_Estado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Estado.SelectedIndexChanged
        If cmb_Estado.Items.Count = 0 Then Exit Sub
        cmb_Ciudad.ActualizaValorParametro("@Id_Estado", cmb_Estado.SelectedValue)
        cmb_Ciudad.Actualizar()
    End Sub

    Private Sub Btn_2_AgregarReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_2_AgregarReferencia.Click
        SegundosDesconexion = 0

        If tbx_Referencia.Text.Trim = "" Then
            MsgBox("Indique la Referencia.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            tbx_Referencia.Focus()
        End If

        Btn_2_AgregarReferencia.Tag = "" 'Esta linea se eliminará cuando se implemente el modo para modificar Referencias
        If Btn_2_AgregarReferencia.Tag.trim = "" Then
            'revisar si ya existe la referencia en la lista
            For Each Elemento As ListViewItem In lsv_2_Referencia.Items
                If Elemento.Text = tbx_Referencia.Text Then
                    Elemento.Selected = True
                    MsgBox("La Referencia indicada ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Referencia.SelectAll()
                    tbx_Referencia.Focus()
                    Exit Sub
                End If
            Next

            Dim Row As DataRow = Tbl_Referencias.NewRow()
            Row("Id_Referencia") = Tbl_Referencias.Rows.Count + 1
            If lsv_Catalogo.SelectedItems.Count > 0 Then
                Row("Id_Cuenta") = lsv_Catalogo.SelectedItems(0).Tag
            Else
                Row("Id_Cuenta") = 0
            End If

            Row("Referencia") = tbx_Referencia.Text
            Row("Status") = "ACTIVO"
            If Tab_Nuevo.Tag > 0 Then Row("Modificado") = 2 Else Row("Modificado") = 1

            Tbl_Referencias.Rows.Add(Row)
        Else
            If lsv_2_Referencia.SelectedItems.Count > 0 Then
                For Each Row As DataRow In Tbl_Referencias.Rows

                    If Row("Id_Referencia") = lsv_2_Referencia.SelectedItems(0).Tag Then
                        Row("Referencia") = tbx_Referencia.Text
                        Row("Modificado") = 1
                        Exit For
                    End If
                Next
            End If
        End If

        Btn_2_AgregarReferencia.Text = "Agregar"
        Btn_2_AgregarReferencia.Tag = ""

        ActualizarReferencias()

        tbx_Referencia.Clear()
        tbx_Referencia.Focus()

    End Sub

    ''' <summary>
    ''' Actualiza los valores de la lista lsv_2_Referencia de acuerdo a la tabla Tbl_Referencias
    ''' </summary>
    Private Sub ActualizarReferencias()

        Dim Item As ListViewItem
        lsv_2_Referencia.Columns.Clear()
        lsv_2_Referencia.Items.Clear()
        lsv_2_Referencia.Columns.Add("Referencia")
        lsv_2_Referencia.Columns.Add("Status")
        lsv_2_Referencia.Columns.Add("Modificado", 0)
        For Each element As DataRow In Tbl_Referencias.Rows
            If lsv_Catalogo.SelectedItems.Count > 0 Then
                If lsv_Catalogo.SelectedItems(0).Tag = element("Id_Cuenta") Then
                    Item = lsv_2_Referencia.Items.Add(element("Referencia").ToString)
                    Item.Tag = element("Id_Referencia")
                    'Item.SubItems.Add(IIf(element("Status") Is DBNull.Value, "", element("Status")))
                    Item.SubItems.Add(element("Status"))
                    Item.SubItems.Add(element("Modificado"))
                End If
            Else
                If 0 = element("Id_Cuenta") Then
                    Item = lsv_2_Referencia.Items.Add(element("Referencia").ToString)
                    Item.Tag = element("Id_Referencia")
                    Item.SubItems.Add(element("Status"))
                    Item.SubItems.Add(element("Modificado"))
                End If
            End If
        Next
        fn_Columna(lsv_2_Referencia, 30, 30, 0, 0, 0, 0, 0, 0, 0, 0)
    End Sub

    Private Sub LimpiarCasillas()
        SegundosDesconexion = 0
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False

        cmb_Banco2.SelectedValue = "0"
        cmb_Referenciada.SelectedValue = "0"
        cmb_ReferenciaFija.SelectedValue = "0"
        cmb_Moneda.Tag = ""
        tbx_Cuenta.Clear()
        tbx_Cuenta.Tag = ""
        lbl_Moneda.Tag = ""
        Tbl_Referencias.Rows.Clear()
        Call ActualizarReferencias()

        Tab_Nuevo.Text = "Nuevo"
        Tab_Nuevo.Tag = 0

        If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cbx_Activas.Checked) Then
            MsgBox("Ocurro un error al buscar las cuentas del banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Function Validar() As Boolean
        If cmb_Banco2.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Referenciada.SelectedValue = "0" Then
            MsgBox("Debe Indicar si la Cuenta es Referenciada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_ReferenciaFija.SelectedValue = "0" And cmb_ReferenciaFija.Enabled Then
            MsgBox("Debe indicar si la Referencia es Fija.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Moneda.SelectedValue = "0" OrElse cmb_Moneda.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If tbx_Cuenta.Text.Trim = "" Then
            MsgBox("Debe escribir un Numero de Cuenta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Pais.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Pais.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Estado.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Estado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Ciudad.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If lsv_2_Referencia.Items.Count = 0 And cmb_ReferenciaFija.SelectedValue = "S" And cmb_ReferenciaFija.Enabled Then
            MsgBox("Debe capturar al menos una Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        'Verificar que la cuenta y la moneda no existan
        If Tab_Nuevo.Text = "Modificar" Then
            If cmb_Banco2.SelectedValue <> cmb_Banco2.Tag AndAlso _
            cmb_Moneda.SelectedValue <> lbl_Moneda.Tag AndAlso _
            tbx_Cuenta.Text.Trim <> tbx_Cuenta.Tag Then

                Dim dt_ProCuentas As DataTable = fn_ProCuentas_Existe(cmb_Banco2.SelectedValue, cmb_Moneda.SelectedValue, tbx_Cuenta.Text)
                If dt_ProCuentas IsNot Nothing AndAlso dt_ProCuentas.Rows.Count > 0 Then
                    MsgBox("Cuenta, moneda y caja bancaria ya existen. ", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
            End If
        Else
            Dim dt_ProCuentas As DataTable = fn_ProCuentas_Existe(cmb_Banco2.SelectedValue, cmb_Moneda.SelectedValue, tbx_Cuenta.Text)
            If dt_ProCuentas IsNot Nothing AndAlso dt_ProCuentas.Rows.Count > 0 Then
                MsgBox("Cuenta, moneda y caja bancaria ya existen. ", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        End If

        'verificar si será cuenta default
        If chk_cuentaDefault.Checked Then
            Dim dt_cuentasDefault As DataTable = fn_CuentasDefault_Get(cmb_Banco2.SelectedValue, cmb_Moneda.SelectedValue)
            If dt_cuentasDefault IsNot Nothing AndAlso dt_cuentasDefault.Rows.Count > 0 Then
                If (MsgBox("La caja bancaria ya tiene " & dt_cuentasDefault.Rows.Count & " cuenta(s) Default  ¿Desea agregar otra? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MensajeAlerta.Text)) = MsgBoxResult.No Then
                    chk_cuentaDefault.Checked = False
                End If
            End If
        End If

        Return True
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Not Validar() Then Exit Sub

        If Tab_Nuevo.Text.Trim = "Modificar" Then
            If Not fn_Cuentas_Modificar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Cuenta.Text.Trim, _
                                        cmb_Moneda.SelectedValue, cmb_Ciudad.SelectedValue, 1, _
                                        cmb_Referenciada.SelectedValue, cmb_ReferenciaFija.SelectedValue, _
                                        cmb_Banco2.SelectedValue, Tbl_Referencias, cmb_Banco2.Text, _
                                        cmb_Moneda.Text, cmb_Moneda.Tag, _
                                         tbx_Cuenta.Tag, chk_cuentaDefault.Checked) Then
                MsgBox("Ha ocurrido un error al intentar guardar la Cuenta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                MsgBox("Datos Modificados correctamente", MsgBoxStyle.Information, frm_MENU.Text)
                Call LimpiarCasillas()
            End If
        Else
            If Not fn_Cuentas_Guardar(tbx_Cuenta.Text.Trim, cmb_Moneda.SelectedValue, _
                                      cmb_Ciudad.SelectedValue, 1, cmb_Referenciada.SelectedValue, _
                                      cmb_ReferenciaFija.SelectedValue, "A", _
                                      cmb_Banco2.SelectedValue, Tbl_Referencias, _
                                      cmb_Banco2.Text, cmb_Moneda.Text, chk_cuentaDefault.Checked) Then
                MsgBox("Ha ocurrido un error al intentar guardar la Cuenta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                MsgBox("Datos guardados correctamente", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Cuenta.Clear()
                tbx_Cuenta.Focus()
                Tbl_Referencias.Rows.Clear()
                lsv_2_Referencia.Items.Clear()
                Btn_Baja.Enabled = False
                BTN_Modificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Call LimpiarCasillas()
        cmb_Moneda.SelectedValue = MonedaId
        cmb_Pais.SelectedValue = Pais
        cmb_Estado.SelectedValue = Estado
        cmb_Ciudad.SelectedValue = Ciudad
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        btn_EliminaReferencia.Enabled = False
    End Sub

    Private Sub cmb_Banco_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedValueChanged
        SegundosDesconexion = 0

        If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cbx_Activas.Checked) Then
            MsgBox("Ocurro un error al buscar las Cuentas del Banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            If lsv_Catalogo.SelectedItems(0).SubItems(5).Text = "ACTIVO" Then
                fn_Cuentas_Baja(lsv_Catalogo.SelectedItems(0).Tag, "B", lsv_Catalogo.SelectedItems(0).Text, cmb_Banco.Text, lsv_Catalogo.SelectedItems(0).SubItems(1).Text)
            Else
                fn_Cuentas_Baja(lsv_Catalogo.SelectedItems(0).Tag, "A", lsv_Catalogo.SelectedItems(0).Text, cmb_Banco.Text, lsv_Catalogo.SelectedItems(0).SubItems(1).Text)
            End If

            If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cbx_Activas.Checked) Then
                MsgBox("Ocurro un error al buscar las Cuentas del Banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
            Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Call IniciarModificacion(lsv_Catalogo.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub IniciarModificacion(ByVal Id_Cuenta As Integer)
        Dim Fila As DataRow = fn_Cuentas_Read(Id_Cuenta)

        cmb_Banco2.SelectedValue = Fila("Id_CajaBancaria")
        cmb_Referenciada.SelectedValue = Fila("Referenciada")
        cmb_ReferenciaFija.SelectedValue = Fila("Referencia_Fija")
        cmb_Moneda.SelectedValue = Fila("Id_Moneda")
        cmb_Moneda.Tag = cmb_Moneda.Text
        tbx_Cuenta.Text = Fila("Numero_Cuenta")
        tbx_Cuenta.Tag = tbx_Cuenta.Text
        cmb_Pais.SelectedValue = Fila("Id_Pais")
        cmb_Estado.SelectedValue = Fila("Id_Estado")
        cmb_Ciudad.SelectedValue = Fila("Id_Ciudad")
        chk_cuentaDefault.Checked = (Fila("CuentaDefault") = "S")
        Tbl_Referencias = fn_Cuentas_Get1(Id_Cuenta, "T")
        Call ActualizarReferencias()

        cmb_Banco2.Tag = Fila("Id_CajaBancaria")
        lbl_Moneda.Tag = Fila("Id_Moneda")

        Tab_Nuevo.Text = "Modificar"
        Tab_Nuevo.Tag = Id_Cuenta
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub cmb_2_Referenciada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Referenciada.SelectedIndexChanged
        cmb_ReferenciaFija.Enabled = cmb_Referenciada.SelectedValue = "S"
    End Sub

    Private Sub cmb_2_ReferenciaFija_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ReferenciaFija.SelectedValueChanged
        gbx_Referencias.Enabled = cmb_ReferenciaFija.SelectedValue = "S"
    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            IniciarModificacion(lsv_Catalogo.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub btn_Banco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Banco.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Banco.SelectedValue = 0
        Else
            cmb_Banco.SelectedValue = frm.Id
        End If
    End Sub

    Private Sub btn_Banco2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Banco2.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Banco2.SelectedValue = 0
        Else
            cmb_Banco2.SelectedValue = frm.Id
        End If
    End Sub

    Private Sub cbx_Activas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Activas.CheckedChanged
        If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cbx_Activas.Checked) Then
            MsgBox("Ocurió un error al buscar las Cuentas del Banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0

        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        Lbl_Registros.Text = "Registros:" & lsv_Catalogo.Items.Count
    End Sub

    Private Sub cmb_2_ReferenciaFija_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ReferenciaFija.EnabledChanged
        If cmb_ReferenciaFija.Enabled = False Then cmb_ReferenciaFija.SelectedValue = "N"
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio) Then
            MsgBox("No se encontró.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_BajaRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BajaRef.Click
        SegundosDesconexion = 0

        'lsv_2_Referencia 
        If MsgBox("ADVERTENCIA: Si la Referencia está ligada a un Cliente, también se dará de Baja o Reingreso esta relación con el mismo. Desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, frm_MENU.Text) <> MsgBoxResult.Yes Then Exit Sub
        If lsv_2_Referencia.SelectedItems(0).SubItems(1).Text = "ACTIVO" Then
            'DARLA DE BAJA
            If Not fn_CuentasReferencias_Baja(lsv_2_Referencia.SelectedItems(0).Tag) Then
                MsgBox("Ocurro un error al intentar dar de baja la Referencia " & lsv_2_Referencia.SelectedItems(0).Text, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
        ElseIf lsv_2_Referencia.SelectedItems(0).SubItems(1).Text = "INACTIVO" Then
            'DARLA DE ALTA
            If Not fn_CuentasReferencias_Reingreso(lsv_2_Referencia.SelectedItems(0).Tag) Then
                MsgBox("Ocurro un error al intentar reingresar la Referencia " & lsv_2_Referencia.SelectedItems(0).Text, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
        End If
        Tbl_Referencias = fn_Cuentas_Get1(lsv_Catalogo.SelectedItems(0).Tag, "T")
        Call ActualizarReferencias()
    End Sub

    Private Sub lsv_2_Referencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_2_Referencia.SelectedIndexChanged
        btn_BajaRef.Enabled = False
        btn_EliminaReferencia.Enabled = False
        If lsv_2_Referencia.SelectedItems.Count = 0 Then Exit Sub

        btn_BajaRef.Enabled = lsv_2_Referencia.SelectedItems.Count > 0
        btn_EliminaReferencia.Enabled = CInt(lsv_2_Referencia.SelectedItems(0).SubItems(2).Text.Trim) = 0

        End Sub

    Private Sub btn_BuscarRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarRef.Click
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_2_Referencia.SelectedItems.Count > 0 Then Fila_Inicio = lsv_2_Referencia.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_2_Referencia, tbx_BuscarRef.Text, 0, Fila_Inicio) Then
            MsgBox("No se encontró.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_EliminaReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminaReferencia.Click
        SegundosDesconexion = 0
        If lsv_2_Referencia.Items.Count = 0 Then Exit Sub
        If MsgBox("Confirma que desea eliminar la referencia de esta cuenta bancaria?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        'eliminar la referecia. verificar que n otenga fichas

        Dim Referencia As Integer = fn_Referencias_Eliminar(lsv_2_Referencia.SelectedItems(0).Tag)

        Select Case Referencia
            Case -1
                MsgBox("Ocurrió un error al eliminar la Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Case 0
                MsgBox("No es posible eliminar la Referencia porque ya se han capturado fichas de depósito.", MsgBoxStyle.Critical, frm_MENU.Text)
            Case 1
                MsgBox("Referencia eliminada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Tbl_Referencias.Rows.Clear()
                Tbl_Referencias = fn_Cuentas_Get1(lsv_Catalogo.SelectedItems(0).Tag, "T")
                Call ActualizarReferencias()
                btn_EliminaReferencia.Enabled = False
                btn_BajaRef.Enabled = False

        End Select

    End Sub

    Private Sub cmb_Status_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_Status.SelectedValueChanged
        Dim Id_Cuenta = lsv_Catalogo.SelectedItems(0).Tag
        Dim Status = cmb_Status.SelectedValue
        Tbl_Referencias = fn_Cuentas_Get1(Id_Cuenta, Status)

        Call ActualizarReferencias()
        If Status = "A" Or Status = "B" Then
            tbx_Referencia.Enabled = False
            Btn_2_AgregarReferencia.Enabled = False

        End If

        If Status = "T" Then
            tbx_Referencia.Enabled = True
            Btn_2_AgregarReferencia.Enabled = True
        End If


    End Sub
End Class