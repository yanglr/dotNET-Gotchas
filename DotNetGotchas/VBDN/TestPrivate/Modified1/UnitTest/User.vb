'User.vb
Imports System
Imports System.Security.Cryptography
Imports NUnit.Framework

Public Class User
    Private password As String

    Public Sub ChangePassword(ByVal oldPassword As String, _
            ByVal thePassword As String)
        If (password Is Nothing And oldPassword Is Nothing) OrElse _
                CreateHash(oldPassword) = password Then
            password = CreateHash(thePassword)
        Else
            Throw New ApplicationException("Invalid password")
        End If
    End Sub

    Private Function CreateHash(ByVal input As String) As String
        Dim hashCode() As Byte = New SHA256Managed().ComputeHash( _
                     System.Text.Encoding.ASCII.GetBytes(input))

        Return BitConverter.ToString(hashCode)

    End Function

    'In .NET 2.0, with Partial Classes, this can be in a separate file
    <TestFixture()> _
    Public Class Test

        Private theUser As User

        <SetUp()> _
        Public Sub CreateCalculator()
            theUser = New User
        End Sub

        <Test()> _
      Public Sub TestSetPassword()
            Dim PASSWORD As String = "Cod!ng"

            theUser.ChangePassword(Nothing, PASSWORD)

            Assert.AreEqual(theUser.password, _
                theUser.CreateHash(PASSWORD))
        End Sub
    End Class

End Class