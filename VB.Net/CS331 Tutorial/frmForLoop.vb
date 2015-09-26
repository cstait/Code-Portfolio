Public Class frmForLoop

    Inherits System.Windows.Forms.Form

    'creates a reference to the frmCplusplus form
    Public myCaller As frmCplusplus

    Private Sub btnForTest_Click(sender As Object, e As EventArgs) Handles btnForTest.Click
        txtForOutput.Clear()
        lblForError.Text = ""

        If txtForInput.Text = "" Then
            lblForError.Text = "Please Enter a value in the text box!"
        Else
            For x As Integer = 1 To txtForInput.Text Step 1
                txtForOutput.AppendText(x)
                txtForOutput.AppendText(Environment.NewLine)
            Next
        End If
    End Sub

    ' added by Caleb Schaefer
    ' handles the event of closing the form. When the form is closed,
    ' it reenables the demo button and the list box.
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) _
    Handles Me.FormClosing
        myCaller.btnDemo.Enabled = True
        myCaller.lst.Enabled = True

    End Sub
End Class