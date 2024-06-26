﻿Imports MySql.Data.MySqlClient

Public Class frmUtama
    Private isInputFormVisible As Boolean = False
    Private isPembayaranFormVisible As Boolean = False
    Private isKeuanganFormVisible As Boolean = False
    Private isRiwayatFormVisible As Boolean = False

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
        If btnInput.Checked Then ' Tombol ditekan
            If Not isInputFormVisible Then ' Jika form input belum ditampilkan
                TampilkanFormInput() ' Tampilkan form input
                isInputFormVisible = True ' Set status form input menjadi ditampilkan
            End If
            ' Set the pembayaran button to unchecked
            btnPembayaran.Checked = False
            btnRiwayat.Checked = False
            btnKeuangan.Checked = False
        Else ' Tombol dilepas
            If isInputFormVisible Then ' Jika form input sedang ditampilkan
                TutupFormInput() ' Tutup form input
                isInputFormVisible = False ' Set status form input menjadi disembunyikan
            End If
        End If
    End Sub

    Private Sub TampilkanFormInput()
        Dim frmInput As New frmInput(Me)
        frmInput.TopLevel = False
        frmInput.FormBorderStyle = FormBorderStyle.None
        frmInput.Location = New Point(300, 100)
        Body.Controls.Clear()
        Body.Controls.Add(frmInput)
        frmInput.Show()
    End Sub

    Private Sub TutupFormInput()
        ' Hapus form input dari panel Body
        For Each ctrl As Control In Body.Controls
            If TypeOf ctrl Is frmInput Then
                Body.Controls.Remove(ctrl)
                Exit For
            End If
        Next
    End Sub

    Public Sub ShowKarcisForm(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As DateTime, petugas As String)
        Dim frmKarcis As New FormKarcis()
        frmKarcis.TopLevel = False
        frmKarcis.FormBorderStyle = FormBorderStyle.None
        frmKarcis.Location = New Point(250, 150)
        Body.Controls.Clear()
        Body.Controls.Add(frmKarcis)
        frmKarcis.Show()

        frmKarcis.TampilkanData(idParkir, jenis, noKendaraan, waktuMasuk, petugas)

        ' Add an event handler for when the Karcis form is closed
        AddHandler frmKarcis.FormClosed, AddressOf OnKarcisFormClosed
    End Sub

    Private Sub OnKarcisFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Check if the input form should be displayed again
        If isInputFormVisible Then
            TampilkanFormInput()
        End If
    End Sub

    Private Sub btnPembayaran_CheckedChanged(sender As Object, e As EventArgs) Handles btnPembayaran.CheckedChanged
        If btnPembayaran.Checked Then ' Tombol ditekan
            If Not isPembayaranFormVisible Then ' Jika form pembayaran belum ditampilkan
                TampilkanFormPembayaran() ' Tampilkan form pembayaran
                isPembayaranFormVisible = True ' Set status form pembayaran menjadi ditampilkan
            End If
            ' Set the input button to unchecked
            btnInput.Checked = False
            btnRiwayat.Checked = False
            btnKeuangan.Checked = False
        Else ' Tombol dilepas
            If isPembayaranFormVisible Then ' Jika form pembayaran sedang ditampilkan
                TutupFormPembayaran() ' Tutup form pembayaran
                isPembayaranFormVisible = False ' Set status form pembayaran menjadi disembunyikan
            End If
        End If
    End Sub

    Private Sub TampilkanFormPembayaran()
        Dim frmPembayaran As New FormPembayaran()
        frmPembayaran.TopLevel = False
        frmPembayaran.FormBorderStyle = FormBorderStyle.None
        frmPembayaran.Location = New Point(160, 80)
        Body.Controls.Clear()
        Body.Controls.Add(frmPembayaran)
        frmPembayaran.Show()
    End Sub

    Private Sub TutupFormPembayaran()
        ' Hapus form pembayaran dari panel Body
        For Each ctrl As Control In Body.Controls
            If TypeOf ctrl Is FormPembayaran Then
                Body.Controls.Remove(ctrl)
                Exit For
            End If
        Next
    End Sub

    Private Sub btnKeuangan_CheckedChanged(sender As Object, e As EventArgs) Handles btnKeuangan.CheckedChanged
        If btnKeuangan.Checked Then ' Tombol ditekan
            If Not isKeuanganFormVisible Then ' Jika form keuangan belum ditampilkan
                TampilkanFormKeuangan() ' Tampilkan form keuangan
                isKeuanganFormVisible = True ' Set status form keuangan menjadi ditampilkan
            End If
            ' Set the pembayaran button to unchecked
            btnInput.Checked = False
            btnPembayaran.Checked = False
            btnRiwayat.Checked = False
        Else ' Tombol dilepas
            If isKeuanganFormVisible Then ' Jika form keuangan sedang ditampilkan
                TutupFormKeuangan() ' Tutup form keuangan
                isKeuanganFormVisible = False ' Set status form keuangan menjadi disembunyikan
            End If
        End If
    End Sub

    Private Sub TampilkanFormKeuangan()
        Dim frmKeuangan As New FormKeuangan()
        frmKeuangan.TopLevel = False
        frmKeuangan.FormBorderStyle = FormBorderStyle.None
        frmKeuangan.Location = New Point(0, 0)

        Body.Controls.Clear()
        Body.Controls.Add(frmKeuangan)
        frmKeuangan.Show()
    End Sub

    Private Sub TutupFormKeuangan()
        ' Hapus form keuangan dari panel Body
        For Each ctrl As Control In Body.Controls
            If TypeOf ctrl Is FormKeuangan Then
                Body.Controls.Remove(ctrl)
                Exit For
            End If
        Next
    End Sub

    Private Sub btnRiwayat_CheckedChanged(sender As Object, e As EventArgs) Handles btnRiwayat.CheckedChanged
        If btnRiwayat.Checked Then ' Tombol ditekan
            If Not isRiwayatFormVisible Then ' Jika form riwayat belum ditampilkan
                TampilkanFormRiwayat() ' Tampilkan form riwayat
                isRiwayatFormVisible = True ' Set status form riwayat menjadi ditampilkan
            End If
            ' Pastikan tombol input dan pembayaran tidak tercentang
            btnInput.Checked = False
            btnPembayaran.Checked = False
            btnKeuangan.Checked = False
        Else ' Tombol dilepas
            If isRiwayatFormVisible Then ' Jika form riwayat sedang ditampilkan
                TutupFormRiwayat() ' Tutup form riwayat
                isRiwayatFormVisible = False ' Set status form riwayat menjadi disembunyikan
            End If
        End If
    End Sub

    ' Metode untuk menampilkan form riwayat di panel Body
    Private Sub TampilkanFormRiwayat()
        Dim frmRiwayat As New FormRiwayat()
        frmRiwayat.TopLevel = False
        frmRiwayat.FormBorderStyle = FormBorderStyle.None
        frmRiwayat.Location = New Point(0, 0)

        Body.Controls.Clear()
        Body.Controls.Add(frmRiwayat)
        frmRiwayat.Show()
    End Sub

    ' Metode untuk menutup form riwayat dari panel Body
    Private Sub TutupFormRiwayat()
        ' Hapus form riwayat dari panel Body
        For Each ctrl As Control In Body.Controls
            If TypeOf ctrl Is FormRiwayat Then
                Body.Controls.Remove(ctrl)
                Exit For
            End If
        Next
    End Sub

    Private WithEvents tmrAnimation As New Timer()
    Private Const Speed As Integer = 1 ' Kecepatan animasi yang lebih lambat
    Private Const TimerInterval As Integer = 10 ' Interval timer yang lebih kecil untuk pergerakan lebih halus

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAnimation.Interval = TimerInterval
        tmrAnimation.Start()
    End Sub

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        ' Ambil teks dari label
        Dim text As String = lbljalan.Text

        ' Geser teks ke kiri sesuai kecepatan
        lbljalan.Left -= Speed

        ' Jika teks keluar dari panel, kembalikan ke posisi awal di kanan panel
        If lbljalan.Right < 0 Then
            lbljalan.Left = Panel3.ClientSize.Width
        End If

        ' Memastikan responsivitas aplikasi
        Application.DoEvents()
    End Sub
End Class
