Imports MySql.Data.MySqlClient

Module KoneksiDB
    Public conn As MySqlConnection
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public DT As DataTable
    Sub koneksi()
        Try
            conn = New MySqlConnection("Server=localhost;user=root;password=;database=parkxpert;Convert Zero Datetime=True;old guids=true")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
