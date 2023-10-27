Imports System.IO
Imports System.Drawing.Imaging
Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_CargarArchivos

    '''<summary> Filtro para que sólo se seleccione ciertos tipos de Archivos, Ejemplo: "Documento de Word (*.Doc)|*.Doc|Archivo PDF(*.Pdf)|*.Pdf" </summary>
    Public Filtro As String = "Todos los Archivos(*.*)|*.*"
    '''<summary> El Máximo de Archivos Aceptados </summary>
    Public MaxArchivos As Integer = 1
    '''<summary> El ID del Registro de la Tabla Principal </summary>
    Public Id_Tabla As Integer = Nothing
    '''<summary> El Tipo de Archivo con relación a al Procedimiento, Ejemplo: Empleados, Clientes, Cajas Fuertes, etc. </summary>
    Public Tipo As Query = Query.CajasFuertesInspeccion
    '''<summary> Sirve para Activar o Desactivar el Campo Descripción. </summary>
    Public DescripcionEnable As Boolean = True
    '''<summary> Es el Tamaño Máximo a guardar de las Imagenes (valor en bytes y por default esta a 204800, es decir, 200 Kb). </summary>
    Public TamañoMaxImagen As Integer = 204800
    '''<summary> Es el Tamaño Máximo a guardar de cualquier Archivo (valor en bytes y por default esta a 512000, es decir, 500 Kb). </summary>
    Public TamañoMaxArchivo As Integer = 512000
    '''<summary> Es la Cantidad de Archivos que fueron agregados. (sirve sólo de referencia) </summary>
    Public CantidaArchivos As Integer = 0

    '''<summary> Es el Tag del ListViewItem que guarda la Posición en el Arreglo. </summary>
    Dim TagPosicion As Integer = -1
    '''<summary> Es la posición siguiente para guardar en el Arreglo. </summary>
    Dim Cont As Integer
    Dim Dialogo As New OpenFileDialog
    Dim RutaFinal As String = ""
    Dim RutaTemp As String = Application.StartupPath & "\"

    <Flags()> _
    Enum Query As Byte
        CajasFuertesInspeccion
        DoctosRequeridosCliente
        CajasFuertesValidar
        ClientesFotografias
        ClientesBajas
    End Enum

    Private Sub frm_MenusArchivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dialogo.InitialDirectory = "c:\"

        tbx_Adicional.Width = 264
        tbx_Descripcion.Enabled = DescripcionEnable
        btn_Guardar.Visible = Id_Tabla <> Nothing
        If btn_Guardar.Visible = False Then btn_Exportar.Left = 6 : btn_ExportarTodos.Left = 152
        ' pct_Imagen.Image = My.Resources.LogoSISSA_Tenue

        Select Case Tipo
            Case Query.CajasFuertesInspeccion
                lsv_Archivos.Columns.Add("Nombre")
                lsv_Archivos.Columns.Add("Ruta")
                FuncionesGlobales.fn_Columna(lsv_Archivos, 35, 60, 0, 0, 0, 0, 0, 0, 0, 0)
                If Id_Tabla <> Nothing Then
                    If Not fn_InspeccionImagenes_CargarArreglo(Id_Tabla) Then
                        MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Me.Close()
                    End If
                End If

            Case Query.DoctosRequeridosCliente
                lsv_Archivos.Columns.Add("Documento")
                lsv_Archivos.Columns.Add("Nombre")
                lsv_Archivos.Columns.Add("Ruta")
                FuncionesGlobales.fn_Columna(lsv_Archivos, 30, 25, 40, 0, 0, 0, 0, 0, 0, 0)
                cmb_SFP.StoredProcedure = "Cat_ClientesDoctosR_ComboGet"
                cmb_SFP.ValueMember = "Id_DoctosR"
                cmb_SFP.DisplayMember = "Descripcion"
                cmb_SFP.Empresa = False
                cmb_SFP.Pista = False
                cmb_SFP.Sucursal = False
                cmb_SFP.AgregaParametro("@Status", "A", 0)
                cmb_SFP.Actualizar()
                cmb_SFP.Visible = True
                lbl_ComboSFP.Visible = True
                lbl_Adicional.Visible = False
                tbx_Adicional.Visible = False
                If Not fn_DoctoRequeridosCliente_CargarArreglo(Id_Tabla) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Close()
                End If

            Case Query.ClientesFotografias
                lsv_Archivos.Columns.Add("Nombre")
                lsv_Archivos.Columns.Add("Ruta")
                FuncionesGlobales.fn_Columna(lsv_Archivos, 35, 60, 0, 0, 0, 0, 0, 0, 0, 0)
                If Not fn_ClienteFotografias_CargarArreglo(Id_Tabla) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Close()
                End If

            Case Query.CajasFuertesValidar
                lsv_Archivos.Columns.Add("Nombre")
                lsv_Archivos.Columns.Add("Ruta")
                FuncionesGlobales.fn_Columna(lsv_Archivos, 35, 60, 0, 0, 0, 0, 0, 0, 0, 0)
                If Not fn_CajasFuertesValidar_CargarArreglo(Id_Tabla) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Close()
                End If

            Case Query.ClientesBajas
                lsv_Archivos.Columns.Add("Nombre")
                lsv_Archivos.Columns.Add("Ruta")
                FuncionesGlobales.fn_Columna(lsv_Archivos, 35, 60, 0, 0, 0, 0, 0, 0, 0, 0)
                If Not fn_ClientesBajasI_CargarArreglo(Id_Tabla) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Close()
                End If

        End Select

        If Arreglo_Archivo Is Nothing Then
            Cont = 0
        Else
            Call CargarLista()
            Call ValidarMaximo()
        End If
    End Sub

#Region "FUNCTION'S"

    Sub Limpiar()
        tbx_Nombre.Clear()
        tbx_Ruta.Clear()
        tbx_Extension.Clear()
        tbx_MimeType.Clear()
        tbx_Descripcion.Clear()
        tbx_FileSize.Clear()
        tbx_Adicional.Clear()
        RutaFinal = ""
        cmb_SFP.SelectedValue = "0"
        ' pct_Imagen.Image = My.Resources.LogoSISSA_Tenue
    End Sub

    Sub Botones()
        btn_Agregar.Enabled = tbx_Nombre.TextLength > 0
        btn_Modificar.Enabled = lsv_Archivos.SelectedItems.Count > 0
        btn_Limpiar.Enabled = lsv_Archivos.SelectedItems.Count > 0
        btn_LimpiarTodo.Enabled = lsv_Archivos.Items.Count > 0
        btn_Guardar.Enabled = Arreglo_Archivo IsNot Nothing OrElse lsv_Archivos.Items.Count > 0
        btn_Exportar.Enabled = lsv_Archivos.SelectedItems.Count > 0
        btn_ExportarTodos.Enabled = lsv_Archivos.Items.Count > 0
    End Sub

    Sub VisorImagen()
        If TagPosicion = -1 Then Exit Sub
        If Arreglo_Archivo(TagPosicion).MimeType_Archivo.ToUpper = "image/jpeg".ToUpper Then
            Dim frm As New frm_VisorImagenes
            If Arreglo_Archivo(TagPosicion).Ruta_Archivo <> Nothing Then
                frm.RutaImagen = Arreglo_Archivo(TagPosicion).Ruta_Archivo
            Else
                frm.ImagenBytes = Arreglo_Archivo(TagPosicion).Objeto_Archivo
            End If
            frm.ShowDialog()
        Else
            MsgBox("Este tipo de Archivo se debe de Extraer primero para luego visualizarse.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    '''<summary> Cargar el Listview con la Información del Arreglo. </summary>
    Sub CargarLista()
        lsv_Archivos.Items.Clear()
        If Arreglo_Archivo Is Nothing Then
            Cont = 0
            lsv_Archivos.Enabled = True
            Call Limpiar()
            Call Botones()
            Exit Sub
        End If

        Dim Elem As ListViewItem
        For ILocal As Integer = 0 To UBound(Arreglo_Archivo)
            If Arreglo_Archivo(ILocal).Nombre_Archivo = Nothing Then Continue For
            Select Case Tipo
                Case Query.DoctosRequeridosCliente
                    Elem = lsv_Archivos.Items.Add(Arreglo_Archivo(ILocal).Adicional_Archivo)
                    Elem.SubItems.Add(Arreglo_Archivo(ILocal).Nombre_Archivo)

                Case Else
                    'Para: Inspección, Validar, Fotografías, Baja Clientes
                    'o sino Cuando sólo se agrega del arreglo directamente sin consultas
                    Elem = lsv_Archivos.Items.Add(Arreglo_Archivo(ILocal).Nombre_Archivo)
            End Select

            If Arreglo_Archivo(ILocal).RutaAnt_Archivo = Nothing Then
                Elem.SubItems.Add(Arreglo_Archivo(ILocal).Ruta_Archivo)
            Else
                Elem.SubItems.Add(Arreglo_Archivo(ILocal).RutaAnt_Archivo)
            End If
            Elem.Tag = ILocal 'En el Tag del Item se guarda la Posición en el Arreglo
        Next
        Cont = Arreglo_Archivo.Length
        lsv_Archivos.Enabled = True
        Call Limpiar()
        Call Botones()
    End Sub

    '''<summary> Sirve para seleccionar el Archivo. </summary>
    Sub BuscarArchivo()
        Call Limpiar()
        If cmb_SFP.Visible AndAlso TagPosicion <> -1 Then
            cmb_SFP.SelectedValue = Arreglo_Archivo(TagPosicion).Extension_Archivo
            cmb_SFP.Enabled = False
        End If
        If ValidarMaximo() Then Exit Sub

        Dialogo = New OpenFileDialog With {.Title = "Seleccione un Archivo.", .Filter = Filtro, .Multiselect = False}
        If Dialogo.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            lsv_Archivos.Enabled = True
            'TagPosicion = Nothing 'antes
            TagPosicion = -1 '4-marzo2014
            Exit Sub
        End If

        tbx_Ruta.Text = Dialogo.FileName
        tbx_Extension.Text = Path.GetExtension(tbx_Ruta.Text)

        'Obtener el MimeType desde el Registro de Windows
        Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(tbx_Extension.Text)
        If regKey IsNot Nothing And regKey.GetValue("Content Type") IsNot Nothing Then
            tbx_MimeType.Text = regKey.GetValue("Content Type").ToString()
        Else
            MsgBox("No se pudo Obtener el MimeType del Archivo.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Revisa el tamaño del archivo si es no es una imagen, porque las imagenes se reducen
        If tbx_MimeType.Text.ToUpper <> "image/jpeg".ToUpper Then If Not FileSize() Then Exit Sub

        tbx_Nombre.Text = Path.GetFileName(tbx_Ruta.Text)
        tbx_Descripcion.Enabled = DescripcionEnable

        'Convert File to bytes Array
        Select Case Tipo
            Case Query.DoctosRequeridosCliente
                'No se agrega nada porque el usuario seleccionará del combo
            Case Else
                'Muestra los mismos campos Inspección, Validar, Fotografias y Baja Cliente
                'o sino para cuando el arreglo se llena sin consultas
                If ReadFile(tbx_Ruta.Text).Length > 0 Then tbx_Adicional.Text = "Conversión Correcta" Else tbx_Adicional.Text = "Conversión Incorrecta"
        End Select
        Call Botones()
        If cmb_SFP.Visible Then
            cmb_SFP.Focus()
        ElseIf tbx_Descripcion.Enabled Then
            tbx_Descripcion.Focus()
        ElseIf btn_Agregar.Enabled Then
            btn_Agregar.Focus()
        Else
            btn_Buscar.Focus()
        End If
    End Sub

    Private Function FileSize() As Boolean
        Dim TamañoNuevoMsg As String = ""
        Dim TamañoNuevo As Integer = CInt(fn_TamañoArchivo(tbx_Ruta.Text))

        If TamañoNuevo < 1024 Then 'Tamaño en Bytes
            TamañoNuevoMsg = Format(CDec(TamañoNuevo / 8), "N2") & " Bytes"

        ElseIf TamañoNuevo >= 1024 And TamañoNuevo < 1024000 Then 'Tamaño en Kilobytes
            TamañoNuevoMsg = Format(CDec(TamañoNuevo / 1024), "N2") & " Kb"

        ElseIf TamañoNuevo >= 1024000 And TamañoNuevo < 1024000000 Then 'Tamaño en Megabytes
            TamañoNuevoMsg = Format(CDec(TamañoNuevo / 1024000), "N2") & " Mb"

        Else 'Tamaño en Gygabytes
            TamañoNuevoMsg = Format(CDec(TamañoNuevo / 1024000000), "N2") & " Gb"
        End If

        If tbx_MimeType.Text.ToUpper <> "image/jpeg".ToUpper Then
            Dim TamañoArchivoMsg As String = ""

            If TamañoMaxArchivo < 1024 Then 'Tamaño en Bytes
                TamañoArchivoMsg = Format(CDec(TamañoMaxArchivo / 8), "N2") & " Bytes"

            ElseIf TamañoMaxArchivo >= 1024 And TamañoMaxArchivo < 1024000 Then 'Tamaño en Kilobytes
                TamañoArchivoMsg = Format(CDec(TamañoMaxArchivo / 1024), "N2") & " Kb"

            Else 'Tamaño en Megabytes
                TamañoArchivoMsg = Format(CDec(TamañoMaxArchivo / 1024000), "N2") & " Mb"
            End If

            If TamañoNuevo > TamañoMaxArchivo Then
                MsgBox("El Archivo seleccionado pesa: " & TamañoNuevoMsg & " y no debe ser mayor que: " & TamañoArchivoMsg, MsgBoxStyle.Critical, frm_MENU.Text)
                lsv_Archivos.Enabled = True
                lsv_Archivos.SelectedItems.Clear()
                Call Limpiar()
                Return False
            End If
        End If

        tbx_FileSize.Text = TamañoNuevoMsg
        Return True
    End Function

    '''<summary> Valida si ya se encuentran agregados el Máximo de Arhivos. </summary>
    Private Function ValidarMaximo() As Boolean
        If lsv_Archivos.Enabled Then
            If lsv_Archivos.Items.Count = MaxArchivos Then
                MsgBox("El Máximo de Archivos permitidos a Ingresar son: " & MaxArchivos.ToString, MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Descripcion.Enabled = False
                btn_Buscar.Enabled = False
                Return True
            End If
        End If
        Return False
    End Function

    '''<summary> Convertir el Archivo a Arreglo de Bytes. </summary>
    Private Function ReadFile(ByVal Ruta As String) As Byte()
        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Dim fInfo As New FileInfo(Ruta)
        Dim numBytes As Long = fInfo.Length

        'Open FileStream to read file 
        Dim fStream As New FileStream(Ruta, FileMode.Open, FileAccess.Read)

        'Use BinaryReader to read file stream into byte array. 
        Dim br As New BinaryReader(fStream)

        'When you use BinaryReader, you need to supply number of bytes to read from file. 
        'In this case we want to read entire file. So supplying total number of bytes. 
        data = br.ReadBytes(CInt(numBytes))
        br = Nothing

        Return data
    End Function

#End Region

    Private Sub lsv_Archivos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Archivos.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Archivos.SelectedItems.Count > 0 Then
            TagPosicion = lsv_Archivos.SelectedItems(0).Tag
            tbx_Descripcion.Enabled = False
            cmb_SFP.Enabled = False
            btn_Agregar.Enabled = False

            tbx_Nombre.Text = Arreglo_Archivo(TagPosicion).Nombre_Archivo
            If Arreglo_Archivo(TagPosicion).RutaAnt_Archivo = Nothing Then
                tbx_Ruta.Text = Arreglo_Archivo(TagPosicion).Ruta_Archivo
            Else
                tbx_Ruta.Text = Arreglo_Archivo(TagPosicion).RutaAnt_Archivo
            End If
            tbx_MimeType.Text = Arreglo_Archivo(TagPosicion).MimeType_Archivo
            Call FileSize()
            tbx_Descripcion.Text = Arreglo_Archivo(TagPosicion).Descripcion_Archivo
            tbx_Extension.Text = Path.GetExtension(tbx_Ruta.Text)

            'Dependiendo del Caso es lo que se mostrará en adicional.
            Select Case Tipo
                Case Query.DoctosRequeridosCliente
                    'Guarda el Id del documento en Extension y en Adicional el Texto mostrado en el combo
                    cmb_SFP.SelectedValue = Arreglo_Archivo(TagPosicion).Extension_Archivo
                Case Else
                    'Se agregan los mismos valores para Inspección, Validar, Fotografías y Baja Clientes
                    'o sino para un arreglo sin consultas
                    tbx_Adicional.Text = Arreglo_Archivo(TagPosicion).Adicional_Archivo
            End Select

            If Arreglo_Archivo(TagPosicion).MimeType_Archivo.ToUpper = "image/jpeg".ToUpper Then
                Dim ms_Imagen As MemoryStream = New MemoryStream(Arreglo_Archivo(TagPosicion).Objeto_Archivo, 0, Arreglo_Archivo(TagPosicion).Objeto_Archivo.Length)
                ms_Imagen.Write(Arreglo_Archivo(TagPosicion).Objeto_Archivo, 0, Arreglo_Archivo(TagPosicion).Objeto_Archivo.Length)
                pct_Imagen.Image = Image.FromStream(ms_Imagen, True)
                ms_Imagen.Dispose()
            Else
                ' pct_Imagen.Image = My.Resources.LogoSISSA_Tenue
            End If
            Call Botones()
        Else
            TagPosicion = -1
            'pct_Imagen.Image = My.Resources.LogoSISSA_Tenue
            cmb_SFP.Enabled = True
            Call Limpiar()
            Call Botones()
            tbx_Descripcion.Enabled = DescripcionEnable
        End If
    End Sub

    Private Sub lsv_Archivos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Archivos.DoubleClick
        SegundosDesconexion = 0

        Call VisorImagen()
    End Sub

    Private Sub pct_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Imagen.Click
        SegundosDesconexion = 0

        If TagPosicion = -1 Then Exit Sub
        If Arreglo_Archivo IsNot Nothing Then If Arreglo_Archivo(TagPosicion).MimeType_Archivo.ToUpper = "image/jpeg".ToUpper Then Call VisorImagen()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Call BuscarArchivo()
    End Sub

    Private Sub cmb_SFP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_SFP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0

            If tbx_Descripcion.Enabled Then
                tbx_Descripcion.Focus()
            Else
                btn_Agregar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        Try
            If cmb_SFP.Visible AndAlso cmb_SFP.SelectedValue = "0" Then
                MsgBox("Seleccione al Tipo de Documento que se agregará.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_SFP.Focus()
                Exit Sub
            End If

            If lsv_Archivos.Enabled Then
                Select Case Tipo
                    Case Query.DoctosRequeridosCliente
                        If Arreglo_Archivo IsNot Nothing Then
                            For ILocal As Integer = 0 To UBound(Arreglo_Archivo)
                                If Arreglo_Archivo(ILocal).Extension_Archivo = cmb_SFP.SelectedValue Then
                                    MsgBox("El Tipo de Documento que desea agregar ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            Next
                        End If
                End Select
            End If

            'Si Listview Activo significa Nuevo sino Modificar Registro
            Dim AgregaPorPosicion As Integer
            If lsv_Archivos.Enabled Then
                AgregaPorPosicion = Cont
                ReDim Preserve Arreglo_Archivo(Cont)
            Else
                AgregaPorPosicion = TagPosicion
            End If

            If tbx_MimeType.Text.ToUpper = "image/jpeg".ToUpper Then
                If lsv_Archivos.Enabled Then
                    'Elimar la imagen si existía para cambiarla
                    If File.Exists(RutaTemp & "IMAGEN" & AgregaPorPosicion + 1 & ".jpg") Then Kill(RutaTemp & "IMAGEN" & AgregaPorPosicion + 1 & ".jpg")
                End If
                Dim Imagen As Image
                'Extraer imagenes a la carpeta temporal.
                Imagen = Image.FromFile(tbx_Ruta.Text)
                RutaFinal = fn_ReducirImagen("IMAGEN" & AgregaPorPosicion + 1, Imagen, TamañoMaxImagen, 30, RutaTemp, 800, 600)
                Imagen.Dispose()
            End If

            Dim FileBytes As Byte()
            If RutaFinal = "" Then
                FileBytes = ReadFile(tbx_Ruta.Text)
            Else
                FileBytes = ReadFile(RutaFinal)
            End If
            'Validar si el Archivo Existe
            For ILocal As Integer = 0 To UBound(Arreglo_Archivo)
                If Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then Continue For
                If Convert.ToBase64String(Arreglo_Archivo(ILocal).Objeto_Archivo) = Convert.ToBase64String(FileBytes) Then
                    If MsgBox("El Archivo ya existe, Desea Agregarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                        FileBytes = Nothing
                        Exit For
                    Else
                        FileBytes = Nothing
                        'Se redimensiona el arreglo cuando se iba a Agregar un nuevo registro al Arreglo
                        If lsv_Archivos.Enabled And Cont > 0 Then ReDim Preserve Arreglo_Archivo(Cont - 1)
                        Call Limpiar()
                        Call Botones()
                        If File.Exists(RutaTemp & "IMAGEN" & AgregaPorPosicion + 1 & ".jpg") Then Kill(RutaTemp & "IMAGEN" & AgregaPorPosicion + 1 & ".jpg")
                        Exit Sub
                    End If
                End If
            Next

            If RutaFinal = "" Then
                Arreglo_Archivo(AgregaPorPosicion).Nombre_Archivo = tbx_Nombre.Text
                Arreglo_Archivo(AgregaPorPosicion).Ruta_Archivo = tbx_Ruta.Text
                Arreglo_Archivo(AgregaPorPosicion).FileSize_Archivo = fn_TamañoArchivo(tbx_Ruta.Text)
                Arreglo_Archivo(AgregaPorPosicion).Objeto_Archivo = ReadFile(tbx_Ruta.Text)
            Else
                Arreglo_Archivo(AgregaPorPosicion).Nombre_Archivo = Path.GetFileName(RutaFinal)
                Arreglo_Archivo(AgregaPorPosicion).Ruta_Archivo = RutaFinal
                Arreglo_Archivo(AgregaPorPosicion).RutaAnt_Archivo = tbx_Ruta.Text
                Arreglo_Archivo(AgregaPorPosicion).FileSize_Archivo = fn_TamañoArchivo(RutaFinal)
                Arreglo_Archivo(AgregaPorPosicion).Objeto_Archivo = ReadFile(RutaFinal)
            End If
            Arreglo_Archivo(AgregaPorPosicion).MimeType_Archivo = tbx_MimeType.Text
            Arreglo_Archivo(AgregaPorPosicion).Descripcion_Archivo = tbx_Descripcion.Text

            'Dependiendo del Caso es lo que se guardará en adicional.
            Select Case Tipo
                Case Query.DoctosRequeridosCliente
                    'Guarda el Id del documento en Extension y en Adicional el Texto mostrado en el combo
                    Arreglo_Archivo(AgregaPorPosicion).Extension_Archivo = cmb_SFP.SelectedValue
                    Arreglo_Archivo(AgregaPorPosicion).Adicional_Archivo = cmb_SFP.Text

                Case Else
                    'Se agregan los mismos valores para Inspección, Validar, Fotografías y Baja Clientes
                    'o sino para un arreglo sin consultas
                    Arreglo_Archivo(AgregaPorPosicion).Extension_Archivo = tbx_Extension.Text
                    Arreglo_Archivo(AgregaPorPosicion).Adicional_Archivo = tbx_Adicional.Text
            End Select

            Call CargarLista()
        Catch
            MsgBox("No se pudo Agregar el Archivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            'Se redimensiona el arreglo cuando se iba a Agregar un nuevo registro al Arreglo
            If lsv_Archivos.Enabled And Cont > 0 Then ReDim Preserve Arreglo_Archivo(Cont - 1)
        End Try
        cmb_SFP.Enabled = cmb_SFP.Visible
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        SegundosDesconexion = 0

        lsv_Archivos.Enabled = False
        btn_Agregar.Enabled = False
        btn_Limpiar.Enabled = False
        btn_LimpiarTodo.Enabled = False
        Call BuscarArchivo()
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        SegundosDesconexion = 0

        Call Limpiar()
        Try
            Arreglo_Archivo(TagPosicion).Nombre_Archivo = Nothing
            Arreglo_Archivo(TagPosicion).Ruta_Archivo = Nothing
            Arreglo_Archivo(TagPosicion).Extension_Archivo = Nothing
            Arreglo_Archivo(TagPosicion).Descripcion_Archivo = Nothing
            Arreglo_Archivo(TagPosicion).FileSize_Archivo = Nothing
            Arreglo_Archivo(TagPosicion).Objeto_Archivo = Nothing
            Arreglo_Archivo(TagPosicion).Adicional_Archivo = Nothing
            If Arreglo_Archivo(TagPosicion).MimeType_Archivo.ToUpper = "image/jpeg".ToUpper Then
                If File.Exists(RutaTemp & "IMAGEN" & TagPosicion + 1 & ".jpg") Then Kill(RutaTemp & "IMAGEN" & TagPosicion + 1 & ".jpg")
            End If
            Arreglo_Archivo(TagPosicion).MimeType_Archivo = Nothing
        Catch
        End Try
        Call CargarLista()
    End Sub

    Private Sub btn_LimpiarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarTodo.Click
        SegundosDesconexion = 0

        Call Limpiar()
        'Si es un arreglo nuevo se reinicia el arreglo sino pone los campos en nothing
        Dim ArregloNuevo As Boolean = True
        Try
            For ILocal As Integer = 0 To UBound(Arreglo_Archivo)
                If Arreglo_Archivo(ILocal).Id_Archivo <> Nothing Then
                    ArregloNuevo = False
                End If
                If Arreglo_Archivo(ILocal).MimeType_Archivo.ToUpper = "image/jpeg".ToUpper Then
                    If File.Exists(RutaTemp & "IMAGEN" & (ILocal + 1) & ".jpg") Then Kill(RutaTemp & "IMAGEN" & (ILocal + 1) & ".jpg")
                End If
            Next
        Catch
        End Try
        If ArregloNuevo Then
            Arreglo_Archivo = Nothing
        Else
            For ILocal As Integer = 0 To UBound(Arreglo_Archivo)
                Arreglo_Archivo(ILocal).Nombre_Archivo = Nothing
                Arreglo_Archivo(ILocal).Ruta_Archivo = Nothing
                Arreglo_Archivo(ILocal).Extension_Archivo = Nothing
                Arreglo_Archivo(ILocal).MimeType_Archivo = Nothing
                Arreglo_Archivo(ILocal).Descripcion_Archivo = Nothing
                Arreglo_Archivo(ILocal).FileSize_Archivo = Nothing
                Arreglo_Archivo(ILocal).Objeto_Archivo = Nothing
                Arreglo_Archivo(ILocal).Adicional_Archivo = Nothing
            Next
        End If

        Call CargarLista()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim NoGuardado As Boolean = False
        Select Case Tipo
            Case Query.CajasFuertesInspeccion
                If Not fn_InspeccionImagenes_Actualizar(Id_Tabla) Then
                    NoGuardado = True
                End If

            Case Query.DoctosRequeridosCliente
                If Not fn_DoctoRequeridosCliente_Actualizar(Id_Tabla) Then
                    NoGuardado = True
                End If

            Case Query.CajasFuertesValidar
                If Not fn_CajasFuertesValidar_Actualizar(Id_Tabla) Then
                    NoGuardado = True
                End If

            Case Query.ClientesFotografias
                If Not fn_ClienteFotografias_Actualizar(Id_Tabla) Then
                    NoGuardado = True
                End If

            Case Query.ClientesBajas
                If Not fn_ClientesBajasI_Actualizar(Id_Tabla) Then
                    NoGuardado = True
                End If
        End Select

        If NoGuardado Then
            MsgBox("Ha ocurrido un error al intentar Guardar los Archivos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Arreglo_Archivo = Nothing
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog With {.Description = "Destino del Archivo.", .ShowNewFolderButton = True}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim CarpetaDestino As String = Dialogo.SelectedPath
        'Tomando en cuenta que el nombre del archivo a guardar no tiene extensión
        If CarpetaDestino.Length = 3 Then
            CarpetaDestino = CarpetaDestino & Arreglo_Archivo(TagPosicion).Nombre_Archivo
        Else
            CarpetaDestino = CarpetaDestino & "\" & Arreglo_Archivo(TagPosicion).Nombre_Archivo
        End If

        Try
            Using fs As New FileStream(CarpetaDestino, FileMode.OpenOrCreate, FileAccess.Write)
                fs.Write(Arreglo_Archivo(TagPosicion).Objeto_Archivo, 0, Arreglo_Archivo(TagPosicion).Objeto_Archivo.Length)
                'Set image variable value using memory stream. 
                fs.Flush()
                fs.Close()
            End Using

            'Open File
            If MsgBox("El Archivo se descargó correctamente. Desea Abrirlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                Process.Start(CarpetaDestino)
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar guardar el Archivo. " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExportarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarTodos.Click
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog With {.Description = "Destino de los Archivos.", .ShowNewFolderButton = True}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim CarpetaDestino As String = Dialogo.SelectedPath
        'Tomando en cuenta que el nombre del archivo a guardar no tiene extensión
        If CarpetaDestino.Length <= 3 Then
            MsgBox("Seleccione una Carpeta Válida para la Extracción de los Archivos.", MsgBoxStyle.Exclamation, frm_MENU.Text)
            Exit Sub
        Else
            CarpetaDestino = CarpetaDestino & "\"
        End If

        Try
            Dim fs As FileStream
            For Each Elemento As ListViewItem In lsv_Archivos.Items
                fs = New FileStream(CarpetaDestino & Arreglo_Archivo(Elemento.Tag).Nombre_Archivo, FileMode.OpenOrCreate, FileAccess.Write)
                fs.Write(Arreglo_Archivo(Elemento.Tag).Objeto_Archivo, 0, Arreglo_Archivo(Elemento.Tag).Objeto_Archivo.Length)
                'Set image variable value using memory stream. 
                fs.Flush()
                fs.Dispose()
            Next
            MsgBox("Los Archivos se descargaron correctamente", MsgBoxStyle.Information, frm_MENU.Text)
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar guardar los Archivos. " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

#Region "CERRAR/CLOSE"

    Private Sub frm_CargarArchivos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar()) = Keys.Escape Then
            SegundosDesconexion = 0

            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_CargarArchivos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CantidaArchivos = lsv_Archivos.Items.Count
        pct_Imagen.Image = Nothing

        If btn_Guardar.Visible AndAlso Arreglo_Archivo IsNot Nothing Then
            For JLocal As Integer = 0 To Arreglo_Archivo.Length - 1
                'Revisa si Existe un archivo que no se haya guardado o
                'Un archivo existente en base de datos que se desee eliminar
                'Si se modifico un archivo no se puede validar.
                If (Arreglo_Archivo(JLocal).Id_Archivo = Nothing AndAlso Arreglo_Archivo(JLocal).Objeto_Archivo IsNot Nothing) OrElse (Arreglo_Archivo(JLocal).Id_Archivo <> Nothing AndAlso Arreglo_Archivo(JLocal).Objeto_Archivo Is Nothing) Then
                    If MsgBox("Se generaron movimientos sin Guardar, Desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                        e.Cancel = True
                        Exit Sub
                    Else
                        Exit For
                    End If
                End If
            Next JLocal

            Arreglo_Archivo = Nothing
        End If
        Try
            For ILocal As Integer = 0 To MaxArchivos
                If File.Exists(RutaTemp & "IMAGEN" & (ILocal + 1) & ".jpg") Then Kill(RutaTemp & "IMAGEN" & (ILocal + 1) & ".jpg")
            Next
        Catch
        End Try
    End Sub

#End Region

End Class