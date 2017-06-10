Public Class frmCredito
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents apeM As System.Windows.Forms.TextBox
    Friend WithEvents apeP As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents tipoID As System.Windows.Forms.ComboBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents nombrePropietario As System.Windows.Forms.TextBox
    Friend WithEvents prentArrendador As System.Windows.Forms.TextBox
    Friend WithEvents telArrendador As System.Windows.Forms.TextBox
    Friend WithEvents nomArrendador As System.Windows.Forms.TextBox
    Friend WithEvents Alquiler As System.Windows.Forms.TextBox
    Friend WithEvents montoMensual As System.Windows.Forms.TextBox
    Friend WithEvents hipoteca As System.Windows.Forms.TextBox
    Friend WithEvents vivienda As System.Windows.Forms.ComboBox
    Friend WithEvents ciudad As System.Windows.Forms.TextBox
    Friend WithEvents tipoIDExt As System.Windows.Forms.ComboBox
    Friend WithEvents tResidencia As System.Windows.Forms.TextBox
    Friend WithEvents nacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents profesion As System.Windows.Forms.TextBox
    Friend WithEvents fecnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents edad As System.Windows.Forms.TextBox
    Friend WithEvents sexo As System.Windows.Forms.ComboBox
    Friend WithEvents cTipoIDext As System.Windows.Forms.ComboBox
    Friend WithEvents cTResidencia As System.Windows.Forms.TextBox
    Friend WithEvents cNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents cProfesion As System.Windows.Forms.TextBox
    Friend WithEvents cFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cEdad As System.Windows.Forms.TextBox
    Friend WithEvents cID As System.Windows.Forms.TextBox
    Friend WithEvents cSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cTipoID As System.Windows.Forms.ComboBox
    Friend WithEvents cApeM As System.Windows.Forms.TextBox
    Friend WithEvents cApeP As System.Windows.Forms.TextBox
    Friend WithEvents cNombres As System.Windows.Forms.TextBox
    Friend WithEvents sActividad As System.Windows.Forms.TextBox
    Friend WithEvents sCiudad As System.Windows.Forms.TextBox
    Friend WithEvents sDireccion As System.Windows.Forms.TextBox
    Friend WithEvents sAntiguedadAnterior As System.Windows.Forms.TextBox
    Friend WithEvents sTipoOcupacion As System.Windows.Forms.ComboBox
    Friend WithEvents sRUC As System.Windows.Forms.TextBox
    Friend WithEvents sCargoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents sTelefonoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents sVentas As System.Windows.Forms.TextBox
    Friend WithEvents sOcupacionAnterior As System.Windows.Forms.TextBox
    Friend WithEvents sCargo As System.Windows.Forms.TextBox
    Friend WithEvents sNroEmpleados As System.Windows.Forms.TextBox
    Friend WithEvents sAntiguedad As System.Windows.Forms.TextBox
    Friend WithEvents sEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents sTelefono As System.Windows.Forms.TextBox
    Friend WithEvents ceActividad As System.Windows.Forms.TextBox
    Friend WithEvents ceCiudad As System.Windows.Forms.TextBox
    Friend WithEvents ceDireccion As System.Windows.Forms.TextBox
    Friend WithEvents ceAntiguedadAnterior As System.Windows.Forms.TextBox
    Friend WithEvents ceOcupacion As System.Windows.Forms.ComboBox
    Friend WithEvents ceRUC As System.Windows.Forms.TextBox
    Friend WithEvents ceCargoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents ceTelefonoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents ceVentasAnuales As System.Windows.Forms.TextBox
    Friend WithEvents ceEmpresaAnterior As System.Windows.Forms.TextBox
    Friend WithEvents ceCargo As System.Windows.Forms.TextBox
    Friend WithEvents ceNroEmpleados As System.Windows.Forms.TextBox
    Friend WithEvents ceAntiguedad As System.Windows.Forms.TextBox
    Friend WithEvents ceEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents ceTelefono As System.Windows.Forms.TextBox
    Friend WithEvents crePlazo As System.Windows.Forms.TextBox
    Friend WithEvents creInicial As System.Windows.Forms.TextBox
    Friend WithEvents creValor As System.Windows.Forms.TextBox
    Friend WithEvents CreModelo As System.Windows.Forms.ComboBox
    Friend WithEvents creMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ctaNombre As System.Windows.Forms.TextBox
    Friend WithEvents tipoRef As System.Windows.Forms.ComboBox
    Friend WithEvents institucion As System.Windows.Forms.ComboBox
    Friend WithEvents cuenta As System.Windows.Forms.TextBox
    Friend WithEvents cupo As System.Windows.Forms.TextBox
    Friend WithEvents parentRef As System.Windows.Forms.TextBox
    Friend WithEvents DireccionRef As System.Windows.Forms.TextBox
    Friend WithEvents nombreRef As System.Windows.Forms.TextBox
    Friend WithEvents telefonoRef As System.Windows.Forms.TextBox
    Friend WithEvents bcomentario As System.Windows.Forms.TextBox
    Friend WithEvents bavaluo As System.Windows.Forms.TextBox
    Friend WithEvents bhipoteca As System.Windows.Forms.TextBox
    Friend WithEvents btipo As System.Windows.Forms.ComboBox
    Friend WithEvents bubicacion As System.Windows.Forms.TextBox
    Friend WithEvents bdetalle As System.Windows.Forms.TextBox
    Friend WithEvents ieRegistro As System.Windows.Forms.ComboBox
    Friend WithEvents ieValor As System.Windows.Forms.TextBox
    Friend WithEvents ieDetalle As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.nombrePropietario = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.prentArrendador = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.telArrendador = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.nomArrendador = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Alquiler = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.montoMensual = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.hipoteca = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.vivienda = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.telefono = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.ciudad = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tipoIDExt = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tResidencia = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.nacionalidad = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.profesion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.fecnac = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.edad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.sexo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tipoID = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.apeM = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.apeP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cTipoIDext = New System.Windows.Forms.ComboBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.cTResidencia = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.cNacionalidad = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.cProfesion = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.cFecNac = New System.Windows.Forms.DateTimePicker
        Me.Label39 = New System.Windows.Forms.Label
        Me.cEdad = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.cID = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.cSexo = New System.Windows.Forms.ComboBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.cTipoID = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.cApeM = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.cApeP = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.cNombres = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.sActividad = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.sCiudad = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.sDireccion = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.sAntiguedadAnterior = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.sTipoOcupacion = New System.Windows.Forms.ComboBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.sRUC = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.sCargoAnterior = New System.Windows.Forms.TextBox
        Me.sTelefonoAnterior = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.sVentas = New System.Windows.Forms.TextBox
        Me.sOcupacionAnterior = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.sCargo = New System.Windows.Forms.TextBox
        Me.sNroEmpleados = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.sAntiguedad = New System.Windows.Forms.TextBox
        Me.sEmpresa = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.sTelefono = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.ceActividad = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.ceCiudad = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.ceDireccion = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.ceAntiguedadAnterior = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.ceOcupacion = New System.Windows.Forms.ComboBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.ceRUC = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.ceCargoAnterior = New System.Windows.Forms.TextBox
        Me.ceTelefonoAnterior = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.ceVentasAnuales = New System.Windows.Forms.TextBox
        Me.ceEmpresaAnterior = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.ceCargo = New System.Windows.Forms.TextBox
        Me.ceNroEmpleados = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.ceAntiguedad = New System.Windows.Forms.TextBox
        Me.ceEmpresa = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.ceTelefono = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label70 = New System.Windows.Forms.Label
        Me.ctaNombre = New System.Windows.Forms.TextBox
        Me.tipoRef = New System.Windows.Forms.ComboBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.institucion = New System.Windows.Forms.ComboBox
        Me.cuenta = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.cupo = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.parentRef = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.DireccionRef = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.nombreRef = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.telefonoRef = New System.Windows.Forms.TextBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Label82 = New System.Windows.Forms.Label
        Me.bcomentario = New System.Windows.Forms.TextBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.bavaluo = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.bhipoteca = New System.Windows.Forms.TextBox
        Me.Label79 = New System.Windows.Forms.Label
        Me.btipo = New System.Windows.Forms.ComboBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.bubicacion = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.bdetalle = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.ieDetalle = New System.Windows.Forms.ComboBox
        Me.Label84 = New System.Windows.Forms.Label
        Me.ieRegistro = New System.Windows.Forms.ComboBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.ieValor = New System.Windows.Forms.TextBox
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label88 = New System.Windows.Forms.Label
        Me.crePlazo = New System.Windows.Forms.TextBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.creInicial = New System.Windows.Forms.TextBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.creValor = New System.Windows.Forms.TextBox
        Me.CreModelo = New System.Windows.Forms.ComboBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.creMarca = New System.Windows.Forms.ComboBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 72)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 480)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.nombrePropietario)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.prentArrendador)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.telArrendador)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.nomArrendador)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Alquiler)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.montoMensual)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.hipoteca)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.vivienda)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.telefono)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.ciudad)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Direccion)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.tipoIDExt)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.tResidencia)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.nacionalidad)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.profesion)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.fecnac)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.edad)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ID)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.sexo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.tipoID)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.apeM)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.apeP)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.nombre)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(656, 454)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        '
        'nombrePropietario
        '
        Me.nombrePropietario.Location = New System.Drawing.Point(176, 320)
        Me.nombrePropietario.Name = "nombrePropietario"
        Me.nombrePropietario.Size = New System.Drawing.Size(472, 20)
        Me.nombrePropietario.TabIndex = 115
        Me.nombrePropietario.Text = ""
        '
        'Label23
        '
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(176, 304)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(208, 16)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Nombre de Familiar Propietario (Si aplica):"
        '
        'prentArrendador
        '
        Me.prentArrendador.Location = New System.Drawing.Point(8, 320)
        Me.prentArrendador.Name = "prentArrendador"
        Me.prentArrendador.Size = New System.Drawing.Size(160, 20)
        Me.prentArrendador.TabIndex = 110
        Me.prentArrendador.Text = ""
        '
        'Label22
        '
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(8, 304)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 16)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Parentezco Propietario (Si aplica):"
        '
        'telArrendador
        '
        Me.telArrendador.Location = New System.Drawing.Point(488, 272)
        Me.telArrendador.Name = "telArrendador"
        Me.telArrendador.Size = New System.Drawing.Size(160, 20)
        Me.telArrendador.TabIndex = 105
        Me.telArrendador.Text = ""
        '
        'Label21
        '
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(488, 256)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 16)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Telf. Arrendador (Si Aaplica):"
        '
        'nomArrendador
        '
        Me.nomArrendador.Location = New System.Drawing.Point(176, 272)
        Me.nomArrendador.Name = "nomArrendador"
        Me.nomArrendador.Size = New System.Drawing.Size(304, 20)
        Me.nomArrendador.TabIndex = 100
        Me.nomArrendador.Text = ""
        '
        'Label20
        '
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(176, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 16)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Arrendador (Si aplica):"
        '
        'Alquiler
        '
        Me.Alquiler.Location = New System.Drawing.Point(8, 272)
        Me.Alquiler.Name = "Alquiler"
        Me.Alquiler.Size = New System.Drawing.Size(160, 20)
        Me.Alquiler.TabIndex = 95
        Me.Alquiler.Text = ""
        '
        'Label19
        '
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(8, 256)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 16)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Valor Alquiler (Si aplica):"
        '
        'montoMensual
        '
        Me.montoMensual.Location = New System.Drawing.Point(488, 224)
        Me.montoMensual.Name = "montoMensual"
        Me.montoMensual.Size = New System.Drawing.Size(160, 20)
        Me.montoMensual.TabIndex = 90
        Me.montoMensual.Text = ""
        '
        'Label18
        '
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(488, 208)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Monto Mensual (Si Aaplica):"
        '
        'hipoteca
        '
        Me.hipoteca.Location = New System.Drawing.Point(320, 224)
        Me.hipoteca.Name = "hipoteca"
        Me.hipoteca.Size = New System.Drawing.Size(160, 20)
        Me.hipoteca.TabIndex = 85
        Me.hipoteca.Text = ""
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(320, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 16)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Valor Hipoteca (Si aplica):"
        '
        'vivienda
        '
        Me.vivienda.Items.AddRange(New Object() {"Propia", "Alquilada", "Familiares"})
        Me.vivienda.Location = New System.Drawing.Point(176, 224)
        Me.vivienda.Name = "vivienda"
        Me.vivienda.Size = New System.Drawing.Size(136, 21)
        Me.vivienda.TabIndex = 80
        '
        'Label16
        '
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(176, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Tipo de Vivienda:"
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(8, 224)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(160, 20)
        Me.telefono.TabIndex = 75
        Me.telefono.Text = ""
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(8, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Telefono(s):"
        '
        'ciudad
        '
        Me.ciudad.Location = New System.Drawing.Point(488, 176)
        Me.ciudad.Name = "ciudad"
        Me.ciudad.Size = New System.Drawing.Size(160, 20)
        Me.ciudad.TabIndex = 70
        Me.ciudad.Text = ""
        '
        'Label14
        '
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(488, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Ciudad:"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(8, 176)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(472, 20)
        Me.Direccion.TabIndex = 65
        Me.Direccion.Text = ""
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(8, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Direccion:"
        '
        'tipoIDExt
        '
        Me.tipoIDExt.Items.AddRange(New Object() {"Cedula", "Pasaporte", "R.U.C."})
        Me.tipoIDExt.Location = New System.Drawing.Point(512, 128)
        Me.tipoIDExt.Name = "tipoIDExt"
        Me.tipoIDExt.Size = New System.Drawing.Size(136, 21)
        Me.tipoIDExt.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(512, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Tipo ID:"
        '
        'tResidencia
        '
        Me.tResidencia.Location = New System.Drawing.Point(320, 128)
        Me.tResidencia.Name = "tResidencia"
        Me.tResidencia.Size = New System.Drawing.Size(184, 20)
        Me.tResidencia.TabIndex = 55
        Me.tResidencia.Text = ""
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(320, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Tiempo de Residencia (Extranjeros):"
        '
        'nacionalidad
        '
        Me.nacionalidad.Location = New System.Drawing.Point(152, 128)
        Me.nacionalidad.Name = "nacionalidad"
        Me.nacionalidad.Size = New System.Drawing.Size(160, 20)
        Me.nacionalidad.TabIndex = 50
        Me.nacionalidad.Text = ""
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(152, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nacionalidad:"
        '
        'profesion
        '
        Me.profesion.Location = New System.Drawing.Point(8, 128)
        Me.profesion.Name = "profesion"
        Me.profesion.Size = New System.Drawing.Size(136, 20)
        Me.profesion.TabIndex = 45
        Me.profesion.Text = ""
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Profesion:"
        '
        'fecnac
        '
        Me.fecnac.Location = New System.Drawing.Point(448, 80)
        Me.fecnac.Name = "fecnac"
        Me.fecnac.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(168, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "?"
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(448, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha de Naciemiento:"
        '
        'edad
        '
        Me.edad.Location = New System.Drawing.Point(384, 80)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(56, 20)
        Me.edad.TabIndex = 35
        Me.edad.Text = ""
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(384, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Edad:"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(120, 80)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(144, 20)
        Me.ID.TabIndex = 25
        Me.ID.Text = ""
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(120, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nro. Identificacion:"
        '
        'sexo
        '
        Me.sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.sexo.Location = New System.Drawing.Point(272, 80)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(104, 21)
        Me.sexo.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(272, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sexo:"
        '
        'tipoID
        '
        Me.tipoID.Items.AddRange(New Object() {"Cedula", "Pasaporte", "R.U.C."})
        Me.tipoID.Location = New System.Drawing.Point(8, 80)
        Me.tipoID.Name = "tipoID"
        Me.tipoID.Size = New System.Drawing.Size(104, 21)
        Me.tipoID.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo ID:"
        '
        'apeM
        '
        Me.apeM.Location = New System.Drawing.Point(192, 32)
        Me.apeM.Name = "apeM"
        Me.apeM.Size = New System.Drawing.Size(160, 20)
        Me.apeM.TabIndex = 10
        Me.apeM.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(192, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido Materno:"
        '
        'apeP
        '
        Me.apeP.Location = New System.Drawing.Point(8, 32)
        Me.apeP.Name = "apeP"
        Me.apeP.Size = New System.Drawing.Size(160, 20)
        Me.apeP.TabIndex = 1
        Me.apeP.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido Paterno:"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(360, 32)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(288, 20)
        Me.nombre.TabIndex = 15
        Me.nombre.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(360, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cTipoIDext)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.cTResidencia)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.cNacionalidad)
        Me.TabPage3.Controls.Add(Me.Label37)
        Me.TabPage3.Controls.Add(Me.cProfesion)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.cFecNac)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.cEdad)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.cID)
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Controls.Add(Me.cSexo)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Controls.Add(Me.cTipoID)
        Me.TabPage3.Controls.Add(Me.Label43)
        Me.TabPage3.Controls.Add(Me.cApeM)
        Me.TabPage3.Controls.Add(Me.Label44)
        Me.TabPage3.Controls.Add(Me.cApeP)
        Me.TabPage3.Controls.Add(Me.Label45)
        Me.TabPage3.Controls.Add(Me.cNombres)
        Me.TabPage3.Controls.Add(Me.Label46)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(656, 454)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Datos Conyugue"
        '
        'cTipoIDext
        '
        Me.cTipoIDext.Items.AddRange(New Object() {"Cedula", "Pasaporte", "R.U.C."})
        Me.cTipoIDext.Location = New System.Drawing.Point(512, 128)
        Me.cTipoIDext.Name = "cTipoIDext"
        Me.cTipoIDext.Size = New System.Drawing.Size(136, 21)
        Me.cTipoIDext.TabIndex = 55
        '
        'Label35
        '
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label35.Location = New System.Drawing.Point(512, 112)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(100, 16)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "Tipo ID:"
        '
        'cTResidencia
        '
        Me.cTResidencia.Location = New System.Drawing.Point(320, 128)
        Me.cTResidencia.Name = "cTResidencia"
        Me.cTResidencia.Size = New System.Drawing.Size(184, 20)
        Me.cTResidencia.TabIndex = 50
        Me.cTResidencia.Text = ""
        '
        'Label36
        '
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label36.Location = New System.Drawing.Point(320, 112)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(176, 16)
        Me.Label36.TabIndex = 69
        Me.Label36.Text = "Tiempo de Residencia (Extranjeros):"
        '
        'cNacionalidad
        '
        Me.cNacionalidad.Location = New System.Drawing.Point(152, 128)
        Me.cNacionalidad.Name = "cNacionalidad"
        Me.cNacionalidad.Size = New System.Drawing.Size(160, 20)
        Me.cNacionalidad.TabIndex = 45
        Me.cNacionalidad.Text = ""
        '
        'Label37
        '
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label37.Location = New System.Drawing.Point(152, 112)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(100, 16)
        Me.Label37.TabIndex = 67
        Me.Label37.Text = "Nacionalidad:"
        '
        'cProfesion
        '
        Me.cProfesion.Location = New System.Drawing.Point(8, 128)
        Me.cProfesion.Name = "cProfesion"
        Me.cProfesion.Size = New System.Drawing.Size(136, 20)
        Me.cProfesion.TabIndex = 40
        Me.cProfesion.Text = ""
        '
        'Label38
        '
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label38.Location = New System.Drawing.Point(8, 112)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(100, 16)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Profesion:"
        '
        'cFecNac
        '
        Me.cFecNac.Location = New System.Drawing.Point(448, 80)
        Me.cFecNac.Name = "cFecNac"
        Me.cFecNac.TabIndex = 35
        '
        'Label39
        '
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label39.Location = New System.Drawing.Point(448, 64)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(120, 16)
        Me.Label39.TabIndex = 62
        Me.Label39.Text = "Fecha de Naciemiento:"
        '
        'cEdad
        '
        Me.cEdad.Location = New System.Drawing.Point(384, 80)
        Me.cEdad.Name = "cEdad"
        Me.cEdad.Size = New System.Drawing.Size(56, 20)
        Me.cEdad.TabIndex = 30
        Me.cEdad.Text = ""
        '
        'Label40
        '
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label40.Location = New System.Drawing.Point(384, 64)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(40, 16)
        Me.Label40.TabIndex = 60
        Me.Label40.Text = "Edad:"
        '
        'cID
        '
        Me.cID.Location = New System.Drawing.Point(120, 80)
        Me.cID.Name = "cID"
        Me.cID.Size = New System.Drawing.Size(144, 20)
        Me.cID.TabIndex = 20
        Me.cID.Text = ""
        '
        'Label41
        '
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label41.Location = New System.Drawing.Point(120, 64)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 16)
        Me.Label41.TabIndex = 58
        Me.Label41.Text = "Nro. Identificacion:"
        '
        'cSexo
        '
        Me.cSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cSexo.Location = New System.Drawing.Point(272, 80)
        Me.cSexo.Name = "cSexo"
        Me.cSexo.Size = New System.Drawing.Size(104, 21)
        Me.cSexo.TabIndex = 25
        '
        'Label42
        '
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label42.Location = New System.Drawing.Point(272, 64)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 16)
        Me.Label42.TabIndex = 56
        Me.Label42.Text = "Sexo:"
        '
        'cTipoID
        '
        Me.cTipoID.Items.AddRange(New Object() {"Cedula", "Pasaporte", "R.U.C."})
        Me.cTipoID.Location = New System.Drawing.Point(8, 80)
        Me.cTipoID.Name = "cTipoID"
        Me.cTipoID.Size = New System.Drawing.Size(104, 21)
        Me.cTipoID.TabIndex = 15
        '
        'Label43
        '
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label43.Location = New System.Drawing.Point(8, 64)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 16)
        Me.Label43.TabIndex = 54
        Me.Label43.Text = "Tipo ID:"
        '
        'cApeM
        '
        Me.cApeM.Location = New System.Drawing.Point(192, 32)
        Me.cApeM.Name = "cApeM"
        Me.cApeM.Size = New System.Drawing.Size(160, 20)
        Me.cApeM.TabIndex = 5
        Me.cApeM.Text = ""
        '
        'Label44
        '
        Me.Label44.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label44.Location = New System.Drawing.Point(192, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(100, 16)
        Me.Label44.TabIndex = 52
        Me.Label44.Text = "Apellido Materno:"
        '
        'cApeP
        '
        Me.cApeP.Location = New System.Drawing.Point(8, 32)
        Me.cApeP.Name = "cApeP"
        Me.cApeP.Size = New System.Drawing.Size(176, 20)
        Me.cApeP.TabIndex = 1
        Me.cApeP.Text = ""
        '
        'Label45
        '
        Me.Label45.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label45.Location = New System.Drawing.Point(8, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(100, 16)
        Me.Label45.TabIndex = 50
        Me.Label45.Text = "Apellido Paterno:"
        '
        'cNombres
        '
        Me.cNombres.Location = New System.Drawing.Point(360, 32)
        Me.cNombres.Name = "cNombres"
        Me.cNombres.Size = New System.Drawing.Size(288, 20)
        Me.cNombres.TabIndex = 10
        Me.cNombres.Text = ""
        '
        'Label46
        '
        Me.Label46.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label46.Location = New System.Drawing.Point(360, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(100, 16)
        Me.Label46.TabIndex = 48
        Me.Label46.Text = "Nombres:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(656, 454)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Datos Laborales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.sActividad)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.sCiudad)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.sDireccion)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.sAntiguedadAnterior)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.sTipoOcupacion)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.sRUC)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.sCargoAnterior)
        Me.GroupBox2.Controls.Add(Me.sTelefonoAnterior)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.sVentas)
        Me.GroupBox2.Controls.Add(Me.sOcupacionAnterior)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.sCargo)
        Me.GroupBox2.Controls.Add(Me.sNroEmpleados)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.sAntiguedad)
        Me.GroupBox2.Controls.Add(Me.sEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.sTelefono)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 216)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Solicitante"
        '
        'Label47
        '
        Me.Label47.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label47.Location = New System.Drawing.Point(488, 168)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(100, 16)
        Me.Label47.TabIndex = 74
        Me.Label47.Text = "Telefono(s):"
        '
        'Label26
        '
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(408, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(152, 16)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Actividad de la Empresa:"
        '
        'sActividad
        '
        Me.sActividad.Location = New System.Drawing.Point(408, 40)
        Me.sActividad.Name = "sActividad"
        Me.sActividad.Size = New System.Drawing.Size(224, 20)
        Me.sActividad.TabIndex = 10
        Me.sActividad.Text = ""
        '
        'Label29
        '
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label29.Location = New System.Drawing.Point(248, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 16)
        Me.Label29.TabIndex = 63
        Me.Label29.Text = "Nro. de Empleados:"
        '
        'sCiudad
        '
        Me.sCiudad.Location = New System.Drawing.Point(8, 136)
        Me.sCiudad.Name = "sCiudad"
        Me.sCiudad.Size = New System.Drawing.Size(160, 20)
        Me.sCiudad.TabIndex = 40
        Me.sCiudad.Text = ""
        '
        'Label32
        '
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Location = New System.Drawing.Point(8, 120)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(100, 16)
        Me.Label32.TabIndex = 70
        Me.Label32.Text = "Ciudad:"
        '
        'sDireccion
        '
        Me.sDireccion.Location = New System.Drawing.Point(176, 136)
        Me.sDireccion.Name = "sDireccion"
        Me.sDireccion.Size = New System.Drawing.Size(304, 20)
        Me.sDireccion.TabIndex = 45
        Me.sDireccion.Text = ""
        '
        'Label33
        '
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Location = New System.Drawing.Point(176, 120)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(100, 16)
        Me.Label33.TabIndex = 68
        Me.Label33.Text = "Direccion:"
        '
        'sAntiguedadAnterior
        '
        Me.sAntiguedadAnterior.Location = New System.Drawing.Point(400, 184)
        Me.sAntiguedadAnterior.Name = "sAntiguedadAnterior"
        Me.sAntiguedadAnterior.Size = New System.Drawing.Size(80, 20)
        Me.sAntiguedadAnterior.TabIndex = 65
        Me.sAntiguedadAnterior.Text = ""
        '
        'Label50
        '
        Me.Label50.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label50.Location = New System.Drawing.Point(400, 168)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(100, 16)
        Me.Label50.TabIndex = 81
        Me.Label50.Text = "Antiguedad:"
        '
        'sTipoOcupacion
        '
        Me.sTipoOcupacion.Items.AddRange(New Object() {"Empleado", "Independiente", "Jubilado"})
        Me.sTipoOcupacion.Location = New System.Drawing.Point(8, 40)
        Me.sTipoOcupacion.Name = "sTipoOcupacion"
        Me.sTipoOcupacion.Size = New System.Drawing.Size(120, 21)
        Me.sTipoOcupacion.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label31.Location = New System.Drawing.Point(448, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(100, 16)
        Me.Label31.TabIndex = 67
        Me.Label31.Text = "R.U.C."
        '
        'sRUC
        '
        Me.sRUC.Location = New System.Drawing.Point(448, 88)
        Me.sRUC.Name = "sRUC"
        Me.sRUC.Size = New System.Drawing.Size(184, 20)
        Me.sRUC.TabIndex = 35
        Me.sRUC.Text = ""
        '
        'Label49
        '
        Me.Label49.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label49.Location = New System.Drawing.Point(248, 168)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(100, 16)
        Me.Label49.TabIndex = 79
        Me.Label49.Text = "Cargo:"
        '
        'sCargoAnterior
        '
        Me.sCargoAnterior.Location = New System.Drawing.Point(248, 184)
        Me.sCargoAnterior.Name = "sCargoAnterior"
        Me.sCargoAnterior.Size = New System.Drawing.Size(144, 20)
        Me.sCargoAnterior.TabIndex = 60
        Me.sCargoAnterior.Text = ""
        '
        'sTelefonoAnterior
        '
        Me.sTelefonoAnterior.Location = New System.Drawing.Point(488, 184)
        Me.sTelefonoAnterior.Name = "sTelefonoAnterior"
        Me.sTelefonoAnterior.Size = New System.Drawing.Size(144, 20)
        Me.sTelefonoAnterior.TabIndex = 70
        Me.sTelefonoAnterior.Text = ""
        '
        'Label30
        '
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label30.Location = New System.Drawing.Point(352, 72)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 16)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "Ventas Anuales:"
        '
        'sVentas
        '
        Me.sVentas.Location = New System.Drawing.Point(352, 88)
        Me.sVentas.Name = "sVentas"
        Me.sVentas.Size = New System.Drawing.Size(88, 20)
        Me.sVentas.TabIndex = 30
        Me.sVentas.Text = ""
        '
        'sOcupacionAnterior
        '
        Me.sOcupacionAnterior.Location = New System.Drawing.Point(8, 184)
        Me.sOcupacionAnterior.Name = "sOcupacionAnterior"
        Me.sOcupacionAnterior.Size = New System.Drawing.Size(232, 20)
        Me.sOcupacionAnterior.TabIndex = 55
        Me.sOcupacionAnterior.Text = ""
        '
        'Label48
        '
        Me.Label48.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label48.Location = New System.Drawing.Point(8, 168)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(152, 16)
        Me.Label48.TabIndex = 76
        Me.Label48.Text = "Ocupacion Anterior (Empresa):"
        '
        'Label24
        '
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(8, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 16)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Tipo Ocupacion:"
        '
        'sCargo
        '
        Me.sCargo.Location = New System.Drawing.Point(8, 88)
        Me.sCargo.Name = "sCargo"
        Me.sCargo.Size = New System.Drawing.Size(144, 20)
        Me.sCargo.TabIndex = 15
        Me.sCargo.Text = ""
        '
        'sNroEmpleados
        '
        Me.sNroEmpleados.Location = New System.Drawing.Point(248, 88)
        Me.sNroEmpleados.Name = "sNroEmpleados"
        Me.sNroEmpleados.Size = New System.Drawing.Size(96, 20)
        Me.sNroEmpleados.TabIndex = 25
        Me.sNroEmpleados.Text = ""
        '
        'Label28
        '
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Location = New System.Drawing.Point(160, 72)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 61
        Me.Label28.Text = "Antiguedad:"
        '
        'sAntiguedad
        '
        Me.sAntiguedad.Location = New System.Drawing.Point(160, 88)
        Me.sAntiguedad.Name = "sAntiguedad"
        Me.sAntiguedad.Size = New System.Drawing.Size(80, 20)
        Me.sAntiguedad.TabIndex = 20
        Me.sAntiguedad.Text = ""
        '
        'sEmpresa
        '
        Me.sEmpresa.Location = New System.Drawing.Point(136, 40)
        Me.sEmpresa.Name = "sEmpresa"
        Me.sEmpresa.Size = New System.Drawing.Size(264, 20)
        Me.sEmpresa.TabIndex = 5
        Me.sEmpresa.Text = ""
        '
        'Label34
        '
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label34.Location = New System.Drawing.Point(488, 120)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 16)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "Telefono(s):"
        '
        'Label27
        '
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(8, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 16)
        Me.Label27.TabIndex = 59
        Me.Label27.Text = "Cargo:"
        '
        'sTelefono
        '
        Me.sTelefono.Location = New System.Drawing.Point(488, 136)
        Me.sTelefono.Name = "sTelefono"
        Me.sTelefono.Size = New System.Drawing.Size(144, 20)
        Me.sTelefono.TabIndex = 50
        Me.sTelefono.Text = ""
        '
        'Label25
        '
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(136, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Empresa:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label51)
        Me.GroupBox3.Controls.Add(Me.Label52)
        Me.GroupBox3.Controls.Add(Me.ceActividad)
        Me.GroupBox3.Controls.Add(Me.Label53)
        Me.GroupBox3.Controls.Add(Me.ceCiudad)
        Me.GroupBox3.Controls.Add(Me.Label54)
        Me.GroupBox3.Controls.Add(Me.ceDireccion)
        Me.GroupBox3.Controls.Add(Me.Label55)
        Me.GroupBox3.Controls.Add(Me.ceAntiguedadAnterior)
        Me.GroupBox3.Controls.Add(Me.Label56)
        Me.GroupBox3.Controls.Add(Me.ceOcupacion)
        Me.GroupBox3.Controls.Add(Me.Label57)
        Me.GroupBox3.Controls.Add(Me.ceRUC)
        Me.GroupBox3.Controls.Add(Me.Label58)
        Me.GroupBox3.Controls.Add(Me.ceCargoAnterior)
        Me.GroupBox3.Controls.Add(Me.ceTelefonoAnterior)
        Me.GroupBox3.Controls.Add(Me.Label59)
        Me.GroupBox3.Controls.Add(Me.ceVentasAnuales)
        Me.GroupBox3.Controls.Add(Me.ceEmpresaAnterior)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.Label61)
        Me.GroupBox3.Controls.Add(Me.ceCargo)
        Me.GroupBox3.Controls.Add(Me.ceNroEmpleados)
        Me.GroupBox3.Controls.Add(Me.Label62)
        Me.GroupBox3.Controls.Add(Me.ceAntiguedad)
        Me.GroupBox3.Controls.Add(Me.ceEmpresa)
        Me.GroupBox3.Controls.Add(Me.Label63)
        Me.GroupBox3.Controls.Add(Me.Label64)
        Me.GroupBox3.Controls.Add(Me.ceTelefono)
        Me.GroupBox3.Controls.Add(Me.Label65)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 216)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conyugue (Si Aplica)"
        '
        'Label51
        '
        Me.Label51.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label51.Location = New System.Drawing.Point(488, 168)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(100, 16)
        Me.Label51.TabIndex = 74
        Me.Label51.Text = "Telefono(s):"
        '
        'Label52
        '
        Me.Label52.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label52.Location = New System.Drawing.Point(408, 24)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(152, 16)
        Me.Label52.TabIndex = 57
        Me.Label52.Text = "Actividad de la Empresa:"
        '
        'ceActividad
        '
        Me.ceActividad.Location = New System.Drawing.Point(408, 40)
        Me.ceActividad.Name = "ceActividad"
        Me.ceActividad.Size = New System.Drawing.Size(224, 20)
        Me.ceActividad.TabIndex = 85
        Me.ceActividad.Text = ""
        '
        'Label53
        '
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label53.Location = New System.Drawing.Point(248, 72)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(100, 16)
        Me.Label53.TabIndex = 63
        Me.Label53.Text = "Nro. de Empleados:"
        '
        'ceCiudad
        '
        Me.ceCiudad.Location = New System.Drawing.Point(8, 136)
        Me.ceCiudad.Name = "ceCiudad"
        Me.ceCiudad.Size = New System.Drawing.Size(160, 20)
        Me.ceCiudad.TabIndex = 115
        Me.ceCiudad.Text = ""
        '
        'Label54
        '
        Me.Label54.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label54.Location = New System.Drawing.Point(8, 120)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(100, 16)
        Me.Label54.TabIndex = 70
        Me.Label54.Text = "Ciudad:"
        '
        'ceDireccion
        '
        Me.ceDireccion.Location = New System.Drawing.Point(176, 136)
        Me.ceDireccion.Name = "ceDireccion"
        Me.ceDireccion.Size = New System.Drawing.Size(304, 20)
        Me.ceDireccion.TabIndex = 120
        Me.ceDireccion.Text = ""
        '
        'Label55
        '
        Me.Label55.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label55.Location = New System.Drawing.Point(176, 120)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(100, 16)
        Me.Label55.TabIndex = 68
        Me.Label55.Text = "Direccion:"
        '
        'ceAntiguedadAnterior
        '
        Me.ceAntiguedadAnterior.Location = New System.Drawing.Point(400, 184)
        Me.ceAntiguedadAnterior.Name = "ceAntiguedadAnterior"
        Me.ceAntiguedadAnterior.Size = New System.Drawing.Size(80, 20)
        Me.ceAntiguedadAnterior.TabIndex = 140
        Me.ceAntiguedadAnterior.Text = ""
        '
        'Label56
        '
        Me.Label56.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label56.Location = New System.Drawing.Point(400, 168)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(100, 16)
        Me.Label56.TabIndex = 81
        Me.Label56.Text = "Antiguedad:"
        '
        'ceOcupacion
        '
        Me.ceOcupacion.Items.AddRange(New Object() {"Empleado", "Independiente", "Jubilado"})
        Me.ceOcupacion.Location = New System.Drawing.Point(8, 40)
        Me.ceOcupacion.Name = "ceOcupacion"
        Me.ceOcupacion.Size = New System.Drawing.Size(120, 21)
        Me.ceOcupacion.TabIndex = 75
        '
        'Label57
        '
        Me.Label57.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label57.Location = New System.Drawing.Point(448, 72)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(100, 16)
        Me.Label57.TabIndex = 67
        Me.Label57.Text = "R.U.C."
        '
        'ceRUC
        '
        Me.ceRUC.Location = New System.Drawing.Point(448, 88)
        Me.ceRUC.Name = "ceRUC"
        Me.ceRUC.Size = New System.Drawing.Size(184, 20)
        Me.ceRUC.TabIndex = 110
        Me.ceRUC.Text = ""
        '
        'Label58
        '
        Me.Label58.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label58.Location = New System.Drawing.Point(248, 168)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(100, 16)
        Me.Label58.TabIndex = 79
        Me.Label58.Text = "Cargo:"
        '
        'ceCargoAnterior
        '
        Me.ceCargoAnterior.Location = New System.Drawing.Point(248, 184)
        Me.ceCargoAnterior.Name = "ceCargoAnterior"
        Me.ceCargoAnterior.Size = New System.Drawing.Size(144, 20)
        Me.ceCargoAnterior.TabIndex = 135
        Me.ceCargoAnterior.Text = ""
        '
        'ceTelefonoAnterior
        '
        Me.ceTelefonoAnterior.Location = New System.Drawing.Point(488, 184)
        Me.ceTelefonoAnterior.Name = "ceTelefonoAnterior"
        Me.ceTelefonoAnterior.Size = New System.Drawing.Size(144, 20)
        Me.ceTelefonoAnterior.TabIndex = 145
        Me.ceTelefonoAnterior.Text = ""
        '
        'Label59
        '
        Me.Label59.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label59.Location = New System.Drawing.Point(352, 72)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(100, 16)
        Me.Label59.TabIndex = 65
        Me.Label59.Text = "Ventas Anuales:"
        '
        'ceVentasAnuales
        '
        Me.ceVentasAnuales.Location = New System.Drawing.Point(352, 88)
        Me.ceVentasAnuales.Name = "ceVentasAnuales"
        Me.ceVentasAnuales.Size = New System.Drawing.Size(88, 20)
        Me.ceVentasAnuales.TabIndex = 105
        Me.ceVentasAnuales.Text = ""
        '
        'ceEmpresaAnterior
        '
        Me.ceEmpresaAnterior.Location = New System.Drawing.Point(8, 184)
        Me.ceEmpresaAnterior.Name = "ceEmpresaAnterior"
        Me.ceEmpresaAnterior.Size = New System.Drawing.Size(232, 20)
        Me.ceEmpresaAnterior.TabIndex = 130
        Me.ceEmpresaAnterior.Text = ""
        '
        'Label60
        '
        Me.Label60.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label60.Location = New System.Drawing.Point(8, 168)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(152, 16)
        Me.Label60.TabIndex = 76
        Me.Label60.Text = "Ocupacion Anterior (Empresa):"
        '
        'Label61
        '
        Me.Label61.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label61.Location = New System.Drawing.Point(8, 24)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(100, 16)
        Me.Label61.TabIndex = 52
        Me.Label61.Text = "Tipo Ocupacion:"
        '
        'ceCargo
        '
        Me.ceCargo.Location = New System.Drawing.Point(8, 88)
        Me.ceCargo.Name = "ceCargo"
        Me.ceCargo.Size = New System.Drawing.Size(144, 20)
        Me.ceCargo.TabIndex = 90
        Me.ceCargo.Text = ""
        '
        'ceNroEmpleados
        '
        Me.ceNroEmpleados.Location = New System.Drawing.Point(248, 88)
        Me.ceNroEmpleados.Name = "ceNroEmpleados"
        Me.ceNroEmpleados.Size = New System.Drawing.Size(96, 20)
        Me.ceNroEmpleados.TabIndex = 100
        Me.ceNroEmpleados.Text = ""
        '
        'Label62
        '
        Me.Label62.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label62.Location = New System.Drawing.Point(160, 72)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(100, 16)
        Me.Label62.TabIndex = 61
        Me.Label62.Text = "Antiguedad:"
        '
        'ceAntiguedad
        '
        Me.ceAntiguedad.Location = New System.Drawing.Point(160, 88)
        Me.ceAntiguedad.Name = "ceAntiguedad"
        Me.ceAntiguedad.Size = New System.Drawing.Size(80, 20)
        Me.ceAntiguedad.TabIndex = 95
        Me.ceAntiguedad.Text = ""
        '
        'ceEmpresa
        '
        Me.ceEmpresa.Location = New System.Drawing.Point(136, 40)
        Me.ceEmpresa.Name = "ceEmpresa"
        Me.ceEmpresa.Size = New System.Drawing.Size(264, 20)
        Me.ceEmpresa.TabIndex = 80
        Me.ceEmpresa.Text = ""
        '
        'Label63
        '
        Me.Label63.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label63.Location = New System.Drawing.Point(488, 120)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(100, 16)
        Me.Label63.TabIndex = 72
        Me.Label63.Text = "Telefono(s):"
        '
        'Label64
        '
        Me.Label64.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label64.Location = New System.Drawing.Point(8, 72)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(100, 16)
        Me.Label64.TabIndex = 59
        Me.Label64.Text = "Cargo:"
        '
        'ceTelefono
        '
        Me.ceTelefono.Location = New System.Drawing.Point(488, 136)
        Me.ceTelefono.Name = "ceTelefono"
        Me.ceTelefono.Size = New System.Drawing.Size(144, 20)
        Me.ceTelefono.TabIndex = 125
        Me.ceTelefono.Text = ""
        '
        'Label65
        '
        Me.Label65.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label65.Location = New System.Drawing.Point(136, 24)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(100, 16)
        Me.Label65.TabIndex = 55
        Me.Label65.Text = "Empresa:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(656, 454)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Referencias"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Label70)
        Me.GroupBox4.Controls.Add(Me.ctaNombre)
        Me.GroupBox4.Controls.Add(Me.tipoRef)
        Me.GroupBox4.Controls.Add(Me.Label69)
        Me.GroupBox4.Controls.Add(Me.Label68)
        Me.GroupBox4.Controls.Add(Me.institucion)
        Me.GroupBox4.Controls.Add(Me.cuenta)
        Me.GroupBox4.Controls.Add(Me.Label67)
        Me.GroupBox4.Controls.Add(Me.cupo)
        Me.GroupBox4.Controls.Add(Me.Label66)
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(640, 192)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bancarias"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(552, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 24)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Eliminar"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(176, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Agregar"
        '
        'Label70
        '
        Me.Label70.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label70.Location = New System.Drawing.Point(8, 120)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(112, 16)
        Me.Label70.TabIndex = 61
        Me.Label70.Tag = ""
        Me.Label70.Text = "Cuenta a Nombre de:"
        '
        'ctaNombre
        '
        Me.ctaNombre.Location = New System.Drawing.Point(8, 136)
        Me.ctaNombre.Name = "ctaNombre"
        Me.ctaNombre.Size = New System.Drawing.Size(248, 20)
        Me.ctaNombre.TabIndex = 20
        Me.ctaNombre.Text = ""
        '
        'tipoRef
        '
        Me.tipoRef.Items.AddRange(New Object() {"Corriente", "Ahorro"})
        Me.tipoRef.Location = New System.Drawing.Point(8, 88)
        Me.tipoRef.Name = "tipoRef"
        Me.tipoRef.Size = New System.Drawing.Size(136, 21)
        Me.tipoRef.TabIndex = 10
        '
        'Label69
        '
        Me.Label69.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label69.Location = New System.Drawing.Point(8, 72)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(100, 16)
        Me.Label69.TabIndex = 58
        Me.Label69.Text = "Tipo (Si Aplica):"
        '
        'Label68
        '
        Me.Label68.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label68.Location = New System.Drawing.Point(152, 72)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(100, 16)
        Me.Label68.TabIndex = 57
        Me.Label68.Tag = ""
        Me.Label68.Text = "Cupo (Si Aplica):"
        '
        'institucion
        '
        Me.institucion.Items.AddRange(New Object() {"Banco", "Tarjeta", "Otra"})
        Me.institucion.Location = New System.Drawing.Point(8, 40)
        Me.institucion.Name = "institucion"
        Me.institucion.Size = New System.Drawing.Size(136, 21)
        Me.institucion.TabIndex = 1
        '
        'cuenta
        '
        Me.cuenta.Location = New System.Drawing.Point(152, 40)
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Size = New System.Drawing.Size(104, 20)
        Me.cuenta.TabIndex = 5
        Me.cuenta.Text = "0"
        '
        'Label67
        '
        Me.Label67.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label67.Location = New System.Drawing.Point(152, 24)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(100, 16)
        Me.Label67.TabIndex = 54
        Me.Label67.Tag = ""
        Me.Label67.Text = "Cta./Nro."
        '
        'cupo
        '
        Me.cupo.Location = New System.Drawing.Point(152, 88)
        Me.cupo.Name = "cupo"
        Me.cupo.Size = New System.Drawing.Size(104, 20)
        Me.cupo.TabIndex = 15
        Me.cupo.Text = "0"
        '
        'Label66
        '
        Me.Label66.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label66.Location = New System.Drawing.Point(8, 24)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 16)
        Me.Label66.TabIndex = 52
        Me.Label66.Text = "Institucion:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(264, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(368, 144)
        Me.ListView1.TabIndex = 30
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Codigo"
        Me.ColumnHeader4.Width = 7
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Institucion"
        Me.ColumnHeader1.Width = 99
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cta./Nro."
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        Me.ColumnHeader3.Width = 150
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.parentRef)
        Me.GroupBox5.Controls.Add(Me.Label75)
        Me.GroupBox5.Controls.Add(Me.Label71)
        Me.GroupBox5.Controls.Add(Me.DireccionRef)
        Me.GroupBox5.Controls.Add(Me.Label72)
        Me.GroupBox5.Controls.Add(Me.nombreRef)
        Me.GroupBox5.Controls.Add(Me.Label74)
        Me.GroupBox5.Controls.Add(Me.telefonoRef)
        Me.GroupBox5.Controls.Add(Me.ListView2)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox5.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(640, 216)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Personales"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Location = New System.Drawing.Point(552, 160)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 24)
        Me.Button7.TabIndex = 70
        Me.Button7.Text = "Eliminar"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Location = New System.Drawing.Point(176, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 24)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Agregar"
        '
        'parentRef
        '
        Me.parentRef.Location = New System.Drawing.Point(120, 136)
        Me.parentRef.Name = "parentRef"
        Me.parentRef.Size = New System.Drawing.Size(136, 20)
        Me.parentRef.TabIndex = 55
        Me.parentRef.Text = ""
        '
        'Label75
        '
        Me.Label75.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label75.Location = New System.Drawing.Point(120, 120)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(112, 16)
        Me.Label75.TabIndex = 62
        Me.Label75.Tag = ""
        Me.Label75.Text = "Parentezco:"
        '
        'Label71
        '
        Me.Label71.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label71.Location = New System.Drawing.Point(8, 120)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(112, 16)
        Me.Label71.TabIndex = 61
        Me.Label71.Tag = ""
        Me.Label71.Text = "Telefonos:"
        '
        'DireccionRef
        '
        Me.DireccionRef.Location = New System.Drawing.Point(8, 88)
        Me.DireccionRef.Name = "DireccionRef"
        Me.DireccionRef.Size = New System.Drawing.Size(248, 20)
        Me.DireccionRef.TabIndex = 45
        Me.DireccionRef.Text = ""
        '
        'Label72
        '
        Me.Label72.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label72.Location = New System.Drawing.Point(8, 72)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(100, 16)
        Me.Label72.TabIndex = 58
        Me.Label72.Text = "Direccion:"
        '
        'nombreRef
        '
        Me.nombreRef.Location = New System.Drawing.Point(8, 40)
        Me.nombreRef.Name = "nombreRef"
        Me.nombreRef.Size = New System.Drawing.Size(248, 20)
        Me.nombreRef.TabIndex = 40
        Me.nombreRef.Text = ""
        '
        'Label74
        '
        Me.Label74.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label74.Location = New System.Drawing.Point(8, 24)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(100, 16)
        Me.Label74.TabIndex = 54
        Me.Label74.Tag = ""
        Me.Label74.Text = "Nombre:"
        '
        'telefonoRef
        '
        Me.telefonoRef.Location = New System.Drawing.Point(8, 136)
        Me.telefonoRef.Name = "telefonoRef"
        Me.telefonoRef.Size = New System.Drawing.Size(104, 20)
        Me.telefonoRef.TabIndex = 50
        Me.telefonoRef.Text = ""
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(264, 16)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(368, 144)
        Me.ListView2.TabIndex = 65
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Codigo"
        Me.ColumnHeader5.Width = 7
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre"
        Me.ColumnHeader6.Width = 171
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Relacion"
        Me.ColumnHeader7.Width = 89
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Telefono"
        Me.ColumnHeader8.Width = 85
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label82)
        Me.TabPage6.Controls.Add(Me.bcomentario)
        Me.TabPage6.Controls.Add(Me.Label81)
        Me.TabPage6.Controls.Add(Me.bavaluo)
        Me.TabPage6.Controls.Add(Me.Label80)
        Me.TabPage6.Controls.Add(Me.bhipoteca)
        Me.TabPage6.Controls.Add(Me.Label79)
        Me.TabPage6.Controls.Add(Me.btipo)
        Me.TabPage6.Controls.Add(Me.Button8)
        Me.TabPage6.Controls.Add(Me.Button9)
        Me.TabPage6.Controls.Add(Me.bubicacion)
        Me.TabPage6.Controls.Add(Me.Label77)
        Me.TabPage6.Controls.Add(Me.bdetalle)
        Me.TabPage6.Controls.Add(Me.Label78)
        Me.TabPage6.Controls.Add(Me.ListView3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(656, 454)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Bienes"
        '
        'Label82
        '
        Me.Label82.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label82.Location = New System.Drawing.Point(256, 64)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(112, 16)
        Me.Label82.TabIndex = 84
        Me.Label82.Tag = ""
        Me.Label82.Text = "Comentario:"
        '
        'bcomentario
        '
        Me.bcomentario.Location = New System.Drawing.Point(256, 80)
        Me.bcomentario.Name = "bcomentario"
        Me.bcomentario.Size = New System.Drawing.Size(392, 20)
        Me.bcomentario.TabIndex = 25
        Me.bcomentario.Text = ""
        '
        'Label81
        '
        Me.Label81.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label81.Location = New System.Drawing.Point(144, 64)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(112, 16)
        Me.Label81.TabIndex = 82
        Me.Label81.Tag = ""
        Me.Label81.Text = "Avaluo:"
        '
        'bavaluo
        '
        Me.bavaluo.Location = New System.Drawing.Point(144, 80)
        Me.bavaluo.Name = "bavaluo"
        Me.bavaluo.Size = New System.Drawing.Size(104, 20)
        Me.bavaluo.TabIndex = 20
        Me.bavaluo.Text = ""
        '
        'Label80
        '
        Me.Label80.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label80.Location = New System.Drawing.Point(8, 64)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(100, 16)
        Me.Label80.TabIndex = 80
        Me.Label80.Text = "Hipoteca/Prenda:"
        '
        'bhipoteca
        '
        Me.bhipoteca.Location = New System.Drawing.Point(8, 80)
        Me.bhipoteca.Name = "bhipoteca"
        Me.bhipoteca.Size = New System.Drawing.Size(128, 20)
        Me.bhipoteca.TabIndex = 15
        Me.bhipoteca.Text = ""
        '
        'Label79
        '
        Me.Label79.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label79.Location = New System.Drawing.Point(120, 16)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(100, 16)
        Me.Label79.TabIndex = 78
        Me.Label79.Text = "Detalle/Marca:"
        '
        'btipo
        '
        Me.btipo.Items.AddRange(New Object() {"Propiedad", "Vehiculo", "Otros"})
        Me.btipo.Location = New System.Drawing.Point(8, 32)
        Me.btipo.Name = "btipo"
        Me.btipo.Size = New System.Drawing.Size(104, 21)
        Me.btipo.TabIndex = 1
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(568, 416)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 24)
        Me.Button8.TabIndex = 40
        Me.Button8.Text = "Eliminar"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(568, 104)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 24)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "Agregar"
        '
        'bubicacion
        '
        Me.bubicacion.Location = New System.Drawing.Point(320, 32)
        Me.bubicacion.Name = "bubicacion"
        Me.bubicacion.Size = New System.Drawing.Size(328, 20)
        Me.bubicacion.TabIndex = 10
        Me.bubicacion.Text = ""
        '
        'Label77
        '
        Me.Label77.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label77.Location = New System.Drawing.Point(320, 16)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(136, 16)
        Me.Label77.TabIndex = 70
        Me.Label77.Text = "Ubicacion/Modelo y Año:"
        '
        'bdetalle
        '
        Me.bdetalle.Location = New System.Drawing.Point(120, 32)
        Me.bdetalle.Name = "bdetalle"
        Me.bdetalle.Size = New System.Drawing.Size(192, 20)
        Me.bdetalle.TabIndex = 5
        Me.bdetalle.Text = ""
        '
        'Label78
        '
        Me.Label78.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label78.Location = New System.Drawing.Point(8, 16)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(100, 16)
        Me.Label78.TabIndex = 68
        Me.Label78.Tag = ""
        Me.Label78.Text = "Tipo:"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(8, 136)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(640, 280)
        Me.ListView3.TabIndex = 35
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Codigo"
        Me.ColumnHeader9.Width = 7
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Tipo"
        Me.ColumnHeader10.Width = 94
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Detalle/Marca"
        Me.ColumnHeader11.Width = 174
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Ubicacion/Modelo y Año"
        Me.ColumnHeader12.Width = 259
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Avaluo"
        Me.ColumnHeader13.Width = 69
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ieDetalle)
        Me.TabPage7.Controls.Add(Me.Label84)
        Me.TabPage7.Controls.Add(Me.ieRegistro)
        Me.TabPage7.Controls.Add(Me.Button10)
        Me.TabPage7.Controls.Add(Me.Button11)
        Me.TabPage7.Controls.Add(Me.ieValor)
        Me.TabPage7.Controls.Add(Me.Label85)
        Me.TabPage7.Controls.Add(Me.Label86)
        Me.TabPage7.Controls.Add(Me.ListView4)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(656, 454)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Ingresos y Egresos"
        '
        'ieDetalle
        '
        Me.ieDetalle.Items.AddRange(New Object() {"Sueldo Deudor", "Sueldo Conyugue", "Otros Ingresos", "Tarjetas de Credito", "Educacion", "Alimentacion/Vestimenta", "Arriendo", "Empresa", "Otros Egresos", "Prestamos"})
        Me.ieDetalle.Location = New System.Drawing.Point(120, 32)
        Me.ieDetalle.MaxDropDownItems = 20
        Me.ieDetalle.Name = "ieDetalle"
        Me.ieDetalle.Size = New System.Drawing.Size(336, 21)
        Me.ieDetalle.TabIndex = 94
        '
        'Label84
        '
        Me.Label84.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label84.Location = New System.Drawing.Point(120, 16)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(104, 16)
        Me.Label84.TabIndex = 93
        Me.Label84.Text = "Detalle/Institucion:"
        '
        'ieRegistro
        '
        Me.ieRegistro.Items.AddRange(New Object() {"Ingreso", "Egreso"})
        Me.ieRegistro.Location = New System.Drawing.Point(8, 32)
        Me.ieRegistro.Name = "ieRegistro"
        Me.ieRegistro.Size = New System.Drawing.Size(104, 21)
        Me.ieRegistro.TabIndex = 1
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(568, 352)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 24)
        Me.Button10.TabIndex = 25
        Me.Button10.Text = "Eliminar"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(568, 32)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 24)
        Me.Button11.TabIndex = 15
        Me.Button11.Text = "Agregar"
        '
        'ieValor
        '
        Me.ieValor.Location = New System.Drawing.Point(464, 31)
        Me.ieValor.Name = "ieValor"
        Me.ieValor.Size = New System.Drawing.Size(96, 20)
        Me.ieValor.TabIndex = 10
        Me.ieValor.Text = ""
        '
        'Label85
        '
        Me.Label85.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label85.Location = New System.Drawing.Point(464, 15)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(136, 16)
        Me.Label85.TabIndex = 88
        Me.Label85.Text = "Valor:"
        '
        'Label86
        '
        Me.Label86.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label86.Location = New System.Drawing.Point(8, 15)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(100, 16)
        Me.Label86.TabIndex = 86
        Me.Label86.Tag = ""
        Me.Label86.Text = "Registro:"
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(8, 72)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(640, 280)
        Me.ListView4.TabIndex = 20
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Codigo"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Detalle/Institucion"
        Me.ColumnHeader16.Width = 453
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Ingresos"
        Me.ColumnHeader17.Width = 76
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Egresos"
        Me.ColumnHeader18.Width = 70
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label88)
        Me.TabPage2.Controls.Add(Me.crePlazo)
        Me.TabPage2.Controls.Add(Me.Label87)
        Me.TabPage2.Controls.Add(Me.creInicial)
        Me.TabPage2.Controls.Add(Me.Label83)
        Me.TabPage2.Controls.Add(Me.creValor)
        Me.TabPage2.Controls.Add(Me.CreModelo)
        Me.TabPage2.Controls.Add(Me.Label76)
        Me.TabPage2.Controls.Add(Me.creMarca)
        Me.TabPage2.Controls.Add(Me.Label73)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(656, 454)
        Me.TabPage2.TabIndex = 7
        Me.TabPage2.Text = "Credito"
        '
        'Label88
        '
        Me.Label88.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label88.Location = New System.Drawing.Point(544, 16)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(100, 16)
        Me.Label88.TabIndex = 102
        Me.Label88.Text = "Plazo:"
        '
        'crePlazo
        '
        Me.crePlazo.Location = New System.Drawing.Point(544, 32)
        Me.crePlazo.Name = "crePlazo"
        Me.crePlazo.Size = New System.Drawing.Size(104, 20)
        Me.crePlazo.TabIndex = 20
        Me.crePlazo.Text = ""
        '
        'Label87
        '
        Me.Label87.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label87.Location = New System.Drawing.Point(432, 16)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(100, 16)
        Me.Label87.TabIndex = 100
        Me.Label87.Text = "Cuota Inicial:"
        '
        'creInicial
        '
        Me.creInicial.Location = New System.Drawing.Point(432, 32)
        Me.creInicial.Name = "creInicial"
        Me.creInicial.Size = New System.Drawing.Size(104, 20)
        Me.creInicial.TabIndex = 15
        Me.creInicial.Text = ""
        '
        'Label83
        '
        Me.Label83.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label83.Location = New System.Drawing.Point(320, 16)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(100, 16)
        Me.Label83.TabIndex = 98
        Me.Label83.Text = "Valor:"
        '
        'creValor
        '
        Me.creValor.Location = New System.Drawing.Point(320, 32)
        Me.creValor.Name = "creValor"
        Me.creValor.Size = New System.Drawing.Size(104, 20)
        Me.creValor.TabIndex = 10
        Me.creValor.Text = ""
        '
        'CreModelo
        '
        Me.CreModelo.Location = New System.Drawing.Point(144, 32)
        Me.CreModelo.Name = "CreModelo"
        Me.CreModelo.Size = New System.Drawing.Size(168, 21)
        Me.CreModelo.TabIndex = 5
        '
        'Label76
        '
        Me.Label76.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label76.Location = New System.Drawing.Point(144, 16)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(100, 16)
        Me.Label76.TabIndex = 95
        Me.Label76.Tag = ""
        Me.Label76.Text = "Modelo:"
        '
        'creMarca
        '
        Me.creMarca.Location = New System.Drawing.Point(8, 32)
        Me.creMarca.Name = "creMarca"
        Me.creMarca.Size = New System.Drawing.Size(128, 21)
        Me.creMarca.TabIndex = 1
        '
        'Label73
        '
        Me.Label73.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label73.Location = New System.Drawing.Point(8, 16)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(100, 16)
        Me.Label73.TabIndex = 93
        Me.Label73.Tag = ""
        Me.Label73.Text = "Marca:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 40)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(640, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(632, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(592, 560)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Guardar"
        '
        'frmCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 589)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Credito"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New frmBuscaCliente
        x.ShowDialog()
        If gVar.codCli > 0 Then
            TextBox1.Text = Str(gVar.codCli) + " - " + gVar.tNombres
            MainClass.cargaCliente(gVar.codCli)
            Me.limpiaForm()
            Me.cargaDatosPer()
            Me.cargaDatos()
            MainClass.cargaListaRef(gVar.codCli, "Bancaria", ListView1)
            MainClass.cargaListaRef(gVar.codCli, "Personal", ListView2)
            MainClass.cargaListaBienes(gVar.codCli, ListView3)
            MainClass.cargaListaIE(gVar.codCli, ListView4)
        End If
    End Sub
    Public Sub cargaDatosPer()
        apeP.Text = gVar.tApellidoP
        apeM.Text = gVar.tApellidoM
        nombre.Text = gVar.tNombres
        tipoID.Text = gVar.tTipoID
        ID.Text = gVar.tID
        telefono.Text = gVar.tTelefono

        Direccion.Text = gVar.tDireccion
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.grabaCredito()
    End Sub

    Private Sub grabaCredito()
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Dim Rc0 As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)
        Try


            Rc0.Open("select clientes_codigo from caCredito where credito_estado='A' and clientes_codigo=" & Trim(MainClass.CualCod(TextBox1.Text)) & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            If Rc0.RecordCount > 0 Then
                Rc.Open("select * from caCredito where credito_estado='A' and clientes_codigo=" & Trim(MainClass.CualCod(TextBox1.Text)) & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Else
                Rc.Open("select * from caCredito", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Rc.AddNew()
            End If
            Rc0.Close()

            Rc.Fields.Item("credito_fecha").Value = System.DateTime.Today
            Rc.Fields.Item("credito_estado").Value = "A"
            Rc.Fields.Item("clientes_codigo").Value = MainClass.CualCod(Trim(TextBox1.Text))

            'Datos Personal
            If sexo.Text <> "" Then
                Rc.Fields.Item("credito_sexo").Value = sexo.Text
            End If
            If edad.Text <> "" Then
                Rc.Fields.Item("credito_edad").Value = edad.Text
            End If
            Rc.Fields.Item("credito_fecnac").Value = fecnac.Value
            If profesion.Text <> "" Then
                Rc.Fields.Item("credito_profesion").Value = profesion.Text
            End If
            If nacionalidad.Text <> "" Then
                Rc.Fields.Item("credito_nacionalidad").Value = nacionalidad.Text
            End If
            If tResidencia.Text <> "" Then
                Rc.Fields.Item("credito_residencia").Value = tResidencia.Text
            End If
            If Direccion.Text <> "" Then
                Rc.Fields.Item("credito_direccion").Value = Direccion.Text
            End If
            If ciudad.Text <> "" Then
                Rc.Fields.Item("credito_ciudad").Value = ciudad.Text
            End If
            If telefono.Text <> "" Then
                Rc.Fields.Item("credito_telefono").Value = telefono.Text
            End If
            If vivienda.Text <> "" Then
                Rc.Fields.Item("credito_tipovivienda").Value = vivienda.Text
            End If
            If hipoteca.Text <> "" Then
                Rc.Fields.Item("credito_hipoteca").Value = hipoteca.Text
            End If
            If montoMensual.Text <> "" Then
                Rc.Fields.Item("credito_montomensual").Value = montoMensual.Text
            End If
            If Alquiler.Text <> "" Then
                Rc.Fields.Item("credito_valoralquiler").Value = Alquiler.Text
            End If
            If nomArrendador.Text <> "" Then
                Rc.Fields.Item("credito_arrendador").Value = nomArrendador.Text
            End If
            If telArrendador.Text <> "" Then
                Rc.Fields.Item("credito_telarrendador").Value = telArrendador.Text
            End If
            If prentArrendador.Text <> "" Then
                Rc.Fields.Item("credito_parArrendatario").Value = prentArrendador.Text
            End If
            If nombrePropietario.Text <> "" Then
                Rc.Fields.Item("credito_familiarpropietario").Value = nombrePropietario.Text
            End If
            'Fin Datos Personal

            'Datos Conyugue
            If cApeP.Text <> "" Then
                Rc.Fields.Item("credito_conyApellidoP").Value = cApeP.Text
            End If
            If cApeM.Text <> "" Then
                Rc.Fields.Item("credito_conyapellidoM").Value = cApeM.Text
            End If
            If cNombres.Text <> "" Then
                Rc.Fields.Item("credito_conyNombres").Value = cNombres.Text
            End If
            If cTipoID.Text <> "" Then
                Rc.Fields.Item("credito_conyTipoID").Value = cTipoID.Text
            End If
            If cID.Text <> "" Then
                Rc.Fields.Item("credito_conyID").Value = cID.Text
            End If
            If cSexo.Text <> "" Then
                Rc.Fields.Item("credito_conySexo").Value = cSexo.Text
            End If
            If cEdad.Text <> "" Then
                Rc.Fields.Item("credito_conyEdad").Value = cEdad.Text
            End If
            Rc.Fields.Item("credito_conyFecNac").Value = cFecNac.Value
            If cProfesion.Text <> "" Then
                Rc.Fields.Item("credito_conyProfesion").Value = cProfesion.Text
            End If
            If cNacionalidad.Text <> "" Then
                Rc.Fields.Item("credito_conyNacionalidad").Value = cNacionalidad.Text
            End If
            If cTResidencia.Text <> "" Then
                Rc.Fields.Item("credito_conyTiempoResidencia").Value = cTResidencia.Text
            End If
            'Fin Datos Conyugue

            'Datos Laborales
            If sTipoOcupacion.Text <> "" Then
                Rc.Fields.Item("credito_SolTipoOcupacion").Value = sTipoOcupacion.Text
            End If
            If sEmpresa.Text <> "" Then
                Rc.Fields.Item("credito_SolEmpresa").Value = sEmpresa.Text
            End If
            If sActividad.Text <> "" Then
                Rc.Fields.Item("credito_SolActividadEmpresa").Value = sActividad.Text
            End If
            If sCargo.Text <> "" Then
                Rc.Fields.Item("credito_SolCargo").Value = sCargo.Text
            End If
            If sAntiguedad.Text <> "" Then
                Rc.Fields.Item("credito_SolAntiguedad").Value = sAntiguedad.Text
            End If
            If sNroEmpleados.Text <> "" Then
                Rc.Fields.Item("credito_SolNroEmpleados").Value = sNroEmpleados.Text
            End If
            If sVentas.Text <> "" Then
                Rc.Fields.Item("credito_SolVentasAnuales").Value = sVentas.Text
            End If
            If sRUC.Text <> "" Then
                Rc.Fields.Item("credito_SolRUC").Value = sRUC.Text
            End If
            If sCiudad.Text <> "" Then
                Rc.Fields.Item("credito_SolCiudad").Value = sCiudad.Text
            End If
            If sDireccion.Text <> "" Then
                Rc.Fields.Item("credito_SolDireccion").Value = sDireccion.Text
            End If
            If sTelefono.Text <> "" Then
                Rc.Fields.Item("credito_SolTelefono").Value = sTelefono.Text
            End If
            If sOcupacionAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolEmpresaAnterior").Value = sOcupacionAnterior.Text
            End If
            If sCargoAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolCargoAnterior").Value = sCargoAnterior.Text
            End If
            If sAntiguedadAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolAntiguedadAnterior").Value = sAntiguedadAnterior.Text
            End If
            If sTelefonoAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolTelefonoAnterior").Value = sTelefonoAnterior.Text
            End If


            If ceOcupacion.Text <> "" Then
                Rc.Fields.Item("credito_SolConyTipoOcupacion").Value = ceOcupacion.Text
            End If
            If ceEmpresa.Text <> "" Then
                Rc.Fields.Item("credito_SolConyEmpresa").Value = ceEmpresa.Text
            End If
            If ceActividad.Text <> "" Then
                Rc.Fields.Item("credito_SolConyActividadEmpresa").Value = ceActividad.Text
            End If
            If ceCargo.Text <> "" Then
                Rc.Fields.Item("credito_SolConyCargo").Value = ceCargo.Text
            End If
            If ceAntiguedad.Text <> "" Then
                Rc.Fields.Item("credito_SolConyAntiguedad").Value = ceAntiguedad.Text
            End If
            If ceNroEmpleados.Text <> "" Then
                Rc.Fields.Item("credito_SolConyNroEmpleados").Value = ceNroEmpleados.Text
            End If
            If ceVentasAnuales.Text <> "" Then
                Rc.Fields.Item("credito_SolConyVentasAnuales").Value = ceVentasAnuales.Text
            End If
            If ceRUC.Text <> "" Then
                Rc.Fields.Item("credito_SolConyRUC").Value = ceRUC.Text
            End If
            If ceCiudad.Text <> "" Then
                Rc.Fields.Item("credito_SolConyCiudad").Value = ceCiudad.Text
            End If
            If ceDireccion.Text <> "" Then
                Rc.Fields.Item("credito_SolConyDireccion").Value = ceDireccion.Text
            End If
            If ceTelefono.Text <> "" Then
                Rc.Fields.Item("credito_SolConyTelefono").Value = ceTelefono.Text
            End If
            If ceEmpresaAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolConyEmpresaAnterior").Value = ceEmpresaAnterior.Text
            End If
            If ceCargoAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolConyCargoAnterior").Value = ceCargoAnterior.Text
            End If
            If ceAntiguedadAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolConyAntiguedadAnterior").Value = ceAntiguedadAnterior.Text
            End If
            If ceTelefonoAnterior.Text <> "" Then
                Rc.Fields.Item("credito_SolConyTelefonoAnterior").Value = ceTelefonoAnterior.Text
            End If
            'Fin Datos Laborales

            'Datos Credito
            If creMarca.Text <> "" Then
                Rc.Fields.Item("credito_marca").Value = creMarca.Text
            End If
            If CreModelo.Text <> "" Then
                Rc.Fields.Item("credito_modelo").Value = CreModelo.Text
            End If
            If creValor.Text <> "" Then
                Rc.Fields.Item("credito_valor").Value = creValor.Text
            End If
            If creInicial.Text <> "" Then
                Rc.Fields.Item("credito_Inicial").Value = creInicial.Text
            End If
            If crePlazo.Text <> "" Then
                Rc.Fields.Item("credito_plazo").Value = crePlazo.Text
            End If
            'Fin Datos Credito
            MsgBox("Datos Guardados")
            Rc.Update()
            Rc.Close()
            Db.Close()

        Catch ex As Exception
            MsgBox("Error en Grabado, Revisar Datos")
        End Try
        
    End Sub

    Private Sub limpiaForm()
        ' sexo.Text
        ' edad.Text
        ' fecnac.Value
        ' profesion.Text
        ' nacionalidad.Text
        ' tResidencia.Text
        ' Direccion.Text
        ' ciudad.Text
        ' telefono.Text
        ' vivienda.Text
        ' hipoteca.Text
        ' montoMensual.Text
        ' Alquiler.Text
        ' nomArrendador.Text
        ' telArrendador.Text
        ' prentArrendador.Text
        ' nombrePropietario.Text
        ' cApeP.Text
        ' cApeM.Text
        ' cNombres.Text
        ' cTipoID.Text
        ' cID.Text
        ' cSexo.Text
        ' cEdad.Text
        ' cFecNac.Value
        ' cProfesion.Text
        ' cNacionalidad.Text
        ' cTResidencia.Text
        ' sTipoOcupacion.Text
        ' sEmpresa.Text
        ' sActividad.Text
        ' sCargo.Text
        ' sAntiguedad.Text
        ' sNroEmpleados.Text
        ' sVentas.Text
        ' sRUC.Text
        ' sCiudad.Text
        ' sDireccion.Text
        ' sTelefono.Text
        ' sOcupacionAnterior.Text
        ' sCargoAnterior.Text
        ' sAntiguedadAnterior.Text
        ' sTelefonoAnterior.Text
        ' ceOcupacion.Text
        ' ceEmpresa.Text
        ' ceActividad.Text
        ' ceCargo.Text
        ' ceAntiguedad.Text
        ' ceNroEmpleados.Text
        ' ceVentasAnuales.Text
        ' ceRUC.Text
        ' ceCiudad.Text
        ' ceDireccion.Text
        ' ceTelefono.Text
        ' ceEmpresaAnterior.Text
        ' ceCargoAnterior.Text
        'ceAntiguedadAnterior.Text
        'ceTelefonoAnterior.Text
        'creMarca.Text
        'CreModelo.Text
        'creValor.Text
        'creInicial.Text
        'crePlazo.Text

        sexo.Text = ""
        edad.Text = ""
        fecnac.Value = System.DateTime.Today
        profesion.Text = ""
        nacionalidad.Text = ""
        tResidencia.Text = ""
        Direccion.Text = ""
        ciudad.Text = ""
        telefono.Text = ""
        vivienda.Text = ""
        hipoteca.Text = ""
        montoMensual.Text = ""
        Alquiler.Text = ""
        nomArrendador.Text = ""
        telArrendador.Text = ""
        prentArrendador.Text = ""
        nombrePropietario.Text = ""
        cApeP.Text = ""
        cApeM.Text = ""
        cNombres.Text = ""
        cTipoID.Text = ""
        cID.Text = ""
        cSexo.Text = ""
        cEdad.Text = ""
        cFecNac.Value = System.DateTime.Today
        cProfesion.Text = ""
        cNacionalidad.Text = ""
        cTResidencia.Text = ""
        sTipoOcupacion.Text = ""
        sEmpresa.Text = ""
        sActividad.Text = ""
        sCargo.Text = ""
        sAntiguedad.Text = ""
        sNroEmpleados.Text = ""
        sVentas.Text = ""
        sRUC.Text = ""
        sCiudad.Text = ""
        sDireccion.Text = ""
        sTelefono.Text = ""
        sOcupacionAnterior.Text = ""
        sCargoAnterior.Text = ""
        sAntiguedadAnterior.Text = ""
        sTelefonoAnterior.Text = ""
        ceOcupacion.Text = ""
        ceEmpresa.Text = ""
        ceActividad.Text = ""
        ceCargo.Text = ""
        ceAntiguedad.Text = ""
        ceNroEmpleados.Text = ""
        ceVentasAnuales.Text = ""
        ceRUC.Text = ""
        ceCiudad.Text = ""
        ceDireccion.Text = ""
        ceTelefono.Text = ""
        ceEmpresaAnterior.Text = ""
        ceCargoAnterior.Text = ""
        ceAntiguedadAnterior.Text = ""
        ceTelefonoAnterior.Text = ""
        creMarca.Text = ""
        CreModelo.Text = ""
        creValor.Text = ""
        creInicial.Text = ""
        crePlazo.Text = ""

    End Sub

    Private Sub cargaDatos()
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(MainClass.provider_sql)

        Rc.Open("select * from caCredito where credito_estado='A' and clientes_codigo=" & Trim(MainClass.CualCod(TextBox1.Text)) & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Rc.RecordCount > 0 Then
            'Datos Personal
            If IsDBNull(Rc.Fields.Item("credito_sexo").Value) = False Then
                sexo.Text = Rc.Fields.Item("credito_sexo").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_edad").Value) = False Then
                edad.Text = Rc.Fields.Item("credito_edad").Value
            End If
            fecnac.Value = Rc.Fields.Item("credito_fecnac").Value
            If IsDBNull(Rc.Fields.Item("credito_profesion").Value) = False Then
                profesion.Text = Rc.Fields.Item("credito_profesion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_nacionalidad").Value) = False Then
                nacionalidad.Text = Rc.Fields.Item("credito_nacionalidad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_residencia").Value) = False Then
                tResidencia.Text = Rc.Fields.Item("credito_residencia").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_direccion").Value) = False Then
                Direccion.Text = Rc.Fields.Item("credito_direccion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_ciudad").Value) = False Then
                ciudad.Text = Rc.Fields.Item("credito_ciudad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_telefono").Value) = False Then
                telefono.Text = Rc.Fields.Item("credito_telefono").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_tipovivienda").Value) = False Then
                vivienda.Text = Rc.Fields.Item("credito_tipovivienda").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_hipoteca").Value) = False Then
                hipoteca.Text = Rc.Fields.Item("credito_hipoteca").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_montomensual").Value) = False Then
                montoMensual.Text = Rc.Fields.Item("credito_montomensual").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_valoralquiler").Value) = False Then
                Alquiler.Text = Rc.Fields.Item("credito_valoralquiler").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_arrendador").Value) = False Then
                nomArrendador.Text = Rc.Fields.Item("credito_arrendador").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_telarrendador").Value) = False Then
                telArrendador.Text = Rc.Fields.Item("credito_telarrendador").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_parArrendatario").Value) = False Then
                prentArrendador.Text = Rc.Fields.Item("credito_parArrendatario").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_familiarpropietario").Value) = False Then
                nombrePropietario.Text = Rc.Fields.Item("credito_familiarpropietario").Value
            End If
            'Fin Datos Personal

            'Datos Conyugue
            If IsDBNull(Rc.Fields.Item("credito_conyApellidoP").Value) = False Then
                cApeP.Text = Rc.Fields.Item("credito_conyApellidoP").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyapellidoM").Value) = False Then
                cApeM.Text = Rc.Fields.Item("credito_conyapellidoM").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyNombres").Value) = False Then
                cNombres.Text = Rc.Fields.Item("credito_conyNombres").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyTipoID").Value) = False Then
                cTipoID.Text = Rc.Fields.Item("credito_conyTipoID").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyID").Value) = False Then
                cID.Text = Rc.Fields.Item("credito_conyID").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conySexo").Value) = False Then
                cSexo.Text = Rc.Fields.Item("credito_conySexo").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyEdad").Value) = False Then
                cEdad.Text = Rc.Fields.Item("credito_conyEdad").Value
            End If
            cFecNac.Value = Rc.Fields.Item("credito_conyFecNac").Value
            If IsDBNull(Rc.Fields.Item("credito_conyProfesion").Value) = False Then
                cProfesion.Text = Rc.Fields.Item("credito_conyProfesion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyNacionalidad").Value) = False Then
                cNacionalidad.Text = Rc.Fields.Item("credito_conyNacionalidad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_conyTiempoResidencia").Value) = False Then
                cTResidencia.Text = Rc.Fields.Item("credito_conyTiempoResidencia").Value
            End If
            'Fin Datos Conyugue

            'Datos Laborales
            If IsDBNull(Rc.Fields.Item("credito_SolTipoOcupacion").Value) = False Then
                sTipoOcupacion.Text = Rc.Fields.Item("credito_SolTipoOcupacion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolEmpresa").Value) = False Then
                sEmpresa.Text = Rc.Fields.Item("credito_SolEmpresa").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolActividadEmpresa").Value) = False Then
                sActividad.Text = Rc.Fields.Item("credito_SolActividadEmpresa").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolCargo").Value) = False Then
                sCargo.Text = Rc.Fields.Item("credito_SolCargo").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolAntiguedad").Value) = False Then
                sAntiguedad.Text = Rc.Fields.Item("credito_SolAntiguedad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolNroEmpleados").Value) = False Then
                sNroEmpleados.Text = Rc.Fields.Item("credito_SolNroEmpleados").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolVentasAnuales").Value) = False Then
                sVentas.Text = Rc.Fields.Item("credito_SolVentasAnuales").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolRUC").Value) = False Then
                sRUC.Text = Rc.Fields.Item("credito_SolRUC").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolCiudad").Value) = False Then
                sCiudad.Text = Rc.Fields.Item("credito_SolCiudad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolDireccion").Value) = False Then
                sDireccion.Text = Rc.Fields.Item("credito_SolDireccion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolTelefono").Value) = False Then
                sTelefono.Text = Rc.Fields.Item("credito_SolTelefono").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolEmpresaAnterior").Value) = False Then
                sOcupacionAnterior.Text = Rc.Fields.Item("credito_SolEmpresaAnterior").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolCargoAnterior").Value) = False Then
                sCargoAnterior.Text = Rc.Fields.Item("credito_SolCargoAnterior").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolAntiguedadAnterior").Value) = False Then
                sAntiguedadAnterior.Text = Rc.Fields.Item("credito_SolAntiguedadAnterior").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolTelefonoAnterior").Value) = False Then
                sTelefonoAnterior.Text = Rc.Fields.Item("credito_SolTelefonoAnterior").Value
            End If


            If IsDBNull(Rc.Fields.Item("credito_SolConyTipoOcupacion").Value) = False Then
                ceOcupacion.Text = Rc.Fields.Item("credito_SolConyTipoOcupacion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyEmpresa").Value) = False Then
                ceEmpresa.Text = Rc.Fields.Item("credito_SolConyEmpresa").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyActividadEmpresa").Value) = False Then
                ceActividad.Text = Rc.Fields.Item("credito_SolConyActividadEmpresa").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyCargo").Value) = False Then
                ceCargo.Text = Rc.Fields.Item("credito_SolConyCargo").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyAntiguedad").Value) = False Then
                ceAntiguedad.Text = Rc.Fields.Item("credito_SolConyAntiguedad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyNroEmpleados").Value) = False Then
                ceNroEmpleados.Text = Rc.Fields.Item("credito_SolConyNroEmpleados").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyVentasAnuales").Value) = False Then
                ceVentasAnuales.Text = Rc.Fields.Item("credito_SolConyVentasAnuales").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyRUC").Value) = False Then
                ceRUC.Text = Rc.Fields.Item("credito_SolConyRUC").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyCiudad").Value) = False Then
                ceCiudad.Text = Rc.Fields.Item("credito_SolConyCiudad").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyDireccion").Value) = False Then
                ceDireccion.Text = Rc.Fields.Item("credito_SolConyDireccion").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyTelefono").Value) = False Then
                ceTelefono.Text = Rc.Fields.Item("credito_SolConyTelefono").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyEmpresaAnterior").Value) = False Then
                ceEmpresaAnterior.Text = Rc.Fields.Item("credito_SolConyEmpresaAnterior").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyCargoAnterior").Value) = False Then
                ceCargoAnterior.Text = Rc.Fields.Item("credito_SolConyCargoAnterior").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyAntiguedadAnterior").Value) = False Then
                ceAntiguedadAnterior.Text = Rc.Fields.Item("credito_SolConyAntiguedadAnterior").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_SolConyTelefonoAnterior").Value) = False Then
                ceTelefonoAnterior.Text = Rc.Fields.Item("credito_SolConyTelefonoAnterior").Value
            End If
            'Fin Datos Laborales

            'Datos Credito
            If IsDBNull(Rc.Fields.Item("credito_marca").Value) = False Then
                creMarca.Text = Rc.Fields.Item("credito_marca").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_modelo").Value) = False Then
                CreModelo.Text = Rc.Fields.Item("credito_modelo").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_valor").Value) = False Then
                creValor.Text = Rc.Fields.Item("credito_valor").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_Inicial").Value) = False Then
                creInicial.Text = Rc.Fields.Item("credito_Inicial").Value
            End If
            If IsDBNull(Rc.Fields.Item("credito_plazo").Value) = False Then
                crePlazo.Text = Rc.Fields.Item("credito_plazo").Value
            End If
            'Fin Datos Credito
        Else
            MsgBox("No Existen Datos")
        End If

        Rc.Close()
        Db.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            MainClass.grabaReferencia(MainClass.CualCod(TextBox1.Text), "Bancaria", Trim(institucion.Text), Trim(cuenta.Text), Trim(tipoRef.Text), cupo.Text, Trim(ctaNombre.Text), "0", "0", "0")
            MainClass.cargaListaRef(gVar.codCli, "Bancaria", ListView1)
        Catch ex As Exception
            MsgBox("Problema en Grabado, Revise los Datos")
        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            MainClass.grabaReferencia(MainClass.CualCod(TextBox1.Text), "Personal", "0", "0", "0", "0", Trim(nombreRef.Text), Trim(DireccionRef.Text), Trim(telefonoRef.Text), Trim(parentRef.Text))
            MainClass.cargaListaRef(gVar.codCli, "Personal", ListView2)
        Catch ex As Exception
            MsgBox("Problema en Grabado, Revise los Datos")
        End Try

    End Sub

    Private Sub frmCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListView1.SelectedItems.Count > 0 Then
            MainClass.borraReferencia(ListView1.SelectedItems(0).Text)
            MainClass.cargaListaRef(gVar.codCli, "Bancaria", ListView1)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ListView2.SelectedItems.Count > 0 Then
            MainClass.borraReferencia(ListView2.SelectedItems(0).Text)
            MainClass.cargaListaRef(gVar.codCli, "Personal", ListView2)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            MainClass.grabaBienes(MainClass.CualCod(TextBox1.Text), btipo.Text, bdetalle.Text, bubicacion.Text, bhipoteca.Text, bavaluo.Text, bcomentario.Text)
            MainClass.cargaListaBienes(gVar.codCli, ListView3)
            bdetalle.Text = ""
            bubicacion.Text = ""
            bhipoteca.Text = ""
            bavaluo.Text = ""
            bcomentario.Text = ""
        Catch ex As Exception
            MsgBox("Problema en Grabado, Revise los Datos")
        End Try

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MainClass.borraBienes(ListView3.SelectedItems(0).Text)
        MainClass.cargaListaBienes(gVar.codCli, ListView3)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            MainClass.grabaIE(gVar.codCli, ieRegistro.Text, ieDetalle.Text, ieValor.Text)
            MainClass.cargaListaIE(gVar.codCli, ListView4)
        Catch ex As Exception
            MsgBox("Problema en Grabado, Revise los Datos")
        End Try

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MainClass.borraIE(ListView4.SelectedItems(0).Text)
        MainClass.cargaListaIE(gVar.codCli, ListView4)
    End Sub
End Class
