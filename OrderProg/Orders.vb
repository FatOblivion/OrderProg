Imports System.Data.SqlClient

Public Class frmOrders

    

    Private Sub frmOrders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataSet1.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.MainDataSet1.Orders)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

     
        ' Me.Close()
        Dim orderFrm As frmAddOrder = New frmAddOrder()
        orderFrm.CurrentOrderId = CInt(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
        orderFrm.Show()

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Me.Hide()
        frmAddOrder.Show()

    End Sub

End Class