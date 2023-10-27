<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValidaHorarios
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
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.Btn_Valida = New System.Windows.Forms.Button
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.tbx_Clave = New System.Windows.Forms.TextBox
        Me.chk_CLiente = New System.Windows.Forms.CheckBox
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_Clientes = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Lsv_Horarios = New Modulo_Ventas.cp_Listview
        Me.Lbl_Comentario = New System.Windows.Forms.Label
        Me.gbx_Horarios = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.tbx_Comentario = New Modulo_Ventas.cp_Textbox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.gbx_Horarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cancelar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Eliminar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Valida)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 507)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(766, 47)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(620, 11)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 2
        Me.Btn_Cancelar.Text = "&Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(155, 11)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 1
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Valida
        '
        Me.Btn_Valida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Valida.Enabled = False
        Me.Btn_Valida.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.Btn_Valida.Location = New System.Drawing.Point(9, 11)
        Me.Btn_Valida.Name = "Btn_Valida"
        Me.Btn_Valida.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Valida.TabIndex = 0
        Me.Btn_Valida.Text = "&Validar"
        Me.Btn_Valida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Valida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Valida.UseVisualStyleBackColor = True
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Clave)
        Me.Gbx_Filtro.Controls.Add(Me.chk_CLiente)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Cliente)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Clientes)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(9, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(766, 47)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Location = New System.Drawing.Point(56, 18)
        Me.tbx_Clave.MaxLength = 10
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Clave.TabIndex = 3
        '
        'chk_CLiente
        '
        Me.chk_CLiente.AutoSize = True
        Me.chk_CLiente.Location = New System.Drawing.Point(462, 20)
        Me.chk_CLiente.Name = "chk_CLiente"
        Me.chk_CLiente.Size = New System.Drawing.Size(116, 17)
        Me.chk_CLiente.TabIndex = 2
        Me.chk_CLiente.Text = "Incluir Sub Clientes"
        Me.chk_CLiente.UseVisualStyleBackColor = True
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(11, 21)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 0
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave"
        Me.cmb_Clientes.Control_Siguiente = Me.Lsv_Horarios
        Me.cmb_Clientes.DisplayMember = "Nombre"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.tbx_Clave
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(112, 18)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(344, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_clientesHorariosTemp_ComboClienteGet"
        Me.cmb_Clientes.Sucursal = False
        Me.cmb_Clientes.TabIndex = 1
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'Lsv_Horarios
        '
        Me.Lsv_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Horarios.CheckBoxes = True
        Me.Lsv_Horarios.FullRowSelect = True
        Me.Lsv_Horarios.HideSelection = False
        Me.Lsv_Horarios.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Horarios.Lvs = ListViewColumnSorter1
        Me.Lsv_Horarios.MultiSelect = False
        Me.Lsv_Horarios.Name = "Lsv_Horarios"
        Me.Lsv_Horarios.Row1 = 8
        Me.Lsv_Horarios.Row10 = 0
        Me.Lsv_Horarios.Row2 = 8
        Me.Lsv_Horarios.Row3 = 20
        Me.Lsv_Horarios.Row4 = 10
        Me.Lsv_Horarios.Row5 = 15
        Me.Lsv_Horarios.Row6 = 8
        Me.Lsv_Horarios.Row7 = 10
        Me.Lsv_Horarios.Row8 = 10
        Me.Lsv_Horarios.Row9 = 0
        Me.Lsv_Horarios.Size = New System.Drawing.Size(754, 358)
        Me.Lsv_Horarios.TabIndex = 0
        Me.Lsv_Horarios.UseCompatibleStateImageBehavior = False
        Me.Lsv_Horarios.View = System.Windows.Forms.View.Details
        '
        'Lbl_Comentario
        '
        Me.Lbl_Comentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Comentario.AutoSize = True
        Me.Lbl_Comentario.Location = New System.Drawing.Point(3, 403)
        Me.Lbl_Comentario.Name = "Lbl_Comentario"
        Me.Lbl_Comentario.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_Comentario.TabIndex = 1
        Me.Lbl_Comentario.Text = "Comentario:"
        '
        'gbx_Horarios
        '
        Me.gbx_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Horarios.Controls.Add(Me.chk_Todos)
        Me.gbx_Horarios.Controls.Add(Me.lbl_Registros)
        Me.gbx_Horarios.Controls.Add(Me.Lsv_Horarios)
        Me.gbx_Horarios.Controls.Add(Me.tbx_Comentario)
        Me.gbx_Horarios.Controls.Add(Me.Lbl_Comentario)
        Me.gbx_Horarios.Location = New System.Drawing.Point(9, 55)
        Me.gbx_Horarios.Name = "gbx_Horarios"
        Me.gbx_Horarios.Size = New System.Drawing.Size(766, 446)
        Me.gbx_Horarios.TabIndex = 1
        Me.gbx_Horarios.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(620, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.lbl_Registros.TabIndex = 30
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Comentario
        '
        Me.tbx_Comentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Comentario.Control_Siguiente = Me.Btn_Valida
        Me.tbx_Comentario.Filtrado = True
        Me.tbx_Comentario.Location = New System.Drawing.Point(72, 398)
        Me.tbx_Comentario.MaxLength = 150
        Me.tbx_Comentario.Multiline = True
        Me.tbx_Comentario.Name = "tbx_Comentario"
        Me.tbx_Comentario.Size = New System.Drawing.Size(688, 42)
        Me.tbx_Comentario.TabIndex = 2
        Me.tbx_Comentario.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(6, 11)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 3
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'frm_ValidaHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Horarios)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ValidaHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valida Horarios"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.gbx_Horarios.ResumeLayout(False)
        Me.gbx_Horarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lsv_Horarios As Modulo_Ventas.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Valida As System.Windows.Forms.Button
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents chk_CLiente As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Clientes As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Comentario As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentario As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents gbx_Horarios As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Clave As System.Windows.Forms.TextBox
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
