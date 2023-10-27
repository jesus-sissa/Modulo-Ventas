Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_CuentasBCliente

    Private Sub frm_CuentasBCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_CajaBancaria.Actualizar()
        cmb_Compañia.Actualizar()
        cmb_Cliente.AgregaParametro("@Id_CajaBancaria", 0, 1)
        cmb_Cliente.AgregaParametro("@Id_Cia", 0, 1)
        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()

        lsv_Consulta.Columns.Add("Caja Bancaria")
        lsv_Consulta.Columns.Add("Cia Traslado")
        lsv_Consulta.Columns.Add("Clave Cliente")
        lsv_Consulta.Columns.Add("Cliente")
        lsv_Consulta.Columns.Add("Requiere Cuenta")
        lsv_Consulta.Columns.Add("Moneda")
        lsv_Consulta.Columns.Add("Cuenta")
        lsv_Consulta.Columns.Add("Referenciada")
        lsv_Consulta.Columns.Add("Ref.Fija")
        lsv_Consulta.Columns.Add("Cuenta")
        lsv_Consulta.Columns.Add("Referencia")
        lsv_Consulta.Columns.Add("Status")

        cmb_StatusCliente.AgregarItem("A", "ACTIVO")
        cmb_StatusCliente.AgregarItem("B", "BAJA")

        cmb_StatusCuenta.AgregarItem("A", "ACTIVO")
        cmb_StatusCuenta.AgregarItem("B", "BAJA")

    End Sub

    Private Sub cmb_Compañia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Compañia.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
        If cmb_CajaBancaria.SelectedValue = 0 Or cmb_Compañia.SelectedValue = 0 Then Exit Sub
        ActualizarClientes()
    End Sub

    Private Sub ActualizarClientes()
        cmb_Cliente.ActualizaValorParametro("@Id_CajaBancaria", CInt(cmb_CajaBancaria.SelectedValue))
        cmb_Cliente.ActualizaValorParametro("@Id_Cia", cmb_Compañia.SelectedValue)
        cmb_Cliente.ActualizaValorParametro("@Status", "A")
        cmb_Cliente.Actualizar()

        'cmb_Cliente.Enabled = True
        'chk_Cliente.Enabled = True

    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
        If cmb_CajaBancaria.SelectedValue = 0 Or cmb_Compañia.SelectedValue = 0 Then Exit Sub
        Call ActualizarClientes()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        Dim Titulo As String = Me.Text & "  -  Caja: " & cmb_CajaBancaria.Text & "  -  Cia Traslado: " & IIf(chk_Cliente.Checked, "Todas", cmb_Compañia.Text) & "  -  Cliente: " & IIf(chk_Cliente.Checked, "Todos", cmb_Cliente.Text) & "  -  Status: " & IIf(chk_StatusCuenta.Checked, "Todos", cmb_StatusCuenta.Text)
        fn_Exportar_Excel(lsv_Consulta, 2, Titulo, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Mostar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostar.Click
        Call LimpiarLista()
        If Validar() = False Then Exit Sub

        If fn_CuentasPorCliente_LlenarLista(lsv_Consulta, cmb_CajaBancaria.SelectedValue, IIf(chk_Compañia.Checked, 0, cmb_Compañia.SelectedValue), IIf(chk_Cliente.Checked, 0, cmb_Cliente.SelectedValue), IIf(chk_StatusCliente.Checked, "T", cmb_StatusCliente.SelectedValue), IIf(chk_StatusCuenta.Checked, "T", cmb_StatusCuenta.SelectedValue)) = False Then
            MsgBox("Ocurrió un error al intentar cargar los Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Consulta.Items.Count
        btn_Exportar.Enabled = True
    End Sub

    Private Function Validar() As Boolean

        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Compañia.SelectedValue = 0 And chk_Compañia.Checked = False Then
            MsgBox("Seleccione una Compañia o marque la casilla «Todas»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Compañia.Focus()
            Return False
        End If

        If cmb_Cliente.SelectedValue = 0 And chk_Cliente.Checked = False Then
            MsgBox("Seleccione un Cliente o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Return False
        End If

        If cmb_StatusCliente.SelectedValue = "0" And chk_StatusCliente.Checked = False Then
            MsgBox("Seleccione un Status de Cliente o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_StatusCliente.Focus()
            Return False
        End If

        If cmb_StatusCuenta.SelectedValue = "0" And chk_StatusCuenta.Checked = False Then
            MsgBox("Seleccione un Status de Cuenta o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_StatusCuenta.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarLista()
        SegundosDesconexion = 0

        lsv_Consulta.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Exportar.Enabled = False
    End Sub

    Private Sub chk_Compañia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Compañia.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
        If chk_Compañia.Checked Then
            cmb_Compañia.SelectedValue = 0
            cmb_Compañia.Enabled = False
            chk_Cliente.Checked = True
            chk_Cliente.Enabled = False
            cmb_Cliente.Enabled = False
        Else
            cmb_Compañia.Enabled = True
            chk_Cliente.Checked = False
            chk_Cliente.Enabled = True
        End If
    End Sub

    Private Sub chk_Cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cliente.CheckedChanged
        Call LimpiarLista()
        If chk_Cliente.Checked Then
            cmb_Cliente.SelectedValue = 0
            cmb_Cliente.Enabled = False
        Else
            cmb_Cliente.Enabled = True
        End If
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_StatusCuenta.CheckedChanged
        Call LimpiarLista()
        cmb_StatusCuenta.SelectedValue = 0
        If chk_StatusCuenta.Checked Then
            cmb_StatusCuenta.Enabled = False
        Else
            cmb_StatusCuenta.Enabled = True
        End If
    End Sub

    Private Sub chk_StatusCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_StatusCliente.CheckedChanged
        Call LimpiarLista()
        cmb_StatusCliente.SelectedValue = 0
        If chk_StatusCliente.Checked Then
            cmb_StatusCliente.Enabled = False
        Else
            cmb_StatusCliente.Enabled = True
        End If
    End Sub

    Private Sub cmb_StatusCliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_StatusCliente.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_StatusCuenta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_StatusCuenta.SelectedValueChanged
        Call LimpiarLista()
    End Sub
End Class