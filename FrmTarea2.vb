Public Class FrmTarea2
    Dim objRegiones As New cRegiones
    Private Sub bGraficar_Click(sender As System.Object, e As System.EventArgs) Handles bGraficar.Click
        objRegiones.graficar(GRA)

    End Sub

    Private Sub FrmTarea2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class