﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.label_TItle = New System.Windows.Forms.Label()
        Me.PB_Console = New System.Windows.Forms.PictureBox()
        Me.label_Price = New System.Windows.Forms.Label()
        Me.CB_used = New System.Windows.Forms.CheckBox()
        Me.CB_addGame = New System.Windows.Forms.CheckBox()
        Me.CB_addController = New System.Windows.Forms.CheckBox()
        Me.CB_refurbished = New System.Windows.Forms.CheckBox()
        Me.CH_HDMI = New System.Windows.Forms.CheckBox()
        Me.button_lastCheckout = New System.Windows.Forms.Button()
        CType(Me.PB_Console, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_TItle
        '
        Me.label_TItle.AutoSize = True
        Me.label_TItle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_TItle.Location = New System.Drawing.Point(236, 14)
        Me.label_TItle.Name = "label_TItle"
        Me.label_TItle.Size = New System.Drawing.Size(237, 58)
        Me.label_TItle.TabIndex = 0
        Me.label_TItle.Text = "Checkout"
        '
        'PB_Console
        '
        Me.PB_Console.Location = New System.Drawing.Point(43, 97)
        Me.PB_Console.Name = "PB_Console"
        Me.PB_Console.Size = New System.Drawing.Size(213, 158)
        Me.PB_Console.TabIndex = 1
        Me.PB_Console.TabStop = False
        '
        'label_Price
        '
        Me.label_Price.AutoSize = True
        Me.label_Price.Location = New System.Drawing.Point(121, 276)
        Me.label_Price.Name = "label_Price"
        Me.label_Price.Size = New System.Drawing.Size(48, 16)
        Me.label_Price.TabIndex = 2
        Me.label_Price.Text = "Label2"
        '
        'CB_used
        '
        Me.CB_used.AutoSize = True
        Me.CB_used.Location = New System.Drawing.Point(376, 144)
        Me.CB_used.Name = "CB_used"
        Me.CB_used.Size = New System.Drawing.Size(62, 20)
        Me.CB_used.TabIndex = 5
        Me.CB_used.Text = "Used"
        Me.CB_used.UseVisualStyleBackColor = True
        '
        'CB_addGame
        '
        Me.CB_addGame.AutoSize = True
        Me.CB_addGame.Location = New System.Drawing.Point(479, 144)
        Me.CB_addGame.Name = "CB_addGame"
        Me.CB_addGame.Size = New System.Drawing.Size(129, 20)
        Me.CB_addGame.TabIndex = 6
        Me.CB_addGame.Text = "Additional Game"
        Me.CB_addGame.UseVisualStyleBackColor = True
        '
        'CB_addController
        '
        Me.CB_addController.AutoSize = True
        Me.CB_addController.Location = New System.Drawing.Point(479, 170)
        Me.CB_addController.Name = "CB_addController"
        Me.CB_addController.Size = New System.Drawing.Size(149, 20)
        Me.CB_addController.TabIndex = 7
        Me.CB_addController.Text = "Additional Controller"
        Me.CB_addController.UseVisualStyleBackColor = True
        '
        'CB_refurbished
        '
        Me.CB_refurbished.AutoSize = True
        Me.CB_refurbished.Location = New System.Drawing.Point(376, 170)
        Me.CB_refurbished.Name = "CB_refurbished"
        Me.CB_refurbished.Size = New System.Drawing.Size(102, 20)
        Me.CB_refurbished.TabIndex = 8
        Me.CB_refurbished.Text = "Refurbished"
        Me.CB_refurbished.UseVisualStyleBackColor = True
        '
        'CH_HDMI
        '
        Me.CH_HDMI.AutoSize = True
        Me.CH_HDMI.Location = New System.Drawing.Point(376, 196)
        Me.CH_HDMI.Name = "CH_HDMI"
        Me.CH_HDMI.Size = New System.Drawing.Size(95, 20)
        Me.CH_HDMI.TabIndex = 9
        Me.CH_HDMI.Text = "HDMI Cord"
        Me.CH_HDMI.UseVisualStyleBackColor = True
        '
        'button_lastCheckout
        '
        Me.button_lastCheckout.Location = New System.Drawing.Point(479, 300)
        Me.button_lastCheckout.Name = "button_lastCheckout"
        Me.button_lastCheckout.Size = New System.Drawing.Size(145, 73)
        Me.button_lastCheckout.TabIndex = 10
        Me.button_lastCheckout.Text = "Very Cool. Buy Now!"
        Me.button_lastCheckout.UseVisualStyleBackColor = True
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.button_lastCheckout)
        Me.Controls.Add(Me.CH_HDMI)
        Me.Controls.Add(Me.CB_refurbished)
        Me.Controls.Add(Me.CB_addController)
        Me.Controls.Add(Me.CB_addGame)
        Me.Controls.Add(Me.CB_used)
        Me.Controls.Add(Me.label_Price)
        Me.Controls.Add(Me.PB_Console)
        Me.Controls.Add(Me.label_TItle)
        Me.Name = "Checkout"
        Me.Size = New System.Drawing.Size(734, 404)
        CType(Me.PB_Console, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_TItle As Label
    Friend WithEvents PB_Console As PictureBox
    Friend WithEvents label_Price As Label
    Friend WithEvents CB_used As CheckBox
    Friend WithEvents CB_addGame As CheckBox
    Friend WithEvents CB_addController As CheckBox
    Friend WithEvents CB_refurbished As CheckBox
    Friend WithEvents CH_HDMI As CheckBox
    Friend WithEvents button_lastCheckout As Button
End Class
