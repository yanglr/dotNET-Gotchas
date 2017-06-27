'AComponent.vb
Public Delegate Sub DummyDelegate()

Public Class AComponent
    Public Event myEvent As DummyDelegate

    Protected Overridable Sub OnMyEvent()
        RaiseEvent myEvent()
    End Sub

    Public Sub fire()
        Console.WriteLine("Raising event")
        OnMyEvent() ' Raising the event
        Console.WriteLine("Done raising event")
    End Sub
End Class
