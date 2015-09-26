'------------------------------------------------------------
'-                File Name : frmMain.frm                     - 
'-                Part of Project: Assign4                  -
'------------------------------------------------------------
'-                Written By: Cameron Tait                     -
'-                Written On: 2-18-2014        
'-                Modified On: 3-25-2014
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program uses dictionaries to track data and display it
'- to the user who can manipulate it through the GUI using drag and drop
'-
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'–none
'------------------------------------------------------------

Public Class frmMain

    Dim dicDictionary As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, Integer)))
    Dim dicHamburgerPlatter As New Dictionary(Of String, Dictionary(Of String, Integer))
    Dim dicChickenSaladPlatter As New Dictionary(Of String, Dictionary(Of String, Integer))
    Dim dicHamburger As New Dictionary(Of String, Integer)
    Dim dicChickenSalad As New Dictionary(Of String, Integer)
    Dim dicSoftDrink As New Dictionary(Of String, Integer)
    Dim dicFries As New Dictionary(Of String, Integer)
    Dim lstRawItems As New List(Of String)
    Dim lstPrepItems As New List(Of String)
    Dim blnRemovePrep As Boolean = False
    Dim blnRemoveRaw As Boolean = False
    Dim blnAddPrep As Boolean = False
    Dim blnAddRaw As Boolean = False


    ' ------------------------------------------------------------
    '-                Subprogram Name: frmMain_Load            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 2-18-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Whenever the form loads it sets the default dictionary values
    '-and the list, also loads these values into the listbox     
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPreppedDish.AllowDrop = False
        lstRaw.AllowDrop = False
        Me.AllowDrop = True
        lstRawItems.Add("Beef Patty")
        lstRawItems.Add("Bun")
        lstRawItems.Add("Ketchup")
        lstRawItems.Add("Mustard")
        lstRawItems.Add("Onions")
        lstRawItems.Add("Pickles")
        lstRawItems.Add("Plate")
        lstRawItems.Add("Basket")
        lstRawItems.Add("Chicken")
        lstRawItems.Add("Lettuce")
        lstRawItems.Add("Mayonaise")
        lstRawItems.Add("Potatoes")
        lstRawItems.Add("Carton")
        lstRawItems.Add("Water")
        lstRawItems.Add("Corn Syrup")
        lstRawItems.Add("Cup")



        lstPrepItems.Add("Chicken Salad")
        lstPrepItems.Add("Fries")
        lstPrepItems.Add("Hamburger")
        lstPrepItems.Add("Soft Drink")



        lstRawItems.Sort()
        lstPrepItems.Sort()

        dicDictionary.Add("Hamburger Platter", dicHamburgerPlatter)
        dicDictionary.Add("Chicken Salad Platter", dicChickenSaladPlatter)

        dicHamburgerPlatter.Add("Hamburger", dicHamburger)
        dicHamburgerPlatter.Add("Fries", dicFries)
        dicHamburgerPlatter.Add("Soft Drink", dicSoftDrink)


        dicChickenSaladPlatter.Add("Chicken Salad", dicChickenSalad)
        dicChickenSaladPlatter.Add("Fries", dicFries)
        dicChickenSaladPlatter.Add("Soft Drink", dicSoftDrink)

        dicHamburger.Add("Beef Patty", 0)
        dicHamburger.Add("Bun", 1)
        dicHamburger.Add("Ketchup", 2)
        dicHamburger.Add("Mustard", 3)
        dicHamburger.Add("Onions", 4)
        dicHamburger.Add("Pickles", 5)
        dicHamburger.Add("Plate", 6)

        dicChickenSalad.Add("Plate", 0)
        dicChickenSalad.Add("Basket", 1)
        dicChickenSalad.Add("Chicken", 2)
        dicChickenSalad.Add("Lettuce", 3)
        dicChickenSalad.Add("Mayonaise", 4)

        dicFries.Add("Potatoes", 0)
        dicFries.Add("Carton", 1)

        dicSoftDrink.Add("Water", 0)
        dicSoftDrink.Add("Corn Syrup", 1)
        dicSoftDrink.Add("Cup", 2)


        For Each strKey In dicDictionary.Keys
            lstDishes.Items.Add(strKey)
        Next



        For Each element In lstRawItems
            lstAllRaw.Items.Add(element)
        Next

        For Each element In lstPrepItems
            lstPreppedItems.Items.Add(element)
        Next



        lstDishes.SelectedIndex = 0
        lstPreppedDish.SelectedIndex = 0
        lstAllRaw.SelectedIndex = 0
        lstPreppedItems.SelectedIndex = 0




    End Sub



    ' ------------------------------------------------------------
    '-                Subprogram Name: lstDishes_SelectedIndexChanged           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 2-18-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Whenever the index changes it loads the array values in 
    '-related listbox
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTemporary: stores the index value for use in locating
    '-the correct dictionary
    '-dicTempDic: points to the dictionary in order to read out values                                                 -
    '------------------------------------------------------------

    Private Sub lstDishes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDishes.SelectedIndexChanged

        lstPreppedDish.Items.Clear()
        Dim strTemporary As String = lstDishes.SelectedItem
        Dim dicTempDic As Dictionary(Of String, Dictionary(Of String, Integer))
        dicTempDic = dicDictionary.Item(strTemporary)

        For Each strKey In dicTempDic.Keys
            lstPreppedDish.Items.Add(strKey)
        Next



    End Sub




    ' ------------------------------------------------------------
    '-                Subprogram Name: lstPreppedDish_SelectedIndexChanged            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 2-18-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Whenever the index changes it loads the array values in 
    '-related listbox
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTemporary: stores the index value for use in locating
    '-the correct dictionary
    '-dicTempDic: points to the dictionary in order to read out values  
    '-strTemporay2: stores the the second index value
    '-dicTempDic2: for use in finding the nested dictionary
    '------------------------------------------------------------

    Private Sub lstPreppedDish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPreppedDish.SelectedIndexChanged

        lstRaw.Items.Clear()

        Dim strTemporary As String = lstDishes.SelectedItem
        Dim dicTempDic As Dictionary(Of String, Dictionary(Of String, Integer))
        dicTempDic = dicDictionary.Item(strTemporary)

        Dim strTemporary2 As String = lstPreppedDish.SelectedItem
        Dim dicTempDic2 As Dictionary(Of String, Integer)
        dicTempDic2 = dicTempDic.Item(strTemporary2)

        For Each strKey In dicTempDic2.Keys
            lstRaw.Items.Add(strKey)
        Next


    End Sub


    ' ------------------------------------------------------------
    '-                Subprogram Name: btnAddDish_Click            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 2-18-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Adds a dish to the list, if it doesn't already exist
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTemporary: stores the text value to add to the dictionary                                         -
    '------------------------------------------------------------

    Private Sub btnAddDish_Click(sender As Object, e As EventArgs) Handles btnAddDish.Click
        Dim strTemporary As String = txtAddDish.Text
        If dicDictionary.ContainsKey(strTemporary) Then
            MsgBox("Error, this Item Already Exists", , "Error")
        ElseIf strTemporary = "" Then
            MsgBox("Error, please enter text", , "Error")
        Else
            lstDishes.Items.Clear()
            dicDictionary.Add(strTemporary, New Dictionary(Of String, Dictionary(Of String, Integer)))
            For Each strKey In dicDictionary.Keys
                lstDishes.Items.Add(strKey)
            Next
            lstRaw.Items.Clear()
        End If

    End Sub


    ' ------------------------------------------------------------
    '-                Subprogram Name: btnAddRaw_Click        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 2-18-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- adds values to the list if they don't exist already
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTemporary: stores text value to be added to the list                                                 -
    '------------------------------------------------------------

    Private Sub btnAddRaw_Click(sender As Object, e As EventArgs) Handles btnAddRaw.Click
        Dim strTemporary As String = txtAddPrepped.Text
        If lstPrepItems.Contains(strTemporary) Then
            MsgBox("Error, this Item Already Exists", , "Error")
        ElseIf strTemporary = "" Then
            MsgBox("Error, please enter text", , "Error")
        Else
            lstPreppedItems.Items.Clear()
            lstPrepItems.Add(strTemporary)
            lstPrepItems.Sort()
            For Each Element In lstPrepItems
                lstPreppedItems.Items.Add(Element)
            Next
        End If
    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: btnAddPrepped_Click            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 2-18-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- adds values to the list if they don't exist already
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTemporary: stores text value to be added to the list                                                 -
    '------------------------------------------------------------

    Private Sub btnAddPrepped_Click(sender As Object, e As EventArgs) Handles btnAddPrepped.Click
        Dim strTemporary As String = txtAddRaw.Text
        If lstRawItems.Contains(strTemporary) Then
            MsgBox("Error, this Item Already Exists", , "Error")
        ElseIf strTemporary = "" Then
            MsgBox("Error, please enter text", , "Error")
        Else
            lstAllRaw.Items.Clear()
            lstRawItems.Add(strTemporary)
            lstRawItems.Sort()
            For Each Element In lstRawItems
                lstAllRaw.Items.Add(Element)
            Next
        End If
    End Sub

 
    ' ------------------------------------------------------------
    '-                Subprogram Name: lstPreppedItems_MouseMove           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Activates whenever the mouse moves into the lstBox, allowing
    '- you to start drag and drop actions
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- dropEffect                           -
    '------------------------------------------------------------

    Private Sub lstPreppedItems_MouseMove(sender As Object, e As MouseEventArgs) Handles lstPreppedItems.MouseMove
        Dim dropEffect As DragDropEffects

        If e.Button = Windows.Forms.MouseButtons.Left Then
            lstPreppedDish.AllowDrop = True
            lstRaw.AllowDrop = False
            Me.AllowDrop = False
            'If the left mouse button is down, proceed with the 
            'drag-and-drop, passing in the list item.                     
            dropEffect = lstPreppedItems.DoDragDrop(lstPreppedItems.Items(lstPreppedItems.SelectedIndex),
                                            DragDropEffects.Copy Or DragDropEffects.None)
        End If


    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: lstPreppedDish_DragEnter            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On:  3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Enables upon dragging an object into DragEnter, allowing 
    '- the user to copy
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub lstPreppedDish_DragEnter(sender As Object, e As DragEventArgs) Handles lstPreppedDish.DragEnter
        e.Effect = DragDropEffects.Copy


    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: lstPreppedDish_DragDrop           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 3-25-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- When the dragged object is finally dropped it adds the dragged
    '- item to the dictionary if it doesn't already exist
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTempstring
    '- dicTempdic                                               -
    '------------------------------------------------------------
    Private Sub lstPreppedDish_DragDrop(sender As Object, e As DragEventArgs) Handles lstPreppedDish.DragDrop


        Dim strTempstring As String = lstDishes.SelectedItem
        Dim dicTempdic As Dictionary(Of String, Dictionary(Of String, Integer))
        dicTempdic = dicDictionary.Item(strTempstring)
        If Not dicTempdic.ContainsKey(e.Data.GetData("Text")) Then
            dicTempdic.Add(lstPreppedItems.SelectedItem, New Dictionary(Of String, Integer))
            lstPreppedDish.Items.Clear()
            For Each strKey In dicTempdic.Keys
                lstPreppedDish.Items.Add(strKey)
            Next
        Else
            MsgBox("Error, this item is already on the menu", , "Error")
        End If
    End Sub
    ' ------------------------------------------------------------
    '-                Subprogram Name: lstPreppedDish_MouseMove           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On:  3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Event is raised when mouse moves ont the listbox, allows you
    '- to drag the form
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- DropEFfect                                                -
    '------------------------------------------------------------

    Private Sub lstPreppedDish_MouseMove(sender As Object, e As MouseEventArgs) Handles lstPreppedDish.MouseMove
        Dim dropEffect As DragDropEffects
        If e.Button = Windows.Forms.MouseButtons.Left And Not lstPreppedDish.SelectedIndex = -1 Then
            Me.AllowDrop = True
            lstAllRaw.AllowDrop = False
            lstRaw.AllowDrop = False
            lstPreppedItems.AllowDrop = False
            'If the left mouse button is down, pr
            'If the left mouse button is down, proceed with the 
            'drag-and-drop, passing in the list item.                     
            dropEffect = lstPreppedDish.DoDragDrop(lstPreppedDish.Items(lstPreppedDish.SelectedIndex),
                                            DragDropEffects.All)
            blnRemovePrep = True

        End If
    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: frmMain_DragEnter            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On:  3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Enables DragDropEffect based on boolean flags when you drag into
    '- the main form
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub frmMain_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If blnRemovePrep = True Then
            e.Effect = DragDropEffects.All
        ElseIf blnRemoveRaw = True Then
            e.Effect = DragDropEffects.All
        End If

    End Sub
    ' ------------------------------------------------------------
    '-                Subprogram Name:  frmMain_DragDrop          -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On:  3-25-2014     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- based on boolean flags, either removes an item from raw items
    '- dictionary or prepitems dictionary
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTempstring
    '- dicTempdic                                                   -
    '------------------------------------------------------------

    Private Sub frmMain_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If blnRemovePrep = True Then
            Dim strTempstring As String = lstDishes.SelectedItem
            Dim dicTempdic As Dictionary(Of String, Dictionary(Of String, Integer))
            dicTempdic = dicDictionary.Item(strTempstring)
            dicTempdic.Remove(e.Data.GetData("Text"))
            lstPreppedDish.Items.Clear()
            For Each strKey In dicTempdic.Keys
                lstPreppedDish.Items.Add(strKey)
            Next
            blnRemovePrep = False

            lstRaw.Items.Clear()

        End If

        If blnRemoveRaw = True Then
            If Not lstPreppedDish.SelectedItem = Nothing Then
                Dim strTemporary As String = lstDishes.SelectedItem
                Dim dicTempDic As Dictionary(Of String, Dictionary(Of String, Integer))
                dicTempDic = dicDictionary.Item(strTemporary)

                Dim strTemporary2 As String = lstPreppedDish.SelectedItem
                Dim dicTempDic2 As Dictionary(Of String, Integer)
                dicTempDic2 = dicTempDic.Item(strTemporary2)

                dicTempDic2.Remove(e.Data.GetData("Text"))
                lstRaw.Items.Clear()
                For Each strKey In dicTempDic2.Keys
                    lstRaw.Items.Add(strKey)
                Next
            End If
        End If


    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: stAllRaw_MouseMove          -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '- Allows you to drag and drop on the lstAllRow
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstAllRaw_MouseMove(sender As Object, e As MouseEventArgs) Handles lstAllRaw.MouseMove
        Dim dropEffect As DragDropEffects

        If e.Button = Windows.Forms.MouseButtons.Left Then
            lstPreppedDish.AllowDrop = False
            lstRaw.AllowDrop = True
            Me.AllowDrop = False
            'If the left mouse button is down, proceed with the 
            'drag-and-drop, passing in the list item.                     
            dropEffect = lstPreppedItems.DoDragDrop(lstAllRaw.Items(lstAllRaw.SelectedIndex),
                                            DragDropEffects.Copy Or DragDropEffects.None)
        End If


    End Sub
    ' ------------------------------------------------------------
    '-                Subprogram Name: lstRaw_DragEnter           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- enable the ability to Copy when a dragged object enters lstRaw     
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstRaw_DragEnter(sender As Object, e As DragEventArgs) Handles lstRaw.DragEnter
            e.Effect = DragDropEffects.Copy
    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: lstRaw_DragDrop           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On:  3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Adds the dragged item to lstRaw's dictionary 
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strTemporary
    '- strTemporary2
    '- dicTempDic
    '- dicTempDic2                         
    '------------------------------------------------------------
    Private Sub lstRaw_DragDrop(sender As Object, e As DragEventArgs) Handles lstRaw.DragDrop
        If Not lstPreppedDish.SelectedItem = Nothing Then
            Dim strTemporary As String = lstDishes.SelectedItem
            Dim dicTempDic As Dictionary(Of String, Dictionary(Of String, Integer))
            dicTempDic = dicDictionary.Item(strTemporary)

            Dim strTemporary2 As String = lstPreppedDish.SelectedItem
            Dim dicTempDic2 As Dictionary(Of String, Integer)
            dicTempDic2 = dicTempDic.Item(strTemporary2)

            If Not dicTempDic2.ContainsKey(e.Data.GetData("Text")) Then
                dicTempDic2.Add(lstAllRaw.Text, New Integer)
                lstRaw.Items.Clear()
                For Each strKey In dicTempDic2.Keys
                    lstRaw.Items.Add(strKey)
                Next
            Else
                MsgBox("Error, this item is already on the menu", , "Error")
            End If
        End If

    End Sub

    ' ------------------------------------------------------------
    '-                Subprogram Name: lstRaw_MouseMove            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                   -
    '-                Written On: 3-25-2014      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- enables drag and drop on lstRaw    
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- dropeffect                                                -
    '------------------------------------------------------------
    Private Sub lstRaw_MouseMove(sender As Object, e As MouseEventArgs) Handles lstRaw.MouseMove
        Dim dropEffect As DragDropEffects
        If e.Button = Windows.Forms.MouseButtons.Left And Not lstRaw.SelectedIndex = -1 Then
            Me.AllowDrop = True
            lstAllRaw.AllowDrop = False
            lstPreppedDish.AllowDrop = False
            lstPreppedItems.AllowDrop = False
            'If the left mouse button is down, proceed with the 
            'drag-and-drop, passing in the list item.                     
            dropEffect = lstRaw.DoDragDrop(lstRaw.Items(lstRaw.SelectedIndex),
                                            DragDropEffects.All)
            blnRemoveRaw = True

        End If
    End Sub
End Class
