Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ValidaProspectos

    Dim Debe_Actualizar As Boolean = False

    Private Sub frm_ValidaProspectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fn_BuscarCP_LlenarLista(Lsv_Prospectos, False)
        lbl_Registros.Text = "Registros: " & Lsv_Prospectos.Items.Count
    End Sub

    Private Sub Btn_Valida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Valida.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()
        If frm.Firma = True Then
            Dim Id_Firma As Integer = frm.Empleado
            frm.Dispose()
            Btn_Valida.Enabled = False

            'Verificar si el usuario que firma pertenece a una instancia
            If fn_ValidaHorario_UsuarioValida(Id_Firma) = True Then

                If fn_ValidaProspectoCreate(Lsv_Prospectos) = True Then
                    'Consultar la Clave que le tocó
                    Dim dr As DataRow
                    Dim Detalles As String = ""
                    Dim MensajeAlerta As String = "NINGUNO"
                    Lsv_Prospectos.Columns.Add("ClaveCliente")

                    For Each Elemento As ListViewItem In Lsv_Prospectos.CheckedItems
                        dr = fn_Clientes_Generales(Elemento.Tag)
                        If dr IsNot Nothing Then
                            Elemento.SubItems.Add(dr("Clave_Cliente"))

                            'Enviar Mensaje de Alta de Cliente al Correo
                            If dr("MensajeAlerta") <> "" Then
                                Dim MensajeArr() As String = Split(dr("MensajeAlerta"), "/")
                                If MensajeArr(0) <> "" Then
                                    If MensajeArr(1) = "" Then
                                        MensajeAlerta = MensajeArr(0)
                                    Else
                                        MensajeAlerta = MensajeArr(0) & " " & MensajeArr(1)
                                    End If
                                Else
                                    MensajeAlerta = MensajeArr(1)
                                End If
                            End If

                            Dim Tipo_Cliente As String
                            Select Case dr("Tipo_Cliente")
                                Case "1"
                                    Tipo_Cliente = "TRASLADO"
                                Case "2"
                                    Tipo_Cliente = "SEGURIDAD PATRIMONIAL"
                                Case "3"
                                    Tipo_Cliente = "TRASLADO Y SEGURIDAD PATRIMONIAL"
                                Case "4"
                                    Tipo_Cliente = "CAJA BANCARIA"
                                Case "5"
                                    Tipo_Cliente = "OTRO"
                                Case Else
                                    Tipo_Cliente = "NO ESPECIFICADO"
                            End Select

                            Detalles = "Por Medio Del Presente Se Le Informa Del Registro Del Nuevo Cliente Con Los Siguientes Datos:" & Chr(13) & Chr(13) _
                                     & "                   Sucursal: " & SucursalN & Chr(13) _
                                     & "                    Cliente: " & dr("Clave_Cliente") & " - " & dr("Nombre_Comercial") & Chr(13) _
                                     & "             Fecha Registro: " & dr("Fecha_Registro") & Chr(13) _
                                     & "           Usuario Registro: " & UsuarioN & Chr(13) _
                                     & "             Giro Comercial: " & dr("GiroComercial") & Chr(13) _
                                     & "            Tipo de Cliente: " & Tipo_Cliente & Chr(13) _
                                     & "   Fecha Inicio Operaciones: " & dr("Fecha_InicioOperaciones") & Chr(13) _
                                     & "Requiere Material Operativo: " & dr("RequiereMaterial") & Chr(13) _
                                     & "        Mensaje Informativo: " & MensajeAlerta & Chr(13) & Chr(13) _
                                     & "Agente de Servicios SIAC " & Today.Year.ToString

                            Dim DetallesHTML As String = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr><tr><td colspan='3' align='center'>Encabezado</td></tr><tr><td colspan='3'><hr /></td></tr><tr>" _
                                                         & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>" _
                                                         & "<tr><td align='right'><label><b>Cliente:</b></label></td><td>" & dr("Clave_Cliente") & " - " & dr("Nombre_Comercial") & "</td></tr><tr><td align='right'><label><b>Fecha Registro:</b></label></td>" _
                                                         & "<td>" & dr("Fecha_Registro") & "</td></tr><tr><td align='right'><label><b>Usuario Registro:</b></label></td><td>" & UsuarioN & "</td></tr><tr><td align='right'><label><b>Giro Comercial:</b></label></td>" _
                                                         & "<td>" & dr("GiroComercial") & "</td></tr><tr><td align='right'><label><b>Tipo de Cliente:</b></label></td><td>" & Tipo_Cliente & "</td></tr><tr><td align='right'><label><b>Fecha Inicio Operaciones:</b></label></td><td>" & dr("Fecha_InicioOperaciones") & "</td></tr>" _
                                                         & "<tr><td align='right'><label><b>Requiere Material Operativo:</b></label></td><td>" & dr("RequiereMaterial") & "</td></tr><tr><td align='right'><label><b>Mensaje Informativo:</b></label></td><td>" & MensajeAlerta & "</td></tr>" _
                                                         & "<tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table></body></html>"

                            Call fn_AlertasGeneradas_Guardar("14", Detalles, Nothing, True, "REGISTRO DE CLIENTE NUEVO", "", DetallesHTML)
                        End If
                    Next

                    MsgBox("Registro guardado. Para continuar Evaluando Prospectos debe Actualizar la Lista.", MsgBoxStyle.Information, frm_MENU.Text)
                    btn_Actualizar.Enabled = True
                    Debe_Actualizar = True
                    tbx_Comentario.Clear()
                End If
            Else
                Debe_Actualizar = False
                Btn_Valida.Enabled = True
                MsgBox("Empleado no autorizado para evaluar Clientes", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub Lsv_Prospectos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Prospectos.ItemChecked
        SegundosDesconexion = 0

        Btn_Valida.Enabled = Lsv_Prospectos.CheckedItems.Count > 0 And Not Debe_Actualizar
    End Sub

    Private Sub btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualizar.Click
        SegundosDesconexion = 0

        fn_BuscarCP_LlenarLista(Lsv_Prospectos, False)
        lbl_Registros.Text = "Registros: " & Lsv_Prospectos.Items.Count
        Debe_Actualizar = False
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class