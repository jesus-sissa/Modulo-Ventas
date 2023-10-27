<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Agenda
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
        Dim DrawTool1 As Calendar.DrawTool = New Calendar.DrawTool
        Me.DayView = New Calendar.DayView
        Me.Gbx_Calendario = New System.Windows.Forms.GroupBox
        Me.rdb_Treinta = New System.Windows.Forms.RadioButton
        Me.rdb_Quince = New System.Windows.Forms.RadioButton
        Me.rdb_Siete = New System.Windows.Forms.RadioButton
        Me.rdb_Cinco = New System.Windows.Forms.RadioButton
        Me.rdb_Tres = New System.Windows.Forms.RadioButton
        Me.rdb_Uno = New System.Windows.Forms.RadioButton
        Me.Gbx_Tareas = New System.Windows.Forms.GroupBox
        Me.btn_Todas = New System.Windows.Forms.Button
        Me.Gbx_Leyendas = New System.Windows.Forms.GroupBox
        Me.Tbx_Amarrillo = New System.Windows.Forms.TextBox
        Me.Lbl_TareaPosp = New System.Windows.Forms.Label
        Me.Tbx_Verde = New System.Windows.Forms.TextBox
        Me.Tbx_Rojo = New System.Windows.Forms.TextBox
        Me.Lbl_TareaPend = New System.Windows.Forms.Label
        Me.Lbl_TareaCanc = New System.Windows.Forms.Label
        Me.Lbl_TareaFin = New System.Windows.Forms.Label
        Me.Tbx_Gris = New System.Windows.Forms.TextBox
        Me.Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Calen = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Calendario1 = New System.Windows.Forms.MonthCalendar
        Me.Gbx_Calendario.SuspendLayout()
        Me.Gbx_Tareas.SuspendLayout()
        Me.Gbx_Leyendas.SuspendLayout()
        Me.Gbx_Calen.SuspendLayout()
        Me.SuspendLayout()
        '
        'DayView
        '
        DrawTool1.DayView = Me.DayView
        Me.DayView.ActiveTool = DrawTool1
        Me.DayView.AllowInplaceEditing = False
        Me.DayView.AllowNew = False
        Me.DayView.AmPmDisplay = False
        Me.DayView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DayView.AppointmentGripWidth = 2
        Me.DayView.AppointmentHeightMode = Calendar.AppHeightDrawMode.TrueHeightAll
        Me.DayView.AppointmentSlotHeight = 30
        Me.DayView.DayGripWidth = 2
        Me.DayView.DayHeadersHeight = 40
        Me.DayView.DaysToShow = 7
        Me.DayView.DrawAllAppBorder = True
        Me.DayView.EnableDurationDisplay = False
        Me.DayView.EnableRoundedCorners = False
        Me.DayView.EnableShadows = False
        Me.DayView.EnableTimeIndicator = True
        Me.DayView.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DayView.HorizontalAppointmentHeight = 30
        Me.DayView.Location = New System.Drawing.Point(6, 49)
        Me.DayView.MinHalfHourApp = False
        Me.DayView.Name = "DayView"
        Me.DayView.SelectionEnd = New Date(CType(0, Long))
        Me.DayView.SelectionStart = New Date(CType(0, Long))
        Me.DayView.Size = New System.Drawing.Size(501, 505)
        Me.DayView.StartDate = New Date(2011, 6, 23, 0, 0, 0, 0)
        Me.DayView.TabIndex = 5
        Me.DayView.WorkingHourEnd = 19
        Me.DayView.WorkingMinuteEnd = 0
        Me.DayView.WorkingMinuteStart = 0
        '
        'Gbx_Calendario
        '
        Me.Gbx_Calendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Calendario.Controls.Add(Me.rdb_Treinta)
        Me.Gbx_Calendario.Controls.Add(Me.rdb_Quince)
        Me.Gbx_Calendario.Controls.Add(Me.rdb_Siete)
        Me.Gbx_Calendario.Controls.Add(Me.rdb_Cinco)
        Me.Gbx_Calendario.Controls.Add(Me.rdb_Tres)
        Me.Gbx_Calendario.Controls.Add(Me.rdb_Uno)
        Me.Gbx_Calendario.Controls.Add(Me.DayView)
        Me.Gbx_Calendario.Location = New System.Drawing.Point(274, 6)
        Me.Gbx_Calendario.Name = "Gbx_Calendario"
        Me.Gbx_Calendario.Size = New System.Drawing.Size(513, 560)
        Me.Gbx_Calendario.TabIndex = 1
        Me.Gbx_Calendario.TabStop = False
        '
        'rdb_Treinta
        '
        Me.rdb_Treinta.AutoSize = True
        Me.rdb_Treinta.Location = New System.Drawing.Point(415, 24)
        Me.rdb_Treinta.Name = "rdb_Treinta"
        Me.rdb_Treinta.Size = New System.Drawing.Size(82, 17)
        Me.rdb_Treinta.TabIndex = 6
        Me.rdb_Treinta.TabStop = True
        Me.rdb_Treinta.Text = "Ver 30 Días"
        Me.rdb_Treinta.UseVisualStyleBackColor = True
        '
        'rdb_Quince
        '
        Me.rdb_Quince.AutoSize = True
        Me.rdb_Quince.Location = New System.Drawing.Point(327, 24)
        Me.rdb_Quince.Name = "rdb_Quince"
        Me.rdb_Quince.Size = New System.Drawing.Size(82, 17)
        Me.rdb_Quince.TabIndex = 4
        Me.rdb_Quince.TabStop = True
        Me.rdb_Quince.Text = "Ver 15 Días"
        Me.rdb_Quince.UseVisualStyleBackColor = True
        '
        'rdb_Siete
        '
        Me.rdb_Siete.AutoSize = True
        Me.rdb_Siete.Checked = True
        Me.rdb_Siete.Location = New System.Drawing.Point(245, 24)
        Me.rdb_Siete.Name = "rdb_Siete"
        Me.rdb_Siete.Size = New System.Drawing.Size(76, 17)
        Me.rdb_Siete.TabIndex = 3
        Me.rdb_Siete.TabStop = True
        Me.rdb_Siete.Text = "Ver 7 Días"
        Me.rdb_Siete.UseVisualStyleBackColor = True
        '
        'rdb_Cinco
        '
        Me.rdb_Cinco.AutoSize = True
        Me.rdb_Cinco.Location = New System.Drawing.Point(163, 24)
        Me.rdb_Cinco.Name = "rdb_Cinco"
        Me.rdb_Cinco.Size = New System.Drawing.Size(76, 17)
        Me.rdb_Cinco.TabIndex = 2
        Me.rdb_Cinco.TabStop = True
        Me.rdb_Cinco.Text = "Ver 5 Días"
        Me.rdb_Cinco.UseVisualStyleBackColor = True
        '
        'rdb_Tres
        '
        Me.rdb_Tres.AutoSize = True
        Me.rdb_Tres.Location = New System.Drawing.Point(81, 24)
        Me.rdb_Tres.Name = "rdb_Tres"
        Me.rdb_Tres.Size = New System.Drawing.Size(76, 17)
        Me.rdb_Tres.TabIndex = 1
        Me.rdb_Tres.TabStop = True
        Me.rdb_Tres.Text = "Ver 3 Días"
        Me.rdb_Tres.UseVisualStyleBackColor = True
        '
        'rdb_Uno
        '
        Me.rdb_Uno.AutoSize = True
        Me.rdb_Uno.Location = New System.Drawing.Point(6, 24)
        Me.rdb_Uno.Name = "rdb_Uno"
        Me.rdb_Uno.Size = New System.Drawing.Size(69, 17)
        Me.rdb_Uno.TabIndex = 0
        Me.rdb_Uno.TabStop = True
        Me.rdb_Uno.Text = "Ver 1 Dia"
        Me.rdb_Uno.UseVisualStyleBackColor = True
        '
        'Gbx_Tareas
        '
        Me.Gbx_Tareas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Tareas.Controls.Add(Me.btn_Todas)
        Me.Gbx_Tareas.Controls.Add(Me.Gbx_Leyendas)
        Me.Gbx_Tareas.Controls.Add(Me.Cerrar)
        Me.Gbx_Tareas.Controls.Add(Me.Gbx_Calen)
        Me.Gbx_Tareas.Controls.Add(Me.Calendario1)
        Me.Gbx_Tareas.Location = New System.Drawing.Point(6, 6)
        Me.Gbx_Tareas.Name = "Gbx_Tareas"
        Me.Gbx_Tareas.Size = New System.Drawing.Size(260, 560)
        Me.Gbx_Tareas.TabIndex = 0
        Me.Gbx_Tareas.TabStop = False
        '
        'btn_Todas
        '
        Me.btn_Todas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Todas.Image = Global.Modulo_Ventas.My.Resources.Resources.AsignaFecha
        Me.btn_Todas.Location = New System.Drawing.Point(60, 257)
        Me.btn_Todas.Name = "btn_Todas"
        Me.btn_Todas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Todas.TabIndex = 4
        Me.btn_Todas.Text = "&Ver Todas(Mes)"
        Me.btn_Todas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Todas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Todas.UseVisualStyleBackColor = True
        '
        'Gbx_Leyendas
        '
        Me.Gbx_Leyendas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Leyendas.Controls.Add(Me.Tbx_Amarrillo)
        Me.Gbx_Leyendas.Controls.Add(Me.Lbl_TareaPosp)
        Me.Gbx_Leyendas.Controls.Add(Me.Tbx_Verde)
        Me.Gbx_Leyendas.Controls.Add(Me.Tbx_Rojo)
        Me.Gbx_Leyendas.Controls.Add(Me.Lbl_TareaPend)
        Me.Gbx_Leyendas.Controls.Add(Me.Lbl_TareaCanc)
        Me.Gbx_Leyendas.Controls.Add(Me.Lbl_TareaFin)
        Me.Gbx_Leyendas.Controls.Add(Me.Tbx_Gris)
        Me.Gbx_Leyendas.Location = New System.Drawing.Point(6, 329)
        Me.Gbx_Leyendas.Name = "Gbx_Leyendas"
        Me.Gbx_Leyendas.Size = New System.Drawing.Size(248, 125)
        Me.Gbx_Leyendas.TabIndex = 3
        Me.Gbx_Leyendas.TabStop = False
        Me.Gbx_Leyendas.Text = "Leyendas"
        '
        'Tbx_Amarrillo
        '
        Me.Tbx_Amarrillo.BackColor = System.Drawing.Color.Khaki
        Me.Tbx_Amarrillo.Location = New System.Drawing.Point(51, 97)
        Me.Tbx_Amarrillo.Name = "Tbx_Amarrillo"
        Me.Tbx_Amarrillo.ReadOnly = True
        Me.Tbx_Amarrillo.Size = New System.Drawing.Size(23, 20)
        Me.Tbx_Amarrillo.TabIndex = 6
        '
        'Lbl_TareaPosp
        '
        Me.Lbl_TareaPosp.AutoSize = True
        Me.Lbl_TareaPosp.Location = New System.Drawing.Point(80, 100)
        Me.Lbl_TareaPosp.Name = "Lbl_TareaPosp"
        Me.Lbl_TareaPosp.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_TareaPosp.TabIndex = 7
        Me.Lbl_TareaPosp.Text = "Tarea Pospuesta"
        '
        'Tbx_Verde
        '
        Me.Tbx_Verde.BackColor = System.Drawing.Color.Green
        Me.Tbx_Verde.Location = New System.Drawing.Point(51, 19)
        Me.Tbx_Verde.Name = "Tbx_Verde"
        Me.Tbx_Verde.ReadOnly = True
        Me.Tbx_Verde.Size = New System.Drawing.Size(23, 20)
        Me.Tbx_Verde.TabIndex = 0
        '
        'Tbx_Rojo
        '
        Me.Tbx_Rojo.BackColor = System.Drawing.Color.Red
        Me.Tbx_Rojo.Location = New System.Drawing.Point(51, 71)
        Me.Tbx_Rojo.Name = "Tbx_Rojo"
        Me.Tbx_Rojo.ReadOnly = True
        Me.Tbx_Rojo.Size = New System.Drawing.Size(23, 20)
        Me.Tbx_Rojo.TabIndex = 4
        '
        'Lbl_TareaPend
        '
        Me.Lbl_TareaPend.AutoSize = True
        Me.Lbl_TareaPend.Location = New System.Drawing.Point(80, 22)
        Me.Lbl_TareaPend.Name = "Lbl_TareaPend"
        Me.Lbl_TareaPend.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_TareaPend.TabIndex = 1
        Me.Lbl_TareaPend.Text = "Tarea Pendiente"
        '
        'Lbl_TareaCanc
        '
        Me.Lbl_TareaCanc.AutoSize = True
        Me.Lbl_TareaCanc.Location = New System.Drawing.Point(80, 74)
        Me.Lbl_TareaCanc.Name = "Lbl_TareaCanc"
        Me.Lbl_TareaCanc.Size = New System.Drawing.Size(89, 13)
        Me.Lbl_TareaCanc.TabIndex = 5
        Me.Lbl_TareaCanc.Text = "Tarea Cancelada"
        '
        'Lbl_TareaFin
        '
        Me.Lbl_TareaFin.AutoSize = True
        Me.Lbl_TareaFin.Location = New System.Drawing.Point(80, 48)
        Me.Lbl_TareaFin.Name = "Lbl_TareaFin"
        Me.Lbl_TareaFin.Size = New System.Drawing.Size(85, 13)
        Me.Lbl_TareaFin.TabIndex = 3
        Me.Lbl_TareaFin.Text = "Tarea Finalizada"
        '
        'Tbx_Gris
        '
        Me.Tbx_Gris.BackColor = System.Drawing.Color.Gray
        Me.Tbx_Gris.Location = New System.Drawing.Point(51, 45)
        Me.Tbx_Gris.Name = "Tbx_Gris"
        Me.Tbx_Gris.ReadOnly = True
        Me.Tbx_Gris.Size = New System.Drawing.Size(23, 20)
        Me.Tbx_Gris.TabIndex = 2
        '
        'Cerrar
        '
        Me.Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Cerrar.Location = New System.Drawing.Point(60, 293)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Cerrar.TabIndex = 2
        Me.Cerrar.Text = "&Cerrar"
        Me.Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Calen
        '
        Me.Gbx_Calen.Controls.Add(Me.Label1)
        Me.Gbx_Calen.Location = New System.Drawing.Point(6, 9)
        Me.Gbx_Calen.Name = "Gbx_Calen"
        Me.Gbx_Calen.Size = New System.Drawing.Size(248, 67)
        Me.Gbx_Calen.TabIndex = 0
        Me.Gbx_Calen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(45, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calendario"
        '
        'Calendario1
        '
        Me.Calendario1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.Calendario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Calendario1.Location = New System.Drawing.Point(8, 83)
        Me.Calendario1.MaxSelectionCount = 1
        Me.Calendario1.Name = "Calendario1"
        Me.Calendario1.TabIndex = 1
        Me.Calendario1.TitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Calendario1.TitleForeColor = System.Drawing.SystemColors.ControlText
        Me.Calendario1.TrailingForeColor = System.Drawing.Color.Transparent
        '
        'frm_Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.Cerrar
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.Gbx_Tareas)
        Me.Controls.Add(Me.Gbx_Calendario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Agenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.Gbx_Calendario.ResumeLayout(False)
        Me.Gbx_Calendario.PerformLayout()
        Me.Gbx_Tareas.ResumeLayout(False)
        Me.Gbx_Leyendas.ResumeLayout(False)
        Me.Gbx_Leyendas.PerformLayout()
        Me.Gbx_Calen.ResumeLayout(False)
        Me.Gbx_Calen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Calendario As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Tareas As System.Windows.Forms.GroupBox
    Friend WithEvents Calendario1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gbx_Calen As System.Windows.Forms.GroupBox
    'Friend WithEvents Ds_Agenda As Modulo_Ventas.ds_Agenda
    Private WithEvents DayView As Calendar.DayView
    Friend WithEvents rdb_Quince As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Siete As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Cinco As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Tres As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Uno As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_TareaPend As System.Windows.Forms.Label
    Friend WithEvents Tbx_Rojo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_TareaCanc As System.Windows.Forms.Label
    Friend WithEvents Tbx_Gris As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_TareaFin As System.Windows.Forms.Label
    Friend WithEvents Tbx_Verde As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_Leyendas As System.Windows.Forms.GroupBox
    Friend WithEvents Tbx_Amarrillo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_TareaPosp As System.Windows.Forms.Label
    Friend WithEvents rdb_Treinta As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Todas As System.Windows.Forms.Button
End Class
