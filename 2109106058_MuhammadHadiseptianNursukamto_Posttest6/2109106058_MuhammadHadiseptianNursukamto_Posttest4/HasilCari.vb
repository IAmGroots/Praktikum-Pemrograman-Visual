Imports MySql.Data.MySqlClient

Public Class HasilCari
    Private Sub hasilCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Admin.txtCari.Visible = True
        Admin.btnCari.Visible = True
        Admin.btnTambah.Visible = True

        Dim target As String = Admin.txtCari.Text
        CMD = New MySqlCommand("Select * From produk where nama like '%" & target & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select * From produk where nama like '%" & target & "%'", CONN)
            DS = New DataSet
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
                Dim produk As New Produk
                With produk
                    .KodeProduk.Text = array(i, 0)
                    .NamaProduk.Text = array(i, 1)
                    Dim hrg As Integer = array(i, 3)
                    .HargaProduk.Text = "Rp " & FormatNumber(hrg, 0, TriState.True)
                    .pctProduk.ImageLocation = PATH_GAMBAR & array(i, 4)
                End With
                produk.TopLevel = False
                FlowLayoutPanel1.Controls.Add(produk)
                produk.Show()
            Next
        Else
            RD.Close()
            lblKosong.Visible = True
        End If
    End Sub
End Class