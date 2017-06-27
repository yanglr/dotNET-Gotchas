Imports System.Threading

Module Test

    Private Sub Worker()
        Console.WriteLine( _
         "Worker started... given chance to cleanup?")
        Try
            Thread.Sleep(5000)
        Catch ex As ThreadAbortException
            Console.WriteLine("Thread aborted exception received")
        End Try
    End Sub

    Public Sub Main()
        Dim workerThread As New Thread(AddressOf Worker)
        workerThread.IsBackground = True
        workerThread.Start()

        Thread.Sleep(2000)
        Console.WriteLine("Main done")
    End Sub

End Module
