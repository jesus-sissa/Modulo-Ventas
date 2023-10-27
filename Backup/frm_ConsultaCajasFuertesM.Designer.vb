<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaCajasFuertesM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaCajasFuertesM))
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Importar = New System.Windows.Forms.Button
        Me.btn_CombinacionCliente = New System.Windows.Forms.Button
        Me.btn_Recibo = New System.Windows.Forms.Button
        Me.Btn_CancerlarMov = New System.Windows.Forms.Button
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.gbx_CajasFuertes = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.gbx_CajaFuerteMov = New System.Windows.Forms.GroupBox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker
        Me.chk_Cliente = New System.Windows.Forms.CheckBox
        Me.chk_TipoMov = New System.Windows.Forms.CheckBox
        Me.cmb_TipoMov = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_TipoMov = New System.Windows.Forms.Label
        Me.lbl_CajaFuerte = New System.Windows.Forms.Label
        Me.tbx_CajaFuerte = New Modulo_Ventas.cp_Textbox
        Me.cmb_CajaFuerte = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.chk_CajaFuerte = New System.Windows.Forms.CheckBox
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_CajasFuertes.SuspendLayout()
        Me.gbx_CajaFuerteMov.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Importar)
        Me.gbx_Controles.Controls.Add(Me.btn_CombinacionCliente)
        Me.gbx_Controles.Controls.Add(Me.btn_Recibo)
        Me.gbx_Controles.Controls.Add(Me.Btn_CancerlarMov)
        Me.gbx_Controles.Controls.Add(Me.BTN_Modificar)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.BTN_Exportar)
        Me.gbx_Controles.Location = New System.Drawing.Point(9, 498)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(1027, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Importar
        '
        Me.btn_Importar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Importar.Enabled = False
        Me.btn_Importar.Image = Global.Modulo_Ventas.My.Resources.Resources.Camara
        Me.btn_Importar.Location = New System.Drawing.Point(296, 13)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Importar.TabIndex = 6
        Me.btn_Importar.Text = "&Importar/Exportar"
        Me.btn_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Importar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'btn_CombinacionCliente
        '
        Me.btn_CombinacionCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CombinacionCliente.Enabled = False
        Me.btn_CombinacionCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_CombinacionCliente.Location = New System.Drawing.Point(588, 13)
        Me.btn_CombinacionCliente.Name = "btn_CombinacionCliente"
        Me.btn_CombinacionCliente.Size = New System.Drawing.Size(140, 30)
        Me.btn_CombinacionCliente.TabIndex = 3
        Me.btn_CombinacionCliente.Text = "Carta Combi&nación"
        Me.btn_CombinacionCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CombinacionCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CombinacionCliente.UseVisualStyleBackColor = True
        '
        'btn_Recibo
        '
        Me.btn_Recibo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibo.Enabled = False
        Me.btn_Recibo.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_Recibo.Location = New System.Drawing.Point(442, 13)
        Me.btn_Recibo.Name = "btn_Recibo"
        Me.btn_Recibo.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibo.TabIndex = 2
        Me.btn_Recibo.Text = "&Recibo"
        Me.btn_Recibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibo.UseVisualStyleBackColor = True
        '
        'Btn_CancerlarMov
        '
        Me.Btn_CancerlarMov.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_CancerlarMov.Enabled = False
        Me.Btn_CancerlarMov.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.Btn_CancerlarMov.Location = New System.Drawing.Point(4, 13)
        Me.Btn_CancerlarMov.Name = "Btn_CancerlarMov"
        Me.Btn_CancerlarMov.Size = New System.Drawing.Size(140, 30)
        Me.Btn_CancerlarMov.TabIndex = 0
        Me.Btn_CancerlarMov.Text = "C&ancelar Movimiento"
        Me.Btn_CancerlarMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CancerlarMov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_CancerlarMov.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(150, 13)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 1
        Me.BTN_Modificar.Text = "M&odificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(883, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 5
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Enabled = False
        Me.BTN_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(734, 13)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 4
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_CajasFuertes
        '
        Me.gbx_CajasFuertes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CajasFuertes.Controls.Add(Me.Lbl_Registros)
        Me.gbx_CajasFuertes.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_Buscar)
        Me.gbx_CajasFuertes.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_CajasFuertes.Controls.Add(Me.BTN_Buscar)
        Me.gbx_CajasFuertes.Location = New System.Drawing.Point(10, 129)
        Me.gbx_CajasFuertes.Name = "gbx_CajasFuertes"
        Me.gbx_CajasFuertes.Size = New System.Drawing.Size(1027, 363)
        Me.gbx_CajasFuertes.TabIndex = 1
        Me.gbx_CajasFuertes.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(886, 11)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(135, 23)
        Me.Lbl_Registros.TabIndex = 17
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(4, 39)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 10
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 10
        Me.lsv_Catalogo.Row5 = 8
        Me.lsv_Catalogo.Row6 = 12
        Me.lsv_Catalogo.Row7 = 12
        Me.lsv_Catalogo.Row8 = 12
        Me.lsv_Catalogo.Row9 = 12
        Me.lsv_Catalogo.Size = New System.Drawing.Size(1019, 316)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(62, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(506, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(574, 11)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(70, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(13, 16)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'gbx_CajaFuerteMov
        '
        Me.gbx_CajaFuerteMov.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.lbl_Cliente)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.tbx_Cliente)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.cmb_Cliente)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.chk_Cliente)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.chk_TipoMov)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.cmb_TipoMov)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.lbl_TipoMov)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.lbl_CajaFuerte)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.tbx_CajaFuerte)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.btn_Mostrar)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.cmb_CajaFuerte)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.dtp_Hasta)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.lbl_Hasta)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.dtp_desde)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.lbl_Desde)
        Me.gbx_CajaFuerteMov.Controls.Add(Me.chk_CajaFuerte)
        Me.gbx_CajaFuerteMov.Location = New System.Drawing.Point(10, 2)
        Me.gbx_CajaFuerteMov.Name = "gbx_CajaFuerteMov"
        Me.gbx_CajaFuerteMov.Size = New System.Drawing.Size(1027, 121)
        Me.gbx_CajaFuerteMov.TabIndex = 0
        Me.gbx_CajaFuerteMov.TabStop = False
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(36, 42)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        Me.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(81, 39)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(63, 20)
        Me.tbx_Cliente.TabIndex = 5
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.dtp_desde
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(150, 39)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_GetAB"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 6
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'dtp_desde
        '
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(81, 66)
        Me.dtp_desde.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_desde.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_desde.TabIndex = 9
        Me.dtp_desde.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'chk_Cliente
        '
        Me.chk_Cliente.AutoSize = True
        Me.chk_Cliente.Location = New System.Drawing.Point(558, 41)
        Me.chk_Cliente.Name = "chk_Cliente"
        Me.chk_Cliente.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cliente.TabIndex = 7
        Me.chk_Cliente.Text = "Todos"
        Me.chk_Cliente.UseVisualStyleBackColor = True
        '
        'chk_TipoMov
        '
        Me.chk_TipoMov.AutoSize = True
        Me.chk_TipoMov.Location = New System.Drawing.Point(324, 94)
        Me.chk_TipoMov.Name = "chk_TipoMov"
        Me.chk_TipoMov.Size = New System.Drawing.Size(56, 17)
        Me.chk_TipoMov.TabIndex = 14
        Me.chk_TipoMov.Text = "Todos"
        Me.chk_TipoMov.UseVisualStyleBackColor = True
        '
        'cmb_TipoMov
        '
        Me.cmb_TipoMov.Control_Siguiente = Nothing
        Me.cmb_TipoMov.DisplayMember = "display"
        Me.cmb_TipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoMov.FormattingEnabled = True
        Me.cmb_TipoMov.Location = New System.Drawing.Point(81, 92)
        Me.cmb_TipoMov.MaxDropDownItems = 20
        Me.cmb_TipoMov.Name = "cmb_TipoMov"
        Me.cmb_TipoMov.Size = New System.Drawing.Size(237, 21)
        Me.cmb_TipoMov.TabIndex = 13
        Me.cmb_TipoMov.ValueMember = "value"
        '
        'lbl_TipoMov
        '
        Me.lbl_TipoMov.AutoSize = True
        Me.lbl_TipoMov.Location = New System.Drawing.Point(14, 95)
        Me.lbl_TipoMov.Name = "lbl_TipoMov"
        Me.lbl_TipoMov.Size = New System.Drawing.Size(61, 13)
        Me.lbl_TipoMov.TabIndex = 12
        Me.lbl_TipoMov.Text = "Movimiento"
        Me.lbl_TipoMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CajaFuerte
        '
        Me.lbl_CajaFuerte.AutoSize = True
        Me.lbl_CajaFuerte.Location = New System.Drawing.Point(8, 16)
        Me.lbl_CajaFuerte.Name = "lbl_CajaFuerte"
        Me.lbl_CajaFuerte.Size = New System.Drawing.Size(67, 13)
        Me.lbl_CajaFuerte.TabIndex = 0
        Me.lbl_CajaFuerte.Text = "Tipo de Caja"
        Me.lbl_CajaFuerte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_CajaFuerte
        '
        Me.tbx_CajaFuerte.Control_Siguiente = Me.cmb_CajaFuerte
        Me.tbx_CajaFuerte.Filtrado = True
        Me.tbx_CajaFuerte.Location = New System.Drawing.Point(81, 13)
        Me.tbx_CajaFuerte.MaxLength = 20
        Me.tbx_CajaFuerte.Name = "tbx_CajaFuerte"
        Me.tbx_CajaFuerte.Size = New System.Drawing.Size(63, 20)
        Me.tbx_CajaFuerte.TabIndex = 1
        Me.tbx_CajaFuerte.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_CajaFuerte
        '
        Me.cmb_CajaFuerte.Clave = "Clave"
        Me.cmb_CajaFuerte.Control_Siguiente = Nothing
        Me.cmb_CajaFuerte.DisplayMember = "Descripcion"
        Me.cmb_CajaFuerte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaFuerte.Empresa = False
        Me.cmb_CajaFuerte.Filtro = Me.tbx_CajaFuerte
        Me.cmb_CajaFuerte.FormattingEnabled = True
        Me.cmb_CajaFuerte.Location = New System.Drawing.Point(150, 13)
        Me.cmb_CajaFuerte.MaxDropDownItems = 20
        Me.cmb_CajaFuerte.Name = "cmb_CajaFuerte"
        Me.cmb_CajaFuerte.Pista = False
        Me.cmb_CajaFuerte.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaFuerte.StoredProcedure = "Cat_CajasFuertesT_GetCombo"
        Me.cmb_CajaFuerte.Sucursal = False
        Me.cmb_CajaFuerte.TabIndex = 2
        Me.cmb_CajaFuerte.Tipo = 0
        Me.cmb_CajaFuerte.ValueMember = "Id_CajaFuerteT"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(504, 86)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 15
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(223, 66)
        Me.dtp_Hasta.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Hasta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 11
        Me.dtp_Hasta.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(182, 70)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 10
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(37, 70)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 8
        Me.lbl_Desde.Text = "Desde"
        '
        'chk_CajaFuerte
        '
        Me.chk_CajaFuerte.AutoSize = True
        Me.chk_CajaFuerte.Location = New System.Drawing.Point(558, 15)
        Me.chk_CajaFuerte.Name = "chk_CajaFuerte"
        Me.chk_CajaFuerte.Size = New System.Drawing.Size(56, 17)
        Me.chk_CajaFuerte.TabIndex = 3
        Me.chk_CajaFuerte.Text = "Todos"
        Me.chk_CajaFuerte.UseVisualStyleBackColor = True
        '
        'frm_ConsultaCajasFuertesM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 554)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_CajasFuertes)
        Me.Controls.Add(Me.gbx_CajaFuerteMov)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1062, 581)
        Me.Name = "frm_ConsultaCajasFuertesM"
        Me.Text = "Movimientos de Cajas Fuertes"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_CajasFuertes.ResumeLayout(False)
        Me.gbx_CajasFuertes.PerformLayout()
        Me.gbx_CajaFuerteMov.ResumeLayout(False)
        Me.gbx_CajaFuerteMov.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_CajaFuerteMov As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents chk_CajaFuerte As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_CajaFuerte As System.Windows.Forms.Label
    Friend WithEvents tbx_CajaFuerte As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_CajaFuerte As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_CajasFuertes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_CancerlarMov As System.Windows.Forms.Button
    Friend WithEvents btn_Recibo As System.Windows.Forms.Button
    Friend WithEvents btn_CombinacionCliente As System.Windows.Forms.Button
    Friend WithEvents cmb_TipoMov As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_TipoMov As System.Windows.Forms.Label
    Friend WithEvents chk_TipoMov As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Cliente As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
