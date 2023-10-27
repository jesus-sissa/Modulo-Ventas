<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesProceso
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
        Dim ListViewColumnSorter4 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientesProceso))
        Dim ListViewColumnSorter5 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter6 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.Tab_General = New System.Windows.Forms.TabControl
        Me.Tab_Listado = New System.Windows.Forms.TabPage
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.cbx_Activas = New System.Windows.Forms.CheckBox
        Me.cmb_Banco = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cia = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lsv_0_Catalogo = New Modulo_Ventas.cp_Listview
        Me.lbl_0_Banco = New System.Windows.Forms.Label
        Me.lbl_0_Cia = New System.Windows.Forms.Label
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Baja = New System.Windows.Forms.Button
        Me.btn_BuscarCajaBancaria = New System.Windows.Forms.Button
        Me.BTN_0_Buscar = New System.Windows.Forms.Button
        Me.tbx_0_Buscar = New Modulo_Ventas.cp_Textbox
        Me.Lbl_0_Buscar = New System.Windows.Forms.Label
        Me.tab_Nuevo = New System.Windows.Forms.TabPage
        Me.gbx_Generales = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_NombreCA = New System.Windows.Forms.Label
        Me.cmb_TipoProceso = New Modulo_Ventas.cp_cmb_Manual
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Cuentas = New System.Windows.Forms.GroupBox
        Me.lsv_Cuentas = New Modulo_Ventas.cp_Listview
        Me.btn_CuentasBaja = New System.Windows.Forms.Button
        Me.gbx_Referencias = New System.Windows.Forms.GroupBox
        Me.lsv_Referencias = New Modulo_Ventas.cp_Listview
        Me.btn_ReferenciaBaja = New System.Windows.Forms.Button
        Me.chk_Clientes = New System.Windows.Forms.CheckBox
        Me.btn_BuscarCajaBancariaNew = New System.Windows.Forms.Button
        Me.cmb_CajaBancariaNew = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Compañias = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_1_Cliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_1_Estado = New System.Windows.Forms.Label
        Me.lbl_1_Pais = New System.Windows.Forms.Label
        Me.lbl_GrupoDota = New System.Windows.Forms.Label
        Me.lbl_GrupoDepo = New System.Windows.Forms.Label
        Me.cmb_GrupoDota = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_GrupoDeposito = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_GrupoF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_1_Contrato = New Modulo_Ventas.cp_Textbox
        Me.btn_BuscarClienteNew = New System.Windows.Forms.Button
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_1_GrupoF = New System.Windows.Forms.Label
        Me.tbx_1_Direccion = New Modulo_Ventas.cp_Textbox
        Me.cmb_Pais = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Estado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Ciudad = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_RequiereCuenta = New System.Windows.Forms.Label
        Me.lbl_1_Banco = New System.Windows.Forms.Label
        Me.lbl_1_Ciudad = New System.Windows.Forms.Label
        Me.lbl_1_Contrato = New System.Windows.Forms.Label
        Me.cmb_RequiereCuentas = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_1_Direccion = New System.Windows.Forms.Label
        Me.lbl_1_Compañias = New System.Windows.Forms.Label
        Me.lbl_1_Cliente = New System.Windows.Forms.Label
        Me.tbx_1_ClienteLibre = New Modulo_Ventas.cp_Textbox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Cuentas = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Tab_General.SuspendLayout()
        Me.Tab_Listado.SuspendLayout()
        Me.tab_Nuevo.SuspendLayout()
        Me.gbx_Generales.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Cuentas.SuspendLayout()
        Me.gbx_Referencias.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_General
        '
        Me.Tab_General.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_General.Controls.Add(Me.Tab_Listado)
        Me.Tab_General.Controls.Add(Me.tab_Nuevo)
        Me.Tab_General.Location = New System.Drawing.Point(0, 0)
        Me.Tab_General.Name = "Tab_General"
        Me.Tab_General.SelectedIndex = 0
        Me.Tab_General.Size = New System.Drawing.Size(784, 560)
        Me.Tab_General.TabIndex = 0
        '
        'Tab_Listado
        '
        Me.Tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.Tab_Listado.Controls.Add(Me.cbx_Activas)
        Me.Tab_Listado.Controls.Add(Me.cmb_Banco)
        Me.Tab_Listado.Controls.Add(Me.lbl_0_Banco)
        Me.Tab_Listado.Controls.Add(Me.lbl_0_Cia)
        Me.Tab_Listado.Controls.Add(Me.cmb_Cia)
        Me.Tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.Tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.Tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.Tab_Listado.Controls.Add(Me.btn_Baja)
        Me.Tab_Listado.Controls.Add(Me.btn_BuscarCajaBancaria)
        Me.Tab_Listado.Controls.Add(Me.BTN_0_Buscar)
        Me.Tab_Listado.Controls.Add(Me.tbx_0_Buscar)
        Me.Tab_Listado.Controls.Add(Me.Lbl_0_Buscar)
        Me.Tab_Listado.Controls.Add(Me.lsv_0_Catalogo)
        Me.Tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Listado.Name = "Tab_Listado"
        Me.Tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Listado.Size = New System.Drawing.Size(776, 534)
        Me.Tab_Listado.TabIndex = 2
        Me.Tab_Listado.Text = "Listado"
        Me.Tab_Listado.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(631, 92)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 16)
        Me.lbl_Registros.TabIndex = 31
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbx_Activas
        '
        Me.cbx_Activas.AutoSize = True
        Me.cbx_Activas.Checked = True
        Me.cbx_Activas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Activas.Location = New System.Drawing.Point(97, 91)
        Me.cbx_Activas.Name = "cbx_Activas"
        Me.cbx_Activas.Size = New System.Drawing.Size(162, 17)
        Me.cbx_Activas.TabIndex = 9
        Me.cbx_Activas.Text = "Sólo mostrar Clientes Activos"
        Me.cbx_Activas.UseVisualStyleBackColor = True
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = "Clave_Cliente"
        Me.cmb_Banco.Control_Siguiente = Me.cmb_Cia
        Me.cmb_Banco.DisplayMember = "Nombre Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Nothing
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(97, 34)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Banco.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_Banco.Sucursal = True
        Me.cmb_Banco.TabIndex = 5
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Clave = Nothing
        Me.cmb_Cia.Control_Siguiente = Me.lsv_0_Catalogo
        Me.cmb_Cia.DisplayMember = "Nombre"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Filtro = Nothing
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(97, 64)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 8
        Me.cmb_Cia.Tipo = 0
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'lsv_0_Catalogo
        '
        Me.lsv_0_Catalogo.AllowColumnReorder = True
        Me.lsv_0_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_0_Catalogo.FullRowSelect = True
        Me.lsv_0_Catalogo.HideSelection = False
        Me.lsv_0_Catalogo.Location = New System.Drawing.Point(3, 114)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_0_Catalogo.Lvs = ListViewColumnSorter4
        Me.lsv_0_Catalogo.MultiSelect = False
        Me.lsv_0_Catalogo.Name = "lsv_0_Catalogo"
        Me.lsv_0_Catalogo.Row1 = 10
        Me.lsv_0_Catalogo.Row10 = 0
        Me.lsv_0_Catalogo.Row2 = 40
        Me.lsv_0_Catalogo.Row3 = 15
        Me.lsv_0_Catalogo.Row4 = 20
        Me.lsv_0_Catalogo.Row5 = 10
        Me.lsv_0_Catalogo.Row6 = 0
        Me.lsv_0_Catalogo.Row7 = 0
        Me.lsv_0_Catalogo.Row8 = 0
        Me.lsv_0_Catalogo.Row9 = 0
        Me.lsv_0_Catalogo.Size = New System.Drawing.Size(770, 379)
        Me.lsv_0_Catalogo.TabIndex = 10
        Me.lsv_0_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_0_Catalogo.View = System.Windows.Forms.View.Details
        '
        'lbl_0_Banco
        '
        Me.lbl_0_Banco.AutoSize = True
        Me.lbl_0_Banco.Location = New System.Drawing.Point(18, 39)
        Me.lbl_0_Banco.Name = "lbl_0_Banco"
        Me.lbl_0_Banco.Size = New System.Drawing.Size(73, 13)
        Me.lbl_0_Banco.TabIndex = 3
        Me.lbl_0_Banco.Text = "Caja Bancaria"
        '
        'lbl_0_Cia
        '
        Me.lbl_0_Cia.AutoSize = True
        Me.lbl_0_Cia.Location = New System.Drawing.Point(36, 67)
        Me.lbl_0_Cia.Name = "lbl_0_Cia"
        Me.lbl_0_Cia.Size = New System.Drawing.Size(56, 13)
        Me.lbl_0_Cia.TabIndex = 7
        Me.lbl_0_Cia.Text = "Compañía"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(154, 498)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 12
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(631, 498)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(300, 498)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 13
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.btn_Baja.Location = New System.Drawing.Point(8, 498)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 11
        Me.btn_Baja.Text = "&Baja / Reing."
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_BuscarCajaBancaria
        '
        Me.btn_BuscarCajaBancaria.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCajaBancaria.Location = New System.Drawing.Point(503, 34)
        Me.btn_BuscarCajaBancaria.Name = "btn_BuscarCajaBancaria"
        Me.btn_BuscarCajaBancaria.Size = New System.Drawing.Size(25, 23)
        Me.btn_BuscarCajaBancaria.TabIndex = 6
        Me.btn_BuscarCajaBancaria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCajaBancaria.UseVisualStyleBackColor = True
        '
        'BTN_0_Buscar
        '
        Me.BTN_0_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.BTN_0_Buscar.Location = New System.Drawing.Point(503, 6)
        Me.BTN_0_Buscar.Name = "BTN_0_Buscar"
        Me.BTN_0_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_0_Buscar.TabIndex = 2
        Me.BTN_0_Buscar.Text = "B&uscar"
        Me.BTN_0_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_0_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_0_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_0_Buscar
        '
        Me.tbx_0_Buscar.Control_Siguiente = Nothing
        Me.tbx_0_Buscar.Filtrado = False
        Me.tbx_0_Buscar.Location = New System.Drawing.Point(97, 8)
        Me.tbx_0_Buscar.Name = "tbx_0_Buscar"
        Me.tbx_0_Buscar.Size = New System.Drawing.Size(400, 20)
        Me.tbx_0_Buscar.TabIndex = 1
        Me.tbx_0_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_0_Buscar
        '
        Me.Lbl_0_Buscar.AutoSize = True
        Me.Lbl_0_Buscar.Location = New System.Drawing.Point(48, 11)
        Me.Lbl_0_Buscar.Name = "Lbl_0_Buscar"
        Me.Lbl_0_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_0_Buscar.TabIndex = 0
        Me.Lbl_0_Buscar.Text = "Buscar"
        '
        'tab_Nuevo
        '
        Me.tab_Nuevo.Controls.Add(Me.gbx_Generales)
        Me.tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.tab_Nuevo.Controls.Add(Me.btn_Cuentas)
        Me.tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.tab_Nuevo.Name = "tab_Nuevo"
        Me.tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Nuevo.Size = New System.Drawing.Size(776, 534)
        Me.tab_Nuevo.TabIndex = 0
        Me.tab_Nuevo.Tag = "0"
        Me.tab_Nuevo.Text = "Nuevo"
        Me.tab_Nuevo.UseVisualStyleBackColor = True
        '
        'gbx_Generales
        '
        Me.gbx_Generales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Generales.Controls.Add(Me.Label8)
        Me.gbx_Generales.Controls.Add(Me.Label7)
        Me.gbx_Generales.Controls.Add(Me.Label6)
        Me.gbx_Generales.Controls.Add(Me.Label5)
        Me.gbx_Generales.Controls.Add(Me.Label4)
        Me.gbx_Generales.Controls.Add(Me.Label3)
        Me.gbx_Generales.Controls.Add(Me.Label2)
        Me.gbx_Generales.Controls.Add(Me.lbl_NombreCA)
        Me.gbx_Generales.Controls.Add(Me.cmb_TipoProceso)
        Me.gbx_Generales.Controls.Add(Me.Label1)
        Me.gbx_Generales.Controls.Add(Me.SplitContainer1)
        Me.gbx_Generales.Controls.Add(Me.chk_Clientes)
        Me.gbx_Generales.Controls.Add(Me.btn_BuscarCajaBancariaNew)
        Me.gbx_Generales.Controls.Add(Me.cmb_CajaBancariaNew)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Estado)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Pais)
        Me.gbx_Generales.Controls.Add(Me.lbl_GrupoDota)
        Me.gbx_Generales.Controls.Add(Me.lbl_GrupoDepo)
        Me.gbx_Generales.Controls.Add(Me.cmb_GrupoDota)
        Me.gbx_Generales.Controls.Add(Me.cmb_GrupoDeposito)
        Me.gbx_Generales.Controls.Add(Me.cmb_Compañias)
        Me.gbx_Generales.Controls.Add(Me.tbx_1_Cliente)
        Me.gbx_Generales.Controls.Add(Me.btn_BuscarClienteNew)
        Me.gbx_Generales.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_GrupoF)
        Me.gbx_Generales.Controls.Add(Me.tbx_1_Direccion)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Banco)
        Me.gbx_Generales.Controls.Add(Me.cmb_Pais)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Ciudad)
        Me.gbx_Generales.Controls.Add(Me.cmb_Estado)
        Me.gbx_Generales.Controls.Add(Me.lbl_RequiereCuenta)
        Me.gbx_Generales.Controls.Add(Me.tbx_1_Contrato)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Contrato)
        Me.gbx_Generales.Controls.Add(Me.cmb_RequiereCuentas)
        Me.gbx_Generales.Controls.Add(Me.cmb_Ciudad)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Direccion)
        Me.gbx_Generales.Controls.Add(Me.cmb_GrupoF)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Compañias)
        Me.gbx_Generales.Controls.Add(Me.lbl_1_Cliente)
        Me.gbx_Generales.Controls.Add(Me.tbx_1_ClienteLibre)
        Me.gbx_Generales.Location = New System.Drawing.Point(8, 6)
        Me.gbx_Generales.Name = "gbx_Generales"
        Me.gbx_Generales.Size = New System.Drawing.Size(760, 484)
        Me.gbx_Generales.TabIndex = 1
        Me.gbx_Generales.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(206, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(345, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(345, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(345, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(608, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(608, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(608, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "*"
        '
        'lbl_NombreCA
        '
        Me.lbl_NombreCA.AutoSize = True
        Me.lbl_NombreCA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreCA.ForeColor = System.Drawing.Color.Red
        Me.lbl_NombreCA.Location = New System.Drawing.Point(673, 205)
        Me.lbl_NombreCA.Name = "lbl_NombreCA"
        Me.lbl_NombreCA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_NombreCA.TabIndex = 31
        Me.lbl_NombreCA.Text = "*"
        '
        'cmb_TipoProceso
        '
        Me.cmb_TipoProceso.Control_Siguiente = Nothing
        Me.cmb_TipoProceso.DisplayMember = "display"
        Me.cmb_TipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoProceso.FormattingEnabled = True
        Me.cmb_TipoProceso.Location = New System.Drawing.Point(523, 205)
        Me.cmb_TipoProceso.MaxDropDownItems = 20
        Me.cmb_TipoProceso.Name = "cmb_TipoProceso"
        Me.cmb_TipoProceso.Size = New System.Drawing.Size(144, 21)
        Me.cmb_TipoProceso.TabIndex = 30
        Me.cmb_TipoProceso.ValueMember = "value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tipo Proceso"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 234)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Cuentas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Referencias)
        Me.SplitContainer1.Size = New System.Drawing.Size(748, 244)
        Me.SplitContainer1.SplitterDistance = 373
        Me.SplitContainer1.TabIndex = 29
        '
        'Cuentas
        '
        Me.Cuentas.Controls.Add(Me.lsv_Cuentas)
        Me.Cuentas.Controls.Add(Me.btn_CuentasBaja)
        Me.Cuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cuentas.Location = New System.Drawing.Point(0, 0)
        Me.Cuentas.Name = "Cuentas"
        Me.Cuentas.Size = New System.Drawing.Size(373, 244)
        Me.Cuentas.TabIndex = 0
        Me.Cuentas.TabStop = False
        Me.Cuentas.Text = "Cuentas"
        '
        'lsv_Cuentas
        '
        Me.lsv_Cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cuentas.FullRowSelect = True
        Me.lsv_Cuentas.HideSelection = False
        Me.lsv_Cuentas.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Cuentas.Lvs = ListViewColumnSorter5
        Me.lsv_Cuentas.MultiSelect = False
        Me.lsv_Cuentas.Name = "lsv_Cuentas"
        Me.lsv_Cuentas.Row1 = 35
        Me.lsv_Cuentas.Row10 = 0
        Me.lsv_Cuentas.Row2 = 35
        Me.lsv_Cuentas.Row3 = 25
        Me.lsv_Cuentas.Row4 = 0
        Me.lsv_Cuentas.Row5 = 0
        Me.lsv_Cuentas.Row6 = 0
        Me.lsv_Cuentas.Row7 = 0
        Me.lsv_Cuentas.Row8 = 0
        Me.lsv_Cuentas.Row9 = 0
        Me.lsv_Cuentas.Size = New System.Drawing.Size(367, 186)
        Me.lsv_Cuentas.TabIndex = 0
        Me.lsv_Cuentas.UseCompatibleStateImageBehavior = False
        Me.lsv_Cuentas.View = System.Windows.Forms.View.Details
        '
        'btn_CuentasBaja
        '
        Me.btn_CuentasBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CuentasBaja.Enabled = False
        Me.btn_CuentasBaja.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.btn_CuentasBaja.Location = New System.Drawing.Point(3, 208)
        Me.btn_CuentasBaja.Name = "btn_CuentasBaja"
        Me.btn_CuentasBaja.Size = New System.Drawing.Size(140, 30)
        Me.btn_CuentasBaja.TabIndex = 1
        Me.btn_CuentasBaja.Text = "&Baja / Reingreso"
        Me.btn_CuentasBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CuentasBaja.UseVisualStyleBackColor = True
        '
        'gbx_Referencias
        '
        Me.gbx_Referencias.Controls.Add(Me.lsv_Referencias)
        Me.gbx_Referencias.Controls.Add(Me.btn_ReferenciaBaja)
        Me.gbx_Referencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Referencias.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Referencias.Name = "gbx_Referencias"
        Me.gbx_Referencias.Size = New System.Drawing.Size(371, 244)
        Me.gbx_Referencias.TabIndex = 0
        Me.gbx_Referencias.TabStop = False
        Me.gbx_Referencias.Text = "Referencias"
        '
        'lsv_Referencias
        '
        Me.lsv_Referencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Referencias.FullRowSelect = True
        Me.lsv_Referencias.HideSelection = False
        Me.lsv_Referencias.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_Referencias.Lvs = ListViewColumnSorter6
        Me.lsv_Referencias.MultiSelect = False
        Me.lsv_Referencias.Name = "lsv_Referencias"
        Me.lsv_Referencias.Row1 = 20
        Me.lsv_Referencias.Row10 = 0
        Me.lsv_Referencias.Row2 = 20
        Me.lsv_Referencias.Row3 = 20
        Me.lsv_Referencias.Row4 = 10
        Me.lsv_Referencias.Row5 = 10
        Me.lsv_Referencias.Row6 = 5
        Me.lsv_Referencias.Row7 = 5
        Me.lsv_Referencias.Row8 = 0
        Me.lsv_Referencias.Row9 = 0
        Me.lsv_Referencias.Size = New System.Drawing.Size(365, 186)
        Me.lsv_Referencias.TabIndex = 0
        Me.lsv_Referencias.UseCompatibleStateImageBehavior = False
        Me.lsv_Referencias.View = System.Windows.Forms.View.Details
        '
        'btn_ReferenciaBaja
        '
        Me.btn_ReferenciaBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ReferenciaBaja.Enabled = False
        Me.btn_ReferenciaBaja.Image = Global.Modulo_Ventas.My.Resources.Resources.BajaReing
        Me.btn_ReferenciaBaja.Location = New System.Drawing.Point(6, 208)
        Me.btn_ReferenciaBaja.Name = "btn_ReferenciaBaja"
        Me.btn_ReferenciaBaja.Size = New System.Drawing.Size(140, 30)
        Me.btn_ReferenciaBaja.TabIndex = 1
        Me.btn_ReferenciaBaja.Text = "&Baja / Reingreso"
        Me.btn_ReferenciaBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ReferenciaBaja.UseVisualStyleBackColor = True
        '
        'chk_Clientes
        '
        Me.chk_Clientes.AutoSize = True
        Me.chk_Clientes.Enabled = False
        Me.chk_Clientes.Location = New System.Drawing.Point(658, 74)
        Me.chk_Clientes.Name = "chk_Clientes"
        Me.chk_Clientes.Size = New System.Drawing.Size(81, 17)
        Me.chk_Clientes.TabIndex = 9
        Me.chk_Clientes.Text = "Subclientes"
        Me.chk_Clientes.UseVisualStyleBackColor = True
        Me.chk_Clientes.Visible = False
        '
        'btn_BuscarCajaBancariaNew
        '
        Me.btn_BuscarCajaBancariaNew.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCajaBancariaNew.Location = New System.Drawing.Point(627, 15)
        Me.btn_BuscarCajaBancariaNew.Name = "btn_BuscarCajaBancariaNew"
        Me.btn_BuscarCajaBancariaNew.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCajaBancariaNew.TabIndex = 2
        Me.btn_BuscarCajaBancariaNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCajaBancariaNew.UseVisualStyleBackColor = True
        '
        'cmb_CajaBancariaNew
        '
        Me.cmb_CajaBancariaNew.Clave = "Clave_Cliente"
        Me.cmb_CajaBancariaNew.Control_Siguiente = Me.cmb_Compañias
        Me.cmb_CajaBancariaNew.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancariaNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancariaNew.Empresa = False
        Me.cmb_CajaBancariaNew.Filtro = Nothing
        Me.cmb_CajaBancariaNew.FormattingEnabled = True
        Me.cmb_CajaBancariaNew.Location = New System.Drawing.Point(112, 16)
        Me.cmb_CajaBancariaNew.MaxDropDownItems = 20
        Me.cmb_CajaBancariaNew.Name = "cmb_CajaBancariaNew"
        Me.cmb_CajaBancariaNew.Pista = False
        Me.cmb_CajaBancariaNew.Size = New System.Drawing.Size(490, 21)
        Me.cmb_CajaBancariaNew.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancariaNew.Sucursal = True
        Me.cmb_CajaBancariaNew.TabIndex = 1
        Me.cmb_CajaBancariaNew.Tipo = 0
        Me.cmb_CajaBancariaNew.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Compañias
        '
        Me.cmb_Compañias.Clave = Nothing
        Me.cmb_Compañias.Control_Siguiente = Me.tbx_1_Cliente
        Me.cmb_Compañias.DisplayMember = "Nombre"
        Me.cmb_Compañias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Compañias.Empresa = False
        Me.cmb_Compañias.Filtro = Nothing
        Me.cmb_Compañias.FormattingEnabled = True
        Me.cmb_Compañias.Location = New System.Drawing.Point(111, 42)
        Me.cmb_Compañias.MaxDropDownItems = 20
        Me.cmb_Compañias.Name = "cmb_Compañias"
        Me.cmb_Compañias.Pista = True
        Me.cmb_Compañias.Size = New System.Drawing.Size(491, 21)
        Me.cmb_Compañias.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Compañias.Sucursal = False
        Me.cmb_Compañias.TabIndex = 4
        Me.cmb_Compañias.Tipo = 0
        Me.cmb_Compañias.ValueMember = "Id_Cia"
        '
        'tbx_1_Cliente
        '
        Me.tbx_1_Cliente.Control_Siguiente = Nothing
        Me.tbx_1_Cliente.Filtrado = True
        Me.tbx_1_Cliente.Location = New System.Drawing.Point(111, 70)
        Me.tbx_1_Cliente.MaxLength = 20
        Me.tbx_1_Cliente.Name = "tbx_1_Cliente"
        Me.tbx_1_Cliente.Size = New System.Drawing.Size(85, 20)
        Me.tbx_1_Cliente.TabIndex = 6
        Me.tbx_1_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_1_Cliente.Visible = False
        '
        'lbl_1_Estado
        '
        Me.lbl_1_Estado.AutoSize = True
        Me.lbl_1_Estado.Location = New System.Drawing.Point(66, 153)
        Me.lbl_1_Estado.Name = "lbl_1_Estado"
        Me.lbl_1_Estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_1_Estado.TabIndex = 14
        Me.lbl_1_Estado.Text = "Estado"
        Me.lbl_1_Estado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1_Pais
        '
        Me.lbl_1_Pais.AutoSize = True
        Me.lbl_1_Pais.Location = New System.Drawing.Point(76, 126)
        Me.lbl_1_Pais.Name = "lbl_1_Pais"
        Me.lbl_1_Pais.Size = New System.Drawing.Size(29, 13)
        Me.lbl_1_Pais.TabIndex = 12
        Me.lbl_1_Pais.Text = "País"
        Me.lbl_1_Pais.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_GrupoDota
        '
        Me.lbl_GrupoDota.AutoSize = True
        Me.lbl_GrupoDota.Location = New System.Drawing.Point(409, 126)
        Me.lbl_GrupoDota.Name = "lbl_GrupoDota"
        Me.lbl_GrupoDota.Size = New System.Drawing.Size(108, 13)
        Me.lbl_GrupoDota.TabIndex = 22
        Me.lbl_GrupoDota.Text = "Grupo de Dotaciones"
        Me.lbl_GrupoDota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_GrupoDepo
        '
        Me.lbl_GrupoDepo.AutoSize = True
        Me.lbl_GrupoDepo.Location = New System.Drawing.Point(421, 153)
        Me.lbl_GrupoDepo.Name = "lbl_GrupoDepo"
        Me.lbl_GrupoDepo.Size = New System.Drawing.Size(96, 13)
        Me.lbl_GrupoDepo.TabIndex = 25
        Me.lbl_GrupoDepo.Text = "Grupo de Depósito"
        '
        'cmb_GrupoDota
        '
        Me.cmb_GrupoDota.Clave = Nothing
        Me.cmb_GrupoDota.Control_Siguiente = Me.cmb_GrupoDeposito
        Me.cmb_GrupoDota.DisplayMember = "Descripcion"
        Me.cmb_GrupoDota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GrupoDota.Empresa = False
        Me.cmb_GrupoDota.Filtro = Nothing
        Me.cmb_GrupoDota.FormattingEnabled = True
        Me.cmb_GrupoDota.Location = New System.Drawing.Point(523, 123)
        Me.cmb_GrupoDota.MaxDropDownItems = 20
        Me.cmb_GrupoDota.Name = "cmb_GrupoDota"
        Me.cmb_GrupoDota.Pista = True
        Me.cmb_GrupoDota.Size = New System.Drawing.Size(228, 21)
        Me.cmb_GrupoDota.StoredProcedure = "Cat_GrupoDota_Get"
        Me.cmb_GrupoDota.Sucursal = False
        Me.cmb_GrupoDota.TabIndex = 23
        Me.cmb_GrupoDota.Tipo = 0
        Me.cmb_GrupoDota.ValueMember = "Id_GrupoDota"
        '
        'cmb_GrupoDeposito
        '
        Me.cmb_GrupoDeposito.Clave = Nothing
        Me.cmb_GrupoDeposito.Control_Siguiente = Me.cmb_GrupoF
        Me.cmb_GrupoDeposito.DisplayMember = "Descripcion"
        Me.cmb_GrupoDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GrupoDeposito.Empresa = False
        Me.cmb_GrupoDeposito.Filtro = Nothing
        Me.cmb_GrupoDeposito.FormattingEnabled = True
        Me.cmb_GrupoDeposito.Location = New System.Drawing.Point(523, 150)
        Me.cmb_GrupoDeposito.MaxDropDownItems = 20
        Me.cmb_GrupoDeposito.Name = "cmb_GrupoDeposito"
        Me.cmb_GrupoDeposito.Pista = True
        Me.cmb_GrupoDeposito.Size = New System.Drawing.Size(228, 21)
        Me.cmb_GrupoDeposito.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.cmb_GrupoDeposito.Sucursal = False
        Me.cmb_GrupoDeposito.TabIndex = 26
        Me.cmb_GrupoDeposito.Tipo = 0
        Me.cmb_GrupoDeposito.ValueMember = "Id_GrupoDepo"
        '
        'cmb_GrupoF
        '
        Me.cmb_GrupoF.Clave = Nothing
        Me.cmb_GrupoF.Control_Siguiente = Me.tbx_1_Contrato
        Me.cmb_GrupoF.DisplayMember = "Descripcion"
        Me.cmb_GrupoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GrupoF.Empresa = False
        Me.cmb_GrupoF.Filtro = Nothing
        Me.cmb_GrupoF.FormattingEnabled = True
        Me.cmb_GrupoF.Location = New System.Drawing.Point(523, 178)
        Me.cmb_GrupoF.MaxDropDownItems = 20
        Me.cmb_GrupoF.Name = "cmb_GrupoF"
        Me.cmb_GrupoF.Pista = False
        Me.cmb_GrupoF.Size = New System.Drawing.Size(228, 21)
        Me.cmb_GrupoF.StoredProcedure = "Pro_GruposFactura_Get"
        Me.cmb_GrupoF.Sucursal = False
        Me.cmb_GrupoF.TabIndex = 28
        Me.cmb_GrupoF.Tipo = 0
        Me.cmb_GrupoF.ValueMember = "Id_GrupoF"
        '
        'tbx_1_Contrato
        '
        Me.tbx_1_Contrato.Control_Siguiente = Nothing
        Me.tbx_1_Contrato.Filtrado = True
        Me.tbx_1_Contrato.Location = New System.Drawing.Point(307, 207)
        Me.tbx_1_Contrato.MaxLength = 50
        Me.tbx_1_Contrato.Name = "tbx_1_Contrato"
        Me.tbx_1_Contrato.Size = New System.Drawing.Size(93, 20)
        Me.tbx_1_Contrato.TabIndex = 21
        Me.tbx_1_Contrato.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarClienteNew
        '
        Me.btn_BuscarClienteNew.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarClienteNew.Location = New System.Drawing.Point(627, 70)
        Me.btn_BuscarClienteNew.Name = "btn_BuscarClienteNew"
        Me.btn_BuscarClienteNew.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarClienteNew.TabIndex = 8
        Me.btn_BuscarClienteNew.UseVisualStyleBackColor = True
        Me.btn_BuscarClienteNew.Visible = False
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_1_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(202, 70)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 7
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        Me.cmb_Cliente.Visible = False
        '
        'lbl_1_GrupoF
        '
        Me.lbl_1_GrupoF.AutoSize = True
        Me.lbl_1_GrupoF.Location = New System.Drawing.Point(422, 181)
        Me.lbl_1_GrupoF.Name = "lbl_1_GrupoF"
        Me.lbl_1_GrupoF.Size = New System.Drawing.Size(95, 13)
        Me.lbl_1_GrupoF.TabIndex = 27
        Me.lbl_1_GrupoF.Text = "Grupo Facturación"
        Me.lbl_1_GrupoF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbx_1_Direccion
        '
        Me.tbx_1_Direccion.Control_Siguiente = Me.cmb_Pais
        Me.tbx_1_Direccion.Filtrado = True
        Me.tbx_1_Direccion.Location = New System.Drawing.Point(111, 97)
        Me.tbx_1_Direccion.MaxLength = 150
        Me.tbx_1_Direccion.Name = "tbx_1_Direccion"
        Me.tbx_1_Direccion.Size = New System.Drawing.Size(574, 20)
        Me.tbx_1_Direccion.TabIndex = 11
        Me.tbx_1_Direccion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Pais
        '
        Me.cmb_Pais.Clave = Nothing
        Me.cmb_Pais.Control_Siguiente = Me.cmb_Estado
        Me.cmb_Pais.DisplayMember = "Nombre"
        Me.cmb_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pais.Empresa = False
        Me.cmb_Pais.Filtro = Nothing
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(111, 123)
        Me.cmb_Pais.MaxDropDownItems = 20
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.Pista = True
        Me.cmb_Pais.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Pais.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Pais.Sucursal = False
        Me.cmb_Pais.TabIndex = 13
        Me.cmb_Pais.Tipo = 0
        Me.cmb_Pais.ValueMember = "Id_Pais"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.Clave = Nothing
        Me.cmb_Estado.Control_Siguiente = Me.cmb_Ciudad
        Me.cmb_Estado.DisplayMember = "Nombre"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Empresa = False
        Me.cmb_Estado.Filtro = Nothing
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(112, 150)
        Me.cmb_Estado.MaxDropDownItems = 20
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Pista = True
        Me.cmb_Estado.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Estado.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_Estado.Sucursal = False
        Me.cmb_Estado.TabIndex = 15
        Me.cmb_Estado.Tipo = 0
        Me.cmb_Estado.ValueMember = "Id_Estado"
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.Clave = Nothing
        Me.cmb_Ciudad.Control_Siguiente = Me.lbl_RequiereCuenta
        Me.cmb_Ciudad.DisplayMember = "Nombre"
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Empresa = False
        Me.cmb_Ciudad.Filtro = Nothing
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(112, 177)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = True
        Me.cmb_Ciudad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 17
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'lbl_RequiereCuenta
        '
        Me.lbl_RequiereCuenta.AutoSize = True
        Me.lbl_RequiereCuenta.Location = New System.Drawing.Point(4, 210)
        Me.lbl_RequiereCuenta.Name = "lbl_RequiereCuenta"
        Me.lbl_RequiereCuenta.Size = New System.Drawing.Size(101, 13)
        Me.lbl_RequiereCuenta.TabIndex = 18
        Me.lbl_RequiereCuenta.Text = "Requiere Cuentas ?"
        Me.lbl_RequiereCuenta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1_Banco
        '
        Me.lbl_1_Banco.AutoSize = True
        Me.lbl_1_Banco.Location = New System.Drawing.Point(32, 19)
        Me.lbl_1_Banco.Name = "lbl_1_Banco"
        Me.lbl_1_Banco.Size = New System.Drawing.Size(73, 13)
        Me.lbl_1_Banco.TabIndex = 0
        Me.lbl_1_Banco.Text = "Caja Bancaria"
        Me.lbl_1_Banco.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1_Ciudad
        '
        Me.lbl_1_Ciudad.AutoSize = True
        Me.lbl_1_Ciudad.Location = New System.Drawing.Point(66, 180)
        Me.lbl_1_Ciudad.Name = "lbl_1_Ciudad"
        Me.lbl_1_Ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_1_Ciudad.TabIndex = 16
        Me.lbl_1_Ciudad.Text = "Ciudad"
        Me.lbl_1_Ciudad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1_Contrato
        '
        Me.lbl_1_Contrato.AutoSize = True
        Me.lbl_1_Contrato.Location = New System.Drawing.Point(220, 210)
        Me.lbl_1_Contrato.Name = "lbl_1_Contrato"
        Me.lbl_1_Contrato.Size = New System.Drawing.Size(81, 13)
        Me.lbl_1_Contrato.TabIndex = 20
        Me.lbl_1_Contrato.Text = "Contrato Banco"
        Me.lbl_1_Contrato.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_RequiereCuentas
        '
        Me.cmb_RequiereCuentas.Control_Siguiente = Me.cmb_GrupoDota
        Me.cmb_RequiereCuentas.DisplayMember = "display"
        Me.cmb_RequiereCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RequiereCuentas.FormattingEnabled = True
        Me.cmb_RequiereCuentas.Location = New System.Drawing.Point(111, 207)
        Me.cmb_RequiereCuentas.MaxDropDownItems = 20
        Me.cmb_RequiereCuentas.Name = "cmb_RequiereCuentas"
        Me.cmb_RequiereCuentas.Size = New System.Drawing.Size(89, 21)
        Me.cmb_RequiereCuentas.TabIndex = 19
        Me.cmb_RequiereCuentas.ValueMember = "value"
        '
        'lbl_1_Direccion
        '
        Me.lbl_1_Direccion.AutoSize = True
        Me.lbl_1_Direccion.Location = New System.Drawing.Point(53, 100)
        Me.lbl_1_Direccion.Name = "lbl_1_Direccion"
        Me.lbl_1_Direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_1_Direccion.TabIndex = 10
        Me.lbl_1_Direccion.Text = "Dirección"
        Me.lbl_1_Direccion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1_Compañias
        '
        Me.lbl_1_Compañias.AutoSize = True
        Me.lbl_1_Compañias.Location = New System.Drawing.Point(32, 45)
        Me.lbl_1_Compañias.Name = "lbl_1_Compañias"
        Me.lbl_1_Compañias.Size = New System.Drawing.Size(73, 13)
        Me.lbl_1_Compañias.TabIndex = 3
        Me.lbl_1_Compañias.Text = "Compañía TV"
        Me.lbl_1_Compañias.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1_Cliente
        '
        Me.lbl_1_Cliente.AutoSize = True
        Me.lbl_1_Cliente.Location = New System.Drawing.Point(66, 73)
        Me.lbl_1_Cliente.Name = "lbl_1_Cliente"
        Me.lbl_1_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_1_Cliente.TabIndex = 5
        Me.lbl_1_Cliente.Text = "Cliente"
        Me.lbl_1_Cliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbx_1_ClienteLibre
        '
        Me.tbx_1_ClienteLibre.Control_Siguiente = Me.tbx_1_Direccion
        Me.tbx_1_ClienteLibre.Filtrado = True
        Me.tbx_1_ClienteLibre.Location = New System.Drawing.Point(112, 70)
        Me.tbx_1_ClienteLibre.MaxLength = 150
        Me.tbx_1_ClienteLibre.Name = "tbx_1_ClienteLibre"
        Me.tbx_1_ClienteLibre.Size = New System.Drawing.Size(490, 20)
        Me.tbx_1_ClienteLibre.TabIndex = 4
        Me.tbx_1_ClienteLibre.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(628, 496)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "&Regresar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cuentas
        '
        Me.btn_Cuentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cuentas.Enabled = False
        Me.btn_Cuentas.Image = Global.Modulo_Ventas.My.Resources.Resources.Agregar
        Me.btn_Cuentas.Location = New System.Drawing.Point(154, 496)
        Me.btn_Cuentas.Name = "btn_Cuentas"
        Me.btn_Cuentas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cuentas.TabIndex = 3
        Me.btn_Cuentas.Text = "&Agregar Cuentas"
        Me.btn_Cuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cuentas.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(8, 496)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'frm_ClientesProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Tab_General)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ClientesProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Clientes con Proceso"
        Me.Tab_General.ResumeLayout(False)
        Me.Tab_Listado.ResumeLayout(False)
        Me.Tab_Listado.PerformLayout()
        Me.tab_Nuevo.ResumeLayout(False)
        Me.gbx_Generales.ResumeLayout(False)
        Me.gbx_Generales.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Cuentas.ResumeLayout(False)
        Me.gbx_Referencias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_General As System.Windows.Forms.TabControl
    Friend WithEvents tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_1_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_1_Cliente As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarClienteNew As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_Compañias As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_1_Compañias As System.Windows.Forms.Label
    Friend WithEvents lbl_1_Direccion As System.Windows.Forms.Label
    Friend WithEvents tbx_1_Direccion As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Estado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_1_Estado As System.Windows.Forms.Label
    Friend WithEvents lbl_1_Pais As System.Windows.Forms.Label
    Friend WithEvents cmb_Pais As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_1_Contrato As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_1_Contrato As System.Windows.Forms.Label
    Friend WithEvents lbl_RequiereCuenta As System.Windows.Forms.Label
    Friend WithEvents cmb_RequiereCuentas As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_Ciudad As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_1_Ciudad As System.Windows.Forms.Label
    Friend WithEvents lbl_1_GrupoF As System.Windows.Forms.Label
    Friend WithEvents cmb_GrupoF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_1_Banco As System.Windows.Forms.Label
    Friend WithEvents tbx_1_ClienteLibre As Modulo_Ventas.cp_Textbox
    Friend WithEvents Tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_0_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_0_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_0_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_0_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_0_Banco As System.Windows.Forms.Label
    Friend WithEvents lbl_0_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Generales As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cuentas As System.Windows.Forms.Button
    Friend WithEvents Cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Referencias As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Cuentas As Modulo_Ventas.cp_Listview
    Friend WithEvents lsv_Referencias As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_GrupoDepo As System.Windows.Forms.Label
    Friend WithEvents cmb_GrupoDota As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_GrupoDeposito As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_GrupoDota As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancariaNew As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Banco As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_BuscarCajaBancaria As System.Windows.Forms.Button
    Friend WithEvents btn_BuscarCajaBancariaNew As System.Windows.Forms.Button
    Friend WithEvents btn_CuentasBaja As System.Windows.Forms.Button
    Friend WithEvents btn_ReferenciaBaja As System.Windows.Forms.Button
    Friend WithEvents cbx_Activas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmb_TipoProceso As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreCA As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
