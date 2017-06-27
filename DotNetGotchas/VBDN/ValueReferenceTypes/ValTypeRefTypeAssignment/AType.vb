'AType.vb
Public Class AType
    Private aField As Integer

    Public Property TheValue() As Integer
        Get
            Return aField
        End Get
        Set(ByVal Value As Integer)
            aField = Value
        End Set
    End Property
End Class
