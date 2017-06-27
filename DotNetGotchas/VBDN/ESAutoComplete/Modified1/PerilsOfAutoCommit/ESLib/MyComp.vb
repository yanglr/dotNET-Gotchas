'MyComp.vb as part of ESLib.dll
Imports System.EnterpriseServices

<Transaction(TransactionOption.Required)> _
Public Class MyComp
    Inherits ServicedComponent

    Private theMessage As String = "UnSet"

    '<AutoComplete()> _
    Public Sub SetInfo(ByVal msg As String)
        ContextUtil.MyTransactionVote _
            = TransactionVote.Abort

        theMessage = msg

        ' If something is wrong, throw exception 
        ' and the vote will remain in Abort.

        ContextUtil.MyTransactionVote _
            = TransactionVote.Commit
    End Sub

    '<AutoComplete()> _
    Public Function GetInfo() As String
        ContextUtil.MyTransactionVote _
            = TransactionVote.Abort

        ' If something is wrong, throw exception 
        ' and the vote will remain in Abort.

        ContextUtil.MyTransactionVote _
            = TransactionVote.Commit

        Return theMessage
    End Function

End Class