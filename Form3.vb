Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form3
    Dim DBConnection As New MysqlConnection

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog.Title = "Select a CSV file"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim fileName As String = openFileDialog.FileName
            Dim csvData As String = File.ReadAllText(fileName)

            Dim query As String = "INSERT INTO game_name (column1, column2, column3) VALUES (@val1, @val2, @val3)"
            Dim lines As String() = csvData.Split(New Char() {ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)

            Try
                If DBConnection.State = ConnectionState.Closed Then
                    DBConnection.Open()
                End If

                For Each line In lines
                    Dim values As String() = line.Split(",")
                    Dim command As New MySqlCommand(query, DBConnection)
                    command.Parameters.AddWithValue("@val1", values(0))
                    command.Parameters.AddWithValue("@val2", values(1))
                    command.Parameters.AddWithValue("@val3", values(2))
                    command.ExecuteNonQuery()
                Next

                MsgBox("Data has been successfully uploaded.", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Disconnect_to_DB()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect_to_DB()
        LoadData()
    End Sub

    Public Sub Connect_to_DB()
        Dim DBConnectionstring As String = "Server=localhost;Uid=root;Pwd='123456';Database=global_videogame_sales_rating;"
        DBConnection.ConnectionString = DBConnectionstring

        Try
            If DBConnection.State = ConnectionState.Closed Then
                DBConnection.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
            DBConnection.Dispose()
        End If
    End Sub

    Public Sub LoadData()
        Dim query As String = "SELECT * FROM actual_table_name"
        Dim command As New MySqlCommand(query, DBConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class
