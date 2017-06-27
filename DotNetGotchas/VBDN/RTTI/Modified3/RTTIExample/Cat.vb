'Cat.vb
Public Class Cat
    Inherits Animal

    Public Sub Meow()
        Console.WriteLine("Cat Meowing")
    End Sub

    Public Overrides Sub MakeNoise()
        Meow()
    End Sub

    Public Overrides Function Play(ByVal other As Animal) As Boolean
        Return False
    End Function
End Class
