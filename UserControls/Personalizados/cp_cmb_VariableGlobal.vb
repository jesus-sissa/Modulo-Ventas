Imports System.Data.SqlClient
Imports Modulo_Ventas.Cn_Datos
Imports Modulo_Ventas.FuncionesGlobales

Public Class cp_cmb_VariableGlobal
    Inherits cp_Combobox

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _NombreParametro As String

    Private _ValorParametro As Object

    Private _Tipodedatos As System.Data.SqlDbType

#End Region

#Region "Propiedades"

    Public Property StoredProcedure() As String
        Get
            Return _StoredProcedure
        End Get
        Set(ByVal value As String)
            _StoredProcedure = value
        End Set
    End Property

    Public Property NombreParametro() As String
        Get
            Return _NombreParametro
        End Get
        Set(ByVal value As String)
            _NombreParametro = value
        End Set
    End Property

    Public Property ValorParametro() As Object
        Get
            Return _NombreParametro
        End Get
        Set(ByVal value As Object)
            _NombreParametro = value
        End Set
    End Property

    Public Property Tipodedatos() As System.Data.SqlDbType
        Get
            Return _Tipodedatos
        End Get
        Set(ByVal value As System.Data.SqlDbType)
            _Tipodedatos = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Sub Actualizar()
        If StoredProcedure = "" Then MsgBox("Debe asignar la propiedad stored procedure al elemento. " & Me.Name, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        Tbl = CreaTabla()
        fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
    End Sub

#End Region

#Region "Funciones"

    Private Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(Cmd, _NombreParametro, _Tipodedatos, _ValorParametro)

        Return EjecutaConsulta(Cmd)
    End Function

#End Region

End Class
