'Derived.vb

Public Class Derived
    Inherits Base

    Public Overrides Sub method1()
        Console.WriteLine("Derived.Method1 called")
    End Sub
    Public Shadows Sub method2()
        Console.WriteLine("Derived.Method2 called")
    End Sub
End Class