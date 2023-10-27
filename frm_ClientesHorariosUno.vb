Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes
Imports System.OperatingSystem

Public Class frm_ClientesHorariosUno

#Region "Variables Publicas"
    Public Id_CS As Integer
    Public Id_Cliente As Integer
    Public Clave_Cliente As String
    Public Clave_Precio As String
    Public Id_PrecioDescripcion As Integer
    Private Prioridad As Integer = 0
    Public Temp As Boolean = True
    Private Dt_SubClientes As New DataTable
    Private FrecuencaAnt As String
#End Region

#Region "Metodos Publicos"

    ''' <summary>
    ''' Limpia los valores de todas las casillas de la pestaña Horarios
    ''' </summary>
    Public Sub Horarios_LimpiarCasillas()
        Me.Tag = 0
        cmb_H_Ruta.SelectedValue = 0
        cbx_Permitir.Checked = False
        cmb_H_TipoF.SelectedValue = 0
        cmb_H_Frecuencia.SelectedValue = 0
        dtp_H_FechaInicio.Text = ""
        tbx_H_ClienteO.Text = ""
        cmb_H_ClienteO.SelectedValue = 0
        cmb_H_DeO.SelectedValue = 0
        cmb_H_AO.SelectedValue = 0
        tbx_H_ClienteD.Text = ""
        cmb_H_ClienteD.SelectedValue = 0
        cmb_H_DeD.SelectedValue = 0
        cmb_H_AD.SelectedValue = 0
    End Sub

    Public Sub Actualizar()
        If Not Me.Tag = 0 Then
            Dim Dr_Horarios As DataRow

            If Temp Then
                Dr_Horarios = fn_Horarios_Leer(Me.Tag)
            Else
                Dr_Horarios = fn_Horarios_Leer2(Me.Tag)
            End If

            If Dr_Horarios IsNot Nothing Then
                dtp_H_FechaInicio.Value = Dr_Horarios("Fecha_Inicio")
                cmb_H_TipoF.SelectedValue = Dr_Horarios("Tipo_Frecuencia")
                cmb_H_Frecuencia.SelectedValue = Dr_Horarios("Frecuencia")
                FrecuencaAnt = Dr_Horarios("Frecuencia")
                cmb_H_ClienteO.SelectedValue = Dr_Horarios("Cliente_Origen")
                Dim Rec As Array = Split(Dr_Horarios("H_Recoleccion"), "/")
                cmb_H_DeO.Text = Rec(0)
                cmb_H_AO.Text = Rec(1)
                Rec = Nothing
                cmb_H_ClienteD.SelectedValue = Dr_Horarios("Cliente_Destino")
                Dim Orig As Array = Split(Dr_Horarios("H_Entrega"), "/")
                cmb_H_DeD.Text = Orig(0)
                cmb_H_AD.Text = Orig(1)
                Orig = Nothing
                cmb_H_Ruta.SelectedValue = Dr_Horarios("Id_Ruta")
                cmb_H_MismoDia.SelectedValue = Dr_Horarios("Mismo_Dia")
                cmb_H_Boveda.SelectedValue = Dr_Horarios("Escala_Boveda")
                cmb_H_DiaEntrega.SelectedValue = Dr_Horarios("Dia_Entrega")
                cmb_H_RutaEntrega.SelectedValue = Dr_Horarios("Id_RutaE")
                Prioridad = Dr_Horarios("Prioridad")
                cmb_CargoA.SelectedValue = Dr_Horarios("Cargo_ODC")
                cmb_FacturarRE.SelectedValue = Dr_Horarios("Cobrar_RE")

                If Dr_Horarios("Utiliza_Caset").ToString() = "S" Then
                    rdb_UtilizaCasetSi.Checked = True
                ElseIf Dr_Horarios("Utiliza_Caset").ToString() = "N" Then
                    rdb_UtilizaCasetNO.Checked = True
                End If
                'cmb_NuevoOrigen.SelectedValue = Dr_Horarios("NuevoOrigenCustodia")

            End If
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ClientesHorariosUno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        cmb_H_Ruta.Actualizar()
        cmb_H_RutaEntrega.Actualizar()
        cmb_H_ClienteO.AgregaParametro("@Id_Sucursal", -1, 1)
        cmb_H_ClienteO.Actualizar()
        cmb_H_ClienteD.AgregaParametro("@Id_Sucursal", -1, 1)
        cmb_H_ClienteD.Actualizar()
        cmb_NuevoOrigen.AgregaParametro("@Id_Sucursal", -1, 1)
        cmb_NuevoOrigen.Actualizar()
        cmb_Sucursal1.Actualizar()
        cmb_Sucursal2.Actualizar()
        cmb_Sucursal1.SelectedValue = SucursalId
        cmb_Sucursal2.SelectedValue = SucursalId
        cmb_Sucursal1.Enabled = False
        cmb_Sucursal2.Enabled = False

        cmb_CargoA.AgregarItem("C", "CONTRATANTE")
        cmb_CargoA.AgregarItem("O", "ORIGEN")
        cmb_CargoA.AgregarItem("D", "DESTINO")

        cmb_FacturarRE.AgregarItem("R", "RECOLECCION")
        cmb_FacturarRE.AgregarItem("E", "ENTREGA")
        cmb_FacturarRE.AgregarItem("RE", "RECOLECCION Y ENTREGA")

        '*** Temporalmente solo se dejan servicios semanales porque no se ha definido la forma de manejar
        'los servicios Quincenales o Mensuales
        cmb_H_TipoF.AgregarItem("S", "CADA 1 SEMANA")
        'cmb_H_TipoF.AgregarItem("Q", "CADA 2 SEMANAS")
        'cmb_H_TipoF.AgregarItem("M", "CADA 4 SEMANAS")

        cmb_H_Frecuencia.AgregarItem("1", "DOMINGO")
        cmb_H_Frecuencia.AgregarItem("2", "LUNES")
        cmb_H_Frecuencia.AgregarItem("3", "MARTES")
        cmb_H_Frecuencia.AgregarItem("4", "MIERCOLES")
        cmb_H_Frecuencia.AgregarItem("5", "JUEVES")
        cmb_H_Frecuencia.AgregarItem("6", "VIERNES")
        cmb_H_Frecuencia.AgregarItem("7", "SABADO")
        cmb_H_Frecuencia.AgregarItem("8", "RESULTAS")
        If Me.Tag = 0 Then
            'Cuando sea un nuevo horario se podrán ver las demás opciones
            cmb_H_Frecuencia.AgregarItem("9", "LUNES A VIERNES")
            cmb_H_Frecuencia.AgregarItem("10", "LUNES A DOMINGO")
            cmb_H_Frecuencia.AgregarItem("11", "LUNES A SABADO")
            cmb_H_Frecuencia.AgregarItem("12", "LUNES, MIERCOLES Y VIERNES")
            cmb_H_Frecuencia.AgregarItem("13", "LUNES, JUEVES Y SABADO")
        End If

        Dim Dt_Source As DataTable = LlenarMinutos_Dt(15)
        cmb_H_DeO.DataSource = Dt_Source
        Dt_Source = LlenarMinutos_Dt(15)
        cmb_H_AO.DataSource = Dt_Source
        Dt_Source = LlenarMinutos_Dt(15)
        cmb_H_DeD.DataSource = Dt_Source
        Dt_Source = LlenarMinutos_Dt(15)
        cmb_H_AD.DataSource = Dt_Source
        'Dt_Source = cmb_H_DeO.DataSource
        'cmb_H_DeD.DataSource = Dt_Source
        'cmb_H_AO.DataSource = Dt_Source
        'cmb_H_AD.DataSource = Dt_Source
        'Call LlenarMinutos(15, cmb_H_DeO)
        'Call LlenarMinutos(15, cmb_H_DeD)
        'Call LlenarMinutos(15, cmb_H_AO)
        'Call LlenarMinutos(15, cmb_H_AD)

        cmb_H_Boveda.AgregarItem("S", "SI")
        cmb_H_Boveda.AgregarItem("N", "NO")
        'Dt_Source = cmb_H_Boveda.DataSource
        'cmb_H_MismoDia.DataSource = Dt_Source
        cmb_H_MismoDia.AgregarItem("S", "SI")
        cmb_H_MismoDia.AgregarItem("N", "NO")

        cmb_H_DiaEntrega.AgregarItem("1", "DOMINGO")
        cmb_H_DiaEntrega.AgregarItem("2", "LUNES")
        cmb_H_DiaEntrega.AgregarItem("3", "MARTES")
        cmb_H_DiaEntrega.AgregarItem("4", "MIERCOLES")
        cmb_H_DiaEntrega.AgregarItem("5", "JUEVES")
        cmb_H_DiaEntrega.AgregarItem("6", "VIERNES")
        cmb_H_DiaEntrega.AgregarItem("7", "SABADO")
        cmb_H_DiaEntrega.AgregarItem("13", "SIGUIENTE DIA HABIL")

        If Me.Tag = 0 Then
            Call Horarios_LimpiarCasillas()
            tbx_H_ClienteO.Text = Clave_Cliente
        Else
            Call Actualizar()
        End If

        Dt_SubClientes.Columns.Add("Id_CS", GetType(Integer))
        Dt_SubClientes.Columns.Add("Id_Cliente", GetType(Integer)) '14/05/2014

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmb_H_DeO_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_H_DeO.SelectedIndexChanged
        If cmb_H_DeO.SelectedIndex = 0 Then
            cmb_H_AO.SelectedIndex = 0
        ElseIf cmb_H_DeO.SelectedIndex = cmb_H_DeO.Items.Count - 1 Then
            cmb_H_AO.SelectedIndex = 1
        Else
            cmb_H_AO.SelectedIndex = cmb_H_DeO.SelectedIndex + 1
        End If
    End Sub

    Private Sub cmb_H_DeD_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_H_DeD.SelectedIndexChanged
        If cmb_H_DeD.SelectedIndex = 0 Then
            cmb_H_AD.SelectedIndex = 0
        ElseIf cmb_H_DeD.SelectedIndex = cmb_H_DeD.Items.Count - 1 Then
            cmb_H_AD.SelectedIndex = 1
        Else
            cmb_H_AD.SelectedIndex = cmb_H_DeD.SelectedIndex + 1
        End If
    End Sub

    Private Sub Btn_CancelarH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CancelarH.Click
        SegundosDesconexion = 0

        Call Horarios_LimpiarCasillas()
        Me.Close()
    End Sub

    Private Sub cbx_Permitir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_Permitir.KeyPress
        If Asc(e.KeyChar) = 13 Then cmb_H_TipoF.Focus()
    End Sub

    Private Sub cbx_Permitir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Permitir.CheckedChanged
        SegundosDesconexion = 0

        Dt_SubClientes.Rows.Clear()
        gbx_Subclientes.Enabled = False
        rtb_Subclientes.Text = ""

        If Not cbx_Permitir.Checked Then Exit Sub

        Dim frm As New frm_BuscarSubClientes
        If Temp And CInt(Me.Tag) > 0 Then
            ''Modificar Horarios Temp
            'frm.Consulta = frm_BuscarSubClientes.Query.ModHorariosTemp
            'frm.Id_Padre = Id_Cliente
            'frm.Clave_Padre = Clave_Cliente
            'frm.Id_CS = Id_CS
        ElseIf Temp Then
            'Crear Nuevos Horarios Temp
            frm.Consulta = frm_BuscarSubClientes.Query.ClientesServicios
            frm.Id_Padre = Id_Cliente
            frm.ClavePrecio = Clave_Precio
            frm.Id_PrecioDescripcion = Id_PrecioDescripcion
        Else
            ''Modificando Horarios Reales (será crear Horarios Temp)
            'frm.Consulta = frm_BuscarSubClientes.Query.ModHorariosReal
            'frm.Id_Padre = Id_Cliente
            'frm.Clave_Padre = Clave_Cliente
            'frm.Id_CS = Id_CS
        End If

        frm.ShowDialog()

        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            gbx_Subclientes.Enabled = True
            Dim Dr As DataRow '14/05/2014

            For Each ModalSubClientes As ListViewItem In frm.lsv_Clientes.CheckedItems
                Dr = Dt_SubClientes.NewRow()

                If rtb_Subclientes.Text = "" Then
                    rtb_Subclientes.Text = ModalSubClientes.SubItems(1).Text
                ElseIf InStr(rtb_Subclientes.Text, ModalSubClientes.SubItems(1).Text) = 0 Then
                    'Se revisa que no se haya ya agregado el nombre de un subcliente para no repetir.
                    rtb_Subclientes.Text &= ", " & ModalSubClientes.SubItems(1).Text
                End If

                Dr("Id_CS") = ModalSubClientes.Tag
                Dr("Id_Cliente") = ModalSubClientes.SubItems(6).Text '14/05/2014
                Dt_SubClientes.Rows.Add(Dr)

                'Crear Nuevos Horarios Temp (sub-clientes)
                'Dt_SubClientes.Rows.Add(ModalSubClientes.Tag)
                'Dt_SubClientes.Rows.Add(ModalSubClientes.SubItems(6).Text) '14/05/2014
            Next
        Else
            cbx_Permitir.Checked = False
        End If
    End Sub

    Private Sub dtp_H_FechaInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_H_FechaInicio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_H_ClienteO.Focus()
        End If
    End Sub

    Private Sub Btn_GuardarH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GuardarH.Click
        SegundosDesconexion = 0

        If ValidaCampos() Then
            If cmb_H_Frecuencia.SelectedValue = 9 Then 'Lunes a Viernes
                fn_Menu_Progreso(0)
                Call GuardarDia(2) 'Lunes
                fn_Menu_Progreso(10)
                Call GuardarDia(3) 'Martes
                fn_Menu_Progreso(20)
                Call GuardarDia(4) 'Miercoles
                fn_Menu_Progreso(40)
                Call GuardarDia(5) 'Jueves
                fn_Menu_Progreso(80)
                Call GuardarDia(6) 'Viernes
                fn_Menu_Progreso(100)
            ElseIf cmb_H_Frecuencia.SelectedValue = 10 Then 'Lunes a Domingo
                fn_Menu_Progreso(0)
                Call GuardarDia(1) 'Domingo
                fn_Menu_Progreso(15)
                Call GuardarDia(2) 'Lunes
                fn_Menu_Progreso(30)
                Call GuardarDia(3) 'Martes
                fn_Menu_Progreso(45)
                Call GuardarDia(4) 'Miercoles
                fn_Menu_Progreso(60)
                Call GuardarDia(5) 'Jueves
                fn_Menu_Progreso(75)
                Call GuardarDia(6) 'Viernes
                fn_Menu_Progreso(90)
                Call GuardarDia(7) 'Sabado
                fn_Menu_Progreso(100)
            ElseIf cmb_H_Frecuencia.SelectedValue = 11 Then 'Lunes a Sabado
                fn_Menu_Progreso(15)
                Call GuardarDia(2) 'Lunes
                fn_Menu_Progreso(30)
                Call GuardarDia(3) 'Martes
                fn_Menu_Progreso(45)
                Call GuardarDia(4) 'Miercoles
                fn_Menu_Progreso(60)
                Call GuardarDia(5) 'Jueves
                fn_Menu_Progreso(75)
                Call GuardarDia(6) 'Viernes
                fn_Menu_Progreso(90)
                Call GuardarDia(7) 'Sabado
                fn_Menu_Progreso(100)
            ElseIf cmb_H_Frecuencia.SelectedValue = 12 Then 'Lunes, Miercoles y Viernes
                fn_Menu_Progreso(25)
                Call GuardarDia(2) 'Lunes
                fn_Menu_Progreso(65)
                Call GuardarDia(4) 'Miercoles
                fn_Menu_Progreso(90)
                Call GuardarDia(6) 'Viernes
                fn_Menu_Progreso(100)
            ElseIf cmb_H_Frecuencia.SelectedValue = 13 Then 'Lunes, Jueves y Sabado
                fn_Menu_Progreso(25)
                Call GuardarDia(2) 'Lunes
                fn_Menu_Progreso(65)
                Call GuardarDia(5) 'Jueves
                fn_Menu_Progreso(90)
                Call GuardarDia(7) 'Sabado
                fn_Menu_Progreso(100)
            Else
                fn_Menu_Progreso(0) 'Guardar solo el Dia seleccionado
                Call GuardarDia(cmb_H_Frecuencia.SelectedValue)
                fn_Menu_Progreso(100)
            End If
            fn_Menu_Progreso(0)

            Call Horarios_LimpiarCasillas()

            Me.Close()
        End If
    End Sub

    Private Sub cmb_H_MismoDia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_H_MismoDia.SelectedValueChanged
        If cmb_H_MismoDia.SelectedValue = "N" Then
            cmb_H_RutaEntrega.Enabled = True
            cmb_H_DiaEntrega.Enabled = True
        Else
            cmb_H_RutaEntrega.SelectedValue = cmb_H_Ruta.SelectedValue
            cmb_H_DiaEntrega.SelectedValue = cmb_H_Frecuencia.SelectedValue

            cmb_H_RutaEntrega.Enabled = False
            cmb_H_DiaEntrega.Enabled = False
        End If
    End Sub

    Private Sub cmb_H_Ruta_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_H_Ruta.SelectedValueChanged
        If cmb_H_MismoDia.SelectedValue = "S" Or cmb_H_MismoDia.SelectedValue = "0" Then
            cmb_H_RutaEntrega.SelectedValue = cmb_H_Ruta.SelectedValue
            cmb_H_DiaEntrega.SelectedValue = cmb_H_Frecuencia.SelectedValue
        End If
    End Sub

    Private Sub cmb_H_ClienteO_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_H_ClienteO.SelectedValueChanged, cmb_H_ClienteD.SelectedValueChanged
        cbx_Permitir.Enabled = (cmb_H_ClienteO.SelectedValue = Id_Cliente) OrElse (cmb_H_ClienteD.SelectedValue = Id_Cliente)
        cbx_Permitir.Checked = False
        gbx_Subclientes.Enabled = False
        rtb_Subclientes.Clear()
    End Sub

    Private Sub cmb_H_Frecuencia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_H_Frecuencia.SelectedValueChanged
        If cmb_H_Frecuencia.SelectedValue <> "0" Then
            If cmb_H_MismoDia.SelectedValue = "S" Then
                cmb_H_RutaEntrega.SelectedValue = cmb_H_Ruta.SelectedValue
                cmb_H_DiaEntrega.SelectedValue = cmb_H_Frecuencia.SelectedValue
                cmb_H_DiaEntrega.Enabled = False
                cmb_H_RutaEntrega.Enabled = False
            Else
                cmb_H_DiaEntrega.Enabled = True
                cmb_H_RutaEntrega.Enabled = True
            End If
        Else
            cmb_H_DiaEntrega.Enabled = True
            cmb_H_RutaEntrega.Enabled = True
        End If
    End Sub

#End Region

#Region "Metodos Privados"

    Private Sub GuardarDia(ByVal Dia As Integer)
        Dim Id_CH, Tipo As Integer
        Dim Id_CHTemp As Integer
        If Temp And CInt(Me.Tag) > 0 Then
            'Modificacion de Horario Temp
            Id_CH = 0
            Id_CHTemp = CInt(Me.Tag)
            Tipo = 0 'En el procedimiento de Update el Tipo no se actualiza
        ElseIf Temp Then
            'AgregarItem horario
            Id_CH = 0
            Id_CHTemp = 0
            Tipo = 1
        Else
            'Modificación de Horario Activo por lo tanto es una inserción en HorariosTemp
            Id_CHTemp = 0
            Id_CH = Me.Tag
            Tipo = 2
        End If
        Dim DiaEntrega As Integer
        Dim unicavez As String = ""
        Dim UtilizaCaset As String = ""

        If cmb_H_MismoDia.SelectedValue = "S" Then
            DiaEntrega = Dia
        Else
            DiaEntrega = cmb_H_DiaEntrega.SelectedValue
        End If

        If cmb_H_RutaEntrega.SelectedValue = "0" Then
            cmb_H_RutaEntrega.SelectedValue = cmb_H_Ruta.SelectedValue
        End If

        If chk_UnicaVez.Checked = True Then
            unicavez = "S"
        Else
            unicavez = "N"
        End If

        If rdb_UtilizaCasetSi.Checked Then
            UtilizaCaset = "S"
        ElseIf rdb_UtilizaCasetNO.Checked Then
            UtilizaCaset = "N"
        End If

        If Temp = False Or (Temp = True And Id_CHTemp = 0 And Id_CH = 0) Then
            'Horario Nuevo. Insert en Horario Temp
            fn_Horarios_Crear(Id_CS, dtp_H_FechaInicio.Value, cmb_H_TipoF.SelectedValue, Dia.ToString, cmb_H_ClienteO.SelectedValue,
                               cmb_H_DeO.Text & "/" & cmb_H_AO.Text, cmb_H_ClienteD.SelectedValue, cmb_H_DeD.Text & "/" & cmb_H_AD.Text,
                              cmb_H_Ruta.SelectedValue, cmb_H_Boveda.SelectedValue, cmb_H_MismoDia.SelectedValue, DiaEntrega.ToString,
                               cmb_H_RutaEntrega.SelectedValue, cmb_FacturarRE.SelectedValue, cmb_CargoA.SelectedValue, unicavez, Id_CH,
                              Tipo, Prioridad, Dt_SubClientes, UtilizaCaset, cmb_NuevoOrigen.SelectedValue)
        Else
            'Modificacion de un Horario Temp. Es un Update en Horarios Temp
            fn_Horarios_Actualizar(Id_CHTemp, dtp_H_FechaInicio.Value, cmb_H_TipoF.SelectedValue, Dia.ToString, cmb_H_ClienteO.SelectedValue,
                                   cmb_H_DeO.Text & "/" & cmb_H_AO.Text, cmb_H_ClienteD.SelectedValue, cmb_H_DeD.Text & "/" & cmb_H_AD.Text,
                                   cmb_H_Ruta.SelectedValue, cmb_H_Boveda.SelectedValue, cmb_H_MismoDia.SelectedValue, DiaEntrega.ToString,
                                   cmb_H_RutaEntrega.SelectedValue, Tipo, Dt_SubClientes, FrecuencaAnt, UtilizaCaset, cmb_NuevoOrigen.SelectedValue)
        End If
    End Sub

    Private Function ValidaCampos() As Boolean
        If cmb_H_AD.SelectedValue = "0" Then
            MsgBox("Seleccione una Horario", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_AD.Focus()
            Return False
        End If

        If cmb_H_AO.SelectedValue = "0" Then
            MsgBox("Seleccione una Horario", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_AO.Focus()
            Return False
        End If

        If cmb_H_Boveda.SelectedValue = "0" Then
            MsgBox("Seleccione Escala en Boveda", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_Boveda.Focus()
            Return False
        End If

        If cmb_H_ClienteO.SelectedValue = "0" Or cmb_H_ClienteO.SelectedValue = Nothing Then
            MsgBox("Seleccione Cliente Origen.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_ClienteO.Focus()
            Return False
        End If

        If cmb_H_ClienteD.SelectedValue = "0" Or cmb_H_ClienteD.SelectedValue = Nothing Then
            MsgBox("Seleccione Cliente Destino.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_ClienteD.Focus()
            Return False
        End If

        If cmb_H_DeD.SelectedValue = "0" Then
            MsgBox("Seleccione Horario Cliente destino", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_DeD.Focus()
            Return False
        End If

        If cmb_H_DeO.SelectedValue = "0" Then
            MsgBox("Seleccione Horario Cliente Origen", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_DeO.Focus()
            Return False
        End If

        If cmb_H_MismoDia.SelectedValue = "0" Then
            MsgBox("Seleccione Horario Cliente Origen", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_MismoDia.Focus()
            Return False
        End If

        'If cmb_H_Ruta.SelectedValue = "0" Then
        '    MsgBox("Seleccione Horario Ruta Origen", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        '    cmb_H_Ruta.Focus()
        '    Return False
        'End If

        If cmb_H_TipoF.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo de Frecuencia.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_H_TipoF.Focus()
            Return False
        End If

        If cmb_CargoA.SelectedValue = "0" Then
            MsgBox("Seleccione la instancia de pago", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_CargoA.Focus()
            Return False
        End If

        If cmb_FacturarRE.SelectedValue = "0" Then
            MsgBox("Seleccione el concepto a cobrar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_FacturarRE.Focus()
            Return False
        End If

        Return True

    End Function

#End Region

    Private Sub btn_H_BuscarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_H_BuscarO.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Id_Sucursal = cmb_Sucursal1.SelectedValue
        frm.ShowDialog()

        tbx_H_ClienteO.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub btn_H_BuscarD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_H_BuscarD.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Id_Sucursal = cmb_Sucursal2.SelectedValue
        frm.ShowDialog()

        tbx_H_ClienteD.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub cmb_Sucursal1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sucursal1.SelectedIndexChanged
        If cmb_Sucursal1.Items.Count = 0 Then Exit Sub
        cmb_H_ClienteO.ActualizaValorParametro("@Id_Sucursal", cmb_Sucursal1.SelectedValue)
        cmb_H_ClienteO.Actualizar()
    End Sub

    Private Sub cmb_Sucursal2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sucursal2.SelectedIndexChanged
        If cmb_Sucursal2.Items.Count = 0 Then Exit Sub
        cmb_H_ClienteD.ActualizaValorParametro("@Id_Sucursal", cmb_Sucursal2.SelectedValue)
        cmb_H_ClienteD.Actualizar()
        cmb_NuevoOrigen.ActualizaValorParametro("@Id_Sucursal", cmb_Sucursal2.SelectedValue)
        cmb_NuevoOrigen.Actualizar()
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click, btn_Agregar2.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CapturarDestino
        frm.ShowDialog()

        Select Case CType(sender, Button).Name
            Case btn_Agregar.Name
                cmb_H_ClienteO.ActualizaValorParametro("@Id_Sucursal", cmb_Sucursal1.SelectedValue)
                cmb_H_ClienteO.Actualizar()
                cmb_H_ClienteO.SelectedValue = frm.Id_Cliente
            Case btn_Agregar2.Name
                cmb_H_ClienteD.ActualizaValorParametro("@Id_Sucursal", cmb_Sucursal2.SelectedValue)
                cmb_H_ClienteD.Actualizar()
                cmb_H_ClienteD.SelectedValue = frm.Id_Cliente
        End Select

        frm.Dispose()
    End Sub

    Private Sub gbx_Recoleccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Recoleccion.MouseHover, gbx_Entrega.MouseHover, gbx_Cargo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ayuda.Click
        Dim frm As New frm_Ayuda
        'Cuando exista un Horario Activo se insertará como Horario Temporal para su validación, tanto como el Cliente Principal como sus Sucursales.
        frm.rtb_Ayuda.Text = "Detalles Generales:" & Chr(13) & Chr(13) & _
                             " 1. Ingresar los Datos Obligatorios (los que están marcados con un Asterisco)." & Chr(13) & _
                             " 2. Seguir el Orden de captura de arriba hacia abajo." & Chr(13) & _
                             " 3. Cuando se está agregando un Horario Nuevo el Cliente Origen será Automáticamente " & Chr(13) & _
                             "    el Cliente que estamos editando." & Chr(13) & _
                             " 4. Si se está agregando un Horario Nuevo y es un Cliente Padre se mostrará la opción:" & Chr(13) & _
                             "    'Permitir que los horarios de servicio también se establezcan para las sucursales de este cliente'" & Chr(13) & _
                             " 5. Al cambiar tanto el Valor del Cliente Origen como el Cliente Destino se" & Chr(13) & _
                             "    desmarcará la opción que hace referencia a los Subclientes y se borrarán" & Chr(13) & _
                             "    los Subclientes que haya seleccionado previamente." & Chr(13) & _
                             " 7. Cuando se seleccionen los Subclientes se mostrarán en el recuadro de la parte baja de la pantalla." & Chr(13) & _
                             Chr(13) & _
                             "Nuevo Horario:" & Chr(13) & _
                             " 1. Al marcar la casilla para afectar también a los Subclientes, se abrirá una ventana en la cual podremos:" & Chr(13) & _
                             "       I. Seleccionar los Subclientes que deseemos afectar junto con el Cliente Padre." & Chr(13) & _
                             "      II. Se muestran sólo Subclientes Activos." & Chr(13) & _
                             "     III. Se muestran sólo Subclientes que tengan un Servicio y Precio Igual al del Cliente Padre." & Chr(13) & _
                             "          y que dicho servicio esté activo." & Chr(13) & _
                             " 2. Al guardar, se agrega un horario para el Cliente padre y otro para cada uno de los Subclientes" & Chr(13) & _
                             "    seleccionados." & Chr(13) & Chr(13) & _
                             "Editar un Horario Pendiente:" & Chr(13) & Chr(13) & _
                             " 1. Todos los Datos se podrán Editar." & Chr(13) & _
                             " 2. Se omite la opción de afectar a subclientes (para este caso se debe realizar a través del Excel)." & Chr(13) & Chr(13) & _
                             "Editar un Horario Activo:" & Chr(13) & Chr(13) & _
                             " 1. Se creará un nuevo Horario Pendiente de Validación para el Cliente Padre." & Chr(13) & _
                             " 2. Se omite la opción de afectar a subclientes (para este caso se debe realizar a través del Excel)." & Chr(13)
        frm.Size = New Size(770, 480)
        frm.Show()
    End Sub

    Private Sub cmb_H_Boveda_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_H_Boveda.SelectedValueChanged
        If cmb_H_Boveda.SelectedValue = "N" Then
            cmb_NuevoOrigen.Enabled = False
            tbx_NuevoOrigen.Enabled = False
            tbx_NuevoOrigen.Text = "0"
        Else
            cmb_NuevoOrigen.Enabled = True
            tbx_NuevoOrigen.Enabled = True
        End If
    End Sub

#Region "Se Iba a usar para editar varios pero quedo pendiente por dejar el proceso de Excel"
    'Private Sub cbx_Permitir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Permitir.CheckedChanged
    '    SegundosDesconexion = 0

    '    Dt_SubClientes.Rows.Clear()
    '    gbx_Subclientes.Enabled = False
    '    rtb_Subclientes.Text = ""

    '    If Not cbx_Permitir.Checked Then Exit Sub

    '    Dim frm As New frm_BuscarSubClientes
    '    If Temp And CInt(Me.Tag) > 0 Then
    '        'Modificar Horarios Temp
    '        frm.Consulta = frm_BuscarSubClientes.Query.ModHorariosTemp
    '        frm.Id_Padre = Id_Cliente
    '        frm.Clave_Padre = Clave_Cliente
    '        frm.Id_CS = Id_CS
    '    ElseIf Temp Then
    '        'Crear Nuevos Horarios Temp
    '        frm.Consulta = frm_BuscarSubClientes.Query.ClientesServicios
    '        frm.Id_Padre = Id_Cliente
    '        frm.ClavePrecio = Clave_Precio
    '        frm.Id_PrecioDescripcion = Id_PrecioDescripcion
    '    Else
    '        'Modificando Horarios Reales (será crear Horarios Temp)
    '        frm.Consulta = frm_BuscarSubClientes.Query.ModHorariosReal
    '        frm.Id_Padre = Id_Cliente
    '        frm.Clave_Padre = Clave_Cliente
    '        frm.Id_CS = Id_CS
    '    End If

    '    frm.ShowDialog()

    '    If frm.DialogResult = Windows.Forms.DialogResult.OK Then
    '        gbx_Subclientes.Enabled = True

    '        For Each ModalSubClientes As ListViewItem In frm.lsv_Clientes.CheckedItems
    '            If rtb_Subclientes.Text = "" Then
    '                rtb_Subclientes.Text = ModalSubClientes.SubItems(1).Text
    '            ElseIf InStr(rtb_Subclientes.Text, ModalSubClientes.SubItems(1).Text) = 0 Then
    '                'Se revisa que no se haya ya agregado el nombre de un subcliente para no repetir.
    '                rtb_Subclientes.Text &= ", " & ModalSubClientes.SubItems(1).Text
    '            End If

    '            If Temp And CInt(Me.Tag) > 0 Then
    '                Dt_SubClientes.Rows.Add(ModalSubClientes.SubItems(9).Text, 0, 0, ModalSubClientes.Tag, ModalSubClientes.SubItems(10).Text)
    '            ElseIf Temp Then
    '                'Crear Nuevos Horarios Temp
    '                Dt_SubClientes.Rows.Add(ModalSubClientes.SubItems(5).Text, ModalSubClientes.Tag, 0, 0, "")
    '            Else
    '                'Modificando Horarios Reales (será crear Horarios Temp)
    '                Dt_SubClientes.Rows.Add(ModalSubClientes.SubItems(9).Text, ModalSubClientes.SubItems(10).Text, ModalSubClientes.Tag, 0, ModalSubClientes.SubItems(11).Text)
    '            End If
    '        Next
    '    Else
    '        cbx_Permitir.Checked = False
    '    End If
    'End Sub
#End Region

End Class