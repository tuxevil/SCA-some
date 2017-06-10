Public Class mainConcesionario
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem13, Me.MenuItem5, Me.MenuItem16, Me.MenuItem14, Me.MenuItem17, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem19})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
        Me.MenuItem1.Text = "Clientes"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Datos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Seguimiento"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem15})
        Me.MenuItem13.Text = "Procesos"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Cotizaciones"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "Ingreso de Solicitudes de Credito"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem9})
        Me.MenuItem5.Text = "Reportes"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem6.Text = "Clientes"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "Proformas"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Solicitudes de Credito"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem9.Text = "Usuarios"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Clientes x Tipo"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Cotizaciones Emitidas x Usuario"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Solicitudes de Credito Aprobadas/Negadas"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem18})
        Me.MenuItem16.Text = "Parametros"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Vehiculos"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Bancos"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "Usuarios"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 4
        Me.MenuItem14.Text = ""
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 5
        Me.MenuItem17.Text = ""
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.Text = ""
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 7
        Me.MenuItem24.Text = "Agenda"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 8
        Me.MenuItem25.Text = "Cerrar Sesion"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Text = "Salir"
        '
        'mainConcesionario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 555)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "mainConcesionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NIKKEI/ORGU Sistema Control de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim x As New frmClientes
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim x As New frmSeguimiento
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim x As New frmCotizaciones
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim x As New frmCredito
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim x As New frmVehiculos
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub mainConcesionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As New frmLogin
        x.ShowDialog()

        If gVar.tempAcceso = 1 Then
            Me.cargaPermisos()
            Me.Text = "NIKKEI/ORGU Sistema Control de Clientes" + " - " + gVar.tempNombreUSer
            Dim y As New frmAgenda
            y.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim x As New frmAgenda
        x.ShowDialog()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim x As New frmBuscaCotizacion
        x.ShowDialog()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim x As New frmImpCredito
        x.ShowDialog()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click

    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click

    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim x As New frmLogin
        x.ShowDialog()
        If gVar.tempAcceso = 1 Then
            Me.cargaPermisos()
            Me.Text = "NIKKEI/ORGU Sistema Control de Clientes" + " - " + gVar.tempNombreUSer
            Dim y As New frmAgenda
            y.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cargaPermisos()
        If gVar.utDatos = 1 Then
            MenuItem2.Enabled = True
        Else
            MenuItem2.Enabled = False
        End If
        If gVar.utSeguimiento = 1 Then
            MenuItem3.Enabled = True
        Else
            MenuItem3.Enabled = False
        End If
        If gVar.utCotizaciones = 1 Then
            MenuItem4.Enabled = True
        Else
            MenuItem4.Enabled = False
        End If
        If gVar.utIngresoCredito = 1 Then
            MenuItem15.Enabled = True
        Else
            MenuItem15.Enabled = False
        End If
        If gVar.utClientes = 1 Then
            MenuItem6.Enabled = True
        Else
            MenuItem6.Enabled = False
        End If
        If gVar.utUsuarios = 1 Then
            MenuItem9.Enabled = True
        Else
            MenuItem9.Enabled = False
        End If
        If gVar.utVehiculos = 1 Then
            MenuItem21.Enabled = True
        Else
            MenuItem21.Enabled = False
        End If
        If gVar.utBancos = 1 Then
            MenuItem22.Enabled = True
        Else
            MenuItem22.Enabled = False
        End If
        If gVar.utParUsuarios = 1 Then
            MenuItem18.Enabled = True
        Else
            MenuItem18.Enabled = False
        End If
        If gVar.utAgenda = 1 Then
            MenuItem24.Enabled = True
        Else
            MenuItem24.Enabled = False
        End If
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim x As New frmUsuarios
        x.ShowDialog()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim x As New frmBancos
        x.ShowDialog()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Me.Close()
    End Sub
End Class
