Imports Modulo_Ventas.Cn_Clientes

Public Class frm_CajasFuertesD

    Public Id_CajaFuerte As Integer = 0

    Private Sub frm_CajasFuertesD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Acceso Then
            tbx_Combinacion.UseSystemPasswordChar = True
        End If
        Dim dr As DataRow = fn_CajasFuertes_ReadD(Id_CajaFuerte)

        'Aqui se establece el texto del objeto seleccionado
        tbx_ClaveCajaFuerte.Text = dr("Clave_CajaFuerte")
        tbx_Status.Text = dr("Status")
        tbx_Combinacion.Text = dr("Combinacion")
        tbx_Marca.Text = dr("Marca")
        tbx_Modelo.Text = dr("Modelo")
        tbx_Serie.Text = dr("Serie")
        tbx_Peso.Text = dr("Peso")
        tbx_FechaFabricacion.Text = dr("FechaFabricacion")
        tbx_Nueva.Text = dr("Nueva")
        tbx_ClaveCajaFuerteT.Text = dr("Clave_CajaFuerteT")
        tbx_AnchoE.Text = dr("AnchoE")
        tbx_AltoE.Text = dr("AltoE")
        tbx_FondoE.Text = dr("FondoE")
        tbx_AnchoI.Text = dr("AnchoI")
        tbx_AltoI.Text = dr("AltoI")
        tbx_FondoI.Text = dr("FondoI")
        tbx_CompraClaveP.Text = dr("Clave_Proveedor")
        tbx_CompraNombreP.Text = dr("Nombre_Comercial")
        tbx_CompraClaveT.Text = dr("Clave_Empleado")
        tbx_CompraNombreT.Text = dr("Nombre")
        tbx_CompraFecha.Text = dr("FechaCompra")
        tbx_CompraObs.Text = dr("Observaciones")
        Select Case dr("Status")
            Case "DISPONIBLE"
                grp_Status.Enabled = False
            Case "BAJA"
                lbl_StatusCliente.Enabled = False
                tbx_StatusClaveC.Enabled = False
                tbx_StatusNombreC.Enabled = False
                tbx_StatusClaveT.Text = dr("ClaveEmpleadoB")
                tbx_StatusNombreT.Text = dr("NombreEmpleadoB")
                tbx_StatusFecha.Text = dr("FechaBaja")
                tbx_StatusObs.Text = dr("ObservacionesB")
            Case "RENTADA", "VENDIDA", "PROCESO EN VENTA", "PROCESO EN RENTA", "RETIRO", "PROCESO EN RETIRO"
                tbx_StatusClaveC.Text = dr("ClaveCliente")
                tbx_StatusNombreC.Text = dr("NombreCliente")
                lbl_StatusEmpleado.Text = "Vendedor"
                tbx_StatusClaveT.Text = dr("ClaveVendedor")
                tbx_StatusNombreT.Text = dr("NomVendedor")
                tbx_StatusFecha.Text = dr("FechaVenRen")
                tbx_StatusObs.Text = dr("ObservacionesVenRen")
                tbx_StatusCombinacionCliente.Text = dr("CombinacionCliente")
                tbx_StatusFechaCita.Text = dr("FechaCita")
                tbx_StatusHoraCita.Text = dr("HoraCita")
                If dr("Status") = "RENTADA" OrElse dr("Status") = "PROCESO EN RENTA" Then
                    lbl_FechaRetiro.Enabled = True
                    tbx_FechaRetiro.Enabled = True
                    tbx_FechaRetiro.Text = dr("Fin_Renta")
                End If
            Case "MANTENIMIENTO INTERNO"
                lbl_StatusCliente.Enabled = False
                tbx_StatusClaveC.Enabled = False
                tbx_StatusNombreC.Enabled = False
                tbx_StatusClaveT.Text = dr("ClaveVendedor")
                tbx_StatusNombreT.Text = dr("NomVendedor")
                tbx_StatusFecha.Text = dr("FechaVenRen")
                tbx_StatusObs.Text = dr("ObservacionesVenRen")
                tbx_StatusFechaCita.Text = dr("FechaCita")
                tbx_StatusHoraCita.Text = dr("HoraCita")
        End Select
        dr = Nothing
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class