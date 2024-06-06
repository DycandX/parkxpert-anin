Imports System.Drawing.Imaging
Public Class FormKarcis
    Public Property MainFormPanel As Panel

    Public Sub TampilkanData(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As String, petugas As String)
        lblid.Text = $"{idParkir}"
        lbljenis.Text = $"{jenis}"
        lblnopol.Text = $"{noKendaraan}"
        lblwaktu.Text = $"{waktuMasuk}"
        lblpetugas.Text = $"{petugas}"
    End Sub

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
        ' This method sends the image to the printer
        Dim printDoc As New Printing.PrintDocument()
        AddHandler printDoc.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                           Dim img As Image = Image.FromFile(filePath)
                                           e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height)
                                           e.HasMorePages = False
                                       End Sub
        printDoc.Print()
    End Sub
End Class