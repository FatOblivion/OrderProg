<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnProd = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(13, 188)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(101, 71)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "View Customer Form"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(120, 188)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(92, 71)
        Me.btnOrder.TabIndex = 1
        Me.btnOrder.Text = "View Order Form"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnProd
        '
        Me.btnProd.Location = New System.Drawing.Point(218, 188)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(94, 71)
        Me.btnProd.TabIndex = 2
        Me.btnProd.Text = "View Product form "
        Me.btnProd.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(26, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(383, 56)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Hi. Welcome to this sample application. "
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(351, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 271)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnProd)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnCustomers)
        Me.Name = "frmMain"
        Me.Tag = "Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnProd As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
