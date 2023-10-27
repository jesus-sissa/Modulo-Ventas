Module Variables

    Public Cnx_Datos As String = ""
    Public ServDatos As String = ""
    Public BaseDatos As String = ""
    Public UsuarioDatos As String = ""
    Public ContraDatos As String = ""
    Public SucursalDatos As String = ""
    Public CadenaPermisosControles As String = ""

    Public SucursalLat As Decimal = 0.0
    Public SucursalLon As Decimal = 0.0
    Public UsuarioId As Long
    Public UsuarioN As String
    Public EmpresaId As Long
    Public SucursalId As Long
    Public SucursalN As String
    Public ProcesoD As Long
    Public EstacioN As String
    Public EstacionIp As String
    Public EstacionMac As String
    Public MonedaId As Long
    Public ModuloClave As String

    Public ModuloVersion As String
    Public ContraHash As String
    Public UsuarioTipo As Byte
    Public CiaId As Integer
    Public I As Long
    Public J As Long
    Public ResP As Integer
    Public BanderA As Boolean
    Public TurnoId As Integer
    Public DepartamentoID As Integer
    Public ModuloNombre As String
    Public CambiarConexion As Boolean
    Public Mail_ReporteFallas As String
    Public GoogleMapsKey As String

    Public Usar_ProspectosCli As String
    Public Clave_AutomaticaCli As String

    Public LoginId As Long
    Public MinutosDesconexion As Integer 'Parametro de Cat_Sucursales
    Public SegundosDesconexion As Integer 'Contador de segundos para el Bloqueo
    Public TipoBloqueo As Byte '0=No Bloqueado; 1=Bloqueado por el Usuario; 2=Bloqueado por inactividad
    Public Intentos_Login As Byte = 0
    Public Acceso As Boolean = False

    Public Structure Estructura_Archivo
        Dim Id_Archivo As String
        Dim Nombre_Archivo As String
        Dim Ruta_Archivo As String
        Dim RutaAnt_Archivo As String
        Dim Extension_Archivo As String
        Dim MimeType_Archivo As String
        Dim Descripcion_Archivo As String
        Dim FileSize_Archivo As Integer
        Dim Objeto_Archivo As Byte()
        Dim Adicional_Archivo As String
    End Structure

    Public Arreglo_Archivo() As Estructura_Archivo 'Arreglo para la Estructura de Archivos

    Public Meses(12) As String
    Public MesesLargo(12) As String

    Public Mostrando_Alerta As Boolean

End Module
