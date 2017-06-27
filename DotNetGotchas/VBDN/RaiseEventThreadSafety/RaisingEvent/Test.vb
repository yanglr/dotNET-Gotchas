'Test.vb
Imports System.Threading

Module Test

    Private Sub TestHandler(ByVal sender As Object, ByVal e As EventArgs)
        Console.WriteLine("TestHandler called")
    End Sub

    Sub Main()
        Dim obj As New AComponent

        AddHandler obj.myEvent, AddressOf TestHandler

        obj.Work()

        Thread.Sleep(5)

        RemoveHandler obj.myEvent, AddressOf TestHandler
    End Sub

End Module
