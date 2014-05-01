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
        Dim str1 As String

        str1 = "begin tran; "
        str1 &= "INSERT INTO Orders VALUES(" & intOrderID & ", " & intCustID & ", " & dblTotal & ", '" & dtDate & "' ); "
        str1 &= "INSERT INTO OrderProd (" & intOrderID & ", " & intCustID & ", " & intProdId & ", " & intQty & ", " & dblPrice & ", " & intOrderID & "); "
        str1 &= "commit tran; "


        mycmd = New SqlCommand
        MyCmd.Connection = myCon
        MyCmd.CommandType = CommandType.Text
        MyCmd.CommandText = str1
        Try
            MyCmd.ExecuteNonQuery()
            MessageBox.Show("Successfully added!")
        Catch ex As SqlException
            MessageBox.Show(ex.ToString, "error", MessageBoxButtons.OK)
        End Try

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