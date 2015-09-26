'------------------------------------------------------------
'-                File Name : Form1.frm                     - 
'-                Part of Project: Assign8                 -
'------------------------------------------------------------
'-                Written By: Cameron Tait                  -
'-                Written On: 4-1-2014                      -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file is responsible for altering the database based on
'- what the user does with the GUI                           - 
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- Program creates a database for users to interact with and save data on
'- that starts with a set of default values everytime        -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- dsCustomer - Dataset that holds values of customer table
'- dsItems - Dataset that holds values of itemsordered table
'- strConn - stores the provider and stored location of database
'- myConn - is the the actual connection to the database
'- DBAdaptCustomer - adapter for Customer table
'- DBAdapt items - adapter for Items table
'- intTUIDCounter - keeps track of the latest TUID number
'- blnUpdateFlag - keeps track of when the database is preparing to update
'- blnAddFlag - keeps track of when db is adding a new tuple
'------------------------------------------------------------


Imports System.Data.OleDb




Public Class frmMain
    Dim dsCustomer As New DataSet()
    Dim dsItems As New DataSet()
    Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=new.mdb"
    Dim myConn As New OleDbConnection(strConn)
    Dim DBAdaptCustomer As OleDbDataAdapter
    Dim DBAdaptItems As OleDbDataAdapter
    Dim intTUIDCounter As Integer = 0
    Dim blnUpdateFlag As Boolean = False
    Dim blnAddFlag As Boolean = False




    '------------------------------------------------------------
    '-                Subprogram Name: frmMain_Load        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- When the form loads it creates databindings for the textboxes
    '- in order to navigate through them via gui controls                           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-strSQLCmd - contains the SQL commands to be sent to the database                                            -
    '------------------------------------------------------------



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSQLCmd As String




        strSQLCmd = "SELECT * FROM Customers"
        DBAdaptCustomer = New OleDbDataAdapter(strSQLCmd, strConn)
        DBAdaptCustomer.Fill(dsCustomer, "Customers")



        txtID.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.TUID"))
        txtFirstName.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.FirstName"))
        txtLastName.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.LastName"))
        txtStreet.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.StreetAddress"))
        txtCity.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.City"))
        txtState.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.State"))
        txtZip.DataBindings.Add(New Binding("Text", dsCustomer, "Customers.Zipcode"))

        updateGridView()




    End Sub


    '------------------------------------------------------------
    '-                Subprogram Name: btnFirst_Click        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Cycles to the first record and updates data grid view                           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click

        BindingContext(dsCustomer, "Customers").Position = 0
        updateGridView()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnPrevious_Click        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Cycles to the previous record and updates data grid view                           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BindingContext(dsCustomer, "Customers").Position = (BindingContext(dsCustomer, "Customers").Position - 1)
        updateGridView()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name:btnNext_Click       -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Cycles to the next record and updates data grid view                           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingContext(dsCustomer, "Customers").Position = (BindingContext(dsCustomer, "Customers").Position + 1)
        updateGridView()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnLast_Click         -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Cycles to the last record and updates data grid view                           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BindingContext(dsCustomer, "Customers").Position =
(dsCustomer.Tables("Customers").Rows.Count - 1)
        updateGridView()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: updateGridView        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '- Clears the dataset which clears the gridview, and then updates
    '- the grid view based on what the Customer ID is                         
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-strSQLCMD - stores SQL command into string for use later                        -
    '------------------------------------------------------------
    Private Sub updateGridView()

        Dim strSQLCMD As String
        dsItems.Tables.Clear()
        strSQLCMD = "SELECT CustomerID, ItemName, ItemNumber, ItemPrice, Quantity, ItemPrice * Quantity AS Total FROM OrderedItems WHERE OrderedItems.CustomerID = " & txtID.Text
        DBAdaptItems = New OleDbDataAdapter(strSQLCMD, strConn)
        DBAdaptItems.Fill(dsItems, "OrderedItems")
        dgvMain.DataSource = dsItems.Tables("OrderedItems")
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnAdd_Click          -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- allows the user to add a new record by enabling text 
    '- boxes and clearing them, also clears grid view           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        blnAddFlag = True
        blnUpdateFlag = False
        txtCity.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtState.Enabled = True
        txtStreet.Enabled = True
        txtZip.Enabled = True




        txtCity.Text = ""
        txtFirstName.Text = ""
        txtID.Text = ""
        txtLastName.Text = ""
        txtState.Text = ""
        txtStreet.Text = ""
        txtZip.Text = ""

        btnAdd.Visible = False
        btnDelete.Visible = False
        btnFirst.Visible = False
        btnLast.Visible = False
        btnNext.Visible = False
        btnPrevious.Visible = False
        btnUpdate.Visible = False
        btnSave.Visible = True
        btnCancel.Visible = True

        clearGridView()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: clearGridView        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Clears the data grid view by clearing the dataset it is bound to                          –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------
    Private Sub clearGridView()
        dsItems.Tables.Clear()
        dgvMain.DataSource = dsItems.Tables("OrderedItems")
    End Sub


    '------------------------------------------------------------
    '-                Subprogram Name: btnCancel_Click        -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- renables select buttons and disables text boxes to enable navigation
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-strSQLCmd - stores sql command for use later                                    -
    '------------------------------------------------------------

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnUpdateFlag = False
        blnAddFlag = False

        Dim strSQLCmd As String

        txtCity.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtState.Enabled = False
        txtStreet.Enabled = False
        txtZip.Enabled = False


        btnAdd.Visible = True
        btnDelete.Visible = True
        btnFirst.Visible = True
        btnLast.Visible = True
        btnNext.Visible = True
        btnPrevious.Visible = True
        btnUpdate.Visible = True
        btnSave.Visible = False
        btnCancel.Visible = False

        dsCustomer.Clear()
        strSQLCmd = "SELECT * FROM Customers"
        DBAdaptCustomer = New OleDbDataAdapter(strSQLCmd, strConn)
        DBAdaptCustomer.Fill(dsCustomer, "Customers")

        BindingContext(dsCustomer, "Customers").Position = 0
        updateGridView()


    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnSave_Click         -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Saves or Updates database based on a boolean flag        -
    '- and the TUID of the new/selected object
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If blnAddFlag = True Then

            If txtCity.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtState.Text = "" Or txtStreet.Text = "" Or txtZip.Text = "" Then
                MessageBox.Show("You must fill in empty fields before proceeding")
            ElseIf IsNumeric(txtZip.Text) = False Then
                MessageBox.Show("Zipcode must have numbers only")
            Else

                Dim strSqlCmd = "Select * FROM Customers"
                Dim DBCmd As OleDbCommand = New OleDbCommand()
                myConn = New OleDbConnection(strConn)
                myConn.Open()
                Dim intNewTUID As Integer = dsCustomer.Tables("Customers").Rows.Count + 1 + intTUIDCounter

                DBCmd.CommandText = "INSERT INTO Customers (TUID, FirstName, LastName, StreetAddress, City, State, Zipcode) VALUES('" & _
             intNewTUID & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtStreet.Text & "','" & txtCity.Text & "','" & txtState.Text & "','" & txtZip.Text & "')"

                DBCmd.Connection = myConn
                DBCmd.ExecuteNonQuery()

                myConn.Close()

                dsCustomer.Clear()
                DBAdaptCustomer = New OleDbDataAdapter(strSqlCmd, strConn)
                DBAdaptCustomer.Fill(dsCustomer, "Customers")

                BindingContext(dsCustomer, "Customers").Position = 0
                updateGridView()



                txtCity.Enabled = False
                txtFirstName.Enabled = False
                txtLastName.Enabled = False
                txtState.Enabled = False
                txtStreet.Enabled = False
                txtZip.Enabled = False


                btnAdd.Visible = True
                btnDelete.Visible = True
                btnFirst.Visible = True
                btnLast.Visible = True
                btnNext.Visible = True
                btnPrevious.Visible = True
                btnUpdate.Visible = True
                btnSave.Visible = False
                btnCancel.Visible = False
            End If
        End If

        If blnUpdateFlag = True Then

            If txtCity.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtState.Text = "" Or txtStreet.Text = "" Or txtZip.Text = "" Then
                MessageBox.Show("You must fill in empty fields before proceeding")
            ElseIf IsNumeric(txtZip.Text) = False Then
                MessageBox.Show("Zipcode must have numbers only")
            Else

                Dim strSqlCmd = "Select * FROM Customers"
                Dim DBCmd As OleDbCommand = New OleDbCommand()
                myConn = New OleDbConnection(strConn)
                myConn.Open()

                DBCmd.CommandText = "Update Customers Set FirstName = '" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', StreetAddress = '" & txtStreet.Text & "',  City = '" & txtCity.Text & "', State = '" & txtState.Text & "', Zipcode = " & txtZip.Text & " Where TUID = " & txtID.Text



                DBCmd.Connection = myConn
                DBCmd.ExecuteNonQuery()

                myConn.Close()

                dsCustomer.Clear()
                DBAdaptCustomer = New OleDbDataAdapter(strSqlCmd, strConn)
                DBAdaptCustomer.Fill(dsCustomer, "Customers")

                BindingContext(dsCustomer, "Customers").Position = 0
                updateGridView()



                txtCity.Enabled = False
                txtFirstName.Enabled = False
                txtLastName.Enabled = False
                txtState.Enabled = False
                txtStreet.Enabled = False
                txtZip.Enabled = False


                btnAdd.Visible = True
                btnDelete.Visible = True
                btnFirst.Visible = True
                btnLast.Visible = True
                btnNext.Visible = True
                btnPrevious.Visible = True
                btnUpdate.Visible = True
                btnSave.Visible = False
                btnCancel.Visible = False
            End If
        End If


    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnDelete_Click          -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Deletes selected record after confirmation from user                           –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strSqlCMD - stores sql command                           -
    '------------------------------------------------------------

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim strSqlCmd = "Select * FROM Customers"
            Dim DBCmd As OleDbCommand = New OleDbCommand()
            myConn = New OleDbConnection(strConn)
            myConn.Open()

            DBCmd.CommandText = "DELETE FROM Customers WHERE TUID =" & txtID.Text
            DBCmd.Connection = myConn
            DBCmd.ExecuteNonQuery()

            myConn.Close()

            dsCustomer.Clear()
            strSqlCmd = "SELECT * FROM Customers"
            DBAdaptCustomer = New OleDbDataAdapter(strSqlCmd, strConn)
            DBAdaptCustomer.Fill(dsCustomer, "Customers")

            BindingContext(dsCustomer, "Customers").Position = 0
            updateGridView()
            intTUIDCounter += 1

        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnUpdate_Click      -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- prepares the gui to update a record                          –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-none                                       -
    '------------------------------------------------------------

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        blnAddFlag = False
        blnUpdateFlag = True

        txtCity.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtState.Enabled = True
        txtStreet.Enabled = True
        txtZip.Enabled = True


        btnAdd.Visible = False
        btnDelete.Visible = False
        btnFirst.Visible = False
        btnLast.Visible = False
        btnNext.Visible = False
        btnPrevious.Visible = False
        btnUpdate.Visible = False
        btnSave.Visible = True
        btnCancel.Visible = True
        clearGridView()
    End Sub
End Class