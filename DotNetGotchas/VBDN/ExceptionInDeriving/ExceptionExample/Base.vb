'Base.vb
''' <summary>
''' A class to illustrate exception when overriding
''' </summary>
Public Class Base

    ''' <summary>
    ''' Method1 does some thing on input given.
    ''' </summary>
    ''' <param name="val">Input to work on</param>
    ''' <exception 
    ''' cref="ExceptionExample.InvalidInputException">
    ''' Thrown if parameter is less than 0.
    ''' </exception>
    Public Overridable Sub Method1(ByVal val As Integer)
        If val < 0 Then
            Throw New InvalidInputException
        End If

        ' ... rest of the code goes here
    End Sub
End Class
