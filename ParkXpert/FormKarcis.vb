Public Class FormKarcis
    Public Property MainFormPanel As Panel

    Public Sub TampilkanData(idParkir As String, jenis As String, noKendaraan As String, waktuMasuk As String, petugas As String)
        lblid.Text = $"{idParkir}"
        lbljenis.Text = $"{jenis}"
        lblnopol.Text = $"{noKendaraan}"
        lblwaktu.Text = $"{waktuMasuk}"
        lblpetugas.Text = $"{petugas}"
    End Sub

End Class