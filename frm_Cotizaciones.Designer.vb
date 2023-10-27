<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cotizaciones
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
        Me.gbx_DatosComerciales = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_NumLlamada = New Modulo_Ventas.cp_Textbox
        Me.tbx_NombreEmpresa = New Modulo_Ventas.cp_Textbox
        Me.lbl_Empresa = New System.Windows.Forms.Label
        Me.lbl_NumLlamada = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Precio = New System.Windows.Forms.GroupBox
        Me.Lbl_MontoAprox = New System.Windows.Forms.Label
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.cmb_Precio = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_CvePrecio = New Modulo_Ventas.cp_Textbox
        Me.cmb_PrecioDescripcion = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_CuotaRiesgo = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveCuotaRiesgo = New Modulo_Ventas.cp_Textbox
        Me.cmb_Kilometraje = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveKilometraje = New Modulo_Ventas.cp_Textbox
        Me.cmb_LineaServicio = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveLinea = New Modulo_Ventas.cp_Textbox
        Me.tbx_DescripcionKM = New Modulo_Ventas.cp_Textbox
        Me.tbx_DescripcionPrecio = New Modulo_Ventas.cp_Textbox
        Me.tbx_DescripcionCR = New Modulo_Ventas.cp_Textbox
        Me.tbx_CantidadKilometraje = New Modulo_Ventas.cp_Textbox
        Me.tbx_CantidadCuotaRiesgo = New Modulo_Ventas.cp_Textbox
        Me.tbx_MontoAprox = New Modulo_Ventas.cp_Textbox
        Me.tbx_CantidadPrecio = New Modulo_Ventas.cp_Textbox
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lbl_LineaServicio = New System.Windows.Forms.Label
        Me.Lbl_Observaciones = New System.Windows.Forms.Label
        Me.Lbl_Cantidad = New System.Windows.Forms.Label
        Me.Lbl_Precio = New System.Windows.Forms.Label
        Me.Lbl_CoutaRiesgo = New System.Windows.Forms.Label
        Me.lbl_Kilometraje = New System.Windows.Forms.Label
        Me.lbl_FechaInicio = New System.Windows.Forms.Label
        Me.ServiciosCotizar = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_ServiciosCotizar = New Modulo_Ventas.cp_Listview
        Me.gbx_ServiciosSolicitudes = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_ServiciosSolicitados = New Modulo_Ventas.cp_Listview
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.lbl_CantidadTotal = New System.Windows.Forms.Label
        Me.gbx_DatosComerciales.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Precio.SuspendLayout()
        Me.ServiciosCotizar.SuspendLayout()
        Me.gbx_ServiciosSolicitudes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_DatosComerciales
        '
        Me.gbx_DatosComerciales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DatosComerciales.Controls.Add(Me.btn_Buscar)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_NumLlamada)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_NombreEmpresa)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Empresa)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_NumLlamada)
        Me.gbx_DatosComerciales.Location = New System.Drawing.Point(12, 3)
        Me.gbx_DatosComerciales.Name = "gbx_DatosComerciales"
        Me.gbx_DatosComerciales.Size = New System.Drawing.Size(890, 77)
        Me.gbx_DatosComerciales.TabIndex = 0
        Me.gbx_DatosComerciales.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(157, 15)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_NumLlamada
        '
        Me.tbx_NumLlamada.Control_Siguiente = Nothing
        Me.tbx_NumLlamada.Filtrado = True
        Me.tbx_NumLlamada.Location = New System.Drawing.Point(101, 18)
        Me.tbx_NumLlamada.MaxLength = 4
        Me.tbx_NumLlamada.Name = "tbx_NumLlamada"
        Me.tbx_NumLlamada.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumLlamada.TabIndex = 1
        Me.tbx_NumLlamada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NumLlamada.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_NombreEmpresa
        '
        Me.tbx_NombreEmpresa.Control_Siguiente = Nothing
        Me.tbx_NombreEmpresa.Filtrado = True
        Me.tbx_NombreEmpresa.Location = New System.Drawing.Point(101, 44)
        Me.tbx_NombreEmpresa.MaxLength = 50
        Me.tbx_NombreEmpresa.Name = "tbx_NombreEmpresa"
        Me.tbx_NombreEmpresa.Size = New System.Drawing.Size(599, 20)
        Me.tbx_NombreEmpresa.TabIndex = 4
        Me.tbx_NombreEmpresa.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Empresa
        '
        Me.lbl_Empresa.AutoSize = True
        Me.lbl_Empresa.Location = New System.Drawing.Point(47, 47)
        Me.lbl_Empresa.Name = "lbl_Empresa"
        Me.lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Empresa.TabIndex = 3
        Me.lbl_Empresa.Text = "Empresa"
        '
        'lbl_NumLlamada
        '
        Me.lbl_NumLlamada.AutoSize = True
        Me.lbl_NumLlamada.Location = New System.Drawing.Point(28, 20)
        Me.lbl_NumLlamada.Name = "lbl_NumLlamada"
        Me.lbl_NumLlamada.Size = New System.Drawing.Size(67, 13)
        Me.lbl_NumLlamada.TabIndex = 0
        Me.lbl_NumLlamada.Text = "No. Llamada"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 637)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(890, 50)
        Me.gbx_Botones.TabIndex = 4
        Me.gbx_Botones.TabStop = False
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Imprimir.Enabled = False
        Me.btn_Imprimir.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(152, 14)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 1
        Me.btn_Imprimir.Text = "&Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
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
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(744, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Precio
        '
        Me.gbx_Precio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Precio.Controls.Add(Me.Lbl_MontoAprox)
        Me.gbx_Precio.Controls.Add(Me.btn_Agregar)
        Me.gbx_Precio.Controls.Add(Me.cmb_Precio)
        Me.gbx_Precio.Controls.Add(Me.cmb_PrecioDescripcion)
        Me.gbx_Precio.Controls.Add(Me.cmb_CuotaRiesgo)
        Me.gbx_Precio.Controls.Add(Me.cmb_Kilometraje)
        Me.gbx_Precio.Controls.Add(Me.cmb_LineaServicio)
        Me.gbx_Precio.Controls.Add(Me.tbx_DescripcionKM)
        Me.gbx_Precio.Controls.Add(Me.tbx_DescripcionPrecio)
        Me.gbx_Precio.Controls.Add(Me.tbx_DescripcionCR)
        Me.gbx_Precio.Controls.Add(Me.tbx_CantidadKilometraje)
        Me.gbx_Precio.Controls.Add(Me.tbx_CantidadCuotaRiesgo)
        Me.gbx_Precio.Controls.Add(Me.tbx_MontoAprox)
        Me.gbx_Precio.Controls.Add(Me.tbx_CantidadPrecio)
        Me.gbx_Precio.Controls.Add(Me.tbx_CvePrecio)
        Me.gbx_Precio.Controls.Add(Me.tbx_CveCuotaRiesgo)
        Me.gbx_Precio.Controls.Add(Me.tbx_CveKilometraje)
        Me.gbx_Precio.Controls.Add(Me.tbx_CveLinea)
        Me.gbx_Precio.Controls.Add(Me.dtp_FechaInicio)
        Me.gbx_Precio.Controls.Add(Me.lbl_LineaServicio)
        Me.gbx_Precio.Controls.Add(Me.Lbl_Observaciones)
        Me.gbx_Precio.Controls.Add(Me.Lbl_Cantidad)
        Me.gbx_Precio.Controls.Add(Me.Lbl_Precio)
        Me.gbx_Precio.Controls.Add(Me.Lbl_CoutaRiesgo)
        Me.gbx_Precio.Controls.Add(Me.lbl_Kilometraje)
        Me.gbx_Precio.Controls.Add(Me.lbl_FechaInicio)
        Me.gbx_Precio.Location = New System.Drawing.Point(12, 209)
        Me.gbx_Precio.Name = "gbx_Precio"
        Me.gbx_Precio.Size = New System.Drawing.Size(890, 187)
        Me.gbx_Precio.TabIndex = 2
        Me.gbx_Precio.TabStop = False
        Me.gbx_Precio.Text = "Precios"
        '
        'Lbl_MontoAprox
        '
        Me.Lbl_MontoAprox.AutoSize = True
        Me.Lbl_MontoAprox.Location = New System.Drawing.Point(25, 155)
        Me.Lbl_MontoAprox.Name = "Lbl_MontoAprox"
        Me.Lbl_MontoAprox.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_MontoAprox.TabIndex = 39
        Me.Lbl_MontoAprox.Text = "Monto Apróx."
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(563, 151)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 38
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'cmb_Precio
        '
        Me.cmb_Precio.Clave = "Clave"
        Me.cmb_Precio.Control_Siguiente = Nothing
        Me.cmb_Precio.DisplayMember = "Descripcion"
        Me.cmb_Precio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Precio.Empresa = False
        Me.cmb_Precio.Filtro = Me.tbx_CvePrecio
        Me.cmb_Precio.FormattingEnabled = True
        Me.cmb_Precio.Location = New System.Drawing.Point(157, 72)
        Me.cmb_Precio.MaxDropDownItems = 20
        Me.cmb_Precio.Name = "cmb_Precio"
        Me.cmb_Precio.Pista = False
        Me.cmb_Precio.Size = New System.Drawing.Size(73, 21)
        Me.cmb_Precio.StoredProcedure = "Cat_Precios_GetCombo"
        Me.cmb_Precio.Sucursal = False
        Me.cmb_Precio.TabIndex = 8
        Me.cmb_Precio.Tipo = 0
        Me.cmb_Precio.ValueMember = "Id_Precio"
        '
        'tbx_CvePrecio
        '
        Me.tbx_CvePrecio.Control_Siguiente = Nothing
        Me.tbx_CvePrecio.Filtrado = True
        Me.tbx_CvePrecio.Location = New System.Drawing.Point(101, 73)
        Me.tbx_CvePrecio.MaxLength = 4
        Me.tbx_CvePrecio.Name = "tbx_CvePrecio"
        Me.tbx_CvePrecio.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CvePrecio.TabIndex = 6
        Me.tbx_CvePrecio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_PrecioDescripcion
        '
        Me.cmb_PrecioDescripcion.Clave = ""
        Me.cmb_PrecioDescripcion.Control_Siguiente = Nothing
        Me.cmb_PrecioDescripcion.DisplayMember = "Descripcion"
        Me.cmb_PrecioDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PrecioDescripcion.Empresa = False
        Me.cmb_PrecioDescripcion.Filtro = Nothing
        Me.cmb_PrecioDescripcion.FormattingEnabled = True
        Me.cmb_PrecioDescripcion.Location = New System.Drawing.Point(236, 72)
        Me.cmb_PrecioDescripcion.MaxDropDownItems = 20
        Me.cmb_PrecioDescripcion.Name = "cmb_PrecioDescripcion"
        Me.cmb_PrecioDescripcion.Pista = False
        Me.cmb_PrecioDescripcion.Size = New System.Drawing.Size(321, 21)
        Me.cmb_PrecioDescripcion.StoredProcedure = "Cat_PreciosDescripcion_Get"
        Me.cmb_PrecioDescripcion.Sucursal = False
        Me.cmb_PrecioDescripcion.TabIndex = 7
        Me.cmb_PrecioDescripcion.Tipo = 0
        Me.cmb_PrecioDescripcion.ValueMember = "Id_PrecioDescripcion"
        '
        'cmb_CuotaRiesgo
        '
        Me.cmb_CuotaRiesgo.Clave = "Clave"
        Me.cmb_CuotaRiesgo.Control_Siguiente = Nothing
        Me.cmb_CuotaRiesgo.DisplayMember = "Descripcion"
        Me.cmb_CuotaRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CuotaRiesgo.Empresa = True
        Me.cmb_CuotaRiesgo.Filtro = Me.tbx_CveCuotaRiesgo
        Me.cmb_CuotaRiesgo.FormattingEnabled = True
        Me.cmb_CuotaRiesgo.Location = New System.Drawing.Point(157, 99)
        Me.cmb_CuotaRiesgo.MaxDropDownItems = 20
        Me.cmb_CuotaRiesgo.Name = "cmb_CuotaRiesgo"
        Me.cmb_CuotaRiesgo.Pista = True
        Me.cmb_CuotaRiesgo.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CuotaRiesgo.StoredProcedure = "Cat_CuotaRiesgoEmpresa_Get"
        Me.cmb_CuotaRiesgo.Sucursal = False
        Me.cmb_CuotaRiesgo.TabIndex = 12
        Me.cmb_CuotaRiesgo.Tipo = 0
        Me.cmb_CuotaRiesgo.ValueMember = "Id_CR"
        '
        'tbx_CveCuotaRiesgo
        '
        Me.tbx_CveCuotaRiesgo.Control_Siguiente = Nothing
        Me.tbx_CveCuotaRiesgo.Filtrado = True
        Me.tbx_CveCuotaRiesgo.Location = New System.Drawing.Point(101, 100)
        Me.tbx_CveCuotaRiesgo.MaxLength = 4
        Me.tbx_CveCuotaRiesgo.Name = "tbx_CveCuotaRiesgo"
        Me.tbx_CveCuotaRiesgo.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveCuotaRiesgo.TabIndex = 11
        Me.tbx_CveCuotaRiesgo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Kilometraje
        '
        Me.cmb_Kilometraje.Clave = "Clave"
        Me.cmb_Kilometraje.Control_Siguiente = Nothing
        Me.cmb_Kilometraje.DisplayMember = "Descripcion"
        Me.cmb_Kilometraje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Kilometraje.Empresa = True
        Me.cmb_Kilometraje.Filtro = Me.tbx_CveKilometraje
        Me.cmb_Kilometraje.FormattingEnabled = True
        Me.cmb_Kilometraje.Location = New System.Drawing.Point(157, 126)
        Me.cmb_Kilometraje.MaxDropDownItems = 20
        Me.cmb_Kilometraje.Name = "cmb_Kilometraje"
        Me.cmb_Kilometraje.Pista = True
        Me.cmb_Kilometraje.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Kilometraje.StoredProcedure = "Cat_KilometrosEmpresa_Get"
        Me.cmb_Kilometraje.Sucursal = False
        Me.cmb_Kilometraje.TabIndex = 22
        Me.cmb_Kilometraje.Tipo = 0
        Me.cmb_Kilometraje.ValueMember = "Id_KM"
        '
        'tbx_CveKilometraje
        '
        Me.tbx_CveKilometraje.Control_Siguiente = Nothing
        Me.tbx_CveKilometraje.Filtrado = True
        Me.tbx_CveKilometraje.Location = New System.Drawing.Point(101, 126)
        Me.tbx_CveKilometraje.MaxLength = 4
        Me.tbx_CveKilometraje.Name = "tbx_CveKilometraje"
        Me.tbx_CveKilometraje.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveKilometraje.TabIndex = 21
        Me.tbx_CveKilometraje.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_LineaServicio
        '
        Me.cmb_LineaServicio.Clave = "Clave"
        Me.cmb_LineaServicio.Control_Siguiente = Nothing
        Me.cmb_LineaServicio.DisplayMember = "Descripcion"
        Me.cmb_LineaServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LineaServicio.Empresa = False
        Me.cmb_LineaServicio.Filtro = Me.tbx_CveLinea
        Me.cmb_LineaServicio.FormattingEnabled = True
        Me.cmb_LineaServicio.Location = New System.Drawing.Point(157, 45)
        Me.cmb_LineaServicio.MaxDropDownItems = 20
        Me.cmb_LineaServicio.Name = "cmb_LineaServicio"
        Me.cmb_LineaServicio.Pista = False
        Me.cmb_LineaServicio.Size = New System.Drawing.Size(294, 21)
        Me.cmb_LineaServicio.StoredProcedure = "Cat_Lineas_Get"
        Me.cmb_LineaServicio.Sucursal = False
        Me.cmb_LineaServicio.TabIndex = 4
        Me.cmb_LineaServicio.Tipo = 0
        Me.cmb_LineaServicio.ValueMember = "Id_Linea"
        '
        'tbx_CveLinea
        '
        Me.tbx_CveLinea.Control_Siguiente = Nothing
        Me.tbx_CveLinea.Filtrado = True
        Me.tbx_CveLinea.Location = New System.Drawing.Point(101, 46)
        Me.tbx_CveLinea.MaxLength = 4
        Me.tbx_CveLinea.Name = "tbx_CveLinea"
        Me.tbx_CveLinea.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveLinea.TabIndex = 3
        Me.tbx_CveLinea.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_DescripcionKM
        '
        Me.tbx_DescripcionKM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_DescripcionKM.Control_Siguiente = Nothing
        Me.tbx_DescripcionKM.Filtrado = True
        Me.tbx_DescripcionKM.Location = New System.Drawing.Point(619, 126)
        Me.tbx_DescripcionKM.MaxLength = 50
        Me.tbx_DescripcionKM.Multiline = True
        Me.tbx_DescripcionKM.Name = "tbx_DescripcionKM"
        Me.tbx_DescripcionKM.Size = New System.Drawing.Size(265, 20)
        Me.tbx_DescripcionKM.TabIndex = 28
        Me.tbx_DescripcionKM.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_DescripcionPrecio
        '
        Me.tbx_DescripcionPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_DescripcionPrecio.Control_Siguiente = Nothing
        Me.tbx_DescripcionPrecio.Filtrado = True
        Me.tbx_DescripcionPrecio.Location = New System.Drawing.Point(619, 73)
        Me.tbx_DescripcionPrecio.MaxLength = 50
        Me.tbx_DescripcionPrecio.Multiline = True
        Me.tbx_DescripcionPrecio.Name = "tbx_DescripcionPrecio"
        Me.tbx_DescripcionPrecio.Size = New System.Drawing.Size(265, 20)
        Me.tbx_DescripcionPrecio.TabIndex = 28
        Me.tbx_DescripcionPrecio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_DescripcionCR
        '
        Me.tbx_DescripcionCR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_DescripcionCR.Control_Siguiente = Nothing
        Me.tbx_DescripcionCR.Filtrado = True
        Me.tbx_DescripcionCR.Location = New System.Drawing.Point(619, 100)
        Me.tbx_DescripcionCR.MaxLength = 50
        Me.tbx_DescripcionCR.Multiline = True
        Me.tbx_DescripcionCR.Name = "tbx_DescripcionCR"
        Me.tbx_DescripcionCR.Size = New System.Drawing.Size(265, 20)
        Me.tbx_DescripcionCR.TabIndex = 28
        Me.tbx_DescripcionCR.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CantidadKilometraje
        '
        Me.tbx_CantidadKilometraje.Control_Siguiente = Nothing
        Me.tbx_CantidadKilometraje.Filtrado = True
        Me.tbx_CantidadKilometraje.Location = New System.Drawing.Point(563, 126)
        Me.tbx_CantidadKilometraje.MaxLength = 6
        Me.tbx_CantidadKilometraje.Name = "tbx_CantidadKilometraje"
        Me.tbx_CantidadKilometraje.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CantidadKilometraje.TabIndex = 24
        Me.tbx_CantidadKilometraje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CantidadKilometraje.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_CantidadCuotaRiesgo
        '
        Me.tbx_CantidadCuotaRiesgo.Control_Siguiente = Nothing
        Me.tbx_CantidadCuotaRiesgo.Filtrado = True
        Me.tbx_CantidadCuotaRiesgo.Location = New System.Drawing.Point(563, 100)
        Me.tbx_CantidadCuotaRiesgo.MaxLength = 6
        Me.tbx_CantidadCuotaRiesgo.Name = "tbx_CantidadCuotaRiesgo"
        Me.tbx_CantidadCuotaRiesgo.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CantidadCuotaRiesgo.TabIndex = 14
        Me.tbx_CantidadCuotaRiesgo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CantidadCuotaRiesgo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_MontoAprox
        '
        Me.tbx_MontoAprox.Control_Siguiente = Nothing
        Me.tbx_MontoAprox.Filtrado = True
        Me.tbx_MontoAprox.Location = New System.Drawing.Point(101, 152)
        Me.tbx_MontoAprox.MaxLength = 4
        Me.tbx_MontoAprox.Name = "tbx_MontoAprox"
        Me.tbx_MontoAprox.Size = New System.Drawing.Size(95, 20)
        Me.tbx_MontoAprox.TabIndex = 9
        Me.tbx_MontoAprox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_MontoAprox.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_CantidadPrecio
        '
        Me.tbx_CantidadPrecio.Control_Siguiente = Nothing
        Me.tbx_CantidadPrecio.Filtrado = True
        Me.tbx_CantidadPrecio.Location = New System.Drawing.Point(563, 73)
        Me.tbx_CantidadPrecio.MaxLength = 6
        Me.tbx_CantidadPrecio.Name = "tbx_CantidadPrecio"
        Me.tbx_CantidadPrecio.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CantidadPrecio.TabIndex = 9
        Me.tbx_CantidadPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CantidadPrecio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(101, 19)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaInicio.TabIndex = 1
        '
        'lbl_LineaServicio
        '
        Me.lbl_LineaServicio.AutoSize = True
        Me.lbl_LineaServicio.Location = New System.Drawing.Point(4, 49)
        Me.lbl_LineaServicio.Name = "lbl_LineaServicio"
        Me.lbl_LineaServicio.Size = New System.Drawing.Size(91, 13)
        Me.lbl_LineaServicio.TabIndex = 2
        Me.lbl_LineaServicio.Text = "Línea de Servicio"
        '
        'Lbl_Observaciones
        '
        Me.Lbl_Observaciones.AutoSize = True
        Me.Lbl_Observaciones.Location = New System.Drawing.Point(616, 57)
        Me.Lbl_Observaciones.Name = "Lbl_Observaciones"
        Me.Lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_Observaciones.TabIndex = 5
        Me.Lbl_Observaciones.Text = "Observaciones"
        '
        'Lbl_Cantidad
        '
        Me.Lbl_Cantidad.AutoSize = True
        Me.Lbl_Cantidad.Location = New System.Drawing.Point(560, 56)
        Me.Lbl_Cantidad.Name = "Lbl_Cantidad"
        Me.Lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Cantidad.TabIndex = 5
        Me.Lbl_Cantidad.Text = "Cantidad"
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.AutoSize = True
        Me.Lbl_Precio.Location = New System.Drawing.Point(58, 76)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Precio.TabIndex = 5
        Me.Lbl_Precio.Text = "Precio"
        '
        'Lbl_CoutaRiesgo
        '
        Me.Lbl_CoutaRiesgo.AutoSize = True
        Me.Lbl_CoutaRiesgo.Location = New System.Drawing.Point(9, 103)
        Me.Lbl_CoutaRiesgo.Name = "Lbl_CoutaRiesgo"
        Me.Lbl_CoutaRiesgo.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_CoutaRiesgo.TabIndex = 10
        Me.Lbl_CoutaRiesgo.Text = "Cuota de Riesgo"
        '
        'lbl_Kilometraje
        '
        Me.lbl_Kilometraje.AutoSize = True
        Me.lbl_Kilometraje.Location = New System.Drawing.Point(37, 129)
        Me.lbl_Kilometraje.Name = "lbl_Kilometraje"
        Me.lbl_Kilometraje.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Kilometraje.TabIndex = 20
        Me.lbl_Kilometraje.Text = "Kilometraje"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(30, 23)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaInicio.TabIndex = 0
        Me.lbl_FechaInicio.Text = "Fecha Inicio"
        '
        'ServiciosCotizar
        '
        Me.ServiciosCotizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiciosCotizar.Controls.Add(Me.Lbl_Registros2)
        Me.ServiciosCotizar.Controls.Add(Me.lsv_ServiciosCotizar)
        Me.ServiciosCotizar.Location = New System.Drawing.Point(12, 402)
        Me.ServiciosCotizar.Name = "ServiciosCotizar"
        Me.ServiciosCotizar.Size = New System.Drawing.Size(890, 216)
        Me.ServiciosCotizar.TabIndex = 3
        Me.ServiciosCotizar.TabStop = False
        Me.ServiciosCotizar.Text = "Servicios a Cotizar"
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Registros2.Location = New System.Drawing.Point(744, 16)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros2.TabIndex = 33
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ServiciosCotizar
        '
        Me.lsv_ServiciosCotizar.AllowColumnReorder = True
        Me.lsv_ServiciosCotizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ServiciosCotizar.FullRowSelect = True
        Me.lsv_ServiciosCotizar.HideSelection = False
        Me.lsv_ServiciosCotizar.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ServiciosCotizar.Lvs = ListViewColumnSorter1
        Me.lsv_ServiciosCotizar.MultiSelect = False
        Me.lsv_ServiciosCotizar.Name = "lsv_ServiciosCotizar"
        Me.lsv_ServiciosCotizar.Row1 = 5
        Me.lsv_ServiciosCotizar.Row10 = 0
        Me.lsv_ServiciosCotizar.Row2 = 35
        Me.lsv_ServiciosCotizar.Row3 = 35
        Me.lsv_ServiciosCotizar.Row4 = 7
        Me.lsv_ServiciosCotizar.Row5 = 7
        Me.lsv_ServiciosCotizar.Row6 = 7
        Me.lsv_ServiciosCotizar.Row7 = 0
        Me.lsv_ServiciosCotizar.Row8 = 0
        Me.lsv_ServiciosCotizar.Row9 = 0
        Me.lsv_ServiciosCotizar.Size = New System.Drawing.Size(884, 179)
        Me.lsv_ServiciosCotizar.TabIndex = 0
        Me.lsv_ServiciosCotizar.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosCotizar.View = System.Windows.Forms.View.Details
        '
        'gbx_ServiciosSolicitudes
        '
        Me.gbx_ServiciosSolicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ServiciosSolicitudes.Controls.Add(Me.lbl_Registros)
        Me.gbx_ServiciosSolicitudes.Controls.Add(Me.lsv_ServiciosSolicitados)
        Me.gbx_ServiciosSolicitudes.Location = New System.Drawing.Point(12, 83)
        Me.gbx_ServiciosSolicitudes.Name = "gbx_ServiciosSolicitudes"
        Me.gbx_ServiciosSolicitudes.Size = New System.Drawing.Size(890, 124)
        Me.gbx_ServiciosSolicitudes.TabIndex = 1
        Me.gbx_ServiciosSolicitudes.TabStop = False
        Me.gbx_ServiciosSolicitudes.Text = "Servicios Solicitados"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(744, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 20)
        Me.lbl_Registros.TabIndex = 32
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ServiciosSolicitados
        '
        Me.lsv_ServiciosSolicitados.AllowColumnReorder = True
        Me.lsv_ServiciosSolicitados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsv_ServiciosSolicitados.FullRowSelect = True
        Me.lsv_ServiciosSolicitados.HideSelection = False
        Me.lsv_ServiciosSolicitados.Location = New System.Drawing.Point(3, 39)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ServiciosSolicitados.Lvs = ListViewColumnSorter2
        Me.lsv_ServiciosSolicitados.MultiSelect = False
        Me.lsv_ServiciosSolicitados.Name = "lsv_ServiciosSolicitados"
        Me.lsv_ServiciosSolicitados.Row1 = 6
        Me.lsv_ServiciosSolicitados.Row10 = 0
        Me.lsv_ServiciosSolicitados.Row2 = 20
        Me.lsv_ServiciosSolicitados.Row3 = 10
        Me.lsv_ServiciosSolicitados.Row4 = 10
        Me.lsv_ServiciosSolicitados.Row5 = 8
        Me.lsv_ServiciosSolicitados.Row6 = 8
        Me.lsv_ServiciosSolicitados.Row7 = 8
        Me.lsv_ServiciosSolicitados.Row8 = 8
        Me.lsv_ServiciosSolicitados.Row9 = 0
        Me.lsv_ServiciosSolicitados.Size = New System.Drawing.Size(884, 82)
        Me.lsv_ServiciosSolicitados.TabIndex = 0
        Me.lsv_ServiciosSolicitados.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosSolicitados.View = System.Windows.Forms.View.Details
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(790, 621)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Total.TabIndex = 20
        Me.lbl_Total.Text = "Total"
        '
        'lbl_CantidadTotal
        '
        Me.lbl_CantidadTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CantidadTotal.AutoSize = True
        Me.lbl_CantidadTotal.Location = New System.Drawing.Point(874, 621)
        Me.lbl_CantidadTotal.Name = "lbl_CantidadTotal"
        Me.lbl_CantidadTotal.Size = New System.Drawing.Size(28, 13)
        Me.lbl_CantidadTotal.TabIndex = 20
        Me.lbl_CantidadTotal.Text = "0.00"
        Me.lbl_CantidadTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_Cotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 699)
        Me.Controls.Add(Me.gbx_ServiciosSolicitudes)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.ServiciosCotizar)
        Me.Controls.Add(Me.lbl_CantidadTotal)
        Me.Controls.Add(Me.gbx_Precio)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_DatosComerciales)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(930, 600)
        Me.Name = "frm_Cotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotización"
        Me.gbx_DatosComerciales.ResumeLayout(False)
        Me.gbx_DatosComerciales.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Precio.ResumeLayout(False)
        Me.gbx_Precio.PerformLayout()
        Me.ServiciosCotizar.ResumeLayout(False)
        Me.gbx_ServiciosSolicitudes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_DatosComerciales As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_NumLlamada As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreEmpresa As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Precio As System.Windows.Forms.GroupBox
    Friend WithEvents ServiciosCotizar As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_NumLlamada As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_LineaServicio As System.Windows.Forms.Label
    Friend WithEvents Lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents Lbl_CoutaRiesgo As System.Windows.Forms.Label
    Friend WithEvents lbl_Kilometraje As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents tbx_CvePrecio As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CveCuotaRiesgo As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CveLinea As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CveKilometraje As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_PrecioDescripcion As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CuotaRiesgo As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Kilometraje As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_LineaServicio As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Precio As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lsv_ServiciosCotizar As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents gbx_ServiciosSolicitudes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ServiciosSolicitados As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_CantidadKilometraje As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CantidadCuotaRiesgo As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CantidadPrecio As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_DescripcionKM As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_DescripcionPrecio As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_DescripcionCR As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_CantidadTotal As System.Windows.Forms.Label
    Friend WithEvents Lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents Lbl_MontoAprox As System.Windows.Forms.Label
    Friend WithEvents tbx_MontoAprox As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
