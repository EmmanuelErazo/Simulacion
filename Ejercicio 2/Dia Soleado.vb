Public Class frm_dia_soleado
    Dim demanda As String() = {"3", "4", "5", "6", "7"}
    Dim probabilidad As String() = {"0,05", "0,15", "0,40", "0,25", "0,15"}
    Dim probabiliad_acumulada As String() = {"0,05", "0,20", "0,60", "0,75", "1"}
    Dim min_intervalo As String() = {"0,00", "0,05", "0,20", "0,60", "0,75"}
    Dim max_intervalo As String() = {"0,04", "0,19", "0,59", "0,74", "0,99"}
    Private Sub frm_dia_soleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        For fila = 0 To 4
            grilla_soleado.Rows.Add()
            grilla_soleado.Rows(fila).Cells(0).Value = demanda(fila)
            grilla_soleado.Rows(fila).Cells(1).Value = probabilidad(fila)
            grilla_soleado.Rows(fila).Cells(2).Value = probabiliad_acumulada(fila)
            grilla_soleado.Rows(fila).Cells(3).Value = min_intervalo(fila)
            grilla_soleado.Rows(fila).Cells(4).Value = max_intervalo(fila)
        Next
    End Sub
End Class