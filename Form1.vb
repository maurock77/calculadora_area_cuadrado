Public Class Form1
    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        ' declaración de variables
        Dim lado As Double
        Dim perimetro As Double
        Dim area As Double

        ' valida si se ingresó un número
        If Double.TryParse(TextBoxLado.Text, lado) Then

            ' validación de número positivo
            If lado <= 0 Then
                MessageBox.Show("El valor del lado debe ser mayor a cero.", "Dato inválido")
                Exit Sub
            End If

            ' calcular
            perimetro = 4 * lado
            area = lado * lado

            ' mostrar resultado en los textbox
            TextBoxPerimetro.Text = perimetro.ToString()
            TextBoxArea.Text = area.ToString

        Else
            MessageBox.Show("Por favor ingrese un valor numérico válido para el lado.", "Error de entrada")

        End If
    End Sub

    Private Sub TextBoxLado_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLado.TextChanged
        ' limpia los campos de perimetro y área cuando se cambie el valor de lado
        TextBoxPerimetro.Clear()
        TextBoxArea.Clear()
    End Sub
End Class
