'DerivedCar.vb

Imports System.Runtime.Serialization

<Serializable()> _
Public Class DerivedCar
    Inherits Car

    Private someValue As Integer

    Public Sub New(ByVal year As Integer, _
        ByVal anEngine As Engine, ByVal val As Integer)

        MyBase.New(year, anEngine)
        someValue = val
    End Sub

    Public Sub New( _
        ByVal info As SerializationInfo, _
        ByVal context As StreamingContext)

        MyBase.New(info, context)

        SerializationHelper.SetData( _
            GetType(DerivedCar), Me, info)
    End Sub

    Public Overrides Sub GetObjectData( _
        ByVal info As SerializationInfo, _
        ByVal context As StreamingContext)

        MyBase.GetObjectData(info, context)
        SerializationHelper.GetData(GetType(DerivedCar), Me, info)
    End Sub


    Public Overrides Function tostring() As String
        Return MyBase.ToString() & ":" & someValue
    End Function

End Class
