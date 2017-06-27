'TestModule.vb in VBUser.exe
Module TestModule

    Sub Main()
        Dim obj1 As New CSLib.MyCollection
        Dim obj2 As New VBLib.MyCollection

        Console.WriteLine("Size of arrays")
        Console.WriteLine("C# created: {0}", obj1.Values.Length)
        Console.WriteLine("VB.NET created: {0}", obj2.Values.Length)

    End Sub

End Module
