'Test.vb
Module Module1

    Sub Main()
        Dim object1 As New Derived(1)
        Dim object2 As New Derived(2)

        object1.Dispose()
    End Sub

End Module
