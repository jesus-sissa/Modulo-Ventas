Imports Modulo_Ventas.Cn_Clientes
Imports Modulo_Ventas.FuncionesGlobales

Public Class frm_ClientesGrupos
    Dim Id_ClienteGrupo As Integer = 0

    Private Sub frm_ClientesGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        cmb_Grupos.DisplayMember = "Descripcion"
        cmb_Grupos.ValueMember = "Id_ClienteGrupo"
        cmb_Grupos.Actualizar()

        Call ListaClientes()
        Call MascaraClientesxGrupo()
    End Sub


    Private Sub tab_Grupos_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tab_Grupos.Selected
        SegundosDesconexion = 0

        If tab_Grupos.SelectedTab Is tp_ClientesxGrupo Then
            cmb_Grupos.Actualizar()
            Call ListaClientes()
            'If cmb_Grupos.SelectedValue = 0 Then
            '    'Call MascaraClientesxGrupo()
            'Else
            '    Call ListaClientesxGrupo()
            'End If
        ElseIf tab_Grupos.SelectedTab Is tp_Grupos Then

            Call ListaGrupos()
            Call LimpiarCG()
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

#Region "Catalogo de Grupos"

    Sub ListaGrupos()

        If Not fn_ClientesGrupos_ListarGrupos(lsv_Catalogo) Then
            MsgBox("Ocurrió un error al intentar mostrar la lista de grupos.", MsgBoxStyle.Critical, Me.Text)
            lsv_Grupos.Clear()
        End If
        Lbl_RegistrosCG.Text = "Registros: " & lsv_Catalogo.Items.Count
        Call BotonesCG()
    End Sub

    Sub BotonesCG()
        btn_EliminarCG.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_ModificarCG.Enabled = lsv_Catalogo.SelectedItems.Count > 0

    End Sub

    Sub LimpiarCG()
        tbx_DescripcionCG.Clear()
        Id_ClienteGrupo = 0
        tbx_DescripcionCG.Tag = ""
        lsv_Catalogo.Enabled = True
        btn_CancelarCG.Visible = False
        tbx_DescripcionCG.Focus()
    End Sub

    Sub Modificar()
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Id_ClienteGrupo = lsv_Catalogo.SelectedItems(0).Tag
            tbx_DescripcionCG.Text = lsv_Catalogo.SelectedItems(0).Text
            tbx_DescripcionCG.Tag = lsv_Catalogo.SelectedItems(0).Text
            btn_ModificarCG.Enabled = False
            btn_EliminarCG.Enabled = False
            lsv_Catalogo.Enabled = False
            btn_CancelarCG.Visible = True
        End If
    End Sub

    Private Sub btn_GuardarCG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarCG.Click
        SegundosDesconexion = 0

        If tbx_DescripcionCG.Text.Trim = "" Then
            MsgBox("Capture la descripción del Grupo.", MsgBoxStyle.Critical, Me.Text)
            tbx_DescripcionCG.Focus()
            Exit Sub
        End If

        Dim Id As Integer = fn_ClientesGrupos_ExisteGrupo(tbx_DescripcionCG.Text.Trim)
        If Id > 0 Then
            MsgBox("La descripción del Grupo ya existe.", MsgBoxStyle.Critical, Me.Text)
            tbx_DescripcionCG.Focus()
            Exit Sub
        ElseIf Id = -1 Then
            MsgBox("Ocurrió un error al intengar validar la descripción del Grupo.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If Id_ClienteGrupo = 0 Then
            If Not fn_ClientesGrupos_NuevoGrupo(tbx_DescripcionCG.Text.Trim) Then
                MsgBox("Ocurrió un error al intentar guardar el Grupo.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If
        Else
            If Not fn_ClientesGrupos_ActualizarGrupo(Id_ClienteGrupo, tbx_DescripcionCG.Text.Trim) Then
                MsgBox("Ocurrió un error al intentar actualizar el Grupo.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If
        End If

        Call ListaGrupos()
        Call LimpiarCG()

    End Sub

    Private Sub btn_ModificarCG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ModificarCG.Click
        SegundosDesconexion = 0
        Call Modificar()
    End Sub

    Private Sub btn_EliminarCG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminarCG.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Dim Id As Integer = fn_ClientesGrupos_Dependencias(lsv_Catalogo.SelectedItems(0).Tag)
            If Id = -1 Then
                MsgBox("Ocurrió un error al intentar Validar el Grupo.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            ElseIf Id > 0 Then
                MsgBox("El Grupo tiene dependencias por lo tanto no se puede eliminar.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If

            If Not fn_ClientesGrupos_EliminarGrupo(lsv_Catalogo.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un error al intentar eliminar el Grupo.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If

            Call ListaGrupos()
            Call LimpiarCG()
        End If
    End Sub

    Private Sub btn_CancelarCG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarCG.Click
        SegundosDesconexion = 0

        Call LimpiarCG()
        Call ListaGrupos()
    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Call Modificar()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        Call BotonesCG()
    End Sub

#End Region

#Region "Clientes por Grupo"

    Sub BotonesCXG()
        btn_AgregarCxG.Enabled = lsv_Clientes.CheckedItems.Count > 0
        btn_EliminarCxG.Enabled = lsv_Grupos.CheckedItems.Count > 0
    End Sub

    Sub ListaClientes()

        RemoveHandler lsv_Clientes.ItemChecked, AddressOf lsv_Clientes_ItemChecked

        lsv_Clientes.Clear()

        If Not fn_ClientesGrupos_ListaClientes(lsv_Clientes, "A") Then
            MsgBox("Ocurrió un error al intentar mostrar los clientes.", MsgBoxStyle.Critical, Me.Text)
        End If

        lbl_RegistrosC.Text = "Registros: " & lsv_Clientes.Items.Count

        AddHandler lsv_Clientes.ItemChecked, AddressOf lsv_Clientes_ItemChecked
        Call BotonesCXG()
    End Sub

    Sub ListaClientesxGrupo()

        RemoveHandler lsv_Grupos.ItemChecked, AddressOf lsv_Grupos_ItemChecked

        lsv_Grupos.Clear()

        If cmb_Grupos.SelectedValue > 0 Then
            If Not fn_ClientesGrupos_ListaClientesxGrupo(lsv_Grupos, cmb_Grupos.SelectedValue) Then
                MsgBox("Ocurrió un error al intentar mostrar los clientes del grupo.", MsgBoxStyle.Critical, Me.Text)
            End If
        End If

        lbl_RegistrosG.Text = "Registros: " & lsv_Grupos.Items.Count

        AddHandler lsv_Grupos.ItemChecked, AddressOf lsv_Grupos_ItemChecked
        Call BotonesCXG()
    End Sub

    Sub MascaraClientesxGrupo()
        lsv_Grupos.Clear()
        lsv_Grupos.Columns.Add("Clave")
        lsv_Grupos.Columns.Add("Cliente")
        lsv_Grupos.Columns.Add("IdC")
        lbl_RegistrosG.Text = "Registros: 0"
    End Sub

    Private Sub cmb_Grupos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Grupos.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Grupos.SelectedValue = 0 Then
            Call MascaraClientesxGrupo()
        Else
            Call ListaClientesxGrupo()
        End If
    End Sub

    Private Sub btn_AgregarCxG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarCxG.Click
        SegundosDesconexion = 0
        Dim Agregados As Integer = 0
        Dim TieneExistentes As Boolean = False

        If cmb_Grupos.SelectedValue = 0 Then
            MsgBox("Seleccione un grupo.", MsgBoxStyle.Critical, Me.Text)
            cmb_Grupos.Focus()
            Exit Sub
        End If

        Agregados = lsv_Clientes.CheckedItems.Count
        For Each ItemCliente As ListViewItem In lsv_Clientes.CheckedItems
            For Each ItemGrupo As ListViewItem In lsv_Grupos.Items
                If ItemCliente.Tag = Integer.Parse(ItemGrupo.SubItems(2).Text) Then
                    TieneExistentes = True
                    Agregados -= 1
                    ItemCliente.Checked = False
                    Exit For
                End If
            Next
        Next

        If Agregados > 0 Then
            If Not fn_ClientesGrupos_AgregarCliente(lsv_Clientes, cmb_Grupos.SelectedValue) Then
                MsgBox("Ocurrió un error al intentar agregar los Clientes.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If
        End If

        If TieneExistentes Then
            MsgBox("Se encontraron algunos Clientes que ya están agregados." & vbNewLine & "Se agregaron " & Agregados & " Clientes.", MsgBoxStyle.Information, Me.Text)
        End If

        Call ListaClientes()
        Call ListaClientesxGrupo()
        Call BotonesCXG()
    End Sub

    Private Sub btn_EliminarCxG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminarCxG.Click
        SegundosDesconexion = 0

        If Not fn_ClientesGrupos_EliminarCliente(lsv_Grupos) Then
            MsgBox("Ocurrió un error al intentar eliminar los Clientes.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Call ListaClientes()
        Call ListaClientesxGrupo()
        Call BotonesCXG()

    End Sub

    Private Sub lsv_Clientes_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs)
        SegundosDesconexion = 0

        btn_AgregarCxG.Enabled = lsv_Clientes.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Grupos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs)
        SegundosDesconexion = 0

        btn_EliminarCxG.Enabled = lsv_Grupos.CheckedItems.Count > 0
    End Sub

#End Region

End Class