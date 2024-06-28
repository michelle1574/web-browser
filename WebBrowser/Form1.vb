Imports System
Imports Microsoft.Web.WebView2.Core

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the Web control to fill the form
        Web.Height = Me.Height - 60
        ' Disable forward and back buttons initially
        ForwardButton.Enabled = False
        BackButton.Enabled = False
        SearchButton.Enabled = False

        ' Add the handler for the Web's NavigationCompleted event
        AddHandler Web.NavigationCompleted, AddressOf Web_NavigationCompleted

        ' Add a handler to monitor changes in TextBox1
        AddHandler TextBox1.TextChanged, AddressOf TextBox1_TextChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        ' Enable the SearchButton if TextBox1 is not empty, otherwise disable it
        SearchButton.Enabled = Not String.IsNullOrWhiteSpace(TextBox1.Text)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim input As String = TextBox1.Text
        Dim uri As Uri

        If Uri.TryCreate(input, UriKind.Absolute, uri) AndAlso (uri.Scheme = Uri.UriSchemeHttp Or uri.Scheme = Uri.UriSchemeHttps) Then
            ' Input is a valid URL
            Web.Source = uri
        Else
            ' Input is not a valid URL, treat it as a search query
            Dim searchQuery As String = "https://www.duckduckgo.com/?q=" & Uri.EscapeDataString(input)
            Web.Source = New Uri(searchQuery)
        End If
    End Sub

    Private Sub Web_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles Web.NavigationCompleted
        TextBox1.Text = Web.Source.ToString()
        ForwardButton.Enabled = Web.CanGoForward
        BackButton.Enabled = Web.CanGoBack
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Web.Reload()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Web.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        Web.GoForward()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Web.Height = Me.Height - 60
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsOptions.ShowDialog()
    End Sub
End Class
