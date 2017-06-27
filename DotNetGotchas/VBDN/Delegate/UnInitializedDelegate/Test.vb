'Test.vb
Public Class Test

    Private Sub callback1()
        Console.WriteLine("callback1 called")
    End Sub

    Private Sub callback2()
        Console.WriteLine("callback2 called")
    End Sub

    Private Sub work()
        Dim obj As New AComponent

        Console.WriteLine("Registering 2 callbacks")
        AddHandler obj.myEvent, New DummyDelegate(AddressOf callback1)
        AddHandler obj.myEvent, New DummyDelegate(AddressOf callback2)
        obj.fire()

        Console.WriteLine("Removing 1 callback")
        RemoveHandler obj.myEvent, New DummyDelegate(AddressOf callback2)
        obj.fire()

        Console.WriteLine("Removing the other callback")
        RemoveHandler obj.myEvent, New DummyDelegate(AddressOf callback1)
        obj.fire()
    End Sub
    Shared Sub Main(ByVal args As String())
        Dim testObj As New Test
        testObj.work()
    End Sub
End Class
