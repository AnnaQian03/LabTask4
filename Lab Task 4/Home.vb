Public Class Home
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNHome.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        Review.Show()
        Me.Hide()

    End Sub
End Class