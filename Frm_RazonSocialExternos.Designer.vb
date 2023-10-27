<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_RazonSocialExternos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewColumnSorter4 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.tbx_Descripcion = New Modulo_Ventas.cp_Textbox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Baja = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.tbx_Status = New Modulo_Ventas.cp_Textbox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_Grupo = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.tab_Listado = New System.Windows.Forms.TabPage()
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage()
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.Tab_Catalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(256, 115)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = False
        Me.tbx_Descripcion.Location = New System.Drawing.Point(110, 44)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Descripcion.TabIndex = 1
        Me.tbx_Descripcion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(653, 30)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(135, 23)
        Me.Lbl_Registros.TabIndex = 8
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(149, 504)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 5
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.btn_Baja.Location = New System.Drawing.Point(3, 504)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 4
        Me.btn_Baja.Text = "&Baja / Reing."
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(653, 504)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Status
        '
        Me.tbx_Status.Control_Siguiente = Nothing
        Me.tbx_Status.Enabled = False
        Me.tbx_Status.Filtrado = True
        Me.tbx_Status.Location = New System.Drawing.Point(110, 70)
        Me.tbx_Status.MaxLength = 1
        Me.tbx_Status.Name = "tbx_Status"
        Me.tbx_Status.Size = New System.Drawing.Size(95, 20)
        Me.tbx_Status.TabIndex = 3
        Me.tbx_Status.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(67, 73)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 2
        Me.lbl_Status.Text = "Status"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(41, 47)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Grupo.TabIndex = 0
        Me.lbl_Grupo.Text = "Descripción"
        Me.lbl_Grupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(573, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(3, 9)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 56)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter4
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 30
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 15
        Me.lsv_Catalogo.Row3 = 0
        Me.lsv_Catalogo.Row4 = 0
        Me.lsv_Catalogo.Row5 = 0
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(790, 442)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.Tag = "Id_TipoParentesco"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(110, 115)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 4
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Baja)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(796, 542)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Status)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Status)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Grupo)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Descripcion)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(796, 542)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(804, 568)
        Me.Tab_Catalogo.TabIndex = 1
        '
        'Frm_RazonSocialExternos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 568)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Name = "Frm_RazonSocialExternos"
        Me.Text = "Razon Social de Clientes Externos"
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.Tab_Nuevo.PerformLayout()
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents tbx_Descripcion As cp_Textbox
    Friend WithEvents Lbl_Registros As Label
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Baja As Button
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents tbx_Status As cp_Textbox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents lbl_Grupo As Label
    Friend WithEvents tbx_Buscar As cp_Textbox
    Friend WithEvents lbl_Buscar As Label
    Friend WithEvents lsv_Catalogo As cp_Listview
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents tab_Listado As TabPage
    Friend WithEvents Tab_Nuevo As TabPage
    Friend WithEvents Tab_Catalogo As TabControl
End Class
