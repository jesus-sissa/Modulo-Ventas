<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MapaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MapaClientes))
        Dim ListViewColumnSorter3 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Spt_MapaLsv = New System.Windows.Forms.SplitContainer
        Me.btn_Ayuda = New System.Windows.Forms.Button
        Me.Lbl_ClienCC = New System.Windows.Forms.Label
        Me.Lbl_Total = New System.Windows.Forms.Label
        Me.Lbl_ClienSC = New System.Windows.Forms.Label
        Me.Web_Mapa = New System.Windows.Forms.WebBrowser
        Me.Lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.Spt_MapaLsv.Panel1.SuspendLayout()
        Me.Spt_MapaLsv.Panel2.SuspendLayout()
        Me.Spt_MapaLsv.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 505)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(846, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(699, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Spt_MapaLsv
        '
        Me.Spt_MapaLsv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Spt_MapaLsv.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Spt_MapaLsv.Location = New System.Drawing.Point(6, 6)
        Me.Spt_MapaLsv.Name = "Spt_MapaLsv"
        '
        'Spt_MapaLsv.Panel1
        '
        Me.Spt_MapaLsv.Panel1.AccessibleDescription = ""
        Me.Spt_MapaLsv.Panel1.Controls.Add(Me.btn_Ayuda)
        Me.Spt_MapaLsv.Panel1.Controls.Add(Me.Lbl_ClienCC)
        Me.Spt_MapaLsv.Panel1.Controls.Add(Me.Lbl_Total)
        Me.Spt_MapaLsv.Panel1.Controls.Add(Me.Lbl_ClienSC)
        Me.Spt_MapaLsv.Panel1.Controls.Add(Me.Lsv_Clientes)
        '
        'Spt_MapaLsv.Panel2
        '
        Me.Spt_MapaLsv.Panel2.AccessibleDescription = ""
        Me.Spt_MapaLsv.Panel2.Controls.Add(Me.Web_Mapa)
        Me.Spt_MapaLsv.Size = New System.Drawing.Size(846, 493)
        Me.Spt_MapaLsv.SplitterDistance = 468
        Me.Spt_MapaLsv.TabIndex = 0
        '
        'btn_Ayuda
        '
        Me.btn_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ayuda.Image = Global.Modulo_Ventas.My.Resources.Resources.help_contents
        Me.btn_Ayuda.Location = New System.Drawing.Point(439, 24)
        Me.btn_Ayuda.Name = "btn_Ayuda"
        Me.btn_Ayuda.Size = New System.Drawing.Size(26, 24)
        Me.btn_Ayuda.TabIndex = 27
        Me.btn_Ayuda.UseVisualStyleBackColor = True
        '
        'Lbl_ClienCC
        '
        Me.Lbl_ClienCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ClienCC.Location = New System.Drawing.Point(3, 28)
        Me.Lbl_ClienCC.Name = "Lbl_ClienCC"
        Me.Lbl_ClienCC.Size = New System.Drawing.Size(262, 17)
        Me.Lbl_ClienCC.TabIndex = 2
        Me.Lbl_ClienCC.Text = "Clientes con Coordenadas: 0"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(317, 5)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(148, 23)
        Me.Lbl_Total.TabIndex = 1
        Me.Lbl_Total.Text = "Total: 0"
        Me.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_ClienSC
        '
        Me.Lbl_ClienSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ClienSC.Location = New System.Drawing.Point(3, 7)
        Me.Lbl_ClienSC.Name = "Lbl_ClienSC"
        Me.Lbl_ClienSC.Size = New System.Drawing.Size(262, 21)
        Me.Lbl_ClienSC.TabIndex = 0
        Me.Lbl_ClienSC.Text = "Clientes sin Coordenadas: 0"
        '
        'Web_Mapa
        '
        Me.Web_Mapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Web_Mapa.Location = New System.Drawing.Point(3, 3)
        Me.Web_Mapa.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web_Mapa.Name = "Web_Mapa"
        Me.Web_Mapa.Size = New System.Drawing.Size(365, 487)
        Me.Web_Mapa.TabIndex = 0
        '
        'Lsv_Clientes
        '
        Me.Lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Clientes.FullRowSelect = True
        Me.Lsv_Clientes.HideSelection = False
        Me.Lsv_Clientes.Location = New System.Drawing.Point(6, 48)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_Clientes.Lvs = ListViewColumnSorter3
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
        Me.Lsv_Clientes.Size = New System.Drawing.Size(459, 442)
        Me.Lsv_Clientes.TabIndex = 4
        Me.Lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.Lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'frm_MapaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 561)
        Me.Controls.Add(Me.Spt_MapaLsv)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_MapaClientes"
        Me.Text = "Obtener Coordenadas de Clientes"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Spt_MapaLsv.Panel1.ResumeLayout(False)
        Me.Spt_MapaLsv.Panel2.ResumeLayout(False)
        Me.Spt_MapaLsv.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Spt_MapaLsv As System.Windows.Forms.SplitContainer
    Friend WithEvents Lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents Web_Mapa As System.Windows.Forms.WebBrowser
    Friend WithEvents Lbl_ClienSC As System.Windows.Forms.Label
    Friend WithEvents Lbl_ClienCC As System.Windows.Forms.Label
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents btn_Ayuda As System.Windows.Forms.Button
End Class
