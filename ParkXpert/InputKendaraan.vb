Imports MySql.Data.MySqlClient

Public Class frmInput
    Sub ClearInput()
        cbKendaraan.SelectedIndex = -1
        txtNopol.Text = "_"
    End Sub

    Private Sub cbPetugas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPetugas.SelectedIndexChanged
        DR.Close()
        CMD = New MySqlCommand("SELECT * FROM pegawai WHERE Nama = '" & cbPetugas.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub

    Private Sub cbKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKendaraan.SelectedIndexChanged
        DR.Close()
        CMD = New MySqlCommand("SELECT * FROM tarifkendaraan WHERE Jenis = '" & cbKendaraan.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub
End Class