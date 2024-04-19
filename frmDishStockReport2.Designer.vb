<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDishStockReport2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDishStockReport2))
        Me.DatagridViewstock = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label1Qua = New System.Windows.Forms.Label()
        Me.Label2Qua = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Management = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complimtry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dispose_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DatagridViewstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatagridViewstock
        '
        Me.DatagridViewstock.AllowUserToAddRows = False
        Me.DatagridViewstock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridViewstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridViewstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DatagridViewstock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridViewstock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridViewstock.ColumnHeadersHeight = 40
        Me.DatagridViewstock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillDate, Me.DataGridViewTextBoxColumn3, Me.Qty, Me.Staff, Me.Management, Me.OtherStaff, Me.Complimtry, Me.Dispose_, Me.DI, Me.TA, Me.HD, Me.TP, Me.Balance})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridViewstock.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridViewstock.EnableHeadersVisualStyles = False
        Me.DatagridViewstock.Location = New System.Drawing.Point(1, 100)
        Me.DatagridViewstock.Name = "DatagridViewstock"
        Me.DatagridViewstock.ReadOnly = True
        Me.DatagridViewstock.RowHeadersVisible = False
        Me.DatagridViewstock.RowTemplate.Height = 25
        Me.DatagridViewstock.Size = New System.Drawing.Size(896, 352)
        Me.DatagridViewstock.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel3.Controls.Add(Me.dtpDateFrom)
        Me.Panel3.Controls.Add(Me.BtnPrint)
        Me.Panel3.Controls.Add(Me.Label1Qua)
        Me.Panel3.Controls.Add(Me.Label2Qua)
        Me.Panel3.Controls.Add(Me.dtpDateTo)
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(896, 46)
        Me.Panel3.TabIndex = 15
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(47, 15)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(145, 22)
        Me.dtpDateFrom.TabIndex = 155
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(799, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(85, 32)
        Me.BtnPrint.TabIndex = 154
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.UseVisualStyleBackColor = True
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
        Me.Label2Qua.Location = New System.Drawing.Point(206, 19)
        Me.Label2Qua.Name = "Label2Qua"
        Me.Label2Qua.Size = New System.Drawing.Size(18, 14)
        Me.Label2Qua.TabIndex = 137
        Me.Label2Qua.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(234, 15)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(145, 22)
        Me.dtpDateTo.TabIndex = 136
        '
        'bntClose
        '
        Me.bntClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntClose.BackColor = System.Drawing.Color.Red
        Me.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClose.Location = New System.Drawing.Point(828, 3)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(69, 44)
        Me.bntClose.TabIndex = 364
        Me.bntClose.Text = "X"
        Me.bntClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(895, 45)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "Dish Stock Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BillDate
        '
        Me.BillDate.HeaderText = "Bill Date"
        Me.BillDate.Name = "BillDate"
        Me.BillDate.ReadOnly = True
        Me.BillDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dish Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Staff
        '
        Me.Staff.HeaderText = "Staff"
        Me.Staff.Name = "Staff"
        Me.Staff.ReadOnly = True
        Me.Staff.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Management
        '
        Me.Management.HeaderText = "Management"
        Me.Management.Name = "Management"
        Me.Management.ReadOnly = True
        Me.Management.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'OtherStaff
        '
        Me.OtherStaff.HeaderText = "Other Staff"
        Me.OtherStaff.Name = "OtherStaff"
        Me.OtherStaff.ReadOnly = True
        Me.OtherStaff.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Complimtry
        '
        Me.Complimtry.HeaderText = "Complimtry"
        Me.Complimtry.Name = "Complimtry"
        Me.Complimtry.ReadOnly = True
        Me.Complimtry.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Dispose_
        '
        Me.Dispose_.HeaderText = "Dispose"
        Me.Dispose_.Name = "Dispose_"
        Me.Dispose_.ReadOnly = True
        Me.Dispose_.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        '
        'TP
        '
        Me.TP.HeaderText = "TP"
        Me.TP.Name = "TP"
        Me.TP.ReadOnly = True
        '
        'Balance
        '
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'frmDishStockReport2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 450)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DatagridViewstock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDishStockReport2"
        Me.Text = "frmDishStockReport2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DatagridViewstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatagridViewstock As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label1Qua As Label
    Friend WithEvents Label2Qua As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents bntClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BillDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Staff As DataGridViewTextBoxColumn
    Friend WithEvents Management As DataGridViewTextBoxColumn
    Friend WithEvents OtherStaff As DataGridViewTextBoxColumn
    Friend WithEvents Complimtry As DataGridViewTextBoxColumn
    Friend WithEvents Dispose_ As DataGridViewTextBoxColumn
    Friend WithEvents DI As DataGridViewTextBoxColumn
    Friend WithEvents TA As DataGridViewTextBoxColumn
    Friend WithEvents HD As DataGridViewTextBoxColumn
    Friend WithEvents TP As DataGridViewTextBoxColumn
    Friend WithEvents Balance As DataGridViewTextBoxColumn
End Class
