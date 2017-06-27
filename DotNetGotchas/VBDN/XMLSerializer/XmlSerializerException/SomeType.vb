'SomeType.vb

Public Class SomeType
    Private val As Integer

    Public Property TheValue() As Integer
        Get
            Return val
        End Get
        Set(ByVal Value As Integer)
            val = Value
        End Set
    End Property
End Class