Public Class Mensaje
    Public Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Public Sub setLetrero(ByVal Letrero As String)
        LblMensaje.Text = Letrero
    End Sub

End Class
