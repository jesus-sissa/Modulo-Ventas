Imports Modulo_Ventas.Cn_Clientes

Public Class frm_ReasignarCodigoPostal

    Dim nombrePais = ""
    Dim nombreEstado = ""
    Dim idEstado As Integer = 0
    Dim nombreCiudad = ""
    Dim infoCiudad As DataTable

    Private Sub frm_ReasignarCodigoPostal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarElementos()
        ocultarDatosColonia()
    End Sub

    Private Sub btn_ValidarCodigoPostal_Click(sender As Object, e As EventArgs) Handles btn_ValidarCodigoPostal.Click

        lbl_Aviso.Text = ""
        btn_ReasignarCP.Visible = False

        ''Validaciones
        If tbx_CodigoPostal.Text.Trim() = "" Then
            lbl_Error.Visible = True
            lbl_Error.Text = "Favor de inresar un codigo postal"
            tbx_CodigoPostal.Focus()
            Exit Sub
        End If

        ''obtenemos la informacion del codigo postal introducido 
        Dim informacionCodigoPostal As DataTable = fn_BuscarDatosColonia(tbx_CodigoPostal.Text)

        'asiganmos los datos que ocuparemos para la visualizacion y el guardado de la informacion.
        If informacionCodigoPostal IsNot Nothing Then
            nombreCiudad = informacionCodigoPostal.Rows(0)("NombreCiudad").ToString()
            nombreEstado = informacionCodigoPostal.Rows(0)("NombreEstado").ToString()
            nombrePais = informacionCodigoPostal.Rows(0)("NombrePais").ToString()
            idEstado = informacionCodigoPostal.Rows(0)("id_Estado").ToString()
        End If

        'verifacamos la informacio del codigo postal.
        If informacionCodigoPostal IsNot Nothing Then

            If nombreCiudad <> "Sin definir" Then
                lbl_EstatusBusqueda.Visible = True
                lbl_EstatusBusqueda.Text = "Este codigo postal ya pertenece a la ciudad de" + vbCrLf + "" + nombreCiudad +
                                            "" + vbCrLf + "y por lo tanto no se puede reasignar."

            ElseIf nombreCiudad = "Sin definir" Then
                lblPais.Text = nombrePais
                lblEstado.Text = nombreEstado
                lbl_CP.Text = tbx_CodigoPostal.Text
                mostrarDatosColonia()
                CargarcomboCiudad(idEstado)
            End If
        Else
            lbl_EstatusBusqueda.Visible = True
            lbl_EstatusBusqueda.Text = "El codigo postal introducido es erroreno o" + vbCrLf + "el catalago esta desactualizado."
        End If
    End Sub


    ''Metodos
    Private Sub ocultarElementos()
        lbl_Error.Visible = False
        lbl_EstatusBusqueda.Visible = False
        lbl_Aviso.Visible = False
        lbl_Aviso.Text = ""
    End Sub

    Private Sub ocultarDatosColonia()
        lbl_TituloPais.Visible = False
        lblPais.Visible = False
        lbl_TituloEstado.Visible = False
        lblEstado.Visible = False
        lbl_TituloCiudad.Visible = False
        cmb_Ciudades.Visible = False
        lbl_TituloCP.Visible = False
        lbl_CP.Visible = False
        btn_ReasignarCP.Visible = False
        lbl_Aviso.Visible = False
    End Sub

    Private Sub mostrarDatosColonia()
        lbl_TituloPais.Visible = True
        lblPais.Visible = True
        lbl_TituloEstado.Visible = True
        lblEstado.Visible = True
        lbl_TituloCiudad.Visible = True
        lbl_TituloCP.Visible = True
        lbl_CP.Visible = True
        cmb_Ciudades.Visible = True
        btn_ReasignarCP.Visible = False
        lbl_Aviso.Visible = True
    End Sub

    Private Sub CargarcomboCiudad(idCiudad As Integer)
        'obtenemos la informacion del codigo postal introducido 
        Dim informacionCodigoPostal As DataTable = fn_BuscarCiudades(idCiudad)
        infoCiudad = informacionCodigoPostal
        cmb_Ciudades.DataSource = informacionCodigoPostal
        cmb_Ciudades.ValueMember = "Id_Ciudad"
        cmb_Ciudades.DisplayMember = "Nombre"
    End Sub

    Private Sub mostarAviso(nombreCiudad As String)
        lbl_Aviso.Text = "Atencion: El codigo Postal " + tbx_CodigoPostal.Text + " sera reasignado" + vbCrLf + "a la ciudad de " + nombreCiudad + "."
        btn_ReasignarCP.Visible = True
    End Sub

    Private Sub cmb_Ciudades_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Ciudades.SelectionChangeCommitted
        mostarAviso(cmb_Ciudades.Text)
        btn_ReasignarCP.Enabled = True
    End Sub

    Private Sub btn_ReasignarCP_Click(sender As Object, e As EventArgs) Handles btn_ReasignarCP.Click


        Dim msgConfirmacion As Integer
        msgConfirmacion = MsgBox("Esta segur@ que la informacion esta de forma correcta", vbQuestion + vbYesNo + vbDefaultButton2, "Cofirmar informacion")

        If msgConfirmacion = vbYes Then

            btn_ReasignarCP.Enabled = False

            Dim clave_ciudad As String = ""
            Dim idCiudad As Integer = 0
            Dim codigoPostal = tbx_CodigoPostal.Text

            If infoCiudad IsNot Nothing Then

                ''obtenemos la clave de la ciudad seleccionada asi como tambien su id correspondiente.
                For index = 0 To infoCiudad.Rows.Count - 1
                    If cmb_Ciudades.SelectedValue.ToString() = infoCiudad.Rows(index)("Id_Ciudad") Then
                        clave_ciudad = infoCiudad.Rows(index)("Clave_Ciudad").ToString()
                        idCiudad = cmb_Ciudades.SelectedValue
                    End If
                Next
            End If
            If clave_ciudad <> "" And idCiudad <> 0 Then
                Dim reasignarCP As Integer = fn_ReasiganarCP(codigoPostal, clave_ciudad, idCiudad)
                If reasignarCP = 1 Then
                    MsgBox("Codigo Postal Reasignado correctamente", MsgBoxStyle.Exclamation, frm_MENU.Text)
                Else
                    MsgBox("Lo sentimos algo salio mal", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If

        End If
    End Sub
End Class