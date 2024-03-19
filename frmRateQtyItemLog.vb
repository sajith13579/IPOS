Imports System.Data.SqlClient

Public Class frmRateQtyItemLog
    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFromdl.ValueChanged
        txtBillNumberdl.Text = ""
        If cmbOperatordl.SelectedItem = "All" OrElse CmbBillTypedl.SelectedItem = "All" OrElse cmbPermissiondl.SelectedItem = "All" Then
            ALL_row_Itm_del()
        ElseIf cmbOperatordl.SelectedItem <> "All" AndAlso cmbOperatordl.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_selct_Index_change_del()

        ElseIf CmbBillTypedl.SelectedItem <> "All" AndAlso CmbBillTypedl.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then
            cmb_bill_typ_selct_Index_change_del()

        ElseIf cmbPermissiondl.SelectedItem <> "All" AndAlso cmbPermissiondl.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then
            cmb_permi_selct_Index_change_del()
        Else
            ALL_row_Itm_del()
        End If
    End Sub

    Public Sub sel_false()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
    End Sub

    'load operators
    Public Sub LoadEmployeeNames()
        cmbOperatordl.Items.Insert(0, "All")
        'cmbOperator.SelectedIndex = 0
        Dim query As String = "SELECT DISTINCT EmployeeName FROM EmployeeRegistration"
        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbOperatordl.Items.Add(reader("EmployeeName").ToString())
                End While
            End Using
        End Using
    End Sub

    Public Sub LoadPermissionGrantedNames_qty_ch()
        cmbPermissiondl.Items.Insert(0, "All")
        Dim query As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM QtyChangeLog  AS ecl
                           INNER JOIN EmployeeRegistration AS ER ON ecl.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermissiondl.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using
    End Sub

    Public Sub LoadPermissionGrantedNames_itm_del()
        cmbPermissiondl.Items.Insert(0, "All")
        Dim query As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM ItemDeleted  AS itd
                           INNER JOIN EmployeeRegistration AS ER ON itd.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermissiondl.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using
    End Sub


    Public Sub fillBilltype()
        CmbBillTypedl.Items.Add("Dine In")
        CmbBillTypedl.Items.Add("Take Away")
        CmbBillTypedl.Items.Add("Home Delivery")
        CmbBillTypedl.Items.Add("Third Party")
        CmbBillTypedl.Items.Add("Express Bill")
        CmbBillTypedl.Items.Insert(0, "All")
    End Sub
    Private Sub frmRateQtyItemLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''load operators to combobox
        'LoadEmployeeNames()
        ''load permission to combobox
        'LoadPermissionGrantedNames()
        'fillBilltype()
        'cmd_operator_select = False
        'cmb_bill_select = False
        'cmb_permission_select = False
        'cmd_operator_select = False
        'cmb_bill_select = False
        'cmb_permission_select = False
    End Sub






    Public Sub ClearAllDataGridViews()
        ' Iterate through each control on the form
        For Each ctrl As Control In Me.Controls
            ' Check if the control is a DataGridView
            If TypeOf ctrl Is DataGridView Then
                ' Clear the DataGridView's contents
                Dim dgv As DataGridView = DirectCast(ctrl, DataGridView)
                dgv.Rows.Clear()
            End If
        Next
    End Sub


    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting

        ClearAllDataGridViews()
        ' Check which tab is being selected
        Select Case e.TabPageIndex
            Case 0 ' TabPage 1 Rate change log
                sel_false()
            Case 1 ' TabPage 2 quantity change
                sel_false()
            Case 2 ' TabPage 3 item delete
                sel_false()
                ''load operators to combobox
                LoadEmployeeNames()
                fillBilltype()
                LoadPermissionGrantedNames_itm_del()
        End Select
    End Sub


    Public Sub ALL_row_Itm_del()
        Dim fromDate As Date = dtpDateFromdl.Value
        Dim toDate As Date = dtpDateTodl.Value
        Dim query As String = "SELECT itd.ID, itd.TicketId as BillNo, dsh.DishName, itd.KOTTime as Kotdate, itd.TableNo, itd.Quantity, itd.Rate, itd.BillType, 
                                 ER_Operator.EmployeeName AS OperatorName, 
                                 ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                                 itd.Remarks, itd.companyId, itd.Branchid 
                          FROM ItemDeleted AS itd
                          INNER JOIN EmployeeRegistration AS ER_Operator ON itd.OperatorId = ER_Operator.EmpId
                          INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON itd.PermissionGrantedId = ER_PermissionGranted.EmpId
                          INNER JOIN Dish AS dsh ON itd.Dish_Id = dsh.DishID
                          WHERE itd.KOTTime >= @FromDate AND itd.KOTTime <= @ToDate"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@FromDate", fromDate)
        cmd.Parameters.AddWithValue("@ToDate", toDate)

        Try
            conn.Open()
            Dim read As SqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in DataGridView
            DatagridViewItemDel.Rows.Clear()
            Dim amount As Decimal = 0
            Dim grand_tot As Decimal = 0
            While (read.Read())
                amount = CDec(read("Quantity")) * CDec(read("Rate"))
                grand_tot = grand_tot + amount
                DatagridViewItemDel.Rows.Add(read("ID"), read("BillNo"), read("DishName"), read("Kotdate"), read("TableNo"), read("Quantity"), read("Rate"), read("BillType"),
                                             read("OperatorName"), read("PermissionGrantedName"), read("Remarks"), read("companyId"), read("Branchid"))
            End While
            read.Close()
            txtGrandTotaldl.Text = grand_tot
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub cmb_op_selct_Index_change_del()
        If cmbOperatordl.SelectedItem <> Nothing OrElse cmbOperatordl.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumberdl.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        Dim selectedOperator As String
        Try
            selectedOperator = cmbOperatordl.SelectedItem.ToString()
        Catch ex As Exception
            selectedOperator = Nothing
        End Try

        ' Check if "All" is selected
        If selectedOperator = "All" Then
            ALL_row_Itm_del()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFromdl.Value
            Dim toDate As Date = dtpDateTodl.Value


            Dim query As String = "SELECT itd.ID, itd.TicketId as BillNo, dsh.DishName, itd.KOTTime as Kotdate, itd.TableNo, itd.Quantity,itd.Rate, itd.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             itd.Remarks, itd.companyId, itd.Branchid 
                      FROM ItemDeleted AS itd
                      INNER JOIN EmployeeRegistration AS ER_Operator ON itd.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON itd.PermissionGrantedId = ER_PermissionGranted.EmpId
                      INNER JOIN Dish AS dsh ON itd.Dish_Id = dsh.DishID
                      WHERE itd.OperatorId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @OperatorName) AND
                      itd.KOTTime >= @FromDate AND itd.KOTTime <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@OperatorName", selectedOperator)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridViewItemDel.Rows.Clear()

                Dim amount As Decimal = 0
                Dim grand_tot As Decimal = 0
                txtGrandTotaldl.Text = grand_tot
                While (read.Read())
                    amount = CDec(read("Quantity")) * CDec(read("Rate"))
                    grand_tot = grand_tot + amount
                    DatagridViewItemDel.Rows.Add(read("ID"), read("BillNo"), read("DishName"), read("Kotdate"), read("TableNo"), read("Quantity"), read("Rate"), read("BillType"),
                            read("OperatorName"), read("PermissionGrantedName"), read("Remarks"), read("companyId"), read("Branchid"))
                End While
                read.Close()
                txtGrandTotaldl.Text = grand_tot
            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If


        cmbPermissiondl.SelectedItem = Nothing
        CmbBillTypedl.SelectedItem = Nothing
        cmbOperatordl.SelectedItem = selectedOperator
    End Sub

    Private Sub cmbOperatordl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperatordl.SelectedIndexChanged
        cmb_op_selct_Index_change_del()
    End Sub

    Public Sub cmb_permi_selct_Index_change_del()
        If cmbPermissiondl.SelectedItem <> Nothing OrElse cmbPermissiondl.SelectedItem <> "All" Then
            cmb_permission_select = True
        End If
        txtBillNumberdl.Text = ""
        cmb_bill_select = False
        cmd_operator_select = False
        Dim selectedPermission As String
        Try
            selectedPermission = cmbPermissiondl.SelectedItem.ToString()
        Catch ex As Exception
            selectedPermission = Nothing
        End Try

        ' Check if "All" is selected
        If selectedPermission = "All" Then
            ALL_row_Itm_del()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFromdl.Value
            Dim toDate As Date = dtpDateTodl.Value

            Dim query As String = "SELECT itd.ID, itd.TicketId as BillNo, dsh.DishName, itd.KOTTime as Kotdate, itd.TableNo, itd.Quantity,itd.Rate, itd.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             itd.Remarks, itd.companyId, itd.Branchid 
                      FROM ItemDeleted AS itd
                      INNER JOIN EmployeeRegistration AS ER_Operator ON itd.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON itd.PermissionGrantedId = ER_PermissionGranted.EmpId
                      INNER JOIN Dish AS dsh ON itd.Dish_Id = dsh.DishID
                      WHERE itd.PermissionGrantedId IN (SELECT EmpId FROM EmployeeRegistration WHERE EmployeeName = @permissionGrant) AND
                      itd.KOTTime >= @FromDate AND itd.KOTTime <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@permissionGrant", selectedPermission)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridViewItemDel.Rows.Clear()

                Dim amount As Decimal = 0
                Dim grand_tot As Decimal = 0
                While (read.Read())
                    amount = CDec(read("Quantity")) * CDec(read("Rate"))
                    grand_tot = grand_tot + amount
                    DatagridViewItemDel.Rows.Add(read("ID"), read("BillNo"), read("DishName"), read("Kotdate"), read("TableNo"), read("Quantity"), read("Rate"), read("BillType"),
                            read("OperatorName"), read("PermissionGrantedName"), read("Remarks"), read("companyId"), read("Branchid"))
                End While
                read.Close()

                txtGrandTotaldl.Text = grand_tot

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbOperatordl.SelectedItem = Nothing
        CmbBillTypedl.SelectedItem = Nothing
        cmbPermissiondl.SelectedItem = selectedPermission
    End Sub

    Private Sub cmbPermissiondl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermissiondl.SelectedIndexChanged
        cmb_permi_selct_Index_change_del()
    End Sub

    Private Sub txtBillNumberdl_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumberdl.TextChanged
        If txtBillNumberdl.Text = "" Then
            ALL_row_Itm_del()

        Else
            searchbillno_del()
        End If
    End Sub

    Public Sub searchbillno_del()
        Dim searchQuery As String = txtBillNumberdl.Text.Trim()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermissiondl.SelectedItem = Nothing
        cmbOperatordl.SelectedItem = Nothing
        CmbBillTypedl.SelectedItem = Nothing

        'Dim fromDate As Date = dtpDateFrom.Value
        'Dim toDate As Date = dtpDateTo.Value

        'Dim query As String = "SELECT Id,BillNo,ChangedDate,OrgRate,ChangedRate,OperatorId,PermissionGrantedId,Remarks FROM RateChangeLog WHERE BillNo LIKE @SearchQuery AND ChangedDate >= @FromDate AND ChangedDate <= @ToDate"



        Dim query As String = "SELECT itd.ID, itd.TicketId as BillNo, dsh.DishName, itd.KOTTime as Kotdate, itd.TableNo, itd.Quantity,itd.Rate, itd.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             itd.Remarks, itd.companyId, itd.Branchid 
                      FROM ItemDeleted AS itd
                      INNER JOIN EmployeeRegistration AS ER_Operator ON itd.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON itd.PermissionGrantedId = ER_PermissionGranted.EmpId
                      INNER JOIN Dish AS dsh ON itd.Dish_Id = dsh.DishID
                      WHERE TicketId LIKE @SearchQuery"

        Dim conn As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@SearchQuery", "%" & searchQuery & "%")

        Try
            conn.Open()
            Dim read As SqlDataReader = cmd.ExecuteReader()
            DatagridViewItemDel.Rows.Clear()
            Dim amount As Decimal = 0
            Dim grand_tot As Decimal = 0
            txtGrandTotaldl.Text = grand_tot
            While (read.Read())
                amount = CDec(read("Quantity")) * CDec(read("Rate"))
                grand_tot = grand_tot + amount
                DatagridViewItemDel.Rows.Add(read("ID"), read("BillNo"), read("DishName"), read("Kotdate"), read("TableNo"), read("Quantity"), read("Rate"), read("BillType"),
                            read("OperatorName"), read("PermissionGrantedName"), read("Remarks"), read("companyId"), read("Branchid"))
            End While
            read.Close()
            txtGrandTotaldl.Text = grand_tot
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        Finally
            conn.Close()
        End Try
        txtBillNumberdl.Text = searchQuery + "  "
        txtBillNumberdl.SelectionStart = txtBillNumberdl.Text.IndexOf(searchQuery) + searchQuery.Length
    End Sub


    Public Sub cmb_bill_typ_selct_Index_change_del()
        txtBillNumberdl.Text = ""
        cmb_permission_select = False
        cmd_operator_select = False
        If CmbBillTypedl.SelectedItem <> Nothing OrElse CmbBillTypedl.SelectedItem <> "All" Then
            cmb_bill_select = True
        End If
        Dim select_bill_type As String
        Dim selectedItem As String
        Try
            select_bill_type = CmbBillTypedl.SelectedItem.ToString()
            selectedItem = CmbBillTypedl.SelectedItem.ToString().ToUpper()
            If selectedItem = "EXPRESS BILL" Then
                selectedItem = "TAEB"

            Else
                selectedItem = CmbBillTypedl.SelectedItem.ToString().ToUpper()
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
            ALL_row_Itm_del()
        Else
            Dim fromDate As Date = dtpDateFromdl.Value
            Dim toDate As Date = dtpDateTodl.Value




            Dim query As String = "SELECT itd.ID, itd.TicketId as BillNo, dsh.DishName, itd.KOTTime as Kotdate, itd.TableNo, itd.Quantity,itd.Rate, itd.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             itd.Remarks, itd.companyId, itd.Branchid 
                      FROM ItemDeleted AS itd
                      INNER JOIN EmployeeRegistration AS ER_Operator ON itd.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON itd.PermissionGrantedId = ER_PermissionGranted.EmpId
                      INNER JOIN Dish AS dsh ON itd.Dish_Id = dsh.DishID
                      WHERE itd.BillType=@BillType AND
                      itd.KOTTime >= @FromDate AND itd.KOTTime <= @ToDate"


            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BillType", selectedItem)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            Try
                conn.Open()
                Dim read As SqlDataReader = cmd.ExecuteReader()
                ' Clear existing rows in DataGridView
                DatagridViewItemDel.Rows.Clear()
                Dim amount As Decimal = 0
                Dim grand_tot As Decimal = 0
                txtGrandTotaldl.Text = grand_tot
                While (read.Read())
                    amount = CDec(read("Quantity")) * CDec(read("Rate"))
                    grand_tot = grand_tot + amount
                    DatagridViewItemDel.Rows.Add(read("ID"), read("BillNo"), read("DishName"), read("Kotdate"), read("TableNo"), read("Quantity"), read("Rate"), read("BillType"),
                            read("OperatorName"), read("PermissionGrantedName"), read("Remarks"), read("companyId"), read("Branchid"))
                End While
                read.Close()
                txtGrandTotaldl.Text = grand_tot

            Catch ex As Exception


            Finally
                conn.Close()
            End Try
        End If

        cmbPermissiondl.SelectedItem = Nothing
        cmbOperatordl.SelectedItem = Nothing
        CmbBillTypedl.SelectedItem = select_bill_type
    End Sub

    Private Sub CmbBillTypedl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillTypedl.SelectedIndexChanged
        cmb_bill_typ_selct_Index_change_del()
    End Sub
End Class