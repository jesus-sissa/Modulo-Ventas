<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InstanciasEmpleados
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
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tbx_Empleado = New Modulo_Ventas.cp_Textbox
        Me.cmb_Empleados = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Instancia = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Catalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(566, 211)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
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
        Me.BTN_Exportar.Location = New System.Drawing.Point(152, 211)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 6
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.Btn_Baja.Location = New System.Drawing.Point(6, 211)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 4
        Me.Btn_Baja.Text = "B&orrar"
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(551, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(26, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar"
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.btn_Guardar)
        Me.tab_Listado.Controls.Add(Me.tbx_Empleado)
        Me.tab_Listado.Controls.Add(Me.cmb_Empleados)
        Me.tab_Listado.Controls.Add(Me.Label1)
        Me.tab_Listado.Controls.Add(Me.cmb_Instancia)
        Me.tab_Listado.Controls.Add(Me.Label5)
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
        Me.tab_Listado.Size = New System.Drawing.Size(714, 249)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(573, 87)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(135, 23)
        Me.Lbl_Registros.TabIndex = 15
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.btn_Guardar.Location = New System.Drawing.Point(551, 54)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 14
        Me.btn_Guardar.Text = "&Agregar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Empleado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Instancia"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(722, 275)
        Me.Tab_Catalogo.TabIndex = 1
        '
        'tbx_Empleado
        '
        Me.tbx_Empleado.Control_Siguiente = Nothing
        Me.tbx_Empleado.Filtrado = False
        Me.tbx_Empleado.Location = New System.Drawing.Point(73, 60)
        Me.tbx_Empleado.MaxLength = 4
        Me.tbx_Empleado.Name = "tbx_Empleado"
        Me.tbx_Empleado.Size = New System.Drawing.Size(66, 20)
        Me.tbx_Empleado.TabIndex = 13
        Me.tbx_Empleado.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Empleados
        '
        Me.cmb_Empleados.Clave = "Clave_Empleado"
        Me.cmb_Empleados.Control_Siguiente = Nothing
        Me.cmb_Empleados.DisplayMember = "Nombre"
        Me.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleados.Empresa = False
        Me.cmb_Empleados.Filtro = Me.tbx_Empleado
        Me.cmb_Empleados.FormattingEnabled = True
        Me.cmb_Empleados.Location = New System.Drawing.Point(145, 60)
        Me.cmb_Empleados.MaxDropDownItems = 20
        Me.cmb_Empleados.Name = "cmb_Empleados"
        Me.cmb_Empleados.Pista = False
        Me.cmb_Empleados.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Empleados.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Empleados.Sucursal = True
        Me.cmb_Empleados.TabIndex = 12
        Me.cmb_Empleados.Tipo = 0
        Me.cmb_Empleados.ValueMember = "Id_Empleado"
        '
        'cmb_Instancia
        '
        Me.cmb_Instancia.Clave = Nothing
        Me.cmb_Instancia.Control_Siguiente = Nothing
        Me.cmb_Instancia.DisplayMember = "Descripcion"
        Me.cmb_Instancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Instancia.Empresa = False
        Me.cmb_Instancia.Filtro = Nothing
        Me.cmb_Instancia.FormattingEnabled = True
        Me.cmb_Instancia.Location = New System.Drawing.Point(73, 33)
        Me.cmb_Instancia.MaxDropDownItems = 20
        Me.cmb_Instancia.Name = "cmb_Instancia"
        Me.cmb_Instancia.Pista = False
        Me.cmb_Instancia.Size = New System.Drawing.Size(214, 21)
        Me.cmb_Instancia.StoredProcedure = "Cat_Instancias_Get"
        Me.cmb_Instancia.Sucursal = False
        Me.cmb_Instancia.TabIndex = 10
        Me.cmb_Instancia.Tipo = 0
        Me.cmb_Instancia.ValueMember = "Id_Instancia"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(73, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(472, 20)
        Me.tbx_Buscar.TabIndex = 1
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
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 113)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 20
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 40
        Me.lsv_Catalogo.Row3 = 0
        Me.lsv_Catalogo.Row4 = 0
        Me.lsv_Catalogo.Row5 = 15
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(700, 93)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'frm_InstanciasEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 550)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.Name = "frm_InstanciasEmpleados"
        Me.Text = "Empleados por Instancia"
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Instancia As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents cmb_Empleados As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Empleado As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label

End Class
