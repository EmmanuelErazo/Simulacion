Public Class frm_Distribución_Prob_Clima
    Dim clima As String() = {"Soleado", "Nublado"}
    Dim probabilidad As String() = {"0,73", "0,27"}
    Dim probabiliad_acumulada As String() = {"0,73", "1"}
    Dim min_intervalo As String() = {"0,00", "0,73"}
    Dim max_intervalo As String() = {"0,72", "0,99"}

    Private Sub cargar_grilla()
        For fila = 0 To 1
            grilla_clima.Rows.Add()
            grilla_clima.Rows(fila).Cells(0).Value = clima(fila)
            grilla_clima.Rows(fila).Cells(1).Value = probabilidad(fila)
            grilla_clima.Rows(fila).Cells(2).Value = probabiliad_acumulada(fila)
            grilla_clima.Rows(fila).Cells(3).Value = min_intervalo(fila)
            grilla_clima.Rows(fila).Cells(4).Value = max_intervalo(fila)
        Next
    End Sub

    Private Sub frm_Distribución_Prob_Clima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
End Class