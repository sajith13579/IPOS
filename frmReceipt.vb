Imports System.Data.SqlClient
Public Class frmReceipt
    'Dim connection_string As String = "Data Source=DEVSERVER\SQL2008Test;initial catalog=IPOS_trainee;user id=sa;password=SQL@123"
    Dim tem_val As Decimal
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
        'Dim nextTransactionNumber As String = GetNextTransactionNumber()
        'txtTransactionNo.Text = nextTransactionNumber
        Dim nextTransactionNumber As String = GetNextTransactionNumber()
        txtTransactionNo.Text = nextTransactionNumber
        binddata()
    End Sub

    Private Function GetNextTransactionNumber() As String
        Using con As New SqlConnection()
            con.Open()
            'Retrive last saved transaction number
            Dim query As String = "select top 1 LedgerNO from ledgerBookNew where Label='Receipt' order by  Id Desc"
            Using cmd As New SqlCommand(query, con)
                Dim lastTransactionNumber As Object = cmd.ExecuteScalar()
                ' Extract the numeric part and increment it
                If lastTransactionNumber IsNot Nothing AndAlso Not DBNull.Value.Equals(lastTransactionNumber) Then
                    Dim lastTransaction As String = lastTransactionNumber.ToString()
                    Dim numericPart As String = lastTransaction.Substring(lastTransaction.LastIndexOf("-") + 1)
                    Dim incrementedNumber As Integer = CInt(numericPart) + 1

                    ' Build the new transaction number
                    Return $"T-{incrementedNumber}"
                Else
                    ' No record found, set it to T-1
                    Return "T-1"
                End If

            End Using
        End Using
    End Function
    Sub Reset()
        txtCustomerAdress.Text = ""
        txtCustomContactNo.Text = ""
        txtRemarks.Text = ""
        txtAccountNo.Text = ""
        txtCustomerName.Text = ""
        txtTransactionAmount.Text = "0"
        txtdiscount.Text = ""
        txtPaymentModeDetails.Text = ""
        cmbPaymentMode.SelectedIndex = 0
        dtpTranactionDate.Value = Today
        lblBalance.Text = "0.000"
        bttnSave.Enabled = False
        bttnDelete.Enabled = False
        bttnUpdate.Enabled = False
        bttnSelection.Enabled = True
        txtTransactionNo.Text = ""

    End Sub

    Private Sub bttnSelection_Click(sender As Object, e As EventArgs) Handles bttnSelection.Click

    End Sub
    Public Sub binddata()
        DataGridView1.Rows.Clear()
        Dim conn As New SqlConnection(connection)
        Dim query As String = "SELECT LedgerNo, Date, Debit FROM ledgerBookNew   WHERE PartyID = @PartyID"
        conn.Open()
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@PartyID", txtAccountNo.Text)
        ' Use a SqlDataReader to read data row by row
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            ' Add a new row to the DataGridView and populate it with data
            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("colBillNo").Value = reader("LedgerNo")
            DataGridView1.Rows(rowIndex).Cells("colBillDate").Value = reader("Date")
            DataGridView1.Rows(rowIndex).Cells("colTotalAmount").Value = reader("Debit")
            'DataGridView1.Rows(rowIndex).Cells("colTotalPaid").Value = reader("ContactNo") 'total paid'
            'DataGridView1.Rows(rowIndex).Cells("colAdvance").Value = reader("Active")  'advanced'

            'DataGridView1.Rows(rowIndex).Cells("colBalance").Value = reader("Debit")
            'DataGridView1.Rows(rowIndex).Cells("colPay").Value = reader("RegistrationDate") pay checkbox
            'DataGridView1.Rows(rowIndex).Cells("colPaidAmount").Value = reader("RegistrationDate") paid amont 
            'DataGridView1.Rows(rowIndex).Cells("colCurrentBalance").Value = reader("RegistrationDate") current balance
            'DataGridView1.Rows(rowIndex).Cells("colDiscountAmt").Value = reader("RegistrationDate") Discount amt
            'DataGridView1.Rows(rowIndex).Cells("colDiscount").Value = reader("RegistrationDate") Discount checkbox
        End While

        conn.Close()
    End Sub




    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtCustID IsNot Nothing Then
            txtCustID.Visible = False
        End If
        cmbPaymentMode.SelectedIndex = 0
        txtTransactionAmount.Text = "0"
        txtdiscount.Text = "0"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim tran_bal_dis_bal_sum As Decimal = 0
        ' Check if the clicked cell is in the "Pay" column and it's a checkbox
        If e.ColumnIndex = DataGridView1.Columns("colPay").Index AndAlso e.RowIndex >= 0 Then
            If tran_bal_dis_bal_sum > 0 Then
                tran_bal_dis_bal_sum = 0
            End If
            'transaction amount balance
            tran_bal_dis_bal_sum = Convert.ToDecimal(txtTransactionAmount.Text)

            ' Get the current cell
            Dim cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)

            'Fetch bill number value
            grid_col_bill_num = DataGridView1.Rows(e.RowIndex).Cells("colBillNo").Value.ToString()
            Dim grid_col_total_amt As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value.ToString())

            'remaining balance
            Dim rem_bal As Decimal

            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            ' Check if the checkbox is checked
            If Convert.ToBoolean(cell.Value) Then
                If grid_col_total_amt >= tamount Then
                    rem_bal = grid_col_total_amt - tamount
                    DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = rem_bal
                    DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = tamount
                    tamount = 0
                End If

                If tamount > grid_col_total_amt Then
                    rem_bal = 0
                    DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = rem_bal
                    DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = grid_col_total_amt
                    tamount = tamount - grid_col_total_amt
                End If
                ' Checkbox is checked, subtract the value from TextBox from "TotalAmount"
            Else
                ' Checkbox is unchecked, you can handle this case if needed
                DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = String.Empty
                DataGridView1.Rows(e.RowIndex).Cells("colTotalPaid").Value = String.Empty
            End If
        End If


        ' Check if the clicked cell is in the "Discount" column and it's a checkbox
        If e.ColumnIndex = DataGridView1.Columns("colDiscount").Index AndAlso e.RowIndex >= 0 Then
            grid_col_bill_num = DataGridView1.Rows(e.RowIndex).Cells("colBillNo").Value.ToString()
            If tran_bal_dis_bal_sum > 0 Then
                tran_bal_dis_bal_sum = 0
            End If
            tran_bal_dis_bal_sum = Convert.ToDecimal(txtTransactionAmount.Text) + Convert.ToDecimal(txtdiscount.Text)
            ' Get the current cell
            Dim cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            ' Check if the checkbox is checked
            If Convert.ToBoolean(cell.Value) Then
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
                        DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value = txtdiscount.Text
                    Else
                        MessageBox.Show("Insufficient balance for payment.")
                    End If
                Else
                    MessageBox.Show("Fill the discount value.")
                    cell.Value = False
                End If
            Else
                ' Checkbox is unchecked, you can handle this case if needed
                Dim currentTotalAmount As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("colTotalAmount").Value)
                DataGridView1.Rows(e.RowIndex).Cells("colDiscountAmt").Value = String.Empty
                Dim balance As Decimal = currentTotalAmount - Convert.ToDecimal(txtTransactionAmount.Text)
                DataGridView1.Rows(e.RowIndex).Cells("colBalance").Value = balance
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click
        Dim tran_txt_box_amt = Convert.ToDecimal(txtTransactionAmount.Text)
        Dim datee As DateTime = dtpTranactionDate.Value()
        Dim pymode As String = cmbPaymentMode.Text
        Dim name As String = txtCustomerName.Text
        Dim labell As String = "Receipt"
        Dim ledgNo As Integer = Val(txtTransactionNo.Text)
        Dim Deb_or_Cr_amt As Integer = Val(txtTransactionAmount.Text)
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
                    MessageBox.Show("The amount paid is not equal to transaction amount")
                    txtTransactionAmount.Text = Convert.ToString(total_sum)
                    Exit For
                End If

                ' Check if the row is not a new row and is selected (checked)
                If Not row.IsNewRow AndAlso CBool(row.Cells("colPay").Value) AndAlso row.Cells("colTotalPaid").Value.ToString() <> "0" Then
                    Dim grid_bal As Decimal = Convert.ToDecimal(row.Cells("colBalance").Value)
                    Dim bill_no As String = Convert.ToString(row.Cells("colBillNo").Value)
                    If grid_bal = 0 Then
                        Dim query6 = "Delete from ledgerBookNew where  LedgerNO='" & bill_no & "'"
                        Executequery(query6)
                    Else
                        'Update the value after save according to LegerNo(billno) and Accledger
                        Dim query3 As String = "update ledgerBookNew set Debit='" & grid_bal & "' where AccLedger='" & "Sales A/c" & "' and LedgerNo='" & bill_no & "' "
                        Executequery(query3)
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

                        Dim query5 As String = "update ledgerBookNew set Credit='" & crd_bal & "' where AccLedger='" & "Credit Customer" & "' and LedgerNo='" & bill_no & "' "
                        Executequery(query5)

                    End If
                    'insert ledgerbooknew credit part 0
                    Dim query As String = "insert into ledgerBookNew" &
                    "(Date,Name,AccLedger, Label,LedgerNo,Debit,Credit,BranchId,LedgerGroup,FinID,Operator)" &
                    "values('" & datee & "','" & pymode & "'," &
                    " '" & name & "', '" & labell & "', '" & trans_num & "' , '" & Deb_or_Cr_amt & "' , " &
                    " '" & zer_val & "', '" & MyBranch & "', '" & "Current Asset" & "', '" & finyearId & "','" & MyUserId & "')"

                    Executequery(query)
                    Dim query2 As String = "insert into ledgerBookNew" &
                    "(Date,Name,AccLedger,Label,LedgerNo,Debit,Credit,BranchId,LedgerGroup,FinID,Operator)" &
                    "values('" & datee & "','" & name & "'," &
                     " '" & pymode & "', '" & labell & "', '" & trans_num & "' , '" & zer_val & "' , " &
                     " '" & Deb_or_Cr_amt & "', '" & MyBranch & "', '" & "Sales" & "' ,'" & finyearId & "','" & MyUserId & "')"
                    Executequery(query2)
                End If
            Next
            'payment mode id fetch from accoun
        End If
        MessageBox.Show("Completed")
        Reset()
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

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'If e.ColumnIndex = DataGridView1.Columns("Discount").Index Then
        ' Calculate the balance when the Discount column is changed

        'End If
    End Sub
End Class