Public Class App
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listSatuanAwal.SelectedIndex = 0
        listSatuanAkhir.SelectedIndex = 0

        txtJudul.Text = "Konversi Satuan Panjang"
        txtPanah.Text = "<>"
    End Sub

    Private Sub txtAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAwal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAkhir.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub untukSebelahKiri()
        Dim hasil As Decimal
        Dim awal, akhir As String

        hasil = 0
        awal = listSatuanAwal.Text
        akhir = listSatuanAkhir.Text

        If awal = "Kilometer (km)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text * 1
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text * 10
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text * 100
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text * 1000
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text * 10000
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text * 100000
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 1000000
            End If

        ElseIf awal = "Hektometer (hm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text / 10
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text * 1
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text * 10
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text * 100
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text * 1000
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text * 10000
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 100000
            End If

        ElseIf awal = "Dekameter (dam)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text / 100
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text / 10
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text * 1
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text * 10
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text * 100
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text * 1000
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 10000
            End If

        ElseIf awal = "Meter (m)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text / 1000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text / 100
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text / 10
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text * 1
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text * 10
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text * 100
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 1000
            End If

        ElseIf awal = "Desimeter (dm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text / 10000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text / 1000
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text / 100
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text / 10
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text * 1
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text * 10
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 100
            End If

        ElseIf awal = "Centimeter (cm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text / 100000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text / 10000
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text / 1000
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text / 100
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text / 10
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text * 1
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 10
            End If

        ElseIf awal = "Milimeter (mm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAwal.Text / 1000000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAwal.Text / 100000
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAwal.Text / 10000
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAwal.Text / 1000
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAwal.Text / 100
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAwal.Text / 10
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAwal.Text * 1
            End If

        End If

        txtAkhir.Text = hasil
        txtHasil.Text = txtAwal.Text + " " + listSatuanAwal.Text + " = " + txtAkhir.Text + " " + listSatuanAkhir.Text
    End Sub

    Public Sub untukSebelahKanan()
        Dim hasil As Decimal
        Dim awal, akhir As String

        hasil = 0
        awal = listSatuanAkhir.Text
        akhir = listSatuanAwal.Text

        If awal = "Kilometer (km)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text * 1
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text * 10
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text * 100
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text * 1000
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text * 10000
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text * 100000
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 1000000
            End If

        ElseIf awal = "Hektometer (hm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text / 10
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text * 1
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text * 10
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text * 100
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text * 1000
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text * 10000
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 100000
            End If

        ElseIf awal = "Dekameter (dam)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text / 100
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text / 10
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text * 1
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text * 10
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text * 100
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text * 1000
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 10000
            End If

        ElseIf awal = "Meter (m)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text / 1000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text / 100
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text / 10
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text * 1
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text * 10
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text * 100
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 1000
            End If

        ElseIf awal = "Desimeter (dm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text / 10000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text / 1000
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text / 100
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text / 10
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text * 1
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text * 10
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 100
            End If

        ElseIf awal = "Centimeter (cm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text / 100000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text / 10000
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text / 1000
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text / 100
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text / 10
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text * 1
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 10
            End If

        ElseIf awal = "Milimeter (mm)" Then
            If akhir = "Kilometer (km)" Then
                hasil = txtAkhir.Text / 1000000
            ElseIf akhir = "Hektometer (hm)" Then
                hasil = txtAkhir.Text / 100000
            ElseIf akhir = "Dekameter (dam)" Then
                hasil = txtAkhir.Text / 10000
            ElseIf akhir = "Meter (m)" Then
                hasil = txtAkhir.Text / 1000
            ElseIf akhir = "Desimeter (dm)" Then
                hasil = txtAkhir.Text / 100
            ElseIf akhir = "Centimeter (cm)" Then
                hasil = txtAkhir.Text / 10
            ElseIf akhir = "Milimeter (mm)" Then
                hasil = txtAkhir.Text * 1
            End If

        End If

        txtAwal.Text = hasil
        txtHasil.Text = txtAwal.Text + " " + listSatuanAwal.Text + " = " + txtAkhir.Text + " " + listSatuanAkhir.Text
    End Sub

    Private Sub txtAwal_TextChanged(sender As Object, e As EventArgs) Handles txtAwal.TextChanged
        If txtAwal.Text = "" Then
            errorInputTarget.SetError(txtAwal, "Wajib Diisi")
            Return
        ElseIf txtAwal.Text = 0 Then
            errorInputTarget.SetError(txtAwal, "Wajib Lebih Dari 0")
            Return
        Else
            errorInputTarget.SetError(txtAwal, "")
        End If

        untukSebelahKiri()

    End Sub

    Private Sub txtAkhir_TextChanged(sender As Object, e As EventArgs) Handles txtAkhir.TextChanged
        If txtAkhir.Text = "" Then
            errorInputTarget.SetError(txtAkhir, "Wajib Diisi")
            Return
        ElseIf txtAkhir.Text = 0 Then
            errorInputTarget.SetError(txtAkhir, "Wajib Lebih Dari 0")
            Return
        Else
            errorInputTarget.SetError(txtAkhir, "")
        End If

        untukSebelahKanan()

    End Sub

    Private Sub listSatuanAwal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSatuanAwal.SelectedIndexChanged
        'untukSebelahKiri()
        untukSebelahKanan()
    End Sub

    Private Sub listSatuanAkhir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSatuanAkhir.SelectedIndexChanged
        'untukSebelahKanan()
        untukSebelahKiri()
    End Sub

End Class
