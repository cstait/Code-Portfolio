'------------------------------------------------------------
'-                File Name : Form1.frm                     - 
'-                Part of Project: Assign10                  -
'------------------------------------------------------------
'-                Written By: Scott James/Cameron Tait                     -
'-                Written On: 4/22/2014                     -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file demonstrates the use of a user created control and
'- how it is modifiable by local code                             - 
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- Same as file purpose             -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- none
'------------------------------------------------------------




Public Class Form1
    'Chapter 21 - Program 1



    'Click button 1 to change the clock's foreground color


    '------------------------------------------------------------
    '-                Subprogram Name: Button1_Click            -
    '------------------------------------------------------------
    '-                Written By: Scott James/Cameron Tait                     -
    '-                Written On: 4/22/2014        -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '-  Changes user created control foreground color to red  –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyClock1.ForeColor = Color.Red
    End Sub

    'Click button 2 to change to the form's background color and
    'see that the clock's background color automatically changes
    'to match

    '------------------------------------------------------------
    '-                Subprogram Name: Button2_Click            -
    '------------------------------------------------------------
    '-                Written By: Scott James/Cameron Tait                     -
    '-                Written On: 4/22/2014        -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '-  Changes form's background color to white  –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.White
    End Sub

End Class
