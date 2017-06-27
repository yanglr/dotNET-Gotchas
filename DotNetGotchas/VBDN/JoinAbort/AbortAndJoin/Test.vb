Imports System.Threading

Module Test

    Private Sub Worker()
        Console.WriteLine("Worker started")
        Try
            Thread.Sleep(5000)
        Finally
            Console.WriteLine("Worker enters finally {0}", _
                DateTime.Now.ToLongTimeString())
            Thread.Sleep(10000)
            ' Simulates some cleanup activity
            Console.WriteLine("Cleanup done in Worker {0}", _
                DateTime.Now.ToLongTimeString())
        End Try
    End Sub

    Public Sub Main()
        Dim workerThread As New Thread(AddressOf Worker)

        workerThread.IsBackground = True
        workerThread.Start()
        Thread.Sleep(1000)

        Console.WriteLine("Aborting thread {0}", _
         DateTime.Now.ToLongTimeString())
        workerThread.Abort()

        workerThread.Join()
        Console.WriteLine("Thread has aborted {0}", _
         DateTime.Now.ToLongTimeString())
    End Sub

End Module
