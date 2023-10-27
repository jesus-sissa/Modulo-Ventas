<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GenerarCarta
    Inherits Modulo_Ventas.frm_Base

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GenerarCarta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.Btn_Generar = New System.Windows.Forms.Button
        Me.gbx_Cliente = New System.Windows.Forms.GroupBox
        Me.cmb_Ejecutivo = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Frima = New System.Windows.Forms.Label
        Me.cmb_Contacto = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Contacto = New System.Windows.Forms.Label
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_TipoPrecio = New Modulo_Ventas.cp_cmb_Manual
        Me.tbx_CantPrecio = New Modulo_Ventas.cp_Textbox
        Me.cmb_TipoCR = New Modulo_Ventas.cp_cmb_Manual
        Me.tbx_CantCR = New Modulo_Ventas.cp_Textbox
        Me.cmb_TipoEE = New Modulo_Ventas.cp_cmb_Manual
        Me.tbx_CantEE = New Modulo_Ventas.cp_Textbox
        Me.cmb_TipoKM = New Modulo_Ventas.cp_cmb_Manual
        Me.tbx_CantKM = New Modulo_Ventas.cp_Textbox
        Me.dgv_Servicios = New System.Windows.Forms.DataGridView
        Me.IdCSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClaveLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClavePrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoAumentoPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadAumentoPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdPrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioNuevoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoAumentoCRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadAumentoCRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioNuevoCRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoAumentoEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadAumentoEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioNuevoEEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoAumentoKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadAumentoKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioNuevoKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblCartaAumentoDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Clientes = New Modulo_Ventas.ds_Clientes
        Me.tbx_Cliente = New Modulo_Ventas.cp_Textbox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.btn_BuscarCliente = New System.Windows.Forms.Button
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox
        Me.gbx_Precios = New System.Windows.Forms.GroupBox
        Me.lbl_KMNvo = New System.Windows.Forms.Label
        Me.lbl_KMNuevo = New System.Windows.Forms.Label
        Me.lbl_Precio = New System.Windows.Forms.Label
        Me.lbl_KMAct = New System.Windows.Forms.Label
        Me.lbl_CantidadP = New System.Windows.Forms.Label
        Me.lbl_KMActual = New System.Windows.Forms.Label
        Me.lbl_PrecioActual = New System.Windows.Forms.Label
        Me.lbl_CantidadKM = New System.Windows.Forms.Label
        Me.lbl_PrecioAct = New System.Windows.Forms.Label
        Me.lbl_KM = New System.Windows.Forms.Label
        Me.lbl_PrecioNuevo = New System.Windows.Forms.Label
        Me.lbl_PrecioNvo = New System.Windows.Forms.Label
        Me.lbl_EENvo = New System.Windows.Forms.Label
        Me.lbl_EENuevo = New System.Windows.Forms.Label
        Me.lbl_CR = New System.Windows.Forms.Label
        Me.lbl_EEAct = New System.Windows.Forms.Label
        Me.lbl_CantidadCR = New System.Windows.Forms.Label
        Me.lbl_EEActual = New System.Windows.Forms.Label
        Me.lbl_CRActual = New System.Windows.Forms.Label
        Me.lbl_CantidadEE = New System.Windows.Forms.Label
        Me.lbl_CRAct = New System.Windows.Forms.Label
        Me.lbl_EE = New System.Windows.Forms.Label
        Me.lbl_CRNuevo = New System.Windows.Forms.Label
        Me.lbl_CRNvo = New System.Windows.Forms.Label
        Me.ComboSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gbx_Controles.SuspendLayout()
        Me.gbx_Cliente.SuspendLayout()
        CType(Me.dgv_Servicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCartaAumentoDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Servicios.SuspendLayout()
        Me.gbx_Precios.SuspendLayout()
        CType(Me.ComboSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbx_Controles
        '
        Me.Gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Controles.Controls.Add(Me.lbl_Fecha)
        Me.Gbx_Controles.Controls.Add(Me.dtp_Fecha)
        Me.Gbx_Controles.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Controles.Controls.Add(Me.Btn_Generar)
        Me.Gbx_Controles.Location = New System.Drawing.Point(3, 481)
        Me.Gbx_Controles.Name = "Gbx_Controles"
        Me.Gbx_Controles.Size = New System.Drawing.Size(837, 54)
        Me.Gbx_Controles.TabIndex = 3
        Me.Gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(691, 18)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(9, 27)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Fecha.TabIndex = 14
        Me.lbl_Fecha.Text = "Fecha Aplicación"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(104, 23)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 13
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(354, 18)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 12
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Generar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.Btn_Generar.Location = New System.Drawing.Point(208, 18)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Generar.TabIndex = 11
        Me.Btn_Generar.Text = "&Generar"
        Me.Btn_Generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Generar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Generar.UseVisualStyleBackColor = True
        Me.Btn_Generar.Visible = False
        '
        'gbx_Cliente
        '
        Me.gbx_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Ejecutivo)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Frima)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Contacto)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Contacto)
        Me.gbx_Cliente.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Cliente.Controls.Add(Me.btn_BuscarCliente)
        Me.gbx_Cliente.Location = New System.Drawing.Point(5, 7)
        Me.gbx_Cliente.Name = "gbx_Cliente"
        Me.gbx_Cliente.Size = New System.Drawing.Size(837, 101)
        Me.gbx_Cliente.TabIndex = 0
        Me.gbx_Cliente.TabStop = False
        Me.gbx_Cliente.Text = "Cliente"
        '
        'cmb_Ejecutivo
        '
        Me.cmb_Ejecutivo.Clave = Nothing
        Me.cmb_Ejecutivo.Control_Siguiente = Nothing
        Me.cmb_Ejecutivo.DisplayMember = "Nombre"
        Me.cmb_Ejecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ejecutivo.Empresa = False
        Me.cmb_Ejecutivo.Filtro = Nothing
        Me.cmb_Ejecutivo.FormattingEnabled = True
        Me.cmb_Ejecutivo.Location = New System.Drawing.Point(112, 71)
        Me.cmb_Ejecutivo.MaxDropDownItems = 20
        Me.cmb_Ejecutivo.Name = "cmb_Ejecutivo"
        Me.cmb_Ejecutivo.Pista = False
        Me.cmb_Ejecutivo.Size = New System.Drawing.Size(367, 21)
        Me.cmb_Ejecutivo.StoredProcedure = "Cat_Empleados_Ventas"
        Me.cmb_Ejecutivo.Sucursal = True
        Me.cmb_Ejecutivo.TabIndex = 80
        Me.cmb_Ejecutivo.Tipo = 0
        Me.cmb_Ejecutivo.ValueMember = "Id_Empleado"
        '
        'lbl_Frima
        '
        Me.lbl_Frima.AutoSize = True
        Me.lbl_Frima.Location = New System.Drawing.Point(6, 74)
        Me.lbl_Frima.Name = "lbl_Frima"
        Me.lbl_Frima.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Frima.TabIndex = 79
        Me.lbl_Frima.Text = "Ejecutivo Comercial"
        '
        'cmb_Contacto
        '
        Me.cmb_Contacto.Clave = Nothing
        Me.cmb_Contacto.Control_Siguiente = Nothing
        Me.cmb_Contacto.DisplayMember = "Nombre"
        Me.cmb_Contacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Contacto.Empresa = False
        Me.cmb_Contacto.Filtro = Nothing
        Me.cmb_Contacto.FormattingEnabled = True
        Me.cmb_Contacto.Location = New System.Drawing.Point(112, 44)
        Me.cmb_Contacto.MaxDropDownItems = 20
        Me.cmb_Contacto.Name = "cmb_Contacto"
        Me.cmb_Contacto.Pista = False
        Me.cmb_Contacto.Size = New System.Drawing.Size(367, 21)
        Me.cmb_Contacto.StoredProcedure = "Cat_ClientesContactos_Get"
        Me.cmb_Contacto.Sucursal = False
        Me.cmb_Contacto.TabIndex = 78
        Me.cmb_Contacto.Tipo = 0
        Me.cmb_Contacto.ValueMember = "Id_Contacto"
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(18, 47)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Contacto.TabIndex = 77
        Me.lbl_Contacto.Text = "Contacto(Cliente)"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.cmb_TipoPrecio
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(177, 17)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 1
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'cmb_TipoPrecio
        '
        Me.cmb_TipoPrecio.BackColor = System.Drawing.Color.White
        Me.cmb_TipoPrecio.Control_Siguiente = Me.tbx_CantPrecio
        Me.cmb_TipoPrecio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblCartaAumentoDBindingSource, "Tipo_AumentoP", True))
        Me.cmb_TipoPrecio.DisplayMember = "display"
        Me.cmb_TipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoPrecio.Enabled = False
        Me.cmb_TipoPrecio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_TipoPrecio.FormattingEnabled = True
        Me.cmb_TipoPrecio.Location = New System.Drawing.Point(122, 25)
        Me.cmb_TipoPrecio.MaxDropDownItems = 20
        Me.cmb_TipoPrecio.Name = "cmb_TipoPrecio"
        Me.cmb_TipoPrecio.Size = New System.Drawing.Size(149, 21)
        Me.cmb_TipoPrecio.TabIndex = 2
        Me.cmb_TipoPrecio.ValueMember = "value"
        '
        'tbx_CantPrecio
        '
        Me.tbx_CantPrecio.BackColor = System.Drawing.Color.White
        Me.tbx_CantPrecio.Control_Siguiente = Me.cmb_TipoCR
        Me.tbx_CantPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Cantidad_AumentoP", True))
        Me.tbx_CantPrecio.Enabled = False
        Me.tbx_CantPrecio.Filtrado = True
        Me.tbx_CantPrecio.Location = New System.Drawing.Point(375, 25)
        Me.tbx_CantPrecio.MaxLength = 10
        Me.tbx_CantPrecio.Name = "tbx_CantPrecio"
        Me.tbx_CantPrecio.Size = New System.Drawing.Size(69, 20)
        Me.tbx_CantPrecio.TabIndex = 3
        Me.tbx_CantPrecio.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_TipoCR
        '
        Me.cmb_TipoCR.BackColor = System.Drawing.Color.White
        Me.cmb_TipoCR.Control_Siguiente = Me.tbx_CantCR
        Me.cmb_TipoCR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblCartaAumentoDBindingSource, "Tipo_AumentoCR", True))
        Me.cmb_TipoCR.DisplayMember = "display"
        Me.cmb_TipoCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoCR.Enabled = False
        Me.cmb_TipoCR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_TipoCR.FormattingEnabled = True
        Me.cmb_TipoCR.Location = New System.Drawing.Point(122, 52)
        Me.cmb_TipoCR.MaxDropDownItems = 20
        Me.cmb_TipoCR.Name = "cmb_TipoCR"
        Me.cmb_TipoCR.Size = New System.Drawing.Size(149, 21)
        Me.cmb_TipoCR.TabIndex = 4
        Me.cmb_TipoCR.ValueMember = "value"
        '
        'tbx_CantCR
        '
        Me.tbx_CantCR.BackColor = System.Drawing.Color.White
        Me.tbx_CantCR.Control_Siguiente = Me.cmb_TipoEE
        Me.tbx_CantCR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Cantidad_AumentoCR", True))
        Me.tbx_CantCR.Enabled = False
        Me.tbx_CantCR.Filtrado = True
        Me.tbx_CantCR.Location = New System.Drawing.Point(375, 52)
        Me.tbx_CantCR.MaxLength = 10
        Me.tbx_CantCR.Name = "tbx_CantCR"
        Me.tbx_CantCR.Size = New System.Drawing.Size(69, 20)
        Me.tbx_CantCR.TabIndex = 5
        Me.tbx_CantCR.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_TipoEE
        '
        Me.cmb_TipoEE.BackColor = System.Drawing.Color.White
        Me.cmb_TipoEE.Control_Siguiente = Me.tbx_CantEE
        Me.cmb_TipoEE.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblCartaAumentoDBindingSource, "Tipo_AumentoEE", True))
        Me.cmb_TipoEE.DisplayMember = "display"
        Me.cmb_TipoEE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoEE.Enabled = False
        Me.cmb_TipoEE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_TipoEE.FormattingEnabled = True
        Me.cmb_TipoEE.Location = New System.Drawing.Point(122, 79)
        Me.cmb_TipoEE.MaxDropDownItems = 20
        Me.cmb_TipoEE.Name = "cmb_TipoEE"
        Me.cmb_TipoEE.Size = New System.Drawing.Size(149, 21)
        Me.cmb_TipoEE.TabIndex = 6
        Me.cmb_TipoEE.ValueMember = "value"
        '
        'tbx_CantEE
        '
        Me.tbx_CantEE.BackColor = System.Drawing.Color.White
        Me.tbx_CantEE.Control_Siguiente = Me.cmb_TipoKM
        Me.tbx_CantEE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Cantidad_AumentoEE", True))
        Me.tbx_CantEE.Enabled = False
        Me.tbx_CantEE.Filtrado = True
        Me.tbx_CantEE.Location = New System.Drawing.Point(375, 79)
        Me.tbx_CantEE.MaxLength = 10
        Me.tbx_CantEE.Name = "tbx_CantEE"
        Me.tbx_CantEE.Size = New System.Drawing.Size(69, 20)
        Me.tbx_CantEE.TabIndex = 7
        Me.tbx_CantEE.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_TipoKM
        '
        Me.cmb_TipoKM.BackColor = System.Drawing.Color.White
        Me.cmb_TipoKM.Control_Siguiente = Me.tbx_CantKM
        Me.cmb_TipoKM.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblCartaAumentoDBindingSource, "Tipo_AumentoKM", True))
        Me.cmb_TipoKM.DisplayMember = "display"
        Me.cmb_TipoKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoKM.Enabled = False
        Me.cmb_TipoKM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_TipoKM.FormattingEnabled = True
        Me.cmb_TipoKM.Location = New System.Drawing.Point(122, 106)
        Me.cmb_TipoKM.MaxDropDownItems = 20
        Me.cmb_TipoKM.Name = "cmb_TipoKM"
        Me.cmb_TipoKM.Size = New System.Drawing.Size(149, 21)
        Me.cmb_TipoKM.TabIndex = 8
        Me.cmb_TipoKM.ValueMember = "value"
        '
        'tbx_CantKM
        '
        Me.tbx_CantKM.BackColor = System.Drawing.Color.White
        Me.tbx_CantKM.Control_Siguiente = Me.dgv_Servicios
        Me.tbx_CantKM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Cantidad_AumentoKM", True))
        Me.tbx_CantKM.Enabled = False
        Me.tbx_CantKM.Filtrado = True
        Me.tbx_CantKM.Location = New System.Drawing.Point(375, 106)
        Me.tbx_CantKM.MaxLength = 10
        Me.tbx_CantKM.Name = "tbx_CantKM"
        Me.tbx_CantKM.Size = New System.Drawing.Size(69, 20)
        Me.tbx_CantKM.TabIndex = 9
        Me.tbx_CantKM.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'dgv_Servicios
        '
        Me.dgv_Servicios.AllowUserToAddRows = False
        Me.dgv_Servicios.AllowUserToDeleteRows = False
        Me.dgv_Servicios.AllowUserToResizeRows = False
        Me.dgv_Servicios.AutoGenerateColumns = False
        Me.dgv_Servicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Servicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCSDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.ClaveLineaDataGridViewTextBoxColumn, Me.ClavePrecioDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.TipoAumentoPDataGridViewTextBoxColumn, Me.CantidadAumentoPDataGridViewTextBoxColumn, Me.IdPrecioDataGridViewTextBoxColumn, Me.PrecioAnteriorDataGridViewTextBoxColumn, Me.PrecioNuevoDataGridViewTextBoxColumn, Me.IdCRDataGridViewTextBoxColumn, Me.TipoAumentoCRDataGridViewTextBoxColumn, Me.CantidadAumentoCRDataGridViewTextBoxColumn, Me.PrecioAnteriorCRDataGridViewTextBoxColumn, Me.PrecioNuevoCRDataGridViewTextBoxColumn, Me.IdEEDataGridViewTextBoxColumn, Me.TipoAumentoEEDataGridViewTextBoxColumn, Me.CantidadAumentoEEDataGridViewTextBoxColumn, Me.PrecioAnteriorEEDataGridViewTextBoxColumn, Me.PrecioNuevoEEDataGridViewTextBoxColumn, Me.IdKMDataGridViewTextBoxColumn, Me.TipoAumentoKMDataGridViewTextBoxColumn, Me.CantidadAumentoKMDataGridViewTextBoxColumn, Me.PrecioAnteriorKMDataGridViewTextBoxColumn, Me.PrecioNuevoKMDataGridViewTextBoxColumn})
        Me.dgv_Servicios.DataSource = Me.TblCartaAumentoDBindingSource
        Me.dgv_Servicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Servicios.Location = New System.Drawing.Point(3, 16)
        Me.dgv_Servicios.Name = "dgv_Servicios"
        Me.dgv_Servicios.ReadOnly = True
        Me.dgv_Servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Servicios.Size = New System.Drawing.Size(831, 194)
        Me.dgv_Servicios.TabIndex = 10
        '
        'IdCSDataGridViewTextBoxColumn
        '
        Me.IdCSDataGridViewTextBoxColumn.DataPropertyName = "Id_CS"
        Me.IdCSDataGridViewTextBoxColumn.HeaderText = "Id_CS"
        Me.IdCSDataGridViewTextBoxColumn.Name = "IdCSDataGridViewTextBoxColumn"
        Me.IdCSDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCSDataGridViewTextBoxColumn.Visible = False
        '
        'FechaInicioDataGridViewTextBoxColumn
        '
        Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio"
        Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
        Me.FechaInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClaveLineaDataGridViewTextBoxColumn
        '
        Me.ClaveLineaDataGridViewTextBoxColumn.DataPropertyName = "ClaveLinea"
        Me.ClaveLineaDataGridViewTextBoxColumn.HeaderText = "Clave Linea"
        Me.ClaveLineaDataGridViewTextBoxColumn.Name = "ClaveLineaDataGridViewTextBoxColumn"
        Me.ClaveLineaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaveLineaDataGridViewTextBoxColumn.Width = 60
        '
        'ClavePrecioDataGridViewTextBoxColumn
        '
        Me.ClavePrecioDataGridViewTextBoxColumn.DataPropertyName = "ClavePrecio"
        Me.ClavePrecioDataGridViewTextBoxColumn.HeaderText = "Clave Precio"
        Me.ClavePrecioDataGridViewTextBoxColumn.Name = "ClavePrecioDataGridViewTextBoxColumn"
        Me.ClavePrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClavePrecioDataGridViewTextBoxColumn.Width = 80
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'TipoAumentoPDataGridViewTextBoxColumn
        '
        Me.TipoAumentoPDataGridViewTextBoxColumn.DataPropertyName = "Tipo_AumentoP"
        Me.TipoAumentoPDataGridViewTextBoxColumn.HeaderText = "Tipo_AumentoP"
        Me.TipoAumentoPDataGridViewTextBoxColumn.Name = "TipoAumentoPDataGridViewTextBoxColumn"
        Me.TipoAumentoPDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoAumentoPDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadAumentoPDataGridViewTextBoxColumn
        '
        Me.CantidadAumentoPDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_AumentoP"
        Me.CantidadAumentoPDataGridViewTextBoxColumn.HeaderText = "Cantidad_AumentoP"
        Me.CantidadAumentoPDataGridViewTextBoxColumn.Name = "CantidadAumentoPDataGridViewTextBoxColumn"
        Me.CantidadAumentoPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadAumentoPDataGridViewTextBoxColumn.Visible = False
        '
        'IdPrecioDataGridViewTextBoxColumn
        '
        Me.IdPrecioDataGridViewTextBoxColumn.DataPropertyName = "Id_Precio"
        Me.IdPrecioDataGridViewTextBoxColumn.HeaderText = "Id_Precio"
        Me.IdPrecioDataGridViewTextBoxColumn.Name = "IdPrecioDataGridViewTextBoxColumn"
        Me.IdPrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPrecioDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioAnteriorDataGridViewTextBoxColumn
        '
        Me.PrecioAnteriorDataGridViewTextBoxColumn.DataPropertyName = "Precio_Anterior"
        Me.PrecioAnteriorDataGridViewTextBoxColumn.HeaderText = "Precio_Anterior"
        Me.PrecioAnteriorDataGridViewTextBoxColumn.Name = "PrecioAnteriorDataGridViewTextBoxColumn"
        Me.PrecioAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioAnteriorDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioNuevoDataGridViewTextBoxColumn
        '
        Me.PrecioNuevoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Nuevo"
        Me.PrecioNuevoDataGridViewTextBoxColumn.HeaderText = "Precio_Nuevo"
        Me.PrecioNuevoDataGridViewTextBoxColumn.Name = "PrecioNuevoDataGridViewTextBoxColumn"
        Me.PrecioNuevoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioNuevoDataGridViewTextBoxColumn.Visible = False
        '
        'IdCRDataGridViewTextBoxColumn
        '
        Me.IdCRDataGridViewTextBoxColumn.DataPropertyName = "Id_CR"
        Me.IdCRDataGridViewTextBoxColumn.HeaderText = "Id_CR"
        Me.IdCRDataGridViewTextBoxColumn.Name = "IdCRDataGridViewTextBoxColumn"
        Me.IdCRDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCRDataGridViewTextBoxColumn.Visible = False
        '
        'TipoAumentoCRDataGridViewTextBoxColumn
        '
        Me.TipoAumentoCRDataGridViewTextBoxColumn.DataPropertyName = "Tipo_AumentoCR"
        Me.TipoAumentoCRDataGridViewTextBoxColumn.HeaderText = "Tipo_AumentoCR"
        Me.TipoAumentoCRDataGridViewTextBoxColumn.Name = "TipoAumentoCRDataGridViewTextBoxColumn"
        Me.TipoAumentoCRDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoAumentoCRDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadAumentoCRDataGridViewTextBoxColumn
        '
        Me.CantidadAumentoCRDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_AumentoCR"
        Me.CantidadAumentoCRDataGridViewTextBoxColumn.HeaderText = "Cantidad_AumentoCR"
        Me.CantidadAumentoCRDataGridViewTextBoxColumn.Name = "CantidadAumentoCRDataGridViewTextBoxColumn"
        Me.CantidadAumentoCRDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadAumentoCRDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioAnteriorCRDataGridViewTextBoxColumn
        '
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn.DataPropertyName = "Precio_AnteriorCR"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn.HeaderText = "Precio CR"
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn.Name = "PrecioAnteriorCRDataGridViewTextBoxColumn"
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioAnteriorCRDataGridViewTextBoxColumn.Width = 80
        '
        'PrecioNuevoCRDataGridViewTextBoxColumn
        '
        Me.PrecioNuevoCRDataGridViewTextBoxColumn.DataPropertyName = "Precio_NuevoCR"
        Me.PrecioNuevoCRDataGridViewTextBoxColumn.HeaderText = "Precio_NuevoCR"
        Me.PrecioNuevoCRDataGridViewTextBoxColumn.Name = "PrecioNuevoCRDataGridViewTextBoxColumn"
        Me.PrecioNuevoCRDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioNuevoCRDataGridViewTextBoxColumn.Visible = False
        '
        'IdEEDataGridViewTextBoxColumn
        '
        Me.IdEEDataGridViewTextBoxColumn.DataPropertyName = "Id_EE"
        Me.IdEEDataGridViewTextBoxColumn.HeaderText = "Id_EE"
        Me.IdEEDataGridViewTextBoxColumn.Name = "IdEEDataGridViewTextBoxColumn"
        Me.IdEEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEEDataGridViewTextBoxColumn.Visible = False
        '
        'TipoAumentoEEDataGridViewTextBoxColumn
        '
        Me.TipoAumentoEEDataGridViewTextBoxColumn.DataPropertyName = "Tipo_AumentoEE"
        Me.TipoAumentoEEDataGridViewTextBoxColumn.HeaderText = "Tipo_AumentoEE"
        Me.TipoAumentoEEDataGridViewTextBoxColumn.Name = "TipoAumentoEEDataGridViewTextBoxColumn"
        Me.TipoAumentoEEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoAumentoEEDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadAumentoEEDataGridViewTextBoxColumn
        '
        Me.CantidadAumentoEEDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_AumentoEE"
        Me.CantidadAumentoEEDataGridViewTextBoxColumn.HeaderText = "Cantidad_AumentoEE"
        Me.CantidadAumentoEEDataGridViewTextBoxColumn.Name = "CantidadAumentoEEDataGridViewTextBoxColumn"
        Me.CantidadAumentoEEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadAumentoEEDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioAnteriorEEDataGridViewTextBoxColumn
        '
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn.DataPropertyName = "Precio_AnteriorEE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn.HeaderText = "Precio EE"
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn.Name = "PrecioAnteriorEEDataGridViewTextBoxColumn"
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioAnteriorEEDataGridViewTextBoxColumn.Width = 80
        '
        'PrecioNuevoEEDataGridViewTextBoxColumn
        '
        Me.PrecioNuevoEEDataGridViewTextBoxColumn.DataPropertyName = "Precio_NuevoEE"
        Me.PrecioNuevoEEDataGridViewTextBoxColumn.HeaderText = "Precio_NuevoEE"
        Me.PrecioNuevoEEDataGridViewTextBoxColumn.Name = "PrecioNuevoEEDataGridViewTextBoxColumn"
        Me.PrecioNuevoEEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioNuevoEEDataGridViewTextBoxColumn.Visible = False
        '
        'IdKMDataGridViewTextBoxColumn
        '
        Me.IdKMDataGridViewTextBoxColumn.DataPropertyName = "Id_KM"
        Me.IdKMDataGridViewTextBoxColumn.HeaderText = "Id_KM"
        Me.IdKMDataGridViewTextBoxColumn.Name = "IdKMDataGridViewTextBoxColumn"
        Me.IdKMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdKMDataGridViewTextBoxColumn.Visible = False
        '
        'TipoAumentoKMDataGridViewTextBoxColumn
        '
        Me.TipoAumentoKMDataGridViewTextBoxColumn.DataPropertyName = "Tipo_AumentoKM"
        Me.TipoAumentoKMDataGridViewTextBoxColumn.HeaderText = "Tipo_AumentoKM"
        Me.TipoAumentoKMDataGridViewTextBoxColumn.Name = "TipoAumentoKMDataGridViewTextBoxColumn"
        Me.TipoAumentoKMDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoAumentoKMDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadAumentoKMDataGridViewTextBoxColumn
        '
        Me.CantidadAumentoKMDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_AumentoKM"
        Me.CantidadAumentoKMDataGridViewTextBoxColumn.HeaderText = "Cantidad_AumentoKM"
        Me.CantidadAumentoKMDataGridViewTextBoxColumn.Name = "CantidadAumentoKMDataGridViewTextBoxColumn"
        Me.CantidadAumentoKMDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadAumentoKMDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioAnteriorKMDataGridViewTextBoxColumn
        '
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn.DataPropertyName = "Precio_AnteriorKM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn.HeaderText = "Precio KM"
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn.Name = "PrecioAnteriorKMDataGridViewTextBoxColumn"
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioAnteriorKMDataGridViewTextBoxColumn.Width = 80
        '
        'PrecioNuevoKMDataGridViewTextBoxColumn
        '
        Me.PrecioNuevoKMDataGridViewTextBoxColumn.DataPropertyName = "Precio_NuevoKM"
        Me.PrecioNuevoKMDataGridViewTextBoxColumn.HeaderText = "Precio_NuevoKM"
        Me.PrecioNuevoKMDataGridViewTextBoxColumn.Name = "PrecioNuevoKMDataGridViewTextBoxColumn"
        Me.PrecioNuevoKMDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioNuevoKMDataGridViewTextBoxColumn.Visible = False
        '
        'TblCartaAumentoDBindingSource
        '
        Me.TblCartaAumentoDBindingSource.DataMember = "Tbl_CartaAumentoD"
        Me.TblCartaAumentoDBindingSource.DataSource = Me.Ds_Clientes
        '
        'Ds_Clientes
        '
        Me.Ds_Clientes.DataSetName = "ds_Clientes"
        Me.Ds_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(112, 17)
        Me.tbx_Cliente.MaxLength = 20
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(59, 20)
        Me.tbx_Cliente.TabIndex = 0
        Me.tbx_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(67, 20)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 75
        Me.lbl_Cliente.Text = "Cliente"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(583, 15)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarCliente.TabIndex = 0
        Me.btn_BuscarCliente.TabStop = False
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.dgv_Servicios)
        Me.gbx_Servicios.Location = New System.Drawing.Point(3, 262)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(837, 213)
        Me.gbx_Servicios.TabIndex = 13
        Me.gbx_Servicios.TabStop = False
        Me.gbx_Servicios.Text = "Servicios"
        '
        'gbx_Precios
        '
        Me.gbx_Precios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Precios.Controls.Add(Me.lbl_KMNvo)
        Me.gbx_Precios.Controls.Add(Me.cmb_TipoPrecio)
        Me.gbx_Precios.Controls.Add(Me.lbl_KMNuevo)
        Me.gbx_Precios.Controls.Add(Me.lbl_Precio)
        Me.gbx_Precios.Controls.Add(Me.lbl_KMAct)
        Me.gbx_Precios.Controls.Add(Me.lbl_CantidadP)
        Me.gbx_Precios.Controls.Add(Me.lbl_KMActual)
        Me.gbx_Precios.Controls.Add(Me.tbx_CantPrecio)
        Me.gbx_Precios.Controls.Add(Me.tbx_CantKM)
        Me.gbx_Precios.Controls.Add(Me.lbl_PrecioActual)
        Me.gbx_Precios.Controls.Add(Me.lbl_CantidadKM)
        Me.gbx_Precios.Controls.Add(Me.lbl_PrecioAct)
        Me.gbx_Precios.Controls.Add(Me.lbl_KM)
        Me.gbx_Precios.Controls.Add(Me.lbl_PrecioNuevo)
        Me.gbx_Precios.Controls.Add(Me.cmb_TipoKM)
        Me.gbx_Precios.Controls.Add(Me.lbl_PrecioNvo)
        Me.gbx_Precios.Controls.Add(Me.lbl_EENvo)
        Me.gbx_Precios.Controls.Add(Me.cmb_TipoCR)
        Me.gbx_Precios.Controls.Add(Me.lbl_EENuevo)
        Me.gbx_Precios.Controls.Add(Me.lbl_CR)
        Me.gbx_Precios.Controls.Add(Me.lbl_EEAct)
        Me.gbx_Precios.Controls.Add(Me.lbl_CantidadCR)
        Me.gbx_Precios.Controls.Add(Me.lbl_EEActual)
        Me.gbx_Precios.Controls.Add(Me.tbx_CantCR)
        Me.gbx_Precios.Controls.Add(Me.tbx_CantEE)
        Me.gbx_Precios.Controls.Add(Me.lbl_CRActual)
        Me.gbx_Precios.Controls.Add(Me.lbl_CantidadEE)
        Me.gbx_Precios.Controls.Add(Me.lbl_CRAct)
        Me.gbx_Precios.Controls.Add(Me.lbl_EE)
        Me.gbx_Precios.Controls.Add(Me.lbl_CRNuevo)
        Me.gbx_Precios.Controls.Add(Me.cmb_TipoEE)
        Me.gbx_Precios.Controls.Add(Me.lbl_CRNvo)
        Me.gbx_Precios.Location = New System.Drawing.Point(3, 117)
        Me.gbx_Precios.Name = "gbx_Precios"
        Me.gbx_Precios.Size = New System.Drawing.Size(837, 139)
        Me.gbx_Precios.TabIndex = 2
        Me.gbx_Precios.TabStop = False
        Me.gbx_Precios.Text = "Tipo y Cantidad del Aumento"
        '
        'lbl_KMNvo
        '
        Me.lbl_KMNvo.AutoSize = True
        Me.lbl_KMNvo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_NuevoKM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_KMNvo.Location = New System.Drawing.Point(618, 109)
        Me.lbl_KMNvo.Name = "lbl_KMNvo"
        Me.lbl_KMNvo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_KMNvo.TabIndex = 107
        Me.lbl_KMNvo.Text = "$ 0.0"
        '
        'lbl_KMNuevo
        '
        Me.lbl_KMNuevo.AutoSize = True
        Me.lbl_KMNuevo.Location = New System.Drawing.Point(573, 109)
        Me.lbl_KMNuevo.Name = "lbl_KMNuevo"
        Me.lbl_KMNuevo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_KMNuevo.TabIndex = 106
        Me.lbl_KMNuevo.Text = "Nuevo"
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Location = New System.Drawing.Point(10, 28)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(106, 13)
        Me.lbl_Precio.TabIndex = 77
        Me.lbl_Precio.Text = "Tipo Aumento Precio"
        '
        'lbl_KMAct
        '
        Me.lbl_KMAct.AutoSize = True
        Me.lbl_KMAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_AnteriorKM", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_KMAct.Location = New System.Drawing.Point(496, 109)
        Me.lbl_KMAct.Name = "lbl_KMAct"
        Me.lbl_KMAct.Size = New System.Drawing.Size(31, 13)
        Me.lbl_KMAct.TabIndex = 105
        Me.lbl_KMAct.Text = "$ 0.0"
        '
        'lbl_CantidadP
        '
        Me.lbl_CantidadP.AutoSize = True
        Me.lbl_CantidadP.Location = New System.Drawing.Point(275, 28)
        Me.lbl_CantidadP.Name = "lbl_CantidadP"
        Me.lbl_CantidadP.Size = New System.Drawing.Size(94, 13)
        Me.lbl_CantidadP.TabIndex = 78
        Me.lbl_CantidadP.Text = "Cantidad Aumento"
        '
        'lbl_KMActual
        '
        Me.lbl_KMActual.AutoSize = True
        Me.lbl_KMActual.Location = New System.Drawing.Point(453, 109)
        Me.lbl_KMActual.Name = "lbl_KMActual"
        Me.lbl_KMActual.Size = New System.Drawing.Size(37, 13)
        Me.lbl_KMActual.TabIndex = 104
        Me.lbl_KMActual.Text = "Actual"
        '
        'lbl_PrecioActual
        '
        Me.lbl_PrecioActual.AutoSize = True
        Me.lbl_PrecioActual.Location = New System.Drawing.Point(453, 28)
        Me.lbl_PrecioActual.Name = "lbl_PrecioActual"
        Me.lbl_PrecioActual.Size = New System.Drawing.Size(37, 13)
        Me.lbl_PrecioActual.TabIndex = 80
        Me.lbl_PrecioActual.Text = "Actual"
        '
        'lbl_CantidadKM
        '
        Me.lbl_CantidadKM.AutoSize = True
        Me.lbl_CantidadKM.Location = New System.Drawing.Point(275, 109)
        Me.lbl_CantidadKM.Name = "lbl_CantidadKM"
        Me.lbl_CantidadKM.Size = New System.Drawing.Size(94, 13)
        Me.lbl_CantidadKM.TabIndex = 102
        Me.lbl_CantidadKM.Text = "Cantidad Aumento"
        '
        'lbl_PrecioAct
        '
        Me.lbl_PrecioAct.AutoSize = True
        Me.lbl_PrecioAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_Anterior", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_PrecioAct.Location = New System.Drawing.Point(496, 28)
        Me.lbl_PrecioAct.Name = "lbl_PrecioAct"
        Me.lbl_PrecioAct.Size = New System.Drawing.Size(31, 13)
        Me.lbl_PrecioAct.TabIndex = 81
        Me.lbl_PrecioAct.Text = "$ 0.0"
        '
        'lbl_KM
        '
        Me.lbl_KM.AutoSize = True
        Me.lbl_KM.Location = New System.Drawing.Point(24, 109)
        Me.lbl_KM.Name = "lbl_KM"
        Me.lbl_KM.Size = New System.Drawing.Size(92, 13)
        Me.lbl_KM.TabIndex = 101
        Me.lbl_KM.Text = "Tipo Aumento KM"
        '
        'lbl_PrecioNuevo
        '
        Me.lbl_PrecioNuevo.AutoSize = True
        Me.lbl_PrecioNuevo.Location = New System.Drawing.Point(573, 28)
        Me.lbl_PrecioNuevo.Name = "lbl_PrecioNuevo"
        Me.lbl_PrecioNuevo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_PrecioNuevo.TabIndex = 82
        Me.lbl_PrecioNuevo.Text = "Nuevo"
        '
        'lbl_PrecioNvo
        '
        Me.lbl_PrecioNvo.AutoSize = True
        Me.lbl_PrecioNvo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_Nuevo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_PrecioNvo.Location = New System.Drawing.Point(618, 28)
        Me.lbl_PrecioNvo.Name = "lbl_PrecioNvo"
        Me.lbl_PrecioNvo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_PrecioNvo.TabIndex = 83
        Me.lbl_PrecioNvo.Text = "$ 0.0"
        '
        'lbl_EENvo
        '
        Me.lbl_EENvo.AutoSize = True
        Me.lbl_EENvo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_NuevoEE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_EENvo.Location = New System.Drawing.Point(618, 82)
        Me.lbl_EENvo.Name = "lbl_EENvo"
        Me.lbl_EENvo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_EENvo.TabIndex = 99
        Me.lbl_EENvo.Text = "$ 0.0"
        '
        'lbl_EENuevo
        '
        Me.lbl_EENuevo.AutoSize = True
        Me.lbl_EENuevo.Location = New System.Drawing.Point(573, 82)
        Me.lbl_EENuevo.Name = "lbl_EENuevo"
        Me.lbl_EENuevo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_EENuevo.TabIndex = 98
        Me.lbl_EENuevo.Text = "Nuevo"
        '
        'lbl_CR
        '
        Me.lbl_CR.AutoSize = True
        Me.lbl_CR.Location = New System.Drawing.Point(12, 55)
        Me.lbl_CR.Name = "lbl_CR"
        Me.lbl_CR.Size = New System.Drawing.Size(104, 13)
        Me.lbl_CR.TabIndex = 85
        Me.lbl_CR.Text = "Tipo Aumento Cuota"
        '
        'lbl_EEAct
        '
        Me.lbl_EEAct.AutoSize = True
        Me.lbl_EEAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_AnteriorEE", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_EEAct.Location = New System.Drawing.Point(496, 82)
        Me.lbl_EEAct.Name = "lbl_EEAct"
        Me.lbl_EEAct.Size = New System.Drawing.Size(31, 13)
        Me.lbl_EEAct.TabIndex = 97
        Me.lbl_EEAct.Text = "$ 0.0"
        '
        'lbl_CantidadCR
        '
        Me.lbl_CantidadCR.AutoSize = True
        Me.lbl_CantidadCR.Location = New System.Drawing.Point(275, 55)
        Me.lbl_CantidadCR.Name = "lbl_CantidadCR"
        Me.lbl_CantidadCR.Size = New System.Drawing.Size(94, 13)
        Me.lbl_CantidadCR.TabIndex = 86
        Me.lbl_CantidadCR.Text = "Cantidad Aumento"
        '
        'lbl_EEActual
        '
        Me.lbl_EEActual.AutoSize = True
        Me.lbl_EEActual.Location = New System.Drawing.Point(453, 82)
        Me.lbl_EEActual.Name = "lbl_EEActual"
        Me.lbl_EEActual.Size = New System.Drawing.Size(37, 13)
        Me.lbl_EEActual.TabIndex = 96
        Me.lbl_EEActual.Text = "Actual"
        '
        'lbl_CRActual
        '
        Me.lbl_CRActual.AutoSize = True
        Me.lbl_CRActual.Location = New System.Drawing.Point(453, 55)
        Me.lbl_CRActual.Name = "lbl_CRActual"
        Me.lbl_CRActual.Size = New System.Drawing.Size(37, 13)
        Me.lbl_CRActual.TabIndex = 88
        Me.lbl_CRActual.Text = "Actual"
        '
        'lbl_CantidadEE
        '
        Me.lbl_CantidadEE.AutoSize = True
        Me.lbl_CantidadEE.Location = New System.Drawing.Point(275, 82)
        Me.lbl_CantidadEE.Name = "lbl_CantidadEE"
        Me.lbl_CantidadEE.Size = New System.Drawing.Size(94, 13)
        Me.lbl_CantidadEE.TabIndex = 94
        Me.lbl_CantidadEE.Text = "Cantidad Aumento"
        '
        'lbl_CRAct
        '
        Me.lbl_CRAct.AutoSize = True
        Me.lbl_CRAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_AnteriorCR", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_CRAct.Location = New System.Drawing.Point(496, 55)
        Me.lbl_CRAct.Name = "lbl_CRAct"
        Me.lbl_CRAct.Size = New System.Drawing.Size(31, 13)
        Me.lbl_CRAct.TabIndex = 89
        Me.lbl_CRAct.Text = "$ 0.0"
        '
        'lbl_EE
        '
        Me.lbl_EE.AutoSize = True
        Me.lbl_EE.Location = New System.Drawing.Point(26, 82)
        Me.lbl_EE.Name = "lbl_EE"
        Me.lbl_EE.Size = New System.Drawing.Size(90, 13)
        Me.lbl_EE.TabIndex = 93
        Me.lbl_EE.Text = "Tipo Aumento EE"
        '
        'lbl_CRNuevo
        '
        Me.lbl_CRNuevo.AutoSize = True
        Me.lbl_CRNuevo.Location = New System.Drawing.Point(573, 55)
        Me.lbl_CRNuevo.Name = "lbl_CRNuevo"
        Me.lbl_CRNuevo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_CRNuevo.TabIndex = 90
        Me.lbl_CRNuevo.Text = "Nuevo"
        '
        'lbl_CRNvo
        '
        Me.lbl_CRNvo.AutoSize = True
        Me.lbl_CRNvo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCartaAumentoDBindingSource, "Precio_NuevoCR", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_CRNvo.Location = New System.Drawing.Point(618, 55)
        Me.lbl_CRNvo.Name = "lbl_CRNvo"
        Me.lbl_CRNvo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_CRNvo.TabIndex = 91
        Me.lbl_CRNvo.Text = "$ 0.0"
        '
        'ComboSourceBindingSource
        '
        Me.ComboSourceBindingSource.DataMember = "ComboSource"
        Me.ComboSourceBindingSource.DataSource = Me.Ds_Clientes
        '
        'frm_GenerarCarta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(845, 539)
        Me.Controls.Add(Me.Gbx_Controles)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Cliente)
        Me.Controls.Add(Me.gbx_Precios)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_GenerarCarta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Carta de Aumento"
        Me.Gbx_Controles.ResumeLayout(False)
        Me.Gbx_Controles.PerformLayout()
        Me.gbx_Cliente.ResumeLayout(False)
        Me.gbx_Cliente.PerformLayout()
        CType(Me.dgv_Servicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCartaAumentoDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Precios.ResumeLayout(False)
        Me.gbx_Precios.PerformLayout()
        CType(Me.ComboSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Servicios As System.Windows.Forms.DataGridView
    Friend WithEvents Gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Generar As System.Windows.Forms.Button
    Friend WithEvents TblCartaAumentoDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Clientes As Modulo_Ventas.ds_Clientes
    Friend WithEvents lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoPrecio As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents tbx_CantPrecio As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CantidadP As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioActual As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioNvo As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioNuevo As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioAct As System.Windows.Forms.Label
    Friend WithEvents lbl_KMNvo As System.Windows.Forms.Label
    Friend WithEvents lbl_KMNuevo As System.Windows.Forms.Label
    Friend WithEvents lbl_KMAct As System.Windows.Forms.Label
    Friend WithEvents lbl_KMActual As System.Windows.Forms.Label
    Friend WithEvents tbx_CantKM As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CantidadKM As System.Windows.Forms.Label
    Friend WithEvents lbl_KM As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoKM As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_EENvo As System.Windows.Forms.Label
    Friend WithEvents lbl_EENuevo As System.Windows.Forms.Label
    Friend WithEvents lbl_EEAct As System.Windows.Forms.Label
    Friend WithEvents lbl_EEActual As System.Windows.Forms.Label
    Friend WithEvents tbx_CantEE As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CantidadEE As System.Windows.Forms.Label
    Friend WithEvents lbl_EE As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoEE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_CRNvo As System.Windows.Forms.Label
    Friend WithEvents lbl_CRNuevo As System.Windows.Forms.Label
    Friend WithEvents lbl_CRAct As System.Windows.Forms.Label
    Friend WithEvents lbl_CRActual As System.Windows.Forms.Label
    Friend WithEvents tbx_CantCR As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CantidadCR As System.Windows.Forms.Label
    Friend WithEvents lbl_CR As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoCR As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents gbx_Precios As System.Windows.Forms.GroupBox
    Friend WithEvents ComboSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents cmb_Contacto As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Frima As System.Windows.Forms.Label
    Friend WithEvents cmb_Ejecutivo As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents IdCartaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents IdCSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaveLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClavePrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioAnteriorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioAnteriorCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioAnteriorEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoEEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAumentoKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAumentoKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioAnteriorKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
