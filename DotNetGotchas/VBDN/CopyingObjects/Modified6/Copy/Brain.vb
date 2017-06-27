'Brain.vb
Public Class Brain
    Implements ICloneable

    Private ReadOnly id As Integer
    Private Shared idCount As Integer

    '...

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
        Dim theClone As Brain = CType(MemberwiseClone(), Brain)
        theClone.id = _
            System.Threading.Interlocked.Increment(idCount)
        Return theClone
    End Function
End Class
