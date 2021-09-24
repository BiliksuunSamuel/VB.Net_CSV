Public Class Splash
    Dim counter As Integer = 0
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressTimer.Enabled = True
    End Sub

    Private Sub HandleProgressLoader(count As Integer)
        ProgressState.Text = count.ToString() + "%"
    End Sub

    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        Dim LoginScreen As New Login()
        If (counter < 100) Then
            counter = counter + 1
            HandleProgressLoader(counter)
            If (counter < 25) Then
                LoaderState.Text = "Loading........"
            ElseIf counter > 25 And counter < 50 Then
                LoaderState.Text = "Processing....."
            ElseIf counter > 50 And counter < 75 Then
                LoaderState.Text = "Almost done....."
            Else
                LoaderState.Text = "Ready....."
            End If
        Else
            counter = counter
            HandleProgressLoader(counter)
            ProgressTimer.Enabled = False
            Me.Hide()
            LoginScreen.Show()
        End If
    End Sub
End Class
