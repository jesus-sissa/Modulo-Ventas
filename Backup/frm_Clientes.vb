Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class frm_Clientes

    Private Id_Cliente As Integer = 0
    ''' <summary> Tipo es cuando se seleccione en el Radiobutton de Cliente o Prospecto </summary>
    Private Tipo As Char = "C"
    Private BajaPermanente As Boolean = False
    Private Proceso As Boolean = False
    Dim Foco As Boolean = False
    Dim Horarios_Ubicacion As String = ""

#Region "Eventos del Formulario"

    Private Sub frm_Clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Aqui se Actualizan los Combos
        Dim Id_Puesto As Integer

        Dim Dt_Parametros As DataTable = FuncionesGlobales.fn_ParametrosGlobales()

        If Dt_Parametros Is Nothing Then
            MsgBox("Ocurrio un Error al Consultar los Parametros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Dt_Parametros.Rows.Count = 0 Then
            MsgBox("No se Encontraron los Parametros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Id_Puesto = Dt_Parametros.Rows(0)("Puesto_Ventas")
        Dt_Parametros.Dispose()

        cmb_Ejecutivo.AgregaParametro("@Id_Puesto", Id_Puesto, 1)
        cmb_Ejecutivo.Actualizar()

        cmb_ZonaF.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ZonaF.Actualizar()
        cmb_ZonaC.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_ZonaC.Actualizar()

        cmb_CiudadF.AgregaParametro("@Id_Estado", -1, 1)
        cmb_CiudadF.Actualizar()
        cmb_CiudadC.AgregaParametro("@Id_Estado", -1, 1)
        cmb_CiudadC.Actualizar()

        cmb_EstadoF.AgregaParametro("@Id_Pais", -1, 1)
        cmb_EstadoF.Actualizar()
        cmb_EstadoC.AgregaParametro("@Id_Pais", -1, 1)
        cmb_EstadoC.Actualizar()

        cmb_CiudadContactos.AgregaParametro("@Id_Estado", -1, 1)
        cmb_CiudadContactos.Actualizar()
        cmb_estadoContactos.AgregaParametro("@Id_Pais", 1, 1)
        cmb_estadoContactos.Actualizar()

        cmb_PaisF.Actualizar()
        cmb_PaisC.Actualizar()

        cmb_Giro.Actualizar()
        cmb_Categoria.Actualizar()
        cmb_EstadoCivil.Actualizar()
        cmb_ClienteC.Actualizar()
        cmb_ClienteF.Actualizar()

        cmb_CuotaR.Actualizar()

        cmb_KM.Actualizar()

        cmb_SeleccioneCP.AgregaParametro("@Status", "T", 0)
        cmb_SeleccioneCP.Actualizar()


        cmb_Cuenta.Actualizar()
        cmb_CRS.Actualizar()
        cmb_EES.Actualizar()
        cmb_KMS.Actualizar()

        'Combos de Descripcion y Precio dependen del la Linea
        cmb_Precio.AgregaParametro("@Id_Linea", -1, 1)
        cmb_Precio.AgregaParametro("@Status", "A", 0)
        cmb_Precio.Actualizar()

        cmb_Descripcion.AgregaParametro("@Id_Linea", -1, 1)
        cmb_Descripcion.AgregaParametro("@Status", "A", 0)
        cmb_Descripcion.Actualizar()

        cmb_Linea.Actualizar()

        cmb_PrecioOtros.AgregaParametro("@Id_Linea", -1, 1)
        cmb_PrecioOtros.AgregaParametro("@Status", "A", 0)
        cmb_PrecioOtros.Actualizar()

        cmb_DescripcionOtros.AgregaParametro("@Id_Linea", -1, 1)
        cmb_DescripcionOtros.AgregaParametro("@Status", "A", 0)
        cmb_DescripcionOtros.Actualizar()

        cmb_ConceptoProceso.AgregaParametro("@Tipo", 2, 1)
        cmb_ConceptoProceso.Actualizar()

        cmb_Materiales.AgregaParametro("@Status", "A", 0)
        cmb_Materiales.Actualizar()
        cmb_Materiales.Size = New Size(440, 21)

        cmb_LineaOtros.AgregaParametro("@Traslado", "N", 0)
        cmb_LineaOtros.Actualizar()

        cmb_PS.AgregaParametro("@Id_Linea", -1, 1)
        cmb_PS.Actualizar()

        cmb_PDS.AgregaParametro("@Id_Linea", -1, 1)
        cmb_PDS.Actualizar()

        cmb_ContactoTipo.AgregarItem(1, "ADMINISTRATIVO")
        cmb_ContactoTipo.AgregarItem(2, "OPERATIVO")
        cmb_ContactoTipo.AgregarItem(3, "REPRESENTANTE LEGAL")

        cmb_Retiene.AgregarItem("S", "SI")
        cmb_Retiene.AgregarItem("N", "NO")

        cmb_Agrupa.AgregarItem("S", "SI")
        cmb_Agrupa.AgregarItem("N", "NO")

        cmb_Descuento.AgregarItem("S", "SI")
        cmb_Descuento.AgregarItem("N", "NO")

        cmb_TipoDesc.AgregarItem("P", "PORCENTAJE")
        cmb_TipoDesc.AgregarItem("I", "IMPORTE")

        cmb_CobroU.AgregarItem("S", "SI")
        cmb_CobroU.AgregarItem("N", "NO")

        cmb_TVPredeterminado.AgregarItem("S", "SI")
        cmb_TVPredeterminado.AgregarItem("N", "NO")

        cmb_Recoleccion.AgregarItem("S", "SI")
        cmb_Recoleccion.AgregarItem("N", "NO")

        cmb_EntregaD.AgregarItem("S", "SI")
        cmb_EntregaD.AgregarItem("N", "NO")

        cmb_StatusSubCli.AgregarItem("A", "ACTIVOS")
        cmb_StatusSubCli.AgregarItem("B", "BAJAS")
        cmb_StatusSubCli.AgregarItem("T", "TODOS")

        cmb_CobroUOtros.AgregarItem("S", "SI")
        cmb_CobroUOtros.AgregarItem("N", "NO")

        lsv_Contactos.Columns.Add("Tipo")
        lsv_Contactos.Columns.Add("Nombre")
        lsv_Contactos.Columns.Add("Departamento")
        lsv_Contactos.Columns.Add("Puesto")
        lsv_Contactos.Columns.Add("FNacimiento")
        lsv_Contactos.Columns.Add("EstadoCivil")
        lsv_Contactos.Columns.Add("Comentarios")
        lsv_Contactos.Columns.Add("Status")
        lsv_Contactos.Columns.Add("TelOficina")
        lsv_Contactos.Columns.Add("TelCasa")
        lsv_Contactos.Columns.Add("Celular")
        lsv_Contactos.Columns.Add("Otro")
        lsv_Contactos.Columns.Add("Fax")
        lsv_Contactos.Columns.Add("Mail")

        lsv_ServiciosOtros.Columns.Add("FechaInicio")
        lsv_ServiciosOtros.Columns.Add("ClaveLinea")
        lsv_ServiciosOtros.Columns.Add("ClavePrecio")
        lsv_ServiciosOtros.Columns.Add("Precio")
        lsv_ServiciosOtros.Columns.Add("Descripcion")

        lsv_ServiciosTV.Columns.Add("FechaInicio")
        lsv_ServiciosTV.Columns.Add("ClaveLinea")
        lsv_ServiciosTV.Columns.Add("ClavePrecio")
        lsv_ServiciosTV.Columns.Add("Descripcion")
        lsv_ServiciosTV.Columns.Add("Precio")
        lsv_ServiciosTV.Columns.Add("PrecioCR")
        lsv_ServiciosTV.Columns.Add("PrecioEE")
        lsv_ServiciosTV.Columns.Add("PrecioKM")
        lsv_ServiciosTV.Columns.Add("Status")

        lsv_H_Servicios.Columns.Add("FechaInicio")
        lsv_H_Servicios.Columns.Add("ClaveLinea")
        lsv_H_Servicios.Columns.Add("ClavePrecio")
        lsv_H_Servicios.Columns.Add("Descripcion")
        lsv_H_Servicios.Columns.Add("Precio")
        lsv_H_Servicios.Columns.Add("PrecioCR")
        lsv_H_Servicios.Columns.Add("PrecioEE")
        lsv_H_Servicios.Columns.Add("PrecioKM")
        lsv_H_Servicios.Columns.Add("Status")

        lsv_HorariosPev.Columns.Add("Finicio")
        lsv_HorariosPev.Columns.Add("Frecuencia")
        lsv_HorariosPev.Columns.Add("Frecuencia")
        lsv_HorariosPev.Columns.Add("Origen")
        lsv_HorariosPev.Columns.Add("HRecoleccion")
        lsv_HorariosPev.Columns.Add("Destino")
        lsv_HorariosPev.Columns.Add("HEntrega")
        lsv_HorariosPev.Columns.Add("Ruta")
        lsv_HorariosPev.Columns.Add("Tipo")
        lsv_HorariosPev.Columns.Add("Status")

        lsv_HorariosActivos.Columns.Add("Finicio")
        lsv_HorariosActivos.Columns.Add("Frecuencia")
        lsv_HorariosActivos.Columns.Add("Frecuencia")
        lsv_HorariosActivos.Columns.Add("Origen")
        lsv_HorariosActivos.Columns.Add("HRecoleccion")
        lsv_HorariosActivos.Columns.Add("Destino")
        lsv_HorariosActivos.Columns.Add("HEntrega")
        lsv_HorariosActivos.Columns.Add("Ruta")
        lsv_HorariosActivos.Columns.Add("Status")

        lsv_TEF.Columns.Add("Banco")
        lsv_TEF.Columns.Add("Moneda")
        lsv_TEF.Columns.Add("Cuenta")
        lsv_TEF.Columns.Add("Referencia")
        lsv_TEF.Columns.Add("Observaciones")
        lsv_TEF.Columns.Add("Status")

        lsv_Cobranza.Columns.Add("Dia")
        lsv_Cobranza.Columns.Add("Horario")

        lsv_Revision.Columns.Add("Dia")
        lsv_Revision.Columns.Add("Horario")

        lsv_Cobranza.Columns.Add("Dia")
        lsv_Cobranza.Columns.Add("Horario")

        lsv_Revision.Columns.Add("Dia")
        lsv_Revision.Columns.Add("Horario")

        lsv_Fotografias.Columns.Add("Nombre")
        lsv_Fotografias.Columns.Add("Descripcion")

        lsv_DocDetalle.Columns.Add("Documento")
        lsv_DocDetalle.Columns.Add("Archivo")

        lsv_SubClientes.Columns.Add("Clave")
        lsv_SubClientes.Columns.Add("NombreComercial")
        lsv_SubClientes.Columns.Add("NombreFiscal")
        lsv_SubClientes.Columns.Add("CHK")
        lsv_SubClientes.Columns.Add("ID")

        Lsv_Contratos.Columns.Add("Numero Contrato")
        Lsv_Contratos.Columns.Add("Fecha Contrato")
        Lsv_Contratos.Columns.Add("Fecha Inicio")
        Lsv_Contratos.Columns.Add("Fecha Fin")
        Lsv_Contratos.Columns.Add("Observacionses")
        Lsv_Contratos.Columns.Add("Status")

        dtp_InicioOp.Value = #1/1/1900#
        rtb_MensajeAlerta.Tag = ""

        'Se deja porque en limpiar también se controla la activación de los controles
        Call Limpiar()
    End Sub

    Private Sub rbn_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Clientes.CheckedChanged
        If rdb_Clientes.Checked Then Tipo = "C" Else Tipo = "P"
        If Id_Cliente = 0 Then Exit Sub
        Call Limpiar()
        tbx_Buscar.Focus()
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If tbx_Buscar.TextLength > 0 AndAlso Asc(e.KeyChar) = Keys.Enter Then
            Call Buscar_Cliente()
            Call LlenarListaContratos()
            Foco = True
        End If
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        BajaPermanente = False
        Proceso = False
        chk_ClienteP.Checked = False
        chk_ClienteP.Enabled = False
        cmb_SeleccioneCP.SelectedValue = "0"
        If Id_Cliente = 0 Then Exit Sub
        Call Limpiar()
    End Sub

    Private Sub tbx_Buscar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.Leave
        If Foco = True Then
            Foco = False
            tbx_Buscar.Focus()
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        If rdb_Clientes.Checked Then
            frm.Cliente = True
            frm.Consulta = Frm_BuscarCliente.Query.Clientes
        Else
            frm.Cliente = False
            frm.Consulta = Frm_BuscarCliente.Query.Prospectos
        End If

        frm.ShowDialog()

        tbx_Buscar.Text = frm.Clave
        If tbx_Buscar.TextLength > 0 Then
            Call Buscar_Cliente()
            tbx_Buscar.Focus()
        End If
    End Sub

    Private Sub tab_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0

        If tab_Clientes.SelectedIndex = 12 Then Call LlenarListaContratos()

        If Id_Cliente > 0 Then Call Controles()
        chk_Contactos.Enabled = False
        chk_Servicios.Enabled = False
        chk_ServiciosOtros.Enabled = False

        'Este listview sirve para guardar los registros que se modificaran
        'cuando se marque cualquier casilla de subclientes
        For Each SubClientes As ListViewItem In lsv_SubClientes.Items
            SubClientes.SubItems(4).Text = ""
            SubClientes.SubItems(5).Text = ""
        Next
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Select Case tab_Clientes.SelectedTab.Name
            Case tab_Generales.Name
                If Not chk_ClienteP.Checked AndAlso cmb_SeleccioneCP.SelectedValue = 0 Then
                    MsgBox("Se debe de Marcar que es Cliente Padre.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_SeleccioneCP.Focus()
                    Exit Sub
                End If

                If Val(tbx_Latitud.Text.Trim) > 90 Or Val(tbx_Latitud.Text.Trim) < -90 Then
                    MsgBox("La Latitud parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Latitud.Focus()
                    Exit Sub
                End If
                If Val(tbx_Longitud.Text.Trim) > 180 Or Val(tbx_Longitud.Text.Trim) < -180 Then
                    MsgBox("La Longitud parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Longitud.Focus()
                    Exit Sub
                End If

                Dim Foraneo As Char = "L"
                Dim RequiereMaterial As String
                Dim UtilizaCaset As String
                Dim Tipo_Cliente As String = ""

                If rdb_ForaneoS.Checked Then Foraneo = "F"
                If tbx_NumeroC.Text = "" Then tbx_NumeroC.Text = "0"
                If tbx_NumeroF.Text = "" Then tbx_NumeroF.Text = "0"
                If tbx_NumeroF.Text.Trim.Contains("-") Then
                    MsgBox("El número exterior parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_NumeroF.Focus()
                    Exit Sub
                End If
                If tbx_NumeroC.Text.Trim.Contains("-") Then
                    MsgBox("El número exterior parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_NumeroC.Focus()
                    Exit Sub
                End If
                If tbx_CPF.Text = "" Then tbx_CPF.Text = "0"
                If tbx_CPC.Text = "" Then tbx_CPC.Text = "0"
                If tbx_Latitud.Text = "" Then tbx_Latitud.Text = 0
                If tbx_Longitud.Text = "" Then tbx_Longitud.Text = 0
                If rdb_MaterialSi.Checked Then RequiereMaterial = "S" Else RequiereMaterial = "N"

                If rdb_Traslado.Checked Then
                    Tipo_Cliente = "1"
                ElseIf rdb_SeguridadP.Checked Then
                    Tipo_Cliente = "2"
                ElseIf rdb_Ambos.Checked Then
                    Tipo_Cliente = "3"
                ElseIf rdb_CajaBancaria.Checked Then
                    Tipo_Cliente = "4"
                ElseIf rdb_Otro.Checked Then
                    Tipo_Cliente = "5"
                End If

                If rdb_CasetSI.Checked Then UtilizaCaset = "S" Else UtilizaCaset = "N"



                If fn_Clientes_Guardar(Id_Cliente, tbx_Buscar.Text, tbx_NombreF.Text, tbx_CalleF.Text, CInt(tbx_NumeroF.Text), tbx_IntF.Text, tbx_ColoniaF.Text, CInt(tbx_CPF.Text), cmb_ZonaF.SelectedValue, _
                                       tbx_RFC.Text, tbx_NombreC.Text, tbx_CalleC.Text, CInt(tbx_NumeroC.Text), tbx_IntC.Text, cmb_ZonaC.SelectedValue, tbx_ColoniaC.Text, CInt(tbx_CPC.Text), cmb_Giro.SelectedValue, _
                                       cmb_Categoria.SelectedValue, tbx_ClaveRadio.Text, Foraneo, cmb_SeleccioneCP.SelectedValue, tbx_Latitud.Text, tbx_Longitud.Text, _
                                       cmb_CiudadC.SelectedValue, RequiereMaterial, rtb_MensajeAlerta.Tag, Tipo_Cliente, dtp_InicioOp.Value.Date, tbx_EntreF1.Text, tbx_EntreF2.Text, tbx_EntreC1.Text, _
                                       tbx_EntreC2.Text, tbx_NombreCorto.Text, tbx_ClaveFacturacion.Text.Trim, chk_ClienteP.Checked, UtilizaCaset) Then

                    MsgBox("Se han actualizado correctamente los datos.", MsgBoxStyle.Information, frm_MENU.Text)
                    Call DatosGenerales_Llenar()
                Else
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If

            Case tab_Administrativos.Name
                If Adm_Validar() Then Exit Sub

                If tbx_CantidadD.Text = "" Then tbx_CantidadD.Text = 0
                'If tbx_CantidadComp.Text = "" Then tbx_CantidadComp.Text = 0

                If fn_Admin_Actualizar(Id_Cliente, cmb_ClienteF.SelectedValue, cmb_ClienteC.SelectedValue, cmb_Ejecutivo.SelectedValue, _
                                        cmb_Retiene.SelectedValue, cmb_Agrupa.SelectedValue, cmb_Descuento.SelectedValue, _
                                       cmb_TipoDesc.SelectedValue, tbx_CantidadD.Text, "N", cmb_TipoDesc.SelectedValue, _
                                        0, "N", chk_Administrativos.Checked, lsv_SubClientes) Then

                    Call Administrativos_Llenar()
                    gbx_DatosTEF.Enabled = True

                    MsgBox("Se han actualizado correctamente los datos.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If

            Case tab_Observaciones.Name
                If Validar_Observaciones() Then
                    If fn_ClienteObservaciones_Actualizar(Id_Cliente, rtb_ObservacionesExtra.Text, rtb_ObservacionesExtra.Tag) Then
                        Call Observaciones_Llenar()
                        MsgBox("Se han actualizado correctamente los datos.", MsgBoxStyle.Information, frm_MENU.Text)
                    Else
                        MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click, lsv_Contactos.DoubleClick, lsv_ServiciosTV.DoubleClick, lsv_ServiciosOtros.DoubleClick
        SegundosDesconexion = 0

        Select Case tab_Clientes.SelectedTab.Name
            Case tab_Contactos.Name
                If Not lsv_Contactos.SelectedItems.Count = 0 Then
                    chk_Contactos.Checked = False
                    chk_Contactos.Enabled = True
                    Call Contactos_ModoEdicion()
                    lsv_Contactos.Enabled = False
                End If

            Case tab_ServiciosOtros.Name
                If lsv_ServiciosOtros.SelectedItems.Count > 0 Then
                    Call ServiciosOtros_ModoEdicion()
                    chk_ServiciosOtros.Enabled = True
                End If

            Case tab_ServiciosTV.Name
                If lsv_ServiciosTV.SelectedItems.Count > 0 Then
                    Call ServiciosTV_ModoEdicion()
                    chk_Servicios.Enabled = True
                End If

        End Select
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        SegundosDesconexion = 0

        cmb_Linea.Enabled = True
        Select Case tab_Clientes.SelectedTab.Name
            Case tab_Contactos.Name
                lsv_Contactos.SelectedItems.Clear()
                Call Contactos_ModoEdicion()
                Call Contactos_Limpiar()
                lsv_Contactos.Enabled = False '--
                chk_Contactos.Enabled = True
                btn_BuscarContactos.Enabled = True

            Case tab_Administrativos.Name
                Dim frm As New frm_TEFModal
                frm.Id_Cliente = Id_Cliente
                frm.Tag = 0
                frm.ShowDialog()
                Call Administrativos_Llenar()

            Case tab_ServiciosTV.Name
                chk_Servicios.Checked = False
                chk_Servicios.Enabled = True
                lsv_ServiciosTV.SelectedItems.Clear()
                Call ServiciosTV_ModoEdicion()
                Call ServiciosTV_Limpiar()

            Case tab_ServiciosOtros.Name
                chk_ServiciosOtros.Checked = False
                chk_ServiciosOtros.Enabled = True
                lsv_ServiciosOtros.SelectedItems.Clear()
                Call ServiciosOtros_ModoEdicion()
                Call ServiciosOtros_Limpiar()

        End Select
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        Select Case tab_Clientes.SelectedTab.Name

            Case tab_Contactos.Name
                If lsv_Contactos.SelectedItems.Count > 0 Then
                    If lsv_Contactos.SelectedItems(0).SubItems(7).Text = "ACTIVO" Then
                        If Not fn_Contactos_AltaBaja(lsv_Contactos.SelectedItems(0).Tag, lsv_Contactos.SelectedItems(0).SubItems(14).Text, "B", chk_Contactos.Checked, lsv_SubClientes) Then
                            MsgBox("No se puedo dar de Baja el Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Else
                        If Not fn_Contactos_AltaBaja(lsv_Contactos.SelectedItems(0).Tag, lsv_Contactos.SelectedItems(0).SubItems(14).Text, "A", chk_Contactos.Checked, lsv_SubClientes) Then
                            MsgBox("No se puedo dar de Alta el Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    End If
                    chk_Contactos.Checked = False
                    Call Contactos_Llenar()
                End If

            Case tab_Administrativos.Name
                If lsv_Cobranza.SelectedItems.Count > 0 Then
                    Call Admin_BajaCobranza()
                ElseIf lsv_Revision.SelectedItems.Count > 0 Then
                    Call Admin_BajaRevision()
                Else
                    MsgBox("No se puede eliminar porque no hay registros seleccionados.", MsgBoxStyle.Information, frm_MENU.Text)
                End If

            Case tab_ServiciosTV.Name
                If MsgBox("ADVERTECIA: Este movimiento afecta directamente la operación de las Rutas de Traslado de Valores. Realmente desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                    If lsv_ServiciosTV.SelectedItems(0).SubItems(17).Text = "ACTIVO" Then
                        If Not fn_Servicios_Baja(lsv_ServiciosTV.SelectedItems(0).Tag, Id_Cliente, chk_Servicios.Checked, lsv_SubClientes) Then
                            MsgBox("No se puedo dar de Baja el Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Else
                        If Not fn_Servicios_Alta(lsv_ServiciosTV.SelectedItems(0).Tag, Id_Cliente, chk_Servicios.Checked, lsv_SubClientes) Then
                            MsgBox("No se puedo dar de Alta el Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    End If
                    Call ServiciosTV_Llenar()
                End If

            Case tab_ServiciosOtros.Name
                If lsv_ServiciosOtros.SelectedItems(0).SubItems(17).Text = "ACTIVO" Then
                    If Not fn_Servicios_Baja(lsv_ServiciosOtros.SelectedItems(0).Tag, Id_Cliente, chk_ServiciosOtros.Checked, lsv_SubClientes) Then
                        MsgBox("No se puedo dar de Baja el Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                Else
                    If Not fn_Servicios_Alta(lsv_ServiciosOtros.SelectedItems(0).Tag, Id_Cliente, chk_ServiciosOtros.Checked, lsv_SubClientes) Then
                        MsgBox("No se puedo dar de Alta el Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                End If
                Call ServiciosOtros_Llenar()
        End Select
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

#End Region

#Region "Funciones de todo el formulario"

    Sub Buscar_Cliente()
        Me.Cursor = Cursors.WaitCursor
        'Primero se Busca si existe el Cliente para poder llenar toda su información
        Dim TblTemp As DataTable = fn_Clientes_Id(tbx_Buscar.Text.Trim, Tipo)
        If TblTemp IsNot Nothing AndAlso TblTemp.Rows.Count > 0 Then
            Id_Cliente = TblTemp.Rows(0)("Id_Cliente")
            TblTemp.Dispose()
            Call LlenarTodasPestañas()
            Call Controles()
            'Revisar si el Cliente es de Proceso
            TblTemp = Nothing
            TblTemp = fn_Clientes_CajBancaria_Proceso(Id_Cliente)
            If TblTemp IsNot Nothing AndAlso TblTemp.Rows.Count > 0 AndAlso TblTemp(0)("CajaBancaria") = 0 AndAlso TblTemp(0)("Proceso") > 0 Then
                Proceso = True
            Else
                Proceso = False
            End If
        End If
        lbl_totalHorariosServicios.Text = "Registros:" & lsv_HorariosActivos.Items.Count
        lbl_totalServiciosTV.Text = "Registros:" & lsv_ServiciosTV.Items.Count
        lbl_totalServicios.Text = "Registros:" & lsv_ServiciosOtros.Items.Count
        Me.Cursor = Cursors.Default
    End Sub

    Sub Controles()
        If Not BajaPermanente Then
            lsv_ServiciosTV.SelectedItems.Clear()
            lsv_Contactos.SelectedItems.Clear()
            lsv_ServiciosOtros.SelectedItems.Clear()
            lsv_TEF.SelectedItems.Clear()

            Select Case tab_Clientes.SelectedTab.Name
                Case tab_Generales.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = True
                    btn_MensajeAlerta.Visible = True

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                Case tab_Contactos.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    lsv_Contactos.Enabled = lsv_Contactos.Items.Count > 0
                    btn_Nuevo.Visible = True
                    btn_Guardar.Visible = False

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                    Call Contactos_ReadOnly()

                Case tab_Administrativos.Name
                    btn_Nuevo.Visible = False
                    btn_Baja.Visible = False
                    btn_Editar.Visible = False
                    btn_Guardar.Visible = True
                    btn_NuevoHorario.Visible = True
                    btn_EliminarHorario.Visible = True
                    btn_ClienteFacturar.Visible = True

                    btn_Nuevo.Left = 147
                    btn_Editar.Left = 291
                    btn_Baja.Left = 435

                Case tab_ServiciosOtros.Name
                    btn_Nuevo.Visible = True
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Nuevo.Visible = True
                    btn_Guardar.Visible = False
                    btn_AgregarOtros.Visible = False
                    btn_CancelarOtros.Visible = False
                    btn_DetallesCF.Visible = lsv_ServiciosOtros.Items.Count > 0

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                    Call ServiciosOtros_Limpiar()
                    Call ServiciosOtros_ReadOnly()

                Case tab_ServiciosTV.Name
                    btn_Nuevo.Visible = True
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Nuevo.Visible = True
                    btn_Guardar.Visible = False
                    btn_AgregarServicio.Visible = False
                    btn_CancelarServicio.Visible = False

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                    Call ServiciosTV_Limpiar()
                    Call ServiciosTV_ReadOnly()

                Case tab_Horarios.Name

                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = False
                    btn_ImportarHorarios.Enabled = True

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                    lsv_H_Servicios.SelectedItems.Clear()

                Case tab_TEF.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = False
                    btn_Agregar.Visible = True
                    btn_EliminarTEF.Visible = True
                    btn_PG.Visible = True
                    btn_CRG.Visible = True
                    btn_EEG.Visible = True
                    btn_KMG.Visible = True

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                Case tab_Imprimir.Name

                    btn_Contrato.Visible = True
                    btn_Servicios.Visible = True

                Case tab_Precios.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = False
                    btn_PG.Visible = Id_Cliente > 0 AndAlso Not BajaPermanente
                    btn_CRG.Visible = Id_Cliente > 0 AndAlso Not BajaPermanente
                    btn_EEG.Visible = Id_Cliente > 0 AndAlso Not BajaPermanente
                    btn_KMG.Visible = Id_Cliente > 0 AndAlso Not BajaPermanente

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                Case tab_Subclientes.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = False
                    btn_Exportar.Visible = True
                    cmb_StatusSubCli.Enabled = True
                    cmb_StatusSubCli.SelectedValue = "A"

                    btn_Nuevo.Left = 4
                    btn_Editar.Left = 147
                    btn_Baja.Left = 291

                Case tab_DocRecibidos.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = False
                    btn_DoctosImportar.Visible = True

                    btn_Nuevo.Left = 147
                    btn_Editar.Left = 291
                    btn_Baja.Left = 435

                Case tab_Fotos.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = False
                    btn_FotografiasImportar.Visible = True

                    btn_Nuevo.Left = 147
                    btn_Editar.Left = 291
                    btn_Baja.Left = 435

                Case tab_Observaciones.Name
                    btn_Nuevo.Visible = False
                    btn_Editar.Visible = False
                    btn_Baja.Visible = False
                    btn_Guardar.Visible = True

                    btn_Nuevo.Left = 147
                    btn_Editar.Left = 291
                    btn_Baja.Left = 435

            End Select
        Else
            Call Limpiar()
            lbl_BajaPermanente.Visible = True
        End If
    End Sub

    Public Sub LlenarTodasPestañas()
        SegundosDesconexion = 0
        Call DatosGenerales_Llenar()
        Call Contactos_Llenar()
        Call Administrativos_Llenar()
        Call TEF_Llenar()
        Call ServiciosOtros_Llenar()
        Call ServiciosTV_Llenar()
        Call Horarios_Llenar()
        Call Precios_Llenar()
        Call Fotos_Llenar()
        Call DoctosRecibidos_Llenar()
        cmb_StatusSubCli.SelectedValue = "T"
        Call Subclientes_Llenar()
        Call Observaciones_Llenar()
        'Call ComparteFactura_Llenar()  'Pendiente porque no esta en uso todavía
        'Call Imprimir_Llenar()         'Pendiente porque no esta en uso todavía
    End Sub

    Private Sub Limpiar()
        'Datos Generales
        lbl_BajaPermanente.Visible = False
        btn_Reingresar.Visible = False
        btn_MensajeAlerta.Visible = False
        chk_ReingresarSubclientes.Visible = False
        chk_ReingresarProceso.Visible = False

        'Contactos
        btn_GuardarC.Visible = False
        lsv_Contactos.Items.Clear()
        Call Contactos_ReadOnly()
        chk_Contactos.Enabled = False

        'Administrativos
        btn_ClienteFacturar.Visible = False
        btn_NuevoHorario.Visible = False
        btn_EliminarHorario.Visible = False
        chk_Administrativos.Enabled = False

        'Servicios Otros
        btn_DetallesCF.Visible = False
        lsv_ServiciosOtros.Items.Clear()
        chk_ServiciosOtros.Enabled = False

        'Servicios TV
        lsv_ServiciosTV.Items.Clear()
        chk_Servicios.Enabled = False

        'Horarios
        btn_NuevoHorarioTemp1.Enabled = False
        btn_NuevoHorarioTempMas.Enabled = False
        btn_EditarHorarioTemp.Enabled = False
        btn_BajaHorarioTemp.Enabled = False
        btn_EditarHorario.Enabled = False
        btn_BajaHorario.Enabled = False
        btn_ImportarHorarios.Enabled = False
        btn_EdicionGlobal.Enabled = False

        'TEF
        btn_Agregar.Visible = False
        btn_EliminarTEF.Visible = False
        lsv_TEF.Items.Clear()

        'Imprimir
        btn_Contrato.Visible = False
        btn_Servicios.Visible = False
        Lsv_Contratos.Items.Clear()

        'Precios
        btn_PG.Visible = False
        btn_CRG.Visible = False
        btn_EEG.Visible = False
        btn_KMG.Visible = False

        'Subclientes
        btn_Exportar.Visible = False
        cmb_StatusSubCli.Enabled = False
        cmb_StatusSubCli.SelectedValue = "0"
        lsv_SubClientes.Items.Clear()

        'Fotografias
        btn_FotografiasImportar.Visible = False
        gbx_Agregar.Enabled = rdb_Clientes.Checked
        lsv_Fotografias.Items.Clear()

        'Documentos Recibidos
        btn_DoctosImportar.Visible = False
        lsv_DocDetalle.Items.Clear()

        'Observaciones
        rtb_ObservacionesExtra.Clear()

        If Not BajaPermanente Then
            Id_Cliente = 0

            Call DatosGenerales_Limpiar()
            Call Contactos_Limpiar()
            Call Contactos_ReadOnly()
            Call Administrativos_Limpiar()
            Call ServiciosOtros_Limpiar()
            Call ServiciosOtros_ReadOnly()
            Call ServiciosTV_Limpiar()
            Call ServiciosTV_ReadOnly()
            Call Horarios_Limpiar()
            Call TEF_Limpiar()
            Call Precios_Limpiar()

            tbx_NombreF2.Clear()   'Nombre_Fiscal (superior)
            tbx_NombreC2.Clear()   'Nombre_Comercial (superior)

            btn_Nuevo.Left = 4
            btn_Editar.Left = 147
            btn_Baja.Left = 291

            btn_Guardar.Visible = False
            btn_Nuevo.Visible = False
            btn_Editar.Visible = False
            btn_Baja.Visible = False
            btn_Baja.ImageIndex = 0
            btn_Baja.Text = "&Baja / Reing."
        End If
    End Sub

    Sub Afectar_SubClientes(ByVal chk As CheckBox, Optional ByVal TipoProcedimiento As Integer = 1)
        'Si se esta palomeando, además el cliente tiene subclientes y no sea un cliente de baja permanente se podrán modificar los sublientes también
        If chk.Checked AndAlso lsv_SubClientes.Items.Count > 0 AndAlso Not BajaPermanente Then
            Dim frm As New frm_BuscarSubClientes
            frm.Id_Padre = Id_Cliente
            Select Case TipoProcedimiento
                Case 1
                    frm.Consulta = frm_BuscarSubClientes.Query.InfoGnral

                Case 2
                    frm.Consulta = frm_BuscarSubClientes.Query.InfoFiscal

                Case 3
                    frm.Consulta = frm_BuscarSubClientes.Query.ClientesServicios
                    Select Case tab_Clientes.SelectedTab.Name
                        Case tab_ServiciosOtros.Name
                            frm.Id_PrecioDescripcion = lsv_ServiciosOtros.SelectedItems(0).SubItems(18).Text
                            frm.ClavePrecio = lsv_ServiciosOtros.SelectedItems(0).SubItems(2).Text

                        Case tab_ServiciosTV.Name
                            frm.Id_PrecioDescripcion = lsv_ServiciosTV.SelectedItems(0).SubItems(18).Text
                            frm.ClavePrecio = lsv_ServiciosTV.SelectedItems(0).SubItems(2).Text

                    End Select

            End Select

            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                'Al palomear subclientes en la ventana modal se pasa esa información a
                'la Pestaña de Subclientes esto para no crear variables globales
                Me.Cursor = Cursors.WaitCursor
                cmb_StatusSubCli.SelectedValue = "T"
                For Each ModalSubClientes As ListViewItem In frm.lsv_Clientes.CheckedItems
                    For Each SubClientes As ListViewItem In lsv_SubClientes.Items
                        If TipoProcedimiento <> 3 Then
                            If SubClientes.Tag = ModalSubClientes.Tag AndAlso ModalSubClientes.SubItems(3).Text <> "BAJA PERMANENTE" Then
                                SubClientes.SubItems(4).Text = "S"
                                SubClientes.SubItems(5).Text = ""
                                Exit For
                            End If
                        Else
                            SubClientes.SubItems(4).Text = "S"
                            SubClientes.SubItems(5).Text &= ModalSubClientes.Tag() & ","
                            Exit For
                        End If
                    Next
                Next
                Me.Cursor = Cursors.Default
            Else
                'Si se dio cancelar se despalomea el checkbox para no generar confusión.
                chk.Checked = False
                For Each SubClientes As ListViewItem In lsv_SubClientes.Items
                    SubClientes.SubItems(4).Text = ""
                    SubClientes.SubItems(5).Text = ""
                Next
            End If
        ElseIf lsv_SubClientes.Items.Count > 0 Then
            'si se tenía palomeado y luego se despalomea la opción de "Afectar a subclientes"
            'se borra la información agregada en la pestaña de subclientes
            For Each SubClientes As ListViewItem In lsv_SubClientes.Items
                SubClientes.SubItems(4).Text = ""
                SubClientes.SubItems(5).Text = ""
            Next
        End If
    End Sub

#End Region

#Region "Datos Generales"

    Private Sub DatosGenerales_Llenar()
        If Id_Cliente = 0 Then Exit Sub
        Dim Dr_DatosGenerales As DataRow = fn_Clientes_Generales(Id_Cliente)

        chk_ClienteP.Enabled = True

        btn_Reingresar.Visible = False
        chk_ReingresarSubclientes.Visible = False
        chk_ReingresarProceso.Visible = False
        BajaPermanente = False
        If Dr_DatosGenerales("Status") = "A" Then
            tbx_NombreF2.ForeColor = Color.Green
            tbx_NombreC2.ForeColor = Color.Green
        ElseIf Dr_DatosGenerales("Status") = "B" AndAlso Dr_DatosGenerales("Baja_Permanente") = "N" Then
            tbx_NombreF2.ForeColor = Color.Red
            tbx_NombreC2.ForeColor = Color.Red
            btn_Reingresar.Visible = True
            chk_ReingresarSubclientes.Visible = True
            chk_ReingresarProceso.Visible = True
        ElseIf Dr_DatosGenerales("Status") = "B" AndAlso Dr_DatosGenerales("Baja_Permanente") = "S" Then
            tbx_NombreF2.ForeColor = Color.DarkRed
            tbx_NombreC2.ForeColor = Color.DarkRed
            BajaPermanente = True
        End If

        tbx_NombreF.Text = Dr_DatosGenerales("Nombre_Fiscal")
        tbx_NombreF2.Text = Dr_DatosGenerales("Nombre_Fiscal")
        tbx_CalleF.Text = Dr_DatosGenerales("Calle_Fiscal")
        tbx_NumeroF.Text = Dr_DatosGenerales("Numero_Fiscal")
        tbx_IntF.Text = Dr_DatosGenerales("NumeroInt_Fiscal")
        tbx_ColoniaF.Text = Dr_DatosGenerales("Colonia_Fiscal")
        tbx_CPF.Text = Dr_DatosGenerales("CP_Fiscal")
        tbx_EntreF1.Text = Dr_DatosGenerales("EntreCalle_Fiscal1")
        tbx_EntreF2.Text = Dr_DatosGenerales("EntreCalle_Fiscal2")

        'Se obtiene los datos del país, estado, ciudad y zona para fiscal
        If Dr_DatosGenerales("Zona_Fiscal") > 0 Then
            Dim Dr_Lugar As DataRow = fn_Clientes_Lugar(Dr_DatosGenerales("Zona_Fiscal"))
            If Dr_Lugar IsNot Nothing Then
                cmb_PaisF.SelectedValue = Dr_Lugar("Id_Pais")
                cmb_EstadoF.SelectedValue = Dr_Lugar("Id_Estado")
                cmb_CiudadF.SelectedValue = Dr_Lugar("Id_Ciudad")
                cmb_ZonaF.SelectedValue = Dr_Lugar("Id_Zona")
            End If
        End If
        tbx_RFC.Text = Dr_DatosGenerales("RFC")
        tbx_NombreC.Text = Dr_DatosGenerales("Nombre_Comercial")
        tbx_NombreC2.Text = Dr_DatosGenerales("Nombre_Comercial")
        tbx_NombreCorto.Text = Dr_DatosGenerales("Nombre_Corto")
        tbx_CalleC.Text = Dr_DatosGenerales("Calle_Comercial")
        tbx_NumeroC.Text = Dr_DatosGenerales("Numero_Comercial")
        tbx_IntC.Text = Dr_DatosGenerales("NumeroInt_Comercial")
        tbx_ColoniaC.Text = Dr_DatosGenerales("Colonia_Comercial")
        tbx_CPC.Text = Dr_DatosGenerales("CP_Comercial")
        tbx_EntreC1.Text = Dr_DatosGenerales("EntreCalle_Comercial1")
        tbx_EntreC2.Text = Dr_DatosGenerales("EntreCalle_Comercial2")
        If Dr_DatosGenerales("Latitud") = 0 Then tbx_Latitud.Text = "" Else tbx_Latitud.Text = Dr_DatosGenerales("Latitud")
        If Dr_DatosGenerales("Longitud") = 0 Then tbx_Longitud.Text = "" Else tbx_Longitud.Text = Dr_DatosGenerales("Longitud")

        'Se obtiene los datos del país, estado, ciudad y zona para comercial
        If Dr_DatosGenerales("Zona_Comercial") = Dr_DatosGenerales("Zona_Fiscal") Then
            cmb_PaisC.SelectedValue = cmb_PaisF.SelectedValue
            cmb_EstadoC.SelectedValue = cmb_EstadoF.SelectedValue
            cmb_CiudadC.SelectedValue = cmb_CiudadF.SelectedValue
            cmb_ZonaC.SelectedValue = cmb_ZonaF.SelectedValue
        ElseIf Dr_DatosGenerales("Zona_Comercial") > 0 Then
            Dim Dr_Lugar As DataRow = fn_Clientes_Lugar(Dr_DatosGenerales("Zona_Comercial"))
            cmb_PaisC.SelectedValue = Dr_Lugar("Id_Pais")
            cmb_EstadoC.SelectedValue = Dr_Lugar("Id_Estado")
            cmb_CiudadC.SelectedValue = Dr_Lugar("Id_Ciudad")
            cmb_ZonaC.SelectedValue = Dr_Lugar("Id_Zona")
        End If

        cmb_Giro.SelectedValue = Dr_DatosGenerales("Id_Giro")
        cmb_Categoria.SelectedValue = Dr_DatosGenerales("Id_Categoria")
        tbx_ClaveRadio.Text = Dr_DatosGenerales("Clave_Radio")

        If Dr_DatosGenerales("Local_Foraneo") = "F" Then rdb_ForaneoS.Checked = True Else rdb_ForaneoN.Checked = True

        chk_ClienteP.Checked = Dr_DatosGenerales("Cliente_Padre") = "S"
        cmb_SeleccioneCP.SelectedValue = Dr_DatosGenerales("Id_Padre")

        If Dr_DatosGenerales("RequiereMaterial") = "SI" Then rdb_MaterialSi.Checked = True Else rdb_MaterialNo.Checked = True

        Select Case Dr_DatosGenerales("Tipo_Cliente")
            Case "1"
                rdb_Traslado.Checked = True
                rdb_SeguridadP.Checked = False
                rdb_Ambos.Checked = False
                rdb_CajaBancaria.Checked = False
                rdb_Otro.Checked = False
            Case "2"
                rdb_Traslado.Checked = False
                rdb_SeguridadP.Checked = True
                rdb_Ambos.Checked = False
                rdb_CajaBancaria.Checked = False
                rdb_Otro.Checked = False
            Case "3"
                rdb_Traslado.Checked = False
                rdb_SeguridadP.Checked = False
                rdb_Ambos.Checked = True
                rdb_CajaBancaria.Checked = False
                rdb_Otro.Checked = False
            Case "4"
                rdb_Traslado.Checked = False
                rdb_SeguridadP.Checked = False
                rdb_Ambos.Checked = False
                rdb_CajaBancaria.Checked = True
                rdb_Otro.Checked = False
            Case "5"
                rdb_Traslado.Checked = False
                rdb_SeguridadP.Checked = False
                rdb_Ambos.Checked = False
                rdb_CajaBancaria.Checked = False
                rdb_Otro.Checked = True
            Case Else
                rdb_Traslado.Checked = False
                rdb_SeguridadP.Checked = False
                rdb_Ambos.Checked = False
                rdb_CajaBancaria.Checked = False
                rdb_Otro.Checked = False
        End Select

        dtp_InicioOp.Value = Dr_DatosGenerales("Fecha_InicioOperaciones")
        tbx_ClaveFacturacion.Text = Dr_DatosGenerales("Clave_Facturacion")

        'Para mostrar el rtb_MensajeAlerta.text de Forma Clara
        rtb_MensajeAlerta.Clear()
        rtb_MensajeAlerta.Tag = ""
        If Dr_DatosGenerales("MensajeAlerta") <> "" Then
            rtb_MensajeAlerta.Tag = Dr_DatosGenerales("MensajeAlerta")
            Dim MensajeArr() As String = Split(Dr_DatosGenerales("MensajeAlerta"), "/")
            If MensajeArr.Length > 0 Then
                If MensajeArr.Length = 1 Then
                    rtb_MensajeAlerta.Text = MensajeArr(0)
                Else
                    rtb_MensajeAlerta.Text = MensajeArr(0) & " " & MensajeArr(1)
                End If
            End If
        End If
    End Sub

    Private Sub DatosGenerales_Limpiar()
        cmb_SeleccioneCP.SelectedValue = "0"
        chk_ClienteP.Checked = False
        tbx_NombreF.Clear()                                   'Nombre_Fiscal
        tbx_CalleF.Clear()                                    'Direccion_Fiscal, 
        tbx_NumeroF.Clear()
        tbx_IntF.Clear()
        tbx_ColoniaF.Clear()
        tbx_CPF.Clear()
        tbx_EntreF1.Clear()
        tbx_EntreF2.Clear()
        cmb_PaisF.SelectedValue = "0"
        cmb_EstadoF.SelectedValue = "0"
        cmb_CiudadF.SelectedValue = "0"
        cmb_ZonaF.SelectedValue = "0"
        tbx_RFC.Clear()
        tbx_NombreC.Clear()
        tbx_NombreC2.Clear()
        tbx_CalleC.Clear()
        tbx_NumeroC.Clear()
        tbx_IntC.Clear()
        tbx_ColoniaC.Clear()
        tbx_CPC.Clear()
        tbx_EntreC1.Clear()
        tbx_EntreC2.Clear()
        cmb_PaisC.SelectedValue = "0"
        cmb_EstadoC.SelectedValue = "0"
        cmb_CiudadC.SelectedValue = "0"
        cmb_ZonaC.SelectedValue = "0"
        cmb_PaisC.SelectedValue = "0"
        cmb_EstadoC.SelectedValue = "0"
        cmb_CiudadC.SelectedValue = "0"
        cmb_ZonaC.SelectedValue = "0"
        cmb_Giro.SelectedValue = "0"
        cmb_Categoria.SelectedValue = "0"
        tbx_ClaveRadio.Clear()
        rdb_ForaneoS.Checked = False
        rdb_ForaneoN.Checked = False
        tbx_Latitud.Clear()
        tbx_Longitud.Clear()
        rdb_MaterialSi.Checked = False
        rdb_MaterialNo.Checked = False
        rtb_MensajeAlerta.Clear()
        rtb_MensajeAlerta.Tag = ""
        rdb_Traslado.Checked = False
        rdb_SeguridadP.Checked = False
        rdb_Ambos.Checked = False
        rdb_CajaBancaria.Checked = False
        rdb_Otro.Checked = False
        dtp_InicioOp.Value = #1/1/1900#
        tbx_NombreCorto.Clear()
        tbx_ClaveFacturacion.Clear()
    End Sub

    Private Sub chk_ClienteP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ClienteP.CheckedChanged
        SegundosDesconexion = 0
        gbx_ClaveFacturacion.Enabled = chk_ClienteP.Checked
    End Sub

    Private Sub chk_ReingresarSubclientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ReingresarSubclientes.CheckedChanged
        SegundosDesconexion = 0
        Call Afectar_SubClientes(chk_ReingresarSubclientes)
    End Sub

    Private Sub chk_Fiscales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then tbx_NombreC.Focus()
    End Sub

    Private Sub cmb_PaisF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PaisF.SelectedValueChanged
        If cmb_PaisF.Items.Count = 0 Then Exit Sub
        cmb_EstadoF.ActualizaValorParametro("@Id_Pais", cmb_PaisF.SelectedValue)
        cmb_EstadoF.Actualizar()
    End Sub

    Private Sub cmb_PaisC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PaisC.SelectedValueChanged
        If cmb_PaisC.Items.Count = 0 Then Exit Sub
        cmb_EstadoC.ActualizaValorParametro("@Id_Pais", cmb_PaisC.SelectedValue)
        cmb_EstadoC.Actualizar()
    End Sub

    Private Sub cmb_EstadoF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_EstadoF.SelectedValueChanged
        If cmb_EstadoF.Items.Count = 0 Then Exit Sub
        cmb_CiudadF.ActualizaValorParametro("@Id_Estado", cmb_EstadoF.SelectedValue)
        cmb_CiudadF.Actualizar()
    End Sub

    Private Sub cmb_EstadoC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_EstadoC.SelectedValueChanged
        If cmb_EstadoC.Items.Count = 0 Then Exit Sub
        cmb_CiudadC.ActualizaValorParametro("@Id_Estado", cmb_EstadoC.SelectedValue)
        cmb_CiudadC.Actualizar()
    End Sub

    Private Sub cmb_CiudadF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CiudadF.SelectedValueChanged
        If cmb_CiudadF.Items.Count = 0 Then Exit Sub
        cmb_ZonaF.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadF.SelectedValue)
        cmb_ZonaF.Actualizar()
    End Sub

    Private Sub cmb_CiudadC_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CiudadC.SelectedValueChanged
        If cmb_CiudadC.Items.Count = 0 Then Exit Sub
        cmb_ZonaC.ActualizaValorParametro("@Id_Ciudad", cmb_CiudadC.SelectedValue)
        cmb_ZonaC.Actualizar()
    End Sub

    Private Sub btn_MensajeAlerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MensajeAlerta.Click
        SegundosDesconexion = 0

        Dim frm As New frm_MensajeAlerta
        frm.MensajeFinal = rtb_MensajeAlerta.Tag
        frm.ShowDialog()
        If frm.DialogResult <> Windows.Forms.DialogResult.Cancel Then
            rtb_MensajeAlerta.Text = frm.MensajeTexto
            rtb_MensajeAlerta.Tag = frm.MensajeFinal
        End If
    End Sub

    Private Sub btn_Reingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reingresar.Click
        SegundosDesconexion = 0

        If Id_Cliente = 0 Then Exit Sub

        If Not chk_ClienteP.Checked AndAlso cmb_SeleccioneCP.SelectedValue = 0 Then
            MsgBox("Debe de Marcar si es Cliente Padre, sino seleccionar el Padre del Subcliente mostrado o" & Chr(13) & _
                   "en su defecto seleccionar ambas opciones, esto para verificar si se encuentra en la Lista Negra el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_SeleccioneCP.Focus()
            Exit Sub
        End If

        If fn_Cliente_ListaNegra(Id_Cliente, cmb_SeleccioneCP.SelectedValue) Then
            If chk_ClienteP.Checked AndAlso cmb_SeleccioneCP.SelectedValue = 0 Then
                If MsgBox("El Clientes se encuentra en Lista Negra, Desea continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            Else
                If MsgBox("El Cliente Padre o el Subcliente se encuentra en Lista Negra, Desea continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If
        'El mensaje se llenará según con la información seleccionada
        If chk_ReingresarSubclientes.Checked AndAlso chk_ReingresarProceso.Checked Then
            'Con hijos y agregar en Proceso
            If MsgBox("Se realizará el Reingreso del Cliente y sus Subclientes seleccionados, además de reactivarlos en Proceso, ¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then Exit Sub
        ElseIf chk_ReingresarSubclientes.Checked Then
            'Con hijos
            If MsgBox("Se realizará el Reingreso del Cliente con sus Subclientes seleccionados sin reactivarlos en Proceso, ¿Desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then Exit Sub
        ElseIf chk_ReingresarProceso.Checked Then
            'Agregar en Proceso
            If MsgBox("Se realizará el Reingreso del Cliente y se reactivará en Proceso, ¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then Exit Sub
        Else
            'Solo el Cliente
            If MsgBox("Se realizará el Reingreso del Cliente sin Subclientes, ¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then Exit Sub
        End If

        If Not fn_Clientes_Reingreso(Id_Cliente, chk_ReingresarSubclientes.Checked, chk_ReingresarProceso.Checked, lsv_SubClientes) Then
            MsgBox("Ha Ocurrido un Error al Intentar Reingresar el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            'Enviar Mensaje de Alta de Cliente al Correo
            Dim dr_Cliente As DataRow = fn_Clientes_Generales(Id_Cliente)
            Dim Detalles As String
            Dim MensajeCorreo As String = "Ningúno"

            If dr_Cliente IsNot Nothing Then
                If rtb_MensajeAlerta.Text <> "" Then MensajeCorreo = rtb_MensajeAlerta.Text
                Dim Tipo_Cliente As String
                If rdb_Traslado.Checked Then
                    Tipo_Cliente = "TRASLADO"
                ElseIf rdb_SeguridadP.Checked Then
                    Tipo_Cliente = "SEGURIDAD PATRIMONIAL"
                ElseIf rdb_Ambos.Checked Then
                    Tipo_Cliente = "TRASLADO Y SEGURIDAD PATRIMONIAL"
                ElseIf rdb_CajaBancaria.Checked Then
                    Tipo_Cliente = "CAJA BANCARIA"
                ElseIf rdb_Otro.Checked Then
                    Tipo_Cliente = "OTRO"
                Else
                    Tipo_Cliente = "NO ESPECIFICADO"
                End If
                Detalles = "Por medio del presente se le informa del Reingreso del Cliente con los siguientes datos:" & Chr(13) & Chr(13) _
                         & "                   Sucursal: " & SucursalN & Chr(13) _
                         & "                    Cliente: " & dr_Cliente("Clave_Cliente") & " - " & dr_Cliente("Nombre_Comercial") & Chr(13) _
                         & "               Tipo Cliente: " & Tipo_Cliente & Chr(13) _
                         & "             Fecha Registro: " & dr_Cliente("Fecha_Registro") & Chr(13) _
                         & "           Usuario Registro: " & UsuarioN & Chr(13) _
                         & "             Giro Comercial: " & dr_Cliente("GiroComercial") & Chr(13) _
                         & "Requiere Material Operativo: " & dr_Cliente("RequiereMaterial") & Chr(13) _
                         & "        Mensaje Informativo: " & MensajeCorreo & Chr(13) & Chr(13) _
                         & "Agente de Servicios SIAC " & Today.Year.ToString

                Dim DetalleHTML As String = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr><tr><td colspan='3' align='center'>Encabezado</td></tr><tr><td colspan='3'><hr /></td></tr><tr>" _
                                            & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>" _
                                            & "<tr><td align='right'><label><b>Cliente:</b></label></td><td>" & dr_Cliente("Clave_Cliente") & " - " & dr_Cliente("Nombre_Comercial") & "</td></tr><tr><td align='right'><label><b>Tipo Cliente:</b></label></td>" _
                                            & "<td>" & Tipo_Cliente & "</td></tr><tr><td align='right'><label><b>Fecha Registro:</b></label></td><td>" & dr_Cliente("Fecha_Registro") & "</td></tr><tr><td align='right'><label><b>Usuario Registro:</b></label></td>" _
                                            & "<td>" & UsuarioN & "</td></tr><tr><td align='right'><label><b>Giro Comercial:</b></label></td><td>" & dr_Cliente("GiroComercial") & "</td></tr><tr><td align='right'><label><b>Requiere Material Operativo:</b></label></td><td>" _
                                            & dr_Cliente("RequiereMaterial") & "</td></tr><tr><td align='right'><label><b>Mensaje Informativo:</b></label></td><td>" & MensajeCorreo & "</td></tr><tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table></body></html>"

                Dim Dt_Subclientes As New DataTable
                Dt_Subclientes.Columns.Add("Clave Cliente")
                Dt_Subclientes.Columns.Add("Nombre Comercial")
                For Each Elemento As ListViewItem In lsv_SubClientes.Items
                    If Elemento.SubItems(4).Text = "S" And Elemento.SubItems(3).Text = "BAJA" Then
                        Dt_Subclientes.Rows.Add(Elemento.Text, Elemento.SubItems(1).Text)
                    End If
                Next

                If Dt_Subclientes IsNot Nothing AndAlso Dt_Subclientes.Rows.Count > 0 Then
                    DetalleHTML = Replace(DetalleHTML, "Pie</td></tr></table>", FuncionesGlobales.fn_DatatableToHTML(Dt_Subclientes, "Subclientes", 0, 0, 14) & "</td></tr><tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table>")
                End If

                If DetalleHTML <> "" Then
                    fn_AlertasGeneradas_Guardar("16", Detalles, Nothing, True, "REINGRESO DE CLIENTE", "", DetalleHTML)
                Else
                    fn_AlertasGeneradas_Guardar("16", Detalles, Nothing, True, "REINGRESO DE CLIENTE", "", "")
                End If
            End If

            MsgBox("El Cliente se ha reingresado Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarTodasPestañas()
        End If
    End Sub

#End Region

#Region "Contactos"

    Private Sub Contactos_Llenar()
        lsv_Contactos.Items.Clear()
        btn_Baja.Enabled = False '<--
        btn_Editar.Enabled = False '-->
        If Id_Cliente = 0 Then Exit Sub
        If Not fn_Clientes_Contactos(Id_Cliente, lsv_Contactos) Then
            MsgBox("Ha Ocurrido un error al intentar cargar la lista de Contactos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Contactos_Limpiar()
        chk_Contactos.Checked = False
        chk_Contactos.Enabled = False
        cmb_ContactoTipo.SelectedValue = 0
        tbx_Nombre.Clear()
        tbx_Nombre.Tag = Nothing
        dtp_FechaNacimiento.Value = Today.Date
        tbx_Departamento.Clear()
        cmb_EstadoCivil.SelectedValue = 0
        tbx_Puesto.Clear()
        tbx_Comentarios.Clear()
        tbx_TelOficina.Clear()
        tbx_TelCasa.Clear()
        tbx_TelCelular.Clear()
        tbx_TelOtro.Clear()
        tbx_Fax.Clear()
        tbx_Mail.Clear()

        tbx_rfcContacto.Clear()
        tbx_calleContacto.Clear()
        tbx_CalleEntre1.Clear()
        tbx_calleEntre2.Clear()
        tbx_NumExterior.Clear()
        tbx_numInterior.Clear()
        tbx_coloniaContacto.Clear()
        cmb_CiudadContactos.SelectedValue = 0
        cmb_estadoContactos.SelectedValue = 0
    End Sub

    Private Sub Contactos_ModoEdicion()
        btn_Nuevo.Visible = False
        btn_Editar.Visible = False
        btn_Baja.Visible = False
        btn_GuardarC.Visible = True
        btn_CancelarC.Visible = True
        btn_BuscarContactos.Enabled = False
        chk_Contactos.Checked = False
        cmb_ContactoTipo.Enabled = True
        tbx_Nombre.Enabled = True
        dtp_FechaNacimiento.Enabled = True
        tbx_Departamento.Enabled = True
        cmb_EstadoCivil.Enabled = True
        tbx_Puesto.Enabled = True
        tbx_Comentarios.Enabled = True
        tbx_TelOficina.Enabled = True
        tbx_TelCasa.Enabled = True
        tbx_TelCelular.Enabled = True
        tbx_TelOtro.Enabled = True
        tbx_Fax.Enabled = True
        tbx_Mail.Enabled = True

        tbx_rfcContacto.Enabled = True
        tbx_calleContacto.Enabled = True
        tbx_CalleEntre1.Enabled = True
        tbx_calleEntre2.Enabled = True
        tbx_NumExterior.Enabled = True
        tbx_numInterior.Enabled = True
        tbx_coloniaContacto.Enabled = True
        cmb_CiudadContactos.Enabled = True
        cmb_estadoContactos.Enabled = True

    End Sub

    Private Sub Contactos_ReadOnly()
        btn_GuardarC.Visible = False
        btn_CancelarC.Visible = False
        btn_BuscarContactos.Enabled = False

        cmb_ContactoTipo.Enabled = False
        tbx_Nombre.Enabled = False
        dtp_FechaNacimiento.Enabled = False
        tbx_Departamento.Enabled = False
        cmb_EstadoCivil.Enabled = False
        tbx_Puesto.Enabled = False
        tbx_Comentarios.Enabled = False

        tbx_TelOficina.Enabled = False
        tbx_TelCasa.Enabled = False
        tbx_TelCelular.Enabled = False
        tbx_TelOtro.Enabled = False
        tbx_Fax.Enabled = False
        tbx_Mail.Enabled = False
        '--
        tbx_rfcContacto.Enabled = False
        tbx_calleContacto.Enabled = False
        tbx_CalleEntre1.Enabled = False
        tbx_calleEntre2.Enabled = False
        tbx_NumExterior.Enabled = False
        tbx_numInterior.Enabled = False
        tbx_coloniaContacto.Enabled = False
        cmb_CiudadContactos.Enabled = False
        cmb_estadoContactos.Enabled = False

    End Sub

    Private Sub btn_BuscarContactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarContactos.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Contactos
        frm.ShowDialog()
        If frm.lsv_Clientes.SelectedItems.Count > 0 Then
            tbx_Nombre.Tag = frm.Id
            tbx_Nombre.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(1).Text
            tbx_Departamento.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(2).Text
            tbx_Puesto.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(3).Text
            dtp_FechaNacimiento.Value = CDate(frm.lsv_Clientes.SelectedItems(0).SubItems(5).Text)
            tbx_TelOficina.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(6).Text
            tbx_TelCasa.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(7).Text
            tbx_TelCelular.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(8).Text
            tbx_TelOtro.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(9).Text
            tbx_Fax.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(10).Text
            tbx_Mail.Text = frm.lsv_Clientes.SelectedItems(0).SubItems(11).Text
            cmb_ContactoTipo.SelectedValue = frm.lsv_Clientes.SelectedItems(0).SubItems(12).Text
            cmb_EstadoCivil.SelectedValue = frm.lsv_Clientes.SelectedItems(0).SubItems(13).Text
        End If
    End Sub

    Private Sub dtp_FechaNacimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaNacimiento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_Departamento.Focus()
        End If
    End Sub

    Private Sub chk_Contactos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Contactos.CheckedChanged
        SegundosDesconexion = 0
        Call Afectar_SubClientes(chk_Contactos)
    End Sub

    Private Sub btn_GuardarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarC.Click
        SegundosDesconexion = 0

        If Id_Cliente = 0 Then
            MsgBox("Indique un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Buscar.Focus()
            Exit Sub
        End If
        If cmb_ContactoTipo.SelectedValue = 0 Then
            MsgBox("Seleccione el Tipo de Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ContactoTipo.Focus()
            Exit Sub
        End If
        If tbx_Nombre.Text.Trim = "" Then
            MsgBox("Indique el Nombre del Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombre.Focus()
            Exit Sub
        End If

        If tbx_Nombre.Tag > 0 Then
            'Se crea un enlace de contacto nuevo en base de un contacto ya existente
            If Not fn_ContactosEnlace_Crear(tbx_Nombre.Tag, Id_Cliente, cmb_ContactoTipo.SelectedValue, tbx_Nombre.Text.Trim, tbx_Departamento.Text.Trim, _
                                            tbx_Puesto.Text.Trim, dtp_FechaNacimiento.Text, cmb_EstadoCivil.SelectedValue, tbx_Comentarios.Text.Trim, _
                                            tbx_TelOficina.Text.Trim, tbx_TelCasa.Text.Trim, tbx_TelCelular.Text.Trim, tbx_TelOtro.Text.Trim, tbx_Fax.Text.Trim, tbx_Mail.Text.Trim, _
                                            chk_Contactos.Checked, lsv_SubClientes, tbx_rfcContacto.Text.Trim, tbx_calleContacto.Text.Trim, tbx_CalleEntre1.Text.Trim, _
                                  tbx_calleEntre2.Text.Trim, tbx_NumExterior.Text.Trim, tbx_numInterior.Text.Trim, tbx_coloniaContacto.Text.Trim, _
                                 cmb_CiudadContactos.SelectedValue, cmb_estadoContactos.SelectedValue) Then
                MsgBox("Ocurrio un error al intentar guardar los contactos.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        ElseIf lsv_Contactos.SelectedItems.Count = 0 Then
            'cuando es nuevo contacto
            If Not fn_Contactos_Crear(Id_Cliente, cmb_ContactoTipo.SelectedValue, tbx_Nombre.Text.Trim, tbx_Departamento.Text.Trim, _
                                  tbx_Puesto.Text, dtp_FechaNacimiento.Text, cmb_EstadoCivil.SelectedValue, tbx_Comentarios.Text.Trim, _
                                  tbx_TelOficina.Text, tbx_TelCasa.Text, tbx_TelCelular.Text.Trim, tbx_TelOtro.Text.Trim, tbx_Fax.Text.Trim, tbx_Mail.Text.Trim, _
                                  chk_Contactos.Checked, lsv_SubClientes, tbx_rfcContacto.Text.Trim, tbx_calleContacto.Text.Trim, tbx_CalleEntre1.Text.Trim, _
                                  tbx_calleEntre2.Text.Trim, tbx_NumExterior.Text.Trim, tbx_numInterior.Text.Trim, tbx_coloniaContacto.Text.Trim, _
                                 cmb_CiudadContactos.SelectedValue, cmb_estadoContactos.SelectedValue) Then
                MsgBox("Ocurrio un error al intentar guardar los contactos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            'cuando estas modificando un contacto
            If Not fn_Contactos_Actualizar(lsv_Contactos.SelectedItems(0).SubItems(14).Text, cmb_ContactoTipo.SelectedValue, tbx_Nombre.Text.Trim, tbx_Departamento.Text.Trim, _
                                           tbx_Puesto.Text.Trim, dtp_FechaNacimiento.Text, cmb_EstadoCivil.SelectedValue, tbx_Comentarios.Text.Trim, _
                                           tbx_TelOficina.Text.Trim, tbx_TelCasa.Text.Trim, tbx_TelCelular.Text.Trim, tbx_TelOtro.Text.Trim, tbx_Fax.Text.Trim, tbx_Mail.Text.Trim, tbx_rfcContacto.Text.Trim, tbx_calleContacto.Text.Trim, tbx_CalleEntre1.Text.Trim, _
                                  tbx_calleEntre2.Text.Trim, tbx_NumExterior.Text.Trim, tbx_numInterior.Text.Trim, tbx_coloniaContacto.Text.Trim, _
                                 cmb_CiudadContactos.SelectedValue, cmb_estadoContactos.SelectedValue) Then
                MsgBox("Ocurrio un error al intentar guardar los contactos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        If lsv_Contactos.SelectedItems.Count > 0 OrElse tbx_Nombre.Tag > 0 Then
            'se select >0 esta modificando
            Call Contactos_Limpiar()
            Call Contactos_ReadOnly()
            btn_Nuevo.Visible = True
            lsv_Contactos.Enabled = True
        Else
            chk_Contactos.Enabled = False
            btn_GuardarC.Text = "&Agregar"
            btn_CancelarC.Visible = True
            btn_BuscarContactos.Enabled = True
            Call Contactos_Limpiar()
        End If

        Call Contactos_Llenar()
    End Sub

    Private Sub Btn_CancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarC.Click
        SegundosDesconexion = 0

        Call Contactos_Limpiar()
        Call Contactos_ReadOnly()
        btn_GuardarC.Text = "&Guardar"
        chk_Contactos.Enabled = False
        btn_Nuevo.Visible = True
        btn_Editar.Visible = lsv_Contactos.SelectedItems.Count > 0
        btn_Baja.Visible = lsv_Contactos.SelectedItems.Count > 0
        lsv_Contactos.Enabled = True
        lsv_Contactos.SelectedItems.Clear()
        btn_GuardarC.Visible = False
        btn_CancelarC.Visible = False
    End Sub

    Private Sub cbx_ClienteP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_ClienteP.KeyPress
        If Asc(e.KeyChar) = 13 Then cmb_SeleccioneCP.Focus()
    End Sub

    Private Sub lsv_Contactos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Contactos.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Contactos.SelectedItems.Count > 0 Then
            cmb_ContactoTipo.SelectedValue = lsv_Contactos.SelectedItems(0).SubItems(15).Text
            tbx_Nombre.Text = lsv_Contactos.SelectedItems(0).SubItems(1).Text
            tbx_Departamento.Text = lsv_Contactos.SelectedItems(0).SubItems(2).Text
            tbx_Puesto.Text = lsv_Contactos.SelectedItems(0).SubItems(3).Text
            dtp_FechaInicio.Value = CDate(lsv_Contactos.SelectedItems(0).SubItems(4).Text)

            cmb_EstadoCivil.SelectedValue = lsv_Contactos.SelectedItems(0).SubItems(16).Text
            tbx_Comentarios.Text = lsv_Contactos.SelectedItems(0).SubItems(6).Text
            tbx_TelOficina.Text = lsv_Contactos.SelectedItems(0).SubItems(8).Text
            tbx_TelCasa.Text = lsv_Contactos.SelectedItems(0).SubItems(9).Text
            tbx_TelCelular.Text = lsv_Contactos.SelectedItems(0).SubItems(10).Text
            tbx_TelOtro.Text = lsv_Contactos.SelectedItems(0).SubItems(11).Text
            tbx_Fax.Text = lsv_Contactos.SelectedItems(0).SubItems(12).Text
            tbx_Mail.Text = lsv_Contactos.SelectedItems(0).SubItems(13).Text

            'falta llenar los demas campos
            dtp_FechaNacimiento.Value = CDate(lsv_Contactos.SelectedItems(0).SubItems(4).Text)
            tbx_rfcContacto.Text = lsv_Contactos.SelectedItems(0).SubItems(17).Text
            tbx_calleContacto.Text = lsv_Contactos.SelectedItems(0).SubItems(18).Text
            tbx_CalleEntre1.Text = lsv_Contactos.SelectedItems(0).SubItems(19).Text
            tbx_calleEntre2.Text = lsv_Contactos.SelectedItems(0).SubItems(20).Text
            tbx_NumExterior.Text = lsv_Contactos.SelectedItems(0).SubItems(21).Text
            tbx_numInterior.Text = lsv_Contactos.SelectedItems(0).SubItems(22).Text
            tbx_coloniaContacto.Text = lsv_Contactos.SelectedItems(0).SubItems(23).Text
            cmb_estadoContactos.SelectedValue = lsv_Contactos.SelectedItems(0).SubItems(25).Text
            cmb_CiudadContactos.SelectedValue = lsv_Contactos.SelectedItems(0).SubItems(24).Text

        Else
            Call Contactos_Limpiar()
        End If

        'Aqui se muestran los botones
        btn_Nuevo.Visible = True
        btn_Editar.Visible = Not sender.SelectedItems.Count = 0
        btn_Baja.Visible = Not sender.SelectedItems.Count = 0
        btn_Baja.Enabled = Not sender.SelectedItems.Count = 0
        btn_Editar.Enabled = Not sender.SelectedItems.Count = 0

    End Sub

#End Region

#Region "Administrativos"

    Private Sub Administrativos_Llenar()
        If Id_Cliente = 0 Then Exit Sub
        Dim Dr_Admin As DataRow = fn_Clientes_Administrativos(Id_Cliente)
        If Dr_Admin IsNot Nothing Then
            cmb_ClienteF.SelectedValue = Dr_Admin("Cliente_Facturar")
            cmb_ClienteC.SelectedValue = Dr_Admin("Cliente_Contra")
            cmb_Ejecutivo.SelectedValue = Dr_Admin("Ejecutivo_Contrato")
            cmb_Retiene.SelectedValue = Dr_Admin("Retiene_IVA")
            cmb_Agrupa.SelectedValue = Dr_Admin("Agrupa_Facturas")
            cmb_Descuento.SelectedValue = Dr_Admin("Tiene_Descuento")
            cmb_TipoDesc.SelectedValue = Dr_Admin("Tipo_Descuento")
            tbx_CantidadD.Text = Dr_Admin("Cantidad_Descuento")
            'cmb_Comparte.SelectedValue = Dr_Admin("Comparte_Facturacion")
            'cmb_TipoComparte.SelectedValue = Dr_Admin("Tipo_Comparte")
            'tbx_CantidadComp.Text = Dr_Admin("Cantidad_Comparte")
            'cmb_PagaTEF.SelectedValue = Dr_Admin("Paga_TEF")
            gbx_DatosTEF.Enabled = True
        Else
            gbx_DatosTEF.Enabled = False
        End If
        chk_Administrativos.Enabled = True
        Call Admin_ActualizarCobranza()
        Call Admin_ActualizarRevision()
    End Sub

    Private Sub Administrativos_Limpiar()
        cmb_ClienteF.SelectedValue = "0"
        cmb_ClienteC.SelectedValue = "0"
        cmb_Ejecutivo.SelectedValue = "0"
        cmb_Retiene.SelectedValue = "0"
        cmb_Agrupa.SelectedValue = "0"
        cmb_Descuento.SelectedValue = "0"
        cmb_TipoDesc.SelectedValue = "0"
        tbx_CantidadD.Clear()
        chk_Administrativos.Checked = False
        lsv_Cobranza.Items.Clear()
        lsv_Revision.Items.Clear()
    End Sub

    Private Sub Admin_ActualizarRevision()
        If Not fn_Admin_LlenarLista(Id_Cliente, 1, lsv_Revision) Then
            MsgBox("Ocurrio un error al tratar de Actualizar la Revisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Admin_BajaCobranza()
        If Not fn_Admin_Eliminar(lsv_Cobranza.SelectedItems(0).Tag) Then
            MsgBox("Ocurrio un error al tratar de Eliminar la Cobranza.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Admin_ActualizarCobranza()
    End Sub

    Private Sub Admin_BajaRevision()
        If Not fn_Admin_Eliminar(lsv_Revision.SelectedItems(0).Tag) Then
            MsgBox("Ocurrio un error al tratar de Eliminar la Revisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Admin_ActualizarRevision()
    End Sub

    Private Function Adm_Validar() As Boolean
        If cmb_ClienteF.SelectedValue = "0" Then
            MsgBox("Seleccione el Cliente a Facturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ClienteF.Focus()
            Return True
        End If

        If cmb_Ejecutivo.SelectedValue = "0" Then
            MsgBox("Indique el Ejecutivo que Contrata.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ejecutivo.Focus()
            Return True
        End If
        If cmb_Retiene.SelectedValue = "0" Then
            MsgBox("Indique si Retiene IVA.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Retiene.Focus()
            Return True
        End If

        If cmb_Descuento.SelectedValue = "0" Then
            MsgBox("Indique si el Cliente tiene Descuento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Descuento.Focus()
            Return True
        End If
        If cmb_Descuento.SelectedValue = "S" Then
            If cmb_TipoDesc.SelectedValue = "0" And cmb_TipoDesc.Enabled Then
                MsgBox("Indique el Tipo de Descuento para el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_TipoDesc.Focus()
                Return True
            End If
            If tbx_CantidadD.Text = "" And tbx_CantidadD.Enabled Then
                MsgBox("Indique la cantidad de Descuento.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_CantidadD.Focus()
                Return True
            End If
        End If
        If cmb_Agrupa.SelectedValue = "0" Then
            MsgBox("Indique si el Cliente Agrupa Facturas.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Agrupa.Focus()
            Return True
        End If

        Return False
    End Function

    Private Sub dtp_VenceC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cmb_Ejecutivo.Focus()
        End If
    End Sub

    Private Sub btn_ClienteFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClienteFacturar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Clientes
        frm.ShowDialog()

        cmb_ClienteF.SelectedValue = frm.Id
    End Sub

    Private Sub cmb_TipoDesc_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_TipoDesc.SelectedValueChanged
        Select Case cmb_TipoDesc.SelectedValue
            Case "0"
                tbx_CantidadD.Enabled = False
            Case "P"
                tbx_CantidadD.Enabled = True
                tbx_CantidadD.TipoDatos = Validar_Cadena.Porcentaje
            Case "I"
                tbx_CantidadD.Enabled = True
                tbx_CantidadD.TipoDatos = Validar_Cadena.Numeros_Decimales
        End Select
    End Sub

    Private Sub cmb_Descuento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Descuento.SelectedValueChanged
        Select Case cmb_Descuento.SelectedValue
            Case "0"
                cmb_TipoDesc.Enabled = False
            Case "S"
                cmb_TipoDesc.Enabled = True
            Case "N"
                cmb_TipoDesc.Enabled = False
        End Select
    End Sub

    Private Sub chk_Administrativos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Administrativos.CheckedChanged
        SegundosDesconexion = 0
        Call Afectar_SubClientes(chk_Administrativos)
    End Sub

    Private Sub Admin_ActualizarCobranza()
        If Not fn_Admin_LlenarLista(Id_Cliente, 2, lsv_Cobranza) Then
            MsgBox("Ocurrio un error al tratar de Actualizar la Cobranza.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_revision_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Revision.MouseUp
        If lsv_Revision.SelectedItems.Count > 0 Then
            lsv_Cobranza.SelectedItems.Clear()
            'Quité esto porque agregue un botón nuevo para eliminar Horarios
            'para que se aun poco mas claro para el usuario
            '06/Nov/2009
            'btn_Baja.Visible = True 
            'btn_Baja.ImageIndex = 1
            'btn_Baja.Text = "&Eliminar"
            btn_EliminarHorario.Enabled = True
        Else
            'btn_Baja.Visible = False
            'btn_Baja.ImageIndex = 0
            'btn_Baja.Text = "&Baja / Reing."
            btn_EliminarHorario.Enabled = False
        End If
    End Sub

    Private Sub lsv_Cobranza_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Cobranza.MouseUp
        If lsv_Cobranza.SelectedItems.Count > 0 Then
            lsv_Revision.SelectedItems.Clear()
            'Quité esto porque agregue un botón nuevo para eliminar Horarios
            'para que se aun poco mas claro para el usuario
            '06/Nov/2009
            'btn_Baja.Visible = True
            'btn_Baja.ImageIndex = 1
            'btn_Baja.Text = "&Eliminar"
            btn_EliminarHorario.Enabled = True
        Else
            'btn_Baja.Visible = False
            'btn_Baja.ImageIndex = 0
            'btn_Baja.Text = "&Baja / Reing."
            btn_EliminarHorario.Enabled = False
        End If
    End Sub

    Private Sub Btn_NuevoHorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevoHorario.Click
        SegundosDesconexion = 0

        Dim frm As New frm_TEFModal
        frm.Id_Cliente = Id_Cliente
        frm.Tag = 0
        frm.ShowDialog()

        Call Admin_ActualizarCobranza()
        Call Admin_ActualizarRevision()
    End Sub

    Private Sub btn_EliminarHorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminarHorario.Click
        SegundosDesconexion = 0

        If lsv_Cobranza.SelectedItems.Count > 0 Then
            Call Admin_BajaCobranza()
        ElseIf lsv_Revision.SelectedItems.Count > 0 Then
            Call Admin_BajaRevision()
        Else
            MsgBox("No se puede eliminar porque no hay registros seleccionados", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

#End Region

#Region "Servicios Otros"
    Private Sub ServiciosOtros_Llenar()
        lsv_ServiciosOtros.Items.Clear()
        If Id_Cliente = 0 Then Exit Sub
        Dim Status As String = "A"
        If Not chk_ActivosOtros.Checked Then Status = "T"
        If Not fn_Clientes_Servicios_Horarios(Id_Cliente, lsv_ServiciosOtros, Status, "N") Then
            MsgBox("Ocurrio un error al tratar cargar la lista de Servicios Otros.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lbl_totalServicios.Text = "Registros:" & lsv_ServiciosOtros.Items.Count
    End Sub

    Private Sub ServiciosOtros_Limpiar()
        chk_ServiciosOtros.Checked = False
        dtp_FechaInicioOtros.Value = Today.Date
        cmb_LineaOtros.SelectedValue = 0
        cmb_PrecioOtros.SelectedValue = 0
        cmb_DescripcionOtros.SelectedValue = 0
        cmb_CobroUOtros.SelectedValue = 0
        cmb_ConceptoProceso.SelectedValue = 0
        cmb_ConceptoProceso.Enabled = False
        tbx_ComentariosOtros.Clear()
    End Sub

    Private Sub ServiciosOtros_ModoEdicion()
        chk_ServiciosOtros.Checked = False

        dtp_FechaInicioOtros.Enabled = True
        tbx_LineaOtros.Enabled = True
        tbx_ClvePrecioOtros.Enabled = True
        tbx_ComentariosOtros.Enabled = True
        cmb_LineaOtros.Enabled = True
        cmb_PrecioOtros.Enabled = True
        cmb_DescripcionOtros.Enabled = True
        cmb_CobroUOtros.Enabled = True
        lsv_ServiciosOtros.Enabled = False
        btn_AgregarOtros.Visible = True
        btn_CancelarOtros.Visible = True
        btn_Editar.Visible = False
        btn_Baja.Visible = False
        'Se mostrará siempre el combo concepto menos cuando sea Materiales (3)
        If cmb_LineaOtros.SelectedValue = 3 Then
            Call ServiciosOtros_ComboConceptos(0, cmb_Materiales.SelectedValue)
        Else
            Call ServiciosOtros_ComboConceptos(cmb_ConceptoProceso.SelectedValue, 0)
        End If
    End Sub

    Private Sub ServiciosOtros_ReadOnly()
        dtp_FechaInicioOtros.Enabled = False
        cmb_LineaOtros.Enabled = False
        cmb_PrecioOtros.Enabled = False
        cmb_DescripcionOtros.Enabled = False
        cmb_CobroUOtros.Enabled = False
        tbx_LineaOtros.Enabled = False
        tbx_ClvePrecioOtros.Enabled = False
        tbx_ComentariosOtros.Enabled = False
        chk_ServiciosOtros.Checked = False
        lsv_ServiciosOtros.Enabled = True
        btn_CancelarOtros.Visible = False
        btn_AgregarOtros.Visible = False
    End Sub

    Private Sub ServiciosOtros_ComboConceptos(ByVal Id_Concepto As Integer, ByVal Id_Material As Integer)
        lbl_ConceptoProcesoAst.Enabled = False
        cmb_ConceptoProceso.Enabled = False
        cmb_ConceptoProceso.SelectedValue = 0

        cmb_Materiales.Enabled = False
        cmb_Materiales.SelectedValue = 0
        cmb_Materiales.Visible = False

        'Siempre se manejará el combo de Concepto con exepción de cuando sea Materiales (del cmb_LineasOtros)
        If cmb_LineaOtros.SelectedValue <> 3 Then
            lbl_ConceptoProceso.Text = "Concepto"
            cmb_ConceptoProceso.Visible = True
            cmb_ConceptoProceso.SelectedValue = Id_Concepto

            'Cuando sea un cliente de Proceso se activaba el combo ahora sólo si la línea es proceso
            'If cmb_LineaOtros.Enabled AndAlso (Proceso) Then
            If cmb_LineaOtros.Enabled Then
                Dim Dt As DataTable = cmb_LineaOtros.DataSource
                For Each Elemento As DataRow In Dt.Rows

                    If cmb_LineaOtros.SelectedValue = Elemento("Id_Linea") And Elemento("Proceso") = "S" Then

                        cmb_ConceptoProceso.Enabled = True
                        lbl_ConceptoProcesoAst.Enabled = True
                        Exit Sub
                    End If
                Next
            End If
        Else
            lbl_ConceptoProceso.Text = "Materiales"
            cmb_ConceptoProceso.Visible = False
            cmb_Materiales.Visible = True
            cmb_Materiales.SelectedValue = Id_Material
            If cmb_LineaOtros.Enabled Then
                cmb_Materiales.Enabled = True
                lbl_ConceptoProcesoAst.Enabled = True
            End If
        End If
    End Sub

    Private Sub chk_ServiciosOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ServiciosOtros.CheckedChanged
        SegundosDesconexion = 0
        If lsv_ServiciosOtros.SelectedItems.Count = 0 Then
            Call Afectar_SubClientes(chk_ServiciosOtros, 1)
        Else
            Call Afectar_SubClientes(chk_ServiciosOtros, 3)
        End If
    End Sub

    Private Sub dtp_FechaInicioOtros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaInicioOtros.KeyPress
        If Asc(e.KeyChar) = 13 Then cmb_LineaOtros.Focus()
    End Sub

    Private Sub Btn_AgregarOtros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarOtros.Click
        SegundosDesconexion = 0

        If cmb_LineaOtros.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Línea de Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_LineaOtros.Focus()
            Exit Sub
        End If

        If cmb_PrecioOtros.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PrecioOtros.Focus()
            Exit Sub
        End If

        If cmb_DescripcionOtros.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DescripcionOtros.Focus()
            Exit Sub
        End If

        If cmb_ConceptoProceso.Enabled And cmb_ConceptoProceso.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Concepto para la Línea de Servicio Seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ConceptoProceso.Focus()
            Exit Sub
        End If

        If cmb_Materiales.Visible And cmb_Materiales.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Material para la Línea de Servicio Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Materiales.Focus()
            Exit Sub
        End If

        Dim CobroUOtros As Char = cmb_CobroUOtros.SelectedValue
        If cmb_CobroUOtros.SelectedValue = "0" Then CobroUOtros = "N"

        If lsv_ServiciosOtros.SelectedItems.Count = 0 Then
            If Not fn_Servicios_Crear(Id_Cliente, dtp_FechaInicioOtros.Value, tbx_ComentariosOtros.Text, cmb_PrecioOtros.SelectedValue, 0, _
                                      0, 0, CobroUOtros, "N", "N", "N", 0, cmb_DescripcionOtros.SelectedValue, chk_ServiciosOtros.Checked, _
                                      lsv_SubClientes, cmb_ConceptoProceso.SelectedValue, cmb_Materiales.SelectedValue) Then
                MsgBox("No se pudo Guardar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            If Not fn_Servicios_Actualizar(lsv_ServiciosOtros.SelectedItems(0).Tag, dtp_FechaInicioOtros.Value, tbx_ComentariosOtros.Text, _
                                           cmb_PrecioOtros.SelectedValue, 0, 0, 0, CobroUOtros, "N", "N", "N", 0, cmb_DescripcionOtros.SelectedValue, _
                                           chk_ServiciosOtros.Checked, lsv_SubClientes, cmb_ConceptoProceso.SelectedValue, cmb_Materiales.SelectedValue) Then
                MsgBox("No se pudo Actualizar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Call ServiciosOtros_Limpiar()
        Call ServiciosOtros_ReadOnly()
        Call ServiciosOtros_Llenar()
        Call Precios_Llenar()
        chk_ServiciosOtros.Enabled = False
    End Sub

    Private Sub btn_CancelarOtros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarOtros.Click
        SegundosDesconexion = 0

        chk_ServiciosOtros.Enabled = False
        chk_ServiciosOtros.Checked = False
        lsv_ServiciosOtros.SelectedItems.Clear()
        Call ServiciosOtros_Limpiar()
        Call ServiciosOtros_ReadOnly()
    End Sub

    Private Sub cmb_LineaOtros_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_LineaOtros.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_LineaOtros.Items.Count > 0 Then
            cmb_PrecioOtros.ActualizaValorParametro("@Id_Linea", cmb_LineaOtros.SelectedValue)
            cmb_PrecioOtros.Actualizar()

            cmb_DescripcionOtros.ActualizaValorParametro("@Id_Linea", cmb_LineaOtros.SelectedValue)
            cmb_DescripcionOtros.Actualizar()

            Call ServiciosOtros_ComboConceptos(0, 0)
        End If
    End Sub

    Private Sub chk_ActivosOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ActivosOtros.CheckedChanged
        lsv_ServiciosOtros.SelectedItems.Clear()
        Call ServiciosOtros_Llenar()
    End Sub

    Private Sub lsv_ServiciosOtros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_ServiciosOtros.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_ServiciosOtros.SelectedItems.Count > 0 Then
            dtp_FechaInicioOtros.Value = lsv_ServiciosOtros.SelectedItems(0).Text
            tbx_LineaOtros.Text = lsv_ServiciosOtros.SelectedItems(0).SubItems(1).Text
            tbx_ClvePrecioOtros.Text = lsv_ServiciosOtros.SelectedItems(0).SubItems(2).Text
            cmb_DescripcionOtros.SelectedValue = lsv_ServiciosOtros.SelectedItems(0).SubItems(18).Text
            cmb_CobroUOtros.Text = lsv_ServiciosOtros.SelectedItems(0).SubItems(12).Text
            tbx_ComentariosOtros.Text = lsv_ServiciosOtros.SelectedItems(0).SubItems(16).Text
            Call ServiciosOtros_ComboConceptos(lsv_ServiciosOtros.SelectedItems(0).SubItems(19).Text, lsv_ServiciosOtros.SelectedItems(0).SubItems(20).Text)

            btn_DetallesCF.Enabled = lsv_ServiciosOtros.SelectedItems(0).SubItems(1).Text = "CF"
        Else
            dtp_FechaInicioOtros.Value = Today.Date
            cmb_LineaOtros.SelectedValue = 0
            cmb_PrecioOtros.SelectedValue = 0
            cmb_DescripcionOtros.SelectedValue = 0
            cmb_CobroUOtros.SelectedValue = "0"
            tbx_ComentariosOtros.Clear()
            cmb_ConceptoProceso.SelectedValue = 0
            Call ServiciosOtros_ComboConceptos(0, 0)

            btn_DetallesCF.Enabled = False
        End If

        'Aqui se muestran los botones
        btn_Nuevo.Visible = True
        btn_Editar.Visible = Not sender.SelectedItems.Count = 0
        btn_Baja.Visible = Not sender.SelectedItems.Count = 0
        btn_Editar.Enabled = Not sender.SelectedItems.Count = 0
        btn_Baja.Enabled = Not sender.SelectedItems.Count = 0
    End Sub

    Private Sub btn_DetallesCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DetallesCF.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajasFuertes
        frm.Id = lsv_ServiciosOtros.SelectedItems(0).Tag
        frm.MaximizeBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frm.ShowDialog()
    End Sub

#End Region

#Region "Servicios TV"

    Private Sub ServiciosTV_Llenar()
        lsv_ServiciosTV.Items.Clear()
        If Id_Cliente = 0 Then Exit Sub
        Dim Status As String = "A"
        If Not chk_ServiciosActivosS.Checked Then Status = "T"
        If Not fn_Clientes_Servicios_Horarios(Id_Cliente, lsv_ServiciosTV, Status, "S") Then
            MsgBox("Ocurrio un error al tratar cargar la lista de Servicios TV.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lbl_totalServiciosTV.Text = "Registros:" & lsv_ServiciosTV.Items.Count
    End Sub

    Private Sub ServiciosTV_Limpiar()
        chk_Servicios.Checked = False
        dtp_FechaInicio.Value = Today.Date
        cmb_Linea.SelectedValue = 0
        cmb_Precio.SelectedValue = 0
        cmb_Descripcion.SelectedValue = 0
        cmb_CuotaR.SelectedValue = 0
        cmb_KM.SelectedValue = 0
        cmb_CobroU.SelectedValue = 0
        cmb_TVPredeterminado.SelectedValue = 0
        cmb_Recoleccion.SelectedValue = 0
        cmb_EntregaD.SelectedValue = 0
        tbx_CantidadKM.Clear()
        tbx_ComentariosS.Clear()
    End Sub

    Private Sub ServiciosTV_ModoEdicion()
        chk_Servicios.Checked = False

        lsv_ServiciosTV.Enabled = False
        btn_AgregarServicio.Visible = True
        btn_CancelarServicio.Visible = True
        btn_Editar.Visible = False
        btn_Baja.Visible = False
        dtp_FechaInicio.Enabled = True
        tbx_ComentariosS.Enabled = True
        cmb_Linea.Enabled = True
        cmb_Precio.Enabled = True
        cmb_Descripcion.Enabled = True
        cmb_CobroU.Enabled = True
        cmb_CuotaR.Enabled = True
        cmb_KM.Enabled = True
        cmb_TVPredeterminado.Enabled = True
        cmb_Recoleccion.Enabled = True
        cmb_EntregaD.Enabled = True
        tbx_ClvePrecio.Enabled = True
        tbx_CantidadKM.Enabled = True
    End Sub

    Private Sub ServiciosTV_ReadOnly()
        chk_Servicios.Checked = False
        dtp_FechaInicio.Enabled = False
        cmb_Linea.Enabled = False
        cmb_Precio.Enabled = False
        cmb_Descripcion.Enabled = False
        cmb_CuotaR.Enabled = False
        cmb_KM.Enabled = False
        cmb_CobroU.Enabled = False
        cmb_TVPredeterminado.Enabled = False
        cmb_Recoleccion.Enabled = False
        cmb_EntregaD.Enabled = False
        tbx_ClveLineaServicio.Enabled = False
        tbx_ClvePrecio.Enabled = False
        tbx_ClveKM.Enabled = False
        tbx_ClveCuotaRiesgo.Enabled = False
        tbx_CantidadKM.Enabled = False
        tbx_ComentariosS.Enabled = False
        lsv_ServiciosTV.Enabled = True
        btn_CancelarServicio.Visible = False
        btn_AgregarServicio.Visible = False
    End Sub

    Private Sub chk_Servicios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Servicios.CheckedChanged
        SegundosDesconexion = 0

        If lsv_ServiciosTV.SelectedItems.Count = 0 Then
            Call Afectar_SubClientes(chk_Servicios, 1)
        Else
            Call Afectar_SubClientes(chk_Servicios, 3)
        End If
    End Sub

    Private Sub Btn_AgregarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarServicio.Click
        SegundosDesconexion = 0

        If cmb_Linea.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Línea de Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Linea.Focus()
            Exit Sub
        End If

        If cmb_Precio.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Precio.Focus()
            Exit Sub
        End If

        If cmb_Descripcion.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Descripcion.Focus()
            Exit Sub
        End If

        If cmb_KM.SelectedValue > 0 AndAlso tbx_CantidadKM.Text = "" Then
            MsgBox("Debe de Asignar la Cantidad de Kilómetros.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CantidadKM.Focus()
            Exit Sub
        End If

        If cmb_TVPredeterminado.SelectedValue = "0" Then
            MsgBox("Debe seleccionar si es o no un Servicio Predeterminado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TVPredeterminado.Focus()
            Exit Sub
        End If

        Dim EntregaD As Char = cmb_EntregaD.SelectedValue
        If cmb_EntregaD.SelectedValue = "0" Then EntregaD = "N"

        Dim CobroU As Char = cmb_CobroU.SelectedValue
        If cmb_CobroU.SelectedValue = "0" Then CobroU = "N"

        Dim Recoleccion As Char = cmb_Recoleccion.SelectedValue
        If cmb_Recoleccion.SelectedValue = "0" Then Recoleccion = "N"

        If lsv_ServiciosTV.SelectedItems.Count = 0 Then
            If Not fn_Servicios_Crear(Id_Cliente, dtp_FechaInicio.Value, tbx_ComentariosS.Text, cmb_Precio.SelectedValue, cmb_CuotaR.SelectedValue, _
                                      0, cmb_KM.SelectedValue, CobroU, cmb_TVPredeterminado.SelectedValue, Recoleccion, EntregaD, _
                                      CInt(Val(tbx_CantidadKM.Text)), cmb_Descripcion.SelectedValue, chk_Servicios.Checked, lsv_SubClientes) Then
                MsgBox("No se pudo Guardar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            If Not fn_Servicios_Actualizar(lsv_ServiciosTV.SelectedItems(0).Tag, dtp_FechaInicio.Value, tbx_ComentariosS.Text, cmb_Precio.SelectedValue, _
                                           cmb_CuotaR.SelectedValue, 0, cmb_KM.SelectedValue, CobroU, cmb_TVPredeterminado.SelectedValue, _
                                           Recoleccion, EntregaD, CInt(Val(tbx_CantidadKM.Text)), cmb_Descripcion.SelectedValue, chk_Servicios.Checked, lsv_SubClientes) Then
                MsgBox("No se pudo Actualizar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Call ServiciosTV_Limpiar()
        Call ServiciosTV_ReadOnly()
        Call ServiciosTV_Llenar()
        Call Horarios_Llenar()
        Call Precios_Llenar()
        chk_Servicios.Enabled = False
    End Sub

    Private Sub btn_CancelarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarServicio.Click
        SegundosDesconexion = 0

        chk_Servicios.Enabled = False
        chk_Servicios.Checked = False
        lsv_ServiciosTV.SelectedItems.Clear()
        Call ServiciosTV_Limpiar()
        Call ServiciosTV_ReadOnly()
    End Sub

    Private Sub dtp_FechaInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaInicio.KeyPress
        If Asc(e.KeyChar) = 13 Then cmb_Linea.Focus()
    End Sub

    Private Sub cmb_Linea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Linea.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Linea.Items.Count > 0 Then
            cmb_Precio.ActualizaValorParametro("@Id_Linea", cmb_Linea.SelectedValue)
            cmb_Precio.Actualizar()
            cmb_Descripcion.ActualizaValorParametro("@Id_Linea", cmb_Linea.SelectedValue)
            cmb_Descripcion.Actualizar()
        End If

        cmb_Precio.SelectedValue = 0
        cmb_Descripcion.SelectedValue = 0
        cmb_CuotaR.SelectedValue = 0
        cmb_KM.SelectedValue = 0
        cmb_TVPredeterminado.SelectedValue = 0
        cmb_Recoleccion.SelectedValue = 0
        cmb_EntregaD.SelectedValue = 0
        tbx_CantidadKM.Clear()
        tbx_ClveKM.Clear()
        tbx_ClveCuotaRiesgo.Clear()
    End Sub

    Private Sub chk_ServiciosActivosS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ServiciosActivosS.CheckedChanged
        lsv_ServiciosTV.SelectedItems.Clear()
        Call ServiciosTV_Llenar()
    End Sub

    Private Sub lsv_ServiciosTV_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_ServiciosTV.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_ServiciosTV.SelectedItems.Count > 0 Then
            dtp_FechaInicio.Value = lsv_ServiciosTV.SelectedItems(0).Text
            tbx_ClveLineaServicio.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(1).Text
            tbx_ClvePrecio.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(2).Text
            cmb_Descripcion.SelectedValue = lsv_ServiciosTV.SelectedItems(0).SubItems(18).Text
            tbx_ClveCuotaRiesgo.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(5).Text
            tbx_ClveKM.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(9).Text
            tbx_CantidadKM.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(11).Text
            cmb_CobroU.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(12).Text
            cmb_TVPredeterminado.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(13).Text
            cmb_Recoleccion.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(14).Text
            cmb_EntregaD.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(15).Text
            tbx_ComentariosS.Text = lsv_ServiciosTV.SelectedItems(0).SubItems(16).Text
        Else
            dtp_FechaInicio.Value = Today.Date
            cmb_Linea.SelectedValue = 0
            cmb_Precio.SelectedValue = 0
            cmb_Descripcion.SelectedValue = 0
            cmb_CuotaR.SelectedValue = 0
            cmb_KM.SelectedValue = 0
            cmb_CobroU.SelectedValue = "0"
            cmb_TVPredeterminado.SelectedValue = "0"
            cmb_Recoleccion.Text = "0"
            cmb_EntregaD.Text = "0"
            tbx_CantidadKM.Clear()
            tbx_ComentariosS.Clear()
        End If

        'Aqui se muestran los botones
        btn_Nuevo.Visible = True
        btn_Editar.Visible = Not sender.SelectedItems.Count = 0
        btn_Baja.Visible = Not sender.SelectedItems.Count = 0

        btn_Baja.Enabled = Not sender.SelectedItems.Count = 0
        btn_Editar.Enabled = Not sender.SelectedItems.Count = 0
    End Sub

#End Region

#Region "Horarios"

    Private Sub Horarios_Llenar()
        lsv_H_Servicios.SelectedItems.Clear()
        lsv_H_Servicios.Items.Clear()
        If Id_Cliente = 0 Then Exit Sub
        Dim Status As String = "T"
        If chk_ServiciosActivosH.Checked Then Status = "A"
        If Not fn_Clientes_Servicios_Horarios(Id_Cliente, lsv_H_Servicios, Status, "S") Then
            MsgBox("Ocurrio un error al tratar cargar la lista de Servicio en Horarios.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub Horarios_Limpiar()
        lsv_H_Servicios.Items.Clear()
        lsv_HorariosPev.Items.Clear()
        lsv_HorariosActivos.Items.Clear()
    End Sub

    Private Sub lsv_H_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_H_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_NuevoHorarioTemp1.Enabled = False
        btn_NuevoHorarioTempMas.Enabled = False
        btn_BajaHorarioTemp.Enabled = False
        btn_EditarHorarioTemp.Enabled = False
        btn_EditarHorario.Enabled = False
        btn_BajaHorario.Enabled = False
        btn_EdicionGlobal.Enabled = False
        lsv_HorariosPev.Items.Clear()
        lsv_HorariosActivos.Items.Clear()

        If lsv_H_Servicios.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarLista(lsv_H_Servicios.SelectedItems(0).Tag, lsv_HorariosPev)

            Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, _
                                                IIf(chk_Horarios.Checked, True, False), _
                                                lsv_HorariosActivos)
            btn_NuevoHorarioTemp1.Enabled = True
            btn_NuevoHorarioTempMas.Enabled = lsv_SubClientes.Items.Count > 0
            btn_EdicionGlobal.Enabled = chk_ClienteP.Checked
        End If
        lbl_totalHorariosServicios.Text = "Registros:" & lsv_HorariosActivos.Items.Count
    End Sub

    Private Sub btn_NuevoHorarioTemp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevoHorarioTemp1.Click
        SegundosDesconexion = 0

        Dim frm As New frm_ClientesHorariosUno
        Me.Cursor = Cursors.WaitCursor
        frm.Temp = True
        frm.Tag = 0
        frm.Id_Cliente = Id_Cliente
        frm.Clave_Precio = lsv_H_Servicios.SelectedItems(0).SubItems(2).Text
        frm.Id_PrecioDescripcion = lsv_H_Servicios.SelectedItems(0).SubItems(18).Text
        frm.Id_CS = lsv_H_Servicios.SelectedItems(0).Tag
        frm.cbx_Permitir.Visible = lsv_SubClientes.Items.Count > 0
        frm.Clave_Cliente = tbx_Buscar.Text
        Me.Cursor = Cursors.Default
        frm.ShowDialog()

        lsv_HorariosPev.SelectedItems.Clear()
        lsv_HorariosActivos.SelectedItems.Clear()
        If lsv_H_Servicios.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarLista(lsv_H_Servicios.SelectedItems(0).Tag, lsv_HorariosPev)
            Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, IIf(chk_Horarios.Checked, True, False), lsv_HorariosActivos)
        Else
            lsv_HorariosPev.Items.Clear()
            lsv_HorariosActivos.Items.Clear()
        End If
    End Sub

    Private Sub btn_NuevoHorarioTempMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevoHorarioTempMas.Click
        SegundosDesconexion = 0

        Dim frm As New frm_ClientesHorarios
        Me.Cursor = Cursors.WaitCursor
        frm.Id_Cliente = Id_Cliente
        frm.Clave_Precio = lsv_H_Servicios.SelectedItems(0).SubItems(2).Text
        frm.Id_PrecioDescripcion = lsv_H_Servicios.SelectedItems(0).SubItems(18).Text
        frm.Id_CS = lsv_H_Servicios.SelectedItems(0).Tag
        frm.Clave_Cliente = tbx_Buscar.Text
        Me.Cursor = Cursors.Default
        frm.ShowDialog()

        lsv_HorariosPev.SelectedItems.Clear()
        lsv_HorariosActivos.SelectedItems.Clear()
        If lsv_H_Servicios.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarLista(lsv_H_Servicios.SelectedItems(0).Tag, lsv_HorariosPev)
            Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, IIf(chk_Horarios.Checked, True, False), lsv_HorariosActivos)
        Else
            lsv_HorariosPev.Items.Clear()
            lsv_HorariosActivos.Items.Clear()
        End If
    End Sub

    Private Sub lsv_Horarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_HorariosPev.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_EditarHorarioTemp.Enabled = lsv_HorariosPev.SelectedItems.Count > 0
        btn_BajaHorarioTemp.Enabled = lsv_HorariosPev.SelectedItems.Count > 0
    End Sub

    Private Sub lsv_HorariosActivos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_HorariosActivos.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_EditarHorario.Enabled = lsv_HorariosActivos.SelectedItems.Count > 0
        btn_BajaHorario.Enabled = lsv_HorariosActivos.SelectedItems.Count > 0
    End Sub

    Private Sub btn_EditarHorarioTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditarHorarioTemp.Click
        SegundosDesconexion = 0

        Dim frm As New frm_ClientesHorariosUno
        frm.Id_Cliente = Id_Cliente
        frm.Id_CS = lsv_H_Servicios.SelectedItems(0).Tag
        frm.Tag = lsv_HorariosPev.SelectedItems(0).Tag
        frm.Temp = True
        frm.cbx_Permitir.Visible = False
        frm.Clave_Cliente = tbx_Buscar.Text
        frm.ShowDialog()

        lsv_HorariosPev.SelectedItems.Clear()
        lsv_HorariosActivos.SelectedItems.Clear()
        If lsv_H_Servicios.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarLista(lsv_H_Servicios.SelectedItems(0).Tag, lsv_HorariosPev)
            Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, IIf(chk_Horarios.Checked, True, False), lsv_HorariosActivos)
        Else
            lsv_HorariosPev.Items.Clear()
            lsv_HorariosActivos.Items.Clear()
        End If
    End Sub

    Private Sub btn_BajaHorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BajaHorario.Click
        SegundosDesconexion = 0

        If MsgBox("ADVERTECIA: Este movimiento afecta directamente la operación de las Rutas de Traslado de Valores. Realmente desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
            If lsv_HorariosActivos.SelectedItems(0).SubItems(8).Text = "ACTIVO" Then

                If Not fn_Clientes_BajaHorario(lsv_HorariosActivos.SelectedItems(0).Tag, "B") Then
                    MsgBox("Ha ocurrido un error al intentar dar de baja el Horario.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                If Not fn_Clientes_BajaHorario(lsv_HorariosActivos.SelectedItems(0).Tag, "A") Then
                    MsgBox("Ha ocurrido un error al intentar dar de alta el Horario.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                    Exit Sub
                End If
            End If

            lsv_HorariosActivos.SelectedItems.Clear()
            If lsv_H_Servicios.SelectedItems.Count > 0 Then
                Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, IIf(chk_Horarios.Checked, True, False), lsv_HorariosActivos)
            End If
        End If
    End Sub

    Private Sub btn_BajaHorarioTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BajaHorarioTemp.Click
        SegundosDesconexion = 0

        If Not fn_Clientes_BorraHorarioTemp(lsv_HorariosPev.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al eliminar el Horario Temporal.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        Else
            If lsv_H_Servicios.SelectedItems.Count > 0 Then fn_Horarios_LlenarLista(lsv_H_Servicios.SelectedItems(0).Tag, lsv_HorariosPev)
            btn_EditarHorarioTemp.Enabled = False
            btn_BajaHorarioTemp.Enabled = False
        End If
    End Sub

    Private Sub btn_ImportarHorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImportarHorarios.Click
        SegundosDesconexion = 0

        Dim NombreArchivo As String = System.IO.Path.GetFileName(Horarios_Ubicacion)
        Dim Dialogo As New OpenFileDialog
        Dialogo.Multiselect = False
        Dialogo.InitialDirectory = Microsoft.VisualBasic.Left(Horarios_Ubicacion, (Horarios_Ubicacion.Length - NombreArchivo.Length))
        Dialogo.FileName = NombreArchivo
        Dialogo.Filter = "Archivos de Excel |*.xlsm"
        If Dialogo.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        Dim Resultado As String = fn_Clientes_EdicionGlobal(Dialogo.FileName.Trim, frm_MENU.prg_Barra)
        MsgBox(Resultado, MsgBoxStyle.Information, frm_MENU.Text)
        Call Horarios_Llenar()
        frm_MENU.prg_Barra.Value = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_EdicionGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EdicionGlobal.Click
        SegundosDesconexion = 0

        'Preguntar donde se guardará el Archivo
        Dim Dialogo As New SaveFileDialog
        Dialogo.Filter = "Libro de Excel habilitado para macros (*.xlsm)|*.xlsm"
        If Dialogo.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Horarios_Ubicacion = Dialogo.FileName

        'Traer la Información de Horarios Temporales y Reales que concuerden con el precio, descripción y cliente.
        Dim Dt_HorariosTemporales As DataTable = fn_Clientes_HorariosTemporales(Id_Cliente, tbx_Buscar.Text, lsv_H_Servicios.SelectedItems(0).Tag)
        If Dt_HorariosTemporales Is Nothing Then MsgBox("Error al Consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text) : Exit Sub

        Dim Dt_HorariosReales As DataTable = fn_Clientes_HorariosReales(Id_Cliente, tbx_Buscar.Text, lsv_H_Servicios.SelectedItems(0).Tag)
        If Dt_HorariosReales Is Nothing Then MsgBox("Error al Consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text) : Exit Sub

        'Traer los clientes que se afectarán.
        Dim Dt_ClientesAfectar As DataTable = fn_Clientes_PadreHijos(Id_Cliente, lsv_H_Servicios.SelectedItems(0).SubItems(18).Text, lsv_H_Servicios.SelectedItems(0).SubItems(2).Text, "S")
        If Dt_ClientesAfectar Is Nothing Then MsgBox("Error al Consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text) : Exit Sub

        'Traer las Sucursales
        Dim Dt_Sucursales As DataTable = fn_Sucursales_Todos()
        If Dt_Sucursales Is Nothing OrElse Dt_Sucursales.Rows.Count = 0 Then MsgBox("Error al Consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text) : Exit Sub

        'Traer los Clientes por sucursal
        Dim Dt_Parcial As DataTable = Nothing
        Dim Dt_ClientesXSucursal As New DataTable
        Dt_ClientesXSucursal.Columns.Add("Sucursal")
        Dt_ClientesXSucursal.Columns.Add("ClientesXSuc", GetType(DataTable))
        Dim Indicador As Integer = 0
        Dim TotalClientes As Integer = 0
        For Each Sucursal As DataRow In Dt_Sucursales.Rows
            Dt_Parcial = fn_Clientes_Todos(Sucursal("Id_Sucursal"))
            If Dt_Parcial Is Nothing Then MsgBox("Error al Consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text) : Exit Sub
            Dt_ClientesXSucursal.Rows.Add(Sucursal("Nombre"), Dt_Parcial)
            TotalClientes += Dt_Parcial.Rows.Count
            Indicador += 1
        Next
        Dt_Parcial.Clear()

        'Cuando no se tenga información
        If (Dt_HorariosTemporales.Rows.Count = 0 AndAlso Dt_HorariosReales.Rows.Count = 0) OrElse Dt_ClientesAfectar.Rows.Count = 0 Then
            MsgBox("No existe Información para Editar.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        frm_MENU.prg_Barra.Maximum = 10 + Dt_HorariosTemporales.Rows.Count + Dt_HorariosReales.Rows.Count + _
                                     Dt_ClientesAfectar.Rows.Count + Dt_Sucursales.Rows.Count + (TotalClientes * 2)
        frm_MENU.prg_Barra.Value = 0
        Dim UltimaFila As Integer = Dt_HorariosTemporales.Rows.Count + Dt_HorariosReales.Rows.Count + 2
        Dim Xls = CreateObject("Excel.Application") 'As New Microsoft.Office.Interop.Excel.Application
        Xls.SheetsInNewWorkbook = 3
        Dim Wbk = Xls.Workbooks.Add() 'As Microsoft.Office.Interop.Excel.Workbook
        Dim Wsht1 = Wbk.Sheets(1) 'As Microsoft.Office.Interop.Excel.Worksheet
        Dim Wsht2 = Wbk.Sheets(2)
        Dim Wsht3 = Wbk.Sheets(3)
        'Xls.Visible = True

        Me.Cursor = Cursors.WaitCursor
        frm_MENU.prg_Barra.Value += 1
        With Wsht2
            .Range("A10").Value = "***"
            .Range("A1").Value = "Id_Sucursal"
            .Range("B1").Value = "Sucursales"
            'For para llenar las Sucursales y Id
            Indicador = 2
            For Each Row As DataRow In Dt_Sucursales.Rows
                .Range("A" & Indicador).Value = Row("Id_Sucursal")
                .Range("B" & Indicador).Value = Row("Nombre")
                Indicador += 1
                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("A2:A" & (Indicador - 1)).Name = "Id_Sucursales" 'Agregarle Nombre al Rango de Sucursales
            .Range("B2:B" & (Indicador - 1)).Name = "Sucursales" 'Agregarle Nombre al Rango de Sucursales Descripcion
            .Range("D1").Value = "Sucursales"
            .Range("D1").Name = "SucursalesInicio" 'Agregarle Nombre al encabezado de Sucursales
            .Range("D:D").Name = "SucursalesColumna" 'Agregarle Nombre al Rango a la columna Sucursales
            .Range("E1").Value = "Id_Cliente"
            .Range("F1").Value = "ClavesEmpresas"
            .Range("G1").Value = "Empresas"
            .Range("F:F").NumberFormat = "@"
            .Range("U:U").NumberFormat = "@"
            'Hacer For para llenar los Clientes con su Respectiva Sucursal
            Indicador = 2
            For ILocal As Integer = 0 To Dt_ClientesXSucursal.Rows.Count - 1
                For Each ClienteSucursal As DataRow In Dt_ClientesXSucursal(ILocal)("ClientesXSuc").Rows
                    .Range("D" & Indicador).Value = Dt_ClientesXSucursal(ILocal)("Sucursal")
                    .Range("E" & Indicador).Value = ClienteSucursal("Id_Cliente")
                    .Range("F" & Indicador).Value = ClienteSucursal("Clave")
                    .Range("G" & Indicador).Value = ClienteSucursal("Cliente")
                    Indicador += 1
                    frm_MENU.prg_Barra.Value += 1
                Next
            Next
            .Range("D2:D" & (Indicador - 1)).Name = "SucursalesEmpresas" 'Agregarle Nombre al Rango de las Sucursales de Empresas
            .Range("E2:E" & (Indicador - 1)).Name = "Id_Empresas" 'Agregarle Nombre al Rango de los Id de Empresas
            .Range("F2:F" & (Indicador - 1)).Name = "ClavesEmpresas" 'Agregarle Nombre al Rango de las Claves de Empresas
            .Range("G2:G" & (Indicador - 1)).Name = "Empresas" 'Agregarle Nombre al Rango de Empresas

            .Range("I1").Value = "Tipo"
            .Range("I2").Value = "S"
            .Range("I3").Value = "Q"
            .Range("I4").Value = "M"
            .Range("J1").Value = "Descripcion"
            .Range("J2").Value = "CADA 1 SEMANA"
            .Range("J3").Value = "CADA 2 SEMANAS"
            .Range("J4").Value = "CADA 4 SEMANAS"
            .Range("I2:I4").Name = "Tipos" 'Agregarle Nombre al Rango de Tipos
            .Range("J2:J4").Name = "TiposDesc" 'Agregarle Nombre al Rango de Tipos Descripcion

            .Range("L1").Value = "Dia"
            .Range("L2").Value = "1"
            .Range("L3").Value = "2"
            .Range("L2:L3").AutoFill(Destination:=.Range("L2:L9"), Type:=0) 'xlFillDefault
            .Range("M1").Value = "Descripcion"
            .Range("M2").Value = "DOMINGO"
            .Range("M3").Value = "LUNES"
            .Range("M4").Value = "MARTES"
            .Range("M5").Value = "MIERCOLES"
            .Range("M6").Value = "JUEVES"
            .Range("M7").Value = "VIERNES"
            .Range("M8").Value = "SABADO"
            .Range("M9").Value = "RESULTAS"
            .Range("L2:L9").Name = "Dias" 'Agregarle Nombre al Rango de Días
            .Range("M2:M9").Name = "DiasDesc" 'Agregarle Nombre al Rango de Días Descripcion

            .Range("O1").Value = "Horas"
            .Range("O2").Value = "0:00"
            .Range("O3").Value = "0:15"
            .Range("O2:O3").AutoFill(Destination:=.Range("O2:O97"), Type:=0) 'xlFillDefault
            .Range("O2:O97").Name = "Horas" 'Agregarle Nombre al Rango de Horas

            .Range("Q1").Value = "Escala En Boveda"
            .Range("Q2").Value = "S"
            .Range("Q3").Value = "N"
            .Range("R1").Value = "Descripcion"
            .Range("R2").Value = "SI"
            .Range("R3").Value = "NO"
            .Range("Q2:Q3").Name = "Escala" 'Agregarle Nombre al Rango de Escala
            .Range("R2:R3").Name = "EscalaDesc" 'Agregarle Nombre al Rango de Escala Descripcion

            .Range("T1").Value = "Id_ClientesAfectar"
            .Range("U1").Value = "ClaveCliAfectar"
            .Range("V1").Value = "ClientesAfectar"
            .Range("W1").Value = "Id_CS"
            'For para llenar los Clientes a Afectar
            Indicador = 2
            For Each Row As DataRow In Dt_ClientesAfectar.Rows
                .Range("T" & Indicador).Value = Row("IDC")
                .Range("U" & Indicador).Value = Row("Clave")
                .Range("V" & Indicador).Value = Row("Cliente")
                .Range("W" & Indicador).Value = Row("Id_CS")
                Indicador += 1
                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("T2:T" & (Indicador - 1)).Name = "Id_ClientesAfectar" 'Agregarle Nombre al Rango de Id_ClientesAfectar
            .Range("U2:U" & (Indicador - 1)).Name = "ClaveCliAfectar" 'Agregarle Nombre al Rango de ClaveCliAfectar
            .Range("V2:V" & (Indicador - 1)).Name = "ClientesAfectar" 'Agregarle Nombre al Rango de ClientesAfectar

            .Range("Y1").Value = "Status"
            .Range("Y2").Value = "A"
            .Range("Y3").Value = "B"
            .Range("Z1").Value = "Descripcion"
            .Range("Z2").Value = "ACTIVO"
            .Range("Z3").Value = "BAJA"
            .Range("Y2:Y3").Name = "Status" 'Agregarle Nombre al Rango de Status
            .Range("Z2:Z3").Name = "StatusDesc" 'Agregarle Nombre al Rango de StatusDesc

            'Ocultar columnas por seguridad
            .Range("A:Z").EntireColumn.Hidden = True

            .Select()
            .Range("AA1").Select()
            Xls.ActiveWindow.SelectedSheets.Visible = False
        End With

        With Wsht3
            .Select()
            .Name = "Catálogo de Clientes"

            .Range("A1").Value = "Sucursal"
            .Range("B1").Value = "Clave"
            .Range("C1").Value = "Nombre Comercial"
            'Hacer For para llenar los Clientes con su Respectiva Sucursal
            Indicador = 2

            .Range("B:B").NumberFormat = "@"
            For ILocal As Integer = 0 To Dt_ClientesXSucursal.Rows.Count - 1
                For Each ClienteSucursal As DataRow In Dt_ClientesXSucursal(ILocal)("ClientesXSuc").Rows
                    .Range("A" & Indicador).Value = Dt_ClientesXSucursal(ILocal)("Sucursal")
                    .Range("B" & Indicador).Value = ClienteSucursal("Clave")
                    .Range("C" & Indicador).Value = ClienteSucursal("Cliente")
                    Indicador += 1
                    frm_MENU.prg_Barra.Value += 1
                Next
            Next
            .Range("A:C").EntireColumn.AutoFit()

            Xls.ActiveWindow.SplitRow = 1
            Xls.ActiveWindow.FreezePanes = True

            'Ocultar Filas y Encabezados
            Xls.ActiveWindow.DisplayHeadings = False
        End With

        With Wsht1
            .Select()
            .Name = "Horarios"
            .Range("A2").Value = "Id_CS"
            .Range("B2").Value = "Id_CH"
            .Range("C2").Value = "Id_Htemp"
            .Range("D2").Value = "Id_Cliente"
            .Range("E2").Value = "Clave"
            .Range("E2").AddComment()
            .Range("E2").Comment.Visible = False
            .Range("E2").Comment.Text(Text:="Colores.-" & Chr(10) & _
                                            "  - Sin Color: Registro para Editar." & Chr(10) & _
                                            "  - Verde: Nuevo Horario." & Chr(10) & _
                                            "  - Rojo: Horario para dar de Baja u Horario Nuevo Cancelado.")
            .Range("E2").Comment.Shape.TextFrame.AutoSize = True
            .Range("E:E").NumberFormat = "@"
            .Range("J:J").NumberFormat = "@"
            .Range("P:P").NumberFormat = "@"
            .Range("AE:AE").NumberFormat = "@"
            .Range("AJ:AJ").NumberFormat = "@"
            .Range("AP:AP").NumberFormat = "@"
            .Range("M:N").NumberFormat = "hh:mm"
            .Range("S:T").NumberFormat = "hh:mm"
            .Range("AM:AN").NumberFormat = "hh:mm"
            .Range("AS:AT").NumberFormat = "hh:mm"
            .Range("F2").Value = "Cliente"
            .Range("F2").AddComment()
            .Range("F2").Comment.Visible = False
            .Range("F2").Comment.Text(Text:="Colores:" & Chr(10) & _
                                            "  - Sin Color: Registro no Editado." & Chr(10) & _
                                            "  - Azul: Registro Editado.")
            .Range("F2").Comment.Shape.TextFrame.AutoSize = True
            .Range("G2").Value = "Frecuencia"
            .Range("G2").AddComment()
            .Range("G2").Comment.Visible = False
            .Range("G2").Comment.Text(Text:="Colores:" & Chr(10) & _
                                            "  - Naranja: Horario Pendiente." & Chr(10) & _
                                            "  - Gris: Horario Real.")
            .Range("G2").Comment.Shape.TextFrame.AutoSize = True
            .Range("BA2").Value = "IdOrigen"
            .Range("BB2").Value = "IdDestino"
            .Range("A:D").EntireColumn.Hidden = True

            'Establecer Tamaños de Columnas
            .Range("H:H").ColumnWidth = 11 'Fecha Inicio (Recolección)
            .Range("I:I").ColumnWidth = 21 'Sucursal (Recolección)
            .Range("J:J").ColumnWidth = 11.5 'Clave Cliente (Recolección)
            .Range("L:L").ColumnWidth = 19 'Tipo (Recolección)
            .Range("M:M").ColumnWidth = 7 'De: (Recolección)
            .Range("N:N").ColumnWidth = 7 'A: (Recolección)
            .Range("O:O").ColumnWidth = 21 'Sucursal (Entrega)
            .Range("P:P").ColumnWidth = 11.5 'Clave Cliente (Entrega)
            .Range("R:R").ColumnWidth = 10.14 'Día (Entrega)
            .Range("S:S").ColumnWidth = 7 'De:(Entrega)
            .Range("T:T").ColumnWidth = 7 'A: (Entrega)
            .Range("U:U").ColumnWidth = 7 'Escala en Bóveda (Entrega)
            .Rows("2:2").RowHeight = 30

            .Range("H1").Value = "RECOLECCION"
            .Range("H1:N1").Merge()
            .Range("O1").Value = "DESTINO"
            .Range("O1:U1").Merge()
            .Range("H2").Value = "Fecha de Inicio"
            .Range("I2").Value = "Sucursal"
            .Range("J2").Value = "Clave"
            .Range("K2").Value = "Cliente"
            .Range("L2").Value = "Tipo"
            .Range("M2").Value = "De:"
            .Range("N2").Value = "A:"
            .Range("O2").Value = "Sucursal"
            .Range("P2").Value = "Clave"
            .Range("Q2").Value = "Cliente"
            .Range("R2").Value = "Día"
            .Range("S2").Value = "De:"
            .Range("T2").Value = "A:"
            .Range("U2").Value = "Escala Bóveda"
            .Range("V2").Value = "STATUS"

            .Range("H1:U1").HorizontalAlignment = -4117
            With .Range("A2:U2")
                .HorizontalAlignment = -4117 'xlDistributed
                .VerticalAlignment = -4117 'xlDistributed
                .WrapText = False
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002 'xlContext
                .MergeCells = False
            End With

            'Bordes y Centrado de Texto
            For ILocal As Integer = 7 To 11
                .Range("E2:G2").Borders(ILocal).Weight = -4138 'Linea Negra Left, Top, Bottom, Right, Vertical
            Next
            .Range("H1:V3").Borders(7).Weight = -4138 'Linea Negra Left
            .Range("H1:V2").Borders(8).Weight = -4138 'Linea Negra Top
            .Range("H1:V2").Borders(9).Weight = -4138 'Linea Negra Bottom
            .Range("H1:V2").Borders(11).Weight = -4138 'Linea Negra Vertical
            .Range("H1:V2").Borders(12).Weight = -4138 'Linea Negra Horizontal
            .Range("H1:V3").Borders(10).Weight = -4138 'Linea Negra Right
            .Range("O1:U3").Borders(7).Weight = -4138 'Linea Negra Left
            .Range("O1:U3").Borders(10).Weight = -4138 'Linea Negra Right

            .Range("V1:V2").Merge()

            .Range("H3").Value = Today.Date.ToShortDateString 'Para que no genere error al ingresar la fórmula de fecha (Origen)
            .Range("I3").Value = "SISSA MONTERREY" 'Para que no genere error al insertar la formula de la validación ligada (Origen)
            .Range("O3").Value = "SISSA MONTERREY" 'Para que no genere error al insertar la formula de la validación ligada (Destino)
            .Range("V3").Value = "ACTIVO" 'Valor por default

            frm_MENU.prg_Barra.Value += 1

            With .Range("G3").Validation
                'Validar la Frecuencia
                .Delete()
                .Add(3, 1, 1, "=DiasDesc")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Frecuencia"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Frecuencia."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("H3").Validation
                'Validar la Fecha que se capture (Origen)
                .Delete()
                .Add(4, 1, 7, Today.Date.ToShortDateString)
                .IgnoreBlank = False
                .InCellDropdown = True
                .InputTitle = "Fecha de Inicio"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "La Fecha de Inicio debe de ser Igual o Mayor a la Fecha Actual."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("I3").Validation
                'Validar que sólo se seleccione una sucursal disponible (Origen)
                .Delete()
                .Add(3, 1, 1, "=Sucursales")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Sucursal"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Sucursal."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("K3").Validation
                'Validar que sólo se seleccione un cliente según la sucursal (Origen)
                .Delete()
                .Add(3, 1, 1, "=DESREF(SucursalesInicio,COINCIDIR(I3,SucursalesColumna,0)-1,3,CONTAR.SI(SucursalesColumna,I3),1)")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "ClientesAfectar"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Clave del Cliente."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("L3").Validation
                'Validar que sólo se seleccione un Tipo (Origen)
                .Delete()
                .Add(3, 1, 1, "=TiposDesc")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Tipo"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar el Tipo."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("M3").Validation
                'Validar que sólo se seleccione la Hora "De:" (Origen)
                .Delete()
                .Add(3, 1, 1, "=Horas")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "De:"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Hora 'De:'."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("N3").Validation
                'Validar que sólo se seleccione la Hora "A:" (Origen)
                .Delete()
                .Add(3, 1, 1, "=Horas")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "A:"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Hora 'A:'."
                .ShowInput = True
                .ShowError = True
            End With

            frm_MENU.prg_Barra.Value += 1

            With .Range("O3").Validation
                'Validar que sólo se seleccione una sucursal disponible (Destino)
                .Delete()
                .Add(3, 1, 1, "=Sucursales")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Sucursal"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Sucursal."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("Q3").Validation
                'Validar que sólo se seleccione un cliente según la sucursal (Destino)
                .Delete()
                .Add(3, 1, 1, "=DESREF(SucursalesInicio,COINCIDIR(O3,SucursalesColumna,0)-1,3,CONTAR.SI(SucursalesColumna,O3),1)")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Clientes"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar el Cliente."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("R3").Validation
                'Validar que sólo se seleccione un Día (Destino)
                .Delete()
                .Add(3, 1, 1, "=DiasDesc")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Día"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar un Día."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("S3").Validation
                'Validar que sólo se seleccione la Hora "De:" (Destino)
                .Delete()
                .Add(3, 1, 1, "=Horas")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "De:"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Hora 'De:'."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("T3").Validation
                'Validar que sólo se seleccione la Hora "A:" (Destino)
                .Delete()
                .Add(3, 1, 1, "=Horas")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "A:"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar la Hora 'A:'."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("U3").Validation
                'Validar que sólo se seleccione si se hará o no Escala en Bóveda (Destino)
                .Delete()
                .Add(3, 1, 1, "=EscalaDesc")
                .IgnoreBlank = True
                .InCellDropdown = True
                .InputTitle = "Escala en Bóveda"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar si se hará o no Escala en Bóveda."
                .ShowInput = True
                .ShowError = True
            End With

            With .Range("V3").Validation
                'Validar que sólo se seleccione si el Status
                .Delete()
                .Add(3, 1, 1, "=StatusDesc")
                .IgnoreBlank = False
                .InCellDropdown = True
                .InputTitle = "Status"
                .ErrorTitle = "Horarios"
                .InputMessage = ""
                .ErrorMessage = "De la Lista desplegable se debe de seleccionar el Status del Horario."
                .ShowInput = True
                .ShowError = True
            End With
            frm_MENU.prg_Barra.Value += 1

            'Copiar Validaciones    
            If UltimaFila <> 3 Then
                .Range("G3:V3").AutoFill(Destination:=.Range("G3:V" & UltimaFila), Type:=0) 'xlFillDefault
            End If

            'Agregar los Clientes a Actualizar de Horarios Temporales
            Indicador = 3
            Dim RecoleccionH() As String
            Dim EntregaH() As String
            For Each HTemporales As DataRow In Dt_HorariosTemporales.Rows
                .Range("A" & Indicador).Value = HTemporales("IDCS")
                .Range("AA" & Indicador).Value = HTemporales("IDCS") 'Espejo
                .Range("B" & Indicador).Value = HTemporales("IDCH")
                .Range("AB" & Indicador).Value = HTemporales("IDCH") 'Id_CH (Espejo)
                .Range("C" & Indicador).Value = HTemporales("Id_Htemp")
                .Range("AC" & Indicador).Value = HTemporales("Id_Htemp") 'Espejo
                .Range("D" & Indicador).Value = HTemporales("IDC")
                .Range("AD" & Indicador).Value = HTemporales("IDC") 'Espejo
                .Range("E" & Indicador).Value = HTemporales("ClaveCliente")
                .Range("AE" & Indicador).Value = HTemporales("ClaveCliente") 'Espejo
                .Range("F" & Indicador).Value = HTemporales("Cliente")
                .Range("AF" & Indicador).Value = HTemporales("Cliente") 'Espejo
                .Range("G" & Indicador).Value = HTemporales("Frecuencia")
                .Range("AG" & Indicador).Value = HTemporales("Frecuencia") 'Espejo
                'Identificar Horarios Temporales
                With .Range("G" & Indicador).Interior
                    .Pattern = 1
                    .PatternColorIndex = -4105
                    .Color = 49407
                    .TintAndShade = 0
                    .PatternTintAndShade = 0
                End With
                RecoleccionH = Split(HTemporales("HorarioRecoleccion"), "/")
                EntregaH = Split(HTemporales("HorarioEntrega"), "/")
                'Información de Recolección
                .Range("H" & Indicador).Value = HTemporales("FechaInicio")
                .Range("AH" & Indicador).Value = HTemporales("FechaInicio") 'Espejo
                .Range("I" & Indicador).Value = HTemporales("SucursalOrigen")
                .Range("AI" & Indicador).Value = HTemporales("SucursalOrigen") 'Espejo
                .Range("J" & Indicador).Value = HTemporales("ClaveCliOrigen")
                .Range("AJ" & Indicador).Value = HTemporales("ClaveCliOrigen") 'Espejo
                .Range("K" & Indicador).Value = HTemporales("ClienteOrigen")
                .Range("AK" & Indicador).Value = HTemporales("ClienteOrigen") 'Espejo
                .Range("L" & Indicador).Value = HTemporales("Tipo")
                .Range("AL" & Indicador).Value = HTemporales("Tipo") 'Espejo
                .Range("M" & Indicador).Value = RecoleccionH(0)
                .Range("AM" & Indicador).Value = RecoleccionH(0) 'Espejo
                .Range("N" & Indicador).Value = RecoleccionH(1)
                .Range("AN" & Indicador).Value = RecoleccionH(1) 'Espejo
                'Información de Destino
                .Range("O" & Indicador).Value = HTemporales("SucursalDestino")
                .Range("AO" & Indicador).Value = HTemporales("SucursalDestino") 'Espejo
                .Range("P" & Indicador).Value = HTemporales("ClaveCliDestino")
                .Range("AP" & Indicador).Value = HTemporales("ClaveCliDestino") 'Espejo
                .Range("Q" & Indicador).Value = HTemporales("ClienteDestino")
                .Range("AQ" & Indicador).Value = HTemporales("ClienteDestino") 'Espejo
                .Range("R" & Indicador).Value = HTemporales("DiaEntrega")
                .Range("AR" & Indicador).Value = HTemporales("DiaEntrega") 'Espejo
                .Range("S" & Indicador).Value = EntregaH(0)
                .Range("AS" & Indicador).Value = EntregaH(0) 'Espejo
                .Range("T" & Indicador).Value = EntregaH(1)
                .Range("AT" & Indicador).Value = EntregaH(1) 'Espejo
                .Range("U" & Indicador).Value = HTemporales("EscalaBoveda")
                .Range("AU" & Indicador).Value = HTemporales("EscalaBoveda") 'Espejo

                'Celdas Extras para Validar cuando se guarde
                .Range("BA" & Indicador).Value = HTemporales("IdCO") 'Para Validación
                .Range("BB" & Indicador).Value = HTemporales("IdCD") 'Para Validación
                .Range("BC" & Indicador).Value = "T" 'Identifica que es horario Temporal

                'El nombre del cliente se pondrá azul Cuando se modifique de una fila cualquier valor (Formato condicional)
                .Range("F" & Indicador).FormatConditions.Add(Type:=2, Formula1:= _
                                                             "=O($G$" & Indicador & "<>$AG$" & Indicador & "," & _
                                                             "$I$" & Indicador & "<>$AI$" & Indicador & "," & _
                                                             "$J$" & Indicador & "<>$AJ$" & Indicador & "," & _
                                                             "$K$" & Indicador & "<>$AK$" & Indicador & "," & _
                                                             "$L$" & Indicador & "<>$AL$" & Indicador & "," & _
                                                             "$M$" & Indicador & "<>$AM$" & Indicador & "," & _
                                                             "$N$" & Indicador & "<>$AN$" & Indicador & "," & _
                                                             "$O$" & Indicador & "<>$AO$" & Indicador & "," & _
                                                             "$P$" & Indicador & "<>$AP$" & Indicador & "," & _
                                                             "$Q$" & Indicador & "<>$AQ$" & Indicador & "," & _
                                                             "$R$" & Indicador & "<>$AR$" & Indicador & "," & _
                                                             "$S$" & Indicador & "<>$AS$" & Indicador & "," & _
                                                             "$T$" & Indicador & "<>$AT$" & Indicador & "," & _
                                                             "$U$" & Indicador & "<>$AU$" & Indicador & ")")
                .Range("F" & Indicador).FormatConditions(.Range("F" & Indicador).FormatConditions.Count).SetFirstPriority()
                With .Range("F" & Indicador).FormatConditions(1).Interior
                    .PatternColorIndex = -4105
                    .ThemeColor = 4
                    .TintAndShade = 0.799981688894314
                End With
                .Range("F" & Indicador).FormatConditions(1).StopIfTrue = False

                'Agregar formato condicional cuando cambie de Status (clave cliente en rojo)
                .Range("E" & Indicador).FormatConditions.Add(Type:=2, Formula1:="=$V$" & Indicador & "=""BAJA""")
                .Range("E" & Indicador).FormatConditions(.Range("E" & Indicador).FormatConditions.Count).SetFirstPriority()
                With .Range("E" & Indicador).FormatConditions(1).Interior
                    .PatternColorIndex = -4105
                    .Color = 255
                    .TintAndShade = 0
                End With
                .Range("E" & Indicador).FormatConditions(1).StopIfTrue = False

                Indicador += 1
                frm_MENU.prg_Barra.Value += 1
            Next

            For Each HReales As DataRow In Dt_HorariosReales.Rows
                .Range("A" & Indicador).Value = HReales("IDCS")
                .Range("AA" & Indicador).Value = HReales("IDCS") 'Espejo
                .Range("B" & Indicador).Value = HReales("Id_CH")
                .Range("AB" & Indicador).Value = HReales("Id_CH") 'Espejo
                .Range("C" & Indicador).Value = 0 'Id_Htemp
                .Range("AC" & Indicador).Value = 0 'Id_Htemp Espejo
                .Range("D" & Indicador).Value = HReales("IDC")
                .Range("AD" & Indicador).Value = HReales("IDC") 'Espejo
                .Range("E" & Indicador).Value = HReales("ClaveCliente")
                .Range("AE" & Indicador).Value = HReales("ClaveCliente") 'Espejo
                .Range("F" & Indicador).Value = HReales("Cliente")
                .Range("AF" & Indicador).Value = HReales("Cliente") 'Espejo
                .Range("G" & Indicador).Value = HReales("Frecuencia")
                .Range("AG" & Indicador).Value = HReales("Frecuencia") 'Espejo
                'Identificar Horarios Reales
                With .Range("G" & Indicador).Interior
                    .Pattern = 1
                    .PatternColorIndex = -4105
                    .ThemeColor = 1
                    .TintAndShade = -0.249977111117893
                    .PatternTintAndShade = 0
                End With
                RecoleccionH = Split(HReales("HorarioRecoleccion"), "/")
                EntregaH = Split(HReales("HorarioEntrega"), "/")
                'Información de Recolección
                .Range("H" & Indicador).Value = HReales("FechaInicio")
                .Range("AH" & Indicador).Value = HReales("FechaInicio") 'Espejo
                .Range("I" & Indicador).Value = HReales("SucursalOrigen")
                .Range("AI" & Indicador).Value = HReales("SucursalOrigen") 'Espejo
                .Range("J" & Indicador).Value = HReales("ClaveCliOrigen")
                .Range("AJ" & Indicador).Value = HReales("ClaveCliOrigen") 'Espejo
                .Range("K" & Indicador).Value = HReales("ClienteOrigen")
                .Range("AK" & Indicador).Value = HReales("ClienteOrigen") 'Espejo
                .Range("L" & Indicador).Value = HReales("Tipo")
                .Range("AL" & Indicador).Value = HReales("Tipo") 'Espejo
                .Range("M" & Indicador).Value = RecoleccionH(0)
                .Range("AM" & Indicador).Value = RecoleccionH(0) 'Espejo
                .Range("N" & Indicador).Value = RecoleccionH(1)
                .Range("AN" & Indicador).Value = RecoleccionH(1) 'Espejo
                'Información de Destino
                .Range("O" & Indicador).Value = HReales("SucursalDestino")
                .Range("AO" & Indicador).Value = HReales("SucursalDestino") 'Espejo
                .Range("P" & Indicador).Value = HReales("ClaveCliDestino")
                .Range("AP" & Indicador).Value = HReales("ClaveCliDestino") 'Espejo
                .Range("Q" & Indicador).Value = HReales("ClienteDestino")
                .Range("AQ" & Indicador).Value = HReales("ClienteDestino") 'Espejo
                .Range("R" & Indicador).Value = HReales("DiaEntrega")
                .Range("AR" & Indicador).Value = HReales("DiaEntrega") 'Espejo
                .Range("S" & Indicador).Value = EntregaH(0)
                .Range("AS" & Indicador).Value = EntregaH(0) 'Espejo
                .Range("T" & Indicador).Value = EntregaH(1)
                .Range("AT" & Indicador).Value = EntregaH(1) 'Espejo
                .Range("U" & Indicador).Value = HReales("EscalaBoveda")
                .Range("AU" & Indicador).Value = HReales("EscalaBoveda") 'Espejo

                'Celdas Extras para Validar cuando se guarde
                .Range("BA" & Indicador).Value = HReales("IdCO") 'Para Validación
                .Range("BB" & Indicador).Value = HReales("IdCD") 'Para Validación
                .Range("BC" & Indicador).Value = "R" 'Identifica que es horario Real

                'El nombre del cliente se pondrá azul Cuando se modifique de una fila cualquier valor (Formato condicional)
                .Range("F" & Indicador).FormatConditions.Add(Type:=2, Formula1:= _
                                                             "=O($G$" & Indicador & "<>$AG$" & Indicador & "," & _
                                                             "$I$" & Indicador & "<>$AI$" & Indicador & "," & _
                                                             "$J$" & Indicador & "<>$AJ$" & Indicador & "," & _
                                                             "$K$" & Indicador & "<>$AK$" & Indicador & "," & _
                                                             "$L$" & Indicador & "<>$AL$" & Indicador & "," & _
                                                             "$M$" & Indicador & "<>$AM$" & Indicador & "," & _
                                                             "$N$" & Indicador & "<>$AN$" & Indicador & "," & _
                                                             "$O$" & Indicador & "<>$AO$" & Indicador & "," & _
                                                             "$P$" & Indicador & "<>$AP$" & Indicador & "," & _
                                                             "$Q$" & Indicador & "<>$AQ$" & Indicador & "," & _
                                                             "$R$" & Indicador & "<>$AR$" & Indicador & "," & _
                                                             "$S$" & Indicador & "<>$AS$" & Indicador & "," & _
                                                             "$T$" & Indicador & "<>$AT$" & Indicador & "," & _
                                                             "$U$" & Indicador & "<>$AU$" & Indicador & ")")
                .Range("F" & Indicador).FormatConditions(.Range("F" & Indicador).FormatConditions.Count).SetFirstPriority()
                With .Range("F" & Indicador).FormatConditions(1).Interior
                    .PatternColorIndex = -4105
                    .ThemeColor = 4
                    .TintAndShade = 0.799981688894314
                End With
                .Range("F" & Indicador).FormatConditions(1).StopIfTrue = False

                .Range("E" & Indicador).FormatConditions.Add(Type:=2, Formula1:="=$V$" & Indicador & "=""BAJA""") 'Agregar formato condicional
                .Range("E" & Indicador).FormatConditions(.Range("E" & Indicador).FormatConditions.Count).SetFirstPriority()
                With .Range("E" & Indicador).FormatConditions(1).Interior
                    .PatternColorIndex = -4105
                    .Color = 255
                    .TintAndShade = 0
                End With
                .Range("E" & Indicador).FormatConditions(1).StopIfTrue = False

                Indicador += 1
                frm_MENU.prg_Barra.Value += 1
            Next

            frm_MENU.prg_Barra.Value += 1

            'Las celdas que se usan de espejo se ocultaran para solo usarlos de referencia
            .Range("AA:BD").EntireColumn.Hidden = True

            'Posicionarse en la Primer Celda
            .Range("E1").Select()

            'Establecer Tamaños de Columnas
            .Range("E:G").EntireColumn.AutoFit() 'Clave, Nombre del Cliente Principal y Frecuencia
            Xls.ActiveWindow.SplitRow = 2
            Xls.ActiveWindow.SplitColumn = 3
            Xls.ActiveWindow.FreezePanes = True

            frm_MENU.prg_Barra.Value += 1
            .Range("A1:V" & UltimaFila).Copy()
            .Range("AA1").Select()
            .Paste()
            .Range("AA:AV").EntireColumn.Hidden = True

            'Desbloquear las Celdas que se podrán Editar
            .Range("G3:V" & UltimaFila).Locked = False
            .Range("BA:BC").Locked = False

            '.Range("A:V").FormulaHidden = True

            .Range("K:K").EntireColumn.AutoFit() 'Cliente (Recolección)
            .Range("Q:Q").EntireColumn.AutoFit() 'Cliente (Entrega)

            Dim CalendarioAgregado As Boolean = False
            Try
                Dim Calendario_Excel = .OLEObjects.Add(ClassType:="MSCAL.Calendar.7", Link:=False, _
                                                   DisplayAsIcon:=False, Left:=372, Top:=242.25, Width:=215.25, Height:= _
                                                   143.25)
                Calendario_Excel.Visible = False
                CalendarioAgregado = True
            Catch
            End Try

            If Not CalendarioAgregado Then
                Try
                    Dim Calendario_Excel = .OLEObjects.Add(ClassType:="MSCAL.Calendar.7", Link:=False, _
                                                   DisplayAsIcon:=False, Left:=372, Top:=242.25, Width:=215.25, Height:= _
                                                   143.25)
                    Calendario_Excel.Visible = False
                    CalendarioAgregado = True
                Catch
                End Try
            End If

            'Ocultar Filas y Encabezados
            Xls.ActiveWindow.DisplayHeadings = False

            'Proteger la Hoja
            .Range("E1").Select()
            Xls.ActiveWindow.ScrollColumn = 8

            Try
                Wbk.VBProject.VBComponents.Import(Application.StartupPath & "\Macro_NuevoHorario.txt")
            Catch
                Xls = Nothing
                frm_MENU.prg_Barra.Value = 0
                Me.Cursor = Cursors.Default
                MsgBox("Ocurrió un error al intentar generar el Archivo de Excel.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End Try
            frm_MENU.prg_Barra.Value += 1

            Dim btn_Excel = .Buttons.Add(33, 1, 90, 17)
            With btn_Excel
                .Select()
                .Characters.Text = "Nuevo Horario"
                .Placement = 3 'xlFree
                .PrintObject = False
                .OnAction = "Macro_NuevoHorario"
            End With

            frm_MENU.prg_Barra.Value += 1

            Try
                Xls.Application.Run("Macro_HojaHorarios")
            Catch
            End Try

            If Not CalendarioAgregado Then
                Try
                    Xls.Application.Run("Macro_CrearCalendario")
                Catch
                End Try
            End If

            .Protect(Password:="***")
        End With
        'Proteger la Hoja 2
        Wsht2.Protect(Password:="***")

        Xls.Application.ErrorCheckingOptions.BackgroundChecking = False 'Que no se muestren los "errores" de formato
        Xls.CutCopyMode = False
        Xls.Application.DisplayAlerts = False
        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
        Try
            Wbk.SaveAs(Filename:=Horarios_Ubicacion, FileFormat:=52, CreateBackup:=False) 'xlOpenXMLWorkbookMacroEnabled
        Catch
            MsgBox("El archivo de Excel fue creado correctamente pero no se puedo guardar.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
        Xls.Application.DisplayAlerts = True
        Xls.Visible = True
        Xls = Nothing
        frm_MENU.prg_Barra.Value = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_EditarHorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditarHorario.Click
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        Dim frm = New frm_ClientesHorariosUno
        frm.Temp = False
        frm.Id_Cliente = Id_Cliente
        frm.Id_CS = lsv_H_Servicios.SelectedItems(0).Tag
        frm.Tag = lsv_HorariosActivos.SelectedItems(0).Tag
        frm.Clave_Precio = lsv_H_Servicios.SelectedItems(0).SubItems(2).Text
        frm.Id_PrecioDescripcion = lsv_H_Servicios.SelectedItems(0).SubItems(18).Text
        frm.cbx_Permitir.Visible = False
        frm.Clave_Cliente = tbx_Buscar.Text
        Me.Cursor = Cursors.Default

        frm.ShowDialog()

        lsv_HorariosPev.SelectedItems.Clear()
        lsv_HorariosActivos.SelectedItems.Clear()
        If lsv_H_Servicios.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarLista(lsv_H_Servicios.SelectedItems(0).Tag, lsv_HorariosPev)
            Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, IIf(chk_Horarios.Checked, True, False), lsv_HorariosActivos)
        Else
            lsv_HorariosPev.Items.Clear()
            lsv_HorariosActivos.Items.Clear()
        End If
    End Sub

    Private Sub chk_Horarios_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Horarios.CheckedChanged
        SegundosDesconexion = 0

        lsv_HorariosActivos.SelectedItems.Clear()
        lsv_HorariosActivos.Items.Clear()
        If lsv_H_Servicios.SelectedItems.Count > 0 Then
            Call fn_Horarios_LlenarListaActivos(lsv_H_Servicios.SelectedItems(0).Tag, IIf(chk_Horarios.Checked, True, False), lsv_HorariosActivos)
        End If
    End Sub

    Private Sub chk_ServiciosActivosH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ServiciosActivosH.CheckedChanged
        SegundosDesconexion = 0

        Call Horarios_Llenar()
    End Sub

#End Region

#Region "Transferencias"

    Private Sub TEF_Llenar()
        lsv_TEF.Items.Clear()
        If Not fn_Clientes_TEF(Id_Cliente, lsv_TEF) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de los Datos de Transferencias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        If gbx_DatosTEF.Enabled AndAlso lsv_TEF.Items.Count = 0 Then
            Call fn_ClientesAdmin_ActualizaPagaTEF(Id_Cliente, "N")
        End If
        btn_EliminarTEF.Enabled = False
    End Sub

    Private Sub TEF_Limpiar()
        cmb_Cuenta.SelectedValue = 0
        tbx_Referencia.Clear()
        tbx_Observaciones.Clear()
        btn_EliminarTEF.Enabled = False
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If cmb_Cuenta.SelectedValue = "0" Then
            MsgBox("Seleccione una Cuenta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cuenta.Focus()
            Exit Sub
        End If
        'revisar si la cuenta ya existe
        For Each elemento As ListViewItem In lsv_TEF.Items
            If CInt(elemento.Tag) = CInt(cmb_Cuenta.SelectedValue) Then
                MsgBox("La Cuenta ya existe para este Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Cuenta.Focus()
                Exit Sub
            End If
        Next

        If Not fn_TEF_Crear(Id_Cliente, cmb_Cuenta.SelectedValue, tbx_Referencia.Text, tbx_Observaciones.Text) Then
            MsgBox("Ocurrio un error al guardar las Transferencias Electrónicas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call TEF_Limpiar()
        Call TEF_Llenar()
    End Sub

    Private Sub lsv_TEF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_TEF.MouseUp
        btn_EliminarTEF.Enabled = lsv_TEF.SelectedItems.Count > 0
    End Sub

    Private Sub btn_EliminarTEF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminarTEF.Click

        If lsv_TEF.SelectedItems.Count > 0 Then
            If Not fn_TEF_Eliminar(lsv_TEF.SelectedItems(0).Tag, Id_Cliente) Then
                MsgBox("No se pudo eliminar ningun registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            btn_EliminarTEF.Enabled = False
            Call TEF_Llenar()
        End If
    End Sub

#End Region

#Region "Imprimir"

    'Private Sub btn_Contrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SegundosDesconexion = 0

    '    If Id_Cliente > 0 Then
    '        If Not cmb_Representante.SelectedValue = "0" Then
    '            Dim rpt As New rpt_Contrato
    '            Dim frm As New frm_Reporte
    '            Dim ds As New ds_Reporte
    '            Dim Arr As Array = fn_Imprimir_DatosEmpresa()
    '            If Not fn_Reportes_Encabezado(ds.Tbl_DatosEmpresa) Then
    '                MsgBox("Hubo un Error al Generar el Encabezado del Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
    '                Exit Sub
    '            End If

    '            rpt.SetDataSource(ds)
    '            rpt.SetParameterValue("Fecha", UCase(dtp_Fecha.Value.Day & " DE " & dtp_Fecha.Value.ToString("MMMM") & " DE " & dtp_Fecha.Value.Year))
    '            rpt.SetParameterValue("Contrato", UCase(tbx_Contrato.Text))
    '            rpt.SetParameterValue("Nombre Fiscal", UCase(tbx_NombreF.Text))
    '            rpt.SetParameterValue("Direccion Fiscal", UCase(tbx_CalleF.Text))
    '            rpt.SetParameterValue("Representante Cliente", UCase(cmb_Representante.Text))
    '            rpt.SetParameterValue("Inicio Vigencia", UCase(dtp_InicioV.Value.Day & " DE " & dtp_InicioV.Value.ToString("MMMM") & " DE " & dtp_InicioV.Value.Year))
    '            rpt.SetParameterValue("Fin Vigencia", UCase(dtp_FinV.Value.Day & " DE " & dtp_FinV.Value.ToString("MMMM") & " DE " & dtp_FinV.Value.Year))
    '            rpt.SetParameterValue("Dia Actual", UCase(dtp_Fecha.Value.Day))
    '            rpt.SetParameterValue("Mes Actual", UCase(dtp_Fecha.Value.ToString("MMMM")))
    '            rpt.SetParameterValue("Año Actual", UCase(dtp_Fecha.Value.Year))
    '            rpt.SetParameterValue("Empresa", UCase(Arr(2)))
    '            rpt.SetParameterValue("Representante Empresa", UCase(Arr(3)))

    '            frm.crv.ReportSource = rpt
    '            frm.WindowState = FormWindowState.Maximized
    '            frm.Show()
    '            'FuncionesGlobales.MostrarVentana(frm)
    '        Else
    '            MsgBox("Debe seleccionar un Representante Legal.", MsgBoxStyle.Information, frm_MENU.Text)
    '            cmb_Representante.Focus()
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information, frm_MENU.Text)
    '    End If
    'End Sub

    Private Sub btn_Servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0

        If Id_Cliente > 0 Then
            Dim Ds As New ds_Reporte

            'imprime servicios otros
            Call fn_Imprimir_LlenarServiciosOtros(Ds.tbl_ServiciosOtros, Id_Cliente)

            'imprime Servicios Tv
            Call fn_Imprimir_LlenarServiciosTV(Ds.tbl_ServiciosTV, Id_Cliente)

            'imprime Horario de Servicios de TV
            Call fn_Imprimir_LlenarHorarios(Ds.Tbl_Horarios, Id_Cliente)

            If Ds.tbl_ServiciosOtros.Rows.Count = 0 AndAlso _
            Ds.tbl_ServiciosTV.Rows.Count = 0 AndAlso _
            Ds.Tbl_Horarios.Rows.Count = 0 Then
                MsgBox("No existen servicios u horarios a imprimir. ", MsgBoxStyle.Exclamation, frm_MENU.Text)
                Exit Sub
            End If

            Dim frm As New frm_Reporte
            'Dim rpt As New rpt_Servicios
            Dim rpt As New rpt_Servicios

            frm.crv.ReportSource = rpt
            CType(rpt.Section2.ReportObjects("Txt_Cliente"), TextObject).Text = tbx_NombreC2.Text
            rpt.SetDataSource(Ds)
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            'FuncionesGlobales.MostrarVentana(frm)
        End If
    End Sub

#End Region

#Region "Precios"

    Private Sub Precios_Llenar()
        If Not fn_GeneraCarta_LlenarDs(Ds_Clientes.Tbl_CartaAumentoD, Id_Cliente) Then
            MsgBox("Ocurrio un error al tratar cargar la lista de Precios.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Precios_Limpiar()
        cmb_PS.SelectedValue = 0
        cmb_PDS.SelectedValue = 0
        cmb_CRS.SelectedValue = 0
        cmb_EES.SelectedValue = 0
        cmb_KMS.SelectedValue = 0
        chk_PN.Checked = False
        chk_CRN.Checked = False
        chk_EEN.Checked = False
        chk_kmn.Checked = False
        tbx_pd.Clear()
        tbx_crd.Clear()
        tbx_eed.Clear()
        tbx_kmd.Clear()
        tbx_pp.Clear()
        tbx_crp.Clear()
        tbx_eep.Clear()
        tbx_kmp.Clear()

        If dgv_Precios.Rows.Count > 0 Then
            fn_GeneraCarta_LlenarDs(Ds_Clientes.Tbl_CartaAumentoD, 0)
        Else
            Call Habilita_Deshabilita_CuotaEnvaseKm(False)
            cmb_CRS.SelectedValue = "0"
            cmb_KMS.SelectedValue = "0"
            cmb_EES.SelectedValue = "0"
        End If

    End Sub

    Private Sub tbx_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles tbx_pd.LostFocus, tbx_pp.LostFocus, tbx_crp.LostFocus, tbx_eep.LostFocus, tbx_kmp.LostFocus
        If Not sender.Text = "" Then
            Dim DT As DataTable
            Select Case sender.Name
                Case tbx_pd.Name
                    DT = cmb_PDS.DataSource
                    For Each element As DataRow In DT.Rows
                        If element("Descripcion") = sender.Text AndAlso Global.Microsoft.VisualBasic.MsgBox("Se ha encontrado un elemento con la descripción " & element("Descripcion") & ". ¿Desea elegir este elemento?", MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                            chk_NADS.Checked = False
                            cmb_PDS.SelectedValue = element("Id_PrecioDescripcion")
                            Exit Sub
                        End If
                    Next
                Case tbx_pp.Name
                    DT = cmb_PS.DataSource
                    For Each element As DataRow In DT.Rows
                        If element("Descripcion") <> "Seleccione..." AndAlso element("Descripcion") = CDbl(sender.Text) AndAlso Global.Microsoft.VisualBasic.MsgBox("Se ha encontrado un elemento con el precio " & FormatCurrency(element("Descripcion")) & ". ¿Desea elegir este elemento?", MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                            chk_NAPS.Checked = False
                            cmb_PS.SelectedValue = element("Id_Precio")
                            Exit Sub
                        End If
                    Next
                Case tbx_crp.Name
                    DT = cmb_CRS.DataSource
                    For Each element As DataRow In DT.Rows
                        If element("Precio") = CDbl(sender.Text) AndAlso Global.Microsoft.VisualBasic.MsgBox("Se ha encontrado un elemento con el precio " & FormatCurrency(element("Precio")) & ". ¿Desea elegir este elemento?", MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                            chk_CRN.Checked = False
                            cmb_CRS.SelectedValue = element("Id_CR")
                            Exit Sub
                        End If
                    Next
                Case tbx_eep.Name
                    DT = cmb_EES.DataSource
                    For Each element As DataRow In DT.Rows
                        If element("Precio") = CDbl(sender.Text) AndAlso Global.Microsoft.VisualBasic.MsgBox("Se ha encontrado un elemento con el precio " & FormatCurrency(element("Precio")) & ". ¿Desea elegir este elemento?", MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                            chk_EEN.Checked = False
                            cmb_EES.SelectedValue = element("Id_EE")
                            Exit Sub
                        End If
                    Next
                Case tbx_kmp.Name
                    DT = cmb_KMS.DataSource
                    For Each element As DataRow In DT.Rows
                        If element("Precio") = CDbl(sender.Text) AndAlso Global.Microsoft.VisualBasic.MsgBox("Se ha encontrado un elemento con el precio " & FormatCurrency(element("Precio")) & ". ¿Desea elegir este elemento?", MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                            chk_kmn.Checked = False
                            cmb_KMS.SelectedValue = element("Id_KM")
                            Exit Sub
                        End If
                    Next
            End Select
        End If
    End Sub

    Private Sub dgv_Precios_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Precios.SelectionChanged
        If dgv_Precios.SelectedCells.Count > 0 Then
            cmb_PS.ActualizaValorParametro("@Id_Linea", dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdLineaDataGridViewTextBoxColumn").Value)
            cmb_PS.Actualizar()
            cmb_PDS.ActualizaValorParametro("@Id_Linea", dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdLineaDataGridViewTextBoxColumn").Value)
            cmb_PDS.Actualizar()
            'cmb_CRS.ValorParametro = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCRDataGridViewTextBoxColumn").Value
            'cmb_CRS.Actualizar()
            'cmb_EES.ValorParametro = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdEEDataGridViewTextBoxColumn").Value
            'cmb_EES.Actualizar()
            'cmb_KMS.ValorParametro = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdKMDataGridViewTextBoxColumn").Value
            'cmb_KMS.Actualizar()

            If dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("Traslado").Value = "S" Then
                Call Habilita_Deshabilita_CuotaEnvaseKm(True)
            Else
                Call Habilita_Deshabilita_CuotaEnvaseKm(False)
                cmb_CRS.SelectedValue = "0"
                cmb_KMS.SelectedValue = "0"
                cmb_EES.SelectedValue = "0"
            End If

            cmb_PS.SelectedValue = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdPrecioDataGridViewTextBoxColumn").Value
            cmb_PDS.SelectedValue = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdPrecioDescripcionDataGridViewTextBoxColumn").Value
            cmb_CRS.SelectedValue = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCRDataGridViewTextBoxColumn").Value
            cmb_EES.SelectedValue = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdEEDataGridViewTextBoxColumn").Value
            cmb_KMS.SelectedValue = dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdKMDataGridViewTextBoxColumn").Value
            dgv_Precios.Columns(0).Visible = False

            tbx_crd.Enabled = False
            tbx_crp.Enabled = False
            tbx_kmd.Enabled = False
            tbx_kmp.Enabled = False
            tbx_eed.Enabled = False
            tbx_eep.Enabled = False

            If cmb_CRS.SelectedValue = 0 Then
                chk_CRN.Enabled = False
                cmb_CRS.Enabled = False
                btn_CRG.Enabled = False
            Else
                chk_CRN.Enabled = True
                cmb_CRS.Enabled = True
                'tbx_crd.Enabled = True
                'tbx_crp.Enabled = True
                btn_CRG.Enabled = True
            End If

            If cmb_KMS.SelectedValue = 0 Then
                chk_kmn.Enabled = False
                cmb_KMS.Enabled = False
                btn_KMG.Enabled = False
            Else
                chk_kmn.Enabled = True
                cmb_KMS.Enabled = True
                'tbx_kmd.Enabled = true
                'tbx_kmp.Enabled = true
                btn_KMG.Enabled = True
            End If

            If cmb_EES.SelectedValue = 0 Then
                chk_EEN.Enabled = False
                cmb_EES.Enabled = False
                btn_EEG.Enabled = False
            Else
                chk_EEN.Enabled = True
                cmb_EES.Enabled = True
                'tbx_eed.Enabled = True
                'tbx_eep.Enabled = True
                btn_EEG.Enabled = True
            End If

        End If
    End Sub

    Private Sub Habilita_Deshabilita_CuotaEnvaseKm(ByVal Habilita As Boolean)
        chk_CRN.Checked = False
        chk_EEN.Checked = False
        chk_kmn.Checked = False

        cmb_CRS.Enabled = Habilita
        chk_CRN.Enabled = Habilita
        tbx_crd.Enabled = Habilita
        tbx_crp.Enabled = Habilita
        btn_CRG.Enabled = Habilita

        cmb_EES.Enabled = Habilita
        chk_EEN.Enabled = Habilita
        tbx_eed.Enabled = Habilita
        tbx_eep.Enabled = Habilita
        btn_EEG.Enabled = Habilita

        cmb_KMS.Enabled = Habilita
        chk_kmn.Enabled = Habilita
        tbx_kmd.Enabled = Habilita
        tbx_kmp.Enabled = Habilita
        btn_KMG.Enabled = Habilita

    End Sub

    Private Sub CheckedChanged(ByVal sender As CheckBox, ByVal e As System.EventArgs) Handles chk_PN.CheckedChanged, chk_CRN.CheckedChanged, chk_EEN.CheckedChanged, chk_kmn.CheckedChanged
        Select Case sender.Name
            Case chk_PN.Name
                chk_NADS.Checked = False
                chk_NAPS.Checked = False
                chk_NADS.Enabled = sender.Checked
                chk_NAPS.Enabled = sender.Checked
                cmb_PDS.SelectedValue = 0
                cmb_PS.SelectedValue = 0

                If cmb_PDS.SelectedValue <> 0 Then
                    tbx_pd.Text = cmb_PDS.Text
                    tbx_pd.Text = Microsoft.VisualBasic.Right(tbx_pd.Text, tbx_pd.Text.Length - InStr(tbx_pd.Text, "    "))
                    tbx_pd.Text = tbx_pd.Text.Trim
                    If cmb_PDS.Enabled Then
                        tbx_pd.Clear()
                    End If
                Else
                    tbx_pd.Text = ""
                End If

            Case chk_CRN.Name
                'If sender.Checked Then cmb_CRS.SelectedValue = "0"
                If Not sender.Checked Then tbx_crd.Clear()
                If Not sender.Checked Then tbx_crp.Clear()

                If cmb_CRS.SelectedValue = "0" Then
                    MsgBox("seleccione una Cuota de Riesgo de la lista desplegable.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_CRS.Focus()
                    Exit Sub
                End If

                cmb_CRS.Enabled = Not sender.Checked
                tbx_crd.Enabled = sender.Checked
                tbx_crp.Enabled = sender.Checked
                

                If cmb_CRS.SelectedValue <> 0 Then
                    tbx_crd.Text = cmb_CRS.Text
                    tbx_crd.Text = Microsoft.VisualBasic.Right(tbx_crd.Text, tbx_crd.Text.Length - InStr(tbx_crd.Text, "    "))
                    tbx_crd.Text = tbx_crd.Text.Trim
                    If cmb_CRS.Enabled Then
                        tbx_crd.Clear()
                        tbx_crp.Clear()
                    End If
                Else
                    tbx_crd.Text = ""
                    tbx_crp.Text = ""
                End If

            Case chk_EEN.Name
                'If sender.Checked Then cmb_EES.SelectedValue = "0"
                If Not sender.Checked Then tbx_eed.Clear()
                If Not sender.Checked Then tbx_eep.Clear()

                If cmb_EES.SelectedValue = "0" Then
                    MsgBox("seleccione un precio de Envases en Exceso de la lista desplegable.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_EES.Focus()
                    Exit Sub
                End If
                cmb_EES.Enabled = Not sender.Checked
                tbx_eed.Enabled = sender.Checked
                tbx_eep.Enabled = sender.Checked

                If cmb_EES.SelectedValue <> 0 Then
                    tbx_eed.Text = cmb_EES.Text
                    tbx_eed.Text = Microsoft.VisualBasic.Right(tbx_eed.Text, tbx_eed.Text.Length - InStr(tbx_eed.Text, "    "))
                    tbx_eed.Text = tbx_eed.Text.Trim
                    If cmb_CRS.Enabled Then
                        tbx_eed.Clear()
                        tbx_eep.Clear()
                    End If
                Else
                    tbx_eed.Text = ""
                    tbx_eep.Text = ""
                End If

            Case chk_kmn.Name
                'If sender.Checked Then cmb_KMS.SelectedValue = "0"
                If Not sender.Checked Then tbx_kmd.Clear()
                If Not sender.Checked Then tbx_kmp.Clear()

                If cmb_KMS.SelectedValue = "0" Then
                    MsgBox("seleccione un precio de Kilometraje de la lista desplegable.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_KMS.Focus()
                    Exit Sub
                End If

                cmb_KMS.Enabled = Not sender.Checked
                tbx_kmd.Enabled = sender.Checked
                tbx_kmp.Enabled = sender.Checked

                If cmb_KMS.SelectedValue <> 0 Then tbx_kmd.Text = cmb_KMS.Text
                If cmb_KMS.SelectedValue <> 0 Then
                    tbx_kmd.Text = cmb_KMS.Text
                    tbx_kmd.Text = Microsoft.VisualBasic.Right(tbx_kmd.Text, tbx_kmd.Text.Length - InStr(tbx_kmd.Text, "    "))
                    tbx_kmd.Text = tbx_kmd.Text.Trim
                    If cmb_KMS.Enabled Then
                        tbx_kmd.Clear()
                        tbx_kmp.Clear()
                    End If
                Else
                    tbx_kmd.Text = ""
                    tbx_kmp.Text = ""
                End If
        End Select
    End Sub

    Private Sub btn_Click(ByVal sender As Button, ByVal e As System.EventArgs) Handles btn_PG.Click, btn_CRG.Click, btn_EEG.Click, btn_KMG.Click
        SegundosDesconexion = 0

        Dim Cambiado As Boolean
        Select Case sender.Name
            Case btn_PG.Name
                If Not Precios_ValidarDatos(chk_PN, tbx_pd, tbx_pp, cmb_PS, cmb_PDS) Then Exit Sub

                If chk_PN.Checked Then
                    'Crear Nuevo
                    If chk_NADS.Checked AndAlso chk_NAPS.Checked Then
                        'Se genera uno nuevo con los valores agregados en los Textbox
                        Cambiado = fn_PreciosDescripcion_ActualizarNuevo(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdPrecioDescripcionDataGridViewTextBoxColumn").Value, dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdPrecioDataGridViewTextBoxColumn").Value, tbx_pd.Text.Trim, CDec(tbx_pp.Text.Trim), dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value)

                    ElseIf chk_NADS.Checked AndAlso Not chk_NAPS.Checked Then
                        'Se genera uno nuevo con sólo Descripción pero en Precios no.
                        Cambiado = fn_Precios_ActualizarNuevo(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdPrecioDescripcionDataGridViewTextBoxColumn").Value, TipoPrecio.Descripcion, tbx_pd.Text, cmb_PS.Text, dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value)

                    ElseIf Not chk_NADS.Checked AndAlso chk_NAPS.Checked Then
                        'Se genera uno nuevo con sólo Precio pero en Descripción no.
                        Cambiado = fn_Precios_ActualizarNuevo(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdPrecioDataGridViewTextBoxColumn").Value, TipoPrecio.Precio, cmb_PDS.Text, tbx_pp.Text, dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value)

                    ElseIf Not chk_NADS.Checked AndAlso Not chk_NAPS.Checked Then
                        'Actua igual que Actualizar directamente sin generar registro nuevo en Descripción y Precio.
                        Cambiado = fn_Precios_ActualizarSugerido(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value, cmb_PS.SelectedValue, , , , cmb_PDS.SelectedValue, )

                    End If
                Else
                    'Se Actualizará uno existente (cuando no se marca la casilla de Nuevo).
                    Cambiado = fn_Precios_ActualizarSugerido(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value, cmb_PS.SelectedValue, , , , cmb_PDS.SelectedValue, )
                End If

            Case btn_CRG.Name
                If Not Precios_ValidarDatos(chk_CRN, tbx_crd, tbx_crp, cmb_CRS) Then Exit Sub

                If chk_CRN.Checked Then
                    Cambiado = fn_Precios_ActualizarNuevo(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCRDataGridViewTextBoxColumn").Value, TipoPrecio.CR, tbx_crd.Text, tbx_crp.Text, dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value)
                Else
                    Cambiado = fn_Precios_ActualizarSugerido(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value, , cmb_CRS.SelectedValue)
                End If

            Case btn_EEG.Name
                If Not Precios_ValidarDatos(chk_EEN, tbx_eed, tbx_eep, cmb_EES) Then Exit Sub

                If chk_EEN.Checked Then
                    Cambiado = fn_Precios_ActualizarNuevo(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdEEDataGridViewTextBoxColumn").Value, TipoPrecio.EE, tbx_eed.Text, tbx_eep.Text, dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value)
                Else
                    Cambiado = fn_Precios_ActualizarSugerido(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value, , , cmb_EES.SelectedValue)
                End If

            Case btn_KMG.Name
                If Not Precios_ValidarDatos(chk_kmn, tbx_kmd, tbx_kmp, cmb_KMS) Then Exit Sub

                If chk_kmn.Checked Then
                    Cambiado = fn_Precios_ActualizarNuevo(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdKMDataGridViewTextBoxColumn").Value, TipoPrecio.KM, tbx_kmd.Text, tbx_kmp.Text, dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value)
                Else
                    Cambiado = fn_Precios_ActualizarSugerido(dgv_Precios.Rows(dgv_Precios.SelectedCells(0).RowIndex).Cells("IdCSDataGridViewTextBoxColumn").Value, , , , cmb_KMS.SelectedValue)
                End If
        End Select

        If Cambiado Then
            Call Precios_Llenar()
            Call ServiciosTV_Llenar()
            Call ServiciosOtros_Llenar()
            Select Case sender.Name
                Case btn_PG.Name
                    chk_PN.Checked = False
                Case btn_CRG.Name
                    chk_CRN.Checked = False
                Case btn_EEG.Name
                    chk_EEN.Checked = False
                Case btn_KMG.Name
                    chk_kmn.Checked = False
            End Select
        Else
            MsgBox("No se pudo realizar el cambio.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Function Precios_ValidarDatos(ByVal chk As CheckBox, ByVal tbx_Desc As TextBox, ByVal tbx_Prec As TextBox, ByVal cmb_Prec As ComboBox, Optional ByVal cmb_Desc As ComboBox = Nothing) As Boolean
        'El cmb_Desc significa que se validará cuando sean 2 combos sino es un sólo combo (es lo que se utiliza normalmente).
        If cmb_Desc IsNot Nothing Then
            If chk.Checked Then
                'Validar cuando es Nuevo Registro.
                If cmb_Desc.Enabled AndAlso cmb_Desc.SelectedValue = 0 Then
                    'Validar cuando sea un registro nuevo, si esta activo el combo de Descripción tenga un valor seleccionado.
                    MsgBox("Debe seleccionar una Descripción Sugerida.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Desc.Focus()
                    Return False

                ElseIf cmb_Prec.Enabled AndAlso cmb_Prec.SelectedValue = 0 Then
                    'Validar cuando sea un registro nuevo, si esta activo el combo de Precio tenga un valor seleccionado.
                    MsgBox("Debe seleccionar un Precio Sugerido.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Prec.Focus()
                    Return False

                ElseIf Not cmb_Desc.Enabled AndAlso tbx_Desc.Text = "" Then
                    'Validar cuando sea un registro nuevo, y no este activo el combo de Descripción tenga un valor el Textbox de Descripción.
                    MsgBox("Debe de capturar una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Desc.Focus()
                    Return False

                ElseIf Not cmb_Prec.Enabled AndAlso tbx_Prec.Text = "" Then
                    'Validar cuando sea un registro nuevo, y no este activo el combo de Precio tenga un valor el Textbox de Precio.
                    MsgBox("Debe de capturar un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Prec.Focus()
                    Return False
                End If

            Else
                'Validar para cuando se modifique un valor
                If cmb_Desc.SelectedValue = 0 Then
                    MsgBox("Debe seleccionar una Descripción Sugerida.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Desc.Focus()
                    Return False

                ElseIf cmb_Prec.SelectedValue = 0 Then
                    MsgBox("Debe seleccionar un Precio Sugerido.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Prec.Focus()
                    Return False
                End If
            End If
        Else
            If chk.Checked AndAlso cmb_Prec.SelectedValue <> "0" Then
                'Validar cuando es Nuevo Registro.
                If tbx_Desc.Text = "" Then
                    MsgBox("Debe de capturar una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Desc.Focus()
                    Return False

                ElseIf tbx_Prec.Text = "" Then
                    MsgBox("Debe de capturar un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Prec.Focus()
                    Return False
                End If

            ElseIf cmb_Prec.SelectedValue = 0 Then
                'Validar para cuando se modifique un valor del Combo.
                MsgBox("Debe seleccionar un Valor Sugerido.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Prec.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub chk_NoAplica_DesPre_CheckedChanged(ByVal sender As CheckBox, ByVal e As System.EventArgs) Handles chk_NADS.CheckedChanged, chk_NAPS.CheckedChanged
        SegundosDesconexion = 0

        Select Case sender.Name
            Case chk_NADS.Name
                cmb_PDS.SelectedValue = 0
                tbx_pd.Clear()
                cmb_PDS.Enabled = Not sender.Checked
                tbx_pd.Enabled = sender.Checked

            Case chk_NAPS.Name
                cmb_PS.SelectedValue = 0
                tbx_pp.Clear()
                cmb_PS.Enabled = Not sender.Checked
                tbx_pp.Enabled = sender.Checked
        End Select
    End Sub

#End Region

#Region "Documentos Recibidos"

    Sub DoctosRecibidos_Llenar()
        lsv_DocDetalle.Items.Clear()
        If Not fn_DoctoRequeridosCliente_LlenarLista(lsv_DocDetalle, Id_Cliente) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Documentos Recibidos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_DoctosImportar.Enabled = lsv_DocDetalle.Items.Count > 0
    End Sub

    Private Sub btn_DoctosImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DoctosImportar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.MaxArchivos = 10
        frm.Id_Tabla = Id_Cliente
        frm.Tipo = frm_CargarArchivos.Query.DoctosRequeridosCliente
        frm.Filtro = "Documento de Word 97-2003 (*.doc)|*.doc|Documento de Word (*.docx)|*.xdoc|Documento de Excel 97-2003 (*.xls)|*.xls|Documento de Excel (*.xlsx)|*.xlsx|Documento de Powerpoint 97-2003 (*.ppt)|*.ppt|Documento de Powerpoint (*.pptx)|*.pptx|Archivo PDF(*.pdf)|*.pdf|Imagenes (*.jpg)|*.jpg"
        frm.ShowDialog()

        Call DoctosRecibidos_Llenar()
    End Sub

#End Region

#Region "Subclientes"

    Sub Subclientes_Llenar()
        lsv_SubClientes.Items.Clear()
        If cmb_StatusSubCli.SelectedValue = "0" OrElse Id_Cliente = 0 Then Exit Sub
        If Not fn_SubCliente_LlenarLista(1, Id_Cliente, cmb_StatusSubCli.SelectedValue, False, lsv_SubClientes) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de Subclientes.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        If lsv_SubClientes.Items.Count = 1 Then
            lbl_Subclientes.Text = lsv_SubClientes.Items.Count.ToString & " Subcliente"
        Else
            lbl_Subclientes.Text = lsv_SubClientes.Items.Count.ToString & " Subclientes"
        End If
        btn_Exportar.Enabled = lsv_SubClientes.Items.Count > 0
        chk_ClienteP.Enabled = lsv_SubClientes.Items.Count = 0
    End Sub

    Private Sub cmb_StatusSubCli_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_StatusSubCli.SelectedValueChanged
        SegundosDesconexion = 0
        Call Subclientes_Llenar()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_SubClientes, 2, Me.Text & " " & tab_Subclientes.Name, 0, 2, frm_MENU.prg_Barra)
    End Sub

#End Region

#Region "Fotografías"

    Sub Fotos_Llenar()
        lsv_Fotografias.Items.Clear()
        If Not fn_ClienteFotografias_LlenarLista(lsv_Fotografias, Id_Cliente) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Fotografías.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_FotografiasImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FotografiasImportar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.MaxArchivos = 6
        frm.Id_Tabla = Id_Cliente
        frm.Tipo = frm_CargarArchivos.Query.ClientesFotografias
        frm.Filtro = "Imagenes (*.jpg)|*.jpg"
        frm.ShowDialog()

        Call Fotos_Llenar()
    End Sub

#End Region

#Region "Observaciones"

    Private Sub Observaciones_Llenar()
        rtb_ObservacionesExtra.Clear()
        Dim Dr_ObservacionesExtra As DataRow = fn_ClienteObservaciones_Texto(Id_Cliente)
        If Dr_ObservacionesExtra IsNot Nothing Then
            rtb_ObservacionesExtra.Text = Dr_ObservacionesExtra("Observaciones")
            rtb_ObservacionesExtra.Tag = Dr_ObservacionesExtra("Id_Cliente")
        End If
    End Sub

    Private Function Validar_Observaciones() As Boolean
        If rtb_ObservacionesExtra.TextLength < 10 Then
            MsgBox("Debe escribir una Observación más completa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub rtb_ObservacionesExtra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_ObservacionesExtra.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

#Region "Contratos"

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        SegundosDesconexion = 0
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = False
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "ACTIVO" Then
                Dim Frm1 As New frm_Contratos
                Frm1.Renovar = False
                Frm1.Nuevo = False
                Frm1.Id_Cliente = Id_Cliente
                Frm1.Id_Contrato = Lsv_Contratos.SelectedItems(0).Tag
                Frm1.ShowDialog()
                Call LlenarListaContratos()
            Else
                MsgBox("No se Puede Modificar un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Valida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Valida.Click
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "ACTIVO" Then
                If fn_Contratos_NumClausulas(Lsv_Contratos.SelectedItems(0).Tag) = False Then
                    MsgBox("Ocurrio un Error o El Contrato Seleccionado no Tiene Clausulas", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "V") = False Then
                    MsgBox("Error al Cambiar el Status", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                MsgBox("No se Puede Validar un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Call LlenarListaContratos()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "ACTIVO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "C") = False Then
                    MsgBox("Error al Cambiar el Status", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                MsgBox("No se Puede Cancelar un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Call LlenarListaContratos()
        End If
    End Sub

    Private Sub btn_Terminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Terminar.Click
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "VALIDADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "F") = False Then
                    MsgBox("Error al Cambiar el Status", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                MsgBox("No se Puede Terminar un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Call LlenarListaContratos()
        End If
    End Sub

    Private Sub btn_CBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CBaja.Click
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "VALIDADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "B") = False Then
                    MsgBox("Error al Cambiar el Status", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                MsgBox("No se Puede Dar de Baja un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Call LlenarListaContratos()
        End If
    End Sub

    Private Sub btn_CRenovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CRenovar.Click
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True

        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "VALIDADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "R") = False Then
                    MsgBox("Error al Cambiar el Status", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                Dim Frm1 As New frm_Contratos
                Frm1.Nuevo = True
                Frm1.Renovar = True
                Frm1.Numero_Contrato = Lsv_Contratos.SelectedItems(0).SubItems(0).Text
                Frm1.Id_Contrato = Lsv_Contratos.SelectedItems(0).Tag
                Frm1.Id_Cliente = Id_Cliente
                Frm1.ShowDialog()
                Call LlenarListaContratos()
            Else
                MsgBox("No se Puede Renovar un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Call LlenarListaContratos()
        End If
    End Sub

    Private Sub btn_Contrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Contrato.Click

        Dim Rpt As New rpt_Contrato
        Dim Frm As New frm_Reporte
        Dim Ds As New ds_Reporte

        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Debe Seleccionar Un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not fn_Reportes_Encabezado(Ds.Tbl_DatosEmpresa) Then
            MsgBox("Hubo un Error al Generar el Encabezado del Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If fn_Contrato_Reporte(Lsv_Contratos.SelectedItems(0).Tag, Ds.tbl_Contratos) = False Then
            MsgBox("Error al Cargar las Clausulas del Contrato", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Ds.tbl_Contratos.Rows.Count = 0 Then
            MsgBox("No se Puede Mostrar un Contrato sin Clausulas", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Rpt.SetDataSource(Ds)
        Frm.crv.ReportSource = Rpt
        Frm.WindowState = FormWindowState.Maximized
        Frm.Show()

    End Sub

    Private Sub LlenarListaContratos()
        If fn_Contratos_LlenarContratos(Lsv_Contratos, Id_Cliente) = False Then
            MsgBox("Error al Cargar los Contratos", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub btn_Deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deshacer.Click
        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "VALIDADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "A") = False Then
                    MsgBox("Error al Deshacer", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

            ElseIf Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "CANCELADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "A") = False Then
                    MsgBox("Error al Deshacer", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

            ElseIf Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "BAJA" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "V") = False Then
                    MsgBox("Error al Deshacer", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

            ElseIf Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "RENOVADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "V") = False Then
                    MsgBox("Error al Deshacer", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

            ElseIf Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "FINALIZADO" Then
                If fn_Contratos_Status(Lsv_Contratos.SelectedItems(0).Tag, Frm.Observaciones, "V") = False Then
                    MsgBox("Error al Deshacer", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            End If
            Call LlenarListaContratos()
        End If
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click

        If Lsv_Contratos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = True
        Frm.ShowDialog()

        If Frm.Firma = True Then
            If Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "ACTIVO" Or Lsv_Contratos.SelectedItems(0).SubItems(5).Text = "CANCELADO" Then
                If fn_Contratos_DeleteContrato(Lsv_Contratos.SelectedItems(0).Tag) = False Then
                    MsgBox("Error al Eliminar el Contrato", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                MsgBox("No se Puede Eliminar un Registro en el Status " & Lsv_Contratos.SelectedItems(0).SubItems(5).Text, MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Call LlenarListaContratos()
        End If
    End Sub
#End Region

    Private Sub cmb_estadoContactos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_estadoContactos.SelectedValueChanged
        If cmb_estadoContactos.Items.Count = 0 Then Exit Sub
        cmb_CiudadContactos.ActualizaValorParametro("@Id_Estado", cmb_estadoContactos.SelectedValue)
        cmb_CiudadContactos.Actualizar()
    End Sub

    Private Sub lsv_TEF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_TEF.SelectedIndexChanged
        btn_EliminarTEF.Enabled = lsv_TEF.SelectedItems.Count > 0
    End Sub

    Private Sub cmb_CuotaR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CuotaR.SelectedIndexChanged
        tbx_CobraDoctos.Text = ""
        tbx_Redondeado.Text = ""
        tbx_milesSCosto.Text = ""
        If cmb_CuotaR.SelectedValue Is Nothing Then Exit Sub

        If cmb_CuotaR.SelectedValue > 0 Then

            Dim dt_milesScosto As DataTable = LlenarMilesSCosto_Dt(cmb_CuotaR.SelectedValue)
            If dt_milesScosto Is Nothing Then
                MsgBox("ocurrió un error al cargar los datos de la Cuota de Riesgo.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If dt_milesScosto.Rows.Count > 0 Then
                tbx_CobraDoctos.Text = dt_milesScosto.Rows(0)("CobraDocumentos")
                tbx_Redondeado.Text = dt_milesScosto.Rows(0)("Redondeado")
                tbx_milesSCosto.Text = dt_milesScosto.Rows(0)("MilesScosto")
            End If
        End If
    End Sub
    

End Class
