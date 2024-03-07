Imports System.Data.SqlClient

Public Class frmDishRateChangeLog
    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value
        Dim query As String = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                      WHERE RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)
        Try
            conn.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            ' Clear existing rows in DataGridView
            DatagridView1.Rows.Clear()
            'DatagridView1.DataSource = datatable

            'Loop through datatable rows
            For Each row As DataRow In datatable.Rows
                Dim rowData(datatable.Columns.Count - 1) As String

                ' Loop through DataTable columns
                For i As Integer = 0 To datatable.Columns.Count - 1
                    ' Add the value of each column to the array
                    rowData(i) = row(i).ToString()
                Next
                ' Add the row data to the DataGridView
                DatagridView1.Rows.Add(rowData)
            Next

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumber.TextChanged
        searchbillno()
    End Sub

    Public Sub searchbillno()
        Dim searchQuery As String = txtBillNumber.Text.Trim()
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value

        Dim query As String = "SELECT Id,BillNo,ChangedDate,OrgRate,ChangedRate,OperatorId,PermissionGrantedId,Remarks FROM RateChangeLog WHERE BillNo LIKE @SearchQuery AND ChangedDate >= @FromDate AND ChangedDate <= @ToDate"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@SearchQuery", "%" & searchQuery & "%")
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)

        Try
            conn.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim datatable As New DataTable
            adapter.Fill(datatable)

            ' Clear existing rows in DataGridView
            DatagridView1.Rows.Clear()

            ' Loop through DataTable rows
            For Each row As DataRow In datatable.Rows
                ' Create an array to store column values for the current row
                Dim rowData(datatable.Columns.Count - 1) As String

                ' Loop through DataTable columns
                For i As Integer = 0 To datatable.Columns.Count - 1
                    ' Add the value of each column to the array
                    rowData(i) = row(i).ToString()
                Next

                ' Add the row data to the DataGridView
                DatagridView1.Rows.Add(rowData)
            Next

            ' Autofill columns according to DataGridView width
            DatagridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dtpDateFrom.Value = DateTime.Today
        dtpDateTo.Value = DateTime.Today
        'ComboBox1.SelectedIndex = 0
        cmbOperator.SelectedIndex = 0
        txtBillNumber.Text = ""
        DatagridView1.Rows.Clear()
    End Sub

    Private Sub frmDishRateChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeNames()
    End Sub


    ' Load the employee names into cmbOperator ComboBox
    Public Sub LoadEmployeeNames()
        Dim query As String = "SELECT EmployeeName FROM EmployeeRegistration"
        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbOperator.Items.Add(reader("EmployeeName").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
        ' Filter the search results in DataGridView based on the selected operator name
        Dim selectedOperator As String = cmbOperator.SelectedItem.ToString()
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value

        Dim query As String = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate, 
                                      ER_Operator.EmployeeName AS OperatorName, 
                                      ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                                      RCL.Remarks 
                               FROM RateChangeLog AS RCL
                               INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                               INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                               WHERE RCL.OperatorId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @OperatorName)
                                 AND RCL.ChangedDate >= @FromDate 
                                 AND RCL.ChangedDate <= @ToDate"
        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)
        Try
            conn.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            ' Clear existing rows in DataGridView
            DatagridView1.Rows.Clear()
            'DatagridView1.DataSource = datatable

            'Loop through datatable rows
            For Each row As DataRow In datatable.Rows
                Dim rowData(datatable.Columns.Count - 1) As String

                ' Loop through DataTable columns
                For i As Integer = 0 To datatable.Columns.Count - 1
                    ' Add the value of each column to the array
                    rowData(i) = row(i).ToString()
                Next
                ' Add the row data to the DataGridView
                DatagridView1.Rows.Add(rowData)
            Next

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub
End Class