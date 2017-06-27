'Test.vb

Class Test
    Private Shared Sub Use(ByVal baseObject As Base, ByVal theValue As Integer)
        Console.WriteLine("Executing Use with {0}, {1}", _
         baseObject.GetType().Name, theValue)

        Try
            baseObject.Method1(theValue)
        Catch e As InvalidInputException
            Console.WriteLine( _
             "{0} was thrown", e.GetType().FullName)
            ' Handle the exception here
        End Try

    End Sub

    '...

    Shared Sub Main()
        Dim object1 As New Base
        Use(object1, -1)
        Use(object1, 3)

        Dim object2 As New Derived
        Use(object2, -1)
        'Use does not handle InputMustBeEvenException
        Use(object2, 3)
    End Sub
End Class
