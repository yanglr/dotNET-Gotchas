'Car.vb
Imports System.Runtime.Serialization
Imports System.Reflection

<Serializable()> _
Public Class Car
    Implements ISerializable

    Private yearOfMake As Integer
    Private theEngine As Engine
    Private miles As Integer = 0

    Public Sub New(ByVal year As Integer, ByVal anEngine As Engine)
        yearOfMake = year
        theEngine = anEngine
    End Sub

    Public Overrides Function ToString() As String
        Return yearOfMake & ":" & miles & ":" & theEngine.ToString()
    End Function

    Public Sub New( _
        ByVal info As SerializationInfo, _
        ByVal context As StreamingContext)

        Dim enumerator As SerializationInfoEnumerator = _
            info.GetEnumerator()

        While enumerator.MoveNext()
            Dim fieldName As String = enumerator.Current.Name
            Dim theField As FieldInfo = _
                 GetType(Car).GetField(fieldName, _
                    BindingFlags.Instance Or _
                    BindingFlags.DeclaredOnly Or _
                    BindingFlags.Public Or _
                    BindingFlags.NonPublic)

            If Not theField Is Nothing Then
                theField.SetValue(Me, enumerator.Value)
            End If
        End While
    End Sub

    Public Overridable Sub GetObjectData(ByVal info As SerializationInfo, _
        ByVal context As StreamingContext) _
            Implements ISerializable.GetObjectData

        Dim fields() As FieldInfo = GetType(Car).GetFields( _
                BindingFlags.Instance Or _
    BindingFlags.DeclaredOnly Or _
    BindingFlags.Public Or _
    BindingFlags.NonPublic)

        Dim i As Integer

        For i = 0 To fields.Length - 1
            'Do not serialize NonSerializable Fields
            If Not fields(i).IsNotSerialized Then
                info.AddValue(fields(i).Name, _
                 fields(i).GetValue(Me))
            End If
        Next
    End Sub
End Class
