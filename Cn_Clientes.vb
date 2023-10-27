Imports System.Data.SqlClient
Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Datos

Public Class Cn_Clientes

#Region "Menu"

    Public Shared Function fn_Menu_TipoCambio() As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_TipoCambio_Copiar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_Bajas() As Integer
        'Revisar si existen Bajas pendientes por Aplicar y Aplicarlas
        'Valida si tiene una Caja Fuerte en Renta
        Dim Cantidad As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_Bajas_Aplicar")
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)

            Cantidad = EjecutarScalarT(cmd)

            tr.Commit()
            cmd.Dispose()
            tr.Dispose()
            Cnn.Dispose()
            Return Cantidad

        Catch ex As Exception
            tr.Rollback()
            tr.Dispose()
            Cnn.Dispose()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_AlertasDestinos_Consultar(ByVal Clave_Alerta As String) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasDestinos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_Alerta)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String, ByVal AlertasD As DataTable, ByVal EnviarMail As Boolean, ByVal Asunto As String, ByVal Adjunto As String, ByVal DetallesHTML As String) As Boolean
        Dim Id_Alerta As Integer = 0
        Dim cmd As SqlCommand
        Dim Dt_Destinos As DataTable
        Dim Encabezado As String = ""
        Dim Pie As String = ""

        Try
            'Obtener los Destinos
            Dt_Destinos = fn_AlertasDestinos_Consultar(Clave_AlertaTipo)
            If Dt_Destinos IsNot Nothing Then
                If Adjunto <> "" Then
                    Detalles = Detalles & Chr(13) & Chr(13) & "(Ver archivo adjunto)"
                End If

                'Guardar la alerta para cada destino
                For Each Destino As DataRow In Dt_Destinos.Rows
                    cmd = Crea_Comando("Cat_AlertasGeneradas_CreateUna", CommandType.StoredProcedure, Crea_ConexionSTD())
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
                    Crea_Parametro(cmd, "@Detalles", SqlDbType.Text, Detalles)
                    Crea_Parametro(cmd, "@Id_EmpleadoDestino", SqlDbType.Int, Destino("Id_Empleado"))
                    Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)
                    Id_Alerta = CInt(EjecutarScalar(cmd))
                    'Guardar el Detalle para cada alerta generada
                    If AlertasD IsNot Nothing Then
                        For Each dr As DataRow In AlertasD.Rows
                            cmd.Parameters.Clear()
                            cmd = Crea_Comando("Cat_AlertasGeneradasD_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
                            Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
                            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, dr("Id"))
                            Crea_Parametro(cmd, "@Clave_Entidad", SqlDbType.VarChar, dr("Clave"))
                            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, dr("Nombre"))
                            EjecutarNonQuery(cmd)
                        Next
                    End If
                    If EnviarMail Then
                        Select Case Clave_AlertaTipo
                            Case "14"
                                Encabezado = "Por medio del presente se le informa del Registro del Nuevo Cliente con los siguientes datos:"
                            Case "15"
                                Encabezado = "Por medio del presente se le informa de la Baja del Cliente con los siguientes datos a partir de la fecha señalada:"
                            Case "16"
                                Encabezado = "Por medio del presente se le informa del Reingreso del Cliente con los siguientes datos a partir de la fecha señalada:"
                        End Select

                        Pie = "Agente de Servicios SIAC " & Today.Year.ToString

                        If DetallesHTML = "" Then
                            Cn_Mail.fn_Enviar_Mail(Destino("Mail"), Asunto, Detalles)
                            'Cn_Mail.fn_Enviar_Mail("raul.coss@sissaseguridad.com", Asunto, Detalles)
                            'Cn_Mail.fn_Enviar_Mail("asurbz@gmail.com", Asunto, Detalles)
                            'Exit Function
                        Else
                            DetallesHTML = Replace(DetallesHTML, "Encabezado", Encabezado)
                            DetallesHTML = Replace(DetallesHTML, "Pie", Pie)

                            Cn_Mail.fn_Enviar_MailHTML(Destino("Mail"), Asunto, DetallesHTML, Adjunto)
                            'Cn_Mail.fn_Enviar_MailHTML("raul.coss@sissaseguridad.com", Asunto, DetallesHTML)
                            'Cn_Mail.fn_Enviar_MailHTML("asurbz@gmail.com", Asunto, DetallesHTML)
                            'Exit Function
                        End If
                    End If
                Next
                Return True
            Else
                'No se encontraron destinos
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Clientes"

    Public Shared Function fn_Clientes_Administrativos(ByVal Id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesAdmin_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
        If Tbl.Rows.Count > 0 Then
            Return Tbl.Rows(0)
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function fn_Clientes_Contactos(ByVal Id_Cliente As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesContactosEnlace_Get", CommandType.StoredProcedure, cnn)
        Try
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            lsv.Actualizar(cmd, "Id_ContactoCliente")
            lsv.Columns(11).Width = 160
            lsv.Columns(12).Width = 160
            lsv.Columns(13).Width = 160
            For contador As Integer = 14 To 25
                lsv.Columns(contador).Width = 0
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_ContactosBuscar(ByRef lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesContactosEnlace_GetBuscar", CommandType.StoredProcedure, cnn)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Try
            lsv.Actualizar(cmd, "Id_Contacto")
            lsv.Columns(10).Width = 0
            lsv.Columns(11).Width = 0
            lsv.Columns(12).Width = 0
            lsv.Columns(13).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_Servicios_Horarios(ByVal Id_Cliente As Integer, ByRef lsv As cp_Listview, ByVal Status As String, ByVal Traslado As String, Optional ByVal subCliente As String = "N") As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_Get", CommandType.StoredProcedure, cnn)
        Try
            Crea_Parametro(cmd, "@IdCliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Traslado", SqlDbType.VarChar, Traslado)
            Crea_Parametro(cmd, "@SubClientes", SqlDbType.VarChar, subCliente)
            lsv.Actualizar(cmd, "Id_CS")

            '----------------
            For contador As Integer = 0 To lsv.Items.Count - 1
                If lsv.Items(contador).SubItems(17).Text = "BAJA" Then
                    lsv.Items(contador).BackColor = Color.Coral
                End If
            Next
            lsv.Columns(7).Width = 0
            lsv.Columns(8).Width = 0
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            '--------------si es TV mostar Todas columnas-----
            If Traslado = "S" Then
                For contador2 As Integer = 10 To 17
                    lsv.Columns(contador2).Width = 100
                Next
                lsv.Columns(18).Width = 0
                lsv.Columns(19).Width = 0
                lsv.Columns(20).Width = 0
                lsv.Columns(6).TextAlign = HorizontalAlignment.Right
                lsv.Columns(8).TextAlign = HorizontalAlignment.Right
                lsv.Columns(10).TextAlign = HorizontalAlignment.Right
                lsv.Columns(11).TextAlign = HorizontalAlignment.Right
                '-----------------------
            Else
                For contador3 As Integer = 10 To 20
                    lsv.Columns(contador3).Width = 0
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_TEF(ByVal Id_Cliente As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesTEF_Get", CommandType.StoredProcedure, cnn)
        Try
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            lsv.Actualizar(cmd, "Id_Cuenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Clientes_Id(ByVal Clave As String, ByVal Tipo As Char) As DataTable
        'Aqui se crea el command
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesClave_Read", CommandType.StoredProcedure, Crea_ConexionSTD())
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave.Trim)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.VarChar, SucursalId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.VarChar, Tipo)

        'Aqui se vacia el resultado en una tabla
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clientes_CajBancaria_Proceso(ByVal Id_Cliente As Integer) As DataTable
        'Aqui se crea el command
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_ExisteProceso", CommandType.StoredProcedure, Crea_ConexionSTD())
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clientes_Generales(ByVal Id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_Read2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
        If Tbl IsNot Nothing AndAlso Tbl.Rows.Count > 0 Then
            Return Tbl.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function fn_Clientes_Lugar(ByVal Zona As Integer) As DataRow
        Dim Cmd As SqlCommand = Crea_Comando("Cat_PaisesZona_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Zona", SqlDbType.Int, Zona)

        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(Cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_BuscarLugar(ByVal CP_F As String) As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Buscar_Lugar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@CodigoPostal", SqlDbType.VarChar, CP_F)

        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(Cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_BuscarDatosColonia(ByVal CodigoPostal As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Buscar_DatosColonia", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.VarChar, CodigoPostal)
        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_BuscarCiudades(ByVal idEstado As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("buscarCiudades", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@idEstado", SqlDbType.Int, idEstado)
        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_Clientes_Guardar(ByVal IdCliente As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Fiscal As String,
                                               ByVal Calle_Fiscal As String, ByVal Numero_Fiscal As Integer,
                                               ByVal NumeroInt_Fiscal As String, ByVal Colonia_Fiscal As String,
                                               ByVal CP_Fiscal As Integer, ByVal Zona_Fiscal As Integer, ByVal RFC As String,
                                               ByVal Nombre_Comercial As String, ByVal Calle_Comercial As String,
                                               ByVal Numero_Comercial As Integer, ByVal NumeroInt_Comercial As String,
                                               ByVal Zona_Comercial As Integer,
                                               ByVal Colonia_Comercial As String, ByVal CP_Comercial As Integer,
                                               ByVal Id_Giro As Integer,
                                               ByVal Id_Categoria As Integer, ByVal Clave_Radio As String,
                                               ByVal Local_Foraneo As Char, ByVal Id_Padre As Integer,
                                               ByVal Latitud As Decimal, ByVal Longitud As Decimal, ByVal Id_Ciudad As Integer,
                                               ByVal RequiereMaterial As String, ByVal MensajeAlerta As String,
                                               ByVal Tipo_Cliente As String, ByVal Fecha_InicioOperaciones As Date,
                                               ByVal EntreCalle_Fiscal1 As String,
                                               ByVal EntreCalle_Fiscal2 As String, ByVal EntreCalle_Comercial1 As String,
                                               ByVal EntreCalle_Comercial2 As String, ByVal Nombre_Corto As String,
                                               ByVal Clave_Facturacion As String, ByVal Cliente_Padre As Boolean,
                                               ByVal Utiliza_Caset As String,
                                               ByRef EscasetPropio As String,
                                               ByRef UtilizaCatalogoDigital As String,
                                               ByVal Id_CFDI As Integer,
                                               ByVal COMPAQ_Codigo As String,
                                               ByVal UtilizaRemision As String,
                                               ByVal KM_CFDI As Decimal,
                                               ByVal ComprobanteUUID As String,
                                               ByVal UsarUUID As Int32,
                                               ByVal Categoria As String,
                                               ByVal UsoCFDI As String,
                                               ByVal Adenda_Nombre As String,
                                               ByVal Adenda_Proveedor As String,
                                               ByVal Adenda_Pedido As String,
                                               ByVal CONTPAQ_Direccion_Cliente As String,
                                               ByVal Regimen As String,
                                               ByVal EnviarCorreo As String,
                                               ByVal Correo As String,
                                               ByVal Id_ClienteGrupo As Integer,
                                               ByVal Id_ClienteGrupoD As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Clientes_Update")

        Try
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, IdCliente)
            Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
            Crea_Parametro(cmd, "@COMPAQ_Codigo", SqlDbType.VarChar, COMPAQ_Codigo)
            Crea_Parametro(cmd, "@Nombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
            Crea_Parametro(cmd, "@Calle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
            Crea_Parametro(cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
            Crea_Parametro(cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
            Crea_Parametro(cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
            Crea_Parametro(cmd, "@CP_Fiscal", SqlDbType.Int, CP_Fiscal)
            Crea_Parametro(cmd, "@Zona_Fiscal", SqlDbType.Int, Zona_Fiscal)
            Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
            Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
            Crea_Parametro(cmd, "@Calle_Comercial", SqlDbType.VarChar, Calle_Comercial)
            Crea_Parametro(cmd, "@Numero_Comercial", SqlDbType.Int, Numero_Comercial)
            Crea_Parametro(cmd, "@NumeroInt_Comercial", SqlDbType.VarChar, NumeroInt_Comercial)
            Crea_Parametro(cmd, "@Colonia_Comercial", SqlDbType.VarChar, Colonia_Comercial)
            Crea_Parametro(cmd, "@CP_Comercial", SqlDbType.Int, CP_Comercial)
            Crea_Parametro(cmd, "@Zona_Comercial", SqlDbType.Int, Zona_Comercial)
            Crea_Parametro(cmd, "@Id_Giro", SqlDbType.Int, Id_Giro)
            Crea_Parametro(cmd, "@Id_Categoria", SqlDbType.Int, Id_Categoria)
            Crea_Parametro(cmd, "@Clave_Radio", SqlDbType.VarChar, Clave_Radio)
            Crea_Parametro(cmd, "@Local_Foraneo", SqlDbType.VarChar, Local_Foraneo)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, Latitud)
            Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, Longitud)
            Crea_Parametro(cmd, "@KM_CFDI", SqlDbType.Decimal, KM_CFDI)
            Crea_Parametro(cmd, "@RequiereMaterial", SqlDbType.VarChar, RequiereMaterial)
            Crea_Parametro(cmd, "@MensajeAlerta", SqlDbType.Text, MensajeAlerta)
            Crea_Parametro(cmd, "@Tipo_Cliente", SqlDbType.VarChar, Tipo_Cliente)
            Crea_Parametro(cmd, "@Fecha_InicioOperaciones", SqlDbType.Date, Fecha_InicioOperaciones)
            Crea_Parametro(cmd, "@EntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
            Crea_Parametro(cmd, "@EntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
            Crea_Parametro(cmd, "@EntreCalle_Comercial1", SqlDbType.VarChar, EntreCalle_Comercial1)
            Crea_Parametro(cmd, "@EntreCalle_Comercial2", SqlDbType.VarChar, EntreCalle_Comercial2)
            Crea_Parametro(cmd, "@Nombre_Corto", SqlDbType.VarChar, Nombre_Corto)
            Crea_Parametro(cmd, "@Utiliza_Caset", SqlDbType.VarChar, Utiliza_Caset)
            Crea_Parametro(cmd, "@UtilizaRemision", SqlDbType.VarChar, UtilizaRemision)
            Crea_Parametro(cmd, "@EnviarCorreo", SqlDbType.VarChar, EnviarCorreo)
            Crea_Parametro(cmd, "@Correo", SqlDbType.VarChar, Correo)

            If Clave_Facturacion <> "" Then Crea_Parametro(cmd, "@Clave_Facturacion", SqlDbType.VarChar, Clave_Facturacion)
            If Cliente_Padre Then
                Crea_Parametro(cmd, "@Cliente_Padre", SqlDbType.VarChar, "S")
            Else
                Crea_Parametro(cmd, "@Cliente_Padre", SqlDbType.VarChar, "N")
            End If

            Crea_Parametro(cmd, "@CasetPropio", SqlDbType.VarChar, EscasetPropio)
            Crea_Parametro(cmd, "@Utiliza_CatalogoDigital", SqlDbType.VarChar, UtilizaCatalogoDigital)
            Crea_Parametro(cmd, "@Id_CFDI", SqlDbType.Int, Id_CFDI)
            Crea_Parametro(cmd, "@ComprobanteUUID", SqlDbType.VarChar, ComprobanteUUID)
            Crea_Parametro(cmd, "@UsarUUID", SqlDbType.Int, UsarUUID)
            Crea_Parametro(cmd, "@Categoria", SqlDbType.VarChar, Categoria)
            Crea_Parametro(cmd, "@UsoCFDI", SqlDbType.VarChar, UsoCFDI)
            Crea_Parametro(cmd, "@Adenda_Nombre", SqlDbType.VarChar, Adenda_Nombre)
            Crea_Parametro(cmd, "@Adenda_Proveedor", SqlDbType.VarChar, Adenda_Proveedor)
            Crea_Parametro(cmd, "@Adenda_Pedido", SqlDbType.VarChar, Adenda_Pedido)
            Crea_Parametro(cmd, "@CONTPAQ_Direccion_Cliente", SqlDbType.VarChar, CONTPAQ_Direccion_Cliente)
            Crea_Parametro(cmd, "@Regimen", SqlDbType.VarChar, Regimen)
            ' Crea_Parametro(cmd, "@Tipo_Proceso", SqlDbType.VarChar, IIf(Tipo_Proceso = "SIN TIPO PROCESO", "", Tipo_Proceso))

            Dim id As Integer = EjecutarNonQueryT(cmd)

            'If Afectar_Subclientes Then
            '    cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Clientes_UpdateHijos")
            '    If lsv_Subclientes IsNot Nothing Then
            '        For Each Elemento As ListViewItem In lsv_Subclientes.Items
            '            If Elemento.SubItems(4).Text = "S" Then
            '                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
            '                Crea_Parametro(cmd, "@Nombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
            '                Crea_Parametro(cmd, "@Calle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
            '                Crea_Parametro(cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
            '                Crea_Parametro(cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
            '                Crea_Parametro(cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
            '                Crea_Parametro(cmd, "@CP_Fiscal", SqlDbType.Int, CP_Fiscal)
            '                Crea_Parametro(cmd, "@Zona_Fiscal", SqlDbType.Int, Zona_Fiscal)
            '                Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
            '                Crea_Parametro(cmd, "@EntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
            '                Crea_Parametro(cmd, "@EntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
            '                id = EjecutarNonQueryT(cmd)
            '                cmd.Parameters.Clear()
            '            End If
            '        Next
            '    End If
            'End If



            '---------------------------------Modificado Morado 10/12/2022----------------------------------
            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesGruposD_Delete")
            Crea_Parametro(cmd, "@Id_ClienteGrupoD", SqlDbType.Int, Id_ClienteGrupoD)

            EjecutarNonQueryT(cmd)
            '-----------------------------------------------------------------------------------------------

            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesGruposD_Create")
            Crea_Parametro(cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, IdCliente)

            EjecutarNonQueryT(cmd)
            '-----------------------------------------------------------------------------------------------



            'Actualizar valores también en la tabla clientes procesos (se guarda como cuando se crea un cliente proceso)
            Dim Direccion_Comercial As String = Calle_Comercial & " " & Numero_Comercial & " " & NumeroInt_Comercial & ", " & Colonia_Comercial

            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesProceso_UpdateName")
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, IdCliente)
            Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
            Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
            Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)

            EjecutarNonQueryT(cmd)
            'If Afectar_SubClietes Then
            '    cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Tipo_Porceso_Subclientes")
            '    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, IdCliente)
            '    Crea_Parametro(cmd, "@Tipo_Proceso", SqlDbType.VarChar, IIf(Tipo_Proceso = "SIN CATEGORIA", "", Tipo_Proceso))
            '    EjecutarNonQueryT(cmd)
            'End If
            If id > 0 Then
                Tr.Commit()
                Cnn.Close()
                Return True
            Else
                Tr.Rollback()
                Cnn.Close()
                Return True
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ContactosEnlace_Crear(ByVal Id_Contacto As Integer, ByVal Id_Cliente As Integer, ByVal TipoContacto As Integer, ByVal Nombre As String, ByVal Departamento As String, ByVal Puesto As String,
                                                    ByVal Fecha_Nacimiento As Date, ByVal EstadoCivil As Integer, ByVal Comentarios As String, ByVal Telefono_Oficina As String, ByVal Telefono_Casa As String, ByVal Telefono_Celular As String,
                                                    ByVal Telefono_Otro As String, ByVal Fax As String, ByVal Mail As String, ByVal Afectar_Subclientes As Boolean, ByRef lsv As cp_Listview, ByVal rfc As String, ByVal calle As String, ByVal Entrecalle1 As String,
                                              ByVal entrecalle2 As String, ByVal numeroExterior As String, ByVal numeroInterior As String, ByVal colonia As String,
                                              ByVal IdCiudad As Integer, ByVal IdEstado As Integer) As Boolean

        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactosEnlace_Create")
            Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Dim Creado As Integer = EjecutarNonQueryT(cmd)

            cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactos_Update")
            Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
            Crea_Parametro(cmd, "@Tipo_Contacto", SqlDbType.TinyInt, TipoContacto)
            Crea_Parametro(cmd, "@Nombre_Contacto", SqlDbType.VarChar, Nombre)
            Crea_Parametro(cmd, "@Departamento", SqlDbType.VarChar, Departamento)
            Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
            Crea_Parametro(cmd, "@Fecha_Nacimiento", SqlDbType.DateTime, Fecha_Nacimiento)
            Crea_Parametro(cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Crea_Parametro(cmd, "@Telefono_Oficina", SqlDbType.VarChar, Telefono_Oficina)
            Crea_Parametro(cmd, "@Telefono_Casa", SqlDbType.VarChar, Telefono_Casa)
            Crea_Parametro(cmd, "@Telefono_Celular", SqlDbType.VarChar, Telefono_Celular)
            Crea_Parametro(cmd, "@Telefono_Otro", SqlDbType.VarChar, Telefono_Otro)
            Crea_Parametro(cmd, "@Fax", SqlDbType.VarChar, Fax)
            Crea_Parametro(cmd, "@Mail", SqlDbType.VarChar, Mail)

            Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, rfc)
            Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, calle)
            Crea_Parametro(cmd, "@Entre_Calle1", SqlDbType.VarChar, Entrecalle1)
            Crea_Parametro(cmd, "@Entre_Calle2", SqlDbType.VarChar, entrecalle2)
            Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, numeroExterior)
            Crea_Parametro(cmd, "@Numero_Int", SqlDbType.VarChar, numeroInterior)
            Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, colonia)
            Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, IdCiudad)
            Crea_Parametro(cmd, "@Id_Estado", SqlDbType.Int, IdEstado)
            EjecutarNonQueryT(cmd)

            If Afectar_Subclientes Then
                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactosEnlace_Create")
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" Then
                        Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                        Creado = EjecutarNonQueryT(cmd)
                        cmd.Parameters.Clear()
                    End If
                Next
            End If

            If Creado > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contactos_Crear(ByVal Id_Cliente As Integer, ByVal TipoContacto As Integer, ByVal Nombre As String, ByVal Departamento As String,
                                              ByVal Puesto As String, ByVal Fecha_Nacimiento As Date, ByVal EstadoCivil As Integer, ByVal Comentarios As String,
                                              ByVal Telefono_Oficina As String, ByVal Telefono_Casa As String, ByVal Telefono_Celular As String,
                                              ByVal Telefono_Otro As String, ByVal Fax As String, ByVal Mail As String,
                                              ByVal Afectar_Subclientes As Boolean, ByRef lsv As cp_Listview, ByVal rfc As String, ByVal calle As String, ByVal Entrecalle1 As String,
                                              ByVal entrecalle2 As String, ByVal numeroExterior As String, ByVal numeroInterior As String, ByVal colonia As String,
                                              ByVal IdCiudad As Integer, ByVal IdEstado As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactos_Create")
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Tipo_Contacto", SqlDbType.TinyInt, TipoContacto)
            Crea_Parametro(cmd, "@Nombre_Contacto", SqlDbType.VarChar, Nombre)
            Crea_Parametro(cmd, "@Departamento", SqlDbType.VarChar, Departamento)
            Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
            Crea_Parametro(cmd, "@Fecha_Nacimiento", SqlDbType.DateTime, Fecha_Nacimiento)
            Crea_Parametro(cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Telefono_Oficina", SqlDbType.VarChar, Telefono_Oficina)
            Crea_Parametro(cmd, "@Telefono_Casa", SqlDbType.VarChar, Telefono_Casa)
            Crea_Parametro(cmd, "@Telefono_Celular", SqlDbType.VarChar, Telefono_Celular)
            Crea_Parametro(cmd, "@Telefono_Otro", SqlDbType.VarChar, Telefono_Otro)
            Crea_Parametro(cmd, "@Fax", SqlDbType.VarChar, Fax)
            Crea_Parametro(cmd, "@Mail", SqlDbType.VarChar, Mail)

            Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, rfc)
            Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, calle)
            Crea_Parametro(cmd, "@Entre_Calle1", SqlDbType.VarChar, Entrecalle1)
            Crea_Parametro(cmd, "@Entre_Calle2", SqlDbType.VarChar, entrecalle2)
            Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, numeroExterior)
            Crea_Parametro(cmd, "@Numero_Int", SqlDbType.VarChar, numeroInterior)
            Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, colonia)
            Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, IdCiudad)
            Crea_Parametro(cmd, "@Id_Estado", SqlDbType.Int, IdEstado)

            Dim Id_Contacto As Integer = EjecutarScalarT(cmd)

            If Afectar_Subclientes Then
                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactosEnlace_Create")
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" Then
                        Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                        EjecutarNonQueryT(cmd)
                        cmd.Parameters.Clear()
                    End If
                Next
            End If

            If Id_Contacto > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contactos_Actualizar(ByVal Id_Contacto As Integer, ByVal TipoContacto As Integer, ByVal Nombre As String,
                                              ByVal Departamento As String, ByVal Puesto As String, ByVal Fecha_Nacimiento As Date,
                                              ByVal EstadoCivil As Integer, ByVal Comentarios As String, ByVal Telefono_Oficina As String, ByVal Telefono_Casa As String,
                                              ByVal Telefono_Celular As String, ByVal Telefono_Otro As String, ByVal Fax As String, ByVal Mail As String, ByVal rfc As String, ByVal calle As String, ByVal Entrecalle1 As String,
                                              ByVal entrecalle2 As String, ByVal numeroExterior As String, ByVal numeroInterior As String, ByVal colonia As String,
                                              ByVal IdCiudad As Integer, ByVal IdEstado As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesContactos_Update", CommandType.StoredProcedure, cnn)
        Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
        Crea_Parametro(cmd, "@Tipo_Contacto", SqlDbType.TinyInt, TipoContacto)
        Crea_Parametro(cmd, "@Nombre_Contacto", SqlDbType.VarChar, Nombre)
        Crea_Parametro(cmd, "@Departamento", SqlDbType.VarChar, Departamento)
        Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
        Crea_Parametro(cmd, "@Fecha_Nacimiento", SqlDbType.DateTime, Fecha_Nacimiento)
        Crea_Parametro(cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Crea_Parametro(cmd, "@Telefono_Oficina", SqlDbType.VarChar, Telefono_Oficina)
        Crea_Parametro(cmd, "@Telefono_Casa", SqlDbType.VarChar, Telefono_Casa)
        Crea_Parametro(cmd, "@Telefono_Celular", SqlDbType.VarChar, Telefono_Celular)
        Crea_Parametro(cmd, "@Telefono_Otro", SqlDbType.VarChar, Telefono_Otro)
        Crea_Parametro(cmd, "@Fax", SqlDbType.VarChar, Fax)
        Crea_Parametro(cmd, "@Mail", SqlDbType.VarChar, Mail)

        Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, rfc)
        Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, calle)
        Crea_Parametro(cmd, "@Entre_Calle1", SqlDbType.VarChar, Entrecalle1)
        Crea_Parametro(cmd, "@Entre_Calle2", SqlDbType.VarChar, entrecalle2)
        Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, numeroExterior)
        Crea_Parametro(cmd, "@Numero_Int", SqlDbType.VarChar, numeroInterior)
        Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, colonia)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, IdCiudad)
        Crea_Parametro(cmd, "@Id_Estado", SqlDbType.Int, IdEstado)

        Try
            Dim Modificado As Integer = EjecutarNonQuery(cmd)
            If Modificado > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contactos_AltaBaja(ByVal Id_ContactoCliente As Integer, ByVal Id_Contacto As Integer, ByVal Status As String, ByVal Afectar_SubClientes As Boolean, ByVal lsv As cp_Listview) As Boolean
        Dim Modificados As Integer = 0
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)

        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactosEnlace_Status")
            Crea_Parametro(cmd, "@Id_ContactoCliente", SqlDbType.Int, Id_ContactoCliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Modificados = EjecutarNonQueryT(cmd)

            If Afectar_SubClientes Then
                'Obtener los Id_ContactoCliente según el Id_Contacto
                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactosEnlace_Read")
                Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                Dim Dt_ContactoCliente As DataTable = EjecutaConsultaT(cmd)
                Dim Todos As Integer = 0

                If Dt_ContactoCliente IsNot Nothing AndAlso Dt_ContactoCliente.Rows.Count > 0 Then
                    cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactosEnlace_Status")
                    For Each Row As DataRow In Dt_ContactoCliente.Rows
                        For Each Elemento As ListViewItem In lsv.Items
                            If Elemento.SubItems(4).Text = "S" AndAlso Elemento.Tag = Row("Id_Cliente") Then
                                Crea_Parametro(cmd, "@Id_ContactoCliente", SqlDbType.Int, Row("Id_ContactoCliente"))
                                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
                                Modificados = EjecutarNonQueryT(cmd)
                                cmd.Parameters.Clear()
                                Todos += 1
                                Exit For
                            End If
                        Next
                    Next
                    If Todos = lsv.Items.Count Then
                        Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesContactos_Status")
                        Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
                        Modificados = EjecutarNonQueryT(cmd)
                    End If
                End If
            End If

            If Modificados > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    'Public Shared Function fn_Contactos_Leer(ByVal Id_Contacto) As DataRow
    '    Try
    '        Dim cnn As SqlConnection = Crea_ConexionSTD()
    '        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesContactos_Read", CommandType.StoredProcedure, cnn)
    '        Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)

    '        Dim Dt As DataTable = EjecutaConsulta(cmd)
    '        If Dt IsNot Nothing AndAlso Dt.Rows.Count > 0 Then
    '            Return Dt.Rows(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    Public Shared Function fn_Admin_Actualizar(ByVal IdCliente As Integer, ByVal ClienteF As Integer, ByVal clienteC As Integer,
                                               ByVal EjecutivoC As Integer, ByVal Retiene As Char, ByVal Agrupa As Char, ByVal Descuento As Char, ByVal TipoD As Char,
                                               ByVal CanitdadD As Decimal, ByVal ComparteF As Char, ByVal TipoC As Char, ByVal CantidadC As Decimal,
                                               ByVal TEF As Char, ByVal Afectar_Subclientes As Boolean, ByVal lsv As cp_Listview) As Boolean
        Dim Afectados As Integer = 0
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesAdmin_Update")
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, IdCliente)
        Crea_Parametro(cmd, "@Cliente_Facturar", SqlDbType.Int, ClienteF)
        Crea_Parametro(cmd, "@Cliente_Contra", SqlDbType.Int, clienteC)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Ejecutivo_Contrato", SqlDbType.Int, EjecutivoC)
        Crea_Parametro(cmd, "@Vence_Contrato", SqlDbType.DateTime, Today)
        Crea_Parametro(cmd, "@Retiene_IVA", SqlDbType.VarChar, Retiene)
        Crea_Parametro(cmd, "@Agrupa_Facturas", SqlDbType.VarChar, Agrupa)
        Crea_Parametro(cmd, "@Tiene_Descuento", SqlDbType.VarChar, Descuento)
        Crea_Parametro(cmd, "@Tipo_Descuento", SqlDbType.VarChar, TipoD)
        Crea_Parametro(cmd, "@Cantidad_Descuento", SqlDbType.Money, CanitdadD)
        Crea_Parametro(cmd, "@Comparte_Facturacion", SqlDbType.VarChar, ComparteF)
        Crea_Parametro(cmd, "@Tipo_Comparte", SqlDbType.VarChar, TipoC)
        Crea_Parametro(cmd, "@Cantidad_Comparte", SqlDbType.Money, CantidadC)
        Crea_Parametro(cmd, "@Paga_TEF", SqlDbType.VarChar, TEF)

        Try
            Afectados = EjecutarNonQueryT(cmd)

            If Afectados = 0 Then
                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesAdmin_Create")
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, IdCliente)
                Crea_Parametro(cmd, "@Cliente_Facturar", SqlDbType.Int, ClienteF)
                Crea_Parametro(cmd, "@Cliente_Contra", SqlDbType.Int, clienteC)
                Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, "")
                Crea_Parametro(cmd, "@Ejecutivo_Contrato", SqlDbType.Int, EjecutivoC)
                Crea_Parametro(cmd, "@Vence_Contrato", SqlDbType.DateTime, Today)
                Crea_Parametro(cmd, "@Retiene_IVA", SqlDbType.VarChar, Retiene)
                Crea_Parametro(cmd, "@Agrupa_Facturas", SqlDbType.VarChar, Agrupa)
                Crea_Parametro(cmd, "@Tiene_Descuento", SqlDbType.VarChar, Descuento)
                Crea_Parametro(cmd, "@Tipo_Descuento", SqlDbType.VarChar, TipoD)
                Crea_Parametro(cmd, "@Cantidad_Descuento", SqlDbType.Money, CanitdadD)
                Crea_Parametro(cmd, "@Comparte_Facturacion", SqlDbType.VarChar, ComparteF)
                Crea_Parametro(cmd, "@Tipo_Comparte", SqlDbType.VarChar, TipoC)
                Crea_Parametro(cmd, "@Cantidad_Comparte", SqlDbType.Money, CantidadC)
                Crea_Parametro(cmd, "@Paga_TEF", SqlDbType.VarChar, TEF)
                Afectados = EjecutarNonQueryT(cmd)
            End If

            If Afectar_Subclientes Then
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" Then
                        Afectados = 0
                        cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesAdmin_Update")
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Crea_Parametro(cmd, "@Cliente_Facturar", SqlDbType.Int, ClienteF)
                        Crea_Parametro(cmd, "@Cliente_Contra", SqlDbType.Int, clienteC)
                        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, "")
                        Crea_Parametro(cmd, "@Ejecutivo_Contrato", SqlDbType.Int, EjecutivoC)
                        Crea_Parametro(cmd, "@Vence_Contrato", SqlDbType.DateTime, Today)
                        Crea_Parametro(cmd, "@Retiene_IVA", SqlDbType.VarChar, Retiene)
                        Crea_Parametro(cmd, "@Agrupa_Facturas", SqlDbType.VarChar, Agrupa)
                        Crea_Parametro(cmd, "@Tiene_Descuento", SqlDbType.VarChar, Descuento)
                        Crea_Parametro(cmd, "@Tipo_Descuento", SqlDbType.VarChar, TipoD)
                        Crea_Parametro(cmd, "@Cantidad_Descuento", SqlDbType.Money, CanitdadD)
                        Crea_Parametro(cmd, "@Comparte_Facturacion", SqlDbType.VarChar, ComparteF)
                        Crea_Parametro(cmd, "@Tipo_Comparte", SqlDbType.VarChar, TipoC)
                        Crea_Parametro(cmd, "@Cantidad_Comparte", SqlDbType.Money, CantidadC)
                        Crea_Parametro(cmd, "@Paga_TEF", SqlDbType.VarChar, TEF)
                        Afectados = EjecutarNonQueryT(cmd)

                        If Afectados = 0 Then
                            cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesAdmin_Create")
                            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                            Crea_Parametro(cmd, "@Cliente_Facturar", SqlDbType.Int, ClienteF)
                            Crea_Parametro(cmd, "@Cliente_Contra", SqlDbType.Int, clienteC)
                            Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, "")
                            Crea_Parametro(cmd, "@Ejecutivo_Contrato", SqlDbType.Int, EjecutivoC)
                            Crea_Parametro(cmd, "@Vence_Contrato", SqlDbType.DateTime, Today)
                            Crea_Parametro(cmd, "@Retiene_IVA", SqlDbType.VarChar, Retiene)
                            Crea_Parametro(cmd, "@Agrupa_Facturas", SqlDbType.VarChar, Agrupa)
                            Crea_Parametro(cmd, "@Tiene_Descuento", SqlDbType.VarChar, Descuento)
                            Crea_Parametro(cmd, "@Tipo_Descuento", SqlDbType.VarChar, TipoD)
                            Crea_Parametro(cmd, "@Cantidad_Descuento", SqlDbType.Money, CanitdadD)
                            Crea_Parametro(cmd, "@Comparte_Facturacion", SqlDbType.VarChar, ComparteF)
                            Crea_Parametro(cmd, "@Tipo_Comparte", SqlDbType.VarChar, TipoC)
                            Crea_Parametro(cmd, "@Cantidad_Comparte", SqlDbType.Money, CantidadC)
                            Crea_Parametro(cmd, "@Paga_TEF", SqlDbType.VarChar, TEF)
                            Afectados = EjecutarNonQueryT(cmd)
                        End If
                    End If
                Next
            End If

            If Afectados > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Crear(ByVal Id_Cliente As Integer, ByVal Fecha_Inicio As Date, ByVal Comentarios As String,
                                              ByVal Id_Precio As Integer, ByVal Id_CR As Integer,
                                              ByVal Id_EE As Integer, ByVal Id_KM As Integer, ByVal Cobro_Unico As Char,
                                              ByVal Tv_Predeterminado As Char, ByVal Recoleccion As Char,
                                              ByVal Entrega_Dotaciones As Char,
                                              ByVal Cantidad_Kilometros As Integer,
                                              ByVal Id_PrecioDescripcion As Integer,
                                              ByVal Afectar_Subclientes As Boolean,
                                              ByVal EsExtraordinario As Char,
                                              ByVal lsv As cp_Listview,
                                              Optional ByVal Id_Concepto As Integer = 0,
                                              Optional ByVal Id_Material As Integer = 0) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesServicios_Create")
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
        Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
        Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Id_CR)
        Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Id_EE)
        Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Id_KM)
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Cobro_Unico)
        Crea_Parametro(cmd, "@Cobrado", SqlDbType.VarChar, "N")
        Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Tv_Predeterminado)
        Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Recoleccion)
        Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Entrega_Dotaciones)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Cantidad_Kilometros)
        Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
        Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)
        Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Id_Material)
        Crea_Parametro(cmd, "@EsExtraordinario", SqlDbType.VarChar, EsExtraordinario)
        Try
            'Guardar el Servicio en el Padre
            Dim id As Integer = EjecutarNonQueryT(cmd)
            'Guardar el Servicio en los Hijos
            If Afectar_Subclientes Then
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" Then
                        cmd.Parameters.Clear()
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
                        Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
                        Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                        Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                        Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                        Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Cobro_Unico)
                        Crea_Parametro(cmd, "@Cobrado", SqlDbType.VarChar, "N")
                        Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Tv_Predeterminado)
                        Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Recoleccion)
                        Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Entrega_Dotaciones)
                        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                        Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Cantidad_Kilometros)
                        Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
                        Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)
                        Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Id_Material)
                        id = EjecutarNonQueryT(cmd)
                    End If
                Next
            End If

            If id > 0 Then
                Tr.Commit()
                Cnn.Close()
                cmd.Dispose()
                Return True
            Else
                Tr.Rollback()
                Cnn.Close()
                cmd.Dispose()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Actualizar(ByVal Id_CS As Integer, ByVal Fecha_Inicio As Date, ByVal Comentarios As String,
                                                   ByVal Id_Precio As Integer,
                                                   ByVal Id_CR As Integer, ByVal Id_EE As Integer,
                                                   ByVal Id_KM As Integer, ByVal Cobro_Unico As Char,
                                                   ByVal Tv_Predeterminado As Char,
                                                   ByVal Recoleccion As Char,
                                                   ByVal Entrega_Dotaciones As Char,
                                                   ByVal Cantidad_Kilometros As Integer,
                                                   ByVal Id_PrecioDescripcion As Integer,
                                                   ByVal Afectar_Subclientes As Boolean,
                                                   ByVal lsv As cp_Listview,
                                                   ByVal EsExtraordinario As Char,
                                                   Optional ByVal Id_Concepto As Integer = 0,
                                                   Optional ByVal Id_Material As Integer = 0) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            'Actualizar los Hijos Primero porque se basan de los valores anteriores del padre
            Dim Res As Integer = 0
            If Afectar_Subclientes Then
                Dim Id_CS_SubClientes() As String

                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" AndAlso Elemento.SubItems(5).Text <> "" Then
                        'Obtener los Id_CS que se afectaran
                        Id_CS_SubClientes = Split(Elemento.SubItems(5).Text, ",")

                        For Item As Integer = 0 To Id_CS_SubClientes.Length - 1
                            If Id_CS_SubClientes(Item) = "" Then Continue For

                            cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_Update")
                            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS_SubClientes(Item))
                            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
                            Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
                            Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                            Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                            Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                            Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                            Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Cobro_Unico)
                            Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Tv_Predeterminado)
                            Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Recoleccion)
                            Crea_Parametro(cmd, "@EsExtraordinario", SqlDbType.VarChar, EsExtraordinario)
                            Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Entrega_Dotaciones)
                            Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Cantidad_Kilometros)
                            Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
                            Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)
                            Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Id_Material)
                            Res = EjecutarNonQueryT(cmd)

                            If Res = 0 Then
                                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_Create")
                                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                                Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
                                Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
                                Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                                Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                                Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                                Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                                Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                                Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Cobro_Unico)
                                Crea_Parametro(cmd, "@Cobrado", SqlDbType.VarChar, "N")
                                Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Tv_Predeterminado)
                                Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Recoleccion)
                                Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Entrega_Dotaciones)
                                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                                Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Cantidad_Kilometros)
                                Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
                                Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)
                                Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Id_Material)
                                EjecutarNonQueryT(cmd)
                            End If
                        Next
                    End If
                Next
            End If

            cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_Update")
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
            Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
            Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Id_CR)
            Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Id_EE)
            Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Id_KM)
            Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Cobro_Unico)
            Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Tv_Predeterminado)
            Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Recoleccion)
            Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Entrega_Dotaciones)
            Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Cantidad_Kilometros)
            Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
            Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)
            Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Id_Material)
            Crea_Parametro(cmd, "@EsExtraordinario", SqlDbType.VarChar, EsExtraordinario)
            Res = EjecutarNonQueryT(cmd)

            If Res > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If

        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Alta(ByVal Id_CS As Integer, ByVal Id_Cliente As Integer, ByVal Afectar_SubClientes As Boolean, ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand
        Try
            Dim Modificados As Integer = 0
            If Afectar_SubClientes Then
                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_AltaHijos")
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" Then
                        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Modificados = EjecutarNonQueryT(cmd)
                        cmd.Parameters.Clear()
                    End If
                Next
            End If

            cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_Alta")
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Modificados = EjecutarNonQueryT(cmd)

            If Modificados > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Baja(ByVal Id_CS As Integer, ByVal Id_Cliente As Integer, ByVal Afectar_SubClientes As Boolean, ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand
        Try
            Dim Modificados As Integer = 0

            If Afectar_SubClientes Then
                cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_BajaHijos")
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" Then
                        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
                        Modificados = EjecutarNonQueryT(cmd)
                        cmd.Parameters.Clear()
                    End If
                Next
            End If

            cmd = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Cat_ClientesServicios_Baja")
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
            Modificados = EjecutarNonQueryT(cmd)

            If Modificados > 0 Then
                tran.Commit()
                cnn.Dispose()
                Return True
            Else
                tran.Rollback()
                cnn.Dispose()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Leer(ByVal Id_CS As Integer) As DataRow
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)

            Dim Dt As DataTable = EjecutaConsulta(cmd)
            If Dt IsNot Nothing AndAlso Dt.Rows.Count > 0 Then
                Return Dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Horarios_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorariosTemp_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id)
            lsv.Actualizar(cmd, "Id_Htemp")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Horarios_LlenarListaActivos(ByVal Id As Integer, ByVal Solo_Activos As Boolean, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorarios_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id)
            If Solo_Activos Then
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            End If
            lsv.Actualizar(cmd, "Id_CH")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Da de alta un nuevo horario de servicio
    ''' </summary>
    ''' <param name="Id_CS">Es el id del servicio</param>
    ''' <param name="Fecha_Inicio">Es la fecha en la que se inicia el servicio</param>
    ''' <param name="Tipo_Frecuencia">
    ''' Es S, Q, M dependiendo si es 
    ''' Semanal = 1 Semana
    ''' Quincenal = 2 Semanas
    ''' Mensual = 4 Semanad
    ''' </param>
    ''' <param name="Frecuencia">Es el numero del dia que se realiza el servicio</param>
    ''' <param name="Cliente_Origen">El el id del cliente de origen</param> 'verificar_hijos(sean Origen 15/05/2014)
    ''' <param name="H_Recoleccion">Es la hora de recoleccion</param>
    ''' <param name="Cliente_Destino">Es el id del cliente en donde se entrega</param>
    ''' <param name="H_Entrega">Es la hora en la que se entrega</param>
    ''' <param name="Id_Ruta">Es el Id de la ruta</param>
    ''' <param name="Escala_Boveda">S / N Indica si la ruta hace escala en la boveda</param>
    ''' <param name="Mismo_Dia">S / N Indica si se entrega el mismo dia</param>
    ''' <param name="Dia_Entrega">Es el numero de dia que se realiza la entrega dependiendo de la casilla anterior</param>
    ''' <param name="Id_RutaE">Es el id de la ruta de entrega</param>
    Public Shared Function fn_Horarios_Crear(ByVal Id_CS As Integer, ByVal Fecha_Inicio As Date, ByVal Tipo_Frecuencia As Char, ByVal Frecuencia As Char, ByVal Cliente_Origen As Integer,
                                             ByVal H_Recoleccion As String, ByVal Cliente_Destino As Integer, ByVal H_Entrega As String, ByVal Id_Ruta As Integer,
                                             ByVal Escala_Boveda As Char, ByVal Mismo_Dia As Char, ByVal Dia_Entrega As Char, ByVal Id_RutaE As Integer, ByVal Cobrar_RE As String,
                                             ByVal Cargo_ODC As Char, ByVal UnicaVez As String, ByVal Id_CH As Integer, ByVal Tipo As Integer, ByVal Prioridad As Integer,
                                             ByVal Dt_SubClientes As DataTable, Utiliza_Caset As String, NuevoOrigen As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Create")
            Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, Id_CH)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS) '
            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
            Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
            Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
            Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, Cliente_Origen) '----->2654
            Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, H_Recoleccion)
            Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, Cliente_Destino) '<---1728
            Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, H_Entrega)
            Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
            Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, Escala_Boveda)
            Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, Mismo_Dia)
            Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, Dia_Entrega)
            Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, Id_RutaE)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, Prioridad)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Cobrar_RE", SqlDbType.VarChar, Cobrar_RE)
            Crea_Parametro(cmd, "@Cargo_ODC", SqlDbType.VarChar, Cargo_ODC)
            Crea_Parametro(cmd, "@Una_Vez", SqlDbType.VarChar, UnicaVez)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Utiliza_Caset", SqlDbType.VarChar, Utiliza_Caset)
            Crea_Parametro(cmd, "@NuevoOrigenCustodia", SqlDbType.Int, NuevoOrigen)
            Dim int As Integer = EjecutarNonQueryT(cmd)

            Dim Contador As Integer = 0
            If Dt_SubClientes.Rows.Count > 0 Then
                For Each Row As DataRow In Dt_SubClientes.Rows
                    cmd.Parameters.Clear()
                    Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, 0)
                    Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Row("Id_CS")) '
                    Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
                    Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
                    Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
                    Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, Row("Id_Cliente")) 'Id_del hijo
                    Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, H_Recoleccion)
                    Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, Cliente_Destino)
                    Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, H_Entrega)
                    Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, Escala_Boveda)
                    Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, Mismo_Dia)
                    Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, Dia_Entrega)
                    Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, Id_RutaE)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, Prioridad)
                    Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                    Crea_Parametro(cmd, "@Cobrar_RE", SqlDbType.VarChar, Cobrar_RE)
                    Crea_Parametro(cmd, "@Cargo_ODC", SqlDbType.VarChar, Cargo_ODC)
                    Crea_Parametro(cmd, "@Una_Vez", SqlDbType.VarChar, UnicaVez)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    If EjecutarNonQueryT(cmd) > 0 Then Contador += 1
                Next
            End If

            If Contador = Dt_SubClientes.Rows.Count Then
                tr.Commit()
                cnn.Close()
                Return True
            Else
                tr.Rollback()
                cnn.Close()
                Return False
            End If
        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Da de alta un nuevo horario de servicio
    ''' </summary>
    ''' <param name="Id">Es el id del registro que se va a actualizar</param>
    ''' <param name="Fecha_Inicio">Es la fecha en la que se inicia el servicio</param>
    ''' <param name="Tipo_Frecuencia">
    ''' Es S, Q, M dependiendo si es 
    ''' Semanal = 1 Semana
    ''' Quincenal = 2 Semanas
    ''' Mensual = 4 Semanad
    ''' </param>
    ''' <param name="Frecuencia">Es el numero del dia que se realiza el servicio</param>
    ''' <param name="Cliente_Origen">El el id del cliente de origen</param>
    ''' <param name="H_Recoleccion">Es la hora de recoleccion</param>
    ''' <param name="Cliente_Destino">Es el id del cliente en donde se entrega</param>
    ''' <param name="H_Entrega">Es la hora en la que se entrega</param>
    ''' <param name="Id_Ruta">Es el Id de la ruta</param>
    ''' <param name="Escala_Boveda">S / N Indica si la ruta hace escala en la boveda</param>
    ''' <param name="Mismo_Dia">S / N Indica si se entrega el mismo dia</param>
    ''' <param name="Dia_Entrega">Es el numero de dia que se realiza la entrega dependiendo de la casilla anterior</param>
    ''' <param name="Id_RutaE">Es el id de la ruta de entrega</param>
    Public Shared Function fn_Horarios_Actualizar(ByVal Id As Integer, ByVal Fecha_Inicio As Date, ByVal Tipo_Frecuencia As Char, ByVal Frecuencia As Char,
                                                  ByVal Cliente_Origen As Integer, ByVal H_Recoleccion As String, ByVal Cliente_Destino As Integer,
                                                  ByVal H_Entrega As String, ByVal Id_Ruta As Integer, ByVal Escala_Boveda As Char, ByVal Mismo_Dia As Char,
                                                  ByVal Dia_Entrega As Char, ByVal Id_RutaE As Integer, ByVal Tipo As Integer, ByVal Dt_Subclientes As DataTable,
                                                  ByVal FrecuenciaAnterior As Char, Utiliza_Caset As String, NuevoOrigen As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorariosTemp_Update", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, Id)
            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
            Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
            Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
            Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, Cliente_Origen)
            Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, H_Recoleccion)
            Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, Cliente_Destino)
            Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, H_Entrega)
            Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
            Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, Escala_Boveda)
            Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, Mismo_Dia)
            Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, Dia_Entrega)
            Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, Id_RutaE)
            Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, 0)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Utiliza_Caset", SqlDbType.VarChar, Utiliza_Caset)
            Crea_Parametro(cmd, "@NuevoOrigenCustodia", SqlDbType.Int, NuevoOrigen)
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Horarios_CrearVarios(ByVal Fecha_Inicio As Date, ByVal Cliente As Integer, ByVal Origen As Boolean,
                                                   ByVal Tipo_Frecuencia As Char, ByVal Cobrar_RE As String, ByVal Cargo_ODC As Char,
                                                   ByVal UnicaVez As String, ByVal Dt_Datos As DataTable,
                                                   ByVal lsv_ClientesAfectar As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Try
            Dim Contador As Integer = 0
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Create")
            For Each Cli As ListViewItem In lsv_ClientesAfectar.CheckedItems
                For Each Fila As DataRow In Dt_Datos.Rows
                    cmd.Parameters.Clear()
                    Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, 0)
                    Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Cli.Tag)
                    Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, Fecha_Inicio)
                    Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
                    Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Fila("Frecuencia"))
                    If Origen Then
                        Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, Cliente)
                        Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, Cli.SubItems(6).Text) 'Id_Cliente
                    Else
                        Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, Cli.SubItems(6).Text) 'Id_Cliente
                        Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, Cliente)
                    End If
                    Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, Fila("H_Recoleccion"))
                    Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, Fila("H_Entrega"))
                    Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, Fila("Id_RutaF"))
                    Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, Fila("Escala_Boveda"))
                    Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, Fila("Mismo_Dia"))
                    Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, Fila("Dia_Entrega"))
                    Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, Fila("Id_RutaE"))
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, 0)
                    Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 1)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                    Crea_Parametro(cmd, "@Cobrar_RE", SqlDbType.VarChar, Cobrar_RE)
                    Crea_Parametro(cmd, "@Cargo_ODC", SqlDbType.VarChar, Cargo_ODC)
                    Crea_Parametro(cmd, "@Una_Vez", SqlDbType.VarChar, UnicaVez)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    If EjecutarNonQueryT(cmd) > 0 Then Contador += 1
                Next
            Next

            If Contador = (lsv_ClientesAfectar.CheckedItems.Count * Dt_Datos.Rows.Count) Then
                tr.Commit()
                cnn.Close()
                Return True
            Else
                tr.Rollback()
                cnn.Close()
                Return False
            End If
        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_LlenarListaHorarios(ByVal Id_Padre As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetHijos", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Horarios_Leer(ByVal Id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorariosTemp_read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, Id)
        Try
            Dim Dt_HorariosTemp As DataTable = EjecutaConsulta(cmd)
            If Dt_HorariosTemp IsNot Nothing AndAlso Dt_HorariosTemp.Rows.Count > 0 Then
                Return Dt_HorariosTemp.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Horarios_Leer2(ByVal Id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorarios_read2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, Id)

        Try
            Dim Dt_ClientesHorarios As DataTable = EjecutaConsulta(cmd)
            If Dt_ClientesHorarios IsNot Nothing AndAlso Dt_ClientesHorarios.Rows.Count > 0 Then
                Return Dt_ClientesHorarios.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Obtiene todos Hijos de un cliente
    ''' </summary>
    ''' <param name="Id_CS">Es el servicio</param>
    ''' <returns>Devuelve un Datatable con todos los servicios y Clientes</returns>
    Public Shared Function fn_Horarios_Hijos(ByVal Id_CS As Integer) As DataRowCollection
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServiciosHijos_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)

        Try
            Return EjecutaConsulta(cmd).Rows
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Crea una nueva transferencia
    ''' </summary>
    ''' <param name="Id_Cliente">Es el id de Cat_Clientes</param>
    ''' <param name="Id_CuentaPago">Es el Id de Cat_SucursalesCuentas</param>
    ''' <param name="Referencia">Es el numero de referencia</param>
    ''' <param name="Observaciones">Son los comentarios</param>
    ''' <returns>Devuelve true si se inserta una fila</returns>
    Public Shared Function fn_TEF_Crear(ByVal Id_Cliente As Integer, ByVal Id_CuentaPago As Integer, ByVal Referencia As String, ByVal Observaciones As String)
        If fn_TEF_ValidarCuenta(Id_CuentaPago, Id_Cliente) Then
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesTEF_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Id_CuentaPago", SqlDbType.Int, Id_CuentaPago)
            Crea_Parametro(cmd, "@Referencia", SqlDbType.VarChar, Referencia)
            Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            Try
                Dim int As Integer = EjecutarNonQuery(cmd)
                If int = 0 Then
                    Return False
                Else
                    cmd = Crea_Comando("Cat_ClientesAdmin_UpdatepagaTEF", CommandType.StoredProcedure, Crea_ConexionSTD)
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Crea_Parametro(cmd, "@Paga_TEF", SqlDbType.VarChar, "S")
                    Return True
                End If

            Catch ex As Exception
                TrataEx(ex)
                Return False
            End Try
        Else
            MsgBox("La Cuenta ya existe para este Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
    End Function

    'Public Shared Function fn_TEF_AgregaParametros(ByVal Cmb As cp_cmb_SimpleFiltradoParam, ByVal IdBanco As Integer, ByVal IdMoneda As Integer) As Boolean
    '    Cmb.LimpiarParametros()
    '    Cmb.AgregarParametros("@Id_Banco", SqlDbType.Int, IdBanco)
    '    Cmb.AgregarParametros("@Id_Moneda", SqlDbType.Int, IdMoneda)

    '    Return True
    'End Function

    ''' <summary>
    ''' Elimina un registro de la bas de datos
    ''' </summary>
    ''' <param name="Id">Es el registro que desea eliminar</param>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    ''' <returns>Devuelve true si se elimino algun registro</returns>
    Public Shared Function fn_TEF_Eliminar(ByVal Id As Integer, ByVal Id_Cliente As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesTEF_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_CuentaPago", SqlDbType.Int, Id)

        Try
            If EjecutarNonQuery(cmd) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesAdmin_ActualizaPagaTEF(ByVal Id_Cliente As Integer, ByVal pagaTEF As String) As Boolean
        '5/03/2014
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesAdmin_UpdatepagaTEF", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Paga_TEF", SqlDbType.VarChar, pagaTEF)

        Try
            If EjecutarNonQuery(cmd) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Valida si existe la cuenta
    ''' </summary>
    ''' <param name="Id_Cuenta">Es el numero de cuenta que se va a verificas</param>
    ''' <param name="Id_Cliente">Es el numero de cliente donde se va a buscar la cuenta</param>
    ''' <returns>Devuelve true si no existe la cuenta</returns>
    Public Shared Function fn_TEF_ValidarCuenta(ByVal Id_Cuenta As Integer, ByVal Id_Cliente As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesTEFCuenta_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            If EjecutaConsulta(cmd).Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try

    End Function

    ''' <summary>
    ''' Llena una lista con valores de la tabla cat_clientesAdminHorarios
    ''' </summary>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    ''' <param name="Tipo">1=Recepcion Facturas; 2=Pago Facturas</param>
    ''' <param name="lsv">Es la lista que se va a llenar de datos</param>
    ''' <returns>Devuelve false en caso de error</returns>
    Public Shared Function fn_Admin_LlenarLista(ByVal Id_Cliente As Integer, ByVal Tipo As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesAdminHorarios_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            lsv.Actualizar(cmd, "Id_Horario")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try


    End Function

    ''' <summary>
    ''' Agrega un nuevo horario a la tabla Cat_ClientesAdminHorarios
    ''' </summary>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    ''' <param name="Tipo">1=Recepcion Facturas; 2=Pago Facturas</param>
    ''' <param name="Frecuencia">Es el numero del dia al que pertenece el horario</param>
    ''' <param name="Horario">es un rango de horas en el que se puede realizar</param>
    ''' <returns>Devuelve true si se inserta alguna fila</returns>
    Public Shared Function fn_Admin_CrearHorario(ByVal Id_Cliente As Integer, ByVal Tipo As Integer, ByVal Frecuencia As Char, ByVal Horario As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesAdminHorarios_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
        Crea_Parametro(cmd, "@Horario", SqlDbType.VarChar, Horario)

        Try
            Dim int As Integer = EjecutarNonQuery(cmd)
            If int = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Elimina un registro de la tabla Cat_ClientesAdminHorarios
    ''' </summary>
    ''' <param name="Id">Es el registro que desea eliminar</param>
    ''' <returns>Devuelve true si se elimino algun registro</returns>
    Public Shared Function fn_Admin_Eliminar(ByVal Id As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesAdminHorarios_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Horario", SqlDbType.Int, Id)

        Try
            If EjecutarNonQuery(cmd) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#Region "BuscarCliente"

    ''' <summary>
    ''' Llena la lista lsv_Clientes
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarLista(ByVal lsv As cp_Listview, ByVal SoloActivos As Boolean, ByVal Id_Sucursal As Integer, Optional ByVal Cliente As Boolean = True) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetBuscaCliente", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, Id_Sucursal)

        If Cliente = False Then
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
        Else
            If SoloActivos Then
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            End If
        End If

        Try
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarProspectos_LlenarLista(ByVal lsv As cp_Listview, ByVal SoloActivos As Boolean, Optional ByVal Cliente As Boolean = True) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetBuscaProspecto", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarClientes_LlenarListaEmpleados(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_ComboGetActivos", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_BuscarClientes_LlenarListaCajasBancarias(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_ComboGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            lsv.Actualizar(cmd, "Id_CajaBancaria")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarClientes_LlenarListaCajasFuertes(ByVal Id_CS As Integer, ByVal Status As String, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_GetByCS", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(cmd, "Id_CajaFuerte")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarClientes_LlenarListaProveedores(ByVal lsv As cp_Listview, ByVal SoloActivos As Boolean) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Proveedores_GetBusca", CommandType.StoredProcedure, Crea_ConexionSTD)

        If SoloActivos Then
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Else
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "T")
        End If

        Try
            lsv.Actualizar(cmd, "Id_Proveedor")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Seguimiento_BuscarLlamadas(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_SolicitudServicio_GetBuscaSolicitud", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            lsv.Actualizar(Cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarClientes_Padres(ByVal SoloActivos As Boolean, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetBuscarPadres", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            If SoloActivos Then
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Else
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "T")
            End If

            lsv.Actualizar(cmd, "Id_Cliente")
            If Not SoloActivos Then
                For Each Elemento As ListViewItem In lsv.Items
                    Select Case Elemento.SubItems(2).Text
                        Case "BAJA"
                            Elemento.ForeColor = Color.Red

                        Case "BAJA PERMANENTE"
                            Elemento.ForeColor = Color.DarkRed

                    End Select
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarClientes_ConCajaFuerte(ByVal Id_Clientes As String, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_CantidadxCliente", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Clientes", SqlDbType.VarChar, Id_Clientes)
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

    Public Shared Function fn_Imprimir_LlenarServiciosOtros(ByRef Tbl As DataTable, ByVal Cliente As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_GetAnexo", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@IdCliente", SqlDbType.Int, Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A") 'mostrar solo activos
            Crea_Parametro(cmd, "@Traslado", SqlDbType.VarChar, "N") 'No_mostar_TV 6/03/2014
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try

        End Using
    End Function

    Public Shared Function fn_Imprimir_LlenarServiciosTV(ByRef Tbl As DataTable, ByVal Cliente As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@IdCliente", SqlDbType.Int, Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A") 'mostrar solo activos
            Crea_Parametro(cmd, "@Traslado", SqlDbType.VarChar, "S") 'solo TV 6/03/2014
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                'Dim dt As DataTable = Tbl
                'For contador As Integer = 0 To Tbl.Rows.Count - 1
                '    Dim cad As String = Tbl.Rows(contador)("ClavePrecio")
                'Next        

                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try

        End Using
    End Function

    Public Shared Function fn_Imprimir_LlenarHorarios(ByRef Tbl As DataTable, ByVal Cliente As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_ClientesHorariosReporte_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A") '6/03/2014 solo Horarios activos
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try

        End Using
    End Function

    Public Shared Function fn_Imprimir_DatosEmpresa() As Array
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empresas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Empresa", SqlDbType.VarChar, EmpresaId)

        Try
            Return EjecutaConsulta(cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Precios__Historial(ByVal Id_CS As Integer, Optional ByVal Precio As Integer = Nothing, Optional ByVal Descripcion As Integer = Nothing, Optional ByVal Precio_Anterio As Integer = Nothing, Optional ByVal ClavePrecio As String = Nothing) As Boolean
        'En esta parte insertamos el registro de la tabla para llevar el histrial de cuando un usario modifique el precio. 


        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_Historial", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
        Crea_Parametro(cmd, "@Clave_Precio", SqlDbType.VarChar, ClavePrecio)
        Crea_Parametro(cmd, "@Descripción", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@id_Precio", SqlDbType.Int, Precio)
        Crea_Parametro(cmd, "@Precio_Anterior", SqlDbType.VarChar, Precio_Anterio)
        Crea_Parametro(cmd, "@usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Sucursal", SqlDbType.Int, SucursalId)
        'Crea_Parametro(cmd, "@Usr_Modifica", SqlDbType.Int, UsuarioId)
        'Crea_Parametro(cmd, "@Precio_Anterio", SqlDbType.Int, SucursalId)


        Try
            Dim int As Integer = EjecutarNonQuery(cmd)
            If int = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Precios_ActualizarSugerido(ByVal Id_CS As Integer, Optional ByVal Precio As Integer = Nothing, Optional ByVal CR As Integer = Nothing, Optional ByVal EE As Integer = Nothing, Optional ByVal KM As Integer = Nothing, Optional ByVal Descripcion As Integer = Nothing, Optional ByVal Tr As SqlTransaction = Nothing) As Boolean
        Dim cmd As SqlCommand
        If Tr Is Nothing Then
            cmd = Crea_Comando("Cat_ClientesServicios_UpdateCambioPrecio", CommandType.StoredProcedure, Crea_ConexionSTD)
        Else
            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_ClientesServicios_UpdateCambioPrecio")
        End If

        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
        If Not Precio = Nothing Then Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Precio)
        If Not Descripcion = Nothing Then Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Descripcion)
        If Not CR = Nothing Then Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, CR)
        If Not EE = Nothing Then Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, EE)
        If Not KM = Nothing Then Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, KM)

        Try
            If Tr Is Nothing Then
                Return EjecutarNonQuery(cmd) > 0
            Else
                If EjecutarNonQueryT(cmd) > 0 Then
                    Return True
                Else
                    Tr.Rollback()
                    Return False
                End If
            End If
        Catch ex As Exception
            If Not Tr Is Nothing Then Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Enum TipoPrecio As Byte
        Precio
        Descripcion
        CR
        EE
        KM
    End Enum

    Public Shared Function fn_Precios_ActualizarNuevo(ByVal Id As Integer, ByVal Tipo As TipoPrecio, ByVal Descripcion As String, ByVal Precio As Decimal, ByVal Id_CS As Integer) As Boolean
        Dim Sp As String = ""
        Dim P As String = ""
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Try
            Select Case Tipo
                Case TipoPrecio.Precio
                    Sp = "Cat_Precios_CreateBase"
                    P = "@Id_Precio"
                Case TipoPrecio.CR
                    Sp = "Cat_CuotaRiesgo_CreateBase"
                    P = "@Id_CR"
                Case TipoPrecio.EE
                    Sp = "Cat_EnvasesE_CreateBase"
                    P = "@Id_EE"
                Case TipoPrecio.KM
                    Sp = "Cat_Kilometros_CreateBase"
                    P = "@Id_KM"
                Case TipoPrecio.Descripcion
                    Sp = "Cat_PrecioDescripcion_CreateBase"
                    P = "@Id_PrecioDescripcion"
            End Select

            Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, Sp)
            Crea_Parametro(cmd, P, SqlDbType.Int, Id)
            'Precio ya no lleva Descripción.
            If Tipo <> TipoPrecio.Precio Then Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            'Descripción no lleva Precio ni Usuario_Registro
            If Tipo <> TipoPrecio.Descripcion Then
                Crea_Parametro(cmd, "@Precio", SqlDbType.Money, Precio)
                Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            End If
            Dim Int As Integer = EjecutarScalarT(cmd)

            If Not Int = Nothing AndAlso Int > 0 Then
                Dim Actualiza As Boolean
                Select Case Tipo
                    Case TipoPrecio.Precio
                        Actualiza = fn_Precios_ActualizarSugerido(Id_CS, Int, , , , , Tr)
                    Case TipoPrecio.CR
                        Actualiza = fn_Precios_ActualizarSugerido(Id_CS, , Int, , , , Tr)
                    Case TipoPrecio.EE
                        Actualiza = fn_Precios_ActualizarSugerido(Id_CS, , , Int, , , Tr)
                    Case TipoPrecio.KM
                        Actualiza = fn_Precios_ActualizarSugerido(Id_CS, , , , Int, , Tr)
                    Case TipoPrecio.Descripcion
                        Actualiza = fn_Precios_ActualizarSugerido(Id_CS, , , , , Int, Tr)
                End Select

                If Actualiza Then
                    Tr.Commit()
                    Return True
                Else
                    Return False
                End If
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_PreciosDescripcion_ActualizarNuevo(ByVal Id_PrecioDescripcion As Integer, ByVal Id_Precio As Integer, ByVal Descripcion As String, ByVal Precio As Decimal, ByVal Id_CS As Integer) As Boolean
        Dim Id_PrecioNuevo As Integer = 0
        Dim Id_PrecioDescripcionNuevo As Integer = 0
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim cmd As SqlCommand
        Try
            'Se Crea Nueva Descripción y Precio por el Textbox.
            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_Precios_CreateBase")
            Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
            Crea_Parametro(cmd, "@Precio", SqlDbType.Money, Precio)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Id_PrecioNuevo = EjecutarScalarT(cmd)

            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_PrecioDescripcion_CreateBase")
            Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Id_PrecioDescripcionNuevo = EjecutarScalarT(cmd)

            If Id_PrecioNuevo > 0 AndAlso Id_PrecioDescripcionNuevo > 0 Then
                If fn_Precios_ActualizarSugerido(Id_CS, Id_PrecioNuevo, , , , Id_PrecioDescripcionNuevo, Tr) = True Then
                    Tr.Commit()
                    Return True
                Else
                    Return False
                End If
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_Crear(ByVal Nombre_Fiscal As String,
                                             ByVal Calle_Fiscal As String,
                                             ByVal Numero_Fiscal As String,
                                             ByVal NumeroInt_Fiscal As String,
                                             ByVal Colonia_Fiscal As String,
                                             ByVal CP_Fiscal As String,
                                             ByVal Zona_Fiscal As String,
                                             ByVal RFC As String,
                                             ByVal Nombre_Comercial As String,
                                             ByVal Calle_Comercial As String,
                                             ByVal Numero_Comercial As String,
                                             ByVal NumeroInt_Comercial As String,
                                             ByVal Zona_Comercial As String,
                                             ByVal Colonia_Comercial As String,
                                             ByVal CP_Comercial As String,
                                             ByVal Id_Giro As Integer,
                                             ByVal Id_Categoria As Integer,
                                             ByVal Clave_Radio As String,
                                             ByVal Local_Foraneo As Char,
                                             ByVal Id_Padre As Integer,
                                             ByVal Latitud As Decimal,
                                             ByVal Longitud As Decimal,
                                             ByVal RequiereMaterial As String,
                                             ByVal MensajeAlerta As String,
                                             ByVal Tipo_Cliente As String,
                                             ByVal Fecha_InicioOperaciones As Date,
                                             ByVal EntreCalle_Fiscal1 As String,
                                             ByVal EntreCalle_Fiscal2 As String,
                                             ByVal EntreCalle_Comercial1 As String,
                                             ByVal EntreCalle_Comercial2 As String,
                                             ByVal Nombre_Corto As String,
                                             ByVal Cliente_Padre As Boolean,
                                             ByVal UtilizaCaset As String,
                                             ByVal UtilizaCatalogoDigital As String,
                                             ByVal Id_CFDI As Integer,
                                             ByVal KM_CFDI As Decimal,
                                             ByVal ComprobanteUUID As String,
                                             ByVal UsarUUID As Integer,
                                             ByVal Categoria As String,
                                             ByRef EscasetPropio As String,
                                             ByVal Envia_Correo As String,
                                             ByVal Correo As String) As Integer
        Dim cmd As SqlCommand
        Dim Id As Integer
        Try
            cmd = Crea_Comando("Cat_Clientes_Create", CommandType.StoredProcedure, Crea_ConexionSTD)

            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            If Nombre_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@Nombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
            End If

            If Calle_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@Calle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
            End If

            If Numero_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
            End If

            If NumeroInt_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
            End If

            If Colonia_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
            End If

            If CP_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@CP_Fiscal", SqlDbType.Int, CP_Fiscal)
            End If

            If Zona_Fiscal.Trim <> "" Then
                Crea_Parametro(cmd, "@Zona_Fiscal", SqlDbType.Int, Zona_Fiscal)
            End If

            If RFC.Trim <> "" Then
                Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
            End If

            Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)

            If Calle_Comercial.Trim <> "" Then
                Crea_Parametro(cmd, "@Calle_Comercial", SqlDbType.VarChar, Calle_Comercial)
            End If

            If Numero_Comercial.Trim <> "" Then
                Crea_Parametro(cmd, "@Numero_Comercial", SqlDbType.Int, Numero_Comercial)
            End If

            If NumeroInt_Comercial.Trim <> "" Then
                Crea_Parametro(cmd, "@NumeroInt_Comercial", SqlDbType.VarChar, NumeroInt_Comercial)
            End If

            If Colonia_Comercial.Trim <> "" Then
                Crea_Parametro(cmd, "@Colonia_Comercial", SqlDbType.VarChar, Colonia_Comercial)
            End If

            If CP_Comercial.Trim <> "" Then
                Crea_Parametro(cmd, "@CP_Comercial", SqlDbType.Int, CP_Comercial)
            End If

            If Zona_Comercial.Trim <> "" Then
                Crea_Parametro(cmd, "@Zona_Comercial", SqlDbType.Int, Zona_Comercial)
            End If

            Crea_Parametro(cmd, "@Id_Giro", SqlDbType.Int, Id_Giro)
            Crea_Parametro(cmd, "@Id_Categoria", SqlDbType.Int, Id_Categoria)
            Crea_Parametro(cmd, "@Clave_Radio", SqlDbType.VarChar, Clave_Radio)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Local_Foraneo", SqlDbType.VarChar, Local_Foraneo)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Ult_Subcliente", SqlDbType.Int, 0)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
            Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, Latitud)
            Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, Longitud)
            Crea_Parametro(cmd, "@EstacionRegistro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@RequiereMaterial", SqlDbType.VarChar, RequiereMaterial)
            Crea_Parametro(cmd, "@MensajeAlerta", SqlDbType.VarChar, MensajeAlerta)
            Crea_Parametro(cmd, "@Tipo_Cliente", SqlDbType.VarChar, Tipo_Cliente)
            Crea_Parametro(cmd, "@Fecha_InicioOperaciones", SqlDbType.Date, Fecha_InicioOperaciones)
            Crea_Parametro(cmd, "@EntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
            Crea_Parametro(cmd, "@EntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
            Crea_Parametro(cmd, "@EntreCalle_Comercial1", SqlDbType.VarChar, EntreCalle_Comercial1)
            Crea_Parametro(cmd, "@EntreCalle_Comercial2", SqlDbType.VarChar, EntreCalle_Comercial2)
            Crea_Parametro(cmd, "@Nombre_Corto", SqlDbType.VarChar, Nombre_Corto)
            Crea_Parametro(cmd, "@KM_CFDI", SqlDbType.Decimal, KM_CFDI)
            Crea_Parametro(cmd, "@ComprobanteUUID", SqlDbType.VarChar, ComprobanteUUID)
            Crea_Parametro(cmd, "@UsarUUID", SqlDbType.Int, UsarUUID)
            Crea_Parametro(cmd, "@Categoria", SqlDbType.VarChar, Categoria)
            Crea_Parametro(cmd, "@EsCasetPropio", SqlDbType.VarChar, EscasetPropio)
            Crea_Parametro(cmd, "@Envia_Correo", SqlDbType.VarChar, Envia_Correo)
            Crea_Parametro(cmd, "@Correo", SqlDbType.VarChar, Correo)

            If Cliente_Padre Then
                Crea_Parametro(cmd, "@Cliente_Padre", SqlDbType.VarChar, "S")
            Else
                Crea_Parametro(cmd, "@Cliente_Padre", SqlDbType.VarChar, "N")
            End If

            Crea_Parametro(cmd, "@Utiliza_Caset", SqlDbType.VarChar, UtilizaCaset)
            Crea_Parametro(cmd, "@Utiliza_CatalogoDigital", SqlDbType.VarChar, UtilizaCatalogoDigital)
            Crea_Parametro(cmd, "@Id_CFDI", SqlDbType.Int, Id_CFDI)
            Id = EjecutaConsulta(cmd).Rows(0)(1)

            'Incrementar el Ult_Prospecto o Ult_Cliente en Cat_Sucursales
            '@Cliente=1 Cuando es Cleinte
            '@Cliente=0 Cuando es Prospecto

            cmd = Crea_Comando("Cat_Sucursales_UltClienteProUpdate", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Cliente", SqlDbType.Int, 0)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            EjecutarNonQuery(cmd)

            Return Id
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' cambia el status de un registro de la tabla cat_ClientesHorariosTemp
    ''' </summary>
    Public Shared Function fn_Clientes_BajaHorario(ByVal Id_CH As Integer, ByVal Status As Char)
        Dim cmd As SqlCommand = Crea_Comando("cat_ClientesHorarios_UpdateStatus", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, Id_CH)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            If EjecutarNonQuery(cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' elimina un registro de la tabla cat_ClientesHorariosTemp
    ''' </summary>
    Public Shared Function fn_Clientes_BorraHorarioTemp(ByVal Id_CH As Integer)
        Dim cmd As SqlCommand = Crea_Comando("cat_ClientesHorariosTemp_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, Id_CH)

        Try
            If EjecutarNonQuery(cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_Reingreso(ByVal Id_Cliente As Integer, ByVal Afectar_Subclientes As Boolean, ByVal ClienteProceso As Boolean, ByVal lsv As cp_Listview) As Boolean
        Dim Tra As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_Clientes_Reingresar")
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)

        Try
            EjecutarNonQueryT(cmd)

            If Afectar_Subclientes Then
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(4).Text = "S" AndAlso Elemento.SubItems(3).Text = "BAJA" Then
                        cmd.Parameters.Clear()
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
                        Crea_Parametro(cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)
                        EjecutarNonQueryT(cmd)
                    End If
                Next
            End If

            'REINGRESO DE CLIENTES PROCESO
            If ClienteProceso Then
                cmd = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesProceso_ReingresoxCliente")
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)
                EjecutarNonQueryT(cmd)

                If Afectar_Subclientes Then
                    For Each Elemento As ListViewItem In lsv.Items
                        If Elemento.SubItems(4).Text = "S" AndAlso Elemento.SubItems(3).Text = "BAJA" Then
                            cmd.Parameters.Clear()
                            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
                            Crea_Parametro(cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)
                            EjecutarNonQueryT(cmd)
                        End If
                    Next
                End If
            End If

            Tra.Commit()
            Return True
        Catch ex As Exception
            Tra.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Cliente_ListaNegra(ByVal Id_Cliente As Integer, ByVal Id_Padre As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesListaNegra_Existe", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Dim Cantidad As Integer = EjecutarScalar(cmd)
            If Cantidad > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Buscar SubClientes"

    Public Shared Function fn_SubCliente_LlenarLista(ByVal Procedimiento As Integer, ByVal Id_Padre As Integer, ByVal Status As String, ByVal AgregarPadre As Boolean, ByRef lsv As cp_Listview) As Boolean
        Try
            'Tipo 1 = Consulta Normal
            'Tipo 2 = Consulta Clientes - Fiscales
            Dim Consulta As String = ""
            Select Case Procedimiento
                Case 1
                    Consulta = "Cat_Clientes_GetHijos"
                Case 2
                    Consulta = "Cat_Clientes_GetFiscales"
            End Select

            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando(Consulta, CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            If AgregarPadre Then Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")

            lsv.Actualizar(cmd, "Id_Cliente")
            For Each Elemento As ListViewItem In lsv.Items
                Select Case Procedimiento
                    Case 1
                        If Elemento.SubItems(3).Text = "BAJA" OrElse Elemento.SubItems(3).Text = "BAJA PERMANENTE" Then
                            Elemento.ForeColor = Color.Red
                        End If

                    Case 2
                        If Elemento.SubItems(4).Text = "BAJA" OrElse Elemento.SubItems(4).Text = "BAJA PERMANENTE" Then
                            Elemento.ForeColor = Color.Red
                        End If

                End Select
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_SubClienteServicios_LlenarLista(ByVal Id_Padre As Integer, ByVal Id_PrecioDescripcion As Integer, ByVal ClavePrecio As String, ByVal TambienPadre As Char, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetServiciosHijos", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.VarChar, Id_Padre)
            Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
            Crea_Parametro(cmd, "@ClavePrecio", SqlDbType.VarChar, ClavePrecio)
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, TambienPadre) 'S = Si o N = No

            lsv.Actualizar(cmd, "Id_CS")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_LlenarLista_HorariosTemporales(ByVal Id_Padre As Integer, ByVal Clave_Padre As String, ByVal Id_CS As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetHTemp", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Clave_Padre", SqlDbType.VarChar, Clave_Padre)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")
            lsv.Actualizar(cmd, "Id_Htemp")
            lsv.Row1 = 10 'Clave Cliente Contratante
            lsv.Row2 = 15 'Cliente Contratante
            lsv.Row3 = 0 'Fecha Inicio
            lsv.Row4 = 12 'Sucursal Origen
            lsv.Row5 = 10 'Clave Cliente Origen
            lsv.Row6 = 15 'Cliente Origen
            lsv.Row7 = 10 'Tipo
            lsv.Row8 = 10 'Frecuencia
            lsv.Row9 = 8 'Horario Recolección
            lsv.Columns(9).Width = 100 'Suc Destino
            lsv.Columns(10).Width = 80 'Clave Destino
            lsv.Columns(11).Width = 120 'Cliente Destino
            lsv.Columns(12).Width = 80 'Dia Entrega
            lsv.Columns(13).Width = 80 'Horarario Entrega
            lsv.Columns(14).Width = 80 'Escala Boveda
            lsv.Columns(15).Width = 0 'Id_CS
            lsv.Columns(16).Width = 0 'Id_Cliente (El Cliente Principal al que se dio de alta el horario)
            lsv.Columns(17).Width = 0 'Id_ClienteOrigen
            lsv.Columns(18).Width = 0 'Id_ClienteDestino
            lsv.Columns(19).Width = 0 'Id_CH
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_LlenarLista_HorariosReales(ByVal Id_Padre As Integer, ByVal Clave_Padre As String, ByVal Id_CS As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetHorarios", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Clave_Padre", SqlDbType.VarChar, Clave_Padre)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")
            lsv.Actualizar(cmd, "Id_CH")
            lsv.Row1 = 10 'Clave Cliente Contratante
            lsv.Row2 = 15 'Cliente Contratante
            lsv.Row3 = 0 'Fecha Inicio
            lsv.Row4 = 12 'Sucursal Origen
            lsv.Row5 = 10 'Clave Cliente Origen
            lsv.Row6 = 15 'Cliente Origen
            lsv.Row7 = 10 'Tipo
            lsv.Row8 = 10 'Frecuencia
            lsv.Row9 = 8 'Horario Recolección
            lsv.Columns(9).Width = 100 'Suc Destino
            lsv.Columns(10).Width = 80 'Clave Destino
            lsv.Columns(11).Width = 120 'Cliente Destino
            lsv.Columns(12).Width = 80 'Dia Entrega
            lsv.Columns(13).Width = 80 'Hora Entrega
            lsv.Columns(14).Width = 80 'Escala Boveda
            lsv.Columns(15).Width = 0 'Id_CS
            lsv.Columns(16).Width = 0 'Id_Cliente (El Cliente Principal al que se dio de alta el horario)
            lsv.Columns(17).Width = 0 'Id_ClienteOrigen
            lsv.Columns(18).Width = 0 'Id_ClienteDestino
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Clientes Extra"

    Public Shared Function fn_ClienteObservaciones_Texto(ByVal Id_Cliente As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesOtros_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try
            Dim Dt As DataTable = EjecutaConsulta(cmd)
            If Dt.Rows.Count > 0 Then
                Return Dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ClienteObservaciones_Actualizar(ByVal Id_Cliente As Integer, ByVal Observaciones As String, ByVal Modificar As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Try
            If Modificar > 0 Then
                Cmd = Cn_Datos.Crea_Comando("Cat_ClientesOtros_Update", CommandType.StoredProcedure, Cnn)
            Else
                Cmd = Cn_Datos.Crea_Comando("Cat_ClientesOtros_Create", CommandType.StoredProcedure, Cnn)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Clientes Fotografías"

    Public Shared Function fn_ClienteFotografias_CargarArreglo(ByVal Id_Cliente As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ReDim Arreglo_Archivo(dt.Rows.Count)
                Dim Contador As Integer = 0
                For Each Elemento As DataRow In dt.Rows
                    Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_ClienteI")
                    Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                    Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                    Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                    Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("Descripcion")
                    Arreglo_Archivo(Contador).Extension_Archivo = Nothing
                    Arreglo_Archivo(Contador).Adicional_Archivo = Nothing
                    Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                    Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                    Contador += 1
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ClienteFotografias_Actualizar(ByVal Id_Cliente As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                    Continue For

                ElseIf Arreglo_Archivo(ILocal).Id_Archivo = Nothing Then
                    'Crear un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesI_Create")
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                ElseIf Arreglo_Archivo(ILocal).Objeto_Archivo IsNot Nothing Then
                    'Actualizar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesI_Update")
                    Crea_Parametro(cmd, "@Id_ClienteI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)

                Else
                    'Eliminar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesI_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_ClienteI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)
                    EjecutarNonQueryT(cmd)
                    Continue For
                End If

                Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Nombre_Archivo, False)
                Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, Arreglo_Archivo(ILocal).MimeType_Archivo)
                Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                EjecutarNonQueryT(cmd)
            Next

            Tr.Commit()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ClienteFotografias_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Cliente As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesI_Get", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

            lsv.Actualizar(cmd, "Id_ClienteI")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Clientes Documentos Requeridos"

    Public Shared Function fn_DoctoRequeridosCliente_CargarArreglo(ByVal Id_Cliente As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctosI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ReDim Arreglo_Archivo(dt.Rows.Count)
                Dim Contador As Integer = 0
                For Each Elemento As DataRow In dt.Rows
                    Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_ClienteDoctoI")
                    Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                    Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                    Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                    Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("DescripcionArchivo")
                    Arreglo_Archivo(Contador).Extension_Archivo = Elemento("Id_DoctosR")
                    Arreglo_Archivo(Contador).Adicional_Archivo = Elemento("TipoDocumentoRecibido")
                    Arreglo_Archivo(Contador).FileSize_Archivo = Elemento("Id_ClienteDocto")
                    Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                    Contador += 1
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctoRequeridosCliente_Actualizar(ByVal Id_Cliente As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                    Continue For

                ElseIf Arreglo_Archivo(ILocal).Id_Archivo = Nothing Then
                    'Crear un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesDoctos_Create")
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                ElseIf Arreglo_Archivo(ILocal).Objeto_Archivo IsNot Nothing Then
                    'Actualizar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesDoctos_Update")
                    Crea_Parametro(cmd, "@Id_ClienteDoctoI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)

                Else
                    'Eliminar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesDoctos_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_ClienteDoctoI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)
                    EjecutarNonQueryT(cmd)
                    Continue For
                End If

                Crea_Parametro(cmd, "@Id_DoctosR", SqlDbType.Int, Arreglo_Archivo(ILocal).Extension_Archivo)
                Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Nombre_Archivo, False)
                Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, Arreglo_Archivo(ILocal).MimeType_Archivo)
                Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                EjecutarNonQueryT(cmd)
            Next

            Tr.Commit()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctoRequeridosCliente_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Cliente As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctos_Get", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

            lsv.Actualizar(cmd, "")
            For Each Elemento As ListViewItem In lsv.Items
                If CInt(Elemento.SubItems(1).Text) > 0 Then
                    Elemento.Checked = True
                End If
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Cajas Bancarias"

    ''' <summary>
    ''' Llena una lista de la tabla Pro_CajasBancarias
    ''' </summary>
    ''' <param name="lsv">Es la lista que se va a llenar</param>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_CajasBancarias_LlenarLista(ByVal lsv As cp_Listview, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(cmd, "Id_CajaBancaria")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Da de alta un nuevo registro en la tabla Pro_CajasBancarias
    ''' </summary>    
    ''' <param name="Id_Banco">Es el Id del banco</param>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    Public Shared Function fn_CajasBancarias_Crear(ByVal Id_Cliente As Integer, ByVal Id_Banco As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Banco", SqlDbType.Int, Id_Banco)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Dim int As Integer = EjecutarNonQuery(cmd)
            If int = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CajasBancarias_BuscarExiste(ByVal Id_Cliente As Integer, ByVal Id_Banco As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Existe", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Banco", SqlDbType.Int, Id_Banco)

        Try
            Dim dt_CajasBancarias As DataTable = EjecutaConsulta(cmd)

            If dt_CajasBancarias IsNot Nothing AndAlso dt_CajasBancarias.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Actualiza un registro en la tabla Pro_CajasBancarias
    ''' </summary>
    ''' <param name="Id_CajaBancaria">Es el id del registro que se va a actualizar</param>
    ''' <param name="Id_banco">Es el id del banco</param>
    Public Shared Function fn_CajasBancarias_Actualizar(ByVal Id_CajaBancaria As Integer, ByVal Id_Banco As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_banco", SqlDbType.Int, Id_Banco)

        Try
            Dim Res As Integer = EjecutarNonQuery(cmd)
            If Res = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Verifica que no existan dependencias antes de dar de baja un registro
    ''' </summary>
    ''' <param name="Id_CajaBancaria">es el registro que se quiere dar de baja</param>
    Public Shared Function fn_CajasBancarias_ValidarDependencias(ByVal Id_CajaBancaria As Integer) As Boolean
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Dependencias", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Dt = EjecutaConsulta(cmd)
            If Dt Is Nothing Then
                Return True
            End If
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)("Clientes") > 0 Or Dt.Rows(0)("Cuentas") > 0 Or Dt.Rows(0)("Depositos") > 0 Then
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try
    End Function

    ''' <summary>
    ''' Cambia el status de un registro segun corresponda
    ''' </summary>
    ''' <param name="Id_CajaBancaria">Es el id del registro</param>
    ''' <param name="Status">Es el status que se quiere asugnar</param>
    Public Shared Function fn_CajasBancarias_Status(ByVal Id_CajaBancaria As Integer, ByVal Status As Char)
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            If EjecutarNonQuery(cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Obtiene todos los valores de un registro de la tabla Pro_CajasBancarias y los regresa en un Array
    ''' </summary>
    ''' <param name="Id_CajaBancaria">Es el id del registro</param>
    Public Shared Function fn_CajasBancarias_Leer(ByVal Id_CajaBancaria As Integer) As Array
        Dim Cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Return EjecutaConsulta(Cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Obtiene todos los valores de un registro de la tabla Pro_CajasBancarias y los regresa en un DataTable
    ''' </summary>
    ''' <param name="Id_CajaBancaria">Es el Id de la Caja Bancaria</param>
    Public Shared Function fn_CajasBancarias_Leer2(ByVal Id_CajaBancaria As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function


#End Region

#Region "Clientes Proceso"

    ''' <summary>
    ''' Llena una lista de la tabla Cat_ClientesProceso
    ''' </summary>
    ''' <param name="lsv">Es la lista que se va a llenar</param>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    ''' 
    Public Shared Function fn_ClientesProceso_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Id_Cia As Integer, ByVal Activos As Boolean) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, If(Activos, "S", "N"))

        Try
            lsv.Actualizar(cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Da de alta un nuevo registro en la tabla Cat_ClientesProceso
    ''' </summary>    
    ''' <param name="Clave_Cliente">Es la clave del cliente</param>
    ''' <param name="Direccion_Comercial">Es la Direccion del cliente</param>
    ''' <param name="Id_CajaBancaria">Es el id de la tabla caja bancaria</param>
    ''' <param name="Id_Ciudad">Es el id de la ciudad</param>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    ''' <param name="Id_Grupo">Es el id del grupo</param>
    ''' <param name="Nombre_Comercial">Es el nombre comercial</param>
    ''' <param name="Numero_Contrato">Es el numero del contrato</param>
    ''' <param name="Requiere_Cuenta">Es un campo S / N que indica si el cliente tiene cuentas</param>
    Public Shared Function fn_ClientesProceso_Crear(ByVal Id_Cliente As Integer, ByVal Id_Cia As Integer, ByVal Clave_Cliente As String,
                                                    ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer,
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String,
                                                    ByVal Requiere_Cuenta As Char, ByVal GrupoDepo As Integer, ByVal GrupoDota As Integer, ByVal Tipo_Proceso As String, ByVal Categoria As String, ByVal Razon_Social As String) As Integer

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, GrupoDepo)
        Crea_Parametro(cmd, "@Id_GrupoDota", SqlDbType.Int, GrupoDota)
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Tipo_Proceso", SqlDbType.VarChar, Tipo_Proceso)
        If Razon_Social <> "" Then
            Crea_Parametro(cmd, "@Razon_Social", SqlDbType.VarChar, Razon_Social)
        End If
        If Categoria <> "SIN CATEGORIA" Then
            Crea_Parametro(cmd, "@Categoria", SqlDbType.VarChar, Categoria)
        End If
        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_ClientesProceso_Existe(ByVal Id_Cliente As Integer, ByVal Id_Cia As Integer, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim Dt_Clientes As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Existe", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Dt_Clientes = EjecutaConsulta(cmd)
            If Dt_Clientes.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try

    End Function

    Public Shared Function fn_ClientesProceso_CrearVarios(ByVal Dt_Clientes As DataTable, ByVal Id_Cia As Integer, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer,
                                                          ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String,
                                                          ByVal Requiere_Cuenta As Char, ByVal GrupoDepo As Integer, ByVal GrupoDota As Integer, ByVal Tipo_Proceso As String, ByVal Categoria As String, ByVal Razon_Social As String) As Integer

        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Try
            Dim Agregados As Integer = 0
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesProceso_Create")
            For Each Row As DataRow In Dt_Clientes.Rows
                cmd.Parameters.Clear()
                Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_Cliente"))
                Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Row("Clave Cliente"))
                Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Row("Nombre Comercial"))
                Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Row("Direccion_Comercial")) 'Direccion_Comercial)
                Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
                Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
                Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
                Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
                Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, GrupoDepo)
                Crea_Parametro(cmd, "@Id_GrupoDota", SqlDbType.Int, GrupoDota)
                Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(cmd, "@Tipo_Proceso", SqlDbType.VarChar, Tipo_Proceso)
                If Razon_Social <> "" Then
                    Crea_Parametro(cmd, "@Razon_Social", SqlDbType.VarChar, Razon_Social)
                End If
                If Categoria <> "SIN CATEGORIA" Then
                    Crea_Parametro(cmd, "@Categoria", SqlDbType.VarChar, Categoria)
                End If
                ''Crea_Parametro(cmd, "@Categoria", SqlDbType.VarChar, Categoria)
                If EjecutarNonQueryT(cmd) > 0 Then Agregados += 1
            Next

            If Agregados > 0 Then
                tr.Commit()
                cnn.Close()
                Return Agregados
            Else
                tr.Rollback()
                cnn.Close()
                Return 0
            End If
        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex, False)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Modifica registro en la tabla Cat_ClientesProceso
    ''' </summary>    
    ''' <param name="Direccion_Comercial">Es la Direccion del cliente</param>
    ''' <param name="Id_Ciudad">Es el id de la ciudad</param>
    ''' <param name="Id_Grupo">Es el id del grupo</param>
    ''' <param name="Nombre_Comercial">Es el nombre comercial</param>
    ''' <param name="Numero_Contrato">Es el numero del contrato</param>
    ''' <param name="Requiere_Cuenta">Es un campo S / N que indica si el cliente tiene cuentas</param>
    Public Shared Function fn_ClientesProceso_Modificar(ByVal Id_ClienteP As Integer, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer,
                                                    ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char, ByVal GrupoDepo As Integer, ByVal GrupoDota As Integer, ByVal Tipo_Proceso As String, ByVal Categoria As String, Afectar_SubClietes As Boolean, Id_Cliente As Integer, ByVal Razon_Social As String) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, GrupoDepo)
        Crea_Parametro(cmd, "@Id_GrupoDota", SqlDbType.Int, GrupoDota)
        Crea_Parametro(cmd, "@Tipo_Proceso", SqlDbType.VarChar, Tipo_Proceso)
        If Razon_Social <> "" Then
            Crea_Parametro(cmd, "@Razon_Social", SqlDbType.VarChar, Razon_Social)
        End If
        If Categoria <> "SIN CATEGORIA" Then
            Crea_Parametro(cmd, "@Categoria", SqlDbType.VarChar, Categoria)
        End If

        Try
            Dim int As Integer = EjecutarNonQuery(cmd)

            If Afectar_SubClietes Then
                Dim cmd2 = Crea_Comando("Clientes_Categoria", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd2, "@Id_Padre", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd2, "@Categoria", SqlDbType.VarChar, IIf(Categoria = "SIN CATEGORIA", "", Categoria))
                EjecutarNonQuery(cmd2)
            End If

            If int = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesProceso_Leer(ByVal Id_ClienteP As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '''' <summary>
    '''' Obtiene toda la informacion de la empresa actual
    '''' </summary>
    '''' <returns>Devuelve un arreglo con los valores del registro</returns>
    'Public Shared Function fn_ParametrosG_Read() As Array
    '    Dim cmd As SqlCommand = Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Crea_ConexionSTD)

    '    Try
    '        Return EjecutaConsulta(cmd).Rows(0).ItemArray
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    Public Shared Function fn_Sucursales_Read(ByVal Id_Sucursal As Integer) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "Id_Sucursal", SqlDbType.Int, Id_Sucursal)
        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Ciudad_Read(ByVal Id_Ciudad As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_PaisesCiudad_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)

        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Fill(ByRef Id As Integer) As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_Cuentas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Id)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Referencias_Fill(ByRef Id As Integer) As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_ReferenciasClientesP_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Protected Shared Function fn_ClientesProceso_CrearT(ByRef Tra As SqlTransaction, ByVal Id_Cliente As Integer, ByVal Id_Cia As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer,
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char) As Integer

        Dim cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesProceso_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutarScalarT(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Public Shared Function fn_ClientesProceso_ModificarT(ByVal Tra As SqlTransaction, ByVal Id As Integer, ByVal Id_Cia As Integer, ByVal Id_Cliente As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer,
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char) As Integer

        Dim cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesProceso_Update")
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Dim int As Integer = EjecutarNonQueryT(cmd)
            If int = 0 Then
                Return 0
            Else
                Return Id
            End If

        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Protected Shared Function fn_Cuentas_Crear(ByVal Tra As SqlTransaction, ByVal Row As DataRow, ByVal Id_CajaBancaria As Integer) As Integer
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_Cuentas_Create")
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Row("Numero_Cuenta"))
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Row("Id_Moneda"))
        Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Row("Id_Ciudad"))
        Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, Row("Modo_Captura"))
        Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Row("Referenciada"))
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Row("Status"))

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Protected Shared Function fn_Cuentas_Actualizar(ByVal Tra As SqlTransaction, ByVal Row As DataRow) As Boolean
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesPcuentas_Update")
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Row("Id_Cuenta"))
        Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Row("Numero_Cuenta"))
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Row("Id_Moneda"))
        Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Row("Id_Ciudad"))
        Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Row("Referenciada"))

        Try
            EjecutarNonQueryT(Cmd)
            Return Row("Id_Cuenta")
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Protected Shared Function fn_Referencias_Crear(ByVal Tra As SqlTransaction, ByVal Row As DataRow, ByVal IdCuenta As Integer) As Integer
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_CuentasReferencias_Create")
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, IdCuenta)
        Crea_Parametro(Cmd, "@Referencia", SqlDbType.VarChar, Row("Referencia"))
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Row("Status"))

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Protected Shared Function fn_Referencias_Actualizar(ByVal Tra As SqlTransaction, ByVal Row As DataRow) As Boolean
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_CuentasReferencias_Update")
        Crea_Parametro(Cmd, "@Id_Referencia", SqlDbType.Int, Row("Id_Referencia"))
        Crea_Parametro(Cmd, "@Referencia", SqlDbType.VarChar, Row("Referencia"))
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Row("Status"))

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Public Shared Function fn_ClientesProceso_CrearCuentas(ByVal Cliente As Array, ByVal Tbl_Cuentas As DataTable, ByVal Tbl_Referencias As DataTable) As Boolean
        Dim Tra As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim IdClienteP As Integer = fn_ClientesProceso_CrearT(Tra, CInt(Cliente(0)), CInt(Cliente(1)), Cliente(2), Cliente(3), Cliente(4), CInt(Cliente(5)), CInt(Cliente(6)), CInt(Cliente(7)), Cliente(8), Cliente(9))
        Dim Id_CuentaActual As Integer

        Try
            For Each element As DataRow In Tbl_Cuentas.Rows
                Id_CuentaActual = fn_Cuentas_Crear(Tra, element, IdClienteP)

                For Each Referencia As DataRow In Tbl_Referencias.Rows
                    If Referencia("Id_Cuenta") = element("Id_Cuenta") Then
                        fn_Referencias_Crear(Tra, Referencia, Id_CuentaActual)
                    End If
                Next
            Next
            Tra.Commit()
            Tra.Dispose()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            If Not Tra Is Nothing Then Tra.Rollback()
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesProceso_ActualizarCuentas(ByVal Cliente As Array, ByVal Id As Integer, ByVal Tbl_Cuentas As DataTable, ByVal Tbl_Referencias As DataTable) As Boolean
        Dim Tra As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim IdClienteP As Integer = fn_ClientesProceso_ModificarT(Tra, Id, CInt(Cliente(1)), CInt(Cliente(0)), Cliente(2), Cliente(3), Cliente(4), CInt(Cliente(5)), CInt(Cliente(6)), CInt(Cliente(7)), Cliente(8), Cliente(9))
        Dim Id_CuentaActual As Integer

        Try
            For Each element As DataRow In Tbl_Cuentas.Rows
                Select Case element("Modificado")
                    Case 1
                        Id_CuentaActual = fn_Cuentas_Actualizar(Tra, element)
                    Case 2
                        Id_CuentaActual = fn_Cuentas_Crear(Tra, element, IdClienteP)
                    Case Else
                        Id_CuentaActual = element("Id_Cuenta")
                End Select

                For Each Referencia As DataRow In Tbl_Referencias.Rows
                    If Referencia("Id_Cuenta") = element("Id_Cuenta") Then
                        Select Case Referencia("Modificado")
                            Case 1
                                fn_Referencias_Actualizar(Tra, Referencia)
                            Case 2
                                fn_Referencias_Crear(Tra, Referencia, Id_CuentaActual)
                        End Select
                    End If
                Next
            Next

            Tra.Commit()
            Tra.Dispose()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            If Not Tra Is Nothing Then Tra.Rollback()
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesCajaFuerte_Cantidad(ByVal Id_Clientes As String) As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_CantidadxCliente", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Clientes", SqlDbType.VarChar, Id_Clientes)
        Try
            Dim dt_cajasFuertes As DataTable = EjecutaConsulta(Cmd) 'modificado se condiciono con Nothing

            If dt_cajasFuertes IsNot Nothing AndAlso dt_cajasFuertes.Rows.Count > 0 Then
                Return dt_cajasFuertes
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ClientesBaja_Crear(ByVal Id_ClientePadre As Integer, ByVal Id_MotivoB As Integer, ByVal Observaciones As String, ByVal Fecha_Baja As Date, ByVal Persona_Solicita As String, ByVal Puesto As String, ByVal ComentariosListaNegra As String, ByVal NombreComercial As String, ByVal Baja_Permanente As String, ByVal Dt_Clientes As DataTable) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(cnn)

        Try
            Dim cmd As SqlCommand
            Dim Totales As Integer = 0

            For Each Row As DataRow In Dt_Clientes.Rows
                Dim x As String
                x = Dt_Clientes.Rows.Count '-------
                If Row("Status") = "BAJA" Then
                    'Modificar una baja
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Bajas_Update")
                    Crea_Parametro(cmd, "@Id_Baja", SqlDbType.Int, Row("Id_Cliente"))
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
                    Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
                    Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.DateTime, Fecha_Baja)
                    Crea_Parametro(cmd, "@Persona_Solicita", SqlDbType.VarChar, Persona_Solicita)
                    Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
                    If EjecutarNonQueryT(cmd) > 0 Then Totales += 1
                ElseIf Row("Status") = "ACTIVO" Then
                    'Crear Baja
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Bajas_Create")
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_Cliente"))
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
                    Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
                    Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.DateTime, Fecha_Baja)
                    Crea_Parametro(cmd, "@Persona_Solicita", SqlDbType.VarChar, Persona_Solicita)
                    Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
                    Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
                    If EjecutarNonQueryT(cmd) > 0 Then Totales += 1

                    If Id_ClientePadre = Row("Id_Cliente") Then
                        'Solo al Cliente padre se le agregará los archivos que se adjunten y se agregará a la lista negra.
                        If Arreglo_Archivo IsNot Nothing Then
                            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                                    Continue For
                                Else
                                    'Crear Archivo
                                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesBajasI_Create")
                                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_Cliente"))
                                    Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Nombre_Archivo, False)
                                    Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, Arreglo_Archivo(ILocal).MimeType_Archivo)
                                    Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                                    Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                                    EjecutarNonQueryT(cmd)
                                End If
                            Next
                        End If

                        If ComentariosListaNegra <> "" Then
                            cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesListaNegra_Create")
                            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_Cliente"))
                            Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, NombreComercial)
                            Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, ComentariosListaNegra)
                            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                            EjecutarNonQueryT(cmd)
                        End If
                    End If
                End If
            Next

            Tr.Commit()
            cnn.Close()
            Arreglo_Archivo = Nothing
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    'Public Shared Function fn_ClientesBaja_Modificar(ByVal Id_Baja As Integer, ByVal Id_Cliente As Integer, ByVal Id_MotivoB As Integer, ByVal Observaciones As String, ByVal Fecha_Baja As Date, ByVal Persona_Solicita As String, ByVal Puesto As String, ByVal Afectar_Subclientes As Boolean, ByVal Dt_Subclientes As DataTable) As Boolean
    '    Dim cnn As SqlConnection = Crea_ConexionSTD()
    '    Dim Tr As SqlTransaction = crear_Trans(cnn)

    '    Try
    '        'Modificar la baja del padre
    '        Dim Modificado As Integer = 0
    '        Dim cmd As SqlCommand = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Bajas_Update")
    '        If Not Afectar_Subclientes Then
    '            Crea_Parametro(cmd, "@Id_Baja", SqlDbType.Int, Id_Baja)
    '            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
    '            Crea_Parametro(cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
    '            Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
    '            Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.DateTime, Fecha_Baja)
    '            Crea_Parametro(cmd, "@Persona_Solicita", SqlDbType.VarChar, Persona_Solicita)
    '            Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
    '            Modificado = EjecutarNonQueryT(cmd)
    '        End If

    '        If Afectar_Subclientes Then
    '            For Each Row As DataRow In Dt_Subclientes.Rows
    '                If Row("Status") = "BAJA" Then
    '                    'Modificar una baja
    '                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Bajas_Update")
    '                    Crea_Parametro(cmd, "@Id_Baja", SqlDbType.Int, Row("Id_Cliente"))
    '                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
    '                    Crea_Parametro(cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
    '                    Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
    '                    Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.DateTime, Fecha_Baja)
    '                    Crea_Parametro(cmd, "@Persona_Solicita", SqlDbType.VarChar, Persona_Solicita)
    '                    Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
    '                    EjecutarNonQueryT(cmd)
    '                ElseIf Row("Status") = "ACTIVO" Then
    '                    'Crear Baja
    '                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Bajas_Create")
    '                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_Cliente"))
    '                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
    '                    Crea_Parametro(cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
    '                    Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
    '                    Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.DateTime, Fecha_Baja)
    '                    Crea_Parametro(cmd, "@Persona_Solicita", SqlDbType.VarChar, Persona_Solicita)
    '                    Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, Puesto)
    '                    Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
    '                    EjecutarNonQueryT(cmd)
    '                End If
    '            Next
    '        End If
    '        If Modificado > 0 Then
    '            Tr.Commit()
    '            cnn.Close()
    '            Return True
    '        Else
    '            Tr.Rollback()
    '            cnn.Close()
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Tr.Rollback()
    '        cnn.Close()
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function

    Public Shared Function fn_ClientesBaja_Read(ByVal Id_Cliente As Integer) As Integer
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_Bajas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Dim dt As DataTable = EjecutaConsulta(Cmd)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt(0)("Id_Baja")
            Else
                Return 0
            End If
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Materiales_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_VentAS_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 13)

        Try
            lsv.Actualizar(cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Boveda_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Bo_Boveda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Saldo_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_VentAS_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 13)

        Try
            lsv.Actualizar(cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, CiaId)

        Try
            lsv.Actualizar(cmd, "Id_Servicio")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Traslado_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("TV_PuntosRemisiones_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(cmd, "Id_Punto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_ObtenerCuentas(ByVal Lsv As cp_Listview, ByVal Id_ClienteP As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesP_GetCuentas", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            Lsv.Actualizar(cmd, "Id_Cuenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_ObtenerReferencias(ByVal Lsv As cp_Listview, ByVal Id_ClienteP As Integer, ByVal Id_Cuenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesP_GetReferencias", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)

        Try
            Lsv.Actualizar(cmd, "Id_Referencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_ValidarReferencias(ByVal Id_ClienteP As Integer, ByVal Id_Referencia As Integer) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesP_ValidarReferencias", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)

        Try
            Return EjecutaConsulta(cmd).Rows.Count = 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_BajaReing(ByVal Id_ClienteP As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_BajaReing", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_CuentasBaja_Reing(ByVal Id_ClienteP As Integer, ByVal Id_Cuenta As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesPcuentas_BajaRenig", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_ReferenciasBaja_Reing(ByVal Id_ClienteP As Integer, ByVal Id_Referencia As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesPreferencias_Baja_Reing", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "ConceptosFproceso"

    Public Shared Function fn_ConceptosFproceso_LlenarLista(ByRef lsw As cp_Listview) As Boolean
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFproceso_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsw.Actualizar(Cmd, "Id_Concepto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConceptosFproceso_Nuevo(ByVal Descripcion As String, ByVal Formula As String) As Boolean
        'Aqui se inserta un nuevo elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFproceso_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Formula", SqlDbType.VarChar, Formula)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConceptosFproceso_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Formula As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFproceso_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Formula", SqlDbType.VarChar, Formula)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConceptosFproceso_Baja(ByVal Id As Integer) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFproceso_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConceptosFproceso_Alta(ByVal Id As Integer) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFproceso_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConceptosFproceso_ValidarFormula(ByVal Formula As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFprocesoFormula_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Formula", SqlDbType.VarChar, Formula)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConceptosFproceso_ValidarDependencias(ByVal Id As Integer) As Boolean
        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFproc_Dependencias", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.VarChar, Id)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "CajasFuertes"

    Public Shared Function fn_CajasFuertes_GetStatus(ByVal Id_Cliente As Integer) As DataRow
        'Utilizado para verificar si un cliente tiene rentada una caja fuerte, si es así no se podrá dar de baja el cliente
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_GetStatus", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            Dim dt As DataTable = EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_CajasFuertes_LlenarListaSincombinaciones(ByRef lsw As cp_Listview, ByVal Status As String, ByVal Id_Cliente As Integer) As Boolean
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_GetSin", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            lsw.Actualizar(Cmd, "Id_CajaFuerte")
            If lsw.Columns.Count = 20 Then
                lsw.Columns(4).TextAlign = HorizontalAlignment.Right

                lsw.Columns(10).Width = 160
                lsw.Columns(11).Width = 200
                lsw.Columns(12).Width = 60
                lsw.Columns(13).Width = 120
                lsw.Columns(14).Width = 80
                lsw.Columns(14).TextAlign = HorizontalAlignment.Right
                lsw.Columns(15).Width = 250
                lsw.Columns(16).Width = 300
                lsw.Columns(17).Width = 0
                lsw.Columns(18).Width = 0
                lsw.Columns(19).Width = 0
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CajasFuertes_LlenarListaEXCEL(ByRef lsw As cp_Listview, ByVal Status As String, ByVal Id_Cliente As Integer) As Boolean
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_Get_Resporte_Semaforo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            lsw.Actualizar(Cmd, "Id_CajaFuerte")
            If lsw.Columns.Count = 20 Then
                lsw.Columns(4).TextAlign = HorizontalAlignment.Right

                lsw.Columns(10).Width = 160
                lsw.Columns(11).Width = 200
                lsw.Columns(12).Width = 60
                lsw.Columns(13).Width = 120
                lsw.Columns(14).Width = 80
                lsw.Columns(14).TextAlign = HorizontalAlignment.Right
                lsw.Columns(15).Width = 250
                lsw.Columns(16).Width = 300
                lsw.Columns(17).Width = 0
                lsw.Columns(18).Width = 0
                lsw.Columns(19).Width = 0
                lsw.Columns(20).Width = 0
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertes_LlenarLista(ByRef lsw As cp_Listview, ByVal Status As String, ByVal Id_Cliente As Integer) As Boolean
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try
            lsw.Actualizar(Cmd, "Id_CajaFuerte")
            If lsw.Columns.Count = 20 Then
                lsw.Columns(4).TextAlign = HorizontalAlignment.Right

                lsw.Columns(10).Width = 160
                lsw.Columns(11).Width = 200
                lsw.Columns(12).Width = 60
                lsw.Columns(13).Width = 120
                lsw.Columns(14).Width = 80
                lsw.Columns(14).TextAlign = HorizontalAlignment.Right
                lsw.Columns(15).Width = 250
                lsw.Columns(16).Width = 300
                lsw.Columns(17).Width = 0
                lsw.Columns(18).Width = 0
                lsw.Columns(19).Width = 0
                lsw.Columns(20).Width = 0
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function



    Public Shared Function fn_CajasFuertes_LlenarListaSemaforo(ByVal Status As String, ByVal Id_Cliente As Integer) As DataTable
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_Get_Resporte_Semaforo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Try


            Return Cn_Datos.EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
    End Function


    Public Shared Function fn_CajasFuertes_PorDia_Semana(ByRef lsw As cp_Listview, ByVal Status As String, ByVal Id_Cliente As Integer, ByVal fechaInicio As String, ByVal FechaFin As String) As Boolean
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_GetSemana", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.VarChar, FechaFin)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.VarChar, fechaInicio)

        Try
            lsw.Actualizar(Cmd, "Id_CajaFuerte")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CajasFuertes_PorDia(ByRef lsw As cp_Listview, ByVal Status As String, ByVal Id_Cliente As Integer, ByVal fechaInicio As String) As Boolean
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_GetDia", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.VarChar, fechaInicio)

        Try
            lsw.Actualizar(Cmd, "Id_CajaFuerte")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CajasFuertes_Nuevo(ByVal Id_CajaFuerteT As String, ByVal Marca As String, ByVal Serie As String, ByVal Id_Proveedor As Integer,
                                                 ByVal Fecha_Compra As Date, ByVal Fecha_Fabricacion As Date, ByVal Combinacion As String, ByVal Observaciones As String,
                                                 ByVal Nueva As String, ByVal TipoCaja As Integer, ByVal Status As String, ByVal Id_Cliente As Integer, ByVal TipoReceptor As String,
                                                 ByVal TipoDial As String, ByVal TipoChapa As String, ByVal UtilizaCombinacion As String) As Boolean
        'Aqui se inserta un nuevo elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertes_Create")
        Dim Id As Integer = 0

        'Cn_Datos.Crea_Parametro(Cmd, "@Clave_CajaFuerte", SqlDbType.VarChar, Clave_CajaFuerte)
        Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.VarChar, Id_CajaFuerteT)
        Crea_Parametro(Cmd, "@Marca", SqlDbType.VarChar, Marca)
        Crea_Parametro(Cmd, "@Serie", SqlDbType.VarChar, Serie)
        Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Crea_Parametro(Cmd, "@Fecha_Compra", SqlDbType.Date, Fecha_Compra)
        Crea_Parametro(Cmd, "@Fecha_Fabricacion", SqlDbType.Date, Fecha_Fabricacion)
        Crea_Parametro(Cmd, "@Combinacion", SqlDbType.VarChar, Combinacion)
        Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(Cmd, "@Nueva", SqlDbType.VarChar, Nueva)
        Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, "N")
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@TipoReceptor", SqlDbType.Int, TipoReceptor)
        Crea_Parametro(Cmd, "@TipoDial", SqlDbType.Int, TipoDial)
        Crea_Parametro(Cmd, "@TipoChapa", SqlDbType.Int, TipoChapa)
        Crea_Parametro(Cmd, "@Utiliza_Combinacion", SqlDbType.VarChar, UtilizaCombinacion)

        Try
            Id = EjecutarScalarT(Cmd)
            If TipoCaja = 1 Then
                Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesT_Inventario")
                Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.Int, Id_CajaFuerteT)
                Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, 1)
                EjecutarNonQueryT(Cmd)
            End If
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
    End Function
    ''Obtiene egistro de el cambio de combinacion (seguridad interna)
    Public Shared Function fn_CajasFuertes_LogCombinaciones_Get(ByVal Id_CajaFuerte As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_LogCombinaciones_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
        Try
            Return EjecutaConsulta(cmd).Rows(0)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    'Guarda el registro de el cambio de combinacion (seguridad interna)
    Public Shared Function fn_CajasFuertes_LogCombinaciones(ByVal Id As String, ByVal Log As String)
        'Aqui se actualiza un elemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_LogCombinaciones_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@LogCombinacion", SqlDbType.VarChar, Log)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function
    Public Shared Function fn_CajasFuertes_Actualizar(ByVal Id As String, ByVal Id_CajaFuerteT As String, ByVal Marca As String, ByVal Serie As String, ByVal Id_Proveedor As Integer, ByVal Fecha_Compra As Date,
                                                      ByVal Fecha_Fabricacion As Date, ByVal Combinacion As String, ByVal Observaciones As String, ByVal Nueva As String, ByVal CombinacionCliente As String,
                                                      ByVal Fin_Renta As Date, ByVal Renta As Boolean, ByVal Id_Cliente As Integer,
                                                      ByVal TipoReceptor As String, ByVal TipoDial As String, ByVal TipoChapa As String,
                                                      ByVal UtilizaCombinacion As String) As Boolean
        'Aqui se actualiza un elemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertes_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.VarChar, Id_CajaFuerteT)
        Cn_Datos.Crea_Parametro(Cmd, "@Marca", SqlDbType.VarChar, Marca)
        Cn_Datos.Crea_Parametro(Cmd, "@Serie", SqlDbType.VarChar, Serie)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Compra", SqlDbType.Date, Fecha_Compra)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Fabricacion", SqlDbType.Date, Fecha_Fabricacion)
        Cn_Datos.Crea_Parametro(Cmd, "@Combinacion", SqlDbType.VarChar, Combinacion)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
        Cn_Datos.Crea_Parametro(Cmd, "@Nueva", SqlDbType.VarChar, Nueva)
        Cn_Datos.Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, CombinacionCliente)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Cn_Datos.Crea_Parametro(Cmd, "@TipoReceptor", SqlDbType.Int, TipoReceptor)
        Cn_Datos.Crea_Parametro(Cmd, "@TipoDial", SqlDbType.Int, TipoDial)
        Cn_Datos.Crea_Parametro(Cmd, "@TipoChapa", SqlDbType.Int, TipoChapa)
        Cn_Datos.Crea_Parametro(Cmd, "@Utiliza_Combinacion", SqlDbType.VarChar, UtilizaCombinacion)


        If Renta Then Cn_Datos.Crea_Parametro(Cmd, "@Fin_Renta", SqlDbType.Date, Fin_Renta)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertes_Read(ByVal Id_CajaFuerte As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)

        Try
            Return EjecutaConsulta(cmd).Rows(0)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertes_Read() As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerte", SqlDbType.Int, 0)

        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertes_UltimaClave() As DataRow
        Try
            Dim Cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_ReadUltimo", CommandType.StoredProcedure, Crea_ConexionSTD)
            Dim dt As DataTable = EjecutaConsulta(Cmd)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_LlenarLista(ByRef lsw As cp_Listview, ByVal Status As String) As Boolean

        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesT_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsw.Actualizar(Cmd, "Id_CajaFuerteT")
            lsw.Columns(2).TextAlign = HorizontalAlignment.Right
            lsw.Columns(3).TextAlign = HorizontalAlignment.Right
            lsw.Columns(4).TextAlign = HorizontalAlignment.Right
            lsw.Columns(5).TextAlign = HorizontalAlignment.Right
            lsw.Columns(6).TextAlign = HorizontalAlignment.Right
            lsw.Columns(7).TextAlign = HorizontalAlignment.Right
            lsw.Columns(8).TextAlign = HorizontalAlignment.Right
            lsw.Columns(9).TextAlign = HorizontalAlignment.Right
            lsw.Columns(10).TextAlign = HorizontalAlignment.Right

            lsw.Columns(10).Width = 110
            lsw.Columns(11).Width = 110
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_Nuevo(ByVal Clave_CajaFuerteT As String, ByVal AltoE As Integer, ByVal AnchoE As Integer, ByVal FondoE As Integer,
                                                  ByVal AltoI As Integer, ByVal AnchoI As Integer, ByVal FondoI As Integer, ByVal StockMinimo As Integer,
                                                  ByVal Peso As Decimal, ByVal Modelo As String, ByVal Tipo As Integer) As Boolean
        'Aqui se inserta un nuevo elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesT_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Clave_CajaFuerteT", SqlDbType.VarChar, Clave_CajaFuerteT)
        Cn_Datos.Crea_Parametro(Cmd, "@AltoE", SqlDbType.Int, AltoE)
        Cn_Datos.Crea_Parametro(Cmd, "@AnchoE", SqlDbType.Int, AnchoE)
        Cn_Datos.Crea_Parametro(Cmd, "@FondoE", SqlDbType.Int, FondoE)
        Cn_Datos.Crea_Parametro(Cmd, "@AltoI", SqlDbType.Int, AltoI)
        Cn_Datos.Crea_Parametro(Cmd, "@AnchoI", SqlDbType.Int, AnchoI)
        Cn_Datos.Crea_Parametro(Cmd, "@FondoI", SqlDbType.Int, FondoI)
        Cn_Datos.Crea_Parametro(Cmd, "@Stock_Minimo", SqlDbType.Int, StockMinimo)
        Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, 0)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Cn_Datos.Crea_Parametro(Cmd, "@Peso", SqlDbType.Decimal, Peso)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.VarChar, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, Tipo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_Actualizar(ByVal Id As Integer, ByVal Clave_CajaFuerteT As String, ByVal AltoE As Integer, ByVal AnchoE As Integer, ByVal FondoE As Integer, ByVal AltoI As Integer, ByVal AnchoI As Integer, ByVal FondoI As Integer, ByVal Stock_Minimo As Integer, ByVal Existencia As Integer, ByVal Peso As Decimal, ByVal Modelo As String) As Boolean
        'Aqui se actualiza un elemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesT_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_CajaFuerteT", SqlDbType.VarChar, Clave_CajaFuerteT)
        Cn_Datos.Crea_Parametro(Cmd, "@AltoE", SqlDbType.Int, AltoE)
        Cn_Datos.Crea_Parametro(Cmd, "@AnchoE", SqlDbType.Int, AnchoE)
        Cn_Datos.Crea_Parametro(Cmd, "@FondoE", SqlDbType.Int, FondoE)
        Cn_Datos.Crea_Parametro(Cmd, "@AltoI", SqlDbType.Int, AltoI)
        Cn_Datos.Crea_Parametro(Cmd, "@AnchoI", SqlDbType.Int, AnchoI)
        Cn_Datos.Crea_Parametro(Cmd, "@FondoI", SqlDbType.Int, FondoI)
        Cn_Datos.Crea_Parametro(Cmd, "@Stock_Minimo", SqlDbType.Int, Stock_Minimo)
        Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, Existencia)
        Cn_Datos.Crea_Parametro(Cmd, "@Peso", SqlDbType.Decimal, Peso)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.VarChar, Modelo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_Baja(ByVal Id As Integer, ByVal Status As String) As Boolean
        'Aqui se actualiza un elemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesT_Baja", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_Reingreso(ByVal Id As Integer, ByVal Status As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesT_Reingreso", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Reingreso", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_Read(ByVal Id_CajaFuerteT As Integer) As DataRow
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesT_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerteT", SqlDbType.Int, Id_CajaFuerteT)

        Try
            Dt = EjecutaConsulta(cmd)

            If Dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertesT_Read() As DataTable
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesT_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerteT", SqlDbType.Int, 0)

        Try
            Dt = EjecutaConsulta(cmd)

            If Dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Dt
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertesBaja_Baja(ByVal Id_CajaFuerte As Integer, ByVal Id_MotivoB As Integer, ByVal Fecha_Baja As Date, ByVal Observaciones As String, ByVal Id_CajaFuerteT As Integer, ByRef Id_CajaFuerteB As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesBaja_Create")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Baja", SqlDbType.Date, Fecha_Baja)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)

        Try
            Id_CajaFuerteB = Cn_Datos.EjecutarScalarT(Cmd)
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesT_Inventario")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.Int, Id_CajaFuerteT)
            Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, -1)

            Cn_Datos.EjecutarNonQueryT(Cmd)
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesBaja_ReadUltimo(ByVal Id_CajaFuerte As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesBajas_ReadUltimo", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)

        Try
            Return EjecutaConsulta(Cmd).Rows(0)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaCajasFuertes_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Proveedor As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_GetConsulta", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(cmd, "Id_CajaFuerte")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            lsv.Columns(10).Width = 150
            lsv.Columns(11).Width = 60
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaCajasFuertesEdad_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Proveedor As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal FechaTodos As Boolean, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_GetEdad", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        If Not FechaTodos Then Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(cmd, "Id_CajaFuerte")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            lsv.Columns(10).Width = 150
            lsv.Columns(11).Width = 60
            lsv.Columns(12).Width = 200
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertes_ReadD(ByVal Id_CajaFuerte As Integer) As DataRow
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertes_ReadD", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)

        Try
            Dt = EjecutaConsulta(cmd)
            If Dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    'Guarda Nueva Venta Y/O RENTADA 13/sep/2012
    Public Shared Function fn_CajasFuertesMov_Nuevo(ByVal Id_CajaFuerte As Integer, ByVal Fecha As Date, ByVal Tipo_Mov As Integer, ByVal Id_Cliente As Integer, ByVal Observaciones As String,
                                                    ByVal Instalacion As String, ByVal ManejoCombinacion As String, ByVal Id_Contacto As Integer, ByVal Cita As Boolean, ByVal FechaCita As Date,
                                                    ByVal HoraCita As String, ByVal FinRentaNull As Boolean, ByVal Fin_Renta As Date, ByVal NumeroCombinacion As String, ByVal Id_CS_Motivo As Integer,
                                                    ByVal Id_CS_Instalacion As Integer, ByVal Renta_Venta As Integer) As Integer
        Dim Id_CajaFuerteMov As Integer = 0
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand

        Try
            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesMov_Create")
            For h As Byte = 0 To 1 'Recorte Codigo metitiendolo en unFor
                If h = 0 Or Id_CS_Instalacion > 0 Then
                    Cmd.Parameters.Clear()
                    Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
                    Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
                    Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
                    Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Crea_Parametro(Cmd, "@Instalacion", SqlDbType.VarChar, Instalacion)
                    Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, ManejoCombinacion)
                    Crea_Parametro(Cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                    If h = 0 Then
                        Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.Int, Tipo_Mov)
                        Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS_Motivo)
                        If Cita Then
                            Crea_Parametro(Cmd, "@FechaCita", SqlDbType.Date, FechaCita)
                            Crea_Parametro(Cmd, "@HoraCita", SqlDbType.Time, Microsoft.VisualBasic.Left(HoraCita, 5))
                        End If
                        If Tipo_Mov = 2 AndAlso FinRentaNull = False Then '
                            Crea_Parametro(Cmd, "@Fin_Renta", SqlDbType.Date, Fin_Renta)
                        End If
                        If Tipo_Mov = 4 OrElse Tipo_Mov = 7 Then
                            Crea_Parametro(Cmd, "@Combinacion", SqlDbType.VarChar, NumeroCombinacion)
                        End If

                        Id_CajaFuerteMov = EjecutarScalarT(Cmd)
                    End If
                End If
                '--------Se crea un movimiento nuevo tipo 8 para separar la Instalación.
                If h = 1 AndAlso Id_CS_Instalacion > 0 Then
                    Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.Int, 8) 'tipoMOv=8 fijo
                    Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS_Instalacion)
                    Crea_Parametro(Cmd, "@Id_MovDepende", SqlDbType.Int, Id_CajaFuerteMov)
                    EjecutarNonQueryT(Cmd)
                End If

            Next
            '-------------------------

            If Renta_Venta > 0 Then
                Dim cmd2 As SqlCommand = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesMov_ActualIdMovDepende")
                Crea_Parametro(cmd2, "@Id_CajaFuerteMov", SqlDbType.Int, Renta_Venta)
                Crea_Parametro(cmd2, "@Id_MovDepende", SqlDbType.Int, Id_CajaFuerteMov)
                EjecutarNonQueryT(cmd2)

            End If
            '-----------------------------------
            'mandar tipo de mov=3finde renta
            If Tipo_Mov = 1 OrElse Tipo_Mov = 2 OrElse Tipo_Mov = 3 OrElse Tipo_Mov = 9 Then
                'Se verifica si es venta, renta o retiro para dejar pendiente el movimiento hasta que se valide.
                'Si es Mantenimiento a una caja fuerte sin cliente se pone status M y al validar el Movimiento se regresará a A
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertes_Status")
                Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
                Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                Select Case Tipo_Mov
                    Case 1
                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "PV")
                    Case 2
                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "PR")
                    Case 3
                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RR")
                    Case 9
                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "M")
                End Select
                EjecutarNonQueryT(Cmd)
            End If

            Trans.Commit()
            Cnn.Dispose()
            Return Id_CajaFuerteMov
        Catch ex As Exception
            Trans.Rollback()
            Cnn.Dispose()
            TrataEx(ex)
            Return 0
        End Try
    End Function
    Public Shared Function fn_CajasFuertesMov_ActualizarVendida(ByVal Id_CajaFuerteMov As Integer, ByVal Fecha As Date, ByVal Tipo_Mov As Integer,
                                                                ByVal Id_Cliente As Integer, ByVal Observaciones As String,
                                                                ByVal Instalacion As String, ByVal ManejoCombinacion As String, ByVal Id_Contacto As Integer,
                                                                ByVal Cita As Boolean, ByVal FechaCita As Date,
                                                                ByVal HoraCita As String, ByVal FinRentaNull As Boolean, ByVal Fin_Renta As Date,
                                                                ByVal NumeroCombinacion As String, ByVal Id_CS_Motivo As Integer,
                                                                ByVal Id_CS_Instalacion As Integer, ByVal Id_CajaFuerte As Integer,
                                                                ByVal Precio_Servicio As Decimal, ByVal Precio_InsDes As Decimal) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tran As SqlTransaction = crear_Trans(Cnn)

        Try

            Dim Cmd As SqlClient.SqlCommand = Crea_ComandoT(Cnn, Tran, CommandType.StoredProcedure, "Cat_CajasFuertesVendidas_Update")
            Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
            'Crea_Parametro(cmd, "@Venta_FinServicio ", SqlDbType.Date, Fecha)
            EjecutarNonQueryT(Cmd)
            Tran.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            Tran.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CajasFuertesMov_Actualizar(ByVal Id_CajaFuerteMov As Integer, ByVal Fecha As Date, ByVal Tipo_Mov As Integer, ByVal Id_Cliente As Integer, ByVal Observaciones As String,
                                                         ByVal Instalacion As String, ByVal ManejoCombinacion As String, ByVal Id_Contacto As Integer, ByVal Cita As Boolean, ByVal FechaCita As Date,
                                                         ByVal HoraCita As String, ByVal FinRentaNull As Boolean, ByVal Fin_Renta As Date, ByVal NumeroCombinacion As String, ByVal Id_CS_Motivo As Integer,
                                                         ByVal Id_CS_Instalacion As Integer, ByVal Id_CajaFuerte As Integer, ByVal Precio_Servicio As Decimal, ByVal Precio_InsDes As Decimal) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tran As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim Cmd As SqlClient.SqlCommand = Crea_ComandoT(Cnn, Tran, CommandType.StoredProcedure, "Cat_CajasFuertesMov_Update")
            Crea_Parametro(Cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
            Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
            Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.Int, Tipo_Mov)
            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
            Crea_Parametro(Cmd, "@Instalacion", SqlDbType.VarChar, Instalacion)
            Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, ManejoCombinacion)
            Crea_Parametro(Cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
            Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS_Motivo)
            Crea_Parametro(Cmd, "@Precio", SqlDbType.Money, Precio_Servicio)
            If Cita Then
                Crea_Parametro(Cmd, "@FechaCita", SqlDbType.Date, FechaCita)
                Crea_Parametro(Cmd, "@HoraCita", SqlDbType.Time, Microsoft.VisualBasic.Left(HoraCita, 5))
            End If
            If Tipo_Mov = 2 And FinRentaNull = False Then
                Crea_Parametro(Cmd, "@Fin_Renta", SqlDbType.Date, Fin_Renta)
            End If
            If NumeroCombinacion <> "" Then
                Crea_Parametro(Cmd, "@Combinacion", SqlDbType.VarChar, NumeroCombinacion)
            End If

            EjecutarNonQueryT(Cmd)

            'Caso que sucede cuando es un Movimiento que implica agregar un movimiento dependiente
            'es para agregar Instalación, Desinstalación o Ambos
            If Id_CS_Instalacion > 0 Then
                Dim Modificado As Integer
                Cmd = Crea_ComandoT(Cnn, Tran, CommandType.StoredProcedure, "Cat_CajasFuertesMov_UpdateDependiente")
                Crea_Parametro(Cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
                Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
                Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.Int, 8)
                Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
                Crea_Parametro(Cmd, "@Instalacion", SqlDbType.VarChar, Instalacion)
                Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, ManejoCombinacion)
                Crea_Parametro(Cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS_Instalacion)
                Crea_Parametro(Cmd, "@Precio", SqlDbType.Money, Precio_InsDes)
                If Cita Then
                    Crea_Parametro(Cmd, "@FechaCita", SqlDbType.Date, FechaCita)
                    Crea_Parametro(Cmd, "@HoraCita", SqlDbType.Time, Microsoft.VisualBasic.Left(HoraCita, 5))
                End If
                If Tipo_Mov = 2 And FinRentaNull = False Then
                    Crea_Parametro(Cmd, "@Fin_Renta", SqlDbType.Date, Fin_Renta)
                End If
                If NumeroCombinacion <> "" Then
                    Crea_Parametro(Cmd, "@Combinacion", SqlDbType.VarChar, NumeroCombinacion)
                End If
                Modificado = EjecutarNonQueryT(Cmd)

                If Modificado = 0 Then
                    Cmd = Crea_ComandoT(Cnn, Tran, CommandType.StoredProcedure, "Cat_CajasFuertesMov_Create")
                    Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
                    Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
                    Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.Int, 8)
                    Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
                    Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Crea_Parametro(Cmd, "@Instalacion", SqlDbType.VarChar, Instalacion)
                    Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, ManejoCombinacion)
                    Crea_Parametro(Cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
                    Crea_Parametro(Cmd, "@Id_MovDepende", SqlDbType.Int, Id_CajaFuerteMov)
                    Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS_Instalacion)
                    EjecutarNonQueryT(Cmd)
                End If
            Else
                'Se cancela el Dependiente cuando se actualiza un movimiento y se esta omitiendo la Instalación, Desinstalación o Ambos
                Cmd = Crea_ComandoT(Cnn, Tran, CommandType.StoredProcedure, "Cat_CajasFuertesMov_StatusDependiente")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
                EjecutarNonQueryT(Cmd)
            End If

            Tran.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            Tran.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaCajasFuertesM_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_CajaFuerte As Integer, ByVal Id_Cliente As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal TipoMov As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_GetConsulta", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@TipoMov", SqlDbType.Int, TipoMov)

        Try
            lsv.Actualizar(cmd, "Id_CajaFuerteMov")
            lsv.Columns(10).Width = 150
            lsv.Columns(11).Width = 0
            lsv.Columns(12).Width = 0
            lsv.Columns(13).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesMov_Read(ByVal Id_CajaFuerteMov As Integer) As DataRow
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)

        Try
            Dt = EjecutaConsulta(cmd)
            If Dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertesMov_ReadDependiente(ByVal Id_CajaFuerteMov As Integer) As DataRow
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_GetDependiente", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)

        Try
            Dt = EjecutaConsulta(cmd)
            If Dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CajasFuertesMov_Baja(ByVal Id_CajaFuerteMov As Integer, ByVal TipoMov As String, ByVal Id_CajaFuerte As Integer, ByVal Id_cliente As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand
        Try
            'esta acción tanto en cancelar y cambiar status se hace si el movimiento no esta validado.
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesMov_Cancelar")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            If TipoMov = "VENTA" OrElse TipoMov = "RENTA" OrElse TipoMov = "FIN DE RENTA" OrElse TipoMov = "MANTENIMIENTO INTERNO" Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertes_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Id_CajaFuerte)
                ' Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, 0)
                If TipoMov = "FIN DE RENTA" Then
                    'Si se estaba haciendo un movimiento de tipo Retiro significa que venía de una Renta de un Cliente por consiguiente
                    'al cancelar el movimiento regresa el status a "R" que es Rentada
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "R")
                Else
                    'En cualquier otro caso la caja fuerte quedaría con el status de activa
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                End If
                Cn_Datos.EjecutarNonQueryT(Cmd)
            End If

            Trans.Commit()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            Cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Imprimir_LlenarReciboMovimiento(ByRef Tbl As DataTable, ByVal Id_CajaFuerteMov As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_GetRecibo", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_Imprimir_LlenarCartaCombinacion(ByRef Tbl As DataTable, ByVal Id_CajaFuerteMov As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_ReciboCombinacion", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_Imprimir_LlenarReciboBajaCajaFuerte(ByRef Tbl As DataTable, ByVal Id_CajaFuerteB As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesBajas_Recibo", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaFuerteB", SqlDbType.Int, Id_CajaFuerteB)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_CajasFuertesT_CuentaxTipo(ByVal Tipo As Integer, ByVal Status As String) As Integer
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_CajasFuertesT_GetContar", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.TinyInt, Tipo)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Dim Cantidad As Integer = EjecutarScalar(cmd)

            Return Cantidad
        Catch ex As Exception
            TrataEx(ex, False)
            Return -1
        End Try
    End Function


#End Region

#Region "Validar Movimiento de Cajas Fuertes"

    Public Shared Function fn_CajasFuertesValidar_LlenarLista(ByRef lsw As cp_Listview) As Boolean
        Try
            Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesMov_GetValidar", CommandType.StoredProcedure, Crea_ConexionSTD)
            lsw.Actualizar(Cmd, "Id_CajaFuerteMov")
            lsw.Columns(4).TextAlign = HorizontalAlignment.Right
            lsw.Columns(8).TextAlign = HorizontalAlignment.Right
            lsw.Columns(9).TextAlign = HorizontalAlignment.Right
            lsw.Columns(10).Width = 200 'Columna Empleado
            lsw.Columns(11).Width = 140 'Columna CombinacionCliente (Si o No)
            lsw.Columns(12).Width = 0   'Columna Combinacion

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesValidar_Status(ByVal Id_CajaFuerteMov As Integer, ByVal Observaciones_Valida As String, ByVal Combinacion As String, ByVal Fecha_Real As Date, ByVal Hora_Real As String) As Boolean
        Dim Dt_CajasFuertesMov As DataTable = Nothing
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand
        Try
            'Consulta para Traer la información del Movimiento y poder actualizar a la Caja Fuerte y Tipo de Caja Fuerte
            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesMov_Read")

            Crea_Parametro(Cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
            Dt_CajasFuertesMov = EjecutaConsultaT(Cmd)

            If Dt_CajasFuertesMov IsNot Nothing AndAlso Dt_CajasFuertesMov.Rows.Count > 0 Then
                'Cambiar el Status a Validado del Movimiento
                'guardar la combinación nueva cuando sea movimiento de combinación
                'y ponerle la hora y fecha real de movimiento
                Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesMov_Validar")
                Crea_Parametro(Cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
                Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Dt_CajasFuertesMov(0)("Id_CajaFuerte"))
                Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(Cmd, "@Observaciones_Valida", SqlDbType.Text, Observaciones_Valida)
                If Dt_CajasFuertesMov(0)("Tipo_Mov") = 4 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 7 Then
                    Crea_Parametro(Cmd, "@Combinacion", SqlDbType.Text, Combinacion)
                End If
                Crea_Parametro(Cmd, "@Fecha_Real", SqlDbType.Date, Fecha_Real)
                Crea_Parametro(Cmd, "@Hora_Real", SqlDbType.Time, Microsoft.VisualBasic.Left(Hora_Real, 5))
                'Cuando sea Venta o Renta su movimiento queda con Vigencia S de que todavía no ha sido cobrado
                'Si es un Retiro se debe de poner N
                If Dt_CajasFuertesMov(0)("Tipo_Mov") = 1 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 2 Then
                    Crea_Parametro(Cmd, "@Vigente", SqlDbType.VarChar, "S")
                ElseIf Dt_CajasFuertesMov(0)("Tipo_Mov") = 3 Then
                    Crea_Parametro(Cmd, "@Vigente", SqlDbType.VarChar, "N")
                    Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.Int, 3)
                    Crea_Parametro(Cmd, "Id_Cliente", SqlDbType.Int, Dt_CajasFuertesMov(0)("Id_Cliente")) 'nuevo19/octubre 2012
                End If

                EjecutarNonQueryT(Cmd)

                'Si es Venta o Renta que se modifique el Status de PV o PR o RR a V o R o A
                'Si es un Mantenimiento Interno (es tipo mov = 9) se cambie Status de M a A
                If Dt_CajasFuertesMov(0)("Tipo_Mov") = 1 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 2 OrElse
                Dt_CajasFuertesMov(0)("Tipo_Mov") = 3 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 9 Then
                    Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertes_Status")
                    Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Dt_CajasFuertesMov(0)("Id_CajaFuerte"))
                    Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Dt_CajasFuertesMov(0)("Id_Cliente"))
                    Select Case Dt_CajasFuertesMov(0)("Tipo_Mov")
                        Case 1
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "V")
                        Case 2
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "R")
                        Case 3, 9
                            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    End Select
                    EjecutarNonQueryT(Cmd)
                End If

                'Si es Venta, Renta, Retiro, Cambio de Combinación o Cambio de Manejo de Combinación
                If Dt_CajasFuertesMov(0)("Tipo_Mov") = 1 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 2 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 3 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 4 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 7 Then
                    Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertes_UpdateVarios")
                    Crea_Parametro(Cmd, "@Id_CajaFuerte", SqlDbType.Int, Dt_CajasFuertesMov(0)("Id_CajaFuerte"))

                    If Dt_CajasFuertesMov(0)("Tipo_Mov") = 3 Then
                        'Si es un Retiro se modifica el manejo de combinación a No, fin renta será la fecha real y deja de ser nueva la caja fuerte.
                        Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, "N")
                        Crea_Parametro(Cmd, "@Fin_Renta", SqlDbType.Date, Fecha_Real)
                        Crea_Parametro(Cmd, "@Nueva", SqlDbType.VarChar, "N")
                    Else
                        'Dejar el valor del manejo de combinación que tenía.
                        Crea_Parametro(Cmd, "@CombinacionCliente", SqlDbType.VarChar, Dt_CajasFuertesMov(0)("CombinacionCliente"))
                    End If

                    If Dt_CajasFuertesMov(0)("Tipo_Mov") = 2 AndAlso Dt_CajasFuertesMov(0)("FechaRetiro") <> "" Then
                        'Ponerle la posible fecha de fin renta cuando sea un Movimiento de Renta
                        Crea_Parametro(Cmd, "@Fin_Renta", SqlDbType.Date, Dt_CajasFuertesMov(0)("FechaRetiro"))
                    End If

                    If Dt_CajasFuertesMov(0)("Tipo_Mov") = 4 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 7 Then
                        'Cambiar la Combinación de la Caja Fuerte cuando si el Movimiento es
                        'Cambio de Combinación o Cambio de Control de Combinación
                        Crea_Parametro(Cmd, "@Combinacion", SqlDbType.VarChar, Combinacion)
                    End If
                    EjecutarNonQueryT(Cmd)
                End If

                'Aumentar o Disminuir el Inventario mostrado en Tipos de Caja Fuerte
                If Dt_CajasFuertesMov(0)("Tipo_Mov") = 1 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 2 OrElse Dt_CajasFuertesMov(0)("Tipo_Mov") = 3 Then
                    Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_CajasFuertesT_Inventario")
                    Crea_Parametro(Cmd, "@Id_CajaFuerteT", SqlDbType.Int, Dt_CajasFuertesMov(0)("Id_CajaFuerteT"))
                    Select Case Dt_CajasFuertesMov(0)("Tipo_Mov")
                        Case 1, 2
                            Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, -1)
                        Case 3
                            Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, 1)
                    End Select
                    EjecutarNonQueryT(Cmd)
                End If
            Else
                Trans.Rollback()
                Cnn.Close()
                Return False
            End If

            Trans.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesValidar_CargarArreglo(ByVal Id_CajaFuerteMov As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMovI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ReDim Arreglo_Archivo(dt.Rows.Count)
                Dim Contador As Integer = 0
                For Each Elemento As DataRow In dt.Rows
                    Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_CajaFuerteMovI")
                    Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                    Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                    Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                    Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("Descripcion")
                    Arreglo_Archivo(Contador).Extension_Archivo = Nothing
                    Arreglo_Archivo(Contador).Adicional_Archivo = Nothing
                    Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                    Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                    Contador += 1
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CajasFuertesValidar_Actualizar(ByVal Id_CajaFuerteMov As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                    Continue For

                ElseIf Arreglo_Archivo(ILocal).Id_Archivo = Nothing Then
                    'Crear un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesMovI_Create")
                    Crea_Parametro(cmd, "@Id_CajaFuerteMov", SqlDbType.Int, Id_CajaFuerteMov)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                ElseIf Arreglo_Archivo(ILocal).Objeto_Archivo IsNot Nothing Then
                    'Actualizar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesMovI_Update")
                    Crea_Parametro(cmd, "@Id_CajaFuerteMovI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)

                Else
                    'Eliminar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesMovI_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_CajaFuerteMovI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)
                    EjecutarNonQueryT(cmd)
                    Continue For
                End If

                Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Nombre_Archivo, False)
                Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, Arreglo_Archivo(ILocal).MimeType_Archivo)
                Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                EjecutarNonQueryT(cmd)
            Next

            Tr.Commit()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Caja Fuerte - Acta de Inspección"

    Public Shared Function fn_ActaInspeccion_Create(ByVal FechaVisita As Date, ByVal HoraVisita As String, ByVal Id_Cliente As Integer, ByVal NombreComercial As String,
                                                    ByVal NombreFiscal As String, ByVal DireccionComercial As String, ByVal Instrucciones As String) As Integer
        Dim Id_Acta As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesInspeccion_Create")
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Fecha_Programada", SqlDbType.Date, FechaVisita)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Programada", SqlDbType.Time, HoraVisita)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(cmd, "@Nombre_Fiscal", SqlDbType.VarChar, NombreFiscal)
            Cn_Datos.Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, NombreComercial)
            Cn_Datos.Crea_Parametro(cmd, "@Domicilio_Comercial", SqlDbType.VarChar, DireccionComercial)
            Cn_Datos.Crea_Parametro(cmd, "@Instrucciones", SqlDbType.VarChar, Instrucciones)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            Id_Acta = Cn_Datos.EjecutarScalarT(cmd)
            Tr.Commit()
            Return Id_Acta
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Cliente_Direccion(ByVal Id_Cliente As Integer) As DataRow
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_Read2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Validar Acta de Inspección de Caja Fuerte"

    Public Shared Function fn_ActaInspeccion_Validar(ByVal Id_Inspeccion As Integer, ByVal FechaVisita As Date, ByVal HoraVisita As String, ByVal PersonaRecibio As String,
                                                    ByVal UbicacionSugerida As String, ByVal UbicacionSugeridaD As String, ByVal Ventajas As String, ByVal Desventajas As String,
                                                    ByVal NotasAdicionales As String, ByVal Id_Empleado As Integer, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer,
                                                    ByVal Id_JefeSeguridad As Integer, ByVal ContactoCita As String, ByVal FechaCita As Date, ByVal HorasCita As String,
                                                    ByVal Piso As String, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Cat_CajasFuertesInspeccion_Valida", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)
            Cn_Datos.Crea_Parametro(cmd, "@Fecha_Inspeccion", SqlDbType.Date, FechaVisita)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Inspeccion", SqlDbType.Time, HoraVisita)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Inspeccion", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(cmd, "@Persona_RecibeCliente", SqlDbType.VarChar, PersonaRecibio)
            Cn_Datos.Crea_Parametro(cmd, "@Ubicacion_Sugerida", SqlDbType.VarChar, UbicacionSugerida)
            Cn_Datos.Crea_Parametro(cmd, "@Ubicacion_SugeridaD", SqlDbType.VarChar, UbicacionSugeridaD)
            Cn_Datos.Crea_Parametro(cmd, "@Ventajas", SqlDbType.VarChar, Ventajas)
            Cn_Datos.Crea_Parametro(cmd, "@Desventajas", SqlDbType.VarChar, Desventajas)
            Cn_Datos.Crea_Parametro(cmd, "@Notas_Adicionales", SqlDbType.VarChar, NotasAdicionales)
            Cn_Datos.Crea_Parametro(cmd, "@Jefe_Seguridad", SqlDbType.Int, Id_JefeSeguridad)
            Cn_Datos.Crea_Parametro(cmd, "@Piso", SqlDbType.VarChar, Piso)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            If ContactoCita <> "" Then
                Cn_Datos.Crea_Parametro(cmd, "@Contacto_Cita", SqlDbType.VarChar, ContactoCita)
                Cn_Datos.Crea_Parametro(cmd, "@Fecha_Cita", SqlDbType.Date, FechaCita)
                Cn_Datos.Crea_Parametro(cmd, "@Horas_Cita", SqlDbType.VarChar, HorasCita)
            End If
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Return Cn_Datos.EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ActaInspeccion_Update(ByVal Id_Inspeccion As Integer, ByVal FechaVisita As Date, ByVal HoraVisita As String, ByVal PersonaRecibio As String,
                                                    ByVal UbicacionSugerida As String, ByVal UbicacionSugeridaD As String, ByVal Ventajas As String, ByVal Desventajas As String,
                                                    ByVal NotasAdicionales As String, ByVal Id_Empleado As Integer, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer,
                                                    ByVal Id_JefeSeguridad As Integer, ByVal ContactoCita As String, ByVal FechaCita As Date, ByVal HorasCita As String,
                                                    ByVal Piso As String) As Boolean
        Dim cmd As SqlCommand
        Try
            'No se le mandan los parametros de validación: Usuario_Valida, Estacion_Valida, Status
            cmd = Crea_Comando("Cat_CajasFuertesInspeccion_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)
            Cn_Datos.Crea_Parametro(cmd, "@Fecha_Inspeccion", SqlDbType.Date, FechaVisita)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Inspeccion", SqlDbType.Time, HoraVisita)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Inspeccion", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(cmd, "@Persona_RecibeCliente", SqlDbType.VarChar, PersonaRecibio)
            Cn_Datos.Crea_Parametro(cmd, "@Ubicacion_Sugerida", SqlDbType.VarChar, UbicacionSugerida)
            Cn_Datos.Crea_Parametro(cmd, "@Ubicacion_SugeridaD", SqlDbType.VarChar, UbicacionSugeridaD)
            Cn_Datos.Crea_Parametro(cmd, "@Ventajas", SqlDbType.VarChar, Ventajas)
            Cn_Datos.Crea_Parametro(cmd, "@Desventajas", SqlDbType.VarChar, Desventajas)
            Cn_Datos.Crea_Parametro(cmd, "@Notas_Adicionales", SqlDbType.VarChar, NotasAdicionales)
            Cn_Datos.Crea_Parametro(cmd, "@Jefe_Seguridad", SqlDbType.Int, Id_JefeSeguridad)
            Cn_Datos.Crea_Parametro(cmd, "@Piso", SqlDbType.VarChar, Piso)
            If ContactoCita <> "" Then
                Cn_Datos.Crea_Parametro(cmd, "@Contacto_Cita", SqlDbType.VarChar, ContactoCita)
                Cn_Datos.Crea_Parametro(cmd, "@Fecha_Cita", SqlDbType.Date, FechaCita)
                Cn_Datos.Crea_Parametro(cmd, "@Horas_Cita", SqlDbType.VarChar, HorasCita)
            End If

            Return Cn_Datos.EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Inspeccion_Datos(ByVal Id_Inspeccion As Integer) As DataRow
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesInspeccion_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Empleado_Datos(ByVal Id_Empleado As Integer) As DataRow
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_InspeccionImagenes_Actualizar(ByVal Id_Inspeccion As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                    Continue For
                ElseIf Arreglo_Archivo(ILocal).Id_Archivo = Nothing Then
                    'Nuevo Registro
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesInspeccionI_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                ElseIf Arreglo_Archivo(ILocal).Objeto_Archivo IsNot Nothing Then
                    'Actualizar un Registro
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesInspeccionI_Update")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_InspeccionI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)

                Else
                    'Eliminar un Registro
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CajasFuertesInspeccionI_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_InspeccionI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)
                    EjecutarNonQueryT(cmd)
                    Continue For
                End If

                Cn_Datos.Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Nombre_Archivo, False)
                Cn_Datos.Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, Arreglo_Archivo(ILocal).MimeType_Archivo)
                Cn_Datos.Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                Cn_Datos.Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                EjecutarNonQueryT(cmd)
            Next
            Tr.Commit()
            cmd.Dispose()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cmd.Dispose()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_InspeccionImagenes_CargarArreglo(ByVal Id_Inspeccion As Integer, Optional ByVal Id_InspeccionI As Integer = 0) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesInspeccionI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)
            Cn_Datos.Crea_Parametro(cmd, "@Id_InspeccionI", SqlDbType.Int, Id_InspeccionI)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    ReDim Arreglo_Archivo(dt.Rows.Count)
                    Dim Contador As Integer = 0
                    For Each Elemento As DataRow In dt.Rows
                        Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_InspeccionI")
                        Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                        Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                        Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                        Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("Descripcion")
                        Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                        Arreglo_Archivo(Contador).Extension_Archivo = Nothing
                        Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                        Arreglo_Archivo(Contador).Adicional_Archivo = Nothing
                        Contador += 1
                    Next
                End If
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_InspeccionImagenes_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Inspeccion As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesInspeccionI_Get", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)

            lsv.Actualizar(cmd, "Id_InspeccionI")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Acta de Inspección de Caja Fuerte Pendientes"

    Public Shared Function fn_ActasInspeccion_Pendientes(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesInspeccion_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, #1/1/2011#)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, DateAdd(DateInterval.Day, 365, Today.Date))
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            lsv.Actualizar(Cmd, "Id_Inspeccion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta de Actas de Inspección de Cajas Fuertes"

    Public Shared Function fn_ActasInspeccion_LlenarLista(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Id_Empleado As Integer, ByVal Status As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CajasFuertesInspeccion_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Inspeccion", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(Cmd, "Id_Inspeccion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ActaInspeccion_Imprimir(ByRef Tbl As DataTable, ByVal Id_Inspeccion As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesInspeccion_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_Reportes_Encabezado(ByRef Tbl As DataTable) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_ActaInspeccion_Cancelar(ByVal Id_Inspeccion As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesInspeccion_Cancelar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Inspeccion", SqlDbType.Int, Id_Inspeccion)
        Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
        Try
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Grupos de Facturacion"

    Public Shared Function fn_GruposFacturacion_LlenarListaGrupos(ByVal Id_CajaBancaria As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_GruposFactura_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_GrupoF")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_LlenarListaClientesSG(ByVal Id_CajaBancaria As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ClientesPSGrupo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_LlenarListaClientesDG(ByVal Id_CajaBancaria As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ClientesPDGrupo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_CajaBancaria)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_LlenarListaConceptos(ByVal Id_GrupoF As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFPGrupo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Concepto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_Crear(ByVal Descripcion As String, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposFactura_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_Actualizar(ByVal Id_GrupoF As Integer, ByVal Descripcion As String) As Boolean

        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposFactura_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_AsignarGrupo(ByVal Id_GrupoF As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposClientes_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_DesAsignarGrupo(ByVal Id_GrupoF As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposClientes_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_AsignarConcepto(ByVal Id_GrupoF As Integer, ByVal Id_Concepto As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposConceptos_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_DesAsignarConcepto(ByVal Id_GrupoF As Integer, ByVal Id_Concepto As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposConceptos_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Generar Carta"

    Public Shared Function fn_GeneraCarta_LlenarDs(ByRef Tbl As DataTable, ByVal Cliente As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_CartaAumentoD_Generar", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Cliente)

            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_GenerarCarta_Crear(ByVal Tr As SqlTransaction, ByVal Id_Cliente As Integer, ByVal Fecha_Aplicacion As Date, ByVal Id_Contacto As Integer, ByVal Firma As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_CartaAumento_Create")
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Usuario_Genera", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Fecha_Aplicacion", SqlDbType.DateTime, Fecha_Aplicacion)
        Crea_Parametro(cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
        Crea_Parametro(cmd, "@Usuario_Firma", SqlDbType.Int, Firma)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Dim I As Integer = EjecutarScalarT(cmd)
            If I > 0 Then
                Return I
            Else
                Tr.Rollback()
                Return 0
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_GenerarCarta_CrearDetalle(ByVal Tr As SqlTransaction, ByVal row As ds_Clientes.Tbl_CartaAumentoDRow, ByVal Id_Carta As Integer) As Boolean
        Using cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_CartaAumentoD_Create")
            Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, row.Id_CS)
            'Crea_Parametro(cmd, "@Tipo_AumentoP", SqlDbType.VarChar, row.Tipo_AumentoP)
            'Crea_Parametro(cmd, "@Cantidad_AumentoP", SqlDbType.Money, row.Cantidad_AumentoP)
            Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, row.Id_Precio)
            Crea_Parametro(cmd, "@Precio_Anterior", SqlDbType.Money, row.Precio_Anterior)
            'Crea_Parametro(cmd, "@Precio_Nuevo", SqlDbType.Money, row.Precio_Nuevo)
            Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, row.Id_CR)
            'Crea_Parametro(cmd, "@Tipo_AumentoCR", SqlDbType.VarChar, row.Tipo_AumentoCR)
            'Crea_Parametro(cmd, "@Cantidad_AumentoCR", SqlDbType.Money, row.Cantidad_AumentoCR)
            Crea_Parametro(cmd, "@Precio_AnteriorCR", SqlDbType.Money, row.Precio_AnteriorCR)
            'Crea_Parametro(cmd, "@Precio_NuevoCR", SqlDbType.Money, row.Precio_NuevoCR)
            Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, row.Id_EE)
            'Crea_Parametro(cmd, "@Tipo_AumentoEE", SqlDbType.VarChar, row.Tipo_AumentoEE)
            'Crea_Parametro(cmd, "@Cantidad_AumentoEE", SqlDbType.Money, row.Cantidad_AumentoEE)
            Crea_Parametro(cmd, "@Precio_AnteriorEE", SqlDbType.Money, row.Precio_AnteriorEE)
            'Crea_Parametro(cmd, "@Precio_NuevoEE", SqlDbType.Money, row.Precio_NuevoEE)
            Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, row.Id_KM)
            'Crea_Parametro(cmd, "@Tipo_AumentoKM", SqlDbType.VarChar, row.Tipo_AumentoKM)
            'Crea_Parametro(cmd, "@Cantidad_AumentoKM", SqlDbType.Money, row.Cantidad_AumentoKM)
            Crea_Parametro(cmd, "@Precio_AnteriorKM", SqlDbType.Money, row.Precio_AnteriorKM)
            'Crea_Parametro(cmd, "@Precio_NuevoKM", SqlDbType.Money, row.Precio_NuevoKM)

            Try
                If EjecutarNonQueryT(cmd) > 0 Then
                    Return True
                Else
                    Tr.Rollback()
                    Return False
                End If

            Catch ex As Exception
                Tr.Rollback()
                TrataEx(ex)
                Return False
            End Try

        End Using

    End Function

    'Public Shared Function fn_GenerarCarta_Guardar(ByVal Tbl As ds_Clientes.Tbl_CartaAumentoDDataTable, ByVal Cliente As Integer, ByVal Fecha As Date, ByVal Id_Contacto As Integer, ByVal Firma As Integer) As Integer
    '    Using tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

    '        Dim Id_Carta As Integer
    '        If Not Cliente = 0 Then
    '            Id_Carta = fn_GenerarCarta_Crear(tr, Cliente, Fecha, Id_Contacto, Firma)
    '            If Id_Carta = 0 Then Return 0
    '        End If

    '        For Each element As ds_Clientes.Tbl_CartaAumentoDRow In Tbl.Rows
    '            If Not element.Precio_Nuevo = 0 Or Not element.Precio_NuevoCR = 0 Or Not element.Precio_NuevoEE = 0 Or Not element.Precio_NuevoKM = 0 Then
    '                If Not fn_GenerarCarta_CrearDetalle(tr, element, Id_Carta) Then Return 0
    '            End If
    '        Next

    '        tr.Commit()
    '        Return Id_Carta
    '    End Using
    'End Function

#End Region

#Region "Validar Cartas"
    Public Shared Function fn_ValidarCartas_LlenarCartas(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_CartaAumento_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_Carta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarCartas_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Carta As Integer)
        Dim cmd As SqlCommand = Crea_Comando("Cat_CartaAumentoD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

        Try
            lsv.Actualizar(cmd, "Id_Precio")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarCartas_Validar(ByRef Tr As SqlTransaction, ByVal Id_Carta As Integer) As Boolean
        Dim Tbl As DataTable = fn_ValidarCartas_Detalles(Tr, Id_Carta)
        If Tbl Is Nothing Then
            Tr.Rollback()
            Return False
        Else
            For Each element As DataRow In Tbl.Rows
                If Not fn_ValidarCartas_CambiaPrecio(Tr, element) Then Return False
            Next

            Return True
        End If
    End Function

    Public Shared Function fn_ValidarCartas_CambiaPrecio(ByRef Tr As SqlTransaction, ByVal row As DataRow) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_CartaAumento_Validar")
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, row("Id_Carta"))
        Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, row("Id_CS"))
        Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If

        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarCartas_Cancelar(ByVal Tr As SqlTransaction, ByVal Id_Carta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_CartaAumento_Cancelar")
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
        Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If

        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarCartas_Detalles(ByVal Tr As SqlTransaction, ByVal Id As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_CartaAumentoD_Detalles")
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id)

        Try
            Return EjecutaConsultaT(cmd)
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ValidarCartas_ValidarCartas(ByVal Id() As Integer) As Boolean
        Using Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

            For Each Id_Carta As Integer In Id

                If Not fn_ValidarCartas_Validar(Tr, Id_Carta) Then Return False
            Next

            Tr.Commit()
            Return True
        End Using
    End Function

    Public Shared Function fn_ValidarCartas_CancelarCartas(ByVal Id() As Integer) As Boolean
        Using Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

            For Each Id_Carta As Integer In Id
                If Not fn_ValidarCartas_Cancelar(Tr, Id_Carta) Then Return False
            Next

            Tr.Commit()
            Return True
        End Using
    End Function

    Public Shared Function fn_ValidarCartas_Imprimir(ByVal Id_Carta As Integer) As Array
        Dim cmd As SqlCommand = Crea_Comando("Cat_CartaAumento_Imprimir", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

        Try
            Return EjecutaConsulta(cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ValidarCartas_ImprimirDetalle(ByRef Tbl As ds_Reporte.tbl_CartaAumentoDDataTable, ByVal Id_Carta As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_CartaAumentoD_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

            Try
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try

        End Using
    End Function

#End Region

#Region "Consulta puntos"

    Public Shared Function fn_ConsultaPuntos_llenarlista(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Tipo As Integer, ByVal Hijos As Boolean, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Tv_Puntos_Atendidos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
        If Hijos Then Crea_Parametro(cmd, "@Hijos", SqlDbType.Int, 1) Else Crea_Parametro(cmd, "@Hijos", SqlDbType.Int, 0)


        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Tbl.Columns("Fuera de Tiempo").ReadOnly = False
            Tbl.Columns("Fuera de Tiempo").MaxLength = 10
            For Each row As DataRow In Tbl.Rows
                If fn_ConsultaPuntos_Comparar(row("Entrega"), row(8)) Or fn_ConsultaPuntos_Comparar(row("Recoleccion"), row(6)) Then row("Fuera de Tiempo") = "Sí"
            Next
            lsv.Actualizar(Tbl, "Id_Punto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaPuntos_Comparar(ByVal Horario As String, ByVal real As String) As Boolean
        If InStr(Horario, "/") = 0 Then Return True
        Dim Horas() As String = Split(Horario, "/")
        Return CDate(Horas(1)) < CDate(real)
    End Function

#End Region

#Region "Cuentas"
    'verificar que id_cajaBancaria,la cuenta y la moneda no existan
    Public Shared Function fn_ProCuentas_Existe(ByVal Id_Cajabancaria As Integer, ByVal IdMoneda As Integer, ByVal NoCuenta As String) As DataTable
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_Cuentas_Existe", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Cajabancaria)
            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, IdMoneda)
            Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.VarChar, NoCuenta)

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    'trae cuentas default de la caja bancaria
    Public Shared Function fn_CuentasDefault_Get(ByVal Id_Cajabancaria As Integer, ByVal IdMoneda As Integer) As DataTable
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_Cuentas_Read2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Cajabancaria)
            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, IdMoneda)
            Crea_Parametro(cmd, "@Cuenta_Default", SqlDbType.VarChar, "S")
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_LLenarLista(ByVal lsv As cp_Listview, ByVal Id_Banco As Integer, ByVal Activos As Boolean) As Boolean
        Dim cmd As SqlCommand
        Try

            cmd = Crea_Comando("Pro_Cuentas_GetTodos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Banco)
            Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, If(Activos, "S", "N"))
            lsv.Actualizar(cmd, "Id_Cuenta")

            For contador As Integer = 0 To lsv.Items.Count - 1
                If lsv.Items(contador).SubItems(6).Text = "S" Then
                    lsv.Items(contador).BackColor = Color.LightGreen
                End If
            Next

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Cuentas_Guardar(ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Status As Char, ByVal Id_CajaBancaria As Integer, ByVal TblRef As DataTable, ByVal CajaBancaria As String, ByVal Moneda As String, ByVal cuentaDefault As Boolean) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim Cuenta As Integer = fn_Cuentas_Crear(Tr, Numero_Cuenta, Id_Moneda, Id_Ciudad, Modo_Captura, Referenciada, Referencia_Fija, Status, Id_CajaBancaria, cuentaDefault)

        If Cuenta = 0 Then Return False
        For Each Referencia As DataRow In TblRef.Rows
            If fn_Referencias_Crear(Tr, Referencia, Cuenta) = 0 Then Return False
        Next

        fn_GuardaBitacora(9, "CAJA BANCARIA: '" & CajaBancaria & "', CUENTA: '" & Numero_Cuenta & "', MONEDA: '" & Moneda & "'")

        Tr.Commit()
        Return True
    End Function

    Protected Shared Function fn_Cuentas_Crear(ByVal Tra As SqlTransaction, ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Status As Char, ByVal Id_CajaBancaria As Integer, ByVal cuentaDefault As Boolean) As Integer
        Dim Cmd As SqlCommand
        Dim cta_Default As String = "N"
        If cuentaDefault Then cta_Default = "S"
        Try
            Cmd = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_Cuentas_Create")
            Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Numero_Cuenta)
            Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
            Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, Modo_Captura)
            Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Referenciada)
            Crea_Parametro(Cmd, "@Referencia_Fija", SqlDbType.VarChar, Referencia_Fija)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(Cmd, "@Cuenta_Default", SqlDbType.VarChar, cta_Default)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Protected Shared Function fn_Cuentas_ActualizaCuenta(ByVal Id_Cuenta As Integer, ByVal Tra As SqlTransaction, ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer,
                                                         ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char,
                                                         ByVal Id_CajaBancaria As Integer, ByVal cuentaDefault As Boolean) As Integer
        Dim Cmd As SqlCommand
        Dim cta_Default As String = "N"
        If cuentaDefault Then cta_Default = "S"
        Try
            Cmd = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_Cuentas_Update")
            Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
            Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Numero_Cuenta)
            Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
            Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, Modo_Captura)
            Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Referenciada)
            Crea_Parametro(Cmd, "@Referencia_Fija", SqlDbType.VarChar, Referencia_Fija)
            Crea_Parametro(Cmd, "@Cuenta_Default", SqlDbType.VarChar, cta_Default)
            Return EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Public Shared Function fn_Cuentas_Baja(ByVal Id_Cuenta As Integer, ByVal Status As Char, ByVal Cuenta As String, ByVal CajaBancaria As String, ByVal Moneda As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cuentas_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            fn_GuardaBitacora(11, "CAJA BANCARIA: '" & CajaBancaria & "', CUENTA: '" & Cuenta & "', MONEDA: '" & Moneda & "'")
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Cuentas_Read(ByVal Id_Cuenta As Integer) As DataRow
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_Cuentas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)

            Return EjecutaConsulta(cmd).Rows(0)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Get(ByVal Id_Cuenta As Integer, ByVal Id_ClienteP As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Get1(ByVal Id_Cuenta As Integer, ByVal Status As Char) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Get1", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.Char, Status)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Modificar(ByVal Id_Cuentas As Integer, ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer,
                                                ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Id_CajaBancaria As Integer,
                                                ByVal TblRef As DataTable, ByVal CajaBancaria As String, ByVal Moneda As String, ByVal MonedaAnt As String, ByVal CuentaAnt As String, ByVal ctaDefault As Boolean) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        fn_Cuentas_ActualizaCuenta(Id_Cuentas, Tr, Numero_Cuenta, Id_Moneda, Id_Ciudad, Modo_Captura, Referenciada, Referencia_Fija, Id_CajaBancaria, ctaDefault)

        For Each Referencia As DataRow In TblRef.Rows
            If Referencia("Modificado") = 2 Then
                If fn_Referencias_Crear(Tr, Referencia, Id_Cuentas) = 0 Then Return False
            End If
        Next

        fn_GuardaBitacora(13, "CAJA BANCARIA: " & CajaBancaria & ", MONEDA DE '" & MonedaAnt & "' A '" & Moneda & ", CUENTA DE '" & CuentaAnt & "' A '" & Numero_Cuenta & "'")

        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_CuentasReferencias_Baja(ByVal Id_Referencia As Integer) As Boolean
        Dim Cantidad As Integer = 0
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Baja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
        Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)

        Try
            'Dar de Baja en Pro_CuentasReferencias
            Cantidad = EjecutarNonQuery(cmd)
            'Falta dar de baja en Cat_ClientesPreferencias
            cmd = Crea_Comando("Cat_ClientesPreferencias_Baja_Reing2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "B")

            Cantidad += EjecutarNonQuery(cmd)

            If Cantidad > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CuentasReferencias_Reingreso(ByVal Id_Referencia As Integer) As Boolean
        Dim Cantidad As Integer = 0
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Reingreso", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
        Crea_Parametro(cmd, "@Usuario_Reingreso", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)

        Try
            'Reingresar en Pro_CuentasReferencias
            Cantidad = EjecutarNonQuery(cmd)

            'Falta reingresar en Cat_ClientesPreferencias
            cmd = Crea_Comando("Cat_ClientesPreferencias_Baja_Reing2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            Cantidad += EjecutarNonQuery(cmd)

            If Cantidad > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Cuentas Modal"
    Public Shared Sub fn_CuentasModal_LlenarExistentes(ByVal lsv As cp_Listview, ByVal Id_ClienteP As Integer, ByVal Id_CajaBancaria As Integer)
        Dim cmd As SqlCommand
        If Id_ClienteP = 0 Then
            cmd = Crea_Comando("Pro_Cuentas_GetTodos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, "S")
        Else
            cmd = Crea_Comando("Pro_Cuentas_GetByClienteP", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, "S")
        End If

        Try
            lsv.Actualizar(cmd, "Id_Cuenta")
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Function fn_CuentasModal_Referencias(ByVal Lsv As cp_Listview, ByVal Id_Cuenta As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        'Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, "S")

        Try
            Lsv.Actualizar(cmd, "Id_Referencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CuentasModal_GuardarNueva(ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Status As Char, ByVal Id_CajaBancaria As Integer, ByVal TblRef As DataTable, ByVal cuentaDefault As Boolean) As Integer()
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim Id(TblRef.Rows.Count) As Integer
        Id(0) = fn_Cuentas_Crear(Tr, Numero_Cuenta, Id_Moneda, Id_Ciudad, Modo_Captura, Referenciada, Referencia_Fija, Status, Id_CajaBancaria, cuentaDefault)

        If Id(0) = 0 Then Return Nothing
        For Each Referencia As DataRow In TblRef.Rows
            Id(TblRef.Rows.IndexOf(Referencia) + 1) = fn_Referencias_Crear(Tr, Referencia, Id(0))
            If Id(TblRef.Rows.IndexOf(Referencia) + 1) = 0 Then Return Nothing
        Next

        Tr.Commit()
        Return Id
    End Function

    Public Shared Function fn_CuentasModal_Guardar(ByVal Id_ClienteP As Integer, ByVal Cuentas() As Integer, ByVal Referencias() As Integer) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        For Each cuenta As Integer In Cuentas
            If Not fn_CuentasModal_CrearCuenta(Tr, Id_ClienteP, cuenta) Then Return False
        Next

        For Each Referencia As Integer In Referencias
            If Not fn_CuentasModal_CrearReferencia(Tr, Id_ClienteP, Referencia) Then Return False
        Next

        Tr.Commit()
        Return True
    End Function

    Protected Shared Function fn_CuentasModal_CrearCuenta(ByVal Tr As SqlTransaction, ByVal Id_ClienteP As Integer, ByVal Id_Cuenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_ClientesPcuentas_Create")
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Return EjecutarNonQueryT(cmd) > 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Protected Shared Function fn_CuentasModal_CrearReferencia(ByVal Tr As SqlTransaction, ByVal Id_ClienteP As Integer, ByVal Id_Referencia As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_ClientesPreferencias_Create")
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            Return EjecutarNonQueryT(cmd) > 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Modificar Origen Destino"

    Public Shared Function fn_ModificarOrigenDestino_Update(ByRef lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Tipo As Char) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)

        Dim cmd As SqlCommand = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesHorarios_ByIdUpdate")
        Dim Creados As Integer = 0
        Try

            For Each Elem As ListViewItem In lsv.CheckedItems
                cmd.Parameters.Clear()
                Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, Elem.Tag)
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                If Tipo = "O" Then
                    Crea_Parametro(cmd, "@Tipo", SqlDbType.Char, "O")
                Else
                    Crea_Parametro(cmd, "@Tipo", SqlDbType.Char, "D")
                End If
                If EjecutarNonQueryT(cmd) > 0 Then Creados += 1

            Next

            If Creados = lsv.CheckedItems.Count Then
                tr.Commit()
                cnn.Close()
                Return True
            Else
                tr.Rollback()
                cnn.Close()
                Return False
            End If
        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ModificarOrigenDestino_LlenarLista(ByRef lsv As cp_Listview, ByVal Cliente As Integer, ByVal ClienteOD As Integer, ByVal Id_precio As Integer, ByVal Tipo As Char) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorarios_XClienteXPrecio_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Cliente)
        Crea_Parametro(cmd, "@Id_ClienteOD", SqlDbType.Int, ClienteOD)
        Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Id_precio)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Char, Tipo)
        Try
            lsv.Actualizar(cmd, "Id_CH")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

#Region "ValidaHorario"

    Public Shared Function fn_ValidaHorario_LlenarLista(ByRef lsv As cp_Listview, ByVal Cliente As Integer, ByVal Hijos As Boolean) As Boolean
        Dim Hijo As String
        Dim cmd As SqlCommand = Crea_Comando("Cat_clientesHorariosTemp_xClienteGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        If Hijos = True Then
            Hijo = "S"
        Else
            Hijo = "N"
        End If

        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Cliente)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Hijos", SqlDbType.VarChar, Hijo)

        Try
            lsv.Actualizar(cmd, "Id_Htemp")
            For Each elemento As ListViewItem In lsv.Items
                elemento.Checked = True
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidaHorario_Valida(ByVal lsv As ListView) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Status")
            Dim Creados As Integer = 0

            For Each Elemento As ListViewItem In lsv.CheckedItems
                cmd.Parameters.Clear()
                Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, Elemento.Tag)
                Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "V")
                If EjecutarNonQueryT(cmd) > 0 Then Creados += 1
            Next

            If Creados = lsv.CheckedItems.Count Then
                tr.Commit()
                cnn.Close()
                Return True
            Else
                tr.Rollback()
                cnn.Close()
                Return False
            End If

        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidaHorario_Eliminar(ByVal lsv As ListView) As Boolean
        Dim Elemento As ListViewItem
        Dim cmd As SqlCommand
        Try
            For Each Elemento In lsv.CheckedItems
                cmd = Crea_Comando("Cat_ClientesHorariosTemp_Eliminar", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, Elemento.Tag)
                EjecutarNonQuery(cmd)
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidaHorario_UsuarioValida(ByVal Id_Empleado As Integer) As Boolean
        Dim cmd As SqlCommand

        Try
            cmd = Crea_Comando("Cat_Instancias_valida", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Clave_Instancia", SqlDbType.Int, ModuloClave)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            If EjecutarScalar(cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "ValidaProspecto"

    Public Shared Function fn_BuscarCP_LlenarLista(ByRef lsv As cp_Listview, Optional ByVal Cliente As Boolean = True) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("[Cat_ClientesProspecto_Get]", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        If Cliente = False Then
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
        Else
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        End If

        Try
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidaProspectoCreate(ByVal lsv As ListView) As Boolean
        Dim Elemento As ListViewItem
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For Each Elemento In lsv.CheckedItems
                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_Clientes_ProspectoCreate")
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Elemento.Tag)
                Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                EjecutarNonQueryT(cmd)
            Next
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
        tr.Commit()
        Return True
    End Function
    Public Shared Function fn_EliminarProspectoCreate(ByVal lsv As ListView) As Boolean
        Dim Elemento As ListViewItem
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For Each Elemento In lsv.CheckedItems
                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Eliminar_Prospecto")
                Crea_Parametro(cmd, "@Id_Prospecto", SqlDbType.Int, Elemento.Tag)
                EjecutarNonQueryT(cmd)
            Next
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
        tr.Commit()
        Return True
    End Function

#End Region

#Region "Razon Social"
    Public Shared Function fn_RazonSocial_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("ListaRazonSocial_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RazonSocial_Existe(ByVal Descripcion As String) As Boolean
        'Aquí se valida si existe el Documento Requerido
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("RazonSocial_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RazonSocial_Nuevo(ByVal Descripcion As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("RazonSocial_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RazonSocial_Modificar(ByVal Id_DoctosR As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("RazonSocial_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id", SqlDbType.Int, Id_DoctosR)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Documentos Requeridos"

    Public Shared Function fn_DocumentosRequerido_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctosR_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_DoctosR")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DocumentosRequeridos_Nuevo(ByVal Descripcion As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctosR_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DocumentosRequeridos_Modificar(ByVal Id_DoctosR As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctosR_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_DoctosR", SqlDbType.Int, Id_DoctosR)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DocumentosRequerido_Read(ByVal Id_DoctosR As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctosR_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_DoctosR", SqlDbType.Int, Id_DoctosR)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DocumentosRequerido_Existe(ByVal Descripcion As String) As Boolean
        'Aquí se valida si existe el Documento Requerido
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ClientesDoctosR_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Instancias"

    Public Shared Function fn_Instancias_Create(ByVal Clave As String, ByVal Descripcion As String, ByVal Tipo_Evaluacion As String, ByVal Status As Char) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Instancias_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Clave_Instancia", SqlDbType.VarChar, Clave)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Tipo_Evaluacion", SqlDbType.VarChar, Tipo_Evaluacion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Instancias_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Instancias_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_Instancia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Instancias_Baja(ByVal Id_Instancia As Integer, ByVal Status As Char) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Instancias_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Instancia", SqlDbType.Int, Id_Instancia)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Instancias_Read(ByVal Id_Instancia As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_Instancias_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Instancia", SqlDbType.Int, Id_Instancia)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Instancias_Update(ByVal Id_Instancia As Integer, ByVal Descripcion As String, ByVal Tipo_Evaluacion As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Instancias_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Instancia", SqlDbType.Int, Id_Instancia)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Tipo_Evaluacion", SqlDbType.VarChar, Tipo_Evaluacion)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Instancias Empleados"

    Public Shared Function fn_InstanciasEmpleados_Create(ByVal Id_Instancia As Long, ByVal Id_Empleado As Long) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_InstanciasEmpleados_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Instancia", SqlDbType.VarChar, Id_Instancia)
        Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.VarChar, Id_Empleado)
        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_InstanciasEmpleados_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_InstanciasEmpleados_Get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_InstanciaEM")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_InstanciasEmpleados_Baja(ByVal Id_InstanciaEM As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_InstanciasEmpleados_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_InstanciaEM", SqlDbType.Int, Id_InstanciaEM)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Contacto Web"

    Public Shared Function fn_Contact_LlenarLista(ByRef lsv As cp_Listview, ByVal Tipo As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("www_Contacto_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            lsv.Actualizar(cmd, "Id_ContactoWeb")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


#End Region

#Region "Capturar Destino"

    Public Shared Function fn_CapturarDestino_ObtenPais() As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_PaisesSucursal_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)
            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0).Item("Id_Pais")
            Else
                Return 0
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_CapturarDestino_Guardar(ByVal Nombre_Comercial As String, ByVal Calle_Comercial As String, ByVal Numero_Comercial As Integer, ByVal NumeroInt_Comercial As String,
                                                      ByVal Colonia_Comercial As String, ByVal Zona_Comercial As Integer) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_CreateDestino", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Calle_Comercial", SqlDbType.VarChar, Calle_Comercial)
        Crea_Parametro(cmd, "@Numero_Comercial", SqlDbType.Int, Numero_Comercial)
        Crea_Parametro(cmd, "@NumeroInt_Comercial", SqlDbType.VarChar, NumeroInt_Comercial)
        Crea_Parametro(cmd, "@Colonia_Comercial", SqlDbType.VarChar, Colonia_Comercial)
        Crea_Parametro(cmd, "@Zona_Comercial", SqlDbType.Int, Zona_Comercial)
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function
#End Region

#Region "Atencion de Llamadas"

    Public Shared Function fn_SolicitudServicio_Nuevo(ByVal TipoLlamada As String, ByVal Id_Cliente As Integer, ByVal NombreContacto As String, ByVal Empresa As String, ByVal Direccion As String, ByVal Colonia As String, ByVal Id_Ciudad As Integer, ByVal Telefono As String, ByVal Fax As String, ByVal Mail As String, ByVal MedioContacto As String, ByVal Observaciones As String, ByVal Items As cp_Listview.ListViewItemCollection) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Id_Solicitud As Integer = 0

        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_SolicitudServicio_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Llamada", SqlDbType.VarChar, TipoLlamada)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Contacto", SqlDbType.VarChar, NombreContacto)
            Cn_Datos.Crea_Parametro(Cmd, "@Empresa", SqlDbType.VarChar, Empresa)
            Cn_Datos.Crea_Parametro(Cmd, "@Direccion", SqlDbType.VarChar, Direccion)
            Cn_Datos.Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, Colonia)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
            Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, Telefono)
            Cn_Datos.Crea_Parametro(Cmd, "@Fax", SqlDbType.VarChar, Fax)
            Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)
            Cn_Datos.Crea_Parametro(Cmd, "@Medio_Contacto", SqlDbType.VarChar, MedioContacto)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            Id_Solicitud = Cn_Datos.EjecutarScalarT(Cmd)

            If Id_Solicitud = 0 Then
                Trans.Rollback()
                Return False
            End If

            For Each elemento As ListViewItem In Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_SolicitudServicioD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Linea", SqlDbType.Int, elemento.SubItems(9).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Proceso_Efectivo", SqlDbType.VarChar, elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Acreditar_MismoDia", SqlDbType.VarChar, elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cambio_Morralla", SqlDbType.VarChar, elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, elemento.SubItems(12).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre_CajaBancaria", SqlDbType.VarChar, elemento.SubItems(13).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(elemento.SubItems(2).Text))
                Cn_Datos.Crea_Parametro(Cmd, "@Dias", SqlDbType.VarChar, elemento.SubItems(11).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Servicio", SqlDbType.Int, elemento.SubItems(19).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.DateTime, elemento.Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.DateTime, elemento.SubItems(10).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Monto_Aproximado", SqlDbType.Money, CInt(elemento.SubItems(4).Text))
                Cn_Datos.Crea_Parametro(Cmd, "@Cia_Actual", SqlDbType.Int, elemento.SubItems(14).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Precio_Actual", SqlDbType.Decimal, CDec(elemento.SubItems(15).Text))
                Cn_Datos.Crea_Parametro(Cmd, "@Cuota_Actual", SqlDbType.Decimal, CDec(elemento.SubItems(16).Text))
                Cn_Datos.Crea_Parametro(Cmd, "@Motivo_Cambio", SqlDbType.VarChar, elemento.SubItems(17).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, elemento.SubItems(18).Text)


                If EjecutarNonQueryT(Cmd) = 0 Then
                    Trans.Rollback()
                    Return False
                End If
            Next

        Catch ex As Exception
            TrataEx(ex)
            Trans.Rollback()
            Return False
        End Try
        Trans.Commit()
        Return True
    End Function

    Public Shared Function fn_AtencionLlamadas_ObtenValores(ByVal Id_Cliente As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Clientes_AtencionGet", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "Id_Cliente", SqlDbType.Int, Id_Cliente)

            Dim tbl As DataTable = EjecutaConsulta(Cmd)
            If tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Citas_Nuevo(ByVal Id_Empleado As Integer, ByVal FechaAgenda As DateTime, ByVal HoraAgenda As Decimal, ByVal Asunto As String, ByVal Descripcion As String) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_Create", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Agenda", SqlDbType.DateTime, FechaAgenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Agenda", SqlDbType.Decimal, HoraAgenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Comentarios_Atencion", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@Proxima_Cita", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_Agenda_ConsultarDia(ByVal Fecha As Date) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AgendaHoras_DiaRead", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)

            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    'Public Shared Function fn_Cita_Finalizar(ByVal Id_Agenda As Integer, ByVal Comentarios As String) As Boolean

    '    Try
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_FinalizarUpdate", CommandType.StoredProcedure, Cnn)

    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)

    '        Cn_Datos.EjecutarNonQuery(Cmd)
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try

    'End Function

    Public Shared Function fn_Cita_Posponer(ByVal Id_Agenda As Integer, ByVal Asunto As String, ByVal Descripcion As String, ByVal FechaNueva As Date, ByVal HoraNueva As Decimal, ByVal Comentarios As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlClient.SqlTransaction = crear_Trans(Cnn)

        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Agenda_PosponerUpdate")

            Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
            Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(Cmd, "@FechaNueva", SqlDbType.Date, FechaNueva)
            Crea_Parametro(Cmd, "@HoraNueva", SqlDbType.Decimal, HoraNueva)
            Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            EjecutarNonQueryT(Cmd)
            Trans.Commit()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Trans.Rollback()
            Return False
        End Try

    End Function

    'Public Shared Function fn_Cita_Cancelar(ByVal Id_Agenda As Integer, ByVal Comentarios As String) As Boolean

    '    Try
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_CancelarUpdate", CommandType.StoredProcedure, Cnn)

    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

    '        Cn_Datos.EjecutarNonQuery(Cmd)
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try

    'End Function

    'Public Shared Function fn_Cita_Reasignar(ByVal Id_Agenda As Integer, ByVal Asunto As String, ByVal Descripcion As String, ByVal FechaNueva As Date, ByVal HoraNueva As Decimal, ByVal Comentarios As String, ByVal Id_EmpleadoR As Integer) As Boolean

    '    Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
    '    Dim Trans As SqlClient.SqlTransaction = crear_Trans(Cnn)

    '    Try
    '        Dim Cmd As SqlClient.SqlCommand = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Agenda_ReasignarUpdate")

    '        Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
    '        Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
    '        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
    '        Crea_Parametro(Cmd, "@FechaNueva", SqlDbType.Date, FechaNueva)
    '        Crea_Parametro(Cmd, "@HoraNueva", SqlDbType.Decimal, HoraNueva)
    '        Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
    '        Crea_Parametro(Cmd, "@Id_EmpleadoR", SqlDbType.Int, Id_EmpleadoR)
    '        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
    '        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

    '        EjecutarNonQueryT(Cmd)
    '        Trans.Commit()
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Trans.Rollback()
    '        Return False
    '    End Try

    'End Function

    'Public Shared Function fn_Cita_Actualizar(ByVal Id_Agenda As Integer, ByVal Asunto As String, ByVal Descripcion As String) As Boolean

    '    Try
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_Update", CommandType.StoredProcedure, Cnn)

    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

    '        Cn_Datos.EjecutarNonQuery(Cmd)
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try

    'End Function

#End Region

#Region "Agenda"

    Public Shared Function fn_Citas_Nuevo(ByVal Id_Empleado As Integer, ByVal Fecha_Agenda As DateTime, ByVal Hora_Agenda As Decimal, ByVal Hora_Final As Decimal, ByVal Hora_InicialT As String, ByVal Hora_FinalT As String, ByVal Asunto As String, ByVal Descripcion As String, ByVal Id_InicioRecurrencia As Integer) As Integer
        Dim Id_Agenda As Integer = 0
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_Create", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Agenda", SqlDbType.DateTime, Fecha_Agenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Agenda", SqlDbType.Decimal, Hora_Agenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Final", SqlDbType.Decimal, Hora_Final)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_InicialT", SqlDbType.Time, Hora_InicialT)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_FinalT", SqlDbType.Time, Hora_FinalT)
            Cn_Datos.Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_InicioRecurrencia", SqlDbType.Int, Id_InicioRecurrencia)
            Id_Agenda = EjecutarScalar(Cmd)
            Return Id_Agenda
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_Cita_Actualizar(ByVal Id_Agenda As Integer, ByVal Asunto As String, ByVal Descripcion As String) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_Update", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Agenda_ConsultarDia(ByVal Fecha As Date, ByVal Id_Empleado As Integer) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_DiaRead", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)

            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Agenda_ConsultarUna(ByVal Id_Agenda As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)

            Dim Dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Dt IsNot Nothing Then
                If Dt.Rows.Count > 0 Then
                    Return Dt.Rows(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Agenda_ConsultarMes(ByVal Mes As Byte, ByVal Id_Empleado As Integer) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_MesRead", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Mes", SqlDbType.TinyInt, Mes)

            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Agenda_MesGet(ByVal lsv As cp_Listview, ByVal Año As Integer, ByVal Mes As Byte, ByVal Id_Empleado As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_MesGet", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Año", SqlDbType.Int, Año)
            Crea_Parametro(Cmd, "@Mes", SqlDbType.TinyInt, Mes)
            lsv.Actualizar(Cmd, "Id_Agenda")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Cita_Finalizar(ByVal Id_Agenda As Integer, ByVal Comentarios As String) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_FinalizarUpdate", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Cita_Existe(ByVal Id_Empleado As Integer, ByVal FechaNueva As Date, ByVal Hora As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Dt As DataTable
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_Existe", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, FechaNueva)
            Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Hora)
            Dt = EjecutaConsulta(Cmd)
            If Dt IsNot Nothing Then
                If Dt.Rows.Count > 0 Then
                    'Si Existe
                    Return True
                Else
                    'No existe
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try

    End Function

    Public Shared Function fn_Cita_Posponer(ByVal Id_Agenda As Integer, ByVal Asunto As String, ByVal Descripcion As String, ByVal FechaNueva As Date, ByVal Hora_InicioNueva As Decimal, ByVal Hora_FinNueva As Decimal, ByVal Hora_InicioNuevaT As String, ByVal Hora_FinNuevaT As String, ByVal Comentarios As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlClient.SqlTransaction = crear_Trans(Cnn)

        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Agenda_PosponerUpdate")

            Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
            Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
            Crea_Parametro(Cmd, "@Fecha_Nueva", SqlDbType.Date, FechaNueva.Date)
            Crea_Parametro(Cmd, "@Hora_InicioNueva", SqlDbType.Decimal, Hora_InicioNueva)
            Crea_Parametro(Cmd, "@Hora_FinNueva", SqlDbType.Decimal, Hora_FinNueva)
            Crea_Parametro(Cmd, "@Hora_InicioNuevaT", SqlDbType.Time, Hora_InicioNuevaT)
            Crea_Parametro(Cmd, "@Hora_FinNuevaT", SqlDbType.Time, Hora_FinNuevaT)
            Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            EjecutarNonQueryT(Cmd)
            Trans.Commit()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Trans.Rollback()
            Return False
        End Try

    End Function

    Public Shared Function fn_Cita_Cancelar(ByVal Id_Agenda As Integer, ByVal Comentarios As String) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Agenda_CancelarUpdate", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
            Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Cita_Reasignar(ByVal Id_Agenda As Integer, ByVal Asunto As String, ByVal Descripcion As String, ByVal FechaNueva As Date, ByVal HoraNueva As Decimal, ByVal Comentarios As String, ByVal Id_EmpleadoR As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlClient.SqlTransaction = crear_Trans(Cnn)

        Try
            Dim Cmd As SqlClient.SqlCommand = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Agenda_ReasignarUpdate")

            Crea_Parametro(Cmd, "@Id_Agenda", SqlDbType.Int, Id_Agenda)
            Crea_Parametro(Cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(Cmd, "@FechaNueva", SqlDbType.Date, FechaNueva)
            Crea_Parametro(Cmd, "@HoraNueva", SqlDbType.Decimal, HoraNueva)
            Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Crea_Parametro(Cmd, "@Id_EmpleadoR", SqlDbType.Int, Id_EmpleadoR)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            EjecutarNonQueryT(Cmd)
            Trans.Commit()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Trans.Rollback()
            Return False
        End Try

    End Function

#End Region

#Region "Consulta de Llamadas"

    Public Shared Function fn_ConsultaLlamadas_LlenarLista(ByVal Desde As DateTime, ByVal Hasta As DateTime, ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_SolicitudServicio_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)

            lsv.Actualizar(Cmd, "Id_Solicitud")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaLlamadas_MuestraDetalles(ByVal Id_Solicitud As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_SolicitudServicio_DetallesGet", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)

            Dim DT As DataTable = EjecutaConsulta(Cmd)

            If DT.Rows.Count > 0 Then
                Return DT.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Consulta_Llamadas_DetallesServicios(ByVal Id_Solicitud As Integer, ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_SolicitudServicioD_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Solicitud", SqlDbType.Int, Id_Solicitud)

            lsv.Actualizar(Cmd, "Id_Solicitud")

            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "Cotizaciones"

    Public Shared Function fn_Seguimiento_LlenarLista(ByVal NumLlamada As Integer, ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_SolicitudServicioD_GetBuscaSolicitud", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Numero_Llamada", SqlDbType.Int, NumLlamada)

            lsv.Actualizar(Cmd, "Id_Solicitud")

            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right

            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Consulta de Clientes"

    Public Shared Function fn_Clientes_ReporteGeneral(ByVal lsv As cp_Listview, ByVal Id_padre As Integer, ByVal Id_ClienteGrupo As Integer, ByVal Status As String, ByVal Tipo_Cliente As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetReporteGeneral", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_padre)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Tipo_Cliente", SqlDbType.VarChar, Tipo_Cliente)
            Crea_Parametro(cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)

            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_ReporteDocumentos(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesDoctosReporte_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            'Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            'Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_padre)
            'Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            'Crea_Parametro(cmd, "@Tipo_Cliente", SqlDbType.VarChar, Tipo_Cliente)
            'Crea_Parametro(cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)


            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_Consulta(ByVal lsv As cp_Listview, ByVal Id_padre As Integer, ByVal Status As String, ByVal Tipo_Cliente As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetConsulta", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_padre)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Tipo_Cliente", SqlDbType.VarChar, Tipo_Cliente)

            lsv.Actualizar(cmd, "Id_Cliente")
            lsv.Columns(11).Width = 100
            lsv.Columns(12).Width = 0
            lsv.Columns(13).Width = 0
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesBajasI_Actualizar(ByVal Id_Cliente As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                    Continue For

                ElseIf Arreglo_Archivo(ILocal).Id_Archivo = Nothing Then
                    'Crear un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesBajasI_Create")
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                ElseIf Arreglo_Archivo(ILocal).Objeto_Archivo IsNot Nothing Then
                    'Actualizar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesBajasI_Update")
                    Crea_Parametro(cmd, "@Id_ClienteBajaI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)

                Else
                    'Eliminar un Registro y Archivo
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesBajasI_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_ClienteBajaI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)
                    EjecutarNonQueryT(cmd)
                    Continue For
                End If

                Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Nombre_Archivo, False)
                Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, Arreglo_Archivo(ILocal).MimeType_Archivo)
                Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                EjecutarNonQueryT(cmd)
            Next

            Tr.Commit()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesBajasI_CargarArreglo(ByVal Id_Cliente As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesBajasI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ReDim Arreglo_Archivo(dt.Rows.Count)
                Dim Contador As Integer = 0
                For Each Elemento As DataRow In dt.Rows
                    Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_ClienteBajaI")
                    Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                    Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                    Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                    Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("Descripcion")
                    Arreglo_Archivo(Contador).Extension_Archivo = Nothing
                    Arreglo_Archivo(Contador).Adicional_Archivo = Nothing
                    Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                    Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                    Contador += 1
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clientes_ConsultaContactos(ByVal Id_Padre As Integer, ByVal Status As String, ByVal Tipo_Cliente As String, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesContactosEnlace_GetBuscar", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Tipo_Cliente", SqlDbType.VarChar, Tipo_Cliente)

            lsv.Actualizar(cmd, "Id_Contacto")
            lsv.Columns(10).Width = 0
            lsv.Columns(11).Width = 0
            lsv.Columns(12).Width = 0
            lsv.Columns(13).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta Clientes Baja"

    Public Shared Function fn_ClientesBaja_Consulta(ByVal Desde As Date, ByVal Hasta As Date, ByVal Usuario_Baja As Integer, ByVal Id_MotivoB As Integer, ByVal Status As String, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Bajas_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, Usuario_Baja)
            Cn_Datos.Crea_Parametro(cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(cmd, "Id_Baja")
            lsv.Columns(10).Width = 0
            Return True
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Empleados"
    Public Shared Function fn_IndicadorAltaBajaEmpleado_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_Indicador", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            lsv.Actualizar(cmd, "mes")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Consulta de Clientes en Lista Negra"

    Public Shared Function fn_ClientesListaNegra_LlenarLista(ByVal Id_ListaNegra As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesListaNegra_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
            Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
            Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

            lsv.Actualizar(cmd, "Id_ListaNegra")
            Return True
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Actualizar Razón Social de Clientes"

    Public Shared Function fn_Clientes_GuardarRS(ByVal Id_Cliente As Integer, ByVal Nombre_Fiscal As String, ByVal Calle_Fiscal As String, ByVal Numero_Fiscal As Integer,
                                                 ByVal EntreCalle_Fiscal1 As String, ByVal EntreCalle_Fiscal2 As String, ByVal NumeroInt_Fiscal As String, ByVal Colonia_Fiscal As String,
                                                 ByVal CP_Fiscal As Integer, ByVal Zona_Fiscal As Integer, ByVal RFC As String, ByVal Clave_Facturacion As String,
                                                 ByVal NClave_Facturacion As String, ByVal Observaciones As String, ByVal Fecha_Inicio As Date, ByVal dt_Subclientes As DataTable) As Boolean
        'Traer los Valores Originales para Guardarlos en el Historial
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesCambioRS_Create")
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Clave_Facturacion", SqlDbType.VarChar, Clave_Facturacion)
            Crea_Parametro(cmd, "@NClave_Facturacion", SqlDbType.VarChar, NClave_Facturacion)
            Crea_Parametro(cmd, "@NNombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
            Crea_Parametro(cmd, "@NCalle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
            Crea_Parametro(cmd, "@NNumero_Fiscal", SqlDbType.Int, Numero_Fiscal)
            Crea_Parametro(cmd, "@NNumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
            Crea_Parametro(cmd, "@NEntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
            Crea_Parametro(cmd, "@NEntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
            Crea_Parametro(cmd, "@NColonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
            Crea_Parametro(cmd, "@NCP_Fiscal", SqlDbType.Int, CP_Fiscal)
            Crea_Parametro(cmd, "@NZona_Fiscal", SqlDbType.Int, Zona_Fiscal)
            Crea_Parametro(cmd, "@NRFC", SqlDbType.VarChar, RFC)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Observaciones", SqlDbType.Text, Observaciones)
            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.Date, Fecha_Inicio)
            If Fecha_Inicio.Date <= Now.Date Then
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "V")
            Else
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            End If
            Dim Id As Integer = EjecutarNonQueryT(cmd)

            For Each Row As DataRow In dt_Subclientes.Rows
                cmd.Parameters.Clear()
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_SubCliente"))
                Crea_Parametro(cmd, "@Clave_Facturacion", SqlDbType.VarChar, Clave_Facturacion)
                Crea_Parametro(cmd, "@NClave_Facturacion", SqlDbType.VarChar, NClave_Facturacion)
                Crea_Parametro(cmd, "@NNombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
                Crea_Parametro(cmd, "@NCalle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
                Crea_Parametro(cmd, "@NNumero_Fiscal", SqlDbType.Int, Numero_Fiscal)
                Crea_Parametro(cmd, "@NNumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
                Crea_Parametro(cmd, "@NEntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
                Crea_Parametro(cmd, "@NEntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
                Crea_Parametro(cmd, "@NColonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
                Crea_Parametro(cmd, "@NCP_Fiscal", SqlDbType.Int, CP_Fiscal)
                Crea_Parametro(cmd, "@NZona_Fiscal", SqlDbType.Int, Zona_Fiscal)
                Crea_Parametro(cmd, "@NRFC", SqlDbType.VarChar, RFC)
                Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(cmd, "@Observaciones", SqlDbType.Text, Observaciones)
                Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.Date, Fecha_Inicio)
                If Fecha_Inicio.Date <= Now.Date Then
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "V")
                Else
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                End If
                EjecutarNonQueryT(cmd)
            Next

            If Fecha_Inicio.Date <= Today.Date Then
                cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Clientes_UpdateFiscales")
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd, "@Nombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
                Crea_Parametro(cmd, "@Calle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
                Crea_Parametro(cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
                Crea_Parametro(cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
                Crea_Parametro(cmd, "@EntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
                Crea_Parametro(cmd, "@EntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
                Crea_Parametro(cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
                Crea_Parametro(cmd, "@CP_Fiscal", SqlDbType.Int, CP_Fiscal)
                Crea_Parametro(cmd, "@Zona_Fiscal", SqlDbType.Int, Zona_Fiscal)
                Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
                'En el caso de que no se envie este un valor al parámetro
                'en el procedimiento se dejará la que tenía ya guardada el cliente.
                If NClave_Facturacion <> "" Then
                    'Poner la nueva clave si es que se ingreso un valor
                    Crea_Parametro(cmd, "@Clave_Facturacion", SqlDbType.VarChar, NClave_Facturacion)
                ElseIf Clave_Facturacion <> "" Then
                    'Poner la clave anterior (si es que tenía) cuando no se puso la nueva
                    Crea_Parametro(cmd, "@Clave_Facturacion", SqlDbType.VarChar, Clave_Facturacion)
                End If
                EjecutarNonQueryT(cmd)

                If dt_Subclientes.Rows.Count > 0 Then
                    For Each Row As DataRow In dt_Subclientes.Rows
                        cmd.Parameters.Clear()
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Row("Id_SubCliente"))
                        Crea_Parametro(cmd, "@Nombre_Fiscal", SqlDbType.VarChar, Nombre_Fiscal)
                        Crea_Parametro(cmd, "@Calle_Fiscal", SqlDbType.VarChar, Calle_Fiscal)
                        Crea_Parametro(cmd, "@Numero_Fiscal", SqlDbType.Int, Numero_Fiscal)
                        Crea_Parametro(cmd, "@NumeroInt_Fiscal", SqlDbType.VarChar, NumeroInt_Fiscal)
                        Crea_Parametro(cmd, "@EntreCalle_Fiscal1", SqlDbType.VarChar, EntreCalle_Fiscal1)
                        Crea_Parametro(cmd, "@EntreCalle_Fiscal2", SqlDbType.VarChar, EntreCalle_Fiscal2)
                        Crea_Parametro(cmd, "@Colonia_Fiscal", SqlDbType.VarChar, Colonia_Fiscal)
                        Crea_Parametro(cmd, "@CP_Fiscal", SqlDbType.Int, CP_Fiscal)
                        Crea_Parametro(cmd, "@Zona_Fiscal", SqlDbType.Int, Zona_Fiscal)
                        Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
                        If NClave_Facturacion <> "" Then
                            'Poner la nueva clave si es que se ingreso un valor
                            Crea_Parametro(cmd, "@Clave_Facturacion", SqlDbType.VarChar, NClave_Facturacion)
                            'Cuando no se haya puesto una nueva clave, en el procedimiento se gestiona automáticamente
                            'dejando la clave anterior, esto porque los hijos pueden tener una distinta a la de su padre.
                        End If
                        EjecutarNonQueryT(cmd)
                    Next
                End If
            End If

            If Id > 0 Then
                Tr.Commit()
                Cnn.Close()
                Return True
            Else
                Tr.Rollback()
                Cnn.Close()
                Return True
            End If
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Horarios"

    Public Shared Function fn_Clientes_HorariosTemporales(ByVal Id_Padre As Integer, ByVal Clave_Padre As String, ByVal Id_CS As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetHTemp", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Clave_Padre", SqlDbType.VarChar, Clave_Padre)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clientes_HorariosReales(ByVal Id_Padre As Integer, ByVal Clave_Padre As String, ByVal Id_CS As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetHorarios", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Clave_Padre", SqlDbType.VarChar, Clave_Padre)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Sucursales_Todos() As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clientes_Todos(ByVal Id_Sucursal As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetConsulta", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, Id_Sucursal)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clientes_PadreHijos(ByVal Id_Padre As Integer, ByVal Id_PrecioDescripcion As Integer, ByVal ClavePrecio As String, ByVal TambienPadre As Char) As DataTable
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetServiciosHijos", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Padre", SqlDbType.VarChar, Id_Padre)
            Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Id_PrecioDescripcion)
            Crea_Parametro(cmd, "@ClavePrecio", SqlDbType.VarChar, ClavePrecio)
            Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, TambienPadre) 'S = Si o N = No

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clientes_EdicionGlobal(ByVal Ruta As String, ByVal Bar As ToolStripProgressBar) As String
        'Abrir el Libro Excel
        Bar.Value = 0
        Bar.Maximum = 0
        Dim Xls = CreateObject("Excel.Application")
        Dim Wbk = Xls.Workbooks.Open(Ruta)
        Try
            If Wbk.Sheets(1).Name <> "Horarios" Then
                Xls.Visible = True
                Xls = Nothing
                Return "Archivo de Excel no Válido."
            End If
        Catch
            Xls.Visible = True
            Xls = Nothing
            Return "Archivo de Excel no Válido."
        End Try

        Dim Wsht1 = Wbk.Sheets(1)
        Dim HayCambios As Boolean = False
        For Each Fila In Wsht1.Rows
            If Fila.Row = 1 OrElse Fila.Row = 2 Then Continue For
            If Wsht1.Range("A" & Fila.Row).Value Is Nothing Then Exit For
            Bar.Maximum += 1
            If Wsht1.Range("BD" & Fila.Row).Text = "EDITADO" Then
                HayCambios = True
            End If
        Next
        If Not HayCambios Then
            Xls.Visible = True
            Xls = Nothing
            Return "Al Archivo de Excel que esta intentando Importar no se le realizaron cambios."
        End If

        Dim Tipo_Frecuencia As Char
        Dim Frecuencia As Integer
        Dim DiaEntrega As Integer
        Dim EscalaBoveda As Char
        Dim ResultadoFecha As Date

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim cmd As SqlCommand
        Try
            With Wsht1
                For Each Fila In Wsht1.Rows
                    If Fila.Row = 1 OrElse Fila.Row = 2 Then Continue For
                    If .Range("A" & Fila.Row).Value Is Nothing Then Exit For
                    If Bar.Value = Bar.Maximum Then Bar.Maximum += 1
                    Bar.Value += 1
                    'En esta celda se pone "Editado" cuando fue editada la fila sino revisar la siguiente fila
                    If .Range("BD" & Fila.Row).Text = "" Then Continue For

                    'Si esta Activa la fila
                    If .Range("V" & Fila.Row).Text.ToString.ToUpper.Trim = "ACTIVO" Then
                        'Validar Identificar Valores de Frecuencia
                        Select Case .Range("G" & Fila.Row).Text.ToString.ToUpper.Trim
                            Case "DOMINGO"
                                Frecuencia = 1
                            Case "LUNES"
                                Frecuencia = 2
                            Case "MARTES"
                                Frecuencia = 3
                            Case "MIERCOLES"
                                Frecuencia = 4
                            Case "JUEVES"
                                Frecuencia = 5
                            Case "VIERNES"
                                Frecuencia = 6
                            Case "SABADO"
                                Frecuencia = 7
                            Case "RESULTAS"
                                Frecuencia = 8
                            Case Else
                                Tr.Rollback()
                                Cnn.Close()
                                .Range("G" & Fila.Row).Select()
                                Xls.Visible = True
                                Xls = Nothing
                                Return "En la Celda: 'G" & Fila.Row & "' debe seleccionar la Frecuencia."
                        End Select

                        'Validar que se seleccionaran los clientes
                        If .Range("D" & Fila.Row).Value = 0 Then
                            'Cliente Principal
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("E" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'E" & Fila.Row & "' la Sucursal, Clave o/y Cliente estan Incorrectos."
                        ElseIf .Range("BA" & Fila.Row).Value = 0 Then
                            'Cliente Origen
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("J" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'J" & Fila.Row & "' la Sucursal, Clave o/y Cliente estan Incorrectos."
                        ElseIf .Range("BB" & Fila.Row).Value = 0 Then
                            'Cliente Destino
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("P" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'P" & Fila.Row & "' la Sucursal, Clave o/y Cliente estan Incorrectos."
                        End If

                        'Validar que sea una fecha correcta y la Fecha Inicio se mayor o Igual a la fecha actual
                        If Not Date.TryParse(.Range("H" & Fila.Row).Value, ResultadoFecha) AndAlso .Range("H" & Fila.Row).Value < Today.Date Then
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("H" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'H" & Fila.Row & "' la Fecha es Incorrecta o la Fecha Ingresada debe de ser igual o mayor a la Fecha Actual."
                        End If

                        'Validar e Identificar Valores
                        Select Case .Range("L" & Fila.Row).Text.ToString.ToUpper.Trim
                            Case "CADA 1 SEMANA"
                                Tipo_Frecuencia = "S"
                            Case "CADA 2 SEMANAS"
                                Tipo_Frecuencia = "Q"
                            Case "CADA 4 SEMANAS"
                                Tipo_Frecuencia = "M"
                            Case Else
                                Tr.Rollback()
                                Cnn.Close()
                                .Range("L" & Fila.Row).Select()
                                Xls.Visible = True
                                Xls = Nothing
                                Return "En la Celda: 'L" & Fila.Row & "' debe seleccionar el Tipo de la Frecuencia."
                        End Select

                        'Validar las Horas
                        If .Range("M" & Fila.Row).Text.ToString.Trim = "" Then
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("M" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'M" & Fila.Row & "' debe ingresar la Hora 'De:' de Recolección."
                        ElseIf .Range("N" & Fila.Row).Text.ToString.Trim = "" Then
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("N" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'N" & Fila.Row & "' debe ingresar la Hora 'A:' de Recolección."
                        ElseIf .Range("S" & Fila.Row).Text.ToString.Trim = "" Then
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("S" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'S" & Fila.Row & "' debe ingresar la Hora 'De:' de Entrega."
                        ElseIf .Range("T" & Fila.Row).Text.ToString.Trim = "" Then
                            Tr.Rollback()
                            Cnn.Close()
                            .Range("T" & Fila.Row).Select()
                            Xls.Visible = True
                            Xls = Nothing
                            Return "En la Celda: 'T" & Fila.Row & "' debe ingresar la Hora 'A:' de Entrega."
                        End If

                        'Validar Identificar Valores de Día de Entrega
                        Select Case .Range("R" & Fila.Row).Text.ToString.ToUpper.Trim
                            Case "DOMINGO"
                                DiaEntrega = 1
                            Case "LUNES"
                                DiaEntrega = 2
                            Case "MARTES"
                                DiaEntrega = 3
                            Case "MIERCOLES"
                                DiaEntrega = 4
                            Case "JUEVES"
                                DiaEntrega = 5
                            Case "VIERNES"
                                DiaEntrega = 6
                            Case "SABADO"
                                DiaEntrega = 7
                            Case "RESULTAS"
                                DiaEntrega = 8
                            Case Else
                                Tr.Rollback()
                                Cnn.Close()
                                .Range("R" & Fila.Row).Select()
                                Xls.Visible = True
                                Xls = Nothing
                                Return "En la Celda: 'R" & Fila.Row & "' debe seleccionar el Día de Entrega."
                        End Select

                        'Validar Identificar Valores de Escala en Bóveda
                        Select Case .Range("U" & Fila.Row).Text.ToString.ToUpper.Trim
                            Case "SI"
                                EscalaBoveda = "S"
                            Case "NO"
                                EscalaBoveda = "N"
                            Case Else
                                Tr.Rollback()
                                Cnn.Close()
                                .Range("U" & Fila.Row).Select()
                                Xls.Visible = True
                                Xls = Nothing
                                Return "En la Celda: 'U" & Fila.Row & "' debe de seleccionar si se hará o no Escala en Bóveda."
                        End Select

                        'Revisar si es Registro Nuevo o Temporal o Real
                        If .Range("BC" & Fila.Row).Value = "N" Then
                            'Crear Nuevo Horario Temporal
                            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Create")
                            Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, .Range("A" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, .Range("H" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
                            Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
                            Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, .Range("BA" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, .Range("M" & Fila.Row).Text & "/" & .Range("N" & Fila.Row).Text)
                            Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, .Range("BB" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, .Range("S" & Fila.Row).Text & "/" & .Range("T" & Fila.Row).Text)
                            Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, EscalaBoveda)
                            If Frecuencia = DiaEntrega Then
                                Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, "S")
                            Else
                                Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, "N")
                            End If
                            Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, DiaEntrega)
                            Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                            Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 1)
                            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                            Crea_Parametro(cmd, "@Cobrar_RE", SqlDbType.VarChar, "R")
                            Crea_Parametro(cmd, "@Cargo_ODC", SqlDbType.VarChar, "O")
                            Crea_Parametro(cmd, "@Una_Vez", SqlDbType.VarChar, "N")
                        ElseIf .Range("BC" & Fila.Row).Value = "T" Then
                            'Editar Horario Temporal
                            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Update")
                            Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, .Range("C" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, .Range("H" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
                            Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
                            Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, .Range("BA" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, .Range("M" & Fila.Row).Text & "/" & .Range("N" & Fila.Row).Text)
                            Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, .Range("BB" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, .Range("S" & Fila.Row).Text & "/" & .Range("T" & Fila.Row).Text)
                            Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, EscalaBoveda)
                            If Frecuencia = DiaEntrega Then
                                Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, "S")
                            Else
                                Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, "N")
                            End If
                            Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, DiaEntrega)
                            Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                        Else
                            'Editar Horario Real.   Si se edita Horario Real crear un Nuevo Horario Temporal
                            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Create")
                            Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, .Range("B" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, .Range("A" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, .Range("H" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Tipo_Frecuencia)
                            Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, Frecuencia)
                            Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, .Range("BA" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, .Range("M" & Fila.Row).Text & "/" & .Range("N" & Fila.Row).Text)
                            Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, .Range("BB" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, .Range("S" & Fila.Row).Text & "/" & .Range("T" & Fila.Row).Text)
                            Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, EscalaBoveda)
                            If Frecuencia = DiaEntrega Then
                                Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, "S")
                            Else
                                Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, "N")
                            End If
                            Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, DiaEntrega)
                            Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                            Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, 0)
                            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 2)
                            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                            Crea_Parametro(cmd, "@Cobrar_RE", SqlDbType.VarChar, "R")
                            Crea_Parametro(cmd, "@Cargo_ODC", SqlDbType.VarChar, "O")
                            Crea_Parametro(cmd, "@Una_Vez", SqlDbType.VarChar, "N")
                        End If
                        EjecutarNonQueryT(cmd)
                    ElseIf .Range("V" & Fila.Row).Text.ToString.ToUpper.Trim = "BAJA" AndAlso .Range("BC" & Fila.Row).Value <> "N" Then
                        'Se dará de Baja horarios Temporales o Reales (omitiendo los registros nuevos con status baja)
                        If .Range("BC" & Fila.Row).Value = "T" Then
                            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "cat_ClientesHorariosTemp_Delete")
                            Crea_Parametro(cmd, "@Id_Htemp", SqlDbType.Int, .Range("C" & Fila.Row).Value)
                        Else
                            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "cat_ClientesHorarios_UpdateStatus")
                            Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, .Range("B" & Fila.Row).Value)
                            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "B")
                        End If
                        EjecutarNonQueryT(cmd)
                    ElseIf .Range("V" & Fila.Row).Text.ToString.Trim = "" Then
                        Tr.Rollback()
                        Cnn.Close()
                        .Range("V" & Fila.Row).Select()
                        Xls.Visible = True
                        Xls = Nothing
                        Return "En la Celda: 'V" & Fila.Row & "' debe de seleccionar el Status del Horario."
                    End If
                Next
                Xls.Application.DisplayAlerts = False
                Xls.ActiveWorkbook.Close(Savechanges:=False)
                Xls.Application.DisplayAlerts = True
                Xls = Nothing
                Tr.Commit()
                Cnn.Close()
                Return "Se Modificaron los Datos Correctamente."
            End With
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            Xls.Application.DisplayAlerts = False
            Xls.ActiveWorkbook.Close(Savechanges:=False)
            Xls.Application.DisplayAlerts = True
            Xls = Nothing
            TrataEx(ex, False)
            Return "Error al Importar el Archivo de Excel."
        End Try
    End Function

#End Region

#Region "DESCARGA MANUAL DE USUARIO"

    Public Shared Function fn_Archivos_Descargar(ByVal Id_Doc As Integer) As Byte()
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Doc", SqlDbType.Int, Id_Doc)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Archivo")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ModulosArchivos_LlenarLista(ByRef lsv As cp_Listview, ByVal Clave_Modulo As String) As Boolean

        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Try
            lsv.Actualizar(Cmd, "Id_Doc")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "FUNCION CUENTA SETTINGS"

    Public Shared Function fn_CuentaSettings() As Integer
        Dim CuentaSettings As Integer = 0
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" AndAlso (My.Settings(setting.Name)).ToString.Split(",")(0) = "VACIO" Then
                CuentaSettings += 1
            End If
        Next
        Return CuentaSettings
    End Function

#End Region

#Region "MapaClientes"

    Public Shared Function fn_ObtenerLatLon(ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetLatLon", CommandType.StoredProcedure, Cnn)
        Try
            lsv.Actualizar(Cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_GuardarLatLon(ByVal Id_Cliente As Integer, ByVal Lat As Decimal, ByVal Lon As Decimal) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clientes_UpdateLatLon", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@Latitud", SqlDbType.Decimal, Lat)
        Crea_Parametro(Cmd, "@Longitud", SqlDbType.Decimal, Lon)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function
#End Region

#Region "Cuentas Por Cliente"

    Public Shared Function fn_CuentasPorCliente_LlenarLista(ByVal Lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Id_Compañia As Integer, ByVal Id_ClienteP As Integer, ByVal StatusCliente As String, ByVal StatusCuenta As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Pro_Cuentas_GetReporte", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Compañia)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(Cmd, "@StatusCliente", SqlDbType.VarChar, StatusCliente)
        Crea_Parametro(Cmd, "@StatusCuenta", SqlDbType.VarChar, StatusCuenta)
        Try
            Lsv.Actualizar(Cmd, "")
            Lsv.Columns(10).Width = 100
            Lsv.Columns(11).Width = 100
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Clausulas"

    Public Shared Function fn_Clausulas_LlenarLista(ByVal Status As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clausulas_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clausulas_LlenarDetalle(ByVal Id_Clausula As Integer, ByVal Status As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClausulasD_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, Id_Clausula)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Clausulas_Guardar(ByVal Descripcion As String, ByVal Comentarios As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clausulas_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion, False)
        Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clausulas_GuardarD(ByVal Id_Clausula As Integer, ByVal Descripcion As String, ByVal Comentarios As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClausulasD_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, Id_Clausula)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
        Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clausulas_Modificar(ByVal Id_Clausula As Integer, ByVal Descripcion As String, ByVal Comentarios As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clausulas_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, Id_Clausula)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion, False)
        Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clasulas_ModificarD(ByVal Id_ClausulaD As Integer, ByVal Descripcion As String, ByVal Comentarios As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClausulasD_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_ClausulaD", SqlDbType.Int, Id_ClausulaD)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
        Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clausulas_Status(ByVal Dgv As DataGridView, ByVal Observaciones As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            For Each dr_Clausula As DataGridViewRow In Dgv.Rows
                Dim dgvchk As DataGridViewCheckBoxCell = dr_Clausula.Cells("Marcar")
                If dgvchk.Value = True Then

                    Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Clasulas_Status")
                    Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, dr_Clausula.Cells("Id_Clausula").Value)
                    Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
                    Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, IIf(dr_Clausula.Cells("Status").Value = "ACTIVO", "B", "A"))

                    EjecutarNonQueryT(Cmd)

                End If
            Next
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Clausulas_StatusD(ByVal Dgv As DataGridView, ByVal Observaciones As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            For Each dr_Clausula As DataGridViewRow In Dgv.Rows
                Dim dgvchk As DataGridViewCheckBoxCell = dr_Clausula.Cells("MarcarD")
                If dgvchk.Value = True Then

                    Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClasulasD_Status")
                    Crea_Parametro(Cmd, "@Id_ClasulaD", SqlDbType.Int, dr_Clausula.Cells("Id_ClausulaD").Value)
                    Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
                    Crea_Parametro(Cmd, "@Status", SqlDbType.Text, IIf(dr_Clausula.Cells("StatusD").Value = "ACTIVO", "B", "A"))

                    EjecutarNonQueryT(Cmd)

                End If
            Next
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contratos_DeleteContrato(ByVal Id_Contrato As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try

            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesContratosD_DeleteXId_Contrato")
            Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
            EjecutarNonQueryT(Cmd)

            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesContratos_Delete")
            Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
            EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, True)
            Return False
        End Try
        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_Contratos_ClausulaEnContrato(ByVal Id_Clausula As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratosD_Existe", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, Id_Clausula)
        Try
            If EjecutaConsulta(Cmd).Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try



    End Function

#End Region

#Region "Contratos"

    Public Shared Function fn_Contratos_Guardar(ByVal Numero_Contrato As Integer, ByVal Fecha_Contrato As Date,
                                                ByVal Fecha_Inicio As Date, ByVal Fecha_Fin As Date, ByVal Id_Cliente As Integer,
                                                ByVal Firma_Empresa As String, ByVal Puesto_Empresa As String,
                                                ByVal Testigo_Empresa As String, ByVal Id_CiudadFirma As Integer, ByVal Firma_Cliente As String,
                                                ByVal Puesto_Cliente As String, ByVal Testigo_Cliente As String, ByVal Observaciones As String,
                                                ByVal Datos_Poder_Emp As String, ByVal Datos_Poder_Cli As String, ByVal Id_Renovado As Integer) As Integer
        Dim Numero As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratos_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Numero_Contrato", SqlDbType.Int, Numero_Contrato)
        Crea_Parametro(Cmd, "@Fecha_Contrato", SqlDbType.Date, Fecha_Contrato)
        Crea_Parametro(Cmd, "@Fecha_Inicio", SqlDbType.Date, Fecha_Inicio)
        Crea_Parametro(Cmd, "@Fecha_Fin", SqlDbType.Date, Fecha_Fin)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Firma_Empresa", SqlDbType.VarChar, Firma_Empresa)
        Crea_Parametro(Cmd, "@Puesto_Empresa", SqlDbType.VarChar, Puesto_Empresa)
        Crea_Parametro(Cmd, "@Testigo_Empresa", SqlDbType.VarChar, Testigo_Empresa)
        Crea_Parametro(Cmd, "@Id_CiudadFirma", SqlDbType.Int, Id_CiudadFirma)
        Crea_Parametro(Cmd, "@Firma_Cliente", SqlDbType.VarChar, Firma_Cliente)
        Crea_Parametro(Cmd, "@Puesto_Cliente", SqlDbType.VarChar, Puesto_Cliente)
        Crea_Parametro(Cmd, "@Testigo_Cliente", SqlDbType.VarChar, Testigo_Cliente)
        Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(Cmd, "@Datos_Poder_Emp", SqlDbType.VarChar, Datos_Poder_Emp)
        Crea_Parametro(Cmd, "@Datos_Poder_Cli", SqlDbType.VarChar, Datos_Poder_Cli)
        Crea_Parametro(Cmd, "@Id_Renovado", SqlDbType.Int, Id_Renovado)
        Try
            Numero = EjecutarScalar(Cmd)
            Return Numero
        Catch ex As Exception
            TrataEx(ex, True)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Contratos_Existe(ByVal Id_Cliente As Integer) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratos_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try

            If EjecutaConsulta(Cmd).Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex, True)
            Return True
        End Try
    End Function

    Public Shared Function fn_Contratos_Read(ByVal Id_Contrato As Integer, ByVal Id_Cliente As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratos_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Contratos_Status(ByVal Id_Contrato As Integer, ByVal Observaciones As String, ByVal Status As String) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratos_Status", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
        Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_Contratos_Modificar(ByVal Id_Contrato As Integer, ByVal Fecha_Contrato As Date,
                                                ByVal Fecha_Inicio As Date, ByVal Fecha_Fin As Date, ByVal Id_Cliente As Integer,
                                                ByVal Firma_Empresa As String, ByVal Puesto_Empresa As String,
                                                ByVal Testigo_Empresa As String, ByVal Id_CiudadFirma As Integer, ByVal Firma_Cliente As String,
                                                ByVal Puesto_Cliente As String, ByVal Testigo_Cliente As String, ByVal Observaciones As String,
                                                ByVal Datos_Poder_Emp As String, ByVal Datos_Poder_Cli As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratos_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
        Crea_Parametro(Cmd, "@Fecha_Contrato", SqlDbType.Date, Fecha_Contrato)
        Crea_Parametro(Cmd, "@Fecha_Inicio", SqlDbType.Date, Fecha_Inicio)
        Crea_Parametro(Cmd, "@Fecha_Fin", SqlDbType.Date, Fecha_Fin)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Firma_Empresa", SqlDbType.VarChar, Firma_Empresa)
        Crea_Parametro(Cmd, "@Puesto_Empresa", SqlDbType.VarChar, Puesto_Empresa)
        Crea_Parametro(Cmd, "@Testigo_Empresa", SqlDbType.VarChar, Testigo_Empresa)
        Crea_Parametro(Cmd, "@Id_CiudadFirma", SqlDbType.Int, Id_CiudadFirma)
        Crea_Parametro(Cmd, "@Firma_Cliente", SqlDbType.VarChar, Firma_Cliente)
        Crea_Parametro(Cmd, "@Puesto_Cliente", SqlDbType.VarChar, Puesto_Cliente)
        Crea_Parametro(Cmd, "@Testigo_Cliente", SqlDbType.VarChar, Testigo_Cliente)
        Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
        Crea_Parametro(Cmd, "@Datos_Poder_Emp", SqlDbType.VarChar, Datos_Poder_Emp)
        Crea_Parametro(Cmd, "@Datos_Poder_Cli", SqlDbType.VarChar, Datos_Poder_Cli)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_Contratos_LlenarClausulas(ByVal Id_Contrato As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClienteContratosD_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Contratos_GuardarDetalle(ByVal dt_ClausulasAdd As DataTable, ByVal Id_Contrato As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            For Each clau As DataRow In dt_ClausulasAdd.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesContratosD_Create")
                Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
                Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, clau("Id_Clausula"))
                Crea_Parametro(Cmd, "@Numero_Clausula", SqlDbType.Int, clau("Numero_Clausula"))
                Crea_Parametro(Cmd, "@Numero_Ordinario", SqlDbType.VarChar, clau("Numero_Ordinario"))
                EjecutarNonQueryT(Cmd)
            Next
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contratos_GuardarDetalleModif(ByVal dt_ClausulasAdd As DataTable, ByVal Id_Contrato As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            Dim Dt As DataTable = fn_Contratos_LlenarClausulas(Id_Contrato)
            For Each clau As DataRow In dt_ClausulasAdd.Rows
                BanderA = False
                If Dt.Rows.Count = 0 Then BanderA = False
                For Each Dr As DataRow In Dt.Rows
                    If Dr("Id_Clausula") = clau("Id_Clausula") Then
                        BanderA = True
                    End If
                Next
                If BanderA = False Then
                    Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesContratosD_Create")
                    Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
                    Crea_Parametro(Cmd, "@Id_Clausula", SqlDbType.Int, clau("Id_Clausula"))
                    Crea_Parametro(Cmd, "@Numero_Clausula", SqlDbType.Int, clau("Numero_Clausula"))
                    Crea_Parametro(Cmd, "@Numero_Ordinario", SqlDbType.VarChar, clau("Numero_Ordinario"))
                    EjecutarNonQueryT(Cmd)
                End If
            Next
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contratos_LlenarContratos(ByVal Lsv As cp_Listview, ByVal Id_Cliente As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratos_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try
            Lsv.Actualizar(Cmd, "Id_Contrato")
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function


    Public Shared Function fn_Contrato_Reporte(ByVal Id_Contrato As Integer, ByVal Dt As DataTable) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clausulas_GetReporte", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@id_Contrato", SqlDbType.Int, Id_Contrato)
        Try
            Dt.Rows.Clear()
            Cmd.Connection.Open()
            Dt.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contratos_NumClausulas(ByVal Id_Contrato As Integer) As Boolean
        Dim Numero As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Clausulas_GetReporte", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
        Try
            If EjecutaConsulta(Cmd).Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contratos_Delete(ByVal Id_Contrato As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesContratosD_Delete", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Contrato", SqlDbType.Int, Id_Contrato)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

#End Region

    Public Shared Function LlenarMilesSCosto_Dt(ByVal Id_CR As Integer, Optional ByVal Agregar_Selecione As Boolean = True) As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_CuotaRiesgo_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Referencias_Eliminar(ByVal Id_Referencia As Integer) As Integer
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand
        Try
            cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Pro_Fichas_GetReferencia")
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)

            Dim dt_referencias As DataTable = EjecutaConsultaT(cmd)

            If dt_referencias IsNot Nothing AndAlso dt_referencias.Rows.Count > 0 Then
                tr.Commit()
                cnn.Close()
                Return 0 ' si existe  registro con esa referecnia
            Else

                'elimianr las tablas
                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesPreferencias_Delete")
                Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
                EjecutarNonQueryT(cmd)

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Pro_CuentasReferencias_Delete")
                Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
                EjecutarNonQueryT(cmd)

                tr.Commit()
                cnn.Close()
                Return 1
            End If
        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return -1
        End Try

    End Function

    ''' <summary>
    ''' Esta funcion nos sirve para comprobar si los datos contpaq del cliente 
    ''' estan ingresados o no.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function Fn_VerifcarDatosContpaq(ByVal Id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("ComprobarDatosContpaq", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Dim tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Return tbl.Rows(0)
        Else
            Return Nothing
        End If
    End Function
#Region "22/sep/2014 -- Clonar Servicios-Horarios de Padres --> Hijos(Nuevos)"

    Public Shared Function fn_Clientes_Servicios_LlenarLista(ByVal Id_Cliente As Integer, ByRef lsv As cp_Listview, ByVal Status As String, ByVal Traslado As String) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_Get2", CommandType.StoredProcedure, cnn)
        Try
            Crea_Parametro(cmd, "@IdCliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Traslado", SqlDbType.VarChar, Traslado)
            lsv.Actualizar(cmd, "Id_CS")

            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).Width = 0
            lsv.Columns(8).Width = 0
            '--------------si es TV mostar Todas columnas-----
            If Traslado = "S" Then
                lsv.Columns(10).Width = 100
                lsv.Columns(11).Width = 100
                lsv.Columns(6).TextAlign = HorizontalAlignment.Right
                lsv.Columns(8).TextAlign = HorizontalAlignment.Right
                lsv.Columns(10).TextAlign = HorizontalAlignment.Right
                lsv.Columns(11).TextAlign = HorizontalAlignment.Right
            Else
                lsv.Columns(10).Width = 0
                lsv.Columns(11).Width = 0
            End If
            For contador2 As Integer = 12 To lsv.Columns.Count - 1
                lsv.Columns(contador2).Width = 0
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Clonar(ByVal FechaInicio As Date, ByVal lsv_Subclientes As cp_Listview, ByVal lsv_Servicios As cp_Listview) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim cmd As SqlCommand
        Try
            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesServicios_Create")
            'Por cada Subcliente marcado insertará todos los servicios_otros-4/10/2014
            For Each subliente As ListViewItem In lsv_Subclientes.CheckedItems
                For Each Elemento As ListViewItem In lsv_Servicios.CheckedItems
                    cmd.Parameters.Clear()
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, subliente.Tag) 'Id_clientedela Lista
                    Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, FechaInicio) 'FechaNueva
                    Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Elemento.SubItems(11).Text)
                    Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Elemento.SubItems(12).Text)
                    Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Elemento.SubItems(13).Text)
                    Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Elemento.SubItems(14).Text)
                    Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Elemento.SubItems(15).Text)
                    Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Elemento.SubItems(16).Text)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Elemento.SubItems(17).Text)
                    Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Elemento.SubItems(18).Text)
                    Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Elemento.SubItems(19).Text)
                    Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Elemento.SubItems(20).Text)
                    Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Elemento.SubItems(21).Text)
                    Crea_Parametro(cmd, "@Cobrado", SqlDbType.VarChar, Elemento.SubItems(22).Text)
                    Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Elemento.SubItems(23).Text)
                    Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Elemento.SubItems(24).Text)
                    Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Elemento.SubItems(25).Text)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    EjecutarNonQueryT(cmd)
                Next
            Next
            Tr.Commit()
            Cnn.Close()
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Horarios_Clonar(ByVal FechaInicio As Date, ByVal lsv_ServicioTV As cp_Listview, ByVal lsv_Subclientes As cp_Listview, ByVal lsv_Horarios As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Dim ID_CS As Integer = 0
        Dim cmd As SqlCommand
        Try
            Dim Contador As Integer = 0
            'Por cada SubCliente marcado insertará 1Solo Servicio y todos los horarios marcados
            For Each subliente As ListViewItem In lsv_Subclientes.CheckedItems
                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesServicios_Create")
                For Each Elemento As ListViewItem In lsv_ServicioTV.SelectedItems
                    'entra solo 1 vez porque es un 1 solo item seleccionado
                    cmd.Parameters.Clear()
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, subliente.Tag) 'Id_cliente
                    Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, FechaInicio) 'fechaNueva
                    Crea_Parametro(cmd, "@Cantidad_Kilometros", SqlDbType.Int, Elemento.SubItems(11).Text)
                    Crea_Parametro(cmd, "@Cobro_Unico", SqlDbType.VarChar, Elemento.SubItems(12).Text)
                    Crea_Parametro(cmd, "@Tv_Predeterminado", SqlDbType.VarChar, Elemento.SubItems(13).Text)
                    Crea_Parametro(cmd, "@Recoleccion", SqlDbType.VarChar, Elemento.SubItems(14).Text)
                    Crea_Parametro(cmd, "@Entrega_Dotaciones", SqlDbType.VarChar, Elemento.SubItems(15).Text)
                    Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Elemento.SubItems(16).Text)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Elemento.SubItems(17).Text)
                    Crea_Parametro(cmd, "@Id_PrecioDescripcion", SqlDbType.Int, Elemento.SubItems(18).Text)
                    Crea_Parametro(cmd, "@Id_Concepto", SqlDbType.Int, Elemento.SubItems(19).Text)
                    Crea_Parametro(cmd, "@Id_Material", SqlDbType.Int, Elemento.SubItems(20).Text)
                    Crea_Parametro(cmd, "@Id_Precio", SqlDbType.Int, Elemento.SubItems(21).Text)
                    Crea_Parametro(cmd, "@Cobrado", SqlDbType.VarChar, Elemento.SubItems(22).Text)
                    Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Elemento.SubItems(23).Text)
                    Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Elemento.SubItems(24).Text)
                    Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Elemento.SubItems(25).Text)
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    ID_CS = EjecutarScalarT(cmd)
                Next
                For Each fila As ListViewItem In lsv_Horarios.CheckedItems
                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_ClientesHorariosTemp_Create")
                    cmd.Parameters.Clear()
                    Crea_Parametro(cmd, "@Id_CH", SqlDbType.Int, 0) ' cuando es Subcliente lleva 0 ??
                    Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, ID_CS) 'se obtendra ahora del ExecuteScalar)
                    Crea_Parametro(cmd, "@Fecha_Inicio", SqlDbType.DateTime, FechaInicio) 'enviarNuevo

                    Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, fila.SubItems(17).Text) ' rutarecolecta, IDR
                    Crea_Parametro(cmd, "@Tipo_Frecuencia", SqlDbType.VarChar, Left(fila.SubItems(1).Text, 1)) 'obtener 1ra letra
                    Crea_Parametro(cmd, "@Frecuencia", SqlDbType.VarChar, fila.SubItems(9).Text)

                    Crea_Parametro(cmd, "@Cliente_Origen", SqlDbType.Int, subliente.Tag) ''fila.SubItems(19).Text
                    Crea_Parametro(cmd, "@H_Recoleccion", SqlDbType.VarChar, fila.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Cliente_Destino", SqlDbType.Int, fila.SubItems(20).Text)

                    Crea_Parametro(cmd, "@H_Entrega", SqlDbType.VarChar, fila.SubItems(6).Text) ' 
                    Crea_Parametro(cmd, "@Escala_Boveda", SqlDbType.VarChar, fila.SubItems(10).Text)
                    Crea_Parametro(cmd, "@Mismo_Dia", SqlDbType.VarChar, fila.SubItems(11).Text)
                    Crea_Parametro(cmd, "@Dia_Entrega", SqlDbType.VarChar, fila.SubItems(12).Text)
                    Crea_Parametro(cmd, "@Id_RutaE", SqlDbType.Int, fila.SubItems(18).Text)

                    Crea_Parametro(cmd, "@Cargo_ODC", SqlDbType.VarChar, fila.SubItems(13).Text) ' cargo A
                    Crea_Parametro(cmd, "@Cobrar_RE", SqlDbType.VarChar, fila.SubItems(14).Text) 'facturar
                    Crea_Parametro(cmd, "@Una_Vez", SqlDbType.VarChar, fila.SubItems(15).Text) 'ChekBox
                    Crea_Parametro(cmd, "@Prioridad", SqlDbType.Int, fila.SubItems(16).Text) ' Mismaque tiene elHorario

                    Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 1) ' modificacion=0 ó nuevoHorario=1 Siempre
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                    Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    EjecutarNonQueryT(cmd)
                Next
            Next
            tr.Commit()
            cnn.Close()
            Return True
        Catch ex As Exception
            tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Horarios_LlenarListaClonar(ByVal Id_CS As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesHorarios_Get2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A") 'solo activos

            lsv.Actualizar(cmd, "Id_CH")
            For I As Integer = 9 To lsv.Columns.Count - 1
                lsv.Columns(I).Width = 0
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Clientes_LlenarListaHijos(ByVal lsv As cp_Listview, ByVal Id_Padre As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim Cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetHijos", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(Cmd, "@AgregarPadre", SqlDbType.VarChar, "N")
            lsv.Actualizar(Cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "Reporte General de Horarios"

    Public Shared Function fn_Clientes_ReporteGeneralHorarios(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer,
                                                              ByVal Origen As Integer, ByVal Destino As Integer,
                                                              ByVal IncluirSubclientes As String, ByVal Status As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_GetReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Origen", SqlDbType.Int, Origen)
            Crea_Parametro(cmd, "@Destino", SqlDbType.Int, Destino)
            Crea_Parametro(cmd, "@Traslado", SqlDbType.VarChar, "S")
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@SubClientes", SqlDbType.VarChar, IncluirSubclientes)
            lsv.Actualizar(cmd, "Id_CH")
            lsv.Columns(10).Width = 100
            lsv.Columns(11).Width = 120
            lsv.Columns(12).Width = 80
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region


#Region "Reporte General de Servicio"

    Public Shared Function fn_Clientes_ReporteGeneralServcio(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Status As String, ByVal IncluirSubclientes As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServiciosReporte_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@IdCliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Traslado", SqlDbType.VarChar, "S")
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@SubClientes", SqlDbType.VarChar, IncluirSubclientes)

            lsv.Actualizar(cmd, "Id_CS")
            'lsv.Columns(10).Width = 100
            'lsv.Columns(11).Width = 120
            'lsv.Columns(12).Width = 80

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region






#Region "Catalogo de Grupos para clientes 25-sep-15"
    Public Shared Function fn_ClientesGrupos_NuevoGrupo(ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGrupos_Create", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Return EjecutarScalar(Cmd)

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_ActualizarGrupo(ByVal Id_ClienteGrupo As Integer, ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGrupos_Update", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_ListarGrupos(ByRef lsv As cp_Listview) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGrupos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            lsv.Actualizar(Cmd, "Id_ClienteGrupo")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_EliminarGrupo(ByVal Id_ClienteGrupo As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGrupos_Delete", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_ExisteGrupo(ByVal Descripcion As String) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGrupos_Existe", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Dim Id As Integer = EjecutarScalar(Cmd)
            Return Id
        Catch ex As Exception
            TrataEx(ex, False)
            Return -1
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_Dependencias(ByVal Id_ClienteGrupo As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGrupos_Dependencias", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            Dim Id As Integer = EjecutarScalar(Cmd)
            Return Id
        Catch ex As Exception
            TrataEx(ex, False)
            Return -1
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_ListaClientes(ByRef lsv As cp_Listview, ByVal Status As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_Clientes_GetCompacto", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            lsv.Actualizar(Cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_ListaClientesxGrupo(ByRef lsv As cp_Listview, ByVal Id_ClienteGrupo As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesGruposD_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            lsv.Actualizar(Cmd, "Id_ClienteGrupoD")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesGrupos_AgregarCliente(ByVal lsv As cp_Listview, ByVal Id_ClienteGrupo As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand = Nothing
        Try
            Dim Id As Integer = 0
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesGruposD_Create")
            For Each ItemCliente As ListViewItem In lsv.CheckedItems
                Crea_Parametro(Cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
                Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, ItemCliente.Tag)
                Id = EjecutarScalarT(Cmd)
                If Id = 0 Then
                    Tr.Rollback()
                    Return False
                Else
                    Cmd.Parameters.Clear()
                End If
            Next

            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_ClientesGrupos_EliminarCliente(ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand = Nothing
        Try
            Dim Id As Integer = 0
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesGruposD_Delete")
            For Each ItemCliente As ListViewItem In lsv.CheckedItems
                Crea_Parametro(Cmd, "@Id_ClienteGrupoD", SqlDbType.Int, ItemCliente.Tag)
                EjecutarNonQueryT(Cmd)
                Cmd.Parameters.Clear()
            Next

            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
    End Function


#End Region

#Region "ALERTAS CLIENTES 01-Oct-15"

    Public Shared Function fn_ClientesAlertas_Guardar(ByVal Clave_Alerta As String, ByVal Id_Cliente As Integer, ByVal Alerta_Recoleccion As String,
                                                      ByVal Alerta_Entrega As String,
                                                      ByVal Tipo_Cliente As Integer, ByVal Modo_Alerta As Integer, ByVal Id_Contacto As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_ClientesContactosAlertas_Create", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(Cmd, "@Clave_Alerta", SqlDbType.VarChar, Clave_Alerta)
            Crea_Parametro(Cmd, "@Tipo_Cliente", SqlDbType.TinyInt, Tipo_Cliente)
            Crea_Parametro(Cmd, "@Id_Contacto", SqlDbType.Int, Id_Contacto)
            Crea_Parametro(Cmd, "@Modo_Alerta", SqlDbType.TinyInt, Modo_Alerta)
            Crea_Parametro(Cmd, "@Alerta_Recoleccion", SqlDbType.VarChar, Alerta_Recoleccion)
            Crea_Parametro(Cmd, "@Alerta_Entrega", SqlDbType.VarChar, Alerta_Entrega)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            Return EjecutarScalar(Cmd)

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesAlertas_Lista(ByRef lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Status As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_CientesContactosAlertas_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(Cmd, "Id_ClienteContactoAlerta")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesAlertas_ListaClientes(ByRef lsv As cp_Listview, ByVal Id_Padre As Integer, ByVal Status As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_Clientes_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(Cmd, "@AgregarPadre", SqlDbType.VarChar, "S")

            lsv.Actualizar(Cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesAlertas_EliminarContacto(ByVal Id_ClienteContactoAlerta As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Nothing
        Try
            Cmd = Crea_Comando("Cat_CientesContactosAlertas_Delete", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ClienteContactoAlerta", SqlDbType.Int, Id_ClienteContactoAlerta)

            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function


#End Region


#Region "Administracion de Caset"

    Public Shared Function fn_Kardex_Catalogo_BajaAlta(ByVal IdCodigo_Barra As String, ByVal Status As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Kardex_Status", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Codigo_Barra", SqlDbType.VarChar, IdCodigo_Barra)
        Crea_Parametro(Cmd, "@Status", SqlDbType.Int, Status)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try

    End Function
    Public Shared Function fn_Kardex_Catalogo_ObtenValores(ByVal IdCodigo_Barra As String) As DataRow

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Kardex_Caset_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Codigo_Barra", SqlDbType.Int, IdCodigo_Barra)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function



#End Region

#Region "Control Caset"

    Public Shared Function fn_Kardex_Caset_Disponibles(ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            lsv.Actualizar(cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_AsignaCliente(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Fecha As Date)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)

            For Each item As ListViewItem In lsv.CheckedItems

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetAsignaCliente_Insert")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(item.Tag))
                Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Fecha_Asigna", SqlDbType.Date, Fecha)
                Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
                EjecutarNonQueryT(cmd)

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateAsignado")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(item.Tag))
                Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "AC")
                EjecutarNonQueryT(cmd)

            Next

            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_CasetAsignaCliente_Disponibles(ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAsignaCliente_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            lsv.Actualizar(cmd, "Id_Asignacion")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_Read(ByVal Codigo_Barras As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@CodigoBarra", SqlDbType.VarChar, Codigo_Barras)
            Dim dt = EjecutaConsulta(cmd)

            If dt.Rows.Count > 0 Then Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        Finally
            cnn.Dispose()
            cmd.Dispose()
        End Try
    End Function

    Public Shared Function fn_kardex_Catalogo_LlenarLista(ByVal Lista As cp_Listview, ByVal Status As String) As Boolean

        Dim Cnn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        Try
            'Aqui se llena el listview
            Cnn = Cn_Datos.Crea_ConexionSTD
            Cmd = Crea_Comando("Kardex_Caset_Get1", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Lista.Actualizar(Cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        Finally
            Cnn.Dispose()
            Cmd.Dispose()
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_Insert(ByVal CodigoBarra As String, ByVal Capacidad As Integer, ByVal Id_Cliente As Integer, ByVal Serie As String, ByVal Id_Color As Integer, ByVal SeguridadInterna As String, ByVal EsRutaInicio As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Dim Caset_SISSA = CodigoBarra.Split("'")(0)
        Try

            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Create", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@CodigoBarra", SqlDbType.VarChar, CodigoBarra)
            Crea_Parametro(cmd, "@Capacidad", SqlDbType.Int, Capacidad)
            Crea_Parametro(cmd, "@Propio", SqlDbType.VarChar, If(Caset_SISSA = 1, "S", "N"))
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Serie", SqlDbType.VarChar, Serie)
            Crea_Parametro(cmd, "@Cliente_CodigoBarra", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Id_Color", SqlDbType.Int, Id_Color)
            Crea_Parametro(cmd, "@Seguridad_Interna", SqlDbType.VarChar, SeguridadInterna)
            Crea_Parametro(cmd, "@EsRutaInicio", SqlDbType.VarChar, EsRutaInicio)



            'Dim id_Caset As Integer = EjecutarScalarT(cmd)


            'If id_Caset > 0 Then
            '    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Movimientos_Create")
            '    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, id_Caset)
            '    Crea_Parametro(cmd, "@Id_Kardex_Cat_Movimiento", SqlDbType.Int, Id_Kardex_Cat_Movimiento)
            '    EjecutarNonQueryT(cmd)
            'End If

            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            cnn.Dispose()
            cmd.Dispose()
            Return False
        End Try
    End Function

    Public Shared Function fn_kardex_Caset_update(ByVal Id_Caset As Integer, ByVal Capacidad As Integer, ByVal Serie As String, ByVal Id_Color As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Update", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Capacidad", SqlDbType.Int, Capacidad)
            Crea_Parametro(cmd, "@Serie", SqlDbType.VarChar, Serie)
            Crea_Parametro(cmd, "@Id_Color", SqlDbType.Int, Id_Color)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_kardex_Caset_Baja(ByVal Id_Caset As Integer, ByVal Status As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Baja", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, If(Status = "ACTIVO", "A", "B"))
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_CasetAsignaCliente_Cancelar(ByVal Descripcion As String, lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()


            For Each item As ListViewItem In lsv.CheckedItems
                cmd = Crea_Comando("Kardex_CasetAsignaCliente_UpdateCancela", CommandType.StoredProcedure, cnn)
                Crea_Parametro(cmd, "@Id_Asignacion", SqlDbType.Int, item.Tag)
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, item.SubItems(6).Text)
                Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, UsuarioN)
                Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
                EjecutarNonQuery(cmd)
            Next
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_getSeguridad(ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_GetSegurdad", CommandType.StoredProcedure, cnn)
            lsv.Actualizar(cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_ReasiganarCP(ByVal codigoPostal As String,
                                           ByVal clave_ciudad As String,
                                           ByVal idCiudad As Integer) As Integer

        Dim fecha = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Dim cmd As SqlCommand

        Try
            cmd = Crea_Comando("ReasignarCodigoPostal", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@codigoPostal", SqlDbType.VarChar, codigoPostal)
            Crea_Parametro(cmd, "@clave_ciudad", SqlDbType.VarChar, clave_ciudad)
            Crea_Parametro(cmd, "@idCiudad", SqlDbType.Int, idCiudad)
            Crea_Parametro(cmd, "@idUsuario_Reasigno", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@fechaReasigno", SqlDbType.DateTime, fecha)
            EjecutarNonQuery(cmd)
            cmd.Connection.Close()
            Return 1
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Agregar_Colonia(ByVal idPais As Integer,
                                              ByVal claveEstado As String,
                                              ByVal claveCiudad As String,
                                              ByVal codigoPostal As String,
                                              ByVal nombreColonia As String,
                                              ByVal idEstado As Integer,
                                              ByVal idCiudad As Integer,
                                              ByVal clave_Colonia As Integer) As Integer
        Dim fecha = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("insertarColoniaPorUsuario", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@claveColonia", SqlDbType.VarChar, clave_Colonia.ToString())
            Crea_Parametro(cmd, "@idPais", SqlDbType.Int, idPais)
            Crea_Parametro(cmd, "@claveEstado", SqlDbType.VarChar, claveEstado)
            Crea_Parametro(cmd, "@claveCiudad", SqlDbType.VarChar, claveCiudad)
            Crea_Parametro(cmd, "@codigoPostal", SqlDbType.VarChar, codigoPostal)
            Crea_Parametro(cmd, "@nombreColonia", SqlDbType.VarChar, nombreColonia)
            Crea_Parametro(cmd, "@idEstado", SqlDbType.Int, idEstado)
            Crea_Parametro(cmd, "@idCiudad", SqlDbType.Int, idCiudad)
            Crea_Parametro(cmd, "@idUsuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@fechaRegistro", SqlDbType.DateTime, fecha)

            EjecutarNonQuery(cmd)
            cmd.Connection.Close()
            Return 1
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function
#End Region

    Public Shared Function fn_LlenarListaClientesFacturacionAnticipada(ByVal Lista As cp_Listview, ByVal Clave As String, TipoBusqueda As String) As Boolean

        Dim Cnn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        Try
            'Aqui se llena el listview
            Cnn = Cn_Datos.Crea_ConexionSTD
            Cmd = Crea_Comando("Clientes_ContpaqFacturaAnticipada", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave", SqlDbType.VarChar, Clave)
            Crea_Parametro(Cmd, "@TipoBusqueda", SqlDbType.VarChar, TipoBusqueda)
            Lista.Actualizar(Cmd, "Id_Cliente")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        Finally
            Cnn.Dispose()
            Cmd.Dispose()
        End Try
        Return True
    End Function
    Public Shared Function fn_LlenarListaClientesFacturacionAnticipada_Update(ByVal Id_CLiente As Integer, ByVal UUID As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Clientes_ContpaqFacturaAnticipada_Update", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_CLiente)
            Crea_Parametro(cmd, "@UUID", SqlDbType.VarChar, UUID)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function
#Region "Alertas Mora"





    Public Shared Function fn_AlertasGeneradas_Guardar_ServociosOtros(ByVal SucursalId As Integer, ByVal UsuarioId As Integer, ByVal EstacioN As String, ByVal Clave_AlertaTipo As String, ByVal Detalles As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_AlertasGeneradas_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
            Crea_Parametro(cmd, "@Detalles", SqlDbType.Text, Detalles)
            Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)   'Alerta por Incidencia
            EjecutarScalar(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_AlertasGeneradas_ObtenerMails(ByVal Clave_AlertaTipo As String) As DataTable
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_AlertasDestinos_GetMail", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            'TrataEx(ex, SucursalId, UsuarioID)
            Return Nothing
        End Try
    End Function
#End Region
#Region "Consulta de importes por recolecciones"

    Public Shared Function fn_ImportesporRecolecciones_llenarlista(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_ActasDiff_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)

        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            lsv.Actualizar(Tbl, "Id_Punto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

#Region "Ventas de Materiales"
    Public Shared Function fn_ConsultaVentas(ByVal lsv As cp_Listview, ByVal F_Desde As Date, ByVal F_Hasta As Date, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@F_Desde", SqlDbType.Date, F_Desde)
        Crea_Parametro(cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            lsv.Actualizar(cmd, "Id_MatVenta")

            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_ConsultaVentas_Detalle(ByVal lsv As cp_Listview, ByVal Id_MatVenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_VentasD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)

        Try
            lsv.Actualizar(cmd, "Id_Material")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaVentas_DetalleF(ByVal lsv As cp_Listview, ByVal Id_MatVenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_RemisionesClientes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)

        Try
            lsv.Actualizar(cmd, "Id_VentaoLote")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region
End Class
