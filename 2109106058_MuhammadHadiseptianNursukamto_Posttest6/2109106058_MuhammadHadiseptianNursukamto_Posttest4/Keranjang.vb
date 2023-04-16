Imports MySql.Data.MySqlClient

Public Class Keranjang
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        Pembeli.panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub

    Private Sub Keranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Dim totalHrg As Integer = 0
        Dim totalBrng As Integer = 0
        DA = New MySqlDataAdapter("Select * From transaksi Where idPengguna='" & UID & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "produk")

        Dim dt As DataTable = DS.Tables("produk")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            lblKosong.Visible = False
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            Dim produk As New ProdukKeranjang
            With produk
                .KodeTransaksi.Text = array(i, 0)
                Dim kodeProduk As String = array(i, 2)
                CMD = New MySqlCommand("Select * From produk Where kode='" & kodeProduk & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                .NamaProduk.Text = RD.GetString(1)
                Dim hrg As Integer = RD.GetString(3)
                .HargaProduk.Text = "Rp " & FormatNumber(hrg, 0, TriState.True)
                .JumlahProduk.Text = array(i, 3)
                .GambarProduk.ImageLocation = PATH_GAMBAR & RD.GetString(4)
                Dim total As Integer = array(i, 4)
                totalHrg += total
                totalBrng += 1
                RD.Close()
            End With

            produk.TopLevel = False
            FlowLayoutPanel1.Controls.Add(produk)
            produk.Show()
        Next
        TotalBarang.Text = totalBrng
        TotalHarga.Text = "Rp " & FormatNumber(totalHrg, 0, TriState.True)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub

    Private Sub btnKembali_MouseEnter(sender As Object, e As EventArgs) Handles btnKembali.MouseEnter
        btnKembali.BackColor = Color.Tomato
    End Sub

    Private Sub btnKembali_MouseLeave(sender As Object, e As EventArgs) Handles btnKembali.MouseLeave
        btnKembali.BackColor = Color.Transparent
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        MsgBox("Fitur masih dalam tahap pengembangan")
    End Sub
End Class