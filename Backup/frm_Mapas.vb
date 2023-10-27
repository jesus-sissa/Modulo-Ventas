Public Class frm_Mapas

    Public LatitudCentroDelMapa As Decimal = 25.694582
    Public LongitudCentroDelMapa As Decimal = -100.261163
    Public ZoomdelMapa As Integer = 12
    Public EstilodelMapa As String = "r"
    Public BloquearMapa As Boolean = False
    Public MododelMapa As String = "VEMapMode.Mode2D"
    Public MostrarSwitch As Boolean = True
    Public LatitudPin() As Decimal
    Public LongitudPin() As Decimal
    Public ColorPin() As Color
    Public NombrePin() As String
    Public DescripcionPin() As String
    Public Mostrarrecorrido As Boolean = False

    Private Sub frm_Mapas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim sw As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(CurDir() & "\Mapa.htm", False)
        sw.WriteLine("<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.1//EN' 'http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd'>")
        sw.WriteLine("<html xmlns='http://www.w3.org/1999/xhtml' >")
        sw.WriteLine("<head>")
        sw.WriteLine("<title>Mapa</title>")
        sw.WriteLine("<script type='text/javascript' src='http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2'></script>") 'SDK
        sw.WriteLine("<script type='text/javascript'>")
        sw.WriteLine("var map = null;")
        sw.WriteLine("")
        sw.WriteLine("function GetMap() {") '****'
        sw.WriteLine("var latitud = " & LatitudCentroDelMapa & ";")
        sw.WriteLine("var longitud = " & LongitudCentroDelMapa & ";")
        sw.WriteLine("")
        sw.WriteLine("")
        sw.WriteLine("map = new VEMap('myMap');")
        sw.WriteLine("map.LoadMap(new VELatLong(latitud, longitud), " & ZoomdelMapa & ", '" & EstilodelMapa & "', " & BloquearMapa.ToString.ToLower & ", " & MododelMapa & ", " & MostrarSwitch.ToString.ToLower & ");")
        sw.WriteLine("map.HideDashboard();")
        sw.WriteLine("")
        sw.WriteLine("layer = new VEShapeLayer();")
        If LongitudPin IsNot Nothing And LatitudPin IsNot Nothing And NombrePin IsNot Nothing And DescripcionPin IsNot Nothing Then
            If LongitudPin.Length = LatitudPin.Length And LatitudPin.Length = NombrePin.Length And NombrePin.Length = DescripcionPin.Length Then
                For i As Integer = 0 To LongitudPin.Length - 1

                    sw.WriteLine("var shape = new VEShape(VEShapeType.Pushpin, new VELatLong(" & LatitudPin(i) & ", " & LongitudPin(i) & "));")
                    sw.WriteLine("shape.SetTitle('" & NombrePin(i) & "');")
                    sw.WriteLine("shape.SetDescription('" & DescripcionPin(i) & "');")
                    'If ColorPin IsNot Nothing Then sw.WriteLine("shape.SetCustomIcon('<div style=" & Chr(34) & "background-color:White" & Chr(34) & ">" & NombrePin(i) & "<img src=" & Chr(34) & "009.bmp" & Chr(34) & "/></div>');")
                    'If ColorPin IsNot Nothing Then sw.WriteLine("shape.SetCustomIcon('<div style=" & Chr(34) & "font-weight:bold; color: Red;" & Chr(34) & ">" & NombrePin(i) & "<img src=" & Chr(34) & "009.bmp" & Chr(34) & "/></div>');")
                    'If ColorPin IsNot Nothing Then sw.WriteLine("shape.SetCustomIcon('<div style=" & Chr(34) & "font-weight:bold; color: Red;" & Chr(34) & ">" & NombrePin(i) & "</div>');")
                    sw.WriteLine("layer.AddShape(shape);")
                Next
            End If
        End If
        sw.WriteLine("map.AddShapeLayer(layer);")
        sw.WriteLine("")
        If Mostrarrecorrido Then
            sw.Write("map.GetDirections([")
            If LongitudPin IsNot Nothing And LatitudPin IsNot Nothing And NombrePin IsNot Nothing And DescripcionPin IsNot Nothing Then
                If LongitudPin.Length = LatitudPin.Length And LatitudPin.Length = NombrePin.Length And NombrePin.Length = DescripcionPin.Length Then
                    For i As Integer = 0 To LongitudPin.Length - 1
                        sw.Write("new VELatLong(" & LatitudPin(i) & ", " & LongitudPin(i) & ")")
                        If i < LongitudPin.Length - 1 Then sw.Write(", ") Else sw.WriteLine("]);")
                    Next
                End If
            End If
        End If
        sw.WriteLine("}")
        sw.WriteLine("function agregarPin() {") '****'
        sw.WriteLine("var latitud = 25.694582;")
        sw.WriteLine("var longitud = -100.261163;")
        sw.WriteLine("var nombre = document.getElementById('tbx_Nombre');")
        sw.WriteLine("var descripcion = document.getElementById('tbx_Descripcion');")
        sw.WriteLine("")
        sw.WriteLine("var shape = new VEShape(VEShapeType.Pushpin, new VELatLong(latitud.value, longitud.value));")
        sw.WriteLine("shape.SetTitle(nombre.value);")
        sw.WriteLine("shape.SetDescription(descripcion.value);")
        sw.WriteLine("layer.AddShape(shape);")
        sw.WriteLine("")
        sw.WriteLine("return false;")
        sw.WriteLine("}")
        sw.WriteLine("function Acercar() {")
        sw.WriteLine("map.ZoomIn();")
        sw.WriteLine("return false;")
        sw.WriteLine("}")
        sw.WriteLine("function Alejar() {")
        sw.WriteLine("map.ZoomOut();")
        sw.WriteLine("return false;")
        sw.WriteLine("}")
        sw.WriteLine("function CambiarVista() {")
        sw.WriteLine("var s = map.GetMapStyle();")
        sw.WriteLine("if (s == VEMapStyle.Hybrid) {")
        sw.WriteLine("map.SetMapStyle(VEMapStyle.Road);")
        sw.WriteLine("} else {")
        sw.WriteLine("map.SetMapStyle(VEMapStyle.Hybrid);")
        sw.WriteLine("}")
        sw.WriteLine("return false;")
        sw.WriteLine("}")
        sw.WriteLine("</script>")
        sw.WriteLine("</head>")
        'Final del encabezado
        sw.WriteLine("<body onload='GetMap();'>")
        sw.WriteLine("<form id='form1' runat='server'>")
        sw.WriteLine("<table>")
        sw.WriteLine("<tr>")
        sw.WriteLine("<td>")
        sw.WriteLine("<input type='button' id='btn_ZoomOut' value='-' onclick='return Alejar();' />")
        sw.WriteLine("</td>")
        sw.WriteLine("<td>")
        sw.WriteLine("<input type='button' id='btn_ZoomIn' value='+' onclick='return Acercar();' />")
        sw.WriteLine("</td>")
        sw.WriteLine("<td>")
        sw.WriteLine("<input type='button' id='btn_Vista' value='Cambiar Vista' onclick='return CambiarVista();' />")
        sw.WriteLine("</td>")
        sw.WriteLine("</tr>")
        sw.WriteLine("</table>")
        sw.WriteLine("<div id='myMap' style='position:relative; width:100%; height:900px;' />")
        sw.WriteLine("</form>")
        sw.WriteLine("</body>")
        sw.WriteLine("</html>")
        sw.Close()
        Web_Mapa.Navigate(CurDir() & "\Mapa.htm")
    End Sub

End Class