'Derived.vb
Public Class Derived
    Inherits Base
    Private obj2 As SomeClass2 = New SomeClass2

    Public Sub New()
        Console.WriteLine("Constructor of Derived called")
    End Sub
End Class
