'Wrapper.vb

Imports ACOMCompLib

Public Class Wrapper
    Implements IDisposable
    Dim comp As IMyComp = New MyCompClass
    Private disposed As Boolean = False

    Public Function doSomething() As Integer
        If disposed = True Then
            Throw New ObjectDisposedException(Nothing)
        End If
        Dim result As Integer
        comp.doSomething(result)
        Return result
    End Function
    Protected Overridable Sub Dispose(ByVal disposiong As Boolean)
        If Not disposed Then
            ' No managed resources to clean up
            ' Clean up unmanaged resources regardless of who called us
            System.Runtime.InteropServices.Marshal.ReleaseComObject(comp)
            GC.SuppressFinalize(Me)
            disposed = True
        End If
    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        Dispose(True)
    End Sub

    Protected Overrides Sub Finalize()
        Try
            Dispose(False)
        Finally
            MyBase.Finalize()
        End Try
    End Sub
End Class
