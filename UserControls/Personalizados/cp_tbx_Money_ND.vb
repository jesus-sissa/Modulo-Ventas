﻿Public Class cp_tbx_Money_ND
    Inherits cp_Textbox

    'Este textbox esta limitado a 50 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 10
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        Me.Width = 110
        Me.Height = 20
        Me.Filtrado = True
    End Sub
End Class
