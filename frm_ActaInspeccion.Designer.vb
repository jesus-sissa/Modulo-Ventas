<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActaInspeccion
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
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.lbl_2 = New System.Windows.Forms.Label
        Me.lbl_FechaVisita = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_DireccionCliente = New System.Windows.Forms.Label
        Me.lbl_ClienteFiscal = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_5 = New System.Windows.Forms.Label
        Me.dtp_Hora = New System.Windows.Forms.DateTimePicker
        Me.lbl_HoraVisita = New System.Windows.Forms.Label
        Me.tbx_Instrucciones = New Modulo_Ventas.cp_Textbox
        Me.lbl_NotasAdicionales = New System.Windows.Forms.Label
        Me.tbx_NombreC = New Modulo_Ventas.cp_Textbox
        Me.lbl_NombreC = New System.Windows.Forms.Label
        Me.tbx_ClaveClienteFiscal = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_NombreF = New Modulo_Ventas.cp_Textbox
        Me.tbx_DireccionCliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_NombreF = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Red
        Me.lbl_1.Location = New System.Drawing.Point(253, 21)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(13, 17)
        Me.lbl_1.TabIndex = 2
        Me.lbl_1.Text = "*"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.Red
        Me.lbl_2.Location = New System.Drawing.Point(247, 48)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(13, 17)
        Me.lbl_2.TabIndex = 5
        Me.lbl_2.Text = "*"
        '
        'lbl_FechaVisita
        '
        Me.lbl_FechaVisita.AutoSize = True
        Me.lbl_FechaVisita.Location = New System.Drawing.Point(66, 23)
        Me.lbl_FechaVisita.Name = "lbl_FechaVisita"
        Me.lbl_FechaVisita.Size = New System.Drawing.Size(80, 13)
        Me.lbl_FechaVisita.TabIndex = 0
        Me.lbl_FechaVisita.Text = "Fecha de Visita"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(152, 19)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
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
        Me.lbl_DireccionCliente.AutoSize = True
        Me.lbl_DireccionCliente.Location = New System.Drawing.Point(42, 184)
        Me.lbl_DireccionCliente.Name = "lbl_DireccionCliente"
        Me.lbl_DireccionCliente.Size = New System.Drawing.Size(104, 13)
        Me.lbl_DireccionCliente.TabIndex = 13
        Me.lbl_DireccionCliente.Text = "Dirección del Cliente"
        Me.lbl_DireccionCliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ClienteFiscal
        '
        Me.lbl_ClienteFiscal.AutoSize = True
        Me.lbl_ClienteFiscal.Location = New System.Drawing.Point(107, 76)
        Me.lbl_ClienteFiscal.Name = "lbl_ClienteFiscal"
        Me.lbl_ClienteFiscal.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ClienteFiscal.TabIndex = 6
        Me.lbl_ClienteFiscal.Text = "Cliente"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 359)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(661, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(515, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
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
        Me.gbx_Datos.Controls.Add(Me.Label1)
        Me.gbx_Datos.Controls.Add(Me.lbl_5)
        Me.gbx_Datos.Controls.Add(Me.lbl_ClienteFiscal)
        Me.gbx_Datos.Controls.Add(Me.dtp_Hora)
        Me.gbx_Datos.Controls.Add(Me.lbl_HoraVisita)
        Me.gbx_Datos.Controls.Add(Me.tbx_Instrucciones)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_NotasAdicionales)
        Me.gbx_Datos.Controls.Add(Me.lbl_1)
        Me.gbx_Datos.Controls.Add(Me.lbl_DireccionCliente)
        Me.gbx_Datos.Controls.Add(Me.lbl_FechaVisita)
        Me.gbx_Datos.Controls.Add(Me.tbx_NombreC)
        Me.gbx_Datos.Controls.Add(Me.lbl_2)
        Me.gbx_Datos.Controls.Add(Me.lbl_NombreC)
        Me.gbx_Datos.Controls.Add(Me.tbx_ClaveClienteFiscal)
        Me.gbx_Datos.Controls.Add(Me.tbx_NombreF)
        Me.gbx_Datos.Controls.Add(Me.tbx_DireccionCliente)
        Me.gbx_Datos.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Datos.Controls.Add(Me.lbl_NombreF)
        Me.gbx_Datos.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(661, 351)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(626, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "*"
        '
        'lbl_5
        '
        Me.lbl_5.AutoSize = True
        Me.lbl_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_5.ForeColor = System.Drawing.Color.Red
        Me.lbl_5.Location = New System.Drawing.Point(537, 223)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(13, 17)
        Me.lbl_5.TabIndex = 17
        Me.lbl_5.Text = "*"
        '
        'dtp_Hora
        '
        Me.dtp_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_Hora.Location = New System.Drawing.Point(152, 45)
        Me.dtp_Hora.Name = "dtp_Hora"
        Me.dtp_Hora.ShowUpDown = True
        Me.dtp_Hora.Size = New System.Drawing.Size(89, 20)
        Me.dtp_Hora.TabIndex = 4
        '
        'lbl_HoraVisita
        '
        Me.lbl_HoraVisita.AutoSize = True
        Me.lbl_HoraVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraVisita.Location = New System.Drawing.Point(9, 50)
        Me.lbl_HoraVisita.Name = "lbl_HoraVisita"
        Me.lbl_HoraVisita.Size = New System.Drawing.Size(137, 13)
        Me.lbl_HoraVisita.TabIndex = 3
        Me.lbl_HoraVisita.Text = "Hora de Visita (Aproximada)"
        '
        'tbx_Instrucciones
        '
        Me.tbx_Instrucciones.Control_Siguiente = Me.dtp_Fecha
        Me.tbx_Instrucciones.Filtrado = True
        Me.tbx_Instrucciones.Location = New System.Drawing.Point(152, 222)
        Me.tbx_Instrucciones.MaxLength = 300
        Me.tbx_Instrucciones.Multiline = True
        Me.tbx_Instrucciones.Name = "tbx_Instrucciones"
        Me.tbx_Instrucciones.Size = New System.Drawing.Size(379, 118)
        Me.tbx_Instrucciones.TabIndex = 16
        Me.tbx_Instrucciones.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_NotasAdicionales
        '
        Me.lbl_NotasAdicionales.AutoSize = True
        Me.lbl_NotasAdicionales.Location = New System.Drawing.Point(19, 225)
        Me.lbl_NotasAdicionales.Name = "lbl_NotasAdicionales"
        Me.lbl_NotasAdicionales.Size = New System.Drawing.Size(127, 13)
        Me.lbl_NotasAdicionales.TabIndex = 15
        Me.lbl_NotasAdicionales.Text = "Instrucciones Adicionales"
        Me.lbl_NotasAdicionales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbx_NombreC
        '
        Me.tbx_NombreC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreC.Control_Siguiente = Me.dtp_Fecha
        Me.tbx_NombreC.Filtrado = True
        Me.tbx_NombreC.Location = New System.Drawing.Point(152, 140)
        Me.tbx_NombreC.MaxLength = 150
        Me.tbx_NombreC.Multiline = True
        Me.tbx_NombreC.Name = "tbx_NombreC"
        Me.tbx_NombreC.ReadOnly = True
        Me.tbx_NombreC.Size = New System.Drawing.Size(379, 35)
        Me.tbx_NombreC.TabIndex = 12
        Me.tbx_NombreC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_NombreC
        '
        Me.lbl_NombreC.AutoSize = True
        Me.lbl_NombreC.Location = New System.Drawing.Point(53, 143)
        Me.lbl_NombreC.Name = "lbl_NombreC"
        Me.lbl_NombreC.Size = New System.Drawing.Size(93, 13)
        Me.lbl_NombreC.TabIndex = 11
        Me.lbl_NombreC.Text = "Nombre Comercial"
        Me.lbl_NombreC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbx_ClaveClienteFiscal
        '
        Me.tbx_ClaveClienteFiscal.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_ClaveClienteFiscal.Filtrado = True
        Me.tbx_ClaveClienteFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbx_ClaveClienteFiscal.Location = New System.Drawing.Point(152, 73)
        Me.tbx_ClaveClienteFiscal.MaxLength = 12
        Me.tbx_ClaveClienteFiscal.Name = "tbx_ClaveClienteFiscal"
        Me.tbx_ClaveClienteFiscal.Size = New System.Drawing.Size(62, 20)
        Me.tbx_ClaveClienteFiscal.TabIndex = 7
        Me.tbx_ClaveClienteFiscal.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.btn_Guardar
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_ClaveClienteFiscal
        Me.cmb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(220, 73)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 8
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_NombreF
        '
        Me.tbx_NombreF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreF.Control_Siguiente = Me.dtp_Fecha
        Me.tbx_NombreF.Filtrado = True
        Me.tbx_NombreF.Location = New System.Drawing.Point(152, 99)
        Me.tbx_NombreF.MaxLength = 150
        Me.tbx_NombreF.Multiline = True
        Me.tbx_NombreF.Name = "tbx_NombreF"
        Me.tbx_NombreF.ReadOnly = True
        Me.tbx_NombreF.Size = New System.Drawing.Size(379, 35)
        Me.tbx_NombreF.TabIndex = 10
        Me.tbx_NombreF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_DireccionCliente
        '
        Me.tbx_DireccionCliente.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DireccionCliente.Control_Siguiente = Nothing
        Me.tbx_DireccionCliente.Filtrado = True
        Me.tbx_DireccionCliente.Location = New System.Drawing.Point(152, 181)
        Me.tbx_DireccionCliente.MaxLength = 200
        Me.tbx_DireccionCliente.Multiline = True
        Me.tbx_DireccionCliente.Name = "tbx_DireccionCliente"
        Me.tbx_DireccionCliente.ReadOnly = True
        Me.tbx_DireccionCliente.Size = New System.Drawing.Size(379, 35)
        Me.tbx_DireccionCliente.TabIndex = 14
        Me.tbx_DireccionCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_NombreF
        '
        Me.lbl_NombreF.AutoSize = True
        Me.lbl_NombreF.Location = New System.Drawing.Point(72, 102)
        Me.lbl_NombreF.Name = "lbl_NombreF"
        Me.lbl_NombreF.Size = New System.Drawing.Size(74, 13)
        Me.lbl_NombreF.TabIndex = 9
        Me.lbl_NombreF.Text = "Nombre Fiscal"
        Me.lbl_NombreF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frm_ActaInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 421)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(680, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(680, 450)
        Me.Name = "frm_ActaInspeccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acta de Inspección para Instalación de Caja Fuerte"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_ClienteFiscal As System.Windows.Forms.Label
    Friend WithEvents lbl_DireccionCliente As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaVisita As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraVisita As System.Windows.Forms.Label
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveClienteFiscal As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_DireccionCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Instrucciones As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NotasAdicionales As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreF As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NombreF As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NombreC As System.Windows.Forms.Label
    Friend WithEvents lbl_5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
