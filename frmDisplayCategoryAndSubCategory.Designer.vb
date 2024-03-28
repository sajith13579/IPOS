<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayCategoryAndSubCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayCategoryAndSubCategory))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Category = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bttnCatDelete = New System.Windows.Forms.Button()
        Me.bttnCatUpdate = New System.Windows.Forms.Button()
        Me.bttnCatSave = New System.Windows.Forms.Button()
        Me.bttnCatNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCatImagePath = New System.Windows.Forms.Label()
        Me.bttnCatBrowse = New System.Windows.Forms.Button()
        Me.bttnCatRemove = New System.Windows.Forms.Button()
        Me.PictBoxCat = New System.Windows.Forms.PictureBox()
        Me.txtCategoryLocal = New System.Windows.Forms.TextBox()
        Me.txtCatDisplayOrder = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkCategory = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DgvCategory = New System.Windows.Forms.DataGridView()
        Me.Col_Cat_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Category_Local = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Cat_IsActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Col_Category_Image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Display_Order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SubCategory = New System.Windows.Forms.TabPage()
        Me.DgvSubCat = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSubCatDelete = New System.Windows.Forms.Button()
        Me.btnSubCatUpdate = New System.Windows.Forms.Button()
        Me.btnSubCatSave = New System.Windows.Forms.Button()
        Me.btnSubCatNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubCatBrowse = New System.Windows.Forms.Button()
        Me.btnSubCatRemove = New System.Windows.Forms.Button()
        Me.pictboxSubCat = New System.Windows.Forms.PictureBox()
        Me.cmbCatName = New System.Windows.Forms.ComboBox()
        Me.txtSubCatLocal = New System.Windows.Forms.TextBox()
        Me.txtSubCatDisplayOrder = New System.Windows.Forms.TextBox()
        Me.txtSubCategory = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkSubCategory = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSubCatImagePath = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sub_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoryLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCatImage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.Category.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictBoxCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SubCategory.SuspendLayout()
        CType(Me.DgvSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictboxSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Category)
        Me.TabControl1.Controls.Add(Me.SubCategory)
        Me.TabControl1.Location = New System.Drawing.Point(2, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(932, 516)
        Me.TabControl1.TabIndex = 0
        '
        'Category
        '
        Me.Category.Controls.Add(Me.Panel4)
        Me.Category.Controls.Add(Me.GroupBox2)
        Me.Category.Controls.Add(Me.DgvCategory)
        Me.Category.Controls.Add(Me.Panel2)
        Me.Category.Location = New System.Drawing.Point(4, 22)
        Me.Category.Name = "Category"
        Me.Category.Padding = New System.Windows.Forms.Padding(3)
        Me.Category.Size = New System.Drawing.Size(924, 490)
        Me.Category.TabIndex = 0
        Me.Category.Text = "Category"
        Me.Category.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel4.Controls.Add(Me.bttnCatDelete)
        Me.Panel4.Controls.Add(Me.bttnCatUpdate)
        Me.Panel4.Controls.Add(Me.bttnCatSave)
        Me.Panel4.Controls.Add(Me.bttnCatNew)
        Me.Panel4.Location = New System.Drawing.Point(0, 439)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(921, 55)
        Me.Panel4.TabIndex = 21
        '
        'bttnCatDelete
        '
        Me.bttnCatDelete.BackColor = System.Drawing.Color.White
        Me.bttnCatDelete.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatDelete.ForeColor = System.Drawing.Color.Black
        Me.bttnCatDelete.Image = CType(resources.GetObject("bttnCatDelete.Image"), System.Drawing.Image)
        Me.bttnCatDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatDelete.Location = New System.Drawing.Point(292, 11)
        Me.bttnCatDelete.Name = "bttnCatDelete"
        Me.bttnCatDelete.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatDelete.TabIndex = 12
        Me.bttnCatDelete.Text = "Delete"
        Me.bttnCatDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatDelete.UseVisualStyleBackColor = False
        '
        'bttnCatUpdate
        '
        Me.bttnCatUpdate.BackColor = System.Drawing.Color.White
        Me.bttnCatUpdate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatUpdate.ForeColor = System.Drawing.Color.Black
        Me.bttnCatUpdate.Image = CType(resources.GetObject("bttnCatUpdate.Image"), System.Drawing.Image)
        Me.bttnCatUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatUpdate.Location = New System.Drawing.Point(199, 11)
        Me.bttnCatUpdate.Name = "bttnCatUpdate"
        Me.bttnCatUpdate.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatUpdate.TabIndex = 11
        Me.bttnCatUpdate.Text = "Update"
        Me.bttnCatUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatUpdate.UseVisualStyleBackColor = False
        '
        'bttnCatSave
        '
        Me.bttnCatSave.BackColor = System.Drawing.Color.White
        Me.bttnCatSave.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatSave.ForeColor = System.Drawing.Color.Black
        Me.bttnCatSave.Image = CType(resources.GetObject("bttnCatSave.Image"), System.Drawing.Image)
        Me.bttnCatSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatSave.Location = New System.Drawing.Point(106, 11)
        Me.bttnCatSave.Name = "bttnCatSave"
        Me.bttnCatSave.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatSave.TabIndex = 10
        Me.bttnCatSave.Text = "Save"
        Me.bttnCatSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatSave.UseVisualStyleBackColor = False
        '
        'bttnCatNew
        '
        Me.bttnCatNew.BackColor = System.Drawing.Color.White
        Me.bttnCatNew.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatNew.ForeColor = System.Drawing.Color.Black
        Me.bttnCatNew.Image = CType(resources.GetObject("bttnCatNew.Image"), System.Drawing.Image)
        Me.bttnCatNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatNew.Location = New System.Drawing.Point(13, 11)
        Me.bttnCatNew.Name = "bttnCatNew"
        Me.bttnCatNew.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatNew.TabIndex = 9
        Me.bttnCatNew.Text = "New"
        Me.bttnCatNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatNew.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblCatImagePath)
        Me.GroupBox2.Controls.Add(Me.bttnCatBrowse)
        Me.GroupBox2.Controls.Add(Me.bttnCatRemove)
        Me.GroupBox2.Controls.Add(Me.PictBoxCat)
        Me.GroupBox2.Controls.Add(Me.txtCategoryLocal)
        Me.GroupBox2.Controls.Add(Me.txtCatDisplayOrder)
        Me.GroupBox2.Controls.Add(Me.txtCategory)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ChkCategory)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 374)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sub Category Info"
        '
        'lblCatImagePath
        '
        Me.lblCatImagePath.AutoSize = True
        Me.lblCatImagePath.Location = New System.Drawing.Point(18, 340)
        Me.lblCatImagePath.Name = "lblCatImagePath"
        Me.lblCatImagePath.Size = New System.Drawing.Size(39, 13)
        Me.lblCatImagePath.TabIndex = 63
        Me.lblCatImagePath.Text = "Label4"
        Me.lblCatImagePath.Visible = False
        '
        'bttnCatBrowse
        '
        Me.bttnCatBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCatBrowse.BackColor = System.Drawing.Color.White
        Me.bttnCatBrowse.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatBrowse.ForeColor = System.Drawing.Color.Black
        Me.bttnCatBrowse.Image = CType(resources.GetObject("bttnCatBrowse.Image"), System.Drawing.Image)
        Me.bttnCatBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatBrowse.Location = New System.Drawing.Point(155, 268)
        Me.bttnCatBrowse.Name = "bttnCatBrowse"
        Me.bttnCatBrowse.Size = New System.Drawing.Size(108, 40)
        Me.bttnCatBrowse.TabIndex = 61
        Me.bttnCatBrowse.Text = "Browse"
        Me.bttnCatBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatBrowse.UseVisualStyleBackColor = False
        '
        'bttnCatRemove
        '
        Me.bttnCatRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCatRemove.BackColor = System.Drawing.Color.White
        Me.bttnCatRemove.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatRemove.ForeColor = System.Drawing.Color.Black
        Me.bttnCatRemove.Image = CType(resources.GetObject("bttnCatRemove.Image"), System.Drawing.Image)
        Me.bttnCatRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatRemove.Location = New System.Drawing.Point(155, 185)
        Me.bttnCatRemove.Name = "bttnCatRemove"
        Me.bttnCatRemove.Size = New System.Drawing.Size(108, 40)
        Me.bttnCatRemove.TabIndex = 62
        Me.bttnCatRemove.Text = "Remove"
        Me.bttnCatRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatRemove.UseVisualStyleBackColor = False
        '
        'PictBoxCat
        '
        Me.PictBoxCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictBoxCat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictBoxCat.ErrorImage = Nothing
        Me.PictBoxCat.Image = CType(resources.GetObject("PictBoxCat.Image"), System.Drawing.Image)
        Me.PictBoxCat.InitialImage = CType(resources.GetObject("PictBoxCat.InitialImage"), System.Drawing.Image)
        Me.PictBoxCat.Location = New System.Drawing.Point(21, 185)
        Me.PictBoxCat.Name = "PictBoxCat"
        Me.PictBoxCat.Size = New System.Drawing.Size(118, 123)
        Me.PictBoxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictBoxCat.TabIndex = 59
        Me.PictBoxCat.TabStop = False
        '
        'txtCategoryLocal
        '
        Me.txtCategoryLocal.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryLocal.Location = New System.Drawing.Point(137, 65)
        Me.txtCategoryLocal.Name = "txtCategoryLocal"
        Me.txtCategoryLocal.Size = New System.Drawing.Size(149, 21)
        Me.txtCategoryLocal.TabIndex = 6
        '
        'txtCatDisplayOrder
        '
        Me.txtCatDisplayOrder.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatDisplayOrder.Location = New System.Drawing.Point(137, 107)
        Me.txtCatDisplayOrder.Name = "txtCatDisplayOrder"
        Me.txtCatDisplayOrder.Size = New System.Drawing.Size(149, 21)
        Me.txtCatDisplayOrder.TabIndex = 6
        Me.txtCatDisplayOrder.Text = "0"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(137, 25)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(149, 21)
        Me.txtCategory.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Display Order"
        '
        'ChkCategory
        '
        Me.ChkCategory.AutoSize = True
        Me.ChkCategory.Location = New System.Drawing.Point(137, 149)
        Me.ChkCategory.Name = "ChkCategory"
        Me.ChkCategory.Size = New System.Drawing.Size(56, 17)
        Me.ChkCategory.TabIndex = 2
        Me.ChkCategory.Text = "Active"
        Me.ChkCategory.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Category Local"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Category"
        '
        'DgvCategory
        '
        Me.DgvCategory.AllowUserToAddRows = False
        Me.DgvCategory.AllowUserToDeleteRows = False
        Me.DgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCategory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Cat_ID, Me.Col_Category, Me.Col_Category_Local, Me.Col_Cat_IsActive, Me.Col_Category_Image, Me.Col_Display_Order})
        Me.DgvCategory.Location = New System.Drawing.Point(355, 63)
        Me.DgvCategory.MultiSelect = False
        Me.DgvCategory.Name = "DgvCategory"
        Me.DgvCategory.ReadOnly = True
        Me.DgvCategory.Size = New System.Drawing.Size(563, 370)
        Me.DgvCategory.TabIndex = 19
        '
        'Col_Cat_ID
        '
        Me.Col_Cat_ID.HeaderText = "ID"
        Me.Col_Cat_ID.Name = "Col_Cat_ID"
        Me.Col_Cat_ID.ReadOnly = True
        Me.Col_Cat_ID.Visible = False
        '
        'Col_Category
        '
        Me.Col_Category.HeaderText = "Category"
        Me.Col_Category.Name = "Col_Category"
        Me.Col_Category.ReadOnly = True
        '
        'Col_Category_Local
        '
        Me.Col_Category_Local.HeaderText = "Category Local"
        Me.Col_Category_Local.Name = "Col_Category_Local"
        Me.Col_Category_Local.ReadOnly = True
        '
        'Col_Cat_IsActive
        '
        Me.Col_Cat_IsActive.HeaderText = "IsActive"
        Me.Col_Cat_IsActive.Name = "Col_Cat_IsActive"
        Me.Col_Cat_IsActive.ReadOnly = True
        '
        'Col_Category_Image
        '
        Me.Col_Category_Image.HeaderText = "Category_Image"
        Me.Col_Category_Image.Name = "Col_Category_Image"
        Me.Col_Category_Image.ReadOnly = True
        Me.Col_Category_Image.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Category_Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Col_Display_Order
        '
        Me.Col_Display_Order.HeaderText = "Display Order"
        Me.Col_Display_Order.Name = "Col_Display_Order"
        Me.Col_Display_Order.ReadOnly = True
        Me.Col_Display_Order.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Display_Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 50)
        Me.Panel2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(322, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 29)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Categories"
        '
        'SubCategory
        '
        Me.SubCategory.Controls.Add(Me.DgvSubCat)
        Me.SubCategory.Controls.Add(Me.Panel3)
        Me.SubCategory.Controls.Add(Me.GroupBox1)
        Me.SubCategory.Controls.Add(Me.Panel1)
        Me.SubCategory.Location = New System.Drawing.Point(4, 22)
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.SubCategory.Size = New System.Drawing.Size(924, 490)
        Me.SubCategory.TabIndex = 1
        Me.SubCategory.Text = "Sub Category"
        Me.SubCategory.UseVisualStyleBackColor = True
        '
        'DgvSubCat
        '
        Me.DgvSubCat.AllowUserToAddRows = False
        Me.DgvSubCat.AllowUserToDeleteRows = False
        Me.DgvSubCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSubCat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvSubCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSubCat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Sub_Category, Me.SubCategoryLocal, Me.IsActive, Me.CategoryName, Me.SubCatImage, Me.DisplayOrder})
        Me.DgvSubCat.Location = New System.Drawing.Point(355, 54)
        Me.DgvSubCat.Name = "DgvSubCat"
        Me.DgvSubCat.ReadOnly = True
        Me.DgvSubCat.Size = New System.Drawing.Size(563, 380)
        Me.DgvSubCat.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnSubCatDelete)
        Me.Panel3.Controls.Add(Me.btnSubCatUpdate)
        Me.Panel3.Controls.Add(Me.btnSubCatSave)
        Me.Panel3.Controls.Add(Me.btnSubCatNew)
        Me.Panel3.Location = New System.Drawing.Point(0, 440)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(921, 55)
        Me.Panel3.TabIndex = 17
        '
        'btnSubCatDelete
        '
        Me.btnSubCatDelete.BackColor = System.Drawing.Color.White
        Me.btnSubCatDelete.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatDelete.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatDelete.Image = CType(resources.GetObject("btnSubCatDelete.Image"), System.Drawing.Image)
        Me.btnSubCatDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatDelete.Location = New System.Drawing.Point(292, 11)
        Me.btnSubCatDelete.Name = "btnSubCatDelete"
        Me.btnSubCatDelete.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatDelete.TabIndex = 12
        Me.btnSubCatDelete.Text = "Delete"
        Me.btnSubCatDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatDelete.UseVisualStyleBackColor = False
        '
        'btnSubCatUpdate
        '
        Me.btnSubCatUpdate.BackColor = System.Drawing.Color.White
        Me.btnSubCatUpdate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatUpdate.Image = CType(resources.GetObject("btnSubCatUpdate.Image"), System.Drawing.Image)
        Me.btnSubCatUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatUpdate.Location = New System.Drawing.Point(199, 11)
        Me.btnSubCatUpdate.Name = "btnSubCatUpdate"
        Me.btnSubCatUpdate.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatUpdate.TabIndex = 11
        Me.btnSubCatUpdate.Text = "Update"
        Me.btnSubCatUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatUpdate.UseVisualStyleBackColor = False
        '
        'btnSubCatSave
        '
        Me.btnSubCatSave.BackColor = System.Drawing.Color.White
        Me.btnSubCatSave.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatSave.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatSave.Image = CType(resources.GetObject("btnSubCatSave.Image"), System.Drawing.Image)
        Me.btnSubCatSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatSave.Location = New System.Drawing.Point(106, 11)
        Me.btnSubCatSave.Name = "btnSubCatSave"
        Me.btnSubCatSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatSave.TabIndex = 10
        Me.btnSubCatSave.Text = "Save"
        Me.btnSubCatSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatSave.UseVisualStyleBackColor = False
        '
        'btnSubCatNew
        '
        Me.btnSubCatNew.BackColor = System.Drawing.Color.White
        Me.btnSubCatNew.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatNew.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatNew.Image = CType(resources.GetObject("btnSubCatNew.Image"), System.Drawing.Image)
        Me.btnSubCatNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatNew.Location = New System.Drawing.Point(13, 11)
        Me.btnSubCatNew.Name = "btnSubCatNew"
        Me.btnSubCatNew.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatNew.TabIndex = 9
        Me.btnSubCatNew.Text = "New"
        Me.btnSubCatNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatNew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblSubCatImagePath)
        Me.GroupBox1.Controls.Add(Me.btnSubCatBrowse)
        Me.GroupBox1.Controls.Add(Me.btnSubCatRemove)
        Me.GroupBox1.Controls.Add(Me.pictboxSubCat)
        Me.GroupBox1.Controls.Add(Me.cmbCatName)
        Me.GroupBox1.Controls.Add(Me.txtSubCatLocal)
        Me.GroupBox1.Controls.Add(Me.txtSubCatDisplayOrder)
        Me.GroupBox1.Controls.Add(Me.txtSubCategory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ChkSubCategory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 380)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sub Category Info"
        '
        'btnSubCatBrowse
        '
        Me.btnSubCatBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubCatBrowse.BackColor = System.Drawing.Color.White
        Me.btnSubCatBrowse.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatBrowse.Image = CType(resources.GetObject("btnSubCatBrowse.Image"), System.Drawing.Image)
        Me.btnSubCatBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatBrowse.Location = New System.Drawing.Point(155, 308)
        Me.btnSubCatBrowse.Name = "btnSubCatBrowse"
        Me.btnSubCatBrowse.Size = New System.Drawing.Size(108, 40)
        Me.btnSubCatBrowse.TabIndex = 61
        Me.btnSubCatBrowse.Text = "Browse"
        Me.btnSubCatBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatBrowse.UseVisualStyleBackColor = False
        '
        'btnSubCatRemove
        '
        Me.btnSubCatRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubCatRemove.BackColor = System.Drawing.Color.White
        Me.btnSubCatRemove.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatRemove.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatRemove.Image = CType(resources.GetObject("btnSubCatRemove.Image"), System.Drawing.Image)
        Me.btnSubCatRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatRemove.Location = New System.Drawing.Point(155, 226)
        Me.btnSubCatRemove.Name = "btnSubCatRemove"
        Me.btnSubCatRemove.Size = New System.Drawing.Size(108, 40)
        Me.btnSubCatRemove.TabIndex = 62
        Me.btnSubCatRemove.Text = "Remove"
        Me.btnSubCatRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatRemove.UseVisualStyleBackColor = False
        '
        'pictboxSubCat
        '
        Me.pictboxSubCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictboxSubCat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pictboxSubCat.ErrorImage = Nothing
        Me.pictboxSubCat.Image = CType(resources.GetObject("pictboxSubCat.Image"), System.Drawing.Image)
        Me.pictboxSubCat.InitialImage = CType(resources.GetObject("pictboxSubCat.InitialImage"), System.Drawing.Image)
        Me.pictboxSubCat.Location = New System.Drawing.Point(17, 225)
        Me.pictboxSubCat.Name = "pictboxSubCat"
        Me.pictboxSubCat.Size = New System.Drawing.Size(118, 123)
        Me.pictboxSubCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictboxSubCat.TabIndex = 59
        Me.pictboxSubCat.TabStop = False
        '
        'cmbCatName
        '
        Me.cmbCatName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCatName.FormattingEnabled = True
        Me.cmbCatName.Location = New System.Drawing.Point(137, 95)
        Me.cmbCatName.Name = "cmbCatName"
        Me.cmbCatName.Size = New System.Drawing.Size(149, 21)
        Me.cmbCatName.TabIndex = 7
        '
        'txtSubCatLocal
        '
        Me.txtSubCatLocal.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCatLocal.Location = New System.Drawing.Point(137, 60)
        Me.txtSubCatLocal.Name = "txtSubCatLocal"
        Me.txtSubCatLocal.Size = New System.Drawing.Size(149, 21)
        Me.txtSubCatLocal.TabIndex = 6
        '
        'txtSubCatDisplayOrder
        '
        Me.txtSubCatDisplayOrder.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCatDisplayOrder.Location = New System.Drawing.Point(137, 140)
        Me.txtSubCatDisplayOrder.Name = "txtSubCatDisplayOrder"
        Me.txtSubCatDisplayOrder.Size = New System.Drawing.Size(149, 21)
        Me.txtSubCatDisplayOrder.TabIndex = 6
        '
        'txtSubCategory
        '
        Me.txtSubCategory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCategory.Location = New System.Drawing.Point(137, 25)
        Me.txtSubCategory.Name = "txtSubCategory"
        Me.txtSubCategory.Size = New System.Drawing.Size(149, 21)
        Me.txtSubCategory.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Display Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Category "
        '
        'ChkSubCategory
        '
        Me.ChkSubCategory.AutoSize = True
        Me.ChkSubCategory.Location = New System.Drawing.Point(137, 185)
        Me.ChkSubCategory.Name = "ChkSubCategory"
        Me.ChkSubCategory.Size = New System.Drawing.Size(56, 17)
        Me.ChkSubCategory.TabIndex = 2
        Me.ChkSubCategory.Text = "Active"
        Me.ChkSubCategory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sub Category Local"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sub Category"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(322, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " Sub Categories"
        '
        'lblSubCatImagePath
        '
        Me.lblSubCatImagePath.AutoSize = True
        Me.lblSubCatImagePath.Location = New System.Drawing.Point(17, 355)
        Me.lblSubCatImagePath.Name = "lblSubCatImagePath"
        Me.lblSubCatImagePath.Size = New System.Drawing.Size(39, 13)
        Me.lblSubCatImagePath.TabIndex = 63
        Me.lblSubCatImagePath.Text = "Label4"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Sub_Category
        '
        Me.Sub_Category.HeaderText = "Sub Category"
        Me.Sub_Category.Name = "Sub_Category"
        Me.Sub_Category.ReadOnly = True
        '
        'SubCategoryLocal
        '
        Me.SubCategoryLocal.HeaderText = "Sub Category Local"
        Me.SubCategoryLocal.Name = "SubCategoryLocal"
        Me.SubCategoryLocal.ReadOnly = True
        '
        'IsActive
        '
        Me.IsActive.HeaderText = "IsActive"
        Me.IsActive.Name = "IsActive"
        Me.IsActive.ReadOnly = True
        '
        'CategoryName
        '
        Me.CategoryName.HeaderText = "Category Name"
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        Me.CategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SubCatImage
        '
        Me.SubCatImage.HeaderText = "SubCatImage"
        Me.SubCatImage.Name = "SubCatImage"
        Me.SubCatImage.ReadOnly = True
        Me.SubCatImage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubCatImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DisplayOrder
        '
        Me.DisplayOrder.HeaderText = "DisplayOrder"
        Me.DisplayOrder.Name = "DisplayOrder"
        Me.DisplayOrder.ReadOnly = True
        Me.DisplayOrder.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisplayOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmDisplayCategoryAndSubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmDisplayCategoryAndSubCategory"
        Me.Text = "frmDisplayCategoryAndSubCategory"
        Me.TabControl1.ResumeLayout(False)
        Me.Category.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictBoxCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SubCategory.ResumeLayout(False)
        CType(Me.DgvSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictboxSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Category As TabPage
    Friend WithEvents SubCategory As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubCatBrowse As Button
    Friend WithEvents btnSubCatRemove As Button
    Friend WithEvents pictboxSubCat As PictureBox
    Friend WithEvents cmbCatName As ComboBox
    Friend WithEvents txtSubCatLocal As TextBox
    Friend WithEvents txtSubCatDisplayOrder As TextBox
    Friend WithEvents txtSubCategory As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkSubCategory As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSubCatDelete As Button
    Friend WithEvents btnSubCatUpdate As Button
    Friend WithEvents btnSubCatSave As Button
    Friend WithEvents btnSubCatNew As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents DgvSubCat As DataGridView
    Friend WithEvents DgvCategory As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bttnCatDelete As Button
    Friend WithEvents bttnCatUpdate As Button
    Friend WithEvents bttnCatSave As Button
    Friend WithEvents bttnCatNew As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bttnCatBrowse As Button
    Friend WithEvents bttnCatRemove As Button
    Friend WithEvents PictBoxCat As PictureBox
    Friend WithEvents txtCategoryLocal As TextBox
    Friend WithEvents txtCatDisplayOrder As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkCategory As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblCatImagePath As Label
    Friend WithEvents Col_Cat_ID As DataGridViewTextBoxColumn
    Friend WithEvents Col_Category As DataGridViewTextBoxColumn
    Friend WithEvents Col_Category_Local As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cat_IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents Col_Category_Image As DataGridViewTextBoxColumn
    Friend WithEvents Col_Display_Order As DataGridViewTextBoxColumn
    Friend WithEvents lblSubCatImagePath As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Sub_Category As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoryLocal As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents CategoryName As DataGridViewTextBoxColumn
    Friend WithEvents SubCatImage As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrder As DataGridViewTextBoxColumn
End Class
