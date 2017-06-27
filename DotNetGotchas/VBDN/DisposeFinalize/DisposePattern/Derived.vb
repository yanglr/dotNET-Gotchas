'Derived.vb
Public Class Derived
    Inherits Base

    Private disposed As Boolean = False

    Public Sub New(ByVal theID As Integer)
        MyBase.New(theID)
    End Sub


    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If Not disposed Then

                If disposing Then
                    Console.WriteLine( _
                        "Derived Cleaning up managed resources")
                    ' Code to clean up managed resources
                End If

                Console.WriteLine( _
                    "Derived Cleaning up unmanaged resources")
                ' Code to clean up unmanaged resources
            End If

            disposed = True
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
End Class
