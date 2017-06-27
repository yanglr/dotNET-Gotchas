'Test.vb

Public Class Test
    Public Shared Sub Main()
        Dim instance1 As New MyType(10)
        Console.WriteLine("instance1: " & instance1.ToString())

        Dim instance2 As New MyType
        Console.WriteLine("instance2: " & instance2.ToString())
    End Sub
End Class
