Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing
Public Class frmCotizaciones
    Inherits System.Windows.Forms.Form

    Dim permitenuevo As Boolean = False
    Dim cnt As Integer = 0


    Public Property permiteN() As Boolean
        Get
            Return permitenuevo
        End Get
        Set(ByVal value As Boolean)
            permitenuevo = value
        End Set
    End Property


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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents imagen_item As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbocot As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizaciones))
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbocot = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.imagen_item = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imagen_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(457, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 21)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(448, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(8, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cliente:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(4, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(4, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Modelo:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Location = New System.Drawing.Point(122, 53)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox3.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(122, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Institucion Financiera:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(239, 53)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 20)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.Text = "0"
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(240, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Entrada:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"1", "3", "6", "12", "24", "48", "60"})
        Me.ComboBox1.Location = New System.Drawing.Point(323, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(320, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Plazo:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(0, 98)
        Me.TextBox3.MaxLength = 300
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(457, 40)
        Me.TextBox3.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(1, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Observaciones:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(0, 160)
        Me.TextBox4.MaxLength = 300
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(457, 40)
        Me.TextBox4.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(1, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Beneficios:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(345, 490)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Imprimir"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(385, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Grabar"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(9, 356)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(448, 128)
        Me.ListView1.TabIndex = 31
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod."
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Banco"
        Me.ColumnHeader6.Width = 157
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Valor"
        Me.ColumnHeader2.Width = 65
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Inicial"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nro. Cuotas"
        Me.ColumnHeader4.Width = 75
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cuota"
        Me.ColumnHeader5.Width = 62
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(296, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Marca/Modelo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(296, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Modelo/Año"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(296, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Clindraje/HP"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(296, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Transmision/Cambios"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 321)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(296, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Seguridad"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(9, 490)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 23)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Eliminar"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(385, 53)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 25
        Me.TextBox5.Text = "0"
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(384, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Cuota:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Label14"
        '
        'cbocot
        '
        Me.cbocot.Enabled = False
        Me.cbocot.FormattingEnabled = True
        Me.cbocot.Items.AddRange(New Object() {"< Nueva Cotización >", "4", "10"})
        Me.cbocot.Location = New System.Drawing.Point(108, 13)
        Me.cbocot.Name = "cbocot"
        Me.cbocot.Size = New System.Drawing.Size(321, 21)
        Me.cbocot.TabIndex = 44
        Me.cbocot.Text = "              --------------------  COTIZACION  ---------------"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.imagen_item)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 514)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Cotización"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cbocot)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(8, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 40)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Escoger Cotización"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(50, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Número :"
        '
        'imagen_item
        '
        Me.imagen_item.BackColor = System.Drawing.Color.White
        Me.imagen_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagen_item.Location = New System.Drawing.Point(297, 230)
        Me.imagen_item.Name = "imagen_item"
        Me.imagen_item.Size = New System.Drawing.Size(160, 120)
        Me.imagen_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen_item.TabIndex = 32
        Me.imagen_item.TabStop = False
        '
        'frmCotizaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 619)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCotizaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.imagen_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        ' pb_auto.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory & "images\mazda3.jpg")
        MainClass.cargaDatosCaracteristicasVehiculo(MainClass.CualCod(ComboBox2.Text))
        Label8.Text = gVar.vMarca
        Label9.Text = gVar.vModelo
        Label10.Text = gVar.vCilindraje
        Label11.Text = gVar.vTransmision
        Label12.Text = gVar.vSeguridad

        If File.Exists(MainClass.imagenes_autos & Trim(ComboBox2.Text) & ".jpg") = True Then
            imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & Trim(ComboBox2.Text) & ".jpg")
        Else
            imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & "logo.jpg")
        End If

    End Sub

    Private Sub frmCotizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(Me.Location.X, Me.Location.Y, 486, 112)
        MainClass.cargaComboModelos(ComboBox2)
        MainClass.cargaComboBancos(ComboBox3)
        Try
            imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & "logo.jpg")

        Catch ex As Exception
            MsgBox("Imagen de Auto no encontrada en el archivo...")
        End Try
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If Val(TextBox2.Text) < gVar.tempEntradaMinima Then
            'validacion de la entrada minima
            MsgBox("Entrada Menor a Requerida por el Banco")
        Else

            If ListView1.Items.Count <= 0 Then
                MainClass.grabaCotizacion(True, gVar.codCli, MainClass.CualCod(ComboBox2.Text), gVar.vModelo, gVar.vPrecio, ComboBox3.Text, TextBox2.Text, ComboBox1.Text, TextBox5.Text, TextBox3.Text, TextBox4.Text)
                MainClass.cargaListaCotiza(gVar.codCli, ListView1)
            Else
                MainClass.grabaCotizacion(False, gVar.codCli, MainClass.CualCod(ComboBox2.Text), gVar.vModelo, gVar.vPrecio, ComboBox3.Text, TextBox2.Text, ComboBox1.Text, TextBox5.Text, TextBox3.Text, TextBox4.Text)
                MainClass.cargaListaCotiza(gVar.codCli, ListView1)

            End If
     End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llamaBuscaClientes()
    End Sub

    Sub resetea()
        TextBox2.Text = "0"
        TextBox5.Text = "0"
        TextBox3.Text = ""
        TextBox4.Text = ""
        ListView1.Items.Clear()
        Me.SetBounds(Me.Location.X, Me.Location.Y, 486, 112)


    End Sub

    Sub llamaBuscaClientes()
        Dim x As New frmBuscaCliente
        x.ShowDialog()
        If gVar.codCli > 0 Then

            TextBox1.Text = Str(gVar.codCli) + " - " + gVar.tNombres
            '    MainClass.cargaListaCotiza(gVar.codCli, ListView1)
            MainClass.cargaComboCotiza(gVar.codCli, cbocot)
            Label15.Enabled = True
            cbocot.Enabled = True
            GroupBox2.Enabled = True
            Me.SetBounds(Me.Location.X, Me.Location.Y, 486, 112)
            resetea()
            cbocot.Focus()
        End If
    End Sub

    Private Sub cargaDatos()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then
            MainClass.eliminaCotizacion(ListView1.SelectedItems(0).Text)
            MainClass.cargaListaCotiza(gVar.codCli, ListView1)
        Else
            MsgBox("No hay seleccion")
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        MainClass.cargaBancos(MainClass.CualCod(ComboBox3.Text))
        gVar.tempEntradaMinima = (gVar.vPrecio * gVar.bEntrada) / 100
        Dim x As New Integer
        x = 0
        ComboBox1.Items.Clear()
        Do While gVar.bPlazo > x
            x = x + 12
            ComboBox1.Items.Add(Str(x))
        Loop

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If gVar.codCli > 0 Then

            Dim x As New frmreportes
            x.Owner = Me
            x.ShowDialog()
            resetea()
            'nuevo --------------------------------------
            MainClass.cargaComboCotiza(gVar.codCli, cbocot)
        End If

    End Sub

    Private Sub cbocot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocot.Click

    End Sub

    Private Sub cbocot_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocot.DropDown

    End Sub

    Private Sub cbocot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbocot.KeyDown

    End Sub

    Private Sub cbocot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbocot.KeyPress
        
    End Sub

    Private Sub cbocot_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbocot.MouseClick

    End Sub


    Private Sub cbocot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocot.SelectedIndexChanged
        Select Case cbocot.SelectedIndex
            Case 0
                If permitenuevo Then
                    Me.SetBounds(Me.Location.X, Me.Location.Y, 486, 651)
                End If
            Case Else
                Me.SetBounds(Me.Location.X, Me.Location.Y, 486, 112)
                Dim CADENA As String = cbocot.SelectedItem

                Dim aa As Integer = CADENA.IndexOf("(")
                If aa < 1 Then
                    gVar.NumCot = CInt(CADENA)
                Else
                    gVar.NumCot = CInt(CADENA.Substring(0, aa))
                End If

                Dim x As New frmreportes
                x.Owner = Me
                x.Show()
                'nuevo-------------------------------
                MainClass.cargaComboCotiza(gVar.codCli, cbocot)

        End Select
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            llamaBuscaClientes()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub cbocot_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocot.SelectedValueChanged
        

    End Sub

    Private Sub cbocot_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocot.SelectionChangeCommitted
        
    End Sub
End Class
