Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_ClientesBaja

    Private Dt_Clientes As New DataTable
    Private Id_Clientes As String = ""

#Region "Eventos Manejados"

    Private Sub frm_ClientesBaja_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Arreglo_Archivo = Nothing
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCliente.Click
        SegundosDesconexion = 0

        Frm_BuscarCliente.ShowDialog()
        tbx_Cliente.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub frm_ClientesBaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Cliente.Actualizar()
        cmb_Motivo.Actualizar()

        If Not fn_Materiales_LlenarLista(-1, lsv_Materiales) Then MsgBox("No se pudo actualizar la tabla materiales", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Boveda_LlenarLista(-1, lsv_Boveda) Then MsgBox("No se pudo actualizar la tabla Boveda", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Saldo_LlenarLista(-1, lsv_Saldo) Then MsgBox("No se pudo actualizar la tabla Saldo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Proceso_LlenarLista(-1, lsv_Proceso) Then MsgBox("No se pudo actualizar la tabla Proceso", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Traslado_LlenarLista(-1, lsv_Traslado) Then MsgBox("No se pudo actualizar la tabla Traslado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)

        lbl_Alerta.Tag = ""
        lbl_Alerta.Text = ""
        Dt_Clientes.Columns.Add("Id_Cliente")
        Dt_Clientes.Columns.Add("Clave Cliente")
        Dt_Clientes.Columns.Add("Nombre Comercial")
        Dt_Clientes.Columns.Add("Status")
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        Call Limpiar()
        Call LimpiarPestañaDatos()
        If cmb_Cliente.SelectedValue = 0 Then
            lsv_Materiales.Items.Clear()
            lsv_Boveda.Items.Clear()
            lsv_Saldo.Items.Clear()
            lsv_Proceso.Items.Clear()
            lsv_Traslado.Items.Clear()
            Exit Sub
        End If

        Dim Arr As DataRow = fn_Clientes_Generales(cmb_Cliente.SelectedValue)

        Dim DirF As String = ""
        Dim DirC As String = ""

        If Not Arr Is Nothing Then
            If Arr("NumeroInt_Fiscal") = "" Then
                DirF = Arr("Calle_Fiscal") & " " & Arr("Numero_Fiscal") & ", " & Arr("Colonia_Fiscal")
            Else
                DirF = Arr("Calle_Fiscal") & " " & Arr("Numero_Fiscal") & " Int " & Arr("NumeroInt_Fiscal") & ", " & Arr("Colonia_Fiscal")
            End If
            If Arr("NumeroInt_Comercial") = "" Then
                DirC = Arr("Calle_Comercial") & " " & Arr("Numero_Comercial") & ", " & Arr("Colonia_Comercial") & ", " & Arr("CiudadComercial")
            Else
                DirC = Arr("Calle_Comercial") & " " & Arr("Numero_Comercial") & " Int " & Arr("NumeroInt_Comercial") & ", " & Arr("Colonia_Comercial") & ", " & Arr("CiudadComercial")
            End If
            tbx_NombreF.Text = Arr("Nombre_Fiscal")
            tbx_DireccionF.Text = DirF
            tbx_RFC.Text = Arr("RFC")
            tbx_DireccionC.Text = DirC
            tbx_CiudadF.Text = Arr("CiudadFiscal")
            Select Case Arr("Tipo_Cliente")
                Case "1"
                    tbx_TipoCliente.Text = "TRASLADO"
                Case "2"
                    tbx_TipoCliente.Text = "SEGURIDAD PATRIMONIAL"
                Case "3"
                    tbx_TipoCliente.Text = "TRASLADO Y SEG. PATRIMONIAL"
                Case "4"
                    tbx_TipoCliente.Text = "CAJA BANCARIA"
                Case "5"
                    tbx_TipoCliente.Text = "OTRO"
                Case Else
                    tbx_TipoCliente.Text = "NO ESPECIFICADO"
            End Select

            Dim dt_ClientesConCaja As DataTable = fn_ClientesCajaFuerte_Cantidad(cmb_Cliente.SelectedValue)
            If dt_ClientesConCaja IsNot Nothing AndAlso dt_ClientesConCaja.Rows.Count > 0 Then
                lbl_Alerta.Text = "El Cliente tiene en Renta, Proceso de Renta o Pendiente de Retiro de Cajas Fuertes"
                lbl_Alerta.Tag = lbl_Alerta.Text
                lbl_Alerta.Visible = True
                btn_Mostrar.Visible = True
            End If

            If Arr("Status") = "A" Then
                Id_Clientes &= cmb_Cliente.SelectedValue & ","
                Dt_Clientes.Rows.Add(cmb_Cliente.SelectedValue, Arr("Clave_Cliente"), Arr("Nombre_Comercial"), "ACTIVO")
            ElseIf Arr("Status") = "B" AndAlso Arr("Baja_Permanente") = "N" Then
                'Se puede modificar una baja a un cliente dado de baja pero ahorita el combo se llena con sólo clientes activos
                Id_Clientes &= cmb_Cliente.SelectedValue & ","
                Dt_Clientes.Rows.Add(cmb_Cliente.SelectedValue, Arr("Clave_Cliente"), Arr("Nombre_Comercial"), "BAJA")
            ElseIf Arr("Status") = "B" AndAlso Arr("Baja_Permanente") = "S" Then
                'Son las Bajas Permanentes y estas no se puede volver a generar otra baja.
                'Dt_Clientes.Rows.Add(cmb_Cliente.SelectedValue, Arr("Clave_Cliente"), Arr("Nombre_Comercial"), "BAJA PERMANENTE")
            End If
        End If
        'Llenar los grupbox de la pestaña PENDIENTES

        If Not fn_Materiales_LlenarLista(cmb_Cliente.SelectedValue, lsv_Materiales) Then MsgBox("Ocurrió un error al intentar consultar los Materiales Pendientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Boveda_LlenarLista(cmb_Cliente.SelectedValue, lsv_Boveda) Then MsgBox("Ocurrió un error al intentar consultar los Servicios en Bóveda Pendientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Saldo_LlenarLista(cmb_Cliente.SelectedValue, lsv_Saldo) Then MsgBox("No se pudo actualizar la tabla Saldo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Proceso_LlenarLista(cmb_Cliente.SelectedValue, lsv_Proceso) Then MsgBox("Ocurrió un error al intentar consultar los Servicios en Proceso Pendientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        If Not fn_Traslado_LlenarLista(cmb_Cliente.SelectedValue, lsv_Traslado) Then MsgBox("Ocurrió un error al intentar consultar los Servicios en Traslado Pendientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)

    End Sub

    Private Sub dtp_Fecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fecha.KeyPress
        If Asc(e.KeyChar) = 13 Then chk_BajaPermanente.Focus()
    End Sub

    Private Sub chk_BajaPermanente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_BajaPermanente.KeyPress
        If Asc(e.KeyChar) = 13 Then cmb_Motivo.Focus()
    End Sub

    Private Sub tbx_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Observaciones.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If btn_AgregarArchivo.Enabled Then
                btn_AgregarArchivo.Focus()
            Else
                Btn_Baja.Focus()
            End If
        End If
    End Sub

    Private Sub btn_AgregarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarArchivo.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.Tipo = frm_CargarArchivos.Query.ClientesBajas
        frm.Filtro = "Documento de Word 97-2003 (*.doc)|*.doc|Documento de Word (*.docx)|*.xdoc|Archivo PDF(*.pdf)|*.pdf"
        frm.MaxArchivos = 1
        frm.Id_Tabla = cmb_Cliente.SelectedValue
        frm.ShowDialog()

        If Arreglo_Archivo IsNot Nothing Then
            tbx_Archivo.Text = "NOMBRE: " & Arreglo_Archivo(0).Nombre_Archivo & "  DESCRIPCION: " & Arreglo_Archivo(0).Descripcion_Archivo
        End If
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0

        If Validar() Then
            Dim Renta As Boolean = False
            Dim Hijos As String = "."

            If btn_Mostrar.Visible Then
                'Significa que el cliente y/o sucursales tienen cajas fuertes rentadas o en proceso de renta o pendiente de retiro
                If dtp_Fecha.Value.Date > Now.Date Then
                    If MsgBox(lbl_Alerta.Text & "." & Chr(13) & "¿Desea continuar con la baja del Cliente y/o Sucursales?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                        Renta = True
                        If chk_Clientes.Checked Then Hijos = " y sus Sucursales."
                    Else
                        Exit Sub
                    End If
                Else
                    MsgBox(lbl_Alerta.Text & "." & Chr(13) & "Se deben Retirar antes de dar de Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            End If

            Dim FRM As New frm_FirmaElectronica
            FRM.Bloquear = True
            FRM.PedirObservaciones = False
            FRM.ShowDialog()
            If FRM.Firma = True Then

                'Baja del Cliente y/o Sucursales
                Dim Baja_Permanente As String = "N"
                If chk_BajaPermanente.Checked Then Baja_Permanente = "S"

                If Not fn_ClientesBaja_Crear(cmb_Cliente.SelectedValue, cmb_Motivo.SelectedValue, tbx_Observaciones.Text.Trim, dtp_Fecha.Value.Date, tbx_Contacto.Text.Trim, tbx_Cargo.Text.Trim, tbx_ListaNegra.Text.Trim, cmb_Cliente.Text.Trim, Baja_Permanente, Dt_Clientes) Then
                    MsgBox("No se pudo registrar la Baja.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                    Exit Sub
                End If

                Dim Detalle As String = ""

                Dim DetalleHTML As String = ""
                Dim Pie As String = "Agente de Servicios SIAC " & Today.Year.ToString
                Dim PieHTMTL As String = "Agente de Servicios SIAC " & Today.Year.ToString
                If Renta Then
                    Pie = lbl_Alerta.Text & " y debe Retirarla antes de la Fecha Marcada." & Chr(13) & Chr(13) _
                          & "Agente de Servicios SIAC " & Today.Year.ToString
                    PieHTMTL = lbl_Alerta.Text & " y debe Retirarla antes de la Fecha Marcada." _
                               & "<BR>Agente de Servicios SIAC " & Today.Year.ToString
                End If

                Dim Baja_ClientePadre As Boolean = False
                If chk_Clientes.Checked Then
                    For Each Row As DataRow In Dt_Clientes.Rows
                        If Row("Id_Cliente") = cmb_Cliente.SelectedValue Then
                            Baja_ClientePadre = True
                            Row.Delete()
                            Exit For
                        End If
                    Next
                Else
                    Baja_ClientePadre = True
                End If

                If Baja_ClientePadre Then
                    'Enviar Mensaje de Baja de Cliente mostrando una leyenda de que el cliente contenía una caja fuerte rentada
                    Detalle = "Por medio del presente se le Informa de la Baja del Cliente" & Hijos & Chr(13) _
                             & "con los siguientes datos a partir de la fecha señalada:" & Chr(13) & Chr(13) _
                             & "          Sucursal: " & SucursalN & Chr(13) _
                             & "           Cliente: " & tbx_Cliente.Text & " - " & cmb_Cliente.Text.ToUpper & Chr(13) _
                             & "   Tipo de Cliente: " & tbx_TipoCliente.Text & Chr(13) _
                             & "        Fecha Baja: " & dtp_Fecha.Value.Date.ToShortDateString & Chr(13) _
                             & "  Usuario Registro: " & UsuarioN & Chr(13) _
                             & "            Motivo: " & cmb_Motivo.Text & Chr(13) _
                             & "          Contacto: " & tbx_Contacto.Text & Chr(13) _
                             & "             Cargo: " & tbx_Cargo.Text & Chr(13) _
                             & "     Observaciones: " & tbx_Observaciones.Text & Chr(13) & Chr(13) _
                             & Pie

                    DetalleHTML = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr><tr><td colspan='3' align='center'>Encabezado</td></tr><tr><td colspan='3'><hr /></td></tr><tr>" _
                                   & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>" _
                                   & "<tr><td align='right'><label><b>Cliente:</b></label></td><td>" & tbx_Cliente.Text & " - " & cmb_Cliente.Text.ToUpper & "</td></tr><tr><td align='right'><label><b>Tipo Cliente:</b></label></td>" _
                                   & "<td>" & tbx_TipoCliente.Text & "</td></tr><tr><td align='right'><label><b>Fecha Baja:</b></label></td><td>" & dtp_Fecha.Value.Date.ToShortDateString & "</td></tr><tr><td align='right'><label><b>Usuario Registro:</b></label></td>" _
                                   & "<td>" & UsuarioN & "</td></tr><tr><td align='right'><label><b>Motivo:</b></label></td><td>" & cmb_Motivo.Text.ToUpper & "</td></tr><tr><td align='right'><label><b>Contacto:</b></label></td><td>" & tbx_Contacto.Text.ToUpper & "</td></tr>" _
                                   & "<tr><td align='right'><label><b>Cargo:</b></label></td><td>" & tbx_Cargo.Text.ToUpper & "</td></tr><tr><td align='right'><label><b>Observaciones:</b></label></td><td>" & tbx_Observaciones.Text.ToUpper & "</td></tr>" _
                                   & "<tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table></body></html>"
                Else
                    'Enviar Mensaje de Baja de Cliente mostrando una leyenda de que el cliente contenía una caja fuerte rentada
                    Detalle = "Por medio del presente se le Informa de la Baja de las Sucursales" & Hijos & Chr(13) _
                             & "con los siguientes datos a partir de la fecha señalada." & Chr(13) & Chr(13) & Pie

                    DetalleHTML = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr><tr><td colspan='3' align='center'>Encabezado</td></tr><tr><td colspan='3'><hr /></td></tr><tr>" _
                                   & "<tr><td align='right'><label><b>Fecha Baja:</b></label></td><td>" & dtp_Fecha.Value.Date.ToShortDateString & "</td></tr><tr><td align='right'><label><b>Usuario Registro:</b></label></td>" _
                                   & "<td>" & UsuarioN & "</td></tr><tr><td align='right'><label><b>Motivo:</b></label></td><td>" & cmb_Motivo.Text.ToUpper & "</td></tr><tr><td align='right'><label><b>Contacto:</b></label></td><td>" & tbx_Contacto.Text.ToUpper & "</td></tr>" _
                                   & "<tr><td align='right'><label><b>Cargo:</b></label></td><td>" & tbx_Cargo.Text.ToUpper & "</td></tr><tr><td align='right'><label><b>Observaciones:</b></label></td><td>" & tbx_Observaciones.Text.ToUpper & "</td></tr>" _
                                   & "<tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table></body></html>"
                End If

                If chk_Clientes.Checked Then
                    DetalleHTML = Replace(DetalleHTML, "Pie</td></tr></table>", FuncionesGlobales.fn_DatatableToHTML(Dt_Clientes, "Subclientes", 1, 1, 14) & "</td></tr><tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table>")
                End If
                DetalleHTML = Replace(DetalleHTML, "Pie", PieHTMTL)

                If DetalleHTML <> "" Then
                    fn_AlertasGeneradas_Guardar("15", Detalle, Nothing, True, "BAJA DE CLIENTE", "", DetalleHTML)
                Else
                    fn_AlertasGeneradas_Guardar("15", Detalle, Nothing, True, "BAJA DE CLIENTE", "", "")
                End If
            End If

            MsgBox("La Baja se registró correctamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_Cliente.Actualizar() 'para que ya no muestre el cliente eliminado''refresca

            cmb_Cliente.SelectedValue = "0"
            cmb_Motivo.SelectedValue = "0"
            Call Limpiar()
            Call LimpiarPestañaDatos()
            tbx_Cliente.Clear()
            tbx_Cliente.Focus()
        End If
    End Sub

#End Region

#Region "Metodos Privados"

    Sub Limpiar()
        Dt_Clientes.Rows.Clear()
        Id_Clientes = ""
        tbx_NombreF.Clear()
        tbx_DireccionF.Clear()
        tbx_RFC.Clear()
        tbx_DireccionC.Clear()
        tbx_CiudadF.Clear()
        Arreglo_Archivo = Nothing
        tbx_TipoCliente.Clear()
        btn_AgregarArchivo.Enabled = cmb_Cliente.SelectedValue > 0
        chk_ListaNegra.Checked = False
        tbx_ListaNegra.Clear()
        lbl_ListaNegra.Enabled = cmb_Cliente.SelectedValue > 0
        chk_ListaNegra.Enabled = cmb_Cliente.SelectedValue > 0
        tbx_Observaciones.Clear()
        dtp_Fecha.Value = Today
        tbx_Contacto.Clear()
        tbx_Cargo.Clear()
        tbx_Archivo.Clear()
        chk_Clientes.Checked = False
        btn_Mostrar.Visible = False
        lbl_Alerta.Text = ""
        lbl_Alerta.Tag = ""
    End Sub

    Sub LimpiarPestañaDatos()
        dtp_Fecha.Value = Now.Date
        cmb_Motivo.SelectedValue = 0
        tbx_Contacto.Clear()
        tbx_Cargo.Clear()
        tbx_Observaciones.Clear()
    End Sub
  
    Function Validar() As Boolean
        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente para la Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Return False
        End If
        If dtp_Fecha.Value.Date < Today.Date Then
            MsgBox("La Fecha seleccionada es incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Fecha.Focus()
            Return False
        End If
        If cmb_Motivo.SelectedValue = "0" Then
            MsgBox("Seleccione el Motivo de la Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Motivo.Focus()
            Return False
        End If
        If tbx_Contacto.Text = "" Then
            MsgBox("Indique el nombre del Contacto que solicitó la Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contacto.Focus()
            Return False
        End If
        If tbx_Cargo.Text = "" Then
            MsgBox("Indique el Cargo o Puesto del Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cargo.Focus()
            Return False
        End If
        If tbx_Observaciones.Text = "" Then
            MsgBox("Indique Observaciones de la Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Observaciones.Focus()
            Return False
        End If
        If chk_ListaNegra.Checked AndAlso tbx_ListaNegra.TextLength < 10 Then
            MsgBox("Indique Comentarios para la Lista Negra.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ListaNegra.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Private Sub Tab_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Datos.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub chk_ListaNegra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ListaNegra.CheckedChanged
        SegundosDesconexion = 0

        tbx_ListaNegra.Clear()
        lbl_ComentariosListaNegra.Enabled = chk_ListaNegra.Checked
        tbx_ListaNegra.Enabled = chk_ListaNegra.Checked
        lbl_ListaNegraA.Visible = chk_ListaNegra.Checked
    End Sub

    Private Sub chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Clientes.CheckedChanged
        SegundosDesconexion = 0
        'Id_Clientes = cmb_Cliente.SelectedValue
        lbl_Alerta.Text = lbl_Alerta.Tag
        btn_Mostrar.Visible = lbl_Alerta.Text <> ""
        If chk_Clientes.Checked AndAlso cmb_Cliente.SelectedValue > 0 Then
            Dim frm As New frm_BuscarSubClientes
            frm.Consulta = frm_BuscarSubClientes.Query.ClientesBaja
            frm.Id_Padre = cmb_Cliente.SelectedValue
            frm.FiltroStatus = "A"
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Dt_Clientes.Rows.Clear()

                Id_Clientes = ""
                For Each ModalSubClientes As ListViewItem In frm.lsv_Clientes.CheckedItems
                    If frm.lsv_Clientes.CheckedItems.Count = 1 Then
                        'Significa que la ventana modal solo se selecciono un solo cliente y si es el cliente padre
                        'por consiguiente no se necesita tener palomeada esta opción
                        If cmb_Cliente.SelectedValue = ModalSubClientes.Tag Then
                            chk_Clientes.Checked = False
                            Exit Sub
                        End If
                    End If

                    If ModalSubClientes.SubItems(3).Text <> "BAJA PERMANENTE" Then
                        Id_Clientes &= ModalSubClientes.Tag & ","
                        Dt_Clientes.Rows.Add(ModalSubClientes.Tag, ModalSubClientes.Text, ModalSubClientes.SubItems(1).Text, ModalSubClientes.SubItems(3).Text)
                    End If
                Next
                If Dt_Clientes.Rows.Count > 0 Then
                    Dim dt_ClientesConCaja As DataTable = fn_ClientesCajaFuerte_Cantidad(Id_Clientes)
                    If dt_ClientesConCaja IsNot Nothing AndAlso dt_ClientesConCaja.Rows.Count > 0 Then
                        lbl_Alerta.Text = "El Cliente o alguna de sus Sucursales tienen en Renta, Proceso de Renta o Pendiente de Retiro de Cajas Fuertes"
                        btn_Mostrar.Visible = True
                    End If
                Else
                    chk_Clientes.Checked = False
                End If
            Else
                chk_Clientes.Checked = False
            End If
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Clave = Id_Clientes
        frm.Consulta = Frm_BuscarCliente.Query.ClientesCajasFuerte
        frm.ShowDialog()
    End Sub

End Class