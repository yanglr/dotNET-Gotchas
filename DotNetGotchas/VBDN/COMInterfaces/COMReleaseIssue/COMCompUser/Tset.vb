Module Test

    Sub Main()
        Console.WriteLine("Creating object")
        Dim theMyComp As MyCOMCompLib.IMyComp _
            = New MyCOMCompLib.MyCompClass

        Dim theMyComp2 As MyCOMCompLib.IMyComp2 _
            = CType(theMyComp, MyCOMCompLib.IMyComp2)

        Console.WriteLine("Calling Method1")
        theMyComp.Method1()

        Console.WriteLine("Releasing the object")
			System.Runtime.InteropServices.Marshal.ReleaseComObject( _
				theMyComp)

        Console.WriteLine("Calling Method2")
        theMyComp2.Method2()
        Console.ReadLine()
    End Sub

End Module
