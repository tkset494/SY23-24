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
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Winpicturebox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.coin3 = New System.Windows.Forms.PictureBox()
        Me.coin2 = New System.Windows.Forms.PictureBox()
        Me.coin1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.jump = New System.Windows.Forms.Timer(Me.components)
        Me.Mover4 = New platformer_game.Mover()
        Me.Mover3 = New platformer_game.Mover()
        Me.Mover1 = New platformer_game.Mover()
        Me.Mover2 = New platformer_game.Mover()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picplayer
        '
        Me.Picplayer.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Picplayer.Location = New System.Drawing.Point(17, 200)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(40, 40)
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'PicAir
        '
        Me.PicAir.BackColor = System.Drawing.Color.Transparent
        Me.PicAir.Location = New System.Drawing.Point(2, -126)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(818, 435)
        Me.PicAir.TabIndex = 1
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.Transparent
        Me.PicGround.Location = New System.Drawing.Point(2, 335)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(805, 114)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 30
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 30
        '
        'TmrUp
        '
        Me.TmrUp.Interval = 30
        '
        'TmrGameLogic
        '
        '
        'TmrGravity
        '
        Me.TmrGravity.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(182, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 13)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(407, 162)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 13)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(497, 98)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(173, 27)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'Winpicturebox
        '
        Me.Winpicturebox.BackColor = System.Drawing.Color.Gold
        Me.Winpicturebox.Location = New System.Drawing.Point(625, 42)
        Me.Winpicturebox.Name = "Winpicturebox"
        Me.Winpicturebox.Size = New System.Drawing.Size(45, 50)
        Me.Winpicturebox.TabIndex = 8
        Me.Winpicturebox.TabStop = False
        Me.Winpicturebox.Tag = "win"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Location = New System.Drawing.Point(231, 234)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "enemy"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(693, -48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(-12858, 31862)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(76, 43)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Red
        Me.PictureBox6.Location = New System.Drawing.Point(227, 297)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(77, 50)
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "enemy"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Red
        Me.PictureBox7.Location = New System.Drawing.Point(602, -41)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(21, 108)
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "enemy"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(673, 356)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'coin3
        '
        Me.coin3.BackColor = System.Drawing.Color.Gold
        Me.coin3.Location = New System.Drawing.Point(754, 321)
        Me.coin3.Name = "coin3"
        Me.coin3.Size = New System.Drawing.Size(15, 17)
        Me.coin3.TabIndex = 20
        Me.coin3.TabStop = False
        Me.coin3.Tag = "win"
        '
        'coin2
        '
        Me.coin2.BackColor = System.Drawing.Color.Gold
        Me.coin2.Location = New System.Drawing.Point(286, 61)
        Me.coin2.Name = "coin2"
        Me.coin2.Size = New System.Drawing.Size(15, 17)
        Me.coin2.TabIndex = 21
        Me.coin2.TabStop = False
        Me.coin2.Tag = "win"
        '
        'coin1
        '
        Me.coin1.BackColor = System.Drawing.Color.Gold
        Me.coin1.Location = New System.Drawing.Point(214, 236)
        Me.coin1.Name = "coin1"
        Me.coin1.Size = New System.Drawing.Size(15, 17)
        Me.coin1.TabIndex = 22
        Me.coin1.TabStop = False
        Me.coin1.Tag = "win"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox11.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox11.TabIndex = 23
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox12.Location = New System.Drawing.Point(58, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox12.TabIndex = 26
        Me.PictureBox12.TabStop = False
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 1000
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(269, 416)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 29)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(143, 416)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown3.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 29)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 29)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "0"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(18, 416)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown4.TabIndex = 34
        '
        'jump
        '
        Me.jump.Interval = 1000
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Mover4.interval = 25
        Me.Mover4.Location = New System.Drawing.Point(587, -126)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(10, 107)
        Me.Mover4.speed = 5
        Me.Mover4.sprite = Me.PictureBox7
        Me.Mover4.TabIndex = 17
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Mover3.interval = 25
        Me.Mover3.Location = New System.Drawing.Point(17, 297)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(711, 12)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox6
        Me.Mover3.TabIndex = 14
        '
        'Mover1
        '
        Me.Mover1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Mover1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Mover1.interval = 40
        Me.Mover1.Location = New System.Drawing.Point(161, 234)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(111, 38)
        Me.Mover1.speed = 5
        Me.Mover1.sprite = Me.PictureBox3
        Me.Mover1.TabIndex = 9
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Mover2.interval = 40
        Me.Mover2.Location = New System.Drawing.Point(337, 162)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(432, 10)
        Me.Mover2.speed = 5
        Me.Mover2.sprite = Me.PictureBox2
        Me.Mover2.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.platformer_game.My.Resources.Resources.Background_for_vb2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.coin1)
        Me.Controls.Add(Me.coin2)
        Me.Controls.Add(Me.coin3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Winpicturebox)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PicAir)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents TmrRight As Timer
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrUp As Timer
    Friend WithEvents TmrGameLogic As Timer
    Friend WithEvents TmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Winpicturebox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Mover1 As Mover
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Mover3 As Mover
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Mover4 As Mover
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents coin3 As PictureBox
    Friend WithEvents coin2 As PictureBox
    Friend WithEvents coin1 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Time As Timer
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents jump As Timer
End Class
