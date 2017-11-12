Public Class frmMain
    Dim firststart As Boolean = True
#Region "Event handlers"
    Private Sub MyComputerNetwork_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Devices.NetworkAvailableEventArgs)
        If My.Computer.Network.IsAvailable = True Then
            desktop.ContentText = "Network is now connected. You may continue browsing."
            desktop.CaptionText = "Alert - Surfer Vio Express"
            desktop.ContentImage = My.Resources.connected
            desktop.FixedSize = New Size(300, 200)
            desktop.Show()
        Else
            desktop.ContentText = "Network is not connected. Please ensure you are connected to the internet."
            desktop.CaptionText = "Alert - Surfer Vio Express"
            desktop.ContentImage = My.Resources.Warning
            desktop.FixedSize = New Size(300, 200)
            desktop.Show()
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        defpage.Dispose()
        addtab()
        AddHandler My.Computer.Network.NetworkAvailabilityChanged, AddressOf MyComputerNetwork_NetworkAvailabilityChanged
        If My.Computer.Network.IsAvailable = True Then
            desktop.ContentText = "Network is now connected. You may continue browsing."
            desktop.CaptionText = "Alert - Surfer Vio Express"
            desktop.ContentImage = My.Resources.connected
            desktop.FixedSize = New Size(300, 200)
            desktop.Show()
        Else
            desktop.ContentText = "Network is not connected. Please ensure you are connected to the internet."
            desktop.CaptionText = "Alert - Surfer Vio Express"
            desktop.ContentImage = My.Resources.warning
            desktop.FixedSize = New Size(300, 200)
            desktop.Show()
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub tabs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabs.SelectedIndexChanged
        If firststart = True Then
            firststart = False
        Else
            If tabs.SelectedIndex = tabs.TabPages.Count - 1 Then
                addtab()
            Else
                Me.Text = tabs.SelectedTab.Text + " - Surfer Vio"
            End If
        End If
    End Sub
    Private Sub tabs_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabs.MouseDoubleClick
        tabs.TabPages.RemoveAt(tabs.SelectedIndex)
    End Sub
#End Region
#Region "Functions"
    Public Function addtab()
        Dim newtab As New tab
        Dim newtabpage As New TabPage
        newtab.TopLevel = False
        newtabpage.Controls.Add(newtab)
        newtab.Dock = DockStyle.Fill
        tabs.TabPages.Insert(tabs.TabPages.Count - 1, newtabpage)
        newtab.Show()
        newtabpage.Text = "Blank Tab"
        tabs.SelectTab(newtabpage)
        Return 0
    End Function
#End Region
End Class
