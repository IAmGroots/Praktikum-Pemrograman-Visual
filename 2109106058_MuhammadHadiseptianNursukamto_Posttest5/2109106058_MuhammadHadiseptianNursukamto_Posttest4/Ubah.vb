Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Ubah
    Dim gambarLama As String
    Sub bersihkan()
        txtNamaProduk.Text = ""
        txtStokProduk.Text = 0
        txtHargaProduk.Text = 0
        pctGambarProduk.Image = Nothing
        txtNamaProduk.Focus()
        clickMe.Visible = True
    End Sub
    Sub tampilkanPanel(ByVal namaForm As Form)
        namaForm.TopLevel = False
        namaForm.WindowState = FormWindowState.Maximized
        Main.panelUtama.Controls.Add(namaForm)
        namaForm.Show()
    End Sub

    Private Sub pctGambarProduk_Click(sender As Object, e As EventArgs) Handles pctGambarProduk.Click
        opnfileGambar.FileName = ""
        opnfileGambar.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png"
        If opnfileGambar.ShowDialog() = DialogResult.OK Then
            clickMe.Visible = False
            Dim lokasiAsal As String = opnfileGambar.FileName
            Dim namaFile As String = Path.GetFileName(lokasiAsal)
            Dim lokasiTujuan As String = Path.Combine(PATH_GAMBAR, namaFile)

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
                If array(i, 4) = namaFile Then
                    MsgBox("Gambar sudah tersedia", MsgBoxStyle.Information, "Pemberitahuan")
                    clickMe.Visible = True
                    Return
                End If
            Next

            pctGambarProduk.Image = Image.FromFile(lokasiAsal)
            File.Copy(lokasiAsal, lokasiTujuan, True)
        End If
    End Sub

    Private Sub clickMe_Click(sender As Object, e As EventArgs) Handles clickMe.Click
        opnfileGambar.FileName = ""
        opnfileGambar.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png"
        If opnfileGambar.ShowDialog() = DialogResult.OK Then
            clickMe.Visible = False
            Dim lokasiAsal As String = opnfileGambar.FileName
            Dim namaFile As String = Path.GetFileName(lokasiAsal)
            Dim lokasiTujuan As String = Path.Combine(PATH_GAMBAR, namaFile)

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
                If array(i, 4) = namaFile Then
                    MsgBox("Gambar sudah tersedia", MsgBoxStyle.Information, "Pemberitahuan")
                    clickMe.Visible = True
                    Return
                End If
            Next

            pctGambarProduk.Image = Image.FromFile(lokasiAsal)
            File.Copy(lokasiAsal, lokasiTujuan, True)
        End If
    End Sub

    Private Sub txtNamaProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaProduk.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStokProduk.Focus()
        End If
    End Sub

    Private Sub txtStokProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStokProduk.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            txtHargaProduk.Focus()
        End If
    End Sub

    Private Sub txtHargaProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaProduk.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            clickMe.PerformClick()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaProduk.Text = "" Then
            txtNamaProduk.Focus()
            Return
        ElseIf txtStokProduk.Text = 0 Then
            txtStokProduk.Focus()
            Return
        ElseIf txtHargaProduk.Text = 0 Then
            txtHargaProduk.Focus()
            Return
        ElseIf pctGambarProduk.Image.Equals(Nothing) Then
            MsgBox("Gambar belum diisi", MsgBoxStyle.Information, "Pemberitahuan")
            Return
        End If

        Dim kodeProduk As String = txtKode.Text
        Dim namaProduk As String = txtNamaProduk.Text
        Dim stokProduk As Integer = txtStokProduk.Text
        Dim hargaProduk As Integer = txtHargaProduk.Text
        Dim gambarProduk As String
        If Path.GetFileName(opnfileGambar.FileName) = "" Then
            gambarProduk = gambarLama
        Else
            gambarProduk = Path.GetFileName(opnfileGambar.FileName)
        End If

        'kode nama stok harga gambar
        Dim query As String = "Update produk Set nama='" & namaProduk & "', stok='" & stokProduk & "', harga='" & hargaProduk & "', gambar='" & gambarProduk & "' Where kode='" & kodeProduk & "'"
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Produk Berhasil Diperbarui", MsgBoxStyle.Information, "Pemberitahuan")
        bersihkan()

        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim form = New Lihat
        tampilkanPanel(form)
    End Sub

    Private Sub Ubah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Main.txtCari.Visible = False
        Main.btnCari.Visible = False
        Main.btnTambah.Visible = False
        Main.btnRefresh.Visible = False

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
            If array(i, 0) = txtKode.Text Then
                gambarLama = array(i, 4)
            End If
        Next
    End Sub
End Class