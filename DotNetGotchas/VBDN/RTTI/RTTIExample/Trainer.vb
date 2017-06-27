'Trainer.vb
Public Class Trainer
    Public Sub Train(ByVal anAnimal As Animal)
        anAnimal.Eat()

        'Using Casting

        Dim doggie As Dog = CType(anAnimal, Dog)
        doggie.Bark()

        Dim aCat As Cat = CType(anAnimal, Cat)
        aCat.Meow()
    End Sub
End Class
