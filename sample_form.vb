Imports System.Data.SqlClient

Public Class sample_form
    Dim connection_string As String = "Data Source=DEVSERVER\SQL2008Test;initial catalog=IPOS_trainee;user id=sa;password=SQL@123"
    Private Sub sample_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "select * from ledgerBookNew"
        Executescalerr(query)
    End Sub
    Public Sub Executescalerr(ByVal query As String)
        Using conn As New SqlConnection(connection_string)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Dim em_id As Integer = cmd.ExecuteScalar()
                MessageBox.Show(em_id)
            End Using
        End Using
    End Sub
End Class