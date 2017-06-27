'Animal.vb
Public MustInherit Class Animal
    Public Sub Eat()
        Console.WriteLine("Animal eating")
    End Sub

    Public MustOverride Sub MakeNoise()

    Public MustOverride Function Play(ByVal other As Animal) As Boolean
End Class