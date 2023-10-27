Imports Modulo_Ventas.Cn_Clientes
Public Class frm_CasetAsignaCliente

    Private Sub frm_CasetAsignaCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Cliente.AgregaParametro("@Status", "T", 0)
        cmb_Cliente.Actualizar()

        CargarCasetsDisponibles()
        CargarCasetAsiganClienteDisponibles()
        CargarCasetDisponiblesSeguridadInterna()

    End Sub

    Private Sub CargarCasetsDisponibles()

        lbl_CasetsAsignados.Text = "0 Caset disponibles"

        If Not fn_Kardex_Caset_Disponibles(lsv_CasetDisponibles) Then
            MsgBox("Ocurrió un error al intentar consultar Caset Disponibles.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_CasetsDisponibles.Text = ObtenerElmentosCantidad(lsv_CasetDisponibles) & " Casets disponibles"

        ActivarModoCodigoBarra(ObtenerElmentosCantidad(lsv_CasetDisponibles))

    End Sub


    Private Sub CargarCasetAsiganClienteDisponibles()
        If Not fn_Kardex_CasetAsignaCliente_Disponibles(lsv_CasetAsignados) Then
            MsgBox("Ocurrió un error al intentar consultar Caset asignado al cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_CasetsAsignados.Text = ObtenerElmentosCantidad(lsv_CasetAsignados) & " Casets disponibles"
    End Sub

    Private Sub CargarCasetDisponiblesSeguridadInterna()
        If Not fn_Kardex_Caset_getSeguridad(lsv_Seguridad) Then
            MsgBox("Ocurrió un error al intentar cargar Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_CasetsDisponibles.Text = ObtenerElmentosCantidad(lsv_Seguridad) & " Casets disponibles"

        ActivarModoCodigoBarra(ObtenerElmentosCantidad(lsv_Seguridad))
    End Sub


    Private Sub ActivarModoCodigoBarra(ByVal Elementos As Integer)
        tbx_CodigoBarra.Enabled = Elementos
    End Sub

    Private Function ObtenerElmentosCantidad(ByVal lsv As cp_Listview) As Integer
        Return lsv.Items.Count
    End Function

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub


    Private Sub tbx_CodigoBarra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_CodigoBarra.TextChanged
        If tbx_CodigoBarra.Text.Length > 7 Then
            If Not tbx_CodigoBarra.Text.Contains("'") Then
                MsgBox("Código no valido.", MsgBoxStyle.Critical)
                tbx_CodigoBarra.Text = ""
                tbx_CodigoBarra.Focus()
                Exit Sub
            End If
            SeleccionarClientes(tbx_CodigoBarra.Text)
            tbx_CodigoBarra.Text = ""
            tbx_CodigoBarra.Focus()
        End If
    End Sub


    Public Function SeleccionarClientes(ByVal CodigoBarra As String) As Boolean
        For Each item As ListViewItem In lsv_CasetDisponibles.Items
            If item.SubItems(0).Text = CodigoBarra Then
                item.Checked = True
                item.ForeColor = Color.Green
                item.EnsureVisible()
                Exit For
            End If
        Next
    End Function

    Private Sub btn_Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignar.Click
        If Not ValidarDatosUsuario() Then
            Exit Sub
        End If

        If Tab_CasetDisponibles.SelectedTab Is tbp_CasetNorma Then
            If Not ValidarCasetSeleccionadoContraCliente() Then
                MsgBox("El cliente del código de barra, no es igual al cliente que se intente asignar.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
        End If


        If Tab_CasetDisponibles.SelectedTab Is tbp_CasetNorma Then
            If Not fn_Kardex_Caset_AsignaCliente(lsv_CasetDisponibles, cmb_Cliente.SelectedValue, dtp_Fecha_Asignacion.Value) Then
                MsgBox("Ocurrió un error al intentar asinar Cassets.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If


        ElseIf Tab_CasetDisponibles.SelectedTab Is tbp_SeguridadInterna Then
            If Not fn_Kardex_Caset_AsignaCliente(lsv_Seguridad, cmb_Cliente.SelectedValue, dtp_Fecha_Asignacion.Value) Then
                MsgBox("Ocurrió un error al intentar asinar Cassets.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If




        
        CargarCasetsDisponibles()
        CargarCasetAsiganClienteDisponibles()
        CargarCasetDisponiblesSeguridadInterna()

    End Sub


    Public Function ValidarDatosUsuario() As Boolean

        If Tab_CasetDisponibles.SelectedTab Is tbp_CasetNorma Then
            If lsv_CasetDisponibles.CheckedItems.Count = 0 Then
                MsgBox("Seleccione un Caset para asignar.", MsgBoxStyle.Information, frm_MENU.Text)
                Return False
            End If

        ElseIf Tab_CasetDisponibles.SelectedTab Is tbp_SeguridadInterna Then
            If lsv_Seguridad.CheckedItems.Count = 0 Then
                MsgBox("Seleccione un Caset para asignar.", MsgBoxStyle.Information, frm_MENU.Text)
                Return False
            End If
        End If

        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub lsv_CasetDisponibles_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_CasetDisponibles.ItemChecked
        e.Item.ForeColor = Color.Black
        If e.Item.Checked Then
            e.Item.ForeColor = Color.Green
        End If
    End Sub


    Private Function ValidarCasetSeleccionadoContraCliente()
        For Each item As ListViewItem In lsv_CasetDisponibles.CheckedItems
            If CInt(item.SubItems(8).Text) <> CInt(cmb_Cliente.SelectedValue) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btn_Retirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Retirar.Click

        If lsv_CasetAsignados.CheckedItems.Count = 0 Then
            MsgBox("Seleccione un caset a cancelar.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_Observaciones.Text = "" Then
            MsgBox("Capture una obaservación.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If


        If Not fn_Kardex_CasetAsignaCliente_Cancelar(tbx_Observaciones.Text, lsv_CasetAsignados) Then
            MsgBox("Ocurrió un error al intentar cancelar Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        CargarCasetsDisponibles()
        CargarCasetAsiganClienteDisponibles()
        CargarCasetDisponiblesSeguridadInterna()
    End Sub

End Class