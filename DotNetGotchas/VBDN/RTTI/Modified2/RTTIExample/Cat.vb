'Cat.vb
Public Class Cat
    Inherits Animal

    Public Sub Meow()
        Console.WriteLine("Cat Meowing")
    End Sub

    Public Overrides Sub MakeNoise()
        Meow()
    End Sub
End Class
