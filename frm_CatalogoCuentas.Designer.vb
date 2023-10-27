<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogoCuentas
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
        Dim ListViewColumnSorter4 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CatalogoCuentas))
        Dim ListViewColumnSorter3 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.tab_Listado = New System.Windows.Forms.TabPage()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.cbx_Activas = New System.Windows.Forms.CheckBox()
        Me.tbx_Banco = New Modulo_Ventas.cp_Textbox()
        Me.cmb_Banco = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Banco = New System.Windows.Forms.Label()
        Me.BTN_Modificar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.BTN_Exportar = New System.Windows.Forms.Button()
        Me.Btn_Baja = New System.Windows.Forms.Button()
        Me.btn_Banco = New System.Windows.Forms.Button()
        Me.BTN_Buscar = New System.Windows.Forms.Button()
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox()
        Me.Lbl_Buscar = New System.Windows.Forms.Label()
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview()
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_BajaRef = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.gbx_Referencias = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_Moneda = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Cuenta = New Modulo_Ventas.cp_Textbox()
        Me.cmb_Pais = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Estado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Ciudad = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.btn_EliminaReferencia = New System.Windows.Forms.Button()
        Me.btn_BuscarRef = New System.Windows.Forms.Button()
        Me.tbx_BuscarRef = New Modulo_Ventas.cp_Textbox()
        Me.lbl_buscar1 = New System.Windows.Forms.Label()
        Me.Btn_2_AgregarReferencia = New System.Windows.Forms.Button()
        Me.lsv_2_Referencia = New Modulo_Ventas.cp_Listview()
        Me.tbx_Referencia = New Modulo_Ventas.cp_Textbox()
        Me.lbl_2_Referencia = New System.Windows.Forms.Label()
        Me.Gbx_Cuentas = New System.Windows.Forms.GroupBox()
        Me.chk_cuentaDefault = New System.Windows.Forms.CheckBox()
        Me.btn_Banco2 = New System.Windows.Forms.Button()
        Me.tbx_Banco2 = New Modulo_Ventas.cp_Textbox()
        Me.cmb_Banco2 = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Banco2 = New System.Windows.Forms.Label()
        Me.lbl_2_Ciudad = New System.Windows.Forms.Label()
        Me.lbl_2_Estado = New System.Windows.Forms.Label()
        Me.lbl_2_Pais = New System.Windows.Forms.Label()
        Me.lbl_2_Cuenta = New System.Windows.Forms.Label()
        Me.lbl_Moneda = New System.Windows.Forms.Label()
        Me.lbl_2_ReferenciaFija = New System.Windows.Forms.Label()
        Me.lbl_2_Referenciada = New System.Windows.Forms.Label()
        Me.cmb_ReferenciaFija = New Modulo_Ventas.cp_cmb_Manual()
        Me.cmb_Referenciada = New Modulo_Ventas.cp_cmb_Manual()
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Referencias.SuspendLayout()
        Me.Gbx_Cuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(791, 562)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.cbx_Activas)
        Me.tab_Listado.Controls.Add(Me.tbx_Banco)
        Me.tab_Listado.Controls.Add(Me.cmb_Banco)
        Me.tab_Listado.Controls.Add(Me.lbl_Banco)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.btn_Banco)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(783, 536)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(633, 55)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(135, 23)
        Me.Lbl_Registros.TabIndex = 20
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbx_Activas
        '
        Me.cbx_Activas.AutoSize = True
        Me.cbx_Activas.Checked = True
        Me.cbx_Activas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Activas.Location = New System.Drawing.Point(57, 58)
        Me.cbx_Activas.Name = "cbx_Activas"
        Me.cbx_Activas.Size = New System.Drawing.Size(164, 17)
        Me.cbx_Activas.TabIndex = 7
        Me.cbx_Activas.Text = "Sólo mostrar Cuentas Activas"
        Me.cbx_Activas.UseVisualStyleBackColor = True
        '
        'tbx_Banco
        '
        Me.tbx_Banco.Control_Siguiente = Nothing
        Me.tbx_Banco.Filtrado = True
        Me.tbx_Banco.Location = New System.Drawing.Point(57, 32)
        Me.tbx_Banco.MaxLength = 4
        Me.tbx_Banco.Name = "tbx_Banco"
        Me.tbx_Banco.Size = New System.Drawing.Size(80, 20)
        Me.tbx_Banco.TabIndex = 4
        Me.tbx_Banco.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = "Clave"
        Me.cmb_Banco.Control_Siguiente = Nothing
        Me.cmb_Banco.DisplayMember = "Nombre_Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Me.tbx_Banco
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(143, 31)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(482, 21)
        Me.cmb_Banco.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_Banco.Sucursal = True
        Me.cmb_Banco.TabIndex = 5
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(13, 35)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco.TabIndex = 3
        Me.lbl_Banco.Text = "Banco"
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(154, 498)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 10
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 498)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 13
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(300, 498)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 11
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
        Me.Btn_Baja.Location = New System.Drawing.Point(8, 498)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 9
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Banco
        '
        Me.btn_Banco.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Banco.Location = New System.Drawing.Point(630, 29)
        Me.btn_Banco.Name = "btn_Banco"
        Me.btn_Banco.Size = New System.Drawing.Size(26, 23)
        Me.btn_Banco.TabIndex = 6
        Me.btn_Banco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Banco.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(74, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(8, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(8, 81)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter4
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 17
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 14
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 20
        Me.lsv_Catalogo.Row5 = 15
        Me.lsv_Catalogo.Row6 = 15
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(762, 411)
        Me.lsv_Catalogo.TabIndex = 8
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.gbx_Botones)
        Me.Tab_Nuevo.Controls.Add(Me.gbx_Referencias)
        Me.Tab_Nuevo.Controls.Add(Me.Gbx_Cuentas)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(783, 536)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_BajaRef)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(1, 481)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(779, 47)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(633, 11)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_BajaRef
        '
        Me.btn_BajaRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_BajaRef.Enabled = False
        Me.btn_BajaRef.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.btn_BajaRef.Location = New System.Drawing.Point(152, 11)
        Me.btn_BajaRef.Name = "btn_BajaRef"
        Me.btn_BajaRef.Size = New System.Drawing.Size(140, 30)
        Me.btn_BajaRef.TabIndex = 1
        Me.btn_BajaRef.Text = "&Baja/Reingreso"
        Me.btn_BajaRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BajaRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BajaRef.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbx_Referencias
        '
        Me.gbx_Referencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Referencias.Controls.Add(Me.Label1)
        Me.gbx_Referencias.Controls.Add(Me.cmb_Status)
        Me.gbx_Referencias.Controls.Add(Me.btn_EliminaReferencia)
        Me.gbx_Referencias.Controls.Add(Me.btn_BuscarRef)
        Me.gbx_Referencias.Controls.Add(Me.tbx_BuscarRef)
        Me.gbx_Referencias.Controls.Add(Me.lbl_buscar1)
        Me.gbx_Referencias.Controls.Add(Me.Btn_2_AgregarReferencia)
        Me.gbx_Referencias.Controls.Add(Me.lsv_2_Referencia)
        Me.gbx_Referencias.Controls.Add(Me.tbx_Referencia)
        Me.gbx_Referencias.Controls.Add(Me.lbl_2_Referencia)
        Me.gbx_Referencias.Enabled = False
        Me.gbx_Referencias.Location = New System.Drawing.Point(1, 173)
        Me.gbx_Referencias.Name = "gbx_Referencias"
        Me.gbx_Referencias.Size = New System.Drawing.Size(779, 302)
        Me.gbx_Referencias.TabIndex = 1
        Me.gbx_Referencias.TabStop = False
        Me.gbx_Referencias.Text = "Referencias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Status"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(446, 18)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(268, 21)
        Me.cmb_Status.TabIndex = 9
        Me.cmb_Status.ValueMember = "value"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Clave = Nothing
        Me.cmb_Moneda.Control_Siguiente = Me.tbx_Cuenta
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Filtro = Nothing
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(105, 68)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 9
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'tbx_Cuenta
        '
        Me.tbx_Cuenta.Control_Siguiente = Me.cmb_Pais
        Me.tbx_Cuenta.Filtrado = True
        Me.tbx_Cuenta.Location = New System.Drawing.Point(446, 68)
        Me.tbx_Cuenta.MaxLength = 15
        Me.tbx_Cuenta.Name = "tbx_Cuenta"
        Me.tbx_Cuenta.Size = New System.Drawing.Size(268, 20)
        Me.tbx_Cuenta.TabIndex = 11
        Me.tbx_Cuenta.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Pais
        '
        Me.cmb_Pais.Clave = Nothing
        Me.cmb_Pais.Control_Siguiente = Me.cmb_Estado
        Me.cmb_Pais.DisplayMember = "Nombre"
        Me.cmb_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pais.Empresa = False
        Me.cmb_Pais.Filtro = Nothing
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(105, 95)
        Me.cmb_Pais.MaxDropDownItems = 20
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.Pista = True
        Me.cmb_Pais.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Pais.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Pais.Sucursal = False
        Me.cmb_Pais.TabIndex = 13
        Me.cmb_Pais.Tipo = 0
        Me.cmb_Pais.ValueMember = "Id_Pais"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.Clave = Nothing
        Me.cmb_Estado.Control_Siguiente = Me.cmb_Ciudad
        Me.cmb_Estado.DisplayMember = "Nombre"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Empresa = False
        Me.cmb_Estado.Filtro = Nothing
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(446, 95)
        Me.cmb_Estado.MaxDropDownItems = 20
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Pista = True
        Me.cmb_Estado.Size = New System.Drawing.Size(268, 21)
        Me.cmb_Estado.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_Estado.Sucursal = False
        Me.cmb_Estado.TabIndex = 15
        Me.cmb_Estado.Tipo = 0
        Me.cmb_Estado.ValueMember = "Id_Estado"
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
        Me.cmb_Ciudad.Location = New System.Drawing.Point(105, 122)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = True
        Me.cmb_Ciudad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 17
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'btn_EliminaReferencia
        '
        Me.btn_EliminaReferencia.Enabled = False
        Me.btn_EliminaReferencia.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.btn_EliminaReferencia.Location = New System.Drawing.Point(466, 45)
        Me.btn_EliminaReferencia.Name = "btn_EliminaReferencia"
        Me.btn_EliminaReferencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_EliminaReferencia.TabIndex = 7
        Me.btn_EliminaReferencia.Text = "Eliminar Referencia"
        Me.btn_EliminaReferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EliminaReferencia.UseVisualStyleBackColor = True
        '
        'btn_BuscarRef
        '
        Me.btn_BuscarRef.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarRef.Location = New System.Drawing.Point(317, 16)
        Me.btn_BuscarRef.Name = "btn_BuscarRef"
        Me.btn_BuscarRef.Size = New System.Drawing.Size(74, 23)
        Me.btn_BuscarRef.TabIndex = 3
        Me.btn_BuscarRef.Text = "B&uscar"
        Me.btn_BuscarRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarRef.UseVisualStyleBackColor = True
        '
        'tbx_BuscarRef
        '
        Me.tbx_BuscarRef.Control_Siguiente = Me.btn_BuscarRef
        Me.tbx_BuscarRef.Filtrado = False
        Me.tbx_BuscarRef.Location = New System.Drawing.Point(103, 19)
        Me.tbx_BuscarRef.Name = "tbx_BuscarRef"
        Me.tbx_BuscarRef.Size = New System.Drawing.Size(208, 20)
        Me.tbx_BuscarRef.TabIndex = 2
        Me.tbx_BuscarRef.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_buscar1
        '
        Me.lbl_buscar1.AutoSize = True
        Me.lbl_buscar1.Location = New System.Drawing.Point(54, 22)
        Me.lbl_buscar1.Name = "lbl_buscar1"
        Me.lbl_buscar1.Size = New System.Drawing.Size(43, 13)
        Me.lbl_buscar1.TabIndex = 1
        Me.lbl_buscar1.Text = "Buscar:"
        '
        'Btn_2_AgregarReferencia
        '
        Me.Btn_2_AgregarReferencia.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.Btn_2_AgregarReferencia.Location = New System.Drawing.Point(317, 45)
        Me.Btn_2_AgregarReferencia.Name = "Btn_2_AgregarReferencia"
        Me.Btn_2_AgregarReferencia.Size = New System.Drawing.Size(140, 30)
        Me.Btn_2_AgregarReferencia.TabIndex = 6
        Me.Btn_2_AgregarReferencia.Text = "Agregar"
        Me.Btn_2_AgregarReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_2_AgregarReferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_2_AgregarReferencia.UseVisualStyleBackColor = True
        '
        'lsv_2_Referencia
        '
        Me.lsv_2_Referencia.AllowColumnReorder = True
        Me.lsv_2_Referencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_2_Referencia.FullRowSelect = True
        Me.lsv_2_Referencia.HideSelection = False
        Me.lsv_2_Referencia.Location = New System.Drawing.Point(6, 80)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_2_Referencia.Lvs = ListViewColumnSorter3
        Me.lsv_2_Referencia.MultiSelect = False
        Me.lsv_2_Referencia.Name = "lsv_2_Referencia"
        Me.lsv_2_Referencia.Row1 = 25
        Me.lsv_2_Referencia.Row10 = 0
        Me.lsv_2_Referencia.Row2 = 20
        Me.lsv_2_Referencia.Row3 = 0
        Me.lsv_2_Referencia.Row4 = 0
        Me.lsv_2_Referencia.Row5 = 0
        Me.lsv_2_Referencia.Row6 = 0
        Me.lsv_2_Referencia.Row7 = 0
        Me.lsv_2_Referencia.Row8 = 0
        Me.lsv_2_Referencia.Row9 = 0
        Me.lsv_2_Referencia.Size = New System.Drawing.Size(767, 216)
        Me.lsv_2_Referencia.TabIndex = 0
        Me.lsv_2_Referencia.UseCompatibleStateImageBehavior = False
        Me.lsv_2_Referencia.View = System.Windows.Forms.View.Details
        '
        'tbx_Referencia
        '
        Me.tbx_Referencia.Control_Siguiente = Me.Btn_2_AgregarReferencia
        Me.tbx_Referencia.Filtrado = True
        Me.tbx_Referencia.Location = New System.Drawing.Point(102, 55)
        Me.tbx_Referencia.MaxLength = 50
        Me.tbx_Referencia.Name = "tbx_Referencia"
        Me.tbx_Referencia.Size = New System.Drawing.Size(209, 20)
        Me.tbx_Referencia.TabIndex = 5
        Me.tbx_Referencia.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_2_Referencia
        '
        Me.lbl_2_Referencia.AutoSize = True
        Me.lbl_2_Referencia.Location = New System.Drawing.Point(3, 57)
        Me.lbl_2_Referencia.Name = "lbl_2_Referencia"
        Me.lbl_2_Referencia.Size = New System.Drawing.Size(94, 13)
        Me.lbl_2_Referencia.TabIndex = 4
        Me.lbl_2_Referencia.Text = "Nueva Referencia"
        '
        'Gbx_Cuentas
        '
        Me.Gbx_Cuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Cuentas.Controls.Add(Me.chk_cuentaDefault)
        Me.Gbx_Cuentas.Controls.Add(Me.btn_Banco2)
        Me.Gbx_Cuentas.Controls.Add(Me.tbx_Banco2)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_Banco2)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_Banco2)
        Me.Gbx_Cuentas.Controls.Add(Me.tbx_Cuenta)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_2_Ciudad)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_2_Estado)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_2_Pais)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_2_Cuenta)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_Moneda)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_2_ReferenciaFija)
        Me.Gbx_Cuentas.Controls.Add(Me.lbl_2_Referenciada)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_Ciudad)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_Estado)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_Pais)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_Moneda)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_ReferenciaFija)
        Me.Gbx_Cuentas.Controls.Add(Me.cmb_Referenciada)
        Me.Gbx_Cuentas.Location = New System.Drawing.Point(1, 6)
        Me.Gbx_Cuentas.Name = "Gbx_Cuentas"
        Me.Gbx_Cuentas.Size = New System.Drawing.Size(779, 161)
        Me.Gbx_Cuentas.TabIndex = 0
        Me.Gbx_Cuentas.TabStop = False
        Me.Gbx_Cuentas.Text = "Cuentas"
        '
        'chk_cuentaDefault
        '
        Me.chk_cuentaDefault.AutoSize = True
        Me.chk_cuentaDefault.Location = New System.Drawing.Point(446, 126)
        Me.chk_cuentaDefault.Name = "chk_cuentaDefault"
        Me.chk_cuentaDefault.Size = New System.Drawing.Size(178, 17)
        Me.chk_cuentaDefault.TabIndex = 18
        Me.chk_cuentaDefault.Text = "Establecer como cuenta Default"
        Me.chk_cuentaDefault.UseVisualStyleBackColor = True
        '
        'btn_Banco2
        '
        Me.btn_Banco2.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Banco2.Location = New System.Drawing.Point(597, 12)
        Me.btn_Banco2.Name = "btn_Banco2"
        Me.btn_Banco2.Size = New System.Drawing.Size(26, 23)
        Me.btn_Banco2.TabIndex = 3
        Me.btn_Banco2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Banco2.UseVisualStyleBackColor = True
        '
        'tbx_Banco2
        '
        Me.tbx_Banco2.Control_Siguiente = Nothing
        Me.tbx_Banco2.Filtrado = True
        Me.tbx_Banco2.Location = New System.Drawing.Point(105, 15)
        Me.tbx_Banco2.MaxLength = 4
        Me.tbx_Banco2.Name = "tbx_Banco2"
        Me.tbx_Banco2.Size = New System.Drawing.Size(80, 20)
        Me.tbx_Banco2.TabIndex = 1
        Me.tbx_Banco2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Banco2
        '
        Me.cmb_Banco2.Clave = "Clave"
        Me.cmb_Banco2.Control_Siguiente = Nothing
        Me.cmb_Banco2.DisplayMember = "Nombre_Comercial"
        Me.cmb_Banco2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco2.Empresa = False
        Me.cmb_Banco2.Filtro = Me.tbx_Banco2
        Me.cmb_Banco2.FormattingEnabled = True
        Me.cmb_Banco2.Location = New System.Drawing.Point(191, 14)
        Me.cmb_Banco2.MaxDropDownItems = 20
        Me.cmb_Banco2.Name = "cmb_Banco2"
        Me.cmb_Banco2.Pista = False
        Me.cmb_Banco2.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Banco2.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_Banco2.Sucursal = True
        Me.cmb_Banco2.TabIndex = 2
        Me.cmb_Banco2.Tipo = 0
        Me.cmb_Banco2.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Banco2
        '
        Me.lbl_Banco2.AutoSize = True
        Me.lbl_Banco2.Location = New System.Drawing.Point(26, 18)
        Me.lbl_Banco2.Name = "lbl_Banco2"
        Me.lbl_Banco2.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Banco2.TabIndex = 0
        Me.lbl_Banco2.Text = "Caja Bancaria"
        '
        'lbl_2_Ciudad
        '
        Me.lbl_2_Ciudad.AutoSize = True
        Me.lbl_2_Ciudad.Location = New System.Drawing.Point(59, 125)
        Me.lbl_2_Ciudad.Name = "lbl_2_Ciudad"
        Me.lbl_2_Ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_2_Ciudad.TabIndex = 16
        Me.lbl_2_Ciudad.Text = "Ciudad"
        Me.lbl_2_Ciudad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_2_Estado
        '
        Me.lbl_2_Estado.AutoSize = True
        Me.lbl_2_Estado.Location = New System.Drawing.Point(400, 98)
        Me.lbl_2_Estado.Name = "lbl_2_Estado"
        Me.lbl_2_Estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_2_Estado.TabIndex = 14
        Me.lbl_2_Estado.Text = "Estado"
        Me.lbl_2_Estado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_2_Pais
        '
        Me.lbl_2_Pais.AutoSize = True
        Me.lbl_2_Pais.Location = New System.Drawing.Point(70, 98)
        Me.lbl_2_Pais.Name = "lbl_2_Pais"
        Me.lbl_2_Pais.Size = New System.Drawing.Size(29, 13)
        Me.lbl_2_Pais.TabIndex = 12
        Me.lbl_2_Pais.Text = "País"
        Me.lbl_2_Pais.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_2_Cuenta
        '
        Me.lbl_2_Cuenta.AutoSize = True
        Me.lbl_2_Cuenta.Location = New System.Drawing.Point(399, 71)
        Me.lbl_2_Cuenta.Name = "lbl_2_Cuenta"
        Me.lbl_2_Cuenta.Size = New System.Drawing.Size(41, 13)
        Me.lbl_2_Cuenta.TabIndex = 10
        Me.lbl_2_Cuenta.Text = "Cuenta"
        Me.lbl_2_Cuenta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(53, 71)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 8
        Me.lbl_Moneda.Text = "Moneda"
        Me.lbl_Moneda.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_2_ReferenciaFija
        '
        Me.lbl_2_ReferenciaFija.AutoSize = True
        Me.lbl_2_ReferenciaFija.Location = New System.Drawing.Point(362, 44)
        Me.lbl_2_ReferenciaFija.Name = "lbl_2_ReferenciaFija"
        Me.lbl_2_ReferenciaFija.Size = New System.Drawing.Size(78, 13)
        Me.lbl_2_ReferenciaFija.TabIndex = 6
        Me.lbl_2_ReferenciaFija.Text = "Referencia Fija"
        Me.lbl_2_ReferenciaFija.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_2_Referenciada
        '
        Me.lbl_2_Referenciada.AutoSize = True
        Me.lbl_2_Referenciada.Location = New System.Drawing.Point(19, 44)
        Me.lbl_2_Referenciada.Name = "lbl_2_Referenciada"
        Me.lbl_2_Referenciada.Size = New System.Drawing.Size(80, 13)
        Me.lbl_2_Referenciada.TabIndex = 4
        Me.lbl_2_Referenciada.Text = " Referenciada?"
        Me.lbl_2_Referenciada.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_ReferenciaFija
        '
        Me.cmb_ReferenciaFija.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_ReferenciaFija.DisplayMember = "display"
        Me.cmb_ReferenciaFija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ReferenciaFija.Enabled = False
        Me.cmb_ReferenciaFija.FormattingEnabled = True
        Me.cmb_ReferenciaFija.Location = New System.Drawing.Point(446, 41)
        Me.cmb_ReferenciaFija.MaxDropDownItems = 20
        Me.cmb_ReferenciaFija.Name = "cmb_ReferenciaFija"
        Me.cmb_ReferenciaFija.Size = New System.Drawing.Size(268, 21)
        Me.cmb_ReferenciaFija.TabIndex = 7
        Me.cmb_ReferenciaFija.ValueMember = "value"
        '
        'cmb_Referenciada
        '
        Me.cmb_Referenciada.Control_Siguiente = Me.cmb_ReferenciaFija
        Me.cmb_Referenciada.DisplayMember = "display"
        Me.cmb_Referenciada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Referenciada.FormattingEnabled = True
        Me.cmb_Referenciada.Location = New System.Drawing.Point(105, 41)
        Me.cmb_Referenciada.MaxDropDownItems = 20
        Me.cmb_Referenciada.Name = "cmb_Referenciada"
        Me.cmb_Referenciada.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Referenciada.TabIndex = 5
        Me.cmb_Referenciada.ValueMember = "value"
        '
        'frm_CatalogoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 562)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CatalogoCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Catálogo de Cuentas Bancarias"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Referencias.ResumeLayout(False)
        Me.gbx_Referencias.PerformLayout()
        Me.Gbx_Cuentas.ResumeLayout(False)
        Me.Gbx_Cuentas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents cmb_Banco As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Referencias As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_2_AgregarReferencia As System.Windows.Forms.Button
    Friend WithEvents lsv_2_Referencia As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Referencia As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_2_Referencia As System.Windows.Forms.Label
    Friend WithEvents Gbx_Cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Banco2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Cuenta As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Pais As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Estado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Ciudad As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_2_Ciudad As System.Windows.Forms.Label
    Friend WithEvents lbl_2_Estado As System.Windows.Forms.Label
    Friend WithEvents lbl_2_Pais As System.Windows.Forms.Label
    Friend WithEvents lbl_2_Cuenta As System.Windows.Forms.Label
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents lbl_2_ReferenciaFija As System.Windows.Forms.Label
    Friend WithEvents lbl_2_Referenciada As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ReferenciaFija As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_Referenciada As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Banco As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Banco As System.Windows.Forms.Button
    Friend WithEvents cmb_Banco2 As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Banco2 As System.Windows.Forms.Button
    Friend WithEvents tbx_Banco2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents cbx_Activas As System.Windows.Forms.CheckBox
    Friend WithEvents btn_BajaRef As System.Windows.Forms.Button
    Friend WithEvents btn_BuscarRef As System.Windows.Forms.Button
    Friend WithEvents tbx_BuscarRef As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_buscar1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents chk_cuentaDefault As System.Windows.Forms.CheckBox
    Friend WithEvents btn_EliminaReferencia As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Status As cp_cmb_Manual
End Class
