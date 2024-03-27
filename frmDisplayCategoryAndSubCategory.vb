Imports System.Data.SqlClient

Public Class frmDisplayCategoryAndSubCategory
    Dim Catitem As Boolean
    Dim selectedCategoryId As Integer
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub bttnCatSave_Click(sender As Object, e As EventArgs) Handles bttnCatSave.Click

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
            Dim query As String = "Select ID, Category,CategoryLocal,
                                     IsActive, CategoryImage, DisplayOrder from DisplayCategory"
            ''''  cmd = New SqlCommand("SELECT CategoryName,Kitchen,VAT,ST,SC,BackColor,CategoryNameLocal,Cat_ID,isActive from Category", con) 
            cmd = New SqlCommand(query, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DgvCategory.Rows.Clear()
            While (rdr.Read() = True)
                DgvCategory.Rows.Add(rdr("ID"), rdr("Category"), rdr("CategoryLocal"), rdr("IsActive"), rdr("CategoryImage"), CStr(rdr("DisplayOrder")))
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
    Private Sub frmDisplayCategoryAndSubCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        ChkCategory.Checked = True
        bttnCatUpdate.Enabled = False
        bttnCatDelete.Enabled = False
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
            txtDisplayOrder.Text = selectedRow.Cells("Col_Display_Order").Value.ToString()
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
End Class