Imports System.Data.SqlClient

Public Class Review

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

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        Search.Show()
        Me.Hide()

    End Sub

    Private Sub BTNReservation_Click(sender As Object, e As EventArgs) Handles BTNReservation.Click
        Reservation.Show()
        Me.Hide()

    End Sub

    Private Sub BTNReview_Click(sender As Object, e As EventArgs) Handles BTNReview.Click

        Me.Hide()
        Me.Show()

    End Sub

    Private Sub txtName1_TextChanged(sender As Object, e As EventArgs) Handles txtName1.TextChanged

    End Sub

    Private Sub BTNRefresh_Click(sender As Object, e As EventArgs) Handles BTNRefresh.Click
        Dim connectionString As String = "Data Source=ANNA酱;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM Review "
        Dim command As New SqlCommand(query, connection)

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            Dim columnValue As Object = reader("name")
            txtName1.Text = reader("name").ToString()
            txtRating1.Text = reader("rating").ToString()
            txtReview1.Text = reader("review").ToString()
            While reader.Read()
                txtName2.Text = reader("name").ToString()
                txtRating2.Text = reader("rating").ToString()
                txtReview2.Text = reader("review").ToString()
            End While
        End While
        connection.Close()
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        Dim connectionString As String = "Data Source=ANNA酱;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "INSERT INTO Review (name, rating, review) VALUES (@name, @rating, @review)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", txtName3.Text)
        command.Parameters.AddWithValue("@rating", txtRating3.Text)
        command.Parameters.AddWithValue("@review", txtReview3.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Successfully Updated. Thank you")
    End Sub

End Class