Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormPembayaran

    ' Method untuk mengisi ComboBox dengan data nomor kendaraan dari tabel kendaraan
    Private Sub LoadComboBox()
        Try
            koneksi()
            Dim query As String = "SELECT NoKendaraan FROM kendaraan"
            CMD = New MySqlCommand(query, conn)
            DR = CMD.ExecuteReader()
            While DR.Read()
                cbnopol.Items.Add(DR("NoKendaraan").ToString())
            End While
            DR.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event saat Form Load
    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()
    End Sub

    ' Event saat ComboBox SelectedIndexChanged
    Private Sub cbnopol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnopol.SelectedIndexChanged
        ' Periksa jika tidak ada item yang dipilih
        If cbnopol.SelectedIndex = -1 Then
            Return
        End If

        Try
            koneksi()
            Dim query As String = "SELECT IDParkir, Jenis, NamaPetugas, WaktuMasuk FROM kendaraan WHERE NoKendaraan = @NoKendaraan"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.AddWithValue("@NoKendaraan", cbnopol.SelectedItem.ToString())
            DR = CMD.ExecuteReader()
            If DR.Read() Then
                lblid.Text = DR("IDParkir").ToString()
                lbljenis.Text = DR("Jenis").ToString()
                lblpetugas.Text = DR("NamaPetugas").ToString()
                lblmasuk.Text = DR("WaktuMasuk").ToString()

                ' Hitung durasi jika waktu masuk sudah ada dan waktu keluar sudah dipilih
                If lblmasuk.Text <> "" AndAlso dtpKeluar.Value <> Nothing Then
                    HitungDurasiDanTagihan()
                End If
            End If
            DR.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dtpKeluar_ValueChanged(sender As Object, e As EventArgs) Handles dtpKeluar.ValueChanged
        If lblmasuk.Text <> "" Then
            ' Hitung durasi dan tagihan ketika nilai waktu keluar berubah
            HitungDurasiDanTagihan()
        End If
    End Sub

    Private Sub HitungDurasiDanTagihan()
        Dim waktuMasuk As DateTime = DateTime.Parse(lblmasuk.Text)
        Dim waktuKeluar As DateTime = dtpKeluar.Value
        Dim durasi As TimeSpan = waktuKeluar - waktuMasuk

        lbldurasi.Text = durasi.TotalHours.ToString("F2") & " Jam"

        Dim tarifPerJam As Decimal
        Try
            koneksi()
            Dim query As String = "SELECT Tarif FROM tarifkendaraan WHERE Jenis = @Jenis"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.AddWithValue("@Jenis", lbljenis.Text)
            tarifPerJam = Convert.ToDecimal(CMD.ExecuteScalar())

            ' Jika durasi kurang dari satu jam, tetap gunakan tarif per jam tanpa mengalikan dengan durasi
            Dim totalTarif As Decimal
            If durasi.TotalHours < 1 Then
                totalTarif = tarifPerJam
            Else
                totalTarif = durasi.TotalHours * tarifPerJam
            End If

            ' Bulatkan ke ribuan terdekat
            Dim totalTarifBulanan As Decimal = Math.Ceiling(totalTarif / 1000) * 1000

            lbltagihan.Text = "Rp" & totalTarifBulanan.ToString("N0", Globalization.CultureInfo.CreateSpecificCulture("id-ID")) & ",00"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    ' Event saat Button Bayar Click
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        ' Validasi input
        Dim jumlahBayar As Decimal
        If Not Decimal.TryParse(txtbayar.Text, jumlahBayar) Then
            MessageBox.Show("Masukkan jumlah bayar yang valid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim totalTagihan As Decimal = Decimal.Parse(lbltagihan.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CreateSpecificCulture("id-ID"))

        If jumlahBayar < totalTagihan Then
            MessageBox.Show("Jumlah uang yang dibayarkan kurang.", "Error Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kembalian As Decimal = jumlahBayar - totalTagihan
        lblkembali.Text = "Rp" & kembalian.ToString("N2", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))

        ' Menyimpan data pembayaran ke database
        Try
            koneksi()
            Dim query As String = "INSERT INTO pembayaran (NoKendaraan, WaktuMasuk, WaktuKeluar, Durasi, TotalTarif, JumlahBayar, Kembalian) VALUES (@NoKendaraan, @WaktuMasuk, @WaktuKeluar, @Durasi, @TotalTarif, @JumlahBayar, @Kembalian)"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.AddWithValue("@NoKendaraan", cbnopol.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@WaktuMasuk", DateTime.Parse(lblmasuk.Text))
            CMD.Parameters.AddWithValue("@WaktuKeluar", dtpKeluar.Value)
            CMD.Parameters.AddWithValue("@Durasi", lbldurasi.Text)
            CMD.Parameters.AddWithValue("@TotalTarif", totalTagihan)
            CMD.Parameters.AddWithValue("@JumlahBayar", jumlahBayar)
            CMD.Parameters.AddWithValue("@Kembalian", kembalian)
            CMD.ExecuteNonQuery()

            ' Masukkan data ke tabel riwayatkendaraan
            Dim queryRiwayat As String = "INSERT INTO riwayatkendaraan (IDParkir, NoKendaraan, Jenis, WaktuMasuk, WaktuKeluar, NamaPetugas) VALUES (@IDParkir, @NoKendaraan, @Jenis, @WaktuMasuk, @WaktuKeluar, @NamaPetugas)"
            CMD = New MySqlCommand(queryRiwayat, conn)
            CMD.Parameters.AddWithValue("@IDParkir", lblid.Text)
            CMD.Parameters.AddWithValue("@NoKendaraan", cbnopol.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@Jenis", lbljenis.Text)
            CMD.Parameters.AddWithValue("@WaktuMasuk", DateTime.Parse(lblmasuk.Text))
            CMD.Parameters.AddWithValue("@WaktuKeluar", dtpKeluar.Value)
            CMD.Parameters.AddWithValue("@NamaPetugas", lblpetugas.Text)
            CMD.ExecuteNonQuery()

            ' Hapus data dari tabel kendaraan
            Dim queryDelete As String = "DELETE FROM kendaraan WHERE NoKendaraan = @NoKendaraan"
            CMD = New MySqlCommand(queryDelete, conn)
            CMD.Parameters.AddWithValue("@NoKendaraan", cbnopol.SelectedItem.ToString())
            CMD.ExecuteNonQuery()

            ' Set nilai label-label baru
            lbljenis1.Text = lbljenis.Text
            lblnopol.Text = cbnopol.SelectedItem.ToString()
            lblmasuk1.Text = lblmasuk.Text
            lblkeluar1.Text = dtpKeluar.Value.ToString()
            lbldurasi1.Text = lbldurasi.Text
            lblpetugas1.Text = lblpetugas.Text
            lbltagihan1.Text = lbltagihan.Text
            lblbayar.Text = "Rp" & jumlahBayar.ToString("N2", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))
            lblkembali.Text = "Rp" & kembalian.ToString("N2", Globalization.CultureInfo.CreateSpecificCulture("id-ID"))

            ' Tampilkan pesan sukses
            MessageBox.Show("Pembayaran berhasil dilakukan.", "Pembayaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event saat Button Clear Click
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbnopol.SelectedIndex = -1
        lblid.Text = "-"
        lbljenis.Text = "-"
        lblpetugas.Text = "-"
        lblmasuk.Text = "-"
        lbldurasi.Text = "-"
        lbltagihan.Text = "-"
        txtbayar.Text = ""
        lblkembali.Text = "-"

        lblbayar.Text = "-"
        lblkeluar1.Text = "-"
        lbljenis1.Text = "Jenis"
        lblpetugas1.Text = "-"
        lblmasuk1.Text = "-"
        lbldurasi1.Text = "-"
        lbltagihan1.Text = "-"
        lblnopol.Text = "No Kendaraan"
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        PrintDocument1.Print()
    End Sub

    Private Function GetPanelImage(panel As Panel, Optional dpi As Integer = 300) As Bitmap
        Dim bmp As New Bitmap(panel.Width, panel.Height)
        bmp.SetResolution(dpi, dpi)
        panel.DrawToBitmap(bmp, New Rectangle(0, 0, panel.Width, panel.Height))
        Return bmp
    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As Bitmap = GetPanelImage(PanelStruk)
        Dim newWidth As Integer = bmp.Width * 3.2
        Dim newHeight As Integer = bmp.Height * 3.2
        Dim resizedBmp As New Bitmap(bmp, newWidth, newHeight)
        e.Graphics.DrawImage(resizedBmp, 0, 0, newWidth, newHeight)
    End Sub

End Class
