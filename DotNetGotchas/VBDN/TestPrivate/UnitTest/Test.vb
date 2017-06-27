'Test.vb
Imports NUnit.Framework
Imports System.Security.Cryptography

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
        'How do you assert that the password has been set?
        'You can rely on calling the GetPassword method to do this.
        'However, do you really want to provide a 
        'method to get the password?

        'OK, let’s write one for now.


        Dim hashCode() As Byte = New SHA256Managed().ComputeHash( _
                     System.Text.Encoding.ASCII.GetBytes(PASSWORD))

        Dim hashCodeString As String = BitConverter.ToString(hashCode)

        Assert.AreEqual(hashCodeString, theUser.GetPassword())
    End Sub
End Class
