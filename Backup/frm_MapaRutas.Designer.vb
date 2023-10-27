<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MapaRutas
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.Spt_MapaRutas = New System.Windows.Forms.SplitContainer
        Me.Pct_Origen = New System.Windows.Forms.PictureBox
        Me.Pic_Destino = New System.Windows.Forms.PictureBox
        Me.Lsv_ClientesOri = New Modulo_Ventas.cp_Listview
        Me.Lsv_ClientesDes = New Modulo_Ventas.cp_Listview
        Me.Lbl_Origen = New System.Windows.Forms.Label
        Me.Lbl_TotalDes = New System.Windows.Forms.Label
        Me.Lbl_Destino = New System.Windows.Forms.Label
        Me.Lbl_TotalOri = New System.Windows.Forms.Label
        Me.Web_Mapa = New System.Windows.Forms.WebBrowser
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_OrigenPunto = New System.Windows.Forms.Button
        Me.Btn_PuntoPunto = New System.Windows.Forms.Button
        Me.Spt_MapaRutas.Panel1.SuspendLayout()
        Me.Spt_MapaRutas.Panel2.SuspendLayout()
        Me.Spt_MapaRutas.SuspendLayout()
        CType(Me.Pct_Origen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Destino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Spt_MapaRutas
        '
        Me.Spt_MapaRutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Spt_MapaRutas.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Spt_MapaRutas.Location = New System.Drawing.Point(5, 6)
        Me.Spt_MapaRutas.Name = "Spt_MapaRutas"
        '
        'Spt_MapaRutas.Panel1
        '
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Pct_Origen)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Pic_Destino)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Lsv_ClientesOri)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Lsv_ClientesDes)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Lbl_Origen)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Lbl_TotalDes)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Lbl_Destino)
        Me.Spt_MapaRutas.Panel1.Controls.Add(Me.Lbl_TotalOri)
        '
        'Spt_MapaRutas.Panel2
        '
        Me.Spt_MapaRutas.Panel2.Controls.Add(Me.Web_Mapa)
        Me.Spt_MapaRutas.Size = New System.Drawing.Size(972, 498)
        Me.Spt_MapaRutas.SplitterDistance = 454
        Me.Spt_MapaRutas.TabIndex = 0
        '
        'Pct_Origen
        '
        Me.Pct_Origen.Image = Global.Modulo_Ventas.My.Resources.Resources.ImagenPinA
        Me.Pct_Origen.InitialImage = Global.Modulo_Ventas.My.Resources.Resources.ImagenPinA
        Me.Pct_Origen.Location = New System.Drawing.Point(77, 3)
        Me.Pct_Origen.Name = "Pct_Origen"
        Me.Pct_Origen.Size = New System.Drawing.Size(21, 23)
        Me.Pct_Origen.TabIndex = 8
        Me.Pct_Origen.TabStop = False
        '
        'Pic_Destino
        '
        Me.Pic_Destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pic_Destino.Image = Global.Modulo_Ventas.My.Resources.Resources.ImagenPinB
        Me.Pic_Destino.InitialImage = Global.Modulo_Ventas.My.Resources.Resources.ImagenPinB
        Me.Pic_Destino.Location = New System.Drawing.Point(77, 130)
        Me.Pic_Destino.Name = "Pic_Destino"
        Me.Pic_Destino.Size = New System.Drawing.Size(21, 23)
        Me.Pic_Destino.TabIndex = 7
        Me.Pic_Destino.TabStop = False
        '
        'Lsv_ClientesOri
        '
        Me.Lsv_ClientesOri.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ClientesOri.FullRowSelect = True
        Me.Lsv_ClientesOri.HideSelection = False
        Me.Lsv_ClientesOri.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_ClientesOri.Lvs = ListViewColumnSorter1
        Me.Lsv_ClientesOri.MultiSelect = False
        Me.Lsv_ClientesOri.Name = "Lsv_ClientesOri"
        Me.Lsv_ClientesOri.Row1 = -1
        Me.Lsv_ClientesOri.Row10 = 10
        Me.Lsv_ClientesOri.Row2 = 40
        Me.Lsv_ClientesOri.Row3 = 0
        Me.Lsv_ClientesOri.Row4 = -1
        Me.Lsv_ClientesOri.Row5 = -1
        Me.Lsv_ClientesOri.Row6 = -1
        Me.Lsv_ClientesOri.Row7 = 10
        Me.Lsv_ClientesOri.Row8 = 10
        Me.Lsv_ClientesOri.Row9 = 10
        Me.Lsv_ClientesOri.Size = New System.Drawing.Size(445, 98)
        Me.Lsv_ClientesOri.TabIndex = 2
        Me.Lsv_ClientesOri.UseCompatibleStateImageBehavior = False
        Me.Lsv_ClientesOri.View = System.Windows.Forms.View.Details
        '
        'Lsv_ClientesDes
        '
        Me.Lsv_ClientesDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ClientesDes.FullRowSelect = True
        Me.Lsv_ClientesDes.HideSelection = False
        Me.Lsv_ClientesDes.Location = New System.Drawing.Point(6, 156)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_ClientesDes.Lvs = ListViewColumnSorter2
        Me.Lsv_ClientesDes.MultiSelect = False
        Me.Lsv_ClientesDes.Name = "Lsv_ClientesDes"
        Me.Lsv_ClientesDes.Row1 = -1
        Me.Lsv_ClientesDes.Row10 = 10
        Me.Lsv_ClientesDes.Row2 = 40
        Me.Lsv_ClientesDes.Row3 = 0
        Me.Lsv_ClientesDes.Row4 = -1
        Me.Lsv_ClientesDes.Row5 = -1
        Me.Lsv_ClientesDes.Row6 = -1
        Me.Lsv_ClientesDes.Row7 = 10
        Me.Lsv_ClientesDes.Row8 = 10
        Me.Lsv_ClientesDes.Row9 = 10
        Me.Lsv_ClientesDes.Size = New System.Drawing.Size(445, 339)
        Me.Lsv_ClientesDes.TabIndex = 5
        Me.Lsv_ClientesDes.UseCompatibleStateImageBehavior = False
        Me.Lsv_ClientesDes.View = System.Windows.Forms.View.Details
        '
        'Lbl_Origen
        '
        Me.Lbl_Origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Origen.Location = New System.Drawing.Point(9, 3)
        Me.Lbl_Origen.Name = "Lbl_Origen"
        Me.Lbl_Origen.Size = New System.Drawing.Size(67, 23)
        Me.Lbl_Origen.TabIndex = 0
        Me.Lbl_Origen.Text = "Origen"
        Me.Lbl_Origen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TotalDes
        '
        Me.Lbl_TotalDes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalDes.Location = New System.Drawing.Point(288, 130)
        Me.Lbl_TotalDes.Name = "Lbl_TotalDes"
        Me.Lbl_TotalDes.Size = New System.Drawing.Size(163, 23)
        Me.Lbl_TotalDes.TabIndex = 4
        Me.Lbl_TotalDes.Text = "Total: 0"
        Me.Lbl_TotalDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Destino
        '
        Me.Lbl_Destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Destino.Location = New System.Drawing.Point(9, 130)
        Me.Lbl_Destino.Name = "Lbl_Destino"
        Me.Lbl_Destino.Size = New System.Drawing.Size(74, 23)
        Me.Lbl_Destino.TabIndex = 3
        Me.Lbl_Destino.Text = "Destino"
        Me.Lbl_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TotalOri
        '
        Me.Lbl_TotalOri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalOri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalOri.Location = New System.Drawing.Point(292, 3)
        Me.Lbl_TotalOri.Name = "Lbl_TotalOri"
        Me.Lbl_TotalOri.Size = New System.Drawing.Size(159, 23)
        Me.Lbl_TotalOri.TabIndex = 1
        Me.Lbl_TotalOri.Text = "Total: 0"
        Me.Lbl_TotalOri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Web_Mapa
        '
        Me.Web_Mapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Web_Mapa.Location = New System.Drawing.Point(4, 3)
        Me.Web_Mapa.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web_Mapa.Name = "Web_Mapa"
        Me.Web_Mapa.Size = New System.Drawing.Size(507, 492)
        Me.Web_Mapa.TabIndex = 0
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_OrigenPunto)
        Me.Gbx_Botones.Controls.Add(Me.Btn_PuntoPunto)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(972, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(826, 14)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 2
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_OrigenPunto
        '
        Me.Btn_OrigenPunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_OrigenPunto.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow
        Me.Btn_OrigenPunto.Location = New System.Drawing.Point(152, 14)
        Me.Btn_OrigenPunto.Name = "Btn_OrigenPunto"
        Me.Btn_OrigenPunto.Size = New System.Drawing.Size(140, 30)
        Me.Btn_OrigenPunto.TabIndex = 1
        Me.Btn_OrigenPunto.Text = "&Desde Central"
        Me.Btn_OrigenPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_OrigenPunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_OrigenPunto.UseVisualStyleBackColor = True
        '
        'Btn_PuntoPunto
        '
        Me.Btn_PuntoPunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_PuntoPunto.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow
        Me.Btn_PuntoPunto.Location = New System.Drawing.Point(6, 14)
        Me.Btn_PuntoPunto.Name = "Btn_PuntoPunto"
        Me.Btn_PuntoPunto.Size = New System.Drawing.Size(140, 30)
        Me.Btn_PuntoPunto.TabIndex = 0
        Me.Btn_PuntoPunto.Text = "&Punto a Punto"
        Me.Btn_PuntoPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_PuntoPunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_PuntoPunto.UseVisualStyleBackColor = True
        '
        'frm_MapaRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Spt_MapaRutas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_MapaRutas"
        Me.Tag = "COMO LLEGAR"
        Me.Text = "Como Llegar"
        Me.Spt_MapaRutas.Panel1.ResumeLayout(False)
        Me.Spt_MapaRutas.Panel2.ResumeLayout(False)
        Me.Spt_MapaRutas.ResumeLayout(False)
        CType(Me.Pct_Origen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Destino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Spt_MapaRutas As System.Windows.Forms.SplitContainer
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_OrigenPunto As System.Windows.Forms.Button
    Friend WithEvents Btn_PuntoPunto As System.Windows.Forms.Button
    Friend WithEvents Lbl_TotalOri As System.Windows.Forms.Label
    Friend WithEvents Web_Mapa As System.Windows.Forms.WebBrowser
    Friend WithEvents Lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents Lbl_TotalDes As System.Windows.Forms.Label
    Friend WithEvents Lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents Lsv_ClientesOri As Modulo_Ventas.cp_Listview
    Friend WithEvents Lsv_ClientesDes As Modulo_Ventas.cp_Listview
    Friend WithEvents Pic_Destino As System.Windows.Forms.PictureBox
    Friend WithEvents Pct_Origen As System.Windows.Forms.PictureBox
End Class
