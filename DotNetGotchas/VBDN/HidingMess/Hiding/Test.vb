'Test.vb
Module Test

    Sub Main()
        Dim d As New Derived

        Dim b As Base = d

        d.Method1()
        d.method2()

        b.Method1()
        b.Method2()
    End Sub

End Module
