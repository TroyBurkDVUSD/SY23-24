Imports System.Reflection.Emit
Public Class Form2
    Dim WithEvents CS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.InsertQuarter()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.InsertDollar()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.InsertNickle()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.InsertDime()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(D As Integer, Q As Integer, DM As Integer, N As Integer) Handles CS.CoinReturnEvent
        If D > 0 Then
            Dollars.Visible = True
        Else
            Dollars.Visible = False
        End If
        If Q > 0 Then
            Quarter.Visible = True
        Else
            Quarter.Visible = False
        End If
        If N > 0 Then
            Nickles.Visible = True
        Else
            Nickles.Visible = False
        End If
        If DM > 0 Then
            Dimes.Visible = True
        Else
            Dimes.Visible = False
        End If
    End Sub

    Private Sub CS_Dispense(P As Image) Handles CS.Dispense
        ProductPB.Image = P
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTB.Text
            Case ProductControl1.ProductID
                CS.Buy(ProductControl1)
            Case ProductControl2.ProductID
                CS.Buy(ProductControl2)
            Case ProductControl3.ProductID
                CS.Buy(ProductControl3)
            Case ProductControl4.ProductID
                CS.Buy(ProductControl4)
            Case ProductControl5.ProductID
                CS.Buy(ProductControl5)
            Case ProductControl6.ProductID
                CS.Buy(ProductControl6)
            Case ProductControl7.ProductID
                CS.Buy(ProductControl7)
            Case ProductControl8.ProductID
                CS.Buy(ProductControl8)
            Case ProductControl9.ProductID
                CS.Buy(ProductControl9)
            Case ProductControl10.ProductID
                CS.Buy(ProductControl10)
            Case ProductControl11.ProductID
                CS.Buy(ProductControl11)
            Case ProductControl12.ProductID
                CS.Buy(ProductControl12)
            Case ProductControl13.ProductID
                CS.Buy(ProductControl13)
            Case ProductControl14.ProductID
                CS.Buy(ProductControl14)
            Case ProductControl15.ProductID
                CS.Buy(ProductControl15)
            Case ProductControl16.ProductID
                CS.Buy(ProductControl16)
        End Select
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub
End Class