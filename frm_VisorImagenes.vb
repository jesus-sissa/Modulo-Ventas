Imports System.IO

Public Class frm_VisorImagenes

    Public Imagen As Image = Nothing
    Public ImagenBytes As Byte() = Nothing
    Public RutaImagen As String = Nothing

    Private Sub frm_VisorImagenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If RutaImagen <> Nothing Then
                pct_Imagen.Image = Image.FromFile(RutaImagen)
            ElseIf Imagen IsNot Nothing Then
                pct_Imagen.Image = Imagen
            ElseIf ImagenBytes IsNot Nothing Then
                Dim ms_Imagen As MemoryStream = New MemoryStream(ImagenBytes, 0, ImagenBytes.Length)
                ms_Imagen.Write(ImagenBytes, 0, ImagenBytes.Length)
                pct_Imagen.Image = Image.FromStream(ms_Imagen, True)
                ms_Imagen.Dispose()
            Else
                ' pct_Imagen.Image = My.Resources.LogoSISSA_Tenue
            End If
        Catch
            'pct_Imagen.Image = My.Resources.LogoSISSA_Tenue
        End Try
    End Sub

    Private Sub pct_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Imagen.Click
        SegundosDesconexion = 0

        pct_Imagen.Image = Nothing
        Imagen = Nothing
        ImagenBytes = Nothing
        RutaImagen = Nothing
        Me.Close()
    End Sub

End Class