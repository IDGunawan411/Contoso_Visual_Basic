Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Edit2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim R_EID As String
        R_EID = Request.QueryString("EID")
        Dim result As New DataTable
        If Not Me.IsPostBack Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
                INNER Join student on student.ID_Student = enrollment.ID_Student WHERE ID_Enrollment='" + R_EID + "'", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            'Dim mydate As DateTime = DateTime.Parse(reader("enrollmentdate").ToString)
                            IDEnrollment_Edit.Text = reader("ID_Enrollment").ToString()
                        End If
                    End Using
                End Using
            End Using
            Studentdropdown()
            Coursedropdown()
            Gradedropdown()
        End If

    End Sub

    Protected Sub Studentdropdown()
        Dim R_SID As String
        R_SID = Request.QueryString("SID")

        'conenction path for database
        Using con As New MySqlConnection("server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true")
            con.Open()
            Dim cmd As New MySqlCommand("Select ID_Student,First_Name FROM student", con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            ddlStudent_edit.DataSource = ds
            ddlStudent_edit.SelectedValue = R_SID
            ddlStudent_edit.DataTextField = "First_Name"
            ddlStudent_edit.DataValueField = "ID_Student"
            ddlStudent_edit.DataBind()
            con.Close()
        End Using
    End Sub

    Protected Sub Coursedropdown()
        Dim R_CID As String
        R_CID = Request.QueryString("CID")

        Using con As New MySqlConnection("server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true")
            con.Open()
            Dim cmd As New MySqlCommand("Select ID_Course,Title FROM course", con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            ddlCourse_edit.DataSource = ds
            ddlCourse_edit.SelectedValue = R_CID
            ddlCourse_edit.DataTextField = "Title"
            ddlCourse_edit.DataValueField = "ID_Course"
            ddlCourse_edit.DataBind()
            con.Close()
        End Using
    End Sub

    Protected Sub Gradedropdown()
        Dim R_Grade As String
        R_Grade = Request.QueryString("Grade")

        ddlGrade_edit.SelectedValue = R_Grade
        ddlGrade_edit.Items.Insert(0, New ListItem("S", "S"))
        ddlGrade_edit.Items.Insert(1, New ListItem("A", "A"))
        ddlGrade_edit.Items.Insert(2, New ListItem("B", "B"))
        ddlGrade_edit.Items.Insert(3, New ListItem("C", "C"))
        ddlGrade_edit.Items.Insert(4, New ListItem("D", "D"))
        ddlGrade_edit.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R_EID As String
        R_EID = Request.QueryString("EID")
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()

            Using command As New MySqlCommand("UPDATE enrollment SET ID_Student='" & ddlStudent_edit.Text & "', ID_Course='" & ddlCourse_edit.Text & "', Grade='" & ddlGrade_edit.Text & "' WHERE ID_Enrollment='" + R_EID + "'", connection)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using

            End Using
        End Using
        Response.Redirect("~/Enrollment/Index")
    End Sub
End Class