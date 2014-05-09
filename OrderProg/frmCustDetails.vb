Imports OrderProg.frmAddOrder
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmCustDetails
    Private custID As Integer
    ''' <summary>
    ''' Gets or sets the custID or else sends -1(false) no existing cust
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SelectedCustID As Integer
        Get
            Return custID
        End Get
        Set(value As Integer)
            LoadCustomer(value)
            custID = value
        End Set
    End Property
    Private Sub LoadCustomer(ByVal custID As Integer)
        Me.CustomersTableAdapter.FillBy(Me.MainDataSet3.Customers, custID)


    End Sub
    Private Sub frmCustDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataSet3.Customers' table. You can move, or remove it, as needed.
        LoadCustomer(SelectedCustID)
       

    End Sub

    

  
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmAddOrder.Show()
    End Sub

    

    
End Class