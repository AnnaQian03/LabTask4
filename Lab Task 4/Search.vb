Imports System.Data.SqlClient

Public Class Search
    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()

    End Sub

    Private Sub BTNHelp_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub BTNHome_Click(sender As Object, e As EventArgs) Handles BTNHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub BTNRestaurant_Click(sender As Object, e As EventArgs) Handles BTNRestaurant.Click
        Restaurant.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTNReview.Click
        Review.Show()
        Me.Hide()

    End Sub

    Private Sub BTNReservation_Click(sender As Object, e As EventArgs) Handles BTNReservation.Click
        Reservation.Show()
        Me.Hide()

    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub BTNReserve_Click(sender As Object, e As EventArgs) Handles BTNReserve.Click
        Reservation.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Data Source=ANNA酱;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)

        Dim query As String = "SELECT * FROM Restaurant WHERE city =@city "
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@city", txtSearch.Text)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            txtID.Text = reader("id").ToString()
            txtAddress.Text = reader("address").ToString()
            txtZip.Text = reader("zip").ToString()
            txtState.Text = reader("state").ToString()
            txtPhoneNumber.Text = reader("phone").ToString()
            txtEmail.Text = reader("email").ToString()

        End While
        connection.Close()
    End Sub
End Class