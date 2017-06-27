'Test.vb
Module Test

    Sub Main()
        Console.WriteLine("Creating object")
        Dim theMyComp As MyCOMCompLib.IMyComp _
            = New MyCOMCompLib.MyCompClass

        Console.WriteLine("Calling Method1")
        theMyComp.Method1()

        'Console.WriteLine("Releasing the object")
        'System.Runtime.InteropServices.Marshal.ReleaseComObject( _
        '    theMyComp)

        Console.WriteLine("Setting reference to null")
        theMyComp = Nothing

        Console.WriteLine("Has the Object been destroyed?")
        Console.ReadLine()
    End Sub

End Module
