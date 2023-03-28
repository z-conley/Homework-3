<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcatering
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
        Me.Groupchoices = New System.Windows.Forms.GroupBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblStar = New System.Windows.Forms.Label()
        Me.Grouppayment = New System.Windows.Forms.GroupBox()
        Me.Btncalc = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Txtpoints = New System.Windows.Forms.TextBox()
        Me.Lblloyal = New System.Windows.Forms.Label()
        Me.Picplatter = New System.Windows.Forms.PictureBox()
        Me.Radpre = New System.Windows.Forms.RadioButton()
        Me.Radpickup = New System.Windows.Forms.RadioButton()
        Me.Radcheese = New System.Windows.Forms.RadioButton()
        Me.Radwraps = New System.Windows.Forms.RadioButton()
        Me.Radveggie = New System.Windows.Forms.RadioButton()
        Me.Radsausage = New System.Windows.Forms.RadioButton()
        Me.Radfruit = New System.Windows.Forms.RadioButton()
        Me.Lblpay = New System.Windows.Forms.Label()
        Me.Lblplzpay = New System.Windows.Forms.Label()
        Me.Groupchoices.SuspendLayout()
        Me.Grouppayment.SuspendLayout()
        CType(Me.Picplatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Groupchoices
        '
        Me.Groupchoices.BackColor = System.Drawing.Color.LemonChiffon
        Me.Groupchoices.Controls.Add(Me.Radfruit)
        Me.Groupchoices.Controls.Add(Me.Radsausage)
        Me.Groupchoices.Controls.Add(Me.Radveggie)
        Me.Groupchoices.Controls.Add(Me.Radwraps)
        Me.Groupchoices.Controls.Add(Me.Radcheese)
        Me.Groupchoices.Location = New System.Drawing.Point(62, 85)
        Me.Groupchoices.Name = "Groupchoices"
        Me.Groupchoices.Size = New System.Drawing.Size(277, 188)
        Me.Groupchoices.TabIndex = 0
        Me.Groupchoices.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(121, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(159, 36)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Catering"
        '
        'LblStar
        '
        Me.LblStar.AutoSize = True
        Me.LblStar.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStar.Location = New System.Drawing.Point(127, 45)
        Me.LblStar.Name = "LblStar"
        Me.LblStar.Size = New System.Drawing.Size(147, 24)
        Me.LblStar.TabIndex = 2
        Me.LblStar.Text = "Star market"
        '
        'Grouppayment
        '
        Me.Grouppayment.BackColor = System.Drawing.Color.LemonChiffon
        Me.Grouppayment.Controls.Add(Me.Radpickup)
        Me.Grouppayment.Controls.Add(Me.Radpre)
        Me.Grouppayment.Location = New System.Drawing.Point(95, 279)
        Me.Grouppayment.Name = "Grouppayment"
        Me.Grouppayment.Size = New System.Drawing.Size(210, 90)
        Me.Grouppayment.TabIndex = 3
        Me.Grouppayment.TabStop = False
        '
        'Btncalc
        '
        Me.Btncalc.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Btncalc.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncalc.Location = New System.Drawing.Point(446, 290)
        Me.Btncalc.Name = "Btncalc"
        Me.Btncalc.Size = New System.Drawing.Size(117, 30)
        Me.Btncalc.TabIndex = 4
        Me.Btncalc.Text = "Calculate"
        Me.Btncalc.UseVisualStyleBackColor = False
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Btnclear.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.Location = New System.Drawing.Point(651, 290)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(117, 30)
        Me.Btnclear.TabIndex = 5
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'Txtpoints
        '
        Me.Txtpoints.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpoints.Location = New System.Drawing.Point(667, 231)
        Me.Txtpoints.Name = "Txtpoints"
        Me.Txtpoints.Size = New System.Drawing.Size(58, 25)
        Me.Txtpoints.TabIndex = 6
        Me.Txtpoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lblloyal
        '
        Me.Lblloyal.AutoSize = True
        Me.Lblloyal.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblloyal.Location = New System.Drawing.Point(451, 239)
        Me.Lblloyal.Name = "Lblloyal"
        Me.Lblloyal.Size = New System.Drawing.Size(128, 17)
        Me.Lblloyal.TabIndex = 7
        Me.Lblloyal.Text = "Loyalty points:"
        '
        'Picplatter
        '
        Me.Picplatter.Image = Global.Homework_3.My.Resources.Resources.platter
        Me.Picplatter.Location = New System.Drawing.Point(454, 9)
        Me.Picplatter.Name = "Picplatter"
        Me.Picplatter.Size = New System.Drawing.Size(334, 199)
        Me.Picplatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picplatter.TabIndex = 8
        Me.Picplatter.TabStop = False
        '
        'Radpre
        '
        Me.Radpre.AutoSize = True
        Me.Radpre.Checked = True
        Me.Radpre.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radpre.Location = New System.Drawing.Point(7, 25)
        Me.Radpre.Name = "Radpre"
        Me.Radpre.Size = New System.Drawing.Size(82, 21)
        Me.Radpre.TabIndex = 0
        Me.Radpre.TabStop = True
        Me.Radpre.Text = "Pre-Pay"
        Me.Radpre.UseVisualStyleBackColor = True
        '
        'Radpickup
        '
        Me.Radpickup.AutoSize = True
        Me.Radpickup.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radpickup.Location = New System.Drawing.Point(7, 58)
        Me.Radpickup.Name = "Radpickup"
        Me.Radpickup.Size = New System.Drawing.Size(146, 21)
        Me.Radpickup.TabIndex = 1
        Me.Radpickup.Text = "Pay Upon Pickup"
        Me.Radpickup.UseVisualStyleBackColor = True
        '
        'Radcheese
        '
        Me.Radcheese.AutoSize = True
        Me.Radcheese.Checked = True
        Me.Radcheese.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radcheese.Location = New System.Drawing.Point(7, 20)
        Me.Radcheese.Name = "Radcheese"
        Me.Radcheese.Size = New System.Drawing.Size(193, 21)
        Me.Radcheese.TabIndex = 0
        Me.Radcheese.TabStop = True
        Me.Radcheese.Text = "Gourmet cheese $49.99"
        Me.Radcheese.UseVisualStyleBackColor = True
        '
        'Radwraps
        '
        Me.Radwraps.AutoSize = True
        Me.Radwraps.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radwraps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Radwraps.Location = New System.Drawing.Point(7, 54)
        Me.Radwraps.Name = "Radwraps"
        Me.Radwraps.Size = New System.Drawing.Size(193, 21)
        Me.Radwraps.TabIndex = 1
        Me.Radwraps.Text = "Pinwheel Wraps $59.99"
        Me.Radwraps.UseVisualStyleBackColor = True
        '
        'Radveggie
        '
        Me.Radveggie.AutoSize = True
        Me.Radveggie.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radveggie.Location = New System.Drawing.Point(7, 89)
        Me.Radveggie.Name = "Radveggie"
        Me.Radveggie.Size = New System.Drawing.Size(128, 21)
        Me.Radveggie.TabIndex = 2
        Me.Radveggie.Text = "Veggie $29.99"
        Me.Radveggie.UseVisualStyleBackColor = True
        '
        'Radsausage
        '
        Me.Radsausage.AutoSize = True
        Me.Radsausage.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radsausage.Location = New System.Drawing.Point(7, 122)
        Me.Radsausage.Name = "Radsausage"
        Me.Radsausage.Size = New System.Drawing.Size(226, 21)
        Me.Radsausage.TabIndex = 3
        Me.Radsausage.Text = "Sausage and Cheese $49.99"
        Me.Radsausage.UseVisualStyleBackColor = True
        '
        'Radfruit
        '
        Me.Radfruit.AutoSize = True
        Me.Radfruit.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radfruit.Location = New System.Drawing.Point(7, 154)
        Me.Radfruit.Name = "Radfruit"
        Me.Radfruit.Size = New System.Drawing.Size(116, 21)
        Me.Radfruit.TabIndex = 4
        Me.Radfruit.Text = "Fruit $29.99"
        Me.Radfruit.UseVisualStyleBackColor = True
        '
        'Lblpay
        '
        Me.Lblpay.AutoSize = True
        Me.Lblpay.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpay.Location = New System.Drawing.Point(98, 390)
        Me.Lblpay.Name = "Lblpay"
        Me.Lblpay.Size = New System.Drawing.Size(137, 24)
        Me.Lblpay.TabIndex = 9
        Me.Lblpay.Text = "Please pay:"
        '
        'Lblplzpay
        '
        Me.Lblplzpay.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblplzpay.Location = New System.Drawing.Point(262, 393)
        Me.Lblplzpay.Name = "Lblplzpay"
        Me.Lblplzpay.Size = New System.Drawing.Size(506, 48)
        Me.Lblplzpay.TabIndex = 10
        Me.Lblplzpay.Text = "Label1"
        '
        'Frmcatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblplzpay)
        Me.Controls.Add(Me.Lblpay)
        Me.Controls.Add(Me.Picplatter)
        Me.Controls.Add(Me.Lblloyal)
        Me.Controls.Add(Me.Txtpoints)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btncalc)
        Me.Controls.Add(Me.Grouppayment)
        Me.Controls.Add(Me.LblStar)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.Groupchoices)
        Me.Name = "Frmcatering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        Me.Groupchoices.ResumeLayout(False)
        Me.Groupchoices.PerformLayout()
        Me.Grouppayment.ResumeLayout(False)
        Me.Grouppayment.PerformLayout()
        CType(Me.Picplatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Groupchoices As GroupBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblStar As Label
    Friend WithEvents Grouppayment As GroupBox
    Friend WithEvents Btncalc As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Txtpoints As TextBox
    Friend WithEvents Lblloyal As Label
    Friend WithEvents Picplatter As PictureBox
    Friend WithEvents Radfruit As RadioButton
    Friend WithEvents Radsausage As RadioButton
    Friend WithEvents Radveggie As RadioButton
    Friend WithEvents Radwraps As RadioButton
    Friend WithEvents Radcheese As RadioButton
    Friend WithEvents Radpickup As RadioButton
    Friend WithEvents Radpre As RadioButton
    Friend WithEvents Lblpay As Label
    Friend WithEvents Lblplzpay As Label
End Class
