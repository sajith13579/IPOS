<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class temporaryFrmReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temporaryFrmReceipt))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTransaction = New System.Windows.Forms.GroupBox()
        Me.txtTransactionAmount = New System.Windows.Forms.TextBox()
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.dtpTranactionDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTransactionNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPaymentModeDetails = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.bttnNew = New System.Windows.Forms.Button()
        Me.lblCusRemBal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtT_ID = New System.Windows.Forms.TextBox()
        Me.txtTempAmt = New System.Windows.Forms.TextBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalBillAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPay = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colDiscountAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSupplierInfo.SuspendLayout()
        Me.grpTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1243, 41)
        Me.Panel2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(318, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Receipt Entry"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colBillNo, Me.colBillDate, Me.colTotalBillAmount, Me.colTotalAmount, Me.colTotalPaid, Me.colBalance, Me.colPay, Me.colDiscountAmt, Me.colDiscount})
        Me.DataGridView1.Location = New System.Drawing.Point(300, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(905, 382)
        Me.DataGridView1.TabIndex = 15
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
        Me.grpSupplierInfo.Controls.Add(Me.Label3)
        Me.grpSupplierInfo.Controls.Add(Me.Label2)
        Me.grpSupplierInfo.Controls.Add(Me.Label1)
        Me.grpSupplierInfo.Location = New System.Drawing.Point(-1, 58)
        Me.grpSupplierInfo.Name = "grpSupplierInfo"
        Me.grpSupplierInfo.Size = New System.Drawing.Size(284, 159)
        Me.grpSupplierInfo.TabIndex = 16
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
        Me.grpTransaction.Controls.Add(Me.txtTransactionAmount)
        Me.grpTransaction.Controls.Add(Me.cmbPaymentMode)
        Me.grpTransaction.Controls.Add(Me.dtpTranactionDate)
        Me.grpTransaction.Controls.Add(Me.txtTransactionNo)
        Me.grpTransaction.Controls.Add(Me.Label9)
        Me.grpTransaction.Controls.Add(Me.Label8)
        Me.grpTransaction.Controls.Add(Me.Label7)
        Me.grpTransaction.Controls.Add(Me.Label6)
        Me.grpTransaction.Location = New System.Drawing.Point(-1, 238)
        Me.grpTransaction.Name = "grpTransaction"
        Me.grpTransaction.Size = New System.Drawing.Size(298, 142)
        Me.grpTransaction.TabIndex = 17
        Me.grpTransaction.TabStop = False
        Me.grpTransaction.Text = "Transaction Info"
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
        'txtPaymentModeDetails
        '
        Me.txtPaymentModeDetails.Location = New System.Drawing.Point(2, 473)
        Me.txtPaymentModeDetails.Multiline = True
        Me.txtPaymentModeDetails.Name = "txtPaymentModeDetails"
        Me.txtPaymentModeDetails.Size = New System.Drawing.Size(295, 44)
        Me.txtPaymentModeDetails.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Payment Mode Details (Transaction ID/Cheque No)"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(2, 400)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(295, 43)
        Me.txtRemarks.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-1, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Remarks"
        '
        'txtCustID
        '
        Me.txtCustID.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtCustID.Location = New System.Drawing.Point(819, 447)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(93, 20)
        Me.txtCustID.TabIndex = 27
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(414, 454)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(75, 36)
        Me.bttnSave.TabIndex = 23
        Me.bttnSave.Text = "Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'bttnNew
        '
        Me.bttnNew.Location = New System.Drawing.Point(321, 454)
        Me.bttnNew.Name = "bttnNew"
        Me.bttnNew.Size = New System.Drawing.Size(75, 36)
        Me.bttnNew.TabIndex = 22
        Me.bttnNew.Text = "New"
        Me.bttnNew.UseVisualStyleBackColor = True
        '
        'lblCusRemBal
        '
        Me.lblCusRemBal.AutoSize = True
        Me.lblCusRemBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusRemBal.Location = New System.Drawing.Point(317, 491)
        Me.lblCusRemBal.Name = "lblCusRemBal"
        Me.lblCusRemBal.Size = New System.Drawing.Size(0, 20)
        Me.lblCusRemBal.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(538, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 20)
        Me.Label14.TabIndex = 29
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.Location = New System.Drawing.Point(740, 499)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(0, 18)
        Me.lblPending.TabIndex = 30
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Image = CType(resources.GetObject("btnGetData.Image"), System.Drawing.Image)
        Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetData.Location = New System.Drawing.Point(495, 455)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(92, 35)
        Me.btnGetData.TabIndex = 31
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(692, 455)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 35)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(593, 455)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 35)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtT_ID
        '
        Me.txtT_ID.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtT_ID.Location = New System.Drawing.Point(959, 447)
        Me.txtT_ID.Name = "txtT_ID"
        Me.txtT_ID.Size = New System.Drawing.Size(93, 20)
        Me.txtT_ID.TabIndex = 34
        '
        'txtTempAmt
        '
        Me.txtTempAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempAmt.Location = New System.Drawing.Point(795, 463)
        Me.txtTempAmt.Name = "txtTempAmt"
        Me.txtTempAmt.Size = New System.Drawing.Size(18, 20)
        Me.txtTempAmt.TabIndex = 35
        Me.txtTempAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTempAmt.Visible = False
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'colBillNo
        '
        Me.colBillNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colBillNo.FillWeight = 30.0!
        Me.colBillNo.HeaderText = "Bill No"
        Me.colBillNo.Name = "colBillNo"
        Me.colBillNo.ReadOnly = True
        Me.colBillNo.Width = 62
        '
        'colBillDate
        '
        Me.colBillDate.HeaderText = "Bill Date"
        Me.colBillDate.Name = "colBillDate"
        Me.colBillDate.ReadOnly = True
        '
        'colTotalBillAmount
        '
        Me.colTotalBillAmount.HeaderText = "Total bill Amount"
        Me.colTotalBillAmount.Name = "colTotalBillAmount"
        Me.colTotalBillAmount.ReadOnly = True
        '
        'colTotalAmount
        '
        Me.colTotalAmount.HeaderText = "Total Pending Amount"
        Me.colTotalAmount.Name = "colTotalAmount"
        Me.colTotalAmount.ReadOnly = True
        '
        'colTotalPaid
        '
        Me.colTotalPaid.HeaderText = "Total Paid"
        Me.colTotalPaid.Name = "colTotalPaid"
        '
        'colBalance
        '
        Me.colBalance.HeaderText = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.ReadOnly = True
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
        Me.colDiscountAmt.HeaderText = "Discount Amont"
        Me.colDiscountAmt.Name = "colDiscountAmt"
        '
        'colDiscount
        '
        Me.colDiscount.HeaderText = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'temporaryFrmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1239, 520)
        Me.Controls.Add(Me.txtTempAmt)
        Me.Controls.Add(Me.txtT_ID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.lblPending)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblCusRemBal)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.bttnNew)
        Me.Controls.Add(Me.txtPaymentModeDetails)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.grpTransaction)
        Me.Controls.Add(Me.grpSupplierInfo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "temporaryFrmReceipt"
        Me.Text = "temporaryFrmReceipt"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSupplierInfo.ResumeLayout(False)
        Me.grpSupplierInfo.PerformLayout()
        Me.grpTransaction.ResumeLayout(False)
        Me.grpTransaction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents grpSupplierInfo As GroupBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCustomContactNo As TextBox
    Friend WithEvents txtCustomerAdress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtAccountNo As TextBox
    Friend WithEvents bttnSelection As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpTransaction As GroupBox
    Friend WithEvents txtTransactionAmount As TextBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents dtpTranactionDate As DateTimePicker
    Friend WithEvents txtTransactionNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPaymentModeDetails As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents bttnSave As Button
    Friend WithEvents bttnNew As Button
    Friend WithEvents lblCusRemBal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents btnGetData As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtT_ID As TextBox
    Friend WithEvents txtTempAmt As TextBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colBillNo As DataGridViewTextBoxColumn
    Friend WithEvents colBillDate As DataGridViewTextBoxColumn
    Friend WithEvents colTotalBillAmount As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPaid As DataGridViewTextBoxColumn
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colPay As DataGridViewCheckBoxColumn
    Friend WithEvents colDiscountAmt As DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DataGridViewCheckBoxColumn
End Class
