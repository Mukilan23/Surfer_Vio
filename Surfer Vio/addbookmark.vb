Public Class addbookmark
    Private Sub addbookmark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtname.Text = CType(frmMain.tabs.SelectedTab.Controls(0).Controls(0), Awesomium.Windows.Forms.WebControl).Title
        txturl.Text = CType(frmMain.tabs.SelectedTab.Controls(0).Controls(0), Awesomium.Windows.Forms.WebControl).Source.ToString
        RadButton1.Focus()
    End Sub
    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        My.Settings.bookmarkname.Add(txtname.Text)
        My.Settings.bookmarkurl.Add(txturl.Text)
        Dim i As Integer = 0
        Do Until i = frmMain.tabs.TabCount - 1
            CType(frmMain.tabs.TabPages(i).Controls(0), tab).bookmarks.Items.Clear()
            i += 1
        Loop
        Dim j As Integer
        i = 0
        Do Until i = frmMain.tabs.TabCount - 1
            j = 0
            Do Until j = My.Settings.bookmarkname.Count
                CType(frmMain.tabs.TabPages(i).Controls(0), tab).bookmarks.Items.Add(My.Settings.bookmarkname(j))
                j += 1
            Loop
            i += 1
        Loop
        i = 0
        managebookmarks.RadListControl1.Items.Clear()
        Do Until i = My.Settings.bookmarkname.Count
            managebookmarks.RadListControl1.Items.Add(My.Settings.bookmarkname(i))
        Loop
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub
End Class