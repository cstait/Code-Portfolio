Public Class frmCases

     'Inherits System.Windows.Forms.Form
     'Public myCaller As frmCases

     Private Sub txtCases_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCases.MaskInputRejected

     End Sub

     Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
          Dim caseNum As Integer = txtCases.Text
          Select Case caseNum
               Case 1
                    lblOutput.Text = "You put in the number one, congratulations!"
               Case 2
                    lblOutput.Text = "You put in the number two, congratulations!"
               Case 3
                    lblOutput.Text = "You put in the number three, congratulations!"
               Case 4
                    lblOutput.Text = "You put in the number four, congratulations!"
               Case 5
                    lblOutput.Text = "You put in the number five, congratulations!"
               Case Else
                    lblOutput.Text = "You didn't put in numbers from 1 to 5, what are you doing!"
          End Select
     End Sub

     Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) _
      '  Handles Me.FormClosing
          '   myCaller.btnDemo.Enabled = True
          '  myCaller.lst.Enabled = True

     End Sub
End Class