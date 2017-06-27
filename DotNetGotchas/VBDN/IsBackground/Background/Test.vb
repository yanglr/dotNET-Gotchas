Imports System.Threading

Module Test

    Private Sub Worker()
        'Some activity
        Thread.Sleep(5000)

        Console.WriteLine("worker done at {0}", _
            DateTime.Now.ToLongTimeString())
    End Sub

    Sub Main()
        Dim workerThread As New Thread(AddressOf Worker)
        'workerThread.IsBackground = true
        workerThread.Start()

        Console.WriteLine("Main done at {0}", _
            DateTime.Now.ToLongTimeString())
    End Sub

End Module
