Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Detail2
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
                            IDStudent_Detail.Text = reader("ID_Student").ToString()
                            FirstName_Detail.Text = reader("First_Name").ToString()
                            LastName_Detail.Text = reader("Last_Name").ToString()
                            Enrollment_Detail.Text = reader("EnrollmentDate").ToString()
                        End If
                    End Using
                End Using
            End If
        End Using
    End Sub

End Class