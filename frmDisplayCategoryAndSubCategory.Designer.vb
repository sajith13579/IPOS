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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sub_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoryLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCatImage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSubCatDelete = New System.Windows.Forms.Button()
        Me.btnSubCatUpdate = New System.Windows.Forms.Button()
        Me.btnSubCatSave = New System.Windows.Forms.Button()
        Me.btnSubCatNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSubCatImagePath = New System.Windows.Forms.Label()
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
        Me.DisplaySubCategoryDish = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtSearchSubCatDish = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtSearchListOfDish = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSub2CategoryNam = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.bttnDisplaySubCatDish = New System.Windows.Forms.Button()
        Me.bttnSaveSubCategoryDish = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bttnAddToGrid = New System.Windows.Forms.Button()
        Me.DgwDisplaySubCatDish = New System.Windows.Forms.DataGridView()
        Me.subCatId_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishId_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCatName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishName__2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrder__2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive__2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Remove_ = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DgwListDish = New System.Windows.Forms.DataGridView()
        Me.DishId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishNameLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.DisplaySubCategoryDish.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DgwDisplaySubCatDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwListDish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Category)
        Me.TabControl1.Controls.Add(Me.SubCategory)
        Me.TabControl1.Controls.Add(Me.DisplaySubCategoryDish)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl1.Location = New System.Drawing.Point(2, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(915, 516)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'Category
        '
        Me.Category.Controls.Add(Me.Panel4)
        Me.Category.Controls.Add(Me.GroupBox2)
        Me.Category.Controls.Add(Me.DgvCategory)
        Me.Category.Controls.Add(Me.Panel2)
        Me.Category.Location = New System.Drawing.Point(4, 34)
        Me.Category.Name = "Category"
        Me.Category.Padding = New System.Windows.Forms.Padding(3)
        Me.Category.Size = New System.Drawing.Size(907, 478)
        Me.Category.TabIndex = 0
        Me.Category.Text = "Category"
        Me.Category.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel4.Controls.Add(Me.bttnCatDelete)
        Me.Panel4.Controls.Add(Me.bttnCatUpdate)
        Me.Panel4.Controls.Add(Me.bttnCatSave)
        Me.Panel4.Controls.Add(Me.bttnCatNew)
        Me.Panel4.Location = New System.Drawing.Point(3, 427)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(904, 55)
        Me.Panel4.TabIndex = 21
        '
        'bttnCatDelete
        '
        Me.bttnCatDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCatDelete.BackColor = System.Drawing.Color.White
        Me.bttnCatDelete.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatDelete.ForeColor = System.Drawing.Color.Black
        Me.bttnCatDelete.Image = CType(resources.GetObject("bttnCatDelete.Image"), System.Drawing.Image)
        Me.bttnCatDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatDelete.Location = New System.Drawing.Point(803, 9)
        Me.bttnCatDelete.Name = "bttnCatDelete"
        Me.bttnCatDelete.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatDelete.TabIndex = 28
        Me.bttnCatDelete.Text = "Delete"
        Me.bttnCatDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatDelete.UseVisualStyleBackColor = False
        '
        'bttnCatUpdate
        '
        Me.bttnCatUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCatUpdate.BackColor = System.Drawing.Color.White
        Me.bttnCatUpdate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatUpdate.ForeColor = System.Drawing.Color.Black
        Me.bttnCatUpdate.Image = CType(resources.GetObject("bttnCatUpdate.Image"), System.Drawing.Image)
        Me.bttnCatUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatUpdate.Location = New System.Drawing.Point(710, 9)
        Me.bttnCatUpdate.Name = "bttnCatUpdate"
        Me.bttnCatUpdate.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatUpdate.TabIndex = 25
        Me.bttnCatUpdate.Text = "Update"
        Me.bttnCatUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatUpdate.UseVisualStyleBackColor = False
        '
        'bttnCatSave
        '
        Me.bttnCatSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCatSave.BackColor = System.Drawing.Color.White
        Me.bttnCatSave.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatSave.ForeColor = System.Drawing.Color.Black
        Me.bttnCatSave.Image = CType(resources.GetObject("bttnCatSave.Image"), System.Drawing.Image)
        Me.bttnCatSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatSave.Location = New System.Drawing.Point(617, 9)
        Me.bttnCatSave.Name = "bttnCatSave"
        Me.bttnCatSave.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatSave.TabIndex = 19
        Me.bttnCatSave.Text = "Save"
        Me.bttnCatSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatSave.UseVisualStyleBackColor = False
        '
        'bttnCatNew
        '
        Me.bttnCatNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCatNew.BackColor = System.Drawing.Color.White
        Me.bttnCatNew.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCatNew.ForeColor = System.Drawing.Color.Black
        Me.bttnCatNew.Image = CType(resources.GetObject("bttnCatNew.Image"), System.Drawing.Image)
        Me.bttnCatNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCatNew.Location = New System.Drawing.Point(524, 9)
        Me.bttnCatNew.Name = "bttnCatNew"
        Me.bttnCatNew.Size = New System.Drawing.Size(87, 36)
        Me.bttnCatNew.TabIndex = 22
        Me.bttnCatNew.Text = "New"
        Me.bttnCatNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnCatNew.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox2.Size = New System.Drawing.Size(348, 362)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sub Category Info"
        '
        'lblCatImagePath
        '
        Me.lblCatImagePath.AutoSize = True
        Me.lblCatImagePath.Location = New System.Drawing.Point(18, 340)
        Me.lblCatImagePath.Name = "lblCatImagePath"
        Me.lblCatImagePath.Size = New System.Drawing.Size(53, 19)
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
        Me.bttnCatBrowse.TabIndex = 16
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
        Me.bttnCatRemove.TabIndex = 13
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
        Me.txtCategoryLocal.MaxLength = 40
        Me.txtCategoryLocal.Name = "txtCategoryLocal"
        Me.txtCategoryLocal.Size = New System.Drawing.Size(149, 21)
        Me.txtCategoryLocal.TabIndex = 4
        '
        'txtCatDisplayOrder
        '
        Me.txtCatDisplayOrder.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatDisplayOrder.Location = New System.Drawing.Point(137, 107)
        Me.txtCatDisplayOrder.MaxLength = 4
        Me.txtCatDisplayOrder.Name = "txtCatDisplayOrder"
        Me.txtCatDisplayOrder.Size = New System.Drawing.Size(149, 21)
        Me.txtCatDisplayOrder.TabIndex = 7
        Me.txtCatDisplayOrder.Text = "0"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(137, 25)
        Me.txtCategory.MaxLength = 40
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(149, 21)
        Me.txtCategory.TabIndex = 1
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
        Me.ChkCategory.Size = New System.Drawing.Size(70, 23)
        Me.ChkCategory.TabIndex = 10
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
        Me.DgvCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCategory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCategory.ColumnHeadersHeight = 35
        Me.DgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Cat_ID, Me.Col_Category, Me.Col_Category_Local, Me.Col_Cat_IsActive, Me.Col_Category_Image, Me.Col_Display_Order})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCategory.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCategory.EnableHeadersVisualStyles = False
        Me.DgvCategory.Location = New System.Drawing.Point(355, 59)
        Me.DgvCategory.MultiSelect = False
        Me.DgvCategory.Name = "DgvCategory"
        Me.DgvCategory.ReadOnly = True
        Me.DgvCategory.RowHeadersVisible = False
        Me.DgvCategory.RowHeadersWidth = 35
        Me.DgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCategory.Size = New System.Drawing.Size(552, 362)
        Me.DgvCategory.TabIndex = 19
        '
        'Col_Cat_ID
        '
        Me.Col_Cat_ID.HeaderText = "ID"
        Me.Col_Cat_ID.Name = "Col_Cat_ID"
        Me.Col_Cat_ID.ReadOnly = True
        Me.Col_Cat_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Cat_ID.Visible = False
        '
        'Col_Category
        '
        Me.Col_Category.HeaderText = "Category"
        Me.Col_Category.Name = "Col_Category"
        Me.Col_Category.ReadOnly = True
        Me.Col_Category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Col_Category_Local
        '
        Me.Col_Category_Local.HeaderText = "Category Local"
        Me.Col_Category_Local.Name = "Col_Category_Local"
        Me.Col_Category_Local.ReadOnly = True
        Me.Col_Category_Local.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Col_Cat_IsActive
        '
        Me.Col_Cat_IsActive.HeaderText = "IsActive"
        Me.Col_Cat_IsActive.Name = "Col_Cat_IsActive"
        Me.Col_Cat_IsActive.ReadOnly = True
        Me.Col_Cat_IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Col_Category_Image
        '
        Me.Col_Category_Image.HeaderText = "Category_Image"
        Me.Col_Category_Image.Name = "Col_Category_Image"
        Me.Col_Category_Image.ReadOnly = True
        Me.Col_Category_Image.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Col_Category_Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Col_Category_Image.Visible = False
        '
        'Col_Display_Order
        '
        Me.Col_Display_Order.HeaderText = "Display Order"
        Me.Col_Display_Order.Name = "Col_Display_Order"
        Me.Col_Display_Order.ReadOnly = True
        Me.Col_Display_Order.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Col_Display_Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(3, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 50)
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
        Me.SubCategory.Location = New System.Drawing.Point(4, 34)
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.SubCategory.Size = New System.Drawing.Size(907, 478)
        Me.SubCategory.TabIndex = 1
        Me.SubCategory.Text = "Sub Category"
        Me.SubCategory.UseVisualStyleBackColor = True
        '
        'DgvSubCat
        '
        Me.DgvSubCat.AllowUserToAddRows = False
        Me.DgvSubCat.AllowUserToDeleteRows = False
        Me.DgvSubCat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSubCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSubCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvSubCat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSubCat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSubCat.ColumnHeadersHeight = 35
        Me.DgvSubCat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Sub_Category, Me.SubCategoryLocal, Me.IsActive, Me.CategoryName, Me.SubCatImage, Me.DisplayOrder, Me.category_id})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSubCat.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvSubCat.EnableHeadersVisualStyles = False
        Me.DgvSubCat.Location = New System.Drawing.Point(355, 54)
        Me.DgvSubCat.MultiSelect = False
        Me.DgvSubCat.Name = "DgvSubCat"
        Me.DgvSubCat.ReadOnly = True
        Me.DgvSubCat.RowHeadersVisible = False
        Me.DgvSubCat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSubCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSubCat.Size = New System.Drawing.Size(552, 363)
        Me.DgvSubCat.TabIndex = 18
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Sub_Category
        '
        Me.Sub_Category.HeaderText = "Sub Category"
        Me.Sub_Category.Name = "Sub_Category"
        Me.Sub_Category.ReadOnly = True
        Me.Sub_Category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'SubCategoryLocal
        '
        Me.SubCategoryLocal.HeaderText = "Sub Category Local"
        Me.SubCategoryLocal.Name = "SubCategoryLocal"
        Me.SubCategoryLocal.ReadOnly = True
        Me.SubCategoryLocal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'IsActive
        '
        Me.IsActive.HeaderText = "IsActive"
        Me.IsActive.Name = "IsActive"
        Me.IsActive.ReadOnly = True
        Me.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CategoryName
        '
        Me.CategoryName.HeaderText = "Category Name"
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        Me.CategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SubCatImage
        '
        Me.SubCatImage.HeaderText = "SubCatImage"
        Me.SubCatImage.Name = "SubCatImage"
        Me.SubCatImage.ReadOnly = True
        Me.SubCatImage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SubCatImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SubCatImage.Visible = False
        '
        'DisplayOrder
        '
        Me.DisplayOrder.HeaderText = "DisplayOrder"
        Me.DisplayOrder.Name = "DisplayOrder"
        Me.DisplayOrder.ReadOnly = True
        Me.DisplayOrder.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisplayOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'category_id
        '
        Me.category_id.HeaderText = "category_id"
        Me.category_id.Name = "category_id"
        Me.category_id.ReadOnly = True
        Me.category_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.category_id.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnSubCatDelete)
        Me.Panel3.Controls.Add(Me.btnSubCatUpdate)
        Me.Panel3.Controls.Add(Me.btnSubCatSave)
        Me.Panel3.Controls.Add(Me.btnSubCatNew)
        Me.Panel3.Location = New System.Drawing.Point(3, 423)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(904, 55)
        Me.Panel3.TabIndex = 17
        '
        'btnSubCatDelete
        '
        Me.btnSubCatDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubCatDelete.BackColor = System.Drawing.Color.White
        Me.btnSubCatDelete.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatDelete.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatDelete.Image = CType(resources.GetObject("btnSubCatDelete.Image"), System.Drawing.Image)
        Me.btnSubCatDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatDelete.Location = New System.Drawing.Point(800, 13)
        Me.btnSubCatDelete.Name = "btnSubCatDelete"
        Me.btnSubCatDelete.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatDelete.TabIndex = 31
        Me.btnSubCatDelete.Text = "Delete"
        Me.btnSubCatDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatDelete.UseVisualStyleBackColor = False
        '
        'btnSubCatUpdate
        '
        Me.btnSubCatUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubCatUpdate.BackColor = System.Drawing.Color.White
        Me.btnSubCatUpdate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatUpdate.Image = CType(resources.GetObject("btnSubCatUpdate.Image"), System.Drawing.Image)
        Me.btnSubCatUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatUpdate.Location = New System.Drawing.Point(707, 13)
        Me.btnSubCatUpdate.Name = "btnSubCatUpdate"
        Me.btnSubCatUpdate.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatUpdate.TabIndex = 28
        Me.btnSubCatUpdate.Text = "Update"
        Me.btnSubCatUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatUpdate.UseVisualStyleBackColor = False
        '
        'btnSubCatSave
        '
        Me.btnSubCatSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubCatSave.BackColor = System.Drawing.Color.White
        Me.btnSubCatSave.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatSave.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatSave.Image = CType(resources.GetObject("btnSubCatSave.Image"), System.Drawing.Image)
        Me.btnSubCatSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatSave.Location = New System.Drawing.Point(614, 13)
        Me.btnSubCatSave.Name = "btnSubCatSave"
        Me.btnSubCatSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatSave.TabIndex = 22
        Me.btnSubCatSave.Text = "Save"
        Me.btnSubCatSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatSave.UseVisualStyleBackColor = False
        '
        'btnSubCatNew
        '
        Me.btnSubCatNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubCatNew.BackColor = System.Drawing.Color.White
        Me.btnSubCatNew.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCatNew.ForeColor = System.Drawing.Color.Black
        Me.btnSubCatNew.Image = CType(resources.GetObject("btnSubCatNew.Image"), System.Drawing.Image)
        Me.btnSubCatNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCatNew.Location = New System.Drawing.Point(521, 13)
        Me.btnSubCatNew.Name = "btnSubCatNew"
        Me.btnSubCatNew.Size = New System.Drawing.Size(87, 36)
        Me.btnSubCatNew.TabIndex = 25
        Me.btnSubCatNew.Text = "New"
        Me.btnSubCatNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubCatNew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Size = New System.Drawing.Size(348, 363)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sub Category Info"
        '
        'lblSubCatImagePath
        '
        Me.lblSubCatImagePath.AutoSize = True
        Me.lblSubCatImagePath.Location = New System.Drawing.Point(17, 355)
        Me.lblSubCatImagePath.Name = "lblSubCatImagePath"
        Me.lblSubCatImagePath.Size = New System.Drawing.Size(53, 19)
        Me.lblSubCatImagePath.TabIndex = 63
        Me.lblSubCatImagePath.Text = "Label4"
        Me.lblSubCatImagePath.Visible = False
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
        Me.btnSubCatBrowse.TabIndex = 19
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
        Me.btnSubCatRemove.TabIndex = 16
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
        Me.cmbCatName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCatName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCatName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCatName.FormattingEnabled = True
        Me.cmbCatName.Location = New System.Drawing.Point(137, 101)
        Me.cmbCatName.Name = "cmbCatName"
        Me.cmbCatName.Size = New System.Drawing.Size(149, 21)
        Me.cmbCatName.TabIndex = 7
        '
        'txtSubCatLocal
        '
        Me.txtSubCatLocal.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCatLocal.Location = New System.Drawing.Point(137, 63)
        Me.txtSubCatLocal.MaxLength = 40
        Me.txtSubCatLocal.Name = "txtSubCatLocal"
        Me.txtSubCatLocal.Size = New System.Drawing.Size(149, 21)
        Me.txtSubCatLocal.TabIndex = 4
        '
        'txtSubCatDisplayOrder
        '
        Me.txtSubCatDisplayOrder.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCatDisplayOrder.Location = New System.Drawing.Point(137, 139)
        Me.txtSubCatDisplayOrder.MaxLength = 4
        Me.txtSubCatDisplayOrder.Name = "txtSubCatDisplayOrder"
        Me.txtSubCatDisplayOrder.Size = New System.Drawing.Size(149, 21)
        Me.txtSubCatDisplayOrder.TabIndex = 10
        Me.txtSubCatDisplayOrder.Text = "0"
        '
        'txtSubCategory
        '
        Me.txtSubCategory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCategory.Location = New System.Drawing.Point(137, 25)
        Me.txtSubCategory.MaxLength = 40
        Me.txtSubCategory.Name = "txtSubCategory"
        Me.txtSubCategory.Size = New System.Drawing.Size(149, 21)
        Me.txtSubCategory.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Display Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 101)
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
        Me.ChkSubCategory.Size = New System.Drawing.Size(70, 23)
        Me.ChkSubCategory.TabIndex = 13
        Me.ChkSubCategory.Text = "Active"
        Me.ChkSubCategory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 63)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 48)
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
        'DisplaySubCategoryDish
        '
        Me.DisplaySubCategoryDish.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel11)
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel10)
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel9)
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel8)
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel7)
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel6)
        Me.DisplaySubCategoryDish.Controls.Add(Me.Panel5)
        Me.DisplaySubCategoryDish.Controls.Add(Me.DgwDisplaySubCatDish)
        Me.DisplaySubCategoryDish.Controls.Add(Me.DgwListDish)
        Me.DisplaySubCategoryDish.ForeColor = System.Drawing.Color.Black
        Me.DisplaySubCategoryDish.Location = New System.Drawing.Point(4, 34)
        Me.DisplaySubCategoryDish.Name = "DisplaySubCategoryDish"
        Me.DisplaySubCategoryDish.Padding = New System.Windows.Forms.Padding(3)
        Me.DisplaySubCategoryDish.Size = New System.Drawing.Size(907, 478)
        Me.DisplaySubCategoryDish.TabIndex = 2
        Me.DisplaySubCategoryDish.Text = "Add SubCategory Dish"
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Location = New System.Drawing.Point(515, 56)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(390, 34)
        Me.Panel11.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "SubCategory Dish"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Location = New System.Drawing.Point(0, 56)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(509, 34)
        Me.Panel10.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "List of dishes"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel9.Controls.Add(Me.txtSearchSubCatDish)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Location = New System.Drawing.Point(515, 95)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(389, 34)
        Me.Panel9.TabIndex = 26
        '
        'txtSearchSubCatDish
        '
        Me.txtSearchSubCatDish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchSubCatDish.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSubCatDish.Location = New System.Drawing.Point(202, 5)
        Me.txtSearchSubCatDish.Name = "txtSearchSubCatDish"
        Me.txtSearchSubCatDish.Size = New System.Drawing.Size(179, 21)
        Me.txtSearchSubCatDish.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(65, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Search Subcategory Dishes"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel8.Controls.Add(Me.txtSearchListOfDish)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Location = New System.Drawing.Point(1, 95)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(508, 34)
        Me.Panel8.TabIndex = 25
        '
        'txtSearchListOfDish
        '
        Me.txtSearchListOfDish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchListOfDish.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchListOfDish.Location = New System.Drawing.Point(323, 6)
        Me.txtSearchListOfDish.Name = "txtSearchListOfDish"
        Me.txtSearchListOfDish.Size = New System.Drawing.Size(179, 21)
        Me.txtSearchListOfDish.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(235, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Search Dishes"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.cmbSub2CategoryNam)
        Me.Panel7.Location = New System.Drawing.Point(1, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(903, 45)
        Me.Panel7.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(5, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Sub Category"
        '
        'cmbSub2CategoryNam
        '
        Me.cmbSub2CategoryNam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSub2CategoryNam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSub2CategoryNam.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSub2CategoryNam.FormattingEnabled = True
        Me.cmbSub2CategoryNam.Location = New System.Drawing.Point(79, 10)
        Me.cmbSub2CategoryNam.Name = "cmbSub2CategoryNam"
        Me.cmbSub2CategoryNam.Size = New System.Drawing.Size(179, 21)
        Me.cmbSub2CategoryNam.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel6.Controls.Add(Me.bttnDisplaySubCatDish)
        Me.Panel6.Controls.Add(Me.bttnSaveSubCategoryDish)
        Me.Panel6.Location = New System.Drawing.Point(515, 421)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(389, 54)
        Me.Panel6.TabIndex = 24
        '
        'bttnDisplaySubCatDish
        '
        Me.bttnDisplaySubCatDish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDisplaySubCatDish.Location = New System.Drawing.Point(35, 9)
        Me.bttnDisplaySubCatDish.Name = "bttnDisplaySubCatDish"
        Me.bttnDisplaySubCatDish.Size = New System.Drawing.Size(171, 39)
        Me.bttnDisplaySubCatDish.TabIndex = 15
        Me.bttnDisplaySubCatDish.Text = "Get Data"
        Me.bttnDisplaySubCatDish.UseVisualStyleBackColor = True
        '
        'bttnSaveSubCategoryDish
        '
        Me.bttnSaveSubCategoryDish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSaveSubCategoryDish.BackColor = System.Drawing.Color.White
        Me.bttnSaveSubCategoryDish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSaveSubCategoryDish.ForeColor = System.Drawing.Color.Black
        Me.bttnSaveSubCategoryDish.Image = CType(resources.GetObject("bttnSaveSubCategoryDish.Image"), System.Drawing.Image)
        Me.bttnSaveSubCategoryDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnSaveSubCategoryDish.Location = New System.Drawing.Point(297, 9)
        Me.bttnSaveSubCategoryDish.Name = "bttnSaveSubCategoryDish"
        Me.bttnSaveSubCategoryDish.Size = New System.Drawing.Size(86, 39)
        Me.bttnSaveSubCategoryDish.TabIndex = 19
        Me.bttnSaveSubCategoryDish.Text = "Save"
        Me.bttnSaveSubCategoryDish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttnSaveSubCategoryDish.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel5.Controls.Add(Me.bttnAddToGrid)
        Me.Panel5.Location = New System.Drawing.Point(0, 421)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(509, 54)
        Me.Panel5.TabIndex = 23
        '
        'bttnAddToGrid
        '
        Me.bttnAddToGrid.BackColor = System.Drawing.Color.White
        Me.bttnAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddToGrid.ForeColor = System.Drawing.Color.Black
        Me.bttnAddToGrid.Image = CType(resources.GetObject("bttnAddToGrid.Image"), System.Drawing.Image)
        Me.bttnAddToGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnAddToGrid.Location = New System.Drawing.Point(398, 9)
        Me.bttnAddToGrid.Name = "bttnAddToGrid"
        Me.bttnAddToGrid.Size = New System.Drawing.Size(102, 39)
        Me.bttnAddToGrid.TabIndex = 7
        Me.bttnAddToGrid.Text = "Add"
        Me.bttnAddToGrid.UseVisualStyleBackColor = False
        '
        'DgwDisplaySubCatDish
        '
        Me.DgwDisplaySubCatDish.AllowUserToAddRows = False
        Me.DgwDisplaySubCatDish.AllowUserToDeleteRows = False
        Me.DgwDisplaySubCatDish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgwDisplaySubCatDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgwDisplaySubCatDish.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgwDisplaySubCatDish.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwDisplaySubCatDish.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgwDisplaySubCatDish.ColumnHeadersHeight = 45
        Me.DgwDisplaySubCatDish.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subCatId_2, Me.DishId_2, Me.subCatName, Me.DishName__2, Me.DisplayOrder__2, Me.IsActive__2, Me.Remove_})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwDisplaySubCatDish.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgwDisplaySubCatDish.EnableHeadersVisualStyles = False
        Me.DgwDisplaySubCatDish.Location = New System.Drawing.Point(515, 135)
        Me.DgwDisplaySubCatDish.Name = "DgwDisplaySubCatDish"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwDisplaySubCatDish.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgwDisplaySubCatDish.RowHeadersVisible = False
        Me.DgwDisplaySubCatDish.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwDisplaySubCatDish.Size = New System.Drawing.Size(389, 280)
        Me.DgwDisplaySubCatDish.TabIndex = 12
        '
        'subCatId_2
        '
        Me.subCatId_2.HeaderText = "subCatID"
        Me.subCatId_2.Name = "subCatId_2"
        Me.subCatId_2.Visible = False
        '
        'DishId_2
        '
        Me.DishId_2.HeaderText = "DishId"
        Me.DishId_2.Name = "DishId_2"
        Me.DishId_2.Visible = False
        '
        'subCatName
        '
        Me.subCatName.HeaderText = "Subcategory "
        Me.subCatName.Name = "subCatName"
        Me.subCatName.ReadOnly = True
        Me.subCatName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DishName__2
        '
        Me.DishName__2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DishName__2.HeaderText = "Dish "
        Me.DishName__2.Name = "DishName__2"
        Me.DishName__2.ReadOnly = True
        Me.DishName__2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DishName__2.Width = 67
        '
        'DisplayOrder__2
        '
        Me.DisplayOrder__2.HeaderText = "Display Order"
        Me.DisplayOrder__2.Name = "DisplayOrder__2"
        Me.DisplayOrder__2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'IsActive__2
        '
        Me.IsActive__2.HeaderText = "IsActive"
        Me.IsActive__2.Name = "IsActive__2"
        Me.IsActive__2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IsActive__2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Remove_
        '
        Me.Remove_.HeaderText = "Remove"
        Me.Remove_.Name = "Remove_"
        Me.Remove_.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Remove_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DgwListDish
        '
        Me.DgwListDish.AllowUserToAddRows = False
        Me.DgwListDish.AllowUserToDeleteRows = False
        Me.DgwListDish.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgwListDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgwListDish.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgwListDish.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwListDish.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgwListDish.ColumnHeadersHeight = 45
        Me.DgwListDish.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DishId, Me.DishName, Me.DishNameLocal, Me.DisplayOrderDish, Me.Check})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwListDish.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgwListDish.EnableHeadersVisualStyles = False
        Me.DgwListDish.Location = New System.Drawing.Point(1, 135)
        Me.DgwListDish.MinimumSize = New System.Drawing.Size(4, 4)
        Me.DgwListDish.Name = "DgwListDish"
        Me.DgwListDish.RowHeadersVisible = False
        Me.DgwListDish.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwListDish.Size = New System.Drawing.Size(508, 280)
        Me.DgwListDish.TabIndex = 6
        '
        'DishId
        '
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.DishId.DefaultCellStyle = DataGridViewCellStyle9
        Me.DishId.HeaderText = "Dish ID"
        Me.DishId.Name = "DishId"
        Me.DishId.Visible = False
        '
        'DishName
        '
        Me.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DishName.FillWeight = 26.11486!
        Me.DishName.HeaderText = "Dish "
        Me.DishName.Name = "DishName"
        Me.DishName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DishName.Width = 170
        '
        'DishNameLocal
        '
        Me.DishNameLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DishNameLocal.FillWeight = 334.2703!
        Me.DishNameLocal.HeaderText = "Dish  Local"
        Me.DishNameLocal.Name = "DishNameLocal"
        Me.DishNameLocal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DishNameLocal.Width = 186
        '
        'DisplayOrderDish
        '
        Me.DisplayOrderDish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DisplayOrderDish.FillWeight = 19.3103!
        Me.DisplayOrderDish.HeaderText = "Display Order"
        Me.DisplayOrderDish.Name = "DisplayOrderDish"
        Me.DisplayOrderDish.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Check
        '
        Me.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Check.FillWeight = 20.30457!
        Me.Check.HeaderText = "check"
        Me.Check.Name = "Check"
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmDisplayCategoryAndSubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisplayCategoryAndSubCategory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        Me.DisplaySubCategoryDish.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DgwDisplaySubCatDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgwListDish, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblSubCatImagePath As Label
    Friend WithEvents DisplaySubCategoryDish As TabPage
    Friend WithEvents DgwDisplaySubCatDish As DataGridView
    Friend WithEvents DgwListDish As DataGridView
    Friend WithEvents bttnAddToGrid As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bttnSaveSubCategoryDish As Button
    Friend WithEvents cmbSub2CategoryNam As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtSearchSubCatDish As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtSearchListOfDish As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents bttnDisplaySubCatDish As Button
    Friend WithEvents Col_Cat_ID As DataGridViewTextBoxColumn
    Friend WithEvents Col_Category As DataGridViewTextBoxColumn
    Friend WithEvents Col_Category_Local As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cat_IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents Col_Category_Image As DataGridViewTextBoxColumn
    Friend WithEvents Col_Display_Order As DataGridViewTextBoxColumn
    Friend WithEvents DishId As DataGridViewTextBoxColumn
    Friend WithEvents DishName As DataGridViewTextBoxColumn
    Friend WithEvents DishNameLocal As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDish As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Sub_Category As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoryLocal As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents CategoryName As DataGridViewTextBoxColumn
    Friend WithEvents SubCatImage As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrder As DataGridViewTextBoxColumn
    Friend WithEvents category_id As DataGridViewTextBoxColumn
    Friend WithEvents subCatId_2 As DataGridViewTextBoxColumn
    Friend WithEvents DishId_2 As DataGridViewTextBoxColumn
    Friend WithEvents subCatName As DataGridViewTextBoxColumn
    Friend WithEvents DishName__2 As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrder__2 As DataGridViewTextBoxColumn
    Friend WithEvents IsActive__2 As DataGridViewCheckBoxColumn
    Friend WithEvents Remove_ As DataGridViewButtonColumn
End Class
