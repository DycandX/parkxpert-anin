Imports MySql.Data.MySqlClient

Public Class frmUtama

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        koneksi()
        CMD = New MySqlCommand("UPDATE pegawai set Status = 'Offline' WHERE BINARY ID = '" & profilUname.Text & "'", conn)
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
        TampilkanFormInput()
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

    Public Sub ShowKarcisForm(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As String, petugas As String)
        Try
            Dim frmKarcis As New FormKarcis()

            ' Set data on frmKarcis
            frmKarcis.lblid.Text = idParkir
            frmKarcis.lbljenis.Text = jenis
            frmKarcis.lblnopol.Text = noKendaraan
            frmKarcis.lblwaktu.Text = waktuMasuk
            frmKarcis.lblpetugas.Text = petugas

            ' Tampilkan form sebagai dialog modal
            frmKarcis.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateQRCodePanel(qrCodeImage As Bitmap)
        Try
            Dim qrPanel As Panel = Me.Controls.OfType(Of Panel)().FirstOrDefault(Function(p) p.Name = "panelQRCode")

            If qrPanel IsNot Nothing Then
                qrPanel.BackgroundImage = qrCodeImage
                qrPanel.BackgroundImageLayout = ImageLayout.Zoom
            Else
                MessageBox.Show("QR Code panel not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TampilkanFormPembayaran()
        Dim frmPembayaran As New FormPembayaran()
        frmPembayaran.TopLevel = False
        frmPembayaran.FormBorderStyle = FormBorderStyle.None
        frmPembayaran.Location = New Point(300, 100)
        Body.Controls.Clear()
        Body.Controls.Add(frmPembayaran)
        frmPembayaran.Show()
    End Sub
End Class
