Imports System.Data.SqlClient
Public Class frmReceipCreditCusList
    Dim conn As New SqlConnection("Data Source=DEVSERVER\SQL2008Test;initial catalog=IPOSDbNew2;user id=sa;password=SQL@123")
    Private Sub frmReceipCreditCusList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        binddata()
    End Sub
    Public Sub binddata()
        Dim query As String = "select CreditCustomerID,Name,Address,ContactNo,Active,RegistrationDate from CreditCustomer"
        conn.Open()
        Dim cmd As New SqlCommand(query, conn)

        ' Use a SqlDataReader to read data row by row
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            ' Add a new row to the DataGridView and populate it with data
            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("col_Account_No").Value = reader("CreditCustomerID")
            DataGridView1.Rows(rowIndex).Cells("col_cus_name").Value = reader("Name")
            DataGridView1.Rows(rowIndex).Cells("colAdress").Value = reader("Address")
            DataGridView1.Rows(rowIndex).Cells("colContact").Value = reader("ContactNo")
            DataGridView1.Rows(rowIndex).Cells("colActive").Value = reader("Active")
            DataGridView1.Rows(rowIndex).Cells("colRegDate").Value = reader("RegistrationDate")
        End While

        conn.Close()
    End Sub

    Private Sub txtSearchCustName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustName.TextChanged
        Dim searchName As String = txtSearchCustName.Text.Trim()
        searchload(searchName)
    End Sub
    Private Sub searchload(searchName As String)
        Dim query As String = "select CreditCustomerID,Name,Address,ContactNo,Active,RegistrationDate from CreditCustomer where Name=@SearchName"
        conn.Open()
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@SearchName", searchName)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read()
            ' Add a new row to the DataGridView and populate it with data
            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("col_Account_No").Value = reader("CreditCustomerID")
            DataGridView1.Rows(rowIndex).Cells("col_cus_name").Value = reader("Name")
            DataGridView1.Rows(rowIndex).Cells("colAdress").Value = reader("Address")
            DataGridView1.Rows(rowIndex).Cells("colContact").Value = reader("ContactNo")
            DataGridView1.Rows(rowIndex).Cells("colActive").Value = reader("Active")
            DataGridView1.Rows(rowIndex).Cells("colRegDate").Value = reader("RegistrationDate")
        End While
        conn.Close()
    End Sub
End Class