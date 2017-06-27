'Test.vb
Module Test

    Sub Main()
        Dim sam As New Person(1, New Brain)
        Dim bob As Person = New Person(sam)

        Console.WriteLine(sam)
        Console.WriteLine(bob)
    End Sub

End Module
