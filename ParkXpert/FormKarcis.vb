Imports QRCoder
Imports System.Drawing

Public Class FormKarcis
    Public Property MainFormPanel As Panel

    Public Sub TampilkanData(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As String, petugas As String)
        lblid.Text = idParkir
        lbljenis.Text = jenis
        lblnopol.Text = noKendaraan
        lblwaktu.Text = waktuMasuk
        lblpetugas.Text = petugas

        GenerateQRCode(idParkir)
    End Sub

    Private Sub GenerateQRCode(data As String)
        Try
            Using qrGenerator As New QRCodeGenerator()
                Using qrCodeData As QRCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q)
                    Using qrCode As New QRCode(qrCodeData)
                        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
                        pbQRCode.Image = qrCodeImage
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "JPG Image|*.jpg"
            sfd.Title = "Save Karcis as JPG"
            sfd.FileName = "Karcis_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".jpg"

            If sfd.ShowDialog() = DialogResult.OK Then
                SaveFormAsImage(sfd.FileName)
                MessageBox.Show("Karcis has been saved and printed successfully.", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveFormAsImage(filePath As String)
        Try
            ' Capture the form as a bitmap
            Dim bmp As New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

            ' Create QR code bitmap
            Dim qrCodeBitmap As Bitmap = pbQRCode.Image

            ' Graphics to merge the QR code image into the ticket image
            Using g As Graphics = Graphics.FromImage(bmp)
                ' Adjust position and size of the QR code image
                Dim qrCodeWidth As Integer = qrCodeBitmap.Width
                Dim qrCodeHeight As Integer = qrCodeBitmap.Height
                Dim qrCodeX As Integer = 120 ' Adjust horizontal position of QR code image
                Dim qrCodeY As Integer = 120 ' Adjust vertical position of QR code image

                ' Draw the QR code image onto the ticket image
                g.DrawImage(qrCodeBitmap, qrCodeX, qrCodeY, qrCodeWidth, qrCodeHeight)
            End Using

            ' Save the bitmap as a JPG file
            bmp.Save(filePath, Imaging.ImageFormat.Jpeg)

            ' Optionally, send the image to the printer
            PrintImage(filePath)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PrintImage(filePath As String)
        Try
            ' This method sends the image to the printer
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                               Dim img As Image = Image.FromFile(filePath)
                                               e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height)
                                               e.HasMorePages = False
                                           End Sub
            printDoc.Print()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
