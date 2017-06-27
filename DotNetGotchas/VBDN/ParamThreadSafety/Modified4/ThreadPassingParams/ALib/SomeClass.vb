'SomeClass.vb part of ALib.dll
Imports System.Threading

Public Class SomeClass

    Private Sub Method1(ByVal val As Integer)
        Console.WriteLine( _
            "Method1 runs on Thread {0} with {1}", _
            AppDomain.GetCurrentThreadId(), val)

        ' Some operation takes place here
    End Sub

    Private Delegate Sub CallMethod1Delegate(ByVal val As Integer)


    Public Sub DoSomething(ByVal val As Integer)
        ' Some operation...

        ' Want to call Method1 in different thread
        ' from here?
        Dim theRunner As New ThreadRunner( _
            New CallMethod1Delegate(AddressOf Method1), val)

        theRunner.Start()

        ' Some operation...
    End Sub
End Class
