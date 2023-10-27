<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NuevoProspecto
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
        Me.lbl_ClienteP = New System.Windows.Forms.Label
        Me.lbl_ClientePadre = New System.Windows.Forms.Label
        Me.cbx_ClienteP = New System.Windows.Forms.CheckBox
        Me.gbx_DatosC = New System.Windows.Forms.GroupBox
        Me.gbx_Foraneo = New System.Windows.Forms.GroupBox
        Me.rdb_ForaneoN = New System.Windows.Forms.RadioButton
        Me.rdb_ForaneoS = New System.Windows.Forms.RadioButton
        Me.lbl_NombreC = New System.Windows.Forms.Label
        Me.lbl_NombreCorto = New System.Windows.Forms.Label
        Me.lbl_EntreC2 = New System.Windows.Forms.Label
        Me.gbx_InicioOp = New System.Windows.Forms.GroupBox
        Me.dtp_InicioOp = New System.Windows.Forms.DateTimePicker
        Me.lbl_EntreC1 = New System.Windows.Forms.Label
        Me.rtb_MensajeAlerta = New System.Windows.Forms.RichTextBox
        Me.gbx_TipoCliente = New System.Windows.Forms.GroupBox
        Me.Rdb_Ambos = New System.Windows.Forms.RadioButton
        Me.rdb_Traslado = New System.Windows.Forms.RadioButton
        Me.Rdb_SeguridadP = New System.Windows.Forms.RadioButton
        Me.Rdb_CajaBancaria = New System.Windows.Forms.RadioButton
        Me.Rdb_Otro = New System.Windows.Forms.RadioButton
        Me.btn_MensajeAlerta = New System.Windows.Forms.Button
        Me.lbl_MensajeAlerta = New System.Windows.Forms.Label
        Me.lbl_MaterialOperativoA = New System.Windows.Forms.Label
        Me.lbl_Material = New System.Windows.Forms.Label
        Me.gbx_Material = New System.Windows.Forms.GroupBox
        Me.rbn_MaterialNo = New System.Windows.Forms.RadioButton
        Me.rbn_MaterialSi = New System.Windows.Forms.RadioButton
        Me.lbl_EstadoA = New System.Windows.Forms.Label
        Me.lbl_CiudadA = New System.Windows.Forms.Label
        Me.lbl_PaisA = New System.Windows.Forms.Label
        Me.lbl_ZonaA = New System.Windows.Forms.Label
        Me.lbl_ForaneoA = New System.Windows.Forms.Label
        Me.lbl_CategoriaA = New System.Windows.Forms.Label
        Me.lbl_GiroComercialA = New System.Windows.Forms.Label
        Me.lbl_NombreComercialA = New System.Windows.Forms.Label
        Me.lbl_CPC = New System.Windows.Forms.Label
        Me.lbl_ColoniaC = New System.Windows.Forms.Label
        Me.lbl_IntC = New System.Windows.Forms.Label
        Me.lbl_NumeroC = New System.Windows.Forms.Label
        Me.lbl_CalleC = New System.Windows.Forms.Label
        Me.lbl_Longitud = New System.Windows.Forms.Label
        Me.lbl_Latitud = New System.Windows.Forms.Label
        Me.lbl_Foraneo = New System.Windows.Forms.Label
        Me.lbl_ClaveRadio = New System.Windows.Forms.Label
        Me.lbl_Categoria = New System.Windows.Forms.Label
        Me.lbl_Giro = New System.Windows.Forms.Label
        Me.lbl_ZonaC = New System.Windows.Forms.Label
        Me.lbl_CiudadC = New System.Windows.Forms.Label
        Me.lbl_EstadoC = New System.Windows.Forms.Label
        Me.lbl_PaisC = New System.Windows.Forms.Label
        Me.gbx_DatosF = New System.Windows.Forms.GroupBox
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
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_ClientePadre = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_Asterisco = New System.Windows.Forms.Label
        Me.lbl_claveProspectoNew = New System.Windows.Forms.Label
        Me.tbx_claveProspectoNew = New Modulo_Ventas.cp_Textbox
        Me.tbx_SeleccioneCP = New Modulo_Ventas.cp_Textbox
        Me.cmb_SeleccioneCP = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
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
        Me.tbx_NombreCorto = New Modulo_Ventas.cp_Textbox
        Me.tbx_CalleC = New Modulo_Ventas.cp_Textbox
        Me.tbx_EntreC1 = New Modulo_Ventas.cp_Textbox
        Me.tbx_EntreC2 = New Modulo_Ventas.cp_Textbox
        Me.tbx_Longitud = New Modulo_Ventas.cp_Textbox
        Me.tbx_Latitud = New Modulo_Ventas.cp_Textbox
        Me.tbx_CPC = New Modulo_Ventas.cp_Textbox
        Me.cmb_PaisC = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_EstadoC = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_CiudadC = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_ZonaC = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Giro = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveRadio = New Modulo_Ventas.cp_Textbox
        Me.cmb_Categoria = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_ColoniaC = New Modulo_Ventas.cp_Textbox
        Me.tbx_IntC = New Modulo_Ventas.cp_Textbox
        Me.tbx_NumeroC = New Modulo_Ventas.cp_Textbox
        Me.tbx_NombreC = New Modulo_Ventas.cp_Textbox
        Me.gbx_DatosC.SuspendLayout()
        Me.gbx_Foraneo.SuspendLayout()
        Me.gbx_InicioOp.SuspendLayout()
        Me.gbx_TipoCliente.SuspendLayout()
        Me.gbx_Material.SuspendLayout()
        Me.gbx_DatosF.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_ClientePadre.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_ClienteP
        '
        Me.lbl_ClienteP.AutoSize = True
        Me.lbl_ClienteP.Location = New System.Drawing.Point(15, 12)
        Me.lbl_ClienteP.Name = "lbl_ClienteP"
        Me.lbl_ClienteP.Size = New System.Drawing.Size(91, 13)
        Me.lbl_ClienteP.TabIndex = 0
        Me.lbl_ClienteP.Text = "Es Cliente Padre?"
        '
        'lbl_ClientePadre
        '
        Me.lbl_ClientePadre.AutoSize = True
        Me.lbl_ClientePadre.Location = New System.Drawing.Point(36, 35)
        Me.lbl_ClientePadre.Name = "lbl_ClientePadre"
        Me.lbl_ClientePadre.Size = New System.Drawing.Size(70, 13)
        Me.lbl_ClientePadre.TabIndex = 2
        Me.lbl_ClientePadre.Text = "Cliente Padre"
        '
        'cbx_ClienteP
        '
        Me.cbx_ClienteP.AutoSize = True
        Me.cbx_ClienteP.Location = New System.Drawing.Point(112, 12)
        Me.cbx_ClienteP.Name = "cbx_ClienteP"
        Me.cbx_ClienteP.Size = New System.Drawing.Size(15, 14)
        Me.cbx_ClienteP.TabIndex = 1
        Me.cbx_ClienteP.UseVisualStyleBackColor = True
        '
        'gbx_DatosC
        '
        Me.gbx_DatosC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosC.Controls.Add(Me.gbx_Foraneo)
        Me.gbx_DatosC.Controls.Add(Me.tbx_NombreCorto)
        Me.gbx_DatosC.Controls.Add(Me.lbl_NombreCorto)
        Me.gbx_DatosC.Controls.Add(Me.lbl_EntreC2)
        Me.gbx_DatosC.Controls.Add(Me.gbx_InicioOp)
        Me.gbx_DatosC.Controls.Add(Me.lbl_EntreC1)
        Me.gbx_DatosC.Controls.Add(Me.rtb_MensajeAlerta)
        Me.gbx_DatosC.Controls.Add(Me.tbx_EntreC2)
        Me.gbx_DatosC.Controls.Add(Me.gbx_TipoCliente)
        Me.gbx_DatosC.Controls.Add(Me.tbx_EntreC1)
        Me.gbx_DatosC.Controls.Add(Me.btn_MensajeAlerta)
        Me.gbx_DatosC.Controls.Add(Me.lbl_MensajeAlerta)
        Me.gbx_DatosC.Controls.Add(Me.lbl_MaterialOperativoA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_Material)
        Me.gbx_DatosC.Controls.Add(Me.gbx_Material)
        Me.gbx_DatosC.Controls.Add(Me.tbx_Longitud)
        Me.gbx_DatosC.Controls.Add(Me.tbx_Latitud)
        Me.gbx_DatosC.Controls.Add(Me.lbl_EstadoA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_CiudadA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_PaisA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_ZonaA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_ForaneoA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_CategoriaA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_GiroComercialA)
        Me.gbx_DatosC.Controls.Add(Me.lbl_NombreComercialA)
        Me.gbx_DatosC.Controls.Add(Me.tbx_CPC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_CPC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_ColoniaC)
        Me.gbx_DatosC.Controls.Add(Me.tbx_ColoniaC)
        Me.gbx_DatosC.Controls.Add(Me.tbx_IntC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_IntC)
        Me.gbx_DatosC.Controls.Add(Me.tbx_NumeroC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_NumeroC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_CalleC)
        Me.gbx_DatosC.Controls.Add(Me.tbx_CalleC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_Longitud)
        Me.gbx_DatosC.Controls.Add(Me.lbl_Latitud)
        Me.gbx_DatosC.Controls.Add(Me.lbl_Foraneo)
        Me.gbx_DatosC.Controls.Add(Me.lbl_ClaveRadio)
        Me.gbx_DatosC.Controls.Add(Me.tbx_ClaveRadio)
        Me.gbx_DatosC.Controls.Add(Me.lbl_Categoria)
        Me.gbx_DatosC.Controls.Add(Me.cmb_Categoria)
        Me.gbx_DatosC.Controls.Add(Me.lbl_Giro)
        Me.gbx_DatosC.Controls.Add(Me.cmb_Giro)
        Me.gbx_DatosC.Controls.Add(Me.cmb_ZonaC)
        Me.gbx_DatosC.Controls.Add(Me.cmb_CiudadC)
        Me.gbx_DatosC.Controls.Add(Me.cmb_EstadoC)
        Me.gbx_DatosC.Controls.Add(Me.cmb_PaisC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_ZonaC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_CiudadC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_EstadoC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_PaisC)
        Me.gbx_DatosC.Controls.Add(Me.lbl_NombreC)
        Me.gbx_DatosC.Controls.Add(Me.tbx_NombreC)
        Me.gbx_DatosC.Location = New System.Drawing.Point(10, 225)
        Me.gbx_DatosC.Name = "gbx_DatosC"
        Me.gbx_DatosC.Size = New System.Drawing.Size(824, 261)
        Me.gbx_DatosC.TabIndex = 2
        Me.gbx_DatosC.TabStop = False
        Me.gbx_DatosC.Text = "Datos Comerciales"
        '
        'gbx_Foraneo
        '
        Me.gbx_Foraneo.Controls.Add(Me.rdb_ForaneoN)
        Me.gbx_Foraneo.Controls.Add(Me.rdb_ForaneoS)
        Me.gbx_Foraneo.Location = New System.Drawing.Point(438, 154)
        Me.gbx_Foraneo.Name = "gbx_Foraneo"
        Me.gbx_Foraneo.Size = New System.Drawing.Size(95, 28)
        Me.gbx_Foraneo.TabIndex = 54
        Me.gbx_Foraneo.TabStop = False
        '
        'rdb_ForaneoN
        '
        Me.rdb_ForaneoN.AutoSize = True
        Me.rdb_ForaneoN.Location = New System.Drawing.Point(49, 7)
        Me.rdb_ForaneoN.Name = "rdb_ForaneoN"
        Me.rdb_ForaneoN.Size = New System.Drawing.Size(39, 17)
        Me.rdb_ForaneoN.TabIndex = 1
        Me.rdb_ForaneoN.TabStop = True
        Me.rdb_ForaneoN.Text = "No"
        Me.rdb_ForaneoN.UseVisualStyleBackColor = True
        '
        'rdb_ForaneoS
        '
        Me.rdb_ForaneoS.AutoSize = True
        Me.rdb_ForaneoS.Location = New System.Drawing.Point(5, 7)
        Me.rdb_ForaneoS.Name = "rdb_ForaneoS"
        Me.rdb_ForaneoS.Size = New System.Drawing.Size(36, 17)
        Me.rdb_ForaneoS.TabIndex = 0
        Me.rdb_ForaneoS.TabStop = True
        Me.rdb_ForaneoS.Text = "Sí"
        Me.rdb_ForaneoS.UseVisualStyleBackColor = True
        '
        'lbl_NombreC
        '
        Me.lbl_NombreC.AutoSize = True
        Me.lbl_NombreC.Location = New System.Drawing.Point(60, 20)
        Me.lbl_NombreC.Name = "lbl_NombreC"
        Me.lbl_NombreC.Size = New System.Drawing.Size(44, 13)
        Me.lbl_NombreC.TabIndex = 0
        Me.lbl_NombreC.Text = "Nombre"
        '
        'lbl_NombreCorto
        '
        Me.lbl_NombreCorto.AutoSize = True
        Me.lbl_NombreCorto.Location = New System.Drawing.Point(614, 20)
        Me.lbl_NombreCorto.Name = "lbl_NombreCorto"
        Me.lbl_NombreCorto.Size = New System.Drawing.Size(72, 13)
        Me.lbl_NombreCorto.TabIndex = 3
        Me.lbl_NombreCorto.Text = "Nombre Corto"
        '
        'lbl_EntreC2
        '
        Me.lbl_EntreC2.AutoSize = True
        Me.lbl_EntreC2.Location = New System.Drawing.Point(517, 43)
        Me.lbl_EntreC2.Name = "lbl_EntreC2"
        Me.lbl_EntreC2.Size = New System.Drawing.Size(14, 13)
        Me.lbl_EntreC2.TabIndex = 9
        Me.lbl_EntreC2.Text = "Y"
        '
        'gbx_InicioOp
        '
        Me.gbx_InicioOp.Controls.Add(Me.dtp_InicioOp)
        Me.gbx_InicioOp.Location = New System.Drawing.Point(692, 200)
        Me.gbx_InicioOp.Name = "gbx_InicioOp"
        Me.gbx_InicioOp.Size = New System.Drawing.Size(122, 48)
        Me.gbx_InicioOp.TabIndex = 53
        Me.gbx_InicioOp.TabStop = False
        Me.gbx_InicioOp.Text = "Inicio Operaciones"
        '
        'dtp_InicioOp
        '
        Me.dtp_InicioOp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_InicioOp.Location = New System.Drawing.Point(14, 19)
        Me.dtp_InicioOp.Name = "dtp_InicioOp"
        Me.dtp_InicioOp.Size = New System.Drawing.Size(95, 20)
        Me.dtp_InicioOp.TabIndex = 0
        '
        'lbl_EntreC1
        '
        Me.lbl_EntreC1.AutoSize = True
        Me.lbl_EntreC1.Location = New System.Drawing.Point(344, 43)
        Me.lbl_EntreC1.Name = "lbl_EntreC1"
        Me.lbl_EntreC1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_EntreC1.TabIndex = 7
        Me.lbl_EntreC1.Text = "Entre"
        '
        'rtb_MensajeAlerta
        '
        Me.rtb_MensajeAlerta.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_MensajeAlerta.Location = New System.Drawing.Point(110, 215)
        Me.rtb_MensajeAlerta.Name = "rtb_MensajeAlerta"
        Me.rtb_MensajeAlerta.ReadOnly = True
        Me.rtb_MensajeAlerta.Size = New System.Drawing.Size(475, 35)
        Me.rtb_MensajeAlerta.TabIndex = 50
        Me.rtb_MensajeAlerta.Text = ""
        '
        'gbx_TipoCliente
        '
        Me.gbx_TipoCliente.Controls.Add(Me.Rdb_Ambos)
        Me.gbx_TipoCliente.Controls.Add(Me.rdb_Traslado)
        Me.gbx_TipoCliente.Controls.Add(Me.Rdb_SeguridadP)
        Me.gbx_TipoCliente.Controls.Add(Me.Rdb_CajaBancaria)
        Me.gbx_TipoCliente.Controls.Add(Me.Rdb_Otro)
        Me.gbx_TipoCliente.Location = New System.Drawing.Point(692, 56)
        Me.gbx_TipoCliente.Name = "gbx_TipoCliente"
        Me.gbx_TipoCliente.Size = New System.Drawing.Size(122, 138)
        Me.gbx_TipoCliente.TabIndex = 52
        Me.gbx_TipoCliente.TabStop = False
        Me.gbx_TipoCliente.Text = "Tipo de Cliente"
        '
        'Rdb_Ambos
        '
        Me.Rdb_Ambos.AutoSize = True
        Me.Rdb_Ambos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Ambos.Location = New System.Drawing.Point(6, 67)
        Me.Rdb_Ambos.Name = "Rdb_Ambos"
        Me.Rdb_Ambos.Size = New System.Drawing.Size(99, 17)
        Me.Rdb_Ambos.TabIndex = 2
        Me.Rdb_Ambos.TabStop = True
        Me.Rdb_Ambos.Text = "Traslado y Seg."
        Me.Rdb_Ambos.UseVisualStyleBackColor = True
        '
        'rdb_Traslado
        '
        Me.rdb_Traslado.AutoSize = True
        Me.rdb_Traslado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_Traslado.Location = New System.Drawing.Point(6, 21)
        Me.rdb_Traslado.Name = "rdb_Traslado"
        Me.rdb_Traslado.Size = New System.Drawing.Size(66, 17)
        Me.rdb_Traslado.TabIndex = 0
        Me.rdb_Traslado.TabStop = True
        Me.rdb_Traslado.Text = "Traslado"
        Me.rdb_Traslado.UseVisualStyleBackColor = True
        '
        'Rdb_SeguridadP
        '
        Me.Rdb_SeguridadP.AutoSize = True
        Me.Rdb_SeguridadP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_SeguridadP.Location = New System.Drawing.Point(6, 44)
        Me.Rdb_SeguridadP.Name = "Rdb_SeguridadP"
        Me.Rdb_SeguridadP.Size = New System.Drawing.Size(101, 17)
        Me.Rdb_SeguridadP.TabIndex = 1
        Me.Rdb_SeguridadP.TabStop = True
        Me.Rdb_SeguridadP.Text = "Seg. Patrimonial"
        Me.Rdb_SeguridadP.UseVisualStyleBackColor = True
        '
        'Rdb_CajaBancaria
        '
        Me.Rdb_CajaBancaria.AutoSize = True
        Me.Rdb_CajaBancaria.Location = New System.Drawing.Point(6, 90)
        Me.Rdb_CajaBancaria.Name = "Rdb_CajaBancaria"
        Me.Rdb_CajaBancaria.Size = New System.Drawing.Size(91, 17)
        Me.Rdb_CajaBancaria.TabIndex = 3
        Me.Rdb_CajaBancaria.TabStop = True
        Me.Rdb_CajaBancaria.Text = "Caja Bancaria"
        Me.Rdb_CajaBancaria.UseVisualStyleBackColor = True
        '
        'Rdb_Otro
        '
        Me.Rdb_Otro.AutoSize = True
        Me.Rdb_Otro.Location = New System.Drawing.Point(6, 113)
        Me.Rdb_Otro.Name = "Rdb_Otro"
        Me.Rdb_Otro.Size = New System.Drawing.Size(45, 17)
        Me.Rdb_Otro.TabIndex = 4
        Me.Rdb_Otro.TabStop = True
        Me.Rdb_Otro.Text = "Otro"
        Me.Rdb_Otro.UseVisualStyleBackColor = True
        '
        'btn_MensajeAlerta
        '
        Me.btn_MensajeAlerta.Image = Global.Modulo_Ventas.My.Resources.Resources.edit_add
        Me.btn_MensajeAlerta.Location = New System.Drawing.Point(590, 215)
        Me.btn_MensajeAlerta.Name = "btn_MensajeAlerta"
        Me.btn_MensajeAlerta.Size = New System.Drawing.Size(75, 23)
        Me.btn_MensajeAlerta.TabIndex = 51
        Me.btn_MensajeAlerta.Text = "&Agregar"
        Me.btn_MensajeAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MensajeAlerta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MensajeAlerta.UseVisualStyleBackColor = True
        '
        'lbl_MensajeAlerta
        '
        Me.lbl_MensajeAlerta.Location = New System.Drawing.Point(32, 215)
        Me.lbl_MensajeAlerta.Name = "lbl_MensajeAlerta"
        Me.lbl_MensajeAlerta.Size = New System.Drawing.Size(72, 33)
        Me.lbl_MensajeAlerta.TabIndex = 49
        Me.lbl_MensajeAlerta.Text = "Mensaje para Alerta"
        Me.lbl_MensajeAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_MaterialOperativoA
        '
        Me.lbl_MaterialOperativoA.AutoSize = True
        Me.lbl_MaterialOperativoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MaterialOperativoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MaterialOperativoA.Location = New System.Drawing.Point(207, 187)
        Me.lbl_MaterialOperativoA.Name = "lbl_MaterialOperativoA"
        Me.lbl_MaterialOperativoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_MaterialOperativoA.TabIndex = 44
        Me.lbl_MaterialOperativoA.Text = "*"
        '
        'lbl_Material
        '
        Me.lbl_Material.AutoSize = True
        Me.lbl_Material.Location = New System.Drawing.Point(5, 189)
        Me.lbl_Material.Name = "lbl_Material"
        Me.lbl_Material.Size = New System.Drawing.Size(99, 13)
        Me.lbl_Material.TabIndex = 42
        Me.lbl_Material.Text = "Material Operativo?"
        '
        'gbx_Material
        '
        Me.gbx_Material.Controls.Add(Me.rbn_MaterialNo)
        Me.gbx_Material.Controls.Add(Me.rbn_MaterialSi)
        Me.gbx_Material.Location = New System.Drawing.Point(110, 180)
        Me.gbx_Material.Name = "gbx_Material"
        Me.gbx_Material.Size = New System.Drawing.Size(95, 28)
        Me.gbx_Material.TabIndex = 43
        Me.gbx_Material.TabStop = False
        '
        'rbn_MaterialNo
        '
        Me.rbn_MaterialNo.AutoSize = True
        Me.rbn_MaterialNo.Location = New System.Drawing.Point(49, 7)
        Me.rbn_MaterialNo.Name = "rbn_MaterialNo"
        Me.rbn_MaterialNo.Size = New System.Drawing.Size(39, 17)
        Me.rbn_MaterialNo.TabIndex = 1
        Me.rbn_MaterialNo.TabStop = True
        Me.rbn_MaterialNo.Text = "No"
        Me.rbn_MaterialNo.UseVisualStyleBackColor = True
        '
        'rbn_MaterialSi
        '
        Me.rbn_MaterialSi.AutoSize = True
        Me.rbn_MaterialSi.Location = New System.Drawing.Point(5, 7)
        Me.rbn_MaterialSi.Name = "rbn_MaterialSi"
        Me.rbn_MaterialSi.Size = New System.Drawing.Size(36, 17)
        Me.rbn_MaterialSi.TabIndex = 0
        Me.rbn_MaterialSi.TabStop = True
        Me.rbn_MaterialSi.Text = "Sí"
        Me.rbn_MaterialSi.UseVisualStyleBackColor = True
        '
        'lbl_EstadoA
        '
        Me.lbl_EstadoA.AutoSize = True
        Me.lbl_EstadoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EstadoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_EstadoA.Location = New System.Drawing.Point(672, 86)
        Me.lbl_EstadoA.Name = "lbl_EstadoA"
        Me.lbl_EstadoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_EstadoA.TabIndex = 24
        Me.lbl_EstadoA.Text = "*"
        '
        'lbl_CiudadA
        '
        Me.lbl_CiudadA.AutoSize = True
        Me.lbl_CiudadA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CiudadA.ForeColor = System.Drawing.Color.Red
        Me.lbl_CiudadA.Location = New System.Drawing.Point(344, 110)
        Me.lbl_CiudadA.Name = "lbl_CiudadA"
        Me.lbl_CiudadA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_CiudadA.TabIndex = 27
        Me.lbl_CiudadA.Text = "*"
        '
        'lbl_PaisA
        '
        Me.lbl_PaisA.AutoSize = True
        Me.lbl_PaisA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaisA.ForeColor = System.Drawing.Color.Red
        Me.lbl_PaisA.Location = New System.Drawing.Point(344, 86)
        Me.lbl_PaisA.Name = "lbl_PaisA"
        Me.lbl_PaisA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_PaisA.TabIndex = 21
        Me.lbl_PaisA.Text = "*"
        '
        'lbl_ZonaA
        '
        Me.lbl_ZonaA.AutoSize = True
        Me.lbl_ZonaA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ZonaA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ZonaA.Location = New System.Drawing.Point(672, 110)
        Me.lbl_ZonaA.Name = "lbl_ZonaA"
        Me.lbl_ZonaA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ZonaA.TabIndex = 30
        Me.lbl_ZonaA.Text = "*"
        '
        'lbl_ForaneoA
        '
        Me.lbl_ForaneoA.AutoSize = True
        Me.lbl_ForaneoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ForaneoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ForaneoA.Location = New System.Drawing.Point(535, 163)
        Me.lbl_ForaneoA.Name = "lbl_ForaneoA"
        Me.lbl_ForaneoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ForaneoA.TabIndex = 41
        Me.lbl_ForaneoA.Text = "*"
        '
        'lbl_CategoriaA
        '
        Me.lbl_CategoriaA.AutoSize = True
        Me.lbl_CategoriaA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CategoriaA.ForeColor = System.Drawing.Color.Red
        Me.lbl_CategoriaA.Location = New System.Drawing.Point(344, 158)
        Me.lbl_CategoriaA.Name = "lbl_CategoriaA"
        Me.lbl_CategoriaA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_CategoriaA.TabIndex = 38
        Me.lbl_CategoriaA.Text = "*"
        '
        'lbl_GiroComercialA
        '
        Me.lbl_GiroComercialA.AutoSize = True
        Me.lbl_GiroComercialA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GiroComercialA.ForeColor = System.Drawing.Color.Red
        Me.lbl_GiroComercialA.Location = New System.Drawing.Point(344, 134)
        Me.lbl_GiroComercialA.Name = "lbl_GiroComercialA"
        Me.lbl_GiroComercialA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_GiroComercialA.TabIndex = 33
        Me.lbl_GiroComercialA.Text = "*"
        '
        'lbl_NombreComercialA
        '
        Me.lbl_NombreComercialA.AutoSize = True
        Me.lbl_NombreComercialA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreComercialA.ForeColor = System.Drawing.Color.Red
        Me.lbl_NombreComercialA.Location = New System.Drawing.Point(603, 18)
        Me.lbl_NombreComercialA.Name = "lbl_NombreComercialA"
        Me.lbl_NombreComercialA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_NombreComercialA.TabIndex = 2
        Me.lbl_NombreComercialA.Text = "*"
        '
        'lbl_CPC
        '
        Me.lbl_CPC.AutoSize = True
        Me.lbl_CPC.Location = New System.Drawing.Point(574, 66)
        Me.lbl_CPC.Name = "lbl_CPC"
        Me.lbl_CPC.Size = New System.Drawing.Size(21, 13)
        Me.lbl_CPC.TabIndex = 17
        Me.lbl_CPC.Text = "CP"
        '
        'lbl_ColoniaC
        '
        Me.lbl_ColoniaC.AutoSize = True
        Me.lbl_ColoniaC.Location = New System.Drawing.Point(282, 66)
        Me.lbl_ColoniaC.Name = "lbl_ColoniaC"
        Me.lbl_ColoniaC.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ColoniaC.TabIndex = 15
        Me.lbl_ColoniaC.Text = "Colonia"
        '
        'lbl_IntC
        '
        Me.lbl_IntC.AutoSize = True
        Me.lbl_IntC.Location = New System.Drawing.Point(181, 66)
        Me.lbl_IntC.Name = "lbl_IntC"
        Me.lbl_IntC.Size = New System.Drawing.Size(39, 13)
        Me.lbl_IntC.TabIndex = 13
        Me.lbl_IntC.Text = "Interior"
        '
        'lbl_NumeroC
        '
        Me.lbl_NumeroC.AutoSize = True
        Me.lbl_NumeroC.Location = New System.Drawing.Point(59, 66)
        Me.lbl_NumeroC.Name = "lbl_NumeroC"
        Me.lbl_NumeroC.Size = New System.Drawing.Size(45, 13)
        Me.lbl_NumeroC.TabIndex = 11
        Me.lbl_NumeroC.Text = "No. Ext."
        '
        'lbl_CalleC
        '
        Me.lbl_CalleC.AutoSize = True
        Me.lbl_CalleC.Location = New System.Drawing.Point(74, 43)
        Me.lbl_CalleC.Name = "lbl_CalleC"
        Me.lbl_CalleC.Size = New System.Drawing.Size(30, 13)
        Me.lbl_CalleC.TabIndex = 5
        Me.lbl_CalleC.Text = "Calle"
        '
        'lbl_Longitud
        '
        Me.lbl_Longitud.AutoSize = True
        Me.lbl_Longitud.Location = New System.Drawing.Point(535, 189)
        Me.lbl_Longitud.Name = "lbl_Longitud"
        Me.lbl_Longitud.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Longitud.TabIndex = 47
        Me.lbl_Longitud.Text = "Longitud"
        '
        'lbl_Latitud
        '
        Me.lbl_Latitud.AutoSize = True
        Me.lbl_Latitud.Location = New System.Drawing.Point(393, 191)
        Me.lbl_Latitud.Name = "lbl_Latitud"
        Me.lbl_Latitud.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Latitud.TabIndex = 45
        Me.lbl_Latitud.Text = "Latitud"
        '
        'lbl_Foraneo
        '
        Me.lbl_Foraneo.AutoSize = True
        Me.lbl_Foraneo.Location = New System.Drawing.Point(365, 166)
        Me.lbl_Foraneo.Name = "lbl_Foraneo"
        Me.lbl_Foraneo.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Foraneo.TabIndex = 39
        Me.lbl_Foraneo.Text = "Es Foráneo?"
        '
        'lbl_ClaveRadio
        '
        Me.lbl_ClaveRadio.AutoSize = True
        Me.lbl_ClaveRadio.Location = New System.Drawing.Point(367, 137)
        Me.lbl_ClaveRadio.Name = "lbl_ClaveRadio"
        Me.lbl_ClaveRadio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_ClaveRadio.TabIndex = 34
        Me.lbl_ClaveRadio.Text = "Clave Radio"
        '
        'lbl_Categoria
        '
        Me.lbl_Categoria.AutoSize = True
        Me.lbl_Categoria.Location = New System.Drawing.Point(50, 161)
        Me.lbl_Categoria.Name = "lbl_Categoria"
        Me.lbl_Categoria.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Categoria.TabIndex = 36
        Me.lbl_Categoria.Text = "Categoría"
        '
        'lbl_Giro
        '
        Me.lbl_Giro.AutoSize = True
        Me.lbl_Giro.Location = New System.Drawing.Point(29, 137)
        Me.lbl_Giro.Name = "lbl_Giro"
        Me.lbl_Giro.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Giro.TabIndex = 31
        Me.lbl_Giro.Text = "Giro Comercial"
        '
        'lbl_ZonaC
        '
        Me.lbl_ZonaC.AutoSize = True
        Me.lbl_ZonaC.Location = New System.Drawing.Point(400, 113)
        Me.lbl_ZonaC.Name = "lbl_ZonaC"
        Me.lbl_ZonaC.Size = New System.Drawing.Size(32, 13)
        Me.lbl_ZonaC.TabIndex = 28
        Me.lbl_ZonaC.Text = "Zona"
        '
        'lbl_CiudadC
        '
        Me.lbl_CiudadC.AutoSize = True
        Me.lbl_CiudadC.Location = New System.Drawing.Point(64, 113)
        Me.lbl_CiudadC.Name = "lbl_CiudadC"
        Me.lbl_CiudadC.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CiudadC.TabIndex = 25
        Me.lbl_CiudadC.Text = "Ciudad"
        '
        'lbl_EstadoC
        '
        Me.lbl_EstadoC.AutoSize = True
        Me.lbl_EstadoC.Location = New System.Drawing.Point(392, 89)
        Me.lbl_EstadoC.Name = "lbl_EstadoC"
        Me.lbl_EstadoC.Size = New System.Drawing.Size(40, 13)
        Me.lbl_EstadoC.TabIndex = 22
        Me.lbl_EstadoC.Text = "Estado"
        '
        'lbl_PaisC
        '
        Me.lbl_PaisC.AutoSize = True
        Me.lbl_PaisC.Location = New System.Drawing.Point(75, 89)
        Me.lbl_PaisC.Name = "lbl_PaisC"
        Me.lbl_PaisC.Size = New System.Drawing.Size(29, 13)
        Me.lbl_PaisC.TabIndex = 19
        Me.lbl_PaisC.Text = "País"
        '
        'gbx_DatosF
        '
        Me.gbx_DatosF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosF.Controls.Add(Me.lbl_EntreF2)
        Me.gbx_DatosF.Controls.Add(Me.lbl_EntreF1)
        Me.gbx_DatosF.Controls.Add(Me.tbx_EntreF2)
        Me.gbx_DatosF.Controls.Add(Me.tbx_EntreF1)
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
        Me.gbx_DatosF.Location = New System.Drawing.Point(10, 72)
        Me.gbx_DatosF.MinimumSize = New System.Drawing.Size(824, 147)
        Me.gbx_DatosF.Name = "gbx_DatosF"
        Me.gbx_DatosF.Size = New System.Drawing.Size(824, 147)
        Me.gbx_DatosF.TabIndex = 1
        Me.gbx_DatosF.TabStop = False
        Me.gbx_DatosF.Text = "Datos Fiscales"
        '
        'lbl_EntreF2
        '
        Me.lbl_EntreF2.AutoSize = True
        Me.lbl_EntreF2.Location = New System.Drawing.Point(517, 48)
        Me.lbl_EntreF2.Name = "lbl_EntreF2"
        Me.lbl_EntreF2.Size = New System.Drawing.Size(14, 13)
        Me.lbl_EntreF2.TabIndex = 8
        Me.lbl_EntreF2.Text = "Y"
        '
        'lbl_EntreF1
        '
        Me.lbl_EntreF1.AutoSize = True
        Me.lbl_EntreF1.Location = New System.Drawing.Point(344, 48)
        Me.lbl_EntreF1.Name = "lbl_EntreF1"
        Me.lbl_EntreF1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_EntreF1.TabIndex = 6
        Me.lbl_EntreF1.Text = "Entre"
        '
        'lbl_CPF
        '
        Me.lbl_CPF.AutoSize = True
        Me.lbl_CPF.Location = New System.Drawing.Point(574, 71)
        Me.lbl_CPF.Name = "lbl_CPF"
        Me.lbl_CPF.Size = New System.Drawing.Size(21, 13)
        Me.lbl_CPF.TabIndex = 16
        Me.lbl_CPF.Text = "CP"
        '
        'lbl_ColoniaF
        '
        Me.lbl_ColoniaF.AutoSize = True
        Me.lbl_ColoniaF.Location = New System.Drawing.Point(285, 71)
        Me.lbl_ColoniaF.Name = "lbl_ColoniaF"
        Me.lbl_ColoniaF.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ColoniaF.TabIndex = 14
        Me.lbl_ColoniaF.Text = "Colonia"
        '
        'lbl_IntF
        '
        Me.lbl_IntF.AutoSize = True
        Me.lbl_IntF.Location = New System.Drawing.Point(183, 71)
        Me.lbl_IntF.Name = "lbl_IntF"
        Me.lbl_IntF.Size = New System.Drawing.Size(39, 13)
        Me.lbl_IntF.TabIndex = 12
        Me.lbl_IntF.Text = "Interior"
        '
        'lbl_NumeroF
        '
        Me.lbl_NumeroF.AutoSize = True
        Me.lbl_NumeroF.Location = New System.Drawing.Point(59, 71)
        Me.lbl_NumeroF.Name = "lbl_NumeroF"
        Me.lbl_NumeroF.Size = New System.Drawing.Size(45, 13)
        Me.lbl_NumeroF.TabIndex = 10
        Me.lbl_NumeroF.Text = "No. Ext."
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(517, 22)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(28, 13)
        Me.lbl_RFC.TabIndex = 2
        Me.lbl_RFC.Text = "RFC"
        '
        'lbl_ZonaF
        '
        Me.lbl_ZonaF.AutoSize = True
        Me.lbl_ZonaF.Location = New System.Drawing.Point(400, 118)
        Me.lbl_ZonaF.Name = "lbl_ZonaF"
        Me.lbl_ZonaF.Size = New System.Drawing.Size(32, 13)
        Me.lbl_ZonaF.TabIndex = 24
        Me.lbl_ZonaF.Text = "Zona"
        '
        'lbl_CiudadF
        '
        Me.lbl_CiudadF.AutoSize = True
        Me.lbl_CiudadF.Location = New System.Drawing.Point(64, 118)
        Me.lbl_CiudadF.Name = "lbl_CiudadF"
        Me.lbl_CiudadF.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CiudadF.TabIndex = 22
        Me.lbl_CiudadF.Text = "Ciudad"
        '
        'lbl_EstadoF
        '
        Me.lbl_EstadoF.AutoSize = True
        Me.lbl_EstadoF.Location = New System.Drawing.Point(392, 94)
        Me.lbl_EstadoF.Name = "lbl_EstadoF"
        Me.lbl_EstadoF.Size = New System.Drawing.Size(40, 13)
        Me.lbl_EstadoF.TabIndex = 20
        Me.lbl_EstadoF.Text = "Estado"
        '
        'lbl_PaisF
        '
        Me.lbl_PaisF.AutoSize = True
        Me.lbl_PaisF.Location = New System.Drawing.Point(75, 94)
        Me.lbl_PaisF.Name = "lbl_PaisF"
        Me.lbl_PaisF.Size = New System.Drawing.Size(29, 13)
        Me.lbl_PaisF.TabIndex = 18
        Me.lbl_PaisF.Text = "País"
        '
        'lbl_CalleF
        '
        Me.lbl_CalleF.AutoSize = True
        Me.lbl_CalleF.Location = New System.Drawing.Point(74, 48)
        Me.lbl_CalleF.Name = "lbl_CalleF"
        Me.lbl_CalleF.Size = New System.Drawing.Size(30, 13)
        Me.lbl_CalleF.TabIndex = 4
        Me.lbl_CalleF.Text = "Calle"
        '
        'lbl_NombreF
        '
        Me.lbl_NombreF.AutoSize = True
        Me.lbl_NombreF.Location = New System.Drawing.Point(60, 22)
        Me.lbl_NombreF.Name = "lbl_NombreF"
        Me.lbl_NombreF.Size = New System.Drawing.Size(44, 13)
        Me.lbl_NombreF.TabIndex = 0
        Me.lbl_NombreF.Text = "Nombre"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cancelar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(10, 492)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(824, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
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
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(678, 13)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "&Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'gbx_ClientePadre
        '
        Me.gbx_ClientePadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ClientePadre.Controls.Add(Me.btn_Buscar)
        Me.gbx_ClientePadre.Controls.Add(Me.tbx_claveProspectoNew)
        Me.gbx_ClientePadre.Controls.Add(Me.tbx_SeleccioneCP)
        Me.gbx_ClientePadre.Controls.Add(Me.lbl_ClientePadre)
        Me.gbx_ClientePadre.Controls.Add(Me.lbl_ClienteP)
        Me.gbx_ClientePadre.Controls.Add(Me.cbx_ClienteP)
        Me.gbx_ClientePadre.Controls.Add(Me.cmb_SeleccioneCP)
        Me.gbx_ClientePadre.Controls.Add(Me.lbl_Asterisco)
        Me.gbx_ClientePadre.Controls.Add(Me.lbl_claveProspectoNew)
        Me.gbx_ClientePadre.Location = New System.Drawing.Point(10, 9)
        Me.gbx_ClientePadre.Name = "gbx_ClientePadre"
        Me.gbx_ClientePadre.Size = New System.Drawing.Size(824, 60)
        Me.gbx_ClientePadre.TabIndex = 0
        Me.gbx_ClientePadre.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(677, 30)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(70, 23)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Asterisco
        '
        Me.lbl_Asterisco.AutoSize = True
        Me.lbl_Asterisco.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Asterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_Asterisco.Location = New System.Drawing.Point(666, 34)
        Me.lbl_Asterisco.Name = "lbl_Asterisco"
        Me.lbl_Asterisco.Size = New System.Drawing.Size(13, 16)
        Me.lbl_Asterisco.TabIndex = 5
        Me.lbl_Asterisco.Text = "*"
        '
        'lbl_claveProspectoNew
        '
        Me.lbl_claveProspectoNew.AutoSize = True
        Me.lbl_claveProspectoNew.Location = New System.Drawing.Point(200, 12)
        Me.lbl_claveProspectoNew.Name = "lbl_claveProspectoNew"
        Me.lbl_claveProspectoNew.Size = New System.Drawing.Size(85, 13)
        Me.lbl_claveProspectoNew.TabIndex = 8
        Me.lbl_claveProspectoNew.Text = "Clave Prospecto"
        Me.lbl_claveProspectoNew.Visible = False
        '
        'tbx_claveProspectoNew
        '
        Me.tbx_claveProspectoNew.Control_Siguiente = Nothing
        Me.tbx_claveProspectoNew.Filtrado = True
        Me.tbx_claveProspectoNew.Location = New System.Drawing.Point(287, 9)
        Me.tbx_claveProspectoNew.MaxLength = 12
        Me.tbx_claveProspectoNew.Name = "tbx_claveProspectoNew"
        Me.tbx_claveProspectoNew.Size = New System.Drawing.Size(89, 20)
        Me.tbx_claveProspectoNew.TabIndex = 7
        Me.tbx_claveProspectoNew.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_claveProspectoNew.Visible = False
        '
        'tbx_SeleccioneCP
        '
        Me.tbx_SeleccioneCP.Control_Siguiente = Me.cmb_SeleccioneCP
        Me.tbx_SeleccioneCP.Filtrado = True
        Me.tbx_SeleccioneCP.Location = New System.Drawing.Point(112, 32)
        Me.tbx_SeleccioneCP.MaxLength = 12
        Me.tbx_SeleccioneCP.Name = "tbx_SeleccioneCP"
        Me.tbx_SeleccioneCP.Size = New System.Drawing.Size(85, 20)
        Me.tbx_SeleccioneCP.TabIndex = 3
        Me.tbx_SeleccioneCP.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_SeleccioneCP
        '
        Me.cmb_SeleccioneCP.Clave = "Clave_Cliente"
        Me.cmb_SeleccioneCP.Control_Siguiente = Me.tbx_NombreF
        Me.cmb_SeleccioneCP.DisplayMember = "Nombre_Comercial"
        Me.cmb_SeleccioneCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SeleccioneCP.Empresa = False
        Me.cmb_SeleccioneCP.Filtro = Me.tbx_SeleccioneCP
        Me.cmb_SeleccioneCP.FormattingEnabled = True
        Me.cmb_SeleccioneCP.Location = New System.Drawing.Point(203, 32)
        Me.cmb_SeleccioneCP.MaxDropDownItems = 20
        Me.cmb_SeleccioneCP.Name = "cmb_SeleccioneCP"
        Me.cmb_SeleccioneCP.Pista = True
        Me.cmb_SeleccioneCP.Size = New System.Drawing.Size(462, 21)
        Me.cmb_SeleccioneCP.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_SeleccioneCP.Sucursal = True
        Me.cmb_SeleccioneCP.TabIndex = 4
        Me.cmb_SeleccioneCP.Tipo = 0
        Me.cmb_SeleccioneCP.ValueMember = "Id_Cliente"
        '
        'tbx_NombreF
        '
        Me.tbx_NombreF.Control_Siguiente = Me.tbx_RFC
        Me.tbx_NombreF.Filtrado = True
        Me.tbx_NombreF.Location = New System.Drawing.Point(110, 19)
        Me.tbx_NombreF.MaxLength = 150
        Me.tbx_NombreF.Name = "tbx_NombreF"
        Me.tbx_NombreF.Size = New System.Drawing.Size(404, 20)
        Me.tbx_NombreF.TabIndex = 1
        Me.tbx_NombreF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_RFC
        '
        Me.tbx_RFC.Control_Siguiente = Me.tbx_CalleF
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(554, 19)
        Me.tbx_RFC.MaxLength = 13
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.Size = New System.Drawing.Size(112, 20)
        Me.tbx_RFC.TabIndex = 3
        Me.tbx_RFC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CalleF
        '
        Me.tbx_CalleF.Control_Siguiente = Me.tbx_EntreF1
        Me.tbx_CalleF.Filtrado = True
        Me.tbx_CalleF.Location = New System.Drawing.Point(110, 45)
        Me.tbx_CalleF.MaxLength = 100
        Me.tbx_CalleF.Name = "tbx_CalleF"
        Me.tbx_CalleF.Size = New System.Drawing.Size(228, 20)
        Me.tbx_CalleF.TabIndex = 5
        Me.tbx_CalleF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreF1
        '
        Me.tbx_EntreF1.Control_Siguiente = Me.tbx_EntreF2
        Me.tbx_EntreF1.Filtrado = True
        Me.tbx_EntreF1.Location = New System.Drawing.Point(382, 45)
        Me.tbx_EntreF1.MaxLength = 100
        Me.tbx_EntreF1.Name = "tbx_EntreF1"
        Me.tbx_EntreF1.Size = New System.Drawing.Size(132, 20)
        Me.tbx_EntreF1.TabIndex = 7
        Me.tbx_EntreF1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreF2
        '
        Me.tbx_EntreF2.Control_Siguiente = Me.tbx_NumeroF
        Me.tbx_EntreF2.Filtrado = True
        Me.tbx_EntreF2.Location = New System.Drawing.Point(534, 45)
        Me.tbx_EntreF2.MaxLength = 100
        Me.tbx_EntreF2.Name = "tbx_EntreF2"
        Me.tbx_EntreF2.Size = New System.Drawing.Size(132, 20)
        Me.tbx_EntreF2.TabIndex = 9
        Me.tbx_EntreF2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroF
        '
        Me.tbx_NumeroF.Control_Siguiente = Me.tbx_IntF
        Me.tbx_NumeroF.Filtrado = True
        Me.tbx_NumeroF.Location = New System.Drawing.Point(110, 68)
        Me.tbx_NumeroF.MaxLength = 10
        Me.tbx_NumeroF.Name = "tbx_NumeroF"
        Me.tbx_NumeroF.Size = New System.Drawing.Size(65, 20)
        Me.tbx_NumeroF.TabIndex = 11
        Me.tbx_NumeroF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_IntF
        '
        Me.tbx_IntF.Control_Siguiente = Me.tbx_ColoniaF
        Me.tbx_IntF.Filtrado = True
        Me.tbx_IntF.Location = New System.Drawing.Point(229, 68)
        Me.tbx_IntF.MaxLength = 10
        Me.tbx_IntF.Name = "tbx_IntF"
        Me.tbx_IntF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_IntF.TabIndex = 13
        Me.tbx_IntF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_ColoniaF
        '
        Me.tbx_ColoniaF.Control_Siguiente = Me.tbx_CPF
        Me.tbx_ColoniaF.Filtrado = True
        Me.tbx_ColoniaF.Location = New System.Drawing.Point(333, 68)
        Me.tbx_ColoniaF.MaxLength = 100
        Me.tbx_ColoniaF.Name = "tbx_ColoniaF"
        Me.tbx_ColoniaF.Size = New System.Drawing.Size(235, 20)
        Me.tbx_ColoniaF.TabIndex = 15
        Me.tbx_ColoniaF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CPF
        '
        Me.tbx_CPF.Control_Siguiente = Me.cmb_PaisF
        Me.tbx_CPF.Filtrado = False
        Me.tbx_CPF.Location = New System.Drawing.Point(601, 68)
        Me.tbx_CPF.MaxLength = 10
        Me.tbx_CPF.Name = "tbx_CPF"
        Me.tbx_CPF.Size = New System.Drawing.Size(65, 20)
        Me.tbx_CPF.TabIndex = 17
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
        Me.cmb_PaisF.Location = New System.Drawing.Point(110, 91)
        Me.cmb_PaisF.MaxDropDownItems = 20
        Me.cmb_PaisF.Name = "cmb_PaisF"
        Me.cmb_PaisF.Pista = True
        Me.cmb_PaisF.Size = New System.Drawing.Size(228, 21)
        Me.cmb_PaisF.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_PaisF.Sucursal = False
        Me.cmb_PaisF.TabIndex = 19
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
        Me.cmb_EstadoF.Location = New System.Drawing.Point(438, 91)
        Me.cmb_EstadoF.MaxDropDownItems = 20
        Me.cmb_EstadoF.Name = "cmb_EstadoF"
        Me.cmb_EstadoF.Pista = True
        Me.cmb_EstadoF.Size = New System.Drawing.Size(228, 21)
        Me.cmb_EstadoF.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_EstadoF.Sucursal = False
        Me.cmb_EstadoF.TabIndex = 21
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
        Me.cmb_CiudadF.Location = New System.Drawing.Point(110, 115)
        Me.cmb_CiudadF.MaxDropDownItems = 20
        Me.cmb_CiudadF.Name = "cmb_CiudadF"
        Me.cmb_CiudadF.Pista = True
        Me.cmb_CiudadF.Size = New System.Drawing.Size(228, 21)
        Me.cmb_CiudadF.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_CiudadF.Sucursal = False
        Me.cmb_CiudadF.TabIndex = 23
        Me.cmb_CiudadF.Tipo = 0
        Me.cmb_CiudadF.ValueMember = "Id_Ciudad"
        '
        'cmb_ZonaF
        '
        Me.cmb_ZonaF.Clave = Nothing
        Me.cmb_ZonaF.Control_Siguiente = Me.lbl_NombreC
        Me.cmb_ZonaF.DisplayMember = "Nombre"
        Me.cmb_ZonaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ZonaF.Empresa = False
        Me.cmb_ZonaF.Filtro = Nothing
        Me.cmb_ZonaF.FormattingEnabled = True
        Me.cmb_ZonaF.Location = New System.Drawing.Point(438, 115)
        Me.cmb_ZonaF.MaxDropDownItems = 20
        Me.cmb_ZonaF.Name = "cmb_ZonaF"
        Me.cmb_ZonaF.Pista = True
        Me.cmb_ZonaF.Size = New System.Drawing.Size(228, 21)
        Me.cmb_ZonaF.StoredProcedure = "Cat_ZonasCiudades_Get"
        Me.cmb_ZonaF.Sucursal = False
        Me.cmb_ZonaF.TabIndex = 25
        Me.cmb_ZonaF.Tipo = 0
        Me.cmb_ZonaF.ValueMember = "Id_Zona"
        '
        'tbx_NombreCorto
        '
        Me.tbx_NombreCorto.Control_Siguiente = Me.tbx_CalleC
        Me.tbx_NombreCorto.Filtrado = True
        Me.tbx_NombreCorto.Location = New System.Drawing.Point(692, 17)
        Me.tbx_NombreCorto.MaxLength = 25
        Me.tbx_NombreCorto.Name = "tbx_NombreCorto"
        Me.tbx_NombreCorto.Size = New System.Drawing.Size(122, 20)
        Me.tbx_NombreCorto.TabIndex = 4
        Me.tbx_NombreCorto.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CalleC
        '
        Me.tbx_CalleC.Control_Siguiente = Me.tbx_EntreC1
        Me.tbx_CalleC.Filtrado = True
        Me.tbx_CalleC.Location = New System.Drawing.Point(110, 40)
        Me.tbx_CalleC.MaxLength = 100
        Me.tbx_CalleC.Name = "tbx_CalleC"
        Me.tbx_CalleC.Size = New System.Drawing.Size(228, 20)
        Me.tbx_CalleC.TabIndex = 6
        Me.tbx_CalleC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreC1
        '
        Me.tbx_EntreC1.Control_Siguiente = Me.tbx_EntreC2
        Me.tbx_EntreC1.Filtrado = True
        Me.tbx_EntreC1.Location = New System.Drawing.Point(382, 40)
        Me.tbx_EntreC1.MaxLength = 100
        Me.tbx_EntreC1.Name = "tbx_EntreC1"
        Me.tbx_EntreC1.Size = New System.Drawing.Size(132, 20)
        Me.tbx_EntreC1.TabIndex = 8
        Me.tbx_EntreC1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreC2
        '
        Me.tbx_EntreC2.Control_Siguiente = Me.tbx_NumeroF
        Me.tbx_EntreC2.Filtrado = True
        Me.tbx_EntreC2.Location = New System.Drawing.Point(534, 40)
        Me.tbx_EntreC2.MaxLength = 100
        Me.tbx_EntreC2.Name = "tbx_EntreC2"
        Me.tbx_EntreC2.Size = New System.Drawing.Size(132, 20)
        Me.tbx_EntreC2.TabIndex = 10
        Me.tbx_EntreC2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Longitud
        '
        Me.tbx_Longitud.Control_Siguiente = Me.btn_MensajeAlerta
        Me.tbx_Longitud.Filtrado = True
        Me.tbx_Longitud.Location = New System.Drawing.Point(590, 186)
        Me.tbx_Longitud.MaxLength = 11
        Me.tbx_Longitud.Name = "tbx_Longitud"
        Me.tbx_Longitud.Size = New System.Drawing.Size(76, 20)
        Me.tbx_Longitud.TabIndex = 48
        Me.tbx_Longitud.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Latitud
        '
        Me.tbx_Latitud.Control_Siguiente = Me.tbx_Longitud
        Me.tbx_Latitud.Filtrado = True
        Me.tbx_Latitud.Location = New System.Drawing.Point(438, 188)
        Me.tbx_Latitud.MaxLength = 11
        Me.tbx_Latitud.Name = "tbx_Latitud"
        Me.tbx_Latitud.Size = New System.Drawing.Size(76, 20)
        Me.tbx_Latitud.TabIndex = 46
        Me.tbx_Latitud.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_CPC
        '
        Me.tbx_CPC.Control_Siguiente = Me.cmb_PaisC
        Me.tbx_CPC.Filtrado = False
        Me.tbx_CPC.Location = New System.Drawing.Point(601, 63)
        Me.tbx_CPC.MaxLength = 10
        Me.tbx_CPC.Name = "tbx_CPC"
        Me.tbx_CPC.Size = New System.Drawing.Size(65, 20)
        Me.tbx_CPC.TabIndex = 18
        Me.tbx_CPC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_PaisC
        '
        Me.cmb_PaisC.Clave = Nothing
        Me.cmb_PaisC.Control_Siguiente = Me.cmb_EstadoC
        Me.cmb_PaisC.DisplayMember = "Nombre"
        Me.cmb_PaisC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PaisC.Empresa = False
        Me.cmb_PaisC.Filtro = Nothing
        Me.cmb_PaisC.FormattingEnabled = True
        Me.cmb_PaisC.Location = New System.Drawing.Point(110, 86)
        Me.cmb_PaisC.MaxDropDownItems = 20
        Me.cmb_PaisC.Name = "cmb_PaisC"
        Me.cmb_PaisC.Pista = True
        Me.cmb_PaisC.Size = New System.Drawing.Size(228, 21)
        Me.cmb_PaisC.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_PaisC.Sucursal = False
        Me.cmb_PaisC.TabIndex = 20
        Me.cmb_PaisC.Tipo = 0
        Me.cmb_PaisC.ValueMember = "Id_Pais"
        '
        'cmb_EstadoC
        '
        Me.cmb_EstadoC.Clave = Nothing
        Me.cmb_EstadoC.Control_Siguiente = Me.cmb_CiudadC
        Me.cmb_EstadoC.DisplayMember = "Nombre"
        Me.cmb_EstadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EstadoC.Empresa = False
        Me.cmb_EstadoC.Filtro = Nothing
        Me.cmb_EstadoC.FormattingEnabled = True
        Me.cmb_EstadoC.Location = New System.Drawing.Point(438, 86)
        Me.cmb_EstadoC.MaxDropDownItems = 20
        Me.cmb_EstadoC.Name = "cmb_EstadoC"
        Me.cmb_EstadoC.Pista = True
        Me.cmb_EstadoC.Size = New System.Drawing.Size(228, 21)
        Me.cmb_EstadoC.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_EstadoC.Sucursal = False
        Me.cmb_EstadoC.TabIndex = 23
        Me.cmb_EstadoC.Tipo = 0
        Me.cmb_EstadoC.ValueMember = "Id_Estado"
        '
        'cmb_CiudadC
        '
        Me.cmb_CiudadC.Clave = Nothing
        Me.cmb_CiudadC.Control_Siguiente = Me.cmb_ZonaC
        Me.cmb_CiudadC.DisplayMember = "Nombre"
        Me.cmb_CiudadC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadC.Empresa = False
        Me.cmb_CiudadC.Filtro = Nothing
        Me.cmb_CiudadC.FormattingEnabled = True
        Me.cmb_CiudadC.Location = New System.Drawing.Point(110, 110)
        Me.cmb_CiudadC.MaxDropDownItems = 20
        Me.cmb_CiudadC.Name = "cmb_CiudadC"
        Me.cmb_CiudadC.Pista = True
        Me.cmb_CiudadC.Size = New System.Drawing.Size(228, 21)
        Me.cmb_CiudadC.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_CiudadC.Sucursal = False
        Me.cmb_CiudadC.TabIndex = 26
        Me.cmb_CiudadC.Tipo = 0
        Me.cmb_CiudadC.ValueMember = "Id_Ciudad"
        '
        'cmb_ZonaC
        '
        Me.cmb_ZonaC.Clave = Nothing
        Me.cmb_ZonaC.Control_Siguiente = Me.cmb_Giro
        Me.cmb_ZonaC.DisplayMember = "Nombre"
        Me.cmb_ZonaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ZonaC.Empresa = False
        Me.cmb_ZonaC.Filtro = Nothing
        Me.cmb_ZonaC.FormattingEnabled = True
        Me.cmb_ZonaC.Location = New System.Drawing.Point(438, 110)
        Me.cmb_ZonaC.MaxDropDownItems = 20
        Me.cmb_ZonaC.Name = "cmb_ZonaC"
        Me.cmb_ZonaC.Pista = True
        Me.cmb_ZonaC.Size = New System.Drawing.Size(228, 21)
        Me.cmb_ZonaC.StoredProcedure = "Cat_ZonasCiudades_Get"
        Me.cmb_ZonaC.Sucursal = False
        Me.cmb_ZonaC.TabIndex = 29
        Me.cmb_ZonaC.Tipo = 0
        Me.cmb_ZonaC.ValueMember = "Id_Zona"
        '
        'cmb_Giro
        '
        Me.cmb_Giro.Clave = Nothing
        Me.cmb_Giro.Control_Siguiente = Me.tbx_ClaveRadio
        Me.cmb_Giro.DisplayMember = "Descripcion"
        Me.cmb_Giro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Giro.Empresa = False
        Me.cmb_Giro.Filtro = Nothing
        Me.cmb_Giro.FormattingEnabled = True
        Me.cmb_Giro.Location = New System.Drawing.Point(110, 134)
        Me.cmb_Giro.MaxDropDownItems = 20
        Me.cmb_Giro.Name = "cmb_Giro"
        Me.cmb_Giro.Pista = True
        Me.cmb_Giro.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Giro.StoredProcedure = "Cat_GirosComerciales_Get"
        Me.cmb_Giro.Sucursal = False
        Me.cmb_Giro.TabIndex = 32
        Me.cmb_Giro.Tipo = 0
        Me.cmb_Giro.ValueMember = "Id_Giro"
        '
        'tbx_ClaveRadio
        '
        Me.tbx_ClaveRadio.Control_Siguiente = Me.cmb_Categoria
        Me.tbx_ClaveRadio.Filtrado = True
        Me.tbx_ClaveRadio.Location = New System.Drawing.Point(438, 134)
        Me.tbx_ClaveRadio.MaxLength = 50
        Me.tbx_ClaveRadio.Name = "tbx_ClaveRadio"
        Me.tbx_ClaveRadio.Size = New System.Drawing.Size(228, 20)
        Me.tbx_ClaveRadio.TabIndex = 35
        Me.tbx_ClaveRadio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_Categoria
        '
        Me.cmb_Categoria.Clave = Nothing
        Me.cmb_Categoria.Control_Siguiente = Nothing
        Me.cmb_Categoria.DisplayMember = "Descripcion"
        Me.cmb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Categoria.Empresa = False
        Me.cmb_Categoria.Filtro = Nothing
        Me.cmb_Categoria.FormattingEnabled = True
        Me.cmb_Categoria.Location = New System.Drawing.Point(110, 158)
        Me.cmb_Categoria.MaxDropDownItems = 20
        Me.cmb_Categoria.Name = "cmb_Categoria"
        Me.cmb_Categoria.Pista = True
        Me.cmb_Categoria.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Categoria.StoredProcedure = "Cat_Categorias_Get"
        Me.cmb_Categoria.Sucursal = False
        Me.cmb_Categoria.TabIndex = 37
        Me.cmb_Categoria.Tipo = 0
        Me.cmb_Categoria.ValueMember = "Id_Categoria"
        '
        'tbx_ColoniaC
        '
        Me.tbx_ColoniaC.Control_Siguiente = Me.tbx_CPC
        Me.tbx_ColoniaC.Filtrado = True
        Me.tbx_ColoniaC.Location = New System.Drawing.Point(330, 63)
        Me.tbx_ColoniaC.MaxLength = 100
        Me.tbx_ColoniaC.Name = "tbx_ColoniaC"
        Me.tbx_ColoniaC.Size = New System.Drawing.Size(238, 20)
        Me.tbx_ColoniaC.TabIndex = 16
        Me.tbx_ColoniaC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_IntC
        '
        Me.tbx_IntC.Control_Siguiente = Me.tbx_ColoniaC
        Me.tbx_IntC.Filtrado = True
        Me.tbx_IntC.Location = New System.Drawing.Point(226, 63)
        Me.tbx_IntC.MaxLength = 10
        Me.tbx_IntC.Name = "tbx_IntC"
        Me.tbx_IntC.Size = New System.Drawing.Size(50, 20)
        Me.tbx_IntC.TabIndex = 14
        Me.tbx_IntC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_NumeroC
        '
        Me.tbx_NumeroC.Control_Siguiente = Me.tbx_IntC
        Me.tbx_NumeroC.Filtrado = True
        Me.tbx_NumeroC.Location = New System.Drawing.Point(110, 63)
        Me.tbx_NumeroC.MaxLength = 10
        Me.tbx_NumeroC.Name = "tbx_NumeroC"
        Me.tbx_NumeroC.Size = New System.Drawing.Size(65, 20)
        Me.tbx_NumeroC.TabIndex = 12
        Me.tbx_NumeroC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_NombreC
        '
        Me.tbx_NombreC.Control_Siguiente = Me.tbx_NombreCorto
        Me.tbx_NombreC.Filtrado = True
        Me.tbx_NombreC.Location = New System.Drawing.Point(110, 17)
        Me.tbx_NombreC.MaxLength = 150
        Me.tbx_NombreC.Name = "tbx_NombreC"
        Me.tbx_NombreC.Size = New System.Drawing.Size(487, 20)
        Me.tbx_NombreC.TabIndex = 1
        Me.tbx_NombreC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_NuevoProspecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 554)
        Me.Controls.Add(Me.gbx_ClientePadre)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_DatosC)
        Me.Controls.Add(Me.gbx_DatosF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_NuevoProspecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prospecto Nuevo"
        Me.gbx_DatosC.ResumeLayout(False)
        Me.gbx_DatosC.PerformLayout()
        Me.gbx_Foraneo.ResumeLayout(False)
        Me.gbx_Foraneo.PerformLayout()
        Me.gbx_InicioOp.ResumeLayout(False)
        Me.gbx_TipoCliente.ResumeLayout(False)
        Me.gbx_TipoCliente.PerformLayout()
        Me.gbx_Material.ResumeLayout(False)
        Me.gbx_Material.PerformLayout()
        Me.gbx_DatosF.ResumeLayout(False)
        Me.gbx_DatosF.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_ClientePadre.ResumeLayout(False)
        Me.gbx_ClientePadre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_SeleccioneCP As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_NombreF As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CalleF As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_PaisF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_EstadoF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CiudadF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ZonaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_RFC As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_NombreC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_ClienteP As System.Windows.Forms.Label
    Friend WithEvents lbl_ClientePadre As System.Windows.Forms.Label
    Friend WithEvents cbx_ClienteP As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_DatosC As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_CPC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CPC As System.Windows.Forms.Label
    Friend WithEvents lbl_ColoniaC As System.Windows.Forms.Label
    Friend WithEvents tbx_ColoniaC As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_IntC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_IntC As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NumeroC As System.Windows.Forms.Label
    Friend WithEvents lbl_CalleC As System.Windows.Forms.Label
    Friend WithEvents tbx_CalleC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Foraneo As System.Windows.Forms.Label
    Friend WithEvents lbl_ClaveRadio As System.Windows.Forms.Label
    Friend WithEvents tbx_ClaveRadio As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Categoria As System.Windows.Forms.Label
    Friend WithEvents cmb_Categoria As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Giro As System.Windows.Forms.Label
    Friend WithEvents cmb_Giro As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ZonaC As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CiudadC As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_EstadoC As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_PaisC As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_ZonaC As System.Windows.Forms.Label
    Friend WithEvents lbl_CiudadC As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoC As System.Windows.Forms.Label
    Friend WithEvents lbl_PaisC As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreC As System.Windows.Forms.Label
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
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_NombreComercialA As System.Windows.Forms.Label
    Friend WithEvents lbl_ForaneoA As System.Windows.Forms.Label
    Friend WithEvents lbl_CategoriaA As System.Windows.Forms.Label
    Friend WithEvents lbl_GiroComercialA As System.Windows.Forms.Label
    Friend WithEvents tbx_SeleccioneCP As Modulo_Ventas.cp_Textbox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ZonaA As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoA As System.Windows.Forms.Label
    Friend WithEvents lbl_CiudadA As System.Windows.Forms.Label
    Friend WithEvents lbl_PaisA As System.Windows.Forms.Label
    Friend WithEvents gbx_ClientePadre As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Asterisco As System.Windows.Forms.Label
    Friend WithEvents tbx_Longitud As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Latitud As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Longitud As System.Windows.Forms.Label
    Friend WithEvents lbl_Latitud As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_MensajeAlerta As System.Windows.Forms.Label
    Friend WithEvents lbl_MaterialOperativoA As System.Windows.Forms.Label
    Friend WithEvents lbl_Material As System.Windows.Forms.Label
    Friend WithEvents gbx_Material As System.Windows.Forms.GroupBox
    Friend WithEvents rbn_MaterialNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_MaterialSi As System.Windows.Forms.RadioButton
    Friend WithEvents btn_MensajeAlerta As System.Windows.Forms.Button
    Friend WithEvents rtb_MensajeAlerta As System.Windows.Forms.RichTextBox
    Friend WithEvents Rdb_CajaBancaria As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Otro As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_InicioOp As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_TipoCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_InicioOp As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_Ambos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Traslado As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_SeguridadP As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_EntreF1 As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreF2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_EntreF1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_EntreF2 As System.Windows.Forms.Label
    Friend WithEvents lbl_EntreC2 As System.Windows.Forms.Label
    Friend WithEvents lbl_EntreC1 As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreC2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_EntreC1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_NombreCorto As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NombreCorto As System.Windows.Forms.Label
    Friend WithEvents gbx_Foraneo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ForaneoN As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ForaneoS As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_claveProspectoNew As System.Windows.Forms.Label
    Friend WithEvents tbx_claveProspectoNew As Modulo_Ventas.cp_Textbox
End Class
