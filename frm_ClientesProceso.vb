Imports System.Data.SqlClient
Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ClientesProceso

    Private Dt_Clientes As New DataTable

    Private Sub frm_CajasBancarias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Aqui se llenan los combos de la pestaña 0
        cmb_Cia.Actualizar()
        cmb_Banco.Actualizar()

        'Aqui se llenan los combos de la pestaña 1
        cmb_TipoProceso.AgregarItem("N", "NORMAL")
        cmb_TipoProceso.AgregarItem("P", "POR PARCIALES")

        cmb_Compañias.Actualizar()
        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()

        Cp_cmb_SimpleFiltradoParam1.Actualizar()


        cmb_GrupoDota.AgregaParametro("@Id_CajaBancaria", -1, 1)
        cmb_GrupoDota.Actualizar()
        cmb_GrupoDeposito.AgregaParametro("@Id_CajaBancaria", -1, 1)
        cmb_GrupoDeposito.Actualizar()
        cmb_GrupoF.AgregaParametro("@Id_CajaBancaria", -1, 1)
        cmb_GrupoF.Actualizar()
        cmb_CajaBancariaNew.Actualizar()

        cmb_Ciudad.AgregaParametro("@Id_Estado", -1, 1)
        cmb_Ciudad.Actualizar()
        cmb_Estado.AgregaParametro("@Id_Pais", -1, 1)
        cmb_Estado.Actualizar()
        cmb_Pais.Actualizar()

        Call ComboSiNo(cmb_RequiereCuentas)

        'Aqui se actualiza el list view lsv_0_Catalogo
        lsv_0_Catalogo.Columns.Add("Clave")
        lsv_0_Catalogo.Columns.Add("Nombre Comercial")
        lsv_0_Catalogo.Columns.Add("Numero Contrato")
        lsv_0_Catalogo.Columns.Add("Descripcion")
        lsv_0_Catalogo.Columns.Add("Status")

        lsv_Cuentas.Columns.Add("Numero Cuenta")
        lsv_Cuentas.Columns.Add("Moneda")
        lsv_Cuentas.Columns.Add("Status")
        lsv_Referencias.Columns.Add("Referencia")
        lsv_Referencias.Columns.Add("Status")

        'Sacar el Pais, Estado y Ciudad de la Sucursal para ponerlos como sugerencia
        Dim dt As DataTable = fn_Sucursales_Read(SucursalId)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cmb_Pais.SelectedValue = dt.Rows(0)("Id_Pais")
                cmb_Estado.SelectedValue = dt.Rows(0)("Id_Estado")
                cmb_Ciudad.SelectedValue = dt.Rows(0)("Id_Ciudad")
            End If
        End If

        tbx_1_Direccion.Tag = ""
        cmb_Pais.Tag = 0
        cmb_Estado.Tag = 0
        cmb_Ciudad.Tag = 0
        'Tabla que contendrá la información de los clientes a los cuales se les creará lo de proceso.
        Dt_Clientes.Columns.Add("Id_Cliente")
        Dt_Clientes.Columns.Add("Clave Cliente")
        Dt_Clientes.Columns.Add("Nombre Comercial")
        Dt_Clientes.Columns.Add("Status")
        'SE LE AGREGO LA DIRECCION YA QUE ANTES SE AGARRABA LA DIRECCION DEL PAPA Y LAS DOTACIONES SALIAN CON DIRECCION DEL PADRE PARA CUALQUIER
        'SUBCLIENTE MODIFICO CARLOS SOLA 3/12/13
        Dt_Clientes.Columns.Add("Direccion_Comercial")



    End Sub

    Private Function esPadre(padre As String) As Boolean
        Dim respPadre As Boolean = False
        Try
            Dim ok = CInt(padre)
            respPadre = True
        Catch ex As Exception

        End Try
        Return respPadre
    End Function


#Region "Metodos Privados"

    ''' <summary>
    ''' Agrega los valores si y no a un combo
    ''' </summary>
    ''' <param name="cmb">Es el combo al que se le van a agregar los valores</param>
    Private Sub ComboSiNo(ByVal cmb As cp_cmb_Manual)
        cmb.AgregarItem("S", "Sí")
        cmb.AgregarItem("N", "No")
    End Sub

    ''' <summary>
    ''' Limpia todas las casilas de la ficha 1
    ''' </summary>
    Private Sub LimpiarFicha1()
        Dt_Clientes.Rows.Clear()
        tbx_1_ClienteLibre.Clear()
        cmb_Compañias.SelectedValue = "0"
        tbx_1_Cliente.Clear()
        cmb_Cliente.SelectedValue = "0"
        tbx_1_Direccion.Clear()
        tbx_1_Direccion.Tag = ""
        cmb_Pais.SelectedValue = "0"
        cmb_CajaBancariaNew.SelectedValue = "0"
        cmb_GrupoF.SelectedValue = "0"
        tbx_1_Contrato.Clear()
        cmb_RequiereCuentas.SelectedValue = "0"
        cmb_Pais.Tag = 0
        cmb_Estado.Tag = 0
        cmb_Ciudad.Tag = 0
        Cp_cmb_SimpleFiltradoParam1.SelectedValue = "0"
        cmb_CajaBancariaNew.Enabled = True
        cmb_Cliente.Enabled = True
        tbx_1_Cliente.Enabled = True

        lsv_Cuentas.Items.Clear()
        lsv_Referencias.Items.Clear()
    End Sub

    ''' <summary>
    ''' Limpia solo las casillas que se ven afectadas al cambiar la casilla del cliente
    ''' </summary>
    Private Sub LimpiarParcialFicha1()
        Dt_Clientes.Rows.Clear()
        cmb_Cliente.SelectedValue = "0"
        tbx_1_Cliente.Clear()
        tbx_1_ClienteLibre.Clear()
        tbx_1_Direccion.Clear()
        cmb_Pais.SelectedValue = "0"
    End Sub

    ''' <summary>
    ''' Valida que no existan casillas vacias en la ficha 1
    ''' </summary>
    Private Function ValidarFicha1() As Boolean
        If cmb_Compañias.SelectedValue = "0" Then Return False
        'If tbx__Cliente.Text = "" Then Return False
        'If cmb_1_Cliente.SelectedValue = "0" And cmb_1_Cliente.Visible Then Return False
        'If tbx_1_Direccion.Text = "" Then Return False
        If cmb_Ciudad.SelectedValue = "0" Then Return False
        If cmb_CajaBancariaNew.SelectedValue = "0" Then Return False
        'If tbx_1_Contrato.Text = "" Then Return False
        If cmb_RequiereCuentas.SelectedValue = "0" Then Return False
        'If cmb_GrupoDeposito.Text = "" Then Return False
        'If cmb_GrupoDota.Text = "" Then Return False

        Return True
    End Function

#End Region

    Private Sub Tab_General_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_General.SelectedIndexChanged
        SegundosDesconexion = 0

        If Tab_General.SelectedTab Is tab_Nuevo Then
            If tab_Nuevo.Text = "Modificar" AndAlso lsv_0_Catalogo.SelectedItems(0).SubItems(4).Text = "INACTIVO" Then
                cmb_Cliente.ActualizaValorParametro("@Status", "T")
            Else
                cmb_Cliente.ActualizaValorParametro("@Status", "A")
            End If
            cmb_Cliente.Actualizar()
        End If
        If Not cmb_Cliente.Visible Then
            cmb_Pais.SelectedValue = CInt(cmb_Pais.Tag)
            cmb_Estado.SelectedValue = CInt(cmb_Estado.Tag)
            cmb_Ciudad.SelectedValue = CInt(cmb_Ciudad.Tag)
        End If

        cmb_CajaBancariaNew.Enabled = True
        btn_BuscarCajaBancariaNew.Enabled = True
        cmb_Compañias.Enabled = True
        btn_BuscarClienteNew.Enabled = True
        chk_Clientes.Enabled = True
    End Sub

    Private Sub BTN_0_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_0_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_0_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_0_Catalogo.SelectedItems(0).Index + 1

        fn_Buscar_enListView(lsv_0_Catalogo, tbx_0_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub cmb_Banco_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedValueChanged
        SegundosDesconexion = 0

        'Aqui se actualiza el list view lsv_0_Catalogo
        If cmb_Banco.SelectedValue <> "0" And cmb_Cia.SelectedValue <> "0" Then
            fn_ClientesProceso_LlenarLista(lsv_0_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, cbx_Activas.Checked)
        Else
            lsv_0_Catalogo.Items.Clear()
        End If
        lbl_Registros.Text = "Registros: " & lsv_0_Catalogo.Items.Count
        btn_Exportar.Enabled = lsv_0_Catalogo.Items.Count > 0
    End Sub

    Private Sub btn_BuscarCajaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCajaBancaria.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        cmb_Banco.SelectedValue = frm.Id
    End Sub

    Private Sub cmb_Cia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedValueChanged
        SegundosDesconexion = 0

        'Aqui se actualiza el list view lsv_0_Catalogo
        If cmb_Banco.SelectedValue <> "0" And cmb_Cia.SelectedValue <> "0" Then
            fn_ClientesProceso_LlenarLista(lsv_0_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, cbx_Activas.Checked)
        Else
            lsv_0_Catalogo.Items.Clear()
        End If
        lbl_Registros.Text = "Registros: " & lsv_0_Catalogo.Items.Count
        btn_Exportar.Enabled = lsv_0_Catalogo.Items.Count > 0
    End Sub

    Private Sub cbx_Activas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Activas.CheckedChanged
        SegundosDesconexion = 0

        fn_ClientesProceso_LlenarLista(lsv_0_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, cbx_Activas.Checked)
        lbl_Registros.Text = "Registros: " & lsv_0_Catalogo.Items.Count
        btn_Exportar.Enabled = lsv_0_Catalogo.Items.Count > 0
    End Sub

    Private Sub lsv_0_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_0_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Modificar.Enabled = lsv_0_Catalogo.SelectedItems.Count > 0
        btn_Baja.Enabled = lsv_0_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        If lsv_0_Catalogo.SelectedItems.Count > 0 Then
            If Not fn_Proceso_BajaReing(lsv_0_Catalogo.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar Dar de Baja o Alta el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_ClientesProceso_LlenarLista(lsv_0_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, cbx_Activas.Checked) Then
                    MsgBox("Ha ocurrido un error al intentar actualizar la lista", MsgBoxStyle.Critical, frm_MENU)
                End If
            End If
        End If
        lbl_Registros.Text = "Registros: " & lsv_0_Catalogo.Items.Count
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_0_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim TrasV As String = cmb_Cia.SelectedValue.ToString()
        If lsv_0_Catalogo.SelectedItems.Count > 0 Then
            Try
                Call LimpiarFicha1()
                If TrasV <> 1 Then
                    Cp_cmb_SimpleFiltradoParam1.Enabled = True
                Else
                    Cp_cmb_SimpleFiltradoParam1.Enabled = False
                    Cp_cmb_SimpleFiltradoParam1.SelectedIndex = -1
                End If
                tab_Nuevo.Text = "Modificar"
                Tab_General.SelectedTab = tab_Nuevo
                Dim Dr_CliPro As DataRow = fn_ClientesProceso_Leer(lsv_0_Catalogo.SelectedItems(0).Tag)
                tab_Nuevo.Tag = lsv_0_Catalogo.SelectedItems(0).Tag
                cmb_Compañias.SelectedValue = Dr_CliPro("Id_Cia")
                cmb_Cliente.SelectedValue = Dr_CliPro("Id_Cliente")
                tbx_1_ClienteLibre.Text = Dr_CliPro("Nombre_Comercial")
                tbx_1_Direccion.Text = Dr_CliPro("Direccion_Comercial")
                tbx_1_Direccion.Tag = Dr_CliPro("Direccion_Comercial")

                If Dr_CliPro("Id_Ciudad") > 0 Then
                    Dim Dr_Ciudad As DataRow = fn_Ciudad_Read(Dr_CliPro("Id_Ciudad"))
                    If Dr_Ciudad IsNot Nothing Then
                        cmb_Pais.SelectedValue = Dr_Ciudad("Id_Pais")      'Id_Pais, 
                        cmb_Estado.SelectedValue = Dr_Ciudad("Id_Estado")  'Id_Estado, 
                        cmb_Ciudad.SelectedValue = Dr_Ciudad("Id_Ciudad") 'Id_Ciudad
                        cmb_Pais.Tag = Dr_Ciudad("Id_Pais")              'Id_Pais, 
                        cmb_Estado.Tag = Dr_Ciudad("Id_Estado")            'Id_Estado, 
                        cmb_Ciudad.Tag = Dr_Ciudad("Id_Ciudad")            'Id_Ciudad
                    End If
                End If

                cmb_CajaBancariaNew.SelectedValue = Dr_CliPro("Id_CajaBancaria")
                cmb_GrupoF.SelectedValue = Dr_CliPro("Id_GrupoF")
                tbx_1_Contrato.Text = Dr_CliPro("Numero_Contrato")
                cmb_RequiereCuentas.SelectedValue = Dr_CliPro("Requiere_Cuenta")
                cmb_GrupoDeposito.SelectedValue = Dr_CliPro("Id_GrupoDepo")
                cmb_GrupoDota.SelectedValue = Dr_CliPro("Id_GrupoDota")
                cmb_TipoProceso.SelectedValue = Dr_CliPro("Tipo_Proceso")
                Cp_cmb_SimpleFiltradoParam1.SelectedValue = Dr_CliPro("Razon_Social")
                btn_Cuentas.Enabled = tab_Nuevo.Tag > 0
                fn_Proceso_ObtenerCuentas(lsv_Cuentas, tab_Nuevo.Tag)

                cmb_CajaBancariaNew.Enabled = False
                btn_BuscarCajaBancariaNew.Enabled = False
                cmb_Compañias.Enabled = False
                btn_BuscarClienteNew.Enabled = False
                chk_Clientes.Enabled = False

                cmb_Cliente.Enabled = False
                tbx_1_Cliente.Enabled = False

                Dim categoria = Dr_CliPro("Categoria")
                If categoria Is Nothing Or IsDBNull(categoria) Then
                    categoria = ""
                End If
                Select Case categoria
                    Case "A"
                        cmb_Categoria.SelectedIndex = 0
                    Case "B"
                        cmb_Categoria.SelectedIndex = 1
                    Case "C"
                        cmb_Categoria.SelectedIndex = 2
                    Case ""
                        cmb_Categoria.SelectedIndex = 3

                End Select
                If esPadre(tbx_1_Cliente.Text) And Dr_CliPro("Id_Cia") = 1 Then
                    chk_TipoProcesoSub.Enabled = True

                Else
                    chk_TipoProcesoSub.Enabled = False
                End If
            Catch ex As Exception
                FuncionesGlobales.TrataEx(ex)
            End Try
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_0_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub cmb_cajaBancariaNew_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancariaNew.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_CajaBancariaNew.Items.Count = 0 Then Exit Sub

        cmb_GrupoF.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancariaNew.SelectedValue)
        cmb_GrupoF.Actualizar()

        cmb_GrupoDeposito.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancariaNew.SelectedValue)
        cmb_GrupoDeposito.Actualizar()

        cmb_GrupoDota.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancariaNew.SelectedValue)
        cmb_GrupoDota.Actualizar()
    End Sub

    Private Sub btn_BuscarCajaBancariaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCajaBancariaNew.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        cmb_CajaBancariaNew.SelectedValue = frm.Id
    End Sub

    Private Sub cmb_Compañias_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Compañias.SelectedValueChanged
        SegundosDesconexion = 0

        'Call LimpiarParcialFicha1()
        Dt_Clientes.Rows.Clear()
        cmb_Cliente.SelectedValue = "0"
        If Not cmb_Cliente.Visible Then
            tbx_1_Direccion.Tag = tbx_1_Direccion.Text
            cmb_Pais.Tag = cmb_Pais.SelectedValue
            cmb_Estado.Tag = cmb_Estado.SelectedValue
            cmb_Ciudad.Tag = cmb_Ciudad.SelectedValue
        End If
        If cmb_Compañias.SelectedValue = CiaId Then
            tbx_1_Cliente.Visible = True
            cmb_Cliente.Visible = True
            btn_BuscarClienteNew.Visible = True
            chk_Clientes.Visible = True
            tbx_1_Direccion.Clear()
            tbx_1_ClienteLibre.Visible = False
            cmb_Pais.SelectedValue = 0
            cmb_Estado.SelectedValue = 0
            cmb_Ciudad.SelectedValue = 0
        Else
            tbx_1_Direccion.Text = tbx_1_Direccion.Tag
            cmb_Pais.SelectedValue = cmb_Pais.Tag
            cmb_Estado.SelectedValue = cmb_Estado.Tag
            cmb_Ciudad.SelectedValue = cmb_Ciudad.Tag
            tbx_1_Cliente.Visible = False
            cmb_Cliente.Visible = False
            cmb_Cliente.SelectedValue = "0"
            btn_BuscarClienteNew.Visible = False
            chk_Clientes.Visible = False
            tbx_1_ClienteLibre.Visible = True
        End If

        'Deshabilitar dirección, país, estado y ciudad para cuando sea un cliente de SISSA
        tbx_1_Direccion.Enabled = cmb_Compañias.SelectedValue <> 1
        cmb_Pais.Enabled = cmb_Compañias.SelectedValue <> 1
        cmb_Estado.Enabled = cmb_Compañias.SelectedValue <> 1
        cmb_Ciudad.Enabled = cmb_Compañias.SelectedValue <> 1
    End Sub

    Private Sub btn_BuscarClienteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarClienteNew.Click

        SegundosDesconexion = 0

        Frm_BuscarCliente.ShowDialog()
        tbx_1_Cliente.Text = Frm_BuscarCliente.Clave

    End Sub

    Private Sub chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Clientes.CheckedChanged
        SegundosDesconexion = 0

        Dt_Clientes.Rows.Clear()
        Dt_Clientes.Rows.Add(cmb_Cliente.SelectedValue, tbx_1_Cliente.Text, cmb_Cliente.Text, "ACTIVO")
        If chk_Clientes.Checked AndAlso cmb_Cliente.SelectedValue > 0 Then
            Dim frm As New frm_BuscarSubClientes
            frm.Consulta = frm_BuscarSubClientes.Query.ClientesProceso
            frm.Id_Padre = cmb_Cliente.SelectedValue
            frm.FiltroStatus = "A"
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Dt_Clientes.Rows.Clear()
                For Each ModalSubClientes As ListViewItem In frm.lsv_Clientes.CheckedItems
                    If frm.lsv_Clientes.CheckedItems.Count = 1 Then
                        'Significa que la ventana modal solo se selecciono un solo cliente
                        'por consiguiente no se necesita tener palomeada esta opción
                        If cmb_Cliente.SelectedValue = ModalSubClientes.Tag Then
                            chk_Clientes.Checked = False
                            Exit Sub
                        End If
                    End If

                    If ModalSubClientes.SubItems(3).Text <> "BAJA PERMANENTE" AndAlso ModalSubClientes.SubItems(3).Text <> "BAJA" Then
                        Dt_Clientes.Rows.Add(ModalSubClientes.Tag, ModalSubClientes.Text, ModalSubClientes.SubItems(1).Text, ModalSubClientes.SubItems(3).Text, ModalSubClientes.SubItems(6).Text)
                    End If
                Next
                If Dt_Clientes.Rows.Count = 0 Then chk_Clientes.Checked = False
            Else
                chk_Clientes.Checked = False
            End If
        End If
    End Sub

    Private Sub cmb_Pais_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pais.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Pais.Items.Count = 0 Then Exit Sub
        cmb_Estado.ActualizaValorParametro("@Id_Pais", cmb_Pais.SelectedValue)
        cmb_Estado.Actualizar()
        If Not cmb_Cliente.Visible Then cmb_Pais.Tag = cmb_Pais.SelectedValue
    End Sub

    Private Sub cmb_Estado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Estado.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Estado.Items.Count = 0 Then Exit Sub
        cmb_Ciudad.ActualizaValorParametro("@Id_Estado", cmb_Estado.SelectedValue)
        cmb_Ciudad.Actualizar()
        If Not cmb_Cliente.Visible Then cmb_Estado.Tag = cmb_Estado.SelectedValue
    End Sub

    Private Sub cmb_Ciudad_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ciudad.SelectedValueChanged
        SegundosDesconexion = 0

        If Not cmb_Cliente.Visible Then cmb_Ciudad.Tag = cmb_Ciudad.SelectedValue
    End Sub

    Private Sub lsv_Cuentas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Cuentas.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Cuentas.SelectedItems.Count > 0 Then
            fn_Proceso_ObtenerReferencias(lsv_Referencias, tab_Nuevo.Tag, lsv_Cuentas.SelectedItems(0).Tag)
            btn_CuentasBaja.Enabled = True
        Else
            lsv_Referencias.Items.Clear()
            btn_CuentasBaja.Enabled = False
        End If
    End Sub

    Private Sub lsv_Cuentas_AlActualizar() Handles lsv_Cuentas.AlActualizar
        SegundosDesconexion = 0

        btn_CuentasBaja.Enabled = False
    End Sub

    Private Sub btn_CuentasBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CuentasBaja.Click
        SegundosDesconexion = 0

        If lsv_Cuentas.SelectedItems.Count > 0 Then
            If Not fn_Proceso_CuentasBaja_Reing(tab_Nuevo.Tag, lsv_Cuentas.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un Error al intentar Modificar la Cuenta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_Proceso_ObtenerCuentas(lsv_Cuentas, tab_Nuevo.Tag) Then
                    MsgBox("Ha ocurrido un Error al intentar Actualizar las Cuentas.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub lsv_Referencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Referencias.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_ReferenciaBaja.Enabled = lsv_Referencias.SelectedItems.Count > 0
    End Sub

    Private Sub lsv_Referencias_AlActualizar() Handles lsv_Referencias.AlActualizar
        SegundosDesconexion = 0

        btn_ReferenciaBaja.Enabled = False
    End Sub

    Private Sub btn_ReferenciaBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReferenciaBaja.Click
        SegundosDesconexion = 0

        If lsv_Referencias.SelectedItems.Count > 0 Then
            If Not fn_Proceso_ReferenciasBaja_Reing(tab_Nuevo.Tag, lsv_Referencias.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un Error al intentar Modificar la Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_Proceso_ObtenerReferencias(lsv_Referencias, tab_Nuevo.Tag, lsv_Cuentas.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un Error al intentar Actualizar la Referencias", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Id_Cliente As Integer
        Dim NombreComercial As String
        Dim TrasV As String = cmb_Compañias.SelectedValue.ToString()
        If cmb_CajaBancariaNew.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancariaNew.Focus()
            Exit Sub
        End If

        If cmb_Cliente.Visible Then
            If cmb_Cliente.SelectedValue = "0" Then
                MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Cliente.Focus()
                Exit Sub
            End If

            Id_Cliente = cmb_Cliente.SelectedValue
            NombreComercial = cmb_Cliente.Text
        Else
            If tbx_1_ClienteLibre.Text = "" Then
                MsgBox("Capture el Nombre del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_1_ClienteLibre.Focus()
                Exit Sub
            End If
            Id_Cliente = 0
            NombreComercial = tbx_1_ClienteLibre.Text
        End If

        If TrasV <> 1 And (Cp_cmb_SimpleFiltradoParam1.SelectedIndex = 0 Or Cp_cmb_SimpleFiltradoParam1.SelectedIndex = -1) Then
            MsgBox("Seleccione una Razón Social.", MsgBoxStyle.Critical, frm_MENU.Text)
            Cp_cmb_SimpleFiltradoParam1.Focus()
            Exit Sub
        End If

        If cmb_Ciudad.SelectedValue = 0 Then
            MsgBox("Seleccione la Ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ciudad.Focus()
            Exit Sub
        End If
        If cmb_RequiereCuentas.SelectedValue = "0" Then
            MsgBox("Seleccione si requiere cuentas o no.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_RequiereCuentas.Focus()
            Exit Sub
        End If
        If cmb_TipoProceso.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo de Proceso que se realizará.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoProceso.Focus()
            Exit Sub
        End If

        If tab_Nuevo.Tag = 0 Then
            If cmb_Cliente.Visible Then
                If cmb_Compañias.SelectedValue = CiaId Then
                    For Each Row As DataRow In Dt_Clientes.Rows
                        If fn_ClientesProceso_Existe(Row("Id_Cliente"), cmb_Compañias.SelectedValue, cmb_CajaBancariaNew.SelectedValue) Then
                            MsgBox("No se pudo comprobar o alguno de los Clientes seleccionados ya existe para la Caja Bancaria y Compañía seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Next
                End If

                tab_Nuevo.Tag = fn_ClientesProceso_CrearVarios(Dt_Clientes, cmb_Compañias.SelectedValue, tbx_1_Direccion.Text, cmb_Ciudad.SelectedValue,
                                                               cmb_CajaBancariaNew.SelectedValue, cmb_GrupoF.SelectedValue, tbx_1_Contrato.Text, cmb_RequiereCuentas.Text,
                                                               cmb_GrupoDeposito.SelectedValue, cmb_GrupoDota.SelectedValue, cmb_TipoProceso.SelectedValue, cmb_Categoria.SelectedItem, Cp_cmb_SimpleFiltradoParam1.SelectedValue)
            Else

                tab_Nuevo.Tag = fn_ClientesProceso_Crear(Id_Cliente, cmb_Compañias.SelectedValue, tbx_1_Cliente.Text, NombreComercial, tbx_1_Direccion.Text, cmb_Ciudad.SelectedValue,
                                                         cmb_CajaBancariaNew.SelectedValue, cmb_GrupoF.SelectedValue, tbx_1_Contrato.Text, cmb_RequiereCuentas.Text, cmb_GrupoDeposito.SelectedValue,
                                                         cmb_GrupoDota.SelectedValue, cmb_TipoProceso.SelectedValue, cmb_Categoria.SelectedItem, Cp_cmb_SimpleFiltradoParam1.SelectedValue)
            End If

            If tab_Nuevo.Tag = 0 Then
                MsgBox("No se pudo guardar el registro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                tab_Nuevo.Tag = 0
                Tab_General.SelectedTab = Tab_Listado
                tab_Nuevo.Text = "Nuevo"
                Call LimpiarFicha1()
                chk_Clientes.Checked = False
            End If
        Else
            If Not fn_ClientesProceso_Modificar(tab_Nuevo.Tag, NombreComercial, tbx_1_Direccion.Text, cmb_Ciudad.SelectedValue,
                                     cmb_GrupoF.SelectedValue, tbx_1_Contrato.Text, cmb_RequiereCuentas.Text, cmb_GrupoDeposito.SelectedValue, cmb_GrupoDota.SelectedValue, cmb_TipoProceso.SelectedValue, cmb_Categoria.SelectedItem, chk_TipoProcesoSub.Checked, Id_Cliente, Cp_cmb_SimpleFiltradoParam1.SelectedValue) Then
                MsgBox("No se pudo actualizar el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Tab_General.SelectedTab = Tab_Listado
            tab_Nuevo.Tag = 0
            Tab_General.SelectedTab = Tab_Listado
            tab_Nuevo.Text = "Nuevo"
            Call LimpiarFicha1()
        End If

        'Aqui se actualiza el list view lsv_0_Catalogo
        fn_ClientesProceso_LlenarLista(lsv_0_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, cbx_Activas.Checked)
        lbl_Registros.Text = "Registros: " & lsv_0_Catalogo.Items.Count
        btn_Cuentas.Enabled = tab_Nuevo.Tag > 0
    End Sub

    Private Sub btn_Cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cuentas.Click
        SegundosDesconexion = 0

        If tab_Nuevo.Tag > 0 Then
            Dim Frm As New frm_CuentasModal
            Frm.Id_ClienteP = tab_Nuevo.Tag
            Frm.Id_Banco = cmb_CajaBancariaNew.SelectedValue
            Frm.ShowDialog()
            Frm.Dispose()
            fn_Proceso_ObtenerCuentas(lsv_Cuentas, tab_Nuevo.Tag)
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        tab_Nuevo.Tag = 0
        Tab_General.SelectedTab = Tab_Listado
        tab_Nuevo.Text = "Nuevo"
        Call LimpiarFicha1()
        cmb_CajaBancariaNew.Enabled = True
        cmb_Cliente.Enabled = True
        tbx_1_Cliente.Enabled = True
        chk_Clientes.Enabled = True
    End Sub

    Private Sub btn_0_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            Dt_Clientes.Rows.Clear()
            chk_Clientes.Checked = False
            chk_Clientes.Enabled = cmb_Cliente.SelectedValue <> 0
            If cmb_Cliente.SelectedValue = 0 Then
                If cmb_Cliente.Visible Then
                    tbx_1_Direccion.Clear()
                    cmb_Pais.SelectedValue = 0
                    cmb_Estado.SelectedValue = 0
                    cmb_Ciudad.SelectedValue = 0
                End If
                Exit Sub
            End If
            If cmb_Compañias.SelectedValue = CiaId Then
                'obtiene los valores de la basede datos
                Dt_Clientes.Rows.Add(cmb_Cliente.SelectedValue, tbx_1_Cliente.Text, cmb_Cliente.Text, "ACTIVO")

                Dim Dr_Datos As DataRow = fn_Clientes_Generales(cmb_Cliente.SelectedValue)
                'Escribe los valores en los campos
                If Not Dr_Datos Is Nothing Then
                    tbx_1_Direccion.Text = Dr_Datos("Calle_Comercial") & " " & Dr_Datos("Numero_Comercial") & " " & Dr_Datos("NumeroInt_Comercial") & ", " & Dr_Datos("Colonia_Comercial")   'Direccion_Comercial
                    Dim Dr_LugarC As DataRow = fn_Clientes_Lugar(Dr_Datos("Zona_Comercial"))

                    If Not Dr_LugarC Is Nothing Then
                        cmb_Pais.SelectedValue = Dr_LugarC("Id_Pais")
                        cmb_Estado.SelectedValue = Dr_LugarC("Id_Estado")
                        cmb_Ciudad.SelectedValue = Dr_LugarC("Id_Ciudad")
                    End If
                Else
                    Call LimpiarParcialFicha1()
                End If
            End If

        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
        End Try
    End Sub

    Private Sub cmb_CajaBancariaNew_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CajaBancariaNew.SelectedIndexChanged
        Dim TrasV As String = cmb_Compañias.SelectedValue.ToString
        If TrasV <> 1 Then
            Cp_cmb_SimpleFiltradoParam1.Enabled = True
        Else
            Cp_cmb_SimpleFiltradoParam1.Enabled = False
            Cp_cmb_SimpleFiltradoParam1.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmb_Compañias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Compañias.SelectedIndexChanged
        Cp_cmb_SimpleFiltradoParam1.SelectedValue = "0"
        Dim TrasV As String = cmb_Compañias.SelectedValue.ToString
        If TrasV <> 1 Then
            Cp_cmb_SimpleFiltradoParam1.Enabled = True
        Else
            Cp_cmb_SimpleFiltradoParam1.Enabled = False
            Cp_cmb_SimpleFiltradoParam1.SelectedIndex = -1
        End If
    End Sub

    Private Sub Cp_cmb_SimpleFiltradoParam1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cp_cmb_SimpleFiltradoParam1.SelectedIndexChanged

    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Cia.SelectedIndexChanged

    End Sub
End Class