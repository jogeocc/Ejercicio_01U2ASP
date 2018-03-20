Public Class AgregarDatos

    Dim numeros As Decimal() = New Decimal(2) {}

    Dim cuantos As Int16 = 3, contador As Int16 = 0

    Public Sub New()
        InitializeComponent()
        BtnRegresar.Enabled = False
    End Sub



    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNum.Text <> "" Then
            numeros(contador) = Convert.ToDecimal(TxtNum.Text)
            contador += 1
            TxtNum.Focus()
        End If

        If contador = cuantos Then
            Dim objMen As Letrero.Mensaje = New Letrero.Mensaje()
            TxtNum.Enabled = False
            BtnRegresar.Enabled = True
            objMen.setLetrero("Ya ingresó los 3 números")
            objMen.ShowDialog()
        Else
            LblNum.Text = "Ingrese el Número " & (contador + 1)
            TxtNum.Text = ""
        End If
    End Sub

    Private Sub BtnRegresar_Click_1(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Dim objInicio As InterfazBienvenida.MenuBienvenida = New InterfazBienvenida.MenuBienvenida()
        objInicio.setDato(numeros, cuantos)
        objInicio.Show()
        Me.Close()
    End Sub


End Class
