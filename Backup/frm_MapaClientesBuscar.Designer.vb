<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MapaClientesBuscar
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MapaClientesBuscar))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Chk_Todos = New System.Windows.Forms.CheckBox
        Me.Lbl_ClienCC = New System.Windows.Forms.Label
        Me.Lbl_Total = New System.Windows.Forms.Label
        Me.Lbl_ClienSC = New System.Windows.Forms.Label
        Me.Lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.Web_Mapa = New System.Windows.Forms.WebBrowser
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Mostrar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chk_Todos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbl_ClienCC)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbl_Total)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbl_ClienSC)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lsv_Clientes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Web_Mapa)
        Me.SplitContainer1.Size = New System.Drawing.Size(774, 495)
        Me.SplitContainer1.SplitterDistance = 458
        Me.SplitContainer1.TabIndex = 0
        '
        'Chk_Todos
        '
        Me.Chk_Todos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_Todos.AutoSize = True
        Me.Chk_Todos.Location = New System.Drawing.Point(390, 31)
        Me.Chk_Todos.Name = "Chk_Todos"
        Me.Chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Todos.TabIndex = 4
        Me.Chk_Todos.Text = "Todos"
        Me.Chk_Todos.UseVisualStyleBackColor = True
        '
        'Lbl_ClienCC
        '
        Me.Lbl_ClienCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ClienCC.Location = New System.Drawing.Point(3, 28)
        Me.Lbl_ClienCC.Name = "Lbl_ClienCC"
        Me.Lbl_ClienCC.Size = New System.Drawing.Size(251, 17)
        Me.Lbl_ClienCC.TabIndex = 2
        Me.Lbl_ClienCC.Text = "Clientes con Coordenadas: 0"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(334, 3)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(121, 23)
        Me.Lbl_Total.TabIndex = 1
        Me.Lbl_Total.Text = "Total: 0"
        Me.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_ClienSC
        '
        Me.Lbl_ClienSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ClienSC.Location = New System.Drawing.Point(3, 6)
        Me.Lbl_ClienSC.Name = "Lbl_ClienSC"
        Me.Lbl_ClienSC.Size = New System.Drawing.Size(251, 16)
        Me.Lbl_ClienSC.TabIndex = 0
        Me.Lbl_ClienSC.Text = "Clientes sin Coordenadas: 0"
        '
        'Lsv_Clientes
        '
        Me.Lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Clientes.CheckBoxes = True
        Me.Lsv_Clientes.FullRowSelect = True
        Me.Lsv_Clientes.HideSelection = False
        Me.Lsv_Clientes.Location = New System.Drawing.Point(3, 50)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Clientes.Lvs = ListViewColumnSorter2
        Me.Lsv_Clientes.MultiSelect = False
        Me.Lsv_Clientes.Name = "Lsv_Clientes"
        Me.Lsv_Clientes.Row1 = -1
        Me.Lsv_Clientes.Row10 = 10
        Me.Lsv_Clientes.Row2 = 40
        Me.Lsv_Clientes.Row3 = -1
        Me.Lsv_Clientes.Row4 = -1
        Me.Lsv_Clientes.Row5 = -1
        Me.Lsv_Clientes.Row6 = -1
        Me.Lsv_Clientes.Row7 = 10
        Me.Lsv_Clientes.Row8 = 10
        Me.Lsv_Clientes.Row9 = 10
        Me.Lsv_Clientes.Size = New System.Drawing.Size(452, 442)
        Me.Lsv_Clientes.TabIndex = 3
        Me.Lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.Lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'Web_Mapa
        '
        Me.Web_Mapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Web_Mapa.Location = New System.Drawing.Point(3, 3)
        Me.Web_Mapa.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web_Mapa.Name = "Web_Mapa"
        Me.Web_Mapa.Size = New System.Drawing.Size(306, 489)
        Me.Web_Mapa.TabIndex = 0
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Mostrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 505)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(775, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow
        Me.Btn_Mostrar.Location = New System.Drawing.Point(6, 14)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Mostrar.TabIndex = 0
        Me.Btn_Mostrar.Text = "&Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(152, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 2
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'frm_MapaClientesBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_MapaClientesBuscar"
        Me.Text = "Buscar Cliente en Mapa"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents Web_Mapa As System.Windows.Forms.WebBrowser
    Friend WithEvents Lbl_ClienCC As System.Windows.Forms.Label
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Lbl_ClienSC As System.Windows.Forms.Label
    Friend WithEvents Btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
End Class
