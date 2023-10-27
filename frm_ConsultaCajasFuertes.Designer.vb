<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaCajasFuertes
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaCajasFuertes))
        Me.gbx_Controles = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.gbx_CajasFuertes = New System.Windows.Forms.GroupBox()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_ConsultaEdad = New Modulo_Ventas.cp_Listview()
        Me.Lbl_DoblClick = New System.Windows.Forms.Label()
        Me.lsv_ConsultaNormal = New Modulo_Ventas.cp_Listview()
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Lbl_Buscar = New System.Windows.Forms.Label()
        Me.gbx_Proveedor = New System.Windows.Forms.GroupBox()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.chk_Fechas = New System.Windows.Forms.CheckBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.tbx_Proveedor = New Modulo_Ventas.cp_Textbox()
        Me.cmb_Proveedor = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.chk_Proveedor = New System.Windows.Forms.CheckBox()
        Me.btn_BuscarProveedores = New System.Windows.Forms.Button()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_CajasFuertes.SuspendLayout()
        Me.gbx_Proveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.btn_Exportar)
        Me.gbx_Controles.Location = New System.Drawing.Point(7, 492)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(770, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_CajasFuertes
        '
        Me.gbx_CajasFuertes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_Registros)
        Me.gbx_CajasFuertes.Controls.Add(Me.lsv_ConsultaEdad)
        Me.gbx_CajasFuertes.Controls.Add(Me.Lbl_DoblClick)
        Me.gbx_CajasFuertes.Controls.Add(Me.lsv_ConsultaNormal)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_Buscar)
        Me.gbx_CajasFuertes.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_CajasFuertes.Controls.Add(Me.btn_Buscar)
        Me.gbx_CajasFuertes.Location = New System.Drawing.Point(7, 111)
        Me.gbx_CajasFuertes.Name = "gbx_CajasFuertes"
        Me.gbx_CajasFuertes.Size = New System.Drawing.Size(770, 375)
        Me.gbx_CajasFuertes.TabIndex = 1
        Me.gbx_CajasFuertes.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(621, 43)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 19)
        Me.lbl_Registros.TabIndex = 30
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ConsultaEdad
        '
        Me.lsv_ConsultaEdad.AllowColumnReorder = True
        Me.lsv_ConsultaEdad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ConsultaEdad.FullRowSelect = True
        Me.lsv_ConsultaEdad.HideSelection = False
        Me.lsv_ConsultaEdad.Location = New System.Drawing.Point(9, 65)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ConsultaEdad.Lvs = ListViewColumnSorter1
        Me.lsv_ConsultaEdad.MultiSelect = False
        Me.lsv_ConsultaEdad.Name = "lsv_ConsultaEdad"
        Me.lsv_ConsultaEdad.Row1 = 8
        Me.lsv_ConsultaEdad.Row10 = 8
        Me.lsv_ConsultaEdad.Row2 = 8
        Me.lsv_ConsultaEdad.Row3 = 5
        Me.lsv_ConsultaEdad.Row4 = 5
        Me.lsv_ConsultaEdad.Row5 = 6
        Me.lsv_ConsultaEdad.Row6 = 8
        Me.lsv_ConsultaEdad.Row7 = 8
        Me.lsv_ConsultaEdad.Row8 = 8
        Me.lsv_ConsultaEdad.Row9 = 12
        Me.lsv_ConsultaEdad.Size = New System.Drawing.Size(756, 208)
        Me.lsv_ConsultaEdad.TabIndex = 4
        Me.lsv_ConsultaEdad.UseCompatibleStateImageBehavior = False
        Me.lsv_ConsultaEdad.View = System.Windows.Forms.View.Details
        Me.lsv_ConsultaEdad.Visible = False
        '
        'Lbl_DoblClick
        '
        Me.Lbl_DoblClick.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DoblClick.AutoSize = True
        Me.Lbl_DoblClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DoblClick.Location = New System.Drawing.Point(5, 359)
        Me.Lbl_DoblClick.Name = "Lbl_DoblClick"
        Me.Lbl_DoblClick.Size = New System.Drawing.Size(276, 13)
        Me.Lbl_DoblClick.TabIndex = 4
        Me.Lbl_DoblClick.Text = "Doble Click en un Elemento para ver su Detalle"
        '
        'lsv_ConsultaNormal
        '
        Me.lsv_ConsultaNormal.AllowColumnReorder = True
        Me.lsv_ConsultaNormal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ConsultaNormal.FullRowSelect = True
        Me.lsv_ConsultaNormal.HideSelection = False
        Me.lsv_ConsultaNormal.Location = New System.Drawing.Point(8, 65)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ConsultaNormal.Lvs = ListViewColumnSorter2
        Me.lsv_ConsultaNormal.MultiSelect = False
        Me.lsv_ConsultaNormal.Name = "lsv_ConsultaNormal"
        Me.lsv_ConsultaNormal.Row1 = 5
        Me.lsv_ConsultaNormal.Row10 = 8
        Me.lsv_ConsultaNormal.Row2 = 8
        Me.lsv_ConsultaNormal.Row3 = 8
        Me.lsv_ConsultaNormal.Row4 = 8
        Me.lsv_ConsultaNormal.Row5 = 6
        Me.lsv_ConsultaNormal.Row6 = 12
        Me.lsv_ConsultaNormal.Row7 = 8
        Me.lsv_ConsultaNormal.Row8 = 8
        Me.lsv_ConsultaNormal.Row9 = 8
        Me.lsv_ConsultaNormal.Size = New System.Drawing.Size(756, 291)
        Me.lsv_ConsultaNormal.TabIndex = 3
        Me.lsv_ConsultaNormal.UseCompatibleStateImageBehavior = False
        Me.lsv_ConsultaNormal.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 19)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(564, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(622, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(70, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'gbx_Proveedor
        '
        Me.gbx_Proveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Proveedor.Controls.Add(Me.dtp_Desde)
        Me.gbx_Proveedor.Controls.Add(Me.chk_Fechas)
        Me.gbx_Proveedor.Controls.Add(Me.lbl_Status)
        Me.gbx_Proveedor.Controls.Add(Me.cmb_Status)
        Me.gbx_Proveedor.Controls.Add(Me.chk_Status)
        Me.gbx_Proveedor.Controls.Add(Me.lbl_Proveedor)
        Me.gbx_Proveedor.Controls.Add(Me.tbx_Proveedor)
        Me.gbx_Proveedor.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Proveedor.Controls.Add(Me.cmb_Proveedor)
        Me.gbx_Proveedor.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Proveedor.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Proveedor.Controls.Add(Me.lbl_Desde)
        Me.gbx_Proveedor.Controls.Add(Me.chk_Proveedor)
        Me.gbx_Proveedor.Controls.Add(Me.btn_BuscarProveedores)
        Me.gbx_Proveedor.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Proveedor.Name = "gbx_Proveedor"
        Me.gbx_Proveedor.Size = New System.Drawing.Size(770, 103)
        Me.gbx_Proveedor.TabIndex = 0
        Me.gbx_Proveedor.TabStop = False
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(81, 46)
        Me.dtp_Desde.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_Desde.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 6
        Me.dtp_Desde.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'chk_Fechas
        '
        Me.chk_Fechas.AutoSize = True
        Me.chk_Fechas.Location = New System.Drawing.Point(324, 51)
        Me.chk_Fechas.Name = "chk_Fechas"
        Me.chk_Fechas.Size = New System.Drawing.Size(56, 17)
        Me.chk_Fechas.TabIndex = 9
        Me.chk_Fechas.Text = "Todos"
        Me.chk_Fechas.UseVisualStyleBackColor = True
        Me.chk_Fechas.Visible = False
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(38, 75)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 10
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(81, 72)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(237, 21)
        Me.cmb_Status.TabIndex = 11
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(503, 63)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 13
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(324, 74)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 12
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(19, 22)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Proveedor.TabIndex = 0
        Me.lbl_Proveedor.Text = "Proveedor"
        Me.lbl_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Proveedor
        '
        Me.tbx_Proveedor.Control_Siguiente = Me.cmb_Proveedor
        Me.tbx_Proveedor.Filtrado = True
        Me.tbx_Proveedor.Location = New System.Drawing.Point(81, 19)
        Me.tbx_Proveedor.MaxLength = 20
        Me.tbx_Proveedor.Name = "tbx_Proveedor"
        Me.tbx_Proveedor.Size = New System.Drawing.Size(63, 20)
        Me.tbx_Proveedor.TabIndex = 1
        Me.tbx_Proveedor.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Proveedor
        '
        Me.cmb_Proveedor.Clave = "Clave"
        Me.cmb_Proveedor.Control_Siguiente = Nothing
        Me.cmb_Proveedor.DisplayMember = "Nombre"
        Me.cmb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Proveedor.Empresa = False
        Me.cmb_Proveedor.Filtro = Me.tbx_Proveedor
        Me.cmb_Proveedor.FormattingEnabled = True
        Me.cmb_Proveedor.Location = New System.Drawing.Point(150, 19)
        Me.cmb_Proveedor.MaxDropDownItems = 20
        Me.cmb_Proveedor.Name = "cmb_Proveedor"
        Me.cmb_Proveedor.Pista = True
        Me.cmb_Proveedor.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Proveedor.StoredProcedure = "Cat_Proveedores_Get"
        Me.cmb_Proveedor.Sucursal = False
        Me.cmb_Proveedor.TabIndex = 2
        Me.cmb_Proveedor.Tipo = 0
        Me.cmb_Proveedor.ValueMember = "Id_Proveedor"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(223, 46)
        Me.dtp_Hasta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_Hasta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 8
        Me.dtp_Hasta.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(182, 50)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 7
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(37, 50)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 5
        Me.lbl_Desde.Text = "Desde"
        '
        'chk_Proveedor
        '
        Me.chk_Proveedor.AutoSize = True
        Me.chk_Proveedor.Location = New System.Drawing.Point(587, 21)
        Me.chk_Proveedor.Name = "chk_Proveedor"
        Me.chk_Proveedor.Size = New System.Drawing.Size(56, 17)
        Me.chk_Proveedor.TabIndex = 4
        Me.chk_Proveedor.Text = "Todos"
        Me.chk_Proveedor.UseVisualStyleBackColor = True
        '
        'btn_BuscarProveedores
        '
        Me.btn_BuscarProveedores.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarProveedores.Location = New System.Drawing.Point(555, 17)
        Me.btn_BuscarProveedores.Name = "btn_BuscarProveedores"
        Me.btn_BuscarProveedores.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarProveedores.TabIndex = 3
        Me.btn_BuscarProveedores.UseVisualStyleBackColor = True
        '
        'frm_ConsultaCajasFuertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Proveedor)
        Me.Controls.Add(Me.gbx_CajasFuertes)
        Me.Controls.Add(Me.gbx_Controles)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaCajasFuertes"
        Me.Text = "Consulta de Cajas Fuertes"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_CajasFuertes.ResumeLayout(False)
        Me.gbx_CajasFuertes.PerformLayout()
        Me.gbx_Proveedor.ResumeLayout(False)
        Me.gbx_Proveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Proveedor As System.Windows.Forms.CheckBox
    Friend WithEvents btn_BuscarProveedores As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents gbx_CajasFuertes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents tbx_Proveedor As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Proveedor As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lsv_ConsultaNormal As Modulo_Ventas.cp_Listview
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_DoblClick As System.Windows.Forms.Label
    Friend WithEvents chk_Fechas As System.Windows.Forms.CheckBox
    Friend WithEvents lsv_ConsultaEdad As Modulo_Ventas.cp_Listview
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
