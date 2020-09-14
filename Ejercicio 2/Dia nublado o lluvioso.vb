Public Class frm_Dia_nubaldo_o_lluvioso
    Dim demanda As String() = {"6", "7", "8", "9"}
    Dim probabilidad As String() = {"0,10", "0,20", "0,45", "0,25"}
    Dim probabiliad_acumulada As String() = {"0,10", "0,30", "0,75", "1"}
    Dim min_intervalo As String() = {"0,00", "0,10", "0,30", "0,75"}
    Dim max_intervalo As String() = {"0,09", "0,129", "0,74", "0,99"}
    Private Sub frm_Dia_nubaldo_o_lluvioso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        For fila = 0 To 3
            grilla_nublado_lluvioso.Rows.Add()
            grilla_nublado_lluvioso.Rows(fila).Cells(0).Value = demanda(fila)
            grilla_nublado_lluvioso.Rows(fila).Cells(1).Value = probabilidad(fila)
            grilla_nublado_lluvioso.Rows(fila).Cells(2).Value = probabiliad_acumulada(fila)
            grilla_nublado_lluvioso.Rows(fila).Cells(3).Value = min_intervalo(fila)
            grilla_nublado_lluvioso.Rows(fila).Cells(4).Value = max_intervalo(fila)

        Next

    End Sub
End Class