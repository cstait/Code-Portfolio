Public Class frmCplusplus

    Inherits System.Windows.Forms.Form

    'creates a reference to the frmCplusplus form
    Public myCaller As frmCplusplus


    'Cplusplus layout designed by Cameron Tait

    'this function changes the text box, label, and button status based on which item is selected
    Private Sub comboList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst.SelectedIndexChanged
        btnDemo.Enabled = True

          If lst.SelectedIndex = 0 Then
               btnDemo.Enabled = False
               txtOutput.Text = "int main()" + Environment.NewLine +
                                 "{" + Environment.NewLine +
                                 "cout <<""Hello World!""<< endl;" + Environment.NewLine +
                                 "return 0;" + Environment.NewLine +
                                 "}"
               lblDef.Text = "This is the simplest starting program in C++, it display" + Environment.NewLine +
                    "a output statement that says Hello World. Every program is required to have an int" + Environment.NewLine +
                    " main enclosure in C++, this tells the computer where the program starts and ends."


          ElseIf lst.SelectedIndex = 1 Then
               btnDemo.Enabled = True
               txtOutput.Text = "int x = 5" + Environment.NewLine + Environment.NewLine +
                                "if(x > 5)" + Environment.NewLine +
                                "{" + Environment.NewLine +
                                "x += 1;" + Environment.NewLine +
                                "cout << x << endl;" + Environment.NewLine +
                                "}" + Environment.NewLine +
                                "else" + Environment.NewLine +
                                "{" + Environment.NewLine +
                                "x -= 1;" + Environment.NewLine +
                                "cout << x << endl;" + Environment.NewLine +
                                "}" + Environment.NewLine + Environment.NewLine +
                                "This code is a very simple if then else statement that if" +
                                " x > 5 then increment and print, else decrement and print."



               lblDef.Text = "If then else statements are good for doing an instruction if" +
                             "the criteria meet whats in" + Environment.NewLine +
                             "the if and if it does not it goes to the else statemet."

          ElseIf lst.SelectedIndex = 2 Then
               btnDemo.Enabled = True

               txtOutput.Text = "while (x ! = 10)" + Environment.NewLine +
                                "{" + Environment.NewLine +
                                "cout << x << endl;" + Environment.NewLine +
                                "x += 1;" + Environment.NewLine +
                                "}" + Environment.NewLine + Environment.NewLine +
                                "This code send the counter number (x) out each time it goes through the" +
                                "loop, until x = 10"

               lblDef.Text = " Loops are a type of control structure that repeat themselves" +
                             "(potentially endlessly)" + Environment.NewLine +
                             "until a certain condition is met."

          ElseIf lst.SelectedIndex = 3 Then
               btnDemo.Enabled = True
               txtOutput.Text = "for(x; x < 9; x++)" + Environment.NewLine +
                                "{" + Environment.NewLine +
                                "cout << x << endl;" + Environment.NewLine +
                                "}" + Environment.NewLine + Environment.NewLine +
                                "This code increments the x value each interval and then prints out to the screen"

               lblDef.Text = "For loops are good for looping a certain amount of times an givin you a value that" +
                             Environment.NewLine + " that increments with it."
          ElseIf lst.SelectedIndex = 4 Then
               btnDemo.Enabled = True
               txtOutput.Text = "switch (x)" + Environment.NewLine +
                    "{" + Environment.NewLine +
  "case 1:" + Environment.NewLine +
   " cout << ""x is 1"";" + Environment.NewLine +
   "break;" + Environment.NewLine +
  "case 2:" + Environment.NewLine +
    "cout << ""x is 2"";" + Environment.NewLine +
    "break;" + Environment.NewLine +
  "default:" + Environment.NewLine +
    "cout << ""value of x unknown"";" + Environment.NewLine +
  "}"
               lblDef.Text = "The switch statement is perfect for having an answer" + Environment.NewLine +
                    "to every problem that can be encountered when your program is running. " + Environment.NewLine +
                    "Essentially it tests the value of x to the case number, if the numbers match" + Environment.NewLine +
                    "the program will execute the following code, otherwise it executes" + Environment.NewLine +
                    "the default line of code."

          End If


    End Sub

     'this button launches a form based on what option was selected created by Caleb Schaeffer
     Private Sub btnDemo_Click(sender As Object, e As EventArgs) Handles btnDemo.Click
          If lst.SelectedIndex = 0 Then
               btnDemo.Enabled = False

          ElseIf lst.SelectedIndex = 1 Then
               btnDemo.Enabled = False
               Dim newForm As frmIf
               newForm = New frmIf
               newForm.Show()
               newForm.myCaller = Me      ' links this form to the new form created, for dynamic modification
               newForm = Nothing
               btnDemo.Enabled = False
               lst.Enabled = False


          ElseIf lst.SelectedIndex = 2 Then
               btnDemo.Enabled = False
               Dim newForm As frmLoop
               newForm = New frmLoop
               newForm.Show()
               newForm.myCaller = Me      ' links this form to the new form created, for dynamic modification
               newForm = Nothing
               btnDemo.Enabled = False
               lst.Enabled = False

          ElseIf lst.SelectedIndex = 3 Then
               btnDemo.Enabled = False
               Dim newForm As frmForLoop
               newForm = New frmForLoop
               newForm.Show()
               newForm.myCaller = Me   ' links this form to the new form created, for dynamic modification
               newForm = Nothing
               btnDemo.Enabled = False
               lst.Enabled = False
          ElseIf lst.SelectedIndex = 4 Then
               btnDemo.Enabled = False
               Dim newForm As frmCases
               newForm = New frmCases
               newForm.Show()
               'newForm.myCaller = Me   ' links this form to the new form created, for dynamic modification
               newForm = Nothing
               btnDemo.Enabled = False
               lst.Enabled = False

          End If
     End Sub


    Private Sub frmCplusplus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst.SelectedIndex = 0
    End Sub


End Class