Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Edit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idrequest As String
        idrequest = Request.QueryString("id")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            If Not Me.IsPostBack Then
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("select * from course where ID_Course='" + idrequest + "'", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            'Dim mydate As DateTime = DateTime.Parse(reader("enrollmentdate").ToString)
                            IDCourse_Edit.Text = reader("ID_Course").ToString()
                            Title_Edit.Text = reader("Title").ToString()
                            Credits_Edit.Text = reader("Credits").ToString()
                        End If
                    End Using
                End Using
            End If
        End Using
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As New DataTable
        Dim idrequest As String
        idrequest = Request.QueryString("id")

        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using commands As New MySqlCommand("UPDATE course SET Title='" & Title_Edit.Text & "', Credits='" & Credits_Edit.Text & "' WHERE ID_Course='" + idrequest + "'", connection)
                Using readers As MySqlDataReader = commands.ExecuteReader()
                    result.Load(readers)
                End Using
            End Using
        End Using

        Response.Redirect("~/Course/Index")
    End Sub
End Class