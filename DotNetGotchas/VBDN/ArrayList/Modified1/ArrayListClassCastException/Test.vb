Module Test

    Sub Main()
        Dim myList As New ArrayList

        myList.Add(3.0)
        myList.Add(3)
        ' Oops. 3 is boxed in as integer not double
        myList.Add("a"c)
        ' Boxing "a" as Char not double

        Dim total As Double = 0
        Dim val As Double
        For Each val In myList ' Exception here.
            total += val
        Next

        Console.WriteLine(total)
    End Sub

End Module
