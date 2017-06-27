'Test.vb
Public Class Test
    Public Shared Sub Main()
        Dim firstInstance As New AType

        firstInstance.TheValue = 2

        Dim secondInstance As New AType
        secondInstance.TheValue = 3

        Console.WriteLine("The values are {0} and {1}", _
            firstInstance.TheValue, _
            secondInstance.TheValue)

        firstInstance = secondInstance ' Line A

        Console.Write("Values after assignment ")
        Console.WriteLine("are {0} and {1}", _
            firstInstance.TheValue, _
            secondInstance.TheValue)

        secondInstance.TheValue = 4

        Console.Write("Values after modifying TheValue ")
        Console.Write("in secondInstance are ")

        Console.WriteLine("{0} and {1}", _
            firstInstance.TheValue, _
            secondInstance.TheValue)
    End Sub
End Class
