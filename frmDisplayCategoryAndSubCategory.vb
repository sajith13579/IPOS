Imports System.Data.SqlClient

Public Class frmDisplayCategoryAndSubCategory
    Dim Catitem As Boolean
    Dim Sub_Catitem As Boolean
    Dim selectedCategoryId As Integer
    Dim selected_sub_CategoryId As Integer

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub bttnCatSave_Click(sender As Object, e As EventArgs) Handles bttnCatSave.Click
        If txtCatDisplayOrder.Text = "" Then
            txtCatDisplayOrder.Text = "0"
        End If
        If txtCategory.Text.Trim() = "" Then
            MessageBox.Show("Please enter category name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategory.Focus()
            Return
        End If

        Try
            Dim query As String = "SELECT Category FROM DisplayCategory WHERE Category = @ctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ctname", txtCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Category Already Exists")
                            txtCategory.Focus()
                            Return
                        End If
                    End Using
                End Using
            End Using






            If ChkCategory.Checked = True Then
                Catitem = True
            Else
                Catitem = False
            End If

            Dim imagePath As String = "\Display Category Images\" & Trim(txtCategory.Text) & ".jpg"

            Using con2 As New SqlConnection(connection)
                con2.Open()
                Dim query2 As String = "INSERT INTO DisplayCategory (Category, CategoryLocal, IsActive, CategoryImage, DisplayOrder)
                                    VALUES (@c1, @c2, @c3, @c4, @c5)"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@c1", txtCategory.Text)
                    cmd2.Parameters.AddWithValue("@c2", txtCategoryLocal.Text)
                    cmd2.Parameters.AddWithValue("@c3", Catitem)
                    cmd2.Parameters.AddWithValue("@c4", imagePath)
                    cmd2.Parameters.AddWithValue("@c5", CDec(txtCatDisplayOrder.Text))
                    cmd2.ExecuteNonQuery()
                End Using

                If Not System.IO.Directory.Exists(Application.StartupPath & "\Display Category Images") Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "\Display Category Images")
                End If
                PictBoxCat.Image.Save(Application.StartupPath & imagePath)
                MessageBox.Show("Category Added Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Reset()
        GetData()
    End Sub

    Private Sub bttnCatBrowse_Click(sender As Object, e As EventArgs) Handles bttnCatBrowse.Click
        Try
            ' Open file dialog to select an image
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            openFileDialog.Title = "Select an Image File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path
                Dim imagePath As String = openFileDialog.FileName

                ' Display the selected image in the PictureBox
                PictBoxCat.Image = Image.FromFile(imagePath)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub bttnCatRemove_Click(sender As Object, e As EventArgs) Handles bttnCatRemove.Click
        PictBoxCat.Image = Nothing
    End Sub

    Public Sub GetData()
        Try
            con = New SqlConnection(connection)
            con.Open()
            cmd = New SqlCommand("SELECT ID, Category, CategoryLocal, IsActive, CategoryImage, DisplayOrder FROM DisplayCategory", con)
            rdr = cmd.ExecuteReader()

            DgvCategory.Rows.Clear()

            While rdr.Read()
                DgvCategory.Rows.Add(rdr("ID"), rdr("Category"), rdr("CategoryLocal"), rdr("IsActive"), rdr("CategoryImage"), rdr("DisplayOrder"))
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Reset()
        txtCategory.Text = ""
        txtCategoryLocal.Text = ""
        'PictBoxCat.Image = Nothing
    End Sub

    Public Sub Reset_subCat()
        txtSubCategory.Text = ""
        txtCategoryLocal.Text = ""
        cmbCatName.SelectedIndex = 0
        txtSubCatLocal.Text = ""
        'PictBoxCat.Image = Nothing
    End Sub

    Public Sub GetCategoryCombo()
        ' Assuming your ComboBox is named cmbCategory
        Try
            Dim query As String = "SELECT Category, ID FROM DisplayCategory"
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    adpt = New SqlDataAdapter()
                    adpt.SelectCommand = New SqlCommand("SELECT Category, ID FROM DisplayCategory ", conn)
                    ds = New DataSet("ds")
                    adpt.Fill(ds)
                    Dim dtable = ds.Tables(0)
                    cmbCatName.DisplayMember = "Category"
                    cmbCatName.ValueMember = "ID"
                    cmbCatName.DataSource = dtable
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmDisplayCategoryAndSubCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        GetData_from_sub_cat()
        GetCategoryCombo()
        GetSubCategoryCombo()
        ChkCategory.Checked = True
        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False

        btnSubCatUpdate.Enabled = False
        btnSubCatDelete.Enabled = False
        Load_dish_to_grid()
    End Sub


    Public Sub GetSubCategoryCombo()
        ' Assuming your ComboBox is named cmbCategory
        Try
            Dim query As String = "SELECT subcategory, ID FROM DisplaySubCategory"
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    adpt = New SqlDataAdapter()
                    adpt.SelectCommand = New SqlCommand(query, con)
                    ds = New DataSet("ds")
                    adpt.Fill(ds)
                    Dim dtable = ds.Tables(0)
                    cmbSub2CategoryNam.DisplayMember = "subcategory"
                    cmbSub2CategoryNam.ValueMember = "ID"
                    cmbSub2CategoryNam.DataSource = dtable
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Load_dish_to_grid()
        Dim con As New SqlConnection(connection)
        con.Open()
        Dim query As String = "select DishID, DishName,DishNameLocal from Dish"
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            DgwListDish.Rows.Add(reader("DishID"), reader("DishName"), reader("DishNameLocal"), CStr(0))
        End While
        con.Close()
    End Sub

    Private Sub bttnCatNew_Click(sender As Object, e As EventArgs) Handles bttnCatNew.Click
        Reset()
        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False
        bttnCatSave.Enabled = True
    End Sub

    Private Sub DgvCategory_MouseClick(sender As Object, e As MouseEventArgs)
        If DgvCategory.SelectedRows.Count > 0 Then
            bttnCatUpdate.Enabled = True
            bttnCatDelete.Enabled = True
            bttnCatSave.Enabled = False

            Dim selectedRow As DataGridViewRow = DgvCategory.SelectedRows(0)
            selectedCategoryId = Convert.ToInt32(selectedRow.Cells("Col_Cat_ID").Value)
            txtCategory.Text = selectedRow.Cells("Col_Category").Value.ToString()
            __category = selectedRow.Cells("Col_Category").Value.ToString()
            txtCategoryLocal.Text = selectedRow.Cells("Col_Category_Local").Value.ToString()

            ChkCategory.Checked = Convert.ToBoolean(selectedRow.Cells("Col_Cat_IsActive").Value)
            txtCatDisplayOrder.Text = selectedRow.Cells("Col_Display_Order").Value.ToString()
            __categoryDisNum = selectedRow.Cells("Col_Display_Order").Value.ToString()
            lblCatImagePath.Text = selectedRow.Cells("Col_Category_Image").Value.ToString()
            PictBoxCat.ImageLocation = Application.StartupPath & "\" & lblCatImagePath.Text
        End If
    End Sub

    Private Sub bttnCatUpdate_Click(sender As Object, e As EventArgs) Handles bttnCatUpdate.Click
        If txtCategory.Text.Trim() = "" Then
            MessageBox.Show("Please enter category name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategory.Focus()
            Return
        End If


        Dim cat_dis_nmber = txtCatDisplayOrder.Text
        Try

            Dim query As String = "SELECT Category FROM DisplayCategory WHERE Category = @ctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ctname", txtCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            If __category = txtCategory.Text Then

                            Else
                                MessageBox.Show("Category  Already Exists It could not be updated")
                                txtCategory.Focus()
                                Return
                            End If
                        End If
                    End Using
                End Using
            End Using







            If ChkCategory.Checked = True Then
                Catitem = True
            Else
                Catitem = False
            End If

            Dim imagePath As String = "\Display Category Images\" & Trim(txtCategory.Text) & ".jpg"

            Using con2 As New SqlConnection(connection)
                con2.Open()
                Dim query2 As String = "update DisplayCategory set Category=@c1, CategoryLocal=@c2, IsActive=@c3, CategoryImage=@c4, DisplayOrder=@c5
                                                where ID=@c6"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@c1", txtCategory.Text)
                    cmd2.Parameters.AddWithValue("@c2", txtCategoryLocal.Text)
                    cmd2.Parameters.AddWithValue("@c3", Catitem)
                    cmd2.Parameters.AddWithValue("@c4", imagePath)
                    cmd2.Parameters.AddWithValue("@c5", CDec(txtCatDisplayOrder.Text))
                    cmd2.Parameters.AddWithValue("@c6", selectedCategoryId)
                    cmd2.ExecuteNonQuery()
                End Using

                If Not System.IO.Directory.Exists(Application.StartupPath & "\Display Category Images") Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "\Display Category Images")
                End If

                PictBoxCat.Image.Save(Application.StartupPath & imagePath)
                MessageBox.Show("Category updated  Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Reset()
        GetData()

        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False
        bttnCatSave.Enabled = True
    End Sub

    Private Sub bttnCatDelete_Click(sender As Object, e As EventArgs) Handles bttnCatDelete.Click
        Try
            Using con2 As New SqlConnection(connection)
                con2.Open()
                Dim query2 As String = "Delete from DisplayCategory where ID=@c6"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@c6", selectedCategoryId)
                    cmd2.ExecuteNonQuery()
                End Using
                MessageBox.Show("Category Deleted  Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Reset()
        GetData()
        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False
        bttnCatSave.Enabled = True
    End Sub

    Private Sub frmDisplayCategoryAndSubCategory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        ' Check if the click occurred outside the DataGridView
        If Not DgvCategory.ClientRectangle.Contains(DgvCategory.PointToClient(MousePosition)) Then
            ' Clear the selection in the DataGridView
            DgvCategory.ClearSelection()
        End If
    End Sub

    Private Sub DgvCategory_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub btnSubCatSave_Click(sender As Object, e As EventArgs) Handles btnSubCatSave.Click
        If txtSubCatDisplayOrder.Text = "" Then
            txtSubCatDisplayOrder.Text = "0"
        End If

        If txtSubCategory.Text.Trim() = "" Then
            MessageBox.Show("Please enter sub category name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSubCategory.Focus()
            Return
        End If

        Try
            ' Check if Subcategory name is provided
            If txtSubCategory.Text.Trim() = "" Then
                MessageBox.Show("Please enter sub category name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSubCategory.Focus()
                Return
            End If

            ' Check if Subcategory already exists
            Dim query As String = "SELECT subcategory FROM DisplaySubCategory WHERE subcategory = @sctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@sctname", txtSubCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Subcategory Already Exists")
                            txtSubCategory.Focus()
                            Return
                        End If
                    End Using
                End Using
            End Using

            ' Get selected Category ID
            Dim categoryId As Integer = Convert.ToInt32(cmbCatName.SelectedValue)

            ' Check if selected Category ID exists in DisplayCategory
            Dim query2 As String = "SELECT ID FROM DisplayCategory WHERE ID = @categoryId"
            Using con2 As New SqlConnection(connection)
                con2.Open()
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@categoryId", categoryId)
                    Using rdr2 As SqlDataReader = cmd2.ExecuteReader()
                        If Not rdr2.Read() Then
                            MessageBox.Show("This Category does not exist")
                            Return
                        End If
                    End Using
                End Using
            End Using

            ' Prepare image path
            Dim imagePath As String = "\Display Sub_Category Images\" & Trim(txtSubCategory.Text) & ".jpg"

            ' Insert new Subcategory
            Using con3 As New SqlConnection(connection)
                con3.Open()
                Dim query3 As String = "INSERT INTO DisplaySubCategory (subcategory, subcategoryLocal, IsActive, categoryId, subCatImage, DisplayOrder) VALUES (@sc1, @sc2, @sc3, @sc4, @sc5, @sc6)"
                Using cmd3 As New SqlCommand(query3, con3)
                    cmd3.Parameters.AddWithValue("@sc1", txtSubCategory.Text)
                    cmd3.Parameters.AddWithValue("@sc2", txtSubCatLocal.Text)
                    cmd3.Parameters.AddWithValue("@sc3", Sub_Catitem)
                    cmd3.Parameters.AddWithValue("@sc4", categoryId)
                    cmd3.Parameters.AddWithValue("@sc5", imagePath)
                    cmd3.Parameters.AddWithValue("@sc6", CDec(txtSubCatDisplayOrder.Text))
                    cmd3.ExecuteNonQuery()
                End Using

                ' Save image file
                If Not System.IO.Directory.Exists(Application.StartupPath & "\Display Sub_Category Images") Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "\Display Sub_Category Images")
                End If
                pictboxSubCat.Image.Save(Application.StartupPath & imagePath)

                MessageBox.Show("SubCategory Added Successfully")
                Reset_subCat()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Perform cleanup or additional actions if necessary
        End Try

        ' Refresh the DataGridView
        GetData_from_sub_cat()
    End Sub
    Public Sub GetData_from_sub_cat()
        Try
            'Dim query As String = "SELECT DSC.*,DC.category FROM Display_SubCategory 
            'as DSC inner join DisplayCategory as DC on DSC.categoryId=DC.ID"

            Dim query As String = "select DSC.ID , DSC.subcategory ,DSC.subcategoryLocal,DSC.IsActive , DC.Category,DSC.subCatImage,dSC.DisplayOrder,DSC.categoryId
            from  DisplaySubCategory as DSC inner join DisplayCategory as DC on DSC.categoryId=DC.ID"
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ' Clear existing rows in DataGridView
                        DgvSubCat.Rows.Clear()
                        ' Loop through the result set and add rows to the DataGridView
                        While reader.Read()
                            DgvSubCat.Rows.Add(reader("ID"), reader("subcategory"), reader("subcategoryLocal"), reader("IsActive"), reader("Category"), reader("subCatImage"), reader("DisplayOrder"), reader("categoryId"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSubCatBrowse_Click(sender As Object, e As EventArgs) Handles btnSubCatBrowse.Click
        Try
            ' Open file dialog to select an image
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            openFileDialog.Title = "Select an Image File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path
                Dim imagePath As String = openFileDialog.FileName

                ' Display the selected image in the PictureBox
                pictboxSubCat.Image = Image.FromFile(imagePath)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnSubCatRemove_Click(sender As Object, e As EventArgs) Handles btnSubCatRemove.Click
        pictboxSubCat.Image = Nothing
    End Sub

    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick

    End Sub

    Private Sub DgvSubCat_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub btnSubCatUpdate_Click(sender As Object, e As EventArgs) Handles btnSubCatUpdate.Click
        If txtSubCategory.Text.Trim() = "" Then
            MessageBox.Show("Please enter sub category name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategory.Focus()
            Return
        End If

        Try

            Dim query As String = "SELECT subcategory FROM DisplaySubCategory WHERE subcategory = @sctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@sctname", txtSubCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            If __subcategory = txtSubCategory.Text Then

                            Else
                                MessageBox.Show("subCategory name Already Exists It could not be updated")
                                Return
                            End If
                        End If
                    End Using
                End Using
            End Using


            If ChkSubCategory.Checked = True Then
                Sub_Catitem = True
            Else
                Sub_Catitem = False
            End If
            Dim categoryId As Integer = Convert.ToInt32(cmbCatName.SelectedValue)
            Dim imagePath As String = "\Display Sub_Category Images\" & Trim(txtCategory.Text) & ".jpg"

            Using con2 As New SqlConnection(connection)
                con2.Open()
                Dim query2 As String = "update DisplaySubCategory set subcategory=@sc1, subcategoryLocal=@sc2, IsActive=@sc3,categoryId=@sc4 , subCatImage=@sc5, DisplayOrder=@sc6
                                    where ID=@sc7"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@sc1", txtSubCategory.Text)
                    cmd2.Parameters.AddWithValue("@sc2", txtSubCatLocal.Text)
                    cmd2.Parameters.AddWithValue("@sc3", Sub_Catitem)
                    cmd2.Parameters.AddWithValue("@sc4", categoryId) 'category id  val mm
                    cmd2.Parameters.AddWithValue("@sc5", imagePath)
                    cmd2.Parameters.AddWithValue("@sc6", CDec(txtSubCatDisplayOrder.Text))
                    cmd2.Parameters.AddWithValue("@sc7", selected_sub_CategoryId)
                    cmd2.ExecuteNonQuery()
                End Using

                If Not System.IO.Directory.Exists(Application.StartupPath & "\Display Sub_Category Images") Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "\Display Sub_Category Images")
                End If
                pictboxSubCat.Image.Save(Application.StartupPath & imagePath)
                MessageBox.Show("SubCategory Updated Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
        Reset_subCat()
        btnSubCatUpdate.Enabled = False
        btnSubCatDelete.Enabled = False
        btnSubCatSave.Enabled = True
        GetData_from_sub_cat()
    End Sub

    Private Sub btnSubCatDelete_Click(sender As Object, e As EventArgs) Handles btnSubCatDelete.Click
        Try
            Using con2 As New SqlConnection(connection)
                con2.Open()
                Dim query2 As String = "Delete from DisplaySubCategory where ID=@c6"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@c6", selected_sub_CategoryId)
                    cmd2.ExecuteNonQuery()
                End Using
                MessageBox.Show("Subcategory Deleted  Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Reset_subCat()
        GetData_from_sub_cat()
        btnSubCatUpdate.Enabled = False
        btnSubCatDelete.Enabled = False
        btnSubCatSave.Enabled = True
    End Sub

    Private Sub txtCatDisplayOrder_TextChanged(sender As Object, e As EventArgs) Handles txtCatDisplayOrder.TextChanged
        ' Get the text from the TextBox
        Dim text As String = txtCatDisplayOrder.Text

        ' Check if the text is numeric
        If Not IsNumeric(text) Then
            ' If the text is not numeric, remove the last character
            If text.Length > 0 Then
                txtCatDisplayOrder.Text = text.Substring(0, text.Length - 1)
                txtCatDisplayOrder.SelectionStart = txtCatDisplayOrder.Text.Length
            Else
                txtCatDisplayOrder.Text = ""
            End If
        End If
    End Sub

    Private Sub txtSubCatDisplayOrder_TextChanged(sender As Object, e As EventArgs) Handles txtSubCatDisplayOrder.TextChanged
        ' Get the text from the TextBox
        Dim text As String = txtSubCatDisplayOrder.Text

        ' Check if the text is numeric
        If Not IsNumeric(text) Then
            ' If the text is not numeric, remove the last character
            If text.Length > 0 Then
                txtSubCatDisplayOrder.Text = text.Substring(0, text.Length - 1)
                txtSubCatDisplayOrder.SelectionStart = txtSubCatDisplayOrder.Text.Length
            Else
                txtSubCatDisplayOrder.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.TextChanged

    End Sub

    Private Sub btnSubCatNew_Click(sender As Object, e As EventArgs) Handles btnSubCatNew.Click
        Reset_subCat()
        btnSubCatUpdate.Enabled = False
        btnSubCatDelete.Enabled = False
        btnSubCatSave.Enabled = True
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles DisplaySubCategoryDish.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub bttnAddToGrid_Click(sender As Object, e As EventArgs) Handles bttnAddToGrid.Click

        For Each row As DataGridViewRow In DgwListDish.Rows()
            Dim isChecked = CBool(row.Cells("Check").Value)
            If isChecked Then
                'fetch display member
                Dim selectedSubcategory As String = cmbSub2CategoryNam.Text
                Dim Subcategory_ID As String = cmbSub2CategoryNam.SelectedValue
                Dim dishname As String = row.Cells("DishName").Value.ToString()
                Dim DishId_2 As String = row.Cells("DishId").Value.ToString()
                ' Dim dishname_local As String = row.Cells("DishNameLocal").Value.ToString()
                Dim diplay_order As String = ""

                diplay_order = row.Cells("DisplayOrderDish").Value.ToString()



                    ' Check if the combination already exists in DgwDisplaySubCatDish
                    Dim alreadyExists As Boolean = False
                For Each existingRow As DataGridViewRow In DgwDisplaySubCatDish.Rows
                    If existingRow.Cells("subCatName").Value.ToString() = selectedSubcategory AndAlso
                   existingRow.Cells("DishName__2").Value.ToString() = dishname Then
                        alreadyExists = True
                        Exit For
                    End If
                Next
                If Not alreadyExists Then
                    ' Add the data to DgwDisplaySubCatDish
                    DgwDisplaySubCatDish.Rows.Add(Subcategory_ID, DishId_2, selectedSubcategory, dishname, diplay_order, True, "Remove")
                End If

            End If
        Next
        'untick column
        untick_all()
    End Sub
    Public Sub untick_all()
        For Each row As DataGridViewRow In DgwListDish.Rows()
            Dim isChecked = CBool(row.Cells("Check").Value)
            If isChecked Then
                ' Dim dishname As String = row.Cells("DishName").Value.ToString()
                row.Cells("Check").Value = False
            End If
        Next
    End Sub

    Private Sub DgwListDish_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

        If DgwListDish.Rows.Count < 0 Then

            ' Check if the cell being validated is in the DisplayOrder column and the value is being changed
            ' Check if the changed cell is in the DisplayOrder column and the value is not empty
            If e.ColumnIndex = DgwListDish.Columns("DisplayOrderDish").Index AndAlso e.RowIndex >= 0 Then
                Dim cell As DataGridViewCell = DgwListDish.Rows(e.RowIndex).Cells(e.ColumnIndex)
                Dim newValue As String = cell.Value.ToString().Trim()

                ' Initialize the Tag property if it's currently Nothing
                If cell.Tag Is Nothing Then
                    cell.Tag = ""
                End If

                ' Check if the value is numeric
                If Not String.IsNullOrEmpty(newValue) AndAlso Not IsNumeric(newValue) Then
                    MessageBox.Show("Please enter a numeric value for the Display Order.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ' Reset the cell value to the previous value
                    cell.Value = cell.Tag
                Else
                    ' Store the valid value in the cell's Tag property for potential rollback
                    cell.Tag = newValue
                End If
            End If
        End If

    End Sub

    Private Sub DgwListDish_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DgwDisplaySubCatDish_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwDisplaySubCatDish.CellContentClick
        ' Check if the clicked cell is in the "Remove" column and if the click was on a button
        If e.ColumnIndex = DgwDisplaySubCatDish.Columns("Remove_").Index AndAlso e.RowIndex >= 0 Then
            ' Remove the row from the DataGridView
            DgwDisplaySubCatDish.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub DgwListDish_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgwListDish.CellEndEdit
        ' Check if the cell being validated is in the DisplayOrder column and the value is being changed
        ' Check if the changed cell is in the DisplayOrder column and the value is not empty
        If e.ColumnIndex = DgwListDish.Columns("DisplayOrderDish").Index AndAlso e.RowIndex >= 0 Then
            Dim cell As DataGridViewCell = DgwListDish.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim newValue As String
            Try
                newValue = cell.Value.ToString().Trim()
            Catch ex As Exception
                newValue = ""
            End Try

            'if displayorder column value is nothing newvalue variable is zero


            ' Initialize the Tag property if it's currently Nothing
            If cell.Tag Is Nothing Then
                cell.Tag = ""
            End If

            ' Check if the value is numeric
            If Not String.IsNullOrEmpty(newValue) AndAlso Not IsNumeric(newValue) Then
                MessageBox.Show("Please enter a numeric value for the Display Order.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Reset the cell value to the previous value
                cell.Value = CStr(0)

            ElseIf newValue = "" Then
                cell.Value = CStr(0)

            ElseIf CInt(newValue) < 0 Then
                MessageBox.Show("Don't allowed negative value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cell.Value = CStr(0)
            Else
                ' Store the valid value in the cell's Tag property for potential rollback
                cell.Tag = newValue
            End If
        End If
    End Sub

    Private Sub DgwListDish_CellValueChanged_1(sender As Object, e As DataGridViewCellEventArgs) Handles DgwListDish.CellValueChanged

    End Sub

    Private Sub DgwDisplaySubCatDish_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgwDisplaySubCatDish.CellEndEdit
        Dim newValue As String
        If e.ColumnIndex = DgwDisplaySubCatDish.Columns("DisplayOrder__2").Index AndAlso e.RowIndex >= 0 Then
            Dim cell As DataGridViewCell = DgwDisplaySubCatDish.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Try
                newValue = cell.Value.ToString().Trim()
            Catch ex As Exception
                newValue = ""
            End Try


            ' Initialize the Tag property if it's currently Nothing
            If cell.Tag Is Nothing Then
                cell.Tag = ""
            End If

            ' Check if the value is numeric
            If Not String.IsNullOrEmpty(newValue) AndAlso Not IsNumeric(newValue) Then
                MessageBox.Show("Please enter a numeric value for the Display Order.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Reset the cell value to the previous value
                cell.Value = CStr(0)

            ElseIf newValue = "" Then
                cell.Value = CStr(0)


            ElseIf CInt(newValue) < 0 Then
                MessageBox.Show("Don't allowed negative value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cell.Value = CStr(0)
            Else
                ' Store the valid value in the cell's Tag property for potential rollback
                cell.Tag = newValue
            End If
        End If
    End Sub

    Private Sub bttnSaveSubCategoryDish_Click(sender As Object, e As EventArgs) Handles bttnSaveSubCategoryDish.Click
        Dim subcategoryId, dis_ID, Disorder As Integer
        Dim active As Boolean
        For Each row As DataGridViewRow In DgwDisplaySubCatDish.Rows()
            'This for validation purpose
            Dim subcategoryName, disName As String
            subcategoryName = row.Cells("subCatName").Value.ToString()
            disName = row.Cells("DishName__2").Value.ToString()
            '-----------------------------------------------------

            subcategoryId = CInt(row.Cells("subCatId_2").Value.ToString())

            dis_ID = CInt(row.Cells("DishId_2").Value.ToString())
            ' Dim dishname_local As String = row.Cells("DishNameLocal").Value.ToString()
            Dim diplay_order As String = ""
            Try
                diplay_order = row.Cells("DisplayOrder__2").Value.ToString()
            Catch ex As Exception
                diplay_order = "0"
            End Try
            Disorder = CInt(diplay_order)
            Dim isChecked = CBool(row.Cells("IsActive__2").Value)
            If isChecked Then
                active = True
            Else
                active = False
            End If

            Dim queryy As String = "SELECT subCatId,dishid FROM DisplaySubCategoryDish WHERE subCatId = @s1 and dishid=@s2"
            Using conn As New SqlConnection(connection)
                conn.Open()
                Using cmdd As New SqlCommand(queryy, conn)
                    cmdd.Parameters.AddWithValue("@s1", subcategoryId)
                    cmdd.Parameters.AddWithValue("@s2", dis_ID)
                    Using rdr As SqlDataReader = cmdd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("This " & disName & " dishname already available in " & subcategoryName & " this Subcategory.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Continue For
                        End If
                    End Using
                End Using
            End Using


            Dim con As New SqlConnection(connection)
            Dim query As String = "insert into DisplaySubCategoryDish (subCatId,dishid,IsActive,DisplayOrder,IsDelete) values(@s1,@s2,@s3,@s4,@s5)"
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@s1", subcategoryId)
            cmd.Parameters.AddWithValue("@s2", dis_ID)
            cmd.Parameters.AddWithValue("@s3", active)
            cmd.Parameters.AddWithValue("@s4", Disorder)
            cmd.Parameters.AddWithValue("@s5", "False")
            cmd.ExecuteNonQuery()
            con.Close()

        Next
        MessageBox.Show("inserted successfully")
        DgwDisplaySubCatDish.Rows.Clear()
    End Sub



    Private Sub DgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DgvSubCat_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtSearchListOfDish_TextChanged(sender As Object, e As EventArgs) Handles txtSearchListOfDish.TextChanged
        Dim searchText As String = txtSearchListOfDish.Text.Trim().ToLower()
        For Each row As DataGridViewRow In DgwListDish.Rows
            Dim dishName As String = row.Cells("DishName").Value.ToString().ToLower()

            ' If the dishName contains the search text, make the row visible; otherwise, hide it
            row.Visible = dishName.Contains(searchText)
        Next
    End Sub

    Private Sub txtSearchSubCatDish_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSubCatDish.TextChanged
        Dim searchText As String = txtSearchSubCatDish.Text.Trim().ToLower()
        For Each row As DataGridViewRow In DgwDisplaySubCatDish.Rows
            Dim dishName As String = row.Cells("DishName__2").Value.ToString().ToLower()

            ' If the dishName contains the search text, make the row visible; otherwise, hide it
            row.Visible = dishName.Contains(searchText)
        Next
    End Sub

    Private Sub bttnDisplaySubCatDish_Click(sender As Object, e As EventArgs) Handles bttnDisplaySubCatDish.Click
        frm_Display_sub_cat_dish.ShowDialog()
        frm_Display_sub_cat_dish.Dispose()
    End Sub

    Private Sub DgvCategory_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DgvSubCat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSubCat.CellDoubleClick
        If DgvSubCat.SelectedRows.Count > 0 Then
            btnSubCatUpdate.Enabled = True
            btnSubCatDelete.Enabled = True
            btnSubCatSave.Enabled = False

            Dim selectedRow As DataGridViewRow = DgvSubCat.SelectedRows(0)
            selected_sub_CategoryId = Convert.ToInt32(selectedRow.Cells("ID").Value)
            txtSubCategory.Text = selectedRow.Cells("Sub_Category").Value.ToString()
            __subcategory = selectedRow.Cells("Sub_Category").Value.ToString()
            txtSubCatLocal.Text = selectedRow.Cells("SubCategoryLocal").Value.ToString()

            ChkSubCategory.Checked = Convert.ToBoolean(selectedRow.Cells("IsActive").Value)
            Dim categoryId As Integer = Convert.ToInt32(selectedRow.Cells("category_id").Value)
            cmbCatName.SelectedValue = categoryId


            cmbCatName.SelectedItem = selectedRow.Cells("CategoryName").Value.ToString()
            txtSubCatDisplayOrder.Text = selectedRow.Cells("DisplayOrder").Value.ToString()
            __categoryDisNum = selectedRow.Cells("DisplayOrder").Value.ToString()
            lblSubCatImagePath.Text = selectedRow.Cells("SubCatImage").Value.ToString()
            pictboxSubCat.ImageLocation = Application.StartupPath & "\" & lblSubCatImagePath.Text
        End If
    End Sub

    Private Sub DgvCategory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategory.CellDoubleClick
        If DgvCategory.SelectedRows.Count > 0 Then
            bttnCatUpdate.Enabled = True
            bttnCatDelete.Enabled = True
            bttnCatSave.Enabled = False

            Dim selectedRow As DataGridViewRow = DgvCategory.SelectedRows(0)
            selectedCategoryId = Convert.ToInt32(selectedRow.Cells("Col_Cat_ID").Value)
            txtCategory.Text = selectedRow.Cells("Col_Category").Value.ToString()
            __category = selectedRow.Cells("Col_Category").Value.ToString()
            txtCategoryLocal.Text = selectedRow.Cells("Col_Category_Local").Value.ToString()

            ChkCategory.Checked = Convert.ToBoolean(selectedRow.Cells("Col_Cat_IsActive").Value)
            txtCatDisplayOrder.Text = selectedRow.Cells("Col_Display_Order").Value.ToString()
            __categoryDisNum = selectedRow.Cells("Col_Display_Order").Value.ToString()
            lblCatImagePath.Text = selectedRow.Cells("Col_Category_Image").Value.ToString()
            PictBoxCat.ImageLocation = Application.StartupPath & "\" & lblCatImagePath.Text
        End If
    End Sub

    Private Sub cmbCatName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCatName.SelectedIndexChanged

    End Sub
End Class