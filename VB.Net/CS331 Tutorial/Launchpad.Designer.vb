<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaunch
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
          Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
          Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.btnCplusplus = New System.Windows.Forms.Button()
          Me.btnNS = New System.Windows.Forms.Button()
          Me.lblCplusplus = New System.Windows.Forms.Label()
          Me.lblNS = New System.Windows.Forms.Label()
          Me.btnUnix = New System.Windows.Forms.Button()
          Me.lblUnix = New System.Windows.Forms.Label()
          Me.MenuStrip1.SuspendLayout()
          Me.SuspendLayout()
          '
          'MenuStrip1
          '
          Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
          Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
          Me.MenuStrip1.Name = "MenuStrip1"
          Me.MenuStrip1.Size = New System.Drawing.Size(517, 24)
          Me.MenuStrip1.TabIndex = 0
          Me.MenuStrip1.Text = "MenuStrip1"
          '
          'FileToolStripMenuItem
          '
          Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
          Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
          Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
          Me.FileToolStripMenuItem.Text = "&File"
          '
          'ExitToolStripMenuItem
          '
          Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
          Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
          Me.ExitToolStripMenuItem.Text = "&Exit"
          '
          'HelpToolStripMenuItem
          '
          Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
          Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
          Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
          Me.HelpToolStripMenuItem.Text = "&Help"
          '
          'AboutToolStripMenuItem
          '
          Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
          Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
          Me.AboutToolStripMenuItem.Text = "&About"
          '
          'btnCplusplus
          '
          Me.btnCplusplus.Location = New System.Drawing.Point(47, 117)
          Me.btnCplusplus.Name = "btnCplusplus"
          Me.btnCplusplus.Size = New System.Drawing.Size(107, 43)
          Me.btnCplusplus.TabIndex = 1
          Me.btnCplusplus.Text = "C++"
          Me.btnCplusplus.UseVisualStyleBackColor = True
          '
          'btnNS
          '
          Me.btnNS.Location = New System.Drawing.Point(47, 190)
          Me.btnNS.Name = "btnNS"
          Me.btnNS.Size = New System.Drawing.Size(107, 43)
          Me.btnNS.TabIndex = 3
          Me.btnNS.Text = "NS Charts"
          Me.btnNS.UseVisualStyleBackColor = True
          '
          'lblCplusplus
          '
          Me.lblCplusplus.AutoSize = True
          Me.lblCplusplus.Location = New System.Drawing.Point(175, 132)
          Me.lblCplusplus.Name = "lblCplusplus"
          Me.lblCplusplus.Size = New System.Drawing.Size(315, 26)
          Me.lblCplusplus.TabIndex = 4
          Me.lblCplusplus.Text = "This section of the program explains and demonstrates C++ code," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " including logic" & _
    " and syntax structure."
          '
          'lblNS
          '
          Me.lblNS.AutoSize = True
          Me.lblNS.Location = New System.Drawing.Point(175, 205)
          Me.lblNS.Name = "lblNS"
          Me.lblNS.Size = New System.Drawing.Size(304, 26)
          Me.lblNS.TabIndex = 6
          Me.lblNS.Text = "This section of the program explains how to correctly construct " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nassi-Schneider" & _
    "mann charts, and commenting practices "
          '
          'btnUnix
          '
          Me.btnUnix.Location = New System.Drawing.Point(47, 265)
          Me.btnUnix.Name = "btnUnix"
          Me.btnUnix.Size = New System.Drawing.Size(107, 43)
          Me.btnUnix.TabIndex = 7
          Me.btnUnix.Text = "Unix"
          Me.btnUnix.UseVisualStyleBackColor = True
          '
          'lblUnix
          '
          Me.lblUnix.AutoSize = True
          Me.lblUnix.Location = New System.Drawing.Point(175, 282)
          Me.lblUnix.Name = "lblUnix"
          Me.lblUnix.Size = New System.Drawing.Size(293, 26)
          Me.lblUnix.TabIndex = 8
          Me.lblUnix.Text = "This section of the program explains how to access a Unix" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "terminal from a window" & _
    "s machine and some basic commands"
          '
          'frmLaunch
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(517, 350)
          Me.Controls.Add(Me.lblUnix)
          Me.Controls.Add(Me.btnUnix)
          Me.Controls.Add(Me.lblNS)
          Me.Controls.Add(Me.lblCplusplus)
          Me.Controls.Add(Me.btnNS)
          Me.Controls.Add(Me.btnCplusplus)
          Me.Controls.Add(Me.MenuStrip1)
          Me.MainMenuStrip = Me.MenuStrip1
          Me.Name = "frmLaunch"
          Me.Text = "Launchpad"
          Me.MenuStrip1.ResumeLayout(False)
          Me.MenuStrip1.PerformLayout()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCplusplus As System.Windows.Forms.Button
    Friend WithEvents btnNS As System.Windows.Forms.Button
    Friend WithEvents lblCplusplus As System.Windows.Forms.Label
     Friend WithEvents lblNS As System.Windows.Forms.Label
     Friend WithEvents btnUnix As System.Windows.Forms.Button
     Friend WithEvents lblUnix As System.Windows.Forms.Label

End Class
