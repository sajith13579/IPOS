<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDishRateChangeLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDishRateChangeLog))
        Me.DatagridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.SearchRadio = New System.Windows.Forms.RadioButton()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbBillType = New System.Windows.Forms.ComboBox()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPermission = New System.Windows.Forms.ComboBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOriginalRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangedRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiffrence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComapnyId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatagridView1
        '
        Me.DatagridView1.AllowUserToAddRows = False
        Me.DatagridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DatagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colBillNumber, Me.colChangedDate, Me.colOriginalRate, Me.colChangedRate, Me.colDiffrence, Me.colBillType, Me.colOperator, Me.colPermission, Me.colRemarks, Me.colComapnyId, Me.colBranchId})
        Me.DatagridView1.Location = New System.Drawing.Point(1, 181)
        Me.DatagridView1.Name = "DatagridView1"
        Me.DatagridView1.ReadOnly = True
        Me.DatagridView1.Size = New System.Drawing.Size(1003, 334)
        Me.DatagridView1.TabIndex = 0
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
        Me.GroupBox1.Controls.Add(Me.bttnSearch)
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
        Me.GroupBox1.Controls.Add(Me.SearchRadio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serach by date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 20)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "To"
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.Location = New System.Drawing.Point(791, 18)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(178, 35)
        Me.BtnPrint.TabIndex = 130
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
        Me.btnReset.Location = New System.Drawing.Point(791, 63)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(178, 35)
        Me.btnReset.TabIndex = 133
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cmbOperator
        '
        Me.cmbOperator.FormattingEnabled = True
        Me.cmbOperator.Location = New System.Drawing.Point(568, 63)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(145, 28)
        Me.cmbOperator.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Operator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "From"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(114, 76)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(195, 26)
        Me.dtpDateTo.TabIndex = 108
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(114, 25)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(195, 26)
        Me.dtpDateFrom.TabIndex = 107
        '
        'txtBillNumber
        '
        Me.txtBillNumber.Location = New System.Drawing.Point(568, 27)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.Size = New System.Drawing.Size(145, 26)
        Me.txtBillNumber.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Bill Number"
        '
        'SearchRadio
        '
        Me.SearchRadio.AutoSize = True
        Me.SearchRadio.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SearchRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchRadio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SearchRadio.Location = New System.Drawing.Point(332, 18)
        Me.SearchRadio.Name = "SearchRadio"
        Me.SearchRadio.Size = New System.Drawing.Size(99, 29)
        Me.SearchRadio.TabIndex = 136
        Me.SearchRadio.TabStop = True
        Me.SearchRadio.Text = "Search"
        Me.SearchRadio.UseVisualStyleBackColor = False
        Me.SearchRadio.Visible = False
        '
        'bttnSearch
        '
        Me.bttnSearch.Location = New System.Drawing.Point(114, 118)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(195, 26)
        Me.bttnSearch.TabIndex = 137
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Bill Type"
        '
        'CmbBillType
        '
        Me.CmbBillType.FormattingEnabled = True
        Me.CmbBillType.Location = New System.Drawing.Point(568, 100)
        Me.CmbBillType.Name = "CmbBillType"
        Me.CmbBillType.Size = New System.Drawing.Size(145, 28)
        Me.CmbBillType.TabIndex = 139
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnExportExcel.Image = CType(resources.GetObject("btnExportExcel.Image"), System.Drawing.Image)
        Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcel.Location = New System.Drawing.Point(791, 110)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(178, 34)
        Me.btnExportExcel.TabIndex = 140
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Permission"
        '
        'cmbPermission
        '
        Me.cmbPermission.FormattingEnabled = True
        Me.cmbPermission.Location = New System.Drawing.Point(568, 134)
        Me.cmbPermission.Name = "cmbPermission"
        Me.cmbPermission.Size = New System.Drawing.Size(145, 28)
        Me.cmbPermission.TabIndex = 142
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colBillNumber
        '
        Me.colBillNumber.HeaderText = "Bill Number"
        Me.colBillNumber.Name = "colBillNumber"
        Me.colBillNumber.ReadOnly = True
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
        Me.colPermission.HeaderText = "Permission"
        Me.colPermission.Name = "colPermission"
        Me.colPermission.ReadOnly = True
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
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
        'frmDishRateChangeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DatagridView1)
        Me.Name = "frmDishRateChangeLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDishRateChangeLog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatagridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBillNumber As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbOperator As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchRadio As RadioButton
    Friend WithEvents bttnSearch As Button
    Friend WithEvents CmbBillType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colBillNumber As DataGridViewTextBoxColumn
    Friend WithEvents colChangedDate As DataGridViewTextBoxColumn
    Friend WithEvents colOriginalRate As DataGridViewTextBoxColumn
    Friend WithEvents colChangedRate As DataGridViewTextBoxColumn
    Friend WithEvents colDiffrence As DataGridViewTextBoxColumn
    Friend WithEvents colBillType As DataGridViewTextBoxColumn
    Friend WithEvents colOperator As DataGridViewTextBoxColumn
    Friend WithEvents colPermission As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents colComapnyId As DataGridViewTextBoxColumn
    Friend WithEvents colBranchId As DataGridViewTextBoxColumn
    Friend WithEvents cmbPermission As ComboBox
    Friend WithEvents Label6 As Label
End Class
