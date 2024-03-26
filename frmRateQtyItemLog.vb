Imports System.Data.SqlClient

Public Class frmRateQtyItemLog
    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFromdl.ValueChanged
        txtBillNumberdl.Text = ""
        If cmbOperatordl.SelectedItem = "All" OrElse CmbBillTypedl.SelectedItem = "All" OrElse cmbPermissiondl.SelectedItem = "All" OrElse cmbDishNameDl.SelectedItem = "All" Then
            ALL_row_Itm_del()
        ElseIf cmbOperatordl.SelectedItem <> "All" AndAlso cmbOperatordl.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_selct_Index_change_del()

        ElseIf CmbBillTypedl.SelectedItem <> "All" AndAlso CmbBillTypedl.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then
            cmb_bill_typ_selct_Index_change_del()

        ElseIf cmbPermissiondl.SelectedItem <> "All" AndAlso cmbPermissiondl.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then
            cmb_permi_selct_Index_change_del()

        ElseIf cmbDishNameDl.SelectedItem <> "All" AndAlso cmbDishNameDl.SelectedItem <> Nothing AndAlso cmb_Dish_select = True Then
            cmb_dish_selct_Index_change_del()
        Else
            ALL_row_Itm_del()
        End If
    End Sub

    Public Sub print_dl_en_dis()
        If DatagridViewItemDel.Rows.Count > 0 Then
            BtnPrintdl.Enabled = True
            BtnPrintdl.BackColor = Color.LightSteelBlue
            btnExportExceldl.Enabled = True
            btnExportExceldl.BackColor = Color.LightSteelBlue
        Else
            BtnPrintdl.Enabled = False
            BtnPrintdl.BackColor = SystemColors.Control ' Reset button color to default
            btnExportExceldl.Enabled = False
            btnExportExceldl.BackColor = SystemColors.Control
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
        load_combobox_RT()
        print_btn_RT_chg_enb_dis_qua()

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
        ' Check which tab is being selected
        Select Case e.TabPageIndex
            Case 0 ' TabPage 1 Rate change log

                'print button export excel already included Reset() function
                Reset()
                load_combobox_RT()
            Case 1 ' TabPage 2 quantity change
                resetQua()
                load_combobox_data_qua()
                'check gridview column function if it zero rows the print button and export excel will be disabled
                print_btn_enb_dis_qua()
            Case 2 ' TabPage 3 item delete
                Reset_dl()
                load_combobox_dl()
                'check gridview column function if it zero rows the print button and export excel will be disabled
                print_dl_en_dis()
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
        print_dl_en_dis()
    End Sub

    Public Sub cmb_op_selct_Index_change_del()
        If cmbOperatordl.SelectedItem <> Nothing OrElse cmbOperatordl.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumberdl.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        cmb_Dish_select = False

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
        cmbDishName.SelectedItem = Nothing
        cmbDishNameDl.SelectedItem = Nothing
        cmbOperatordl.SelectedItem = selectedOperator
        print_dl_en_dis()
    End Sub

    Public Sub cmb_dish_selct_Index_change_del()
        If cmbDishNameDl.SelectedItem <> Nothing OrElse cmbDishNameDl.SelectedItem <> "All" Then
            cmb_Dish_select = True
        End If
        txtBillNumberdl.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        cmd_operator_select = False
        Dim selectedDish As String
        Try
            selectedDish = cmbDishNameDl.SelectedItem.ToString()
        Catch ex As Exception
            selectedDish = Nothing
        End Try

        ' Check if "All" is selected
        If selectedDish = "All" Then
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
                      WHERE itd.Dish_Id IN (SELECT DishID FROM Dish WHERE Dishname = @Dishname) AND
                      itd.KOTTime >= @FromDate AND itd.KOTTime <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Dishname", selectedDish)
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
        cmbOperatordl.SelectedItem = Nothing
        cmbDishName.SelectedItem = selectedDish
        print_dl_en_dis()
    End Sub
    Public Sub load_combobox_dl()
        'operator load
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

        'bill type load
        CmbBillTypedl.Items.Add("Dine In")
        CmbBillTypedl.Items.Add("Take Away")
        CmbBillTypedl.Items.Add("Home Delivery")
        CmbBillTypedl.Items.Add("Third Party")
        CmbBillTypedl.Items.Add("Express Bill")
        CmbBillTypedl.Items.Insert(0, "All")


        'permission
        cmbPermissiondl.Items.Insert(0, "All")
        Dim query1 As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM ItemDeleted  AS itd
                           INNER JOIN EmployeeRegistration AS ER ON itd.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query1, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermissiondl.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using


        'Dishname

        cmbDishName.Items.Insert(0, "All")
        Dim query2 As String = "SELECT DISTINCT Dis.DishID ,  Dis.DishName 
                           FROM ItemDeleted AS itd
                           INNER JOIN Dish AS Dis ON itd.Dish_Id = Dis.DishID"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query2, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim dishName As String = reader("DishName").ToString()
                    cmbDishNameDl.Items.Add(dishName)
                End While
            End Using

        End Using

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
        cmb_Dish_select = False
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
        cmbDishNameDl.SelectedItem = Nothing
        cmbPermissiondl.SelectedItem = selectedPermission

        print_dl_en_dis()
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
        print_dl_en_dis()
    End Sub


    Public Sub cmb_bill_typ_selct_Index_change_del()
        txtBillNumberdl.Text = ""
        cmb_permission_select = False
        cmd_operator_select = False
        cmb_Dish_select = False
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
        cmbDishName.SelectedItem = Nothing
        cmbDishNameDl.SelectedItem = Nothing
        CmbBillTypedl.SelectedItem = select_bill_type

        print_dl_en_dis()
    End Sub

    Private Sub CmbBillTypedl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillTypedl.SelectedIndexChanged
        cmb_bill_typ_selct_Index_change_del()
    End Sub

    Public Sub all_print_dl()
        Dim CN As New SqlConnection(connection)
        Dim fromDate As Date = dtpDateFromdl.Value
        Dim toDate As Date = dtpDateTodl.Value

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
        Dim cmd2 As New SqlCommand("GetItemDeletedData", CN)
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.Parameters.AddWithValue("@FromDate", fromDate)
        cmd2.Parameters.AddWithValue("@ToDate", toDate)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim datatable2 As New DataTable
        adapter2.Fill(ds, "Item_delete")
        ' Merge the new DataTable into the existing DataSet
        'ds.Tables.Add(datatable.Copy())

        ' Load the Crystal Report
        Dim rpt2 As New RptItemDelete
        rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

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


    Private Sub BtnPrintdl_Click(sender As Object, e As EventArgs) Handles BtnPrintdl.Click
        Dim fromDate As Date = dtpDateFromdl.Value
        Dim toDate As Date = dtpDateTodl.Value
        If txtBillNumberdl.Text = "" Then
            If cmbOperatordl.SelectedItem <> Nothing AndAlso cmbOperatordl.SelectedItem.ToString() = "All" Then
                all_print_dl()

            ElseIf cmbPermissiondl.SelectedItem <> Nothing AndAlso cmbPermissiondl.SelectedItem.ToString() = "All" Then
                all_print_dl()

            ElseIf CmbBillTypedl.SelectedItem <> Nothing AndAlso CmbBillTypedl.SelectedItem.ToString() = "All" Then
                all_print_dl()

            ElseIf cmbDishNameDl.SelectedItem <> Nothing AndAlso cmbDishNameDl.SelectedItem.ToString() = "All" Then
                all_print_dl()

            ElseIf cmbOperatordl.SelectedItem = Nothing AndAlso CmbBillTypedl.SelectedItem = Nothing AndAlso cmbPermissiondl.SelectedItem = Nothing AndAlso cmbDishNameDl.SelectedItem = Nothing Then
                all_print_dl()

            ElseIf cmbOperatordl.SelectedItem <> Nothing AndAlso cmbOperatordl.SelectedItem.ToString() <> "All" Then
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
                Dim operator1 As String = cmbOperatordl.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetItemDeletedDataByOperatore", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@OperatorName", operator1)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "Item_delete")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptItemDelete
                rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

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

            ElseIf CmbBillTypedl.SelectedItem <> Nothing AndAlso CmbBillTypedl.SelectedItem.ToString() <> "All" Then
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
                Dim bill_type As String = CmbBillTypedl.SelectedItem.ToString()
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
                Dim cmd2 As New SqlCommand("GetItemDeletedDataByBillType", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@BillType", bill_type)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "Item_delete")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptItemDelete
                rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

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

            ElseIf cmbPermissiondl.SelectedItem <> Nothing AndAlso cmbPermissiondl.SelectedItem <> "All" Then
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
                Dim permission As String = cmbPermissiondl.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GeItemDeleteDataByPermission", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@PermissionGrant", permission)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "Item_delete")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptItemDelete
                rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

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

            ElseIf cmbDishNameDl.SelectedItem <> Nothing AndAlso cmbDishNameDl.SelectedItem <> "All" Then
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
                Dim dishname As String = cmbDishNameDl.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetItemDeletedByDish", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@Dishname", dishname)
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim datatable2 As New DataTable
                adapter2.Fill(ds, "Item_delete")
                ' Merge the new DataTable into the existing DataSet
                'ds.Tables.Add(datatable.Copy())

                ' Load the Crystal Report
                Dim rpt2 As New RptItemDelete
                rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

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

            Dim cmd2 As New SqlCommand("GetItemDeletedByBillNo", CN)
            cmd2.CommandType = CommandType.StoredProcedure
            Dim searchquery As String = txtBillNumberdl.Text.Trim()
            cmd2.Parameters.AddWithValue("@SearchQuery", searchquery)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim datatable2 As New DataTable
            adapter2.Fill(ds, "Item_delete")
            ' Merge the new DataTable into the existing DataSet
            'ds.Tables.Add(datatable.Copy())

            ' Load the Crystal Report
            Dim rpt2 As New RptItemDelete
            rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

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

    Public Sub Reset_dl()
        dtpDateFromdl.Value = DateTime.Today
        dtpDateTodl.Value = DateTime.Today
        'ComboBox1.SelectedIndex = 0
        'cmbOperator.SelectedIndex = 0
        txtBillNumberdl.Text = ""
        DatagridViewItemDel.Rows.Clear()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmbPermissiondl.SelectedItem = Nothing
        cmbOperatordl.SelectedItem = Nothing
        CmbBillTypedl.SelectedItem = Nothing
        cmbDishNameDl.SelectedItem = Nothing
        BtnPrintdl.Enabled = False
        txtGrandTotaldl.Text = ""
    End Sub

    Private Sub btnResetdl_Click(sender As Object, e As EventArgs) Handles btnResetdl.Click
        Reset_dl()
    End Sub

    Private Sub btnExportExceldl_Click(sender As Object, e As EventArgs) Handles btnExportExceldl.Click
        ToExcel1(DatagridViewItemDel)
    End Sub

    Private Sub dtpDateTodl_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTodl.ValueChanged
        txtBillNumberdl.Text = ""
        If cmbOperatordl.SelectedItem = "All" OrElse CmbBillTypedl.SelectedItem = "All" OrElse cmbPermissiondl.SelectedItem = "All" OrElse cmbDishNameDl.SelectedItem = "All" Then
            ALL_row_Itm_del()
        ElseIf cmbOperatordl.SelectedItem <> "All" AndAlso cmbOperatordl.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_selct_Index_change_del()

        ElseIf CmbBillTypedl.SelectedItem <> "All" AndAlso CmbBillTypedl.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then
            cmb_bill_typ_selct_Index_change_del()

        ElseIf cmbPermissiondl.SelectedItem <> "All" AndAlso cmbPermissiondl.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then
            cmb_permi_selct_Index_change_del()

        ElseIf cmbDishNameDl.SelectedItem <> "All" AndAlso cmbDishNameDl.SelectedItem <> Nothing AndAlso cmb_Dish_select = True Then
            cmb_dish_selct_Index_change_del()
        Else
            ALL_row_Itm_del()
        End If
    End Sub

    'Quantity change log start

    'filter operator according to operator name except 'All'
    Public Sub cmb_op_qua_select_ind_change()
        If cmbOperatorQua.SelectedItem <> Nothing OrElse cmbOperatorQua.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumberQua.Text = ""
        cmb_Dish_select = False
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
        CmbDishNameQua.SelectedItem = Nothing
        cmbOperatorQua.SelectedItem = selectedOperator
        print_btn_enb_dis_qua()
    End Sub


    'filter bill type according to billtype name except 'All'
    Public Sub cmb_bill_qua_select_ind_change()
        txtBillNumberQua.Text = ""
        cmb_permission_select = False
        cmd_operator_select = False
        cmb_Dish_select = False
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

        CmbDishNameQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = select_bill_type

        print_btn_enb_dis_qua()
    End Sub


    'filter permission according to permission name except 'All'
    Public Sub cmb_permission_qua_select_ind_change()
        If cmbPermissionQua.SelectedItem <> Nothing OrElse cmbPermissionQua.SelectedItem <> "All" Then
            cmb_permission_select = True
        End If
        txtBillNumberQua.Text = ""
        cmb_bill_select = False
        cmd_operator_select = False
        cmb_Dish_select = False
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
        CmbDishNameQua.SelectedItem = Nothing
        cmbPermissionQua.SelectedItem = selectedPermission
        print_btn_enb_dis_qua()
    End Sub

    'filter dish name according to dish name except 'All'
    Public Sub cmb_dish_qua_select_ind_change()
        If CmbDishNameQua.SelectedItem IsNot Nothing AndAlso CmbDishNameQua.SelectedItem.ToString() <> "All" Then
            cmb_Dish_select = True
        End If
        txtBillNumber.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        cmd_operator_select = False

        Dim selectedDish As String
        Try
            selectedDish = CmbDishNameQua.SelectedItem.ToString()
        Catch ex As Exception
            selectedDish = Nothing
        End Try

        ' Check if "All" is selected
        If selectedDish = "All" Then
            data_all()
        Else
            ' Filter the search results in DataGridView based on the selected operator name

            Dim fromDate As Date = dtpDateFrom.Value
            Dim toDate As Date = dtpDateTo.Value


            Dim query As String = "SELECT qcl.Id, qcl.BillNo,dsh.DishName , qcl.ChangedDate, qcl.OrgQty, qcl.ChangedQty,qcl.BillType, 
                             ER_Operator.EmployeeName AS OperatorName, 
                             ER_PermissionGranted.EmployeeName AS PermissionGrantedName, 
                             qcl.Remarks,qcl.companyId ,qcl.Branchid 
                      FROM QtyChangeLog  AS qcl
                      INNER JOIN EmployeeRegistration AS ER_Operator ON qcl.OperatorId = ER_Operator.EmpId
                      INNER JOIN EmployeeRegistration AS ER_PermissionGranted ON qcl.PermissionGrantedId = ER_PermissionGranted.EmpId
                        INNER JOIN Dish AS dsh ON qcl.DishId = dsh.DishID
                      WHERE qcl.DishId IN (SELECT DishID FROM Dish WHERE DishName = @Dishname) AND
                      qcl.ChangedDate >= @FromDate AND qcl.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Dishname", selectedDish)
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
        cmbOperator.SelectedItem = Nothing
        cmbDishName.SelectedItem = selectedDish
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    'filter in case of all row
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
        print_btn_enb_dis_qua()
    End Sub


    'filter according to bill number
    Public Sub searchbillnoQua()
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
        print_btn_enb_dis_qua()
    End Sub


    'filter print all row
    Public Sub all_print_qua()
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

    'load all combobx in quantity change log

    Public Sub load_combobox_data_qua()
        'operator combobox load items
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

        'bill type combobox load items
        CmbBillTypeQua.Items.Add("Dine In")
        CmbBillTypeQua.Items.Add("Take Away")
        CmbBillTypeQua.Items.Add("Home Delivery")
        CmbBillTypeQua.Items.Add("Third Party")
        CmbBillTypeQua.Items.Add("Express Bill")
        CmbBillTypeQua.Items.Insert(0, "All")

        'permisson granted combobox load items
        cmbPermissionQua.Items.Insert(0, "All")
        Dim query1 As String = "SELECT DISTINCT  ER.EmployeeName AS PermissionGrantedName
                           FROM QtyChangeLog  AS ecl
                           INNER JOIN EmployeeRegistration AS ER ON ecl.PermissionGrantedId = ER.EmpId"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query1, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbPermissionQua.Items.Add(reader("PermissionGrantedName").ToString())
                End While
            End Using
        End Using

        'Dishname

        cmbDishName.Items.Insert(0, "All")
        Dim query2 As String = "SELECT DISTINCT Dis.DishId ,  Dis.DishName 
                           FROM QtyChangeLog AS qcl
                           INNER JOIN Dish AS Dis ON qcl.DishId = Dis.DishID"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query2, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim dishName As String = reader("DishName").ToString()
                    CmbDishNameQua.Items.Add(dishName)
                End While
            End Using

        End Using

    End Sub


    Public Sub print_btn_enb_dis_qua()
        If DatagridViewQty.Rows.Count > 0 Then
            BtnPrintqua.Enabled = True
            BtnPrintqua.BackColor = Color.LightSteelBlue
            btnExportExcelqua.Enabled = True
            btnExportExcelqua.BackColor = Color.LightSteelBlue
        Else
            BtnPrintqua.Enabled = False
            BtnPrintqua.BackColor = SystemColors.Control ' Reset button color to default
            btnExportExcelqua.Enabled = False
            btnExportExcelqua.BackColor = SystemColors.Control
        End If
    End Sub
    Private Sub dtpDateFromQua_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFromQua.ValueChanged
        txtBillNumberQua.Text = ""
        If cmbOperatorQua.SelectedItem = "All" OrElse CmbBillTypeQua.SelectedItem = "All" OrElse cmbPermissionQua.SelectedItem = "All" OrElse CmbDishNameQua.SelectedItem = "All" Then
            ALL_ROW_qua()
        ElseIf cmbOperatorQua.SelectedItem <> "All" AndAlso cmbOperatorQua.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_qua_select_ind_change()
        ElseIf CmbBillTypeQua.SelectedItem <> "All" AndAlso CmbBillTypeQua.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            cmb_bill_qua_select_ind_change()
        ElseIf cmbPermissionQua.SelectedItem <> "All" AndAlso cmbPermissionQua.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            cmb_permission_qua_select_ind_change()

        ElseIf CmbDishNameQua.SelectedItem <> "All" AndAlso CmbDishNameQua.SelectedItem <> Nothing AndAlso cmb_Dish_select = True Then
            cmb_dish_qua_select_ind_change()
        Else
            ALL_ROW_qua()
        End If
    End Sub

    Private Sub dtpDateToQua_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateToQua.ValueChanged
        txtBillNumberQua.Text = ""
        If cmbOperatorQua.SelectedItem = "All" OrElse CmbBillTypeQua.SelectedItem = "All" OrElse cmbPermissionQua.SelectedItem = "All" OrElse cmbDishName.SelectedItem = "All" Then
            ALL_ROW_qua()
        ElseIf cmbOperatorQua.SelectedItem <> "All" AndAlso cmbOperatorQua.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then
            cmb_op_qua_select_ind_change()
        ElseIf CmbBillTypeQua.SelectedItem <> "All" AndAlso CmbBillTypeQua.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            cmb_bill_qua_select_ind_change()
        ElseIf cmbPermissionQua.SelectedItem <> "All" AndAlso cmbPermissionQua.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            cmb_permission_qua_select_ind_change()

        ElseIf CmbDishNameQua.SelectedItem <> "All" AndAlso CmbDishNameQua.SelectedItem <> Nothing AndAlso cmb_Dish_select = True Then
            cmb_dish_qua_select_ind_change()
        Else
            ALL_ROW_qua()
        End If
    End Sub

    Private Sub txtBillNumberQua_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumberQua.TextChanged
        If txtBillNumberQua.Text = "" Then
            ALL_ROW_qua()

        Else
            searchbillnoQua()
        End If
    End Sub

    Private Sub cmbOperatorQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperatorQua.SelectedIndexChanged
        cmb_op_qua_select_ind_change()
    End Sub

    Private Sub CmbBillTypeQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillTypeQua.SelectedIndexChanged
        cmb_bill_qua_select_ind_change()
    End Sub

    Private Sub cmbPermissionQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermissionQua.SelectedIndexChanged
        cmb_permission_qua_select_ind_change()
    End Sub

    Private Sub BtnPrintqua_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub resetQua()
        dtpDateFromQua.Value = DateTime.Today
        dtpDateToQua.Value = DateTime.Today
        'ComboBox1.SelectedIndex = 0
        'cmbOperator.SelectedIndex = 0
        txtBillNumberQua.Text = ""
        DatagridViewQty.Rows.Clear()
        cmd_operator_select = False
        cmb_bill_select = False
        cmb_permission_select = False
        cmb_Dish_select = False
        cmbPermissionQua.SelectedItem = Nothing
        cmbOperatorQua.SelectedItem = Nothing
        CmbBillTypeQua.SelectedItem = Nothing
        CmbDishNameQua.SelectedItem = Nothing
        txtChangedQtyCount.Text = ""
    End Sub

    Private Sub btnResetqua_Click(sender As Object, e As EventArgs) Handles btnResetqua.Click
        resetQua()
        print_btn_enb_dis_qua()
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim tabBounds As Rectangle = TabControl1.GetTabRect(e.Index)

        ' Set custom width and height for each tab
        tabBounds.Width = 100 ' Set the desired width
        tabBounds.Height = 30 ' Set the desired height

        ' Fill the tab with color based on the index
        Select Case e.Index
            Case 0
                e.Graphics.FillRectangle(New SolidBrush(Color.Red), tabBounds)
            Case 1
                e.Graphics.FillRectangle(New SolidBrush(Color.Blue), tabBounds)
            Case 2
                e.Graphics.FillRectangle(New SolidBrush(Color.Magenta), tabBounds)
        End Select

        ' Adjust the text position within the tab
        Dim textBounds As New Rectangle(tabBounds.Left + 4, tabBounds.Top + 4, tabBounds.Width - 8, tabBounds.Height - 8)

        ' Draw the tab text
        e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, Me.Font, SystemBrushes.HighlightText, textBounds)
    End Sub


    '------------------Rate change log sarted--------------------------------
    Public Sub print_btn_RT_chg_enb_dis_qua()
        If DatagridView1.Rows.Count > 0 Then
            BtnPrint.Enabled = True
            BtnPrint.BackColor = Color.LightSteelBlue
            btnExportExcel.Enabled = True
            btnExportExcel.BackColor = Color.LightSteelBlue
            ' Assuming you have a button named Button1


        Else
            BtnPrint.Enabled = False
            BtnPrint.BackColor = SystemColors.Control ' Reset button color to default
            btnExportExcel.Enabled = False
            btnExportExcel.BackColor = SystemColors.Control
        End If
    End Sub


    Public Sub select_bill_ty_indx_RT_Ch()
        txtBillNumber.Text = ""
        cmb_permission_select = False
        cmd_operator_select = False
        cmb_Dish_select = False
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
            data_all()
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
        cmbDishName.SelectedItem = Nothing
        CmbBillType.SelectedItem = select_bill_type
        print_btn_RT_chg_enb_dis_qua()
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

    Public Sub select_oper_indx_RT_Ch()
        If cmbOperator.SelectedItem <> Nothing OrElse cmbOperator.SelectedItem <> "All" Then
            cmd_operator_select = True
        End If
        txtBillNumber.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        cmb_Dish_select = False
        Dim selectedOperator As String

        Try
            selectedOperator = cmbOperator.SelectedItem.ToString()
        Catch ex As Exception
            selectedOperator = Nothing
        End Try

        ' Check if "All" is selected
        If selectedOperator = "All" Then
            data_all()
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
        cmbDishName.SelectedItem = Nothing
        cmbOperator.SelectedItem = selectedOperator
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    Public Sub select_dish_indx_RT_Ch()
        If cmbDishName.SelectedItem IsNot Nothing AndAlso cmbDishName.SelectedItem.ToString() <> "All" Then
            cmb_Dish_select = True
        End If
        txtBillNumber.Text = ""

        cmb_bill_select = False
        cmb_permission_select = False
        cmd_operator_select = False

        Dim selectedDish As String
        Try
            selectedDish = cmbDishName.SelectedItem.ToString()
        Catch ex As Exception
            selectedDish = Nothing
        End Try

        ' Check if "All" is selected
        If selectedDish = "All" Then
            data_all()
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
                        WHERE RCL.DishId IN (SELECT DishID FROM Dish WHERE DishName = @Dishname)
                      AND
                      RCL.ChangedDate >= @FromDate AND RCL.ChangedDate <= @ToDate"

            Dim conn As New SqlConnection(connection)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Dishname", selectedDish)
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
        cmbOperator.SelectedItem = Nothing
        cmbDishName.SelectedItem = selectedDish
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    Public Sub select_permi_indx_RT_Ch()
        If cmbPermission.SelectedItem <> Nothing OrElse cmbPermission.SelectedItem <> "All" Then
            cmb_permission_select = True
        End If
        txtBillNumber.Text = ""
        cmb_bill_select = False
        cmd_operator_select = False
        cmb_Dish_select = False
        Dim selectedPermission As String
        Try
            selectedPermission = cmbPermission.SelectedItem.ToString()
        Catch ex As Exception
            selectedPermission = Nothing
        End Try

        ' Check if "All" is selected
        If selectedPermission = "All" Then
            data_all()
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
        cmbDishName.SelectedItem = Nothing
        cmbPermission.SelectedItem = selectedPermission
        print_btn_RT_chg_enb_dis_qua()
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
        cmbDishName.SelectedItem = Nothing
        txtRateDiffSum.Text = ""
        txtChangeRateSum.Text = ""
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    'load combobox rate change
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

        'Dishname

        cmbDishName.Items.Insert(0, "All")
        Dim query2 As String = "SELECT DISTINCT Dis.DishId ,  Dis.DishName 
                           FROM RateChangeLog AS RCL
                           INNER JOIN Dish AS Dis ON RCL.DishId = Dis.DishID"

        Using conn As New SqlConnection(connection)
            Using cmd As New SqlCommand(query2, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim dishName As String = reader("DishName").ToString()
                    cmbDishName.Items.Add(dishName)
                End While
            End Using

        End Using
    End Sub
    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumber.TextChanged
        If txtBillNumber.Text = "" Then
            data_all()

        Else
            searchbillno()
        End If
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
        select_oper_indx_RT_Ch()
    End Sub

    Private Sub CmbBillType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillType.SelectedIndexChanged
        select_bill_ty_indx_RT_Ch()
    End Sub

    Private Sub cmbPermission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermission.SelectedIndexChanged
        select_permi_indx_RT_Ch()
    End Sub

    Private Sub dtpDateFrom_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        'filter_data()
        'SearchRadio.Checked = False
        'SearchRadio.PerformClick()
        txtBillNumber.Text = ""
        'cmbOperator.SelectedItem = Nothing
        'CmbBillType.SelectedItem = Nothing
        'cmbPermission.SelectedItem = Nothing
        If cmbOperator.SelectedItem = "All" OrElse CmbBillType.SelectedItem = "All" OrElse cmbPermission.SelectedItem = "All" OrElse cmbDishName.SelectedItem = "All" Then
            data_all()
        ElseIf cmbOperator.SelectedItem <> "All" AndAlso cmbOperator.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then

            select_oper_indx_RT_Ch()

        ElseIf CmbBillType.SelectedItem <> "All" AndAlso CmbBillType.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            select_bill_ty_indx_RT_Ch()

        ElseIf cmbPermission.SelectedItem <> "All" AndAlso cmbPermission.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            select_permi_indx_RT_Ch()

        ElseIf cmbDishName.SelectedItem <> "All" AndAlso cmbDishName.SelectedItem <> Nothing AndAlso cmb_Dish_select = True Then
            select_dish_indx_RT_Ch()
        Else
            ' bttnSearch.PerformClick()
            data_all()
        End If
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        'filter_data()
        'SearchRadio.Checked = False
        'SearchRadio.PerformClick()
        txtBillNumber.Text = ""
        'cmbOperator.SelectedItem = Nothing
        'CmbBillType.SelectedItem = Nothing
        'cmbPermission.SelectedItem = Nothing
        If cmbOperator.SelectedItem = "All" OrElse CmbBillType.SelectedItem = "All" OrElse cmbPermission.SelectedItem = "All" OrElse cmbDishName.SelectedItem = "All" Then
            data_all()
        ElseIf cmbOperator.SelectedItem <> "All" AndAlso cmbOperator.SelectedItem <> Nothing AndAlso cmd_operator_select = True Then

            select_oper_indx_RT_Ch()

        ElseIf CmbBillType.SelectedItem <> "All" AndAlso CmbBillType.SelectedItem <> Nothing AndAlso cmb_bill_select = True Then

            select_bill_ty_indx_RT_Ch()

        ElseIf cmbPermission.SelectedItem <> "All" AndAlso cmbPermission.SelectedItem <> Nothing AndAlso cmb_permission_select = True Then

            select_permi_indx_RT_Ch()


        ElseIf cmbDishName.SelectedItem <> "All" AndAlso cmbDishName.SelectedItem <> Nothing AndAlso cmb_Dish_select = True Then
            select_dish_indx_RT_Ch()
        Else
            ' bttnSearch.PerformClick()
            data_all()
        End If
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

            ElseIf cmbDishName.SelectedItem <> Nothing AndAlso cmbDishName.SelectedItem.ToString() = "All" Then
                all_print_RT()

                'if these combobox is empty value working filter according to fromDate and toDate
            ElseIf cmbOperator.SelectedItem = Nothing AndAlso CmbBillType.SelectedItem = Nothing AndAlso cmbPermission.SelectedItem = Nothing AndAlso cmbDishName.SelectedItem = Nothing Then
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

            ElseIf cmbDishName.SelectedItem <> Nothing AndAlso cmbDishName.SelectedItem.ToString() <> "All" Then
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
                Dim dishname As String = cmbDishName.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetRateChangeLogByDishAndDate", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@Dishname", dishname)
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ToExcel1(DatagridView1)
    End Sub

    Private Sub btnExportExcelqua_Click(sender As Object, e As EventArgs) Handles btnExportExcelqua.Click
        ToExcel1(DatagridViewQty)
    End Sub

    Private Sub cmbDishName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDishName.SelectedIndexChanged
        select_dish_indx_RT_Ch()
    End Sub

    Private Sub CmbDishNameQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDishNameQua.SelectedIndexChanged
        cmb_dish_qua_select_ind_change()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Label10qua_Click(sender As Object, e As EventArgs) Handles Label10qua.Click

    End Sub

    Private Sub cmbDishNameDl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDishNameDl.SelectedIndexChanged
        cmb_dish_selct_Index_change_del()
    End Sub

    Private Sub Label10dl_Click(sender As Object, e As EventArgs) Handles Label10dl.Click

    End Sub

    Private Sub Panel1Qua_Paint(sender As Object, e As PaintEventArgs) Handles Panel1Qua.Paint

    End Sub

    Private Sub BtnPrintqua_Click_1(sender As Object, e As EventArgs) Handles BtnPrintqua.Click
        Dim fromDate As Date = dtpDateFromQua.Value
        Dim toDate As Date = dtpDateToQua.Value
        If txtBillNumberQua.Text = "" Then
            If cmbOperatorQua.SelectedItem <> Nothing AndAlso cmbOperatorQua.SelectedItem.ToString() = "All" Then
                all_print_qua()

            ElseIf cmbPermissionQua.SelectedItem <> Nothing AndAlso cmbPermissionQua.SelectedItem.ToString() = "All" Then
                all_print_qua()

            ElseIf CmbBillTypeQua.SelectedItem <> Nothing AndAlso CmbBillTypeQua.SelectedItem.ToString() = "All" Then
                all_print_qua()

            ElseIf CmbDishNameQua.SelectedItem <> Nothing AndAlso CmbDishNameQua.SelectedItem.ToString() = "All" Then
                all_print_qua()

                'If all combobox is nothin the filter will be work as from date and todate
            ElseIf cmbOperatorQua.SelectedItem = Nothing AndAlso CmbBillTypeQua.SelectedItem = Nothing AndAlso cmbPermissionQua.SelectedItem = Nothing AndAlso cmbDishName.SelectedItem = Nothing Then
                all_print_qua()

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

            ElseIf CmbDishNameQua.SelectedItem <> Nothing AndAlso CmbDishNameQua.SelectedItem.ToString() <> "All" Then
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
                Dim dish As String = CmbDishNameQua.SelectedItem.ToString()
                Dim cmd2 As New SqlCommand("GetQtyChangeLogByDishnameAndDateRange", CN)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("@FromDate", fromDate)
                cmd2.Parameters.AddWithValue("@ToDate", toDate)
                cmd2.Parameters.AddWithValue("@Dishname ", dish)
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

    Private Sub BtnPrintqua1_Click(sender As Object, e As EventArgs)

    End Sub
End Class