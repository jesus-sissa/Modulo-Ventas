<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ContactosModal
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
        Me.lbl_Ejecutivo = New System.Windows.Forms.Label
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.cmb_Ejecutivo = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.SuspendLayout()
        '
        'lbl_Ejecutivo
        '
        Me.lbl_Ejecutivo.AutoSize = True
        Me.lbl_Ejecutivo.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Ejecutivo.Name = "lbl_Ejecutivo"
        Me.lbl_Ejecutivo.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Ejecutivo.TabIndex = 1
        Me.lbl_Ejecutivo.Text = "Ejecutivo"
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(69, 39)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(277, 39)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 3
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'cmb_Ejecutivo
        '
        Me.cmb_Ejecutivo.Clave = Nothing
        Me.cmb_Ejecutivo.Control_Siguiente = Nothing
        Me.cmb_Ejecutivo.DisplayMember = "Nombre"
        Me.cmb_Ejecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ejecutivo.Empresa = False
        Me.cmb_Ejecutivo.Filtro = Nothing
        Me.cmb_Ejecutivo.FormattingEnabled = True
        Me.cmb_Ejecutivo.Location = New System.Drawing.Point(69, 12)
        Me.cmb_Ejecutivo.MaxDropDownItems = 20
        Me.cmb_Ejecutivo.Name = "cmb_Ejecutivo"
        Me.cmb_Ejecutivo.Pista = True
        Me.cmb_Ejecutivo.Size = New System.Drawing.Size(283, 21)
        Me.cmb_Ejecutivo.StoredProcedure = "Cat_ClientesContactos_Get"
        Me.cmb_Ejecutivo.Sucursal = False
        Me.cmb_Ejecutivo.TabIndex = 6
        Me.cmb_Ejecutivo.Tipo = 0
        Me.cmb_Ejecutivo.ValueMember = "Id_Contacto"
        '
        'frm_ContactosModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 71)
        Me.Controls.Add(Me.cmb_Ejecutivo)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.lbl_Ejecutivo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(380, 110)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(380, 110)
        Me.Name = "frm_ContactosModal"
        Me.Text = "Seleccione Contacto..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Ejecutivo As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_Ejecutivo As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
End Class
