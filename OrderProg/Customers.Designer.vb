<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSrch = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(205, 221)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 38)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Show main form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSrch
        '
        Me.btnSrch.Location = New System.Drawing.Point(13, 221)
        Me.btnSrch.Name = "btnSrch"
        Me.btnSrch.Size = New System.Drawing.Size(75, 38)
        Me.btnSrch.TabIndex = 1
        Me.btnSrch.Text = "Search by Customer ID"
        Me.btnSrch.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(13, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(267, 23)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Customer Details"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(18, 39)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(262, 173)
        Me.lst1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(109, 221)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 271)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lst1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnSrch)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "frmCustomers"
        Me.Text = "Customers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnSrch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
