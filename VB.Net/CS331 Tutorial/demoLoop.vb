Public Class frmLoop


    Inherits System.Windows.Forms.Form

    'creates a reference to the frmCplusplus form
    Public myCaller As frmCplusplus



    'Written by Cameron Tait
    'This button clears the textbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoop.Text = ""
    End Sub
    'This function is a loop that counts by 2 until it reaches 100, it pauses between loops and outputs the current status to screen
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim I As Integer = 0
        While I <> 102
            txtLoop.AppendText(I)
            txtLoop.AppendText(Environment.NewLine)
            I += 2
            Threading.Thread.Sleep(300)
            txtLoop.Refresh()
        End While


    End Sub


    Private Sub txtLoop_TextChanged(sender As Object, e As EventArgs) Handles txtLoop.TextChanged

    End Sub

    ' added by Caleb Schaefer
    ' handles the event of closing the form. When the form is closed,
    ' it reenables the demo button and the list box.
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) _
    Handles Me.FormClosing
        myCaller.btnDemo.Enabled = True
        myCaller.lst.Enabled = True

    End Sub

     Private Sub frmLoop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

     End Sub
End Class