<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rv_1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'rv_1
        '
        Me.rv_1.ActiveViewIndex = -1
        Me.rv_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rv_1.DisplayGroupTree = False
        Me.rv_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_1.Location = New System.Drawing.Point(0, 0)
        Me.rv_1.Name = "rv_1"
        Me.rv_1.SelectionFormula = ""
        Me.rv_1.Size = New System.Drawing.Size(550, 423)
        Me.rv_1.TabIndex = 0
        Me.rv_1.ViewTimeSelectionFormula = ""
        '
        'frmReportesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 423)
        Me.Controls.Add(Me.rv_1)
        Me.Name = "frmReportesVentas"
        Me.ShowInTaskbar = False
        Me.Text = "Reporte de Ventas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
