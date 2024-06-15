Imports MySql.Data.MySqlClient

Public Class FormKeuangan
    Private Sub LoadDataGrid(Optional filter As String = "")
        Try
            ' Panggil metode koneksi dari modul KoneksiDB
            KoneksiDB.koneksi()

            ' Query untuk mengambil data dari tabel keuangan
            Dim query As String = "SELECT * FROM pembayaran"
            If filter <> "" Then
                query &= " WHERE " & filter
            End If

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
        ' Isi ComboBox dengan pilihan filter
        cbFilter.Items.Add("Hari Ini")
        cbFilter.Items.Add("Minggu Ini")
        cbFilter.Items.Add("Bulan Ini")
        cbFilter.Items.Add("Tahun Ini")
        cbFilter.SelectedIndex = 0 ' Set default value

        LoadDataGrid()
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        Dim filter As String = ""
        Dim now As DateTime = DateTime.Now

        Select Case cbFilter.SelectedItem.ToString()
            Case "Hari Ini"
                filter = $"WaktuKeluar >= '{now.ToString("yyyy-MM-dd 00:00:00")}' AND WaktuKeluar <= '{now.ToString("yyyy-MM-dd 23:59:59")}'"
            Case "Minggu Ini"
                ' Calculate the first day of the week (Monday)
                Dim firstDayOfWeek As DateTime = now.AddDays(-(now.DayOfWeek - DayOfWeek.Monday))
                If now.DayOfWeek = DayOfWeek.Sunday Then
                    firstDayOfWeek = now.AddDays(-6)
                End If
                filter = $"WaktuKeluar >= '{firstDayOfWeek.ToString("yyyy-MM-dd 00:00:00")}' AND WaktuKeluar <= '{now.ToString("yyyy-MM-dd 23:59:59")}'"
            Case "Bulan Ini"
                Dim firstDayOfMonth As New DateTime(now.Year, now.Month, 1)
                filter = $"WaktuKeluar >= '{firstDayOfMonth.ToString("yyyy-MM-dd 00:00:00")}' AND WaktuKeluar <= '{now.ToString("yyyy-MM-dd 23:59:59")}'"
            Case "Tahun Ini"
                Dim firstDayOfYear As New DateTime(now.Year, 1, 1)
                filter = $"WaktuKeluar >= '{firstDayOfYear.ToString("yyyy-MM-dd 00:00:00")}' AND WaktuKeluar <= '{now.ToString("yyyy-MM-dd 23:59:59")}'"
        End Select

        LoadDataGrid(filter)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Panggil kembali LoadDataGrid tanpa filter
        LoadDataGrid()
    End Sub
End Class
