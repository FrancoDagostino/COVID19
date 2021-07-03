Public Class FrmPrincipal

    Private Sub ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem.Click
        Dim F1 As New FrmTarea1
        F1.ShowDialog()
    End Sub

    Private Sub GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem.Click
        Dim F2 As New FrmTarea2
        F2.ShowDialog()
    End Sub

    Private Sub GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem.Click
        Dim F3 As New FrmTarea3
        F3.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
