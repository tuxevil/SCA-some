Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmreportes
    Inherits System.Windows.Forms.Form

    Dim ass As Form



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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblvendido As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents rv_1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportes))
        Me.rv_1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblvendido = New System.Windows.Forms.Label
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
        Me.rv_1.Size = New System.Drawing.Size(846, 569)
        Me.rv_1.TabIndex = 0
        Me.rv_1.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(481, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Confirmar Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblvendido
        '
        Me.lblvendido.AutoSize = True
        Me.lblvendido.BackColor = System.Drawing.Color.Transparent
        Me.lblvendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendido.ForeColor = System.Drawing.Color.Red
        Me.lblvendido.Location = New System.Drawing.Point(448, 5)
        Me.lblvendido.Name = "lblvendido"
        Me.lblvendido.Size = New System.Drawing.Size(202, 20)
        Me.lblvendido.TabIndex = 2
        Me.lblvendido.Text = "** Cotización Vendida **"
        '
        'frmreportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(846, 569)
        Me.Controls.Add(Me.lblvendido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rv_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmreportes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim isSold As Boolean = False


    Private Sub frmreportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xx As New Loading()
        'xx.SetBounds(Me.Location.X + 100, Me.Location.Y + 100, xx.Size.Width, xx.Size.Height)
        'xx.ShowDialog()

        xx.Show()
        'MsgBox("sfsd")
        rv_1.ReportSource = MainClass.reporte_cotizaciones
        rv_1.SelectionFormula = "{caCotizacion.clientes_codigo}=" & gVar.codCli & " and {caCotizacion.num_cot}=" & gVar.NumCot & " and {caCotizacion.cot_estado}='A'"
        rv_1.RefreshReport()
        xx.Close()

        If MainClass.vendido(gVar.codCli, gVar.NumCot) Then
            Button1.Visible = False
            lblvendido.Visible = True
            isSold = True


        Else
            lblvendido.Visible = False
            Button1.Visible = True
        End If

    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not isSold Then


            MainClass.vender(gVar.codCli, gVar.NumCot)
            Me.Close()
        End If




    End Sub

    Private Sub lblvendido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvendido.Click

    End Sub
End Class
