<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNS
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
        Me.picTarget = New System.Windows.Forms.PictureBox()
        Me.lblDef = New System.Windows.Forms.Label()
        Me.lstNS = New System.Windows.Forms.ComboBox()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTarget
        '
        Me.picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picTarget.Location = New System.Drawing.Point(12, 126)
        Me.picTarget.Name = "picTarget"
        Me.picTarget.Size = New System.Drawing.Size(272, 385)
        Me.picTarget.TabIndex = 10
        Me.picTarget.TabStop = False
        '
        'lblDef
        '
        Me.lblDef.AutoSize = True
        Me.lblDef.ForeColor = System.Drawing.Color.Black
        Me.lblDef.Location = New System.Drawing.Point(12, 50)
        Me.lblDef.Name = "lblDef"
        Me.lblDef.Size = New System.Drawing.Size(62, 13)
        Me.lblDef.TabIndex = 9
        Me.lblDef.Text = "Explanation"
        '
        'lstNS
        '
        Me.lstNS.FormattingEnabled = True
        Me.lstNS.Items.AddRange(New Object() {"Int Main", "Instruction", "IfCondition", "Case", "While Loop", "For Loop", "Function", "NestedLoop"})
        Me.lstNS.Location = New System.Drawing.Point(12, 12)
        Me.lstNS.Name = "lstNS"
        Me.lstNS.Size = New System.Drawing.Size(121, 21)
        Me.lstNS.TabIndex = 8
        '
        'frmNS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 521)
        Me.Controls.Add(Me.picTarget)
        Me.Controls.Add(Me.lblDef)
        Me.Controls.Add(Me.lstNS)
        Me.Name = "frmNS"
        Me.Text = "NS Tutorial"
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTarget As System.Windows.Forms.PictureBox
    Friend WithEvents lblDef As System.Windows.Forms.Label
    Friend WithEvents lstNS As System.Windows.Forms.ComboBox
End Class
