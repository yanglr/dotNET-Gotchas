Imports System.Collections

Module Module1

    Sub Main()
        Dim myArray() As Integer = Nothing

        Dim i As Integer
        For i = 0 To myArray.Length - 1
            Dim aValue As Integer
            aValue = myArray(i)
            'Use aValue for whatever...
        Next

        'Or we may also write 
        Dim iter As IEnumerator = myArray.GetEnumerator()
        While iter.MoveNext()
            Dim aValue As Integer = _
                Convert.ToInt32(CInt(iter.Current))
            'Use aValue for whatever…
        End While

        'And finally, we may write
        Dim theValue As Integer
        For Each theValue In myArray
            'Use theValue for whatever…
        Next
    End Sub

End Module
