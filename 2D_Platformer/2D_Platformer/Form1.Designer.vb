<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.labPoints = New System.Windows.Forms.Label()
        Me.labScore = New System.Windows.Forms.Label()
        Me.labWinner = New System.Windows.Forms.Label()
        Me.tmrBomb = New System.Windows.Forms.Timer(Me.components)
        Me.LabBombTime = New System.Windows.Forms.Label()
        Me.labLoser = New System.Windows.Forms.Label()
        Me.Goldbar1 = New System.Windows.Forms.PictureBox()
        Me.Pineapple6 = New System.Windows.Forms.PictureBox()
        Me.Pineapple5 = New System.Windows.Forms.PictureBox()
        Me.Pineapple4 = New System.Windows.Forms.PictureBox()
        Me.Pineapple3 = New System.Windows.Forms.PictureBox()
        Me.Pineapple2 = New System.Windows.Forms.PictureBox()
        Me.Pineapple1 = New System.Windows.Forms.PictureBox()
        Me.picBomb = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.Goldbar2 = New System.Windows.Forms.PictureBox()
        Me.Goldbar3 = New System.Windows.Forms.PictureBox()
        Me.Goldbar4 = New System.Windows.Forms.PictureBox()
        Me.Goldbar5 = New System.Windows.Forms.PictureBox()
        Me.Goldbar6 = New System.Windows.Forms.PictureBox()
        Me.Goldbar7 = New System.Windows.Forms.PictureBox()
        Me.Goldbar8 = New System.Windows.Forms.PictureBox()
        Me.Goldbar9 = New System.Windows.Forms.PictureBox()
        Me.Goldbar10 = New System.Windows.Forms.PictureBox()
        Me.ButRestart = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Goldbar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pineapple6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pineapple5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pineapple4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pineapple3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pineapple2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pineapple1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBomb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goldbar10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 30
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 30
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 25
        '
        'tmrGameLogic
        '
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 50
        '
        'labPoints
        '
        Me.labPoints.AutoSize = True
        Me.labPoints.Location = New System.Drawing.Point(669, 9)
        Me.labPoints.Name = "labPoints"
        Me.labPoints.Size = New System.Drawing.Size(91, 16)
        Me.labPoints.TabIndex = 7
        Me.labPoints.Text = "Happy Points!"
        '
        'labScore
        '
        Me.labScore.AutoSize = True
        Me.labScore.Location = New System.Drawing.Point(669, 34)
        Me.labScore.Name = "labScore"
        Me.labScore.Size = New System.Drawing.Size(14, 16)
        Me.labScore.TabIndex = 8
        Me.labScore.Text = "0"
        '
        'labWinner
        '
        Me.labWinner.AutoSize = True
        Me.labWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labWinner.Location = New System.Drawing.Point(838, 332)
        Me.labWinner.Name = "labWinner"
        Me.labWinner.Size = New System.Drawing.Size(368, 91)
        Me.labWinner.TabIndex = 14
        Me.labWinner.Text = "You Win!"
        Me.labWinner.Visible = False
        '
        'tmrBomb
        '
        Me.tmrBomb.Interval = 300
        '
        'LabBombTime
        '
        Me.LabBombTime.AutoSize = True
        Me.LabBombTime.Location = New System.Drawing.Point(618, 20)
        Me.LabBombTime.Name = "LabBombTime"
        Me.LabBombTime.Size = New System.Drawing.Size(21, 16)
        Me.LabBombTime.TabIndex = 15
        Me.LabBombTime.Text = "50"
        '
        'labLoser
        '
        Me.labLoser.AutoSize = True
        Me.labLoser.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLoser.Location = New System.Drawing.Point(825, 239)
        Me.labLoser.Name = "labLoser"
        Me.labLoser.Size = New System.Drawing.Size(381, 91)
        Me.labLoser.TabIndex = 17
        Me.labLoser.Text = "You Lose"
        Me.labLoser.Visible = False
        '
        'Goldbar1
        '
        Me.Goldbar1.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar1.Location = New System.Drawing.Point(389, 20)
        Me.Goldbar1.Name = "Goldbar1"
        Me.Goldbar1.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar1.TabIndex = 24
        Me.Goldbar1.TabStop = False
        Me.Goldbar1.Tag = "t3collectable"
        Me.Goldbar1.Visible = False
        '
        'Pineapple6
        '
        Me.Pineapple6.Image = Global._2D_Platformer.My.Resources.Resources.pineapple
        Me.Pineapple6.Location = New System.Drawing.Point(12, 166)
        Me.Pineapple6.Name = "Pineapple6"
        Me.Pineapple6.Size = New System.Drawing.Size(53, 50)
        Me.Pineapple6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pineapple6.TabIndex = 23
        Me.Pineapple6.TabStop = False
        Me.Pineapple6.Tag = "t2collectable"
        Me.Pineapple6.Visible = False
        '
        'Pineapple5
        '
        Me.Pineapple5.Image = Global._2D_Platformer.My.Resources.Resources.pineapple
        Me.Pineapple5.Location = New System.Drawing.Point(615, 342)
        Me.Pineapple5.Name = "Pineapple5"
        Me.Pineapple5.Size = New System.Drawing.Size(53, 50)
        Me.Pineapple5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pineapple5.TabIndex = 22
        Me.Pineapple5.TabStop = False
        Me.Pineapple5.Tag = "t2collectable"
        Me.Pineapple5.Visible = False
        '
        'Pineapple4
        '
        Me.Pineapple4.Image = Global._2D_Platformer.My.Resources.Resources.pineapple
        Me.Pineapple4.Location = New System.Drawing.Point(372, 339)
        Me.Pineapple4.Name = "Pineapple4"
        Me.Pineapple4.Size = New System.Drawing.Size(53, 50)
        Me.Pineapple4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pineapple4.TabIndex = 21
        Me.Pineapple4.TabStop = False
        Me.Pineapple4.Tag = "t2collectable"
        Me.Pineapple4.Visible = False
        '
        'Pineapple3
        '
        Me.Pineapple3.Image = Global._2D_Platformer.My.Resources.Resources.pineapple
        Me.Pineapple3.Location = New System.Drawing.Point(672, 70)
        Me.Pineapple3.Name = "Pineapple3"
        Me.Pineapple3.Size = New System.Drawing.Size(53, 50)
        Me.Pineapple3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pineapple3.TabIndex = 20
        Me.Pineapple3.TabStop = False
        Me.Pineapple3.Tag = "t2collectable"
        Me.Pineapple3.Visible = False
        '
        'Pineapple2
        '
        Me.Pineapple2.Image = Global._2D_Platformer.My.Resources.Resources.pineapple
        Me.Pineapple2.Location = New System.Drawing.Point(615, 166)
        Me.Pineapple2.Name = "Pineapple2"
        Me.Pineapple2.Size = New System.Drawing.Size(53, 50)
        Me.Pineapple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pineapple2.TabIndex = 19
        Me.Pineapple2.TabStop = False
        Me.Pineapple2.Tag = "t2collectable"
        Me.Pineapple2.Visible = False
        '
        'Pineapple1
        '
        Me.Pineapple1.Image = Global._2D_Platformer.My.Resources.Resources.pineapple
        Me.Pineapple1.Location = New System.Drawing.Point(204, 20)
        Me.Pineapple1.Name = "Pineapple1"
        Me.Pineapple1.Size = New System.Drawing.Size(53, 50)
        Me.Pineapple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pineapple1.TabIndex = 18
        Me.Pineapple1.TabStop = False
        Me.Pineapple1.Tag = "t2collectable"
        Me.Pineapple1.Visible = False
        '
        'picBomb
        '
        Me.picBomb.Image = Global._2D_Platformer.My.Resources.Resources.Bomb_icon_svg
        Me.picBomb.Location = New System.Drawing.Point(563, 9)
        Me.picBomb.Name = "picBomb"
        Me.picBomb.Size = New System.Drawing.Size(49, 50)
        Me.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBomb.TabIndex = 16
        Me.picBomb.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global._2D_Platformer.My.Resources.Resources.cherries
        Me.PictureBox9.Location = New System.Drawing.Point(310, 245)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(47, 43)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 13
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "t1collectable"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global._2D_Platformer.My.Resources.Resources.cherries
        Me.PictureBox8.Location = New System.Drawing.Point(310, 56)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(47, 43)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 12
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "t1collectable"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global._2D_Platformer.My.Resources.Resources.cherries
        Me.PictureBox7.Location = New System.Drawing.Point(621, 70)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(47, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "t1collectable"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global._2D_Platformer.My.Resources.Resources.cherries
        Me.PictureBox6.Location = New System.Drawing.Point(435, 151)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(47, 43)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "t1collectable"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global._2D_Platformer.My.Resources.Resources.cherries
        Me.PictureBox5.Location = New System.Drawing.Point(727, 332)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(47, 43)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "t1collectable"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global._2D_Platformer.My.Resources.Resources.cherries
        Me.PictureBox4.Location = New System.Drawing.Point(117, 70)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(47, 43)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "t1collectable"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Coral
        Me.PictureBox3.Location = New System.Drawing.Point(557, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 34)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Coral
        Me.PictureBox2.Location = New System.Drawing.Point(85, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 34)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Coral
        Me.PictureBox1.Location = New System.Drawing.Point(332, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 34)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global._2D_Platformer.My.Resources.Resources.smileyfat
        Me.picPlayer.Location = New System.Drawing.Point(35, 339)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(66, 61)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        Me.picPlayer.Visible = False
        '
        'picAir
        '
        Me.picAir.Image = Global._2D_Platformer.My.Resources.Resources._159432416_happy_concept_smilie_from_white_cloud_in_the_blue_sky
        Me.picAir.Location = New System.Drawing.Point(0, -2)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(799, 402)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'picGround
        '
        Me.picGround.Image = Global._2D_Platformer.My.Resources.Resources.dirt
        Me.picGround.Location = New System.Drawing.Point(0, 398)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(799, 58)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'Goldbar2
        '
        Me.Goldbar2.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar2.Location = New System.Drawing.Point(746, 245)
        Me.Goldbar2.Name = "Goldbar2"
        Me.Goldbar2.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar2.TabIndex = 25
        Me.Goldbar2.TabStop = False
        Me.Goldbar2.Tag = "t3collectable"
        Me.Goldbar2.Visible = False
        '
        'Goldbar3
        '
        Me.Goldbar3.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar3.Location = New System.Drawing.Point(735, 34)
        Me.Goldbar3.Name = "Goldbar3"
        Me.Goldbar3.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar3.TabIndex = 26
        Me.Goldbar3.TabStop = False
        Me.Goldbar3.Tag = "t3collectable"
        Me.Goldbar3.Visible = False
        '
        'Goldbar4
        '
        Me.Goldbar4.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar4.Location = New System.Drawing.Point(12, 9)
        Me.Goldbar4.Name = "Goldbar4"
        Me.Goldbar4.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar4.TabIndex = 27
        Me.Goldbar4.TabStop = False
        Me.Goldbar4.Tag = "t3collectable"
        Me.Goldbar4.Visible = False
        '
        'Goldbar5
        '
        Me.Goldbar5.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar5.Location = New System.Drawing.Point(12, 238)
        Me.Goldbar5.Name = "Goldbar5"
        Me.Goldbar5.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar5.TabIndex = 28
        Me.Goldbar5.TabStop = False
        Me.Goldbar5.Tag = "t3collectable"
        Me.Goldbar5.Visible = False
        '
        'Goldbar6
        '
        Me.Goldbar6.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar6.Location = New System.Drawing.Point(372, 103)
        Me.Goldbar6.Name = "Goldbar6"
        Me.Goldbar6.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar6.TabIndex = 29
        Me.Goldbar6.TabStop = False
        Me.Goldbar6.Tag = "t3collectable"
        Me.Goldbar6.Visible = False
        '
        'Goldbar7
        '
        Me.Goldbar7.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar7.Location = New System.Drawing.Point(465, 342)
        Me.Goldbar7.Name = "Goldbar7"
        Me.Goldbar7.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar7.TabIndex = 30
        Me.Goldbar7.TabStop = False
        Me.Goldbar7.Tag = "t3collectable"
        Me.Goldbar7.Visible = False
        '
        'Goldbar8
        '
        Me.Goldbar8.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar8.Location = New System.Drawing.Point(541, 269)
        Me.Goldbar8.Name = "Goldbar8"
        Me.Goldbar8.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar8.TabIndex = 31
        Me.Goldbar8.TabStop = False
        Me.Goldbar8.Tag = "t3collectable"
        Me.Goldbar8.Visible = False
        '
        'Goldbar9
        '
        Me.Goldbar9.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar9.Location = New System.Drawing.Point(192, 166)
        Me.Goldbar9.Name = "Goldbar9"
        Me.Goldbar9.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar9.TabIndex = 32
        Me.Goldbar9.TabStop = False
        Me.Goldbar9.Tag = "t3collectable"
        Me.Goldbar9.Visible = False
        '
        'Goldbar10
        '
        Me.Goldbar10.Image = Global._2D_Platformer.My.Resources.Resources.gold_bars
        Me.Goldbar10.Location = New System.Drawing.Point(241, 294)
        Me.Goldbar10.Name = "Goldbar10"
        Me.Goldbar10.Size = New System.Drawing.Size(53, 50)
        Me.Goldbar10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Goldbar10.TabIndex = 33
        Me.Goldbar10.TabStop = False
        Me.Goldbar10.Tag = "t3collectable"
        Me.Goldbar10.Visible = False
        '
        'ButRestart
        '
        Me.ButRestart.Location = New System.Drawing.Point(342, 269)
        Me.ButRestart.Name = "ButRestart"
        Me.ButRestart.Size = New System.Drawing.Size(120, 61)
        Me.ButRestart.TabIndex = 34
        Me.ButRestart.Text = "Start!"
        Me.ButRestart.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(841, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(805, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(594, 106)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Happy Game!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(838, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 64)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButRestart)
        Me.Controls.Add(Me.Goldbar10)
        Me.Controls.Add(Me.labLoser)
        Me.Controls.Add(Me.Goldbar9)
        Me.Controls.Add(Me.Goldbar8)
        Me.Controls.Add(Me.Goldbar7)
        Me.Controls.Add(Me.Goldbar6)
        Me.Controls.Add(Me.Goldbar5)
        Me.Controls.Add(Me.Goldbar4)
        Me.Controls.Add(Me.Goldbar3)
        Me.Controls.Add(Me.Goldbar2)
        Me.Controls.Add(Me.Goldbar1)
        Me.Controls.Add(Me.Pineapple6)
        Me.Controls.Add(Me.Pineapple5)
        Me.Controls.Add(Me.Pineapple4)
        Me.Controls.Add(Me.Pineapple3)
        Me.Controls.Add(Me.Pineapple2)
        Me.Controls.Add(Me.Pineapple1)
        Me.Controls.Add(Me.picBomb)
        Me.Controls.Add(Me.LabBombTime)
        Me.Controls.Add(Me.labWinner)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.labScore)
        Me.Controls.Add(Me.labPoints)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Goldbar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pineapple6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pineapple5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pineapple4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pineapple3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pineapple2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pineapple1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBomb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goldbar10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents labPoints As Label
    Friend WithEvents labScore As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents labWinner As Label
    Friend WithEvents tmrBomb As Timer
    Friend WithEvents LabBombTime As Label
    Friend WithEvents picBomb As PictureBox
    Friend WithEvents labLoser As Label
    Friend WithEvents Pineapple1 As PictureBox
    Friend WithEvents Pineapple2 As PictureBox
    Friend WithEvents Pineapple3 As PictureBox
    Friend WithEvents Pineapple4 As PictureBox
    Friend WithEvents Pineapple5 As PictureBox
    Friend WithEvents Pineapple6 As PictureBox
    Friend WithEvents Goldbar1 As PictureBox
    Friend WithEvents Goldbar2 As PictureBox
    Friend WithEvents Goldbar3 As PictureBox
    Friend WithEvents Goldbar4 As PictureBox
    Friend WithEvents Goldbar5 As PictureBox
    Friend WithEvents Goldbar6 As PictureBox
    Friend WithEvents Goldbar7 As PictureBox
    Friend WithEvents Goldbar8 As PictureBox
    Friend WithEvents Goldbar9 As PictureBox
    Friend WithEvents Goldbar10 As PictureBox
    Friend WithEvents ButRestart As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
