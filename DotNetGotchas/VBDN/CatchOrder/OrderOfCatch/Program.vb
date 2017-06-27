Module Program
    Public Sub AMethod()
        Throw New ApplicationException
    End Sub

    Sub Main(ByVal args As String())
        Try
            AMethod()
        Catch ex As Exception
            Console.WriteLine("Caught Exception")
        Catch ae As ApplicationException
            Console.WriteLine("Caught ApplicationException")
        End Try
    End Sub
End Module
