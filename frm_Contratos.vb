Imports Modulo_Ventas.Cn_Clientes

Public Class frm_Contratos

    Public Nuevo As Boolean = True
    Public Renovar As Boolean = False
    Public Id_Renovar As Integer = 0
    Public Id_Cliente As Integer = 0
    Public Id_Contrato As Integer = 0
    Public Numero_Contrato As Integer = 0
    Dim dt_Clausulas As DataTable = Nothing
    Dim dt_ClausulasAdd As DataTable = Nothing
    Dim frm_Cla As New frm_ContratosClausulas

    Private Sub frm_Contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        cmb_Clientes.AgregaParametro("@Status", "A", 0)
        cmb_Clientes.AgregaParametro("@Padres", "N", 0)
        cmb_Clientes.Actualizar()

        cmb_Pais.AgregaParametro("@Status", "A", 0)

        cmb_Estado.AgregaParametro("@Status", "A", 0)
        cmb_Estado.AgregaParametro("@Id_Pais", 0, 1)

        cmb_Ciudad.AgregaParametro("@Status", "A", 0)
        cmb_Ciudad.AgregaParametro("@Id_Estado", 0, 1)

        cmb_Pais.Actualizar()

        If Nuevo = False Or Renovar = True Then
            Dim Dt_Datos As DataTable
            Dt_Datos = fn_Contratos_Read(Id_Contrato, Id_Cliente)

            tbx_NumContrato.Enabled = Renovar
            If Dt_Datos Is Nothing Then Exit Sub
            If Dt_Datos.Rows.Count = 0 Then Exit Sub

            Id_Contrato = Dt_Datos.Rows(0)("Id_Contrato")
            tbx_NumContrato.Text = Dt_Datos.Rows(0)("Numero_Contrato")
            dtp_FechaContrato.Value = Dt_Datos.Rows(0)("Fecha_Contrato")
            dtp_FechaInicio.Value = Dt_Datos.Rows(0)("Fecha_Inicio")
            dtp_FechaFin.Value = Dt_Datos.Rows(0)("Fecha_Fin")
            cmb_Pais.SelectedValue = Dt_Datos.Rows(0)("Id_Pais")
            cmb_Estado.SelectedValue = Dt_Datos.Rows(0)("Id_Estado")
            cmb_Ciudad.SelectedValue = Dt_Datos.Rows(0)("Id_CiudadFirma")
            cmb_Clientes.SelectedValue = Dt_Datos.Rows(0)("Id_Cliente")
            tbx_FirmaEmpresa.Text = Dt_Datos.Rows(0)("Firma_Empresa")
            tbx_PuestoEmpresa.Text = Dt_Datos.Rows(0)("Puesto_Empresa")
            tbx_TetigoEmpresa.Text = Dt_Datos.Rows(0)("Testigo_Empresa")
            tbx_FirmaCliente.Text = Dt_Datos.Rows(0)("Firma_Cliente")
            tbx_PuestoCliente.Text = Dt_Datos.Rows(0)("Puesto_Cliente")
            tbx_TestigoCliente.Text = Dt_Datos.Rows(0)("Testigo_Cliente")
            rtb_Observaciones.Text = Dt_Datos.Rows(0)("Observaciones")
            rtb_DatosPoderEmpresa.Text = Dt_Datos.Rows(0)("Datos_Poder_Empresa")
            rtb_DatosPoderCliente.Text = Dt_Datos.Rows(0)("Datos_Poder_Cliente")
        End If

        'llena lista de clausulas Activos
        Call LlenarListaClausulas()
        frm_Cla.Dt_Clausulas = dt_Clausulas

        'Llena Clausulas agregados
        Call LlenarListaClasulasAgregadas()
    End Sub

    Private Sub LlenarListaClausulas()
        dt_Clausulas = fn_Clausulas_LlenarLista("A")
        If dt_Clausulas Is Nothing Then
            MsgBox("Ocurrió un error al cargar la información de las Claúsulas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        dt_Clausulas.Columns.Add("Numero_Clausula")
        dt_Clausulas.Columns("Numero_Clausula").ReadOnly = False
        dt_Clausulas.Columns.Add("Numero_Ordinario")
    End Sub

    Private Sub LlenarListaClasulasAgregadas()
        dt_ClausulasAdd = fn_Contratos_LlenarClausulas(Id_Contrato)
        If dt_ClausulasAdd Is Nothing Then
            MsgBox("Ocurrió un error al cargar la información de las Claúsulas agregadas a este Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub cmb_Pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pais.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Estado.ActualizaValorParametro("@Id_Pais", cmb_Pais.SelectedValue)
        cmb_Estado.Actualizar()
    End Sub

    Private Sub cmb_Estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Estado.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Ciudad.ActualizaValorParametro("@Id_Estado", cmb_Estado.SelectedValue)
        cmb_Ciudad.Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub LimpiarControles()
        tbx_NumContrato.Focus()
        Id_Contrato = 0
        Nuevo = True
        dt_ClausulasAdd.Rows.Clear() 'Clear DT
        tbx_NumContrato.Clear()
        dtp_FechaContrato.Value = Now.Date
        dtp_FechaFin.Value = Now.Date
        dtp_FechaInicio.Value = Now.Date
        tbx_Filtro.Text = 0
        cmb_Pais.SelectedValue = 0
        cmb_Estado.SelectedValue = 0
        cmb_Ciudad.SelectedValue = 0
        tbx_FirmaCliente.Clear()
        tbx_FirmaEmpresa.Clear()
        tbx_PuestoCliente.Clear()
        tbx_PuestoEmpresa.Clear()
        tbx_TestigoCliente.Clear()
        tbx_TetigoEmpresa.Clear()
        rtb_Observaciones.Clear()
        rtb_DatosPoderCliente.Clear()
        rtb_DatosPoderEmpresa.Clear()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If tbx_NumContrato.Text.Trim() = "" Then
            MsgBox("Indique un Número de Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NumContrato.Focus()
            Exit Sub
        End If

        If dtp_FechaInicio.Value > dtp_FechaFin.Value Then
            MsgBox("Las fechas parecen ser Incorrectas.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaInicio.Focus()
            Exit Sub
        End If

        If cmb_Clientes.SelectedValue = 0 Then
            MsgBox("Debe Indicar un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Filtro.Focus()
            Exit Sub
        End If

        If cmb_Pais.SelectedValue = 0 Then
            MsgBox("Debe indicar un País.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Pais.Focus()
            Exit Sub
        End If

        If cmb_Estado.SelectedValue = 0 Then
            MsgBox("Debe Indicar un Estado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Estado.Focus()
            Exit Sub
        End If

        If cmb_Ciudad.SelectedValue = 0 Then
            MsgBox("Debe Indicar una Ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ciudad.Focus()
            Exit Sub
        End If

        If tbx_FirmaEmpresa.Text.Trim = "" Then
            MsgBox("Debe Indicar el nombre de quien firma por parte de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FirmaEmpresa.Focus()
            Exit Sub
        End If

        If tbx_PuestoEmpresa.Text.Trim = "" Then
            MsgBox("Debe indicar el puesto de la persona que firma por parte de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_PuestoEmpresa.Focus()
            Exit Sub
        End If

        If tbx_FirmaCliente.Text.Trim = "" Then
            MsgBox("Debe Indicar el nombre de la persona que firma por parte del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_FirmaCliente.Focus()
            Exit Sub
        End If

        If tbx_PuestoCliente.Text.Trim = "" Then
            MsgBox("Debe indicar el puesto de la persona que firma por parte del Cliente", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_PuestoCliente.Focus()
            Exit Sub
        End If

        Dim ExisteContrato As Boolean = fn_Contratos_Existe(cmb_Clientes.SelectedValue)

        If (ExisteContrato And Nuevo = True) Or (ExisteContrato And Renovar = True) Then
            MsgBox(" Ya existe un Número de Contrato para el Cliente " & cmb_Clientes.Text, MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If dt_ClausulasAdd.Rows.Count = 0 Then
            MsgBox("Debe agregar Cláusulas para poder guardar el Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Nuevo = True Then 'ContratoNuevo

            Id_Contrato = fn_Contratos_Guardar(tbx_NumContrato.Text.Trim, dtp_FechaContrato.Value, dtp_FechaInicio.Value.Date, dtp_FechaFin.Value.Date, cmb_Clientes.SelectedValue, _
                                               tbx_FirmaEmpresa.Text.Trim, tbx_PuestoEmpresa.Text.Trim, tbx_TestigoCliente.Text.Trim, cmb_Ciudad.SelectedValue, tbx_FirmaCliente.Text.Trim, _
                                               tbx_PuestoCliente.Text.Trim, tbx_TestigoCliente.Text.Trim, rtb_Observaciones.Text.Trim, rtb_DatosPoderEmpresa.Text.Trim, rtb_DatosPoderCliente.Text.Trim, Id_Renovar)
            If Id_Contrato = 0 Then
                MsgBox("Error al Guardar el Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("Contrato Guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            Call GuardarClausulas()
            Call LimpiarControles()

        Else 'Si es Modificacion
            If fn_Contratos_Modificar(Id_Contrato, dtp_FechaContrato.Value, dtp_FechaInicio.Value, dtp_FechaFin.Value, cmb_Clientes.SelectedValue, tbx_FirmaEmpresa.Text.Trim, _
                                      tbx_PuestoEmpresa.Text.Trim, tbx_TetigoEmpresa.Text.Trim, cmb_Ciudad.SelectedValue, tbx_FirmaCliente.Text.Trim, _
                                      tbx_PuestoCliente.Text.Trim, tbx_TestigoCliente.Text.Trim, rtb_Observaciones.Text.Trim, rtb_DatosPoderEmpresa.Text.Trim, rtb_DatosPoderCliente.Text.Trim) = False Then
                MsgBox("Error al Modificar el Contrato.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("Contrato modificado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            Call GuardarClausulas()
        End If

    End Sub

    Private Function GuardarClausulas() As Boolean
        SegundosDesconexion = 0
        'Borrar las Cláusulas Actuales (en caso de que haya)
        If fn_Contratos_Delete(Id_Contrato) = False Then
            MsgBox("Error al eliminar las Cláusulas anteriores.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        If Nuevo = True Then
            If fn_Contratos_GuardarDetalle(dt_ClausulasAdd, Id_Contrato) = False Then
                MsgBox("Error al Guardar las Cláusulas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Function
            End If
        Else
            If fn_Contratos_GuardarDetalleModif(dt_ClausulasAdd, Id_Contrato) = False Then
                MsgBox("Error al Modificar las Cláusulas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Function
            End If
        End If
        Return True
    End Function

    Private Sub btn_Clausulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clausulas.Click
        SegundosDesconexion = 0
        frm_Cla.Dt_Agregado = dt_ClausulasAdd 'cnsultado
        frm_Cla.ShowDialog()
        dt_ClausulasAdd = frm_Cla.Dt_Agregado
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rtb_DatosPoderEmpresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_DatosPoderEmpresa.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rtb_DatosPoderCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_DatosPoderCliente.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class