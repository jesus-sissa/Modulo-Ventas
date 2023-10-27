Imports Modulo_Ventas.FuncionesGlobales
Imports Modulo_Ventas.Cn_Clientes

Public Class frm_TEFModal

#Region "Variables Publicas"
    Public Id_Cliente As Integer
#End Region

#Region "Metodos Publicos"

    ''' <summary>
    ''' Limpia los valores de todas las casillas de la pestaña Horarios
    ''' </summary>
    Public Sub TEF_LimpiarCasillas()
        cmb_Tipo.SelectedValue = 0
        cmb_Frecuencia.SelectedValue = 0
        cmb_De.SelectedValue = 0
        cmb_A.SelectedValue = 0
    End Sub

    '' Obtiene los valores de la base de datos cuyo id  = Me.Tag
    'Public Sub Actualizar()
    '    If Not Me.Tag = 0 Then
    '        'Aqui se obtienen los valores de la base de datos
    '        Dim Arr As Array = fn_Horarios_Leer(Me.Tag)

    '        If Not Arr.Length = 0 Then
    '            dtp_H_FechaInicio.Value = Arr(2)            'Fecha_Inicio
    '            cmb_H_TipoF.SelectedValue = Arr(3)          'Tipo_Frecuencia
    '            cmb_H_Frecuencia.SelectedValue = Arr(4)     'Frecuencia
    '            cmb_H_ClienteO.SelectedValue = Arr(5)       'Cliente_Origen
    '            Dim Rec As Array = Split(Arr(6), "/")       'H_Recoleccion
    '            cmb_H_DeO.Text = Rec(0)
    '            cmb_H_AO.Text = Rec(1)
    '            Rec = Nothing
    '            cmb_H_ClienteD.SelectedValue = Arr(7)       'Cliente_Destino
    '            Dim Orig As Array = Split(Arr(8), "/")      'H_Entrega
    '            cmb_H_DeD.Text = Orig(0)
    '            cmb_H_AD.Text = Orig(1)
    '            Orig = Nothing
    '            cmb_H_Ruta.SelectedValue = Arr(9)          'Id_Ruta
    '            cmb_H_Boveda.SelectedValue = Arr(10)        'Escala_Boveda
    '            cmb_H_MismoDia.SelectedValue = Arr(11)      'Mismo_Dia
    '            cmb_H_DiaEntrega.SelectedValue = Arr(12)    'Dia_Entrega
    '            cmb_H_RutaEntrega.SelectedValue = Arr(13)   'Id_RutaE
    '        End If
    '    End If
    'End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TEFModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_Tipo.LimpiarItems()
        cmb_Tipo.AgregarItem("1", "RECEPCION DE FACTURAS")
        cmb_Tipo.AgregarItem("2", "PAGO FACTURAS")

        cmb_Frecuencia.LimpiarItems()
        cmb_Frecuencia.AgregarItem("1", "DOMINGO")
        cmb_Frecuencia.AgregarItem("2", "LUNES")
        cmb_Frecuencia.AgregarItem("3", "MARTES")
        cmb_Frecuencia.AgregarItem("4", "MIERCOLES")
        cmb_Frecuencia.AgregarItem("5", "JUEVES")
        cmb_Frecuencia.AgregarItem("6", "VIERNES")
        cmb_Frecuencia.AgregarItem("7", "SABADO")
        cmb_Frecuencia.AgregarItem("9", "LUNES A VIERNES")

        cmb_De.LimpiarItems()
        LlenarMinutos(15, cmb_De)

        cmb_A.LimpiarItems()
        LlenarMinutos(15, cmb_A)

        If Me.Tag = 0 Then
            TEF_LimpiarCasillas()
        End If

    End Sub

    Private Sub cmb_De_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_De.SelectedIndexChanged
        If cmb_De.SelectedIndex = 0 Then
            cmb_A.SelectedIndex = 0
        ElseIf cmb_De.SelectedIndex = cmb_De.Items.Count - 1 Then
            cmb_A.SelectedIndex = 1
        Else
            cmb_A.SelectedIndex = cmb_De.SelectedIndex + 1
        End If
    End Sub

    Private Sub Btn_CancelarH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CancelarH.Click
        Call TEF_LimpiarCasillas()
        Me.Close()
    End Sub

    Private Sub Btn_GuardarH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GuardarH.Click
        SegundosDesconexion = 0

        If ValidarCampos() = True Then
            If cmb_Frecuencia.SelectedValue = 9 Then
                fn_Menu_Progreso(0)
                GuardarDia(2)
                fn_Menu_Progreso(10)
                GuardarDia(3)
                fn_Menu_Progreso(20)
                GuardarDia(4)
                fn_Menu_Progreso(40)
                GuardarDia(5)
                fn_Menu_Progreso(80)
                GuardarDia(6)
                fn_Menu_Progreso(100)
            Else
                fn_Menu_Progreso(0)
                Call GuardarDia(cmb_Frecuencia.SelectedValue)
                fn_Menu_Progreso(100)
            End If
            fn_Menu_Progreso(0)

            Call TEF_LimpiarCasillas()

            Me.Close()
        End If
    End Sub

#End Region

#Region "Metodos Privados"

    Private Sub GuardarDia(ByVal Dia As Integer)
        SegundosDesconexion = 0

        Call fn_Admin_CrearHorario(Id_Cliente, cmb_Tipo.SelectedValue, Dia.ToString, cmb_De.Text & "/" & cmb_A.Text)
    End Sub

    Private Function ValidarCampos() As Boolean
        SegundosDesconexion = 0

        If cmb_Tipo.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_Tipo.Focus()
            Return False
        End If

        If cmb_Frecuencia.SelectedValue = "0" Then
            MsgBox("Seleccione la Frecuencia.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_Frecuencia.Focus()
            Return False
        End If

        If cmb_De.SelectedValue = "0" Then
            MsgBox("Seleccione el Horario.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_De.Focus()
            Return False
        End If

        If cmb_A.SelectedValue = "0" Then
            MsgBox("Seleccione el Horario.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_A.Focus()
            Return False
        End If

        If cmb_De.SelectedIndex > cmb_A.SelectedIndex Then
            MsgBox("Horario Incorrecto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_De.Focus()
            Return False
        End If

        Return True

    End Function

#End Region

End Class