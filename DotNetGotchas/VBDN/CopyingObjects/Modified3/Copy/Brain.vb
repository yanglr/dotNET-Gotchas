'Brain.vb
Public Class Brain
    Implements ICloneable

    Public Sub New()

    End Sub

    Public Sub New(ByVal another As Brain)
        ' Code to properly copy Brain can go here
    End Sub

    Public Overrides Function ToString() As String
        Return Me.GetType().Name & ":" & GetHashCode()
    End Function

    '...
    Public Function Clone() As Object _
        Implements System.ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Class
