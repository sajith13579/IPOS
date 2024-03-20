Imports System.Data.SqlClient

Public Class frmDishQuantityChangeLog

    Public Sub all_print()
        Dim CN As New SqlConnection(connection)
        Dim fromDate As Date = dtpDateFromQua.Value
        Dim toDate As Date = dtpDateToQua.Value

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
        Dim cmd2 As New SqlCommand("GetAllQtyChangeLogByDateRange", CN)
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.Parameters.AddWithValue("@FromDate", fromDate)
        cmd2.Parameters.AddWithValue("@ToDate", toDate)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim datatable2 As New DataTable
        adapter2.Fill(ds, "QtyChangeLog")
        ' Merge the new DataTable into the existing DataSet
        'ds.Tables.Add(datatable.Copy())

        ' Load the Crystal Report
        Dim rpt2 As New RptQtychangeLog
        rpt2.Load(Application.StartupPath & "\Reports\RptQtychangeLog.rpt")

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
        Dim fromDate As Date = dtpDateFromQua.Value
        Dim toDate As Date = dtpDateToQua.Value
        If txtBillNumberQua.Text = "" Then
            If cmbOperatorQua.SelectedItem <> Nothing AndAlso cmbOperatorQua.SelectedItem.ToString() = "All" Then
                all_print()

            ElseIf cmbPermissionQua.SelectedItem <> Nothing AndAlso cmbPermissionQua.SelectedItem.ToString() = "All" Then
                all_print()

            ElseIf CmbBillTypeQua.SelectedItem <> Nothing AndAlso CmbBillTypeQua.SelectedItem.ToString() = "All" Then
                all_print()
            ElseIf cmbOperatorQua.SelectedItem = Nothing AndAlso CmbBillTypeQua.SelectedItem = Nothing AndAlso cmbPermissionQua.SelectedItem = Nothing Then
                all_print()

                'it is check all value cmboperator except all
            ElseIf cmbOperatorQua.SelectedItem <> Nothing AndAlso cmbOperatorQua.SelectedItem.ToString() <> "All" Then
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
                Dim operator1 As String = cmbOperatorQua.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetQtyChangeLogByOperatorAndDateRange", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@OperatorName", operator1)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "QtyChangeLog")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptQtychangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptQtychangeLog.rpt")

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

            ElseIf CmbBillTypeQua.SelectedItem <> Nothing AndAlso CmbBillTypeQua.SelectedItem.ToString() <> "All" Then
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
                Dim bill_type As String = CmbBillTypeQua.SelectedItem.ToString()
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
                Dim cmd2 As New SqlCommand("GetQtyChangeLogByBillTypeAndDateRange", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@BillType", bill_type)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "QtyChangeLog")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptQtychangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptQtychangeLog.rpt")

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

            ElseIf cmbPermissionQua.SelectedItem <> Nothing AndAlso cmbPermissionQua.SelectedItem <> "All" Then
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
                Dim permission As String = cmbPermissionQua.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetQtyChangeLogByPermissionAndDateRange", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@PermissionGrant", permission)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "QtyChangeLog")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptQtychangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptQtychangeLog.rpt")

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

            Dim cmd2 As New SqlCommand("SearchQtyChangeLogByBillNo", CN)
            cmd2.CommandType = CommandType.StoredProcedure
            Dim searchquery As String = txtBillNumberQua.Text.Trim()
            cmd2.Parameters.AddWithValue("@SearchQuery", searchquery)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim datatable2 As New DataTable
            adapter2.Fill(ds, "QtyChangeLog")
            ' Merge the new DataTable into the existing DataSet
            'ds.Tables.Add(datatable.Copy())

            ' Load the Crystal Report
            Dim rpt2 As New RptQtychangeLog
            rpt2.Load(Application.StartupPath & "\Reports\RptQtychangeLog.rpt")

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

    Public Sub ALL_ROW_qua()
        Dim conn As New SqlConnection(connection)
        Dim fromDate As Date = dtpDateFromQua.Value
        Dim toDate As Date = dtpDateToQua.Value
        Dim query As String = "select qcl.ID,qcl.BillNo,dsh.DishName,qcl.ChangedDate,qcl.OrgQty,qcl.ChangedQty,qcl.BillType,
            ER_Operator.EmployeeName As OperatorName,
            ER_PermissionGranted.EmployeeName AS PermissionGrantedName,
            qcl.Remarks,qcl.companyId ,qcl.Branchid 
            from QtyChangeLog as qcl 
            INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
            INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
            INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
            WHERE qcl.ChangedDate >= @FromDate AND qcl.ChangedDate <= @ToDate
          "

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)
        Try
            conn.Open()

            Dim read As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DatagridViewQty.Rows.Clear()

            Dim changed_qty_count As Decimal = 0
            Dim qty_diff_count As Decimal = 0
            While (read.Read())
                'org qty variable
                Dim org_qty As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim chng_qty As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type

                Dim result As Double = org_qty - chng_qty
                qty_diff_count = qty_diff_count + Math.Abs(result)
                Dim status As String = ""
                If chng_qty < org_qty Then
                    status = "Less"
                ElseIf chng_qty > org_qty Then
                    status = "High"
                ElseIf chng_qty = org_qty Then
                    status = "Equal"
                End If
                changed_qty_count = changed_qty_count + chng_qty
                DatagridViewQty.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
            End While
            read.Close()
            'txtRateDiffSum.Text = rate_diff_sum
            txtChangedQtyCount.Text = changed_qty_count
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub





    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFromQua.ValueChanged
        txtBillNumberQua.Text = ""
        If cmbOperatorQua.SelectedItem = "All" OrElse CmbBillTypeQua.SelectedItem = "All" OrElse cmbPermissionQua.SelectedItem = "All" Then
            ALL_ROW_qua()
        ElseIf cmbOperatorQua.SelectedItem <> "All" AndAlso cmbOperatorQua.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_qua_select_ind_change()
        ElseIf CmbBillTypeQua.SelectedItem <> "All" AndAlso CmbBillTypeQua.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            cmb_bill_qua_select_ind_change()
        ElseIf cmbPermissionQua.SelectedItem <> "All" AndAlso cmbPermissionQua.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            cmb_permission_qua_select_ind_change()
        Else
            ALL_ROW_qua()
        End If

    End Sub

    Public Sub cmb_op_qua_select_ind_change()
        If cmbOperatorQua.SelectedItem <> Nothing OrElse cmbOperatorQua.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumberQua.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        Dim selectedOperator As String
        Try
            selectedOperator = cmbOperatorQua.SelectedItem.ToString()
        Catch ex As Exception
            selectedOperator = Nothing
        End Try

        ' Check if "All" is selected
        If selectedOperator = "All" Then
            ALL_ROW_qua()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFromQua.Value
            Dim toDate As Date = dtpDateToQua.Value


            Dim query As String = "select qcl.ID,qcl.BillNo,dsh.DishName,qcl.ChangedDate,qcl.OrgQty,qcl.ChangedQty,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM QtyChangeLog  AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE qcl.OperatorId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @OperatorName) AND
                      qcl.ChangedDate >= @FromDate AND qcl.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridViewQty.Rows.Clear()

                Dim changed_qty_count As Decimal = 0
                Dim qty_diff_count As Decimal = 0
                While (read.Read())
                    'org qty variable
                    Dim org_qty As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim chng_qty As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type

                    Dim result As Double = org_qty - chng_qty
                    qty_diff_count = qty_diff_count + Math.Abs(result)
                    Dim status As String = ""
                    If chng_qty < org_qty Then
                        status = "Less"
                    ElseIf chng_qty > org_qty Then
                        status = "High"
                    ElseIf chng_qty = org_qty Then
                        status = "Equal"
                    End If
                    changed_qty_count = changed_qty_count + chng_qty
                    DatagridViewQty.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
                End While
                read.Close()
                'txtRateDiffSum.Text = rate_diff_sum
                txtChangedQtyCount.Text = changed_qty_count

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If


        cmbPermissionQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = Nothing
        cmbOperatorQua.SelectedItem = selectedOperator
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperatorQua.SelectedIndexChanged
        cmb_op_qua_select_ind_change()
    End Sub
    Public Sub LoadPermissionGrantedNames()
        cmbPermissionQua.Items.Insert(0, "All")
        Dim query As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM QtyChangeLog  AS ecl
                           INNER JOIN EmployeeRegistration AS ER ON ecl.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermissionQua.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using
    End Sub
    Public Sub fillBilltype()
        CmbBillTypeQua.Items.Add("Dine In")
        CmbBillTypeQua.Items.Add("Take Away")
        CmbBillTypeQua.Items.Add("Home Delivery")
        CmbBillTypeQua.Items.Add("Third Party")
        CmbBillTypeQua.Items.Add("Express Bill")
        CmbBillTypeQua.Items.Insert(0, "All")

    End Sub
    Private Sub frmDishQuantityChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load operators to combobox
        LoadEmployeeNames()
        'load permission to combobox
        LoadPermissionGrantedNames()
        fillBilltype()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
    End Sub

    'load operators
    Public Sub LoadEmployeeNames()
        cmbOperatorQua.Items.Insert(0, "All")
        'cmbOperator.SelectedIndex = 0
        Dim query As String = "SELECT DISTINCT EmployeeName FROM EmployeeRegistration"
        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbOperatorQua.Items.Add(reader("EmployeeName").ToString())
                End While
            End Using
        End Using
    End Sub

    Public Sub cmb_bill_qua_select_ind_change()
        txtBillNumberQua.Text = ""
        cmb_permission_select = False
        cmd_operator_select = False
        If CmbBillTypeQua.SelectedItem <> Nothing OrElse CmbBillTypeQua.SelectedItem <> "All" Then
            cmb_bill_select = True
        End If
        Dim select_bill_type As String
        Dim selectedItem As String
        Try
            select_bill_type = CmbBillTypeQua.SelectedItem.ToString()
            selectedItem = CmbBillTypeQua.SelectedItem.ToString().ToUpper()
            If selectedItem = "EXPRESS BILL" Then
                selectedItem = "TAEB"

            Else
                selectedItem = CmbBillTypeQua.SelectedItem.ToString().ToUpper()
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
            ALL_ROW_qua()
        Else
            Dim fromDate As Date = dtpDateFromQua.Value
            Dim toDate As Date = dtpDateToQua.Value


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgQty, qcl.ChangedQty,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM QtyChangeLog  AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE qcl.BillType=@BillType AND
                      qcl.ChangedDate >= @FromDate AND qcl.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BillType", selectedItem)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridViewQty.Rows.Clear()
                Dim changed_qty_count As Decimal = 0
                Dim qty_diff_count As Decimal = 0
                While (read.Read())
                    'org qty variable
                    Dim org_qty As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim chng_qty As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type

                    Dim result As Double = org_qty - chng_qty
                    qty_diff_count = qty_diff_count + Math.Abs(result)
                    Dim status As String = ""
                    If chng_qty < org_qty Then
                        status = "Less"
                    ElseIf chng_qty > org_qty Then
                        status = "High"
                    ElseIf chng_qty = org_qty Then
                        status = "Equal"
                    End If
                    changed_qty_count = changed_qty_count + chng_qty
                    DatagridViewQty.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
                End While
                read.Close()
                'txtRateDiffSum.Text = rate_diff_sum
                txtChangedQtyCount.Text = changed_qty_count

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbPermissionQua.SelectedItem = Nothing
        cmbOperatorQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = select_bill_type
    End Sub

    Private Sub CmbBillType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillTypeQua.SelectedIndexChanged
        cmb_bill_qua_select_ind_change()
    End Sub

    Public Sub cmb_permission_qua_select_ind_change()
        If cmbPermissionQua.SelectedItem <> Nothing OrElse cmbPermissionQua.SelectedItem <> "All" Then
            cmb_permission_select = True
        End If
        txtBillNumberQua.Text = ""
        cmb_bill_select = False
        cmd_operator_select = False
        Dim selectedPermission As String
        Try
            selectedPermission = cmbPermissionQua.SelectedItem.ToString()
        Catch ex As Exception
            selectedPermission = Nothing
        End Try

        ' Check if "All" is selected
        If selectedPermission = "All" Then
            ALL_ROW_qua()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFromQua.Value
            Dim toDate As Date = dtpDateToQua.Value


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgQty, qcl.ChangedQty,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM QtyChangeLog  AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE qcl.PermissionGrantedId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @permissionGrant) AND
                      qcl.ChangedDate >= @FromDate AND qcl.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@permissionGrant", selectedPermission)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridViewQty.Rows.Clear()

                Dim changed_qty_count As Decimal = 0
                Dim qty_diff_count As Decimal = 0
                While (read.Read())
                    'org qty variable
                    Dim org_qty As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                    Dim chng_qty As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type

                    Dim result As Double = org_qty - chng_qty
                    qty_diff_count = qty_diff_count + Math.Abs(result)
                    Dim status As String = ""
                    If chng_qty < org_qty Then
                        status = "Less"
                    ElseIf chng_qty > org_qty Then
                        status = "High"
                    ElseIf chng_qty = org_qty Then
                        status = "Equal"
                    End If
                    changed_qty_count = changed_qty_count + chng_qty
                    DatagridViewQty.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
                End While
                read.Close()
                'txtRateDiffSum.Text = rate_diff_sum
                txtChangedQtyCount.Text = changed_qty_count

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbOperatorQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = Nothing
        cmbPermissionQua.SelectedItem = selectedPermission
    End Sub

    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumberQua.TextChanged
        If txtBillNumberQua.Text = "" Then
            ALL_ROW_qua()

        Else
            searchbillno()
        End If
    End Sub

    Private Sub cmbPermission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermissionQua.SelectedIndexChanged
        cmb_permission_qua_select_ind_change()
    End Sub
    Public Sub searchbillno()
        Dim searchQuery As String = txtBillNumberQua.Text.Trim()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermissionQua.SelectedItem = Nothing
        cmbOperatorQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = Nothing

        'Dim fromDate As Date = dtpDateFrom.Value
        'Dim toDate As Date = dtpDateTo.Value

        'Dim query As String = "SELECT Id,BillNo,ChangedDate,OrgRate,ChangedRate,OperatorId,PermissionGrantedId,Remarks FROM RateChangeLog WHERE BillNo LIKE @SearchQuery AND ChangedDate >= @FromDate AND ChangedDate <= @ToDate"

        Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName ,qcl.ChangedDate, qcl.OrgRate, qcl.ChangedRate,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM RateChangeLog AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE BillNo LIKE @SearchQuery"



        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@SearchQuery", "%" & searchQuery & "%")
        'cmd.Parameters.AddWithValue("@FromDate", fromDate)
        'cmd.Parameters.AddWithValue("@ToDate", toDate)

        Try
            conn.Open()
            Dim read As SqlDataReader = cmd.ExecuteReader()
            DatagridViewQty.Rows.Clear()

            Dim changed_qty_count As Decimal = 0
            Dim qty_diff_count As Decimal = 0
            While (read.Read())
                'org qty variable
                Dim org_qty As Double = CDec(read(4)) ' Convert to Double or appropriate numerical type
                Dim chng_qty As Double = CDec(read(5)) ' Convert to Double or appropriate numerical type

                Dim result As Double = org_qty - chng_qty
                qty_diff_count = qty_diff_count + Math.Abs(result)
                Dim status As String = ""
                If chng_qty < org_qty Then
                    status = "Less"
                ElseIf chng_qty > org_qty Then
                    status = "High"
                ElseIf chng_qty = org_qty Then
                    status = "Equal"
                End If
                changed_qty_count = changed_qty_count + chng_qty
                DatagridViewQty.Rows.Add(read(0), read(1), read(2), read(3), read(4), read(5), Math.Abs(result), status, read(6), read(7), read(8), read(9), read(10), read(11))
            End While
            read.Close()
            'txtRateDiffSum.Text = rate_diff_sum
            txtChangedQtyCount.Text = changed_qty_count
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        Finally
            conn.Close()
        End Try
        txtBillNumberQua.Text = searchQuery + "  "
        txtBillNumberQua.SelectionStart = txtBillNumberQua.Text.IndexOf(searchQuery) + searchQuery.Length

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dtpDateFromQua.Value = DateTime.Today
        dtpDateToQua.Value = DateTime.Today
        'ComboBox1.SelectedIndex = 0
        'cmbOperator.SelectedIndex = 0
        txtBillNumberQua.Text = ""
        DatagridViewQty.Rows.Clear()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermissionQua.SelectedItem = Nothing
        cmbOperatorQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = Nothing
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ToExcel1(DatagridViewQty)
    End Sub

    Private Sub dtpDateToQua_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateToQua.ValueChanged
        txtBillNumberQua.Text = ""
        If cmbOperatorQua.SelectedItem = "All" OrElse CmbBillTypeQua.SelectedItem = "All" OrElse cmbPermissionQua.SelectedItem = "All" Then
            ALL_ROW_qua()
        ElseIf cmbOperatorQua.SelectedItem <> "All" AndAlso cmbOperatorQua.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_qua_select_ind_change()
        ElseIf CmbBillTypeQua.SelectedItem <> "All" AndAlso CmbBillTypeQua.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            cmb_bill_qua_select_ind_change()
        ElseIf cmbPermissionQua.SelectedItem <> "All" AndAlso cmbPermissionQua.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            cmb_permission_qua_select_ind_change()
        Else
            ALL_ROW_qua()
        End If
    End Sub
End Class