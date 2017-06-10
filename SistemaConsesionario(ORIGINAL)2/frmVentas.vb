Public Class frmVentas

    Dim fec1 As System.DateTime = System.DateTime.Today
    Dim fec2 As System.DateTime = System.DateTime.Today




    Private Sub frmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabPage1.Text = "Establecido"
        TabPage2.Text = "Personalizado"
        rmes.Checked = True
        ComboBox1.SelectedIndex = 0
        gVar.RAflag = 1

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                gVar.RAflag = 1
            Case 1
                gVar.RAflag = 2
            Case 2
                gVar.RAflag = 3

        End Select
    End Sub

    Private Sub rsemana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rsemana.CheckedChanged
        If rsemana.Checked = True Then
            fec1 = DateSerial(Year(System.DateTime.Today), Month(System.DateTime.Today), System.DateTime.Today.Day() - 7)
            fec2 = System.DateTime.Today
        Else

        End If
    End Sub

    Private Sub rquincena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rquincena.CheckedChanged
        If rquincena.Checked = True Then
            fec1 = DateSerial(Year(System.DateTime.Today), Month(System.DateTime.Today), System.DateTime.Today.Day() - 15)
            fec2 = System.DateTime.Today
        Else

        End If
    End Sub

    Private Sub rmes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmes.CheckedChanged
        If rmes.Checked = True Then
            fec1 = DateSerial(Year(System.DateTime.Today), Month(System.DateTime.Today) - 1, System.DateTime.Today.Day())
            fec2 = System.DateTime.Today
        Else

        End If
    End Sub

    Private Sub rano_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rano.CheckedChanged
        If rano.Checked = True Then
            fec1 = DateSerial(Year(System.DateTime.Today) - 1, Month(System.DateTime.Today), System.DateTime.Today.Day())
            fec2 = System.DateTime.Today
        Else

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        validaFec()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        validaFec()
    End Sub

    Sub validaFec()
        If DateTimePicker2.Value > System.DateTime.Today Then
            fec2 = System.DateTime.Today
        End If
        If DateTimePicker1.Value < DateTimePicker2.Value Then
            fec1 = DateTimePicker1.Value
            fec2 = DateTimePicker2.Value
        ElseIf DateTimePicker1.Value = DateTimePicker2.Value Then
            fec1 = System.DateTime.Today
            fec2 = System.DateTime.Today
        ElseIf DateTimePicker1.Value > DateTimePicker2.Value Then
            fec1 = System.DateTime.Today
            fec2 = System.DateTime.Today
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gVar.RAfec1 = fec1
        gVar.RAfec2 = fec2
        Dim x As New frmReportesVentas()
        x.Owner = Me
        x.Show()



    End Sub
End Class