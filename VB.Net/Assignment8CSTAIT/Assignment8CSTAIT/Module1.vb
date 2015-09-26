Imports System.Data.OleDb
Imports System.IO

'------------------------------------------------------------
'-                File Name : Module.vb                     - 
'-                Part of Project: Assign8                  -
'------------------------------------------------------------
'-                Written By: Cameron Tait                     -
'-                Written On: 4-1-2014         -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file orchestrates the creation of a database file and maintaining
'- it's original form                            - 
'------------------------------------------------------------

Module Module1

    '------------------------------------------------------------
    '-                Subprogram Name: Main          -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Creates, deletes, and populates two new tables                            –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-  strConn - stores provider and storage location of DB
    '- strDBName the actual name of the db
    '- frmMain - the form to be produced one the module is about to end                                            -
    '------------------------------------------------------------

    Sub main()

        Dim strConn As String   'used to tell type of database & path
        Dim strDBName As String = "new.mdb" 'path of database
        Dim frmMain As New frmMain() 'the main form

        'Pointer to the database we will use
        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName

        'If the database doesn't exist, create it
        If Not (File.Exists(strDBName)) Then
            CreateDatabase(strConn)
        End If

        'Make sure all tables are clean each time we run this
        CleanOutCustomersTable(strConn)
        CleanOutItemsTable(strConn)

        'Put some data into the tables
        PopulateCustomersTable(strConn)
        PopulateItemsTable(strConn)


        frmMain.ShowDialog()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: CreateDatabase            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Creates database schema for the databases
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- DBCAT - a catalog according to ADOX standards
    '-DBConn - connection to database
    '-DBCmd - SQL command to relay to database                  -
    '------------------------------------------------------------

    Sub CreateDatabase(ByVal strConn As String)

        'Let's build an Access database
        Dim DBCat As New ADOX.Catalog()
        Dim DBConn As OleDbConnection
        Dim DBCmd As OleDbCommand = New OleDbCommand()

        Try
            DBCat.Create(strConn)
            MessageBox.Show("Created database")
        Catch Ex As Exception
            MessageBox.Show("Database already exists")
        End Try


        'Build the Tables
        DBConn = New OleDbConnection(strConn)
        DBConn.Open()

        'Build the Student Table
        DBCmd.CommandText = "CREATE TABLE Customers (" & _
                             "TUID int, " & _
                             "FirstName varchar(50), " & _
                             "LastName varchar(50), " & _
                             "StreetAddress varchar(50), " & _
                             "City varchar(50), " & _
                             "State varchar(50), " & _
                             "ZipCode varchar(50), " & _
                             "PRIMARY KEY (TUID))"


 

        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()

        'Build the Courses Table
        DBCmd.CommandText = "CREATE TABLE OrderedItems (" & _
                                     "TUID int, " & _
                                     "CustomerID int, " & _
                                     "ItemNumber varchar(50), " & _
                                     "ItemName varchar(50), " & _
                                     "Quantity int, " & _
                                     "ItemPrice int, " & _
                                     "PRIMARY KEY (TUID))"



        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()



        DBConn.Close()
    End Sub


    '------------------------------------------------------------
    '-                Subprogram Name: CleanOutCustomersTable            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Wipes all prexisiting tuples from customer table
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-DBConn - connection to database
    '-DBCmd - SQL command to relay to database                  -
    '------------------------------------------------------------


    Sub CleanOutCustomersTable(ByVal strConn As String)
        Dim DBConn As OleDbConnection
        Dim DBCmd As OleDbCommand = New OleDbCommand()

        'Now try to open up a connection to the database
        DBConn = New OleDbConnection(strConn)
        DBConn.Open()

        'Use SQL to zap the contents of the table
        DBCmd.CommandText = "DELETE * FROM Customers"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()


        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: CleanOutItemsTable           -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Wipes all prexisiting tuples from items table
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-DBConn - connection to database
    '-DBCmd - SQL command to relay to database                  -
    '------------------------------------------------------------


    Sub CleanOutItemsTable(ByVal strConn As String)
        Dim DBConn As OleDbConnection
        Dim DBCmd As OleDbCommand = New OleDbCommand()

        'Now try to open up a connection to the database
        DBConn = New OleDbConnection(strConn)
        DBConn.Open()

        'Use SQL to zap the contents of the table
        DBCmd.CommandText = "DELETE * FROM OrderedItems"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()


        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: PopulateCustomersTable            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Wipes all prexisiting tuples from customer table
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-DBConn - connection to database
    '-DBCmd - SQL command to relay to database                  -
    '------------------------------------------------------------


    Sub PopulateCustomersTable(ByVal strConn As String)
        Dim DBConn As OleDbConnection
        Dim DBCmd As OleDbCommand = New OleDbCommand()

        'Now try to open up a connection to the database
        DBConn = New OleDbConnection(strConn)
        DBConn.Open()

        'Add a student using SQL
        DBCmd.CommandText = "INSERT INTO Customers (TUID, FirstName, LastName, StreetAddress, City, State, Zipcode) " & _
           "VALUES ('1','Cameron','Tait', '2411 Vickory Road', 'Caro', 'MI', '48723')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()

        DBCmd.CommandText = "INSERT INTO Customers (TUID, FirstName, LastName, StreetAddress, City, State, Zipcode) " & _
   "VALUES ('2','Hello','World', 'ExceptionStreet', 'Silicon Valley', 'CA', '01234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()


        DBConn.Close()

    End Sub


    '------------------------------------------------------------
    '-                Subprogram Name: PopulateItemsTable            -
    '------------------------------------------------------------
    '-                Written By: Cameron Tait                  -
    '-                Written On: 4-1-2014                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Populates Item Table with new tuples
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '-DBConn - connection to database
    '-DBCmd - SQL command to relay to database                  -
    '------------------------------------------------------------

    Sub PopulateItemsTable(ByVal strConn As String)
        Dim DBConn As OleDbConnection
        Dim DBCmd As OleDbCommand = New OleDbCommand()

        'Now try to open up a connection to the database
        DBConn = New OleDbConnection(strConn)
        DBConn.Open()

        'Add courses using SQL
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
            "VALUES ('1', '1', '8033', 'Warcraft 3: Frozen Throne', '1', '20.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('2', '1', '9001', 'Dota 2', '12', '0.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('3', '1', '05121989', 'Pembroke Welsh Corgi', '1', '500.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('4', '1', '345', 'C++: The Superior Language', '3', '80.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('5', '1', '868', 'Ever Run out of Ideas?', '1', '1000.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('6', '2', '55', 'Yay New Customer', '1', '50.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('7', '2', '55', 'Need brain food', '5', '200.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('8', '2', '55', 'Have fun grading these', '1', '0.00')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO OrderedItems (TUID, CustomerID, ItemNumber, ItemName, Quantity, ItemPrice) " & _
       "VALUES ('9', '2', '55', 'Last One', '1', '1.00')"


        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()



        DBConn.Close()

    End Sub




End Module
