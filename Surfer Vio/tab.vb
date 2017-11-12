Public Class tab
    Dim currenthost As String
#Region "Event handlers"
    Private Sub buthistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buthistory.Click
        history.Show()
    End Sub

    Private Sub browser_LoadingFrameComplete(ByVal sender As Object, ByVal e As Awesomium.Core.FrameEventArgs) Handles browser.LoadingFrameComplete
        My.Settings.historyname.Add(browser.Title)
        My.Settings.historyurl.Add(browser.Source.ToString)
    End Sub

    Private Sub butaddbookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butaddbookmark.Click
        addbookmark.Show()
    End Sub
    Private Sub butyoutuber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butyoutuber.Click
        Dim youtube As New YouTuber.Main
        youtube.Show()
    End Sub
    Private Sub butback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butback.Click
        On Error Resume Next
        browser.GoBack()
    End Sub
    Private Sub butforward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butforward.Click
        On Error Resume Next
        browser.GoForward()
    End Sub
    Private Sub butgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butgo.Click
        browser.Source = adress.URL
    End Sub
    Private Sub butstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butstop.Click
        browser.Stop()
    End Sub
    Private Sub butrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butrefresh.Click
        browser.Refresh()
    End Sub
    Private Sub searchtext_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles searchtext.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Select Case (searchprovider.SelectedIndex)
                Case 0
                    browser.Source = New Uri("https://www.google.com/?q=" + searchtext.Text)
                Case 1
                    browser.Source = New Uri("https://www.bing.com/?q=" + searchtext.Text)
                Case 2
                    browser.Source = New Uri("https://in.search.yahoo.com/search?p=" + searchtext.Text)
                Case 3
                    browser.Source = New Uri("https://www.youtube.com/results?search_query=" + searchtext.Text)
                Case 4
                    browser.Source = New Uri("https://en.wikipedia.org/w/index.php?search=" + searchtext.Text)
                Case 5
                    browser.Source = New Uri("https://www.torrentz.com/search?q=" + searchtext.Text)
            End Select
        End If
    End Sub
    Private Sub Awesomium_Windows_Forms_WebControl_LoadingFrame(ByVal sender As System.Object, ByVal e As Awesomium.Core.LoadingFrameEventArgs) Handles browser.LoadingFrame
        webprogress.Visible = True
        With webprogress
            .Minimum = 0
            .Maximum = 50
            .Step = 5
        End With
        For index As Integer = 0 To 50 Step 5
            webprogress.Value = index
            System.Threading.Thread.Sleep(35)
        Next
    End Sub
    Private Sub Awesomium_Windows_Forms_WebControl_DocumentReady(ByVal sender As System.Object, ByVal e As Awesomium.Core.DocumentReadyEventArgs) Handles browser.DocumentReady
        On Error GoTo noicon
        If browser.Source.Host.ToString <> currenthost Then
            Dim iconurl = "http://" + browser.Source.Host.ToString + "/favicon.ico"
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconurl)
            Dim response As System.Net.HttpWebResponse = request.GetResponse
            Dim stream As System.IO.Stream = response.GetResponseStream
            Dim favicon = Image.FromStream(stream)
            frmMain.tabimage.Images.Add(browser.Source.Host.ToString, favicon)
            CType(Me.Parent, TabPage).ImageKey = browser.Source.Host.ToString
            currenthost = browser.Source.Host.ToString
        End If
        adress.Text = browser.Source.ToString
        If browser.Title = "" Then
            Me.Parent.Text = "Blank page"
            frmMain.Text = "Blank page - Surfer Vio"
        Else

            Me.Parent.Text = browser.Title
            frmMain.Text = browser.Title + " - Surfer Vio"
        End If
        adress.URL = browser.Source
        webprogress.Visible = False
        currentpage.Text = browser.Title + " "
        GoTo last
noicon:
        CType(Me.Parent, TabPage).ImageIndex = 1
last:
    End Sub
    Private Sub tab_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        i = 0
        Do Until i = My.Settings.bookmarkname.Count
            bookmarks.Items.Add(My.Settings.bookmarkname(i))
            i += 1
        Loop
    End Sub
    Private Sub bookmarks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookmarks.SelectedIndexChanged
        adress.URL = New Uri(My.Settings.bookmarkurl(bookmarks.SelectedIndex))
    End Sub
    Private Sub bookmarkmanager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookmarkmanager.Click
        managebookmarks.Show()
    End Sub
    Private Sub searchtext_Click(sender As Object, e As EventArgs) Handles searchtext.Click
        If searchtext.Text = "Search here..." Then
            searchtext.Text = ""
        End If
    End Sub

    Private Sub searchtext_LostFocus(sender As Object, e As EventArgs) Handles searchtext.LostFocus
        If searchtext.Text = "" Then
            searchtext.Text = "Search here..."
        End If
    End Sub
#End Region

End Class