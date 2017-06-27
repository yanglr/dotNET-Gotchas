'Program.vb
Module Program

    Sub Main()
        Console.Write("Please enter number of iterations:")
        Dim count As Integer = Convert.ToInt32(Console.ReadLine())

        Dim myArray() As SomeClass = New SomeClass(count - 1) {}
        Dim i As Integer

        For i = 0 To count - 1
            myArray(i) = New SomeClass
        Next

        Dim forStartTickCount As Integer = Environment.TickCount

        For i = 0 To count - 1
            Dim theObject As SomeClass = myArray(i)
            theObject.Method1()
        Next

        Dim forEndTickCount As Integer = Environment.TickCount

        Dim ienumeratorStartTickCount As Integer = _
            Environment.TickCount

        Dim iter As IEnumerator = myArray.GetEnumerator()

        While iter.MoveNext()
            Dim theObject As SomeClass = CType(iter.Current, SomeClass)
            theObject.Method1()
        End While

        Dim ienumeratorEndTickCount As Integer = Environment.TickCount

        Dim foreachStartTickCount As Integer = Environment.TickCount
        Dim theObj As SomeClass

        For Each theObj In myArray
            theObj.Method1()
        Next

        Dim foreachEndTickCount As Integer = Environment.TickCount

        Console.WriteLine("Timing:")

        Console.WriteLine("for: {0}", _
         (forEndTickCount - forStartTickCount) / 1000.0)


        Console.WriteLine("enumerator: {0}", _
         (ienumeratorEndTickCount - _
            ienumeratorStartTickCount) / 1000.0)

        Console.WriteLine("foreach: {0}", _
            (foreachEndTickCount _
            - foreachStartTickCount) / 1000.0)
    End Sub

End Module
