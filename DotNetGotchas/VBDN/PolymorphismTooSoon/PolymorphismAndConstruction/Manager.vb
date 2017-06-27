'Manager.vb
Public Class Manager
    Inherits Employee
    Private theRoom As Room = Nothing
    Private managementLevel As Integer = 0

    Public Sub New(ByVal level As Integer)
        Console.WriteLine("Manager's constructor called")

        managementLevel = level

        If level < 2 Then
            theRoom = New Room
        Else
            theRoom = New ExecutiveRoom
        End If
    End Sub
    Public Overrides Sub Work()
        Console.WriteLine("Manager's work called")

        theRoom.OpenWindow()
        MyBase.Work()
    End Sub
End Class