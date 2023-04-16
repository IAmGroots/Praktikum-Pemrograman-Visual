Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        pctBackground.ImageLocation = PATH_GAMBAR & "background2.png"
        txtUsername.Focus()
    End Sub

    Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click
        MsgBox("Fitur masih dalam tahap pengembangan")
    End Sub

    Private Sub btnFacebook_Click(sender As Object, e As EventArgs) Handles btnFacebook.Click
        MsgBox("Fitur masih dalam tahap pengembangan")
    End Sub

    Private Sub btnTwitter_Click(sender As Object, e As EventArgs) Handles btnTwitter.Click
        MsgBox("Fitur masih dalam tahap pengembangan")
    End Sub

    Private Sub lblDaftar_Click(sender As Object, e As EventArgs) Handles lblDaftar.Click
        MsgBox("Fitur masih dalam tahap pengembangan")
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        lblUsername.ForeColor = Color.MediumSeaGreen
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        lblUsername.ForeColor = Color.DimGray
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        lblPassword.ForeColor = Color.MediumSeaGreen
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        lblPassword.ForeColor = Color.DimGray
    End Sub

    Private Sub lblDaftar_MouseEnter(sender As Object, e As EventArgs) Handles lblDaftar.MouseEnter
        lblDaftar.ForeColor = Color.MediumSeaGreen
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnMasuk.PerformClick()
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            lblUsername.ForeColor = Color.Tomato
            lblPassword.ForeColor = Color.Tomato
            txtUsername.Focus()
            Return
        ElseIf txtUsername.Text = "" Then
            lblUsername.ForeColor = Color.Tomato
            txtUsername.Focus()
            Return
        ElseIf txtPassword.Text = "" Then
            lblPassword.ForeColor = Color.Tomato
            txtPassword.Focus()
            Return
        End If

        CMD = New MySqlCommand("Select * From pengguna Where nama='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim role As String = RD.GetString(3)
            Dim idPengguna As String = RD.GetString(0)
            RD.Close()
            If role = "admin" Then
                UID = idPengguna
                ROLE_AKTIF = role
                Admin.Show()
                Me.Close()
            Else
                UID = idPengguna
                ROLE_AKTIF = role
                Pembeli.Show()
                Me.Close()
            End If
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub
End Class