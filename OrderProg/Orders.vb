Imports System.Data.SqlClient
Public Class frmOrders
    'declaring private variables 
    Private blnval1 As Boolean
    Private strInp As String

    Private myCon As New SqlConnection

    Private MyRowPosition As Integer = 0
    Private MyDatAdp As New SqlDataAdapter
    Private MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Private Sub frmOrders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            myCon.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2010\Projects\OrderProg\db\Main.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            myCon.Open()
        Catch ex As Exception
            MessageBox.Show("Error", ex.ToString(), MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub showRecords()

        If MyDataTbl.Rows.Count = 0 Then
            txtOrderID.Clear()
            txtQty.Clear()
            txtCustID.Clear()
            txtTotal.Clear()
            txtDate.Clear()
            Exit Sub
        End If

        txtOrderID.Text = MyDataTbl.Rows(MyRowPosition)("ID").ToString
        txtQty.Text = MyDataTbl.Rows(MyRowPosition)("Quantity").ToString
        txtCustID.Text = MyDataTbl.Rows(MyRowPosition)("CustomerID").ToString
        txtTotal.Text = MyDataTbl.Rows(MyRowPosition)("Total").ToString
        txtDate.Text = MyDataTbl.Rows(MyRowPosition)("Date").ToString
             

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
        'Declaring variables
        Dim input As String
        Dim orderID As Integer
        
        'collecting ID
        input = InputBox("Please enter customer ID", "Enter ID")
        'Ensuring that the data is ready to convert to int, checking data type
        If Not IsNumeric(input) Then
            MessageBox.Show("That can't be right, please re-enter the information", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            orderID = CInt(input)
        End If
        'Declaring adapter command and build
        MyDatAdp = New SqlDataAdapter("SELECT * FROM Orders WHERE ID=" & orderID, myCon)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)
        'Declaring additional variables req.
        Dim MyDataRow As DataRow = MyDataTbl.Rows(0)
        Dim intID As Integer
        Dim intQty As Integer
        Dim intCustomerID As Integer
        Dim dblTotal As Double
        Dim dtDate As Date
        'Defining the datarow params
        
        intID = MyDataRow("ID")
        intQty = MyDataRow("Quantity")
        intCustomerID = MyDataRow("CustomerID")
        dblTotal = MyDataRow("Total")
        dtDate = MyDataRow("Date")
        'Converting all called data to string
        intID.ToString()
        intQty.ToString()
        intCustomerID.ToString()
        dblTotal.ToString()
        dtDate.ToString()
        txtOrderID.Text = intID.ToString()
        'Calling procedure to display records
        Me.showRecords()




    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class