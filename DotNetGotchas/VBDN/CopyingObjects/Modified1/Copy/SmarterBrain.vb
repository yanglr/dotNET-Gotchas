'SmarterBrain.vb

Public Class SmarterBrain
    Inherits Brain


    Public Sub New()

    End Sub

    Public Sub New(ByVal another As SmarterBrain)
        MyBase.New(another)
    End Sub
End Class
