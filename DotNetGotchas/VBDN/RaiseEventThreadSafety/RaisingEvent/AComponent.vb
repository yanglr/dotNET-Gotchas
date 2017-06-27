'AComponent.vb

Imports System.Threading

Public Class AComponent
    Public Event myEvent As EventHandler

    Private Sub DoWork()
        Thread.Sleep(5) ' Simulate some work delay

        'SyncLock Me
        RaiseEvent myEvent(Me, New EventArgs)
        'End SyncLock
    End Sub
    Public Sub Work()
        Dim aThread As New Thread(AddressOf DoWork)
        aThread.Start()
    End Sub
End Class
