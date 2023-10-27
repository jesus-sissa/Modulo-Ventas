<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActaInspeccionDetalle
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
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.btn_Importar = New System.Windows.Forms.Button
        Me.lbl_4 = New System.Windows.Forms.Label
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.lbl_3 = New System.Windows.Forms.Label
        Me.lbl_2 = New System.Windows.Forms.Label
        Me.lbl_FechaVisita = New System.Windows.Forms.Label
        Me.dtp_FechaVisita = New System.Windows.Forms.DateTimePicker
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_DireccionCliente = New System.Windows.Forms.Label
        Me.lbl_ClienteFiscal = New System.Windows.Forms.Label
        Me.lbl_PersonaRecibio = New System.Windows.Forms.Label
        Me.lbl_UbicacionSugeridaD = New System.Windows.Forms.Label
        Me.lbl_UbicacionSugerida = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.gbx_Imagenes = New System.Windows.Forms.GroupBox
        Me.lsv_Imagenes = New Modulo_Ventas.cp_Listview
        Me.Lbl_DActa = New System.Windows.Forms.Label
        Me.lbl_Acta = New System.Windows.Forms.Label
        Me.chk_ProgramacionCita = New System.Windows.Forms.CheckBox
        Me.gbx_InformacionCita = New System.Windows.Forms.GroupBox
        Me.tbx_HorasCita = New Modulo_Ventas.cp_Textbox
        Me.lbl_HorasCita = New System.Windows.Forms.Label
        Me.dtp_FechaCita = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaCita = New System.Windows.Forms.Label
        Me.lbl_Contacto = New System.Windows.Forms.Label
        Me.lbl_7 = New System.Windows.Forms.Label
        Me.tbx_Contacto = New Modulo_Ventas.cp_Textbox
        Me.gbx_InformacionCliente = New System.Windows.Forms.GroupBox
        Me.tbx_NombreF = New Modulo_Ventas.cp_Textbox
        Me.tbx_DireccionCliente = New Modulo_Ventas.cp_Textbox
        Me.tbx_UbicacionSugerida = New Modulo_Ventas.cp_Textbox
        Me.tbx_UbicacionSugeridaD = New Modulo_Ventas.cp_Textbox
        Me.tbx_Piso = New Modulo_Ventas.cp_Textbox
        Me.tbx_Ventajas = New Modulo_Ventas.cp_Textbox
        Me.tbx_Desventajas = New Modulo_Ventas.cp_Textbox
        Me.tbx_NotasAdicionales = New Modulo_Ventas.cp_Textbox
        Me.tbx_ClavePersonaInspeccion = New Modulo_Ventas.cp_Textbox
        Me.cmb_PersonaInspeccion = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Departamento = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Puesto = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveJefeSeguridad = New Modulo_Ventas.cp_Textbox
        Me.cmb_JefeSeguridad = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_PersonaRecibio = New Modulo_Ventas.cp_Textbox
        Me.gbx_InformacionEmpleado = New System.Windows.Forms.GroupBox
        Me.Lbl_JefeSeg = New System.Windows.Forms.Label
        Me.lbl_PersonaInspeccion = New System.Windows.Forms.Label
        Me.lbl_Departamento = New System.Windows.Forms.Label
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.lbl_6 = New System.Windows.Forms.Label
        Me.gbx_UbicacionSugerida = New System.Windows.Forms.GroupBox
        Me.lbl_Ejemplo = New System.Windows.Forms.Label
        Me.lbl_Piso = New System.Windows.Forms.Label
        Me.lbl_Ventajas = New System.Windows.Forms.Label
        Me.lbl_Desventajas = New System.Windows.Forms.Label
        Me.lbl_NotasAdicionales = New System.Windows.Forms.Label
        Me.dtp_HoraVisita = New System.Windows.Forms.DateTimePicker
        Me.lbl_HoraVisita = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Imagenes.SuspendLayout()
        Me.gbx_InformacionCita.SuspendLayout()
        Me.gbx_InformacionCliente.SuspendLayout()
        Me.gbx_InformacionEmpleado.SuspendLayout()
        Me.gbx_UbicacionSugerida.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Importar
        '
        Me.btn_Importar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Importar.Image = Global.Modulo_Ventas.My.Resources.Resources.Camara
        Me.btn_Importar.Location = New System.Drawing.Point(152, 13)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Importar.TabIndex = 1
        Me.btn_Importar.Text = "&Importar/Exportar"
        Me.btn_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Importar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_4.ForeColor = System.Drawing.Color.Red
        Me.lbl_4.Location = New System.Drawing.Point(190, -3)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(13, 17)
        Me.lbl_4.TabIndex = 0
        Me.lbl_4.Text = "*"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Red
        Me.lbl_1.Location = New System.Drawing.Point(190, 22)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(13, 17)
        Me.lbl_1.TabIndex = 2
        Me.lbl_1.Text = "*"
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.ForeColor = System.Drawing.Color.Red
        Me.lbl_3.Location = New System.Drawing.Point(120, -3)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(13, 17)
        Me.lbl_3.TabIndex = 0
        Me.lbl_3.Text = "*"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.Red
        Me.lbl_2.Location = New System.Drawing.Point(387, 20)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(13, 17)
        Me.lbl_2.TabIndex = 5
        Me.lbl_2.Text = "*"
        '
        'lbl_FechaVisita
        '
        Me.lbl_FechaVisita.AutoSize = True
        Me.lbl_FechaVisita.Location = New System.Drawing.Point(3, 24)
        Me.lbl_FechaVisita.Name = "lbl_FechaVisita"
        Me.lbl_FechaVisita.Size = New System.Drawing.Size(80, 13)
        Me.lbl_FechaVisita.TabIndex = 0
        Me.lbl_FechaVisita.Text = "Fecha de Visita"
        '
        'dtp_FechaVisita
        '
        Me.dtp_FechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVisita.Location = New System.Drawing.Point(89, 20)
        Me.dtp_FechaVisita.Name = "dtp_FechaVisita"
        Me.dtp_FechaVisita.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaVisita.TabIndex = 1
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_DireccionCliente
        '
        Me.lbl_DireccionCliente.Location = New System.Drawing.Point(19, 49)
        Me.lbl_DireccionCliente.Name = "lbl_DireccionCliente"
        Me.lbl_DireccionCliente.Size = New System.Drawing.Size(58, 32)
        Me.lbl_DireccionCliente.TabIndex = 3
        Me.lbl_DireccionCliente.Text = "Dirección del Cliente"
        Me.lbl_DireccionCliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ClienteFiscal
        '
        Me.lbl_ClienteFiscal.AutoSize = True
        Me.lbl_ClienteFiscal.Location = New System.Drawing.Point(38, 23)
        Me.lbl_ClienteFiscal.Name = "lbl_ClienteFiscal"
        Me.lbl_ClienteFiscal.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ClienteFiscal.TabIndex = 1
        Me.lbl_ClienteFiscal.Text = "Cliente"
        '
        'lbl_PersonaRecibio
        '
        Me.lbl_PersonaRecibio.Location = New System.Drawing.Point(6, 87)
        Me.lbl_PersonaRecibio.Name = "lbl_PersonaRecibio"
        Me.lbl_PersonaRecibio.Size = New System.Drawing.Size(71, 26)
        Me.lbl_PersonaRecibio.TabIndex = 5
        Me.lbl_PersonaRecibio.Text = "Persona que Recibió"
        Me.lbl_PersonaRecibio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_UbicacionSugeridaD
        '
        Me.lbl_UbicacionSugeridaD.AutoSize = True
        Me.lbl_UbicacionSugeridaD.Location = New System.Drawing.Point(389, 22)
        Me.lbl_UbicacionSugeridaD.Name = "lbl_UbicacionSugeridaD"
        Me.lbl_UbicacionSugeridaD.Size = New System.Drawing.Size(63, 13)
        Me.lbl_UbicacionSugeridaD.TabIndex = 3
        Me.lbl_UbicacionSugeridaD.Text = "Descripción"
        Me.lbl_UbicacionSugeridaD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_UbicacionSugerida
        '
        Me.lbl_UbicacionSugerida.AutoSize = True
        Me.lbl_UbicacionSugerida.Location = New System.Drawing.Point(22, 22)
        Me.lbl_UbicacionSugerida.Name = "lbl_UbicacionSugerida"
        Me.lbl_UbicacionSugerida.Size = New System.Drawing.Size(55, 13)
        Me.lbl_UbicacionSugerida.TabIndex = 1
        Me.lbl_UbicacionSugerida.Text = "Ubicación"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Importar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 549)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(780, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(634, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.gbx_Imagenes)
        Me.gbx_Datos.Controls.Add(Me.Lbl_DActa)
        Me.gbx_Datos.Controls.Add(Me.lbl_Acta)
        Me.gbx_Datos.Controls.Add(Me.chk_ProgramacionCita)
        Me.gbx_Datos.Controls.Add(Me.gbx_InformacionCita)
        Me.gbx_Datos.Controls.Add(Me.gbx_InformacionCliente)
        Me.gbx_Datos.Controls.Add(Me.gbx_InformacionEmpleado)
        Me.gbx_Datos.Controls.Add(Me.gbx_UbicacionSugerida)
        Me.gbx_Datos.Controls.Add(Me.tbx_NotasAdicionales)
        Me.gbx_Datos.Controls.Add(Me.lbl_NotasAdicionales)
        Me.gbx_Datos.Controls.Add(Me.dtp_HoraVisita)
        Me.gbx_Datos.Controls.Add(Me.lbl_HoraVisita)
        Me.gbx_Datos.Controls.Add(Me.dtp_FechaVisita)
        Me.gbx_Datos.Controls.Add(Me.lbl_1)
        Me.gbx_Datos.Controls.Add(Me.lbl_FechaVisita)
        Me.gbx_Datos.Controls.Add(Me.lbl_2)
        Me.gbx_Datos.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(780, 541)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        Me.gbx_Datos.Text = "Acta de Inspección No."
        '
        'gbx_Imagenes
        '
        Me.gbx_Imagenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Imagenes.Controls.Add(Me.lsv_Imagenes)
        Me.gbx_Imagenes.Location = New System.Drawing.Point(505, 330)
        Me.gbx_Imagenes.Name = "gbx_Imagenes"
        Me.gbx_Imagenes.Size = New System.Drawing.Size(269, 148)
        Me.gbx_Imagenes.TabIndex = 13
        Me.gbx_Imagenes.TabStop = False
        Me.gbx_Imagenes.Text = "Imágenes"
        '
        'lsv_Imagenes
        '
        Me.lsv_Imagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Imagenes.FullRowSelect = True
        Me.lsv_Imagenes.HideSelection = False
        Me.lsv_Imagenes.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Imagenes.Lvs = ListViewColumnSorter1
        Me.lsv_Imagenes.MultiSelect = False
        Me.lsv_Imagenes.Name = "lsv_Imagenes"
        Me.lsv_Imagenes.Row1 = 95
        Me.lsv_Imagenes.Row10 = 0
        Me.lsv_Imagenes.Row2 = 0
        Me.lsv_Imagenes.Row3 = 0
        Me.lsv_Imagenes.Row4 = 0
        Me.lsv_Imagenes.Row5 = 0
        Me.lsv_Imagenes.Row6 = 0
        Me.lsv_Imagenes.Row7 = 0
        Me.lsv_Imagenes.Row8 = 0
        Me.lsv_Imagenes.Row9 = 0
        Me.lsv_Imagenes.Size = New System.Drawing.Size(263, 129)
        Me.lsv_Imagenes.TabIndex = 0
        Me.lsv_Imagenes.UseCompatibleStateImageBehavior = False
        Me.lsv_Imagenes.View = System.Windows.Forms.View.Details
        '
        'Lbl_DActa
        '
        Me.Lbl_DActa.AutoSize = True
        Me.Lbl_DActa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DActa.Location = New System.Drawing.Point(680, 24)
        Me.Lbl_DActa.Name = "Lbl_DActa"
        Me.Lbl_DActa.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_DActa.TabIndex = 6
        Me.Lbl_DActa.Text = "Acta:"
        '
        'lbl_Acta
        '
        Me.lbl_Acta.AutoSize = True
        Me.lbl_Acta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Acta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Acta.Location = New System.Drawing.Point(715, 18)
        Me.lbl_Acta.Name = "lbl_Acta"
        Me.lbl_Acta.Size = New System.Drawing.Size(21, 24)
        Me.lbl_Acta.TabIndex = 7
        Me.lbl_Acta.Text = "0"
        '
        'chk_ProgramacionCita
        '
        Me.chk_ProgramacionCita.AutoSize = True
        Me.chk_ProgramacionCita.Location = New System.Drawing.Point(6, 462)
        Me.chk_ProgramacionCita.Name = "chk_ProgramacionCita"
        Me.chk_ProgramacionCita.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_ProgramacionCita.Size = New System.Drawing.Size(307, 17)
        Me.chk_ProgramacionCita.TabIndex = 15
        Me.chk_ProgramacionCita.Text = "?Se Programó una Cita para la Instalación de la Caja Fuerte"
        Me.chk_ProgramacionCita.UseVisualStyleBackColor = True
        '
        'gbx_InformacionCita
        '
        Me.gbx_InformacionCita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_InformacionCita.Controls.Add(Me.tbx_HorasCita)
        Me.gbx_InformacionCita.Controls.Add(Me.lbl_HorasCita)
        Me.gbx_InformacionCita.Controls.Add(Me.dtp_FechaCita)
        Me.gbx_InformacionCita.Controls.Add(Me.lbl_FechaCita)
        Me.gbx_InformacionCita.Controls.Add(Me.lbl_Contacto)
        Me.gbx_InformacionCita.Controls.Add(Me.lbl_7)
        Me.gbx_InformacionCita.Controls.Add(Me.tbx_Contacto)
        Me.gbx_InformacionCita.Enabled = False
        Me.gbx_InformacionCita.Location = New System.Drawing.Point(6, 484)
        Me.gbx_InformacionCita.Name = "gbx_InformacionCita"
        Me.gbx_InformacionCita.Size = New System.Drawing.Size(768, 51)
        Me.gbx_InformacionCita.TabIndex = 16
        Me.gbx_InformacionCita.TabStop = False
        Me.gbx_InformacionCita.Text = "Información para la Programación de la Cita"
        '
        'tbx_HorasCita
        '
        Me.tbx_HorasCita.Control_Siguiente = Me.btn_Guardar
        Me.tbx_HorasCita.Filtrado = True
        Me.tbx_HorasCita.Location = New System.Drawing.Point(617, 19)
        Me.tbx_HorasCita.MaxLength = 50
        Me.tbx_HorasCita.Name = "tbx_HorasCita"
        Me.tbx_HorasCita.Size = New System.Drawing.Size(148, 20)
        Me.tbx_HorasCita.TabIndex = 6
        Me.tbx_HorasCita.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_HorasCita
        '
        Me.lbl_HorasCita.AutoSize = True
        Me.lbl_HorasCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HorasCita.Location = New System.Drawing.Point(526, 22)
        Me.lbl_HorasCita.Name = "lbl_HorasCita"
        Me.lbl_HorasCita.Size = New System.Drawing.Size(85, 13)
        Me.lbl_HorasCita.TabIndex = 5
        Me.lbl_HorasCita.Text = "Rango de Horas"
        '
        'dtp_FechaCita
        '
        Me.dtp_FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaCita.Location = New System.Drawing.Point(418, 19)
        Me.dtp_FechaCita.Name = "dtp_FechaCita"
        Me.dtp_FechaCita.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FechaCita.TabIndex = 4
        '
        'lbl_FechaCita
        '
        Me.lbl_FechaCita.AutoSize = True
        Me.lbl_FechaCita.Location = New System.Drawing.Point(375, 22)
        Me.lbl_FechaCita.Name = "lbl_FechaCita"
        Me.lbl_FechaCita.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaCita.TabIndex = 3
        Me.lbl_FechaCita.Text = "Fecha"
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(27, 22)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Contacto.TabIndex = 1
        Me.lbl_Contacto.Text = "Contacto"
        Me.lbl_Contacto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_7
        '
        Me.lbl_7.AutoSize = True
        Me.lbl_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7.ForeColor = System.Drawing.Color.Red
        Me.lbl_7.Location = New System.Drawing.Point(218, -3)
        Me.lbl_7.Name = "lbl_7"
        Me.lbl_7.Size = New System.Drawing.Size(13, 17)
        Me.lbl_7.TabIndex = 0
        Me.lbl_7.Text = "*"
        Me.lbl_7.Visible = False
        '
        'tbx_Contacto
        '
        Me.tbx_Contacto.Control_Siguiente = Me.dtp_FechaCita
        Me.tbx_Contacto.Filtrado = True
        Me.tbx_Contacto.Location = New System.Drawing.Point(83, 19)
        Me.tbx_Contacto.MaxLength = 100
        Me.tbx_Contacto.Name = "tbx_Contacto"
        Me.tbx_Contacto.Size = New System.Drawing.Size(286, 20)
        Me.tbx_Contacto.TabIndex = 2
        Me.tbx_Contacto.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_InformacionCliente
        '
        Me.gbx_InformacionCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_InformacionCliente.Controls.Add(Me.tbx_NombreF)
        Me.gbx_InformacionCliente.Controls.Add(Me.lbl_ClienteFiscal)
        Me.gbx_InformacionCliente.Controls.Add(Me.lbl_3)
        Me.gbx_InformacionCliente.Controls.Add(Me.lbl_DireccionCliente)
        Me.gbx_InformacionCliente.Controls.Add(Me.tbx_DireccionCliente)
        Me.gbx_InformacionCliente.Controls.Add(Me.lbl_PersonaRecibio)
        Me.gbx_InformacionCliente.Controls.Add(Me.tbx_PersonaRecibio)
        Me.gbx_InformacionCliente.Location = New System.Drawing.Point(6, 45)
        Me.gbx_InformacionCliente.Name = "gbx_InformacionCliente"
        Me.gbx_InformacionCliente.Size = New System.Drawing.Size(768, 119)
        Me.gbx_InformacionCliente.TabIndex = 8
        Me.gbx_InformacionCliente.TabStop = False
        Me.gbx_InformacionCliente.Text = "Información del Cliente"
        '
        'tbx_NombreF
        '
        Me.tbx_NombreF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreF.Control_Siguiente = Nothing
        Me.tbx_NombreF.Filtrado = True
        Me.tbx_NombreF.Location = New System.Drawing.Point(83, 20)
        Me.tbx_NombreF.MaxLength = 150
        Me.tbx_NombreF.Name = "tbx_NombreF"
        Me.tbx_NombreF.ReadOnly = True
        Me.tbx_NombreF.Size = New System.Drawing.Size(661, 20)
        Me.tbx_NombreF.TabIndex = 2
        Me.tbx_NombreF.TabStop = False
        Me.tbx_NombreF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_DireccionCliente
        '
        Me.tbx_DireccionCliente.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DireccionCliente.Control_Siguiente = Me.tbx_UbicacionSugerida
        Me.tbx_DireccionCliente.Filtrado = True
        Me.tbx_DireccionCliente.Location = New System.Drawing.Point(83, 46)
        Me.tbx_DireccionCliente.MaxLength = 200
        Me.tbx_DireccionCliente.Multiline = True
        Me.tbx_DireccionCliente.Name = "tbx_DireccionCliente"
        Me.tbx_DireccionCliente.ReadOnly = True
        Me.tbx_DireccionCliente.Size = New System.Drawing.Size(661, 35)
        Me.tbx_DireccionCliente.TabIndex = 4
        Me.tbx_DireccionCliente.TabStop = False
        Me.tbx_DireccionCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_UbicacionSugerida
        '
        Me.tbx_UbicacionSugerida.Control_Siguiente = Me.tbx_UbicacionSugeridaD
        Me.tbx_UbicacionSugerida.Filtrado = True
        Me.tbx_UbicacionSugerida.Location = New System.Drawing.Point(83, 19)
        Me.tbx_UbicacionSugerida.MaxLength = 50
        Me.tbx_UbicacionSugerida.Name = "tbx_UbicacionSugerida"
        Me.tbx_UbicacionSugerida.Size = New System.Drawing.Size(286, 20)
        Me.tbx_UbicacionSugerida.TabIndex = 2
        Me.tbx_UbicacionSugerida.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_UbicacionSugeridaD
        '
        Me.tbx_UbicacionSugeridaD.Control_Siguiente = Me.tbx_Piso
        Me.tbx_UbicacionSugeridaD.Filtrado = True
        Me.tbx_UbicacionSugeridaD.Location = New System.Drawing.Point(458, 19)
        Me.tbx_UbicacionSugeridaD.MaxLength = 500
        Me.tbx_UbicacionSugeridaD.Multiline = True
        Me.tbx_UbicacionSugeridaD.Name = "tbx_UbicacionSugeridaD"
        Me.tbx_UbicacionSugeridaD.Size = New System.Drawing.Size(286, 46)
        Me.tbx_UbicacionSugeridaD.TabIndex = 4
        Me.tbx_UbicacionSugeridaD.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Piso
        '
        Me.tbx_Piso.Control_Siguiente = Me.tbx_Ventajas
        Me.tbx_Piso.Filtrado = True
        Me.tbx_Piso.Location = New System.Drawing.Point(83, 45)
        Me.tbx_Piso.MaxLength = 2
        Me.tbx_Piso.Name = "tbx_Piso"
        Me.tbx_Piso.Size = New System.Drawing.Size(29, 20)
        Me.tbx_Piso.TabIndex = 6
        Me.tbx_Piso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Piso.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Ventajas
        '
        Me.tbx_Ventajas.Control_Siguiente = Me.tbx_Desventajas
        Me.tbx_Ventajas.Filtrado = True
        Me.tbx_Ventajas.Location = New System.Drawing.Point(83, 71)
        Me.tbx_Ventajas.MaxLength = 300
        Me.tbx_Ventajas.Multiline = True
        Me.tbx_Ventajas.Name = "tbx_Ventajas"
        Me.tbx_Ventajas.Size = New System.Drawing.Size(286, 40)
        Me.tbx_Ventajas.TabIndex = 9
        Me.tbx_Ventajas.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Desventajas
        '
        Me.tbx_Desventajas.Control_Siguiente = Me.tbx_NotasAdicionales
        Me.tbx_Desventajas.Filtrado = True
        Me.tbx_Desventajas.Location = New System.Drawing.Point(458, 71)
        Me.tbx_Desventajas.MaxLength = 300
        Me.tbx_Desventajas.Multiline = True
        Me.tbx_Desventajas.Name = "tbx_Desventajas"
        Me.tbx_Desventajas.Size = New System.Drawing.Size(286, 40)
        Me.tbx_Desventajas.TabIndex = 11
        Me.tbx_Desventajas.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NotasAdicionales
        '
        Me.tbx_NotasAdicionales.Control_Siguiente = Me.tbx_ClavePersonaInspeccion
        Me.tbx_NotasAdicionales.Filtrado = True
        Me.tbx_NotasAdicionales.Location = New System.Drawing.Point(89, 294)
        Me.tbx_NotasAdicionales.MaxLength = 300
        Me.tbx_NotasAdicionales.Multiline = True
        Me.tbx_NotasAdicionales.Name = "tbx_NotasAdicionales"
        Me.tbx_NotasAdicionales.Size = New System.Drawing.Size(685, 30)
        Me.tbx_NotasAdicionales.TabIndex = 11
        Me.tbx_NotasAdicionales.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_ClavePersonaInspeccion
        '
        Me.tbx_ClavePersonaInspeccion.Control_Siguiente = Me.cmb_PersonaInspeccion
        Me.tbx_ClavePersonaInspeccion.Filtrado = True
        Me.tbx_ClavePersonaInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ClavePersonaInspeccion.Location = New System.Drawing.Point(105, 19)
        Me.tbx_ClavePersonaInspeccion.MaxLength = 5
        Me.tbx_ClavePersonaInspeccion.Name = "tbx_ClavePersonaInspeccion"
        Me.tbx_ClavePersonaInspeccion.Size = New System.Drawing.Size(52, 20)
        Me.tbx_ClavePersonaInspeccion.TabIndex = 2
        Me.tbx_ClavePersonaInspeccion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_PersonaInspeccion
        '
        Me.cmb_PersonaInspeccion.Clave = "Clave_Empleado"
        Me.cmb_PersonaInspeccion.Control_Siguiente = Me.cmb_Departamento
        Me.cmb_PersonaInspeccion.DisplayMember = "Nombre"
        Me.cmb_PersonaInspeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PersonaInspeccion.Empresa = False
        Me.cmb_PersonaInspeccion.Filtro = Me.tbx_ClavePersonaInspeccion
        Me.cmb_PersonaInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PersonaInspeccion.FormattingEnabled = True
        Me.cmb_PersonaInspeccion.Location = New System.Drawing.Point(163, 19)
        Me.cmb_PersonaInspeccion.MaxDropDownItems = 20
        Me.cmb_PersonaInspeccion.Name = "cmb_PersonaInspeccion"
        Me.cmb_PersonaInspeccion.Pista = False
        Me.cmb_PersonaInspeccion.Size = New System.Drawing.Size(324, 21)
        Me.cmb_PersonaInspeccion.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_PersonaInspeccion.Sucursal = True
        Me.cmb_PersonaInspeccion.TabIndex = 3
        Me.cmb_PersonaInspeccion.Tipo = 0
        Me.cmb_PersonaInspeccion.ValueMember = "Id_Empleado"
        '
        'cmb_Departamento
        '
        Me.cmb_Departamento.Clave = Nothing
        Me.cmb_Departamento.Control_Siguiente = Me.cmb_Puesto
        Me.cmb_Departamento.DisplayMember = "Descripcion"
        Me.cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento.Empresa = False
        Me.cmb_Departamento.Enabled = False
        Me.cmb_Departamento.Filtro = Nothing
        Me.cmb_Departamento.FormattingEnabled = True
        Me.cmb_Departamento.Location = New System.Drawing.Point(105, 46)
        Me.cmb_Departamento.MaxDropDownItems = 20
        Me.cmb_Departamento.Name = "cmb_Departamento"
        Me.cmb_Departamento.Pista = False
        Me.cmb_Departamento.Size = New System.Drawing.Size(382, 21)
        Me.cmb_Departamento.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento.Sucursal = False
        Me.cmb_Departamento.TabIndex = 5
        Me.cmb_Departamento.Tipo = 0
        Me.cmb_Departamento.ValueMember = "Id_Departamento"
        '
        'cmb_Puesto
        '
        Me.cmb_Puesto.Clave = Nothing
        Me.cmb_Puesto.Control_Siguiente = Me.tbx_ClaveJefeSeguridad
        Me.cmb_Puesto.DisplayMember = "Descripcion"
        Me.cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puesto.Empresa = False
        Me.cmb_Puesto.Enabled = False
        Me.cmb_Puesto.Filtro = Nothing
        Me.cmb_Puesto.FormattingEnabled = True
        Me.cmb_Puesto.Location = New System.Drawing.Point(105, 73)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(382, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 7
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'tbx_ClaveJefeSeguridad
        '
        Me.tbx_ClaveJefeSeguridad.Control_Siguiente = Me.cmb_JefeSeguridad
        Me.tbx_ClaveJefeSeguridad.Filtrado = True
        Me.tbx_ClaveJefeSeguridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ClaveJefeSeguridad.Location = New System.Drawing.Point(105, 100)
        Me.tbx_ClaveJefeSeguridad.MaxLength = 5
        Me.tbx_ClaveJefeSeguridad.Name = "tbx_ClaveJefeSeguridad"
        Me.tbx_ClaveJefeSeguridad.Size = New System.Drawing.Size(52, 20)
        Me.tbx_ClaveJefeSeguridad.TabIndex = 9
        Me.tbx_ClaveJefeSeguridad.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_JefeSeguridad
        '
        Me.cmb_JefeSeguridad.Clave = "Clave_Empleado"
        Me.cmb_JefeSeguridad.Control_Siguiente = Me.chk_ProgramacionCita
        Me.cmb_JefeSeguridad.DisplayMember = "Nombre"
        Me.cmb_JefeSeguridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JefeSeguridad.Empresa = False
        Me.cmb_JefeSeguridad.Filtro = Me.tbx_ClaveJefeSeguridad
        Me.cmb_JefeSeguridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_JefeSeguridad.FormattingEnabled = True
        Me.cmb_JefeSeguridad.Location = New System.Drawing.Point(163, 100)
        Me.cmb_JefeSeguridad.MaxDropDownItems = 20
        Me.cmb_JefeSeguridad.Name = "cmb_JefeSeguridad"
        Me.cmb_JefeSeguridad.Pista = False
        Me.cmb_JefeSeguridad.Size = New System.Drawing.Size(324, 21)
        Me.cmb_JefeSeguridad.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_JefeSeguridad.Sucursal = True
        Me.cmb_JefeSeguridad.TabIndex = 10
        Me.cmb_JefeSeguridad.Tipo = 0
        Me.cmb_JefeSeguridad.ValueMember = "Id_Empleado"
        '
        'tbx_PersonaRecibio
        '
        Me.tbx_PersonaRecibio.Control_Siguiente = Me.tbx_UbicacionSugerida
        Me.tbx_PersonaRecibio.Filtrado = True
        Me.tbx_PersonaRecibio.Location = New System.Drawing.Point(83, 87)
        Me.tbx_PersonaRecibio.MaxLength = 100
        Me.tbx_PersonaRecibio.Name = "tbx_PersonaRecibio"
        Me.tbx_PersonaRecibio.Size = New System.Drawing.Size(369, 20)
        Me.tbx_PersonaRecibio.TabIndex = 6
        Me.tbx_PersonaRecibio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_InformacionEmpleado
        '
        Me.gbx_InformacionEmpleado.Controls.Add(Me.cmb_Departamento)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.cmb_Puesto)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.tbx_ClaveJefeSeguridad)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.cmb_JefeSeguridad)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.Lbl_JefeSeg)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.tbx_ClavePersonaInspeccion)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.cmb_PersonaInspeccion)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.lbl_PersonaInspeccion)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.lbl_Departamento)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.lbl_Puesto)
        Me.gbx_InformacionEmpleado.Controls.Add(Me.lbl_6)
        Me.gbx_InformacionEmpleado.Location = New System.Drawing.Point(6, 330)
        Me.gbx_InformacionEmpleado.Name = "gbx_InformacionEmpleado"
        Me.gbx_InformacionEmpleado.Size = New System.Drawing.Size(496, 128)
        Me.gbx_InformacionEmpleado.TabIndex = 12
        Me.gbx_InformacionEmpleado.TabStop = False
        Me.gbx_InformacionEmpleado.Text = "Información de la Persona que Asistió a la Inspección"
        '
        'Lbl_JefeSeg
        '
        Me.Lbl_JefeSeg.AutoSize = True
        Me.Lbl_JefeSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_JefeSeg.Location = New System.Drawing.Point(6, 103)
        Me.Lbl_JefeSeg.Name = "Lbl_JefeSeg"
        Me.Lbl_JefeSeg.Size = New System.Drawing.Size(93, 13)
        Me.Lbl_JefeSeg.TabIndex = 8
        Me.Lbl_JefeSeg.Text = "Jefe de Seguridad"
        Me.Lbl_JefeSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_PersonaInspeccion
        '
        Me.lbl_PersonaInspeccion.AutoSize = True
        Me.lbl_PersonaInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PersonaInspeccion.Location = New System.Drawing.Point(45, 22)
        Me.lbl_PersonaInspeccion.Name = "lbl_PersonaInspeccion"
        Me.lbl_PersonaInspeccion.Size = New System.Drawing.Size(54, 13)
        Me.lbl_PersonaInspeccion.TabIndex = 1
        Me.lbl_PersonaInspeccion.Text = "Empleado"
        Me.lbl_PersonaInspeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Departamento.Location = New System.Drawing.Point(25, 49)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 4
        Me.lbl_Departamento.Text = "Departamento"
        Me.lbl_Departamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Puesto.Location = New System.Drawing.Point(59, 76)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 6
        Me.lbl_Puesto.Text = "Puesto"
        Me.lbl_Puesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_6
        '
        Me.lbl_6.AutoSize = True
        Me.lbl_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_6.ForeColor = System.Drawing.Color.Red
        Me.lbl_6.Location = New System.Drawing.Point(265, -3)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(13, 17)
        Me.lbl_6.TabIndex = 0
        Me.lbl_6.Text = "*"
        '
        'gbx_UbicacionSugerida
        '
        Me.gbx_UbicacionSugerida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_Ejemplo)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_UbicacionSugerida)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.tbx_Piso)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_Piso)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.tbx_UbicacionSugerida)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_UbicacionSugeridaD)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.tbx_UbicacionSugeridaD)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_4)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_Ventajas)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.tbx_Ventajas)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.lbl_Desventajas)
        Me.gbx_UbicacionSugerida.Controls.Add(Me.tbx_Desventajas)
        Me.gbx_UbicacionSugerida.Location = New System.Drawing.Point(6, 170)
        Me.gbx_UbicacionSugerida.Name = "gbx_UbicacionSugerida"
        Me.gbx_UbicacionSugerida.Size = New System.Drawing.Size(768, 118)
        Me.gbx_UbicacionSugerida.TabIndex = 9
        Me.gbx_UbicacionSugerida.TabStop = False
        Me.gbx_UbicacionSugerida.Text = "Información de la Ubicación Sugerida"
        '
        'lbl_Ejemplo
        '
        Me.lbl_Ejemplo.AutoSize = True
        Me.lbl_Ejemplo.Location = New System.Drawing.Point(118, 48)
        Me.lbl_Ejemplo.Name = "lbl_Ejemplo"
        Me.lbl_Ejemplo.Size = New System.Drawing.Size(99, 13)
        Me.lbl_Ejemplo.TabIndex = 7
        Me.lbl_Ejemplo.Text = "(ZN, PB, 1, 2, 3, ...)"
        Me.lbl_Ejemplo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Piso
        '
        Me.lbl_Piso.AutoSize = True
        Me.lbl_Piso.Location = New System.Drawing.Point(50, 48)
        Me.lbl_Piso.Name = "lbl_Piso"
        Me.lbl_Piso.Size = New System.Drawing.Size(27, 13)
        Me.lbl_Piso.TabIndex = 5
        Me.lbl_Piso.Text = "Piso"
        Me.lbl_Piso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Ventajas
        '
        Me.lbl_Ventajas.AutoSize = True
        Me.lbl_Ventajas.Location = New System.Drawing.Point(29, 74)
        Me.lbl_Ventajas.Name = "lbl_Ventajas"
        Me.lbl_Ventajas.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Ventajas.TabIndex = 8
        Me.lbl_Ventajas.Text = "Ventajas"
        '
        'lbl_Desventajas
        '
        Me.lbl_Desventajas.AutoSize = True
        Me.lbl_Desventajas.Location = New System.Drawing.Point(386, 74)
        Me.lbl_Desventajas.Name = "lbl_Desventajas"
        Me.lbl_Desventajas.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Desventajas.TabIndex = 10
        Me.lbl_Desventajas.Text = "Desventajas"
        '
        'lbl_NotasAdicionales
        '
        Me.lbl_NotasAdicionales.Location = New System.Drawing.Point(20, 297)
        Me.lbl_NotasAdicionales.Name = "lbl_NotasAdicionales"
        Me.lbl_NotasAdicionales.Size = New System.Drawing.Size(63, 27)
        Me.lbl_NotasAdicionales.TabIndex = 10
        Me.lbl_NotasAdicionales.Text = "Notas Adicionales"
        Me.lbl_NotasAdicionales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtp_HoraVisita
        '
        Me.dtp_HoraVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraVisita.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_HoraVisita.Location = New System.Drawing.Point(292, 20)
        Me.dtp_HoraVisita.Name = "dtp_HoraVisita"
        Me.dtp_HoraVisita.ShowUpDown = True
        Me.dtp_HoraVisita.Size = New System.Drawing.Size(89, 20)
        Me.dtp_HoraVisita.TabIndex = 4
        '
        'lbl_HoraVisita
        '
        Me.lbl_HoraVisita.AutoSize = True
        Me.lbl_HoraVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraVisita.Location = New System.Drawing.Point(213, 24)
        Me.lbl_HoraVisita.Name = "lbl_HoraVisita"
        Me.lbl_HoraVisita.Size = New System.Drawing.Size(73, 13)
        Me.lbl_HoraVisita.TabIndex = 3
        Me.lbl_HoraVisita.Text = "Hora de Visita"
        '
        'frm_ActaInspeccionDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 611)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ActaInspeccionDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acta de Inspección para Instalación de Caja Fuerte"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_Imagenes.ResumeLayout(False)
        Me.gbx_InformacionCita.ResumeLayout(False)
        Me.gbx_InformacionCita.PerformLayout()
        Me.gbx_InformacionCliente.ResumeLayout(False)
        Me.gbx_InformacionCliente.PerformLayout()
        Me.gbx_InformacionEmpleado.ResumeLayout(False)
        Me.gbx_InformacionEmpleado.PerformLayout()
        Me.gbx_UbicacionSugerida.ResumeLayout(False)
        Me.gbx_UbicacionSugerida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_ClienteFiscal As System.Windows.Forms.Label
    Friend WithEvents lbl_DireccionCliente As System.Windows.Forms.Label
    Friend WithEvents tbx_PersonaRecibio As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_PersonaRecibio As System.Windows.Forms.Label
    Friend WithEvents lbl_UbicacionSugeridaD As System.Windows.Forms.Label
    Friend WithEvents tbx_UbicacionSugerida As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_UbicacionSugerida As System.Windows.Forms.Label
    Friend WithEvents tbx_UbicacionSugeridaD As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_FechaVisita As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaVisita As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_4 As System.Windows.Forms.Label
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_HoraVisita As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraVisita As System.Windows.Forms.Label
    Friend WithEvents tbx_DireccionCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Desventajas As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Desventajas As System.Windows.Forms.Label
    Friend WithEvents tbx_Ventajas As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Ventajas As System.Windows.Forms.Label
    Friend WithEvents lbl_6 As System.Windows.Forms.Label
    Friend WithEvents tbx_NotasAdicionales As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NotasAdicionales As System.Windows.Forms.Label
    Friend WithEvents lbl_PersonaInspeccion As System.Windows.Forms.Label
    Friend WithEvents cmb_PersonaInspeccion As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClavePersonaInspeccion As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents gbx_UbicacionSugerida As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_InformacionEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_InformacionCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_InformacionCita As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents tbx_Contacto As Modulo_Ventas.cp_Textbox
    Friend WithEvents dtp_FechaCita As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaCita As System.Windows.Forms.Label
    Friend WithEvents tbx_HorasCita As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_HorasCita As System.Windows.Forms.Label
    Friend WithEvents tbx_ClaveJefeSeguridad As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_JefeSeguridad As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_JefeSeg As System.Windows.Forms.Label
    Friend WithEvents cmb_Puesto As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Departamento As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_NombreF As Modulo_Ventas.cp_Textbox
    Friend WithEvents chk_ProgramacionCita As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Piso As System.Windows.Forms.Label
    Friend WithEvents lbl_Ejemplo As System.Windows.Forms.Label
    Friend WithEvents tbx_Piso As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_DActa As System.Windows.Forms.Label
    Friend WithEvents lbl_Acta As System.Windows.Forms.Label
    Friend WithEvents gbx_Imagenes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Imagenes As Modulo_Ventas.cp_Listview
End Class
