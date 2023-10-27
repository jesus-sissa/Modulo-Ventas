<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProspectoaClientes
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
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Ventas.cp_Textbox
        Me.lsv_Clientes = New Modulo_Ventas.cp_Listview
        Me.SuspendLayout()
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 2
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(61, 12)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(438, 20)
        Me.tbx_Buscar.TabIndex = 0
        Me.tbx_Buscar.TipoDatos = Modulo_Ventas.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.AllowColumnReorder = True
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(9, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 70
        Me.lsv_Clientes.Row10 = 10
        Me.lsv_Clientes.Row2 = 20
        Me.lsv_Clientes.Row3 = 10
        Me.lsv_Clientes.Row4 = 10
        Me.lsv_Clientes.Row5 = 10
        Me.lsv_Clientes.Row6 = 10
        Me.lsv_Clientes.Row7 = 10
        Me.lsv_Clientes.Row8 = 10
        Me.lsv_Clientes.Row9 = 10
        Me.lsv_Clientes.Size = New System.Drawing.Size(496, 317)
        Me.lsv_Clientes.TabIndex = 1
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'frm_ProspectoaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 361)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.lsv_Clientes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(530, 400)
        Me.Name = "frm_ProspectoaClientes"
        Me.Text = "Buscar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Clientes As Modulo_Ventas.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Ventas.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
End Class
