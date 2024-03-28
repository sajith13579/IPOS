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
        cmbCatName.SelectedItem = Nothing
        'PictBoxCat.Image = Nothing
    End Sub

    Public Sub GetCategoryCombo()
        ' Assuming your ComboBox is named cmbCategory
        Try
            Dim query As String = "SELECT Category, ID FROM DisplayCategory"
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbCatName.Items.Add(New With {.Text = reader("Category").ToString(), .Value = reader("ID")})
                    End While
                End Using
            End Using
            ' Set the DisplayMember and ValueMember properties
            cmbCatName.DisplayMember = "Text"
            cmbCatName.ValueMember = "Value"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmDisplayCategoryAndSubCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        GetData_from_sub_cat()
        GetCategoryCombo()
        ChkCategory.Checked = True
        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False

        btnSubCatUpdate.Enabled = False
        btnSubCatDelete.Enabled = False

    End Sub

    Private Sub bttnCatNew_Click(sender As Object, e As EventArgs) Handles bttnCatNew.Click
        Reset()
        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False
        bttnCatSave.Enabled = True
    End Sub

    Private Sub DgvCategory_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvCategory.MouseClick
        If DgvCategory.SelectedRows.Count > 0 Then
            bttnCatUpdate.Enabled = True
            bttnCatDelete.Enabled = True
            bttnCatSave.Enabled = False

            Dim selectedRow As DataGridViewRow = DgvCategory.SelectedRows(0)
            selectedCategoryId = Convert.ToInt32(selectedRow.Cells("Col_Cat_ID").Value)
            txtCategory.Text = selectedRow.Cells("Col_Category").Value.ToString()
            txtCategoryLocal.Text = selectedRow.Cells("Col_Category_Local").Value.ToString()

            ChkCategory.Checked = Convert.ToBoolean(selectedRow.Cells("Col_Cat_IsActive").Value)
            txtCatDisplayOrder.Text = selectedRow.Cells("Col_Display_Order").Value.ToString()
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

        Try
            Dim query As String = "SELECT Category FROM DisplayCategory WHERE Category = @ctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ctname", txtCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Category Already Exists")
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
            txtCategory.Focus()
            Return
        End If


        Try
            Dim query As String = "SELECT subcategory FROM Display_SubCategory WHERE subcategory = @sctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@sctname", txtSubCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Subcategory Already Exists")
                            Return
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
                Dim query2 As String = "INSERT INTO Display_SubCategory (subcategory, subcategoryLocal, IsActive,categoryId , subCatImage, DisplayOrder)
                                    VALUES (@sc1, @sc2, @sc3, @sc4, @sc5,@sc6)"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@sc1", txtSubCategory.Text)
                    cmd2.Parameters.AddWithValue("@sc2", txtSubCatLocal.Text)
                    cmd2.Parameters.AddWithValue("@sc3", Sub_Catitem)
                    cmd2.Parameters.AddWithValue("@sc4", categoryId) 'category id  val mm
                    cmd2.Parameters.AddWithValue("@sc5", imagePath)
                    cmd2.Parameters.AddWithValue("@sc6", CDec(txtCatDisplayOrder.Text))
                    cmd2.ExecuteNonQuery()
                End Using

                If Not System.IO.Directory.Exists(Application.StartupPath & "\Display Sub_Category Images") Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "\Display Sub_Category Images")
                End If
                pictboxSubCat.Image.Save(Application.StartupPath & imagePath)
                MessageBox.Show("SubCategory Added Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
        ' Reset()
        GetData_from_sub_cat()
    End Sub
    Public Sub GetData_from_sub_cat()
        Try
            Dim query As String = "SELECT * FROM Display_SubCategory"
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ' Clear existing rows in DataGridView
                        DgvSubCat.Rows.Clear()
                        ' Loop through the result set and add rows to the DataGridView
                        While reader.Read()
                            DgvSubCat.Rows.Add(reader("ID"), reader("subcategory"), reader("subcategoryLocal"), reader("IsActive"), reader("categoryId"), reader("subCatImage"), reader("DisplayOrder"))
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

    Private Sub DgvSubCat_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvSubCat.MouseClick
        If DgvSubCat.SelectedRows.Count > 0 Then
            btnSubCatUpdate.Enabled = True
            btnSubCatDelete.Enabled = True
            btnSubCatSave.Enabled = False

            Dim selectedRow As DataGridViewRow = DgvSubCat.SelectedRows(0)
            selected_sub_CategoryId = Convert.ToInt32(selectedRow.Cells("ID").Value)
            txtSubCategory.Text = selectedRow.Cells("Sub_Category").Value.ToString()
            txtSubCatLocal.Text = selectedRow.Cells("SubCategoryLocal").Value.ToString()

            ChkSubCategory.Checked = Convert.ToBoolean(selectedRow.Cells("IsActive").Value)
            cmbCatName.SelectedItem = selectedRow.Cells("CategoryName").Value.ToString()
            txtSubCatDisplayOrder.Text = selectedRow.Cells("DisplayOrder").Value.ToString()
            lblSubCatImagePath.Text = selectedRow.Cells("SubCatImage").Value.ToString()
            pictboxSubCat.ImageLocation = Application.StartupPath & "\" & lblSubCatImagePath.Text
        End If
    End Sub

    Private Sub btnSubCatUpdate_Click(sender As Object, e As EventArgs) Handles btnSubCatUpdate.Click
        If txtSubCategory.Text.Trim() = "" Then
            MessageBox.Show("Please enter sub category name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategory.Focus()
            Return
        End If


        Try
            Dim query As String = "SELECT subcategory FROM Display_SubCategory WHERE subcategory = @sctname"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@sctname", txtSubCategory.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Subcategory Already Exists")
                            Return
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
                Dim query2 As String = "update Display_SubCategory set subcategory=@sc1, subcategoryLocal=@sc2, IsActive=@sc3,categoryId=@sc4 , subCatImage=@sc5, DisplayOrder=@sc6
                                    where ID=@sc7"
                Using cmd2 As New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@sc1", txtSubCategory.Text)
                    cmd2.Parameters.AddWithValue("@sc2", txtSubCatLocal.Text)
                    cmd2.Parameters.AddWithValue("@sc3", Sub_Catitem)
                    cmd2.Parameters.AddWithValue("@sc4", categoryId) 'category id  val mm
                    cmd2.Parameters.AddWithValue("@sc5", imagePath)
                    cmd2.Parameters.AddWithValue("@sc6", CDec(txtCatDisplayOrder.Text))
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
                Dim query2 As String = "Delete from Display_SubCategory where ID=@c6"
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
End Class