Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class Delete
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idrequest As String
        idrequest = Request.QueryString("id")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("select * from course where ID_Course='" + idrequest + "'", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        IDCourse_Delete.Text = idrequest
                        Title_Delete.Text = reader("Title").ToString()
                        Credits_Delete.Text = reader("Credits").ToString()
                        result.Load(reader)
                    End If

                End Using
            End Using
            connection.Close()
        End Using
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idrequest As String
        idrequest = Request.QueryString("id")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("DELETE FROM course where ID_Course='" + idrequest + "'", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
            connection.Close()
        End Using
        Response.Redirect("~/Course/Index")
    End Sub
End Class