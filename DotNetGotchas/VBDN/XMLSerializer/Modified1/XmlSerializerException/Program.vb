'Program.vb
Imports System.IO
Imports System.Xml.Serialization

Module Program

    Sub Main()
        Dim myList As New ArrayList
        myList.Add(New SomeType)

        Try
            Dim fileStrm As New FileStream("output.xml", _
                FileMode.Create)

            Dim theSerializer As New XmlSerializer(GetType(ArrayList))

            theSerializer.Serialize(fileStrm, myList)
        Catch ex As InvalidOperationException
            Console.WriteLine( _
             "OOps: The Problem is ""{0}""", _
             ex.Message)

            If Not ex.InnerException Is Nothing Then
                Console.WriteLine( _
                    "The real problem is {0}", ex.InnerException)
            End If

        Catch catchAllEx As Exception
            Console.WriteLine( _
             "OOps: The Problem is ""{0}""", _
             catchAllEx.Message)
            Throw
        End Try
    End Sub

End Module
