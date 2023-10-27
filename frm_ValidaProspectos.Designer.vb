<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValidaProspectos
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Valida = New System.Windows.Forms.Button()
        Me.Lbl_Comentario = New System.Windows.Forms.Label()
        Me.gbx_Prospectos = New System.Windows.Forms.GroupBox()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Lsv_Prospectos = New Modulo_Ventas.cp_Listview()
        Me.tbx_Comentario = New Modulo_Ventas.cp_Textbox()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Prospectos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_eliminar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Actualizar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Valida)
        Me.Gbx_Botones.Location = New System.Drawing.Point(10, 507)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(765, 47)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(619, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Actualizar.Enabled = False
        Me.btn_Actualizar.Image = Global.Modulo_Ventas.My.Resources.Resources.agt_reload
        Me.btn_Actualizar.Location = New System.Drawing.Point(312, 11)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Actualizar.TabIndex = 1
        Me.btn_Actualizar.Text = "&Actualizar"
        Me.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Valida
        '
        Me.Btn_Valida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Valida.Enabled = False
        Me.Btn_Valida.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.Btn_Valida.Location = New System.Drawing.Point(9, 11)
        Me.Btn_Valida.Name = "Btn_Valida"
        Me.Btn_Valida.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Valida.TabIndex = 0
        Me.Btn_Valida.Text = "&Validar"
        Me.Btn_Valida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Valida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Valida.UseVisualStyleBackColor = True
        '
        'Lbl_Comentario
        '
        Me.Lbl_Comentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Comentario.AutoSize = True
        Me.Lbl_Comentario.Location = New System.Drawing.Point(6, 454)
        Me.Lbl_Comentario.Name = "Lbl_Comentario"
        Me.Lbl_Comentario.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_Comentario.TabIndex = 1
        Me.Lbl_Comentario.Text = "Comentario:"
        '
        'gbx_Prospectos
        '
        Me.gbx_Prospectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Prospectos.Controls.Add(Me.lbl_Registros)
        Me.gbx_Prospectos.Controls.Add(Me.Lsv_Prospectos)
        Me.gbx_Prospectos.Controls.Add(Me.Lbl_Comentario)
        Me.gbx_Prospectos.Controls.Add(Me.tbx_Comentario)
        Me.gbx_Prospectos.Location = New System.Drawing.Point(10, 2)
        Me.gbx_Prospectos.Name = "gbx_Prospectos"
        Me.gbx_Prospectos.Size = New System.Drawing.Size(765, 499)
        Me.gbx_Prospectos.TabIndex = 0
        Me.gbx_Prospectos.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(608, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(151, 15)
        Me.lbl_Registros.TabIndex = 30
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = Global.Modulo_Ventas.My.Resources.Resources.Delete
        Me.btn_eliminar.Location = New System.Drawing.Point(155, 11)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_eliminar.TabIndex = 3
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'Lsv_Prospectos
        '
        Me.Lsv_Prospectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Prospectos.CheckBoxes = True
        Me.Lsv_Prospectos.FullRowSelect = True
        Me.Lsv_Prospectos.HideSelection = False
        Me.Lsv_Prospectos.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Prospectos.Lvs = ListViewColumnSorter2
        Me.Lsv_Prospectos.MultiSelect = False
        Me.Lsv_Prospectos.Name = "Lsv_Prospectos"
        Me.Lsv_Prospectos.Row1 = 15
        Me.Lsv_Prospectos.Row10 = 0
        Me.Lsv_Prospectos.Row2 = 30
        Me.Lsv_Prospectos.Row3 = 30
        Me.Lsv_Prospectos.Row4 = 15
        Me.Lsv_Prospectos.Row5 = 0
        Me.Lsv_Prospectos.Row6 = 0
        Me.Lsv_Prospectos.Row7 = 0
        Me.Lsv_Prospectos.Row8 = 0
        Me.Lsv_Prospectos.Row9 = 0
        Me.Lsv_Prospectos.Size = New System.Drawing.Size(753, 411)
        Me.Lsv_Prospectos.TabIndex = 0
        Me.Lsv_Prospectos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Prospectos.View = System.Windows.Forms.View.Details
        '
        'tbx_Comentario
        '
        Me.tbx_Comentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Comentario.Control_Siguiente = Me.Btn_Valida
        Me.tbx_Comentario.Filtrado = True
        Me.tbx_Comentario.Location = New System.Drawing.Point(75, 451)
        Me.tbx_Comentario.MaxLength = 150
        Me.tbx_Comentario.Multiline = True
        Me.tbx_Comentario.Name = "tbx_Comentario"
        Me.tbx_Comentario.Size = New System.Drawing.Size(684, 42)
        Me.tbx_Comentario.TabIndex = 2
        Me.tbx_Comentario.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'frm_ValidaProspectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Prospectos)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ValidaProspectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valida Prospectos"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Prospectos.ResumeLayout(False)
        Me.gbx_Prospectos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lsv_Prospectos As Modulo_Ventas.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Valida As System.Windows.Forms.Button
    Friend WithEvents Lbl_Comentario As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentario As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents gbx_Prospectos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As Button
End Class
