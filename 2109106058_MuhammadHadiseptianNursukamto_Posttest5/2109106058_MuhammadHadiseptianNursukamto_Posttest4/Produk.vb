Imports MySql.Data.MySqlClient

Public Class Produk
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        Main.panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        DA = New MySqlDataAdapter("Select * From produk", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "produk")

        Dim dt As DataTable = DS.Tables("produk")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            If array(i, 0) = KodeProduk.Text Then
                Dim form = New Ubah
                form.txtKode.Text = array(i, 0)
                form.txtNamaProduk.Text = array(i, 1)
                form.txtStokProduk.Text = array(i, 2)
                form.txtHargaProduk.Text = array(i, 3)
                form.pctGambarProduk.ImageLocation = PATH_GAMBAR & array(i, 4)
                tampilkanPanel(Form)
            End If
        Next
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim hapus As String
        hapus = MessageBox.Show("Anda Yakin Hapus Produk?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hapus = MsgBoxResult.Yes Then
            Dim kode As String = KodeProduk.Text
            'kode nama stok harga gambar
            Dim query As String = "Delete From produk Where kode='" & kode & "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Produk Berhasil Dihapus", MsgBoxStyle.Information, "Pemberitahuan")

        Else
            Exit Sub
        End If

        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub


    Private Sub NamaProduk_MouseEnter(sender As Object, e As EventArgs) Handles NamaProduk.MouseEnter
        NamaProduk.BackColor = Color.LightCyan
    End Sub

    Private Sub NamaProduk_MouseLeave(sender As Object, e As EventArgs) Handles NamaProduk.MouseLeave
        NamaProduk.BackColor = Color.Transparent
    End Sub

    Private Sub HargaProduk_MouseEnter(sender As Object, e As EventArgs) Handles HargaProduk.MouseEnter
        HargaProduk.BackColor = Color.LightCyan
    End Sub

    Private Sub HargaProduk_MouseLeave(sender As Object, e As EventArgs) Handles HargaProduk.MouseLeave
        HargaProduk.BackColor = Color.Transparent
    End Sub
End Class