<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesHorariosUno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientesHorariosUno))
        Me.gbx_Recoleccion = New System.Windows.Forms.GroupBox()
        Me.rdb_UtilizaCasetNO = New System.Windows.Forms.RadioButton()
        Me.rdb_UtilizaCasetSi = New System.Windows.Forms.RadioButton()
        Me.lbl_UtilizaCaset = New System.Windows.Forms.Label()
        Me.btn_Ayuda = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal1 = New System.Windows.Forms.Label()
        Me.cmb_Sucursal1 = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cmb_H_ClienteO = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cmb_H_DeO = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_AO = New Modulo_Ventas.cp_cmb_Manual()
        Me.tbx_H_ClienteD = New Modulo_Ventas.cp_Textbox()
        Me.cmb_H_ClienteD = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cmb_H_DeD = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_AD = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_Boveda = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_MismoDia = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_DiaEntrega = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_RutaEntrega = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.Btn_GuardarH = New System.Windows.Forms.Button()
        Me.tbx_H_ClienteO = New Modulo_Ventas.cp_Textbox()
        Me.cmb_H_Ruta = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cbx_Permitir = New System.Windows.Forms.CheckBox()
        Me.cmb_H_TipoF = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_H_Frecuencia = New Modulo_Ventas.cp_cmb_Manual()
        Me.dtp_H_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lbl_H_TipoF = New System.Windows.Forms.Label()
        Me.lbl_Ruta = New System.Windows.Forms.Label()
        Me.lbl_H_AO = New System.Windows.Forms.Label()
        Me.lbl_H_DeO = New System.Windows.Forms.Label()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_H_BuscarO = New System.Windows.Forms.Button()
        Me.lbl_H_ClienteO = New System.Windows.Forms.Label()
        Me.lbl_H_Frecuencia = New System.Windows.Forms.Label()
        Me.lbl_H_FechaInicio = New System.Windows.Forms.Label()
        Me.chk_UnicaVez = New System.Windows.Forms.CheckBox()
        Me.lbl_FacturarRE = New System.Windows.Forms.Label()
        Me.lbl_CargoA = New System.Windows.Forms.Label()
        Me.lbl_Sucursal2 = New System.Windows.Forms.Label()
        Me.lbl_H_DiaEntrega = New System.Windows.Forms.Label()
        Me.lbl_H_MismoDia = New System.Windows.Forms.Label()
        Me.lbl_H_Boveda = New System.Windows.Forms.Label()
        Me.lbl_H_AD = New System.Windows.Forms.Label()
        Me.lbl_H_DeD = New System.Windows.Forms.Label()
        Me.lbl_H_ClienteD = New System.Windows.Forms.Label()
        Me.lbl_H_RutaEntrega = New System.Windows.Forms.Label()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.Btn_CancelarH = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbx_Entrega = New System.Windows.Forms.GroupBox()
        Me.cmb_Sucursal2 = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.btn_H_BuscarD = New System.Windows.Forms.Button()
        Me.btn_Agregar2 = New System.Windows.Forms.Button()
        Me.gbx_Cargo = New System.Windows.Forms.GroupBox()
        Me.cmb_CargoA = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_FacturarRE = New Modulo_Ventas.cp_cmb_Manual()
        Me.gbx_Subclientes = New System.Windows.Forms.GroupBox()
        Me.rtb_Subclientes = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbx_NuevoOrigen = New Modulo_Ventas.cp_Textbox()
        Me.cmb_NuevoOrigen = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.gbx_Recoleccion.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Entrega.SuspendLayout()
        Me.gbx_Cargo.SuspendLayout()
        Me.gbx_Subclientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Recoleccion
        '
        Me.gbx_Recoleccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Recoleccion.Controls.Add(Me.rdb_UtilizaCasetNO)
        Me.gbx_Recoleccion.Controls.Add(Me.rdb_UtilizaCasetSi)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_UtilizaCaset)
        Me.gbx_Recoleccion.Controls.Add(Me.btn_Ayuda)
        Me.gbx_Recoleccion.Controls.Add(Me.Label6)
        Me.gbx_Recoleccion.Controls.Add(Me.Label5)
        Me.gbx_Recoleccion.Controls.Add(Me.Label4)
        Me.gbx_Recoleccion.Controls.Add(Me.Label3)
        Me.gbx_Recoleccion.Controls.Add(Me.Label2)
        Me.gbx_Recoleccion.Controls.Add(Me.Label1)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_Sucursal1)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_Sucursal1)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_ClienteO)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_Ruta)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_TipoF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_TipoF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_Ruta)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_Frecuencia)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_AO)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_AO)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_DeO)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_DeO)
        Me.gbx_Recoleccion.Controls.Add(Me.btn_Agregar)
        Me.gbx_Recoleccion.Controls.Add(Me.btn_H_BuscarO)
        Me.gbx_Recoleccion.Controls.Add(Me.tbx_H_ClienteO)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_ClienteO)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_Frecuencia)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_FechaInicio)
        Me.gbx_Recoleccion.Controls.Add(Me.dtp_H_FechaInicio)
        Me.gbx_Recoleccion.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Recoleccion.Name = "gbx_Recoleccion"
        Me.gbx_Recoleccion.Size = New System.Drawing.Size(713, 193)
        Me.gbx_Recoleccion.TabIndex = 0
        Me.gbx_Recoleccion.TabStop = False
        Me.gbx_Recoleccion.Text = "Recolección"
        '
        'rdb_UtilizaCasetNO
        '
        Me.rdb_UtilizaCasetNO.AutoSize = True
        Me.rdb_UtilizaCasetNO.Location = New System.Drawing.Point(140, 165)
        Me.rdb_UtilizaCasetNO.Name = "rdb_UtilizaCasetNO"
        Me.rdb_UtilizaCasetNO.Size = New System.Drawing.Size(41, 17)
        Me.rdb_UtilizaCasetNO.TabIndex = 29
        Me.rdb_UtilizaCasetNO.TabStop = True
        Me.rdb_UtilizaCasetNO.Text = "NO"
        Me.rdb_UtilizaCasetNO.UseVisualStyleBackColor = True
        '
        'rdb_UtilizaCasetSi
        '
        Me.rdb_UtilizaCasetSi.AutoSize = True
        Me.rdb_UtilizaCasetSi.Location = New System.Drawing.Point(95, 165)
        Me.rdb_UtilizaCasetSi.Name = "rdb_UtilizaCasetSi"
        Me.rdb_UtilizaCasetSi.Size = New System.Drawing.Size(35, 17)
        Me.rdb_UtilizaCasetSi.TabIndex = 28
        Me.rdb_UtilizaCasetSi.TabStop = True
        Me.rdb_UtilizaCasetSi.Text = "SI"
        Me.rdb_UtilizaCasetSi.UseVisualStyleBackColor = True
        '
        'lbl_UtilizaCaset
        '
        Me.lbl_UtilizaCaset.AutoSize = True
        Me.lbl_UtilizaCaset.Location = New System.Drawing.Point(21, 165)
        Me.lbl_UtilizaCaset.Name = "lbl_UtilizaCaset"
        Me.lbl_UtilizaCaset.Size = New System.Drawing.Size(68, 13)
        Me.lbl_UtilizaCaset.TabIndex = 27
        Me.lbl_UtilizaCaset.Text = "Utiliza Caset:"
        '
        'btn_Ayuda
        '
        Me.btn_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ayuda.Image = Global.Modulo_Ventas.My.Resources.Resources.help_contents
        Me.btn_Ayuda.Location = New System.Drawing.Point(686, 7)
        Me.btn_Ayuda.Name = "btn_Ayuda"
        Me.btn_Ayuda.Size = New System.Drawing.Size(26, 24)
        Me.btn_Ayuda.TabIndex = 26
        Me.btn_Ayuda.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(299, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(634, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(435, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(198, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(504, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(222, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "*"
        '
        'lbl_Sucursal1
        '
        Me.lbl_Sucursal1.AutoSize = True
        Me.lbl_Sucursal1.Location = New System.Drawing.Point(41, 88)
        Me.lbl_Sucursal1.Name = "lbl_Sucursal1"
        Me.lbl_Sucursal1.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Sucursal1.TabIndex = 11
        Me.lbl_Sucursal1.Text = "Sucursal"
        '
        'cmb_Sucursal1
        '
        Me.cmb_Sucursal1.Clave = Nothing
        Me.cmb_Sucursal1.Control_Siguiente = Nothing
        Me.cmb_Sucursal1.DisplayMember = "Nombre"
        Me.cmb_Sucursal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sucursal1.Empresa = True
        Me.cmb_Sucursal1.Filtro = Nothing
        Me.cmb_Sucursal1.FormattingEnabled = True
        Me.cmb_Sucursal1.Location = New System.Drawing.Point(95, 85)
        Me.cmb_Sucursal1.MaxDropDownItems = 20
        Me.cmb_Sucursal1.Name = "cmb_Sucursal1"
        Me.cmb_Sucursal1.Pista = True
        Me.cmb_Sucursal1.Size = New System.Drawing.Size(336, 21)
        Me.cmb_Sucursal1.StoredProcedure = "Cat_SucursalesCombo_Get"
        Me.cmb_Sucursal1.Sucursal = False
        Me.cmb_Sucursal1.TabIndex = 12
        Me.cmb_Sucursal1.Tipo = 0
        Me.cmb_Sucursal1.ValueMember = "Id_Sucursal"
        '
        'cmb_H_ClienteO
        '
        Me.cmb_H_ClienteO.Clave = "Clave_Cliente"
        Me.cmb_H_ClienteO.Control_Siguiente = Me.cmb_H_DeO
        Me.cmb_H_ClienteO.DisplayMember = "Nombre_Comercial"
        Me.cmb_H_ClienteO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_ClienteO.Empresa = False
        Me.cmb_H_ClienteO.Filtro = Me.tbx_H_ClienteO
        Me.cmb_H_ClienteO.FormattingEnabled = True
        Me.cmb_H_ClienteO.Location = New System.Drawing.Point(178, 109)
        Me.cmb_H_ClienteO.MaxDropDownItems = 20
        Me.cmb_H_ClienteO.Name = "cmb_H_ClienteO"
        Me.cmb_H_ClienteO.Pista = False
        Me.cmb_H_ClienteO.Size = New System.Drawing.Size(450, 21)
        Me.cmb_H_ClienteO.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_H_ClienteO.Sucursal = False
        Me.cmb_H_ClienteO.TabIndex = 16
        Me.cmb_H_ClienteO.Tipo = 0
        Me.cmb_H_ClienteO.ValueMember = "Id_Cliente"
        '
        'cmb_H_DeO
        '
        Me.cmb_H_DeO.Control_Siguiente = Me.cmb_H_AO
        Me.cmb_H_DeO.DisplayMember = "display"
        Me.cmb_H_DeO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_DeO.FormattingEnabled = True
        Me.cmb_H_DeO.Location = New System.Drawing.Point(95, 133)
        Me.cmb_H_DeO.MaxDropDownItems = 20
        Me.cmb_H_DeO.Name = "cmb_H_DeO"
        Me.cmb_H_DeO.Size = New System.Drawing.Size(86, 21)
        Me.cmb_H_DeO.TabIndex = 22
        Me.cmb_H_DeO.ValueMember = "value"
        '
        'cmb_H_AO
        '
        Me.cmb_H_AO.Control_Siguiente = Me.tbx_H_ClienteD
        Me.cmb_H_AO.DisplayMember = "display"
        Me.cmb_H_AO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_AO.FormattingEnabled = True
        Me.cmb_H_AO.Location = New System.Drawing.Point(207, 133)
        Me.cmb_H_AO.MaxDropDownItems = 20
        Me.cmb_H_AO.Name = "cmb_H_AO"
        Me.cmb_H_AO.Size = New System.Drawing.Size(86, 21)
        Me.cmb_H_AO.TabIndex = 24
        Me.cmb_H_AO.ValueMember = "value"
        '
        'tbx_H_ClienteD
        '
        Me.tbx_H_ClienteD.Control_Siguiente = Me.cmb_H_ClienteD
        Me.tbx_H_ClienteD.Filtrado = True
        Me.tbx_H_ClienteD.Location = New System.Drawing.Point(95, 42)
        Me.tbx_H_ClienteD.MaxLength = 20
        Me.tbx_H_ClienteD.Name = "tbx_H_ClienteD"
        Me.tbx_H_ClienteD.Size = New System.Drawing.Size(77, 20)
        Me.tbx_H_ClienteD.TabIndex = 4
        Me.tbx_H_ClienteD.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_H_ClienteD
        '
        Me.cmb_H_ClienteD.Clave = "Clave_Cliente"
        Me.cmb_H_ClienteD.Control_Siguiente = Me.cmb_H_DeD
        Me.cmb_H_ClienteD.DisplayMember = "Nombre_Comercial"
        Me.cmb_H_ClienteD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_ClienteD.Empresa = False
        Me.cmb_H_ClienteD.Filtro = Me.tbx_H_ClienteD
        Me.cmb_H_ClienteD.FormattingEnabled = True
        Me.cmb_H_ClienteD.Location = New System.Drawing.Point(178, 41)
        Me.cmb_H_ClienteD.MaxDropDownItems = 20
        Me.cmb_H_ClienteD.Name = "cmb_H_ClienteD"
        Me.cmb_H_ClienteD.Pista = False
        Me.cmb_H_ClienteD.Size = New System.Drawing.Size(450, 21)
        Me.cmb_H_ClienteD.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_H_ClienteD.Sucursal = False
        Me.cmb_H_ClienteD.TabIndex = 5
        Me.cmb_H_ClienteD.Tipo = 0
        Me.cmb_H_ClienteD.ValueMember = "Id_Cliente"
        '
        'cmb_H_DeD
        '
        Me.cmb_H_DeD.Control_Siguiente = Me.cmb_H_AD
        Me.cmb_H_DeD.DisplayMember = "display"
        Me.cmb_H_DeD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_DeD.FormattingEnabled = True
        Me.cmb_H_DeD.Location = New System.Drawing.Point(95, 65)
        Me.cmb_H_DeD.MaxDropDownItems = 20
        Me.cmb_H_DeD.Name = "cmb_H_DeD"
        Me.cmb_H_DeD.Size = New System.Drawing.Size(86, 21)
        Me.cmb_H_DeD.TabIndex = 10
        Me.cmb_H_DeD.ValueMember = "value"
        '
        'cmb_H_AD
        '
        Me.cmb_H_AD.Control_Siguiente = Me.cmb_H_Boveda
        Me.cmb_H_AD.DisplayMember = "display"
        Me.cmb_H_AD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_AD.FormattingEnabled = True
        Me.cmb_H_AD.Location = New System.Drawing.Point(207, 65)
        Me.cmb_H_AD.MaxDropDownItems = 20
        Me.cmb_H_AD.Name = "cmb_H_AD"
        Me.cmb_H_AD.Size = New System.Drawing.Size(86, 21)
        Me.cmb_H_AD.TabIndex = 12
        Me.cmb_H_AD.ValueMember = "value"
        '
        'cmb_H_Boveda
        '
        Me.cmb_H_Boveda.Control_Siguiente = Me.cmb_H_MismoDia
        Me.cmb_H_Boveda.DisplayMember = "display"
        Me.cmb_H_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_Boveda.FormattingEnabled = True
        Me.cmb_H_Boveda.Location = New System.Drawing.Point(95, 89)
        Me.cmb_H_Boveda.MaxDropDownItems = 20
        Me.cmb_H_Boveda.Name = "cmb_H_Boveda"
        Me.cmb_H_Boveda.Size = New System.Drawing.Size(89, 21)
        Me.cmb_H_Boveda.TabIndex = 15
        Me.cmb_H_Boveda.ValueMember = "value"
        '
        'cmb_H_MismoDia
        '
        Me.cmb_H_MismoDia.Control_Siguiente = Me.cmb_H_DiaEntrega
        Me.cmb_H_MismoDia.DisplayMember = "display"
        Me.cmb_H_MismoDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_MismoDia.FormattingEnabled = True
        Me.cmb_H_MismoDia.Location = New System.Drawing.Point(337, 88)
        Me.cmb_H_MismoDia.MaxDropDownItems = 20
        Me.cmb_H_MismoDia.Name = "cmb_H_MismoDia"
        Me.cmb_H_MismoDia.Size = New System.Drawing.Size(94, 21)
        Me.cmb_H_MismoDia.TabIndex = 18
        Me.cmb_H_MismoDia.ValueMember = "value"
        '
        'cmb_H_DiaEntrega
        '
        Me.cmb_H_DiaEntrega.Control_Siguiente = Me.cmb_H_RutaEntrega
        Me.cmb_H_DiaEntrega.DisplayMember = "display"
        Me.cmb_H_DiaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_DiaEntrega.Enabled = False
        Me.cmb_H_DiaEntrega.FormattingEnabled = True
        Me.cmb_H_DiaEntrega.Location = New System.Drawing.Point(95, 113)
        Me.cmb_H_DiaEntrega.MaxDropDownItems = 20
        Me.cmb_H_DiaEntrega.Name = "cmb_H_DiaEntrega"
        Me.cmb_H_DiaEntrega.Size = New System.Drawing.Size(198, 21)
        Me.cmb_H_DiaEntrega.TabIndex = 21
        Me.cmb_H_DiaEntrega.ValueMember = "value"
        '
        'cmb_H_RutaEntrega
        '
        Me.cmb_H_RutaEntrega.Clave = Nothing
        Me.cmb_H_RutaEntrega.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_H_RutaEntrega.DisplayMember = "Descripcion"
        Me.cmb_H_RutaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_RutaEntrega.Empresa = False
        Me.cmb_H_RutaEntrega.Enabled = False
        Me.cmb_H_RutaEntrega.Filtro = Nothing
        Me.cmb_H_RutaEntrega.FormattingEnabled = True
        Me.cmb_H_RutaEntrega.Location = New System.Drawing.Point(95, 137)
        Me.cmb_H_RutaEntrega.MaxDropDownItems = 20
        Me.cmb_H_RutaEntrega.Name = "cmb_H_RutaEntrega"
        Me.cmb_H_RutaEntrega.Pista = True
        Me.cmb_H_RutaEntrega.Size = New System.Drawing.Size(334, 21)
        Me.cmb_H_RutaEntrega.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_H_RutaEntrega.Sucursal = True
        Me.cmb_H_RutaEntrega.TabIndex = 23
        Me.cmb_H_RutaEntrega.Tipo = 0
        Me.cmb_H_RutaEntrega.ValueMember = "Id_Ruta"
        '
        'Btn_GuardarH
        '
        Me.Btn_GuardarH.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.Btn_GuardarH.Location = New System.Drawing.Point(7, 13)
        Me.Btn_GuardarH.Name = "Btn_GuardarH"
        Me.Btn_GuardarH.Size = New System.Drawing.Size(140, 30)
        Me.Btn_GuardarH.TabIndex = 0
        Me.Btn_GuardarH.Text = "&Guardar"
        Me.Btn_GuardarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_GuardarH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_GuardarH.UseVisualStyleBackColor = True
        '
        'tbx_H_ClienteO
        '
        Me.tbx_H_ClienteO.Control_Siguiente = Me.cmb_H_ClienteO
        Me.tbx_H_ClienteO.Filtrado = True
        Me.tbx_H_ClienteO.Location = New System.Drawing.Point(95, 109)
        Me.tbx_H_ClienteO.MaxLength = 20
        Me.tbx_H_ClienteO.Name = "tbx_H_ClienteO"
        Me.tbx_H_ClienteO.Size = New System.Drawing.Size(77, 20)
        Me.tbx_H_ClienteO.TabIndex = 15
        Me.tbx_H_ClienteO.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_H_Ruta
        '
        Me.cmb_H_Ruta.Clave = Nothing
        Me.cmb_H_Ruta.Control_Siguiente = Me.cbx_Permitir
        Me.cmb_H_Ruta.DisplayMember = "Descripcion"
        Me.cmb_H_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_Ruta.Empresa = False
        Me.cmb_H_Ruta.Filtro = Nothing
        Me.cmb_H_Ruta.FormattingEnabled = True
        Me.cmb_H_Ruta.Location = New System.Drawing.Point(95, 37)
        Me.cmb_H_Ruta.MaxDropDownItems = 20
        Me.cmb_H_Ruta.Name = "cmb_H_Ruta"
        Me.cmb_H_Ruta.Pista = True
        Me.cmb_H_Ruta.Size = New System.Drawing.Size(336, 21)
        Me.cmb_H_Ruta.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_H_Ruta.Sucursal = True
        Me.cmb_H_Ruta.TabIndex = 4
        Me.cmb_H_Ruta.Tipo = 0
        Me.cmb_H_Ruta.ValueMember = "Id_Ruta"
        '
        'cbx_Permitir
        '
        Me.cbx_Permitir.AutoSize = True
        Me.cbx_Permitir.Location = New System.Drawing.Point(95, 61)
        Me.cbx_Permitir.Name = "cbx_Permitir"
        Me.cbx_Permitir.Size = New System.Drawing.Size(470, 17)
        Me.cbx_Permitir.TabIndex = 7
        Me.cbx_Permitir.Text = "&Permitir que los horarios de servicio también se establezcan para las sucursales" &
    " de este cliente"
        Me.cbx_Permitir.UseVisualStyleBackColor = True
        Me.cbx_Permitir.Visible = False
        '
        'cmb_H_TipoF
        '
        Me.cmb_H_TipoF.Control_Siguiente = Me.cmb_H_Frecuencia
        Me.cmb_H_TipoF.DisplayMember = "display"
        Me.cmb_H_TipoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_TipoF.FormattingEnabled = True
        Me.cmb_H_TipoF.Location = New System.Drawing.Point(95, 61)
        Me.cmb_H_TipoF.MaxDropDownItems = 20
        Me.cmb_H_TipoF.Name = "cmb_H_TipoF"
        Me.cmb_H_TipoF.Size = New System.Drawing.Size(121, 21)
        Me.cmb_H_TipoF.TabIndex = 6
        Me.cmb_H_TipoF.ValueMember = "value"
        '
        'cmb_H_Frecuencia
        '
        Me.cmb_H_Frecuencia.Control_Siguiente = Me.dtp_H_FechaInicio
        Me.cmb_H_Frecuencia.DisplayMember = "display"
        Me.cmb_H_Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_Frecuencia.FormattingEnabled = True
        Me.cmb_H_Frecuencia.Location = New System.Drawing.Point(299, 61)
        Me.cmb_H_Frecuencia.MaxDropDownItems = 20
        Me.cmb_H_Frecuencia.Name = "cmb_H_Frecuencia"
        Me.cmb_H_Frecuencia.Size = New System.Drawing.Size(201, 21)
        Me.cmb_H_Frecuencia.TabIndex = 9
        Me.cmb_H_Frecuencia.ValueMember = "value"
        '
        'dtp_H_FechaInicio
        '
        Me.dtp_H_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_H_FechaInicio.Location = New System.Drawing.Point(97, 15)
        Me.dtp_H_FechaInicio.Name = "dtp_H_FechaInicio"
        Me.dtp_H_FechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_H_FechaInicio.TabIndex = 1
        '
        'lbl_H_TipoF
        '
        Me.lbl_H_TipoF.AutoSize = True
        Me.lbl_H_TipoF.Location = New System.Drawing.Point(61, 66)
        Me.lbl_H_TipoF.Name = "lbl_H_TipoF"
        Me.lbl_H_TipoF.Size = New System.Drawing.Size(28, 13)
        Me.lbl_H_TipoF.TabIndex = 5
        Me.lbl_H_TipoF.Text = "Tipo"
        '
        'lbl_Ruta
        '
        Me.lbl_Ruta.AutoSize = True
        Me.lbl_Ruta.Location = New System.Drawing.Point(59, 40)
        Me.lbl_Ruta.Name = "lbl_Ruta"
        Me.lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Ruta.TabIndex = 3
        Me.lbl_Ruta.Text = "Ruta"
        '
        'lbl_H_AO
        '
        Me.lbl_H_AO.AutoSize = True
        Me.lbl_H_AO.Location = New System.Drawing.Point(187, 136)
        Me.lbl_H_AO.Name = "lbl_H_AO"
        Me.lbl_H_AO.Size = New System.Drawing.Size(14, 13)
        Me.lbl_H_AO.TabIndex = 23
        Me.lbl_H_AO.Text = "A"
        '
        'lbl_H_DeO
        '
        Me.lbl_H_DeO.AutoSize = True
        Me.lbl_H_DeO.Location = New System.Drawing.Point(65, 136)
        Me.lbl_H_DeO.Name = "lbl_H_DeO"
        Me.lbl_H_DeO.Size = New System.Drawing.Size(24, 13)
        Me.lbl_H_DeO.TabIndex = 21
        Me.lbl_H_DeO.Text = "De:"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.edit_add
        Me.btn_Agregar.Location = New System.Drawing.Point(679, 109)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(26, 23)
        Me.btn_Agregar.TabIndex = 20
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_H_BuscarO
        '
        Me.btn_H_BuscarO.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_H_BuscarO.Location = New System.Drawing.Point(647, 109)
        Me.btn_H_BuscarO.Name = "btn_H_BuscarO"
        Me.btn_H_BuscarO.Size = New System.Drawing.Size(26, 23)
        Me.btn_H_BuscarO.TabIndex = 19
        Me.btn_H_BuscarO.UseVisualStyleBackColor = True
        '
        'lbl_H_ClienteO
        '
        Me.lbl_H_ClienteO.AutoSize = True
        Me.lbl_H_ClienteO.Location = New System.Drawing.Point(51, 112)
        Me.lbl_H_ClienteO.Name = "lbl_H_ClienteO"
        Me.lbl_H_ClienteO.Size = New System.Drawing.Size(38, 13)
        Me.lbl_H_ClienteO.TabIndex = 14
        Me.lbl_H_ClienteO.Text = "Origen"
        '
        'lbl_H_Frecuencia
        '
        Me.lbl_H_Frecuencia.AutoSize = True
        Me.lbl_H_Frecuencia.Location = New System.Drawing.Point(233, 66)
        Me.lbl_H_Frecuencia.Name = "lbl_H_Frecuencia"
        Me.lbl_H_Frecuencia.Size = New System.Drawing.Size(60, 13)
        Me.lbl_H_Frecuencia.TabIndex = 8
        Me.lbl_H_Frecuencia.Text = "Frecuencia"
        '
        'lbl_H_FechaInicio
        '
        Me.lbl_H_FechaInicio.AutoSize = True
        Me.lbl_H_FechaInicio.Location = New System.Drawing.Point(11, 18)
        Me.lbl_H_FechaInicio.Name = "lbl_H_FechaInicio"
        Me.lbl_H_FechaInicio.Size = New System.Drawing.Size(80, 13)
        Me.lbl_H_FechaInicio.TabIndex = 0
        Me.lbl_H_FechaInicio.Text = "Fecha de Inicio"
        '
        'chk_UnicaVez
        '
        Me.chk_UnicaVez.AutoSize = True
        Me.chk_UnicaVez.Location = New System.Drawing.Point(95, 42)
        Me.chk_UnicaVez.Name = "chk_UnicaVez"
        Me.chk_UnicaVez.Size = New System.Drawing.Size(151, 17)
        Me.chk_UnicaVez.TabIndex = 6
        Me.chk_UnicaVez.Text = "&Servicio por única ocasión"
        Me.chk_UnicaVez.UseVisualStyleBackColor = True
        '
        'lbl_FacturarRE
        '
        Me.lbl_FacturarRE.AutoSize = True
        Me.lbl_FacturarRE.Location = New System.Drawing.Point(269, 19)
        Me.lbl_FacturarRE.Name = "lbl_FacturarRE"
        Me.lbl_FacturarRE.Size = New System.Drawing.Size(46, 13)
        Me.lbl_FacturarRE.TabIndex = 3
        Me.lbl_FacturarRE.Text = "Facturar"
        '
        'lbl_CargoA
        '
        Me.lbl_CargoA.AutoSize = True
        Me.lbl_CargoA.Location = New System.Drawing.Point(19, 19)
        Me.lbl_CargoA.Name = "lbl_CargoA"
        Me.lbl_CargoA.Size = New System.Drawing.Size(70, 13)
        Me.lbl_CargoA.TabIndex = 0
        Me.lbl_CargoA.Text = "Con Cargo A:"
        '
        'lbl_Sucursal2
        '
        Me.lbl_Sucursal2.AutoSize = True
        Me.lbl_Sucursal2.Location = New System.Drawing.Point(41, 20)
        Me.lbl_Sucursal2.Name = "lbl_Sucursal2"
        Me.lbl_Sucursal2.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Sucursal2.TabIndex = 0
        Me.lbl_Sucursal2.Text = "Sucursal"
        '
        'lbl_H_DiaEntrega
        '
        Me.lbl_H_DiaEntrega.AutoSize = True
        Me.lbl_H_DiaEntrega.Location = New System.Drawing.Point(9, 117)
        Me.lbl_H_DiaEntrega.Name = "lbl_H_DiaEntrega"
        Me.lbl_H_DiaEntrega.Size = New System.Drawing.Size(80, 13)
        Me.lbl_H_DiaEntrega.TabIndex = 20
        Me.lbl_H_DiaEntrega.Text = "Día de Entrega"
        '
        'lbl_H_MismoDia
        '
        Me.lbl_H_MismoDia.AutoSize = True
        Me.lbl_H_MismoDia.Location = New System.Drawing.Point(233, 92)
        Me.lbl_H_MismoDia.Name = "lbl_H_MismoDia"
        Me.lbl_H_MismoDia.Size = New System.Drawing.Size(98, 13)
        Me.lbl_H_MismoDia.TabIndex = 17
        Me.lbl_H_MismoDia.Text = "Entrega Mismo Día"
        '
        'lbl_H_Boveda
        '
        Me.lbl_H_Boveda.AutoSize = True
        Me.lbl_H_Boveda.Location = New System.Drawing.Point(10, 92)
        Me.lbl_H_Boveda.Name = "lbl_H_Boveda"
        Me.lbl_H_Boveda.Size = New System.Drawing.Size(79, 13)
        Me.lbl_H_Boveda.TabIndex = 14
        Me.lbl_H_Boveda.Text = "Escala en Bov."
        '
        'lbl_H_AD
        '
        Me.lbl_H_AD.AutoSize = True
        Me.lbl_H_AD.Location = New System.Drawing.Point(187, 68)
        Me.lbl_H_AD.Name = "lbl_H_AD"
        Me.lbl_H_AD.Size = New System.Drawing.Size(14, 13)
        Me.lbl_H_AD.TabIndex = 11
        Me.lbl_H_AD.Text = "A"
        '
        'lbl_H_DeD
        '
        Me.lbl_H_DeD.AutoSize = True
        Me.lbl_H_DeD.Location = New System.Drawing.Point(65, 68)
        Me.lbl_H_DeD.Name = "lbl_H_DeD"
        Me.lbl_H_DeD.Size = New System.Drawing.Size(24, 13)
        Me.lbl_H_DeD.TabIndex = 9
        Me.lbl_H_DeD.Text = "De:"
        '
        'lbl_H_ClienteD
        '
        Me.lbl_H_ClienteD.AutoSize = True
        Me.lbl_H_ClienteD.Location = New System.Drawing.Point(46, 45)
        Me.lbl_H_ClienteD.Name = "lbl_H_ClienteD"
        Me.lbl_H_ClienteD.Size = New System.Drawing.Size(43, 13)
        Me.lbl_H_ClienteD.TabIndex = 3
        Me.lbl_H_ClienteD.Text = "Destino"
        '
        'lbl_H_RutaEntrega
        '
        Me.lbl_H_RutaEntrega.AutoSize = True
        Me.lbl_H_RutaEntrega.Location = New System.Drawing.Point(4, 140)
        Me.lbl_H_RutaEntrega.Name = "lbl_H_RutaEntrega"
        Me.lbl_H_RutaEntrega.Size = New System.Drawing.Size(85, 13)
        Me.lbl_H_RutaEntrega.TabIndex = 22
        Me.lbl_H_RutaEntrega.Text = "Ruta de Entrega"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.Btn_GuardarH)
        Me.gbx_Botones.Controls.Add(Me.Btn_CancelarH)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 654)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(713, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'Btn_CancelarH
        '
        Me.Btn_CancelarH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CancelarH.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_CancelarH.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_CancelarH.Location = New System.Drawing.Point(567, 13)
        Me.Btn_CancelarH.Name = "Btn_CancelarH"
        Me.Btn_CancelarH.Size = New System.Drawing.Size(140, 30)
        Me.Btn_CancelarH.TabIndex = 1
        Me.Btn_CancelarH.Text = "&Cancelar"
        Me.Btn_CancelarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CancelarH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_CancelarH.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(437, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(634, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(299, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(188, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(437, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(244, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(506, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "*"
        '
        'gbx_Entrega
        '
        Me.gbx_Entrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Entrega.Controls.Add(Me.tbx_NuevoOrigen)
        Me.gbx_Entrega.Controls.Add(Me.cmb_NuevoOrigen)
        Me.gbx_Entrega.Controls.Add(Me.Label14)
        Me.gbx_Entrega.Controls.Add(Me.cmb_Sucursal2)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_RutaEntrega)
        Me.gbx_Entrega.Controls.Add(Me.Label11)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_ClienteD)
        Me.gbx_Entrega.Controls.Add(Me.Label10)
        Me.gbx_Entrega.Controls.Add(Me.tbx_H_ClienteD)
        Me.gbx_Entrega.Controls.Add(Me.Label9)
        Me.gbx_Entrega.Controls.Add(Me.btn_H_BuscarD)
        Me.gbx_Entrega.Controls.Add(Me.Label8)
        Me.gbx_Entrega.Controls.Add(Me.btn_Agregar2)
        Me.gbx_Entrega.Controls.Add(Me.Label7)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_DeD)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_DeD)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_AD)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_AD)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_ClienteD)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_Boveda)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_Boveda)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_MismoDia)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_MismoDia)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_DiaEntrega)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_DiaEntrega)
        Me.gbx_Entrega.Controls.Add(Me.cmb_H_RutaEntrega)
        Me.gbx_Entrega.Controls.Add(Me.lbl_Sucursal2)
        Me.gbx_Entrega.Location = New System.Drawing.Point(6, 207)
        Me.gbx_Entrega.Name = "gbx_Entrega"
        Me.gbx_Entrega.Size = New System.Drawing.Size(712, 198)
        Me.gbx_Entrega.TabIndex = 1
        Me.gbx_Entrega.TabStop = False
        Me.gbx_Entrega.Text = "Entrega"
        '
        'cmb_Sucursal2
        '
        Me.cmb_Sucursal2.Clave = Nothing
        Me.cmb_Sucursal2.Control_Siguiente = Nothing
        Me.cmb_Sucursal2.DisplayMember = "Nombre"
        Me.cmb_Sucursal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sucursal2.Empresa = True
        Me.cmb_Sucursal2.Filtro = Nothing
        Me.cmb_Sucursal2.FormattingEnabled = True
        Me.cmb_Sucursal2.Location = New System.Drawing.Point(95, 17)
        Me.cmb_Sucursal2.MaxDropDownItems = 20
        Me.cmb_Sucursal2.Name = "cmb_Sucursal2"
        Me.cmb_Sucursal2.Pista = True
        Me.cmb_Sucursal2.Size = New System.Drawing.Size(336, 21)
        Me.cmb_Sucursal2.StoredProcedure = "Cat_SucursalesCombo_Get"
        Me.cmb_Sucursal2.Sucursal = False
        Me.cmb_Sucursal2.TabIndex = 1
        Me.cmb_Sucursal2.Tipo = 0
        Me.cmb_Sucursal2.ValueMember = "Id_Sucursal"
        '
        'btn_H_BuscarD
        '
        Me.btn_H_BuscarD.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_H_BuscarD.Location = New System.Drawing.Point(647, 39)
        Me.btn_H_BuscarD.Name = "btn_H_BuscarD"
        Me.btn_H_BuscarD.Size = New System.Drawing.Size(26, 23)
        Me.btn_H_BuscarD.TabIndex = 7
        Me.btn_H_BuscarD.UseVisualStyleBackColor = True
        '
        'btn_Agregar2
        '
        Me.btn_Agregar2.Image = Global.Modulo_Ventas.My.Resources.Resources.edit_add
        Me.btn_Agregar2.Location = New System.Drawing.Point(679, 40)
        Me.btn_Agregar2.Name = "btn_Agregar2"
        Me.btn_Agregar2.Size = New System.Drawing.Size(26, 23)
        Me.btn_Agregar2.TabIndex = 8
        Me.btn_Agregar2.UseVisualStyleBackColor = True
        '
        'gbx_Cargo
        '
        Me.gbx_Cargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cargo.Controls.Add(Me.Label13)
        Me.gbx_Cargo.Controls.Add(Me.cmb_CargoA)
        Me.gbx_Cargo.Controls.Add(Me.Label12)
        Me.gbx_Cargo.Controls.Add(Me.cbx_Permitir)
        Me.gbx_Cargo.Controls.Add(Me.lbl_CargoA)
        Me.gbx_Cargo.Controls.Add(Me.lbl_FacturarRE)
        Me.gbx_Cargo.Controls.Add(Me.cmb_FacturarRE)
        Me.gbx_Cargo.Controls.Add(Me.chk_UnicaVez)
        Me.gbx_Cargo.Location = New System.Drawing.Point(6, 405)
        Me.gbx_Cargo.Name = "gbx_Cargo"
        Me.gbx_Cargo.Size = New System.Drawing.Size(713, 85)
        Me.gbx_Cargo.TabIndex = 3
        Me.gbx_Cargo.TabStop = False
        '
        'cmb_CargoA
        '
        Me.cmb_CargoA.Control_Siguiente = Nothing
        Me.cmb_CargoA.DisplayMember = "display"
        Me.cmb_CargoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CargoA.FormattingEnabled = True
        Me.cmb_CargoA.Location = New System.Drawing.Point(95, 15)
        Me.cmb_CargoA.MaxDropDownItems = 20
        Me.cmb_CargoA.Name = "cmb_CargoA"
        Me.cmb_CargoA.Size = New System.Drawing.Size(143, 21)
        Me.cmb_CargoA.TabIndex = 1
        Me.cmb_CargoA.ValueMember = "value"
        '
        'cmb_FacturarRE
        '
        Me.cmb_FacturarRE.Control_Siguiente = Nothing
        Me.cmb_FacturarRE.DisplayMember = "display"
        Me.cmb_FacturarRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FacturarRE.FormattingEnabled = True
        Me.cmb_FacturarRE.Location = New System.Drawing.Point(321, 15)
        Me.cmb_FacturarRE.MaxDropDownItems = 20
        Me.cmb_FacturarRE.Name = "cmb_FacturarRE"
        Me.cmb_FacturarRE.Size = New System.Drawing.Size(179, 21)
        Me.cmb_FacturarRE.TabIndex = 4
        Me.cmb_FacturarRE.ValueMember = "value"
        '
        'gbx_Subclientes
        '
        Me.gbx_Subclientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Subclientes.Controls.Add(Me.rtb_Subclientes)
        Me.gbx_Subclientes.Enabled = False
        Me.gbx_Subclientes.Location = New System.Drawing.Point(6, 493)
        Me.gbx_Subclientes.Name = "gbx_Subclientes"
        Me.gbx_Subclientes.Size = New System.Drawing.Size(713, 155)
        Me.gbx_Subclientes.TabIndex = 4
        Me.gbx_Subclientes.TabStop = False
        Me.gbx_Subclientes.Text = "Subclientes Agregados"
        '
        'rtb_Subclientes
        '
        Me.rtb_Subclientes.BackColor = System.Drawing.Color.White
        Me.rtb_Subclientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_Subclientes.Location = New System.Drawing.Point(3, 16)
        Me.rtb_Subclientes.Name = "rtb_Subclientes"
        Me.rtb_Subclientes.ReadOnly = True
        Me.rtb_Subclientes.Size = New System.Drawing.Size(707, 136)
        Me.rtb_Subclientes.TabIndex = 0
        Me.rtb_Subclientes.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Nuevo Origen"
        '
        'tbx_NuevoOrigen
        '
        Me.tbx_NuevoOrigen.Control_Siguiente = Me.cmb_NuevoOrigen
        Me.tbx_NuevoOrigen.Filtrado = True
        Me.tbx_NuevoOrigen.Location = New System.Drawing.Point(95, 164)
        Me.tbx_NuevoOrigen.MaxLength = 20
        Me.tbx_NuevoOrigen.Name = "tbx_NuevoOrigen"
        Me.tbx_NuevoOrigen.Size = New System.Drawing.Size(77, 20)
        Me.tbx_NuevoOrigen.TabIndex = 25
        Me.tbx_NuevoOrigen.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_NuevoOrigen
        '
        Me.cmb_NuevoOrigen.Clave = "Clave_Cliente"
        Me.cmb_NuevoOrigen.Control_Siguiente = Me.cmb_H_DeD
        Me.cmb_NuevoOrigen.DisplayMember = "Nombre_Comercial"
        Me.cmb_NuevoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NuevoOrigen.Empresa = False
        Me.cmb_NuevoOrigen.Filtro = Me.tbx_NuevoOrigen
        Me.cmb_NuevoOrigen.FormattingEnabled = True
        Me.cmb_NuevoOrigen.Location = New System.Drawing.Point(178, 163)
        Me.cmb_NuevoOrigen.MaxDropDownItems = 20
        Me.cmb_NuevoOrigen.Name = "cmb_NuevoOrigen"
        Me.cmb_NuevoOrigen.Pista = False
        Me.cmb_NuevoOrigen.Size = New System.Drawing.Size(450, 21)
        Me.cmb_NuevoOrigen.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_NuevoOrigen.Sucursal = False
        Me.cmb_NuevoOrigen.TabIndex = 26
        Me.cmb_NuevoOrigen.Tipo = 0
        Me.cmb_NuevoOrigen.ValueMember = "Id_Cliente"
        '
        'frm_ClientesHorariosUno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_CancelarH
        Me.ClientSize = New System.Drawing.Size(714, 706)
        Me.Controls.Add(Me.gbx_Subclientes)
        Me.Controls.Add(Me.gbx_Cargo)
        Me.Controls.Add(Me.gbx_Entrega)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Recoleccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 660)
        Me.Name = "frm_ClientesHorariosUno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios de Traslado"
        Me.gbx_Recoleccion.ResumeLayout(False)
        Me.gbx_Recoleccion.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Entrega.ResumeLayout(False)
        Me.gbx_Entrega.PerformLayout()
        Me.gbx_Cargo.ResumeLayout(False)
        Me.gbx_Cargo.PerformLayout()
        Me.gbx_Subclientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Recoleccion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_H_ClienteD As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_H_DeD As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_H_AD As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Btn_GuardarH As System.Windows.Forms.Button
    Friend WithEvents tbx_H_ClienteD As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_H_ClienteO As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_H_DeO As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_H_AO As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents tbx_H_ClienteO As Modulo_Ventas.cp_Textbox
    Friend WithEvents cbx_Permitir As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_CancelarH As System.Windows.Forms.Button
    Friend WithEvents cmb_H_TipoF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_H_Frecuencia As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents dtp_H_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_H_TipoF As System.Windows.Forms.Label
    Friend WithEvents lbl_H_AD As System.Windows.Forms.Label
    Friend WithEvents lbl_H_DeD As System.Windows.Forms.Label
    Friend WithEvents lbl_H_AO As System.Windows.Forms.Label
    Friend WithEvents lbl_H_DeO As System.Windows.Forms.Label
    Friend WithEvents btn_H_BuscarD As System.Windows.Forms.Button
    Friend WithEvents lbl_H_ClienteD As System.Windows.Forms.Label
    Friend WithEvents btn_H_BuscarO As System.Windows.Forms.Button
    Friend WithEvents lbl_H_ClienteO As System.Windows.Forms.Label
    Friend WithEvents lbl_H_Frecuencia As System.Windows.Forms.Label
    Friend WithEvents lbl_H_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents lbl_H_Boveda As System.Windows.Forms.Label
    Friend WithEvents cmb_H_Boveda As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_H_MismoDia As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_H_MismoDia As System.Windows.Forms.Label
    Friend WithEvents cmb_H_DiaEntrega As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_H_DiaEntrega As System.Windows.Forms.Label
    Friend WithEvents cmb_H_RutaEntrega As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_H_RutaEntrega As System.Windows.Forms.Label
    Friend WithEvents cmb_H_Ruta As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Sucursal2 As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Sucursal1 As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CargoA As System.Windows.Forms.Label
    Friend WithEvents cmb_CargoA As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_FacturarRE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_FacturarRE As System.Windows.Forms.Label
    Friend WithEvents chk_UnicaVez As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Agregar2 As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_Entrega As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Cargo As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Subclientes As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Subclientes As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Ayuda As System.Windows.Forms.Button
    Friend WithEvents rdb_UtilizaCasetNO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_UtilizaCasetSi As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_UtilizaCaset As System.Windows.Forms.Label
    Friend WithEvents tbx_NuevoOrigen As cp_Textbox
    Friend WithEvents cmb_NuevoOrigen As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label14 As Label
End Class
