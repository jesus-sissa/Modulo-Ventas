<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Clausulas
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Clausulas))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbx_ClausulaDg = New System.Windows.Forms.GroupBox
        Me.chk_Clausula = New System.Windows.Forms.CheckBox
        Me.dgv_Clausula = New System.Windows.Forms.DataGridView
        Me.Id_Clausula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_BotonesD = New System.Windows.Forms.GroupBox
        Me.btn_ModificarSC = New System.Windows.Forms.Button
        Me.btn_StatusSC = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_DescripcionC = New System.Windows.Forms.Label
        Me.rtb_DescripcionC = New System.Windows.Forms.RichTextBox
        Me.btn_GuardarC = New System.Windows.Forms.Button
        Me.lbl_ComentariosC = New System.Windows.Forms.Label
        Me.gbx_Clausula = New System.Windows.Forms.GroupBox
        Me.btn_CancelarC = New System.Windows.Forms.Button
        Me.tbx_ComentariosC = New System.Windows.Forms.TextBox
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.gbx_DellateC = New System.Windows.Forms.GroupBox
        Me.chk_DetalleC = New System.Windows.Forms.CheckBox
        Me.dgv_DetalleC = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_CancelarD = New System.Windows.Forms.Button
        Me.tbx_ComentariosD = New System.Windows.Forms.TextBox
        Me.lbl_ComentariosD = New System.Windows.Forms.Label
        Me.btn_GuardarSC = New System.Windows.Forms.Button
        Me.rtb_DescripcionD = New System.Windows.Forms.RichTextBox
        Me.lbl_DescripcionD = New System.Windows.Forms.Label
        Me.gbx_BotonesC = New System.Windows.Forms.GroupBox
        Me.btn_DetalleC = New System.Windows.Forms.Button
        Me.btn_ModificarC = New System.Windows.Forms.Button
        Me.btn_StatusC = New System.Windows.Forms.Button
        Me.tab_Clausulas = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.gbx_DetalleDg = New System.Windows.Forms.GroupBox
        Me.chk_Detalle = New System.Windows.Forms.CheckBox
        Me.dgv_Detalle = New System.Windows.Forms.DataGridView
        Me.Id_ClausulaD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcarD = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DescripcionD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentariosD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tab_ClausulaNueva = New System.Windows.Forms.TabPage
        Me.tab_SubClausulaNueva = New System.Windows.Forms.TabPage
        Me.gbx_ClausulaDg.SuspendLayout()
        CType(Me.dgv_Clausula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_BotonesD.SuspendLayout()
        Me.gbx_Clausula.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_DellateC.SuspendLayout()
        CType(Me.dgv_DetalleC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_BotonesC.SuspendLayout()
        Me.tab_Clausulas.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.gbx_DetalleDg.SuspendLayout()
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_ClausulaNueva.SuspendLayout()
        Me.tab_SubClausulaNueva.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_ClausulaDg
        '
        Me.gbx_ClausulaDg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ClausulaDg.Controls.Add(Me.chk_Clausula)
        Me.gbx_ClausulaDg.Controls.Add(Me.dgv_Clausula)
        Me.gbx_ClausulaDg.Location = New System.Drawing.Point(6, 2)
        Me.gbx_ClausulaDg.Name = "gbx_ClausulaDg"
        Me.gbx_ClausulaDg.Size = New System.Drawing.Size(762, 205)
        Me.gbx_ClausulaDg.TabIndex = 0
        Me.gbx_ClausulaDg.TabStop = False
        '
        'chk_Clausula
        '
        Me.chk_Clausula.AutoSize = True
        Me.chk_Clausula.Checked = True
        Me.chk_Clausula.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Clausula.Location = New System.Drawing.Point(9, 12)
        Me.chk_Clausula.Name = "chk_Clausula"
        Me.chk_Clausula.Size = New System.Drawing.Size(85, 17)
        Me.chk_Clausula.TabIndex = 0
        Me.chk_Clausula.Text = "Solo Activos"
        Me.chk_Clausula.UseVisualStyleBackColor = True
        '
        'dgv_Clausula
        '
        Me.dgv_Clausula.AllowUserToAddRows = False
        Me.dgv_Clausula.AllowUserToDeleteRows = False
        Me.dgv_Clausula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Clausula.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Clausula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Clausula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Clausula, Me.Marcar, Me.Descripcion, Me.Comentarios, Me.Status})
        Me.dgv_Clausula.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgv_Clausula.Location = New System.Drawing.Point(6, 35)
        Me.dgv_Clausula.MultiSelect = False
        Me.dgv_Clausula.Name = "dgv_Clausula"
        Me.dgv_Clausula.RowHeadersVisible = False
        Me.dgv_Clausula.RowHeadersWidth = 30
        Me.dgv_Clausula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Clausula.Size = New System.Drawing.Size(750, 164)
        Me.dgv_Clausula.TabIndex = 1
        Me.dgv_Clausula.Tag = "1"
        '
        'Id_Clausula
        '
        Me.Id_Clausula.DataPropertyName = "Id_Clausula"
        Me.Id_Clausula.HeaderText = "Id_Clausula"
        Me.Id_Clausula.Name = "Id_Clausula"
        Me.Id_Clausula.Visible = False
        '
        'Marcar
        '
        Me.Marcar.FalseValue = "0"
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Name = "Marcar"
        Me.Marcar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Marcar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Marcar.TrueValue = "1"
        Me.Marcar.Width = 50
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle9
        Me.Descripcion.HeaderText = "Descripion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.Width = 300
        '
        'Comentarios
        '
        Me.Comentarios.DataPropertyName = "Comentarios"
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Comentarios.DefaultCellStyle = DataGridViewCellStyle10
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.ReadOnly = True
        Me.Comentarios.Width = 300
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'gbx_BotonesD
        '
        Me.gbx_BotonesD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_BotonesD.Controls.Add(Me.btn_ModificarSC)
        Me.gbx_BotonesD.Controls.Add(Me.btn_StatusSC)
        Me.gbx_BotonesD.Controls.Add(Me.btn_Cerrar)
        Me.gbx_BotonesD.Location = New System.Drawing.Point(6, 478)
        Me.gbx_BotonesD.Name = "gbx_BotonesD"
        Me.gbx_BotonesD.Size = New System.Drawing.Size(762, 50)
        Me.gbx_BotonesD.TabIndex = 3
        Me.gbx_BotonesD.TabStop = False
        '
        'btn_ModificarSC
        '
        Me.btn_ModificarSC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ModificarSC.Enabled = False
        Me.btn_ModificarSC.Image = CType(resources.GetObject("btn_ModificarSC.Image"), System.Drawing.Image)
        Me.btn_ModificarSC.Location = New System.Drawing.Point(157, 14)
        Me.btn_ModificarSC.Name = "btn_ModificarSC"
        Me.btn_ModificarSC.Size = New System.Drawing.Size(145, 30)
        Me.btn_ModificarSC.TabIndex = 1
        Me.btn_ModificarSC.Text = "Editar"
        Me.btn_ModificarSC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ModificarSC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ModificarSC.UseVisualStyleBackColor = True
        '
        'btn_StatusSC
        '
        Me.btn_StatusSC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_StatusSC.Enabled = False
        Me.btn_StatusSC.Image = CType(resources.GetObject("btn_StatusSC.Image"), System.Drawing.Image)
        Me.btn_StatusSC.Location = New System.Drawing.Point(6, 14)
        Me.btn_StatusSC.Name = "btn_StatusSC"
        Me.btn_StatusSC.Size = New System.Drawing.Size(145, 30)
        Me.btn_StatusSC.TabIndex = 0
        Me.btn_StatusSC.Text = "Baja/Reingreso"
        Me.btn_StatusSC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_StatusSC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_StatusSC.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(611, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(145, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_DescripcionC
        '
        Me.lbl_DescripcionC.AutoSize = True
        Me.lbl_DescripcionC.Location = New System.Drawing.Point(3, 14)
        Me.lbl_DescripcionC.Name = "lbl_DescripcionC"
        Me.lbl_DescripcionC.Size = New System.Drawing.Size(63, 13)
        Me.lbl_DescripcionC.TabIndex = 0
        Me.lbl_DescripcionC.Text = "Descripcion"
        '
        'rtb_DescripcionC
        '
        Me.rtb_DescripcionC.Location = New System.Drawing.Point(6, 30)
        Me.rtb_DescripcionC.Name = "rtb_DescripcionC"
        Me.rtb_DescripcionC.Size = New System.Drawing.Size(486, 138)
        Me.rtb_DescripcionC.TabIndex = 1
        Me.rtb_DescripcionC.Text = ""
        '
        'btn_GuardarC
        '
        Me.btn_GuardarC.Image = CType(resources.GetObject("btn_GuardarC.Image"), System.Drawing.Image)
        Me.btn_GuardarC.Location = New System.Drawing.Point(6, 200)
        Me.btn_GuardarC.Name = "btn_GuardarC"
        Me.btn_GuardarC.Size = New System.Drawing.Size(145, 30)
        Me.btn_GuardarC.TabIndex = 4
        Me.btn_GuardarC.Text = "Guardar"
        Me.btn_GuardarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarC.UseVisualStyleBackColor = True
        '
        'lbl_ComentariosC
        '
        Me.lbl_ComentariosC.AutoSize = True
        Me.lbl_ComentariosC.Location = New System.Drawing.Point(3, 177)
        Me.lbl_ComentariosC.Name = "lbl_ComentariosC"
        Me.lbl_ComentariosC.Size = New System.Drawing.Size(65, 13)
        Me.lbl_ComentariosC.TabIndex = 2
        Me.lbl_ComentariosC.Text = "Comentarios"
        '
        'gbx_Clausula
        '
        Me.gbx_Clausula.Controls.Add(Me.btn_CancelarC)
        Me.gbx_Clausula.Controls.Add(Me.tbx_ComentariosC)
        Me.gbx_Clausula.Controls.Add(Me.lbl_ComentariosC)
        Me.gbx_Clausula.Controls.Add(Me.btn_GuardarC)
        Me.gbx_Clausula.Controls.Add(Me.rtb_DescripcionC)
        Me.gbx_Clausula.Controls.Add(Me.lbl_DescripcionC)
        Me.gbx_Clausula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Clausula.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Clausula.Name = "gbx_Clausula"
        Me.gbx_Clausula.Size = New System.Drawing.Size(770, 530)
        Me.gbx_Clausula.TabIndex = 0
        Me.gbx_Clausula.TabStop = False
        Me.gbx_Clausula.Text = "Clausula"
        '
        'btn_CancelarC
        '
        Me.btn_CancelarC.Image = CType(resources.GetObject("btn_CancelarC.Image"), System.Drawing.Image)
        Me.btn_CancelarC.Location = New System.Drawing.Point(347, 200)
        Me.btn_CancelarC.Name = "btn_CancelarC"
        Me.btn_CancelarC.Size = New System.Drawing.Size(145, 30)
        Me.btn_CancelarC.TabIndex = 5
        Me.btn_CancelarC.Text = "Cancelar"
        Me.btn_CancelarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarC.UseVisualStyleBackColor = True
        '
        'tbx_ComentariosC
        '
        Me.tbx_ComentariosC.Location = New System.Drawing.Point(74, 174)
        Me.tbx_ComentariosC.Name = "tbx_ComentariosC"
        Me.tbx_ComentariosC.Size = New System.Drawing.Size(418, 20)
        Me.tbx_ComentariosC.TabIndex = 3
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Controls.Add(Me.gbx_DellateC)
        Me.gbx_Detalle.Controls.Add(Me.btn_CancelarD)
        Me.gbx_Detalle.Controls.Add(Me.tbx_ComentariosD)
        Me.gbx_Detalle.Controls.Add(Me.lbl_ComentariosD)
        Me.gbx_Detalle.Controls.Add(Me.btn_GuardarSC)
        Me.gbx_Detalle.Controls.Add(Me.rtb_DescripcionD)
        Me.gbx_Detalle.Controls.Add(Me.lbl_DescripcionD)
        Me.gbx_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Detalle.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(770, 530)
        Me.gbx_Detalle.TabIndex = 0
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "SubClausula"
        '
        'gbx_DellateC
        '
        Me.gbx_DellateC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DellateC.Controls.Add(Me.chk_DetalleC)
        Me.gbx_DellateC.Controls.Add(Me.dgv_DetalleC)
        Me.gbx_DellateC.Location = New System.Drawing.Point(4, 238)
        Me.gbx_DellateC.Name = "gbx_DellateC"
        Me.gbx_DellateC.Size = New System.Drawing.Size(762, 286)
        Me.gbx_DellateC.TabIndex = 6
        Me.gbx_DellateC.TabStop = False
        '
        'chk_DetalleC
        '
        Me.chk_DetalleC.AutoSize = True
        Me.chk_DetalleC.Checked = True
        Me.chk_DetalleC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_DetalleC.Location = New System.Drawing.Point(9, 12)
        Me.chk_DetalleC.Name = "chk_DetalleC"
        Me.chk_DetalleC.Size = New System.Drawing.Size(85, 17)
        Me.chk_DetalleC.TabIndex = 0
        Me.chk_DetalleC.Text = "Solo Activos"
        Me.chk_DetalleC.UseVisualStyleBackColor = True
        '
        'dgv_DetalleC
        '
        Me.dgv_DetalleC.AllowUserToAddRows = False
        Me.dgv_DetalleC.AllowUserToDeleteRows = False
        Me.dgv_DetalleC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_DetalleC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_DetalleC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DetalleC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_DetalleC.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_DetalleC.Location = New System.Drawing.Point(6, 35)
        Me.dgv_DetalleC.Name = "dgv_DetalleC"
        Me.dgv_DetalleC.RowHeadersVisible = False
        Me.dgv_DetalleC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_DetalleC.Size = New System.Drawing.Size(750, 245)
        Me.dgv_DetalleC.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_ClausulaD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_ClausulaD"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Comentarios"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comentarios"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'btn_CancelarD
        '
        Me.btn_CancelarD.Image = CType(resources.GetObject("btn_CancelarD.Image"), System.Drawing.Image)
        Me.btn_CancelarD.Location = New System.Drawing.Point(347, 200)
        Me.btn_CancelarD.Name = "btn_CancelarD"
        Me.btn_CancelarD.Size = New System.Drawing.Size(145, 30)
        Me.btn_CancelarD.TabIndex = 5
        Me.btn_CancelarD.Text = "Cancelar"
        Me.btn_CancelarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarD.UseVisualStyleBackColor = True
        '
        'tbx_ComentariosD
        '
        Me.tbx_ComentariosD.Location = New System.Drawing.Point(74, 174)
        Me.tbx_ComentariosD.Name = "tbx_ComentariosD"
        Me.tbx_ComentariosD.Size = New System.Drawing.Size(418, 20)
        Me.tbx_ComentariosD.TabIndex = 3
        '
        'lbl_ComentariosD
        '
        Me.lbl_ComentariosD.AutoSize = True
        Me.lbl_ComentariosD.Location = New System.Drawing.Point(3, 177)
        Me.lbl_ComentariosD.Name = "lbl_ComentariosD"
        Me.lbl_ComentariosD.Size = New System.Drawing.Size(65, 13)
        Me.lbl_ComentariosD.TabIndex = 2
        Me.lbl_ComentariosD.Text = "Comentarios"
        '
        'btn_GuardarSC
        '
        Me.btn_GuardarSC.Image = CType(resources.GetObject("btn_GuardarSC.Image"), System.Drawing.Image)
        Me.btn_GuardarSC.Location = New System.Drawing.Point(6, 200)
        Me.btn_GuardarSC.Name = "btn_GuardarSC"
        Me.btn_GuardarSC.Size = New System.Drawing.Size(145, 30)
        Me.btn_GuardarSC.TabIndex = 4
        Me.btn_GuardarSC.Text = "Guardar"
        Me.btn_GuardarSC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarSC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarSC.UseVisualStyleBackColor = True
        '
        'rtb_DescripcionD
        '
        Me.rtb_DescripcionD.Location = New System.Drawing.Point(6, 30)
        Me.rtb_DescripcionD.Name = "rtb_DescripcionD"
        Me.rtb_DescripcionD.Size = New System.Drawing.Size(486, 138)
        Me.rtb_DescripcionD.TabIndex = 1
        Me.rtb_DescripcionD.Text = ""
        '
        'lbl_DescripcionD
        '
        Me.lbl_DescripcionD.AutoSize = True
        Me.lbl_DescripcionD.Location = New System.Drawing.Point(3, 14)
        Me.lbl_DescripcionD.Name = "lbl_DescripcionD"
        Me.lbl_DescripcionD.Size = New System.Drawing.Size(63, 13)
        Me.lbl_DescripcionD.TabIndex = 0
        Me.lbl_DescripcionD.Text = "Descripcion"
        '
        'gbx_BotonesC
        '
        Me.gbx_BotonesC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_BotonesC.Controls.Add(Me.btn_DetalleC)
        Me.gbx_BotonesC.Controls.Add(Me.btn_ModificarC)
        Me.gbx_BotonesC.Controls.Add(Me.btn_StatusC)
        Me.gbx_BotonesC.Location = New System.Drawing.Point(6, 213)
        Me.gbx_BotonesC.Name = "gbx_BotonesC"
        Me.gbx_BotonesC.Size = New System.Drawing.Size(762, 50)
        Me.gbx_BotonesC.TabIndex = 1
        Me.gbx_BotonesC.TabStop = False
        '
        'btn_DetalleC
        '
        Me.btn_DetalleC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_DetalleC.Image = CType(resources.GetObject("btn_DetalleC.Image"), System.Drawing.Image)
        Me.btn_DetalleC.Location = New System.Drawing.Point(308, 14)
        Me.btn_DetalleC.Name = "btn_DetalleC"
        Me.btn_DetalleC.Size = New System.Drawing.Size(145, 30)
        Me.btn_DetalleC.TabIndex = 2
        Me.btn_DetalleC.Text = "Detalle"
        Me.btn_DetalleC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DetalleC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_DetalleC.UseVisualStyleBackColor = True
        '
        'btn_ModificarC
        '
        Me.btn_ModificarC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ModificarC.Image = CType(resources.GetObject("btn_ModificarC.Image"), System.Drawing.Image)
        Me.btn_ModificarC.Location = New System.Drawing.Point(157, 14)
        Me.btn_ModificarC.Name = "btn_ModificarC"
        Me.btn_ModificarC.Size = New System.Drawing.Size(145, 30)
        Me.btn_ModificarC.TabIndex = 1
        Me.btn_ModificarC.Text = "Editar"
        Me.btn_ModificarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ModificarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ModificarC.UseVisualStyleBackColor = True
        '
        'btn_StatusC
        '
        Me.btn_StatusC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_StatusC.Image = CType(resources.GetObject("btn_StatusC.Image"), System.Drawing.Image)
        Me.btn_StatusC.Location = New System.Drawing.Point(6, 14)
        Me.btn_StatusC.Name = "btn_StatusC"
        Me.btn_StatusC.Size = New System.Drawing.Size(145, 30)
        Me.btn_StatusC.TabIndex = 0
        Me.btn_StatusC.Text = "Baja/Reingreso"
        Me.btn_StatusC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_StatusC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_StatusC.UseVisualStyleBackColor = True
        '
        'tab_Clausulas
        '
        Me.tab_Clausulas.Controls.Add(Me.tab_Listado)
        Me.tab_Clausulas.Controls.Add(Me.tab_ClausulaNueva)
        Me.tab_Clausulas.Controls.Add(Me.tab_SubClausulaNueva)
        Me.tab_Clausulas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Clausulas.Location = New System.Drawing.Point(0, 0)
        Me.tab_Clausulas.Name = "tab_Clausulas"
        Me.tab_Clausulas.SelectedIndex = 0
        Me.tab_Clausulas.Size = New System.Drawing.Size(784, 562)
        Me.tab_Clausulas.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.gbx_ClausulaDg)
        Me.tab_Listado.Controls.Add(Me.gbx_BotonesD)
        Me.tab_Listado.Controls.Add(Me.gbx_BotonesC)
        Me.tab_Listado.Controls.Add(Me.gbx_DetalleDg)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 536)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listados"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'gbx_DetalleDg
        '
        Me.gbx_DetalleDg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DetalleDg.Controls.Add(Me.chk_Detalle)
        Me.gbx_DetalleDg.Controls.Add(Me.dgv_Detalle)
        Me.gbx_DetalleDg.Location = New System.Drawing.Point(6, 269)
        Me.gbx_DetalleDg.Name = "gbx_DetalleDg"
        Me.gbx_DetalleDg.Size = New System.Drawing.Size(762, 203)
        Me.gbx_DetalleDg.TabIndex = 2
        Me.gbx_DetalleDg.TabStop = False
        '
        'chk_Detalle
        '
        Me.chk_Detalle.AutoSize = True
        Me.chk_Detalle.Checked = True
        Me.chk_Detalle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Detalle.Location = New System.Drawing.Point(9, 12)
        Me.chk_Detalle.Name = "chk_Detalle"
        Me.chk_Detalle.Size = New System.Drawing.Size(85, 17)
        Me.chk_Detalle.TabIndex = 0
        Me.chk_Detalle.Text = "Solo Activos"
        Me.chk_Detalle.UseVisualStyleBackColor = True
        '
        'dgv_Detalle
        '
        Me.dgv_Detalle.AllowUserToAddRows = False
        Me.dgv_Detalle.AllowUserToDeleteRows = False
        Me.dgv_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Detalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_ClausulaD, Me.MarcarD, Me.DescripcionD, Me.ComentariosD, Me.StatusD})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Detalle.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_Detalle.Location = New System.Drawing.Point(6, 35)
        Me.dgv_Detalle.Name = "dgv_Detalle"
        Me.dgv_Detalle.RowHeadersVisible = False
        Me.dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Detalle.Size = New System.Drawing.Size(750, 162)
        Me.dgv_Detalle.TabIndex = 1
        Me.dgv_Detalle.Tag = "1"
        '
        'Id_ClausulaD
        '
        Me.Id_ClausulaD.DataPropertyName = "Id_ClausulaD"
        Me.Id_ClausulaD.HeaderText = "Id_ClausulaD"
        Me.Id_ClausulaD.Name = "Id_ClausulaD"
        Me.Id_ClausulaD.ReadOnly = True
        Me.Id_ClausulaD.Visible = False
        Me.Id_ClausulaD.Width = 5
        '
        'MarcarD
        '
        Me.MarcarD.HeaderText = "Marcar"
        Me.MarcarD.Name = "MarcarD"
        Me.MarcarD.Width = 50
        '
        'DescripcionD
        '
        Me.DescripcionD.DataPropertyName = "Descripcion"
        Me.DescripcionD.HeaderText = "Descripcion"
        Me.DescripcionD.Name = "DescripcionD"
        Me.DescripcionD.ReadOnly = True
        Me.DescripcionD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DescripcionD.Width = 300
        '
        'ComentariosD
        '
        Me.ComentariosD.DataPropertyName = "Comentarios"
        Me.ComentariosD.HeaderText = "Comentarios"
        Me.ComentariosD.Name = "ComentariosD"
        Me.ComentariosD.ReadOnly = True
        Me.ComentariosD.Width = 300
        '
        'StatusD
        '
        Me.StatusD.DataPropertyName = "Status"
        Me.StatusD.HeaderText = "Status"
        Me.StatusD.Name = "StatusD"
        Me.StatusD.ReadOnly = True
        '
        'tab_ClausulaNueva
        '
        Me.tab_ClausulaNueva.Controls.Add(Me.gbx_Clausula)
        Me.tab_ClausulaNueva.Location = New System.Drawing.Point(4, 22)
        Me.tab_ClausulaNueva.Name = "tab_ClausulaNueva"
        Me.tab_ClausulaNueva.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ClausulaNueva.Size = New System.Drawing.Size(776, 536)
        Me.tab_ClausulaNueva.TabIndex = 1
        Me.tab_ClausulaNueva.Text = "NuevaClausula"
        Me.tab_ClausulaNueva.UseVisualStyleBackColor = True
        '
        'tab_SubClausulaNueva
        '
        Me.tab_SubClausulaNueva.Controls.Add(Me.gbx_Detalle)
        Me.tab_SubClausulaNueva.Location = New System.Drawing.Point(4, 22)
        Me.tab_SubClausulaNueva.Name = "tab_SubClausulaNueva"
        Me.tab_SubClausulaNueva.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_SubClausulaNueva.Size = New System.Drawing.Size(776, 536)
        Me.tab_SubClausulaNueva.TabIndex = 2
        Me.tab_SubClausulaNueva.Text = "NuevaSubClausula"
        Me.tab_SubClausulaNueva.UseVisualStyleBackColor = True
        '
        'frm_Clausulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.tab_Clausulas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Clausulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Clausulas"
        Me.gbx_ClausulaDg.ResumeLayout(False)
        Me.gbx_ClausulaDg.PerformLayout()
        CType(Me.dgv_Clausula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_BotonesD.ResumeLayout(False)
        Me.gbx_Clausula.ResumeLayout(False)
        Me.gbx_Clausula.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Detalle.PerformLayout()
        Me.gbx_DellateC.ResumeLayout(False)
        Me.gbx_DellateC.PerformLayout()
        CType(Me.dgv_DetalleC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_BotonesC.ResumeLayout(False)
        Me.tab_Clausulas.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.gbx_DetalleDg.ResumeLayout(False)
        Me.gbx_DetalleDg.PerformLayout()
        CType(Me.dgv_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_ClausulaNueva.ResumeLayout(False)
        Me.tab_SubClausulaNueva.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_ClausulaDg As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Clausula As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_BotonesD As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_DescripcionC As System.Windows.Forms.Label
    Friend WithEvents rtb_DescripcionC As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_GuardarC As System.Windows.Forms.Button
    Friend WithEvents lbl_ComentariosC As System.Windows.Forms.Label
    Friend WithEvents gbx_Clausula As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ComentariosD As System.Windows.Forms.Label
    Friend WithEvents btn_GuardarSC As System.Windows.Forms.Button
    Friend WithEvents rtb_DescripcionD As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_DescripcionD As System.Windows.Forms.Label
    Friend WithEvents btn_ModificarSC As System.Windows.Forms.Button
    Friend WithEvents btn_StatusSC As System.Windows.Forms.Button
    Friend WithEvents gbx_BotonesC As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ModificarC As System.Windows.Forms.Button
    Friend WithEvents btn_StatusC As System.Windows.Forms.Button
    Friend WithEvents tab_Clausulas As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents tab_ClausulaNueva As System.Windows.Forms.TabPage
    Friend WithEvents tab_SubClausulaNueva As System.Windows.Forms.TabPage
    Friend WithEvents dgv_Clausula As System.Windows.Forms.DataGridView
    Friend WithEvents tbx_ComentariosC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ComentariosD As System.Windows.Forms.TextBox
    Friend WithEvents btn_CancelarC As System.Windows.Forms.Button
    Friend WithEvents btn_CancelarD As System.Windows.Forms.Button
    Friend WithEvents btn_DetalleC As System.Windows.Forms.Button
    Friend WithEvents gbx_DetalleDg As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Detalle As System.Windows.Forms.CheckBox
    Friend WithEvents dgv_Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_DellateC As System.Windows.Forms.GroupBox
    Friend WithEvents chk_DetalleC As System.Windows.Forms.CheckBox
    Friend WithEvents dgv_DetalleC As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Clausula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marcar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_ClausulaD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcarD As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescripcionD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentariosD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
