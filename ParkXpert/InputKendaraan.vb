<<<<<<< HEAD
﻿Imports MySql.Data.MySqlClient

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
=======
﻿Imports System.Windows.Forms.Design.Behavior
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
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            DR.Close()
            CMD = New MySqlCommand("SELECT * FROM pegawai WHERE Nama = @Nama", conn)
            CMD.Parameters.AddWithValue("@Nama", cbPetugas.Text)
            DR = CMD.ExecuteReader()
            DR.Read()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            DR.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub cbKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKendaraan.SelectedIndexChanged
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            DR.Close()
            CMD = New MySqlCommand("SELECT * FROM tarifkendaraan WHERE Jenis = @Jenis", conn)
            CMD.Parameters.AddWithValue("@Jenis", cbKendaraan.Text)
            DR = CMD.ExecuteReader()
            If DR.Read() Then
                txttarif.Text = DR("Tarif").ToString()
            Else
                txttarif.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            DR.Close()
            conn.Close()
        End Try
    End Sub

    Private Function GenerateParkirID() As String
        Dim random As New Random()
        Dim numbers As String = random.Next(10, 100).ToString("D2")
        Dim letters As String = New String(Enumerable.Range(0, 3).[Select](Function(x) Chr(random.Next(65, 91))).ToArray()) ' Generate 3 letters
        Return numbers & letters
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim idParkir As String = GenerateParkirID()
        Dim jenis As String = cbKendaraan.Text
        Dim noKendaraan As String = txtNopol.Text
        Dim waktuMasuk As String = $"{DateTime.Now:dddd, dd MMMM yyyy HH:mm:ss}"
        Dim petugas As String = cbPetugas.Text

        mainForm.ShowKarcisForm(idParkir, jenis, noKendaraan, waktuMasuk, petugas)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub
End Class
>>>>>>> checkpoint3
