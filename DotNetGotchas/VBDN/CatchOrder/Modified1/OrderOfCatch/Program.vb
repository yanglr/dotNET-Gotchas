Module Program
    Public Sub AMethod()
        Throw New ApplicationException
    End Sub

    Sub Main(ByVal args As String())
        Try
            AMethod()
        Catch ae As ApplicationException
            Console.WriteLine("Caught ApplicationException")
        Catch ex As Exception
            Console.WriteLine("Caught Exception")
        End Try
    End Sub
End Module
