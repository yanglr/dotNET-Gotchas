Imports System.Threading

Module Test
    Private Sub Worker()
        Try
            Thread.Sleep(5000)
        Catch ex As ThreadAbortException

            Console.WriteLine("ThreadAbortException caught")
            Thread.ResetAbort()
        End Try

        Console.WriteLine("Look where we are now!")

        Thread.Sleep(10000)
    End Sub

    Public Sub Main()
        Dim workerThread As New Thread(AddressOf Worker)
        workerThread.Start()

        Thread.Sleep(1000)
        Console.WriteLine("Calling abort")
        workerThread.Abort()

        Thread.Sleep(2000)
        Console.WriteLine("Main done")
    End Sub

End Module
