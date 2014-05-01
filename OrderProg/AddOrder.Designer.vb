<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtPicker = New System.Windows.Forms.DateTimePicker()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 195)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(267, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 224)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(267, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(13, 13)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(50, 13)
        Me.lblOrderID.TabIndex = 2
        Me.lblOrderID.Text = "Order ID:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(147, 10)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(133, 20)
        Me.txtOrderID.TabIndex = 3
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(147, 40)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(133, 20)
        Me.txtCustomerID.TabIndex = 4
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(13, 43)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(68, 13)
        Me.lblCustID.TabIndex = 5
        Me.lblCustID.Text = "Customer ID:"
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(147, 66)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(133, 20)
        Me.txtProdID.TabIndex = 6
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(13, 69)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 7
        Me.lblProductID.Text = "Product ID:"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(13, 94)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(49, 13)
        Me.lblQty.TabIndex = 8
        Me.lblQty.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(147, 91)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(132, 20)
        Me.txtQty.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(14, 146)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Order Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(148, 143)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 20)
        Me.txtTotal.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Order date:"
        '
        'DtPicker
        '
        Me.DtPicker.Location = New System.Drawing.Point(80, 169)
        Me.DtPicker.Name = "DtPicker"
        Me.DtPicker.Size = New System.Drawing.Size(200, 20)
        Me.DtPicker.TabIndex = 13
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(14, 120)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 14
        Me.lblPrice.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.AcceptsReturn = True
        Me.txtPrice.Location = New System.Drawing.Point(147, 117)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 20)
        Me.txtPrice.TabIndex = 15
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(13, 258)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(267, 23)
        Me.btnClr.TabIndex = 16
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'frmAddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 293)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.DtPicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmAddOrder"
        Me.Text = "AddOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents txtProdID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnClr As System.Windows.Forms.Button
End Class
