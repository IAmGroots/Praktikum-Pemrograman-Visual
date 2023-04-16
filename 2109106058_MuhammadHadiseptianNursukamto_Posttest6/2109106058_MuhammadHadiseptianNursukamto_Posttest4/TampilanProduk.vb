Imports MySql.Data.MySqlClient

Public Class TampilanProduk
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        CMD = New MySqlCommand("Select * From produk Where kode='" & KodeProduk.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim harga As Integer = RD.GetString(3)
        Dim jumlah As Integer = 1
        Dim total As Integer = jumlah * harga
        RD.Close()
        Dim tambah = "Insert Into transaksi (idTransaksi, idPengguna, idProduk, jumlah, total, status) Values (NULL,'" & UID & "', '" & KodeProduk.Text & "', '" & jumlah & "', '" & total & "', 'dipesan')"

        CMD = New MySqlCommand(tambah, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Produk berhasil ditambahkan ke keranjang belanja", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub
End Class