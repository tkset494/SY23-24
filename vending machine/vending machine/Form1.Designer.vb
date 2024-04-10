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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DollarReturn = New System.Windows.Forms.PictureBox()
        Me.QuarterReturn = New System.Windows.Forms.PictureBox()
        Me.DimeReturn = New System.Windows.Forms.PictureBox()
        Me.NickelReturn = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductControl116 = New vending_machine.ProductControl1()
        Me.ProductControl115 = New vending_machine.ProductControl1()
        Me.ProductControl114 = New vending_machine.ProductControl1()
        Me.ProductControl113 = New vending_machine.ProductControl1()
        Me.ProductControl112 = New vending_machine.ProductControl1()
        Me.ProductControl111 = New vending_machine.ProductControl1()
        Me.ProductControl110 = New vending_machine.ProductControl1()
        Me.ProductControl19 = New vending_machine.ProductControl1()
        Me.ProductControl18 = New vending_machine.ProductControl1()
        Me.ProductControl17 = New vending_machine.ProductControl1()
        Me.ProductControl16 = New vending_machine.ProductControl1()
        Me.ProductControl15 = New vending_machine.ProductControl1()
        Me.ProductControl14 = New vending_machine.ProductControl1()
        Me.ProductControl13 = New vending_machine.ProductControl1()
        Me.ProductControl12 = New vending_machine.ProductControl1()
        Me.ProductControl11 = New vending_machine.ProductControl1()
        CType(Me.DollarReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimeReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "$0.00"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 90)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "coin return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DollarReturn
        '
        Me.DollarReturn.Image = Global.vending_machine.My.Resources.Resources.download__10_
        Me.DollarReturn.Location = New System.Drawing.Point(12, 388)
        Me.DollarReturn.Name = "DollarReturn"
        Me.DollarReturn.Size = New System.Drawing.Size(50, 50)
        Me.DollarReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarReturn.TabIndex = 9
        Me.DollarReturn.TabStop = False
        Me.DollarReturn.Visible = False
        '
        'QuarterReturn
        '
        Me.QuarterReturn.Image = Global.vending_machine.My.Resources.Resources.quarter
        Me.QuarterReturn.Location = New System.Drawing.Point(68, 388)
        Me.QuarterReturn.Name = "QuarterReturn"
        Me.QuarterReturn.Size = New System.Drawing.Size(50, 50)
        Me.QuarterReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuarterReturn.TabIndex = 8
        Me.QuarterReturn.TabStop = False
        Me.QuarterReturn.Visible = False
        '
        'DimeReturn
        '
        Me.DimeReturn.Image = Global.vending_machine.My.Resources.Resources.dime
        Me.DimeReturn.Location = New System.Drawing.Point(124, 388)
        Me.DimeReturn.Name = "DimeReturn"
        Me.DimeReturn.Size = New System.Drawing.Size(50, 50)
        Me.DimeReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DimeReturn.TabIndex = 7
        Me.DimeReturn.TabStop = False
        Me.DimeReturn.Visible = False
        '
        'NickelReturn
        '
        Me.NickelReturn.Image = Global.vending_machine.My.Resources.Resources.Nickel
        Me.NickelReturn.Location = New System.Drawing.Point(180, 388)
        Me.NickelReturn.Name = "NickelReturn"
        Me.NickelReturn.Size = New System.Drawing.Size(50, 50)
        Me.NickelReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelReturn.TabIndex = 6
        Me.NickelReturn.TabStop = False
        Me.NickelReturn.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.vending_machine.My.Resources.Resources.Nickel
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(618, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 95)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.vending_machine.My.Resources.Resources.dime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(618, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 95)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.vending_machine.My.Resources.Resources.quarter
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(618, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 95)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.vending_machine.My.Resources.Resources.download__10_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(618, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 95)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(517, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 95)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTextBox1
        '
        Me.IDTextBox1.Location = New System.Drawing.Point(517, 351)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(95, 22)
        Me.IDTextBox1.TabIndex = 27
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(328, 375)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 28
        Me.ProductPictureBox.TabStop = False
        '
        'ProductControl116
        '
        Me.ProductControl116.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl116.count = 5
        Me.ProductControl116.Location = New System.Drawing.Point(315, 253)
        Me.ProductControl116.Name = "ProductControl116"
        Me.ProductControl116.picture = Global.vending_machine.My.Resources.Resources.mnm
        Me.ProductControl116.Price = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl116.ProductID = "D3"
        Me.ProductControl116.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl116.TabIndex = 25
        '
        'ProductControl115
        '
        Me.ProductControl115.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl115.count = 5
        Me.ProductControl115.Location = New System.Drawing.Point(214, 31)
        Me.ProductControl115.Name = "ProductControl115"
        Me.ProductControl115.picture = Global.vending_machine.My.Resources.Resources.gummybear
        Me.ProductControl115.Price = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.ProductControl115.ProductID = "C1"
        Me.ProductControl115.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl115.TabIndex = 24
        '
        'ProductControl114
        '
        Me.ProductControl114.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl114.count = 5
        Me.ProductControl114.Location = New System.Drawing.Point(113, 31)
        Me.ProductControl114.Name = "ProductControl114"
        Me.ProductControl114.picture = Global.vending_machine.My.Resources.Resources.sourkids
        Me.ProductControl114.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl114.ProductID = "B1"
        Me.ProductControl114.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl114.TabIndex = 23
        '
        'ProductControl113
        '
        Me.ProductControl113.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl113.count = 5
        Me.ProductControl113.Location = New System.Drawing.Point(315, 31)
        Me.ProductControl113.Name = "ProductControl113"
        Me.ProductControl113.picture = Global.vending_machine.My.Resources.Resources.nerds
        Me.ProductControl113.Price = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.ProductControl113.ProductID = "D1"
        Me.ProductControl113.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl113.TabIndex = 22
        '
        'ProductControl112
        '
        Me.ProductControl112.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl112.count = 5
        Me.ProductControl112.Location = New System.Drawing.Point(416, 31)
        Me.ProductControl112.Name = "ProductControl112"
        Me.ProductControl112.picture = Global.vending_machine.My.Resources.Resources.watermelon
        Me.ProductControl112.Price = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.ProductControl112.ProductID = "E1"
        Me.ProductControl112.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl112.TabIndex = 21
        '
        'ProductControl111
        '
        Me.ProductControl111.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl111.count = 5
        Me.ProductControl111.Location = New System.Drawing.Point(517, 31)
        Me.ProductControl111.Name = "ProductControl111"
        Me.ProductControl111.picture = Global.vending_machine.My.Resources.Resources.skittles
        Me.ProductControl111.Price = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl111.ProductID = "F1"
        Me.ProductControl111.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl111.TabIndex = 20
        '
        'ProductControl110
        '
        Me.ProductControl110.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl110.count = 5
        Me.ProductControl110.Location = New System.Drawing.Point(12, 142)
        Me.ProductControl110.Name = "ProductControl110"
        Me.ProductControl110.picture = Global.vending_machine.My.Resources.Resources.kitkat
        Me.ProductControl110.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl110.ProductID = "A2"
        Me.ProductControl110.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl110.TabIndex = 19
        '
        'ProductControl19
        '
        Me.ProductControl19.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl19.count = 5
        Me.ProductControl19.Location = New System.Drawing.Point(113, 142)
        Me.ProductControl19.Name = "ProductControl19"
        Me.ProductControl19.picture = Global.vending_machine.My.Resources.Resources.twix_bar
        Me.ProductControl19.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl19.ProductID = "B2"
        Me.ProductControl19.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl19.TabIndex = 18
        '
        'ProductControl18
        '
        Me.ProductControl18.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl18.count = 5
        Me.ProductControl18.Location = New System.Drawing.Point(214, 142)
        Me.ProductControl18.Name = "ProductControl18"
        Me.ProductControl18.picture = Global.vending_machine.My.Resources.Resources.reeses_penut_buter_cup
        Me.ProductControl18.Price = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl18.ProductID = "C2"
        Me.ProductControl18.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl18.TabIndex = 17
        '
        'ProductControl17
        '
        Me.ProductControl17.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl17.count = 5
        Me.ProductControl17.Location = New System.Drawing.Point(315, 142)
        Me.ProductControl17.Name = "ProductControl17"
        Me.ProductControl17.picture = Global.vending_machine.My.Resources.Resources.takis
        Me.ProductControl17.Price = New Decimal(New Integer() {350, 0, 0, 131072})
        Me.ProductControl17.ProductID = "D2"
        Me.ProductControl17.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl17.TabIndex = 16
        '
        'ProductControl16
        '
        Me.ProductControl16.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl16.count = 5
        Me.ProductControl16.Location = New System.Drawing.Point(416, 142)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.picture = Global.vending_machine.My.Resources.Resources.cheetospuffs
        Me.ProductControl16.Price = New Decimal(New Integer() {350, 0, 0, 131072})
        Me.ProductControl16.ProductID = "E2"
        Me.ProductControl16.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl16.TabIndex = 15
        '
        'ProductControl15
        '
        Me.ProductControl15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl15.count = 5
        Me.ProductControl15.Location = New System.Drawing.Point(517, 142)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.picture = Global.vending_machine.My.Resources.Resources.cheetos
        Me.ProductControl15.Price = New Decimal(New Integer() {350, 0, 0, 131072})
        Me.ProductControl15.ProductID = "F2"
        Me.ProductControl15.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl15.TabIndex = 14
        '
        'ProductControl14
        '
        Me.ProductControl14.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl14.count = 5
        Me.ProductControl14.Location = New System.Drawing.Point(113, 253)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.picture = Global.vending_machine.My.Resources.Resources.bluedorit
        Me.ProductControl14.Price = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.ProductControl14.ProductID = "B3"
        Me.ProductControl14.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl14.TabIndex = 13
        '
        'ProductControl13
        '
        Me.ProductControl13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl13.count = 5
        Me.ProductControl13.Location = New System.Drawing.Point(214, 253)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.picture = Global.vending_machine.My.Resources.Resources.fritos
        Me.ProductControl13.Price = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.ProductControl13.ProductID = "C3"
        Me.ProductControl13.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl13.TabIndex = 12
        '
        'ProductControl12
        '
        Me.ProductControl12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl12.count = 5
        Me.ProductControl12.Location = New System.Drawing.Point(416, 253)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.picture = Global.vending_machine.My.Resources.Resources.lays
        Me.ProductControl12.Price = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.ProductControl12.ProductID = "E3"
        Me.ProductControl12.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl12.TabIndex = 11
        '
        'ProductControl11
        '
        Me.ProductControl11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl11.count = 5
        Me.ProductControl11.Location = New System.Drawing.Point(12, 31)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.picture = Global.vending_machine.My.Resources.Resources.doritos
        Me.ProductControl11.Price = New Decimal(New Integer() {350, 0, 0, 131072})
        Me.ProductControl11.ProductID = "A1"
        Me.ProductControl11.Size = New System.Drawing.Size(95, 105)
        Me.ProductControl11.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProductControl116)
        Me.Controls.Add(Me.ProductControl115)
        Me.Controls.Add(Me.ProductControl114)
        Me.Controls.Add(Me.ProductControl113)
        Me.Controls.Add(Me.ProductControl112)
        Me.Controls.Add(Me.ProductControl111)
        Me.Controls.Add(Me.ProductControl110)
        Me.Controls.Add(Me.ProductControl19)
        Me.Controls.Add(Me.ProductControl18)
        Me.Controls.Add(Me.ProductControl17)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.DollarReturn)
        Me.Controls.Add(Me.QuarterReturn)
        Me.Controls.Add(Me.DimeReturn)
        Me.Controls.Add(Me.NickelReturn)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DollarReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimeReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents NickelReturn As PictureBox
    Friend WithEvents DimeReturn As PictureBox
    Friend WithEvents QuarterReturn As PictureBox
    Friend WithEvents DollarReturn As PictureBox
    Friend WithEvents ProductControl11 As ProductControl1
    Friend WithEvents ProductControl12 As ProductControl1
    Friend WithEvents ProductControl13 As ProductControl1
    Friend WithEvents ProductControl14 As ProductControl1
    Friend WithEvents ProductControl15 As ProductControl1
    Friend WithEvents ProductControl16 As ProductControl1
    Friend WithEvents ProductControl17 As ProductControl1
    Friend WithEvents ProductControl18 As ProductControl1
    Friend WithEvents ProductControl19 As ProductControl1
    Friend WithEvents ProductControl110 As ProductControl1
    Friend WithEvents ProductControl111 As ProductControl1
    Friend WithEvents ProductControl112 As ProductControl1
    Friend WithEvents ProductControl113 As ProductControl1
    Friend WithEvents ProductControl114 As ProductControl1
    Friend WithEvents ProductControl115 As ProductControl1
    Friend WithEvents ProductControl116 As ProductControl1
    Friend WithEvents Button6 As Button
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents ProductPictureBox As PictureBox
End Class
