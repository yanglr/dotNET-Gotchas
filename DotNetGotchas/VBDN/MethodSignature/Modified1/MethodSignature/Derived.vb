'Derived.cs

Public Class Derived
    Inherits Base

    Public Overloads Overrides Sub Method1(ByVal val As Double)
        Console.WriteLine( _
                "Derived.Method1(double val) called")
    End Sub

    Public Overridable Overloads Sub Method1(ByVal val As Integer)
        Console.WriteLine("Derived.Method1(int val) called")
        ' You may call Method1((double) val) from here if
        ' you want consistent behavior.
    End Sub
End Class