<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CajasFuertesMov
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_GuardarImprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.lbl_CombActual = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.chk_Retiro = New System.Windows.Forms.CheckBox
        Me.dtp_FechaRetiro = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaRetiro = New System.Windows.Forms.Label
        Me.chk_Cita = New System.Windows.Forms.CheckBox
        Me.lbl_Cita = New System.Windows.Forms.Label
        Me.gbx_Cita = New System.Windows.Forms.GroupBox
        Me.dtp_HoraCita = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaCita = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaCita = New System.Windows.Forms.Label
        Me.lbl_HoraCita = New System.Windows.Forms.Label
        Me.cmb_Contacto = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Contacto = New System.Windows.Forms.Label
        Me.lbl_AContacto = New System.Windows.Forms.Label
        Me.tbx_CombActual2 = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombActual1 = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombActual0 = New Modulo_Ventas.cp_Textbox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.lbl_AFecha = New System.Windows.Forms.Label
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_ACliente = New System.Windows.Forms.Label
        Me.gbx_Asignacion = New System.Windows.Forms.GroupBox
        Me.rbn_ManejoCombinacion = New System.Windows.Forms.RadioButton
        Me.rbn_Reubicacion = New System.Windows.Forms.RadioButton
        Me.rbn_Combinacion = New System.Windows.Forms.RadioButton
        Me.rbn_Retiro = New System.Windows.Forms.RadioButton
        Me.rbn_Mantenimiento = New System.Windows.Forms.RadioButton
        Me.rbn_Renta = New System.Windows.Forms.RadioButton
        Me.rbn_Venta = New System.Windows.Forms.RadioButton
        Me.gbx_Instalacion = New System.Windows.Forms.GroupBox
        Me.rbn_Instalacion = New System.Windows.Forms.RadioButton
        Me.rbn_Ambos = New System.Windows.Forms.RadioButton
        Me.rbn_Ninguno = New System.Windows.Forms.RadioButton
        Me.rbn_Desinstalacion = New System.Windows.Forms.RadioButton
        Me.lbl_CajaFuerte = New System.Windows.Forms.Label
        Me.gbx_Combinacion = New System.Windows.Forms.GroupBox
        Me.rbn_CombinacionNo = New System.Windows.Forms.RadioButton
        Me.rbn_CombinacionSi = New System.Windows.Forms.RadioButton
        Me.gbx_ClienteServicio = New System.Windows.Forms.GroupBox
        Me.lbl_PrecioAntIndDes = New System.Windows.Forms.Label
        Me.lbl_PrecioAntServicio = New System.Windows.Forms.Label
        Me.lbl_PrecioAnteriorInsDes = New System.Windows.Forms.Label
        Me.lbl_PrecioAnteriorServicio = New System.Windows.Forms.Label
        Me.lbl_PrecioInsDesA = New System.Windows.Forms.Label
        Me.lbl_PrecioTipoMovA = New System.Windows.Forms.Label
        Me.lbl_PrecioInsDes = New System.Windows.Forms.Label
        Me.cmb_PrecioInsDes = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_PrecioTipoMov = New System.Windows.Forms.Label
        Me.cmb_PrecioTipoMov = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Cita.SuspendLayout()
        Me.gbx_Asignacion.SuspendLayout()
        Me.gbx_Instalacion.SuspendLayout()
        Me.gbx_Combinacion.SuspendLayout()
        Me.gbx_ClienteServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_GuardarImprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(11, 510)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(627, 53)
        Me.gbx_Botones.TabIndex = 6
        Me.gbx_Botones.TabStop = False
        '
        'btn_GuardarImprimir
        '
        Me.btn_GuardarImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarImprimir.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_GuardarImprimir.Location = New System.Drawing.Point(152, 14)
        Me.btn_GuardarImprimir.Name = "btn_GuardarImprimir"
        Me.btn_GuardarImprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarImprimir.TabIndex = 1
        Me.btn_GuardarImprimir.Text = "Guardar e &Imprimir"
        Me.btn_GuardarImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarImprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(481, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
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
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(9, 45)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(111, 13)
        Me.lbl_Fecha.TabIndex = 3
        Me.lbl_Fecha.Text = "Fecha del Movimiento"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(42, 127)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 13
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'lbl_CombActual
        '
        Me.lbl_CombActual.AutoSize = True
        Me.lbl_CombActual.Location = New System.Drawing.Point(19, 194)
        Me.lbl_CombActual.Name = "lbl_CombActual"
        Me.lbl_CombActual.Size = New System.Drawing.Size(101, 13)
        Me.lbl_CombActual.TabIndex = 15
        Me.lbl_CombActual.Text = "Combinación Actual"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.chk_Retiro)
        Me.gbx_Datos.Controls.Add(Me.dtp_FechaRetiro)
        Me.gbx_Datos.Controls.Add(Me.lbl_FechaRetiro)
        Me.gbx_Datos.Controls.Add(Me.chk_Cita)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cita)
        Me.gbx_Datos.Controls.Add(Me.gbx_Cita)
        Me.gbx_Datos.Controls.Add(Me.cmb_Contacto)
        Me.gbx_Datos.Controls.Add(Me.lbl_Contacto)
        Me.gbx_Datos.Controls.Add(Me.lbl_AContacto)
        Me.gbx_Datos.Controls.Add(Me.tbx_CombActual2)
        Me.gbx_Datos.Controls.Add(Me.tbx_CombActual1)
        Me.gbx_Datos.Controls.Add(Me.tbx_CombActual0)
        Me.gbx_Datos.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_Datos.Controls.Add(Me.lbl_AFecha)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_CombActual)
        Me.gbx_Datos.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_Datos.Enabled = False
        Me.gbx_Datos.Location = New System.Drawing.Point(11, 276)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(627, 228)
        Me.gbx_Datos.TabIndex = 5
        Me.gbx_Datos.TabStop = False
        Me.gbx_Datos.Text = "Detalles del Movimiento"
        '
        'chk_Retiro
        '
        Me.chk_Retiro.AutoSize = True
        Me.chk_Retiro.Location = New System.Drawing.Point(227, 68)
        Me.chk_Retiro.Name = "chk_Retiro"
        Me.chk_Retiro.Size = New System.Drawing.Size(72, 17)
        Me.chk_Retiro.TabIndex = 9
        Me.chk_Retiro.Text = "No Aplica"
        Me.chk_Retiro.UseVisualStyleBackColor = True
        '
        'dtp_FechaRetiro
        '
        Me.dtp_FechaRetiro.Enabled = False
        Me.dtp_FechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaRetiro.Location = New System.Drawing.Point(126, 65)
        Me.dtp_FechaRetiro.Name = "dtp_FechaRetiro"
        Me.dtp_FechaRetiro.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaRetiro.TabIndex = 7
        '
        'lbl_FechaRetiro
        '
        Me.lbl_FechaRetiro.AutoSize = True
        Me.lbl_FechaRetiro.Enabled = False
        Me.lbl_FechaRetiro.Location = New System.Drawing.Point(6, 69)
        Me.lbl_FechaRetiro.Name = "lbl_FechaRetiro"
        Me.lbl_FechaRetiro.Size = New System.Drawing.Size(114, 13)
        Me.lbl_FechaRetiro.TabIndex = 6
        Me.lbl_FechaRetiro.Text = "Fecha Estimada Retiro"
        '
        'chk_Cita
        '
        Me.chk_Cita.AutoSize = True
        Me.chk_Cita.Location = New System.Drawing.Point(386, 98)
        Me.chk_Cita.Name = "chk_Cita"
        Me.chk_Cita.Size = New System.Drawing.Size(72, 17)
        Me.chk_Cita.TabIndex = 12
        Me.chk_Cita.Text = "No Aplica"
        Me.chk_Cita.UseVisualStyleBackColor = True
        '
        'lbl_Cita
        '
        Me.lbl_Cita.AutoSize = True
        Me.lbl_Cita.Location = New System.Drawing.Point(44, 98)
        Me.lbl_Cita.Name = "lbl_Cita"
        Me.lbl_Cita.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Cita.TabIndex = 10
        Me.lbl_Cita.Text = "Programar Cita"
        '
        'gbx_Cita
        '
        Me.gbx_Cita.Controls.Add(Me.dtp_HoraCita)
        Me.gbx_Cita.Controls.Add(Me.dtp_FechaCita)
        Me.gbx_Cita.Controls.Add(Me.lbl_FechaCita)
        Me.gbx_Cita.Controls.Add(Me.lbl_HoraCita)
        Me.gbx_Cita.Location = New System.Drawing.Point(126, 84)
        Me.gbx_Cita.Name = "gbx_Cita"
        Me.gbx_Cita.Size = New System.Drawing.Size(254, 36)
        Me.gbx_Cita.TabIndex = 11
        Me.gbx_Cita.TabStop = False
        '
        'dtp_HoraCita
        '
        Me.dtp_HoraCita.CustomFormat = "HH:mm"
        Me.dtp_HoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraCita.Location = New System.Drawing.Point(185, 11)
        Me.dtp_HoraCita.Name = "dtp_HoraCita"
        Me.dtp_HoraCita.ShowUpDown = True
        Me.dtp_HoraCita.Size = New System.Drawing.Size(62, 20)
        Me.dtp_HoraCita.TabIndex = 3
        '
        'dtp_FechaCita
        '
        Me.dtp_FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaCita.Location = New System.Drawing.Point(48, 11)
        Me.dtp_FechaCita.Name = "dtp_FechaCita"
        Me.dtp_FechaCita.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaCita.TabIndex = 1
        '
        'lbl_FechaCita
        '
        Me.lbl_FechaCita.AutoSize = True
        Me.lbl_FechaCita.Location = New System.Drawing.Point(5, 15)
        Me.lbl_FechaCita.Name = "lbl_FechaCita"
        Me.lbl_FechaCita.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaCita.TabIndex = 0
        Me.lbl_FechaCita.Text = "Fecha"
        '
        'lbl_HoraCita
        '
        Me.lbl_HoraCita.AutoSize = True
        Me.lbl_HoraCita.Location = New System.Drawing.Point(149, 14)
        Me.lbl_HoraCita.Name = "lbl_HoraCita"
        Me.lbl_HoraCita.Size = New System.Drawing.Size(30, 13)
        Me.lbl_HoraCita.TabIndex = 2
        Me.lbl_HoraCita.Text = "Hora"
        '
        'cmb_Contacto
        '
        Me.cmb_Contacto.Clave = Nothing
        Me.cmb_Contacto.Control_Siguiente = Me.dtp_Fecha
        Me.cmb_Contacto.DisplayMember = "Nombre_Contacto"
        Me.cmb_Contacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Contacto.Empresa = False
        Me.cmb_Contacto.Enabled = False
        Me.cmb_Contacto.Filtro = Nothing
        Me.cmb_Contacto.FormattingEnabled = True
        Me.cmb_Contacto.Location = New System.Drawing.Point(126, 16)
        Me.cmb_Contacto.MaxDropDownItems = 20
        Me.cmb_Contacto.Name = "cmb_Contacto"
        Me.cmb_Contacto.Pista = False
        Me.cmb_Contacto.Size = New System.Drawing.Size(281, 21)
        Me.cmb_Contacto.StoredProcedure = "Cat_ClientesContactos_GetCombo"
        Me.cmb_Contacto.Sucursal = False
        Me.cmb_Contacto.TabIndex = 1
        Me.cmb_Contacto.Tipo = 0
        Me.cmb_Contacto.ValueMember = "Id_Contacto"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(126, 41)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 4
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Enabled = False
        Me.lbl_Contacto.Location = New System.Drawing.Point(70, 19)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Contacto.TabIndex = 0
        Me.lbl_Contacto.Text = "Contacto"
        Me.lbl_Contacto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_AContacto
        '
        Me.lbl_AContacto.AutoSize = True
        Me.lbl_AContacto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AContacto.ForeColor = System.Drawing.Color.Red
        Me.lbl_AContacto.Location = New System.Drawing.Point(413, 17)
        Me.lbl_AContacto.Name = "lbl_AContacto"
        Me.lbl_AContacto.Size = New System.Drawing.Size(13, 16)
        Me.lbl_AContacto.TabIndex = 2
        Me.lbl_AContacto.Text = "*"
        Me.lbl_AContacto.Visible = False
        '
        'tbx_CombActual2
        '
        Me.tbx_CombActual2.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CombActual2.Control_Siguiente = Nothing
        Me.tbx_CombActual2.Filtrado = True
        Me.tbx_CombActual2.Location = New System.Drawing.Point(238, 191)
        Me.tbx_CombActual2.MaxLength = 4
        Me.tbx_CombActual2.Name = "tbx_CombActual2"
        Me.tbx_CombActual2.ReadOnly = True
        Me.tbx_CombActual2.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombActual2.TabIndex = 18
        Me.tbx_CombActual2.TabStop = False
        Me.tbx_CombActual2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_CombActual1
        '
        Me.tbx_CombActual1.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CombActual1.Control_Siguiente = Nothing
        Me.tbx_CombActual1.Filtrado = True
        Me.tbx_CombActual1.Location = New System.Drawing.Point(182, 191)
        Me.tbx_CombActual1.MaxLength = 4
        Me.tbx_CombActual1.Name = "tbx_CombActual1"
        Me.tbx_CombActual1.ReadOnly = True
        Me.tbx_CombActual1.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombActual1.TabIndex = 17
        Me.tbx_CombActual1.TabStop = False
        Me.tbx_CombActual1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_CombActual0
        '
        Me.tbx_CombActual0.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CombActual0.Control_Siguiente = Nothing
        Me.tbx_CombActual0.Filtrado = True
        Me.tbx_CombActual0.Location = New System.Drawing.Point(126, 191)
        Me.tbx_CombActual0.MaxLength = 4
        Me.tbx_CombActual0.Name = "tbx_CombActual0"
        Me.tbx_CombActual0.ReadOnly = True
        Me.tbx_CombActual0.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombActual0.TabIndex = 16
        Me.tbx_CombActual0.TabStop = False
        Me.tbx_CombActual0.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(126, 124)
        Me.rtb_Observaciones.MaxLength = 3000
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(488, 63)
        Me.rtb_Observaciones.TabIndex = 14
        Me.rtb_Observaciones.Text = ""
        '
        'lbl_AFecha
        '
        Me.lbl_AFecha.AutoSize = True
        Me.lbl_AFecha.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AFecha.ForeColor = System.Drawing.Color.Red
        Me.lbl_AFecha.Location = New System.Drawing.Point(227, 43)
        Me.lbl_AFecha.Name = "lbl_AFecha"
        Me.lbl_AFecha.Size = New System.Drawing.Size(13, 16)
        Me.lbl_AFecha.TabIndex = 5
        Me.lbl_AFecha.Text = "*"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(106, 17)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 3
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(6, 22)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente"
        Me.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ACliente
        '
        Me.lbl_ACliente.AutoSize = True
        Me.lbl_ACliente.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ACliente.ForeColor = System.Drawing.Color.Red
        Me.lbl_ACliente.Location = New System.Drawing.Point(138, 20)
        Me.lbl_ACliente.Name = "lbl_ACliente"
        Me.lbl_ACliente.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ACliente.TabIndex = 2
        Me.lbl_ACliente.Text = "*"
        Me.lbl_ACliente.Visible = False
        '
        'gbx_Asignacion
        '
        Me.gbx_Asignacion.Controls.Add(Me.rbn_ManejoCombinacion)
        Me.gbx_Asignacion.Controls.Add(Me.rbn_Reubicacion)
        Me.gbx_Asignacion.Controls.Add(Me.rbn_Combinacion)
        Me.gbx_Asignacion.Controls.Add(Me.rbn_Retiro)
        Me.gbx_Asignacion.Controls.Add(Me.rbn_Mantenimiento)
        Me.gbx_Asignacion.Controls.Add(Me.rbn_Renta)
        Me.gbx_Asignacion.Controls.Add(Me.rbn_Venta)
        Me.gbx_Asignacion.Location = New System.Drawing.Point(11, 36)
        Me.gbx_Asignacion.Name = "gbx_Asignacion"
        Me.gbx_Asignacion.Size = New System.Drawing.Size(200, 234)
        Me.gbx_Asignacion.TabIndex = 1
        Me.gbx_Asignacion.TabStop = False
        Me.gbx_Asignacion.Text = "Tipo de Movimiento"
        '
        'rbn_ManejoCombinacion
        '
        Me.rbn_ManejoCombinacion.AutoSize = True
        Me.rbn_ManejoCombinacion.Location = New System.Drawing.Point(6, 139)
        Me.rbn_ManejoCombinacion.Name = "rbn_ManejoCombinacion"
        Me.rbn_ManejoCombinacion.Size = New System.Drawing.Size(192, 17)
        Me.rbn_ManejoCombinacion.TabIndex = 4
        Me.rbn_ManejoCombinacion.Text = "Cambio de Manejo de Combinación"
        Me.rbn_ManejoCombinacion.UseVisualStyleBackColor = True
        '
        'rbn_Reubicacion
        '
        Me.rbn_Reubicacion.AutoSize = True
        Me.rbn_Reubicacion.Location = New System.Drawing.Point(6, 111)
        Me.rbn_Reubicacion.Name = "rbn_Reubicacion"
        Me.rbn_Reubicacion.Size = New System.Drawing.Size(157, 17)
        Me.rbn_Reubicacion.TabIndex = 3
        Me.rbn_Reubicacion.Text = "Reubicación de Caja Fuerte"
        Me.rbn_Reubicacion.UseVisualStyleBackColor = True
        '
        'rbn_Combinacion
        '
        Me.rbn_Combinacion.AutoSize = True
        Me.rbn_Combinacion.Location = New System.Drawing.Point(6, 167)
        Me.rbn_Combinacion.Name = "rbn_Combinacion"
        Me.rbn_Combinacion.Size = New System.Drawing.Size(139, 17)
        Me.rbn_Combinacion.TabIndex = 5
        Me.rbn_Combinacion.Text = "Cambio de Combinación"
        Me.rbn_Combinacion.UseVisualStyleBackColor = True
        '
        'rbn_Retiro
        '
        Me.rbn_Retiro.AutoSize = True
        Me.rbn_Retiro.Location = New System.Drawing.Point(6, 83)
        Me.rbn_Retiro.Name = "rbn_Retiro"
        Me.rbn_Retiro.Size = New System.Drawing.Size(123, 17)
        Me.rbn_Retiro.TabIndex = 2
        Me.rbn_Retiro.Text = "Fin de Renta (Retiro)"
        Me.rbn_Retiro.UseVisualStyleBackColor = True
        '
        'rbn_Mantenimiento
        '
        Me.rbn_Mantenimiento.AutoSize = True
        Me.rbn_Mantenimiento.Location = New System.Drawing.Point(6, 195)
        Me.rbn_Mantenimiento.Name = "rbn_Mantenimiento"
        Me.rbn_Mantenimiento.Size = New System.Drawing.Size(161, 17)
        Me.rbn_Mantenimiento.TabIndex = 6
        Me.rbn_Mantenimiento.Text = "Mantenimiento o Reparación"
        Me.rbn_Mantenimiento.UseVisualStyleBackColor = True
        '
        'rbn_Renta
        '
        Me.rbn_Renta.AutoSize = True
        Me.rbn_Renta.Location = New System.Drawing.Point(6, 55)
        Me.rbn_Renta.Name = "rbn_Renta"
        Me.rbn_Renta.Size = New System.Drawing.Size(124, 17)
        Me.rbn_Renta.TabIndex = 1
        Me.rbn_Renta.Text = "Asignación en Renta"
        Me.rbn_Renta.UseVisualStyleBackColor = True
        '
        'rbn_Venta
        '
        Me.rbn_Venta.AutoSize = True
        Me.rbn_Venta.Location = New System.Drawing.Point(6, 27)
        Me.rbn_Venta.Name = "rbn_Venta"
        Me.rbn_Venta.Size = New System.Drawing.Size(123, 17)
        Me.rbn_Venta.TabIndex = 0
        Me.rbn_Venta.Text = "Asignación en Venta"
        Me.rbn_Venta.UseVisualStyleBackColor = True
        '
        'gbx_Instalacion
        '
        Me.gbx_Instalacion.Controls.Add(Me.rbn_Instalacion)
        Me.gbx_Instalacion.Controls.Add(Me.rbn_Ambos)
        Me.gbx_Instalacion.Controls.Add(Me.rbn_Ninguno)
        Me.gbx_Instalacion.Controls.Add(Me.rbn_Desinstalacion)
        Me.gbx_Instalacion.Enabled = False
        Me.gbx_Instalacion.Location = New System.Drawing.Point(217, 36)
        Me.gbx_Instalacion.Name = "gbx_Instalacion"
        Me.gbx_Instalacion.Size = New System.Drawing.Size(231, 68)
        Me.gbx_Instalacion.TabIndex = 2
        Me.gbx_Instalacion.TabStop = False
        Me.gbx_Instalacion.Text = "Requiere Instalación o Desinstalación?"
        '
        'rbn_Instalacion
        '
        Me.rbn_Instalacion.AutoSize = True
        Me.rbn_Instalacion.Location = New System.Drawing.Point(27, 22)
        Me.rbn_Instalacion.Name = "rbn_Instalacion"
        Me.rbn_Instalacion.Size = New System.Drawing.Size(76, 17)
        Me.rbn_Instalacion.TabIndex = 1
        Me.rbn_Instalacion.Text = "Instalación"
        Me.rbn_Instalacion.UseVisualStyleBackColor = True
        '
        'rbn_Ambos
        '
        Me.rbn_Ambos.AutoSize = True
        Me.rbn_Ambos.Location = New System.Drawing.Point(27, 45)
        Me.rbn_Ambos.Name = "rbn_Ambos"
        Me.rbn_Ambos.Size = New System.Drawing.Size(57, 17)
        Me.rbn_Ambos.TabIndex = 0
        Me.rbn_Ambos.Text = "Ambos"
        Me.rbn_Ambos.UseVisualStyleBackColor = True
        '
        'rbn_Ninguno
        '
        Me.rbn_Ninguno.AutoSize = True
        Me.rbn_Ninguno.Location = New System.Drawing.Point(109, 45)
        Me.rbn_Ninguno.Name = "rbn_Ninguno"
        Me.rbn_Ninguno.Size = New System.Drawing.Size(65, 17)
        Me.rbn_Ninguno.TabIndex = 3
        Me.rbn_Ninguno.Text = "Ninguno"
        Me.rbn_Ninguno.UseVisualStyleBackColor = True
        '
        'rbn_Desinstalacion
        '
        Me.rbn_Desinstalacion.AutoSize = True
        Me.rbn_Desinstalacion.Location = New System.Drawing.Point(109, 22)
        Me.rbn_Desinstalacion.Name = "rbn_Desinstalacion"
        Me.rbn_Desinstalacion.Size = New System.Drawing.Size(94, 17)
        Me.rbn_Desinstalacion.TabIndex = 2
        Me.rbn_Desinstalacion.Text = "Desinstalación"
        Me.rbn_Desinstalacion.UseVisualStyleBackColor = True
        '
        'lbl_CajaFuerte
        '
        Me.lbl_CajaFuerte.AutoSize = True
        Me.lbl_CajaFuerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CajaFuerte.Location = New System.Drawing.Point(7, 9)
        Me.lbl_CajaFuerte.Name = "lbl_CajaFuerte"
        Me.lbl_CajaFuerte.Size = New System.Drawing.Size(150, 24)
        Me.lbl_CajaFuerte.TabIndex = 0
        Me.lbl_CajaFuerte.Text = "CAJA FUERTE"
        '
        'gbx_Combinacion
        '
        Me.gbx_Combinacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Combinacion.Controls.Add(Me.rbn_CombinacionNo)
        Me.gbx_Combinacion.Controls.Add(Me.rbn_CombinacionSi)
        Me.gbx_Combinacion.Enabled = False
        Me.gbx_Combinacion.Location = New System.Drawing.Point(454, 36)
        Me.gbx_Combinacion.Name = "gbx_Combinacion"
        Me.gbx_Combinacion.Size = New System.Drawing.Size(184, 68)
        Me.gbx_Combinacion.TabIndex = 3
        Me.gbx_Combinacion.TabStop = False
        Me.gbx_Combinacion.Text = "Cliente Maneja la Combinación?"
        '
        'rbn_CombinacionNo
        '
        Me.rbn_CombinacionNo.AutoSize = True
        Me.rbn_CombinacionNo.Location = New System.Drawing.Point(29, 45)
        Me.rbn_CombinacionNo.Name = "rbn_CombinacionNo"
        Me.rbn_CombinacionNo.Size = New System.Drawing.Size(39, 17)
        Me.rbn_CombinacionNo.TabIndex = 1
        Me.rbn_CombinacionNo.Text = "No"
        Me.rbn_CombinacionNo.UseVisualStyleBackColor = True
        '
        'rbn_CombinacionSi
        '
        Me.rbn_CombinacionSi.AutoSize = True
        Me.rbn_CombinacionSi.Location = New System.Drawing.Point(29, 22)
        Me.rbn_CombinacionSi.Name = "rbn_CombinacionSi"
        Me.rbn_CombinacionSi.Size = New System.Drawing.Size(36, 17)
        Me.rbn_CombinacionSi.TabIndex = 0
        Me.rbn_CombinacionSi.Text = "Sí"
        Me.rbn_CombinacionSi.UseVisualStyleBackColor = True
        '
        'gbx_ClienteServicio
        '
        Me.gbx_ClienteServicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioAntIndDes)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioAntServicio)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioAnteriorInsDes)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioAnteriorServicio)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioInsDesA)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioTipoMovA)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioInsDes)
        Me.gbx_ClienteServicio.Controls.Add(Me.cmb_PrecioInsDes)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_PrecioTipoMov)
        Me.gbx_ClienteServicio.Controls.Add(Me.cmb_PrecioTipoMov)
        Me.gbx_ClienteServicio.Controls.Add(Me.tbx_Cliente)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_Cliente)
        Me.gbx_ClienteServicio.Controls.Add(Me.btn_BuscarCliente)
        Me.gbx_ClienteServicio.Controls.Add(Me.lbl_ACliente)
        Me.gbx_ClienteServicio.Controls.Add(Me.cmb_Cliente)
        Me.gbx_ClienteServicio.Enabled = False
        Me.gbx_ClienteServicio.Location = New System.Drawing.Point(217, 110)
        Me.gbx_ClienteServicio.Name = "gbx_ClienteServicio"
        Me.gbx_ClienteServicio.Size = New System.Drawing.Size(421, 160)
        Me.gbx_ClienteServicio.TabIndex = 4
        Me.gbx_ClienteServicio.TabStop = False
        Me.gbx_ClienteServicio.Text = "Servicios del Cliente"
        '
        'lbl_PrecioAntIndDes
        '
        Me.lbl_PrecioAntIndDes.Location = New System.Drawing.Point(323, 109)
        Me.lbl_PrecioAntIndDes.Name = "lbl_PrecioAntIndDes"
        Me.lbl_PrecioAntIndDes.Size = New System.Drawing.Size(85, 14)
        Me.lbl_PrecioAntIndDes.TabIndex = 14
        Me.lbl_PrecioAntIndDes.Text = "0.00"
        Me.lbl_PrecioAntIndDes.Visible = False
        '
        'lbl_PrecioAntServicio
        '
        Me.lbl_PrecioAntServicio.Location = New System.Drawing.Point(323, 69)
        Me.lbl_PrecioAntServicio.Name = "lbl_PrecioAntServicio"
        Me.lbl_PrecioAntServicio.Size = New System.Drawing.Size(85, 15)
        Me.lbl_PrecioAntServicio.TabIndex = 13
        Me.lbl_PrecioAntServicio.Text = "0.00"
        Me.lbl_PrecioAntServicio.Visible = False
        '
        'lbl_PrecioAnteriorInsDes
        '
        Me.lbl_PrecioAnteriorInsDes.AutoSize = True
        Me.lbl_PrecioAnteriorInsDes.Location = New System.Drawing.Point(226, 109)
        Me.lbl_PrecioAnteriorInsDes.Name = "lbl_PrecioAnteriorInsDes"
        Me.lbl_PrecioAnteriorInsDes.Size = New System.Drawing.Size(99, 13)
        Me.lbl_PrecioAnteriorInsDes.TabIndex = 12
        Me.lbl_PrecioAnteriorInsDes.Text = "Precio Guardado: $"
        Me.lbl_PrecioAnteriorInsDes.Visible = False
        '
        'lbl_PrecioAnteriorServicio
        '
        Me.lbl_PrecioAnteriorServicio.AutoSize = True
        Me.lbl_PrecioAnteriorServicio.Location = New System.Drawing.Point(226, 69)
        Me.lbl_PrecioAnteriorServicio.Name = "lbl_PrecioAnteriorServicio"
        Me.lbl_PrecioAnteriorServicio.Size = New System.Drawing.Size(99, 13)
        Me.lbl_PrecioAnteriorServicio.TabIndex = 11
        Me.lbl_PrecioAnteriorServicio.Text = "Precio Guardado: $"
        Me.lbl_PrecioAnteriorServicio.Visible = False
        '
        'lbl_PrecioInsDesA
        '
        Me.lbl_PrecioInsDesA.AutoSize = True
        Me.lbl_PrecioInsDesA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioInsDesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_PrecioInsDesA.Location = New System.Drawing.Point(393, 125)
        Me.lbl_PrecioInsDesA.Name = "lbl_PrecioInsDesA"
        Me.lbl_PrecioInsDesA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_PrecioInsDesA.TabIndex = 10
        Me.lbl_PrecioInsDesA.Text = "*"
        '
        'lbl_PrecioTipoMovA
        '
        Me.lbl_PrecioTipoMovA.AutoSize = True
        Me.lbl_PrecioTipoMovA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioTipoMovA.ForeColor = System.Drawing.Color.Red
        Me.lbl_PrecioTipoMovA.Location = New System.Drawing.Point(393, 85)
        Me.lbl_PrecioTipoMovA.Name = "lbl_PrecioTipoMovA"
        Me.lbl_PrecioTipoMovA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_PrecioTipoMovA.TabIndex = 7
        Me.lbl_PrecioTipoMovA.Text = "*"
        '
        'lbl_PrecioInsDes
        '
        Me.lbl_PrecioInsDes.AutoSize = True
        Me.lbl_PrecioInsDes.Location = New System.Drawing.Point(6, 109)
        Me.lbl_PrecioInsDes.Name = "lbl_PrecioInsDes"
        Me.lbl_PrecioInsDes.Size = New System.Drawing.Size(200, 13)
        Me.lbl_PrecioInsDes.TabIndex = 8
        Me.lbl_PrecioInsDes.Text = "Precio por Instalación y/o Desinstalación"
        '
        'cmb_PrecioInsDes
        '
        Me.cmb_PrecioInsDes.Clave = ""
        Me.cmb_PrecioInsDes.Control_Siguiente = Me.cmb_Contacto
        Me.cmb_PrecioInsDes.DisplayMember = "Descripcion"
        Me.cmb_PrecioInsDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PrecioInsDes.Empresa = False
        Me.cmb_PrecioInsDes.Enabled = False
        Me.cmb_PrecioInsDes.Filtro = Nothing
        Me.cmb_PrecioInsDes.FormattingEnabled = True
        Me.cmb_PrecioInsDes.Location = New System.Drawing.Point(6, 124)
        Me.cmb_PrecioInsDes.MaxDropDownItems = 20
        Me.cmb_PrecioInsDes.Name = "cmb_PrecioInsDes"
        Me.cmb_PrecioInsDes.Pista = False
        Me.cmb_PrecioInsDes.Size = New System.Drawing.Size(381, 21)
        Me.cmb_PrecioInsDes.StoredProcedure = "Cat_ClientesServicios_GetCombo"
        Me.cmb_PrecioInsDes.Sucursal = False
        Me.cmb_PrecioInsDes.TabIndex = 9
        Me.cmb_PrecioInsDes.Tipo = 0
        Me.cmb_PrecioInsDes.ValueMember = "Id_CS"
        '
        'lbl_PrecioTipoMov
        '
        Me.lbl_PrecioTipoMov.AutoSize = True
        Me.lbl_PrecioTipoMov.Location = New System.Drawing.Point(6, 69)
        Me.lbl_PrecioTipoMov.Name = "lbl_PrecioTipoMov"
        Me.lbl_PrecioTipoMov.Size = New System.Drawing.Size(95, 13)
        Me.lbl_PrecioTipoMov.TabIndex = 5
        Me.lbl_PrecioTipoMov.Text = "Precio del Servicio"
        '
        'cmb_PrecioTipoMov
        '
        Me.cmb_PrecioTipoMov.Clave = ""
        Me.cmb_PrecioTipoMov.Control_Siguiente = Nothing
        Me.cmb_PrecioTipoMov.DisplayMember = "Descripcion"
        Me.cmb_PrecioTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PrecioTipoMov.Empresa = False
        Me.cmb_PrecioTipoMov.Enabled = False
        Me.cmb_PrecioTipoMov.Filtro = Nothing
        Me.cmb_PrecioTipoMov.FormattingEnabled = True
        Me.cmb_PrecioTipoMov.Location = New System.Drawing.Point(6, 84)
        Me.cmb_PrecioTipoMov.MaxDropDownItems = 20
        Me.cmb_PrecioTipoMov.Name = "cmb_PrecioTipoMov"
        Me.cmb_PrecioTipoMov.Pista = False
        Me.cmb_PrecioTipoMov.Size = New System.Drawing.Size(381, 21)
        Me.cmb_PrecioTipoMov.StoredProcedure = "Cat_ClientesServicios_GetCombo"
        Me.cmb_PrecioTipoMov.Sucursal = False
        Me.cmb_PrecioTipoMov.TabIndex = 6
        Me.cmb_PrecioTipoMov.Tipo = 0
        Me.cmb_PrecioTipoMov.ValueMember = "Id_CS"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(51, 19)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Cliente.TabIndex = 1
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.cmb_PrecioTipoMov
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(6, 42)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_GetNoProspectos"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 4
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'frm_CajasFuertesMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 571)
        Me.Controls.Add(Me.gbx_ClienteServicio)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Combinacion)
        Me.Controls.Add(Me.lbl_CajaFuerte)
        Me.Controls.Add(Me.gbx_Instalacion)
        Me.Controls.Add(Me.gbx_Asignacion)
        Me.Controls.Add(Me.gbx_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 600)
        Me.Name = "frm_CajasFuertesMov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_Cita.ResumeLayout(False)
        Me.gbx_Cita.PerformLayout()
        Me.gbx_Asignacion.ResumeLayout(False)
        Me.gbx_Asignacion.PerformLayout()
        Me.gbx_Instalacion.ResumeLayout(False)
        Me.gbx_Instalacion.PerformLayout()
        Me.gbx_Combinacion.ResumeLayout(False)
        Me.gbx_Combinacion.PerformLayout()
        Me.gbx_ClienteServicio.ResumeLayout(False)
        Me.gbx_ClienteServicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lbl_CombActual As System.Windows.Forms.Label
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_AFecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_ACliente As System.Windows.Forms.Label
    Friend WithEvents gbx_Asignacion As System.Windows.Forms.GroupBox
    Friend WithEvents rbn_Combinacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Retiro As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Mantenimiento As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Renta As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Venta As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents gbx_Instalacion As System.Windows.Forms.GroupBox
    Friend WithEvents rbn_Desinstalacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Instalacion As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_CajaFuerte As System.Windows.Forms.Label
    Friend WithEvents rbn_Ninguno As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Reubicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Ambos As System.Windows.Forms.RadioButton
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_GuardarImprimir As System.Windows.Forms.Button
    Friend WithEvents gbx_Combinacion As System.Windows.Forms.GroupBox
    Friend WithEvents rbn_CombinacionNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_CombinacionSi As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_CombActual2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CombActual1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CombActual0 As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents lbl_AContacto As System.Windows.Forms.Label
    Friend WithEvents cmb_Contacto As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_HoraCita As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaCita As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaCita As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraCita As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Cita As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Cita As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Cita As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaRetiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaRetiro As System.Windows.Forms.Label
    Friend WithEvents chk_Retiro As System.Windows.Forms.CheckBox
    Friend WithEvents rbn_ManejoCombinacion As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_PrecioTipoMov As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_ClienteServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_PrecioInsDes As System.Windows.Forms.Label
    Friend WithEvents cmb_PrecioInsDes As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_PrecioTipoMov As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioInsDesA As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioTipoMovA As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioAnteriorInsDes As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioAnteriorServicio As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioAntIndDes As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioAntServicio As System.Windows.Forms.Label
End Class
