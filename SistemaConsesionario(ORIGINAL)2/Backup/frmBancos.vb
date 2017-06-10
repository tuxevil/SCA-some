Public Class frmBancos
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents entrada As System.Windows.Forms.TextBox
    Friend WithEvents meses As System.Windows.Forms.TextBox
    Friend WithEvents interes As System.Windows.Forms.TextBox
    Friend WithEvents rutasolicitud As System.Windows.Forms.TextBox
    Friend WithEvents institucion As System.Windows.Forms.TextBox
    Friend WithEvents lv_bancos As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents paginas As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lv_bancos = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.institucion = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.entrada = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.meses = New System.Windows.Forms.TextBox
        Me.interes = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rutasolicitud = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.paginas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lv_bancos
        '
        Me.lv_bancos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lv_bancos.FullRowSelect = True
        Me.lv_bancos.GridLines = True
        Me.lv_bancos.Location = New System.Drawing.Point(328, 8)
        Me.lv_bancos.Name = "lv_bancos"
        Me.lv_bancos.Size = New System.Drawing.Size(176, 160)
        Me.lv_bancos.TabIndex = 101
        Me.lv_bancos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Institucion"
        Me.ColumnHeader2.Width = 104
        '
        'institucion
        '
        Me.institucion.Location = New System.Drawing.Point(120, 24)
        Me.institucion.MaxLength = 30
        Me.institucion.Name = "institucion"
        Me.institucion.Size = New System.Drawing.Size(200, 20)
        Me.institucion.TabIndex = 102
        Me.institucion.Text = ""
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(120, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Institucion:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(88, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "N"
        '
        'tb_codigo
        '
        Me.tb_codigo.Enabled = False
        Me.tb_codigo.Location = New System.Drawing.Point(8, 24)
        Me.tb_codigo.MaxLength = 30
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(80, 20)
        Me.tb_codigo.TabIndex = 104
        Me.tb_codigo.Text = ""
        Me.tb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Codigo:"
        '
        'entrada
        '
        Me.entrada.Location = New System.Drawing.Point(8, 72)
        Me.entrada.MaxLength = 30
        Me.entrada.Name = "entrada"
        Me.entrada.Size = New System.Drawing.Size(104, 20)
        Me.entrada.TabIndex = 107
        Me.entrada.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Entrada Minima (%):"
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(120, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Maximo Meses:"
        '
        'meses
        '
        Me.meses.Location = New System.Drawing.Point(120, 72)
        Me.meses.MaxLength = 30
        Me.meses.Name = "meses"
        Me.meses.Size = New System.Drawing.Size(96, 20)
        Me.meses.TabIndex = 110
        Me.meses.Text = ""
        '
        'interes
        '
        Me.interes.Location = New System.Drawing.Point(224, 72)
        Me.interes.MaxLength = 30
        Me.interes.Name = "interes"
        Me.interes.Size = New System.Drawing.Size(96, 20)
        Me.interes.TabIndex = 112
        Me.interes.Text = ""
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(224, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Interes Anual (%):"
        '
        'rutasolicitud
        '
        Me.rutasolicitud.Location = New System.Drawing.Point(8, 120)
        Me.rutasolicitud.MaxLength = 300
        Me.rutasolicitud.Name = "rutasolicitud"
        Me.rutasolicitud.Size = New System.Drawing.Size(232, 20)
        Me.rutasolicitud.TabIndex = 113
        Me.rutasolicitud.Text = ""
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(8, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Ruta Solicitud de Credito:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(248, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "Guardar"
        '
        'paginas
        '
        Me.paginas.Location = New System.Drawing.Point(248, 120)
        Me.paginas.MaxLength = 30
        Me.paginas.Name = "paginas"
        Me.paginas.Size = New System.Drawing.Size(72, 20)
        Me.paginas.TabIndex = 114
        Me.paginas.Text = ""
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(248, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Paginas:"
        '
        'frmBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(514, 173)
        Me.Controls.Add(Me.paginas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rutasolicitud)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.interes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.meses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.entrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.institucion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lv_bancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainClass.grababancos(tb_codigo.Text, institucion.Text, entrada.Text, meses.Text, interes.Text, rutasolicitud.Text, paginas.Text)
        MainClass.cargaListaBancos(lv_bancos)
    End Sub

    Private Sub frmBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainClass.cargaListaBancos(lv_bancos)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tb_codigo.Text = "Nuevo"
        Me.limpiaBancos()
    End Sub

    Private Sub lv_bancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_bancos.SelectedIndexChanged
        If lv_bancos.SelectedItems.Count > 0 Then
            MainClass.cargaBancos(lv_bancos.SelectedItems(0).Text)
            Me.limpiaBancos()
            Me.cargaDatos()
        End If
    End Sub
    Private Sub limpiaBancos()
        institucion.Text = ""
        entrada.Text = ""
        meses.Text = ""
        interes.Text = ""
        rutasolicitud.Text = ""
        paginas.Text = ""
    End Sub
    Private Sub cargaDatos()
        tb_codigo.Text = gVar.bCodigo
        institucion.Text = gVar.bDescripcion
        entrada.Text = gVar.bEntrada
        meses.Text = gVar.bPlazo
        interes.Text = gVar.bInteres
        rutasolicitud.Text = gVar.bRuta
        paginas.Text = gVar.bPaginas
    End Sub

  
End Class
