<<<<<<< HEAD
﻿Public Class FormRiwayat
    
End Class
=======
﻿Imports MySql.Data.MySqlClient

Public Class FormRiwayat

    Private Sub FormRiwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub LoadDataGrid(Optional filter As String = "")
        Try
            KoneksiDB.koneksi() ' Panggil metode koneksi dari modul KoneksiDB

            Dim query As String = "SELECT IDParkir, NoKendaraan, Jenis, WaktuMasuk, WaktuKeluar, NamaPetugas FROM riwayatkendaraan"
            If filter <> "" Then
                query &= " WHERE " & filter
            End If

            Dim adapter As New MySqlDataAdapter(query, KoneksiDB.conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table ' Set DataGridView data source

            ' Set DataGridView properties
            DataGridView1.Dock = DockStyle.Fill
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Set alignment for all columns to center
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnFilterMasuk_Click(sender As Object, e As EventArgs) Handles btnFilterMasuk.Click
        ' Ambil tanggal dari DateTimePicker
        Dim filterDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        ' Buat filter berdasarkan tanggal WaktuMasuk
        Dim filter As String = $"DATE(WaktuMasuk) = '{filterDate}'"

        ' Muat ulang DataGridView dengan filter yang diberikan
        LoadDataGrid(filter)
    End Sub

    Private Sub btnFilterKeluar_Click(sender As Object, e As EventArgs) Handles btnFilterKeluar.Click
        ' Ambil tanggal dari DateTimePicker
        Dim filterDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        ' Buat filter berdasarkan tanggal WaktuKeluar
        Dim filter As String = $"DATE(WaktuKeluar) = '{filterDate}'"

        ' Muat ulang DataGridView dengan filter yang diberikan
        LoadDataGrid(filter)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Muat ulang DataGridView tanpa filter
        LoadDataGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Ambil teks dari TextBox pencarian (txtSearch)
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Atur warna default kembali ke Transparent untuk semua baris
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.DefaultCellStyle.BackColor = Color.Transparent
        Next

        ' Lakukan pencarian di DataGridView
        Dim found As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("NoKendaraan").Value IsNot Nothing AndAlso row.Cells("NoKendaraan").Value.ToString().Equals(searchTerm, StringComparison.OrdinalIgnoreCase) Then
                ' Jika ditemukan, atur warna latar belakang baris menjadi kuning
                row.DefaultCellStyle.BackColor = Color.Yellow
                DataGridView1.CurrentCell = row.Cells(0) ' Atur sel yang sedang aktif
                found = True
                Exit For
            End If
        Next

        ' Jika tidak ditemukan, tampilkan pesan kesalahan
        If Not found Then
            MessageBox.Show($"Nomor kendaraan '{searchTerm}' tidak ditemukan.")
        End If
    End Sub
End Class
>>>>>>> checkpoint3
