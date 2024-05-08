Imports System.Net.Security
Imports System.Windows.Media.Animation

Class MainWindow
    Dim check As Boolean
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        label1.Content = "hello"
        Dim r As New RotateTransform
        r.Angle = 90

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Textbox1.Text = ""
        Textbox2.Text = ""
        textbox3.Text = ""
        Textbox4.Text = ""
        Textbox5.Text = ""
        Textbox6.Text = ""
        Textbox7.Text = ""
    End Sub

    Private Sub Textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles Textbox1.TextChanged, Textbox2.TextChanged, textbox3.TextChanged, Textbox4.TextChanged, Textbox5.TextChanged, Textbox6.TextChanged, Textbox7.TextChanged
        Dim credit As Boolean = (Textbox1.Text Like "################") OrElse (Textbox1.Text Like "#### #### #### ####")
        Dim month As Boolean = (Textbox2.Text Like "##")
        Dim year As Boolean = (textbox3.Text Like "##")
        Dim name As Boolean = (Textbox4.Text Like "*")
        Dim street As Boolean = (Textbox5.Text Like "*")
        Dim zip As Boolean = (Textbox6.Text Like "#####")
        Dim ccv As Boolean = (Textbox7.Text Like "###")
        If credit = True And month = True And year = True And name = True And street = True And zip = True And ccv = True Then
            Button4.IsEnabled = True
        End If



    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles Textbox1.TextChanged

    End Sub

End Class