Public Class About
    Private Sub BTNHelp_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        Me.Hide()
        Me.Show()
    End Sub


    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()
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
        Review.Show()
        Me.Hide()

    End Sub
End Class