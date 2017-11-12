Public Class managebookmarks

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        addbookmark.Show()
    End Sub
    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        On Error GoTo last
        My.Settings.bookmarkname.RemoveAt(RadListControl1.SelectedIndex)
        My.Settings.bookmarkurl.RemoveAt(RadListControl1.SelectedIndex)
        RadListControl1.Items.Clear()
        Dim i As Integer = 0
        Do Until RadListControl1.Items.Count = My.Settings.bookmarkname.Count
            RadListControl1.Items.Add(My.Settings.bookmarkname(i))
            i += 1
        Loop
last:
    End Sub

    Private Sub managebookmarks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer = 0
        Do Until RadListControl1.Items.Count = My.Settings.bookmarkname.Count
            RadListControl1.Items.Add(My.Settings.bookmarkname(i))
            i += 1
        Loop
    End Sub

    Private Sub RadButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton5.Click
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Dim editbookmarks As New modifybookmarks
        editbookmarks.RadTextBoxControl1.Text = My.Settings.bookmarkname(RadListControl1.SelectedIndex)
        editbookmarks.RadTextBoxControl2.Text = My.Settings.bookmarkurl(RadListControl1.SelectedIndex)
        editbookmarks.Show()
    End Sub

    Private Sub RadListControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadListControl1.DoubleClick
        frmMain.addtab()
        CType(frmMain.tabs.SelectedTab.Controls(0).Controls(0), Awesomium.Windows.Forms.WebControl).Source = New Uri(My.Settings.bookmarkurl(RadListControl1.SelectedIndex))
    End Sub
End Class