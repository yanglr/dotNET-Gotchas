Module Program
    Private resource() As Integer = New Integer() {0, 1, 2}

    Public Enum Size
        Small
        Medium
        Large
    End Enum

    Public Sub Method1(ByVal theSize As Size)
        Console.WriteLine(theSize)
        Console.WriteLine("Resource: {0}", _
            resource(Convert.ToInt32(theSize)))
    End Sub
    Sub Main()
        Method1(Size.Small)
        Method1(Size.Large)
        Method1(CType(1, Size))
        Method1(CType(3, Size))
    End Sub
End Module
