<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CajasFuertesT
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
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CajasFuertesT))
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.tab_Listado = New System.Windows.Forms.TabPage()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.cbx_Activos = New System.Windows.Forms.CheckBox()
        Me.BTN_Buscar = New System.Windows.Forms.Button()
        Me.BTN_Modificar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.BTN_Exportar = New System.Windows.Forms.Button()
        Me.Btn_Baja = New System.Windows.Forms.Button()
        Me.Lbl_Buscar = New System.Windows.Forms.Label()
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage()
        Me.grp_DatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_Modelo = New System.Windows.Forms.Label()
        Me.lbl_kg = New System.Windows.Forms.Label()
        Me.lbl_A3 = New System.Windows.Forms.Label()
        Me.lbl_Peso = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_A2 = New System.Windows.Forms.Label()
        Me.lbl_A1 = New System.Windows.Forms.Label()
        Me.Lbl_StockMin = New System.Windows.Forms.Label()
        Me.Lbl_Existencia = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.Grp_Dimension = New System.Windows.Forms.GroupBox()
        Me.lbl_A9 = New System.Windows.Forms.Label()
        Me.lbl_A7 = New System.Windows.Forms.Label()
        Me.Lbl_FondoExt = New System.Windows.Forms.Label()
        Me.lbl_A8 = New System.Windows.Forms.Label()
        Me.Lbl_AltoExt = New System.Windows.Forms.Label()
        Me.lbl_A6 = New System.Windows.Forms.Label()
        Me.lbl_A4 = New System.Windows.Forms.Label()
        Me.Lbl_AnchoInt = New System.Windows.Forms.Label()
        Me.lbl_cm6 = New System.Windows.Forms.Label()
        Me.Lbl_AnchoExt = New System.Windows.Forms.Label()
        Me.lbl_cm5 = New System.Windows.Forms.Label()
        Me.lbl_cm1 = New System.Windows.Forms.Label()
        Me.lbl_cm3 = New System.Windows.Forms.Label()
        Me.lbl_A5 = New System.Windows.Forms.Label()
        Me.lbl_cm4 = New System.Windows.Forms.Label()
        Me.lbl_cm2 = New System.Windows.Forms.Label()
        Me.Lbl_AltoInt = New System.Windows.Forms.Label()
        Me.Lbl_FondoInt = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox()
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview()
        Me.cmb_Tipo = New Modulo_Ventas.cp_cmb_Manual()
        Me.tbx_Modelo = New Modulo_Ventas.cp_Textbox()
        Me.tbx_AltoE = New Modulo_Ventas.cp_Textbox()
        Me.tbx_AnchoE = New Modulo_Ventas.cp_Textbox()
        Me.tbx_FondoE = New Modulo_Ventas.cp_Textbox()
        Me.tbx_AltoI = New Modulo_Ventas.cp_Textbox()
        Me.tbx_AnchoI = New Modulo_Ventas.cp_Textbox()
        Me.tbx_FondoI = New Modulo_Ventas.cp_Textbox()
        Me.tbx_Peso = New Modulo_Ventas.cp_Textbox()
        Me.tbx_Clave = New Modulo_Ventas.cp_Textbox()
        Me.tbx_StockMinimo = New Modulo_Ventas.cp_Textbox()
        Me.tbx_Existencia = New Modulo_Ventas.cp_Textbox()
        Me.gb_Carateristicas = New System.Windows.Forms.GroupBox()
        Me.lbl_TipoDial = New System.Windows.Forms.Label()
        Me.lbl_TipoChapa = New System.Windows.Forms.Label()
        Me.lbl_TipoReceptor = New System.Windows.Forms.Label()
        Me.Cp_cmb_TipoDial = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.Cp_cmb_TipoChapa = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.Cp_cmb_TipoReceptor = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.grp_DatosGenerales.SuspendLayout()
        Me.Grp_Dimension.SuspendLayout()
        Me.gb_Carateristicas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(1084, 662)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.cbx_Activos)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 25)
        Me.tab_Listado.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(4)
        Me.tab_Listado.Size = New System.Drawing.Size(1076, 633)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(744, 41)
        Me.lbl_Registros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(187, 16)
        Me.lbl_Registros.TabIndex = 29
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbx_Activos
        '
        Me.cbx_Activos.AutoSize = True
        Me.cbx_Activos.Checked = True
        Me.cbx_Activos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Activos.Location = New System.Drawing.Point(69, 39)
        Me.cbx_Activos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbx_Activos.Name = "cbx_Activos"
        Me.cbx_Activos.Size = New System.Drawing.Size(107, 21)
        Me.cbx_Activos.TabIndex = 3
        Me.cbx_Activos.Text = "Sólo Activos"
        Me.cbx_Activos.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(841, 5)
        Me.BTN_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(199, 583)
        Me.BTN_Modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(187, 37)
        Me.BTN_Modificar.TabIndex = 6
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(751, 583)
        Me.btn_Cerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(187, 37)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(393, 583)
        Me.BTN_Exportar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(187, 37)
        Me.BTN_Exportar.TabIndex = 7
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(4, 583)
        Me.Btn_Baja.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(187, 37)
        Me.Btn_Baja.TabIndex = 5
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(4, 11)
        Me.Lbl_Buscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.gb_Carateristicas)
        Me.Tab_Nuevo.Controls.Add(Me.grp_DatosGenerales)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.Grp_Dimension)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(1076, 633)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'grp_DatosGenerales
        '
        Me.grp_DatosGenerales.Controls.Add(Me.Label1)
        Me.grp_DatosGenerales.Controls.Add(Me.cmb_Tipo)
        Me.grp_DatosGenerales.Controls.Add(Me.Label9)
        Me.grp_DatosGenerales.Controls.Add(Me.tbx_Modelo)
        Me.grp_DatosGenerales.Controls.Add(Me.Lbl_Modelo)
        Me.grp_DatosGenerales.Controls.Add(Me.lbl_kg)
        Me.grp_DatosGenerales.Controls.Add(Me.lbl_A3)
        Me.grp_DatosGenerales.Controls.Add(Me.tbx_Peso)
        Me.grp_DatosGenerales.Controls.Add(Me.lbl_Peso)
        Me.grp_DatosGenerales.Controls.Add(Me.lbl_Nombre)
        Me.grp_DatosGenerales.Controls.Add(Me.lbl_A2)
        Me.grp_DatosGenerales.Controls.Add(Me.tbx_Clave)
        Me.grp_DatosGenerales.Controls.Add(Me.lbl_A1)
        Me.grp_DatosGenerales.Controls.Add(Me.tbx_StockMinimo)
        Me.grp_DatosGenerales.Controls.Add(Me.Lbl_StockMin)
        Me.grp_DatosGenerales.Controls.Add(Me.tbx_Existencia)
        Me.grp_DatosGenerales.Controls.Add(Me.Lbl_Existencia)
        Me.grp_DatosGenerales.Location = New System.Drawing.Point(35, 28)
        Me.grp_DatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_DatosGenerales.Name = "grp_DatosGenerales"
        Me.grp_DatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_DatosGenerales.Size = New System.Drawing.Size(528, 222)
        Me.grp_DatosGenerales.TabIndex = 0
        Me.grp_DatosGenerales.TabStop = False
        Me.grp_DatosGenerales.Text = "Datos Generales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tipo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(295, 89)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "*"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(35, 390)
        Me.btn_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(187, 37)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Lbl_Modelo
        '
        Me.Lbl_Modelo.AutoSize = True
        Me.Lbl_Modelo.Location = New System.Drawing.Point(68, 92)
        Me.Lbl_Modelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Modelo.Name = "Lbl_Modelo"
        Me.Lbl_Modelo.Size = New System.Drawing.Size(54, 17)
        Me.Lbl_Modelo.TabIndex = 10
        Me.Lbl_Modelo.Text = "Modelo"
        Me.Lbl_Modelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kg
        '
        Me.lbl_kg.AutoSize = True
        Me.lbl_kg.Location = New System.Drawing.Point(236, 158)
        Me.lbl_kg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_kg.Name = "lbl_kg"
        Me.lbl_kg.Size = New System.Drawing.Size(23, 17)
        Me.lbl_kg.TabIndex = 8
        Me.lbl_kg.Text = "kg"
        Me.lbl_kg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_A3
        '
        Me.lbl_A3.AutoSize = True
        Me.lbl_A3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A3.ForeColor = System.Drawing.Color.Red
        Me.lbl_A3.Location = New System.Drawing.Point(269, 155)
        Me.lbl_A3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A3.Name = "lbl_A3"
        Me.lbl_A3.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A3.TabIndex = 9
        Me.lbl_A3.Text = "*"
        '
        'lbl_Peso
        '
        Me.lbl_Peso.AutoSize = True
        Me.lbl_Peso.Location = New System.Drawing.Point(83, 158)
        Me.lbl_Peso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Peso.Name = "lbl_Peso"
        Me.lbl_Peso.Size = New System.Drawing.Size(40, 17)
        Me.lbl_Peso.TabIndex = 6
        Me.lbl_Peso.Text = "Peso"
        Me.lbl_Peso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(79, 60)
        Me.lbl_Nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(43, 17)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Clave"
        Me.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_A2
        '
        Me.lbl_A2.AutoSize = True
        Me.lbl_A2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A2.ForeColor = System.Drawing.Color.Red
        Me.lbl_A2.Location = New System.Drawing.Point(236, 123)
        Me.lbl_A2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A2.Name = "lbl_A2"
        Me.lbl_A2.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A2.TabIndex = 5
        Me.lbl_A2.Text = "*"
        '
        'lbl_A1
        '
        Me.lbl_A1.AutoSize = True
        Me.lbl_A1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A1.ForeColor = System.Drawing.Color.Red
        Me.lbl_A1.Location = New System.Drawing.Point(207, 58)
        Me.lbl_A1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A1.Name = "lbl_A1"
        Me.lbl_A1.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A1.TabIndex = 2
        Me.lbl_A1.Text = "*"
        '
        'Lbl_StockMin
        '
        Me.Lbl_StockMin.AutoSize = True
        Me.Lbl_StockMin.Location = New System.Drawing.Point(27, 126)
        Me.Lbl_StockMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_StockMin.Name = "Lbl_StockMin"
        Me.Lbl_StockMin.Size = New System.Drawing.Size(91, 17)
        Me.Lbl_StockMin.TabIndex = 3
        Me.Lbl_StockMin.Text = "Stock Mínimo"
        Me.Lbl_StockMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Existencia
        '
        Me.Lbl_Existencia.AutoSize = True
        Me.Lbl_Existencia.Location = New System.Drawing.Point(51, 190)
        Me.Lbl_Existencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Existencia.Name = "Lbl_Existencia"
        Me.Lbl_Existencia.Size = New System.Drawing.Size(71, 17)
        Me.Lbl_Existencia.TabIndex = 13
        Me.Lbl_Existencia.Text = "Existencia"
        Me.Lbl_Existencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(376, 390)
        Me.btn_Cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(187, 37)
        Me.btn_Cancelar.TabIndex = 3
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Grp_Dimension
        '
        Me.Grp_Dimension.Controls.Add(Me.lbl_A9)
        Me.Grp_Dimension.Controls.Add(Me.lbl_A7)
        Me.Grp_Dimension.Controls.Add(Me.Lbl_FondoExt)
        Me.Grp_Dimension.Controls.Add(Me.lbl_A8)
        Me.Grp_Dimension.Controls.Add(Me.Lbl_AltoExt)
        Me.Grp_Dimension.Controls.Add(Me.lbl_A6)
        Me.Grp_Dimension.Controls.Add(Me.tbx_AnchoE)
        Me.Grp_Dimension.Controls.Add(Me.tbx_AnchoI)
        Me.Grp_Dimension.Controls.Add(Me.lbl_A4)
        Me.Grp_Dimension.Controls.Add(Me.Lbl_AnchoInt)
        Me.Grp_Dimension.Controls.Add(Me.lbl_cm6)
        Me.Grp_Dimension.Controls.Add(Me.Lbl_AnchoExt)
        Me.Grp_Dimension.Controls.Add(Me.lbl_cm5)
        Me.Grp_Dimension.Controls.Add(Me.lbl_cm1)
        Me.Grp_Dimension.Controls.Add(Me.lbl_cm3)
        Me.Grp_Dimension.Controls.Add(Me.lbl_A5)
        Me.Grp_Dimension.Controls.Add(Me.tbx_FondoE)
        Me.Grp_Dimension.Controls.Add(Me.lbl_cm4)
        Me.Grp_Dimension.Controls.Add(Me.tbx_AltoE)
        Me.Grp_Dimension.Controls.Add(Me.lbl_cm2)
        Me.Grp_Dimension.Controls.Add(Me.tbx_FondoI)
        Me.Grp_Dimension.Controls.Add(Me.Lbl_AltoInt)
        Me.Grp_Dimension.Controls.Add(Me.tbx_AltoI)
        Me.Grp_Dimension.Controls.Add(Me.Lbl_FondoInt)
        Me.Grp_Dimension.Location = New System.Drawing.Point(35, 257)
        Me.Grp_Dimension.Margin = New System.Windows.Forms.Padding(4)
        Me.Grp_Dimension.Name = "Grp_Dimension"
        Me.Grp_Dimension.Padding = New System.Windows.Forms.Padding(4)
        Me.Grp_Dimension.Size = New System.Drawing.Size(528, 126)
        Me.Grp_Dimension.TabIndex = 1
        Me.Grp_Dimension.TabStop = False
        Me.Grp_Dimension.Text = "Dimensiones de la Caja Fuerte"
        '
        'lbl_A9
        '
        Me.lbl_A9.AutoSize = True
        Me.lbl_A9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A9.ForeColor = System.Drawing.Color.Red
        Me.lbl_A9.Location = New System.Drawing.Point(493, 89)
        Me.lbl_A9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A9.Name = "lbl_A9"
        Me.lbl_A9.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A9.TabIndex = 23
        Me.lbl_A9.Text = "*"
        '
        'lbl_A7
        '
        Me.lbl_A7.AutoSize = True
        Me.lbl_A7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A7.ForeColor = System.Drawing.Color.Red
        Me.lbl_A7.Location = New System.Drawing.Point(493, 25)
        Me.lbl_A7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A7.Name = "lbl_A7"
        Me.lbl_A7.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A7.TabIndex = 15
        Me.lbl_A7.Text = "*"
        '
        'Lbl_FondoExt
        '
        Me.Lbl_FondoExt.AutoSize = True
        Me.Lbl_FondoExt.Location = New System.Drawing.Point(24, 91)
        Me.Lbl_FondoExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_FondoExt.Name = "Lbl_FondoExt"
        Me.Lbl_FondoExt.Size = New System.Drawing.Size(100, 17)
        Me.Lbl_FondoExt.TabIndex = 8
        Me.Lbl_FondoExt.Text = "Fondo Exterior"
        Me.Lbl_FondoExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_A8
        '
        Me.lbl_A8.AutoSize = True
        Me.lbl_A8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A8.ForeColor = System.Drawing.Color.Red
        Me.lbl_A8.Location = New System.Drawing.Point(493, 57)
        Me.lbl_A8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A8.Name = "lbl_A8"
        Me.lbl_A8.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A8.TabIndex = 19
        Me.lbl_A8.Text = "*"
        '
        'Lbl_AltoExt
        '
        Me.Lbl_AltoExt.AutoSize = True
        Me.Lbl_AltoExt.Location = New System.Drawing.Point(40, 27)
        Me.Lbl_AltoExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AltoExt.Name = "Lbl_AltoExt"
        Me.Lbl_AltoExt.Size = New System.Drawing.Size(84, 17)
        Me.Lbl_AltoExt.TabIndex = 0
        Me.Lbl_AltoExt.Text = "Alto Exterior"
        Me.Lbl_AltoExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_A6
        '
        Me.lbl_A6.AutoSize = True
        Me.lbl_A6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A6.ForeColor = System.Drawing.Color.Red
        Me.lbl_A6.Location = New System.Drawing.Point(225, 89)
        Me.lbl_A6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A6.Name = "lbl_A6"
        Me.lbl_A6.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A6.TabIndex = 11
        Me.lbl_A6.Text = "*"
        '
        'lbl_A4
        '
        Me.lbl_A4.AutoSize = True
        Me.lbl_A4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A4.ForeColor = System.Drawing.Color.Red
        Me.lbl_A4.Location = New System.Drawing.Point(225, 25)
        Me.lbl_A4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A4.Name = "lbl_A4"
        Me.lbl_A4.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A4.TabIndex = 3
        Me.lbl_A4.Text = "*"
        '
        'Lbl_AnchoInt
        '
        Me.Lbl_AnchoInt.AutoSize = True
        Me.Lbl_AnchoInt.Location = New System.Drawing.Point(295, 59)
        Me.Lbl_AnchoInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AnchoInt.Name = "Lbl_AnchoInt"
        Me.Lbl_AnchoInt.Size = New System.Drawing.Size(96, 17)
        Me.Lbl_AnchoInt.TabIndex = 16
        Me.Lbl_AnchoInt.Text = "Ancho Interior"
        Me.Lbl_AnchoInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm6
        '
        Me.lbl_cm6.AutoSize = True
        Me.lbl_cm6.Location = New System.Drawing.Point(457, 91)
        Me.lbl_cm6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cm6.Name = "lbl_cm6"
        Me.lbl_cm6.Size = New System.Drawing.Size(26, 17)
        Me.lbl_cm6.TabIndex = 22
        Me.lbl_cm6.Text = "cm"
        Me.lbl_cm6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_AnchoExt
        '
        Me.Lbl_AnchoExt.AutoSize = True
        Me.Lbl_AnchoExt.Location = New System.Drawing.Point(23, 59)
        Me.Lbl_AnchoExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AnchoExt.Name = "Lbl_AnchoExt"
        Me.Lbl_AnchoExt.Size = New System.Drawing.Size(100, 17)
        Me.Lbl_AnchoExt.TabIndex = 4
        Me.Lbl_AnchoExt.Text = "Ancho Exterior"
        Me.Lbl_AnchoExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm5
        '
        Me.lbl_cm5.AutoSize = True
        Me.lbl_cm5.Location = New System.Drawing.Point(457, 27)
        Me.lbl_cm5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cm5.Name = "lbl_cm5"
        Me.lbl_cm5.Size = New System.Drawing.Size(26, 17)
        Me.lbl_cm5.TabIndex = 14
        Me.lbl_cm5.Text = "cm"
        Me.lbl_cm5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm1
        '
        Me.lbl_cm1.AutoSize = True
        Me.lbl_cm1.Location = New System.Drawing.Point(189, 59)
        Me.lbl_cm1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cm1.Name = "lbl_cm1"
        Me.lbl_cm1.Size = New System.Drawing.Size(26, 17)
        Me.lbl_cm1.TabIndex = 6
        Me.lbl_cm1.Text = "cm"
        Me.lbl_cm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm3
        '
        Me.lbl_cm3.AutoSize = True
        Me.lbl_cm3.Location = New System.Drawing.Point(189, 91)
        Me.lbl_cm3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cm3.Name = "lbl_cm3"
        Me.lbl_cm3.Size = New System.Drawing.Size(26, 17)
        Me.lbl_cm3.TabIndex = 10
        Me.lbl_cm3.Text = "cm"
        Me.lbl_cm3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_A5
        '
        Me.lbl_A5.AutoSize = True
        Me.lbl_A5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_A5.ForeColor = System.Drawing.Color.Red
        Me.lbl_A5.Location = New System.Drawing.Point(225, 57)
        Me.lbl_A5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_A5.Name = "lbl_A5"
        Me.lbl_A5.Size = New System.Drawing.Size(16, 19)
        Me.lbl_A5.TabIndex = 7
        Me.lbl_A5.Text = "*"
        '
        'lbl_cm4
        '
        Me.lbl_cm4.AutoSize = True
        Me.lbl_cm4.Location = New System.Drawing.Point(457, 59)
        Me.lbl_cm4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cm4.Name = "lbl_cm4"
        Me.lbl_cm4.Size = New System.Drawing.Size(26, 17)
        Me.lbl_cm4.TabIndex = 18
        Me.lbl_cm4.Text = "cm"
        Me.lbl_cm4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm2
        '
        Me.lbl_cm2.AutoSize = True
        Me.lbl_cm2.Location = New System.Drawing.Point(189, 27)
        Me.lbl_cm2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cm2.Name = "lbl_cm2"
        Me.lbl_cm2.Size = New System.Drawing.Size(26, 17)
        Me.lbl_cm2.TabIndex = 2
        Me.lbl_cm2.Text = "cm"
        Me.lbl_cm2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_AltoInt
        '
        Me.Lbl_AltoInt.AutoSize = True
        Me.Lbl_AltoInt.Location = New System.Drawing.Point(312, 27)
        Me.Lbl_AltoInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AltoInt.Name = "Lbl_AltoInt"
        Me.Lbl_AltoInt.Size = New System.Drawing.Size(80, 17)
        Me.Lbl_AltoInt.TabIndex = 12
        Me.Lbl_AltoInt.Text = "Alto Interior"
        Me.Lbl_AltoInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_FondoInt
        '
        Me.Lbl_FondoInt.AutoSize = True
        Me.Lbl_FondoInt.Location = New System.Drawing.Point(296, 91)
        Me.Lbl_FondoInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_FondoInt.Name = "Lbl_FondoInt"
        Me.Lbl_FondoInt.Size = New System.Drawing.Size(96, 17)
        Me.Lbl_FondoInt.TabIndex = 20
        Me.Lbl_FondoInt.Text = "Fondo Interior"
        Me.Lbl_FondoInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = True
        Me.tbx_Buscar.Location = New System.Drawing.Point(69, 7)
        Me.tbx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Buscar.MaxLength = 150
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(763, 22)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(4, 68)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.Margin = New System.Windows.Forms.Padding(4)
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 7
        Me.lsv_Catalogo.Row10 = 9
        Me.lsv_Catalogo.Row2 = 8
        Me.lsv_Catalogo.Row3 = 9
        Me.lsv_Catalogo.Row4 = 9
        Me.lsv_Catalogo.Row5 = 9
        Me.lsv_Catalogo.Row6 = 9
        Me.lsv_Catalogo.Row7 = 9
        Me.lsv_Catalogo.Row8 = 9
        Me.lsv_Catalogo.Row9 = 9
        Me.lsv_Catalogo.Size = New System.Drawing.Size(932, 507)
        Me.lsv_Catalogo.TabIndex = 4
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(132, 23)
        Me.cmb_Tipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(303, 24)
        Me.cmb_Tipo.TabIndex = 15
        Me.cmb_Tipo.ValueMember = "value"
        '
        'tbx_Modelo
        '
        Me.tbx_Modelo.Control_Siguiente = Me.tbx_AltoE
        Me.tbx_Modelo.Filtrado = True
        Me.tbx_Modelo.Location = New System.Drawing.Point(132, 89)
        Me.tbx_Modelo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Modelo.MaxLength = 9
        Me.tbx_Modelo.Name = "tbx_Modelo"
        Me.tbx_Modelo.Size = New System.Drawing.Size(153, 22)
        Me.tbx_Modelo.TabIndex = 11
        Me.tbx_Modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Modelo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_AltoE
        '
        Me.tbx_AltoE.Control_Siguiente = Me.tbx_AnchoE
        Me.tbx_AltoE.Filtrado = True
        Me.tbx_AltoE.Location = New System.Drawing.Point(132, 23)
        Me.tbx_AltoE.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_AltoE.MaxLength = 3
        Me.tbx_AltoE.Name = "tbx_AltoE"
        Me.tbx_AltoE.Size = New System.Drawing.Size(48, 22)
        Me.tbx_AltoE.TabIndex = 1
        Me.tbx_AltoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AltoE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_AnchoE
        '
        Me.tbx_AnchoE.Control_Siguiente = Me.tbx_FondoE
        Me.tbx_AnchoE.Filtrado = True
        Me.tbx_AnchoE.Location = New System.Drawing.Point(132, 55)
        Me.tbx_AnchoE.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_AnchoE.MaxLength = 3
        Me.tbx_AnchoE.Name = "tbx_AnchoE"
        Me.tbx_AnchoE.Size = New System.Drawing.Size(48, 22)
        Me.tbx_AnchoE.TabIndex = 5
        Me.tbx_AnchoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AnchoE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_FondoE
        '
        Me.tbx_FondoE.Control_Siguiente = Me.tbx_AltoI
        Me.tbx_FondoE.Filtrado = True
        Me.tbx_FondoE.Location = New System.Drawing.Point(132, 87)
        Me.tbx_FondoE.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_FondoE.MaxLength = 3
        Me.tbx_FondoE.Name = "tbx_FondoE"
        Me.tbx_FondoE.Size = New System.Drawing.Size(48, 22)
        Me.tbx_FondoE.TabIndex = 9
        Me.tbx_FondoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_FondoE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_AltoI
        '
        Me.tbx_AltoI.Control_Siguiente = Me.tbx_AnchoI
        Me.tbx_AltoI.Filtrado = True
        Me.tbx_AltoI.Location = New System.Drawing.Point(400, 23)
        Me.tbx_AltoI.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_AltoI.MaxLength = 3
        Me.tbx_AltoI.Name = "tbx_AltoI"
        Me.tbx_AltoI.Size = New System.Drawing.Size(48, 22)
        Me.tbx_AltoI.TabIndex = 13
        Me.tbx_AltoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AltoI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_AnchoI
        '
        Me.tbx_AnchoI.Control_Siguiente = Me.tbx_FondoI
        Me.tbx_AnchoI.Filtrado = True
        Me.tbx_AnchoI.Location = New System.Drawing.Point(400, 55)
        Me.tbx_AnchoI.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_AnchoI.MaxLength = 3
        Me.tbx_AnchoI.Name = "tbx_AnchoI"
        Me.tbx_AnchoI.Size = New System.Drawing.Size(48, 22)
        Me.tbx_AnchoI.TabIndex = 17
        Me.tbx_AnchoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AnchoI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_FondoI
        '
        Me.tbx_FondoI.Control_Siguiente = Me.btn_Guardar
        Me.tbx_FondoI.Filtrado = True
        Me.tbx_FondoI.Location = New System.Drawing.Point(400, 87)
        Me.tbx_FondoI.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_FondoI.MaxLength = 3
        Me.tbx_FondoI.Name = "tbx_FondoI"
        Me.tbx_FondoI.Size = New System.Drawing.Size(48, 22)
        Me.tbx_FondoI.TabIndex = 21
        Me.tbx_FondoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_FondoI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Peso
        '
        Me.tbx_Peso.Control_Siguiente = Me.tbx_Modelo
        Me.tbx_Peso.Filtrado = True
        Me.tbx_Peso.Location = New System.Drawing.Point(132, 154)
        Me.tbx_Peso.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Peso.MaxLength = 9
        Me.tbx_Peso.Name = "tbx_Peso"
        Me.tbx_Peso.Size = New System.Drawing.Size(95, 22)
        Me.tbx_Peso.TabIndex = 7
        Me.tbx_Peso.Text = "0.00"
        Me.tbx_Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Peso.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_StockMinimo
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(132, 57)
        Me.tbx_Clave.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(65, 22)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_StockMinimo
        '
        Me.tbx_StockMinimo.Control_Siguiente = Me.tbx_AltoE
        Me.tbx_StockMinimo.Filtrado = True
        Me.tbx_StockMinimo.Location = New System.Drawing.Point(132, 122)
        Me.tbx_StockMinimo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_StockMinimo.MaxLength = 9
        Me.tbx_StockMinimo.Name = "tbx_StockMinimo"
        Me.tbx_StockMinimo.Size = New System.Drawing.Size(95, 22)
        Me.tbx_StockMinimo.TabIndex = 4
        Me.tbx_StockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_StockMinimo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Existencia
        '
        Me.tbx_Existencia.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Existencia.Filtrado = True
        Me.tbx_Existencia.Location = New System.Drawing.Point(132, 186)
        Me.tbx_Existencia.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_Existencia.MaxLength = 9
        Me.tbx_Existencia.Name = "tbx_Existencia"
        Me.tbx_Existencia.ReadOnly = True
        Me.tbx_Existencia.Size = New System.Drawing.Size(95, 22)
        Me.tbx_Existencia.TabIndex = 14
        Me.tbx_Existencia.TabStop = False
        Me.tbx_Existencia.Text = "0"
        Me.tbx_Existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Existencia.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'gb_Carateristicas
        '
        Me.gb_Carateristicas.Controls.Add(Me.lbl_TipoDial)
        Me.gb_Carateristicas.Controls.Add(Me.lbl_TipoChapa)
        Me.gb_Carateristicas.Controls.Add(Me.lbl_TipoReceptor)
        Me.gb_Carateristicas.Controls.Add(Me.Cp_cmb_TipoDial)
        Me.gb_Carateristicas.Controls.Add(Me.Cp_cmb_TipoChapa)
        Me.gb_Carateristicas.Controls.Add(Me.Cp_cmb_TipoReceptor)
        Me.gb_Carateristicas.Location = New System.Drawing.Point(609, 39)
        Me.gb_Carateristicas.Name = "gb_Carateristicas"
        Me.gb_Carateristicas.Size = New System.Drawing.Size(459, 211)
        Me.gb_Carateristicas.TabIndex = 20
        Me.gb_Carateristicas.TabStop = False
        Me.gb_Carateristicas.Text = "Caracteristicas"
        '
        'lbl_TipoDial
        '
        Me.lbl_TipoDial.AutoSize = True
        Me.lbl_TipoDial.Location = New System.Drawing.Point(47, 110)
        Me.lbl_TipoDial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TipoDial.Name = "lbl_TipoDial"
        Me.lbl_TipoDial.Size = New System.Drawing.Size(68, 17)
        Me.lbl_TipoDial.TabIndex = 25
        Me.lbl_TipoDial.Text = "Tipo Dial:"
        Me.lbl_TipoDial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_TipoChapa
        '
        Me.lbl_TipoChapa.AutoSize = True
        Me.lbl_TipoChapa.Location = New System.Drawing.Point(47, 78)
        Me.lbl_TipoChapa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TipoChapa.Name = "lbl_TipoChapa"
        Me.lbl_TipoChapa.Size = New System.Drawing.Size(117, 17)
        Me.lbl_TipoChapa.TabIndex = 24
        Me.lbl_TipoChapa.Text = "Tipo Tipo Chapa:"
        Me.lbl_TipoChapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_TipoReceptor
        '
        Me.lbl_TipoReceptor.AutoSize = True
        Me.lbl_TipoReceptor.Location = New System.Drawing.Point(47, 49)
        Me.lbl_TipoReceptor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TipoReceptor.Name = "lbl_TipoReceptor"
        Me.lbl_TipoReceptor.Size = New System.Drawing.Size(102, 17)
        Me.lbl_TipoReceptor.TabIndex = 23
        Me.lbl_TipoReceptor.Text = "Tipo Receptor:"
        Me.lbl_TipoReceptor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cp_cmb_TipoDial
        '
        Me.Cp_cmb_TipoDial.Clave = Nothing
        Me.Cp_cmb_TipoDial.Control_Siguiente = Nothing
        Me.Cp_cmb_TipoDial.DisplayMember = "Descripcion"
        Me.Cp_cmb_TipoDial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cp_cmb_TipoDial.Empresa = False
        Me.Cp_cmb_TipoDial.Filtro = Nothing
        Me.Cp_cmb_TipoDial.FormattingEnabled = True
        Me.Cp_cmb_TipoDial.Location = New System.Drawing.Point(182, 110)
        Me.Cp_cmb_TipoDial.MaxDropDownItems = 20
        Me.Cp_cmb_TipoDial.Name = "Cp_cmb_TipoDial"
        Me.Cp_cmb_TipoDial.Pista = False
        Me.Cp_cmb_TipoDial.Size = New System.Drawing.Size(228, 24)
        Me.Cp_cmb_TipoDial.StoredProcedure = "CajaFuerte_TipoDial_Get"
        Me.Cp_cmb_TipoDial.Sucursal = False
        Me.Cp_cmb_TipoDial.TabIndex = 22
        Me.Cp_cmb_TipoDial.Tipo = 0
        Me.Cp_cmb_TipoDial.ValueMember = "id_TipoDial"
        '
        'Cp_cmb_TipoChapa
        '
        Me.Cp_cmb_TipoChapa.Clave = Nothing
        Me.Cp_cmb_TipoChapa.Control_Siguiente = Nothing
        Me.Cp_cmb_TipoChapa.DisplayMember = "Descripcion"
        Me.Cp_cmb_TipoChapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cp_cmb_TipoChapa.Empresa = False
        Me.Cp_cmb_TipoChapa.Filtro = Nothing
        Me.Cp_cmb_TipoChapa.FormattingEnabled = True
        Me.Cp_cmb_TipoChapa.Location = New System.Drawing.Point(182, 77)
        Me.Cp_cmb_TipoChapa.MaxDropDownItems = 20
        Me.Cp_cmb_TipoChapa.Name = "Cp_cmb_TipoChapa"
        Me.Cp_cmb_TipoChapa.Pista = False
        Me.Cp_cmb_TipoChapa.Size = New System.Drawing.Size(228, 24)
        Me.Cp_cmb_TipoChapa.StoredProcedure = "CajaFuerte_TipoChapa_Get"
        Me.Cp_cmb_TipoChapa.Sucursal = False
        Me.Cp_cmb_TipoChapa.TabIndex = 21
        Me.Cp_cmb_TipoChapa.Tipo = 0
        Me.Cp_cmb_TipoChapa.ValueMember = "id_TipoChapa"
        '
        'Cp_cmb_TipoReceptor
        '
        Me.Cp_cmb_TipoReceptor.Clave = Nothing
        Me.Cp_cmb_TipoReceptor.Control_Siguiente = Nothing
        Me.Cp_cmb_TipoReceptor.DisplayMember = "Descripcion"
        Me.Cp_cmb_TipoReceptor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cp_cmb_TipoReceptor.Empresa = False
        Me.Cp_cmb_TipoReceptor.Filtro = Nothing
        Me.Cp_cmb_TipoReceptor.FormattingEnabled = True
        Me.Cp_cmb_TipoReceptor.Location = New System.Drawing.Point(182, 42)
        Me.Cp_cmb_TipoReceptor.MaxDropDownItems = 20
        Me.Cp_cmb_TipoReceptor.Name = "Cp_cmb_TipoReceptor"
        Me.Cp_cmb_TipoReceptor.Pista = False
        Me.Cp_cmb_TipoReceptor.Size = New System.Drawing.Size(228, 24)
        Me.Cp_cmb_TipoReceptor.StoredProcedure = "CajaFuerte_TipoReceptor_Get"
        Me.Cp_cmb_TipoReceptor.Sucursal = False
        Me.Cp_cmb_TipoReceptor.TabIndex = 20
        Me.Cp_cmb_TipoReceptor.Tipo = 0
        Me.Cp_cmb_TipoReceptor.ValueMember = "id_TipoReceptor"
        '
        'frm_CajasFuertesT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(967, 699)
        Me.Name = "frm_CajasFuertesT"
        Me.Text = "Catálogo de Tipos de Cajas Fuertes"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.grp_DatosGenerales.ResumeLayout(False)
        Me.grp_DatosGenerales.PerformLayout()
        Me.Grp_Dimension.ResumeLayout(False)
        Me.Grp_Dimension.PerformLayout()
        Me.gb_Carateristicas.ResumeLayout(False)
        Me.gb_Carateristicas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents tbx_AltoE As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_FondoE As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_FondoExt As System.Windows.Forms.Label
    Friend WithEvents Lbl_AltoExt As System.Windows.Forms.Label
    Friend WithEvents Lbl_StockMin As System.Windows.Forms.Label
    Friend WithEvents Lbl_Existencia As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Lbl_AnchoExt As System.Windows.Forms.Label
    Friend WithEvents tbx_Existencia As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_StockMinimo As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Clave As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_A1 As System.Windows.Forms.Label
    Friend WithEvents lbl_A2 As System.Windows.Forms.Label
    Friend WithEvents Grp_Dimension As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_A9 As System.Windows.Forms.Label
    Friend WithEvents lbl_A7 As System.Windows.Forms.Label
    Friend WithEvents lbl_A8 As System.Windows.Forms.Label
    Friend WithEvents lbl_A6 As System.Windows.Forms.Label
    Friend WithEvents lbl_A4 As System.Windows.Forms.Label
    Friend WithEvents lbl_A5 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm6 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm5 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm4 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm3 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm1 As System.Windows.Forms.Label
    Friend WithEvents tbx_FondoI As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_AnchoE As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_AnchoInt As System.Windows.Forms.Label
    Friend WithEvents tbx_AnchoI As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_AltoInt As System.Windows.Forms.Label
    Friend WithEvents tbx_AltoI As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_FondoInt As System.Windows.Forms.Label
    Friend WithEvents grp_DatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_A3 As System.Windows.Forms.Label
    Friend WithEvents tbx_Peso As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Peso As System.Windows.Forms.Label
    Friend WithEvents lbl_kg As System.Windows.Forms.Label
    Friend WithEvents cbx_Activos As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Modelo As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Modelo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents gb_Carateristicas As GroupBox
    Friend WithEvents lbl_TipoDial As Label
    Friend WithEvents lbl_TipoChapa As Label
    Friend WithEvents lbl_TipoReceptor As Label
    Friend WithEvents Cp_cmb_TipoDial As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Cp_cmb_TipoChapa As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Cp_cmb_TipoReceptor As cp_cmb_SimpleFiltradoParam
End Class
