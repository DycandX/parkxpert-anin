Imports MySql.Data.MySqlClient

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
    Private Sub CmbNoPol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnopol.SelectedIndexChanged
        Try
            koneksi()
            Dim query As String = "SELECT IDParkir, Jenis, IDPetugas, WaktuMasuk FROM kendaraan WHERE NoKendaraan = @NoKendaraan"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.AddWithValue("@NoKendaraan", cbnopol.SelectedItem.ToString())
            DR = CMD.ExecuteReader()
            If DR.Read() Then
                lblid.Text = DR("IDParkir").ToString()
                lbljenis.Text = DR("Jenis").ToString()
                lblpetugas.Text = DR("IDPetugas").ToString()
                lblmasuk.Text = DR("WaktuMasuk").ToString()
            End If
            DR.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event saat DateTimePicker ValueChanged
    Private Sub DtpKeluar_ValueChanged(sender As Object, e As EventArgs) Handles dtpKeluar.ValueChanged
        If lblmasuk.Text <> "" Then
            Dim waktuMasuk As DateTime = DateTime.Parse(lblmasuk.Text)
            Dim waktuKeluar As DateTime = dtpKeluar.Value
            Dim durasi As TimeSpan = waktuKeluar - waktuMasuk
            lbldurasi.Text = durasi.TotalHours.ToString("F2") & " Jam"

            Dim tarifPerJam As Integer
            Try
                koneksi()
                Dim query As String = "SELECT Tarif FROM tarif_kendaraan WHERE Jenis = @Jenis"
                CMD = New MySqlCommand(query, conn)
                CMD.Parameters.AddWithValue("@Jenis", lbljenis.Text)
                tarifPerJam = Convert.ToInt32(CMD.ExecuteScalar())
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

            Dim totalTarif As Decimal = durasi.TotalHours * tarifPerJam
            lbltagihan.Text = totalTarif.ToString("C")
        End If
    End Sub

    ' Event saat Button Bayar Click
    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim jumlahBayar As Decimal = Decimal.Parse(txtbayar.Text)
        Dim totalTagihan As Decimal = Decimal.Parse(lbltagihan.Text, Globalization.NumberStyles.Currency)
        Dim kembalian As Decimal = jumlahBayar - totalTagihan
        lblkembali.Text = kembalian.ToString("C")

        ' Menyimpan data pembayaran ke database
        Try
            koneksi()
            Dim query As String = "INSERT INTO pembayaran (NoKendaraan, WaktuMasuk, WaktuKeluar, Durasi, TotalTarif, JumlahBayar, Kembalian) VALUES (@NoKendaraan, @WaktuMasuk, @WaktuKeluar, @Durasi, @TotalTarif, @JumlahBayar, @Kembalian)"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.AddWithValue("@NoKendaraan", cbnopol.SelectedItem.ToString())
            CMD.Parameters.AddWithValue("@WaktuMasuk", DateTime.Parse(lblmasuk.Text))
            CMD.Parameters.AddWithValue("@WaktuKeluar", dtpKeluar.Value)
            CMD.Parameters.AddWithValue("@Durasi", lbldurasi.Text)
            CMD.Parameters.AddWithValue("@TotalTarif", Decimal.Parse(lbltagihan.Text, Globalization.NumberStyles.Currency))
            CMD.Parameters.AddWithValue("@JumlahBayar", jumlahBayar)
            CMD.Parameters.AddWithValue("@Kembalian", kembalian)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event saat Button Clear Click
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbnopol.SelectedIndex = -1
        lblid.Text = ""
        lbljenis.Text = ""
        lblpetugas.Text = ""
        lblmasuk.Text = ""
        lbldurasi.Text = ""
        lbltagihan.Text = ""
        txtbayar.Text = ""
        lblkembali.Text = ""
    End Sub

End Class
