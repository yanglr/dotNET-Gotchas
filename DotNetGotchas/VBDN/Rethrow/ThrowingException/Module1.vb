Module Test

    Public Sub Method1()
        Throw New ApplicationException
    End Sub

    Public Sub Method2()
        Try
            Method1()
        Catch ex As Exception
            'code to log may go here
            Throw ex
            'Throw New ApplicationException("Exception logged", ex)
        End Try
    End Sub

    Public Sub Method3()
        Try
            Method1()
        Catch ex As Exception
            'code to log may go here
            Throw
        End Try
    End Sub

    Public Sub Main()
        Try
            Console.WriteLine("----- Calling Method2")

            Method2()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        Try
            Console.WriteLine("----- Calling Method3")

            Method3()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub
End Module
