'Test.vb

Imports ALib

Module Test
    Public Sub Main()
        Console.WriteLine("Main running in Thread {0}", _
           AppDomain.GetCurrentThreadId())
        Dim anObject As New SomeClass
        anObject.doSomething(5)
    End Sub
End Module