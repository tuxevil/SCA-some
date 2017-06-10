Public Class var_globales
    Public tempCodigo, tempAcceso, tempCodUser As Integer
    Public tempMarca, tempModelo, tempDescripcion, tempCilindraje, tempTransmision, tempSeguridad, tempPrecio, tempNombreUSer, tempNickUser As String
    Public tempEntradaMinima As Double
    Public codCli As Integer
    Public tApellidoP, tApellidoM, tNombres, tTipoID, tID, tEmail, tTelefono, tCelular, tFax, tDireccion As String
    Public sFechaConsulta As Date
    Public sEstadoSeg, sObservacion, sUsuario As String
    Public cModelo, cInstitucion, cEntrada, cPlazo As String
    Public NumCot As Integer
    Public utDatos, utSeguimiento, utCotizaciones, utIngresoCredito, utClientes, utUsuarios, utVehiculos, utBancos, utParUsuarios, utAgenda As Integer
    Public vMarca, vModelo, vDescripcion, vCilindraje, vTransmision, vSeguridad As String
    Public vPrecio As Double
    Public bDescripcion, bRuta As String
    Public bEntrada, bInteres As Double
    Public bCodigo, bPlazo, bPaginas As Integer
    Public tuDatos, tuSeguimiento, tuCotizaciones, tuIngresoCredito, tuClientes, tuUsuarios, tuVehiculos, tuBancos, tuParUsuarios, tuAgenda, tuSuperUser As Integer
    Public licNumero, licEmpresa, licAno As String
    Public superuser As Integer
    'variables de fechas para reportes administrativos
    Public RAfec1, RAfec2 As System.DateTime
    'este flag es 1 para mostrar RA_Cotizaciones y 2 para RA_Ventas y 3 para RA?Solicitudes
    Public RAflag As Integer
    Public reporte_ventas As String
    Public reporte_cotizaciones As String
    Public reporte_solicitudes As String
    Public es_reporte_cotizacion As Integer = 1
    Public Fecha_Asc As Integer = 1
    Public fecha_orden As String
    Public Nombre_Server As String = "Multiserver"






End Class
