Imports System.Data.SqlClient

Public Class frm_Display_sub_cat_dish
    Private Sub frm_Display_sub_cat_dish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bttnUpdate.Enabled = False
        Dim con As New SqlConnection(connection)
        Dim Isdel As Boolean = False
        Dim query As String = "SELECT Dsh.ID,su.subcategory,di.DishName,Dsh.IsActive,Dsh.DisplayOrder,Dsh.IsDelete
                        FROM DisplaySubCategoryDish AS Dsh                                       
                        LEFT JOIN 
                            DisplaySubCategory AS su ON Dsh.subCatId = su.ID
                        LEFT JOIN 
                            Dish AS di ON Dsh.dishid = di.DishID where IsDelete=@Isdel"
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@IsDel", Isdel)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            DgwDisplaySubCatDish.Rows.Add(reader("ID"), reader("subcategory"), reader("DishName"), reader("IsActive"), reader("DisplayOrder"), reader("IsDelete"), "Remove")
        End While

        reader.Close()
        con.Close()
    End Sub

    Private Sub DgwDisplaySubCatDish_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwDisplaySubCatDish.CellContentClick
        ' Check if the clicked cell is in the "Remove" column and if the click was on a button

        If e.ColumnIndex = DgwDisplaySubCatDish.Columns("Remove_").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'fetch id from gridview and save into id variable
                Dim ID As Integer = Convert.ToInt32(DgwDisplaySubCatDish.Rows(e.RowIndex).Cells("ID").Value)

                ' Remove the row from the DataGridView
                DgwDisplaySubCatDish.Rows.RemoveAt(e.RowIndex)
                Dim con As New SqlConnection(connection)
                Dim isd As Boolean = True
                con.Open()
                Dim query As String = "update DisplaySubCategoryDish set IsDelete=@isd where ID=@ID"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@isd", isd)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        End If
    End Sub

    Private Sub DgwDisplaySubCatDish_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgwDisplaySubCatDish.CellEndEdit
        bttnUpdate.Enabled = True
        If e.ColumnIndex = DgwDisplaySubCatDish.Columns("DisplayOrder__2").Index AndAlso e.RowIndex >= 0 Then
            Dim cell As DataGridViewCell = DgwDisplaySubCatDish.Rows(e.RowIndex).Cells(e.ColumnIndex)
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

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click
        For Each row As DataGridViewRow In DgwDisplaySubCatDish.Rows
            Dim id As Integer = CInt(row.Cells("ID").Value())
            Dim isactive As Boolean = CBool(row.Cells("IsActive__2").Value)
            Dim dis_order As Boolean = CInt(row.Cells("DisplayOrder__2").Value)
            Dim query As String = "update DisplaySubCategoryDish set IsActive=@isa , DisplayOrder=@dis_order where ID=@ID"
            Dim con As New SqlConnection(connection)
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@isa", isactive)
            cmd.Parameters.AddWithValue("@dis_order", dis_order)
            cmd.Parameters.AddWithValue("@ID", id)
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        MessageBox.Show("Updated successfully")
    End Sub
End Class