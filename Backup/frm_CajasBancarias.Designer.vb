<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CajasBancarias
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
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.lbl_Banco = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cbx_Activas = New System.Windows.Forms.CheckBox
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.cmb_Banco = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
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
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 562)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.cbx_Activas)
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 536)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(633, 30)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(135, 23)
        Me.Lbl_Registros.TabIndex = 19
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(152, 498)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 8
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 498)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
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
        Me.BTN_Exportar.Location = New System.Drawing.Point(298, 498)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 5
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
        Me.Btn_Baja.Location = New System.Drawing.Point(6, 498)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 4
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 3
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(8, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 1
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.cmb_Banco)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Banco)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Cliente)
        Me.Tab_Nuevo.Controls.Add(Me.btn_BuscarCliente)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.cmb_Cliente)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Cliente)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(776, 536)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(35, 70)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco.TabIndex = 65
        Me.lbl_Banco.Text = "Banco"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(34, 43)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 63
        Me.lbl_Cliente.Text = "Cliente"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(640, 38)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 62
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(225, 93)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(79, 94)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 4
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cbx_Activas
        '
        Me.cbx_Activas.AutoSize = True
        Me.cbx_Activas.Checked = True
        Me.cbx_Activas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Activas.Location = New System.Drawing.Point(11, 36)
        Me.cbx_Activas.Name = "cbx_Activas"
        Me.cbx_Activas.Size = New System.Drawing.Size(150, 17)
        Me.cbx_Activas.TabIndex = 20
        Me.cbx_Activas.Text = "Sólo mostrar Cajas activas"
        Me.cbx_Activas.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 2
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 56)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 50
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 30
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 0
        Me.lsv_Catalogo.Row5 = 0
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(762, 437)
        Me.lsv_Catalogo.TabIndex = 0
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = Nothing
        Me.cmb_Banco.Control_Siguiente = Nothing
        Me.cmb_Banco.DisplayMember = "Nombre"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Nothing
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(79, 67)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = True
        Me.cmb_Banco.Size = New System.Drawing.Size(286, 21)
        Me.cmb_Banco.StoredProcedure = "Cat_Bancos_Get"
        Me.cmb_Banco.Sucursal = False
        Me.cmb_Banco.TabIndex = 64
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_Banco"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(135, 40)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(499, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 61
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(79, 40)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cliente.TabIndex = 60
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'frm_CajasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CajasBancarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Cajas Bancarias"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.Tab_Nuevo.PerformLayout()
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
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Banco As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents cbx_Activas As System.Windows.Forms.CheckBox
End Class
