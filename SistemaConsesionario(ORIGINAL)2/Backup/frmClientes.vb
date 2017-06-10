Public Class frmClientes
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tipoID As System.Windows.Forms.ComboBox
    Friend WithEvents apeP As System.Windows.Forms.TextBox
    Friend WithEvents apeM As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents celular As System.Windows.Forms.TextBox
    Friend WithEvents fax As System.Windows.Forms.TextBox
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents bt_grabar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.codigo = New System.Windows.Forms.Label
        Me.tipoID = New System.Windows.Forms.ComboBox
        Me.apeP = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.apeM = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.nombre = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.telefono = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.celular = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.fax = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.direccion = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.email = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.bt_grabar = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(176, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "?"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'codigo
        '
        Me.codigo.BackColor = System.Drawing.Color.White
        Me.codigo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.codigo.Location = New System.Drawing.Point(48, 8)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(72, 16)
        Me.codigo.TabIndex = 2
        Me.codigo.Text = "Nuevo"
        Me.codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tipoID
        '
        Me.tipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipoID.Items.AddRange(New Object() {"Cedula", "R.U.C.", "Pasaporte"})
        Me.tipoID.Location = New System.Drawing.Point(8, 144)
        Me.tipoID.Name = "tipoID"
        Me.tipoID.Size = New System.Drawing.Size(104, 21)
        Me.tipoID.TabIndex = 25
        '
        'apeP
        '
        Me.apeP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.apeP.Location = New System.Drawing.Point(8, 48)
        Me.apeP.MaxLength = 20
        Me.apeP.Name = "apeP"
        Me.apeP.Size = New System.Drawing.Size(168, 20)
        Me.apeP.TabIndex = 5
        Me.apeP.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido Paterno:"
        '
        'apeM
        '
        Me.apeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.apeM.Location = New System.Drawing.Point(200, 48)
        Me.apeM.MaxLength = 20
        Me.apeM.Name = "apeM"
        Me.apeM.Size = New System.Drawing.Size(184, 20)
        Me.apeM.TabIndex = 15
        Me.apeM.Text = ""
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(200, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido Materno:"
        '
        'nombre
        '
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Location = New System.Drawing.Point(8, 96)
        Me.nombre.MaxLength = 30
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(376, 20)
        Me.nombre.TabIndex = 20
        Me.nombre.Text = ""
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombres:"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo ID.:"
        '
        'ID
        '
        Me.ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ID.Location = New System.Drawing.Point(120, 144)
        Me.ID.MaxLength = 20
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(112, 20)
        Me.ID.TabIndex = 30
        Me.ID.Text = ""
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(120, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nro. Identificacion"
        '
        'telefono
        '
        Me.telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.telefono.Location = New System.Drawing.Point(8, 192)
        Me.telefono.MaxLength = 30
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(120, 20)
        Me.telefono.TabIndex = 40
        Me.telefono.Text = ""
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(8, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Telefono:"
        '
        'celular
        '
        Me.celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.celular.Location = New System.Drawing.Point(136, 192)
        Me.celular.MaxLength = 30
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(120, 20)
        Me.celular.TabIndex = 45
        Me.celular.Text = ""
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(136, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Celular:"
        '
        'fax
        '
        Me.fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fax.Location = New System.Drawing.Point(264, 192)
        Me.fax.MaxLength = 30
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(120, 20)
        Me.fax.TabIndex = 50
        Me.fax.Text = ""
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(264, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fax:"
        '
        'direccion
        '
        Me.direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.direccion.Location = New System.Drawing.Point(8, 240)
        Me.direccion.MaxLength = 100
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(376, 20)
        Me.direccion.TabIndex = 55
        Me.direccion.Text = ""
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(8, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Direccion:"
        '
        'email
        '
        Me.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.email.Location = New System.Drawing.Point(240, 144)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(144, 20)
        Me.email.TabIndex = 35
        Me.email.Text = ""
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(240, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Email:"
        '
        'bt_grabar
        '
        Me.bt_grabar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_grabar.Location = New System.Drawing.Point(304, 272)
        Me.bt_grabar.Name = "bt_grabar"
        Me.bt_grabar.Size = New System.Drawing.Size(80, 23)
        Me.bt_grabar.TabIndex = 60
        Me.bt_grabar.Text = "Grabar"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(120, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(16, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "N"
        '
        'frmClientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 301)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bt_grabar)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.fax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.celular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.apeM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.apeP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tipoID)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Cliente(s)"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_grabar.Click
        MainClass.grabaDatosCliente(codigo.Text, apeP.Text, apeM.Text, nombre.Text, tipoID.Text, ID.Text, email.Text, telefono.Text, celular.Text, fax.Text, direccion.Text, gVar.tempNickUser)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New frmBuscaCliente
        x.ShowDialog()
        MainClass.cargaCliente(gVar.codCli)
        Me.cargaDatos()

    End Sub

    Public Sub cargaDatos()
        Me.limpiaDatos()
        codigo.Text = gVar.codCli
        apeP.Text = gVar.tApellidoP
        apeM.Text = gVar.tApellidoM
        nombre.Text = gVar.tNombres
        tipoID.Text = gVar.tTipoID
        ID.Text = gVar.tID
        email.Text = gVar.tEmail
        telefono.Text = gVar.tTelefono
        celular.Text = gVar.tCelular
        fax.Text = gVar.tFax
        direccion.Text = gVar.tDireccion
    End Sub

    Public Sub limpiaDatos()
        codigo.Text = "Nuevo"
        apeP.Text = ""
        apeM.Text = ""
        nombre.Text = ""
        tipoID.Text = ""
        ID.Text = ""
        email.Text = ""
        telefono.Text = ""
        celular.Text = ""
        fax.Text = ""
        direccion.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.limpiaDatos()
    End Sub
End Class
