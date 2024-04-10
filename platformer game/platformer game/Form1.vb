Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form2Dplatfomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Left
                TmrLeft.Start()
            Case Keys.Up
                TmrUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        Picplayer.Left += movespeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Left
                TmrLeft.Stop()
            Case Keys.Up
                TmrUp.Stop()
                jump.Enabled = True
                isjumping = False


                    End Select
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        Picplayer.Left -= movespeed
    End Sub

    Private Sub TmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        Picplayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrGameLogic.Start()
        TextBox1.Select()
    End Sub

    Private Sub TmrGameLogic_Tick(sender As Object, e As EventArgs) Handles TmrGameLogic.Tick
        If Picplayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            TmrGravity.Stop()
        ElseIf Picplayer.Bounds.IntersectsWith(PicAir.Bounds) Then
            If isjumping = False Then
                TmrGravity.Start()
            End If
        End If


        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
                If b.Tag = "win" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        If Winpicturebox.Visible = True And Picplayer.Bounds.IntersectsWith(Winpicturebox.Bounds) Then
                            NumericUpDown1.Value = NumericUpDown1.Value + 1
                            Winpicturebox.Visible = False
                        End If
                        If coin1.Visible = True And Picplayer.Bounds.IntersectsWith(coin1.Bounds) Then
                            NumericUpDown1.Value = NumericUpDown1.Value + 1
                            coin1.Visible = False
                        End If
                        If coin2.Visible = True And Picplayer.Bounds.IntersectsWith(coin2.Bounds) Then
                            NumericUpDown1.Value = NumericUpDown1.Value + 1
                            coin2.Visible = False
                        End If
                        If coin3.Visible = True And Picplayer.Bounds.IntersectsWith(coin3.Bounds) Then
                            NumericUpDown1.Value = NumericUpDown1.Value + 1
                            coin3.Visible = False
                        End If
                        Label1.Text = NumericUpDown1.Value
                    End If
                End If
                If b.Tag = "enemy" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        Picplayer.Visible = False
                        NumericUpDown1.Value = 0
                        Label1.Text = NumericUpDown1.Value
                        If Picplayer.Visible = False Then
                            coin1.Visible = True
                            coin2.Visible = True
                            coin3.Visible = True
                            Winpicturebox.Visible = True
                        End If
                    End If
                    End If
            End If
        Next
    End Sub

    Private Sub TmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGravity.Tick
        Picplayer.Top += movespeed
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        NumericUpDown2.Value = NumericUpDown2.Value + 1
        Label4.Text = NumericUpDown2.Value
        If NumericUpDown2.Value = 10 Then
            NumericUpDown2.Value = 0
            NumericUpDown3.Value = NumericUpDown3.Value + 1
            If NumericUpDown3.Value = 6 Then
                NumericUpDown2.Value = 0
                NumericUpDown3.Value = 0
                NumericUpDown4.Value = NumericUpDown4.Value + 1
            End If
        End If
        Label4.Text = NumericUpDown2.Value
        Label6.Text = NumericUpDown3.Value
        Label2.Text = NumericUpDown4.Value
        If Picplayer.Visible = False Or NumericUpDown1.Value = 4 Then
            Time.Enabled = False
        End If
    End Sub
End Class
