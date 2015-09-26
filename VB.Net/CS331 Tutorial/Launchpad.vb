Public Class frmLaunch
    'The launchpad and functions were written by Cameron Tait

    'This function exits the program when clicking on the exit button on the tool strip
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    'this launches the about form which shows information about the program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim newForm As frmAbout
        newForm = New frmAbout
        newForm.Show()
        newForm = Nothing
    End Sub
    'this launches a new form that hosts the c++ portion of the program
    Private Sub btnCplusplus_Click(sender As Object, e As EventArgs) Handles btnCplusplus.Click
        Dim newForm As frmCplusplus
        newForm = New frmCplusplus
        newForm.Show()
        newForm = Nothing
    End Sub


    'this button launches the NS chart portion of the program
    Private Sub btnNS_Click(sender As Object, e As EventArgs) Handles btnNS.Click
        Dim newForm As frmNS
        newForm = New frmNS
        newForm.Show()
        newForm = Nothing
    End Sub



     'this button launches the unix portion of the program
     Private Sub btnUnix_Click(sender As Object, e As EventArgs) Handles btnUnix.Click
          Dim newForm As frmUnix
          newForm = New frmUnix
          newForm.Show()
          newForm = Nothing
     End Sub

     Private Sub frmLaunch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

     End Sub
End Class
