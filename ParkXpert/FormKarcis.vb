Imports QRCoder
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

Public Class FormKarcis
    Public Property MainFormPanel As Panel

    Public Sub TampilkanData(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As DateTime, petugas As String)
        lblid.Text = $"{idParkir}"
        lbljenis.Text = $"{jenis}"
        lblnopol.Text = $"{noKendaraan}"
        lblwaktu.Text = waktuMasuk.ToString("yyyy-MM-dd HH:mm:ss")
        lblpetugas.Text = $"{petugas}"

        Dim qrContent As String = $"{idParkir}|{jenis}|{noKendaraan}|{waktuMasuk:yyyy-MM-dd HH:mm:ss}|{petugas}"
        Dim qrCodeImage As Bitmap = GenerateQRCode(qrContent)
        pbQRCode.Image = qrCodeImage
        pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Function GenerateQRCode(content As String) As Bitmap
        Using qrGenerator As New QRCodeGenerator()
            Using qrCodeData As QRCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q)
                Using qrCode As New QRCode(qrCodeData)
                    Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
                    Return qrCodeImage
                End Using
            End Using
        End Using
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "JPG Image|*.jpg"
        sfd.Title = "Save Karcis as JPG"
        sfd.FileName = "Karcis_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".jpg"

        If sfd.ShowDialog() = DialogResult.OK Then
            ' Sembunyikan tombol cetak sebelum membuat cetakan gambar
            btnPrint.Visible = False

            SaveFormAsImage(sfd.FileName)
            MessageBox.Show("Karcis has been saved and printed successfully.", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tampilkan kembali tombol cetak setelah proses pencetakan selesai
            btnPrint.Visible = True

            ' Insert data into the database
            Dim idParkir As String = lblid.Text
            Dim noKendaraan As String = lblnopol.Text
            Dim jenis As String = lbljenis.Text
            Dim waktuMasuk As DateTime = DateTime.Parse(lblwaktu.Text) ' Ensure the correct format is used
            Dim namaPetugas As String = lblpetugas.Text

            InsertDataToDatabase(idParkir, noKendaraan, jenis, waktuMasuk, namaPetugas)

            Me.Close()
        End If
    End Sub

    Private Sub SaveFormAsImage(filePath As String)
        ' Capture the form as a bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        ' Save the bitmap as a JPG file
        bmp.Save(filePath, ImageFormat.Jpeg)

        ' Optionally, send the image to the printer
        PrintImage(filePath)
    End Sub

    Private Sub PrintImage(filePath As String)
        ' Create a PrintDocument object
        Dim printDoc As New Printing.PrintDocument()

        ' Create a PrintDialog object
        Dim printDialog As New PrintDialog()

        ' Set the Document property of the PrintDialog to the PrintDocument
        printDialog.Document = printDoc

        ' Show the PrintDialog and check if the user clicks OK
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' If the user clicked OK, proceed with printing

            ' Assign the selected printer to the PrintDocument
            printDoc.PrinterSettings = printDialog.PrinterSettings

            ' Define the PrintPage event handler
            AddHandler printDoc.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                               Dim img As Image = Image.FromFile(filePath)
                                               e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height)
                                               e.HasMorePages = False
                                           End Sub

            ' Start printing
            printDoc.Print()
        End If
    End Sub

    Private Sub InsertDataToDatabase(idParkir As String, noKendaraan As String, jenis As String, waktuMasuk As DateTime, namaPetugas As String)
        Try
            KoneksiDB.koneksi()
            Dim query As String = "INSERT INTO kendaraan (IDParkir, NoKendaraan, Jenis, WaktuMasuk, NamaPetugas) VALUES (@IDParkir, @NoKendaraan, @Jenis, @WaktuMasuk, @NamaPetugas)"
            Using command As New MySqlCommand(query, KoneksiDB.conn)
                command.Parameters.AddWithValue("@IDParkir", idParkir)
                command.Parameters.AddWithValue("@NoKendaraan", noKendaraan)
                command.Parameters.AddWithValue("@Jenis", jenis)
                command.Parameters.AddWithValue("@WaktuMasuk", waktuMasuk.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@NamaPetugas", namaPetugas)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error inserting data into database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If KoneksiDB.conn IsNot Nothing AndAlso KoneksiDB.conn.State = ConnectionState.Open Then
                KoneksiDB.conn.Close()
            End If
        End Try
    End Sub

End Class
