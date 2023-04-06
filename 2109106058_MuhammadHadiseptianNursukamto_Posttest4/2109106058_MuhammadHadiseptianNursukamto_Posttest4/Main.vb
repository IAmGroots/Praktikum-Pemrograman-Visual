Public Class Main
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        btnLihat.BackColor = Color.LightSalmon
        btnTambah.BackColor = Color.LightBlue
        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        btnTambah.BackColor = Color.Moccasin
        btnLihat.BackColor = Color.LightBlue
        Dim form = New Tambah
        tampilkanPanel(form)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form = New Lihat
        btnLihat.PerformClick()
        tampilkanPanel(form)
        koneksi()
    End Sub
End Class
