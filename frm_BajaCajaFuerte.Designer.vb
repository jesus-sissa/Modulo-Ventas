<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BajaCajaFuerte
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.lbl_EjecutivoVentas = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_Baja = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.dtp_Baja = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 195)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(528, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cancelar.Location = New System.Drawing.Point(382, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(47, 52)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 3
        Me.lbl_Fecha.Text = "Fecha"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(6, 75)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 6
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'lbl_EjecutivoVentas
        '
        Me.lbl_EjecutivoVentas.AutoSize = True
        Me.lbl_EjecutivoVentas.Location = New System.Drawing.Point(6, 22)
        Me.lbl_EjecutivoVentas.Name = "lbl_EjecutivoVentas"
        Me.lbl_EjecutivoVentas.Size = New System.Drawing.Size(78, 13)
        Me.lbl_EjecutivoVentas.TabIndex = 0
        Me.lbl_EjecutivoVentas.Text = "Motivo de Baja"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_Datos.Controls.Add(Me.Label2)
        Me.gbx_Datos.Controls.Add(Me.cmb_Baja)
        Me.gbx_Datos.Controls.Add(Me.Label1)
        Me.gbx_Datos.Controls.Add(Me.Label6)
        Me.gbx_Datos.Controls.Add(Me.dtp_Baja)
        Me.gbx_Datos.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_EjecutivoVentas)
        Me.gbx_Datos.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_Datos.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(527, 190)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(90, 72)
        Me.rtb_Observaciones.MaxLength = 5000
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(396, 104)
        Me.rtb_Observaciones.TabIndex = 7
        Me.rtb_Observaciones.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(492, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "*"
        '
        'cmb_Baja
        '
        Me.cmb_Baja.Clave = Nothing
        Me.cmb_Baja.Control_Siguiente = Me.dtp_Baja
        Me.cmb_Baja.DisplayMember = "Descripcion"
        Me.cmb_Baja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Baja.Empresa = False
        Me.cmb_Baja.Filtro = Nothing
        Me.cmb_Baja.FormattingEnabled = True
        Me.cmb_Baja.Location = New System.Drawing.Point(90, 19)
        Me.cmb_Baja.MaxDropDownItems = 20
        Me.cmb_Baja.Name = "cmb_Baja"
        Me.cmb_Baja.Pista = False
        Me.cmb_Baja.Size = New System.Drawing.Size(396, 21)
        Me.cmb_Baja.StoredProcedure = "Cat_MotivosBajaCombo_Get"
        Me.cmb_Baja.Sucursal = False
        Me.cmb_Baja.TabIndex = 1
        Me.cmb_Baja.Tipo = 0
        Me.cmb_Baja.ValueMember = "Id_MotivoB"
        '
        'dtp_Baja
        '
        Me.dtp_Baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Baja.Location = New System.Drawing.Point(90, 46)
        Me.dtp_Baja.Name = "dtp_Baja"
        Me.dtp_Baja.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Baja.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(492, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(191, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "*"
        '
        'frm_BajaCajaFuerte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 251)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 280)
        Me.Name = "frm_BajaCajaFuerte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lbl_EjecutivoVentas As System.Windows.Forms.Label
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_Baja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Baja As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
End Class
