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

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim excelApp As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try
            ' Check if DataGridView has data
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data untuk diimpor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Membuat aplikasi Excel
            excelApp = New Microsoft.Office.Interop.Excel.Application()
            excelApp.Visible = True

            ' Membuat workbook baru
            workbook = excelApp.Workbooks.Add(Type.Missing)
            worksheet = workbook.ActiveSheet
            worksheet.Name = "Laporan Keuangan"

            ' Menulis header kolom
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                worksheet.Cells(1, j + 1) = DataGridView1.Columns(j).HeaderText
                DirectCast(worksheet.Cells(1, j + 1), Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            Next

            ' Menulis data dari DataGridView
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    If DataGridView1.Rows(i).Cells(j).Value IsNot Nothing Then
                        worksheet.Cells(i + 2, j + 1) = DataGridView1.Rows(i).Cells(j).Value.ToString()
                        DirectCast(worksheet.Cells(i + 2, j + 1), Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                    End If
                Next
            Next

            ' Simpan workbook ke file Excel
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.FilterIndex = 1

            If saveDialog.ShowDialog() = DialogResult.OK Then
                workbook.SaveAs(saveDialog.FileName)
                MessageBox.Show("Berhasil Mengimpor Data Ke Excel.", "Export Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Membersihkan objek Excel
            If workbook IsNot Nothing Then
                workbook.Close(SaveChanges:=False)
                ReleaseObject(workbook)
            End If
            If excelApp IsNot Nothing Then
                excelApp.Quit()
                ReleaseObject(excelApp)
            End If
            ReleaseObject(worksheet)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
