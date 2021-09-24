Imports System.IO
Imports EMS.Services
Public Class Home

    Dim services As New Services()
    Private Sub MenuItem_Exitbtn_Click(sender As Object, e As EventArgs) Handles MenuItem_Exitbtn.Click
        Dim response As DialogResult = MessageBox.Show("Do you want to exit Applicaton?", "Exit Application", MessageBoxButtons.YesNoCancel
                                                       )
        If (response = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub
    ''' <summary>
    ''' form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadAllText()
    End Sub

    'method to save the employee details
    Private Sub HandleFile(userinfo As String)
        Try
            services.RegisterEmployee(userinfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

    'function to format the user info
    Private Function HandleUserInfo(username As String, phone As String, email As String) As String
        Dim userInfo As String = String.Format("{0}_{1}_{2}/", username, phone, email)
        Return userInfo
    End Function

    ''' <summary>
    ''' Safe Employee Details
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveInfobtn_Click(sender As Object, e As EventArgs) Handles SaveInfobtn.Click
        Dim info As String = HandleUserInfo(Usernametxt.Text, Phonetxt.Text, Emailtxt.Text)
        Try
            HandleValidation(Usernametxt.Text, Phonetxt.Text, Emailtxt.Text)
            ' CheckUser(Usernametxt.Text, Phonetxt.Text, Emailtxt.Text)
            HandleFile(info)
            AppendEmployee(Usernametxt.Text, Phonetxt.Text, Emailtxt.Text)
            ClearInfo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

    ''' <summary>
    ''' Read All the registered employees
    ''' </summary>
    Private Sub ReadAllText()
        Try
            Dim users As String()
            Dim resource As String = services.ReadEmployeesData()
            If (resource IsNot Nothing) Then
                users = resource.Split("/")
                For Each u In users
                    FetchUsers(u)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

    'show the users 
    Private Sub FetchUsers(user As String)
        Dim info As String() = user.Split("_")
        If (info.Length = 3) Then
            Employees.Rows.Add(New String() {info(0), info(1), info(2)})
        End If
    End Sub

    'append employee
    Private Sub AppendEmployee(username As String, phone As String, email As String)
        Employees.Rows.Add(New String() {username, phone, email})
    End Sub

    ''' <summary>
    ''' handle the user validatoin
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="phone"></param>
    Private Sub HandleValidation(username As String, phone As String, email As String)
        Dim validnum As Integer = 0
        If (username.Length <= 0) Then
            Throw New System.Exception("user name required")
        ElseIf Not Int32.TryParse(phone, validnum) Or phone.Length < 10 Or phone.Length > 10 Then
            Throw New System.Exception("phone number invalid")
        ElseIf email.Length <= 0 Then
            Throw New System.Exception("Email address required")
        Else
            Dim users As String()
            If services.ReadEmployeesData() IsNot Nothing Then
                users = services.ReadEmployeesData().Split("/")
                For Each u In users
                    Dim inf As String() = u.Split("_")
                    For Each value In inf
                        If value = username Then
                            Throw New System.Exception("username already registered")
                        ElseIf value = phone Then
                            Throw New System.Exception("phone number already registered")
                        ElseIf value = email Then
                            Throw New System.Exception("email number already registered")
                        End If
                    Next
                Next
            End If
        End If
    End Sub
    ''' <summary>
    ''' clear the input entries
    ''' </summary>
    Private Sub ClearInfo()
        Usernametxt.Clear()
        Phonetxt.Clear()
        Emailtxt.Clear()
    End Sub

    Private Sub ExitAppbtn_Click(sender As Object, e As EventArgs) Handles ExitAppbtn.Click
        Application.Exit()

    End Sub
End Class