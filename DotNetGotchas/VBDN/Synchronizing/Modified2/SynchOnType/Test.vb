'Test.vb

Imports System.Threading

Module Test

    Private Sub Worker1()
        Console.WriteLine("In thread {0}", _
            AppDomain.GetCurrentThreadId())

        Dim aBacteria As New Bacteria
    End Sub

    Private Sub Worker2()
        Console.WriteLine("In thread {0}", _
            AppDomain.GetCurrentThreadId())

        Dim aBacteria As New SpecializedBacteria
    End Sub


    Public Sub Main()
        Dim thread1 As New Thread(AddressOf Worker1)
        Dim thread2 As New Thread(AddressOf Worker2)

        thread1.Start()
        thread2.Start()
    End Sub
End Module
