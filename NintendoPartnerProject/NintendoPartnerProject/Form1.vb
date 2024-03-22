Imports System.Windows
Public Class Form1
    'Dim f2 As New Customization
    Dim f3 As New Checkout
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonNes_Click(sender As Object, e As EventArgs) Handles button_nes.Click
        PB_consDisplay.Load("nes-new.png")
        PB_consDisplay.Size = New Size(300, 159)
        PB_conslogo.Size = New Size(116, 59)
    End Sub

End Class
