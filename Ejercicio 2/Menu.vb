﻿Public Class frm_menu
    Dim dt As DataTable = New DataTable
    Dim creo_tabla_simulacion As Boolean = False
    Dim n As Integer
    Dim hasta As Integer
    Dim desde As Integer
    Dim compra_diaria As Integer
    Dim precio_costo As Double
    Dim precio_venta As Double
    Dim precio_compra_emergencia As Double
    Dim precio_reventa As Double
    Dim precio_faltante As Double
    Dim simu As frm_simulacion = New frm_simulacion()
    Private Sub cmb_tabla_referencia_Click(sender As Object, e As EventArgs) Handles cmb_tabla_referencia.Click
        frm_Dia_nubaldo_o_lluvioso.Show()
        frm_dia_soleado.Show()
        frm_Distribución_Prob_Clima.Show()
    End Sub

    Private Sub cmdSimulacion_Click(sender As Object, e As EventArgs)
        frm_simulacion.Show()
    End Sub

    Private Sub txtCantidadExperimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadExperimento.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesde.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHasta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtGananciaPromedio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGananciaPromedio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPrecio()
    End Sub
    Private Sub CargarPrecio()
        txt_precio_compra.Text = "7"
        txt_precio_venta.Text = "12"
        txt_precio_reventa.Text = "1,44"
        txt_faltante.Text = "0,96"
    End Sub
    Private Function Validar()
        If txtCantidadExperimento.Text.Trim = "" Then
            MessageBox.Show("Debe cargar la cantidad de experimentos")
            txtCantidadExperimento.Focus()
            Return False
        End If
        If txtDesde.Text.Trim() = "" Then
            MessageBox.Show("Debe cargar desde")
            txtDesde.Focus()
            Return False
        End If
        If txtHasta.Text.Trim() = "" Then
            MessageBox.Show("Debe cargar hasta")
            txtHasta.Focus()
            Return False
        End If
        If txt_precio_compra.Text.Trim() = "" Then
            MessageBox.Show("Debe cargar el precio de compra")
            txt_precio_compra.Focus()
            Return False
        End If
        If txt_precio_venta.Text.Trim() = "" Then
            MessageBox.Show("Debe cargar el precio de venta")
            txt_precio_venta.Focus()
            Return False
        End If
        If txt_precio_reventa.Text.Trim() = "" Then
            MessageBox.Show("Debe cargar el precio de Reventa")
            txt_precio_reventa.Focus()
            Return False
        End If
        If txt_faltante.Text.Trim() = "" Then
            MessageBox.Show("Debe cargar el precio de Faltante")
            txt_faltante.Focus()
            Return False
        End If
        If RbnSiComprar.Checked = True Then
            If TxtPrecioCompraFaltante.Text.Trim() = "" Then
                MessageBox.Show("Debe cargar el precio de compra de mercaderia faltante")
                TxtPrecioCompraFaltante.Focus()
                Return False
            End If
        End If
        If RbnCompraDiaria.Checked = True Then
            If txt_compra_diaria.Text.Trim() = "" Then
                MessageBox.Show("Debe cargar la compra diria")
                txt_compra_diaria.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub cmbCargarEjemplo_Click(sender As Object, e As EventArgs) Handles cmbCargarEjemplo.Click
        txtCantidadExperimento.Text = "10000"
        txtDesde.Text = "0"
        txtHasta.Text = "100"
        If RbnCompraDiaria.Checked = False Then
            RbnCompraDiaria.Checked = True
        End If
        txt_compra_diaria.Text = "8"
        txtCantidadExperimento.Focus()
        If RbnSiComprar.Checked = True Then
            RbnNoComprar.Checked = True
        End If
        CargarPrecio()
    End Sub
    Public Sub Limpiar()
        txtCantidadExperimento.Text = ""
        txtDesde.Text = ""
        txtHasta.Text = ""
        txt_compra_diaria.Text = ""
        txtGananciaPromedio.Text = ""
        txtCantidadExperimento.Focus()
        frm_simulacion.grilla_simulacion.DataSource = Nothing
        dt.Rows.Clear()
    End Sub
    Private Sub CrearTablaSimulacion()
        dt.Columns.Add("Dia")
        dt.Columns.Add("RndClima")
        dt.Columns.Add("Clima")
        dt.Columns.Add("RndDemanda")
        dt.Columns.Add("Demanda")
        dt.Columns.Add("Venta")
        dt.Columns.Add("Sobrante")
        dt.Columns.Add("Faltante")
        dt.Columns.Add("Gan Venta")
        dt.Columns.Add("Costo Compra")
        dt.Columns.Add("Costo Faltante")
        dt.Columns.Add("Gan Sobrante")
        dt.Columns.Add("Gan Diaria")
        dt.Columns.Add("Gan Acumulado")
        dt.Columns.Add("Media")
        creo_tabla_simulacion = True
    End Sub

    Private Sub cmbLimpiar_Click(sender As Object, e As EventArgs) Handles cmbLimpiar.Click
        Limpiar()
    End Sub
    Public Function IniciarValores()
        n = Integer.Parse(txtCantidadExperimento.Text)
        hasta = Integer.Parse(txtHasta.Text)
        desde = Integer.Parse(txtDesde.Text)
        If RbnCompraDiaria.Checked = True Then
            compra_diaria = Integer.Parse(txt_compra_diaria.Text)
        End If
        precio_costo = Double.Parse(txt_precio_compra.Text)
        precio_venta = Double.Parse(txt_precio_venta.Text)
        precio_reventa = Double.Parse(txt_precio_reventa.Text)
        precio_faltante = Double.Parse(txt_faltante.Text)
        If RbnSiComprar.Checked = True Then
            precio_compra_emergencia = Double.Parse(TxtPrecioCompraFaltante.Text)
        End If
        If desde >= hasta Then
            MessageBox.Show("El hasta debe ser mayor al desde")
            txtHasta.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub cmbGenerar_Click(sender As Object, e As EventArgs) Handles cmbGenerar.Click
        If Validar() = True Then
            frm_simulacion.grilla_simulacion.DataSource = Nothing
            dt.Rows.Clear()

            If IniciarValores() Then
                GenerarSimulacion()
            End If
            frm_simulacion.Show()

        End If
    End Sub
    Private Sub GenerarSimulacion()
        If creo_tabla_simulacion = False Then
            CrearTablaSimulacion()
        End If
        Dim clima As String
        Dim demanda As Integer
        Dim venta As Integer
        Dim sobrante As Integer
        Dim faltante As Integer = 0
        Dim gan_venta As Double
        Dim venta_compra_faltante As Double
        Dim costo_compra As Double
        Dim costo_faltante As Double
        Dim gan_sobrante As Double
        Dim gan_diaria As Double
        Dim acumulado_anterior As Double = 0
        Dim acumulado As Double
        Dim media_anterior As Double = 0
        Dim media As Double = 0

        Try
            For fila = 0 To n
                Dim aleatorioClima As Double = Math.Round(Rnd(), 2)
                If aleatorioClima = 1 Then
                    aleatorioClima = 0.99
                End If

                Dim aleatorioDemanda As Double = Math.Round(Rnd(), 2)
                If aleatorioDemanda = 1 Then
                    aleatorioDemanda = 0.99
                End If

                Dim dr As DataRow
                dr = dt.NewRow()

                If fila = 0 Then
                    dr("Dia") = fila
                    dr("Gan Acumulado") = 0
                    dr("Media") = 0
                    acumulado_anterior = 0
                    media_anterior = 0
                    If RbnCompraDiaria.Checked = False Then
                        compra_diaria = 8
                    End If
                Else
                    clima = CalcularClima(aleatorioClima)
                    demanda = CalcularDemanda(clima, aleatorioDemanda)
                    If demanda > compra_diaria Then
                        venta = compra_diaria
                        faltante = demanda - compra_diaria
                    Else
                        venta = demanda
                    End If

                    If compra_diaria > venta Then
                        sobrante = compra_diaria - venta
                    Else
                        sobrante = 0
                    End If

                    gan_venta = venta * precio_venta
                    costo_compra = compra_diaria * precio_costo
                    If faltante > 0 And RbnSiComprar.Checked = True Then
                        costo_faltante = 0
                        venta_compra_faltante = faltante * (precio_venta - precio_compra_emergencia)
                    Else
                        costo_faltante = faltante * precio_faltante
                    End If

                    gan_sobrante = sobrante * precio_reventa
                    gan_diaria = gan_venta - costo_compra + gan_sobrante - costo_faltante + venta_compra_faltante
                    acumulado = gan_diaria + acumulado_anterior
                    media = (1 / fila) * ((fila - 1) * media_anterior + gan_diaria)
                    Dim aux_acumulado As Double = Math.Round(acumulado, 2)
                    Dim aux_media As Double = Math.Round(media, 2)
                    Dim aux_ganancia_diaria As Double = Math.Round(gan_diaria, 2)

                    dr("Dia") = fila.ToString
                    dr("RndClima") = aleatorioClima.ToString
                    dr("Clima") = clima.ToString
                    dr("RndDemanda") = aleatorioDemanda.ToString
                    dr("Demanda") = demanda.ToString
                    dr("Venta") = venta.ToString
                    dr("Sobrante") = sobrante.ToString
                    dr("Faltante") = faltante.ToString
                    dr("Gan Venta") = "$ " + gan_venta.ToString
                    dr("Costo Compra") = "$ -" + costo_compra.ToString
                    dr("Gan Sobrante") = "$ " + gan_sobrante.ToString

                    If costo_faltante = 0 Then
                        dr("Costo Faltante") = "$ " + costo_faltante.ToString
                    Else
                        dr("Costo Faltante") = "$ -" + costo_faltante.ToString
                    End If

                    dr("Gan Diaria") = "$ " + aux_ganancia_diaria.ToString
                    dr("Gan Acumulado") = "$ " + aux_acumulado.ToString
                    dr("Media") = "$ " + aux_media.ToString

                    acumulado_anterior = acumulado
                    media_anterior = media

                    If RbnCompraDiaria.Checked = False Then
                        compra_diaria = demanda
                    End If
                    faltante = 0
                End If
                If fila >= desde And fila <= hasta Then
                    dt.Rows.Add(dr)
                End If
            Next
            txtGananciaPromedio.Text = Math.Round(media, 2).ToString()
            frm_simulacion.grilla_simulacion.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        frm_simulacion.grilla_simulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        frm_simulacion.grilla_simulacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        frm_simulacion.grilla_simulacion.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Function CalcularDemanda(clima As String, rnd As Double)
        If clima.ToString() = "Soleado" Then
            Return CalcularDemandaSoleado(rnd)
        Else
            Return CalcularDemandaNubladoLluvioso(rnd)
        End If
    End Function
    Private Function CalcularDemandaSoleado(rnd As Double)
        Dim demanda As Integer
        Select Case rnd
            Case 0 To 0.09
                demanda = 6
            Case 0.1 To 0.29
                demanda = 7
            Case 0.3 To 0.74
                demanda = 8
            Case 0.75 To 0.99
                demanda = 9
        End Select
        Return demanda
    End Function
    Private Function CalcularDemandaNubladoLluvioso(rnd As Double)
        Dim demanda As Integer
        Select Case rnd
            Case 0 To 0.04
                demanda = 3
            Case 0.05 To 0.19
                demanda = 4
            Case 0.2 To 0.59
                demanda = 5
            Case 0.6 To 0.84
                demanda = 6
            Case 0.85 To 0.99
                demanda = 7
        End Select
        Return demanda
    End Function
    Private Function CalcularClima(rnd As Double)
        Dim clima As String = ""
        Select Case rnd
            Case 0 To 0.72
                clima = "Soleado"
            Case 0.73 To 0.99
                clima = "Nublado"
        End Select
        Return clima
    End Function

    Private Sub RbnCompraDiaria_CheckedChanged(sender As Object, e As EventArgs) Handles RbnCompraDiaria.CheckedChanged
        txt_compra_diaria.Enabled = True
        txt_compra_diaria.Text = ""
        txt_compra_diaria.Focus()
    End Sub

    Private Sub RbnDemandaDiaAnterior_CheckedChanged(sender As Object, e As EventArgs) Handles RbnDemandaDiaAnterior.CheckedChanged
        txt_compra_diaria.Enabled = False
        txt_compra_diaria.Text = ""
        txt_compra_diaria.Focus()
    End Sub

    Private Sub RbnSiComprar_CheckedChanged(sender As Object, e As EventArgs) Handles RbnSiComprar.CheckedChanged
        LblPrecioCompraFaltante.Visible = True
        TxtPrecioCompraFaltante.Visible = True
        TxtPrecioCompraFaltante.Text = "11"
    End Sub

    Private Sub RbnNoComprar_CheckedChanged(sender As Object, e As EventArgs) Handles RbnNoComprar.CheckedChanged
        LblPrecioCompraFaltante.Visible = False
        TxtPrecioCompraFaltante.Visible = False
        TxtPrecioCompraFaltante.Text = ""
    End Sub

    Private Sub txt_precio_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_compra.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_precio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_venta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_precio_reventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_reventa.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_compra_diaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compra_diaria.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TxtPrecioCompraFaltante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecioCompraFaltante.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_faltante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_faltante.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub
End Class
