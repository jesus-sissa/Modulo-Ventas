Public Class cp_tbx_Buscar
    Inherits cp_Textbox

    'Este textbox esta limitado con el tipo de datos varchar en clave
    Public Sub New()
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.Width = 568
        Me.Height = 20
        Me.Filtrado = False
    End Sub
End Class
