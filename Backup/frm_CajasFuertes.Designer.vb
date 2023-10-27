<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CajasFuertes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CajasFuertes))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_Clientes = New System.Windows.Forms.CheckBox
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_ReciboBaja = New System.Windows.Forms.Button
        Me.tbx_Buscar = New System.Windows.Forms.TextBox
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.btn_Gestion = New System.Windows.Forms.Button
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.grp_DimensionI = New System.Windows.Forms.GroupBox
        Me.lbl_6 = New System.Windows.Forms.Label
        Me.lbl_cm5 = New System.Windows.Forms.Label
        Me.lbl_cm4 = New System.Windows.Forms.Label
        Me.lbl_AnchoI = New System.Windows.Forms.Label
        Me.lbl_FondoI = New System.Windows.Forms.Label
        Me.lbl_AltoI = New System.Windows.Forms.Label
        Me.grp_DimensionE = New System.Windows.Forms.GroupBox
        Me.lbl_cm3 = New System.Windows.Forms.Label
        Me.lbl_cm2 = New System.Windows.Forms.Label
        Me.lbl_cm1 = New System.Windows.Forms.Label
        Me.lbl_AnchoE = New System.Windows.Forms.Label
        Me.lbl_FondoE = New System.Windows.Forms.Label
        Me.lbl_AltoE = New System.Windows.Forms.Label
        Me.grp_InfoGeneral = New System.Windows.Forms.GroupBox
        Me.grp_detallescomb = New System.Windows.Forms.GroupBox
        Me.ltb_LogCombinacion = New System.Windows.Forms.ListBox
        Me.pnl_des2 = New System.Windows.Forms.Panel
        Me.dtp_Fabricacion = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaFabricacion = New System.Windows.Forms.Label
        Me.lbl_FechaFabricacionA = New System.Windows.Forms.Label
        Me.dtp_Compra = New System.Windows.Forms.DateTimePicker
        Me.chk_Retiro = New System.Windows.Forms.CheckBox
        Me.lbl_Nueva = New System.Windows.Forms.Label
        Me.lbl_NuevaA = New System.Windows.Forms.Label
        Me.lbl_CombinacionCliente = New System.Windows.Forms.Label
        Me.lbl_FechaRetiroA = New System.Windows.Forms.Label
        Me.dtp_FechaRetiro = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaRetiro = New System.Windows.Forms.Label
        Me.pnl_des = New System.Windows.Forms.Panel
        Me.lbl_Marca = New System.Windows.Forms.Label
        Me.lbl_Peso = New System.Windows.Forms.Label
        Me.lbl_pesokg = New System.Windows.Forms.Label
        Me.lbl_ClaveCajaFuerte = New System.Windows.Forms.Label
        Me.lbl_Serie = New System.Windows.Forms.Label
        Me.lbl_CajaFuerteT = New System.Windows.Forms.Label
        Me.lbl_Modelo = New System.Windows.Forms.Label
        Me.lbl_CajaFuerteTA = New System.Windows.Forms.Label
        Me.lbl_MarcaA = New System.Windows.Forms.Label
        Me.lbl_SerieA = New System.Windows.Forms.Label
        Me.lbl_Combinacion = New System.Windows.Forms.Label
        Me.lbl_CombinacionA = New System.Windows.Forms.Label
        Me.grp_InfoCompra = New System.Windows.Forms.GroupBox
        Me.Pnl_infocompra = New System.Windows.Forms.Panel
        Me.btn_BuscarProveedores = New System.Windows.Forms.Button
        Me.dtp_CompraA = New System.Windows.Forms.Label
        Me.tbx_ProveedorA = New System.Windows.Forms.Label
        Me.lbl_Proveedor = New System.Windows.Forms.Label
        Me.lbl_FechaCompra = New System.Windows.Forms.Label
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.tbx_FondoI = New Modulo_Ventas.cp_Textbox
        Me.tbx_AnchoI = New Modulo_Ventas.cp_Textbox
        Me.tbx_AltoI = New Modulo_Ventas.cp_Textbox
        Me.tbx_FondoE = New Modulo_Ventas.cp_Textbox
        Me.tbx_AnchoE = New Modulo_Ventas.cp_Textbox
        Me.tbx_AltoE = New Modulo_Ventas.cp_Textbox
        Me.cmb_Nueva = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_Proveedor = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_Proveedor = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombinacionCliente = New Modulo_Ventas.cp_Textbox
        Me.tbx_Combinacion1 = New Modulo_Ventas.cp_Textbox
        Me.tbx_Combinacion2 = New Modulo_Ventas.cp_Textbox
        Me.cmb_CajaFuerteT = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveCajaFuerte = New Modulo_Ventas.cp_Textbox
        Me.tbx_Marca = New Modulo_Ventas.cp_Textbox
        Me.tbx_Serie = New Modulo_Ventas.cp_Textbox
        Me.tbx_Combinacion0 = New Modulo_Ventas.cp_Textbox
        Me.tbx_Peso = New Modulo_Ventas.cp_Textbox
        Me.tbx_Modelo = New Modulo_Ventas.cp_Textbox
        Me.cmb_ClienteAsignado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.grp_DimensionI.SuspendLayout()
        Me.grp_DimensionE.SuspendLayout()
        Me.grp_InfoGeneral.SuspendLayout()
        Me.grp_detallescomb.SuspendLayout()
        Me.pnl_des2.SuspendLayout()
        Me.pnl_des.SuspendLayout()
        Me.grp_InfoCompra.SuspendLayout()
        Me.Pnl_infocompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(914, 631)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.btn_Mostrar)
        Me.tab_Listado.Controls.Add(Me.chk_Clientes)
        Me.tab_Listado.Controls.Add(Me.tbx_Cliente)
        Me.tab_Listado.Controls.Add(Me.btn_BuscarCliente)
        Me.tab_Listado.Controls.Add(Me.cmb_Cliente)
        Me.tab_Listado.Controls.Add(Me.lbl_Cliente)
        Me.tab_Listado.Controls.Add(Me.btn_ReciboBaja)
        Me.tab_Listado.Controls.Add(Me.cmb_Status)
        Me.tab_Listado.Controls.Add(Me.chk_Status)
        Me.tab_Listado.Controls.Add(Me.lbl_Status)
        Me.tab_Listado.Controls.Add(Me.btn_Gestion)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(906, 605)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(748, 89)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(155, 17)
        Me.Lbl_Registros.TabIndex = 30
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(367, 67)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 11
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Clientes
        '
        Me.chk_Clientes.AutoSize = True
        Me.chk_Clientes.Location = New System.Drawing.Point(548, 43)
        Me.chk_Clientes.Name = "chk_Clientes"
        Me.chk_Clientes.Size = New System.Drawing.Size(56, 17)
        Me.chk_Clientes.TabIndex = 7
        Me.chk_Clientes.Text = "Todos"
        Me.chk_Clientes.UseVisualStyleBackColor = True
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(516, 39)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 6
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(7, 44)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 3
        Me.lbl_Cliente.Text = "Cliente"
        Me.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_ReciboBaja
        '
        Me.btn_ReciboBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ReciboBaja.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_ReciboBaja.Location = New System.Drawing.Point(587, 567)
        Me.btn_ReciboBaja.Name = "btn_ReciboBaja"
        Me.btn_ReciboBaja.Size = New System.Drawing.Size(140, 30)
        Me.btn_ReciboBaja.TabIndex = 17
        Me.btn_ReciboBaja.Text = "&Recibo Baja"
        Me.btn_ReciboBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ReciboBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ReciboBaja.UseVisualStyleBackColor = True
        Me.btn_ReciboBaja.Visible = False
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 15)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(573, 20)
        Me.tbx_Buscar.TabIndex = 1
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(286, 69)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 10
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(9, 70)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 8
        Me.lbl_Status.Text = "Status"
        '
        'btn_Gestion
        '
        Me.btn_Gestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Gestion.Image = Global.Modulo_Ventas.My.Resources.Resources.cajafuerte
        Me.btn_Gestion.Location = New System.Drawing.Point(295, 567)
        Me.btn_Gestion.Name = "btn_Gestion"
        Me.btn_Gestion.Size = New System.Drawing.Size(140, 30)
        Me.btn_Gestion.TabIndex = 15
        Me.btn_Gestion.Text = "&Gestion"
        Me.btn_Gestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Gestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Gestion.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(149, 567)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 14
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(763, 567)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 18
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(441, 567)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 16
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(3, 567)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 13
        Me.Btn_Baja.Text = "&Baja"
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(631, 13)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(6, 18)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.grp_DimensionI)
        Me.Tab_Nuevo.Controls.Add(Me.grp_DimensionE)
        Me.Tab_Nuevo.Controls.Add(Me.grp_InfoGeneral)
        Me.Tab_Nuevo.Controls.Add(Me.grp_InfoCompra)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(906, 605)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'grp_DimensionI
        '
        Me.grp_DimensionI.Controls.Add(Me.lbl_6)
        Me.grp_DimensionI.Controls.Add(Me.lbl_cm5)
        Me.grp_DimensionI.Controls.Add(Me.lbl_cm4)
        Me.grp_DimensionI.Controls.Add(Me.tbx_FondoI)
        Me.grp_DimensionI.Controls.Add(Me.lbl_AnchoI)
        Me.grp_DimensionI.Controls.Add(Me.lbl_FondoI)
        Me.grp_DimensionI.Controls.Add(Me.tbx_AnchoI)
        Me.grp_DimensionI.Controls.Add(Me.tbx_AltoI)
        Me.grp_DimensionI.Controls.Add(Me.lbl_AltoI)
        Me.grp_DimensionI.Location = New System.Drawing.Point(390, 323)
        Me.grp_DimensionI.Name = "grp_DimensionI"
        Me.grp_DimensionI.Size = New System.Drawing.Size(409, 54)
        Me.grp_DimensionI.TabIndex = 2
        Me.grp_DimensionI.TabStop = False
        Me.grp_DimensionI.Text = "Dimensiones Interiores"
        '
        'lbl_6
        '
        Me.lbl_6.AutoSize = True
        Me.lbl_6.Location = New System.Drawing.Point(331, 26)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(21, 13)
        Me.lbl_6.TabIndex = 8
        Me.lbl_6.Text = "cm"
        Me.lbl_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm5
        '
        Me.lbl_cm5.AutoSize = True
        Me.lbl_cm5.Location = New System.Drawing.Point(220, 26)
        Me.lbl_cm5.Name = "lbl_cm5"
        Me.lbl_cm5.Size = New System.Drawing.Size(21, 13)
        Me.lbl_cm5.TabIndex = 5
        Me.lbl_cm5.Text = "cm"
        Me.lbl_cm5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm4
        '
        Me.lbl_cm4.AutoSize = True
        Me.lbl_cm4.Location = New System.Drawing.Point(105, 26)
        Me.lbl_cm4.Name = "lbl_cm4"
        Me.lbl_cm4.Size = New System.Drawing.Size(21, 13)
        Me.lbl_cm4.TabIndex = 2
        Me.lbl_cm4.Text = "cm"
        Me.lbl_cm4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_AnchoI
        '
        Me.lbl_AnchoI.AutoSize = True
        Me.lbl_AnchoI.Location = New System.Drawing.Point(135, 26)
        Me.lbl_AnchoI.Name = "lbl_AnchoI"
        Me.lbl_AnchoI.Size = New System.Drawing.Size(38, 13)
        Me.lbl_AnchoI.TabIndex = 3
        Me.lbl_AnchoI.Text = "Ancho"
        Me.lbl_AnchoI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_FondoI
        '
        Me.lbl_FondoI.AutoSize = True
        Me.lbl_FondoI.Location = New System.Drawing.Point(250, 26)
        Me.lbl_FondoI.Name = "lbl_FondoI"
        Me.lbl_FondoI.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FondoI.TabIndex = 6
        Me.lbl_FondoI.Text = "Fondo"
        Me.lbl_FondoI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_AltoI
        '
        Me.lbl_AltoI.AutoSize = True
        Me.lbl_AltoI.Location = New System.Drawing.Point(33, 26)
        Me.lbl_AltoI.Name = "lbl_AltoI"
        Me.lbl_AltoI.Size = New System.Drawing.Size(25, 13)
        Me.lbl_AltoI.TabIndex = 0
        Me.lbl_AltoI.Text = "Alto"
        Me.lbl_AltoI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grp_DimensionE
        '
        Me.grp_DimensionE.Controls.Add(Me.lbl_cm3)
        Me.grp_DimensionE.Controls.Add(Me.lbl_cm2)
        Me.grp_DimensionE.Controls.Add(Me.lbl_cm1)
        Me.grp_DimensionE.Controls.Add(Me.tbx_FondoE)
        Me.grp_DimensionE.Controls.Add(Me.lbl_AnchoE)
        Me.grp_DimensionE.Controls.Add(Me.lbl_FondoE)
        Me.grp_DimensionE.Controls.Add(Me.tbx_AnchoE)
        Me.grp_DimensionE.Controls.Add(Me.tbx_AltoE)
        Me.grp_DimensionE.Controls.Add(Me.lbl_AltoE)
        Me.grp_DimensionE.Location = New System.Drawing.Point(8, 323)
        Me.grp_DimensionE.Name = "grp_DimensionE"
        Me.grp_DimensionE.Size = New System.Drawing.Size(376, 54)
        Me.grp_DimensionE.TabIndex = 1
        Me.grp_DimensionE.TabStop = False
        Me.grp_DimensionE.Text = "Dimensiones Exteriores"
        '
        'lbl_cm3
        '
        Me.lbl_cm3.AutoSize = True
        Me.lbl_cm3.Location = New System.Drawing.Point(331, 26)
        Me.lbl_cm3.Name = "lbl_cm3"
        Me.lbl_cm3.Size = New System.Drawing.Size(21, 13)
        Me.lbl_cm3.TabIndex = 8
        Me.lbl_cm3.Text = "cm"
        Me.lbl_cm3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm2
        '
        Me.lbl_cm2.AutoSize = True
        Me.lbl_cm2.Location = New System.Drawing.Point(220, 26)
        Me.lbl_cm2.Name = "lbl_cm2"
        Me.lbl_cm2.Size = New System.Drawing.Size(21, 13)
        Me.lbl_cm2.TabIndex = 5
        Me.lbl_cm2.Text = "cm"
        Me.lbl_cm2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cm1
        '
        Me.lbl_cm1.AutoSize = True
        Me.lbl_cm1.Location = New System.Drawing.Point(110, 26)
        Me.lbl_cm1.Name = "lbl_cm1"
        Me.lbl_cm1.Size = New System.Drawing.Size(21, 13)
        Me.lbl_cm1.TabIndex = 2
        Me.lbl_cm1.Text = "cm"
        Me.lbl_cm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_AnchoE
        '
        Me.lbl_AnchoE.AutoSize = True
        Me.lbl_AnchoE.Location = New System.Drawing.Point(138, 26)
        Me.lbl_AnchoE.Name = "lbl_AnchoE"
        Me.lbl_AnchoE.Size = New System.Drawing.Size(38, 13)
        Me.lbl_AnchoE.TabIndex = 3
        Me.lbl_AnchoE.Text = "Ancho"
        Me.lbl_AnchoE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_FondoE
        '
        Me.lbl_FondoE.AutoSize = True
        Me.lbl_FondoE.Location = New System.Drawing.Point(250, 26)
        Me.lbl_FondoE.Name = "lbl_FondoE"
        Me.lbl_FondoE.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FondoE.TabIndex = 6
        Me.lbl_FondoE.Text = "Fondo"
        Me.lbl_FondoE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_AltoE
        '
        Me.lbl_AltoE.AutoSize = True
        Me.lbl_AltoE.Location = New System.Drawing.Point(40, 26)
        Me.lbl_AltoE.Name = "lbl_AltoE"
        Me.lbl_AltoE.Size = New System.Drawing.Size(25, 13)
        Me.lbl_AltoE.TabIndex = 0
        Me.lbl_AltoE.Text = "Alto"
        Me.lbl_AltoE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grp_InfoGeneral
        '
        Me.grp_InfoGeneral.Controls.Add(Me.grp_detallescomb)
        Me.grp_InfoGeneral.Controls.Add(Me.pnl_des2)
        Me.grp_InfoGeneral.Controls.Add(Me.tbx_Combinacion1)
        Me.grp_InfoGeneral.Controls.Add(Me.pnl_des)
        Me.grp_InfoGeneral.Controls.Add(Me.lbl_Combinacion)
        Me.grp_InfoGeneral.Controls.Add(Me.tbx_Combinacion0)
        Me.grp_InfoGeneral.Controls.Add(Me.tbx_Combinacion2)
        Me.grp_InfoGeneral.Controls.Add(Me.lbl_CombinacionA)
        Me.grp_InfoGeneral.Location = New System.Drawing.Point(8, 6)
        Me.grp_InfoGeneral.Name = "grp_InfoGeneral"
        Me.grp_InfoGeneral.Size = New System.Drawing.Size(791, 311)
        Me.grp_InfoGeneral.TabIndex = 0
        Me.grp_InfoGeneral.TabStop = False
        Me.grp_InfoGeneral.Text = "Información General"
        '
        'grp_detallescomb
        '
        Me.grp_detallescomb.Controls.Add(Me.ltb_LogCombinacion)
        Me.grp_detallescomb.Location = New System.Drawing.Point(553, 19)
        Me.grp_detallescomb.Name = "grp_detallescomb"
        Me.grp_detallescomb.Size = New System.Drawing.Size(212, 162)
        Me.grp_detallescomb.TabIndex = 36
        Me.grp_detallescomb.TabStop = False
        Me.grp_detallescomb.Text = "Detalles de combinación"
        '
        'ltb_LogCombinacion
        '
        Me.ltb_LogCombinacion.Enabled = False
        Me.ltb_LogCombinacion.FormattingEnabled = True
        Me.ltb_LogCombinacion.Location = New System.Drawing.Point(7, 17)
        Me.ltb_LogCombinacion.Name = "ltb_LogCombinacion"
        Me.ltb_LogCombinacion.Size = New System.Drawing.Size(198, 134)
        Me.ltb_LogCombinacion.TabIndex = 0
        '
        'pnl_des2
        '
        Me.pnl_des2.Controls.Add(Me.dtp_Fabricacion)
        Me.pnl_des2.Controls.Add(Me.lbl_FechaFabricacion)
        Me.pnl_des2.Controls.Add(Me.lbl_FechaFabricacionA)
        Me.pnl_des2.Controls.Add(Me.cmb_Nueva)
        Me.pnl_des2.Controls.Add(Me.chk_Retiro)
        Me.pnl_des2.Controls.Add(Me.lbl_Nueva)
        Me.pnl_des2.Controls.Add(Me.lbl_NuevaA)
        Me.pnl_des2.Controls.Add(Me.lbl_CombinacionCliente)
        Me.pnl_des2.Controls.Add(Me.lbl_FechaRetiroA)
        Me.pnl_des2.Controls.Add(Me.tbx_CombinacionCliente)
        Me.pnl_des2.Controls.Add(Me.dtp_FechaRetiro)
        Me.pnl_des2.Controls.Add(Me.lbl_FechaRetiro)
        Me.pnl_des2.Location = New System.Drawing.Point(2, 213)
        Me.pnl_des2.Name = "pnl_des2"
        Me.pnl_des2.Size = New System.Drawing.Size(545, 87)
        Me.pnl_des2.TabIndex = 35
        '
        'dtp_Fabricacion
        '
        Me.dtp_Fabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fabricacion.Location = New System.Drawing.Point(168, 30)
        Me.dtp_Fabricacion.Name = "dtp_Fabricacion"
        Me.dtp_Fabricacion.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fabricacion.TabIndex = 25
        '
        'lbl_FechaFabricacion
        '
        Me.lbl_FechaFabricacion.AutoSize = True
        Me.lbl_FechaFabricacion.Location = New System.Drawing.Point(49, 32)
        Me.lbl_FechaFabricacion.Name = "lbl_FechaFabricacion"
        Me.lbl_FechaFabricacion.Size = New System.Drawing.Size(110, 13)
        Me.lbl_FechaFabricacion.TabIndex = 24
        Me.lbl_FechaFabricacion.Text = "Fecha de Fabricación"
        Me.lbl_FechaFabricacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_FechaFabricacionA
        '
        Me.lbl_FechaFabricacionA.AutoSize = True
        Me.lbl_FechaFabricacionA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaFabricacionA.ForeColor = System.Drawing.Color.Red
        Me.lbl_FechaFabricacionA.Location = New System.Drawing.Point(277, 32)
        Me.lbl_FechaFabricacionA.Name = "lbl_FechaFabricacionA"
        Me.lbl_FechaFabricacionA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_FechaFabricacionA.TabIndex = 26
        Me.lbl_FechaFabricacionA.Text = "*"
        '
        'dtp_Compra
        '
        Me.dtp_Compra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Compra.Location = New System.Drawing.Point(165, 40)
        Me.dtp_Compra.Name = "dtp_Compra"
        Me.dtp_Compra.Size = New System.Drawing.Size(111, 20)
        Me.dtp_Compra.TabIndex = 6
        '
        'chk_Retiro
        '
        Me.chk_Retiro.AutoSize = True
        Me.chk_Retiro.Enabled = False
        Me.chk_Retiro.Location = New System.Drawing.Point(296, 57)
        Me.chk_Retiro.Name = "chk_Retiro"
        Me.chk_Retiro.Size = New System.Drawing.Size(72, 17)
        Me.chk_Retiro.TabIndex = 33
        Me.chk_Retiro.Text = "No Aplica"
        Me.chk_Retiro.UseVisualStyleBackColor = True
        '
        'lbl_Nueva
        '
        Me.lbl_Nueva.AutoSize = True
        Me.lbl_Nueva.Location = New System.Drawing.Point(293, 36)
        Me.lbl_Nueva.Name = "lbl_Nueva"
        Me.lbl_Nueva.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Nueva.TabIndex = 27
        Me.lbl_Nueva.Text = "Nueva"
        Me.lbl_Nueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_NuevaA
        '
        Me.lbl_NuevaA.AutoSize = True
        Me.lbl_NuevaA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NuevaA.ForeColor = System.Drawing.Color.Red
        Me.lbl_NuevaA.Location = New System.Drawing.Point(435, 36)
        Me.lbl_NuevaA.Name = "lbl_NuevaA"
        Me.lbl_NuevaA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_NuevaA.TabIndex = 29
        Me.lbl_NuevaA.Text = "*"
        '
        'lbl_CombinacionCliente
        '
        Me.lbl_CombinacionCliente.AutoSize = True
        Me.lbl_CombinacionCliente.Location = New System.Drawing.Point(7, 6)
        Me.lbl_CombinacionCliente.Name = "lbl_CombinacionCliente"
        Me.lbl_CombinacionCliente.Size = New System.Drawing.Size(155, 13)
        Me.lbl_CombinacionCliente.TabIndex = 22
        Me.lbl_CombinacionCliente.Text = "Tiene el Cliente la Combinación"
        Me.lbl_CombinacionCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_FechaRetiroA
        '
        Me.lbl_FechaRetiroA.AutoSize = True
        Me.lbl_FechaRetiroA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaRetiroA.ForeColor = System.Drawing.Color.Red
        Me.lbl_FechaRetiroA.Location = New System.Drawing.Point(277, 58)
        Me.lbl_FechaRetiroA.Name = "lbl_FechaRetiroA"
        Me.lbl_FechaRetiroA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_FechaRetiroA.TabIndex = 32
        Me.lbl_FechaRetiroA.Text = "*"
        Me.lbl_FechaRetiroA.Visible = False
        '
        'dtp_FechaRetiro
        '
        Me.dtp_FechaRetiro.Enabled = False
        Me.dtp_FechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaRetiro.Location = New System.Drawing.Point(168, 54)
        Me.dtp_FechaRetiro.Name = "dtp_FechaRetiro"
        Me.dtp_FechaRetiro.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaRetiro.TabIndex = 31
        '
        'lbl_FechaRetiro
        '
        Me.lbl_FechaRetiro.AutoSize = True
        Me.lbl_FechaRetiro.Enabled = False
        Me.lbl_FechaRetiro.Location = New System.Drawing.Point(57, 58)
        Me.lbl_FechaRetiro.Name = "lbl_FechaRetiro"
        Me.lbl_FechaRetiro.Size = New System.Drawing.Size(105, 13)
        Me.lbl_FechaRetiro.TabIndex = 30
        Me.lbl_FechaRetiro.Text = "Fin de Renta (Retiro)"
        Me.lbl_FechaRetiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl_des
        '
        Me.pnl_des.Controls.Add(Me.cmb_CajaFuerteT)
        Me.pnl_des.Controls.Add(Me.tbx_Marca)
        Me.pnl_des.Controls.Add(Me.lbl_Marca)
        Me.pnl_des.Controls.Add(Me.lbl_Peso)
        Me.pnl_des.Controls.Add(Me.tbx_ClaveCajaFuerte)
        Me.pnl_des.Controls.Add(Me.tbx_Peso)
        Me.pnl_des.Controls.Add(Me.tbx_Modelo)
        Me.pnl_des.Controls.Add(Me.lbl_pesokg)
        Me.pnl_des.Controls.Add(Me.lbl_ClaveCajaFuerte)
        Me.pnl_des.Controls.Add(Me.lbl_Serie)
        Me.pnl_des.Controls.Add(Me.tbx_Serie)
        Me.pnl_des.Controls.Add(Me.lbl_CajaFuerteT)
        Me.pnl_des.Controls.Add(Me.lbl_Modelo)
        Me.pnl_des.Controls.Add(Me.lbl_CajaFuerteTA)
        Me.pnl_des.Controls.Add(Me.lbl_MarcaA)
        Me.pnl_des.Controls.Add(Me.lbl_SerieA)
        Me.pnl_des.Location = New System.Drawing.Point(63, 19)
        Me.pnl_des.Name = "pnl_des"
        Me.pnl_des.Size = New System.Drawing.Size(484, 162)
        Me.pnl_des.TabIndex = 34
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(64, 60)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Marca.TabIndex = 6
        Me.lbl_Marca.Text = "Marca"
        Me.lbl_Marca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Peso
        '
        Me.lbl_Peso.AutoSize = True
        Me.lbl_Peso.Location = New System.Drawing.Point(70, 139)
        Me.lbl_Peso.Name = "lbl_Peso"
        Me.lbl_Peso.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Peso.TabIndex = 14
        Me.lbl_Peso.Text = "Peso"
        Me.lbl_Peso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_pesokg
        '
        Me.lbl_pesokg.AutoSize = True
        Me.lbl_pesokg.Location = New System.Drawing.Point(159, 139)
        Me.lbl_pesokg.Name = "lbl_pesokg"
        Me.lbl_pesokg.Size = New System.Drawing.Size(19, 13)
        Me.lbl_pesokg.TabIndex = 16
        Me.lbl_pesokg.Text = "kg"
        Me.lbl_pesokg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_ClaveCajaFuerte
        '
        Me.lbl_ClaveCajaFuerte.AutoSize = True
        Me.lbl_ClaveCajaFuerte.Location = New System.Drawing.Point(67, 34)
        Me.lbl_ClaveCajaFuerte.Name = "lbl_ClaveCajaFuerte"
        Me.lbl_ClaveCajaFuerte.Size = New System.Drawing.Size(34, 13)
        Me.lbl_ClaveCajaFuerte.TabIndex = 3
        Me.lbl_ClaveCajaFuerte.Text = "Clave"
        Me.lbl_ClaveCajaFuerte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Serie
        '
        Me.lbl_Serie.AutoSize = True
        Me.lbl_Serie.Location = New System.Drawing.Point(70, 112)
        Me.lbl_Serie.Name = "lbl_Serie"
        Me.lbl_Serie.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Serie.TabIndex = 11
        Me.lbl_Serie.Text = "Serie"
        Me.lbl_Serie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CajaFuerteT
        '
        Me.lbl_CajaFuerteT.AutoSize = True
        Me.lbl_CajaFuerteT.Location = New System.Drawing.Point(1, 7)
        Me.lbl_CajaFuerteT.Name = "lbl_CajaFuerteT"
        Me.lbl_CajaFuerteT.Size = New System.Drawing.Size(100, 13)
        Me.lbl_CajaFuerteT.TabIndex = 0
        Me.lbl_CajaFuerteT.Text = "Tipo de Caja Fuerte"
        Me.lbl_CajaFuerteT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(59, 86)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Modelo.TabIndex = 9
        Me.lbl_Modelo.Text = "Modelo"
        Me.lbl_Modelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CajaFuerteTA
        '
        Me.lbl_CajaFuerteTA.AutoSize = True
        Me.lbl_CajaFuerteTA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CajaFuerteTA.ForeColor = System.Drawing.Color.Red
        Me.lbl_CajaFuerteTA.Location = New System.Drawing.Point(463, 7)
        Me.lbl_CajaFuerteTA.Name = "lbl_CajaFuerteTA"
        Me.lbl_CajaFuerteTA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_CajaFuerteTA.TabIndex = 2
        Me.lbl_CajaFuerteTA.Text = "*"
        '
        'lbl_MarcaA
        '
        Me.lbl_MarcaA.AutoSize = True
        Me.lbl_MarcaA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MarcaA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MarcaA.Location = New System.Drawing.Point(463, 56)
        Me.lbl_MarcaA.Name = "lbl_MarcaA"
        Me.lbl_MarcaA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_MarcaA.TabIndex = 8
        Me.lbl_MarcaA.Text = "*"
        '
        'lbl_SerieA
        '
        Me.lbl_SerieA.AutoSize = True
        Me.lbl_SerieA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SerieA.ForeColor = System.Drawing.Color.Red
        Me.lbl_SerieA.Location = New System.Drawing.Point(223, 110)
        Me.lbl_SerieA.Name = "lbl_SerieA"
        Me.lbl_SerieA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_SerieA.TabIndex = 13
        Me.lbl_SerieA.Text = "*"
        '
        'lbl_Combinacion
        '
        Me.lbl_Combinacion.AutoSize = True
        Me.lbl_Combinacion.Location = New System.Drawing.Point(96, 190)
        Me.lbl_Combinacion.Name = "lbl_Combinacion"
        Me.lbl_Combinacion.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Combinacion.TabIndex = 17
        Me.lbl_Combinacion.Text = "Combinación"
        Me.lbl_Combinacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_CombinacionA
        '
        Me.lbl_CombinacionA.AutoSize = True
        Me.lbl_CombinacionA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CombinacionA.ForeColor = System.Drawing.Color.Red
        Me.lbl_CombinacionA.Location = New System.Drawing.Point(330, 188)
        Me.lbl_CombinacionA.Name = "lbl_CombinacionA"
        Me.lbl_CombinacionA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_CombinacionA.TabIndex = 21
        Me.lbl_CombinacionA.Text = "*"
        '
        'grp_InfoCompra
        '
        Me.grp_InfoCompra.Controls.Add(Me.Pnl_infocompra)
        Me.grp_InfoCompra.Controls.Add(Me.rtb_Observaciones)
        Me.grp_InfoCompra.Controls.Add(Me.lbl_Observaciones)
        Me.grp_InfoCompra.Location = New System.Drawing.Point(8, 387)
        Me.grp_InfoCompra.Name = "grp_InfoCompra"
        Me.grp_InfoCompra.Size = New System.Drawing.Size(791, 167)
        Me.grp_InfoCompra.TabIndex = 3
        Me.grp_InfoCompra.TabStop = False
        Me.grp_InfoCompra.Text = "Información de Compra"
        '
        'Pnl_infocompra
        '
        Me.Pnl_infocompra.Controls.Add(Me.cmb_ClienteAsignado)
        Me.Pnl_infocompra.Controls.Add(Me.btn_BuscarProveedores)
        Me.Pnl_infocompra.Controls.Add(Me.cmb_Proveedor)
        Me.Pnl_infocompra.Controls.Add(Me.dtp_CompraA)
        Me.Pnl_infocompra.Controls.Add(Me.tbx_Proveedor)
        Me.Pnl_infocompra.Controls.Add(Me.tbx_ProveedorA)
        Me.Pnl_infocompra.Controls.Add(Me.lbl_Proveedor)
        Me.Pnl_infocompra.Controls.Add(Me.lbl_FechaCompra)
        Me.Pnl_infocompra.Controls.Add(Me.dtp_Compra)
        Me.Pnl_infocompra.Location = New System.Drawing.Point(2, 22)
        Me.Pnl_infocompra.Name = "Pnl_infocompra"
        Me.Pnl_infocompra.Size = New System.Drawing.Size(763, 67)
        Me.Pnl_infocompra.TabIndex = 10
        '
        'btn_BuscarProveedores
        '
        Me.btn_BuscarProveedores.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarProveedores.Location = New System.Drawing.Point(659, 11)
        Me.btn_BuscarProveedores.Name = "btn_BuscarProveedores"
        Me.btn_BuscarProveedores.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarProveedores.TabIndex = 4
        Me.btn_BuscarProveedores.UseVisualStyleBackColor = True
        '
        'dtp_CompraA
        '
        Me.dtp_CompraA.AutoSize = True
        Me.dtp_CompraA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_CompraA.ForeColor = System.Drawing.Color.Red
        Me.dtp_CompraA.Location = New System.Drawing.Point(282, 44)
        Me.dtp_CompraA.Name = "dtp_CompraA"
        Me.dtp_CompraA.Size = New System.Drawing.Size(13, 16)
        Me.dtp_CompraA.TabIndex = 7
        Me.dtp_CompraA.Text = "*"
        '
        'tbx_ProveedorA
        '
        Me.tbx_ProveedorA.AutoSize = True
        Me.tbx_ProveedorA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ProveedorA.ForeColor = System.Drawing.Color.Red
        Me.tbx_ProveedorA.Location = New System.Drawing.Point(640, 14)
        Me.tbx_ProveedorA.Name = "tbx_ProveedorA"
        Me.tbx_ProveedorA.Size = New System.Drawing.Size(13, 16)
        Me.tbx_ProveedorA.TabIndex = 3
        Me.tbx_ProveedorA.Text = "*"
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(103, 16)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Proveedor.TabIndex = 0
        Me.lbl_Proveedor.Text = "Proveedor"
        Me.lbl_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_FechaCompra
        '
        Me.lbl_FechaCompra.AutoSize = True
        Me.lbl_FechaCompra.Location = New System.Drawing.Point(68, 46)
        Me.lbl_FechaCompra.Name = "lbl_FechaCompra"
        Me.lbl_FechaCompra.Size = New System.Drawing.Size(91, 13)
        Me.lbl_FechaCompra.TabIndex = 5
        Me.lbl_FechaCompra.Text = "Fecha de Compra"
        Me.lbl_FechaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(167, 100)
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(520, 54)
        Me.rtb_Observaciones.TabIndex = 9
        Me.rtb_Observaciones.Text = ""
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(83, 105)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 8
        Me.lbl_Observaciones.Text = "Observaciones"
        Me.lbl_Observaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(321, 560)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(175, 560)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 4
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(52, 41)
        Me.tbx_Cliente.MaxLength = 10
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Cliente.TabIndex = 4
        Me.tbx_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
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
        Me.cmb_Cliente.Location = New System.Drawing.Point(107, 41)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_GetNoProspectos"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 5
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.tbx_Buscar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(52, 67)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Status.TabIndex = 9
        Me.cmb_Status.ValueMember = "value"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 109)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 7
        Me.lsv_Catalogo.Row10 = 8
        Me.lsv_Catalogo.Row2 = 8
        Me.lsv_Catalogo.Row3 = 8
        Me.lsv_Catalogo.Row4 = 8
        Me.lsv_Catalogo.Row5 = 7
        Me.lsv_Catalogo.Row6 = 12
        Me.lsv_Catalogo.Row7 = 12
        Me.lsv_Catalogo.Row8 = 8
        Me.lsv_Catalogo.Row9 = 8
        Me.lsv_Catalogo.Size = New System.Drawing.Size(900, 452)
        Me.lsv_Catalogo.TabIndex = 12
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_FondoI
        '
        Me.tbx_FondoI.Control_Siguiente = Nothing
        Me.tbx_FondoI.Filtrado = True
        Me.tbx_FondoI.Location = New System.Drawing.Point(293, 23)
        Me.tbx_FondoI.MaxLength = 20
        Me.tbx_FondoI.Name = "tbx_FondoI"
        Me.tbx_FondoI.ReadOnly = True
        Me.tbx_FondoI.Size = New System.Drawing.Size(35, 20)
        Me.tbx_FondoI.TabIndex = 7
        Me.tbx_FondoI.TabStop = False
        Me.tbx_FondoI.Text = "0"
        Me.tbx_FondoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_FondoI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_AnchoI
        '
        Me.tbx_AnchoI.Control_Siguiente = Nothing
        Me.tbx_AnchoI.Filtrado = True
        Me.tbx_AnchoI.Location = New System.Drawing.Point(179, 23)
        Me.tbx_AnchoI.MaxLength = 20
        Me.tbx_AnchoI.Name = "tbx_AnchoI"
        Me.tbx_AnchoI.ReadOnly = True
        Me.tbx_AnchoI.Size = New System.Drawing.Size(35, 20)
        Me.tbx_AnchoI.TabIndex = 4
        Me.tbx_AnchoI.TabStop = False
        Me.tbx_AnchoI.Text = "0"
        Me.tbx_AnchoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AnchoI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_AltoI
        '
        Me.tbx_AltoI.Control_Siguiente = Nothing
        Me.tbx_AltoI.Filtrado = True
        Me.tbx_AltoI.Location = New System.Drawing.Point(64, 23)
        Me.tbx_AltoI.MaxLength = 20
        Me.tbx_AltoI.Name = "tbx_AltoI"
        Me.tbx_AltoI.ReadOnly = True
        Me.tbx_AltoI.Size = New System.Drawing.Size(35, 20)
        Me.tbx_AltoI.TabIndex = 1
        Me.tbx_AltoI.TabStop = False
        Me.tbx_AltoI.Text = "0"
        Me.tbx_AltoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AltoI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_FondoE
        '
        Me.tbx_FondoE.Control_Siguiente = Nothing
        Me.tbx_FondoE.Filtrado = True
        Me.tbx_FondoE.Location = New System.Drawing.Point(293, 23)
        Me.tbx_FondoE.MaxLength = 20
        Me.tbx_FondoE.Name = "tbx_FondoE"
        Me.tbx_FondoE.ReadOnly = True
        Me.tbx_FondoE.Size = New System.Drawing.Size(35, 20)
        Me.tbx_FondoE.TabIndex = 7
        Me.tbx_FondoE.TabStop = False
        Me.tbx_FondoE.Text = "0"
        Me.tbx_FondoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_FondoE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_AnchoE
        '
        Me.tbx_AnchoE.Control_Siguiente = Nothing
        Me.tbx_AnchoE.Filtrado = True
        Me.tbx_AnchoE.Location = New System.Drawing.Point(182, 23)
        Me.tbx_AnchoE.MaxLength = 20
        Me.tbx_AnchoE.Name = "tbx_AnchoE"
        Me.tbx_AnchoE.ReadOnly = True
        Me.tbx_AnchoE.Size = New System.Drawing.Size(35, 20)
        Me.tbx_AnchoE.TabIndex = 4
        Me.tbx_AnchoE.TabStop = False
        Me.tbx_AnchoE.Text = "0"
        Me.tbx_AnchoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AnchoE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_AltoE
        '
        Me.tbx_AltoE.Control_Siguiente = Nothing
        Me.tbx_AltoE.Filtrado = True
        Me.tbx_AltoE.Location = New System.Drawing.Point(71, 23)
        Me.tbx_AltoE.MaxLength = 20
        Me.tbx_AltoE.Name = "tbx_AltoE"
        Me.tbx_AltoE.ReadOnly = True
        Me.tbx_AltoE.Size = New System.Drawing.Size(35, 20)
        Me.tbx_AltoE.TabIndex = 1
        Me.tbx_AltoE.TabStop = False
        Me.tbx_AltoE.Text = "0"
        Me.tbx_AltoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_AltoE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Nueva
        '
        Me.cmb_Nueva.Control_Siguiente = Me.cmb_Proveedor
        Me.cmb_Nueva.DisplayMember = "display"
        Me.cmb_Nueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Nueva.FormattingEnabled = True
        Me.cmb_Nueva.Location = New System.Drawing.Point(338, 32)
        Me.cmb_Nueva.MaxDropDownItems = 20
        Me.cmb_Nueva.Name = "cmb_Nueva"
        Me.cmb_Nueva.Size = New System.Drawing.Size(91, 21)
        Me.cmb_Nueva.TabIndex = 28
        Me.cmb_Nueva.ValueMember = "value"
        '
        'cmb_Proveedor
        '
        Me.cmb_Proveedor.Clave = "Clave"
        Me.cmb_Proveedor.Control_Siguiente = Me.dtp_Compra
        Me.cmb_Proveedor.DisplayMember = "Nombre"
        Me.cmb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Proveedor.Empresa = False
        Me.cmb_Proveedor.Filtro = Me.tbx_Proveedor
        Me.cmb_Proveedor.FormattingEnabled = True
        Me.cmb_Proveedor.Location = New System.Drawing.Point(234, 13)
        Me.cmb_Proveedor.MaxDropDownItems = 20
        Me.cmb_Proveedor.Name = "cmb_Proveedor"
        Me.cmb_Proveedor.Pista = True
        Me.cmb_Proveedor.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Proveedor.StoredProcedure = "Cat_Proveedores_Get"
        Me.cmb_Proveedor.Sucursal = False
        Me.cmb_Proveedor.TabIndex = 2
        Me.cmb_Proveedor.Tipo = 0
        Me.cmb_Proveedor.ValueMember = "Id_Proveedor"
        '
        'tbx_Proveedor
        '
        Me.tbx_Proveedor.Control_Siguiente = Me.cmb_Proveedor
        Me.tbx_Proveedor.Filtrado = True
        Me.tbx_Proveedor.Location = New System.Drawing.Point(165, 13)
        Me.tbx_Proveedor.MaxLength = 10
        Me.tbx_Proveedor.Name = "tbx_Proveedor"
        Me.tbx_Proveedor.Size = New System.Drawing.Size(63, 20)
        Me.tbx_Proveedor.TabIndex = 1
        Me.tbx_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Proveedor.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CombinacionCliente
        '
        Me.tbx_CombinacionCliente.Control_Siguiente = Me.dtp_Fabricacion
        Me.tbx_CombinacionCliente.Filtrado = True
        Me.tbx_CombinacionCliente.Location = New System.Drawing.Point(168, 3)
        Me.tbx_CombinacionCliente.MaxLength = 2
        Me.tbx_CombinacionCliente.Name = "tbx_CombinacionCliente"
        Me.tbx_CombinacionCliente.ReadOnly = True
        Me.tbx_CombinacionCliente.Size = New System.Drawing.Size(35, 20)
        Me.tbx_CombinacionCliente.TabIndex = 23
        Me.tbx_CombinacionCliente.TabStop = False
        Me.tbx_CombinacionCliente.Text = "NO"
        Me.tbx_CombinacionCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'tbx_Combinacion1
        '
        Me.tbx_Combinacion1.Control_Siguiente = Me.tbx_Combinacion2
        Me.tbx_Combinacion1.Filtrado = True
        Me.tbx_Combinacion1.Location = New System.Drawing.Point(223, 190)
        Me.tbx_Combinacion1.MaxLength = 2
        Me.tbx_Combinacion1.Name = "tbx_Combinacion1"
        Me.tbx_Combinacion1.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Combinacion1.TabIndex = 19
        Me.tbx_Combinacion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Combinacion1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Combinacion2
        '
        Me.tbx_Combinacion2.Control_Siguiente = Me.dtp_Fabricacion
        Me.tbx_Combinacion2.Filtrado = True
        Me.tbx_Combinacion2.Location = New System.Drawing.Point(274, 190)
        Me.tbx_Combinacion2.MaxLength = 2
        Me.tbx_Combinacion2.Name = "tbx_Combinacion2"
        Me.tbx_Combinacion2.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Combinacion2.TabIndex = 20
        Me.tbx_Combinacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Combinacion2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_CajaFuerteT
        '
        Me.cmb_CajaFuerteT.Clave = Nothing
        Me.cmb_CajaFuerteT.Control_Siguiente = Me.tbx_ClaveCajaFuerte
        Me.cmb_CajaFuerteT.DisplayMember = "Descripcion"
        Me.cmb_CajaFuerteT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaFuerteT.Empresa = False
        Me.cmb_CajaFuerteT.Filtro = Nothing
        Me.cmb_CajaFuerteT.FormattingEnabled = True
        Me.cmb_CajaFuerteT.Location = New System.Drawing.Point(107, 4)
        Me.cmb_CajaFuerteT.MaxDropDownItems = 20
        Me.cmb_CajaFuerteT.Name = "cmb_CajaFuerteT"
        Me.cmb_CajaFuerteT.Pista = False
        Me.cmb_CajaFuerteT.Size = New System.Drawing.Size(350, 21)
        Me.cmb_CajaFuerteT.StoredProcedure = "Cat_CajasFuertesT_GetCombo"
        Me.cmb_CajaFuerteT.Sucursal = False
        Me.cmb_CajaFuerteT.TabIndex = 1
        Me.cmb_CajaFuerteT.Tipo = 0
        Me.cmb_CajaFuerteT.ValueMember = "Id_CajaFuerteT"
        '
        'tbx_ClaveCajaFuerte
        '
        Me.tbx_ClaveCajaFuerte.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ClaveCajaFuerte.Control_Siguiente = Me.tbx_Marca
        Me.tbx_ClaveCajaFuerte.Filtrado = True
        Me.tbx_ClaveCajaFuerte.Location = New System.Drawing.Point(107, 31)
        Me.tbx_ClaveCajaFuerte.MaxLength = 4
        Me.tbx_ClaveCajaFuerte.Name = "tbx_ClaveCajaFuerte"
        Me.tbx_ClaveCajaFuerte.ReadOnly = True
        Me.tbx_ClaveCajaFuerte.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveCajaFuerte.TabIndex = 4
        Me.tbx_ClaveCajaFuerte.TabStop = False
        Me.tbx_ClaveCajaFuerte.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Marca
        '
        Me.tbx_Marca.Control_Siguiente = Me.tbx_Serie
        Me.tbx_Marca.Filtrado = True
        Me.tbx_Marca.Location = New System.Drawing.Point(107, 57)
        Me.tbx_Marca.MaxLength = 50
        Me.tbx_Marca.Name = "tbx_Marca"
        Me.tbx_Marca.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Marca.TabIndex = 7
        Me.tbx_Marca.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Serie
        '
        Me.tbx_Serie.Control_Siguiente = Me.tbx_Combinacion0
        Me.tbx_Serie.Filtrado = True
        Me.tbx_Serie.Location = New System.Drawing.Point(107, 109)
        Me.tbx_Serie.MaxLength = 20
        Me.tbx_Serie.Name = "tbx_Serie"
        Me.tbx_Serie.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Serie.TabIndex = 12
        Me.tbx_Serie.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Combinacion0
        '
        Me.tbx_Combinacion0.Control_Siguiente = Me.tbx_Combinacion1
        Me.tbx_Combinacion0.Filtrado = True
        Me.tbx_Combinacion0.Location = New System.Drawing.Point(170, 190)
        Me.tbx_Combinacion0.MaxLength = 2
        Me.tbx_Combinacion0.Name = "tbx_Combinacion0"
        Me.tbx_Combinacion0.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Combinacion0.TabIndex = 18
        Me.tbx_Combinacion0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Combinacion0.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Peso
        '
        Me.tbx_Peso.Control_Siguiente = Me.tbx_Combinacion0
        Me.tbx_Peso.Filtrado = False
        Me.tbx_Peso.Location = New System.Drawing.Point(107, 135)
        Me.tbx_Peso.MaxLength = 10
        Me.tbx_Peso.Name = "tbx_Peso"
        Me.tbx_Peso.ReadOnly = True
        Me.tbx_Peso.Size = New System.Drawing.Size(46, 20)
        Me.tbx_Peso.TabIndex = 15
        Me.tbx_Peso.TabStop = False
        Me.tbx_Peso.Text = "0.00"
        Me.tbx_Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Peso.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Modelo
        '
        Me.tbx_Modelo.Control_Siguiente = Me.tbx_Serie
        Me.tbx_Modelo.Filtrado = True
        Me.tbx_Modelo.Location = New System.Drawing.Point(107, 83)
        Me.tbx_Modelo.MaxLength = 20
        Me.tbx_Modelo.Name = "tbx_Modelo"
        Me.tbx_Modelo.ReadOnly = True
        Me.tbx_Modelo.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Modelo.TabIndex = 10
        Me.tbx_Modelo.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_ClienteAsignado
        '
        Me.cmb_ClienteAsignado.Clave = "Clave_Cliente"
        Me.cmb_ClienteAsignado.Control_Siguiente = Me.dtp_Compra
        Me.cmb_ClienteAsignado.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClienteAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClienteAsignado.Empresa = False
        Me.cmb_ClienteAsignado.Filtro = Me.tbx_Proveedor
        Me.cmb_ClienteAsignado.FormattingEnabled = True
        Me.cmb_ClienteAsignado.Location = New System.Drawing.Point(234, 13)
        Me.cmb_ClienteAsignado.MaxDropDownItems = 20
        Me.cmb_ClienteAsignado.Name = "cmb_ClienteAsignado"
        Me.cmb_ClienteAsignado.Pista = False
        Me.cmb_ClienteAsignado.Size = New System.Drawing.Size(400, 21)
        Me.cmb_ClienteAsignado.StoredProcedure = "Cat_ClientesCombo_GetNoProspectos"
        Me.cmb_ClienteAsignado.Sucursal = True
        Me.cmb_ClienteAsignado.TabIndex = 10
        Me.cmb_ClienteAsignado.Tipo = 0
        Me.cmb_ClienteAsignado.ValueMember = "Id_Cliente"
        '
        'frm_CajasFuertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 631)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_CajasFuertes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Cajas Fuertes"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.grp_DimensionI.ResumeLayout(False)
        Me.grp_DimensionI.PerformLayout()
        Me.grp_DimensionE.ResumeLayout(False)
        Me.grp_DimensionE.PerformLayout()
        Me.grp_InfoGeneral.ResumeLayout(False)
        Me.grp_InfoGeneral.PerformLayout()
        Me.grp_detallescomb.ResumeLayout(False)
        Me.pnl_des2.ResumeLayout(False)
        Me.pnl_des2.PerformLayout()
        Me.pnl_des.ResumeLayout(False)
        Me.pnl_des.PerformLayout()
        Me.grp_InfoCompra.ResumeLayout(False)
        Me.grp_InfoCompra.PerformLayout()
        Me.Pnl_infocompra.ResumeLayout(False)
        Me.Pnl_infocompra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Marca As System.Windows.Forms.Label
    Friend WithEvents lbl_ClaveCajaFuerte As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_ClaveCajaFuerte As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_CajaFuerteT As System.Windows.Forms.Label
    Friend WithEvents lbl_Serie As System.Windows.Forms.Label
    Friend WithEvents tbx_Serie As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Modelo As System.Windows.Forms.Label
    Friend WithEvents tbx_Modelo As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Marca As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents dtp_Compra As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaCompra As System.Windows.Forms.Label
    Friend WithEvents dtp_Fabricacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaFabricacion As System.Windows.Forms.Label
    Friend WithEvents cmb_Proveedor As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Proveedor As Modulo_Ventas.cp_Textbox
    Friend WithEvents grp_InfoCompra As System.Windows.Forms.GroupBox
    Friend WithEvents grp_InfoGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Combinacion As System.Windows.Forms.Label
    Friend WithEvents lbl_pesokg As System.Windows.Forms.Label
    Friend WithEvents tbx_Peso As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Peso As System.Windows.Forms.Label
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents grp_DimensionI As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_FondoI As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_AnchoI As System.Windows.Forms.Label
    Friend WithEvents lbl_FondoI As System.Windows.Forms.Label
    Friend WithEvents tbx_AnchoI As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_AltoI As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_AltoI As System.Windows.Forms.Label
    Friend WithEvents grp_DimensionE As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_FondoE As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_AnchoE As System.Windows.Forms.Label
    Friend WithEvents lbl_FondoE As System.Windows.Forms.Label
    Friend WithEvents tbx_AnchoE As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_AltoE As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_AltoE As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaFabricacionA As System.Windows.Forms.Label
    Friend WithEvents lbl_CombinacionA As System.Windows.Forms.Label
    Friend WithEvents lbl_SerieA As System.Windows.Forms.Label
    Friend WithEvents lbl_MarcaA As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaFuerteTA As System.Windows.Forms.Label
    Friend WithEvents dtp_CompraA As System.Windows.Forms.Label
    Friend WithEvents tbx_ProveedorA As System.Windows.Forms.Label
    Friend WithEvents lbl_6 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm5 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm4 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm3 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cm1 As System.Windows.Forms.Label
    Friend WithEvents btn_Gestion As System.Windows.Forms.Button
    Friend WithEvents btn_BuscarProveedores As System.Windows.Forms.Button
    Friend WithEvents cmb_CajaFuerteT As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_NuevaA As System.Windows.Forms.Label
    Friend WithEvents lbl_Nueva As System.Windows.Forms.Label
    Friend WithEvents cmb_Nueva As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents tbx_Combinacion2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Combinacion1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Combinacion0 As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_CombinacionCliente As System.Windows.Forms.Label
    Friend WithEvents tbx_CombinacionCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_FechaRetiroA As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaRetiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaRetiro As System.Windows.Forms.Label
    Friend WithEvents btn_ReciboBaja As System.Windows.Forms.Button
    Friend WithEvents chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_Retiro As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents cmb_ClienteAsignado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents pnl_des As System.Windows.Forms.Panel
    Friend WithEvents pnl_des2 As System.Windows.Forms.Panel
    Friend WithEvents grp_detallescomb As System.Windows.Forms.GroupBox
    Friend WithEvents Pnl_infocompra As System.Windows.Forms.Panel
    Friend WithEvents ltb_LogCombinacion As System.Windows.Forms.ListBox
End Class
