Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Threading

Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cs.total >= 1 Then
            ReelControl11.spin()
            ReelControl12.spin()
            ReelControl13.spin()
            cs.spin()
            Label4.Text = cs.total.ToString("C2")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertquarter()
        Label4.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdimes()
        Label4.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickels()
        Label4.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cs.insertdollars()
        Label4.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cs.coinreturn()
        Label4.Text = cs.total.ToString("c2")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl11.ItemValue
        Label2.Text = ReelControl12.ItemValue
        Label3.Text = ReelControl13.ItemValue
        Timer1.Enabled = False
        If ReelControl11.ItemValue = ReelControl12.ItemValue And ReelControl12.ItemValue = ReelControl13.ItemValue Then
            Me.BackColor = Color.LawnGreen
            cs.Bigwin()
            Label4.Text = cs.total.ToString("C2")
        Else
            Me.BackColor = Color.White
        End If
        If ReelControl11.ItemValue = 1 And ReelControl12.ItemValue = 1 And ReelControl13.ItemValue = 1 Then
            cs.Biggestwin()
            Label4.Text = cs.total.ToString("c2")
        End If
        If ReelControl11.ItemValue = ReelControl13.ItemValue And ReelControl13.ItemValue <> ReelControl12.ItemValue Then
            cs.smallwin()
            Label4.Text = cs.total.ToString("C2")
            Me.BackColor = Color.Yellow
        Else
        End If
    End Sub
End Class
