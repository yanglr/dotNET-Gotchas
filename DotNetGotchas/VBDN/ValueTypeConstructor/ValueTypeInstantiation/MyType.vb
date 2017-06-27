'MyType.vb

Public Structure MyType
    Private val As Integer

    Public Overrides Function ToString() As String
        Return "The value is " & val
    End Function

    'Public Sub New() ' Can't be provided
    'End Sub

    Public Sub New(ByVal initialValue As Integer)
        val = initialValue
    End Sub
End Structure
