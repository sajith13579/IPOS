Imports System.Data.SqlClient

Public Class frmDishRateChangeLog
    Private Sub bttnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumber.TextChanged
        If txtBillNumber.Text = "" Then
            data_all()

        Else
            searchbillno()
        End If

    End Sub

    Public Sub searchbillno()
        Dim searchQuery As String = txtBillNumber.Text.Trim()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing

        'Dim fromDate As Date = dtpDateFrom.Value
        'Dim toDate As Date = dtpDateTo.Value

        'Dim query As String = "SELECT Id,BillNo,ChangedDate,OrgRate,ChangedRate,OperatorId,PermissionGrantedId,Remarks FROM RateChangeLog WHERE BillNo LIKE @SearchQuery AND ChangedDate >= @FromDate AND ChangedDate <= @ToDate"

        Dim query As String = "SELECT RCL.Id, RCL.BillNo,dsh.DishName ,RCL.ChangedDate, RCL.OrgRate, RCL.ChangedRate,RCL.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             RCL.Remarks,RCL.companyId ,RCL.Branchid 
                      FROM RateChangeLog AS RCL
                      INNER JOIN EmployeeRegistration AS ER_Operator ON RCL.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON RCL.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON RCL.DishId = dsh.DishID
                      WHERE BillNo LIKE @SearchQuery"



        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@SearchQuery", "%" & searchQuery & "%")
        'cmd.Parameters.AddWithValue("@FromDate", fromDate)
        'cmd.Parameters.AddWithValue("@ToDate", toDate)

        Try
            conn.Open()
            Dim read As SqlDataReader = cmd.ExecuteReader()
            DatagridView1.Rows.Clear()
            Dim original_rate_sum As Decimal = 0
            Dim rate_diff_sum As Decimal = 0
            While (read.Read())
                Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                Dim result As Double = value1 - value2
                rate_diff_sum = rate_diff_sum + Math.Abs(result)
                original_rate_sum = original_rate_sum + value2
                Dim status As String = ""
                If value2 < value1 Then
                    status = "Less"
                ElseIf value2 > value1 Then
                    status = "High"
                ElseIf value1 = value2 Then
                    status = "Equal"
                End If
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
            End While
            read.Close()
            txtRateDiffSum.Text = rate_diff_sum
            txtChangeRateSum.Text = original_rate_sum
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        Finally
            conn.Close()
        End Try
        txtBillNumber.Text = searchQuery + "  "
        txtBillNumber.SelectionStart = txtBillNumber.Text.IndexOf(searchQuery) + searchQuery.Length
        print_btn_RT_chg_enb_dis_qua()
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
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        txtRateDiffSum.Text = ""
        txtChangeRateSum.Text = ""
        print_btn_RT_chg_enb_dis_qua()
    End Sub


    Public Sub load_combobox_RT()
        'operator load
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

        'bill type load
        CmbBillType.Items.Add("Dine In")
        CmbBillType.Items.Add("Take Away")
        CmbBillType.Items.Add("Home Delivery")
        CmbBillType.Items.Add("Third Party")
        CmbBillType.Items.Add("Express Bill")
        CmbBillType.Items.Insert(0, "All")


        'permission
        cmbPermission.Items.Insert(0, "All")
        Dim query1 As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM RateChangeLog AS RCL
                           INNER JOIN EmployeeRegistration AS ER ON RCL.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query1, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermission.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using

    End Sub


    Public Sub print_btn_RT_chg_enb_dis_qua()
        If DatagridView1.Rows.Count > 0 Then
            BtnPrint.Enabled = True
            BtnPrint.BackColor = Color.HotPink
            btnExportExcel.Enabled = True
            btnExportExcel.BackColor = Color.HotPink
        Else
            BtnPrint.Enabled = False
            BtnPrint.BackColor = SystemColors.Control ' Reset button color to default
            btnExportExcel.Enabled = False
            btnExportExcel.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub frmDishRateChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_combobox_RT()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
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

    Public Sub select_oper_indx_RT_Ch()
        If cmbOperator.SelectedItem <> Nothing OrElse cmbOperator.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumber.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
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
                Dim changed_rate_sum As Decimal = 0
                Dim rate_diff_sum As Decimal = 0
                While (read.Read())
                    Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                    Dim result As Double = value1 - value2
                    rate_diff_sum = rate_diff_sum + Math.Abs(result)
                    changed_rate_sum = changed_rate_sum + value2
                    Dim status As String = ""
                    If value2 < value1 Then
                        status = "Less"
                    ElseIf value2 > value1 Then
                        status = "High"
                    ElseIf value1 = value2 Then
                        status = "Equal"
                    End If
                    DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
                End While
                read.Close()
                txtRateDiffSum.Text = rate_diff_sum
                txtChangeRateSum.Text = changed_rate_sum

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If


        cmbPermission.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbOperator.SelectedItem = selectedOperator
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
        select_oper_indx_RT_Ch()
    End Sub

    'print all operator, billtype , permisssion
    Public Sub all_print_RT()
        Dim CN As New SqlConnection(connection)
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value

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
        CN.Open()
        ' Call the stored procedure
        Dim cmd2 As New SqlCommand("GetRateChangeLog_all_data", CN)
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
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click


        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value
        If txtBillNumber.Text = "" Then
            If cmbOperator.SelectedItem <> Nothing AndAlso cmbOperator.SelectedItem.ToString() = "All" Then
                all_print_RT()

            ElseIf cmbPermission.SelectedItem <> Nothing AndAlso cmbPermission.SelectedItem.ToString() = "All" Then
                all_print_RT()

            ElseIf CmbBillType.SelectedItem <> Nothing AndAlso CmbBillType.SelectedItem.ToString() = "All" Then
                all_print_RT()
            ElseIf cmbOperator.SelectedItem = Nothing AndAlso CmbBillType.SelectedItem = Nothing AndAlso cmbPermission.SelectedItem = Nothing Then
                all_print_RT()

                'it is check all value cmboperator except all
            ElseIf cmbOperator.SelectedItem <> Nothing AndAlso cmbOperator.SelectedItem.ToString() <> "All" Then
                Dim CN As New SqlConnection(connection)
                CN.Open()
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
                ' Call the stored procedure
                Dim operator1 As String = cmbOperator.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetRateChangeLogByOperatorAndDate", CN)
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

            ElseIf CmbBillType.SelectedItem <> Nothing AndAlso CmbBillType.SelectedItem.ToString() <> "All" Then
                Dim CN As New SqlConnection(connection)
                CN.Open()
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

                ' Call the stored procedure
                Dim bill_type As String = CmbBillType.SelectedItem.ToString()
                If bill_type = "Dine In" Then
                    bill_type = "DI"
                End If
                If bill_type = "Take Away" Then
                    bill_type = "TA"
                End If
                If bill_type = "Home Delivery" Then
                    bill_type = "HD"
                End If
                If bill_type = "Third Party" Then
                    bill_type = "TP"
                End If
                If bill_type = "Express Bill" Then
                    bill_type = "TAEB"
                End If
                Dim cmd2 As New SqlCommand("GetRateChangeLogByBillTypeAndDate", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@BillType", bill_type)
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

            ElseIf cmbPermission.SelectedItem <> Nothing AndAlso cmbPermission.SelectedItem <> "All" Then
                Dim CN As New SqlConnection(connection)
                CN.Open()
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
                ' Call the stored procedure
                Dim permission As String = cmbPermission.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetRateChangeLogByPermissionAndDate", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@permissionGrant", permission)
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
            Dim CN As New SqlConnection(connection)
            CN.Open()
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
            ' Call the stored procedure

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






    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        'filter_data()
        'SearchRadio.Checked = False
        'SearchRadio.PerformClick()
        txtBillNumber.Text = ""
        'cmbOperator.SelectedItem = Nothing
        'CmbBillType.SelectedItem = Nothing
        'cmbPermission.SelectedItem = Nothing
        If cmbOperator.SelectedItem = "All" OrElse CmbBillType.SelectedItem = "All" OrElse cmbPermission.SelectedItem = "All" Then
            data_all()
        ElseIf cmbOperator.SelectedItem <> "All" AndAlso cmbOperator.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then

            select_oper_indx_RT_Ch()

        ElseIf CmbBillType.SelectedItem <> "All" AndAlso CmbBillType.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            select_bill_ty_indx_RT_Ch()

        ElseIf cmbPermission.SelectedItem <> "All" AndAlso cmbPermission.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            select_permi_indx_RT_Ch()
        Else
            ' bttnSearch.PerformClick()
            data_all()
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
        'SearchRadio.Checked = False
        'SearchRadio.PerformClick()
        txtBillNumber.Text = ""
        'cmbOperator.SelectedItem = Nothing
        'CmbBillType.SelectedItem = Nothing
        'cmbPermission.SelectedItem = Nothing
        If cmbOperator.SelectedItem = "All" OrElse CmbBillType.SelectedItem = "All" OrElse cmbPermission.SelectedItem = "All" Then
            data_all()
        ElseIf cmbOperator.SelectedItem <> "All" AndAlso cmbOperator.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then

            select_oper_indx_RT_Ch()

        ElseIf CmbBillType.SelectedItem <> "All" AndAlso CmbBillType.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            select_bill_ty_indx_RT_Ch()

        ElseIf cmbPermission.SelectedItem <> "All" AndAlso cmbPermission.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            select_permi_indx_RT_Ch()
        Else
            ' bttnSearch.PerformClick()
            data_all()
        End If
    End Sub

    Public Sub ALL_ROW()
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
            Dim changed_rate_sum As Decimal = 0
            Dim rate_diff_sum As Decimal = 0
            While (read.Read())
                Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type

                Dim result As Double = value1 - value2
                rate_diff_sum = rate_diff_sum + Math.Abs(result)
                Dim status As String = ""
                If value2 < value1 Then
                    status = "Less"
                ElseIf value2 > value1 Then
                    status = "High"
                ElseIf value1 = value2 Then
                    status = "Equal"
                End If
                changed_rate_sum = changed_rate_sum + value2
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
            End While
            read.Close()
            txtRateDiffSum.Text = rate_diff_sum
            txtChangeRateSum.Text = changed_rate_sum
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub data_all()
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
            Dim original_rate_sum As Decimal = 0
            Dim rate_diff_sum As Decimal = 0
            While (read.Read())
                Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                Dim result As Double = value1 - value2
                rate_diff_sum = rate_diff_sum + Math.Abs(result)
                original_rate_sum = original_rate_sum + value2

                Dim status As String = ""
                If value2 < value1 Then
                    status = "Less"
                ElseIf value2 > value1 Then
                    status = "High"
                ElseIf value1 = value2 Then
                    status = "Equal"
                End If
                DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
            End While
            read.Close()
            txtRateDiffSum.Text = rate_diff_sum
            txtChangeRateSum.Text = original_rate_sum
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try
        print_btn_RT_chg_enb_dis_qua()
    End Sub


    Private Sub bttnSearch_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ToExcel1(DatagridView1)
    End Sub

    Public Sub bllAll()

    End Sub
    Public Sub select_bill_ty_indx_RT_Ch()
        txtBillNumber.Text = ""
        cmb_permission_select = False
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
        If select_bill_type = "All" Then
            ALL_ROW()
        Else
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
                Dim changed_rate_sum As Decimal = 0
                Dim rate_diff_sum As Decimal = 0
                While (read.Read())
                    Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                    Dim result As Double = value1 - value2
                    rate_diff_sum = rate_diff_sum + Math.Abs(result)
                    changed_rate_sum = changed_rate_sum + value2
                    Dim status As String = ""
                    If value2 < value1 Then
                        status = "Less"
                    ElseIf value2 > value1 Then
                        status = "High"
                    ElseIf value1 = value2 Then
                        status = "Equal"
                    End If
                    DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
                End While
                read.Close()

                txtRateDiffSum.Text = rate_diff_sum
                txtChangeRateSum.Text = changed_rate_sum

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = select_bill_type
        print_btn_RT_chg_enb_dis_qua()
    End Sub
    Private Sub CmbBillType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillType.SelectedIndexChanged
        select_bill_ty_indx_RT_Ch()
    End Sub


    Public Sub select_permi_indx_RT_Ch()
        If cmbPermission.SelectedItem <> Nothing OrElse cmbPermission.SelectedItem <> "All" Then
            cmb_permission_select = True
        End If
        txtBillNumber.Text = ""
        cmb_bill_select = False
        cmd_operator_select = False
        Dim selectedPermission As String
        Try
            selectedPermission = cmbPermission.SelectedItem.ToString()
        Catch ex As Exception
            selectedPermission = Nothing
        End Try

        ' Check if "All" is selected
        If selectedPermission = "All" Then
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
                      WHERE RCL.PermissionGrantedId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @permissionGrant) AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@permissionGrant", selectedPermission)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridView1.Rows.Clear()
                'DatagridView1.DataSource = datatable
                Dim changed_rate_sum As Decimal = 0
                Dim rate_diff_sum As Decimal = 0
                While (read.Read())
                    Dim value1 As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim value2 As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type
                    Dim result As Double = value1 - value2
                    rate_diff_sum = rate_diff_sum + Math.Abs(result)
                    changed_rate_sum = changed_rate_sum + value2
                    Dim status As String = ""
                    If value2 < value1 Then
                        status = "Less"
                    ElseIf value2 > value1 Then
                        status = "High"
                    ElseIf value1 = value2 Then
                        status = "Equal"
                    End If
                    DatagridView1.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
                End While
                read.Close()
                txtRateDiffSum.Text = rate_diff_sum
                txtChangeRateSum.Text = changed_rate_sum

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbPermission.SelectedItem = selectedPermission
        print_btn_RT_chg_enb_dis_qua()
    End Sub


    Private Sub cmbPermission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermission.SelectedIndexChanged
        select_permi_indx_RT_Ch()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class