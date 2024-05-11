<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoteMasterNew
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNoteMasterNew))
        Me.DgvNotes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.backcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDish = New System.Windows.Forms.CheckBox()
        Me.cmbDishName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBackUIColor = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.ChkActive = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.bttnNew = New System.Windows.Forms.Button()
        Me.bntClose = New System.Windows.Forms.Button()
        CType(Me.DgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvNotes
        '
        Me.DgvNotes.AllowUserToAddRows = False
        Me.DgvNotes.AllowUserToDeleteRows = False
        Me.DgvNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvNotes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvNotes.ColumnHeadersHeight = 35
        Me.DgvNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Note, Me.DishID, Me.Dish, Me.IsActive, Me.backcolor})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNotes.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgvNotes.EnableHeadersVisualStyles = False
        Me.DgvNotes.Location = New System.Drawing.Point(333, 44)
        Me.DgvNotes.MultiSelect = False
        Me.DgvNotes.Name = "DgvNotes"
        Me.DgvNotes.ReadOnly = True
        Me.DgvNotes.RowHeadersVisible = False
        Me.DgvNotes.RowHeadersWidth = 35
        Me.DgvNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvNotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotes.Size = New System.Drawing.Size(510, 353)
        Me.DgvNotes.TabIndex = 20
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID.Visible = False
        '
        'Note
        '
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DishID
        '
        Me.DishID.HeaderText = "DishID"
        Me.DishID.Name = "DishID"
        Me.DishID.ReadOnly = True
        '
        'Dish
        '
        Me.Dish.HeaderText = "Dish"
        Me.Dish.Name = "Dish"
        Me.Dish.ReadOnly = True
        Me.Dish.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'IsActive
        '
        Me.IsActive.HeaderText = "IsActive"
        Me.IsActive.Name = "IsActive"
        Me.IsActive.ReadOnly = True
        Me.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'backcolor
        '
        Me.backcolor.HeaderText = "backcolor"
        Me.backcolor.Name = "backcolor"
        Me.backcolor.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(841, 39)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Note Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.chkDish)
        Me.GroupBox2.Controls.Add(Me.cmbDishName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnBackUIColor)
        Me.GroupBox2.Controls.Add(Me.txtNotes)
        Me.GroupBox2.Controls.Add(Me.ChkActive)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(1, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 353)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Note Info"
        '
        'chkDish
        '
        Me.chkDish.AutoSize = True
        Me.chkDish.Location = New System.Drawing.Point(220, 96)
        Me.chkDish.Name = "chkDish"
        Me.chkDish.Size = New System.Drawing.Size(95, 17)
        Me.chkDish.TabIndex = 20
        Me.chkDish.Text = "Choose a Dish"
        Me.chkDish.UseVisualStyleBackColor = True
        '
        'cmbDishName
        '
        Me.cmbDishName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDishName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDishName.Enabled = False
        Me.cmbDishName.FormattingEnabled = True
        Me.cmbDishName.Location = New System.Drawing.Point(52, 94)
        Me.cmbDishName.Name = "cmbDishName"
        Me.cmbDishName.Size = New System.Drawing.Size(149, 21)
        Me.cmbDishName.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(217, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Select Color"
        '
        'btnBackUIColor
        '
        Me.btnBackUIColor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBackUIColor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUIColor.ForeColor = System.Drawing.Color.White
        Me.btnBackUIColor.Location = New System.Drawing.Point(52, 163)
        Me.btnBackUIColor.Name = "btnBackUIColor"
        Me.btnBackUIColor.Size = New System.Drawing.Size(123, 50)
        Me.btnBackUIColor.TabIndex = 17
        Me.btnBackUIColor.Text = "Back UI Color"
        Me.btnBackUIColor.UseVisualStyleBackColor = False
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(53, 51)
        Me.txtNotes.MaxLength = 40
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(149, 21)
        Me.txtNotes.TabIndex = 1
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Checked = True
        Me.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActive.Location = New System.Drawing.Point(55, 134)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 10
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Dish"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Note"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel4.Controls.Add(Me.bttnDelete)
        Me.Panel4.Controls.Add(Me.bttnUpdate)
        Me.Panel4.Controls.Add(Me.bttnSave)
        Me.Panel4.Controls.Add(Me.bttnNew)
        Me.Panel4.Location = New System.Drawing.Point(1, 399)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(842, 51)
        Me.Panel4.TabIndex = 23
        '
        'bttnDelete
        '
        Me.bttnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnDelete.BackColor = System.Drawing.Color.White
        Me.bttnDelete.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.ForeColor = System.Drawing.Color.Black
        Me.bttnDelete.Image = CType(resources.GetObject("bttnDelete.Image"), System.Drawing.Image)
        Me.bttnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnDelete.Location = New System.Drawing.Point(741, 6)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(87, 36)
        Me.bttnDelete.TabIndex = 28
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnDelete.UseVisualStyleBackColor = False
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnUpdate.BackColor = System.Drawing.Color.White
        Me.bttnUpdate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUpdate.ForeColor = System.Drawing.Color.Black
        Me.bttnUpdate.Image = CType(resources.GetObject("bttnUpdate.Image"), System.Drawing.Image)
        Me.bttnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnUpdate.Location = New System.Drawing.Point(648, 7)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(87, 36)
        Me.bttnUpdate.TabIndex = 25
        Me.bttnUpdate.Text = "Update"
        Me.bttnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnUpdate.UseVisualStyleBackColor = False
        '
        'bttnSave
        '
        Me.bttnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSave.BackColor = System.Drawing.Color.White
        Me.bttnSave.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSave.ForeColor = System.Drawing.Color.Black
        Me.bttnSave.Image = CType(resources.GetObject("bttnSave.Image"), System.Drawing.Image)
        Me.bttnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnSave.Location = New System.Drawing.Point(555, 7)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(87, 36)
        Me.bttnSave.TabIndex = 19
        Me.bttnSave.Text = "Save"
        Me.bttnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnSave.UseVisualStyleBackColor = False
        '
        'bttnNew
        '
        Me.bttnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnNew.BackColor = System.Drawing.Color.White
        Me.bttnNew.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnNew.ForeColor = System.Drawing.Color.Black
        Me.bttnNew.Image = CType(resources.GetObject("bttnNew.Image"), System.Drawing.Image)
        Me.bttnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnNew.Location = New System.Drawing.Point(462, 8)
        Me.bttnNew.Name = "bttnNew"
        Me.bttnNew.Size = New System.Drawing.Size(87, 36)
        Me.bttnNew.TabIndex = 22
        Me.bttnNew.Text = "New"
        Me.bttnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnNew.UseVisualStyleBackColor = False
        '
        'bntClose
        '
        Me.bntClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntClose.BackColor = System.Drawing.Color.Red
        Me.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClose.Location = New System.Drawing.Point(774, 3)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(69, 39)
        Me.bntClose.TabIndex = 366
        Me.bntClose.Text = "X"
        Me.bntClose.UseVisualStyleBackColor = False
        '
        'frmNoteMasterNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 450)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoteMasterNew"
        Me.Text = "frmNoteMasterNew"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvNotes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents ChkActive As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents bttnSave As Button
    Friend WithEvents bttnNew As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBackUIColor As Button
    Friend WithEvents cmbDishName As ComboBox
    Friend WithEvents chkDish As CheckBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents DishID As DataGridViewTextBoxColumn
    Friend WithEvents Dish As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents backcolor As DataGridViewTextBoxColumn
    Friend WithEvents bntClose As Button
End Class
