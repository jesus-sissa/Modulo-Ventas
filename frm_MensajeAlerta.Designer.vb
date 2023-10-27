<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MensajeAlerta
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
        Me.tab_MensajeAlerta = New System.Windows.Forms.TabControl
        Me.Tab_Inventario = New System.Windows.Forms.TabPage
        Me.btn_Limpiar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.cmb_Material = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lsv_Material = New Modulo_Ventas.cp_Listview
        Me.lbl_Material = New System.Windows.Forms.Label
        Me.lbl_Cantidad = New System.Windows.Forms.Label
        Me.tbx_Cantidad = New Modulo_Ventas.cp_Textbox
        Me.Tab_Texto = New System.Windows.Forms.TabPage
        Me.lbl_Texto = New System.Windows.Forms.Label
        Me.rtb_MensajeAlerta = New System.Windows.Forms.RichTextBox
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.tab_MensajeAlerta.SuspendLayout()
        Me.Tab_Inventario.SuspendLayout()
        Me.Tab_Texto.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_MensajeAlerta
        '
        Me.tab_MensajeAlerta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_MensajeAlerta.Controls.Add(Me.Tab_Inventario)
        Me.tab_MensajeAlerta.Controls.Add(Me.Tab_Texto)
        Me.tab_MensajeAlerta.Location = New System.Drawing.Point(0, 0)
        Me.tab_MensajeAlerta.Name = "tab_MensajeAlerta"
        Me.tab_MensajeAlerta.SelectedIndex = 0
        Me.tab_MensajeAlerta.Size = New System.Drawing.Size(596, 371)
        Me.tab_MensajeAlerta.TabIndex = 0
        '
        'Tab_Inventario
        '
        Me.Tab_Inventario.Controls.Add(Me.btn_Limpiar)
        Me.Tab_Inventario.Controls.Add(Me.btn_Agregar)
        Me.Tab_Inventario.Controls.Add(Me.cmb_Material)
        Me.Tab_Inventario.Controls.Add(Me.lsv_Material)
        Me.Tab_Inventario.Controls.Add(Me.lbl_Material)
        Me.Tab_Inventario.Controls.Add(Me.lbl_Cantidad)
        Me.Tab_Inventario.Controls.Add(Me.tbx_Cantidad)
        Me.Tab_Inventario.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Inventario.Name = "Tab_Inventario"
        Me.Tab_Inventario.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Inventario.Size = New System.Drawing.Size(588, 345)
        Me.Tab_Inventario.TabIndex = 0
        Me.Tab_Inventario.Text = "Por Inventario"
        Me.Tab_Inventario.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Enabled = False
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Image = Global.Modulo_Ventas.My.Resources.Resources.Trash16
        Me.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Limpiar.Location = New System.Drawing.Point(530, 4)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(33, 23)
        Me.btn_Limpiar.TabIndex = 5
        Me.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Agregar.Location = New System.Drawing.Point(449, 4)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 4
        Me.btn_Agregar.Text = "A&gregar"
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'cmb_Material
        '
        Me.cmb_Material.Clave = Nothing
        Me.cmb_Material.Control_Siguiente = Nothing
        Me.cmb_Material.DisplayMember = "Descripcion"
        Me.cmb_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Material.Empresa = False
        Me.cmb_Material.Filtro = Nothing
        Me.cmb_Material.FormattingEnabled = True
        Me.cmb_Material.Location = New System.Drawing.Point(163, 6)
        Me.cmb_Material.MaxDropDownItems = 20
        Me.cmb_Material.Name = "cmb_Material"
        Me.cmb_Material.Pista = False
        Me.cmb_Material.Size = New System.Drawing.Size(280, 21)
        Me.cmb_Material.StoredProcedure = "Mat_Materiales_ComboGet"
        Me.cmb_Material.Sucursal = False
        Me.cmb_Material.TabIndex = 3
        Me.cmb_Material.Tipo = 0
        Me.cmb_Material.ValueMember = "Id_Material"
        '
        'lsv_Material
        '
        Me.lsv_Material.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Material.FullRowSelect = True
        Me.lsv_Material.HideSelection = False
        Me.lsv_Material.Location = New System.Drawing.Point(3, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Material.Lvs = ListViewColumnSorter1
        Me.lsv_Material.MultiSelect = False
        Me.lsv_Material.Name = "lsv_Material"
        Me.lsv_Material.Row1 = 10
        Me.lsv_Material.Row10 = 0
        Me.lsv_Material.Row2 = 80
        Me.lsv_Material.Row3 = 0
        Me.lsv_Material.Row4 = 0
        Me.lsv_Material.Row5 = 0
        Me.lsv_Material.Row6 = 0
        Me.lsv_Material.Row7 = 0
        Me.lsv_Material.Row8 = 0
        Me.lsv_Material.Row9 = 0
        Me.lsv_Material.Size = New System.Drawing.Size(582, 309)
        Me.lsv_Material.TabIndex = 6
        Me.lsv_Material.UseCompatibleStateImageBehavior = False
        Me.lsv_Material.View = System.Windows.Forms.View.Details
        '
        'lbl_Material
        '
        Me.lbl_Material.AutoSize = True
        Me.lbl_Material.Location = New System.Drawing.Point(113, 9)
        Me.lbl_Material.Name = "lbl_Material"
        Me.lbl_Material.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Material.TabIndex = 2
        Me.lbl_Material.Text = "Material"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(2, 9)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cantidad.TabIndex = 0
        Me.lbl_Cantidad.Text = "Cantidad"
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Nothing
        Me.tbx_Cantidad.Filtrado = True
        Me.tbx_Cantidad.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Cantidad.MaxLength = 4
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cantidad.TabIndex = 1
        Me.tbx_Cantidad.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Tab_Texto
        '
        Me.Tab_Texto.Controls.Add(Me.lbl_Texto)
        Me.Tab_Texto.Controls.Add(Me.rtb_MensajeAlerta)
        Me.Tab_Texto.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Texto.Name = "Tab_Texto"
        Me.Tab_Texto.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Texto.Size = New System.Drawing.Size(588, 345)
        Me.Tab_Texto.TabIndex = 1
        Me.Tab_Texto.Text = "Textual"
        Me.Tab_Texto.UseVisualStyleBackColor = True
        '
        'lbl_Texto
        '
        Me.lbl_Texto.AutoSize = True
        Me.lbl_Texto.Location = New System.Drawing.Point(7, 11)
        Me.lbl_Texto.Name = "lbl_Texto"
        Me.lbl_Texto.Size = New System.Drawing.Size(269, 13)
        Me.lbl_Texto.TabIndex = 0
        Me.lbl_Texto.Text = "Capture la Información Adicional que se desee Agregar:"
        '
        'rtb_MensajeAlerta
        '
        Me.rtb_MensajeAlerta.Location = New System.Drawing.Point(3, 33)
        Me.rtb_MensajeAlerta.Name = "rtb_MensajeAlerta"
        Me.rtb_MensajeAlerta.Size = New System.Drawing.Size(575, 309)
        Me.rtb_MensajeAlerta.TabIndex = 1
        Me.rtb_MensajeAlerta.Text = ""
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Controles.Controls.Add(Me.btn_Aceptar)
        Me.gbx_Controles.Location = New System.Drawing.Point(3, 370)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(589, 48)
        Me.gbx_Controles.TabIndex = 1
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(443, 12)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_Aceptar.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.btn_Aceptar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Aceptar.TabIndex = 0
        Me.btn_Aceptar.Text = "&Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'frm_MensajeAlerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 421)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.tab_MensajeAlerta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 450)
        Me.Name = "frm_MensajeAlerta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje de Alerta"
        Me.tab_MensajeAlerta.ResumeLayout(False)
        Me.Tab_Inventario.ResumeLayout(False)
        Me.Tab_Inventario.PerformLayout()
        Me.Tab_Texto.ResumeLayout(False)
        Me.Tab_Texto.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents tab_MensajeAlerta As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Inventario As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Texto As System.Windows.Forms.TabPage
    Friend WithEvents rtb_MensajeAlerta As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Texto As System.Windows.Forms.Label
    Friend WithEvents lbl_Material As System.Windows.Forms.Label
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad As Modulo_Ventas.cp_Textbox
    Friend WithEvents lsv_Material As Modulo_Ventas.cp_Listview
    Friend WithEvents cmb_Material As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
End Class
