Public Class MenuBienvenida

    Private Mensaje As Letrero.Mensaje = New Letrero.Mensaje()
    Private objAgregarDat As AgregarDatos.AgregarDatos = New AgregarDatos.AgregarDatos()
    Private numeros As Decimal(), resultados As Decimal() = {0, 0, 0, 0}
    Private opcion, cuantos As Int16

    Public Sub setDato(ByVal numeros As Decimal(), ByVal cuantos As Int16)
        Me.numeros = numeros
        Me.cuantos = cuantos
    End Sub


    Public Function realizarSuma(ByVal numeros As Decimal()) As Decimal
        Dim resp As Decimal = numeros(0)
        For i As Int16 = 1 To cuantos - 1
            resp += numeros(i)
        Next

        Return resp
    End Function

    Public Function realizarResta(ByVal numeros As Decimal()) As Decimal
        Dim resp As Decimal = numeros(0)
        For i As Int16 = 1 To cuantos - 1
            resp -= numeros(i)
        Next

        Return resp
    End Function

    Private Sub BtnContinuar_Click_1(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Try
            opcion = Convert.ToInt16(TxtOpcion.Text)
        Catch exception As Exception
        End Try

        Select Case opcion
            Case 1
                Me.Hide()
                objAgregarDat.Show()
            Case 2
                resultados(0) = realizarSuma(numeros)
                Mensaje.setLetrero("Suma Realizada")
                Mensaje.ShowDialog()
            Case 3
                resultados(1) = realizarResta(numeros)
                Mensaje.setLetrero("Resta Realizada")
                Mensaje.ShowDialog()
            Case 4
                resultados(2) = realizarProducto(numeros)
                Mensaje.setLetrero("Producto Realizado")
                Mensaje.ShowDialog()
            Case 5
                resultados(3) = realizarDiv(numeros)
                Mensaje.setLetrero("División Realizada")
                Mensaje.ShowDialog()
            Case 6
                Dim objDespRel As DesplegarResultado.DesplegarResultado = New DesplegarResultado.DesplegarResultado()
                objDespRel.setResultados(resultados)
                objDespRel.ShowDialog()
            Case Else
                Mensaje.setLetrero("Opción no valida")
                Mensaje.ShowDialog()
        End Select
    End Sub

    Public Function realizarProducto(ByVal numeros As Decimal()) As Decimal
        Dim resp As Decimal = numeros(0)
        For i As Int16 = 1 To cuantos - 1
            resp *= numeros(i)
        Next

        Return resp
    End Function

    Public Function realizarDiv(ByVal numeros As Decimal()) As Decimal
        Dim resp As Decimal = numeros(0)
        For i As Int16 = 1 To cuantos - 1
            resp /= numeros(i)
        Next

        Return resp
    End Function

End Class
