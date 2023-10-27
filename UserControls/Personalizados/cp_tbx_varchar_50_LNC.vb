Public Class cp_tbx_varchar_50_LNC
    Inherits cp_Textbox

    'Este textbox esta limitado a 50 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 50
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.Width = 350
        Me.Height = 20
        Me.Filtrado = True
    End Sub
End Class
