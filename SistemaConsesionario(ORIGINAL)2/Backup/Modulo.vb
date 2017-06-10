Module Modulo

    Public MainClass As New SuperClase
    Public gVar As New var_globales


    Public Sub main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        MainClass.CargaOp()
        Dim y As New frmTecDev
        y.ShowDialog()
        Dim x As New mainConcesionario
        x.ShowDialog()
    End Sub

End Module
