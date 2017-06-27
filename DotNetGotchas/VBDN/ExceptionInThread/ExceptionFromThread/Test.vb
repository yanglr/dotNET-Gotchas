Imports System.Threading

Module Test

    Private Sub Method1()
        Console.WriteLine("Method1 is throwing exception")
        Throw New ApplicationException("**** oops ****")
    End Sub

    Delegate Sub Method1Delegate()

    Public Sub Main()
        Console.WriteLine("We first use a thread")
        Dim aThread As New Thread(AddressOf Method1)
        aThread.Start()

        Console.WriteLine("press return")
        Console.ReadLine()

        Console.WriteLine("We will use a Delegate now")
        Dim dlg As New Method1Delegate(AddressOf Method1)

        Dim handle As IAsyncResult = dlg.BeginInvoke(Nothing, Nothing)

        Thread.Sleep(1000)

        Console.WriteLine("Was the exception reported so far?")

        Try
            Console.WriteLine("Let's call EndInvoke")
            dlg.EndInvoke(handle)
        Catch ex As Exception
            Console.WriteLine("Exception: {0}", ex.Message)
        End Try

        Console.WriteLine("press return")
        Console.ReadLine()

        Console.WriteLine("We will use a timer now")

        Dim theTimer As New System.Timers.Timer(1000)

        AddHandler theTimer.Elapsed, _
                New System.Timers.ElapsedEventHandler( _
                    AddressOf theTimer_Elapsed)

        theTimer.Start()

        Thread.Sleep(3000)
        theTimer.Stop()

        Console.WriteLine("press return")
        Console.ReadLine()
    End Sub

    Private Sub theTimer_Elapsed( _
    ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)

        Method1()
    End Sub
End Module
