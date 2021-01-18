Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Web.UI.WebControls
Public Class Create2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Studentdropdown()
            Coursedropdown()
        End If
        Gradedropdown()

    End Sub
    Protected Sub Studentdropdown()
        'conenction path for database
        Using con As New MySqlConnection("server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true")
            con.Open()
            Dim cmd As New MySqlCommand("Select ID_Student,First_Name FROM student", con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            ddlStudent.DataSource = ds
            ddlStudent.DataTextField = "First_Name"
            ddlStudent.DataValueField = "ID_Student"
            ddlStudent.DataBind()
            con.Close()
        End Using
    End Sub

    Protected Sub Coursedropdown()
        'conenction path for database
        Using con As New MySqlConnection("server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true")
            con.Open()
            Dim cmd As New MySqlCommand("Select ID_Course,Title FROM course", con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            ddlCourse.DataSource = ds
            ddlCourse.DataTextField = "Title"
            ddlCourse.DataValueField = "ID_Course"
            ddlCourse.DataBind()
            con.Close()
        End Using
    End Sub
    Protected Sub Gradedropdown()

        ddlGrade.Items.Insert(0, New ListItem("S", "S"))
        ddlGrade.Items.Insert(1, New ListItem("A", "A"))
        ddlGrade.Items.Insert(2, New ListItem("B", "B"))
        ddlGrade.Items.Insert(3, New ListItem("C", "C"))
        ddlGrade.Items.Insert(4, New ListItem("D", "D"))

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()

            Using command As New MySqlCommand("insert into enrollment(ID_Enrollment,ID_Student,ID_Course,Grade) 
            Values ('" & IDEnrollment_Text.Text & "','" & ddlStudent.Text & "','" & ddlCourse.Text & "','" & ddlGrade.Text & "')", connection)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using

            End Using
        End Using
        Response.Redirect("~/Enrollment/Index")
    End Sub
End Class