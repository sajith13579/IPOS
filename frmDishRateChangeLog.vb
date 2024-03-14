Imports System.Data.SqlClient

Public Class frmDishRateChangeLog
    Private Sub bttnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumber.TextChanged
        If txtBillNumber.Text = "" Then
            If cmbOperator.SelectedItem.ToString() = "All" Then
                operator_all()
            Else
                'SearchRadio.Checked = False
                'SearchRadio.PerformClick()
                bttnSearch.PerformClick()
            End If
        Else
            searchbillno()
        End If

    End Sub

    Public Sub searchbillno()
        Dim searchQuery As String = txtBillNumber.Text.Trim()
        'Dim fromDate As Date = dtpDateFrom.Value
        'Dim toDate As Date = dtpDateTo.Value

        'Dim query As String = "SELECT Id,BillNo,ChangedDate,OrgRate,ChangedRate,OperatorId,PermissionGrantedId,Remarks FROM RateChangeLog WHERE BillNo LIKE @SearchQuery AND ChangedDate >= @FromDate AND ChangedDate <= @ToDate"



        Dim query As String = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                      WHERE BillNo LIKE @SearchQuery"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@SearchQuery", "%" & searchQuery & "%")
        'cmd.Parameters.AddWithValue("@FromDate", fromDate)
        'cmd.Parameters.AddWithValue("@ToDate", toDate)

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
        Reset()
    End Sub
    Public Sub Reset()
        dtpDateFrom.Value = DateTime.Today
        dtpDateTo.Value = DateTime.Today
        'ComboBox1.SelectedIndex = 0
        'cmbOperator.SelectedIndex = 0
        txtBillNumber.Text = ""
        DatagridView1.Rows.Clear()
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbPermission.SelectedItem = Nothing
        cmb_bill_select = False
        cmd_operator_select = False
    End Sub
    Private Sub frmDishRateChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load operators to combobox
        LoadEmployeeNames()
        'load permission to combobox
        LoadPermissionGrantedNames()
        fillBilltype()
        cmd_operator_select = False
        cmb_bill_select = False
    End Sub

    Public Sub GetOperatorData()
        txtBillNumber.Text = ""

        Dim selectedOperator As String
        Try
            selectedOperator = cmbOperator.SelectedItem.ToString()
        Catch ex As Exception
            selectedOperator = Nothing
        End Try

        ' Check if "All" is selected
        If selectedOperator = "All" Then
            ALL_ROW()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFrom.Value
            Dim toDate As Date = dtpDateTo.Value


            Dim query As String = "SELECT RCL.Id, RCL.BillNo,dsh.DishName, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON RCL.DishId = dsh.DishID
                      WHERE RCL.OperatorId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @OperatorName) AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridView1.Rows.Clear()
                'DatagridView1.DataSource = datatable
                While (read.Read())
                    Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                    Dim result As Double = value1 - value2
                    DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), result, read(5), read(6), read(7), read(8), read(9), read(10))
                End While
                read.Close()


            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbPermission.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbOperator.SelectedItem = selectedOperator
    End Sub



    Public Sub fillBilltype()
        CmbBillType.Items.Add("Dine In")
        CmbBillType.Items.Add("Take Away")
        CmbBillType.Items.Add("Home Delivery")
        CmbBillType.Items.Add("Third Party")
        CmbBillType.Items.Add("Express Bill")
        CmbBillType.Items.Insert(0, "All")

    End Sub

    ' Load the employee names into cmbOperator ComboBox
    Public Sub LoadEmployeeNames()
        cmbOperator.Items.Insert(0, "All")
        'cmbOperator.SelectedIndex = 0
        Dim query As String = "SELECT DISTINCT EmployeeName FROM EmployeeRegistration"
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

    ' Load the Permission names into cmbOperator ComboBox
    Public Sub LoadPermissionGrantedNames()
        cmbPermission.Items.Insert(0, "All")
        Dim query As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM RateChangeLog AS RCL
                           INNER JOIN EmployeeRegistration AS ER ON RCL.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermission.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using
    End Sub


    Public Sub operator_all()
        txtBillNumber.Text = ""
        DatagridView1.Rows.Clear()
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value
        Dim query As String

        query = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId , RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                      WHERE  RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"


        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)

        Try
            conn.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            '' Clear existing rows in DataGridView

            'DatagridView1.DataSource = datatable

            ''Loop through datatable rows
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

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
        If cmbOperator.SelectedItem <> Nothing OrElse cmbOperator.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumber.Text = ""

        cmb_bill_select = False
        Dim selectedOperator As String
        Try
            selectedOperator = cmbOperator.SelectedItem.ToString()
        Catch ex As Exception
            selectedOperator = Nothing
        End Try

        ' Check if "All" is selected
        If selectedOperator = "All" Then
            ALL_ROW()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFrom.Value
            Dim toDate As Date = dtpDateTo.Value


            Dim query As String = "SELECT RCL.Id, RCL.BillNo,dsh.DishName , RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON RCL.DishId = dsh.DishID
                      WHERE RCL.OperatorId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @OperatorName) AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridView1.Rows.Clear()
                'DatagridView1.DataSource = datatable
                While (read.Read())
                    Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                    Dim result As Double = value1 - value2
                    DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), result, read(5), read(6), read(7), read(8), read(9), read(10))
                End While
                read.Close()


            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If


        cmbPermission.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbOperator.SelectedItem = selectedOperator
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim CN As New SqlConnection(connection)


        Dim MyCommand1 As New SqlCommand()
        Dim myDA1 As New SqlDataAdapter()
        Dim ds As New DataSet ' The DataSet you created.

        MyCommand1.Connection = CN
        MyCommand1.CommandText = "SELECT ID, HotelName, LocalName AS AddressLine1, Address AS AddressLine2, " &
                                "LocalAddress AS AddressLine3, ContactNo, EmailID, TIN, STNo, CIN, Logo, " &
                                "BaseCurrency, CurrencyCode, TicketFooterMessage, ShowLogo FROM Hotel"
        MyCommand1.CommandType = CommandType.Text
        myDA1.SelectCommand = MyCommand1
        myDA1.Fill(ds, "Hotel")

        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value
        If txtBillNumber.Text = "" Then
            If cmbOperator.SelectedItem.ToString() = "All" Then
                CN.Open()
                ' Call the stored procedure
                Dim cmd2 As New SqlCommand("GetRateChangeLog_Operator_all", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "RateChangeLog")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptRatechangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptRatechangeLog.rpt")

                ' Set the DataSource of the Crystal Report to the DataTable
                'rpt.SetDataSource(dataTable)
                rpt2.SetDataSource(ds)
                ' Show the report
                frmReport.CrystalReportViewer1.ReportSource = rpt2
                frmReport.ShowDialog()

                ' Clean up
                rpt2.Close()
                rpt2.Dispose()
                CN.Close()
            Else
                CN.Open()
                ' Call the stored procedure
                Dim operator1 As String = cmbOperator.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetRateChangeLogReportBySearch_OP", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@OperatorName", operator1)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "RateChangeLog")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptRatechangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptRatechangeLog.rpt")

                ' Set the DataSource of the Crystal Report to the DataTable
                'rpt.SetDataSource(dataTable)
                rpt2.SetDataSource(ds)
                ' Show the report
                frmReport.CrystalReportViewer1.ReportSource = rpt2
                frmReport.ShowDialog()

                ' Clean up
                rpt2.Close()
                rpt2.Dispose()
                CN.Close()
            End If
        Else
            CN.Open()
            ' Call the stored procedure
            Dim operator1 As String = cmbOperator.SelectedItem.ToString()
            Dim cmd2 As New SqlCommand("Get_Rate_Change_log_bill_num", CN)
            cmd2.CommandType = CommandType.StoredProcedure
            Dim searchquery As String = txtBillNumber.Text.Trim()
            cmd2.Parameters.AddWithValue("@SearchQuery", searchquery)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim datatable2 As New DataTable
            adapter2.Fill(ds, "RateChangeLog")
            ' Merge the new DataTable into the existing DataSet
            'ds.Tables.Add(datatable.Copy())

            ' Load the Crystal Report
            Dim rpt2 As New RptRatechangeLog
            rpt2.Load(Application.StartupPath & "\Reports\RptRatechangeLog.rpt")

            ' Set the DataSource of the Crystal Report to the DataTable
            'rpt.SetDataSource(dataTable)
            rpt2.SetDataSource(ds)
            ' Show the report
            frmReport.CrystalReportViewer1.ReportSource = rpt2
            frmReport.ShowDialog()

            ' Clean up
            rpt2.Close()
            rpt2.Dispose()
            CN.Close()
        End If
    End Sub

    Private Sub SearchRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SearchRadio.CheckedChanged

        txtBillNumber.Text = ""
        ' Check if the RadioButton is checked
        If SearchRadio.Checked Then
            ' Change the background color of the RadioButton when it is checked
            SearchRadio.BackColor = Color.Red ' You can set any color you want here
        Else
            ' If the RadioButton is not checked, revert the background color
            SearchRadio.BackColor = SystemColors.Control
        End If

        Dim selectedOperator As String = cmbOperator.SelectedItem.ToString()


        ' Check if "All" is selected
        If cmbOperator.SelectedItem.ToString() = "All" Then
            operator_all()

        Else
            Dim conn As New SqlConnection(connection)
            Dim fromDate As Date = dtpDateFrom.Value
            Dim toDate As Date = dtpDateTo.Value

            Dim query As String = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                      WHERE RCL.OperatorId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @OperatorName) AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"


            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)

            cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)


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
        End If

    End Sub
    Public Sub GetBillData()
        txtBillNumber.Text = ""

        If CmbBillType.SelectedItem <> Nothing OrElse CmbBillType.SelectedItem <> "All" Then
            cmb_bill_select = True
        End If
        Dim select_bill_type As String
        Dim selectedItem As String
        Try
            select_bill_type = CmbBillType.SelectedItem.ToString()
            selectedItem = CmbBillType.SelectedItem.ToString().ToUpper()
            If selectedItem = "EXPRESS BILL" Then
                selectedItem = "TAEB"
            ElseIf selectedItem = "ALL" Then
                bllAll()
            Else
                selectedItem = CmbBillType.SelectedItem.ToString().ToUpper()
                Dim words() As String = selectedItem.Split(" "c)
                If words.Length >= 2 Then
                    selectedItem = words(0).Substring(0, 1) & words(1).Substring(0, 1)
                ElseIf words.Length = 1 Then
                    selectedItem = words(0).Substring(0, Math.Min(2, words(0).Length))
                Else
                    selectedItem = ""
                End If
            End If
        Catch ex As Exception
            selectedItem = Nothing
        End Try
        ' Check if "All" is selected

        ' Filter the search results in DataGridView based on the selected operator name

        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value


        Dim query As String = "SELECT RCL.Id, RCL.BillNo,dsh.DishName , RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON RCL.DishId = dsh.DishID
                      WHERE RCL.BillType=@BillType AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@BillType", selectedItem)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)
        Try
            conn.Open()
            Dim read As SqlDataReader = cmd.ExecuteReader()
            ' Clear existing rows in DataGridView
            DatagridView1.Rows.Clear()
            'DatagridView1.DataSource = datatable
            While (read.Read())
                Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                Dim result As Double = value1 - value2
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), result, read(5), read(6), read(7), read(8), read(9))
            End While
            read.Close()


        Catch ex As Exception


        Finally
            conn.Close()
        End Try
        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = select_bill_type
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        'filter_data()
        'SearchRadio.Checked = False
        'SearchRadio.PerformClick()
        txtBillNumber.Text = ""
        'cmbOperator.SelectedItem = Nothing
        'CmbBillType.SelectedItem = Nothing
        'cmbPermission.SelectedItem = Nothing
        If cmbOperator.SelectedItem = "All" OrElse CmbBillType.SelectedItem = "All" OrElse cmbPermission.SelectedItem = "All" Then
            ALL_ROW()
        ElseIf cmbOperator.SelectedItem <> "All" AndAlso cmbOperator.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            GetOperatorData()

        ElseIf CmbBillType.SelectedItem <> "All" AndAlso CmbBillType.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then
            GetBillData()
        Else
            bttnSearch.PerformClick()
        End If
    End Sub



    Public Sub filter_data()
        Dim selectedOperator As String = ""

        If cmbOperator.SelectedItem IsNot Nothing AndAlso cmbOperator.SelectedItem.ToString() = "All" Then
            operator_all()
        ElseIf cmbOperator.SelectedItem IsNot Nothing Then
            selectedOperator = cmbOperator.SelectedItem.ToString()
        End If

        Dim searchQueryBillNO As String
        Try
            searchQueryBillNO = txtBillNumber.Text.Trim()
        Catch ex As Exception
            searchQueryBillNO = ""
        End Try
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value
        Dim query As String = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                      WHERE EmployeeName = @OperatorName AND RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate AND RCL.BillNo LIKE @BillNo"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)
        cmd.Parameters.AddWithValue("@BillNo", "%" & searchQueryBillNO & "%")
        cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)
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

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        'filter_data()
        txtBillNumber.Text = ""
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbPermission.SelectedItem = Nothing
        bttnSearch.PerformClick()
    End Sub

    Public Sub ALL_ROW()
        'Dim selectedOperator As String = cmbOperator.SelectedItem.ToString()
        Dim conn As New SqlConnection(connection)
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value

        Dim query As String = "SELECT RCL.Id, RCL.BillNo, RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                      WHERE RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"


        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)

        'cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)


        Try
            conn.Open()
            'Dim adapter As New SqlDataAdapter(cmd)
            Dim read As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            'Dim datatable As New DataTable
            'adapter.Fill(datatable)
            ' Clear existing rows in DataGridView
            DatagridView1.Rows.Clear()
            'DatagridView1.DataSource = datatable

            'Loop through datatable rows
            'For Each row As DataRow In datatable.Rows
            '    Dim rowData(datatable.Columns.Count - 1) As String

            '    ' Loop through DataTable columns
            '    For i As Integer = 0 To datatable.Columns.Count - 1
            '        ' Add the value of each column to the array
            '        rowData(i) = row(i).ToString()
            '    Next
            '    ' Add the row data to the DataGridView
            '    DatagridView1.Rows.Add(rowData)
            'Next
            While (read.Read())
                Dim value1 As Double = CDec(read(3)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim result As Double = value1 - value2
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), result, read(5), read(6), read(7), read(8), read(9))
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub bttnSearch_Click_1(sender As Object, e As EventArgs) Handles bttnSearch.Click
        txtBillNumber.Text = ""

        'Dim selectedOperator As String = cmbOperator.SelectedItem.ToString()
        Dim conn As New SqlConnection(connection)
            Dim fromDate As Date = dtpDateFrom.Value
            Dim toDate As Date = dtpDateTo.Value

        Dim query As String = "SELECT RCL.Id, RCL.BillNo,dsh.DishName ,RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON RCL.DishId = dsh.DishID
                      WHERE RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"


        Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)

        'cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)


        Try
            conn.Open()
            'Dim adapter As New SqlDataAdapter(cmd)
            Dim read As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            'Dim datatable As New DataTable
            'adapter.Fill(datatable)
            ' Clear existing rows in DataGridView
            DatagridView1.Rows.Clear()
            'DatagridView1.DataSource = datatable

            'Loop through datatable rows
            'For Each row As DataRow In datatable.Rows
            '    Dim rowData(datatable.Columns.Count - 1) As String

            '    ' Loop through DataTable columns
            '    For i As Integer = 0 To datatable.Columns.Count - 1
            '        ' Add the value of each column to the array
            '        rowData(i) = row(i).ToString()
            '    Next
            '    ' Add the row data to the DataGridView
            '    DatagridView1.Rows.Add(rowData)
            'Next
            While (read.Read())
                Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                Dim result As Double = value1 - value2
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), result, read(5), read(6), read(7), read(8), read(9), read(10))
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ToExcel1(DatagridView1)
    End Sub

    Public Sub bllAll()

    End Sub

    Private Sub CmbBillType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillType.SelectedIndexChanged
        txtBillNumber.Text = ""

        cmd_operator_select = False
        If CmbBillType.SelectedItem <> Nothing OrElse CmbBillType.SelectedItem <> "All" Then
            cmb_bill_select = True
        End If
        Dim select_bill_type As String
        Dim selectedItem As String
        Try
            select_bill_type = CmbBillType.SelectedItem.ToString()
            selectedItem = CmbBillType.SelectedItem.ToString().ToUpper()
            If selectedItem = "EXPRESS BILL" Then
                selectedItem = "TAEB"
            ElseIf selectedItem = "ALL" Then
                bllAll()
            Else
                selectedItem = CmbBillType.SelectedItem.ToString().ToUpper()
                Dim words() As String = selectedItem.Split(" "c)
                If words.Length >= 2 Then
                    selectedItem = words(0).Substring(0, 1) & words(1).Substring(0, 1)
                ElseIf words.Length = 1 Then
                    selectedItem = words(0).Substring(0, Math.Min(2, words(0).Length))
                Else
                    selectedItem = ""
                End If
            End If
        Catch ex As Exception
            select_bill_type = Nothing
            selectedItem = Nothing
        End Try
        ' Check if "All" is selected

        ' Filter the search results in DataGridView based on the selected operator name

        Dim fromDate As Date = dtpDateFrom.Value
            Dim toDate As Date = dtpDateTo.Value


        Dim query As String = "SELECT RCL.Id, RCL.BillNo,dsh.DishName , RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON RCL.DishId = dsh.DishID
                      WHERE RCL.BillType=@BillType AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

        Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BillType", selectedItem)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridView1.Rows.Clear()
                'DatagridView1.DataSource = datatable
                While (read.Read())
                Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                Dim result As Double = value1 - value2
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), result, read(5), read(6), read(7), read(8), read(9), read(10))
            End While
                read.Close()


            Catch ex As Exception


            Finally
                conn.Close()
            End Try

        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = select_bill_type

    End Sub
End Class