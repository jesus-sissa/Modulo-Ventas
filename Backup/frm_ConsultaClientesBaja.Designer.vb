<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaClientesBaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaClientesBaja))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.gbx_Consulta = New System.Windows.Forms.GroupBox
        Me.cmb_MotivoBaja = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.chk_UsuarioBaja = New System.Windows.Forms.CheckBox
        Me.lbl_UsuarioBaja = New System.Windows.Forms.Label
        Me.cmb_UsuarioBaja = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_UsuarioBaja = New Modulo_Ventas.cp_Textbox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.chk_MotivoBaja = New System.Windows.Forms.CheckBox
        Me.lbl_MotivoBaja = New System.Windows.Forms.Label
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.tbx_MotivoBaja = New Modulo_Ventas.cp_Textbox
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Adjunto = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.lbl_TotalLsv = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.gbx_Consulta.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Consulta
        '
        Me.gbx_Consulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consulta.Controls.Add(Me.cmb_MotivoBaja)
        Me.gbx_Consulta.Controls.Add(Me.chk_UsuarioBaja)
        Me.gbx_Consulta.Controls.Add(Me.lbl_UsuarioBaja)
        Me.gbx_Consulta.Controls.Add(Me.cmb_UsuarioBaja)
        Me.gbx_Consulta.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Consulta.Controls.Add(Me.dtp_Desde)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Desde)
        Me.gbx_Consulta.Controls.Add(Me.chk_MotivoBaja)
        Me.gbx_Consulta.Controls.Add(Me.lbl_MotivoBaja)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Status)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Status)
        Me.gbx_Consulta.Controls.Add(Me.chk_Status)
        Me.gbx_Consulta.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Consulta.Controls.Add(Me.tbx_UsuarioBaja)
        Me.gbx_Consulta.Controls.Add(Me.tbx_MotivoBaja)
        Me.gbx_Consulta.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Consulta.Name = "gbx_Consulta"
        Me.gbx_Consulta.Size = New System.Drawing.Size(767, 122)
        Me.gbx_Consulta.TabIndex = 0
        Me.gbx_Consulta.TabStop = False
        '
        'cmb_MotivoBaja
        '
        Me.cmb_MotivoBaja.Clave = "Clave"
        Me.cmb_MotivoBaja.Control_Siguiente = Nothing
        Me.cmb_MotivoBaja.DisplayMember = "Descripcion"
        Me.cmb_MotivoBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MotivoBaja.Empresa = False
        Me.cmb_MotivoBaja.Filtro = Nothing
        Me.cmb_MotivoBaja.FormattingEnabled = True
        Me.cmb_MotivoBaja.Location = New System.Drawing.Point(83, 69)
        Me.cmb_MotivoBaja.MaxDropDownItems = 20
        Me.cmb_MotivoBaja.Name = "cmb_MotivoBaja"
        Me.cmb_MotivoBaja.Pista = True
        Me.cmb_MotivoBaja.Size = New System.Drawing.Size(294, 21)
        Me.cmb_MotivoBaja.StoredProcedure = "Cat_MotivosBaja_Get"
        Me.cmb_MotivoBaja.Sucursal = False
        Me.cmb_MotivoBaja.TabIndex = 10
        Me.cmb_MotivoBaja.Tipo = 1
        Me.cmb_MotivoBaja.ValueMember = "Id_MotivoB"
        '
        'chk_UsuarioBaja
        '
        Me.chk_UsuarioBaja.AutoSize = True
        Me.chk_UsuarioBaja.Location = New System.Drawing.Point(439, 44)
        Me.chk_UsuarioBaja.Name = "chk_UsuarioBaja"
        Me.chk_UsuarioBaja.Size = New System.Drawing.Size(56, 17)
        Me.chk_UsuarioBaja.TabIndex = 7
        Me.chk_UsuarioBaja.Text = "Todos"
        Me.chk_UsuarioBaja.UseVisualStyleBackColor = True
        '
        'lbl_UsuarioBaja
        '
        Me.lbl_UsuarioBaja.AutoSize = True
        Me.lbl_UsuarioBaja.Location = New System.Drawing.Point(11, 45)
        Me.lbl_UsuarioBaja.Name = "lbl_UsuarioBaja"
        Me.lbl_UsuarioBaja.Size = New System.Drawing.Size(67, 13)
        Me.lbl_UsuarioBaja.TabIndex = 4
        Me.lbl_UsuarioBaja.Text = "Usuario Baja"
        '
        'cmb_UsuarioBaja
        '
        Me.cmb_UsuarioBaja.Clave = "Clave_Empleado"
        Me.cmb_UsuarioBaja.Control_Siguiente = Nothing
        Me.cmb_UsuarioBaja.DisplayMember = "Nombre"
        Me.cmb_UsuarioBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioBaja.Empresa = False
        Me.cmb_UsuarioBaja.Filtro = Me.tbx_UsuarioBaja
        Me.cmb_UsuarioBaja.FormattingEnabled = True
        Me.cmb_UsuarioBaja.Location = New System.Drawing.Point(83, 42)
        Me.cmb_UsuarioBaja.MaxDropDownItems = 20
        Me.cmb_UsuarioBaja.Name = "cmb_UsuarioBaja"
        Me.cmb_UsuarioBaja.Pista = False
        Me.cmb_UsuarioBaja.Size = New System.Drawing.Size(350, 21)
        Me.cmb_UsuarioBaja.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_UsuarioBaja.Sucursal = True
        Me.cmb_UsuarioBaja.TabIndex = 6
        Me.cmb_UsuarioBaja.Tipo = 0
        Me.cmb_UsuarioBaja.ValueMember = "Id_Empleado"
        '
        'tbx_UsuarioBaja
        '
        Me.tbx_UsuarioBaja.Control_Siguiente = Me.cmb_UsuarioBaja
        Me.tbx_UsuarioBaja.Filtrado = True
        Me.tbx_UsuarioBaja.Location = New System.Drawing.Point(74, 41)
        Me.tbx_UsuarioBaja.MaxLength = 12
        Me.tbx_UsuarioBaja.Name = "tbx_UsuarioBaja"
        Me.tbx_UsuarioBaja.Size = New System.Drawing.Size(50, 20)
        Me.tbx_UsuarioBaja.TabIndex = 5
        Me.tbx_UsuarioBaja.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_UsuarioBaja.Visible = False
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(225, 14)
        Me.dtp_Hasta.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Hasta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        Me.dtp_Hasta.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(184, 18)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(83, 14)
        Me.dtp_Desde.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Desde.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        Me.dtp_Desde.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(39, 18)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'chk_MotivoBaja
        '
        Me.chk_MotivoBaja.AutoSize = True
        Me.chk_MotivoBaja.Location = New System.Drawing.Point(383, 71)
        Me.chk_MotivoBaja.Name = "chk_MotivoBaja"
        Me.chk_MotivoBaja.Size = New System.Drawing.Size(56, 17)
        Me.chk_MotivoBaja.TabIndex = 11
        Me.chk_MotivoBaja.Text = "Todos"
        Me.chk_MotivoBaja.UseVisualStyleBackColor = True
        '
        'lbl_MotivoBaja
        '
        Me.lbl_MotivoBaja.AutoSize = True
        Me.lbl_MotivoBaja.Location = New System.Drawing.Point(14, 70)
        Me.lbl_MotivoBaja.Name = "lbl_MotivoBaja"
        Me.lbl_MotivoBaja.Size = New System.Drawing.Size(63, 13)
        Me.lbl_MotivoBaja.TabIndex = 8
        Me.lbl_MotivoBaja.Text = "Motivo Baja"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(40, 97)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 12
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(83, 94)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(183, 21)
        Me.cmb_Status.TabIndex = 13
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(567, 86)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 15
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(272, 96)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 14
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'tbx_MotivoBaja
        '
        Me.tbx_MotivoBaja.Control_Siguiente = Me.cmb_MotivoBaja
        Me.tbx_MotivoBaja.Filtrado = True
        Me.tbx_MotivoBaja.Location = New System.Drawing.Point(74, 68)
        Me.tbx_MotivoBaja.MaxLength = 12
        Me.tbx_MotivoBaja.Name = "tbx_MotivoBaja"
        Me.tbx_MotivoBaja.Size = New System.Drawing.Size(50, 20)
        Me.tbx_MotivoBaja.TabIndex = 9
        Me.tbx_MotivoBaja.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_MotivoBaja.Visible = False
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Adjunto)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.btn_Exportar)
        Me.gbx_Controles.Location = New System.Drawing.Point(8, 495)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Adjunto
        '
        Me.btn_Adjunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Adjunto.Enabled = False
        Me.btn_Adjunto.Image = Global.Modulo_Ventas.My.Resources.Resources.Camara
        Me.btn_Adjunto.Location = New System.Drawing.Point(152, 14)
        Me.btn_Adjunto.Name = "btn_Adjunto"
        Me.btn_Adjunto.Size = New System.Drawing.Size(140, 30)
        Me.btn_Adjunto.TabIndex = 1
        Me.btn_Adjunto.Text = "Archivo Adjunto"
        Me.btn_Adjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Adjunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Adjunto.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
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
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.lbl_TotalLsv)
        Me.gbx_Datos.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_Datos.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_Datos.Controls.Add(Me.btn_Buscar)
        Me.gbx_Datos.Location = New System.Drawing.Point(8, 130)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(767, 359)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'lbl_TotalLsv
        '
        Me.lbl_TotalLsv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalLsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalLsv.Location = New System.Drawing.Point(664, 14)
        Me.lbl_TotalLsv.Name = "lbl_TotalLsv"
        Me.lbl_TotalLsv.Size = New System.Drawing.Size(97, 17)
        Me.lbl_TotalLsv.TabIndex = 16
        Me.lbl_TotalLsv.Text = "0 Registros"
        Me.lbl_TotalLsv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(8, 39)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 15
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 15
        Me.lsv_Catalogo.Row5 = 12
        Me.lsv_Catalogo.Row6 = 12
        Me.lsv_Catalogo.Row7 = 12
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 8
        Me.lsv_Catalogo.Size = New System.Drawing.Size(753, 306)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(63, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(505, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Ventas.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(574, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(70, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(14, 16)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'frm_ConsultaClientesBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Consulta)
        Me.Controls.Add(Me.gbx_Datos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaClientesBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Bajas de Clientes"
        Me.gbx_Consulta.ResumeLayout(False)
        Me.gbx_Consulta.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_MotivoBaja As System.Windows.Forms.Label
    Friend WithEvents chk_MotivoBaja As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents cmb_UsuarioBaja As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_UsuarioBaja As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_UsuarioBaja As System.Windows.Forms.Label
    Friend WithEvents chk_UsuarioBaja As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_MotivoBaja As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_MotivoBaja As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Adjunto As System.Windows.Forms.Button
    Friend WithEvents lbl_TotalLsv As System.Windows.Forms.Label
End Class
