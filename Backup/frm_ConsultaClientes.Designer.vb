<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaClientes))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.gbx_Cliente = New System.Windows.Forms.GroupBox
        Me.chk_TipoCliente = New System.Windows.Forms.CheckBox
        Me.lbl_TipoCliente = New System.Windows.Forms.Label
        Me.cmb_TipoCliente = New Modulo_Ventas.cp_cmb_Manual
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_ExportarContactos = New System.Windows.Forms.Button
        Me.btn_Adjunto = New System.Windows.Forms.Button
        Me.btn_Mapa = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.gbx_Puntos = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.gbx_Cliente.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Puntos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Cliente
        '
        Me.gbx_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cliente.Controls.Add(Me.chk_TipoCliente)
        Me.gbx_Cliente.Controls.Add(Me.lbl_TipoCliente)
        Me.gbx_Cliente.Controls.Add(Me.cmb_TipoCliente)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Status)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Status)
        Me.gbx_Cliente.Controls.Add(Me.chk_Todos)
        Me.gbx_Cliente.Controls.Add(Me.chk_Status)
        Me.gbx_Cliente.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.btn_BuscarCliente)
        Me.gbx_Cliente.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Cliente.Name = "gbx_Cliente"
        Me.gbx_Cliente.Size = New System.Drawing.Size(770, 96)
        Me.gbx_Cliente.TabIndex = 0
        Me.gbx_Cliente.TabStop = False
        '
        'chk_TipoCliente
        '
        Me.chk_TipoCliente.AutoSize = True
        Me.chk_TipoCliente.Location = New System.Drawing.Point(272, 70)
        Me.chk_TipoCliente.Name = "chk_TipoCliente"
        Me.chk_TipoCliente.Size = New System.Drawing.Size(56, 17)
        Me.chk_TipoCliente.TabIndex = 10
        Me.chk_TipoCliente.Text = "Todos"
        Me.chk_TipoCliente.UseVisualStyleBackColor = True
        '
        'lbl_TipoCliente
        '
        Me.lbl_TipoCliente.AutoSize = True
        Me.lbl_TipoCliente.Location = New System.Drawing.Point(49, 71)
        Me.lbl_TipoCliente.Name = "lbl_TipoCliente"
        Me.lbl_TipoCliente.Size = New System.Drawing.Size(28, 13)
        Me.lbl_TipoCliente.TabIndex = 8
        Me.lbl_TipoCliente.Text = "Tipo"
        '
        'cmb_TipoCliente
        '
        Me.cmb_TipoCliente.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_TipoCliente.DisplayMember = "display"
        Me.cmb_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoCliente.FormattingEnabled = True
        Me.cmb_TipoCliente.Location = New System.Drawing.Point(83, 68)
        Me.cmb_TipoCliente.MaxDropDownItems = 20
        Me.cmb_TipoCliente.Name = "cmb_TipoCliente"
        Me.cmb_TipoCliente.Size = New System.Drawing.Size(183, 21)
        Me.cmb_TipoCliente.TabIndex = 9
        Me.cmb_TipoCliente.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(412, 60)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 11
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(40, 43)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 5
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(83, 40)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(183, 21)
        Me.cmb_Status.TabIndex = 6
        Me.cmb_Status.ValueMember = "value"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(590, 16)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 4
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(272, 42)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 7
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(152, 13)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "cat_Clientes_GetPadres"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 2
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(83, 13)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(63, 20)
        Me.tbx_Cliente.TabIndex = 1
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(7, 16)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente Padre"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(558, 11)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 3
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_ExportarContactos)
        Me.gbx_Controles.Controls.Add(Me.btn_Adjunto)
        Me.gbx_Controles.Controls.Add(Me.btn_Mapa)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.btn_Exportar)
        Me.gbx_Controles.Location = New System.Drawing.Point(7, 495)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(770, 54)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_ExportarContactos
        '
        Me.btn_ExportarContactos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarContactos.Enabled = False
        Me.btn_ExportarContactos.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_ExportarContactos.Location = New System.Drawing.Point(152, 15)
        Me.btn_ExportarContactos.Name = "btn_ExportarContactos"
        Me.btn_ExportarContactos.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarContactos.TabIndex = 4
        Me.btn_ExportarContactos.Text = "&Exportar Contactos"
        Me.btn_ExportarContactos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarContactos.UseVisualStyleBackColor = True
        '
        'btn_Adjunto
        '
        Me.btn_Adjunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Adjunto.Enabled = False
        Me.btn_Adjunto.Image = Global.Modulo_Ventas.My.Resources.Resources.Camara
        Me.btn_Adjunto.Location = New System.Drawing.Point(444, 15)
        Me.btn_Adjunto.Name = "btn_Adjunto"
        Me.btn_Adjunto.Size = New System.Drawing.Size(140, 30)
        Me.btn_Adjunto.TabIndex = 3
        Me.btn_Adjunto.Text = "Archivo Adjunto"
        Me.btn_Adjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Adjunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Adjunto.UseVisualStyleBackColor = True
        '
        'btn_Mapa
        '
        Me.btn_Mapa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mapa.Enabled = False
        Me.btn_Mapa.Image = CType(resources.GetObject("btn_Mapa.Image"), System.Drawing.Image)
        Me.btn_Mapa.Location = New System.Drawing.Point(298, 15)
        Me.btn_Mapa.Name = "btn_Mapa"
        Me.btn_Mapa.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mapa.TabIndex = 1
        Me.btn_Mapa.Text = "Ver Mapa"
        Me.btn_Mapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mapa.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 15)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 15)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_Puntos
        '
        Me.gbx_Puntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Puntos.Controls.Add(Me.lbl_Registros)
        Me.gbx_Puntos.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_Puntos.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Puntos.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_Puntos.Controls.Add(Me.btn_Buscar)
        Me.gbx_Puntos.Location = New System.Drawing.Point(7, 104)
        Me.gbx_Puntos.Name = "gbx_Puntos"
        Me.gbx_Puntos.Size = New System.Drawing.Size(770, 385)
        Me.gbx_Puntos.TabIndex = 1
        Me.gbx_Puntos.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(624, 15)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 18)
        Me.lbl_Registros.TabIndex = 29
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(8, 39)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 20
        Me.lsv_Catalogo.Row3 = 20
        Me.lsv_Catalogo.Row4 = 10
        Me.lsv_Catalogo.Row5 = 15
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(756, 332)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(63, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(467, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(536, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(70, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(14, 16)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'frm_ConsultaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Cliente)
        Me.Controls.Add(Me.gbx_Puntos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes"
        Me.gbx_Cliente.ResumeLayout(False)
        Me.gbx_Cliente.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Puntos.ResumeLayout(False)
        Me.gbx_Puntos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Puntos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Mapa As System.Windows.Forms.Button
    Friend WithEvents btn_Adjunto As System.Windows.Forms.Button
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_TipoCliente As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_TipoCliente As System.Windows.Forms.Label
    Friend WithEvents chk_TipoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ExportarContactos As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
