Imports System.Runtime.InteropServices

Module Module1

    Public Declare Function Beep Lib "Kernel32" ( _
        ByVal dwFreq As Long, ByVal dwDuration As Long) As Boolean

    Sub Main()
        Beep(1000, 1000)
    End Sub

End Module
