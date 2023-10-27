<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesBaja
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter5 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.tbx_TipoCliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_TipoCliente = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.chk_Clientes = New System.Windows.Forms.CheckBox
        Me.tbx_CiudadF = New Modulo_Ventas.cp_Textbox
        Me.lbl_DireccionF = New System.Windows.Forms.Label
        Me.lbl_NombreF = New System.Windows.Forms.Label
        Me.tbx_DireccionF = New Modulo_Ventas.cp_Textbox
        Me.tbx_NombreF = New Modulo_Ventas.cp_Textbox
        Me.tbx_RFC = New Modulo_Ventas.cp_Textbox
        Me.lbl_RFC = New System.Windows.Forms.Label
        Me.lbl_CiudadF = New System.Windows.Forms.Label
        Me.lbl_DireccionC = New System.Windows.Forms.Label
        Me.tbx_DireccionC = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.Gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.Tab_Bajas = New System.Windows.Forms.TabControl
        Me.Tab_Datos = New System.Windows.Forms.TabPage
        Me.lbl_Alerta = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_BajaPermanente = New System.Windows.Forms.CheckBox
        Me.lbl_ListaNegra = New System.Windows.Forms.Label
        Me.chk_ListaNegra = New System.Windows.Forms.CheckBox
        Me.lbl_ListaNegraA = New System.Windows.Forms.Label
        Me.lbl_ComentariosListaNegra = New System.Windows.Forms.Label
        Me.tbx_ListaNegra = New Modulo_Ventas.cp_Textbox
        Me.btn_AgregarArchivo = New System.Windows.Forms.Button
        Me.lbl_Archivo = New System.Windows.Forms.Label
        Me.tbx_Archivo = New Modulo_Ventas.cp_Textbox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.tbx_Observaciones = New Modulo_Ventas.cp_Textbox
        Me.lbl_Cargo = New System.Windows.Forms.Label
        Me.lbl_Contacto = New System.Windows.Forms.Label
        Me.tbx_Cargo = New Modulo_Ventas.cp_Textbox
        Me.tbx_Contacto = New Modulo_Ventas.cp_Textbox
        Me.lbl_Motivo = New System.Windows.Forms.Label
        Me.cmb_Motivo = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.Tab_Pendientes = New System.Windows.Forms.TabPage
        Me.gbx_Proceso = New System.Windows.Forms.GroupBox
        Me.lsv_Proceso = New Modulo_Ventas.cp_Listview
        Me.gbx_Materiales = New System.Windows.Forms.GroupBox
        Me.lsv_Materiales = New Modulo_Ventas.cp_Listview
        Me.gbx_Saldo = New System.Windows.Forms.GroupBox
        Me.lsv_Saldo = New Modulo_Ventas.cp_Listview
        Me.gbx_Traslado = New System.Windows.Forms.GroupBox
        Me.lsv_Traslado = New Modulo_Ventas.cp_Listview
        Me.gbx_Boveda = New System.Windows.Forms.GroupBox
        Me.lsv_Boveda = New Modulo_Ventas.cp_Listview
        Me.gbx_Datos.SuspendLayout()
        Me.Gbx_Controles.SuspendLayout()
        Me.Tab_Bajas.SuspendLayout()
        Me.Tab_Datos.SuspendLayout()
        Me.Tab_Pendientes.SuspendLayout()
        Me.gbx_Proceso.SuspendLayout()
        Me.gbx_Materiales.SuspendLayout()
        Me.gbx_Saldo.SuspendLayout()
        Me.gbx_Traslado.SuspendLayout()
        Me.gbx_Boveda.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.tbx_TipoCliente)
        Me.gbx_Datos.Controls.Add(Me.lbl_TipoCliente)
        Me.gbx_Datos.Controls.Add(Me.Label12)
        Me.gbx_Datos.Controls.Add(Me.chk_Clientes)
        Me.gbx_Datos.Controls.Add(Me.tbx_CiudadF)
        Me.gbx_Datos.Controls.Add(Me.lbl_DireccionF)
        Me.gbx_Datos.Controls.Add(Me.lbl_NombreF)
        Me.gbx_Datos.Controls.Add(Me.tbx_DireccionF)
        Me.gbx_Datos.Controls.Add(Me.tbx_NombreF)
        Me.gbx_Datos.Controls.Add(Me.tbx_RFC)
        Me.gbx_Datos.Controls.Add(Me.lbl_RFC)
        Me.gbx_Datos.Controls.Add(Me.lbl_CiudadF)
        Me.gbx_Datos.Controls.Add(Me.lbl_DireccionC)
        Me.gbx_Datos.Controls.Add(Me.tbx_DireccionC)
        Me.gbx_Datos.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Datos.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Datos.Controls.Add(Me.btn_BuscarCliente)
        Me.gbx_Datos.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(817, 198)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        Me.gbx_Datos.Text = "Cliente"
        '
        'tbx_TipoCliente
        '
        Me.tbx_TipoCliente.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_TipoCliente.Control_Siguiente = Nothing
        Me.tbx_TipoCliente.Filtrado = True
        Me.tbx_TipoCliente.Location = New System.Drawing.Point(548, 63)
        Me.tbx_TipoCliente.MaxLength = 50
        Me.tbx_TipoCliente.Name = "tbx_TipoCliente"
        Me.tbx_TipoCliente.ReadOnly = True
        Me.tbx_TipoCliente.Size = New System.Drawing.Size(208, 20)
        Me.tbx_TipoCliente.TabIndex = 8
        Me.tbx_TipoCliente.TabStop = False
        Me.tbx_TipoCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_TipoCliente
        '
        Me.lbl_TipoCliente.Location = New System.Drawing.Point(497, 56)
        Me.lbl_TipoCliente.Name = "lbl_TipoCliente"
        Me.lbl_TipoCliente.Size = New System.Drawing.Size(49, 32)
        Me.lbl_TipoCliente.TabIndex = 7
        Me.lbl_TipoCliente.Text = "Tipo de Cliente"
        Me.lbl_TipoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(598, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "*"
        '
        'chk_Clientes
        '
        Me.chk_Clientes.AutoSize = True
        Me.chk_Clientes.Location = New System.Drawing.Point(85, 176)
        Me.chk_Clientes.Name = "chk_Clientes"
        Me.chk_Clientes.Size = New System.Drawing.Size(379, 17)
        Me.chk_Clientes.TabIndex = 15
        Me.chk_Clientes.Text = "También dar de baja las Sucursales (subclientes) del Cliente Seleccionado."
        Me.chk_Clientes.UseVisualStyleBackColor = True
        '
        'tbx_CiudadF
        '
        Me.tbx_CiudadF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CiudadF.Control_Siguiente = Nothing
        Me.tbx_CiudadF.Filtrado = True
        Me.tbx_CiudadF.Location = New System.Drawing.Point(548, 135)
        Me.tbx_CiudadF.MaxLength = 50
        Me.tbx_CiudadF.Multiline = True
        Me.tbx_CiudadF.Name = "tbx_CiudadF"
        Me.tbx_CiudadF.ReadOnly = True
        Me.tbx_CiudadF.Size = New System.Drawing.Size(208, 35)
        Me.tbx_CiudadF.TabIndex = 16
        Me.tbx_CiudadF.TabStop = False
        Me.tbx_CiudadF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_DireccionF
        '
        Me.lbl_DireccionF.Location = New System.Drawing.Point(15, 138)
        Me.lbl_DireccionF.Name = "lbl_DireccionF"
        Me.lbl_DireccionF.Size = New System.Drawing.Size(64, 32)
        Me.lbl_DireccionF.TabIndex = 13
        Me.lbl_DireccionF.Text = "Dirección Fiscal"
        Me.lbl_DireccionF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_NombreF
        '
        Me.lbl_NombreF.Location = New System.Drawing.Point(16, 97)
        Me.lbl_NombreF.Name = "lbl_NombreF"
        Me.lbl_NombreF.Size = New System.Drawing.Size(63, 32)
        Me.lbl_NombreF.TabIndex = 9
        Me.lbl_NombreF.Text = "Nombre Fiscal"
        Me.lbl_NombreF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbx_DireccionF
        '
        Me.tbx_DireccionF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DireccionF.Control_Siguiente = Nothing
        Me.tbx_DireccionF.Filtrado = True
        Me.tbx_DireccionF.Location = New System.Drawing.Point(85, 135)
        Me.tbx_DireccionF.MaxLength = 150
        Me.tbx_DireccionF.Multiline = True
        Me.tbx_DireccionF.Name = "tbx_DireccionF"
        Me.tbx_DireccionF.ReadOnly = True
        Me.tbx_DireccionF.Size = New System.Drawing.Size(406, 35)
        Me.tbx_DireccionF.TabIndex = 14
        Me.tbx_DireccionF.TabStop = False
        Me.tbx_DireccionF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_NombreF
        '
        Me.tbx_NombreF.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreF.Control_Siguiente = Nothing
        Me.tbx_NombreF.Filtrado = True
        Me.tbx_NombreF.Location = New System.Drawing.Point(85, 94)
        Me.tbx_NombreF.MaxLength = 150
        Me.tbx_NombreF.Multiline = True
        Me.tbx_NombreF.Name = "tbx_NombreF"
        Me.tbx_NombreF.ReadOnly = True
        Me.tbx_NombreF.Size = New System.Drawing.Size(406, 35)
        Me.tbx_NombreF.TabIndex = 10
        Me.tbx_NombreF.TabStop = False
        Me.tbx_NombreF.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_RFC
        '
        Me.tbx_RFC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_RFC.Control_Siguiente = Nothing
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(548, 98)
        Me.tbx_RFC.MaxLength = 50
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.ReadOnly = True
        Me.tbx_RFC.Size = New System.Drawing.Size(208, 20)
        Me.tbx_RFC.TabIndex = 12
        Me.tbx_RFC.TabStop = False
        Me.tbx_RFC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(518, 101)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(28, 13)
        Me.lbl_RFC.TabIndex = 11
        Me.lbl_RFC.Text = "RFC"
        '
        'lbl_CiudadF
        '
        Me.lbl_CiudadF.AutoSize = True
        Me.lbl_CiudadF.Location = New System.Drawing.Point(494, 138)
        Me.lbl_CiudadF.Name = "lbl_CiudadF"
        Me.lbl_CiudadF.Size = New System.Drawing.Size(52, 13)
        Me.lbl_CiudadF.TabIndex = 15
        Me.lbl_CiudadF.Text = "Ciudad F."
        '
        'lbl_DireccionC
        '
        Me.lbl_DireccionC.Location = New System.Drawing.Point(10, 56)
        Me.lbl_DireccionC.Name = "lbl_DireccionC"
        Me.lbl_DireccionC.Size = New System.Drawing.Size(69, 32)
        Me.lbl_DireccionC.TabIndex = 5
        Me.lbl_DireccionC.Text = "Dirección Comercial"
        Me.lbl_DireccionC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbx_DireccionC
        '
        Me.tbx_DireccionC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DireccionC.Control_Siguiente = Nothing
        Me.tbx_DireccionC.Filtrado = True
        Me.tbx_DireccionC.Location = New System.Drawing.Point(85, 53)
        Me.tbx_DireccionC.MaxLength = 150
        Me.tbx_DireccionC.Multiline = True
        Me.tbx_DireccionC.Name = "tbx_DireccionC"
        Me.tbx_DireccionC.ReadOnly = True
        Me.tbx_DireccionC.Size = New System.Drawing.Size(406, 35)
        Me.tbx_DireccionC.TabIndex = 6
        Me.tbx_DireccionC.TabStop = False
        Me.tbx_DireccionC.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.dtp_Fecha
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(155, 19)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(405, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 2
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(130, 6)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.dtp_Fecha
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(85, 19)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(64, 20)
        Me.tbx_Cliente.TabIndex = 1
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(40, 22)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(566, 17)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 3
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'Gbx_Controles
        '
        Me.Gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Controles.Controls.Add(Me.Btn_Baja)
        Me.Gbx_Controles.Location = New System.Drawing.Point(9, 614)
        Me.Gbx_Controles.Name = "Gbx_Controles"
        Me.Gbx_Controles.Size = New System.Drawing.Size(817, 49)
        Me.Gbx_Controles.TabIndex = 2
        Me.Gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(670, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.Btn_Baja.Location = New System.Drawing.Point(9, 13)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 0
        Me.Btn_Baja.Text = "&Baja"
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'Tab_Bajas
        '
        Me.Tab_Bajas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Bajas.Controls.Add(Me.Tab_Datos)
        Me.Tab_Bajas.Controls.Add(Me.Tab_Pendientes)
        Me.Tab_Bajas.Location = New System.Drawing.Point(9, 206)
        Me.Tab_Bajas.Name = "Tab_Bajas"
        Me.Tab_Bajas.SelectedIndex = 0
        Me.Tab_Bajas.Size = New System.Drawing.Size(817, 406)
        Me.Tab_Bajas.TabIndex = 1
        '
        'Tab_Datos
        '
        Me.Tab_Datos.Controls.Add(Me.lbl_Alerta)
        Me.Tab_Datos.Controls.Add(Me.btn_Mostrar)
        Me.Tab_Datos.Controls.Add(Me.chk_BajaPermanente)
        Me.Tab_Datos.Controls.Add(Me.lbl_ListaNegra)
        Me.Tab_Datos.Controls.Add(Me.chk_ListaNegra)
        Me.Tab_Datos.Controls.Add(Me.lbl_ListaNegraA)
        Me.Tab_Datos.Controls.Add(Me.lbl_ComentariosListaNegra)
        Me.Tab_Datos.Controls.Add(Me.tbx_ListaNegra)
        Me.Tab_Datos.Controls.Add(Me.btn_AgregarArchivo)
        Me.Tab_Datos.Controls.Add(Me.lbl_Archivo)
        Me.Tab_Datos.Controls.Add(Me.tbx_Archivo)
        Me.Tab_Datos.Controls.Add(Me.Label5)
        Me.Tab_Datos.Controls.Add(Me.Label4)
        Me.Tab_Datos.Controls.Add(Me.Label3)
        Me.Tab_Datos.Controls.Add(Me.Label2)
        Me.Tab_Datos.Controls.Add(Me.Label1)
        Me.Tab_Datos.Controls.Add(Me.lbl_Observaciones)
        Me.Tab_Datos.Controls.Add(Me.tbx_Observaciones)
        Me.Tab_Datos.Controls.Add(Me.lbl_Cargo)
        Me.Tab_Datos.Controls.Add(Me.lbl_Contacto)
        Me.Tab_Datos.Controls.Add(Me.tbx_Cargo)
        Me.Tab_Datos.Controls.Add(Me.tbx_Contacto)
        Me.Tab_Datos.Controls.Add(Me.lbl_Motivo)
        Me.Tab_Datos.Controls.Add(Me.cmb_Motivo)
        Me.Tab_Datos.Controls.Add(Me.lbl_Fecha)
        Me.Tab_Datos.Controls.Add(Me.dtp_Fecha)
        Me.Tab_Datos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Datos.Name = "Tab_Datos"
        Me.Tab_Datos.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Datos.Size = New System.Drawing.Size(809, 380)
        Me.Tab_Datos.TabIndex = 0
        Me.Tab_Datos.Text = "Datos de la Baja"
        Me.Tab_Datos.UseVisualStyleBackColor = True
        '
        'lbl_Alerta
        '
        Me.lbl_Alerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Alerta.ForeColor = System.Drawing.Color.Red
        Me.lbl_Alerta.Location = New System.Drawing.Point(544, 6)
        Me.lbl_Alerta.Name = "lbl_Alerta"
        Me.lbl_Alerta.Size = New System.Drawing.Size(210, 100)
        Me.lbl_Alerta.TabIndex = 25
        Me.lbl_Alerta.Tag = ""
        Me.lbl_Alerta.Text = "Alerta de Renta, en Proceso de Renta o Pendiente de Retiro de Cajas Fuertes."
        Me.lbl_Alerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(518, 131)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(80, 25)
        Me.btn_Mostrar.TabIndex = 26
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        Me.btn_Mostrar.Visible = False
        '
        'chk_BajaPermanente
        '
        Me.chk_BajaPermanente.AutoSize = True
        Me.chk_BajaPermanente.Location = New System.Drawing.Point(250, 9)
        Me.chk_BajaPermanente.Name = "chk_BajaPermanente"
        Me.chk_BajaPermanente.Size = New System.Drawing.Size(113, 17)
        Me.chk_BajaPermanente.TabIndex = 3
        Me.chk_BajaPermanente.Text = "Baja Permanente?"
        Me.chk_BajaPermanente.UseVisualStyleBackColor = True
        '
        'lbl_ListaNegra
        '
        Me.lbl_ListaNegra.AutoSize = True
        Me.lbl_ListaNegra.Enabled = False
        Me.lbl_ListaNegra.Location = New System.Drawing.Point(8, 240)
        Me.lbl_ListaNegra.Name = "lbl_ListaNegra"
        Me.lbl_ListaNegra.Size = New System.Drawing.Size(116, 13)
        Me.lbl_ListaNegra.TabIndex = 20
        Me.lbl_ListaNegra.Text = "Agregar a Lista Negra?"
        '
        'chk_ListaNegra
        '
        Me.chk_ListaNegra.AutoSize = True
        Me.chk_ListaNegra.Enabled = False
        Me.chk_ListaNegra.Location = New System.Drawing.Point(130, 240)
        Me.chk_ListaNegra.Name = "chk_ListaNegra"
        Me.chk_ListaNegra.Size = New System.Drawing.Size(15, 14)
        Me.chk_ListaNegra.TabIndex = 21
        Me.chk_ListaNegra.UseVisualStyleBackColor = True
        '
        'lbl_ListaNegraA
        '
        Me.lbl_ListaNegraA.AutoSize = True
        Me.lbl_ListaNegraA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ListaNegraA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ListaNegraA.Location = New System.Drawing.Point(518, 267)
        Me.lbl_ListaNegraA.Name = "lbl_ListaNegraA"
        Me.lbl_ListaNegraA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ListaNegraA.TabIndex = 24
        Me.lbl_ListaNegraA.Text = "*"
        Me.lbl_ListaNegraA.Visible = False
        '
        'lbl_ComentariosListaNegra
        '
        Me.lbl_ComentariosListaNegra.AutoSize = True
        Me.lbl_ComentariosListaNegra.Enabled = False
        Me.lbl_ComentariosListaNegra.Location = New System.Drawing.Point(59, 263)
        Me.lbl_ComentariosListaNegra.Name = "lbl_ComentariosListaNegra"
        Me.lbl_ComentariosListaNegra.Size = New System.Drawing.Size(65, 13)
        Me.lbl_ComentariosListaNegra.TabIndex = 22
        Me.lbl_ComentariosListaNegra.Text = "Comentarios"
        '
        'tbx_ListaNegra
        '
        Me.tbx_ListaNegra.Control_Siguiente = Nothing
        Me.tbx_ListaNegra.Enabled = False
        Me.tbx_ListaNegra.Filtrado = True
        Me.tbx_ListaNegra.Location = New System.Drawing.Point(130, 260)
        Me.tbx_ListaNegra.MaxLength = 300
        Me.tbx_ListaNegra.Multiline = True
        Me.tbx_ListaNegra.Name = "tbx_ListaNegra"
        Me.tbx_ListaNegra.Size = New System.Drawing.Size(382, 58)
        Me.tbx_ListaNegra.TabIndex = 23
        Me.tbx_ListaNegra.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_AgregarArchivo
        '
        Me.btn_AgregarArchivo.Enabled = False
        Me.btn_AgregarArchivo.Image = Global.Modulo_Ventas.My.Resources.Resources.edit_add
        Me.btn_AgregarArchivo.Location = New System.Drawing.Point(518, 205)
        Me.btn_AgregarArchivo.Name = "btn_AgregarArchivo"
        Me.btn_AgregarArchivo.Size = New System.Drawing.Size(80, 25)
        Me.btn_AgregarArchivo.TabIndex = 19
        Me.btn_AgregarArchivo.Text = "Adjuntar"
        Me.btn_AgregarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarArchivo.UseVisualStyleBackColor = True
        '
        'lbl_Archivo
        '
        Me.lbl_Archivo.AutoSize = True
        Me.lbl_Archivo.Location = New System.Drawing.Point(81, 211)
        Me.lbl_Archivo.Name = "lbl_Archivo"
        Me.lbl_Archivo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Archivo.TabIndex = 17
        Me.lbl_Archivo.Text = "Archivo"
        '
        'tbx_Archivo
        '
        Me.tbx_Archivo.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Archivo.Control_Siguiente = Nothing
        Me.tbx_Archivo.Filtrado = True
        Me.tbx_Archivo.Location = New System.Drawing.Point(130, 208)
        Me.tbx_Archivo.MaxLength = 50
        Me.tbx_Archivo.Name = "tbx_Archivo"
        Me.tbx_Archivo.ReadOnly = True
        Me.tbx_Archivo.Size = New System.Drawing.Size(382, 20)
        Me.tbx_Archivo.TabIndex = 18
        Me.tbx_Archivo.TabStop = False
        Me.tbx_Archivo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(518, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(486, 86)
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
        Me.Label3.Location = New System.Drawing.Point(486, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(486, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(231, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(46, 114)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 14
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Control_Siguiente = Nothing
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(130, 111)
        Me.tbx_Observaciones.MaxLength = 300
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(382, 91)
        Me.tbx_Observaciones.TabIndex = 15
        Me.tbx_Observaciones.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Cargo
        '
        Me.lbl_Cargo.AutoSize = True
        Me.lbl_Cargo.Location = New System.Drawing.Point(89, 88)
        Me.lbl_Cargo.Name = "lbl_Cargo"
        Me.lbl_Cargo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Cargo.TabIndex = 11
        Me.lbl_Cargo.Text = "Cargo"
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(74, 62)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Contacto.TabIndex = 8
        Me.lbl_Contacto.Text = "Contacto"
        '
        'tbx_Cargo
        '
        Me.tbx_Cargo.Control_Siguiente = Me.tbx_Observaciones
        Me.tbx_Cargo.Filtrado = True
        Me.tbx_Cargo.Location = New System.Drawing.Point(130, 85)
        Me.tbx_Cargo.MaxLength = 50
        Me.tbx_Cargo.Name = "tbx_Cargo"
        Me.tbx_Cargo.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Cargo.TabIndex = 12
        Me.tbx_Cargo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Contacto
        '
        Me.tbx_Contacto.Control_Siguiente = Me.tbx_Cargo
        Me.tbx_Contacto.Filtrado = True
        Me.tbx_Contacto.Location = New System.Drawing.Point(130, 59)
        Me.tbx_Contacto.MaxLength = 50
        Me.tbx_Contacto.Name = "tbx_Contacto"
        Me.tbx_Contacto.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Contacto.TabIndex = 9
        Me.tbx_Contacto.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Motivo
        '
        Me.lbl_Motivo.AutoSize = True
        Me.lbl_Motivo.Location = New System.Drawing.Point(85, 35)
        Me.lbl_Motivo.Name = "lbl_Motivo"
        Me.lbl_Motivo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Motivo.TabIndex = 4
        Me.lbl_Motivo.Text = "Motivo"
        '
        'cmb_Motivo
        '
        Me.cmb_Motivo.Clave = ""
        Me.cmb_Motivo.Control_Siguiente = Me.tbx_Contacto
        Me.cmb_Motivo.DisplayMember = "Descripcion"
        Me.cmb_Motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Motivo.Empresa = False
        Me.cmb_Motivo.Filtro = Nothing
        Me.cmb_Motivo.FormattingEnabled = True
        Me.cmb_Motivo.Location = New System.Drawing.Point(130, 32)
        Me.cmb_Motivo.MaxDropDownItems = 20
        Me.cmb_Motivo.Name = "cmb_Motivo"
        Me.cmb_Motivo.Pista = True
        Me.cmb_Motivo.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Motivo.StoredProcedure = "Cat_MotivosBaja_Get"
        Me.cmb_Motivo.Sucursal = False
        Me.cmb_Motivo.TabIndex = 6
        Me.cmb_Motivo.Tipo = 1
        Me.cmb_Motivo.ValueMember = "Id_MotivoB"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(87, 10)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        '
        'Tab_Pendientes
        '
        Me.Tab_Pendientes.Controls.Add(Me.gbx_Proceso)
        Me.Tab_Pendientes.Controls.Add(Me.gbx_Materiales)
        Me.Tab_Pendientes.Controls.Add(Me.gbx_Saldo)
        Me.Tab_Pendientes.Controls.Add(Me.gbx_Traslado)
        Me.Tab_Pendientes.Controls.Add(Me.gbx_Boveda)
        Me.Tab_Pendientes.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Pendientes.Name = "Tab_Pendientes"
        Me.Tab_Pendientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Pendientes.Size = New System.Drawing.Size(809, 380)
        Me.Tab_Pendientes.TabIndex = 1
        Me.Tab_Pendientes.Text = "Pendientes"
        Me.Tab_Pendientes.UseVisualStyleBackColor = True
        '
        'gbx_Proceso
        '
        Me.gbx_Proceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Proceso.Controls.Add(Me.lsv_Proceso)
        Me.gbx_Proceso.Location = New System.Drawing.Point(383, 122)
        Me.gbx_Proceso.Name = "gbx_Proceso"
        Me.gbx_Proceso.Size = New System.Drawing.Size(417, 102)
        Me.gbx_Proceso.TabIndex = 1
        Me.gbx_Proceso.TabStop = False
        Me.gbx_Proceso.Text = "Proceso"
        '
        'lsv_Proceso
        '
        Me.lsv_Proceso.AllowColumnReorder = True
        Me.lsv_Proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Proceso.FullRowSelect = True
        Me.lsv_Proceso.HideSelection = False
        Me.lsv_Proceso.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Proceso.Lvs = ListViewColumnSorter1
        Me.lsv_Proceso.MultiSelect = False
        Me.lsv_Proceso.Name = "lsv_Proceso"
        Me.lsv_Proceso.Row1 = 29
        Me.lsv_Proceso.Row10 = 10
        Me.lsv_Proceso.Row2 = 20
        Me.lsv_Proceso.Row3 = 20
        Me.lsv_Proceso.Row4 = 20
        Me.lsv_Proceso.Row5 = 10
        Me.lsv_Proceso.Row6 = 10
        Me.lsv_Proceso.Row7 = 10
        Me.lsv_Proceso.Row8 = 10
        Me.lsv_Proceso.Row9 = 10
        Me.lsv_Proceso.Size = New System.Drawing.Size(411, 83)
        Me.lsv_Proceso.TabIndex = 0
        Me.lsv_Proceso.UseCompatibleStateImageBehavior = False
        Me.lsv_Proceso.View = System.Windows.Forms.View.Details
        '
        'gbx_Materiales
        '
        Me.gbx_Materiales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Materiales.Controls.Add(Me.lsv_Materiales)
        Me.gbx_Materiales.Location = New System.Drawing.Point(383, 6)
        Me.gbx_Materiales.Name = "gbx_Materiales"
        Me.gbx_Materiales.Size = New System.Drawing.Size(417, 110)
        Me.gbx_Materiales.TabIndex = 1
        Me.gbx_Materiales.TabStop = False
        Me.gbx_Materiales.Text = "Materiales"
        '
        'lsv_Materiales
        '
        Me.lsv_Materiales.AllowColumnReorder = True
        Me.lsv_Materiales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Materiales.FullRowSelect = True
        Me.lsv_Materiales.HideSelection = False
        Me.lsv_Materiales.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Materiales.Lvs = ListViewColumnSorter2
        Me.lsv_Materiales.MultiSelect = False
        Me.lsv_Materiales.Name = "lsv_Materiales"
        Me.lsv_Materiales.Row1 = 15
        Me.lsv_Materiales.Row10 = 0
        Me.lsv_Materiales.Row2 = 15
        Me.lsv_Materiales.Row3 = 10
        Me.lsv_Materiales.Row4 = 20
        Me.lsv_Materiales.Row5 = 10
        Me.lsv_Materiales.Row6 = 15
        Me.lsv_Materiales.Row7 = 10
        Me.lsv_Materiales.Row8 = 0
        Me.lsv_Materiales.Row9 = 0
        Me.lsv_Materiales.Size = New System.Drawing.Size(411, 91)
        Me.lsv_Materiales.TabIndex = 0
        Me.lsv_Materiales.UseCompatibleStateImageBehavior = False
        Me.lsv_Materiales.View = System.Windows.Forms.View.Details
        '
        'gbx_Saldo
        '
        Me.gbx_Saldo.Controls.Add(Me.lsv_Saldo)
        Me.gbx_Saldo.Location = New System.Drawing.Point(9, 122)
        Me.gbx_Saldo.Name = "gbx_Saldo"
        Me.gbx_Saldo.Size = New System.Drawing.Size(368, 102)
        Me.gbx_Saldo.TabIndex = 0
        Me.gbx_Saldo.TabStop = False
        Me.gbx_Saldo.Text = "Saldo"
        '
        'lsv_Saldo
        '
        Me.lsv_Saldo.AllowColumnReorder = True
        Me.lsv_Saldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Saldo.FullRowSelect = True
        Me.lsv_Saldo.HideSelection = False
        Me.lsv_Saldo.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Saldo.Lvs = ListViewColumnSorter3
        Me.lsv_Saldo.MultiSelect = False
        Me.lsv_Saldo.Name = "lsv_Saldo"
        Me.lsv_Saldo.Row1 = 15
        Me.lsv_Saldo.Row10 = 0
        Me.lsv_Saldo.Row2 = 15
        Me.lsv_Saldo.Row3 = 10
        Me.lsv_Saldo.Row4 = 20
        Me.lsv_Saldo.Row5 = 10
        Me.lsv_Saldo.Row6 = 15
        Me.lsv_Saldo.Row7 = 10
        Me.lsv_Saldo.Row8 = 0
        Me.lsv_Saldo.Row9 = 0
        Me.lsv_Saldo.Size = New System.Drawing.Size(362, 83)
        Me.lsv_Saldo.TabIndex = 0
        Me.lsv_Saldo.UseCompatibleStateImageBehavior = False
        Me.lsv_Saldo.View = System.Windows.Forms.View.Details
        '
        'gbx_Traslado
        '
        Me.gbx_Traslado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Traslado.Controls.Add(Me.lsv_Traslado)
        Me.gbx_Traslado.Location = New System.Drawing.Point(6, 230)
        Me.gbx_Traslado.Name = "gbx_Traslado"
        Me.gbx_Traslado.Size = New System.Drawing.Size(797, 144)
        Me.gbx_Traslado.TabIndex = 2
        Me.gbx_Traslado.TabStop = False
        Me.gbx_Traslado.Text = "Traslado"
        '
        'lsv_Traslado
        '
        Me.lsv_Traslado.AllowColumnReorder = True
        Me.lsv_Traslado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Traslado.FullRowSelect = True
        Me.lsv_Traslado.HideSelection = False
        Me.lsv_Traslado.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Traslado.Lvs = ListViewColumnSorter4
        Me.lsv_Traslado.MultiSelect = False
        Me.lsv_Traslado.Name = "lsv_Traslado"
        Me.lsv_Traslado.Row1 = 10
        Me.lsv_Traslado.Row10 = 10
        Me.lsv_Traslado.Row2 = 10
        Me.lsv_Traslado.Row3 = 10
        Me.lsv_Traslado.Row4 = 10
        Me.lsv_Traslado.Row5 = 10
        Me.lsv_Traslado.Row6 = 10
        Me.lsv_Traslado.Row7 = 10
        Me.lsv_Traslado.Row8 = 10
        Me.lsv_Traslado.Row9 = 10
        Me.lsv_Traslado.Size = New System.Drawing.Size(791, 125)
        Me.lsv_Traslado.TabIndex = 0
        Me.lsv_Traslado.UseCompatibleStateImageBehavior = False
        Me.lsv_Traslado.View = System.Windows.Forms.View.Details
        '
        'gbx_Boveda
        '
        Me.gbx_Boveda.Controls.Add(Me.lsv_Boveda)
        Me.gbx_Boveda.Location = New System.Drawing.Point(9, 6)
        Me.gbx_Boveda.Name = "gbx_Boveda"
        Me.gbx_Boveda.Size = New System.Drawing.Size(368, 110)
        Me.gbx_Boveda.TabIndex = 0
        Me.gbx_Boveda.TabStop = False
        Me.gbx_Boveda.Text = "Bóveda"
        '
        'lsv_Boveda
        '
        Me.lsv_Boveda.AllowColumnReorder = True
        Me.lsv_Boveda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Boveda.FullRowSelect = True
        Me.lsv_Boveda.HideSelection = False
        Me.lsv_Boveda.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Boveda.Lvs = ListViewColumnSorter5
        Me.lsv_Boveda.MultiSelect = False
        Me.lsv_Boveda.Name = "lsv_Boveda"
        Me.lsv_Boveda.Row1 = 29
        Me.lsv_Boveda.Row10 = 10
        Me.lsv_Boveda.Row2 = 20
        Me.lsv_Boveda.Row3 = 20
        Me.lsv_Boveda.Row4 = 20
        Me.lsv_Boveda.Row5 = 10
        Me.lsv_Boveda.Row6 = 10
        Me.lsv_Boveda.Row7 = 10
        Me.lsv_Boveda.Row8 = 10
        Me.lsv_Boveda.Row9 = 10
        Me.lsv_Boveda.Size = New System.Drawing.Size(362, 91)
        Me.lsv_Boveda.TabIndex = 0
        Me.lsv_Boveda.UseCompatibleStateImageBehavior = False
        Me.lsv_Boveda.View = System.Windows.Forms.View.Details
        '
        'frm_ClientesBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 672)
        Me.Controls.Add(Me.Gbx_Controles)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.Tab_Bajas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(850, 710)
        Me.Name = "frm_ClientesBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Clientes"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.Gbx_Controles.ResumeLayout(False)
        Me.Tab_Bajas.ResumeLayout(False)
        Me.Tab_Datos.ResumeLayout(False)
        Me.Tab_Datos.PerformLayout()
        Me.Tab_Pendientes.ResumeLayout(False)
        Me.gbx_Proceso.ResumeLayout(False)
        Me.gbx_Materiales.ResumeLayout(False)
        Me.gbx_Saldo.ResumeLayout(False)
        Me.gbx_Traslado.ResumeLayout(False)
        Me.gbx_Boveda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents lbl_DireccionC As System.Windows.Forms.Label
    Friend WithEvents tbx_DireccionC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CiudadF As System.Windows.Forms.Label
    Friend WithEvents tbx_RFC As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_RFC As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreF As System.Windows.Forms.Label
    Friend WithEvents tbx_DireccionF As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_NombreF As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_DireccionF As System.Windows.Forms.Label
    Friend WithEvents Tab_Bajas As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Datos As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Pendientes As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Traslado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Traslado As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Proceso As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Proceso As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Saldo As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Saldo As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Materiales As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Materiales As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Boveda As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Boveda As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_CiudadF As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Motivo As System.Windows.Forms.Label
    Friend WithEvents cmb_Motivo As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents tbx_Cargo As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Contacto As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Cargo As System.Windows.Forms.Label
    Friend WithEvents tbx_Observaciones As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Archivo As System.Windows.Forms.Label
    Friend WithEvents tbx_Archivo As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_AgregarArchivo As System.Windows.Forms.Button
    Friend WithEvents lbl_ListaNegra As System.Windows.Forms.Label
    Friend WithEvents chk_ListaNegra As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ListaNegraA As System.Windows.Forms.Label
    Friend WithEvents lbl_ComentariosListaNegra As System.Windows.Forms.Label
    Friend WithEvents tbx_ListaNegra As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_TipoCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_TipoCliente As System.Windows.Forms.Label
    Friend WithEvents chk_BajaPermanente As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Alerta As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
End Class
