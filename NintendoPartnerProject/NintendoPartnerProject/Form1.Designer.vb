﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.button_nes = New System.Windows.Forms.Button()
        Me.button_snes = New System.Windows.Forms.Button()
        Me.button_n64 = New System.Windows.Forms.Button()
        Me.button_gc = New System.Windows.Forms.Button()
        Me.button_wii = New System.Windows.Forms.Button()
        Me.button_Checkout = New System.Windows.Forms.Button()
        Me.PB_conslogo = New System.Windows.Forms.PictureBox()
        Me.PB_consDisplay = New System.Windows.Forms.PictureBox()
        Me.label_flavor = New System.Windows.Forms.Label()
        Me.label_consDescription = New System.Windows.Forms.Label()
        CType(Me.PB_conslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_consDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button_nes
        '
        Me.button_nes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_nes.Location = New System.Drawing.Point(12, 12)
        Me.button_nes.Name = "button_nes"
        Me.button_nes.Size = New System.Drawing.Size(114, 59)
        Me.button_nes.TabIndex = 0
        Me.button_nes.Text = "NES"
        Me.button_nes.UseVisualStyleBackColor = True
        '
        'button_snes
        '
        Me.button_snes.Location = New System.Drawing.Point(12, 77)
        Me.button_snes.Name = "button_snes"
        Me.button_snes.Size = New System.Drawing.Size(114, 59)
        Me.button_snes.TabIndex = 1
        Me.button_snes.Text = "SNES"
        Me.button_snes.UseVisualStyleBackColor = True
        '
        'button_n64
        '
        Me.button_n64.Location = New System.Drawing.Point(12, 142)
        Me.button_n64.Name = "button_n64"
        Me.button_n64.Size = New System.Drawing.Size(114, 59)
        Me.button_n64.TabIndex = 2
        Me.button_n64.Text = "N64"
        Me.button_n64.UseVisualStyleBackColor = True
        '
        'button_gc
        '
        Me.button_gc.Location = New System.Drawing.Point(12, 207)
        Me.button_gc.Name = "button_gc"
        Me.button_gc.Size = New System.Drawing.Size(114, 59)
        Me.button_gc.TabIndex = 3
        Me.button_gc.Text = "GC"
        Me.button_gc.UseVisualStyleBackColor = True
        '
        'button_wii
        '
        Me.button_wii.Location = New System.Drawing.Point(12, 272)
        Me.button_wii.Name = "button_wii"
        Me.button_wii.Size = New System.Drawing.Size(114, 59)
        Me.button_wii.TabIndex = 4
        Me.button_wii.Text = "WII"
        Me.button_wii.UseVisualStyleBackColor = True
        '
        'button_Checkout
        '
        Me.button_Checkout.Location = New System.Drawing.Point(219, 346)
        Me.button_Checkout.Name = "button_Checkout"
        Me.button_Checkout.Size = New System.Drawing.Size(199, 92)
        Me.button_Checkout.TabIndex = 10
        Me.button_Checkout.Text = "Checkout"
        Me.button_Checkout.UseVisualStyleBackColor = True
        '
        'PB_conslogo
        '
        Me.PB_conslogo.BackColor = System.Drawing.Color.DarkGray
        Me.PB_conslogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_conslogo.Image = Global.NintendoPartnerProject.My.Resources.Resources.Cool_Text___NES_454283385759727
        Me.PB_conslogo.Location = New System.Drawing.Point(504, 12)
        Me.PB_conslogo.Name = "PB_conslogo"
        Me.PB_conslogo.Size = New System.Drawing.Size(293, 124)
        Me.PB_conslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_conslogo.TabIndex = 11
        Me.PB_conslogo.TabStop = False
        '
        'PB_consDisplay
        '
        Me.PB_consDisplay.Location = New System.Drawing.Point(148, 12)
        Me.PB_consDisplay.Name = "PB_consDisplay"
        Me.PB_consDisplay.Size = New System.Drawing.Size(341, 277)
        Me.PB_consDisplay.TabIndex = 6
        Me.PB_consDisplay.TabStop = False
        '
        'label_flavor
        '
        Me.label_flavor.AutoSize = True
        Me.label_flavor.Location = New System.Drawing.Point(203, 306)
        Me.label_flavor.Name = "label_flavor"
        Me.label_flavor.Size = New System.Drawing.Size(215, 16)
        Me.label_flavor.TabIndex = 12
        Me.label_flavor.Text = "ONLY 50 REMAIN! MUST HURRY!"
        '
        'label_consDescription
        '
        Me.label_consDescription.AutoSize = True
        Me.label_consDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_consDescription.Location = New System.Drawing.Point(500, 146)
        Me.label_consDescription.Name = "label_consDescription"
        Me.label_consDescription.Size = New System.Drawing.Size(298, 120)
        Me.label_consDescription.TabIndex = 13
        Me.label_consDescription.Text = "PLACEHOLDER PLACEHOLDER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLACEHOLDER PLACEHOLDER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLACEHOLDER PLACEHOLDER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLACE" &
    "HOLDER PLACEHOLDER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLACEHOLDER PLACEHOLDER"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NintendoPartnerProject.My.Resources.Resources.dark_4487690_1280
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label_consDescription)
        Me.Controls.Add(Me.label_flavor)
        Me.Controls.Add(Me.PB_conslogo)
        Me.Controls.Add(Me.button_Checkout)
        Me.Controls.Add(Me.PB_consDisplay)
        Me.Controls.Add(Me.button_wii)
        Me.Controls.Add(Me.button_gc)
        Me.Controls.Add(Me.button_n64)
        Me.Controls.Add(Me.button_snes)
        Me.Controls.Add(Me.button_nes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PB_conslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_consDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_nes As Button
    Friend WithEvents button_snes As Button
    Friend WithEvents button_n64 As Button
    Friend WithEvents button_gc As Button
    Friend WithEvents button_wii As Button
    Friend WithEvents PB_consDisplay As PictureBox
    Friend WithEvents button_Checkout As Button
    Friend WithEvents PB_conslogo As PictureBox
    Friend WithEvents label_flavor As Label
    Friend WithEvents label_consDescription As Label
End Class
