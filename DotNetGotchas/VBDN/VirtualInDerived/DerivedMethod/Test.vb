'Test.vb

Public Class Test
    Shared Sub Main()
        Dim d As New Derived
        Dim b As Base = d

        d.Method1()
        b.Method1()
    End Sub
End Class
