Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ClientesHorarios

    Public Id_CS As Integer
    Public Id_Cliente As Integer
    Public Clave_Cliente As String
    Public Clave_Precio As String
    Public Id_PrecioDescripcion As Integer

    Private Sub frm_ClientesModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        rdb_Origen.Checked = True

        Me.Cursor = Cursors.WaitCursor
        'cmb_H_Cliente.AgregaParametro("@Id_Sucursal", -1, 1)
        cmb_H_Cliente.Actualizar()

        BanderA = False 'Para evitar que se ejecuten Eventos al estar cargando los combos

        cmb_DomingoRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_DomingoRutaF.Actualizar()
        cmb_LunesRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_LunesRutaF.Actualizar()
        cmb_MartesRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_MartesRutaF.Actualizar()
        cmb_MiercolesRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_MiercolesRutaF.Actualizar()
        cmb_JuevesRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_JuevesRutaF.Actualizar()
        cmb_ViernesRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_ViernesRutaF.Actualizar()
        cmb_SabadoRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_SabadoRutaF.Actualizar()
        cmb_ResultasRutaF.AgregaParametro("@Tipo", "1", 1)
        cmb_ResultasRutaF.Actualizar()
        cmb_DomingoRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_DomingoRutaE.Actualizar()
        cmb_LunesRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_LunesRutaE.Actualizar()
        cmb_MartesRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_MartesRutaE.Actualizar()
        cmb_MiercolesRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_MiercolesRutaE.Actualizar()
        cmb_JuevesRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_JuevesRutaE.Actualizar()
        cmb_ViernesRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_ViernesRutaE.Actualizar()
        cmb_SabadoRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_SabadoRutaE.Actualizar()
        cmb_ResultasRutaE.AgregaParametro("@Tipo", "1", 1)
        cmb_ResultasRutaE.Actualizar()

        cmb_CargoA.AgregarItem("C", "CONTRATANTE")
        cmb_CargoA.AgregarItem("O", "ORIGEN")
        cmb_CargoA.AgregarItem("D", "DESTINO")

        cmb_FacturarRE.AgregarItem("R", "RECOLECCION")
        cmb_FacturarRE.AgregarItem("E", "ENTREGA")
        cmb_FacturarRE.AgregarItem("RE", "RECOLECCION Y ENTREGA")

        cmb_H_TipoF.AgregarItem("S", "CADA 1 SEMANA")
        cmb_H_TipoF.AgregarItem("Q", "CADA 2 SEMANAS")
        cmb_H_TipoF.AgregarItem("M", "CADA 4 SEMANAS")
        cmb_H_TipoF.SelectedValue = "S"

        'Combos de "Día de Entrega":
        cmb_DomingoE.DataSource = CargarCombos()
        cmb_LunesE.DataSource = CargarCombos()
        cmb_MartesE.DataSource = CargarCombos()
        cmb_MiercolesE.DataSource = CargarCombos()
        cmb_JuevesE.DataSource = CargarCombos()
        cmb_ViernesE.DataSource = CargarCombos()
        cmb_SabadoE.DataSource = CargarCombos()
        cmb_ResultasE.DataSource = CargarCombos()

        'Horarios en Frecuencia
        cmb_DomingoDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_DomingoAF.DataSource = LlenarMinutos_Dt(15)
        cmb_LunesDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_LunesAF.DataSource = LlenarMinutos_Dt(15)
        cmb_MartesDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_MartesAF.DataSource = LlenarMinutos_Dt(15)
        cmb_MiercolesDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_MiercolesAF.DataSource = LlenarMinutos_Dt(15)
        cmb_JuevesDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_JuevesAF.DataSource = LlenarMinutos_Dt(15)
        cmb_ViernesDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_ViernesAF.DataSource = LlenarMinutos_Dt(15)
        cmb_SabadoDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_SabadoAF.DataSource = LlenarMinutos_Dt(15)
        cmb_ResultasDeF.DataSource = LlenarMinutos_Dt(15)
        cmb_ResultasAF.DataSource = LlenarMinutos_Dt(15)

        'Horarios Entrega
        cmb_DomingoDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_DomingoAE.DataSource = LlenarMinutos_Dt(15)
        cmb_LunesDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_LunesAE.DataSource = LlenarMinutos_Dt(15)
        cmb_MartesDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_MartesAE.DataSource = LlenarMinutos_Dt(15)
        cmb_MiercolesDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_MiercolesAE.DataSource = LlenarMinutos_Dt(15)
        cmb_JuevesDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_JuevesAE.DataSource = LlenarMinutos_Dt(15)
        cmb_ViernesDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_ViernesAE.DataSource = LlenarMinutos_Dt(15)
        cmb_SabadoDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_SabadoAE.DataSource = LlenarMinutos_Dt(15)
        cmb_ResultasDeE.DataSource = LlenarMinutos_Dt(15)
        cmb_ResultasAE.DataSource = LlenarMinutos_Dt(15)

        cmb_DomingoEsc.AgregarItem("S", "SI")
        cmb_DomingoEsc.AgregarItem("N", "NO")
        cmb_LunesEsc.AgregarItem("S", "SI")
        cmb_LunesEsc.AgregarItem("N", "NO")
        cmb_MartesEsc.AgregarItem("S", "SI")
        cmb_MartesEsc.AgregarItem("N", "NO")
        cmb_MiercolesEsc.AgregarItem("S", "SI")
        cmb_MiercolesEsc.AgregarItem("N", "NO")
        cmb_JuevesEsc.AgregarItem("S", "SI")
        cmb_JuevesEsc.AgregarItem("N", "NO")
        cmb_ViernesEsc.AgregarItem("S", "SI")
        cmb_ViernesEsc.AgregarItem("N", "NO")
        cmb_SabadoEsc.AgregarItem("S", "SI")
        cmb_SabadoEsc.AgregarItem("N", "NO")
        cmb_ResultasEsc.AgregarItem("S", "SI")
        cmb_ResultasEsc.AgregarItem("N", "NO")

        'tbx_H_Cliente.Text = Clave_Cliente
        'Llenar la lista del cliente con subclientes.
        If Not fn_SubClienteServicios_LlenarLista(Id_Cliente, Id_PrecioDescripcion, Clave_Precio, "S", lsv_Clientes) Then
            MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Llenar la lista de horarios temporales.
        If Not fn_Clientes_LlenarLista_HorariosTemporales(Id_Cliente, Clave_Cliente, Id_CS, lsv_HorariosTemp) Then
            MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Llenar la lista de horarios reales.
        If Not fn_Clientes_LlenarLista_HorariosReales(Id_Cliente, Clave_Cliente, Id_CS, lsv_HorariosReal) Then
            MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        BanderA = True 'Para evitar que se ejecuten Eventos al estar cargando los combos
        Me.Cursor = Cursors.Default
    End Sub

#Region "SUB's"

    Private Function CargarCombos() As DataTable
        Dim dt_Dias As New DataTable
        dt_Dias.Columns.Add("value")
        dt_Dias.Columns.Add("display")
        dt_Dias.Rows.Add(0, "Seleccione...")
        dt_Dias.Rows.Add(1, "DOMINGO")
        dt_Dias.Rows.Add(2, "LUNES")
        dt_Dias.Rows.Add(3, "MARTES")
        dt_Dias.Rows.Add(4, "MIERCOLES")
        dt_Dias.Rows.Add(5, "JUEVES")
        dt_Dias.Rows.Add(6, "VIERNES")
        dt_Dias.Rows.Add(7, "SABADO")
        Return dt_Dias
    End Function

    Sub Enable_Combos(ByVal chk As CheckBox, ByVal cmb_DeF As cp_cmb_Manual, ByVal cmb_AF As cp_cmb_Manual, ByVal cmb_RutaF As cp_cmb_SimpleFiltradoParam, _
                      ByVal cmb_Ent As cp_cmb_Manual, ByVal cmb_DeE As cp_cmb_Manual, ByVal cmb_AE As cp_cmb_Manual, ByVal cmb_EscE As cp_cmb_Manual, _
                      ByVal cmb_RutaE As cp_cmb_SimpleFiltradoParam, ByVal lbl_Flecha As Label, ByVal lbl_A As Label)
        cmb_DeF.SelectedValue = 0
        cmb_AF.SelectedValue = 0
        cmb_RutaF.SelectedValue = 0
        cmb_DeE.SelectedValue = 0
        cmb_AE.SelectedValue = 0
        cmb_EscE.SelectedValue = 0
        cmb_RutaE.SelectedValue = 0
        cmb_DeF.Enabled = chk.Checked
        cmb_AF.Enabled = chk.Checked
        cmb_RutaE.Enabled = chk.Checked
        cmb_DeE.Enabled = chk.Checked
        cmb_AE.Enabled = chk.Checked
        cmb_EscE.Enabled = chk.Checked
        cmb_RutaF.Enabled = chk.Checked
        lbl_Flecha.Visible = chk.Checked
        lbl_A.Visible = chk.Checked

        If chk.Checked Then
            cmb_Ent.Enabled = True
            Select Case chk.Text.ToUpper
                Case "DOMINGO", "LUNES", "MARTES", "JUEVES", "VIERNES"
                    cmb_Ent.Text = chk.Text.ToUpper

                Case "MIÉRCOLES"
                    cmb_Ent.SelectedValue = 4

                Case "SÁBADO"
                    cmb_Ent.SelectedValue = 7

                Case "RESULTAS"
                    cmb_Ent.SelectedValue = 0

            End Select
        Else
            cmb_Ent.SelectedValue = 0
            cmb_Ent.Enabled = False
        End If
    End Sub

    Sub SelectedValue_CombosFrecuencia(ByVal cmb_DeF As cp_cmb_Manual, ByVal cmb_AF As cp_cmb_Manual)
        If cmb_DeF.SelectedIndex = 0 Then
            cmb_AF.SelectedIndex = 0
        ElseIf cmb_DeF.SelectedIndex = cmb_AF.Items.Count - 1 Then
            cmb_AF.SelectedIndex = 1
        Else
            cmb_AF.SelectedIndex = cmb_DeF.SelectedIndex + 1
        End If
    End Sub

    Sub SelectedValue_CombosEntrega(ByVal cmb_DeE As cp_cmb_Manual, ByVal cmb_AE As cp_cmb_Manual)
        If cmb_DeE.SelectedIndex = 0 Then
            cmb_AE.SelectedIndex = 0
        ElseIf cmb_DeE.SelectedIndex = cmb_AE.Items.Count - 1 Then
            cmb_AE.SelectedIndex = 1
        Else
            cmb_AE.SelectedIndex = cmb_DeE.SelectedIndex + 1
        End If
    End Sub

    Private Function ValidaCampos(ByVal Dia As String, ByVal cmb_DeF As cp_cmb_Manual, ByVal cmb_AF As cp_cmb_Manual, ByVal cmb_Ent As cp_cmb_Manual, ByVal cmb_DeE As cp_cmb_Manual, ByVal cmb_AE As cp_cmb_Manual, ByVal cmb_Esc As cp_cmb_Manual) As Boolean
        If cmb_DeF.SelectedValue = "0" OrElse cmb_AF.SelectedValue = "0" Then
            MsgBox("Seleccione un Horario de Recolección para el día: " & Dia & ".", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_DeF.Focus()
            Return False
        End If

        If cmb_Ent.SelectedValue = "0" Then
            MsgBox("Seleccione el Día de Entrega para el día: " & Dia & ".", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ent.Focus()
            Return False
        End If

        If cmb_DeE.SelectedValue = "0" OrElse cmb_AF.SelectedValue = "0" Then
            MsgBox("Seleccione una Horario de Entrega para el día: " & Dia & ".", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_DeE.Focus()
            Return False
        End If

        If cmb_Esc.SelectedValue = "0" Then
            MsgBox("Seleccione hará o no Escala en Bóveda para el día: " & Dia & ".", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_Esc.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Private Sub rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Origen.CheckedChanged, rdb_Destino.CheckedChanged
        SegundosDesconexion = 0
        If rdb_Destino.Checked = True Then
            lbl_Nota.Text = "Estos clientes seran el ORIGEN."
        Else
            lbl_Nota.Text = "Estos clientes seran los DESTINOS."
        End If

    End Sub

    Private Sub dtp_H_FechaInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_H_FechaInicio.KeyPress
        If Asc(e.KeyChar) = 13 Then tbx_H_Cliente.Focus()
    End Sub

    Private Sub btn_H_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_H_Buscar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Id_Sucursal = SucursalId
        frm.ShowDialog()
        tbx_H_Cliente.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CapturarDestino
        frm.ShowDialog()
        'cmb_H_Cliente.ActualizaValorParametro("@Id_Sucursal", cmb_Sucursal.SelectedValue)
        cmb_H_Cliente.Actualizar()
        cmb_H_Cliente.SelectedValue = frm.Id_Cliente
        frm.Dispose()
    End Sub

    Private Sub chk_DiasFrecuencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DomingoF.CheckedChanged, chk_LunesF.CheckedChanged, chk_MartesF.CheckedChanged, chk_MiercolesF.CheckedChanged, chk_JuevesF.CheckedChanged, chk_ViernesF.CheckedChanged, chk_SabadoF.CheckedChanged, chk_ResultasF.CheckedChanged
        SegundosDesconexion = 0

        Select Case sender.Name
            Case chk_DomingoF.Name
                Call Enable_Combos(chk_DomingoF, cmb_DomingoDeF, cmb_DomingoAF, cmb_DomingoRutaF, cmb_DomingoE, cmb_DomingoDeE, _
                                  cmb_DomingoAE, cmb_DomingoEsc, cmb_DomingoRutaE, lbl_DomingoFlecha, lbl_DomingoA)
                If sender.Checked Then chk_ResultasF.Checked = False

            Case chk_LunesF.Name
                Call Enable_Combos(chk_LunesF, cmb_LunesDeF, cmb_LunesAF, cmb_LunesRutaF, cmb_LunesE, cmb_LunesDeE, cmb_LunesAE, _
                                  cmb_LunesEsc, cmb_LunesRutaE, lbl_LunesFlecha, lbl_LunesA)
                If sender.Checked Then chk_ResultasF.Checked = False

            Case chk_MartesF.Name
                Call Enable_Combos(chk_MartesF, cmb_MartesDeF, cmb_MartesAF, cmb_MartesRutaF, cmb_MartesE, cmb_MartesDeE, _
                                  cmb_MartesAE, cmb_MartesEsc, cmb_MartesRutaE, lbl_MartesFlecha, lbl_MartesA)
                If sender.Checked Then chk_ResultasF.Checked = False

            Case chk_MiercolesF.Name
                Call Enable_Combos(chk_MiercolesF, cmb_MiercolesDeF, cmb_MiercolesAF, cmb_MiercolesRutaF, cmb_MiercolesE, cmb_MiercolesDeE, _
                                  cmb_MiercolesAE, cmb_MiercolesEsc, cmb_MiercolesRutaE, lbl_MiercolesFlecha, lbl_MiercolesA)
                If sender.Checked Then chk_ResultasF.Checked = False

            Case chk_JuevesF.Name
                Call Enable_Combos(chk_JuevesF, cmb_JuevesDeF, cmb_JuevesAF, cmb_JuevesRutaF, cmb_JuevesE, cmb_JuevesDeE, _
                                  cmb_JuevesAE, cmb_JuevesEsc, cmb_JuevesRutaE, lbl_JuevesFlecha, lbl_JuevesA)
                If sender.Checked Then chk_ResultasF.Checked = False

            Case chk_ViernesF.Name
                Call Enable_Combos(chk_ViernesF, cmb_ViernesDeF, cmb_ViernesAF, cmb_ViernesRutaF, cmb_ViernesE, cmb_ViernesDeE, _
                                  cmb_ViernesAE, cmb_ViernesEsc, cmb_ViernesRutaE, lbl_ViernesFlecha, lbl_ViernesA)
                If sender.Checked Then chk_ResultasF.Checked = False
            Case chk_SabadoF.Name
                Call Enable_Combos(chk_SabadoF, cmb_SabadoDeF, cmb_SabadoAF, cmb_SabadoRutaF, cmb_SabadoE, cmb_SabadoDeE, _
                                  cmb_SabadoAE, cmb_SabadoEsc, cmb_SabadoRutaE, lbl_SabadoFlecha, lbl_SabadoA)
                If sender.Checked Then chk_ResultasF.Checked = False

            Case chk_ResultasF.Name
                Call Enable_Combos(chk_ResultasF, cmb_ResultasDeF, cmb_ResultasAF, cmb_ResultasRutaF, cmb_ResultasE, cmb_ResultasDeE, _
                                  cmb_ResultasAE, cmb_ResultasEsc, cmb_ResultasRutaE, lbl_ResultasFlecha, lbl_ResultasA)
                If sender.Checked Then
                    chk_DomingoF.Checked = False
                    chk_LunesF.Checked = False
                    chk_MartesF.Checked = False
                    chk_MiercolesF.Checked = False
                    chk_JuevesF.Checked = False
                    chk_ViernesF.Checked = False
                    chk_SabadoF.Checked = False
                End If

        End Select
    End Sub

    Private Sub cmb_DiasDe_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DomingoDeF.SelectedValueChanged, cmb_LunesDeF.SelectedValueChanged, _
                                                                                                                    cmb_MartesDeF.SelectedValueChanged, cmb_MiercolesDeF.SelectedValueChanged, _
                                                                                                                    cmb_JuevesDeF.SelectedValueChanged, cmb_ViernesDeF.SelectedValueChanged, _
                                                                                                                    cmb_SabadoDeF.SelectedValueChanged, cmb_ResultasDeF.SelectedValueChanged, _
                                                                                                                    cmb_DomingoDeE.SelectedValueChanged, cmb_LunesDeE.SelectedValueChanged, _
                                                                                                                    cmb_MartesDeE.SelectedValueChanged, cmb_MiercolesDeE.SelectedValueChanged, _
                                                                                                                    cmb_JuevesDeE.SelectedValueChanged, cmb_ViernesDeE.SelectedValueChanged, _
                                                                                                                    cmb_SabadoDeE.SelectedValueChanged, cmb_ResultasDeE.SelectedValueChanged
        SegundosDesconexion = 0
        If Not BanderA Then Exit Sub

        Select Case sender.Name
            Case cmb_DomingoDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_DomingoDeF, cmb_DomingoAF)

            Case cmb_LunesDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_LunesDeF, cmb_LunesAF)

            Case cmb_MartesDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_MartesDeF, cmb_MartesAF)

            Case cmb_MiercolesDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_MiercolesDeF, cmb_MiercolesAF)

            Case cmb_JuevesDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_JuevesDeF, cmb_JuevesAF)

            Case cmb_ViernesDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_ViernesDeF, cmb_ViernesAF)

            Case cmb_SabadoDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_SabadoDeF, cmb_SabadoAF)

            Case cmb_ResultasDeF.Name
                Call SelectedValue_CombosFrecuencia(cmb_ResultasDeF, cmb_ResultasAF)

            Case cmb_DomingoDeE.Name
                Call SelectedValue_CombosEntrega(cmb_DomingoDeE, cmb_DomingoAE)

            Case cmb_LunesDeE.Name
                Call SelectedValue_CombosEntrega(cmb_LunesDeE, cmb_LunesAE)

            Case cmb_MartesDeE.Name
                Call SelectedValue_CombosEntrega(cmb_MartesDeE, cmb_MartesAE)

            Case cmb_MiercolesDeE.Name
                Call SelectedValue_CombosEntrega(cmb_MiercolesDeE, cmb_MiercolesAE)

            Case cmb_JuevesDeE.Name
                Call SelectedValue_CombosEntrega(cmb_JuevesDeE, cmb_JuevesAE)

            Case cmb_ViernesDeE.Name
                Call SelectedValue_CombosEntrega(cmb_ViernesDeE, cmb_ViernesAE)

            Case cmb_SabadoDeE.Name
                Call SelectedValue_CombosEntrega(cmb_SabadoDeE, cmb_SabadoAE)

            Case cmb_ResultasDeE.Name
                Call SelectedValue_CombosEntrega(cmb_ResultasDeE, cmb_ResultasAE)

        End Select
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        For Each Item As ListViewItem In lsv_Clientes.Items
            Item.Checked = chk_Todos.Checked
        Next
    End Sub

    Private Sub lsv_Clientes_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Clientes.ItemChecked
        SegundosDesconexion = 0

        Btn_GuardarH.Enabled = lsv_Clientes.CheckedItems.Count > 0
    End Sub

    Private Sub Btn_GuardarH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GuardarH.Click
        SegundosDesconexion = 0

        If Not rdb_Origen.Checked AndAlso Not rdb_Destino.Checked Then
            MsgBox("Seleccione si el Cliente será Origen o Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If cmb_H_Cliente.SelectedValue = "0" OrElse cmb_H_Cliente.SelectedValue = Nothing Then
            If rdb_Origen.Checked Then
                MsgBox("Seleccione el Cliente Origen", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                MsgBox("Seleccione el Cliente Destino", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            cmb_H_Cliente.Focus()
            Exit Sub
        End If

        'If cmb_H_TipoF.SelectedValue = "0" Then
        '    MsgBox("Seleccione el Tipo de Frecuencia.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    cmb_H_TipoF.Focus()
        '    Exit Sub
        'End If

        If Not chk_DomingoF.Checked AndAlso Not chk_LunesF.Checked AndAlso Not chk_MartesF.Checked AndAlso Not chk_MiercolesF.Checked AndAlso _
           Not chk_JuevesF.Checked AndAlso Not chk_ViernesF.Checked AndAlso Not chk_SabadoF.Checked Then
            If Not chk_ResultasF.Checked Then
                MsgBox("Seleccione la Frecuencia del Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        'Revisar que esten todos los campos correctos para cada día marcado
        If chk_DomingoF.Checked AndAlso Not ValidaCampos(chk_DomingoF.Text, cmb_DomingoDeF, cmb_DomingoAF, cmb_DomingoE, cmb_DomingoDeE, cmb_DomingoAE, cmb_DomingoEsc) Then Exit Sub
        If chk_LunesF.Checked AndAlso Not ValidaCampos(chk_LunesF.Text, cmb_LunesDeF, cmb_LunesAF, cmb_LunesE, cmb_LunesDeE, cmb_LunesAE, cmb_LunesEsc) Then Exit Sub
        If chk_MartesF.Checked AndAlso Not ValidaCampos(chk_MartesF.Text, cmb_MartesDeF, cmb_MartesAF, cmb_MartesE, cmb_MartesDeE, cmb_MartesAE, cmb_MartesEsc) Then Exit Sub
        If chk_MiercolesF.Checked AndAlso Not ValidaCampos(chk_MiercolesF.Text, cmb_MiercolesDeF, cmb_MiercolesAF, cmb_MiercolesE, cmb_MiercolesDeE, cmb_MiercolesAE, cmb_MiercolesEsc) Then Exit Sub
        If chk_JuevesF.Checked AndAlso Not ValidaCampos(chk_JuevesF.Text, cmb_JuevesDeF, cmb_JuevesAF, cmb_JuevesE, cmb_JuevesDeE, cmb_JuevesAE, cmb_JuevesEsc) Then Exit Sub
        If chk_ViernesF.Checked AndAlso Not ValidaCampos(chk_ViernesF.Text, cmb_ViernesDeF, cmb_ViernesAF, cmb_ViernesE, cmb_ViernesDeE, cmb_ViernesAE, cmb_ViernesEsc) Then Exit Sub
        If chk_SabadoF.Checked AndAlso Not ValidaCampos(chk_SabadoF.Text, cmb_SabadoDeF, cmb_SabadoAF, cmb_SabadoE, cmb_SabadoDeE, cmb_SabadoAE, cmb_SabadoEsc) Then Exit Sub
        If chk_ResultasF.Checked AndAlso Not ValidaCampos(chk_ResultasF.Text, cmb_ResultasDeF, cmb_ResultasAF, cmb_ResultasE, cmb_ResultasDeE, cmb_ResultasAE, cmb_ResultasEsc) Then Exit Sub

        If cmb_CargoA.SelectedValue = "0" Then
            MsgBox("Seleccione la instancia de pago.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CargoA.Focus()
            Exit Sub
        End If

        If cmb_FacturarRE.SelectedValue = "0" Then
            MsgBox("Seleccione el concepto a cobrar.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_FacturarRE.Focus()
            Exit Sub
        End If

        Dim MismoDia As Char
        Dim Unicavez As Char = "N"
        If chk_UnicaVez.Checked Then Unicavez = "S"

        Dim Dt_Datos As New DataTable
        Dt_Datos.Columns.Add("Frecuencia")
        Dt_Datos.Columns.Add("H_Recoleccion")
        Dt_Datos.Columns.Add("Id_RutaF")
        Dt_Datos.Columns.Add("Dia_Entrega")
        Dt_Datos.Columns.Add("H_Entrega")
        Dt_Datos.Columns.Add("Escala_Boveda")
        Dt_Datos.Columns.Add("Id_RutaE")
        Dt_Datos.Columns.Add("Mismo_Dia")

        'Llenar la tabla
        MismoDia = "N"
        If chk_DomingoF.Checked Then
            If cmb_DomingoE.SelectedValue = 1 Then MismoDia = "S"
            Dt_Datos.Rows.Add(1, cmb_DomingoDeF.Text & "/" & cmb_DomingoAF.Text, cmb_DomingoRutaF.SelectedValue, _
                              cmb_DomingoE.SelectedValue, cmb_DomingoDeE.Text & "/" & cmb_DomingoAE.Text, _
                              cmb_DomingoEsc.SelectedValue, cmb_DomingoRutaE.SelectedValue, MismoDia)
        End If
        If chk_LunesF.Checked Then
            If cmb_LunesE.SelectedValue = 2 Then MismoDia = "S"
            Dt_Datos.Rows.Add(2, cmb_LunesDeF.Text & "/" & cmb_LunesAF.Text, cmb_LunesRutaF.SelectedValue, _
                              cmb_LunesE.SelectedValue, cmb_LunesDeE.Text & "/" & cmb_LunesAE.Text, _
                              cmb_LunesEsc.SelectedValue, cmb_LunesRutaE.SelectedValue, MismoDia)
        End If
        If chk_MartesF.Checked Then
            If cmb_MartesE.SelectedValue = 3 Then MismoDia = "S"
            Dt_Datos.Rows.Add(3, cmb_MartesDeF.Text & "/" & cmb_MartesAF.Text, cmb_MartesRutaF.SelectedValue, _
                              cmb_MartesE.SelectedValue, cmb_MartesDeE.Text & "/" & cmb_MartesAE.Text, _
                              cmb_MartesEsc.SelectedValue, cmb_MartesRutaE.SelectedValue, MismoDia)
        End If
        If chk_MiercolesF.Checked Then
            If cmb_MiercolesE.SelectedValue = 4 Then MismoDia = "S"
            Dt_Datos.Rows.Add(4, cmb_MiercolesDeF.Text & "/" & cmb_MiercolesAF.Text, cmb_MiercolesRutaF.SelectedValue, _
                              cmb_MiercolesE.SelectedValue, cmb_MiercolesDeE.Text & "/" & cmb_MiercolesAE.Text, _
                              cmb_MiercolesEsc.SelectedValue, cmb_MiercolesRutaE.SelectedValue, MismoDia)
        End If
        If chk_JuevesF.Checked Then
            If cmb_JuevesE.SelectedValue = 5 Then MismoDia = "S"
            Dt_Datos.Rows.Add(5, cmb_JuevesDeF.Text & "/" & cmb_JuevesAF.Text, cmb_JuevesRutaF.SelectedValue, _
                                                       cmb_JuevesE.SelectedValue, cmb_JuevesDeE.Text & "/" & cmb_JuevesAE.Text, _
                                                       cmb_JuevesEsc.SelectedValue, cmb_JuevesRutaE.SelectedValue, MismoDia)
        End If
        If chk_ViernesF.Checked Then
            If cmb_ViernesE.SelectedValue = 6 Then MismoDia = "S"
            Dt_Datos.Rows.Add(6, cmb_ViernesDeF.Text & "/" & cmb_ViernesAF.Text, cmb_ViernesRutaF.SelectedValue, _
                              cmb_ViernesE.SelectedValue, cmb_ViernesDeE.Text & "/" & cmb_ViernesAE.Text, _
                              cmb_ViernesEsc.SelectedValue, cmb_ViernesRutaE.SelectedValue, MismoDia)
        End If
        If chk_SabadoF.Checked Then
            If cmb_SabadoE.SelectedValue = 7 Then MismoDia = "S"
            Dt_Datos.Rows.Add(7, cmb_SabadoDeF.Text & "/" & cmb_SabadoAF.Text, cmb_SabadoRutaF.SelectedValue, _
                                                       cmb_SabadoE.SelectedValue, cmb_SabadoDeE.Text & "/" & cmb_SabadoAE.Text, _
                                                       cmb_SabadoEsc.SelectedValue, cmb_SabadoRutaE.SelectedValue, MismoDia)
        End If
        If chk_ResultasF.Checked Then
            If cmb_ResultasE.SelectedValue = 8 Then MismoDia = "S"
            Dt_Datos.Rows.Add(8, cmb_ResultasDeF.Text & "/" & cmb_ResultasAF.Text, cmb_ResultasRutaF.SelectedValue, _
                                                       cmb_ResultasE.SelectedValue, cmb_ResultasDeE.Text & "/" & cmb_ResultasAE.Text, _
                                                       cmb_ResultasEsc.SelectedValue, cmb_ResultasRutaE.SelectedValue, MismoDia)
        End If

        If rdb_Origen.Checked Then
            If MsgBox("Los Clientes seleccionados de la lista tendrán Horarios de Entrega siendo el Cliente Origen: " & _
                      cmb_H_Cliente.Text & "," & Chr(13) & "Seguro que desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            If MsgBox("Los Clientes seleccionados de la lista tendrán Horarios de Recolección siendo el Cliente Destino: " & _
                      cmb_H_Cliente.Text & "," & Chr(13) & "Seguro que desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        'Horario Nuevo. Insert en Horario Temp
        If fn_Horarios_CrearVarios(dtp_H_FechaInicio.Value, cmb_H_Cliente.SelectedValue, rdb_Origen.Checked, _
                                   cmb_H_TipoF.SelectedValue, cmb_FacturarRE.SelectedValue, _
                                   cmb_CargoA.SelectedValue, Unicavez, Dt_Datos, lsv_Clientes) Then
            MsgBox("Se guardarón los Horarios correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Me.Close()
        Else
            MsgBox("No se pudo guardar los Horarios.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Btn_CancelarH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CancelarH.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ayuda.Click
        Dim frm As New frm_Ayuda
        'Cuando exista un Horario Activo se insertará como Horario Temporal para su validación, tanto como el Cliente Principal como sus Sucursales.
        frm.rtb_Ayuda.Text = "Detalles Generales:" & Chr(13) & Chr(13) & _
                             " 1. Sólo se utilizará esta ventana para agregar Horarios." & Chr(13) & _
                             " 2. Ingresar los Datos Obligatorios (los que están marcados con un Asterisco)." & Chr(13) & _
                             " 3. Seguir el Orden de captura de arriba hacia abajo." & Chr(13) & _
                             " 4. El Cliente que estamos editando, es decir, el cliente padre será" & Chr(13) & _
                             "    puesto como Cliente Origen automáticamente." & Chr(13) & _
                             " 5. Cada Frecuencia marcada requiere los siguiente datos obligatorios:" & Chr(13) & _
                             "        I. El Horario de Recolección. ('De' y 'A')." & Chr(13) & _
                             "       II. El Día de Entrega." & Chr(13) & _
                             "      III. El Horario de Entrega. ('De' y 'A')" & Chr(13) & _
                             "       IV. Si se hará o no Escala en Bóveda." & Chr(13) & _
                             " 6. La informacón de la Ruta, tanto de Recolección como Entrega no son Requeridas." & Chr(13) & _
                             " 7. Se muestran 3 pestañas en donde cada una contiene:" & Chr(13) & _
                             "        I. Clientes: muestra todos los Clientes que tengan coincidencia con" & Chr(13) & _
                             "           el Servicio seleccionado." & Chr(13) & _
                             "       II. Horarios Pendientes: se enlistan los Clientes y la información de Horarios Pendientes que" & Chr(13) & _
                             "           tengan coincidencia con el Servicio seleccionado. (sólo con fines informativos)" & Chr(13) & _
                             "      III. Horarios Activos: se enlistan los Clientes y la información de Horarios Activos que" & Chr(13) & _
                             "           tengan coincidencia con el Servicio seleccionado. (sólo con fines informativos)" & Chr(13) & _
                             "       IV. Si se hará o no Escala en Bóveda." & Chr(13) & _
                             " 8. De la Lista de Clientes se deberán marcar los Clientes que se les creará Horarios Nuevos." & Chr(13)
        frm.Size = New Size(770, 380)
        frm.Show()
    End Sub

    Private Sub gbx_RecoEntrega_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_RecoEntrega.Enter

    End Sub
End Class