'Derived.vb

Public Class Derived
    Inherits Base

    Public Overridable Sub Method1()
        Console.WriteLine("Derived.Method1 called")
    End Sub
End Class