Imports System.Windows.Forms.Design.Behavior
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class frmInput
    Private mainForm As frmUtama

    Public Sub New(formUtama As frmUtama)
        InitializeComponent()
        mainForm = formUtama
    End Sub

    Private Sub frmInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttarif.Enabled = False
    End Sub

    Sub ClearInput()
        cbPetugas.SelectedIndex = -1
        cbKendaraan.SelectedIndex = -1
        txtNopol.Text = ""
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
        If DR.Read() Then
            txttarif.Text = DR("Tarif").ToString()
        Else
            txttarif.Text = ""
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        mainForm.ShowKarcisForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class