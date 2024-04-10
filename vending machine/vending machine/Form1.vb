Imports System.Security.Cryptography

Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdimes()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickels()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollars()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")

    End Sub

    Private Sub cs_coinreturnevent(D As Integer, Q As Integer, DM As Integer, N As Integer) Handles cs.coinreturnevent
        If D > 0 Then
            DollarReturn.Visible = True
        Else
            DollarReturn.Visible = False
        End If
        If Q > 0 Then
            QuarterReturn.Visible = True
        Else
            QuarterReturn.Visible = False
        End If
        If DM > 0 Then
            DimeReturn.Visible = True
        Else
            DimeReturn.Visible = False
        End If
        If N > 0 Then
            NickelReturn.Visible = True
        Else
            NickelReturn.Visible = False
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox1.Text
            Case ProductControl11.ProductID
                ProductControl11.buy()
                cs.buy(ProductControl11)
            Case ProductControl12.ProductID
                ProductControl12.buy()
                cs.buy(ProductControl12)
            Case ProductControl13.ProductID
                ProductControl13.buy()
                cs.buy(ProductControl13)
            Case ProductControl14.ProductID
                ProductControl14.buy()
                cs.buy(ProductControl14)
            Case ProductControl15.ProductID
                ProductControl15.buy()
                cs.buy(ProductControl15)
            Case ProductControl16.ProductID
                ProductControl16.buy()
                cs.buy(ProductControl16)
            Case ProductControl17.ProductID
                ProductControl17.buy()
                cs.buy(ProductControl17)
            Case ProductControl18.ProductID
                ProductControl18.buy()
                cs.buy(ProductControl18)
            Case ProductControl19.ProductID
                ProductControl19.buy()
                cs.buy(ProductControl19)
            Case ProductControl110.ProductID
                ProductControl110.buy()
                cs.buy(ProductControl110)
            Case ProductControl111.ProductID
                ProductControl111.buy()
                cs.buy(ProductControl111)
            Case ProductControl112.ProductID
                ProductControl112.buy()
                cs.buy(ProductControl112)
            Case ProductControl113.ProductID
                ProductControl113.buy()
                cs.buy(ProductControl113)
            Case ProductControl114.ProductID
                ProductControl114.buy()
                cs.buy(ProductControl114)
            Case ProductControl115.ProductID
                ProductControl115.buy()
                cs.buy(ProductControl115)
            Case ProductControl116.ProductID
                ProductControl116.buy()
                cs.buy(ProductControl116)
            Case Else

        End Select
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub cs_dispense(p As Image) Handles cs.dispense
        ProductPictureBox.Image = p
    End Sub
End Class
