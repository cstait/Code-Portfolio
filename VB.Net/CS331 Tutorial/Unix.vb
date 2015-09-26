Public Class frmUnix
    Private Sub frmUnix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          lstUnix.SelectedIndex = 0
    End Sub

     Private Sub lnkPutty_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPutty.LinkClicked
          System.Diagnostics.Process.Start("http://downloads.svsu.edu/putty.exe")
     End Sub

     Private Sub lstUnix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnix.SelectedIndexChanged
          If lstUnix.SelectedIndex = 0 Then
               lnkPutty.Visible = True
               lblOutput.Text = "To get started with accessing the Unix terminal, download putty at the link above" + Environment.NewLine +
               "and then enter CSIS.SVSU.EDU under the hostname with port 22 and SSH selected. If successful" + Environment.NewLine +
               "a console box should show up that asks for your SVSU name and password."

          ElseIf lstUnix.SelectedIndex = 1 Then
               lnkPutty.Visible = False
               lblOutput.Text = "There are several commands used to navigate unix, similar to a windows file system:" + Environment.NewLine +
                    "cd nameofdirectory   -- This command allows you to change directories (aka folders)" + Environment.NewLine +
                    "mkdir nameofdirectory -- This command allows you to make new directories" + Environment.NewLine +
                    "ll  -- this lists the contents of the directory you're currently in" + Environment.NewLine +
                    "rm fileName -- becareful with this command, it allows you to remove files and directories permanently" + Environment.NewLine +
                    "mv sourceDirectory destinationDirectory -- this command allows you to move files from one directory to another" + Environment.NewLine +
                    "cp sourceDirectory destinationDirectory -- this command allows you to copy files from one directory to another"
          ElseIf lstUnix.SelectedIndex = 2 Then
               lnkPutty.Visible = False
               lblOutput.Text = "To start programming with Unix, a simple tool to use is a text editor called Pico" + Environment.NewLine +
                    "pico filename -- this command either opens an existing file with pico or creates a new one with that name" + Environment.NewLine +
                    "After creating a c++ program you can save it by hitting ctrl + o, and confirming the name of the program file," + Environment.NewLine +
                    "make sure to give it the file extension cxx by adding .cxx to the end of the name." + Environment.NewLine + Environment.NewLine +
                    "Once you are finished with the program in pico, hit ctrl x to exit pico and then when at the command line" + Environment.NewLine +
                    "cxx fileName.cxx -- this command will attempt to compile your program, if successful it will result in an a.out file in your directory " + Environment.NewLine +
                    "./a.out -- will attempt to run your program. Remember to hit ctrl + c to exit your program if it doesn't return control" + Environment.NewLine +
                    "to the console line."
          End If
     End Sub
End Class