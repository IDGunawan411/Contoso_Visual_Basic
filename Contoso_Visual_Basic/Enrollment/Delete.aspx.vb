Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Delete2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idrequest As String
        idrequest = Request.QueryString("id")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            If Not Me.IsPostBack Then
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
                INNER Join student on student.ID_Student = enrollment.ID_Student WHERE ID_Enrollment='" + idrequest + "'", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            'Dim mydate As DateTime = DateTime.Parse(reader("enrollmentdate").ToString)
                            IDEnrollment_Delete.Text = reader("ID_Enrollment").ToString()
                            IDStudent_Delete.Text = reader("First_Name").ToString()
                            IDCours_Delete.Text = reader("Title").ToString()
                            Grade_Delete.Text = reader("Grade").ToString()
                        End If
                    End Using
                End Using
            End If
        End Using
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idrequest As String
        idrequest = Request.QueryString("id")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("DELETE FROM enrollment where ID_Enrollment='" + idrequest + "'", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
            connection.Close()
        End Using
        Response.Redirect("~/Enrollment/Index")
    End Sub

End Class