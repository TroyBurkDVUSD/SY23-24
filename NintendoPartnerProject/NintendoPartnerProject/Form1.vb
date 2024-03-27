Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1
    Dim f3 As New Checkout
    'Dim ConsoleSelected As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f2 As New Customization
        label_Price.Text = f2.p
    End Sub

    Private Sub buttonNes_Click(sender As Object, e As EventArgs) Handles button_nes.Click
        PB_consDisplay.Load("nes-new.png")
        PB_conslogo.Load("cooltext_nes.png")
        PB_consDisplay.Size = New Size(300, 159)
        PB_conslogo.Size = New Size(116, 59)
        ConsoleSelected = "NES"
        label_Price.Text = 94.99.ToString("C2")
        button_Customize.Visible = True
        button_Checkout.Visible = True
    End Sub

    Private Sub button_snes_Click(sender As Object, e As EventArgs) Handles button_snes.Click
        PB_consDisplay.Load("snes-new.jpg")
        PB_conslogo.Load("cooltext_snes.png")
        PB_consDisplay.Size = New Size(290, 159)
        PB_conslogo.Size = New Size(130, 59)
        PB_consDisplay.Location = New Point(175, 12)
        PB_conslogo.Location = New Point(467, 12)
        ConsoleSelected = "SNES"
        label_Price.Text = 159.99.ToString("C2")
        button_Customize.Visible = True
        button_Checkout.Visible = True
    End Sub

    Private Sub button_n64_Click(sender As Object, e As EventArgs) Handles button_n64.Click
        PB_consDisplay.Load("n64-new.jpg")
        PB_conslogo.Load("cooltext_nintendo64.png")
        ConsoleSelected = "N64"
        label_Price.Text = 169.99.ToString("C2")
        button_Customize.Visible = True
        button_Checkout.Visible = True
    End Sub

    Private Sub button_gc_Click(sender As Object, e As EventArgs) Handles button_gc.Click
        PB_consDisplay.Load("gc-new.jpg")
        PB_conslogo.Load("cooltext_gamecube.png")
        ConsoleSelected = "GC"
        label_Price.Text = 129.99.ToString("C2")
        button_Customize.Visible = True
        button_Checkout.Visible = True
    End Sub

    Private Sub button_wii_Click(sender As Object, e As EventArgs) Handles button_wii.Click
        PB_consDisplay.Load("wii-new.jpg")
        PB_conslogo.Load("cooltext_nintendowii.png")
        ConsoleSelected = "WII"
        label_Price.Text = 119.99.ToString("C2")
        button_Customize.Visible = True
        button_Checkout.Visible = True
    End Sub

    Private Sub button_Customize_Click(sender As Object, e As EventArgs) Handles button_Customize.Click
        If ConsoleSelected = "WII" Or ConsoleSelected = "GC" Or ConsoleSelected = "N64" Or ConsoleSelected = "SNES" Or ConsoleSelected = "NES" Then
            button_Customize.Visible = True
            Me.Hide()
            Dim f2 As New Customization
            f2.ShowDialog()
            Me.Show()
        End If

    End Sub
End Class
