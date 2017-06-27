'Base.vb

Public Class Base
    Implements IDisposable
    Private disposed As Boolean = False
    Private ReadOnly id As Integer

    Public Sub New(ByVal theID As Integer)
        id = theID
    End Sub

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not disposed Then
            If disposing Then
                Console.WriteLine( _
                    "Base Cleaning up managed resources on {0}", _
                    id)

                ' Code to clean up managed resources
            End If
            Console.WriteLine( _
             "Base Cleaning up unmanaged resources on {0}", id)

            ' Code to clean up unmanaged resources

        End If

        disposed = True
    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Console.WriteLine("*** Finalize called on Base {0}", id)
        Dispose(False)
    End Sub
End Class