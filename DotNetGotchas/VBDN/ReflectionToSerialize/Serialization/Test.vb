'Test.vb
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module Test

    Public Sub Main()
        Console.WriteLine( _
            "Enter s to serialize, d to deserialize")

        Dim input As String = Console.ReadLine()

        If input.ToUpper() = "S" Then
            Dim aCar As Car = New Car(2004, New Engine(500))

            Console.WriteLine("Serializing " & aCar.ToString())

            Dim strm As FileStream = New FileStream("output.dat", _
                 FileMode.Create, FileAccess.Write)

            Dim formatter As New BinaryFormatter
            formatter.Serialize(strm, aCar)
            strm.Close()
        Else
            Dim strm As FileStream = New FileStream("output.dat", _
                 FileMode.Open, FileAccess.Read)
            Dim formatter As New BinaryFormatter
            Dim aCar As Car = CType(formatter.Deserialize(strm), Car)
            strm.Close()
            Console.WriteLine("DeSerialized " & aCar.ToString())
        End If
    End Sub
End Module
