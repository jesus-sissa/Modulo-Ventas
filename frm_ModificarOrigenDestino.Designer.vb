<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ModificarOrigenDestino
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
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.Gbx_Datos = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.rdb_Destino = New System.Windows.Forms.RadioButton
        Me.cmb_ClientesHorarios = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.rdb_Origen = New System.Windows.Forms.RadioButton
        Me.tbx_ClaveServicio = New Modulo_Ventas.cp_Textbox
        Me.cmb_Servicios = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New System.Windows.Forms.TextBox
        Me.lbl_Servicio = New System.Windows.Forms.Label
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_Clientes = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.gbx_Horarios = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lbl_H_Cliente = New System.Windows.Forms.Label
        Me.tbx_H_Cliente = New Modulo_Ventas.cp_Textbox
        Me.cmb_H_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Lsv_Horarios = New Modulo_Ventas.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Datos.SuspendLayout()
        Me.gbx_Horarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cancelar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(10, 507)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(765, 47)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(619, 11)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "&Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Gbx_Datos
        '
        Me.Gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Datos.Controls.Add(Me.rdb_Destino)
        Me.Gbx_Datos.Controls.Add(Me.cmb_ClientesHorarios)
        Me.Gbx_Datos.Controls.Add(Me.rdb_Origen)
        Me.Gbx_Datos.Controls.Add(Me.tbx_ClaveServicio)
        Me.Gbx_Datos.Controls.Add(Me.cmb_Servicios)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Clave)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Servicio)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Cliente)
        Me.Gbx_Datos.Controls.Add(Me.cmb_Clientes)
        Me.Gbx_Datos.Location = New System.Drawing.Point(10, 2)
        Me.Gbx_Datos.Name = "Gbx_Datos"
        Me.Gbx_Datos.Size = New System.Drawing.Size(765, 133)
        Me.Gbx_Datos.TabIndex = 0
        Me.Gbx_Datos.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(505, 92)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 9
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'rdb_Destino
        '
        Me.rdb_Destino.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdb_Destino.AutoSize = True
        Me.rdb_Destino.Location = New System.Drawing.Point(15, 105)
        Me.rdb_Destino.Name = "rdb_Destino"
        Me.rdb_Destino.Size = New System.Drawing.Size(61, 17)
        Me.rdb_Destino.TabIndex = 7
        Me.rdb_Destino.Text = "Destino"
        Me.rdb_Destino.UseVisualStyleBackColor = True
        '
        'cmb_ClientesHorarios
        '
        Me.cmb_ClientesHorarios.Clave = "Clave_Cliente"
        Me.cmb_ClientesHorarios.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_ClientesHorarios.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClientesHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClientesHorarios.Empresa = False
        Me.cmb_ClientesHorarios.Filtro = Nothing
        Me.cmb_ClientesHorarios.FormattingEnabled = True
        Me.cmb_ClientesHorarios.Location = New System.Drawing.Point(82, 102)
        Me.cmb_ClientesHorarios.MaxDropDownItems = 20
        Me.cmb_ClientesHorarios.Name = "cmb_ClientesHorarios"
        Me.cmb_ClientesHorarios.Pista = False
        Me.cmb_ClientesHorarios.Size = New System.Drawing.Size(390, 21)
        Me.cmb_ClientesHorarios.StoredProcedure = "Cat_ClientesHorarios_CombobyCliente_Get"
        Me.cmb_ClientesHorarios.Sucursal = False
        Me.cmb_ClientesHorarios.TabIndex = 8
        Me.cmb_ClientesHorarios.Tipo = 0
        Me.cmb_ClientesHorarios.ValueMember = "Id_Cliente"
        '
        'rdb_Origen
        '
        Me.rdb_Origen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdb_Origen.AutoSize = True
        Me.rdb_Origen.Location = New System.Drawing.Point(15, 78)
        Me.rdb_Origen.Name = "rdb_Origen"
        Me.rdb_Origen.Size = New System.Drawing.Size(56, 17)
        Me.rdb_Origen.TabIndex = 6
        Me.rdb_Origen.Text = "Origen"
        Me.rdb_Origen.UseVisualStyleBackColor = True
        '
        'tbx_ClaveServicio
        '
        Me.tbx_ClaveServicio.Control_Siguiente = Me.cmb_Servicios
        Me.tbx_ClaveServicio.Filtrado = True
        Me.tbx_ClaveServicio.Location = New System.Drawing.Point(72, 47)
        Me.tbx_ClaveServicio.Name = "tbx_ClaveServicio"
        Me.tbx_ClaveServicio.Size = New System.Drawing.Size(49, 20)
        Me.tbx_ClaveServicio.TabIndex = 4
        Me.tbx_ClaveServicio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Servicios
        '
        Me.cmb_Servicios.Clave = "Clave"
        Me.cmb_Servicios.Control_Siguiente = Me.cmb_ClientesHorarios
        Me.cmb_Servicios.DisplayMember = "Descripcion"
        Me.cmb_Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Servicios.Empresa = False
        Me.cmb_Servicios.Filtro = Me.tbx_ClaveServicio
        Me.cmb_Servicios.FormattingEnabled = True
        Me.cmb_Servicios.Location = New System.Drawing.Point(128, 46)
        Me.cmb_Servicios.MaxDropDownItems = 20
        Me.cmb_Servicios.Name = "cmb_Servicios"
        Me.cmb_Servicios.Pista = False
        Me.cmb_Servicios.Size = New System.Drawing.Size(344, 21)
        Me.cmb_Servicios.StoredProcedure = "Cat_ClientesServicios_ComboGet"
        Me.cmb_Servicios.Sucursal = False
        Me.cmb_Servicios.TabIndex = 5
        Me.cmb_Servicios.Tipo = 0
        Me.cmb_Servicios.ValueMember = "Id_Precio"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Location = New System.Drawing.Point(72, 18)
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Clave.TabIndex = 1
        '
        'lbl_Servicio
        '
        Me.lbl_Servicio.AutoSize = True
        Me.lbl_Servicio.Location = New System.Drawing.Point(12, 50)
        Me.lbl_Servicio.Name = "lbl_Servicio"
        Me.lbl_Servicio.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Servicio.TabIndex = 3
        Me.lbl_Servicio.Text = "Servicios"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(23, 21)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 0
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Me.cmb_Servicios
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.tbx_Clave
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(128, 18)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(344, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_Clientes_GetPadres"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 2
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'gbx_Horarios
        '
        Me.gbx_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Horarios.Controls.Add(Me.lbl_Registros)
        Me.gbx_Horarios.Controls.Add(Me.chk_Todos)
        Me.gbx_Horarios.Controls.Add(Me.lbl_H_Cliente)
        Me.gbx_Horarios.Controls.Add(Me.tbx_H_Cliente)
        Me.gbx_Horarios.Controls.Add(Me.cmb_H_Cliente)
        Me.gbx_Horarios.Controls.Add(Me.Lsv_Horarios)
        Me.gbx_Horarios.Location = New System.Drawing.Point(10, 141)
        Me.gbx_Horarios.Name = "gbx_Horarios"
        Me.gbx_Horarios.Size = New System.Drawing.Size(765, 360)
        Me.gbx_Horarios.TabIndex = 1
        Me.gbx_Horarios.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(558, 10)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(201, 15)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(6, 10)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 0
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lbl_H_Cliente
        '
        Me.lbl_H_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_H_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H_Cliente.Location = New System.Drawing.Point(8, 335)
        Me.lbl_H_Cliente.Name = "lbl_H_Cliente"
        Me.lbl_H_Cliente.Size = New System.Drawing.Size(251, 16)
        Me.lbl_H_Cliente.TabIndex = 3
        Me.lbl_H_Cliente.Text = "Este Cliente sera el Nuevo Origen"
        Me.lbl_H_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbx_H_Cliente
        '
        Me.tbx_H_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_H_Cliente.Control_Siguiente = Me.cmb_H_Cliente
        Me.tbx_H_Cliente.Filtrado = True
        Me.tbx_H_Cliente.Location = New System.Drawing.Point(265, 334)
        Me.tbx_H_Cliente.MaxLength = 20
        Me.tbx_H_Cliente.Name = "tbx_H_Cliente"
        Me.tbx_H_Cliente.Size = New System.Drawing.Size(64, 20)
        Me.tbx_H_Cliente.TabIndex = 4
        Me.tbx_H_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_H_Cliente
        '
        Me.cmb_H_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_H_Cliente.Clave = "Clave_Cliente"
        Me.cmb_H_Cliente.Control_Siguiente = Nothing
        Me.cmb_H_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_H_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_Cliente.Empresa = False
        Me.cmb_H_Cliente.Filtro = Me.tbx_H_Cliente
        Me.cmb_H_Cliente.FormattingEnabled = True
        Me.cmb_H_Cliente.Location = New System.Drawing.Point(335, 333)
        Me.cmb_H_Cliente.MaxDropDownItems = 20
        Me.cmb_H_Cliente.Name = "cmb_H_Cliente"
        Me.cmb_H_Cliente.Pista = False
        Me.cmb_H_Cliente.Size = New System.Drawing.Size(355, 21)
        Me.cmb_H_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_H_Cliente.Sucursal = True
        Me.cmb_H_Cliente.TabIndex = 5
        Me.cmb_H_Cliente.Tipo = 0
        Me.cmb_H_Cliente.ValueMember = "Id_Cliente"
        '
        'Lsv_Horarios
        '
        Me.Lsv_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Horarios.CheckBoxes = True
        Me.Lsv_Horarios.FullRowSelect = True
        Me.Lsv_Horarios.HideSelection = False
        Me.Lsv_Horarios.Location = New System.Drawing.Point(6, 28)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Horarios.Lvs = ListViewColumnSorter1
        Me.Lsv_Horarios.MultiSelect = False
        Me.Lsv_Horarios.Name = "Lsv_Horarios"
        Me.Lsv_Horarios.Row1 = 25
        Me.Lsv_Horarios.Row10 = 0
        Me.Lsv_Horarios.Row2 = 6
        Me.Lsv_Horarios.Row3 = 25
        Me.Lsv_Horarios.Row4 = 8
        Me.Lsv_Horarios.Row5 = 25
        Me.Lsv_Horarios.Row6 = 8
        Me.Lsv_Horarios.Row7 = 0
        Me.Lsv_Horarios.Row8 = 0
        Me.Lsv_Horarios.Row9 = 0
        Me.Lsv_Horarios.Size = New System.Drawing.Size(753, 297)
        Me.Lsv_Horarios.TabIndex = 2
        Me.Lsv_Horarios.UseCompatibleStateImageBehavior = False
        Me.Lsv_Horarios.View = System.Windows.Forms.View.Details
        '
        'frm_ModificarOrigenDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Horarios)
        Me.Controls.Add(Me.Gbx_Datos)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ModificarOrigenDestino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Origen o Destino"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Datos.ResumeLayout(False)
        Me.Gbx_Datos.PerformLayout()
        Me.gbx_Horarios.ResumeLayout(False)
        Me.gbx_Horarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lsv_Horarios As Modulo_Ventas.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Clientes As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Horarios As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Clave As System.Windows.Forms.TextBox
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_Destino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Origen As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_H_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_H_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_H_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Servicios As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveServicio As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Servicio As System.Windows.Forms.Label
    Friend WithEvents cmb_ClientesHorarios As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
