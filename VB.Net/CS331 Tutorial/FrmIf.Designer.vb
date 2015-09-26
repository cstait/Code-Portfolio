<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIf
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
        Me.lblIfDescr = New System.Windows.Forms.Label()
        Me.btnTestIf = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.MaskedTextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIfDescr
        '
        Me.lblIfDescr.AutoSize = True
        Me.lblIfDescr.Location = New System.Drawing.Point(13, 13)
        Me.lblIfDescr.Name = "lblIfDescr"
        Me.lblIfDescr.Size = New System.Drawing.Size(278, 65)
        Me.lblIfDescr.TabIndex = 0
        Me.lblIfDescr.Text = "This is a simple if statement where the input you enter will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do one of two thin" & _
    "gs:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If value >= 5 it will print out Value is Greater or Equal to 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Else prin" & _
    "t value is less than 5"
        '
        'btnTestIf
        '
        Me.btnTestIf.Location = New System.Drawing.Point(148, 95)
        Me.btnTestIf.Name = "btnTestIf"
        Me.btnTestIf.Size = New System.Drawing.Size(75, 23)
        Me.btnTestIf.TabIndex = 2
        Me.btnTestIf.Text = "Test"
        Me.btnTestIf.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(13, 136)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 4
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(13, 96)
        Me.txtInput.Mask = "0"
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 5
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 170)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(210, 20)
        Me.txtOutput.TabIndex = 6
        '
        'frmIf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 219)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnTestIf)
        Me.Controls.Add(Me.lblIfDescr)
        Me.Name = "frmIf"
        Me.Text = "If Then Else Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIfDescr As System.Windows.Forms.Label
    Friend WithEvents btnTestIf As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
