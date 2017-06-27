Public Class Test
    Implements IDisposable

    Private ReadOnly id As Integer

    Public Sub New(ByVal theID As Integer)
        id = theID
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Console.WriteLine("Finalize called on {0}", id)
    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        Console.WriteLine("Dispose called on {0}", id)
        GC.SuppressFinalize(Me)
    End Sub

    Public Shared Sub Main()
        Dim count As Integer = 1
        Dim object1 As New Test(count)
        count += 1
        Dim object2 As New Test(count)
        object1.Dispose()

        Console.WriteLine("Main done")
    End Sub
End Class
