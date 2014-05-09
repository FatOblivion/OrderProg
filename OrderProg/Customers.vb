Imports System.Data.SqlClient
Public Class frmCustomers
    Private Sub frmCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataSet4.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.MainDataSet4.Customers)
        'TODO: This line of code loads data into the 'MainDataSet4.Customers' table. You can move, or remove it, as needed.


    End Sub


  



    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class