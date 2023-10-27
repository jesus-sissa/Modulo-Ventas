Imports System.IO
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_MapaRutas
    'Tipo = 1 - Origen a Punto
    'Tipo = 2 - Punto a Punto
    Dim Tipo As Integer = 0

    Private Sub frm_MapaRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        Call LlenarListas()
        Call MapaLimpio()
    End Sub

    Private Sub LlenarListas()
        SegundosDesconexion = 0
        If fn_ObtenerLatLon(Lsv_ClientesOri) = False Then
            MsgBox("Error al Cargar los Clientes Origen", MsgBoxStyle.Critical, frm_Menu.Text)
            Exit Sub
        End If
        If fn_ObtenerLatLon(Lsv_ClientesDes) = False Then
            MsgBox("Error al Cargar los Clientes Destino", MsgBoxStyle.Critical, frm_Menu.Text)
            Exit Sub
        End If
        Lbl_TotalOri.Text = "Total: " & Lsv_ClientesOri.Items.Count
        Lbl_TotalDes.Text = "Total: " & Lsv_ClientesDes.Items.Count
    End Sub

    Private Sub MapaLimpio()
        SegundosDesconexion = 0
        Dim UrlCoo As String = ""
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
        UrlCoo &= "}" & vbCrLf
        UrlCoo &= "</script>" & vbCrLf
        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "</body>" & vbCrLf
        UrlCoo &= "</html>"

        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "MapaRuta.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaRuta.HTML")
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

    Private Sub Mapa()
        SegundosDesconexion = 0
        Dim Url_mapa As String = ""


        Url_mapa = "<!DOCTYPE html>" & vbCrLf & _
                    "<html>" & vbCrLf & _
                    "<head>" & vbCrLf & _
                    "<meta http-equiv=" & Chr(34) & "X-UA-Compatible" & Chr(34) & " content=" & Chr(34) & "IE=edge" & Chr(34) & ">" & vbCrLf & _
                    "<meta name='viewport' content='initial-scale=1.0, user-scalable=no'>" & vbCrLf & _
                    "<meta charset='utf-8'>" & vbCrLf & _
                    "<title>Localizar Rutas</title>" & vbCrLf
        'Url_mapa &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&sensor=false" & Chr(34) & " async defer></script>" & vbCrLf
        Url_mapa &= "<script src='https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&sensor=false'></script>" & vbCrLf
        Url_mapa &= "<script>" & vbCrLf & _
                    "var rendererOptions = {draggable: true};" & vbCrLf & _
                    "var directionsDisplay = new google.maps.DirectionsRenderer(rendererOptions);;" & vbCrLf & _
                    "var directionsService = new google.maps.DirectionsService();" & vbCrLf & _
                    "var map;" & vbCrLf & _
                    "var Sucursal = new google.maps.LatLng(25.678500,-100.323760);" & vbCrLf & _
                    "function initialize() {" & vbCrLf & _
                    "var mapOptions = {" & vbCrLf & _
                    "zoom: 7," & vbCrLf & _
                    "center: Sucursal," & vbCrLf & _
                    "mapTypeId: 'roadmap'" & vbCrLf & _
                    "};" & vbCrLf & _
                    "map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);" & vbCrLf & _
                    "directionsDisplay.setMap(map);" & vbCrLf & _
                    "directionsDisplay.setPanel(document.getElementById('directionsPanel'));" & vbCrLf & _
                    "google.maps.event.addListener(directionsDisplay, 'directions_changed', function() {" & vbCrLf & _
                    "computeTotalDistance(directionsDisplay.getDirections());" & vbCrLf & _
                    "});" & vbCrLf & _
                    "calcRoute();" & vbCrLf & _
                    "}" & vbCrLf & _
                    ""
        If Tipo = 1 Then
            Url_mapa &= "function calcRoute() {" & vbCrLf & _
                    "var request = {" & vbCrLf & _
                    "origin: new google.maps.LatLng(" & Lsv_ClientesOri.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesOri.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "destination: new google.maps.LatLng(" & Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "travelMode: google.maps.TravelMode.DRIVING" & vbCrLf & _
                    "};" & vbCrLf & _
                    ""
        ElseIf Tipo = 2 Then
            Url_mapa &= "function calcRoute() {" & vbCrLf & _
                    "var request = {" & vbCrLf & _
                    "origin: new google.maps.LatLng(" & SucursalLat & "," & SucursalLon & ")," & vbCrLf & _
                    "destination: new google.maps.LatLng(" & Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "travelMode: google.maps.TravelMode.DRIVING" & vbCrLf & _
                    "};" & vbCrLf & _
                    ""
        End If
        Url_mapa &= "directionsService.route(request, function(response, status) {" & vbCrLf & _
                "if (status == google.maps.DirectionsStatus.OK) {" & vbCrLf & _
                "directionsDisplay.setDirections(response)" & vbCrLf & _
                "}" & vbCrLf & _
                "});" & vbCrLf & _
                "}" & vbCrLf & _
                "function computeTotalDistance(result) {" & vbCrLf & _
                "var total = 0;" & vbCrLf & _
                "var myroute = result.routes[0];" & vbCrLf & _
                "for (var i = 0; i < myroute.legs.length; i++) {" & vbCrLf & _
                "total += myroute.legs[i].distance.value;" & vbCrLf & _
                "}" & vbCrLf & _
                "total = total / 1000.0;" & vbCrLf & _
                "document.getElementById('total').innerHTML = total + ' km';" & vbCrLf & _
                "}" & vbCrLf & _
                "google.maps.event.addDomListener(window, 'load', initialize);" & vbCrLf & _
                "</script>" & vbCrLf & _
                "</head>" & vbCrLf & _
                "<body>" & vbCrLf & _
                "<div id='map-canvas' style='float:left;margin:0px;padding:0px;width:69%; height:" & Web_Mapa.Height - 20 & "px'></div>" & vbCrLf & _
                "<div id='directionsPanel' style='float:right;margin:0px;padding:0px;width:29%;height:" & Web_Mapa.Height - 20 & "px;overflow-y: scroll;'>" & vbCrLf & _
                "<p>Total Distance: <span id='total'></span></p>" & vbCrLf & _
                "</div>" & vbCrLf & _
                "</body>" & vbCrLf & _
            "</html>"

        '"<style>" & vbCrLf & _
        '"html, body, #map-canvas {" & vbCrLf & _
        '"height: 100%;" & vbCrLf & _
        '"margin: 0px;" & vbCrLf & _
        '"padding: 0px" & vbCrLf & _
        '"}" & vbCrLf & _
        '"</style>" & vbCrLf
        Call CrearArchivoHTML(Url_mapa, Application.StartupPath, "MapaRuta.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaRuta.HTML")
    End Sub

    Sub Mapa_Respaldo()
        SegundosDesconexion = 0
        Dim Url_mapa As String = ""
        SucursalLat = "25.678500"
        SucursalLon = "-100.323760"
        Url_mapa = "<!DOCTYPE html>" & vbCrLf & _
                    "<html>" & vbCrLf & _
                    "<head>" & vbCrLf & _
                    "<meta name='viewport' content='initial-scale=1.0, user-scalable=no'>" & vbCrLf & _
                    "<meta charset='utf-8'>" & vbCrLf & _
                    "<title>Programacion de Rutas</title>" & vbCrLf & _
                    "<style>" & vbCrLf & _
                    "html, body, #map-canvas {" & vbCrLf & _
                    "height: 100%;" & vbCrLf & _
                    "margin: 0px;" & vbCrLf & _
                    "padding: 0px" & vbCrLf & _
                    "}" & vbCrLf & _
                    "</style>" & vbCrLf & _
                    "<script src='http://maps.googleapis.com/maps/api/js?key=AIzaSyA6CoAsABBo2hDDGVZleYm54XcJ0R9vgjk&sensor=false'></script>" & vbCrLf & _
                    "<script>" & vbCrLf & _
                    "var rendererOptions = {" & vbCrLf & _
                    "draggable: true" & vbCrLf & _
                    "};" & vbCrLf & _
                    "var directionsDisplay = new google.maps.DirectionsRenderer(rendererOptions);;" & vbCrLf & _
                    "var directionsService = new google.maps.DirectionsService();" & vbCrLf & _
                    "var map;" & vbCrLf & _
                    "var Sissa = new google.maps.LatLng(25.678500,-100.323760);" & vbCrLf & _
                    "function initialize() {" & vbCrLf & _
                    "var mapOptions = {" & vbCrLf & _
                    "zoom: 7," & vbCrLf & _
                    "center: Sissa," & vbCrLf & _
                    "mapTypeId:  'hybrid'" & vbCrLf & _
                    "};" & vbCrLf & _
                    "map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);" & vbCrLf & _
                    "directionsDisplay.setMap(map);" & vbCrLf & _
                    "directionsDisplay.setPanel(document.getElementById('directionsPanel'));" & vbCrLf & _
                    "google.maps.event.addListener(directionsDisplay, 'directions_changed', function() {" & vbCrLf & _
                    "computeTotalDistance(directionsDisplay.getDirections());" & vbCrLf & _
                    "});" & vbCrLf & _
                    "calcRoute();" & vbCrLf & _
                    "}" & vbCrLf & _
                    ""
        If Tipo = 1 Then
            Url_mapa &= "function calcRoute() {" & vbCrLf & _
                    "var request = {" & vbCrLf & _
                    "origin: new google.maps.LatLng(" & Lsv_ClientesOri.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesOri.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "destination: new google.maps.LatLng(" & Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "travelMode: google.maps.TravelMode.DRIVING" & vbCrLf & _
                    "};" & vbCrLf & _
                    ""
        ElseIf Tipo = 2 Then
            Url_mapa &= "function calcRoute() {" & vbCrLf & _
                    "var request = {" & vbCrLf & _
                    "origin: new google.maps.LatLng(" & SucursalLat & "," & SucursalLon & ")," & vbCrLf & _
                    "destination: new google.maps.LatLng(" & Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "travelMode: google.maps.TravelMode.DRIVING" & vbCrLf & _
                    "};" & vbCrLf & _
                    ""
        End If
        Url_mapa &= "directionsService.route(request, function(response, status) {" & vbCrLf & _
                "if (status == google.maps.DirectionsStatus.OK) {" & vbCrLf & _
                "directionsDisplay.setDirections(response)" & vbCrLf & _
                "}" & vbCrLf & _
                "});" & vbCrLf & _
                "}" & vbCrLf & _
                "function computeTotalDistance(result) {" & vbCrLf & _
                "var total = 0;" & vbCrLf & _
                "var myroute = result.routes[0];" & vbCrLf & _
                "for (var i = 0; i < myroute.legs.length; i++) {" & vbCrLf & _
                "total += myroute.legs[i].distance.value;" & vbCrLf & _
                "}" & vbCrLf & _
                "total = total / 1000.0;" & vbCrLf & _
                "document.getElementById('total').innerHTML = total + ' km';" & vbCrLf & _
                "}" & vbCrLf & _
                "google.maps.event.addDomListener(window, 'load', initialize);" & vbCrLf & _
                "</script>" & vbCrLf & _
                "</head>" & vbCrLf & _
                "<body>" & vbCrLf & _
                "<div id='map-canvas' style='float:left;width:70%; height:100%'></div>" & vbCrLf & _
                "<div id='directionsPanel' style='float:right;width:30%;height:100%'>" & vbCrLf & _
                "<p>Total Distance: <span id='total'></span></p>" & vbCrLf & _
                "</div>" & vbCrLf & _
                "</body>" & vbCrLf & _
            "</html>"

        Call CrearArchivoHTML(Url_mapa, Application.StartupPath, "DocApiGoogle.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/DocApiGoogle.HTML")
    End Sub

    Private Sub Mapa_Raul()
        SegundosDesconexion = 0
        Dim Url_mapa As String = ""
        Dim UrlCoo As String = ""

        UrlCoo = "<!DOCTYPE html>" & vbCrLf & _
               "<html>" & vbCrLf & _
               "<head>" & vbCrLf & _
               "<meta http-equiv=" & Chr(34) & "X-UA-Compatible" & Chr(34) & " content=" & Chr(34) & "IE=8" & Chr(34) & ">" & vbCrLf & _
               "<title>Localizador de Rutas</title>" & vbCrLf & _
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
               "});" & vbCrLf & _
               "}" & vbCrLf

        UrlCoo &= "var rendererOptions = {draggable: true};" & vbCrLf & _
                "var directionsDisplay = new google.maps.DirectionsRenderer(rendererOptions);;" & vbCrLf & _
                "var directionsService = new google.maps.DirectionsService();" & vbCrLf & _
                "var map;" & vbCrLf & _
                "var centro = new google.maps.LatLng(" & SucursalLat & "," & SucursalLon & ");" & vbCrLf & _
                "function initialize() {" & vbCrLf & _
                "var mapOptions = {" & vbCrLf & _
                "zoom: 10," & vbCrLf & _
                "center: centro," & vbCrLf & _
                "mapTypeId:  'hybrid'" & vbCrLf & _
                "};" & vbCrLf & _
                "map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);" & vbCrLf & _
                "directionsDisplay.setMap(map);" & vbCrLf & _
                "directionsDisplay.setPanel(document.getElementById('directionsPanel'));" & vbCrLf & _
                "google.maps.event.addListener(directionsDisplay, 'directions_changed', function() {" & vbCrLf & _
                "computeTotalDistance(directionsDisplay.getDirections());" & vbCrLf & _
                "});" & vbCrLf & _
                "calcRoute();" & vbCrLf & _
                "}" & vbCrLf & _
                ""
        If Tipo = 1 Then
            'De un Punto A a un Punto B
            UrlCoo &= "function calcRoute() {" & vbCrLf & _
                    "var request = {" & vbCrLf & _
                    "origin: new google.maps.LatLng(" & Lsv_ClientesOri.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesOri.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "destination: new google.maps.LatLng(" & Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "travelMode: google.maps.TravelMode.DRIVING" & vbCrLf & _
                    "};" & vbCrLf & _
                    ""
        ElseIf Tipo = 2 Then
            'De Central a un Punto
            UrlCoo &= "function calcRoute() {" & vbCrLf & _
                    "var request = {" & vbCrLf & _
                    "origin: new google.maps.LatLng(" & SucursalLat & "," & SucursalLon & ")," & vbCrLf & _
                    "destination: new google.maps.LatLng(" & Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text & ", " & Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text & ")," & vbCrLf & _
                    "travelMode: google.maps.TravelMode.DRIVING" & vbCrLf & _
                    "};" & vbCrLf & _
                    ""
        End If
        UrlCoo &= "directionsService.route(request, function(response, status) {" & vbCrLf & _
                "if (status == google.maps.DirectionsStatus.OK) {" & vbCrLf & _
                "directionsDisplay.setDirections(response)" & vbCrLf & _
                "}" & vbCrLf & _
                "});" & vbCrLf & _
                "}" & vbCrLf & _
                "function computeTotalDistance(result) {" & vbCrLf & _
                "var total = 0;" & vbCrLf & _
                "var myroute = result.routes[0];" & vbCrLf & _
                "for (var i = 0; i < myroute.legs.length; i++) {" & vbCrLf & _
                "total += myroute.legs[i].distance.value;" & vbCrLf & _
                "}" & vbCrLf & _
                "total = total / 1000.0;" & vbCrLf & _
                "document.getElementById('total').innerHTML = total + ' km';" & vbCrLf & _
                "}" & vbCrLf & _
                "google.maps.event.addDomListener(window, 'load', initialize);" & vbCrLf & _
                "</script>" & vbCrLf

        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "<div id='map-canvas' style='float:left;width:70%; height:80%'></div>" & vbCrLf & _
                "<div id='directionsPanel' style='float:right;width:30%;height:80%'>" & vbCrLf & _
                "<p>Total Distance: <span id='total'></span></p>" & vbCrLf & _
                "</div>" & vbCrLf & _
                "</body>" & vbCrLf & _
            "</html>"


        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "MapaRuta.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaRuta.HTML")

    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Btn_OrigenPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OrigenPunto.Click
        SegundosDesconexion = 0
        Tipo = 2
        If Lsv_ClientesDes.SelectedItems.Count = 0 Then
            MsgBox("Selecione un Destino a Mostrar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesDes.Focus()
            Exit Sub
        End If
        If CDec(Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text) = 0 Or CDec(Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text) = 0 Then
            MsgBox("El Cliente Destino seleccionado parece tener incorrectas sus coordenadas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesDes.Focus()
            Exit Sub
        End If
        Call Mapa()
    End Sub

    Private Sub Btn_PuntoPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PuntoPunto.Click
        SegundosDesconexion = 0
        Tipo = 1
        If Lsv_ClientesOri.SelectedItems.Count = 0 Then
            MsgBox("Selecione un Origen.", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesOri.Focus()
            Exit Sub
        End If
        If CDec(Lsv_ClientesOri.SelectedItems(0).SubItems(4).Text) = 0 Or CDec(Lsv_ClientesOri.SelectedItems(0).SubItems(5).Text) = 0 Then
            MsgBox("El Cliente Origen seleccionado parece no tener coordenadas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesOri.Focus()
            Exit Sub
        End If
        If Lsv_ClientesDes.SelectedItems.Count = 0 Then
            MsgBox("Selecione un Destino", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesDes.Focus()
            Exit Sub
        End If
        If CDec(Lsv_ClientesDes.SelectedItems(0).SubItems(4).Text) = 0 Or CDec(Lsv_ClientesDes.SelectedItems(0).SubItems(5).Text) = 0 Then
            MsgBox("El Cliente Destino seleccionado parece no tener coordenadas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesDes.Focus()
            Exit Sub
        End If

        If Lsv_ClientesOri.SelectedItems(0).Text.Trim = Lsv_ClientesDes.SelectedItems(0).Text Then
            MsgBox("El Origen y Destino deben ser Clientes Diferentes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Lsv_ClientesDes.Focus()
            Exit Sub
        End If

        Call Mapa()
    End Sub

End Class