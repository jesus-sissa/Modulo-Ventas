Public Class frm_Kardex


    Private Sub frm_Kardex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsv_Caset.Columns.Add("Codigo Caset")
        lsv_Caset.Columns.Add("Codigo Barra")
        lsv_Caset.Columns.Add("Cliente")
        lsv_Caset.Columns.Add("Serie")
        lsv_Caset.Columns.Add("Descripcion")
        lsv_Caset.Columns.Add("Capacidad")
        lsv_Caset.Columns.Add("Caset SISSA")

        cmb_Color.AgregaParametro("@Status", "A", 0)
        cmb_Color.Actualizar()


        cmb_Cliente.Actualizar()
        cmb_Cliente.Enabled = False

        cmb_Status.AgregarItem("A", "ACTIVO")
        cmb_Status.AgregarItem("B", "BAJA")
        cmb_Status.SelectedValue = "A"

        rdb_NO.Checked = True

        Call LlenarLista()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not validar() Then
            Exit Sub
        End If

        If tab_Nuevo.Text = "Nuevo" Then
            If Cn_Clientes.fn_Kardex_Caset_Read(tbx_CodigoBarra.Text) Then
                MsgBox("El código de Barra YA EXISTE!!!.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_CodigoBarra.Focus()
                Exit Sub
            End If
        End If

        If tab_Nuevo.Text = "Nuevo" Then
            If Not Cn_Clientes.fn_Kardex_Caset_Insert(tbx_CodigoBarra.Text.Trim, tbx_Capacidad.Text, cmb_Cliente.SelectedValue, tbx_Serie.Text, cmb_Color.SelectedValue, If(rdb_Si.Checked, "S", "N")) Then
                MsgBox("Ocurrió un error al guardar! Reportar a sistemas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

        ElseIf tab_Nuevo.Text = "Modificar" Then

            If Not Cn_Clientes.fn_kardex_Caset_update(lsv_Caset.SelectedItems(0).Tag, tbx_Capacidad.Text, tbx_Serie.Text, cmb_Color.SelectedValue) Then
                MsgBox("Ocurrió un error al intentar modificar los registros.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

        End If

        MsgBox("Se guardo con exito.", MsgBoxStyle.Information, frm_MENU.Text)
        tab_Nuevo.Text = "Nuevo"
        LimpiarControles()
        
    End Sub

    Function validar()
        

        If tbx_CodigoBarra.Text = "" Then

            MsgBox("Capture el codigo de Barra.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CodigoBarra.Focus()
            Return False
        End If

        If Not rdb_Si.Checked Then
            If cmb_Cliente.SelectedValue = 0 Then
                MsgBox("Cliente no valido.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        End If
        
        If tbx_Serie.Text = "" Then
            MsgBox("Capture la Serie.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Serie.Focus()
            Return False
        End If

        If tbx_Capacidad.Text = "" Then
            MsgBox("Capture la Capacidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Capacidad.Focus()
            Return False
        End If

        If Not IsNumeric(tbx_Capacidad.Text) Then
            MsgBox("Data no valido en Capacidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Capacidad.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub lsv_Caset_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Caset.SelectedIndexChanged
        SegundosDesconexion = 0
        'Aqui se desactivan los botones de edicion
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        If lsv_Caset.SelectedItems.Count = 0 Then Exit Sub
        If lsv_Caset.SelectedItems(0).SubItems(6).Text <> "BAJA" Then
            Btn_Baja.Enabled = True
        End If
        BTN_Modificar.Enabled = lsv_Caset.SelectedItems.Count > 0
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        lsv_Caset.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        BTN_Exportar.Enabled = False

        If Not Cn_Clientes.fn_kardex_Catalogo_LlenarLista(lsv_Caset, cmb_Status.SelectedValue) Then
            MsgBox("Ocurrió un error al cargar la Lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_Registros.Text = "Registros: '" & lsv_Caset.Items.Count & "'"

    End Sub

    'Sub Buscar()
    '    SegundosDesconexion = 0

    '    Dim Fila_Inicio As Integer = 0
    '    If lsv_Caset.SelectedItems.Count > 0 Then
    '        Fila_Inicio = lsv_Caset.SelectedItems(0).Index + 1
    '    End If
    '    If FuncionesGlobales.fn_Buscar_enListView(lsv_Caset, tbx_Buscar.Text, 0, Fila_Inicio) Then
    '        Btn_Baja.Enabled = True
    '        BTN_Modificar.Enabled = True
    '    Else
    '        Btn_Baja.Enabled = True
    '        BTN_Modificar.Enabled = True
    '    End If
    'End Sub



    Private Sub Btn_Baja_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0
        If lsv_Caset.Items.Count = 0 Then Exit Sub
        If Not Cn_Clientes.fn_kardex_Caset_Baja(lsv_Caset.SelectedItems(0).Tag, lsv_Caset.SelectedItems(0).SubItems(5).Text) Then
            MsgBox("Ocurrió un error al intentar dar baja Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LlenarLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call LlenarLista()
    End Sub


    Private Sub tbx_CodigoBarra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_CodigoBarra.TextChanged
        If tbx_CodigoBarra.Text = "" Or tbx_CodigoBarra.Text.Length < 6 Then Exit Sub
        Dim elementos As String() = tbx_CodigoBarra.Text.Split("'")
        cmb_Cliente.SelectedValue = elementos(1)
    End Sub


    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click
        Tab_Cartuchos.SelectedTab = tab_Nuevo
        tab_Nuevo.Text = "Modificar"
        tbx_CodigoBarra.Text = lsv_Caset.SelectedItems(0).Text
        tbx_CodigoBarra.Enabled = False
        tbx_Serie.Text = lsv_Caset.SelectedItems(0).SubItems(1).Text
        cmb_Cliente.SelectedValue = lsv_Caset.SelectedItems(0).SubItems(8).Text
        tbx_Capacidad.Text = lsv_Caset.SelectedItems(0).SubItems(3).Text
        ''cmb_Color.SelectedValue = lsv_Caset.SelectedItems(0).SubItems(6).Text
        If lsv_Caset.SelectedItems(0).SubItems(3).Text = "S" Then
            rdb_Si.Checked = True
            rdb_NO.Enabled = False
            rdb_Si.Enabled = False
        Else
            rdb_NO.Checked = True
            rdb_NO.Enabled = False
            rdb_Si.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarControles()
        tab_Nuevo.Text = "Nuevo"
        Tab_Cartuchos.SelectedTab = tab_Listado
    End Sub

    Private Sub LimpiarControles()
        tbx_Capacidad.Text = ""
        tbx_CodigoBarra.Text = ""
        tbx_Serie.Text = ""
        cmb_Color.SelectedValue = 0
        cmb_Cliente.SelectedValue = 0
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Caset, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

End Class