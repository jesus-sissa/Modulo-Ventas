<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BuscarCliente
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
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.chk_SoloActivos = New System.Windows.Forms.CheckBox
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.lbl_DobleClick = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 2
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'chk_SoloActivos
        '
        Me.chk_SoloActivos.AutoSize = True
        Me.chk_SoloActivos.Checked = True
        Me.chk_SoloActivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SoloActivos.Location = New System.Drawing.Point(62, 37)
        Me.chk_SoloActivos.Name = "chk_SoloActivos"
        Me.chk_SoloActivos.Size = New System.Drawing.Size(161, 17)
        Me.chk_SoloActivos.TabIndex = 3
        Me.chk_SoloActivos.Text = "Mostrar solo Clientes Activos"
        Me.chk_SoloActivos.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_buscar.Location = New System.Drawing.Point(364, 33)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(137, 23)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "&Buscar Siguiente"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(61, 12)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(438, 20)
        Me.tbx_Buscar.TabIndex = 0
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.AllowColumnReorder = True
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(3, 79)
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
        Me.lsv_Clientes.Size = New System.Drawing.Size(506, 318)
        Me.lsv_Clientes.TabIndex = 1
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'lbl_DobleClick
        '
        Me.lbl_DobleClick.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_DobleClick.AutoSize = True
        Me.lbl_DobleClick.Location = New System.Drawing.Point(0, 400)
        Me.lbl_DobleClick.Name = "lbl_DobleClick"
        Me.lbl_DobleClick.Size = New System.Drawing.Size(341, 13)
        Me.lbl_DobleClick.TabIndex = 6
        Me.lbl_DobleClick.Text = "Doble Click para realizar la Selección y cerrar la ventana de búsqueda."
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(354, 59)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(155, 17)
        Me.Lbl_Registros.TabIndex = 20
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 417)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.lbl_DobleClick)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.chk_SoloActivos)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.lsv_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(519, 446)
        Me.Name = "Frm_BuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents chk_SoloActivos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_DobleClick As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
