<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgendaTodas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AgendaTodas))
        Me.myTimer = New System.Windows.Forms.Timer(Me.components)
        Me.gbx_Vencidas = New System.Windows.Forms.GroupBox
        Me.lsv_Tareas = New Modulo_Ventas.cp_Listview
        Me.il_Alertas = New System.Windows.Forms.ImageList(Me.components)
        Me.rtb_Descripcion = New System.Windows.Forms.RichTextBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Lbl_Descripcion = New System.Windows.Forms.Label
        Me.btn_Detalle = New System.Windows.Forms.Button
        Me.gbx_Vencidas.SuspendLayout()
        Me.SuspendLayout()
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'gbx_Vencidas
        '
        Me.gbx_Vencidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Vencidas.Controls.Add(Me.lsv_Tareas)
        Me.gbx_Vencidas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Vencidas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbx_Vencidas.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Vencidas.Name = "gbx_Vencidas"
        Me.gbx_Vencidas.Size = New System.Drawing.Size(758, 337)
        Me.gbx_Vencidas.TabIndex = 1
        Me.gbx_Vencidas.TabStop = False
        '
        'lsv_Tareas
        '
        Me.lsv_Tareas.AllowColumnReorder = True
        Me.lsv_Tareas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Tareas.BackColor = System.Drawing.SystemColors.Window
        Me.lsv_Tareas.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lsv_Tareas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lsv_Tareas.FullRowSelect = True
        Me.lsv_Tareas.HideSelection = False
        Me.lsv_Tareas.Location = New System.Drawing.Point(6, 13)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Tareas.Lvs = ListViewColumnSorter1
        Me.lsv_Tareas.MultiSelect = False
        Me.lsv_Tareas.Name = "lsv_Tareas"
        Me.lsv_Tareas.Row1 = 15
        Me.lsv_Tareas.Row10 = 0
        Me.lsv_Tareas.Row2 = 15
        Me.lsv_Tareas.Row3 = 15
        Me.lsv_Tareas.Row4 = 35
        Me.lsv_Tareas.Row5 = 0
        Me.lsv_Tareas.Row6 = 15
        Me.lsv_Tareas.Row7 = 0
        Me.lsv_Tareas.Row8 = 0
        Me.lsv_Tareas.Row9 = 0
        Me.lsv_Tareas.Size = New System.Drawing.Size(746, 318)
        Me.lsv_Tareas.SmallImageList = Me.il_Alertas
        Me.lsv_Tareas.TabIndex = 0
        Me.lsv_Tareas.UseCompatibleStateImageBehavior = False
        Me.lsv_Tareas.View = System.Windows.Forms.View.Details
        '
        'il_Alertas
        '
        Me.il_Alertas.ImageStream = CType(resources.GetObject("il_Alertas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il_Alertas.TransparentColor = System.Drawing.Color.Transparent
        Me.il_Alertas.Images.SetKeyName(0, "Mail_Cerrado.png")
        Me.il_Alertas.Images.SetKeyName(1, "Mail_Abierto.png")
        Me.il_Alertas.Images.SetKeyName(2, "Mail_Enviado.png")
        '
        'rtb_Descripcion
        '
        Me.rtb_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Descripcion.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_Descripcion.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.rtb_Descripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rtb_Descripcion.Location = New System.Drawing.Point(3, 362)
        Me.rtb_Descripcion.Name = "rtb_Descripcion"
        Me.rtb_Descripcion.ReadOnly = True
        Me.rtb_Descripcion.Size = New System.Drawing.Size(758, 70)
        Me.rtb_Descripcion.TabIndex = 6
        Me.rtb_Descripcion.Text = ""
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 437)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Descripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_Descripcion.ImageList = Me.il_Alertas
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(5, 345)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(75, 14)
        Me.Lbl_Descripcion.TabIndex = 7
        Me.Lbl_Descripcion.Text = "Descripción:"
        Me.Lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Detalle
        '
        Me.btn_Detalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Detalle.Enabled = False
        Me.btn_Detalle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Detalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Detalle.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_Detalle.Location = New System.Drawing.Point(3, 437)
        Me.btn_Detalle.Name = "btn_Detalle"
        Me.btn_Detalle.Size = New System.Drawing.Size(140, 30)
        Me.btn_Detalle.TabIndex = 8
        Me.btn_Detalle.Text = "&Detalle"
        Me.btn_Detalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Detalle.UseVisualStyleBackColor = True
        '
        'frm_AgendaTodas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(764, 471)
        Me.Controls.Add(Me.btn_Detalle)
        Me.Controls.Add(Me.Lbl_Descripcion)
        Me.Controls.Add(Me.rtb_Descripcion)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.gbx_Vencidas)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(770, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(770, 500)
        Me.Name = "frm_AgendaTodas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tareas del Mes: Julio"
        Me.gbx_Vencidas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents gbx_Vencidas As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lsv_Tareas As Modulo_Ventas.cp_Listview
    Friend WithEvents il_Alertas As System.Windows.Forms.ImageList
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents btn_Detalle As System.Windows.Forms.Button
End Class
