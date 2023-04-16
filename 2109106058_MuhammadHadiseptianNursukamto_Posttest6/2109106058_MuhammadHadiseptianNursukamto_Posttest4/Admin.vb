Imports MySql.Data.MySqlClient

Public Class Admin
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim form = New Tambah
        tampilkanPanel(form)
    End Sub

    Private Sub btnTambah_MouseEnter(sender As Object, e As EventArgs) Handles btnTambah.MouseEnter
        btnTambah.BackColor = Color.Green
    End Sub

    Private Sub btnTambah_MouseLeave(sender As Object, e As EventArgs) Handles btnTambah.MouseLeave
        btnTambah.BackColor = Color.ForestGreen
    End Sub

    Private Sub txtCari_Leave(sender As Object, e As EventArgs) Handles txtCari.Leave
        If txtCari.Text = "" Then
            txtCari.ForeColor = Color.Gray
            txtCari.Text = " Cari di Tokopaedi"
        End If
    End Sub

    Private Sub txtCari_Enter(sender As Object, e As EventArgs) Handles txtCari.Enter
        txtCari.ForeColor = Color.Black
        txtCari.Text = ""
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim form = New HasilCari
            tampilkanPanel(form)
            txtCari.ForeColor = Color.Gray
            txtCari.Text = " Cari di Tokopaedi"
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim form = New HasilCari
        tampilkanPanel(form)
        txtCari.ForeColor = Color.Gray
        txtCari.Text = " Cari di Tokopaedi"
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub

    Private Sub btnKeluar_MouseEnter(sender As Object, e As EventArgs) Handles btnKeluar.MouseEnter
        btnKeluar.ForeColor = Color.White
        btnKeluar.BackColor = Color.Tomato
    End Sub

    Private Sub btnKeluar_MouseLeave(sender As Object, e As EventArgs) Handles btnKeluar.MouseLeave
        btnKeluar.ForeColor = Color.Black
        btnKeluar.BackColor = Color.Transparent
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        txtCari.ForeColor = Color.Gray
        txtCari.Text = " Cari di Tokopaedi"
        pctProfile.ImageLocation = PATH_GAMBAR & "profile.png"

        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub
End Class