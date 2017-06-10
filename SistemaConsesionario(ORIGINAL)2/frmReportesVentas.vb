Public Class frmReportesVentas

    Private Sub frmReportesVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gVar.RAflag = 1 Then
            rv_1.ReportSource = gVar.reporte_cotizaciones
        ElseIf gVar.RAflag = 2 Then
            rv_1.ReportSource = gVar.reporte_ventas
        ElseIf gVar.RAflag = 3 Then
            rv_1.ReportSource = gVar.reporte_solicitudes
        End If


        If gVar.RAflag = 1 Or gVar.RAflag = 2 Then
            rv_1.SelectionFormula = "{caCotizacion.cot_fecha} in DateTime (" & gVar.RAfec1.Year & "," & gVar.RAfec1.Month & "," & gVar.RAfec1.Day & "," & gVar.RAfec1.Hour & "," & gVar.RAfec1.Minute & "," & gVar.RAfec1.Second & ") to DateTime (" & gVar.RAfec2.Year & "," & gVar.RAfec2.Month & "," & gVar.RAfec2.Day & "," & gVar.RAfec2.Hour & "," & gVar.RAfec2.Minute & "," & gVar.RAfec2.Second & ")"
        Else
            'selection formula de solicitud
            rv_1.SelectionFormula = "{caSolicitudes.fecha_impreso} in DateTime (" & gVar.RAfec1.Year & "," & gVar.RAfec1.Month & "," & gVar.RAfec1.Day & "," & gVar.RAfec1.Hour & "," & gVar.RAfec1.Minute & "," & gVar.RAfec1.Second & ") to DateTime (" & gVar.RAfec2.Year & "," & gVar.RAfec2.Month & "," & gVar.RAfec2.Day & "," & gVar.RAfec2.Hour & "," & gVar.RAfec2.Minute & "," & gVar.RAfec2.Second & ")"
        End If

        rv_1.RefreshReport()
    End Sub
End Class