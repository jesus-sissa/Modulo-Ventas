<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Instancias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Instancias))
        Dim ListViewColumnSorter1 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_clave = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Baja = New System.Windows.Forms.Button
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.gbx_empladosXinstancia = New System.Windows.Forms.GroupBox
        Me.btn_AgregarEI = New System.Windows.Forms.Button
        Me.lbl_empleadoxI = New System.Windows.Forms.Label
        Me.lbl_Instancia = New System.Windows.Forms.Label
        Me.btn_ExportarEI = New System.Windows.Forms.Button
        Me.btn_BorrarEI = New System.Windows.Forms.Button
        Me.btn_buscarEI = New System.Windows.Forms.Button
        Me.lbl_buscarEI = New System.Windows.Forms.Label
        Me.lbl_registrosEI = New System.Windows.Forms.Label
        Me.gbx_instanciasEv = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.tlp_EmpeladosInstancias = New System.Windows.Forms.TableLayoutPanel
        Me.cmb_Empleados = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_EmpleadoInstancia = New Modulo_Ventas.cp_Textbox
        Me.cmb_Instancia = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.tbx_buscarEI = New Modulo_Ventas.cp_Textbox
        Me.lsv_empleadosxInstancia = New Modulo_Ventas.cp_Listview
        Me.tbx_Descripcion = New Modulo_Ventas.cp_Textbox
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.tbx_Clave = New Modulo_Ventas.cp_Textbox
        Me.cmb_Tipo = New Modulo_Ventas.cp_cmb_Manual
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.gbx_empladosXinstancia.SuspendLayout()
        Me.gbx_instanciasEv.SuspendLayout()
        Me.tlp_EmpeladosInstancias.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = CType(resources.GetObject("btn_Modificar.Image"), System.Drawing.Image)
        Me.btn_Modificar.Location = New System.Drawing.Point(155, 243)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 5
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(22, 47)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Descripción"
        Me.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(444, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(51, 21)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_clave.TabIndex = 0
        Me.lbl_clave.Text = "Clave"
        Me.lbl_clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(463, 65)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(1, 74)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(84, 13)
        Me.lbl_Tipo.TabIndex = 4
        Me.lbl_Tipo.Text = "Tipo Evaluación"
        Me.lbl_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(608, 244)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = CType(resources.GetObject("btn_Baja.Image"), System.Drawing.Image)
        Me.btn_Baja.Location = New System.Drawing.Point(9, 243)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 4
        Me.btn_Baja.Text = "&Baja / Reing."
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(609, 106)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(139, 15)
        Me.Lbl_Registros.TabIndex = 9
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = CType(resources.GetObject("btn_Exportar.Image"), System.Drawing.Image)
        Me.btn_Exportar.Location = New System.Drawing.Point(301, 243)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 6
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(43, 104)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'gbx_empladosXinstancia
        '
        Me.gbx_empladosXinstancia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_empladosXinstancia.Controls.Add(Me.btn_AgregarEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.btn_Cerrar)
        Me.gbx_empladosXinstancia.Controls.Add(Me.cmb_Empleados)
        Me.gbx_empladosXinstancia.Controls.Add(Me.lbl_empleadoxI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.cmb_Instancia)
        Me.gbx_empladosXinstancia.Controls.Add(Me.lbl_Instancia)
        Me.gbx_empladosXinstancia.Controls.Add(Me.btn_ExportarEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.btn_BorrarEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.btn_buscarEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.tbx_buscarEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.lbl_buscarEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.lsv_empleadosxInstancia)
        Me.gbx_empladosXinstancia.Controls.Add(Me.lbl_registrosEI)
        Me.gbx_empladosXinstancia.Controls.Add(Me.tbx_EmpleadoInstancia)
        Me.gbx_empladosXinstancia.Location = New System.Drawing.Point(3, 288)
        Me.gbx_empladosXinstancia.Name = "gbx_empladosXinstancia"
        Me.gbx_empladosXinstancia.Size = New System.Drawing.Size(754, 280)
        Me.gbx_empladosXinstancia.TabIndex = 1
        Me.gbx_empladosXinstancia.TabStop = False
        Me.gbx_empladosXinstancia.Text = "Empleados por Instancia"
        '
        'btn_AgregarEI
        '
        Me.btn_AgregarEI.Enabled = False
        Me.btn_AgregarEI.Image = CType(resources.GetObject("btn_AgregarEI.Image"), System.Drawing.Image)
        Me.btn_AgregarEI.Location = New System.Drawing.Point(488, 67)
        Me.btn_AgregarEI.Name = "btn_AgregarEI"
        Me.btn_AgregarEI.Size = New System.Drawing.Size(140, 30)
        Me.btn_AgregarEI.TabIndex = 28
        Me.btn_AgregarEI.Text = "&Agregar"
        Me.btn_AgregarEI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarEI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarEI.UseVisualStyleBackColor = True
        '
        'lbl_empleadoxI
        '
        Me.lbl_empleadoxI.AutoSize = True
        Me.lbl_empleadoxI.Location = New System.Drawing.Point(22, 76)
        Me.lbl_empleadoxI.Name = "lbl_empleadoxI"
        Me.lbl_empleadoxI.Size = New System.Drawing.Size(54, 13)
        Me.lbl_empleadoxI.TabIndex = 25
        Me.lbl_empleadoxI.Text = "Empleado"
        Me.lbl_empleadoxI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Instancia
        '
        Me.lbl_Instancia.AutoSize = True
        Me.lbl_Instancia.Location = New System.Drawing.Point(26, 49)
        Me.lbl_Instancia.Name = "lbl_Instancia"
        Me.lbl_Instancia.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Instancia.TabIndex = 23
        Me.lbl_Instancia.Text = "Instancia"
        Me.lbl_Instancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_ExportarEI
        '
        Me.btn_ExportarEI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarEI.Image = CType(resources.GetObject("btn_ExportarEI.Image"), System.Drawing.Image)
        Me.btn_ExportarEI.Location = New System.Drawing.Point(156, 244)
        Me.btn_ExportarEI.Name = "btn_ExportarEI"
        Me.btn_ExportarEI.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarEI.TabIndex = 21
        Me.btn_ExportarEI.Text = "&Exportar"
        Me.btn_ExportarEI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarEI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarEI.UseVisualStyleBackColor = True
        '
        'btn_BorrarEI
        '
        Me.btn_BorrarEI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_BorrarEI.Enabled = False
        Me.btn_BorrarEI.Image = CType(resources.GetObject("btn_BorrarEI.Image"), System.Drawing.Image)
        Me.btn_BorrarEI.Location = New System.Drawing.Point(9, 243)
        Me.btn_BorrarEI.Name = "btn_BorrarEI"
        Me.btn_BorrarEI.Size = New System.Drawing.Size(140, 30)
        Me.btn_BorrarEI.TabIndex = 20
        Me.btn_BorrarEI.Text = "B&orrar"
        Me.btn_BorrarEI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BorrarEI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BorrarEI.UseVisualStyleBackColor = True
        '
        'btn_buscarEI
        '
        Me.btn_buscarEI.Image = CType(resources.GetObject("btn_buscarEI.Image"), System.Drawing.Image)
        Me.btn_buscarEI.Location = New System.Drawing.Point(490, 17)
        Me.btn_buscarEI.Name = "btn_buscarEI"
        Me.btn_buscarEI.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarEI.TabIndex = 18
        Me.btn_buscarEI.Text = "B&uscar"
        Me.btn_buscarEI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarEI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscarEI.UseVisualStyleBackColor = True
        '
        'lbl_buscarEI
        '
        Me.lbl_buscarEI.AutoSize = True
        Me.lbl_buscarEI.Location = New System.Drawing.Point(37, 23)
        Me.lbl_buscarEI.Name = "lbl_buscarEI"
        Me.lbl_buscarEI.Size = New System.Drawing.Size(40, 13)
        Me.lbl_buscarEI.TabIndex = 16
        Me.lbl_buscarEI.Text = "Buscar"
        '
        'lbl_registrosEI
        '
        Me.lbl_registrosEI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_registrosEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registrosEI.Location = New System.Drawing.Point(613, 100)
        Me.lbl_registrosEI.Name = "lbl_registrosEI"
        Me.lbl_registrosEI.Size = New System.Drawing.Size(135, 23)
        Me.lbl_registrosEI.TabIndex = 29
        Me.lbl_registrosEI.Text = "Registros: 0"
        Me.lbl_registrosEI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_instanciasEv
        '
        Me.gbx_instanciasEv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_instanciasEv.Controls.Add(Me.btn_Cancelar)
        Me.gbx_instanciasEv.Controls.Add(Me.Lbl_Registros)
        Me.gbx_instanciasEv.Controls.Add(Me.Label4)
        Me.gbx_instanciasEv.Controls.Add(Me.btn_Modificar)
        Me.gbx_instanciasEv.Controls.Add(Me.btn_Exportar)
        Me.gbx_instanciasEv.Controls.Add(Me.btn_Baja)
        Me.gbx_instanciasEv.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_instanciasEv.Controls.Add(Me.lbl_clave)
        Me.gbx_instanciasEv.Controls.Add(Me.tbx_Buscar)
        Me.gbx_instanciasEv.Controls.Add(Me.tbx_Clave)
        Me.gbx_instanciasEv.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_instanciasEv.Controls.Add(Me.cmb_Tipo)
        Me.gbx_instanciasEv.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_instanciasEv.Controls.Add(Me.btn_Guardar)
        Me.gbx_instanciasEv.Controls.Add(Me.lbl_Nombre)
        Me.gbx_instanciasEv.Controls.Add(Me.lbl_Tipo)
        Me.gbx_instanciasEv.Location = New System.Drawing.Point(3, 3)
        Me.gbx_instanciasEv.Name = "gbx_instanciasEv"
        Me.gbx_instanciasEv.Size = New System.Drawing.Size(754, 279)
        Me.gbx_instanciasEv.TabIndex = 0
        Me.gbx_instanciasEv.TabStop = False
        Me.gbx_instanciasEv.Text = "Instancias de Evaluación"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(608, 66)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'tlp_EmpeladosInstancias
        '
        Me.tlp_EmpeladosInstancias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_EmpeladosInstancias.ColumnCount = 1
        Me.tlp_EmpeladosInstancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_EmpeladosInstancias.Controls.Add(Me.gbx_empladosXinstancia, 0, 1)
        Me.tlp_EmpeladosInstancias.Controls.Add(Me.gbx_instanciasEv, 0, 0)
        Me.tlp_EmpeladosInstancias.Location = New System.Drawing.Point(12, 12)
        Me.tlp_EmpeladosInstancias.Name = "tlp_EmpeladosInstancias"
        Me.tlp_EmpeladosInstancias.RowCount = 2
        Me.tlp_EmpeladosInstancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_EmpeladosInstancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_EmpeladosInstancias.Size = New System.Drawing.Size(760, 571)
        Me.tlp_EmpeladosInstancias.TabIndex = 2
        '
        'cmb_Empleados
        '
        Me.cmb_Empleados.Clave = "Clave_Empleado"
        Me.cmb_Empleados.Control_Siguiente = Nothing
        Me.cmb_Empleados.DisplayMember = "Nombre"
        Me.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleados.Empresa = False
        Me.cmb_Empleados.Filtro = Me.tbx_EmpleadoInstancia
        Me.cmb_Empleados.FormattingEnabled = True
        Me.cmb_Empleados.Location = New System.Drawing.Point(82, 73)
        Me.cmb_Empleados.MaxDropDownItems = 20
        Me.cmb_Empleados.Name = "cmb_Empleados"
        Me.cmb_Empleados.Pista = False
        Me.cmb_Empleados.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Empleados.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Empleados.Sucursal = True
        Me.cmb_Empleados.TabIndex = 26
        Me.cmb_Empleados.Tipo = 0
        Me.cmb_Empleados.ValueMember = "Id_Empleado"
        '
        'tbx_EmpleadoInstancia
        '
        Me.tbx_EmpleadoInstancia.Control_Siguiente = Nothing
        Me.tbx_EmpleadoInstancia.Filtrado = False
        Me.tbx_EmpleadoInstancia.Location = New System.Drawing.Point(72, 74)
        Me.tbx_EmpleadoInstancia.MaxLength = 12
        Me.tbx_EmpleadoInstancia.Name = "tbx_EmpleadoInstancia"
        Me.tbx_EmpleadoInstancia.Size = New System.Drawing.Size(66, 20)
        Me.tbx_EmpleadoInstancia.TabIndex = 27
        Me.tbx_EmpleadoInstancia.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_EmpleadoInstancia.Visible = False
        '
        'cmb_Instancia
        '
        Me.cmb_Instancia.Clave = Nothing
        Me.cmb_Instancia.Control_Siguiente = Nothing
        Me.cmb_Instancia.DisplayMember = "Descripcion"
        Me.cmb_Instancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Instancia.Empresa = False
        Me.cmb_Instancia.Filtro = Nothing
        Me.cmb_Instancia.FormattingEnabled = True
        Me.cmb_Instancia.Location = New System.Drawing.Point(82, 46)
        Me.cmb_Instancia.MaxDropDownItems = 20
        Me.cmb_Instancia.Name = "cmb_Instancia"
        Me.cmb_Instancia.Pista = False
        Me.cmb_Instancia.Size = New System.Drawing.Size(214, 21)
        Me.cmb_Instancia.StoredProcedure = "Cat_Instancias_Get"
        Me.cmb_Instancia.Sucursal = False
        Me.cmb_Instancia.TabIndex = 24
        Me.cmb_Instancia.Tipo = 0
        Me.cmb_Instancia.ValueMember = "Id_Instancia"
        '
        'tbx_buscarEI
        '
        Me.tbx_buscarEI.Control_Siguiente = Me.btn_buscarEI
        Me.tbx_buscarEI.Filtrado = False
        Me.tbx_buscarEI.Location = New System.Drawing.Point(83, 20)
        Me.tbx_buscarEI.Name = "tbx_buscarEI"
        Me.tbx_buscarEI.Size = New System.Drawing.Size(401, 20)
        Me.tbx_buscarEI.TabIndex = 17
        Me.tbx_buscarEI.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_empleadosxInstancia
        '
        Me.lsv_empleadosxInstancia.AllowColumnReorder = True
        Me.lsv_empleadosxInstancia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_empleadosxInstancia.FullRowSelect = True
        Me.lsv_empleadosxInstancia.HideSelection = False
        Me.lsv_empleadosxInstancia.Location = New System.Drawing.Point(9, 130)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_empleadosxInstancia.Lvs = ListViewColumnSorter1
        Me.lsv_empleadosxInstancia.MultiSelect = False
        Me.lsv_empleadosxInstancia.Name = "lsv_empleadosxInstancia"
        Me.lsv_empleadosxInstancia.Row1 = 20
        Me.lsv_empleadosxInstancia.Row10 = 0
        Me.lsv_empleadosxInstancia.Row2 = 40
        Me.lsv_empleadosxInstancia.Row3 = 0
        Me.lsv_empleadosxInstancia.Row4 = 0
        Me.lsv_empleadosxInstancia.Row5 = 15
        Me.lsv_empleadosxInstancia.Row6 = 0
        Me.lsv_empleadosxInstancia.Row7 = 0
        Me.lsv_empleadosxInstancia.Row8 = 0
        Me.lsv_empleadosxInstancia.Row9 = 0
        Me.lsv_empleadosxInstancia.Size = New System.Drawing.Size(739, 108)
        Me.lsv_empleadosxInstancia.TabIndex = 19
        Me.lsv_empleadosxInstancia.UseCompatibleStateImageBehavior = False
        Me.lsv_empleadosxInstancia.View = System.Windows.Forms.View.Details
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(91, 44)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Descripcion.TabIndex = 3
        Me.tbx_Descripcion.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(91, 101)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(401, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Nothing
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(91, 18)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(69, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(92, 71)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(349, 21)
        Me.cmb_Tipo.TabIndex = 5
        Me.cmb_Tipo.ValueMember = "value"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(9, 127)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter2
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 40
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 15
        Me.lsv_Catalogo.Row5 = 0
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(739, 110)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'frm_Instancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 585)
        Me.Controls.Add(Me.tlp_EmpeladosInstancias)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 624)
        Me.Name = "frm_Instancias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instancias de Evaluación y Empleados por Instancia"
        Me.gbx_empladosXinstancia.ResumeLayout(False)
        Me.gbx_empladosXinstancia.PerformLayout()
        Me.gbx_instanciasEv.ResumeLayout(False)
        Me.gbx_instanciasEv.PerformLayout()
        Me.tlp_EmpeladosInstancias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Descripcion As Modulo_Ventas.cp_Textbox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Clave As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_clave As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_empladosXinstancia As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_registrosEI As System.Windows.Forms.Label
    Friend WithEvents btn_AgregarEI As System.Windows.Forms.Button
    Friend WithEvents tbx_EmpleadoInstancia As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Empleados As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_empleadoxI As System.Windows.Forms.Label
    Friend WithEvents cmb_Instancia As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Instancia As System.Windows.Forms.Label
    Friend WithEvents btn_ExportarEI As System.Windows.Forms.Button
    Friend WithEvents btn_BorrarEI As System.Windows.Forms.Button
    Friend WithEvents btn_buscarEI As System.Windows.Forms.Button
    Friend WithEvents tbx_buscarEI As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_buscarEI As System.Windows.Forms.Label
    Friend WithEvents lsv_empleadosxInstancia As Modulo_Ventas.cp_Listview
    Friend WithEvents gbx_instanciasEv As System.Windows.Forms.GroupBox
    Friend WithEvents tlp_EmpeladosInstancias As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
End Class
