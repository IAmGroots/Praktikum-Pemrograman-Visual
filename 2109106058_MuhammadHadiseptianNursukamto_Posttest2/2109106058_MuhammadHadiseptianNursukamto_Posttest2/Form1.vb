Public Class Form1
    Private Sub txtGaji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGaji.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSakit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSakit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTnpKet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTnpKet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtIzin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIzin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGaji.Text = 0
        txtIzin.Text = 0
        txtSakit.Text = 0
        txtTnpKet.Text = 0
        cmbBulan.SelectedIndex = 0
        txtHari.Text = 27

        listData.GridLines = True
        listData.View = View.Details
        listData.Columns.Add("Gaji Pokok")
        listData.Columns.Add("Bulan")
        listData.Columns.Add("Jumlah Hari Kerja")
        listData.Columns.Add("Sakit")
        listData.Columns.Add("Izin")
        listData.Columns.Add("Tanpa Keterangan")
        listData.Columns.Add("Tunjangan")
        listData.Columns.Add("Gaji Bersih")
    End Sub

    Private Sub txtGaji_TextChanged(sender As Object, e As EventArgs) Handles txtGaji.TextChanged
        If txtGaji.Text = "" Then
            errorInput.SetError(txtGaji, "Wajib Diisi")
            Return
        ElseIf txtGaji.Text = 0 Then
            errorInput.SetError(txtGaji, "Wajib Lebih Dari 0")
            Return
        Else
            errorInput.SetError(txtGaji, "")
        End If

        Dim gajiPokok, tunjangan As Integer
        gajiPokok = txtGaji.Text
        tunjangan = txtTunjangan.Text

        txtGjBersih.Text = gajiPokok + tunjangan
    End Sub

    Private Sub txtSakit_TextChanged(sender As Object, e As EventArgs) Handles txtSakit.TextChanged
        If txtSakit.Text = "" Then
            errorInput.SetError(txtSakit, "Wajib Diisi")
            Return
        ElseIf txtSakit.Text = 0 Then
            errorInput.SetError(txtSakit, "")
            Return
        Else
            errorInput.SetError(txtSakit, "")
        End If

        Dim jmlUang, jmlSakit, jmlIzin, jmlTnpKet, gajiPokok, tunjangan As Integer
        jmlUang = txtHari.Text * 50000
        jmlSakit = txtSakit.Text * 20000
        jmlIzin = txtIzin.Text * 5000
        jmlTnpKet = txtTnpKet.Text * 30000

        txtTunjangan.Text = jmlUang - (jmlSakit + jmlIzin + jmlTnpKet)

        gajiPokok = txtGaji.Text
        tunjangan = txtTunjangan.Text

        txtGjBersih.Text = gajiPokok + tunjangan
    End Sub

    Private Sub txtIzin_TextChanged(sender As Object, e As EventArgs) Handles txtIzin.TextChanged
        If txtIzin.Text = "" Then
            errorInput.SetError(txtIzin, "Wajib Diisi")
            Return
        ElseIf txtIzin.Text = 0 Then
            errorInput.SetError(txtIzin, "")
            Return
        Else
            errorInput.SetError(txtIzin, "")
        End If

        Dim jmlUang, jmlSakit, jmlIzin, jmlTnpKet, gajiPokok, tunjangan As Integer
        jmlUang = txtHari.Text * 50000
        jmlSakit = txtSakit.Text * 20000
        jmlIzin = txtIzin.Text * 5000
        jmlTnpKet = txtTnpKet.Text * 30000

        txtTunjangan.Text = jmlUang - (jmlSakit + jmlIzin + jmlTnpKet)

        gajiPokok = txtGaji.Text
        tunjangan = txtTunjangan.Text

        txtGjBersih.Text = gajiPokok + tunjangan
    End Sub

    Private Sub txtTnpKet_TextChanged(sender As Object, e As EventArgs) Handles txtTnpKet.TextChanged
        If txtTnpKet.Text = "" Then
            errorInput.SetError(txtTnpKet, "Wajib Diisi")
            Return
        ElseIf txtTnpKet.Text = 0 Then
            errorInput.SetError(txtTnpKet, "")
            Return
        Else
            errorInput.SetError(txtTnpKet, "")
        End If

        Dim jmlUang, jmlSakit, jmlIzin, jmlTnpKet, gajiPokok, tunjangan As Integer
        jmlUang = txtHari.Text * 50000
        jmlSakit = txtSakit.Text * 20000
        jmlIzin = txtIzin.Text * 5000
        jmlTnpKet = txtTnpKet.Text * 30000

        txtTunjangan.Text = jmlUang - (jmlSakit + jmlIzin + jmlTnpKet)

        gajiPokok = txtGaji.Text
        tunjangan = txtTunjangan.Text

        txtGjBersih.Text = gajiPokok + tunjangan
    End Sub

    Private Sub cmbBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBulan.SelectedIndexChanged
        If cmbBulan.Text = "Januari" Then
            txtHari.Text = 27
        ElseIf cmbBulan.Text = "Februari" Then
            txtHari.Text = 24
        ElseIf cmbBulan.Text = "Maret" Then
            txtHari.Text = 27
        ElseIf cmbBulan.Text = "April" Then
            txtHari.Text = 26
        ElseIf cmbBulan.Text = "Mei" Then
            txtHari.Text = 27
        ElseIf cmbBulan.Text = "Juni" Then
            txtHari.Text = 26
        ElseIf cmbBulan.Text = "Juli" Then
            txtHari.Text = 27
        ElseIf cmbBulan.Text = "Agustus" Then
            txtHari.Text = 27
        ElseIf cmbBulan.Text = "September" Then
            txtHari.Text = 26
        ElseIf cmbBulan.Text = "Oktober" Then
            txtHari.Text = 27
        ElseIf cmbBulan.Text = "November" Then
            txtHari.Text = 26
        ElseIf cmbBulan.Text = "Desember" Then
            txtHari.Text = 27
        End If

        Dim jmlUang, jmlSakit, jmlIzin, jmlTnpKet, gajiPokok, tunjangan As Integer
        jmlUang = txtHari.Text * 50000
        jmlSakit = txtSakit.Text * 20000
        jmlIzin = txtIzin.Text * 5000
        jmlTnpKet = txtTnpKet.Text * 30000

        txtTunjangan.Text = jmlUang - (jmlSakit + jmlIzin + jmlTnpKet)

        gajiPokok = txtGaji.Text
        tunjangan = txtTunjangan.Text

        txtGjBersih.Text = gajiPokok + tunjangan
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtGaji.Text = "" Then
            errorInput.SetError(txtGaji, "Wajib Diisi")
            txtGaji.Focus()
            Return
        ElseIf txtGaji.Text = 0 Then
            errorInput.SetError(txtGaji, "Wajib Lebih Dari 0")
            txtGaji.Focus()
            Return
        ElseIf txtSakit.Text = "" Then
            errorInput.SetError(txtSakit, "Wajib Diisi")
            txtSakit.Focus()
            Return
        ElseIf txtIzin.Text = "" Then
            errorInput.SetError(txtIzin, "Wajib Diisi")
            txtIzin.Focus()
            Return
        ElseIf txtTnpKet.Text = "" Then
            errorInput.SetError(txtTnpKet, "Wajib Diisi")
            txtTnpKet.Focus()
            Return
        End If

        Dim arrayData(8) As String
        arrayData(0) = txtGaji.Text
        arrayData(1) = cmbBulan.Text
        arrayData(2) = txtHari.Text
        arrayData(3) = txtSakit.Text
        arrayData(4) = txtIzin.Text
        arrayData(5) = txtTnpKet.Text
        arrayData(6) = txtTunjangan.Text
        arrayData(7) = txtGjBersih.Text

        Dim listItem As ListViewItem
        'listItem = New ListViewItem
        listItem = listData.Items.Add(arrayData(0))
        listItem.SubItems.Add(arrayData(1))
        listItem.SubItems.Add(arrayData(2))
        listItem.SubItems.Add(arrayData(3))
        listItem.SubItems.Add(arrayData(4))
        listItem.SubItems.Add(arrayData(5))
        listItem.SubItems.Add(arrayData(6))
        listItem.SubItems.Add(arrayData(7))

        txtGaji.Text = 0
        txtSakit.Text = 0
        txtIzin.Text = 0
        txtTnpKet.Text = 0
        cmbBulan.SelectedIndex = 0
        txtGaji.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtGaji.Text = 0
        txtSakit.Text = 0
        txtIzin.Text = 0
        txtTnpKet.Text = 0
        cmbBulan.SelectedIndex = 0
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim keluar As String
        keluar = MessageBox.Show("Keluar ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If keluar = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class