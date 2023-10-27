Imports Modulo_Ventas.Cn_Clientes


Public Class frm_AgregarColonia
    Private Sub frm_AgregarColonia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Error.Visible = False
        ocultarElementos()
        tbx_CodigoPostal.Enabled = False
        tbx_NombreColonia.Text = ""
    End Sub

    'Con estas varaibles almacenaremos la informacion necesaria para el guardado de las colonias
    Dim idPais As Integer = 0
    Dim claveEstado As String = ""
    Dim claveCiudad As String = ""
    Dim codigoPostal As String = ""
    Dim nombreColonia As String = ""
    Dim idEstado As Integer = 0
    Dim idCiudad As Integer = 0
    Dim valorClaveColoniaFinal As Integer = 0
    Private Sub btn_ValidarCodigoPostal_Click(sender As Object, e As EventArgs) Handles btn_ValidarCodigoPostal.Click

        lbl_Error.Text = ""

        If tbx_CodigoPostal.Text.Trim() = "" Then
            lbl_Error.Visible = True
            lbl_Error.Text = "Favor de ingresar el codigo postal."
            ocultarElementos()
            Exit Sub
        End If

        If tbx_NombreColonia.Text.Trim() = "" Then
            lbl_Error.Visible = True
            lbl_Error.Text = "Favor de ingresar el nombre de la colonia."
            ocultarElementos()
            Exit Sub
        End If

        Dim informacionCodigoPostal As DataTable = fn_BuscarDatosColonia(tbx_CodigoPostal.Text)

        If informacionCodigoPostal IsNot Nothing Then

            ''Mostramos la informacion de la colonia que se guardara al usario 
            MostrarElementos()
            lblPais.Text = informacionCodigoPostal.Rows(0)("NombrePais").ToString()
            lblEstado.Text = informacionCodigoPostal.Rows(0)("NombreEstado").ToString()
            lblCiudad.Text = informacionCodigoPostal.Rows(0)("NombreCiudad").ToString()
            lblColonia.Text = tbx_NombreColonia.Text
            lblCP.Text = informacionCodigoPostal.Rows(0)("c_CodigoPostal").ToString()

            'Almacenamos los valores que se guardaran en la tabla  correspondiente.
            idPais = Convert.ToInt32(informacionCodigoPostal.Rows(0)("id_Pais").ToString())
            claveEstado = informacionCodigoPostal.Rows(0)("Clave_Estado").ToString()
            claveCiudad = informacionCodigoPostal.Rows(0)("Clave_Ciudad").ToString()
            codigoPostal = informacionCodigoPostal.Rows(0)("c_CodigoPostal").ToString()
            nombreColonia = tbx_NombreColonia.Text
            idEstado = Convert.ToInt32(informacionCodigoPostal.Rows(0)("id_Estado").ToString())
            idCiudad = Convert.ToInt32(informacionCodigoPostal.Rows(0)("id_Ciudad").ToString())

            Dim valorClaveColonia As Integer

            ''obtenemos el valor mas alto del campo clave colonia y le sumamos 1. Esto con el fin de que nos permita guardar
            For I = 0 To informacionCodigoPostal.Rows.Count() - 1
                If informacionCodigoPostal.Rows(I)("Clave_Colonia").ToString() <> "" Then
                    valorClaveColonia = informacionCodigoPostal.Rows(I)("Clave_Colonia").ToString()
                    If valorClaveColonia > valorClaveColoniaFinal Then
                        valorClaveColoniaFinal = valorClaveColonia
                    End If
                End If
            Next
            valorClaveColoniaFinal = valorClaveColoniaFinal + 1
        Else
            ocultarElementos()
            MsgBox("El codigo postal es erroneo. Asegurese de que este bien escrito o de que el catalago este actualizado", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim msgConfirmacion As Integer
        msgConfirmacion = MsgBox("Esta segur@ que la informacion esta de forma correcta", vbQuestion + vbYesNo + vbDefaultButton2, "Cofirmar informacion")

        If msgConfirmacion = vbYes Then

            Dim insertarColonia As Integer = fn_Agregar_Colonia(idPais,
                                                          claveEstado,
                                                          claveCiudad,
                                                          codigoPostal,
                                                          nombreColonia,
                                                          idEstado,
                                                          idCiudad,
                                                          valorClaveColoniaFinal)
            If insertarColonia = 1 Then
                MsgBox("Colonia agregada correctamente", MsgBoxStyle.Information, frm_MENU.Tag)
            Else
                MsgBox("Lo sentimos la colonia no se pudo agregar, Consulte al area de sistemas", MsgBoxStyle.Critical, frm_MENU.Tag)
            End If
        End If


    End Sub

    Private Sub ocultarElementos()
        ''Titulo
        lbl_TituloPais.Visible = False
        lbl_TituloEstado.Visible = False
        lbl_TituloCiudad.Visible = False
        lbl_TituloColonia.Visible = False
        lbl_TituloCP.Visible = False
        btnGuardar.Visible = False
        lblAviso.Visible = False
        ''Valores
        lblPais.Visible = False
        lblEstado.Visible = False
        lblCiudad.Visible = False
        lblColonia.Visible = False
        lblCP.Visible = False
        ''limpiamos las variables
        lblPais.Text = ""
        lblEstado.Text = ""
        lblCiudad.Text = ""
        lblColonia.Text = ""
        lblCP.Text = ""
        idPais = 0
        claveEstado = ""
        claveCiudad = ""
        codigoPostal = ""
        nombreColonia = ""
        idEstado = 0
        idCiudad = 0
    End Sub

    ''' <summary>
    ''' Este metodo mostrara los label's que contienen la informacion que se va guardar.
    ''' </summary>
    Private Sub MostrarElementos()
        ''Titulo
        lbl_TituloPais.Visible = True
        lbl_TituloEstado.Visible = True
        lbl_TituloCiudad.Visible = True
        lbl_TituloColonia.Visible = True
        lbl_TituloCP.Visible = True
        lblAviso.Visible = True
        ''Valores
        lblPais.Visible = True
        lblEstado.Visible = True
        lblCiudad.Visible = True
        lblColonia.Visible = True
        lblCP.Visible = True

        btnGuardar.Visible = True
        btnGuardar.Enabled = True
    End Sub

    Private Sub tbx_CodigoPostal_Click(sender As Object, e As EventArgs) Handles tbx_CodigoPostal.Click
        btnGuardar.Enabled = False
    End Sub

    Private Sub tbx_NombreColonia_Click(sender As Object, e As EventArgs) Handles tbx_NombreColonia.Click
        btnGuardar.Enabled = False
    End Sub

    Private Sub GuardarColonia()

    End Sub

    Private Sub tbx_NombreColonia_ModifiedChanged(sender As Object, e As EventArgs) Handles tbx_NombreColonia.ModifiedChanged
        btnGuardar.Enabled = False
    End Sub

    Private Sub tbx_NombreColonia_TextChanged(sender As Object, e As EventArgs) Handles tbx_NombreColonia.TextChanged
        btnGuardar.Enabled = False
    End Sub
End Class