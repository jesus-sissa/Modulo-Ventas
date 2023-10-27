<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesAlertas
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientesAlertas))
        Me.Tab_ClientesAlertas = New System.Windows.Forms.TabControl
        Me.tp_Clientes = New System.Windows.Forms.TabPage
        Me.gbx_Clientes = New System.Windows.Forms.GroupBox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.lbl_RegistrosClientes = New System.Windows.Forms.Label
        Me.lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.Chk_TodosClientes = New System.Windows.Forms.CheckBox
        Me.cmb_ClienteP = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_SeleccioneCP = New Modulo_Ventas.cp_Textbox
        Me.lbl_ClientePadre = New System.Windows.Forms.Label
        Me.tp_Alertas = New System.Windows.Forms.TabPage
        Me.gbx_AlertasLista = New System.Windows.Forms.GroupBox
        Me.btn_AlertaBajaReingreso = New System.Windows.Forms.Button
        Me.lbl_RegistrosAlertas = New System.Windows.Forms.Label
        Me.lsv_Alertas = New Modulo_Ventas.cp_Listview
        Me.gbx_AlertasDetalle = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_AlertaGuardar = New System.Windows.Forms.Button
        Me.cmb_AlertaContacto = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.Label7 = New System.Windows.Forms.Label
        Me.rbn_AlertaClientePadre = New System.Windows.Forms.RadioButton
        Me.rbn_AlertaEsteCliente = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chk_AlertaDestino = New System.Windows.Forms.CheckBox
        Me.Chk_AlertaOrigen = New System.Windows.Forms.CheckBox
        Me.Chk_AlertaEntrega = New System.Windows.Forms.CheckBox
        Me.Chk_AlertaRecoleccion = New System.Windows.Forms.CheckBox
        Me.Cmb_AlertasTipo = New Modulo_Ventas.cp_cmb_Manual
        Me.Label3 = New System.Windows.Forms.Label
        Me.Tab_ClientesAlertas.SuspendLayout()
        Me.tp_Clientes.SuspendLayout()
        Me.gbx_Clientes.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.tp_Alertas.SuspendLayout()
        Me.gbx_AlertasLista.SuspendLayout()
        Me.gbx_AlertasDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_ClientesAlertas
        '
        Me.Tab_ClientesAlertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_ClientesAlertas.Controls.Add(Me.tp_Clientes)
        Me.Tab_ClientesAlertas.Controls.Add(Me.tp_Alertas)
        Me.Tab_ClientesAlertas.Location = New System.Drawing.Point(5, 2)
        Me.Tab_ClientesAlertas.Name = "Tab_ClientesAlertas"
        Me.Tab_ClientesAlertas.SelectedIndex = 0
        Me.Tab_ClientesAlertas.Size = New System.Drawing.Size(775, 556)
        Me.Tab_ClientesAlertas.TabIndex = 0
        '
        'tp_Clientes
        '
        Me.tp_Clientes.Controls.Add(Me.gbx_Clientes)
        Me.tp_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.tp_Clientes.Name = "tp_Clientes"
        Me.tp_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Clientes.Size = New System.Drawing.Size(767, 530)
        Me.tp_Clientes.TabIndex = 0
        Me.tp_Clientes.Text = "Lista de Clientes"
        Me.tp_Clientes.UseVisualStyleBackColor = True
        '
        'gbx_Clientes
        '
        Me.gbx_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Clientes.Controls.Add(Me.gbx_Botones)
        Me.gbx_Clientes.Controls.Add(Me.lbl_RegistrosClientes)
        Me.gbx_Clientes.Controls.Add(Me.lsv_Clientes)
        Me.gbx_Clientes.Controls.Add(Me.Chk_TodosClientes)
        Me.gbx_Clientes.Controls.Add(Me.cmb_ClienteP)
        Me.gbx_Clientes.Controls.Add(Me.tbx_SeleccioneCP)
        Me.gbx_Clientes.Controls.Add(Me.lbl_ClientePadre)
        Me.gbx_Clientes.Location = New System.Drawing.Point(5, 5)
        Me.gbx_Clientes.Name = "gbx_Clientes"
        Me.gbx_Clientes.Size = New System.Drawing.Size(756, 519)
        Me.gbx_Clientes.TabIndex = 0
        Me.gbx_Clientes.TabStop = False
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Editar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 465)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(744, 50)
        Me.gbx_Botones.TabIndex = 26
        Me.gbx_Botones.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(598, 14)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 7
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Editar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_Editar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Editar.TabIndex = 24
        Me.btn_Editar.Text = "&Alertas"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosClientes
        '
        Me.lbl_RegistrosClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosClientes.Location = New System.Drawing.Point(615, 41)
        Me.lbl_RegistrosClientes.Name = "lbl_RegistrosClientes"
        Me.lbl_RegistrosClientes.Size = New System.Drawing.Size(135, 19)
        Me.lbl_RegistrosClientes.TabIndex = 23
        Me.lbl_RegistrosClientes.Text = "Registros: 0"
        Me.lbl_RegistrosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(6, 63)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 10
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 30
        Me.lsv_Clientes.Row3 = 20
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(744, 396)
        Me.lsv_Clientes.TabIndex = 9
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'Chk_TodosClientes
        '
        Me.Chk_TodosClientes.AutoSize = True
        Me.Chk_TodosClientes.Location = New System.Drawing.Point(585, 21)
        Me.Chk_TodosClientes.Name = "Chk_TodosClientes"
        Me.Chk_TodosClientes.Size = New System.Drawing.Size(56, 17)
        Me.Chk_TodosClientes.TabIndex = 8
        Me.Chk_TodosClientes.Text = "Todos"
        Me.Chk_TodosClientes.UseVisualStyleBackColor = True
        '
        'cmb_ClienteP
        '
        Me.cmb_ClienteP.Clave = "Clave_Cliente"
        Me.cmb_ClienteP.Control_Siguiente = Nothing
        Me.cmb_ClienteP.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClienteP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClienteP.Empresa = False
        Me.cmb_ClienteP.Filtro = Me.tbx_SeleccioneCP
        Me.cmb_ClienteP.FormattingEnabled = True
        Me.cmb_ClienteP.Location = New System.Drawing.Point(179, 19)
        Me.cmb_ClienteP.MaxDropDownItems = 20
        Me.cmb_ClienteP.Name = "cmb_ClienteP"
        Me.cmb_ClienteP.Pista = False
        Me.cmb_ClienteP.Size = New System.Drawing.Size(400, 21)
        Me.cmb_ClienteP.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_ClienteP.Sucursal = True
        Me.cmb_ClienteP.TabIndex = 7
        Me.cmb_ClienteP.TabStop = False
        Me.cmb_ClienteP.Tipo = 0
        Me.cmb_ClienteP.ValueMember = "Id_Cliente"
        '
        'tbx_SeleccioneCP
        '
        Me.tbx_SeleccioneCP.Control_Siguiente = Me.cmb_ClienteP
        Me.tbx_SeleccioneCP.Filtrado = True
        Me.tbx_SeleccioneCP.Location = New System.Drawing.Point(88, 19)
        Me.tbx_SeleccioneCP.MaxLength = 12
        Me.tbx_SeleccioneCP.Name = "tbx_SeleccioneCP"
        Me.tbx_SeleccioneCP.Size = New System.Drawing.Size(85, 20)
        Me.tbx_SeleccioneCP.TabIndex = 6
        Me.tbx_SeleccioneCP.TabStop = False
        Me.tbx_SeleccioneCP.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_ClientePadre
        '
        Me.lbl_ClientePadre.AutoSize = True
        Me.lbl_ClientePadre.Location = New System.Drawing.Point(14, 20)
        Me.lbl_ClientePadre.Name = "lbl_ClientePadre"
        Me.lbl_ClientePadre.Size = New System.Drawing.Size(70, 13)
        Me.lbl_ClientePadre.TabIndex = 5
        Me.lbl_ClientePadre.Text = "Cliente Padre"
        '
        'tp_Alertas
        '
        Me.tp_Alertas.Controls.Add(Me.gbx_AlertasLista)
        Me.tp_Alertas.Controls.Add(Me.gbx_AlertasDetalle)
        Me.tp_Alertas.Location = New System.Drawing.Point(4, 22)
        Me.tp_Alertas.Name = "tp_Alertas"
        Me.tp_Alertas.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Alertas.Size = New System.Drawing.Size(767, 530)
        Me.tp_Alertas.TabIndex = 1
        Me.tp_Alertas.Text = "Alertas"
        Me.tp_Alertas.UseVisualStyleBackColor = True
        '
        'gbx_AlertasLista
        '
        Me.gbx_AlertasLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_AlertasLista.Controls.Add(Me.btn_AlertaBajaReingreso)
        Me.gbx_AlertasLista.Controls.Add(Me.lbl_RegistrosAlertas)
        Me.gbx_AlertasLista.Controls.Add(Me.lsv_Alertas)
        Me.gbx_AlertasLista.Location = New System.Drawing.Point(5, 199)
        Me.gbx_AlertasLista.Name = "gbx_AlertasLista"
        Me.gbx_AlertasLista.Size = New System.Drawing.Size(756, 311)
        Me.gbx_AlertasLista.TabIndex = 3
        Me.gbx_AlertasLista.TabStop = False
        Me.gbx_AlertasLista.Text = "Alertas"
        '
        'btn_AlertaBajaReingreso
        '
        Me.btn_AlertaBajaReingreso.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.btn_AlertaBajaReingreso.Location = New System.Drawing.Point(6, 19)
        Me.btn_AlertaBajaReingreso.Name = "btn_AlertaBajaReingreso"
        Me.btn_AlertaBajaReingreso.Size = New System.Drawing.Size(140, 30)
        Me.btn_AlertaBajaReingreso.TabIndex = 23
        Me.btn_AlertaBajaReingreso.Text = "&Eliminar"
        Me.btn_AlertaBajaReingreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AlertaBajaReingreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AlertaBajaReingreso.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosAlertas
        '
        Me.lbl_RegistrosAlertas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosAlertas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosAlertas.Location = New System.Drawing.Point(615, 35)
        Me.lbl_RegistrosAlertas.Name = "lbl_RegistrosAlertas"
        Me.lbl_RegistrosAlertas.Size = New System.Drawing.Size(135, 17)
        Me.lbl_RegistrosAlertas.TabIndex = 22
        Me.lbl_RegistrosAlertas.Text = "Registros: 0"
        Me.lbl_RegistrosAlertas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Alertas
        '
        Me.lsv_Alertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Alertas.FullRowSelect = True
        Me.lsv_Alertas.HideSelection = False
        Me.lsv_Alertas.Location = New System.Drawing.Point(6, 55)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Alertas.Lvs = ListViewColumnSorter2
        Me.lsv_Alertas.MultiSelect = False
        Me.lsv_Alertas.Name = "lsv_Alertas"
        Me.lsv_Alertas.Row1 = 20
        Me.lsv_Alertas.Row10 = 0
        Me.lsv_Alertas.Row2 = 25
        Me.lsv_Alertas.Row3 = 20
        Me.lsv_Alertas.Row4 = 5
        Me.lsv_Alertas.Row5 = 5
        Me.lsv_Alertas.Row6 = 5
        Me.lsv_Alertas.Row7 = 5
        Me.lsv_Alertas.Row8 = 10
        Me.lsv_Alertas.Row9 = 0
        Me.lsv_Alertas.Size = New System.Drawing.Size(744, 246)
        Me.lsv_Alertas.TabIndex = 0
        Me.lsv_Alertas.UseCompatibleStateImageBehavior = False
        Me.lsv_Alertas.View = System.Windows.Forms.View.Details
        '
        'gbx_AlertasDetalle
        '
        Me.gbx_AlertasDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_AlertasDetalle.Controls.Add(Me.btn_Cancelar)
        Me.gbx_AlertasDetalle.Controls.Add(Me.btn_AlertaGuardar)
        Me.gbx_AlertasDetalle.Controls.Add(Me.cmb_AlertaContacto)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Label7)
        Me.gbx_AlertasDetalle.Controls.Add(Me.rbn_AlertaClientePadre)
        Me.gbx_AlertasDetalle.Controls.Add(Me.rbn_AlertaEsteCliente)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Label6)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Label5)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Label4)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Chk_AlertaDestino)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Chk_AlertaOrigen)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Chk_AlertaEntrega)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Chk_AlertaRecoleccion)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Cmb_AlertasTipo)
        Me.gbx_AlertasDetalle.Controls.Add(Me.Label3)
        Me.gbx_AlertasDetalle.Location = New System.Drawing.Point(5, 5)
        Me.gbx_AlertasDetalle.Name = "gbx_AlertasDetalle"
        Me.gbx_AlertasDetalle.Size = New System.Drawing.Size(756, 188)
        Me.gbx_AlertasDetalle.TabIndex = 2
        Me.gbx_AlertasDetalle.TabStop = False
        Me.gbx_AlertasDetalle.Text = "Detalle"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(203, 150)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 47
        Me.btn_Cancelar.Text = "Ca&ncelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_AlertaGuardar
        '
        Me.btn_AlertaGuardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_AlertaGuardar.Location = New System.Drawing.Point(57, 150)
        Me.btn_AlertaGuardar.Name = "btn_AlertaGuardar"
        Me.btn_AlertaGuardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_AlertaGuardar.TabIndex = 46
        Me.btn_AlertaGuardar.Text = "&Guardar"
        Me.btn_AlertaGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AlertaGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AlertaGuardar.UseVisualStyleBackColor = True
        '
        'cmb_AlertaContacto
        '
        Me.cmb_AlertaContacto.Clave = Nothing
        Me.cmb_AlertaContacto.Control_Siguiente = Nothing
        Me.cmb_AlertaContacto.DisplayMember = "Nombre_Contacto"
        Me.cmb_AlertaContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AlertaContacto.Empresa = False
        Me.cmb_AlertaContacto.Filtro = Nothing
        Me.cmb_AlertaContacto.FormattingEnabled = True
        Me.cmb_AlertaContacto.Location = New System.Drawing.Point(111, 123)
        Me.cmb_AlertaContacto.MaxDropDownItems = 20
        Me.cmb_AlertaContacto.Name = "cmb_AlertaContacto"
        Me.cmb_AlertaContacto.Pista = False
        Me.cmb_AlertaContacto.Size = New System.Drawing.Size(400, 21)
        Me.cmb_AlertaContacto.StoredProcedure = "Cat_ClientesContactos_GetCombo"
        Me.cmb_AlertaContacto.Sucursal = False
        Me.cmb_AlertaContacto.TabIndex = 45
        Me.cmb_AlertaContacto.Tipo = 0
        Me.cmb_AlertaContacto.ValueMember = "Id_Contacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Contacto"
        '
        'rbn_AlertaClientePadre
        '
        Me.rbn_AlertaClientePadre.AutoSize = True
        Me.rbn_AlertaClientePadre.Location = New System.Drawing.Point(219, 98)
        Me.rbn_AlertaClientePadre.Name = "rbn_AlertaClientePadre"
        Me.rbn_AlertaClientePadre.Size = New System.Drawing.Size(88, 17)
        Me.rbn_AlertaClientePadre.TabIndex = 43
        Me.rbn_AlertaClientePadre.TabStop = True
        Me.rbn_AlertaClientePadre.Text = "Cliente Padre"
        Me.rbn_AlertaClientePadre.UseVisualStyleBackColor = True
        '
        'rbn_AlertaEsteCliente
        '
        Me.rbn_AlertaEsteCliente.AutoSize = True
        Me.rbn_AlertaEsteCliente.Location = New System.Drawing.Point(111, 98)
        Me.rbn_AlertaEsteCliente.Name = "rbn_AlertaEsteCliente"
        Me.rbn_AlertaEsteCliente.Size = New System.Drawing.Size(81, 17)
        Me.rbn_AlertaEsteCliente.TabIndex = 42
        Me.rbn_AlertaEsteCliente.TabStop = True
        Me.rbn_AlertaEsteCliente.Text = "Este Cliente"
        Me.rbn_AlertaEsteCliente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Alertar a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Cuando sea"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Evento"
        '
        'Chk_AlertaDestino
        '
        Me.Chk_AlertaDestino.AutoSize = True
        Me.Chk_AlertaDestino.Location = New System.Drawing.Point(228, 73)
        Me.Chk_AlertaDestino.Name = "Chk_AlertaDestino"
        Me.Chk_AlertaDestino.Size = New System.Drawing.Size(62, 17)
        Me.Chk_AlertaDestino.TabIndex = 38
        Me.Chk_AlertaDestino.Text = "Destino"
        Me.Chk_AlertaDestino.UseVisualStyleBackColor = True
        '
        'Chk_AlertaOrigen
        '
        Me.Chk_AlertaOrigen.AutoSize = True
        Me.Chk_AlertaOrigen.Location = New System.Drawing.Point(111, 73)
        Me.Chk_AlertaOrigen.Name = "Chk_AlertaOrigen"
        Me.Chk_AlertaOrigen.Size = New System.Drawing.Size(57, 17)
        Me.Chk_AlertaOrigen.TabIndex = 37
        Me.Chk_AlertaOrigen.Text = "Origen"
        Me.Chk_AlertaOrigen.UseVisualStyleBackColor = True
        '
        'Chk_AlertaEntrega
        '
        Me.Chk_AlertaEntrega.AutoSize = True
        Me.Chk_AlertaEntrega.Location = New System.Drawing.Point(228, 50)
        Me.Chk_AlertaEntrega.Name = "Chk_AlertaEntrega"
        Me.Chk_AlertaEntrega.Size = New System.Drawing.Size(63, 17)
        Me.Chk_AlertaEntrega.TabIndex = 36
        Me.Chk_AlertaEntrega.Text = "Entrega"
        Me.Chk_AlertaEntrega.UseVisualStyleBackColor = True
        '
        'Chk_AlertaRecoleccion
        '
        Me.Chk_AlertaRecoleccion.AutoSize = True
        Me.Chk_AlertaRecoleccion.Location = New System.Drawing.Point(111, 50)
        Me.Chk_AlertaRecoleccion.Name = "Chk_AlertaRecoleccion"
        Me.Chk_AlertaRecoleccion.Size = New System.Drawing.Size(86, 17)
        Me.Chk_AlertaRecoleccion.TabIndex = 35
        Me.Chk_AlertaRecoleccion.Text = "Recolección"
        Me.Chk_AlertaRecoleccion.UseVisualStyleBackColor = True
        '
        'Cmb_AlertasTipo
        '
        Me.Cmb_AlertasTipo.Control_Siguiente = Nothing
        Me.Cmb_AlertasTipo.DisplayMember = "display"
        Me.Cmb_AlertasTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_AlertasTipo.FormattingEnabled = True
        Me.Cmb_AlertasTipo.Location = New System.Drawing.Point(111, 19)
        Me.Cmb_AlertasTipo.MaxDropDownItems = 20
        Me.Cmb_AlertasTipo.Name = "Cmb_AlertasTipo"
        Me.Cmb_AlertasTipo.Size = New System.Drawing.Size(400, 21)
        Me.Cmb_AlertasTipo.TabIndex = 34
        Me.Cmb_AlertasTipo.ValueMember = "value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Tipo Alerta"
        '
        'frm_ClientesAlertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_ClientesAlertas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ClientesAlertas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Alertas para Clientes"
        Me.Tab_ClientesAlertas.ResumeLayout(False)
        Me.tp_Clientes.ResumeLayout(False)
        Me.gbx_Clientes.ResumeLayout(False)
        Me.gbx_Clientes.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.tp_Alertas.ResumeLayout(False)
        Me.gbx_AlertasLista.ResumeLayout(False)
        Me.gbx_AlertasDetalle.ResumeLayout(False)
        Me.gbx_AlertasDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_ClientesAlertas As System.Windows.Forms.TabControl
    Friend WithEvents tp_Clientes As System.Windows.Forms.TabPage
    Friend WithEvents tp_Alertas As System.Windows.Forms.TabPage
    Friend WithEvents gbx_AlertasLista As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AlertaBajaReingreso As System.Windows.Forms.Button
    Friend WithEvents lbl_RegistrosAlertas As System.Windows.Forms.Label
    Friend WithEvents lsv_Alertas As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_AlertasDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AlertaGuardar As System.Windows.Forms.Button
    Friend WithEvents cmb_AlertaContacto As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbn_AlertaClientePadre As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_AlertaEsteCliente As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chk_AlertaDestino As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_AlertaOrigen As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_AlertaEntrega As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_AlertaRecoleccion As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_AlertasTipo As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbx_Clientes As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_ClienteP As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_SeleccioneCP As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_ClientePadre As System.Windows.Forms.Label
    Friend WithEvents Chk_TodosClientes As System.Windows.Forms.CheckBox
    Friend WithEvents lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_RegistrosClientes As System.Windows.Forms.Label
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
End Class
