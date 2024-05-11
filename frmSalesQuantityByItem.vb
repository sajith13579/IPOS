Imports System.Data.SqlClient

Public Class frmSalesQuantityByItem
    Private formLoaded As Boolean = False
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub GetData()
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            Dim query As String = "exec  Proc_SaleQTYAnalysisWithOUTKOT2 @d1,@d2,@d3,@d4,@foodTime,@dish"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime).Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime).Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@dish", SqlDbType.Int).Value = CInt(cmbDish.SelectedValue.ToString())
            cmd.Parameters.Add("@foodTime", SqlDbType.NVarChar, 50, "foodTime").Value = cmbFoodTime.Text
            cmd.Parameters.Add("@d3", SqlDbType.DateTime).Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d4", SqlDbType.DateTime).Value = dtpDateTo.Value.Date.AddDays(1)




            ' cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            Dim total_DI As Decimal = 0
            Dim total_TA As Decimal = 0
            Dim total_HD As Decimal = 0
            Dim total_TP As Decimal = 0
            Dim total_qua_all_row As Decimal = 0
            Dim total_amt As Decimal = 0
            While reader.Read()
                total_DI = total_DI + CDec(reader("DineIN"))
                total_TA = total_TA + CDec(reader("TakeAway"))
                total_HD = total_HD + CDec(reader("HomeDelivery"))
                total_TP = total_TP + CDec(reader("ThirdParty"))
                total_amt = total_amt + CDec(reader("Amount"))
                '  Dim billdae As Date = CDate(reader("BillDate"))

                'Total Quantity of each row
                Dim tot_quatity As Integer = reader("DineIN") + reader("TakeAway") + reader("HomeDelivery") + reader("ThirdParty")
                'Total Quantity of all row
                total_qua_all_row = total_qua_all_row + tot_quatity
                DataGridView1.Rows.Add(reader("DishName"), reader("DineIN"), reader("TakeAway"),
                                       reader("HomeDelivery"), reader("ThirdParty"), tot_quatity, reader("Amount"))
            End While

            txtTotalDI.Text = CStr(total_DI)
            txtTotalTA.Text = CStr(total_TA)
            txtTotalHD.Text = CStr(total_HD)
            txtTotalTP.Text = CStr(total_TP)
            txtTotalQty.Text = total_qua_all_row
            txtTotalAmt.Text = total_amt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpDateTo_ValueChanged_1(sender As Object, e As EventArgs)
        GetData()
    End Sub

    Private Sub dtpDateFrom_ValueChanged_1(sender As Object, e As EventArgs)
        GetData()
    End Sub

    Private Sub BtnPrint_Click_1(sender As Object, e As EventArgs)
        Dim CN As New SqlConnection(cs)
        CN.Open()
        Dim rpt As New rptSalesQuantityByItem
        rpt.Load(Application.StartupPath + "\Reports\ rptSalesQuantityByItem.rpt")
        Dim myConnection As SqlConnection
        Dim MyCommand, MyCommand1, MyCommand2 As New SqlCommand()
        Dim myDA, myDA1, myDA2 As New SqlDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.
        myConnection = New SqlConnection(cs)
        MyCommand.Connection = myConnection
        MyCommand1.Connection = myConnection
        MyCommand.CommandText = "exec  Proc_SaleQTYAnalysisWithOUTKOT @d1,@d2,@mode,@d3,@d4"
        MyCommand1.CommandText = " SELECT ID,HotelName,LocalName as AddressLine1,Address as AddressLine2,
                                    LocalAddress as AddressLine3,ContactNo,EmailID,TIN,STNo,CIN,Logo,
                                    BaseCurrency,CurrencyCode,TicketFooterMessage,ShowLogo  from Hotel"
        MyCommand.CommandType = CommandType.Text
        MyCommand1.CommandType = CommandType.Text
        MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)

        MyCommand.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
        MyCommand.Parameters.Add("@d3", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
        MyCommand.Parameters.Add("@d4", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1)
        myDA.SelectCommand = MyCommand
        myDA1.SelectCommand = MyCommand1
        myDA.Fill(myDS, "VAT1")
        myDA1.Fill(myDS, "Hotel")
        If myDS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
            Return
        End If
        con = New SqlConnection(cs)
        con.Open()
        Dim cmdText As String = " exec Proc_RoundOffWithOutKOT @d1,@d2,@mode"
        cmd = New SqlCommand(cmdText)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateIN").Value = dtpDateFrom.Value.Date.AddHours(5)
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateIN").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(5)
        cmd.Parameters.Add("@mode", SqlDbType.NVarChar, 20, "FoodTime").Value = "All"
        cmd.Connection = con
        rdr = cmd.ExecuteReader
        Dim x As Decimal
        Dim y As Decimal
        If rdr.Read() Then
            x = rdr("grandtotal").ToString()
            y = rdr("roundoff").ToString()
        End If
        con.Close()
        rpt.SetDataSource(myDS)
        rpt.SetParameterValue("p1", dtpDateFrom.Value.Date)
        rpt.SetParameterValue("p2", dtpDateTo.Value.Date)
        rpt.SetParameterValue("p3", x)
        rpt.SetParameterValue("p4", y)
        frmReport.CrystalReportViewer1.ReportSource = rpt
        frmReport.ShowDialog()
        rpt.Close()
        rpt.Dispose()
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub bttnPrint2_Click(sender As Object, e As EventArgs) Handles bttnPrint2.Click
        Dim CN As New SqlConnection(cs)
        CN.Open()
        Dim rpt As New rptSalesQuantityByItem
        rpt.Load(Application.StartupPath + "\Reports\ rptSalesQuantityByItem.rpt")
        Dim myConnection As SqlConnection
        Dim MyCommand, MyCommand1, MyCommand2 As New SqlCommand()
        Dim myDA, myDA1, myDA2 As New SqlDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.
        myConnection = New SqlConnection(cs)
        MyCommand.Connection = myConnection
        MyCommand1.Connection = myConnection
        ' MyCommand.CommandText = "exec  Proc_SaleQTYAnalysisWithOUTKOT @d1,@d2,@mode,@d3,@d4"
        MyCommand.CommandText = "exec  Proc_SaleQTYAnalysisWithOUTKOT2 @d1,@d2,@d3,@d4,@foodTime,@dish"
        MyCommand1.CommandText = " SELECT ID,HotelName,LocalName as AddressLine1,Address as AddressLine2,
                                    LocalAddress as AddressLine3,ContactNo,EmailID,TIN,STNo,CIN,Logo,
                                    BaseCurrency,CurrencyCode,TicketFooterMessage,ShowLogo  from Hotel"
        MyCommand.CommandType = CommandType.Text
        MyCommand1.CommandType = CommandType.Text
        MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        MyCommand.Parameters.Add("@dish", SqlDbType.Int).Value = CInt(cmbDish.SelectedValue.ToString())
        MyCommand.Parameters.Add("@foodTime", SqlDbType.NVarChar, 50, "foodTime").Value = cmbFoodTime.Text
        '  MyCommand.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
        MyCommand.Parameters.Add("@d3", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
        MyCommand.Parameters.Add("@d4", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1)
        myDA.SelectCommand = MyCommand
        myDA1.SelectCommand = MyCommand1
        myDA.Fill(myDS, "VAT1")
        myDA1.Fill(myDS, "Hotel")
        If myDS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
            Return
        End If
        con = New SqlConnection(cs)
        con.Open()
        Dim cmdText As String = " exec Proc_RoundOffWithOutKOT @d1,@d2,@mode"
        cmd = New SqlCommand(cmdText)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateIN").Value = dtpDateFrom.Value.Date.AddHours(5)
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateIN").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(5)
        cmd.Parameters.Add("@mode", SqlDbType.NVarChar, 20, "FoodTime").Value = cmbFoodTime.Text
        'cmd.Parameters.Add("@dish", SqlDbType.Int).Value = CInt(cmbDish.SelectedValue.ToString())
        cmd.Connection = con
        rdr = cmd.ExecuteReader
        Dim x As Decimal
        Dim y As Decimal
        If rdr.Read() Then
            x = rdr("grandtotal").ToString()
            y = rdr("roundoff").ToString()
        End If
        con.Close()
        rpt.SetDataSource(myDS)
        rpt.SetParameterValue("p1", dtpDateFrom.Value.Date)
        rpt.SetParameterValue("p2", dtpDateTo.Value.Date)
        rpt.SetParameterValue("p3", x)
        rpt.SetParameterValue("p4", y)
        frmReport.CrystalReportViewer1.ReportSource = rpt
        frmReport.ShowDialog()
        rpt.Close()
        rpt.Dispose()
    End Sub



    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged

    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub


    Public Sub GetDishCombo()
        ' Assuming your ComboBox is named cmbCategory
        Try
            Dim query As String = "SELECT DishName, DishID FROM Dish
                union
                select 'All' as DishName , 0 as DishID
                "
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    adpt = New SqlDataAdapter()
                    adpt.SelectCommand = New SqlCommand(query, con)
                    ds = New DataSet("ds")
                    adpt.Fill(ds)
                    Dim dtable = ds.Tables(0)
                    cmbDish.DisplayMember = "DishName"
                    cmbDish.ValueMember = "DishID"
                    cmbDish.DataSource = dtable
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub foodtime_load()
        cmbFoodTime.Items.Add("Breakfast")
        cmbFoodTime.Items.Add("Lunch")
        cmbFoodTime.Items.Add("TeaTime")
        cmbFoodTime.Items.Add("Dinner")
        cmbFoodTime.Items.Insert(0, "All")
        cmbFoodTime.SelectedIndex = 0
    End Sub
    Private Sub frmSalesQuantityByItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDishCombo()
        cmbDish.SelectedIndex = 0
        foodtime_load()
        cmbFoodTime.SelectedIndex = 0
        formLoaded = True
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbDish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDish.SelectedIndexChanged
        GetData()
    End Sub

    Private Sub cmbFoodTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFoodTime.SelectedIndexChanged
        GetData()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
            Return
        Else
            ToExcel2(DataGridView1)
        End If
    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        GetData()
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Sorry..No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class