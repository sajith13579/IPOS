<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipCreditCusList
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearchCustName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearchACNO = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.col_Account_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearchCustName)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search by customer name"
        '
        'txtSearchCustName
        '
        Me.txtSearchCustName.Location = New System.Drawing.Point(6, 45)
        Me.txtSearchCustName.Name = "txtSearchCustName"
        Me.txtSearchCustName.Size = New System.Drawing.Size(197, 20)
        Me.txtSearchCustName.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearchACNO)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 74)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by Account No"
        '
        'txtSearchACNO
        '
        Me.txtSearchACNO.Location = New System.Drawing.Point(6, 39)
        Me.txtSearchACNO.Name = "txtSearchACNO"
        Me.txtSearchACNO.Size = New System.Drawing.Size(227, 20)
        Me.txtSearchACNO.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Account_no, Me.col_cus_name, Me.colAdress, Me.colContact, Me.colActive, Me.colRegDate})
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 201)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(737, 251)
        Me.DataGridView1.TabIndex = 2
        '
        'col_Account_no
        '
        Me.col_Account_no.HeaderText = "Account_no"
        Me.col_Account_no.Name = "col_Account_no"
        '
        'col_cus_name
        '
        Me.col_cus_name.HeaderText = "Customer name"
        Me.col_cus_name.Name = "col_cus_name"
        '
        'colAdress
        '
        Me.colAdress.HeaderText = "Adress"
        Me.colAdress.Name = "colAdress"
        '
        'colContact
        '
        Me.colContact.HeaderText = "Contact no"
        Me.colContact.Name = "colContact"
        '
        'colActive
        '
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        '
        'colRegDate
        '
        Me.colRegDate.HeaderText = "Reg date"
        Me.colRegDate.Name = "colRegDate"
        '
        'frmReceipCreditCusList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReceipCreditCusList"
        Me.Text = "frmReceipCreditCusList"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearchCustName As TextBox
    Friend WithEvents txtSearchACNO As TextBox
    Friend WithEvents col_Account_no As DataGridViewTextBoxColumn
    Friend WithEvents col_cus_name As DataGridViewTextBoxColumn
    Friend WithEvents colAdress As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colRegDate As DataGridViewTextBoxColumn
End Class
