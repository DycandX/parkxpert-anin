Imports MySql.Data.MySqlClient

Public Class frmUtama
    Private isInputFormVisible As Boolean = False
    Private isPembayaranFormVisible As Boolean = False

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
End Class
