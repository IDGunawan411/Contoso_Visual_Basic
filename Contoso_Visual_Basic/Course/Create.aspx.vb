Imports MySql.Data.MySqlClient

Public Class Create1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()

            Using command As New MySqlCommand("insert into course(ID_Course,Title,Credits) 
            Values ('" & IDCourse_Text.Text & "','" & Title_Text.Text & "','" & Credits_Text.Text & "')", connection)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using

            End Using
        End Using
        Response.Redirect("~/Course/Index")
    End Sub
End Class