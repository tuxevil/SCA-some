Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing
Public Class frmVehiculos
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
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lv_vehiculos As System.Windows.Forms.ListView
    Friend WithEvents tb_marca As System.Windows.Forms.TextBox
    Friend WithEvents tb_modelo As System.Windows.Forms.TextBox
    Friend WithEvents tb_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents tb_cilindraje As System.Windows.Forms.TextBox
    Friend WithEvents tb_transmision As System.Windows.Forms.TextBox
    Friend WithEvents tb_seguridad As System.Windows.Forms.TextBox
    Friend WithEvents tb_precio As System.Windows.Forms.TextBox
    Friend WithEvents imagen_item As System.Windows.Forms.PictureBox
    Friend WithEvents dgopen As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lv_vehiculos = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.tb_marca = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.imagen_item = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.tb_modelo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tb_descripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.tb_cilindraje = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_transmision = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_seguridad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.tb_precio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgopen = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lv_vehiculos
        '
        Me.lv_vehiculos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_vehiculos.FullRowSelect = True
        Me.lv_vehiculos.GridLines = True
        Me.lv_vehiculos.Location = New System.Drawing.Point(432, 8)
        Me.lv_vehiculos.Name = "lv_vehiculos"
        Me.lv_vehiculos.Size = New System.Drawing.Size(392, 360)
        Me.lv_vehiculos.TabIndex = 100
        Me.lv_vehiculos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modelo"
        Me.ColumnHeader3.Width = 221
        '
        'tb_marca
        '
        Me.tb_marca.Location = New System.Drawing.Point(176, 72)
        Me.tb_marca.MaxLength = 50
        Me.tb_marca.Name = "tb_marca"
        Me.tb_marca.Size = New System.Drawing.Size(248, 20)
        Me.tb_marca.TabIndex = 15
        Me.tb_marca.Text = ""
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(176, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Marca:"
        '
        'imagen_item
        '
        Me.imagen_item.BackColor = System.Drawing.Color.White
        Me.imagen_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagen_item.Location = New System.Drawing.Point(8, 16)
        Me.imagen_item.Name = "imagen_item"
        Me.imagen_item.Size = New System.Drawing.Size(160, 120)
        Me.imagen_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen_item.TabIndex = 33
        Me.imagen_item.TabStop = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(176, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Codigo:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(280, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "N"
        '
        'tb_modelo
        '
        Me.tb_modelo.Location = New System.Drawing.Point(176, 120)
        Me.tb_modelo.MaxLength = 50
        Me.tb_modelo.Name = "tb_modelo"
        Me.tb_modelo.Size = New System.Drawing.Size(248, 20)
        Me.tb_modelo.TabIndex = 20
        Me.tb_modelo.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(176, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Modelo:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(96, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Cargar"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.Location = New System.Drawing.Point(8, 184)
        Me.tb_descripcion.MaxLength = 300
        Me.tb_descripcion.Multiline = True
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(416, 50)
        Me.tb_descripcion.TabIndex = 25
        Me.tb_descripcion.Text = ""
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(8, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Descripcion:"
        '
        'tb_codigo
        '
        Me.tb_codigo.Enabled = False
        Me.tb_codigo.Location = New System.Drawing.Point(176, 32)
        Me.tb_codigo.MaxLength = 30
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(104, 20)
        Me.tb_codigo.TabIndex = 0
        Me.tb_codigo.Text = ""
        Me.tb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_cilindraje
        '
        Me.tb_cilindraje.Location = New System.Drawing.Point(8, 262)
        Me.tb_cilindraje.MaxLength = 50
        Me.tb_cilindraje.Name = "tb_cilindraje"
        Me.tb_cilindraje.Size = New System.Drawing.Size(200, 20)
        Me.tb_cilindraje.TabIndex = 30
        Me.tb_cilindraje.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(8, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Cilindraje/HP:"
        '
        'tb_transmision
        '
        Me.tb_transmision.Location = New System.Drawing.Point(224, 264)
        Me.tb_transmision.MaxLength = 50
        Me.tb_transmision.Name = "tb_transmision"
        Me.tb_transmision.Size = New System.Drawing.Size(200, 20)
        Me.tb_transmision.TabIndex = 35
        Me.tb_transmision.Text = ""
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(224, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Transmision/Cambios:"
        '
        'tb_seguridad
        '
        Me.tb_seguridad.Location = New System.Drawing.Point(8, 312)
        Me.tb_seguridad.MaxLength = 200
        Me.tb_seguridad.Name = "tb_seguridad"
        Me.tb_seguridad.Size = New System.Drawing.Size(416, 20)
        Me.tb_seguridad.TabIndex = 40
        Me.tb_seguridad.Text = ""
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(8, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Seguridad:"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(352, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Guardar"
        '
        'tb_precio
        '
        Me.tb_precio.Location = New System.Drawing.Point(312, 32)
        Me.tb_precio.MaxLength = 30
        Me.tb_precio.Name = "tb_precio"
        Me.tb_precio.Size = New System.Drawing.Size(112, 20)
        Me.tb_precio.TabIndex = 10
        Me.tb_precio.Text = ""
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(312, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Precio:"
        '
        'frmVehiculos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 381)
        Me.Controls.Add(Me.tb_precio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tb_seguridad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_transmision)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_cilindraje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(Me.tb_descripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_modelo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imagen_item)
        Me.Controls.Add(Me.tb_marca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lv_vehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainClass.llenaListaVehiculos(lv_vehiculos)
        imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & "logo.jpg")
    End Sub
    Private Sub cargaDatos()
        tb_codigo.Text = gVar.tempCodigo
        tb_precio.Text = gVar.tempPrecio
        tb_marca.Text = gVar.tempMarca
        tb_modelo.Text = gVar.tempModelo
        tb_descripcion.Text = gVar.tempDescripcion
        tb_cilindraje.Text = gVar.tempCilindraje
        tb_transmision.Text = gVar.tempTransmision
        tb_seguridad.Text = gVar.tempSeguridad
    End Sub

    Private Sub limpiaDatos()
        tb_precio.Text = ""
        tb_marca.Text = ""
        tb_modelo.Text = ""
        tb_descripcion.Text = ""
        tb_cilindraje.Text = ""
        tb_transmision.Text = ""
        tb_seguridad.Text = ""
    End Sub

    Private Sub lv_vehiculos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_vehiculos.Click
        If lv_vehiculos.SelectedItems.Count > 0 Then
            MainClass.cargaDatosVehiculo(lv_vehiculos.SelectedItems(0).Text)
            Me.cargaDatos()
            If File.Exists(MainClass.imagenes_autos & Trim(lv_vehiculos.SelectedItems(0).Text) & " - " & Trim(lv_vehiculos.SelectedItems(0).SubItems(2).Text) & ".jpg") = True Then
                imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & Trim(lv_vehiculos.SelectedItems(0).Text) & " - " & Trim(lv_vehiculos.SelectedItems(0).SubItems(2).Text) & ".jpg")
            Else
                imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & "logo.jpg")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MainClass.grabaDatosVehiculo(tb_codigo.Text, tb_precio.Text, tb_marca.Text, tb_modelo.Text, tb_descripcion.Text, tb_cilindraje.Text, tb_transmision.Text, tb_seguridad.Text)
        MainClass.llenaListaVehiculos(lv_vehiculos)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tb_codigo.Text = "Nuevo"
        Me.limpiaDatos()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        imagen_item.Image.Dispose()
        imagen_item.Image = Nothing
        dgopen.Title = "Cargando Imagen de Item..."
        dgopen.Filter = "Archivo JPG|*.jpg"
        dgopen.ShowDialog()
        Try
            If Not dgopen.FileName = String.Empty Then
                Dim i1 As System.Drawing.Image
                i1 = New Bitmap(dgopen.FileName)

                If File.Exists(MainClass.imagenes_autos & Trim(lv_vehiculos.SelectedItems(0).Text) & " - " & Trim(lv_vehiculos.SelectedItems(0).SubItems(2).Text) & ".jpg") = True Then
                    File.Delete(MainClass.imagenes_autos & Trim(lv_vehiculos.SelectedItems(0).Text) & " - " & Trim(lv_vehiculos.SelectedItems(0).SubItems(2).Text) & ".jpg")
                End If

                i1.Save(MainClass.imagenes_autos & Trim(lv_vehiculos.SelectedItems(0).Text) & " - " & Trim(lv_vehiculos.SelectedItems(0).SubItems(2).Text) & ".jpg")
                imagen_item.Image = Image.FromFile(dgopen.FileName)
            Else
                imagen_item.Image = Image.FromFile(MainClass.imagenes_autos & Trim(lv_vehiculos.SelectedItems(0).Text) & " - " & Trim(lv_vehiculos.SelectedItems(0).SubItems(2).Text) & ".jpg")
            End If
        Catch ex As Exception
            MsgBox("Formato no Compatible")
        End Try
        
    End Sub

    
End Class
