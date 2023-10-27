<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CuentasBCliente
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CuentasBCliente))
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_ListView = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.btn_Mostar = New System.Windows.Forms.Button
        Me.chk_StatusCuenta = New System.Windows.Forms.CheckBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.chk_Cliente = New System.Windows.Forms.CheckBox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.chk_Compañia = New System.Windows.Forms.CheckBox
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.chk_StatusCliente = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lsv_Consulta = New Modulo_Ventas.cp_Listview
        Me.cmb_StatusCliente = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_Compañia = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_StatusCuenta = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_CajaBancaria = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_ListView.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 453)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(774, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(3, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_ListView
        '
        Me.gbx_ListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ListView.Controls.Add(Me.Lbl_Registros)
        Me.gbx_ListView.Controls.Add(Me.lsv_Consulta)
        Me.gbx_ListView.Location = New System.Drawing.Point(5, 153)
        Me.gbx_ListView.Name = "gbx_ListView"
        Me.gbx_ListView.Size = New System.Drawing.Size(774, 302)
        Me.gbx_ListView.TabIndex = 1
        Me.gbx_ListView.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(628, 12)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 20)
        Me.Lbl_Registros.TabIndex = 1
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_StatusCliente)
        Me.gbx_Filtro.Controls.Add(Me.chk_StatusCliente)
        Me.gbx_Filtro.Controls.Add(Me.Label1)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostar)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Compañia)
        Me.gbx_Filtro.Controls.Add(Me.cmb_StatusCuenta)
        Me.gbx_Filtro.Controls.Add(Me.chk_StatusCuenta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.chk_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.chk_Compañia)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Compañia)
        Me.gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtro.Location = New System.Drawing.Point(5, 1)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(774, 149)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'btn_Mostar
        '
        Me.btn_Mostar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostar.Location = New System.Drawing.Point(361, 112)
        Me.btn_Mostar.Name = "btn_Mostar"
        Me.btn_Mostar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostar.TabIndex = 14
        Me.btn_Mostar.Text = "Mostrar"
        Me.btn_Mostar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostar.UseVisualStyleBackColor = True
        '
        'chk_StatusCuenta
        '
        Me.chk_StatusCuenta.AutoSize = True
        Me.chk_StatusCuenta.Location = New System.Drawing.Point(245, 124)
        Me.chk_StatusCuenta.Name = "chk_StatusCuenta"
        Me.chk_StatusCuenta.Size = New System.Drawing.Size(56, 17)
        Me.chk_StatusCuenta.TabIndex = 13
        Me.chk_StatusCuenta.Text = "Todos"
        Me.chk_StatusCuenta.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(18, 125)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Status.TabIndex = 11
        Me.lbl_Status.Text = "Status Cuenta"
        '
        'chk_Cliente
        '
        Me.chk_Cliente.AutoSize = True
        Me.chk_Cliente.Location = New System.Drawing.Point(507, 69)
        Me.chk_Cliente.Name = "chk_Cliente"
        Me.chk_Cliente.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cliente.TabIndex = 7
        Me.chk_Cliente.Text = "Todos"
        Me.chk_Cliente.UseVisualStyleBackColor = True
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(53, 70)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 5
        Me.lbl_Cliente.Text = "Cliente"
        '
        'chk_Compañia
        '
        Me.chk_Compañia.AutoSize = True
        Me.chk_Compañia.Location = New System.Drawing.Point(507, 42)
        Me.chk_Compañia.Name = "chk_Compañia"
        Me.chk_Compañia.Size = New System.Drawing.Size(56, 17)
        Me.chk_Compañia.TabIndex = 4
        Me.chk_Compañia.Text = "Todos"
        Me.chk_Compañia.UseVisualStyleBackColor = True
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(26, 43)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Compañia.TabIndex = 2
        Me.lbl_Compañia.Text = "Cia Traslado"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(19, 16)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'chk_StatusCliente
        '
        Me.chk_StatusCliente.AutoSize = True
        Me.chk_StatusCliente.Location = New System.Drawing.Point(245, 97)
        Me.chk_StatusCliente.Name = "chk_StatusCliente"
        Me.chk_StatusCliente.Size = New System.Drawing.Size(56, 17)
        Me.chk_StatusCliente.TabIndex = 10
        Me.chk_StatusCliente.Text = "Todos"
        Me.chk_StatusCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Status Cliente"
        '
        'lsv_Consulta
        '
        Me.lsv_Consulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Consulta.FullRowSelect = True
        Me.lsv_Consulta.HideSelection = False
        Me.lsv_Consulta.Location = New System.Drawing.Point(6, 35)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Consulta.Lvs = ListViewColumnSorter2
        Me.lsv_Consulta.MultiSelect = False
        Me.lsv_Consulta.Name = "lsv_Consulta"
        Me.lsv_Consulta.Row1 = 25
        Me.lsv_Consulta.Row10 = 10
        Me.lsv_Consulta.Row2 = 10
        Me.lsv_Consulta.Row3 = 10
        Me.lsv_Consulta.Row4 = 25
        Me.lsv_Consulta.Row5 = 9
        Me.lsv_Consulta.Row6 = 7
        Me.lsv_Consulta.Row7 = 7
        Me.lsv_Consulta.Row8 = 6
        Me.lsv_Consulta.Row9 = 10
        Me.lsv_Consulta.Size = New System.Drawing.Size(762, 261)
        Me.lsv_Consulta.TabIndex = 0
        Me.lsv_Consulta.UseCompatibleStateImageBehavior = False
        Me.lsv_Consulta.View = System.Windows.Forms.View.Details
        '
        'cmb_StatusCliente
        '
        Me.cmb_StatusCliente.Control_Siguiente = Nothing
        Me.cmb_StatusCliente.DisplayMember = "display"
        Me.cmb_StatusCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_StatusCliente.FormattingEnabled = True
        Me.cmb_StatusCliente.Location = New System.Drawing.Point(101, 95)
        Me.cmb_StatusCliente.MaxDropDownItems = 20
        Me.cmb_StatusCliente.Name = "cmb_StatusCliente"
        Me.cmb_StatusCliente.Size = New System.Drawing.Size(138, 21)
        Me.cmb_StatusCliente.TabIndex = 9
        Me.cmb_StatusCliente.ValueMember = "value"
        '
        'cmb_Compañia
        '
        Me.cmb_Compañia.Clave = Nothing
        Me.cmb_Compañia.Control_Siguiente = Nothing
        Me.cmb_Compañia.DisplayMember = "Nombre"
        Me.cmb_Compañia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Compañia.Empresa = False
        Me.cmb_Compañia.Filtro = Nothing
        Me.cmb_Compañia.FormattingEnabled = True
        Me.cmb_Compañia.Location = New System.Drawing.Point(101, 40)
        Me.cmb_Compañia.MaxDropDownItems = 20
        Me.cmb_Compañia.Name = "cmb_Compañia"
        Me.cmb_Compañia.Pista = True
        Me.cmb_Compañia.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Compañia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Compañia.Sucursal = False
        Me.cmb_Compañia.TabIndex = 3
        Me.cmb_Compañia.Tipo = 0
        Me.cmb_Compañia.ValueMember = "Id_Cia"
        '
        'cmb_StatusCuenta
        '
        Me.cmb_StatusCuenta.Control_Siguiente = Nothing
        Me.cmb_StatusCuenta.DisplayMember = "display"
        Me.cmb_StatusCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_StatusCuenta.FormattingEnabled = True
        Me.cmb_StatusCuenta.Location = New System.Drawing.Point(101, 122)
        Me.cmb_StatusCuenta.MaxDropDownItems = 20
        Me.cmb_StatusCuenta.Name = "cmb_StatusCuenta"
        Me.cmb_StatusCuenta.Size = New System.Drawing.Size(138, 21)
        Me.cmb_StatusCuenta.TabIndex = 12
        Me.cmb_StatusCuenta.ValueMember = "value"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Nothing
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(101, 67)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesProceso_ByCajaAndCia"
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 6
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_ClienteP"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(101, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'frm_CuentasBCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 508)
        Me.Controls.Add(Me.gbx_ListView)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "frm_CuentasBCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Bancarias Por Cliente"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_ListView.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_ListView As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Compañia As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents chk_StatusCuenta As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents chk_Cliente As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_StatusCuenta As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Consulta As Modulo_Ventas.cp_Listview
    Friend WithEvents cmb_Compañia As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Mostar As System.Windows.Forms.Button
    Friend WithEvents cmb_StatusCliente As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_StatusCliente As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
