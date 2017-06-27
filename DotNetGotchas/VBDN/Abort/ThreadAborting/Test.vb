Imports System.Threading

Module Test

    Private Sub Worker()
        Try
            Try
                Thread.Sleep(5000)
            Catch ex As ThreadAbortException
                Console.WriteLine("ThreadAbortException caught")
            End Try

            Console.WriteLine("Let's leave the method now")
        Finally
            Console.WriteLine("In the finally block")
        End Try
    End Sub

    Public Sub Main()
        Dim workerThread As New Thread(AddressOf Worker)
        workerThread.Start()

        Thread.Sleep(1000)
        Console.WriteLine("Calling abort")
        workerThread.Abort()

        Thread.Sleep(1000)
        Console.WriteLine("Main done")
    End Sub

End Module
