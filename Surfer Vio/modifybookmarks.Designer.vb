<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifybookmarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modifybookmarks))
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBoxControl2 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txturl = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadTextBoxControl1 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtname = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txturl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(407, 100)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 32)
        Me.RadButton2.TabIndex = 14
        Me.RadButton2.Text = "&Cancel"
        Me.RadButton2.ThemeName = "TelerikMetroBlue"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(291, 100)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 32)
        Me.RadButton1.TabIndex = 13
        Me.RadButton1.Text = "&Ok"
        Me.RadButton1.ThemeName = "TelerikMetroBlue"
        '
        'RadTextBoxControl2
        '
        Me.RadTextBoxControl2.Location = New System.Drawing.Point(102, 57)
        Me.RadTextBoxControl2.Name = "RadTextBoxControl2"
        Me.RadTextBoxControl2.Size = New System.Drawing.Size(415, 30)
        Me.RadTextBoxControl2.TabIndex = 11
        Me.RadTextBoxControl2.ThemeName = "TelerikMetroBlue"
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(102, 57)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(415, 30)
        Me.txturl.TabIndex = 12
        Me.txturl.ThemeName = "TelerikMetroBlue"
        '
        'RadTextBoxControl1
        '
        Me.RadTextBoxControl1.Location = New System.Drawing.Point(102, 10)
        Me.RadTextBoxControl1.Name = "RadTextBoxControl1"
        Me.RadTextBoxControl1.Size = New System.Drawing.Size(415, 30)
        Me.RadTextBoxControl1.TabIndex = 10
        Me.RadTextBoxControl1.ThemeName = "TelerikMetroBlue"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(102, 10)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(415, 30)
        Me.txtname.TabIndex = 9
        Me.txtname.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 57)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(29, 16)
        Me.RadLabel2.TabIndex = 8
        Me.RadLabel2.Text = "URL"
        Me.RadLabel2.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(36, 16)
        Me.RadLabel3.TabIndex = 6
        Me.RadLabel3.Text = "Name"
        Me.RadLabel3.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(36, 16)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Name"
        Me.RadLabel1.ThemeName = "TelerikMetroBlue"
        '
        'modifybookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 145)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadTextBoxControl2)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.RadTextBoxControl1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modifybookmarks"
        Me.Text = "Modify bookmark"
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txturl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBoxControl2 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txturl As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadTextBoxControl1 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtname As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class
