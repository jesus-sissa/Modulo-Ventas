Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_AgendaCita

    Public Dia As DateTime
    Public HoraCadena As String
    Public HoraCadenaFin As String
    Public Hora As Decimal
    Public HoraFin As Decimal
    Public IdAgenda As Integer = 0
    Public IdEmpleado As Integer
    Public Status As String
    Dim Accion As Char = ""

    Private Sub frm_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_HastaDiario.Value = DateTime.Now
        dtp_HastaDia.Value = DateTime.Now
        dtp_HastaMes.Value = DateTime.Now
        dtp_HastaSemestre.Value = DateTime.Now

        Call LlenarComboMinutos(30, cmb_HoraInicio)
        Call LlenarComboMinutos(30, cmb_HoraFin)
        Call LlenarComboMinutos(30, cmb_HoraInicioNueva)
        Call LlenarComboMinutos(30, cmb_HoraFinNueva)

        cmb_DiaSemana.AgregarItem("1", "DOMINGO")
        cmb_DiaSemana.AgregarItem("2", "LUNES")
        cmb_DiaSemana.AgregarItem("3", "MARTES")
        cmb_DiaSemana.AgregarItem("4", "MIERCOLES")
        cmb_DiaSemana.AgregarItem("5", "JUEVES")
        cmb_DiaSemana.AgregarItem("6", "VIERNES")
        cmb_DiaSemana.AgregarItem("7", "SABADO")

        For XLOCAL As Integer = 1 To 31
            cmb_DiaMes.AgregarItem(XLOCAL.ToString, XLOCAL.ToString)
            cmb_DiaSemestre.AgregarItem(XLOCAL.ToString, XLOCAL.ToString)
        Next

        If IdAgenda > 0 Then
            rdb_Editar.Checked = True
            gbx_Recurrente.Enabled = False
            gbx_Semana.Enabled = False
            gbx_Mes.Enabled = False
            cmb_HoraInicio.Enabled = False
            cmb_HoraFin.Enabled = False
            Dim Dr As DataRow = Cn_Clientes.fn_Agenda_ConsultarUna(IdAgenda)
            If Dr IsNot Nothing Then
                Dia = Dr("Fecha")
                dtp_Fecha.Value = Dia
                dtp_FechaProxima.Value = Dia
                Hora = Dr("Hora_Agenda")
                HoraFin = Dr("Hora_Final")
                HoraCadena = Dr("Hora_InicialT")
                HoraCadenaFin = Dr("Hora_FinalT")
                IdEmpleado = Dr("Id_Empleado")
                tbx_Asunto.Text = Dr("Asunto")
                tbx_Descripcion.Text = Dr("Descripcion")
                Status = Dr("Status")
                'Asignar los valores a los Objetos
                dtp_Fecha.Value = Dia
                dtp_FechaProxima.Value = Dia
                cmb_HoraInicio.Text = HoraCadena
                cmb_HoraFin.Text = HoraCadenaFin
                cmb_HoraInicioNueva.Text = HoraCadena
                cmb_HoraFinNueva.Text = HoraCadenaFin
            Else
                MsgBox("Ocurrió un Error al Intentar Mostrar los Datos de la Tarea.", MsgBoxStyle.Critical, frm_MENU.Text)
                Me.Close()
                Exit Sub
            End If
        Else
            cmb_HoraInicio.Enabled = True
            cmb_HoraFin.Enabled = True
            rdb_Editar.Enabled = True
            rdb_Ninguno.Checked = True
            rdb_Editar.Checked = True
            cmb_HoraInicio.Enabled = True
            cmb_HoraFin.Enabled = True
            gbx_Recurrente.Enabled = True
            gbx_Semana.Enabled = False
            gbx_Mes.Enabled = False
            gbx_Accion.Enabled = False
            'Asignar los valores a los Objetos
            dtp_Fecha.Value = Dia
            dtp_FechaProxima.Value = Dia
            cmb_HoraInicio.SelectedValue = Hora.ToString
            cmb_HoraFin.SelectedValue = (Hora + 0.5).ToString
            cmb_HoraInicioNueva.SelectedValue = Hora.ToString
            cmb_HoraFinNueva.SelectedValue = (Hora + 0.5).ToString
        End If

        Select Case Status
            Case "V", "PP", "C"
                gbx_Accion.Enabled = False
                gbx_Actualizar.Enabled = False
                gbx_Datos.Enabled = False
                btn_Guardar.Enabled = False
            Case Else
                gbx_Datos.Enabled = True
                btn_Guardar.Enabled = True
        End Select

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If IdAgenda = 0 Then
            If dtp_Fecha.Value.Date < Now.Date Then
                MsgBox("La Fecha parece ser Incorrecta. Solo se permiten tareas para la Fecha Actual o Futuras.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_Fecha.Focus()
                Exit Sub
            End If
            If cmb_HoraInicio.SelectedValue = 0 Then
                MsgBox("Debe seleccionar la Hora Inicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_HoraInicio.Focus()
                Exit Sub
            End If
            If cmb_HoraFin.SelectedValue = 0 Then
                MsgBox("Debe seleccionar la Hora Final.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_HoraFin.Focus()
                Exit Sub
            End If
            If cmb_HoraInicio.SelectedValue = cmb_HoraFin.SelectedValue Then
                MsgBox("La Hora Final no debe ser igual a la Hora Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_HoraFin.Focus()
                Exit Sub
            End If
            If tbx_Asunto.Text = "" Then
                MsgBox("Capture el Asunto.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Asunto.Focus()
                Exit Sub
            End If
            If tbx_Descripcion.Text = "" Then
                MsgBox("Capture la descripción de la Tarea.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Descripcion.Focus()
                Exit Sub
            End If
            'Nueva
            Dim FF As Date = dtp_Fecha.Value.Date
            Dim Id_InicioRecurrencia As Integer = 0
            If rdb_Diario.Checked Then
                While FF <= dtp_HastaDiario.Value.Date
                    If Id_InicioRecurrencia = 0 Then
                        Id_InicioRecurrencia = fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, 0)
                    Else
                        fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, Id_InicioRecurrencia)
                    End If
                    FF = DateAdd(DateInterval.Day, 1, FF)
                End While
            ElseIf rdb_Semana.Checked Then
                While FF <= dtp_HastaDia.Value.Date
                    If FF.DayOfWeek = dtp_Fecha.Value.Date.DayOfWeek Then
                        If Id_InicioRecurrencia = 0 Then
                            Id_InicioRecurrencia = fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, 0)
                        Else
                            fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, Id_InicioRecurrencia)
                        End If
                    End If
                    FF = DateAdd(DateInterval.Day, 1, FF)
                End While
            ElseIf rdb_Mes.Checked Then
                While FF <= dtp_HastaMes.Value.Date
                    If FF.Day = dtp_Fecha.Value.Date.Day Then
                        If Id_InicioRecurrencia = 0 Then
                            Id_InicioRecurrencia = fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, 0)
                        Else
                            fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, Id_InicioRecurrencia)
                        End If
                    End If
                    FF = DateAdd(DateInterval.Month, 1, FF)
                End While
            ElseIf rdb_Semestre.Checked Then
                While FF <= dtp_HastaSemestre.Value.Date
                    If FF.Day = dtp_Fecha.Value.Date.Day Then
                        If Id_InicioRecurrencia = 0 Then
                            Id_InicioRecurrencia = fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, 0)
                        Else
                            fn_Citas_Nuevo(UsuarioId, FF, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, Id_InicioRecurrencia)
                        End If
                    End If
                    FF = DateAdd(DateInterval.Month, 6, FF)
                End While
            ElseIf rdb_Ninguno.Checked Then
                If fn_Citas_Nuevo(UsuarioId, dtp_Fecha.Value.Date, cmb_HoraInicio.SelectedValue, cmb_HoraFin.SelectedValue, cmb_HoraInicio.Text, cmb_HoraFin.Text, tbx_Asunto.Text, tbx_Descripcion.Text, 0) <= 0 Then
                    MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If

        ElseIf IdAgenda > 0 Then
            'Modificacion
            If rdb_Editar.Checked Then
                'Si sólo se van a editar los datos de la cita agendada
                If Not fn_Cita_Actualizar(IdAgenda, tbx_Asunto.Text, tbx_Descripcion.Text) Then
                    MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                'Si se va a editar una cita
                Select Case Accion
                    Case "F" 'Finalizar
                        If Not fn_Cita_Finalizar(IdAgenda, tbx_Comentarios.Text) Then
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Case "C" 'Cancelar
                        If Not fn_Cita_Cancelar(IdAgenda, tbx_Comentarios.Text) Then
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Case "P" 'Posponer
                        If dtp_FechaProxima.Value.Date < System.DateTime.Today.Date Then
                            MsgBox("La Nueva Fecha no puede ser menor que Hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
                            dtp_FechaProxima.Focus()
                            Exit Sub
                        End If
                        If cmb_HoraInicioNueva.SelectedValue = 0 Or cmb_HoraFinNueva.SelectedValue = 0 Then
                            MsgBox("Verifique las Nuevas horas de Inicio y Fin.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_HoraInicioNueva.Focus()
                            Exit Sub
                        End If
                        If dtp_FechaProxima.Value.Date = dtp_Fecha.Value.Date Then
                            If cmb_HoraInicioNueva.SelectedValue <= (DatePart(DateInterval.Hour, System.DateTime.Now) + 0.5) Then
                                MsgBox("Solo se permite cambiar la tarea para una Fecha y Hora mayor que la Fecha y Hora actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                                cmb_HoraInicioNueva.Focus()
                                Exit Sub
                            End If
                        End If
                        If cmb_HoraInicioNueva.SelectedValue = 0 Then
                            MsgBox("Seleccione la Hora Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_HoraInicioNueva.Focus()
                            Exit Sub
                        End If
                        If cmb_HoraFinNueva.SelectedValue = 0 Then
                            MsgBox("Seleccione la Hora Final.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_HoraFinNueva.Focus()
                            Exit Sub
                        End If
                        'Revisar si para la Nueva Fecha y Hora ya hay una tarea
                        If fn_Cita_Existe(UsuarioId, dtp_FechaProxima.Value.Date, cmb_HoraInicioNueva.Text) Then
                            MsgBox("Ya existe una tarea para la Fecha y Hora Seleccionadas. Intente de nuevo con otra Hora y/o Fecha.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                            Exit Sub
                        End If
                        'Guardar la nueva tarea
                        If Not fn_Cita_Posponer(IdAgenda, tbx_Asunto.Text, tbx_Descripcion.Text, dtp_FechaProxima.Value, cmb_HoraInicioNueva.SelectedValue, cmb_HoraFinNueva.SelectedValue, cmb_HoraInicioNueva.Text, cmb_HoraFinNueva.Text, tbx_Comentarios.Text) Then
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                End Select
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub rdb_Editar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdb_Editar.CheckedChanged
        If rdb_Editar.Checked Then
            Accion = "E"
            gbx_Datos.Enabled = True
            gbx_Recurrente.Enabled = False
            gbx_Actualizar.Enabled = False
            'tbx_Asunto.Enabled = True
            'lbl_Asunto.Enabled = True
            'tbx_Descripcion.Enabled = True
            'lbl_Descripcion.Enabled = True
            lbl_Comentario.Text = "Comentarios"
        End If
    End Sub

    Private Sub rdb_Posponer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Posponer.CheckedChanged
        If rdb_Posponer.Checked Then
            Accion = "P"
            gbx_Datos.Enabled = False
            gbx_Actualizar.Enabled = True
            dtp_FechaProxima.Enabled = rdb_Posponer.Checked
            cmb_HoraInicioNueva.Enabled = rdb_Posponer.Checked
            cmb_HoraFinNueva.Enabled = rdb_Posponer.Checked
            tbx_DuracionNueva.Enabled = rdb_Posponer.Checked
            lbl_Comentario.Text = "Por qué se Pospone?"
        End If
    End Sub

    Private Sub rdb_Finalizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Finalizar.CheckedChanged
        If rdb_Finalizar.Checked Then
            Accion = "F"
            gbx_Datos.Enabled = False
            gbx_Actualizar.Enabled = True
            dtp_FechaProxima.Enabled = False
            cmb_HoraInicioNueva.Enabled = False
            cmb_HoraFinNueva.Enabled = False
            tbx_DuracionNueva.Enabled = False
            lbl_Comentario.Text = "Comentario de Finalización"
        End If
    End Sub

    Private Sub rdb_Cancelar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Cancelar.CheckedChanged
        If rdb_Cancelar.Checked Then
            Accion = "C"
            gbx_Datos.Enabled = False
            gbx_Actualizar.Enabled = True
            dtp_FechaProxima.Enabled = False
            cmb_HoraInicioNueva.Enabled = False
            cmb_HoraFinNueva.Enabled = False
            tbx_DuracionNueva.Enabled = False
            lbl_Comentario.Text = "Comentario de Cancelación"
        End If
    End Sub

    Private Sub gbx_DatosCita_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Datos.MouseHover, gbx_Actualizar.MouseHover, gbx_Accion.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub tbx_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Descripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmb_HoraInicio_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_HoraInicio.SelectedValueChanged
        tbx_Duracion.Clear()
        If cmb_HoraInicio.SelectedValue > 0 Then
            If CDec(cmb_HoraFin.SelectedValue) <= CDec(cmb_HoraInicio.SelectedValue) Then
                If CDec(cmb_HoraInicio.SelectedValue) <= 23 Then cmb_HoraFin.SelectedValue = CDec(cmb_HoraInicio.SelectedValue) + 0.5
            End If
        End If
        If cmb_HoraInicio.SelectedValue <> 0 And cmb_HoraFin.SelectedValue <> 0 Then
            tbx_Duracion.Text = (cmb_HoraFin.SelectedValue - cmb_HoraInicio.SelectedValue) * 60
        End If
    End Sub

    Private Sub cmb_HoraFin_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_HoraFin.SelectedValueChanged
        tbx_Duracion.Clear()
        If cmb_HoraInicio.SelectedValue <> 0 And cmb_HoraFin.SelectedValue <> 0 Then
            tbx_Duracion.Text = (cmb_HoraFin.SelectedValue - cmb_HoraInicio.SelectedValue) * 60
        End If
    End Sub

    Private Sub cmb_HoraInicioNueva_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_HoraInicioNueva.SelectedValueChanged
        tbx_DuracionNueva.Clear()
        If cmb_HoraInicioNueva.SelectedValue > 0 Then
            If CDec(cmb_HoraFinNueva.SelectedValue) <= CDec(cmb_HoraInicioNueva.SelectedValue) Then
                If CDec(cmb_HoraInicioNueva.SelectedValue) <= 23 Then cmb_HoraFinNueva.SelectedValue = CDec(cmb_HoraInicioNueva.SelectedValue) + 0.5
            End If
        End If
        If cmb_HoraInicioNueva.SelectedValue <> 0 And cmb_HoraFinNueva.SelectedValue <> 0 Then
            tbx_DuracionNueva.Text = (cmb_HoraFinNueva.SelectedValue - cmb_HoraInicioNueva.SelectedValue) * 60
        End If
    End Sub

    Private Sub cmb_HoraFinNueva_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_HoraFinNueva.SelectedValueChanged
        tbx_DuracionNueva.Clear()
        If cmb_HoraInicioNueva.SelectedValue <> 0 And cmb_HoraFinNueva.SelectedValue <> 0 Then
            tbx_DuracionNueva.Text = (cmb_HoraFinNueva.SelectedValue - cmb_HoraInicioNueva.SelectedValue) * 60
        End If
    End Sub

    Private Sub dtp_Fecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_HoraInicio.Enabled Then
                cmb_HoraInicio.Focus()
            ElseIf cmb_HoraFin.Enabled Then
                cmb_HoraFin.Focus()
            ElseIf tbx_Asunto.Enabled Then
                tbx_Asunto.Focus()
            ElseIf tbx_Descripcion.Enabled Then
                tbx_Descripcion.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_FechaProxima_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaProxima.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_HoraInicioNueva.Enabled Then
                cmb_HoraInicioNueva.Focus()
            ElseIf cmb_HoraFinNueva.Enabled Then
                cmb_HoraFinNueva.Focus()
            ElseIf tbx_Comentarios.Enabled Then
                tbx_Comentarios.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        cmb_DiaSemana.SelectedValue = DatePart(DateInterval.Weekday, dtp_Fecha.Value.Date, FirstDayOfWeek.Sunday)
        cmb_DiaMes.SelectedValue = dtp_Fecha.Value.Day
        lbl_DiarioInicio.Text = dtp_Fecha.Value.Date.ToShortDateString
    End Sub

    Private Sub rdb_Ninguno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Ninguno.CheckedChanged
        gbx_Semana.Enabled = False
        gbx_Mes.Enabled = False
        gbx_Diario.Enabled = False
    End Sub

    Private Sub rdb_Diario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Diario.CheckedChanged
        gbx_Diario.Enabled = rdb_Diario.Checked
        lbl_DiarioInicio.Text = dtp_Fecha.Value.Date.ToShortDateString
    End Sub

    Private Sub rdb_Semana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Semana.CheckedChanged
        gbx_Semana.Enabled = rdb_Semana.Checked
        cmb_DiaSemana.SelectedValue = DatePart(DateInterval.Weekday, dtp_Fecha.Value.Date, FirstDayOfWeek.Sunday)
    End Sub

    Private Sub rdb_Mes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Mes.CheckedChanged
        gbx_Mes.Enabled = rdb_Mes.Checked
        cmb_DiaMes.SelectedValue = dtp_Fecha.Value.Day
    End Sub

    Private Sub rdb_Semestre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Semestre.CheckedChanged
        gbx_Semestre.Enabled = rdb_Semestre.Checked
        cmb_DiaSemestre.SelectedValue = dtp_Fecha.Value.Day
    End Sub
End Class
