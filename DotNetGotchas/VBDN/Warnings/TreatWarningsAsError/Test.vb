Public Class Base

    Public Overridable Sub foo()

    End Sub
End Class

Public Class Derived
    Inherits Base
    Public Sub foo()

    End Sub
End Class
Public Class Test
    Public Shared Sub Main(ByVal args() As String)
        Dim val As Integer

        Console.WriteLine("Test")
    End Sub
End Class
