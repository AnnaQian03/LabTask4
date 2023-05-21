Imports System.Data.SqlClient

Public Class Signup
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNSignup.Click
        Dim connectionString As String = "Data Source=ANNA酱;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "INSERT INTO Login (username, password, email, name) VALUES (@username, @password, @email, @name)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", txtUsername.Text)
        command.Parameters.AddWithValue("@password", txtPassword.Text)
        command.Parameters.AddWithValue("@email", txtEmail.Text)
        command.Parameters.AddWithValue("@name", txtAccountName.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Successfully Update")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNCancel.Click
        Login.Show()
        Me.Hide()

    End Sub
End Class