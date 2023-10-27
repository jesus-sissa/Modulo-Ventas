<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CapturarDestino
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
        Me.gbx_DatosComerciales = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_Zona = New System.Windows.Forms.Label
        Me.lbl_Ciudad = New System.Windows.Forms.Label
        Me.cmb_Zona = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.cmb_Ciudad = New Modulo_Ventas.cp_cmb_SimpleFiltradoParam
        Me.lbl_Colonia = New System.Windows.Forms.Label
        Me.tbx_Colonia = New Modulo_Ventas.cp_Textbox
        Me.lbl_NumeroInt = New System.Windows.Forms.Label
        Me.tbx_NumeroInt = New Modulo_Ventas.cp_Textbox
        Me.lbl_Numero = New System.Windows.Forms.Label
        Me.tbx_Numero = New Modulo_Ventas.cp_Textbox
        Me.tbx_Calle = New Modulo_Ventas.cp_Textbox
        Me.lbl_Calle = New System.Windows.Forms.Label
        Me.tbx_Nombre = New Modulo_Ventas.cp_Textbox
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.gbx_DatosComerciales.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_DatosComerciales
        '
        Me.gbx_DatosComerciales.Controls.Add(Me.Label5)
        Me.gbx_DatosComerciales.Controls.Add(Me.Label4)
        Me.gbx_DatosComerciales.Controls.Add(Me.Label3)
        Me.gbx_DatosComerciales.Controls.Add(Me.Label2)
        Me.gbx_DatosComerciales.Controls.Add(Me.Label1)
        Me.gbx_DatosComerciales.Controls.Add(Me.Label11)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Zona)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Ciudad)
        Me.gbx_DatosComerciales.Controls.Add(Me.cmb_Zona)
        Me.gbx_DatosComerciales.Controls.Add(Me.cmb_Ciudad)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Colonia)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_Colonia)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_NumeroInt)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_NumeroInt)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Numero)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_Numero)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_Calle)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Calle)
        Me.gbx_DatosComerciales.Controls.Add(Me.tbx_Nombre)
        Me.gbx_DatosComerciales.Controls.Add(Me.lbl_Nombre)
        Me.gbx_DatosComerciales.Location = New System.Drawing.Point(5, 0)
        Me.gbx_DatosComerciales.Name = "gbx_DatosComerciales"
        Me.gbx_DatosComerciales.Size = New System.Drawing.Size(504, 215)
        Me.gbx_DatosComerciales.TabIndex = 0
        Me.gbx_DatosComerciales.TabStop = False
        Me.gbx_DatosComerciales.Text = "Datos Comerciales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(314, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(314, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(486, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(196, 77)
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
        Me.Label1.Location = New System.Drawing.Point(486, 51)
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
        Me.Label11.Location = New System.Drawing.Point(486, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "*"
        '
        'lbl_Zona
        '
        Me.lbl_Zona.AutoSize = True
        Me.lbl_Zona.Location = New System.Drawing.Point(40, 185)
        Me.lbl_Zona.Name = "lbl_Zona"
        Me.lbl_Zona.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Zona.TabIndex = 12
        Me.lbl_Zona.Text = "Zona"
        '
        'lbl_Ciudad
        '
        Me.lbl_Ciudad.AutoSize = True
        Me.lbl_Ciudad.Location = New System.Drawing.Point(34, 157)
        Me.lbl_Ciudad.Name = "lbl_Ciudad"
        Me.lbl_Ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Ciudad.TabIndex = 10
        Me.lbl_Ciudad.Text = "Ciudad"
        '
        'cmb_Zona
        '
        Me.cmb_Zona.Clave = Nothing
        Me.cmb_Zona.Control_Siguiente = Nothing
        Me.cmb_Zona.DisplayMember = "Nombre"
        Me.cmb_Zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Zona.Empresa = False
        Me.cmb_Zona.Filtro = Nothing
        Me.cmb_Zona.FormattingEnabled = True
        Me.cmb_Zona.Location = New System.Drawing.Point(80, 182)
        Me.cmb_Zona.MaxDropDownItems = 20
        Me.cmb_Zona.Name = "cmb_Zona"
        Me.cmb_Zona.Pista = True
        Me.cmb_Zona.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Zona.StoredProcedure = "Cat_ZonasCiudades_Get"
        Me.cmb_Zona.Sucursal = False
        Me.cmb_Zona.TabIndex = 13
        Me.cmb_Zona.Tipo = 0
        Me.cmb_Zona.ValueMember = "Id_Zona"
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.Clave = Nothing
        Me.cmb_Ciudad.Control_Siguiente = Nothing
        Me.cmb_Ciudad.DisplayMember = "Nombre"
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Empresa = False
        Me.cmb_Ciudad.Filtro = Nothing
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(80, 155)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = False
        Me.cmb_Ciudad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 11
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'lbl_Colonia
        '
        Me.lbl_Colonia.AutoSize = True
        Me.lbl_Colonia.Location = New System.Drawing.Point(30, 132)
        Me.lbl_Colonia.Name = "lbl_Colonia"
        Me.lbl_Colonia.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Colonia.TabIndex = 8
        Me.lbl_Colonia.Text = "Colonia"
        '
        'tbx_Colonia
        '
        Me.tbx_Colonia.Control_Siguiente = Nothing
        Me.tbx_Colonia.Filtrado = True
        Me.tbx_Colonia.Location = New System.Drawing.Point(80, 129)
        Me.tbx_Colonia.MaxLength = 50
        Me.tbx_Colonia.Name = "tbx_Colonia"
        Me.tbx_Colonia.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Colonia.TabIndex = 9
        Me.tbx_Colonia.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_NumeroInt
        '
        Me.lbl_NumeroInt.AutoSize = True
        Me.lbl_NumeroInt.Location = New System.Drawing.Point(10, 106)
        Me.lbl_NumeroInt.Name = "lbl_NumeroInt"
        Me.lbl_NumeroInt.Size = New System.Drawing.Size(62, 13)
        Me.lbl_NumeroInt.TabIndex = 6
        Me.lbl_NumeroInt.Text = "Numero Int."
        '
        'tbx_NumeroInt
        '
        Me.tbx_NumeroInt.Control_Siguiente = Nothing
        Me.tbx_NumeroInt.Filtrado = True
        Me.tbx_NumeroInt.Location = New System.Drawing.Point(80, 103)
        Me.tbx_NumeroInt.MaxLength = 50
        Me.tbx_NumeroInt.Name = "tbx_NumeroInt"
        Me.tbx_NumeroInt.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroInt.TabIndex = 7
        Me.tbx_NumeroInt.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Numero
        '
        Me.lbl_Numero.AutoSize = True
        Me.lbl_Numero.Location = New System.Drawing.Point(28, 80)
        Me.lbl_Numero.Name = "lbl_Numero"
        Me.lbl_Numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Numero.TabIndex = 4
        Me.lbl_Numero.Text = "Numero"
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Nothing
        Me.tbx_Numero.Filtrado = True
        Me.tbx_Numero.Location = New System.Drawing.Point(80, 77)
        Me.tbx_Numero.MaxLength = 20
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Numero.TabIndex = 5
        Me.tbx_Numero.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Calle
        '
        Me.tbx_Calle.Control_Siguiente = Nothing
        Me.tbx_Calle.Filtrado = True
        Me.tbx_Calle.Location = New System.Drawing.Point(80, 51)
        Me.tbx_Calle.MaxLength = 50
        Me.tbx_Calle.Name = "tbx_Calle"
        Me.tbx_Calle.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Calle.TabIndex = 3
        Me.tbx_Calle.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Calle
        '
        Me.lbl_Calle.AutoSize = True
        Me.lbl_Calle.Location = New System.Drawing.Point(42, 54)
        Me.lbl_Calle.Name = "lbl_Calle"
        Me.lbl_Calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Calle.TabIndex = 2
        Me.lbl_Calle.Text = "Calle"
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.Control_Siguiente = Nothing
        Me.tbx_Nombre.Filtrado = True
        Me.tbx_Nombre.Location = New System.Drawing.Point(80, 25)
        Me.tbx_Nombre.MaxLength = 150
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Nombre.TabIndex = 1
        Me.tbx_Nombre.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(30, 28)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Ventas.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 14
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(350, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 217)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(504, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'frm_CapturarDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 271)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_DatosComerciales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 300)
        Me.Name = "frm_CapturarDestino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capturar Destino"
        Me.gbx_DatosComerciales.ResumeLayout(False)
        Me.gbx_DatosComerciales.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_DatosComerciales As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_NumeroInt As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Numero As System.Windows.Forms.Label
    Friend WithEvents tbx_Numero As Modulo_Ventas.cp_Textbox
    Friend WithEvents tbx_Calle As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Calle As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombre As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Colonia As System.Windows.Forms.Label
    Friend WithEvents tbx_Colonia As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_NumeroInt As System.Windows.Forms.Label
    Friend WithEvents lbl_Zona As System.Windows.Forms.Label
    Friend WithEvents lbl_Ciudad As System.Windows.Forms.Label
    Friend WithEvents cmb_Zona As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Ciudad As Modulo_Ventas.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
End Class
