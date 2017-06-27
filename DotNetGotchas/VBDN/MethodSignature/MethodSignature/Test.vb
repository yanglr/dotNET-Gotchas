'Test.vb
Module Test

    Sub Main()
        Dim d As New Derived
        Dim b As Base = d

        ' b and d refer to the same object now.
        b.Method1(3)
        d.Method1(3)
    End Sub

End Module
