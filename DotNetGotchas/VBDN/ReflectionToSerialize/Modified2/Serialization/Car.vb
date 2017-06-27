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

        SerializationHelper.SetData(GetType(Car), Me, info)
    End Sub

    Public Overridable Sub GetObjectData(ByVal info As SerializationInfo, _
        ByVal context As StreamingContext) _
            Implements ISerializable.GetObjectData

        SerializationHelper.GetData(GetType(Car), Me, info)
    End Sub
End Class
