<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Outlook
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
        Me.gbx_Contactos = New System.Windows.Forms.GroupBox
        Me.lsv_Datos = New Modulo_Ventas.cp_Listview
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.gbx_Contactos.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Contactos
        '
        Me.gbx_Contactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Contactos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Contactos.Location = New System.Drawing.Point(9, 3)
        Me.gbx_Contactos.Name = "gbx_Contactos"
        Me.gbx_Contactos.Size = New System.Drawing.Size(765, 491)
        Me.gbx_Contactos.TabIndex = 3
        Me.gbx_Contactos.TabStop = False
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 30
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 25
        Me.lsv_Datos.Row3 = 25
        Me.lsv_Datos.Row4 = 15
        Me.lsv_Datos.Row5 = 10
        Me.lsv_Datos.Row6 = 10
        Me.lsv_Datos.Row7 = 10
        Me.lsv_Datos.Row8 = 10
        Me.lsv_Datos.Row9 = 10
        Me.lsv_Datos.Size = New System.Drawing.Size(753, 466)
        Me.lsv_Datos.TabIndex = 1
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.Btn_Cancelar)
        Me.gbx_botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_botones.Location = New System.Drawing.Point(9, 500)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(765, 50)
        Me.gbx_botones.TabIndex = 4
        Me.gbx_botones.TabStop = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(619, 14)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 3
        Me.Btn_Cancelar.Text = "&Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 2
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'frm_Outlook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_Contactos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Outlook"
        Me.Text = "Contactos de Outlook"
        Me.gbx_Contactos.ResumeLayout(False)
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsv_Datos As cp_Listview
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Contactos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
End Class
