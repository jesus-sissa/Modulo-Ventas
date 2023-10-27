
Public Class frm_Outlook

    Private Sub frm_Outlook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gbx_Contactos.Text = "0 Contactos"
        Me.Cursor = Cursors.WaitCursor
        lsv_Datos.Columns.Add("Nombre", 200)
        lsv_Datos.Columns.Add("Empresa", 200)
        lsv_Datos.Columns.Add("Mail", 150)
        lsv_Datos.Columns.Add("Telefono", 100)

        '**********************************
        'NO Utiliza Referencias
        '**********************************

        Dim objOutlook As Object
        Dim objNS As Object
        Dim objAddressList As Object
        Try
            objOutlook = CreateObject("Outlook.Application")
            objNS = objOutlook.GetNamespace("MAPI")
            objAddressList = objNS.GetDefaultFolder(10)
            For Each Elemento As Object In objAddressList.items
                'lsv_Datos.Items.Add(Elemento.FullName.ToString.ToUpper)
                lsv_Datos.Items.Add(Elemento.FirstName.ToString.ToUpper & " " & Elemento.LastName.ToString.ToUpper)
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Elemento.CompanyName.ToString.ToUpper)
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Elemento.Email1Address.ToString.ToUpper)
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Elemento.BusinessTelephoneNumber.ToString.ToUpper)
            Next
            objAddressList = Nothing
            objNS = Nothing
            objOutlook = Nothing
            btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
            gbx_Contactos.Text = lsv_Datos.Items.Count & " Contactos"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            objAddressList = Nothing
            objNS = Nothing
            objOutlook = Nothing
            'MessageBox.Show(ex.Message)
            MsgBox("Ocurrió el siguiente Error: " & Chr(13) & Chr(13) & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
            gbx_Contactos.Text = lsv_Datos.Items.Count & " Contactos"
        End Try
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, "CONTACTOS DE OUTLOOK. EXPORTADOS EL " & Today.ToString, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub
End Class