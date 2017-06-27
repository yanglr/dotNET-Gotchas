Public Class SomeClass
    Private ref1 As SomeOtherClass

    Public Sub New(ByVal givenObject As SomeOtherClass)
        ref1 = givenObject
    End Sub
    Protected Overrides Sub Finalize()
        ref1 = Nothing
        MyBase.Finalize()
    End Sub
End Class
