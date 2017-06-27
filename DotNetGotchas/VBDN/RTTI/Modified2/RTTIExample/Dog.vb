'Dog.vb

Public Class Dog
    Inherits Animal

    Public Sub Bark()
        Console.WriteLine("Dog barking")
    End Sub


    Public Overrides Sub MakeNoise()
        Bark()
    End Sub
End Class
