<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GruposFacturacion
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
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Clientes = New System.Windows.Forms.TabPage
        Me.gbx_Conceptos = New System.Windows.Forms.GroupBox
        Me.Btn_AgregarConcepto = New System.Windows.Forms.Button
        Me.cmb_Concepto = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lbl_AgregarConcepto = New System.Windows.Forms.Label
        Me.lsv_Conceptos = New Modulo_Ventas.cp_Listview
        Me.gbx_ClientesDG = New System.Windows.Forms.GroupBox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.btn_Desasignar = New System.Windows.Forms.Button
        Me.lsv_ClientesDG = New Modulo_Ventas.cp_Listview
        Me.gbx_Grupos = New System.Windows.Forms.GroupBox
        Me.lsv_Grupos = New Modulo_Ventas.cp_Listview
        Me.gbx_ClientesSG = New System.Windows.Forms.GroupBox
        Me.chk_TodosSG = New System.Windows.Forms.CheckBox
        Me.Btn_Asignar = New System.Windows.Forms.Button
        Me.lsv_ClientesSG = New Modulo_Ventas.cp_Listview
        Me.Tab_Grupos = New System.Windows.Forms.TabPage
        Me.tbx_Grupo = New Modulo_Ventas.cp_Textbox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lsv_Grupos2 = New Modulo_Ventas.cp_Listview
        Me.lbl_Grupo = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_CajaBancaria = New System.Windows.Forms.GroupBox
        Me.cmb_CajaBancaria = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.btn_BuscarCajaBancaria = New System.Windows.Forms.Button
        Me.tbx_CajaBancaria = New Modulo_Ventas.cp_Textbox
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Banco = New System.Windows.Forms.Label
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Clientes.SuspendLayout()
        Me.gbx_Conceptos.SuspendLayout()
        Me.gbx_ClientesDG.SuspendLayout()
        Me.gbx_Grupos.SuspendLayout()
        Me.gbx_ClientesSG.SuspendLayout()
        Me.Tab_Grupos.SuspendLayout()
        Me.gbx_CajaBancaria.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Catalogo.Controls.Add(Me.tab_Clientes)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Grupos)
        Me.Tab_Catalogo.Location = New System.Drawing.Point(3, 55)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(779, 509)
        Me.Tab_Catalogo.TabIndex = 1
        '
        'tab_Clientes
        '
        Me.tab_Clientes.Controls.Add(Me.gbx_Conceptos)
        Me.tab_Clientes.Controls.Add(Me.gbx_ClientesDG)
        Me.tab_Clientes.Controls.Add(Me.gbx_Grupos)
        Me.tab_Clientes.Controls.Add(Me.gbx_ClientesSG)
        Me.tab_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.tab_Clientes.Name = "tab_Clientes"
        Me.tab_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Clientes.Size = New System.Drawing.Size(771, 483)
        Me.tab_Clientes.TabIndex = 0
        Me.tab_Clientes.Text = "Clientes por Grupos"
        Me.tab_Clientes.UseVisualStyleBackColor = True
        '
        'gbx_Conceptos
        '
        Me.gbx_Conceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Conceptos.Controls.Add(Me.Btn_AgregarConcepto)
        Me.gbx_Conceptos.Controls.Add(Me.cmb_Concepto)
        Me.gbx_Conceptos.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Conceptos.Controls.Add(Me.lbl_AgregarConcepto)
        Me.gbx_Conceptos.Controls.Add(Me.lsv_Conceptos)
        Me.gbx_Conceptos.Location = New System.Drawing.Point(371, 256)
        Me.gbx_Conceptos.Name = "gbx_Conceptos"
        Me.gbx_Conceptos.Size = New System.Drawing.Size(394, 221)
        Me.gbx_Conceptos.TabIndex = 3
        Me.gbx_Conceptos.TabStop = False
        Me.gbx_Conceptos.Text = "Conceptos de Facturación"
        '
        'Btn_AgregarConcepto
        '
        Me.Btn_AgregarConcepto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AgregarConcepto.Enabled = False
        Me.Btn_AgregarConcepto.Location = New System.Drawing.Point(308, 192)
        Me.Btn_AgregarConcepto.Name = "Btn_AgregarConcepto"
        Me.Btn_AgregarConcepto.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AgregarConcepto.TabIndex = 3
        Me.Btn_AgregarConcepto.Text = "A&gregar"
        Me.Btn_AgregarConcepto.UseVisualStyleBackColor = True
        '
        'cmb_Concepto
        '
        Me.cmb_Concepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Concepto.Clave = Nothing
        Me.cmb_Concepto.Control_Siguiente = Me.Btn_AgregarConcepto
        Me.cmb_Concepto.DisplayMember = "Descripcion"
        Me.cmb_Concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Concepto.Empresa = False
        Me.cmb_Concepto.Filtro = Nothing
        Me.cmb_Concepto.FormattingEnabled = True
        Me.cmb_Concepto.Location = New System.Drawing.Point(147, 194)
        Me.cmb_Concepto.MaxDropDownItems = 20
        Me.cmb_Concepto.Name = "cmb_Concepto"
        Me.cmb_Concepto.Pista = False
        Me.cmb_Concepto.Size = New System.Drawing.Size(155, 21)
        Me.cmb_Concepto.StoredProcedure = "Cat_ConceptosFproceso_Get"
        Me.cmb_Concepto.Sucursal = False
        Me.cmb_Concepto.TabIndex = 2
        Me.cmb_Concepto.Tipo = 0
        Me.cmb_Concepto.ValueMember = "Id_Concepto"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(7, 192)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 0
        Me.btn_Eliminar.Text = "E&liminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_AgregarConcepto
        '
        Me.lbl_AgregarConcepto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_AgregarConcepto.AutoSize = True
        Me.lbl_AgregarConcepto.Location = New System.Drawing.Point(88, 196)
        Me.lbl_AgregarConcepto.Name = "lbl_AgregarConcepto"
        Me.lbl_AgregarConcepto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_AgregarConcepto.TabIndex = 1
        Me.lbl_AgregarConcepto.Text = "Concepto"
        '
        'lsv_Conceptos
        '
        Me.lsv_Conceptos.AllowColumnReorder = True
        Me.lsv_Conceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Conceptos.FullRowSelect = True
        Me.lsv_Conceptos.HideSelection = False
        Me.lsv_Conceptos.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Conceptos.Lvs = ListViewColumnSorter1
        Me.lsv_Conceptos.MultiSelect = False
        Me.lsv_Conceptos.Name = "lsv_Conceptos"
        Me.lsv_Conceptos.Row1 = 50
        Me.lsv_Conceptos.Row10 = 0
        Me.lsv_Conceptos.Row2 = 35
        Me.lsv_Conceptos.Row3 = 12
        Me.lsv_Conceptos.Row4 = 0
        Me.lsv_Conceptos.Row5 = 0
        Me.lsv_Conceptos.Row6 = 0
        Me.lsv_Conceptos.Row7 = 0
        Me.lsv_Conceptos.Row8 = 0
        Me.lsv_Conceptos.Row9 = 0
        Me.lsv_Conceptos.Size = New System.Drawing.Size(382, 165)
        Me.lsv_Conceptos.TabIndex = 0
        Me.lsv_Conceptos.UseCompatibleStateImageBehavior = False
        Me.lsv_Conceptos.View = System.Windows.Forms.View.Details
        '
        'gbx_ClientesDG
        '
        Me.gbx_ClientesDG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_ClientesDG.Controls.Add(Me.chk_Todos)
        Me.gbx_ClientesDG.Controls.Add(Me.btn_Desasignar)
        Me.gbx_ClientesDG.Controls.Add(Me.lsv_ClientesDG)
        Me.gbx_ClientesDG.Location = New System.Drawing.Point(6, 256)
        Me.gbx_ClientesDG.Name = "gbx_ClientesDG"
        Me.gbx_ClientesDG.Size = New System.Drawing.Size(359, 221)
        Me.gbx_ClientesDG.TabIndex = 2
        Me.gbx_ClientesDG.TabStop = False
        Me.gbx_ClientesDG.Text = "Clientes del Grupo: 0"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(8, 19)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(115, 17)
        Me.chk_Todos.TabIndex = 3
        Me.chk_Todos.Text = "Seleccionar Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'btn_Desasignar
        '
        Me.btn_Desasignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Desasignar.Enabled = False
        Me.btn_Desasignar.Location = New System.Drawing.Point(6, 190)
        Me.btn_Desasignar.Name = "btn_Desasignar"
        Me.btn_Desasignar.Size = New System.Drawing.Size(133, 24)
        Me.btn_Desasignar.TabIndex = 1
        Me.btn_Desasignar.Text = "&Eliminar Cliente de Grupo"
        Me.btn_Desasignar.UseVisualStyleBackColor = True
        '
        'lsv_ClientesDG
        '
        Me.lsv_ClientesDG.AllowColumnReorder = True
        Me.lsv_ClientesDG.AllowDrop = True
        Me.lsv_ClientesDG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ClientesDG.CheckBoxes = True
        Me.lsv_ClientesDG.FullRowSelect = True
        Me.lsv_ClientesDG.HideSelection = False
        Me.lsv_ClientesDG.Location = New System.Drawing.Point(6, 39)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ClientesDG.Lvs = ListViewColumnSorter2
        Me.lsv_ClientesDG.MultiSelect = False
        Me.lsv_ClientesDG.Name = "lsv_ClientesDG"
        Me.lsv_ClientesDG.Row1 = 25
        Me.lsv_ClientesDG.Row10 = 0
        Me.lsv_ClientesDG.Row2 = 50
        Me.lsv_ClientesDG.Row3 = 20
        Me.lsv_ClientesDG.Row4 = 0
        Me.lsv_ClientesDG.Row5 = 0
        Me.lsv_ClientesDG.Row6 = 0
        Me.lsv_ClientesDG.Row7 = 0
        Me.lsv_ClientesDG.Row8 = 0
        Me.lsv_ClientesDG.Row9 = 0
        Me.lsv_ClientesDG.Size = New System.Drawing.Size(347, 145)
        Me.lsv_ClientesDG.TabIndex = 0
        Me.lsv_ClientesDG.UseCompatibleStateImageBehavior = False
        Me.lsv_ClientesDG.View = System.Windows.Forms.View.Details
        '
        'gbx_Grupos
        '
        Me.gbx_Grupos.Controls.Add(Me.lsv_Grupos)
        Me.gbx_Grupos.Location = New System.Drawing.Point(6, 6)
        Me.gbx_Grupos.Name = "gbx_Grupos"
        Me.gbx_Grupos.Size = New System.Drawing.Size(359, 244)
        Me.gbx_Grupos.TabIndex = 0
        Me.gbx_Grupos.TabStop = False
        Me.gbx_Grupos.Text = "Grupos"
        '
        'lsv_Grupos
        '
        Me.lsv_Grupos.AllowColumnReorder = True
        Me.lsv_Grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Grupos.FullRowSelect = True
        Me.lsv_Grupos.HideSelection = False
        Me.lsv_Grupos.Location = New System.Drawing.Point(3, 19)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Grupos.Lvs = ListViewColumnSorter3
        Me.lsv_Grupos.MultiSelect = False
        Me.lsv_Grupos.Name = "lsv_Grupos"
        Me.lsv_Grupos.Row1 = 70
        Me.lsv_Grupos.Row10 = 10
        Me.lsv_Grupos.Row2 = 20
        Me.lsv_Grupos.Row3 = 10
        Me.lsv_Grupos.Row4 = 10
        Me.lsv_Grupos.Row5 = 10
        Me.lsv_Grupos.Row6 = 10
        Me.lsv_Grupos.Row7 = 10
        Me.lsv_Grupos.Row8 = 10
        Me.lsv_Grupos.Row9 = 10
        Me.lsv_Grupos.Size = New System.Drawing.Size(353, 222)
        Me.lsv_Grupos.TabIndex = 0
        Me.lsv_Grupos.UseCompatibleStateImageBehavior = False
        Me.lsv_Grupos.View = System.Windows.Forms.View.Details
        '
        'gbx_ClientesSG
        '
        Me.gbx_ClientesSG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ClientesSG.Controls.Add(Me.chk_TodosSG)
        Me.gbx_ClientesSG.Controls.Add(Me.Btn_Asignar)
        Me.gbx_ClientesSG.Controls.Add(Me.lsv_ClientesSG)
        Me.gbx_ClientesSG.Location = New System.Drawing.Point(371, 6)
        Me.gbx_ClientesSG.Name = "gbx_ClientesSG"
        Me.gbx_ClientesSG.Size = New System.Drawing.Size(392, 244)
        Me.gbx_ClientesSG.TabIndex = 1
        Me.gbx_ClientesSG.TabStop = False
        Me.gbx_ClientesSG.Text = "Clientes sin Grupo: 0"
        '
        'chk_TodosSG
        '
        Me.chk_TodosSG.AutoSize = True
        Me.chk_TodosSG.Location = New System.Drawing.Point(8, 21)
        Me.chk_TodosSG.Name = "chk_TodosSG"
        Me.chk_TodosSG.Size = New System.Drawing.Size(115, 17)
        Me.chk_TodosSG.TabIndex = 2
        Me.chk_TodosSG.Text = "Seleccionar Todos"
        Me.chk_TodosSG.UseVisualStyleBackColor = True
        '
        'Btn_Asignar
        '
        Me.Btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Asignar.Enabled = False
        Me.Btn_Asignar.Location = New System.Drawing.Point(6, 214)
        Me.Btn_Asignar.Name = "Btn_Asignar"
        Me.Btn_Asignar.Size = New System.Drawing.Size(129, 24)
        Me.Btn_Asignar.TabIndex = 1
        Me.Btn_Asignar.Text = "&Agregar Cliente a Grupo"
        Me.Btn_Asignar.UseVisualStyleBackColor = False
        '
        'lsv_ClientesSG
        '
        Me.lsv_ClientesSG.AllowColumnReorder = True
        Me.lsv_ClientesSG.AllowDrop = True
        Me.lsv_ClientesSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ClientesSG.CheckBoxes = True
        Me.lsv_ClientesSG.FullRowSelect = True
        Me.lsv_ClientesSG.HideSelection = False
        Me.lsv_ClientesSG.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_ClientesSG.Lvs = ListViewColumnSorter4
        Me.lsv_ClientesSG.MultiSelect = False
        Me.lsv_ClientesSG.Name = "lsv_ClientesSG"
        Me.lsv_ClientesSG.Row1 = 25
        Me.lsv_ClientesSG.Row10 = 0
        Me.lsv_ClientesSG.Row2 = 50
        Me.lsv_ClientesSG.Row3 = 20
        Me.lsv_ClientesSG.Row4 = 0
        Me.lsv_ClientesSG.Row5 = 0
        Me.lsv_ClientesSG.Row6 = 0
        Me.lsv_ClientesSG.Row7 = 0
        Me.lsv_ClientesSG.Row8 = 0
        Me.lsv_ClientesSG.Row9 = 0
        Me.lsv_ClientesSG.Size = New System.Drawing.Size(380, 168)
        Me.lsv_ClientesSG.TabIndex = 0
        Me.lsv_ClientesSG.UseCompatibleStateImageBehavior = False
        Me.lsv_ClientesSG.View = System.Windows.Forms.View.Details
        '
        'Tab_Grupos
        '
        Me.Tab_Grupos.Controls.Add(Me.tbx_Grupo)
        Me.Tab_Grupos.Controls.Add(Me.lsv_Grupos2)
        Me.Tab_Grupos.Controls.Add(Me.lbl_Grupo)
        Me.Tab_Grupos.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Grupos.Controls.Add(Me.btn_Guardar)
        Me.Tab_Grupos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Grupos.Name = "Tab_Grupos"
        Me.Tab_Grupos.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Grupos.Size = New System.Drawing.Size(771, 483)
        Me.Tab_Grupos.TabIndex = 1
        Me.Tab_Grupos.Text = "Grupos"
        Me.Tab_Grupos.UseVisualStyleBackColor = True
        '
        'tbx_Grupo
        '
        Me.tbx_Grupo.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Grupo.Filtrado = True
        Me.tbx_Grupo.Location = New System.Drawing.Point(54, 6)
        Me.tbx_Grupo.MaxLength = 50
        Me.tbx_Grupo.Name = "tbx_Grupo"
        Me.tbx_Grupo.Size = New System.Drawing.Size(286, 20)
        Me.tbx_Grupo.TabIndex = 67
        Me.tbx_Grupo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(54, 33)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 4
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lsv_Grupos2
        '
        Me.lsv_Grupos2.AllowColumnReorder = True
        Me.lsv_Grupos2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Grupos2.FullRowSelect = True
        Me.lsv_Grupos2.HideSelection = False
        Me.lsv_Grupos2.Location = New System.Drawing.Point(6, 69)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Grupos2.Lvs = ListViewColumnSorter5
        Me.lsv_Grupos2.MultiSelect = False
        Me.lsv_Grupos2.Name = "lsv_Grupos2"
        Me.lsv_Grupos2.Row1 = 70
        Me.lsv_Grupos2.Row10 = 0
        Me.lsv_Grupos2.Row2 = 20
        Me.lsv_Grupos2.Row3 = 10
        Me.lsv_Grupos2.Row4 = 0
        Me.lsv_Grupos2.Row5 = 0
        Me.lsv_Grupos2.Row6 = 0
        Me.lsv_Grupos2.Row7 = 0
        Me.lsv_Grupos2.Row8 = 0
        Me.lsv_Grupos2.Row9 = 0
        Me.lsv_Grupos2.Size = New System.Drawing.Size(757, 410)
        Me.lsv_Grupos2.TabIndex = 66
        Me.lsv_Grupos2.UseCompatibleStateImageBehavior = False
        Me.lsv_Grupos2.View = System.Windows.Forms.View.Details
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Grupo.TabIndex = 65
        Me.lbl_Grupo.Text = "Grupo"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(200, 32)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'gbx_CajaBancaria
        '
        Me.gbx_CajaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CajaBancaria.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_CajaBancaria.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_CajaBancaria.Controls.Add(Me.tbx_CajaBancaria)
        Me.gbx_CajaBancaria.Controls.Add(Me.lbl_Banco)
        Me.gbx_CajaBancaria.Controls.Add(Me.btn_BuscarCajaBancaria)
        Me.gbx_CajaBancaria.Location = New System.Drawing.Point(3, 5)
        Me.gbx_CajaBancaria.Name = "gbx_CajaBancaria"
        Me.gbx_CajaBancaria.Size = New System.Drawing.Size(779, 44)
        Me.gbx_CajaBancaria.TabIndex = 0
        Me.gbx_CajaBancaria.TabStop = False
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Banco"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.btn_BuscarCajaBancaria
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Me.tbx_CajaBancaria
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(91, 15)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(264, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'btn_BuscarCajaBancaria
        '
        Me.btn_BuscarCajaBancaria.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCajaBancaria.Location = New System.Drawing.Point(361, 15)
        Me.btn_BuscarCajaBancaria.Name = "btn_BuscarCajaBancaria"
        Me.btn_BuscarCajaBancaria.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCajaBancaria.TabIndex = 2
        Me.btn_BuscarCajaBancaria.UseVisualStyleBackColor = True
        '
        'tbx_CajaBancaria
        '
        Me.tbx_CajaBancaria.Control_Siguiente = Nothing
        Me.tbx_CajaBancaria.Enabled = False
        Me.tbx_CajaBancaria.Filtrado = True
        Me.tbx_CajaBancaria.Location = New System.Drawing.Point(444, 17)
        Me.tbx_CajaBancaria.MaxLength = 50
        Me.tbx_CajaBancaria.Name = "tbx_CajaBancaria"
        Me.tbx_CajaBancaria.Size = New System.Drawing.Size(242, 20)
        Me.tbx_CajaBancaria.TabIndex = 4
        Me.tbx_CajaBancaria.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(15, 20)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(400, 19)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco.TabIndex = 3
        Me.lbl_Banco.Text = "Banco"
        '
        'frm_GruposFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Controls.Add(Me.gbx_CajaBancaria)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_GruposFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos de Facturación a Bancos"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Clientes.ResumeLayout(False)
        Me.gbx_Conceptos.ResumeLayout(False)
        Me.gbx_Conceptos.PerformLayout()
        Me.gbx_ClientesDG.ResumeLayout(False)
        Me.gbx_ClientesDG.PerformLayout()
        Me.gbx_Grupos.ResumeLayout(False)
        Me.gbx_ClientesSG.ResumeLayout(False)
        Me.gbx_ClientesSG.PerformLayout()
        Me.Tab_Grupos.ResumeLayout(False)
        Me.Tab_Grupos.PerformLayout()
        Me.gbx_CajaBancaria.ResumeLayout(False)
        Me.gbx_CajaBancaria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Clientes As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Grupos As System.Windows.Forms.TabPage
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Grupo As System.Windows.Forms.Label
    Friend WithEvents lsv_Grupos2 As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Grupos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_ClientesSG As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_ClientesDG As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Conceptos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Grupos As Modulo_Ventas.cp_Listview
    Friend WithEvents lsv_ClientesSG As Modulo_Ventas.cp_Listview
    Friend WithEvents lsv_ClientesDG As Modulo_Ventas.cp_Listview
    Friend WithEvents lsv_Conceptos As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_CajaBancaria As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_CajaBancaria As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarCajaBancaria As System.Windows.Forms.Button
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents Btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents lbl_AgregarConcepto As System.Windows.Forms.Label
    Friend WithEvents Btn_AgregarConcepto As System.Windows.Forms.Button
    Friend WithEvents cmb_Concepto As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CajaBancaria As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Grupo As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Desasignar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents chk_TodosSG As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
End Class
