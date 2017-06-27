'Test.vb
Module Test

    Sub Main(ByVal args() As String)
        Dim iterations As Integer = Convert.ToInt32(args(0))
        Dim result As Integer = 0

        For i As Integer = 0 To iterations - 1
            Dim theWrapper As Wrapper

            Try
                theWrapper = New Wrapper
                result = theWrapper.doSomething()
            Finally
                theWrapper.Dispose()
            End Try

            Console.WriteLine(result)
            Console.WriteLine("End of Main")
        Next
    End Sub

End Module
