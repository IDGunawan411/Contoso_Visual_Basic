Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Index
    Inherits System.Web.UI.Page

    Public Property DataGridView1 As Object

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tampil_Student()
    End Sub

    Sub Tampil_Student()

        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub GridView_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView.PageIndexChanging
        GridView.PageIndex = e.NewPageIndex
        Tampil_Query()
    End Sub

    Protected Sub Bt_Search_Click(sender As Object, e As EventArgs) Handles Bt_Search.Click
        Tampil_Query()
    End Sub

    Protected Sub Tampil_Query()
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%'", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub IDStudent_ASC_Click(sender As Object, e As EventArgs) Handles IDStudent_ASC.Click
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY ID_Student ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub IDStudent_DESC_Click(sender As Object, e As EventArgs) Handles IDStudent_DESC.Click
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY ID_Student DESC", connection)
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
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY First_Name ASC", connection)
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
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY First_Name DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub LastName_ASC_Click(sender As Object, e As EventArgs) Handles LastName_ASC.Click
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY Last_Name ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub LastName_DESC_Click(sender As Object, e As EventArgs) Handles LastName_DESC.Click
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY Last_Name DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Enrollment_ASC_Click(sender As Object, e As EventArgs) Handles Enrollment_ASC.Click
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY EnrollmentDate ASC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub

    Protected Sub Enrollment_DESC_Click(sender As Object, e As EventArgs) Handles Enrollment_DESC.Click
        Dim result As New DataTable
        Dim Date_Enrollment As String
        Dim Result_Enrollment As String
        Date_Enrollment = Enrollment_Sr.Text '2020-10-07
        If Enrollment_Sr.Text = "" Then
            Result_Enrollment = ""
        Else
            Result_Enrollment = Date_Enrollment(8) & Date_Enrollment(9) & "/" & Date_Enrollment(5) & Date_Enrollment(6) & "/" & Date_Enrollment(0) & Date_Enrollment(1) & Date_Enrollment(2) & Date_Enrollment(3)
        End If
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM student WHERE First_Name LIKE'%" & FirstName_Sr.Text & "%' 
            AND Last_Name LIKE'%" & LastName_Sr.Text & "%' AND EnrollmentDate LIKE'%" & Result_Enrollment & "%' ORDER BY EnrollmentDate DESC", connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        GridView.DataSource = result
        GridView.DataBind()
    End Sub
End Class