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
        Dim reader As SqlDataReader = Nothing
        Try
            con.Open()
            Dim query As String = "exec Proc_WithKotAmount3 @d1,@d2,@operator ,@foodtime"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@operator", SqlDbType.NVarChar, 50, "operator").Value = cmbOperator.Text()
            cmd.Parameters.Add("@foodtime ", SqlDbType.NVarChar, 50, "foodtime ").Value = cmbFoodTime.Text()
            ' cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"
            reader = cmd.ExecuteReader()
            DgwKotAmountReport.Rows.Clear()
            While reader.Read()
                Dim billDate As String = CDate(reader("BillDate")).ToString("d/MMM/yyyy")
                DgwKotAmountReport.Rows.Add(reader("Operator"), billDate, reader("DineIN"), reader("TakeAway"), reader("HomeDelivery"), reader("ThirdParty"), reader("Amount"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            reader.Close()
            con.Close()
        End Try
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        GetKotAmountReport()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        GetKotAmountReport()
    End Sub

    Public Sub operator_load()
        Try
            Dim query As String = "SELECT DISTINCT EmpId, EmployeeName FROM EmployeeRegistration UNION SELECT 0 AS EmpId, 'All' AS EmployeeName"
            Using conn As New SqlConnection(connection)
                conn.Open()
                Dim adapte As New SqlDataAdapter(query, conn)
                Dim ds As New DataSet()
                adapte.Fill(ds)
                Dim dt As DataTable = ds.Tables(0)
                cmbOperator.DisplayMember = "EmployeeName"
                cmbOperator.ValueMember = "EmpId"
                cmbOperator.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading operators: " & ex.Message)
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

    Private Sub frmKotAmontReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operator_load()
        foodtime_load()
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
        GetKotAmountReport()
    End Sub

    Private Sub cmbFoodTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFoodTime.SelectedIndexChanged
        GetKotAmountReport()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If DgwKotAmountReport.Rows.Count = 0 Then
            MessageBox.Show("Sorry...No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
            Return
        Else
            ToExcel2(DgwKotAmountReport)
        End If

    End Sub
End Class