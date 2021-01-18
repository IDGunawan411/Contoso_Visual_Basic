Imports MySql.Data.MySqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim Koneksi As New MySqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Koneksi.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic"
        Koneksi.Open()

    End Sub

End Class