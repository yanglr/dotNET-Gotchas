Imports System.Reflection

Module Test
    Public Sub Method1()

    End Sub

    Public Sub Main()

        Console.Write("Enter number of iterations:")
        Dim iterations As Integer = Convert.ToInt32(Console.ReadLine())

        Dim directCallStartTick As Integer = Environment.TickCount
        Dim i As Integer
        For i = 0 To iterations - 1
            Method1()
        Next

        Dim directCallEndTick As Integer = Environment.TickCount

        Dim theMethod As MethodInfo _
            = GetType(Test).GetMethod("Method1")
        Dim InvokeCallStartTick As Integer = Environment.TickCount
        For i = 0 To iterations - 1
            theMethod.Invoke(GetType(Test), Nothing)
        Next

        Dim InvokeCallEndTick As Integer = Environment.TickCount

        Console.WriteLine("Time taken:")
        Console.WriteLine("Direct call: {0}", _
            (directCallEndTick - directCallStartTick) / 1000.0)

        Console.WriteLine("Invoke call: {0}", _
            (InvokeCallEndTick - InvokeCallStartTick) / 1000.0)
    End Sub
End Module
