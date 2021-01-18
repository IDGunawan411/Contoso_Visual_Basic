Imports MySql.Data.MySqlClient

Public Class Create
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox4.Text = DateTime.Now
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As New DataTable

        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()

            Using command As New MySqlCommand("insert into student(ID_Student,First_Name,Last_Name,EnrollmentDate) 
            Values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", connection)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using

            End Using
        End Using
        Response.Redirect("~/Student/Index")
    End Sub
End Class












