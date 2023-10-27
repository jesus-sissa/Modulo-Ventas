<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CargarArchivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CargarArchivos))
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.gbx_Principales = New System.Windows.Forms.GroupBox
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.lbl_Adicional = New System.Windows.Forms.Label
        Me.tbx_Adicional = New Modulo_Ventas.cp_Textbox
        Me.lbl_FileSize = New System.Windows.Forms.Label
        Me.tbx_FileSize = New Modulo_Ventas.cp_Textbox
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.tbx_Descripcion = New Modulo_Ventas.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_MimeType = New System.Windows.Forms.Label
        Me.lbl_Ruta = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.lbl_Extension = New System.Windows.Forms.Label
        Me.tbx_MimeType = New Modulo_Ventas.cp_Textbox
        Me.tbx_Ruta = New Modulo_Ventas.cp_Textbox
        Me.tbx_Extension = New Modulo_Ventas.cp_Textbox
        Me.tbx_Nombre = New Modulo_Ventas.cp_Textbox
        Me.cmb_SFP = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_ComboSFP = New System.Windows.Forms.Label
        Me.gbx_Archivos = New System.Windows.Forms.GroupBox
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_LimpiarTodo = New System.Windows.Forms.Button
        Me.btn_Limpiar = New System.Windows.Forms.Button
        Me.lsv_Archivos = New Modulo_Ventas.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ExportarTodos = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_VistaPrevia = New System.Windows.Forms.GroupBox
        Me.pct_Imagen = New System.Windows.Forms.PictureBox
        Me.gbx_Principales.SuspendLayout()
        Me.gbx_Archivos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_VistaPrevia.SuspendLayout()
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Principales
        '
        Me.gbx_Principales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Principales.Controls.Add(Me.btn_Agregar)
        Me.gbx_Principales.Controls.Add(Me.lbl_Adicional)
        Me.gbx_Principales.Controls.Add(Me.tbx_Adicional)
        Me.gbx_Principales.Controls.Add(Me.lbl_FileSize)
        Me.gbx_Principales.Controls.Add(Me.tbx_FileSize)
        Me.gbx_Principales.Controls.Add(Me.lbl_Descripcion)
        Me.gbx_Principales.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Principales.Controls.Add(Me.btn_Buscar)
        Me.gbx_Principales.Controls.Add(Me.lbl_MimeType)
        Me.gbx_Principales.Controls.Add(Me.lbl_Ruta)
        Me.gbx_Principales.Controls.Add(Me.lbl_Nombre)
        Me.gbx_Principales.Controls.Add(Me.lbl_Extension)
        Me.gbx_Principales.Controls.Add(Me.tbx_MimeType)
        Me.gbx_Principales.Controls.Add(Me.tbx_Ruta)
        Me.gbx_Principales.Controls.Add(Me.tbx_Nombre)
        Me.gbx_Principales.Controls.Add(Me.tbx_Extension)
        Me.gbx_Principales.Controls.Add(Me.cmb_SFP)
        Me.gbx_Principales.Controls.Add(Me.lbl_ComboSFP)
        Me.gbx_Principales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Principales.Location = New System.Drawing.Point(12, 2)
        Me.gbx_Principales.Name = "gbx_Principales"
        Me.gbx_Principales.Size = New System.Drawing.Size(343, 281)
        Me.gbx_Principales.TabIndex = 0
        Me.gbx_Principales.TabStop = False
        Me.gbx_Principales.Text = "Datos Principales"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.edit_add
        Me.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Agregar.Location = New System.Drawing.Point(244, 248)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(93, 25)
        Me.btn_Agregar.TabIndex = 17
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_Adicional
        '
        Me.lbl_Adicional.AutoSize = True
        Me.lbl_Adicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adicional.Location = New System.Drawing.Point(17, 129)
        Me.lbl_Adicional.Name = "lbl_Adicional"
        Me.lbl_Adicional.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Adicional.TabIndex = 10
        Me.lbl_Adicional.Text = "Adicional"
        '
        'tbx_Adicional
        '
        Me.tbx_Adicional.Control_Siguiente = Nothing
        Me.tbx_Adicional.Filtrado = True
        Me.tbx_Adicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Adicional.Location = New System.Drawing.Point(73, 126)
        Me.tbx_Adicional.MaxLength = 150
        Me.tbx_Adicional.Name = "tbx_Adicional"
        Me.tbx_Adicional.ReadOnly = True
        Me.tbx_Adicional.Size = New System.Drawing.Size(227, 20)
        Me.tbx_Adicional.TabIndex = 11
        Me.tbx_Adicional.TabStop = False
        Me.tbx_Adicional.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_FileSize
        '
        Me.lbl_FileSize.AutoSize = True
        Me.lbl_FileSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FileSize.Location = New System.Drawing.Point(24, 157)
        Me.lbl_FileSize.Name = "lbl_FileSize"
        Me.lbl_FileSize.Size = New System.Drawing.Size(43, 13)
        Me.lbl_FileSize.TabIndex = 13
        Me.lbl_FileSize.Text = "FileSize"
        '
        'tbx_FileSize
        '
        Me.tbx_FileSize.Control_Siguiente = Nothing
        Me.tbx_FileSize.Filtrado = True
        Me.tbx_FileSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_FileSize.Location = New System.Drawing.Point(73, 154)
        Me.tbx_FileSize.MaxLength = 150
        Me.tbx_FileSize.Name = "tbx_FileSize"
        Me.tbx_FileSize.ReadOnly = True
        Me.tbx_FileSize.Size = New System.Drawing.Size(110, 20)
        Me.tbx_FileSize.TabIndex = 14
        Me.tbx_FileSize.TabStop = False
        Me.tbx_FileSize.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descripcion.Location = New System.Drawing.Point(4, 185)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 15
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Descripcion.Location = New System.Drawing.Point(73, 182)
        Me.tbx_Descripcion.MaxLength = 200
        Me.tbx_Descripcion.Multiline = True
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(264, 60)
        Me.tbx_Descripcion.TabIndex = 16
        Me.tbx_Descripcion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Location = New System.Drawing.Point(306, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(31, 25)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "..."
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_MimeType
        '
        Me.lbl_MimeType.AutoSize = True
        Me.lbl_MimeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MimeType.Location = New System.Drawing.Point(8, 101)
        Me.lbl_MimeType.Name = "lbl_MimeType"
        Me.lbl_MimeType.Size = New System.Drawing.Size(59, 13)
        Me.lbl_MimeType.TabIndex = 7
        Me.lbl_MimeType.Text = "Mime Type"
        '
        'lbl_Ruta
        '
        Me.lbl_Ruta.AutoSize = True
        Me.lbl_Ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ruta.Location = New System.Drawing.Point(37, 49)
        Me.lbl_Ruta.Name = "lbl_Ruta"
        Me.lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Ruta.TabIndex = 3
        Me.lbl_Ruta.Text = "Ruta"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(23, 25)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_Extension
        '
        Me.lbl_Extension.AutoSize = True
        Me.lbl_Extension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Extension.Location = New System.Drawing.Point(14, 75)
        Me.lbl_Extension.Name = "lbl_Extension"
        Me.lbl_Extension.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Extension.TabIndex = 5
        Me.lbl_Extension.Text = "Extensión"
        '
        'tbx_MimeType
        '
        Me.tbx_MimeType.Control_Siguiente = Nothing
        Me.tbx_MimeType.Filtrado = True
        Me.tbx_MimeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_MimeType.Location = New System.Drawing.Point(73, 98)
        Me.tbx_MimeType.MaxLength = 150
        Me.tbx_MimeType.Name = "tbx_MimeType"
        Me.tbx_MimeType.ReadOnly = True
        Me.tbx_MimeType.Size = New System.Drawing.Size(264, 20)
        Me.tbx_MimeType.TabIndex = 8
        Me.tbx_MimeType.TabStop = False
        Me.tbx_MimeType.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Ruta
        '
        Me.tbx_Ruta.Control_Siguiente = Me.tbx_Extension
        Me.tbx_Ruta.Filtrado = True
        Me.tbx_Ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Ruta.Location = New System.Drawing.Point(73, 46)
        Me.tbx_Ruta.MaxLength = 200
        Me.tbx_Ruta.Name = "tbx_Ruta"
        Me.tbx_Ruta.ReadOnly = True
        Me.tbx_Ruta.Size = New System.Drawing.Size(264, 20)
        Me.tbx_Ruta.TabIndex = 4
        Me.tbx_Ruta.TabStop = False
        Me.tbx_Ruta.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Extension
        '
        Me.tbx_Extension.Control_Siguiente = Me.tbx_MimeType
        Me.tbx_Extension.Filtrado = True
        Me.tbx_Extension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Extension.Location = New System.Drawing.Point(73, 72)
        Me.tbx_Extension.MaxLength = 50
        Me.tbx_Extension.Name = "tbx_Extension"
        Me.tbx_Extension.ReadOnly = True
        Me.tbx_Extension.Size = New System.Drawing.Size(264, 20)
        Me.tbx_Extension.TabIndex = 6
        Me.tbx_Extension.TabStop = False
        Me.tbx_Extension.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.Control_Siguiente = Me.tbx_Ruta
        Me.tbx_Nombre.Filtrado = True
        Me.tbx_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Nombre.Location = New System.Drawing.Point(73, 20)
        Me.tbx_Nombre.MaxLength = 150
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.ReadOnly = True
        Me.tbx_Nombre.Size = New System.Drawing.Size(227, 20)
        Me.tbx_Nombre.TabIndex = 1
        Me.tbx_Nombre.TabStop = False
        Me.tbx_Nombre.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_SFP
        '
        Me.cmb_SFP.Clave = Nothing
        Me.cmb_SFP.Control_Siguiente = Nothing
        Me.cmb_SFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SFP.Empresa = False
        Me.cmb_SFP.Filtro = Nothing
        Me.cmb_SFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_SFP.FormattingEnabled = True
        Me.cmb_SFP.Location = New System.Drawing.Point(73, 126)
        Me.cmb_SFP.MaxDropDownItems = 20
        Me.cmb_SFP.Name = "cmb_SFP"
        Me.cmb_SFP.Pista = True
        Me.cmb_SFP.Size = New System.Drawing.Size(264, 21)
        Me.cmb_SFP.StoredProcedure = Nothing
        Me.cmb_SFP.Sucursal = False
        Me.cmb_SFP.TabIndex = 12
        Me.cmb_SFP.Tipo = 0
        Me.cmb_SFP.Visible = False
        '
        'lbl_ComboSFP
        '
        Me.lbl_ComboSFP.AutoSize = True
        Me.lbl_ComboSFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ComboSFP.Location = New System.Drawing.Point(5, 129)
        Me.lbl_ComboSFP.Name = "lbl_ComboSFP"
        Me.lbl_ComboSFP.Size = New System.Drawing.Size(62, 13)
        Me.lbl_ComboSFP.TabIndex = 9
        Me.lbl_ComboSFP.Text = "Documento"
        Me.lbl_ComboSFP.Visible = False
        '
        'gbx_Archivos
        '
        Me.gbx_Archivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Archivos.Controls.Add(Me.btn_Modificar)
        Me.gbx_Archivos.Controls.Add(Me.btn_LimpiarTodo)
        Me.gbx_Archivos.Controls.Add(Me.btn_Limpiar)
        Me.gbx_Archivos.Controls.Add(Me.lsv_Archivos)
        Me.gbx_Archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Archivos.Location = New System.Drawing.Point(361, 2)
        Me.gbx_Archivos.Name = "gbx_Archivos"
        Me.gbx_Archivos.Size = New System.Drawing.Size(375, 281)
        Me.gbx_Archivos.TabIndex = 1
        Me.gbx_Archivos.TabStop = False
        Me.gbx_Archivos.Text = "Archivos"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(9, 249)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(93, 25)
        Me.btn_Modificar.TabIndex = 1
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_LimpiarTodo
        '
        Me.btn_LimpiarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LimpiarTodo.Enabled = False
        Me.btn_LimpiarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LimpiarTodo.Image = CType(resources.GetObject("btn_LimpiarTodo.Image"), System.Drawing.Image)
        Me.btn_LimpiarTodo.Location = New System.Drawing.Point(276, 249)
        Me.btn_LimpiarTodo.Name = "btn_LimpiarTodo"
        Me.btn_LimpiarTodo.Size = New System.Drawing.Size(93, 25)
        Me.btn_LimpiarTodo.TabIndex = 3
        Me.btn_LimpiarTodo.Text = "Limpiar &Todo"
        Me.btn_LimpiarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LimpiarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LimpiarTodo.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Limpiar.Enabled = False
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(177, 249)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(93, 25)
        Me.btn_Limpiar.TabIndex = 2
        Me.btn_Limpiar.Text = "&Limpiar Uno"
        Me.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lsv_Archivos
        '
        Me.lsv_Archivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Archivos.FullRowSelect = True
        Me.lsv_Archivos.HideSelection = False
        Me.lsv_Archivos.Location = New System.Drawing.Point(9, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Archivos.Lvs = ListViewColumnSorter2
        Me.lsv_Archivos.MultiSelect = False
        Me.lsv_Archivos.Name = "lsv_Archivos"
        Me.lsv_Archivos.Row1 = 0
        Me.lsv_Archivos.Row10 = 0
        Me.lsv_Archivos.Row2 = 0
        Me.lsv_Archivos.Row3 = 0
        Me.lsv_Archivos.Row4 = 0
        Me.lsv_Archivos.Row5 = 0
        Me.lsv_Archivos.Row6 = 0
        Me.lsv_Archivos.Row7 = 0
        Me.lsv_Archivos.Row8 = 0
        Me.lsv_Archivos.Row9 = 0
        Me.lsv_Archivos.Size = New System.Drawing.Size(360, 224)
        Me.lsv_Archivos.TabIndex = 0
        Me.lsv_Archivos.UseCompatibleStateImageBehavior = False
        Me.lsv_Archivos.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarTodos)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 289)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(910, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_ExportarTodos
        '
        Me.btn_ExportarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarTodos.Enabled = False
        Me.btn_ExportarTodos.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_ExportarTodos.Location = New System.Drawing.Point(298, 13)
        Me.btn_ExportarTodos.Name = "btn_ExportarTodos"
        Me.btn_ExportarTodos.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarTodos.TabIndex = 3
        Me.btn_ExportarTodos.Text = "&Exportar Todos"
        Me.btn_ExportarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarTodos.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(152, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 1
        Me.btn_Exportar.Text = "&Exportar Archivo"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
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
        Me.btn_Guardar.Visible = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(764, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_VistaPrevia
        '
        Me.gbx_VistaPrevia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_VistaPrevia.Controls.Add(Me.pct_Imagen)
        Me.gbx_VistaPrevia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_VistaPrevia.Location = New System.Drawing.Point(742, 38)
        Me.gbx_VistaPrevia.Name = "gbx_VistaPrevia"
        Me.gbx_VistaPrevia.Size = New System.Drawing.Size(175, 207)
        Me.gbx_VistaPrevia.TabIndex = 2
        Me.gbx_VistaPrevia.TabStop = False
        Me.gbx_VistaPrevia.Text = "Vista Previa"
        '
        'pct_Imagen
        '
        Me.pct_Imagen.BackColor = System.Drawing.SystemColors.Window
        Me.pct_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Imagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_Imagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pct_Imagen.Location = New System.Drawing.Point(3, 16)
        Me.pct_Imagen.Name = "pct_Imagen"
        Me.pct_Imagen.Size = New System.Drawing.Size(169, 188)
        Me.pct_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Imagen.TabIndex = 1
        Me.pct_Imagen.TabStop = False
        '
        'frm_CargarArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 351)
        Me.Controls.Add(Me.gbx_VistaPrevia)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Archivos)
        Me.Controls.Add(Me.gbx_Principales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(940, 380)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(940, 380)
        Me.Name = "frm_CargarArchivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Archivos"
        Me.gbx_Principales.ResumeLayout(False)
        Me.gbx_Principales.PerformLayout()
        Me.gbx_Archivos.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_VistaPrevia.ResumeLayout(False)
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbx_Ruta As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Nombre As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_MimeType As System.Windows.Forms.Label
    Friend WithEvents lbl_Extension As System.Windows.Forms.Label
    Friend WithEvents tbx_MimeType As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Extension As Modulo_Ventas.cp_Textbox
    Friend WithEvents gbx_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents gbx_Archivos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Archivos As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_Adicional As System.Windows.Forms.Label
    Friend WithEvents tbx_Adicional As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_FileSize As System.Windows.Forms.Label
    Friend WithEvents tbx_FileSize As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_LimpiarTodo As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents cmb_SFP As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_ComboSFP As System.Windows.Forms.Label
    Friend WithEvents gbx_VistaPrevia As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ExportarTodos As System.Windows.Forms.Button
End Class
