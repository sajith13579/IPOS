<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKotAmontReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKotAmontReport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkOperatorWise = New System.Windows.Forms.CheckBox()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFoodTime = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOperator = New System.Windows.Forms.ComboBox()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1Qua = New System.Windows.Forms.Label()
        Me.Label2Qua = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.DgwKotAmountReport = New System.Windows.Forms.DataGridView()
        Me.BillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operator_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtTotalTP = New System.Windows.Forms.TextBox()
        Me.txtTotalHD = New System.Windows.Forms.TextBox()
        Me.txtTotalTA = New System.Windows.Forms.TextBox()
        Me.txtTotalDI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotAmount = New System.Windows.Forms.Label()
        Me.lblTP = New System.Windows.Forms.Label()
        Me.lblHD = New System.Windows.Forms.Label()
        Me.lblTA = New System.Windows.Forms.Label()
        Me.lblDi = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.DgwKotAmountReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel3.Controls.Add(Me.chkOperatorWise)
        Me.Panel3.Controls.Add(Me.bttnSearch)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cmbFoodTime)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmbOperator)
        Me.Panel3.Controls.Add(Me.dtpDateFrom)
        Me.Panel3.Controls.Add(Me.Label1Qua)
        Me.Panel3.Controls.Add(Me.Label2Qua)
        Me.Panel3.Controls.Add(Me.dtpDateTo)
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(590, 94)
        Me.Panel3.TabIndex = 13
        '
        'chkOperatorWise
        '
        Me.chkOperatorWise.AutoSize = True
        Me.chkOperatorWise.ForeColor = System.Drawing.Color.White
        Me.chkOperatorWise.Location = New System.Drawing.Point(460, 62)
        Me.chkOperatorWise.Name = "chkOperatorWise"
        Me.chkOperatorWise.Size = New System.Drawing.Size(91, 17)
        Me.chkOperatorWise.TabIndex = 162
        Me.chkOperatorWise.Text = "OperatorWise"
        Me.chkOperatorWise.UseVisualStyleBackColor = True
        '
        'bttnSearch
        '
        Me.bttnSearch.BackColor = System.Drawing.Color.LimeGreen
        Me.bttnSearch.ForeColor = System.Drawing.Color.White
        Me.bttnSearch.Image = CType(resources.GetObject("bttnSearch.Image"), System.Drawing.Image)
        Me.bttnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnSearch.Location = New System.Drawing.Point(456, 10)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(89, 29)
        Me.bttnSearch.TabIndex = 160
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnSearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(234, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Foodtime"
        '
        'cmbFoodTime
        '
        Me.cmbFoodTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFoodTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFoodTime.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFoodTime.FormattingEnabled = True
        Me.cmbFoodTime.Location = New System.Drawing.Point(306, 60)
        Me.cmbFoodTime.Name = "cmbFoodTime"
        Me.cmbFoodTime.Size = New System.Drawing.Size(145, 22)
        Me.cmbFoodTime.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Operator"
        '
        'cmbOperator
        '
        Me.cmbOperator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOperator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOperator.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator.FormattingEnabled = True
        Me.cmbOperator.Location = New System.Drawing.Point(66, 57)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(145, 22)
        Me.cmbOperator.TabIndex = 156
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(65, 12)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(145, 22)
        Me.dtpDateFrom.TabIndex = 155
        '
        'Label1Qua
        '
        Me.Label1Qua.AutoSize = True
        Me.Label1Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1Qua.ForeColor = System.Drawing.Color.White
        Me.Label1Qua.Location = New System.Drawing.Point(8, 16)
        Me.Label1Qua.Name = "Label1Qua"
        Me.Label1Qua.Size = New System.Drawing.Size(33, 14)
        Me.Label1Qua.TabIndex = 138
        Me.Label1Qua.Text = "From"
        '
        'Label2Qua
        '
        Me.Label2Qua.AutoSize = True
        Me.Label2Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2Qua.ForeColor = System.Drawing.Color.White
        Me.Label2Qua.Location = New System.Drawing.Point(234, 16)
        Me.Label2Qua.Name = "Label2Qua"
        Me.Label2Qua.Size = New System.Drawing.Size(18, 14)
        Me.Label2Qua.TabIndex = 137
        Me.Label2Qua.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(305, 13)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(145, 22)
        Me.dtpDateTo.TabIndex = 136
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(12, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(115, 38)
        Me.BtnPrint.TabIndex = 154
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'DgwKotAmountReport
        '
        Me.DgwKotAmountReport.AllowUserToAddRows = False
        Me.DgwKotAmountReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgwKotAmountReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgwKotAmountReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgwKotAmountReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwKotAmountReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgwKotAmountReport.ColumnHeadersHeight = 40
        Me.DgwKotAmountReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillDate, Me.Operator_, Me.DI, Me.TA, Me.HD, Me.TP, Me.Amount})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwKotAmountReport.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgwKotAmountReport.EnableHeadersVisualStyles = False
        Me.DgwKotAmountReport.Location = New System.Drawing.Point(0, 150)
        Me.DgwKotAmountReport.Name = "DgwKotAmountReport"
        Me.DgwKotAmountReport.ReadOnly = True
        Me.DgwKotAmountReport.RowHeadersVisible = False
        Me.DgwKotAmountReport.RowTemplate.Height = 25
        Me.DgwKotAmountReport.Size = New System.Drawing.Size(801, 235)
        Me.DgwKotAmountReport.TabIndex = 14
        '
        'BillDate
        '
        Me.BillDate.HeaderText = "Bill Date"
        Me.BillDate.Name = "BillDate"
        Me.BillDate.ReadOnly = True
        Me.BillDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Operator_
        '
        Me.Operator_.HeaderText = "Operator"
        Me.Operator_.Name = "Operator_"
        Me.Operator_.ReadOnly = True
        '
        'DI
        '
        Me.DI.HeaderText = "DI"
        Me.DI.Name = "DI"
        Me.DI.ReadOnly = True
        Me.DI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TA
        '
        Me.TA.HeaderText = "TA"
        Me.TA.Name = "TA"
        Me.TA.ReadOnly = True
        Me.TA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'HD
        '
        Me.HD.HeaderText = "HD"
        Me.HD.Name = "HD"
        Me.HD.ReadOnly = True
        Me.HD.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TP
        '
        Me.TP.HeaderText = "TP"
        Me.TP.Name = "TP"
        Me.TP.ReadOnly = True
        Me.TP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(804, 47)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "KOT Amount  Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bntClose
        '
        Me.bntClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntClose.BackColor = System.Drawing.Color.Red
        Me.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClose.Location = New System.Drawing.Point(732, 3)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(69, 44)
        Me.bntClose.TabIndex = 365
        Me.bntClose.Text = "X"
        Me.bntClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExportExcel)
        Me.Panel1.Controls.Add(Me.BtnPrint)
        Me.Panel1.Location = New System.Drawing.Point(593, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 93)
        Me.Panel1.TabIndex = 366
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnExportExcel.Image = CType(resources.GetObject("btnExportExcel.Image"), System.Drawing.Image)
        Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcel.Location = New System.Drawing.Point(12, 51)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(115, 38)
        Me.btnExportExcel.TabIndex = 155
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtTotalAmount)
        Me.Panel2.Controls.Add(Me.txtTotalTP)
        Me.Panel2.Controls.Add(Me.txtTotalHD)
        Me.Panel2.Controls.Add(Me.txtTotalTA)
        Me.Panel2.Controls.Add(Me.txtTotalDI)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblTotAmount)
        Me.Panel2.Controls.Add(Me.lblTP)
        Me.Panel2.Controls.Add(Me.lblHD)
        Me.Panel2.Controls.Add(Me.lblTA)
        Me.Panel2.Controls.Add(Me.lblDi)
        Me.Panel2.Location = New System.Drawing.Point(0, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 62)
        Me.Panel2.TabIndex = 367
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAmount.Location = New System.Drawing.Point(712, 32)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(78, 20)
        Me.txtTotalAmount.TabIndex = 10
        '
        'txtTotalTP
        '
        Me.txtTotalTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalTP.Location = New System.Drawing.Point(600, 32)
        Me.txtTotalTP.Name = "txtTotalTP"
        Me.txtTotalTP.ReadOnly = True
        Me.txtTotalTP.Size = New System.Drawing.Size(78, 20)
        Me.txtTotalTP.TabIndex = 9
        '
        'txtTotalHD
        '
        Me.txtTotalHD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalHD.Location = New System.Drawing.Point(486, 32)
        Me.txtTotalHD.Name = "txtTotalHD"
        Me.txtTotalHD.ReadOnly = True
        Me.txtTotalHD.Size = New System.Drawing.Size(78, 20)
        Me.txtTotalHD.TabIndex = 8
        '
        'txtTotalTA
        '
        Me.txtTotalTA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalTA.Location = New System.Drawing.Point(374, 32)
        Me.txtTotalTA.Name = "txtTotalTA"
        Me.txtTotalTA.ReadOnly = True
        Me.txtTotalTA.Size = New System.Drawing.Size(77, 20)
        Me.txtTotalTA.TabIndex = 7
        '
        'txtTotalDI
        '
        Me.txtTotalDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDI.Location = New System.Drawing.Point(261, 32)
        Me.txtTotalDI.Name = "txtTotalDI"
        Me.txtTotalDI.ReadOnly = True
        Me.txtTotalDI.Size = New System.Drawing.Size(78, 20)
        Me.txtTotalDI.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total"
        '
        'lblTotAmount
        '
        Me.lblTotAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotAmount.AutoSize = True
        Me.lblTotAmount.ForeColor = System.Drawing.Color.White
        Me.lblTotAmount.Location = New System.Drawing.Point(711, 11)
        Me.lblTotAmount.Name = "lblTotAmount"
        Me.lblTotAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblTotAmount.TabIndex = 4
        Me.lblTotAmount.Text = "Amount"
        '
        'lblTP
        '
        Me.lblTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTP.AutoSize = True
        Me.lblTP.ForeColor = System.Drawing.Color.White
        Me.lblTP.Location = New System.Drawing.Point(600, 11)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(21, 13)
        Me.lblTP.TabIndex = 3
        Me.lblTP.Text = "TP"
        '
        'lblHD
        '
        Me.lblHD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHD.AutoSize = True
        Me.lblHD.ForeColor = System.Drawing.Color.White
        Me.lblHD.Location = New System.Drawing.Point(486, 11)
        Me.lblHD.Name = "lblHD"
        Me.lblHD.Size = New System.Drawing.Size(23, 13)
        Me.lblHD.TabIndex = 2
        Me.lblHD.Text = "HD"
        '
        'lblTA
        '
        Me.lblTA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTA.AutoSize = True
        Me.lblTA.ForeColor = System.Drawing.Color.White
        Me.lblTA.Location = New System.Drawing.Point(373, 11)
        Me.lblTA.Name = "lblTA"
        Me.lblTA.Size = New System.Drawing.Size(21, 13)
        Me.lblTA.TabIndex = 1
        Me.lblTA.Text = "TA"
        '
        'lblDi
        '
        Me.lblDi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDi.AutoSize = True
        Me.lblDi.ForeColor = System.Drawing.Color.White
        Me.lblDi.Location = New System.Drawing.Point(261, 11)
        Me.lblDi.Name = "lblDi"
        Me.lblDi.Size = New System.Drawing.Size(18, 13)
        Me.lblDi.TabIndex = 0
        Me.lblDi.Text = "DI"
        '
        'frmKotAmontReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgwKotAmountReport)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKotAmontReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DgwKotAmountReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label1Qua As Label
    Friend WithEvents Label2Qua As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents DgwKotAmountReport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bntClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbOperator As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbFoodTime As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents bttnSearch As Button
    Friend WithEvents BillDate As DataGridViewTextBoxColumn
    Friend WithEvents Operator_ As DataGridViewTextBoxColumn
    Friend WithEvents DI As DataGridViewTextBoxColumn
    Friend WithEvents TA As DataGridViewTextBoxColumn
    Friend WithEvents HD As DataGridViewTextBoxColumn
    Friend WithEvents TP As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents chkOperatorWise As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDi As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtTotalTP As TextBox
    Friend WithEvents txtTotalHD As TextBox
    Friend WithEvents txtTotalTA As TextBox
    Friend WithEvents txtTotalDI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotAmount As Label
    Friend WithEvents lblTP As Label
    Friend WithEvents lblHD As Label
    Friend WithEvents lblTA As Label
End Class
