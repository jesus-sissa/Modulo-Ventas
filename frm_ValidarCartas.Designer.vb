<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValidarCartas
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
        Me.gbx_Carta = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Cartas = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Detalle = New Modulo_Ventas.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Reimprimir = New System.Windows.Forms.Button
        Me.btn_Enviar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Carta.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Carta
        '
        Me.gbx_Carta.Controls.Add(Me.lbl_Registros)
        Me.gbx_Carta.Controls.Add(Me.lsv_Cartas)
        Me.gbx_Carta.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Carta.Controls.Add(Me.btn_Buscar)
        Me.gbx_Carta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Carta.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Carta.Name = "gbx_Carta"
        Me.gbx_Carta.Size = New System.Drawing.Size(776, 246)
        Me.gbx_Carta.TabIndex = 0
        Me.gbx_Carta.TabStop = False
        Me.gbx_Carta.Text = "Cartas"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(630, 42)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 13)
        Me.lbl_Registros.TabIndex = 33
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Cartas
        '
        Me.lsv_Cartas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cartas.FullRowSelect = True
        Me.lsv_Cartas.HideSelection = False
        Me.lsv_Cartas.Location = New System.Drawing.Point(9, 58)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Cartas.Lvs = ListViewColumnSorter1
        Me.lsv_Cartas.MultiSelect = False
        Me.lsv_Cartas.Name = "lsv_Cartas"
        Me.lsv_Cartas.Row1 = 15
        Me.lsv_Cartas.Row10 = 0
        Me.lsv_Cartas.Row2 = 65
        Me.lsv_Cartas.Row3 = 10
        Me.lsv_Cartas.Row4 = 0
        Me.lsv_Cartas.Row5 = 0
        Me.lsv_Cartas.Row6 = 0
        Me.lsv_Cartas.Row7 = 0
        Me.lsv_Cartas.Row8 = 0
        Me.lsv_Cartas.Row9 = 0
        Me.lsv_Cartas.Size = New System.Drawing.Size(761, 182)
        Me.lsv_Cartas.TabIndex = 2
        Me.lsv_Cartas.UseCompatibleStateImageBehavior = False
        Me.lsv_Cartas.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(9, 19)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 0
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(583, 16)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 1
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Controls.Add(Me.Lbl_Registros2)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.gbx_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Detalle.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(776, 242)
        Me.gbx_Detalle.TabIndex = 1
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle"
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Registros2.Location = New System.Drawing.Point(630, 16)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(140, 13)
        Me.Lbl_Registros2.TabIndex = 34
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(8, 37)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter2
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 7
        Me.lsv_Detalle.Row10 = 8
        Me.lsv_Detalle.Row2 = 15
        Me.lsv_Detalle.Row3 = 10
        Me.lsv_Detalle.Row4 = 10
        Me.lsv_Detalle.Row5 = 10
        Me.lsv_Detalle.Row6 = 10
        Me.lsv_Detalle.Row7 = 10
        Me.lsv_Detalle.Row8 = 10
        Me.lsv_Detalle.Row9 = 10
        Me.lsv_Detalle.Size = New System.Drawing.Size(762, 199)
        Me.lsv_Detalle.TabIndex = 3
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Reimprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Enviar)
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 501)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(776, 54)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 16)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 16
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(155, 16)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Reimprimir
        '
        Me.btn_Reimprimir.Enabled = False
        Me.btn_Reimprimir.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_Reimprimir.Location = New System.Drawing.Point(301, 16)
        Me.btn_Reimprimir.Name = "btn_Reimprimir"
        Me.btn_Reimprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Reimprimir.TabIndex = 6
        Me.btn_Reimprimir.Text = "Reimprimir"
        Me.btn_Reimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Reimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Reimprimir.UseVisualStyleBackColor = True
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Image = Global.Modulo_Ventas.My.Resources.Resources.Enviar
        Me.btn_Enviar.Location = New System.Drawing.Point(447, 16)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Enviar.TabIndex = 7
        Me.btn_Enviar.Text = "Enviar"
        Me.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Enviar.UseVisualStyleBackColor = True
        Me.btn_Enviar.Visible = False
        '
        'btn_Validar
        '
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(9, 16)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 4
        Me.btn_Validar.Text = "Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Carta)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Detalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 492)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 3
        '
        'frm_ValidarCartas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ValidarCartas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Cartas de Aumento"
        Me.gbx_Carta.ResumeLayout(False)
        Me.gbx_Carta.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Carta As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Detalle As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lsv_Cartas As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Reimprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
