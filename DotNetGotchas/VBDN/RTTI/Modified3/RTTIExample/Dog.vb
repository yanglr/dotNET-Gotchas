'Dog.vb

Public Class Dog
    Inherits Animal

    Public Sub Bark()
        Console.WriteLine("Dog barking")
    End Sub


    Public Overrides Sub MakeNoise()
        Bark()
    End Sub

    Public Overrides Function Play(ByVal other As Animal) As Boolean
        If TypeOf other Is Dog Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
