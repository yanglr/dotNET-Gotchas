'SmarterBrain.vb

Public Class SmarterBrain
    Inherits Brain

    Public Sub New()

    End Sub

    Protected Sub New(ByVal another As SmarterBrain)
        MyBase.New(another)
    End Sub


    Public Overrides Function Clone() As Object
        Return New SmarterBrain(Me)
    End Function
End Class
