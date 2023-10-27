<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cita))
        Me.lbl_Asunto = New System.Windows.Forms.Label
        Me.gbx_DatosCita = New System.Windows.Forms.GroupBox
        Me.cbx_SoloEditar = New System.Windows.Forms.CheckBox
        Me.tbx_Descripcion = New Modulo_Ventas.cp_Textbox
        Me.cmb_EmpleadoVentas = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_EjecutivoVentas = New System.Windows.Forms.Label
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.tbx_Asunto = New Modulo_Ventas.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_DatosActualizarCita = New System.Windows.Forms.GroupBox
        Me.tbx_Comentarios = New Modulo_Ventas.cp_Textbox
        Me.cmb_HoraNueva = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_EjecutivoReasignar = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_EjecutivoReasignar = New System.Windows.Forms.Label
        Me.dtp_FechaProxima = New System.Windows.Forms.DateTimePicker
        Me.lbl_Comentario = New System.Windows.Forms.Label
        Me.lbl_HoraNueva = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_FechaProxima = New System.Windows.Forms.Label
        Me.gbx_Accion = New System.Windows.Forms.GroupBox
        Me.rdb_Reasignar = New System.Windows.Forms.RadioButton
        Me.rdb_Cancelar = New System.Windows.Forms.RadioButton
        Me.rdb_Posponer = New System.Windows.Forms.RadioButton
        Me.rdb_Finalizar = New System.Windows.Forms.RadioButton
        Me.gbx_DatosCita.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_DatosActualizarCita.SuspendLayout()
        Me.gbx_Accion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Asunto
        '
        Me.lbl_Asunto.AutoSize = True
        Me.lbl_Asunto.Location = New System.Drawing.Point(53, 49)
        Me.lbl_Asunto.Name = "lbl_Asunto"
        Me.lbl_Asunto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Asunto.TabIndex = 2
        Me.lbl_Asunto.Text = "Asunto"
        '
        'gbx_DatosCita
        '
        Me.gbx_DatosCita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosCita.Controls.Add(Me.cbx_SoloEditar)
        Me.gbx_DatosCita.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_DatosCita.Controls.Add(Me.cmb_EmpleadoVentas)
        Me.gbx_DatosCita.Controls.Add(Me.lbl_EjecutivoVentas)
        Me.gbx_DatosCita.Controls.Add(Me.lbl_Descripcion)
        Me.gbx_DatosCita.Controls.Add(Me.lbl_Asunto)
        Me.gbx_DatosCita.Controls.Add(Me.tbx_Asunto)
        Me.gbx_DatosCita.Location = New System.Drawing.Point(7, 6)
        Me.gbx_DatosCita.Name = "gbx_DatosCita"
        Me.gbx_DatosCita.Size = New System.Drawing.Size(530, 211)
        Me.gbx_DatosCita.TabIndex = 0
        Me.gbx_DatosCita.TabStop = False
        '
        'cbx_SoloEditar
        '
        Me.cbx_SoloEditar.AutoSize = True
        Me.cbx_SoloEditar.Checked = True
        Me.cbx_SoloEditar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_SoloEditar.Location = New System.Drawing.Point(99, 182)
        Me.cbx_SoloEditar.Name = "cbx_SoloEditar"
        Me.cbx_SoloEditar.Size = New System.Drawing.Size(76, 17)
        Me.cbx_SoloEditar.TabIndex = 6
        Me.cbx_SoloEditar.Text = "Solo editar"
        Me.cbx_SoloEditar.UseVisualStyleBackColor = True
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(99, 72)
        Me.tbx_Descripcion.MaxLength = 250
        Me.tbx_Descripcion.Multiline = True
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(415, 104)
        Me.tbx_Descripcion.TabIndex = 5
        Me.tbx_Descripcion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_EmpleadoVentas
        '
        Me.cmb_EmpleadoVentas.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_EmpleadoVentas.Clave = Nothing
        Me.cmb_EmpleadoVentas.Control_Siguiente = Nothing
        Me.cmb_EmpleadoVentas.DisplayMember = "Nombre"
        Me.cmb_EmpleadoVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EmpleadoVentas.Empresa = False
        Me.cmb_EmpleadoVentas.Filtro = Nothing
        Me.cmb_EmpleadoVentas.FormattingEnabled = True
        Me.cmb_EmpleadoVentas.Location = New System.Drawing.Point(99, 19)
        Me.cmb_EmpleadoVentas.MaxDropDownItems = 20
        Me.cmb_EmpleadoVentas.Name = "cmb_EmpleadoVentas"
        Me.cmb_EmpleadoVentas.Pista = False
        Me.cmb_EmpleadoVentas.Size = New System.Drawing.Size(415, 21)
        Me.cmb_EmpleadoVentas.StoredProcedure = "Cat_Empleados_Ventas"
        Me.cmb_EmpleadoVentas.Sucursal = True
        Me.cmb_EmpleadoVentas.TabIndex = 1
        Me.cmb_EmpleadoVentas.Tipo = 0
        Me.cmb_EmpleadoVentas.ValueMember = "Id_Empleado"
        '
        'lbl_EjecutivoVentas
        '
        Me.lbl_EjecutivoVentas.AutoSize = True
        Me.lbl_EjecutivoVentas.Location = New System.Drawing.Point(6, 22)
        Me.lbl_EjecutivoVentas.Name = "lbl_EjecutivoVentas"
        Me.lbl_EjecutivoVentas.Size = New System.Drawing.Size(87, 13)
        Me.lbl_EjecutivoVentas.TabIndex = 0
        Me.lbl_EjecutivoVentas.Text = "Ejecutivo Ventas"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(30, 75)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 4
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'tbx_Asunto
        '
        Me.tbx_Asunto.Control_Siguiente = Nothing
        Me.tbx_Asunto.Filtrado = True
        Me.tbx_Asunto.Location = New System.Drawing.Point(99, 46)
        Me.tbx_Asunto.MaxLength = 50
        Me.tbx_Asunto.Name = "tbx_Asunto"
        Me.tbx_Asunto.Size = New System.Drawing.Size(415, 20)
        Me.tbx_Asunto.TabIndex = 3
        Me.tbx_Asunto.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 395)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(530, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(384, 14)
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
        'gbx_DatosActualizarCita
        '
        Me.gbx_DatosActualizarCita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.tbx_Comentarios)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.cmb_HoraNueva)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.cmb_EjecutivoReasignar)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.lbl_EjecutivoReasignar)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.dtp_FechaProxima)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.lbl_Comentario)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.lbl_HoraNueva)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.lbl_Fecha)
        Me.gbx_DatosActualizarCita.Controls.Add(Me.lbl_FechaProxima)
        Me.gbx_DatosActualizarCita.Location = New System.Drawing.Point(106, 223)
        Me.gbx_DatosActualizarCita.Name = "gbx_DatosActualizarCita"
        Me.gbx_DatosActualizarCita.Size = New System.Drawing.Size(431, 166)
        Me.gbx_DatosActualizarCita.TabIndex = 2
        Me.gbx_DatosActualizarCita.TabStop = False
        '
        'tbx_Comentarios
        '
        Me.tbx_Comentarios.Control_Siguiente = Nothing
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(99, 46)
        Me.tbx_Comentarios.MaxLength = 250
        Me.tbx_Comentarios.Multiline = True
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(316, 72)
        Me.tbx_Comentarios.TabIndex = 5
        Me.tbx_Comentarios.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_HoraNueva
        '
        Me.cmb_HoraNueva.Control_Siguiente = Nothing
        Me.cmb_HoraNueva.DisplayMember = "display"
        Me.cmb_HoraNueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HoraNueva.Enabled = False
        Me.cmb_HoraNueva.FormattingEnabled = True
        Me.cmb_HoraNueva.Location = New System.Drawing.Point(304, 19)
        Me.cmb_HoraNueva.MaxDropDownItems = 20
        Me.cmb_HoraNueva.Name = "cmb_HoraNueva"
        Me.cmb_HoraNueva.Size = New System.Drawing.Size(111, 21)
        Me.cmb_HoraNueva.TabIndex = 9
        Me.cmb_HoraNueva.ValueMember = "value"
        '
        'cmb_EjecutivoReasignar
        '
        Me.cmb_EjecutivoReasignar.Clave = Nothing
        Me.cmb_EjecutivoReasignar.Control_Siguiente = Nothing
        Me.cmb_EjecutivoReasignar.DisplayMember = "Nombre"
        Me.cmb_EjecutivoReasignar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EjecutivoReasignar.Empresa = False
        Me.cmb_EjecutivoReasignar.Enabled = False
        Me.cmb_EjecutivoReasignar.Filtro = Nothing
        Me.cmb_EjecutivoReasignar.FormattingEnabled = True
        Me.cmb_EjecutivoReasignar.Location = New System.Drawing.Point(99, 124)
        Me.cmb_EjecutivoReasignar.MaxDropDownItems = 20
        Me.cmb_EjecutivoReasignar.Name = "cmb_EjecutivoReasignar"
        Me.cmb_EjecutivoReasignar.Pista = False
        Me.cmb_EjecutivoReasignar.Size = New System.Drawing.Size(316, 21)
        Me.cmb_EjecutivoReasignar.StoredProcedure = "Cat_Empleados_Ventas"
        Me.cmb_EjecutivoReasignar.Sucursal = True
        Me.cmb_EjecutivoReasignar.TabIndex = 1
        Me.cmb_EjecutivoReasignar.Tipo = 0
        Me.cmb_EjecutivoReasignar.ValueMember = "Id_Empleado"
        '
        'lbl_EjecutivoReasignar
        '
        Me.lbl_EjecutivoReasignar.AutoSize = True
        Me.lbl_EjecutivoReasignar.Enabled = False
        Me.lbl_EjecutivoReasignar.Location = New System.Drawing.Point(6, 127)
        Me.lbl_EjecutivoReasignar.Name = "lbl_EjecutivoReasignar"
        Me.lbl_EjecutivoReasignar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_EjecutivoReasignar.TabIndex = 0
        Me.lbl_EjecutivoReasignar.Text = "Ejecutivo Ventas"
        '
        'dtp_FechaProxima
        '
        Me.dtp_FechaProxima.CustomFormat = "dddd dd/MM/yyyy"
        Me.dtp_FechaProxima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaProxima.Location = New System.Drawing.Point(99, 20)
        Me.dtp_FechaProxima.Name = "dtp_FechaProxima"
        Me.dtp_FechaProxima.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaProxima.TabIndex = 8
        '
        'lbl_Comentario
        '
        Me.lbl_Comentario.AutoSize = True
        Me.lbl_Comentario.Location = New System.Drawing.Point(28, 49)
        Me.lbl_Comentario.Name = "lbl_Comentario"
        Me.lbl_Comentario.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Comentario.TabIndex = 4
        Me.lbl_Comentario.Text = "Comentarios"
        '
        'lbl_HoraNueva
        '
        Me.lbl_HoraNueva.AutoSize = True
        Me.lbl_HoraNueva.Enabled = False
        Me.lbl_HoraNueva.Location = New System.Drawing.Point(268, 24)
        Me.lbl_HoraNueva.Name = "lbl_HoraNueva"
        Me.lbl_HoraNueva.Size = New System.Drawing.Size(30, 13)
        Me.lbl_HoraNueva.TabIndex = 2
        Me.lbl_HoraNueva.Text = "Hora"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(56, 24)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 2
        Me.lbl_Fecha.Text = "Fecha"
        '
        'lbl_FechaProxima
        '
        Me.lbl_FechaProxima.AutoSize = True
        Me.lbl_FechaProxima.Location = New System.Drawing.Point(16, 24)
        Me.lbl_FechaProxima.Name = "lbl_FechaProxima"
        Me.lbl_FechaProxima.Size = New System.Drawing.Size(77, 13)
        Me.lbl_FechaProxima.TabIndex = 2
        Me.lbl_FechaProxima.Text = "Fecha Próxima"
        Me.lbl_FechaProxima.Visible = False
        '
        'gbx_Accion
        '
        Me.gbx_Accion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Accion.Controls.Add(Me.rdb_Reasignar)
        Me.gbx_Accion.Controls.Add(Me.rdb_Cancelar)
        Me.gbx_Accion.Controls.Add(Me.rdb_Posponer)
        Me.gbx_Accion.Controls.Add(Me.rdb_Finalizar)
        Me.gbx_Accion.Location = New System.Drawing.Point(7, 223)
        Me.gbx_Accion.Name = "gbx_Accion"
        Me.gbx_Accion.Size = New System.Drawing.Size(93, 166)
        Me.gbx_Accion.TabIndex = 4
        Me.gbx_Accion.TabStop = False
        '
        'rdb_Reasignar
        '
        Me.rdb_Reasignar.AutoSize = True
        Me.rdb_Reasignar.Location = New System.Drawing.Point(10, 91)
        Me.rdb_Reasignar.Name = "rdb_Reasignar"
        Me.rdb_Reasignar.Size = New System.Drawing.Size(73, 17)
        Me.rdb_Reasignar.TabIndex = 9
        Me.rdb_Reasignar.Text = "Reasignar"
        Me.rdb_Reasignar.UseVisualStyleBackColor = True
        '
        'rdb_Cancelar
        '
        Me.rdb_Cancelar.AutoSize = True
        Me.rdb_Cancelar.Location = New System.Drawing.Point(10, 68)
        Me.rdb_Cancelar.Name = "rdb_Cancelar"
        Me.rdb_Cancelar.Size = New System.Drawing.Size(67, 17)
        Me.rdb_Cancelar.TabIndex = 9
        Me.rdb_Cancelar.Text = "Cancelar"
        Me.rdb_Cancelar.UseVisualStyleBackColor = True
        '
        'rdb_Posponer
        '
        Me.rdb_Posponer.AutoSize = True
        Me.rdb_Posponer.Location = New System.Drawing.Point(10, 45)
        Me.rdb_Posponer.Name = "rdb_Posponer"
        Me.rdb_Posponer.Size = New System.Drawing.Size(70, 17)
        Me.rdb_Posponer.TabIndex = 9
        Me.rdb_Posponer.Text = "Posponer"
        Me.rdb_Posponer.UseVisualStyleBackColor = True
        '
        'rdb_Finalizar
        '
        Me.rdb_Finalizar.AutoSize = True
        Me.rdb_Finalizar.Checked = True
        Me.rdb_Finalizar.Location = New System.Drawing.Point(10, 22)
        Me.rdb_Finalizar.Name = "rdb_Finalizar"
        Me.rdb_Finalizar.Size = New System.Drawing.Size(63, 17)
        Me.rdb_Finalizar.TabIndex = 9
        Me.rdb_Finalizar.TabStop = True
        Me.rdb_Finalizar.Text = "Finalizar"
        Me.rdb_Finalizar.UseVisualStyleBackColor = True
        '
        'frm_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 451)
        Me.Controls.Add(Me.gbx_Accion)
        Me.Controls.Add(Me.gbx_DatosActualizarCita)
        Me.Controls.Add(Me.gbx_DatosCita)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 480)
        Me.Name = "frm_Cita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cita"
        Me.gbx_DatosCita.ResumeLayout(False)
        Me.gbx_DatosCita.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_DatosActualizarCita.ResumeLayout(False)
        Me.gbx_DatosActualizarCita.PerformLayout()
        Me.gbx_Accion.ResumeLayout(False)
        Me.gbx_Accion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Asunto As System.Windows.Forms.Label
    Friend WithEvents tbx_Asunto As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_DatosCita As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_EjecutivoVentas As System.Windows.Forms.Label
    Friend WithEvents cmb_EmpleadoVentas As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents gbx_DatosActualizarCita As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Accion As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaProxima As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Comentario As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents cmb_EjecutivoReasignar As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_EjecutivoReasignar As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaProxima As System.Windows.Forms.Label
    Friend WithEvents rdb_Reasignar As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Cancelar As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Posponer As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Finalizar As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Descripcion As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_HoraNueva As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_HoraNueva As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentarios As Modulo_Ventas.cp_Textbox
    Friend WithEvents cbx_SoloEditar As System.Windows.Forms.CheckBox
End Class
