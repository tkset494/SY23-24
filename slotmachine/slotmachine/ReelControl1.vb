Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class ReelControl1
    Public Property ItemValue As Integer
    Public Property SpinTime As Integer = 2000
    Dim rand As New Random
    Private Sub ReelControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = SpinTime

    End Sub
    Public Sub spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        ItemValue = r
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
End Class
