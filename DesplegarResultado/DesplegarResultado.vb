Public Class DesplegarResultado


    Public Sub setResultados(ByRef resultados As Decimal())
        TxtSuma.Text = Convert.ToString(resultados(0))
        TxtResta.Text = Convert.ToString(resultados(1))
        TxtProd.Text = Convert.ToString(resultados(2))
        TxtDiv.Text = Convert.ToString(resultados(3))
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class
