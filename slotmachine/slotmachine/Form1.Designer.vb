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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReelControl13 = New slotmachine.ReelControl1()
        Me.ReelControl12 = New slotmachine.ReelControl1()
        Me.ReelControl11 = New slotmachine.ReelControl1()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 2050
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(713, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.slotmachine.My.Resources.Resources.Nickel
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(613, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 95)
        Me.Button4.TabIndex = 12
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 415)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Label4"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.slotmachine.My.Resources.Resources.dime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(613, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 95)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.slotmachine.My.Resources.Resources.quarter
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(613, 113)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(175, 95)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.slotmachine.My.Resources.Resources.download__10_
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(613, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 95)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.slotmachine.My.Resources.Resources.slot_machine_lever
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(481, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 150)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReelControl13
        '
        Me.ReelControl13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ReelControl13.ItemValue = 0
        Me.ReelControl13.Location = New System.Drawing.Point(169, 93)
        Me.ReelControl13.Name = "ReelControl13"
        Me.ReelControl13.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl13.SpinTime = 2000
        Me.ReelControl13.TabIndex = 5
        '
        'ReelControl12
        '
        Me.ReelControl12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ReelControl12.ItemValue = 0
        Me.ReelControl12.Location = New System.Drawing.Point(325, 93)
        Me.ReelControl12.Name = "ReelControl12"
        Me.ReelControl12.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl12.SpinTime = 2000
        Me.ReelControl12.TabIndex = 4
        '
        'ReelControl11
        '
        Me.ReelControl11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ReelControl11.ItemValue = 0
        Me.ReelControl11.Location = New System.Drawing.Point(12, 93)
        Me.ReelControl11.Name = "ReelControl11"
        Me.ReelControl11.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl11.SpinTime = 2000
        Me.ReelControl11.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReelControl13)
        Me.Controls.Add(Me.ReelControl12)
        Me.Controls.Add(Me.ReelControl11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ReelControl11 As ReelControl1
    Friend WithEvents ReelControl12 As ReelControl1
    Friend WithEvents ReelControl13 As ReelControl1
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label4 As Label
End Class
