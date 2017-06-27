'Brain.vb
Public Class Brain
    Implements ICloneable

    Private ReadOnly id As Integer
    Private Shared idCount As Integer

    Public Sub New()
        id = System.Threading.Interlocked.Increment(idCount)
    End Sub

    Protected Sub New(ByVal another As Brain)
        id = System.Threading.Interlocked.Increment(idCount)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.GetType().Name & ":" & id
    End Function

    Public Overridable Function Clone() As Object _
        Implements System.ICloneable.Clone
        Return New Brain(Me)
    End Function
End Class
