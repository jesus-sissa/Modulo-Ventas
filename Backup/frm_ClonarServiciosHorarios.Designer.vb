<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClonarServiciosHorarios
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
        Dim ListViewColumnSorter3 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClonarServiciosHorarios))
        Me.lbl_ClientePadre = New System.Windows.Forms.Label
        Me.gbx_ListaServiciosOtros = New System.Windows.Forms.GroupBox
        Me.chk_ServiciosOtros = New System.Windows.Forms.CheckBox
        Me.lsv_ServiciosOtros = New Modulo_Ventas.cp_Listview
        Me.lbl_ServiciosOtros = New System.Windows.Forms.Label
        Me.btn_ClonarServicios = New System.Windows.Forms.Button
        Me.dtp_FechaInicioServicio = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaInicioServicio = New System.Windows.Forms.Label
        Me.gbx_ServiciosTV = New System.Windows.Forms.GroupBox
        Me.lsv_ServiciosTV = New Modulo_Ventas.cp_Listview
        Me.lbl_ServiciosTV = New System.Windows.Forms.Label
        Me.btn_ClonarServiciosHorarios = New System.Windows.Forms.Button
        Me.gbx_Horarios = New System.Windows.Forms.GroupBox
        Me.lsv_HorariosActivos = New Modulo_Ventas.cp_Listview
        Me.chk_HorariosServicios = New System.Windows.Forms.CheckBox
        Me.lbl_Horarios = New System.Windows.Forms.Label
        Me.tab_ClonarServiciosHorarios = New System.Windows.Forms.TabControl
        Me.tab_ServiciosOtros = New System.Windows.Forms.TabPage
        Me.tab_ServiciosHorarios = New System.Windows.Forms.TabPage
        Me.tab_Subclientes = New System.Windows.Forms.TabPage
        Me.gbx_Subclientes = New System.Windows.Forms.GroupBox
        Me.chk_Subclientes = New System.Windows.Forms.CheckBox
        Me.lbl_Subclientes = New System.Windows.Forms.Label
        Me.lsv_Subclientes = New Modulo_Ventas.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_TipoServicio = New System.Windows.Forms.Label
        Me.cmb_TipoServicio = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_ClientePadre = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_SeleccioneCP = New Modulo_Ventas.cp_Textbox
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.gbx_ListaServiciosOtros.SuspendLayout()
        Me.gbx_ServiciosTV.SuspendLayout()
        Me.gbx_Horarios.SuspendLayout()
        Me.tab_ClonarServiciosHorarios.SuspendLayout()
        Me.tab_ServiciosOtros.SuspendLayout()
        Me.tab_ServiciosHorarios.SuspendLayout()
        Me.tab_Subclientes.SuspendLayout()
        Me.gbx_Subclientes.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_ClientePadre
        '
        Me.lbl_ClientePadre.AutoSize = True
        Me.lbl_ClientePadre.Location = New System.Drawing.Point(28, 18)
        Me.lbl_ClientePadre.Name = "lbl_ClientePadre"
        Me.lbl_ClientePadre.Size = New System.Drawing.Size(70, 13)
        Me.lbl_ClientePadre.TabIndex = 0
        Me.lbl_ClientePadre.Text = "Cliente Padre"
        '
        'gbx_ListaServiciosOtros
        '
        Me.gbx_ListaServiciosOtros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ListaServiciosOtros.Controls.Add(Me.chk_ServiciosOtros)
        Me.gbx_ListaServiciosOtros.Controls.Add(Me.lsv_ServiciosOtros)
        Me.gbx_ListaServiciosOtros.Controls.Add(Me.lbl_ServiciosOtros)
        Me.gbx_ListaServiciosOtros.Location = New System.Drawing.Point(6, 6)
        Me.gbx_ListaServiciosOtros.Name = "gbx_ListaServiciosOtros"
        Me.gbx_ListaServiciosOtros.Size = New System.Drawing.Size(756, 389)
        Me.gbx_ListaServiciosOtros.TabIndex = 0
        Me.gbx_ListaServiciosOtros.TabStop = False
        Me.gbx_ListaServiciosOtros.Text = "Servicios Otros"
        '
        'chk_ServiciosOtros
        '
        Me.chk_ServiciosOtros.AutoSize = True
        Me.chk_ServiciosOtros.Location = New System.Drawing.Point(7, 16)
        Me.chk_ServiciosOtros.Name = "chk_ServiciosOtros"
        Me.chk_ServiciosOtros.Size = New System.Drawing.Size(56, 17)
        Me.chk_ServiciosOtros.TabIndex = 0
        Me.chk_ServiciosOtros.Text = "Todos"
        Me.chk_ServiciosOtros.UseVisualStyleBackColor = True
        '
        'lsv_ServiciosOtros
        '
        Me.lsv_ServiciosOtros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ServiciosOtros.CheckBoxes = True
        Me.lsv_ServiciosOtros.FullRowSelect = True
        Me.lsv_ServiciosOtros.HideSelection = False
        Me.lsv_ServiciosOtros.Location = New System.Drawing.Point(7, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ServiciosOtros.Lvs = ListViewColumnSorter1
        Me.lsv_ServiciosOtros.MultiSelect = False
        Me.lsv_ServiciosOtros.Name = "lsv_ServiciosOtros"
        Me.lsv_ServiciosOtros.Row1 = 11
        Me.lsv_ServiciosOtros.Row10 = 0
        Me.lsv_ServiciosOtros.Row2 = 8
        Me.lsv_ServiciosOtros.Row3 = 9
        Me.lsv_ServiciosOtros.Row4 = 8
        Me.lsv_ServiciosOtros.Row5 = 50
        Me.lsv_ServiciosOtros.Row6 = 0
        Me.lsv_ServiciosOtros.Row7 = 0
        Me.lsv_ServiciosOtros.Row8 = 0
        Me.lsv_ServiciosOtros.Row9 = 0
        Me.lsv_ServiciosOtros.Size = New System.Drawing.Size(744, 346)
        Me.lsv_ServiciosOtros.TabIndex = 2
        Me.lsv_ServiciosOtros.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosOtros.View = System.Windows.Forms.View.Details
        '
        'lbl_ServiciosOtros
        '
        Me.lbl_ServiciosOtros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ServiciosOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServiciosOtros.Location = New System.Drawing.Point(626, 9)
        Me.lbl_ServiciosOtros.Name = "lbl_ServiciosOtros"
        Me.lbl_ServiciosOtros.Size = New System.Drawing.Size(125, 22)
        Me.lbl_ServiciosOtros.TabIndex = 1
        Me.lbl_ServiciosOtros.Text = "Registros: 0"
        Me.lbl_ServiciosOtros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_ClonarServicios
        '
        Me.btn_ClonarServicios.Enabled = False
        Me.btn_ClonarServicios.Image = Global.Modulo_Ventas.My.Resources.Resources.clonar_serv
        Me.btn_ClonarServicios.Location = New System.Drawing.Point(6, 14)
        Me.btn_ClonarServicios.Name = "btn_ClonarServicios"
        Me.btn_ClonarServicios.Size = New System.Drawing.Size(140, 30)
        Me.btn_ClonarServicios.TabIndex = 0
        Me.btn_ClonarServicios.Text = "Clonar Servicios"
        Me.btn_ClonarServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ClonarServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ClonarServicios.UseVisualStyleBackColor = True
        '
        'dtp_FechaInicioServicio
        '
        Me.dtp_FechaInicioServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicioServicio.Location = New System.Drawing.Point(162, 11)
        Me.dtp_FechaInicioServicio.Name = "dtp_FechaInicioServicio"
        Me.dtp_FechaInicioServicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaInicioServicio.TabIndex = 2
        '
        'lbl_FechaInicioServicio
        '
        Me.lbl_FechaInicioServicio.AutoSize = True
        Me.lbl_FechaInicioServicio.Location = New System.Drawing.Point(82, 14)
        Me.lbl_FechaInicioServicio.Name = "lbl_FechaInicioServicio"
        Me.lbl_FechaInicioServicio.Size = New System.Drawing.Size(80, 13)
        Me.lbl_FechaInicioServicio.TabIndex = 1
        Me.lbl_FechaInicioServicio.Text = "Fecha de Inicio"
        '
        'gbx_ServiciosTV
        '
        Me.gbx_ServiciosTV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ServiciosTV.Controls.Add(Me.lsv_ServiciosTV)
        Me.gbx_ServiciosTV.Controls.Add(Me.lbl_ServiciosTV)
        Me.gbx_ServiciosTV.Location = New System.Drawing.Point(6, 6)
        Me.gbx_ServiciosTV.Name = "gbx_ServiciosTV"
        Me.gbx_ServiciosTV.Size = New System.Drawing.Size(906, 164)
        Me.gbx_ServiciosTV.TabIndex = 1
        Me.gbx_ServiciosTV.TabStop = False
        Me.gbx_ServiciosTV.Text = "Servicios TV"
        '
        'lsv_ServiciosTV
        '
        Me.lsv_ServiciosTV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ServiciosTV.FullRowSelect = True
        Me.lsv_ServiciosTV.HideSelection = False
        Me.lsv_ServiciosTV.Location = New System.Drawing.Point(7, 36)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ServiciosTV.Lvs = ListViewColumnSorter2
        Me.lsv_ServiciosTV.MultiSelect = False
        Me.lsv_ServiciosTV.Name = "lsv_ServiciosTV"
        Me.lsv_ServiciosTV.Row1 = 11
        Me.lsv_ServiciosTV.Row10 = 8
        Me.lsv_ServiciosTV.Row2 = 8
        Me.lsv_ServiciosTV.Row3 = 8
        Me.lsv_ServiciosTV.Row4 = 8
        Me.lsv_ServiciosTV.Row5 = 20
        Me.lsv_ServiciosTV.Row6 = 8
        Me.lsv_ServiciosTV.Row7 = 8
        Me.lsv_ServiciosTV.Row8 = 0
        Me.lsv_ServiciosTV.Row9 = 0
        Me.lsv_ServiciosTV.Size = New System.Drawing.Size(893, 122)
        Me.lsv_ServiciosTV.TabIndex = 1
        Me.lsv_ServiciosTV.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosTV.View = System.Windows.Forms.View.Details
        '
        'lbl_ServiciosTV
        '
        Me.lbl_ServiciosTV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ServiciosTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServiciosTV.Location = New System.Drawing.Point(776, 10)
        Me.lbl_ServiciosTV.Name = "lbl_ServiciosTV"
        Me.lbl_ServiciosTV.Size = New System.Drawing.Size(125, 23)
        Me.lbl_ServiciosTV.TabIndex = 0
        Me.lbl_ServiciosTV.Text = "Registros: 0"
        Me.lbl_ServiciosTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_ClonarServiciosHorarios
        '
        Me.btn_ClonarServiciosHorarios.Enabled = False
        Me.btn_ClonarServiciosHorarios.Image = Global.Modulo_Ventas.My.Resources.Resources.clonar_serv
        Me.btn_ClonarServiciosHorarios.Location = New System.Drawing.Point(159, 14)
        Me.btn_ClonarServiciosHorarios.Name = "btn_ClonarServiciosHorarios"
        Me.btn_ClonarServiciosHorarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_ClonarServiciosHorarios.TabIndex = 1
        Me.btn_ClonarServiciosHorarios.Text = "Clonar Serv-Horarios"
        Me.btn_ClonarServiciosHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ClonarServiciosHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ClonarServiciosHorarios.UseVisualStyleBackColor = True
        '
        'gbx_Horarios
        '
        Me.gbx_Horarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Horarios.Controls.Add(Me.lsv_HorariosActivos)
        Me.gbx_Horarios.Controls.Add(Me.chk_HorariosServicios)
        Me.gbx_Horarios.Controls.Add(Me.lbl_Horarios)
        Me.gbx_Horarios.Location = New System.Drawing.Point(6, 176)
        Me.gbx_Horarios.Name = "gbx_Horarios"
        Me.gbx_Horarios.Size = New System.Drawing.Size(906, 286)
        Me.gbx_Horarios.TabIndex = 0
        Me.gbx_Horarios.TabStop = False
        Me.gbx_Horarios.Text = "Horarios Activos"
        '
        'lsv_HorariosActivos
        '
        Me.lsv_HorariosActivos.AllowColumnReorder = True
        Me.lsv_HorariosActivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_HorariosActivos.CheckBoxes = True
        Me.lsv_HorariosActivos.FullRowSelect = True
        Me.lsv_HorariosActivos.HideSelection = False
        Me.lsv_HorariosActivos.Location = New System.Drawing.Point(7, 39)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_HorariosActivos.Lvs = ListViewColumnSorter3
        Me.lsv_HorariosActivos.MultiSelect = False
        Me.lsv_HorariosActivos.Name = "lsv_HorariosActivos"
        Me.lsv_HorariosActivos.Row1 = 8
        Me.lsv_HorariosActivos.Row10 = 0
        Me.lsv_HorariosActivos.Row2 = 8
        Me.lsv_HorariosActivos.Row3 = 8
        Me.lsv_HorariosActivos.Row4 = 25
        Me.lsv_HorariosActivos.Row5 = 8
        Me.lsv_HorariosActivos.Row6 = 20
        Me.lsv_HorariosActivos.Row7 = 7
        Me.lsv_HorariosActivos.Row8 = 7
        Me.lsv_HorariosActivos.Row9 = 7
        Me.lsv_HorariosActivos.Size = New System.Drawing.Size(893, 241)
        Me.lsv_HorariosActivos.TabIndex = 2
        Me.lsv_HorariosActivos.UseCompatibleStateImageBehavior = False
        Me.lsv_HorariosActivos.View = System.Windows.Forms.View.Details
        '
        'chk_HorariosServicios
        '
        Me.chk_HorariosServicios.AutoSize = True
        Me.chk_HorariosServicios.Location = New System.Drawing.Point(7, 16)
        Me.chk_HorariosServicios.Name = "chk_HorariosServicios"
        Me.chk_HorariosServicios.Size = New System.Drawing.Size(56, 17)
        Me.chk_HorariosServicios.TabIndex = 0
        Me.chk_HorariosServicios.Text = "Todos"
        Me.chk_HorariosServicios.UseVisualStyleBackColor = True
        '
        'lbl_Horarios
        '
        Me.lbl_Horarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Horarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Horarios.Location = New System.Drawing.Point(775, 11)
        Me.lbl_Horarios.Name = "lbl_Horarios"
        Me.lbl_Horarios.Size = New System.Drawing.Size(125, 23)
        Me.lbl_Horarios.TabIndex = 1
        Me.lbl_Horarios.Text = "Registros: 0"
        Me.lbl_Horarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tab_ClonarServiciosHorarios
        '
        Me.tab_ClonarServiciosHorarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_ClonarServiciosHorarios.Controls.Add(Me.tab_ServiciosOtros)
        Me.tab_ClonarServiciosHorarios.Controls.Add(Me.tab_ServiciosHorarios)
        Me.tab_ClonarServiciosHorarios.Controls.Add(Me.tab_Subclientes)
        Me.tab_ClonarServiciosHorarios.Location = New System.Drawing.Point(4, 78)
        Me.tab_ClonarServiciosHorarios.Name = "tab_ClonarServiciosHorarios"
        Me.tab_ClonarServiciosHorarios.SelectedIndex = 0
        Me.tab_ClonarServiciosHorarios.Size = New System.Drawing.Size(776, 427)
        Me.tab_ClonarServiciosHorarios.TabIndex = 3
        '
        'tab_ServiciosOtros
        '
        Me.tab_ServiciosOtros.Controls.Add(Me.gbx_ListaServiciosOtros)
        Me.tab_ServiciosOtros.Location = New System.Drawing.Point(4, 22)
        Me.tab_ServiciosOtros.Name = "tab_ServiciosOtros"
        Me.tab_ServiciosOtros.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ServiciosOtros.Size = New System.Drawing.Size(768, 401)
        Me.tab_ServiciosOtros.TabIndex = 0
        Me.tab_ServiciosOtros.Text = "ServiciosOtros"
        Me.tab_ServiciosOtros.UseVisualStyleBackColor = True
        '
        'tab_ServiciosHorarios
        '
        Me.tab_ServiciosHorarios.Controls.Add(Me.gbx_ServiciosTV)
        Me.tab_ServiciosHorarios.Controls.Add(Me.gbx_Horarios)
        Me.tab_ServiciosHorarios.Location = New System.Drawing.Point(4, 22)
        Me.tab_ServiciosHorarios.Name = "tab_ServiciosHorarios"
        Me.tab_ServiciosHorarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ServiciosHorarios.Size = New System.Drawing.Size(922, 465)
        Me.tab_ServiciosHorarios.TabIndex = 1
        Me.tab_ServiciosHorarios.Text = "ServiciosTv-Horarios"
        Me.tab_ServiciosHorarios.UseVisualStyleBackColor = True
        '
        'tab_Subclientes
        '
        Me.tab_Subclientes.Controls.Add(Me.gbx_Subclientes)
        Me.tab_Subclientes.Location = New System.Drawing.Point(4, 22)
        Me.tab_Subclientes.Name = "tab_Subclientes"
        Me.tab_Subclientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Subclientes.Size = New System.Drawing.Size(922, 465)
        Me.tab_Subclientes.TabIndex = 2
        Me.tab_Subclientes.Text = "Subclientes"
        Me.tab_Subclientes.UseVisualStyleBackColor = True
        '
        'gbx_Subclientes
        '
        Me.gbx_Subclientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Subclientes.Controls.Add(Me.chk_Subclientes)
        Me.gbx_Subclientes.Controls.Add(Me.lbl_Subclientes)
        Me.gbx_Subclientes.Controls.Add(Me.lsv_Subclientes)
        Me.gbx_Subclientes.Controls.Add(Me.dtp_FechaInicioServicio)
        Me.gbx_Subclientes.Controls.Add(Me.lbl_FechaInicioServicio)
        Me.gbx_Subclientes.Location = New System.Drawing.Point(3, 6)
        Me.gbx_Subclientes.Name = "gbx_Subclientes"
        Me.gbx_Subclientes.Size = New System.Drawing.Size(910, 453)
        Me.gbx_Subclientes.TabIndex = 0
        Me.gbx_Subclientes.TabStop = False
        Me.gbx_Subclientes.Text = "Subclientes"
        '
        'chk_Subclientes
        '
        Me.chk_Subclientes.AutoSize = True
        Me.chk_Subclientes.Location = New System.Drawing.Point(9, 15)
        Me.chk_Subclientes.Name = "chk_Subclientes"
        Me.chk_Subclientes.Size = New System.Drawing.Size(56, 17)
        Me.chk_Subclientes.TabIndex = 0
        Me.chk_Subclientes.Text = "Todos"
        Me.chk_Subclientes.UseVisualStyleBackColor = True
        '
        'lbl_Subclientes
        '
        Me.lbl_Subclientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Subclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subclientes.Location = New System.Drawing.Point(779, 10)
        Me.lbl_Subclientes.Name = "lbl_Subclientes"
        Me.lbl_Subclientes.Size = New System.Drawing.Size(125, 23)
        Me.lbl_Subclientes.TabIndex = 3
        Me.lbl_Subclientes.Text = "Registros: 0"
        Me.lbl_Subclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Subclientes
        '
        Me.lsv_Subclientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Subclientes.CheckBoxes = True
        Me.lsv_Subclientes.FullRowSelect = True
        Me.lsv_Subclientes.HideSelection = False
        Me.lsv_Subclientes.Location = New System.Drawing.Point(9, 36)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Subclientes.Lvs = ListViewColumnSorter4
        Me.lsv_Subclientes.MultiSelect = False
        Me.lsv_Subclientes.Name = "lsv_Subclientes"
        Me.lsv_Subclientes.Row1 = 10
        Me.lsv_Subclientes.Row10 = 0
        Me.lsv_Subclientes.Row2 = 80
        Me.lsv_Subclientes.Row3 = 0
        Me.lsv_Subclientes.Row4 = 0
        Me.lsv_Subclientes.Row5 = 0
        Me.lsv_Subclientes.Row6 = 0
        Me.lsv_Subclientes.Row7 = 0
        Me.lsv_Subclientes.Row8 = 0
        Me.lsv_Subclientes.Row9 = 0
        Me.lsv_Subclientes.Size = New System.Drawing.Size(895, 411)
        Me.lsv_Subclientes.TabIndex = 4
        Me.lsv_Subclientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Subclientes.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_ClonarServiciosHorarios)
        Me.gbx_Botones.Controls.Add(Me.btn_ClonarServicios)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 507)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(776, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 14)
        Me.btn_Cerrar.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_TipoServicio
        '
        Me.lbl_TipoServicio.AutoSize = True
        Me.lbl_TipoServicio.Location = New System.Drawing.Point(59, 44)
        Me.lbl_TipoServicio.Name = "lbl_TipoServicio"
        Me.lbl_TipoServicio.Size = New System.Drawing.Size(104, 13)
        Me.lbl_TipoServicio.TabIndex = 4
        Me.lbl_TipoServicio.Text = "¿Que desea Clonar?"
        '
        'cmb_TipoServicio
        '
        Me.cmb_TipoServicio.Control_Siguiente = Nothing
        Me.cmb_TipoServicio.DisplayMember = "display"
        Me.cmb_TipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoServicio.FormattingEnabled = True
        Me.cmb_TipoServicio.Location = New System.Drawing.Point(169, 41)
        Me.cmb_TipoServicio.MaxDropDownItems = 20
        Me.cmb_TipoServicio.Name = "cmb_TipoServicio"
        Me.cmb_TipoServicio.Size = New System.Drawing.Size(156, 21)
        Me.cmb_TipoServicio.TabIndex = 5
        Me.cmb_TipoServicio.ValueMember = "value"
        '
        'cmb_ClientePadre
        '
        Me.cmb_ClientePadre.Clave = "Clave_Cliente"
        Me.cmb_ClientePadre.Control_Siguiente = Nothing
        Me.cmb_ClientePadre.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClientePadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClientePadre.Empresa = False
        Me.cmb_ClientePadre.Filtro = Me.tbx_SeleccioneCP
        Me.cmb_ClientePadre.FormattingEnabled = True
        Me.cmb_ClientePadre.Location = New System.Drawing.Point(169, 14)
        Me.cmb_ClientePadre.MaxDropDownItems = 20
        Me.cmb_ClientePadre.Name = "cmb_ClientePadre"
        Me.cmb_ClientePadre.Pista = False
        Me.cmb_ClientePadre.Size = New System.Drawing.Size(400, 21)
        Me.cmb_ClientePadre.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_ClientePadre.Sucursal = True
        Me.cmb_ClientePadre.TabIndex = 2
        Me.cmb_ClientePadre.TabStop = False
        Me.cmb_ClientePadre.Tipo = 0
        Me.cmb_ClientePadre.ValueMember = "Id_Cliente"
        '
        'tbx_SeleccioneCP
        '
        Me.tbx_SeleccioneCP.Control_Siguiente = Me.cmb_ClientePadre
        Me.tbx_SeleccioneCP.Filtrado = True
        Me.tbx_SeleccioneCP.Location = New System.Drawing.Point(102, 15)
        Me.tbx_SeleccioneCP.MaxLength = 12
        Me.tbx_SeleccioneCP.Name = "tbx_SeleccioneCP"
        Me.tbx_SeleccioneCP.Size = New System.Drawing.Size(61, 20)
        Me.tbx_SeleccioneCP.TabIndex = 1
        Me.tbx_SeleccioneCP.TabStop = False
        Me.tbx_SeleccioneCP.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.tbx_SeleccioneCP)
        Me.gbx_Filtro.Controls.Add(Me.cmb_TipoServicio)
        Me.gbx_Filtro.Controls.Add(Me.lbl_TipoServicio)
        Me.gbx_Filtro.Controls.Add(Me.lbl_ClientePadre)
        Me.gbx_Filtro.Controls.Add(Me.cmb_ClientePadre)
        Me.gbx_Filtro.Location = New System.Drawing.Point(4, 4)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(776, 68)
        Me.gbx_Filtro.TabIndex = 6
        Me.gbx_Filtro.TabStop = False
        '
        'frm_ClonarServiciosHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.tab_ClonarServiciosHorarios)
        Me.MinimizeBox = False
        Me.Name = "frm_ClonarServiciosHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clonar Servicios y Horarios"
        Me.gbx_ListaServiciosOtros.ResumeLayout(False)
        Me.gbx_ListaServiciosOtros.PerformLayout()
        Me.gbx_ServiciosTV.ResumeLayout(False)
        Me.gbx_Horarios.ResumeLayout(False)
        Me.gbx_Horarios.PerformLayout()
        Me.tab_ClonarServiciosHorarios.ResumeLayout(False)
        Me.tab_ServiciosOtros.ResumeLayout(False)
        Me.tab_ServiciosHorarios.ResumeLayout(False)
        Me.tab_Subclientes.ResumeLayout(False)
        Me.gbx_Subclientes.ResumeLayout(False)
        Me.gbx_Subclientes.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_ClientePadre As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_SeleccioneCP As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_ClientePadre As System.Windows.Forms.Label
    Friend WithEvents gbx_ListaServiciosOtros As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ServiciosOtros As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_ServiciosTV As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ServiciosTV As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Horarios As System.Windows.Forms.GroupBox
    Friend WithEvents chk_ServiciosOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chk_HorariosServicios As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ClonarServiciosHorarios As System.Windows.Forms.Button
    Friend WithEvents btn_ClonarServicios As System.Windows.Forms.Button
    Friend WithEvents lsv_HorariosActivos As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_ServiciosOtros As System.Windows.Forms.Label
    Friend WithEvents lbl_ServiciosTV As System.Windows.Forms.Label
    Friend WithEvents lbl_Horarios As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaInicioServicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaInicioServicio As System.Windows.Forms.Label
    Friend WithEvents tab_ClonarServiciosHorarios As System.Windows.Forms.TabControl
    Friend WithEvents tab_ServiciosOtros As System.Windows.Forms.TabPage
    Friend WithEvents tab_ServiciosHorarios As System.Windows.Forms.TabPage
    Friend WithEvents tab_Subclientes As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Subclientes As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Subclientes As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Subclientes As System.Windows.Forms.Label
    Friend WithEvents lsv_Subclientes As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_TipoServicio As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoServicio As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
End Class
