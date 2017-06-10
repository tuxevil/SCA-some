Public Class ErrorDatosCredito


    Dim colec1 As New Collection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ErrorDatosCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub coleccion(ByVal col As Collection)
        colec1 = col
        ListBox1.DataSource = colec1
    End Sub

End Class