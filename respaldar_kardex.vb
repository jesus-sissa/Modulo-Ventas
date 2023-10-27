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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.lbl_Capacidad = New System.Windows.Forms.Label
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.lbl_Serie = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label
        Me.lbl_CodigoCaset = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.lsv_Caset = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.Tab_Cartuchos = New System.Windows.Forms.TabControl
        Me.tab_Nuevo = New System.Windows.Forms.TabPage
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.tbx_Capacidad = New Modulo_Ventas.cp_Textbox
        Me.tbx_Descripcion = New Modulo_Ventas.cp_Textbox
        Me.tbx_Serie = New Modulo_Ventas.cp_Textbox
        Me.tbx_CodigoBarra = New Modulo_Ventas.cp_Textbox
        Me.tbx_CodigoCaset = New Modulo_Ventas.cp_Textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Cartuchos.SuspendLayout()
        Me.tab_Nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Capacidad
        '
        Me.lbl_Capacidad.AutoSize = True
        Me.lbl_Capacidad.Location = New System.Drawing.Point(88, 179)
        Me.lbl_Capacidad.Name = "lbl_Capacidad"
        Me.lbl_Capacidad.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Capacidad.TabIndex = 39
        Me.lbl_Capacidad.Text = "Capacidad"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(83, 153)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 38
        Me.lbl_Descripcion.Text = "Descripcion"
        '
        'lbl_Serie
        '
        Me.lbl_Serie.AutoSize = True
        Me.lbl_Serie.Location = New System.Drawing.Point(115, 127)
        Me.lbl_Serie.Name = "lbl_Serie"
        Me.lbl_Serie.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Serie.TabIndex = 37
        Me.lbl_Serie.Text = "Serie"
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
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(63, 74)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(83, 13)
        Me.lbl_CodigoBarra.TabIndex = 34
        Me.lbl_CodigoBarra.Text = "Codigo de Barra"
        '
        'lbl_CodigoCaset
        '
        Me.lbl_CodigoCaset.AutoSize = True
        Me.lbl_CodigoCaset.Location = New System.Drawing.Point(61, 48)
        Me.lbl_CodigoCaset.Name = "lbl_CodigoCaset"
        Me.lbl_CodigoCaset.Size = New System.Drawing.Size(85, 13)
        Me.lbl_CodigoCaset.TabIndex = 33
        Me.lbl_CodigoCaset.Text = "Codigo de Caset"
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
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.cmb_Status)
        Me.tab_Listado.Controls.Add(Me.lbl_Status)
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.lbl_Buscar)
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
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Caset.Lvs = ListViewColumnSorter2
        Me.lsv_Caset.MultiSelect = False
        Me.lsv_Caset.Name = "lsv_Caset"
        Me.lsv_Caset.Row1 = 10
        Me.lsv_Caset.Row10 = 10
        Me.lsv_Caset.Row2 = 10
        Me.lsv_Caset.Row3 = 10
        Me.lsv_Caset.Row4 = 10
        Me.lsv_Caset.Row5 = 10
        Me.lsv_Caset.Row6 = 10
        Me.lsv_Caset.Row7 = 10
        Me.lsv_Caset.Row8 = 10
        Me.lsv_Caset.Row9 = 10
        Me.lsv_Caset.Size = New System.Drawing.Size(770, 424)
        Me.lsv_Caset.TabIndex = 31
        Me.lsv_Caset.UseCompatibleStateImageBehavior = False
        Me.lsv_Caset.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = True
        Me.tbx_Buscar.Location = New System.Drawing.Point(54, 11)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(623, 20)
        Me.tbx_Buscar.TabIndex = 29
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(54, 41)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Status.TabIndex = 30
        Me.cmb_Status.ValueMember = "value"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(12, 44)
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
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = CType(resources.GetObject("BTN_Buscar.Image"), System.Drawing.Image)
        Me.BTN_Buscar.Location = New System.Drawing.Point(683, 9)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 26
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(8, 14)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 20
        Me.lbl_Buscar.Text = "Buscar"
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
        Me.tab_Nuevo.Controls.Add(Me.cmb_Cliente)
        Me.tab_Nuevo.Controls.Add(Me.Button1)
        Me.tab_Nuevo.Controls.Add(Me.Button2)
        Me.tab_Nuevo.Controls.Add(Me.tbx_Capacidad)
        Me.tab_Nuevo.Controls.Add(Me.tbx_Descripcion)
        Me.tab_Nuevo.Controls.Add(Me.tbx_Serie)
        Me.tab_Nuevo.Controls.Add(Me.tbx_CodigoBarra)
        Me.tab_Nuevo.Controls.Add(Me.tbx_CodigoCaset)
        Me.tab_Nuevo.Controls.Add(Me.Label1)
        Me.tab_Nuevo.Controls.Add(Me.Label2)
        Me.tab_Nuevo.Controls.Add(Me.Label4)
        Me.tab_Nuevo.Controls.Add(Me.Label5)
        Me.tab_Nuevo.Controls.Add(Me.Label6)
        Me.tab_Nuevo.Controls.Add(Me.Label7)
        Me.tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.tab_Nuevo.Name = "tab_Nuevo"
        Me.tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Nuevo.Size = New System.Drawing.Size(776, 535)
        Me.tab_Nuevo.TabIndex = 1
        Me.tab_Nuevo.Text = "Nuevo"
        Me.tab_Nuevo.UseVisualStyleBackColor = True
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
        Me.cmb_Cliente.Location = New System.Drawing.Point(97, 76)
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
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(251, 212)
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
        Me.Button2.Location = New System.Drawing.Point(98, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 30)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "&Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbx_Capacidad
        '
        Me.tbx_Capacidad.Control_Siguiente = Nothing
        Me.tbx_Capacidad.Filtrado = True
        Me.tbx_Capacidad.Location = New System.Drawing.Point(97, 158)
        Me.tbx_Capacidad.MaxLength = 5
        Me.tbx_Capacidad.Name = "tbx_Capacidad"
        Me.tbx_Capacidad.Size = New System.Drawing.Size(229, 20)
        Me.tbx_Capacidad.TabIndex = 51
        Me.tbx_Capacidad.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(97, 132)
        Me.tbx_Descripcion.MaxLength = 100
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(229, 20)
        Me.tbx_Descripcion.TabIndex = 50
        Me.tbx_Descripcion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Serie
        '
        Me.tbx_Serie.Control_Siguiente = Nothing
        Me.tbx_Serie.Filtrado = True
        Me.tbx_Serie.Location = New System.Drawing.Point(97, 106)
        Me.tbx_Serie.MaxLength = 100
        Me.tbx_Serie.Name = "tbx_Serie"
        Me.tbx_Serie.Size = New System.Drawing.Size(229, 20)
        Me.tbx_Serie.TabIndex = 49
        Me.tbx_Serie.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_CodigoBarra
        '
        Me.tbx_CodigoBarra.Control_Siguiente = Nothing
        Me.tbx_CodigoBarra.Filtrado = True
        Me.tbx_CodigoBarra.Location = New System.Drawing.Point(97, 46)
        Me.tbx_CodigoBarra.MaxLength = 100
        Me.tbx_CodigoBarra.Name = "tbx_CodigoBarra"
        Me.tbx_CodigoBarra.Size = New System.Drawing.Size(229, 20)
        Me.tbx_CodigoBarra.TabIndex = 47
        Me.tbx_CodigoBarra.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_CodigoCaset
        '
        Me.tbx_CodigoCaset.Control_Siguiente = Nothing
        Me.tbx_CodigoCaset.Filtrado = True
        Me.tbx_CodigoCaset.Location = New System.Drawing.Point(98, 20)
        Me.tbx_CodigoCaset.MaxLength = 100
        Me.tbx_CodigoCaset.Name = "tbx_CodigoCaset"
        Me.tbx_CodigoCaset.Size = New System.Drawing.Size(228, 20)
        Me.tbx_CodigoCaset.TabIndex = 46
        Me.tbx_CodigoCaset.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Capacidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Serie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Codigo de Barra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Codigo de Caset"
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
    Friend WithEvents lbl_Capacidad As System.Windows.Forms.Label
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_Serie As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents lbl_CodigoCaset As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Caset As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents Tab_Cartuchos As System.Windows.Forms.TabControl
    Friend WithEvents tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents tbx_CodigoCaset As Modulo_Ventas.cp_Textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbx_CodigoBarra As Modulo_Ventas.cp_Textbox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbx_Capacidad As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Descripcion As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Serie As Modulo_Ventas.cp_Textbox
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
End Class
