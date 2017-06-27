Module Test

    Private Sub Method1(ByVal val As Integer)
        Console.Write("Method 1 called from Thread {0}", _
            AppDomain.GetCurrentThreadId())

        Console.WriteLine(" with value {0}", val)
    End Sub

    Delegate Sub Method1Delegate(ByVal val As Integer)

    Public Sub Main()
        ' It is not so easy to call Method1 from
        ' another thread using the Thread class.

        Dim dlg As New Method1Delegate(AddressOf Method1)
        Dim handle As IAsyncResult _
                = dlg.BeginInvoke(2, Nothing, Nothing)

        Console.ReadLine()
    End Sub

End Module
