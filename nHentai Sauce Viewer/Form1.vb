Imports System.IO

Public Class Form1
    Dim sauceLink As String
    Public random As New Random()

    Private Sub sauce_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sauce_id.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub viewSauce_Click(sender As Object, e As EventArgs) Handles viewSauce.Click
        sauceLink = "https://nhentai.net/g/" + sauce_id.Text
        If browsers.SelectedItem = "" Then
            MsgBox("Please select a browser to continue!", vbOKOnly + vbCritical, "Error")
        Else
            launch()
        End If
    End Sub

    Private Sub roulette_Click(sender As Object, e As EventArgs) Handles roulette.Click
        sauce_id.Text = Convert.ToString(random.Next(1, 199999))
        sauceLink = "https://nhentai.net/g/" + sauce_id.Text
        If browsers.SelectedItem = "" Then
            MsgBox("Please select a browser to continue!", vbOKOnly + vbCritical, "Error")
        Else
            launch()
        End If
    End Sub

    Private Sub load_browsers() Handles Me.Load
        load_config()
    End Sub

    Sub launch()
        If browsers.SelectedItem = "Chrome" Then
            Try
                If incogEnable.Checked = True Then
                    Process.Start("chrome.exe", "-incognito " + sauceLink)
                Else
                    Process.Start("chrome.exe", sauceLink)
                End If
            Catch
                MsgBox("The selected browser does not appear to be installed!" + vbNewLine + "Please select another one.", vbCritical + vbOKOnly, "nHentai Sauce Viewer")
            End Try
        End If
        If browsers.SelectedItem = "Firefox" Then
            Try
                If incogEnable.Checked = True Then
                    Process.Start("firefox.exe", "-private-window " + sauceLink)
                Else
                    Process.Start("firefox.exe", sauceLink)
                End If
            Catch
                MsgBox("The selected browser does not appear to be installed!" + vbNewLine + "Please select another one.", vbCritical + vbOKOnly, "nHentai Sauce Viewer")
            End Try
        End If
        If browsers.SelectedItem = "Opera" Then
            Try
                If incogEnable.Checked = True Then
                    Process.Start("opera.exe", "-private " + sauceLink)
                Else
                    Process.Start("opera.exe", sauceLink)
                End If
            Catch
                MsgBox("The selected browser does not appear to be installed!" + vbNewLine + "Please select another one.", vbCritical + vbOKOnly, "nHentai Sauce Viewer")
            End Try
        End If
        If browsers.SelectedItem = "Vivaldi" Then
            Try
                If incogEnable.Checked = True Then
                    Process.Start("vivaldi.exe", "-incognito " + sauceLink)
                Else
                    Process.Start("vivaldi.exe", sauceLink)
                End If
            Catch
                MsgBox("The selected browser does not appear to be installed!" + vbNewLine + "Please select another one.", vbCritical + vbOKOnly, "nHentai Sauce Viewer")
            End Try
        End If
        If browsers.SelectedItem = "Internet Explorer" Then
            Try
                If incogEnable.Checked = True Then
                    Process.Start("iexplore.exe", "-private " + sauceLink)
                Else
                    Process.Start("iexplore.exe", sauceLink)
                End If
            Catch
                MsgBox("The selected browser does not appear to be installed!" + vbNewLine + "Please select another one.", vbCritical + vbOKOnly, "nHentai Sauce Viewer")
            End Try
        End If
    End Sub

    Sub load_config()
        If System.IO.File.Exists("bookmarks.conf") = False Then
            Return
        End If
        Dim fileReader As StreamReader = My.Computer.FileSystem.OpenTextFileReader("bookmarks.conf")
        Dim stringReader
        bookmarks.Items.Clear()
        Do
            stringReader = fileReader.ReadLine
            If stringReader <> "" Then
                bookmarks.Items.Add(stringReader)
            End If
        Loop Until stringReader = ""

        fileReader.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        System.IO.File.AppendAllText("bookmarks.conf", sauce_id.Text & vbNewLine)
        load_config()
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles open.Click
        sauce_id.Text = bookmarks.SelectedItem
        sauceLink = "https://nhentai.net/g/" + sauce_id.Text
        If browsers.SelectedItem = "" Then
            MsgBox("Please select a browser to continue!", vbOKOnly + vbCritical, "Error")
        Else
            launch()
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim delItem As String = bookmarks.SelectedIndex
        If System.IO.File.Exists("bookmarks.conf") = False Then
            Return
        End If
        Dim lines As List(Of String) = System.IO.File.ReadAllLines("bookmarks.conf").ToList
        lines.RemoveAt(delItem)
        System.IO.File.WriteAllLines("bookmarks.conf", lines.ToArray)
        load_config()
        delete.Enabled = False
        open.Enabled = False
    End Sub

    Private Sub Bookmarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bookmarks.SelectedIndexChanged
        If bookmarks.SelectedItem <> "" Then
            delete.Enabled = True
            open.Enabled = True
        End If
    End Sub

    Private Sub Sauce_id_TextChanged(sender As Object, e As EventArgs) Handles sauce_id.TextChanged
        If sauce_id.Text = "" Then
            save.Enabled = False
            viewSauce.Enabled = False
        Else
            save.Enabled = True
            viewSauce.Enabled = True
        End If
    End Sub
End Class
