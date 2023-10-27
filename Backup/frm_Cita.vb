
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_Cita

    Public Dia As DateTime
    Public HoraCadena As String
    Public Hora As Decimal
    Public BanderaId As Boolean = False
    Public IdAgenda As Integer = 0
    Public CalIdEmpleado As Integer
    Dim Accion As Char = ""

    Private Sub frm_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_EmpleadoVentas.Actualizar()
        cmb_EmpleadoVentas.SelectedValue = CalIdEmpleado

        cmb_EjecutivoReasignar.Actualizar()

        dtp_FechaProxima.Value = Dia

        LlenarComboMinutos(30, cmb_HoraNueva)
        cmb_HoraNueva.Text = HoraCadena

        cmb_EmpleadoVentas.Enabled = Not BanderaId

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If cmb_EmpleadoVentas.SelectedValue = 0 Then
            MsgBox("Seleccione el Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_EmpleadoVentas.Focus()
            Exit Sub
        End If

        If tbx_Asunto.Text = "" Then
            MsgBox("Capture el Asunto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Asunto.Focus()
            Exit Sub
        End If

        If BanderaId Then
            ' Si es un fecha con cita agendada
            If cbx_SoloEditar.Checked Then
                'Si sólo se van a editar los datos de la cita agendada
                If Cn_Clientes.fn_Cita_Actualizar(IdAgenda, tbx_Asunto.Text, tbx_Descripcion.Text) Then
                    MsgBox("Los datos han sido actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                'Si se va a editar una cita

                Select Case Accion

                    Case "F"
                        If Cn_Clientes.fn_Cita_Finalizar(IdAgenda, tbx_Comentarios.Text) Then
                            MsgBox("Los datos han sido actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                        Else
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Case "C"
                        If Cn_Clientes.fn_Cita_Cancelar(IdAgenda, tbx_Comentarios.Text) Then
                            MsgBox("Los datos han sido actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                        Else
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Case "P"
                        If cmb_HoraNueva.SelectedValue = 0 Then
                            MsgBox("Seleccione la Hora.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_HoraNueva.Focus()
                            Exit Sub
                        End If
                        If Cn_Clientes.fn_Cita_Posponer(IdAgenda, tbx_Asunto.Text, tbx_Descripcion.Text, dtp_FechaProxima.Value, cmb_HoraNueva.SelectedValue, tbx_Comentarios.Text) Then
                            MsgBox("Los datos han sido actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                        Else
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Case "R"
                        If cmb_HoraNueva.SelectedValue = 0 Then
                            MsgBox("Seleccione la Hora.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_HoraNueva.Focus()
                            Exit Sub
                        End If
                        If cmb_EjecutivoReasignar.SelectedValue = 0 Then
                            MsgBox("Seleccione el Ejecutivo a Reasignar.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_EjecutivoReasignar.Focus()
                            Exit Sub
                        ElseIf cmb_EjecutivoReasignar.SelectedValue = CalIdEmpleado Then
                            MsgBox("Seleccione un Ejecutivo a Reasignar diferente.", MsgBoxStyle.Critical, frm_MENU.Text)
                            cmb_EjecutivoReasignar.Focus()
                            Exit Sub
                        End If

                        If Cn_Clientes.fn_Cita_Reasignar(IdAgenda, tbx_Asunto.Text, tbx_Descripcion.Text, dtp_FechaProxima.Value, cmb_HoraNueva.SelectedValue, tbx_Comentarios.Text, cmb_EjecutivoReasignar.SelectedValue) Then
                            MsgBox("Los datos han sido actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                        Else
                            MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If

                End Select
            End If
        Else
            If Cn_Clientes.fn_Citas_Nuevo(cmb_EmpleadoVentas.SelectedValue, Dia, Hora, tbx_Asunto.Text, tbx_Descripcion.Text) Then
                MsgBox("Los datos han sido guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If
        Me.Close()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub rdb_Reasignar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Reasignar.CheckedChanged
        If rdb_Reasignar.Checked Then Accion = "R"
        lbl_EjecutivoReasignar.Enabled = rdb_Reasignar.Checked
        cmb_EjecutivoReasignar.Enabled = rdb_Reasignar.Checked
        lbl_Fecha.Visible = rdb_Reasignar.Checked
        lbl_Fecha.Enabled = rdb_Reasignar.Checked
        lbl_FechaProxima.Visible = Not rdb_Reasignar.Checked
        dtp_FechaProxima.Enabled = rdb_Reasignar.Checked
        lbl_HoraNueva.Enabled = rdb_Reasignar.Checked
        cmb_HoraNueva.Enabled = rdb_Reasignar.Checked
    End Sub

    Private Sub rdb_Posponer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Posponer.CheckedChanged
        If rdb_Posponer.Checked Then Accion = "P"
        lbl_Fecha.Visible = Not rdb_Posponer.Checked
        lbl_Fecha.Enabled = Not rdb_Posponer.Checked
        lbl_FechaProxima.Visible = rdb_Posponer.Checked
        dtp_FechaProxima.Enabled = rdb_Posponer.Checked
        lbl_HoraNueva.Enabled = rdb_Posponer.Checked
        cmb_HoraNueva.Enabled = rdb_Posponer.Checked
    End Sub

    Private Sub rdb_Finalizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Finalizar.CheckedChanged
        If rdb_Finalizar.Checked Then Accion = "F"
        lbl_Fecha.Enabled = Not rdb_Finalizar.Checked
        lbl_FechaProxima.Enabled = Not rdb_Finalizar.Checked
        dtp_FechaProxima.Enabled = Not rdb_Finalizar.Checked
        lbl_HoraNueva.Enabled = Not rdb_Finalizar.Checked
        cmb_HoraNueva.Enabled = Not rdb_Finalizar.Checked
    End Sub

    Private Sub rdb_Cancelar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Cancelar.CheckedChanged
        If rdb_Cancelar.Checked Then Accion = "C"
        lbl_Fecha.Enabled = Not rdb_Cancelar.Checked
        lbl_FechaProxima.Enabled = Not rdb_Cancelar.Checked
        dtp_FechaProxima.Enabled = Not rdb_Cancelar.Checked
        lbl_HoraNueva.Enabled = Not rdb_Cancelar.Checked
        cmb_HoraNueva.Enabled = Not rdb_Cancelar.Checked
    End Sub

    Private Sub cbx_SoloEditar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_SoloEditar.CheckedChanged
        gbx_Accion.Enabled = Not cbx_SoloEditar.Checked
        gbx_DatosActualizarCita.Enabled = Not cbx_SoloEditar.Checked
        cmb_EmpleadoVentas.Enabled = Not cbx_SoloEditar.Checked
    End Sub

    Private Sub gbx_DatosCita_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_DatosCita.MouseHover, gbx_DatosActualizarCita.MouseHover, gbx_Accion.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class
