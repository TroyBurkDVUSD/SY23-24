Imports System.Windows
Public Class Form1
    'Dim f2 As New Customization
    Dim f3 As New Checkout
    Dim ConsoleSelected As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonNes_Click(sender As Object, e As EventArgs) Handles button_nes.Click
        PB_consDisplay.Load("nes-new.png")
        PB_conslogo.Load("cooltext_nes.png")
        PB_consDisplay.Size = New Size(300, 159)
        PB_conslogo.Size = New Size(116, 59)
        ConsoleSelected = "NES"
    End Sub

    Private Sub button_snes_Click(sender As Object, e As EventArgs) Handles button_snes.Click
        PB_consDisplay.Load("snes-new.jpg")
        PB_conslogo.Load("snes_cooltext.jpg")
        ConsoleSelected = "SNES"
    End Sub

    Private Sub button_n64_Click(sender As Object, e As EventArgs) Handles button_n64.Click
        PB_consDisplay.Load("n64-new.jpg")
        PB_conslogo.Load("cooltext_nintendo64.png")
        ConsoleSelected = "N64"
    End Sub

    Private Sub button_gc_Click(sender As Object, e As EventArgs) Handles button_gc.Click
        PB_consDisplay.Load("")
    End Sub
End Class
