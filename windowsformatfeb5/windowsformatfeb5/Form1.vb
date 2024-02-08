Public Class Form1
    Dim c As New clicker
    Dim c2 As New clicker
    Dim c3 As New clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = NumericUpDown1.Value
        c.click()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c2.increment = NumericUpDown2.Value
        c2.click()
        TextBox3.Text = c2.count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c2.reset()
        TextBox3.Text = c2.count
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c3.increment = NumericUpDown3.Value
        c3.click()
        TextBox4.Text = c3.count
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c3.reset()
        TextBox4.Text = c3.count
    End Sub
End Class
