'SomeClass.vb part of ALib.dll
Imports System.Threading

Public Class SomeClass

    Private Sub Method1(ByVal val As Integer)
        Console.WriteLine( _
            "Method1 runs on Thread {0} with {1}", _
            AppDomain.GetCurrentThreadId(), val)

        ' Some operation takes place here
    End Sub

    '...
    Class CallMethod1Helper
        Private theTarget As SomeClass
        Private theValue As Integer

        Public Sub New(ByVal val As Integer, ByVal target As SomeClass)
            theValue = val
            theTarget = target
        End Sub

        Private Sub CallMethod1()
            theTarget.Method1(theValue)
        End Sub

        Public Sub Run()
            Dim theThread As New Thread(AddressOf CallMethod1)
            theThread.Start()
        End Sub
    End Class


    Public Sub DoSomething(ByVal val As Integer)
        ' Some operation...

        ' Want to call Method1 in different thread
        ' from here?
        Dim helper As New CallMethod1Helper(val, Me)
        helper.Run()

        ' Some operation...
    End Sub
End Class
