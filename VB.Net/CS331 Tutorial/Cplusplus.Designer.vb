<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCplusplus
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
          Me.txtOutput = New System.Windows.Forms.RichTextBox()
          Me.lst = New System.Windows.Forms.ComboBox()
          Me.lblDef = New System.Windows.Forms.Label()
          Me.btnDemo = New System.Windows.Forms.Button()
          Me.lblCode = New System.Windows.Forms.Label()
          Me.SuspendLayout()
          '
          'txtOutput
          '
          Me.txtOutput.BackColor = System.Drawing.Color.LightGray
          Me.txtOutput.Location = New System.Drawing.Point(40, 152)
          Me.txtOutput.Name = "txtOutput"
          Me.txtOutput.ReadOnly = True
          Me.txtOutput.Size = New System.Drawing.Size(266, 167)
          Me.txtOutput.TabIndex = 0
          Me.txtOutput.Text = ""
          '
          'lst
          '
          Me.lst.FormattingEnabled = True
          Me.lst.Items.AddRange(New Object() {"Hello World", "If/Then Else", "Loops", "For Loops", "Cases"})
          Me.lst.Location = New System.Drawing.Point(40, 25)
          Me.lst.Name = "lst"
          Me.lst.Size = New System.Drawing.Size(121, 21)
          Me.lst.TabIndex = 1
          '
          'lblDef
          '
          Me.lblDef.AutoSize = True
          Me.lblDef.ForeColor = System.Drawing.Color.Black
          Me.lblDef.Location = New System.Drawing.Point(37, 59)
          Me.lblDef.Name = "lblDef"
          Me.lblDef.Size = New System.Drawing.Size(62, 13)
          Me.lblDef.TabIndex = 2
          Me.lblDef.Text = "Explanation"
          '
          'btnDemo
          '
          Me.btnDemo.Enabled = False
          Me.btnDemo.ForeColor = System.Drawing.Color.Black
          Me.btnDemo.Location = New System.Drawing.Point(167, 25)
          Me.btnDemo.Name = "btnDemo"
          Me.btnDemo.Size = New System.Drawing.Size(75, 23)
          Me.btnDemo.TabIndex = 3
          Me.btnDemo.Text = "Demo"
          Me.btnDemo.UseVisualStyleBackColor = True
          '
          'lblCode
          '
          Me.lblCode.AutoSize = True
          Me.lblCode.ForeColor = System.Drawing.Color.Black
          Me.lblCode.Location = New System.Drawing.Point(37, 136)
          Me.lblCode.Name = "lblCode"
          Me.lblCode.Size = New System.Drawing.Size(35, 13)
          Me.lblCode.TabIndex = 4
          Me.lblCode.Text = "Code:"
          '
          'frmCplusplus
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.White
          Me.ClientSize = New System.Drawing.Size(437, 351)
          Me.Controls.Add(Me.lblCode)
          Me.Controls.Add(Me.btnDemo)
          Me.Controls.Add(Me.lblDef)
          Me.Controls.Add(Me.lst)
          Me.Controls.Add(Me.txtOutput)
          Me.ForeColor = System.Drawing.Color.Coral
          Me.Name = "frmCplusplus"
          Me.Text = "C++ Tutorial"
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents lst As System.Windows.Forms.ComboBox
    Friend WithEvents lblDef As System.Windows.Forms.Label
    Friend WithEvents btnDemo As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
End Class
