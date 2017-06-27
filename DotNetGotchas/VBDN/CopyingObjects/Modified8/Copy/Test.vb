'Test.vb
Module Test

    Sub Main()
        Dim sam As New Person(1, New SmarterBrain)
        'Dim bob As Person = New Person(sam)
        Dim bob As Person = CType(sam.Clone(), Person)

        Console.WriteLine(sam)
        Console.WriteLine(bob)
    End Sub

End Module
