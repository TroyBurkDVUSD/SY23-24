Imports System.ComponentModel
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Windows

Public Class Customization
    Dim a As Decimal
    Dim b As Decimal
    Dim c As Decimal
    Dim d As Decimal
    Dim f As Decimal
    Dim m As Decimal
    Public p As Decimal


    Private Sub Customization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ConsoleSelected = "NES" Then
            m = 94.99
            label_Price.Text = 94.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "SNES" Then
            m = 159.99
            label_Price.Text = 159.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "N64" Then
            m = 169.99
            label_Price.Text = 169.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "GC" Then
            m = 129.99
            label_Price.Text = 129.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "WII" Then
            m = 119.99
            label_Price.Text = 119.99.ToString("C2")
            Options()
        End If
    End Sub
    Private Sub Options()
        If CB_used.Checked Then
            p = m + m * 0.8
        End If
        If CB_refurbished.Checked Then
            p = m + m * 1.2
        End If
        If CB_addGame.Checked Then
            nup_addGame.Visible = True
            If nup_addGame.Value > 1 Then
                p = m + 60 * nup_addGame.Value
            Else
                p = m + 60
            End If

        End If
        If CB_addController.Checked Then
            nup_addController.Visible = True
            If nup_addController.Value > 1 Then
                p = m + 60 * nup_addController.Value
            Else
                p = m + 60
            End If
            p = m + 60
        End If
        label_Price.Text = p.ToString("c2")
    End Sub
End Class