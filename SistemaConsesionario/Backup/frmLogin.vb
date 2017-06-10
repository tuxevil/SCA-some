Public Class frmLogin
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.user = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pass = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.user.Location = New System.Drawing.Point(8, 24)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(160, 20)
        Me.user.TabIndex = 12
        Me.user.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usuario:"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(8, 72)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(160, 20)
        Me.pass.TabIndex = 14
        Me.pass.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Contraseña:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Aceptar"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(96, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Salir"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 96)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 24)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Cambiar Clave de Acceso"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(176, 152)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainClass.validaUsuario(user.Text, pass.Text) = 1 Then
            gVar.tempAcceso = 1
            If CheckBox1.Checked = True Then
                Dim X As New frmCambioClave
                X.ShowDialog()
            End If
            Me.Close()
        Else
            gVar.tempAcceso = 0
            MsgBox("Acceso Fallido")
            user.Text = ""
            pass.Text = ""
            user.Focus()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gVar.tempAcceso = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gVar.tempAcceso = 0
        Me.Close()
    End Sub
End Class
