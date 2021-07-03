Public Class FrmTarea1
    Dim objRegion As New cRegiones
    Private Sub FrmTarea1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        objRegion.llenarCombo(cbRegion)



    End Sub

    Private Sub bConsultar_Click(sender As System.Object, e As System.EventArgs) Handles bConsultar.Click
        Dim casos As Integer
        Dim muertes As Integer
        objRegion.llenarGridView(GRILLA, cbRegion.SelectedValue, Val(lblCasos.Text), Val(lblMuertes.Text))
        muertes = objRegion.muertesCovid(cbRegion.SelectedValue)
        casos = objRegion.casosCovid(cbRegion.SelectedValue)
        lblCasos.Text = casos
        lblMuertes.Text = muertes
    End Sub

End Class