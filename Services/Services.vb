Imports System.IO

Public Class Services
    Dim file As String = System.Environment.CurrentDirectory + "/Data/database.csv"

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
