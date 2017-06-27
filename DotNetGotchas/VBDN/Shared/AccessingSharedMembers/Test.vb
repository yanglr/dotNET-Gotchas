'Test.vb
Public Class Test
    Public Shared Sub Run(ByVal b As Base)
        b.Method1()
        b.Method2()
    End Sub
    Public Shared Sub Main()
        Dim object1 As New Derived

        Console.WriteLine("--------- Using object of Derived")
        object1.Method1()
        object1.Method2()
        Run(object1)
    End Sub
End Class
