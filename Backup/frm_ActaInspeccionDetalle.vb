Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ActaInspeccionDetalle

    Public Id_Inspeccion As Integer = 0
    Public Status As String = "V"
    Public Modificar As Boolean = False

    Private Sub frm_ActaInspeccionValidar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_PersonaInspeccion.Actualizar()
        cmb_Departamento.Actualizar()
        cmb_Puesto.Actualizar()
        cmb_JefeSeguridad.Actualizar()
        dtp_FechaCita.Value = Today.Date

        lsv_Imagenes.Items.Clear()
        If Not fn_InspeccionImagenes_LlenarLista(lsv_Imagenes, Id_Inspeccion) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Dim Dr_Datos As DataRow = fn_Inspeccion_Datos(Id_Inspeccion)
        If Dr_Datos IsNot Nothing Then
            If Modificar Then
                dtp_FechaVisita.Value = Dr_Datos("Fecha_Inspeccion")
                dtp_HoraVisita.Value = Today.Date & " " & Dr_Datos("Hora_Ispeccion")
            Else
                dtp_FechaVisita.Value = Dr_Datos("Fecha_Programada")
                dtp_HoraVisita.Value = Today.Date & " " & Dr_Datos("Hora_Programada")
            End If
            gbx_Datos.Text = "Acta de Inspección No." & Dr_Datos("Numero_Acta")
            lbl_Acta.Text = Dr_Datos("Numero_Acta")
            tbx_NombreF.Text = Dr_Datos("Nombre_Comercial")
            tbx_DireccionCliente.Text = Dr_Datos("Domicilio_Comercial")
            tbx_PersonaRecibio.Text = Dr_Datos("Persona_RecibeCliente")
            tbx_UbicacionSugerida.Text = Dr_Datos("Ubicacion_Sugerida")
            tbx_UbicacionSugeridaD.Text = Dr_Datos("Ubicacion_SugeridaD")
            tbx_Piso.Text = Dr_Datos("Piso")
            tbx_Ventajas.Text = Dr_Datos("Ventajas")
            tbx_Desventajas.Text = Dr_Datos("Desventajas")
            tbx_NotasAdicionales.Text = Dr_Datos("Notas_Adicionales")
            cmb_PersonaInspeccion.SelectedValue = Dr_Datos("Usuario_Inspeccion")
            cmb_JefeSeguridad.SelectedValue = Dr_Datos("Jefe_Seguridad")
            If Dr_Datos("Contacto_Cita") <> Nothing Then
                chk_ProgramacionCita.Checked = True
                tbx_Contacto.Text = Dr_Datos("Contacto_Cita")
                dtp_FechaCita.Value = Dr_Datos("Fecha_Cita")
                tbx_HorasCita.Text = Dr_Datos("Horas_Cita")
            End If
        Else
            MsgBox("Ha ocurrido un error al intentar mostrar la información de las Actas de Inspección para la Instalación de Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub dtp_FechaVisita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaVisita.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_HoraVisita.Focus()
        End If
    End Sub

    Private Sub dtp_HoraVisita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_HoraVisita.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_PersonaRecibio.Focus()
        End If
    End Sub

    Private Sub cmb_PersonaInspeccion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PersonaInspeccion.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_PersonaInspeccion.SelectedValue <> "0" Then
            Dim Dr_Empleado As DataRow = fn_Empleado_Datos(cmb_PersonaInspeccion.SelectedValue)

            If Not Dr_Empleado Is Nothing Then
                If Not Dr_Empleado("Id_Departamento") Is Nothing Then
                    cmb_Departamento.SelectedValue = Dr_Empleado("Id_Departamento")
                Else
                    cmb_Departamento.SelectedValue = "0"
                End If
                If Not Dr_Empleado("Id_Puesto") Is Nothing Then
                    cmb_Puesto.SelectedValue = Dr_Empleado("Id_Puesto")
                Else
                    cmb_Puesto.SelectedValue = "0"
                End If
            Else
                cmb_Departamento.SelectedValue = "0"
                cmb_Puesto.SelectedValue = "0"
            End If
        Else
            cmb_Departamento.SelectedValue = "0"
            cmb_Puesto.SelectedValue = "0"
        End If
    End Sub

    Private Sub chk_ProgramacionCita_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ProgramacionCita.CheckedChanged
        SegundosDesconexion = 0

        gbx_InformacionCita.Enabled = chk_ProgramacionCita.Checked
        lbl_7.Visible = chk_ProgramacionCita.Checked
        tbx_Contacto.Clear()
        dtp_FechaCita.Value = Today.Date
        tbx_HorasCita.Clear()
    End Sub

    Private Sub dtp_FechaCita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaCita.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_HorasCita.Focus()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Validar() Then
            'Validar = True Cuando sea vaya a ingresar los datos para completar el registro, sino sería modificación
            If Modificar Then
                If Not fn_ActaInspeccion_Update(Id_Inspeccion, dtp_FechaVisita.Value.Date, dtp_HoraVisita.Value.TimeOfDay.ToString, tbx_PersonaRecibio.Text, tbx_UbicacionSugerida.Text, _
                                                    tbx_UbicacionSugeridaD.Text, tbx_Ventajas.Text, tbx_Desventajas.Text, tbx_NotasAdicionales.Text, cmb_PersonaInspeccion.SelectedValue, _
                                                    cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, cmb_JefeSeguridad.SelectedValue, tbx_Contacto.Text, dtp_FechaCita.Value.Date, _
                                                    tbx_HorasCita.Text, tbx_Piso.Text) Then
                    MsgBox("Ocurrio un error al intentar Guardar la Información de la Acta de Inspección para la Instalación de Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("MODIFICAR ORDEN DE INSPECCION: " & lbl_Acta.Text.Trim)
            Else
                If Not fn_ActaInspeccion_Validar(Id_Inspeccion, dtp_FechaVisita.Value.Date, dtp_HoraVisita.Value.TimeOfDay.ToString, tbx_PersonaRecibio.Text, tbx_UbicacionSugerida.Text, _
                                                    tbx_UbicacionSugeridaD.Text, tbx_Ventajas.Text, tbx_Desventajas.Text, tbx_NotasAdicionales.Text, cmb_PersonaInspeccion.SelectedValue, _
                                                    cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, cmb_JefeSeguridad.SelectedValue, tbx_Contacto.Text, dtp_FechaCita.Value.Date, _
                                                    tbx_HorasCita.Text, tbx_Piso.Text, Status) Then
                    MsgBox("Ocurrio un error al intentar Guardar la Información de la Acta de Inspección para la Instalación de Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("VALIDAR ORDEN DE INSPECCION: " & lbl_Acta.Text.Trim)
                'Cargar el Reporte para imprimirlo
                Dim ds As New ds_Reporte
                If Not fn_Reportes_Encabezado(ds.Tbl_DatosEmpresa) Then
                    MsgBox("Hubo un Error al Generar el Encabezado del Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                Call fn_ActaInspeccion_Imprimir(ds.Tbl_ActaInspeccion, Id_Inspeccion)
                'Mostrar el Reporte
                Dim rpt As New rpt_ActaInspeccionCajaFuerte

                '--------------pruebas de imagen en reportes {
                If Not IsDBNull(ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

                    Dim imagenNueva As Image = Nothing
                    Dim imagenBytes As Byte() = ds.Tbl_DatosEmpresa.Rows(0)("logo")
                    Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                    imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                    Dim Ancho As Integer = imagenNueva.Width
                    Dim Alto As Integer = imagenNueva.Height
                    Dim valordiv As Decimal = 0.0

                    With rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                        Dim Top_Obj As Integer = .Top
                        Dim Left_Obj As Integer = .Left '+- 342default
                        Dim Width_Obj As Integer = .Width '1440Default

                        If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                        Dim nuevoAncho As Integer = Ancho * valordiv
                        Dim NuevoAlto As Integer = Alto * valordiv

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

                    '-------liberar objetos
                    ms_ByteToImagen.Dispose()
                    imagenNueva.Dispose()
                End If
                '--------------}

                rpt.SetDataSource(ds)
                Dim frm As New frm_Reporte
                frm.crv.ReportSource = rpt
                frm.WindowState = FormWindowState.Maximized
                frm.ShowDialog()
            End If

            'MsgBox("Los Datos se guardaron correctamente", MsgBoxStyle.Information, frm_MENU.Text)
            Me.Close()
        End If
    End Sub

    Private Function Validar() As Boolean
        If Modificar Then
            Return True
        End If

        If tbx_PersonaRecibio.Text = "" Then
            MsgBox("Escriba el Nombre de la Persona que Recibió", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_DireccionCliente.Focus()
            Return False
        End If

        If tbx_UbicacionSugerida.Text = "" Then
            MsgBox("Escriba la Ubicación Sugerida para la Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_UbicacionSugerida.Focus()
            Return False
        End If

        If tbx_UbicacionSugeridaD.Text = "" Then
            MsgBox("Escriba a Detalle la Ubicación Sugerida para la Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_UbicacionSugeridaD.Focus()
            Return False
        End If

        If tbx_Ventajas.Text = "" Then
            MsgBox("Escriba las Ventajas de la Ubicación Sugerida para la Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Ventajas.Focus()
            Return False
        End If

        If tbx_Desventajas.Text = "" Then
            MsgBox("Escriba las Desventajas de la Ubicación Sugerida para la Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Desventajas.Focus()
            Return False
        End If

        If cmb_PersonaInspeccion.SelectedValue = "0" Then
            MsgBox("Seleccione el Empleado que fue a la Inspección", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PersonaInspeccion.Focus()
            Return False
        End If

        If cmb_JefeSeguridad.SelectedValue = "0" Then
            MsgBox("Seleccione el Jefe de Seguridad del Empleado que fue a la Inspección", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_JefeSeguridad.Focus()
            Return False
        End If

        If chk_ProgramacionCita.Checked Then
            If tbx_Contacto.Text = "" Then
                MsgBox("Escriba el Nombre del Contacto para la Cita Programada", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_JefeSeguridad.Focus()
                Return False
            End If

            If dtp_FechaCita.Value < Today.Date Then
                MsgBox("La Fecha de la Cita no puede ser menor a la Fecha Actual", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_JefeSeguridad.Focus()
                Return False
            End If

            If tbx_HorasCita.Text = "" Then
                MsgBox("Escriba en que Horario se Programo la Cita", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_JefeSeguridad.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub lsv_Imagenes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Imagenes.DoubleClick
        SegundosDesconexion = 0

        Dim frm As New frm_VisorImagenes

        If fn_InspeccionImagenes_CargarArreglo(Id_Inspeccion, lsv_Imagenes.SelectedItems(0).Tag) Then
            frm.ImagenBytes = Arreglo_Archivo(0).Objeto_Archivo
            frm.ShowDialog()
            Arreglo_Archivo = Nothing
        End If
    End Sub

    Private Sub btn_Importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.Filtro = "Imagenes (*.jpg)|*.jpg"
        frm.MaxArchivos = 3
        frm.Id_Tabla = Id_Inspeccion
        frm.Tipo = frm_CargarArchivos.Query.CajasFuertesInspeccion
        frm.ShowDialog()

        lsv_Imagenes.Items.Clear()
        If Not fn_InspeccionImagenes_LlenarLista(lsv_Imagenes, Id_Inspeccion) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class