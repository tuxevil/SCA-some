Public Class frmreportes
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents rv_1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rv_1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'rv_1
        '
        Me.rv_1.ActiveViewIndex = -1
        Me.rv_1.DisplayGroupTree = False
        Me.rv_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_1.Location = New System.Drawing.Point(0, 0)
        Me.rv_1.Name = "rv_1"
        Me.rv_1.ReportSource = Nothing
        Me.rv_1.Size = New System.Drawing.Size(848, 571)
        Me.rv_1.TabIndex = 0
        '
        'frmreportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 571)
        Me.Controls.Add(Me.rv_1)
        Me.MinimizeBox = False
        Me.Name = "frmreportes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmreportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rv_1.ReportSource = MainClass.reporte_cotizaciones
        rv_1.SelectionFormula = "{caCotizacion.clientes_codigo}=" & gVar.codCli & " and {caCotizacion.cot_estado}='A'"
        rv_1.RefreshReport()
    End Sub
End Class
