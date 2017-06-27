Module Test

    Sub Main()
        Dim theType As Type = Type.GetType("Test")

        Console.WriteLine(theType.FullName)
    End Sub

End Module
