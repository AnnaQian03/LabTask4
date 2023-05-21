Imports System.Data.SqlClient

Public Class Reservation
    Private Sub BTNHome_Click(sender As Object, e As EventArgs) Handles BTNHome.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()

    End Sub

    Private Sub BTNHelp_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub BTNRestaurant_Click(sender As Object, e As EventArgs) Handles BTNRestaurant.Click
        Restaurant.Show()
        Me.Hide()

    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        Search.Show()
        Me.Hide()

    End Sub

    Private Sub BTNReservation_Click(sender As Object, e As EventArgs) Handles BTNReservation.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub BTNReview_Click(sender As Object, e As EventArgs) Handles BTNReview.Click
        Review.Show()

        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNReserve.Click
        Dim connectionString As String = "Data Source=ANNA酱;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "INSERT INTO Reservation (name, person, date, time) VALUES (@name, @person, @date, @time)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", txtName.Text)
        command.Parameters.AddWithValue("@person", txtNumber.Text)
        command.Parameters.AddWithValue("@date", txtDate.Text)
        command.Parameters.AddWithValue("@time", txtTime.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Successfully Reserved. Thank You")

        Controls.Clear()
        InitializeComponent()

    End Sub
End Class