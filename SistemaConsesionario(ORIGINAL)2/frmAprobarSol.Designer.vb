<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprobarSol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAprobarSol))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DataSet1 = New System.Data.DataSet
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.busca = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(578, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(4, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cliente:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=SERVIDOR-DEV\SQLEXPRESS;Initial Catalog=conAutomotriz;User ID=sa;Pass" & _
            "word=gotechdev"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT * FROM caSolicitudes"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo_Usuario", System.Data.SqlDbType.[Char], 0, "Codigo_Usuario"), New System.Data.SqlClient.SqlParameter("@clientes_codigo", System.Data.SqlDbType.[Char], 0, "clientes_codigo"), New System.Data.SqlClient.SqlParameter("@bancos_descripcion", System.Data.SqlDbType.[Char], 0, "bancos_descripcion"), New System.Data.SqlClient.SqlParameter("@solicitudes_Aprobado", System.Data.SqlDbType.Bit, 0, "solicitudes_Aprobado")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo_Usuario", System.Data.SqlDbType.[Char], 0, "Codigo_Usuario"), New System.Data.SqlClient.SqlParameter("@clientes_codigo", System.Data.SqlDbType.[Char], 0, "clientes_codigo"), New System.Data.SqlClient.SqlParameter("@bancos_descripcion", System.Data.SqlDbType.[Char], 0, "bancos_descripcion"), New System.Data.SqlClient.SqlParameter("@solicitudes_Aprobado", System.Data.SqlDbType.Bit, 0, "solicitudes_Aprobado"), New System.Data.SqlClient.SqlParameter("@Original_solicitudes_cod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "solicitudes_cod", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Codigo_Usuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_Usuario", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Codigo_Usuario", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_clientes_codigo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "clientes_codigo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_clientes_codigo", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clientes_codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bancos_descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bancos_descripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bancos_descripcion", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bancos_descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_solicitudes_Aprobado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "solicitudes_Aprobado", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_solicitudes_Aprobado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "solicitudes_Aprobado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@solicitudes_cod", System.Data.SqlDbType.Int, 4, "solicitudes_cod")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_solicitudes_cod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "solicitudes_cod", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Codigo_Usuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_Usuario", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Codigo_Usuario", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_clientes_codigo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "clientes_codigo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_clientes_codigo", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clientes_codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bancos_descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bancos_descripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bancos_descripcion", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bancos_descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_solicitudes_Aprobado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "solicitudes_Aprobado", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_solicitudes_Aprobado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "solicitudes_Aprobado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "caSolicitudes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("solicitudes_cod", "solicitudes_cod"), New System.Data.Common.DataColumnMapping("Codigo_Usuario", "Codigo_Usuario"), New System.Data.Common.DataColumnMapping("clientes_codigo", "clientes_codigo"), New System.Data.Common.DataColumnMapping("bancos_descripcion", "bancos_descripcion"), New System.Data.Common.DataColumnMapping("solicitudes_Aprobado", "solicitudes_Aprobado")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(452, 20)
        Me.TextBox1.TabIndex = 14
        '
        'busca
        '
        Me.busca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busca.Location = New System.Drawing.Point(463, 31)
        Me.busca.Name = "busca"
        Me.busca.Size = New System.Drawing.Size(24, 24)
        Me.busca.TabIndex = 15
        Me.busca.Text = "?"
        Me.busca.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(424, 254)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(157, 27)
        Me.Salir.TabIndex = 16
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'frmAprobarSol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 288)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.busca)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAprobarSol"
        Me.ShowInTaskbar = False
        Me.Text = "Aprobar Solicitudes de Crédito"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents busca As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
End Class
