Public Class frmIf
    
    Inherits System.Windows.Forms.Form

    'creates a reference to the frmCplusplus form
    Public myCaller As frmCplusplus



        Private Sub btnTestIf_Click(sender As Object, e As EventArgs) Handles btnTestIf.Click

            txtOutput.Clear()
            lblError.Text = ""

            If (txtInput.Text = "") Then
            lblError.Text = "Please Enter a value in the text box!"



            Else
                If (txtInput.Text >= 5) Then
                    txtOutput.Text = "Value is Greater or Equal to 5"

                Else
                    txtOutput.Text = "Value is less than 5"

                End If
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