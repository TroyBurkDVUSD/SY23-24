<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.button_nes = New System.Windows.Forms.Button()
        Me.button_snes = New System.Windows.Forms.Button()
        Me.button_n64 = New System.Windows.Forms.Button()
        Me.button_gc = New System.Windows.Forms.Button()
        Me.button_wii = New System.Windows.Forms.Button()
        Me.button_Customize = New System.Windows.Forms.Button()
        Me.PB_conslogo = New System.Windows.Forms.PictureBox()
        Me.PB_consDisplay = New System.Windows.Forms.PictureBox()
        Me.label_Price = New System.Windows.Forms.Label()
        Me.button_Checkout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        'button_Customize
        '
        Me.button_Customize.Location = New System.Drawing.Point(219, 346)
        Me.button_Customize.Name = "button_Customize"
        Me.button_Customize.Size = New System.Drawing.Size(199, 92)
        Me.button_Customize.TabIndex = 10
        Me.button_Customize.Text = "Customize"
        Me.button_Customize.UseVisualStyleBackColor = True
        Me.button_Customize.Visible = False
        '
        'PB_conslogo
        '
        Me.PB_conslogo.BackColor = System.Drawing.Color.DarkGray
        Me.PB_conslogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_conslogo.Image = Global.NintendoPartnerProject.My.Resources.Resources.cooltext_snes
        Me.PB_conslogo.Location = New System.Drawing.Point(632, 12)
        Me.PB_conslogo.Name = "PB_conslogo"
        Me.PB_conslogo.Size = New System.Drawing.Size(116, 59)
        Me.PB_conslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_conslogo.TabIndex = 11
        Me.PB_conslogo.TabStop = False
        '
        'PB_consDisplay
        '
        Me.PB_consDisplay.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PB_consDisplay.Image = Global.NintendoPartnerProject.My.Resources.Resources.snes_new
        Me.PB_consDisplay.Location = New System.Drawing.Point(219, 12)
        Me.PB_consDisplay.Name = "PB_consDisplay"
        Me.PB_consDisplay.Size = New System.Drawing.Size(318, 159)
        Me.PB_consDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_consDisplay.TabIndex = 6
        Me.PB_consDisplay.TabStop = False
        '
        'label_Price
        '
        Me.label_Price.AutoSize = True
        Me.label_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Price.Location = New System.Drawing.Point(316, 244)
        Me.label_Price.Name = "label_Price"
        Me.label_Price.Size = New System.Drawing.Size(273, 76)
        Me.label_Price.TabIndex = 14
        Me.label_Price.Text = "$000.00"
        '
        'button_Checkout
        '
        Me.button_Checkout.Location = New System.Drawing.Point(462, 346)
        Me.button_Checkout.Name = "button_Checkout"
        Me.button_Checkout.Size = New System.Drawing.Size(199, 92)
        Me.button_Checkout.TabIndex = 15
        Me.button_Checkout.Text = "Checkout"
        Me.button_Checkout.UseVisualStyleBackColor = True
        Me.button_Checkout.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NintendoPartnerProject.My.Resources.Resources.hexbackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button_Checkout)
        Me.Controls.Add(Me.label_Price)
        Me.Controls.Add(Me.PB_conslogo)
        Me.Controls.Add(Me.button_Customize)
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
    Friend WithEvents button_Customize As Button
    Friend WithEvents PB_conslogo As PictureBox
    Friend WithEvents label_Price As Label
    Friend WithEvents button_Checkout As Button
    Friend WithEvents Timer1 As Timer
End Class
