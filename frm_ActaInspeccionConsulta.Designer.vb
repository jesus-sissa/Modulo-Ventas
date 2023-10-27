<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActaInspeccionConsulta
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
        Dim ListViewColumnSorter2 As Modulo_Ventas.ListViewColumnSorter = New Modulo_Ventas.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ActaInspeccionConsulta))
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ModificarImagenes = New System.Windows.Forms.Button
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Reimprimir = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_ActasInspeccion = New Modulo_Ventas.cp_Listview
        Me.gbx_Consulta = New System.Windows.Forms.GroupBox
        Me.cmb_Status = New Modulo_Ventas.cp_cmb_Manual
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_StatusTodos = New System.Windows.Forms.CheckBox
        Me.chk_EmpleadoTodos = New System.Windows.Forms.CheckBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.chk_ClienteTodos = New System.Windows.Forms.CheckBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.tbx_EmpleadoClave = New Modulo_Ventas.cp_Textbox
        Me.cmb_Empleado = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.tbx_ClienteClave = New Modulo_Ventas.cp_Textbox
        Me.cmb_Cliente = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ModificarImagenes)
        Me.gbx_Botones.Controls.Add(Me.btn_Modificar)
        Me.gbx_Botones.Controls.Add(Me.btn_Reimprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(790, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_ModificarImagenes
        '
        Me.btn_ModificarImagenes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ModificarImagenes.Enabled = False
        Me.btn_ModificarImagenes.Image = Global.Modulo_Ventas.My.Resources.Resources.Camara
        Me.btn_ModificarImagenes.Location = New System.Drawing.Point(444, 13)
        Me.btn_ModificarImagenes.Name = "btn_ModificarImagenes"
        Me.btn_ModificarImagenes.Size = New System.Drawing.Size(140, 30)
        Me.btn_ModificarImagenes.TabIndex = 3
        Me.btn_ModificarImagenes.Text = "Modificar &Imagenes"
        Me.btn_ModificarImagenes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ModificarImagenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ModificarImagenes.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Ventas.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(152, 13)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 1
        Me.btn_Modificar.Text = "M&odificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Reimprimir
        '
        Me.btn_Reimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Reimprimir.Enabled = False
        Me.btn_Reimprimir.Image = Global.Modulo_Ventas.My.Resources.Resources.Imprimir
        Me.btn_Reimprimir.Location = New System.Drawing.Point(6, 13)
        Me.btn_Reimprimir.Name = "btn_Reimprimir"
        Me.btn_Reimprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Reimprimir.TabIndex = 0
        Me.btn_Reimprimir.Text = "&Reimprimir"
        Me.btn_Reimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Reimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Reimprimir.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Baja
        Me.btn_Cancelar.Location = New System.Drawing.Point(298, 13)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "C&ancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(644, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Datos.Controls.Add(Me.lsv_ActasInspeccion)
        Me.gbx_Datos.Location = New System.Drawing.Point(8, 142)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(790, 351)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(644, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 17)
        Me.Lbl_Registros.TabIndex = 1
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ActasInspeccion
        '
        Me.lsv_ActasInspeccion.AllowColumnReorder = True
        Me.lsv_ActasInspeccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ActasInspeccion.FullRowSelect = True
        Me.lsv_ActasInspeccion.HideSelection = False
        Me.lsv_ActasInspeccion.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ActasInspeccion.Lvs = ListViewColumnSorter2
        Me.lsv_ActasInspeccion.MultiSelect = False
        Me.lsv_ActasInspeccion.Name = "lsv_ActasInspeccion"
        Me.lsv_ActasInspeccion.Row1 = 10
        Me.lsv_ActasInspeccion.Row10 = 0
        Me.lsv_ActasInspeccion.Row2 = 10
        Me.lsv_ActasInspeccion.Row3 = 10
        Me.lsv_ActasInspeccion.Row4 = 20
        Me.lsv_ActasInspeccion.Row5 = 20
        Me.lsv_ActasInspeccion.Row6 = 20
        Me.lsv_ActasInspeccion.Row7 = 10
        Me.lsv_ActasInspeccion.Row8 = 0
        Me.lsv_ActasInspeccion.Row9 = 0
        Me.lsv_ActasInspeccion.Size = New System.Drawing.Size(778, 312)
        Me.lsv_ActasInspeccion.TabIndex = 0
        Me.lsv_ActasInspeccion.UseCompatibleStateImageBehavior = False
        Me.lsv_ActasInspeccion.View = System.Windows.Forms.View.Details
        '
        'gbx_Consulta
        '
        Me.gbx_Consulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Status)
        Me.gbx_Consulta.Controls.Add(Me.chk_StatusTodos)
        Me.gbx_Consulta.Controls.Add(Me.chk_EmpleadoTodos)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Status)
        Me.gbx_Consulta.Controls.Add(Me.chk_ClienteTodos)
        Me.gbx_Consulta.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Consulta.Controls.Add(Me.dtp_Desde)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Desde)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Empleado)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Empleado)
        Me.gbx_Consulta.Controls.Add(Me.tbx_ClienteClave)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Consulta.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Consulta.Controls.Add(Me.tbx_EmpleadoClave)
        Me.gbx_Consulta.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Consulta.Name = "gbx_Consulta"
        Me.gbx_Consulta.Size = New System.Drawing.Size(790, 134)
        Me.gbx_Consulta.TabIndex = 0
        Me.gbx_Consulta.TabStop = False
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(69, 99)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(162, 21)
        Me.cmb_Status.TabIndex = 13
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Ventas.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(338, 98)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 15
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_StatusTodos
        '
        Me.chk_StatusTodos.AutoSize = True
        Me.chk_StatusTodos.Location = New System.Drawing.Point(237, 102)
        Me.chk_StatusTodos.Name = "chk_StatusTodos"
        Me.chk_StatusTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_StatusTodos.TabIndex = 14
        Me.chk_StatusTodos.Text = "Todos"
        Me.chk_StatusTodos.UseVisualStyleBackColor = True
        '
        'chk_EmpleadoTodos
        '
        Me.chk_EmpleadoTodos.AutoSize = True
        Me.chk_EmpleadoTodos.Location = New System.Drawing.Point(426, 74)
        Me.chk_EmpleadoTodos.Name = "chk_EmpleadoTodos"
        Me.chk_EmpleadoTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_EmpleadoTodos.TabIndex = 11
        Me.chk_EmpleadoTodos.Text = "Todos"
        Me.chk_EmpleadoTodos.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(26, 103)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 12
        Me.lbl_Status.Text = "Status"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_ClienteTodos
        '
        Me.chk_ClienteTodos.AutoSize = True
        Me.chk_ClienteTodos.Location = New System.Drawing.Point(484, 47)
        Me.chk_ClienteTodos.Name = "chk_ClienteTodos"
        Me.chk_ClienteTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_ClienteTodos.TabIndex = 7
        Me.chk_ClienteTodos.Text = "Todos"
        Me.chk_ClienteTodos.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(211, 19)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(170, 23)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(69, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(25, 23)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'tbx_EmpleadoClave
        '
        Me.tbx_EmpleadoClave.Control_Siguiente = Me.cmb_Empleado
        Me.tbx_EmpleadoClave.Filtrado = True
        Me.tbx_EmpleadoClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_EmpleadoClave.Location = New System.Drawing.Point(61, 72)
        Me.tbx_EmpleadoClave.MaxLength = 12
        Me.tbx_EmpleadoClave.Name = "tbx_EmpleadoClave"
        Me.tbx_EmpleadoClave.Size = New System.Drawing.Size(52, 20)
        Me.tbx_EmpleadoClave.TabIndex = 9
        Me.tbx_EmpleadoClave.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_EmpleadoClave.Visible = False
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave_Empleado"
        Me.cmb_Empleado.Control_Siguiente = Me.cmb_Status
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_EmpleadoClave
        Me.cmb_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(69, 72)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = False
        Me.cmb_Empleado.Size = New System.Drawing.Size(351, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 10
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Empleado.Location = New System.Drawing.Point(9, 75)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Empleado.TabIndex = 8
        Me.lbl_Empleado.Text = "Empleado"
        Me.lbl_Empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_ClienteClave
        '
        Me.tbx_ClienteClave.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_ClienteClave.Filtrado = True
        Me.tbx_ClienteClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ClienteClave.Location = New System.Drawing.Point(69, 45)
        Me.tbx_ClienteClave.MaxLength = 5
        Me.tbx_ClienteClave.Name = "tbx_ClienteClave"
        Me.tbx_ClienteClave.Size = New System.Drawing.Size(52, 20)
        Me.tbx_ClienteClave.TabIndex = 5
        Me.tbx_ClienteClave.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.tbx_EmpleadoClave
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_ClienteClave
        Me.cmb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(127, 45)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(351, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_GetAB"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 6
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(24, 48)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        Me.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_ActaInspeccionConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 561)
        Me.Controls.Add(Me.gbx_Consulta)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ActaInspeccionConsulta"
        Me.Text = "Consulta de Actas de Inspección para Instalación de Cajas Fuertes"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Consulta.ResumeLayout(False)
        Me.gbx_Consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ActasInspeccion As Modulo_Ventas.cp_Listview
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents gbx_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents tbx_EmpleadoClave As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Empleado As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents tbx_ClienteClave As Modulo_Ventas.cp_Textbox
    Friend WithEvents cmb_Cliente As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents chk_ClienteTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_StatusTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_EmpleadoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents btn_Reimprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_ModificarImagenes As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
