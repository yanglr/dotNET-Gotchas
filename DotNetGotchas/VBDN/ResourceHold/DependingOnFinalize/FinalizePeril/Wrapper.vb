'Wrapper.vb

Imports ACOMCompLib

Public Class Wrapper
    Implements IDisposable
    Dim comp As IMyComp = New MyCompClass

    Public Function doSomething() As Integer
        Dim result As Integer
        comp.doSomething(result)
        Return result
    End Function

    Public Sub Dispose() Implements System.IDisposable.Dispose
        System.Runtime.InteropServices.Marshal.ReleaseComObject(comp)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(comp)
    End Sub
End Class
