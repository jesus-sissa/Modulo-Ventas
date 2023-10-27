<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AtencionLlamadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AtencionLlamadas))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.gbx_AtendiendoA = New System.Windows.Forms.GroupBox
        Me.rdb_Nuevo = New System.Windows.Forms.RadioButton
        Me.rdb_Prospecto = New System.Windows.Forms.RadioButton
        Me.rdb_Cliente = New System.Windows.Forms.RadioButton
        Me.gbx_TipoLllamada = New System.Windows.Forms.GroupBox
        Me.rdb_Saliente = New System.Windows.Forms.RadioButton
        Me.rdb_Entrante = New System.Windows.Forms.RadioButton
        Me.gbx_DatosContacto = New System.Windows.Forms.GroupBox
        Me.cmb_Ciudad = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Empresa = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New Modulo_Ventas.cp_Textbox
        Me.lbl_Colonia = New System.Windows.Forms.Label
        Me.tbx_Colonia = New Modulo_Ventas.cp_Textbox
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.tbx_Nombre = New Modulo_Ventas.cp_Textbox
        Me.tbx_Fax = New Modulo_Ventas.cp_Textbox
        Me.lbl_Fax = New System.Windows.Forms.Label
        Me.tbx_Direccion = New Modulo_Ventas.cp_Textbox
        Me.lbl_Direccion = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Telefono = New Modulo_Ventas.cp_Textbox
        Me.lbl_Ciudad = New System.Windows.Forms.Label
        Me.lbl_Telefono = New System.Windows.Forms.Label
        Me.tbx_Correo = New Modulo_Ventas.cp_Textbox
        Me.lbl_Empresa = New System.Windows.Forms.Label
        Me.tbx_Empresa = New Modulo_Ventas.cp_Textbox
        Me.lbl_Correo = New System.Windows.Forms.Label
        Me.lbl_Comoseentero = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Observaiones = New System.Windows.Forms.Label
        Me.btn_Agenda = New System.Windows.Forms.Button
        Me.lbl_ObservacionesEsp = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox
        Me.cmb_Banco = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveLineaServicio = New Modulo_Ventas.cp_Textbox
        Me.cmb_LineaServicio = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Gbx_Horarios = New System.Windows.Forms.GroupBox
        Me.tbx_HorarioDom = New Modulo_Ventas.cp_Textbox
        Me.cbx_Mar = New System.Windows.Forms.CheckBox
        Me.cbx_Vie = New System.Windows.Forms.CheckBox
        Me.cbx_Dom = New System.Windows.Forms.CheckBox
        Me.cbx_Lun = New System.Windows.Forms.CheckBox
        Me.cbx_Sab = New System.Windows.Forms.CheckBox
        Me.tbx_HorarioSab = New Modulo_Ventas.cp_Textbox
        Me.tbx_HorarioVie = New Modulo_Ventas.cp_Textbox
        Me.tbx_HorarioJue = New Modulo_Ventas.cp_Textbox
        Me.tbx_HorarioMie = New Modulo_Ventas.cp_Textbox
        Me.tbx_HorarioMar = New Modulo_Ventas.cp_Textbox
        Me.tbx_HorarioLun = New Modulo_Ventas.cp_Textbox
        Me.cbx_Jue = New System.Windows.Forms.CheckBox
        Me.cbx_Mie = New System.Windows.Forms.CheckBox
        Me.Lbl_Ejemplo = New System.Windows.Forms.Label
        Me.cmb_CiaActual = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.cbx_Morralla = New System.Windows.Forms.CheckBox
        Me.cbx_AcreditarMismoDia = New System.Windows.Forms.CheckBox
        Me.cbx_Proceso = New System.Windows.Forms.CheckBox
        Me.cbx_Ninguna = New System.Windows.Forms.CheckBox
        Me.lbl_FechaHasta = New System.Windows.Forms.Label
        Me.lbl_FechaDesde = New System.Windows.Forms.Label
        Me.cmb_Tipo = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_CuotaActual = New System.Windows.Forms.Label
        Me.lbl_PrecioActual = New System.Windows.Forms.Label
        Me.lbl_Cantidad = New System.Windows.Forms.Label
        Me.lbl_CiaActual = New System.Windows.Forms.Label
        Me.lbl_Dias = New System.Windows.Forms.Label
        Me.tbx_CuotaActual = New Modulo_Ventas.cp_Textbox
        Me.tbx_PrecioActual = New Modulo_Ventas.cp_Textbox
        Me.tbx_Cantidad = New Modulo_Ventas.cp_Textbox
        Me.tbx_Monto = New Modulo_Ventas.cp_Textbox
        Me.lbl_Banco = New System.Windows.Forms.Label
        Me.lbl_MontoAproximado = New System.Windows.Forms.Label
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.tbx_Banco = New Modulo_Ventas.cp_Textbox
        Me.lbl_MotivoCambio = New System.Windows.Forms.Label
        Me.tbx_MotivoCambio = New Modulo_Ventas.cp_Textbox
        Me.tbx_ObservacionesEsp = New Modulo_Ventas.cp_Textbox
        Me.lbl_LineaServicio = New System.Windows.Forms.Label
        Me.gbx_DatosAdicionales = New System.Windows.Forms.GroupBox
        Me.tbx_ComoSeEntero = New Modulo_Ventas.cp_Textbox
        Me.tbx_Observaciones = New Modulo_Ventas.cp_Textbox
        Me.gbx_ServiciosACotizar = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_ServiciosCotizar = New Modulo_Ventas.cp_Listview
        Me.gbx_AtendiendoA.SuspendLayout()
        Me.gbx_TipoLllamada.SuspendLayout()
        Me.gbx_DatosContacto.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Servicios.SuspendLayout()
        Me.Gbx_Horarios.SuspendLayout()
        Me.gbx_DatosAdicionales.SuspendLayout()
        Me.gbx_ServiciosACotizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_AtendiendoA
        '
        Me.gbx_AtendiendoA.Controls.Add(Me.rdb_Nuevo)
        Me.gbx_AtendiendoA.Controls.Add(Me.rdb_Prospecto)
        Me.gbx_AtendiendoA.Controls.Add(Me.rdb_Cliente)
        Me.gbx_AtendiendoA.Location = New System.Drawing.Point(9, 95)
        Me.gbx_AtendiendoA.Name = "gbx_AtendiendoA"
        Me.gbx_AtendiendoA.Size = New System.Drawing.Size(98, 97)
        Me.gbx_AtendiendoA.TabIndex = 1
        Me.gbx_AtendiendoA.TabStop = False
        Me.gbx_AtendiendoA.Text = "Atendiendo a"
        '
        'rdb_Nuevo
        '
        Me.rdb_Nuevo.AutoSize = True
        Me.rdb_Nuevo.Checked = True
        Me.rdb_Nuevo.Location = New System.Drawing.Point(16, 67)
        Me.rdb_Nuevo.Name = "rdb_Nuevo"
        Me.rdb_Nuevo.Size = New System.Drawing.Size(57, 17)
        Me.rdb_Nuevo.TabIndex = 2
        Me.rdb_Nuevo.TabStop = True
        Me.rdb_Nuevo.Text = "Nuevo"
        Me.rdb_Nuevo.UseVisualStyleBackColor = True
        '
        'rdb_Prospecto
        '
        Me.rdb_Prospecto.AutoSize = True
        Me.rdb_Prospecto.Location = New System.Drawing.Point(16, 44)
        Me.rdb_Prospecto.Name = "rdb_Prospecto"
        Me.rdb_Prospecto.Size = New System.Drawing.Size(73, 17)
        Me.rdb_Prospecto.TabIndex = 1
        Me.rdb_Prospecto.Text = "Prospecto"
        Me.rdb_Prospecto.UseVisualStyleBackColor = True
        '
        'rdb_Cliente
        '
        Me.rdb_Cliente.AutoSize = True
        Me.rdb_Cliente.Location = New System.Drawing.Point(16, 21)
        Me.rdb_Cliente.Name = "rdb_Cliente"
        Me.rdb_Cliente.Size = New System.Drawing.Size(57, 17)
        Me.rdb_Cliente.TabIndex = 0
        Me.rdb_Cliente.Text = "Cliente"
        Me.rdb_Cliente.UseVisualStyleBackColor = True
        '
        'gbx_TipoLllamada
        '
        Me.gbx_TipoLllamada.Controls.Add(Me.rdb_Saliente)
        Me.gbx_TipoLllamada.Controls.Add(Me.rdb_Entrante)
        Me.gbx_TipoLllamada.Location = New System.Drawing.Point(9, 8)
        Me.gbx_TipoLllamada.Name = "gbx_TipoLllamada"
        Me.gbx_TipoLllamada.Size = New System.Drawing.Size(98, 79)
        Me.gbx_TipoLllamada.TabIndex = 0
        Me.gbx_TipoLllamada.TabStop = False
        Me.gbx_TipoLllamada.Text = "Tipo Llamada"
        '
        'rdb_Saliente
        '
        Me.rdb_Saliente.AutoSize = True
        Me.rdb_Saliente.Location = New System.Drawing.Point(16, 46)
        Me.rdb_Saliente.Name = "rdb_Saliente"
        Me.rdb_Saliente.Size = New System.Drawing.Size(63, 17)
        Me.rdb_Saliente.TabIndex = 1
        Me.rdb_Saliente.Text = "Saliente"
        Me.rdb_Saliente.UseVisualStyleBackColor = True
        '
        'rdb_Entrante
        '
        Me.rdb_Entrante.AutoSize = True
        Me.rdb_Entrante.Checked = True
        Me.rdb_Entrante.Location = New System.Drawing.Point(16, 23)
        Me.rdb_Entrante.Name = "rdb_Entrante"
        Me.rdb_Entrante.Size = New System.Drawing.Size(65, 17)
        Me.rdb_Entrante.TabIndex = 0
        Me.rdb_Entrante.TabStop = True
        Me.rdb_Entrante.Text = "Entrante"
        Me.rdb_Entrante.UseVisualStyleBackColor = True
        '
        'gbx_DatosContacto
        '
        Me.gbx_DatosContacto.Controls.Add(Me.cmb_Ciudad)
        Me.gbx_DatosContacto.Controls.Add(Me.cmb_Empresa)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Colonia)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Colonia)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Nombre)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Nombre)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Fax)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Fax)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Direccion)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Direccion)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Clave)
        Me.gbx_DatosContacto.Controls.Add(Me.btn_Buscar)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Telefono)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Ciudad)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Telefono)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Correo)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Empresa)
        Me.gbx_DatosContacto.Controls.Add(Me.tbx_Empresa)
        Me.gbx_DatosContacto.Controls.Add(Me.lbl_Correo)
        Me.gbx_DatosContacto.Location = New System.Drawing.Point(113, 8)
        Me.gbx_DatosContacto.Name = "gbx_DatosContacto"
        Me.gbx_DatosContacto.Size = New System.Drawing.Size(507, 184)
        Me.gbx_DatosContacto.TabIndex = 2
        Me.gbx_DatosContacto.TabStop = False
        Me.gbx_DatosContacto.Text = "Datos del Contacto"
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.Clave = Nothing
        Me.cmb_Ciudad.Control_Siguiente = Nothing
        Me.cmb_Ciudad.DisplayMember = "Nombre"
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Empresa = False
        Me.cmb_Ciudad.Filtro = Nothing
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(64, 109)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = False
        Me.cmb_Ciudad.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 12
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'cmb_Empresa
        '
        Me.cmb_Empresa.Clave = "Clave_Cliente"
        Me.cmb_Empresa.Control_Siguiente = Nothing
        Me.cmb_Empresa.DisplayMember = "Nombre_Comercial"
        Me.cmb_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa.Empresa = False
        Me.cmb_Empresa.Filtro = Me.tbx_Clave
        Me.cmb_Empresa.FormattingEnabled = True
        Me.cmb_Empresa.Location = New System.Drawing.Point(120, 38)
        Me.cmb_Empresa.MaxDropDownItems = 20
        Me.cmb_Empresa.Name = "cmb_Empresa"
        Me.cmb_Empresa.Pista = True
        Me.cmb_Empresa.Size = New System.Drawing.Size(340, 21)
        Me.cmb_Empresa.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Empresa.Sucursal = True
        Me.cmb_Empresa.TabIndex = 4
        Me.cmb_Empresa.Tipo = 0
        Me.cmb_Empresa.ValueMember = "Id_Cliente"
        Me.cmb_Empresa.Visible = False
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Nothing
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(64, 39)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 3
        Me.tbx_Clave.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'lbl_Colonia
        '
        Me.lbl_Colonia.AutoSize = True
        Me.lbl_Colonia.Location = New System.Drawing.Point(16, 89)
        Me.lbl_Colonia.Name = "lbl_Colonia"
        Me.lbl_Colonia.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Colonia.TabIndex = 9
        Me.lbl_Colonia.Text = "Colonia"
        '
        'tbx_Colonia
        '
        Me.tbx_Colonia.Control_Siguiente = Nothing
        Me.tbx_Colonia.Filtrado = True
        Me.tbx_Colonia.Location = New System.Drawing.Point(64, 86)
        Me.tbx_Colonia.MaxLength = 100
        Me.tbx_Colonia.Name = "tbx_Colonia"
        Me.tbx_Colonia.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Colonia.TabIndex = 10
        Me.tbx_Colonia.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(14, 19)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre"
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.Control_Siguiente = Nothing
        Me.tbx_Nombre.Filtrado = True
        Me.tbx_Nombre.Location = New System.Drawing.Point(64, 16)
        Me.tbx_Nombre.MaxLength = 100
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Nombre.TabIndex = 1
        Me.tbx_Nombre.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Fax
        '
        Me.tbx_Fax.Control_Siguiente = Nothing
        Me.tbx_Fax.Filtrado = False
        Me.tbx_Fax.Location = New System.Drawing.Point(248, 157)
        Me.tbx_Fax.MaxLength = 50
        Me.tbx_Fax.Name = "tbx_Fax"
        Me.tbx_Fax.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Fax.TabIndex = 18
        Me.tbx_Fax.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Fax
        '
        Me.lbl_Fax.AutoSize = True
        Me.lbl_Fax.Location = New System.Drawing.Point(218, 160)
        Me.lbl_Fax.Name = "lbl_Fax"
        Me.lbl_Fax.Size = New System.Drawing.Size(24, 13)
        Me.lbl_Fax.TabIndex = 17
        Me.lbl_Fax.Text = "Fax"
        '
        'tbx_Direccion
        '
        Me.tbx_Direccion.Control_Siguiente = Nothing
        Me.tbx_Direccion.Filtrado = True
        Me.tbx_Direccion.Location = New System.Drawing.Point(64, 62)
        Me.tbx_Direccion.MaxLength = 200
        Me.tbx_Direccion.Name = "tbx_Direccion"
        Me.tbx_Direccion.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Direccion.TabIndex = 8
        Me.tbx_Direccion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(6, 65)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Direccion.TabIndex = 7
        Me.lbl_Direccion.Text = "Dirección"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(466, 37)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 23)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Telefono
        '
        Me.tbx_Telefono.Control_Siguiente = Nothing
        Me.tbx_Telefono.Filtrado = False
        Me.tbx_Telefono.Location = New System.Drawing.Point(64, 157)
        Me.tbx_Telefono.MaxLength = 100
        Me.tbx_Telefono.Name = "tbx_Telefono"
        Me.tbx_Telefono.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Telefono.TabIndex = 16
        Me.tbx_Telefono.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Ciudad
        '
        Me.lbl_Ciudad.AutoSize = True
        Me.lbl_Ciudad.Location = New System.Drawing.Point(18, 113)
        Me.lbl_Ciudad.Name = "lbl_Ciudad"
        Me.lbl_Ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Ciudad.TabIndex = 11
        Me.lbl_Ciudad.Text = "Ciudad"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(9, 160)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'tbx_Correo
        '
        Me.tbx_Correo.Control_Siguiente = Nothing
        Me.tbx_Correo.Filtrado = True
        Me.tbx_Correo.Location = New System.Drawing.Point(64, 133)
        Me.tbx_Correo.MaxLength = 100
        Me.tbx_Correo.Name = "tbx_Correo"
        Me.tbx_Correo.Size = New System.Drawing.Size(294, 20)
        Me.tbx_Correo.TabIndex = 14
        Me.tbx_Correo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Empresa
        '
        Me.lbl_Empresa.AutoSize = True
        Me.lbl_Empresa.Location = New System.Drawing.Point(10, 42)
        Me.lbl_Empresa.Name = "lbl_Empresa"
        Me.lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Empresa.TabIndex = 2
        Me.lbl_Empresa.Text = "Empresa"
        '
        'tbx_Empresa
        '
        Me.tbx_Empresa.Control_Siguiente = Nothing
        Me.tbx_Empresa.Filtrado = True
        Me.tbx_Empresa.Location = New System.Drawing.Point(64, 39)
        Me.tbx_Empresa.MaxLength = 50
        Me.tbx_Empresa.Name = "tbx_Empresa"
        Me.tbx_Empresa.Size = New System.Drawing.Size(396, 20)
        Me.tbx_Empresa.TabIndex = 5
        Me.tbx_Empresa.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Correo
        '
        Me.lbl_Correo.AutoSize = True
        Me.lbl_Correo.Location = New System.Drawing.Point(20, 136)
        Me.lbl_Correo.Name = "lbl_Correo"
        Me.lbl_Correo.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Correo.TabIndex = 13
        Me.lbl_Correo.Text = "Correo"
        '
        'lbl_Comoseentero
        '
        Me.lbl_Comoseentero.AutoSize = True
        Me.lbl_Comoseentero.Location = New System.Drawing.Point(3, 16)
        Me.lbl_Comoseentero.Name = "lbl_Comoseentero"
        Me.lbl_Comoseentero.Size = New System.Drawing.Size(139, 13)
        Me.lbl_Comoseentero.TabIndex = 0
        Me.lbl_Comoseentero.Text = "Cómo se enteró de nosotros"
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
        'lbl_Observaiones
        '
        Me.lbl_Observaiones.AutoSize = True
        Me.lbl_Observaiones.Location = New System.Drawing.Point(3, 88)
        Me.lbl_Observaiones.Name = "lbl_Observaiones"
        Me.lbl_Observaiones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaiones.TabIndex = 2
        Me.lbl_Observaiones.Text = "Observaciones"
        '
        'btn_Agenda
        '
        Me.btn_Agenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agenda.Image = Global.Modulo_Ventas.My.Resources.Resources.today
        Me.btn_Agenda.Location = New System.Drawing.Point(152, 14)
        Me.btn_Agenda.Name = "btn_Agenda"
        Me.btn_Agenda.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agenda.TabIndex = 1
        Me.btn_Agenda.Text = "Agenda"
        Me.btn_Agenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agenda.UseVisualStyleBackColor = True
        '
        'lbl_ObservacionesEsp
        '
        Me.lbl_ObservacionesEsp.Location = New System.Drawing.Point(565, 161)
        Me.lbl_ObservacionesEsp.Name = "lbl_ObservacionesEsp"
        Me.lbl_ObservacionesEsp.Size = New System.Drawing.Size(64, 35)
        Me.lbl_ObservacionesEsp.TabIndex = 30
        Me.lbl_ObservacionesEsp.Text = "Observac. Especiales"
        Me.lbl_ObservacionesEsp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Agenda)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 560)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(978, 50)
        Me.gbx_Botones.TabIndex = 6
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(832, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.cmb_Banco)
        Me.gbx_Servicios.Controls.Add(Me.tbx_ClaveLineaServicio)
        Me.gbx_Servicios.Controls.Add(Me.cmb_LineaServicio)
        Me.gbx_Servicios.Controls.Add(Me.Gbx_Horarios)
        Me.gbx_Servicios.Controls.Add(Me.cmb_CiaActual)
        Me.gbx_Servicios.Controls.Add(Me.dtp_FechaHasta)
        Me.gbx_Servicios.Controls.Add(Me.dtp_FechaDesde)
        Me.gbx_Servicios.Controls.Add(Me.btn_Agregar)
        Me.gbx_Servicios.Controls.Add(Me.cbx_Morralla)
        Me.gbx_Servicios.Controls.Add(Me.cbx_AcreditarMismoDia)
        Me.gbx_Servicios.Controls.Add(Me.cbx_Proceso)
        Me.gbx_Servicios.Controls.Add(Me.cbx_Ninguna)
        Me.gbx_Servicios.Controls.Add(Me.lbl_FechaHasta)
        Me.gbx_Servicios.Controls.Add(Me.lbl_FechaDesde)
        Me.gbx_Servicios.Controls.Add(Me.cmb_Tipo)
        Me.gbx_Servicios.Controls.Add(Me.lbl_CuotaActual)
        Me.gbx_Servicios.Controls.Add(Me.lbl_PrecioActual)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Cantidad)
        Me.gbx_Servicios.Controls.Add(Me.lbl_CiaActual)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Dias)
        Me.gbx_Servicios.Controls.Add(Me.tbx_CuotaActual)
        Me.gbx_Servicios.Controls.Add(Me.tbx_PrecioActual)
        Me.gbx_Servicios.Controls.Add(Me.tbx_Cantidad)
        Me.gbx_Servicios.Controls.Add(Me.tbx_Monto)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Banco)
        Me.gbx_Servicios.Controls.Add(Me.lbl_MontoAproximado)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Tipo)
        Me.gbx_Servicios.Controls.Add(Me.tbx_Banco)
        Me.gbx_Servicios.Controls.Add(Me.lbl_MotivoCambio)
        Me.gbx_Servicios.Controls.Add(Me.lbl_ObservacionesEsp)
        Me.gbx_Servicios.Controls.Add(Me.tbx_MotivoCambio)
        Me.gbx_Servicios.Controls.Add(Me.tbx_ObservacionesEsp)
        Me.gbx_Servicios.Controls.Add(Me.lbl_LineaServicio)
        Me.gbx_Servicios.Location = New System.Drawing.Point(9, 195)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(978, 263)
        Me.gbx_Servicios.TabIndex = 4
        Me.gbx_Servicios.TabStop = False
        Me.gbx_Servicios.Text = "Servicios"
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = Nothing
        Me.cmb_Banco.Control_Siguiente = Nothing
        Me.cmb_Banco.DisplayMember = "Nombre_Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Nothing
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(86, 211)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Banco.StoredProcedure = "Pro_CajasBancarias_comboGet"
        Me.cmb_Banco.Sucursal = True
        Me.cmb_Banco.TabIndex = 19
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'tbx_ClaveLineaServicio
        '
        Me.tbx_ClaveLineaServicio.Control_Siguiente = Nothing
        Me.tbx_ClaveLineaServicio.Filtrado = True
        Me.tbx_ClaveLineaServicio.Location = New System.Drawing.Point(86, 20)
        Me.tbx_ClaveLineaServicio.MaxLength = 4
        Me.tbx_ClaveLineaServicio.Name = "tbx_ClaveLineaServicio"
        Me.tbx_ClaveLineaServicio.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveLineaServicio.TabIndex = 1
        Me.tbx_ClaveLineaServicio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_LineaServicio
        '
        Me.cmb_LineaServicio.Clave = "Clave"
        Me.cmb_LineaServicio.Control_Siguiente = Nothing
        Me.cmb_LineaServicio.DisplayMember = "Descripcion"
        Me.cmb_LineaServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LineaServicio.Empresa = False
        Me.cmb_LineaServicio.Filtro = Me.tbx_ClaveLineaServicio
        Me.cmb_LineaServicio.FormattingEnabled = True
        Me.cmb_LineaServicio.Location = New System.Drawing.Point(142, 20)
        Me.cmb_LineaServicio.MaxDropDownItems = 20
        Me.cmb_LineaServicio.Name = "cmb_LineaServicio"
        Me.cmb_LineaServicio.Pista = True
        Me.cmb_LineaServicio.Size = New System.Drawing.Size(238, 21)
        Me.cmb_LineaServicio.StoredProcedure = "Cat_Lineas_Get"
        Me.cmb_LineaServicio.Sucursal = False
        Me.cmb_LineaServicio.TabIndex = 2
        Me.cmb_LineaServicio.Tipo = 0
        Me.cmb_LineaServicio.ValueMember = "Id_Linea"
        '
        'Gbx_Horarios
        '
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioDom)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Mar)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Vie)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Dom)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Lun)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Sab)
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioSab)
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioVie)
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioJue)
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioMie)
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioMar)
        Me.Gbx_Horarios.Controls.Add(Me.tbx_HorarioLun)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Jue)
        Me.Gbx_Horarios.Controls.Add(Me.cbx_Mie)
        Me.Gbx_Horarios.Controls.Add(Me.Lbl_Ejemplo)
        Me.Gbx_Horarios.Location = New System.Drawing.Point(86, 115)
        Me.Gbx_Horarios.Name = "Gbx_Horarios"
        Me.Gbx_Horarios.Size = New System.Drawing.Size(467, 66)
        Me.Gbx_Horarios.TabIndex = 15
        Me.Gbx_Horarios.TabStop = False
        '
        'tbx_HorarioDom
        '
        Me.tbx_HorarioDom.Control_Siguiente = Nothing
        Me.tbx_HorarioDom.Enabled = False
        Me.tbx_HorarioDom.Filtrado = False
        Me.tbx_HorarioDom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioDom.Location = New System.Drawing.Point(6, 32)
        Me.tbx_HorarioDom.MaxLength = 11
        Me.tbx_HorarioDom.Name = "tbx_HorarioDom"
        Me.tbx_HorarioDom.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioDom.TabIndex = 1
        Me.tbx_HorarioDom.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cbx_Mar
        '
        Me.cbx_Mar.AutoSize = True
        Me.cbx_Mar.Location = New System.Drawing.Point(138, 13)
        Me.cbx_Mar.Name = "cbx_Mar"
        Me.cbx_Mar.Size = New System.Drawing.Size(44, 17)
        Me.cbx_Mar.TabIndex = 4
        Me.cbx_Mar.Text = "Mar"
        Me.cbx_Mar.UseVisualStyleBackColor = True
        '
        'cbx_Vie
        '
        Me.cbx_Vie.AutoSize = True
        Me.cbx_Vie.Location = New System.Drawing.Point(336, 13)
        Me.cbx_Vie.Name = "cbx_Vie"
        Me.cbx_Vie.Size = New System.Drawing.Size(41, 17)
        Me.cbx_Vie.TabIndex = 10
        Me.cbx_Vie.Text = "Vie"
        Me.cbx_Vie.UseVisualStyleBackColor = True
        '
        'cbx_Dom
        '
        Me.cbx_Dom.AutoSize = True
        Me.cbx_Dom.Location = New System.Drawing.Point(6, 13)
        Me.cbx_Dom.Name = "cbx_Dom"
        Me.cbx_Dom.Size = New System.Drawing.Size(48, 17)
        Me.cbx_Dom.TabIndex = 0
        Me.cbx_Dom.Text = "Dom"
        Me.cbx_Dom.UseVisualStyleBackColor = True
        '
        'cbx_Lun
        '
        Me.cbx_Lun.AutoSize = True
        Me.cbx_Lun.Location = New System.Drawing.Point(72, 13)
        Me.cbx_Lun.Name = "cbx_Lun"
        Me.cbx_Lun.Size = New System.Drawing.Size(44, 17)
        Me.cbx_Lun.TabIndex = 2
        Me.cbx_Lun.Text = "Lun"
        Me.cbx_Lun.UseVisualStyleBackColor = True
        '
        'cbx_Sab
        '
        Me.cbx_Sab.AutoSize = True
        Me.cbx_Sab.Location = New System.Drawing.Point(402, 13)
        Me.cbx_Sab.Name = "cbx_Sab"
        Me.cbx_Sab.Size = New System.Drawing.Size(45, 17)
        Me.cbx_Sab.TabIndex = 12
        Me.cbx_Sab.Text = "Sab"
        Me.cbx_Sab.UseVisualStyleBackColor = True
        '
        'tbx_HorarioSab
        '
        Me.tbx_HorarioSab.Control_Siguiente = Nothing
        Me.tbx_HorarioSab.Enabled = False
        Me.tbx_HorarioSab.Filtrado = False
        Me.tbx_HorarioSab.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioSab.Location = New System.Drawing.Point(402, 32)
        Me.tbx_HorarioSab.MaxLength = 11
        Me.tbx_HorarioSab.Name = "tbx_HorarioSab"
        Me.tbx_HorarioSab.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioSab.TabIndex = 13
        Me.tbx_HorarioSab.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_HorarioVie
        '
        Me.tbx_HorarioVie.Control_Siguiente = Nothing
        Me.tbx_HorarioVie.Enabled = False
        Me.tbx_HorarioVie.Filtrado = False
        Me.tbx_HorarioVie.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioVie.Location = New System.Drawing.Point(336, 32)
        Me.tbx_HorarioVie.MaxLength = 11
        Me.tbx_HorarioVie.Name = "tbx_HorarioVie"
        Me.tbx_HorarioVie.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioVie.TabIndex = 11
        Me.tbx_HorarioVie.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_HorarioJue
        '
        Me.tbx_HorarioJue.Control_Siguiente = Nothing
        Me.tbx_HorarioJue.Enabled = False
        Me.tbx_HorarioJue.Filtrado = False
        Me.tbx_HorarioJue.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioJue.Location = New System.Drawing.Point(270, 32)
        Me.tbx_HorarioJue.MaxLength = 11
        Me.tbx_HorarioJue.Name = "tbx_HorarioJue"
        Me.tbx_HorarioJue.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioJue.TabIndex = 9
        Me.tbx_HorarioJue.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_HorarioMie
        '
        Me.tbx_HorarioMie.Control_Siguiente = Nothing
        Me.tbx_HorarioMie.Enabled = False
        Me.tbx_HorarioMie.Filtrado = False
        Me.tbx_HorarioMie.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioMie.Location = New System.Drawing.Point(204, 32)
        Me.tbx_HorarioMie.MaxLength = 11
        Me.tbx_HorarioMie.Name = "tbx_HorarioMie"
        Me.tbx_HorarioMie.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioMie.TabIndex = 7
        Me.tbx_HorarioMie.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_HorarioMar
        '
        Me.tbx_HorarioMar.Control_Siguiente = Nothing
        Me.tbx_HorarioMar.Enabled = False
        Me.tbx_HorarioMar.Filtrado = False
        Me.tbx_HorarioMar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioMar.Location = New System.Drawing.Point(138, 32)
        Me.tbx_HorarioMar.MaxLength = 11
        Me.tbx_HorarioMar.Name = "tbx_HorarioMar"
        Me.tbx_HorarioMar.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioMar.TabIndex = 5
        Me.tbx_HorarioMar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_HorarioLun
        '
        Me.tbx_HorarioLun.Control_Siguiente = Nothing
        Me.tbx_HorarioLun.Enabled = False
        Me.tbx_HorarioLun.Filtrado = False
        Me.tbx_HorarioLun.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HorarioLun.Location = New System.Drawing.Point(72, 32)
        Me.tbx_HorarioLun.MaxLength = 11
        Me.tbx_HorarioLun.Name = "tbx_HorarioLun"
        Me.tbx_HorarioLun.Size = New System.Drawing.Size(60, 18)
        Me.tbx_HorarioLun.TabIndex = 3
        Me.tbx_HorarioLun.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cbx_Jue
        '
        Me.cbx_Jue.AutoSize = True
        Me.cbx_Jue.Location = New System.Drawing.Point(270, 13)
        Me.cbx_Jue.Name = "cbx_Jue"
        Me.cbx_Jue.Size = New System.Drawing.Size(43, 17)
        Me.cbx_Jue.TabIndex = 8
        Me.cbx_Jue.Text = "Jue"
        Me.cbx_Jue.UseVisualStyleBackColor = True
        '
        'cbx_Mie
        '
        Me.cbx_Mie.AutoSize = True
        Me.cbx_Mie.Location = New System.Drawing.Point(204, 13)
        Me.cbx_Mie.Name = "cbx_Mie"
        Me.cbx_Mie.Size = New System.Drawing.Size(43, 17)
        Me.cbx_Mie.TabIndex = 6
        Me.cbx_Mie.Text = "Mie"
        Me.cbx_Mie.UseVisualStyleBackColor = True
        '
        'Lbl_Ejemplo
        '
        Me.Lbl_Ejemplo.AutoSize = True
        Me.Lbl_Ejemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ejemplo.Location = New System.Drawing.Point(5, 52)
        Me.Lbl_Ejemplo.Name = "Lbl_Ejemplo"
        Me.Lbl_Ejemplo.Size = New System.Drawing.Size(92, 12)
        Me.Lbl_Ejemplo.TabIndex = 3
        Me.Lbl_Ejemplo.Text = "Ejemplo: 10:00-11:00"
        '
        'cmb_CiaActual
        '
        Me.cmb_CiaActual.Clave = Nothing
        Me.cmb_CiaActual.Control_Siguiente = Nothing
        Me.cmb_CiaActual.DisplayMember = "Nombre"
        Me.cmb_CiaActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiaActual.Empresa = False
        Me.cmb_CiaActual.Filtro = Nothing
        Me.cmb_CiaActual.FormattingEnabled = True
        Me.cmb_CiaActual.Location = New System.Drawing.Point(635, 19)
        Me.cmb_CiaActual.MaxDropDownItems = 20
        Me.cmb_CiaActual.Name = "cmb_CiaActual"
        Me.cmb_CiaActual.Pista = True
        Me.cmb_CiaActual.Size = New System.Drawing.Size(300, 21)
        Me.cmb_CiaActual.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_CiaActual.Sucursal = False
        Me.cmb_CiaActual.TabIndex = 22
        Me.cmb_CiaActual.Tipo = 0
        Me.cmb_CiaActual.ValueMember = "Id_Cia"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(255, 95)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaHasta.TabIndex = 13
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(86, 95)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaDesde.TabIndex = 11
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(827, 227)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 32
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'cbx_Morralla
        '
        Me.cbx_Morralla.AutoSize = True
        Me.cbx_Morralla.Location = New System.Drawing.Point(177, 73)
        Me.cbx_Morralla.Name = "cbx_Morralla"
        Me.cbx_Morralla.Size = New System.Drawing.Size(63, 17)
        Me.cbx_Morralla.TabIndex = 8
        Me.cbx_Morralla.Text = "Morralla"
        Me.cbx_Morralla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbx_Morralla.UseVisualStyleBackColor = True
        '
        'cbx_AcreditarMismoDia
        '
        Me.cbx_AcreditarMismoDia.AutoSize = True
        Me.cbx_AcreditarMismoDia.Enabled = False
        Me.cbx_AcreditarMismoDia.Location = New System.Drawing.Point(270, 73)
        Me.cbx_AcreditarMismoDia.Name = "cbx_AcreditarMismoDia"
        Me.cbx_AcreditarMismoDia.Size = New System.Drawing.Size(119, 17)
        Me.cbx_AcreditarMismoDia.TabIndex = 9
        Me.cbx_AcreditarMismoDia.Text = "Acreditar mismo día"
        Me.cbx_AcreditarMismoDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbx_AcreditarMismoDia.UseVisualStyleBackColor = True
        '
        'cbx_Proceso
        '
        Me.cbx_Proceso.AutoSize = True
        Me.cbx_Proceso.Location = New System.Drawing.Point(86, 73)
        Me.cbx_Proceso.Name = "cbx_Proceso"
        Me.cbx_Proceso.Size = New System.Drawing.Size(65, 17)
        Me.cbx_Proceso.TabIndex = 7
        Me.cbx_Proceso.Text = "Proceso"
        Me.cbx_Proceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbx_Proceso.UseVisualStyleBackColor = True
        '
        'cbx_Ninguna
        '
        Me.cbx_Ninguna.AutoSize = True
        Me.cbx_Ninguna.Location = New System.Drawing.Point(635, 43)
        Me.cbx_Ninguna.Name = "cbx_Ninguna"
        Me.cbx_Ninguna.Size = New System.Drawing.Size(66, 17)
        Me.cbx_Ninguna.TabIndex = 23
        Me.cbx_Ninguna.Text = "Ninguna"
        Me.cbx_Ninguna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbx_Ninguna.UseVisualStyleBackColor = True
        '
        'lbl_FechaHasta
        '
        Me.lbl_FechaHasta.AutoSize = True
        Me.lbl_FechaHasta.Location = New System.Drawing.Point(187, 101)
        Me.lbl_FechaHasta.Name = "lbl_FechaHasta"
        Me.lbl_FechaHasta.Size = New System.Drawing.Size(62, 13)
        Me.lbl_FechaHasta.TabIndex = 12
        Me.lbl_FechaHasta.Text = "Fin Servicio"
        '
        'lbl_FechaDesde
        '
        Me.lbl_FechaDesde.AutoSize = True
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(7, 99)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(73, 13)
        Me.lbl_FechaDesde.TabIndex = 10
        Me.lbl_FechaDesde.Text = "Inicio Servicio"
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(86, 46)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(111, 21)
        Me.cmb_Tipo.TabIndex = 4
        Me.cmb_Tipo.ValueMember = "value"
        '
        'lbl_CuotaActual
        '
        Me.lbl_CuotaActual.AutoSize = True
        Me.lbl_CuotaActual.Location = New System.Drawing.Point(751, 64)
        Me.lbl_CuotaActual.Name = "lbl_CuotaActual"
        Me.lbl_CuotaActual.Size = New System.Drawing.Size(68, 13)
        Me.lbl_CuotaActual.TabIndex = 26
        Me.lbl_CuotaActual.Text = "Cuota Actual"
        '
        'lbl_PrecioActual
        '
        Me.lbl_PrecioActual.AutoSize = True
        Me.lbl_PrecioActual.Location = New System.Drawing.Point(561, 66)
        Me.lbl_PrecioActual.Name = "lbl_PrecioActual"
        Me.lbl_PrecioActual.Size = New System.Drawing.Size(70, 13)
        Me.lbl_PrecioActual.TabIndex = 24
        Me.lbl_PrecioActual.Text = "Precio Actual"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(215, 49)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cantidad.TabIndex = 5
        Me.lbl_Cantidad.Text = "Cantidad"
        '
        'lbl_CiaActual
        '
        Me.lbl_CiaActual.AutoSize = True
        Me.lbl_CiaActual.Location = New System.Drawing.Point(542, 23)
        Me.lbl_CiaActual.Name = "lbl_CiaActual"
        Me.lbl_CiaActual.Size = New System.Drawing.Size(89, 13)
        Me.lbl_CiaActual.TabIndex = 21
        Me.lbl_CiaActual.Text = "Compañía Actual"
        '
        'lbl_Dias
        '
        Me.lbl_Dias.AutoSize = True
        Me.lbl_Dias.Location = New System.Drawing.Point(6, 134)
        Me.lbl_Dias.Name = "lbl_Dias"
        Me.lbl_Dias.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Dias.TabIndex = 14
        Me.lbl_Dias.Text = "Días/Horarios"
        '
        'tbx_CuotaActual
        '
        Me.tbx_CuotaActual.Control_Siguiente = Nothing
        Me.tbx_CuotaActual.Filtrado = False
        Me.tbx_CuotaActual.Location = New System.Drawing.Point(825, 61)
        Me.tbx_CuotaActual.MaxLength = 10
        Me.tbx_CuotaActual.Name = "tbx_CuotaActual"
        Me.tbx_CuotaActual.Size = New System.Drawing.Size(110, 20)
        Me.tbx_CuotaActual.TabIndex = 27
        Me.tbx_CuotaActual.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_PrecioActual
        '
        Me.tbx_PrecioActual.Control_Siguiente = Nothing
        Me.tbx_PrecioActual.Filtrado = False
        Me.tbx_PrecioActual.Location = New System.Drawing.Point(635, 63)
        Me.tbx_PrecioActual.MaxLength = 10
        Me.tbx_PrecioActual.Name = "tbx_PrecioActual"
        Me.tbx_PrecioActual.Size = New System.Drawing.Size(110, 20)
        Me.tbx_PrecioActual.TabIndex = 25
        Me.tbx_PrecioActual.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Nothing
        Me.tbx_Cantidad.Filtrado = False
        Me.tbx_Cantidad.Location = New System.Drawing.Point(270, 46)
        Me.tbx_Cantidad.MaxLength = 10
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Cantidad.TabIndex = 6
        Me.tbx_Cantidad.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Monto
        '
        Me.tbx_Monto.Control_Siguiente = Nothing
        Me.tbx_Monto.Filtrado = False
        Me.tbx_Monto.Location = New System.Drawing.Point(87, 186)
        Me.tbx_Monto.MaxLength = 10
        Me.tbx_Monto.Name = "tbx_Monto"
        Me.tbx_Monto.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Monto.TabIndex = 17
        Me.tbx_Monto.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(7, 214)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Banco.TabIndex = 18
        Me.lbl_Banco.Text = "Caja Bancaria"
        '
        'lbl_MontoAproximado
        '
        Me.lbl_MontoAproximado.AutoSize = True
        Me.lbl_MontoAproximado.Location = New System.Drawing.Point(11, 189)
        Me.lbl_MontoAproximado.Name = "lbl_MontoAproximado"
        Me.lbl_MontoAproximado.Size = New System.Drawing.Size(70, 13)
        Me.lbl_MontoAproximado.TabIndex = 16
        Me.lbl_MontoAproximado.Text = "Monto Apróx."
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(52, 49)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Tipo.TabIndex = 3
        Me.lbl_Tipo.Text = "Tipo"
        '
        'tbx_Banco
        '
        Me.tbx_Banco.Control_Siguiente = Nothing
        Me.tbx_Banco.Filtrado = True
        Me.tbx_Banco.Location = New System.Drawing.Point(86, 237)
        Me.tbx_Banco.MaxLength = 50
        Me.tbx_Banco.Name = "tbx_Banco"
        Me.tbx_Banco.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Banco.TabIndex = 20
        Me.tbx_Banco.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_MotivoCambio
        '
        Me.lbl_MotivoCambio.AutoSize = True
        Me.lbl_MotivoCambio.Location = New System.Drawing.Point(552, 90)
        Me.lbl_MotivoCambio.Name = "lbl_MotivoCambio"
        Me.lbl_MotivoCambio.Size = New System.Drawing.Size(77, 13)
        Me.lbl_MotivoCambio.TabIndex = 28
        Me.lbl_MotivoCambio.Text = "Motivo Cambio"
        '
        'tbx_MotivoCambio
        '
        Me.tbx_MotivoCambio.Control_Siguiente = Nothing
        Me.tbx_MotivoCambio.Filtrado = True
        Me.tbx_MotivoCambio.Location = New System.Drawing.Point(635, 87)
        Me.tbx_MotivoCambio.MaxLength = 250
        Me.tbx_MotivoCambio.Multiline = True
        Me.tbx_MotivoCambio.Name = "tbx_MotivoCambio"
        Me.tbx_MotivoCambio.Size = New System.Drawing.Size(332, 63)
        Me.tbx_MotivoCambio.TabIndex = 29
        Me.tbx_MotivoCambio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_ObservacionesEsp
        '
        Me.tbx_ObservacionesEsp.Control_Siguiente = Nothing
        Me.tbx_ObservacionesEsp.Filtrado = True
        Me.tbx_ObservacionesEsp.Location = New System.Drawing.Point(635, 154)
        Me.tbx_ObservacionesEsp.MaxLength = 250
        Me.tbx_ObservacionesEsp.Multiline = True
        Me.tbx_ObservacionesEsp.Name = "tbx_ObservacionesEsp"
        Me.tbx_ObservacionesEsp.Size = New System.Drawing.Size(332, 63)
        Me.tbx_ObservacionesEsp.TabIndex = 31
        Me.tbx_ObservacionesEsp.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_LineaServicio
        '
        Me.lbl_LineaServicio.AutoSize = True
        Me.lbl_LineaServicio.Location = New System.Drawing.Point(6, 23)
        Me.lbl_LineaServicio.Name = "lbl_LineaServicio"
        Me.lbl_LineaServicio.Size = New System.Drawing.Size(74, 13)
        Me.lbl_LineaServicio.TabIndex = 0
        Me.lbl_LineaServicio.Text = "Linea Servicio"
        '
        'gbx_DatosAdicionales
        '
        Me.gbx_DatosAdicionales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosAdicionales.Controls.Add(Me.tbx_ComoSeEntero)
        Me.gbx_DatosAdicionales.Controls.Add(Me.lbl_Comoseentero)
        Me.gbx_DatosAdicionales.Controls.Add(Me.tbx_Observaciones)
        Me.gbx_DatosAdicionales.Controls.Add(Me.lbl_Observaiones)
        Me.gbx_DatosAdicionales.Location = New System.Drawing.Point(627, 8)
        Me.gbx_DatosAdicionales.Name = "gbx_DatosAdicionales"
        Me.gbx_DatosAdicionales.Size = New System.Drawing.Size(360, 184)
        Me.gbx_DatosAdicionales.TabIndex = 3
        Me.gbx_DatosAdicionales.TabStop = False
        Me.gbx_DatosAdicionales.Text = "Datos Adicionales"
        '
        'tbx_ComoSeEntero
        '
        Me.tbx_ComoSeEntero.Control_Siguiente = Nothing
        Me.tbx_ComoSeEntero.Filtrado = True
        Me.tbx_ComoSeEntero.Location = New System.Drawing.Point(6, 33)
        Me.tbx_ComoSeEntero.MaxLength = 250
        Me.tbx_ComoSeEntero.Multiline = True
        Me.tbx_ComoSeEntero.Name = "tbx_ComoSeEntero"
        Me.tbx_ComoSeEntero.Size = New System.Drawing.Size(343, 51)
        Me.tbx_ComoSeEntero.TabIndex = 1
        Me.tbx_ComoSeEntero.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Control_Siguiente = Nothing
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(6, 105)
        Me.tbx_Observaciones.MaxLength = 250
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(343, 70)
        Me.tbx_Observaciones.TabIndex = 3
        Me.tbx_Observaciones.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'gbx_ServiciosACotizar
        '
        Me.gbx_ServiciosACotizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ServiciosACotizar.Controls.Add(Me.Lbl_Registros)
        Me.gbx_ServiciosACotizar.Controls.Add(Me.lsv_ServiciosCotizar)
        Me.gbx_ServiciosACotizar.Location = New System.Drawing.Point(9, 461)
        Me.gbx_ServiciosACotizar.Name = "gbx_ServiciosACotizar"
        Me.gbx_ServiciosACotizar.Size = New System.Drawing.Size(978, 99)
        Me.gbx_ServiciosACotizar.TabIndex = 5
        Me.gbx_ServiciosACotizar.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(817, 12)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(155, 17)
        Me.Lbl_Registros.TabIndex = 19
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ServiciosCotizar
        '
        Me.lsv_ServiciosCotizar.AllowColumnReorder = True
        Me.lsv_ServiciosCotizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ServiciosCotizar.FullRowSelect = True
        Me.lsv_ServiciosCotizar.HideSelection = False
        Me.lsv_ServiciosCotizar.Location = New System.Drawing.Point(3, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ServiciosCotizar.Lvs = ListViewColumnSorter1
        Me.lsv_ServiciosCotizar.MultiSelect = False
        Me.lsv_ServiciosCotizar.Name = "lsv_ServiciosCotizar"
        Me.lsv_ServiciosCotizar.Row1 = 10
        Me.lsv_ServiciosCotizar.Row10 = 10
        Me.lsv_ServiciosCotizar.Row2 = 10
        Me.lsv_ServiciosCotizar.Row3 = 10
        Me.lsv_ServiciosCotizar.Row4 = 10
        Me.lsv_ServiciosCotizar.Row5 = 10
        Me.lsv_ServiciosCotizar.Row6 = 10
        Me.lsv_ServiciosCotizar.Row7 = 10
        Me.lsv_ServiciosCotizar.Row8 = 10
        Me.lsv_ServiciosCotizar.Row9 = 10
        Me.lsv_ServiciosCotizar.Size = New System.Drawing.Size(972, 63)
        Me.lsv_ServiciosCotizar.TabIndex = 0
        Me.lsv_ServiciosCotizar.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosCotizar.View = System.Windows.Forms.View.Details
        '
        'frm_AtencionLlamadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 621)
        Me.Controls.Add(Me.gbx_ServiciosACotizar)
        Me.Controls.Add(Me.gbx_DatosAdicionales)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_AtendiendoA)
        Me.Controls.Add(Me.gbx_DatosContacto)
        Me.Controls.Add(Me.gbx_TipoLllamada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frm_AtencionLlamadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atención de Llamadas"
        Me.gbx_AtendiendoA.ResumeLayout(False)
        Me.gbx_AtendiendoA.PerformLayout()
        Me.gbx_TipoLllamada.ResumeLayout(False)
        Me.gbx_TipoLllamada.PerformLayout()
        Me.gbx_DatosContacto.ResumeLayout(False)
        Me.gbx_DatosContacto.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Servicios.PerformLayout()
        Me.Gbx_Horarios.ResumeLayout(False)
        Me.Gbx_Horarios.PerformLayout()
        Me.gbx_DatosAdicionales.ResumeLayout(False)
        Me.gbx_DatosAdicionales.PerformLayout()
        Me.gbx_ServiciosACotizar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_AtendiendoA As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_TipoLllamada As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Saliente As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Entrante As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Prospecto As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Nuevo As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_DatosContacto As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents tbx_Telefono As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents tbx_Correo As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Correo As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_ObservacionesEsp As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_ObservacionesEsp As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Clave As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Empresa As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Agenda As System.Windows.Forms.Button
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Direccion As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents tbx_Fax As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Fax As System.Windows.Forms.Label
    Friend WithEvents lbl_LineaServicio As System.Windows.Forms.Label
    Friend WithEvents gbx_DatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Dias As System.Windows.Forms.Label
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents tbx_Monto As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_MontoAproximado As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_CiaActual As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioActual As System.Windows.Forms.Label
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombre As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Colonia As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Colonia As System.Windows.Forms.Label
    Friend WithEvents tbx_ComoSeEntero As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Comoseentero As System.Windows.Forms.Label
    Friend WithEvents lbl_Ciudad As System.Windows.Forms.Label
    Friend WithEvents tbx_Banco As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Observaciones As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Observaiones As System.Windows.Forms.Label
    Friend WithEvents tbx_PrecioActual As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Cantidad As Modulo_Ventas.cp_Textbox
    Friend WithEvents cbx_Lun As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Mar As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Dom As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Mie As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Jue As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Vie As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Sab As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Tipo As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_FechaHasta As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaDesde As System.Windows.Forms.Label
    Friend WithEvents cbx_Ninguna As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_CuotaActual As System.Windows.Forms.Label
    Friend WithEvents tbx_CuotaActual As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_MotivoCambio As System.Windows.Forms.Label
    Friend WithEvents tbx_MotivoCambio As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_ServiciosACotizar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lsv_ServiciosCotizar As Modulo_Ventas.cp_Listview
    Friend WithEvents cbx_Morralla As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_AcreditarMismoDia As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Proceso As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_CiaActual As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Empresa As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Gbx_Horarios As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Ciudad As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_LineaServicio As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveLineaServicio As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Banco As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_HorarioDom As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_HorarioLun As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_HorarioSab As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_HorarioVie As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_HorarioJue As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_HorarioMie As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_HorarioMar As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Ejemplo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
