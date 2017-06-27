Structure A
    Public val As Integer
End Structure

Class Test
    Private theA As A

    Public Sub New()
        theA = New A
    End Sub

    Public Property MyValue() As A
        Get
            Return theA
        End Get
        Set(ByVal Value As A)
            theA = Value
        End Set
    End Property

    '...
    Public Shared Sub Main()
        Dim obj As New Test

        obj.MyValue.val = 4

        Console.WriteLine(obj.MyValue.val)
    End Sub
End Class
