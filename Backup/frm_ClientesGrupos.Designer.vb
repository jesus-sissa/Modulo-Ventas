<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesGrupos
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
        Me.tab_Grupos = New System.Windows.Forms.TabControl
        Me.tp_ClientesxGrupo = New System.Windows.Forms.TabPage
        Me.tlp_ClientesxGrupo = New System.Windows.Forms.TableLayoutPanel
        Me.grb_Botones = New System.Windows.Forms.GroupBox
        Me.btn_EliminarCxG = New System.Windows.Forms.Button
        Me.btn_AgregarCxG = New System.Windows.Forms.Button
        Me.grb_Clientes = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosC = New System.Windows.Forms.Label
        Me.lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.grb_Grupos = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosG = New System.Windows.Forms.Label
        Me.lsv_Grupos = New Modulo_Ventas.cp_Listview
        Me.cmb_Grupos = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tp_Grupos = New System.Windows.Forms.TabPage
        Me.lbl_ClientePadre = New System.Windows.Forms.Label
        Me.btn_CancelarCG = New System.Windows.Forms.Button
        Me.btn_ModificarCG = New System.Windows.Forms.Button
        Me.btn_EliminarCG = New System.Windows.Forms.Button
        Me.Lbl_RegistrosCG = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.btn_GuardarCG = New System.Windows.Forms.Button
        Me.tbx_DescripcionCG = New Modulo_Ventas.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.tab_Grupos.SuspendLayout()
        Me.tp_ClientesxGrupo.SuspendLayout()
        Me.tlp_ClientesxGrupo.SuspendLayout()
        Me.grb_Botones.SuspendLayout()
        Me.grb_Clientes.SuspendLayout()
        Me.grb_Grupos.SuspendLayout()
        Me.tp_Grupos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_Grupos
        '
        Me.tab_Grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Grupos.Controls.Add(Me.tp_ClientesxGrupo)
        Me.tab_Grupos.Controls.Add(Me.tp_Grupos)
        Me.tab_Grupos.Location = New System.Drawing.Point(5, 1)
        Me.tab_Grupos.Name = "tab_Grupos"
        Me.tab_Grupos.SelectedIndex = 0
        Me.tab_Grupos.Size = New System.Drawing.Size(775, 509)
        Me.tab_Grupos.TabIndex = 0
        '
        'tp_ClientesxGrupo
        '
        Me.tp_ClientesxGrupo.Controls.Add(Me.tlp_ClientesxGrupo)
        Me.tp_ClientesxGrupo.Location = New System.Drawing.Point(4, 22)
        Me.tp_ClientesxGrupo.Name = "tp_ClientesxGrupo"
        Me.tp_ClientesxGrupo.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_ClientesxGrupo.Size = New System.Drawing.Size(767, 483)
        Me.tp_ClientesxGrupo.TabIndex = 0
        Me.tp_ClientesxGrupo.Text = "Clientes por Grupo"
        Me.tp_ClientesxGrupo.UseVisualStyleBackColor = True
        '
        'tlp_ClientesxGrupo
        '
        Me.tlp_ClientesxGrupo.ColumnCount = 3
        Me.tlp_ClientesxGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_ClientesxGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlp_ClientesxGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_ClientesxGrupo.Controls.Add(Me.grb_Botones, 0, 0)
        Me.tlp_ClientesxGrupo.Controls.Add(Me.grb_Clientes, 0, 0)
        Me.tlp_ClientesxGrupo.Controls.Add(Me.grb_Grupos, 2, 0)
        Me.tlp_ClientesxGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_ClientesxGrupo.Location = New System.Drawing.Point(3, 3)
        Me.tlp_ClientesxGrupo.Name = "tlp_ClientesxGrupo"
        Me.tlp_ClientesxGrupo.RowCount = 1
        Me.tlp_ClientesxGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_ClientesxGrupo.Size = New System.Drawing.Size(761, 477)
        Me.tlp_ClientesxGrupo.TabIndex = 0
        '
        'grb_Botones
        '
        Me.grb_Botones.Controls.Add(Me.btn_EliminarCxG)
        Me.grb_Botones.Controls.Add(Me.btn_AgregarCxG)
        Me.grb_Botones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_Botones.Location = New System.Drawing.Point(353, 3)
        Me.grb_Botones.Name = "grb_Botones"
        Me.grb_Botones.Size = New System.Drawing.Size(54, 471)
        Me.grb_Botones.TabIndex = 2
        Me.grb_Botones.TabStop = False
        '
        'btn_EliminarCxG
        '
        Me.btn_EliminarCxG.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_EliminarCxG.Image = Global.Modulo_Ventas.My.Resources.Resources.previous
        Me.btn_EliminarCxG.Location = New System.Drawing.Point(8, 250)
        Me.btn_EliminarCxG.Name = "btn_EliminarCxG"
        Me.btn_EliminarCxG.Size = New System.Drawing.Size(40, 30)
        Me.btn_EliminarCxG.TabIndex = 6
        Me.btn_EliminarCxG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarCxG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EliminarCxG.UseVisualStyleBackColor = True
        '
        'btn_AgregarCxG
        '
        Me.btn_AgregarCxG.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_AgregarCxG.Image = Global.Modulo_Ventas.My.Resources.Resources._next
        Me.btn_AgregarCxG.Location = New System.Drawing.Point(8, 180)
        Me.btn_AgregarCxG.Name = "btn_AgregarCxG"
        Me.btn_AgregarCxG.Size = New System.Drawing.Size(40, 30)
        Me.btn_AgregarCxG.TabIndex = 5
        Me.btn_AgregarCxG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarCxG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarCxG.UseVisualStyleBackColor = True
        '
        'grb_Clientes
        '
        Me.grb_Clientes.Controls.Add(Me.lbl_RegistrosC)
        Me.grb_Clientes.Controls.Add(Me.lsv_Clientes)
        Me.grb_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_Clientes.Location = New System.Drawing.Point(3, 3)
        Me.grb_Clientes.Name = "grb_Clientes"
        Me.grb_Clientes.Size = New System.Drawing.Size(344, 471)
        Me.grb_Clientes.TabIndex = 0
        Me.grb_Clientes.TabStop = False
        Me.grb_Clientes.Text = "Clientes"
        '
        'lbl_RegistrosC
        '
        Me.lbl_RegistrosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosC.Location = New System.Drawing.Point(203, 18)
        Me.lbl_RegistrosC.Name = "lbl_RegistrosC"
        Me.lbl_RegistrosC.Size = New System.Drawing.Size(135, 23)
        Me.lbl_RegistrosC.TabIndex = 9
        Me.lbl_RegistrosC.Text = "Registros: 0"
        Me.lbl_RegistrosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.AllowColumnReorder = True
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.CheckBoxes = True
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(6, 44)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 20
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 75
        Me.lsv_Clientes.Row3 = 0
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(332, 421)
        Me.lsv_Clientes.TabIndex = 4
        Me.lsv_Clientes.Tag = "Id_TipoParentesco"
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'grb_Grupos
        '
        Me.grb_Grupos.Controls.Add(Me.lbl_RegistrosG)
        Me.grb_Grupos.Controls.Add(Me.lsv_Grupos)
        Me.grb_Grupos.Controls.Add(Me.cmb_Grupos)
        Me.grb_Grupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_Grupos.Location = New System.Drawing.Point(413, 3)
        Me.grb_Grupos.Name = "grb_Grupos"
        Me.grb_Grupos.Size = New System.Drawing.Size(345, 471)
        Me.grb_Grupos.TabIndex = 1
        Me.grb_Grupos.TabStop = False
        Me.grb_Grupos.Text = "Grupo"
        '
        'lbl_RegistrosG
        '
        Me.lbl_RegistrosG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosG.Location = New System.Drawing.Point(204, 45)
        Me.lbl_RegistrosG.Name = "lbl_RegistrosG"
        Me.lbl_RegistrosG.Size = New System.Drawing.Size(135, 23)
        Me.lbl_RegistrosG.TabIndex = 10
        Me.lbl_RegistrosG.Text = "Registros: 0"
        Me.lbl_RegistrosG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Grupos
        '
        Me.lsv_Grupos.AllowColumnReorder = True
        Me.lsv_Grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Grupos.CheckBoxes = True
        Me.lsv_Grupos.FullRowSelect = True
        Me.lsv_Grupos.HideSelection = False
        Me.lsv_Grupos.Location = New System.Drawing.Point(6, 71)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Grupos.Lvs = ListViewColumnSorter2
        Me.lsv_Grupos.MultiSelect = False
        Me.lsv_Grupos.Name = "lsv_Grupos"
        Me.lsv_Grupos.Row1 = 20
        Me.lsv_Grupos.Row10 = 0
        Me.lsv_Grupos.Row2 = 75
        Me.lsv_Grupos.Row3 = 0
        Me.lsv_Grupos.Row4 = 0
        Me.lsv_Grupos.Row5 = 0
        Me.lsv_Grupos.Row6 = 0
        Me.lsv_Grupos.Row7 = 0
        Me.lsv_Grupos.Row8 = 0
        Me.lsv_Grupos.Row9 = 0
        Me.lsv_Grupos.Size = New System.Drawing.Size(333, 394)
        Me.lsv_Grupos.TabIndex = 5
        Me.lsv_Grupos.Tag = "Id_TipoParentesco"
        Me.lsv_Grupos.UseCompatibleStateImageBehavior = False
        Me.lsv_Grupos.View = System.Windows.Forms.View.Details
        '
        'cmb_Grupos
        '
        Me.cmb_Grupos.Clave = Nothing
        Me.cmb_Grupos.Control_Siguiente = Nothing
        Me.cmb_Grupos.DisplayMember = "descripcion"
        Me.cmb_Grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grupos.Empresa = False
        Me.cmb_Grupos.Filtro = Nothing
        Me.cmb_Grupos.FormattingEnabled = True
        Me.cmb_Grupos.Location = New System.Drawing.Point(6, 18)
        Me.cmb_Grupos.MaxDropDownItems = 20
        Me.cmb_Grupos.Name = "cmb_Grupos"
        Me.cmb_Grupos.Pista = False
        Me.cmb_Grupos.Size = New System.Drawing.Size(300, 21)
        Me.cmb_Grupos.StoredProcedure = "Cat_ClientesGrupos_Get"
        Me.cmb_Grupos.Sucursal = True
        Me.cmb_Grupos.TabIndex = 0
        Me.cmb_Grupos.Tipo = 0
        Me.cmb_Grupos.ValueMember = "Id_ClienteGrupo"
        '
        'tp_Grupos
        '
        Me.tp_Grupos.Controls.Add(Me.lbl_ClientePadre)
        Me.tp_Grupos.Controls.Add(Me.btn_CancelarCG)
        Me.tp_Grupos.Controls.Add(Me.btn_ModificarCG)
        Me.tp_Grupos.Controls.Add(Me.btn_EliminarCG)
        Me.tp_Grupos.Controls.Add(Me.Lbl_RegistrosCG)
        Me.tp_Grupos.Controls.Add(Me.lsv_Catalogo)
        Me.tp_Grupos.Controls.Add(Me.btn_GuardarCG)
        Me.tp_Grupos.Controls.Add(Me.tbx_DescripcionCG)
        Me.tp_Grupos.Location = New System.Drawing.Point(4, 22)
        Me.tp_Grupos.Name = "tp_Grupos"
        Me.tp_Grupos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Grupos.Size = New System.Drawing.Size(767, 476)
        Me.tp_Grupos.TabIndex = 1
        Me.tp_Grupos.Text = "Catálogo de Grupos"
        Me.tp_Grupos.UseVisualStyleBackColor = True
        '
        'lbl_ClientePadre
        '
        Me.lbl_ClientePadre.AutoSize = True
        Me.lbl_ClientePadre.Location = New System.Drawing.Point(7, 24)
        Me.lbl_ClientePadre.Name = "lbl_ClientePadre"
        Me.lbl_ClientePadre.Size = New System.Drawing.Size(63, 13)
        Me.lbl_ClientePadre.TabIndex = 14
        Me.lbl_ClientePadre.Text = "Descripción"
        '
        'btn_CancelarCG
        '
        Me.btn_CancelarCG.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_CancelarCG.Location = New System.Drawing.Point(478, 15)
        Me.btn_CancelarCG.Name = "btn_CancelarCG"
        Me.btn_CancelarCG.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarCG.TabIndex = 13
        Me.btn_CancelarCG.Text = "&Cancelar"
        Me.btn_CancelarCG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarCG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarCG.UseVisualStyleBackColor = True
        '
        'btn_ModificarCG
        '
        Me.btn_ModificarCG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ModificarCG.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_ModificarCG.Location = New System.Drawing.Point(10, 440)
        Me.btn_ModificarCG.Name = "btn_ModificarCG"
        Me.btn_ModificarCG.Size = New System.Drawing.Size(140, 30)
        Me.btn_ModificarCG.TabIndex = 12
        Me.btn_ModificarCG.Text = "&Modificar"
        Me.btn_ModificarCG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ModificarCG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ModificarCG.UseVisualStyleBackColor = True
        '
        'btn_EliminarCG
        '
        Me.btn_EliminarCG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_EliminarCG.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.btn_EliminarCG.Location = New System.Drawing.Point(156, 440)
        Me.btn_EliminarCG.Name = "btn_EliminarCG"
        Me.btn_EliminarCG.Size = New System.Drawing.Size(140, 30)
        Me.btn_EliminarCG.TabIndex = 11
        Me.btn_EliminarCG.Text = "&Eliminar"
        Me.btn_EliminarCG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarCG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EliminarCG.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosCG
        '
        Me.Lbl_RegistrosCG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosCG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosCG.Location = New System.Drawing.Point(624, 25)
        Me.Lbl_RegistrosCG.Name = "Lbl_RegistrosCG"
        Me.Lbl_RegistrosCG.Size = New System.Drawing.Size(135, 23)
        Me.Lbl_RegistrosCG.TabIndex = 10
        Me.Lbl_RegistrosCG.Text = "Registros: 0"
        Me.Lbl_RegistrosCG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(10, 51)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter3
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 80
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 0
        Me.lsv_Catalogo.Row3 = 0
        Me.lsv_Catalogo.Row4 = 0
        Me.lsv_Catalogo.Row5 = 0
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(749, 383)
        Me.lsv_Catalogo.TabIndex = 9
        Me.lsv_Catalogo.Tag = "Id_TipoParentesco"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'btn_GuardarCG
        '
        Me.btn_GuardarCG.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_GuardarCG.Location = New System.Drawing.Point(332, 15)
        Me.btn_GuardarCG.Name = "btn_GuardarCG"
        Me.btn_GuardarCG.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarCG.TabIndex = 5
        Me.btn_GuardarCG.Text = "&Guardar"
        Me.btn_GuardarCG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarCG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarCG.UseVisualStyleBackColor = True
        '
        'tbx_DescripcionCG
        '
        Me.tbx_DescripcionCG.Control_Siguiente = Me.btn_GuardarCG
        Me.tbx_DescripcionCG.Filtrado = True
        Me.tbx_DescripcionCG.Location = New System.Drawing.Point(76, 21)
        Me.tbx_DescripcionCG.MaxLength = 50
        Me.tbx_DescripcionCG.Name = "tbx_DescripcionCG"
        Me.tbx_DescripcionCG.Size = New System.Drawing.Size(250, 20)
        Me.tbx_DescripcionCG.TabIndex = 0
        Me.tbx_DescripcionCG.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 509)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(775, 50)
        Me.gbx_Botones.TabIndex = 9
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_ClientesGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.tab_Grupos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ClientesGrupos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos de Clientes"
        Me.tab_Grupos.ResumeLayout(False)
        Me.tp_ClientesxGrupo.ResumeLayout(False)
        Me.tlp_ClientesxGrupo.ResumeLayout(False)
        Me.grb_Botones.ResumeLayout(False)
        Me.grb_Clientes.ResumeLayout(False)
        Me.grb_Grupos.ResumeLayout(False)
        Me.tp_Grupos.ResumeLayout(False)
        Me.tp_Grupos.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_Grupos As System.Windows.Forms.TabControl
    Friend WithEvents tp_ClientesxGrupo As System.Windows.Forms.TabPage
    Friend WithEvents tp_Grupos As System.Windows.Forms.TabPage
    Friend WithEvents tlp_ClientesxGrupo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grb_Clientes As System.Windows.Forms.GroupBox
    Friend WithEvents grb_Grupos As System.Windows.Forms.GroupBox
    Friend WithEvents grb_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_AgregarCxG As System.Windows.Forms.Button
    Friend WithEvents btn_EliminarCxG As System.Windows.Forms.Button
    Friend WithEvents lbl_RegistrosC As System.Windows.Forms.Label
    Friend WithEvents lsv_Grupos As Modulo_Ventas.cp_Listview
    Friend WithEvents cmb_Grupos As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_RegistrosG As System.Windows.Forms.Label
    Friend WithEvents tbx_DescripcionCG As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_GuardarCG As System.Windows.Forms.Button
    Friend WithEvents Lbl_RegistrosCG As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_EliminarCG As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_ModificarCG As System.Windows.Forms.Button
    Friend WithEvents btn_CancelarCG As System.Windows.Forms.Button
    Friend WithEvents lbl_ClientePadre As System.Windows.Forms.Label
End Class
