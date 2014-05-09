Imports System.Data.SqlClient
Public Class frmProducts

    Private Sub frmProducts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.MainDataSet.Products)

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
        Me.MainDataSet.RejectChanges()
    End Sub

    

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        frmAddOrder.Show()
        Me.Close()
    End Sub
End Class