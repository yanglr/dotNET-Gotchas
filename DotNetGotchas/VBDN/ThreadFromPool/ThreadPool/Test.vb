Imports System.Threading

Module Test

    Private Sub Method1()
        Console.Write("Executed by Thread {0} which is ", _
         AppDomain.GetCurrentThreadId())

        If Not Thread.CurrentThread.IsThreadPoolThread Then
            Console.Write("not ")
        End If

        Console.WriteLine("from the thread pool at {0}", _
         DateTime.Now.ToLongTimeString())

        'Thread.Sleep(10000)
    End Sub

    Public Sub Main()
        Console.WriteLine("Using our own thread")
        For i As Integer = 0 To 4

            Dim aThread As New Thread(AddressOf Method1)
            aThread.Start()
            Thread.Sleep(1000)
        Next

        Console.WriteLine("Press any key to use timer")
        Console.ReadLine()
        Console.WriteLine("Using timer")
        Dim theTimer As New System.Timers.Timer(1000)
        AddHandler theTimer.Elapsed, _
            New System.Timers.ElapsedEventHandler( _
            AddressOf theTimer_Elapsed)

        theTimer.Start()
        Thread.Sleep(6000)
        theTimer.Stop()
    End Sub

    Private Sub theTimer_Elapsed( _
    ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        Method1()
    End Sub

End Module
