<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCases
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
          Me.txtCases = New System.Windows.Forms.MaskedTextBox()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.btnTest = New System.Windows.Forms.Button()
          Me.lblOutput = New System.Windows.Forms.Label()
          Me.SuspendLayout()
          '
          'txtCases
          '
          Me.txtCases.Location = New System.Drawing.Point(12, 37)
          Me.txtCases.Name = "txtCases"
          Me.txtCases.Size = New System.Drawing.Size(100, 20)
          Me.txtCases.TabIndex = 0
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(13, 13)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(209, 13)
          Me.Label1.TabIndex = 1
          Me.Label1.Text = "Enter a number 1-5 to test the case switch!"
          '
          'btnTest
          '
          Me.btnTest.Location = New System.Drawing.Point(118, 35)
          Me.btnTest.Name = "btnTest"
          Me.btnTest.Size = New System.Drawing.Size(75, 23)
          Me.btnTest.TabIndex = 2
          Me.btnTest.Text = "Test"
          Me.btnTest.UseVisualStyleBackColor = True
          '
          'lblOutput
          '
          Me.lblOutput.AutoSize = True
          Me.lblOutput.Location = New System.Drawing.Point(13, 79)
          Me.lblOutput.Name = "lblOutput"
          Me.lblOutput.Size = New System.Drawing.Size(78, 13)
          Me.lblOutput.TabIndex = 3
          Me.lblOutput.Text = "Try out a case!"
          '
          'frmCases
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(284, 262)
          Me.Controls.Add(Me.lblOutput)
          Me.Controls.Add(Me.btnTest)
          Me.Controls.Add(Me.Label1)
          Me.Controls.Add(Me.txtCases)
          Me.Name = "frmCases"
          Me.Text = "Cases Demo"
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents txtCases As System.Windows.Forms.MaskedTextBox
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents btnTest As System.Windows.Forms.Button
     Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
