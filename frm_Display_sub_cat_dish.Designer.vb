﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Display_sub_cat_dish
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgwDisplaySubCatDish = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCatId_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DishId_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive__2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DisplayOrder__2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDelete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remove_ = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DgwDisplaySubCatDish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgwDisplaySubCatDish
        '
        Me.DgwDisplaySubCatDish.AllowUserToAddRows = False
        Me.DgwDisplaySubCatDish.AllowUserToDeleteRows = False
        Me.DgwDisplaySubCatDish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgwDisplaySubCatDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgwDisplaySubCatDish.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwDisplaySubCatDish.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgwDisplaySubCatDish.ColumnHeadersHeight = 35
        Me.DgwDisplaySubCatDish.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.subCatId_2, Me.DishId_2, Me.IsActive__2, Me.DisplayOrder__2, Me.IsDelete, Me.Remove_})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwDisplaySubCatDish.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgwDisplaySubCatDish.EnableHeadersVisualStyles = False
        Me.DgwDisplaySubCatDish.Location = New System.Drawing.Point(0, 0)
        Me.DgwDisplaySubCatDish.Name = "DgwDisplaySubCatDish"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgwDisplaySubCatDish.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgwDisplaySubCatDish.RowHeadersVisible = False
        Me.DgwDisplaySubCatDish.Size = New System.Drawing.Size(798, 392)
        Me.DgwDisplaySubCatDish.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bttnUpdate)
        Me.Panel1.Location = New System.Drawing.Point(0, 398)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 50)
        Me.Panel1.TabIndex = 3
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Location = New System.Drawing.Point(595, 16)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(193, 24)
        Me.bttnUpdate.TabIndex = 0
        Me.bttnUpdate.Text = "Update"
        Me.bttnUpdate.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'subCatId_2
        '
        Me.subCatId_2.HeaderText = "Subcategory"
        Me.subCatId_2.Name = "subCatId_2"
        Me.subCatId_2.ReadOnly = True
        '
        'DishId_2
        '
        Me.DishId_2.HeaderText = "Dish"
        Me.DishId_2.Name = "DishId_2"
        Me.DishId_2.ReadOnly = True
        '
        'IsActive__2
        '
        Me.IsActive__2.HeaderText = "IsActive"
        Me.IsActive__2.Name = "IsActive__2"
        Me.IsActive__2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsActive__2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DisplayOrder__2
        '
        Me.DisplayOrder__2.HeaderText = "Display Order"
        Me.DisplayOrder__2.Name = "DisplayOrder__2"
        '
        'IsDelete
        '
        Me.IsDelete.HeaderText = "IsDelete"
        Me.IsDelete.Name = "IsDelete"
        Me.IsDelete.ReadOnly = True
        '
        'Remove_
        '
        Me.Remove_.HeaderText = "Remove"
        Me.Remove_.Name = "Remove_"
        Me.Remove_.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Remove_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frm_Display_sub_cat_dish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgwDisplaySubCatDish)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Display_sub_cat_dish"
        Me.Text = "frm_Display_sub_cat_dish"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgwDisplaySubCatDish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgwDisplaySubCatDish As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents subCatId_2 As DataGridViewTextBoxColumn
    Friend WithEvents DishId_2 As DataGridViewTextBoxColumn
    Friend WithEvents IsActive__2 As DataGridViewCheckBoxColumn
    Friend WithEvents DisplayOrder__2 As DataGridViewTextBoxColumn
    Friend WithEvents IsDelete As DataGridViewTextBoxColumn
    Friend WithEvents Remove_ As DataGridViewButtonColumn
End Class