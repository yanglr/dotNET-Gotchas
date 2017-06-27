'Test.vb as part of ESUser.exe

Imports ESLib

Module Test

    Sub Main()
        Dim theComp As New MyComp

        theComp.SetInfo("hello")

        Console.WriteLine(theComp.GetInfo())
    End Sub

End Module
