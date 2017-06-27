'Person.vb
Public Class Person
    Implements ICloneable

    Private theAge As Integer
    Private theBrain As Brain

    Public Sub New(ByVal age As Integer, ByVal aBrain As Brain)
        theAge = age
        theBrain = aBrain
    End Sub

    Protected Sub New(ByVal another As Person)
        theAge = another.theAge

        theBrain = CType(another.theBrain.Clone(), Brain)
    End Sub

    Public Overrides Function ToString() As String
        Return "This is person with age " & _
            theAge & " and " & _
            theBrain.ToString()
    End Function

    Public Overridable Function Clone() As Object _
        Implements System.ICloneable.Clone
        Return New Person(Me)
    End Function
End Class
