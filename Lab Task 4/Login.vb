Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Login
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()

    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        Dim connectionString As String = "Data Source=ANNA酱;Initial Catalog=LabTask4;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)

        Dim query As String = "SELECT * FROM login WHERE username =@username AND password = @password"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", txtUsername.Text)
        command.Parameters.AddWithValue("@password", txtPassword.Text)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim username As String = reader("username").ToString()
                Dim password As String = reader("password").ToString()
                'Do something with the retrieved values here

            End While
            MsgBox("Welcome")
            Home.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password. Please try again")
            Me.Show()
            Controls.Clear()
            InitializeComponent()
        End If
        connection.Close()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub BTNSignup_Click(sender As Object, e As EventArgs) Handles BTNSignup.Click
        Signup.Show()
        Me.Hide()

    End Sub
End Class
