Imports System.Threading

'Bacteria.vb
Public Class Bacteria

    Private Shared bacteriaCount As Integer

    Private Shared Sub IncreaseCount()
        Console.WriteLine( _
         "IncreaseCount called by {0} at {1}", _
         AppDomain.GetCurrentThreadId(), _
         DateTime.Now.ToLongTimeString())

        bacteriaCount += 1

        Thread.Sleep(2000)
        ' Used for illustration purpose
    End Sub

    Public Sub New()
        SyncLock GetType(Bacteria)
            IncreaseCount()
        End SyncLock
    End Sub

End Class
