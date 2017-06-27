'Brain.vb
Public Class Brain
    Implements ICloneable

    Private id As Integer
    Private Shared idCount As Integer

    Public Sub New()
        id = System.Threading.Interlocked.Increment(idCount)
    End Sub

    Public Sub New(ByVal another As Brain)
        ' Code to properly copy Brain can go here
    End Sub

    Public Overrides Function ToString() As String
        Return Me.GetType().Name & ":" & id
    End Function

    Public Function Clone() As Object _
        Implements System.ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Class
