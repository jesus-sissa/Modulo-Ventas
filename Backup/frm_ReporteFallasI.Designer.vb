﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteFallasI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Gbx_DatosFalla = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Lbl_Observacion = New System.Windows.Forms.Label
        Me.dtp_HoraRequerida = New System.Windows.Forms.DateTimePicker
        Me.lbl_HoraIngreso = New System.Windows.Forms.Label
        Me.cmb_DeptoDesignado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Lbl_DeptoDesig = New System.Windows.Forms.Label
        Me.dtp_FechaRequerida = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Ejemplo = New System.Windows.Forms.Label
        Me.rtb_Descripcion = New System.Windows.Forms.RichTextBox
        Me.cmb_UsuarioDesignado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.gbx_TipoSolicitud = New System.Windows.Forms.GroupBox
        Me.rdb_Equipo = New System.Windows.Forms.RadioButton
        Me.rdb_Otros = New System.Windows.Forms.RadioButton
        Me.rdb_Servicios = New System.Windows.Forms.RadioButton
        Me.lbl_Servicios = New System.Windows.Forms.Label
        Me.lbl_Equipo = New System.Windows.Forms.Label
        Me.tbx_CantidadSolicitada = New Modulo_Ventas.cp_Textbox
        Me.tbx_EquipoSustituye = New Modulo_Ventas.cp_Textbox
        Me.lbl_FechaRequerida = New System.Windows.Forms.Label
        Me.Lbl_UsuarioDesig = New System.Windows.Forms.Label
        Me.lbl_CantidadSolicitada = New System.Windows.Forms.Label
        Me.lbl_EquipoSustituye = New System.Windows.Forms.Label
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Descripcion = New System.Windows.Forms.GroupBox
        Me.Tbx_Adjunto = New System.Windows.Forms.TextBox
        Me.btn_Adjunto = New System.Windows.Forms.Button
        Me.Lbl_Adjunto = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.rtb_MotivoSolicitud = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_UsuarioSolicita = New System.Windows.Forms.Label
        Me.tbx_UsuarioSolicita = New Modulo_Ventas.cp_Textbox
        Me.Lbl_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Mensaje = New System.Windows.Forms.GroupBox
        Me.Pct_Alerta = New System.Windows.Forms.PictureBox
        Me.Lbl_Mensaje = New System.Windows.Forms.Label
        Me.Gbx_DatosFalla.SuspendLayout()
        Me.gbx_TipoSolicitud.SuspendLayout()
        Me.Gbx_Descripcion.SuspendLayout()
        Me.Lbl_Botones.SuspendLayout()
        Me.Gbx_Mensaje.SuspendLayout()
        CType(Me.Pct_Alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbx_DatosFalla
        '
        Me.Gbx_DatosFalla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_DatosFalla.Controls.Add(Me.Label12)
        Me.Gbx_DatosFalla.Controls.Add(Me.Label11)
        Me.Gbx_DatosFalla.Controls.Add(Me.Label9)
        Me.Gbx_DatosFalla.Controls.Add(Me.Label10)
        Me.Gbx_DatosFalla.Controls.Add(Me.Lbl_Observacion)
        Me.Gbx_DatosFalla.Controls.Add(Me.dtp_HoraRequerida)
        Me.Gbx_DatosFalla.Controls.Add(Me.lbl_HoraIngreso)
        Me.Gbx_DatosFalla.Controls.Add(Me.cmb_DeptoDesignado)
        Me.Gbx_DatosFalla.Controls.Add(Me.Lbl_DeptoDesig)
        Me.Gbx_DatosFalla.Controls.Add(Me.dtp_FechaRequerida)
        Me.Gbx_DatosFalla.Controls.Add(Me.Lbl_Ejemplo)
        Me.Gbx_DatosFalla.Controls.Add(Me.rtb_Descripcion)
        Me.Gbx_DatosFalla.Controls.Add(Me.cmb_UsuarioDesignado)
        Me.Gbx_DatosFalla.Controls.Add(Me.gbx_TipoSolicitud)
        Me.Gbx_DatosFalla.Controls.Add(Me.tbx_CantidadSolicitada)
        Me.Gbx_DatosFalla.Controls.Add(Me.tbx_EquipoSustituye)
        Me.Gbx_DatosFalla.Controls.Add(Me.lbl_FechaRequerida)
        Me.Gbx_DatosFalla.Controls.Add(Me.Lbl_UsuarioDesig)
        Me.Gbx_DatosFalla.Controls.Add(Me.lbl_CantidadSolicitada)
        Me.Gbx_DatosFalla.Controls.Add(Me.lbl_EquipoSustituye)
        Me.Gbx_DatosFalla.Controls.Add(Me.lbl_Descripcion)
        Me.Gbx_DatosFalla.Location = New System.Drawing.Point(12, 7)
        Me.Gbx_DatosFalla.Name = "Gbx_DatosFalla"
        Me.Gbx_DatosFalla.Size = New System.Drawing.Size(563, 315)
        Me.Gbx_DatosFalla.TabIndex = 0
        Me.Gbx_DatosFalla.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(523, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(523, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(523, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(523, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "*"
        '
        'Lbl_Observacion
        '
        Me.Lbl_Observacion.AutoSize = True
        Me.Lbl_Observacion.Location = New System.Drawing.Point(3, 143)
        Me.Lbl_Observacion.Name = "Lbl_Observacion"
        Me.Lbl_Observacion.Size = New System.Drawing.Size(122, 13)
        Me.Lbl_Observacion.TabIndex = 16
        Me.Lbl_Observacion.Text = "(Describa lo que solicita)"
        '
        'dtp_HoraRequerida
        '
        Me.dtp_HoraRequerida.CustomFormat = "HH:mm"
        Me.dtp_HoraRequerida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_HoraRequerida.Location = New System.Drawing.Point(444, 231)
        Me.dtp_HoraRequerida.Name = "dtp_HoraRequerida"
        Me.dtp_HoraRequerida.ShowUpDown = True
        Me.dtp_HoraRequerida.Size = New System.Drawing.Size(73, 20)
        Me.dtp_HoraRequerida.TabIndex = 11
        '
        'lbl_HoraIngreso
        '
        Me.lbl_HoraIngreso.AutoSize = True
        Me.lbl_HoraIngreso.Location = New System.Drawing.Point(355, 235)
        Me.lbl_HoraIngreso.Name = "lbl_HoraIngreso"
        Me.lbl_HoraIngreso.Size = New System.Drawing.Size(82, 13)
        Me.lbl_HoraIngreso.TabIndex = 10
        Me.lbl_HoraIngreso.Text = "Hora Requerida"
        '
        'cmb_DeptoDesignado
        '
        Me.cmb_DeptoDesignado.Clave = Nothing
        Me.cmb_DeptoDesignado.Control_Siguiente = Nothing
        Me.cmb_DeptoDesignado.DisplayMember = "Descripcion"
        Me.cmb_DeptoDesignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DeptoDesignado.Empresa = False
        Me.cmb_DeptoDesignado.Filtro = Nothing
        Me.cmb_DeptoDesignado.FormattingEnabled = True
        Me.cmb_DeptoDesignado.Location = New System.Drawing.Point(126, 258)
        Me.cmb_DeptoDesignado.MaxDropDownItems = 20
        Me.cmb_DeptoDesignado.Name = "cmb_DeptoDesignado"
        Me.cmb_DeptoDesignado.Pista = False
        Me.cmb_DeptoDesignado.Size = New System.Drawing.Size(391, 21)
        Me.cmb_DeptoDesignado.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DeptoDesignado.Sucursal = False
        Me.cmb_DeptoDesignado.TabIndex = 13
        Me.cmb_DeptoDesignado.Tipo = 0
        Me.cmb_DeptoDesignado.ValueMember = "Id_Departamento"
        '
        'Lbl_DeptoDesig
        '
        Me.Lbl_DeptoDesig.AutoSize = True
        Me.Lbl_DeptoDesig.Location = New System.Drawing.Point(27, 261)
        Me.Lbl_DeptoDesig.Name = "Lbl_DeptoDesig"
        Me.Lbl_DeptoDesig.Size = New System.Drawing.Size(93, 13)
        Me.Lbl_DeptoDesig.TabIndex = 12
        Me.Lbl_DeptoDesig.Text = "Depto. Designado"
        '
        'dtp_FechaRequerida
        '
        Me.dtp_FechaRequerida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaRequerida.Location = New System.Drawing.Point(254, 232)
        Me.dtp_FechaRequerida.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_FechaRequerida.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_FechaRequerida.Name = "dtp_FechaRequerida"
        Me.dtp_FechaRequerida.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaRequerida.TabIndex = 9
        Me.dtp_FechaRequerida.Value = New Date(2011, 10, 4, 0, 0, 0, 0)
        '
        'Lbl_Ejemplo
        '
        Me.Lbl_Ejemplo.AutoSize = True
        Me.Lbl_Ejemplo.Location = New System.Drawing.Point(123, 190)
        Me.Lbl_Ejemplo.Name = "Lbl_Ejemplo"
        Me.Lbl_Ejemplo.Size = New System.Drawing.Size(258, 13)
        Me.Lbl_Ejemplo.TabIndex = 3
        Me.Lbl_Ejemplo.Text = "En caso de que el equipo sustituya a otro descríbalo."
        '
        'rtb_Descripcion
        '
        Me.rtb_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb_Descripcion.Location = New System.Drawing.Point(126, 123)
        Me.rtb_Descripcion.MaxLength = 3000
        Me.rtb_Descripcion.Name = "rtb_Descripcion"
        Me.rtb_Descripcion.Size = New System.Drawing.Size(391, 64)
        Me.rtb_Descripcion.TabIndex = 2
        Me.rtb_Descripcion.Text = ""
        '
        'cmb_UsuarioDesignado
        '
        Me.cmb_UsuarioDesignado.Clave = Nothing
        Me.cmb_UsuarioDesignado.Control_Siguiente = Nothing
        Me.cmb_UsuarioDesignado.DisplayMember = "Nombre"
        Me.cmb_UsuarioDesignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioDesignado.Empresa = False
        Me.cmb_UsuarioDesignado.Filtro = Nothing
        Me.cmb_UsuarioDesignado.FormattingEnabled = True
        Me.cmb_UsuarioDesignado.Location = New System.Drawing.Point(126, 285)
        Me.cmb_UsuarioDesignado.MaxDropDownItems = 20
        Me.cmb_UsuarioDesignado.Name = "cmb_UsuarioDesignado"
        Me.cmb_UsuarioDesignado.Pista = False
        Me.cmb_UsuarioDesignado.Size = New System.Drawing.Size(391, 21)
        Me.cmb_UsuarioDesignado.StoredProcedure = "Cat_Empleados_ComboGetByDepto"
        Me.cmb_UsuarioDesignado.Sucursal = True
        Me.cmb_UsuarioDesignado.TabIndex = 15
        Me.cmb_UsuarioDesignado.Tipo = 0
        Me.cmb_UsuarioDesignado.ValueMember = "Id_Empleado"
        '
        'gbx_TipoSolicitud
        '
        Me.gbx_TipoSolicitud.Controls.Add(Me.rdb_Equipo)
        Me.gbx_TipoSolicitud.Controls.Add(Me.rdb_Otros)
        Me.gbx_TipoSolicitud.Controls.Add(Me.rdb_Servicios)
        Me.gbx_TipoSolicitud.Controls.Add(Me.lbl_Servicios)
        Me.gbx_TipoSolicitud.Controls.Add(Me.lbl_Equipo)
        Me.gbx_TipoSolicitud.Location = New System.Drawing.Point(126, 19)
        Me.gbx_TipoSolicitud.Name = "gbx_TipoSolicitud"
        Me.gbx_TipoSolicitud.Size = New System.Drawing.Size(391, 98)
        Me.gbx_TipoSolicitud.TabIndex = 0
        Me.gbx_TipoSolicitud.TabStop = False
        Me.gbx_TipoSolicitud.Text = "Tipo de Solicitud"
        '
        'rdb_Equipo
        '
        Me.rdb_Equipo.AutoSize = True
        Me.rdb_Equipo.Location = New System.Drawing.Point(7, 22)
        Me.rdb_Equipo.Name = "rdb_Equipo"
        Me.rdb_Equipo.Size = New System.Drawing.Size(58, 17)
        Me.rdb_Equipo.TabIndex = 0
        Me.rdb_Equipo.Tag = "1"
        Me.rdb_Equipo.Text = "Equipo"
        Me.rdb_Equipo.UseVisualStyleBackColor = True
        '
        'rdb_Otros
        '
        Me.rdb_Otros.AutoSize = True
        Me.rdb_Otros.Location = New System.Drawing.Point(7, 71)
        Me.rdb_Otros.Name = "rdb_Otros"
        Me.rdb_Otros.Size = New System.Drawing.Size(50, 17)
        Me.rdb_Otros.TabIndex = 2
        Me.rdb_Otros.Text = "Otros"
        Me.rdb_Otros.UseVisualStyleBackColor = True
        '
        'rdb_Servicios
        '
        Me.rdb_Servicios.AutoSize = True
        Me.rdb_Servicios.Location = New System.Drawing.Point(7, 46)
        Me.rdb_Servicios.Name = "rdb_Servicios"
        Me.rdb_Servicios.Size = New System.Drawing.Size(63, 17)
        Me.rdb_Servicios.TabIndex = 4
        Me.rdb_Servicios.Text = "Servicio"
        Me.rdb_Servicios.UseVisualStyleBackColor = True
        '
        'lbl_Servicios
        '
        Me.lbl_Servicios.AutoSize = True
        Me.lbl_Servicios.Location = New System.Drawing.Point(100, 48)
        Me.lbl_Servicios.Name = "lbl_Servicios"
        Me.lbl_Servicios.Size = New System.Drawing.Size(249, 13)
        Me.lbl_Servicios.TabIndex = 5
        Me.lbl_Servicios.Text = "Asesoría, capacitación, mantenimiento equipo, etc."
        '
        'lbl_Equipo
        '
        Me.lbl_Equipo.AutoSize = True
        Me.lbl_Equipo.Location = New System.Drawing.Point(100, 24)
        Me.lbl_Equipo.Name = "lbl_Equipo"
        Me.lbl_Equipo.Size = New System.Drawing.Size(165, 13)
        Me.lbl_Equipo.TabIndex = 1
        Me.lbl_Equipo.Text = "Equipo electrónico, mobiliario, etc"
        '
        'tbx_CantidadSolicitada
        '
        Me.tbx_CantidadSolicitada.Control_Siguiente = Nothing
        Me.tbx_CantidadSolicitada.Filtrado = True
        Me.tbx_CantidadSolicitada.Location = New System.Drawing.Point(126, 232)
        Me.tbx_CantidadSolicitada.MaxLength = 2
        Me.tbx_CantidadSolicitada.Name = "tbx_CantidadSolicitada"
        Me.tbx_CantidadSolicitada.Size = New System.Drawing.Size(33, 20)
        Me.tbx_CantidadSolicitada.TabIndex = 7
        Me.tbx_CantidadSolicitada.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_EquipoSustituye
        '
        Me.tbx_EquipoSustituye.Control_Siguiente = Nothing
        Me.tbx_EquipoSustituye.Enabled = False
        Me.tbx_EquipoSustituye.Filtrado = True
        Me.tbx_EquipoSustituye.Location = New System.Drawing.Point(126, 206)
        Me.tbx_EquipoSustituye.MaxLength = 50
        Me.tbx_EquipoSustituye.Name = "tbx_EquipoSustituye"
        Me.tbx_EquipoSustituye.Size = New System.Drawing.Size(391, 20)
        Me.tbx_EquipoSustituye.TabIndex = 5
        Me.tbx_EquipoSustituye.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_FechaRequerida
        '
        Me.lbl_FechaRequerida.AutoSize = True
        Me.lbl_FechaRequerida.Location = New System.Drawing.Point(162, 236)
        Me.lbl_FechaRequerida.Name = "lbl_FechaRequerida"
        Me.lbl_FechaRequerida.Size = New System.Drawing.Size(89, 13)
        Me.lbl_FechaRequerida.TabIndex = 8
        Me.lbl_FechaRequerida.Text = "Fecha Requerida"
        '
        'Lbl_UsuarioDesig
        '
        Me.Lbl_UsuarioDesig.AutoSize = True
        Me.Lbl_UsuarioDesig.Location = New System.Drawing.Point(23, 288)
        Me.Lbl_UsuarioDesig.Name = "Lbl_UsuarioDesig"
        Me.Lbl_UsuarioDesig.Size = New System.Drawing.Size(97, 13)
        Me.Lbl_UsuarioDesig.TabIndex = 14
        Me.Lbl_UsuarioDesig.Text = "Usuario Designado"
        '
        'lbl_CantidadSolicitada
        '
        Me.lbl_CantidadSolicitada.AutoSize = True
        Me.lbl_CantidadSolicitada.Location = New System.Drawing.Point(22, 235)
        Me.lbl_CantidadSolicitada.Name = "lbl_CantidadSolicitada"
        Me.lbl_CantidadSolicitada.Size = New System.Drawing.Size(98, 13)
        Me.lbl_CantidadSolicitada.TabIndex = 6
        Me.lbl_CantidadSolicitada.Text = "Cantidad Solicitada"
        '
        'lbl_EquipoSustituye
        '
        Me.lbl_EquipoSustituye.AutoSize = True
        Me.lbl_EquipoSustituye.Location = New System.Drawing.Point(34, 209)
        Me.lbl_EquipoSustituye.Name = "lbl_EquipoSustituye"
        Me.lbl_EquipoSustituye.Size = New System.Drawing.Size(86, 13)
        Me.lbl_EquipoSustituye.TabIndex = 4
        Me.lbl_EquipoSustituye.Text = "Equipo Sustituye"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(57, 126)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 1
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Gbx_Descripcion
        '
        Me.Gbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Descripcion.Controls.Add(Me.Tbx_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.btn_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.Label13)
        Me.Gbx_Descripcion.Controls.Add(Me.rtb_MotivoSolicitud)
        Me.Gbx_Descripcion.Controls.Add(Me.Label2)
        Me.Gbx_Descripcion.Controls.Add(Me.lbl_UsuarioSolicita)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_UsuarioSolicita)
        Me.Gbx_Descripcion.Location = New System.Drawing.Point(12, 392)
        Me.Gbx_Descripcion.Name = "Gbx_Descripcion"
        Me.Gbx_Descripcion.Size = New System.Drawing.Size(563, 181)
        Me.Gbx_Descripcion.TabIndex = 2
        Me.Gbx_Descripcion.TabStop = False
        '
        'Tbx_Adjunto
        '
        Me.Tbx_Adjunto.Location = New System.Drawing.Point(126, 136)
        Me.Tbx_Adjunto.Name = "Tbx_Adjunto"
        Me.Tbx_Adjunto.Size = New System.Drawing.Size(391, 20)
        Me.Tbx_Adjunto.TabIndex = 28
        '
        'btn_Adjunto
        '
        Me.btn_Adjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Adjunto.Location = New System.Drawing.Point(523, 133)
        Me.btn_Adjunto.Name = "btn_Adjunto"
        Me.btn_Adjunto.Size = New System.Drawing.Size(29, 23)
        Me.btn_Adjunto.TabIndex = 27
        Me.btn_Adjunto.Text = "..."
        Me.btn_Adjunto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Adjunto.UseVisualStyleBackColor = True
        '
        'Lbl_Adjunto
        '
        Me.Lbl_Adjunto.AutoSize = True
        Me.Lbl_Adjunto.Location = New System.Drawing.Point(123, 120)
        Me.Lbl_Adjunto.Name = "Lbl_Adjunto"
        Me.Lbl_Adjunto.Size = New System.Drawing.Size(148, 13)
        Me.Lbl_Adjunto.TabIndex = 26
        Me.Lbl_Adjunto.Text = "Adjuntar un Archivo(Opcional)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(523, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "*"
        '
        'rtb_MotivoSolicitud
        '
        Me.rtb_MotivoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb_MotivoSolicitud.Location = New System.Drawing.Point(126, 41)
        Me.rtb_MotivoSolicitud.MaxLength = 3000
        Me.rtb_MotivoSolicitud.Name = "rtb_MotivoSolicitud"
        Me.rtb_MotivoSolicitud.Size = New System.Drawing.Size(391, 76)
        Me.rtb_MotivoSolicitud.TabIndex = 3
        Me.rtb_MotivoSolicitud.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Motivo de Solicitud"
        '
        'lbl_UsuarioSolicita
        '
        Me.lbl_UsuarioSolicita.AutoSize = True
        Me.lbl_UsuarioSolicita.Location = New System.Drawing.Point(19, 18)
        Me.lbl_UsuarioSolicita.Name = "lbl_UsuarioSolicita"
        Me.lbl_UsuarioSolicita.Size = New System.Drawing.Size(101, 13)
        Me.lbl_UsuarioSolicita.TabIndex = 0
        Me.lbl_UsuarioSolicita.Text = "Usuario que Solicita"
        '
        'tbx_UsuarioSolicita
        '
        Me.tbx_UsuarioSolicita.Control_Siguiente = Nothing
        Me.tbx_UsuarioSolicita.Enabled = False
        Me.tbx_UsuarioSolicita.Filtrado = True
        Me.tbx_UsuarioSolicita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_UsuarioSolicita.Location = New System.Drawing.Point(126, 15)
        Me.tbx_UsuarioSolicita.MaxLength = 100
        Me.tbx_UsuarioSolicita.Name = "tbx_UsuarioSolicita"
        Me.tbx_UsuarioSolicita.Size = New System.Drawing.Size(391, 21)
        Me.tbx_UsuarioSolicita.TabIndex = 1
        Me.tbx_UsuarioSolicita.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_Botones
        '
        Me.Lbl_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Lbl_Botones.Controls.Add(Me.btn_Guardar)
        Me.Lbl_Botones.Location = New System.Drawing.Point(12, 579)
        Me.Lbl_Botones.Name = "Lbl_Botones"
        Me.Lbl_Botones.Size = New System.Drawing.Size(563, 50)
        Me.Lbl_Botones.TabIndex = 3
        Me.Lbl_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(417, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Mensaje
        '
        Me.Gbx_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Mensaje.Controls.Add(Me.Pct_Alerta)
        Me.Gbx_Mensaje.Controls.Add(Me.Lbl_Mensaje)
        Me.Gbx_Mensaje.Location = New System.Drawing.Point(12, 328)
        Me.Gbx_Mensaje.Name = "Gbx_Mensaje"
        Me.Gbx_Mensaje.Size = New System.Drawing.Size(563, 62)
        Me.Gbx_Mensaje.TabIndex = 1
        Me.Gbx_Mensaje.TabStop = False
        '
        'Pct_Alerta
        '
        Me.Pct_Alerta.Image = Global.Modulo_Ventas.My.Resources.Resources.Atencion
        Me.Pct_Alerta.Location = New System.Drawing.Point(64, 10)
        Me.Pct_Alerta.Name = "Pct_Alerta"
        Me.Pct_Alerta.Size = New System.Drawing.Size(48, 47)
        Me.Pct_Alerta.TabIndex = 1
        Me.Pct_Alerta.TabStop = False
        '
        'Lbl_Mensaje
        '
        Me.Lbl_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mensaje.Location = New System.Drawing.Point(118, 14)
        Me.Lbl_Mensaje.Name = "Lbl_Mensaje"
        Me.Lbl_Mensaje.Size = New System.Drawing.Size(399, 38)
        Me.Lbl_Mensaje.TabIndex = 0
        Me.Lbl_Mensaje.Text = "Para agilizar la atención de su solicitud es necesario que describa el motivo lo " & _
            "mas claro posible."
        '
        'frm_ReporteFallasI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 641)
        Me.Controls.Add(Me.Gbx_Mensaje)
        Me.Controls.Add(Me.Lbl_Botones)
        Me.Controls.Add(Me.Gbx_Descripcion)
        Me.Controls.Add(Me.Gbx_DatosFalla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(590, 670)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(590, 670)
        Me.Name = "frm_ReporteFallasI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Equipo, Servicio y Otros"
        Me.Gbx_DatosFalla.ResumeLayout(False)
        Me.Gbx_DatosFalla.PerformLayout()
        Me.gbx_TipoSolicitud.ResumeLayout(False)
        Me.gbx_TipoSolicitud.PerformLayout()
        Me.Gbx_Descripcion.ResumeLayout(False)
        Me.Gbx_Descripcion.PerformLayout()
        Me.Lbl_Botones.ResumeLayout(False)
        Me.Gbx_Mensaje.ResumeLayout(False)
        CType(Me.Pct_Alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_DatosFalla As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_UsuarioSolicita As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Mensaje As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents Pct_Alerta As System.Windows.Forms.PictureBox
    Friend WithEvents rdb_Otros As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Equipo As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents tbx_EquipoSustituye As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_EquipoSustituye As System.Windows.Forms.Label
    Friend WithEvents tbx_CantidadSolicitada As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CantidadSolicitada As System.Windows.Forms.Label
    Friend WithEvents rtb_MotivoSolicitud As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdb_Servicios As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_TipoSolicitud As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FechaRequerida As System.Windows.Forms.Label
    Friend WithEvents Lbl_UsuarioDesig As System.Windows.Forms.Label
    Friend WithEvents lbl_Servicios As System.Windows.Forms.Label
    Friend WithEvents lbl_Equipo As System.Windows.Forms.Label
    Friend WithEvents cmb_UsuarioDesignado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Ejemplo As System.Windows.Forms.Label
    Friend WithEvents rtb_Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents dtp_FechaRequerida As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_DeptoDesignado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_DeptoDesig As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraRequerida As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraIngreso As System.Windows.Forms.Label
    Friend WithEvents tbx_UsuarioSolicita As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Observacion As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Tbx_Adjunto As System.Windows.Forms.TextBox
    Friend WithEvents btn_Adjunto As System.Windows.Forms.Button
    Friend WithEvents Lbl_Adjunto As System.Windows.Forms.Label
End Class
