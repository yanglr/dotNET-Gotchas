Imports System.Threading

Module Test

    Public Sub Worker()
        Console.WriteLine("worker thread started")
        Try
            Thread.Sleep(5000)
        Catch ex As ThreadInterruptedException
            Console.WriteLine("worker interrupted")
        Catch ex As ThreadAbortException

            Console.WriteLine("worker aborted")
        End Try
    End Sub

    Public Sub Main()
        Dim workerThread1 As New Thread(AddressOf Worker)

        workerThread1.Start()
        Thread.Sleep(1000)

        Console.WriteLine("Interrupting worker1 at {0}", _
         DateTime.Now.ToLongTimeString())

        workerThread1.Interrupt()

        Dim workerThread2 As New Thread(AddressOf Worker)
        workerThread2.Start()
        Thread.Sleep(1000)

        Console.WriteLine("Calling Exit")

        Environment.Exit(0)
    End Sub

End Module
