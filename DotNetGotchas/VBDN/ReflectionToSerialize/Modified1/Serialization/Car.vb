'Car.vb
Imports System.Runtime.Serialization

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
        yearOfMake = info.GetInt32("yearOfMake")
        theEngine = CType(info.GetValue("theEngine", _
             GetType(Engine)), Engine)

        Try
            miles = info.GetInt32("miles")
        Catch ex As Exception
            'Shhhhh, let's move on quietly.
        End Try
    End Sub
    Public Sub GetObjectData(ByVal info As SerializationInfo, _
        ByVal context As StreamingContext) _
            Implements ISerializable.GetObjectData
        info.AddValue("yearOfMake", yearOfMake)
        info.AddValue("theEngine", theEngine)
        info.AddValue("miles", miles)
    End Sub
End Class
