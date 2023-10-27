<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Kardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Kardex))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.lsv_Caset = New Modulo_Ventas.cp_Listview
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.Tab_Cartuchos = New System.Windows.Forms.TabControl
        Me.tab_Nuevo = New System.Windows.Forms.TabPage
        Me.rdb_NO = New System.Windows.Forms.RadioButton
        Me.lbl_Caset = New System.Windows.Forms.Label
        Me.rdb_Si = New System.Windows.Forms.RadioButton
        Me.lbl_Color = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lbl_Capacidad = New System.Windows.Forms.Label
        Me.lbl_Serie = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_CodigoBarras = New System.Windows.Forms.Label
        Me.cmb_Color = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Capacidad = New Modulo_Ventas.cp_Textbox
        Me.tbx_Serie = New Modulo_Ventas.cp_Textbox
        Me.tbx_CodigoBarra = New Modulo_Ventas.cp_Textbox
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Cartuchos.SuspendLayout()
        Me.tab_Nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Cliente"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Location = New System.Drawing.Point(299, 216)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 23
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(152, 216)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(141, 30)
        Me.btn_Guardar.TabIndex = 22
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.lsv_Caset)
        Me.tab_Listado.Controls.Add(Me.cmb_Status)
        Me.tab_Listado.Controls.Add(Me.lbl_Status)
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = CType(resources.GetObject("BTN_Modificar.Image"), System.Drawing.Image)
        Me.BTN_Modificar.Location = New System.Drawing.Point(151, 497)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 35
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 497)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 34
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = CType(resources.GetObject("BTN_Exportar.Image"), System.Drawing.Image)
        Me.BTN_Exportar.Location = New System.Drawing.Point(297, 497)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 33
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = CType(resources.GetObject("Btn_Baja.Image"), System.Drawing.Image)
        Me.Btn_Baja.Location = New System.Drawing.Point(5, 497)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 32
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'lsv_Caset
        '
        Me.lsv_Caset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Caset.FullRowSelect = True
        Me.lsv_Caset.HideSelection = False
        Me.lsv_Caset.Location = New System.Drawing.Point(3, 68)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Caset.Lvs = ListViewColumnSorter1
        Me.lsv_Caset.MultiSelect = False
        Me.lsv_Caset.Name = "lsv_Caset"
        Me.lsv_Caset.Row1 = 10
        Me.lsv_Caset.Row10 = 0
        Me.lsv_Caset.Row2 = 15
        Me.lsv_Caset.Row3 = 35
        Me.lsv_Caset.Row4 = 10
        Me.lsv_Caset.Row5 = 10
        Me.lsv_Caset.Row6 = 10
        Me.lsv_Caset.Row7 = 15
        Me.lsv_Caset.Row8 = 50
        Me.lsv_Caset.Row9 = 0
        Me.lsv_Caset.Size = New System.Drawing.Size(770, 424)
        Me.lsv_Caset.TabIndex = 31
        Me.lsv_Caset.UseCompatibleStateImageBehavior = False
        Me.lsv_Caset.View = System.Windows.Forms.View.Details
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(54, 17)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Status.TabIndex = 30
        Me.cmb_Status.ValueMember = "value"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 28
        Me.lbl_Status.Text = "Status"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(623, 48)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(135, 15)
        Me.lbl_Registros.TabIndex = 27
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Cartuchos
        '
        Me.Tab_Cartuchos.Controls.Add(Me.tab_Listado)
        Me.Tab_Cartuchos.Controls.Add(Me.tab_Nuevo)
        Me.Tab_Cartuchos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Cartuchos.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Cartuchos.Name = "Tab_Cartuchos"
        Me.Tab_Cartuchos.SelectedIndex = 0
        Me.Tab_Cartuchos.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Cartuchos.TabIndex = 0
        '
        'tab_Nuevo
        '
        Me.tab_Nuevo.Controls.Add(Me.rdb_NO)
        Me.tab_Nuevo.Controls.Add(Me.lbl_Caset)
        Me.tab_Nuevo.Controls.Add(Me.rdb_Si)
        Me.tab_Nuevo.Controls.Add(Me.lbl_Color)
        Me.tab_Nuevo.Controls.Add(Me.Button1)
        Me.tab_Nuevo.Controls.Add(Me.Button2)
        Me.tab_Nuevo.Controls.Add(Me.lbl_Capacidad)
        Me.tab_Nuevo.Controls.Add(Me.lbl_Serie)
        Me.tab_Nuevo.Controls.Add(Me.lbl_Cliente)
        Me.tab_Nuevo.Controls.Add(Me.lbl_CodigoBarras)
        Me.tab_Nuevo.Controls.Add(Me.cmb_Color)
        Me.tab_Nuevo.Controls.Add(Me.cmb_Cliente)
        Me.tab_Nuevo.Controls.Add(Me.tbx_Capacidad)
        Me.tab_Nuevo.Controls.Add(Me.tbx_Serie)
        Me.tab_Nuevo.Controls.Add(Me.tbx_CodigoBarra)
        Me.tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.tab_Nuevo.Name = "tab_Nuevo"
        Me.tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Nuevo.Size = New System.Drawing.Size(776, 535)
        Me.tab_Nuevo.TabIndex = 1
        Me.tab_Nuevo.Text = "Nuevo"
        Me.tab_Nuevo.UseVisualStyleBackColor = True
        '
        'rdb_NO
        '
        Me.rdb_NO.AutoSize = True
        Me.rdb_NO.Location = New System.Drawing.Point(177, 23)
        Me.rdb_NO.Name = "rdb_NO"
        Me.rdb_NO.Size = New System.Drawing.Size(41, 17)
        Me.rdb_NO.TabIndex = 60
        Me.rdb_NO.TabStop = True
        Me.rdb_NO.Text = "NO"
        Me.rdb_NO.UseVisualStyleBackColor = True
        '
        'lbl_Caset
        '
        Me.lbl_Caset.AutoSize = True
        Me.lbl_Caset.Location = New System.Drawing.Point(9, 25)
        Me.lbl_Caset.Name = "lbl_Caset"
        Me.lbl_Caset.Size = New System.Drawing.Size(121, 13)
        Me.lbl_Caset.TabIndex = 59
        Me.lbl_Caset.Text = "Caset Seguridad Interna"
        Me.lbl_Caset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdb_Si
        '
        Me.rdb_Si.AutoSize = True
        Me.rdb_Si.Location = New System.Drawing.Point(136, 23)
        Me.rdb_Si.Name = "rdb_Si"
        Me.rdb_Si.Size = New System.Drawing.Size(35, 17)
        Me.rdb_Si.TabIndex = 58
        Me.rdb_Si.TabStop = True
        Me.rdb_Si.Text = "SI"
        Me.rdb_Si.UseVisualStyleBackColor = True
        '
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Location = New System.Drawing.Point(98, 160)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Color.TabIndex = 55
        Me.lbl_Color.Text = "Color"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(289, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(136, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 30)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "&Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_Capacidad
        '
        Me.lbl_Capacidad.AutoSize = True
        Me.lbl_Capacidad.Location = New System.Drawing.Point(71, 134)
        Me.lbl_Capacidad.Name = "lbl_Capacidad"
        Me.lbl_Capacidad.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Capacidad.TabIndex = 45
        Me.lbl_Capacidad.Text = "Capacidad"
        '
        'lbl_Serie
        '
        Me.lbl_Serie.AutoSize = True
        Me.lbl_Serie.Location = New System.Drawing.Point(98, 106)
        Me.lbl_Serie.Name = "lbl_Serie"
        Me.lbl_Serie.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Serie.TabIndex = 43
        Me.lbl_Serie.Text = "Serie"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(90, 79)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 42
        Me.lbl_Cliente.Text = "Cliente"
        '
        'lbl_CodigoBarras
        '
        Me.lbl_CodigoBarras.AutoSize = True
        Me.lbl_CodigoBarras.Location = New System.Drawing.Point(47, 49)
        Me.lbl_CodigoBarras.Name = "lbl_CodigoBarras"
        Me.lbl_CodigoBarras.Size = New System.Drawing.Size(83, 13)
        Me.lbl_CodigoBarras.TabIndex = 41
        Me.lbl_CodigoBarras.Text = "Codigo de Barra"
        '
        'cmb_Color
        '
        Me.cmb_Color.Clave = Nothing
        Me.cmb_Color.Control_Siguiente = Nothing
        Me.cmb_Color.DisplayMember = "Descripcion"
        Me.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Color.Empresa = False
        Me.cmb_Color.Filtro = Nothing
        Me.cmb_Color.FormattingEnabled = True
        Me.cmb_Color.Location = New System.Drawing.Point(136, 157)
        Me.cmb_Color.MaxDropDownItems = 20
        Me.cmb_Color.Name = "cmb_Color"
        Me.cmb_Color.Pista = False
        Me.cmb_Color.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Color.StoredProcedure = "Kardex_CasetColor_Get"
        Me.cmb_Color.Sucursal = False
        Me.cmb_Color.TabIndex = 56
        Me.cmb_Color.Tipo = 0
        Me.cmb_Color.ValueMember = "Id_Color"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = Nothing
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Nothing
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(135, 76)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 54
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_Capacidad
        '
        Me.tbx_Capacidad.Control_Siguiente = Nothing
        Me.tbx_Capacidad.Filtrado = True
        Me.tbx_Capacidad.Location = New System.Drawing.Point(135, 131)
        Me.tbx_Capacidad.MaxLength = 5
        Me.tbx_Capacidad.Name = "tbx_Capacidad"
        Me.tbx_Capacidad.Size = New System.Drawing.Size(229, 20)
        Me.tbx_Capacidad.TabIndex = 51
        Me.tbx_Capacidad.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Serie
        '
        Me.tbx_Serie.Control_Siguiente = Nothing
        Me.tbx_Serie.Filtrado = True
        Me.tbx_Serie.Location = New System.Drawing.Point(135, 103)
        Me.tbx_Serie.MaxLength = 100
        Me.tbx_Serie.Name = "tbx_Serie"
        Me.tbx_Serie.Size = New System.Drawing.Size(229, 20)
        Me.tbx_Serie.TabIndex = 49
        Me.tbx_Serie.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_CodigoBarra
        '
        Me.tbx_CodigoBarra.Control_Siguiente = Nothing
        Me.tbx_CodigoBarra.Filtrado = True
        Me.tbx_CodigoBarra.Location = New System.Drawing.Point(136, 46)
        Me.tbx_CodigoBarra.MaxLength = 100
        Me.tbx_CodigoBarra.Name = "tbx_CodigoBarra"
        Me.tbx_CodigoBarra.Size = New System.Drawing.Size(229, 20)
        Me.tbx_CodigoBarra.TabIndex = 47
        Me.tbx_CodigoBarra.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Cartuchos)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Kardex"
        Me.Text = "Catalogo Caset"
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Cartuchos.ResumeLayout(False)
        Me.tab_Nuevo.ResumeLayout(False)
        Me.tab_Nuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Caset As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Tab_Cartuchos As System.Windows.Forms.TabControl
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_Capacidad As System.Windows.Forms.Label
    Friend WithEvents lbl_Serie As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_CodigoBarras As System.Windows.Forms.Label
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Capacidad As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Serie As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CodigoBarra As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Color As System.Windows.Forms.Label
    Friend WithEvents cmb_Color As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Caset As System.Windows.Forms.Label
    Friend WithEvents rdb_Si As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_NO As System.Windows.Forms.RadioButton
End Class
