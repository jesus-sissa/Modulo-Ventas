<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BuscarSubClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BuscarSubClientes))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lbl_StatusSubCli = New System.Windows.Forms.Label
        Me.cmb_StatusSubCli = New Modulo_Ventas.cp_cmb_Manual
        Me.lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(257, 9)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 3
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_buscar.Location = New System.Drawing.Point(641, 4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(69, 23)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(3, 417)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 7
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(750, 417)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(10, 8)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 0
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lbl_StatusSubCli
        '
        Me.lbl_StatusSubCli.AutoSize = True
        Me.lbl_StatusSubCli.Location = New System.Drawing.Point(72, 9)
        Me.lbl_StatusSubCli.Name = "lbl_StatusSubCli"
        Me.lbl_StatusSubCli.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusSubCli.TabIndex = 1
        Me.lbl_StatusSubCli.Text = "Status"
        '
        'cmb_StatusSubCli
        '
        Me.cmb_StatusSubCli.Control_Siguiente = Me.chk_Todos
        Me.cmb_StatusSubCli.DisplayMember = "display"
        Me.cmb_StatusSubCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_StatusSubCli.FormattingEnabled = True
        Me.cmb_StatusSubCli.Location = New System.Drawing.Point(115, 6)
        Me.cmb_StatusSubCli.MaxDropDownItems = 20
        Me.cmb_StatusSubCli.Name = "cmb_StatusSubCli"
        Me.cmb_StatusSubCli.Size = New System.Drawing.Size(136, 21)
        Me.cmb_StatusSubCli.TabIndex = 2
        Me.cmb_StatusSubCli.ValueMember = "value"
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.CheckBoxes = True
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(3, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 0
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 0
        Me.lsv_Clientes.Row3 = 0
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(887, 378)
        Me.lsv_Clientes.TabIndex = 6
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(306, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(329, 20)
        Me.tbx_Buscar.TabIndex = 4
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(735, 9)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(155, 17)
        Me.Lbl_Registros.TabIndex = 20
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_BuscarSubClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 451)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.lbl_StatusSubCli)
        Me.Controls.Add(Me.cmb_StatusSubCli)
        Me.Controls.Add(Me.chk_Todos)
        Me.Controls.Add(Me.lsv_Clientes)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 480)
        Me.Name = "frm_BuscarSubClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Subclientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_StatusSubCli As System.Windows.Forms.Label
    Friend WithEvents cmb_StatusSubCli As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
