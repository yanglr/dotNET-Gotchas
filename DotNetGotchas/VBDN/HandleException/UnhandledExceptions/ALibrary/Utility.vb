'Utility.vb part of ALibrary.dll

Public Class Utility
    Public Function Operate( _
        ByVal value1 As Integer, ByVal value2 As Integer) As Double
        'Some operation
        ' Of course, this is an enormous programming error
        ' Never do division without making sure the denominator
        ' is not zero.
        ' We’re just doing it here for the sake of example.
        Dim val As Double = value1 / value2

        If Double.IsInfinity(val) Then
            Throw New DivideByZeroException( _
                "Attempted to Divide by Zero")
        End If
        Return Math.Sqrt(val)
    End Function
End Class
