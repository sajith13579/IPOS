<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRateQtyItemLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRateQtyItemLog))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbRateChange = New System.Windows.Forms.TabPage()
        Me.tbQuantityChange = New System.Windows.Forms.TabPage()
        Me.tbItemDeleted = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportExceldl = New System.Windows.Forms.Button()
        Me.BtnPrintdl = New System.Windows.Forms.Button()
        Me.btnResetdl = New System.Windows.Forms.Button()
        Me.cmbPermissiondl = New System.Windows.Forms.ComboBox()
        Me.CmbBillTypedl = New System.Windows.Forms.ComboBox()
        Me.cmbOperatordl = New System.Windows.Forms.ComboBox()
        Me.txtBillNumberdl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTodl = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFromdl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatagridViewItemDel = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kot_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.table_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operator_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permission_Granted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComapnyId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtGrandTotaldl = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tbItemDeleted.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatagridViewItemDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbRateChange)
        Me.TabControl1.Controls.Add(Me.tbQuantityChange)
        Me.TabControl1.Controls.Add(Me.tbItemDeleted)
        Me.TabControl1.Location = New System.Drawing.Point(-3, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(922, 531)
        Me.TabControl1.TabIndex = 0
        '
        'tbRateChange
        '
        Me.tbRateChange.Location = New System.Drawing.Point(4, 22)
        Me.tbRateChange.Name = "tbRateChange"
        Me.tbRateChange.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRateChange.Size = New System.Drawing.Size(914, 505)
        Me.tbRateChange.TabIndex = 0
        Me.tbRateChange.Text = "Rate Change Log"
        Me.tbRateChange.UseVisualStyleBackColor = True
        '
        'tbQuantityChange
        '
        Me.tbQuantityChange.Location = New System.Drawing.Point(4, 22)
        Me.tbQuantityChange.Name = "tbQuantityChange"
        Me.tbQuantityChange.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuantityChange.Size = New System.Drawing.Size(914, 505)
        Me.tbQuantityChange.TabIndex = 1
        Me.tbQuantityChange.Text = "Quantity Change Log"
        Me.tbQuantityChange.UseVisualStyleBackColor = True
        '
        'tbItemDeleted
        '
        Me.tbItemDeleted.Controls.Add(Me.Panel1)
        Me.tbItemDeleted.Controls.Add(Me.GroupBox1)
        Me.tbItemDeleted.Controls.Add(Me.DatagridViewItemDel)
        Me.tbItemDeleted.Location = New System.Drawing.Point(4, 22)
        Me.tbItemDeleted.Name = "tbItemDeleted"
        Me.tbItemDeleted.Padding = New System.Windows.Forms.Padding(3)
        Me.tbItemDeleted.Size = New System.Drawing.Size(914, 505)
        Me.tbItemDeleted.TabIndex = 2
        Me.tbItemDeleted.Text = "Item Deleted"
        Me.tbItemDeleted.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnExportExceldl)
        Me.GroupBox1.Controls.Add(Me.BtnPrintdl)
        Me.GroupBox1.Controls.Add(Me.btnResetdl)
        Me.GroupBox1.Controls.Add(Me.cmbPermissiondl)
        Me.GroupBox1.Controls.Add(Me.CmbBillTypedl)
        Me.GroupBox1.Controls.Add(Me.cmbOperatordl)
        Me.GroupBox1.Controls.Add(Me.txtBillNumberdl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateTodl)
        Me.GroupBox1.Controls.Add(Me.dtpDateFromdl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 164)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Date"
        '
        'btnExportExceldl
        '
        Me.btnExportExceldl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExceldl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExceldl.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnExportExceldl.Image = CType(resources.GetObject("btnExportExceldl.Image"), System.Drawing.Image)
        Me.btnExportExceldl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExceldl.Location = New System.Drawing.Point(676, 113)
        Me.btnExportExceldl.Name = "btnExportExceldl"
        Me.btnExportExceldl.Size = New System.Drawing.Size(124, 33)
        Me.btnExportExceldl.TabIndex = 152
        Me.btnExportExceldl.Text = "Export Excel"
        Me.btnExportExceldl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExceldl.UseVisualStyleBackColor = True
        '
        'BtnPrintdl
        '
        Me.BtnPrintdl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintdl.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintdl.Location = New System.Drawing.Point(676, 20)
        Me.BtnPrintdl.Name = "BtnPrintdl"
        Me.BtnPrintdl.Size = New System.Drawing.Size(124, 31)
        Me.BtnPrintdl.TabIndex = 150
        Me.BtnPrintdl.Text = "Print"
        Me.BtnPrintdl.UseVisualStyleBackColor = True
        '
        'btnResetdl
        '
        Me.btnResetdl.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetdl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetdl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetdl.ForeColor = System.Drawing.Color.Black
        Me.btnResetdl.Image = CType(resources.GetObject("btnResetdl.Image"), System.Drawing.Image)
        Me.btnResetdl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetdl.Location = New System.Drawing.Point(676, 68)
        Me.btnResetdl.Name = "btnResetdl"
        Me.btnResetdl.Size = New System.Drawing.Size(124, 32)
        Me.btnResetdl.TabIndex = 151
        Me.btnResetdl.Text = "Reset"
        Me.btnResetdl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResetdl.UseVisualStyleBackColor = False
        '
        'cmbPermissiondl
        '
        Me.cmbPermissiondl.FormattingEnabled = True
        Me.cmbPermissiondl.Location = New System.Drawing.Point(455, 122)
        Me.cmbPermissiondl.Name = "cmbPermissiondl"
        Me.cmbPermissiondl.Size = New System.Drawing.Size(145, 24)
        Me.cmbPermissiondl.TabIndex = 149
        '
        'CmbBillTypedl
        '
        Me.CmbBillTypedl.FormattingEnabled = True
        Me.CmbBillTypedl.Location = New System.Drawing.Point(455, 88)
        Me.CmbBillTypedl.Name = "CmbBillTypedl"
        Me.CmbBillTypedl.Size = New System.Drawing.Size(145, 24)
        Me.CmbBillTypedl.TabIndex = 148
        '
        'cmbOperatordl
        '
        Me.cmbOperatordl.FormattingEnabled = True
        Me.cmbOperatordl.Location = New System.Drawing.Point(455, 50)
        Me.cmbOperatordl.Name = "cmbOperatordl"
        Me.cmbOperatordl.Size = New System.Drawing.Size(145, 24)
        Me.cmbOperatordl.TabIndex = 147
        '
        'txtBillNumberdl
        '
        Me.txtBillNumberdl.Location = New System.Drawing.Point(455, 14)
        Me.txtBillNumberdl.Name = "txtBillNumberdl"
        Me.txtBillNumberdl.Size = New System.Drawing.Size(145, 23)
        Me.txtBillNumberdl.TabIndex = 146
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
        'dtpDateTodl
        '
        Me.dtpDateTodl.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTodl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTodl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTodl.Location = New System.Drawing.Point(86, 83)
        Me.dtpDateTodl.Name = "dtpDateTodl"
        Me.dtpDateTodl.Size = New System.Drawing.Size(195, 23)
        Me.dtpDateTodl.TabIndex = 135
        '
        'dtpDateFromdl
        '
        Me.dtpDateFromdl.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFromdl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFromdl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFromdl.Location = New System.Drawing.Point(86, 28)
        Me.dtpDateFromdl.Name = "dtpDateFromdl"
        Me.dtpDateFromdl.Size = New System.Drawing.Size(195, 23)
        Me.dtpDateFromdl.TabIndex = 134
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
        'DatagridViewItemDel
        '
        Me.DatagridViewItemDel.AllowUserToAddRows = False
        Me.DatagridViewItemDel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridViewItemDel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridViewItemDel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridViewItemDel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DatagridViewItemDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridViewItemDel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.BillNumber, Me.DishName, Me.Kot_Date, Me.table_No, Me.Quantity, Me.Rate, Me.Bill_Type, Me.Operator_, Me.Permission_Granted, Me.Remarks, Me.colComapnyId, Me.colBranchId})
        Me.DatagridViewItemDel.EnableHeadersVisualStyles = False
        Me.DatagridViewItemDel.Location = New System.Drawing.Point(-3, 169)
        Me.DatagridViewItemDel.Name = "DatagridViewItemDel"
        Me.DatagridViewItemDel.ReadOnly = True
        Me.DatagridViewItemDel.RowHeadersVisible = False
        Me.DatagridViewItemDel.Size = New System.Drawing.Size(921, 276)
        Me.DatagridViewItemDel.TabIndex = 2
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
        'Kot_Date
        '
        Me.Kot_Date.HeaderText = "Kot Date"
        Me.Kot_Date.Name = "Kot_Date"
        Me.Kot_Date.ReadOnly = True
        '
        'table_No
        '
        Me.table_No.HeaderText = "Table_No"
        Me.table_No.Name = "table_No"
        Me.table_No.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Grand Total"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtGrandTotaldl)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 440)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 65)
        Me.Panel1.TabIndex = 5
        '
        'txtGrandTotaldl
        '
        Me.txtGrandTotaldl.Location = New System.Drawing.Point(420, 25)
        Me.txtGrandTotaldl.Name = "txtGrandTotaldl"
        Me.txtGrandTotaldl.ReadOnly = True
        Me.txtGrandTotaldl.Size = New System.Drawing.Size(180, 20)
        Me.txtGrandTotaldl.TabIndex = 5
        '
        'frmRateQtyItemLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 525)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmRateQtyItemLog"
        Me.Text = "frmRateQtyItemLog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbItemDeleted.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DatagridViewItemDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbRateChange As TabPage
    Friend WithEvents tbQuantityChange As TabPage
    Friend WithEvents tbItemDeleted As TabPage
    Friend WithEvents DatagridViewItemDel As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExportExceldl As Button
    Friend WithEvents BtnPrintdl As Button
    Friend WithEvents btnResetdl As Button
    Friend WithEvents cmbPermissiondl As ComboBox
    Friend WithEvents CmbBillTypedl As ComboBox
    Friend WithEvents cmbOperatordl As ComboBox
    Friend WithEvents txtBillNumberdl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateTodl As DateTimePicker
    Friend WithEvents dtpDateFromdl As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents BillNumber As DataGridViewTextBoxColumn
    Friend WithEvents DishName As DataGridViewTextBoxColumn
    Friend WithEvents Kot_Date As DataGridViewTextBoxColumn
    Friend WithEvents table_No As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Bill_Type As DataGridViewTextBoxColumn
    Friend WithEvents Operator_ As DataGridViewTextBoxColumn
    Friend WithEvents Permission_Granted As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents colComapnyId As DataGridViewTextBoxColumn
    Friend WithEvents colBranchId As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtGrandTotaldl As TextBox
    Friend WithEvents Label7 As Label
End Class
