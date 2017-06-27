'MyComp.vb as part of ESLib.dll
Imports System.EnterpriseServices

<Transaction(TransactionOption.Required)> _
Public Class MyComp
    Inherits ServicedComponent

    Private theMessage As String = "UnSet"

    <AutoComplete()> _
    Public Sub SetInfo(ByVal msg As String)
        theMessage = msg
    End Sub

    <AutoComplete()> _
    Public Function GetInfo() As String
        Return theMessage
    End Function

End Class