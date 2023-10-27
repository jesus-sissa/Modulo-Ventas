<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActaInspeccionValidar
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_ActasInspeccionP = New Modulo_Ventas.cp_Listview
        Me.gbx_Botones.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 504)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 7
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.lsv_ActasInspeccionP)
        Me.Gbx_Listado.Location = New System.Drawing.Point(8, 7)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(767, 491)
        Me.Gbx_Listado.TabIndex = 2
        Me.Gbx_Listado.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(599, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(162, 18)
        Me.Lbl_Registros.TabIndex = 2
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ActasInspeccionP
        '
        Me.lsv_ActasInspeccionP.AllowColumnReorder = True
        Me.lsv_ActasInspeccionP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ActasInspeccionP.FullRowSelect = True
        Me.lsv_ActasInspeccionP.HideSelection = False
        Me.lsv_ActasInspeccionP.Location = New System.Drawing.Point(7, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ActasInspeccionP.Lvs = ListViewColumnSorter1
        Me.lsv_ActasInspeccionP.MultiSelect = False
        Me.lsv_ActasInspeccionP.Name = "lsv_ActasInspeccionP"
        Me.lsv_ActasInspeccionP.Row1 = 10
        Me.lsv_ActasInspeccionP.Row10 = 0
        Me.lsv_ActasInspeccionP.Row2 = 10
        Me.lsv_ActasInspeccionP.Row3 = 10
        Me.lsv_ActasInspeccionP.Row4 = 25
        Me.lsv_ActasInspeccionP.Row5 = 30
        Me.lsv_ActasInspeccionP.Row6 = 0
        Me.lsv_ActasInspeccionP.Row7 = 10
        Me.lsv_ActasInspeccionP.Row8 = 0
        Me.lsv_ActasInspeccionP.Row9 = 0
        Me.lsv_ActasInspeccionP.Size = New System.Drawing.Size(752, 447)
        Me.lsv_ActasInspeccionP.TabIndex = 0
        Me.lsv_ActasInspeccionP.UseCompatibleStateImageBehavior = False
        Me.lsv_ActasInspeccionP.View = System.Windows.Forms.View.Details
        '
        'frm_ActaInspeccionValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ActaInspeccionValidar"
        Me.Text = "Validar Acta de Inspección para Instalación de Cajas Fuertes"
        Me.gbx_Botones.ResumeLayout(False)
        Me.Gbx_Listado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ActasInspeccionP As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
