<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnix
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
          Me.lstUnix = New System.Windows.Forms.ComboBox()
          Me.lnkPutty = New System.Windows.Forms.LinkLabel()
          Me.lblOutput = New System.Windows.Forms.Label()
          Me.SuspendLayout()
          '
          'lstUnix
          '
          Me.lstUnix.FormattingEnabled = True
          Me.lstUnix.Items.AddRange(New Object() {"Getting Started", "Navigating Unix", "Creating A Program"})
          Me.lstUnix.Location = New System.Drawing.Point(12, 12)
          Me.lstUnix.Name = "lstUnix"
          Me.lstUnix.Size = New System.Drawing.Size(121, 21)
          Me.lstUnix.TabIndex = 0
          '
          'lnkPutty
          '
          Me.lnkPutty.AutoSize = True
          Me.lnkPutty.Location = New System.Drawing.Point(165, 15)
          Me.lnkPutty.Name = "lnkPutty"
          Me.lnkPutty.Size = New System.Drawing.Size(82, 13)
          Me.lnkPutty.TabIndex = 1
          Me.lnkPutty.TabStop = True
          Me.lnkPutty.Text = "Download Putty"
          '
          'lblOutput
          '
          Me.lblOutput.AutoSize = True
          Me.lblOutput.Location = New System.Drawing.Point(13, 59)
          Me.lblOutput.Name = "lblOutput"
          Me.lblOutput.Size = New System.Drawing.Size(41, 13)
          Me.lblOutput.TabIndex = 2
          Me.lblOutput.Text = "Default"
          '
          'frmUnix
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(611, 319)
          Me.Controls.Add(Me.lblOutput)
          Me.Controls.Add(Me.lnkPutty)
          Me.Controls.Add(Me.lstUnix)
          Me.Name = "frmUnix"
          Me.Text = "Unix Tutorial"
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents lstUnix As System.Windows.Forms.ComboBox
     Friend WithEvents lnkPutty As System.Windows.Forms.LinkLabel
     Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
