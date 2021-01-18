Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Edit1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idrequest As String
        idrequest = Request.QueryString("id")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            If Not Me.IsPostBack Then
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("select * from student where ID_Student='" + idrequest + "'", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            'Dim mydate As DateTime = DateTime.Parse(reader("enrollmentdate").ToString)
                            IDStudent_Edit.Text = reader("ID_Student").ToString()
                            FirstName_Edit.Text = reader("First_Name").ToString()
                            LastName_Edit.Text = reader("Last_Name").ToString()
                        End If
                    End Using
                End Using
            End If
        End Using
        Enrollment_Edit.Text = DateTime.Now
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As New DataTable
        Dim idrequest_student As String
        idrequest_student = Request.QueryString("id")

        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using commands As New MySqlCommand("UPDATE student SET First_Name='" & FirstName_Edit.Text & "', 
            Last_Name='" & LastName_Edit.Text & "', EnrollmentDate='" & Enrollment_Edit.Text & "' WHERE ID_Student='" + idrequest_student + "'", connection)
                Using readers As MySqlDataReader = commands.ExecuteReader()
                    result.Load(readers)
                End Using
            End Using
        End Using

        Response.Redirect("~/Student/Index")
    End Sub
End Class