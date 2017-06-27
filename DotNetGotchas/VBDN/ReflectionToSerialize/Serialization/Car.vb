'Car.vb
Imports System.Runtime.Serialization

<Serializable()> _
Public Class Car
    Implements ISerializable

    Private yearOfMake As Integer
    Private theEngine As Engine

    Public Sub New(ByVal year As Integer, ByVal anEngine As Engine)
        yearOfMake = year
        theEngine = anEngine
    End Sub

    Public Overrides Function ToString() As String
        Return yearOfMake & ":" & theEngine.ToString()
    End Function

    Public Sub New( _
        ByVal info As SerializationInfo, _
        ByVal context As StreamingContext)
        yearOfMake = info.GetInt32("yearOfMake")
        theEngine = CType(info.GetValue("theEngine", _
             GetType(Engine)), Engine)
    End Sub
    Public Sub GetObjectData(ByVal info As SerializationInfo, _
        ByVal context As StreamingContext) _
            Implements ISerializable.GetObjectData
        info.AddValue("yearOfMake", yearOfMake)
        info.AddValue("theEngine", theEngine)
    End Sub
End Class
