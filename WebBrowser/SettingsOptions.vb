Public Class SettingsOptions
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' URL of the GitHub page
        Dim url As String = "https://github.com/michelle1574/web-browser"

        ' Open the URL in the default web browser
        Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If CheckBox1.Checked = True Then
            Form1.BackButton.ForeColor = Color.White
            Form1.BackButton.BackColor = Color.Black
            Form1.ForwardButton.ForeColor = Color.White
            Form1.ForwardButton.BackColor = Color.Black
            Form1.RefreshButton.ForeColor = Color.White
            Form1.RefreshButton.BackColor = Color.Black
            Form1.SearchButton.ForeColor = Color.White
            Form1.SearchButton.BackColor = Color.Black
            Form1.TextBox1.ForeColor = Color.White
            Form1.TextBox1.BackColor = Color.Black
            Form1.TableLayoutPanel1.ForeColor = Color.White
            Form1.TableLayoutPanel1.BackColor = Color.Black
            Form1.Web.ForeColor = Color.White
            Form1.Web.BackColor = Color.Black
            Form1.SettingsButton.ForeColor = Color.White
            Form1.SettingsButton.BackColor = Color.Black
        Else
            Form1.BackButton.ForeColor = Color.Black
            Form1.BackButton.BackColor = Color.White
            Form1.ForwardButton.ForeColor = Color.Black
            Form1.ForwardButton.BackColor = Color.White
            Form1.RefreshButton.ForeColor = Color.Black
            Form1.RefreshButton.BackColor = Color.White
            Form1.SearchButton.ForeColor = Color.Black
            Form1.SearchButton.BackColor = Color.White
            Form1.TextBox1.ForeColor = Color.Black
            Form1.TextBox1.BackColor = Color.White
            Form1.TableLayoutPanel1.ForeColor = Color.Black
            Form1.TableLayoutPanel1.BackColor = Color.White
            Form1.Web.ForeColor = Color.Black
            Form1.Web.BackColor = Color.White
            Form1.SettingsButton.ForeColor = Color.Black
            Form1.SettingsButton.BackColor = Color.White
        End If
        Me.Hide()
        Me.Close()
    End Sub
End Class