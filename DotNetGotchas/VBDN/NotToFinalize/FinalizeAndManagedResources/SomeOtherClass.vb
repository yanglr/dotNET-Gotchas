'SomeOtherClass.vb
Public Class SomeOtherClass
    Private values() As Integer = New Integer(1000000 - 1) {}

    Public Sub Notify()
        Console.WriteLine("Notify called on SomeOtherClass")
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Console.WriteLine("*** SomeOtherClass Finalized")
    End Sub
End Class