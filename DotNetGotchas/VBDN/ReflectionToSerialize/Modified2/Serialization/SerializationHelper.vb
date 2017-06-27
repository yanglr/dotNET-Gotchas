'SerializationHelper.vb

Imports System.Runtime.Serialization
imports System.Reflection

Public Class SerializationHelper
    Public Shared Sub SetData( _
    ByVal theType As Type, ByVal instance As Object, _
    ByVal info As SerializationInfo)

        Dim enumerator As SerializationInfoEnumerator = _
            info.GetEnumerator()

        While enumerator.MoveNext()
            Dim fieldName As String = enumerator.Current.Name
            Dim theField As FieldInfo = _
                 theType.GetField(fieldName, _
                    BindingFlags.Instance Or _
                    BindingFlags.DeclaredOnly Or _
                    BindingFlags.Public Or _
                    BindingFlags.NonPublic)

            If Not theField Is Nothing Then
                theField.SetValue(instance, enumerator.Value)
            End If
        End While
    End Sub

    Public Shared Sub GetData( _
    ByVal theType As Type, ByVal instance As Object, ByVal info As SerializationInfo)

        Dim fields() As FieldInfo = theType.GetFields( _
            BindingFlags.Instance Or _
            BindingFlags.Public Or _
            BindingFlags.NonPublic)

        Dim i As Integer

        For i = 0 To fields.Length - 1
            'Do not serialize NonSerializable Fields
            If Not fields(i).IsNotSerialized Then
                info.AddValue(fields(i).Name, _
                 fields(i).GetValue(instance))
            End If
        Next
    End Sub

End Class
