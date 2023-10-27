Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes


Public Class frm_CajasFuertesMov

    Public Id_CajaFuerte As Integer = 0
    Public Id_CajaFuerteT As Integer = 0
    Public Id_CajaFuerteMov As Integer = 0
    Public Id_Cliente As Integer = 0
    Public CajaClave As String
    Public CajaMarca As String
    Public CajaSerie As String
    Public CombinacionActual() As String
    Public Existencia As Integer = 0
    Public StatusMov As String = ""
    Public ManejoCombinacion As String = ""
    Private Clave_Clientes As String = "0"
    Dim TipoMov As Integer
    Public DeRentaaVenta As Integer = 0 'new
    Public Cuenta As Byte = 0

    Private Sub frm_CajaFuerteMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Acceso Then
            tbx_CombActual0.UseSystemPasswordChar = True
            tbx_CombActual1.UseSystemPasswordChar = True
            tbx_CombActual2.UseSystemPasswordChar = True
        End If
        'Revisa que en el listview si tiene Id_Cliente significa que esta como renta o venta
        lbl_CajaFuerte.Text = CajaSerie & " " & CajaClave & " " & CajaMarca

        Call Habilitar()
        cmb_PrecioTipoMov.AgregaParametro("@Id_Cliente", Id_Cliente, 1)
        cmb_PrecioTipoMov.AgregaParametro("@Clave_Linea", "CF", 0)
        cmb_PrecioTipoMov.Actualizar()

        cmb_PrecioInsDes.AgregaParametro("@Id_Cliente", Id_Cliente, 1)
        cmb_PrecioInsDes.AgregaParametro("@Clave_Linea", "CF", 0)
        cmb_PrecioInsDes.Actualizar()

        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()

        cmb_Contacto.AgregaParametro("@Id_Cliente", 0, 1)
        cmb_Contacto.Actualizar()

        dtp_Fecha.Value = Today.Date
        dtp_FechaCita.Value = Today.Date
        dtp_HoraCita.Value = Now.ToLongDateString
        dtp_FechaRetiro.Value = Today.Date

        If Id_CajaFuerteMov = 0 Then Call Controles()

        'Cuando se quiera modificar la información de un movimiento
        If Id_CajaFuerteMov > 0 Then
            lbl_FechaRetiro.Enabled = False
            dtp_FechaRetiro.Enabled = False
            chk_Retiro.Checked = True
            chk_Retiro.Enabled = False

            Dim dr As DataRow = fn_CajasFuertesMov_Read(Id_CajaFuerteMov)
            gbx_Asignacion.Enabled = False

            cmb_Cliente.SelectedValue = dr("Id_Cliente")
            Id_Cliente = dr("Id_Cliente")
            Select Case dr("Tipo_Mov")
                Case 1
                    rbn_Venta.Checked = True
                    TipoMov = 1
                Case 2
                    rbn_Renta.Checked = True
                    If dr("FechaRetiro") IsNot Nothing AndAlso dr("FechaRetiro") <> "" Then
                        dtp_FechaRetiro.Value = dr("FechaRetiro")
                        chk_Retiro.Checked = False
                    Else
                        chk_Retiro.Checked = True
                    End If
                    TipoMov = 2
                Case 3
                    rbn_Retiro.Checked = True
                    TipoMov = 3
                Case 4
                    rbn_Combinacion.Checked = True
                    TipoMov = 4
                    tbx_CombActual0.Text = CombinacionActual(0)
                    tbx_CombActual1.Text = CombinacionActual(1)
                    tbx_CombActual2.Text = CombinacionActual(2)
                Case 5
                    rbn_Mantenimiento.Checked = True
                    TipoMov = 5
                Case 6
                    rbn_Reubicacion.Checked = True
                    TipoMov = 6
                Case 7
                    rbn_ManejoCombinacion.Checked = True
                    TipoMov = 7
                    tbx_CombActual0.Text = CombinacionActual(0)
                    tbx_CombActual1.Text = CombinacionActual(1)
                    tbx_CombActual2.Text = CombinacionActual(2)
                Case 9
                    rbn_Mantenimiento.Checked = True
                    TipoMov = 9
                Case 10
                    rbn_Vendida.Checked = True
                    TipoMov = 10
            End Select
            Select Case dr("Instalacion")
                Case "A"
                    rbn_Ambos.Checked = True
                Case "I"
                    rbn_Instalacion.Checked = True
                Case "D"
                    rbn_Desinstalacion.Checked = True
                Case "N"
                    rbn_Ninguno.Checked = True
            End Select

            Select Case dr("CombinacionCliente")
                Case "S"
                    rbn_CombinacionSi.Checked = True
                Case "N"
                    rbn_CombinacionNo.Checked = True
            End Select

            If dr("FechaCita") = Nothing Then
                chk_Cita.Checked = True
                gbx_Cita.Enabled = False
            Else
                dtp_FechaCita.Value = dr("FechaCita")
                dtp_HoraCita.Value = Today.Date & " " & dr("HoraCita")
            End If

            cmb_Contacto.SelectedValue = dr("Contacto")
            dtp_Fecha.Value = dr("Fecha")
            rtb_Observaciones.Text = dr("Observaciones")
            cmb_PrecioTipoMov.SelectedValue = dr("Id_CS")
            lbl_PrecioAnteriorServicio.Visible = True
            lbl_PrecioAnteriorInsDes.Visible = True
            lbl_PrecioAntServicio.Visible = True
            lbl_PrecioAntIndDes.Visible = True
            lbl_PrecioAntServicio.Text = dr("Precio")
            dr = Nothing
            If rbn_Ambos.Checked OrElse rbn_Instalacion.Checked OrElse rbn_Desinstalacion.Checked Then
                dr = fn_CajasFuertesMov_ReadDependiente(Id_CajaFuerteMov)
                If dr IsNot Nothing Then
                    cmb_PrecioInsDes.SelectedValue = dr("Id_CS")
                    lbl_PrecioAntIndDes.Text = dr("Precio")
                Else
                    lbl_PrecioAntIndDes.Text = "0.00"
                End If
            End If
        Else
            Call ManejarCombinacion()
        End If

        If StatusMov = "PROCESO" OrElse StatusMov = "M" Then
            rbn_Venta.Enabled = False
            rbn_Renta.Enabled = False
            rbn_Retiro.Enabled = False
            rbn_Vendida.Enabled = False
            rbn_Reubicacion.Enabled = False
            rbn_ManejoCombinacion.Enabled = False
        ElseIf StatusMov = "V" Then
            rbn_Retiro.Enabled = False
            rbn_Vendida.Enabled = True
        End If
    End Sub

#Region "Sub"

    Sub Habilitar()
        If Id_Cliente = 0 Then
            rbn_Venta.Enabled = True
            rbn_Renta.Enabled = True
            rbn_Retiro.Enabled = False
            rbn_Vendida.Enabled = False
            rbn_Reubicacion.Enabled = False
            rbn_ManejoCombinacion.Enabled = False
        Else
            rbn_Venta.Enabled = (StatusMov = "R")
            rbn_Renta.Enabled = False
            rbn_Retiro.Enabled = True
            rbn_Vendida.Enabled = True
            rbn_Reubicacion.Enabled = True
            rbn_ManejoCombinacion.Enabled = True
        End If
    End Sub

    Sub Controles()
        Call Limpiar()
        Call Cliente()
        If rbn_Venta.Checked OrElse rbn_Renta.Checked Then
            gbx_Instalacion.Enabled = True
            gbx_Combinacion.Enabled = True
            cmb_PrecioTipoMov.Enabled = True
            gbx_Datos.Enabled = True
            gbx_ClienteServicio.Enabled = True
            If (StatusMov = "R") AndAlso TipoMov = 1 Then rbn_Ambos.Enabled = True 'New
            If (StatusMov = "R") AndAlso TipoMov = 1 Then rbn_Ninguno.Checked = True 'New
            'If (StatusMov = "R") AndAlso TipoMov = 1 Then rbn_Desinstalacion.Enabled = False 'New
            If (StatusMov = "R") AndAlso TipoMov = 1 Then rbn_Instalacion.Enabled = True 'New
        ElseIf rbn_Retiro.Checked Then
            gbx_Instalacion.Enabled = True
            rbn_Instalacion.Enabled = False
            rbn_Ambos.Enabled = False
            rbn_Desinstalacion.Enabled = True 'New 
            rbn_Desinstalacion.Checked = True

            gbx_Combinacion.Enabled = False
            gbx_Datos.Enabled = True
            gbx_ClienteServicio.Enabled = True
        ElseIf rbn_Reubicacion.Checked Then
            gbx_Instalacion.Enabled = False
            rbn_Ambos.Checked = True
            gbx_Combinacion.Enabled = False
            cmb_PrecioTipoMov.Enabled = True
            gbx_Datos.Enabled = True
            gbx_ClienteServicio.Enabled = True
        ElseIf rbn_Mantenimiento.Checked AndAlso StatusMov <> "A" AndAlso StatusMov <> "M" Then
            gbx_Instalacion.Enabled = False
            gbx_Combinacion.Enabled = False
            cmb_PrecioTipoMov.Enabled = True
            gbx_Datos.Enabled = True
            gbx_ClienteServicio.Enabled = True
        ElseIf rbn_Combinacion.Checked Then
            gbx_Instalacion.Enabled = False
            gbx_Combinacion.Enabled = False
            lbl_Fecha.Enabled = True
            dtp_Fecha.Enabled = True
            lbl_AFecha.Enabled = True
            lbl_Observaciones.Enabled = True
            rtb_Observaciones.Enabled = True
            lbl_CombActual.Enabled = True
            cmb_PrecioTipoMov.Enabled = True
            gbx_Datos.Enabled = True
            gbx_ClienteServicio.Enabled = True
        ElseIf rbn_ManejoCombinacion.Checked Then
            gbx_Instalacion.Enabled = False
            gbx_Combinacion.Enabled = True
            lbl_Fecha.Enabled = True
            dtp_Fecha.Enabled = True
            lbl_AFecha.Enabled = True
            lbl_Observaciones.Enabled = True
            rtb_Observaciones.Enabled = True
            lbl_CombActual.Enabled = True
            cmb_PrecioTipoMov.Enabled = True
            gbx_Datos.Enabled = True
            gbx_ClienteServicio.Enabled = True
        ElseIf rbn_Mantenimiento.Checked AndAlso (StatusMov = "A" OrElse StatusMov = "M") Then
            gbx_Instalacion.Enabled = False
            gbx_Combinacion.Enabled = False
            cmb_PrecioTipoMov.Enabled = False
            gbx_Datos.Enabled = True
            chk_Cita.Checked = True
            gbx_ClienteServicio.Enabled = False
        ElseIf rbn_Vendida.Checked Then
            gbx_Instalacion.Enabled = False
            rbn_Instalacion.Enabled = False
            rbn_Ambos.Enabled = False
            rbn_Desinstalacion.Enabled = False 'New 
            rbn_Desinstalacion.Checked = False

            gbx_Combinacion.Enabled = False
            gbx_Datos.Enabled = False
            gbx_ClienteServicio.Enabled = False

        End If



        Call ManejarCombinacion()
        chk_Retiro.Enabled = rbn_Renta.Checked
        chk_Retiro.Checked = Not rbn_Renta.Checked
    End Sub

    Sub ManejarCombinacion()
        Select Case ManejoCombinacion
            Case "S"
                rbn_CombinacionSi.Checked = True
            Case "N"
                rbn_CombinacionNo.Checked = True
            Case ""
                rbn_CombinacionNo.Checked = True
        End Select
    End Sub

    Sub Limpiar()
        rbn_Ambos.Checked = False
        rbn_Instalacion.Checked = False
        rbn_Desinstalacion.Checked = False

        rbn_Ninguno.Checked = False
        '
        cmb_PrecioInsDes.Enabled = False
        cmb_PrecioInsDes.SelectedValue = 0

        rbn_CombinacionSi.Checked = False
        rbn_CombinacionNo.Checked = False

        dtp_Fecha.Value = Today.Date
        rtb_Observaciones.Clear()

        lbl_CombActual.Enabled = False
        tbx_CombActual0.Clear()
        tbx_CombActual1.Clear()
        tbx_CombActual2.Clear()

        chk_Cita.Checked = False
        dtp_FechaCita.Value = Today.Date
        dtp_HoraCita.Value = Now.ToLongDateString
        dtp_FechaRetiro.Value = Today.Date
    End Sub

    Sub Cliente()
        'Id_Cliente = 0 significa que viene Disponible la CF
        If Id_Cliente <> 0 Then
            cmb_Cliente.SelectedValue = Id_Cliente
            tbx_Cliente.Enabled = False
            cmb_Cliente.Enabled = False
            btn_BuscarCliente.Enabled = False
            lbl_ACliente.Visible = False
        Else
            'cmb_Cliente.SelectedValue = 0
            tbx_Cliente.Enabled = True
            cmb_Cliente.Enabled = True
            btn_BuscarCliente.Enabled = True
            lbl_ACliente.Visible = True
        End If
    End Sub

    Private Function Guardar() As Boolean
        'Validar que se seleccione un Movimiento
        If Not rbn_Venta.Checked And Not rbn_Renta.Checked _
            And Not rbn_Retiro.Checked _
            And Not rbn_ManejoCombinacion.Checked _
            And Not rbn_Reubicacion.Checked _
            And Not rbn_Combinacion.Checked _
            And Not rbn_Mantenimiento.Checked _
            And Not rbn_Vendida.Checked Then
            MsgBox("Seleccione el Tipo de Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        'Valida la Instalación
        If gbx_Instalacion.Enabled Then
            If Not rbn_Ambos.Checked AndAlso
                Not rbn_Instalacion.Checked AndAlso
                Not rbn_Desinstalacion.Checked AndAlso
                Not rbn_Ninguno.Checked Then
                MsgBox("Seleccione la acción a realizar con respecto a la Instalación de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                btn_Guardar.Focus()
                Return False
            End If
        End If

        'Valida el Servicio Cliente (cobro del movimiento)
        If cmb_PrecioTipoMov.Enabled AndAlso cmb_PrecioTipoMov.SelectedValue = 0 Then
            MsgBox("Seleccione el Cobro por el Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PrecioTipoMov.Focus()
            Return False
        End If

        'Valida el Servicio Cliente (cobro de la instalción)
        If cmb_PrecioInsDes.Enabled AndAlso cmb_PrecioInsDes.SelectedValue = 0 Then
            MsgBox("Seleccione el Cobro por Instalación.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PrecioInsDes.Focus()
            Return False
        End If

        'Valida el grupo de combinación para cuando sea renta.
        If (rbn_Venta.Checked Or rbn_Renta.Checked Or rbn_ManejoCombinacion.Checked) And Not rbn_CombinacionSi.Checked And Not rbn_CombinacionNo.Checked Then
            MsgBox("Seleccione si el Cliente manejará la Combinación.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_Combinacion.Focus()
            Return False
        End If

        'Validar selección de un cliente
        If rbn_Venta.Checked OrElse rbn_Renta.Checked Then
            If cmb_Cliente.SelectedValue = 0 Then
                MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Cliente.Focus()
                Return False
            End If
        End If

        'Valida que se tenga seleccionado un Contacto (sirve para cuando se crean los recibos).
        If Not rbn_Vendida.Checked Then
            If cmb_Contacto.SelectedValue = 0 Then
                MsgBox("Seleccione un Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Contacto.Focus()
                Return False
            End If
        End If

        'Valida el rango de la fecha seleccionada
        If dtp_Fecha.Value.Date > DateAdd(DateInterval.Day, 30, Now.Date) Then
            MsgBox("Solo puede programar movimientos para los próximos 30 días.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Fecha.Focus()
            Return False
        End If

        'Validar que la Fecha Retiro no sea igual o Menor que la Fecha del Movimiento
        If dtp_FechaRetiro.Enabled Then
            If dtp_FechaRetiro.Value.Date <= dtp_Fecha.Value.Date Then
                MsgBox("La Fecha de Retiro no debe de ser menor o igual que la Fecha del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_FechaRetiro.Focus()
                Return False
            End If
        End If

        'Validación de las Fechas con relación a la Fecha de Programación de la Cita
        If gbx_Cita.Enabled Then
            If dtp_FechaCita.Value.Date < dtp_Fecha.Value.Date Then
                MsgBox("La Fecha de la Programación de la Cita no debe de ser menor que la Fecha del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_FechaCita.Focus()
                Return False
            ElseIf dtp_FechaRetiro.Enabled Then
                If dtp_FechaCita.Value.Date > dtp_FechaRetiro.Value.Date Then
                    MsgBox("La Fecha de la Programación de la Cita no debe de ser mayor que la Fecha de Retiro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    dtp_FechaCita.Focus()
                    Return False
                End If
            End If
        End If

        'Valida si el precio guardado es Diferente al precio que se tiene en el Servicio Cliente (en el combo)
        'Esta validación sucede sólo cuando se esta actualizando
        Dim PrecioServicio As Decimal = CDec(lbl_PrecioAntServicio.Text.Trim)
        Dim PrecioInsDes As Decimal = CDec(lbl_PrecioAntIndDes.Text.Trim)
        If lbl_PrecioAntServicio.Visible Then
            Dim Dt_Precios As DataTable = cmb_PrecioTipoMov.DataSource

            'Verificar si el precio del servicio en el combo es el mismo que se tenía guardado
            For Each Elemento As DataRow In Dt_Precios.Rows
                'Del elemento seleccionado revisar los precios
                If cmb_PrecioTipoMov.SelectedValue = Elemento("Id_CS") Then
                    If CDec(Elemento("Precio")) = CDec(lbl_PrecioAntServicio.Text) Then
                        'Precio Igual
                        PrecioServicio = CDec(lbl_PrecioAntServicio.Text.Trim)
                    Else
                        'Se mantiene el precio que se seleccione en el Combo
                        PrecioServicio = Elemento("Precio")
                    End If
                    Exit For
                End If
            Next
            Dt_Precios = Nothing
            Dt_Precios = cmb_PrecioInsDes.DataSource

            'Verificar si el precio de Instalación/Desinstalación en el combo
            'es el mismo que se tenía guardado, cuando este activo el combo
            For Each Elemento As DataRow In Dt_Precios.Rows
                'Del elemento seleccionado revisar los precios
                If cmb_PrecioInsDes.SelectedValue = Elemento("Id_CS") Then
                    If CDec(Elemento("Precio")) = CDec(lbl_PrecioAntIndDes.Text) Then
                        'Precio Igual
                        PrecioInsDes = CDec(lbl_PrecioAntIndDes.Text.Trim)
                    Else
                        'Se mantiene el precio que se seleccione en el Combo
                        PrecioInsDes = Elemento("Precio")
                    End If
                    Exit For
                End If
            Next

            If PrecioServicio <> CDec(lbl_PrecioAntServicio.Text) OrElse (cmb_PrecioInsDes.Enabled AndAlso PrecioInsDes <> CDec(lbl_PrecioAntIndDes.Text)) Then
                If MsgBox("Los Precios que existen en el Servicio del Cliente son diferentes" & Chr(13) & _
                          "a los Precios guardados cuando se generó el Movimiento, Desea Cambiarlos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    PrecioServicio = CDec(lbl_PrecioAntServicio.Text.Trim)
                    PrecioInsDes = CDec(lbl_PrecioAntIndDes.Text.Trim)
                End If
            End If
        End If

        'Verificar una nueva contraseña
        Dim NumeroCombinacion As String = CombinacionActual(0) & " " & CombinacionActual(1) & " " & CombinacionActual(2)

        'Verificar si se requiere instalación o no
        Dim Instalacion As String = "N"
        If rbn_Instalacion.Checked Then
            Instalacion = "I"
        ElseIf rbn_Desinstalacion.Checked Then
            Instalacion = "D"
        ElseIf rbn_Ninguno.Checked Then
            Instalacion = "N"
        ElseIf rbn_Ambos.Checked Then
            Instalacion = "A"
        End If

        'Verificar si el cliente maneja o no la combinación
        If rbn_CombinacionSi.Checked Then
            ManejoCombinacion = "S"
        Else
            ManejoCombinacion = "N"
        End If

        If gbx_Asignacion.Enabled Then
            Id_Cliente = cmb_Cliente.SelectedValue
            DeRentaaVenta = 0 'resetea este valor si guarda de nuevo sin salir del formulario
            '
            '--------------------------Valida si biene de Fin de Renta y Va a Venta
            If StatusMov = "R" AndAlso TipoMov = 1 Then
                Dim OBservacionesRV As String = "GENERADO AUTOMATICAMENETE, PASA DE FIN DE RENTA A VENTA"
                Id_CajaFuerteMov = fn_CajasFuertesMov_Nuevo(Id_CajaFuerte, dtp_Fecha.Value.Date, 3, Id_Cliente, OBservacionesRV, "N", "N", _
                                                              cmb_Contacto.SelectedValue, False, dtp_FechaCita.Value.Date, _
                                                               dtp_HoraCita.Value.TimeOfDay.ToString, chk_Retiro.Checked, dtp_FechaRetiro.Value.Date, _
                                                               NumeroCombinacion, 0, 0, 0)
                If Id_CajaFuerteMov = 0 Then
                    MsgBox("No se pudo guardar el Movimiento de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                '----------VALIDA FIN DE RENTA'****
                If Not fn_CajasFuertesValidar_Status(Id_CajaFuerteMov, "VALIDACION - " & OBservacionesRV, "", Date.Today, "00:00:00") Then
                    MsgBox("No se pudo realizar la Validación.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Function
                End If
                DeRentaaVenta = Id_CajaFuerteMov 'para saber cuando va de finderenta a ventaDirecto
                Cuenta += 1
            End If
            '------------------TERMINA DE ValidaR si biene de Fin de Renta y Va a Venta
            '
            'Crear un Nuevo Movimiento (luego se validara y modificara los valores necesarios a la Caja Fuerte)
            Id_CajaFuerteMov = fn_CajasFuertesMov_Nuevo(Id_CajaFuerte, dtp_Fecha.Value.Date, TipoMov, Id_Cliente, rtb_Observaciones.Text, Instalacion, _
                                                        ManejoCombinacion, cmb_Contacto.SelectedValue, gbx_Cita.Enabled, dtp_FechaCita.Value.Date, _
                                                        dtp_HoraCita.Value.TimeOfDay.ToString, chk_Retiro.Checked, dtp_FechaRetiro.Value.Date, _
                                                        NumeroCombinacion, cmb_PrecioTipoMov.SelectedValue, cmb_PrecioInsDes.SelectedValue, DeRentaaVenta)
            If Id_CajaFuerteMov = 0 Then
                MsgBox("No se pudo guardar el Movimiento de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
            StatusMov = "PROCESO"
            Cuenta += 1
        Else
            'Modificar/Actualizar Valores
            If Not fn_CajasFuertesMov_Actualizar(Id_CajaFuerteMov, dtp_Fecha.Value.Date, TipoMov, cmb_Cliente.SelectedValue, rtb_Observaciones.Text, _
                                                Instalacion, ManejoCombinacion, cmb_Contacto.SelectedValue, gbx_Cita.Enabled, dtp_FechaCita.Value.Date, _
                                                dtp_HoraCita.Value.TimeOfDay.ToString, chk_Retiro.Checked, dtp_FechaRetiro.Value.Date, NumeroCombinacion, _
                                                cmb_PrecioTipoMov.SelectedValue, cmb_PrecioInsDes.SelectedValue, Id_CajaFuerte, PrecioServicio, PrecioInsDes) Then
                MsgBox("No se pudo actualizar el Movimiento de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
            lbl_PrecioAntServicio.Text = PrecioServicio
            lbl_PrecioAntIndDes.Text = PrecioInsDes
            Return True
        End If

        'Si se realizó retiro Id_Cliente se vuelve 0 porque ya no esta con alguien la caja fuerte.
        If rbn_Retiro.Checked Or rbn_Vendida.Checked Then
            Id_Cliente = 0
        Else
            Id_Cliente = cmb_Cliente.SelectedValue
        End If

        'Limpiar todos los movimientos
        rbn_Venta.Checked = False
        rbn_Renta.Checked = False
        rbn_Retiro.Checked = False
        rbn_Vendida.Checked = False

        rbn_ManejoCombinacion.Checked = False
        rbn_Combinacion.Checked = False
        rbn_Mantenimiento.Checked = False
        rbn_Reubicacion.Checked = False
        chk_Retiro.Checked = True

        Call Limpiar()
        Call Habilitar()
        Call Cliente()

        If ManejoCombinacion = "S" Then
            rbn_CombinacionSi.Checked = True
        Else
            rbn_CombinacionNo.Checked = True
        End If

        gbx_Instalacion.Enabled = False
        gbx_Datos.Enabled = False
        gbx_Combinacion.Enabled = False
        cmb_PrecioTipoMov.Enabled = False

        If StatusMov = "PROCESO" Then
            rbn_Venta.Enabled = False
            rbn_Renta.Enabled = False
            rbn_Retiro.Enabled = False
            rbn_Vendida.Enabled = False
            rbn_Reubicacion.Enabled = False
            rbn_ManejoCombinacion.Enabled = False
        End If

        Return True
    End Function

    Private Function Guardar_FinServicio_CajasVendidas() As Boolean
        If rbn_Vendida.Checked Then
            If fn_CajasFuertesMov_ActualizarVendida(Id_CajaFuerteMov, dtp_Fecha.Value.Date, 9, 0, rtb_Observaciones.Text, "N", ManejoCombinacion, 0,
                                                    gbx_Cita.Enabled, dtp_FechaCita.Value.Date, dtp_HoraCita.Value.TimeOfDay.ToString, chk_Retiro.Checked,
                                                    dtp_FechaRetiro.Value.Date, "", 0, 0, Id_CajaFuerte, 0, 0) Then
                MsgBox("Se actualizó el movimiento de Fin de Servcicio para las cajas Vendidas.", MsgBoxStyle.Information, frm_MENU.Text)
                Return True
            Else
                MsgBox("No se pudo actualizar el Movimiento Fin de Servicio a cajas Vendidas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        End If
    End Function

    Private Function Guardar_MantenimientoInterno() As Boolean
        If StatusMov = "A" Then
            'Crear un Nuevo Movimiento de Mantenimiento Interno (Tipo Mov = 9)
            If fn_CajasFuertesMov_Nuevo(Id_CajaFuerte, dtp_Fecha.Value.Date, 9, 0, rtb_Observaciones.Text, "N", ManejoCombinacion, 0, gbx_Cita.Enabled, dtp_FechaCita.Value.Date,
                                        dtp_HoraCita.Value.TimeOfDay.ToString, chk_Retiro.Checked, dtp_FechaRetiro.Value.Date, "", 0, 0, 0) > 0 Then
                MsgBox("La Caja Fuerte quedo en Mantenimiento o Reparación (Servicio Interno).", MsgBoxStyle.Information, frm_MENU.Text)
                Return True
            Else
                MsgBox("No se pudo guardar el Movimiento de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        Else
            'StatusMov = "M"
            'Actualizar el Movimiento de Mantenimiento Interno (Tipo Mov = 9)
            If fn_CajasFuertesMov_Actualizar(Id_CajaFuerteMov, dtp_Fecha.Value.Date, 9, 0, rtb_Observaciones.Text, "N", ManejoCombinacion, 0,
                                             gbx_Cita.Enabled, dtp_FechaCita.Value.Date, dtp_HoraCita.Value.TimeOfDay.ToString, chk_Retiro.Checked,
                                             dtp_FechaRetiro.Value.Date, "", 0, 0, Id_CajaFuerte, 0, 0) Then
                MsgBox("Se actualizó el movimiento de Mantenimiento o Reparación (Servicio Interno).", MsgBoxStyle.Information, frm_MENU.Text)
                Return True
            Else
                MsgBox("No se pudo actualizar el Movimiento de la Caja Fuerte.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        End If
    End Function

#End Region

#Region "Botones y RadioButton"

    Private Sub rbn_Venta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Venta.CheckedChanged
        SegundosDesconexion = 0

        Clave_Clientes = tbx_Cliente.Text
        cmb_Cliente.ActualizaValorParametro("@Status", "A")
        cmb_Cliente.Actualizar()
        TipoMov = 1
        Call Controles()
        tbx_Cliente.Text = Clave_Clientes

    End Sub

    Private Sub rbn_Renta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Renta.CheckedChanged
        SegundosDesconexion = 0

        Clave_Clientes = tbx_Cliente.Text
        cmb_Cliente.ActualizaValorParametro("@Status", "A")
        cmb_Cliente.Actualizar()
        TipoMov = 2
        Call Controles()
        tbx_Cliente.Text = Clave_Clientes

    End Sub

    Private Sub rbn_Retiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Retiro.CheckedChanged
        SegundosDesconexion = 0

        Clave_Clientes = tbx_Cliente.Text
        cmb_Cliente.ActualizaValorParametro("@Status", "T")
        cmb_Cliente.Actualizar()
        TipoMov = 3 'para quevalide botones
        Call Controles()
        tbx_Cliente.Text = Clave_Clientes

    End Sub

    Private Sub rbn_Combinacion_ManejoCombinacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Combinacion.CheckedChanged, rbn_ManejoCombinacion.CheckedChanged
        SegundosDesconexion = 0

        Clave_Clientes = tbx_Cliente.Text
        cmb_Cliente.ActualizaValorParametro("@Status", "A")
        cmb_Cliente.Actualizar()

        Call Controles()
        tbx_Cliente.Text = Clave_Clientes
        tbx_CombActual0.Text = CombinacionActual(0)
        tbx_CombActual1.Text = CombinacionActual(1)
        tbx_CombActual2.Text = CombinacionActual(2)
        If rbn_Combinacion.Checked Then
            TipoMov = 4
        ElseIf rbn_ManejoCombinacion.Checked Then
            TipoMov = 7
        End If
    End Sub

    Private Sub rbn_Mantenimiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Mantenimiento.CheckedChanged
        SegundosDesconexion = 0

        Clave_Clientes = tbx_Cliente.Text
        cmb_Cliente.ActualizaValorParametro("@Status", "A")
        cmb_Cliente.Actualizar()

        Call Controles()
        If StatusMov <> "A" AndAlso StatusMov <> "M" Then tbx_Cliente.Text = Clave_Clientes

        TipoMov = 5
    End Sub

    Private Sub rbn_Reubicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Reubicacion.CheckedChanged
        SegundosDesconexion = 0

        Clave_Clientes = tbx_Cliente.Text
        cmb_Cliente.ActualizaValorParametro("@Status", "A")
        cmb_Cliente.Actualizar()

        Call Controles()
        tbx_Cliente.Text = Clave_Clientes
        TipoMov = 6
    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Clientes
        frm.ShowDialog()

        tbx_Cliente.Text = frm.Clave
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If (rbn_Vendida.Checked And StatusMov = "V") Then
            Guardar_FinServicio_CajasVendidas()
        ElseIf rbn_Mantenimiento.Checked AndAlso (StatusMov = "A" OrElse StatusMov = "M") Then
            If Guardar_MantenimientoInterno() Then Me.Close()
        ElseIf Guardar() Then
            MsgBox("La información fue guardada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_GuardarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarImprimir.Click
        SegundosDesconexion = 0
        Cuenta = 0
        Dim Correcto As Boolean = False

        If rbn_Mantenimiento.Checked AndAlso (StatusMov = "A" OrElse StatusMov = "M") Then
            Correcto = Guardar_MantenimientoInterno()
        ElseIf Guardar() Then
            Correcto = True
        End If
        If Correcto Then
            If Cuenta = 0 Then Cuenta = 1 ' por si entra en otra opcion ke no tenga variable Cuenta


            For k As Byte = 1 To Cuenta

                Dim frm As New frm_Reporte
                Dim rpt
                If TipoMov = 2 Then
                    rpt = New rpt_ReciboMovCaja2
                Else
                    rpt = New rpt_ReciboMovCaja3 'tipomov(fin-de renta=3,venta=1)
                End If
                Dim Ds As New ds_Reporte

                'Reporte de Movimientos
                frm.crv.ReportSource = rpt

                If Not fn_Imprimir_LlenarReciboMovimiento(Ds.Tbl_CajasFuertesMov, Id_CajaFuerteMov) Then
                    MsgBox("Error al intentar generar el Recibo del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                If Not fn_Reportes_Encabezado(Ds.Tbl_DatosEmpresa) Then
                    MsgBox("Error al intentar generar el Recibo del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                '--------------pruebas de imagen en reportes {

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte()
                Dim ms_ByteToImagen As IO.MemoryStream
                Dim Ancho As Integer = 0
                Dim Alto As Integer = 0
                Dim valordiv As Decimal = 0.0

                Dim Top_Obj As Integer = 0
                Dim Left_Obj As Integer = 0 '+- 342default
                Dim Width_Obj As Integer = 0 '1440Default
                Dim nuevoAncho As Integer = 0
                Dim NuevoAlto As Integer = 0

                If Not IsDBNull(Ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

                    imagenBytes = Ds.Tbl_DatosEmpresa.Rows(0)("logo")
                    ms_ByteToImagen = New IO.MemoryStream(imagenBytes)
                    imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                    Ancho = imagenNueva.Width
                    Alto = imagenNueva.Height

                    '----subreporte1
                    With rpt.SubReports(0).ReportDefinition.Sections("Section1").ReportObjects("Logo")

                        Top_Obj = .Top
                        Left_Obj = .Left '+- 342default
                        Width_Obj = .Width '1440Default

                        If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                        nuevoAncho = Ancho * valordiv
                        NuevoAlto = Alto * valordiv

                        If Ancho > Alto Then
                            'horizontal
                            Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                            .Top = Top_Obj
                        Else
                            'vertical,cuadrado
                            Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                            .Left = Left_Obj
                        End If
                        .Width = nuevoAncho
                        .Height = NuevoAlto
                    End With

                    '-----para el subreporte 2----------

                    With rpt.SubReports(1).ReportDefinition.Sections("Section1").ReportObjects("Logo")
                        If Ancho > Alto Then .Top = Top_Obj Else .Left = Left_Obj
                        .Width = nuevoAncho
                        .Height = NuevoAlto
                    End With

                    '---para el tercer subreporte ----

                    If TipoMov <> 2 Then
                        With rpt.SubReports(2).ReportDefinition.Sections("Section1").ReportObjects("Logo")
                            If Ancho > Alto Then .Top = Top_Obj Else .Left = Left_Obj
                            .Width = nuevoAncho
                            .Height = NuevoAlto
                        End With
                    End If
                    '-------liberar objetos
                    'ms_ByteToImagen.Dispose()
                    'imagenNueva.Dispose()
                End If
                '--------------}

                rpt.Subreports.Item(0).SetDataSource(Ds)
                rpt.Subreports.Item(1).SetDataSource(Ds)
                If TipoMov <> 2 Then rpt.Subreports.Item(2).SetDataSource(Ds)

                frm.WindowState = FormWindowState.Maximized
                frm.ShowDialog()

                If TipoMov = 1 Or TipoMov = 2 Then ' -IF INICIO VALIDA TIPOMOV
                    'Carta Combinación es mostrada cuando Se realice los siguientes movimientos:
                    '1 = Venta
                    '2 = Renta
                    If ManejoCombinacion = "S" Then
                        'Solo se debe imprimir la carta de Combinacion cuando el cliente maneja la combinacion
                        Dim rptCombinacion As New rpt_ReciboCombinacion
                        frm.crv.ReportSource = rptCombinacion
                        If Not fn_Imprimir_LlenarCartaCombinacion(Ds.Tbl_ReciboCombinacion, Id_CajaFuerteMov) Then
                            MsgBox("Error al intentar generar el Recibo del Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                        Dim txt_Combinacion1 As CrystalDecisions.CrystalReports.Engine.TextObject = rptCombinacion.Section3.ReportObjects("txt_Combinacion1")
                        Dim txt_Combinacion2 As CrystalDecisions.CrystalReports.Engine.TextObject = rptCombinacion.Section3.ReportObjects("txt_Combinacion2")
                        Dim txt_Combinacion3 As CrystalDecisions.CrystalReports.Engine.TextObject = rptCombinacion.Section3.ReportObjects("txt_Combinacion3")

                        Try
                            txt_Combinacion1.Text = CombinacionActual(0)
                            txt_Combinacion2.Text = CombinacionActual(1)
                            txt_Combinacion3.Text = CombinacionActual(2)

                            'como ya se leyeron medidas de imagen solo se pasan.
                            With rptCombinacion.ReportDefinition.Sections("Section1").ReportObjects("Logo")
                                If Ancho > Alto Then .Top = Top_Obj Else .Left = Left_Obj
                                .Width = nuevoAncho
                                .Height = NuevoAlto
                            End With

                            rptCombinacion.SetDataSource(Ds)
                            frm.WindowState = FormWindowState.Maximized
                            frm.ShowDialog()
                        Catch
                        End Try
                    End If
                End If '--IF TERMINA VALIDATIPOMOV
                Id_CajaFuerteMov = DeRentaaVenta
                TipoMov = 3
            Next k
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

#End Region

    Private Sub dtp_Fecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            rtb_Observaciones.Focus()
        End If
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        If cmb_Cliente.SelectedValue > 0 Then
            lbl_Contacto.Enabled = True
            cmb_Contacto.Enabled = True
            cmb_Contacto.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
            cmb_Contacto.Actualizar()
            lbl_AContacto.Visible = True

            cmb_PrecioTipoMov.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
            cmb_PrecioTipoMov.Actualizar()

            cmb_PrecioInsDes.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
            cmb_PrecioInsDes.Actualizar()
        Else
            If cmb_Cliente.Items.Count > 0 Then
                cmb_PrecioTipoMov.ActualizaValorParametro("@Id_Cliente", 0)
                cmb_PrecioTipoMov.Actualizar()

                cmb_PrecioInsDes.ActualizaValorParametro("@Id_Cliente", 0)
                cmb_PrecioInsDes.Actualizar()
            End If

            lbl_Contacto.Enabled = False
            cmb_Contacto.Enabled = False
            cmb_Contacto.SelectedValue = 0
            lbl_AContacto.Visible = False
        End If
    End Sub

    Private Sub chk_Cita_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cita.CheckedChanged
        SegundosDesconexion = 0

        dtp_FechaCita.Value = Today.Date
        dtp_HoraCita.Value = Now.ToLongDateString
        gbx_Cita.Enabled = Not chk_Cita.Checked
    End Sub

    Private Sub chk_Retiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Retiro.CheckedChanged
        SegundosDesconexion = 0

        lbl_FechaRetiro.Enabled = Not chk_Retiro.Checked
        dtp_FechaRetiro.Enabled = Not chk_Retiro.Checked
    End Sub

    Private Sub rbn_InsDes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_Ninguno.CheckedChanged, rbn_Instalacion.CheckedChanged, rbn_Desinstalacion.CheckedChanged, rbn_Ambos.CheckedChanged
        SegundosDesconexion = 0

        'Se activará el combo de cobro de instalación cuando sea marcada la instalación, desinstalación o ambos y sea venta o renta
        If rbn_Retiro.Checked AndAlso (rbn_Ninguno.Checked OrElse rbn_Desinstalacion.Checked) Then
            cmb_PrecioTipoMov.SelectedValue = 0
            cmb_PrecioTipoMov.Enabled = False
        Else
            cmb_PrecioTipoMov.Enabled = True
        End If

        cmb_PrecioInsDes.SelectedValue = 0
        cmb_PrecioInsDes.Enabled = (sender.Equals(rbn_Instalacion) OrElse sender.Equals(rbn_Desinstalacion) OrElse sender.Equals(rbn_Ambos)) AndAlso (rbn_Venta.Checked OrElse rbn_Renta.Checked OrElse rbn_Retiro.Checked)
    End Sub

    Private Sub cmb_PrecioTipoMov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_PrecioTipoMov.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_PrecioInsDes.Enabled Then
                cmb_PrecioInsDes.Focus()
            Else
                cmb_Contacto.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_PrecioInsDes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_PrecioInsDes.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_Contacto.Focus()
    End Sub

    Private Sub dtp_FechaRetiro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaRetiro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If dtp_FechaCita.Enabled Then
                dtp_FechaCita.Focus()
            Else
                rtb_Observaciones.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_FechaCita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaCita.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_HoraCita.Focus()
    End Sub

    Private Sub dtp_HoraCita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_HoraCita.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then rtb_Observaciones.Focus()
    End Sub
End Class
