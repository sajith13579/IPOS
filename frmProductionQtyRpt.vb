Imports System.Data.SqlClient
Public Class frmProductionQtyRpt
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim CN As New SqlConnection(cs)
        CN.Open()

        Dim rpt As New rptDishProduction
        rpt.Load(Application.StartupPath + "\Reports\ rptDishProduction.rpt")

        Dim myConnection As SqlConnection
        Dim MyCommand, MyCommand1, MyCommand2 As New SqlCommand()
        Dim myDA, myDA1, myDA2 As New SqlDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.
        myConnection = New SqlConnection(cs)
        MyCommand.Connection = myConnection
        MyCommand1.Connection = myConnection

        MyCommand.CommandText = "exec Proc_DishProductionQty @d1,@d2"


        MyCommand1.CommandText = " SELECT ID as HID,HotelName,LocalName as AddressLine1,Address as AddressLine2,
                                    LocalAddress as AddressLine3,ContactNo,EmailID,TIN,STNo,CIN,Logo,
                                    BaseCurrency,CurrencyCode,TicketFooterMessage,ShowLogo  from Hotel"
        MyCommand.CommandType = CommandType.Text
        MyCommand1.CommandType = CommandType.Text

        MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(0)
        MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)

        myDA.SelectCommand = MyCommand
        myDA1.SelectCommand = MyCommand1

        myDA.Fill(myDS, "DishProduction")

        myDA1.Fill(myDS, "Hotel")
        If myDS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
            Return
        End If

        rpt.SetDataSource(myDS)
        rpt.SetParameterValue("p1", dtpDateFrom.Value.Date)
        rpt.SetParameterValue("p2", dtpDateTo.Value.Date)
        frmReport.CrystalReportViewer1.ReportSource = rpt
        frmReport.ShowDialog()
        rpt.Close()
        rpt.Dispose()
    End Sub

    Public Sub GetData()
        Dim con As New SqlConnection(connection)
        con.Open()
        Dim query As String = "exec Proc_DishProductionQty @d1,@d2"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(0)
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Dim tot_stock As Decimal = 0
        Dim tot_used As Decimal = 0
        Dim tot_bal As Decimal = 0
        DataGridView1.Rows.Clear()
        While reader.Read()
            tot_stock = tot_stock + CDec(reader("ProductionQty"))
            tot_used = tot_used + CDec(reader("consumption"))

            Dim Billdate As Date = CDate(reader("Billdate"))
            Dim bal As Decimal = CDec(reader("ProductionQty")) - CDec(reader("consumption"))
            tot_bal = tot_bal + bal
            DataGridView1.Rows.Add(Billdate.ToShortDateString(), reader("DishName"), reader("ProductionQty"), reader("consumption"), bal)
        End While

        lblTotalStock.Text = CStr(tot_stock)
        lblTotalUsed.Text = CStr(tot_used)
        lblTotalBal.Text = CStr(tot_bal)
        reader.Close()
        con.Close()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        GetData()
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        GetData()
    End Sub
End Class