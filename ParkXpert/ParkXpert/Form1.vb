Imports System.ComponentModel

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Mengatur ulang nilai-nilai kontrol ke nilai awalnya
        ComboBox1.SelectedIndex = -1 ' Menghapus pilihan pada ComboBox1
        TextBox1.Text = "" ' Mengosongkan TextBox1
        DateTimePicker1.Value = DateTime.Now ' Mengatur ulang DateTimePicker1 ke waktu saat ini
        ' Anda bisa menambahkan kode tambahan di sini sesuai dengan kebutuhan

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Code yang ingin Anda jalankan ketika Button1 diklik
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
