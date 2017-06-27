'Derived.cs

Public Class Derived
    Inherits Base

    Public Overridable Sub Method1(ByVal val As Integer)
        Console.WriteLine("Derived.Method1(int val) called")
    End Sub
End Class