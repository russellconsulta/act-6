Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles GameName.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub GameSales_Click(sender As Object, e As EventArgs) Handles GameSales.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub usrCount_Click(sender As Object, e As EventArgs) Handles usrCount.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub DeveloperRating_Click(sender As Object, e As EventArgs) Handles DeveloperRating.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub CriticScore_Click(sender As Object, e As EventArgs) Handles CriticScore.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class