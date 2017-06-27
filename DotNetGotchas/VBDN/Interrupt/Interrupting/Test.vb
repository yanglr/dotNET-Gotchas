Imports System.Threading

Module Test
    Public Sub Worker()
        Try
            Dim str As String = Nothing

            Console.WriteLine("worker started at {0}", _
                DateTime.Now.ToLongTimeString())

            For i As Integer = 0 To 30000
                str += i.ToString()
                'Simulating some activity
            Next

            Thread.Sleep(1000)

        Catch ex As ThreadInterruptedException
            Console.WriteLine("Thread interrupted at {0}", _
                 DateTime.Now.ToLongTimeString())
        End Try


        Console.WriteLine( _
            "Continuing after Exception is caught")
    End Sub

    Public Sub Main()
        Dim workerThread As New Thread(AddressOf Worker)

        'workerThread.IsBackground = True

        workerThread.Start()
        Thread.Sleep(1000)

        Console.WriteLine("Interrupting worker at {0}", _
            DateTime.Now.ToLongTimeString())

        workerThread.Interrupt()
    End Sub

End Module
