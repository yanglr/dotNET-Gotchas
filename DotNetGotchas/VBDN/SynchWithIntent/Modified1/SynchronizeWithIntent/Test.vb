'Test.vb

Imports System.Threading

Module Test

    Private Sub Worker()
        Console.WriteLine("In thread {0}", _
            AppDomain.GetCurrentThreadId())

        Dim aBacteria As New Bacteria
    End Sub
    Public Sub Main()
        Dim thread1 As New Thread(AddressOf Worker)
        Dim thread2 As New Thread(AddressOf Worker)


        SyncLock (GetType(Bacteria))
            Console.WriteLine("Starting threads at {0}", _
                 DateTime.Now.ToLongTimeString())

            thread1.Start()
            thread2.Start()

            Thread.Sleep(3000)
        End SyncLock
				
    End Sub

End Module
