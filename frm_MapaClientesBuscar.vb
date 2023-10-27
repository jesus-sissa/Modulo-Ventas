Imports Modulo_Ventas.Cn_Clientes
Imports System.IO

Public Class frm_MapaClientesBuscar

    Private Sub frm_MapaClientesBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        Call LlenarLista()
        Call Mapa()
    End Sub

    Private Sub LlenarLista()
        SegundosDesconexion = 0
        Dim ClienCC As Integer = 0
        Dim ClienSC As Integer = 0
        Dim Total As Integer = 0
        Btn_Mostrar.Enabled = False
        btn_Exportar.Enabled = False
        If fn_ObtenerLatLon(Lsv_Clientes) = False Then
            MsgBox("Error al Cargar los Clientes", MsgBoxStyle.Critical, frm_MENU.Text)
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
        Lbl_ClienSC.Text = "Clientes sin coordenadas: " & ClienSC
        Lbl_ClienCC.Text = "Clientes con coordenadas: " & ClienCC
        Lbl_Total.Text = "Total: " & Total
        If Lsv_Clientes.Items.Count > 0 Then Btn_Mostrar.Enabled = True
        If Lsv_Clientes.Items.Count > 0 Then btn_Exportar.Enabled = True

    End Sub

    Public Sub Mapa()
        SegundosDesconexion = 0
        Dim UrlCoo As String = ""
        Dim Numero As Integer = 0
        Dim NumeroSin As Integer = 0
        Dim Title As String = ""


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

        For Each fila As ListViewItem In Lsv_Clientes.CheckedItems
            If fila.Checked Then
                If fila.SubItems(4).Text <> 0 And fila.SubItems(5).Text <> 0 Then
                    Numero += 1
                    Title = fila.Text & " - " & fila.SubItems(1).Text

                    UrlCoo &= "var marker" & Numero & " = new google.maps.Marker({" & vbCrLf
                    UrlCoo &= "map: map," & vbCrLf
                    UrlCoo &= "position: {lat: " & fila.SubItems(4).Text & ", lng: " & fila.SubItems(5).Text & "}," & vbCrLf
                    UrlCoo &= "title: '" & Title & "'," & vbCrLf
                    UrlCoo &= "animation: google.maps.Animation.DROP" & vbCrLf
                    UrlCoo &= "});" & vbCrLf
                    UrlCoo &= " var infowindow" & Numero & " = new google.maps.InfoWindow({" & vbCrLf
                    UrlCoo &= "content: " & Chr(34) & " <h3>" & Title & "</h3>" & Chr(34) & " + " & Chr(34) & "<div id=\" & Chr(34) & "bodyContent\" & Chr(34) & ">" & Chr(34) & " + " & Chr(34) & "<b>Dirección: </b>" & fila.SubItems(2).Text & "<br><b>Ciudad: </b>" & fila.SubItems(3).Text & "<br><br><b>Latitud: </b>" & fila.SubItems(4).Text & "<br><b>Longitud: </b>" & fila.SubItems(5).Text & Chr(34) & vbCrLf
                    UrlCoo &= "  });" & vbCrLf
                    UrlCoo &= " marker" & Numero & ".addListener('click', function() {" & vbCrLf
                    UrlCoo &= "  infowindow" & Numero & ".open(marker" & Numero & ".get('map'), marker" & Numero & ");" & vbCrLf
                    UrlCoo &= " });" & vbCrLf

                Else
                    NumeroSin += 1
                End If
            End If
        Next

        UrlCoo &= "}" & vbCrLf
        UrlCoo &= "</script>" & vbCrLf
        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "</body>" & vbCrLf
        UrlCoo &= "</html>"

        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "MapaClientes.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaClientes.HTML")

        If NumeroSin > 0 Then
            MsgBox("(" & NumeroSin & ") Clientes no Tienen Coordenadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub ExportarAHTML(ByVal Texto As String, ByVal Direccion As String)
        SegundosDesconexion = 0
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        Dim PathArchivo As String
        Dim i As Integer
        Try
            If Directory.Exists(Direccion) = False Then
                Directory.CreateDirectory(Direccion)
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = "DocApiGoogle.HTML"

            If File.Exists(PathArchivo) Then
                File.Delete(PathArchivo)
            End If
            strStreamW = File.Create(PathArchivo)
            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default)
            strStreamWriter.WriteLine(Texto)
            strStreamWriter.Close()

        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, frm_MENU.Text)
            strStreamWriter.Close()
        End Try
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

    Private Sub Btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Mostrar.Click
        SegundosDesconexion = 0
        Call Mapa()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Todos.CheckedChanged
        SegundosDesconexion = 0
        If Chk_Todos.Checked Then
            For Each T As ListViewItem In Lsv_Clientes.Items
                T.Checked = True
            Next
        Else
            For Each H As ListViewItem In Lsv_Clientes.CheckedItems
                H.Checked = False
            Next
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        Cn_Login.fn_Log_Create("EXPORTAR LISTADO GENERAL DE CLIENTES CON COORDENADAS. " & Lbl_ClienCC.Text & " " & Lbl_ClienSC.Text)
        FuncionesGlobales.fn_Exportar_Excel(Lsv_Clientes, 2, "Coordenadas de Clientes", 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class