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
        Me.label_totalPricelabel = New System.Windows.Forms.Label()
        Me.label_ogPricelabel = New System.Windows.Forms.Label()
        Me.label_taxlabel = New System.Windows.Forms.Label()
        Me.label_total = New System.Windows.Forms.Label()
        Me.label_tax = New System.Windows.Forms.Label()
        Me.label_ogprice = New System.Windows.Forms.Label()
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
        'label_totalPricelabel
        '
        Me.label_totalPricelabel.AutoSize = True
        Me.label_totalPricelabel.Location = New System.Drawing.Point(313, 224)
        Me.label_totalPricelabel.Name = "label_totalPricelabel"
        Me.label_totalPricelabel.Size = New System.Drawing.Size(41, 16)
        Me.label_totalPricelabel.TabIndex = 20
        Me.label_totalPricelabel.Text = "Total:"
        '
        'label_ogPricelabel
        '
        Me.label_ogPricelabel.AutoSize = True
        Me.label_ogPricelabel.Location = New System.Drawing.Point(313, 146)
        Me.label_ogPricelabel.Name = "label_ogPricelabel"
        Me.label_ogPricelabel.Size = New System.Drawing.Size(41, 16)
        Me.label_ogPricelabel.TabIndex = 21
        Me.label_ogPricelabel.Text = "Price:"
        '
        'label_taxlabel
        '
        Me.label_taxlabel.AutoSize = True
        Me.label_taxlabel.Location = New System.Drawing.Point(318, 181)
        Me.label_taxlabel.Name = "label_taxlabel"
        Me.label_taxlabel.Size = New System.Drawing.Size(33, 16)
        Me.label_taxlabel.TabIndex = 22
        Me.label_taxlabel.Text = "Tax:"
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
        'label_ogprice
        '
        Me.label_ogprice.AutoSize = True
        Me.label_ogprice.Location = New System.Drawing.Point(378, 146)
        Me.label_ogprice.Name = "label_ogprice"
        Me.label_ogprice.Size = New System.Drawing.Size(48, 16)
        Me.label_ogprice.TabIndex = 25
        Me.label_ogprice.Text = "Label3"
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label_ogprice)
        Me.Controls.Add(Me.label_tax)
        Me.Controls.Add(Me.label_total)
        Me.Controls.Add(Me.label_taxlabel)
        Me.Controls.Add(Me.label_ogPricelabel)
        Me.Controls.Add(Me.label_totalPricelabel)
        Me.Controls.Add(Me.button_lastCheckout)
        Me.Controls.Add(Me.label_TItle)
        Me.Name = "Checkout"
        Me.Text = "Checkout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_lastCheckout As Button
    Friend WithEvents label_TItle As Label
    Friend WithEvents label_totalPricelabel As Label
    Friend WithEvents label_ogPricelabel As Label
    Friend WithEvents label_taxlabel As Label
    Friend WithEvents label_total As Label
    Friend WithEvents label_tax As Label
    Friend WithEvents label_ogprice As Label
End Class
