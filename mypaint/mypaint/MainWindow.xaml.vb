Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.form

Class MainWindow
    Dim c1 As Color
    Dim c2 As Color


    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingCanvas.MouseMove
        If shapelabel.Content = "ELIPSE" Then
            Dim el As New Ellipse
            el.Width = widthSlider.Value
            el.Height = heightSlider.Value
            el.Fill = color1Rectangle.Fill

            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.MouseDevice.LeftButton = MouseButtonState.Pressed Then
                mainCanvas.Children.Add(el)
                Dim r As New Polygon
                r.Fill = color1Rectangle.Fill
                r.Points.Add(p + New Point(-6 * widthSlider.Value, 9 * widthSlider.Value))
                r.Points.Add(p + New Point(5 * widthSlider.Value, 10 * widthSlider.Value))
                r.Points.Add(p + New Point(2 * widthSlider.Value, 3 * widthSlider.Value))
                r.Points.Add(p + New Point(3 * widthSlider.Value, -3 * widthSlider.Value))
                r.Points.Add(p + New Point(4 * widthSlider.Value, -8 * widthSlider.Value))
                r.Points.Add(p + New Point(-2 * widthSlider.Value, -8 * widthSlider.Value))
                r.Points.Add(p + New Point(-7 * widthSlider.Value, -6 * widthSlider.Value))
                r.Points.Add(p + New Point(-8 * widthSlider.Value, 3 * widthSlider.Value))
                mainCanvas.Children.Add(r)
            End If
        End If
        If shapelabel.Content = "RECTANGLE" Then
            Dim re As New Ellipse
            re.Width = widthSlider.Value
            re.Height = heightSlider.Value
            re.Fill = color1Rectangle.Fill

            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(re, p.X)
            Canvas.SetTop(re, p.Y)
            If e.MouseDevice.LeftButton = MouseButtonState.Pressed Then
                mainCanvas.Children.Add(re)
                Dim r As New Polygon
                r.Fill = color1Rectangle.Fill
                r.Points.Add(p + New Point(5 * widthSlider.Value, 5 * widthSlider.Value))
                r.Points.Add(p + New Point(5 * widthSlider.Value, -5 * widthSlider.Value))
                r.Points.Add(p + New Point(-5 * widthSlider.Value, -5 * widthSlider.Value))
                r.Points.Add(p + New Point(-5 * widthSlider.Value, 5 * widthSlider.Value))
                mainCanvas.Children.Add(r)
            End If
        End If
        If shapelabel.Content = "Triangle" Then
            Dim tr As New Ellipse
            tr.Width = widthSlider.Value
            tr.Height = heightSlider.Value
            tr.Fill = color1Rectangle.Fill

            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(tr, p.X)
            Canvas.SetTop(tr, p.Y)
            If e.MouseDevice.LeftButton = MouseButtonState.Pressed Then
                mainCanvas.Children.Add(tr)
                Dim r As New Polygon
                r.Fill = color1Rectangle.Fill
                r.Points.Add(p + New Point(0 * widthSlider.Value, -5 * widthSlider.Value))
                r.Points.Add(p + New Point(-5 * widthSlider.Value, 5 * widthSlider.Value))
                r.Points.Add(p + New Point(5 * widthSlider.Value, 5 * widthSlider.Value))
                mainCanvas.Children.Add(r)
            End If
        End If
        If shapelabel.Content = "picture" Then

            Dim myImageBrush As New ImageBrush(Kevin.Source)
            Dim myCanvas As New Canvas
            myCanvas.Width = 100
            myCanvas.Height = 100
            myCanvas.Background = myImageBrush
            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(myCanvas, p.X)
            Canvas.SetTop(myCanvas, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                mainCanvas.Children.Add(myCanvas)
            End If

        End If
        If shapelabel.Content = "picture2" Then

            Dim myImageBrush As New ImageBrush(BAKACTIT.Source)
            Dim myCanvas As New Canvas
            myCanvas.Width = 100
            myCanvas.Height = 100
            myCanvas.Background = myImageBrush
            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(myCanvas, p.X)
            Canvas.SetTop(myCanvas, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                mainCanvas.Children.Add(myCanvas)
            End If

        End If
        If shapelabel.Content = "picture3" Then

            Dim myImageBrush As New ImageBrush(Kevin2.Source)
            Dim myCanvas As New Canvas
            myCanvas.Width = 100
            myCanvas.Height = 100
            myCanvas.Background = myImageBrush
            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(myCanvas, p.X)
            Canvas.SetTop(myCanvas, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                mainCanvas.Children.Add(myCanvas)
            End If

        End If
    End Sub

    Private Sub color1Rectangle_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color1Rectangle.MouseDown, color2rectangle.MouseDown, color3rectangle.MouseDown, color4rectangle.MouseDown, color5rectangle.MouseDown, color6rectangle.MouseDown
        color1Rectangle.Fill = sender.fill
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        mainCanvas.Children.RemoveRange(1, mainCanvas.Children.Count - 1)
    End Sub

    Private Sub undobutton_Click(sender As Object, e As RoutedEventArgs) Handles undobutton.Click
        mainCanvas.Children.RemoveAt(mainCanvas.Children.Count - 1)
    End Sub

    Private Sub elipsebutton_Click(sender As Object, e As RoutedEventArgs) Handles elipsebutton.Click
        shapelabel.Content = sender.content
    End Sub

    Private Sub rectanglebutton_Click(sender As Object, e As RoutedEventArgs) Handles rectanglebutton.click
        shapelabel.Content = sender.content
    End Sub

    Private Sub angleslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleslider.ValueChanged
        color1Rectangle.Fill = New LinearGradientBrush(c1, c2, angleslider.Value)
    End Sub

    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using



        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingCanvas, 5)

        Canvas.SetTop(drawingCanvas, 10)

    End Sub


    Private Sub grad1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Grad1.MouseDown
        Grad1.Fill = New SolidColorBrush(Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
        c1 = (Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
    End Sub

    Private Sub grad2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Grad2.MouseDown
        Grad2.Fill = New SolidColorBrush(Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
        c2 = (Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
    End Sub

    Private Sub triangle_Click(sender As Object, e As RoutedEventArgs) Handles triangle.Click
        shapelabel.Content = sender.content
    End Sub

    Private Sub btn5_Click(sender As Object, e As RoutedEventArgs) Handles btn5.Click
        shapelabel.Content = "picture"
    End Sub

    Private Sub btn7_Click(sender As Object, e As RoutedEventArgs) Handles btn7.Click
        shapelabel.Content = "picture2"
    End Sub

    Private Sub btn6_Click(sender As Object, e As RoutedEventArgs) Handles btn6.Click
        shapelabel.Content = "picture3"
    End Sub
End Class

