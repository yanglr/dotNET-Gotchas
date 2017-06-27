Public Class Program

    Public Sub foo()
        Console.WriteLine("foo called")
    End Sub

    Public Shared Sub Main()

        'Very simple case
        Dim val As Integer = 2.3
        Console.WriteLine(val)

        'This one is more killing
        Dim obj As Program = New Object

        obj.foo()

    End Sub

End Class
