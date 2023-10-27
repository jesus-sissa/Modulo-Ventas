<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaWeb
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
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Datos = New Modulo_Ventas.cp_Listview
        Me.Gbx_Datos = New System.Windows.Forms.GroupBox
        Me.tbx_Mensaje = New System.Windows.Forms.TextBox
        Me.Lbl_Mensaje = New System.Windows.Forms.Label
        Me.tbx_Empresa = New System.Windows.Forms.TextBox
        Me.Lbl_Empresa = New System.Windows.Forms.Label
        Me.tbx_Telefono = New System.Windows.Forms.TextBox
        Me.Lbl_Telefono = New System.Windows.Forms.Label
        Me.tbx_Mail = New System.Windows.Forms.TextBox
        Me.Lbl_Mail = New System.Windows.Forms.Label
        Me.tbx_Apellido = New System.Windows.Forms.TextBox
        Me.Lbl_Apellido = New System.Windows.Forms.Label
        Me.tbx_Nombre = New System.Windows.Forms.TextBox
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.tbx_Fecha = New System.Windows.Forms.TextBox
        Me.Lbl_Fecha = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Actualizar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Datos.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.lsv_Datos)
        Me.Gbx_Listado.Location = New System.Drawing.Point(7, 10)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(771, 231)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(625, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 17)
        Me.lbl_Registros.TabIndex = 29
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 10
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 10
        Me.lsv_Datos.Row3 = 10
        Me.lsv_Datos.Row4 = 20
        Me.lsv_Datos.Row5 = 10
        Me.lsv_Datos.Row6 = 20
        Me.lsv_Datos.Row7 = 30
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(759, 189)
        Me.lsv_Datos.TabIndex = 0
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'Gbx_Datos
        '
        Me.Gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Mensaje)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Mensaje)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Empresa)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Empresa)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Telefono)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Telefono)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Mail)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Mail)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Apellido)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Apellido)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Nombre)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Nombre)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Fecha)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Fecha)
        Me.Gbx_Datos.Location = New System.Drawing.Point(7, 247)
        Me.Gbx_Datos.Name = "Gbx_Datos"
        Me.Gbx_Datos.Size = New System.Drawing.Size(771, 291)
        Me.Gbx_Datos.TabIndex = 2
        Me.Gbx_Datos.TabStop = False
        Me.Gbx_Datos.Text = "Detalle"
        '
        'tbx_Mensaje
        '
        Me.tbx_Mensaje.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Mensaje.Location = New System.Drawing.Point(74, 181)
        Me.tbx_Mensaje.Multiline = True
        Me.tbx_Mensaje.Name = "tbx_Mensaje"
        Me.tbx_Mensaje.ReadOnly = True
        Me.tbx_Mensaje.Size = New System.Drawing.Size(547, 104)
        Me.tbx_Mensaje.TabIndex = 3
        '
        'Lbl_Mensaje
        '
        Me.Lbl_Mensaje.AutoSize = True
        Me.Lbl_Mensaje.Location = New System.Drawing.Point(21, 184)
        Me.Lbl_Mensaje.Name = "Lbl_Mensaje"
        Me.Lbl_Mensaje.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_Mensaje.TabIndex = 2
        Me.Lbl_Mensaje.Text = "Mensaje"
        '
        'tbx_Empresa
        '
        Me.tbx_Empresa.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Empresa.Location = New System.Drawing.Point(74, 155)
        Me.tbx_Empresa.Name = "tbx_Empresa"
        Me.tbx_Empresa.ReadOnly = True
        Me.tbx_Empresa.Size = New System.Drawing.Size(547, 20)
        Me.tbx_Empresa.TabIndex = 3
        '
        'Lbl_Empresa
        '
        Me.Lbl_Empresa.AutoSize = True
        Me.Lbl_Empresa.Location = New System.Drawing.Point(20, 158)
        Me.Lbl_Empresa.Name = "Lbl_Empresa"
        Me.Lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.Lbl_Empresa.TabIndex = 2
        Me.Lbl_Empresa.Text = "Empresa"
        '
        'tbx_Telefono
        '
        Me.tbx_Telefono.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Telefono.Location = New System.Drawing.Point(74, 129)
        Me.tbx_Telefono.Name = "tbx_Telefono"
        Me.tbx_Telefono.ReadOnly = True
        Me.tbx_Telefono.Size = New System.Drawing.Size(241, 20)
        Me.tbx_Telefono.TabIndex = 3
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(19, 132)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Telefono.TabIndex = 2
        Me.Lbl_Telefono.Text = "Teléfono"
        '
        'tbx_Mail
        '
        Me.tbx_Mail.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Mail.Location = New System.Drawing.Point(74, 103)
        Me.tbx_Mail.Name = "tbx_Mail"
        Me.tbx_Mail.ReadOnly = True
        Me.tbx_Mail.Size = New System.Drawing.Size(334, 20)
        Me.tbx_Mail.TabIndex = 3
        '
        'Lbl_Mail
        '
        Me.Lbl_Mail.AutoSize = True
        Me.Lbl_Mail.Location = New System.Drawing.Point(42, 106)
        Me.Lbl_Mail.Name = "Lbl_Mail"
        Me.Lbl_Mail.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Mail.TabIndex = 2
        Me.Lbl_Mail.Text = "Mail"
        '
        'tbx_Apellido
        '
        Me.tbx_Apellido.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Apellido.Location = New System.Drawing.Point(74, 77)
        Me.tbx_Apellido.Name = "tbx_Apellido"
        Me.tbx_Apellido.ReadOnly = True
        Me.tbx_Apellido.Size = New System.Drawing.Size(241, 20)
        Me.tbx_Apellido.TabIndex = 3
        '
        'Lbl_Apellido
        '
        Me.Lbl_Apellido.AutoSize = True
        Me.Lbl_Apellido.Location = New System.Drawing.Point(24, 80)
        Me.Lbl_Apellido.Name = "Lbl_Apellido"
        Me.Lbl_Apellido.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Apellido.TabIndex = 2
        Me.Lbl_Apellido.Text = "Apellido"
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Nombre.Location = New System.Drawing.Point(74, 51)
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.ReadOnly = True
        Me.tbx_Nombre.Size = New System.Drawing.Size(241, 20)
        Me.tbx_Nombre.TabIndex = 3
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(24, 54)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Nombre.TabIndex = 2
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'tbx_Fecha
        '
        Me.tbx_Fecha.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Fecha.Location = New System.Drawing.Point(74, 25)
        Me.tbx_Fecha.Name = "tbx_Fecha"
        Me.tbx_Fecha.ReadOnly = True
        Me.tbx_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.tbx_Fecha.TabIndex = 1
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(31, 28)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Fecha.TabIndex = 0
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Actualizar)
        Me.Gbx_Botones.Controls.Add(Me.BTN_Exportar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 544)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(771, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Ventas.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(625, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 16
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Actualizar.Image = Global.Modulo_Ventas.My.Resources.Resources.agt_reload
        Me.btn_Actualizar.Location = New System.Drawing.Point(152, 14)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Actualizar.TabIndex = 15
        Me.btn_Actualizar.Text = "&Actualizar"
        Me.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Enabled = False
        Me.BTN_Exportar.Image = Global.Modulo_Ventas.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 15
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'frm_ConsultaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 606)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Datos)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Contactos Web"
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Datos.ResumeLayout(False)
        Me.Gbx_Datos.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Datos As Modulo_Ventas.cp_Listview
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents tbx_Mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents tbx_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents tbx_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents tbx_Mail As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents tbx_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbx_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
