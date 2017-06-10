Public Class frmSeguimiento
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cliente As System.Windows.Forms.TextBox
    Friend WithEvents fechaConsulta As System.Windows.Forms.DateTimePicker
    Friend WithEvents estadoSeg As System.Windows.Forms.ComboBox
    Friend WithEvents observacion As System.Windows.Forms.TextBox
    Friend WithEvents encargado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cliente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.fechaConsulta = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.estadoSeg = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.observacion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.encargado = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.Enabled = False
        Me.cliente.Location = New System.Drawing.Point(8, 24)
        Me.cliente.MaxLength = 20
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(448, 20)
        Me.cliente.TabIndex = 1
        Me.cliente.Text = ""
        Me.cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cliente:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "?"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha en Agenda:"
        '
        'fechaConsulta
        '
        Me.fechaConsulta.Location = New System.Drawing.Point(8, 72)
        Me.fechaConsulta.Name = "fechaConsulta"
        Me.fechaConsulta.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(216, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Estado Seguimiento:"
        '
        'estadoSeg
        '
        Me.estadoSeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.estadoSeg.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.estadoSeg.Location = New System.Drawing.Point(216, 72)
        Me.estadoSeg.MaxLength = 30
        Me.estadoSeg.Name = "estadoSeg"
        Me.estadoSeg.Size = New System.Drawing.Size(120, 21)
        Me.estadoSeg.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(344, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Encargado:"
        '
        'observacion
        '
        Me.observacion.Location = New System.Drawing.Point(8, 120)
        Me.observacion.MaxLength = 400
        Me.observacion.Name = "observacion"
        Me.observacion.Size = New System.Drawing.Size(464, 20)
        Me.observacion.TabIndex = 25
        Me.observacion.Text = ""
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(8, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Observacion:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(405, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Grabar"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 184)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(464, 400)
        Me.ListView1.TabIndex = 35
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Codigo"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Fecha"
        Me.ColumnHeader1.Width = 63
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Observacion"
        Me.ColumnHeader2.Width = 381
        '
        'encargado
        '
        Me.encargado.Enabled = False
        Me.encargado.Location = New System.Drawing.Point(344, 72)
        Me.encargado.MaxLength = 30
        Me.encargado.Name = "encargado"
        Me.encargado.Size = New System.Drawing.Size(128, 20)
        Me.encargado.TabIndex = 20
        Me.encargado.Text = ""
        Me.encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmSeguimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(482, 595)
        Me.Controls.Add(Me.encargado)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.observacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.estadoSeg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fechaConsulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento Cliente(s)"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSeguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        encargado.Text = Trim(gVar.tempNickUser)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New frmBuscaCliente
        x.ShowDialog()
        MainClass.llenaListaSeguimiento(gVar.codCli, ListView1)
        cliente.Text = Trim(gVar.tNombres)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MainClass.grabaSeguimiento(fechaConsulta.Value, Trim(gVar.tempNickUser), encargado.Text, observacion.Text)
        MainClass.llenaListaSeguimiento(gVar.codCli, ListView1)

    End Sub
End Class
