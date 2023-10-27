<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientesHorarios))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.gbx_Recoleccion = New System.Windows.Forms.GroupBox
        Me.cmb_ResultasRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_SabadoRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_ViernesRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_JuevesRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_MiercolesRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_MartesRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_LunesRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_RutaF = New System.Windows.Forms.Label
        Me.cmb_DomingoRutaF = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Frecuencia = New System.Windows.Forms.Label
        Me.lbl_DeF = New System.Windows.Forms.Label
        Me.chk_MartesF = New System.Windows.Forms.CheckBox
        Me.lbl_H_FechaInicioA = New System.Windows.Forms.Label
        Me.cmb_JuevesDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_JuevesAF = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_H_TipoFA = New System.Windows.Forms.Label
        Me.cmb_LunesAF = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ViernesAF = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MartesDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MartesAF = New Modulo_Ventas.cp_cmb_Manual
        Me.chk_LunesF = New System.Windows.Forms.CheckBox
        Me.cmb_H_TipoF = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_H_TipoF = New System.Windows.Forms.Label
        Me.chk_MiercolesF = New System.Windows.Forms.CheckBox
        Me.cmb_ResultasAF = New Modulo_Ventas.cp_cmb_Manual
        Me.chk_DomingoF = New System.Windows.Forms.CheckBox
        Me.cmb_ViernesDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_H_FechaInicio = New System.Windows.Forms.Label
        Me.cmb_LunesDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.dtp_H_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.cmb_SabadoDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_SabadoAF = New Modulo_Ventas.cp_cmb_Manual
        Me.chk_ViernesF = New System.Windows.Forms.CheckBox
        Me.chk_ResultasF = New System.Windows.Forms.CheckBox
        Me.cmb_DomingoAF = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_AF = New System.Windows.Forms.Label
        Me.cmb_DomingoDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.chk_SabadoF = New System.Windows.Forms.CheckBox
        Me.cmb_MiercolesAF = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MiercolesDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.chk_JuevesF = New System.Windows.Forms.CheckBox
        Me.cmb_ResultasDeF = New Modulo_Ventas.cp_cmb_Manual
        Me.btn_Ayuda = New System.Windows.Forms.Button
        Me.lbl_H_ClienteA = New System.Windows.Forms.Label
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.btn_H_Buscar = New System.Windows.Forms.Button
        Me.lbl_H_Cliente = New System.Windows.Forms.Label
        Me.chk_UnicaVez = New System.Windows.Forms.CheckBox
        Me.lbl_FacturarRE = New System.Windows.Forms.Label
        Me.lbl_CargoA = New System.Windows.Forms.Label
        Me.lbl_H_Boveda = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_GuardarH = New System.Windows.Forms.Button
        Me.Btn_CancelarH = New System.Windows.Forms.Button
        Me.lbl_CargoAA = New System.Windows.Forms.Label
        Me.lbl_FacturarRE_A = New System.Windows.Forms.Label
        Me.gbx_Entrega = New System.Windows.Forms.GroupBox
        Me.cmb_ResultasRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_SabadoRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_ViernesRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_JuevesRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_MiercolesRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_MartesRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_LunesRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_RutaD = New System.Windows.Forms.Label
        Me.cmb_DomingoRutaE = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Dia = New System.Windows.Forms.Label
        Me.cmb_ResultasEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_SabadoEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ViernesEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_JuevesEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MiercolesEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MartesEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_LunesEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ResultasE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_SabadoE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ViernesE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_DeD = New System.Windows.Forms.Label
        Me.cmb_JuevesE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_SabadoA = New System.Windows.Forms.Label
        Me.cmb_MiercolesE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_MartesA = New System.Windows.Forms.Label
        Me.cmb_MartesE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_AD = New System.Windows.Forms.Label
        Me.cmb_LunesE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_DomingoDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_DomingoAE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_DomingoE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MiercolesDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_MiercolesAE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_SabadoAE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_DomingoEsc = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ResultasDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ResultasAE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_ResultasA = New System.Windows.Forms.Label
        Me.cmb_MartesAE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_DomingoA = New System.Windows.Forms.Label
        Me.lbl_JuevesA = New System.Windows.Forms.Label
        Me.lbl_LunesA = New System.Windows.Forms.Label
        Me.cmb_JuevesDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_JuevesAE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_ViernesA = New System.Windows.Forms.Label
        Me.cmb_SabadoDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_LunesAE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_LunesDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ViernesAE = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ViernesDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_MiercolesA = New System.Windows.Forms.Label
        Me.cmb_MartesDeE = New Modulo_Ventas.cp_cmb_Manual
        Me.gbx_Cargo = New System.Windows.Forms.GroupBox
        Me.cmb_CargoA = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_FacturarRE = New Modulo_Ventas.cp_cmb_Manual
        Me.gbx_Subclientes = New System.Windows.Forms.GroupBox
        Me.tab_Horarios = New System.Windows.Forms.TabControl
        Me.tab_Clientes = New System.Windows.Forms.TabPage
        Me.lbl_Nota = New System.Windows.Forms.Label
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.tab_HorariosTemp = New System.Windows.Forms.TabPage
        Me.lsv_HorariosTemp = New Modulo_Ventas.cp_Listview
        Me.tab_HorariosReal = New System.Windows.Forms.TabPage
        Me.lsv_HorariosReal = New Modulo_Ventas.cp_Listview
        Me.lbl_DomingoFlecha = New System.Windows.Forms.Label
        Me.lbl_MartesFlecha = New System.Windows.Forms.Label
        Me.lbl_LunesFlecha = New System.Windows.Forms.Label
        Me.lbl_MiercolesFlecha = New System.Windows.Forms.Label
        Me.lbl_JuevesFlecha = New System.Windows.Forms.Label
        Me.lbl_SabadoFlecha = New System.Windows.Forms.Label
        Me.lbl_ResultasFlecha = New System.Windows.Forms.Label
        Me.lbl_ViernesFlecha = New System.Windows.Forms.Label
        Me.gbx_RecoEntrega = New System.Windows.Forms.GroupBox
        Me.rdb_Destino = New System.Windows.Forms.RadioButton
        Me.rdb_Origen = New System.Windows.Forms.RadioButton
        Me.tbx_H_Cliente = New Modulo_Ventas.cp_Textbox
        Me.cmb_H_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.gbx_Recoleccion.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Entrega.SuspendLayout()
        Me.gbx_Cargo.SuspendLayout()
        Me.gbx_Subclientes.SuspendLayout()
        Me.tab_Horarios.SuspendLayout()
        Me.tab_Clientes.SuspendLayout()
        Me.tab_HorariosTemp.SuspendLayout()
        Me.tab_HorariosReal.SuspendLayout()
        Me.gbx_RecoEntrega.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Recoleccion
        '
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_ResultasRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_SabadoRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_ViernesRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_JuevesRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_MiercolesRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_MartesRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_LunesRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_RutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_DomingoRutaF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_Frecuencia)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_DeF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_MartesF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_FechaInicioA)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_JuevesDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_TipoFA)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_LunesAF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_ViernesAF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_MartesDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_LunesF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_H_TipoF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_TipoF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_MiercolesF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_ResultasAF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_DomingoF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_ViernesDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_H_FechaInicio)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_LunesDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.dtp_H_FechaInicio)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_SabadoDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_ViernesF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_JuevesAF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_ResultasF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_DomingoAF)
        Me.gbx_Recoleccion.Controls.Add(Me.lbl_AF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_DomingoDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_MartesAF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_SabadoF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_MiercolesAF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_MiercolesDeF)
        Me.gbx_Recoleccion.Controls.Add(Me.chk_JuevesF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_SabadoAF)
        Me.gbx_Recoleccion.Controls.Add(Me.cmb_ResultasDeF)
        Me.gbx_Recoleccion.Location = New System.Drawing.Point(6, 74)
        Me.gbx_Recoleccion.Name = "gbx_Recoleccion"
        Me.gbx_Recoleccion.Size = New System.Drawing.Size(367, 267)
        Me.gbx_Recoleccion.TabIndex = 0
        Me.gbx_Recoleccion.TabStop = False
        Me.gbx_Recoleccion.Text = "Recolección"
        '
        'cmb_ResultasRutaF
        '
        Me.cmb_ResultasRutaF.Clave = Nothing
        Me.cmb_ResultasRutaF.Control_Siguiente = Nothing
        Me.cmb_ResultasRutaF.DisplayMember = "Descripcion"
        Me.cmb_ResultasRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasRutaF.Empresa = False
        Me.cmb_ResultasRutaF.Enabled = False
        Me.cmb_ResultasRutaF.Filtro = Nothing
        Me.cmb_ResultasRutaF.FormattingEnabled = True
        Me.cmb_ResultasRutaF.Location = New System.Drawing.Point(241, 236)
        Me.cmb_ResultasRutaF.MaxDropDownItems = 20
        Me.cmb_ResultasRutaF.Name = "cmb_ResultasRutaF"
        Me.cmb_ResultasRutaF.Pista = True
        Me.cmb_ResultasRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_ResultasRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_ResultasRutaF.Sucursal = True
        Me.cmb_ResultasRutaF.TabIndex = 98
        Me.cmb_ResultasRutaF.Tipo = 0
        Me.cmb_ResultasRutaF.ValueMember = "Id_Ruta"
        '
        'cmb_SabadoRutaF
        '
        Me.cmb_SabadoRutaF.Clave = Nothing
        Me.cmb_SabadoRutaF.Control_Siguiente = Nothing
        Me.cmb_SabadoRutaF.DisplayMember = "Descripcion"
        Me.cmb_SabadoRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoRutaF.Empresa = False
        Me.cmb_SabadoRutaF.Enabled = False
        Me.cmb_SabadoRutaF.Filtro = Nothing
        Me.cmb_SabadoRutaF.FormattingEnabled = True
        Me.cmb_SabadoRutaF.Location = New System.Drawing.Point(241, 212)
        Me.cmb_SabadoRutaF.MaxDropDownItems = 20
        Me.cmb_SabadoRutaF.Name = "cmb_SabadoRutaF"
        Me.cmb_SabadoRutaF.Pista = True
        Me.cmb_SabadoRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_SabadoRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_SabadoRutaF.Sucursal = True
        Me.cmb_SabadoRutaF.TabIndex = 97
        Me.cmb_SabadoRutaF.Tipo = 0
        Me.cmb_SabadoRutaF.ValueMember = "Id_Ruta"
        '
        'cmb_ViernesRutaF
        '
        Me.cmb_ViernesRutaF.Clave = Nothing
        Me.cmb_ViernesRutaF.Control_Siguiente = Nothing
        Me.cmb_ViernesRutaF.DisplayMember = "Descripcion"
        Me.cmb_ViernesRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesRutaF.Empresa = False
        Me.cmb_ViernesRutaF.Enabled = False
        Me.cmb_ViernesRutaF.Filtro = Nothing
        Me.cmb_ViernesRutaF.FormattingEnabled = True
        Me.cmb_ViernesRutaF.Location = New System.Drawing.Point(241, 188)
        Me.cmb_ViernesRutaF.MaxDropDownItems = 20
        Me.cmb_ViernesRutaF.Name = "cmb_ViernesRutaF"
        Me.cmb_ViernesRutaF.Pista = True
        Me.cmb_ViernesRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_ViernesRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_ViernesRutaF.Sucursal = True
        Me.cmb_ViernesRutaF.TabIndex = 96
        Me.cmb_ViernesRutaF.Tipo = 0
        Me.cmb_ViernesRutaF.ValueMember = "Id_Ruta"
        '
        'cmb_JuevesRutaF
        '
        Me.cmb_JuevesRutaF.Clave = Nothing
        Me.cmb_JuevesRutaF.Control_Siguiente = Nothing
        Me.cmb_JuevesRutaF.DisplayMember = "Descripcion"
        Me.cmb_JuevesRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesRutaF.Empresa = False
        Me.cmb_JuevesRutaF.Enabled = False
        Me.cmb_JuevesRutaF.Filtro = Nothing
        Me.cmb_JuevesRutaF.FormattingEnabled = True
        Me.cmb_JuevesRutaF.Location = New System.Drawing.Point(241, 164)
        Me.cmb_JuevesRutaF.MaxDropDownItems = 20
        Me.cmb_JuevesRutaF.Name = "cmb_JuevesRutaF"
        Me.cmb_JuevesRutaF.Pista = True
        Me.cmb_JuevesRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_JuevesRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_JuevesRutaF.Sucursal = True
        Me.cmb_JuevesRutaF.TabIndex = 95
        Me.cmb_JuevesRutaF.Tipo = 0
        Me.cmb_JuevesRutaF.ValueMember = "Id_Ruta"
        '
        'cmb_MiercolesRutaF
        '
        Me.cmb_MiercolesRutaF.Clave = Nothing
        Me.cmb_MiercolesRutaF.Control_Siguiente = Nothing
        Me.cmb_MiercolesRutaF.DisplayMember = "Descripcion"
        Me.cmb_MiercolesRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesRutaF.Empresa = False
        Me.cmb_MiercolesRutaF.Enabled = False
        Me.cmb_MiercolesRutaF.Filtro = Nothing
        Me.cmb_MiercolesRutaF.FormattingEnabled = True
        Me.cmb_MiercolesRutaF.Location = New System.Drawing.Point(241, 140)
        Me.cmb_MiercolesRutaF.MaxDropDownItems = 20
        Me.cmb_MiercolesRutaF.Name = "cmb_MiercolesRutaF"
        Me.cmb_MiercolesRutaF.Pista = True
        Me.cmb_MiercolesRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_MiercolesRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_MiercolesRutaF.Sucursal = True
        Me.cmb_MiercolesRutaF.TabIndex = 94
        Me.cmb_MiercolesRutaF.Tipo = 0
        Me.cmb_MiercolesRutaF.ValueMember = "Id_Ruta"
        '
        'cmb_MartesRutaF
        '
        Me.cmb_MartesRutaF.Clave = Nothing
        Me.cmb_MartesRutaF.Control_Siguiente = Nothing
        Me.cmb_MartesRutaF.DisplayMember = "Descripcion"
        Me.cmb_MartesRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesRutaF.Empresa = False
        Me.cmb_MartesRutaF.Enabled = False
        Me.cmb_MartesRutaF.Filtro = Nothing
        Me.cmb_MartesRutaF.FormattingEnabled = True
        Me.cmb_MartesRutaF.Location = New System.Drawing.Point(241, 116)
        Me.cmb_MartesRutaF.MaxDropDownItems = 20
        Me.cmb_MartesRutaF.Name = "cmb_MartesRutaF"
        Me.cmb_MartesRutaF.Pista = True
        Me.cmb_MartesRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_MartesRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_MartesRutaF.Sucursal = True
        Me.cmb_MartesRutaF.TabIndex = 93
        Me.cmb_MartesRutaF.Tipo = 0
        Me.cmb_MartesRutaF.ValueMember = "Id_Ruta"
        '
        'cmb_LunesRutaF
        '
        Me.cmb_LunesRutaF.Clave = Nothing
        Me.cmb_LunesRutaF.Control_Siguiente = Nothing
        Me.cmb_LunesRutaF.DisplayMember = "Descripcion"
        Me.cmb_LunesRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesRutaF.Empresa = False
        Me.cmb_LunesRutaF.Enabled = False
        Me.cmb_LunesRutaF.Filtro = Nothing
        Me.cmb_LunesRutaF.FormattingEnabled = True
        Me.cmb_LunesRutaF.Location = New System.Drawing.Point(241, 92)
        Me.cmb_LunesRutaF.MaxDropDownItems = 20
        Me.cmb_LunesRutaF.Name = "cmb_LunesRutaF"
        Me.cmb_LunesRutaF.Pista = True
        Me.cmb_LunesRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_LunesRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_LunesRutaF.Sucursal = True
        Me.cmb_LunesRutaF.TabIndex = 92
        Me.cmb_LunesRutaF.Tipo = 0
        Me.cmb_LunesRutaF.ValueMember = "Id_Ruta"
        '
        'lbl_RutaF
        '
        Me.lbl_RutaF.AutoSize = True
        Me.lbl_RutaF.Location = New System.Drawing.Point(285, 50)
        Me.lbl_RutaF.Name = "lbl_RutaF"
        Me.lbl_RutaF.Size = New System.Drawing.Size(30, 13)
        Me.lbl_RutaF.TabIndex = 91
        Me.lbl_RutaF.Text = "Ruta"
        '
        'cmb_DomingoRutaF
        '
        Me.cmb_DomingoRutaF.Clave = Nothing
        Me.cmb_DomingoRutaF.Control_Siguiente = Nothing
        Me.cmb_DomingoRutaF.DisplayMember = "Descripcion"
        Me.cmb_DomingoRutaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoRutaF.Empresa = False
        Me.cmb_DomingoRutaF.Enabled = False
        Me.cmb_DomingoRutaF.Filtro = Nothing
        Me.cmb_DomingoRutaF.FormattingEnabled = True
        Me.cmb_DomingoRutaF.Location = New System.Drawing.Point(241, 68)
        Me.cmb_DomingoRutaF.MaxDropDownItems = 20
        Me.cmb_DomingoRutaF.Name = "cmb_DomingoRutaF"
        Me.cmb_DomingoRutaF.Pista = True
        Me.cmb_DomingoRutaF.Size = New System.Drawing.Size(118, 21)
        Me.cmb_DomingoRutaF.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_DomingoRutaF.Sucursal = True
        Me.cmb_DomingoRutaF.TabIndex = 90
        Me.cmb_DomingoRutaF.Tipo = 0
        Me.cmb_DomingoRutaF.ValueMember = "Id_Ruta"
        '
        'lbl_Frecuencia
        '
        Me.lbl_Frecuencia.AutoSize = True
        Me.lbl_Frecuencia.Location = New System.Drawing.Point(30, 50)
        Me.lbl_Frecuencia.Name = "lbl_Frecuencia"
        Me.lbl_Frecuencia.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Frecuencia.TabIndex = 89
        Me.lbl_Frecuencia.Text = "Día"
        '
        'lbl_DeF
        '
        Me.lbl_DeF.AutoSize = True
        Me.lbl_DeF.Location = New System.Drawing.Point(109, 50)
        Me.lbl_DeF.Name = "lbl_DeF"
        Me.lbl_DeF.Size = New System.Drawing.Size(24, 13)
        Me.lbl_DeF.TabIndex = 9
        Me.lbl_DeF.Text = "De:"
        '
        'chk_MartesF
        '
        Me.chk_MartesF.AutoSize = True
        Me.chk_MartesF.Location = New System.Drawing.Point(9, 118)
        Me.chk_MartesF.Name = "chk_MartesF"
        Me.chk_MartesF.Size = New System.Drawing.Size(58, 17)
        Me.chk_MartesF.TabIndex = 62
        Me.chk_MartesF.Tag = ""
        Me.chk_MartesF.Text = "Martes"
        Me.chk_MartesF.UseVisualStyleBackColor = True
        '
        'lbl_H_FechaInicioA
        '
        Me.lbl_H_FechaInicioA.AutoSize = True
        Me.lbl_H_FechaInicioA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H_FechaInicioA.ForeColor = System.Drawing.Color.Red
        Me.lbl_H_FechaInicioA.Location = New System.Drawing.Point(178, 19)
        Me.lbl_H_FechaInicioA.Name = "lbl_H_FechaInicioA"
        Me.lbl_H_FechaInicioA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_H_FechaInicioA.TabIndex = 2
        Me.lbl_H_FechaInicioA.Text = "*"
        '
        'cmb_JuevesDeF
        '
        Me.cmb_JuevesDeF.Control_Siguiente = Me.cmb_JuevesAF
        Me.cmb_JuevesDeF.DisplayMember = "display"
        Me.cmb_JuevesDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesDeF.Enabled = False
        Me.cmb_JuevesDeF.FormattingEnabled = True
        Me.cmb_JuevesDeF.Location = New System.Drawing.Point(81, 164)
        Me.cmb_JuevesDeF.MaxDropDownItems = 20
        Me.cmb_JuevesDeF.Name = "cmb_JuevesDeF"
        Me.cmb_JuevesDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_JuevesDeF.TabIndex = 78
        Me.cmb_JuevesDeF.ValueMember = "value"
        '
        'cmb_JuevesAF
        '
        Me.cmb_JuevesAF.Control_Siguiente = Nothing
        Me.cmb_JuevesAF.DisplayMember = "display"
        Me.cmb_JuevesAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesAF.Enabled = False
        Me.cmb_JuevesAF.FormattingEnabled = True
        Me.cmb_JuevesAF.Location = New System.Drawing.Point(161, 164)
        Me.cmb_JuevesAF.MaxDropDownItems = 20
        Me.cmb_JuevesAF.Name = "cmb_JuevesAF"
        Me.cmb_JuevesAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_JuevesAF.TabIndex = 79
        Me.cmb_JuevesAF.ValueMember = "value"
        '
        'lbl_H_TipoFA
        '
        Me.lbl_H_TipoFA.AutoSize = True
        Me.lbl_H_TipoFA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H_TipoFA.ForeColor = System.Drawing.Color.Red
        Me.lbl_H_TipoFA.Location = New System.Drawing.Point(353, 19)
        Me.lbl_H_TipoFA.Name = "lbl_H_TipoFA"
        Me.lbl_H_TipoFA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_H_TipoFA.TabIndex = 7
        Me.lbl_H_TipoFA.Text = "*"
        Me.lbl_H_TipoFA.Visible = False
        '
        'cmb_LunesAF
        '
        Me.cmb_LunesAF.Control_Siguiente = Nothing
        Me.cmb_LunesAF.DisplayMember = "display"
        Me.cmb_LunesAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesAF.Enabled = False
        Me.cmb_LunesAF.FormattingEnabled = True
        Me.cmb_LunesAF.Location = New System.Drawing.Point(161, 92)
        Me.cmb_LunesAF.MaxDropDownItems = 20
        Me.cmb_LunesAF.Name = "cmb_LunesAF"
        Me.cmb_LunesAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_LunesAF.TabIndex = 70
        Me.cmb_LunesAF.ValueMember = "value"
        '
        'cmb_ViernesAF
        '
        Me.cmb_ViernesAF.Control_Siguiente = Nothing
        Me.cmb_ViernesAF.DisplayMember = "display"
        Me.cmb_ViernesAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesAF.Enabled = False
        Me.cmb_ViernesAF.FormattingEnabled = True
        Me.cmb_ViernesAF.Location = New System.Drawing.Point(161, 188)
        Me.cmb_ViernesAF.MaxDropDownItems = 20
        Me.cmb_ViernesAF.Name = "cmb_ViernesAF"
        Me.cmb_ViernesAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ViernesAF.TabIndex = 82
        Me.cmb_ViernesAF.ValueMember = "value"
        '
        'cmb_MartesDeF
        '
        Me.cmb_MartesDeF.Control_Siguiente = Me.cmb_MartesAF
        Me.cmb_MartesDeF.DisplayMember = "display"
        Me.cmb_MartesDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesDeF.Enabled = False
        Me.cmb_MartesDeF.FormattingEnabled = True
        Me.cmb_MartesDeF.Location = New System.Drawing.Point(81, 116)
        Me.cmb_MartesDeF.MaxDropDownItems = 20
        Me.cmb_MartesDeF.Name = "cmb_MartesDeF"
        Me.cmb_MartesDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MartesDeF.TabIndex = 72
        Me.cmb_MartesDeF.ValueMember = "value"
        '
        'cmb_MartesAF
        '
        Me.cmb_MartesAF.Control_Siguiente = Nothing
        Me.cmb_MartesAF.DisplayMember = "display"
        Me.cmb_MartesAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesAF.Enabled = False
        Me.cmb_MartesAF.FormattingEnabled = True
        Me.cmb_MartesAF.Location = New System.Drawing.Point(161, 116)
        Me.cmb_MartesAF.MaxDropDownItems = 20
        Me.cmb_MartesAF.Name = "cmb_MartesAF"
        Me.cmb_MartesAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MartesAF.TabIndex = 73
        Me.cmb_MartesAF.ValueMember = "value"
        '
        'chk_LunesF
        '
        Me.chk_LunesF.AutoSize = True
        Me.chk_LunesF.Location = New System.Drawing.Point(9, 94)
        Me.chk_LunesF.Name = "chk_LunesF"
        Me.chk_LunesF.Size = New System.Drawing.Size(55, 17)
        Me.chk_LunesF.TabIndex = 61
        Me.chk_LunesF.Tag = ""
        Me.chk_LunesF.Text = "Lunes"
        Me.chk_LunesF.UseVisualStyleBackColor = True
        '
        'cmb_H_TipoF
        '
        Me.cmb_H_TipoF.Control_Siguiente = Nothing
        Me.cmb_H_TipoF.DisplayMember = "display"
        Me.cmb_H_TipoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_TipoF.FormattingEnabled = True
        Me.cmb_H_TipoF.Location = New System.Drawing.Point(226, 19)
        Me.cmb_H_TipoF.MaxDropDownItems = 20
        Me.cmb_H_TipoF.Name = "cmb_H_TipoF"
        Me.cmb_H_TipoF.Size = New System.Drawing.Size(121, 21)
        Me.cmb_H_TipoF.TabIndex = 6
        Me.cmb_H_TipoF.ValueMember = "value"
        Me.cmb_H_TipoF.Visible = False
        '
        'lbl_H_TipoF
        '
        Me.lbl_H_TipoF.AutoSize = True
        Me.lbl_H_TipoF.Location = New System.Drawing.Point(192, 22)
        Me.lbl_H_TipoF.Name = "lbl_H_TipoF"
        Me.lbl_H_TipoF.Size = New System.Drawing.Size(28, 13)
        Me.lbl_H_TipoF.TabIndex = 5
        Me.lbl_H_TipoF.Text = "Tipo"
        Me.lbl_H_TipoF.Visible = False
        '
        'chk_MiercolesF
        '
        Me.chk_MiercolesF.AutoSize = True
        Me.chk_MiercolesF.Location = New System.Drawing.Point(9, 142)
        Me.chk_MiercolesF.Name = "chk_MiercolesF"
        Me.chk_MiercolesF.Size = New System.Drawing.Size(71, 17)
        Me.chk_MiercolesF.TabIndex = 63
        Me.chk_MiercolesF.Tag = ""
        Me.chk_MiercolesF.Text = "Miércoles"
        Me.chk_MiercolesF.UseVisualStyleBackColor = True
        '
        'cmb_ResultasAF
        '
        Me.cmb_ResultasAF.Control_Siguiente = Nothing
        Me.cmb_ResultasAF.DisplayMember = "display"
        Me.cmb_ResultasAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasAF.Enabled = False
        Me.cmb_ResultasAF.FormattingEnabled = True
        Me.cmb_ResultasAF.Location = New System.Drawing.Point(161, 236)
        Me.cmb_ResultasAF.MaxDropDownItems = 20
        Me.cmb_ResultasAF.Name = "cmb_ResultasAF"
        Me.cmb_ResultasAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ResultasAF.TabIndex = 88
        Me.cmb_ResultasAF.ValueMember = "value"
        '
        'chk_DomingoF
        '
        Me.chk_DomingoF.AutoSize = True
        Me.chk_DomingoF.Location = New System.Drawing.Point(9, 70)
        Me.chk_DomingoF.Name = "chk_DomingoF"
        Me.chk_DomingoF.Size = New System.Drawing.Size(68, 17)
        Me.chk_DomingoF.TabIndex = 60
        Me.chk_DomingoF.Tag = ""
        Me.chk_DomingoF.Text = "Domingo"
        Me.chk_DomingoF.UseVisualStyleBackColor = True
        '
        'cmb_ViernesDeF
        '
        Me.cmb_ViernesDeF.Control_Siguiente = Me.cmb_ViernesAF
        Me.cmb_ViernesDeF.DisplayMember = "display"
        Me.cmb_ViernesDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesDeF.Enabled = False
        Me.cmb_ViernesDeF.FormattingEnabled = True
        Me.cmb_ViernesDeF.Location = New System.Drawing.Point(81, 188)
        Me.cmb_ViernesDeF.MaxDropDownItems = 20
        Me.cmb_ViernesDeF.Name = "cmb_ViernesDeF"
        Me.cmb_ViernesDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ViernesDeF.TabIndex = 81
        Me.cmb_ViernesDeF.ValueMember = "value"
        '
        'lbl_H_FechaInicio
        '
        Me.lbl_H_FechaInicio.AutoSize = True
        Me.lbl_H_FechaInicio.Location = New System.Drawing.Point(6, 22)
        Me.lbl_H_FechaInicio.Name = "lbl_H_FechaInicio"
        Me.lbl_H_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_H_FechaInicio.TabIndex = 0
        Me.lbl_H_FechaInicio.Text = "Fecha Inicio"
        '
        'cmb_LunesDeF
        '
        Me.cmb_LunesDeF.Control_Siguiente = Me.cmb_LunesAF
        Me.cmb_LunesDeF.DisplayMember = "display"
        Me.cmb_LunesDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesDeF.Enabled = False
        Me.cmb_LunesDeF.FormattingEnabled = True
        Me.cmb_LunesDeF.Location = New System.Drawing.Point(81, 92)
        Me.cmb_LunesDeF.MaxDropDownItems = 20
        Me.cmb_LunesDeF.Name = "cmb_LunesDeF"
        Me.cmb_LunesDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_LunesDeF.TabIndex = 69
        Me.cmb_LunesDeF.ValueMember = "value"
        '
        'dtp_H_FechaInicio
        '
        Me.dtp_H_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_H_FechaInicio.Location = New System.Drawing.Point(77, 19)
        Me.dtp_H_FechaInicio.Name = "dtp_H_FechaInicio"
        Me.dtp_H_FechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_H_FechaInicio.TabIndex = 1
        '
        'cmb_SabadoDeF
        '
        Me.cmb_SabadoDeF.Control_Siguiente = Me.cmb_SabadoAF
        Me.cmb_SabadoDeF.DisplayMember = "display"
        Me.cmb_SabadoDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoDeF.Enabled = False
        Me.cmb_SabadoDeF.FormattingEnabled = True
        Me.cmb_SabadoDeF.Location = New System.Drawing.Point(81, 212)
        Me.cmb_SabadoDeF.MaxDropDownItems = 20
        Me.cmb_SabadoDeF.Name = "cmb_SabadoDeF"
        Me.cmb_SabadoDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_SabadoDeF.TabIndex = 84
        Me.cmb_SabadoDeF.ValueMember = "value"
        '
        'cmb_SabadoAF
        '
        Me.cmb_SabadoAF.Control_Siguiente = Nothing
        Me.cmb_SabadoAF.DisplayMember = "display"
        Me.cmb_SabadoAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoAF.Enabled = False
        Me.cmb_SabadoAF.FormattingEnabled = True
        Me.cmb_SabadoAF.Location = New System.Drawing.Point(161, 212)
        Me.cmb_SabadoAF.MaxDropDownItems = 20
        Me.cmb_SabadoAF.Name = "cmb_SabadoAF"
        Me.cmb_SabadoAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_SabadoAF.TabIndex = 85
        Me.cmb_SabadoAF.ValueMember = "value"
        '
        'chk_ViernesF
        '
        Me.chk_ViernesF.AutoSize = True
        Me.chk_ViernesF.Location = New System.Drawing.Point(9, 190)
        Me.chk_ViernesF.Name = "chk_ViernesF"
        Me.chk_ViernesF.Size = New System.Drawing.Size(61, 17)
        Me.chk_ViernesF.TabIndex = 65
        Me.chk_ViernesF.Text = "Viernes"
        Me.chk_ViernesF.UseVisualStyleBackColor = True
        '
        'chk_ResultasF
        '
        Me.chk_ResultasF.AutoSize = True
        Me.chk_ResultasF.Location = New System.Drawing.Point(9, 238)
        Me.chk_ResultasF.Name = "chk_ResultasF"
        Me.chk_ResultasF.Size = New System.Drawing.Size(67, 17)
        Me.chk_ResultasF.TabIndex = 67
        Me.chk_ResultasF.Text = "Resultas"
        Me.chk_ResultasF.UseVisualStyleBackColor = True
        '
        'cmb_DomingoAF
        '
        Me.cmb_DomingoAF.Control_Siguiente = Nothing
        Me.cmb_DomingoAF.DisplayMember = "display"
        Me.cmb_DomingoAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoAF.Enabled = False
        Me.cmb_DomingoAF.FormattingEnabled = True
        Me.cmb_DomingoAF.Location = New System.Drawing.Point(161, 68)
        Me.cmb_DomingoAF.MaxDropDownItems = 20
        Me.cmb_DomingoAF.Name = "cmb_DomingoAF"
        Me.cmb_DomingoAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_DomingoAF.TabIndex = 59
        Me.cmb_DomingoAF.ValueMember = "value"
        '
        'lbl_AF
        '
        Me.lbl_AF.AutoSize = True
        Me.lbl_AF.Location = New System.Drawing.Point(192, 50)
        Me.lbl_AF.Name = "lbl_AF"
        Me.lbl_AF.Size = New System.Drawing.Size(17, 13)
        Me.lbl_AF.TabIndex = 11
        Me.lbl_AF.Text = "A:"
        '
        'cmb_DomingoDeF
        '
        Me.cmb_DomingoDeF.Control_Siguiente = Me.cmb_DomingoAF
        Me.cmb_DomingoDeF.DisplayMember = "display"
        Me.cmb_DomingoDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoDeF.Enabled = False
        Me.cmb_DomingoDeF.FormattingEnabled = True
        Me.cmb_DomingoDeF.Location = New System.Drawing.Point(81, 68)
        Me.cmb_DomingoDeF.MaxDropDownItems = 20
        Me.cmb_DomingoDeF.Name = "cmb_DomingoDeF"
        Me.cmb_DomingoDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_DomingoDeF.TabIndex = 58
        Me.cmb_DomingoDeF.ValueMember = "value"
        '
        'chk_SabadoF
        '
        Me.chk_SabadoF.AutoSize = True
        Me.chk_SabadoF.Location = New System.Drawing.Point(9, 214)
        Me.chk_SabadoF.Name = "chk_SabadoF"
        Me.chk_SabadoF.Size = New System.Drawing.Size(63, 17)
        Me.chk_SabadoF.TabIndex = 66
        Me.chk_SabadoF.Text = "Sábado"
        Me.chk_SabadoF.UseVisualStyleBackColor = True
        '
        'cmb_MiercolesAF
        '
        Me.cmb_MiercolesAF.Control_Siguiente = Nothing
        Me.cmb_MiercolesAF.DisplayMember = "display"
        Me.cmb_MiercolesAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesAF.Enabled = False
        Me.cmb_MiercolesAF.FormattingEnabled = True
        Me.cmb_MiercolesAF.Location = New System.Drawing.Point(161, 140)
        Me.cmb_MiercolesAF.MaxDropDownItems = 20
        Me.cmb_MiercolesAF.Name = "cmb_MiercolesAF"
        Me.cmb_MiercolesAF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MiercolesAF.TabIndex = 76
        Me.cmb_MiercolesAF.ValueMember = "value"
        '
        'cmb_MiercolesDeF
        '
        Me.cmb_MiercolesDeF.Control_Siguiente = Me.cmb_MiercolesAF
        Me.cmb_MiercolesDeF.DisplayMember = "display"
        Me.cmb_MiercolesDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesDeF.Enabled = False
        Me.cmb_MiercolesDeF.FormattingEnabled = True
        Me.cmb_MiercolesDeF.Location = New System.Drawing.Point(81, 140)
        Me.cmb_MiercolesDeF.MaxDropDownItems = 20
        Me.cmb_MiercolesDeF.Name = "cmb_MiercolesDeF"
        Me.cmb_MiercolesDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MiercolesDeF.TabIndex = 75
        Me.cmb_MiercolesDeF.ValueMember = "value"
        '
        'chk_JuevesF
        '
        Me.chk_JuevesF.AutoSize = True
        Me.chk_JuevesF.Location = New System.Drawing.Point(9, 166)
        Me.chk_JuevesF.Name = "chk_JuevesF"
        Me.chk_JuevesF.Size = New System.Drawing.Size(60, 17)
        Me.chk_JuevesF.TabIndex = 64
        Me.chk_JuevesF.Tag = ""
        Me.chk_JuevesF.Text = "Jueves"
        Me.chk_JuevesF.UseVisualStyleBackColor = True
        '
        'cmb_ResultasDeF
        '
        Me.cmb_ResultasDeF.Control_Siguiente = Me.cmb_ResultasAF
        Me.cmb_ResultasDeF.DisplayMember = "display"
        Me.cmb_ResultasDeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasDeF.Enabled = False
        Me.cmb_ResultasDeF.FormattingEnabled = True
        Me.cmb_ResultasDeF.Location = New System.Drawing.Point(81, 236)
        Me.cmb_ResultasDeF.MaxDropDownItems = 20
        Me.cmb_ResultasDeF.Name = "cmb_ResultasDeF"
        Me.cmb_ResultasDeF.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ResultasDeF.TabIndex = 87
        Me.cmb_ResultasDeF.ValueMember = "value"
        '
        'btn_Ayuda
        '
        Me.btn_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ayuda.Image = Global.Modulo_Ventas.My.Resources.Resources.help_contents
        Me.btn_Ayuda.Location = New System.Drawing.Point(823, 10)
        Me.btn_Ayuda.Name = "btn_Ayuda"
        Me.btn_Ayuda.Size = New System.Drawing.Size(26, 24)
        Me.btn_Ayuda.TabIndex = 26
        Me.btn_Ayuda.UseVisualStyleBackColor = True
        '
        'lbl_H_ClienteA
        '
        Me.lbl_H_ClienteA.AutoSize = True
        Me.lbl_H_ClienteA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H_ClienteA.ForeColor = System.Drawing.Color.Red
        Me.lbl_H_ClienteA.Location = New System.Drawing.Point(576, 33)
        Me.lbl_H_ClienteA.Name = "lbl_H_ClienteA"
        Me.lbl_H_ClienteA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_H_ClienteA.TabIndex = 18
        Me.lbl_H_ClienteA.Text = "*"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Ventas.My.Resources.Resources.edit_add
        Me.btn_Agregar.Location = New System.Drawing.Point(627, 30)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(26, 23)
        Me.btn_Agregar.TabIndex = 20
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_H_Buscar
        '
        Me.btn_H_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_H_Buscar.Location = New System.Drawing.Point(595, 30)
        Me.btn_H_Buscar.Name = "btn_H_Buscar"
        Me.btn_H_Buscar.Size = New System.Drawing.Size(26, 23)
        Me.btn_H_Buscar.TabIndex = 19
        Me.btn_H_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_H_Cliente
        '
        Me.lbl_H_Cliente.AutoSize = True
        Me.lbl_H_Cliente.Location = New System.Drawing.Point(87, 35)
        Me.lbl_H_Cliente.Name = "lbl_H_Cliente"
        Me.lbl_H_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_H_Cliente.TabIndex = 14
        Me.lbl_H_Cliente.Text = "Cliente"
        '
        'chk_UnicaVez
        '
        Me.chk_UnicaVez.AutoSize = True
        Me.chk_UnicaVez.Location = New System.Drawing.Point(493, 17)
        Me.chk_UnicaVez.Name = "chk_UnicaVez"
        Me.chk_UnicaVez.Size = New System.Drawing.Size(151, 17)
        Me.chk_UnicaVez.TabIndex = 6
        Me.chk_UnicaVez.Text = "&Servicio por única ocasión"
        Me.chk_UnicaVez.UseVisualStyleBackColor = True
        '
        'lbl_FacturarRE
        '
        Me.lbl_FacturarRE.AutoSize = True
        Me.lbl_FacturarRE.Location = New System.Drawing.Point(244, 19)
        Me.lbl_FacturarRE.Name = "lbl_FacturarRE"
        Me.lbl_FacturarRE.Size = New System.Drawing.Size(46, 13)
        Me.lbl_FacturarRE.TabIndex = 3
        Me.lbl_FacturarRE.Text = "Facturar"
        '
        'lbl_CargoA
        '
        Me.lbl_CargoA.AutoSize = True
        Me.lbl_CargoA.Location = New System.Drawing.Point(4, 19)
        Me.lbl_CargoA.Name = "lbl_CargoA"
        Me.lbl_CargoA.Size = New System.Drawing.Size(70, 13)
        Me.lbl_CargoA.TabIndex = 0
        Me.lbl_CargoA.Text = "Con Cargo A:"
        '
        'lbl_H_Boveda
        '
        Me.lbl_H_Boveda.AutoSize = True
        Me.lbl_H_Boveda.Location = New System.Drawing.Point(272, 50)
        Me.lbl_H_Boveda.Name = "lbl_H_Boveda"
        Me.lbl_H_Boveda.Size = New System.Drawing.Size(64, 13)
        Me.lbl_H_Boveda.TabIndex = 14
        Me.lbl_H_Boveda.Text = "Escala Bov."
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.Btn_GuardarH)
        Me.gbx_Botones.Controls.Add(Me.Btn_CancelarH)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 528)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(853, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'Btn_GuardarH
        '
        Me.Btn_GuardarH.Enabled = False
        Me.Btn_GuardarH.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.Btn_GuardarH.Location = New System.Drawing.Point(7, 13)
        Me.Btn_GuardarH.Name = "Btn_GuardarH"
        Me.Btn_GuardarH.Size = New System.Drawing.Size(140, 30)
        Me.Btn_GuardarH.TabIndex = 0
        Me.Btn_GuardarH.Text = "&Guardar"
        Me.Btn_GuardarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_GuardarH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_GuardarH.UseVisualStyleBackColor = True
        '
        'Btn_CancelarH
        '
        Me.Btn_CancelarH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CancelarH.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_CancelarH.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_CancelarH.Location = New System.Drawing.Point(707, 13)
        Me.Btn_CancelarH.Name = "Btn_CancelarH"
        Me.Btn_CancelarH.Size = New System.Drawing.Size(140, 30)
        Me.Btn_CancelarH.TabIndex = 1
        Me.Btn_CancelarH.Text = "&Cancelar"
        Me.Btn_CancelarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CancelarH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_CancelarH.UseVisualStyleBackColor = True
        '
        'lbl_CargoAA
        '
        Me.lbl_CargoAA.AutoSize = True
        Me.lbl_CargoAA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CargoAA.ForeColor = System.Drawing.Color.Red
        Me.lbl_CargoAA.Location = New System.Drawing.Point(225, 15)
        Me.lbl_CargoAA.Name = "lbl_CargoAA"
        Me.lbl_CargoAA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_CargoAA.TabIndex = 2
        Me.lbl_CargoAA.Text = "*"
        '
        'lbl_FacturarRE_A
        '
        Me.lbl_FacturarRE_A.AutoSize = True
        Me.lbl_FacturarRE_A.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FacturarRE_A.ForeColor = System.Drawing.Color.Red
        Me.lbl_FacturarRE_A.Location = New System.Drawing.Point(477, 15)
        Me.lbl_FacturarRE_A.Name = "lbl_FacturarRE_A"
        Me.lbl_FacturarRE_A.Size = New System.Drawing.Size(13, 16)
        Me.lbl_FacturarRE_A.TabIndex = 5
        Me.lbl_FacturarRE_A.Text = "*"
        '
        'gbx_Entrega
        '
        Me.gbx_Entrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ResultasRutaE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_SabadoRutaE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ViernesRutaE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_JuevesRutaE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MiercolesRutaE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MartesRutaE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_LunesRutaE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_RutaD)
        Me.gbx_Entrega.Controls.Add(Me.cmb_DomingoRutaE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_Dia)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ResultasEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_SabadoEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ViernesEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_JuevesEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MiercolesEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MartesEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_LunesEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ResultasE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_SabadoE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ViernesE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_DeD)
        Me.gbx_Entrega.Controls.Add(Me.cmb_JuevesE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_SabadoA)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MiercolesE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_MartesA)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MartesE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_AD)
        Me.gbx_Entrega.Controls.Add(Me.cmb_LunesE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_DomingoDeE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_DomingoE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MiercolesDeE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_SabadoAE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_DomingoEsc)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ResultasDeE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_H_Boveda)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MiercolesAE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_ResultasA)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MartesAE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_DomingoA)
        Me.gbx_Entrega.Controls.Add(Me.lbl_JuevesA)
        Me.gbx_Entrega.Controls.Add(Me.lbl_LunesA)
        Me.gbx_Entrega.Controls.Add(Me.cmb_DomingoAE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_JuevesDeE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_JuevesAE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_ViernesA)
        Me.gbx_Entrega.Controls.Add(Me.cmb_SabadoDeE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_LunesAE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_LunesDeE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ViernesAE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ViernesDeE)
        Me.gbx_Entrega.Controls.Add(Me.lbl_MiercolesA)
        Me.gbx_Entrega.Controls.Add(Me.cmb_ResultasAE)
        Me.gbx_Entrega.Controls.Add(Me.cmb_MartesDeE)
        Me.gbx_Entrega.Location = New System.Drawing.Point(379, 74)
        Me.gbx_Entrega.Name = "gbx_Entrega"
        Me.gbx_Entrega.Size = New System.Drawing.Size(480, 267)
        Me.gbx_Entrega.TabIndex = 1
        Me.gbx_Entrega.TabStop = False
        Me.gbx_Entrega.Text = "Entrega"
        '
        'cmb_ResultasRutaE
        '
        Me.cmb_ResultasRutaE.Clave = Nothing
        Me.cmb_ResultasRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_ResultasRutaE.DisplayMember = "Descripcion"
        Me.cmb_ResultasRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasRutaE.Empresa = False
        Me.cmb_ResultasRutaE.Enabled = False
        Me.cmb_ResultasRutaE.Filtro = Nothing
        Me.cmb_ResultasRutaE.FormattingEnabled = True
        Me.cmb_ResultasRutaE.Location = New System.Drawing.Point(347, 236)
        Me.cmb_ResultasRutaE.MaxDropDownItems = 20
        Me.cmb_ResultasRutaE.Name = "cmb_ResultasRutaE"
        Me.cmb_ResultasRutaE.Pista = True
        Me.cmb_ResultasRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_ResultasRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_ResultasRutaE.Sucursal = True
        Me.cmb_ResultasRutaE.TabIndex = 141
        Me.cmb_ResultasRutaE.Tipo = 0
        Me.cmb_ResultasRutaE.ValueMember = "Id_Ruta"
        '
        'cmb_SabadoRutaE
        '
        Me.cmb_SabadoRutaE.Clave = Nothing
        Me.cmb_SabadoRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_SabadoRutaE.DisplayMember = "Descripcion"
        Me.cmb_SabadoRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoRutaE.Empresa = False
        Me.cmb_SabadoRutaE.Enabled = False
        Me.cmb_SabadoRutaE.Filtro = Nothing
        Me.cmb_SabadoRutaE.FormattingEnabled = True
        Me.cmb_SabadoRutaE.Location = New System.Drawing.Point(347, 212)
        Me.cmb_SabadoRutaE.MaxDropDownItems = 20
        Me.cmb_SabadoRutaE.Name = "cmb_SabadoRutaE"
        Me.cmb_SabadoRutaE.Pista = True
        Me.cmb_SabadoRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_SabadoRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_SabadoRutaE.Sucursal = True
        Me.cmb_SabadoRutaE.TabIndex = 140
        Me.cmb_SabadoRutaE.Tipo = 0
        Me.cmb_SabadoRutaE.ValueMember = "Id_Ruta"
        '
        'cmb_ViernesRutaE
        '
        Me.cmb_ViernesRutaE.Clave = Nothing
        Me.cmb_ViernesRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_ViernesRutaE.DisplayMember = "Descripcion"
        Me.cmb_ViernesRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesRutaE.Empresa = False
        Me.cmb_ViernesRutaE.Enabled = False
        Me.cmb_ViernesRutaE.Filtro = Nothing
        Me.cmb_ViernesRutaE.FormattingEnabled = True
        Me.cmb_ViernesRutaE.Location = New System.Drawing.Point(347, 188)
        Me.cmb_ViernesRutaE.MaxDropDownItems = 20
        Me.cmb_ViernesRutaE.Name = "cmb_ViernesRutaE"
        Me.cmb_ViernesRutaE.Pista = True
        Me.cmb_ViernesRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_ViernesRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_ViernesRutaE.Sucursal = True
        Me.cmb_ViernesRutaE.TabIndex = 139
        Me.cmb_ViernesRutaE.Tipo = 0
        Me.cmb_ViernesRutaE.ValueMember = "Id_Ruta"
        '
        'cmb_JuevesRutaE
        '
        Me.cmb_JuevesRutaE.Clave = Nothing
        Me.cmb_JuevesRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_JuevesRutaE.DisplayMember = "Descripcion"
        Me.cmb_JuevesRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesRutaE.Empresa = False
        Me.cmb_JuevesRutaE.Enabled = False
        Me.cmb_JuevesRutaE.Filtro = Nothing
        Me.cmb_JuevesRutaE.FormattingEnabled = True
        Me.cmb_JuevesRutaE.Location = New System.Drawing.Point(347, 164)
        Me.cmb_JuevesRutaE.MaxDropDownItems = 20
        Me.cmb_JuevesRutaE.Name = "cmb_JuevesRutaE"
        Me.cmb_JuevesRutaE.Pista = True
        Me.cmb_JuevesRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_JuevesRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_JuevesRutaE.Sucursal = True
        Me.cmb_JuevesRutaE.TabIndex = 138
        Me.cmb_JuevesRutaE.Tipo = 0
        Me.cmb_JuevesRutaE.ValueMember = "Id_Ruta"
        '
        'cmb_MiercolesRutaE
        '
        Me.cmb_MiercolesRutaE.Clave = Nothing
        Me.cmb_MiercolesRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_MiercolesRutaE.DisplayMember = "Descripcion"
        Me.cmb_MiercolesRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesRutaE.Empresa = False
        Me.cmb_MiercolesRutaE.Enabled = False
        Me.cmb_MiercolesRutaE.Filtro = Nothing
        Me.cmb_MiercolesRutaE.FormattingEnabled = True
        Me.cmb_MiercolesRutaE.Location = New System.Drawing.Point(347, 140)
        Me.cmb_MiercolesRutaE.MaxDropDownItems = 20
        Me.cmb_MiercolesRutaE.Name = "cmb_MiercolesRutaE"
        Me.cmb_MiercolesRutaE.Pista = True
        Me.cmb_MiercolesRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_MiercolesRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_MiercolesRutaE.Sucursal = True
        Me.cmb_MiercolesRutaE.TabIndex = 137
        Me.cmb_MiercolesRutaE.Tipo = 0
        Me.cmb_MiercolesRutaE.ValueMember = "Id_Ruta"
        '
        'cmb_MartesRutaE
        '
        Me.cmb_MartesRutaE.Clave = Nothing
        Me.cmb_MartesRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_MartesRutaE.DisplayMember = "Descripcion"
        Me.cmb_MartesRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesRutaE.Empresa = False
        Me.cmb_MartesRutaE.Enabled = False
        Me.cmb_MartesRutaE.Filtro = Nothing
        Me.cmb_MartesRutaE.FormattingEnabled = True
        Me.cmb_MartesRutaE.Location = New System.Drawing.Point(347, 116)
        Me.cmb_MartesRutaE.MaxDropDownItems = 20
        Me.cmb_MartesRutaE.Name = "cmb_MartesRutaE"
        Me.cmb_MartesRutaE.Pista = True
        Me.cmb_MartesRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_MartesRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_MartesRutaE.Sucursal = True
        Me.cmb_MartesRutaE.TabIndex = 136
        Me.cmb_MartesRutaE.Tipo = 0
        Me.cmb_MartesRutaE.ValueMember = "Id_Ruta"
        '
        'cmb_LunesRutaE
        '
        Me.cmb_LunesRutaE.Clave = Nothing
        Me.cmb_LunesRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_LunesRutaE.DisplayMember = "Descripcion"
        Me.cmb_LunesRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesRutaE.Empresa = False
        Me.cmb_LunesRutaE.Enabled = False
        Me.cmb_LunesRutaE.Filtro = Nothing
        Me.cmb_LunesRutaE.FormattingEnabled = True
        Me.cmb_LunesRutaE.Location = New System.Drawing.Point(347, 92)
        Me.cmb_LunesRutaE.MaxDropDownItems = 20
        Me.cmb_LunesRutaE.Name = "cmb_LunesRutaE"
        Me.cmb_LunesRutaE.Pista = True
        Me.cmb_LunesRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_LunesRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_LunesRutaE.Sucursal = True
        Me.cmb_LunesRutaE.TabIndex = 135
        Me.cmb_LunesRutaE.Tipo = 0
        Me.cmb_LunesRutaE.ValueMember = "Id_Ruta"
        '
        'lbl_RutaD
        '
        Me.lbl_RutaD.AutoSize = True
        Me.lbl_RutaD.Location = New System.Drawing.Point(390, 50)
        Me.lbl_RutaD.Name = "lbl_RutaD"
        Me.lbl_RutaD.Size = New System.Drawing.Size(30, 13)
        Me.lbl_RutaD.TabIndex = 92
        Me.lbl_RutaD.Text = "Ruta"
        '
        'cmb_DomingoRutaE
        '
        Me.cmb_DomingoRutaE.Clave = Nothing
        Me.cmb_DomingoRutaE.Control_Siguiente = Me.Btn_GuardarH
        Me.cmb_DomingoRutaE.DisplayMember = "Descripcion"
        Me.cmb_DomingoRutaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoRutaE.Empresa = False
        Me.cmb_DomingoRutaE.Enabled = False
        Me.cmb_DomingoRutaE.Filtro = Nothing
        Me.cmb_DomingoRutaE.FormattingEnabled = True
        Me.cmb_DomingoRutaE.Location = New System.Drawing.Point(347, 68)
        Me.cmb_DomingoRutaE.MaxDropDownItems = 20
        Me.cmb_DomingoRutaE.Name = "cmb_DomingoRutaE"
        Me.cmb_DomingoRutaE.Pista = True
        Me.cmb_DomingoRutaE.Size = New System.Drawing.Size(118, 21)
        Me.cmb_DomingoRutaE.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_DomingoRutaE.Sucursal = True
        Me.cmb_DomingoRutaE.TabIndex = 134
        Me.cmb_DomingoRutaE.Tipo = 0
        Me.cmb_DomingoRutaE.ValueMember = "Id_Ruta"
        '
        'lbl_Dia
        '
        Me.lbl_Dia.AutoSize = True
        Me.lbl_Dia.Location = New System.Drawing.Point(43, 50)
        Me.lbl_Dia.Name = "lbl_Dia"
        Me.lbl_Dia.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Dia.TabIndex = 133
        Me.lbl_Dia.Text = "Día"
        '
        'cmb_ResultasEsc
        '
        Me.cmb_ResultasEsc.Control_Siguiente = Nothing
        Me.cmb_ResultasEsc.DisplayMember = "display"
        Me.cmb_ResultasEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasEsc.Enabled = False
        Me.cmb_ResultasEsc.FormattingEnabled = True
        Me.cmb_ResultasEsc.Location = New System.Drawing.Point(267, 236)
        Me.cmb_ResultasEsc.MaxDropDownItems = 20
        Me.cmb_ResultasEsc.Name = "cmb_ResultasEsc"
        Me.cmb_ResultasEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ResultasEsc.TabIndex = 132
        Me.cmb_ResultasEsc.ValueMember = "value"
        '
        'cmb_SabadoEsc
        '
        Me.cmb_SabadoEsc.Control_Siguiente = Nothing
        Me.cmb_SabadoEsc.DisplayMember = "display"
        Me.cmb_SabadoEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoEsc.Enabled = False
        Me.cmb_SabadoEsc.FormattingEnabled = True
        Me.cmb_SabadoEsc.Location = New System.Drawing.Point(267, 212)
        Me.cmb_SabadoEsc.MaxDropDownItems = 20
        Me.cmb_SabadoEsc.Name = "cmb_SabadoEsc"
        Me.cmb_SabadoEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_SabadoEsc.TabIndex = 132
        Me.cmb_SabadoEsc.ValueMember = "value"
        '
        'cmb_ViernesEsc
        '
        Me.cmb_ViernesEsc.Control_Siguiente = Nothing
        Me.cmb_ViernesEsc.DisplayMember = "display"
        Me.cmb_ViernesEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesEsc.Enabled = False
        Me.cmb_ViernesEsc.FormattingEnabled = True
        Me.cmb_ViernesEsc.Location = New System.Drawing.Point(267, 188)
        Me.cmb_ViernesEsc.MaxDropDownItems = 20
        Me.cmb_ViernesEsc.Name = "cmb_ViernesEsc"
        Me.cmb_ViernesEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ViernesEsc.TabIndex = 132
        Me.cmb_ViernesEsc.ValueMember = "value"
        '
        'cmb_JuevesEsc
        '
        Me.cmb_JuevesEsc.Control_Siguiente = Nothing
        Me.cmb_JuevesEsc.DisplayMember = "display"
        Me.cmb_JuevesEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesEsc.Enabled = False
        Me.cmb_JuevesEsc.FormattingEnabled = True
        Me.cmb_JuevesEsc.Location = New System.Drawing.Point(267, 164)
        Me.cmb_JuevesEsc.MaxDropDownItems = 20
        Me.cmb_JuevesEsc.Name = "cmb_JuevesEsc"
        Me.cmb_JuevesEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_JuevesEsc.TabIndex = 132
        Me.cmb_JuevesEsc.ValueMember = "value"
        '
        'cmb_MiercolesEsc
        '
        Me.cmb_MiercolesEsc.Control_Siguiente = Nothing
        Me.cmb_MiercolesEsc.DisplayMember = "display"
        Me.cmb_MiercolesEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesEsc.Enabled = False
        Me.cmb_MiercolesEsc.FormattingEnabled = True
        Me.cmb_MiercolesEsc.Location = New System.Drawing.Point(267, 140)
        Me.cmb_MiercolesEsc.MaxDropDownItems = 20
        Me.cmb_MiercolesEsc.Name = "cmb_MiercolesEsc"
        Me.cmb_MiercolesEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MiercolesEsc.TabIndex = 132
        Me.cmb_MiercolesEsc.ValueMember = "value"
        '
        'cmb_MartesEsc
        '
        Me.cmb_MartesEsc.Control_Siguiente = Nothing
        Me.cmb_MartesEsc.DisplayMember = "display"
        Me.cmb_MartesEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesEsc.Enabled = False
        Me.cmb_MartesEsc.FormattingEnabled = True
        Me.cmb_MartesEsc.Location = New System.Drawing.Point(267, 116)
        Me.cmb_MartesEsc.MaxDropDownItems = 20
        Me.cmb_MartesEsc.Name = "cmb_MartesEsc"
        Me.cmb_MartesEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MartesEsc.TabIndex = 131
        Me.cmb_MartesEsc.ValueMember = "value"
        '
        'cmb_LunesEsc
        '
        Me.cmb_LunesEsc.Control_Siguiente = Nothing
        Me.cmb_LunesEsc.DisplayMember = "display"
        Me.cmb_LunesEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesEsc.Enabled = False
        Me.cmb_LunesEsc.FormattingEnabled = True
        Me.cmb_LunesEsc.Location = New System.Drawing.Point(267, 92)
        Me.cmb_LunesEsc.MaxDropDownItems = 20
        Me.cmb_LunesEsc.Name = "cmb_LunesEsc"
        Me.cmb_LunesEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_LunesEsc.TabIndex = 130
        Me.cmb_LunesEsc.ValueMember = "value"
        '
        'cmb_ResultasE
        '
        Me.cmb_ResultasE.Control_Siguiente = Nothing
        Me.cmb_ResultasE.DisplayMember = "display"
        Me.cmb_ResultasE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasE.Enabled = False
        Me.cmb_ResultasE.FormattingEnabled = True
        Me.cmb_ResultasE.Location = New System.Drawing.Point(17, 236)
        Me.cmb_ResultasE.MaxDropDownItems = 20
        Me.cmb_ResultasE.Name = "cmb_ResultasE"
        Me.cmb_ResultasE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_ResultasE.TabIndex = 129
        Me.cmb_ResultasE.ValueMember = "value"
        '
        'cmb_SabadoE
        '
        Me.cmb_SabadoE.Control_Siguiente = Nothing
        Me.cmb_SabadoE.DisplayMember = "display"
        Me.cmb_SabadoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoE.Enabled = False
        Me.cmb_SabadoE.FormattingEnabled = True
        Me.cmb_SabadoE.Location = New System.Drawing.Point(17, 212)
        Me.cmb_SabadoE.MaxDropDownItems = 20
        Me.cmb_SabadoE.Name = "cmb_SabadoE"
        Me.cmb_SabadoE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_SabadoE.TabIndex = 128
        Me.cmb_SabadoE.ValueMember = "value"
        '
        'cmb_ViernesE
        '
        Me.cmb_ViernesE.Control_Siguiente = Nothing
        Me.cmb_ViernesE.DisplayMember = "display"
        Me.cmb_ViernesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesE.Enabled = False
        Me.cmb_ViernesE.FormattingEnabled = True
        Me.cmb_ViernesE.Location = New System.Drawing.Point(17, 188)
        Me.cmb_ViernesE.MaxDropDownItems = 20
        Me.cmb_ViernesE.Name = "cmb_ViernesE"
        Me.cmb_ViernesE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_ViernesE.TabIndex = 127
        Me.cmb_ViernesE.ValueMember = "value"
        '
        'lbl_DeD
        '
        Me.lbl_DeD.AutoSize = True
        Me.lbl_DeD.Location = New System.Drawing.Point(133, 50)
        Me.lbl_DeD.Name = "lbl_DeD"
        Me.lbl_DeD.Size = New System.Drawing.Size(24, 13)
        Me.lbl_DeD.TabIndex = 89
        Me.lbl_DeD.Text = "De:"
        '
        'cmb_JuevesE
        '
        Me.cmb_JuevesE.Control_Siguiente = Nothing
        Me.cmb_JuevesE.DisplayMember = "display"
        Me.cmb_JuevesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesE.Enabled = False
        Me.cmb_JuevesE.FormattingEnabled = True
        Me.cmb_JuevesE.Location = New System.Drawing.Point(17, 164)
        Me.cmb_JuevesE.MaxDropDownItems = 20
        Me.cmb_JuevesE.Name = "cmb_JuevesE"
        Me.cmb_JuevesE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_JuevesE.TabIndex = 126
        Me.cmb_JuevesE.ValueMember = "value"
        '
        'lbl_SabadoA
        '
        Me.lbl_SabadoA.AutoSize = True
        Me.lbl_SabadoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SabadoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_SabadoA.Location = New System.Drawing.Point(468, 213)
        Me.lbl_SabadoA.Name = "lbl_SabadoA"
        Me.lbl_SabadoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_SabadoA.TabIndex = 117
        Me.lbl_SabadoA.Text = "*"
        Me.lbl_SabadoA.Visible = False
        '
        'cmb_MiercolesE
        '
        Me.cmb_MiercolesE.Control_Siguiente = Nothing
        Me.cmb_MiercolesE.DisplayMember = "display"
        Me.cmb_MiercolesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesE.Enabled = False
        Me.cmb_MiercolesE.FormattingEnabled = True
        Me.cmb_MiercolesE.Location = New System.Drawing.Point(17, 140)
        Me.cmb_MiercolesE.MaxDropDownItems = 20
        Me.cmb_MiercolesE.Name = "cmb_MiercolesE"
        Me.cmb_MiercolesE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_MiercolesE.TabIndex = 125
        Me.cmb_MiercolesE.ValueMember = "value"
        '
        'lbl_MartesA
        '
        Me.lbl_MartesA.AutoSize = True
        Me.lbl_MartesA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MartesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MartesA.Location = New System.Drawing.Point(468, 117)
        Me.lbl_MartesA.Name = "lbl_MartesA"
        Me.lbl_MartesA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_MartesA.TabIndex = 105
        Me.lbl_MartesA.Text = "*"
        Me.lbl_MartesA.Visible = False
        '
        'cmb_MartesE
        '
        Me.cmb_MartesE.Control_Siguiente = Nothing
        Me.cmb_MartesE.DisplayMember = "display"
        Me.cmb_MartesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesE.Enabled = False
        Me.cmb_MartesE.FormattingEnabled = True
        Me.cmb_MartesE.Location = New System.Drawing.Point(17, 116)
        Me.cmb_MartesE.MaxDropDownItems = 20
        Me.cmb_MartesE.Name = "cmb_MartesE"
        Me.cmb_MartesE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_MartesE.TabIndex = 124
        Me.cmb_MartesE.ValueMember = "value"
        '
        'lbl_AD
        '
        Me.lbl_AD.AutoSize = True
        Me.lbl_AD.Location = New System.Drawing.Point(216, 50)
        Me.lbl_AD.Name = "lbl_AD"
        Me.lbl_AD.Size = New System.Drawing.Size(17, 13)
        Me.lbl_AD.TabIndex = 90
        Me.lbl_AD.Text = "A:"
        '
        'cmb_LunesE
        '
        Me.cmb_LunesE.Control_Siguiente = Nothing
        Me.cmb_LunesE.DisplayMember = "display"
        Me.cmb_LunesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesE.Enabled = False
        Me.cmb_LunesE.FormattingEnabled = True
        Me.cmb_LunesE.Location = New System.Drawing.Point(17, 92)
        Me.cmb_LunesE.MaxDropDownItems = 20
        Me.cmb_LunesE.Name = "cmb_LunesE"
        Me.cmb_LunesE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_LunesE.TabIndex = 123
        Me.cmb_LunesE.ValueMember = "value"
        '
        'cmb_DomingoDeE
        '
        Me.cmb_DomingoDeE.Control_Siguiente = Me.cmb_DomingoAE
        Me.cmb_DomingoDeE.DisplayMember = "display"
        Me.cmb_DomingoDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoDeE.Enabled = False
        Me.cmb_DomingoDeE.FormattingEnabled = True
        Me.cmb_DomingoDeE.Location = New System.Drawing.Point(107, 68)
        Me.cmb_DomingoDeE.MaxDropDownItems = 20
        Me.cmb_DomingoDeE.Name = "cmb_DomingoDeE"
        Me.cmb_DomingoDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_DomingoDeE.TabIndex = 92
        Me.cmb_DomingoDeE.ValueMember = "value"
        '
        'cmb_DomingoAE
        '
        Me.cmb_DomingoAE.Control_Siguiente = Nothing
        Me.cmb_DomingoAE.DisplayMember = "display"
        Me.cmb_DomingoAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoAE.Enabled = False
        Me.cmb_DomingoAE.FormattingEnabled = True
        Me.cmb_DomingoAE.Location = New System.Drawing.Point(187, 68)
        Me.cmb_DomingoAE.MaxDropDownItems = 20
        Me.cmb_DomingoAE.Name = "cmb_DomingoAE"
        Me.cmb_DomingoAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_DomingoAE.TabIndex = 93
        Me.cmb_DomingoAE.ValueMember = "value"
        '
        'cmb_DomingoE
        '
        Me.cmb_DomingoE.Control_Siguiente = Nothing
        Me.cmb_DomingoE.DisplayMember = "display"
        Me.cmb_DomingoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoE.Enabled = False
        Me.cmb_DomingoE.FormattingEnabled = True
        Me.cmb_DomingoE.Location = New System.Drawing.Point(17, 68)
        Me.cmb_DomingoE.MaxDropDownItems = 20
        Me.cmb_DomingoE.Name = "cmb_DomingoE"
        Me.cmb_DomingoE.Size = New System.Drawing.Size(86, 21)
        Me.cmb_DomingoE.TabIndex = 25
        Me.cmb_DomingoE.ValueMember = "value"
        '
        'cmb_MiercolesDeE
        '
        Me.cmb_MiercolesDeE.Control_Siguiente = Me.cmb_MiercolesAE
        Me.cmb_MiercolesDeE.DisplayMember = "display"
        Me.cmb_MiercolesDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesDeE.Enabled = False
        Me.cmb_MiercolesDeE.FormattingEnabled = True
        Me.cmb_MiercolesDeE.Location = New System.Drawing.Point(107, 140)
        Me.cmb_MiercolesDeE.MaxDropDownItems = 20
        Me.cmb_MiercolesDeE.Name = "cmb_MiercolesDeE"
        Me.cmb_MiercolesDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MiercolesDeE.TabIndex = 109
        Me.cmb_MiercolesDeE.ValueMember = "value"
        '
        'cmb_MiercolesAE
        '
        Me.cmb_MiercolesAE.Control_Siguiente = Nothing
        Me.cmb_MiercolesAE.DisplayMember = "display"
        Me.cmb_MiercolesAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MiercolesAE.Enabled = False
        Me.cmb_MiercolesAE.FormattingEnabled = True
        Me.cmb_MiercolesAE.Location = New System.Drawing.Point(187, 140)
        Me.cmb_MiercolesAE.MaxDropDownItems = 20
        Me.cmb_MiercolesAE.Name = "cmb_MiercolesAE"
        Me.cmb_MiercolesAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MiercolesAE.TabIndex = 110
        Me.cmb_MiercolesAE.ValueMember = "value"
        '
        'cmb_SabadoAE
        '
        Me.cmb_SabadoAE.Control_Siguiente = Nothing
        Me.cmb_SabadoAE.DisplayMember = "display"
        Me.cmb_SabadoAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoAE.Enabled = False
        Me.cmb_SabadoAE.FormattingEnabled = True
        Me.cmb_SabadoAE.Location = New System.Drawing.Point(187, 212)
        Me.cmb_SabadoAE.MaxDropDownItems = 20
        Me.cmb_SabadoAE.Name = "cmb_SabadoAE"
        Me.cmb_SabadoAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_SabadoAE.TabIndex = 119
        Me.cmb_SabadoAE.ValueMember = "value"
        '
        'cmb_DomingoEsc
        '
        Me.cmb_DomingoEsc.Control_Siguiente = Nothing
        Me.cmb_DomingoEsc.DisplayMember = "display"
        Me.cmb_DomingoEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DomingoEsc.Enabled = False
        Me.cmb_DomingoEsc.FormattingEnabled = True
        Me.cmb_DomingoEsc.Location = New System.Drawing.Point(267, 68)
        Me.cmb_DomingoEsc.MaxDropDownItems = 20
        Me.cmb_DomingoEsc.Name = "cmb_DomingoEsc"
        Me.cmb_DomingoEsc.Size = New System.Drawing.Size(76, 21)
        Me.cmb_DomingoEsc.TabIndex = 15
        Me.cmb_DomingoEsc.ValueMember = "value"
        '
        'cmb_ResultasDeE
        '
        Me.cmb_ResultasDeE.Control_Siguiente = Me.cmb_ResultasAE
        Me.cmb_ResultasDeE.DisplayMember = "display"
        Me.cmb_ResultasDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasDeE.Enabled = False
        Me.cmb_ResultasDeE.FormattingEnabled = True
        Me.cmb_ResultasDeE.Location = New System.Drawing.Point(107, 236)
        Me.cmb_ResultasDeE.MaxDropDownItems = 20
        Me.cmb_ResultasDeE.Name = "cmb_ResultasDeE"
        Me.cmb_ResultasDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ResultasDeE.TabIndex = 121
        Me.cmb_ResultasDeE.ValueMember = "value"
        '
        'cmb_ResultasAE
        '
        Me.cmb_ResultasAE.Control_Siguiente = Nothing
        Me.cmb_ResultasAE.DisplayMember = "display"
        Me.cmb_ResultasAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ResultasAE.Enabled = False
        Me.cmb_ResultasAE.FormattingEnabled = True
        Me.cmb_ResultasAE.Location = New System.Drawing.Point(187, 236)
        Me.cmb_ResultasAE.MaxDropDownItems = 20
        Me.cmb_ResultasAE.Name = "cmb_ResultasAE"
        Me.cmb_ResultasAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ResultasAE.TabIndex = 122
        Me.cmb_ResultasAE.ValueMember = "value"
        '
        'lbl_ResultasA
        '
        Me.lbl_ResultasA.AutoSize = True
        Me.lbl_ResultasA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ResultasA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ResultasA.Location = New System.Drawing.Point(468, 237)
        Me.lbl_ResultasA.Name = "lbl_ResultasA"
        Me.lbl_ResultasA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ResultasA.TabIndex = 120
        Me.lbl_ResultasA.Text = "*"
        Me.lbl_ResultasA.Visible = False
        '
        'cmb_MartesAE
        '
        Me.cmb_MartesAE.Control_Siguiente = Nothing
        Me.cmb_MartesAE.DisplayMember = "display"
        Me.cmb_MartesAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesAE.Enabled = False
        Me.cmb_MartesAE.FormattingEnabled = True
        Me.cmb_MartesAE.Location = New System.Drawing.Point(187, 116)
        Me.cmb_MartesAE.MaxDropDownItems = 20
        Me.cmb_MartesAE.Name = "cmb_MartesAE"
        Me.cmb_MartesAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MartesAE.TabIndex = 107
        Me.cmb_MartesAE.ValueMember = "value"
        '
        'lbl_DomingoA
        '
        Me.lbl_DomingoA.AutoSize = True
        Me.lbl_DomingoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DomingoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_DomingoA.Location = New System.Drawing.Point(468, 69)
        Me.lbl_DomingoA.Name = "lbl_DomingoA"
        Me.lbl_DomingoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_DomingoA.TabIndex = 91
        Me.lbl_DomingoA.Text = "*"
        Me.lbl_DomingoA.Visible = False
        '
        'lbl_JuevesA
        '
        Me.lbl_JuevesA.AutoSize = True
        Me.lbl_JuevesA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_JuevesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_JuevesA.Location = New System.Drawing.Point(468, 165)
        Me.lbl_JuevesA.Name = "lbl_JuevesA"
        Me.lbl_JuevesA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_JuevesA.TabIndex = 111
        Me.lbl_JuevesA.Text = "*"
        Me.lbl_JuevesA.Visible = False
        '
        'lbl_LunesA
        '
        Me.lbl_LunesA.AutoSize = True
        Me.lbl_LunesA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LunesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_LunesA.Location = New System.Drawing.Point(468, 93)
        Me.lbl_LunesA.Name = "lbl_LunesA"
        Me.lbl_LunesA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_LunesA.TabIndex = 102
        Me.lbl_LunesA.Text = "*"
        Me.lbl_LunesA.Visible = False
        '
        'cmb_JuevesDeE
        '
        Me.cmb_JuevesDeE.Control_Siguiente = Me.cmb_JuevesAE
        Me.cmb_JuevesDeE.DisplayMember = "display"
        Me.cmb_JuevesDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesDeE.Enabled = False
        Me.cmb_JuevesDeE.FormattingEnabled = True
        Me.cmb_JuevesDeE.Location = New System.Drawing.Point(107, 164)
        Me.cmb_JuevesDeE.MaxDropDownItems = 20
        Me.cmb_JuevesDeE.Name = "cmb_JuevesDeE"
        Me.cmb_JuevesDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_JuevesDeE.TabIndex = 112
        Me.cmb_JuevesDeE.ValueMember = "value"
        '
        'cmb_JuevesAE
        '
        Me.cmb_JuevesAE.Control_Siguiente = Nothing
        Me.cmb_JuevesAE.DisplayMember = "display"
        Me.cmb_JuevesAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JuevesAE.Enabled = False
        Me.cmb_JuevesAE.FormattingEnabled = True
        Me.cmb_JuevesAE.Location = New System.Drawing.Point(187, 164)
        Me.cmb_JuevesAE.MaxDropDownItems = 20
        Me.cmb_JuevesAE.Name = "cmb_JuevesAE"
        Me.cmb_JuevesAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_JuevesAE.TabIndex = 113
        Me.cmb_JuevesAE.ValueMember = "value"
        '
        'lbl_ViernesA
        '
        Me.lbl_ViernesA.AutoSize = True
        Me.lbl_ViernesA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ViernesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ViernesA.Location = New System.Drawing.Point(468, 189)
        Me.lbl_ViernesA.Name = "lbl_ViernesA"
        Me.lbl_ViernesA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ViernesA.TabIndex = 114
        Me.lbl_ViernesA.Text = "*"
        Me.lbl_ViernesA.Visible = False
        '
        'cmb_SabadoDeE
        '
        Me.cmb_SabadoDeE.Control_Siguiente = Me.cmb_SabadoAE
        Me.cmb_SabadoDeE.DisplayMember = "display"
        Me.cmb_SabadoDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SabadoDeE.Enabled = False
        Me.cmb_SabadoDeE.FormattingEnabled = True
        Me.cmb_SabadoDeE.Location = New System.Drawing.Point(107, 212)
        Me.cmb_SabadoDeE.MaxDropDownItems = 20
        Me.cmb_SabadoDeE.Name = "cmb_SabadoDeE"
        Me.cmb_SabadoDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_SabadoDeE.TabIndex = 118
        Me.cmb_SabadoDeE.ValueMember = "value"
        '
        'cmb_LunesAE
        '
        Me.cmb_LunesAE.Control_Siguiente = Nothing
        Me.cmb_LunesAE.DisplayMember = "display"
        Me.cmb_LunesAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesAE.Enabled = False
        Me.cmb_LunesAE.FormattingEnabled = True
        Me.cmb_LunesAE.Location = New System.Drawing.Point(187, 92)
        Me.cmb_LunesAE.MaxDropDownItems = 20
        Me.cmb_LunesAE.Name = "cmb_LunesAE"
        Me.cmb_LunesAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_LunesAE.TabIndex = 104
        Me.cmb_LunesAE.ValueMember = "value"
        '
        'cmb_LunesDeE
        '
        Me.cmb_LunesDeE.Control_Siguiente = Me.cmb_LunesAE
        Me.cmb_LunesDeE.DisplayMember = "display"
        Me.cmb_LunesDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LunesDeE.Enabled = False
        Me.cmb_LunesDeE.FormattingEnabled = True
        Me.cmb_LunesDeE.Location = New System.Drawing.Point(107, 92)
        Me.cmb_LunesDeE.MaxDropDownItems = 20
        Me.cmb_LunesDeE.Name = "cmb_LunesDeE"
        Me.cmb_LunesDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_LunesDeE.TabIndex = 103
        Me.cmb_LunesDeE.ValueMember = "value"
        '
        'cmb_ViernesAE
        '
        Me.cmb_ViernesAE.Control_Siguiente = Nothing
        Me.cmb_ViernesAE.DisplayMember = "display"
        Me.cmb_ViernesAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesAE.Enabled = False
        Me.cmb_ViernesAE.FormattingEnabled = True
        Me.cmb_ViernesAE.Location = New System.Drawing.Point(187, 188)
        Me.cmb_ViernesAE.MaxDropDownItems = 20
        Me.cmb_ViernesAE.Name = "cmb_ViernesAE"
        Me.cmb_ViernesAE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ViernesAE.TabIndex = 116
        Me.cmb_ViernesAE.ValueMember = "value"
        '
        'cmb_ViernesDeE
        '
        Me.cmb_ViernesDeE.Control_Siguiente = Me.cmb_ViernesAE
        Me.cmb_ViernesDeE.DisplayMember = "display"
        Me.cmb_ViernesDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViernesDeE.Enabled = False
        Me.cmb_ViernesDeE.FormattingEnabled = True
        Me.cmb_ViernesDeE.Location = New System.Drawing.Point(107, 188)
        Me.cmb_ViernesDeE.MaxDropDownItems = 20
        Me.cmb_ViernesDeE.Name = "cmb_ViernesDeE"
        Me.cmb_ViernesDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_ViernesDeE.TabIndex = 115
        Me.cmb_ViernesDeE.ValueMember = "value"
        '
        'lbl_MiercolesA
        '
        Me.lbl_MiercolesA.AutoSize = True
        Me.lbl_MiercolesA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MiercolesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MiercolesA.Location = New System.Drawing.Point(468, 141)
        Me.lbl_MiercolesA.Name = "lbl_MiercolesA"
        Me.lbl_MiercolesA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_MiercolesA.TabIndex = 108
        Me.lbl_MiercolesA.Text = "*"
        Me.lbl_MiercolesA.Visible = False
        '
        'cmb_MartesDeE
        '
        Me.cmb_MartesDeE.Control_Siguiente = Me.cmb_MartesAE
        Me.cmb_MartesDeE.DisplayMember = "display"
        Me.cmb_MartesDeE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MartesDeE.Enabled = False
        Me.cmb_MartesDeE.FormattingEnabled = True
        Me.cmb_MartesDeE.Location = New System.Drawing.Point(107, 116)
        Me.cmb_MartesDeE.MaxDropDownItems = 20
        Me.cmb_MartesDeE.Name = "cmb_MartesDeE"
        Me.cmb_MartesDeE.Size = New System.Drawing.Size(76, 21)
        Me.cmb_MartesDeE.TabIndex = 106
        Me.cmb_MartesDeE.ValueMember = "value"
        '
        'gbx_Cargo
        '
        Me.gbx_Cargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cargo.Controls.Add(Me.lbl_FacturarRE_A)
        Me.gbx_Cargo.Controls.Add(Me.cmb_CargoA)
        Me.gbx_Cargo.Controls.Add(Me.lbl_CargoAA)
        Me.gbx_Cargo.Controls.Add(Me.lbl_CargoA)
        Me.gbx_Cargo.Controls.Add(Me.lbl_FacturarRE)
        Me.gbx_Cargo.Controls.Add(Me.cmb_FacturarRE)
        Me.gbx_Cargo.Controls.Add(Me.chk_UnicaVez)
        Me.gbx_Cargo.Location = New System.Drawing.Point(6, 482)
        Me.gbx_Cargo.Name = "gbx_Cargo"
        Me.gbx_Cargo.Size = New System.Drawing.Size(853, 46)
        Me.gbx_Cargo.TabIndex = 3
        Me.gbx_Cargo.TabStop = False
        '
        'cmb_CargoA
        '
        Me.cmb_CargoA.Control_Siguiente = Nothing
        Me.cmb_CargoA.DisplayMember = "display"
        Me.cmb_CargoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CargoA.FormattingEnabled = True
        Me.cmb_CargoA.Location = New System.Drawing.Point(76, 15)
        Me.cmb_CargoA.MaxDropDownItems = 20
        Me.cmb_CargoA.Name = "cmb_CargoA"
        Me.cmb_CargoA.Size = New System.Drawing.Size(143, 21)
        Me.cmb_CargoA.TabIndex = 1
        Me.cmb_CargoA.ValueMember = "value"
        '
        'cmb_FacturarRE
        '
        Me.cmb_FacturarRE.Control_Siguiente = Nothing
        Me.cmb_FacturarRE.DisplayMember = "display"
        Me.cmb_FacturarRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FacturarRE.FormattingEnabled = True
        Me.cmb_FacturarRE.Location = New System.Drawing.Point(292, 15)
        Me.cmb_FacturarRE.MaxDropDownItems = 20
        Me.cmb_FacturarRE.Name = "cmb_FacturarRE"
        Me.cmb_FacturarRE.Size = New System.Drawing.Size(179, 21)
        Me.cmb_FacturarRE.TabIndex = 4
        Me.cmb_FacturarRE.ValueMember = "value"
        '
        'gbx_Subclientes
        '
        Me.gbx_Subclientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Subclientes.Controls.Add(Me.tab_Horarios)
        Me.gbx_Subclientes.Location = New System.Drawing.Point(6, 344)
        Me.gbx_Subclientes.Name = "gbx_Subclientes"
        Me.gbx_Subclientes.Size = New System.Drawing.Size(853, 140)
        Me.gbx_Subclientes.TabIndex = 4
        Me.gbx_Subclientes.TabStop = False
        '
        'tab_Horarios
        '
        Me.tab_Horarios.Controls.Add(Me.tab_Clientes)
        Me.tab_Horarios.Controls.Add(Me.tab_HorariosTemp)
        Me.tab_Horarios.Controls.Add(Me.tab_HorariosReal)
        Me.tab_Horarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Horarios.Location = New System.Drawing.Point(3, 16)
        Me.tab_Horarios.Name = "tab_Horarios"
        Me.tab_Horarios.SelectedIndex = 0
        Me.tab_Horarios.Size = New System.Drawing.Size(847, 121)
        Me.tab_Horarios.TabIndex = 2
        '
        'tab_Clientes
        '
        Me.tab_Clientes.Controls.Add(Me.lbl_Nota)
        Me.tab_Clientes.Controls.Add(Me.chk_Todos)
        Me.tab_Clientes.Controls.Add(Me.lsv_Clientes)
        Me.tab_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.tab_Clientes.Name = "tab_Clientes"
        Me.tab_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Clientes.Size = New System.Drawing.Size(839, 95)
        Me.tab_Clientes.TabIndex = 0
        Me.tab_Clientes.Text = "Clientes"
        Me.tab_Clientes.UseVisualStyleBackColor = True
        '
        'lbl_Nota
        '
        Me.lbl_Nota.AutoSize = True
        Me.lbl_Nota.Location = New System.Drawing.Point(71, 11)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Nota.TabIndex = 142
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_Todos.Location = New System.Drawing.Point(3, 10)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 1
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.CheckBoxes = True
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(3, 30)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 15
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 50
        Me.lsv_Clientes.Row3 = 0
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(833, 62)
        Me.lsv_Clientes.TabIndex = 0
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'tab_HorariosTemp
        '
        Me.tab_HorariosTemp.Controls.Add(Me.lsv_HorariosTemp)
        Me.tab_HorariosTemp.Location = New System.Drawing.Point(4, 22)
        Me.tab_HorariosTemp.Name = "tab_HorariosTemp"
        Me.tab_HorariosTemp.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_HorariosTemp.Size = New System.Drawing.Size(839, 53)
        Me.tab_HorariosTemp.TabIndex = 1
        Me.tab_HorariosTemp.Text = "Horarios Pendientes"
        Me.tab_HorariosTemp.UseVisualStyleBackColor = True
        '
        'lsv_HorariosTemp
        '
        Me.lsv_HorariosTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_HorariosTemp.FullRowSelect = True
        Me.lsv_HorariosTemp.HideSelection = False
        Me.lsv_HorariosTemp.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_HorariosTemp.Lvs = ListViewColumnSorter2
        Me.lsv_HorariosTemp.MultiSelect = False
        Me.lsv_HorariosTemp.Name = "lsv_HorariosTemp"
        Me.lsv_HorariosTemp.Row1 = 0
        Me.lsv_HorariosTemp.Row10 = 0
        Me.lsv_HorariosTemp.Row2 = 0
        Me.lsv_HorariosTemp.Row3 = 0
        Me.lsv_HorariosTemp.Row4 = 0
        Me.lsv_HorariosTemp.Row5 = 0
        Me.lsv_HorariosTemp.Row6 = 0
        Me.lsv_HorariosTemp.Row7 = 0
        Me.lsv_HorariosTemp.Row8 = 0
        Me.lsv_HorariosTemp.Row9 = 0
        Me.lsv_HorariosTemp.Size = New System.Drawing.Size(833, 47)
        Me.lsv_HorariosTemp.TabIndex = 1
        Me.lsv_HorariosTemp.UseCompatibleStateImageBehavior = False
        Me.lsv_HorariosTemp.View = System.Windows.Forms.View.Details
        '
        'tab_HorariosReal
        '
        Me.tab_HorariosReal.Controls.Add(Me.lsv_HorariosReal)
        Me.tab_HorariosReal.Location = New System.Drawing.Point(4, 22)
        Me.tab_HorariosReal.Name = "tab_HorariosReal"
        Me.tab_HorariosReal.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_HorariosReal.Size = New System.Drawing.Size(839, 53)
        Me.tab_HorariosReal.TabIndex = 2
        Me.tab_HorariosReal.Text = "Horarios Activos"
        Me.tab_HorariosReal.UseVisualStyleBackColor = True
        '
        'lsv_HorariosReal
        '
        Me.lsv_HorariosReal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_HorariosReal.FullRowSelect = True
        Me.lsv_HorariosReal.HideSelection = False
        Me.lsv_HorariosReal.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_HorariosReal.Lvs = ListViewColumnSorter3
        Me.lsv_HorariosReal.MultiSelect = False
        Me.lsv_HorariosReal.Name = "lsv_HorariosReal"
        Me.lsv_HorariosReal.Row1 = 0
        Me.lsv_HorariosReal.Row10 = 0
        Me.lsv_HorariosReal.Row2 = 0
        Me.lsv_HorariosReal.Row3 = 0
        Me.lsv_HorariosReal.Row4 = 0
        Me.lsv_HorariosReal.Row5 = 0
        Me.lsv_HorariosReal.Row6 = 0
        Me.lsv_HorariosReal.Row7 = 0
        Me.lsv_HorariosReal.Row8 = 0
        Me.lsv_HorariosReal.Row9 = 0
        Me.lsv_HorariosReal.Size = New System.Drawing.Size(833, 47)
        Me.lsv_HorariosReal.TabIndex = 1
        Me.lsv_HorariosReal.UseCompatibleStateImageBehavior = False
        Me.lsv_HorariosReal.View = System.Windows.Forms.View.Details
        '
        'lbl_DomingoFlecha
        '
        Me.lbl_DomingoFlecha.AutoSize = True
        Me.lbl_DomingoFlecha.Location = New System.Drawing.Point(365, 161)
        Me.lbl_DomingoFlecha.Name = "lbl_DomingoFlecha"
        Me.lbl_DomingoFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_DomingoFlecha.TabIndex = 90
        Me.lbl_DomingoFlecha.Text = "------>"
        Me.lbl_DomingoFlecha.Visible = False
        '
        'lbl_MartesFlecha
        '
        Me.lbl_MartesFlecha.AutoSize = True
        Me.lbl_MartesFlecha.Location = New System.Drawing.Point(365, 209)
        Me.lbl_MartesFlecha.Name = "lbl_MartesFlecha"
        Me.lbl_MartesFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_MartesFlecha.TabIndex = 91
        Me.lbl_MartesFlecha.Text = "------>"
        Me.lbl_MartesFlecha.Visible = False
        '
        'lbl_LunesFlecha
        '
        Me.lbl_LunesFlecha.AutoSize = True
        Me.lbl_LunesFlecha.Location = New System.Drawing.Point(365, 185)
        Me.lbl_LunesFlecha.Name = "lbl_LunesFlecha"
        Me.lbl_LunesFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_LunesFlecha.TabIndex = 92
        Me.lbl_LunesFlecha.Text = "------>"
        Me.lbl_LunesFlecha.Visible = False
        '
        'lbl_MiercolesFlecha
        '
        Me.lbl_MiercolesFlecha.AutoSize = True
        Me.lbl_MiercolesFlecha.Location = New System.Drawing.Point(365, 233)
        Me.lbl_MiercolesFlecha.Name = "lbl_MiercolesFlecha"
        Me.lbl_MiercolesFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_MiercolesFlecha.TabIndex = 93
        Me.lbl_MiercolesFlecha.Text = "------>"
        Me.lbl_MiercolesFlecha.Visible = False
        '
        'lbl_JuevesFlecha
        '
        Me.lbl_JuevesFlecha.AutoSize = True
        Me.lbl_JuevesFlecha.Location = New System.Drawing.Point(365, 257)
        Me.lbl_JuevesFlecha.Name = "lbl_JuevesFlecha"
        Me.lbl_JuevesFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_JuevesFlecha.TabIndex = 94
        Me.lbl_JuevesFlecha.Text = "------>"
        Me.lbl_JuevesFlecha.Visible = False
        '
        'lbl_SabadoFlecha
        '
        Me.lbl_SabadoFlecha.AutoSize = True
        Me.lbl_SabadoFlecha.Location = New System.Drawing.Point(365, 305)
        Me.lbl_SabadoFlecha.Name = "lbl_SabadoFlecha"
        Me.lbl_SabadoFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_SabadoFlecha.TabIndex = 95
        Me.lbl_SabadoFlecha.Text = "------>"
        Me.lbl_SabadoFlecha.Visible = False
        '
        'lbl_ResultasFlecha
        '
        Me.lbl_ResultasFlecha.AutoSize = True
        Me.lbl_ResultasFlecha.Location = New System.Drawing.Point(365, 328)
        Me.lbl_ResultasFlecha.Name = "lbl_ResultasFlecha"
        Me.lbl_ResultasFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_ResultasFlecha.TabIndex = 96
        Me.lbl_ResultasFlecha.Text = "------>"
        Me.lbl_ResultasFlecha.Visible = False
        '
        'lbl_ViernesFlecha
        '
        Me.lbl_ViernesFlecha.AutoSize = True
        Me.lbl_ViernesFlecha.Location = New System.Drawing.Point(365, 281)
        Me.lbl_ViernesFlecha.Name = "lbl_ViernesFlecha"
        Me.lbl_ViernesFlecha.Size = New System.Drawing.Size(31, 13)
        Me.lbl_ViernesFlecha.TabIndex = 97
        Me.lbl_ViernesFlecha.Text = "------>"
        Me.lbl_ViernesFlecha.Visible = False
        '
        'gbx_RecoEntrega
        '
        Me.gbx_RecoEntrega.Controls.Add(Me.btn_Ayuda)
        Me.gbx_RecoEntrega.Controls.Add(Me.rdb_Destino)
        Me.gbx_RecoEntrega.Controls.Add(Me.rdb_Origen)
        Me.gbx_RecoEntrega.Controls.Add(Me.lbl_H_Cliente)
        Me.gbx_RecoEntrega.Controls.Add(Me.tbx_H_Cliente)
        Me.gbx_RecoEntrega.Controls.Add(Me.btn_H_Buscar)
        Me.gbx_RecoEntrega.Controls.Add(Me.btn_Agregar)
        Me.gbx_RecoEntrega.Controls.Add(Me.cmb_H_Cliente)
        Me.gbx_RecoEntrega.Controls.Add(Me.lbl_H_ClienteA)
        Me.gbx_RecoEntrega.Location = New System.Drawing.Point(6, 2)
        Me.gbx_RecoEntrega.Name = "gbx_RecoEntrega"
        Me.gbx_RecoEntrega.Size = New System.Drawing.Size(854, 69)
        Me.gbx_RecoEntrega.TabIndex = 98
        Me.gbx_RecoEntrega.TabStop = False
        Me.gbx_RecoEntrega.Text = "Datos Cliente"
        '
        'rdb_Destino
        '
        Me.rdb_Destino.AutoSize = True
        Me.rdb_Destino.Location = New System.Drawing.Point(13, 42)
        Me.rdb_Destino.Name = "rdb_Destino"
        Me.rdb_Destino.Size = New System.Drawing.Size(61, 17)
        Me.rdb_Destino.TabIndex = 1
        Me.rdb_Destino.Text = "Destino"
        Me.rdb_Destino.UseVisualStyleBackColor = True
        '
        'rdb_Origen
        '
        Me.rdb_Origen.AutoSize = True
        Me.rdb_Origen.Location = New System.Drawing.Point(13, 20)
        Me.rdb_Origen.Name = "rdb_Origen"
        Me.rdb_Origen.Size = New System.Drawing.Size(56, 17)
        Me.rdb_Origen.TabIndex = 0
        Me.rdb_Origen.Text = "Origen"
        Me.rdb_Origen.UseVisualStyleBackColor = True
        '
        'tbx_H_Cliente
        '
        Me.tbx_H_Cliente.Control_Siguiente = Me.cmb_H_Cliente
        Me.tbx_H_Cliente.Filtrado = True
        Me.tbx_H_Cliente.Location = New System.Drawing.Point(132, 32)
        Me.tbx_H_Cliente.MaxLength = 20
        Me.tbx_H_Cliente.Name = "tbx_H_Cliente"
        Me.tbx_H_Cliente.Size = New System.Drawing.Size(77, 20)
        Me.tbx_H_Cliente.TabIndex = 15
        Me.tbx_H_Cliente.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_H_Cliente
        '
        Me.cmb_H_Cliente.Clave = "Clave_Cliente"
        Me.cmb_H_Cliente.Control_Siguiente = Nothing
        Me.cmb_H_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_H_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_H_Cliente.Empresa = False
        Me.cmb_H_Cliente.Filtro = Me.tbx_H_Cliente
        Me.cmb_H_Cliente.FormattingEnabled = True
        Me.cmb_H_Cliente.Location = New System.Drawing.Point(215, 32)
        Me.cmb_H_Cliente.MaxDropDownItems = 20
        Me.cmb_H_Cliente.Name = "cmb_H_Cliente"
        Me.cmb_H_Cliente.Pista = False
        Me.cmb_H_Cliente.Size = New System.Drawing.Size(355, 21)
        Me.cmb_H_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_H_Cliente.Sucursal = True
        Me.cmb_H_Cliente.TabIndex = 16
        Me.cmb_H_Cliente.Tipo = 0
        Me.cmb_H_Cliente.ValueMember = "Id_Cliente"
        '
        'frm_ClientesHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_CancelarH
        Me.ClientSize = New System.Drawing.Size(864, 582)
        Me.Controls.Add(Me.gbx_RecoEntrega)
        Me.Controls.Add(Me.lbl_ViernesFlecha)
        Me.Controls.Add(Me.lbl_ResultasFlecha)
        Me.Controls.Add(Me.lbl_SabadoFlecha)
        Me.Controls.Add(Me.lbl_JuevesFlecha)
        Me.Controls.Add(Me.lbl_MiercolesFlecha)
        Me.Controls.Add(Me.lbl_LunesFlecha)
        Me.Controls.Add(Me.lbl_MartesFlecha)
        Me.Controls.Add(Me.lbl_DomingoFlecha)
        Me.Controls.Add(Me.gbx_Subclientes)
        Me.Controls.Add(Me.gbx_Cargo)
        Me.Controls.Add(Me.gbx_Entrega)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Recoleccion)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(880, 620)
        Me.Name = "frm_ClientesHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios de Traslado"
        Me.gbx_Recoleccion.ResumeLayout(False)
        Me.gbx_Recoleccion.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Entrega.ResumeLayout(False)
        Me.gbx_Entrega.PerformLayout()
        Me.gbx_Cargo.ResumeLayout(False)
        Me.gbx_Cargo.PerformLayout()
        Me.gbx_Subclientes.ResumeLayout(False)
        Me.tab_Horarios.ResumeLayout(False)
        Me.tab_Clientes.ResumeLayout(False)
        Me.tab_Clientes.PerformLayout()
        Me.tab_HorariosTemp.ResumeLayout(False)
        Me.tab_HorariosReal.ResumeLayout(False)
        Me.gbx_RecoEntrega.ResumeLayout(False)
        Me.gbx_RecoEntrega.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_Recoleccion As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_GuardarH As System.Windows.Forms.Button
    Friend WithEvents cmb_H_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_H_Cliente As Modulo_Ventas.cp_Textbox
    Friend WithEvents Btn_CancelarH As System.Windows.Forms.Button
    Friend WithEvents cmb_H_TipoF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents dtp_H_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_H_TipoF As System.Windows.Forms.Label
    Friend WithEvents btn_H_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_H_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_H_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents lbl_H_Boveda As System.Windows.Forms.Label
    Friend WithEvents cmb_DomingoEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_CargoA As System.Windows.Forms.Label
    Friend WithEvents cmb_CargoA As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_FacturarRE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_FacturarRE As System.Windows.Forms.Label
    Friend WithEvents chk_UnicaVez As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_FacturarRE_A As System.Windows.Forms.Label
    Friend WithEvents lbl_CargoAA As System.Windows.Forms.Label
    Friend WithEvents lbl_H_ClienteA As System.Windows.Forms.Label
    Friend WithEvents lbl_H_FechaInicioA As System.Windows.Forms.Label
    Friend WithEvents lbl_H_TipoFA As System.Windows.Forms.Label
    Friend WithEvents gbx_Entrega As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Cargo As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Subclientes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Ayuda As System.Windows.Forms.Button
    Friend WithEvents cmb_ResultasAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ResultasDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_SabadoAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_SabadoDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ViernesAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ViernesDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_JuevesAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_DomingoF As System.Windows.Forms.CheckBox
    Friend WithEvents chk_LunesF As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_JuevesDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_MartesF As System.Windows.Forms.CheckBox
    Friend WithEvents chk_MiercolesF As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_DeF As System.Windows.Forms.Label
    Friend WithEvents cmb_DomingoAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MiercolesAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_JuevesF As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_MiercolesDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_DomingoDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_AF As System.Windows.Forms.Label
    Friend WithEvents chk_ViernesF As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SabadoF As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_MartesAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_ResultasF As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_LunesDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_LunesAF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MartesDeF As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_DomingoE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_DeD As System.Windows.Forms.Label
    Friend WithEvents lbl_ResultasA As System.Windows.Forms.Label
    Friend WithEvents lbl_DomingoA As System.Windows.Forms.Label
    Friend WithEvents lbl_LunesA As System.Windows.Forms.Label
    Friend WithEvents cmb_JuevesDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_JuevesAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_ViernesA As System.Windows.Forms.Label
    Friend WithEvents cmb_LunesAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ViernesAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_MiercolesA As System.Windows.Forms.Label
    Friend WithEvents cmb_MartesDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MartesAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ResultasAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ViernesDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_LunesDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_SabadoDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_SabadoAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_DomingoAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_JuevesA As System.Windows.Forms.Label
    Friend WithEvents cmb_MiercolesAE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ResultasDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MiercolesDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_DomingoDeE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_AD As System.Windows.Forms.Label
    Friend WithEvents lbl_MartesA As System.Windows.Forms.Label
    Friend WithEvents lbl_SabadoA As System.Windows.Forms.Label
    Friend WithEvents cmb_ResultasE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_SabadoE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ViernesE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_JuevesE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MiercolesE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MartesE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_LunesE As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Frecuencia As System.Windows.Forms.Label
    Friend WithEvents cmb_ResultasEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_SabadoEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_ViernesEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_JuevesEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MiercolesEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_MartesEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_LunesEsc As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Dia As System.Windows.Forms.Label
    Friend WithEvents lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_DomingoFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_MartesFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_LunesFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_MiercolesFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_JuevesFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_SabadoFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_ResultasFlecha As System.Windows.Forms.Label
    Friend WithEvents lbl_ViernesFlecha As System.Windows.Forms.Label
    Friend WithEvents cmb_DomingoRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_RutaF As System.Windows.Forms.Label
    Friend WithEvents cmb_DomingoRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_RutaD As System.Windows.Forms.Label
    Friend WithEvents cmb_ResultasRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_SabadoRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ViernesRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_JuevesRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_MiercolesRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_MartesRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_LunesRutaF As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ResultasRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_SabadoRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ViernesRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_JuevesRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_MiercolesRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_MartesRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_LunesRutaE As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents tab_Horarios As System.Windows.Forms.TabControl
    Friend WithEvents tab_Clientes As System.Windows.Forms.TabPage
    Friend WithEvents tab_HorariosTemp As System.Windows.Forms.TabPage
    Friend WithEvents lsv_HorariosTemp As Modulo_Ventas.cp_Listview
    Friend WithEvents tab_HorariosReal As System.Windows.Forms.TabPage
    Friend WithEvents lsv_HorariosReal As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_RecoEntrega As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Destino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Origen As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
End Class
