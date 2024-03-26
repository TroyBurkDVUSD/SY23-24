<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customization
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customization))
        Me.nup_addGame = New System.Windows.Forms.NumericUpDown()
        Me.button_gotoCheckout = New System.Windows.Forms.Button()
        Me.CB_HDMI = New System.Windows.Forms.CheckBox()
        Me.CB_refurbished = New System.Windows.Forms.CheckBox()
        Me.CB_addController = New System.Windows.Forms.CheckBox()
        Me.CB_addGame = New System.Windows.Forms.CheckBox()
        Me.CB_used = New System.Windows.Forms.CheckBox()
        Me.label_Price = New System.Windows.Forms.Label()
        Me.PB_Console = New System.Windows.Forms.PictureBox()
        Me.label_Title = New System.Windows.Forms.Label()
        Me.nup_addController = New System.Windows.Forms.NumericUpDown()
        Me.nup_HDMI = New System.Windows.Forms.NumericUpDown()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.nup_addGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Console, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_addController, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_HDMI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nup_addGame
        '
        Me.nup_addGame.Location = New System.Drawing.Point(653, 140)
        Me.nup_addGame.Name = "nup_addGame"
        Me.nup_addGame.Size = New System.Drawing.Size(45, 22)
        Me.nup_addGame.TabIndex = 29
        Me.nup_addGame.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nup_addGame.Visible = False
        '
        'button_gotoCheckout
        '
        Me.button_gotoCheckout.Location = New System.Drawing.Point(502, 312)
        Me.button_gotoCheckout.Name = "button_gotoCheckout"
        Me.button_gotoCheckout.Size = New System.Drawing.Size(145, 73)
        Me.button_gotoCheckout.TabIndex = 28
        Me.button_gotoCheckout.Text = "Procede to Checkout"
        Me.button_gotoCheckout.UseVisualStyleBackColor = True
        '
        'CB_HDMI
        '
        Me.CB_HDMI.AutoSize = True
        Me.CB_HDMI.Location = New System.Drawing.Point(502, 194)
        Me.CB_HDMI.Name = "CB_HDMI"
        Me.CB_HDMI.Size = New System.Drawing.Size(95, 20)
        Me.CB_HDMI.TabIndex = 27
        Me.CB_HDMI.Text = "HDMI Cord"
        Me.CB_HDMI.UseVisualStyleBackColor = True
        '
        'CB_refurbished
        '
        Me.CB_refurbished.AutoSize = True
        Me.CB_refurbished.Location = New System.Drawing.Point(399, 182)
        Me.CB_refurbished.Name = "CB_refurbished"
        Me.CB_refurbished.Size = New System.Drawing.Size(102, 20)
        Me.CB_refurbished.TabIndex = 26
        Me.CB_refurbished.Text = "Refurbished"
        Me.CB_refurbished.UseVisualStyleBackColor = True
        '
        'CB_addController
        '
        Me.CB_addController.AutoSize = True
        Me.CB_addController.Location = New System.Drawing.Point(502, 168)
        Me.CB_addController.Name = "CB_addController"
        Me.CB_addController.Size = New System.Drawing.Size(149, 20)
        Me.CB_addController.TabIndex = 25
        Me.CB_addController.Text = "Additional Controller"
        Me.CB_addController.UseVisualStyleBackColor = True
        '
        'CB_addGame
        '
        Me.CB_addGame.AutoSize = True
        Me.CB_addGame.Location = New System.Drawing.Point(502, 142)
        Me.CB_addGame.Name = "CB_addGame"
        Me.CB_addGame.Size = New System.Drawing.Size(129, 20)
        Me.CB_addGame.TabIndex = 24
        Me.CB_addGame.Text = "Additional Game"
        Me.CB_addGame.UseVisualStyleBackColor = True
        '
        'CB_used
        '
        Me.CB_used.AutoSize = True
        Me.CB_used.Location = New System.Drawing.Point(399, 156)
        Me.CB_used.Name = "CB_used"
        Me.CB_used.Size = New System.Drawing.Size(62, 20)
        Me.CB_used.TabIndex = 23
        Me.CB_used.Text = "Used"
        Me.CB_used.UseVisualStyleBackColor = True
        '
        'label_Price
        '
        Me.label_Price.AutoSize = True
        Me.label_Price.Location = New System.Drawing.Point(464, 241)
        Me.label_Price.Name = "label_Price"
        Me.label_Price.Size = New System.Drawing.Size(48, 16)
        Me.label_Price.TabIndex = 22
        Me.label_Price.Text = "Label2"
        '
        'PB_Console
        '
        Me.PB_Console.Location = New System.Drawing.Point(66, 109)
        Me.PB_Console.Name = "PB_Console"
        Me.PB_Console.Size = New System.Drawing.Size(213, 158)
        Me.PB_Console.TabIndex = 21
        Me.PB_Console.TabStop = False
        '
        'label_Title
        '
        Me.label_Title.AutoSize = True
        Me.label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Title.Location = New System.Drawing.Point(266, 9)
        Me.label_Title.Name = "label_Title"
        Me.label_Title.Size = New System.Drawing.Size(310, 46)
        Me.label_Title.TabIndex = 30
        Me.label_Title.Text = "Custominzation"
        '
        'nup_addController
        '
        Me.nup_addController.Location = New System.Drawing.Point(653, 168)
        Me.nup_addController.Name = "nup_addController"
        Me.nup_addController.Size = New System.Drawing.Size(45, 22)
        Me.nup_addController.TabIndex = 31
        Me.nup_addController.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nup_addController.Visible = False
        '
        'nup_HDMI
        '
        Me.nup_HDMI.Location = New System.Drawing.Point(653, 194)
        Me.nup_HDMI.Name = "nup_HDMI"
        Me.nup_HDMI.Size = New System.Drawing.Size(45, 22)
        Me.nup_HDMI.TabIndex = 32
        Me.nup_HDMI.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nup_HDMI.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "fat kirby.png")
        '
        'Customization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nup_HDMI)
        Me.Controls.Add(Me.nup_addController)
        Me.Controls.Add(Me.label_Title)
        Me.Controls.Add(Me.nup_addGame)
        Me.Controls.Add(Me.button_gotoCheckout)
        Me.Controls.Add(Me.CB_HDMI)
        Me.Controls.Add(Me.CB_refurbished)
        Me.Controls.Add(Me.CB_addController)
        Me.Controls.Add(Me.CB_addGame)
        Me.Controls.Add(Me.CB_used)
        Me.Controls.Add(Me.label_Price)
        Me.Controls.Add(Me.PB_Console)
        Me.Name = "Customization"
        Me.Text = "Customization"
        CType(Me.nup_addGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Console, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_addController, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_HDMI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nup_addGame As NumericUpDown
    Friend WithEvents button_gotoCheckout As Button
    Friend WithEvents CB_HDMI As CheckBox
    Friend WithEvents CB_refurbished As CheckBox
    Friend WithEvents CB_addController As CheckBox
    Friend WithEvents CB_addGame As CheckBox
    Friend WithEvents CB_used As CheckBox
    Friend WithEvents label_Price As Label
    Friend WithEvents PB_Console As PictureBox
    Friend WithEvents label_Title As Label
    Friend WithEvents nup_addController As NumericUpDown
    Friend WithEvents nup_HDMI As NumericUpDown
    Friend WithEvents ImageList1 As ImageList
End Class
