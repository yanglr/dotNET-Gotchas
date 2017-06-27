'Test.vb - VB.NET Port of Test.cs

Module Test

    Sub Main()
        Dim objects() As Object = New Object(3) {}

        For i As Integer = 0 To 2
            objects(i) = New Object
        Next

        For Each anObj As Object In objects
            Console.WriteLine(anObj.GetHashCode())
        Next
    End Sub

End Module
