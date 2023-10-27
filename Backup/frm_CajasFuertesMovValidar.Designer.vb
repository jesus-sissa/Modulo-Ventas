<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CajasFuertesMovValidar
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
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.gbx_CajasFuertes = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.dtp_HoraReal = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaReal = New System.Windows.Forms.DateTimePicker
        Me.lbl_HoraReal = New System.Windows.Forms.Label
        Me.lbl_FechaReal = New System.Windows.Forms.Label
        Me.tbx_CombActual2 = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombActual1 = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombActual0 = New Modulo_Ventas.cp_Textbox
        Me.lbl_CombActual = New System.Windows.Forms.Label
        Me.tbx_CombNueva1 = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombNueva2 = New Modulo_Ventas.cp_Textbox
        Me.tbx_CombNueva0 = New Modulo_Ventas.cp_Textbox
        Me.lbl_ACombinacion = New System.Windows.Forms.Label
        Me.lbl_CombNueva = New System.Windows.Forms.Label
        Me.lbl_ObservacionesValida = New System.Windows.Forms.Label
        Me.rtb_ObservacionesValidar = New System.Windows.Forms.RichTextBox
        Me.lsv_Catalogo = New Modulo_Ventas.cp_Listview
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_CajasFuertes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.btn_Validar)
        Me.gbx_Controles.Location = New System.Drawing.Point(9, 504)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Controles.TabIndex = 1
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Ventas.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'gbx_CajasFuertes
        '
        Me.gbx_CajasFuertes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CajasFuertes.Controls.Add(Me.Lbl_Registros)
        Me.gbx_CajasFuertes.Controls.Add(Me.dtp_HoraReal)
        Me.gbx_CajasFuertes.Controls.Add(Me.dtp_FechaReal)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_HoraReal)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_FechaReal)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_CombActual2)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_CombActual1)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_CombActual0)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_CombActual)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_CombNueva1)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_CombNueva0)
        Me.gbx_CajasFuertes.Controls.Add(Me.tbx_CombNueva2)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_ACombinacion)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_CombNueva)
        Me.gbx_CajasFuertes.Controls.Add(Me.lbl_ObservacionesValida)
        Me.gbx_CajasFuertes.Controls.Add(Me.rtb_ObservacionesValidar)
        Me.gbx_CajasFuertes.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_CajasFuertes.Location = New System.Drawing.Point(9, 2)
        Me.gbx_CajasFuertes.Name = "gbx_CajasFuertes"
        Me.gbx_CajasFuertes.Size = New System.Drawing.Size(767, 496)
        Me.gbx_CajasFuertes.TabIndex = 0
        Me.gbx_CajasFuertes.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(626, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(135, 15)
        Me.Lbl_Registros.TabIndex = 18
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_HoraReal
        '
        Me.dtp_HoraReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_HoraReal.CustomFormat = "HH:mm"
        Me.dtp_HoraReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraReal.Location = New System.Drawing.Point(115, 470)
        Me.dtp_HoraReal.Name = "dtp_HoraReal"
        Me.dtp_HoraReal.ShowUpDown = True
        Me.dtp_HoraReal.Size = New System.Drawing.Size(60, 20)
        Me.dtp_HoraReal.TabIndex = 6
        '
        'dtp_FechaReal
        '
        Me.dtp_FechaReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_FechaReal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaReal.Location = New System.Drawing.Point(115, 444)
        Me.dtp_FechaReal.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_FechaReal.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_FechaReal.Name = "dtp_FechaReal"
        Me.dtp_FechaReal.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaReal.TabIndex = 4
        Me.dtp_FechaReal.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_HoraReal
        '
        Me.lbl_HoraReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_HoraReal.AutoSize = True
        Me.lbl_HoraReal.Location = New System.Drawing.Point(54, 473)
        Me.lbl_HoraReal.Name = "lbl_HoraReal"
        Me.lbl_HoraReal.Size = New System.Drawing.Size(55, 13)
        Me.lbl_HoraReal.TabIndex = 5
        Me.lbl_HoraReal.Text = "Hora Real"
        '
        'lbl_FechaReal
        '
        Me.lbl_FechaReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_FechaReal.AutoSize = True
        Me.lbl_FechaReal.Location = New System.Drawing.Point(47, 447)
        Me.lbl_FechaReal.Name = "lbl_FechaReal"
        Me.lbl_FechaReal.Size = New System.Drawing.Size(62, 13)
        Me.lbl_FechaReal.TabIndex = 3
        Me.lbl_FechaReal.Text = "Fecha Real"
        '
        'tbx_CombActual2
        '
        Me.tbx_CombActual2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_CombActual2.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CombActual2.Control_Siguiente = Nothing
        Me.tbx_CombActual2.Filtrado = True
        Me.tbx_CombActual2.Location = New System.Drawing.Point(440, 444)
        Me.tbx_CombActual2.MaxLength = 4
        Me.tbx_CombActual2.Name = "tbx_CombActual2"
        Me.tbx_CombActual2.ReadOnly = True
        Me.tbx_CombActual2.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombActual2.TabIndex = 10
        Me.tbx_CombActual2.TabStop = False
        Me.tbx_CombActual2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CombActual2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_CombActual2.Visible = False
        '
        'tbx_CombActual1
        '
        Me.tbx_CombActual1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_CombActual1.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CombActual1.Control_Siguiente = Nothing
        Me.tbx_CombActual1.Filtrado = True
        Me.tbx_CombActual1.Location = New System.Drawing.Point(384, 444)
        Me.tbx_CombActual1.MaxLength = 4
        Me.tbx_CombActual1.Name = "tbx_CombActual1"
        Me.tbx_CombActual1.ReadOnly = True
        Me.tbx_CombActual1.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombActual1.TabIndex = 9
        Me.tbx_CombActual1.TabStop = False
        Me.tbx_CombActual1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CombActual1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_CombActual1.Visible = False
        '
        'tbx_CombActual0
        '
        Me.tbx_CombActual0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_CombActual0.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CombActual0.Control_Siguiente = Nothing
        Me.tbx_CombActual0.Filtrado = True
        Me.tbx_CombActual0.Location = New System.Drawing.Point(328, 444)
        Me.tbx_CombActual0.MaxLength = 4
        Me.tbx_CombActual0.Name = "tbx_CombActual0"
        Me.tbx_CombActual0.ReadOnly = True
        Me.tbx_CombActual0.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombActual0.TabIndex = 8
        Me.tbx_CombActual0.TabStop = False
        Me.tbx_CombActual0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CombActual0.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_CombActual0.Visible = False
        '
        'lbl_CombActual
        '
        Me.lbl_CombActual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_CombActual.AutoSize = True
        Me.lbl_CombActual.Location = New System.Drawing.Point(221, 447)
        Me.lbl_CombActual.Name = "lbl_CombActual"
        Me.lbl_CombActual.Size = New System.Drawing.Size(101, 13)
        Me.lbl_CombActual.TabIndex = 7
        Me.lbl_CombActual.Text = "Combinación Actual"
        Me.lbl_CombActual.Visible = False
        '
        'tbx_CombNueva1
        '
        Me.tbx_CombNueva1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_CombNueva1.Control_Siguiente = Me.tbx_CombNueva2
        Me.tbx_CombNueva1.Filtrado = True
        Me.tbx_CombNueva1.Location = New System.Drawing.Point(384, 470)
        Me.tbx_CombNueva1.MaxLength = 2
        Me.tbx_CombNueva1.Name = "tbx_CombNueva1"
        Me.tbx_CombNueva1.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombNueva1.TabIndex = 13
        Me.tbx_CombNueva1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CombNueva1.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_CombNueva1.Visible = False
        '
        'tbx_CombNueva2
        '
        Me.tbx_CombNueva2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_CombNueva2.Control_Siguiente = Me.btn_Validar
        Me.tbx_CombNueva2.Filtrado = True
        Me.tbx_CombNueva2.Location = New System.Drawing.Point(440, 470)
        Me.tbx_CombNueva2.MaxLength = 2
        Me.tbx_CombNueva2.Name = "tbx_CombNueva2"
        Me.tbx_CombNueva2.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombNueva2.TabIndex = 14
        Me.tbx_CombNueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CombNueva2.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_CombNueva2.Visible = False
        '
        'tbx_CombNueva0
        '
        Me.tbx_CombNueva0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_CombNueva0.Control_Siguiente = Me.tbx_CombNueva1
        Me.tbx_CombNueva0.Filtrado = True
        Me.tbx_CombNueva0.Location = New System.Drawing.Point(328, 470)
        Me.tbx_CombNueva0.MaxLength = 2
        Me.tbx_CombNueva0.Name = "tbx_CombNueva0"
        Me.tbx_CombNueva0.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CombNueva0.TabIndex = 12
        Me.tbx_CombNueva0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CombNueva0.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_CombNueva0.Visible = False
        '
        'lbl_ACombinacion
        '
        Me.lbl_ACombinacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ACombinacion.AutoSize = True
        Me.lbl_ACombinacion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ACombinacion.ForeColor = System.Drawing.Color.Red
        Me.lbl_ACombinacion.Location = New System.Drawing.Point(496, 471)
        Me.lbl_ACombinacion.Name = "lbl_ACombinacion"
        Me.lbl_ACombinacion.Size = New System.Drawing.Size(13, 16)
        Me.lbl_ACombinacion.TabIndex = 15
        Me.lbl_ACombinacion.Text = "*"
        Me.lbl_ACombinacion.Visible = False
        '
        'lbl_CombNueva
        '
        Me.lbl_CombNueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_CombNueva.AutoSize = True
        Me.lbl_CombNueva.Location = New System.Drawing.Point(219, 473)
        Me.lbl_CombNueva.Name = "lbl_CombNueva"
        Me.lbl_CombNueva.Size = New System.Drawing.Size(103, 13)
        Me.lbl_CombNueva.TabIndex = 11
        Me.lbl_CombNueva.Text = "Combinación Nueva"
        Me.lbl_CombNueva.Visible = False
        '
        'lbl_ObservacionesValida
        '
        Me.lbl_ObservacionesValida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ObservacionesValida.Location = New System.Drawing.Point(23, 381)
        Me.lbl_ObservacionesValida.Name = "lbl_ObservacionesValida"
        Me.lbl_ObservacionesValida.Size = New System.Drawing.Size(86, 35)
        Me.lbl_ObservacionesValida.TabIndex = 1
        Me.lbl_ObservacionesValida.Text = "Observaciones de la Validación"
        Me.lbl_ObservacionesValida.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rtb_ObservacionesValidar
        '
        Me.rtb_ObservacionesValidar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_ObservacionesValidar.Location = New System.Drawing.Point(115, 381)
        Me.rtb_ObservacionesValidar.Name = "rtb_ObservacionesValidar"
        Me.rtb_ObservacionesValidar.Size = New System.Drawing.Size(649, 57)
        Me.rtb_ObservacionesValidar.TabIndex = 2
        Me.rtb_ObservacionesValidar.Text = ""
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 10
        Me.lsv_Catalogo.Row3 = 20
        Me.lsv_Catalogo.Row4 = 25
        Me.lsv_Catalogo.Row5 = 8
        Me.lsv_Catalogo.Row6 = 8
        Me.lsv_Catalogo.Row7 = 8
        Me.lsv_Catalogo.Row8 = 8
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(761, 341)
        Me.lsv_Catalogo.TabIndex = 0
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'frm_CajasFuertesMovValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_CajasFuertes)
        Me.Controls.Add(Me.gbx_Controles)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CajasFuertesMovValidar"
        Me.Text = "Validar Movimientos de Cajas Fuertes"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_CajasFuertes.ResumeLayout(False)
        Me.gbx_CajasFuertes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents gbx_CajasFuertes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Catalogo As Modulo_Ventas.cp_Listview
    Friend WithEvents lbl_ObservacionesValida As System.Windows.Forms.Label
    Friend WithEvents rtb_ObservacionesValidar As System.Windows.Forms.RichTextBox
    Friend WithEvents tbx_CombNueva1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CombNueva0 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CombNueva2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_ACombinacion As System.Windows.Forms.Label
    Friend WithEvents lbl_CombNueva As System.Windows.Forms.Label
    Friend WithEvents tbx_CombActual2 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CombActual1 As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_CombActual0 As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_CombActual As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraReal As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaReal As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_HoraReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
