Public Class frmCambioClave
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pass1 As System.Windows.Forms.TextBox
    Friend WithEvents pass2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button
        Me.pass1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pass2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(48, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Aceptar"
        '
        'pass1
        '
        Me.pass1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.pass1.Location = New System.Drawing.Point(8, 24)
        Me.pass1.Name = "pass1"
        Me.pass1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.pass1.Size = New System.Drawing.Size(160, 20)
        Me.pass1.TabIndex = 22
        Me.pass1.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nueva Clave:"
        '
        'pass2
        '
        Me.pass2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.pass2.Location = New System.Drawing.Point(8, 64)
        Me.pass2.Name = "pass2"
        Me.pass2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.pass2.Size = New System.Drawing.Size(160, 20)
        Me.pass2.TabIndex = 25
        Me.pass2.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Confirmar Clave:"
        '
        'frmCambioClave
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(176, 123)
        Me.Controls.Add(Me.pass2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pass1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioClave"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambio de Clave"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If pass1.Text = pass2.Text Then
            MainClass.grabaClave(gVar.tempCodUser, pass1.Text)
            MsgBox("Cambio de Clave Exitoso")
            Me.Close()
        Else
            MsgBox("No Concuerdan")
        End If
    End Sub
End Class
