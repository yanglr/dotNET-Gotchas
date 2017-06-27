Module Test

    Private Sub timeRead(ByVal fetchSchema As Boolean)
        Dim ds As DataSet = New DataSet
        Dim startTime As Integer = Environment.TickCount

        If fetchSchema Then
            ds.ReadXmlSchema("..\data.xsd")
        End If

        ds.ReadXml("..\data.xml")

        Dim endTime As Integer = Environment.TickCount

        Console.WriteLine( _
         "Time taken to read {0} rows is {1} ms", _
         ds.Tables(0).Rows.Count.ToString(), _
         (endTime - startTime))
    End Sub

    Sub Main()
        Console.WriteLine("Reading XML into DataSet")
        timeRead(False)

        Console.WriteLine( _
            "Reading XML into DataSet after reading Schema")
        timeRead(True)
    End Sub

End Module
