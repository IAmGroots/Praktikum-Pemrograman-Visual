Imports MySql.Data.MySqlClient

Public Class Lihat
    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        DA = New MySqlDataAdapter("Select * From produk", CONN)
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
            Dim produk As New Produk ' membuat objek PictureBox baru
            With produk ' mengatur properti picturebox
                .btnKodeProduk.Text = array(i, 0)
                .btnNamaProduk.Text = array(i, 1)
                Dim hrg As Integer = array(i, 3)
                .btnHargaProduk.Text = "Rp " & FormatNumber(hrg, 0, TriState.True)
                .PictureBox1.Image = Image.FromFile(PATH_GAMBAR & array(i, 4))
            End With
            produk.TopLevel = False
            FlowLayoutPanel1.Controls.Add(produk) ' menambahkan objek picturebox ke form
            produk.Show()
        Next
    End Sub
End Class