Public Class MySingleton
    Public ReadOnly creationTime As DateTime

    Protected Sub New()
        creationTime = DateTime.Now
    End Sub

    Protected Shared theInstance As New MySingleton

    Public Shared Function GetInstance() As MySingleton
        Return theInstance
    End Function

End Class
