Module Test
    Private Const format As String = "{0,-15} {1,-20} {2,-15}"

    Sub Main()
        Dim iterations As Integer() = New Integer() {10, 100, _
    1000, 2500, 5000, 7500, _
    10000, 15000, 25000, 35000, _
    50000, 65000, 75000, 85000, _
    100000, 150000, 250000, 350000, 500000, _
    650000, 750000, 850000, 1000000}

        Console.WriteLine(format, _
          "# of Appends", "Time (in sec) for &", _
          "Time (in sec) for StringBuilder")

        For Each count As Integer In iterations
            Run(count)
        Next


    End Sub
    Sub Run(ByVal count As Integer) 'number of strings to append
        Dim str As String = Nothing
        Dim startCount As Integer = Environment.TickCount

        Dim i As Integer

        For i = 0 To count
            str = str & "."
        Next

        Dim endCount As Integer = Environment.TickCount

        Dim timeTakenByPlus As Double = _
         (endCount - startCount) / 1000.0


        Dim bldr As New System.Text.StringBuilder

        startCount = Environment.TickCount

        For i = 0 To count
            bldr.Append(".")
        Next

        endCount = Environment.TickCount

        Dim timeTakenByStringBuilder As Double = _
         (endCount - startCount) / 1000.0

        Console.WriteLine(format, _
            count, timeTakenByPlus, timeTakenByStringBuilder)
    End Sub
End Module
