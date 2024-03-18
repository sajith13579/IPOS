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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbPermission = New System.Windows.Forms.ComboBox()
        Me.CmbBillType = New System.Windows.Forms.ComboBox()
        Me.cmbOperator = New System.Windows.Forms.ComboBox()
        Me.txtBillNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChangedQtyCount = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatagridViewQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnExportExcel)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.cmbPermission)
        Me.GroupBox1.Controls.Add(Me.CmbBillType)
        Me.GroupBox1.Controls.Add(Me.cmbOperator)
        Me.GroupBox1.Controls.Add(Me.txtBillNumber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Date"
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
        'cmbPermission
        '
        Me.cmbPermission.FormattingEnabled = True
        Me.cmbPermission.Location = New System.Drawing.Point(455, 122)
        Me.cmbPermission.Name = "cmbPermission"
        Me.cmbPermission.Size = New System.Drawing.Size(145, 24)
        Me.cmbPermission.TabIndex = 149
        '
        'CmbBillType
        '
        Me.CmbBillType.FormattingEnabled = True
        Me.CmbBillType.Location = New System.Drawing.Point(455, 88)
        Me.CmbBillType.Name = "CmbBillType"
        Me.CmbBillType.Size = New System.Drawing.Size(145, 24)
        Me.CmbBillType.TabIndex = 148
        '
        'cmbOperator
        '
        Me.cmbOperator.FormattingEnabled = True
        Me.cmbOperator.Location = New System.Drawing.Point(455, 50)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(145, 24)
        Me.cmbOperator.TabIndex = 147
        '
        'txtBillNumber
        '
        Me.txtBillNumber.Location = New System.Drawing.Point(455, 14)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.Size = New System.Drawing.Size(145, 23)
        Me.txtBillNumber.TabIndex = 146
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Permission"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Bill Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Operator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Bill Number"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(86, 83)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(195, 23)
        Me.dtpDateTo.TabIndex = 135
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(86, 28)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(195, 23)
        Me.dtpDateFrom.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "From"
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtChangedQtyCount)
        Me.Panel1.Location = New System.Drawing.Point(2, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 62)
        Me.Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(196, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Changed Quantity Count"
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DatagridViewQty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDishQuantityChangeLog"
        Me.Text = "frmDishQuantityChangeLog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DatagridViewQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPermission As ComboBox
    Friend WithEvents CmbBillType As ComboBox
    Friend WithEvents cmbOperator As ComboBox
    Friend WithEvents txtBillNumber As TextBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents DatagridViewQty As DataGridView
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChangedQtyCount As TextBox
End Class
