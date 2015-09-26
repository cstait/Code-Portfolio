<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForLoop
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
        Me.lblForDescr = New System.Windows.Forms.Label()
        Me.txtForInput = New System.Windows.Forms.MaskedTextBox()
        Me.btnForTest = New System.Windows.Forms.Button()
        Me.lblForError = New System.Windows.Forms.Label()
        Me.txtForOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblForDescr
        '
        Me.lblForDescr.AutoSize = True
        Me.lblForDescr.Location = New System.Drawing.Point(13, 13)
        Me.lblForDescr.Name = "lblForDescr"
        Me.lblForDescr.Size = New System.Drawing.Size(220, 39)
        Me.lblForDescr.TabIndex = 0
        Me.lblForDescr.Text = "This is a simple for loop loop where the input" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " you enter will make the for loop" & _
    " go that many" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " times and it will output it to the screen."
        '
        'txtForInput
        '
        Me.txtForInput.Location = New System.Drawing.Point(13, 72)
        Me.txtForInput.Mask = "0"
        Me.txtForInput.Name = "txtForInput"
        Me.txtForInput.Size = New System.Drawing.Size(100, 20)
        Me.txtForInput.TabIndex = 1
        '
        'btnForTest
        '
        Me.btnForTest.Location = New System.Drawing.Point(134, 68)
        Me.btnForTest.Name = "btnForTest"
        Me.btnForTest.Size = New System.Drawing.Size(90, 23)
        Me.btnForTest.TabIndex = 2
        Me.btnForTest.Text = "Test"
        Me.btnForTest.UseVisualStyleBackColor = True
        '
        'lblForError
        '
        Me.lblForError.AutoSize = True
        Me.lblForError.Location = New System.Drawing.Point(13, 108)
        Me.lblForError.Name = "lblForError"
        Me.lblForError.Size = New System.Drawing.Size(0, 13)
        Me.lblForError.TabIndex = 4
        '
        'txtForOutput
        '
        Me.txtForOutput.Location = New System.Drawing.Point(13, 143)
        Me.txtForOutput.Name = "txtForOutput"
        Me.txtForOutput.Size = New System.Drawing.Size(100, 139)
        Me.txtForOutput.TabIndex = 5
        Me.txtForOutput.Text = ""
        '
        'frmForLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 294)
        Me.Controls.Add(Me.txtForOutput)
        Me.Controls.Add(Me.lblForError)
        Me.Controls.Add(Me.btnForTest)
        Me.Controls.Add(Me.txtForInput)
        Me.Controls.Add(Me.lblForDescr)
        Me.Name = "frmForLoop"
        Me.Text = "frmForLoop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblForDescr As System.Windows.Forms.Label
    Friend WithEvents txtForInput As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnForTest As System.Windows.Forms.Button
    Friend WithEvents lblForError As System.Windows.Forms.Label
    Friend WithEvents txtForOutput As System.Windows.Forms.RichTextBox
End Class
