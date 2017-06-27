Imports System.Runtime.InteropServices

<Guid("74555C62-75CD-4c87-940A-4AE8A69FFCB2"), _
  InterfaceType(ComInterfaceType.InterfaceIsDual)> _
Public Interface IMy
    Sub Method1()
End Interface

<Guid("53DEF193-D7A4-4ce3-938E-A7A35B5F7AB7"), _
  ClassInterface(ClassInterfaceType.None)> _
Public Class MyComponent
    Implements IMy

    Public Sub Method1() Implements IMy.Method1

    End Sub
End Class


