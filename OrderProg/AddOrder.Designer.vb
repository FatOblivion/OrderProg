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
        Me.components = New System.ComponentModel.Container()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDataSet1 = New OrderProg.MainDataSet1()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New OrderProg.MainDataSet1TableAdapters.OrdersTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrderProdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDataSet2 = New OrderProg.MainDataSet2()
        Me.OrderProdTableAdapter = New OrderProg.MainDataSet2TableAdapters.OrderProdTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnProd = New System.Windows.Forms.Button()
        Me.btnViewCust = New System.Windows.Forms.Button()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderProdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(13, 13)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(50, 13)
        Me.lblOrderID.TabIndex = 0
        Me.lblOrderID.Text = "Order ID:"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(13, 127)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(68, 13)
        Me.lblCustID.TabIndex = 1
        Me.lblCustID.Text = "Customer ID:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(13, 39)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 13)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Order total:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(13, 65)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ID", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtID.Location = New System.Drawing.Point(89, 10)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.MainDataSet1
        '
        'MainDataSet1
        '
        Me.MainDataSet1.DataSetName = "MainDataSet1"
        Me.MainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCustID
        '
        Me.txtCustID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource1, "CustomerID", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtCustID.Location = New System.Drawing.Point(89, 124)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustID.TabIndex = 5
        '
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "Orders"
        Me.OrdersBindingSource1.DataSource = Me.MainDataSet1
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource2, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtTotal.Location = New System.Drawing.Point(89, 36)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 6
        '
        'OrdersBindingSource2
        '
        Me.OrdersBindingSource2.DataMember = "Orders"
        Me.OrdersBindingSource2.DataSource = Me.MainDataSet1
        '
        'txtDate
        '
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource3, "Date", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
        Me.txtDate.Location = New System.Drawing.Point(89, 62)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 39)
        Me.txtDate.TabIndex = 7
        '
        'OrdersBindingSource3
        '
        Me.OrdersBindingSource3.DataMember = "Orders"
        Me.OrdersBindingSource3.DataSource = Me.MainDataSet1
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderProdBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(195, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(655, 357)
        Me.DataGridView1.TabIndex = 8
        '
        'OrderProdBindingSource
        '
        Me.OrderProdBindingSource.DataMember = "OrderProd"
        Me.OrderProdBindingSource.DataSource = Me.MainDataSet2
        '
        'MainDataSet2
        '
        Me.MainDataSet2.DataSetName = "MainDataSet2"
        Me.MainDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderProdTableAdapter
        '
        Me.OrderProdTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(16, 235)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(173, 40)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(16, 281)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(173, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnProd
        '
        Me.btnProd.Location = New System.Drawing.Point(16, 327)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(173, 40)
        Me.btnProd.TabIndex = 11
        Me.btnProd.Text = "Product List"
        Me.btnProd.UseVisualStyleBackColor = True
        '
        'btnViewCust
        '
        Me.btnViewCust.Location = New System.Drawing.Point(16, 189)
        Me.btnViewCust.Name = "btnViewCust"
        Me.btnViewCust.Size = New System.Drawing.Size(173, 40)
        Me.btnViewCust.TabIndex = 12
        Me.btnViewCust.Text = "View Customer Details"
        Me.btnViewCust.UseVisualStyleBackColor = True
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmAddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 380)
        Me.Controls.Add(Me.btnViewCust)
        Me.Controls.Add(Me.btnProd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Name = "frmAddOrder"
        Me.Text = "AddOrder"
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderProdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents MainDataSet1 As OrderProg.MainDataSet1
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As OrderProg.MainDataSet1TableAdapters.OrdersTableAdapter
    Friend WithEvents OrdersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MainDataSet2 As OrderProg.MainDataSet2
    Friend WithEvents OrderProdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderProdTableAdapter As OrderProg.MainDataSet2TableAdapters.OrderProdTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnProd As System.Windows.Forms.Button
    Friend WithEvents btnViewCust As System.Windows.Forms.Button
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
