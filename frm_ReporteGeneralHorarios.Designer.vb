<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ReporteGeneralHorarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReporteGeneralHorarios))
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.gbx_Cliente = New System.Windows.Forms.GroupBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.chk_Clientes = New System.Windows.Forms.CheckBox()
        Me.chk_Destino = New System.Windows.Forms.CheckBox()
        Me.chk_Origen = New System.Windows.Forms.CheckBox()
        Me.lbl_Destino = New System.Windows.Forms.Label()
        Me.lbl_Origen = New System.Windows.Forms.Label()
        Me.chk_Subclientes = New System.Windows.Forms.CheckBox()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.gbx_Horarios = New System.Windows.Forms.GroupBox()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.lsv_Horarios = New Modulo_Ventas.cp_Listview()
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual()
        Me.tbx_H_ClienteD = New Modulo_Ventas.cp_Textbox()
        Me.cmb_H_ClienteD = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.tbx_H_ClienteO = New Modulo_Ventas.cp_Textbox()
        Me.cmb_H_ClienteO = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Cliente.SuspendLayout()
        Me.gbx_Horarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 552)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(906, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'gbx_Cliente
        '
        Me.gbx_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Status)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Status)
        Me.gbx_Cliente.Controls.Add(Me.tbx_H_ClienteD)
        Me.gbx_Cliente.Controls.Add(Me.tbx_H_ClienteO)
        Me.gbx_Cliente.Controls.Add(Me.cmb_H_ClienteD)
        Me.gbx_Cliente.Controls.Add(Me.cmb_H_ClienteO)
        Me.gbx_Cliente.Controls.Add(Me.chk_Clientes)
        Me.gbx_Cliente.Controls.Add(Me.chk_Destino)
        Me.gbx_Cliente.Controls.Add(Me.chk_Origen)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Destino)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Origen)
        Me.gbx_Cliente.Controls.Add(Me.chk_Subclientes)
        Me.gbx_Cliente.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Cliente.Location = New System.Drawing.Point(4, 5)
        Me.gbx_Cliente.Name = "gbx_Cliente"
        Me.gbx_Cliente.Size = New System.Drawing.Size(906, 123)
        Me.gbx_Cliente.TabIndex = 0
        Me.gbx_Cliente.TabStop = False
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(109, 45)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 14
        Me.lbl_Status.Text = "Status"
        '
        'chk_Clientes
        '
        Me.chk_Clientes.AutoSize = True
        Me.chk_Clientes.Location = New System.Drawing.Point(671, 16)
        Me.chk_Clientes.Name = "chk_Clientes"
        Me.chk_Clientes.Size = New System.Drawing.Size(56, 17)
        Me.chk_Clientes.TabIndex = 4
        Me.chk_Clientes.Text = "Todos"
        Me.chk_Clientes.UseVisualStyleBackColor = True
        '
        'chk_Destino
        '
        Me.chk_Destino.AutoSize = True
        Me.chk_Destino.Location = New System.Drawing.Point(559, 98)
        Me.chk_Destino.Name = "chk_Destino"
        Me.chk_Destino.Size = New System.Drawing.Size(56, 17)
        Me.chk_Destino.TabIndex = 12
        Me.chk_Destino.Text = "Todos"
        Me.chk_Destino.UseVisualStyleBackColor = True
        '
        'chk_Origen
        '
        Me.chk_Origen.AutoSize = True
        Me.chk_Origen.Location = New System.Drawing.Point(559, 71)
        Me.chk_Origen.Name = "chk_Origen"
        Me.chk_Origen.Size = New System.Drawing.Size(56, 17)
        Me.chk_Origen.TabIndex = 8
        Me.chk_Origen.Text = "Todos"
        Me.chk_Origen.UseVisualStyleBackColor = True
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(34, 98)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 9
        Me.lbl_Destino.Text = "Destino"
        '
        'lbl_Origen
        '
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(39, 71)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Origen.TabIndex = 5
        Me.lbl_Origen.Text = "Origen"
        '
        'chk_Subclientes
        '
        Me.chk_Subclientes.AutoSize = True
        Me.chk_Subclientes.Location = New System.Drawing.Point(558, 16)
        Me.chk_Subclientes.Name = "chk_Subclientes"
        Me.chk_Subclientes.Size = New System.Drawing.Size(112, 17)
        Me.chk_Subclientes.TabIndex = 3
        Me.chk_Subclientes.Text = "Incluir Subclientes"
        Me.chk_Subclientes.UseVisualStyleBackColor = True
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
        'gbx_Horarios
        '
        Me.gbx_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Horarios.Controls.Add(Me.lbl_Registros)
        Me.gbx_Horarios.Controls.Add(Me.lsv_Horarios)
        Me.gbx_Horarios.Location = New System.Drawing.Point(4, 134)
        Me.gbx_Horarios.Name = "gbx_Horarios"
        Me.gbx_Horarios.Size = New System.Drawing.Size(906, 423)
        Me.gbx_Horarios.TabIndex = 1
        Me.gbx_Horarios.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(760, 29)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 16)
        Me.lbl_Registros.TabIndex = 0
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(671, 86)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 13
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(761, 11)
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
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'lsv_Horarios
        '
        Me.lsv_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Horarios.FullRowSelect = True
        Me.lsv_Horarios.HideSelection = False
        Me.lsv_Horarios.Location = New System.Drawing.Point(12, 55)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Horarios.Lvs = ListViewColumnSorter1
        Me.lsv_Horarios.MultiSelect = False
        Me.lsv_Horarios.Name = "lsv_Horarios"
        Me.lsv_Horarios.Row1 = 8
        Me.lsv_Horarios.Row10 = 15
        Me.lsv_Horarios.Row2 = 15
        Me.lsv_Horarios.Row3 = 8
        Me.lsv_Horarios.Row4 = 8
        Me.lsv_Horarios.Row5 = 15
        Me.lsv_Horarios.Row6 = 10
        Me.lsv_Horarios.Row7 = 10
        Me.lsv_Horarios.Row8 = 15
        Me.lsv_Horarios.Row9 = 8
        Me.lsv_Horarios.Size = New System.Drawing.Size(894, 368)
        Me.lsv_Horarios.TabIndex = 1
        Me.lsv_Horarios.UseCompatibleStateImageBehavior = False
        Me.lsv_Horarios.View = System.Windows.Forms.View.Details
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(152, 41)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(183, 21)
        Me.cmb_Status.TabIndex = 15
        Me.cmb_Status.ValueMember = "value"
        '
        'tbx_H_ClienteD
        '
        Me.tbx_H_ClienteD.Control_Siguiente = Me.cmb_H_ClienteD
        Me.tbx_H_ClienteD.Filtrado = True
        Me.tbx_H_ClienteD.Location = New System.Drawing.Point(83, 97)
        Me.tbx_H_ClienteD.MaxLength = 20
        Me.tbx_H_ClienteD.Name = "tbx_H_ClienteD"
        Me.tbx_H_ClienteD.Size = New System.Drawing.Size(63, 20)
        Me.tbx_H_ClienteD.TabIndex = 10
        Me.tbx_H_ClienteD.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_H_ClienteD
        '
        Me.cmb_H_ClienteD.Clave = "Clave_Cliente"
        Me.cmb_H_ClienteD.Control_Siguiente = Nothing
        Me.cmb_H_ClienteD.DisplayMember = "Nombre_Comercial"
        Me.cmb_H_ClienteD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_ClienteD.Empresa = False
        Me.cmb_H_ClienteD.Filtro = Me.tbx_H_ClienteD
        Me.cmb_H_ClienteD.FormattingEnabled = True
        Me.cmb_H_ClienteD.Location = New System.Drawing.Point(152, 97)
        Me.cmb_H_ClienteD.MaxDropDownItems = 20
        Me.cmb_H_ClienteD.Name = "cmb_H_ClienteD"
        Me.cmb_H_ClienteD.Pista = False
        Me.cmb_H_ClienteD.Size = New System.Drawing.Size(400, 21)
        Me.cmb_H_ClienteD.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_H_ClienteD.Sucursal = True
        Me.cmb_H_ClienteD.TabIndex = 11
        Me.cmb_H_ClienteD.Tipo = 0
        Me.cmb_H_ClienteD.ValueMember = "Id_Cliente"
        '
        'tbx_H_ClienteO
        '
        Me.tbx_H_ClienteO.Control_Siguiente = Me.cmb_H_ClienteO
        Me.tbx_H_ClienteO.Filtrado = True
        Me.tbx_H_ClienteO.Location = New System.Drawing.Point(83, 68)
        Me.tbx_H_ClienteO.MaxLength = 20
        Me.tbx_H_ClienteO.Name = "tbx_H_ClienteO"
        Me.tbx_H_ClienteO.Size = New System.Drawing.Size(63, 20)
        Me.tbx_H_ClienteO.TabIndex = 6
        Me.tbx_H_ClienteO.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_H_ClienteO
        '
        Me.cmb_H_ClienteO.Clave = "Clave_Cliente"
        Me.cmb_H_ClienteO.Control_Siguiente = Nothing
        Me.cmb_H_ClienteO.DisplayMember = "Nombre_Comercial"
        Me.cmb_H_ClienteO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_ClienteO.Empresa = False
        Me.cmb_H_ClienteO.Filtro = Me.tbx_H_ClienteO
        Me.cmb_H_ClienteO.FormattingEnabled = True
        Me.cmb_H_ClienteO.Location = New System.Drawing.Point(152, 67)
        Me.cmb_H_ClienteO.MaxDropDownItems = 20
        Me.cmb_H_ClienteO.Name = "cmb_H_ClienteO"
        Me.cmb_H_ClienteO.Pista = False
        Me.cmb_H_ClienteO.Size = New System.Drawing.Size(400, 21)
        Me.cmb_H_ClienteO.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_H_ClienteO.Sucursal = True
        Me.cmb_H_ClienteO.TabIndex = 7
        Me.cmb_H_ClienteO.Tipo = 0
        Me.cmb_H_ClienteO.ValueMember = "Id_Cliente"
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
        'frm_ReporteGeneralHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 606)
        Me.Controls.Add(Me.gbx_Horarios)
        Me.Controls.Add(Me.gbx_Cliente)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteGeneralHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte General de Horarios"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Cliente.ResumeLayout(False)
        Me.gbx_Cliente.PerformLayout()
        Me.gbx_Horarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_Subclientes As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents gbx_Horarios As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Horarios As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents chk_Destino As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Origen As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_H_ClienteO As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_H_ClienteD As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_H_ClienteO As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_H_ClienteD As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents cmb_Status As cp_cmb_Manual
End Class
