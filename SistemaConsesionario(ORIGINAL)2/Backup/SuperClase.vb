Public Class SuperClase


    Public provider_sql As String
    Public provider_pvs As String
    Public Printer_dire As String
    Public reporte_cotizaciones As String
    Public imagenes_autos As String
    Public Printer_Formula As String


    Public Sub CargaOp()
        Try
            Dim Fnum As Integer = FreeFile()
            Dim T As String
            FileOpen(Fnum, System.AppDomain.CurrentDomain.BaseDirectory & "TecDev.ini", OpenMode.Binary, OpenAccess.ReadWrite)
            While Not EOF(Fnum)
                T = LineInput(Fnum)
                If T = "--sql_autos--" Then
                    provider_sql = "Provider=SQLOLEDB;Data Source=" & LineInput(Fnum) & ";Initial Catalog=ConAutomotriz;User ID=sa;Password=jes025;"
                End If
                If T = "--Cotizaciones--" Then
                    reporte_cotizaciones = LineInput(Fnum)
                End If
                If T = "--Imagenes--" Then
                    imagenes_autos = LineInput(Fnum)
                End If
            End While
        Catch
            MsgBox("No se Ecuentra Archivo de sistema de Inicialización", MsgBoxStyle.Critical, "System Alert")
        End Try
    End Sub

    Public Function CualCod(ByVal X As String) As Double
        Dim Z As Integer
        Z = 1
        Do While Z < Len(X)
            If Mid(X, Z, 1) = "-" Then
                CualCod = CDbl(Mid(X, 1, Z - 1))
                Exit Function
            End If
            Z = Z + 1
        Loop
    End Function

    Public Sub llenaListaVehiculos(ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from cavehiculos where vehiculos_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        t.SubItems.Clear()
        Do While Rc.EOF = False
            t.SubItems.Clear()
            t.Text = Rc.Fields.Item("vehiculos_codigo").Value
            t.SubItems.Add(Trim(Rc.Fields.Item("vehiculos_marca").Value))
            t.SubItems.Add(Trim(Rc.Fields.Item("vehiculos_modelo").Value))
            lista.Items.Add(t.Clone)
            Rc.MoveNext()
        Loop
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub cargaDatosVehiculo(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from cavehiculos where vehiculos_estado='A' and vehiculos_codigo = " & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            gVar.tempCodigo = codigo
            If IsDBNull(Rc.Fields.Item("vehiculos_marca").Value) Then
                gVar.tempMarca = "No disponible"
            Else
                gVar.tempMarca = Trim(Rc.Fields.Item("vehiculos_marca").Value)
            End If
            If IsDBNull(Rc.Fields.Item("vehiculos_modelo").Value) Then
                gVar.tempModelo = "No disponible"
            Else
                gVar.tempModelo = Trim(Rc.Fields.Item("vehiculos_modelo").Value)
            End If
            If IsDBNull(Rc.Fields.Item("vehiculos_descripcion").Value) Then
                gVar.tempDescripcion = "No disponible"
            Else
                gVar.tempDescripcion = Trim(Rc.Fields.Item("vehiculos_descripcion").Value)
            End If
            If IsDBNull(Rc.Fields.Item("vehiculos_cilindraje").Value) Then
                gVar.tempCilindraje = "No disponible"
            Else
                gVar.tempCilindraje = Trim(Rc.Fields.Item("vehiculos_cilindraje").Value)
            End If
            If IsDBNull(Rc.Fields.Item("vehiculos_transmision").Value) Then
                gVar.tempTransmision = "No disponible"
            Else
                gVar.tempTransmision = Trim(Rc.Fields.Item("vehiculos_transmision").Value)
            End If
            If IsDBNull(Rc.Fields.Item("vehiculos_seguridad").Value) Then
                gVar.tempSeguridad = "No disponible"
            Else
                gVar.tempSeguridad = Trim(Rc.Fields.Item("vehiculos_seguridad").Value)
            End If
            If IsDBNull(Rc.Fields.Item("vehiculos_precio").Value) Then
                gVar.tempPrecio = "No disponible"
            Else
                gVar.tempPrecio = Trim(Rc.Fields.Item("vehiculos_precio").Value)
            End If
        End If
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabaDatosVehiculo(ByRef codigo As String, ByRef precio As String, ByRef marca As String, ByRef modelo As String, ByRef descripcion As String, ByRef cilindraje As String, ByRef transmision As String, ByRef seguridad As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        If codigo = "Nuevo" Then
            Rc.Open("select * from cavehiculos", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc.AddNew()
        Else
            Rc.Open("select * from cavehiculos where vehiculos_codigo = " & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        End If
        If precio = "" Then
            Rc.Fields.Item("vehiculos_precio").Value = 0
        Else
            Rc.Fields.Item("vehiculos_precio").Value = precio
        End If
        If marca = "" Then
            Rc.Fields.Item("vehiculos_marca").Value = "No disponible"
        Else
            Rc.Fields.Item("vehiculos_marca").Value = marca
        End If
        If modelo = "" Then
            Rc.Fields.Item("vehiculos_modelo").Value = "No disponible"
        Else
            Rc.Fields.Item("vehiculos_modelo").Value = modelo
        End If
        If descripcion = "" Then
            Rc.Fields.Item("vehiculos_descripcion").Value = "No disponible"
        Else
            Rc.Fields.Item("vehiculos_descripcion").Value = descripcion
        End If
        If cilindraje = "" Then
            Rc.Fields.Item("vehiculos_cilindraje").Value = "No disponible"
        Else
            Rc.Fields.Item("vehiculos_cilindraje").Value = cilindraje
        End If
        If transmision = "" Then
            Rc.Fields.Item("vehiculos_transmision").Value = "No disponible"
        Else
            Rc.Fields.Item("vehiculos_transmision").Value = transmision
        End If
        If seguridad = "" Then
            Rc.Fields.Item("vehiculos_seguridad").Value = "No disponible"
        Else
            Rc.Fields.Item("vehiculos_seguridad").Value = seguridad
        End If
        Rc.Fields.Item("vehiculos_fecha").Value = System.DateTime.Today
        Rc.Fields.Item("vehiculos_estado").Value = "A"
        Rc.Update()
        MsgBox("Datos Grabados Exitosamente", MsgBoxStyle.OKOnly, "Sistema Concesionario")
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabaDatosCliente(ByRef codigo As String, ByRef apellidoP As String, ByRef apellidoM As String, ByRef nombres As String, ByRef tipoID As String, ByRef ID As String, ByRef email As String, ByRef telefono As String, ByRef celular As String, ByRef fax As String, ByRef direccion As String, ByRef nick As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Try
            If codigo = "Nuevo" Then
                Rc.Open("select * from caClientes", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Rc.AddNew()
            Else
                Rc.Open("select * from caClientes where clientes_codigo = " & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            End If
            If apellidoP = "" Then
                Rc.Fields.Item("clientes_apellidop").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_apellidop").Value = apellidoP
            End If
            If apellidoM = "" Then
                Rc.Fields.Item("clientes_apellidom").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_apellidom").Value = apellidoM
            End If
            If nombres = "" Then
                Rc.Fields.Item("clientes_nombres").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_nombres").Value = nombres
            End If
            If tipoID = "" Then
                Rc.Fields.Item("clientes_tipoid").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_tipoid").Value = tipoID
            End If
            If ID = "" Then
                Rc.Fields.Item("clientes_id").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_id").Value = ID
            End If
            If email = "" Then
                Rc.Fields.Item("clientes_email").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_email").Value = email
            End If
            If telefono = "" Then
                Rc.Fields.Item("clientes_telefono").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_telefono").Value = telefono
            End If
            If celular = "" Then
                Rc.Fields.Item("clientes_celular").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_celular").Value = celular
            End If
            If fax = "" Then
                Rc.Fields.Item("clientes_fax").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_fax").Value = fax
            End If
            If direccion = "" Then
                Rc.Fields.Item("clientes_direccion").Value = "No disponible"
            Else
                Rc.Fields.Item("clientes_direccion").Value = direccion
            End If
            Rc.Fields.Item("usuarios_nick").Value = gVar.tempNickUser
            Rc.Fields.Item("clientes_fecha").Value = System.DateTime.Today
            Rc.Fields.Item("clientes_estado").Value = "A"
            Rc.Update()
            MsgBox("Datos Grabados Exitosamente", MsgBoxStyle.OKOnly, "Sistema Concesionario")
            Rc.Close()
            Db.Close()
        Catch ex As Exception
            MsgBox("Error en Grabado")
        End Try
        
    End Sub

    Public Sub buscaClientesExternos(ByRef criterio As String, ByRef lista As ListView)
        Dim t As New ListViewItem
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        If criterio = "ALL" Then
            Rc.Open("select clientes_codigo, clientes_id, clientes_nombres, clientes_apellidop, clientes_apellidom, usuarios_nick from caClientes where clientes_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Else
            Rc.Open("select clientes_codigo, clientes_id, clientes_nombres, clientes_apellidop, clientes_apellidom, usuarios_nick from caClientes where clientes_estado='A' and clientes_apellidop like '%" & UCase(criterio) & "%'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        End If

        Do While Rc.EOF = False
            t.SubItems.Clear()
            t.Text = Rc.Fields.Item("clientes_codigo").Value
            t.SubItems.Add(Rc.Fields.Item("clientes_id").Value)
            t.SubItems.Add(Trim(Rc.Fields.Item("clientes_apellidop").Value) & " " & Trim(Rc.Fields.Item("clientes_apellidom").Value) & " " & Trim(Rc.Fields.Item("clientes_nombres").Value))
            t.SubItems.Add(Trim(Rc.Fields.Item("usuarios_nick").Value))

            lista.Items.Add(t.Clone)

            Rc.MoveNext()

        Loop
    End Sub

    Public Sub cargaCliente(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caClientes where clientes_estado='A' and clientes_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            gVar.tApellidoP = Rc.Fields.Item("clientes_apellidop").Value
            gVar.tApellidoM = Rc.Fields.Item("clientes_apellidom").Value
            gVar.tNombres = Rc.Fields.Item("clientes_nombres").Value
            gVar.tTipoID = Rc.Fields.Item("clientes_tipoid").Value
            gVar.tID = Rc.Fields.Item("clientes_id").Value
            gVar.tEmail = Rc.Fields.Item("clientes_email").Value
            gVar.tTelefono = Rc.Fields.Item("clientes_telefono").Value
            gVar.tCelular = Rc.Fields.Item("clientes_celular").Value
            gVar.tFax = Rc.Fields.Item("clientes_fax").Value
            gVar.tDireccion = Rc.Fields.Item("clientes_direccion").Value
        End If
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub llenaListaSeguimiento(ByRef codigo As Integer, ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from caseguimiento where seg_estado='A' and clientes_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("seg_codigo").Value
                x = Rc.Fields.Item("seg_fechaConsulta").Value
                t.SubItems.Add(Trim(x.ToShortDateString))
                t.SubItems.Add(Trim(Rc.Fields.Item("seg_observacion").Value))
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If

    End Sub

    Public Sub grabaSeguimiento(ByRef fechaConsulta As Date, ByRef estadoSeg As String, ByRef usuario As String, ByRef observacion As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)

        Rc.Open("select * from caseguimiento", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.AddNew()
        Rc.Fields.Item("clientes_codigo").Value = gVar.codCli
        Rc.Fields.Item("seg_fechaConsulta").Value = fechaConsulta
        Rc.Fields.Item("seg_estadoSeg").Value = estadoSeg
        Rc.Fields.Item("seg_usuario").Value = usuario
        Rc.Fields.Item("seg_observacion").Value = observacion
        Rc.Fields.Item("seg_fecha").Value = System.DateTime.Today
        Rc.Fields.Item("seg_estado").Value = "A"

        Rc.Update()
        Rc.Close()
        Db.Close()

    End Sub

    Public Sub llenaListaAgenda(ByRef lista As ListView, ByRef usuario As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Dim y As Date
        Dim z As String
        y = System.DateTime.Today
        z = y.ToShortDateString
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select caSeguimiento.seg_fechaConsulta, caSeguimiento.seg_estadoSeg, caSeguimiento.seg_usuario, caSeguimiento.seg_observacion, caClientes.clientes_apellidop, caClientes.clientes_apellidom, caClientes.clientes_nombres from caSeguimiento, caClientes where caSeguimiento.seg_estado='A' and caClientes.clientes_estado='A' and caSeguimiento.clientes_codigo = caClientes.clientes_codigo and caseguimiento.seg_usuario='" & usuario & "'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                x = Rc.Fields.Item("seg_fechaConsulta").Value
                If Trim(x.ToShortDateString) = y Then
                    t.SubItems.Clear()
                    t.Text = Trim(x.ToLongDateString)
                    t.SubItems.Add(Trim(Rc.Fields.Item("clientes_apellidop").Value) + " " + Trim(Rc.Fields.Item("clientes_apellidom").Value) + " " + Trim(Rc.Fields.Item("clientes_nombres").Value))
                    t.SubItems.Add(Trim(Rc.Fields.Item("seg_observacion").Value))
                    lista.Items.Add(t.Clone)
                End If
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Function validaUsuario(ByRef usuario As String, ByRef clave As String)
        '1 = Clave aceptada
        '2 = Clave Incorrecta
        '3 = Usuario Incorrecto
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim Db1 As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Dim t As New Integer
        Db1.Open(MainClass.provider_sql)
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from causuarios where usuarios_estado = 'A' and usuarios_nick = '" & usuario & "'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            If Trim(Rc.Fields.Item("usuarios_pass").Value) = clave Then

                t = Rc.Fields.Item("usuariotipo_codigo").Value
                Rc1.Open("select * from causuariostipo where usuariotipo_estado = 'A' and usuariotipo_codigo = " & t & "", Db1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                gVar.utDatos = Rc1.Fields.Item("datos").Value
                gVar.utSeguimiento = Rc1.Fields.Item("seguimiento").Value
                gVar.utCotizaciones = Rc1.Fields.Item("cotizaciones").Value
                gVar.utIngresoCredito = Rc1.Fields.Item("ingresoCredito").Value
                gVar.utClientes = Rc1.Fields.Item("clientes").Value
                gVar.utUsuarios = Rc1.Fields.Item("usuarios").Value
                gVar.utVehiculos = Rc1.Fields.Item("vehiculos").Value
                gVar.utBancos = Rc1.Fields.Item("bancos").Value
                gVar.utParUsuarios = Rc1.Fields.Item("parusuarios").Value
                gVar.utAgenda = Rc1.Fields.Item("agenda").Value
                gVar.superuser = Rc1.Fields.Item("superuser").Value
                Rc1.Close()
                Db1.Close()

                gVar.tempCodUser = Rc.Fields.Item("usuarios_codigo").Value
                gVar.tempNombreUSer = Trim(Rc.Fields.Item("usuarios_apellidop").Value) + " " + Trim(Rc.Fields.Item("usuarios_apellidom").Value) + " " + Trim(Rc.Fields.Item("usuarios_nombres").Value)
                gVar.tempNickUser = Trim(Rc.Fields.Item("usuarios_nick").Value)

                Rc.Close()
                Db.Close()
                Return 1
            Else
                Db1.Close()
                Rc.Close()
                Db.Close()
                Return 2
            End If
        Else
            Db1.Close()
            Rc.Close()
            Db.Close()
            Return 3
        End If
    End Function

    Public Sub cargaPermisos(ByRef codigo As Integer)
        Dim Db1 As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Db1.Open(MainClass.provider_sql)
        Rc1.Open("select * from causuariostipo where usuariotipo_estado = 'A' and usuariotipo_codigo = " & codigo & "", Db1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        gVar.utDatos = Rc1.Fields.Item("datos").Value
        gVar.utSeguimiento = Rc1.Fields.Item("seguimiento").Value
        gVar.utCotizaciones = Rc1.Fields.Item("cotizaciones").Value
        gVar.utIngresoCredito = Rc1.Fields.Item("ingresoCredito").Value
        gVar.utClientes = Rc1.Fields.Item("clientes").Value
        gVar.utUsuarios = Rc1.Fields.Item("usuarios").Value
        gVar.utVehiculos = Rc1.Fields.Item("vehiculos").Value
        gVar.utBancos = Rc1.Fields.Item("bancos").Value
        gVar.utParUsuarios = Rc1.Fields.Item("parusuarios").Value
        gVar.utAgenda = Rc1.Fields.Item("agenda").Value
        gVar.superuser = Rc1.Fields.Item("superuser").Value
        gVar.tuSuperUser = Rc1.Fields.Item("superuser").Value
        Rc1.Close()
        Db1.Close()
    End Sub

    Public Sub cargaListaUsuarios(ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from causuarios where usuarios_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("usuarios_codigo").Value
                t.SubItems.Add(Trim(Rc.Fields.Item("usuarios_nick").Value))
                t.SubItems.Add(Trim(Rc.Fields.Item("usuariotipo_codigo").Value))
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub cargaListaTipos(ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from causuariostipo where usuariotipo_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("usuariotipo_codigo").Value
                t.SubItems.Add(Trim(Rc.Fields.Item("usuariotipo_descripcion").Value))
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub cargaComboModelos(ByRef combo As ComboBox)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from cavehiculos where vehiculos_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            Do While Rc.EOF = False
                combo.Items.Add(Str(Rc.Fields.Item("vehiculos_codigo").Value) + " - " + Trim(Rc.Fields.Item("vehiculos_modelo").Value))
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub cargaComboTipoUsuario(ByRef combo As ComboBox)
        combo.Items.Clear()
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from causuariosTipo where usuarioTipo_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            Do While Rc.EOF = False
                combo.Items.Add(Str(Rc.Fields.Item("usuarioTipo_codigo").Value) + " - " + Trim(Rc.Fields.Item("usuarioTipo_descripcion").Value))
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub cargaComboBancos(ByRef combo As ComboBox)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from cabancos where bancos_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            Do While Rc.EOF = False
                combo.Items.Add(Str(Rc.Fields.Item("bancos_codigo").Value) + " - " + Trim(Rc.Fields.Item("bancos_descripcion").Value))
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub cargaListaCotiza(ByRef codigo As Integer, ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from cacotizacion where cot_estado='A' and clientes_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("cot_codigo").Value
                t.SubItems.Add(Trim(Rc.Fields.Item("cot_institucion").Value))
                t.SubItems.Add(Rc.Fields.Item("cot_precio").Value)
                t.SubItems.Add(Rc.Fields.Item("cot_entrada").Value)
                t.SubItems.Add(Rc.Fields.Item("cot_plazo").Value)
                ''t.SubItems.Add((Rc.Fields.Item("cot_precio").Value - Rc.Fields.Item("cot_entrada").Value) / Rc.Fields.Item("cot_plazo").Value)
                t.SubItems.Add(Str(Rc.Fields.Item("cot_cuota").Value))
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub eliminaCotizacion(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caCotizacion where cot_estado='A' and cot_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.Fields.Item("cot_estado").Value = "E"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub eliminaUsuario(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from causuarios where usuarios_estado='A' and usuarios_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.Fields.Item("usuarios_estado").Value = "E"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub eliminaUsuarioTipo(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim Rc1 As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from causuarios where usuarios_estado='A' and usuarioTipo_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount <= 0 Then
            Rc1.Open("select * from causuariostipo where usuariotipo_estado='A' and usuariotipo_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc1.Fields.Item("usuariotipo_estado").Value = "E"
            Rc1.Update()
            Rc1.Close()
        Else
            MsgBox("Posee Registros Activos de Este Tipo de Usuarios")
        End If
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub cargaDatosCaracteristicasVehiculo(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from cavehiculos where vehiculos_estado='A' and vehiculos_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        gVar.vMarca = Trim(Rc.Fields.Item("vehiculos_marca").Value)
        gVar.vModelo = Trim(Rc.Fields.Item("vehiculos_modelo").Value)
        gVar.vDescripcion = Trim(Rc.Fields.Item("vehiculos_descripcion").Value)
        gVar.vCilindraje = Trim(Rc.Fields.Item("vehiculos_cilindraje").Value)
        gVar.vTransmision = Trim(Rc.Fields.Item("vehiculos_transmision").Value)
        gVar.vSeguridad = Trim(Rc.Fields.Item("vehiculos_seguridad").Value)
        gVar.vPrecio = Trim(Rc.Fields.Item("vehiculos_precio").Value)
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabaCotizacion(ByRef codigoCli As Integer, ByRef codigoVeh As Integer, ByRef modelo As String, ByRef precio As Double, ByRef institucion As String, ByRef entrada As Double, ByRef plazo As Integer, ByRef cuota As Double, ByRef observacion As String, ByRef beneficios As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from cacotizacion ", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.AddNew()
        Rc.Fields.Item("clientes_codigo").Value = codigoCli
        Rc.Fields.Item("vehiculos_codigo").Value = codigoVeh
        Rc.Fields.Item("cot_modelo").Value = Trim(modelo)
        Rc.Fields.Item("cot_precio").Value = precio
        Rc.Fields.Item("cot_institucion").Value = Trim(institucion)
        Rc.Fields.Item("cot_entrada").Value = entrada
        Rc.Fields.Item("cot_plazo").Value = plazo
        Rc.Fields.Item("cot_cuota").Value = cuota
        Rc.Fields.Item("cot_observacion").Value = Trim(observacion)
        Rc.Fields.Item("cot_beneficios").Value = Trim(beneficios)
        Rc.Fields.Item("cot_fecha").Value = System.DateTime.Today
        Rc.Fields.Item("cot_estado").Value = "A"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabausuario(ByRef nick As String, ByRef apellidop As String, ByRef apellidom As String, ByRef nombres As String, ByRef tipo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from causuarios ", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.AddNew()
        Rc.Fields.Item("usuarios_nick").Value = nick
        Rc.Fields.Item("usuarios_pass").Value = "123"
        Rc.Fields.Item("usuarios_apellidop").Value = apellidop
        Rc.Fields.Item("usuarios_apellidom").Value = apellidom
        Rc.Fields.Item("usuarios_nombres").Value = nombres
        Rc.Fields.Item("usuariotipo_codigo").Value = tipo
        Rc.Fields.Item("usuarios_fecha").Value = System.DateTime.Today
        Rc.Fields.Item("usuarios_estado").Value = "A"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grababancos(ByRef codigo As String, ByRef descripcion As String, ByRef entrada As String, ByRef plazo As String, ByRef interes As Double, ByRef ruta As String, ByRef paginas As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        If codigo = "Nuevo" Then
            Rc.Open("select * from cabancos ", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc.AddNew()
            Rc.Fields.Item("bancos_descripcion").Value = Trim(descripcion)
            Rc.Fields.Item("bancos_entradaMinima").Value = entrada
            Rc.Fields.Item("bancos_plazoMaximo").Value = plazo
            Rc.Fields.Item("bancos_interes").Value = interes
            Rc.Fields.Item("bancos_ruta").Value = ruta
            Rc.Fields.Item("bancos_paginas").Value = paginas
            Rc.Fields.Item("bancos_fecha").Value = System.DateTime.Today
            Rc.Fields.Item("bancos_estado").Value = "A"
            Rc.Update()
            MsgBox("Datos Grabado Exitosamente")
            Rc.Close()
            Db.Close()
        Else
            Rc.Open("select * from cabancos where bancos_codigo=" & codigo & " and bancos_estado='A'", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc.Fields.Item("bancos_descripcion").Value = Trim(descripcion)
            Rc.Fields.Item("bancos_entradaMinima").Value = entrada
            Rc.Fields.Item("bancos_plazoMaximo").Value = plazo
            Rc.Fields.Item("bancos_interes").Value = interes
            Rc.Fields.Item("bancos_ruta").Value = ruta
            Rc.Fields.Item("bancos_paginas").Value = paginas
            Rc.Fields.Item("bancos_fecha").Value = System.DateTime.Today
            Rc.Fields.Item("bancos_estado").Value = "A"
            Rc.Update()
            MsgBox("Datos Grabado Exitosamente")
            Rc.Close()
            Db.Close()
        End If


    End Sub

    Public Sub cargaListaBancos(ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from caBancos where bancos_estado='A'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("bancos_codigo").Value
                t.SubItems.Add(Trim(Rc.Fields.Item("bancos_descripcion").Value))
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub cargaBancos(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caBancos where bancos_estado = 'A' and bancos_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            gVar.bCodigo = Rc.Fields.Item("bancos_codigo").Value
            gVar.bDescripcion = Rc.Fields.Item("bancos_descripcion").Value
            gVar.bEntrada = Rc.Fields.Item("bancos_entradaMinima").Value
            gVar.bPlazo = Rc.Fields.Item("bancos_plazoMaximo").Value
            gVar.bInteres = Rc.Fields.Item("bancos_interes").Value
            gVar.bRuta = Rc.Fields.Item("bancos_ruta").Value
            gVar.bPaginas = Rc.Fields.Item("bancos_paginas").Value
        End If
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub cargatipos(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caUsuariosTipo where usuarioTipo_estado = 'A' and usuarioTipo_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            gVar.tuDatos = Rc.Fields.Item("datos").Value
            gVar.tuSeguimiento = Rc.Fields.Item("seguimiento").Value
            gVar.tuCotizaciones = Rc.Fields.Item("cotizaciones").Value
            gVar.tuIngresoCredito = Rc.Fields.Item("ingresocredito").Value
            gVar.tuClientes = Rc.Fields.Item("clientes").Value
            gVar.tuUsuarios = Rc.Fields.Item("usuarios").Value
            gVar.tuVehiculos = Rc.Fields.Item("vehiculos").Value
            gVar.tuBancos = Rc.Fields.Item("bancos").Value
            gVar.tuParUsuarios = Rc.Fields.Item("parusuarios").Value
            gVar.tuAgenda = Rc.Fields.Item("agenda").Value
            gVar.superuser = Rc.Fields.Item("superuser").Value
            gVar.tuSuperUser = Rc.Fields.Item("superuser").Value
        End If
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub cargaLicencia()
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from tecdev ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        gVar.licNumero = Rc.Fields.Item("tecdev_licencia").Value
        gVar.licEmpresa = Rc.Fields.Item("tecdev_empresa").Value
        gVar.licAno = Rc.Fields.Item("tecdev_ano").Value
    End Sub
    Public Sub grabaClave(ByRef codigo As Integer, ByRef clave As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caUsuarios where usuarios_estado='A' and usuarios_codigo=" & codigo & " ", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.Fields.Item("usuarios_pass").Value = clave
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabaTipos(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc1.Open("select * from caUsuariosTipo where usuarioTipo_estado='A' and usuarioTipo_codigo=" & codigo & " ", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc1.Fields.Item("datos").Value = gVar.tuDatos
        Rc1.Fields.Item("seguimiento").Value = gVar.tuSeguimiento
        Rc1.Fields.Item("cotizaciones").Value = gVar.tuCotizaciones
        Rc1.Fields.Item("ingresoCredito").Value = gVar.tuIngresoCredito
        Rc1.Fields.Item("clientes").Value = gVar.tuClientes
        Rc1.Fields.Item("usuarios").Value = gVar.tuUsuarios
        Rc1.Fields.Item("vehiculos").Value = gVar.tuVehiculos
        Rc1.Fields.Item("bancos").Value = gVar.tuBancos
        Rc1.Fields.Item("parusuarios").Value = gVar.tuParUsuarios
        Rc1.Fields.Item("agenda").Value = gVar.tuAgenda
        Rc1.Fields.Item("superuser").Value = gVar.tuSuperUser
        Rc1.Update()
        Rc1.Close()
        Db.Close()
    End Sub

    Public Sub creaTipos(ByRef nombre As String)
        Dim Db As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc1.Open("select * from caUsuariosTipo where usuarioTipo_estado='A'", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc1.AddNew()
        Rc1.Fields.Item("usuarioTipo_descripcion").Value = nombre
        Rc1.Fields.Item("usuarioTipo_estado").Value = "A"
        Rc1.Fields.Item("datos").Value = 0
        Rc1.Fields.Item("seguimiento").Value = 0
        Rc1.Fields.Item("cotizaciones").Value = 0
        Rc1.Fields.Item("ingresoCredito").Value = 0
        Rc1.Fields.Item("clientes").Value = 0
        Rc1.Fields.Item("usuarios").Value = 0
        Rc1.Fields.Item("vehiculos").Value = 0
        Rc1.Fields.Item("bancos").Value = 0
        Rc1.Fields.Item("parusuarios").Value = 0
        Rc1.Fields.Item("agenda").Value = 0
        Rc1.Fields.Item("superuser").Value = 0
        Rc1.Update()
        Rc1.Close()
        Db.Close()
    End Sub

    Public Sub grabaReferencia(ByRef codigo As Integer, ByRef tipo As String, ByRef institucion As String, ByRef cuenta As String, ByRef tiporef As String, ByRef cupo As Double, ByRef nombreCta As String, ByRef direccion As String, ByRef telefono As String, ByRef parent As String)
        Dim Db As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Try
            Rc1.Open("select * from careferencias", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc1.AddNew()
            Rc1.Fields.Item("clientes_codigo").Value = codigo
            Rc1.Fields.Item("ref_tipo").Value = tipo
            Rc1.Fields.Item("ref_institucion").Value = institucion
            Rc1.Fields.Item("ref_cuenta").Value = cuenta
            Rc1.Fields.Item("ref_tiporef").Value = tiporef
            Rc1.Fields.Item("ref_cupo").Value = cupo
            Rc1.Fields.Item("ref_nombrecta").Value = nombreCta
            Rc1.Fields.Item("ref_direccion").Value = direccion
            Rc1.Fields.Item("ref_telefono").Value = telefono
            Rc1.Fields.Item("ref_parent").Value = parent
            Rc1.Fields.Item("ref_fecha").Value = System.DateTime.Today
            Rc1.Fields.Item("ref_estado").Value = "A"
            Rc1.Update()
            MsgBox("Datos Grabados")
            Rc1.Close()
            Db.Close()
        Catch ex As Exception
            MsgBox("Error en Grabacion, Revisar Datos")
        End Try

    End Sub

    Public Sub cargaListaRef(ByRef codigo As Integer, ByRef tipo As String, ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from caReferencias where ref_estado='A' and clientes_codigo=" & codigo & " and ref_tipo='" & Trim(tipo) & "'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            If Trim(tipo) = "Bancaria" Then
                Do While Rc.EOF = False
                    t.SubItems.Clear()
                    t.Text = Rc.Fields.Item("ref_codigo").Value
                    t.SubItems.Add(Trim(Rc.Fields.Item("ref_institucion").Value))
                    t.SubItems.Add(Trim(Rc.Fields.Item("ref_cuenta").Value))
                    t.SubItems.Add(Trim(Rc.Fields.Item("ref_nombreCta").Value))
                    lista.Items.Add(t.Clone)
                    Rc.MoveNext()
                Loop
            End If
            If Trim(tipo) = "Personal" Then
                Do While Rc.EOF = False
                    t.SubItems.Clear()
                    t.Text = Rc.Fields.Item("ref_codigo").Value
                    t.SubItems.Add(Trim(Rc.Fields.Item("ref_nombreCta").Value))
                    t.SubItems.Add(Trim(Rc.Fields.Item("ref_parent").Value))
                    t.SubItems.Add(Trim(Rc.Fields.Item("ref_telefono").Value))
                    lista.Items.Add(t.Clone)
                    Rc.MoveNext()
                Loop
            End If

            Rc.Close()
            Db.Close()
        End If
    End Sub

    Public Sub borraReferencia(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caReferencias where ref_estado='A' and ref_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.Fields.Item("ref_estado").Value = "E"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabaBienes(ByRef codigo As Integer, ByRef tipo As String, ByRef detalle As String, ByRef ubicacion As String, ByRef hipoteca As Double, ByRef avaluo As Double, ByRef comentario As String)
        Dim Db As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Try
            Rc1.Open("select * from cabienes", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc1.AddNew()
            Rc1.Fields.Item("clientes_codigo").Value = codigo
            Rc1.Fields.Item("bienes_tipo").Value = tipo
            Rc1.Fields.Item("bienes_detalle").Value = detalle
            Rc1.Fields.Item("bienes_ubicacion").Value = ubicacion
            Rc1.Fields.Item("bienes_hipoteca").Value = hipoteca
            Rc1.Fields.Item("bienes_avaluo").Value = avaluo
            Rc1.Fields.Item("bienes_comentario").Value = comentario
            Rc1.Fields.Item("bienes_fecha").Value = System.DateTime.Today
            Rc1.Fields.Item("bienes_estado").Value = "A"
            Rc1.Update()
            MsgBox("Datos Grabados")
            Rc1.Close()
            Db.Close()
        Catch ex As Exception
            MsgBox("Error en Grabacion, Revisar Datos")
        End Try

    End Sub

    Public Sub cargaListaBienes(ByRef codigo As Integer, ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from cabienes where bienes_estado='A' and clientes_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("bienes_codigo").Value
                t.SubItems.Add(Trim(Rc.Fields.Item("bienes_tipo").Value))
                t.SubItems.Add(Trim(Rc.Fields.Item("bienes_detalle").Value))
                t.SubItems.Add(Trim(Rc.Fields.Item("bienes_ubicacion").Value))
                t.SubItems.Add(Trim(Rc.Fields.Item("bienes_avaluo").Value))
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
        End If


        Rc.Close()
        Db.Close()

    End Sub

    Public Sub borraBienes(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caBienes where bienes_estado='A' and bienes_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.Fields.Item("bienes_estado").Value = "E"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

    Public Sub grabaIE(ByRef codigo As Integer, ByRef tipo As String, ByRef detalle As String, ByRef valor As Double)
        Dim Db As New ADODB.Connection
        Dim Rc1 As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Try
            Rc1.Open("select * from caingresosegresos", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Rc1.AddNew()
            Rc1.Fields.Item("clientes_codigo").Value = codigo
            Rc1.Fields.Item("ie_registro").Value = tipo
            Rc1.Fields.Item("ie_detalle").Value = detalle
            Rc1.Fields.Item("ie_valor").Value = valor
            Rc1.Fields.Item("ie_fecha").Value = System.DateTime.Today
            Rc1.Fields.Item("ie_estado").Value = "A"
            Rc1.Update()
            MsgBox("Datos Grabados")
            Rc1.Close()
            Db.Close()
        Catch ex As Exception
            MsgBox("Error en Grabacion, Revisar Datos")
        End Try
    End Sub

    Public Sub cargaListaIE(ByRef codigo As Integer, ByRef lista As ListView)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim t As New ListViewItem
        Dim x As Date
        Db.Open(MainClass.provider_sql)
        lista.Items.Clear()
        Rc.Open("select * from caingresosegresos where ie_estado='A' and clientes_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            t.SubItems.Clear()
            Do While Rc.EOF = False
                t.SubItems.Clear()
                t.Text = Rc.Fields.Item("ie_codigo").Value
                t.SubItems.Add(Trim(Rc.Fields.Item("ie_detalle").Value))
                If Trim(Rc.Fields.Item("ie_registro").Value) = "Ingreso" Then
                    t.SubItems.Add(Trim(Rc.Fields.Item("ie_valor").Value))
                    t.SubItems.Add("0.00")
                Else
                    t.SubItems.Add("0.00")
                    t.SubItems.Add(Trim(Rc.Fields.Item("ie_valor").Value))
                End If
                lista.Items.Add(t.Clone)
                Rc.MoveNext()
            Loop
        End If
        Rc.Close()
        Db.Close()

    End Sub

    Public Sub borraIE(ByRef codigo As Integer)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Rc.Open("select * from caingresosegresos where ie_estado='A' and ie_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.Fields.Item("ie_estado").Value = "E"
        Rc.Update()
        Rc.Close()
        Db.Close()
    End Sub

End Class
