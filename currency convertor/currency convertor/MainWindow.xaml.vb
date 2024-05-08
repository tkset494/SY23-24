Class MainWindow
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textbox1.TextChanged
        Dim convert As Boolean = (textbox1.Text Like "#" OrElse textbox1.Text Like "##" OrElse textbox1.Text Like "###" OrElse textbox1.Text Like "####" OrElse textbox1.Text Like "#####" OrElse textbox1.Text Like "######" OrElse textbox1.Text Like "#######" OrElse textbox1.Text Like "########" OrElse textbox1.Text Like "#########" OrElse textbox1.Text Like "##########")



        If convert = True Then
            EUR.IsEnabled = True
        Else
            EUR.IsEnabled = False
        End If
        If convert = True Then
            AUD.IsEnabled = True
        Else
            AUD.IsEnabled = False
        End If
        If convert = True Then
            JPY.IsEnabled = True
        Else
            JPY.IsEnabled = False
        End If
        If convert = True Then
            CAD.IsEnabled = True
        Else
            CAD.IsEnabled = False
        End If
        If convert = True Then
            GBP.IsEnabled = True
        Else
            GBP.IsEnabled = False
        End If
        If convert = True Then
            CHF.IsEnabled = True
        Else
            CHF.IsEnabled = False
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles EUR.Click
        Final.Content = textbox1.Text * 0.93
        multiply.Content = "0.93"

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs) Handles AUD.Click
        Final.Content = textbox1.Text * 1.54
        multiply.Content = "1.54"
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs) Handles JPY.Click
        Final.Content = textbox1.Text * 154.79
        multiply.Content = "154.79"
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs) Handles CAD.Click
        Final.Content = textbox1.Text * 1.37
        multiply.Content = "1.37"

    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs) Handles GBP.Click
        Final.Content = textbox1.Text * 0.8
        multiply.Content = "0.8"
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs) Handles CHF.Click
        Final.Content = textbox1.Text * 0.91
        multiply.Content = "0.91"

    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        textbox1.Text = ""
        Final.Content = "0"
        multiply.Content = "N/A"
    End Sub
End Class
