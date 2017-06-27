Imports System.Collections.Generic

Module Test

    Sub Main()
        Dim myList As New Collection(Of Double)

        myList.Add(3.0)
        myList.Add(3) 'No problem 3 stored as 3.0

        myList.Add("a"c)
        'error BC30311: Value of type 'Char' 
        'cannot be converted to 'Double'

        Dim total As Double = 0
        Dim val As Double
        For Each val In myList
            total += val
        Next

        Console.WriteLine(total)
    End Sub

End Module
