'Trainer.vb
Public Class Trainer
    Public Sub Train(ByVal anAnimal As Animal)
        anAnimal.Eat()

        'Using RTTI

        If TypeOf anAnimal Is Dog Then
            Dim doggie As Dog = CType(anAnimal, Dog)
            doggie.Bark()
        ElseIf TypeOf anAnimal Is Cat Then
            Dim aCat As Cat = CType(anAnimal, Cat)
            aCat.Meow()
        End If
    End Sub
End Class
