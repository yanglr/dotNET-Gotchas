'Test.vb

Imports ALib

Module Test
    Public Sub Main()
        Console.WriteLine("Main running in Thread {0}", _
            AppDomain.GetCurrentThreadId())
        Dim anObject As New SomeClass
        anObject.DoSomething(5)
        anObject.DoSomething(6)
    End Sub
End Module