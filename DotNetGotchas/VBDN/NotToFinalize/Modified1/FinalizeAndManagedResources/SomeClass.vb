'SomeClass.vb
Public Class SomeClass
    Private other As SomeOtherClass

    Public Sub Setother(ByVal otherObject As SomeOtherClass)
        other = otherObject
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Console.WriteLine("Finalize called on SomeClass")
        If Not other Is Nothing Then
            other.Notify()
        End If
    End Sub
End Class