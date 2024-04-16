Imports System.Data.SqlClient

Public Class frmSalesQuantityByItem
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub GetData()
        Dim con As New SqlConnection(connection)
        con.Open()
        Dim query As String = "exec  Proc_SaleQTYAnalysisWithOUTKOT @d1,@d2,@mode,@d3,@d4"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)

        cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
        cmd.Parameters.Add("@d3", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
        cmd.Parameters.Add("@d4", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            Dim billdae As Date = CDate(reader("BillDate"))
            Dim tot_quatity As Integer = reader("DineIN") + reader("TakeAway") + reader("HomeDelivery") + reader("ThirdParty")
            DataGridView1.Rows.Add(billdae.ToShortDateString(), reader("DishName"), reader("DineIN"), reader("TakeAway"),
                                   reader("HomeDelivery"), reader("ThirdParty"), tot_quatity, reader("Amount"))
        End While
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpDateTo_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        GetData()
    End Sub

    Private Sub dtpDateFrom_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        GetData()
    End Sub

    Private Sub BtnPrint_Click_1(sender As Object, e As EventArgs) Handles BtnPrint.Click
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

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub
End Class