<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TEFModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TEFModal))
        Me.gbx_Agregar = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_A = New System.Windows.Forms.Label
        Me.cmb_A = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_De = New System.Windows.Forms.Label
        Me.cmb_De = New Modulo_Ventas.cp_cmb_Manual
        Me.cmb_Frecuencia = New Modulo_Ventas.cp_cmb_Manual
        Me.lbl_Frecuencia = New System.Windows.Forms.Label
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.cmb_Tipo = New Modulo_Ventas.cp_cmb_Manual
        Me.Btn_CancelarH = New System.Windows.Forms.Button
        Me.Btn_GuardarH = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.gbx_Agregar.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Agregar
        '
        Me.gbx_Agregar.Controls.Add(Me.Label2)
        Me.gbx_Agregar.Controls.Add(Me.Label1)
        Me.gbx_Agregar.Controls.Add(Me.Label11)
        Me.gbx_Agregar.Controls.Add(Me.lbl_A)
        Me.gbx_Agregar.Controls.Add(Me.cmb_A)
        Me.gbx_Agregar.Controls.Add(Me.lbl_De)
        Me.gbx_Agregar.Controls.Add(Me.cmb_De)
        Me.gbx_Agregar.Controls.Add(Me.cmb_Frecuencia)
        Me.gbx_Agregar.Controls.Add(Me.lbl_Frecuencia)
        Me.gbx_Agregar.Controls.Add(Me.lbl_Tipo)
        Me.gbx_Agregar.Controls.Add(Me.cmb_Tipo)
        Me.gbx_Agregar.Location = New System.Drawing.Point(7, 7)
        Me.gbx_Agregar.Name = "gbx_Agregar"
        Me.gbx_Agregar.Size = New System.Drawing.Size(381, 109)
        Me.gbx_Agregar.TabIndex = 0
        Me.gbx_Agregar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(311, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(332, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(332, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "*"
        '
        'lbl_A
        '
        Me.lbl_A.AutoSize = True
        Me.lbl_A.Location = New System.Drawing.Point(193, 77)
        Me.lbl_A.Name = "lbl_A"
        Me.lbl_A.Size = New System.Drawing.Size(17, 13)
        Me.lbl_A.TabIndex = 6
        Me.lbl_A.Text = "A:"
        '
        'cmb_A
        '
        Me.cmb_A.Control_Siguiente = Nothing
        Me.cmb_A.DisplayMember = "display"
        Me.cmb_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_A.FormattingEnabled = True
        Me.cmb_A.Location = New System.Drawing.Point(216, 74)
        Me.cmb_A.MaxDropDownItems = 20
        Me.cmb_A.Name = "cmb_A"
        Me.cmb_A.Size = New System.Drawing.Size(89, 21)
        Me.cmb_A.TabIndex = 7
        Me.cmb_A.ValueMember = "value"
        '
        'lbl_De
        '
        Me.lbl_De.AutoSize = True
        Me.lbl_De.Location = New System.Drawing.Point(68, 77)
        Me.lbl_De.Name = "lbl_De"
        Me.lbl_De.Size = New System.Drawing.Size(24, 13)
        Me.lbl_De.TabIndex = 4
        Me.lbl_De.Text = "De:"
        '
        'cmb_De
        '
        Me.cmb_De.Control_Siguiente = Nothing
        Me.cmb_De.DisplayMember = "display"
        Me.cmb_De.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_De.FormattingEnabled = True
        Me.cmb_De.Location = New System.Drawing.Point(98, 74)
        Me.cmb_De.MaxDropDownItems = 20
        Me.cmb_De.Name = "cmb_De"
        Me.cmb_De.Size = New System.Drawing.Size(89, 21)
        Me.cmb_De.TabIndex = 5
        Me.cmb_De.ValueMember = "value"
        '
        'cmb_Frecuencia
        '
        Me.cmb_Frecuencia.Control_Siguiente = Nothing
        Me.cmb_Frecuencia.DisplayMember = "display"
        Me.cmb_Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Frecuencia.FormattingEnabled = True
        Me.cmb_Frecuencia.Location = New System.Drawing.Point(98, 47)
        Me.cmb_Frecuencia.MaxDropDownItems = 12
        Me.cmb_Frecuencia.Name = "cmb_Frecuencia"
        Me.cmb_Frecuencia.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Frecuencia.TabIndex = 3
        Me.cmb_Frecuencia.ValueMember = "value"
        '
        'lbl_Frecuencia
        '
        Me.lbl_Frecuencia.AutoSize = True
        Me.lbl_Frecuencia.Location = New System.Drawing.Point(32, 50)
        Me.lbl_Frecuencia.Name = "lbl_Frecuencia"
        Me.lbl_Frecuencia.Size = New System.Drawing.Size(60, 13)
        Me.lbl_Frecuencia.TabIndex = 2
        Me.lbl_Frecuencia.Text = "Frecuencia"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(64, 23)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Tipo.TabIndex = 0
        Me.lbl_Tipo.Text = "Tipo"
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(98, 20)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Tipo.TabIndex = 1
        Me.cmb_Tipo.ValueMember = "value"
        '
        'Btn_CancelarH
        '
        Me.Btn_CancelarH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CancelarH.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_CancelarH.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.Btn_CancelarH.Location = New System.Drawing.Point(235, 13)
        Me.Btn_CancelarH.Name = "Btn_CancelarH"
        Me.Btn_CancelarH.Size = New System.Drawing.Size(140, 30)
        Me.Btn_CancelarH.TabIndex = 1
        Me.Btn_CancelarH.Text = "&Cancelar"
        Me.Btn_CancelarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CancelarH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_CancelarH.UseVisualStyleBackColor = True
        '
        'Btn_GuardarH
        '
        Me.Btn_GuardarH.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.Btn_GuardarH.Location = New System.Drawing.Point(8, 13)
        Me.Btn_GuardarH.Name = "Btn_GuardarH"
        Me.Btn_GuardarH.Size = New System.Drawing.Size(140, 30)
        Me.Btn_GuardarH.TabIndex = 0
        Me.Btn_GuardarH.Text = "&Guardar"
        Me.Btn_GuardarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_GuardarH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_GuardarH.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.Btn_CancelarH)
        Me.Gbx_Botones.Controls.Add(Me.Btn_GuardarH)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 122)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(381, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'frm_TEFModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_CancelarH
        Me.ClientSize = New System.Drawing.Size(394, 181)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 210)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 210)
        Me.Name = "frm_TEFModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios"
        Me.gbx_Agregar.ResumeLayout(False)
        Me.gbx_Agregar.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Agregar As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_GuardarH As System.Windows.Forms.Button
    Friend WithEvents Btn_CancelarH As System.Windows.Forms.Button
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_Frecuencia As System.Windows.Forms.Label
    Friend WithEvents cmb_Frecuencia As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents cmb_De As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents lbl_De As System.Windows.Forms.Label
    Friend WithEvents lbl_A As System.Windows.Forms.Label
    Friend WithEvents cmb_A As Modulo_Ventas.cp_cmb_Manual
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
