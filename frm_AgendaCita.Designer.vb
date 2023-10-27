<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgendaCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AgendaCita))
        Me.lbl_Asunto = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.lbl_Minutos = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaTarea = New System.Windows.Forms.Label
        Me.lbl_Duracion = New System.Windows.Forms.Label
        Me.tbx_Descripcion = New System.Windows.Forms.RichTextBox
        Me.tbx_Duracion = New Modulo_Ventas.cp_Textbox
        Me.cmb_HoraInicio = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_HoraFin = New Modulo_Ventas.cp_cmb_Manual
        Me.tbx_Asunto = New Modulo_Ventas.cp_Textbox
        Me.lbl_HoraInicio = New System.Windows.Forms.Label
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.lbl_HoraFin = New System.Windows.Forms.Label
        Me.gbx_Recurrente = New System.Windows.Forms.GroupBox
        Me.rdb_Semestre = New System.Windows.Forms.RadioButton
        Me.rdb_Diario = New System.Windows.Forms.RadioButton
        Me.rdb_Ninguno = New System.Windows.Forms.RadioButton
        Me.rdb_Mes = New System.Windows.Forms.RadioButton
        Me.rdb_Semana = New System.Windows.Forms.RadioButton
        Me.gbx_Mes = New System.Windows.Forms.GroupBox
        Me.Lbl_CadaMes = New System.Windows.Forms.Label
        Me.dtp_HastaMes = New System.Windows.Forms.DateTimePicker
        Me.lbl_HastaMes = New System.Windows.Forms.Label
        Me.cmb_DiaMes = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_HoraFinNueva = New Modulo_Ventas.cp_cmb_Manual
        Me.Lbl_RepTod = New System.Windows.Forms.Label
        Me.gbx_Semana = New System.Windows.Forms.GroupBox
        Me.Lbl_CadaSem = New System.Windows.Forms.Label
        Me.dtp_HastaDia = New System.Windows.Forms.DateTimePicker
        Me.lbl_HastaSemana = New System.Windows.Forms.Label
        Me.cmb_DiaSemana = New Modulo_Ventas.cp_cmb_Manual
        Me.Lbl_RepTodos = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Actualizar = New System.Windows.Forms.GroupBox
        Me.lbl_MinutosNueva = New System.Windows.Forms.Label
        Me.lbl_DuracionNueva = New System.Windows.Forms.Label
        Me.tbx_DuracionNueva = New Modulo_Ventas.cp_Textbox
        Me.cmb_HoraInicioNueva = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_HoraInicioNueva = New System.Windows.Forms.Label
        Me.lbl_HoraFinNueva = New System.Windows.Forms.Label
        Me.dtp_FechaProxima = New System.Windows.Forms.DateTimePicker
        Me.tbx_Comentarios = New Modulo_Ventas.cp_Textbox
        Me.lbl_Comentario = New System.Windows.Forms.Label
        Me.lbl_FechaProxima = New System.Windows.Forms.Label
        Me.gbx_Accion = New System.Windows.Forms.GroupBox
        Me.rdb_Editar = New System.Windows.Forms.RadioButton
        Me.rdb_Cancelar = New System.Windows.Forms.RadioButton
        Me.rdb_Posponer = New System.Windows.Forms.RadioButton
        Me.rdb_Finalizar = New System.Windows.Forms.RadioButton
        Me.gbx_Diario = New System.Windows.Forms.GroupBox
        Me.lbl_DiarioInicio = New System.Windows.Forms.Label
        Me.dtp_HastaDiario = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_RepTodDiasDesde = New System.Windows.Forms.Label
        Me.gbx_Semestre = New System.Windows.Forms.GroupBox
        Me.Lbl_Cada6Mes = New System.Windows.Forms.Label
        Me.dtp_HastaSemestre = New System.Windows.Forms.DateTimePicker
        Me.lbl_HastaSemestre = New System.Windows.Forms.Label
        Me.cmb_DiaSemestre = New Modulo_Ventas.cp_cmb_Manual
        Me.Lbl_RepeTodos = New System.Windows.Forms.Label
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Recurrente.SuspendLayout()
        Me.gbx_Mes.SuspendLayout()
        Me.gbx_Semana.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Actualizar.SuspendLayout()
        Me.gbx_Accion.SuspendLayout()
        Me.gbx_Diario.SuspendLayout()
        Me.gbx_Semestre.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Asunto
        '
        Me.lbl_Asunto.AutoSize = True
        Me.lbl_Asunto.Location = New System.Drawing.Point(53, 65)
        Me.lbl_Asunto.Name = "lbl_Asunto"
        Me.lbl_Asunto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Asunto.TabIndex = 8
        Me.lbl_Asunto.Text = "Asunto"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.lbl_Minutos)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_FechaTarea)
        Me.gbx_Datos.Controls.Add(Me.lbl_Duracion)
        Me.gbx_Datos.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Datos.Controls.Add(Me.tbx_Duracion)
        Me.gbx_Datos.Controls.Add(Me.cmb_HoraInicio)
        Me.gbx_Datos.Controls.Add(Me.lbl_HoraInicio)
        Me.gbx_Datos.Controls.Add(Me.lbl_Descripcion)
        Me.gbx_Datos.Controls.Add(Me.lbl_Asunto)
        Me.gbx_Datos.Controls.Add(Me.cmb_HoraFin)
        Me.gbx_Datos.Controls.Add(Me.tbx_Asunto)
        Me.gbx_Datos.Controls.Add(Me.lbl_HoraFin)
        Me.gbx_Datos.Location = New System.Drawing.Point(12, 6)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(666, 213)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'lbl_Minutos
        '
        Me.lbl_Minutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Minutos.AutoSize = True
        Me.lbl_Minutos.Location = New System.Drawing.Point(488, 37)
        Me.lbl_Minutos.Name = "lbl_Minutos"
        Me.lbl_Minutos.Size = New System.Drawing.Size(24, 13)
        Me.lbl_Minutos.TabIndex = 8
        Me.lbl_Minutos.Text = "Min"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_Fecha.Enabled = False
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(99, 35)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 4
        Me.dtp_Fecha.Value = New Date(2011, 7, 1, 0, 0, 0, 0)
        '
        'lbl_FechaTarea
        '
        Me.lbl_FechaTarea.AutoSize = True
        Me.lbl_FechaTarea.Location = New System.Drawing.Point(129, 16)
        Me.lbl_FechaTarea.Name = "lbl_FechaTarea"
        Me.lbl_FechaTarea.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaTarea.TabIndex = 0
        Me.lbl_FechaTarea.Text = "Fecha"
        '
        'lbl_Duracion
        '
        Me.lbl_Duracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Duracion.AutoSize = True
        Me.lbl_Duracion.Location = New System.Drawing.Point(439, 16)
        Me.lbl_Duracion.Name = "lbl_Duracion"
        Me.lbl_Duracion.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Duracion.TabIndex = 3
        Me.lbl_Duracion.Text = "Duración"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Location = New System.Drawing.Point(99, 88)
        Me.tbx_Descripcion.MaxLength = 2000
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(553, 115)
        Me.tbx_Descripcion.TabIndex = 11
        Me.tbx_Descripcion.Text = ""
        '
        'tbx_Duracion
        '
        Me.tbx_Duracion.Control_Siguiente = Nothing
        Me.tbx_Duracion.Enabled = False
        Me.tbx_Duracion.Filtrado = False
        Me.tbx_Duracion.Location = New System.Drawing.Point(442, 34)
        Me.tbx_Duracion.MaxLength = 4
        Me.tbx_Duracion.Name = "tbx_Duracion"
        Me.tbx_Duracion.ReadOnly = True
        Me.tbx_Duracion.Size = New System.Drawing.Size(40, 20)
        Me.tbx_Duracion.TabIndex = 7
        Me.tbx_Duracion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_HoraInicio
        '
        Me.cmb_HoraInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_HoraInicio.Control_Siguiente = Me.cmb_HoraFin
        Me.cmb_HoraInicio.DisplayMember = "display"
        Me.cmb_HoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HoraInicio.FormattingEnabled = True
        Me.cmb_HoraInicio.Location = New System.Drawing.Point(208, 34)
        Me.cmb_HoraInicio.MaxDropDownItems = 20
        Me.cmb_HoraInicio.Name = "cmb_HoraInicio"
        Me.cmb_HoraInicio.Size = New System.Drawing.Size(111, 21)
        Me.cmb_HoraInicio.TabIndex = 5
        Me.cmb_HoraInicio.ValueMember = "value"
        '
        'cmb_HoraFin
        '
        Me.cmb_HoraFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_HoraFin.Control_Siguiente = Me.tbx_Asunto
        Me.cmb_HoraFin.DisplayMember = "display"
        Me.cmb_HoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HoraFin.FormattingEnabled = True
        Me.cmb_HoraFin.Location = New System.Drawing.Point(325, 34)
        Me.cmb_HoraFin.MaxDropDownItems = 20
        Me.cmb_HoraFin.Name = "cmb_HoraFin"
        Me.cmb_HoraFin.Size = New System.Drawing.Size(111, 21)
        Me.cmb_HoraFin.TabIndex = 6
        Me.cmb_HoraFin.ValueMember = "value"
        '
        'tbx_Asunto
        '
        Me.tbx_Asunto.Control_Siguiente = Me.tbx_Descripcion
        Me.tbx_Asunto.Filtrado = True
        Me.tbx_Asunto.Location = New System.Drawing.Point(99, 62)
        Me.tbx_Asunto.MaxLength = 50
        Me.tbx_Asunto.Name = "tbx_Asunto"
        Me.tbx_Asunto.Size = New System.Drawing.Size(415, 20)
        Me.tbx_Asunto.TabIndex = 9
        Me.tbx_Asunto.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_HoraInicio
        '
        Me.lbl_HoraInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_HoraInicio.AutoSize = True
        Me.lbl_HoraInicio.Location = New System.Drawing.Point(235, 16)
        Me.lbl_HoraInicio.Name = "lbl_HoraInicio"
        Me.lbl_HoraInicio.Size = New System.Drawing.Size(58, 13)
        Me.lbl_HoraInicio.TabIndex = 1
        Me.lbl_HoraInicio.Text = "Hora Inicio"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(30, 91)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 10
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'lbl_HoraFin
        '
        Me.lbl_HoraFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_HoraFin.AutoSize = True
        Me.lbl_HoraFin.Location = New System.Drawing.Point(355, 16)
        Me.lbl_HoraFin.Name = "lbl_HoraFin"
        Me.lbl_HoraFin.Size = New System.Drawing.Size(47, 13)
        Me.lbl_HoraFin.TabIndex = 2
        Me.lbl_HoraFin.Text = "Hora Fin"
        '
        'gbx_Recurrente
        '
        Me.gbx_Recurrente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Recurrente.Controls.Add(Me.rdb_Semestre)
        Me.gbx_Recurrente.Controls.Add(Me.rdb_Diario)
        Me.gbx_Recurrente.Controls.Add(Me.rdb_Ninguno)
        Me.gbx_Recurrente.Controls.Add(Me.rdb_Mes)
        Me.gbx_Recurrente.Controls.Add(Me.rdb_Semana)
        Me.gbx_Recurrente.Location = New System.Drawing.Point(12, 222)
        Me.gbx_Recurrente.Name = "gbx_Recurrente"
        Me.gbx_Recurrente.Size = New System.Drawing.Size(125, 186)
        Me.gbx_Recurrente.TabIndex = 1
        Me.gbx_Recurrente.TabStop = False
        Me.gbx_Recurrente.Text = "Recurrencia"
        '
        'rdb_Semestre
        '
        Me.rdb_Semestre.Location = New System.Drawing.Point(14, 154)
        Me.rdb_Semestre.Name = "rdb_Semestre"
        Me.rdb_Semestre.Size = New System.Drawing.Size(96, 25)
        Me.rdb_Semestre.TabIndex = 4
        Me.rdb_Semestre.Text = "Semestral"
        Me.rdb_Semestre.UseVisualStyleBackColor = True
        '
        'rdb_Diario
        '
        Me.rdb_Diario.AutoSize = True
        Me.rdb_Diario.Location = New System.Drawing.Point(14, 51)
        Me.rdb_Diario.Name = "rdb_Diario"
        Me.rdb_Diario.Size = New System.Drawing.Size(52, 17)
        Me.rdb_Diario.TabIndex = 1
        Me.rdb_Diario.Text = "Diaria"
        Me.rdb_Diario.UseVisualStyleBackColor = True
        '
        'rdb_Ninguno
        '
        Me.rdb_Ninguno.AutoSize = True
        Me.rdb_Ninguno.Checked = True
        Me.rdb_Ninguno.Location = New System.Drawing.Point(14, 18)
        Me.rdb_Ninguno.Name = "rdb_Ninguno"
        Me.rdb_Ninguno.Size = New System.Drawing.Size(65, 17)
        Me.rdb_Ninguno.TabIndex = 0
        Me.rdb_Ninguno.TabStop = True
        Me.rdb_Ninguno.Text = "Ninguna"
        Me.rdb_Ninguno.UseVisualStyleBackColor = True
        '
        'rdb_Mes
        '
        Me.rdb_Mes.Location = New System.Drawing.Point(14, 116)
        Me.rdb_Mes.Name = "rdb_Mes"
        Me.rdb_Mes.Size = New System.Drawing.Size(105, 31)
        Me.rdb_Mes.TabIndex = 3
        Me.rdb_Mes.Text = "Por Día del Mes"
        Me.rdb_Mes.UseVisualStyleBackColor = True
        '
        'rdb_Semana
        '
        Me.rdb_Semana.Location = New System.Drawing.Point(14, 80)
        Me.rdb_Semana.Name = "rdb_Semana"
        Me.rdb_Semana.Size = New System.Drawing.Size(96, 30)
        Me.rdb_Semana.TabIndex = 2
        Me.rdb_Semana.Text = "Por Día de la Semana"
        Me.rdb_Semana.UseVisualStyleBackColor = True
        '
        'gbx_Mes
        '
        Me.gbx_Mes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Mes.Controls.Add(Me.Lbl_CadaMes)
        Me.gbx_Mes.Controls.Add(Me.dtp_HastaMes)
        Me.gbx_Mes.Controls.Add(Me.lbl_HastaMes)
        Me.gbx_Mes.Controls.Add(Me.cmb_DiaMes)
        Me.gbx_Mes.Controls.Add(Me.Lbl_RepTod)
        Me.gbx_Mes.Enabled = False
        Me.gbx_Mes.Location = New System.Drawing.Point(143, 316)
        Me.gbx_Mes.Name = "gbx_Mes"
        Me.gbx_Mes.Size = New System.Drawing.Size(535, 43)
        Me.gbx_Mes.TabIndex = 5
        Me.gbx_Mes.TabStop = False
        Me.gbx_Mes.Text = "Por día del Mes"
        '
        'Lbl_CadaMes
        '
        Me.Lbl_CadaMes.AutoSize = True
        Me.Lbl_CadaMes.Location = New System.Drawing.Point(247, 19)
        Me.Lbl_CadaMes.Name = "Lbl_CadaMes"
        Me.Lbl_CadaMes.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_CadaMes.TabIndex = 2
        Me.Lbl_CadaMes.Text = "de cada Mes."
        '
        'dtp_HastaMes
        '
        Me.dtp_HastaMes.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_HastaMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_HastaMes.Location = New System.Drawing.Point(396, 15)
        Me.dtp_HastaMes.Name = "dtp_HastaMes"
        Me.dtp_HastaMes.Size = New System.Drawing.Size(95, 20)
        Me.dtp_HastaMes.TabIndex = 4
        Me.dtp_HastaMes.Value = New Date(2011, 7, 1, 0, 0, 0, 0)
        '
        'lbl_HastaMes
        '
        Me.lbl_HastaMes.AutoSize = True
        Me.lbl_HastaMes.Location = New System.Drawing.Point(352, 19)
        Me.lbl_HastaMes.Name = "lbl_HastaMes"
        Me.lbl_HastaMes.Size = New System.Drawing.Size(35, 13)
        Me.lbl_HastaMes.TabIndex = 3
        Me.lbl_HastaMes.Text = "Hasta"
        '
        'cmb_DiaMes
        '
        Me.cmb_DiaMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_DiaMes.Control_Siguiente = Me.cmb_HoraFinNueva
        Me.cmb_DiaMes.DisplayMember = "display"
        Me.cmb_DiaMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DiaMes.Enabled = False
        Me.cmb_DiaMes.FormattingEnabled = True
        Me.cmb_DiaMes.Location = New System.Drawing.Point(142, 16)
        Me.cmb_DiaMes.MaxDropDownItems = 32
        Me.cmb_DiaMes.Name = "cmb_DiaMes"
        Me.cmb_DiaMes.Size = New System.Drawing.Size(99, 21)
        Me.cmb_DiaMes.TabIndex = 1
        Me.cmb_DiaMes.ValueMember = "value"
        '
        'cmb_HoraFinNueva
        '
        Me.cmb_HoraFinNueva.Control_Siguiente = Me.tbx_Asunto
        Me.cmb_HoraFinNueva.DisplayMember = "display"
        Me.cmb_HoraFinNueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HoraFinNueva.FormattingEnabled = True
        Me.cmb_HoraFinNueva.Location = New System.Drawing.Point(264, 46)
        Me.cmb_HoraFinNueva.MaxDropDownItems = 20
        Me.cmb_HoraFinNueva.Name = "cmb_HoraFinNueva"
        Me.cmb_HoraFinNueva.Size = New System.Drawing.Size(111, 21)
        Me.cmb_HoraFinNueva.TabIndex = 6
        Me.cmb_HoraFinNueva.ValueMember = "value"
        '
        'Lbl_RepTod
        '
        Me.Lbl_RepTod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RepTod.AutoSize = True
        Me.Lbl_RepTod.Location = New System.Drawing.Point(50, 19)
        Me.Lbl_RepTod.Name = "Lbl_RepTod"
        Me.Lbl_RepTod.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_RepTod.TabIndex = 0
        Me.Lbl_RepTod.Text = "Repetir todos los"
        '
        'gbx_Semana
        '
        Me.gbx_Semana.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Semana.Controls.Add(Me.Lbl_CadaSem)
        Me.gbx_Semana.Controls.Add(Me.dtp_HastaDia)
        Me.gbx_Semana.Controls.Add(Me.lbl_HastaSemana)
        Me.gbx_Semana.Controls.Add(Me.cmb_DiaSemana)
        Me.gbx_Semana.Controls.Add(Me.Lbl_RepTodos)
        Me.gbx_Semana.Enabled = False
        Me.gbx_Semana.Location = New System.Drawing.Point(143, 269)
        Me.gbx_Semana.Name = "gbx_Semana"
        Me.gbx_Semana.Size = New System.Drawing.Size(535, 43)
        Me.gbx_Semana.TabIndex = 4
        Me.gbx_Semana.TabStop = False
        Me.gbx_Semana.Text = "Por día de la Semana"
        '
        'Lbl_CadaSem
        '
        Me.Lbl_CadaSem.AutoSize = True
        Me.Lbl_CadaSem.Location = New System.Drawing.Point(247, 19)
        Me.Lbl_CadaSem.Name = "Lbl_CadaSem"
        Me.Lbl_CadaSem.Size = New System.Drawing.Size(91, 13)
        Me.Lbl_CadaSem.TabIndex = 2
        Me.Lbl_CadaSem.Text = "de cada Semana."
        '
        'dtp_HastaDia
        '
        Me.dtp_HastaDia.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_HastaDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_HastaDia.Location = New System.Drawing.Point(396, 15)
        Me.dtp_HastaDia.Name = "dtp_HastaDia"
        Me.dtp_HastaDia.Size = New System.Drawing.Size(95, 20)
        Me.dtp_HastaDia.TabIndex = 4
        Me.dtp_HastaDia.Value = New Date(2011, 7, 1, 0, 0, 0, 0)
        '
        'lbl_HastaSemana
        '
        Me.lbl_HastaSemana.AutoSize = True
        Me.lbl_HastaSemana.Location = New System.Drawing.Point(352, 19)
        Me.lbl_HastaSemana.Name = "lbl_HastaSemana"
        Me.lbl_HastaSemana.Size = New System.Drawing.Size(35, 13)
        Me.lbl_HastaSemana.TabIndex = 3
        Me.lbl_HastaSemana.Text = "Hasta"
        '
        'cmb_DiaSemana
        '
        Me.cmb_DiaSemana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_DiaSemana.Control_Siguiente = Me.cmb_HoraFinNueva
        Me.cmb_DiaSemana.DisplayMember = "display"
        Me.cmb_DiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DiaSemana.Enabled = False
        Me.cmb_DiaSemana.FormattingEnabled = True
        Me.cmb_DiaSemana.Location = New System.Drawing.Point(142, 16)
        Me.cmb_DiaSemana.MaxDropDownItems = 10
        Me.cmb_DiaSemana.Name = "cmb_DiaSemana"
        Me.cmb_DiaSemana.Size = New System.Drawing.Size(99, 21)
        Me.cmb_DiaSemana.TabIndex = 1
        Me.cmb_DiaSemana.ValueMember = "value"
        '
        'Lbl_RepTodos
        '
        Me.Lbl_RepTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RepTodos.AutoSize = True
        Me.Lbl_RepTodos.Location = New System.Drawing.Point(50, 19)
        Me.Lbl_RepTodos.Name = "Lbl_RepTodos"
        Me.Lbl_RepTodos.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_RepTodos.TabIndex = 0
        Me.Lbl_RepTodos.Text = "Repetir todos los"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 572)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(666, 50)
        Me.gbx_Botones.TabIndex = 0
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(520, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbx_Actualizar
        '
        Me.gbx_Actualizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Actualizar.Controls.Add(Me.lbl_MinutosNueva)
        Me.gbx_Actualizar.Controls.Add(Me.lbl_DuracionNueva)
        Me.gbx_Actualizar.Controls.Add(Me.tbx_DuracionNueva)
        Me.gbx_Actualizar.Controls.Add(Me.cmb_HoraInicioNueva)
        Me.gbx_Actualizar.Controls.Add(Me.lbl_HoraInicioNueva)
        Me.gbx_Actualizar.Controls.Add(Me.cmb_HoraFinNueva)
        Me.gbx_Actualizar.Controls.Add(Me.lbl_HoraFinNueva)
        Me.gbx_Actualizar.Controls.Add(Me.dtp_FechaProxima)
        Me.gbx_Actualizar.Controls.Add(Me.tbx_Comentarios)
        Me.gbx_Actualizar.Controls.Add(Me.lbl_Comentario)
        Me.gbx_Actualizar.Controls.Add(Me.lbl_FechaProxima)
        Me.gbx_Actualizar.Enabled = False
        Me.gbx_Actualizar.Location = New System.Drawing.Point(143, 413)
        Me.gbx_Actualizar.Name = "gbx_Actualizar"
        Me.gbx_Actualizar.Size = New System.Drawing.Size(535, 155)
        Me.gbx_Actualizar.TabIndex = 8
        Me.gbx_Actualizar.TabStop = False
        '
        'lbl_MinutosNueva
        '
        Me.lbl_MinutosNueva.AutoSize = True
        Me.lbl_MinutosNueva.Location = New System.Drawing.Point(483, 49)
        Me.lbl_MinutosNueva.Name = "lbl_MinutosNueva"
        Me.lbl_MinutosNueva.Size = New System.Drawing.Size(24, 13)
        Me.lbl_MinutosNueva.TabIndex = 9
        Me.lbl_MinutosNueva.Text = "Min"
        '
        'lbl_DuracionNueva
        '
        Me.lbl_DuracionNueva.AutoSize = True
        Me.lbl_DuracionNueva.Location = New System.Drawing.Point(381, 49)
        Me.lbl_DuracionNueva.Name = "lbl_DuracionNueva"
        Me.lbl_DuracionNueva.Size = New System.Drawing.Size(50, 13)
        Me.lbl_DuracionNueva.TabIndex = 7
        Me.lbl_DuracionNueva.Text = "Duración"
        '
        'tbx_DuracionNueva
        '
        Me.tbx_DuracionNueva.Control_Siguiente = Nothing
        Me.tbx_DuracionNueva.Enabled = False
        Me.tbx_DuracionNueva.Filtrado = False
        Me.tbx_DuracionNueva.Location = New System.Drawing.Point(437, 46)
        Me.tbx_DuracionNueva.MaxLength = 4
        Me.tbx_DuracionNueva.Name = "tbx_DuracionNueva"
        Me.tbx_DuracionNueva.ReadOnly = True
        Me.tbx_DuracionNueva.Size = New System.Drawing.Size(40, 20)
        Me.tbx_DuracionNueva.TabIndex = 8
        Me.tbx_DuracionNueva.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_HoraInicioNueva
        '
        Me.cmb_HoraInicioNueva.Control_Siguiente = Me.cmb_HoraFinNueva
        Me.cmb_HoraInicioNueva.DisplayMember = "display"
        Me.cmb_HoraInicioNueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HoraInicioNueva.FormattingEnabled = True
        Me.cmb_HoraInicioNueva.Location = New System.Drawing.Point(99, 46)
        Me.cmb_HoraInicioNueva.MaxDropDownItems = 20
        Me.cmb_HoraInicioNueva.Name = "cmb_HoraInicioNueva"
        Me.cmb_HoraInicioNueva.Size = New System.Drawing.Size(111, 21)
        Me.cmb_HoraInicioNueva.TabIndex = 4
        Me.cmb_HoraInicioNueva.ValueMember = "value"
        '
        'lbl_HoraInicioNueva
        '
        Me.lbl_HoraInicioNueva.AutoSize = True
        Me.lbl_HoraInicioNueva.Location = New System.Drawing.Point(30, 49)
        Me.lbl_HoraInicioNueva.Name = "lbl_HoraInicioNueva"
        Me.lbl_HoraInicioNueva.Size = New System.Drawing.Size(58, 13)
        Me.lbl_HoraInicioNueva.TabIndex = 1
        Me.lbl_HoraInicioNueva.Text = "Hora Inicio"
        '
        'lbl_HoraFinNueva
        '
        Me.lbl_HoraFinNueva.AutoSize = True
        Me.lbl_HoraFinNueva.Location = New System.Drawing.Point(216, 49)
        Me.lbl_HoraFinNueva.Name = "lbl_HoraFinNueva"
        Me.lbl_HoraFinNueva.Size = New System.Drawing.Size(47, 13)
        Me.lbl_HoraFinNueva.TabIndex = 5
        Me.lbl_HoraFinNueva.Text = "Hora Fin"
        '
        'dtp_FechaProxima
        '
        Me.dtp_FechaProxima.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_FechaProxima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaProxima.Location = New System.Drawing.Point(99, 20)
        Me.dtp_FechaProxima.Name = "dtp_FechaProxima"
        Me.dtp_FechaProxima.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaProxima.TabIndex = 3
        Me.dtp_FechaProxima.Value = New Date(2011, 7, 1, 0, 0, 0, 0)
        '
        'tbx_Comentarios
        '
        Me.tbx_Comentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Comentarios.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(99, 73)
        Me.tbx_Comentarios.MaxLength = 250
        Me.tbx_Comentarios.Multiline = True
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(430, 76)
        Me.tbx_Comentarios.TabIndex = 10
        Me.tbx_Comentarios.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Comentario
        '
        Me.lbl_Comentario.Location = New System.Drawing.Point(6, 76)
        Me.lbl_Comentario.Name = "lbl_Comentario"
        Me.lbl_Comentario.Size = New System.Drawing.Size(87, 52)
        Me.lbl_Comentario.TabIndex = 2
        Me.lbl_Comentario.Text = "Comentarios"
        Me.lbl_Comentario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_FechaProxima
        '
        Me.lbl_FechaProxima.AutoSize = True
        Me.lbl_FechaProxima.Location = New System.Drawing.Point(16, 24)
        Me.lbl_FechaProxima.Name = "lbl_FechaProxima"
        Me.lbl_FechaProxima.Size = New System.Drawing.Size(72, 13)
        Me.lbl_FechaProxima.TabIndex = 0
        Me.lbl_FechaProxima.Text = "Nueva Fecha"
        Me.lbl_FechaProxima.Visible = False
        '
        'gbx_Accion
        '
        Me.gbx_Accion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Accion.Controls.Add(Me.rdb_Editar)
        Me.gbx_Accion.Controls.Add(Me.rdb_Cancelar)
        Me.gbx_Accion.Controls.Add(Me.rdb_Posponer)
        Me.gbx_Accion.Controls.Add(Me.rdb_Finalizar)
        Me.gbx_Accion.Location = New System.Drawing.Point(12, 413)
        Me.gbx_Accion.Name = "gbx_Accion"
        Me.gbx_Accion.Size = New System.Drawing.Size(125, 155)
        Me.gbx_Accion.TabIndex = 7
        Me.gbx_Accion.TabStop = False
        Me.gbx_Accion.Text = "Acción"
        '
        'rdb_Editar
        '
        Me.rdb_Editar.AutoSize = True
        Me.rdb_Editar.Location = New System.Drawing.Point(14, 24)
        Me.rdb_Editar.Name = "rdb_Editar"
        Me.rdb_Editar.Size = New System.Drawing.Size(52, 17)
        Me.rdb_Editar.TabIndex = 0
        Me.rdb_Editar.Text = "Editar"
        Me.rdb_Editar.UseVisualStyleBackColor = True
        '
        'rdb_Cancelar
        '
        Me.rdb_Cancelar.AutoSize = True
        Me.rdb_Cancelar.Location = New System.Drawing.Point(14, 114)
        Me.rdb_Cancelar.Name = "rdb_Cancelar"
        Me.rdb_Cancelar.Size = New System.Drawing.Size(67, 17)
        Me.rdb_Cancelar.TabIndex = 3
        Me.rdb_Cancelar.Text = "Cancelar"
        Me.rdb_Cancelar.UseVisualStyleBackColor = True
        '
        'rdb_Posponer
        '
        Me.rdb_Posponer.Location = New System.Drawing.Point(14, 76)
        Me.rdb_Posponer.Name = "rdb_Posponer"
        Me.rdb_Posponer.Size = New System.Drawing.Size(81, 32)
        Me.rdb_Posponer.TabIndex = 2
        Me.rdb_Posponer.Text = "Adelantar o Posponer"
        Me.rdb_Posponer.UseVisualStyleBackColor = True
        '
        'rdb_Finalizar
        '
        Me.rdb_Finalizar.AutoSize = True
        Me.rdb_Finalizar.Location = New System.Drawing.Point(14, 53)
        Me.rdb_Finalizar.Name = "rdb_Finalizar"
        Me.rdb_Finalizar.Size = New System.Drawing.Size(63, 17)
        Me.rdb_Finalizar.TabIndex = 1
        Me.rdb_Finalizar.Text = "Finalizar"
        Me.rdb_Finalizar.UseVisualStyleBackColor = True
        '
        'gbx_Diario
        '
        Me.gbx_Diario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Diario.Controls.Add(Me.lbl_DiarioInicio)
        Me.gbx_Diario.Controls.Add(Me.dtp_HastaDiario)
        Me.gbx_Diario.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Diario.Controls.Add(Me.Lbl_RepTodDiasDesde)
        Me.gbx_Diario.Enabled = False
        Me.gbx_Diario.Location = New System.Drawing.Point(144, 222)
        Me.gbx_Diario.Name = "gbx_Diario"
        Me.gbx_Diario.Size = New System.Drawing.Size(534, 43)
        Me.gbx_Diario.TabIndex = 2
        Me.gbx_Diario.TabStop = False
        Me.gbx_Diario.Text = "Diariamente"
        '
        'lbl_DiarioInicio
        '
        Me.lbl_DiarioInicio.AutoSize = True
        Me.lbl_DiarioInicio.Location = New System.Drawing.Point(190, 19)
        Me.lbl_DiarioInicio.Name = "lbl_DiarioInicio"
        Me.lbl_DiarioInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_DiarioInicio.TabIndex = 1
        Me.lbl_DiarioInicio.Text = "01/01/1900"
        '
        'dtp_HastaDiario
        '
        Me.dtp_HastaDiario.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_HastaDiario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_HastaDiario.Location = New System.Drawing.Point(396, 15)
        Me.dtp_HastaDiario.Name = "dtp_HastaDiario"
        Me.dtp_HastaDiario.Size = New System.Drawing.Size(95, 20)
        Me.dtp_HastaDiario.TabIndex = 3
        Me.dtp_HastaDiario.Value = New Date(2011, 7, 1, 0, 0, 0, 0)
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(352, 19)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'Lbl_RepTodDiasDesde
        '
        Me.Lbl_RepTodDiasDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RepTodDiasDesde.AutoSize = True
        Me.Lbl_RepTodDiasDesde.Location = New System.Drawing.Point(49, 19)
        Me.Lbl_RepTodDiasDesde.Name = "Lbl_RepTodDiasDesde"
        Me.Lbl_RepTodDiasDesde.Size = New System.Drawing.Size(142, 13)
        Me.Lbl_RepTodDiasDesde.TabIndex = 0
        Me.Lbl_RepTodDiasDesde.Text = "Repetir todos los días desde"
        '
        'gbx_Semestre
        '
        Me.gbx_Semestre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Semestre.Controls.Add(Me.Lbl_Cada6Mes)
        Me.gbx_Semestre.Controls.Add(Me.dtp_HastaSemestre)
        Me.gbx_Semestre.Controls.Add(Me.lbl_HastaSemestre)
        Me.gbx_Semestre.Controls.Add(Me.cmb_DiaSemestre)
        Me.gbx_Semestre.Controls.Add(Me.Lbl_RepeTodos)
        Me.gbx_Semestre.Enabled = False
        Me.gbx_Semestre.Location = New System.Drawing.Point(143, 365)
        Me.gbx_Semestre.Name = "gbx_Semestre"
        Me.gbx_Semestre.Size = New System.Drawing.Size(535, 43)
        Me.gbx_Semestre.TabIndex = 6
        Me.gbx_Semestre.TabStop = False
        Me.gbx_Semestre.Text = "Por Semestre"
        '
        'Lbl_Cada6Mes
        '
        Me.Lbl_Cada6Mes.AutoSize = True
        Me.Lbl_Cada6Mes.Location = New System.Drawing.Point(247, 19)
        Me.Lbl_Cada6Mes.Name = "Lbl_Cada6Mes"
        Me.Lbl_Cada6Mes.Size = New System.Drawing.Size(89, 13)
        Me.Lbl_Cada6Mes.TabIndex = 2
        Me.Lbl_Cada6Mes.Text = "de cada 6 Meses"
        '
        'dtp_HastaSemestre
        '
        Me.dtp_HastaSemestre.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_HastaSemestre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_HastaSemestre.Location = New System.Drawing.Point(396, 15)
        Me.dtp_HastaSemestre.Name = "dtp_HastaSemestre"
        Me.dtp_HastaSemestre.Size = New System.Drawing.Size(95, 20)
        Me.dtp_HastaSemestre.TabIndex = 4
        Me.dtp_HastaSemestre.Value = New Date(2011, 7, 1, 0, 0, 0, 0)
        '
        'lbl_HastaSemestre
        '
        Me.lbl_HastaSemestre.AutoSize = True
        Me.lbl_HastaSemestre.Location = New System.Drawing.Point(352, 19)
        Me.lbl_HastaSemestre.Name = "lbl_HastaSemestre"
        Me.lbl_HastaSemestre.Size = New System.Drawing.Size(35, 13)
        Me.lbl_HastaSemestre.TabIndex = 3
        Me.lbl_HastaSemestre.Text = "Hasta"
        '
        'cmb_DiaSemestre
        '
        Me.cmb_DiaSemestre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_DiaSemestre.Control_Siguiente = Me.cmb_HoraFinNueva
        Me.cmb_DiaSemestre.DisplayMember = "display"
        Me.cmb_DiaSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DiaSemestre.Enabled = False
        Me.cmb_DiaSemestre.FormattingEnabled = True
        Me.cmb_DiaSemestre.Location = New System.Drawing.Point(142, 15)
        Me.cmb_DiaSemestre.MaxDropDownItems = 32
        Me.cmb_DiaSemestre.Name = "cmb_DiaSemestre"
        Me.cmb_DiaSemestre.Size = New System.Drawing.Size(99, 21)
        Me.cmb_DiaSemestre.TabIndex = 1
        Me.cmb_DiaSemestre.ValueMember = "value"
        '
        'Lbl_RepeTodos
        '
        Me.Lbl_RepeTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RepeTodos.AutoSize = True
        Me.Lbl_RepeTodos.Location = New System.Drawing.Point(50, 19)
        Me.Lbl_RepeTodos.Name = "Lbl_RepeTodos"
        Me.Lbl_RepeTodos.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_RepeTodos.TabIndex = 0
        Me.Lbl_RepeTodos.Text = "Repetir todos los"
        '
        'frm_AgendaCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 631)
        Me.Controls.Add(Me.gbx_Semestre)
        Me.Controls.Add(Me.gbx_Diario)
        Me.Controls.Add(Me.gbx_Mes)
        Me.Controls.Add(Me.gbx_Recurrente)
        Me.Controls.Add(Me.gbx_Semana)
        Me.Controls.Add(Me.gbx_Accion)
        Me.Controls.Add(Me.gbx_Actualizar)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(690, 660)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(690, 660)
        Me.Name = "frm_AgendaCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Evento"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_Recurrente.ResumeLayout(False)
        Me.gbx_Recurrente.PerformLayout()
        Me.gbx_Mes.ResumeLayout(False)
        Me.gbx_Mes.PerformLayout()
        Me.gbx_Semana.ResumeLayout(False)
        Me.gbx_Semana.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Actualizar.ResumeLayout(False)
        Me.gbx_Actualizar.PerformLayout()
        Me.gbx_Accion.ResumeLayout(False)
        Me.gbx_Accion.PerformLayout()
        Me.gbx_Diario.ResumeLayout(False)
        Me.gbx_Diario.PerformLayout()
        Me.gbx_Semestre.ResumeLayout(False)
        Me.gbx_Semestre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Asunto As System.Windows.Forms.Label
    Friend WithEvents tbx_Asunto As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents gbx_Actualizar As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Accion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Comentario As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaProxima As System.Windows.Forms.Label
    Friend WithEvents rdb_Cancelar As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Posponer As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Finalizar As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Comentarios As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaTarea As System.Windows.Forms.Label
    Friend WithEvents cmb_HoraInicio As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_HoraInicio As System.Windows.Forms.Label
    Friend WithEvents cmb_HoraFin As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_HoraFin As System.Windows.Forms.Label
    Friend WithEvents lbl_Minutos As System.Windows.Forms.Label
    Friend WithEvents lbl_Duracion As System.Windows.Forms.Label
    Friend WithEvents tbx_Duracion As Modulo_Ventas.cp_Textbox
    Friend WithEvents dtp_FechaProxima As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_MinutosNueva As System.Windows.Forms.Label
    Friend WithEvents lbl_DuracionNueva As System.Windows.Forms.Label
    Friend WithEvents tbx_DuracionNueva As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_HoraInicioNueva As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_HoraFinNueva As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_HoraInicioNueva As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraFinNueva As System.Windows.Forms.Label
    Friend WithEvents gbx_Semana As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_DiaSemana As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Lbl_RepTodos As System.Windows.Forms.Label
    Friend WithEvents gbx_Mes As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_HastaMes As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HastaMes As System.Windows.Forms.Label
    Friend WithEvents cmb_DiaMes As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Lbl_RepTod As System.Windows.Forms.Label
    Friend WithEvents dtp_HastaDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HastaSemana As System.Windows.Forms.Label
    Friend WithEvents Lbl_CadaMes As System.Windows.Forms.Label
    Friend WithEvents Lbl_CadaSem As System.Windows.Forms.Label
    Friend WithEvents gbx_Recurrente As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Mes As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Semana As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Ninguno As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Editar As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Diario As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_Diario As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_HastaDiario As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_RepTodDiasDesde As System.Windows.Forms.Label
    Friend WithEvents lbl_DiarioInicio As System.Windows.Forms.Label
    Friend WithEvents rdb_Semestre As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_Semestre As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Cada6Mes As System.Windows.Forms.Label
    Friend WithEvents dtp_HastaSemestre As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HastaSemestre As System.Windows.Forms.Label
    Friend WithEvents cmb_DiaSemestre As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Lbl_RepeTodos As System.Windows.Forms.Label
End Class
