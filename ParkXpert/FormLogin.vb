Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim Str As String
    Dim Hitung As Decimal

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If cbshowpwd.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cbshowpwd_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpwd.CheckedChanged
        If cbshowpwd.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        koneksi()
        If txtuname.Text = "" Or txtuname.Text = "" Then
            MessageBox.Show(Me, "Username Atau Password Tidak Boleh Kosong!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If txtuname.Text = "" Then
                txtuname.Focus()
            Else
                txtuname.Focus()
            End If
        Else
            Try
                CMD = New MySqlCommand("SELECT * FROM pegawai WHERE BINARY ID = '" & txtuname.Text & "' AND BINARY Password = '" & txtPassword.Text & "'", conn)
                DR = CMD.ExecuteReader()
                DR.Read()
                If DR.HasRows Then
                    frmUtama.profilUname.Text = DR.Item("ID")
                    frmUtama.profilNama.Text = DR.Item("Nama")
                    frmUtama.profilAkses.Text = DR.Item("Akses")
                    'frmKendaraan.inputPetugas.Text = DR.Item("Nama")
                    koneksi()
                    CMD = New MySqlCommand("UPDATE pegawai set Status = '" & "Online" & "' WHERE BINARY ID = '" & txtuname.Text & "'", conn)
                    CMD.ExecuteNonQuery()
                    frmUtama.Show()
                    Me.Hide()
                Else
                    MessageBox.Show(Me, "Username Atau Password Salah, Harap Coba Lagi", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub frmParking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Str = "Selamat Datang!"
        Hitung = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text.Length = Str.Length Then
            Timer1.Stop()
            Exit Sub
        End If


        Label1.Text = Str.Substring(0, Hitung)
        Hitung += 1
    End Sub

    Public Sub ResetTextBox()
        txtuname.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
