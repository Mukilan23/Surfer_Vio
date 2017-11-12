Public Class modifybookmarks
    Dim index As Integer
    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub
    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        My.Settings.bookmarkname(managebookmarks.RadListControl1.SelectedIndex) = RadTextBoxControl1.Text
        My.Settings.bookmarkurl(managebookmarks.RadListControl1.SelectedIndex) = RadTextBoxControl2.Text
        MsgBox("Changes updated successfully.", vbInformation, "Surfer Vio - Changes updated")
        Me.Close()
    End Sub
End Class