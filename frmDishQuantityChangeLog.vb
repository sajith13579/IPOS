Imports System.Data.SqlClient

Public Class frmDishQuantityChangeLog
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

    Public Sub ALL_ROW()
        Dim conn As New SqlConnection(connection)
        Dim fromDate As Date = dtpDateFrom.Value
        Dim toDate As Date = dtpDateTo.Value
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
    Public Sub GetOperatorData()
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


        cmbPermission.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbOperator.SelectedItem = selectedOperator
    End Sub

    Public Sub GetBillData()
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


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgRate, qcl.ChangedRate,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM QtyChangeLog  AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE RCL.BillType=@BillType AND
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

        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = select_bill_type
    End Sub
    Public Sub GetPermissionData()
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


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgRate, qcl.ChangedRate,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,RCL.companyId ,qcl.Branchid 
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

        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbPermission.SelectedItem = selectedPermission
    End Sub


    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        txtBillNumber.Text = ""
        If cmbOperator.SelectedItem = "All" OrElse CmbBillType.SelectedItem = "All" OrElse cmbPermission.SelectedItem = "All" Then
            ALL_ROW()
        ElseIf cmbOperator.SelectedItem <> "All" AndAlso cmbOperator.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            GetOperatorData()

        ElseIf CmbBillType.SelectedItem <> "All" AndAlso CmbBillType.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then
            GetBillData()

        ElseIf cmbPermission.SelectedItem <> "All" AndAlso cmbPermission.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then
            GetPermissionData()
        Else
            ALL_ROW()
        End If
        ALL_ROW()
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
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


        cmbPermission.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbOperator.SelectedItem = selectedOperator
    End Sub
    Public Sub LoadPermissionGrantedNames()
        cmbPermission.Items.Insert(0, "All")
        Dim query As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM QtyChangeLog  AS ecl
                           INNER JOIN EmployeeRegistration AS ER ON ecl.PermissionGrantedId = ER.EmpId"

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
    Public Sub fillBilltype()
        CmbBillType.Items.Add("Dine In")
        CmbBillType.Items.Add("Take Away")
        CmbBillType.Items.Add("Home Delivery")
        CmbBillType.Items.Add("Third Party")
        CmbBillType.Items.Add("Express Bill")
        CmbBillType.Items.Insert(0, "All")

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

    Private Sub CmbBillType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillType.SelectedIndexChanged
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


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgRate, qcl.ChangedRate,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM QtyChangeLog  AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE RCL.BillType=@BillType AND
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

        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = select_bill_type
    End Sub

    Private Sub cmbPermission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermission.SelectedIndexChanged
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


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgRate, qcl.ChangedRate,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,RCL.companyId ,qcl.Branchid 
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

        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        cmbPermission.SelectedItem = selectedPermission
    End Sub

    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumber.TextChanged
        If txtBillNumber.Text = "" Then
            ALL_ROW()

        Else
            searchbillno()
        End If
    End Sub
    Public Sub searchbillno()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermission.SelectedItem = Nothing
        cmbOperator.SelectedItem = Nothing
        CmbBillType.SelectedItem = Nothing
        Dim searchQuery As String = txtBillNumber.Text.Trim()
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

End Class