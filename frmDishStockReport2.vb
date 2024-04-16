Imports System.Data.SqlClient

Public Class frmDishStockReport2

    Public Sub displayStockReport()
        Try
            Dim con As New SqlConnection(connection)
            con.Open()
            Dim query As String = "exec Proc_SaleQTYAnalysisWithKOT @d1,@d2,@mode,@d3,@d4"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
            cmd.Parameters.Add("@d3", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d4", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1)
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ' Add the retrieved data to the DataGridView
            DatagridViewstock.Rows.Clear()
            While rdr.Read()
                Dim billDate As Date = CDate(rdr("BillDate"))
                DatagridViewstock.Rows.Add(billDate.ToShortDateString(), rdr("dishName"), rdr("Stock"), rdr("Staff"), rdr("Management"), rdr("OtherStaff"), rdr("Complimentory"), rdr("Dispose"), rdr("DineIN"), rdr("TakeAway"), rdr("HomeDelivery"), rdr("ThirdParty"), rdr("Balance"))
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        Finally
            con.Close()
        End Try
    End Sub








    Private Sub dtpDateTo_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        displayStockReport()
    End Sub

    Private Sub dtpDateFrom_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        displayStockReport()
    End Sub

    Private Sub BtnPrint_Click_1(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Try

            Dim CN As New SqlConnection(cs)
            CN.Open()
            Dim rpt As New rptStockEntry23New
            rpt.Load(Application.StartupPath + "\Reports\rptStockEntry23New.rpt")
            Dim myConnection As SqlConnection
            Dim MyCommand, MyCommand1 As New SqlCommand()
            Dim myDA, myDA1, myDA2 As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand1.Connection = myConnection
            MyCommand.CommandText = "exec Proc_SaleQTYAnalysisWithKOT @d1,@d2,@mode,@d3,@d4"

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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub
End Class