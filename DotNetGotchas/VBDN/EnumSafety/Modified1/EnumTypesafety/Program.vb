Module Program
    Private resource() As Integer = New Integer() {0, 1, 2}

    Public Enum Size
        Small
        Medium
        Large
    End Enum

    Public Sub Method1(ByVal theSize As Size)
        If System.Enum.IsDefined(GetType(Size), theSize) Then
            Console.WriteLine(theSize)
            Console.WriteLine("Resource: {0}", _
                resource(Convert.ToInt32(theSize)))
        Else
            Throw New ApplicationException( _
                "Invalid input for Size")
        End If
    End Sub
    Sub Main()
        Try
            Method1(Size.Small)
            Method1(Size.Large)
            Method1(CType(1, Size))
            Method1(CType(3, Size))
        Catch ex As ApplicationException
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Module
