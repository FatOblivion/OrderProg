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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
        Dim input As String
        Dim orderID As Integer
        input = InputBox("Please enter customer ID", "Enter ID")
        If Not IsNumeric(input) Then

            MessageBox.Show("That can't be right, please re-enter the information", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            orderID = CInt(input)
        End If
       
    End Sub
End Class