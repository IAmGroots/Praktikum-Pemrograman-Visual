Public Class Pembeli
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub

    Private Sub Pembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        txtCari.ForeColor = Color.Gray
        txtCari.Text = " Cari di Tokopaedi"
        pctProfile.ImageLocation = PATH_GAMBAR & "profile.png"

        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub

    Private Sub btnKeranjang_Click(sender As Object, e As EventArgs) Handles btnKeranjang.Click
        Dim form = New Keranjang
        tampilkanPanel(form)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnKeluar_MouseEnter(sender As Object, e As EventArgs) Handles btnKeluar.MouseEnter
        btnKeluar.BackColor = Color.Tomato
    End Sub

    Private Sub btnKeluar_MouseLeave(sender As Object, e As EventArgs) Handles btnKeluar.MouseLeave
        btnKeluar.BackColor = Color.Transparent
    End Sub

    Private Sub btnKeranjang_MouseEnter(sender As Object, e As EventArgs) Handles btnKeranjang.MouseEnter
        btnKeranjang.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub btnKeranjang_MouseLeave(sender As Object, e As EventArgs) Handles btnKeranjang.MouseLeave
        btnKeranjang.BackColor = Color.Transparent
    End Sub
End Class