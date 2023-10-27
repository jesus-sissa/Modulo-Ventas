<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaPuntos
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
        Me.gbx_Cliente = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.cbx_Hijos = New System.Windows.Forms.CheckBox
        Me.rbn_Ambos = New System.Windows.Forms.RadioButton
        Me.rbn_Destino = New System.Windows.Forms.RadioButton
        Me.rbn_Origen = New System.Windows.Forms.RadioButton
        Me.cbx_Todos = New System.Windows.Forms.CheckBox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.gbx_Puntos = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.gbx_Cliente.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Puntos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Cliente
        '
        Me.gbx_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cliente.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Cliente.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Cliente.Controls.Add(Me.dtp_desde)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Desde)
        Me.gbx_Cliente.Controls.Add(Me.cbx_Hijos)
        Me.gbx_Cliente.Controls.Add(Me.rbn_Ambos)
        Me.gbx_Cliente.Controls.Add(Me.rbn_Destino)
        Me.gbx_Cliente.Controls.Add(Me.rbn_Origen)
        Me.gbx_Cliente.Controls.Add(Me.cbx_Todos)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.btn_BuscarCliente)
        Me.gbx_Cliente.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Cliente.Name = "gbx_Cliente"
        Me.gbx_Cliente.Size = New System.Drawing.Size(768, 90)
        Me.gbx_Cliente.TabIndex = 0
        Me.gbx_Cliente.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(593, 54)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 13
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(201, 39)
        Me.dtp_Hasta.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Hasta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 7
        Me.dtp_Hasta.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(160, 43)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 6
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_desde
        '
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(59, 39)
        Me.dtp_desde.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_desde.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_desde.TabIndex = 5
        Me.dtp_desde.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(15, 43)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 4
        Me.lbl_Desde.Text = "Desde"
        '
        'cbx_Hijos
        '
        Me.cbx_Hijos.AutoSize = True
        Me.cbx_Hijos.Location = New System.Drawing.Point(400, 65)
        Me.cbx_Hijos.Name = "cbx_Hijos"
        Me.cbx_Hijos.Size = New System.Drawing.Size(112, 17)
        Me.cbx_Hijos.TabIndex = 11
        Me.cbx_Hijos.Text = "Incluir Subclientes"
        Me.cbx_Hijos.UseVisualStyleBackColor = True
        '
        'rbn_Ambos
        '
        Me.rbn_Ambos.AutoSize = True
        Me.rbn_Ambos.Location = New System.Drawing.Point(319, 65)
        Me.rbn_Ambos.Name = "rbn_Ambos"
        Me.rbn_Ambos.Size = New System.Drawing.Size(76, 17)
        Me.rbn_Ambos.TabIndex = 10
        Me.rbn_Ambos.Text = "Por Ambos"
        Me.rbn_Ambos.UseVisualStyleBackColor = True
        '
        'rbn_Destino
        '
        Me.rbn_Destino.AutoSize = True
        Me.rbn_Destino.Location = New System.Drawing.Point(187, 65)
        Me.rbn_Destino.Name = "rbn_Destino"
        Me.rbn_Destino.Size = New System.Drawing.Size(130, 17)
        Me.rbn_Destino.TabIndex = 9
        Me.rbn_Destino.Text = "Por Cliente de Destino"
        Me.rbn_Destino.UseVisualStyleBackColor = True
        '
        'rbn_Origen
        '
        Me.rbn_Origen.AutoSize = True
        Me.rbn_Origen.Checked = True
        Me.rbn_Origen.Location = New System.Drawing.Point(59, 65)
        Me.rbn_Origen.Name = "rbn_Origen"
        Me.rbn_Origen.Size = New System.Drawing.Size(125, 17)
        Me.rbn_Origen.TabIndex = 8
        Me.rbn_Origen.TabStop = True
        Me.rbn_Origen.Text = "Por Cliente de Origen"
        Me.rbn_Origen.UseVisualStyleBackColor = True
        '
        'cbx_Todos
        '
        Me.cbx_Todos.AutoSize = True
        Me.cbx_Todos.Location = New System.Drawing.Point(518, 66)
        Me.cbx_Todos.Name = "cbx_Todos"
        Me.cbx_Todos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todos.TabIndex = 12
        Me.cbx_Todos.Text = "Todos"
        Me.cbx_Todos.UseVisualStyleBackColor = True
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.dtp_desde
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(149, 13)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 2
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(59, 13)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(84, 20)
        Me.tbx_Cliente.TabIndex = 1
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(14, 16)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(555, 11)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 3
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.BTN_Exportar)
        Me.gbx_Controles.Location = New System.Drawing.Point(8, 495)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(768, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Enabled = False
        Me.BTN_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 0
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_Puntos
        '
        Me.gbx_Puntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Puntos.Controls.Add(Me.lbl_Registros)
        Me.gbx_Puntos.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_Puntos.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Puntos.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_Puntos.Controls.Add(Me.BTN_Buscar)
        Me.gbx_Puntos.Location = New System.Drawing.Point(8, 98)
        Me.gbx_Puntos.Name = "gbx_Puntos"
        Me.gbx_Puntos.Size = New System.Drawing.Size(768, 391)
        Me.gbx_Puntos.TabIndex = 1
        Me.gbx_Puntos.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(622, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 17)
        Me.lbl_Registros.TabIndex = 28
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(8, 39)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 10
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 10
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(754, 338)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(63, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(441, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(518, 11)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(70, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "&Buscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(14, 16)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'frm_ConsultaPuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Cliente)
        Me.Controls.Add(Me.gbx_Puntos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaPuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Puntos Atendidos"
        Me.gbx_Cliente.ResumeLayout(False)
        Me.gbx_Cliente.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Puntos.ResumeLayout(False)
        Me.gbx_Puntos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_Hijos As System.Windows.Forms.CheckBox
    Friend WithEvents rbn_Ambos As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Destino As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_Origen As System.Windows.Forms.RadioButton
    Friend WithEvents cbx_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents gbx_Puntos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
