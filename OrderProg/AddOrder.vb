Imports System.Data.SqlClient

Imports OrderProg.frmOrders

''' <summary>
''' Allows the creation or editing of Orders and their line items.
''' </summary>
''' <remarks></remarks>
Public Class frmAddOrder : Inherits Form

    
    Private Sub AddOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private orderId As Integer
    ''' <summary>
    ''' Gets or sets the current order being edited. Set the current order id to -1 to specify a new order.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CurrentOrderId As Integer
        Get
            Return orderId
        End Get
        Set(value As Integer)
            LoadOrder(value)
            orderId = value
        End Set
    End Property
    
    ''' <summary>
    ''' Loads the order data by the given orderId
    ''' </summary>
    ''' <param name="orderId"></param>
    ''' <remarks></remarks>
    Private Sub LoadOrder(ByVal orderId As Integer)

        Me.OrdersTableAdapter.FillBy(Me.MainDataSet1.Orders, orderId)
        Me.OrderProdTableAdapter.Fill(Me.MainDataSet2.OrderProd, orderId)

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub btnClr_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub btnViewCust_Click(sender As System.Object, e As System.EventArgs) Handles btnViewCust.Click
        Dim customerDetailsFrm As frmCustDetails = New frmCustDetails()
        customerDetailsFrm.SelectedCustID = CInt(txtCustID.Text)
        customerDetailsFrm.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim blnval1 As Boolean
        Dim result As DialogResult
        
        result = MessageBox.Show("Are you sure?", "Really?", MessageBoxButtons.YesNo)
        If result = System.Windows.Forms.DialogResult.Yes Then
            blnval1 = True
        ElseIf result = System.Windows.Forms.DialogResult.No Then
            blnval1 = False
        End If
        If blnval1 = True Then
            Me.OrderProdTableAdapter.Update(Me.MainDataSet2)
            Me.OrdersTableAdapter.Update(Me.MainDataSet1)
            Me.Close()
            frmOrders.Refresh()
            frmOrders.Show()
        ElseIf blnval1 = False Then
            Me.MainDataSet2.RejectChanges()
            Me.MainDataSet1.RejectChanges()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        Me.MainDataSet2.RejectChanges()
        Me.MainDataSet1.RejectChanges()
        Me.Close()
        frmOrders.Refresh()
        frmOrders.Show()
    End Sub

    Private Sub btnProd_Click(sender As System.Object, e As System.EventArgs) Handles btnProd.Click
        frmProducts.Show()
    End Sub
End Class