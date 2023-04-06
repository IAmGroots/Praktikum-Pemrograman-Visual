Imports MySql.Data.MySqlClient

Module Bantuan
    Public PATH_GAMBAR As String = "D:\Proyek Visual Studio\Praktikum\2109106058_MuhammadHadiseptianNursukamto_Posttest4\Database Gambar\"

    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public DATABASE As String

    Sub koneksi()
        Try
            'DATABASE = "server=localhost;userid=root;password=;database=dbpraktikum"
            Dim DATABASE As String = "server=localhost;userid=root;password=;database=dbPraktikum"
            CONN = New MySqlConnection(DATABASE)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
