Imports MySql.Data.MySqlClient
Public Class FormKeuangan
    Private Sub LoadDataGrid()
        Try
            ' Panggil metode koneksi dari modul KoneksiDB
            KoneksiDB.koneksi()

            ' Query untuk mengambil data dari tabel keuangan
            Dim query As String = "SELECT * FROM pembayaran"
            Dim adapter As New MySqlDataAdapter(query, KoneksiDB.conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Set DataGridView data source
            DataGridView1.DataSource = table

            ' Set DataGridView to fill the form
            DataGridView1.Dock = DockStyle.Fill

            ' Set DataGridView to adjust columns width automatically
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Loop through each column and set text alignment to center
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FormKeuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub
End Class