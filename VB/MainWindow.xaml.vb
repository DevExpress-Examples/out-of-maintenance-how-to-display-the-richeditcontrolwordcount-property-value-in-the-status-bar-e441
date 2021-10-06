Imports System
Imports System.Windows

Namespace RichEditWordCountStatusBarWpf

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateStatusBar()
        End Sub

        Private Sub richEditControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateStatusBar()
        End Sub

        Private Sub UpdateStatusBar()
            siWords.Content = richEditControl1.WordCount
        End Sub
    End Class
End Namespace
