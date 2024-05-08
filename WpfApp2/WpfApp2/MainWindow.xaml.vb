Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim D As Integer
        Dim M As Integer
        D = Calander1.SelectedDate.Value.Day
        M = Calander1.SelectedDate.Value.Month

        If M = 3 And D > 20 Or M = 4 And D < 20 Then
            monthlabel.Content = "aries"
            Aries.Opacity = 100%
        Else
            Aries.Opacity = 0%
        End If

        If M = 4 And D > 19 Or M = 5 And D < 21 Then
            monthlabel.Content = "Taurus"
            taurus.Opacity = 100%
        Else
            taurus.Opacity = 0%
        End If

        If M = 5 And D > 20 Or M = 6 And D < 21 Then
            monthlabel.Content = "gemini"
            gemini.Opacity = 100%
        Else
            gemini.Opacity = 0%
        End If

        If M = 6 And D > 20 Or M = 7 And D < 23 Then
            monthlabel.Content = "cancer"
            cancer.Opacity = 100%
        Else
            cancer.Opacity = 0%
        End If

        If M = 7 And D > 22 Or M = 8 And D < 23 Then
            monthlabel.Content = "Leo"
            leo.Opacity = 100%
        Else
            leo.Opacity = 0%
        End If

        If M = 8 And D > 22 Or M = 9 And D < 23 Then
            monthlabel.Content = "virgo"
            virgo1.Opacity = 100%
        Else
            virgo1.Opacity = 0%
        End If

        If M = 9 And D > 22 Or M = 10 And D < 22 Then
            monthlabel.Content = "libra"
            libra.Opacity = 100%
        Else
            libra.Opacity = 0%
        End If
        If M = 10 And D > 22 Or M = 11 And D < 22 Then
            monthlabel.Content = "scorpio"
            scorpio.Opacity = 100%
        Else
            scorpio.Opacity = 0%
        End If
        If M = 11 And D > 21 Or M = 12 And D < 22 Then
            monthlabel.Content = "sagittarius"
            Sagittarius.Opacity = 100%
        Else
            Sagittarius.Opacity = 0%
        End If
        If M = 12 And D > 21 Or M = 1 And D < 20 Then
            monthlabel.Content = "capricorn"
            capricorn.Opacity = 100%
        Else
            capricorn.Opacity = 0%
        End If
        If M = 1 And D > 19 Or M = 2 And D < 29 Then
            monthlabel.Content = "aquarius"
            aquarius.Opacity = 100%
        Else
            aquarius.Opacity = 0%
        End If
        If M = 2 And D > 18 Or M = 3 And D < 21 Then
            monthlabel.Content = "pisces"
            pisces.Opacity = 100%
        Else
            pisces.Opacity = 0%
        End If
    End Sub
End Class
