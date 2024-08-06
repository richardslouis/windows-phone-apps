' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub WebView_LoadCompleted(sender As Object, e As NavigationEventArgs)

        ProgressRing1.IsActive = False

    End Sub

    Private Sub TextBlock_SelectionChanged(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub TextBlock_SelectionChanged_1(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub backButton_Click(sender As Object, e As RoutedEventArgs)
        Try

            webview1.GoBack()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub WebView_contentLoading(sender As WebView, args As WebViewContentLoadingEventArgs) Handles webview1.ContentLoading
        ProgressRing1.IsActive = True
    End Sub

    Private Sub TextBlock_SelectionChanged_2(sender As Object, e As RoutedEventArgs)

    End Sub




End Class
