Public Class Checkout

    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f2 As New Customization
        label_price.Text = f2.p.ToString("C2")
        label_tax.Text = (f2.p * 0.08).ToString("C2")
        label_total.Text = (f2.p + f2.p * 0.08).ToString("C2")
    End Sub
End Class