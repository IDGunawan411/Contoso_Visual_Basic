Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Detail1
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
                            IDEnrollment_Detail.Text = reader("ID_Enrollment").ToString()
                            IDStudent_Detail.Text = reader("First_Name").ToString()
                            IDCours_Detail.Text = reader("Title").ToString()
                            Grade_Detail.Text = reader("Grade").ToString()
                        End If
                    End Using
                End Using
            End If
        End Using
    End Sub

End Class