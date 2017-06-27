'SomeOtherClass.vb
Public Class SomeOtherClass
    Private values() As Integer = New Integer(1000000 - 1) {}

    Public Sub Notify()
        Console.WriteLine("Entering Notify")
        SyncLock Me
            Console.WriteLine("Notify called on SomeOtherClass")
        End SyncLock
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Console.WriteLine("*** SomeOtherClass Finalized")
    End Sub
End Class