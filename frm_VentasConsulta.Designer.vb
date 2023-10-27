<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VentasConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VentasConsulta))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Dim ListViewColumnSorter3 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.cbx_Status = New System.Windows.Forms.CheckBox()
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lsv_Datos = New Modulo_Ventas.cp_Listview()
        Me.gbx_Desglose = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lsv_Folios = New Modulo_Ventas.cp_Listview()
        Me.lsv_Detalle = New Modulo_Ventas.cp_Listview()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Parametros.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.gbx_Desglose.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 481)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(703, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(557, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Status)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Status)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Status)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Location = New System.Drawing.Point(5, 2)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(703, 66)
        Me.gbx_Parametros.TabIndex = 0
        Me.gbx_Parametros.TabStop = False
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(205, 12)
        Me.dtp_Hasta.MinDate = New Date(2009, 8, 13, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(50, 12)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(368, 30)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cbx_Status
        '
        Me.cbx_Status.AutoSize = True
        Me.cbx_Status.Location = New System.Drawing.Point(306, 40)
        Me.cbx_Status.Name = "cbx_Status"
        Me.cbx_Status.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Status.TabIndex = 6
        Me.cbx_Status.Text = "Todos"
        Me.cbx_Status.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(50, 38)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(250, 21)
        Me.cmb_Status.TabIndex = 5
        Me.cmb_Status.ValueMember = "value"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(7, 41)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 4
        Me.lbl_Status.Text = "Status"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(164, 16)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotaciones.Controls.Add(Me.lbl_Total)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Datos)
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(5, 74)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(703, 186)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(557, 16)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(140, 13)
        Me.lbl_Total.TabIndex = 0
        Me.lbl_Total.Text = "Total Ventas: 0"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(5, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 7
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 7
        Me.lsv_Datos.Row3 = 6
        Me.lsv_Datos.Row4 = 22
        Me.lsv_Datos.Row5 = 6
        Me.lsv_Datos.Row6 = 6
        Me.lsv_Datos.Row7 = 18
        Me.lsv_Datos.Row8 = 7
        Me.lsv_Datos.Row9 = 19
        Me.lsv_Datos.Size = New System.Drawing.Size(692, 147)
        Me.lsv_Datos.TabIndex = 1
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'gbx_Desglose
        '
        Me.gbx_Desglose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Desglose.Controls.Add(Me.TableLayoutPanel1)
        Me.gbx_Desglose.Location = New System.Drawing.Point(5, 262)
        Me.gbx_Desglose.Name = "gbx_Desglose"
        Me.gbx_Desglose.Size = New System.Drawing.Size(703, 220)
        Me.gbx_Desglose.TabIndex = 2
        Me.gbx_Desglose.TabStop = False
        Me.gbx_Desglose.Text = "Detalle"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lsv_Folios, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lsv_Detalle, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 194)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lsv_Folios
        '
        Me.lsv_Folios.AllowColumnReorder = True
        Me.lsv_Folios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Folios.FullRowSelect = True
        Me.lsv_Folios.HideSelection = False
        Me.lsv_Folios.Location = New System.Drawing.Point(347, 3)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Folios.Lvs = ListViewColumnSorter2
        Me.lsv_Folios.MultiSelect = False
        Me.lsv_Folios.Name = "lsv_Folios"
        Me.lsv_Folios.Row1 = 30
        Me.lsv_Folios.Row10 = 0
        Me.lsv_Folios.Row2 = 20
        Me.lsv_Folios.Row3 = 20
        Me.lsv_Folios.Row4 = 20
        Me.lsv_Folios.Row5 = 0
        Me.lsv_Folios.Row6 = 0
        Me.lsv_Folios.Row7 = 0
        Me.lsv_Folios.Row8 = 0
        Me.lsv_Folios.Row9 = 0
        Me.lsv_Folios.Size = New System.Drawing.Size(338, 188)
        Me.lsv_Folios.TabIndex = 1
        Me.lsv_Folios.UseCompatibleStateImageBehavior = False
        Me.lsv_Folios.View = System.Windows.Forms.View.Details
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.AllowColumnReorder = True
        Me.lsv_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter3
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 20
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 50
        Me.lsv_Detalle.Row3 = 25
        Me.lsv_Detalle.Row4 = 0
        Me.lsv_Detalle.Row5 = 0
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(338, 188)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'frm_VentasConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(714, 539)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Desglose)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_VentasConsulta"
        Me.Text = "Consulta de Ventas de Material"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Desglose.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Desglose As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Ventas.cp_Listview
    Friend WithEvents lsv_Detalle As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cbx_Status As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents lsv_Folios As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
