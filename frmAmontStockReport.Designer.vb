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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Operator_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.DgwKotAmountReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(235, 58)
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
        Me.cmbFoodTime.Location = New System.Drawing.Point(297, 57)
        Me.cmbFoodTime.Name = "cmbFoodTime"
        Me.cmbFoodTime.Size = New System.Drawing.Size(145, 22)
        Me.cmbFoodTime.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(235, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Operator"
        '
        'cmbOperator
        '
        Me.cmbOperator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOperator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOperator.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator.FormattingEnabled = True
        Me.cmbOperator.Location = New System.Drawing.Point(296, 13)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(145, 22)
        Me.cmbOperator.TabIndex = 156
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(48, 13)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(145, 22)
        Me.dtpDateFrom.TabIndex = 155
        '
        'Label1Qua
        '
        Me.Label1Qua.AutoSize = True
        Me.Label1Qua.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1Qua.ForeColor = System.Drawing.Color.White
        Me.Label1Qua.Location = New System.Drawing.Point(8, 18)
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
        Me.Label2Qua.Location = New System.Drawing.Point(13, 55)
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
        Me.dtpDateTo.Location = New System.Drawing.Point(48, 52)
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
        Me.BtnPrint.Location = New System.Drawing.Point(12, 7)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwKotAmountReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgwKotAmountReport.ColumnHeadersHeight = 40
        Me.DgwKotAmountReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Operator_, Me.BillDate, Me.DI, Me.TA, Me.HD, Me.TP, Me.Amount})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwKotAmountReport.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgwKotAmountReport.EnableHeadersVisualStyles = False
        Me.DgwKotAmountReport.Location = New System.Drawing.Point(0, 153)
        Me.DgwKotAmountReport.Name = "DgwKotAmountReport"
        Me.DgwKotAmountReport.ReadOnly = True
        Me.DgwKotAmountReport.RowHeadersVisible = False
        Me.DgwKotAmountReport.RowTemplate.Height = 25
        Me.DgwKotAmountReport.Size = New System.Drawing.Size(801, 299)
        Me.DgwKotAmountReport.TabIndex = 14
        '
        'Operator_
        '
        Me.Operator_.HeaderText = "Operator"
        Me.Operator_.Name = "Operator_"
        Me.Operator_.ReadOnly = True
        Me.Operator_.Visible = False
        '
        'BillDate
        '
        Me.BillDate.HeaderText = "Bill Date"
        Me.BillDate.Name = "BillDate"
        Me.BillDate.ReadOnly = True
        Me.BillDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        Me.Panel1.Location = New System.Drawing.Point(596, 53)
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
        'frmKotAmontReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 453)
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
    Friend WithEvents Operator_ As DataGridViewTextBoxColumn
    Friend WithEvents BillDate As DataGridViewTextBoxColumn
    Friend WithEvents DI As DataGridViewTextBoxColumn
    Friend WithEvents TA As DataGridViewTextBoxColumn
    Friend WithEvents HD As DataGridViewTextBoxColumn
    Friend WithEvents TP As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
End Class
