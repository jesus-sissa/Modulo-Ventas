<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReasignarCodigoPostal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.btn_ValidarCodigoPostal = New System.Windows.Forms.Button()
        Me.lbl_Error = New System.Windows.Forms.Label()
        Me.lbl_EstatusBusqueda = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lbl_TituloEstado = New System.Windows.Forms.Label()
        Me.lbl_TituloPais = New System.Windows.Forms.Label()
        Me.lbl_TituloCiudad = New System.Windows.Forms.Label()
        Me.cmb_Ciudades = New System.Windows.Forms.ComboBox()
        Me.btn_ReasignarCP = New System.Windows.Forms.Button()
        Me.lbl_TituloCP = New System.Windows.Forms.Label()
        Me.lbl_CP = New System.Windows.Forms.Label()
        Me.lbl_Aviso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(272, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'tbx_CodigoPostal
        '
        Me.tbx_CodigoPostal.Enabled = False
        Me.tbx_CodigoPostal.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.tbx_CodigoPostal.Location = New System.Drawing.Point(43, 76)
        Me.tbx_CodigoPostal.MaxLength = 6
        Me.tbx_CodigoPostal.Name = "tbx_CodigoPostal"
        Me.tbx_CodigoPostal.Size = New System.Drawing.Size(223, 23)
        Me.tbx_CodigoPostal.TabIndex = 9
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(101, 57)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(96, 16)
        Me.lbl_CodigoPostal.TabIndex = 8
        Me.lbl_CodigoPostal.Text = "Codigo Postal"
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(45, 9)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(221, 22)
        Me.lbl_Titulo.TabIndex = 7
        Me.lbl_Titulo.Text = "Reasignar Codigo Postal"
        '
        'btn_ValidarCodigoPostal
        '
        Me.btn_ValidarCodigoPostal.Image = Global.Modulo_Ventas.My.Resources.Resources.Actualizar_VerdeAzul
        Me.btn_ValidarCodigoPostal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ValidarCodigoPostal.Location = New System.Drawing.Point(104, 117)
        Me.btn_ValidarCodigoPostal.Name = "btn_ValidarCodigoPostal"
        Me.btn_ValidarCodigoPostal.Size = New System.Drawing.Size(84, 32)
        Me.btn_ValidarCodigoPostal.TabIndex = 11
        Me.btn_ValidarCodigoPostal.Text = "Validar"
        Me.btn_ValidarCodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ValidarCodigoPostal.UseVisualStyleBackColor = True
        '
        'lbl_Error
        '
        Me.lbl_Error.AutoSize = True
        Me.lbl_Error.ForeColor = System.Drawing.Color.Red
        Me.lbl_Error.Location = New System.Drawing.Point(46, 102)
        Me.lbl_Error.Name = "lbl_Error"
        Me.lbl_Error.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Error.TabIndex = 12
        Me.lbl_Error.Text = "Error"
        '
        'lbl_EstatusBusqueda
        '
        Me.lbl_EstatusBusqueda.AutoSize = True
        Me.lbl_EstatusBusqueda.Font = New System.Drawing.Font("Microsoft YaHei", 7.75!)
        Me.lbl_EstatusBusqueda.ForeColor = System.Drawing.Color.Red
        Me.lbl_EstatusBusqueda.Location = New System.Drawing.Point(31, 152)
        Me.lbl_EstatusBusqueda.Name = "lbl_EstatusBusqueda"
        Me.lbl_EstatusBusqueda.Size = New System.Drawing.Size(101, 16)
        Me.lbl_EstatusBusqueda.TabIndex = 13
        Me.lbl_EstatusBusqueda.Text = """statusBusqueda"""
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.ForeColor = System.Drawing.Color.Green
        Me.lblEstado.Location = New System.Drawing.Point(98, 203)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(57, 16)
        Me.lblEstado.TabIndex = 20
        Me.lblEstado.Text = "Estado"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPais.ForeColor = System.Drawing.Color.Green
        Me.lblPais.Location = New System.Drawing.Point(80, 178)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(39, 16)
        Me.lblPais.TabIndex = 19
        Me.lblPais.Text = "Pais"
        '
        'lbl_TituloEstado
        '
        Me.lbl_TituloEstado.AutoSize = True
        Me.lbl_TituloEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloEstado.Location = New System.Drawing.Point(31, 203)
        Me.lbl_TituloEstado.Name = "lbl_TituloEstado"
        Me.lbl_TituloEstado.Size = New System.Drawing.Size(61, 16)
        Me.lbl_TituloEstado.TabIndex = 18
        Me.lbl_TituloEstado.Text = "Estado:"
        '
        'lbl_TituloPais
        '
        Me.lbl_TituloPais.AutoSize = True
        Me.lbl_TituloPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloPais.Location = New System.Drawing.Point(31, 178)
        Me.lbl_TituloPais.Name = "lbl_TituloPais"
        Me.lbl_TituloPais.Size = New System.Drawing.Size(43, 16)
        Me.lbl_TituloPais.TabIndex = 17
        Me.lbl_TituloPais.Text = "Pais:"
        '
        'lbl_TituloCiudad
        '
        Me.lbl_TituloCiudad.AutoSize = True
        Me.lbl_TituloCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloCiudad.Location = New System.Drawing.Point(31, 254)
        Me.lbl_TituloCiudad.Name = "lbl_TituloCiudad"
        Me.lbl_TituloCiudad.Size = New System.Drawing.Size(61, 16)
        Me.lbl_TituloCiudad.TabIndex = 21
        Me.lbl_TituloCiudad.Text = "Ciudad:"
        '
        'cmb_Ciudades
        '
        Me.cmb_Ciudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudades.FormattingEnabled = True
        Me.cmb_Ciudades.Location = New System.Drawing.Point(98, 249)
        Me.cmb_Ciudades.Name = "cmb_Ciudades"
        Me.cmb_Ciudades.Size = New System.Drawing.Size(154, 21)
        Me.cmb_Ciudades.TabIndex = 22
        '
        'btn_ReasignarCP
        '
        Me.btn_ReasignarCP.Image = Global.Modulo_Ventas.My.Resources.Resources.Actualizar
        Me.btn_ReasignarCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ReasignarCP.Location = New System.Drawing.Point(104, 319)
        Me.btn_ReasignarCP.Name = "btn_ReasignarCP"
        Me.btn_ReasignarCP.Size = New System.Drawing.Size(84, 32)
        Me.btn_ReasignarCP.TabIndex = 23
        Me.btn_ReasignarCP.Text = "Reasignar"
        Me.btn_ReasignarCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ReasignarCP.UseVisualStyleBackColor = True
        '
        'lbl_TituloCP
        '
        Me.lbl_TituloCP.AutoSize = True
        Me.lbl_TituloCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloCP.Location = New System.Drawing.Point(31, 228)
        Me.lbl_TituloCP.Name = "lbl_TituloCP"
        Me.lbl_TituloCP.Size = New System.Drawing.Size(76, 16)
        Me.lbl_TituloCP.TabIndex = 24
        Me.lbl_TituloCP.Text = "Codigo P:"
        '
        'lbl_CP
        '
        Me.lbl_CP.AutoSize = True
        Me.lbl_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_CP.ForeColor = System.Drawing.Color.Green
        Me.lbl_CP.Location = New System.Drawing.Point(113, 228)
        Me.lbl_CP.Name = "lbl_CP"
        Me.lbl_CP.Size = New System.Drawing.Size(32, 16)
        Me.lbl_CP.TabIndex = 25
        Me.lbl_CP.Text = "000"
        '
        'lbl_Aviso
        '
        Me.lbl_Aviso.AutoSize = True
        Me.lbl_Aviso.ForeColor = System.Drawing.Color.Red
        Me.lbl_Aviso.Location = New System.Drawing.Point(40, 282)
        Me.lbl_Aviso.Name = "lbl_Aviso"
        Me.lbl_Aviso.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Aviso.TabIndex = 26
        Me.lbl_Aviso.Text = "Aviso"
        '
        'frm_ReasignarCodigoPostal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 450)
        Me.Controls.Add(Me.lbl_Aviso)
        Me.Controls.Add(Me.lbl_CP)
        Me.Controls.Add(Me.lbl_TituloCP)
        Me.Controls.Add(Me.btn_ReasignarCP)
        Me.Controls.Add(Me.cmb_Ciudades)
        Me.Controls.Add(Me.lbl_TituloCiudad)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lbl_TituloEstado)
        Me.Controls.Add(Me.lbl_TituloPais)
        Me.Controls.Add(Me.lbl_EstatusBusqueda)
        Me.Controls.Add(Me.lbl_Error)
        Me.Controls.Add(Me.btn_ValidarCodigoPostal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_CodigoPostal)
        Me.Controls.Add(Me.lbl_CodigoPostal)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_ReasignarCodigoPostal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reasignar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Public WithEvents tbx_CodigoPostal As TextBox
    Friend WithEvents lbl_CodigoPostal As Label
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents btn_ValidarCodigoPostal As Button
    Friend WithEvents lbl_Error As Label
    Friend WithEvents lbl_EstatusBusqueda As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lbl_TituloEstado As Label
    Friend WithEvents lbl_TituloPais As Label
    Friend WithEvents lbl_TituloCiudad As Label
    Friend WithEvents cmb_Ciudades As ComboBox
    Friend WithEvents btn_ReasignarCP As Button
    Friend WithEvents lbl_TituloCP As Label
    Friend WithEvents lbl_CP As Label
    Friend WithEvents lbl_Aviso As Label
End Class
