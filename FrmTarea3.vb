Public Class FrmTarea3

    Private Sub FrmTarea3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bGraficar_Click(sender As System.Object, e As System.EventArgs) Handles bGraficar.Click
        Dim objRegiones As New cRegiones
        objRegiones.graficar2(GRA)
    End Sub
End Class