Imports System.Threading

Module Test

    Private Sub Worker()
        Dim currentThread As Thread = Thread.CurrentThread
        Console.WriteLine("In worker thread")

        Console.WriteLine("Apartment in worker is {0}", _
                     currentThread.ApartmentState.ToString())

        Console.WriteLine("Creating COM object")
        Dim theMyComp As MyCOMCompLib.IMyComp _
    = New MyCOMCompLib.MyCompClass

        Console.WriteLine("Apartment in worker is {0}", _
         currentThread.ApartmentState.ToString())
    End Sub

    Public Sub Main()
        Dim currentThread As Thread = Thread.CurrentThread

        Console.WriteLine("Apartment in main is {0}", _
         currentThread.ApartmentState.ToString())

        Console.WriteLine("Creating COM object")
        Dim theMyComp As MyCOMCompLib.IMyComp _
    = New MyCOMCompLib.MyCompClass

        Console.WriteLine("Apartment in main is {0}", _
         currentThread.ApartmentState.ToString())

        Dim workerThread As New Thread(AddressOf Worker)
        'Not setting IsBackground on thread intentionally
        workerThread.Start()
    End Sub
End Module
