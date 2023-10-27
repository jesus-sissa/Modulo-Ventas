<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ayuda
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
        Me.rtb_Ayuda = New System.Windows.Forms.RichTextBox
        Me.lbl_Resize = New System.Windows.Forms.Label
        Me.lbl_Salir = New System.Windows.Forms.Label
        Me.pct_Cerrar = New System.Windows.Forms.PictureBox
        CType(Me.pct_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtb_Ayuda
        '
        Me.rtb_Ayuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Ayuda.BackColor = System.Drawing.Color.LemonChiffon
        Me.rtb_Ayuda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_Ayuda.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_Ayuda.Location = New System.Drawing.Point(0, 15)
        Me.rtb_Ayuda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rtb_Ayuda.Name = "rtb_Ayuda"
        Me.rtb_Ayuda.ReadOnly = True
        Me.rtb_Ayuda.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.rtb_Ayuda.Size = New System.Drawing.Size(490, 555)
        Me.rtb_Ayuda.TabIndex = 5
        Me.rtb_Ayuda.TabStop = False
        Me.rtb_Ayuda.Text = ""
        Me.rtb_Ayuda.WordWrap = False
        '
        'lbl_Resize
        '
        Me.lbl_Resize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Resize.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_Resize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resize.ForeColor = System.Drawing.Color.White
        Me.lbl_Resize.Location = New System.Drawing.Point(474, 554)
        Me.lbl_Resize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Resize.Name = "lbl_Resize"
        Me.lbl_Resize.Size = New System.Drawing.Size(17, 16)
        Me.lbl_Resize.TabIndex = 6
        Me.lbl_Resize.Text = "╝"
        '
        'lbl_Salir
        '
        Me.lbl_Salir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Salir.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Salir.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_Salir.Location = New System.Drawing.Point(-1, 0)
        Me.lbl_Salir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Salir.Name = "lbl_Salir"
        Me.lbl_Salir.Size = New System.Drawing.Size(475, 14)
        Me.lbl_Salir.TabIndex = 7
        Me.lbl_Salir.Text = "»»»AYUDA«««"
        Me.lbl_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pct_Cerrar
        '
        Me.pct_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_Cerrar.BackColor = System.Drawing.Color.LemonChiffon
        Me.pct_Cerrar.ErrorImage = Nothing
        Me.pct_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Delete
        Me.pct_Cerrar.Location = New System.Drawing.Point(474, -1)
        Me.pct_Cerrar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct_Cerrar.Name = "pct_Cerrar"
        Me.pct_Cerrar.Size = New System.Drawing.Size(16, 15)
        Me.pct_Cerrar.TabIndex = 8
        Me.pct_Cerrar.TabStop = False
        '
        'frm_Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(490, 570)
        Me.Controls.Add(Me.pct_Cerrar)
        Me.Controls.Add(Me.lbl_Salir)
        Me.Controls.Add(Me.lbl_Resize)
        Me.Controls.Add(Me.rtb_Ayuda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(130, 90)
        Me.Name = "frm_Ayuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        CType(Me.pct_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtb_Ayuda As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Resize As System.Windows.Forms.Label
    Friend WithEvents lbl_Salir As System.Windows.Forms.Label
    Friend WithEvents pct_Cerrar As System.Windows.Forms.PictureBox
End Class
