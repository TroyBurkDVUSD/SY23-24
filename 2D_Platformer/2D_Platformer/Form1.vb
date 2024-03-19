Public Class Form1
    Dim MoveSpeed As Integer = 8
    Dim IsJumping As Boolean
    Dim Points As Integer = 0
    Dim BombTime As Integer = 50
    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                IsJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += MoveSpeed
    End Sub

    Private Sub frm2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                IsJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= MoveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= MoveSpeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
        Label1.Top = 75
        Label1.Left = 58
        Label2.Top = 165
        Label2.Left = 165
        labLoser.Top = 133
        labLoser.Left = 140
        labWinner.Top = 133
        labWinner.Left = 150

    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If IsJumping = False Then
                tmrGravity.Start()
            End If
        End If


        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next

        For Each t1 As Control In Me.Controls
            If TypeOf t1 Is PictureBox Then
                If t1.Tag = "t1collectable" Then
                    If picPlayer.Bounds.IntersectsWith(t1.Bounds) Then
                        If t1.Visible = True And picPlayer.Visible = True Then
                            t1.Visible = False
                            Points = Points + 1
                            labScore.Text = Points
                        End If
                    End If
                End If
            End If
        Next

        If Points = 6 Then
            Points = Points + 5
            Pineapple1.Visible = True
            Pineapple2.Visible = True
            Pineapple3.Visible = True
            Pineapple4.Visible = True
            Pineapple5.Visible = True
            Pineapple6.Visible = True
            BombTime = BombTime + 20
        End If

        For Each t2 As Control In Me.Controls
            If TypeOf t2 Is PictureBox Then
                If t2.Tag = "t2collectable" Then
                    If picPlayer.Bounds.IntersectsWith(t2.Bounds) Then
                        If t2.Visible = True And picPlayer.Visible = True Then
                            t2.Visible = False
                            Points = Points + 3
                            labScore.Text = Points
                        End If
                    End If
                End If
            End If
        Next

        If Points = 29 Then
            Points = Points + 5
            BombTime = BombTime + 20
            Goldbar1.Visible = True
            Goldbar2.Visible = True
            Goldbar3.Visible = True
            Goldbar4.Visible = True
            Goldbar5.Visible = True
            Goldbar6.Visible = True
            Goldbar7.Visible = True
            Goldbar8.Visible = True
            Goldbar9.Visible = True
            Goldbar10.Visible = True
        End If

        For Each t3 As Control In Me.Controls
            If TypeOf t3 Is PictureBox Then
                If t3.Tag = "t3collectable" Then
                    If picPlayer.Bounds.IntersectsWith(t3.Bounds) Then
                        If t3.Visible = True And picPlayer.Visible = True Then
                            t3.Visible = False
                            Points = Points + 7
                            labScore.Text = Points
                        End If
                    End If
                End If
            End If
        Next

        If Points = 104 Then
            tmrBomb.Enabled = False
            labWinner.Visible = True
            ButRestart.Visible = True
        End If

        If BombTime = 0 Then
            labLoser.Visible = True
            tmrBomb.Enabled = False
            picPlayer.Visible = False
            ButRestart.Visible = True
        End If
    End Sub
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += MoveSpeed
    End Sub

    Private Sub tmrBomb_Tick(sender As Object, e As EventArgs) Handles tmrBomb.Tick
        BombTime = BombTime - 1
        LabBombTime.Text = BombTime
    End Sub

    Private Sub ButRestart_Click(sender As Object, e As EventArgs) Handles ButRestart.Click
        Label1.Visible = False
        Label2.Visible = False
        labLoser.Visible = False
        labWinner.Visible = False
        ButRestart.Visible = False
        ButRestart.Text = "Restart?"
        picPlayer.Visible = True
        picPlayer.Top = 250
        picPlayer.Left = 39
        Points = 0
        Pineapple1.Visible = False
        Pineapple2.Visible = False
        Pineapple3.Visible = False
        Pineapple4.Visible = False
        Pineapple5.Visible = False
        Pineapple6.Visible = False
        tmrBomb.Enabled = True
        BombTime = 50
        Goldbar1.Visible = False
        Goldbar2.Visible = False
        Goldbar3.Visible = False
        Goldbar4.Visible = False
        Goldbar5.Visible = False
        Goldbar6.Visible = False
        Goldbar7.Visible = False
        Goldbar8.Visible = False
        Goldbar9.Visible = False
        Goldbar10.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
