'Derived.vb
Public Class Derived
    Inherits Base
    Public Overrides Sub Method1()
        Console.WriteLine("Derived.Method1")
    End Sub

    Public Shared Sub Method2()
        Console.WriteLine("Derived Method2")
    End Sub
End Class
