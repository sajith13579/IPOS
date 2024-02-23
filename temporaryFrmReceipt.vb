﻿Imports System.Data.SqlClient

Public Class temporaryFrmReceipt
    Dim toal_dis As Decimal = 0
    Private Sub temporaryFrmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtCustID IsNot Nothing Then
            txtCustID.Visible = False
        End If

        txtTransactionAmount.Text = "0"
        toal_pend = 0
        fillPaymentMode(cmbPaymentMode)
        cmbPaymentMode.SelectedIndex = 0
    End Sub

    Private Sub bttnSelection_Click(sender As Object, e As EventArgs) Handles bttnSelection.Click

    End Sub

    Private Sub bttnSelection_MouseClick(sender As Object, e As MouseEventArgs) Handles bttnSelection.MouseClick

        frmCreditCustomerListt.lblSet.Text = "Payment"
        frmCreditCustomerListt.ShowDialog()
        txtCustID.Text = ccId
        txtAccountNo.Text = cusId
        txtCustomerName.Text = cusName
        txtCustomerAdress.Text = cusAddress
        txtCustomContactNo.Text = cusContact
        lblBalance.Text = cusBalance
        ccId = ""
        cusId = ""
        cusName = ""
        cusAddress = ""
        cusContact = ""
        cusBalance = ""
        Dim nextTransactionNumber As String = GenerateTransactionID()
        txtTransactionNo.Text = nextTransactionNumber
        binddata()

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim pend As Decimal = Convert.ToDecimal(row.Cells("colTotalAmount").Value)
            'total_pend is a public variable
            toal_pend = toal_pend + pend
        Next
        If String.IsNullOrEmpty(txtAccountNo.Text) Then
            lblPending.Text = ""
        Else
            lblPending.Text = "Total pending amount is " + Convert.ToString(toal_pend)
        End If

    End Sub


    Private Function GenerateTransactionID() As String
        Dim latestTransactionID As String = ""

        ' Query to get the latest transaction ID from the credit customer payment table
        Using con As New SqlConnection(connection)
            con.Open()
            Dim query As String = "SELECT TOP 1 T_ID FROM CreditCustomerPayment ORDER BY T_ID DESC"
            Using cmd As New SqlCommand(query, con)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    ' If there are existing transaction IDs, parse the numeric part, increment, and append
                    Dim lastID As Integer = Convert.ToInt32(result)
                    latestTransactionID = "T-" & (lastID + 1)
                Else
                    ' If there are no existing transaction IDs, default to "T-1"
                    latestTransactionID = "T-1"
                End If
            End Using
        End Using

        Return latestTransactionID
    End Function





    'Private Function GetNextTransactionNumber() As String
    '    Using con As New SqlConnection(connection)
    '        con.Open()
    '        'Retrive last saved transaction number
    '        Dim query As String = "select top 1 LedgerNO from ledgerBookNew where Label='Receipt' order by  Id Desc"
    '        Using cmd As New SqlCommand(query, con)
    '            Dim lastTransactionNumber As Object = cmd.ExecuteScalar()
    '            ' Extract the numeric part and increment it
    '            If lastTransactionNumber IsNot Nothing AndAlso Not DBNull.Value.Equals(lastTransactionNumber) Then
    '                Dim lastTransaction As String = lastTransactionNumber.ToString()
    '                Dim numericPart As String = lastTransaction.Substring(lastTransaction.LastIndexOf("-") + 1)
    '                Dim incrementedNumber As Integer = CInt(numericPart) + 1

    '                ' Build the new transaction number
    '                Return $"T-{incrementedNumber}"
    '            Else
    '                ' No record found, set it to T-1
    '                Return "T-1"
    '            End If

    '        End Using
    '    End Using
    'End Function


    Public Sub binddata()
        ' Check if txtAccountNo.Text is empty or null
        If String.IsNullOrEmpty(txtAccountNo.Text) Then
            lblPending.Text = ""
            Return
        End If
        DataGridView1.Rows.Clear()
        Dim conn As New SqlConnection(connection)
        Dim query As String = "SELECT LedgerNo, Date, Debit FROM ledgerBookNew   WHERE PartyID = @PartyID and LedgerGroup='Current Asset'"

        conn.Open()
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@PartyID", txtAccountNo.Text)
        ' Use a SqlDataReader to read data row by row
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            'Sum of deb column balance 
            Dim sum_deb As Decimal = 0
            ' Add a new row to the DataGridView and populate it with data
            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("colBillNo").Value = reader("LedgerNo")
            'billNO is a ledger no
            _billno = DataGridView1.Rows(rowIndex).Cells("colBillNo").Value.ToString()
            Dim trans_num_find As String = txtAccountNo.Text() + "-T"
            'finding sum pending balance
            Dim accountNumber As String = txtAccountNo.Text
            Dim numericPart As Integer = accountNumber.Substring(accountNumber.IndexOf("_") + 1)

            Dim queryy As String = "SELECT ab.Amount, abd.Discount " &
                       "FROM AgainstBilltb ab " &
                       "JOIN AgainstBillDiscount abd ON ab.InvoiceNo = abd.InvoiceNo " &
                       "WHERE ab.InvoiceNo ='" & _billno & "' "
            Dim cmdd As New SqlCommand(queryy, conn)
            Dim readerr As SqlDataReader = cmdd.ExecuteReader()
            While readerr.Read()
                sum_deb = sum_deb + readerr.GetDecimal(readerr.GetOrdinal("Amount"))
                sum_deb = sum_deb + readerr.GetDecimal(readerr.GetOrdinal("Discount"))
            End While
            readerr.Close()
            DataGridView1.Rows(rowIndex).Cells("colBillDate").Value = reader("Date")
            DataGridView1.Rows(rowIndex).Cells("colTotalBillAmount").Value = reader("Debit")
            'save to the variable colTotalBillAmount
            Dim colTotBillAmt As Decimal = reader("Debit")
            'substract for pending amount
            Dim pend_amt As Decimal = colTotBillAmt - sum_deb
            'it is pending amount column
            DataGridView1.Rows(rowIndex).Cells("colTotalAmount").Value = pend_amt
        End While
        conn.Close()
        txtT_ID.Text = cusId
    End Sub

    Public Sub checkbx_already()
        MessageBox.Show("already checked")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim tran_bal_dis_bal_sum As Decimal = 0
        ' Check if the clicked cell is in the "Pay" column and it's a checkbox
        If e.ColumnIndex = DataGridView1.Columns("colPay").Index AndAlso e.RowIndex >= 0 Then
            If tran_bal_dis_bal_sum > 0 Then
                tran_bal_dis_bal_sum = 0
            End If
            'transaction amount balance
            Try
                tran_bal_dis_bal_sum = Convert.ToDecimal(txtTransactionAmount.Text)
            Catch ex As Exception
                txtTransactionAmount.Text = 0
                tran_bal_dis_bal_sum = Convert.ToDecimal(txtTransactionAmount.Text)
            End Try


            ' Get the current cell
            Dim cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)

            'Fetch bill number value
            grid_col_bill_num = DataGridView1.Rows(e.RowIndex).Cells("colBillNo").Value.ToString()
            Dim grid_col_total_amt As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value.ToString())

            'remaining balance
            Dim rem_bal As Decimal

            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            'this variable main purpose already checked pay column and retrive total paid value t_paid






            ' Check if the pay checkbox is checked
            If Convert.ToBoolean(cell.Value) Then
                'DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").ReadOnly = False

                If Convert.ToDecimal(txtTransactionAmount.Text) = 0 Then
                    MessageBox.Show("Transation amount is zero check again")
                    txtTransactionAmount.Focus()
                End If
                'paid_colm variable is total paid grid column
                Dim paid_colm As Object = DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value
                Dim pend_amt As Object = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value.ToString())
                'paid_colm is variable of total paid..it it is not null or empty handle this block
                If paid_colm IsNot Nothing AndAlso Not String.IsNullOrEmpty(paid_colm.ToString()) AndAlso IsNumeric(paid_colm) Then
                    ' Convert the value to Decimal
                    Dim paidAmount As Decimal = Convert.ToDecimal(paid_colm)
                    'grid_col_total_amt variable is a pending balance column
                    If grid_col_total_amt >= paid_colm Then
                        rem_bal = grid_col_total_amt - paidAmount
                        DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = rem_bal
                        'DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = tamount
                        tamount = tamount - paidAmount
                        lblCusRemBal.Text = "Customer remaining amount is " + Convert.ToString(tamount)
                    End If

                Else
                    ' Your code here to handle if the value is null, empty, or not numeric
                    'above code handle direct tick without give paid amount
                    If tamount <= pend_amt Then
                        rem_bal = pend_amt - tamount
                        DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = rem_bal
                        DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = tamount
                        tamount = 0
                        lblCusRemBal.Text = "Customer remaining amount is " + Convert.ToString(tamount)
                    Else

                        DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = 0
                        DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = pend_amt
                        tamount = tamount - pend_amt
                        lblCusRemBal.Text = "Customer remaining amount is " + Convert.ToString(tamount)
                    End If
                End If




                'If tamount > grid_col_total_amt Then
                '    rem_bal = 0
                '    DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = rem_bal
                '    DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = grid_col_total_amt
                '    tamount = tamount - grid_col_total_amt
                'End If
                ' Checkbox is checked, subtract the value from TextBox from "TotalAmount"
            Else
                ' Checkbox is unchecked, you can handle this case if needed
                Dim paid_colm As Object
                paid_colm = DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value
                paid_colm = Convert.ToDecimal(paid_colm)
                tamount = tamount + paid_colm
                lblCusRemBal.Text = "Customer remaining amount is " + Convert.ToString(tamount)
                DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = String.Empty
                DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = String.Empty
                DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value = String.Empty
                DataGridView1.Rows(e.RowIndex).Cells("colDiscount").Value = False
            End If
        End If


        ' Check if the clicked cell is in the "Discount" column and it's a checkbox
        If e.ColumnIndex = DataGridView1.Columns("colDiscount").Index AndAlso e.RowIndex >= 0 Then
            grid_col_bill_num = DataGridView1.Rows(e.RowIndex).Cells("colBillNo").Value.ToString()
            Dim grid_col_dis_amt As Decimal
            Try
                'if the discount column is no value it will carry error
                grid_col_dis_amt = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value().ToString())
            Catch ex As Exception
                grid_col_dis_amt = 0
            End Try

            If tran_bal_dis_bal_sum > 0 Then
                tran_bal_dis_bal_sum = 0
            End If
            Dim grid_col_tot_amt As Decimal
            'colTotalAmount is a total pending amount value
            grid_col_tot_amt = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value().ToString())
            grid_col_balance = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value().ToString())
            Dim grid_col_tot_paid As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value().ToString())

            If grid_col_tot_amt > grid_col_balance Then
                tran_bal_dis_bal_sum = grid_col_tot_paid + grid_col_dis_amt

            ElseIf grid_col_tot_paid = 0 Then
                tran_bal_dis_bal_sum = 0
            Else
                tran_bal_dis_bal_sum = grid_col_dis_amt + 0
            End If


            ' Get the current cell
            Dim cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            ' Check if the Discount checkbox is checked
            If Convert.ToBoolean(cell.Value) Then
                'DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").ReadOnly = False
                DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value = grid_col_dis_amt
                ' Checkbox is checked, subtract the value from TextBox from "TotalAmount"
                Dim total_di_bal As Decimal
                If Decimal.TryParse(tran_bal_dis_bal_sum, total_di_bal) Then
                    ' Get the current "TotalAmount" value in the DataGridView
                    Dim currentTotalAmount As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value)
                    ' Subtract the value and Discount 
                    If currentTotalAmount >= total_di_bal Then
                        'total_di_bal is a discount textbox and transation textbox sum
                        Dim totla_Balance_sub As Decimal = currentTotalAmount - total_di_bal
                        'total balnce fetch to grid
                        DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = totla_Balance_sub
                        tamount = tamount - grid_col_dis_amt
                        lblCusRemBal.Text = "Customer remaining amount is " + Convert.ToString(tamount)
                    Else
                        MessageBox.Show("Insufficient balance for payment.")
                    End If
                Else
                    MessageBox.Show("It is not decimal value")
                    cell.Value = False
                End If
            Else
                ' Checkbox is unchecked, you can handle this case if needed
                Dim Dis_colm As Decimal
                Dis_colm = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value.ToString())
                tamount = tamount + Dis_colm
                Dim currentTotalAmount As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value)
                DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value = String.Empty
                Dim balance As Decimal = currentTotalAmount - grid_col_tot_paid
                DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = balance
                lblCusRemBal.Text = "Customer remaining amount is" + Convert.ToString(tamount)
            End If
        End If
    End Sub
    Sub Reset()
        txtCustomerAdress.Text = ""
        txtCustomContactNo.Text = ""
        txtRemarks.Text = ""
        txtAccountNo.Text = ""
        txtCustomerName.Text = ""
        txtTransactionAmount.Text = "0"
        txtPaymentModeDetails.Text = ""
        cmbPaymentMode.SelectedIndex = 0
        dtpTranactionDate.Value = Today
        lblBalance.Text = "0.000"
        bttnSave.Enabled = False
        'bttnDelete.Enabled = False
        'bttnUpdate.Enabled = False
        bttnSelection.Enabled = True
        txtTransactionNo.Text = ""
        lblCusRemBal.Text = ""
        lblPending.Text = ""
        DataGridView1.Rows.Clear()
        tamount = 0
    End Sub
    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click

        For Each row As DataGridViewRow In DataGridView1.Rows
            Try
                Dim dic As Decimal = Convert.ToDecimal(row.Cells("colDiscountAmt").Value)
                toal_dis = toal_dis + dic
                'if dic value get empty it will handling that error
            Catch ex As Exception
                toal_dis = 0
            End Try
        Next

        Dim tran_txt_box_amt = Convert.ToDecimal(txtTransactionAmount.Text)
        Dim datee As DateTime = dtpTranactionDate.Value()
        Dim pymode As String = cmbPaymentMode.Text
        Dim name As String = txtCustomerName.Text
        Dim labell As String = "Receipt"
        Dim ledgNo As Integer = Val(txtTransactionNo.Text) + toal_dis
        Dim Deb_or_Cr_amt As Decimal = 0
        Dim crd_amt As Integer = Val(txtTransactionAmount.Text)
        Dim zer_val As Integer = 0
        Dim party_ID As String = txtAccountNo.Text
        Dim trans_num As String = txtAccountNo.Text + "-" + txtTransactionNo.Text
        'MyBranch
        'finyearId
        'MyUserId

        If String.IsNullOrEmpty(txtAccountNo.Text) OrElse
           String.IsNullOrEmpty(txtCustomerName.Text) OrElse
           String.IsNullOrEmpty(txtTransactionAmount.Text) OrElse
           String.IsNullOrEmpty(dtpTranactionDate.Value) OrElse
           String.IsNullOrEmpty(txtTransactionAmount.Text) OrElse
           String.IsNullOrEmpty(cmbPaymentMode.Text) OrElse
           String.IsNullOrEmpty(txtTransactionNo.Text) Then
            MessageBox.Show("Fields are empty select a person")
        Else

            tran_id_get = txtAccountNo.Text + "-" + txtTransactionNo.Text
            'insert value into creditcustomerPayment


            'Find total amount sum receipt datagridviewtable
            Dim total_sum As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim total_amount As Decimal = Convert.ToDecimal(row.Cells("colTotalAmount").Value)
                total_sum = total_sum + total_amount
            Next

            'payment save according bill number
            Dim tem_tran_amt = Convert.ToDecimal(txtTransactionAmount.Text)
            For Each row As DataGridViewRow In DataGridView1.Rows
                If tran_txt_box_amt > total_sum Then
                    MessageBox.Show("The amount paid is not equal to transaction amount the customer gave amount is " + Convert.ToString(tran_txt_box_amt))
                    'txtTransactionAmount.Text = Convert.ToString(total_sum)
                    Exit For
                End If

                ' Check if the row is not a new row and is selected (checked)
                If Not row.IsNewRow AndAlso CBool(row.Cells("colPay").Value) AndAlso row.Cells("colTotalPaid").Value.ToString() <> "0" Then
                    Dim grid_bal As Decimal = Convert.ToDecimal(row.Cells("colBalance").Value)
                    Dim bill_no As String = Convert.ToString(row.Cells("colBillNo").Value)
                    'addition to total paid and discount amount for inserting data
                    Dim grid_paid_amt As Decimal = Convert.ToDecimal(row.Cells("colTotalPaid").Value)

                    Try
                        grid_dic_amt = Convert.ToDecimal(row.Cells("colDiscountAmt").Value.ToString())
                    Catch ex As Exception
                        grid_dic_amt = 0
                    End Try

                    Deb_or_Cr_amt = grid_paid_amt + grid_dic_amt
                    If grid_bal = 0 Then
                        Dim query6 = "Delete from ledgerBookNew where  LedgerNO='" & bill_no & "'"
                        Executequery(query6)
                    Else
                        'Update the value after save according to LegerNo(billno) and Accledger
                        'Dim query3 As String = "update ledgerBookNew set Debit='" & grid_bal & "' where AccLedger='" & "Sales A/c" & "' and LedgerNo='" & bill_no & "' "
                        'Executequery(query3)

                        'Get output vat amount and fetch into the variable and it will increament same debit column
                        Dim query4 As String = "select * from ledgerBookNew where Name='" & "OUTPUT VAT" & "' and LedgerNo='" & bill_no & "'"
                        Dim con As New SqlConnection(connection)
                        Dim cmd As New SqlCommand(query4, con)
                        con.Open()
                        Dim reader As SqlDataReader = cmd.ExecuteReader()

                        'fetch output vat value from name field and  bill number
                        Dim op_vt_val As Double = Nothing
                        While reader.Read()
                            op_vt_val = reader.GetDecimal(reader.GetOrdinal("Credit"))
                        End While
                        con.Close()
                        Dim crd_bal As Double = grid_bal - op_vt_val

                        'Dim query5 As String = "update ledgerBookNew set Credit='" & crd_bal & "' where AccLedger='" & "Credit Customer" & "' and LedgerNo='" & bill_no & "' "
                        'Executequery(query5)

                    End If


                    'retrive value from vouchertype table
                    con = New SqlConnection(connection)
                    con.Open()
                    Dim str4 As String = "select id from vouchertypes where VoucherType='Receipt'"
                    cmd = New SqlCommand(str4, con)
                    'cmd.Parameters.AddWithValue("@d1", txtSupplierName.Text)
                    Dim VoucherTypeID As Object = cmd.ExecuteScalar()
                    con.Close()

                    'retrive value from accountmaster table
                    con = New SqlConnection(connection)
                    con.Open()
                    Dim str3 As String = "select id from accountmaster where name = @d1"
                    cmd = New SqlCommand(str3, con)
                    cmd.Parameters.AddWithValue("@d1", txtCustomerName.Text)
                    Dim AccountId As Object = cmd.ExecuteScalar()
                    con.Close()

                    'insert value into creditcustomerpayment
                    Dim query_cr_pay As String = "insert into CreditCustomerPayment(TransactionID,
                                Date,PaymentMode, CreditCustomer_ID, Amount,Remarks,
                                PaymentModeDetails,Discount,PaymentModeId) 
                                VALUES (@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)"
                    Execute_cr_pay(query_cr_pay)

                    'insert value into AgainstBillTB
                    con = New SqlConnection(connection)
                    con.Open()
                    Dim str6 As String = "Insert into AgainstBillTb(VoucherTypeId,AccountId,AccountName,Amount,BillId,VoucherDate,IsDelete,InvoiceNo,TransactionId,vouchertype) 
                            VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)"
                    cmd = New SqlCommand(str6)
                    cmd.Parameters.AddWithValue("@d1", VoucherTypeID) 'Vouchertypeid
                    cmd.Parameters.AddWithValue("@d2", AccountId) 'Accountid
                    'cmd.Parameters.AddWithValue("@d2", 5)
                    cmd.Parameters.AddWithValue("@d3", txtCustomerName.Text) 'AccountName
                    cmd.Parameters.AddWithValue("@d4", grid_paid_amt) 'Amount
                    cmd.Parameters.AddWithValue("@d5", billId)
                    cmd.Parameters.AddWithValue("@d6", dtpTranactionDate.Value.Date) 'Voucher date
                    cmd.Parameters.AddWithValue("@d7", False)  'isdelete
                    cmd.Parameters.AddWithValue("@d8", bill_no) 'invoice number
                    cmd.Parameters.AddWithValue("@d9", tran_id_get) 'Transaction id
                    cmd.Parameters.AddWithValue("@d10", "Credit Customer") 'Transaction id
                    cmd.CommandText = str6
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'if the discout checkbox is checked insert value into AgainstDiscount
                    If CBool(row.Cells("colDiscount").Value) AndAlso grid_dic_amt > 0 Then
                        con = New SqlConnection(connection)
                        con.Open()
                        Dim str5 As String = "Insert into AgainstBillDiscount(VoucherTypeId,AccountId,AccountName,Discount,BillId,VoucherDate,IsDelete,InvoiceNo,TransactionId,vouchertype) 
                            VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)"
                        cmd = New SqlCommand(str5)
                        cmd.Parameters.AddWithValue("@d1", VoucherTypeID)
                        cmd.Parameters.AddWithValue("@d2", AccountId)
                        'cmd.Parameters.AddWithValue("@d2", 5)
                        cmd.Parameters.AddWithValue("@d3", txtCustomerName.Text)
                        cmd.Parameters.AddWithValue("@d4", grid_dic_amt)
                        cmd.Parameters.AddWithValue("@d5", billId)
                        cmd.Parameters.AddWithValue("@d6", dtpTranactionDate.Value.Date)
                        cmd.Parameters.AddWithValue("@d7", False)
                        cmd.Parameters.AddWithValue("@d8", bill_no)
                        cmd.Parameters.AddWithValue("@d9", tran_id_get)
                        cmd.Parameters.AddWithValue("@d10", "Credit Customer")
                        cmd.CommandText = str5
                        cmd.Connection = con
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End If
                    con = New SqlConnection(connection)
                    con.Open()
                    Dim ct2 As String = "select ID from AccountMaster where Name=@d1"
                    cmd = New SqlCommand(ct2)
                    cmd.Parameters.AddWithValue("@d1", cmbPaymentMode.Text)
                    cmd.Connection = con
                    Dim PaymentModeAccountId As Integer = cmd.ExecuteScalar()
                    con.Close()
                    'insert ledgerbooknew credit part 0
                    LedgerBookCreateNew(datee, pymode, name, "Receipt", tran_id_get, Deb_or_Cr_amt, 0, "", myBranchId, "CurrentAssets", PaymentModeAccountId, 5)
                    LedgerBookCreateNew(datee, name, pymode, "Receipt", tran_id_get, 0, Deb_or_Cr_amt, txtAccountNo.Text, myBranchId, "SUNDRY DEBTORS", AccountId, 19)

                    If CBool(row.Cells("colDiscount").Value) AndAlso grid_dic_amt > 0 Then
                        LedgerBookCreateNew(datee, "ReceiptDiscount", name, "Receipt", tran_id_get, grid_dic_amt, 0, "", myBranchId, "Indirect Expense Account", 0, 11)
                        LedgerBookCreateNew(datee, "ReceiptDiscount", cmbPaymentMode.Text, "Receipt", tran_id_get, 0, grid_dic_amt, AccountId, myBranchId, "OtherRevenue", 41, 40)
                    End If
                End If
            Next
            'payment mode id fetch from accoun
        End If
        Reset()
        LogFunc(Mode1Class.lbluser1, "Added the new Receipt having
                            Transaction No " & txtTransactionNo.Text & " ")
        MessageBox.Show("Completed")
    End Sub

    'credit customer payment save into the database
    Public Sub Execute_cr_pay(ByVal query As String)
        Dim con As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, con)
        'cmd.Parameters.AddWithValue("@d1", Val(txtT_ID.Text))
        cmd.Parameters.AddWithValue("@d2", tran_id_get)
        cmd.Parameters.AddWithValue("@d3", dtpTranactionDate.Value.Date)
        cmd.Parameters.AddWithValue("@d4", cmbPaymentMode.Text)
        cmd.Parameters.AddWithValue("@d5", Val(txtCustID.Text))
        cmd.Parameters.AddWithValue("@d6", Val(txtTransactionAmount.Text))
        cmd.Parameters.AddWithValue("@d7", txtRemarks.Text)
        cmd.Parameters.AddWithValue("@d8", txtPaymentModeDetails.Text)
        cmd.Parameters.AddWithValue("@d9", grid_dic_amt)
        cmd.Parameters.AddWithValue("@d10", If(cmbPaymentMode.SelectedValue IsNot Nothing, cmbPaymentMode.SelectedValue, DBNull.Value))

        'cmd.Parameters.AddWithValue("@d11", finyearId)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Sub Executequery(ByVal query As String)
        Dim con As New SqlConnection(connection)
        Dim cmd As New SqlCommand(query, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub txtTransactionAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTransactionAmount.TextChanged
        ' Check if the text is a valid decimal
        If Decimal.TryParse(txtTransactionAmount.Text, Nothing) Then
            ' Enable the save button if the value is greater than zero
            bttnSave.Enabled = Decimal.Parse(txtTransactionAmount.Text) > 0
        Else
            ' Disable the save button for non-numeric or invalid input
            bttnSave.Enabled = False
        End If
        Try
            tamount = Convert.ToDecimal(txtTransactionAmount.Text)
        Catch ex As Exception
            tamount = 0
        End Try
        If tamount > toal_pend Then
            MessageBox.Show("The amount is not paid  equal to total pending amount.. Total pending amount is " + Convert.ToString(toal_pend))
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'Dim t_paid As Decimal
        'Try
        '    t_paid = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value.ToString)

        'Catch ex As Exception
        '    t_paid = 0
        'End Try
        '' Get the current cell
        'Dim cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
        ''if pay checkbox already checked how to handle that one
        'If Convert.ToBoolean(cell.Value) AndAlso Not String.IsNullOrEmpty(t_paid) Then
        '    checkbx_already()
        '    If t_paid > Convert.ToDecimal(txtTransactionAmount.Text) Then
        '        MessageBox.Show("it is greater than transaction value")
        '    End If
        'End If

    End Sub

    Private Sub txtTransactionAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransactionAmount.KeyPress
        ' Check if the pressed key is a digit or a control character (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or a control character, ignore it
            e.Handled = True
        End If
    End Sub

    Private Sub bttnNew_Click(sender As Object, e As EventArgs) Handles bttnNew.Click
        Reset()
    End Sub

    Private Sub DataGridView1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellMouseEnter

    End Sub

    Sub GetCustomerInfo()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "SELECT CreditCustomerID,Name,Address,ContactNo from CreditCustomer where CC_ID=@d1"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@d1", Val(txtCustID.Text))
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (rdr.Read() = True) Then
                txtAccountNo.Text = rdr.GetValue(0)
                txtCustomerName.Text = rdr.GetValue(1)
                txtCustomerAdress.Text = rdr.GetValue(2)
                txtCustomContactNo.Text = rdr.GetValue(3)
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnGetData_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGetData.MouseClick
        Me.Reset()
        frmCreditCustomerReceiptRecord.lblSet.Text = "Payment"
        frmCreditCustomerReceiptRecord.Reset()
        frmCreditCustomerReceiptRecord.ShowDialog()
        txtT_ID.Text = tId
        txtTransactionNo.Text = tnNo
        dtpTranactionDate.Text = tndate
        cmbPaymentMode.Text = paymode
        txtCustID.Text = ccId
        txtAccountNo.Text = cusId
        txtCustomerName.Text = cusName
        txtTransactionAmount.Text = tnamt
        txtTempAmt.Text = tempamt
        txtPaymentModeDetails.Text = paymodedetails
        txtRemarks.Text = remarks
        'txt.Text = CustDiscount
        bttnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        GetCustomerInfo()
        bttnSelection.Enabled = False
        'GetCustomerBalance()
        tId = ""
        tnNo = ""
        tndate = ""
        paymode = ""
        ccId = ""
        cusId = ""
        cusName = ""
        tnamt = ""
        tempamt = ""
        paymodedetails = ""
        remarks = ""
        cusBalance = ""
        CustDiscount = ""
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim accountNumber As String = txtAccountNo.Text
        Dim numericPart As String = accountNumber.Substring(accountNumber.IndexOf("_") + 1)
        MessageBox.Show(numericPart)
    End Sub
End Class

