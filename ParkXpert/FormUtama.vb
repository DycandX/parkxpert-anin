Imports MySql.Data.MySqlClient

Public Class frmUtama

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        koneksi()
        CMD = New MySqlCommand("UPDATE pegawai set Status = '" & "Offline" & "' WHERE BINARY ID = '" & profilUname.Text & "'", conn)
        CMD.ExecuteNonQuery()
        Me.Hide()
        frmLogin.ResetTextBox()
        frmLogin.Show()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnInput_CheckedChanged(sender As Object, e As EventArgs) Handles btnInput.CheckedChanged
        frmInput.Show()
    End Sub
End Class