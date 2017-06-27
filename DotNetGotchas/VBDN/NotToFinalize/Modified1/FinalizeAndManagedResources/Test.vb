'Test.vb
Module Test
    Sub ohoh(ByVal obj As SomeOtherClass)
        Dim object1 As New SomeClass
        object1.Setother(obj)
    End Sub

    Sub Main()
        Dim object2 As New SomeOtherClass

        SyncLock object2
            ohoh(object2)
            GC.Collect()
            'GC.WaitForPendingFinalizers()
            Console.WriteLine("OK let's release lock in Main")
        End SyncLock
        Console.WriteLine("Are we here")
    End Sub

End Module
