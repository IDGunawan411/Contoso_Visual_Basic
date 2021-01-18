Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class Index1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tampil_Course()
    End Sub

    Sub Tampil_Course()

        Dim result As New DataTable
        Using connection As New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
            connection.Open()
            Using command As New MySqlCommand("SELECT * FROM course", connection)
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

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%'", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & "", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If


    End Sub

    Protected Sub IDCourse_ASC_Click(sender As Object, e As EventArgs) Handles IDCourse_ASC.Click
        Dim result As New DataTable

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' ORDER BY ID_Course ASC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & " ORDER BY ID_Course ASC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If

    End Sub

    Protected Sub IDCourse_DESC_Click(sender As Object, e As EventArgs) Handles IDCourse_DESC.Click
        Dim result As New DataTable

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' ORDER BY ID_Course DESC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & " ORDER BY ID_Course DESC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If


    End Sub

    Protected Sub Titile_ASC_Click(sender As Object, e As EventArgs) Handles Titile_ASC.Click
        Dim result As New DataTable

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' ORDER BY Title ASC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & " ORDER BY Title ASC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If


    End Sub

    Protected Sub Titile_DESC_Click(sender As Object, e As EventArgs) Handles Titile_DESC.Click
        Dim result As New DataTable

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' ORDER BY Title DESC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & " ORDER BY Title DESC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If

    End Sub

    Protected Sub Credit_ASC_Click(sender As Object, e As EventArgs) Handles Credit_ASC.Click
        Dim result As New DataTable

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' ORDER BY Credits ASC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & " ORDER BY Credits ASC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If

    End Sub

    Protected Sub Credit_DESC_Click(sender As Object, e As EventArgs) Handles Credit_DESC.Click
        Dim result As New DataTable

        If Credit_Sr_From.Text = "" And Credit_Sr_To.Text = "" Then
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' ORDER BY Credits DESC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        Else
            Using connection As New MySqlConnection
                connection.ConnectionString = "server=localhost;user=root;password=;database=contoso_visual_basic;allow user variables=true"
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM course WHERE Title LIKE'%" & Title_Sr.Text & "%' 
            AND Credits BETWEEN " & Credit_Sr_From.Text & " AND " & Credit_Sr_To.Text & " ORDER BY Credits DESC", connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        result.Load(reader)
                    End Using
                End Using
            End Using
            GridView.DataSource = result
            GridView.DataBind()
        End If

    End Sub

    Protected Sub GridView_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView.PageIndexChanging
        GridView.PageIndex = e.NewPageIndex
        Tampil_Query()
    End Sub

End Class