''' <summary>
''' A Derived class that violates LSP.
''' </summary>
Public Class Derived
    Inherits Base

    ''' <summary>
    ''' Method1 does something with input
    ''' </summary>
    ''' <param name="val">val to work with</param>
    ''' <exception cref="InvalidInputException">
    ''' thrown if parameter is 0
    ''' </exception>
    ''' <exception cref="InputMustBeEvenException">
    ''' thrown if parameter is not even
    ''' </exception>
    Public Overrides Sub Method1(ByVal val As Integer)
        If Not val Mod 2 = 0 Then
            'Not an even number
            Throw New InputMustBeEvenException
        End If


        MyBase.Method1(val)
        'Continue with rest of the code		
    End Sub

End Class