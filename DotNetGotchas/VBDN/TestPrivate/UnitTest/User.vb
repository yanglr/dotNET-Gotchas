'User.vb
Imports System
Imports System.Security.Cryptography

Public Class User
    Private password As String

    Public Sub ChangePassword(ByVal oldPassword As String, _
            ByVal thePassword As String)
        'Make sure that the caller is either creating a new password,
        'or knows the old password
        If (password Is Nothing And oldPassword Is Nothing) OrElse _
                CreateHash(oldPassword) = password Then
            password = CreateHash(thePassword)
        Else
            Throw New ApplicationException("Invalid password")
        End If
    End Sub

    Friend Function GetPassword() As String
        Return password
    End Function


    Private Function CreateHash(ByVal input As String) As String
        Dim hashCode() As Byte = New SHA256Managed().ComputeHash( _
                     System.Text.Encoding.ASCII.GetBytes(input))

        Return BitConverter.ToString(hashCode)

    End Function
End Class