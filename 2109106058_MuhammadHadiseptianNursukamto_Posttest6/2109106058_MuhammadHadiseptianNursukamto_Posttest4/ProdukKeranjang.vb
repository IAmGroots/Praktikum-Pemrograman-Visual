Imports MySql.Data.MySqlClient

Public Class ProdukKeranjang
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        Pembeli.panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub

    Private Sub ProdukKeranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        btnMinus.Enabled = True
        Dim jml As Integer = JumlahProduk.Text + 1
        Dim kode As String = KodeTransaksi.Text

        CMD = New MySqlCommand("Select * From transaksi Where idTransaksi='" & KodeTransaksi.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim kodeProduk As String = RD.GetString(2)
        RD.Close()

        CMD = New MySqlCommand("Select * From produk Where kode='" & kodeProduk & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim harga As Integer = RD.GetString(3)
        RD.Close()

        Dim total As Integer = jml * harga
        Dim ubah As String = "Update transaksi Set jumlah='" & jml & "', total='" & total & "' Where idTransaksi='" & kode & "'"
        CMD = New MySqlCommand(ubah, CONN)
        CMD.ExecuteNonQuery()

        JumlahProduk.Text = jml
        Dim form = New Keranjang
        tampilkanPanel(form)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If JumlahProduk.Text - 1 > 0 Then
            Dim jml As Integer = JumlahProduk.Text - 1
            Dim kode As String = KodeTransaksi.Text

            CMD = New MySqlCommand("Select * From transaksi Where idTransaksi='" & KodeTransaksi.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            Dim kodeProduk As String = RD.GetString(2)
            RD.Close()

            CMD = New MySqlCommand("Select * From produk Where kode='" & kodeProduk & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            Dim harga As Integer = RD.GetString(3)
            RD.Close()

            Dim total As Integer = jml * harga
            Dim ubah As String = "Update transaksi Set jumlah='" & jml & "', total='" & total & "' Where idTransaksi='" & kode & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()

            JumlahProduk.Text = jml
            Dim form = New Keranjang
            tampilkanPanel(form)
            Return
        End If
        btnMinus.Enabled = False
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim hapus As String
        hapus = MessageBox.Show("Anda Yakin Hapus Produk?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hapus = MsgBoxResult.Yes Then
            Dim kode As String = KodeTransaksi.Text
            'kode nama stok harga gambar
            Dim query As String = "Delete From transaksi Where idTransaksi='" & kode & "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Barang telah dihapus", MsgBoxStyle.Information, "Pemberitahuan")
        Else
            Exit Sub
        End If

        Dim form = New Keranjang
        tampilkanPanel(form)
    End Sub
End Class