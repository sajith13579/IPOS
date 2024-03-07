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
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOriginalRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangedRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBillNumber = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbOperator = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatagridView1
        '
        Me.DatagridView1.AllowUserToAddRows = False
        Me.DatagridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colBillNumber, Me.colChangedDate, Me.colOriginalRate, Me.colChangedRate, Me.colOperator, Me.colPermission, Me.colRemarks})
        Me.DatagridView1.Location = New System.Drawing.Point(0, 179)
        Me.DatagridView1.Name = "DatagridView1"
        Me.DatagridView1.ReadOnly = True
        Me.DatagridView1.Size = New System.Drawing.Size(1005, 335)
        Me.DatagridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bttnSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 133)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serach by date"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(114, 19)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(195, 26)
        Me.dtpDateFrom.TabIndex = 107
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(114, 64)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(195, 26)
        Me.dtpDateTo.TabIndex = 108
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(856, 12)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(136, 26)
        Me.BtnPrint.TabIndex = 130
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "To"
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
        'bttnSearch
        '
        Me.bttnSearch.Location = New System.Drawing.Point(114, 104)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(195, 23)
        Me.bttnSearch.TabIndex = 131
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Bill Number"
        '
        'txtBillNumber
        '
        Me.txtBillNumber.Location = New System.Drawing.Point(415, 56)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.Size = New System.Drawing.Size(145, 20)
        Me.txtBillNumber.TabIndex = 132
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(856, 70)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(136, 42)
        Me.btnReset.TabIndex = 133
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cmbOperator
        '
        Me.cmbOperator.FormattingEnabled = True
        Me.cmbOperator.Location = New System.Drawing.Point(415, 116)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(145, 21)
        Me.cmbOperator.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Operator"
        '
        'frmDishRateChangeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 513)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbOperator)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtBillNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DatagridView1)
        Me.Name = "frmDishRateChangeLog"
        Me.Text = "frmDishRateChangeLog"
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatagridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents BtnPrint As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colBillNumber As DataGridViewTextBoxColumn
    Friend WithEvents colChangedDate As DataGridViewTextBoxColumn
    Friend WithEvents colOriginalRate As DataGridViewTextBoxColumn
    Friend WithEvents colChangedRate As DataGridViewTextBoxColumn
    Friend WithEvents colOperator As DataGridViewTextBoxColumn
    Friend WithEvents colPermission As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnSearch As Button
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBillNumber As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbOperator As ComboBox
    Friend WithEvents Label4 As Label
End Class
