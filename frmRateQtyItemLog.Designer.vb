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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRateQtyItemLog))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbRateChange = New System.Windows.Forms.TabPage()
        Me.tbQuantityChange = New System.Windows.Forms.TabPage()
        Me.Panel1Qua = New System.Windows.Forms.Panel()
        Me.Label7Qua = New System.Windows.Forms.Label()
        Me.txtChangedQtyCount = New System.Windows.Forms.TextBox()
        Me.DatagridViewQty = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Changed_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Original_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Changed_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diffrence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1Qua = New System.Windows.Forms.GroupBox()
        Me.btnExportExcelqua = New System.Windows.Forms.Button()
        Me.BtnPrintqua = New System.Windows.Forms.Button()
        Me.btnResetqua = New System.Windows.Forms.Button()
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
        Me.tbItemDeleted = New System.Windows.Forms.TabPage()
        Me.Panel1del = New System.Windows.Forms.Panel()
        Me.txtGrandTotaldl = New System.Windows.Forms.TextBox()
        Me.Label7del = New System.Windows.Forms.Label()
        Me.GroupBox1del = New System.Windows.Forms.GroupBox()
        Me.btnExportExceldl = New System.Windows.Forms.Button()
        Me.BtnPrintdl = New System.Windows.Forms.Button()
        Me.btnResetdl = New System.Windows.Forms.Button()
        Me.cmbPermissiondl = New System.Windows.Forms.ComboBox()
        Me.CmbBillTypedl = New System.Windows.Forms.ComboBox()
        Me.cmbOperatordl = New System.Windows.Forms.ComboBox()
        Me.txtBillNumberdl = New System.Windows.Forms.TextBox()
        Me.Label6del = New System.Windows.Forms.Label()
        Me.Label5del = New System.Windows.Forms.Label()
        Me.Label4del = New System.Windows.Forms.Label()
        Me.Label3del = New System.Windows.Forms.Label()
        Me.dtpDateTodl = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFromdl = New System.Windows.Forms.DateTimePicker()
        Me.Label2del = New System.Windows.Forms.Label()
        Me.Label1del = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPermission = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.CmbBillType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbOperator = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtBillNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DatagridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOriginalRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangedRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiffrence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtChangeRateSum = New System.Windows.Forms.TextBox()
        Me.txtRateDiffSum = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tbRateChange.SuspendLayout()
        Me.tbQuantityChange.SuspendLayout()
        Me.Panel1Qua.SuspendLayout()
        CType(Me.DatagridViewQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1Qua.SuspendLayout()
        Me.tbItemDeleted.SuspendLayout()
        Me.Panel1del.SuspendLayout()
        Me.GroupBox1del.SuspendLayout()
        CType(Me.DatagridViewItemDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbRateChange)
        Me.TabControl1.Controls.Add(Me.tbQuantityChange)
        Me.TabControl1.Controls.Add(Me.tbItemDeleted)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(919, 534)
        Me.TabControl1.TabIndex = 0
        '
        'tbRateChange
        '
        Me.tbRateChange.Controls.Add(Me.Panel1)
        Me.tbRateChange.Controls.Add(Me.DatagridView1)
        Me.tbRateChange.Controls.Add(Me.GroupBox1)
        Me.tbRateChange.Location = New System.Drawing.Point(4, 23)
        Me.tbRateChange.Name = "tbRateChange"
        Me.tbRateChange.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRateChange.Size = New System.Drawing.Size(911, 507)
        Me.tbRateChange.TabIndex = 0
        Me.tbRateChange.Text = "Rate Change Log"
        Me.tbRateChange.UseVisualStyleBackColor = True
        '
        'tbQuantityChange
        '
        Me.tbQuantityChange.Controls.Add(Me.Panel1Qua)
        Me.tbQuantityChange.Controls.Add(Me.DatagridViewQty)
        Me.tbQuantityChange.Controls.Add(Me.GroupBox1Qua)
        Me.tbQuantityChange.Location = New System.Drawing.Point(4, 23)
        Me.tbQuantityChange.Name = "tbQuantityChange"
        Me.tbQuantityChange.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuantityChange.Size = New System.Drawing.Size(911, 498)
        Me.tbQuantityChange.TabIndex = 1
        Me.tbQuantityChange.Text = "Quantity Change Log"
        Me.tbQuantityChange.UseVisualStyleBackColor = True
        '
        'Panel1Qua
        '
        Me.Panel1Qua.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1Qua.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1Qua.Controls.Add(Me.Label7Qua)
        Me.Panel1Qua.Controls.Add(Me.txtChangedQtyCount)
        Me.Panel1Qua.Location = New System.Drawing.Point(-4, 424)
        Me.Panel1Qua.Name = "Panel1Qua"
        Me.Panel1Qua.Size = New System.Drawing.Size(915, 74)
        Me.Panel1Qua.TabIndex = 3
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
        Me.txtChangedQtyCount.Size = New System.Drawing.Size(216, 22)
        Me.txtChangedQtyCount.TabIndex = 0
        '
        'DatagridViewQty
        '
        Me.DatagridViewQty.AllowUserToAddRows = False
        Me.DatagridViewQty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridViewQty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridViewQty.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridViewQty.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridViewQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridViewQty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Changed_Date, Me.Original_Quantity, Me.Changed_Quantity, Me.Diffrence, Me.Rate_Status, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DatagridViewQty.EnableHeadersVisualStyles = False
        Me.DatagridViewQty.Location = New System.Drawing.Point(-8, 152)
        Me.DatagridViewQty.Name = "DatagridViewQty"
        Me.DatagridViewQty.ReadOnly = True
        Me.DatagridViewQty.RowHeadersVisible = False
        Me.DatagridViewQty.Size = New System.Drawing.Size(919, 273)
        Me.DatagridViewQty.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bill Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dish Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bill Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Operator"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Permission Granted"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "comp_Id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Branch_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'GroupBox1Qua
        '
        Me.GroupBox1Qua.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1Qua.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1Qua.Controls.Add(Me.btnExportExcelqua)
        Me.GroupBox1Qua.Controls.Add(Me.BtnPrintqua)
        Me.GroupBox1Qua.Controls.Add(Me.btnResetqua)
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
        Me.GroupBox1Qua.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1Qua.Name = "GroupBox1Qua"
        Me.GroupBox1Qua.Size = New System.Drawing.Size(911, 158)
        Me.GroupBox1Qua.TabIndex = 1
        Me.GroupBox1Qua.TabStop = False
        Me.GroupBox1Qua.Text = "Search By Date"
        '
        'btnExportExcelqua
        '
        Me.btnExportExcelqua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcelqua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcelqua.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnExportExcelqua.Image = CType(resources.GetObject("btnExportExcelqua.Image"), System.Drawing.Image)
        Me.btnExportExcelqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcelqua.Location = New System.Drawing.Point(676, 113)
        Me.btnExportExcelqua.Name = "btnExportExcelqua"
        Me.btnExportExcelqua.Size = New System.Drawing.Size(124, 33)
        Me.btnExportExcelqua.TabIndex = 152
        Me.btnExportExcelqua.Text = "Export Excel"
        Me.btnExportExcelqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcelqua.UseVisualStyleBackColor = True
        '
        'BtnPrintqua
        '
        Me.BtnPrintqua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintqua.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintqua.Location = New System.Drawing.Point(676, 20)
        Me.BtnPrintqua.Name = "BtnPrintqua"
        Me.BtnPrintqua.Size = New System.Drawing.Size(124, 31)
        Me.BtnPrintqua.TabIndex = 150
        Me.BtnPrintqua.Text = "Print"
        Me.BtnPrintqua.UseVisualStyleBackColor = True
        '
        'btnResetqua
        '
        Me.btnResetqua.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetqua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetqua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetqua.ForeColor = System.Drawing.Color.Black
        Me.btnResetqua.Image = CType(resources.GetObject("btnResetqua.Image"), System.Drawing.Image)
        Me.btnResetqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetqua.Location = New System.Drawing.Point(676, 66)
        Me.btnResetqua.Name = "btnResetqua"
        Me.btnResetqua.Size = New System.Drawing.Size(124, 32)
        Me.btnResetqua.TabIndex = 151
        Me.btnResetqua.Text = "Reset"
        Me.btnResetqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResetqua.UseVisualStyleBackColor = False
        '
        'cmbPermissionQua
        '
        Me.cmbPermissionQua.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPermissionQua.FormattingEnabled = True
        Me.cmbPermissionQua.Location = New System.Drawing.Point(455, 121)
        Me.cmbPermissionQua.Name = "cmbPermissionQua"
        Me.cmbPermissionQua.Size = New System.Drawing.Size(145, 23)
        Me.cmbPermissionQua.TabIndex = 149
        '
        'CmbBillTypeQua
        '
        Me.CmbBillTypeQua.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBillTypeQua.FormattingEnabled = True
        Me.CmbBillTypeQua.Location = New System.Drawing.Point(455, 85)
        Me.CmbBillTypeQua.Name = "CmbBillTypeQua"
        Me.CmbBillTypeQua.Size = New System.Drawing.Size(145, 23)
        Me.CmbBillTypeQua.TabIndex = 148
        '
        'cmbOperatorQua
        '
        Me.cmbOperatorQua.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperatorQua.FormattingEnabled = True
        Me.cmbOperatorQua.Location = New System.Drawing.Point(455, 49)
        Me.cmbOperatorQua.Name = "cmbOperatorQua"
        Me.cmbOperatorQua.Size = New System.Drawing.Size(145, 23)
        Me.cmbOperatorQua.TabIndex = 147
        '
        'txtBillNumberQua
        '
        Me.txtBillNumberQua.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNumberQua.Location = New System.Drawing.Point(455, 14)
        Me.txtBillNumberQua.Name = "txtBillNumberQua"
        Me.txtBillNumberQua.Size = New System.Drawing.Size(145, 24)
        Me.txtBillNumberQua.TabIndex = 146
        '
        'Label6Qua
        '
        Me.Label6Qua.AutoSize = True
        Me.Label6Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6Qua.Location = New System.Drawing.Point(354, 128)
        Me.Label6Qua.Name = "Label6Qua"
        Me.Label6Qua.Size = New System.Drawing.Size(61, 14)
        Me.Label6Qua.TabIndex = 145
        Me.Label6Qua.Text = "Permission"
        '
        'Label5Qua
        '
        Me.Label5Qua.AutoSize = True
        Me.Label5Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5Qua.Location = New System.Drawing.Point(354, 92)
        Me.Label5Qua.Name = "Label5Qua"
        Me.Label5Qua.Size = New System.Drawing.Size(50, 14)
        Me.Label5Qua.TabIndex = 144
        Me.Label5Qua.Text = "Bill Type"
        '
        'Label4Qua
        '
        Me.Label4Qua.AutoSize = True
        Me.Label4Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4Qua.Location = New System.Drawing.Point(354, 56)
        Me.Label4Qua.Name = "Label4Qua"
        Me.Label4Qua.Size = New System.Drawing.Size(51, 14)
        Me.Label4Qua.TabIndex = 143
        Me.Label4Qua.Text = "Operator"
        '
        'Label3Qua
        '
        Me.Label3Qua.AutoSize = True
        Me.Label3Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3Qua.Location = New System.Drawing.Point(354, 20)
        Me.Label3Qua.Name = "Label3Qua"
        Me.Label3Qua.Size = New System.Drawing.Size(66, 14)
        Me.Label3Qua.TabIndex = 142
        Me.Label3Qua.Text = "Bill Number"
        '
        'dtpDateToQua
        '
        Me.dtpDateToQua.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateToQua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateToQua.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateToQua.Location = New System.Drawing.Point(86, 83)
        Me.dtpDateToQua.Name = "dtpDateToQua"
        Me.dtpDateToQua.Size = New System.Drawing.Size(195, 22)
        Me.dtpDateToQua.TabIndex = 135
        '
        'dtpDateFromQua
        '
        Me.dtpDateFromQua.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFromQua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFromQua.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFromQua.Location = New System.Drawing.Point(86, 28)
        Me.dtpDateFromQua.Name = "dtpDateFromQua"
        Me.dtpDateFromQua.Size = New System.Drawing.Size(195, 22)
        Me.dtpDateFromQua.TabIndex = 134
        '
        'Label2Qua
        '
        Me.Label2Qua.AutoSize = True
        Me.Label2Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2Qua.Location = New System.Drawing.Point(22, 83)
        Me.Label2Qua.Name = "Label2Qua"
        Me.Label2Qua.Size = New System.Drawing.Size(18, 14)
        Me.Label2Qua.TabIndex = 133
        Me.Label2Qua.Text = "To"
        '
        'Label1Qua
        '
        Me.Label1Qua.AutoSize = True
        Me.Label1Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1Qua.Location = New System.Drawing.Point(22, 28)
        Me.Label1Qua.Name = "Label1Qua"
        Me.Label1Qua.Size = New System.Drawing.Size(33, 14)
        Me.Label1Qua.TabIndex = 132
        Me.Label1Qua.Text = "From"
        '
        'tbItemDeleted
        '
        Me.tbItemDeleted.Controls.Add(Me.Panel1del)
        Me.tbItemDeleted.Controls.Add(Me.GroupBox1del)
        Me.tbItemDeleted.Controls.Add(Me.DatagridViewItemDel)
        Me.tbItemDeleted.Location = New System.Drawing.Point(4, 23)
        Me.tbItemDeleted.Name = "tbItemDeleted"
        Me.tbItemDeleted.Padding = New System.Windows.Forms.Padding(3)
        Me.tbItemDeleted.Size = New System.Drawing.Size(911, 498)
        Me.tbItemDeleted.TabIndex = 2
        Me.tbItemDeleted.Text = "Item Deleted"
        Me.tbItemDeleted.UseVisualStyleBackColor = True
        '
        'Panel1del
        '
        Me.Panel1del.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1del.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1del.Controls.Add(Me.txtGrandTotaldl)
        Me.Panel1del.Controls.Add(Me.Label7del)
        Me.Panel1del.ForeColor = System.Drawing.Color.White
        Me.Panel1del.Location = New System.Drawing.Point(0, 433)
        Me.Panel1del.Name = "Panel1del"
        Me.Panel1del.Size = New System.Drawing.Size(911, 65)
        Me.Panel1del.TabIndex = 5
        '
        'txtGrandTotaldl
        '
        Me.txtGrandTotaldl.Location = New System.Drawing.Point(420, 25)
        Me.txtGrandTotaldl.Name = "txtGrandTotaldl"
        Me.txtGrandTotaldl.ReadOnly = True
        Me.txtGrandTotaldl.Size = New System.Drawing.Size(180, 22)
        Me.txtGrandTotaldl.TabIndex = 5
        '
        'Label7del
        '
        Me.Label7del.AutoSize = True
        Me.Label7del.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7del.Location = New System.Drawing.Point(297, 25)
        Me.Label7del.Name = "Label7del"
        Me.Label7del.Size = New System.Drawing.Size(95, 17)
        Me.Label7del.TabIndex = 4
        Me.Label7del.Text = "Grand Total"
        '
        'GroupBox1del
        '
        Me.GroupBox1del.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1del.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1del.Controls.Add(Me.btnExportExceldl)
        Me.GroupBox1del.Controls.Add(Me.BtnPrintdl)
        Me.GroupBox1del.Controls.Add(Me.btnResetdl)
        Me.GroupBox1del.Controls.Add(Me.cmbPermissiondl)
        Me.GroupBox1del.Controls.Add(Me.CmbBillTypedl)
        Me.GroupBox1del.Controls.Add(Me.cmbOperatordl)
        Me.GroupBox1del.Controls.Add(Me.txtBillNumberdl)
        Me.GroupBox1del.Controls.Add(Me.Label6del)
        Me.GroupBox1del.Controls.Add(Me.Label5del)
        Me.GroupBox1del.Controls.Add(Me.Label4del)
        Me.GroupBox1del.Controls.Add(Me.Label3del)
        Me.GroupBox1del.Controls.Add(Me.dtpDateTodl)
        Me.GroupBox1del.Controls.Add(Me.dtpDateFromdl)
        Me.GroupBox1del.Controls.Add(Me.Label2del)
        Me.GroupBox1del.Controls.Add(Me.Label1del)
        Me.GroupBox1del.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1del.ForeColor = System.Drawing.Color.White
        Me.GroupBox1del.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1del.Name = "GroupBox1del"
        Me.GroupBox1del.Size = New System.Drawing.Size(915, 164)
        Me.GroupBox1del.TabIndex = 3
        Me.GroupBox1del.TabStop = False
        Me.GroupBox1del.Text = "Search By Date"
        '
        'btnExportExceldl
        '
        Me.btnExportExceldl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExceldl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnPrintdl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintdl.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintdl.Location = New System.Drawing.Point(676, 22)
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
        Me.btnResetdl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetdl.ForeColor = System.Drawing.Color.Black
        Me.btnResetdl.Image = CType(resources.GetObject("btnResetdl.Image"), System.Drawing.Image)
        Me.btnResetdl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetdl.Location = New System.Drawing.Point(676, 66)
        Me.btnResetdl.Name = "btnResetdl"
        Me.btnResetdl.Size = New System.Drawing.Size(124, 32)
        Me.btnResetdl.TabIndex = 151
        Me.btnResetdl.Text = "Reset"
        Me.btnResetdl.UseVisualStyleBackColor = False
        '
        'cmbPermissiondl
        '
        Me.cmbPermissiondl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPermissiondl.FormattingEnabled = True
        Me.cmbPermissiondl.Location = New System.Drawing.Point(455, 136)
        Me.cmbPermissiondl.Name = "cmbPermissiondl"
        Me.cmbPermissiondl.Size = New System.Drawing.Size(145, 22)
        Me.cmbPermissiondl.TabIndex = 149
        '
        'CmbBillTypedl
        '
        Me.CmbBillTypedl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBillTypedl.FormattingEnabled = True
        Me.CmbBillTypedl.Location = New System.Drawing.Point(455, 95)
        Me.CmbBillTypedl.Name = "CmbBillTypedl"
        Me.CmbBillTypedl.Size = New System.Drawing.Size(145, 22)
        Me.CmbBillTypedl.TabIndex = 148
        '
        'cmbOperatordl
        '
        Me.cmbOperatordl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperatordl.FormattingEnabled = True
        Me.cmbOperatordl.Location = New System.Drawing.Point(455, 54)
        Me.cmbOperatordl.Name = "cmbOperatordl"
        Me.cmbOperatordl.Size = New System.Drawing.Size(145, 22)
        Me.cmbOperatordl.TabIndex = 147
        '
        'txtBillNumberdl
        '
        Me.txtBillNumberdl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNumberdl.Location = New System.Drawing.Point(455, 14)
        Me.txtBillNumberdl.Name = "txtBillNumberdl"
        Me.txtBillNumberdl.Size = New System.Drawing.Size(145, 22)
        Me.txtBillNumberdl.TabIndex = 146
        '
        'Label6del
        '
        Me.Label6del.AutoSize = True
        Me.Label6del.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6del.Location = New System.Drawing.Point(356, 140)
        Me.Label6del.Name = "Label6del"
        Me.Label6del.Size = New System.Drawing.Size(61, 14)
        Me.Label6del.TabIndex = 145
        Me.Label6del.Text = "Permission"
        '
        'Label5del
        '
        Me.Label5del.AutoSize = True
        Me.Label5del.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5del.Location = New System.Drawing.Point(356, 99)
        Me.Label5del.Name = "Label5del"
        Me.Label5del.Size = New System.Drawing.Size(50, 14)
        Me.Label5del.TabIndex = 144
        Me.Label5del.Text = "Bill Type"
        '
        'Label4del
        '
        Me.Label4del.AutoSize = True
        Me.Label4del.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4del.Location = New System.Drawing.Point(356, 58)
        Me.Label4del.Name = "Label4del"
        Me.Label4del.Size = New System.Drawing.Size(51, 14)
        Me.Label4del.TabIndex = 143
        Me.Label4del.Text = "Operator"
        '
        'Label3del
        '
        Me.Label3del.AutoSize = True
        Me.Label3del.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3del.Location = New System.Drawing.Point(356, 17)
        Me.Label3del.Name = "Label3del"
        Me.Label3del.Size = New System.Drawing.Size(66, 14)
        Me.Label3del.TabIndex = 142
        Me.Label3del.Text = "Bill Number"
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
        'Label2del
        '
        Me.Label2del.AutoSize = True
        Me.Label2del.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2del.Location = New System.Drawing.Point(22, 83)
        Me.Label2del.Name = "Label2del"
        Me.Label2del.Size = New System.Drawing.Size(18, 14)
        Me.Label2del.TabIndex = 133
        Me.Label2del.Text = "To"
        '
        'Label1del
        '
        Me.Label1del.AutoSize = True
        Me.Label1del.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1del.Location = New System.Drawing.Point(22, 28)
        Me.Label1del.Name = "Label1del"
        Me.Label1del.Size = New System.Drawing.Size(33, 14)
        Me.Label1del.TabIndex = 132
        Me.Label1del.Text = "From"
        '
        'DatagridViewItemDel
        '
        Me.DatagridViewItemDel.AllowUserToAddRows = False
        Me.DatagridViewItemDel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridViewItemDel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridViewItemDel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridViewItemDel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridViewItemDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridViewItemDel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.BillNumber, Me.DishName, Me.Kot_Date, Me.table_No, Me.Quantity, Me.Rate, Me.Bill_Type, Me.Operator_, Me.Permission_Granted, Me.Remarks, Me.colComapnyId, Me.colBranchId})
        Me.DatagridViewItemDel.EnableHeadersVisualStyles = False
        Me.DatagridViewItemDel.Location = New System.Drawing.Point(-3, 169)
        Me.DatagridViewItemDel.Name = "DatagridViewItemDel"
        Me.DatagridViewItemDel.ReadOnly = True
        Me.DatagridViewItemDel.RowHeadersVisible = False
        Me.DatagridViewItemDel.Size = New System.Drawing.Size(918, 269)
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbPermission)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnExportExcel)
        Me.GroupBox1.Controls.Add(Me.CmbBillType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.cmbOperator)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Controls.Add(Me.txtBillNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 160)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serach by date"
        '
        'cmbPermission
        '
        Me.cmbPermission.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPermission.FormattingEnabled = True
        Me.cmbPermission.Location = New System.Drawing.Point(455, 118)
        Me.cmbPermission.Name = "cmbPermission"
        Me.cmbPermission.Size = New System.Drawing.Size(145, 22)
        Me.cmbPermission.TabIndex = 142
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 14)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Permission"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnExportExcel.Image = CType(resources.GetObject("btnExportExcel.Image"), System.Drawing.Image)
        Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcel.Location = New System.Drawing.Point(645, 100)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(114, 33)
        Me.btnExportExcel.TabIndex = 140
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'CmbBillType
        '
        Me.CmbBillType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBillType.FormattingEnabled = True
        Me.CmbBillType.Location = New System.Drawing.Point(455, 85)
        Me.CmbBillType.Name = "CmbBillType"
        Me.CmbBillType.Size = New System.Drawing.Size(145, 22)
        Me.CmbBillType.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 14)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Bill Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 14)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "To"
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.Location = New System.Drawing.Point(645, 22)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(114, 32)
        Me.BtnPrint.TabIndex = 130
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(645, 61)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 32)
        Me.btnReset.TabIndex = 133
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cmbOperator
        '
        Me.cmbOperator.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator.FormattingEnabled = True
        Me.cmbOperator.Location = New System.Drawing.Point(455, 52)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(145, 22)
        Me.cmbOperator.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(367, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 14)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Operator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "From"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(77, 73)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(195, 22)
        Me.dtpDateTo.TabIndex = 108
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(77, 25)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(195, 22)
        Me.dtpDateFrom.TabIndex = 107
        '
        'txtBillNumber
        '
        Me.txtBillNumber.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNumber.Location = New System.Drawing.Point(455, 19)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.Size = New System.Drawing.Size(145, 22)
        Me.txtBillNumber.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Bill Number"
        '
        'DatagridView1
        '
        Me.DatagridView1.AllowUserToAddRows = False
        Me.DatagridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.colBillNumber, Me.colDishName, Me.colChangedDate, Me.colOriginalRate, Me.colChangedRate, Me.colDiffrence, Me.colStatus, Me.colBillType, Me.colOperator, Me.colPermission, Me.colRemarks, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.DatagridView1.EnableHeadersVisualStyles = False
        Me.DatagridView1.Location = New System.Drawing.Point(3, 155)
        Me.DatagridView1.Name = "DatagridView1"
        Me.DatagridView1.ReadOnly = True
        Me.DatagridView1.RowHeadersVisible = False
        Me.DatagridView1.Size = New System.Drawing.Size(912, 295)
        Me.DatagridView1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'colBillNumber
        '
        Me.colBillNumber.HeaderText = "Bill Number"
        Me.colBillNumber.Name = "colBillNumber"
        Me.colBillNumber.ReadOnly = True
        '
        'colDishName
        '
        Me.colDishName.HeaderText = "Dish Name"
        Me.colDishName.Name = "colDishName"
        Me.colDishName.ReadOnly = True
        '
        'colChangedDate
        '
        Me.colChangedDate.HeaderText = "Changed Date"
        Me.colChangedDate.Name = "colChangedDate"
        Me.colChangedDate.ReadOnly = True
        '
        'colOriginalRate
        '
        Me.colOriginalRate.HeaderText = "Original Rate"
        Me.colOriginalRate.Name = "colOriginalRate"
        Me.colOriginalRate.ReadOnly = True
        '
        'colChangedRate
        '
        Me.colChangedRate.HeaderText = "Changed Rate"
        Me.colChangedRate.Name = "colChangedRate"
        Me.colChangedRate.ReadOnly = True
        '
        'colDiffrence
        '
        Me.colDiffrence.HeaderText = "Diffrence"
        Me.colDiffrence.Name = "colDiffrence"
        Me.colDiffrence.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Rate Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'colBillType
        '
        Me.colBillType.HeaderText = "Bill Type"
        Me.colBillType.Name = "colBillType"
        Me.colBillType.ReadOnly = True
        '
        'colOperator
        '
        Me.colOperator.HeaderText = "Operator"
        Me.colOperator.Name = "colOperator"
        Me.colOperator.ReadOnly = True
        '
        'colPermission
        '
        Me.colPermission.HeaderText = "Permission Granted"
        Me.colPermission.Name = "colPermission"
        Me.colPermission.ReadOnly = True
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "comp_Id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Branch_ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtChangeRateSum)
        Me.Panel1.Controls.Add(Me.txtRateDiffSum)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 447)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 64)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(365, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Grand Total Of Changed Rate"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Grand Total of Rate Diffrence"
        '
        'txtChangeRateSum
        '
        Me.txtChangeRateSum.Location = New System.Drawing.Point(537, 28)
        Me.txtChangeRateSum.Name = "txtChangeRateSum"
        Me.txtChangeRateSum.ReadOnly = True
        Me.txtChangeRateSum.Size = New System.Drawing.Size(154, 22)
        Me.txtChangeRateSum.TabIndex = 6
        '
        'txtRateDiffSum
        '
        Me.txtRateDiffSum.Location = New System.Drawing.Point(190, 28)
        Me.txtRateDiffSum.Name = "txtRateDiffSum"
        Me.txtRateDiffSum.ReadOnly = True
        Me.txtRateDiffSum.Size = New System.Drawing.Size(154, 22)
        Me.txtRateDiffSum.TabIndex = 5
        '
        'frmRateQtyItemLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 534)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmRateQtyItemLog"
        Me.Text = "frmRateQtyItemLog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbRateChange.ResumeLayout(False)
        Me.tbQuantityChange.ResumeLayout(False)
        Me.Panel1Qua.ResumeLayout(False)
        Me.Panel1Qua.PerformLayout()
        CType(Me.DatagridViewQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1Qua.ResumeLayout(False)
        Me.GroupBox1Qua.PerformLayout()
        Me.tbItemDeleted.ResumeLayout(False)
        Me.Panel1del.ResumeLayout(False)
        Me.Panel1del.PerformLayout()
        Me.GroupBox1del.ResumeLayout(False)
        Me.GroupBox1del.PerformLayout()
        CType(Me.DatagridViewItemDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbRateChange As TabPage
    Friend WithEvents tbQuantityChange As TabPage
    Friend WithEvents tbItemDeleted As TabPage
    Friend WithEvents DatagridViewItemDel As DataGridView
    Friend WithEvents GroupBox1del As GroupBox
    Friend WithEvents btnExportExceldl As Button
    Friend WithEvents BtnPrintdl As Button
    Friend WithEvents btnResetdl As Button
    Friend WithEvents cmbPermissiondl As ComboBox
    Friend WithEvents CmbBillTypedl As ComboBox
    Friend WithEvents cmbOperatordl As ComboBox
    Friend WithEvents txtBillNumberdl As TextBox
    Friend WithEvents Label6del As Label
    Friend WithEvents Label5del As Label
    Friend WithEvents Label4del As Label
    Friend WithEvents Label3del As Label
    Friend WithEvents dtpDateTodl As DateTimePicker
    Friend WithEvents dtpDateFromdl As DateTimePicker
    Friend WithEvents Label2del As Label
    Friend WithEvents Label1del As Label
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
    Friend WithEvents Panel1del As Panel
    Friend WithEvents txtGrandTotaldl As TextBox
    Friend WithEvents Label7del As Label
    Friend WithEvents GroupBox1Qua As GroupBox
    Friend WithEvents btnExportExcelqua As Button
    Friend WithEvents BtnPrintqua As Button
    Friend WithEvents btnResetqua As Button
    Friend WithEvents cmbPermissionQua As ComboBox
    Friend WithEvents CmbBillTypeQua As ComboBox
    Friend WithEvents cmbOperatorQua As ComboBox
    Friend WithEvents txtBillNumberQua As TextBox
    Friend WithEvents Label6Qua As Label
    Friend WithEvents Label5Qua As Label
    Friend WithEvents Label4Qua As Label
    Friend WithEvents Label3Qua As Label
    Friend WithEvents dtpDateToQua As DateTimePicker
    Friend WithEvents dtpDateFromQua As DateTimePicker
    Friend WithEvents Label2Qua As Label
    Friend WithEvents Label1Qua As Label
    Friend WithEvents DatagridViewQty As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Changed_Date As DataGridViewTextBoxColumn
    Friend WithEvents Original_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Changed_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Diffrence As DataGridViewTextBoxColumn
    Friend WithEvents Rate_Status As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1Qua As Panel
    Friend WithEvents Label7Qua As Label
    Friend WithEvents txtChangedQtyCount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbPermission As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents CmbBillType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbOperator As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents txtBillNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DatagridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents colBillNumber As DataGridViewTextBoxColumn
    Friend WithEvents colDishName As DataGridViewTextBoxColumn
    Friend WithEvents colChangedDate As DataGridViewTextBoxColumn
    Friend WithEvents colOriginalRate As DataGridViewTextBoxColumn
    Friend WithEvents colChangedRate As DataGridViewTextBoxColumn
    Friend WithEvents colDiffrence As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colBillType As DataGridViewTextBoxColumn
    Friend WithEvents colOperator As DataGridViewTextBoxColumn
    Friend WithEvents colPermission As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtChangeRateSum As TextBox
    Friend WithEvents txtRateDiffSum As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
