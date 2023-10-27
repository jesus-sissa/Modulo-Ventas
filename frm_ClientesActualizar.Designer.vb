<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesActualizar
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
        Me.chk_Fiscales = New System.Windows.Forms.CheckBox
        Me.gbx_DatosF = New System.Windows.Forms.GroupBox
        Me.lbl_A12 = New System.Windows.Forms.Label
        Me.lbl_A11 = New System.Windows.Forms.Label
        Me.lbl_A8 = New System.Windows.Forms.Label
        Me.lbl_A7 = New System.Windows.Forms.Label
        Me.lbl_A6 = New System.Windows.Forms.Label
        Me.lbl_A5 = New System.Windows.Forms.Label
        Me.lbl_A3 = New System.Windows.Forms.Label
        Me.lbl_A2 = New System.Windows.Forms.Label
        Me.lbl_A1 = New System.Windows.Forms.Label
        Me.dtp_Inicio = New System.Windows.Forms.DateTimePicker
        Me.lbl_Inicio = New System.Windows.Forms.Label
        Me.lbl_ClvFactN = New System.Windows.Forms.Label
        Me.lbl_ClvFactAnt = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.lbl_EntreF2 = New System.Windows.Forms.Label
        Me.lbl_EntreF1 = New System.Windows.Forms.Label
        Me.lbl_CPF = New System.Windows.Forms.Label
        Me.lbl_ColoniaF = New System.Windows.Forms.Label
        Me.lbl_IntF = New System.Windows.Forms.Label
        Me.lbl_NumeroF = New System.Windows.Forms.Label
        Me.lbl_RFC = New System.Windows.Forms.Label
        Me.lbl_ZonaF = New System.Windows.Forms.Label
        Me.lbl_CiudadF = New System.Windows.Forms.Label
        Me.lbl_EstadoF = New System.Windows.Forms.Label
        Me.lbl_PaisF = New System.Windows.Forms.Label
        Me.lbl_CalleF = New System.Windows.Forms.Label
        Me.lbl_NombreF = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Nombre = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_NombreF = New Modulo_Ventas.cp_Textbox
        Me.tbx_RFC = New Modulo_Ventas.cp_Textbox
        Me.tbx_CalleF = New Modulo_Ventas.cp_Textbox
        Me.tbx_EntreF1 = New Modulo_Ventas.cp_Textbox
        Me.tbx_EntreF2 = New Modulo_Ventas.cp_Textbox
        Me.tbx_NumeroF = New Modulo_Ventas.cp_Textbox
        Me.tbx_IntF = New Modulo_Ventas.cp_Textbox
        Me.tbx_ColoniaF = New Modulo_Ventas.cp_Textbox
        Me.tbx_CPF = New Modulo_Ventas.cp_Textbox
        Me.cmb_PaisF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_EstadoF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_CiudadF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_ZonaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClvFactN = New Modulo_Ventas.cp_Textbox
        Me.tbx_ClvFactAnt = New Modulo_Ventas.cp_Textbox
        Me.gbx_DatosF.SuspendLayout()
        Me.gbx_Nombre.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_Fiscales
        '
        Me.chk_Fiscales.AutoSize = True
        Me.chk_Fiscales.Enabled = False
        Me.chk_Fiscales.Location = New System.Drawing.Point(90, 332)
        Me.chk_Fiscales.Name = "chk_Fiscales"
        Me.chk_Fiscales.Size = New System.Drawing.Size(255, 17)
        Me.chk_Fiscales.TabIndex = 48
        Me.chk_Fiscales.Text = "Afectar también Datos Fiscales a los Subclientes"
        Me.chk_Fiscales.UseVisualStyleBackColor = True
        '
        'gbx_DatosF
        '
        Me.gbx_DatosF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A12)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A11)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A8)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A7)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A6)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A5)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A3)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A2)
        Me.gbx_DatosF.Controls.Add(Me.lbl_A1)
        Me.gbx_DatosF.Controls.Add(Me.dtp_Inicio)
        Me.gbx_DatosF.Controls.Add(Me.lbl_Inicio)
        Me.gbx_DatosF.Controls.Add(Me.lbl_ClvFactN)
        Me.gbx_DatosF.Controls.Add(Me.lbl_ClvFactAnt)
        Me.gbx_DatosF.Controls.Add(Me.tbx_ClvFactN)
        Me.gbx_DatosF.Controls.Add(Me.tbx_ClvFactAnt)
        Me.gbx_DatosF.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_DatosF.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_DatosF.Controls.Add(Me.lbl_EntreF2)
        Me.gbx_DatosF.Controls.Add(Me.lbl_EntreF1)
        Me.gbx_DatosF.Controls.Add(Me.tbx_EntreF2)
        Me.gbx_DatosF.Controls.Add(Me.tbx_EntreF1)
        Me.gbx_DatosF.Controls.Add(Me.chk_Fiscales)
        Me.gbx_DatosF.Controls.Add(Me.tbx_CPF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_CPF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_ColoniaF)
        Me.gbx_DatosF.Controls.Add(Me.tbx_ColoniaF)
        Me.gbx_DatosF.Controls.Add(Me.tbx_IntF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_IntF)
        Me.gbx_DatosF.Controls.Add(Me.tbx_NumeroF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_NumeroF)
        Me.gbx_DatosF.Controls.Add(Me.cmb_ZonaF)
        Me.gbx_DatosF.Controls.Add(Me.cmb_CiudadF)
        Me.gbx_DatosF.Controls.Add(Me.cmb_EstadoF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_RFC)
        Me.gbx_DatosF.Controls.Add(Me.tbx_RFC)
        Me.gbx_DatosF.Controls.Add(Me.lbl_ZonaF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_CiudadF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_EstadoF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_PaisF)
        Me.gbx_DatosF.Controls.Add(Me.cmb_PaisF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_CalleF)
        Me.gbx_DatosF.Controls.Add(Me.tbx_CalleF)
        Me.gbx_DatosF.Controls.Add(Me.lbl_NombreF)
        Me.gbx_DatosF.Controls.Add(Me.tbx_NombreF)
        Me.gbx_DatosF.Location = New System.Drawing.Point(8, 60)
        Me.gbx_DatosF.Name = "gbx_DatosF"
        Me.gbx_DatosF.Size = New System.Drawing.Size(658, 353)
        Me.gbx_DatosF.TabIndex = 1
        Me.gbx_DatosF.TabStop = False
        Me.gbx_DatosF.Text = "Datos Fiscales"
        '
        'lbl_A12
        '
        Me.lbl_A12.AutoSize = True
        Me.lbl_A12.ForeColor = System.Drawing.Color.Red
        Me.lbl_A12.Location = New System.Drawing.Point(644, 283)
        Me.lbl_A12.Name = "lbl_A12"
        Me.lbl_A12.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A12.TabIndex = 47
        Me.lbl_A12.Text = "*"
        '
        'lbl_A11
        '
        Me.lbl_A11.AutoSize = True
        Me.lbl_A11.ForeColor = System.Drawing.Color.Red
        Me.lbl_A11.Location = New System.Drawing.Point(355, 257)
        Me.lbl_A11.Name = "lbl_A11"
        Me.lbl_A11.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A11.TabIndex = 44
        Me.lbl_A11.Text = "*"
        '
        'lbl_A8
        '
        Me.lbl_A8.AutoSize = True
        Me.lbl_A8.ForeColor = System.Drawing.Color.Red
        Me.lbl_A8.Location = New System.Drawing.Point(644, 178)
        Me.lbl_A8.Name = "lbl_A8"
        Me.lbl_A8.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A8.TabIndex = 35
        Me.lbl_A8.Text = "*"
        '
        'lbl_A7
        '
        Me.lbl_A7.AutoSize = True
        Me.lbl_A7.ForeColor = System.Drawing.Color.Red
        Me.lbl_A7.Location = New System.Drawing.Point(333, 178)
        Me.lbl_A7.Name = "lbl_A7"
        Me.lbl_A7.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A7.TabIndex = 32
        Me.lbl_A7.Text = "*"
        '
        'lbl_A6
        '
        Me.lbl_A6.AutoSize = True
        Me.lbl_A6.ForeColor = System.Drawing.Color.Red
        Me.lbl_A6.Location = New System.Drawing.Point(644, 151)
        Me.lbl_A6.Name = "lbl_A6"
        Me.lbl_A6.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A6.TabIndex = 29
        Me.lbl_A6.Text = "*"
        '
        'lbl_A5
        '
        Me.lbl_A5.AutoSize = True
        Me.lbl_A5.ForeColor = System.Drawing.Color.Red
        Me.lbl_A5.Location = New System.Drawing.Point(333, 151)
        Me.lbl_A5.Name = "lbl_A5"
        Me.lbl_A5.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A5.TabIndex = 26
        Me.lbl_A5.Text = "*"
        '
        'lbl_A3
        '
        Me.lbl_A3.AutoSize = True
        Me.lbl_A3.ForeColor = System.Drawing.Color.Red
        Me.lbl_A3.Location = New System.Drawing.Point(333, 73)
        Me.lbl_A3.Name = "lbl_A3"
        Me.lbl_A3.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A3.TabIndex = 10
        Me.lbl_A3.Text = "*"
        '
        'lbl_A2
        '
        Me.lbl_A2.AutoSize = True
        Me.lbl_A2.ForeColor = System.Drawing.Color.Red
        Me.lbl_A2.Location = New System.Drawing.Point(206, 47)
        Me.lbl_A2.Name = "lbl_A2"
        Me.lbl_A2.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A2.TabIndex = 7
        Me.lbl_A2.Text = "*"
        '
        'lbl_A1
        '
        Me.lbl_A1.AutoSize = True
        Me.lbl_A1.ForeColor = System.Drawing.Color.Red
        Me.lbl_A1.Location = New System.Drawing.Point(644, 21)
        Me.lbl_A1.Name = "lbl_A1"
        Me.lbl_A1.Size = New System.Drawing.Size(11, 13)
        Me.lbl_A1.TabIndex = 2
        Me.lbl_A1.Text = "*"
        '
        'dtp_Inicio
        '
        Me.dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Inicio.Location = New System.Drawing.Point(254, 254)
        Me.dtp_Inicio.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Inicio.Name = "dtp_Inicio"
        Me.dtp_Inicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Inicio.TabIndex = 43
        '
        'lbl_Inicio
        '
        Me.lbl_Inicio.AutoSize = True
        Me.lbl_Inicio.Location = New System.Drawing.Point(87, 257)
        Me.lbl_Inicio.Name = "lbl_Inicio"
        Me.lbl_Inicio.Size = New System.Drawing.Size(161, 13)
        Me.lbl_Inicio.TabIndex = 42
        Me.lbl_Inicio.Text = "Fecha para Realizar los Cambios"
        '
        'lbl_ClvFactN
        '
        Me.lbl_ClvFactN.AutoSize = True
        Me.lbl_ClvFactN.Location = New System.Drawing.Point(120, 231)
        Me.lbl_ClvFactN.Name = "lbl_ClvFactN"
        Me.lbl_ClvFactN.Size = New System.Drawing.Size(128, 13)
        Me.lbl_ClvFactN.TabIndex = 39
        Me.lbl_ClvFactN.Text = "Clave Facturación Nueva"
        '
        'lbl_ClvFactAnt
        '
        Me.lbl_ClvFactAnt.AutoSize = True
        Me.lbl_ClvFactAnt.Location = New System.Drawing.Point(116, 205)
        Me.lbl_ClvFactAnt.Name = "lbl_ClvFactAnt"
        Me.lbl_ClvFactAnt.Size = New System.Drawing.Size(132, 13)
        Me.lbl_ClvFactAnt.TabIndex = 36
        Me.lbl_ClvFactAnt.Text = "Clave Facturación Anterior"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(6, 283)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 45
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(90, 280)
        Me.rtb_Observaciones.MaxLength = 3000
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(548, 46)
        Me.rtb_Observaciones.TabIndex = 46
        Me.rtb_Observaciones.Text = ""
        '
        'lbl_EntreF2
        '
        Me.lbl_EntreF2.AutoSize = True
        Me.lbl_EntreF2.Location = New System.Drawing.Point(381, 99)
        Me.lbl_EntreF2.Name = "lbl_EntreF2"
        Me.lbl_EntreF2.Size = New System.Drawing.Size(14, 13)
        Me.lbl_EntreF2.TabIndex = 17
        Me.lbl_EntreF2.Text = "Y"
        '
        'lbl_EntreF1
        '
        Me.lbl_EntreF1.AutoSize = True
        Me.lbl_EntreF1.Location = New System.Drawing.Point(52, 99)
        Me.lbl_EntreF1.Name = "lbl_EntreF1"
        Me.lbl_EntreF1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_EntreF1.TabIndex = 15
        Me.lbl_EntreF1.Text = "Entre"
        '
        'lbl_CPF
        '
        Me.lbl_CPF.AutoSize = True
        Me.lbl_CPF.Location = New System.Drawing.Point(374, 125)
        Me.lbl_CPF.Name = "lbl_CPF"
        Me.lbl_CPF.Size = New System.Drawing.Size(21, 13)
        Me.lbl_CPF.TabIndex = 22
        Me.lbl_CPF.Text = "CP"
        '
        'lbl_ColoniaF
        '
        Me.lbl_ColoniaF.AutoSize = True
        Me.lbl_ColoniaF.Location = New System.Drawing.Point(42, 125)
        Me.lbl_ColoniaF.Name = "lbl_ColoniaF"
        Me.lbl_ColoniaF.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ColoniaF.TabIndex = 19
        Me.lbl_ColoniaF.Text = "Colonia"
        '
        'lbl_IntF
        '
        Me.lbl_IntF.AutoSize = True
        Me.lbl_IntF.Location = New System.Drawing.Point(472, 73)
        Me.lbl_IntF.Name = "lbl_IntF"
        Me.lbl_IntF.Size = New System.Drawing.Size(39, 13)
        Me.lbl_IntF.TabIndex = 13
        Me.lbl_IntF.Text = "Interior"
        '
        'lbl_NumeroF
        '
        Me.lbl_NumeroF.AutoSize = True
        Me.lbl_NumeroF.Location = New System.Drawing.Point(350, 73)
        Me.lbl_NumeroF.Name = "lbl_NumeroF"
        Me.lbl_NumeroF.Size = New System.Drawing.Size(45, 13)
        Me.lbl_NumeroF.TabIndex = 11
        Me.lbl_NumeroF.Text = "No. Ext."
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(56, 47)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(28, 13)
        Me.lbl_RFC.TabIndex = 5
        Me.lbl_RFC.Text = "RFC"
        '
        'lbl_ZonaF
        '
        Me.lbl_ZonaF.AutoSize = True
        Me.lbl_ZonaF.Location = New System.Drawing.Point(363, 178)
        Me.lbl_ZonaF.Name = "lbl_ZonaF"
        Me.lbl_ZonaF.Size = New System.Drawing.Size(32, 13)
        Me.lbl_ZonaF.TabIndex = 33
        Me.lbl_ZonaF.Text = "Zona"
        '
        'lbl_CiudadF
        '
        Me.lbl_CiudadF.AutoSize = True
        Me.lbl_CiudadF.Location = New System.Drawing.Point(44, 178)
        Me.lbl_CiudadF.Name = "lbl_CiudadF"
        Me.lbl_CiudadF.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CiudadF.TabIndex = 30
        Me.lbl_CiudadF.Text = "Ciudad"
        '
        'lbl_EstadoF
        '
        Me.lbl_EstadoF.AutoSize = True
        Me.lbl_EstadoF.Location = New System.Drawing.Point(355, 151)
        Me.lbl_EstadoF.Name = "lbl_EstadoF"
        Me.lbl_EstadoF.Size = New System.Drawing.Size(40, 13)
        Me.lbl_EstadoF.TabIndex = 27
        Me.lbl_EstadoF.Text = "Estado"
        '
        'lbl_PaisF
        '
        Me.lbl_PaisF.AutoSize = True
        Me.lbl_PaisF.Location = New System.Drawing.Point(55, 151)
        Me.lbl_PaisF.Name = "lbl_PaisF"
        Me.lbl_PaisF.Size = New System.Drawing.Size(29, 13)
        Me.lbl_PaisF.TabIndex = 24
        Me.lbl_PaisF.Text = "País"
        '
        'lbl_CalleF
        '
        Me.lbl_CalleF.AutoSize = True
        Me.lbl_CalleF.Location = New System.Drawing.Point(54, 73)
        Me.lbl_CalleF.Name = "lbl_CalleF"
        Me.lbl_CalleF.Size = New System.Drawing.Size(30, 13)
        Me.lbl_CalleF.TabIndex = 8
        Me.lbl_CalleF.Text = "Calle"
        '
        'lbl_NombreF
        '
        Me.lbl_NombreF.AutoSize = True
        Me.lbl_NombreF.Location = New System.Drawing.Point(40, 21)
        Me.lbl_NombreF.Name = "lbl_NombreF"
        Me.lbl_NombreF.Size = New System.Drawing.Size(44, 13)
        Me.lbl_NombreF.TabIndex = 0
        Me.lbl_NombreF.Text = "Nombre"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
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
        'gbx_Nombre
        '
        Me.gbx_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Nombre.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Nombre.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Nombre.Controls.Add(Me.btn_Buscar)
        Me.gbx_Nombre.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Nombre.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Nombre.Name = "gbx_Nombre"
        Me.gbx_Nombre.Size = New System.Drawing.Size(658, 52)
        Me.gbx_Nombre.TabIndex = 0
        Me.gbx_Nombre.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(571, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(30, 23)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(6, 21)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente Padre"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(512, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 419)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(658, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(82, 19)
        Me.tbx_Cliente.MaxLength = 12
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(77, 20)
        Me.tbx_Cliente.TabIndex = 1
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.tbx_NombreF
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(165, 18)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 2
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_NombreF
        '
        Me.tbx_NombreF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreF.Control_Siguiente = Me.tbx_RFC
        Me.tbx_NombreF.Filtrado = True
        Me.tbx_NombreF.Location = New System.Drawing.Point(90, 18)
        Me.tbx_NombreF.MaxLength = 150
        Me.tbx_NombreF.Name = "tbx_NombreF"
        Me.tbx_NombreF.Size = New System.Drawing.Size(548, 20)
        Me.tbx_NombreF.TabIndex = 1
        Me.tbx_NombreF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_RFC
        '
        Me.tbx_RFC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_RFC.Control_Siguiente = Me.tbx_CalleF
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(90, 44)
        Me.tbx_RFC.MaxLength = 13
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.Size = New System.Drawing.Size(110, 20)
        Me.tbx_RFC.TabIndex = 6
        Me.tbx_RFC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CalleF
        '
        Me.tbx_CalleF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CalleF.Control_Siguiente = Me.tbx_EntreF1
        Me.tbx_CalleF.Filtrado = True
        Me.tbx_CalleF.Location = New System.Drawing.Point(90, 70)
        Me.tbx_CalleF.MaxLength = 100
        Me.tbx_CalleF.Name = "tbx_CalleF"
        Me.tbx_CalleF.Size = New System.Drawing.Size(237, 20)
        Me.tbx_CalleF.TabIndex = 9
        Me.tbx_CalleF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreF1
        '
        Me.tbx_EntreF1.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EntreF1.Control_Siguiente = Me.tbx_EntreF2
        Me.tbx_EntreF1.Filtrado = True
        Me.tbx_EntreF1.Location = New System.Drawing.Point(90, 96)
        Me.tbx_EntreF1.MaxLength = 100
        Me.tbx_EntreF1.Name = "tbx_EntreF1"
        Me.tbx_EntreF1.Size = New System.Drawing.Size(237, 20)
        Me.tbx_EntreF1.TabIndex = 16
        Me.tbx_EntreF1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreF2
        '
        Me.tbx_EntreF2.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EntreF2.Control_Siguiente = Me.tbx_NumeroF
        Me.tbx_EntreF2.Filtrado = True
        Me.tbx_EntreF2.Location = New System.Drawing.Point(401, 96)
        Me.tbx_EntreF2.MaxLength = 100
        Me.tbx_EntreF2.Name = "tbx_EntreF2"
        Me.tbx_EntreF2.Size = New System.Drawing.Size(237, 20)
        Me.tbx_EntreF2.TabIndex = 18
        Me.tbx_EntreF2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroF
        '
        Me.tbx_NumeroF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NumeroF.Control_Siguiente = Me.tbx_IntF
        Me.tbx_NumeroF.Filtrado = False
        Me.tbx_NumeroF.Location = New System.Drawing.Point(401, 70)
        Me.tbx_NumeroF.MaxLength = 10
        Me.tbx_NumeroF.Name = "tbx_NumeroF"
        Me.tbx_NumeroF.Size = New System.Drawing.Size(65, 20)
        Me.tbx_NumeroF.TabIndex = 12
        Me.tbx_NumeroF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_IntF
        '
        Me.tbx_IntF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_IntF.Control_Siguiente = Me.tbx_ColoniaF
        Me.tbx_IntF.Filtrado = True
        Me.tbx_IntF.Location = New System.Drawing.Point(513, 70)
        Me.tbx_IntF.MaxLength = 10
        Me.tbx_IntF.Name = "tbx_IntF"
        Me.tbx_IntF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_IntF.TabIndex = 14
        Me.tbx_IntF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_ColoniaF
        '
        Me.tbx_ColoniaF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ColoniaF.Control_Siguiente = Me.tbx_CPF
        Me.tbx_ColoniaF.Filtrado = True
        Me.tbx_ColoniaF.Location = New System.Drawing.Point(90, 122)
        Me.tbx_ColoniaF.MaxLength = 100
        Me.tbx_ColoniaF.Name = "tbx_ColoniaF"
        Me.tbx_ColoniaF.Size = New System.Drawing.Size(237, 20)
        Me.tbx_ColoniaF.TabIndex = 20
        Me.tbx_ColoniaF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CPF
        '
        Me.tbx_CPF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CPF.Control_Siguiente = Me.cmb_PaisF
        Me.tbx_CPF.Filtrado = False
        Me.tbx_CPF.Location = New System.Drawing.Point(401, 122)
        Me.tbx_CPF.MaxLength = 10
        Me.tbx_CPF.Name = "tbx_CPF"
        Me.tbx_CPF.Size = New System.Drawing.Size(65, 20)
        Me.tbx_CPF.TabIndex = 23
        Me.tbx_CPF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_PaisF
        '
        Me.cmb_PaisF.Clave = Nothing
        Me.cmb_PaisF.Control_Siguiente = Me.cmb_EstadoF
        Me.cmb_PaisF.DisplayMember = "Nombre"
        Me.cmb_PaisF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PaisF.Empresa = False
        Me.cmb_PaisF.Filtro = Nothing
        Me.cmb_PaisF.FormattingEnabled = True
        Me.cmb_PaisF.Location = New System.Drawing.Point(90, 148)
        Me.cmb_PaisF.MaxDropDownItems = 20
        Me.cmb_PaisF.Name = "cmb_PaisF"
        Me.cmb_PaisF.Pista = True
        Me.cmb_PaisF.Size = New System.Drawing.Size(237, 21)
        Me.cmb_PaisF.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_PaisF.Sucursal = False
        Me.cmb_PaisF.TabIndex = 25
        Me.cmb_PaisF.Tipo = 0
        Me.cmb_PaisF.ValueMember = "Id_Pais"
        '
        'cmb_EstadoF
        '
        Me.cmb_EstadoF.Clave = Nothing
        Me.cmb_EstadoF.Control_Siguiente = Me.cmb_CiudadF
        Me.cmb_EstadoF.DisplayMember = "Nombre"
        Me.cmb_EstadoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EstadoF.Empresa = False
        Me.cmb_EstadoF.Filtro = Nothing
        Me.cmb_EstadoF.FormattingEnabled = True
        Me.cmb_EstadoF.Location = New System.Drawing.Point(401, 148)
        Me.cmb_EstadoF.MaxDropDownItems = 20
        Me.cmb_EstadoF.Name = "cmb_EstadoF"
        Me.cmb_EstadoF.Pista = True
        Me.cmb_EstadoF.Size = New System.Drawing.Size(237, 21)
        Me.cmb_EstadoF.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_EstadoF.Sucursal = False
        Me.cmb_EstadoF.TabIndex = 28
        Me.cmb_EstadoF.Tipo = 0
        Me.cmb_EstadoF.ValueMember = "Id_Estado"
        '
        'cmb_CiudadF
        '
        Me.cmb_CiudadF.Clave = Nothing
        Me.cmb_CiudadF.Control_Siguiente = Me.cmb_ZonaF
        Me.cmb_CiudadF.DisplayMember = "Nombre"
        Me.cmb_CiudadF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadF.Empresa = False
        Me.cmb_CiudadF.Filtro = Nothing
        Me.cmb_CiudadF.FormattingEnabled = True
        Me.cmb_CiudadF.Location = New System.Drawing.Point(90, 175)
        Me.cmb_CiudadF.MaxDropDownItems = 20
        Me.cmb_CiudadF.Name = "cmb_CiudadF"
        Me.cmb_CiudadF.Pista = True
        Me.cmb_CiudadF.Size = New System.Drawing.Size(237, 21)
        Me.cmb_CiudadF.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_CiudadF.Sucursal = False
        Me.cmb_CiudadF.TabIndex = 31
        Me.cmb_CiudadF.Tipo = 0
        Me.cmb_CiudadF.ValueMember = "Id_Ciudad"
        '
        'cmb_ZonaF
        '
        Me.cmb_ZonaF.Clave = Nothing
        Me.cmb_ZonaF.Control_Siguiente = Me.chk_Fiscales
        Me.cmb_ZonaF.DisplayMember = "Nombre"
        Me.cmb_ZonaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ZonaF.Empresa = False
        Me.cmb_ZonaF.Filtro = Nothing
        Me.cmb_ZonaF.FormattingEnabled = True
        Me.cmb_ZonaF.Location = New System.Drawing.Point(401, 175)
        Me.cmb_ZonaF.MaxDropDownItems = 20
        Me.cmb_ZonaF.Name = "cmb_ZonaF"
        Me.cmb_ZonaF.Pista = True
        Me.cmb_ZonaF.Size = New System.Drawing.Size(237, 21)
        Me.cmb_ZonaF.StoredProcedure = "Cat_ZonasCiudades_Get"
        Me.cmb_ZonaF.Sucursal = False
        Me.cmb_ZonaF.TabIndex = 34
        Me.cmb_ZonaF.Tipo = 0
        Me.cmb_ZonaF.ValueMember = "Id_Zona"
        '
        'tbx_ClvFactN
        '
        Me.tbx_ClvFactN.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ClvFactN.Control_Siguiente = Me.tbx_RFC
        Me.tbx_ClvFactN.Filtrado = True
        Me.tbx_ClvFactN.Location = New System.Drawing.Point(254, 228)
        Me.tbx_ClvFactN.MaxLength = 12
        Me.tbx_ClvFactN.Name = "tbx_ClvFactN"
        Me.tbx_ClvFactN.Size = New System.Drawing.Size(95, 20)
        Me.tbx_ClvFactN.TabIndex = 40
        Me.tbx_ClvFactN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ClvFactN.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_ClvFactAnt
        '
        Me.tbx_ClvFactAnt.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ClvFactAnt.Control_Siguiente = Me.tbx_RFC
        Me.tbx_ClvFactAnt.Filtrado = True
        Me.tbx_ClvFactAnt.Location = New System.Drawing.Point(254, 202)
        Me.tbx_ClvFactAnt.MaxLength = 12
        Me.tbx_ClvFactAnt.Name = "tbx_ClvFactAnt"
        Me.tbx_ClvFactAnt.Size = New System.Drawing.Size(95, 20)
        Me.tbx_ClvFactAnt.TabIndex = 37
        Me.tbx_ClvFactAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ClvFactAnt.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_ClientesActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(674, 481)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Nombre)
        Me.Controls.Add(Me.gbx_DatosF)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(690, 520)
        Me.Name = "frm_ClientesActualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Razón Social"
        Me.gbx_DatosF.ResumeLayout(False)
        Me.gbx_DatosF.PerformLayout()
        Me.gbx_Nombre.ResumeLayout(False)
        Me.gbx_Nombre.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Nombre As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_NombreF As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CalleF As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_PaisF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_EstadoF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CiudadF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ZonaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_RFC As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_DatosF As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_CPF As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CPF As System.Windows.Forms.Label
    Friend WithEvents lbl_ColoniaF As System.Windows.Forms.Label
    Friend WithEvents tbx_ColoniaF As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_IntF As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_IntF As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroF As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NumeroF As System.Windows.Forms.Label
    Friend WithEvents lbl_RFC As System.Windows.Forms.Label
    Friend WithEvents lbl_ZonaF As System.Windows.Forms.Label
    Friend WithEvents lbl_CiudadF As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoF As System.Windows.Forms.Label
    Friend WithEvents lbl_PaisF As System.Windows.Forms.Label
    Friend WithEvents lbl_CalleF As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreF As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents chk_Fiscales As System.Windows.Forms.CheckBox
    Friend WithEvents IdCartaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_EntreF2 As System.Windows.Forms.Label
    Friend WithEvents lbl_EntreF1 As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreF2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_EntreF1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lbl_ClvFactN As System.Windows.Forms.Label
    Friend WithEvents lbl_ClvFactAnt As System.Windows.Forms.Label
    Friend WithEvents tbx_ClvFactN As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_ClvFactAnt As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Inicio As System.Windows.Forms.Label
    Friend WithEvents lbl_A12 As System.Windows.Forms.Label
    Friend WithEvents lbl_A11 As System.Windows.Forms.Label
    Friend WithEvents lbl_A8 As System.Windows.Forms.Label
    Friend WithEvents lbl_A7 As System.Windows.Forms.Label
    Friend WithEvents lbl_A6 As System.Windows.Forms.Label
    Friend WithEvents lbl_A5 As System.Windows.Forms.Label
    Friend WithEvents lbl_A3 As System.Windows.Forms.Label
    Friend WithEvents lbl_A2 As System.Windows.Forms.Label
    Friend WithEvents lbl_A1 As System.Windows.Forms.Label
End Class
