﻿Public Class frm_ReporteGeneralHorarios

    Private Sub frm_ReporteGeneralHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_H_ClienteO.Actualizar()
        cmb_H_ClienteD.Actualizar()
        cmb_Cliente.AgregaParametro("Status", "A", 0)
        cmb_Cliente.Actualizar()

        lsv_Horarios.Columns.Add("Clave")
        lsv_Horarios.Columns.Add("Cliente")
        lsv_Horarios.Columns.Add("Fechainicio")
        lsv_Horarios.Columns.Add("ClavePrecio")
        lsv_Horarios.Columns.Add("Descripcion")
        lsv_Horarios.Columns.Add("TipoFrecuencia")
        lsv_Horarios.Columns.Add("Frecuencia")
        lsv_Horarios.Columns.Add("Origen")
        lsv_Horarios.Columns.Add("Recoleccion")
        lsv_Horarios.Columns.Add("Destino")
        lsv_Horarios.Columns.Add("Entrega")
        lsv_Horarios.Columns.Add("Ruta")
        lsv_Horarios.Columns.Add("Status")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        Dim IncluirSubclientes As String = "N"
        If chk_Subclientes.Checked Then IncluirSubclientes = "S"

        If Not chk_Clientes.Checked And cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione el Cliente Padre o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        If Not chk_Origen.Checked And cmb_H_ClienteO.SelectedValue = "0" Then
            MsgBox("Seleccione el Origen o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_H_ClienteO.Focus()
            Exit Sub
        End If

        If Not chk_Destino.Checked And cmb_H_ClienteD.SelectedValue = "0" Then
            MsgBox("Seleccione el Destino o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_H_ClienteD.Focus()
            Exit Sub
        End If

        If Not Cn_Clientes.fn_Clientes_ReporteGeneralHorarios(lsv_Horarios, cmb_Cliente.SelectedValue, cmb_H_ClienteO.SelectedValue, cmb_H_ClienteD.SelectedValue, IncluirSubclientes) Then
            MsgBox("Ocurrió un error al ejecutar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_Exportar.Enabled = lsv_Horarios.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Horarios.Items.Count
    End Sub

    Private Sub chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Clientes.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
        cmb_Cliente.SelectedValue = 0
        cmb_Cliente.Enabled = Not chk_Clientes.Checked
        tbx_Cliente.Enabled = cmb_Cliente.Enabled
        chk_Subclientes.Enabled = Not chk_Clientes.Checked
        chk_Subclientes.Checked = chk_Clientes.Checked
    End Sub

    Private Sub LimpiarControles()
        SegundosDesconexion = 0
        lsv_Horarios.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        btn_Exportar.Enabled = False
    End Sub

    Private Sub chk_Origen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Origen.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
        cmb_H_ClienteO.SelectedValue = 0
        cmb_H_ClienteO.Enabled = Not chk_Origen.Checked
        tbx_H_ClienteO.Enabled = cmb_H_ClienteO.Enabled
    End Sub

    Private Sub chk_Destino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Destino.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
        cmb_H_ClienteD.SelectedValue = 0
        cmb_H_ClienteD.Enabled = Not chk_Destino.Checked
        tbx_H_ClienteD.Enabled = cmb_H_ClienteD.Enabled
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        Cursor = Cursors.WaitCursor
        FuncionesGlobales.fn_Exportar_Excel(lsv_Horarios, 2, "REPORTE GENERAL DE HORARIOS (AL " & DateTime.Now.Date.ToShortDateString & ")", 0, 0, frm_MENU.prg_Barra)
        Cursor = Cursors.Default
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
    End Sub

    Private Sub cmb_H_ClienteO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_H_ClienteO.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
    End Sub

    Private Sub cmb_H_ClienteD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_H_ClienteD.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
    End Sub

    Private Sub chk_Subclientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Subclientes.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarControles()
    End Sub

End Class