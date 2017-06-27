'Person.vb
Public Class Person
    Private theAge As Integer
    Private theBrain As Brain

    Public Sub New(ByVal age As Integer, ByVal aBrain As Brain)
        theAge = age
        theBrain = aBrain
    End Sub

    Public Sub New(ByVal another As Person)
        theAge = another.theAge

        If TypeOf another.theBrain Is SmarterBrain Then
            theBrain = New SmarterBrain( _
                CType(another.theBrain, SmarterBrain))
        Else
            theBrain = New Brain(another.theBrain)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return "This is person with age " & _
            theAge & " and " & _
            theBrain.ToString()
    End Function
End Class
