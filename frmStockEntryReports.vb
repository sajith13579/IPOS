Imports System.Data.SqlClient

Public Class frmStockEntryReports
    Public Strt_Hours As Integer = _startTime
    Public End_hours As Integer = _endTime
    Private Sub frmStockEntryReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Try
            Cursor = Cursors.WaitCursor
            con = New SqlConnection(connection)
            con.Open()
            ''  Dim str As String = ("Select ItemName , Quantity as Quantity,SUM(StockIn) AS STOCKIN from
            '' (select (D.DishName) AS ItemName,(TS.QTY) as Quantity,(rkot.Quantity) as STOCKiN
            '' from Temp_Stock_Store TS inner join  RestaurantPOS_OrderedProductBillKOT RKOT on TS.Dish_id=RKOT.DishID
            ''INNER JOIN DISH d ON TS.Dish_ID=d.DishID inner join RestaurantPOS_OrderInfoKOT rikot
            ''  on rkot.BillID=rikot.ID where rikot.BillDate >=@d1 and rikot.BillDate <@d2 ) 
            ''  g group by itemname ") 
            ''      Dim STR As String = "with ItemName as (
            ''      select ds.DishID,ds.DishName as ItemName from Dish ds),
            ''      Quantity as 
            ''      (select ts.Dish_id,sum(ts.Qty) as Quantity 
            ''      from Temp_Stock_Store TS 
            ''      group by ts.Dish_id),
            ''      stockIn as (
            ''      select  rkot.Dish_Id,sum(rkot.Quantity) as StockIn
            ''from RestaurantPOS_OrderedProductBillKOT RKOT 
            ''      INNER JOIN RestaurantPOS_OrderInfoKOT RKIOT ON RKOT.BillID=Rkiot.ID
            ''WHERE BILLdate >=@d1 and billDate<@d2
            ''group by RKOT.Dish_Id) 
            ''select ItemName.ItemName,Quantity.Quantity,stockIn.StockIn from ItemName
            ''      join Quantity on Quantity.Dish_id=ItemName.DishID
            ''      join stockIn on stockIn.Dish_Id=ItemName.DishID	 " 
            Dim str As String = "    with ItemName as 
      (select ds.DishID,ds.DishName as ItemName from Dish ds),
   
    stockIn as 
               (select  rkot.Dish_Id,sum(rkot.Quantity) as StockIn from RestaurantPOS_OrderedProductBillKOT RKOT 
                INNER JOIN RestaurantPOS_OrderInfoKOT RKIOT ON RKOT.BillID=Rkiot.ID
                WHERE BILLdate >=@d1 and billDate<=@d2 group by RKOT.Dish_Id)
                    ,
 
	   stockEntry as (select SK.Dish_Id, sk.Qty as Quantity,sk.staff as Staff,sk.Management as Management,
	   sk.Complimentory as Complimentory,sk.Dispose as Dispose 
       from STOCK_STORE_JOIN SK 
       where BillDate >=@d1 and BillDate<=@d2) 
		           
     select ItemName.ItemName,Stockentry.Quantity,stockEntry.Staff,stockentry.Management,stockentry.Complimentory,
     stockentry.Dispose  from ItemName
               left outer join stockIn on stockIn.Dish_Id=ItemName.DishID 
               left outer JOIN StockEntry on StockEntry.Dish_Id=itemname.DishID
               where not stockEntry.Quantity is null
                  "
            cmd = New SqlCommand(str)
            'cmd.CommandText = str
            cmd.Connection = con
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "BillDate").Value = dtpDateFrom.Value.Date.AddHours(Strt_Hours)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "BillDate").Value = dtpDateTo.Value.AddDays(1).AddHours(End_hours)
            adpt = New SqlDataAdapter(cmd)

            Dim dtable = New DataTable()
            adpt.Fill(dtable)
            con.Close()
            If dtable.Rows.Count = 0 Then
                MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cursor = Cursors.Default
                Return
            End If
            ds = New DataSet()
            ds.Tables.Add(dtable)
            Dim rpt As New StockEntry

            rpt.SetDataSource(dtable)
            rpt.SetParameterValue("p1", dtpDateFrom.Value.Date)
            rpt.SetParameterValue("p2", dtpDateTo.Value.Date)

            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()


            rpt.Close()
            rpt.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub

    Public Sub getData()
        Dim conne As New SqlConnection(connection)
        Try

            conne.Open()
            Dim query As String = "with ItemName as 
      (select ds.DishID,ds.DishName as ItemName from Dish ds),
   
    stockIn as 
               (select  rkot.Dish_Id,sum(rkot.Quantity) as StockIn from RestaurantPOS_OrderedProductBillKOT RKOT 
                INNER JOIN RestaurantPOS_OrderInfoKOT RKIOT ON RKOT.BillID=Rkiot.ID
                WHERE BILLdate >=@d1 and billDate<=@d2 group by RKOT.Dish_Id)
                    ,
 
	   stockEntry as (select SK.Dish_Id, sk.Qty as Quantity,sk.staff as Staff,sk.Management as Management,
	   sk.Complimentory as Complimentory,sk.Dispose as Dispose 
       from STOCK_STORE_JOIN SK 
       where BillDate >=@d1 and BillDate<=@d2) 
		           
     select ItemName.ItemName,Stockentry.Quantity,stockEntry.Staff,stockentry.Management,stockentry.Complimentory,
     stockentry.Dispose  from ItemName
               left outer join stockIn on stockIn.Dish_Id=ItemName.DishID 
               left outer JOIN StockEntry on StockEntry.Dish_Id=itemname.DishID
               where not stockEntry.Quantity is null
                  "
            Dim cmd As New SqlCommand(query, conne)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "BillDate").Value = dtpDateFrom.Value.Date.AddHours(Strt_Hours)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "BillDate").Value = dtpDateTo.Value.AddDays(1).AddHours(End_hours)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim balance As Decimal = (reader("Quantity")) - (reader("Staff") + reader("Management") + reader("Complimentory") + reader("Dispose"))
                DataGridView1.Rows.Add(reader("ItemName"), reader("Quantity"), reader("Staff"), reader("Management"), reader("Complimentory"), reader("Dispose"), balance)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If conne.State = ConnectionState.Open Then
                conne.Close()
            End If

        End Try

    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        getData()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        getData()
    End Sub
End Class