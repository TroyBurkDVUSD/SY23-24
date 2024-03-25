Imports System.ComponentModel
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Windows

Public Class Customization
    Dim f1 As New Form1
    Dim f3 As New Checkout
    Dim a As Decimal
    Dim b As Decimal
    Dim c As Decimal
    Dim d As Decimal
    Dim f As Decimal
    Dim image As Image = f1.PB_conslogo.Image

    Private Sub Customization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CB_used.Checked Then


            If f1.PB_conslogo.Image = "cooltext_nes.png" Then

            End If


        End If

        If CB_refurbished.Checked Then
            b = 1.2
        End If
        If CB_addGame.Checked Then
            nup_addGame.Visible = True
            If nup_addGame.Value > 1 Then
                c = 60 * nup_addGame.Value
            Else
                c = 60
            End If
        End If
        If CB_addController.Checked Then
            nup_addController.Visible = True
            d = 60
        End If
        If CB_HDMI.Checked Then
            nup_HDMI.Visible = True
            f = 15
        End If
        'label_Price.Text = 
    End Sub
End Class