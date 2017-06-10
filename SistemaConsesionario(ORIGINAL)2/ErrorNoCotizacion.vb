Public Class ErrorNoCotizacion

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim x As New frmCotizaciones
        'x.MdiParent = Me
        x.permiteN = True
        x.Owner = Me.Owner
        x.Show()
        'Me.Visible = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ErrorNoCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(My.Computer.Screen.WorkingArea.Width / 2 - 100, My.Computer.Screen.WorkingArea.Height / 2, Me.Size.Width, Me.Size.Height)
        Button1.Focus()

    End Sub
End Class