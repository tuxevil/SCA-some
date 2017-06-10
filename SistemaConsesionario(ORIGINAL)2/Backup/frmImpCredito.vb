Public Class frmImpCredito
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cliente As System.Windows.Forms.TextBox
    Friend WithEvents rv_1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_paginas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cliente = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.rv_1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.cb_paginas = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.Location = New System.Drawing.Point(8, 24)
        Me.cliente.MaxLength = 30
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(344, 20)
        Me.cliente.TabIndex = 104
        Me.cliente.Text = ""
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Cliente:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(352, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 23)
        Me.Button2.TabIndex = 106
        Me.Button2.Text = "?"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Location = New System.Drawing.Point(376, 24)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(256, 21)
        Me.ComboBox3.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(376, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Institucion Financiera:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(664, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 120
        Me.Button1.Text = "Generar"
        '
        'rv_1
        '
        Me.rv_1.ActiveViewIndex = -1
        Me.rv_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rv_1.DisplayGroupTree = False
        Me.rv_1.Location = New System.Drawing.Point(8, 80)
        Me.rv_1.Name = "rv_1"
        Me.rv_1.ReportSource = Nothing
        Me.rv_1.Size = New System.Drawing.Size(728, 336)
        Me.rv_1.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(640, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Paginas:"
        '
        'cb_paginas
        '
        Me.cb_paginas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_paginas.Location = New System.Drawing.Point(640, 24)
        Me.cb_paginas.Name = "cb_paginas"
        Me.cb_paginas.Size = New System.Drawing.Size(96, 21)
        Me.cb_paginas.TabIndex = 115
        '
        'frmImpCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(746, 429)
        Me.Controls.Add(Me.cb_paginas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rv_1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmImpCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Solicitudes de Credito"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmImpCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainClass.cargaComboBancos(ComboBox3)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As New frmBuscaCliente
        x.ShowDialog()
        cliente.Text = Str(gVar.codCli) + " - " + gVar.tNombres
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim x As New Integer
        x = 0
        MainClass.cargaBancos(MainClass.CualCod(ComboBox3.Text))
        cb_paginas.Items.Clear()
        Do While x < gVar.bPaginas
            x = x + 1
            cb_paginas.Items.Add(x)
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim count As Integer
        'count = 0
        'Do While count <= gVar.bPaginas
        rv_1.ReportSource = gVar.bRuta + Trim(cb_paginas.Text) + ".rpt"
        rv_1.SelectionFormula = "{caCredito.clientes_codigo}=" & MainClass.CualCod(cliente.Text) & " and {caCredito.credito_estado}='A'"
        rv_1.RefreshReport()
        '    count = count + 1
        'Loop
    End Sub
End Class
