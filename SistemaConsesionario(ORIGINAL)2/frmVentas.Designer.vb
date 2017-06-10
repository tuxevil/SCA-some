<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.g1 = New System.Windows.Forms.GroupBox
        Me.rano = New System.Windows.Forms.RadioButton
        Me.rmes = New System.Windows.Forms.RadioButton
        Me.rquincena = New System.Windows.Forms.RadioButton
        Me.rsemana = New System.Windows.Forms.RadioButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.g2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.g1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.g2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Tiempo"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(246, 150)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.g1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(238, 124)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'g1
        '
        Me.g1.Controls.Add(Me.rano)
        Me.g1.Controls.Add(Me.rmes)
        Me.g1.Controls.Add(Me.rquincena)
        Me.g1.Controls.Add(Me.rsemana)
        Me.g1.Location = New System.Drawing.Point(13, 6)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(219, 106)
        Me.g1.TabIndex = 8
        Me.g1.TabStop = False
        '
        'rano
        '
        Me.rano.AutoSize = True
        Me.rano.Location = New System.Drawing.Point(6, 82)
        Me.rano.Name = "rano"
        Me.rano.Size = New System.Drawing.Size(63, 17)
        Me.rano.TabIndex = 5
        Me.rano.TabStop = True
        Me.rano.Text = "Por Año"
        Me.rano.UseVisualStyleBackColor = True
        '
        'rmes
        '
        Me.rmes.AutoSize = True
        Me.rmes.Location = New System.Drawing.Point(6, 59)
        Me.rmes.Name = "rmes"
        Me.rmes.Size = New System.Drawing.Size(64, 17)
        Me.rmes.TabIndex = 4
        Me.rmes.TabStop = True
        Me.rmes.Text = "Por Mes"
        Me.rmes.UseVisualStyleBackColor = True
        '
        'rquincena
        '
        Me.rquincena.AutoSize = True
        Me.rquincena.Location = New System.Drawing.Point(6, 36)
        Me.rquincena.Name = "rquincena"
        Me.rquincena.Size = New System.Drawing.Size(90, 17)
        Me.rquincena.TabIndex = 3
        Me.rquincena.TabStop = True
        Me.rquincena.Text = "Por Quincena"
        Me.rquincena.UseVisualStyleBackColor = True
        '
        'rsemana
        '
        Me.rsemana.AutoSize = True
        Me.rsemana.Location = New System.Drawing.Point(6, 13)
        Me.rsemana.Name = "rsemana"
        Me.rsemana.Size = New System.Drawing.Size(83, 17)
        Me.rsemana.TabIndex = 2
        Me.rsemana.TabStop = True
        Me.rsemana.Text = "Por Semana"
        Me.rsemana.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.g2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(238, 124)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'g2
        '
        Me.g2.Controls.Add(Me.Label2)
        Me.g2.Controls.Add(Me.Label1)
        Me.g2.Controls.Add(Me.DateTimePicker2)
        Me.g2.Controls.Add(Me.DateTimePicker1)
        Me.g2.Location = New System.Drawing.Point(6, 6)
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(227, 106)
        Me.g2.TabIndex = 9
        Me.g2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(9, 80)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Reporte de Cotizaciones", "Reporte de Ventas", "Reporte de Solicitudes de Crédito"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 51)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Reporte"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(116, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ver Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 285)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVentas"
        Me.ShowInTaskbar = False
        Me.Text = "Reportes Administrativos"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.g1.ResumeLayout(False)
        Me.g1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.g2.ResumeLayout(False)
        Me.g2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rano As System.Windows.Forms.RadioButton
    Friend WithEvents rmes As System.Windows.Forms.RadioButton
    Friend WithEvents rquincena As System.Windows.Forms.RadioButton
    Friend WithEvents rsemana As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents g1 As System.Windows.Forms.GroupBox
    Friend WithEvents g2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
