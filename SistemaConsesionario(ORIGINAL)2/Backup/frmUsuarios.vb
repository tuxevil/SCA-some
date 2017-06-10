Public Class frmUsuarios
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents a10 As System.Windows.Forms.CheckBox
    Friend WithEvents a9 As System.Windows.Forms.CheckBox
    Friend WithEvents a8 As System.Windows.Forms.CheckBox
    Friend WithEvents a7 As System.Windows.Forms.CheckBox
    Friend WithEvents a6 As System.Windows.Forms.CheckBox
    Friend WithEvents a5 As System.Windows.Forms.CheckBox
    Friend WithEvents a4 As System.Windows.Forms.CheckBox
    Friend WithEvents a3 As System.Windows.Forms.CheckBox
    Friend WithEvents a2 As System.Windows.Forms.CheckBox
    Friend WithEvents a1 As System.Windows.Forms.CheckBox
    Friend WithEvents a11 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label70 = New System.Windows.Forms.Label
        Me.TextBox58 = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.ComboBox10 = New System.Windows.Forms.ComboBox
        Me.TextBox57 = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.TextBox56 = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.a11 = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.a10 = New System.Windows.Forms.CheckBox
        Me.a9 = New System.Windows.Forms.CheckBox
        Me.a8 = New System.Windows.Forms.CheckBox
        Me.a7 = New System.Windows.Forms.CheckBox
        Me.a6 = New System.Windows.Forms.CheckBox
        Me.a5 = New System.Windows.Forms.CheckBox
        Me.a4 = New System.Windows.Forms.CheckBox
        Me.a3 = New System.Windows.Forms.CheckBox
        Me.a2 = New System.Windows.Forms.CheckBox
        Me.a1 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label70)
        Me.GroupBox1.Controls.Add(Me.TextBox58)
        Me.GroupBox1.Controls.Add(Me.Label69)
        Me.GroupBox1.Controls.Add(Me.Label68)
        Me.GroupBox1.Controls.Add(Me.ComboBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox57)
        Me.GroupBox1.Controls.Add(Me.Label67)
        Me.GroupBox1.Controls.Add(Me.TextBox56)
        Me.GroupBox1.Controls.Add(Me.Label66)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Location = New System.Drawing.Point(232, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "N"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = ""
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(552, 169)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 24)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Eliminar"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(176, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Agregar"
        '
        'Label70
        '
        Me.Label70.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label70.Location = New System.Drawing.Point(8, 128)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(112, 16)
        Me.Label70.TabIndex = 74
        Me.Label70.Tag = ""
        Me.Label70.Text = "Nombres:"
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(8, 144)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(224, 20)
        Me.TextBox58.TabIndex = 20
        Me.TextBox58.Text = ""
        '
        'Label69
        '
        Me.Label69.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label69.Location = New System.Drawing.Point(8, 80)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(100, 16)
        Me.Label69.TabIndex = 73
        Me.Label69.Text = "Apellido Paterno:"
        '
        'Label68
        '
        Me.Label68.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label68.Location = New System.Drawing.Point(136, 80)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(100, 16)
        Me.Label68.TabIndex = 72
        Me.Label68.Tag = ""
        Me.Label68.Text = "Apellido Materno:"
        '
        'ComboBox10
        '
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.Items.AddRange(New Object() {""})
        Me.ComboBox10.Location = New System.Drawing.Point(8, 48)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox10.TabIndex = 1
        '
        'TextBox57
        '
        Me.TextBox57.Location = New System.Drawing.Point(152, 48)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(104, 20)
        Me.TextBox57.TabIndex = 5
        Me.TextBox57.Text = ""
        '
        'Label67
        '
        Me.Label67.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label67.Location = New System.Drawing.Point(152, 32)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(100, 16)
        Me.Label67.TabIndex = 71
        Me.Label67.Tag = ""
        Me.Label67.Text = "Usuario:"
        '
        'TextBox56
        '
        Me.TextBox56.Location = New System.Drawing.Point(136, 96)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(120, 20)
        Me.TextBox56.TabIndex = 15
        Me.TextBox56.Text = ""
        '
        'Label66
        '
        Me.Label66.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label66.Location = New System.Drawing.Point(8, 32)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 16)
        Me.Label66.TabIndex = 70
        Me.Label66.Text = "Tipo:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(264, 25)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(368, 140)
        Me.ListView1.TabIndex = 200
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Codigo"
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Usuario"
        Me.ColumnHeader1.Width = 209
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.a11)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Controls.Add(Me.a10)
        Me.GroupBox2.Controls.Add(Me.a9)
        Me.GroupBox2.Controls.Add(Me.a8)
        Me.GroupBox2.Controls.Add(Me.a7)
        Me.GroupBox2.Controls.Add(Me.a6)
        Me.GroupBox2.Controls.Add(Me.a5)
        Me.GroupBox2.Controls.Add(Me.a4)
        Me.GroupBox2.Controls.Add(Me.a3)
        Me.GroupBox2.Controls.Add(Me.a2)
        Me.GroupBox2.Controls.Add(Me.a1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 264)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos"
        '
        'a11
        '
        Me.a11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a11.Location = New System.Drawing.Point(136, 200)
        Me.a11.Name = "a11"
        Me.a11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a11.Size = New System.Drawing.Size(128, 24)
        Me.a11.TabIndex = 91
        Me.a11.Text = "Super Usuario"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(232, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "N"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader5})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(264, 32)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(368, 192)
        Me.ListView2.TabIndex = 205
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Codigo"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Descripcion"
        Me.ColumnHeader5.Width = 307
        '
        'a10
        '
        Me.a10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a10.Location = New System.Drawing.Point(8, 200)
        Me.a10.Name = "a10"
        Me.a10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a10.Size = New System.Drawing.Size(128, 24)
        Me.a10.TabIndex = 90
        Me.a10.Text = "Acceso Agenda"
        '
        'a9
        '
        Me.a9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a9.Location = New System.Drawing.Point(144, 168)
        Me.a9.Name = "a9"
        Me.a9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a9.Size = New System.Drawing.Size(88, 24)
        Me.a9.TabIndex = 85
        Me.a9.Text = "Usuarios"
        '
        'a8
        '
        Me.a8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a8.Location = New System.Drawing.Point(80, 168)
        Me.a8.Name = "a8"
        Me.a8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a8.Size = New System.Drawing.Size(88, 24)
        Me.a8.TabIndex = 80
        Me.a8.Text = "Bancos"
        '
        'a7
        '
        Me.a7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a7.Location = New System.Drawing.Point(8, 168)
        Me.a7.Name = "a7"
        Me.a7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a7.Size = New System.Drawing.Size(88, 24)
        Me.a7.TabIndex = 75
        Me.a7.Text = "Vehiculos"
        '
        'a6
        '
        Me.a6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a6.Location = New System.Drawing.Point(120, 136)
        Me.a6.Name = "a6"
        Me.a6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a6.Size = New System.Drawing.Size(112, 24)
        Me.a6.TabIndex = 70
        Me.a6.Text = "Reportes Usuarios"
        '
        'a5
        '
        Me.a5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a5.Location = New System.Drawing.Point(8, 136)
        Me.a5.Name = "a5"
        Me.a5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a5.TabIndex = 65
        Me.a5.Text = "Reportes Clientes"
        '
        'a4
        '
        Me.a4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a4.Location = New System.Drawing.Point(96, 104)
        Me.a4.Name = "a4"
        Me.a4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a4.Size = New System.Drawing.Size(176, 24)
        Me.a4.TabIndex = 60
        Me.a4.Text = "Ingreso Solicitudes de Credito"
        '
        'a3
        '
        Me.a3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a3.Location = New System.Drawing.Point(8, 104)
        Me.a3.Name = "a3"
        Me.a3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a3.Size = New System.Drawing.Size(88, 24)
        Me.a3.TabIndex = 55
        Me.a3.Text = "Cotizaciones"
        '
        'a2
        '
        Me.a2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a2.Location = New System.Drawing.Point(72, 72)
        Me.a2.Name = "a2"
        Me.a2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a2.Size = New System.Drawing.Size(88, 24)
        Me.a2.TabIndex = 50
        Me.a2.Text = "Seguimiento"
        '
        'a1
        '
        Me.a1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.a1.Location = New System.Drawing.Point(8, 72)
        Me.a1.Name = "a1"
        Me.a1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a1.Size = New System.Drawing.Size(88, 24)
        Me.a1.TabIndex = 45
        Me.a1.Text = "Datos"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(552, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Eliminar"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(176, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 74
        Me.Label1.Tag = ""
        Me.Label1.Text = "Descripcion:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(8, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 20)
        Me.TextBox3.TabIndex = 40
        Me.TextBox3.Text = ""
        '
        'frmUsuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainClass.cargaComboTipoUsuario(ComboBox10)
        MainClass.cargaListaUsuarios(ListView1)
        MainClass.cargaListaTipos(ListView2)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MainClass.grabausuario(TextBox57.Text, TextBox1.Text, TextBox56.Text, TextBox58.Text, MainClass.CualCod(ComboBox10.Text))
        MainClass.cargaListaUsuarios(ListView1)
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            MainClass.cargatipos(ListView2.SelectedItems(0).Text)
            Me.cargaCheck()

        End If
    End Sub
    Public Sub cargaCheck()
        If gVar.tuDatos = 1 Then
            a1.Checked = True
        Else
            a1.Checked = False
        End If
        If gVar.tuSeguimiento = 1 Then
            a2.Checked = True
        Else
            a2.Checked = False
        End If
        If gVar.tuCotizaciones = 1 Then
            a3.Checked = True
        Else
            a3.Checked = False
        End If
        If gVar.tuIngresoCredito = 1 Then
            a4.Checked = True
        Else
            a4.Checked = False
        End If
        If gVar.tuClientes = 1 Then
            a5.Checked = True
        Else
            a5.Checked = False
        End If
        If gVar.tuUsuarios = 1 Then
            a6.Checked = True
        Else
            a6.Checked = False
        End If
        If gVar.tuVehiculos = 1 Then
            a7.Checked = True
        Else
            a7.Checked = False
        End If
        If gVar.tuBancos = 1 Then
            a8.Checked = True
        Else
            a8.Checked = False
        End If
        If gVar.tuParUsuarios = 1 Then
            a9.Checked = True
        Else
            a9.Checked = False
        End If
        If gVar.tuAgenda = 1 Then
            a10.Checked = True
        Else
            a10.Checked = False
        End If
        If gVar.superuser = 1 Then
            a11.Checked = True
        Else
            a11.Checked = False
        End If
    End Sub

    Private Sub grabaCheck()
        If a1.Checked = True Then
            gVar.tuDatos = 1
        Else
            gVar.tuDatos = 0
        End If
        If a2.Checked = True Then
            gVar.tuSeguimiento = 1
        Else
            gVar.tuSeguimiento = 0
        End If
        If a3.Checked = True Then
            gVar.tuCotizaciones = 1
        Else
            gVar.tuCotizaciones = 0
        End If
        If a4.Checked = True Then
            gVar.tuIngresoCredito = 1
        Else
            gVar.tuIngresoCredito = 0
        End If
        If a5.Checked = True Then
            gVar.tuClientes = 1
        Else
            gVar.tuClientes = 0
        End If
        If a6.Checked = True Then
            gVar.tuUsuarios = 1
        Else
            gVar.tuUsuarios = 0
        End If
        If a7.Checked = True Then
            gVar.tuVehiculos = 1
        Else
            gVar.tuVehiculos = 0
        End If
        If a8.Checked = True Then
            gVar.tuBancos = 1
        Else
            gVar.tuBancos = 0
        End If
        If a9.Checked = True Then
            gVar.tuParUsuarios = 1
        Else
            gVar.tuParUsuarios = 0
        End If
        If a10.Checked = True Then
            gVar.tuAgenda = 1
        Else
            gVar.tuAgenda = 0
        End If
        If a11.Checked = True Then
            gVar.tuSuperUser = 1
        Else
            gVar.tuSuperUser = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.grabaCheck()
        MainClass.grabaTipos(ListView2.SelectedItems(0).Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox3.Text <> "" Then
            MainClass.creaTipos(TextBox3.Text)
            MainClass.cargaListaTipos(ListView2)
            MainClass.cargaComboTipoUsuario(ComboBox10)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListView1.SelectedItems.Count > 0 Then
            MainClass.eliminaUsuario(ListView1.SelectedItems(0).Text)
            MainClass.cargaListaUsuarios(ListView1)
        Else
            MsgBox("No Hay Seleccion de Usuarios")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListView2.SelectedItems.Count > 0 Then
            MainClass.eliminaUsuarioTipo(ListView2.SelectedItems(0).Text)
            MainClass.cargaListaTipos(ListView2)
            MainClass.cargaComboTipoUsuario(ComboBox10)
        Else
            MsgBox("No Hay Seleccion de Tipos Usuarios")
        End If

    End Sub
End Class
