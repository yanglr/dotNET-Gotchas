'SomeClass.vb part of ALib.dll
Imports System.Threading

Public Class SomeClass

    Private Sub Method1(ByVal val As Integer)
        Console.WriteLine( _
            "Method1 runs on Thread {0} with {1}", _
            AppDomain.GetCurrentThreadId(), val)

        ' Some operation takes place here
    End Sub

    Private theValToUseByCallMethod1 As Integer

    Private Sub CallMethod1()
        Method1(theValToUseByCallMethod1)
    End Sub


    Public Sub DoSomething(ByVal val As Integer)
        ' Some operation...

        ' Want to call Method1 in different thread
        ' from here?
        theValToUseByCallMethod1 = val
        Dim aThread As New Thread(AddressOf CallMethod1)
        aThread.Start()

        ' Some operation...
    End Sub
End Class
