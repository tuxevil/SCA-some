Public Class frmMultiCotizacion
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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 96)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(488, 280)
        Me.ListView1.TabIndex = 31
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Codigo"
        Me.ColumnHeader4.Width = 47
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Institucion"
        Me.ColumnHeader1.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modelo"
        Me.ColumnHeader3.Width = 146
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Entrada"
        Me.ColumnHeader5.Width = 84
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Plazo (meses)"
        Me.ColumnHeader6.Width = 81
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Cotizacion Nro."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMultiCotizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 395)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMultiCotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Cotizacion"
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        gVar.codCli = ListView1.SelectedItems(0).Text
        gVar.cModelo = ListView1.SelectedItems(0).SubItems(1).Text
        gVar.cInstitucion = ListView1.SelectedItems(0).SubItems(2).Text
        gVar.cEntrada = ListView1.SelectedItems(0).SubItems(3).Text
        gVar.cPlazo = ListView1.SelectedItems(0).SubItems(4).Text
    End Sub
End Class
