Imports System.Data.SqlClient

Public Class frmRateQtyItemLog
    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFromdl.ValueChanged
        filter_item_del()
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

    Public Sub rate_chg_sel_ind_zer()
        cmbOperator1.SelectedIndex = 0
        CmbBillType.SelectedIndex = 0

        cmbDishName.SelectedIndex = 0

    End Sub

    Private Sub frmRateQtyItemLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----------------Rate change portion--------------------'
        fillOperatorRt()
        fill_bill_type_RT()
        fill_permission_RT()
        fill_dish_Rt()
        cmbpermission1.SelectedIndex = 0
        cmbOperator1.SelectedIndex = 0
        CmbBillType.SelectedIndex = 0
        cmbDishName.SelectedIndex = 0
        'check the print button..if datagridview does no have value the print button disabled mode
        print_btn_RT_chg_enb_dis_qua()
        '  rate_chg_sel_ind_zer()

        '--------------------------------------------------------
    End Sub



    Public Sub fillOperatorDl()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()
        Dim query8 As String = "
         select distinct er.empid, er.employeename as operatorname
         from ItemDeleted as itd
         inner join employeeregistration as er on itd.OperatorId = er.empid
         union
         select 0 as empid, 'All' as operatorname"


        adpt.SelectCommand = New SqlCommand(query8, con)

        ds = New DataSet("ds")
        adpt.Fill(ds)
        Dim dtable = ds.Tables(0)
        cmbOperatordl.DisplayMember = "operatorname"
        cmbOperatordl.ValueMember = "EmpId"

        cmbOperatordl.DataSource = dtable

        con.Close()
    End Sub

    Public Sub fill_bill_type_Dl()
        'con = New SqlConnection(connection)
        'con.Open()
        'adpt = New SqlDataAdapter()

        'Dim query8 As String = "
        ' select Distinct BillType 
        ' from ratechangelog 
        ' union
        ' select 'All' as billtype"


        'adpt.SelectCommand = New SqlCommand(query8, con)

        'ds = New DataSet("ds")
        'adpt.Fill(ds)
        'Dim dtable = ds.Tables(0)

        'cmbOperator1.DataSource = dtable

        'con.Close()
        CmbBillTypedl.Items.Clear()
        CmbBillTypedl.Items.Add("Dine In")
        CmbBillTypedl.Items.Add("Take Away")
        CmbBillTypedl.Items.Add("Home Delivery")
        CmbBillTypedl.Items.Add("Third Party")
        CmbBillTypedl.Items.Add("Express Bill")
        CmbBillTypedl.Items.Insert(0, "All")
    End Sub

    Public Sub fill_permission_Dl()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()

        Dim query1 As String = "
    SELECT DISTINCT ER.EmpId, ER.EmployeeName AS PermissionGrantedName
    FROM ItemDeleted AS itd
    INNER JOIN EmployeeRegistration AS ER ON itd.PermissionGrantedId = ER.EmpId
    UNION
    SELECT 0 AS EmpId, 'All' AS PermissionGrantedName
"

        adpt.SelectCommand = New SqlCommand(query1, con)
        ds1 = New DataSet("ds")
        adpt.Fill(ds1)
        Dim dtable1 = ds1.Tables(0)
        cmbPermissiondl.DisplayMember = "PermissionGrantedName"
        cmbPermissiondl.ValueMember = "EmpId"
        cmbPermissiondl.DataSource = dtable1

        con.Close()
    End Sub

    Public Sub fill_dish_Dl()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()


        Dim query2 As String = "SELECT DISTINCT Dis.DishId ,  Dis.DishName 
                           FROM ItemDeleted AS itd
                           INNER JOIN Dish AS Dis ON itd.Dish_Id = Dis.DishID
                                UNION
                            SELECT 0 AS DishId, 'All' AS DishName
            
                            "

        adpt.SelectCommand = New SqlCommand(query2, con)
        ds1 = New DataSet("ds")
        adpt.Fill(ds1)
        Dim dtable1 = ds1.Tables(0)
        cmbDishNameDl.DisplayMember = "DishName"
        cmbDishNameDl.ValueMember = "DishId"
        cmbDishNameDl.DataSource = dtable1
        con.Close()
    End Sub


    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        ' Check which tab is being selected
        Select Case e.TabPageIndex
            Case 0 ' TabPage 1 Rate change log

                'print button export excel already included Reset() function
                Reset()
                'load_combobox_RT()

                '----------------Rate change portion--------------------'
                fillOperatorRt()
                fill_bill_type_RT()
                fill_permission_RT()
                fill_dish_Rt()
                cmbOperator1.SelectedIndex = 0
                CmbBillType.SelectedIndex = 0
                cmbDishName.SelectedIndex = 0
                'check the print button..if datagridview does no have value the print button disabled mode
                print_btn_RT_chg_enb_dis_qua()
        '  rate_chg_sel_ind_zer()

        '--------------------------------------------------------

            Case 1 ' TabPage 2 quantity change
                resetQua()
                ' load_combobox_data_qua()

                fillOperatorQt()
                fill_bill_type_Qt()
                ' fill_permission_Qt()
                fill_permission_Qt()
                fill_dish_Qt()
                cmbOperatorQua.SelectedIndex = 0
                CmbBillTypeQua.SelectedIndex = 0
                cmbPermissionQua.SelectedIndex = 0
                CmbDishNameQua.SelectedIndex = 0

                'check gridview column function if it zero rows the print button and export excel will be disabled
                print_btn_enb_dis_qua()
            Case 2 ' TabPage 3 item delete
                Reset_dl()
                ' load_combobox_dl()
                'check gridview column function if it zero rows the print button and export excel will be disabled

                print_dl_en_dis()
        End Select
    End Sub


    Private Sub cmbOperatordl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperatordl.SelectedIndexChanged
        filter_item_del()
    End Sub


    Private Sub cmbPermissiondl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermissiondl.SelectedIndexChanged
        filter_item_del()
    End Sub

    Private Sub txtBillNumberdl_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumberdl.TextChanged
        filter_item_del()
    End Sub

    Private Sub CmbBillTypedl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillTypedl.SelectedIndexChanged

        filter_item_del()
    End Sub

    Private Sub BtnPrintdl_Click(sender As Object, e As EventArgs) Handles BtnPrintdl.Click
        filter_item_del_print()
    End Sub

    Public Sub Reset_dl()
        dtpDateFromdl.Value = DateTime.Today
        dtpDateTodl.Value = DateTime.Today
        'ComboBox1.SelectedIndex = 0
        'cmbOperator.SelectedIndex = 0
        txtBillNumberdl.Text = ""
        DatagridViewItemDel.Rows.Clear()
        BtnPrintdl.Enabled = False
        txtGrandTotaldl.Text = ""
        fillOperatorDl()
        fill_bill_type_Dl()
        fill_permission_Dl()
        fill_dish_Dl()
        cmbOperatordl.SelectedIndex = 0
        CmbBillTypedl.SelectedIndex = 0
        cmbPermissiondl.SelectedIndex = 0
        cmbDishNameDl.SelectedIndex = 0
    End Sub

    Private Sub btnResetdl_Click(sender As Object, e As EventArgs) Handles btnResetdl.Click
        Reset_dl()
    End Sub

    Private Sub btnExportExceldl_Click(sender As Object, e As EventArgs) Handles btnExportExceldl.Click
        ToExcel2(DatagridViewItemDel)
    End Sub

    Private Sub dtpDateTodl_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTodl.ValueChanged
        filter_item_del()
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

    Public Sub filter_qty_change()
        Try
            Dim bill_type As String = ""
            If CmbBillTypeQua.SelectedItem IsNot Nothing Then
                bill_type = CmbBillTypeQua.SelectedItem.ToString()
                Select Case bill_type
                    Case "Dine In"
                        bill_type = "DI"
                    Case "Take Away"
                        bill_type = "TA"
                    Case "Home Delivery"
                        bill_type = "HD"
                    Case "Third Party"
                        bill_type = "TP"
                    Case "Express Bill"
                        bill_type = "TAEB"
                    Case Else
                        bill_type = "All"
                End Select
            End If

            con = New SqlConnection(cs)
            con.Open()

            Dim SQL As String = "exec Proc_QtyChange @d1,@d2,@Operator,@BillNo,@BillType,@Permission ,@Dish"
            cmd = New SqlCommand(SQL, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime).Value = dtpDateFromQua.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime).Value = dtpDateToQua.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = CInt(cmbOperatorQua.SelectedValue)
            cmd.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50).Value = txtBillNumberQua.Text
            cmd.Parameters.Add("@BillType", SqlDbType.NVarChar, 50).Value = CStr(bill_type)
            cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = CInt(cmbPermissionQua.SelectedValue)
            cmd.Parameters.Add("@Dish", SqlDbType.Int).Value = CInt(CmbDishNameQua.SelectedValue)

            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DatagridViewQty.Rows.Clear()

            Dim changed_qty_count As Decimal = 0
            Dim qty_diff_count As Decimal = 0
            While (rdr.Read())
                'org qty variable
                Dim org_qty As Double = CDec(rdr(4)) ' Convert to Double or appropriate numerical type
                Dim chng_qty As Double = CDec(rdr(5)) ' Convert to Double or appropriate numerical type

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
                Dim changedDate As Date = CDate(rdr(3))
                DatagridViewQty.Rows.Add(rdr(0), rdr(1), rdr(2), changedDate.ToShortDateString(), rdr(4), rdr(5), Math.Abs(result), status, rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11))
            End While

            'txtRateDiffSum.Text = rate_diff_sum
            txtChangedQtyCount.Text = changed_qty_count
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            rdr.Close()
            con.Close()
        End Try
        print_btn_enb_dis_qua()
    End Sub


    Public Sub filter_item_del()
        Try
            Dim bill_type As String = ""
            If CmbBillTypedl.SelectedItem IsNot Nothing Then
                bill_type = CmbBillTypedl.SelectedItem.ToString()
                Select Case bill_type
                    Case "Dine In"
                        bill_type = "DI"
                    Case "Take Away"
                        bill_type = "TA"
                    Case "Home Delivery"
                        bill_type = "HD"
                    Case "Third Party"
                        bill_type = "TP"
                    Case "Express Bill"
                        bill_type = "TAEB"
                    Case Else
                        bill_type = "All"
                End Select
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim SQL As String = ""
            SQL = "exec Proc_itemDeleted @d1,@d2,@Operator,@BillNo,@BillType,@Permission ,@Dish"
            cmd = New SqlCommand(SQL, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateFrom").Value = dtpDateFromdl.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateTo").Value = dtpDateTodl.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = CInt(cmbOperatordl.SelectedValue)
            cmd.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50, "BillNo").Value = txtBillNumberdl.Text
            cmd.Parameters.Add("@BillType", SqlDbType.NVarChar, 50, "BillType").Value = bill_type
            cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = CInt(cmbPermissiondl.SelectedValue)
            cmd.Parameters.Add("@Dish", SqlDbType.Int).Value = CInt(cmbDishNameDl.SelectedValue)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DatagridViewItemDel.Rows.Clear()

            Dim amount As Decimal = 0
            Dim grand_tot As Decimal = 0
            txtGrandTotaldl.Text = grand_tot

            While (rdr.Read())
                amount = CDec(rdr("Quantity")) * CDec(rdr("Rate"))
                grand_tot = grand_tot + amount
                Dim changedDate As Date = CDate(rdr(3))
                DatagridViewItemDel.Rows.Add(rdr("ID"), rdr("BillNo"), rdr("DishName"), changedDate.ToShortDateString(), rdr("TableNo"), rdr("Quantity"), rdr("Rate"), rdr("BillType"),
                                rdr("OperatorName"), rdr("PermissionGrantedName"), rdr("Remarks"), rdr("companyId"), rdr("Branchid"))
            End While

            txtGrandTotaldl.Text = grand_tot

        Catch ex As Exception

        Finally
            rdr.Close()
            con.Close()
        End Try
        print_dl_en_dis()
    End Sub


    Private Sub dtpDateFromQua_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFromQua.ValueChanged
        filter_qty_change()
    End Sub

    Private Sub dtpDateToQua_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateToQua.ValueChanged
        filter_qty_change()
    End Sub

    Private Sub txtBillNumberQua_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumberQua.TextChanged
        filter_qty_change()
    End Sub

    Private Sub cmbOperatorQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperatorQua.SelectedIndexChanged
        filter_qty_change()
    End Sub

    Private Sub CmbBillTypeQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillTypeQua.SelectedIndexChanged
        filter_qty_change()
    End Sub

    Private Sub cmbPermissionQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermissionQua.SelectedIndexChanged
        filter_qty_change()
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
        'cmbPermissionQua.SelectedItem = Nothing
        'cmbOperatorQua.SelectedItem = Nothing
        'CmbBillTypeQua.SelectedItem = Nothing
        'CmbDishNameQua.SelectedItem = Nothing
        txtChangedQtyCount.Text = ""
    End Sub

    Private Sub btnResetqua_Click(sender As Object, e As EventArgs) Handles btnResetqua.Click
        resetQua()
        print_btn_enb_dis_qua()
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
        'cmbPermission.SelectedItem = Nothing
        'cmbOperator1.SelectedItem = Nothing
        'CmbBillType.SelectedItem = Nothing
        'cmbDishName.SelectedItem = Nothing
        txtRateDiffSum.Text = ""
        txtChangeRateSum.Text = ""
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    'load combobox rate change


    Public Sub fillOperatorRt()
        Try
            con = New SqlConnection(connection)
            con.Open()
            adpt = New SqlDataAdapter()

            Dim query8 As String = "
            SELECT DISTINCT er.empid, er.employeename AS operatorname
            FROM ratechangelog AS rcl
            INNER JOIN employeeregistration AS er ON rcl.operatorid = er.empid
            UNION
            SELECT 0 AS empid, 'All' AS operatorname
        "

            adpt.SelectCommand = New SqlCommand(query8, con)

            ds = New DataSet("ds")
            adpt.Fill(ds)
            Dim dtable = ds.Tables(0)
            cmbOperator1.DisplayMember = "operatorname"
            cmbOperator1.ValueMember = "EmpId"
            cmbOperator1.DataSource = dtable
            cmbOperator1.Refresh()
        Catch ex As Exception
            ' Handle the exception, e.g., show an error message
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub fill_bill_type_RT()

        CmbBillType.Items.Clear()
        CmbBillType.Items.Add("Dine In")
        CmbBillType.Items.Add("Take Away")
        CmbBillType.Items.Add("Home Delivery")
        CmbBillType.Items.Add("Third Party")
        CmbBillType.Items.Add("Express Bill")
        CmbBillType.Items.Insert(0, "All")
        CmbBillType.SelectedIndex = 0
    End Sub

    Public Sub fill_permission_RT()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()

        Dim query1 As String = "
    SELECT DISTINCT ER.EmpId, ER.EmployeeName AS PermissionGrantedName
    FROM RateChangeLog AS RCL
    INNER JOIN EmployeeRegistration AS ER ON RCL.PermissionGrantedId = ER.EmpId
    UNION
    SELECT 0 AS EmpId, 'All' AS PermissionGrantedName
"

        adpt.SelectCommand = New SqlCommand(query1, con)
        ds1 = New DataSet("ds")
        adpt.Fill(ds1)
        Dim dtable1 = ds1.Tables(0)
        cmbpermission1.DisplayMember = "PermissionGrantedName"
        cmbpermission1.ValueMember = "EmpId"
        cmbpermission1.DataSource = dtable1

        con.Close()
    End Sub

    Public Sub fill_dish_Rt()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()


        Dim query2 As String = "SELECT DISTINCT Dis.DishID ,  Dis.DishName 
                           FROM RateChangeLog AS rcl
                           INNER JOIN Dish AS Dis ON rcl.DishId = Dis.DishID
                                UNION
                            SELECT 0 AS DishID, 'All' AS DishName
            
                            "

        adpt.SelectCommand = New SqlCommand(query2, con)
        ds1 = New DataSet("ds")
        adpt.Fill(ds1)
        Dim dtable1 = ds1.Tables(0)
        cmbDishName.DisplayMember = "DishName"
        cmbDishName.ValueMember = "DishID"
        cmbDishName.DataSource = dtable1
        con.Close()
    End Sub

    '--------------complete load combobox rate change---------------------------

    'load combobox quantity change------------------------------------------
    Public Sub fillOperatorQt()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()

        Dim query8 As String = "
         select distinct er.empid, er.employeename as operatorname
         from QtyChangeLog as qcl
         inner join employeeregistration as er on qcl.operatorid = er.empid
         union
         select 0 as empid, 'All' as operatorname"


        adpt.SelectCommand = New SqlCommand(query8, con)

        ds = New DataSet("ds")
        adpt.Fill(ds)
        Dim dtable = ds.Tables(0)
        cmbOperatorQua.DisplayMember = "operatorname"
        cmbOperatorQua.ValueMember = "EmpId"

        cmbOperatorQua.DataSource = dtable

        con.Close()
    End Sub

    Public Sub fill_bill_type_Qt()

        CmbBillTypeQua.Items.Clear()
        CmbBillTypeQua.Items.Add("Dine In")
        CmbBillTypeQua.Items.Add("Take Away")
        CmbBillTypeQua.Items.Add("Home Delivery")
        CmbBillTypeQua.Items.Add("Third Party")
        CmbBillTypeQua.Items.Add("Express Bill")
        CmbBillTypeQua.Items.Insert(0, "All")

    End Sub

    Public Sub fill_permission_Qt()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()

        Dim query1 As String = "
    SELECT DISTINCT ER.EmpId, ER.EmployeeName AS PermissionGrantedName
    FROM QtyChangeLog AS qcl
    INNER JOIN EmployeeRegistration AS ER ON qcl.PermissionGrantedId = ER.EmpId
    UNION
    SELECT 0 AS EmpId, 'All' AS PermissionGrantedName
"

        adpt.SelectCommand = New SqlCommand(query1, con)
        ds1 = New DataSet("ds")
        adpt.Fill(ds1)
        Dim dtable1 = ds1.Tables(0)
        cmbPermissionQua.DisplayMember = "PermissionGrantedName"
        cmbPermissionQua.ValueMember = "EmpId"
        cmbPermissionQua.DataSource = dtable1

        con.Close()
    End Sub

    Public Sub fill_dish_Qt()
        con = New SqlConnection(connection)
        con.Open()
        adpt = New SqlDataAdapter()


        Dim query2 As String = "SELECT DISTINCT Dis.DishId ,  Dis.DishName 
                           FROM QtyChangeLog AS qcl
                           INNER JOIN Dish AS Dis ON qcl.DishId = Dis.DishID
                                UNION
                            SELECT 0 AS DishId, 'All' AS DishName
            
                            "

        adpt.SelectCommand = New SqlCommand(query2, con)
        ds1 = New DataSet("ds")
        adpt.Fill(ds1)
        Dim dtable1 = ds1.Tables(0)
        CmbDishNameQua.DisplayMember = "DishName"
        CmbDishNameQua.ValueMember = "DishId"
        CmbDishNameQua.DataSource = dtable1
        con.Close()
    End Sub

    Private Sub txtBillNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBillNumber.TextChanged
        filter_rate_change()
    End Sub



    Private Sub CmbBillType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBillType.SelectedIndexChanged
        'select_bill_ty_indx_RT_Ch()
        filter_rate_change()
    End Sub


    Public Sub filter_rate_change()
        Try

            Dim bill_type As String
            If CmbBillType.SelectedItem IsNot Nothing Then
                bill_type = CStr(CmbBillType.SelectedItem)
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
                If bill_type = "All" Then
                    bill_type = "All"
                End If
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim SQL As String = ""
            SQL = "exec Proc_RateChangeLog @d1,@d2,@Operator,@BillNo,@BillType,@Permission ,@Dish"
            cmd = New SqlCommand(SQL, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateFrom").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateTo").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = CInt(cmbOperator1.SelectedValue)
            cmd.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50, "BillNo").Value = txtBillNumber.Text
            cmd.Parameters.Add("@BillType", SqlDbType.NVarChar, 50, "BillType").Value = bill_type

            cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = CInt(cmbpermission1.SelectedValue)
            cmd.Parameters.Add("@Dish", SqlDbType.Int).Value = CInt(cmbDishName.SelectedValue)

            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DatagridView1.Rows.Clear()
            Dim changed_rate_sum As Decimal = 0
            Dim rate_diff_sum As Decimal = 0
            While (rdr.Read() = True)
                Dim value1 As Double = CDec(rdr(4)) ' Convert to Double or appropriate numerical type
                Dim value2 As Double = CDec(rdr(5)) ' Convert to Double or appropriate numerical type
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
                ' Extracting only the date part from ChangedDate
                Dim changedDate As Date = CDate(rdr(3))
                DatagridView1.Rows.Add(rdr(0), rdr(1), rdr(2), changedDate.ToShortDateString(), rdr(4), rdr(5), Math.Abs(result), status, rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11))
            End While
            txtRateDiffSum.Text = rate_diff_sum
            txtChangeRateSum.Text = changed_rate_sum
        Catch ex As Exception

        Finally
            rdr.Close()
            con.Close()
        End Try
        print_btn_RT_chg_enb_dis_qua()
    End Sub

    Private Sub dtpDateFrom_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        filter_rate_change()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        filter_rate_change()
    End Sub

    Public Sub filter_rate_change_print()
        Try
            Dim bill_type As String
            If CmbBillType.SelectedItem IsNot Nothing Then
                bill_type = CStr(CmbBillType.SelectedItem)
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
                If bill_type = "All" Then
                    bill_type = "All"
                End If
            End If
            Using CN As New SqlConnection(connection)
                CN.Open()

                Dim ds As New DataSet()

                Dim MyCommand1 As New SqlCommand("SELECT ID, HotelName, LocalName AS AddressLine1, Address AS AddressLine2, " &
                                              "LocalAddress AS AddressLine3, ContactNo, EmailID, TIN, STNo, CIN, Logo, " &
                                              "BaseCurrency, CurrencyCode, TicketFooterMessage, ShowLogo FROM Hotel", CN)
                MyCommand1.CommandType = CommandType.Text

                Dim myDA1 As New SqlDataAdapter(MyCommand1)
                myDA1.Fill(ds, "Hotel")

                Dim sql As String = "exec Proc_RateChangeLog @d1,@d2,@Operator,@BillNo,@BillType,@Permission ,@Dish"
                Dim cmd As New SqlCommand(sql, CN)
                cmd.Parameters.Add("@d1", SqlDbType.DateTime).Value = dtpDateFrom.Value.Date.AddHours(_startTime)
                cmd.Parameters.Add("@d2", SqlDbType.DateTime).Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
                cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = CInt(cmbOperator1.SelectedValue)
                cmd.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50).Value = txtBillNumber.Text
                cmd.Parameters.Add("@BillType", SqlDbType.NVarChar, 50).Value = bill_type
                cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = CInt(cmbpermission1.SelectedValue)
                cmd.Parameters.Add("@Dish", SqlDbType.Int).Value = CInt(cmbDishName.SelectedValue)

                Dim myDA2 As New SqlDataAdapter(cmd)
                myDA2.Fill(ds, "RateChangeLog")

                ' Load the Crystal Report
                Dim rpt2 As New RptRatechangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptRatechangeLog.rpt")

                ' Set the DataSource of the Crystal Report to the DataSet
                rpt2.SetDataSource(ds)

                ' Show the report
                frmReport.CrystalReportViewer1.ReportSource = rpt2
                frmReport.ShowDialog()

                ' Clean up
                rpt2.Close()
                rpt2.Dispose()
            End Using
        Catch ex As Exception
            ' Handle the exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Public Sub filter_qty_change_print()
        Try
            Dim bill_type As String = ""
            If CmbBillTypeQua.SelectedItem IsNot Nothing Then
                bill_type = CmbBillTypeQua.SelectedItem.ToString()
                Select Case bill_type
                    Case "Dine In"
                        bill_type = "DI"
                    Case "Take Away"
                        bill_type = "TA"
                    Case "Home Delivery"
                        bill_type = "HD"
                    Case "Third Party"
                        bill_type = "TP"
                    Case "Express Bill"
                        bill_type = "TAEB"
                    Case Else
                        bill_type = "All"
                End Select
            End If
            Using CN As New SqlConnection(connection)
                CN.Open()

                Dim ds As New DataSet()

                Dim MyCommand1 As New SqlCommand("SELECT ID, HotelName, LocalName AS AddressLine1, Address AS AddressLine2, " &
                                              "LocalAddress AS AddressLine3, ContactNo, EmailID, TIN, STNo, CIN, Logo, " &
                                              "BaseCurrency, CurrencyCode, TicketFooterMessage, ShowLogo FROM Hotel", CN)
                MyCommand1.CommandType = CommandType.Text

                Dim myDA1 As New SqlDataAdapter(MyCommand1)
                myDA1.Fill(ds, "Hotel")

                Dim SQL As String = "exec Proc_QtyChange @d1,@d2,@Operator,@BillNo,@BillType,@Permission ,@Dish"
                Dim cmd As New SqlCommand(SQL, CN)
                cmd.Parameters.Add("@d1", SqlDbType.DateTime).Value = dtpDateFromQua.Value.Date.AddHours(_startTime)
                cmd.Parameters.Add("@d2", SqlDbType.DateTime).Value = dtpDateToQua.Value.Date.AddDays(1).AddHours(_endTime)
                cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = CInt(cmbOperatorQua.SelectedValue)
                cmd.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50).Value = txtBillNumberQua.Text
                cmd.Parameters.Add("@BillType", SqlDbType.NVarChar, 50).Value = bill_type
                cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = CInt(cmbPermissionQua.SelectedValue)
                cmd.Parameters.Add("@Dish", SqlDbType.Int).Value = CInt(CmbDishNameQua.SelectedValue)

                Dim myDA2 As New SqlDataAdapter(cmd)
                myDA2.Fill(ds, "QtyChangeLog")

                ' Load the Crystal Report
                Dim rpt2 As New RptQtychangeLog
                rpt2.Load(Application.StartupPath & "\Reports\RptQtychangeLog.rpt")

                ' Set the DataSource of the Crystal Report to the DataSet
                rpt2.SetDataSource(ds)

                ' Show the report
                frmReport.CrystalReportViewer1.ReportSource = rpt2
                frmReport.ShowDialog()

                ' Clean up
                rpt2.Close()
                rpt2.Dispose()
            End Using
        Catch ex As Exception
            ' Handle the exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Public Sub filter_item_del_print()
        Try
            Dim bill_type As String = ""
            If CmbBillTypedl.SelectedItem IsNot Nothing Then
                bill_type = CmbBillTypedl.SelectedItem.ToString()
                Select Case bill_type
                    Case "Dine In"
                        bill_type = "DI"
                    Case "Take Away"
                        bill_type = "TA"
                    Case "Home Delivery"
                        bill_type = "HD"
                    Case "Third Party"
                        bill_type = "TP"
                    Case "Express Bill"
                        bill_type = "TAEB"
                    Case Else
                        bill_type = "All"
                End Select
            End If

            Using con As New SqlConnection(connection)
                con.Open()

                Dim ds As New DataSet()

                Dim MyCommand1 As New SqlCommand("SELECT ID, HotelName, LocalName AS AddressLine1, Address AS AddressLine2, " &
                                              "LocalAddress AS AddressLine3, ContactNo, EmailID, TIN, STNo, CIN, Logo, " &
                                              "BaseCurrency, CurrencyCode, TicketFooterMessage, ShowLogo FROM Hotel", con)
                MyCommand1.CommandType = CommandType.Text

                Dim myDA1 As New SqlDataAdapter(MyCommand1)
                myDA1.Fill(ds, "Hotel")

                Dim SQL As String = "exec Proc_itemDeleted @d1,@d2,@Operator,@BillNo,@BillType,@Permission ,@Dish"
                Dim cmd As New SqlCommand(SQL, con)
                cmd.Parameters.Add("@d1", SqlDbType.DateTime).Value = dtpDateFromdl.Value.Date.AddHours(_startTime)
                cmd.Parameters.Add("@d2", SqlDbType.DateTime).Value = dtpDateTodl.Value.Date.AddDays(1).AddHours(_endTime)
                cmd.Parameters.Add("@Operator", SqlDbType.Int).Value = CInt(cmbOperatordl.SelectedValue)
                cmd.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50).Value = txtBillNumberdl.Text
                cmd.Parameters.Add("@BillType", SqlDbType.NVarChar, 50).Value = bill_type
                cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = CInt(cmbPermissiondl.SelectedValue)
                cmd.Parameters.Add("@Dish", SqlDbType.Int).Value = CInt(cmbDishNameDl.SelectedValue)

                Dim myDA2 As New SqlDataAdapter(cmd)
                myDA2.Fill(ds, "Item_delete")

                ' Load the Crystal Report
                Dim rpt2 As New RptItemDelete
                rpt2.Load(Application.StartupPath & "\Reports\RptItemDelete.rpt")

                ' Set the DataSource of the Crystal Report to the DataSet
                rpt2.SetDataSource(ds)

                ' Show the report
                frmReport.CrystalReportViewer1.ReportSource = rpt2
                frmReport.ShowDialog()

                ' Clean up
                rpt2.Close()
                rpt2.Dispose()
            End Using
        Catch ex As Exception
            ' Handle the exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        filter_rate_change_print()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ToExcel2(DatagridView1)
    End Sub

    Private Sub btnExportExcelqua_Click(sender As Object, e As EventArgs) Handles btnExportExcelqua.Click
        ToExcel2(DatagridViewQty)
    End Sub

    Private Sub cmbDishName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDishName.SelectedIndexChanged
        filter_rate_change()
    End Sub

    Private Sub CmbDishNameQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDishNameQua.SelectedIndexChanged
        filter_qty_change()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Label10qua_Click(sender As Object, e As EventArgs) Handles Label10qua.Click

    End Sub

    Private Sub cmbDishNameDl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDishNameDl.SelectedIndexChanged
        filter_item_del()
    End Sub

    Private Sub Label10dl_Click(sender As Object, e As EventArgs) Handles Label10dl.Click

    End Sub

    Private Sub Panel1Qua_Paint(sender As Object, e As PaintEventArgs) Handles Panel1Qua.Paint

    End Sub

    Private Sub BtnPrintqua_Click_1(sender As Object, e As EventArgs) Handles BtnPrintqua.Click
        filter_qty_change_print()
    End Sub

    Private Sub BtnPrintqua1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbOperator1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator1.SelectedIndexChanged
        filter_rate_change()
    End Sub

    Private Sub cmbpermission1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpermission1.SelectedIndexChanged
        filter_rate_change()
    End Sub

    Private Sub cmbDishName1_SelectedIndexChanged(sender As Object, e As EventArgs)
        filter_rate_change()
    End Sub



    Private Sub cmbOperator3_SelectedIndexChanged(sender As Object, e As EventArgs)
        filter_rate_change()
    End Sub
End Class