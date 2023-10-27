Imports Modulo_Ventas.cn_Clientes

Public Class frm_ActaInspeccion

    Public Nuevo As Boolean = True

    Private Sub frm_ActaInspeccionCajaFuerte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Fecha.Value = Now
        dtp_Hora.Value = Now
        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.Actualizar()
        Call Limpiar()
    End Sub

#Region "SUB"

    Sub Limpiar()
        cmb_Cliente.SelectedValue = "0"
        tbx_NombreF.Clear()
        tbx_NombreC.Clear()
        tbx_DireccionCliente.Clear()
        tbx_Instrucciones.Clear()
    End Sub

    Private Function Validar() As Boolean
        If dtp_Fecha.Value.Date < Now.Date Then
            MsgBox("No puede seleccionar una Fecha atrasada.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Fecha.Focus()
            Return False
        End If

        If cmb_Cliente.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Return False
        End If

        If tbx_Instrucciones.Text.Trim = "" Then
            MsgBox("Indique Instrucciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Instrucciones.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Private Sub cmb_ClienteFiscal_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0
        tbx_DireccionCliente.Clear()
        tbx_NombreC.Clear()
        tbx_NombreF.Clear()
        If cmb_Cliente.SelectedValue = 0 Then Exit Sub

        Dim Dr_Direccion As DataRow = fn_Cliente_Direccion(cmb_Cliente.SelectedValue)
        Dim DirC As String = ""

        If Not Dr_Direccion Is Nothing Then
            tbx_NombreC.Text = Dr_Direccion("Nombre_Comercial")
            tbx_NombreF.Text = Dr_Direccion("Nombre_Fiscal")

            If Dr_Direccion("NumeroInt_Comercial") = "" Then
                DirC = Dr_Direccion("Calle_Comercial") & " " & Dr_Direccion("Numero_Comercial") & ", " & Dr_Direccion("Colonia_Comercial") & ", " & Dr_Direccion("CiudadComercial")
            Else
                DirC = Dr_Direccion("Calle_Comercial") & " " & Dr_Direccion("Numero_Comercial") & " Int " & Dr_Direccion("NumeroInt_Comercial") & ", " & Dr_Direccion("Colonia_Comercial") & ", " & Dr_Direccion("CiudadComercial")
            End If
            If Dr_Direccion("EntreCalle_Comercial1") <> "" AndAlso Dr_Direccion("EntreCalle_Comercial2") <> "" Then
                DirC &= ", Entre: " & Dr_Direccion("EntreCalle_Comercial1") & " Y " & Dr_Direccion("EntreCalle_Comercial2")
            End If
            tbx_DireccionCliente.Text = DirC
            Dr_Direccion = Nothing
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        Dim Id_Inspeccion As Integer = 0
        If Validar() Then
            If Nuevo Then

                Id_Inspeccion = fn_ActaInspeccion_Create(dtp_Fecha.Value.Date, dtp_Hora.Value.TimeOfDay.ToString, cmb_Cliente.SelectedValue, tbx_NombreC.Text.Trim, tbx_NombreF.Text.Trim, _
                                                tbx_DireccionCliente.Text.Trim, tbx_Instrucciones.Text.Trim)
                If Id_Inspeccion = 0 Then
                    MsgBox("Ocurrio un error al intentar Guardar la Información de la Acta de Inspección para la Instalación de Caja Fuerte", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("CAPTURAR ORDEN DE INSPECCION: " & cmb_Cliente.Text)
                'Cargar el Reporte para imprimirlo
                Dim ds As New ds_Reporte
                Call fn_ActaInspeccion_Imprimir(ds.Tbl_ActaInspeccion, Id_Inspeccion)
                Call fn_Reportes_Encabezado(ds.Tbl_DatosEmpresa)
                'Mostrar el Reporte
                'MsgBox("Se encontraron: " & datas.Tbl_ActaInspeccion.Rows.Count.ToString & " Filas.", MsgBoxStyle.Information, frm_MENU.Text)
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
            Else
                'Modificar los registros (Pendiente)
            End If
            Call Limpiar()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub dtp_Fecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_Hora.Focus()
        End If
    End Sub

    Private Sub dtp_Hora_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hora.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_ClaveClienteFiscal.Focus()
        End If
    End Sub

End Class