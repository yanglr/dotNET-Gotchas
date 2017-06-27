'Program.vb part of UnhandledExceptionConsoleApp.exe

Imports ALibrary
Imports System.Threading

Module Program
    Private Sub Worker()
			Console.WriteLine( _
				"Enter two numbers separated by a return")

        Dim number1 As Integer = Convert.ToInt32(Console.ReadLine())
        Dim number2 As Integer = Convert.ToInt32(Console.ReadLine())

        Dim result As Double = New Utility().Operate(number1, number2)

        Console.WriteLine("Result is {0}", result)
    End Sub

    Public Sub Main()
        Try
            'AddHandler AppDomain.CurrentDomain.UnhandledException, _
            '     New UnhandledExceptionEventHandler( _
            '    AddressOf CurrentDomain_UnhandledException)

            Dim aThread As New Thread(AddressOf Worker)
            aThread.Start()
        Catch ex As Exception
            Console.WriteLine("Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub CurrentDomain_UnhandledException( _
        ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        Console.WriteLine("Send the following to support")
        Console.WriteLine("Unexpected error:")
        Console.WriteLine(e.ExceptionObject)
        Console.WriteLine("Is CLR terminating: {0}", _
         e.IsTerminating)
    End Sub
End Module