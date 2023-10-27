Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.Globalization
Imports Calendar
Imports System.Runtime.InteropServices
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_Agenda

    Dim DiaSel As DateTime
    Dim DiaAgenda As DataTable
    Dim MesSeleccionado As Integer
    Dim Eventos As List(Of Calendar.Appointment)


    Private Sub frm_Agenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_Agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Eventos = New List(Of Calendar.Appointment)()
        Calendario1.SelectionStart = Today
        DiaSel = Calendario1.SelectionStart
        MesSeleccionado = Calendario1.SelectionRange.Start.Month
        Call LlenarMesNuevo()
        DayView.StartDate = Calendario1.SelectionStart
    End Sub

    Sub LlenarMesNuevo()
        SegundosDesconexion = 0
        Eventos.Clear()
        Dim dt As DataTable
        dt = fn_Agenda_ConsultarMes(MesSeleccionado, UsuarioId)
        If dt Is Nothing Then
            MsgBox("Error al consultar los Eventos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        For Each row As DataRow In dt.Rows
            Dim Evento As New Appointment
            Evento.AppointmentId = row("Id_Agenda")
            Evento.Subject = row("Asunto")
            Evento.Note = row("Descripcion")
            Evento.StartDate = row("Fecha") & " " & row("Hora_InicialT")
            Evento.EndDate = row("Fecha") & " " & row("Hora_FinalT")
            Evento.Locked = True
            If row("Status") = "A" Then
                Evento.Color = Color.Green
                Evento.BorderColor = Color.Green
                Evento.Group = "A"
            ElseIf row("Status") = "C" Then
                Evento.Color = Color.Red
                Evento.BorderColor = Color.Red
                Evento.Group = "C"
            ElseIf row("Status") = "V" Then
                Evento.Color = Color.Gray
                Evento.BorderColor = Color.Gray
                Evento.Group = "V"
            ElseIf row("Status") = "PP" Then
                Evento.Color = Color.Khaki
                Evento.BorderColor = Color.Khaki
                Evento.Group = "PP"
            End If
            If row("Id_InicioRecurrencia") > 0 Then
                Evento.Recurring = True
            End If
            Eventos.Add(Evento)
        Next
        DayView.Invalidate()
        DayView.Refresh()
    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Calendario1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario1.DateChanged
        SegundosDesconexion = 0
        DiaSel = Calendario1.SelectionStart

        If Calendario1.SelectionRange.Start.Month <> MesSeleccionado Then
            MesSeleccionado = Calendario1.SelectionRange.Start.Month
            Call LlenarMesNuevo()
        End If
        DayView.StartDate = Calendario1.SelectionStart
    End Sub

    Private Sub dgv_AgendaDia_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
    End Sub

    'Private Sub DayView_OnNewAppointment(ByVal sender As Object, ByVal e As Calendar.NewAppointmentEventArgs) Handles DayView.OnNewAppointment
    '    Dim m_Appointment As New Calendar.Appointment

    '    m_Appointment.StartDate = e.StartDate
    '    m_Appointment.EndDate = e.EndDate
    '    m_Appointment.Subject = e.Title
    '    m_Appointment.Group = "1"

    '    Eventos.Add(m_Appointment)
    '    DayView.Invalidate()

    'End Sub

    Private Sub DayView_OnResolveAppointments(ByVal sender As Object, ByVal e As Calendar.ResolveAppointmentsEventArgs) Handles DayView.OnResolveAppointments
        Dim m_Apps As List(Of Appointment) = New List(Of Appointment)()

        For Each m_App As Appointment In Eventos
            If ((m_App.StartDate >= e.StartDate) And (m_App.StartDate <= e.EndDate)) Then
                m_Apps.Add(m_App)
            End If

            e.Appointments = m_Apps
        Next
    End Sub

    Private Sub DayView_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DayView.MouseDoubleClick
        'Identificar la tarea a la que le estoy haciendo click
        SegundosDesconexion = 0

        Dim FechaSeleccionada As Date = DayView.GetTimeAt(e.X, e.Y)
        Dim FechaSeleccionadaMasUno As Date = DateAdd(DateInterval.Minute, 1, FechaSeleccionada)
        'Es una tarea nueva
        Dim frm As New frm_AgendaCita
        frm.Text = "Nueva Tarea"
        frm.HoraCadena = Microsoft.VisualBasic.Left(FechaSeleccionada.TimeOfDay.ToString, 5)
        If Microsoft.VisualBasic.Right(frm.HoraCadena, 2) = "30" Then
            frm.Hora = Hour(FechaSeleccionada) + 0.5
        Else
            frm.Hora = Hour(FechaSeleccionada)
        End If
        frm.IdAgenda = 0
        frm.tbx_Asunto.Text = ""
        frm.tbx_Descripcion.Text = ""
        frm.IdEmpleado = UsuarioId
        frm.Dia = FechaSeleccionada
        'BUSCAR UNA CITA EN LA FECHA Y HORA SELECCIONADA PARA VER SI VA A SER NUEVA O MODIFICAR
        For Each m_App As Appointment In Eventos
            If (FechaSeleccionadaMasUno >= m_App.StartDate) And (FechaSeleccionadaMasUno < m_App.EndDate) Then
                frm.Text = "Editar Tarea"
                frm.IdAgenda = m_App.AppointmentId
                frm.Dia = m_App.StartDate
                frm.tbx_Asunto.Text = m_App.Subject
                frm.tbx_Descripcion.Text = m_App.Note
                frm.HoraCadena = Microsoft.VisualBasic.Left(m_App.StartDate.TimeOfDay.ToString, 5)
                If Microsoft.VisualBasic.Right(frm.HoraCadena, 2) = "30" Then
                    frm.Hora = Hour(m_App.StartDate) + 0.5
                Else
                    frm.Hora = Hour(m_App.StartDate)
                End If
                frm.Status = m_App.Group
                Exit For
            End If
        Next
        frm.ShowDialog()
        Call LlenarMesNuevo()
    End Sub

    Private Sub rdb_Uno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Uno.CheckedChanged
        If rdb_Uno.Checked Then
            DayView.DaysToShow = 1
        End If
    End Sub

    Private Sub rdb_Tres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Tres.CheckedChanged
        If rdb_Tres.Checked Then
            DayView.DaysToShow = 3
        End If
    End Sub

    Private Sub rdb_Cinco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Cinco.CheckedChanged
        If rdb_Cinco.Checked Then
            DayView.DaysToShow = 5
        End If
    End Sub

    Private Sub rdb_Siete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Siete.CheckedChanged
        If rdb_Siete.Checked Then
            DayView.DaysToShow = 7
        End If
    End Sub

    Private Sub rdb_Quince_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Quince.CheckedChanged
        If rdb_Quince.Checked Then
            DayView.DaysToShow = 15
        End If
    End Sub

    Private Sub DayView_OnAppointmentMove(ByVal sender As System.Object, ByVal e As Calendar.AppointmentEventArgs) Handles DayView.OnAppointmentMove
        'e.Appointment.Recurring = True
    End Sub

    Private Sub rdb_Treinta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Treinta.CheckedChanged
        If rdb_Treinta.Checked Then
            DayView.DaysToShow = 30
        End If
    End Sub

    Private Sub btn_Todas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Todas.Click
        'Mostrar en un formulario Modal Todas las tareas del Mes
        Dim frm_Todas As New frm_AgendaTodas
        frm_Todas.Año = Calendario1.SelectionStart.Year
        frm_Todas.Mes = MesSeleccionado
        frm_Todas.Id_Empleado = UsuarioId
        frm_Todas.ShowDialog()
        frm_Todas.Dispose()
        Call LlenarMesNuevo()
    End Sub
End Class

