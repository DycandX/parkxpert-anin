﻿Imports QRCoder
Imports System.Drawing.Imaging
Imports System.Security.Cryptography
Public Class FormKarcis
    Public Property MainFormPanel As Panel

    Public Sub TampilkanData(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As String, petugas As String)
        lblid.Text = $"{idParkir}"
        lbljenis.Text = $"{jenis}"
        lblnopol.Text = $"{noKendaraan}"
        lblwaktu.Text = $"{waktuMasuk}"
        lblpetugas.Text = $"{petugas}"

        Dim qrContent As String = $"{idParkir}|{jenis}|{noKendaraan}|{waktuMasuk}|{petugas}"
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
            SaveFormAsImage(sfd.FileName)
            MessageBox.Show("Karcis has been saved and printed successfully.", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


End Class