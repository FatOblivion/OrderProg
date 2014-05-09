Imports System.Data.SqlClient

Public Class frmMain
  

       

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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
