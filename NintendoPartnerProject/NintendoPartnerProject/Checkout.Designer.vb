<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Me.button_lastCheckout = New System.Windows.Forms.Button()
        Me.label_TItle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_total = New System.Windows.Forms.Label()
        Me.label_tax = New System.Windows.Forms.Label()
        Me.label_price = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button_lastCheckout
        '
        Me.button_lastCheckout.Location = New System.Drawing.Point(305, 293)
        Me.button_lastCheckout.Name = "button_lastCheckout"
        Me.button_lastCheckout.Size = New System.Drawing.Size(145, 73)
        Me.button_lastCheckout.TabIndex = 19
        Me.button_lastCheckout.Text = "Confirm"
        Me.button_lastCheckout.UseVisualStyleBackColor = True
        '
        'label_TItle
        '
        Me.label_TItle.AutoSize = True
        Me.label_TItle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_TItle.Location = New System.Drawing.Point(261, 22)
        Me.label_TItle.Name = "label_TItle"
        Me.label_TItle.Size = New System.Drawing.Size(245, 58)
        Me.label_TItle.TabIndex = 11
        Me.label_TItle.Text = "Checkout"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tax:"
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Location = New System.Drawing.Point(378, 224)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(48, 16)
        Me.label_total.TabIndex = 23
        Me.label_total.Text = "Label1"
        '
        'label_tax
        '
        Me.label_tax.AutoSize = True
        Me.label_tax.Location = New System.Drawing.Point(378, 181)
        Me.label_tax.Name = "label_tax"
        Me.label_tax.Size = New System.Drawing.Size(48, 16)
        Me.label_tax.TabIndex = 24
        Me.label_tax.Text = "Label2"
        '
        'label_price
        '
        Me.label_price.AutoSize = True
        Me.label_price.Location = New System.Drawing.Point(378, 146)
        Me.label_price.Name = "label_price"
        Me.label_price.Size = New System.Drawing.Size(48, 16)
        Me.label_price.TabIndex = 25
        Me.label_price.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NintendoPartnerProject.My.Resources.Resources.thankyousmiley
        Me.PictureBox1.Location = New System.Drawing.Point(144, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(496, 445)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_price)
        Me.Controls.Add(Me.label_tax)
        Me.Controls.Add(Me.label_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.button_lastCheckout)
        Me.Controls.Add(Me.label_TItle)
        Me.Name = "Checkout"
        Me.Text = "Checkout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_lastCheckout As Button
    Friend WithEvents label_TItle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label_total As Label
    Friend WithEvents label_tax As Label
    Friend WithEvents label_price As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
