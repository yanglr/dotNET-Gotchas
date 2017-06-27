' Factory.vb part of ESLib.dll
Imports System.EnterpriseServices

Public Interface ITransactionCoordinator
    Sub SetVoteToAbort()
End Interface

<Transaction(TransactionOption.Required), JustInTimeActivation()> _
Public Class Factory
    Inherits ServicedComponent
    Implements ITransactionCoordinator

    Public Function CreateComp(ByVal key As Integer) As Comp
        ContextUtil.MyTransactionVote = TransactionVote.Abort

        Dim theComp As New Comp

        theComp.TheTransactionCoordinator = Me

        theCOmp.init(key)

        ContextUtil.MyTransactionVote = TransactionVote.Commit

        Return theCOmp
    End Function
    Protected Overloads Overrides Sub Dispose( _
        ByVal disposing As Boolean)
        If disposing Then
            ContextUtil.DeactivateOnReturn = True
        End If

        MyBase.Dispose(disposing)
    End Sub

    Public Sub SetVoteToAbort() _
        Implements ITransactionCoordinator.SetVoteToAbort
        ContextUtil.MyTransactionVote() = TransactionVote.Abort
    End Sub
End Class
