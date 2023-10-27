<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contratos
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
        Me.gbx_Nuevo = New System.Windows.Forms.GroupBox
        Me.lbl_DatosPoderEmp = New System.Windows.Forms.Label
        Me.lbl_DatosPoderCli = New System.Windows.Forms.Label
        Me.rtb_DatosPoderCliente = New System.Windows.Forms.RichTextBox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_TestigoCliente = New Modulo_Ventas.cp_Textbox
        Me.tbx_TetigoEmpresa = New Modulo_Ventas.cp_Textbox
        Me.lbl_TestigoCli = New System.Windows.Forms.Label
        Me.lbl_TestigoEmp = New System.Windows.Forms.Label
        Me.tbx_Filtro = New Modulo_Ventas.cp_Textbox
        Me.dtp_FechaContrato = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaContrato = New System.Windows.Forms.Label
        Me.rtb_DatosPoderEmpresa = New System.Windows.Forms.RichTextBox
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.tbx_PuestoCliente = New Modulo_Ventas.cp_Textbox
        Me.tbx_PuestoEmpresa = New Modulo_Ventas.cp_Textbox
        Me.lbl_PuestoCliente = New System.Windows.Forms.Label
        Me.lbl_PuestoEmp = New System.Windows.Forms.Label
        Me.tbx_FirmaCliente = New Modulo_Ventas.cp_Textbox
        Me.tbx_FirmaEmpresa = New Modulo_Ventas.cp_Textbox
        Me.lbl_FirmaCliente = New System.Windows.Forms.Label
        Me.lbl_FirmaEmp = New System.Windows.Forms.Label
        Me.cmb_Ciudad = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Ciudad = New System.Windows.Forms.Label
        Me.cmb_Estado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Estado = New System.Windows.Forms.Label
        Me.lbl_Pais = New System.Windows.Forms.Label
        Me.cmb_Pais = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_NumContrato = New Modulo_Ventas.cp_Textbox
        Me.lbl_NumContrato = New System.Windows.Forms.Label
        Me.dtp_FechaFin = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaFin = New System.Windows.Forms.Label
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaIni = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_Clientes = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Clausulas = New System.Windows.Forms.Button
        Me.gbx_Nuevo.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Nuevo
        '
        Me.gbx_Nuevo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_DatosPoderEmp)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_DatosPoderCli)
        Me.gbx_Nuevo.Controls.Add(Me.rtb_DatosPoderCliente)
        Me.gbx_Nuevo.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_Nuevo.Controls.Add(Me.Label12)
        Me.gbx_Nuevo.Controls.Add(Me.Label11)
        Me.gbx_Nuevo.Controls.Add(Me.Label10)
        Me.gbx_Nuevo.Controls.Add(Me.Label9)
        Me.gbx_Nuevo.Controls.Add(Me.Label8)
        Me.gbx_Nuevo.Controls.Add(Me.Label7)
        Me.gbx_Nuevo.Controls.Add(Me.Label6)
        Me.gbx_Nuevo.Controls.Add(Me.Label5)
        Me.gbx_Nuevo.Controls.Add(Me.Label4)
        Me.gbx_Nuevo.Controls.Add(Me.Label3)
        Me.gbx_Nuevo.Controls.Add(Me.Label2)
        Me.gbx_Nuevo.Controls.Add(Me.Label1)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_TestigoCliente)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_TetigoEmpresa)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_TestigoCli)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_TestigoEmp)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_Filtro)
        Me.gbx_Nuevo.Controls.Add(Me.dtp_FechaContrato)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_FechaContrato)
        Me.gbx_Nuevo.Controls.Add(Me.rtb_DatosPoderEmpresa)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_PuestoCliente)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_PuestoEmpresa)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_PuestoCliente)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_PuestoEmp)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_FirmaCliente)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_FirmaEmpresa)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_FirmaCliente)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_FirmaEmp)
        Me.gbx_Nuevo.Controls.Add(Me.cmb_Ciudad)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_Ciudad)
        Me.gbx_Nuevo.Controls.Add(Me.cmb_Estado)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_Estado)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_Pais)
        Me.gbx_Nuevo.Controls.Add(Me.cmb_Pais)
        Me.gbx_Nuevo.Controls.Add(Me.tbx_NumContrato)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_NumContrato)
        Me.gbx_Nuevo.Controls.Add(Me.dtp_FechaFin)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_FechaFin)
        Me.gbx_Nuevo.Controls.Add(Me.dtp_FechaInicio)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_FechaIni)
        Me.gbx_Nuevo.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Nuevo.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Nuevo.Location = New System.Drawing.Point(4, 4)
        Me.gbx_Nuevo.Name = "gbx_Nuevo"
        Me.gbx_Nuevo.Size = New System.Drawing.Size(775, 493)
        Me.gbx_Nuevo.TabIndex = 0
        Me.gbx_Nuevo.TabStop = False
        '
        'lbl_DatosPoderEmp
        '
        Me.lbl_DatosPoderEmp.Location = New System.Drawing.Point(42, 399)
        Me.lbl_DatosPoderEmp.Name = "lbl_DatosPoderEmp"
        Me.lbl_DatosPoderEmp.Size = New System.Drawing.Size(66, 39)
        Me.lbl_DatosPoderEmp.TabIndex = 43
        Me.lbl_DatosPoderEmp.Text = "Datos de Poder Empresa"
        Me.lbl_DatosPoderEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_DatosPoderCli
        '
        Me.lbl_DatosPoderCli.Location = New System.Drawing.Point(375, 399)
        Me.lbl_DatosPoderCli.Name = "lbl_DatosPoderCli"
        Me.lbl_DatosPoderCli.Size = New System.Drawing.Size(66, 39)
        Me.lbl_DatosPoderCli.TabIndex = 45
        Me.lbl_DatosPoderCli.Text = "Datos de Poder Clientes"
        Me.lbl_DatosPoderCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtb_DatosPoderCliente
        '
        Me.rtb_DatosPoderCliente.Location = New System.Drawing.Point(447, 396)
        Me.rtb_DatosPoderCliente.Name = "rtb_DatosPoderCliente"
        Me.rtb_DatosPoderCliente.Size = New System.Drawing.Size(228, 54)
        Me.rtb_DatosPoderCliente.TabIndex = 46
        Me.rtb_DatosPoderCliente.Text = ""
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(114, 309)
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(561, 81)
        Me.rtb_Observaciones.TabIndex = 42
        Me.rtb_Observaciones.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(681, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(681, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(348, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(348, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(348, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(348, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(348, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(598, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(217, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(217, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(217, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(217, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        '
        'tbx_TestigoCliente
        '
        Me.tbx_TestigoCliente.Control_Siguiente = Nothing
        Me.tbx_TestigoCliente.Filtrado = True
        Me.tbx_TestigoCliente.Location = New System.Drawing.Point(447, 283)
        Me.tbx_TestigoCliente.Name = "tbx_TestigoCliente"
        Me.tbx_TestigoCliente.Size = New System.Drawing.Size(228, 20)
        Me.tbx_TestigoCliente.TabIndex = 40
        Me.tbx_TestigoCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'tbx_TetigoEmpresa
        '
        Me.tbx_TetigoEmpresa.Control_Siguiente = Nothing
        Me.tbx_TetigoEmpresa.Filtrado = True
        Me.tbx_TetigoEmpresa.Location = New System.Drawing.Point(114, 283)
        Me.tbx_TetigoEmpresa.Name = "tbx_TetigoEmpresa"
        Me.tbx_TetigoEmpresa.Size = New System.Drawing.Size(228, 20)
        Me.tbx_TetigoEmpresa.TabIndex = 38
        Me.tbx_TetigoEmpresa.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'lbl_TestigoCli
        '
        Me.lbl_TestigoCli.AutoSize = True
        Me.lbl_TestigoCli.Location = New System.Drawing.Point(364, 286)
        Me.lbl_TestigoCli.Name = "lbl_TestigoCli"
        Me.lbl_TestigoCli.Size = New System.Drawing.Size(77, 13)
        Me.lbl_TestigoCli.TabIndex = 39
        Me.lbl_TestigoCli.Text = "Testigo Cliente"
        '
        'lbl_TestigoEmp
        '
        Me.lbl_TestigoEmp.AutoSize = True
        Me.lbl_TestigoEmp.Location = New System.Drawing.Point(22, 286)
        Me.lbl_TestigoEmp.Name = "lbl_TestigoEmp"
        Me.lbl_TestigoEmp.Size = New System.Drawing.Size(86, 13)
        Me.lbl_TestigoEmp.TabIndex = 37
        Me.lbl_TestigoEmp.Text = "Tesitgo Empresa"
        '
        'tbx_Filtro
        '
        Me.tbx_Filtro.Control_Siguiente = Nothing
        Me.tbx_Filtro.Filtrado = True
        Me.tbx_Filtro.Location = New System.Drawing.Point(114, 123)
        Me.tbx_Filtro.Name = "tbx_Filtro"
        Me.tbx_Filtro.Size = New System.Drawing.Size(72, 20)
        Me.tbx_Filtro.TabIndex = 13
        Me.tbx_Filtro.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'dtp_FechaContrato
        '
        Me.dtp_FechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaContrato.Location = New System.Drawing.Point(114, 45)
        Me.dtp_FechaContrato.Name = "dtp_FechaContrato"
        Me.dtp_FechaContrato.Size = New System.Drawing.Size(97, 20)
        Me.dtp_FechaContrato.TabIndex = 4
        '
        'lbl_FechaContrato
        '
        Me.lbl_FechaContrato.AutoSize = True
        Me.lbl_FechaContrato.Location = New System.Drawing.Point(28, 51)
        Me.lbl_FechaContrato.Name = "lbl_FechaContrato"
        Me.lbl_FechaContrato.Size = New System.Drawing.Size(80, 13)
        Me.lbl_FechaContrato.TabIndex = 3
        Me.lbl_FechaContrato.Text = "Fecha Contrato"
        '
        'rtb_DatosPoderEmpresa
        '
        Me.rtb_DatosPoderEmpresa.Location = New System.Drawing.Point(114, 396)
        Me.rtb_DatosPoderEmpresa.Name = "rtb_DatosPoderEmpresa"
        Me.rtb_DatosPoderEmpresa.Size = New System.Drawing.Size(228, 54)
        Me.rtb_DatosPoderEmpresa.TabIndex = 44
        Me.rtb_DatosPoderEmpresa.Text = ""
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(30, 312)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 41
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'tbx_PuestoCliente
        '
        Me.tbx_PuestoCliente.Control_Siguiente = Nothing
        Me.tbx_PuestoCliente.Filtrado = True
        Me.tbx_PuestoCliente.Location = New System.Drawing.Point(447, 257)
        Me.tbx_PuestoCliente.Name = "tbx_PuestoCliente"
        Me.tbx_PuestoCliente.Size = New System.Drawing.Size(228, 20)
        Me.tbx_PuestoCliente.TabIndex = 35
        Me.tbx_PuestoCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'tbx_PuestoEmpresa
        '
        Me.tbx_PuestoEmpresa.Control_Siguiente = Nothing
        Me.tbx_PuestoEmpresa.Filtrado = True
        Me.tbx_PuestoEmpresa.Location = New System.Drawing.Point(114, 257)
        Me.tbx_PuestoEmpresa.Name = "tbx_PuestoEmpresa"
        Me.tbx_PuestoEmpresa.Size = New System.Drawing.Size(228, 20)
        Me.tbx_PuestoEmpresa.TabIndex = 32
        Me.tbx_PuestoEmpresa.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'lbl_PuestoCliente
        '
        Me.lbl_PuestoCliente.AutoSize = True
        Me.lbl_PuestoCliente.Location = New System.Drawing.Point(366, 260)
        Me.lbl_PuestoCliente.Name = "lbl_PuestoCliente"
        Me.lbl_PuestoCliente.Size = New System.Drawing.Size(75, 13)
        Me.lbl_PuestoCliente.TabIndex = 34
        Me.lbl_PuestoCliente.Text = "Puesto Cliente"
        '
        'lbl_PuestoEmp
        '
        Me.lbl_PuestoEmp.AutoSize = True
        Me.lbl_PuestoEmp.Location = New System.Drawing.Point(24, 260)
        Me.lbl_PuestoEmp.Name = "lbl_PuestoEmp"
        Me.lbl_PuestoEmp.Size = New System.Drawing.Size(84, 13)
        Me.lbl_PuestoEmp.TabIndex = 31
        Me.lbl_PuestoEmp.Text = "Puesto Empresa"
        '
        'tbx_FirmaCliente
        '
        Me.tbx_FirmaCliente.Control_Siguiente = Nothing
        Me.tbx_FirmaCliente.Filtrado = True
        Me.tbx_FirmaCliente.Location = New System.Drawing.Point(447, 231)
        Me.tbx_FirmaCliente.Name = "tbx_FirmaCliente"
        Me.tbx_FirmaCliente.Size = New System.Drawing.Size(228, 20)
        Me.tbx_FirmaCliente.TabIndex = 29
        Me.tbx_FirmaCliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'tbx_FirmaEmpresa
        '
        Me.tbx_FirmaEmpresa.Control_Siguiente = Nothing
        Me.tbx_FirmaEmpresa.Filtrado = True
        Me.tbx_FirmaEmpresa.Location = New System.Drawing.Point(114, 231)
        Me.tbx_FirmaEmpresa.Name = "tbx_FirmaEmpresa"
        Me.tbx_FirmaEmpresa.Size = New System.Drawing.Size(228, 20)
        Me.tbx_FirmaEmpresa.TabIndex = 26
        Me.tbx_FirmaEmpresa.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYcaracteres
        '
        'lbl_FirmaCliente
        '
        Me.lbl_FirmaCliente.AutoSize = True
        Me.lbl_FirmaCliente.Location = New System.Drawing.Point(374, 234)
        Me.lbl_FirmaCliente.Name = "lbl_FirmaCliente"
        Me.lbl_FirmaCliente.Size = New System.Drawing.Size(67, 13)
        Me.lbl_FirmaCliente.TabIndex = 28
        Me.lbl_FirmaCliente.Text = "Firma Cliente"
        '
        'lbl_FirmaEmp
        '
        Me.lbl_FirmaEmp.AutoSize = True
        Me.lbl_FirmaEmp.Location = New System.Drawing.Point(32, 234)
        Me.lbl_FirmaEmp.Name = "lbl_FirmaEmp"
        Me.lbl_FirmaEmp.Size = New System.Drawing.Size(76, 13)
        Me.lbl_FirmaEmp.TabIndex = 25
        Me.lbl_FirmaEmp.Text = "Firma Empresa"
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.Clave = "Clave_Ciudad"
        Me.cmb_Ciudad.Control_Siguiente = Nothing
        Me.cmb_Ciudad.DisplayMember = "Nombre"
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Empresa = False
        Me.cmb_Ciudad.Filtro = Nothing
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(114, 204)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = True
        Me.cmb_Ciudad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 23
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'lbl_Ciudad
        '
        Me.lbl_Ciudad.AutoSize = True
        Me.lbl_Ciudad.Location = New System.Drawing.Point(68, 207)
        Me.lbl_Ciudad.Name = "lbl_Ciudad"
        Me.lbl_Ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Ciudad.TabIndex = 22
        Me.lbl_Ciudad.Text = "Ciudad"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.Clave = "Clave_Estado"
        Me.cmb_Estado.Control_Siguiente = Nothing
        Me.cmb_Estado.DisplayMember = "Nombre"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Empresa = False
        Me.cmb_Estado.Filtro = Nothing
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(114, 177)
        Me.cmb_Estado.MaxDropDownItems = 20
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Pista = True
        Me.cmb_Estado.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Estado.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_Estado.Sucursal = False
        Me.cmb_Estado.TabIndex = 20
        Me.cmb_Estado.Tipo = 0
        Me.cmb_Estado.ValueMember = "Id_Estado"
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(68, 180)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Estado.TabIndex = 19
        Me.lbl_Estado.Text = "Estado"
        '
        'lbl_Pais
        '
        Me.lbl_Pais.AutoSize = True
        Me.lbl_Pais.Location = New System.Drawing.Point(81, 153)
        Me.lbl_Pais.Name = "lbl_Pais"
        Me.lbl_Pais.Size = New System.Drawing.Size(27, 13)
        Me.lbl_Pais.TabIndex = 16
        Me.lbl_Pais.Text = "Pais"
        '
        'cmb_Pais
        '
        Me.cmb_Pais.Clave = "Clave_Pais"
        Me.cmb_Pais.Control_Siguiente = Nothing
        Me.cmb_Pais.DisplayMember = "Nombre"
        Me.cmb_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pais.Empresa = False
        Me.cmb_Pais.Filtro = Nothing
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(114, 150)
        Me.cmb_Pais.MaxDropDownItems = 20
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.Pista = True
        Me.cmb_Pais.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Pais.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Pais.Sucursal = False
        Me.cmb_Pais.TabIndex = 17
        Me.cmb_Pais.Tipo = 0
        Me.cmb_Pais.ValueMember = "Id_Pais"
        '
        'tbx_NumContrato
        '
        Me.tbx_NumContrato.Control_Siguiente = Nothing
        Me.tbx_NumContrato.Filtrado = True
        Me.tbx_NumContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NumContrato.Location = New System.Drawing.Point(114, 13)
        Me.tbx_NumContrato.MaxLength = 10
        Me.tbx_NumContrato.Name = "tbx_NumContrato"
        Me.tbx_NumContrato.Size = New System.Drawing.Size(100, 26)
        Me.tbx_NumContrato.TabIndex = 1
        Me.tbx_NumContrato.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_NumContrato
        '
        Me.lbl_NumContrato.AutoSize = True
        Me.lbl_NumContrato.Location = New System.Drawing.Point(6, 16)
        Me.lbl_NumContrato.Name = "lbl_NumContrato"
        Me.lbl_NumContrato.Size = New System.Drawing.Size(102, 13)
        Me.lbl_NumContrato.TabIndex = 0
        Me.lbl_NumContrato.Text = "Numero de Contrato"
        '
        'dtp_FechaFin
        '
        Me.dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFin.Location = New System.Drawing.Point(114, 97)
        Me.dtp_FechaFin.Name = "dtp_FechaFin"
        Me.dtp_FechaFin.Size = New System.Drawing.Size(97, 20)
        Me.dtp_FechaFin.TabIndex = 10
        '
        'lbl_FechaFin
        '
        Me.lbl_FechaFin.AutoSize = True
        Me.lbl_FechaFin.Location = New System.Drawing.Point(54, 101)
        Me.lbl_FechaFin.Name = "lbl_FechaFin"
        Me.lbl_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lbl_FechaFin.TabIndex = 9
        Me.lbl_FechaFin.Text = "Fecha Fin"
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(114, 71)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(97, 20)
        Me.dtp_FechaInicio.TabIndex = 7
        '
        'lbl_FechaIni
        '
        Me.lbl_FechaIni.AutoSize = True
        Me.lbl_FechaIni.Location = New System.Drawing.Point(43, 75)
        Me.lbl_FechaIni.Name = "lbl_FechaIni"
        Me.lbl_FechaIni.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaIni.TabIndex = 6
        Me.lbl_FechaIni.Text = "Fecha Inicio"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(69, 126)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 12
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Nothing
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.tbx_Filtro
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(192, 123)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 14
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 48
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 47
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Clausulas)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 498)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(775, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Clausulas
        '
        Me.btn_Clausulas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Clausulas.Image = Global.Modulo_Ventas.My.Resources.Resources.reporte
        Me.btn_Clausulas.Location = New System.Drawing.Point(152, 14)
        Me.btn_Clausulas.Name = "btn_Clausulas"
        Me.btn_Clausulas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Clausulas.TabIndex = 49
        Me.btn_Clausulas.Text = "Clausulas"
        Me.btn_Clausulas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Clausulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Clausulas.UseVisualStyleBackColor = True
        '
        'frm_Contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 552)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Nuevo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 530)
        Me.Name = "frm_Contratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Contratos"
        Me.gbx_Nuevo.ResumeLayout(False)
        Me.gbx_Nuevo.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Nuevo As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Clientes As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIni As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaFin As System.Windows.Forms.Label
    Friend WithEvents tbx_NumContrato As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NumContrato As System.Windows.Forms.Label
    Friend WithEvents lbl_Pais As System.Windows.Forms.Label
    Friend WithEvents cmb_Pais As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents tbx_PuestoCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_PuestoEmpresa As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_PuestoCliente As System.Windows.Forms.Label
    Friend WithEvents lbl_PuestoEmp As System.Windows.Forms.Label
    Friend WithEvents tbx_FirmaCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_FirmaEmpresa As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_FirmaCliente As System.Windows.Forms.Label
    Friend WithEvents lbl_FirmaEmp As System.Windows.Forms.Label
    Friend WithEvents cmb_Ciudad As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Ciudad As System.Windows.Forms.Label
    Friend WithEvents cmb_Estado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents rtb_DatosPoderEmpresa As System.Windows.Forms.RichTextBox
    Friend WithEvents tbx_Filtro As Modulo_Ventas.cp_Textbox
    Friend WithEvents dtp_FechaContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaContrato As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_TestigoCliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_TetigoEmpresa As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_TestigoCli As System.Windows.Forms.Label
    Friend WithEvents lbl_TestigoEmp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_DatosPoderEmp As System.Windows.Forms.Label
    Friend WithEvents lbl_DatosPoderCli As System.Windows.Forms.Label
    Friend WithEvents rtb_DatosPoderCliente As System.Windows.Forms.RichTextBox
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Clausulas As System.Windows.Forms.Button
End Class
