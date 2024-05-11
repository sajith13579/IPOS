Imports System.Data.SqlClient



Public Class frmKotAmontReport

    Public Sub uncheckedprint()
        Dim oper_en As Boolean
        If cmbOperator.Enabled = True Then
            oper_en = True
        Else
            oper_en = True
        End If

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
        rpt.SetParameterValue("oper_enabl", oper_en)

        frmReport.CrystalReportViewer1.ReportSource = rpt
        frmReport.ShowDialog()
        rpt.Close()
        rpt.Dispose()
        CN.Close()
    End Sub

    Public Sub checkedprint()
        Dim con As New SqlConnection(connection)

        Try
            Dim oper_en As Boolean
            If cmbOperator.Enabled = True Then
                oper_en = True
            Else
                oper_en = False
            End If

            con.Open()
            Dim rpt As New rptKOTAmountReport
            rpt.Load(Application.StartupPath + "\Reports\rptKOTAmountReport.rpt")
            Dim myDA, myDA1 As New SqlDataAdapter()
            Dim myDS As New DataSet
            Dim query As String = "exec Proc_WithKotAmount3 @d1,@d2,@operator ,@foodtime,@operatorwise"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@operator", SqlDbType.NVarChar, 50, "operator").Value = cmbOperator.Text()
            cmd.Parameters.Add("@foodtime ", SqlDbType.NVarChar, 50, "foodtime ").Value = cmbFoodTime.Text()
            cmd.Parameters.Add("@operatorwise", SqlDbType.Bit).Value = chkOperatorWise.Checked

            Dim Mycommand1 As New SqlCommand()
            Mycommand1.Connection = con
            Mycommand1.CommandText = "SELECT ID,HotelName,LocalName as AddressLine1,Address as AddressLine2, LocalAddress as AddressLine3,ContactNo,EmailID,TIN,STNo,CIN,Logo, BaseCurrency,CurrencyCode,TicketFooterMessage,ShowLogo  FROM Hotel"
            Mycommand1.CommandType = CommandType.Text

            myDA.SelectCommand = cmd
            myDA1.SelectCommand = Mycommand1
            myDA.Fill(myDS, "VAT1")
            myDA1.Fill(myDS, "Hotel")
            rpt.SetDataSource(myDS)

            rpt.SetParameterValue("p1", dtpDateFrom.Value.Date)
            rpt.SetParameterValue("p2", dtpDateTo.Value.Date)
            rpt.SetParameterValue("oper_enabl", chkOperatorWise.Checked)

            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
            rpt.Close()
            rpt.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        'If chkOperatorWise.Checked = True Then
        '    checkedprint()
        'Else
        '    uncheckedprint()
        'End If
        checkedprint()
    End Sub

    Public Sub GetKotAmountReport()
        Dim column_index As Integer = DgwKotAmountReport.Columns("Operator_").Index()
        If chkOperatorWise.Checked = True Then
            DgwKotAmountReport.Columns(column_index).Visible = True
        Else
            DgwKotAmountReport.Columns(column_index).Visible = False
        End If

        Dim con As New SqlConnection(connection)
        Dim reader As SqlDataReader = Nothing
        Try
            con.Open()
            Dim query As String = "exec Proc_WithKotAmount3 @d1,@d2,@operator ,@foodtime,@operatorwise"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
            cmd.Parameters.Add("@operator", SqlDbType.NVarChar, 50, "operator").Value = cmbOperator.Text()
            cmd.Parameters.Add("@foodtime ", SqlDbType.NVarChar, 50, "foodtime ").Value = cmbFoodTime.Text()
            cmd.Parameters.Add("@operatorwise", SqlDbType.Bit).Value = chkOperatorWise.Checked
            reader = cmd.ExecuteReader()
            DgwKotAmountReport.Rows.Clear()
            While reader.Read()
                Dim billDate As String = CDate(reader("BillDate")).ToString("d/MMM/yyyy")
                DgwKotAmountReport.Rows.Add(billDate, reader("Operator"), reader("DineIN"), reader("TakeAway"), reader("HomeDelivery"), reader("ThirdParty"), reader("Amount"))
            End While
            reader.Close()

            ' cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = "All"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged

    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged

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
        cmbOperator.Enabled = False
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperator.SelectedIndexChanged
        GetKotAmountReport()
        total_from_grid()
    End Sub

    Private Sub cmbFoodTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFoodTime.SelectedIndexChanged
        GetKotAmountReport()
        total_from_grid()
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

    Public Sub total_from_grid()
        Dim totalDI As Decimal = 0
        Dim totalTA As Decimal = 0
        Dim totalHD As Decimal = 0
        Dim totalTP As Decimal = 0
        Dim totaAmt As Decimal = 0
        For Each row As DataGridViewRow In DgwKotAmountReport.Rows
            ' Check if the row is not a new row and is not null
            If Not row.IsNewRow AndAlso row.Cells("DI").Value IsNot Nothing Then
                totalDI += CDec(row.Cells("DI").Value)
            End If

            If Not row.IsNewRow AndAlso row.Cells("TA").Value IsNot Nothing Then
                totalTA += CDec(row.Cells("TA").Value)
            End If

            If Not row.IsNewRow AndAlso row.Cells("HD").Value IsNot Nothing Then
                totalHD += CDec(row.Cells("HD").Value)
            End If

            If Not row.IsNewRow AndAlso row.Cells("TP").Value IsNot Nothing Then
                totalTP += CDec(row.Cells("TP").Value)
            End If
            If Not row.IsNewRow AndAlso row.Cells("Amount").Value IsNot Nothing Then
                totaAmt += CDec(row.Cells("Amount").Value)
            End If
        Next

        'clear textbox if recently exists in textbox
        txtTotalDI.Text = ""
        txtTotalTA.Text = ""
        txtTotalHD.Text = ""
        txtTotalTP.Text = ""
        txtTotalAmount.Text = ""

        'total sum each textbox
        txtTotalDI.Text = CStr(totalDI)
        txtTotalTA.Text = CStr(totalTA)
        txtTotalHD.Text = CStr(totalHD)
        txtTotalTP.Text = CStr(totalTP)
        txtTotalAmount.Text = CStr(totaAmt)
    End Sub


    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        If chkOperatorWise.Checked = True Then
            cmbOperator.Enabled = True
        Else
            cmbOperator.Enabled = False
        End If
        GetKotAmountReport()
        total_from_grid()
    End Sub

    Public Sub GetKotAmountReportWithOutOP()
        Dim con As New SqlConnection(cs)
        con.Open()
        Dim query As String = "exec Proc_WithKotAmount2 @d1,@d2,@mode"
        Dim MyCommand, MyCommand1, MyCommand2 As New SqlCommand()
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date.AddHours(_startTime)
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date.AddDays(1).AddHours(_endTime)
        cmd.Parameters.Add("@mode", SqlDbType.VarChar, 20, "FoodTime").Value = cmbFoodTime.Text
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        DgwKotAmountReport.Rows.Clear()
        While reader.Read()
            Dim billDate As String = CDate(reader("BillDate")).ToString("d/MMM/yyyy")
            DgwKotAmountReport.Rows.Add(billDate, reader("Operator"), reader("DineIN"), reader("TakeAway"), reader("HomeDelivery"), reader("ThirdParty"), reader("Amount"))
        End While
        con.Close()
    End Sub


    Private Sub chkOperatorWise_CheckedChanged(sender As Object, e As EventArgs) Handles chkOperatorWise.CheckedChanged
        If chkOperatorWise.Checked = True Then
            cmbOperator.Enabled = True
        Else
            cmbOperator.Enabled = False
        End If
        GetKotAmountReport()
        total_from_grid()
    End Sub
End Class