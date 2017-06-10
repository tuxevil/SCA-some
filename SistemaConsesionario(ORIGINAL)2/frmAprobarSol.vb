Public Class frmAprobarSol



    Dim dt As New DataTable
    Private Sub frmAprobarSol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
        Me.SetBounds(Me.Location.X, Me.Location.Y, 588, 90)
        TextBox1.Focus()

    End Sub



    Sub llenadatos(ByVal nombre As String)


        Try
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If gVar.utUsuarios = 1 Then
                If TextBox1.Text = "" Then
                    SqlDataAdapter1.SelectCommand.CommandText = "SELECT solicitudes_cod,fecha_impreso,Codigo_Usuario ,clientes_codigo ,bancos_descripcion ,solicitudes_aprobado  FROM caSolicitudes "

                Else
                    SqlDataAdapter1.SelectCommand.CommandText = "SELECT solicitudes_cod,fecha_impreso,Codigo_Usuario ,clientes_codigo ,bancos_descripcion ,solicitudes_aprobado  FROM caSolicitudes where clientes_codigo='" & nombre & "'"

                End If
            Else
                If TextBox1.Text = "" Then
                    SqlDataAdapter1.SelectCommand.CommandText = "SELECT solicitudes_cod,fecha_impreso,Codigo_Usuario,clientes_codigo ,bancos_descripcion ,solicitudes_aprobado  FROM caSolicitudes where Codigo_Usuario='" & gVar.tempNickUser & "' "

                Else
                    SqlDataAdapter1.SelectCommand.CommandText = "SELECT solicitudes_cod,fecha_impreso,Codigo_Usuario,clientes_codigo ,bancos_descripcion ,solicitudes_aprobado  FROM caSolicitudes where Codigo_Usuario='" & gVar.tempNickUser & "' and clientes_codigo='" & nombre & "'"

                End If

            End If


            SqlDataAdapter1.Fill(dt)
            'DataGridView1.DataSource = DataSet1.Tables(0)



            DataGridView1.DataSource = dt
            DataGridView1.Columns(5).Visible = False


            DataGridView1.Columns.Add("dd", "Aprobado")
            DataGridView1.Columns.Add("d", "Desaprobado")
            DataGridView1.Columns(0).ReadOnly = True
            DataGridView1.Columns(1).ReadOnly = True
            DataGridView1.Columns(2).ReadOnly = True
            DataGridView1.Columns(3).ReadOnly = True
            DataGridView1.Columns(4).ReadOnly = True
            DataGridView1.Columns(5).ReadOnly = True

            DataGridView1.Columns(0).Width = 20
            DataGridView1.Columns(3).Width = 180
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(6).Width = 20
            DataGridView1.Columns(7).Width = 20

            'dt.Columns.Add(New System.Data.DataColumn)

            '  DataGridView1.Columns(0).Name = "Vendedor"
            lee_datos(nombre)
        Catch ex As Exception

        End Try

       
    End Sub


    Sub busca_clientes()
           Dim x As New frmBuscaCliente
        x.ShowDialog()


        If gVar.codCli > 0 Then

            TextBox1.Text = Str(gVar.codCli) + " - " + gVar.tNombres
            '    MainClass.cargaListaCotiza(gVar.codCli, ListView1)
            '        Me.SetBounds(Me.Location.X, Me.Location.Y, 486, 124)

            llenadatos(gVar.tNombres)


        End If
        


    End Sub




    Private Sub busca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles busca.Click
        reset()

        busca_clientes()
        '  DataGridView1.Columns(3).ReadOnly = True
        busca.Enabled = False
        TextBox1.Enabled = False
        busca.Visible = False
        TextBox1.Visible = False
        DataGridView1.Visible = True
        Label3.Visible = False
        Me.SetBounds(Me.Location.X, Me.Location.Y, 588, 309)


    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then



            reset()

            busca_clientes()
            '  DataGridView1.Columns(3).ReadOnly = True
            busca.Enabled = False
            TextBox1.Enabled = False
            busca.Visible = False
            TextBox1.Visible = False
            DataGridView1.Visible = True
            Label3.Visible = False
            Me.SetBounds(Me.Location.X, Me.Location.Y, 588, 309)




        End If
    End Sub

    Private Sub frmAprobarSol_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        TextBox1.Focus()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'If Not DataGridView1.Rows(e.RowIndex).Cells(0).ReadOnly Then
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value) 'obtiene el valor del codigo
            If e.ColumnIndex = 6 Then
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "X"
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = ""
            ElseIf e.ColumnIndex = 7 Then

                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "X"
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = ""


            End If

              'DataGridView1.Rows(e.RowIndex).Cells(0).ReadOnly = True
            grababase(DataGridView1.Rows(e.RowIndex).Cells(0).Value, e.ColumnIndex, e.RowIndex)

        End If
        'End If

    End Sub

    Sub lee_datos(ByVal nombre As String)
        Dim cn As ADODB.Connection
        Dim rs As New ADODB.Recordset()
        cn = New ADODB.Connection()
        cn.Open("Provider=SQLOLEDB;Data Source='" & gVar.Nombre_Server & "';User ID=sa;Password=gotechdev;Initial Catalog=conAutomotriz")
        rs = cn.Execute("Select solicitudes_aprobado from caSolicitudes where clientes_codigo='" & nombre & "' and codigo_usuario='sreal'")


        If gVar.utUsuarios = 1 Then
            If TextBox1.Text = "" Then
                rs = cn.Execute("Select solicitudes_aprobado from caSolicitudes ")

            Else
                rs = cn.Execute("Select solicitudes_aprobado from caSolicitudes where clientes_codigo='" & nombre & "' ")

            End If
        Else
            If TextBox1.Text = "" Then
                SqlDataAdapter1.SelectCommand.CommandText = "SELECT solicitudes_cod,fecha_impreso,clientes_codigo ,bancos_descripcion ,solicitudes_aprobado  FROM caSolicitudes where Codigo_Usuario='" & gVar.tempNickUser & "' "
                rs = cn.Execute("Select solicitudes_aprobado from caSolicitudes where   codigo_usuario='" & gVar.tempNickUser & "'")

            Else
                SqlDataAdapter1.SelectCommand.CommandText = "SELECT solicitudes_cod,fecha_impreso,clientes_codigo ,bancos_descripcion ,solicitudes_aprobado  FROM caSolicitudes where Codigo_Usuario='" & gVar.tempNickUser & "' and clientes_codigo='" & nombre & "'"
                rs = cn.Execute("Select solicitudes_aprobado from caSolicitudes where  clientes_codigo='" & nombre & "'  and codigo_usuario='" & gVar.tempNickUser & "'")

            End If

        End If


        'MsgBox(rs.Fields(0).Value)

        Try
            For k As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim tmp As Integer = rs.Fields(0).Value
                If tmp = 1 Then
                    DataGridView1.Rows(k).Cells(6).Value = "X"
                ElseIf tmp = 0 Then
                    DataGridView1.Rows(k).Cells(7).Value = "X"
                End If

                rs.MoveNext()
            Next

        Catch ex As Exception

        End Try
        

        cn.Close()





    End Sub
    Sub grababase(ByVal a As Integer, ByVal i As Integer, ByVal j As Integer)
        If i = 6 Or i = 7 Then
            Dim cn As ADODB.Connection

            cn = New ADODB.Connection()

            cn.Open("Provider=SQLOLEDB;Data Source='" & gVar.Nombre_Server & "';User ID=sa;Password=gotechdev;Initial Catalog=conAutomotriz")

            If i = 7 Then
                cn.Execute("update caSolicitudes set solicitudes_Aprobado=0 where solicitudes_cod=" & a & "")

            ElseIf i = 6 Then
                cn.Execute("update caSolicitudes set solicitudes_Aprobado=1 where solicitudes_cod=" & a & "")

            End If

            cn.Close()
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Sub reset()
        DataGridView1.Columns.Clear()
        '   MsgBox(DataGridView1.Rows.Count)

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class