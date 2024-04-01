
Imports System.Management.Instrumentation

Public Class Customization
    Dim m As Decimal
    Public p As Decimal
    Dim o As Decimal


    Private Sub Customization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ConsoleSelected = "NES" Then
            p = 94.99
            label_Price.Text = 94.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "SNES" Then
            p = 159.99
            label_Price.Text = 159.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "N64" Then
            p = 169.99
            label_Price.Text = 169.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "GC" Then
            p = 129.99
            label_Price.Text = 129.99.ToString("C2")
            Options()
        End If
        If ConsoleSelected = "WII" Then
            p = 119.99
            label_Price.Text = 119.99.ToString("C2")
            Options()
        End If
        o = p
    End Sub

    Private Sub Options()

        If CB_used.Checked Then
            m = p * 0.8
        End If
        If CB_refurbished.Checked Then
            m = p * 1.3
        End If
        If CB_addGame.Checked Then
            nup_addGame.Visible = True
            m += 60 * nup_addGame.Value
        End If
        If CB_addController.Checked Then
            nup_addController.Visible = True
            m = p + 60 * nup_addController.Value
        End If
        If CB_HDMI.Checked Then
            nup_HDMI.Visible = True
            m = p + 60 * nup_HDMI.Value
        End If
        label_Price.Text = m.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If CB_used.Checked Or CB_refurbished.Checked Or CB_addGame.Checked Or nup_addController.Value > 1 Or CB_addController.Checked Or nup_addController.Value > 1 Then
        '    Timer1.Enabled = True
        '    Options()
        '    Timer1.Enabled = False
        'End If
        "MAKE TIMER CALL UPON OPTIONS ON MONDAY!!!!!!!!!!!!"

    End Sub

    Private Sub button_gotoCheckout_Click(sender As Object, e As EventArgs) Handles button_gotoCheckout.Click
        Me.Hide()
        Dim f1 As New Form1
        f1.ShowDialog()
        Me.Show()
    End Sub

    'Private Sub CB_used_CheckedChanged(sender As Object, e As EventArgs) Handles CB_used.CheckedChanged
    '    m = p
    '    p = m + m * -0.2
    '    CB_refurbished.Visible = False
    '    If CB_used.Checked = False Then
    '        p = o
    '        CB_refurbished.Visible = True
    '    End If
    '    label_Price.Text = p.ToString("C2")
    'End Sub

    'Private Sub CB_refurbished_CheckedChanged(sender As Object, e As EventArgs) Handles CB_refurbished.CheckedChanged
    '    m = p
    '    p = m * 1.3
    '    CB_used.Visible = False
    '    If CB_refurbished.Checked = False Then
    '        p = o
    '        CB_used.Visible = True
    '    End If
    '    label_Price.Text = p.ToString("C2")
    'End Sub

    'Private Sub CB_addGame_CheckedChanged(sender As Object, e As EventArgs) Handles CB_addGame.CheckedChanged
    '    m = p
    '    o = p
    '    nup_addGame.Visible = True
    '    p = m + 60 * nup_addGame.Value
    '    If CB_addGame.Checked = False Then
    '        p = o

    '    End If
    '    label_Price.Text = p.ToString("C2")
    'End Sub

    Private Sub CB_addController_CheckedChanged(sender As Object, e As EventArgs) Handles CB_addController.CheckedChanged

    End Sub

    Private Sub CB_HDMI_CheckedChanged(sender As Object, e As EventArgs) Handles CB_HDMI.CheckedChanged

    End Sub
End Class