Imports System.Data.SqlClient



Public Class frmKotAmontReport
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim CN As New SqlConnection(cs)
        CN.Open()

        'Dim rpt As New rptKotAmount
        'rpt.Load(Application.StartupPath + "\Reports\rptKotAmount.rpt")
        Dim rpt As New rptKOTAmountReport
        rpt.Load(Application.StartupPath + "\Reports\rptKOTAmountReport.rpt")
        Dim myConnection As SqlConnection
        Dim MyCommand, MyCommand1, MyCommand2 As New SqlCommand()
        Dim myDA, myDA1, myDA2 As New SqlDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.
        myConnection = New SqlConnection(cs)
        MyCommand.Connection = myConnection
        MyCommand1.Connection = myConnection

        'MyCommand.CommandText = "exec Proc_KotAmout @d1,@d2"
        MyCommand.CommandText = "exec Proc_WithKotAmount @d1,@d2,@mode "
        MyCommand1.CommandText = " SELECT ID,HotelName,LocalName as AddressLine1,Address as AddressLine2,
                                    LocalAddress as AddressLine3,ContactNo,EmailID,TIN,STNo,CIN,Logo,
                                    BaseCurrency,CurrencyCode,TicketFooterMessage,ShowLogo  from Hotel"
        MyCommand.CommandType = CommandType.Text
        MyCommand1.CommandType = CommandType.Text

        MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        MyCommand.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
        myDA.SelectCommand = MyCommand
        myDA1.SelectCommand = MyCommand1

        myDA.Fill(myDS, "VAT1")

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

    Public Sub GetKotAmountReport()
        Dim con As New SqlConnection(connection)
        con.Open()
        Dim query As String = "exec Proc_WithKotAmount @d1,@d2,@mode "
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        DgwKotAmountReport.Rows.Clear()
        While reader.Read()
            Dim billDate As Date = CDate(reader("BillDate"))
            DgwKotAmountReport.Rows.Add(billDate.ToShortDateString(), reader("DineIN"), reader("TakeAway"), reader("HomeDelivery"), reader("ThirdParty"), reader("Amount"))
        End While
        reader.Close()
        con.Close()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        GetKotAmountReport()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        GetKotAmountReport()
    End Sub

    Private Sub frmKotAmontReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub
End Class