<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ContratosClausulas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbx_Agregar = New System.Windows.Forms.GroupBox
        Me.dgv_Clausulas = New System.Windows.Forms.DataGridView
        Me.Id_Clausula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.btn_Regresar = New System.Windows.Forms.Button
        Me.gbx_Agregados = New System.Windows.Forms.GroupBox
        Me.btn_Bajar = New System.Windows.Forms.Button
        Me.btn_Subir = New System.Windows.Forms.Button
        Me.dgv_Agregados = New System.Windows.Forms.DataGridView
        Me.btn_Quitar = New System.Windows.Forms.Button
        Me.spt_DataGrid = New System.Windows.Forms.SplitContainer
        Me.Id_ClausulaD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_ContratoD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcarA = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DescripcionA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentariosA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Numero_Clausula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Numero_Ordinario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_Agregar.SuspendLayout()
        CType(Me.dgv_Clausulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Agregados.SuspendLayout()
        CType(Me.dgv_Agregados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spt_DataGrid.Panel1.SuspendLayout()
        Me.spt_DataGrid.Panel2.SuspendLayout()
        Me.spt_DataGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Agregar
        '
        Me.gbx_Agregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Agregar.Controls.Add(Me.dgv_Clausulas)
        Me.gbx_Agregar.Controls.Add(Me.btn_Agregar)
        Me.gbx_Agregar.Location = New System.Drawing.Point(9, 9)
        Me.gbx_Agregar.Name = "gbx_Agregar"
        Me.gbx_Agregar.Size = New System.Drawing.Size(859, 314)
        Me.gbx_Agregar.TabIndex = 0
        Me.gbx_Agregar.TabStop = False
        Me.gbx_Agregar.Text = "Clausulas"
        '
        'dgv_Clausulas
        '
        Me.dgv_Clausulas.AllowUserToAddRows = False
        Me.dgv_Clausulas.AllowUserToDeleteRows = False
        Me.dgv_Clausulas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Clausulas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Clausulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Clausulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Clausula, Me.Marcar, Me.Descripcion, Me.Comentarios, Me.Status})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Clausulas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Clausulas.Location = New System.Drawing.Point(6, 16)
        Me.dgv_Clausulas.MultiSelect = False
        Me.dgv_Clausulas.Name = "dgv_Clausulas"
        Me.dgv_Clausulas.RowHeadersVisible = False
        Me.dgv_Clausulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Clausulas.Size = New System.Drawing.Size(847, 251)
        Me.dgv_Clausulas.TabIndex = 0
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
        Me.Marcar.HeaderText = ""
        Me.Marcar.Name = "Marcar"
        Me.Marcar.Width = 25
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descripcion.Width = 300
        '
        'Comentarios
        '
        Me.Comentarios.DataPropertyName = "Comentarios"
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.ReadOnly = True
        Me.Comentarios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Comentarios.Width = 300
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Status.Width = 75
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(6, 273)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 1
        Me.btn_Agregar.Text = " Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Regresar
        '
        Me.btn_Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Regresar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Regresar.Location = New System.Drawing.Point(713, 159)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Regresar.TabIndex = 2
        Me.btn_Regresar.Text = "Cerrar"
        Me.btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Regresar.UseVisualStyleBackColor = True
        '
        'gbx_Agregados
        '
        Me.gbx_Agregados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Agregados.Controls.Add(Me.btn_Bajar)
        Me.gbx_Agregados.Controls.Add(Me.btn_Subir)
        Me.gbx_Agregados.Controls.Add(Me.btn_Regresar)
        Me.gbx_Agregados.Controls.Add(Me.dgv_Agregados)
        Me.gbx_Agregados.Controls.Add(Me.btn_Quitar)
        Me.gbx_Agregados.Location = New System.Drawing.Point(9, 3)
        Me.gbx_Agregados.Name = "gbx_Agregados"
        Me.gbx_Agregados.Size = New System.Drawing.Size(859, 197)
        Me.gbx_Agregados.TabIndex = 0
        Me.gbx_Agregados.TabStop = False
        Me.gbx_Agregados.Text = "Agregados"
        '
        'btn_Bajar
        '
        Me.btn_Bajar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Bajar.Enabled = False
        Me.btn_Bajar.Image = Global.Modulo_Ventas.My.Resources.Resources.Bajar
        Me.btn_Bajar.Location = New System.Drawing.Point(423, 161)
        Me.btn_Bajar.Name = "btn_Bajar"
        Me.btn_Bajar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Bajar.TabIndex = 3
        Me.btn_Bajar.Text = " Bajar"
        Me.btn_Bajar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Bajar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Bajar.UseVisualStyleBackColor = True
        '
        'btn_Subir
        '
        Me.btn_Subir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Subir.Enabled = False
        Me.btn_Subir.Image = Global.Modulo_Ventas.My.Resources.Resources.Subir
        Me.btn_Subir.Location = New System.Drawing.Point(277, 161)
        Me.btn_Subir.Name = "btn_Subir"
        Me.btn_Subir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Subir.TabIndex = 2
        Me.btn_Subir.Text = "Subir"
        Me.btn_Subir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Subir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Subir.UseVisualStyleBackColor = True
        '
        'dgv_Agregados
        '
        Me.dgv_Agregados.AllowUserToAddRows = False
        Me.dgv_Agregados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Agregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Agregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Agregados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_ClausulaD, Me.Id_ContratoD, Me.MarcarA, Me.DescripcionA, Me.ComentariosA, Me.Numero_Clausula, Me.Numero_Ordinario})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Agregados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Agregados.Location = New System.Drawing.Point(6, 19)
        Me.dgv_Agregados.MultiSelect = False
        Me.dgv_Agregados.Name = "dgv_Agregados"
        Me.dgv_Agregados.RowHeadersVisible = False
        Me.dgv_Agregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Agregados.Size = New System.Drawing.Size(847, 135)
        Me.dgv_Agregados.TabIndex = 0
        '
        'btn_Quitar
        '
        Me.btn_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Quitar.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.btn_Quitar.Location = New System.Drawing.Point(6, 159)
        Me.btn_Quitar.Name = "btn_Quitar"
        Me.btn_Quitar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Quitar.TabIndex = 1
        Me.btn_Quitar.Text = "Remover"
        Me.btn_Quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Quitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Quitar.UseVisualStyleBackColor = True
        '
        'spt_DataGrid
        '
        Me.spt_DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spt_DataGrid.Location = New System.Drawing.Point(3, 3)
        Me.spt_DataGrid.Name = "spt_DataGrid"
        Me.spt_DataGrid.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spt_DataGrid.Panel1
        '
        Me.spt_DataGrid.Panel1.Controls.Add(Me.gbx_Agregar)
        '
        'spt_DataGrid.Panel2
        '
        Me.spt_DataGrid.Panel2.Controls.Add(Me.gbx_Agregados)
        Me.spt_DataGrid.Size = New System.Drawing.Size(875, 539)
        Me.spt_DataGrid.SplitterDistance = 326
        Me.spt_DataGrid.TabIndex = 0
        '
        'Id_ClausulaD
        '
        Me.Id_ClausulaD.DataPropertyName = "Id_Clausula"
        Me.Id_ClausulaD.HeaderText = "Id_Clausula"
        Me.Id_ClausulaD.Name = "Id_ClausulaD"
        Me.Id_ClausulaD.ReadOnly = True
        Me.Id_ClausulaD.Visible = False
        '
        'Id_ContratoD
        '
        Me.Id_ContratoD.DataPropertyName = "Id_ContratoD"
        Me.Id_ContratoD.HeaderText = "Id_ContratoD"
        Me.Id_ContratoD.Name = "Id_ContratoD"
        Me.Id_ContratoD.ReadOnly = True
        Me.Id_ContratoD.Visible = False
        '
        'MarcarA
        '
        Me.MarcarA.HeaderText = ""
        Me.MarcarA.Name = "MarcarA"
        Me.MarcarA.Width = 25
        '
        'DescripcionA
        '
        Me.DescripcionA.DataPropertyName = "Descripcion"
        Me.DescripcionA.HeaderText = "Descripcion"
        Me.DescripcionA.Name = "DescripcionA"
        Me.DescripcionA.ReadOnly = True
        Me.DescripcionA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DescripcionA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DescripcionA.Width = 300
        '
        'ComentariosA
        '
        Me.ComentariosA.DataPropertyName = "Comentarios"
        Me.ComentariosA.HeaderText = "Comentarios"
        Me.ComentariosA.Name = "ComentariosA"
        Me.ComentariosA.ReadOnly = True
        Me.ComentariosA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ComentariosA.Width = 300
        '
        'Numero_Clausula
        '
        Me.Numero_Clausula.DataPropertyName = "Numero_Clausula"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Numero_Clausula.DefaultCellStyle = DataGridViewCellStyle2
        Me.Numero_Clausula.HeaderText = "Orden"
        Me.Numero_Clausula.Name = "Numero_Clausula"
        Me.Numero_Clausula.ReadOnly = True
        Me.Numero_Clausula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Numero_Clausula.Width = 50
        '
        'Numero_Ordinario
        '
        Me.Numero_Ordinario.DataPropertyName = "Numero_Ordinario"
        Me.Numero_Ordinario.HeaderText = "Numero_Ordinario"
        Me.Numero_Ordinario.Name = "Numero_Ordinario"
        Me.Numero_Ordinario.ReadOnly = True
        Me.Numero_Ordinario.Visible = False
        '
        'frm_ContratosClausulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 545)
        Me.Controls.Add(Me.spt_DataGrid)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "frm_ContratosClausulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clausulas del Contrato"
        Me.gbx_Agregar.ResumeLayout(False)
        CType(Me.dgv_Clausulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Agregados.ResumeLayout(False)
        CType(Me.dgv_Agregados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spt_DataGrid.Panel1.ResumeLayout(False)
        Me.spt_DataGrid.Panel2.ResumeLayout(False)
        Me.spt_DataGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Agregar As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Clausulas As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_Agregados As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Agregados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Quitar As System.Windows.Forms.Button
    Friend WithEvents spt_DataGrid As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_Regresar As System.Windows.Forms.Button
    Friend WithEvents Id_Clausula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marcar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Bajar As System.Windows.Forms.Button
    Friend WithEvents btn_Subir As System.Windows.Forms.Button
    Friend WithEvents Id_ClausulaD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_ContratoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcarA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescripcionA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentariosA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero_Clausula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero_Ordinario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
