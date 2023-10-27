Imports System.IO
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_MapaClientes
    Dim LatitudE As Decimal
    Dim LongitudE As Decimal
    Dim PendientesGuardar As Integer = 0

    Private Sub frm_MapaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        Call LlenarLista()
        Call Mapa()
    End Sub

    Private Sub LlenarLista()
        SegundosDesconexion = 0
        Dim ClienCC As Integer = 0
        Dim ClienSC As Integer = 0
        Dim Total As Integer = 0
        If fn_ObtenerLatLon(Lsv_Clientes) = False Then
            MsgBox("Error al Cargar los Clientes", MsgBoxStyle.Critical, frm_Menu.Text)
            Exit Sub
        End If
        For Each W As ListViewItem In Lsv_Clientes.Items
            If CDec(W.SubItems(4).Text) <> 0 And CDec(W.SubItems(5).Text) <> 0 Then
                W.BackColor = Color.LightGreen
                ClienCC += 1
            End If
        Next
        ClienSC = Lsv_Clientes.Items.Count - ClienCC
        Total = Lsv_Clientes.Items.Count
        Lbl_ClienSC.Text = "Clientes sin Coordenadas: " & ClienSC
        Lbl_ClienCC.Text = "Clientes con Coordenadas: " & ClienCC
        Lbl_Total.Text = "Total: " & Total

    End Sub

    Private Sub CrearArchivoHTML(ByVal Texto As String, ByVal RutaDisco As String, ByVal NombreArchivo As String)
        SegundosDesconexion = 0
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        Dim PathArchivo As String

        Try
            If Directory.Exists(RutaDisco) = False Then
                Directory.CreateDirectory(RutaDisco)
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = NombreArchivo

            If File.Exists(PathArchivo) Then
                File.Delete(PathArchivo)
            End If
            strStreamW = File.Create(PathArchivo)

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default)
            strStreamWriter.WriteLine(Texto)
            strStreamWriter.Close()

        Catch ex As Exception
            MsgBox("Error al Guardar la información en el archivo." & ex.ToString, MsgBoxStyle.Critical, frm_MENU.Text)
            strStreamWriter.Close()
        End Try
    End Sub

    Public Sub Mapa()
        SegundosDesconexion = 0
        Dim UrlCoo As String = ""

        Dim Title As String = "Arrastre para ubicar al Cliente"

        UrlCoo = "<!DOCTYPE html>" & vbCrLf & _
                "<html>" & vbCrLf & _
                "<head>" & vbCrLf & _
                "<meta http-equiv=" & Chr(34) & "X-UA-Compatible" & Chr(34) & " content=" & Chr(34) & "IE=8" & Chr(34) & ">" & vbCrLf & _
                "<style>" & vbCrLf & _
                "html, body {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "margin: 0;" & vbCrLf & _
                "padding: 0;" & vbCrLf & _
                "}" & vbCrLf & _
                "#map {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "}" & vbCrLf & _
                "</style>" & vbCrLf & _
                "</head>" & vbCrLf & _
                "<body>" & vbCrLf & _
                "<div id=" & Chr(34) & "map" & Chr(34) & "></div>" & vbCrLf & _
                "<script>" & vbCrLf & _
                " function initMap() {" & vbCrLf & _
                "var map = new google.maps.Map(document.getElementById('map'), {" & vbCrLf & _
                "center: {lat:  " & SucursalLat & ", lng: " & SucursalLon & "}," & vbCrLf & _
                "scrollwheel: true," & vbCrLf & _
                "zoom: 12" & vbCrLf & _
                "});" & vbCrLf

        UrlCoo &= "var marker1= new google.maps.Marker({" & vbCrLf
        UrlCoo &= "map: map," & vbCrLf
        UrlCoo &= "position: {lat: " & SucursalLat & ", lng: " & SucursalLon & "}," & vbCrLf
        UrlCoo &= "title: '" & Title & "'," & vbCrLf
        UrlCoo &= "draggable: true," & vbCrLf
        UrlCoo &= "animation: google.maps.Animation.DROP" & vbCrLf
        UrlCoo &= "});" & vbCrLf

        UrlCoo &= " marker1.addListener('dragend', function(evento) {" & vbCrLf
        UrlCoo &= "var latitud = evento.latLng.lat();" & vbCrLf
        UrlCoo &= "var longitud = evento.latLng.lng();" & vbCrLf
        UrlCoo &= "document.getElementById('latitud').value = latitud;" & vbCrLf
        UrlCoo &= "document.getElementById('longitud').value = longitud;" & vbCrLf
        UrlCoo &= "var coordenadas = evento.latLng.lat() + ', ' + evento.latLng.lng();" & vbCrLf
        UrlCoo &= "var coordenadas = new google.maps.LatLng(latitud, longitud);" & vbCrLf
        UrlCoo &= "});" & vbCrLf

        UrlCoo &= "}" & vbCrLf
        UrlCoo &= "</script>" & vbCrLf
        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "<input type='hidden' id='latitud'> " & vbCrLf
        UrlCoo &= "<input type='hidden' id='longitud'>" & vbCrLf
        UrlCoo &= "</body>" & vbCrLf
        UrlCoo &= "</html>"

        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "DocApiGoogle.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/DocApiGoogle.HTML")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        If PendientesGuardar > 0 Then
            If MsgBox("Tiene registros que no ha guardado. Desea cerrar la ventana de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If

        End If

        Me.Close()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        SegundosDesconexion = 0
        Dim Cantidad As Integer = 0
        For Each R As ListViewItem In Lsv_Clientes.Items
            If R.SubItems(1).Tag = "E" Then
                If fn_GuardarLatLon(R.Tag, CDec(R.SubItems(4).Text), CDec(R.SubItems(5).Text)) = False Then
                    MsgBox("Error al Guardar los Registros", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                Else
                    R.ForeColor = Color.Black
                    R.BackColor = Color.LightGreen
                End If
                Cantidad += 1
            End If
        Next
        PendientesGuardar = 0
        MsgBox("Se guardaron " & Cantidad.ToString & " Registros.", MsgBoxStyle.Information, frm_MENU.Text)
        Call LlenarLista()
    End Sub

    Private Sub Lsv_Clientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Clientes.DoubleClick
        SegundosDesconexion = 0
        Dim LatitudI As String = ""
        Dim LongitudI As String = ""
        Dim PosicionValue As Integer = 0
        If Lsv_Clientes.SelectedItems.Count > 0 Then
            Spt_MapaLsv.Panel2.Enabled = True
            'sacar el HTML de los objetos Latitud y Longitud
            LatitudI = Web_Mapa.Document.GetElementById("Latitud").OuterHtml
            LongitudI = Web_Mapa.Document.GetElementById("Longitud").OuterHtml
            'Sacar la Latitud
            PosicionValue = InStr(LatitudI, "value=") + 6
            LatitudE = Mid(LatitudI, PosicionValue, 12)
            'Sacar la Longitud
            PosicionValue = InStr(LongitudI, "value=") + 6
            LongitudE = Mid(LongitudI, PosicionValue, 13)
            
            Lsv_Clientes.SelectedItems(0).SubItems(4).Text = LatitudE
            Lsv_Clientes.SelectedItems(0).SubItems(5).Text = LongitudE
            Lsv_Clientes.SelectedItems(0).ForeColor = Color.Red
            Lsv_Clientes.SelectedItems(0).BackColor = Color.White
            Lsv_Clientes.SelectedItems(0).SubItems(1).Tag = "E"

            PendientesGuardar += 1

            MsgBox("Coordenadas obtenias para " & Lsv_Clientes.SelectedItems(0).SubItems(1).Text & vbCr & vbCr & "Latitud: " & LatitudE.ToString & vbCr & "Longitud: " & LongitudE.ToString, MsgBoxStyle.Information, frm_MENU.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ayuda.Click
        SegundosDesconexion = 0
        Dim frm As New frm_Ayuda
        'Cuando exista un Horario Activo se insertará como Horario Temporal para su validación, tanto como el Cliente Principal como sus Sucursales.
        frm.rtb_Ayuda.Text = "Detalles Generales:" & Chr(13) & Chr(13) & _
                             " 1. Arrastrar el Marcador hasta la ubicación del Cliente en el Mapa." & Chr(13) & _
                             " 2. Hacer DobleClic al Cliente(en la lista) que se desea Asignar las " & Chr(13) & _
                             "    Coordenadas (los Clientes con fondo blanco no tiene coordenadas)." & Chr(13) & _
                             " 3. SI las coordenadas se asignaron correctamente, el cliente " & Chr(13) & _
                             "    cambiará a color Rojo" & Chr(13) & _
                             " 4. Al terminar de asignar todas las coordenadas deseadas debe hacer" & Chr(13) & _
                             "    Clic al boton Guardar. Al volver a cargarse la lista, los " & Chr(13) & Chr(13) & _
                             "    clientes aparecerán con fondo verde" & Chr(13) & Chr(13) & _
                             " *Las coordenadas Pueden ser editas tantas veces como sea nacesario"
        frm.Size = New Size(500, 380)
        frm.Show()
    End Sub
End Class
