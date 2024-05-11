Imports System.Data.SqlClient

Public Class frmDishCategoryReport
    Dim total_qu As Decimal = 0
    Dim total_amt As Decimal = 0
    Public Sub ItemCategorySearch()
        DataGridView1.Rows.Clear()
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            Dim query As String = "exec Proc_ItemCategory2 @d1,@d2,@BranchId,@catId"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@BranchId", SqlDbType.Int, 30, "BranchId").Value = myBranchId
            ' cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            ' cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@catId", SqlDbType.Int, 30, "catId").Value = CInt(cmbCategory.SelectedValue)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                'reader("column2") is a total quantity and reader("GrandTotal") is a total amount
                'totl_qu and total_amt every row result
                total_qu = total_qu + reader("column2")
                total_amt = total_amt + reader("GrandTotal")
                DataGridView1.Rows.Add(reader("category"), "", "", reader("Column2"), Math.Round(reader("GrandTotal"), 2))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        txtTotalQuantity.Text = total_qu.ToString("0.00")
        txtTotalAmount.Text = total_amt.ToString("0.00")
        amountQtyPer()
    End Sub

    Public Sub amountQtyPer()
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim qty_cell As Decimal = CDec(row.Cells("TotalQty").Value)
            Dim amt_cell As Decimal = CDec(row.Cells("TotalAmount").Value)
            Dim qty_percen As Decimal = Math.Round((qty_cell * 100) / total_qu, 2) ' Round to 2 decimal places
            Dim amt_percen As Decimal = Math.Round((amt_cell * 100) / total_amt, 2) ' Round to 2 decimal places
            row.Cells("Qtypercentage").Value = qty_percen.ToString("0.00")
            row.Cells("AmountPercentage").Value = amt_percen.ToString("0.00")
        Next
    End Sub

    Public Sub ItemCategoryReportPrint1()
        Dim CN As New SqlConnection(cs)
        CN.Open()

        Dim rpt As New rpt_SalesCategoryReport23
        rpt.Load(Application.StartupPath + "\Reports\rpt_SalesCategoryReport23.rpt")

        Dim myConnection As SqlConnection
        Dim MyCommand, MyCommand1, MyCommand2 As New SqlCommand()
        Dim myDA, myDA1, myDA2 As New SqlDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.
        myConnection = New SqlConnection(cs)
        MyCommand.Connection = myConnection
        MyCommand1.Connection = myConnection
        MyCommand2.Connection = myConnection
        MyCommand.CommandText = "exec Proc_ItemCategory @d1,@d2,@BranchId"
        '    MyCommand.CommandText = " SELECT CategoryName as DishName,sum(Quantity) as Column2,sum(TotalAmount) as GrandTotal FROM (select CategoryName,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT okot
        'inner join RestaurantPOS_BillingInfoKOT Ikot  on ikot.id=okot.BillID inner join Category cat on 
        'okot.Cat_id=cat.Cat_ID where BillDate >=@d1 and BillDate <@d2 and BranchId=" & myBranchId & " and ikot.IsDeleted='False'
        'Union all  select Cat.categoryName,Quantity,(TotalAmount * ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA OTA
        'inner join RestaurantPOS_BillingInfoTA ITA on OTA.BILLID=ITA.Id inner join Category cat on OTA.CAT_ID=CAT.Cat_ID WHERE
        'BillDate >=@d1 and BillDate <@d2 and TA_Status <> 'void' and BranchId=" & myBranchId & "
        'Union all select CategoryName ,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedproductBillHD ohd inner join RestaurantPOS_BillingInfoHD ihd
        'on ohd.BillID=ihd.Id inner join Category cat on ohd.Cat_Id=cat.Cat_ID where BillDate >=@d1 and BillDate <@d2 and HD_Status <>
        ''Void' and BranchId=" & myBranchId & ")C group BY CategoryName order by 1"
        'MyCommand2.CommandText = "select BranchId,SUM(grandtotal) AS Rate,sum(DiscountAmt)as TotalDiscount,SUM(totvat) TotalVAT,SUM(sub)as SubTotal from (select BranchId,grandtotal, KOTDiscountAmt as DiscountAmt ,totvat,SubTotal as sub from RestaurantPOS_BillingInfoKOT 
        '        where BillDate between @d1 and @d2 and isdeleted = 'false'
        '    union all
        '    select BranchId,grandtotal,TADiscountAmt as DiscountAmt,totvat,SubTotal as sub from RestaurantPOS_BillingInfoTA 
        '    where BillDate between @d1 and @d2 and TA_Status  = 'Paid'and isdeleted = 'false'
        '    union all
        '    select BranchId,grandtotal,hdDiscountAmt as DiscountAmt,totvat,SubTotal as sub from RestaurantPOS_BillingInfoHD 
        '    where BillDate between @d1 and @d2 and  HD_Status ='Paid' and isdeleted = 'false'
        '    union all
        '    select BranchId,grandtotal,EBDiscountAmt as DiscountAmt,totvat,SubTotal as sub from RestaurantPOS_BillingInfoEB 
        '    where BillDate between @d1 and @d2 and EB_Status = 'Closed' and isdeleted = 'false')c group by BranchId"

        MyCommand1.CommandText = " SELECT ID,HotelName,LocalName as AddressLine1,Address as AddressLine2,
                                    LocalAddress as AddressLine3,ContactNo,EmailID,TIN,STNo,CIN,Logo,
                                    BaseCurrency,CurrencyCode,TicketFooterMessage,ShowLogo  from Hotel"
        MyCommand.CommandType = CommandType.Text
        MyCommand1.CommandType = CommandType.Text

        MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        MyCommand.Parameters.Add("@BranchId", SqlDbType.Int, 30, "BranchId").Value = myBranchId
        MyCommand2.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        MyCommand2.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        myDA.SelectCommand = MyCommand
        myDA1.SelectCommand = MyCommand1

        myDA.Fill(myDS, "VAT1")

        myDA1.Fill(myDS, "Hotel")

        rpt.SetDataSource(myDS)
        If myDS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
            Return
        End If
        rpt.SetParameterValue("p1", dtpDateFrom.Value.Date)
        rpt.SetParameterValue("p2", dtpDateTo.Value.Date)
        frmReport.CrystalReportViewer1.ReportSource = rpt
        frmReport.ShowDialog()
        rpt.Close()
        rpt.Dispose()

    End Sub


    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        ItemCategoryReportPrint1()
    End Sub

    Public Sub GetCategoryCombo()
        ' Assuming your ComboBox is named cmbCategory
        Try
            Dim query As String = "SELECT 'All' AS CategoryName, 0 AS Cat_ID 
                               UNION 
                               SELECT CategoryName, Cat_ID FROM Category"
            Using conn As New SqlConnection(connection)

                conn.Open()
                adpt = New SqlDataAdapter()

                adpt.SelectCommand = New SqlCommand(query, conn)
                ds = New DataSet("ds")
                adpt.Fill(ds)
                Dim dtable = ds.Tables(0)
                cmbCategory.DisplayMember = "CategoryName"
                cmbCategory.ValueMember = "Cat_ID"
                cmbCategory.DataSource = dtable

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmDishCategoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCategoryCombo()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If DataGridView1.Rows.Count > 0 Then
            ToExcel2(DataGridView1)
        Else
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        ItemCategorySearch()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        ItemCategorySearch()
    End Sub
End Class