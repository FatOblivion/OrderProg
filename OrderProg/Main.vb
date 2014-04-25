Imports System.Data.SqlClient

Public Class frmMain
    Private MyDatAdp As New SqlDataAdapter
    Private MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Private myCon As New SqlConnection

       

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            myCon.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2010\Projects\OrderProg\db\Main.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            myCon.Open()
        Catch ex As Exception
            MessageBox.Show("Error", ex.ToString(), MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomers.Click
        Me.Hide()
        frmCustomers.Show()
    End Sub

    Private Sub btnOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnOrder.Click
        Me.Hide()
        frmOrders.Show()
    End Sub

    Private Sub btnProd_Click(sender As System.Object, e As System.EventArgs) Handles btnProd.Click
        Me.Hide()
        frmProducts.Show()
    End Sub
End Class
