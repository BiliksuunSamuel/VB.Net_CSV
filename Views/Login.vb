Public Class Login
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Application.Exit()
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        If (Phonetxt.Text = "1234567890" And Passwordtxt.Text = "password") Then
            Dim HomeScreen As New Home()
            Me.Hide()
            HomeScreen.Show()
        Else
            MessageBox.Show("Invalid Login Details", "Login Fail", MessageBoxButtons.OK)
        End If
    End Sub
End Class