Imports System.Windows.Forms.Design.Behavior
Imports MySql.Data.MySqlClient
Imports QRCoder
Imports System.Drawing

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
            DR.Close()
            CMD = New MySqlCommand("SELECT * FROM pegawai WHERE Nama = '" & cbPetugas.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cbKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKendaraan.SelectedIndexChanged
        Try
            DR.Close()
            CMD = New MySqlCommand("SELECT * FROM tarifkendaraan WHERE Jenis = '" & cbKendaraan.Text & "'", conn)
            DR = CMD.ExecuteReader
            If DR.Read() Then
                txttarif.Text = DR("Tarif").ToString()
            Else
                txttarif.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function GenerateParkirID() As String
        Dim random As New Random()
        Dim numbers As String = random.Next(10, 100).ToString("D2") ' Generate 2-digit number
        Dim letters As String = New String(Enumerable.Range(0, 3).[Select](Function(x) Chr(random.Next(65, 91))).ToArray()) ' Generate 3 letters
        Return numbers & letters
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            Dim idParkir As String = GenerateParkirID()
            Dim jenis As String = cbKendaraan.Text
            Dim noKendaraan As String = txtNopol.Text
            Dim waktuMasuk As String = $"{DateTime.Now:dddd, dd MMMM yyyy HH:mm}"
            Dim petugas As String = cbPetugas.Text

            If String.IsNullOrWhiteSpace(jenis) OrElse String.IsNullOrWhiteSpace(noKendaraan) OrElse String.IsNullOrWhiteSpace(petugas) Then
                MessageBox.Show("Please fill in all fields.")
                Return
            End If

            Me.Hide()

            mainForm.ShowKarcisForm(idParkir, jenis, noKendaraan, waktuMasuk, petugas)
            GenerateQRCode(idParkir)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub GenerateQRCode(data As String)
        Try
            Using qrGenerator As New QRCodeGenerator()
                Using qrCodeData As QRCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q)
                    Using qrCode As New QRCode(qrCodeData)
                        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
                        mainForm.UpdateQRCodePanel(qrCodeImage)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
