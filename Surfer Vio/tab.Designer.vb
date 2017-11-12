<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tab))
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.currentpage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.webprogress = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.connectionstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tools = New System.Windows.Forms.ToolStrip()
        Me.butback = New System.Windows.Forms.ToolStripButton()
        Me.butforward = New System.Windows.Forms.ToolStripButton()
        Me.adress = New Awesomium.Windows.Forms.ToolStripAddressBox()
        Me.browser = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.butgo = New System.Windows.Forms.ToolStripButton()
        Me.butstop = New System.Windows.Forms.ToolStripButton()
        Me.butrefresh = New System.Windows.Forms.ToolStripButton()
        Me.searchprovider = New System.Windows.Forms.ToolStripComboBox()
        Me.searchtext = New System.Windows.Forms.ToolStripTextBox()
        Me.bookmarks = New System.Windows.Forms.ToolStripComboBox()
        Me.butyoutuber = New System.Windows.Forms.ToolStripButton()
        Me.buthistory = New System.Windows.Forms.ToolStripButton()
        Me.bookmarkmanager = New System.Windows.Forms.ToolStripButton()
        Me.butaddbookmark = New System.Windows.Forms.ToolStripButton()
        Me.sessionprovider = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.status.SuspendLayout()
        Me.tools.SuspendLayout()
        Me.SuspendLayout()
        '
        'status
        '
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.currentpage, Me.webprogress, Me.ToolStripStatusLabel3, Me.connectionstatus})
        Me.status.Location = New System.Drawing.Point(0, 497)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(1091, 22)
        Me.status.TabIndex = 0
        Me.status.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(85, 17)
        Me.ToolStripStatusLabel1.Text = "Current Page : "
        '
        'currentpage
        '
        Me.currentpage.Name = "currentpage"
        Me.currentpage.Size = New System.Drawing.Size(68, 17)
        Me.currentpage.Text = "Blank  page"
        '
        'webprogress
        '
        Me.webprogress.Name = "webprogress"
        Me.webprogress.Size = New System.Drawing.Size(100, 16)
        Me.webprogress.Visible = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel3.Text = " Status : "
        '
        'connectionstatus
        '
        Me.connectionstatus.Name = "connectionstatus"
        Me.connectionstatus.Size = New System.Drawing.Size(65, 17)
        Me.connectionstatus.Text = "Connected"
        '
        'tools
        '
        Me.tools.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butback, Me.butforward, Me.adress, Me.butgo, Me.butstop, Me.butrefresh, Me.searchprovider, Me.searchtext, Me.bookmarks, Me.butyoutuber, Me.buthistory, Me.bookmarkmanager, Me.butaddbookmark})
        Me.tools.Location = New System.Drawing.Point(0, 0)
        Me.tools.Name = "tools"
        Me.tools.Size = New System.Drawing.Size(1091, 33)
        Me.tools.TabIndex = 1
        Me.tools.Text = "ToolStrip1"
        '
        'butback
        '
        Me.butback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butback.Image = CType(resources.GetObject("butback.Image"), System.Drawing.Image)
        Me.butback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butback.Name = "butback"
        Me.butback.Size = New System.Drawing.Size(30, 30)
        Me.butback.Text = "ToolStripButton1"
        '
        'butforward
        '
        Me.butforward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butforward.Image = Global.Surfer_Vio.My.Resources.Resources.forward
        Me.butforward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butforward.Name = "butforward"
        Me.butforward.Size = New System.Drawing.Size(30, 30)
        Me.butforward.Text = "ToolStripButton2"
        '
        'adress
        '
        Me.adress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adress.Name = "adress"
        Me.adress.Size = New System.Drawing.Size(430, 33)
        Me.adress.URL = Nothing
        Me.adress.WebControl = Me.browser
        '
        'browser
        '
        Me.browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser.Location = New System.Drawing.Point(0, 33)
        Me.browser.Size = New System.Drawing.Size(1091, 464)
        Me.browser.Source = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.browser.TabIndex = 2
        '
        'butgo
        '
        Me.butgo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butgo.Image = Global.Surfer_Vio.My.Resources.Resources.tick
        Me.butgo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butgo.Name = "butgo"
        Me.butgo.Size = New System.Drawing.Size(30, 30)
        Me.butgo.Text = "ToolStripButton3"
        '
        'butstop
        '
        Me.butstop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butstop.Image = Global.Surfer_Vio.My.Resources.Resources._stop
        Me.butstop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butstop.Name = "butstop"
        Me.butstop.Size = New System.Drawing.Size(30, 30)
        Me.butstop.Text = "ToolStripButton4"
        '
        'butrefresh
        '
        Me.butrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butrefresh.Image = Global.Surfer_Vio.My.Resources.Resources.Refresh
        Me.butrefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butrefresh.Name = "butrefresh"
        Me.butrefresh.Size = New System.Drawing.Size(30, 30)
        Me.butrefresh.Text = "ToolStripButton5"
        '
        'searchprovider
        '
        Me.searchprovider.Items.AddRange(New Object() {"Google", "Bing", "Yahoo!", "Youtube.com", "Wikipedia", "Torrentz.com"})
        Me.searchprovider.Name = "searchprovider"
        Me.searchprovider.Size = New System.Drawing.Size(121, 33)
        Me.searchprovider.Text = "Google"
        '
        'searchtext
        '
        Me.searchtext.Name = "searchtext"
        Me.searchtext.Size = New System.Drawing.Size(100, 33)
        Me.searchtext.Text = "Search here..."
        '
        'bookmarks
        '
        Me.bookmarks.Name = "bookmarks"
        Me.bookmarks.Size = New System.Drawing.Size(121, 33)
        '
        'butyoutuber
        '
        Me.butyoutuber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butyoutuber.Image = Global.Surfer_Vio.My.Resources.Resources.YouTube1
        Me.butyoutuber.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butyoutuber.Name = "butyoutuber"
        Me.butyoutuber.Size = New System.Drawing.Size(30, 30)
        Me.butyoutuber.Text = "ToolStripButton7"
        '
        'buthistory
        '
        Me.buthistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buthistory.Image = Global.Surfer_Vio.My.Resources.Resources.Tab_History
        Me.buthistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buthistory.Name = "buthistory"
        Me.buthistory.Size = New System.Drawing.Size(30, 30)
        Me.buthistory.Text = "ToolStripButton8"
        '
        'bookmarkmanager
        '
        Me.bookmarkmanager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bookmarkmanager.Image = Global.Surfer_Vio.My.Resources.Resources.Bookmark_Settings
        Me.bookmarkmanager.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bookmarkmanager.Name = "bookmarkmanager"
        Me.bookmarkmanager.Size = New System.Drawing.Size(30, 30)
        Me.bookmarkmanager.Text = "ToolStripButton1"
        '
        'butaddbookmark
        '
        Me.butaddbookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butaddbookmark.Image = Global.Surfer_Vio.My.Resources.Resources.Bookmark_Add
        Me.butaddbookmark.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butaddbookmark.Name = "butaddbookmark"
        Me.butaddbookmark.Size = New System.Drawing.Size(30, 30)
        Me.butaddbookmark.Text = "ToolStripButton1"
        '
        'sessionprovider
        '
        Me.sessionprovider.Views.Add(Me.browser)
        '
        'tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 519)
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.tools)
        Me.Controls.Add(Me.status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tab"
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.tools.ResumeLayout(False)
        Me.tools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents status As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents currentpage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents webprogress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents connectionstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tools As System.Windows.Forms.ToolStrip
    Friend WithEvents butback As System.Windows.Forms.ToolStripButton
    Friend WithEvents butforward As System.Windows.Forms.ToolStripButton
    Friend WithEvents adress As Awesomium.Windows.Forms.ToolStripAddressBox
    Friend WithEvents butgo As System.Windows.Forms.ToolStripButton
    Friend WithEvents butstop As System.Windows.Forms.ToolStripButton
    Friend WithEvents butrefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents searchprovider As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents searchtext As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents butyoutuber As System.Windows.Forms.ToolStripButton
    Friend WithEvents buthistory As System.Windows.Forms.ToolStripButton
    Private WithEvents browser As Awesomium.Windows.Forms.WebControl
    Friend WithEvents sessionprovider As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents butaddbookmark As System.Windows.Forms.ToolStripButton
    Friend WithEvents bookmarks As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents bookmarkmanager As System.Windows.Forms.ToolStripButton
End Class
