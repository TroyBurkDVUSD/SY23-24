<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.IDTB = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ProductPB = New System.Windows.Forms.PictureBox()
        Me.Dimes = New System.Windows.Forms.PictureBox()
        Me.Dollars = New System.Windows.Forms.PictureBox()
        Me.Nickles = New System.Windows.Forms.PictureBox()
        Me.Quarter = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductControl16 = New Vending_machine.ProductControl()
        Me.ProductControl15 = New Vending_machine.ProductControl()
        Me.ProductControl14 = New Vending_machine.ProductControl()
        Me.ProductControl13 = New Vending_machine.ProductControl()
        Me.ProductControl12 = New Vending_machine.ProductControl()
        Me.ProductControl11 = New Vending_machine.ProductControl()
        Me.ProductControl10 = New Vending_machine.ProductControl()
        Me.ProductControl9 = New Vending_machine.ProductControl()
        Me.ProductControl8 = New Vending_machine.ProductControl()
        Me.ProductControl7 = New Vending_machine.ProductControl()
        Me.ProductControl6 = New Vending_machine.ProductControl()
        Me.ProductControl5 = New Vending_machine.ProductControl()
        Me.ProductControl4 = New Vending_machine.ProductControl()
        Me.ProductControl3 = New Vending_machine.ProductControl()
        Me.ProductControl2 = New Vending_machine.ProductControl()
        Me.ProductControl1 = New Vending_machine.ProductControl()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTB
        '
        Me.IDTB.Location = New System.Drawing.Point(736, 91)
        Me.IDTB.Multiline = True
        Me.IDTB.Name = "IDTB"
        Me.IDTB.Size = New System.Drawing.Size(96, 32)
        Me.IDTB.TabIndex = 31
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(701, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 48)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(771, 324)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 48)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(758, 65)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(48, 16)
        Me.TotalLabel.TabIndex = 20
        Me.TotalLabel.Text = "Label1"
        '
        'ProductPB
        '
        Me.ProductPB.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ProductPB.Location = New System.Drawing.Point(255, 636)
        Me.ProductPB.Name = "ProductPB"
        Me.ProductPB.Size = New System.Drawing.Size(150, 135)
        Me.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPB.TabIndex = 32
        Me.ProductPB.TabStop = False
        '
        'Dimes
        '
        Me.Dimes.Image = Global.Vending_machine.My.Resources.Resources.dime
        Me.Dimes.Location = New System.Drawing.Point(714, 680)
        Me.Dimes.Name = "Dimes"
        Me.Dimes.Size = New System.Drawing.Size(118, 91)
        Me.Dimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dimes.TabIndex = 25
        Me.Dimes.TabStop = False
        Me.Dimes.Visible = False
        '
        'Dollars
        '
        Me.Dollars.Image = Global.Vending_machine.My.Resources.Resources.Dollar
        Me.Dollars.Location = New System.Drawing.Point(485, 680)
        Me.Dollars.Name = "Dollars"
        Me.Dollars.Size = New System.Drawing.Size(126, 91)
        Me.Dollars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dollars.TabIndex = 24
        Me.Dollars.TabStop = False
        Me.Dollars.Visible = False
        '
        'Nickles
        '
        Me.Nickles.Image = Global.Vending_machine.My.Resources.Resources.nickles
        Me.Nickles.Location = New System.Drawing.Point(819, 680)
        Me.Nickles.Name = "Nickles"
        Me.Nickles.Size = New System.Drawing.Size(118, 91)
        Me.Nickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Nickles.TabIndex = 23
        Me.Nickles.TabStop = False
        Me.Nickles.Visible = False
        '
        'Quarter
        '
        Me.Quarter.Image = Global.Vending_machine.My.Resources.Resources.Quart
        Me.Quarter.Location = New System.Drawing.Point(589, 680)
        Me.Quarter.Name = "Quarter"
        Me.Quarter.Size = New System.Drawing.Size(136, 91)
        Me.Quarter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Quarter.TabIndex = 22
        Me.Quarter.TabStop = False
        Me.Quarter.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Vending_machine.My.Resources.Resources.Dollar
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(860, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 69)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Dollar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Vending_machine.My.Resources.Resources.dime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(860, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 69)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Vending_machine.My.Resources.Resources.nickles
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(860, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 69)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Nickles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Vending_machine.My.Resources.Resources.Quart
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(860, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 69)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Quarter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductControl16
        '
        Me.ProductControl16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl16.Location = New System.Drawing.Point(485, 480)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.Picture = Global.Vending_machine.My.Resources.Resources.dor
        Me.ProductControl16.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl16.ProductCount = 5
        Me.ProductControl16.ProductID = "A16"
        Me.ProductControl16.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl16.TabIndex = 44
        '
        'ProductControl15
        '
        Me.ProductControl15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl15.Location = New System.Drawing.Point(329, 480)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.Picture = Global.Vending_machine.My.Resources.Resources.Fun
        Me.ProductControl15.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl15.ProductCount = 5
        Me.ProductControl15.ProductID = "A15"
        Me.ProductControl15.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl15.TabIndex = 43
        '
        'ProductControl14
        '
        Me.ProductControl14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl14.Location = New System.Drawing.Point(168, 480)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.Picture = Global.Vending_machine.My.Resources.Resources.cheet
        Me.ProductControl14.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl14.ProductCount = 5
        Me.ProductControl14.ProductID = "A14"
        Me.ProductControl14.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl14.TabIndex = 42
        '
        'ProductControl13
        '
        Me.ProductControl13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl13.Location = New System.Drawing.Point(12, 480)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.Picture = Global.Vending_machine.My.Resources.Resources.dort
        Me.ProductControl13.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl13.ProductCount = 5
        Me.ProductControl13.ProductID = "A13"
        Me.ProductControl13.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl13.TabIndex = 41
        '
        'ProductControl12
        '
        Me.ProductControl12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl12.Location = New System.Drawing.Point(485, 324)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.Picture = Global.Vending_machine.My.Resources.Resources.nerds
        Me.ProductControl12.Price = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.ProductControl12.ProductCount = 5
        Me.ProductControl12.ProductID = "A12"
        Me.ProductControl12.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl12.TabIndex = 40
        '
        'ProductControl11
        '
        Me.ProductControl11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl11.Location = New System.Drawing.Point(329, 324)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.Picture = Global.Vending_machine.My.Resources.Resources._3
        Me.ProductControl11.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl11.ProductCount = 5
        Me.ProductControl11.ProductID = "A11"
        Me.ProductControl11.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl11.TabIndex = 39
        '
        'ProductControl10
        '
        Me.ProductControl10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl10.Location = New System.Drawing.Point(168, 324)
        Me.ProductControl10.Name = "ProductControl10"
        Me.ProductControl10.Picture = Global.Vending_machine.My.Resources.Resources.Snickers
        Me.ProductControl10.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl10.ProductCount = 5
        Me.ProductControl10.ProductID = "A10"
        Me.ProductControl10.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl10.TabIndex = 38
        '
        'ProductControl9
        '
        Me.ProductControl9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl9.Location = New System.Drawing.Point(12, 324)
        Me.ProductControl9.Name = "ProductControl9"
        Me.ProductControl9.Picture = Global.Vending_machine.My.Resources.Resources.Kit1
        Me.ProductControl9.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl9.ProductCount = 5
        Me.ProductControl9.ProductID = "A9"
        Me.ProductControl9.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl9.TabIndex = 37
        '
        'ProductControl8
        '
        Me.ProductControl8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl8.Location = New System.Drawing.Point(485, 168)
        Me.ProductControl8.Name = "ProductControl8"
        Me.ProductControl8.Picture = Global.Vending_machine.My.Resources.Resources.takis3
        Me.ProductControl8.Price = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.ProductControl8.ProductCount = 5
        Me.ProductControl8.ProductID = "A8"
        Me.ProductControl8.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl8.TabIndex = 36
        '
        'ProductControl7
        '
        Me.ProductControl7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl7.Location = New System.Drawing.Point(329, 168)
        Me.ProductControl7.Name = "ProductControl7"
        Me.ProductControl7.Picture = Global.Vending_machine.My.Resources.Resources.Takis21
        Me.ProductControl7.Price = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.ProductControl7.ProductCount = 5
        Me.ProductControl7.ProductID = "A7"
        Me.ProductControl7.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl7.TabIndex = 35
        '
        'ProductControl6
        '
        Me.ProductControl6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl6.Location = New System.Drawing.Point(168, 168)
        Me.ProductControl6.Name = "ProductControl6"
        Me.ProductControl6.Picture = Global.Vending_machine.My.Resources.Resources.Takis1
        Me.ProductControl6.Price = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.ProductControl6.ProductCount = 5
        Me.ProductControl6.ProductID = "A6"
        Me.ProductControl6.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl6.TabIndex = 34
        '
        'ProductControl5
        '
        Me.ProductControl5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl5.Location = New System.Drawing.Point(12, 168)
        Me.ProductControl5.Name = "ProductControl5"
        Me.ProductControl5.Picture = Global.Vending_machine.My.Resources.Resources.Takis
        Me.ProductControl5.Price = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.ProductControl5.ProductCount = 5
        Me.ProductControl5.ProductID = "A5"
        Me.ProductControl5.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl5.TabIndex = 33
        '
        'ProductControl4
        '
        Me.ProductControl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl4.Location = New System.Drawing.Point(485, 12)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.Picture = Global.Vending_machine.My.Resources.Resources.Lays
        Me.ProductControl4.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl4.ProductCount = 5
        Me.ProductControl4.ProductID = "A4"
        Me.ProductControl4.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl4.TabIndex = 29
        '
        'ProductControl3
        '
        Me.ProductControl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl3.Location = New System.Drawing.Point(324, 12)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.Picture = Global.Vending_machine.My.Resources.Resources.Barb
        Me.ProductControl3.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl3.ProductCount = 0
        Me.ProductControl3.ProductID = "A3"
        Me.ProductControl3.Size = New System.Drawing.Size(155, 150)
        Me.ProductControl3.TabIndex = 28
        '
        'ProductControl2
        '
        Me.ProductControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl2.Location = New System.Drawing.Point(168, 12)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.Picture = Global.Vending_machine.My.Resources.Resources.sour
        Me.ProductControl2.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl2.ProductCount = 5
        Me.ProductControl2.ProductID = "A2"
        Me.ProductControl2.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl2.TabIndex = 27
        '
        'ProductControl1
        '
        Me.ProductControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl1.Location = New System.Drawing.Point(12, 12)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.Picture = Global.Vending_machine.My.Resources.Resources.Doritos
        Me.ProductControl1.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl1.ProductCount = 5
        Me.ProductControl1.ProductID = "A1"
        Me.ProductControl1.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl1.TabIndex = 26
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(939, 775)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl10)
        Me.Controls.Add(Me.ProductControl9)
        Me.Controls.Add(Me.ProductControl8)
        Me.Controls.Add(Me.ProductControl7)
        Me.Controls.Add(Me.ProductControl6)
        Me.Controls.Add(Me.ProductControl5)
        Me.Controls.Add(Me.ProductPB)
        Me.Controls.Add(Me.IDTB)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.Dimes)
        Me.Controls.Add(Me.Dollars)
        Me.Controls.Add(Me.Nickles)
        Me.Controls.Add(Me.Quarter)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTB As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents ProductControl4 As ProductControl
    Friend WithEvents ProductControl3 As ProductControl
    Friend WithEvents ProductControl2 As ProductControl
    Friend WithEvents ProductControl1 As ProductControl
    Friend WithEvents Dimes As PictureBox
    Friend WithEvents Dollars As PictureBox
    Friend WithEvents Nickles As PictureBox
    Friend WithEvents Quarter As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductPB As PictureBox
    Friend WithEvents ProductControl5 As ProductControl
    Friend WithEvents ProductControl6 As ProductControl
    Friend WithEvents ProductControl7 As ProductControl
    Friend WithEvents ProductControl8 As ProductControl
    Friend WithEvents ProductControl9 As ProductControl
    Friend WithEvents ProductControl10 As ProductControl
    Friend WithEvents ProductControl11 As ProductControl
    Friend WithEvents ProductControl12 As ProductControl
    Friend WithEvents ProductControl13 As ProductControl
    Friend WithEvents ProductControl14 As ProductControl
    Friend WithEvents ProductControl15 As ProductControl
    Friend WithEvents ProductControl16 As ProductControl
End Class
