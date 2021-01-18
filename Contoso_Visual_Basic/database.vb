Imports System.Data.Odbc


Module database

    Public koneksi As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public CMD As OdbcCommand

    Sub KoneksiDatabase()
        Try
            koneksi = New OdbcConnection("DSN=Contoso_Visual_Basic;MultipleActiveResultSets=True")
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
                MsgBox("Koneksi Berhasil", vbInformation, "Sukses")
            End If

        Catch ex As Exception
            MsgBox("Koneksi database gagal", vbCritical, "Gagal")
        End Try
    End Sub




End Module
