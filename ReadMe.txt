-EMPLOYEES MANAGEMENT SYSTEM
This is a basic management system for mangement of the working employees of a company
the system is design to keep record of the basic details of an employee
- On start of the system, after the loading screen( Splash screen),
- the user is welcomed with the login page where they would have to provide their basic access details
----phone number
----password

-if the provided details are not correct, then the user does not have permission to the system and as such will not be login
-moreover, if the entered user details are correct, then the user has the permissions to enter the system, and hence,is login
-------ON SUCCESSFUL LOGIN
--the user is welcomed to the home page where the have the following services to perform
-----------Register New Employee
--------ON REGISTRATION OF  A NEW EMPLOYEE BELOW ARE THE FOLLOWING CHECKS
--USER NAME EXIST OR NOT
--PHONE NUMBER EXIST OR NOT
--EMAIL ADDRESSS EXIST OR NOT
---the validation is handle in such a way that, no duplicates of the employee details in the system.

--------------- THE REQUIRED DETAILS FOR THE REGISTRATION OF AN EMPLOYEE IS
---full name(username)
---phone number
---email address

---- ON SUCCESSFUL OPERATION OF THE DUTIES AND TASK, THE USER HAS THE ABILITY TO LOGOUT
--the registered details are saved in a comman separated values CSV

----BELOW ARE THE CODES FOR THE VARIOUS SCREENS




-------------------------------SPLASH SCREEN-----------------------------
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


---------------------------LOGIN SCREEN--------------------
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

--------------------------------HOME SCREEN-----------------------------
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

-----------------------------------------------SERVICES---------------------------
Imports System.IO

Public Class Services
    Dim file As String = "../../Data/database.csv"

    ''' <summary>
    ''' Read Employee Data
    ''' </summary>
    ''' <returns></returns>
    Public Function ReadEmployeesData() As String
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader(file)
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            fileReader.Close()
            Return stringReader
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            Return ""
        End Try
    End Function
    ''' <summary>
    ''' Register Employee
    ''' </summary>
    ''' <param name="userinfo"></param>
    Public Sub RegisterEmployee(userinfo As String)
        Try
            Dim fs As FileStream = New FileStream(file, FileMode.Append, FileAccess.Write)
            Dim out = New StreamWriter(fs, System.Text.Encoding.Default)
            out.Write(userinfo)
            out.Close()
            Throw New System.Exception("Employee Added Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

End Class
