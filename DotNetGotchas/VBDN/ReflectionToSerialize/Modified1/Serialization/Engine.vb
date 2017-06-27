'Engine.vb
<Serializable()> _
Public Class Engine
    Private power As Integer

    Public Sub New(ByVal thePower As Integer)
        power = thePower
    End Sub

    Public Overrides Function ToString() As String
        Return power.ToString()
    End Function
End Class
