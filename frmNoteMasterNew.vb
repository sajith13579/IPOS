Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class frmNoteMasterNew
    Public Sub check_chekbox()
        If ChkActive.Checked = True Then
            chkitem = True
        Else
            chkitem = False
        End If
    End Sub
    Dim chkitem As Boolean
    Dim __note As String
    Private __dishid As Integer
    Private __id As Integer
    Private ColorDialog1 As New ColorDialog
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Dim result As DialogResult = ColorDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Me.btnBackUIColor.BackColor = ColorDialog1.Color

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetDishCombo()
        Dim query As String = "select DishName , DishId from Dish"
        Using con As New SqlConnection(connection)
            adpt = New SqlDataAdapter()
            adpt.SelectCommand = New SqlCommand(query, con)
            ds = New DataSet("ds")
            adpt.Fill(ds)
            Dim dtable = ds.Tables(0)
            cmbDishName.DisplayMember = "DishName"
            cmbDishName.ValueMember = "DishId"
            cmbDishName.DataSource = dtable
        End Using
    End Sub

    Public Sub GetData()
        DgvNotes.Rows.Clear()
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            Dim query As String = "select nt.ID,RTRIM(nt.Notes) as Notes ,ISNULL(ds.DishID,0) as DishID , ISNULL(ds.dishname, 'common') AS dishname ,nt.isactive, nt.backcolor as bg
                from NotesMaster as nt left join Dish as ds on nt.dishid=ds.DishId
            "
            Dim cmd As New SqlCommand(query, con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                DgvNotes.Rows.Add(reader("ID"), reader("Notes"), reader("DishID"), reader("dishname"), reader("isactive"), reader("bg"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub frmNoteMasterNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDishCombo()
        GetData()
        bttnUpdate.Enabled = False
        bttnDelete.Enabled = False

    End Sub

    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click
        check_chekbox()
        If txtNotes.Text.Trim.Length = 0 Then
            MessageBox.Show("Please Enter Notes", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNotes.Focus()
            Exit Sub
        End If
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            Dim str As String = "select Notes,dishid from NotesMaster where  Notes=@d1 and dishid=@d2"
            Dim cmd As New SqlCommand(str, con)
            cmd.Parameters.AddWithValue("@d1", txtNotes.Text)
            cmd.Parameters.AddWithValue("@d2", If(chkDish.Checked, cmbDishName.SelectedValue, 0))
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                MessageBox.Show("Notes already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtNotes.Text = ""
                txtNotes.Focus()
                Return
            End If
            Dim str1 As String = "Insert into NotesMaster(Notes,backcolor,dishid,isactive)values (@d1,@d2,@d3,@d4)"
            cmd = New SqlCommand(str1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtNotes.Text)
            cmd.Parameters.AddWithValue("@d2", btnBackUIColor.BackColor.ToArgb())
            cmd.Parameters.AddWithValue("@d3", If(chkDish.Checked, cmbDishName.SelectedValue, 0))
            cmd.Parameters.AddWithValue("@d4", chkitem)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bttnSave.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        GetData()
        Reset()
    End Sub
    Sub Reset()
        txtNotes.Text = ""
        txtNotes.Focus()
        bttnSave.Enabled = True
        bttnUpdate.Enabled = False
        bttnDelete.Enabled = False
        cmbDishName.SelectedIndex = 0
        btnBackUIColor.BackColor = Color.CornflowerBlue

    End Sub
    Private Sub bttnNew_Click(sender As Object, e As EventArgs) Handles bttnNew.Click
        Reset()
    End Sub

    Private Sub DgvNotes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNotes.CellDoubleClick
        bttnSave.Enabled = False
        bttnUpdate.Enabled = True
        bttnDelete.Enabled = True
        If DgvNotes.Rows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DgvNotes.SelectedRows(0)
            Dim id As Integer = CInt(selectedRow.Cells("ID").Value)
            __id = id
            txtNotes.Text = CStr(selectedRow.Cells("Note").Value)
            __note = CStr(selectedRow.Cells("Note").Value)
            Dim dishid As Integer = CInt(selectedRow.Cells("DishID").Value)
            __dishid = dishid
            cmbDishName.SelectedValue = dishid

            ChkActive.Checked = CBool(selectedRow.Cells("IsActive").Value)
            btnBackUIColor.BackColor = Color.FromArgb(CInt(selectedRow.Cells("backcolor").Value))

        End If
    End Sub

    Private Sub DgvNotes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNotes.CellContentClick

    End Sub

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click
        Dim con As New SqlConnection(connection)
        'chkitem variable define threw this function
        check_chekbox()
        If txtNotes.Text.Trim.Length = 0 Then
            MessageBox.Show("Please Enter Notes", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNotes.Focus()
            Exit Sub
        End If
        Try
            con.Open()
            If __note = txtNotes.Text Then

            Else
                Dim str As String = "select Notes,dishid from NotesMaster where  Notes=@d1 and dishid=@d2"
                Dim cmd As New SqlCommand(str, con)
                cmd.Parameters.AddWithValue("@d1", txtNotes.Text)
                cmd.Parameters.AddWithValue("@d2", If(chkDish.Checked, cmbDishName.SelectedValue, 0))
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    MessageBox.Show("Notes already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    txtNotes.Text = ""
                    txtNotes.Focus()
                    Return
                End If
            End If


            Dim query As String = "update NotesMaster set  Notes=@d2,BackColor=@d3,dishid=@d4,isactive=@d5 where ID=@d6"
            Dim cmdd As New SqlCommand(query, con)
            cmdd.Parameters.AddWithValue("@d2", txtNotes.Text)
            cmdd.Parameters.AddWithValue("@d3", btnBackUIColor.BackColor.ToArgb())
            cmdd.Parameters.AddWithValue("@d4", If(chkDish.Checked, cmbDishName.SelectedValue, 0))
            cmdd.Parameters.AddWithValue("@d5", chkitem)
            cmdd.Parameters.AddWithValue("@d6", __id)
            cmdd.ExecuteNonQuery()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bttnUpdate.Enabled = False
            bttnDelete.Enabled = False
            GetData()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Public Sub deleterecord()
        Dim con As New SqlConnection(connection)
        Try
            con.Open()
            Dim query As String = "delete from NotesMaster where ID=@d1"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@d1", __id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetData()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub bttnDelete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        If MessageBox.Show("Do you really want this record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            deleterecord()
        End If


    End Sub



    Private Sub chkCommon_CheckedChanged(sender As Object, e As EventArgs) Handles chkDish.CheckedChanged
        If chkDish.Checked Then
            cmbDishName.Enabled = True
        Else
            cmbDishName.Enabled = False
        End If
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Dispose()
    End Sub
End Class