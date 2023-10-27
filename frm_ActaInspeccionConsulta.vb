Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ActaInspeccionConsulta

    Private Sub frm_ConsultaActaInspeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Today.Date
        dtp_Hasta.Value = Today.Date

        cmb_Cliente.Actualizar()
        cmb_Empleado.Actualizar()
        cmb_Status.AgregarItem("A", "PENDIENTES")
        cmb_Status.AgregarItem("C", "CANCELADOS")
        cmb_Status.AgregarItem("V", "VALIDADOS")

        lsv_ActasInspeccion.Columns.Add("NumeroActa")
        lsv_ActasInspeccion.Columns.Add("FechaProgramada")
        lsv_ActasInspeccion.Columns.Add("HoraProgramada")
        lsv_ActasInspeccion.Columns.Add("Cliente")
        lsv_ActasInspeccion.Columns.Add("Domicilio")
        lsv_ActasInspeccion.Columns.Add("Status")

        Call Limpiar()
        Call Botones()
    End Sub

#Region "SUB"

    Sub Limpiar()
        lsv_ActasInspeccion.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Modificar.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Reimprimir.Enabled = False
    End Sub

    Sub Botones()
        btn_Modificar.Enabled = False
        btn_ModificarImagenes.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Reimprimir.Enabled = False
        If lsv_ActasInspeccion.SelectedItems.Count > 0 Then
            If lsv_ActasInspeccion.SelectedItems(0).SubItems(6).Text <> "CANCELADO" Then
                btn_Cancelar.Enabled = True
            End If
            If lsv_ActasInspeccion.SelectedItems(0).SubItems(6).Text = "VALIDADO" Then
                btn_ModificarImagenes.Enabled = True
                btn_Modificar.Enabled = True
            End If
            btn_Reimprimir.Enabled = True
        End If
    End Sub

    Private Function LlenarLista() As Boolean
        Call Limpiar()
        Dim Status As String
        If cmb_Status.SelectedValue = "0" Then Status = "T" Else Status = cmb_Status.SelectedValue
        If Not Cn_Clientes.fn_ActasInspeccion_LlenarLista(lsv_ActasInspeccion, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Cliente.SelectedValue, cmb_Empleado.SelectedValue, Status) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Lbl_Registros.Text = "Registros: " & lsv_ActasInspeccion.Items.Count
        Return True
    End Function

#End Region

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha Inicial no puede ser mayor que la Fecha Final", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If chk_ClienteTodos.Checked = False Then
            If cmb_Cliente.SelectedValue = "0" Then
                MsgBox("Seleccione un Cliente o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        If chk_EmpleadoTodos.Checked = False Then
            If cmb_Empleado.SelectedValue = "0" Then
                MsgBox("Seleccione un Empleado o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        If chk_StatusTodos.Checked = False Then
            If cmb_Status.SelectedValue = "0" Then
                MsgBox("Seleccione el Status o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Call LlenarLista()
    End Sub

    Private Sub chk_ClienteTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ClienteTodos.CheckedChanged
        SegundosDesconexion = 0
        cmb_Cliente.SelectedValue = 0
        lbl_Cliente.Enabled = chk_ClienteTodos.Checked = False
        tbx_ClienteClave.Enabled = chk_ClienteTodos.Checked = False
        cmb_Cliente.Enabled = chk_ClienteTodos.Checked = False
        Call Limpiar()
    End Sub

    Private Sub chk_EmpleadoTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_EmpleadoTodos.CheckedChanged
        SegundosDesconexion = 0
        cmb_Empleado.SelectedValue = 0
        lbl_Empleado.Enabled = chk_EmpleadoTodos.Checked = False
        tbx_EmpleadoClave.Enabled = chk_EmpleadoTodos.Checked = False
        cmb_Empleado.Enabled = chk_EmpleadoTodos.Checked = False
        Call Limpiar()
    End Sub

    Private Sub chk_StatusTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_StatusTodos.CheckedChanged
        SegundosDesconexion = 0
        cmb_Status.SelectedValue = 0
        lbl_Status.Enabled = chk_StatusTodos.Checked = False
        cmb_Status.Enabled = chk_StatusTodos.Checked = False
        Call Limpiar()
    End Sub

    Private Sub lsv_ActasInspeccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ActasInspeccion.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_ActaInspeccionDetalle
        frm.Id_Inspeccion = lsv_ActasInspeccion.SelectedItems(0).Tag
        Select Case lsv_ActasInspeccion.SelectedItems(0).SubItems(6).Text
            Case "PENDIENTE"
                frm.Status = "A"
            Case "VALIDADO"
                frm.Status = "V"
        End Select
        frm.Modificar = True
        frm.ShowDialog()
        Call LlenarLista()
        Call Botones()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        If MsgBox("Confirma que desea Cancelar el Acta " & lsv_ActasInspeccion.SelectedItems(0).Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
            If Not Cn_Clientes.fn_ActaInspeccion_Cancelar(lsv_ActasInspeccion.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un Error al intentar Cancelar el Acta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Cn_Login.fn_Log_Create("CANCELAR ORDEN DE INSPECCION: " & lsv_ActasInspeccion.SelectedItems(0).Text & " CLIENTE: " & lsv_ActasInspeccion.SelectedItems(0).SubItems(3).Text)
            Call LlenarLista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Reimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reimprimir.Click
        SegundosDesconexion = 0
        'Cargar el Reporte para imprimirlo
        Dim ds As New ds_Reporte
        If Not fn_ActaInspeccion_Imprimir(ds.Tbl_ActaInspeccion, lsv_ActasInspeccion.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar Reimprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not fn_Reportes_Encabezado(ds.Tbl_DatosEmpresa) Then
            MsgBox("Ha ocurrido un error al intentar Reimprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Mostrar el Reporte
        Dim rpt As New rpt_ActaInspeccionCajaFuerte

        '--------------pruebas de imagen en reportes {
        If Not IsDBNull(ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then

            Dim imagenNueva As Image = Nothing
            Dim imagenBytes As Byte() = ds.Tbl_DatosEmpresa.Rows(0)("logo")
            Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
            imagenNueva = Image.FromStream(ms_ByteToImagen, True)

            Dim Ancho As Integer = imagenNueva.Width
            Dim Alto As Integer = imagenNueva.Height
            Dim valordiv As Decimal = 0.0

            With rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                Dim Top_Obj As Integer = .Top
                Dim Left_Obj As Integer = .Left '+- 342default
                Dim Width_Obj As Integer = .Width '1440Default

                If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                Dim nuevoAncho As Integer = Ancho * valordiv
                Dim NuevoAlto As Integer = Alto * valordiv

                If Ancho > Alto Then
                    'horizontal
                    Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                    .Top = Top_Obj
                Else
                    'vertical,cuadrado
                    Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                    .Left = Left_Obj
                End If
                .Width = nuevoAncho
                .Height = NuevoAlto
            End With

            '-------liberar objetos
            ms_ByteToImagen.Dispose()
            imagenNueva.Dispose()
        End If
        '--------------}
        rpt.SetDataSource(ds)
        Dim frm As New frm_Reporte
        frm.crv.ReportSource = rpt
        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()
    End Sub

    Private Sub btn_ModificarImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ModificarImagenes.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.Filtro = "Imagenes (*.jpg)|*.jpg"
        frm.MaxArchivos = 3
        frm.Id_Tabla = lsv_ActasInspeccion.SelectedItems(0).Tag
        frm.Tipo = frm_CargarArchivos.Query.CajasFuertesInspeccion
        frm.ShowDialog()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Cliente.Enabled Then
                cmb_Cliente.Focus()
            ElseIf cmb_Empleado.Enabled Then
                cmb_Empleado.Focus()
            ElseIf cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

End Class