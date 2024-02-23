<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.grpSupplierInfo = New System.Windows.Forms.GroupBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCustomContactNo = New System.Windows.Forms.TextBox()
        Me.txtCustomerAdress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtAccountNo = New System.Windows.Forms.TextBox()
        Me.bttnSelection = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTransaction = New System.Windows.Forms.GroupBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTransactionAmount = New System.Windows.Forms.TextBox()
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.dtpTranactionDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTransactionNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPaymentModeDetails = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bttnNew = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnGetData = New System.Windows.Forms.Button()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.colBillNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPay = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colDiscountAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grpSupplierInfo.SuspendLayout()
        Me.grpTransaction.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSupplierInfo
        '
        Me.grpSupplierInfo.Controls.Add(Me.lblBalance)
        Me.grpSupplierInfo.Controls.Add(Me.Label13)
        Me.grpSupplierInfo.Controls.Add(Me.txtCustomContactNo)
        Me.grpSupplierInfo.Controls.Add(Me.txtCustomerAdress)
        Me.grpSupplierInfo.Controls.Add(Me.txtCustomerName)
        Me.grpSupplierInfo.Controls.Add(Me.txtAccountNo)
        Me.grpSupplierInfo.Controls.Add(Me.bttnSelection)
        Me.grpSupplierInfo.Controls.Add(Me.Panel1)
        Me.grpSupplierInfo.Controls.Add(Me.Label5)
        Me.grpSupplierInfo.Controls.Add(Me.Label4)
        Me.grpSupplierInfo.Controls.Add(Me.Label3)
        Me.grpSupplierInfo.Controls.Add(Me.Label2)
        Me.grpSupplierInfo.Controls.Add(Me.Label1)
        Me.grpSupplierInfo.Location = New System.Drawing.Point(2, 43)
        Me.grpSupplierInfo.Name = "grpSupplierInfo"
        Me.grpSupplierInfo.Size = New System.Drawing.Size(295, 136)
        Me.grpSupplierInfo.TabIndex = 0
        Me.grpSupplierInfo.TabStop = False
        Me.grpSupplierInfo.Text = "Suplier Info"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(102, 120)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(43, 13)
        Me.lblBalance.TabIndex = 20
        Me.lblBalance.Text = "0.000 "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Balance"
        '
        'txtCustomContactNo
        '
        Me.txtCustomContactNo.Location = New System.Drawing.Point(96, 96)
        Me.txtCustomContactNo.Name = "txtCustomContactNo"
        Me.txtCustomContactNo.Size = New System.Drawing.Size(112, 20)
        Me.txtCustomContactNo.TabIndex = 18
        '
        'txtCustomerAdress
        '
        Me.txtCustomerAdress.Location = New System.Drawing.Point(96, 73)
        Me.txtCustomerAdress.Name = "txtCustomerAdress"
        Me.txtCustomerAdress.Size = New System.Drawing.Size(112, 20)
        Me.txtCustomerAdress.TabIndex = 17
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(96, 43)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(112, 20)
        Me.txtCustomerName.TabIndex = 16
        '
        'txtAccountNo
        '
        Me.txtAccountNo.Location = New System.Drawing.Point(96, 13)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(112, 20)
        Me.txtAccountNo.TabIndex = 15
        '
        'bttnSelection
        '
        Me.bttnSelection.Location = New System.Drawing.Point(234, 13)
        Me.bttnSelection.Name = "bttnSelection"
        Me.bttnSelection.Size = New System.Drawing.Size(43, 23)
        Me.bttnSelection.TabIndex = 14
        Me.bttnSelection.Text = "...."
        Me.bttnSelection.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(301, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 52)
        Me.Panel1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Account No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Balance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adress"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'grpTransaction
        '
        Me.grpTransaction.Controls.Add(Me.txtdiscount)
        Me.grpTransaction.Controls.Add(Me.Label14)
        Me.grpTransaction.Controls.Add(Me.txtTransactionAmount)
        Me.grpTransaction.Controls.Add(Me.cmbPaymentMode)
        Me.grpTransaction.Controls.Add(Me.dtpTranactionDate)
        Me.grpTransaction.Controls.Add(Me.txtTransactionNo)
        Me.grpTransaction.Controls.Add(Me.Label9)
        Me.grpTransaction.Controls.Add(Me.Label8)
        Me.grpTransaction.Controls.Add(Me.Label7)
        Me.grpTransaction.Controls.Add(Me.Label6)
        Me.grpTransaction.Location = New System.Drawing.Point(2, 185)
        Me.grpTransaction.Name = "grpTransaction"
        Me.grpTransaction.Size = New System.Drawing.Size(295, 145)
        Me.grpTransaction.TabIndex = 1
        Me.grpTransaction.TabStop = False
        Me.grpTransaction.Text = "Transaction Info"
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(129, 122)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(160, 20)
        Me.txtdiscount.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Discount"
        '
        'txtTransactionAmount
        '
        Me.txtTransactionAmount.Location = New System.Drawing.Point(129, 99)
        Me.txtTransactionAmount.Name = "txtTransactionAmount"
        Me.txtTransactionAmount.Size = New System.Drawing.Size(160, 20)
        Me.txtTransactionAmount.TabIndex = 24
        '
        'cmbPaymentMode
        '
        Me.cmbPaymentMode.FormattingEnabled = True
        Me.cmbPaymentMode.Items.AddRange(New Object() {"Cash", "Card", "ManagerCash"})
        Me.cmbPaymentMode.Location = New System.Drawing.Point(129, 73)
        Me.cmbPaymentMode.Name = "cmbPaymentMode"
        Me.cmbPaymentMode.Size = New System.Drawing.Size(160, 21)
        Me.cmbPaymentMode.TabIndex = 23
        '
        'dtpTranactionDate
        '
        Me.dtpTranactionDate.Location = New System.Drawing.Point(129, 45)
        Me.dtpTranactionDate.Name = "dtpTranactionDate"
        Me.dtpTranactionDate.Size = New System.Drawing.Size(160, 20)
        Me.dtpTranactionDate.TabIndex = 22
        '
        'txtTransactionNo
        '
        Me.txtTransactionNo.Location = New System.Drawing.Point(129, 19)
        Me.txtTransactionNo.Name = "txtTransactionNo"
        Me.txtTransactionNo.Size = New System.Drawing.Size(160, 20)
        Me.txtTransactionNo.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Payment Mode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Transaction Date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Transaction No :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-1, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(2, 349)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(295, 51)
        Me.txtRemarks.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Payment Mode Details (Transaction ID/Cheque No)"
        '
        'txtPaymentModeDetails
        '
        Me.txtPaymentModeDetails.Location = New System.Drawing.Point(2, 422)
        Me.txtPaymentModeDetails.Multiline = True
        Me.txtPaymentModeDetails.Name = "txtPaymentModeDetails"
        Me.txtPaymentModeDetails.Size = New System.Drawing.Size(295, 62)
        Me.txtPaymentModeDetails.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 37)
        Me.Panel2.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(334, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Receipt Entry"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBillNo, Me.colBillDate, Me.colTotalAmount, Me.colTotalPaid, Me.colBalance, Me.colPay, Me.colDiscountAmt, Me.colDiscount})
        Me.DataGridView1.Location = New System.Drawing.Point(306, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(569, 383)
        Me.DataGridView1.TabIndex = 14
        '
        'bttnNew
        '
        Me.bttnNew.Location = New System.Drawing.Point(306, 461)
        Me.bttnNew.Name = "bttnNew"
        Me.bttnNew.Size = New System.Drawing.Size(75, 23)
        Me.bttnNew.TabIndex = 15
        Me.bttnNew.Text = "New"
        Me.bttnNew.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(401, 461)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(75, 23)
        Me.bttnSave.TabIndex = 16
        Me.bttnSave.Text = "Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Location = New System.Drawing.Point(498, 461)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.bttnUpdate.TabIndex = 17
        Me.bttnUpdate.Text = "Update"
        Me.bttnUpdate.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Location = New System.Drawing.Point(588, 461)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(75, 23)
        Me.bttnDelete.TabIndex = 18
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnGetData
        '
        Me.bttnGetData.Location = New System.Drawing.Point(681, 461)
        Me.bttnGetData.Name = "bttnGetData"
        Me.bttnGetData.Size = New System.Drawing.Size(75, 23)
        Me.bttnGetData.TabIndex = 19
        Me.bttnGetData.Text = "GetDate"
        Me.bttnGetData.UseVisualStyleBackColor = True
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(762, 461)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(93, 20)
        Me.txtCustID.TabIndex = 20
        '
        'colBillNo
        '
        Me.colBillNo.HeaderText = "BillNo"
        Me.colBillNo.Name = "colBillNo"
        '
        'colBillDate
        '
        Me.colBillDate.HeaderText = "BillDate"
        Me.colBillDate.Name = "colBillDate"
        '
        'colTotalAmount
        '
        Me.colTotalAmount.HeaderText = "Total_Pending_Amount"
        Me.colTotalAmount.Name = "colTotalAmount"
        '
        'colTotalPaid
        '
        Me.colTotalPaid.HeaderText = "TotalPaid"
        Me.colTotalPaid.Name = "colTotalPaid"
        '
        'colBalance
        '
        Me.colBalance.HeaderText = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colPay
        '
        Me.colPay.HeaderText = "Pay"
        Me.colPay.Name = "colPay"
        Me.colPay.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colDiscountAmt
        '
        Me.colDiscountAmt.HeaderText = "DiscountAmt"
        Me.colDiscountAmt.Name = "colDiscountAmt"
        '
        'colDiscount
        '
        Me.colDiscount.HeaderText = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(880, 496)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.bttnGetData)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnUpdate)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.bttnNew)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtPaymentModeDetails)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.grpTransaction)
        Me.Controls.Add(Me.grpSupplierInfo)
        Me.Name = "frmReceipt"
        Me.Text = "frmReceipt"
        Me.grpSupplierInfo.ResumeLayout(False)
        Me.grpSupplierInfo.PerformLayout()
        Me.grpTransaction.ResumeLayout(False)
        Me.grpTransaction.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSupplierInfo As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpTransaction As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPaymentModeDetails As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bttnNew As Button
    Friend WithEvents bttnSave As Button
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnGetData As Button
    Friend WithEvents bttnSelection As Button
    Friend WithEvents txtAccountNo As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerAdress As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCustomContactNo As TextBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtTransactionNo As TextBox
    Friend WithEvents dtpTranactionDate As DateTimePicker
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTransactionAmount As TextBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents colBillNo As DataGridViewTextBoxColumn
    Friend WithEvents colBillDate As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPaid As DataGridViewTextBoxColumn
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colPay As DataGridViewCheckBoxColumn
    Friend WithEvents colDiscountAmt As DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DataGridViewCheckBoxColumn
End Class
