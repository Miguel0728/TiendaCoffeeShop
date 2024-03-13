Imports System.Dynamic
Imports System.Linq.Expressions
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    'Miguel Melendez Hernandez
    'Programa Venta en Coffe Shop

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim NumeroDeProducto As Integer
        Dim NombreDeArticulo As String
        Dim IncomeTax, IncomeTax2, IncomeTax3, IncomeTax4 As Double
        Dim Total1, Total2, Total3, Total4 As Double
        Dim Precio1, Precio2, Precio3, Precio4 As Double

        'Porcentajes
        Const Tax As Double = 0.115

        'Precio de Articulos
        Precio1 = 1.99
        Precio2 = 1.5
        Precio3 = 2.5
        Precio4 = 4.25

        'Calcular Income Tax
        IncomeTax = Precio1 * Tax
        IncomeTax2 = Precio2 * Tax
        IncomeTax3 = Precio3 * Tax
        IncomeTax4 = Precio4 * Tax

        'Calcular Total
        Total1 = Precio1 + IncomeTax
        Total2 = Precio2 + IncomeTax2
        Total3 = Precio3 + IncomeTax3
        Total4 = Precio4 + IncomeTax4

        Try
            NumeroDeProducto = txtNumProducto.Text

        Catch
            MessageBox.Show("Entra un producto")

        End Try

        If NumeroDeProducto = 1 Then
            NombreDeArticulo = "Latte"
            lblNombreArticulo.Text = NombreDeArticulo
            lblTotal.Text = Total1.ToString("c")
            lblTax.Text = Tax
            lblPrecio.Text = Precio1.ToString("c")


        ElseIf NumeroDeProducto = 2 Then
            NombreDeArticulo = "Espresso"
            lblNombreArticulo.Text = NombreDeArticulo
            lblTotal.Text = Total2.ToString("c")
            lblTax.Text = Tax
            lblPrecio.Text = Precio2.ToString("c")


        ElseIf NumeroDeProducto = 3 Then
            NombreDeArticulo = "Cappucino"
            lblNombreArticulo.Text = NombreDeArticulo
            lblTotal.Text = Total3.ToString("c")
            lblTax.Text = Tax
            lblPrecio.Text = Precio3.ToString("c")


        ElseIf NumeroDeProducto = 4 Then
            NombreDeArticulo = "IceCofee"
            lblNombreArticulo.Text = NombreDeArticulo
            lblTotal.Text = Total4.ToString("c")
            lblTax.Text = Tax
            lblPrecio.Text = Precio4.ToString("c")



        Else MessageBox.Show("Articulo no encontrado!")

        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNumProducto.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
