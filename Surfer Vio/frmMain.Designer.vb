<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.defpage = New System.Windows.Forms.TabPage()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.newtab = New System.Windows.Forms.TabPage()
        Me.tabimage = New System.Windows.Forms.ImageList(Me.components)
        Me.desktop = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
        Me.networkchecker = New System.Windows.Forms.Timer(Me.components)
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.tabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'defpage
        '
        Me.defpage.Location = New System.Drawing.Point(4, 23)
        Me.defpage.Name = "defpage"
        Me.defpage.Padding = New System.Windows.Forms.Padding(3)
        Me.defpage.Size = New System.Drawing.Size(829, 467)
        Me.defpage.TabIndex = 0
        Me.defpage.Text = "Blank page"
        Me.defpage.UseVisualStyleBackColor = True
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.defpage)
        Me.tabs.Controls.Add(Me.newtab)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.ImageList = Me.tabimage
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(837, 494)
        Me.tabs.TabIndex = 0
        '
        'newtab
        '
        Me.newtab.Location = New System.Drawing.Point(4, 23)
        Me.newtab.Name = "newtab"
        Me.newtab.Padding = New System.Windows.Forms.Padding(3)
        Me.newtab.Size = New System.Drawing.Size(829, 467)
        Me.newtab.TabIndex = 1
        Me.newtab.Text = "Add tab"
        Me.newtab.UseVisualStyleBackColor = True
        '
        'tabimage
        '
        Me.tabimage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.tabimage.ImageSize = New System.Drawing.Size(16, 16)
        Me.tabimage.TransparentColor = System.Drawing.Color.Transparent
        '
        'desktop
        '
        Me.desktop.Opacity = 1.0!
        Me.desktop.ShowOptionsButton = False
        Me.desktop.ShowPinButton = False
        Me.desktop.ThemeName = "Windows8"
        '
        'networkchecker
        '
        Me.networkchecker.Enabled = True
        Me.networkchecker.Interval = 2000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 494)
        Me.Controls.Add(Me.tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Surfer Vio"
        Me.tabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents defpage As System.Windows.Forms.TabPage
    Friend WithEvents tabs As System.Windows.Forms.TabControl
    Friend WithEvents newtab As System.Windows.Forms.TabPage
    Friend WithEvents tabimage As System.Windows.Forms.ImageList
    Friend WithEvents desktop As Telerik.WinControls.UI.RadDesktopAlert
    Friend WithEvents networkchecker As System.Windows.Forms.Timer
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme

End Class
