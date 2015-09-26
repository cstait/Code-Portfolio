Public Class frmNS
    'Class form written by Cameron Tait

    'based on the option selected, will change picture and label
    Private Sub lstNS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNS.SelectedIndexChanged

        If lstNS.SelectedIndex = 0 Then
            picTarget.Image = Image.FromFile("intmain.png")
            lblDef.Text = "When creating an NS chart, first start with a square box that will contain" + Environment.NewLine +
                "all your instructions with a function block. Label it with the name of the function." + Environment.NewLine +
                "The following examples were created with the software program Structurizer. "

        ElseIf lstNS.SelectedIndex = 1 Then
            picTarget.Image = Image.FromFile("instruction.png")
            lblDef.Text = "Each (non function) instruction you want in your program will be contained in it's" + Environment.NewLine +
                "own cell"

        ElseIf lstNS.SelectedIndex = 2 Then
            picTarget.Image = Image.FromFile("IfCondition.png")
            lblDef.Text = "An if condition consists of two rectanges, the top rectangle" + Environment.NewLine +
                "consists of three sections, one is true, other is false, another states" + Environment.NewLine +
                "the condition being checked. The bottom section is split between true and" + Environment.NewLine +
                "false, showing the instructions to be performed based on the outcome of the" + Environment.NewLine +
                "condition."

        ElseIf lstNS.SelectedIndex = 3 Then
            picTarget.Image = Image.FromFile("Case.png")
            lblDef.Text = "A case is similar to the top portion of a if condition, except it splits into more" + Environment.NewLine +
                "than true and false, going up to how many choices the user wants and" + Environment.NewLine +
                "based on what it is testing"

        ElseIf lstNS.SelectedIndex = 4 Then
            picTarget.Image = Image.FromFile("While Loop.png")
            lblDef.Text = "The while loop has the condition being tested at the top, and a smaller inner box" + Environment.NewLine +
                "that consists of the instructions"


        ElseIf lstNS.SelectedIndex = 5 Then
            picTarget.Image = Image.FromFile("forLoop.png")
            lblDef.Text = "Similar to a while loop, except the inner square has three sides instead of two"

        ElseIf lstNS.SelectedIndex = 6 Then
            picTarget.Image = Image.FromFile("function.png")
            lblDef.Text = "A function is extremely similar to an instruction, but it has a line at the beginning"

        ElseIf lstNS.SelectedIndex = 7 Then
            picTarget.Image = Image.FromFile("NestedLoops.png")
            lblDef.Text = "This example combines previous lessons to show how a Nested Loop would look like." + Environment.NewLine +
                "Notice how all the control structures are within one large box."

        End If
    End Sub

    Private Sub frmNS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstNS.SelectedIndex = 0
    End Sub

    Private Sub lblDef_Click(sender As Object, e As EventArgs) Handles lblDef.Click

    End Sub
End Class