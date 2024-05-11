Imports System.Data.SqlClient

Public Class frmNotesNew
    Public NoteFlag As String
    Public noteflag1 As String
    Public _RowID As Integer = 0

    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn = New Button
        btn = sender

        DgvN.Rows.Add(btn.Name, btn.Text)
        btn.Enabled = False
    End Sub

    Private Sub loadCommonNotes()
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            flpNotesCommon.Controls.Clear()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("select ID,notes,BackColor from notesmaster where isactive=@isactive", con)
            adp.SelectCommand.Parameters.AddWithValue("@isactive", True)
            ds = New DataSet("ds")
            adp.Fill(ds)
            For i = 1 To ds.Tables(0).Rows.Count()
                Dim newBtn = New Button()
                newBtn.Size = New Size(130, 70)
                newBtn.Name = ds.Tables(0).Rows(i - 1).Item("ID").ToString()
                newBtn.Text = ds.Tables(0).Rows(i - 1).Item("notes").ToString()
                newBtn.FlatStyle = FlatStyle.Flat
                newBtn.FlatAppearance.BorderSize = 1
                newBtn.Font = New Font("ms san sherif", 9, FontStyle.Bold)
                newBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
                Dim backColorValue As Integer = CInt(ds.Tables(0).Rows(i - 1).Item("BackColor"))
                newBtn.BackColor = Color.FromArgb(backColorValue)
                newBtn.Margin = New Padding(5, 5, 5, 5)
                AddHandler newBtn.Click, AddressOf Me.BtnNotes_Click
                flpNotesCommon.Controls.Add(newBtn)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub loadDishWiseNotes()
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            flpNotesDishwise.Controls.Clear()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT ID, notes, BackColor FROM notesmaster WHERE dishid = @dishid 
            and isactive=@isactive", con)
            adp.SelectCommand.Parameters.AddWithValue("@dishid", CInt(lblDishId.Text))
            adp.SelectCommand.Parameters.AddWithValue("@isactive", True)
            ds = New DataSet("ds")
            adp.Fill(ds)
            For i = 1 To ds.Tables(0).Rows.Count()
                Dim newBtn = New Button()
                newBtn.Size = New Size(130, 70)
                newBtn.Name = ds.Tables(0).Rows(i - 1).Item("ID").ToString()
                newBtn.Text = ds.Tables(0).Rows(i - 1).Item("notes").ToString()
                newBtn.FlatStyle = FlatStyle.Flat
                newBtn.FlatAppearance.BorderSize = 1
                newBtn.Font = New Font("ms san sherif", 9, FontStyle.Bold)
                newBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
                Dim backColorValue As Integer = CInt(ds.Tables(0).Rows(i - 1).Item("BackColor"))
                newBtn.BackColor = Color.FromArgb(backColorValue)
                newBtn.Margin = New Padding(5, 5, 5, 5)
                AddHandler newBtn.Click, AddressOf Me.BtnNotes_Click
                flpNotesDishwise.Controls.Add(newBtn)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Select Case e.TabPageIndex
            Case 0 'Tab page 1 common
                loadCommonNotes()

            Case 1 'Tab page Dishwise
                loadDishWiseNotes()
                'flpLetters2.Visible = False
        End Select
    End Sub

    Private Sub frmNotesNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCommonNotes()
        '   flpletters1.Visible = False
        '   flpLetters2.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txttyping_MouseClick(sender As Object, e As MouseEventArgs) Handles txttyping.MouseClick
        flpletters1.Visible = True
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txttyping.Text = "" Then
            MsgBox("Click textbox")
        Else
            DgvN.Rows.Add(0, txttyping.Text)
            ' flpLetters2.Visible = False
            txttyping.Text = ""
        End If
    End Sub
    Private WithEvents bntClose As Button
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click

        Dim str As String = ""
        For i = 0 To DgvN.Rows.Count - 1
            str = str + DgvN.Rows(i).Cells(1).Value + ","
        Next

        If str.Length <> 0 Then
            str = str.Substring(0, str.Length - 1)
        End If

        g_otherval = str
        NoteFlag = ""
        _RowID = 0
        Me.Close()
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        bntClose_Click(sender, e)
        Dim con As New SqlConnection(connection)
        If TabControl1.SelectedTab Is common Then
            ' Code to execute when the Common tab is active

            Try
                con.Open()

                Dim query1 As String = "select Notes,dishid from NotesMaster where  Notes=@d1 and dishid=@d2"
                Dim cmd As New SqlCommand(query1, con)
                cmd.Parameters.AddWithValue("@d1", txttyping.Text)
                cmd.Parameters.AddWithValue("@d2", 0)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    MessageBox.Show("Notes already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    txttyping.Text = ""
                    txttyping.Focus()
                    Return
                Else
                    For Each row As DataGridViewRow In DgvN.Rows
                        If row.Cells("ItemCode").Value IsNot Nothing AndAlso CInt(row.Cells("ItemCode").Value) = 0 Then
                            Dim query2 As String = "Insert into NotesMaster(Notes,backcolor,dishid,isactive)values (@d1,@d2,@d3,@d4)"
                            Dim cmd2 As New SqlCommand(query2, con)
                            cmd2.Connection = con
                            cmd2.Parameters.AddWithValue("@d1", row.Cells("ItemName").Value)
                            cmd2.Parameters.AddWithValue("@d2", Color.CornflowerBlue.ToArgb())
                            cmd2.Parameters.AddWithValue("@d3", 0)
                            cmd2.Parameters.AddWithValue("@d4", True)
                            cmd2.ExecuteNonQuery()
                            ' MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Next

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try

        End If
        If TabControl1.SelectedTab Is Dishwise Then
            Try
                con.Open()
                Dim query1 As String = "select Notes,dishid from NotesMaster where  Notes=@d1"
                Dim cmd As New SqlCommand(query1, con)
                cmd.Parameters.AddWithValue("@d1", txttyping.Text)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    MessageBox.Show("Notes already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    txttyping.Text = ""
                    txttyping.Focus()
                    Return
                Else
                    For Each row As DataGridViewRow In DgvN.Rows
                        If row.Cells("ItemCode").Value IsNot Nothing AndAlso CInt(row.Cells("ItemCode").Value) = 0 Then
                            Dim query2 As String = "Insert into NotesMaster(Notes,backcolor,dishid,isactive)values (@d1,@d2,@d3,@d4)"
                            Dim cmd2 As New SqlCommand(query2, con)
                            cmd2.Connection = con
                            cmd2.Parameters.AddWithValue("@d1", row.Cells("ItemName").Value)
                            cmd2.Parameters.AddWithValue("@d2", Color.CornflowerBlue.ToArgb())
                            cmd2.Parameters.AddWithValue("@d3", CInt(lblDishId.Text))
                            cmd2.Parameters.AddWithValue("@d4", True)
                            cmd2.ExecuteNonQuery()
                            '    MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Next

                End If
            Catch ex As Exception

            Finally
                con.Close()
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub bntRemove_Click(sender As Object, e As EventArgs) Handles bntRemove.Click
        If DgvN.Rows.Count > 0 Then
            'DgvN.Rows.Remove(DgvN.CurrentRow)
            Dim removedRow = DgvN.CurrentRow
            Dim btnName = removedRow.Cells("ItemCode").Value.ToString()
            DgvN.Rows.Remove(removedRow)

            Dim btn As Button = TryCast(Controls.Find(btnName, True).FirstOrDefault(), Button)
            If btn IsNot Nothing Then
                btn.Enabled = True
            End If
        End If
        'btn.Name, btn.Text ItemCode

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click, Button12.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button10.Click, Button1.Click, Button22.Click, Button21.Click, bntBs.Click
        Dim btn As Button = CType(sender, Button)
        If btn.Text = "Backspace" Then
            If txttyping.Text.Count = 0 Then
                Exit Sub
            Else
                txttyping.Text = txttyping.Text.Substring(0, txttyping.Text.Length - 1)
            End If
        ElseIf (btn.Text = "Space") Then
            txttyping.Text = txttyping.Text + " "
        ElseIf (btn.Text = "/") Then
            txttyping.Text = txttyping.Text + "/"
        Else
            txttyping.Text = txttyping.Text + btn.Text
        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txttyping.Text = ""
    End Sub

    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        'Me.Close()
        flpletters1.Visible = False
    End Sub

    Private Sub bttnWinClose_Click(sender As Object, e As EventArgs) Handles bttnWinClose.Click
        Dim str As String = ""
        For i = 0 To DgvN.Rows.Count - 1
            str = str + DgvN.Rows(i).Cells(1).Value + ","
        Next

        If str.Length <> 0 Then
            str = str.Substring(0, str.Length - 1)
        End If


        'If iMode = "Desktop" Then
        '    If NoteFlag = "All" Then
        '        ''MainDeskPos.txtNotes.Text = MainDeskPos.txtNotes.Text + str 
        '        MainDeskPos.txtNotes.Text = MainDeskPos.txtNotes.Text + str

        '    ElseIf NoteFlag = "Item" Then
        '        MainDeskPos.DgvList.Rows(_RowID).Cells("Notes").Value = str

        '    End If
        'ElseIf iMode = "SEARCHTAB" Then
        '    If NoteFlag = "All" Then
        '        frmtabvertical.txtNotes.Text = frmtabvertical.txtNotes.Text + str
        '    ElseIf NoteFlag = "Item" Then

        '        frmtabvertical.DgvList.Rows(_RowID).Cells("Notes").Value = str
        '        'MsgBox(ft.DgvList.Rows.Count.ToString())
        '        'MsgBox(frmtabvertical.DgvList.Rows.Count.ToString())
        '        ' frmtabvertical.DgvList.Rows(0).Cells(2).Value = "test" 'str
        '    End If
        'ElseIf iMode = "TakeAway" Then
        '    If NoteFlag = "All" Then
        '        MainDeskPosTA.txtNotes.Text = MainDeskPosTA.txtNotes.Text + str
        '    ElseIf NoteFlag = "Item" Then

        '        MainDeskPosTA.DgvList.Rows(_RowID).Cells("Cl_Notes").Value = str

        '    End If


        'If NoteFlag = "All" Then
        '    frmMainPosSearch.txtNotes.Text = frmMainPosSearch.txtNotes.Text + str
        'ElseIf NoteFlag = "Item" Then

        '    frmMainPosSearch.DgvList.Rows(_RowID).Cells("Notes").Value = str
        'End If
        'End If
        g_otherval = str
        NoteFlag = ""
        _RowID = 0
        Me.Close()
    End Sub
End Class