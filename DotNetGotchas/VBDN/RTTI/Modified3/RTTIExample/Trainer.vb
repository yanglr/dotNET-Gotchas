'Trainer.vb
Public Class Trainer
    Public Sub Train(ByVal anAnimal As Animal)
        anAnimal.Eat()

        'Using Abstraction and Polymorphis

        anAnimal.MakeNoise()
    End Sub
End Class
