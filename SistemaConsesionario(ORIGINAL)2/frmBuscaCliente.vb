
Public Class frmBuscaCliente
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
    Friend WithEvents TextBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaCliente))
        Me.TextBuscar = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(89, 12)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(464, 20)
        Me.TextBuscar.TabIndex = 9
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(544, 328)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ced./RUC"
        Me.ColumnHeader2.Width = 114
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre/Empresa"
        Me.ColumnHeader3.Width = 253
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Usuario"
        Me.ColumnHeader4.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre :"
        '
        'frmBuscaCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 379)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscaCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub TextBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBuscar.TextChanged

    End Sub

    Private Sub TextBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBuscar.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            llenaCLientes()
        End If
    End Sub

    Sub llenaCLientes()
        ListView1.Items.Clear()
        MainClass.buscaClientesExternos(TextBuscar.Text, ListView1)
        ListView1.Focus()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)

        Dim letra As String = e.KeyChar

        If keyascii = 27 Then
            Me.Close()
        End If

        If Not keyascii = 13 And Not keyascii = 27 Then

            'seleccion de letras------------------------
            Dim temp As String
            Dim i As Integer = 0
            Dim found As Boolean = False

            Do
                temp = ListView1.Items(i).SubItems(2).Text
                If letra.ToUpper() = temp.Substring(0, 1) Or letra.ToLower() = temp.Substring(0, 1) Then
                    found = True

                    If Not ListView1.SelectedItems.Count < 1 Then
                        ListView1.SelectedItems(0).Selected = False
                    Else
                        ListView1.FocusedItem.Selected = False
                    End If

                    ListView1.Items(i).Selected = True
                End If
                i = i + 1
                If i >= ListView1.Items.Count Then
                    Exit Do
                End If
            Loop While found = False
            '------------------------------
        End If



        If keyascii = 13 And ListView1.SelectedItems.Count > 0 Then
            If (ListView1.SelectedItems(0).SubItems(3).Text = gVar.tempNickUser Or gVar.superuser = 1) Then
                gVar.codCli = ListView1.SelectedItems(0).Text
                gVar.tNombres = ListView1.SelectedItems(0).SubItems(2).Text
                Me.Close()
            Else
                MsgBox("Cliente Corresponde a Otro Vendedor")
            End If

        End If


    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If (ListView1.SelectedItems(0).SubItems(3).Text = gVar.tempNickUser Or gVar.superuser = 1) Then
            gVar.codCli = ListView1.SelectedItems(0).Text
            gVar.tNombres = ListView1.SelectedItems(0).SubItems(2).Text
            Me.Close()
        Else
            MsgBox("Cliente Corresponde a Otro Vendedor")
        End If
    End Sub

    Private Sub frmBuscaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        llenaCLientes()
        ListView1.Items(0).Selected = True

        'ListView1.Focus()


    End Sub
End Class
