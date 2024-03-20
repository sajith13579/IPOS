<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDishQuantityChangeLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDishQuantityChangeLog))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1Qua = New System.Windows.Forms.GroupBox()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbPermissionQua = New System.Windows.Forms.ComboBox()
        Me.CmbBillTypeQua = New System.Windows.Forms.ComboBox()
        Me.cmbOperatorQua = New System.Windows.Forms.ComboBox()
        Me.txtBillNumberQua = New System.Windows.Forms.TextBox()
        Me.Label6Qua = New System.Windows.Forms.Label()
        Me.Label5Qua = New System.Windows.Forms.Label()
        Me.Label4Qua = New System.Windows.Forms.Label()
        Me.Label3Qua = New System.Windows.Forms.Label()
        Me.dtpDateToQua = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFromQua = New System.Windows.Forms.DateTimePicker()
        Me.Label2Qua = New System.Windows.Forms.Label()
        Me.Label1Qua = New System.Windows.Forms.Label()
        Me.DatagridViewQty = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Changed_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Original_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Changed_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diffrence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operator_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permission_Granted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComapnyId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1Qua = New System.Windows.Forms.Panel()
        Me.Label7Qua = New System.Windows.Forms.Label()
        Me.txtChangedQtyCount = New System.Windows.Forms.TextBox()
        Me.GroupBox1Qua.SuspendLayout()
        CType(Me.DatagridViewQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1Qua.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1Qua
        '
        Me.GroupBox1Qua.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1Qua.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1Qua.Controls.Add(Me.btnExportExcel)
        Me.GroupBox1Qua.Controls.Add(Me.BtnPrint)
        Me.GroupBox1Qua.Controls.Add(Me.btnReset)
        Me.GroupBox1Qua.Controls.Add(Me.cmbPermissionQua)
        Me.GroupBox1Qua.Controls.Add(Me.CmbBillTypeQua)
        Me.GroupBox1Qua.Controls.Add(Me.cmbOperatorQua)
        Me.GroupBox1Qua.Controls.Add(Me.txtBillNumberQua)
        Me.GroupBox1Qua.Controls.Add(Me.Label6Qua)
        Me.GroupBox1Qua.Controls.Add(Me.Label5Qua)
        Me.GroupBox1Qua.Controls.Add(Me.Label4Qua)
        Me.GroupBox1Qua.Controls.Add(Me.Label3Qua)
        Me.GroupBox1Qua.Controls.Add(Me.dtpDateToQua)
        Me.GroupBox1Qua.Controls.Add(Me.dtpDateFromQua)
        Me.GroupBox1Qua.Controls.Add(Me.Label2Qua)
        Me.GroupBox1Qua.Controls.Add(Me.Label1Qua)
        Me.GroupBox1Qua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1Qua.ForeColor = System.Drawing.Color.White
        Me.GroupBox1Qua.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1Qua.Name = "GroupBox1Qua"
        Me.GroupBox1Qua.Size = New System.Drawing.Size(879, 152)
        Me.GroupBox1Qua.TabIndex = 0
        Me.GroupBox1Qua.TabStop = False
        Me.GroupBox1Qua.Text = "Search By Date"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnExportExcel.Image = CType(resources.GetObject("btnExportExcel.Image"), System.Drawing.Image)
        Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcel.Location = New System.Drawing.Point(676, 113)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(124, 33)
        Me.btnExportExcel.TabIndex = 152
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.Location = New System.Drawing.Point(676, 20)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(124, 31)
        Me.BtnPrint.TabIndex = 150
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(676, 68)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(124, 32)
        Me.btnReset.TabIndex = 151
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cmbPermissionQua
        '
        Me.cmbPermissionQua.FormattingEnabled = True
        Me.cmbPermissionQua.Location = New System.Drawing.Point(455, 122)
        Me.cmbPermissionQua.Name = "cmbPermissionQua"
        Me.cmbPermissionQua.Size = New System.Drawing.Size(145, 24)
        Me.cmbPermissionQua.TabIndex = 149
        '
        'CmbBillTypeQua
        '
        Me.CmbBillTypeQua.FormattingEnabled = True
        Me.CmbBillTypeQua.Location = New System.Drawing.Point(455, 88)
        Me.CmbBillTypeQua.Name = "CmbBillTypeQua"
        Me.CmbBillTypeQua.Size = New System.Drawing.Size(145, 24)
        Me.CmbBillTypeQua.TabIndex = 148
        '
        'cmbOperatorQua
        '
        Me.cmbOperatorQua.FormattingEnabled = True
        Me.cmbOperatorQua.Location = New System.Drawing.Point(455, 50)
        Me.cmbOperatorQua.Name = "cmbOperatorQua"
        Me.cmbOperatorQua.Size = New System.Drawing.Size(145, 24)
        Me.cmbOperatorQua.TabIndex = 147
        '
        'txtBillNumberQua
        '
        Me.txtBillNumberQua.Location = New System.Drawing.Point(455, 14)
        Me.txtBillNumberQua.Name = "txtBillNumberQua"
        Me.txtBillNumberQua.Size = New System.Drawing.Size(145, 23)
        Me.txtBillNumberQua.TabIndex = 146
        '
        'Label6Qua
        '
        Me.Label6Qua.AutoSize = True
        Me.Label6Qua.Location = New System.Drawing.Point(354, 129)
        Me.Label6Qua.Name = "Label6Qua"
        Me.Label6Qua.Size = New System.Drawing.Size(87, 17)
        Me.Label6Qua.TabIndex = 145
        Me.Label6Qua.Text = "Permission"
        '
        'Label5Qua
        '
        Me.Label5Qua.AutoSize = True
        Me.Label5Qua.Location = New System.Drawing.Point(354, 95)
        Me.Label5Qua.Name = "Label5Qua"
        Me.Label5Qua.Size = New System.Drawing.Size(71, 17)
        Me.Label5Qua.TabIndex = 144
        Me.Label5Qua.Text = "Bill Type"
        '
        'Label4Qua
        '
        Me.Label4Qua.AutoSize = True
        Me.Label4Qua.Location = New System.Drawing.Point(354, 57)
        Me.Label4Qua.Name = "Label4Qua"
        Me.Label4Qua.Size = New System.Drawing.Size(73, 17)
        Me.Label4Qua.TabIndex = 143
        Me.Label4Qua.Text = "Operator"
        '
        'Label3Qua
        '
        Me.Label3Qua.AutoSize = True
        Me.Label3Qua.Location = New System.Drawing.Point(354, 20)
        Me.Label3Qua.Name = "Label3Qua"
        Me.Label3Qua.Size = New System.Drawing.Size(91, 17)
        Me.Label3Qua.TabIndex = 142
        Me.Label3Qua.Text = "Bill Number"
        '
        'dtpDateToQua
        '
        Me.dtpDateToQua.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateToQua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateToQua.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateToQua.Location = New System.Drawing.Point(86, 83)
        Me.dtpDateToQua.Name = "dtpDateToQua"
        Me.dtpDateToQua.Size = New System.Drawing.Size(195, 23)
        Me.dtpDateToQua.TabIndex = 135
        '
        'dtpDateFromQua
        '
        Me.dtpDateFromQua.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFromQua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFromQua.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFromQua.Location = New System.Drawing.Point(86, 28)
        Me.dtpDateFromQua.Name = "dtpDateFromQua"
        Me.dtpDateFromQua.Size = New System.Drawing.Size(195, 23)
        Me.dtpDateFromQua.TabIndex = 134
        '
        'Label2Qua
        '
        Me.Label2Qua.AutoSize = True
        Me.Label2Qua.Location = New System.Drawing.Point(22, 83)
        Me.Label2Qua.Name = "Label2Qua"
        Me.Label2Qua.Size = New System.Drawing.Size(27, 17)
        Me.Label2Qua.TabIndex = 133
        Me.Label2Qua.Text = "To"
        '
        'Label1Qua
        '
        Me.Label1Qua.AutoSize = True
        Me.Label1Qua.Location = New System.Drawing.Point(22, 28)
        Me.Label1Qua.Name = "Label1Qua"
        Me.Label1Qua.Size = New System.Drawing.Size(44, 17)
        Me.Label1Qua.TabIndex = 132
        Me.Label1Qua.Text = "From"
        '
        'DatagridViewQty
        '
        Me.DatagridViewQty.AllowUserToAddRows = False
        Me.DatagridViewQty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridViewQty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridViewQty.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridViewQty.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridViewQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridViewQty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.BillNumber, Me.DishName, Me.Changed_Date, Me.Original_Quantity, Me.Changed_Quantity, Me.Diffrence, Me.Rate_Status, Me.Bill_Type, Me.Operator_, Me.Permission_Granted, Me.Remarks, Me.colComapnyId, Me.colBranchId})
        Me.DatagridViewQty.EnableHeadersVisualStyles = False
        Me.DatagridViewQty.Location = New System.Drawing.Point(2, 161)
        Me.DatagridViewQty.Name = "DatagridViewQty"
        Me.DatagridViewQty.ReadOnly = True
        Me.DatagridViewQty.RowHeadersVisible = False
        Me.DatagridViewQty.Size = New System.Drawing.Size(879, 230)
        Me.DatagridViewQty.TabIndex = 1
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'BillNumber
        '
        Me.BillNumber.HeaderText = "Bill Number"
        Me.BillNumber.Name = "BillNumber"
        Me.BillNumber.ReadOnly = True
        '
        'DishName
        '
        Me.DishName.HeaderText = "Dish Name"
        Me.DishName.Name = "DishName"
        Me.DishName.ReadOnly = True
        '
        'Changed_Date
        '
        Me.Changed_Date.HeaderText = "Changed Date"
        Me.Changed_Date.Name = "Changed_Date"
        Me.Changed_Date.ReadOnly = True
        '
        'Original_Quantity
        '
        Me.Original_Quantity.HeaderText = "Original Qty"
        Me.Original_Quantity.Name = "Original_Quantity"
        Me.Original_Quantity.ReadOnly = True
        '
        'Changed_Quantity
        '
        Me.Changed_Quantity.HeaderText = "Changed Qty"
        Me.Changed_Quantity.Name = "Changed_Quantity"
        Me.Changed_Quantity.ReadOnly = True
        '
        'Diffrence
        '
        Me.Diffrence.HeaderText = "Diffrence"
        Me.Diffrence.Name = "Diffrence"
        Me.Diffrence.ReadOnly = True
        '
        'Rate_Status
        '
        Me.Rate_Status.HeaderText = "Rate Status"
        Me.Rate_Status.Name = "Rate_Status"
        Me.Rate_Status.ReadOnly = True
        '
        'Bill_Type
        '
        Me.Bill_Type.HeaderText = "Bill Type"
        Me.Bill_Type.Name = "Bill_Type"
        Me.Bill_Type.ReadOnly = True
        '
        'Operator_
        '
        Me.Operator_.HeaderText = "Operator"
        Me.Operator_.Name = "Operator_"
        Me.Operator_.ReadOnly = True
        '
        'Permission_Granted
        '
        Me.Permission_Granted.HeaderText = "Permission Granted"
        Me.Permission_Granted.Name = "Permission_Granted"
        Me.Permission_Granted.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'colComapnyId
        '
        Me.colComapnyId.HeaderText = "comp_Id"
        Me.colComapnyId.Name = "colComapnyId"
        Me.colComapnyId.ReadOnly = True
        Me.colComapnyId.Visible = False
        '
        'colBranchId
        '
        Me.colBranchId.HeaderText = "Branch_ID"
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.ReadOnly = True
        Me.colBranchId.Visible = False
        '
        'Panel1Qua
        '
        Me.Panel1Qua.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1Qua.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1Qua.Controls.Add(Me.Label7Qua)
        Me.Panel1Qua.Controls.Add(Me.txtChangedQtyCount)
        Me.Panel1Qua.Location = New System.Drawing.Point(2, 388)
        Me.Panel1Qua.Name = "Panel1Qua"
        Me.Panel1Qua.Size = New System.Drawing.Size(879, 62)
        Me.Panel1Qua.TabIndex = 2
        '
        'Label7Qua
        '
        Me.Label7Qua.AutoSize = True
        Me.Label7Qua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7Qua.ForeColor = System.Drawing.Color.White
        Me.Label7Qua.Location = New System.Drawing.Point(196, 23)
        Me.Label7Qua.Name = "Label7Qua"
        Me.Label7Qua.Size = New System.Drawing.Size(206, 20)
        Me.Label7Qua.TabIndex = 1
        Me.Label7Qua.Text = "Changed Quantity Count"
        '
        'txtChangedQtyCount
        '
        Me.txtChangedQtyCount.Location = New System.Drawing.Point(430, 23)
        Me.txtChangedQtyCount.Name = "txtChangedQtyCount"
        Me.txtChangedQtyCount.ReadOnly = True
        Me.txtChangedQtyCount.Size = New System.Drawing.Size(216, 20)
        Me.txtChangedQtyCount.TabIndex = 0
        '
        'frmDishQuantityChangeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 450)
        Me.Controls.Add(Me.Panel1Qua)
        Me.Controls.Add(Me.DatagridViewQty)
        Me.Controls.Add(Me.GroupBox1Qua)
        Me.Name = "frmDishQuantityChangeLog"
        Me.Text = "frmDishQuantityChangeLog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1Qua.ResumeLayout(False)
        Me.GroupBox1Qua.PerformLayout()
        CType(Me.DatagridViewQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1Qua.ResumeLayout(False)
        Me.Panel1Qua.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1Qua As GroupBox
    Friend WithEvents Label2Qua As Label
    Friend WithEvents Label1Qua As Label
    Friend WithEvents dtpDateFromQua As DateTimePicker
    Friend WithEvents dtpDateToQua As DateTimePicker
    Friend WithEvents Label6Qua As Label
    Friend WithEvents Label5Qua As Label
    Friend WithEvents Label4Qua As Label
    Friend WithEvents Label3Qua As Label
    Friend WithEvents cmbPermissionQua As ComboBox
    Friend WithEvents CmbBillTypeQua As ComboBox
    Friend WithEvents cmbOperatorQua As ComboBox
    Friend WithEvents txtBillNumberQua As TextBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents DatagridViewQty As DataGridView
    Friend WithEvents Panel1Qua As Panel
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents BillNumber As DataGridViewTextBoxColumn
    Friend WithEvents DishName As DataGridViewTextBoxColumn
    Friend WithEvents Changed_Date As DataGridViewTextBoxColumn
    Friend WithEvents Original_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Changed_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Diffrence As DataGridViewTextBoxColumn
    Friend WithEvents Rate_Status As DataGridViewTextBoxColumn
    Friend WithEvents Bill_Type As DataGridViewTextBoxColumn
    Friend WithEvents Operator_ As DataGridViewTextBoxColumn
    Friend WithEvents Permission_Granted As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents colComapnyId As DataGridViewTextBoxColumn
    Friend WithEvents colBranchId As DataGridViewTextBoxColumn
    Friend WithEvents Label7Qua As Label
    Friend WithEvents txtChangedQtyCount As TextBox
End Class
