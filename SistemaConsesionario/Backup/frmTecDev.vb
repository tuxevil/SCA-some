Public Class frmTecDev
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
    Friend WithEvents lic As System.Windows.Forms.Label
    Friend WithEvents nom As System.Windows.Forms.Label
    Friend WithEvents ano As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTecDev))
        Me.lic = New System.Windows.Forms.Label
        Me.nom = New System.Windows.Forms.Label
        Me.ano = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'lic
        '
        Me.lic.Location = New System.Drawing.Point(0, 160)
        Me.lic.Name = "lic"
        Me.lic.Size = New System.Drawing.Size(440, 23)
        Me.lic.TabIndex = 1
        Me.lic.Text = "Licencia Nro. 2512-0811-0203"
        Me.lic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(4, 184)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(440, 23)
        Me.nom.TabIndex = 2
        Me.nom.Text = "A Nombre de  Nikkei/Orgu"
        Me.nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ano
        '
        Me.ano.Location = New System.Drawing.Point(4, 208)
        Me.ano.Name = "ano"
        Me.ano.Size = New System.Drawing.Size(440, 23)
        Me.ano.TabIndex = 3
        Me.ano.Text = "2007 - 2008"
        Me.ano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmTecDev
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(448, 235)
        Me.Controls.Add(Me.ano)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.lic)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTecDev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTecDev"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTecDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainClass.cargaLicencia()
        lic.Text = "Licencia Nro. " & Trim(gVar.licNumero)
        nom.Text = "A Nombre de " & Trim(gVar.licEmpresa)
        ano.Text = Trim(gVar.licAno)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
