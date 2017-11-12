Public Class history
    Private Sub history_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Do Until RadListControl1.Items.Count = My.Settings.historyname.Count
            RadListControl1.Items.Add(My.Settings.historyurl(i))
            i += 1
        Loop
    End Sub
    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        My.Settings.historyname.Clear()
        My.Settings.historyurl.Clear()
        Dim i As Integer = 0
        RadListControl1.Items.Clear()
        MsgBox("History has been cleared.", vbInformation, "Surfer Vio")
    End Sub
    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub
    Private Sub RadListControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadListControl1.DoubleClick
        frmMain.addtab()
        CType(frmMain.tabs.SelectedTab.Controls(0).Controls(0), Awesomium.Windows.Forms.WebControl).Source = New Uri(My.Settings.historyurl(RadListControl1.SelectedIndex))
    End Sub
End Class