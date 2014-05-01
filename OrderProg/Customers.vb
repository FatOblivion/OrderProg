Imports System.Data.SqlClient
Public Class frmCustomers
    Private myCon As New SqlConnection

    Private MyRowPosition As Integer = 0
    Private MyDatAdp As New SqlDataAdapter
    Private MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Private Sub frmCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            myCon.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2010\Projects\OrderProg\db\Main.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            myCon.Open()
        Catch ex As Exception
            MessageBox.Show("Error", ex.ToString(), MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
        frmMain.Show()
    End Sub
    Private Sub showRecords()

        If MyDataTbl.Rows.Count = 0 Then
            lst1.Items.Clear()
            MessageBox.Show("Sorry, it seems that no records matched those paramaters", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If

        lst1.Items.Add("ID:" + vbTab + MyDataTbl.Rows(MyRowPosition)("ID").ToString)
        lst1.Items.Add(vbNewLine + "First Name:" + vbTab + MyDataTbl.Rows(MyRowPosition)("First Name"))
        lst1.Items.Add(vbNewLine + "Surname:" + vbTab + MyDataTbl.Rows(MyRowPosition)("Surname"))
        lst1.Items.Add(vbNewLine + "Contact Details:" + vbTab + MyDataTbl.Rows(MyRowPosition)("Contact"))
        lst1.Items.Add(vbCrLf + "Date of birth:" + vbTab + MyDataTbl.Rows(MyRowPosition)("D.O.B").ToString())



    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lst1.Items.Clear()

    End Sub

    Private Sub btnSrch_Click(sender As System.Object, e As System.EventArgs) Handles btnSrch.Click
        'Declaring variables
        Dim input As String
        Dim custID As Integer

        'collecting ID
        input = InputBox("Please enter order ID", "Enter ID")
        'Ensuring that the data is ready to convert to int, checking data type
        If Not IsNumeric(input) Then
            MessageBox.Show("That can't be right, please re-enter the information", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            custID = CInt(input)
        End If
        'Declaring adapter command and build
        MyDatAdp = New SqlDataAdapter("SELECT * FROM Customers WHERE ID=" & custID, myCon)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)
        'Declaring additional variables req.
        Dim MyDataRow As DataRow = MyDataTbl.Rows(0)
        Dim intID As Integer
        Dim strFirstName As String
        Dim strSurname As String
        Dim strContact As String
        Dim dtDOB As Date


        'Defining the datarow params

        intID = MyDataRow("ID")
        strFirstName = MyDataRow("First Name")
        strSurname = MyDataRow("Surname")
        strContact = MyDataRow("Contact")
        dtDOB = MyDataRow("D.O.B")


        'Converting all called data to string
        intID.ToString()
        strFirstName.ToString()
        strSurname.ToString()
        strContact.ToString()
        dtDOB.ToString()



        'Calling procedure to display records
        Me.showRecords()



    End Sub
End Class