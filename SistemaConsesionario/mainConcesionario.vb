Public Class mainConcesionario

    Private Sub DatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem.Click
        Dim x As New frmClientes
        'x.MdiParent = Me
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoToolStripMenuItem.Click
        Dim x As New frmSeguimiento
        'x.MdiParent = Me
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesToolStripMenuItem.Click
        Dim x As New frmCotizaciones
        'x.MdiParent = Me
        x.permiteN = True
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub IngresoDeSolicitudesDeCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeSolicitudesDeCToolStripMenuItem.Click
        Dim x As New frmCredito
        'x.MdiParent = Me
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub ProformasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProformasToolStripMenuItem.Click
        Dim x As New frmCotizaciones
        x.permiteN = False

        x.Owner = Me
        x.Show()
    End Sub

    Private Sub SolicitudesDeCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudesDeCréditoToolStripMenuItem.Click
        Dim x As New frmImpCredito
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub VehículosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehículosToolStripMenuItem.Click
        Dim x As New frmVehiculos
        '  x.MdiParent = Me
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem.Click
        Dim x As New frmBancos
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Dim x As New frmUsuarios
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmAgenda
        x.ShowDialog()
    End Sub

    Private Sub CerrarSecionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmLogin
        x.ShowDialog()
        If gVar.tempAcceso = 1 Then
            Me.cargaPermisos()
            Me.Text = "Sistema Comercial Automotriz" + " - " + gVar.tempNombreUSer
            Dim y As New frmAgenda
            y.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub mainConcesionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Show()

        Dim x As New frmLogin
        x.ShowDialog()
        If gVar.tempAcceso = 1 Then
            Me.cargaPermisos()
            Me.Text = "Sistema Comercial Automotriz" + " - " + gVar.tempNombreUSer



            If gVar.fecha_orden = "ASC" Then
                gVar.Fecha_Asc = 1
            Else
                gVar.Fecha_Asc = 2
            End If


            Dim y As New frmAgenda
            y.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cargaPermisos()
        If gVar.utDatos = 1 Then
            DatosToolStripMenuItem.Enabled = True
        Else
            DatosToolStripMenuItem.Enabled = False
        End If
        If gVar.utSeguimiento = 1 Then
            SeguimientoToolStripMenuItem.Enabled = True
        Else
            SeguimientoToolStripMenuItem.Enabled = False
        End If
        If gVar.utCotizaciones = 1 Then
            CotizacionesToolStripMenuItem.Enabled = True
        Else
            CotizacionesToolStripMenuItem.Enabled = False
        End If
        If gVar.utIngresoCredito = 1 Then
            IngresoDeSolicitudesDeCToolStripMenuItem.Enabled = True
        Else
            IngresoDeSolicitudesDeCToolStripMenuItem.Enabled = False
        End If
        If gVar.utClientes = 1 Then
            ClientesToolStripMenuItem1.Enabled = True
        Else
            ClientesToolStripMenuItem1.Enabled = False
        End If
        If gVar.utUsuarios = 1 Then
            mnuusuario.Enabled = True
        Else
            mnuusuario.Enabled = False
        End If
        If gVar.utVehiculos = 1 Then
            VehículosToolStripMenuItem.Enabled = True
        Else
            VehículosToolStripMenuItem.Enabled = False
        End If
        If gVar.utBancos = 1 Then
            BancosToolStripMenuItem.Enabled = True
        Else
            BancosToolStripMenuItem.Enabled = False
        End If
        If gVar.utParUsuarios = 1 Then
            UsuariosToolStripMenuItem1.Enabled = True
        Else
            UsuariosToolStripMenuItem1.Enabled = False
        End If
        If gVar.utAgenda = 1 Then
            ToolStripButton1.Enabled = True
        Else
            ToolStripButton1.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim x As New frmAgenda
        x.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim x As New frmLogin
        x.ShowDialog()
        If gVar.tempAcceso = 1 Then
            Me.cargaPermisos()
            Me.Text = "Sistema Comercial Automotriz" + " - " + gVar.tempNombreUSer
            Dim y As New frmAgenda
            y.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub AgendaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaToolStripMenuItem.Click
        Dim x As New frmAgenda
        x.ShowDialog()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim x As New frmLogin
        x.ShowDialog()
        If gVar.tempAcceso = 1 Then
            Me.cargaPermisos()
            Me.Text = "Sistema Comercial Automotriz" + " - " + gVar.tempNombreUSer
            Dim y As New frmAgenda
            y.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ApagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApagarToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub mnuusuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuusuario.Click
        Dim x As New frmVentas()
        x.Owner = Me
        x.Show()
    End Sub

 
    Private Sub AprobarSolicitudesDeCrñToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AprobarSolicitudesDeCrñToolStripMenuItem.Click
        Dim x As New frmAprobarSol
        x.Owner = Me
        x.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(gVar.Fecha_Asc & "," & gVar.reporte_solicitudes)
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class