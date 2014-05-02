Imports System.Data.SqlClient
Public Class frmAddOrder
    Private myCon As New SqlConnection

    Private MyRowPosition As Integer = 0
    Private MyDatAdp As New SqlDataAdapter
    Private MyCmd As New SqlCommand
    Private MyDataTbl As New DataTable
    Private Sub AddOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            myCon.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2010\Projects\OrderProg\db\Main.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            myCon.Open()
        Catch ex As Exception
            MessageBox.Show("Error", ex.ToString(), MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmOrders.Show()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim intCustID As Integer
        Dim dblTotal As Double
        Dim dtDate As Date
        Dim intOrderID As Integer
        Dim intQty As Integer
        Dim dblPrice As Integer
        Dim intProdId As Integer
        If Not IsNumeric(txtCustomerID.Text) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCustomerID.Clear()
            txtCustomerID.Focus()
            Exit Sub
        Else
            intCustID = CInt(txtCustomerID.Text)
        End If
        If Not IsNumeric(txtProdID.Text) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProdID.Clear()
            txtProdID.Focus()
            Exit Sub
        Else
            intProdId = CInt(txtProdID.Text)
        End If
        If Not IsNumeric(txtOrderID.Text) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOrderID.Clear()
            txtOrderID.Focus()
            Exit Sub
        Else
            intOrderID = CInt(txtOrderID.Text)
        End If
        If Not IsNumeric(txtTotal.Text) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotal.Clear()
            txtTotal.Focus()
            Exit Sub
        Else
            dblTotal = CDbl(txtTotal.Text)
        End If
        If Not IsNumeric(txtQty.Text) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQty.Clear()
            txtQty.Focus()
            Exit Sub
        Else
            intQty = CInt(txtQty.Text)
        End If
        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Clear()
            txtPrice.Focus()
            Exit Sub
        Else
            dblPrice = CDbl(txtOrderID.Text)
        End If
        If Not IsDate(DtPicker.Value) Then
            MessageBox.Show("Please ensure all information is entered and accurate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DtPicker.ResetText()
            DtPicker.Focus()
            Exit Sub
        Else
            dtDate = CDate(DtPicker.Value)
        End If
        Dim query As String = String.Empty
        query &= "INSERT INTO Orders (ID, CustomerID, Total, Date)"
        query &= "VALUES (@orderID, @custID, @total, @date);"
        query &= "INSERT INTO OrderProd(ID, CustomerID,ProductID, Quantity, Price, OrderID)"
        query &= "VALUES (@orderID, @custID, @prodID, @Quantity, @price, @orderID)"

        Using myCon
            Using comm As New SqlCommand()
                With comm
                    .Connection = myCon
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@orderID", intOrderID)
                    .Parameters.AddWithValue("@custID", intCustID)
                    .Parameters.AddWithValue("@total", dblTotal)
                    .Parameters.AddWithValue("@date", dtDate)
                    .Parameters.AddWithValue("@prodID", intProdId)
                    .Parameters.AddWithValue("@Quantity", intQty)
                    .Parameters.AddWithValue("@price", dblPrice)
                End With
                Try
                    comm.ExecuteNonQuery()
                    MessageBox.Show("Added sucessfully!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCustomerID.Clear()
                    txtOrderID.Clear()
                    txtPrice.Clear()
                    txtProdID.Clear()
                    txtQty.Clear()
                    txtTotal.Clear()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnClr_Click(sender As System.Object, e As System.EventArgs) Handles btnClr.Click

        txtCustomerID.Clear()
        txtOrderID.Clear()
        txtPrice.Clear()
        txtProdID.Clear()
        txtQty.Clear()
        txtTotal.Clear()
        txtOrderID.Focus()
    End Sub
End Class