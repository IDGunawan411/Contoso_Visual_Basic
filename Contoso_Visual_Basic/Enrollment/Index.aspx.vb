Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Index2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tampil_Enrollment()
        If Not IsPostBack Then
            Gradedropdown_Sr()
        End If
    End Sub
    Protected Sub Tampil_Enrollment()

        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course INNER JOIN student on student.ID_Student = enrollment.ID_Student", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Bt_Search_Click(sender As Object, e As EventArgs) Handles Bt_Search.Click
        Tampil_Query()
    End Sub

    Protected Sub Tampil_Query()
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%'", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Gradedropdown_Sr()
        ddlGrade_sr.Items.Insert(0, New ListItem("Select", ""))
        ddlGrade_sr.Items.Insert(1, New ListItem("S", "S"))
        ddlGrade_sr.Items.Insert(2, New ListItem("A", "A"))
        ddlGrade_sr.Items.Insert(3, New ListItem("B", "B"))
        ddlGrade_sr.Items.Insert(4, New ListItem("C", "C"))
        ddlGrade_sr.Items.Insert(5, New ListItem("D", "D"))
    End Sub

    Protected Sub GridView_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView.PageIndexChanging
        GridView.PageIndex = e.NewPageIndex
        Tampil_Query()
    End Sub

    Protected Sub IDEnrollment_ASC_Click(sender As Object, e As EventArgs) Handles IDEnrollment_ASC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY ID_Enrollment ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub IDEnrollment_DESC_Click(sender As Object, e As EventArgs) Handles IDEnrollment_DESC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY ID_Enrollment DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub FirstName_ASC_Click(sender As Object, e As EventArgs) Handles FirstName_ASC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY student.First_Name ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub FirstName_DESC_Click(sender As Object, e As EventArgs) Handles FirstName_DESC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY student.First_Name DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Title_ASC_Click(sender As Object, e As EventArgs) Handles Title_ASC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY course.Title ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Title_DESC_Click(sender As Object, e As EventArgs) Handles Title_DESC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY course.Title DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Grade_ASC_Click(sender As Object, e As EventArgs) Handles Grade_ASC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY Grade ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Grade_DESC_Click(sender As Object, e As EventArgs) Handles Grade_DESC.Click
        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM enrollment INNER JOIN course on course.ID_Course = enrollment.ID_Course 
            INNER JOIN student on student.ID_Student = enrollment.ID_Student WHERE student.First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND course.Title LIKE'%" & Title_Sr.Text & "%' AND Grade LIKE'%" & ddlGrade_sr.Text & "%' ORDER BY Grade DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

End Class