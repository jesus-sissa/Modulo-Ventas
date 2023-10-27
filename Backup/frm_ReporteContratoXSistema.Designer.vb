<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteContratoXSistema
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
        Me.crv_rptContratoXSistema = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv_rptContratoXSistema
        '
        Me.crv_rptContratoXSistema.ActiveViewIndex = -1
        Me.crv_rptContratoXSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_rptContratoXSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_rptContratoXSistema.Location = New System.Drawing.Point(0, 0)
        Me.crv_rptContratoXSistema.Name = "crv_rptContratoXSistema"
        Me.crv_rptContratoXSistema.SelectionFormula = ""
        Me.crv_rptContratoXSistema.Size = New System.Drawing.Size(784, 561)
        Me.crv_rptContratoXSistema.TabIndex = 0
        Me.crv_rptContratoXSistema.ViewTimeSelectionFormula = ""
        '
        'frm_ReporteContratoXSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.crv_rptContratoXSistema)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ReporteContratoXSistema"
        Me.Text = " Contrato Por medio de Sisstema"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_rptContratoXSistema As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
