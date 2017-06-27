'Test.vb part of ESUser.exe
Imports ESLib

Module Test
    Public Sub Work()
        Dim theFactory As New Factory

        Try
            Dim component1 As Comp = theFactory.CreateComp(1)
            Dim component2 As Comp = theFactory.CreateComp(2)

            Console.WriteLine(component1.GetValue())
            Console.WriteLine(component2.GetValue())

            component1.SetValue(1)
            component2.SetValue(-1)

            Console.WriteLine(component1.GetValue())
            Console.WriteLine(component2.GetValue())
        Catch ex As Exception
            Console.WriteLine("Oops: " + ex.Message)
        Finally
            theFactory.Dispose()
        End Try
    End Sub

    Public Sub Main()
        Try
            Work()
        Catch ex As Exception
            Console.WriteLine("Error:" + ex.Message)
        End Try
    End Sub
End Module
